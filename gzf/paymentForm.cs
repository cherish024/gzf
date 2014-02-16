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
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
            {
                comboBoxDay.Items.Add(i);
            }
            comboBoxDay.SelectedIndex = 2;
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
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string buildingQuery = "";
            if (comboBoxBuilding.SelectedIndex != 0)
            {
                buildingQuery = " and gzf_house.building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key;
            }
            string cmd = "select house_id,openhouse_id from gzf_payment,gzf_house where openhouse_id in (select id from gzf_openhouse where is_jiezhang=0) AND DateDiff (Day,getdate(),end_time) <= " + (comboBoxDay.SelectedIndex + 1) + " and gzf_payment.id in (select max(id) from gzf_payment group by house_id) and gzf_payment.house_id=gzf_house.id" + buildingQuery + " order by gzf_house.building_id,gzf_house.sn";
            dataGridView1.DataSource = DB.select(cmd);
            
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = DB.selectScalar("select gzf_building.name from gzf_house,gzf_building where gzf_house.building_id=gzf_building.id and gzf_house.id=" + e.Value + " order by gzf_house.building_id ASC, gzf_house.floor ASC ");
            }
            if (e.ColumnIndex == 1)
            {
                e.Value = DB.selectScalar("select sn from gzf_house where id=" + e.Value);
            }
            if (e.ColumnIndex == 2)
            {
                e.Value = DB.selectScalar("select name from gzf_guest where openhouse_id=" + e.Value);
            }
            if (e.ColumnIndex == 3)
            {
                e.Value = DB.selectScalar("select phone from gzf_guest where openhouse_id=" + e.Value);
            }
            if (e.ColumnIndex == 4)
            {
                e.Value = Convert.ToDateTime(DB.selectScalar("select end_time from gzf_payment where openhouse_id=" + e.Value + " order by id desc")).ToString("yyyy-MM-dd");
            }
            if (e.ColumnIndex == 5)
            {
                e.Value = DB.selectScalar("select remark from gzf_guest where openhouse_id=" + e.Value);
            }
            if (e.ColumnIndex == 6)
            {
                e.Value = DB.selectScalar("select remark from gzf_openhouse where id=" + e.Value);
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridview(dataGridView1, "sheet1.xls", true);
        }
    }
}
