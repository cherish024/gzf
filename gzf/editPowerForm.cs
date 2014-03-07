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
            comboBoxPayMethod.SelectedIndex = Convert.ToInt32(dt.Rows[0]["pay_method"]) - 1;
            txtFapiao.Text = dt.Rows[0]["fapiao"].ToString();
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["start_time"]);
                dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0]["end_time"]);
                dateTimePicker3.Value = Convert.ToDateTime(dt.Rows[0]["addtime"]);
            }
            
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cmd = "update gzf_power set price=" + txtPay.Value + ", pay_month=" + txtMonth.Value + ", pay_method=" + (comboBoxPayMethod.SelectedIndex + 1).ToString() + ", pay_day=" + txtDay.Value + ", start_time='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', end_time='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', addtime='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "', fapiao='" + txtFapiao.Text + "' where id=" + _id;
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
