using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using dotnetCHARTING.WinForms;
using System.Xml;

namespace gzf
{
    public partial class YingyeDayForm : Form
    {
        SeriesCollection SC = new SeriesCollection();
        SeriesCollection SC2 = new SeriesCollection();
        public YingyeDayForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            XmlDocument configXml = new XmlDocument();
            configXml.Load("config.xml");
            string countJian =  configXml["config"]["Tongji"].InnerText;
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string countOpenTotal = DB.selectScalar("select count(*) from gzf_openhouse where convert(varchar(10),addtime,120)='" + date + "'");
            string countCloseTotal = DB.selectScalar("select count(*) from gzf_openhouse,gzf_zd where convert(varchar(10),gzf_zd.addtime,120)='" + date + "' and gzf_zd.openhouse_id=gzf_openhouse.id");

            lblOpenCount.Text = DB.selectScalar("select count(*) from gzf_openhouse where convert(varchar(10),addtime,120)='" + date + "'");
            lblHouseCount.Text = (Convert.ToInt32(DB.selectScalar("select count(*) from gzf_house")) - Convert.ToInt32(countJian)).ToString();
            lblZDCount.Text = DB.selectScalar("select count(*) from gzf_zd where convert(varchar(10),addtime,120)='" + date + "'");
            lblStayCount.Text = DB.selectScalar("select count(*) from gzf_house,gzf_openhouse where gzf_openhouse.house_id=gzf_house.id and '" + date + "' between gzf_openhouse.addtime and end_time and (select count(*) from gzf_zd where gzf_zd.openhouse_id=gzf_openhouse.id and '" + date + "'<gzf_zd.addtime)=0");
            lblPercent.Text = (Convert.ToDouble(lblStayCount.Text) / Convert.ToDouble(lblHouseCount.Text)).ToString("P");
            lblWater.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=0 and status=1");
            lblDian.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=1 and status=1");
            lbltv.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=2 and status=1");
            lblMeiqi.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=3 and status=1");
            lblHotwater.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=4 and status=1");
            lblKey.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=6 and status=1");
            lblDoor.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=5 and status=1");
            lblOther.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and type=7 and status=1");
            lblPowerTotal.Text = DB.selectScalar("select sum(price) from gzf_power where convert(varchar(10),addtime,120)='" + date + "' and status=1");
            lblHousePrice.Text = DB.selectScalar("select sum(pay) from gzf_payment where convert(varchar(10),addtime,120)='" + date + "'");
            lblYaJing.Text = DB.selectScalar("select sum(deposit) from gzf_openhouse where convert(varchar(10),addtime,120)='" + date + "'");

            lblWater.Text = lblWater.Text == "" ? "0" : lblWater.Text;
            lblDian.Text = lblDian.Text == "" ? "0" : lblDian.Text;
            lblHousePrice.Text = lblHousePrice.Text == "" ? "0" : lblHousePrice.Text;
            lblYaJing.Text = lblYaJing.Text == "" ? "0" : lblYaJing.Text;
            lblHotwater.Text = lblHotwater.Text == "" ? "0" : lblHotwater.Text;
            lbltv.Text = lbltv.Text == "" ? "0" : lbltv.Text;
            lblMeiqi.Text = lblMeiqi.Text == "" ? "0" : lblMeiqi.Text;
            lblKey.Text = lblKey.Text == "" ? "0" : lblKey.Text;
            lblDoor.Text = lblDoor.Text == "" ? "0" : lblDoor.Text;
            lblOther.Text = lblOther.Text == "" ? "0" : lblOther.Text;
            lblPowerTotal.Text = lblPowerTotal.Text == "" ? "0" : lblPowerTotal.Text;


