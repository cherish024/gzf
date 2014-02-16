using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace gzf
{
    public partial class editHouseForm : Form
    {
        model.House house;
        public editHouseForm(model.House house)
        {
            InitializeComponent();
            DataTable dt = DB.select("select * from gzf_house where id=" + house.id);
            model.House h = new gzf.model.House();
            h.id = house.id;
            h.building_id = Convert.ToInt32(dt.Rows[0]["building_id"]);
            h.sn = dt.Rows[0]["sn"].ToString();
            h.floor = Convert.ToInt32(dt.Rows[0]["floor"]);
            h.price = Convert.ToInt32(dt.Rows[0]["price"]);
            h.status = Convert.ToInt32(dt.Rows[0]["status"]);
            h.Position = Convert.ToInt32(dt.Rows[0]["position"]);
            h.Sortnum = Convert.ToInt32(dt.Rows[0]["sortnum"]);
            h.Guestnum = Convert.ToInt32(dt.Rows[0]["guestnum"]);
            h.Leftpos = Convert.ToInt32(dt.Rows[0]["leftpos"]);
            this.house = h;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cmd = "update gzf_house set building_id=" + comboBoxBuilding.SelectedValue + ", floor=" + (comboBoxFloor.SelectedIndex + 1).ToString() + ", position=" + comboBoxPosition.SelectedIndex + ", price=" + txtPrice.Text + ", sn='" + txtSn.Text + "', sortnum=" + numSort.Value + ", guestnum=" + comboBox1.SelectedIndex + ", leftpos=" + leftpos.Value + " where id=" + house.id;
            int dbcount = DB.exec_NonQuery(cmd);
            if (dbcount > 0)
            {
                MessageBox.Show("编辑成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("编辑失败！");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editHouseForm_Load(object sender, EventArgs e)
        {
            comboBoxBuilding.DataSource = DB.select("select * from gzf_building");
            comboBoxBuilding.SelectedValue = house.building_id;
            for (int i = 1; i <= 10; i++)
            {
                comboBoxFloor.Items.Add(i.ToString());
            }
            comboBoxFloor.SelectedIndex = house.floor - 1;
            txtPrice.Text = house.price.ToString();
            txtSn.Text = house.sn;
            numSort.Value = house.Sortnum;
            model.HouseStatus housestatus = new gzf.model.HouseStatus(house.status);
            comboBoxPosition.SelectedIndex = house.Position;
            comboBox1.SelectedIndex = house.Guestnum;
            leftpos.Value = house.Leftpos;
        }
    }
}
