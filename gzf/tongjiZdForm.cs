using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class tongjiZdForm : Form
    {
        public tongjiZdForm()
        {
            InitializeComponent();
        }

        private void tongjiZdForm_Load(object sender, EventArgs e)
        {
            dateEdit1.Value = DateTime.Now.AddMonths(-1);
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
            if (dateEdit2.Text == "")
            {
                MessageBox.Show("结束日期未选择！");
                return;
            }
            dataGridView1.DataSource = DB.select("select * from gzf_zd zd,gzf_openhouse openhouse where zd.openhouse_id=openhouse.id and zd.addtime>='" + dateEdit1.Text + "' and zd.addtime <='" + dateEdit2.Text + " 23:59:59" + "' order by building_id");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = DB.selectScalar("select name from gzf_building where id=" + e.Value.ToString());
            }
            if (e.ColumnIndex == 2)
            {
                e.Value = DB.selectScalar("select name from gzf_guest where id=" + e.Value.ToString());
            }
            if (e.ColumnIndex == 1)
            {
                e.Value = DB.selectScalar("select sn from gzf_house where id=" + e.Value.ToString());
            }
            if (e.ColumnIndex == 3)
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
            if (e.ColumnIndex == 4)
            {
                e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
            }
            if (e.ColumnIndex == 6)
            {
                e.Value = DB.selectScalar("select username from gzf_user where id=" + e.Value.ToString());
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridviewTongji(dataGridView1, "sheet1.xls", true,"F","退押金",1,false);
        }
    }
}
