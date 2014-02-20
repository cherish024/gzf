using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class tongjiPowerForm : Form
    {
        public tongjiPowerForm()
        {
            InitializeComponent();
        }

        private void tongjiPowerForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.select("select * from gzf_power power,gzf_house house where power.house_id=house.id and power.addtime>='" + dateTimePicker1.Text + "' and power.addtime <='" + dateTimePicker2.Text + " 23:59:59" + "' and power.status=1" + " order by building_id");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "冷水费";
                }
                else if (e.Value.ToString() == "1")
                {
                    e.Value = "电费";
                }
                else if (e.Value.ToString() == "2")
                {
                    e.Value = "电视费";
                }
                else if (e.Value.ToString() == "3")
                {
                    e.Value = "煤气费";
                }
                else if (e.Value.ToString() == "4")
                {
                    e.Value = "热水费";
                }
                else if (e.Value.ToString() == "5")
                {
                    e.Value = "门禁卡";
                }
                else if (e.Value.ToString() == "6")
                {
                    e.Value = "钥匙";
                }
                else
                {
                    e.Value = "其他";
                }
            }
            if (e.ColumnIndex == 1)
            {
                e.Value = DB.selectScalar("select name from gzf_building where id=" + e.Value);
            }
            if (e.ColumnIndex == 3)
            {
                e.Value = DB.selectScalar("select name from gzf_guest where openhouse_id=" + e.Value);
            }
            if (e.ColumnIndex == 7)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
            }
            if (e.ColumnIndex == 9)
            {
                e.Value = DB.selectScalar("select username from gzf_user where id=" + e.Value);
            }
            if (e.ColumnIndex == 8)
            {
                e.Value = common.getPaymethod(e.Value.ToString());
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridviewTongji3(dataGridView1, "sheet1.xls", true, "F", "缴费金额", 3);
        }
    }
}
