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
    public partial class changeStatusForm : Form
    {
        private model.House house;
        public changeStatusForm(model.House house)
        {
            InitializeComponent();
            model.HouseStatus housestatus = new gzf.model.HouseStatus(house.status);
            foreach (DictionaryEntry de in housestatus.statusTable)
            {
                if (Convert.ToInt32(de.Key) == 0)
                {
                    continue;
                }
                comboBoxStatus.Items.Add(de);
                if (Convert.ToInt32(de.Key) == house.status)
                {
                    comboBoxStatus.SelectedItem = de;
                }
            }
            comboBoxStatus.ValueMember = "Key";
            comboBoxStatus.DisplayMember = "Value";
            this.house = house;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string status = DB.selectScalar("select status from gzf_house where id=" + house.id);
            if (status == "0")
            {
                MessageBox.Show("占用房不能修改房态！");
                return;
            }
            if (((DictionaryEntry)comboBoxStatus.SelectedItem).Key.ToString() == "0" || ((DictionaryEntry)comboBoxStatus.SelectedItem).Key.ToString() == "6")
            {
                MessageBox.Show("请按正常流程开单！");
                return;
            }
            string cmd = "update gzf_house set status=" + ((DictionaryEntry)comboBoxStatus.SelectedItem).Key + " where id=" + house.id;
            int dbcount = DB.exec_NonQuery(cmd);
            if (dbcount > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
