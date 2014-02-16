using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class editBuildingForm : Form
    {
        string id;
        public editBuildingForm(string id)
        {
            InitializeComponent();
            DataTable dt = DB.select("select * from gzf_building where id=" + id);
            txtName.Text = dt.Rows[0]["name"].ToString();
            comboBox1.SelectedIndex = Convert.ToInt32(dt.Rows[0]["type"]);
            cbDating.SelectedIndex = Convert.ToInt32(dt.Rows[0]["dating"]);
            txtSort.Text = dt.Rows[0]["sortnum"].ToString();
            this.id = id;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("建筑名称不能为空！");
                return;
            }
            string cmd = "update gzf_building set name='" + txtName.Text + "', type=" + comboBox1.SelectedIndex + ", sortnum=" + txtSort.Text + ", dating=" + cbDating.SelectedIndex + " where id=" + id;
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

        private void editBuildingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
