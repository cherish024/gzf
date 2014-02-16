namespace gzf
{
    partial class xufeiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xufeiForm));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPayDay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPayMonth = new System.Windows.Forms.NumericUpDown();
            this.chkDay = new System.Windows.Forms.CheckBox();
            this.panelDay = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.payDay = new System.Windows.Forms.NumericUpDown();
            this.spinEditDay = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPayMonth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHouseTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataPayment = new System.Windows.Forms.DataGridView();
            this.btn_payadd = new System.Windows.Forms.Button();
            this.btn_paydel = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFapiao = new System.Windows.Forms.TextBox();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayMonth)).BeginInit();
            this.panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(277, 508);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(209, 513);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 51;
            this.label23.Text = "结束时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 509);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(30, 514);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 49;
            this.label21.Text = "开始时间：";
            // 
            // lblPayDay
            // 
            this.lblPayDay.AutoSize = true;
            this.lblPayDay.Location = new System.Drawing.Point(442, 363);
            this.lblPayDay.Name = "lblPayDay";
            this.lblPayDay.Size = new System.Drawing.Size(41, 12);
            this.lblPayDay.TabIndex = 48;
            this.lblPayDay.Text = "label4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(371, 363);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 47;
            this.label17.Text = "缴费天数：";
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.label4);
            this.panelMonth.Controls.Add(this.txtPay);
            this.panelMonth.Controls.Add(this.label11);
            this.panelMonth.Controls.Add(this.txtPayMonth);
            this.panelMonth.Location = new System.Drawing.Point(27, 405);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(340, 32);
            this.panelMonth.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "缴费月数：";
            // 
            // txtPay
            // 
            this.txtPay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtPay.Location = new System.Drawing.Point(245, 6);
            this.txtPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(85, 21);
            this.txtPay.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 39;
            this.label11.Text = "缴费金额：";
            // 
            // txtPayMonth
            // 
            this.txtPayMonth.Location = new System.Drawing.Point(68, 6);
            this.txtPayMonth.Name = "txtPayMonth";
            this.txtPayMonth.Size = new System.Drawing.Size(87, 21);
            this.txtPayMonth.TabIndex = 41;
            this.txtPayMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPayMonth.ValueChanged += new System.EventHandler(this.txtPayMonth_ValueChanged);
            // 
            // chkDay
            // 
            this.chkDay.AutoSize = true;
            this.chkDay.Location = new System.Drawing.Point(385, 415);
            this.chkDay.Name = "chkDay";
            this.chkDay.Size = new System.Drawing.Size(60, 16);
            this.chkDay.TabIndex = 45;
            this.chkDay.Text = "按天付";
            this.chkDay.UseVisualStyleBackColor = true;
            this.chkDay.CheckedChanged += new System.EventHandler(this.chkDay_CheckedChanged);
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.label20);
            this.panelDay.Controls.Add(this.payDay);
            this.panelDay.Controls.Add(this.spinEditDay);
            this.panelDay.Controls.Add(this.label19);
            this.panelDay.Enabled = false;
            this.panelDay.Location = new System.Drawing.Point(451, 405);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(301, 32);
            this.panelDay.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 24;
            this.label20.Text = "实收天租金：";
            // 
            // payDay
            // 
            this.payDay.Location = new System.Drawing.Point(222, 5);
            this.payDay.Name = "payDay";
            this.payDay.Size = new System.Drawing.Size(50, 21);
            this.payDay.TabIndex = 22;
            // 
            // spinEditDay
            // 
            this.spinEditDay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditDay.Location = new System.Drawing.Point(87, 5);
            this.spinEditDay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spinEditDay.Name = "spinEditDay";
            this.spinEditDay.Size = new System.Drawing.Size(102, 21);
            this.spinEditDay.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(278, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 23;
            this.label19.Text = "天";
            // 
            // lblPayMonth
            // 
            this.lblPayMonth.AutoSize = true;
            this.lblPayMonth.Location = new System.Drawing.Point(272, 363);
            this.lblPayMonth.Name = "lblPayMonth";
            this.lblPayMonth.Size = new System.Drawing.Size(41, 12);
            this.lblPayMonth.TabIndex = 43;
            this.lblPayMonth.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 42;
            this.label8.Text = "缴费月数：";
            // 
            // lblHouseTotal
            // 
            this.lblHouseTotal.AutoSize = true;
            this.lblHouseTotal.Location = new System.Drawing.Point(101, 363);
            this.lblHouseTotal.Name = "lblHouseTotal";
            this.lblHouseTotal.Size = new System.Drawing.Size(41, 12);
            this.lblHouseTotal.TabIndex = 30;
            this.lblHouseTotal.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "缴费总计：";
            // 
            // dataPayment
            // 
            this.dataPayment.AllowUserToAddRows = false;
            this.dataPayment.AllowUserToDeleteRows = false;
            this.dataPayment.BackgroundColor = System.Drawing.Color.White;
            this.dataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column6,
            this.Column9,
            this.Column12,
            this.Column10,
            this.Column8,
            this.Column14,
            this.Column15,
            this.Column1});
            this.dataPayment.Location = new System.Drawing.Point(32, 38);
            this.dataPayment.Name = "dataPayment";
            this.dataPayment.ReadOnly = true;
            this.dataPayment.RowHeadersVisible = false;
            this.dataPayment.RowTemplate.Height = 23;
            this.dataPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPayment.Size = new System.Drawing.Size(695, 308);
            this.dataPayment.TabIndex = 0;
            this.dataPayment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPayment_CellDoubleClick);
            this.dataPayment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPayment_CellFormatting);
            // 
            // btn_payadd
            // 
            this.btn_payadd.Location = new System.Drawing.Point(230, 575);
            this.btn_payadd.Name = "btn_payadd";
            this.btn_payadd.Size = new System.Drawing.Size(102, 35);
            this.btn_payadd.TabIndex = 31;
            this.btn_payadd.Text = "新增房费";
            this.btn_payadd.UseVisualStyleBackColor = true;
            this.btn_payadd.Click += new System.EventHandler(this.btn_payadd_Click);
            // 
            // btn_paydel
            // 
            this.btn_paydel.Location = new System.Drawing.Point(410, 575);
            this.btn_paydel.Name = "btn_paydel";
            this.btn_paydel.Size = new System.Drawing.Size(92, 35);
            this.btn_paydel.TabIndex = 33;
            this.btn_paydel.Text = "删除房费";
            this.btn_paydel.UseVisualStyleBackColor = true;
            this.btn_paydel.Click += new System.EventHandler(this.btn_paydel_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id";
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sn";
            this.Column6.HeaderText = "房间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "pay_month";
            this.Column9.HeaderText = "缴费月数";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "pay_day";
            this.Column12.HeaderText = "缴费天数";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "pay";
            this.Column10.HeaderText = "缴费金额";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "addtime";
            this.Column8.HeaderText = "缴费时间";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "start_time";
            this.Column14.HeaderText = "开始时间";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 90;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "end_time";
            this.Column15.HeaderText = "结束时间";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 90;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fapiao";
            this.Column1.HeaderText = "发票号码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "发票号码：";
            // 
            // txtFapiao
            // 
            this.txtFapiao.Location = new System.Drawing.Point(98, 461);
            this.txtFapiao.Name = "txtFapiao";
            this.txtFapiao.Size = new System.Drawing.Size(132, 21);
            this.txtFapiao.TabIndex = 54;
            // 
            // xufeiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 645);
            this.Controls.Add(this.txtFapiao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dataPayment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_paydel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn_payadd);
            this.Controls.Add(this.lblPayDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblHouseTotal);
            this.Controls.Add(this.panelMonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkDay);
            this.Controls.Add(this.lblPayMonth);
            this.Controls.Add(this.panelDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xufeiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "续费";
            this.Load += new System.EventHandler(this.xufeiForm_Load);
            this.panelMonth.ResumeLayout(false);
            this.panelMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayMonth)).EndInit();
            this.panelDay.ResumeLayout(false);
            this.panelDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPayDay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtPayMonth;
        private System.Windows.Forms.CheckBox chkDay;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown payDay;
        private System.Windows.Forms.NumericUpDown spinEditDay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPayMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHouseTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataPayment;
        private System.Windows.Forms.Button btn_payadd;
        private System.Windows.Forms.Button btn_paydel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFapiao;
    }
}