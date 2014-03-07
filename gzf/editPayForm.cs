using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class editPayForm : Form
    {
        string paymentID = "";
        public editPayForm(string id)
        {
            InitializeComponent();
            DataTable dt = DB.select("select * from gzf_payment where id=" + id);
            txtPay.Value = Convert.ToInt32(dt.Rows[0]["pay"]);
            txtPayMonth.Value = Convert.ToInt32(dt.Rows[0]["pay_month"]);
            txtDay.Value = Convert.ToInt32(dt.Rows[0]["pay_day"]);
            txtFapiao.Text = dt.Rows[0]["fapiao"].ToString();
            spinEditCash.Value = Convert.ToInt32(dt.Rows[0]["cash"]);
            spinEditCride.Value = Convert.ToInt32(dt.Rows[0]["credit"]);
            spinEditOther.Value = Convert.ToInt32(dt.Rows[0]["other"]);
            lblMethod.Text = common.getPaymethod(dt.Rows[0]["pay_method"].ToString());
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["start_time"]);
                dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0]["end_time"]);
                dateTimePicker3.Value = Convert.ToDateTime(dt.Rows[0]["addtime"]);
            }
            catch
            { }
            paymentID = id;
        }

        private void editPayForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int count = DB.exec_NonQuery("update gzf_payment set pay_month=" + txtPayMonth.Value + ", pay=" + txtPay.Value + ", pay_day=" + txtDay.Value + ", start_time='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', end_time='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', addtime='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "', fapiao='" + txtFapiao.Text + "', cash=" + spinEditCash.Value + ", credit=" + spinEditCride.Value + ", other=" + spinEditOther.Value + " where id=" + paymentID);
            if (count > 0)
            {
                MessageBox.Show("编辑成功！");
                this.Close();
                return;
            }
            MessageBox.Show("编辑失败！");
        }

    }
}