            lblTotal.Text = (Convert.ToInt32(lblPowerTotal.Text) + Convert.ToInt32(lblHousePrice.Text) + Convert.ToInt32(lblYaJing.Text)).ToString();
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(0);
            SC.Clear();
            SC2.Clear();
            int x = 10;
            int y = 30;
            groupBoxOpen.Controls.Clear();
            groupBoxClose.Controls.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            foreach (DictionaryEntry de in kind.statusTable)
            {
                //绑定收费统计导出明细开始
                DataTable money = DB.select("select SUM(gzf_payment.pay) as pay,SUM(gzf_payment.cash) as cash,SUM(gzf_payment.credit) as credit,SUM(gzf_payment.other) as other from gzf_openhouse,gzf_payment where gzf_payment.openhouse_id = gzf_openhouse.id and kind=" + de.Key + " and convert(varchar(10),gzf_payment.addtime,120)='" + date + "'");
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView1);
                dr.Cells[0].Value = de.Value;
                dr.Cells[1].Value = money.Rows[0]["pay"].ToString() != "" ? money.Rows[0]["pay"] : "0";
                dr.Cells[2].Value = money.Rows[0]["cash"].ToString() != "" ? money.Rows[0]["cash"] : "0";
                dr.Cells[3].Value = money.Rows[0]["credit"].ToString() != "" ? money.Rows[0]["credit"] : "0";
                dr.Cells[4].Value = money.Rows[0]["other"].ToString() != "" ? money.Rows[0]["other"] : "0";
                dataGridView1.Rows.Add(dr);
                //绑定收费统计导出明细结束
                string count = DB.selectScalar("select count(*) from gzf_openhouse where kind=" + de.Key + " and convert(varchar(10),addtime,120)='" + date + "'");
                string count2 = DB.selectScalar("select count(*) from gzf_openhouse,gzf_zd where kind=" + de.Key + " and convert(varchar(10),gzf_zd.addtime,120)='" + date + "' and gzf_zd.openhouse_id=gzf_openhouse.id");
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
                if (x > groupBoxOpen.Width)
                {
                    x = 10;
                    y += 30;
                }
                //绑定房屋统计导出
                DataGridViewRow dr3 = new DataGridViewRow();
                dr3.CreateCells(dataGridView2);
                dr3.Cells[0].Value = de.Value;
                dr3.Cells[1].Value = count;
                dr3.Cells[2].Value = (Convert.ToDouble(count) / Convert.ToDouble(countOpenTotal)).ToString("P");
                dr3.Cells[3].Value = count2;
                dr3.Cells[4].Value = (Convert.ToDouble(count2) / Convert.ToDouble(countCloseTotal)).ToString("P");
                dataGridView2.Rows.Add(dr3);
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
                DataTable money = DB.select("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and convert(varchar(10),gzf_power.addtime,120)='" + date + "' and status=1");
                cash = DB.selectScalar("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and convert(varchar(10),gzf_power.addtime,120)='" + date + "' and status=1 and gzf_power.pay_method=1");
                credit = DB.selectScalar("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and convert(varchar(10),gzf_power.addtime,120)='" + date + "' and status=1 and gzf_power.pay_method=2");
                other = DB.selectScalar("select SUM(gzf_power.price) as pay from gzf_openhouse,gzf_power where gzf_power.openhouse_id = gzf_openhouse.id and gzf_power.type=" + de.Key + " and convert(varchar(10),gzf_power.addtime,120)='" + date + "' and status=1 and gzf_power.pay_method=3");
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView1);
                dr.Cells[0].Value = de.Value;
                dr.Cells[1].Value = money.Rows[0]["pay"].ToString() != "" ? money.Rows[0]["pay"] : "0";
                dr.Cells[2].Value = cash != "" ? cash : "0";
                dr.Cells[3].Value = credit != "" ? credit : "0";
                dr.Cells[4].Value = other != "" ? other : "0";
                dataGridView1.Rows.Add(dr);
            }
            DataGridViewRow dr2 = new DataGridViewRow();
            dr2.CreateCells(dataGridView1);
            dr2.Cells[0].Value = "押金";
            dr2.Cells[1].Value = lblYaJing.Text;
            dr2.Cells[2].Value = lblYaJing.Text;
            dr2.Cells[3].Value = "0";
            dr2.Cells[4].Value = "0";
            dataGridView1.Rows.Add(dr2);
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

        private void YingyeDayForm_Load(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridviewTongji2(dataGridView1, "sheet1.xls", true, "B", "金额", "现金", "信用卡", "其他");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            common.ExportForDataGridview(dataGridView2, "sheet1.xls", true);
        }
    }
}
