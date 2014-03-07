namespace gzf
{
    partial class editPowerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editPowerForm));
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.txtPay = new System.Windows.Forms.NumericUpDown();
            this.txtMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPayMethod = new System.Windows.Forms.ComboBox();
            this.txtFapiao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "缴费金额：";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(106, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 27);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtPay
            // 
            this.txtPay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPay.Location = new System.Drawing.Point(130, 37);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(103, 21);
            this.txtPay.TabIndex = 27;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(130, 80);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(103, 21);
            this.txtMonth.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "缴费月数：";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(130, 123);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(103, 21);
            this.txtDay.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "缴费天数：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(130, 294);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker2.TabIndex = 56;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(59, 298);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 55;
            this.label23.Text = "结束时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(59, 255);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 53;
            this.label21.Text = "开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 57;
            this.label3.Text = "付款方式：";
            // 
            // comboBoxPayMethod
            // 
            this.comboBoxPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayMethod.FormattingEnabled = true;
            this.comboBoxPayMethod.Items.AddRange(new object[] {
            "现金",
            "信用卡",
            "其它方式"});
            this.comboBoxPayMethod.Location = new System.Drawing.Point(130, 166);
            this.comboBoxPayMethod.Name = "comboBoxPayMethod";
            this.comboBoxPayMethod.Size = new System.Drawing.Size(103, 20);
            this.comboBoxPayMethod.TabIndex = 67;
            // 
            // txtFapiao
            // 
            this.txtFapiao.Location = new System.Drawing.Point(130, 208);
            this.txtFapiao.Name = "txtFapiao";
            this.txtFapiao.Size = new System.Drawing.Size(103, 21);
            this.txtFapiao.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 68;
            this.label4.Text = "发票号码：";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(130, 340);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker3.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "缴费时间：";
            // 
            // editPowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 473);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFapiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPayMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "editPowerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑水电费";
            this.Load += new System.EventHandler(this.editPowerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.NumericUpDown txtPay;
        private System.Windows.Forms.NumericUpDown txtMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPayMethod;
        private System.Windows.Forms.TextBox txtFapiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
    }
}