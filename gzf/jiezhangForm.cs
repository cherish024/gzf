using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Office.Interop.Word;
using CrystalDecisions.Shared;

namespace gzf
{
    public partial class jiezhangForm : Form
    {
        public model.OpenHouse openhouse;
        public model.House house;
        //private string zdsn = "ZD" + DateTime.Now.ToString("yyyyMMddhhmmss");
        private int _isjiezhang;

        public int Isjiezhang
        {
            get { return _isjiezhang; }
            set { _isjiezhang = value; }
        }
        public jiezhangForm(model.OpenHouse openhouse, model.House house)
        {
            InitializeComponent();
            this.openhouse = openhouse;
            this.house = house;
        }

        private void jiezhangForm_Load(object sender, EventArgs e)
        {
            int month = (openhouse.End_time - openhouse.Start_time).Days / 30;
            lblyajing.Text = "已收押金：" + openhouse.Deposit;
            lblStarTime.Text = openhouse.Start_time.ToShortDateString();
            lblEndTime.Text = openhouse.End_time.ToShortDateString();
            lblBuilding.Text = DB.selectScalar("select name from gzf_building where id=" + openhouse.Building_id);
            lblsn.Text = this.house.sn;
            lblMonthNum.Text = month.ToString();
            txtPay.Value = openhouse.Price;
            txtPayMonth.Value = 1;
            comboBoxType.SelectedIndex = 0;
            comboBoxPayMethod.SelectedIndex = 0;
            comboBoxPayMethod2.SelectedIndex = 0;
            dataPayment.AutoGenerateColumns = false;
            dataPower.AutoGenerateColumns = false;
            dataPower.DataSource = DB.select("select * from gzf_power,gzf_house where gzf_power.house_id=gzf_house.id and openhouse_id=" + openhouse.Id + " and gzf_power.status=1");
            if (dataPower.RowCount > 0)
            {
                dataPower.MultiSelect = false;
                dataPower.Rows[dataPower.RowCount - 1].Selected = true;
                //dataPower.CurrentCell = dataPower.Rows[this.dataPower.Rows.Count - 1].Cells[1];
            }
            string powerfei = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and status=1");
            string cool = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + "and type=0 and status=1");
            string hot = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + "and type=4 and status=1");
            string dianfei = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=1 and status=1");
            string tv = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=2 and status=1");
            string gas = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=3 and status=1");
            string door = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=5 and status=1");
            string key = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=6 and status=1");
            string fangfei = DB.selectScalar("select sum(pay) from gzf_payment where openhouse_id=" + openhouse.Id);
            string monthall = DB.selectScalar("select sum(pay_month) from gzf_payment where openhouse_id=" + openhouse.Id);
            string dayall = DB.selectScalar("select sum(pay_day) from gzf_payment where openhouse_id=" + openhouse.Id);

            lblCool.Text = cool != "" ? cool : "0" ;
            lblHot.Text = hot != "" ? hot : "0";
            lblDian.Text = dianfei != "" ? dianfei : "0";
            lblTv.Text = tv != "" ? tv : "0";
            lblGas.Text = gas != "" ? gas : "0";
            lblDoor.Text = door != "" ? door : "0";
            lblKey.Text = key != "" ? key : "0";
            powerfei = powerfei != "" ? powerfei : "0";
            fangfei = fangfei != "" ? fangfei : "0";
            lblHouseTotal.Text = fangfei;
            lblPayMonth.Text = monthall;
            lblPayDay.Text = dayall;

