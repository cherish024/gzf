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
    public partial class tongjiYajingForm : Form
    {
        public tongjiYajingForm()
        {
            InitializeComponent();
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
                buildingQuery = " and house_id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key;
            }
            dataGridView1.DataSource = DB.select("select * from gzf_openhouse where deposit_sn like '" + textBox1.Text + "%'" + buildingQuery + houseQuery);
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    e.Value = DB.selectScalar("select name from gzf_guest where id=" + e.Value.ToString());
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = DB.selectScalar("select name from gzf_building where id=" + e.Value.ToString());
                }
                if (e.ColumnIndex == 4)
                {
                    e.Value = DB.selectScalar("select sn from gzf_house where id=" + e.Value.ToString());
                }
                if (e.ColumnIndex == 5)
                {
                    if (e.Value.ToString() == "0")
                    {
                        e.Value = "个人";
                    }
                    else
                    {
                        e.Value = "团体";
                    }
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = DB.selectScalar("select username from gzf_user where id=" + e.Value.ToString());
                }
            }
            catch { }
        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHouse.Items.Clear();
            comboBoxHouse.Items.Add(new DictionaryEntry(0, "全部房屋"));
            comboBoxHouse.SelectedIndex = 0;
            if (Convert.ToInt32(((DictionaryEntry)comboBoxBuilding.SelectedItem).Key) != 0)
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
