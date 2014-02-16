using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Text.RegularExpressions;

namespace gzf
{
    public partial class jiezhangPrintForm : Form
    {
        int openid;
        bool isCheck;
        string total;
        public jiezhangPrintForm(int openid, bool isCheck, string total)
        {
            InitializeComponent();
            this.openid = openid;
            this.isCheck = isCheck;
            this.total = total;
        }

        private void jiezhangPrintForm_Load(object sender, EventArgs e)
        {
            DataTable dt = DB.select("select gzf_guest.name,sn,deposit,start_time,gzf_building.name as buildingname from gzf_openhouse,gzf_guest,gzf_house,gzf_building where gzf_openhouse.id=" + openid + " and gzf_openhouse.main_guest_id=gzf_guest.id and gzf_openhouse.house_id=gzf_house.id and gzf_building.id=gzf_house.building_id");
            ReportDocument repostDoc = new ReportDocument();
            repostDoc.Load("jiezhang.rpt");
            repostDoc.SetDataSource(dt);
            repostDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            paramField.Name = "isLost";
            ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
            if (isCheck)
            {
                discreteVal.Value = "退房凭证遗失，凭（身份证/护照）领取。";
            }
            else
            {
                discreteVal.Value = "";
            }
            paramField.CurrentValues.Add(discreteVal);
            paramFields.Add(paramField);
            ParameterField paramField2 = new ParameterField();
            paramField2.Name = "upper";
            ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();
            discreteVal2.Value = common.DaXie(total);
            paramField2.CurrentValues.Add(discreteVal2);
            paramFields.Add(paramField2);
            crystalReportViewer1.ParameterFieldInfo = paramFields;
            crystalReportViewer1.ReportSource = repostDoc;
        }
    }
}
