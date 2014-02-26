using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.Office.Interop.Word;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Xml;

namespace gzf
{
    public partial class openPersonFrom : Form
    {
        private model.House house;
        private string imagePath = "";
        private int result = 100;

        public openPersonFrom(model.House house)
        {   
            InitializeComponent();
            this.house = house;
        }

        private void openPersonFrom_Load(object sender, EventArgs e)
        {
            string status = DB.selectScalar("select status from gzf_house where id=" + house.id);
            if (status == "0")
            {
                MessageBox.Show("此房间已被占用！");
                this.Close();
            }
            DataTable dt = DB.select("select * from gzf_building where id=" + house.building_id);
            spinEditMoney.Value = house.price;
            spinEditDeposit.Value = house.price;
            lblSn.Text = house.sn;
            lblBuilding.Text = dt.Rows[0]["name"].ToString();
            comboBoxSex.SelectedIndex = 0;
            comboBoxSex2.SelectedIndex = 0;
            comboBoxPayMethod.SelectedIndex = 0;
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(0);
            foreach (DictionaryEntry de in kind.statusTable)
            {
                comboBoxKind.Items.Add(de);
            }
            comboBoxKind.ValueMember = "Key";
            comboBoxKind.DisplayMember = "Value";
            comboBoxKind.SelectedIndex = 5;

            comboBoxCompany.DataSource = common.getCompany();
            comboBoxCompany.DisplayMember = "name";
            comboBoxCompany.SelectedItem = null;
            comboBoxCompany2.DataSource = common.getCompany();
            comboBoxCompany2.DisplayMember = "name";
            comboBoxCompany2.SelectedItem = null;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            //if (spinEditDeposit.Value == 0)
            //{
            //    MessageBox.Show("请填写押金！");
            //    return;
            //}
            if (txtDipositSN.Text == "")
            {
                MessageBox.Show("请填写押金单号！");
                return;
            }
            if (txtFapiao.Text == "")
            {
                MessageBox.Show("请填写发票号！");
                return;
            }
            if (chkDay.Checked)
            {
                if (payDay.Value == 0)
                {
                    MessageBox.Show("请填写预付天数！");
                    return;
                }
            }
            else
            {
                if (payMonth.Value == 0)
                {
                    MessageBox.Show("请填写预付月数！");
                    return;
                }
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("请选择开始时间！");
                return;
            }
            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("请选择结束时间！");
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请填写客户姓名！");
                return;
            }
            if (txtIDCard.Text.Trim() == "")
            {
                MessageBox.Show("请填写身份证号码！");
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("请填写手机号码！");
                return;
            }
            decimal money = 0;
            if (chkDay.Checked)
            {
                money = spinEditDay.Value;
            }
            else
            {
                money = spinEditMoney.Value * payMonth.Value;
            }
            if (spinEditCash.Value + spinEditCride.Value + spinEditOther.Value != money)
            {
                MessageBox.Show("请检查现金、信用卡、其他是否与总金额一致");
                return;
            }
            string count = DB.selectScalar("select count(*) from gzf_payment where fapiao='" + txtFapiao.Text + "'");
            if (count != "0")
            {
                if (MessageBox.Show("发票号码已存在,是否继续操作?", "确认发票号码", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            Byte[] bytes = new Byte[0];
            //if (lblStatus.Text == "读卡成功！")
            //{
            string path = Path.GetTempFileName() + ".bmp";
            FileStream fs;
            if (result != 0)
            {
                Bitmap bitmap1 = new Bitmap(pictureBox1.Image);
                bitmap1.Save(path);
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            else
            {
                fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            }
            bytes = new Byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
            //}
            string cmd = "insert into gzf_guest values ('" + txtName.Text + "','" + txtIDCard.Text + "','" + dateBirthday.Value.ToString() + "'," + comboBoxSex.SelectedIndex + ",'" + txtPhone.Text + "','" + txtAdress.Text + "','" + txtRemark.Text + "','" + comboBoxJob.Text + "','" + comboBoxCompany.Text + "', @Picture," + house.id + ",0,'" + txtStudent.Text + "')";
            string guestid = DB.exec_insertLastID(cmd,bytes);
            string cmdOpen = "insert into gzf_openhouse (building_id,house_id,start_time,end_time,guest_num,price,user_id,main_guest_id,deposit,deposit_sn,remark,fapiao,pay_method,kind,wuye) values (" + house.building_id + "," + house.id + ",'" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "',1," + Convert.ToInt32(spinEditMoney.Value) + "," + common.User.id + "," + guestid + "," + Convert.ToInt32(spinEditDeposit.Value) + ",'" + txtDipositSN.Text + "','" + txtHouseRemark.Text + "','" + txtFapiao.Text + "'," + (comboBoxPayMethod.SelectedIndex + 1) + ", " + ((DictionaryEntry)comboBoxKind.SelectedItem).Key +", " + txtWuye.Value + ")";
            string openhouseid = DB.exec_insertLastID(cmdOpen);
            if (openhouseid != "")
            {
                DB.exec_NonQuery("update gzf_guest set openhouse_id=" + openhouseid + " where id=" + guestid);
                //插入副客信息
                if (txtIDCard2.Text.Trim() != "" && txtName2.Text.Trim() !="")
                {
                    //读取头像
                    string path2 = Path.GetTempFileName() + ".bmp";
                    Bitmap bitmap = new Bitmap(pictureBox2.Image);
                    bitmap.Save(path2);
                    FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read);
                    Byte[] bytes2 = new Byte[fs2.Length];
                    fs2.Read(bytes2, 0, bytes2.Length);
                    fs2.Close();
                    //插入数据库
                    DB.exec_insertLastID("insert into gzf_guest values ('" + txtName2.Text + "','" + txtIDCard2.Text + "','" + dateBirthday2.Value.ToString() + "'," + comboBoxSex2.SelectedIndex + ",'" + txtPhone2.Text + "','" + txtAdress2.Text + "','" + txtRemark2.Text + "','" + comboBoxJob2.Text + "','" + comboBoxCompany2.Text + "', @Picture," + house.id + "," + openhouseid + ",'" + txtStudent2.Text + "')", bytes2);
                }
                //if (((DictionaryEntry)comboBoxKind.SelectedItem).Key.ToString() == "4")
                //{
                    //DB.exec_NonQuery("update gzf_house set status=6 where id=" + house.id);
                //}
                //else
                //{
                    DB.exec_NonQuery("update gzf_house set status=0 where id=" + house.id);
                //}
                if(chkDay.Checked)
                {
                    DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao,pay_method,cash,credit,other) values (" + openhouseid + ", 0," + spinEditDay.Value + "," + house.id + "," + common.User.id + "," + payDay.Value + ",'" + dateTimePicker3.Text + "','" + dateTimePicker4.Text + "','" + txtFapiao.Text + "'," + (comboBoxPayMethod.SelectedIndex+1) + "," + spinEditCash.Value + "," + spinEditCride.Value + "," + spinEditOther.Value + ")");
                }
                else
                {
                    if (payMonth.Value > 0)
                    {
                        DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao,pay_method,cash,credit,other) values (" + openhouseid + "," + payMonth.Value + "," + (Convert.ToInt32(spinEditMoney.Value) * payMonth.Value) + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker3.Text + "','" + dateTimePicker4.Text + "','" + txtFapiao.Text + "'," + (comboBoxPayMethod.SelectedIndex + 1) + "," + spinEditCash.Value + "," + spinEditCride.Value + "," + spinEditOther.Value + ")");
                    }
                }
                MessageBox.Show("开单成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("开单失败！");
            }

        }

        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDay.Checked)
            {
                panelDay.Enabled = true;
                panelMonth.Enabled = false;
            }
            else
            {
                panelDay.Enabled = false;
                panelMonth.Enabled = true;
            }
        }

