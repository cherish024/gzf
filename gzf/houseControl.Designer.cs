namespace gzf
{
    partial class houseControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.散客开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.团体开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改房态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.合同信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更换房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水电费明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.散客开单ToolStripMenuItem,
            this.团体开单ToolStripMenuItem,
            this.退房ToolStripMenuItem,
            this.客人信息ToolStripMenuItem,
            this.更改房态ToolStripMenuItem,
            this.合同信息ToolStripMenuItem,
            this.更换房间ToolStripMenuItem,
            this.水电费明细ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 202);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // 散客开单ToolStripMenuItem
            // 
            this.散客开单ToolStripMenuItem.Name = "散客开单ToolStripMenuItem";
            this.散客开单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.散客开单ToolStripMenuItem.Text = "个人开单";
            this.散客开单ToolStripMenuItem.Click += new System.EventHandler(this.散客开单ToolStripMenuItem_Click);
            // 
            // 团体开单ToolStripMenuItem
            // 
            this.团体开单ToolStripMenuItem.Name = "团体开单ToolStripMenuItem";
            this.团体开单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.团体开单ToolStripMenuItem.Text = "团体开单";
            this.团体开单ToolStripMenuItem.Click += new System.EventHandler(this.团体开单ToolStripMenuItem_Click);
            // 
            // 退房ToolStripMenuItem
            // 
            this.退房ToolStripMenuItem.Name = "退房ToolStripMenuItem";
            this.退房ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退房ToolStripMenuItem.Text = "结账";
            this.退房ToolStripMenuItem.Click += new System.EventHandler(this.退房ToolStripMenuItem_Click);
            // 
            // 客人信息ToolStripMenuItem
            // 
            this.客人信息ToolStripMenuItem.Name = "客人信息ToolStripMenuItem";
            this.客人信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.客人信息ToolStripMenuItem.Text = "客人信息";
            this.客人信息ToolStripMenuItem.Click += new System.EventHandler(this.客人信息ToolStripMenuItem_Click);
            // 
            // 更改房态ToolStripMenuItem
            // 
            this.更改房态ToolStripMenuItem.Name = "更改房态ToolStripMenuItem";
            this.更改房态ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.更改房态ToolStripMenuItem.Text = "更改房态";
            this.更改房态ToolStripMenuItem.Click += new System.EventHandler(this.更改房态ToolStripMenuItem_Click);
            // 
            // 合同信息ToolStripMenuItem
            // 
            this.合同信息ToolStripMenuItem.Enabled = false;
            this.合同信息ToolStripMenuItem.Name = "合同信息ToolStripMenuItem";
            this.合同信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.合同信息ToolStripMenuItem.Text = "合同信息";
            this.合同信息ToolStripMenuItem.Click += new System.EventHandler(this.合同信息ToolStripMenuItem_Click);
            // 
            // 更换房间ToolStripMenuItem
            // 
            this.更换房间ToolStripMenuItem.Enabled = false;
            this.更换房间ToolStripMenuItem.Name = "更换房间ToolStripMenuItem";
            this.更换房间ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.更换房间ToolStripMenuItem.Text = "更换房间";
            this.更换房间ToolStripMenuItem.Click += new System.EventHandler(this.更换房间ToolStripMenuItem_Click);
            // 
            // 水电费明细ToolStripMenuItem
            // 
            this.水电费明细ToolStripMenuItem.Enabled = false;
            this.水电费明细ToolStripMenuItem.Name = "水电费明细ToolStripMenuItem";
            this.水电费明细ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.水电费明细ToolStripMenuItem.Text = "水电费明细";
            this.水电费明细ToolStripMenuItem.Click += new System.EventHandler(this.水电费明细ToolStripMenuItem_Click_1);
            // 
            // houseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "houseControl";
            this.Size = new System.Drawing.Size(73, 50);
            this.DoubleClick += new System.EventHandler(this.houseControl_DoubleClick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.houseControl_Paint);
            this.Click += new System.EventHandler(this.houseControl_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.houseControl_MouseMove);
            this.Leave += new System.EventHandler(this.houseControl_Leave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 散客开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 团体开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改房态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 合同信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更换房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水电费明细ToolStripMenuItem;
    }
}
