using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace gzf
{
    public partial class mainForm : Form
    {
        TabPage tab;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                btn_personOpen.Visible = false;
                btn_groupOpen.Visible = false;
                btn_jiezhang.Visible = false;
                btn_SMS.Visible = false;
                btn_tongji.Visible = false;
                btn_Warning.Visible = false;
                btn_pay.Visible = false;
                btn_Config.Visible = false;
                groupBox1.Visible = false;
            }
            lbltime.Text = DateTime.Now.ToString();
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height-40;
            this.Size = new Size(width, height);
            tabHouse.Size = new Size(width - 230, height - 150);
            DataTable dt = new DataTable();
            dt = DB.select("select * from gzf_building order by sortnum");
            tabHouse.TabPages.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                TabPage tab = new TabPage();
                tab.Text = dr["name"].ToString().Replace("楼","");
                tab.Tag = dr["id"].ToString();
                tab.Name = dr["id"].ToString();
                tabHouse.TabPages.Add(tab);
                this.tabHouse.TabPages[tab.Tag.ToString()].Click += new EventHandler(tabPages_Click);
                this.tabHouse.TabPages[tab.Tag.ToString()].AutoScroll = true;
            }
            tabHouse_Selected(this.tabHouse, new TabControlEventArgs(tabHouse.TabPages[0], 0, TabControlAction.Selected));
            timerWarning_Tick(sender, e);
        }

        public void loadinfo()
        {
            model.House house = common.houseSelect;
            model.HouseStatus hs = new gzf.model.HouseStatus(house.status);
            lblstatus.Text = hs.Statustxt;
            lblPrice.Text = house.price.ToString();
            lblName.Text = "无客人";
            if (house.status == 0 || house.status == 6)
            {
                lblName.Text = "";
                string openid = common.GetOpenhouse_id(house.id);
                DataTable dt = DB.select("select * from gzf_openhouse where id=" + openid);
                //DataTable dt2 = DB.select("select name from gzf_guest where house_id=" + house.id + " and openhouse_id=" + openid);
                DataTable dt2 = DB.select("select name from gzf_guest where openhouse_id=" + openid);
                DataTable dt3 = DB.select("select * from gzf_payment where openhouse_id=" + openid + " ORDER BY addtime asc");
                DataTable dt4 = DB.select("select * from gzf_payment where openhouse_id=" + openid + " ORDER BY addtime desc");
                foreach (DataRow dr in dt2.Rows)
                {
                    lblName.Text += dr["name"] + ", ";
                }
                try
                {
                    lblName.Text = lblName.Text.Remove(lblName.Text.Length - 2);
                    lblPrice.Text = dt.Rows[0]["price"].ToString();
                    lblStartTime.Text = Convert.ToDateTime(dt3.Rows[0]["start_time"]).ToString("d");
                    lblEndTime.Text = Convert.ToDateTime(dt4.Rows[0]["end_time"]).ToString("d");
                    lblFapiao.Text = dt4.Rows[0]["fapiao"].ToString();
                    lblHetong.Text = dt.Rows[0]["fapiao"].ToString();
                }
                catch { };
                //选中团体其他房间
                if (dt.Rows[0]["is_team"].ToString() != "0")
                {
                    DataTable teamhouse = DB.select("select house_id,id from gzf_openhouse where is_team=" + dt.Rows[0]["is_team"].ToString() + " and is_jiezhang=0");
                    foreach(DataRow dr in teamhouse.Rows)
                    {
                        //MessageBox.Show();
                        //MessageBox.Show();
                        if (dt.Rows[0]["id"].ToString() == dr["id"].ToString())
                        {
                            ((houseControl)tab.Controls[dr["house_id"].ToString()]).BackColor = Color.DarkSeaGreen;
                        }
                        else
                        {
                            ((houseControl)tab.Controls[dr["house_id"].ToString()]).BackColor = Color.LightSteelBlue;
                        }
                    }
                    common.teamSelect = true;
                }
            }
        }

        public void clearinfo()
        {
            lblstatus.Text = "";
            lblPrice.Text = "";
            lblName.Text = "";
            lblStartTime.Text = "";
            lblEndTime.Text = "";
            lblFapiao.Text = "";
            lblHetong.Text = "";
            if (common.teamSelect == true)
            {
                common.teamSelect = false;
                string openid = common.GetOpenhouse_id(common.houseSelect.id);
                DataTable dt = DB.select("select * from gzf_openhouse where id=" + openid);
                DataTable teamhouse = DB.select("select house_id from gzf_openhouse where is_team=" + dt.Rows[0]["is_team"].ToString());
                foreach (DataRow dr in teamhouse.Rows)
                {
                    ((houseControl)tab.Controls[dr["house_id"].ToString()]).BackColor = Color.DarkGray;
                }
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editUserForm euf = new editUserForm(common.User);
            euf.ShowDialog();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Config_Click(this, e);
        }

        private void tabHouse_Selected(object sender, TabControlEventArgs e)
        {
            this.tabHouse.Invalidate();
            if (e.TabPage == null)
            {
                return;
            }
            tab = e.TabPage;
            tab.Controls.Clear();
            int x = 10;
            int y = 10;
            for (int i = 7; i > 0 ; i--)
            {
                for (int position = 1; position >=0; position--)
                {
                    DataTable dt = new DataTable();
                    dt = DB.select("select * from gzf_house,gzf_building where building_id=" + tab.Tag + " and floor=" + i + " and position=" + position + " and gzf_house.building_id=gzf_building.id order by gzf_house.sn desc");
                    if(dt.Rows.Count == 0)
                    {
                        continue;
                    }
                    if (dt.Rows[0]["dating"].ToString() == "0")
                    {
                        //左边大厅
                        if ((i == 2 ) || i == 1)
                        {
                            if (i == 2 && position == 1)
                            {
                                Panel panel = new Panel();
                                panel.Name = "dating";
                                panel.Location = new Point(x, y);
                                panel.Size = new Size(73 * 2 + 5, 50 * 4 + 15);
                                panel.BackColor = Color.White;
                                panel.Paint += new PaintEventHandler(panel_Paint);
                                tab.Controls.Add(panel);
                            }
                            x += (73 + 5) * 2;
                        }
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        model.House house = new gzf.model.House();
                        house.id = Convert.ToInt32(dr["id"]);
                        house.building_id = Convert.ToInt32(dr["building_id"]);
                        house.floor = Convert.ToInt32(dr["floor"]);
                        house.status = Convert.ToInt32(dr["status"]);
                        house.sn = dr["sn"].ToString();
                        house.price = Convert.ToInt32(dr["price"]);
                        house.Position = Convert.ToInt32(dr["position"]);
                        house.Guestnum = Convert.ToInt32(dr["guestnum"]);
                        house.Leftpos = Convert.ToInt32(dr["leftpos"]);
                        houseControl hs = new houseControl(house);
                        hs.Name = Convert.ToInt32(dr["id"]).ToString();
                        hs.Location = new Point(x + ((hs.Size.Width+5) * house.Leftpos), y);
                        tab.Controls.Add(hs);
                        hs.BringToFront();
                        x += hs.Size.Width + 5 + ((hs.Size.Width+5) * house.Leftpos);
                    }
                    if (dt.Rows[0]["dating"].ToString() == "1")
                    {
                        //右边大厅
                        if ((i == 2 ) || i == 1)
                        {
                            if (i == 2 && position == 0)
                            {
                                Panel panel = new Panel();
                                panel.Name = "dating";
                                panel.Location = new Point(x, y-55);
                                panel.Size = new Size(73 * 2 + 5, 50 * 4 + 15);
                                panel.BackColor = Color.White;
                                panel.Paint += new PaintEventHandler(panel_Paint);
                                tab.Controls.Add(panel);;
                            }
                            x += (73 + 5) * 2;
                        }
                    }
                    x = 10;
                    y += 55;
                }
            }
            //加载统计信息
            model.HouseStatus housestatus = new gzf.model.HouseStatus(1);
            x = 20;
            y = 25;
            groupBox1.Controls.Clear();
            foreach (DictionaryEntry de in housestatus.statusTable)
            {
                if (Convert.ToInt32(de.Key) == 0)
                {
                    continue;
                }
                string count = DB.selectScalar("select count(*) from gzf_house where status=" + de.Key + " and building_id=" + tab.Tag);
                Label lbl = new Label();
                lbl.Text = de.Value.ToString() + "：" + count;
                lbl.Location = new Point(x, y);
                groupBox1.Controls.Add(lbl);
                y += lbl.Size.Height + 1;
            }
            model.OpenHouseKind kind = new gzf.model.OpenHouseKind(1);
            foreach (DictionaryEntry de in kind.statusTable)
            {
                //string count = DB.selectScalar("select count(*) from gzf_openhouse,gzf_house where kind=" + de.Key + " and gzf_openhouse.building_id=" + tab.Tag + " and gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and is_jiezhang=0");
                string count = DB.selectScalar("select count(*) from gzf_openhouse,gzf_house where gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and kind=" + de.Key + " and gzf_openhouse.id in (select Max(id) from gzf_openhouse WHERE gzf_openhouse.building_id=" + tab.Tag + " and is_jiezhang=0 group by house_id)");
                Label lbl = new Label();
                lbl.Text = de.Value.ToString() + "：" + count;
                lbl.Location = new Point(x, y);
                groupBox1.Controls.Add(lbl);
                y += lbl.Size.Height + 1;
            }

            string count1 = DB.selectScalar("select count(*) from gzf_house where building_id=" + tab.Tag);
            Label lbl1 = new Label();
            lbl1.Width = 140;
            lbl1.Text = "该楼共有房屋" + "：" + count1;
            lbl1.Location = new Point(x, y);
            groupBox1.Controls.Add(lbl1);
            y += lbl1.Size.Height + 1;

            count1 = DB.selectScalar("select count(*) from gzf_openhouse,gzf_house where gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and gzf_openhouse.id in (select Max(id) from gzf_openhouse WHERE gzf_openhouse.building_id=" + tab.Tag + " and is_jiezhang=0 group by house_id)");
            lbl1 = new Label();
            lbl1.Width = 140;
            lbl1.Text = "该楼已入住房屋" + "：" + count1;
            lbl1.Location = new Point(x, y);
            groupBox1.Controls.Add(lbl1);
            y += lbl1.Size.Height + 1;

            count1 = DB.selectScalar("select count(*) from gzf_guest,gzf_openhouse,gzf_house where gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and is_jiezhang=0 and gzf_guest.openhouse_id=gzf_openhouse.id" + " and gzf_openhouse.id in (select Max(id) from gzf_openhouse WHERE gzf_openhouse.building_id=" + tab.Tag + " and is_jiezhang=0 group by house_id)");
            lbl1 = new Label();
            lbl1.Width = 140;
            lbl1.Text = "该楼住宿人数" + "：" + count1;
            lbl1.Location = new Point(x, y);
            groupBox1.Controls.Add(lbl1);
            y += lbl1.Size.Height + 1;



            //能源信息
            x = 20;
            y = 25;
            groupBox3.Controls.Clear();
            model.powerType power = new gzf.model.powerType(0);
            foreach (DictionaryEntry de in power.statusTable)
            {
                //string count = DB.selectScalar("select count(*) from gzf_openhouse,gzf_house where kind=" + de.Key + " and gzf_openhouse.building_id=" + tab.Tag + " and gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and is_jiezhang=0");
                string count = DB.selectScalar("select SUM(gzf_power.price) from gzf_openhouse,gzf_house,gzf_power where gzf_openhouse.house_id=gzf_house.id and gzf_house.status=0 and type=" + de.Key + " and gzf_openhouse.id in (select Max(id) from gzf_openhouse WHERE gzf_openhouse.building_id=" + tab.Tag + " and is_jiezhang=0 group by house_id) and gzf_power.openhouse_id=gzf_openhouse.id");
                count = count == "" ? "0" : count;
                Label lbl = new Label();
                lbl.Text = de.Value.ToString() + "：" + count + "元";
                lbl.Location = new Point(x, y);
                groupBox3.Controls.Add(lbl);
                y += lbl.Size.Height + 1;
            }

        }

        void panel_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("宋体", 30f);
            Graphics g = e.Graphics;
            g.DrawString("大厅", font, Brushes.Black, new PointF(25, 35));
            //g.DrawImage(new Bitmap("接待大厅.JPG"), new PointF(0, 0));
        }

        private void tabPages_Click(object sender, EventArgs e)
        {
            TabPage tp = (TabPage)sender;
            tp.Focus();
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            if (common.User.type == 1)
            {
                configForm cf = new configForm();
                cf.ShowDialog(this);
                reloadTab();
            }
            else
            {
                MessageBox.Show("只有管理员才能进入设置！");
            }
        }

        private void btn_personOpen_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            if (common.houseSelect.id == 0)
            {
                MessageBox.Show("请选择需要开单的房屋！");
                return;
            }
            if (common.houseSelect.status != 1)
            {
                MessageBox.Show("该房屋不是可租用状态！");
                return;
            }
            openPersonFrom opf = new openPersonFrom(common.houseSelect);
            opf.ShowDialog();
            reloadTab();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString();
        }

        private void btn_groupOpen_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            openTeamForm op = new openTeamForm();
            op.ShowDialog();
            reloadTab();
        }

        public void reloadForm()
        {
            mainForm_Load(this, new EventArgs());
        }

        public void reloadTab()
        {
            tabHouse_Selected(this.tabHouse, new TabControlEventArgs(tab,0, TabControlAction.Selected));
            //tabHouse.SelectedTab = tab;
        }


        private void timerWarning_Tick(object sender, EventArgs e)
        {
            DataTable dt = DB.select("select house_id,openhouse_id from gzf_payment where openhouse_id in (select id from gzf_openhouse where is_jiezhang=0) AND DateDiff (Day,getdate(),end_time) < 4 and id in (select Max(id) from gzf_payment group by house_id)");
            foreach (DataRow dr in dt.Rows)
            {
                int count2 = Convert.ToInt32(DB.selectScalar("select count(*) from gzf_warning where openhouse_id=" + dr["openhouse_id"].ToString()));
                if (count2 == 0)
                {
                    DB.exec_NonQuery("insert into gzf_warning (openhouse_id,house_id) values (" + dr["openhouse_id"].ToString() + "," + dr["house_id"].ToString() + ")");
                }
                int warningCount = Convert.ToInt32(DB.selectScalar("select count(*) from gzf_warning where openhouse_id=" + dr["openhouse_id"].ToString() + " and is_read=0"));
                if (warningCount > 0)
                {
                    btn_Warning.ForeColor = Color.Red;
                    btn_Warning.Text = "合同到期";
                }
                else
                {
                    btn_Warning.ForeColor = Color.Black;
                    btn_Warning.Text = "合同到期";
                }
            }
        }

        private void btn_Warning_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            warningForm wf = new warningForm();
            wf.ShowDialog();
            timerWarning_Tick(sender, e);
        }

        private void btn_SMS_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            sendSmsForm sms = new sendSmsForm();
            sms.ShowDialog();
        }

        private void btn_jiezhang_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            if (common.houseSelect.id == 0)
            {
                MessageBox.Show("请选择需要结账的房间！");
                return;
            }
            if (common.houseSelect.status != 0)
            {
                MessageBox.Show("该房屋不可结账！");
                return;
            }
            string openhouseid = common.GetOpenhouse_id(common.houseSelect.id);
            if (openhouseid.Trim() == "")
            {
                MessageBox.Show("该房间无法结账！请正常开单后结账！");
                return;
            }
            model.OpenHouse openhouse = new gzf.model.OpenHouse();
            DataTable dt = DB.select("select top 1 * from gzf_openhouse where id=" + openhouseid + " order by id desc");
            openhouse.Id = Convert.ToInt32(dt.Rows[0]["id"]);
            openhouse.House_id = Convert.ToInt32(dt.Rows[0]["house_id"]);
            openhouse.Guest_num = Convert.ToInt32(dt.Rows[0]["guest_num"]);
            openhouse.Building_id = Convert.ToInt32(dt.Rows[0]["building_id"]);
            //openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            openhouse.Start_time = Convert.ToDateTime(dt.Rows[0]["start_time"]);
            openhouse.End_time = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            openhouse.Main_guest_id = Convert.ToInt32(dt.Rows[0]["main_guest_id"]);
            openhouse.Price = Convert.ToInt32(dt.Rows[0]["price"]);
            openhouse.User_id = Convert.ToInt32(dt.Rows[0]["user_id"]);
            openhouse.Is_jiezhang = Convert.ToInt32(dt.Rows[0]["is_jiezhang"]);
            openhouse.Is_team = Convert.ToInt32(dt.Rows[0]["is_team"]);
            jiezhangForm jz = new jiezhangForm(openhouse, common.houseSelect);
            jz.ShowDialog();
            reloadTab();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            if (common.houseSelect.id == 0)
            {
                tongjiGuestForm guest = new tongjiGuestForm();
                guest.ShowDialog();
                return;
            }
            if (common.houseSelect.status != 0 && common.houseSelect.status != 6)
            {
                return;
            }
            guestInfoListForm gilf = new guestInfoListForm(common.houseSelect);
            gilf.ShowDialog();
        }

        private void btn_tongji_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            tongjiForm tj = new tongjiForm();
            tj.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs about = new aboutUs();
            about.ShowDialog();
        }

        private void 散客开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_personOpen_Click(sender, e);
        }

        private void 团体开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_groupOpen_Click(sender, e);
        }

        private void 修改登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Guest_Click(sender, e);
        }

        private void 宾客结账ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_jiezhang_Click(sender, e);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出系统", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            paymentForm pay = new paymentForm();
            pay.ShowDialog();
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            string openhouseid = common.GetOpenhouse_id(common.houseSelect.id);
            if (openhouseid.Trim() == "")
            {
                MessageBox.Show("该房间无法结账！请正常开单后结账！");
                return;
            }
            DataTable dt = DB.select("select top 1 * from gzf_openhouse where id=" + openhouseid + " order by id desc");
            model.OpenHouse openhouse = new gzf.model.OpenHouse();
            openhouse.Id = Convert.ToInt32(dt.Rows[0]["id"]);
            openhouse.House_id = Convert.ToInt32(dt.Rows[0]["house_id"]);
            openhouse.Guest_num = Convert.ToInt32(dt.Rows[0]["guest_num"]);
            openhouse.Building_id = common.houseSelect.building_id;
            //openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            openhouse.Start_time = Convert.ToDateTime(dt.Rows[0]["start_time"]);
            openhouse.End_time = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            openhouse.Main_guest_id = Convert.ToInt32(dt.Rows[0]["main_guest_id"]);
            openhouse.Price = Convert.ToInt32(dt.Rows[0]["price"]);
            openhouse.User_id = Convert.ToInt32(dt.Rows[0]["user_id"]);
            openhouse.Is_jiezhang = Convert.ToInt32(dt.Rows[0]["is_jiezhang"]);
            openhouse.Is_team = Convert.ToInt32(dt.Rows[0]["is_team"]);
            openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            powerInfoForm pi = new powerInfoForm(openhouse, common.houseSelect);
            pi.ShowDialog();
        }
    }
}
