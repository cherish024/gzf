using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections;
using System.Xml;

namespace gzf
{
    public class common
    {
        public static model.User User = new gzf.model.User();
        public static model.House houseSelect = new gzf.model.House();
        public static bool teamSelect = false;
        public static string MD5Encrypt(string strText)
        {
            string cl = strText;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 

                pwd = pwd + s[i].ToString("X");

            }
            return pwd;

        }

        public static string GetOpenhouse_id(int house_id)
        {
            string openhouse_id = DB.selectScalar("select top 1 id from gzf_openhouse where house_id=" + house_id + " and is_jiezhang=0 order by id desc");
            if (openhouse_id != "")
            {
                return openhouse_id;
            }
            else
            {
                return DB.selectScalar("select top 1 openhouse_id from gzf_teamopenhouse where house_id=" + house_id + " order by id desc");
            }
        }

        public static string GetMain_Guest_Id(int house_id)
        {
            string openhouse_id = DB.selectScalar("select top 1 main_guest_id from gzf_openhouse where house_id=" + house_id + " and is_jiezhang=0 order by id desc");
            return openhouse_id;
        }


        public static string ConvertDate(string str)
        {
            string year;
            string month;
            string day;
            if (str.Length >= 8)
            {
                year = str.Substring(0, 4);
                month = str.Substring(4, 2);
                day = str.Substring(6, 2);
                return string.Format("{0}/{1}/{2}", year, month, day);
            }

            return "";
        }

        public static System.Data.DataTable getCompany()
        {
            //XmlDocument configXml = new XmlDocument();
            //configXml.Load("config.xml");
            //char[] chars = new char[1];
            //chars[0] = ',';
            //string[] a = configXml["config"]["Company"].InnerText.Split(chars);
            //return a;
            System.Data.DataTable dt = DB.select("select name from gzf_company");
            return dt;
        }

        public static bool ExportForDataGridview(DataGridView gridView, string fileName, bool isShowExcle)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (app == null)
                {
                    return false;
                }
                app.Visible = isShowExcle;
                Workbooks workbooks = app.Workbooks;
                _Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Sheets sheets = workbook.Worksheets;
                _Worksheet worksheet = (_Worksheet)sheets.get_Item(1);
                if (worksheet == null)
                {
                    return false;
                }
                string sLen = "";
                //取得最后一列列名
                char H = (char)(64 + gridView.ColumnCount / 26);
                char L = (char)(64 + gridView.ColumnCount % 26);
                if (gridView.ColumnCount < 26)
                {
                    sLen = L.ToString();
                }
                else
                {
                    sLen = H.ToString() + L.ToString();
                }
                //标题
                string sTmp = sLen + "1";
                Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[gridView.ColumnCount];
                for (int i = 0; i < gridView.ColumnCount; i++)
                {
                    asCaption[i] = gridView.Columns[i].HeaderText;
                }
                ranCaption.Value2 = asCaption;

