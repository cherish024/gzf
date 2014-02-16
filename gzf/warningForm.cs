using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Excel;

namespace gzf
{
    
    public partial class warningForm : Form
    {
        public warningForm()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                comboBoxDay.Items.Add(i);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void warningForm_Load(object sender, EventArgs e)
        {
            listBoxMsg.Items.Clear();
            listBoxMsg.ValueMember = "Key";
            listBoxMsg.DisplayMember = "Value";
            System.Data.DataTable dt = DB.select("select * from gzf_warning,gzf_house where is_read!=3 and gzf_warning.house_id=gzf_house.id order by building_id");
            foreach (DataRow dr in dt.Rows)
            {
                System.Data.DataTable dt2 = DB.select("select sn,name,end_time from gzf_building,gzf_warning,gzf_openhouse,gzf_house where gzf_house.id=" + dr["house_id"] + " and gzf_house.building_id=gzf_building.id and gzf_openhouse.id=gzf_warning.openhouse_id and gzf_warning.id=" + dr["id"].ToString());
                DictionaryEntry de = new DictionaryEntry(dr["id"].ToString(), dt2.Rows[0]["name"].ToString() + dt2.Rows[0]["sn"] + "的合同期限将于：" + (Convert.ToDateTime(dt2.Rows[0]["end_time"])).ToString("yyy-MM-dd") + "到期");
                listBoxMsg.Items.Add(de);
                DB.exec_NonQuery("update gzf_warning set is_read=1 where id=" + dr["id"].ToString());
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (listBoxMsg.SelectedItems.Count == 0)
            {
                return;
            }
            if (!(listBoxMsg.SelectedItem is DictionaryEntry))
            {
                MessageBox.Show("此行为查询结果，无法删除！");
                return;
            }
            if (MessageBox.Show("是否要删除此房屋？", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (object obj in listBoxMsg.SelectedItems)
                {
                    DictionaryEntry de = (DictionaryEntry)obj;
                    DB.exec_NonQuery("update gzf_warning set is_read=3 where id=" + de.Key);
                }
                warningForm_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument1;
            //DialogResult result = printPreviewDialog1.ShowDialog();
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            try
            {
                Workbooks workbooks = app.Workbooks;
                _Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Sheets sheets = workbook.Worksheets;
                _Worksheet worksheet = (_Worksheet)sheets.get_Item(1);
                int ColumnCount = 20;
                string sLen = "";
                char H = (char)(64 + ColumnCount / 26);
                char L = (char)(64 + ColumnCount % 26);
                sLen = L.ToString();
                string sTmp = sLen + "1";
                Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[ColumnCount];
                //asCaption[0] = "楼号";
                //asCaption[1] = "房号";
                asCaption[0] = "到期提醒";
                ranCaption.Value2 = asCaption;
                object[] obj = new object[ColumnCount];
                for (int i = 0; i < listBoxMsg.Items.Count; i++)
                {
                    obj[0] = "";
                    if (listBoxMsg.Items[i] is DictionaryEntry)
                    {
                        obj[0] = ((DictionaryEntry)listBoxMsg.Items[i]).Value.ToString();
                    }
                    else
                    {
                        obj[0] = listBoxMsg.Items[i].ToString();
                    }
                    string cell1 = sLen + ((int)(i + 2)).ToString();
                    string cell2 = "A" + ((int)(i + 2)).ToString();
                    Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
            }
            finally
            {
                //关闭
                //app.UserControl = false;
                //app.Quit();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //int y = 25;
            //int x = 20;
            //e.Graphics.DrawString("合同到期列表", new Font(new FontFamily("黑体"), 18), System.Drawing.Brushes.Black, 20, y);
            //y += 50;
            //for (int i=0;i<listBoxMsg.Items.Count;i++)
            //{

            //    if (listBoxMsg.Items[i] is DictionaryEntry)
            //    {
            //        e.Graphics.DrawString(((DictionaryEntry)listBoxMsg.Items[i]).Value.ToString(), new Font(new FontFamily("黑体"), 13), System.Drawing.Brushes.Black, x, y);
            //    }
            //    else
            //    {
            //        e.Graphics.DrawString(listBoxMsg.Items[i].ToString(), new Font(new FontFamily("黑体"), 13), System.Drawing.Brushes.Black, x, y);
            //    }
            //    if (x > 300)
            //    {
            //        x = 20;
            //        y += 45;
            //    }
            //    else
            //    {
            //        x += 420;
            //    }
            //}
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            listBoxMsg.Items.Clear();
            System.Data.DataTable dt = DB.select("select house_id,openhouse_id from gzf_payment where openhouse_id in (select id from gzf_openhouse where is_jiezhang=0) AND DateDiff (Day,getdate(),end_time) <= " + (comboBoxDay.SelectedIndex + 1) + " and id in (select max(id) from gzf_payment group by house_id)");
            foreach (DataRow dr in dt.Rows)
            {
                string name = DB.selectScalar("select name from gzf_house,gzf_building where gzf_house.building_id=gzf_building.id and gzf_house.id=" + dr["house_id"]);
                string sn = DB.selectScalar("select sn from gzf_house where id=" + dr["house_id"]);
                string endtime = DB.selectScalar("select top 1 end_time from gzf_payment where openhouse_id=" + dr["openhouse_id"] + " order by end_time desc");
                listBoxMsg.Items.Add(name + sn + "的合同期限将于：" + (Convert.ToDateTime(endtime)).ToString("yyyy-MM-dd") + "到期");
            }
        }
    }
}
