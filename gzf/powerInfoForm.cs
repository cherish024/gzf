using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gzf
{
    public partial class powerInfoForm : Form
    {
        public model.OpenHouse openhouse;
        public model.House house;
        public powerInfoForm(model.OpenHouse openhouse, model.House house)
        {
            InitializeComponent();
            this.openhouse = openhouse;
            this.house = house;
        }

        private void powerInfoForm_Load(object sender, EventArgs e)
        {
            dataPower.AutoGenerateColumns = false;
            dataPower.DataSource = DB.select("select * from gzf_power,gzf_house where gzf_power.house_id=gzf_house.id and openhouse_id=" + openhouse.Id + " and gzf_power.status=0");
            if (dataPower.RowCount > 0)
            {
                dataPower.MultiSelect = false;
                dataPower.Rows[dataPower.RowCount - 1].Selected = true;
                //dataPower.CurrentCell = dataPower.Rows[this.dataPower.Rows.Count - 1].Cells[1];
            }
            string shuifei = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + "and status=0");
            if (shuifei == "")
            {
                shuifei = "0";
            }
            lblTotal.Text = shuifei;
        }

        private void btn_powerAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = DB.exec_NonQuery("insert into gzf_power (type,openhouse_id,pay_month,price,house_id,user_id,pay_day,start_time,end_time,status,pay_method) values (1," + openhouse.Id + ",0 ," + txtDian.Value + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "',0,1)");
            count = DB.exec_NonQuery("insert into gzf_power (type,openhouse_id,pay_month,price,house_id,user_id,pay_day,start_time,end_time,status,pay_method) values (4," + openhouse.Id + ",0 ," + txtHot.Value + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "',0,1)");
            count = DB.exec_NonQuery("insert into gzf_power (type,openhouse_id,pay_month,price,house_id,user_id,pay_day,start_time,end_time,status,pay_method) values (0," + openhouse.Id + ",0 ," + txtCool.Value + "," + house.id + "," + common.User.id + ", 0,'" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "',0,1)");

            if (count > 0)
            {
                powerInfoForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btn_powerDel_Click(object sender, EventArgs e)
        {
            if (dataPower.SelectedRows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("是否要删除此记录？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.exec_NonQuery("delete from gzf_power where id=" + dataPower.SelectedRows[0].Cells[0].Value);
                powerInfoForm_Load(sender, e);
            }
        }

        private void dataPower_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                model.powerType powertype = new gzf.model.powerType(Convert.ToInt32(e.Value));
                e.Value = powertype.Statustxt;
            }
            try
            {
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    e.Value = (Convert.ToDateTime(e.Value)).ToString("yyyy-MM-dd");
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = "确认";
                }
            }
            catch
            { }
        }

        private void dataPower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataPower.SelectedRows.Count == 0)
            {
                return;
            }
            editPowerForm power = new editPowerForm(dataPower.SelectedRows[0].Cells[0].Value.ToString());
            power.ShowDialog();
            powerInfoForm_Load(sender, e);
        }

        private void dataPower_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (common.User.type == 2)
                {
                    MessageBox.Show("不可操作");
                    return;
                }
                //if (MessageBox.Show("是否确认此记录？", "确认记录", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                    DB.exec_NonQuery("update gzf_power set status=1 where id=" + dataPower.Rows[e.RowIndex].Cells[0].Value);
                    powerInfoForm_Load(sender, e);
                //}
            }
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Value = dateTimePicker1.Value;
            dateTimePicker5.Value = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Value = dateTimePicker2.Value;
            dateTimePicker6.Value = dateTimePicker2.Value;
        }
    }
}
