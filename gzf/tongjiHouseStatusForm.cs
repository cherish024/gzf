using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using dotnetCHARTING.WinForms;

namespace gzf
{
    public partial class tongjiHouseStatusForm : Form
    {
        SeriesCollection SC = new SeriesCollection();
        //Series s = new Series();
        public tongjiHouseStatusForm()
        {
            InitializeComponent();
        }

        private void tongjiHouseStatusForm_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("宋体", 12f);
            Graphics g = e.Graphics;

        }

        private void tongjiHouseStatusForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            model.HouseStatus housestatus = new gzf.model.HouseStatus(0);
            foreach (DictionaryEntry de in housestatus.statusTable)
            {
                comboBoxStatus.Items.Add(de);
            }
            comboBoxStatus.ValueMember = "Key";
            comboBoxStatus.DisplayMember = "Value";
            DataTable dt = DB.select("select * from gzf_building");
            comboBoxBuilding.Items.Add("全部建筑");

            foreach (DataRow dr in dt.Rows)
            {
                DictionaryEntry de = new DictionaryEntry(dr["id"].ToString(),dr["name"].ToString());
                comboBoxBuilding.Items.Add(de);
            }
            comboBoxBuilding.ValueMember = "Key";
            comboBoxBuilding.DisplayMember = "Value";
            comboBoxBuilding.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 4;
            btn_search_Click(sender, e);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridview(dataGridView1, "sheet1.xls", true);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SC.Clear();
            Series s = new Series();
            string buildingQuery = "";
            if (comboBoxBuilding.SelectedIndex != 0)
            { 
                buildingQuery = " and building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key;
            }
            dataGridView1.DataSource = DB.select("select * from gzf_house,gzf_building where status=" + ((DictionaryEntry)comboBoxStatus.SelectedItem).Key + " and gzf_house.building_id=gzf_building.id" + buildingQuery);
            lblNum.Text = dataGridView1.Rows.Count.ToString();
            if (comboBoxStatus.SelectedIndex == 4)
            {
                //加载统计信息
                model.OpenHouseKind kind = new gzf.model.OpenHouseKind(1);
                int x = 0;
                int y = 20;
                panelKind.Controls.Clear();
                string cond = "";
                if (comboBoxBuilding.SelectedIndex != 0)
                {
                    cond = "and gzf_openhouse.building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key;
                }
                foreach (DictionaryEntry de in kind.statusTable)
                {
                    //string count = DB.selectScalar("select count(*) from gzf_openhouse where is_jiezhang=0 and kind=" + de.Key + cond);
                    string count = DB.selectScalar("select count(*) from gzf_openhouse,gzf_house where gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and kind=" + de.Key + " and gzf_openhouse.id in (select Max(id) from gzf_openhouse WHERE is_jiezhang=0" + cond + " group by house_id)");
                    System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                    lbl.Text = de.Value.ToString() + "：" + count;
                    lbl.Location = new Point(x, y);
                    panelKind.Controls.Add(lbl);
                    x += lbl.Size.Width + 6;
                    //填充拼图元素
                    Element el = new Element();
                    // 每元素的名称
                    el.Name = de.Value.ToString();
                    // 每元素的大小数值
                    el.YValue = Convert.ToInt32(count);
                    s.Elements.Add(el);
                }
                s.Name = "房屋类型图";
                SC.Add(s);
                panelKind.Visible = true;
                //加载饼图
                //chart1.YAxis.Percent = true;
                //chart1.DefaultElement.SmartLabel.PieLabelMode = PieLabelMode.Outside;
                chart1.DefaultElement.SmartLabel.Text = "<%PercentOfTotal,0.00>";
                chart1.SeriesCollection.Clear();
                chart1.SeriesCollection.Add(SC);
                //chart1.XAxis.StaticColumnWidth = 900;
                chart1.Refresh();
            }
            else
            {
                panelKind.Visible = false;
                //加载饼图
                chart1.SeriesCollection.Clear();
                chart1.Refresh();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
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
    }
}
