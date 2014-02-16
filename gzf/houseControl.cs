using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace gzf
{
    public partial class houseControl : UserControl
    {
        private Color startColor;
        private model.House house;
        public houseControl(model.House house)
        {
            InitializeComponent();
            this.house = house;
            loadview();
            if (common.User.type == 2)
            {
                contextMenuStrip1.Items.Clear();
            }
        }

        public void loadview()
        {
            DataTable dt = DB.select("select * from gzf_house where id=" + house.id);
            this.house.building_id = Convert.ToInt32(dt.Rows[0]["building_id"]);
            this.house.floor = Convert.ToInt32(dt.Rows[0]["floor"]);
            this.house.price = Convert.ToInt32(dt.Rows[0]["price"]);
            this.house.sn = dt.Rows[0]["sn"].ToString();
            this.house.status = Convert.ToInt32(dt.Rows[0]["status"]);
            this.house.Position = Convert.ToInt32(dt.Rows[0]["position"]);
            int status = house.status;
            if (status == 0 || status == 6)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = true;
                contextMenuStrip1.Items[3].Enabled = true;
                contextMenuStrip1.Items[5].Enabled = true;
                contextMenuStrip1.Items[6].Enabled = true;
                contextMenuStrip1.Items[7].Enabled = true;
            }
            if (status == 1)
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = true;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
            }
            if (status == 2)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
            }
            if (status == 3)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
            }
            if (status == 4)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
            }
            if (status == 5)
            {
                contextMenuStrip1.Items[3].Enabled = false;
            }
            startColor = this.BackColor;
        }

        private void houseControl_Leave(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.DarkGray;
                this.BorderStyle = BorderStyle.None;
                if (this.Parent.Parent != null)
                {
                    ((mainForm)this.Parent.Parent.Parent).clearinfo();
                }
                common.houseSelect = new model.House();
            }
            catch
            { }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            houseControl_Click(sender, new MouseEventArgs(MouseButtons.Right,1,0,0,0));
        }

        private void 散客开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            if (common.houseSelect.status == 1 || common.houseSelect.status == 6)
            {
                openPersonFrom opf = new openPersonFrom(this.house);
                opf.ShowDialog();
                this.loadview();
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("该房屋不是可租用状态！");
            }

        }

        private void 更改房态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            changeStatusForm cs = new changeStatusForm(this.house);
            cs.ShowDialog();
            this.loadview();
            this.Invalidate();
        }

        private void 客人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            guestInfoListForm gilf = new guestInfoListForm(house);
            gilf.ShowDialog();
        }

        private void 退房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            //结账
            string openhouseid = common.GetOpenhouse_id(house.id);
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
            openhouse.Building_id = house.building_id;
            //openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            openhouse.Start_time = Convert.ToDateTime(dt.Rows[0]["start_time"]);
            openhouse.End_time = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            openhouse.Main_guest_id = Convert.ToInt32(dt.Rows[0]["main_guest_id"]);
            openhouse.Price = Convert.ToInt32(dt.Rows[0]["price"]);
            openhouse.User_id = Convert.ToInt32(dt.Rows[0]["user_id"]);
            openhouse.Is_jiezhang = Convert.ToInt32(dt.Rows[0]["is_jiezhang"]);
            openhouse.Is_team = Convert.ToInt32(dt.Rows[0]["is_team"]);
            openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            jiezhangForm jz = new jiezhangForm(openhouse, this.house);
            jz.ShowDialog();
            this.loadview();
            this.Invalidate();
            if (common.teamSelect)
            {
                ((mainForm)this.Parent.Parent.Parent).reloadTab();
            }
        }


        private void houseControl_DoubleClick(object sender, EventArgs e)
        {
            if (house.status == 1)
            {
                if (common.User.type == 2)
                {
                    return;
                }
                散客开单ToolStripMenuItem_Click(sender, new MouseEventArgs(MouseButtons.Left, 2, 0, 0, 0));
            }
            else if (house.status == 0 || house.status == 6)
            {
                if (common.User.type == 2)
                {
                    水电费明细ToolStripMenuItem_Click_1(sender, e);
                    return;
                }
                退房ToolStripMenuItem_Click(sender, new MouseEventArgs(MouseButtons.Left, 2, 0, 0, 0));
            }
            else
            {
                更改房态ToolStripMenuItem_Click(sender, new MouseEventArgs(MouseButtons.Left, 2, 0, 0, 0));
            }
        }

        private void 团体开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            openTeamForm op = new openTeamForm();
            op.ShowDialog();
            ((mainForm)this.Parent.Parent.Parent).reloadTab();
        }

        public void houseControl_Click(object sender, EventArgs e)
        {
            try
            {
                common.houseSelect = this.house;
                this.BackColor = Color.LightSteelBlue;
                //this.BorderStyle = BorderStyle.Fixed3D;
                ((mainForm)this.Parent.Parent.Parent).loadinfo();
            }
            catch { }
        }

        private void houseControl_Paint(object sender, PaintEventArgs e)
        {
            //lblSn.Text = house.sn;
            //lblPrice.Text = "租金：" + house.price;
            //lblstatus.Text = hs.Statustxt;
            Font font = new Font("宋体", 9f);
            Graphics g = e.Graphics;
            model.HouseStatus hs = new gzf.model.HouseStatus(house.status);
            //绘制房号背景
            switch (house.status)
            { 
                case 0:
                    string openhouseid = common.GetOpenhouse_id(house.id);
                    DataTable dt = DB.select("select top 1 price,is_team,kind from gzf_openhouse where id=" + openhouseid + " order by id desc");
                    g.FillRectangle(Brushes.Green, 0, 0, 73, 15);
                    if (dt.Rows[0]["kind"].ToString() == "3")
                    {
                        g.FillRectangle(Brushes.Orange, 0, 0, 73, 15);
                    }
                    model.OpenHouseKind kind = new gzf.model.OpenHouseKind(Convert.ToInt16(dt.Rows[0]["kind"]));
                    g.DrawString(kind.Statustxt, font, Brushes.White, new PointF(15, 19));
                    //绘制团体主房间标记
                    if (openhouseid == dt.Rows[0]["is_team"].ToString())
                    {
                        g.DrawString("*", new Font("宋体", 9f, FontStyle.Bold), Brushes.White, new PointF(5, 1));
                    }
                    if (dt.Rows[0]["is_team"].ToString() != "0")
                    {
                        //string mainOpenid = DB.selectScalar("select id from gzf_openhouse where is_team=");
                        string name = DB.selectScalar("select name from gzf_openhouse,gzf_guest where gzf_guest.openhouse_id=gzf_openhouse.id and gzf_openhouse.id=" + dt.Rows[0]["is_team"].ToString() + " and gzf_openhouse.id=gzf_openhouse.is_team");
                        g.DrawString(name, font, Brushes.Black, new PointF(4, 36));
                        g.DrawString("团", new Font("宋体", 9f, FontStyle.Bold), Brushes.White, new PointF(53, 1));
                    }
                    else
                    {
                        if (dt.Rows[0]["kind"].ToString() == "3")
                        {
                            string name = DB.selectScalar("select name from gzf_openhouse,gzf_guest where gzf_guest.openhouse_id=gzf_openhouse.id and gzf_openhouse.id=" + openhouseid);
                            g.DrawString(name, font, Brushes.Black, new PointF(4, 36));
                        }
                        else
                        {
                            g.DrawString("租金：" + dt.Rows[0]["price"], font, Brushes.Black, new PointF(4, 36));
                        }
                    }
                    break;
                case 1:
                    g.FillRectangle(Brushes.Red, 0, 0, 73, 15);
                    g.DrawString("租金：" + house.price, font, Brushes.Black, new PointF(4, 36));
                    g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    break;
                case 2:
                    g.FillRectangle(Brushes.DarkOrchid, 0, 0, 73, 15); 
                    g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    break;
                case 3:
                    g.FillRectangle(Brushes.Blue, 0, 0, 73, 15); 
                    g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    break;
                case 4:
                    g.FillRectangle(Brushes.DeepPink, 0, 0, 73, 15);
                    g.DrawString("租金：" + house.price, font, Brushes.Black, new PointF(4, 36));
                    g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    break;
                case 5:
                    g.FillRectangle(Brushes.Orange, 0, 0, 73, 15);
                    g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    break;
                case 6:
                    openhouseid = common.GetOpenhouse_id(house.id);
                    dt = DB.select("select top 1 price,remark from gzf_openhouse where id=" + openhouseid + " order by id desc");
                    g.FillRectangle(Brushes.Green, 0, 0, 73, 15);
                    g.DrawString("租金：" + dt.Rows[0]["price"], font, Brushes.Black, new PointF(4, 36));
                    if (dt.Rows[0]["remark"].ToString().Trim() == "")
                    {
                        g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    }
                    else
                    {
                        g.DrawString(dt.Rows[0]["remark"].ToString(), font, Brushes.White, new PointF(15, 19));
                    }
                    break;
                case 7:
                    g.FillRectangle(Brushes.Navy, 0, 0, 73, 15);
                    g.DrawString(hs.Statustxt, font, Brushes.White, new PointF(15, 19));
                    break;
            }
            //绘制房号
            if (house.Guestnum == 1)
            {
                g.DrawString("四", new Font("宋体", 9f, FontStyle.Bold), Brushes.White, new PointF(1, 1));
            }
            g.DrawString(house.sn, new Font("宋体", 9f,FontStyle.Bold), Brushes.White, new PointF(20, 1));
            g.Dispose();
        }

        private void houseControl_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void 合同信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            openInfoForm oi = new openInfoForm(Convert.ToInt32(common.GetOpenhouse_id(house.id)));
            oi.ShowDialog();
        }

        private void 更换房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            changeHouseForm change = new changeHouseForm(house);
            change.ShowDialog();
            ((mainForm)this.Parent.Parent.Parent).reloadTab();
        }

        private void 房费续费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (common.User.type == 2)
            {
                MessageBox.Show("此用户没有权限进入该功能！");
                return;
            }
            string openhouseid = common.GetOpenhouse_id(house.id);
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
            openhouse.Building_id = house.building_id;
            //openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            openhouse.Start_time = Convert.ToDateTime(dt.Rows[0]["start_time"]);
            openhouse.End_time = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            openhouse.Main_guest_id = Convert.ToInt32(dt.Rows[0]["main_guest_id"]);
            openhouse.Price = Convert.ToInt32(dt.Rows[0]["price"]);
            openhouse.User_id = Convert.ToInt32(dt.Rows[0]["user_id"]);
            openhouse.Is_jiezhang = Convert.ToInt32(dt.Rows[0]["is_jiezhang"]);
            openhouse.Is_team = Convert.ToInt32(dt.Rows[0]["is_team"]);
            openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            xufeiForm xf = new xufeiForm(openhouse, this.house);
            xf.ShowDialog();
        }

        private void 水电费明细ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string openhouseid = common.GetOpenhouse_id(house.id);
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
            openhouse.Building_id = house.building_id;
            //openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            openhouse.Start_time = Convert.ToDateTime(dt.Rows[0]["start_time"]);
            openhouse.End_time = Convert.ToDateTime(dt.Rows[0]["end_time"]);
            openhouse.Main_guest_id = Convert.ToInt32(dt.Rows[0]["main_guest_id"]);
            openhouse.Price = Convert.ToInt32(dt.Rows[0]["price"]);
            openhouse.User_id = Convert.ToInt32(dt.Rows[0]["user_id"]);
            openhouse.Is_jiezhang = Convert.ToInt32(dt.Rows[0]["is_jiezhang"]);
            openhouse.Is_team = Convert.ToInt32(dt.Rows[0]["is_team"]);
            openhouse.Deposit = Convert.ToInt32(dt.Rows[0]["deposit"]);
            powerInfoForm pi = new powerInfoForm(openhouse, this.house);
            pi.ShowDialog();
        }


    }
}