                //数据
                string[] obj = new string[gridView.Columns.Count];
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        if (gridView[l, r].ValueType == typeof(DateTime))
                        {
                            obj[l] = (Convert.ToDateTime(gridView[l, r].FormattedValue)).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            obj[l] = gridView[l, r].FormattedValue.ToString();
                        }
                    }
                    string cell1 = sLen + ((int)(r + 2)).ToString();
                    string cell2 = "A" + ((int)(r + 2)).ToString();
                    Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
                //保存
                //workbook.SaveCopyAs(fileName);
                //workbook.Saved = true;
            }
            finally
            {
                //关闭
                //app.UserControl = false;
                //app.Quit();
            }
            return true;

        }


        public static bool ExportForDataGridviewTongji(DataGridView gridView, string fileName, bool isShowExcle, string tongji, string tongjiName, int chaju, bool showCash)
        {
            int total = 0, cash = 0, crides = 0, other = 0;
            for (int r = 0; r < gridView.RowCount; r++)
            {
                for (int l = 0; l < gridView.Columns.Count; l++)
                {
                    if (gridView.Columns[l].HeaderText == tongjiName)
                    {
                        if (gridView[l, r].FormattedValue.ToString() != "")
                        {
                            total += Convert.ToInt32(gridView[l, r].FormattedValue);
                        }
                        //switch (gridView[l+chaju, r].FormattedValue.ToString())
                        //{
                        //    case "现金": cash += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                        //    case "信用卡": crides += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                        //    case "其他方式": other += Convert.ToInt32(gridView[l, r].FormattedValue); break; 
                        //}
                            
                    }
                    
                }
            }
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (app == null)
                {
                    return false;
                }
                app.Visible = isShowExcle;
                Workbooks workbooks = app.Workbooks;
                _Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Sheets sheets = workbook.Worksheets;
                _Worksheet worksheet = (_Worksheet)sheets.get_Item(1);
                if (worksheet == null)
                {
                    return false;
                }
                string sLen = "";
                //取得最后一列列名
                char H = (char)(64 + gridView.ColumnCount / 26);
                char L = (char)(64 + gridView.ColumnCount % 26);
                if (gridView.ColumnCount < 26)
                {
                    sLen = L.ToString();
                }
                else
                {
                    sLen = H.ToString() + L.ToString();
                }
                //标题
                string sTmp = sLen + "1";
                Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[gridView.ColumnCount];
                for (int i = 0; i < gridView.ColumnCount; i++)
                {
                    asCaption[i] = gridView.Columns[i].HeaderText;
                }
                ranCaption.Value2 = asCaption;

                //数据
                string[] obj = new string[gridView.Columns.Count];
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        if (gridView[l, r].ValueType == typeof(DateTime))
                        {
                            obj[l] = (Convert.ToDateTime(gridView[l, r].FormattedValue)).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            obj[l] = gridView[l, r].FormattedValue.ToString();
                        }
                    }
                    string cell1 = sLen + ((int)(r + 2)).ToString();
                    string cell2 = "A" + ((int)(r + 2)).ToString();
                    Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
                int r1 = gridView.RowCount + 1;
                Range ran1 = worksheet.get_Range("A" + (r1 + 2).ToString(), "A" + (r1 + 2).ToString());
                ran1.Value2 = "合计";

                ran1 = worksheet.get_Range(tongji + (r1 + 2).ToString(), tongji + (r1 + 2).ToString());
                ran1.Value2 = total.ToString();

                if (showCash)
                {
                    ran1 = worksheet.get_Range("A" + (r1 + 3).ToString(), "A" + (r1 + 3).ToString());
                    ran1.Value2 = "现金";

                    ran1 = worksheet.get_Range(tongji + (r1 + 3).ToString(), tongji + (r1 + 3).ToString());
                    ran1.Value2 = cash.ToString();

                    ran1 = worksheet.get_Range("A" + (r1 + 4).ToString(), "A" + (r1 + 4).ToString());
                    ran1.Value2 = "信用卡";

                    ran1 = worksheet.get_Range(tongji + (r1 + 4).ToString(), tongji + (r1 + 4).ToString());
                    ran1.Value2 = crides.ToString();

                    ran1 = worksheet.get_Range("A" + (r1 + 5).ToString(), "A" + (r1 + 5).ToString());
                    ran1.Value2 = "其他方式";

                    ran1 = worksheet.get_Range(tongji + (r1 + 5).ToString(), tongji + (r1 + 5).ToString());
                    ran1.Value2 = other.ToString();
                }
            }
            catch { }
            return true;

        }

        public static bool ExportForDataGridviewTongji2(DataGridView gridView, string fileName, bool isShowExcle, string position,string tongji, string tongji1, string tongji2, string tongji3)
        {
            int total = 0, cash = 0, crides = 0, other = 0;
            try
            {
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        string num = gridView[l, r].FormattedValue.ToString();
                        if (num.Trim() == "")
                        {
                            num = "0";
                        }
                        if (gridView.Columns[l].HeaderText == tongji)
                        {
                            total += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongji1)
                        {
                            cash += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongji2)
                        {
                            crides += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongji3)
                        {
                            other += Convert.ToInt32(num);
                        }
                    }
                }
            }
            catch { }
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (app == null)
                {
                    return false;
                }
                app.Visible = isShowExcle;
                Workbooks workbooks = app.Workbooks;
                _Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Sheets sheets = workbook.Worksheets;
                _Worksheet worksheet = (_Worksheet)sheets.get_Item(1);
                if (worksheet == null)
                {
                    return false;
                }
                string sLen = "";
                //取得最后一列列名
                char H = (char)(64 + gridView.ColumnCount / 26);
                char L = (char)(64 + gridView.ColumnCount % 26);
                if (gridView.ColumnCount < 26)
                {
                    sLen = L.ToString();
                }
                else
                {
                    sLen = H.ToString() + L.ToString();
                }
                //标题
                string sTmp = sLen + "1";
                Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[gridView.ColumnCount];
                for (int i = 0; i < gridView.ColumnCount; i++)
                {
                    asCaption[i] = gridView.Columns[i].HeaderText;
                }
                ranCaption.Value2 = asCaption;

                //数据
                string[] obj = new string[gridView.Columns.Count];
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        if (gridView[l, r].ValueType == typeof(DateTime))
                        {
                            obj[l] = (Convert.ToDateTime(gridView[l, r].FormattedValue)).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            obj[l] = gridView[l, r].FormattedValue.ToString();
                        }
                    }
                    string cell1 = sLen + ((int)(r + 2)).ToString();
                    string cell2 = "A" + ((int)(r + 2)).ToString();
                    Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
                int r1 = gridView.RowCount + 1;
                Range ran1 = worksheet.get_Range("A" + (r1 + 2).ToString(), "A" + (r1 + 2).ToString());
                ran1.Value2 = "合计";

                ran1 = worksheet.get_Range(position + (r1 + 2).ToString(), position + (r1 + 2).ToString());
                ran1.Value2 = total.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 3).ToString(), "A" + (r1 + 3).ToString());
                ran1.Value2 = "现金";

                ran1 = worksheet.get_Range(position + (r1 + 3).ToString(), position + (r1 + 3).ToString());
                ran1.Value2 = cash.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 4).ToString(), "A" + (r1 + 4).ToString());
                ran1.Value2 = "信用卡";

                ran1 = worksheet.get_Range(position + (r1 + 4).ToString(), position + (r1 + 4).ToString());
                ran1.Value2 = crides.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 5).ToString(), "A" + (r1 + 5).ToString());
                ran1.Value2 = "其他方式";

                ran1 = worksheet.get_Range(position + (r1 + 5).ToString(), position + (r1 + 5).ToString());
                ran1.Value2 = other.ToString();
                //保存
                //workbook.SaveCopyAs(fileName);
                //workbook.Saved = true;
            }
            finally
            {
                //关闭
                //app.UserControl = false;
                //app.Quit();
            }
            return true;

        }

        public static bool ExportForDataGridviewTongji3(DataGridView gridView, string fileName, bool isShowExcle, string tongji, string tongjiName, int chaju)
        {
            model.powerType powertype = new gzf.model.powerType(0);
            int total = 0, cash = 0, crides = 0, other = 0;
            int[] totals = new int[20];
            int[] cashs = new int[20];
            int[] cridess = new int[20];
            int[] others = new int[20];
            for (int r = 0; r < gridView.RowCount; r++)
            {
                for (int l = 0; l < gridView.Columns.Count; l++)
                {
                    if (gridView.Columns[l].HeaderText == tongjiName)
                    {
                        if (gridView[l, r].FormattedValue.ToString() != "")
                        {
                            total += Convert.ToInt32(gridView[l, r].FormattedValue);
                        }
                        switch (gridView[l + chaju, r].FormattedValue.ToString())
                        {
                            case "现金": cash += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                            case "信用卡": crides += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                            case "其他方式": other += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                        }
                        int x = 0;
                        foreach (DictionaryEntry de in powertype.statusTable)
                        {
                            if (gridView[0, r].FormattedValue.ToString() == de.Value.ToString())
                            {
                                totals[x] += Convert.ToInt32(gridView[l, r].FormattedValue);
                                switch (gridView[l + chaju, r].FormattedValue.ToString())
                                {
                                    case "现金": cashs[x] += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                                    case "信用卡": cridess[x] += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                                    case "其他方式": others[x] += Convert.ToInt32(gridView[l, r].FormattedValue); break;
                                }
                            }

                            x+=1;
                        }
                    }

                }
            }
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (app == null)
                {
                    return false;
                }
                app.Visible = isShowExcle;
                Workbooks workbooks = app.Workbooks;
                _Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Sheets sheets = workbook.Worksheets;
                _Worksheet worksheet = (_Worksheet)sheets.get_Item(1);
                if (worksheet == null)
                {
                    return false;
                }
                string sLen = "";
                //取得最后一列列名
                char H = (char)(64 + gridView.ColumnCount / 26);
                char L = (char)(64 + gridView.ColumnCount % 26);
                if (gridView.ColumnCount < 26)
                {
                    sLen = L.ToString();
                }
                else
                {
                    sLen = H.ToString() + L.ToString();
                }
                //标题
                string sTmp = sLen + "1";
                Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[gridView.ColumnCount];
                for (int i = 0; i < gridView.ColumnCount; i++)
                {
                    asCaption[i] = gridView.Columns[i].HeaderText;
                }
                ranCaption.Value2 = asCaption;

                //数据
                string[] obj = new string[gridView.Columns.Count];
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        if (gridView[l, r].ValueType == typeof(DateTime))
                        {
                            obj[l] = (Convert.ToDateTime(gridView[l, r].FormattedValue)).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            obj[l] = gridView[l, r].FormattedValue.ToString();
                        }
                    }
                    string cell1 = sLen + ((int)(r + 2)).ToString();
                    string cell2 = "A" + ((int)(r + 2)).ToString();
                    Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
                int r1 = gridView.RowCount + 1;
                Range ran1 = worksheet.get_Range("A" + (r1 + 2).ToString(), "A" + (r1 + 2).ToString());
                ran1.Value2 = "全部合计";

                ran1 = worksheet.get_Range(tongji + (r1 + 2).ToString(), tongji + (r1 + 2).ToString());
                ran1.Value2 = total.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 3).ToString(), "A" + (r1 + 3).ToString());
                ran1.Value2 = "现金";

                ran1 = worksheet.get_Range(tongji + (r1 + 3).ToString(), tongji + (r1 + 3).ToString());
                ran1.Value2 = cash.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 4).ToString(), "A" + (r1 + 4).ToString());
                ran1.Value2 = "信用卡";

                ran1 = worksheet.get_Range(tongji + (r1 + 4).ToString(), tongji + (r1 + 4).ToString());
                ran1.Value2 = crides.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 5).ToString(), "A" + (r1 + 5).ToString());
                ran1.Value2 = "其他方式";

                ran1 = worksheet.get_Range(tongji + (r1 + 5).ToString(), tongji + (r1 + 5).ToString());
                ran1.Value2 = other.ToString();

                
                int x = 2;
                int y = 0;
                foreach (DictionaryEntry de in powertype.statusTable)
                {
                    ran1 = worksheet.get_Range("A" + (r1 + 5 + x).ToString(), "A" + (r1 + 5 + x).ToString());
                    ran1.Value2 = de.Value + "合计";
                    ran1 = worksheet.get_Range(tongji + (r1 + 5 + x).ToString(), tongji + (r1 + 5 + x).ToString());
                    ran1.Value2 = totals[y];
                    x += 1;
                    ran1 = worksheet.get_Range("A" + (r1 + 5 + x).ToString(), "A" + (r1 + 5 + x).ToString());
                    ran1.Value2 = de.Value + "现金";
                    ran1 = worksheet.get_Range(tongji + (r1 + 5 + x).ToString(), tongji + (r1 + 5 + x).ToString());
                    ran1.Value2 = cashs[y];
                    x += 1;
                    ran1 = worksheet.get_Range("A" + (r1 + 5 + x).ToString(), "A" + (r1 + 5 + x).ToString());
                    ran1.Value2 = de.Value + "信用卡";
                    ran1 = worksheet.get_Range(tongji + (r1 + 5 + x).ToString(), tongji + (r1 + 5 + x).ToString());
                    ran1.Value2 = cridess[y];
                    x += 1;
                    ran1 = worksheet.get_Range("A" + (r1 + 5 + x).ToString(), "A" + (r1 + 5 + x).ToString());
                    ran1.Value2 = de.Value + "其他方式";
                    ran1 = worksheet.get_Range(tongji + (r1 + 5 + x).ToString(), tongji + (r1 + 5 + x).ToString());
                    ran1.Value2 = others[y];
                    x += 2;
                    y += 1;
                }
            }
            catch { }
            return true;

        }


        public static bool ExportForDataGridviewTongji4(DataGridView gridView, string fileName, bool isShowExcle, string position,string position2, string tongji,string tongjitwo, string tongji1, string tongji2, string tongji3)
        {
            int total = 0, cash = 0, crides = 0, other = 0, yj = 0;
            try
            {
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        string num = gridView[l, r].FormattedValue.ToString();
                        if (num.Trim() == "")
                        {
                            num = "0";
                        }
                        if (gridView.Columns[l].HeaderText == tongji)
                        {
                            total += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongjitwo)
                        {
                            yj += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongji1)
                        {
                            cash += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongji2)
                        {
                            crides += Convert.ToInt32(num);
                        }
                        if (gridView.Columns[l].HeaderText == tongji3)
                        {
                            other += Convert.ToInt32(num);
                        }
                    }
                }
            }
            catch { }
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (app == null)
                {
                    return false;
                }
                app.Visible = isShowExcle;
                Workbooks workbooks = app.Workbooks;
                _Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Sheets sheets = workbook.Worksheets;
                _Worksheet worksheet = (_Worksheet)sheets.get_Item(1);
                if (worksheet == null)
                {
                    return false;
                }
                string sLen = "";
                //取得最后一列列名
                char H = (char)(64 + gridView.ColumnCount / 26);
                char L = (char)(64 + gridView.ColumnCount % 26);
                if (gridView.ColumnCount < 26)
                {
                    sLen = L.ToString();
                }
                else
                {
                    sLen = H.ToString() + L.ToString();
                }
                //标题
                string sTmp = sLen + "1";
                Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[gridView.ColumnCount];
                for (int i = 0; i < gridView.ColumnCount; i++)
                {
                    asCaption[i] = gridView.Columns[i].HeaderText;
                }
                ranCaption.Value2 = asCaption;

                //数据
                string[] obj = new string[gridView.Columns.Count];
                for (int r = 0; r < gridView.RowCount; r++)
                {
                    for (int l = 0; l < gridView.Columns.Count; l++)
                    {
                        if (gridView[l, r].ValueType == typeof(DateTime))
                        {
                            obj[l] = (Convert.ToDateTime(gridView[l, r].FormattedValue)).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            obj[l] = gridView[l, r].FormattedValue.ToString();
                        }
                    }
                    string cell1 = sLen + ((int)(r + 2)).ToString();
                    string cell2 = "A" + ((int)(r + 2)).ToString();
                    Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
                int r1 = gridView.RowCount + 1;
                Range ran1 = worksheet.get_Range("A" + (r1 + 2).ToString(), "A" + (r1 + 2).ToString());
                ran1.Value2 = "合计";

                ran1 = worksheet.get_Range(position + (r1 + 2).ToString(), position + (r1 + 2).ToString());
                ran1.Value2 = total.ToString();

                ran1 = worksheet.get_Range(position2 + (r1 + 2).ToString(), position2 + (r1 + 2).ToString());
                ran1.Value2 = yj.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 3).ToString(), "A" + (r1 + 3).ToString());
                ran1.Value2 = "现金";

                ran1 = worksheet.get_Range(position + (r1 + 3).ToString(), position + (r1 + 3).ToString());
                ran1.Value2 = cash.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 4).ToString(), "A" + (r1 + 4).ToString());
                ran1.Value2 = "信用卡";

                ran1 = worksheet.get_Range(position + (r1 + 4).ToString(), position + (r1 + 4).ToString());
                ran1.Value2 = crides.ToString();

                ran1 = worksheet.get_Range("A" + (r1 + 5).ToString(), "A" + (r1 + 5).ToString());
                ran1.Value2 = "其他方式";

                ran1 = worksheet.get_Range(position + (r1 + 5).ToString(), position + (r1 + 5).ToString());
                ran1.Value2 = other.ToString();
                //保存
                //workbook.SaveCopyAs(fileName);
                //workbook.Saved = true;
            }
            finally
            {
                //关闭
                //app.UserControl = false;
                //app.Quit();
            }
            return true;

        }

        public static Bitmap getClipBordImage()
        {
            IDataObject iData = Clipboard.GetDataObject();
            // 将数据与指定的格式进行匹配，返回bool
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                // GetData检索数据并指定一个格式
                return (Bitmap)iData.GetData(DataFormats.Bitmap);
            }
            return new Bitmap(1, 1);
        }

        public static string DaXie(string money)
        {
            string s = double.Parse(money).ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            string d = Regex.Replace(s, @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            return Regex.Replace(d, ".", delegate(Match m) { return "负圆空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万億兆京垓秭穰"[m.Value[0] - '-'].ToString(); });
        }

        public static string getPaymethod(string paymethod)
        {
            if (paymethod == "1")
            {
                return "现金";
            }
            else if (paymethod == "2")
            {
                return "信用卡";
            }
            else if (paymethod == "3")
            {
                return "其他方式";
            }
            else
            {
                return " ";
            }
        }

    }
}
