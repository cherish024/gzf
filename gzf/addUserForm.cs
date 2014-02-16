using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("密码两次输入不一致！");
                return;
            }
            string cmd = "insert into gzf_user values ('" + txtUsername.Text + "', '" + common.MD5Encrypt(txtPassword.Text) + "' , " + comboBoxLevel.SelectedIndex + ", '" + txtFullname.Text + "' ,'" + DateTime.Now.ToString() + "')";
            int res = DB.exec_NonQuery(cmd);
            if (res > 0)
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void addUserForm_Load(object sender, EventArgs e)
        {
            comboBoxLevel.SelectedIndex = 0;
        }
    }
}
