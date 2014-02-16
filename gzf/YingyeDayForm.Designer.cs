namespace gzf
{
    partial class YingyeDayForm
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
            dotnetCHARTING.WinForms.Label label12 = new dotnetCHARTING.WinForms.Label();
            dotnetCHARTING.WinForms.Label label18 = new dotnetCHARTING.WinForms.Label();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YingyeDayForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStayCount = new System.Windows.Forms.Label();
            this.lblZDCount = new System.Windows.Forms.Label();
            this.lblHouseCount = new System.Windows.Forms.Label();
            this.lblOpenCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMeiqi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbltv = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHotwater = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblYaJing = new System.Windows.Forms.Label();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblDian = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.groupBoxOpen = new System.Windows.Forms.GroupBox();
            this.groupBoxClose = new System.Windows.Forms.GroupBox();
            this.chart1 = new dotnetCHARTING.WinForms.Chart();
            this.chart2 = new dotnetCHARTING.WinForms.Chart();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开房数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "退房数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "房间数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "入住数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "入住比例：";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(591, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房屋统计";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(1079, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(35, 37);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(381, 70);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(11, 12);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "0";
            // 
            // lblStayCount
            // 
            this.lblStayCount.AutoSize = true;
            this.lblStayCount.Location = new System.Drawing.Point(242, 70);
            this.lblStayCount.Name = "lblStayCount";
            this.lblStayCount.Size = new System.Drawing.Size(11, 12);
            this.lblStayCount.TabIndex = 10;
            this.lblStayCount.Text = "0";
            // 
            // lblZDCount
            // 
            this.lblZDCount.AutoSize = true;
            this.lblZDCount.Location = new System.Drawing.Point(89, 70);
            this.lblZDCount.Name = "lblZDCount";
            this.lblZDCount.Size = new System.Drawing.Size(11, 12);
            this.lblZDCount.TabIndex = 9;
            this.lblZDCount.Text = "0";
            // 
            // lblHouseCount
            // 
            this.lblHouseCount.AutoSize = true;
            this.lblHouseCount.Location = new System.Drawing.Point(240, 39);
            this.lblHouseCount.Name = "lblHouseCount";
            this.lblHouseCount.Size = new System.Drawing.Size(11, 12);
            this.lblHouseCount.TabIndex = 8;
            this.lblHouseCount.Text = "0";
            // 
            // lblOpenCount
            // 
            this.lblOpenCount.AutoSize = true;
            this.lblOpenCount.Location = new System.Drawing.Point(89, 39);
            this.lblOpenCount.Name = "lblOpenCount";
            this.lblOpenCount.Size = new System.Drawing.Size(11, 12);
            this.lblOpenCount.TabIndex = 7;
            this.lblOpenCount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKey);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblDoor);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblMeiqi);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbltv);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblHotwater);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblYaJing);
            this.groupBox2.Controls.Add(this.lblHousePrice);
            this.groupBox2.Controls.Add(this.lblDian);
            this.groupBox2.Controls.Add(this.lblWater);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(40, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 147);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "收费统计";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(333, 76);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(11, 12);
            this.lblKey.TabIndex = 27;
            this.lblKey.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(269, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 26;
            this.label17.Text = "缴纳钥匙：";
            // 
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Location = new System.Drawing.Point(216, 76);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(11, 12);
            this.lblDoor.TabIndex = 25;
            this.lblDoor.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 24;
            this.label16.Text = "缴纳门禁卡：";
            // 
            // lblMeiqi
            // 
            this.lblMeiqi.AutoSize = true;
            this.lblMeiqi.Location = new System.Drawing.Point(100, 76);
            this.lblMeiqi.Name = "lblMeiqi";
            this.lblMeiqi.Size = new System.Drawing.Size(11, 12);
            this.lblMeiqi.TabIndex = 23;
            this.lblMeiqi.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "缴纳煤气费：";
            // 
            // lbltv
            // 
            this.lbltv.AutoSize = true;
            this.lbltv.Location = new System.Drawing.Point(457, 43);
            this.lbltv.Name = "lbltv";
            this.lbltv.Size = new System.Drawing.Size(11, 12);
            this.lbltv.TabIndex = 21;
            this.lbltv.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "缴纳电视费：";
            // 
            // lblHotwater
            // 
            this.lblHotwater.AutoSize = true;
            this.lblHotwater.Location = new System.Drawing.Point(216, 43);
            this.lblHotwater.Name = "lblHotwater";
            this.lblHotwater.Size = new System.Drawing.Size(11, 12);
            this.lblHotwater.TabIndex = 17;
            this.lblHotwater.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(207, 114);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 12);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "缴纳热水费：";
            // 
            // lblYaJing
            // 
            this.lblYaJing.AutoSize = true;
            this.lblYaJing.Location = new System.Drawing.Point(91, 114);
            this.lblYaJing.Name = "lblYaJing";
            this.lblYaJing.Size = new System.Drawing.Size(11, 12);
            this.lblYaJing.TabIndex = 18;
            this.lblYaJing.Text = "0";
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Location = new System.Drawing.Point(450, 76);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(11, 12);
            this.lblHousePrice.TabIndex = 17;
            this.lblHousePrice.Text = "0";
            // 
            // lblDian
            // 
            this.lblDian.AutoSize = true;
            this.lblDian.Location = new System.Drawing.Point(332, 43);
            this.lblDian.Name = "lblDian";
            this.lblDian.Size = new System.Drawing.Size(11, 12);
            this.lblDian.TabIndex = 16;
            this.lblDian.Text = "0";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(100, 43);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(11, 12);
            this.lblWater.TabIndex = 15;
            this.lblWater.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "总收金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "缴纳押金：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "缴纳房费：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "缴纳电费：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "缴纳冷水费：";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(252, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(347, 31);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(87, 23);
            this.btn_excel.TabIndex = 15;
            this.btn_excel.Text = "导出Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // groupBoxOpen
            // 
            this.groupBoxOpen.Location = new System.Drawing.Point(40, 251);
            this.groupBoxOpen.Name = "groupBoxOpen";
            this.groupBoxOpen.Size = new System.Drawing.Size(523, 91);
            this.groupBoxOpen.TabIndex = 16;
            this.groupBoxOpen.TabStop = false;
            this.groupBoxOpen.Text = "开房类型统计";
            // 
            // groupBoxClose
            // 
            this.groupBoxClose.Location = new System.Drawing.Point(40, 380);
            this.groupBoxClose.Name = "groupBoxClose";
            this.groupBoxClose.Size = new System.Drawing.Size(523, 99);
            this.groupBoxClose.TabIndex = 17;
            this.groupBoxClose.TabStop = false;
            this.groupBoxClose.Text = "退房类型统计";
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
            this.chart1.LabelChart = label12;
            this.chart1.Location = new System.Drawing.Point(591, 251);
            this.chart1.Name = "chart1";
            this.chart1.NoDataLabel.Text = "No Data";
            this.chart1.Size = new System.Drawing.Size(293, 228);
            this.chart1.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart1.TabIndex = 18;
            this.chart1.TempDirectory = "C:\\Users\\Cherish\\AppData\\Local\\Temp\\";
            this.chart1.Title = "开房类型比例";
            this.chart1.Type = dotnetCHARTING.WinForms.ChartType.Pie;
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
            this.chart2.LabelChart = label18;
            this.chart2.Location = new System.Drawing.Point(901, 251);
            this.chart2.Name = "chart2";
            this.chart2.NoDataLabel.Text = "No Data";
            this.chart2.Size = new System.Drawing.Size(290, 228);
            this.chart2.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart2.StartDayOfWeek = System.DayOfWeek.Monday;
            this.chart2.TabIndex = 19;
            this.chart2.TempDirectory = "C:\\Users\\Cherish\\AppData\\Local\\Temp\\";
            this.chart2.Title = "退房类型比例";
            this.chart2.Type = dotnetCHARTING.WinForms.ChartType.Pie;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "类型";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "金额";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "现金";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "信用卡";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "其他";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // YingyeDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBoxClose);
            this.Controls.Add(this.groupBoxOpen);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YingyeDayForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日营业统计";
            this.Load += new System.EventHandler(this.YingyeDayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblStayCount;
        private System.Windows.Forms.Label lblZDCount;
        private System.Windows.Forms.Label lblHouseCount;
        private System.Windows.Forms.Label lblOpenCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblYaJing;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblDian;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHotwater;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMeiqi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBoxOpen;
        private System.Windows.Forms.GroupBox groupBoxClose;
        private dotnetCHARTING.WinForms.Chart chart1;
        private dotnetCHARTING.WinForms.Chart chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}