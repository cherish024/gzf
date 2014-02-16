using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class editUserForm : Form
    {
        private model.User user;
        public editUserForm(model.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("密码两次输入不一致！");
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullname = txtFullname.Text;
            int type = comboBoxLevel.SelectedIndex;
            string cmd = "";
            if (password.Trim() == "")
            {
                cmd = "update gzf_user set username='" + username + "', fullname='" + fullname + "', type=" + type + " where id=" + user.id;
            }
            else
            {
                cmd = "update gzf_user set username='" + username + "', fullname='" + fullname + "', type=" + type + ", password='" + common.MD5Encrypt(password) + "' where id=" + user.id;
            }
            //cmd += " where id=" + user.id;
            int count = DB.exec_NonQuery(cmd);
            if (count > 0)
            {
                MessageBox.Show("编辑成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("编辑失败！");
            }
        }

        private void editUserForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DB.select("select * from gzf_user where id=" + user.id);
            txtUsername.Text = dt.Rows[0]["username"].ToString();
            txtFullname.Text = dt.Rows[0]["fullname"].ToString();
            comboBoxLevel.SelectedIndex = Convert.ToInt32(dt.Rows[0]["type"].ToString());
        }
    }
}