        private void btnClipBorad_Click(object sender, EventArgs e)
        {
            Bitmap image = common.getClipBordImage();
            if(image.Width != 1)
            {
                pictureBox1.Image = image;
            }
        }

        private void btnClipBorad2_Click(object sender, EventArgs e)
        {
            Bitmap image = common.getClipBordImage();
            if (image.Width != 1)
            {
                pictureBox2.Image = image;
            }
        }

        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCard.Text.Trim().Length == 18)
            {
                string identityCard = txtIDCard.Text.Trim();
                dateBirthday.Text = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                int sexnum = Convert.ToInt32(identityCard.Substring(16, 1));
                if (sexnum % 2 == 0)
                {
                    comboBoxSex.SelectedIndex = 1;
                }
                else
                {
                    comboBoxSex.SelectedIndex = 0;
                }
            }
        }

        private void txtIDCard2_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCard2.Text.Trim().Length == 18)
            {
                string identityCard = txtIDCard2.Text.Trim();
                dateBirthday2.Text = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
                int sexnum = Convert.ToInt32(identityCard.Substring(16, 1));
                if (sexnum % 2 == 0)
                {
                    comboBoxSex2.SelectedIndex = 1;
                }
                else
                {
                    comboBoxSex2.SelectedIndex = 0;
                }
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            Card2.PERSONINFOW person = new Card2.PERSONINFOW();
            int OpenResult = Card2.OpenCardReader(0, 0x04, 115200);
            if (OpenResult == 0)
            {
                imagePath = Path.GetTempPath() + "images.bmp";
                lblStatus.Text = "身份证读卡器已就绪...";
                try
                {
                    result = Card2.GetPersonMsgW(ref person, imagePath);
                }
                catch
                {
                    lblStatus.Text = "身份证读取失败,请重新尝试";
                    Card2.CloseCardReader();
                }
                if (result == 0)
                {
                    txtName.Text = person.name;
                    txtIDCard.Text = person.cardId;
                    txtAdress.Text = person.address;
                    if (person.sex == "男")
                    {
                        comboBoxSex.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxSex.SelectedIndex = 1;
                    }
                    dateBirthday.Value = Convert.ToDateTime(common.ConvertDate(person.birthday));
                    FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                    sr.Read();
                    pictureBox1.Image = new Bitmap(fs);
                    sr.Close();
                    lblStatus.Text = "读卡成功！";
                    Card2.CloseCardReader();
                }

            }
            else
            {
                lblStatus.Text = "身份证读卡器连接失败！";
            }
        }

        private void btn_read2_Click(object sender, EventArgs e)
        {
            Card2.PERSONINFOW person = new Card2.PERSONINFOW();
            int OpenResult = Card2.OpenCardReader(0, 0x04, 115200);
            if (OpenResult == 0)
            {
                imagePath = Path.GetTempPath() + "images2.bmp";
                lblStatus2.Text = "身份证读卡器已就绪...";
                try
                {
                    result = Card2.GetPersonMsgW(ref person, imagePath);
                }
                catch
                {
                    lblStatus2.Text = "身份证读取失败,请重新尝试";
                    Card2.CloseCardReader();
                }
                if (result == 0)
                {
                    txtName2.Text = person.name;
                    txtIDCard2.Text = person.cardId;
                    txtAdress2.Text = person.address;
                    if (person.sex == "男")
                    {
                        comboBoxSex2.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxSex2.SelectedIndex = 1;
                    }
                    dateBirthday2.Value = Convert.ToDateTime(common.ConvertDate(person.birthday));
                    FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                    sr.Read();
                    pictureBox2.Image = new Bitmap(fs);
                    sr.Close();
                    lblStatus2.Text = "读卡成功！";
                    Card2.CloseCardReader();
                }

            }
            else
            {
                lblStatus2.Text = "身份证读卡器连接失败！";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Value = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Value = dateTimePicker2.Value;
        }

        private void spinEditDeposit_Click(object sender, EventArgs e)
        {
            spinEditDeposit.Select(0, 10);
        }

        private void payMonth_Click(object sender, EventArgs e)
        {
            payMonth.Select(0, 10);
        }

        private void txtWuye_Click(object sender, EventArgs e)
        {
            txtWuye.Select(0, 10);
        }

        private void btn_xieyi_Click(object sender, EventArgs e)
        {
            //if (spinEditDeposit.Value == 0)
            //{
            //    MessageBox.Show("请填写押金！");
            //    return;
            //}
            if (txtFapiao.Text == "")
            {
                MessageBox.Show("请填写发票号！");
                return;
            }
            string count = DB.selectScalar("select count(*) from gzf_payment where fapiao='" + txtFapiao.Text + "'");
            if (count != "0")
            {
                MessageBox.Show("发票号码已存在，请检查！");
                return;
            }
            crystalReportViewer1_Click(sender, e);
            crystalReportViewer1.PrintReport();
        }

        private bool clearZero(int bit)
        {
            int desposit = Convert.ToInt32(spinEditDeposit.Value);
            if (bit > desposit)
            {
                return false;
            }
            return true;
        }

        private void crystalReportViewer1_Click(object sender, EventArgs e)
        {
            
            ReportDocument repostDoc = new ReportDocument();
            repostDoc.Load("xieyi.rpt");
            repostDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            ParameterFields paramFields = new ParameterFields();
            
            //加载打印
            try
            {
                int desposit = Convert.ToInt32(spinEditDeposit.Value);
                string name=" ";
                if (txtName2.Text.Trim() == "")
                {
                    name = txtName.Text;
                }
                else
                {
                    name = txtName.Text + "、" + txtName2.Text;
                }
                ParameterField paramField = new ParameterField();
                paramField.Name = "name";
                ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
                discreteVal.Value = name;
                paramField.CurrentValues.Add(discreteVal);

                ParameterField paramField2 = new ParameterField();
                paramField2.Name = "start_time";
                ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();
                discreteVal2.Value = dateTimePicker1.Value.ToString("yyyy   MM   dd");
                paramField2.CurrentValues.Add(discreteVal2);

                ParameterField paramField3 = new ParameterField();
                paramField3.Name = "end_time";
                ParameterDiscreteValue discreteVal3 = new ParameterDiscreteValue();
                discreteVal3.Value = dateTimePicker2.Value.ToString("yyyy   MM   dd");
                paramField3.CurrentValues.Add(discreteVal3);

                ParameterField paramField4 = new ParameterField();
                paramField4.Name = "building";
                ParameterDiscreteValue discreteVal4 = new ParameterDiscreteValue();
                discreteVal4.Value = lblBuilding.Text.Replace("号楼", "");
                paramField4.CurrentValues.Add(discreteVal4);

                ParameterField paramField5 = new ParameterField();
                paramField5.Name = "sn";
                ParameterDiscreteValue discreteVal5 = new ParameterDiscreteValue();
                discreteVal5.Value = lblSn.Text;
                paramField5.CurrentValues.Add(discreteVal5);

                ParameterField paramField6 = new ParameterField();
                paramField6.Name = "price";
                ParameterDiscreteValue discreteVal6 = new ParameterDiscreteValue();
                discreteVal6.Value = spinEditMoney.Value.ToString();
                paramField6.CurrentValues.Add(discreteVal6);

                ParameterField paramField7 = new ParameterField();
                paramField7.Name = "yj";
                ParameterDiscreteValue discreteVal7 = new ParameterDiscreteValue();
                discreteVal7.Value = spinEditDeposit.Value.ToString();
                paramField7.CurrentValues.Add(discreteVal7);

                ParameterField paramField8 = new ParameterField();
                paramField8.Name = "add_time";
                ParameterDiscreteValue discreteVal8 = new ParameterDiscreteValue();
                discreteVal8.Value = DateTime.Now.ToString("yyyy   MM   dd");
                paramField8.CurrentValues.Add(discreteVal8);

                ParameterField paramField9 = new ParameterField();
                paramField9.Name = "yj_daxie";
                ParameterDiscreteValue discreteVal9 = new ParameterDiscreteValue();
                discreteVal9.Value = common.DaXie(spinEditDeposit.Value.ToString());
                paramField9.CurrentValues.Add(discreteVal9);

                ParameterField paramField10 = new ParameterField();
                paramField10.Name = "shiwan";
                ParameterDiscreteValue discreteVal10 = new ParameterDiscreteValue();
                discreteVal10.Value = clearZero(100000) ? (desposit / 100000).ToString() : "";
                paramField10.CurrentValues.Add(discreteVal10);

                ParameterField paramField11 = new ParameterField();
                paramField11.Name = "wan";
                ParameterDiscreteValue discreteVal11 = new ParameterDiscreteValue();
                discreteVal11.Value = clearZero(10000) ? ((desposit % 100000) / 10000).ToString() : "";
                paramField11.CurrentValues.Add(discreteVal11);

                ParameterField paramField12 = new ParameterField();
                paramField12.Name = "qian";
                ParameterDiscreteValue discreteVal12 = new ParameterDiscreteValue();
                discreteVal12.Value = clearZero(1000) ? ((desposit % 10000) / 1000).ToString() : "";
                paramField12.CurrentValues.Add(discreteVal12);

                ParameterField paramField13 = new ParameterField();
                paramField13.Name = "bai";
                ParameterDiscreteValue discreteVal13 = new ParameterDiscreteValue();
                discreteVal13.Value = clearZero(100) ? ((desposit % 1000) / 100).ToString() : "";
                paramField13.CurrentValues.Add(discreteVal13);

                ParameterField paramField14 = new ParameterField();
                paramField14.Name = "ge";
                ParameterDiscreteValue discreteVal14 = new ParameterDiscreteValue();
                discreteVal14.Value = (desposit % 10).ToString(); ;
                paramField14.CurrentValues.Add(discreteVal14);

                ParameterField paramField15 = new ParameterField();
                paramField15.Name = "shi";
                ParameterDiscreteValue discreteVal15 = new ParameterDiscreteValue();
                discreteVal15.Value = clearZero(10) ? ((desposit % 100) / 10).ToString() : "";
                paramField15.CurrentValues.Add(discreteVal15);

                string company = " ";
                if (comboBoxCompany.SelectedItem != null)
                {
                    company = "(" + comboBoxCompany.Text + ")";
                }
                ParameterField paramField16 = new ParameterField();
                paramField16.Name = "company";
                ParameterDiscreteValue discreteVal16 = new ParameterDiscreteValue();
                discreteVal16.Value =  company;
                paramField16.CurrentValues.Add(discreteVal16);

                ParameterField paramField17 = new ParameterField();
                paramField17.Name = "buildingsn";
                ParameterDiscreteValue discreteVal17 = new ParameterDiscreteValue();
                discreteVal17.Value = lblBuilding.Text.Replace("号楼", "#") + house.sn;
                paramField17.CurrentValues.Add(discreteVal17);

                paramFields.Add(paramField);
                paramFields.Add(paramField2);
                paramFields.Add(paramField3);
                paramFields.Add(paramField4);
                paramFields.Add(paramField5);
                paramFields.Add(paramField6);
                paramFields.Add(paramField7);
                paramFields.Add(paramField8);
                paramFields.Add(paramField9);
                paramFields.Add(paramField10);
                paramFields.Add(paramField11);
                paramFields.Add(paramField12);
                paramFields.Add(paramField13);
                paramFields.Add(paramField14);
                paramFields.Add(paramField15);
                paramFields.Add(paramField16);
                paramFields.Add(paramField17);

            }
            catch { }
            finally
            {
                crystalReportViewer1.ParameterFieldInfo = paramFields;
                crystalReportViewer1.ReportSource = repostDoc;
            }
        }

        private void payMonth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(Convert.ToInt32(payMonth.Value)).AddDays(-1);
        }

        private void spinEditDay_ValueChanged(object sender, EventArgs e)
        {
            //spinEditCash.Value = spinEditDay.Value;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spinEditCash.Value = spinEditMoney.Value * payMonth.Value;
            spinEditCride.Value = 0;
            spinEditOther.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spinEditCride.Value = spinEditMoney.Value * payMonth.Value;
            spinEditCash.Value = 0;
            spinEditOther.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spinEditCride.Value = 0;
            spinEditCash.Value = 0;
            spinEditOther.Value = spinEditMoney.Value * payMonth.Value;
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            editCompanyForm company = new editCompanyForm();
            company.ShowDialog();
            comboBoxCompany.DataSource = common.getCompany();
            comboBoxCompany.DisplayMember = "name";
            comboBoxCompany.SelectedItem = null;
            comboBoxCompany2.DataSource = common.getCompany();
            comboBoxCompany2.DisplayMember = "name";
            comboBoxCompany2.SelectedItem = null;
        }

        private void payDay_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(Convert.ToInt32(payDay.Value));
        }

        private void spinEditMoney_ValueChanged(object sender, EventArgs e)
        {
            spinEditDeposit.Value = spinEditMoney.Value;
        }

        private void openPersonFrom_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        protected override void WndProc(ref Message msg)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                // 点击winform右上关闭按钮 
                // 加入想要的逻辑处理
                if (txtName.Text.Trim() != "")
                {
                    if (MessageBox.Show("窗口存在开单信息，确认关闭吗?", "确认信息", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            base.WndProc(ref msg);
        }




    }
}
