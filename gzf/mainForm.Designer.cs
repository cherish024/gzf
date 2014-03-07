namespace gzf
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.来宾登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.散客开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.团体开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宾客结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宾客结账ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHouse = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHetong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFapiao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_groupOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Config = new DevExpress.XtraEditors.SimpleButton();
            this.lbltime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.btn_SMS = new DevExpress.XtraEditors.SimpleButton();
            this.btn_tongji = new DevExpress.XtraEditors.SimpleButton();
            this.timerWarning = new System.Windows.Forms.Timer(this.components);
            this.btn_Warning = new DevExpress.XtraEditors.SimpleButton();
            this.btn_jiezhang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pay = new DevExpress.XtraEditors.SimpleButton();
            this.btn_personOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btn_power = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房屋统计";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.来宾登记ToolStripMenuItem,
            this.宾客结账ToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 来宾登记ToolStripMenuItem
            // 
            this.来宾登记ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.散客开单ToolStripMenuItem,
            this.团体开单ToolStripMenuItem,
            this.修改登记ToolStripMenuItem});
            this.来宾登记ToolStripMenuItem.Name = "来宾登记ToolStripMenuItem";
            this.来宾登记ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.来宾登记ToolStripMenuItem.Text = "来宾登记";
            // 
            // 散客开单ToolStripMenuItem
            // 
            this.散客开单ToolStripMenuItem.Name = "散客开单ToolStripMenuItem";
            this.散客开单ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.散客开单ToolStripMenuItem.Text = "个人开单";
            this.散客开单ToolStripMenuItem.Click += new System.EventHandler(this.散客开单ToolStripMenuItem_Click);
            // 
            // 团体开单ToolStripMenuItem
            // 
            this.团体开单ToolStripMenuItem.Name = "团体开单ToolStripMenuItem";
            this.团体开单ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.团体开单ToolStripMenuItem.Text = "团体开单";
            this.团体开单ToolStripMenuItem.Click += new System.EventHandler(this.团体开单ToolStripMenuItem_Click);
            // 
            // 修改登记ToolStripMenuItem
            // 
            this.修改登记ToolStripMenuItem.Name = "修改登记ToolStripMenuItem";
            this.修改登记ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改登记ToolStripMenuItem.Text = "修改登记";
            this.修改登记ToolStripMenuItem.Click += new System.EventHandler(this.修改登记ToolStripMenuItem_Click);
            // 
            // 宾客结账ToolStripMenuItem
            // 
            this.宾客结账ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宾客结账ToolStripMenuItem1});
            this.宾客结账ToolStripMenuItem.Name = "宾客结账ToolStripMenuItem";
            this.宾客结账ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宾客结账ToolStripMenuItem.Text = "收银结算";
            // 
            // 宾客结账ToolStripMenuItem1
            // 
            this.宾客结账ToolStripMenuItem1.Name = "宾客结账ToolStripMenuItem1";
            this.宾客结账ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.宾客结账ToolStripMenuItem1.Text = "宾客结账";
            this.宾客结账ToolStripMenuItem1.Click += new System.EventHandler(this.宾客结账ToolStripMenuItem1_Click);
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.系统设置ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // tabHouse
            // 
            this.tabHouse.ItemSize = new System.Drawing.Size(34, 18);
            this.tabHouse.Location = new System.Drawing.Point(208, 102);
            this.tabHouse.Name = "tabHouse";
            this.tabHouse.SelectedIndex = 0;
            this.tabHouse.Size = new System.Drawing.Size(869, 516);
            this.tabHouse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabHouse.TabIndex = 0;
            this.tabHouse.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabHouse_Selected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHetong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblFapiao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.lblEndTime);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblstatus);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 206);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房屋信息";
            // 
            // lblHetong
            // 
            this.lblHetong.AutoSize = true;
            this.lblHetong.Location = new System.Drawing.Point(82, 179);
            this.lblHetong.Name = "lblHetong";
            this.lblHetong.Size = new System.Drawing.Size(0, 12);
            this.lblHetong.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "合同发票：";
            // 
            // lblFapiao
            // 
            this.lblFapiao.AutoSize = true;
            this.lblFapiao.Location = new System.Drawing.Point(82, 156);
            this.lblFapiao.Name = "lblFapiao";
            this.lblFapiao.Size = new System.Drawing.Size(0, 12);
            this.lblFapiao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "缴费发票：";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(84, 111);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(0, 12);
            this.lblStartTime.TabIndex = 9;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(84, 133);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(0, 12);
            this.lblEndTime.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(84, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 12);
            this.lblPrice.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "无客人";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(82, 66);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 12);
            this.lblstatus.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "租金开始：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "租金结束：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "房间租金：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "房间状态：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "租客姓名：";
            // 
            // btn_groupOpen
            // 
            this.btn_groupOpen.AllowFocus = false;
            this.btn_groupOpen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_groupOpen.Image = ((System.Drawing.Image)(resources.GetObject("btn_groupOpen.Image")));
            this.btn_groupOpen.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_groupOpen.Location = new System.Drawing.Point(107, 28);
            this.btn_groupOpen.Name = "btn_groupOpen";
            this.btn_groupOpen.Size = new System.Drawing.Size(61, 61);
            this.btn_groupOpen.TabIndex = 15;
            this.btn_groupOpen.Text = "团体开单";
            this.btn_groupOpen.Click += new System.EventHandler(this.btn_groupOpen_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.AllowFocus = false;
            this.btn_Config.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_Config.Image = ((System.Drawing.Image)(resources.GetObject("btn_Config.Image")));
            this.btn_Config.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Config.Location = new System.Drawing.Point(720, 28);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(61, 61);
            this.btn_Config.TabIndex = 16;
            this.btn_Config.Text = "系统设置";
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(18, 914);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(35, 12);
            this.lbltime.TabIndex = 17;
            this.lbltime.Text = "timer";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // btn_SMS
            // 
            this.btn_SMS.AllowFocus = false;
            this.btn_SMS.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_SMS.Image = ((System.Drawing.Image)(resources.GetObject("btn_SMS.Image")));
            this.btn_SMS.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_SMS.Location = new System.Drawing.Point(285, 28);
            this.btn_SMS.Name = "btn_SMS";
            this.btn_SMS.Size = new System.Drawing.Size(61, 61);
            this.btn_SMS.TabIndex = 18;
            this.btn_SMS.Text = "短信发送";
            this.btn_SMS.Click += new System.EventHandler(this.btn_SMS_Click);
            // 
            // btn_tongji
            // 
            this.btn_tongji.AllowFocus = false;
            this.btn_tongji.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_tongji.Image = ((System.Drawing.Image)(resources.GetObject("btn_tongji.Image")));
            this.btn_tongji.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_tongji.Location = new System.Drawing.Point(463, 28);
            this.btn_tongji.Name = "btn_tongji";
            this.btn_tongji.Size = new System.Drawing.Size(61, 61);
            this.btn_tongji.TabIndex = 20;
            this.btn_tongji.Text = "营业统计";
            this.btn_tongji.Click += new System.EventHandler(this.btn_tongji_Click);
            // 
            // timerWarning
            // 
            this.timerWarning.Enabled = true;
            this.timerWarning.Interval = 1800000;
            this.timerWarning.Tick += new System.EventHandler(this.timerWarning_Tick);
            // 
            // btn_Warning
            // 
            this.btn_Warning.AllowFocus = false;
            this.btn_Warning.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_Warning.Image = ((System.Drawing.Image)(resources.GetObject("btn_Warning.Image")));
            this.btn_Warning.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_Warning.Location = new System.Drawing.Point(374, 28);
            this.btn_Warning.Name = "btn_Warning";
            this.btn_Warning.Size = new System.Drawing.Size(61, 61);
            this.btn_Warning.TabIndex = 21;
            this.btn_Warning.Text = "合同到期";
            this.btn_Warning.Click += new System.EventHandler(this.btn_Warning_Click);
            // 
            // btn_jiezhang
            // 
            this.btn_jiezhang.AllowFocus = false;
            this.btn_jiezhang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_jiezhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_jiezhang.Image")));
            this.btn_jiezhang.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_jiezhang.Location = new System.Drawing.Point(196, 28);
            this.btn_jiezhang.Name = "btn_jiezhang";
            this.btn_jiezhang.Size = new System.Drawing.Size(61, 61);
            this.btn_jiezhang.TabIndex = 22;
            this.btn_jiezhang.Text = "结账";
            this.btn_jiezhang.Click += new System.EventHandler(this.btn_jiezhang_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AllowFocus = false;
            this.btn_exit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(809, 28);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(61, 61);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "退出系统";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.AllowFocus = false;
            this.btn_pay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_pay.Image = ((System.Drawing.Image)(resources.GetObject("btn_pay.Image")));
            this.btn_pay.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_pay.Location = new System.Drawing.Point(552, 28);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(61, 61);
            this.btn_pay.TabIndex = 24;
            this.btn_pay.Text = "房费到期";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_personOpen
            // 
            this.btn_personOpen.AllowFocus = false;
            this.btn_personOpen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_personOpen.Image = ((System.Drawing.Image)(resources.GetObject("btn_personOpen.Image")));
            this.btn_personOpen.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_personOpen.Location = new System.Drawing.Point(18, 28);
            this.btn_personOpen.Name = "btn_personOpen";
            this.btn_personOpen.Size = new System.Drawing.Size(61, 61);
            this.btn_personOpen.TabIndex = 14;
            this.btn_personOpen.TabStop = false;
            this.btn_personOpen.Text = "个人开单";
            this.btn_personOpen.Click += new System.EventHandler(this.btn_personOpen_Click);
            // 
            // btn_power
            // 
            this.btn_power.AllowFocus = false;
            this.btn_power.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_power.Image = ((System.Drawing.Image)(resources.GetObject("btn_power.Image")));
            this.btn_power.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_power.Location = new System.Drawing.Point(638, 28);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(61, 61);
            this.btn_power.TabIndex = 25;
            this.btn_power.Text = "水电费";
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(19, 686);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 223);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "该楼能源费用";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1110, 939);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_power);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_jiezhang);
            this.Controls.Add(this.btn_Warning);
            this.Controls.Add(this.btn_tongji);
            this.Controls.Add(this.btn_SMS);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_groupOpen);
            this.Controls.Add(this.btn_personOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabHouse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "房产管理系统";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 来宾登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 散客开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 团体开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宾客结账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宾客结账ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_groupOpen;
        private DevExpress.XtraEditors.SimpleButton btn_Config;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timerTime;
        private DevExpress.XtraEditors.SimpleButton btn_SMS;
        private DevExpress.XtraEditors.SimpleButton btn_tongji;
        private System.Windows.Forms.Timer timerWarning;
        private DevExpress.XtraEditors.SimpleButton btn_Warning;
        private DevExpress.XtraEditors.SimpleButton btn_jiezhang;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.SimpleButton btn_pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFapiao;
        private DevExpress.XtraEditors.SimpleButton btn_personOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHetong;
        private DevExpress.XtraEditors.SimpleButton btn_power;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}