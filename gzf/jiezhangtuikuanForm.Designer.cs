namespace gzf
{
    partial class jiezhangtuikuanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jiezhangtuikuanForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_jz = new System.Windows.Forms.Button();
            this.lbl_yj = new System.Windows.Forms.Label();
            this.lblShui = new System.Windows.Forms.Label();
            this.lblDian = new System.Windows.Forms.Label();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.lblHot = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "押金退：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "房费退：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 10F);
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(169, 81);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "冷水费：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(50, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "电费：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("宋体", 9F);
            this.panel1.Location = new System.Drawing.Point(53, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 64);
            this.panel1.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(218, 25);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(77, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "总计退款：";
            // 
            // btn_jz
            // 
            this.btn_jz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_jz.ForeColor = System.Drawing.Color.Red;
            this.btn_jz.Location = new System.Drawing.Point(95, 483);
            this.btn_jz.Name = "btn_jz";
            this.btn_jz.Size = new System.Drawing.Size(280, 48);
            this.btn_jz.TabIndex = 6;
            this.btn_jz.Text = "确认结账";
            this.btn_jz.UseVisualStyleBackColor = true;
            this.btn_jz.Click += new System.EventHandler(this.btn_jz_Click);
            // 
            // lbl_yj
            // 
            this.lbl_yj.AutoSize = true;
            this.lbl_yj.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_yj.Location = new System.Drawing.Point(165, 40);
            this.lbl_yj.Name = "lbl_yj";
            this.lbl_yj.Size = new System.Drawing.Size(14, 14);
            this.lbl_yj.TabIndex = 7;
            this.lbl_yj.Text = "0";
            // 
            // lblShui
            // 
            this.lblShui.AutoSize = true;
            this.lblShui.Font = new System.Drawing.Font("宋体", 10F);
            this.lblShui.Location = new System.Drawing.Point(166, 132);
            this.lblShui.Name = "lblShui";
            this.lblShui.Size = new System.Drawing.Size(14, 14);
            this.lblShui.TabIndex = 8;
            this.lblShui.Text = "0";
            // 
            // lblDian
            // 
            this.lblDian.AutoSize = true;
            this.lblDian.Font = new System.Drawing.Font("宋体", 10F);
            this.lblDian.Location = new System.Drawing.Point(165, 178);
            this.lblDian.Name = "lblDian";
            this.lblDian.Size = new System.Drawing.Size(14, 14);
            this.lblDian.TabIndex = 9;
            this.lblDian.Text = "0";
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Checked = true;
            this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrint.Location = new System.Drawing.Point(53, 375);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(96, 16);
            this.chkPrint.TabIndex = 35;
            this.chkPrint.Text = "打印说明文字";
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(163, 364);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(131, 36);
            this.btn_print.TabIndex = 34;
            this.btn_print.Text = "打印退房凭证";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lblHot
            // 
            this.lblHot.AutoSize = true;
            this.lblHot.Font = new System.Drawing.Font("宋体", 10F);
            this.lblHot.Location = new System.Drawing.Point(395, 132);
            this.lblHot.Name = "lblHot";
            this.lblHot.Size = new System.Drawing.Size(14, 14);
            this.lblHot.TabIndex = 37;
            this.lblHot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F);
            this.label7.Location = new System.Drawing.Point(279, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 36;
            this.label7.Text = "热水费：";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Font = new System.Drawing.Font("宋体", 10F);
            this.lblGas.Location = new System.Drawing.Point(395, 178);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(14, 14);
            this.lblGas.TabIndex = 39;
            this.lblGas.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10F);
            this.label9.Location = new System.Drawing.Point(279, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 38;
            this.label9.Text = "煤气费：";
            // 
            // lblTv
            // 
            this.lblTv.AutoSize = true;
            this.lblTv.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTv.Location = new System.Drawing.Point(165, 226);
            this.lblTv.Name = "lblTv";
            this.lblTv.Size = new System.Drawing.Size(14, 14);
            this.lblTv.TabIndex = 41;
            this.lblTv.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10F);
            this.label11.Location = new System.Drawing.Point(49, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 40;
            this.label11.Text = "电视费：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 42;
            this.button1.Text = "退款支付凭证";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jiezhangtuikuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lblDian);
            this.Controls.Add(this.lblShui);
            this.Controls.Add(this.lbl_yj);
            this.Controls.Add(this.btn_jz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "jiezhangtuikuanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结账确认";
            this.Load += new System.EventHandler(this.jiezhangtuikuanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_jz;
        private System.Windows.Forms.Label lbl_yj;
        private System.Windows.Forms.Label lblShui;
        private System.Windows.Forms.Label lblDian;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lblHot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}