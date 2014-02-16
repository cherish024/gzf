using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class editPowerForm : Form
    {
        private string _id;
        public editPowerForm(string id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void editPowerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DB.select("select * from gzf_power where id=" + _id);
            txtPay.Value = Convert.ToInt32(dt.Rows[0]["price"]);
            txtMonth.Value = Convert.ToInt32(dt.Rows[0]["pay_month"]);
            txtDay.Value = Convert.ToInt32(dt.Rows[0]["pay_day"]);
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["start_time"]);
                dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cmd = "update gzf_power set price=" + txtPay.Value + ", pay_month=" + txtMonth.Value + ", pay_day=" + txtDay.Value + ", start_time='" + dateTimePicker1.Value + "', end_time='" + dateTimePicker2.Value + "' where id=" + _id;
            int dbcount = DB.exec_NonQuery(cmd);
            if (dbcount > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("编辑失败！");
            }
        }
    }
}
