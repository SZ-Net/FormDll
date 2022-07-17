namespace DLLClientLink.Forms
{
    partial class MainMsgControl
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
            this.menuMsgBoxAddRoutingRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMsgTitle = new System.Windows.Forms.GroupBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolSslInboundInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslRoutingRule = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslServerSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsMsgBox.SuspendLayout();
            this.gbMsgTitle.SuspendLayout();
            this.ssMain.SuspendLayout();
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
            this.txtMsgBox.Size = new System.Drawing.Size(900, 275);
            this.txtMsgBox.TabIndex = 4;
            // 
            // cmsMsgBox
            // 
            this.cmsMsgBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMsgBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMsgBoxSelectAll,
            this.menuMsgBoxCopy,
            this.menuMsgBoxCopyAll,
            this.menuMsgBoxClear,
            this.menuMsgBoxAddRoutingRule,
            this.menuMsgBoxFilter});
            this.cmsMsgBox.Name = "cmsMsgBox";
            this.cmsMsgBox.Size = new System.Drawing.Size(269, 148);
            // 
            // menuMsgBoxSelectAll
            // 
            this.menuMsgBoxSelectAll.Name = "menuMsgBoxSelectAll";
            this.menuMsgBoxSelectAll.Size = new System.Drawing.Size(268, 24);
            this.menuMsgBoxSelectAll.Text = "Select All (Ctrl+A)";
            // 
            // menuMsgBoxCopy
            // 
            this.menuMsgBoxCopy.Name = "menuMsgBoxCopy";
            this.menuMsgBoxCopy.Size = new System.Drawing.Size(268, 24);
            this.menuMsgBoxCopy.Text = "Copy (Ctrl+C)";
            // 
            // menuMsgBoxCopyAll
            // 
            this.menuMsgBoxCopyAll.Name = "menuMsgBoxCopyAll";
            this.menuMsgBoxCopyAll.Size = new System.Drawing.Size(268, 24);
            this.menuMsgBoxCopyAll.Text = "Copy All";
            // 
            // menuMsgBoxClear
            // 
            this.menuMsgBoxClear.Name = "menuMsgBoxClear";
            this.menuMsgBoxClear.Size = new System.Drawing.Size(268, 24);
            this.menuMsgBoxClear.Text = "Clear All";
            // 
            // menuMsgBoxAddRoutingRule
            // 
            this.menuMsgBoxAddRoutingRule.Name = "menuMsgBoxAddRoutingRule";
            this.menuMsgBoxAddRoutingRule.Size = new System.Drawing.Size(268, 24);
            this.menuMsgBoxAddRoutingRule.Text = "Add Routing Rule (Ctrl+V)";
            // 
            // menuMsgBoxFilter
            // 
            this.menuMsgBoxFilter.Name = "menuMsgBoxFilter";
            this.menuMsgBoxFilter.Size = new System.Drawing.Size(268, 24);
            this.menuMsgBoxFilter.Text = "Set message filters";
            // 
            // gbMsgTitle
            // 
            this.gbMsgTitle.Controls.Add(this.txtMsgBox);
            this.gbMsgTitle.Controls.Add(this.ssMain);
            this.gbMsgTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMsgTitle.Location = new System.Drawing.Point(0, 0);
            this.gbMsgTitle.Margin = new System.Windows.Forms.Padding(4);
            this.gbMsgTitle.Name = "gbMsgTitle";
            this.gbMsgTitle.Padding = new System.Windows.Forms.Padding(4);
            this.gbMsgTitle.Size = new System.Drawing.Size(908, 327);
            this.gbMsgTitle.TabIndex = 6;
            this.gbMsgTitle.TabStop = false;
            this.gbMsgTitle.Text = "Informations";
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSslInboundInfo,
            this.toolSslBlank1,
            this.toolSslRoutingRule,
            this.toolSslBlank2,
            this.toolSslServerSpeed,
            this.toolSslBlank4});
            this.ssMain.Location = new System.Drawing.Point(4, 297);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMain.Size = new System.Drawing.Size(900, 26);
            this.ssMain.TabIndex = 0;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolSslInboundInfo
            // 
            this.toolSslInboundInfo.Name = "toolSslInboundInfo";
            this.toolSslInboundInfo.Size = new System.Drawing.Size(98, 20);
            this.toolSslInboundInfo.Text = "InboundInfo";
            // 
            // toolSslBlank1
            // 
            this.toolSslBlank1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toolSslBlank1.Name = "toolSslBlank1";
            this.toolSslBlank1.Size = new System.Drawing.Size(12, 20);
            this.toolSslBlank1.Spring = true;
            // 
            // toolSslRoutingRule
            // 
            this.toolSslRoutingRule.Name = "toolSslRoutingRule";
            this.toolSslRoutingRule.Size = new System.Drawing.Size(0, 20);
            // 
            // toolSslBlank2
            // 
            this.toolSslBlank2.Name = "toolSslBlank2";
            this.toolSslBlank2.Size = new System.Drawing.Size(12, 20);
            this.toolSslBlank2.Spring = true;
            // 
            // toolSslServerSpeed
            // 
            this.toolSslServerSpeed.AutoSize = false;
            this.toolSslServerSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSslServerSpeed.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.toolSslServerSpeed.Name = "toolSslServerSpeed";
            this.toolSslServerSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolSslServerSpeed.Size = new System.Drawing.Size(250, 20);
            this.toolSslServerSpeed.Text = "SPEED Disabled";
            this.toolSslServerSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolSslBlank4
            // 
            this.toolSslBlank4.Name = "toolSslBlank4";
            this.toolSslBlank4.Size = new System.Drawing.Size(0, 0);
            // 
            // MainMsgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMsgTitle);
            this.Name = "MainMsgControl";
            this.Size = new System.Drawing.Size(908, 327);
            this.cmsMsgBox.ResumeLayout(false);
            this.gbMsgTitle.ResumeLayout(false);
            this.gbMsgTitle.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsgBox;
        private System.Windows.Forms.ContextMenuStrip cmsMsgBox;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopyAll;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxClear;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxAddRoutingRule;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxFilter;
        private System.Windows.Forms.GroupBox gbMsgTitle;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolSslInboundInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank1;
        private System.Windows.Forms.ToolStripStatusLabel toolSslRoutingRule;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank2;
        private System.Windows.Forms.ToolStripStatusLabel toolSslServerSpeed;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank4;
    }
}
