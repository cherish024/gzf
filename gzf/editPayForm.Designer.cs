namespace gzf
{
    partial class editPayForm
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayMonth = new System.Windows.Forms.NumericUpDown();
            this.txtDay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFapiao = new System.Windows.Forms.TextBox();
            this.spinEditOther = new System.Windows.Forms.NumericUpDown();
            this.spinEditCride = new System.Windows.Forms.NumericUpDown();
            this.spinEditCash = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCash)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(123, 451);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(93, 33);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "保存";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtPay
            // 
            this.txtPay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtPay.Location = new System.Drawing.Point(150, 131);
            this.txtPay.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(120, 21);
            this.txtPay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "缴费月份：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "缴费金额：";
            // 
            // txtPayMonth
            // 
            this.txtPayMonth.Location = new System.Drawing.Point(150, 46);
            this.txtPayMonth.Name = "txtPayMonth";
            this.txtPayMonth.Size = new System.Drawing.Size(120, 21);
            this.txtPayMonth.TabIndex = 7;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(150, 89);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(120, 21);
            this.txtDay.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "缴费天数：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 349);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker2.TabIndex = 60;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(56, 355);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 59;
            this.label23.Text = "结束时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 308);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 314);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 57;
            this.label21.Text = "开始时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "发票号码：";
            // 
            // txtFapiao
            // 
            this.txtFapiao.Location = new System.Drawing.Point(143, 270);
            this.txtFapiao.Name = "txtFapiao";
            this.txtFapiao.Size = new System.Drawing.Size(120, 21);
            this.txtFapiao.TabIndex = 62;
            // 
            // spinEditOther
            // 
            this.spinEditOther.Location = new System.Drawing.Point(276, 222);
            this.spinEditOther.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.spinEditOther.Name = "spinEditOther";
            this.spinEditOther.Size = new System.Drawing.Size(65, 21);
            this.spinEditOther.TabIndex = 114;
            // 
            // spinEditCride
            // 
            this.spinEditCride.Location = new System.Drawing.Point(167, 222);
            this.spinEditCride.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.spinEditCride.Name = "spinEditCride";
            this.spinEditCride.Size = new System.Drawing.Size(65, 21);
            this.spinEditCride.TabIndex = 113;
            // 
            // spinEditCash
            // 
            this.spinEditCash.Location = new System.Drawing.Point(44, 222);
            this.spinEditCash.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.spinEditCash.Name = "spinEditCash";
            this.spinEditCash.Size = new System.Drawing.Size(65, 21);
            this.spinEditCash.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 115;
            this.label5.Text = "现金";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 116;
            this.label6.Text = "信用卡";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 117;
            this.label7.Text = "其他";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 118;
            this.label8.Text = "原支付方式：";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(150, 178);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(0, 12);
            this.lblMethod.TabIndex = 119;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(143, 393);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(103, 21);
            this.dateTimePicker3.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 120;
            this.label9.Text = "缴费时间：";
            // 
            // editPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 511);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spinEditOther);
            this.Controls.Add(this.spinEditCride);
            this.Controls.Add(this.spinEditCash);
            this.Controls.Add(this.txtFapiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.btn_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "editPayForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑房费";
            this.Load += new System.EventHandler(this.editPayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.NumericUpDown txtPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPayMonth;
        private System.Windows.Forms.NumericUpDown txtDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFapiao;
        private System.Windows.Forms.NumericUpDown spinEditOther;
        private System.Windows.Forms.NumericUpDown spinEditCride;
        private System.Windows.Forms.NumericUpDown spinEditCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
    }
}