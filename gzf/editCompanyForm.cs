using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class editCompanyForm : Form
    {
        public editCompanyForm()
        {
            InitializeComponent();
        }

        private void editCompanyForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = DB.select("select * from gzf_company");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.exec_NonQuery("insert into gzf_company values ('" + textBox1.Text + "')");
            editCompanyForm_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此记录？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_company where id=" + dataGridView1.SelectedRows[0].Cells[0].Value);
                editCompanyForm_Load(sender, e);
            }
        }
    }
}
