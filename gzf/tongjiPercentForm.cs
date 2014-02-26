using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace gzf
{
    public partial class tongjiPercentForm : Form
    {
        public tongjiPercentForm()
        {
            InitializeComponent();
        }

        private void tongjiPercentForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            dataGridView1.AutoGenerateColumns = false;
            btn_search_Click(sender, e);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            XmlDocument configXml = new XmlDocument();
            configXml.Load("config.xml");
            string count = configXml["config"]["Tongji"].InnerText;
            dataGridView1.Rows.Clear();
            int days = ((dateTimePicker2.Value) - (dateTimePicker1.Value)).Days + 2;
            string houseCount = DB.selectScalar("select count(*) from gzf_house");
            double num = 0;
            for (int i = 0; i < days; i++)
            { 
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView1);
                dr.Cells[0].Value = dateTimePicker1.Value.AddDays(i).ToString("yyyy-MM-dd");
                dr.Cells[1].Value = DB.selectScalar("select count(*) from gzf_openhouse where convert(varchar(10),addtime,120)='" + dr.Cells[0].Value + "'");
                dr.Cells[2].Value = Convert.ToInt32(houseCount) - Convert.ToInt32(count);
                dr.Cells[3].Value = DB.selectScalar("select count(*) from gzf_openhouse where (select count(*) from gzf_zd where gzf_zd.openhouse_id=gzf_openhouse.id and '" + dr.Cells[0].Value + "'<gzf_zd.addtime)=0");
                dr.Cells[4].Value = (Convert.ToDouble(dr.Cells[3].Value) / Convert.ToDouble(dr.Cells[2].Value)).ToString("P");
                num += (Convert.ToDouble(dr.Cells[3].Value) / Convert.ToDouble(dr.Cells[2].Value));
                dataGridView1.Rows.Add(dr);
            }
            lblPercent.Text = (num / dataGridView1.Rows.Count).ToString("P");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridview(dataGridView1, "sheet1.xls", true);
        }
    }
}
