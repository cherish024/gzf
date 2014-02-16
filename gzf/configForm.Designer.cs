namespace gzf
{
    partial class configForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delUser = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_delBuilding = new System.Windows.Forms.Button();
            this.btn_editBuilding = new System.Windows.Forms.Button();
            this.btn_addBuilding = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delHouse = new System.Windows.Forms.Button();
            this.btn_editHouse = new System.Windows.Forms.Button();
            this.btn_addHouse = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.排序 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(28, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_EditUser);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_delUser);
            this.tabPage1.Controls.Add(this.btn_addUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "系统用户";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(221, 263);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(75, 23);
            this.btn_EditUser.TabIndex = 3;
            this.btn_EditUser.Text = "编辑用户";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.用户名,
            this.用户类型,
            this.姓名});
            this.dataGridView1.Location = new System.Drawing.Point(55, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 228);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // 用户名
            // 
            this.用户名.DataPropertyName = "username";
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            // 
            // 用户类型
            // 
            this.用户类型.DataPropertyName = "type";
            this.用户类型.HeaderText = "用户级别";
            this.用户类型.Name = "用户类型";
            this.用户类型.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "fullname";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // btn_delUser
            // 
            this.btn_delUser.Location = new System.Drawing.Point(334, 263);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(75, 23);
            this.btn_delUser.TabIndex = 1;
            this.btn_delUser.Text = "删除用户";
            this.btn_delUser.UseVisualStyleBackColor = true;
            this.btn_delUser.Click += new System.EventHandler(this.btn_delUser_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(104, 263);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(75, 23);
            this.btn_addUser.TabIndex = 0;
            this.btn_addUser.Text = "添加用户";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_delBuilding);
            this.tabPage2.Controls.Add(this.btn_editBuilding);
            this.tabPage2.Controls.Add(this.btn_addBuilding);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "建筑管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.排序,
            this.Column2,
            this.Column3,
            this.Column11});
            this.dataGridView2.Location = new System.Drawing.Point(49, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(427, 234);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // btn_delBuilding
            // 
            this.btn_delBuilding.Location = new System.Drawing.Point(333, 269);
            this.btn_delBuilding.Name = "btn_delBuilding";
            this.btn_delBuilding.Size = new System.Drawing.Size(75, 23);
            this.btn_delBuilding.TabIndex = 2;
            this.btn_delBuilding.Text = "删除建筑";
            this.btn_delBuilding.UseVisualStyleBackColor = true;
            this.btn_delBuilding.Click += new System.EventHandler(this.btn_delBuilding_Click);
            // 
            // btn_editBuilding
            // 
            this.btn_editBuilding.Location = new System.Drawing.Point(223, 269);
            this.btn_editBuilding.Name = "btn_editBuilding";
            this.btn_editBuilding.Size = new System.Drawing.Size(75, 23);
            this.btn_editBuilding.TabIndex = 1;
            this.btn_editBuilding.Text = "编辑建筑";
            this.btn_editBuilding.UseVisualStyleBackColor = true;
            this.btn_editBuilding.Click += new System.EventHandler(this.btn_editBuilding_Click);
            // 
            // btn_addBuilding
            // 
            this.btn_addBuilding.Location = new System.Drawing.Point(113, 269);
            this.btn_addBuilding.Name = "btn_addBuilding";
            this.btn_addBuilding.Size = new System.Drawing.Size(75, 23);
            this.btn_addBuilding.TabIndex = 0;
            this.btn_addBuilding.Text = "添加建筑";
            this.btn_addBuilding.UseVisualStyleBackColor = true;
            this.btn_addBuilding.Click += new System.EventHandler(this.btn_addBuilding_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxBuilding);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.btn_delHouse);
            this.tabPage3.Controls.Add(this.btn_editHouse);
            this.tabPage3.Controls.Add(this.btn_addHouse);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(525, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "房屋管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.DisplayMember = "name";
            this.comboBoxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Location = new System.Drawing.Point(21, 18);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(130, 20);
            this.comboBoxBuilding.TabIndex = 4;
            this.comboBoxBuilding.ValueMember = "id";
            this.comboBoxBuilding.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuilding_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column10,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            this.dataGridView3.Location = new System.Drawing.Point(21, 58);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(490, 192);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            this.dataGridView3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView3_CellFormatting);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id";
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 65;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "sortnum";
            this.Column10.HeaderText = "排序";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "name";
            this.Column8.HeaderText = "所属建筑";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sn";
            this.Column5.HeaderText = "房屋编号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "floor";
            this.Column6.HeaderText = "楼层";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "price";
            this.Column7.HeaderText = "租金";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "position";
            this.Column9.HeaderText = "朝向";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // btn_delHouse
            // 
            this.btn_delHouse.Location = new System.Drawing.Point(341, 271);
            this.btn_delHouse.Name = "btn_delHouse";
            this.btn_delHouse.Size = new System.Drawing.Size(75, 23);
            this.btn_delHouse.TabIndex = 2;
            this.btn_delHouse.Text = "删除房屋";
            this.btn_delHouse.UseVisualStyleBackColor = true;
            this.btn_delHouse.Click += new System.EventHandler(this.btn_delHouse_Click);
            // 
            // btn_editHouse
            // 
            this.btn_editHouse.Location = new System.Drawing.Point(223, 272);
            this.btn_editHouse.Name = "btn_editHouse";
            this.btn_editHouse.Size = new System.Drawing.Size(75, 23);
            this.btn_editHouse.TabIndex = 1;
            this.btn_editHouse.Text = "编辑房屋";
            this.btn_editHouse.UseVisualStyleBackColor = true;
            this.btn_editHouse.Click += new System.EventHandler(this.btn_editHouse_Click);
            // 
            // btn_addHouse
            // 
            this.btn_addHouse.Location = new System.Drawing.Point(103, 272);
            this.btn_addHouse.Name = "btn_addHouse";
            this.btn_addHouse.Size = new System.Drawing.Size(75, 23);
            this.btn_addHouse.TabIndex = 0;
            this.btn_addHouse.Text = "添加房屋";
            this.btn_addHouse.UseVisualStyleBackColor = true;
            this.btn_addHouse.Click += new System.EventHandler(this.btn_addHouse_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // 排序
            // 
            this.排序.DataPropertyName = "sortnum";
            this.排序.HeaderText = "排序";
            this.排序.Name = "排序";
            this.排序.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "建筑名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "type";
            this.Column3.HeaderText = "建筑类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "dating";
            this.Column11.HeaderText = "大厅位置";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "configForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.configForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_delUser;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.Button btn_addBuilding;
        private System.Windows.Forms.Button btn_delBuilding;
        private System.Windows.Forms.Button btn_editBuilding;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_addHouse;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_delHouse;
        private System.Windows.Forms.Button btn_editHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 排序;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}