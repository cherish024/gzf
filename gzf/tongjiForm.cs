using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class tongjiForm : Form
    {
        public tongjiForm()
        {
            InitializeComponent();
        }

        private void tongjiForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_jiezhang_Click(object sender, EventArgs e)
        {
            tongjiZdForm zd = new tongjiZdForm();
            zd.ShowDialog();
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            tongjiPowerForm power = new tongjiPowerForm();
            power.ShowDialog();
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            tongjiGuestForm guest = new tongjiGuestForm();
            guest.ShowDialog();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            tongjiPayForm pay = new tongjiPayForm();
            pay.ShowDialog();
        }

        private void btn_houseStatus_Click(object sender, EventArgs e)
        {
            tongjiHouseStatusForm status = new tongjiHouseStatusForm();
            status.ShowDialog();
        }

        private void btn_stayPercent_Click(object sender, EventArgs e)
        {
            tongjiPercentForm percent = new tongjiPercentForm();
            percent.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            YingyeDayForm day = new YingyeDayForm();
            day.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            YingyeMonth month = new YingyeMonth();
            month.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            YingyeYearForm year = new YingyeYearForm();
            year.ShowDialog();
        }

        private void btn_fapiao_Click(object sender, EventArgs e)
        {
            tongjiFapiaoForm fapiao = new tongjiFapiaoForm();
            fapiao.ShowDialog();
        }

        private void btn_yajing_Click(object sender, EventArgs e)
        {
            tongjiYajingForm yj = new tongjiYajingForm();
            yj.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tongjiOpen open = new tongjiOpen();
            open.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (common.User.type != 1)
            {
                if (tabControl1.SelectedIndex == 1 || tabControl1.SelectedIndex == 2)
                {
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show("普通用户没有权限查看！");
                    
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            tongjiDayForm day = new tongjiDayForm();
            day.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            tongjiMonth month = new tongjiMonth();
            month.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tongjiYearForm year = new tongjiYearForm();
            year.ShowDialog();
        }
    }
}
