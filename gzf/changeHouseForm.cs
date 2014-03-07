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
    public partial class changeHouseForm : Form
    {
        model.House house;
        public changeHouseForm(model.House house)
        {
            InitializeComponent();
            this.house = house;
        }

        private void changeHouseForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DB.select("select * from gzf_building");
            foreach (DataRow dr in dt.Rows)
            {
                DictionaryEntry de = new DictionaryEntry(dr["id"].ToString(), dr["name"].ToString());
                comboBoxBuilding.Items.Add(de);
            }
            comboBoxBuilding.ValueMember = "Key";
            comboBoxBuilding.DisplayMember = "Value";
            comboBoxBuilding.SelectedIndex = 0;
            comboBoxBuilding_SelectedIndexChanged(sender, e);
            lblHouse.Text = house.sn;
            lblBuilding.Text = DB.selectScalar("select name from gzf_building where id=" + house.building_id);
        }

        private void comboBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHouse.Items.Clear();
            DataTable dt = DB.select("select * from gzf_house where building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key + " order by sn");
            foreach (DataRow dr in dt.Rows)
            {
                DictionaryEntry de = new DictionaryEntry(dr["id"].ToString(), dr["sn"].ToString());
                comboBoxHouse.Items.Add(de);
            }
            comboBoxHouse.ValueMember = "Key";
            comboBoxHouse.DisplayMember = "Value";
            if (comboBoxHouse.Items.Count > 0)
            {
                comboBoxHouse.SelectedIndex = 0;
            }
        }

        private void comboBoxHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price = DB.selectScalar("select price from gzf_house where id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key);
            txtPrice.Value = Convert.ToInt32(price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定更换房间？", "确认更换", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string openid = common.GetOpenhouse_id(house.id);
            string newhouse_openid = common.GetOpenhouse_id(Convert.ToInt32(((DictionaryEntry)comboBoxHouse.SelectedItem).Key));
            if (openid.Trim() == "")
            {
                MessageBox.Show("更换失败！");
                return;
            }

            //更新开房表
            int count = DB.exec_NonQuery("update gzf_openhouse set house_id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key + ", price=" + txtPrice.Value + ", building_id=" + ((DictionaryEntry)comboBoxBuilding.SelectedItem).Key + " WHERE id=" + openid);
            //string is_team = DB.selectScalar("select is_team from gzf_openhouse where id=" + openid);
            if (count == 0)
            {
                MessageBox.Show("更换失败！");
                return;
            }
            //if (is_team == openid)
            //{
            //    //更换主房间
            //    DataTable dt = DB.select("select id from gzf_openhouse where is_team=" + openid);
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        DB.exec_NonQuery("update gzf_openhouse set is_team=" + newhouse_openid + " WHERE id=" + dr["id"].ToString());
            //    }
            //}
            //新换房间是已入住房
            if (newhouse_openid != "")
            {
                //更新付款表
                DB.exec_NonQuery("update gzf_payment set openhouse_id=" + openid + " WHERE openhouse_id=" + newhouse_openid);
                DB.exec_NonQuery("update gzf_power set openhouse_id=" + openid + " WHERE openhouse_id=" + newhouse_openid);
                //更新客户表
                DB.exec_NonQuery("update gzf_guest set openhouse_id=" + openid + " WHERE openhouse_id=" + newhouse_openid);
                //删除原开房表
                DB.exec_NonQuery("delete from gzf_openhouse WHERE id=" + newhouse_openid);
            }
            //更新付款表
            DB.exec_NonQuery("update gzf_payment set house_id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key + " WHERE openhouse_id=" + openid);
            DB.exec_NonQuery("update gzf_power set house_id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key + " WHERE openhouse_id=" + openid);
            //更改房间状态
            DB.exec_NonQuery("update gzf_house set status=" + house.status + " where id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key);
            DB.exec_NonQuery("update gzf_house set status=2 where id=" + house.id);
            //更新客户表
            DB.exec_NonQuery("update gzf_guest set house_id=" + ((DictionaryEntry)comboBoxHouse.SelectedItem).Key + " WHERE openhouse_id=" + openid);
            MessageBox.Show("更换房间成功！");
            this.Close();
        }
    }
}
