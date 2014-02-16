using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class tongjiOpen : Form
    {
        public tongjiOpen()
        {
            InitializeComponent();
        }

        private void tongjiOpen_Load(object sender, EventArgs e)
        {
            dateEdit1.Value = DateTime.Now.AddMonths(-1);
            dataGridView1.AutoGenerateColumns = false;
            btn_search_Click(sender, e);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (dateEdit2.Text == "")
            {
                MessageBox.Show("结束日期未选择！");
                return;
            }
            dataGridView1.DataSource = DB.select("select * from gzf_openhouse where addtime>='" + dateEdit1.Text + "' and addtime <='" + dateEdit2.Text + " 23:59:59" + "' order by building_id");

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    e.Value = DB.selectScalar("select name from gzf_guest where id=" + e.Value.ToString());
                }
                if (e.ColumnIndex == 0)
                {
                    e.Value = DB.selectScalar("select name from gzf_building where id=" + e.Value.ToString());
                }
                if (e.ColumnIndex == 1)
                {
                    e.Value = DB.selectScalar("select sn from gzf_house where id=" + e.Value.ToString());
                }
                if (e.ColumnIndex == 5)
                {
                    e.Value = DB.selectScalar("select pay from gzf_payment where openhouse_id=" + e.Value.ToString() + " ORDER BY addtime ASC");
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = DB.selectScalar("select cash from gzf_payment where openhouse_id=" + e.Value.ToString() + " ORDER BY addtime ASC");
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = DB.selectScalar("select credit from gzf_payment where openhouse_id=" + e.Value.ToString() + " ORDER BY addtime ASC");
                }
                if (e.ColumnIndex == 8)
                {
                    e.Value = DB.selectScalar("select other from gzf_payment where openhouse_id=" + e.Value.ToString() + " ORDER BY addtime ASC");
                }
                if (e.ColumnIndex == 10)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
                }
                if (e.ColumnIndex == 13)
                {
                    e.Value = DB.selectScalar("select username from gzf_user where id=" + e.Value.ToString());
                }
            }
            catch { }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridviewTongji4(dataGridView1, "sheet1.xls", true, "F", "D" , "缴费金额","押金金额", "现金", "信用卡", "其他方式");
        }
    }
}
