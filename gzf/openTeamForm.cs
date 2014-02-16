using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace gzf
{
    public partial class openTeamForm : Form
    {
        private string imagePath = "";
        int result = 100;
        public openTeamForm()
        {
            InitializeComponent();
            listBoxHouse.DisplayMember = "text";
            listBoxHouse.ValueMember = "key";
            comboBoxSex.SelectedIndex = 0;
        }

        private void openTeamForm_Load(object sender, EventArgs e)
        {
            DataTable buildDT = DB.select("select * from gzf_building");
            foreach (DataRow dr in buildDT.Rows)
            {
                treeView1.Nodes.Add(dr["id"].ToString(), dr["name"].ToString());
                DataTable houseDT = DB.select("select * from gzf_house where building_id=" + dr["id"].ToString() + " and status=1 order by sn");
                foreach (DataRow dr2 in houseDT.Rows)
                {
                    treeView1.Nodes[dr["id"].ToString()].Nodes.Add(dr2["id"].ToString(), dr2["sn"].ToString());
                    treeView1.Nodes[dr["id"].ToString()].Nodes[dr2["id"].ToString()].Tag = dr2["building_id"].ToString();
                }
            }
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(0);
            foreach (DictionaryEntry de in kind.statusTable)
            {
                comboBoxKind.Items.Add(de);
            }
            comboBoxKind.ValueMember = "Key";
            comboBoxKind.DisplayMember = "Value";
            comboBoxKind.SelectedIndex = 4;
            comboBoxCompany.DataSource = common.getCompany();
            comboBoxCompany.DisplayMember = "name";
            comboBoxCompany.SelectedItem = null;
            comboBoxCompany2.DataSource = common.getCompany();
            comboBoxCompany2.DisplayMember = "name";
            comboBoxCompany2.SelectedItem = null;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btn_right_Click(sender, e);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                return;
            }
            TreeNode tn = treeView1.SelectedNode;
            if (tn.Text.Contains("号楼"))
            {
                return;
            }
            
            listBoxHouse.Items.Add(tn);
            tn.Remove();
            loadSN();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (listBoxHouse.SelectedItem == null)
            {
                return;
            }
            TreeNode tn = (TreeNode)listBoxHouse.SelectedItem;
            listBoxHouse.Items.Remove(tn);
            treeView1.Nodes[tn.Tag.ToString()].Nodes.Add(tn);
            loadSN();
        }

        private void loadSN()
        {
            if (listBoxHouse.Items.Count != 0)
            {
                lblSn.Text = ((TreeNode)listBoxHouse.Items[0]).Text;
            }
            else
            {
                lblSn.Text = "";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            //开单
            if (listBoxHouse.Items.Count == 0)
            {
                MessageBox.Show("还没有选择房屋！");
                return;
            }
            if (dateEditStart.Text == "")
            {
                MessageBox.Show("请选择开始时间！");
                return;
            }
            if (dateEditEnd.Text == "")
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
            if (spinEditCash.Value + spinEditCride.Value + spinEditOther.Value != spinEditMoney.Value)
            {
                MessageBox.Show("请检查现金、信用卡、其他是否与总金额一致");
                return;
            }
            Byte[] bytes = new Byte[0];
            //if (lblStatus.Text == "读卡成功！")
            //{
            string path = Path.GetTempFileName() + ".bmp";
            FileStream fs;
            if (result == 100)
            {
                pictureBox1.Image.Save(path);
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
            //插入主客户
            string guestcmd = "insert into gzf_guest values ('" + txtName.Text + "','" + txtIDCard.Text + "','" + dateBirthday.Value + "'," + comboBoxSex.SelectedIndex + ",'" + txtPhone.Text + "','" + txtAdress.Text + "','" + txtRemark.Text + "','" + comboBoxJob.Text + "','" + comboBoxCompany.Text + "', @Picture," + ((TreeNode)listBoxHouse.Items[0]).Name + ",0,'" + txtStudent.Text + "')";
            string guestid = DB.exec_insertLastID(guestcmd, bytes);
            model.House house = new gzf.model.House();
            //插入开房表
            string price = DB.selectScalar("select price from gzf_house where id=" + ((TreeNode)listBoxHouse.Items[0]).Name);
            string openid = DB.exec_insertLastID("insert into gzf_openhouse (building_id,house_id,start_time,end_time,guest_num,user_id,main_guest_id,deposit,deposit_sn,is_team,kind,wuye,remark,price) values (" + ((TreeNode)listBoxHouse.Items[0]).Tag.ToString() + "," + ((TreeNode)listBoxHouse.Items[0]).Name + ",'" + dateEditStart.Text + "','" + dateEditEnd.Text + "',1," + common.User.id + "," + guestid + "," + Convert.ToInt32(spinEditDeposit.Value) + ",'" + txtDipositSN.Text + "',1" + ", " + ((DictionaryEntry)comboBoxKind.SelectedItem).Key + ", " + txtWuye.Value + ",'" + txtRemark.Text + "'," + price + ")");
            DB.exec_NonQuery("update gzf_openhouse set is_team=" + openid + " where id=" + openid);
            DB.exec_NonQuery("update gzf_guest set openhouse_id=" + openid + " where id=" + guestid);
            //插入副客信息
            if (txtIDCard2.Text.Trim() != "" && txtName2.Text.Trim() != "")
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
                DB.exec_insertLastID("insert into gzf_guest values ('" + txtName2.Text + "','" + txtIDCard2.Text + "','" + dateBirthday2.Value.ToString() + "'," + comboBoxSex2.SelectedIndex + ",'" + txtPhone2.Text + "','" + txtAdress2.Text + "','" + txtRemark2.Text + "','" + comboBoxJob2.Text + "','" + comboBoxCompany2.Text + "', @Picture," + ((TreeNode)listBoxHouse.Items[0]).Name + "," + openid + ",'" + txtStudent2.Text + "')", bytes2);
            }
            //插入附属房
            foreach (TreeNode tn in listBoxHouse.Items)
            {
                if (tn != (TreeNode)listBoxHouse.Items[0])
                {
                    price = DB.selectScalar("select price from gzf_house where id=" + tn.Name.ToString());
                    //DB.exec_NonQuery("insert into gzf_teamopenhouse (openhouse_id,house_id,building_id) values (" + openid + "," + tn.Name.ToString() + "," + tn.Tag.ToString() + ")");
                    DB.exec_NonQuery("insert into gzf_openhouse (building_id,house_id,start_time,end_time,guest_num,user_id,main_guest_id,is_team,kind,wuye,remark,price,deposit) values (" + tn.Tag.ToString() + "," + tn.Name.ToString() + ",'" + dateEditStart.Text + "','" + dateEditEnd.Text + "',1," + common.User.id + "," + guestid + "," + openid + ", " + ((DictionaryEntry)comboBoxKind.SelectedItem).Key + ", " + txtWuye.Value + ",'" + txtRemark.Text + "'," + price + ",0)");
                }
                //if (((DictionaryEntry)comboBoxKind.SelectedItem).Key.ToString() == "4")
                //{
                    //DB.exec_NonQuery("update gzf_house set status=6 where id=" + tn.Name.ToString());
                //}
                //else
                //{
                    DB.exec_NonQuery("update gzf_house set status=0 where id=" + tn.Name.ToString());
                //}
            }
            if (payMonth.Value > 0)
            {
                DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao,cash,credit,other) values (" + openid + "," + payMonth.Value + "," + Convert.ToInt32(spinEditMoney.Value) + "," + ((TreeNode)listBoxHouse.Items[0]).Name + "," + common.User.id + ", 0,'" + dateTimePicker3.Text + "','" + dateTimePicker4.Text + "','" + txtFapiao.Text + "'" + "," + spinEditCash.Value + "," + spinEditCride.Value + "," + spinEditOther.Value + ")");
            }
            MessageBox.Show("团体开单成功！");
            this.Close();
        }

        private void btnClipBorad_Click(object sender, EventArgs e)
        {
            Bitmap image = common.getClipBordImage();
            if (image.Width != 1)
            {
                pictureBox1.Image = image;
            }
        }

        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCard.Text.Trim().Length == 18)
            {
                string identityCard = txtIDCard.Text.Trim();
                dateBirthday.Text = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
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

        private void dateEditStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Value = dateEditStart.Value;
        }

        private void dateEditEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Value = dateEditEnd.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spinEditCash.Value = spinEditMoney.Value;
            spinEditCride.Value = 0;
            spinEditOther.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spinEditCride.Value = spinEditMoney.Value;
            spinEditCash.Value = 0;
            spinEditOther.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spinEditCride.Value = 0;
            spinEditCash.Value = 0;
            spinEditOther.Value = spinEditMoney.Value;
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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_xieyi_Click(object sender, EventArgs e)
        {
            crystalReportViewer1_Click(sender, e);
            crystalReportViewer1.PrintReport();
        }

        private void crystalReportViewer1_Click(object sender, EventArgs e)
        {
            string buildname = DB.selectScalar("select name from gzf_building where id=" + ((TreeNode)listBoxHouse.Items[0]).Tag.ToString());
            ReportDocument repostDoc = new ReportDocument();
            repostDoc.Load("xieyi.rpt");
            repostDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            ParameterFields paramFields = new ParameterFields();

            //加载打印
            try
            {
                int desposit = Convert.ToInt32(spinEditDeposit.Value);
                string name = txtName.Text;
                ParameterField paramField = new ParameterField();
                paramField.Name = "name";
                ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
                discreteVal.Value = name;
                paramField.CurrentValues.Add(discreteVal);

                ParameterField paramField2 = new ParameterField();
                paramField2.Name = "start_time";
                ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();
                discreteVal2.Value = dateTimePicker3.Value.ToString("yyyy   MM   dd");
                paramField2.CurrentValues.Add(discreteVal2);

                ParameterField paramField3 = new ParameterField();
                paramField3.Name = "end_time";
                ParameterDiscreteValue discreteVal3 = new ParameterDiscreteValue();
                discreteVal3.Value = dateTimePicker4.Value.ToString("yyyy   MM   dd");
                paramField3.CurrentValues.Add(discreteVal3);

                ParameterField paramField4 = new ParameterField();
                paramField4.Name = "building";
                ParameterDiscreteValue discreteVal4 = new ParameterDiscreteValue();
                discreteVal4.Value = buildname.Replace("号楼", "");
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
                discreteVal16.Value = company;
                paramField16.CurrentValues.Add(discreteVal16);

                ParameterField paramField17 = new ParameterField();
                paramField17.Name = "buildingsn";
                ParameterDiscreteValue discreteVal17 = new ParameterDiscreteValue();
                discreteVal17.Value = buildname.Replace("号楼", "#") + lblSn.Text;
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
            dateEditEnd.Value = dateEditStart.Value.AddMonths(Convert.ToInt32(payMonth.Value)).AddDays(-1);
        }

        private void btnClipBorad2_Click(object sender, EventArgs e)
        {
            Bitmap image = common.getClipBordImage();
            if (image.Width != 1)
            {
                pictureBox2.Image = image;
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

    }
}
