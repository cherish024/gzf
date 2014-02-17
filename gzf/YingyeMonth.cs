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
    public partial class YingyeMonth : Form
    {
        SeriesCollection SC = new SeriesCollection();
        SeriesCollection SC2 = new SeriesCollection();
        public YingyeMonth()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lblOpenCount.Text = DB.selectScalar("select count(*) from gzf_openhouse where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            lblHouseCount.Text = DB.selectScalar("select count(*) from gzf_house");
            lblZDCount.Text = DB.selectScalar("select count(*) from gzf_zd where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            //lblStayCount.Text = DB.selectScalar("select count(*) from gzf_house,gzf_openhouse where gzf_openhouse.house_id=gzf_house.id and '" + date + "' between gzf_openhouse.addtime and end_time and (select count(*) from gzf_zd where gzf_zd.openhouse_id=gzf_openhouse.id and '" + date + "'<gzf_zd.addtime)=0");
            //lblPercent.Text = (Convert.ToDouble(lblStayCount.Text) / Convert.ToDouble(lblHouseCount.Text)).ToString("P");
            lblWater.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=0");
            lblDian.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=1");
            lbltv.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=2");
            lblMeiqi.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=3");
            lblHotwater.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=4");
            lblKey.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=6");
            lblDoor.Text = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and type=5");

            lblHousePrice.Text = DB.selectScalar("select sum(pay) from gzf_payment where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            lblYaJing.Text = DB.selectScalar("select sum(deposit) from gzf_openhouse where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            if (lblWater.Text == "")
            {
                lblWater.Text = "0";
            }
            if (lblDian.Text == "")
            {
                lblDian.Text = "0";
            }
            if (lblHousePrice.Text == "")
            {
                lblHousePrice.Text = "0";
            }
            if (lblYaJing.Text == "")
            {
                lblYaJing.Text = "0";
            }
            if (lblHotwater.Text == "")
            {
                lblHotwater.Text = "0";
            }
            if (lbltv.Text == "")
            {
                lbltv.Text = "0";
            }
            if (lblMeiqi.Text == "")
            {
                lblMeiqi.Text = "0";
            }
            if (lblKey.Text == "")
            {
                lblKey.Text = "0";
            }
            if (lblDoor.Text == "")
            {
                lblDoor.Text = "0";
            }
            lblTotal.Text = (Convert.ToInt32(lblWater.Text) + Convert.ToInt32(lblDian.Text) + Convert.ToInt32(lblHousePrice.Text) + Convert.ToInt32(lblYaJing.Text)).ToString();

            SC.Clear();
            SC2.Clear();
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(0);
            int x = 10;
            int y = 30;
            groupBoxOpen.Controls.Clear();
            groupBoxClose.Controls.Clear();
            dataGridView1.Rows.Clear();
            foreach (DictionaryEntry de in kind.statusTable)
            {
                //绑定导出明细开始
                DataTable money = DB.select("select SUM(gzf_payment.pay) as pay,SUM(gzf_payment.cash) as cash,SUM(gzf_payment.credit) as credit,SUM(gzf_payment.other) as other from gzf_openhouse,gzf_payment where gzf_payment.openhouse_id = gzf_openhouse.id and kind=" + de.Key + " and month(gzf_payment.addtime)=" + comboBoxMonth.SelectedItem);
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView1);
                dr.Cells[0].Value = de.Value;
                dr.Cells[1].Value = money.Rows[0]["pay"].ToString() != "" ? money.Rows[0]["pay"] : "0";
                dr.Cells[2].Value = money.Rows[0]["cash"].ToString() != "" ? money.Rows[0]["cash"] : "0";
                dr.Cells[3].Value = money.Rows[0]["credit"].ToString() != "" ? money.Rows[0]["credit"] : "0";
                dr.Cells[4].Value = money.Rows[0]["other"].ToString() != "" ? money.Rows[0]["other"] : "0";
                dataGridView1.Rows.Add(dr);
                //绑定导出明细结束
                string count = DB.selectScalar("select count(*) from gzf_openhouse where kind=" + de.Key + " and year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
                string count2 = DB.selectScalar("select count(*) from gzf_openhouse,gzf_zd where kind=" + de.Key + " and year(gzf_zd.addtime)=" + comboBoxYear.SelectedItem + " and month(gzf_zd.addtime)=" + comboBoxMonth.SelectedItem + " and gzf_zd.openhouse_id=gzf_openhouse.id");
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Width = 98;
                lbl.Height = 12;
                lbl.Text = de.Value.ToString() + "：" + count;
                lbl.Location = new Point(x, y);
                System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
                lbl2.Width = 100;
                lbl2.Height = 12;
                lbl2.Location = new Point(x, y);
                lbl2.Text = de.Value.ToString() + "：" + count2;
                groupBoxOpen.Controls.Add(lbl);
                groupBoxClose.Controls.Add(lbl2);
                x += lbl.Size.Width + 6;
                //填充拼图元素
                Series s = new Series();
                s.Name = de.Value.ToString();
                Element el = new Element();
                // 每元素的名称
                el.Name = de.Value.ToString();
                // 每元素的大小数值
                el.YValue = Convert.ToInt32(count);
                s.Elements.Add(el);
                SC.Add(s);
                //填充拼图元素
                Series s2 = new Series();
                s2.Name = de.Value.ToString();
                Element el2 = new Element();
                // 每元素的名称
                el2.Name = de.Value.ToString();
                // 每元素的大小数值
                el2.YValue = Convert.ToInt32(count2);
                s2.Elements.Add(el2);
                SC2.Add(s2);
            }
            model.powerType powertype = new gzf.model.powerType(0);
            foreach (DictionaryEntry de in powertype.statusTable)
            {
                string cash = "0", credit = "0", other = "0";
                DataTable money = DB.select("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + "  and month(gzf_power.addtime)=" + comboBoxMonth.SelectedItem + " and status=1");
                cash = DB.selectScalar("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and month(gzf_power.addtime)=" + comboBoxMonth.SelectedItem + " and status=1 and gzf_power.pay_method=1");
                credit = DB.selectScalar("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and month(gzf_power.addtime)=" + comboBoxMonth.SelectedItem + " and status=1 and gzf_power.pay_method=2");
                other = DB.selectScalar("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and month(gzf_power.addtime)=" + comboBoxMonth.SelectedItem + " and status=1 and gzf_power.pay_method=3");
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView1);
                dr.Cells[0].Value = de.Value;
                dr.Cells[1].Value = money.Rows[0]["pay"].ToString() != "" ? money.Rows[0]["pay"] : "0";
                dr.Cells[2].Value = cash != "" ? cash : "0";
                dr.Cells[3].Value = credit != "" ? credit : "0";
                dr.Cells[4].Value = other != "" ? other : "0";
                dataGridView1.Rows.Add(dr);
            }
            //加载饼图
            chart1.YAxis.Percent = true;
            //chart1.DefaultElement.SmartLabel.PieLabelMode = PieLabelMode.Outside;
            chart1.DefaultElement.SmartLabel.Text = "<%PercentOfTotal,0.00>";
            chart1.SeriesCollection.Clear();
            chart1.SeriesCollection.Add(SC);

            //加载饼图
            chart2.YAxis.Percent = true;
            //chart2.DefaultElement.SmartLabel.PieLabelMode = PieLabelMode.Outside;
            chart2.DefaultElement.SmartLabel.Text = "<%PercentOfTotal,0.00>";
            chart2.SeriesCollection.Clear();
            chart2.SeriesCollection.Add(SC2);
            chart1.Refresh();
            chart2.Refresh();
        }

        private void YingyeMonth_Load(object sender, EventArgs e)
        {
            comboBoxYear.SelectedItem = DateTime.Now.Year.ToString();
            comboBoxMonth.SelectedItem = DateTime.Now.Month.ToString();
            btn_search_Click(sender, e);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridviewTongji2(dataGridView1, "sheet1.xls", true, "B", "金额", "现金", "信用卡", "其他");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
 
        }
    }
}
