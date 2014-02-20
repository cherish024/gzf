using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace gzf
{
    public partial class jiezhangtuikuanForm : Form
    {
        model.OpenHouse openhouse;
        string shui;
        string dian;
        string houseTotal;
        string total;
        string powerTotal;
        string tv;
        model.House house;
        private string zdsn = "ZD" + DateTime.Now.ToString("yyyyMMddhhmmss");
        public jiezhangtuikuanForm(model.OpenHouse openhouse, string shui, string dian, string houseTotal, string total, model.House house)
        {
            InitializeComponent();
            this.openhouse = openhouse;
            this.shui = shui;
            this.dian = dian;
            this.houseTotal = houseTotal;
            this.total = total;
            this.house = house;
        }

        private void jiezhangtuikuanForm_Load(object sender, EventArgs e)
        {
            string cool = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + "and type=0");
            string dian = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=1");
            tv = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=2");
            string gas = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=3");
            string hot = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id + " and type=4");
            powerTotal = DB.selectScalar("select sum(price) from gzf_power where openhouse_id=" + openhouse.Id);
            if (cool == "") { cool = "0"; }
            if (dian == "") { dian = "0"; }
            if (tv == "") { tv = "0"; }
            if (gas == "") { gas = "0"; }
            if (hot == "") { hot = "0"; }
            if (powerTotal == "") { powerTotal = "0"; }
            lbl_yj.Text = openhouse.Deposit.ToString();
            lblShui.Text = cool;
            lblDian.Text = dian;
            lblTv.Text = tv;
            lblGas.Text = gas;
            lblHot.Text = hot;
            lblTotal.Text = (openhouse.Deposit + numericUpDown1.Value - Convert.ToInt32(powerTotal)).ToString();
        }

        private void btn_jz_Click(object sender, EventArgs e)
        {
            DB.exec_NonQuery("update gzf_openhouse set is_jiezhang=1 where id=" + openhouse.Id);
            if (openhouse.Is_team == 1)
            {
                DB.exec_NonQuery("update gzf_house set status=2 where id=" + house.id);
            }
            else
            {
                DB.exec_NonQuery("update gzf_house set status=2 where id=" + openhouse.House_id);
            }
            
            if (openhouse.Is_team > 0)
            {
                DataTable dt = DB.select("select house_id from gzf_openhouse where is_team=" + openhouse.Id + "and is_jiezhang=0 and id!=" + openhouse.Id);
                foreach (DataRow dr in dt.Rows)
                {
                    DB.exec_NonQuery("update gzf_house set status=2 where id=" + dr["house_id"]);
                }
            }
            DB.exec_NonQuery("insert into gzf_zd (sn,openhouse_id,guest_id,shui_price,dian_price,house_price,is_team,total_price,user_id,refund) values ('" + zdsn + "'," + openhouse.Id + "," + openhouse.Main_guest_id + "," + shui + "," + dian + "," + houseTotal + "," + openhouse.Is_team + "," + total + "," + common.User.id + "," + lblTotal.Text + ")");
            jiezhangForm jz = (jiezhangForm)this.Owner;
            jz.Isjiezhang = 1;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (openhouse.Deposit + numericUpDown1.Value - Convert.ToInt32(powerTotal) + Convert.ToInt32(tv)).ToString();
        }


        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.ApplicationClass app = new Microsoft.Office.Interop.Word.ApplicationClass();
            app.Visible = true;
            Microsoft.Office.Interop.Word.Document doc = null;
            object missing = System.Reflection.Missing.Value;
            object FileNames = System.Windows.Forms.Application.StartupPath + "\\tuifangsmall_templete.doc";
            //object xieyiFileName = System.Windows.Forms.Application.StartupPath + "\\tuikuan.doc";
            object readOnly = true;
            object isVisible = true;
            object isOpen = true;
            object index = 0;
            try
            {
                doc = app.Documents.Open(ref FileNames, ref missing, ref readOnly,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref isVisible, ref isOpen,
                ref missing, ref missing, ref missing);
                object replaceAll = WdReplace.wdReplaceAll;
                app.Selection.Find.Text = "{time}";
                app.Selection.Find.Replacement.Text = DateTime.Now.ToString("yyyy-MM-dd");
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{name}";
                app.Selection.Find.Replacement.Text = DB.selectScalar("select name from gzf_guest where id=" + openhouse.Main_guest_id);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{sn}";
                app.Selection.Find.Replacement.Text = DB.selectScalar("select name from gzf_building where id=" + openhouse.Building_id) + DB.selectScalar("select sn from gzf_house where id=" + openhouse.House_id);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{fapiao}";
                app.Selection.Find.Replacement.Text = DB.selectScalar("select fapiao from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime desc");
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{price}";
                app.Selection.Find.Replacement.Text = lblTotal.Text;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{daxie}";
                //app.Selection.Find.Replacement.Text = common.DaXie(lblTotal.Text);
                app.Selection.Find.Replacement.Text = common.DaXie(numericUpDown1.Text);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{xiaoxie}";
                //app.Selection.Find.Replacement.Text = lblTotal.Text;
                app.Selection.Find.Replacement.Text = numericUpDown1.Text;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{month}";
                DateTime endtime = Convert.ToDateTime(DB.selectScalar("select end_time from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime desc"));
                DateTime starttime = Convert.ToDateTime(DB.selectScalar("select start_time from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime asc"));
                app.Selection.Find.Replacement.Text = (endtime - starttime).Days.ToString() + "天";

                //-- 退押金单start --
                app.Selection.Find.Text = "{ydyajin}";
                app.Selection.Find.Replacement.Text = common.DaXie(lbl_yj.Text);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{yyajin}";
                app.Selection.Find.Replacement.Text = lbl_yj.Text;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{ystart}";
                app.Selection.Find.Replacement.Text = starttime.ToShortDateString();
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{yend}";
                app.Selection.Find.Replacement.Text = DateTime.Now.ToShortDateString();
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                string shuoming = "";
                if (chkPrint.Checked)
                {
                    shuoming = "退房凭证遗失，凭（身份证/护照）领取。";
                }
                app.Selection.Find.Text = "{shuoming}";
                app.Selection.Find.Replacement.Text = shuoming;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                //-- 退押金单END --

                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            }
            catch { }
            //jiezhangPrintForm print = new jiezhangPrintForm(openhouse.Id, chkPrint.Checked, lbl_yj.Text);
            //print.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.ApplicationClass app = new Microsoft.Office.Interop.Word.ApplicationClass();
            app.Visible = true;
            Microsoft.Office.Interop.Word.Document doc = null;
            object missing = System.Reflection.Missing.Value;
            object FileName = System.Windows.Forms.Application.StartupPath + "\\tuikuan_templete.doc";
            //object xieyiFileName = System.Windows.Forms.Application.StartupPath + "\\tuikuan.doc";
            object readOnly = true;
            object isVisible = true;
            object isOpen = true;
            object index = 0;
            try
            {
                doc = app.Documents.Open(ref FileName, ref missing, ref readOnly,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref isVisible, ref isOpen,
                ref missing, ref missing, ref missing);
                object replaceAll = WdReplace.wdReplaceAll;
                app.Selection.Find.Text = "{time}";
                app.Selection.Find.Replacement.Text = DateTime.Now.ToString("yyyy-MM-dd");
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{name}";
                app.Selection.Find.Replacement.Text = DB.selectScalar("select name from gzf_guest where id=" + openhouse.Main_guest_id);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{sn}";
                app.Selection.Find.Replacement.Text = DB.selectScalar("select name from gzf_building where id=" + openhouse.Building_id) + DB.selectScalar("select sn from gzf_house where id=" + openhouse.House_id);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{fapiao}";
                app.Selection.Find.Replacement.Text = DB.selectScalar("select fapiao from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime desc");
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{price}";
                app.Selection.Find.Replacement.Text = lblTotal.Text;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{daxie}";
                //app.Selection.Find.Replacement.Text = common.DaXie(lblTotal.Text);
                app.Selection.Find.Replacement.Text = common.DaXie(numericUpDown1.Text);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{xiaoxie}";
                //app.Selection.Find.Replacement.Text = lblTotal.Text;
                app.Selection.Find.Replacement.Text = numericUpDown1.Text;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{month}";
                DateTime endtime = Convert.ToDateTime(DB.selectScalar("select end_time from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime desc"));
                DateTime starttime = Convert.ToDateTime(DB.selectScalar("select start_time from gzf_payment where openhouse_id=" + openhouse.Id + " order by addtime desc"));
                app.Selection.Find.Replacement.Text = (endtime - starttime).Days.ToString() + "天";

                //-- 退押金单start --
                app.Selection.Find.Text = "{ydyajin}";
                app.Selection.Find.Replacement.Text = common.DaXie(lbl_yj.Text);
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{yyajin}";
                app.Selection.Find.Replacement.Text = lbl_yj.Text;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{ystart}";
                app.Selection.Find.Replacement.Text = starttime.ToShortDateString();
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                app.Selection.Find.Text = "{yend}";
                app.Selection.Find.Replacement.Text = DateTime.Now.ToShortDateString();
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                string shuoming = "";
                if (chkPrint.Checked)
                {
                    shuoming = "退房凭证遗失，凭（身份证/护照）领取。";
                }
                app.Selection.Find.Text = "{shuoming}";
                app.Selection.Find.Replacement.Text = shuoming;
                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);


                //-- 退押金单END --

                app.Selection.Find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            }
            catch { }
        }


    }
}
