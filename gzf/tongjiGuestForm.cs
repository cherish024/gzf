using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace gzf
{
    public partial class tongjiGuestForm : Form
    {
        public tongjiGuestForm()
        {
            InitializeComponent();
        }

        private void tongjiGuestForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DataTable dt = DB.select("select * from gzf_building");
            comboBoxBuilding.Items.Add(new DictionaryEntry(0, "全部建筑"));
            foreach (DataRow dr in dt.Rows)
            {
                DictionaryEntry de = new DictionaryEntry(dr["id"].ToString(), dr["name"].ToString());
                comboBoxBuilding.Items.Add(de);
            }
            comboBoxBuilding.ValueMember = "Key";
            comboBoxBuilding.DisplayMember = "Value";
            comboBoxBuilding.SelectedIndex = 0;
            comboBoxHouse.Items.Clear();
            comboBoxHouse.Items.Add(new DictionaryEntry(0, "全部房屋"));
            comboBoxHouse.ValueMember = "Key";
            comboBoxHouse.DisplayMember = "Value";
            comboBoxHouse.SelectedIndex = 0;
            btn_search_Click(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = DB.selectScalar("select name from gzf_building where id=" + e.Value.ToString());
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "男";
                }
                else
                {
                    e.Value = "女";
                }
            }

            if (e.ColumnIndex == 4)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridview(dataGridView1, "sheet1.xls", true);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string buildingQuery = "";
            if (comboBoxBuilding.SelectedIndex != 0)
            {
                buildingQuery = " and building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key;
            }
            string houseQuery = "";
            if (comboBoxHouse.SelectedIndex != 0)
            {
                buildingQuery = " and gzf_guest.house_id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key;
            }
            string nameQuery = "";
            if (txtName.Text.Trim() != "")
            {
                nameQuery = " and gzf_guest.name like '%" + txtName.Text + "%'";
            }
            string idcardQuery = "";
            if (txtIDCard.Text.Trim() != "")
            {
                idcardQuery = " and gzf_guest.idcard like '" + txtIDCard.Text + "%'";
            }
            string companyQuery = "";
            if (comboBoxCompany.Text.Trim() != "")
            {
                nameQuery = " and gzf_guest.company like '%" + comboBoxCompany.Text + "%'";
            }
            dataGridView1.DataSource = DB.select("select * from gzf_guest,gzf_house where gzf_guest.house_id=gzf_house.id" + buildingQuery + houseQuery + nameQuery + idcardQuery + companyQuery + " order by building_id");
        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHouse.Items.Clear();
            comboBoxHouse.Items.Add(new DictionaryEntry(0, "全部房屋"));
            comboBoxHouse.SelectedIndex = 0;
            if ( Convert.ToInt32(((DictionaryEntry)comboBoxBuilding.SelectedItem).Key) != 0)
            {
                DataTable dt = DB.select("select * from gzf_house where building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key);
                foreach (DataRow dr in dt.Rows)
                {
                    DictionaryEntry de = new DictionaryEntry(dr["id"].ToString(), dr["sn"].ToString());
                    comboBoxHouse.Items.Add(de);
                }
                comboBoxHouse.ValueMember = "Key";
                comboBoxHouse.DisplayMember = "Value";
                comboBoxHouse.SelectedIndex = 0;
            }
        }
    }
}