            lblTotal.Text = (Convert.ToInt32(powerfei) + Convert.ToInt32(fangfei)).ToString();
            List<int> list = new List<int>();
            string idStr = "";
            if (openhouse.Is_team == 0)
            {
                list.Add(openhouse.House_id);
            }
            else
            {
                list.Add(openhouse.House_id);
                DataTable dt = DB.select("select house_id from gzf_teamopenhouse where openhouse_id=" + openhouse.Id);
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(Convert.ToInt32(dr["house_id"]));
                }
            }
            foreach (int i in list)
            {
                idStr += i.ToString() + ",";
            }
            idStr = idStr.Remove(idStr.Length - 1, 1);
            dataPayment.DataSource = DB.select("select * from gzf_payment,gzf_house where gzf_payment.house_id=gzf_house.id and openhouse_id=" + openhouse.Id);
            if (dataPayment.RowCount > 0) {
                dataPayment.MultiSelect = false;
                dataPayment.Rows[dataPayment.RowCount - 1].Selected = true;
                //dataPayment.CurrentCell = dataPayment.Rows[this.dataPayment.Rows.Count - 1].Cells[1];
            }
            
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(DB.selectScalar("select end_time from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime desc")).AddDays(1);
                dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
            }
            catch { }
            string power_endtime = DB.selectScalar("select end_time from gzf_power where openhouse_id=" + openhouse.Id + " order by addtime desc");
            if (power_endtime.Trim() != "")
            {
                dateTimePicker3.Value = Convert.ToDateTime(power_endtime).AddDays(1);
                dateTimePicker4.Value = dateTimePicker3.Value.AddMonths(1).AddDays(-1);
            }
            string name = " ";
            DataTable dtName = DB.select("select name from gzf_guest where openhouse_id=" + openhouse.Id);
            if (dtName.Rows.Count > 0)
            {
                if (dtName.Rows.Count == 1)
                {
                    name = dtName.Rows[0]["name"].ToString();
                }
                else
                {
                    name = dtName.Rows[0]["name"] + "、" + dtName.Rows[1]["name"];
                }
            }
            lblname.Text = name;
            //加载团体开单信息
            if (openhouse.Is_team != 0)
            {
                lblsn.Text = "";
                DataTable dt = DB.select("select * from gzf_openhouse,gzf_house,gzf_building where is_team=" + openhouse.Is_team + " and gzf_house.building_id=gzf_building.id and gzf_openhouse.house_id=gzf_house.id and is_jiezhang=0");
                if (dt.Rows.Count > 0)
                { 
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["id"].ToString() == openhouse.Is_team.ToString())
                        {
                            lblsn.Text += "*" + Convert.ToInt32(dr["sn"]) + "  ";
                        }
                        else
                        {
                            lblsn.Text += Convert.ToInt32(dr["sn"]) + "  ";
                        }
                        

                    }
                    lblsn.Text = lblsn.Text.Substring(0, 50);
                }
            }
            crystalReportViewer1_Click(sender, new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("是否确定结账？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    return;
            //}
            //DB.exec_NonQuery("update gzf_openhouse set is_jiezhang=1 where id="+openhouse.Id);
            //DB.exec_NonQuery("update gzf_house set status=1 where id=" + openhouse.House_id);
            //if (openhouse.Is_team == 1)
            //{
            //    DataTable dt = DB.select("select house_id from gzf_teamopenhouse where openhouse_id=" + openhouse.Id);
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        DB.exec_NonQuery("update gzf_house set status=1 where id=" + dr["house_id"]);
            //    }
            //}
            //DB.exec_NonQuery("insert into gzf_zd (sn,openhouse_id,guest_id,shui_price,dian_price,house_price,is_team,total_price,user_id) values ('" + zdsn + "'," + openhouse.Id + "," + openhouse.Main_guest_id + "," + lblShui.Text + "," + lblDian.Text + "," + lblHouseTotal.Text + "," + openhouse.Is_team + "," + lblTotal.Text + "," + common.User.id + ")");
            //this.Close();
            jiezhangtuikuanForm jz = new jiezhangtuikuanForm(openhouse,lblHot.Text,lblDian.Text,lblHouseTotal.Text,lblTotal.Text,house);
            jz.ShowDialog(this);
            if (Isjiezhang == 1)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                model.powerType powertype = new gzf.model.powerType(Convert.ToInt32(e.Value));
                e.Value = powertype.Statustxt;
            }
            try
            {
                if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
                {
                    e.Value = (Convert.ToDateTime(e.Value)).ToString("yyyy-MM-dd");
                }
            }
            catch
            { }
        }


        private void btn_payadd_Click(object sender, EventArgs e)
        {
            decimal money = 0;
            if (chkDay.Checked)
            {
                money = spinEditDay.Value;
            }
            else
            {
                money = txtPay.Value;
            }
            if (spinEditCash.Value + spinEditCride.Value + spinEditOther.Value != money)
            {
                MessageBox.Show("请检查现金、信用卡、其他是否与总金额一致");
                return;
            }
            string fpcount = DB.selectScalar("select count(*) from gzf_payment where fapiao='" + txtFapiao1.Text + "'");
            if (fpcount != "0")
            {
                if (MessageBox.Show("发票号码已存在,是否继续操作?", "确认发票号码", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            int count = 0;
            if (chkDay.Checked)
            {
                count = DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao,pay_method,cash,credit,other) values (" + openhouse.Id + ", 0," + spinEditDay.Value + "," + house.id + "," + common.User.id + "," + payDay.Value + ",'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + txtFapiao1.Text + "'," + (comboBoxPayMethod.SelectedIndex + 1) +"," + spinEditCash.Value + "," + spinEditCride.Value + "," + spinEditOther.Value + ")");
            }
            else
            {
                if (txtPayMonth.Value > 0)
                {
                    count = DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao,pay_method,cash,credit,other) values (" + openhouse.Id + "," + txtPayMonth.Value + "," + txtPay.Value + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + txtFapiao1.Text + "'," + (comboBoxPayMethod.SelectedIndex + 1) + "," + spinEditCash.Value + "," + spinEditCride.Value + "," + spinEditOther.Value + ")");
                }
            }
            if (count > 0)
            {
                jiezhangForm_Load(sender, e);
                return;
            }
            MessageBox.Show("添加失败！");
        }

        private void btn_payedit_Click(object sender, EventArgs e)
        {
            if (dataPayment.SelectedRows.Count == 0)
            {
                return;
            }
            editPayForm pay = new editPayForm(dataPayment.SelectedRows[0].Cells[0].Value.ToString());
            pay.ShowDialog();
            jiezhangForm_Load(sender, e);
        }

        private void dataPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_payedit_Click(sender, e);
        }

        private void btn_powerAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (chkPowerDay.Checked)
            {
                count = DB.exec_NonQuery("insert into gzf_power (type,openhouse_id,pay_month,price,house_id,user_id,pay_day,start_time,end_time,fapiao,pay_method,status) values (" + comboBoxType.SelectedIndex + "," + openhouse.Id + ",0 ," + powerDayPay.Value + "," + house.id + "," + common.User.id + "," + powerDay.Value + ",'" + dateTimePicker3.Value.ToString() + "','" + dateTimePicker4.Value.ToString() + "','" + txtFapiao2.Text + "'" + (comboBoxPayMethod2.SelectedIndex) + 1 + ",1)");
            }
            else
            {
                count = DB.exec_NonQuery("insert into gzf_power (type,openhouse_id,pay_month,price,house_id,user_id,pay_day,start_time,end_time,fapiao,pay_method,status) values (" + comboBoxType.SelectedIndex + "," + openhouse.Id + "," + txtPowerMonth.Value.ToString() + "," + txtPowerPay.Value + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker3.Value.ToString() + "','" + dateTimePicker4.Value.ToString() + "','" + txtFapiao2.Text + "'," + (comboBoxPayMethod2.SelectedIndex + 1) + ",1)");
            }
            if (count > 0)
            {
                jiezhangForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            
        }

        private void btn_paydel_Click(object sender, EventArgs e)
        {
            if (dataPayment.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此记录？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_payment where id=" + dataPayment.SelectedRows[0].Cells[0].Value);
                jiezhangForm_Load(sender, e);
            }
        }

        private void btn_powerDel_Click(object sender, EventArgs e)
        {
            if (dataPower.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此记录？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_power where id=" + dataPower.SelectedRows[0].Cells[0].Value);
                jiezhangForm_Load(sender, e);
            }
        }

        private void btn_powerEdit_Click(object sender, EventArgs e)
        {
            if (dataPower.SelectedRows.Count == 0)
            {
                return;
            }
            editPowerForm power = new editPowerForm(dataPower.SelectedRows[0].Cells[0].Value.ToString());
            power.ShowDialog();
            jiezhangForm_Load(sender, e);
        }

        private void dataPower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_powerEdit_Click(sender, e);
        }

        private void txtPayMonth_ValueChanged(object sender, EventArgs e)
        {
            txtPay.Value = txtPayMonth.Value * openhouse.Price;
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(Convert.ToInt32(txtPayMonth.Value)).AddDays(-1);
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

        private void chkPowerDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPowerDay.Checked)
            {
                panelPowerDay.Enabled = true;
                panelPowerMonth.Enabled = false;
            }
            else
            {
                panelPowerDay.Enabled = false;
                panelPowerMonth.Enabled = true;
            }
        }

        private void dataPayment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                {
                    e.Value = (Convert.ToDateTime(e.Value)).ToString("yyyy-MM-dd");
                }
            }
            catch
            { }
        }

        private void payDay_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(Convert.ToInt32(payDay.Value));
        }

        private void txtPowerMonth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Value = dateTimePicker3.Value.AddMonths(Convert.ToInt32(txtPowerMonth.Value)).AddDays(-1);
        }

        private void powerDay_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Value = dateTimePicker3.Value.AddDays(Convert.ToInt32(powerDay.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1_Click(sender, e);
            crystalReportViewer1.PrintReport();
            //Microsoft.Office.Interop.Word.ApplicationClass app = new Microsoft.Office.Interop.Word.ApplicationClass();
            //app.Visible = true;
            //Microsoft.Office.Interop.Word.Document doc = null;
            //object missing = System.Reflection.Missing.Value;
            //object FileName = System.Windows.Forms.Application.StartupPath + "\\xieyi_templete.doc";
            //object xieyiFileName = System.Windows.Forms.Application.StartupPath + "\\xieyi.doc";
            //object readOnly = false;
            //object isVisible = true;
            //object isOpen = true;
            //object index = 0;
            //try
            //{
            //    doc = app.Documents.Open(ref FileName, ref missing, ref readOnly,
            //    ref missing, ref missing, ref missing, ref missing, ref missing,
            //    ref missing, ref missing, ref missing, ref isVisible, ref isOpen,
            //    ref missing, ref missing, ref missing);
            //    object replaceAll = WdReplace.wdReplaceAll;
            //    DataTable dt = DB.select("select name from gzf_guest where openhouse_id=" + openhouse.Id);
            //    app.Selection.Find.Text = "{name}";
            //    if (dt.Rows.Count == 1)
            //    {
            //        app.Selection.Find.Replacement.Text = dt.Rows[0]["name"].ToString();
            //    }
            //    else
            //    {
            //        app.Selection.Find.Replacement.Text = dt.Rows[0]["name"] + "、" + dt.Rows[1]["name"];
            //    }
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{building}";
            //    if (lblBuilding.Text.Replace("号楼", "").Length == 1)
            //    {
            //        app.Selection.Find.Replacement.Text = "0" + lblBuilding.Text.Replace("号楼", "");
            //    }
            //    else
            //    {
            //        app.Selection.Find.Replacement.Text = lblBuilding.Text.Replace("号楼", "");
            //    }
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{sn}";
            //    app.Selection.Find.Replacement.Text = house.sn;
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{price}";
            //    app.Selection.Find.Replacement.Text = openhouse.Price.ToString();
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{start_time}";
            //    app.Selection.Find.Replacement.Text = Convert.ToDateTime(DB.selectScalar("select start_time from gzf_payment where openhouse_id=" + openhouse.Id + " ORDER BY addtime desc")).ToString("yyyy年MM月dd日");
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{end_time}";
            //    app.Selection.Find.Replacement.Text = Convert.ToDateTime(DB.selectScalar("select end_time from gzf_payment where openhouse_id=" + openhouse.Id + " ORDER BY addtime desc")).ToString("yyyy年MM月dd日");
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{add_time}";
            //    app.Selection.Find.Replacement.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{yj}";
            //    app.Selection.Find.Replacement.Text = "0";
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{yj_daxie}";
            //    app.Selection.Find.Replacement.Text = common.DaXie("0");
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    int desposit = openhouse.Deposit;
            //    app.Selection.Find.Text = "{shiwan}";
            //    app.Selection.Find.Replacement.Text = clearZero(100000) ? (desposit / 100000).ToString() : "";
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{wan}";
            //    app.Selection.Find.Replacement.Text = clearZero(10000) ? ((desposit % 100000) / 10000).ToString() : "";
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{qian}";
            //    app.Selection.Find.Replacement.Text = clearZero(1000) ? ((desposit % 10000) / 1000).ToString() : "";
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{bai}";
            //    app.Selection.Find.Replacement.Text = clearZero(100) ? ((desposit % 1000) / 100).ToString() : "";
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{shi}";
            //    app.Selection.Find.Replacement.Text = clearZero(10) ? ((desposit % 100) / 10).ToString() : "";
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Find.Text = "{ge}";
            //    app.Selection.Find.Replacement.Text = (desposit % 10).ToString();
            //    app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            //    app.Selection.Document.SaveAs(ref xieyiFileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
            //}
            //catch { }

        }
        private bool clearZero(int bit)
        {
            int desposit = 0;
            if (bit > desposit)
            {
                return false;
            }
            return true;
        }


        private void crystalReportViewer1_Click(object sender, EventArgs e)
        {
            //加载打印信息
            try
            {
                int desposit = openhouse.Deposit;
                string start_time = Convert.ToDateTime(DB.selectScalar("select start_time from gzf_payment where openhouse_id=" + openhouse.Id + " ORDER BY addtime desc")).ToString("yyyy   MM   dd");
                string end_time = Convert.ToDateTime(DB.selectScalar("select end_time from gzf_payment where openhouse_id=" + openhouse.Id + " ORDER BY addtime desc")).ToString("yyyy   MM   dd");
                string name = " ";
                DataTable dt = DB.select("select name from gzf_guest where openhouse_id=" + openhouse.Id);
                if (dt.Rows.Count == 1)
                {
                    name = dt.Rows[0]["name"].ToString();
                }
                else
                {
                    name = dt.Rows[0]["name"] + "、" + dt.Rows[1]["name"];
                }
                //lblname.Text = name;
                //dsd
                ReportDocument repostDoc = new ReportDocument();
                repostDoc.Load("xieyi.rpt");
                repostDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField = new ParameterField();
                paramField.Name = "name";
                ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
                discreteVal.Value = name;
                paramField.CurrentValues.Add(discreteVal);

                ParameterField paramField2 = new ParameterField();
                paramField2.Name = "start_time";
                ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();
                discreteVal2.Value = start_time;
                paramField2.CurrentValues.Add(discreteVal2);

                ParameterField paramField3 = new ParameterField();
                paramField3.Name = "end_time";
                ParameterDiscreteValue discreteVal3 = new ParameterDiscreteValue();
                discreteVal3.Value = end_time;
                paramField3.CurrentValues.Add(discreteVal3);

                ParameterField paramField4 = new ParameterField();
                paramField4.Name = "building";
                ParameterDiscreteValue discreteVal4 = new ParameterDiscreteValue();
                discreteVal4.Value = lblBuilding.Text.Replace("号楼", "");
                paramField4.CurrentValues.Add(discreteVal4);

                ParameterField paramField5 = new ParameterField();
                paramField5.Name = "sn";
                ParameterDiscreteValue discreteVal5 = new ParameterDiscreteValue();
                discreteVal5.Value = house.sn;
                paramField5.CurrentValues.Add(discreteVal5);

                ParameterField paramField6 = new ParameterField();
                paramField6.Name = "price";
                ParameterDiscreteValue discreteVal6 = new ParameterDiscreteValue();
                discreteVal6.Value = openhouse.Price.ToString();
                paramField6.CurrentValues.Add(discreteVal6);

                ParameterField paramField7 = new ParameterField();
                paramField7.Name = "yj";
                ParameterDiscreteValue discreteVal7 = new ParameterDiscreteValue();
                discreteVal7.Value = "0";
                paramField7.CurrentValues.Add(discreteVal7);

                ParameterField paramField8 = new ParameterField();
                paramField8.Name = "add_time";
                ParameterDiscreteValue discreteVal8 = new ParameterDiscreteValue();
                discreteVal8.Value = DateTime.Now.ToString("yyyy   MM   dd");
                paramField8.CurrentValues.Add(discreteVal8);

                ParameterField paramField9 = new ParameterField();
                paramField9.Name = "yj_daxie";
                ParameterDiscreteValue discreteVal9 = new ParameterDiscreteValue();
                discreteVal9.Value = common.DaXie("0");
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
                discreteVal14.Value = (desposit % 10).ToString();
                paramField14.CurrentValues.Add(discreteVal14);

                ParameterField paramField15 = new ParameterField();
                paramField15.Name = "shi";
                ParameterDiscreteValue discreteVal15 = new ParameterDiscreteValue();
                discreteVal15.Value = clearZero(10) ? ((desposit % 100) / 10).ToString() : "";
                paramField15.CurrentValues.Add(discreteVal15);

                ParameterField paramField16 = new ParameterField();
                paramField16.Name = "company";
                ParameterDiscreteValue discreteVal16 = new ParameterDiscreteValue();
                discreteVal16.Value = "(" + DB.selectScalar("select top 1 company from gzf_guest where openhouse_id=" + openhouse.Id) + ")";
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
                crystalReportViewer1.ParameterFieldInfo = paramFields;
                crystalReportViewer1.ReportSource = repostDoc;
            }
            catch
            {
                //MessageBox.Show("有房费缴纳记录才能打印！");
            }
        }

        private void txtPay_ValueChanged(object sender, EventArgs e)
        {
            //spinEditCash.Value = txtPay.Value;
        }

        private void spinEditDay_ValueChanged(object sender, EventArgs e)
        {
            //spinEditCash.Value = spinEditDay.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spinEditCash.Value = txtPay.Value;
            spinEditCride.Value = 0;
            spinEditOther.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spinEditCride.Value = txtPay.Value;
            spinEditCash.Value = 0;
            spinEditOther.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spinEditCride.Value = 0;
            spinEditCash.Value = 0;
            spinEditOther.Value = txtPay.Value;
        }
    }
}
