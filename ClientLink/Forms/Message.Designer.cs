namespace ClientLink.Forms
{
    partial class Message
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.cmsMsgBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuMsgBoxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxClear = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMsgTitle = new System.Windows.Forms.GroupBox();
            this.cmsMsgBox.SuspendLayout();
            this.gbMsgTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgBox.ContextMenuStrip = this.cmsMsgBox;
            this.txtMsgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.txtMsgBox.Location = new System.Drawing.Point(4, 22);
            this.txtMsgBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsgBox.MaxLength = 0;
            this.txtMsgBox.Multiline = true;
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.ReadOnly = true;
            this.txtMsgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsgBox.Size = new System.Drawing.Size(900, 301);
            this.txtMsgBox.TabIndex = 4;
            this.txtMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsgBox_KeyDown);
            // 
            // cmsMsgBox
            // 
            this.cmsMsgBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMsgBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMsgBoxSelectAll,
            this.menuMsgBoxCopy,
            this.menuMsgBoxCopyAll,
            this.menuMsgBoxClear});
            this.cmsMsgBox.Name = "cmsMsgBox";
            this.cmsMsgBox.Size = new System.Drawing.Size(292, 156);
            // 
            // menuMsgBoxSelectAll
            // 
            this.menuMsgBoxSelectAll.Name = "menuMsgBoxSelectAll";
            this.menuMsgBoxSelectAll.Size = new System.Drawing.Size(291, 38);
            this.menuMsgBoxSelectAll.Text = "Select All (Ctrl+A)";
            this.menuMsgBoxSelectAll.Click += new System.EventHandler(this.menuMsgBoxSelectAll_Click);
            // 
            // menuMsgBoxCopy
            // 
            this.menuMsgBoxCopy.Name = "menuMsgBoxCopy";
            this.menuMsgBoxCopy.Size = new System.Drawing.Size(291, 38);
            this.menuMsgBoxCopy.Text = "Copy (Ctrl+C)";
            this.menuMsgBoxCopy.Click += new System.EventHandler(this.menuMsgBoxCopy_Click);
            // 
            // menuMsgBoxCopyAll
            // 
            this.menuMsgBoxCopyAll.Name = "menuMsgBoxCopyAll";
            this.menuMsgBoxCopyAll.Size = new System.Drawing.Size(291, 38);
            this.menuMsgBoxCopyAll.Text = "Copy All";
            this.menuMsgBoxCopyAll.Click += new System.EventHandler(this.menuMsgBoxCopyAll_Click);
            // 
            // menuMsgBoxClear
            // 
            this.menuMsgBoxClear.Name = "menuMsgBoxClear";
            this.menuMsgBoxClear.Size = new System.Drawing.Size(291, 38);
            this.menuMsgBoxClear.Text = "Clear All";
            this.menuMsgBoxClear.Click += new System.EventHandler(this.menuMsgBoxClear_Click);
            // 
            // gbMsgTitle
            // 
            this.gbMsgTitle.Controls.Add(this.txtMsgBox);
            this.gbMsgTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMsgTitle.Location = new System.Drawing.Point(0, 0);
            this.gbMsgTitle.Margin = new System.Windows.Forms.Padding(4);
            this.gbMsgTitle.Name = "gbMsgTitle";
            this.gbMsgTitle.Padding = new System.Windows.Forms.Padding(4);
            this.gbMsgTitle.Size = new System.Drawing.Size(908, 327);
            this.gbMsgTitle.TabIndex = 6;
            this.gbMsgTitle.TabStop = false;
            this.gbMsgTitle.Text = "log";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMsgTitle);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(908, 327);
            this.cmsMsgBox.ResumeLayout(false);
            this.gbMsgTitle.ResumeLayout(false);
            this.gbMsgTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsgBox;
        private System.Windows.Forms.ContextMenuStrip cmsMsgBox;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopyAll;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxClear;
        private System.Windows.Forms.GroupBox gbMsgTitle;
    }
}
