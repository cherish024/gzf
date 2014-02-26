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
    public partial class tongjiMonth : Form
    {
        SeriesCollection SC = new SeriesCollection();
        SeriesCollection SC2 = new SeriesCollection();
        public tongjiMonth()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            XmlDocument configXml = new XmlDocument();
            configXml.Load("config.xml");
            string countJian = configXml["config"]["Tongji"].InnerText;
            string countOpenTotal = DB.selectScalar("select count(*) from gzf_openhouse where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            string countCloseTotal = DB.selectScalar("select count(*) from gzf_openhouse,gzf_zd where year(gzf_zd.addtime)=" + comboBoxYear.SelectedItem + " and month(gzf_zd.addtime)=" + comboBoxMonth.SelectedItem + " and gzf_zd.openhouse_id=gzf_openhouse.id");
            string date = Convert.ToDateTime(comboBoxYear.SelectedItem + "-" + comboBoxMonth.SelectedItem).AddDays(1 - Convert.ToDateTime(comboBoxYear.SelectedItem + "-" + comboBoxMonth.SelectedItem).Day).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
            lblOpenCount.Text = DB.selectScalar("select count(*) from gzf_openhouse where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            lblHouseCount.Text = (Convert.ToInt32(DB.selectScalar("select count(*) from gzf_house where building_id!=2 and building_id!=4 and building_id!=5 and building_id!=6 and building_id!=7 and building_id!=8 and building_id!=12 and building_id!=20")) - Convert.ToInt32(countJian)).ToString();
            lblZDCount.Text = DB.selectScalar("select count(*) from gzf_zd where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            lblStayCount.Text = DB.selectScalar("select count(*) from gzf_openhouse where (select count(*) from gzf_zd where gzf_zd.openhouse_id=gzf_openhouse.id and '" + date + "'>gzf_zd.addtime)=0" + " and gzf_openhouse.kind !=3 and gzf_openhouse.kind !=4 and gzf_openhouse.kind !=5 and gzf_openhouse.building_id!=2 and gzf_openhouse.building_id!=4 and gzf_openhouse.building_id!=5 and gzf_openhouse.building_id!=6 and gzf_openhouse.building_id!=7 and gzf_openhouse.building_id!=8 and gzf_openhouse.building_id!=12 and gzf_openhouse.building_id!=20");
            lblPercent.Text = (Convert.ToDouble(lblStayCount.Text) / Convert.ToDouble(lblHouseCount.Text)).ToString("P");
            lblPeople.Text = DB.selectScalar("select count(*) from gzf_guest,gzf_openhouse,gzf_house where gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and is_jiezhang=0 and gzf_guest.openhouse_id=gzf_openhouse.id" + " and gzf_openhouse.id in (select Max(id) from gzf_openhouse WHERE is_jiezhang=0 group by house_id)");
            string lblPowerTotal = DB.selectScalar("select sum(price) from gzf_power where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem + " and status=1");
            string lblHousePrice = DB.selectScalar("select sum(pay) from gzf_payment where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);
            string lblYaJing = DB.selectScalar("select sum(deposit) from gzf_openhouse where year(addtime)=" + comboBoxYear.SelectedItem + " and month(addtime)=" + comboBoxMonth.SelectedItem);

            lblHousePrice = lblHousePrice == "" ? "0" : lblHousePrice;
            lblYaJing = lblYaJing == "" ? "0" : lblYaJing;
            lblPowerTotal = lblPowerTotal == "" ? "0" : lblPowerTotal;

            lblKechuzu.Text = (Convert.ToInt32(lblHouseCount.Text) - Convert.ToInt32(lblStayCount.Text)).ToString();
            lblTotal.Text = (Convert.ToInt32(lblPowerTotal) + Convert.ToInt32(lblHousePrice) + Convert.ToInt32(lblYaJing)).ToString();

            SC.Clear();
            SC2.Clear();
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(0);
            int x = 10;
            int y = 30;
            groupBoxOpen.Controls.Clear();
            groupBoxClose.Controls.Clear();
            foreach (DictionaryEntry de in kind.statusTable)
            {
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
                if (x > groupBoxOpen.Width)
                {
                    x = 10;
                    y += 30;
                }
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

    }
}
