using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class addHouseForm : Form
    {
        private int buildID;
        public addHouseForm(int buildingID)
        {
            InitializeComponent();
            this.buildID = buildingID;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtSn.Text.Trim() == "")
            {
                MessageBox.Show("房屋编号不能为空！");
                return;
            }
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("租金不能为空！");
                return;
            }
            try
            {
                Convert.ToInt32(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("输入的租金有误！");
                return;
            }
            string cmd = "insert into gzf_house values (" + comboBoxBuilding.SelectedValue.ToString() + ", " + comboBoxFloor.SelectedItem.ToString() + ", 1, '" + txtPrice.Value.ToString() + "', '" + txtSn.Text + "', " + comboBoxPosition.SelectedIndex + "," + numSort.Value + ",0," + leftpos.Value + ")";
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addHouseForm_Load(object sender, EventArgs e)
        {
            comboBoxBuilding.DataSource = DB.select("select * from gzf_building");
            comboBoxBuilding.SelectedValue = buildID;
            for (int i = 1; i <= 10;i++ )
            {
                comboBoxFloor.Items.Add(i.ToString());
            }
            comboBoxFloor.SelectedIndex = 0;
            comboBoxPosition.SelectedIndex = 0;
        }
    }
}
