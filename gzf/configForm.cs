using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class configForm : Form
    {
        public configForm()
        {
            InitializeComponent();
        }

        private void configForm_Load(object sender, EventArgs e)
        {
            reloadUserGrid();
            reloadBuildingGrid();
            comboBoxBuilding.SelectedIndex = 0;
            reloadHouseGrid(comboBoxBuilding.SelectedValue.ToString());
            dataGridView2.AutoGenerateColumns = false;
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            addUserForm auf = new addUserForm();
            auf.ShowDialog();
            reloadUserGrid();
        }

        private void btn_delUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此用户？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_user where id=" + dataGridView1.SelectedRows[0].Cells[0].Value);
                reloadUserGrid();//abck
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.select("select * from gzf_user where id=" + dataGridView1.SelectedRows[0].Cells[0].Value);
            model.User user = new gzf.model.User();
            user.id = Convert.ToInt32(dt.Rows[0]["id"].ToString());
            user.username = dt.Rows[0]["username"].ToString();
            user.fullname = dt.Rows[0]["fullname"].ToString();
            user.type = Convert.ToInt32(dt.Rows[0]["type"].ToString());
            editUserForm euf = new editUserForm(user);
            euf.ShowDialog(this);
            reloadUserGrid();
        }

        private void reloadUserGrid()
        {
            dataGridView1.DataSource = DB.select("select id,username,type,fullname from gzf_user");
        }

        private void reloadBuildingGrid()
        {
            dataGridView2.DataSource = DB.select("select * from gzf_building");
            comboBoxBuilding.DataSource = dataGridView2.DataSource;
            
        }

        private void reloadHouseGrid(string id)
        {
            dataGridView3.DataSource = DB.select("select gzf_house.id,gzf_building.name,sn,floor,price,position,gzf_house.sortnum from gzf_house,gzf_building where gzf_house.building_id=gzf_building.id and building_id=" + id + " order by sn");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "普通用户";
                }
                else
                {
                    e.Value = "管理员";
                }
            }
        }

        private void btn_addBuilding_Click(object sender, EventArgs e)
        {
            addBuildingForm ab = new addBuildingForm();
            ab.ShowDialog();
            reloadBuildingGrid();
        }

        private void btn_delBuilding_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此建筑？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_building where id=" + dataGridView2.SelectedRows[0].Cells[0].Value);
                reloadBuildingGrid();
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "小型房";
                }
                else
                {
                    e.Value = "大型房";
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "左边";
                }
                else
                {
                    e.Value = "右边";
                }
            }
        }

        private void btn_editBuilding_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.SelectedRows[0].Cells["Column1"].Value.ToString();
            editBuildingForm ebf = new editBuildingForm(id);
            ebf.ShowDialog();
            reloadBuildingGrid();
        }

        private void btn_addHouse_Click(object sender, EventArgs e)
        {
            addHouseForm ahf = new addHouseForm(Convert.ToInt32(comboBoxBuilding.SelectedValue));
            ahf.ShowDialog();
            reloadHouseGrid(comboBoxBuilding.SelectedValue.ToString());
        }

        private void btn_delHouse_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此房屋？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_house where id=" + dataGridView3.SelectedRows[0].Cells["Column4"].Value);
                reloadHouseGrid(comboBoxBuilding.SelectedValue.ToString());
            }
        }

        private void btn_editHouse_Click(object sender, EventArgs e)
        {
            model.House house = new gzf.model.House();
            house.id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["Column4"].Value);
            editHouseForm ehf = new editHouseForm(house);
            ehf.ShowDialog();
            reloadHouseGrid(comboBoxBuilding.SelectedValue.ToString());
        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadHouseGrid(comboBoxBuilding.SelectedValue.ToString());
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "南";
                }
                else
                {
                    e.Value = "北";
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_EditUser_Click(sender, e);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editBuilding_Click(sender, e);
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editHouse_Click(sender, e);
        }


    }
}
