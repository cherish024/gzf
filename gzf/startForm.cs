using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;

namespace gzf
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cmd = "select count(*) from gzf_user where username='" + txtUsername.Text + "' and password='" + common.MD5Encrypt(txtPassword.Text) + "'";
            int count = Convert.ToInt16(DB.selectScalar(cmd));
            if(count > 0)
            {
                //数据库升级
                //添加建筑排序字段
                string sortnumstr = DB.selectScalar("select name from syscolumns where name='sortnum' and id=object_id('gzf_building')");
                if (sortnumstr.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_building ADD sortnum INT");
                    int sortnum = 1;
                    for (int i = 9; i <= 33; i++)
                    {
                        DB.exec_NonQuery("update gzf_building set sortnum=" + sortnum + " where id=" + i);
                        sortnum++;
                    }
                    DB.exec_NonQuery("update gzf_building set sortnum=26 where id=35");
                    DB.exec_NonQuery("update gzf_building set sortnum=27 where id=2");
                    DB.exec_NonQuery("update gzf_building set sortnum=28 where id=4");
                    DB.exec_NonQuery("update gzf_building set sortnum=29 where id=5");
                    DB.exec_NonQuery("update gzf_building set sortnum=30 where id=6");
                    DB.exec_NonQuery("update gzf_building set sortnum=31 where id=7");
                    DB.exec_NonQuery("update gzf_building set sortnum=32 where id=8");
                }
                //添加水电费天数字段
                string pay_day = DB.selectScalar("select name from syscolumns where name='pay_day' and id=object_id('gzf_power')");
                if (pay_day.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_power ADD pay_day INT");
                }
                //添加房屋排序字段
                string sort = DB.selectScalar("select name from syscolumns where name='sortnum' and id=object_id('gzf_house')");
                if (sort.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_house ADD sortnum INT");
                    DB.exec_NonQuery("update gzf_house set sortnum=0");
                }
                //添加开房备注字段
                string remark = DB.selectScalar("select name from syscolumns where name='remark' and id=object_id('gzf_openhouse')");
                if (remark.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_openhouse ADD remark varchar(255)");
                    DB.exec_NonQuery("update gzf_openhouse set remark=''");
                }
                //添加建筑大厅字段
                string dating = DB.selectScalar("select name from syscolumns where name='dating' and id=object_id('gzf_building')");
                if (dating.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_building ADD dating INT");
                    DB.exec_NonQuery("update gzf_building set dating=0");
                }
                //添加客户学生证字段
                string student = DB.selectScalar("select name from syscolumns where name='student' and id=object_id('gzf_guest')");
                if (student.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_guest ADD student varchar(255)");
                    DB.exec_NonQuery("update gzf_guest set student=''");
                }
                //添加房费开始字段
                string paystart = DB.selectScalar("select name from syscolumns where name='start_time' and id=object_id('gzf_payment')");
                if (paystart.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD start_time datetime");
                }
                //添加房费结束字段
                string payend = DB.selectScalar("select name from syscolumns where name='end_time' and id=object_id('gzf_payment')");
                if (payend.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD end_time datetime");
                }
                //添加水电费开始字段
                string powerstart = DB.selectScalar("select name from syscolumns where name='start_time' and id=object_id('gzf_power')");
                if (powerstart.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_power ADD start_time datetime");
                }
                //添加水电费结束字段
                string powerend = DB.selectScalar("select name from syscolumns where name='end_time' and id=object_id('gzf_power')");
                if (powerend.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_power ADD end_time datetime");
                }
                //添加开房发票字段
                string fapiao = DB.selectScalar("select name from syscolumns where name='fapiao' and id=object_id('gzf_openhouse')");
                if (fapiao.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_openhouse ADD fapiao varchar(255)");
                    DB.exec_NonQuery("update gzf_openhouse set fapiao=''");
                }
                //添加开房支付方式字段
                string method = DB.selectScalar("select name from syscolumns where name='pay_method' and id=object_id('gzf_openhouse')");
                if (method.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_openhouse ADD pay_method INT");
                    DB.exec_NonQuery("update gzf_openhouse set pay_method=1");
                }
                //添加开房性质字段
                string kind = DB.selectScalar("select name from syscolumns where name='kind' and id=object_id('gzf_openhouse')");
                if (kind.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_openhouse ADD kind INT");
                    DB.exec_NonQuery("update gzf_openhouse set kind=0");
                }
                //添加物业费字段
                string wuye = DB.selectScalar("select name from syscolumns where name='wuye' and id=object_id('gzf_openhouse')");
                if (wuye.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_openhouse ADD wuye INT");
                    DB.exec_NonQuery("update gzf_openhouse set wuye=0");
                }
                //添加房费结束字段
                string fp = DB.selectScalar("select name from syscolumns where name='fapiao' and id=object_id('gzf_payment')");
                if (fp.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD fapiao varchar(255)");
                    DB.exec_NonQuery("update gzf_payment set fapiao=''");
                }
                //添加房屋排序字段
                string guestnum = DB.selectScalar("select name from syscolumns where name='guestnum' and id=object_id('gzf_house')");
                if (guestnum.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_house ADD guestnum INT");
                    DB.exec_NonQuery("update gzf_house set guestnum=0");
                }
                //添加房费支付类型字段
                string md1 = DB.selectScalar("select name from syscolumns where name='pay_method' and id=object_id('gzf_payment')");
                if (md1.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD pay_method INT");
                    DB.exec_NonQuery("update gzf_payment set pay_method=1");
                }
                //添加水电费支付类型字段
                string md2 = DB.selectScalar("select name from syscolumns where name='pay_method' and id=object_id('gzf_power')");
                if (md2.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_power ADD pay_method INT");
                    DB.exec_NonQuery("update gzf_power set pay_method=1");
                }
                //添加缴费现金部分字段
                string cash = DB.selectScalar("select name from syscolumns where name='cash' and id=object_id('gzf_payment')");
                if (cash.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD cash INT");
                    DB.exec_NonQuery("update gzf_payment set cash=0");
                }
                //添加缴费信用卡部分字段
                string credit = DB.selectScalar("select name from syscolumns where name='credit' and id=object_id('gzf_payment')");
                if (credit.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD credit INT");
                    DB.exec_NonQuery("update gzf_payment set credit=0");
                }
                //添加缴费其他部分字段
                string other = DB.selectScalar("select name from syscolumns where name='other' and id=object_id('gzf_payment')");
                if (other.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_payment ADD other INT");
                    DB.exec_NonQuery("update gzf_payment set other=0");
                }
                //添加账单退款字段
                string refund = DB.selectScalar("select name from syscolumns where name='refund' and id=object_id('gzf_zd')");
                if (refund.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_zd ADD refund INT");
                    DB.exec_NonQuery("update gzf_zd set refund=0");
                }
                //添加房屋位移字段
                string left = DB.selectScalar("select name from syscolumns where name='leftpos' and id=object_id('gzf_house')");
                if (left.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_house ADD leftpos INT");
                    DB.exec_NonQuery("update gzf_house set leftpos=0");
                }
                //添加水电状态字段
                string status = DB.selectScalar("select name from syscolumns where name='status' and id=object_id('gzf_power')");
                if (status.Trim() == "")
                {
                    DB.exec_NonQuery("ALTER TABLE gzf_power ADD status INT");
                    DB.exec_NonQuery("update gzf_power set status=1");
                }
                //数据库升级结束
                if (chkUsername.Checked)
                {
                    XmlDocument configXml = new XmlDocument();
                    configXml.Load("config.xml");
                    configXml["config"]["User"]["name"].InnerText = txtUsername.Text;
                    configXml.Save("config.xml");
                }
                else
                {
                    XmlDocument configXml = new XmlDocument();
                    configXml.Load("config.xml");
                    configXml["config"]["User"]["name"].InnerText = "";
                    configXml.Save("config.xml");
                }
                if (chkPass.Checked)
                {
                    XmlDocument configXml = new XmlDocument();
                    configXml.Load("config.xml");
                    configXml["config"]["User"]["pass"].InnerText = txtPassword.Text;
                    configXml.Save("config.xml");
                }
                else
                {
                    XmlDocument configXml = new XmlDocument();
                    configXml.Load("config.xml");
                    configXml["config"]["User"]["pass"].InnerText = "";
                    configXml.Save("config.xml");
                }
                DataTable dt = DB.select("select * from gzf_user where username='" + txtUsername.Text + "'");
                common.User.id = Convert.ToInt16(dt.Rows[0]["id"]);
                common.User.username = dt.Rows[0]["username"].ToString();
                common.User.fullname = dt.Rows[0]["fullname"].ToString();
                common.User.type = Convert.ToInt16(dt.Rows[0]["type"]);
                mainForm m = new mainForm();
                this.Hide();
                m.ShowDialog();
                this.Close();
                return;
            }
            MessageBox.Show("用户名或密码错误！");
        }

        private void startForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            startForm_KeyDown(sender, e);
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            txtUsername.DataSource = DB.select("select username from gzf_user");
            txtUsername.DisplayMember = "username";
            XmlDocument configXml = new XmlDocument();
            configXml.Load("config.xml");
            txtUsername.Text = configXml["config"]["User"]["name"].InnerText;
            txtPassword.Text = configXml["config"]["User"]["pass"].InnerText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.exec_NonQuery("Truncate Table gzf_zd");
            DB.exec_NonQuery("Truncate Table gzf_warning");
            DB.exec_NonQuery("Truncate Table gzf_power");
            DB.exec_NonQuery("Truncate Table gzf_payment");
            DB.exec_NonQuery("Truncate Table gzf_openhouse");
            DB.exec_NonQuery("Truncate Table gzf_teamopenhouse");
            DB.exec_NonQuery("update gzf_house set status=1");
            MessageBox.Show("清除成功");
        }

        private void txtUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
