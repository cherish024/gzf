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
    public partial class tongjiPayForm : Form
    {
        public tongjiPayForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string buildingQuery = "";
            if (comboBoxBuilding.SelectedIndex != 0)
            {
                buildingQuery = " and house.building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key;
            }
            dataGridView1.DataSource = DB.select("select * from gzf_payment payment,gzf_house house,gzf_building building where payment.house_id=house.id and payment.addtime>='" + dateTimePicker1.Text + "' and payment.addtime <='" + dateTimePicker2.Text + " 23:59:59" + "' and house.building_id=building.id" + buildingQuery + " order by building_id");
        }

        private void tongjiPayForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
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
            dataGridView1.AutoGenerateColumns = false;
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
            if (e.ColumnIndex == 2)
            {
                e.Value = DB.selectScalar("select name from gzf_guest where openhouse_id=" + e.Value);
            }
            if (e.ColumnIndex == 5)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
            }
            if (e.ColumnIndex == 11)
            {
                e.Value = DB.selectScalar("select username from gzf_user where id=" + e.Value);
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridviewTongji2(dataGridView1, "sheet1.xls", true, "D", "缴费金额", "现金部分", "信用卡部分", "其他部分");
        }
    }
}
