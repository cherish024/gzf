namespace gzf
{
    partial class tongjiYearForm
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
            dotnetCHARTING.WinForms.Label label1 = new dotnetCHARTING.WinForms.Label();
            dotnetCHARTING.WinForms.Label label9 = new dotnetCHARTING.WinForms.Label();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tongjiYearForm));
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.chart2 = new dotnetCHARTING.WinForms.Chart();
            this.chart1 = new dotnetCHARTING.WinForms.Chart();
            this.groupBoxClose = new System.Windows.Forms.GroupBox();
            this.groupBoxOpen = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKechuzu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStayCount = new System.Windows.Forms.Label();
            this.lblZDCount = new System.Windows.Forms.Label();
            this.lblHouseCount = new System.Windows.Forms.Label();
            this.lblOpenCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboBoxYear.Location = new System.Drawing.Point(85, 36);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(60, 20);
            this.comboBoxYear.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(25, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "选择年份：";
            // 
            // btn_search
            // 
            this.btn_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_search.Location = new System.Drawing.Point(194, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chart2
            // 
            this.chart2.Background.Color = System.Drawing.Color.White;
            this.chart2.ChartArea.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.chart2.ChartArea.CornerTopLeft = dotnetCHARTING.WinForms.BoxCorner.Square;
            this.chart2.ChartArea.DefaultElement.DefaultSubValue.Line.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.chart2.ChartArea.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart2.ChartArea.InteriorLine.Color = System.Drawing.Color.LightGray;
            this.chart2.ChartArea.Label.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chart2.ChartArea.LegendBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart2.ChartArea.LegendBox.CornerBottomRight = dotnetCHARTING.WinForms.BoxCorner.Cut;
            this.chart2.ChartArea.LegendBox.DefaultEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart2.ChartArea.LegendBox.HeaderEntry.DividerLine.Color = System.Drawing.Color.Gray;
            this.chart2.ChartArea.LegendBox.HeaderEntry.Name = "Name";
            this.chart2.ChartArea.LegendBox.HeaderEntry.SortOrder = -1;
            this.chart2.ChartArea.LegendBox.HeaderEntry.Value = "Value";
            this.chart2.ChartArea.LegendBox.HeaderEntry.Visible = false;
            this.chart2.ChartArea.LegendBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart2.ChartArea.LegendBox.Line.Color = System.Drawing.Color.Gray;
            this.chart2.ChartArea.LegendBox.Padding = 4;
            this.chart2.ChartArea.LegendBox.Position = dotnetCHARTING.WinForms.LegendBoxPosition.Top;
            this.chart2.ChartArea.LegendBox.Visible = true;
            this.chart2.ChartArea.Line.Color = System.Drawing.Color.Gray;
            this.chart2.ChartArea.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart2.ChartArea.Title = "退房类型比例";
            this.chart2.ChartArea.TitleBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart2.ChartArea.TitleBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart2.ChartArea.TitleBox.Label.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(45)))), ((int)(((byte)(38)))));
            this.chart2.ChartArea.TitleBox.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chart2.ChartArea.TitleBox.Label.Text = "退房类型比例";
            this.chart2.ChartArea.TitleBox.Line.Color = System.Drawing.Color.Gray;
            this.chart2.ChartArea.TitleBox.Visible = true;
            this.chart2.ChartArea.XAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart2.ChartArea.XAxis.DefaultTick.Line.Length = 3;
            this.chart2.ChartArea.XAxis.MinorTimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart2.ChartArea.XAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart2.ChartArea.XAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart2.ChartArea.XAxis.ZeroTick.Line.Length = 3;
            this.chart2.ChartArea.YAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart2.ChartArea.YAxis.DefaultTick.Line.Length = 3;
            this.chart2.ChartArea.YAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart2.ChartArea.YAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart2.ChartArea.YAxis.ZeroTick.Line.Length = 3;
            this.chart2.DataGrid = null;
            this.chart2.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart2.DefaultElement.ShowValue = true;
            this.chart2.LabelChart = label1;
            this.chart2.Location = new System.Drawing.Point(589, 362);
            this.chart2.Name = "chart2";
            this.chart2.NoDataLabel.Text = "No Data";
            this.chart2.Size = new System.Drawing.Size(523, 341);
            this.chart2.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart2.StartDayOfWeek = System.DayOfWeek.Monday;
            this.chart2.TabIndex = 29;
            this.chart2.TempDirectory = "C:\\Users\\Cherish\\AppData\\Local\\Temp\\";
            this.chart2.Title = "退房类型比例";
            this.chart2.Type = dotnetCHARTING.WinForms.ChartType.Pie;
            // 
            // chart1
            // 
            this.chart1.Background.Color = System.Drawing.Color.White;
            this.chart1.ChartArea.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.chart1.ChartArea.CornerTopLeft = dotnetCHARTING.WinForms.BoxCorner.Square;
            this.chart1.ChartArea.DefaultElement.DefaultSubValue.Line.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.chart1.ChartArea.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.InteriorLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.Label.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chart1.ChartArea.LegendBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart1.ChartArea.LegendBox.CornerBottomRight = dotnetCHARTING.WinForms.BoxCorner.Cut;
            this.chart1.ChartArea.LegendBox.DefaultEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.ChartArea.LegendBox.HeaderEntry.DividerLine.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.LegendBox.HeaderEntry.Name = "Name";
            this.chart1.ChartArea.LegendBox.HeaderEntry.SortOrder = -1;
            this.chart1.ChartArea.LegendBox.HeaderEntry.Value = "Value";
            this.chart1.ChartArea.LegendBox.HeaderEntry.Visible = false;
            this.chart1.ChartArea.LegendBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartArea.LegendBox.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.LegendBox.Padding = 4;
            this.chart1.ChartArea.LegendBox.Position = dotnetCHARTING.WinForms.LegendBoxPosition.Top;
            this.chart1.ChartArea.LegendBox.Visible = true;
            this.chart1.ChartArea.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.Title = "开房类型比例";
            this.chart1.ChartArea.TitleBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart1.ChartArea.TitleBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartArea.TitleBox.Label.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(45)))), ((int)(((byte)(38)))));
            this.chart1.ChartArea.TitleBox.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chart1.ChartArea.TitleBox.Label.Text = "开房类型比例";
            this.chart1.ChartArea.TitleBox.Line.Color = System.Drawing.Color.Gray;
            this.chart1.ChartArea.TitleBox.Visible = true;
            this.chart1.ChartArea.XAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.XAxis.DefaultTick.Line.Length = 3;
            this.chart1.ChartArea.XAxis.MinorTimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.XAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.XAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart1.ChartArea.XAxis.ZeroTick.Line.Length = 3;
            this.chart1.ChartArea.YAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart1.ChartArea.YAxis.DefaultTick.Line.Length = 3;
            this.chart1.ChartArea.YAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart1.ChartArea.YAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart1.ChartArea.YAxis.ZeroTick.Line.Length = 3;
            this.chart1.DataGrid = null;
            this.chart1.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart1.DefaultElement.ShowValue = true;
            this.chart1.LabelChart = label9;
            this.chart1.Location = new System.Drawing.Point(27, 362);
            this.chart1.Name = "chart1";
            this.chart1.NoDataLabel.Text = "No Data";
            this.chart1.Size = new System.Drawing.Size(521, 341);
            this.chart1.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.TabIndex = 28;
            this.chart1.TempDirectory = "C:\\Users\\Cherish\\AppData\\Local\\Temp\\";
            this.chart1.Title = "开房类型比例";
            this.chart1.Type = dotnetCHARTING.WinForms.ChartType.Pie;
            // 
            // groupBoxClose
            // 
            this.groupBoxClose.Location = new System.Drawing.Point(589, 210);
            this.groupBoxClose.Name = "groupBoxClose";
            this.groupBoxClose.Size = new System.Drawing.Size(523, 99);
            this.groupBoxClose.TabIndex = 27;
            this.groupBoxClose.TabStop = false;
            this.groupBoxClose.Text = "退房类型统计";
            // 
            // groupBoxOpen
            // 
            this.groupBoxOpen.Location = new System.Drawing.Point(589, 99);
            this.groupBoxOpen.Name = "groupBoxOpen";
            this.groupBoxOpen.Size = new System.Drawing.Size(523, 91);
            this.groupBoxOpen.TabIndex = 26;
            this.groupBoxOpen.TabStop = false;
            this.groupBoxOpen.Text = "开房类型统计";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPeople);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(284, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 95);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "园区人数统计";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Location = new System.Drawing.Point(109, 49);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(11, 12);
            this.lblPeople.TabIndex = 19;
            this.lblPeople.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "总入住人数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(27, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 95);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "收费统计";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(104, 49);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 12);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "总收金额：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKechuzu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.lblStayCount);
            this.groupBox1.Controls.Add(this.lblZDCount);
            this.groupBox1.Controls.Add(this.lblHouseCount);
            this.groupBox1.Controls.Add(this.lblOpenCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 116);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房屋统计";
            // 
            // lblKechuzu
            // 
            this.lblKechuzu.AutoSize = true;
            this.lblKechuzu.Location = new System.Drawing.Point(101, 79);
            this.lblKechuzu.Name = "lblKechuzu";
            this.lblKechuzu.Size = new System.Drawing.Size(11, 12);
            this.lblKechuzu.TabIndex = 13;
            this.lblKechuzu.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "可出租数量：";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(381, 36);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(11, 12);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "0";
            // 
            // lblStayCount
            // 
            this.lblStayCount.AutoSize = true;
            this.lblStayCount.Location = new System.Drawing.Point(242, 36);
            this.lblStayCount.Name = "lblStayCount";
            this.lblStayCount.Size = new System.Drawing.Size(11, 12);
            this.lblStayCount.TabIndex = 10;
            this.lblStayCount.Text = "0";
            // 
            // lblZDCount
            // 
            this.lblZDCount.AutoSize = true;
            this.lblZDCount.Location = new System.Drawing.Point(381, 79);
            this.lblZDCount.Name = "lblZDCount";
            this.lblZDCount.Size = new System.Drawing.Size(11, 12);
            this.lblZDCount.TabIndex = 9;
            this.lblZDCount.Text = "0";
            // 
            // lblHouseCount
            // 
            this.lblHouseCount.AutoSize = true;
            this.lblHouseCount.Location = new System.Drawing.Point(89, 36);
            this.lblHouseCount.Name = "lblHouseCount";
            this.lblHouseCount.Size = new System.Drawing.Size(11, 12);
            this.lblHouseCount.TabIndex = 8;
            this.lblHouseCount.Text = "0";
            // 
            // lblOpenCount
            // 
            this.lblOpenCount.AutoSize = true;
            this.lblOpenCount.Location = new System.Drawing.Point(240, 79);
            this.lblOpenCount.Name = "lblOpenCount";
            this.lblOpenCount.Size = new System.Drawing.Size(11, 12);
            this.lblOpenCount.TabIndex = 7;
            this.lblOpenCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开房数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "入住比例：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "退房数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "入住数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "房间数量：";
            // 
            // tongjiYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBoxClose);
            this.Controls.Add(this.groupBoxOpen);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tongjiYearForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年营业统计";
            this.Load += new System.EventHandler(this.YingyeYearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_search;
        private dotnetCHARTING.WinForms.Chart chart2;
        private dotnetCHARTING.WinForms.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxClose;
        private System.Windows.Forms.GroupBox groupBoxOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKechuzu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblStayCount;
        private System.Windows.Forms.Label lblZDCount;
        private System.Windows.Forms.Label lblHouseCount;
        private System.Windows.Forms.Label lblOpenCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}