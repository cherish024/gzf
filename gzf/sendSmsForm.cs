using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace gzf
{
    public partial class sendSmsForm : Form
    {
        public sendSmsForm()
        {
            InitializeComponent();
            listBox1.DisplayMember = "text";
            listBox1.ValueMember = "key";
        }

        private void sendSmsForm_Load(object sender, EventArgs e)
        {
            DataTable buildDT = DB.select("select * from gzf_building");
            foreach (DataRow dr in buildDT.Rows)
            {
                treeView1.Nodes.Add(dr["id"].ToString(), dr["name"].ToString());
                DataTable houseDT = DB.select("select * from gzf_guest,gzf_openhouse,gzf_house where gzf_house.building_id=" + dr["id"].ToString() + " and status=0 and gzf_house.id=gzf_guest.house_id and gzf_openhouse.house_id=gzf_house.id and gzf_openhouse.is_jiezhang=0 and gzf_guest.openhouse_id=gzf_openhouse.id");
                foreach (DataRow dr2 in houseDT.Rows)
                {
                    treeView1.Nodes[dr["id"].ToString()].Nodes.Add(dr2["id"].ToString(), dr2["sn"].ToString() + "(" + dr2["name"].ToString() + ":" + dr2["phone"].ToString() + ")");
                    treeView1.Nodes[dr["id"].ToString()].Nodes[dr2["id"].ToString()].Tag = dr2["building_id"].ToString();
                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btn_right_Click(sender, e);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                return;
            }
            TreeNode tn = treeView1.SelectedNode;
            if (tn.Text.Contains("号楼"))
            {
                foreach (TreeNode treenode in tn.Nodes)
                {
                    listBox1.Items.Add(treenode);
                }
                tn.Nodes.Clear();
                return;
            }
            listBox1.Items.Add(tn);
            tn.Remove();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            TreeNode tn = (TreeNode)listBox1.SelectedItem;
            listBox1.Items.Remove(tn);
            treeView1.Nodes[tn.Tag.ToString()].Nodes.Add(tn);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            btn_Send.Enabled = false;
            btn_Send.Text = "发送短信中...";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> mobiles = new List<string>();
            if (checkBox1.Checked)
            {
                string[] split = textBox1.Text.Split(new char[] {','});
                foreach (string str in split)
                {
                    mobiles.Add(str);
                }
            }
            else
            {
                foreach (TreeNode treenode in listBox1.Items)
                {
                    mobiles.Add((treenode.Text.Split(':'))[1].Replace(")", ""));
                }
            }
            SmsService sms = new SmsService();
            string xml = ToServiceXML.getSendSmsXMLstr(txtContent.Text, mobiles); //拼装xml数据
            string sendSmsBack = sms.SendSmsToServer(xml); //开始远程调用
            string sendSmsBack1 = sendSmsBack.Replace(">", ">\r\n");

            ///////////////////////////////////解析反馈结果///////////////////////////////////////
            XmlDocument m_XmlDoc = new XmlDocument();
            try
            {
                m_XmlDoc.LoadXml(sendSmsBack);
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(m_XmlDoc.NameTable);
                XmlNodeList nodeList = m_XmlDoc.ChildNodes;
                XmlNode node = nodeList.Item(1);
                //ErrorFlag 为0,即表示修改成功
                string ErrorFlag = node.FirstChild.SelectSingleNode("Header").SelectSingleNode("ErrorFlag").InnerText;
                string ReturnMessage = node.FirstChild.SelectSingleNode("Header").SelectSingleNode("ReturnMessage").InnerText;
                string queryResultS = "";
                queryResultS = queryResultS + "ErrorFlag :" + ErrorFlag + "\r\n" + "ReturnMessage:" + ReturnMessage + "\r\n";
                e.Result = ErrorFlag;
            }
            catch 
            {
                
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result.ToString() == "0")
            {
                MessageBox.Show("发送成功！");
            }
            else
            {
                MessageBox.Show("发送失败！请重新尝试");
            }
            btn_Send.Enabled = true;
            btn_Send.Text = "发送短信";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

    }
}
