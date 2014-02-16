using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace gzf
{
    public partial class openInfoForm : Form
    {
        int openid;
        DataTable dt = new DataTable();
        public openInfoForm(int openhouseID)
        {
            InitializeComponent();
            openid = openhouseID;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cmd = "update gzf_openhouse set start_time='" + dateTimePicker1.Value + "', end_time='" + dateTimePicker2.Value + "', deposit=" + spinEditDeposit.Value + ", deposit_sn='" + txtDipositSN.Text + "', fapiao='" + txtFapiao.Text + "', price=" + spinEditMoney.Value + ", kind=" + ((DictionaryEntry)comboBoxKind.SelectedItem).Key + ", remark='" + txtRemark.Text + "' where id=" + openid;
            int count = DB.exec_NonQuery(cmd);
            DataTable dt = DB.select("select top 1 price,is_team,kind from gzf_openhouse where id=" + openid + " order by id desc");
            if (openid.ToString() == dt.Rows[0]["is_team"].ToString())
            {
                DataTable teamhouse = DB.select("select house_id,id from gzf_openhouse where is_team=" + dt.Rows[0]["is_team"].ToString() + " and is_jiezhang=0");
                foreach (DataRow dr in teamhouse.Rows)
                {
                    string c = "update gzf_openhouse set kind=" + ((DictionaryEntry)comboBoxKind.SelectedItem).Key + " where id=" + dr["id"].ToString();
                    DB.exec_NonQuery(c);
                }
            }
            
            if (count > 0)
            {
                MessageBox.Show("保存成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败！");
            }

        }

        private void openInfoForm_Load(object sender, EventArgs e)
        {
            dt = DB.select("select * from gzf_openhouse,gzf_house,gzf_building where gzf_openhouse.house_id=gzf_house.id and gzf_house.building_id=gzf_building.id and gzf_openhouse.id=" + openid);
            lblSn.Text = dt.Rows[0]["sn"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["start_time"]);
            dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            spinEditDeposit.Value = Convert.ToInt32(dt.Rows[0]["deposit"]);
            txtDipositSN.Text = dt.Rows[0]["deposit_sn"].ToString();
            spinEditMoney.Value = Convert.ToInt32(dt.Rows[0]["price"]);
            lblBuilding.Text = dt.Rows[0]["name"].ToString();
            txtRemark.Text = dt.Rows[0]["remark"].ToString();
            txtFapiao.Text = dt.Rows[0]["fapiao"].ToString();
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(0);
            foreach (DictionaryEntry de in kind.statusTable)
            {
                comboBoxKind.Items.Add(de);
            }
            comboBoxKind.ValueMember = "Key";
            comboBoxKind.DisplayMember = "Value";
            DictionaryEntry de2 = new DictionaryEntry(Convert.ToInt32(dt.Rows[0]["kind"]), new gzf.model.OpenHouseKind(Convert.ToInt32(dt.Rows[0]["kind"])).Statustxt);
            comboBoxKind.SelectedItem = de2;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            crystalReportViewer1_Click(sender, e);
            crystalReportViewer1.PrintReport();
        }

        private bool clearZero(int bit)
        {
            int desposit = Convert.ToInt32(spinEditDeposit.Value);
            if (bit > desposit)
            {
                return false;
            }
            return true;
        }

        private void crystalReportViewer1_Click(object sender, EventArgs e)
        {
            ReportDocument repostDoc = new ReportDocument();
            repostDoc.Load("xieyi.rpt");
            repostDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            ParameterFields paramFields = new ParameterFields();

            //加载打印
            try
            {
                int desposit = Convert.ToInt32(spinEditDeposit.Value);
                string name = " ";
                DataTable dt = DB.select("select name,company from gzf_guest where openhouse_id=" + openid);
                if (dt.Rows.Count == 1)
                {
                    name = dt.Rows[0]["name"].ToString();
                }
                else
                {
                    name = dt.Rows[0]["name"] + "、" + dt.Rows[1]["name"];
                }
                ParameterField paramField = new ParameterField();
                paramField.Name = "name";
                ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
                discreteVal.Value = name;
                paramField.CurrentValues.Add(discreteVal);

                ParameterField paramField2 = new ParameterField();
                paramField2.Name = "start_time";
                ParameterDiscreteValue discreteVal2 = new ParameterDiscreteValue();
                discreteVal2.Value = dateTimePicker1.Value.ToString("yyyy   MM   dd");
                paramField2.CurrentValues.Add(discreteVal2);

                ParameterField paramField3 = new ParameterField();
                paramField3.Name = "end_time";
                ParameterDiscreteValue discreteVal3 = new ParameterDiscreteValue();
                discreteVal3.Value = dateTimePicker2.Value.ToString("yyyy   MM   dd");
                paramField3.CurrentValues.Add(discreteVal3);

                ParameterField paramField4 = new ParameterField();
                paramField4.Name = "building";
                ParameterDiscreteValue discreteVal4 = new ParameterDiscreteValue();
                discreteVal4.Value = lblBuilding.Text.Replace("号楼", "");
                paramField4.CurrentValues.Add(discreteVal4);

                ParameterField paramField5 = new ParameterField();
                paramField5.Name = "sn";
                ParameterDiscreteValue discreteVal5 = new ParameterDiscreteValue();
                discreteVal5.Value = lblSn.Text;
                paramField5.CurrentValues.Add(discreteVal5);

                ParameterField paramField6 = new ParameterField();
                paramField6.Name = "price";
                ParameterDiscreteValue discreteVal6 = new ParameterDiscreteValue();
                discreteVal6.Value = spinEditMoney.Value.ToString();
                paramField6.CurrentValues.Add(discreteVal6);

                ParameterField paramField7 = new ParameterField();
                paramField7.Name = "yj";
                ParameterDiscreteValue discreteVal7 = new ParameterDiscreteValue();
                discreteVal7.Value = spinEditDeposit.Value.ToString();
                paramField7.CurrentValues.Add(discreteVal7);

                ParameterField paramField8 = new ParameterField();
                paramField8.Name = "add_time";
                ParameterDiscreteValue discreteVal8 = new ParameterDiscreteValue();
                discreteVal8.Value = DateTime.Now.ToString("yyyy   MM   dd");
                paramField8.CurrentValues.Add(discreteVal8);

                ParameterField paramField9 = new ParameterField();
                paramField9.Name = "yj_daxie";
                ParameterDiscreteValue discreteVal9 = new ParameterDiscreteValue();
                discreteVal9.Value = common.DaXie(spinEditDeposit.Value.ToString());
                paramField9.CurrentValues.Add(discreteVal9);

                ParameterField paramField10 = new ParameterField();
                paramField10.Name = "shiwan";
                ParameterDiscreteValue discreteVal10 = new ParameterDiscreteValue();
                discreteVal10.Value = clearZero(100000) ? (desposit / 100000).ToString() : "";
                paramField10.CurrentValues.Add(discreteVal10);

                ParameterField paramField11 = new ParameterField();
                paramField11.Name = "wan";
                ParameterDiscreteValue discreteVal11 = new ParameterDiscreteValue();
                discreteVal11.Value = clearZero(10000) ? ((desposit % 100000) / 10000).ToString() : "";
                paramField11.CurrentValues.Add(discreteVal11);

                ParameterField paramField12 = new ParameterField();
                paramField12.Name = "qian";
                ParameterDiscreteValue discreteVal12 = new ParameterDiscreteValue();
                discreteVal12.Value = clearZero(1000) ? ((desposit % 10000) / 1000).ToString() : "";
                paramField12.CurrentValues.Add(discreteVal12);

                ParameterField paramField13 = new ParameterField();
                paramField13.Name = "bai";
                ParameterDiscreteValue discreteVal13 = new ParameterDiscreteValue();
                discreteVal13.Value = clearZero(100) ? ((desposit % 1000) / 100).ToString() : "";
                paramField13.CurrentValues.Add(discreteVal13);

                ParameterField paramField14 = new ParameterField();
                paramField14.Name = "ge";
                ParameterDiscreteValue discreteVal14 = new ParameterDiscreteValue();
                discreteVal14.Value = (desposit % 10).ToString(); ;
                paramField14.CurrentValues.Add(discreteVal14);

                ParameterField paramField15 = new ParameterField();
                paramField15.Name = "shi";
                ParameterDiscreteValue discreteVal15 = new ParameterDiscreteValue();
                discreteVal15.Value = clearZero(10) ? ((desposit % 100) / 10).ToString() : "";
                paramField15.CurrentValues.Add(discreteVal15);

                string company = " ";
                if (dt.Rows[0]["company"].ToString() != "")
                {
                    company = "(" + dt.Rows[0]["company"].ToString() + ")";
                }
                ParameterField paramField16 = new ParameterField();
                paramField16.Name = "company";
                ParameterDiscreteValue discreteVal16 = new ParameterDiscreteValue();
                discreteVal16.Value = company;
                paramField16.CurrentValues.Add(discreteVal16);

                ParameterField paramField17 = new ParameterField();
                paramField17.Name = "buildingsn";
                ParameterDiscreteValue discreteVal17 = new ParameterDiscreteValue();
                discreteVal17.Value = lblBuilding.Text.Replace("号楼", "#") + lblSn.Text;
                paramField17.CurrentValues.Add(discreteVal17);

                paramFields.Add(paramField);
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

            }
            catch { }
            finally
            {
                crystalReportViewer1.ParameterFieldInfo = paramFields;
                crystalReportViewer1.ReportSource = repostDoc;
            }
        }
    }
}
