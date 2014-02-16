namespace gzf
{
    partial class tongjiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tongjiForm));
            this.btn_guest = new DevExpress.XtraEditors.SimpleButton();
            this.btn_jiezhang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_power = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pay = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yajing = new DevExpress.XtraEditors.SimpleButton();
            this.btn_fapiao = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_houseStatus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_stayPercent = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guest
            // 
            this.btn_guest.Image = ((System.Drawing.Image)(resources.GetObject("btn_guest.Image")));
            this.btn_guest.Location = new System.Drawing.Point(43, 218);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Size = new System.Drawing.Size(128, 57);
            this.btn_guest.TabIndex = 0;
            this.btn_guest.Text = "客人信息";
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // btn_jiezhang
            // 
            this.btn_jiezhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_jiezhang.Image")));
            this.btn_jiezhang.Location = new System.Drawing.Point(240, 39);
            this.btn_jiezhang.Name = "btn_jiezhang";
            this.btn_jiezhang.Size = new System.Drawing.Size(128, 57);
            this.btn_jiezhang.TabIndex = 1;
            this.btn_jiezhang.Text = "结账明细";
            this.btn_jiezhang.Click += new System.EventHandler(this.btn_jiezhang_Click);
            // 
            // btn_power
            // 
            this.btn_power.Image = ((System.Drawing.Image)(resources.GetObject("btn_power.Image")));
            this.btn_power.Location = new System.Drawing.Point(43, 126);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(128, 57);
            this.btn_power.TabIndex = 3;
            this.btn_power.Text = "水电费明细";
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Image = ((System.Drawing.Image)(resources.GetObject("btn_pay.Image")));
            this.btn_pay.Location = new System.Drawing.Point(425, 39);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(153, 57);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "房屋缴费明细";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 334);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.simpleButton1);
            this.tabPage1.Controls.Add(this.btn_yajing);
            this.tabPage1.Controls.Add(this.btn_fapiao);
            this.tabPage1.Controls.Add(this.btn_guest);
            this.tabPage1.Controls.Add(this.btn_pay);
            this.tabPage1.Controls.Add(this.btn_jiezhang);
            this.tabPage1.Controls.Add(this.btn_power);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "日常查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(43, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(128, 57);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "开单明细";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_yajing
            // 
            this.btn_yajing.Image = ((System.Drawing.Image)(resources.GetObject("btn_yajing.Image")));
            this.btn_yajing.Location = new System.Drawing.Point(425, 126);
            this.btn_yajing.Name = "btn_yajing";
            this.btn_yajing.Size = new System.Drawing.Size(128, 57);
            this.btn_yajing.TabIndex = 6;
            this.btn_yajing.Text = "押金查询";
            this.btn_yajing.Click += new System.EventHandler(this.btn_yajing_Click);
            // 
            // btn_fapiao
            // 
            this.btn_fapiao.Image = ((System.Drawing.Image)(resources.GetObject("btn_fapiao.Image")));
            this.btn_fapiao.Location = new System.Drawing.Point(240, 126);
            this.btn_fapiao.Name = "btn_fapiao";
            this.btn_fapiao.Size = new System.Drawing.Size(128, 57);
            this.btn_fapiao.TabIndex = 5;
            this.btn_fapiao.Text = "发票查询";
            this.btn_fapiao.Click += new System.EventHandler(this.btn_fapiao_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_houseStatus);
            this.tabPage2.Controls.Add(this.btn_stayPercent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "统计查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_houseStatus
            // 
            this.btn_houseStatus.Image = ((System.Drawing.Image)(resources.GetObject("btn_houseStatus.Image")));
            this.btn_houseStatus.Location = new System.Drawing.Point(46, 31);
            this.btn_houseStatus.Name = "btn_houseStatus";
            this.btn_houseStatus.Size = new System.Drawing.Size(145, 57);
            this.btn_houseStatus.TabIndex = 2;
            this.btn_houseStatus.Text = "房间总状态";
            this.btn_houseStatus.Click += new System.EventHandler(this.btn_houseStatus_Click);
            // 
            // btn_stayPercent
            // 
            this.btn_stayPercent.Image = ((System.Drawing.Image)(resources.GetObject("btn_stayPercent.Image")));
            this.btn_stayPercent.Location = new System.Drawing.Point(251, 31);
            this.btn_stayPercent.Name = "btn_stayPercent";
            this.btn_stayPercent.Size = new System.Drawing.Size(145, 57);
            this.btn_stayPercent.TabIndex = 1;
            this.btn_stayPercent.Text = "入住率统计";
            this.btn_stayPercent.Click += new System.EventHandler(this.btn_stayPercent_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.simpleButton5);
            this.tabPage3.Controls.Add(this.simpleButton4);
            this.tabPage3.Controls.Add(this.simpleButton3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(634, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "财务统计";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(441, 30);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(145, 57);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "年营业分析";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(243, 30);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(145, 57);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "月营业分析";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(41, 30);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(145, 57);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "日营业分析";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // tongjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 356);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tongjiForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "营业统计";
            this.Load += new System.EventHandler(this.tongjiForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_guest;
        private DevExpress.XtraEditors.SimpleButton btn_jiezhang;
        private DevExpress.XtraEditors.SimpleButton btn_power;
        private DevExpress.XtraEditors.SimpleButton btn_pay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.SimpleButton btn_stayPercent;
        private DevExpress.XtraEditors.SimpleButton btn_houseStatus;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_yajing;
        private DevExpress.XtraEditors.SimpleButton btn_fapiao;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}