namespace gzf
{
    partial class editHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editHouseForm));
            this.txtSn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFloor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numSort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.leftpos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxKitchen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftpos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSn
            // 
            this.txtSn.Location = new System.Drawing.Point(109, 96);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(100, 21);
            this.txtSn.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "房屋编号：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(317, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "租金：";
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFloor.FormattingEnabled = true;
            this.comboBoxFloor.Location = new System.Drawing.Point(317, 46);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(100, 20);
            this.comboBoxFloor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "楼层：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "所属建筑：";
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.DisplayMember = "name";
            this.comboBoxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Location = new System.Drawing.Point(108, 45);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(101, 20);
            this.comboBoxBuilding.TabIndex = 12;
            this.comboBoxBuilding.ValueMember = "id";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(272, 332);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 32);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(134, 332);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 32);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "朝向：";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "南",
            "北"});
            this.comboBoxPosition.Location = new System.Drawing.Point(109, 147);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.comboBoxPosition.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "排序：";
            // 
            // numSort
            // 
            this.numSort.Location = new System.Drawing.Point(317, 146);
            this.numSort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSort.Name = "numSort";
            this.numSort.Size = new System.Drawing.Size(100, 21);
            this.numSort.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "几人间：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "二人间",
            "四人间"});
            this.comboBox1.Location = new System.Drawing.Point(109, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // leftpos
            // 
            this.leftpos.Location = new System.Drawing.Point(317, 202);
            this.leftpos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.leftpos.Name = "leftpos";
            this.leftpos.Size = new System.Drawing.Size(100, 21);
            this.leftpos.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "左边空几格：";
            // 
            // comboBoxKitchen
            // 
            this.comboBoxKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKitchen.FormattingEnabled = true;
            this.comboBoxKitchen.Items.AddRange(new object[] {
            "否",
            "是"});
            this.comboBoxKitchen.Location = new System.Drawing.Point(108, 258);
            this.comboBoxKitchen.Name = "comboBoxKitchen";
            this.comboBoxKitchen.Size = new System.Drawing.Size(100, 20);
            this.comboBoxKitchen.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "靠近厨房：";
            // 
            // editHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 413);
            this.Controls.Add(this.comboBoxKitchen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.leftpos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBuilding);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "editHouseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑房屋";
            this.Load += new System.EventHandler(this.editHouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftpos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown leftpos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxKitchen;
        private System.Windows.Forms.Label label9;
    }
}