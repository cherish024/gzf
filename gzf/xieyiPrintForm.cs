using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace gzf
{
    public partial class xieyiPrintForm : Form
    {
        string name, start_time, end_time, building, sn, price, yj, add_time, yj_daxie, shiwan,wan,qian,bai,shi,ge,company,buildingsn;
        public xieyiPrintForm(string name,string start_time,string end_time,string building,string sn,string price,string yj,string add_time,string yj_daxie,string shiwan,string wan,string qian,string bai,string shi,string ge, string company, string buildingsn)
        {
            InitializeComponent();
            this.name = name;
            this.start_time = start_time;
            this.end_time = end_time;
            this.building = building;
            this.sn = sn;
            this.price = price;
            this.yj = yj;
            this.add_time = add_time;
            this.yj_daxie = yj_daxie;
            this.shiwan = shiwan;
            this.wan = wan;
            this.qian = qian;
            this.bai = bai;
            this.shi = shi;
            this.ge = ge;
            this.company = company;
            this.buildingsn = buildingsn;
        }

        private void xieyiPrintForm_Load(object sender, EventArgs e)
        {
            ReportDocument repostDoc = new ReportDocument();
            repostDoc.Load("xieyi.rpt");
            repostDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            paramField.Name = "name";
            ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
            discreteVal.Value = name;
            paramField.CurrentValues.Add(discreteVal);

            ParameterField paramField2 = new ParameterField();
            paramField2.Name = "start_time";
            ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();
            discreteVal2.Value = start_time;
            paramField2.CurrentValues.Add(discreteVal2);

            ParameterField paramField3 = new ParameterField();
            paramField3.Name = "end_time";
            ParameterDiscreteValue discreteVal3 = new ParameterDiscreteValue();
            discreteVal3.Value = end_time;
            paramField3.CurrentValues.Add(discreteVal3);

            ParameterField paramField4 = new ParameterField();
            paramField4.Name = "building";
            ParameterDiscreteValue discreteVal4 = new ParameterDiscreteValue();
            discreteVal4.Value = building;
            paramField4.CurrentValues.Add(discreteVal4);

            ParameterField paramField5 = new ParameterField();
            paramField5.Name = "sn";
            ParameterDiscreteValue discreteVal5 = new ParameterDiscreteValue();
            discreteVal5.Value = sn;
            paramField5.CurrentValues.Add(discreteVal5);

            ParameterField paramField6 = new ParameterField();
            paramField6.Name = "price";
            ParameterDiscreteValue discreteVal6 = new ParameterDiscreteValue();
            discreteVal6.Value = price;
            paramField6.CurrentValues.Add(discreteVal6);

            ParameterField paramField7 = new ParameterField();
            paramField7.Name = "yj";
            ParameterDiscreteValue discreteVal7 = new ParameterDiscreteValue();
            discreteVal7.Value = yj;
            paramField7.CurrentValues.Add(discreteVal7);

            ParameterField paramField8 = new ParameterField();
            paramField8.Name = "add_time";
            ParameterDiscreteValue discreteVal8 = new ParameterDiscreteValue();
            discreteVal8.Value = add_time;
            paramField8.CurrentValues.Add(discreteVal8);

            ParameterField paramField9 = new ParameterField();
            paramField9.Name = "yj_daxie";
            ParameterDiscreteValue discreteVal9 = new ParameterDiscreteValue();
            discreteVal9.Value = yj_daxie;
            paramField9.CurrentValues.Add(discreteVal9);

            ParameterField paramField10 = new ParameterField();
            paramField10.Name = "shiwan";
            ParameterDiscreteValue discreteVal10 = new ParameterDiscreteValue();
            discreteVal10.Value = shiwan;
            paramField10.CurrentValues.Add(discreteVal10);

            ParameterField paramField11 = new ParameterField();
            paramField11.Name = "wan";
            ParameterDiscreteValue discreteVal11 = new ParameterDiscreteValue();
            discreteVal11.Value = wan;
            paramField11.CurrentValues.Add(discreteVal11);

            ParameterField paramField12 = new ParameterField();
            paramField12.Name = "qian";
            ParameterDiscreteValue discreteVal12 = new ParameterDiscreteValue();
            discreteVal12.Value = qian;
            paramField12.CurrentValues.Add(discreteVal12);

            ParameterField paramField13 = new ParameterField();
            paramField13.Name = "bai";
            ParameterDiscreteValue discreteVal13 = new ParameterDiscreteValue();
            discreteVal13.Value = bai;
            paramField13.CurrentValues.Add(discreteVal13);

            ParameterField paramField14 = new ParameterField();
            paramField14.Name = "ge";
            ParameterDiscreteValue discreteVal14 = new ParameterDiscreteValue();
            discreteVal14.Value = ge;
            paramField14.CurrentValues.Add(discreteVal14); paramFields.Add(paramField);

            ParameterField paramField15 = new ParameterField();
            paramField15.Name = "shi";
            ParameterDiscreteValue discreteVal15 = new ParameterDiscreteValue();
            discreteVal15.Value = shi;
            paramField15.CurrentValues.Add(discreteVal15); paramFields.Add(paramField);

            ParameterField paramField16 = new ParameterField();
            paramField16.Name = "company";
            ParameterDiscreteValue discreteVal16 = new ParameterDiscreteValue();
            discreteVal16.Value = company;
            paramField16.CurrentValues.Add(discreteVal16);

            ParameterField paramField17 = new ParameterField();
            paramField17.Name = "buildingsn";
            ParameterDiscreteValue discreteVal17 = new ParameterDiscreteValue();
            discreteVal17.Value = buildingsn;
            paramField17.CurrentValues.Add(discreteVal17);

            paramFields.Add(paramField2);
            paramFields.Add(paramField3);
            paramFields.Add(paramField4);
            paramFields.Add(paramField5);
            paramFields.Add(paramField6);
            paramFields.Add(paramField7);
            paramFields.Add(paramField8);
            paramFields.Add(paramField9);
            paramFields.Add(paramField10);
            paramFields.Add(paramField11);
            paramFields.Add(paramField12);
            paramFields.Add(paramField13);
            paramFields.Add(paramField14);
            paramFields.Add(paramField15);
            paramFields.Add(paramField16);
            paramFields.Add(paramField17);
            crystalReportViewer1.ParameterFieldInfo = paramFields;
            crystalReportViewer1.ReportSource = repostDoc;
        }
    }
}
