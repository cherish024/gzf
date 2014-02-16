using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class xufeiForm : Form
    {
        public model.OpenHouse openhouse;
        public model.House house;
        public xufeiForm(model.OpenHouse openhouse, model.House house)
        {
            InitializeComponent();
            this.openhouse = openhouse;
            this.house = house;
        }

        private void btn_payadd_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (chkDay.Checked)
            {
                count = DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao) values (" + openhouse.Id + ", 0," + spinEditDay.Value + "," + house.id + "," + common.User.id + "," + payDay.Value + ",'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + txtFapiao.Text + "')");
            }
            else
            {
                if (txtPayMonth.Value > 0)
                {
                    count = DB.exec_NonQuery("insert into gzf_payment (openhouse_id,pay_month,pay,house_id,user_id,pay_day,start_time,end_time,fapiao) values (" + openhouse.Id + "," + txtPayMonth.Value + "," + txtPay.Value + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + txtFapiao.Text + "')");
                }
            }
            if (count > 0)
            {
                xufeiForm_Load(sender, e);
                return;
            }
            MessageBox.Show("添加失败！");
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
                xufeiForm_Load(sender, e);
            }
        }

        private void xufeiForm_Load(object sender, EventArgs e)
        {
            dataPayment.AutoGenerateColumns = false;
            dataPayment.DataSource = DB.select("select * from gzf_payment,gzf_house where gzf_payment.house_id=gzf_house.id and openhouse_id=" + openhouse.Id);
            string shuifei = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + "and type=0");
            string dianfei = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=1");
            string fangfei = DB.selectScalar("select sum(pay) from gzf_payment where openhouse_id=" + openhouse.Id);
            string monthall = DB.selectScalar("select sum(pay_month) from gzf_payment where openhouse_id=" + openhouse.Id);
            string dayall = DB.selectScalar("select sum(pay_day) from gzf_payment where openhouse_id=" + openhouse.Id);
            string shuimonth = DB.selectScalar("select sum(pay_month) from gzf_power where openhouse_id=" + openhouse.Id + "and type=0");
            string dianmonth = DB.selectScalar("select sum(pay_month) from gzf_power where openhouse_id=" + openhouse.Id + "and type=1");
            string shuiday = DB.selectScalar("select sum(pay_day) from gzf_power where openhouse_id=" + openhouse.Id + "and type=0");
            string dianday = DB.selectScalar("select sum(pay_day) from gzf_power where openhouse_id=" + openhouse.Id + "and type=1");
            if (shuifei == "")
            {
                shuifei = "0";
            }
            if (dianfei == "")
            {
                dianfei = "0";
            }
            if (fangfei == "")
            {
                fangfei = "0";
            }
            if (shuimonth == "")
            {
                shuimonth = "0";
            }
            if (dianmonth == "")
            {
                dianmonth = "0";
            }
            if (shuiday == "")
            {
                shuiday = "0";
            }
            if (dianday == "")
            {
                dianday = "0";
            }
            if (monthall == "")
            {
                monthall = "0";
            }
            if (dayall == "")
            {
                dayall = "0";
            }
            lblHouseTotal.Text = fangfei;
            lblPayMonth.Text = monthall;
            lblPayDay.Text = dayall;
            txtPay.Value = openhouse.Price;
            txtPayMonth.Value = 1;
        }

        private void dataPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataPayment.SelectedRows.Count == 0)
            {
                return;
            }
            editPayForm pay = new editPayForm(dataPayment.SelectedRows[0].Cells[0].Value.ToString());
            pay.ShowDialog();
            xufeiForm_Load(sender, e);
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

        private void txtPayMonth_ValueChanged(object sender, EventArgs e)
        {
            txtPay.Value = txtPayMonth.Value * openhouse.Price;
        }
    }
}
