using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace gzf
{
    public partial class guestInfoListForm : Form
    {
        model.House house;
        public guestInfoListForm(model.House house)
        {
            InitializeComponent();
            this.house = house;
        }

        private void guestInfoListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = DB.select("select * from gzf_guest where house_id=" + house.id + " and openhouse_id=" + common.GetOpenhouse_id(house.id));
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "男";
                }
                else
                {
                    e.Value = "女";
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (e.Value.ToString() != "")
                {
                    e.Value = (Convert.ToDateTime(e.Value.ToString())).ToString("yyyy-MM-dd");
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addGuestForm add = new addGuestForm(house);
            add.ShowDialog();
            guestInfoListForm_Load(sender, e);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            model.Guest guest = new gzf.model.Guest();
            string guestid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DataTable dt = DB.select("select * from gzf_guest where id=" + guestid);
            guest.Id = Convert.ToInt32(guestid);
            guest.Name = dt.Rows[0]["name"].ToString();
            guest.Idcard = dt.Rows[0]["idcard"].ToString();
            guest.Phone = dt.Rows[0]["phone"].ToString();
            guest.Remark = dt.Rows[0]["remark"].ToString();
            guest.Birthday = Convert.ToDateTime(dt.Rows[0]["birthday"]);
            guest.Sex = Convert.ToInt16(dt.Rows[0]["sex"]);
            guest.Address = dt.Rows[0]["address"].ToString();
            guest.Job = dt.Rows[0]["job"].ToString();
            guest.Company = dt.Rows[0]["company"].ToString();
            guest.Student = dt.Rows[0]["student"].ToString();
            if (((byte[])dt.Rows[0]["pic"]).Length > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["pic"]);
                guest.Pic = Image.FromStream(ms);
            }
            guestinfoForm gif = new guestinfoForm(guest);
            gif.ShowDialog();
            guestInfoListForm_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == common.GetMain_Guest_Id(house.id))
            {
                MessageBox.Show("主客信息不可删除！");
                return;
            }
            if (MessageBox.Show("是否要删除此租客？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_guest where id=" + dataGridView1.SelectedRows[0].Cells[0].Value);
                guestInfoListForm_Load(sender, e);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btn_edit_Click(sender, e);
        }
    }
}
