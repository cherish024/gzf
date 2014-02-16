using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class tongjiFapiaoForm : Form
    {
        public tongjiFapiaoForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.select("select * from gzf_payment,gzf_openhouse where gzf_payment.fapiao like '" + textBox1.Text + "%' and gzf_payment.openhouse_id=gzf_openhouse.id");
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
                    e.Value = Convert.ToDateTime(e.Value).ToString("yyyy-MM-dd");
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = DB.selectScalar("select username from gzf_user where id=" + e.Value.ToString());
                }
            }
            catch { }
        }
    }
}
