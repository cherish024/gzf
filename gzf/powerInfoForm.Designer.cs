namespace gzf
{
    partial class powerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(powerInfoForm));
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDian = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_powerAdd = new System.Windows.Forms.Button();
            this.btn_powerDel = new System.Windows.Forms.Button();
            this.dataPower = new System.Windows.Forms.DataGridView();
            this.txtHot = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCool = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtDian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCool)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(101, 360);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker3.TabIndex = 65;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(215, 364);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 64;
            this.label25.Text = "缴费结束：";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(279, 360);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker4.TabIndex = 63;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(36, 365);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 62;
            this.label26.Text = "缴费开始：";
            // 
            // txtDian
            // 
            this.txtDian.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDian.Location = new System.Drawing.Point(459, 326);
            this.txtDian.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtDian.Name = "txtDian";
            this.txtDian.Size = new System.Drawing.Size(85, 21);
            this.txtDian.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 48;
            this.label12.Text = "电费：";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 446);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 12);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "水电费总计：";
            // 
            // btn_powerAdd
            // 
            this.btn_powerAdd.Location = new System.Drawing.Point(585, 343);
            this.btn_powerAdd.Name = "btn_powerAdd";
            this.btn_powerAdd.Size = new System.Drawing.Size(83, 53);
            this.btn_powerAdd.TabIndex = 40;
            this.btn_powerAdd.Text = "新增水电费";
            this.btn_powerAdd.UseVisualStyleBackColor = true;
            this.btn_powerAdd.Click += new System.EventHandler(this.btn_powerAdd_Click);
            // 
            // btn_powerDel
            // 
            this.btn_powerDel.Location = new System.Drawing.Point(679, 343);
            this.btn_powerDel.Name = "btn_powerDel";
            this.btn_powerDel.Size = new System.Drawing.Size(83, 53);
            this.btn_powerDel.TabIndex = 42;
            this.btn_powerDel.Text = "删除水电费";
            this.btn_powerDel.UseVisualStyleBackColor = true;
            this.btn_powerDel.Click += new System.EventHandler(this.btn_powerDel_Click);
            // 
            // dataPower
            // 
            this.dataPower.AllowUserToAddRows = false;
            this.dataPower.AllowUserToDeleteRows = false;
            this.dataPower.BackgroundColor = System.Drawing.Color.White;
            this.dataPower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column5,
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column16,
            this.Column17,
            this.Column6});
            this.dataPower.Location = new System.Drawing.Point(38, 21);
            this.dataPower.MultiSelect = false;
            this.dataPower.Name = "dataPower";
            this.dataPower.ReadOnly = true;
            this.dataPower.RowHeadersVisible = false;
            this.dataPower.RowTemplate.Height = 23;
            this.dataPower.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataPower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPower.Size = new System.Drawing.Size(743, 281);
            this.dataPower.TabIndex = 18;
            this.dataPower.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPower_CellDoubleClick);
            this.dataPower.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPower_CellFormatting);
            this.dataPower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPower_CellContentClick);
            // 
            // txtHot
            // 
            this.txtHot.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtHot.Location = new System.Drawing.Point(459, 361);
            this.txtHot.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtHot.Name = "txtHot";
            this.txtHot.Size = new System.Drawing.Size(85, 21);
            this.txtHot.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 67;
            this.label1.Text = "热水费：";
            // 
            // txtCool
            // 
            this.txtCool.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCool.Location = new System.Drawing.Point(459, 395);
            this.txtCool.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCool.Name = "txtCool";
            this.txtCool.Size = new System.Drawing.Size(85, 21);
            this.txtCool.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 69;
            this.label2.Text = "冷水费：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker1.TabIndex = 73;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 72;
            this.label3.Text = "缴费结束：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(279, 326);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker2.TabIndex = 71;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 70;
            this.label4.Text = "缴费开始：";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(101, 394);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker5.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "缴费结束：";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(279, 394);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker6.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 74;
            this.label6.Text = "缴费开始：";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "id";
            this.Column11.HeaderText = "ID";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            this.Column11.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sn";
            this.Column5.HeaderText = "房间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "type";
            this.Column1.HeaderText = "类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "price";
            this.Column4.HeaderText = "缴费金额";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "addtime";
            this.Column3.HeaderText = "缴费时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "start_time";
            this.Column16.HeaderText = "结算开始时间";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 110;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "end_time";
            this.Column17.HeaderText = "结算结束时间";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "确认费用";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Text = "确认费用";
            this.Column6.Width = 80;
            // 
            // powerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 497);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.txtDian);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dataPower);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.btn_powerDel);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btn_powerAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "powerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "水电费明细";
            this.Load += new System.EventHandler(this.powerInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown txtDian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_powerAdd;
        private System.Windows.Forms.Button btn_powerDel;
        private System.Windows.Forms.DataGridView dataPower;
        private System.Windows.Forms.NumericUpDown txtHot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}