using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class addBuildingForm : Form
    {
        public addBuildingForm()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "insert into gzf_building values ('" + txtName.Text + "', " + comboBox1.SelectedIndex + "," + txtSort.Text + "," + cbDating.SelectedIndex + ")";
            int count = DB.exec_NonQuery(cmd);
            if (count > 0)
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBuildingForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
