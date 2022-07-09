namespace WinRemoteDesktop
{
    partial class FormVNC
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLALTDELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaledViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.remoteDesktop1 = new VncSharp.RemoteDesktop();
            this.clippedViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(795, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Enabled = false;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.connectToolStripMenuItem.Text = "&Connect...";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendKeysToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // sendKeysToolStripMenuItem
            // 
            this.sendKeysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTRLALTDELToolStripMenuItem,
            this.aLTF4ToolStripMenuItem,
            this.cTRLESCToolStripMenuItem,
            this.cTRLToolStripMenuItem,
            this.aLTToolStripMenuItem});
            this.sendKeysToolStripMenuItem.Name = "sendKeysToolStripMenuItem";
            this.sendKeysToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.sendKeysToolStripMenuItem.Text = "Send Keys";
            // 
            // cTRLALTDELToolStripMenuItem
            // 
            this.cTRLALTDELToolStripMenuItem.Name = "cTRLALTDELToolStripMenuItem";
            this.cTRLALTDELToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.cTRLALTDELToolStripMenuItem.Text = "CTRL + ALT + DEL";
            this.cTRLALTDELToolStripMenuItem.Click += new System.EventHandler(this.cTRLALTDELToolStripMenuItem_Click);
            // 
            // aLTF4ToolStripMenuItem
            // 
            this.aLTF4ToolStripMenuItem.Name = "aLTF4ToolStripMenuItem";
            this.aLTF4ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.aLTF4ToolStripMenuItem.Text = "ALT + F4";
            this.aLTF4ToolStripMenuItem.Click += new System.EventHandler(this.aLTF4ToolStripMenuItem_Click);
            // 
            // cTRLESCToolStripMenuItem
            // 
            this.cTRLESCToolStripMenuItem.Name = "cTRLESCToolStripMenuItem";
            this.cTRLESCToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.cTRLESCToolStripMenuItem.Text = "CTRL + ESC";
            this.cTRLESCToolStripMenuItem.Click += new System.EventHandler(this.cTRLESCToolStripMenuItem_Click);
            // 
            // cTRLToolStripMenuItem
            // 
            this.cTRLToolStripMenuItem.Name = "cTRLToolStripMenuItem";
            this.cTRLToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.cTRLToolStripMenuItem.Text = "CTRL";
            this.cTRLToolStripMenuItem.Click += new System.EventHandler(this.cTRLToolStripMenuItem_Click);
            // 
            // aLTToolStripMenuItem
            // 
            this.aLTToolStripMenuItem.Name = "aLTToolStripMenuItem";
            this.aLTToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.aLTToolStripMenuItem.Text = "ALT";
            this.aLTToolStripMenuItem.Click += new System.EventHandler(this.aLTToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.pasteToolStripMenuItem.Text = "Copy local clipboard to host";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clippedViewToolStripMenuItem,
            this.scaledViewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.fullScreenRefreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // scaledViewToolStripMenuItem
            // 
            this.scaledViewToolStripMenuItem.Name = "scaledViewToolStripMenuItem";
            this.scaledViewToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.scaledViewToolStripMenuItem.Text = "Sc&aled View";
            this.scaledViewToolStripMenuItem.Click += new System.EventHandler(this.scaledViewToolStripMenuItem_Click);
            // 
            // fullScreenRefreshToolStripMenuItem
            // 
            this.fullScreenRefreshToolStripMenuItem.Name = "fullScreenRefreshToolStripMenuItem";
            this.fullScreenRefreshToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.fullScreenRefreshToolStripMenuItem.Text = "Full Screen Refresh";
            this.fullScreenRefreshToolStripMenuItem.Click += new System.EventHandler(this.fullScreenRefreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // remoteDesktop1
            // 
            this.remoteDesktop1.AutoScroll = true;
            this.remoteDesktop1.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.remoteDesktop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteDesktop1.Location = new System.Drawing.Point(0, 34);
            this.remoteDesktop1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remoteDesktop1.Name = "remoteDesktop1";
            this.remoteDesktop1.Size = new System.Drawing.Size(795, 615);
            this.remoteDesktop1.TabIndex = 2;
            this.remoteDesktop1.ViewOnly = false;
            // 
            // clippedViewToolStripMenuItem
            // 
            this.clippedViewToolStripMenuItem.Name = "clippedViewToolStripMenuItem";
            this.clippedViewToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.clippedViewToolStripMenuItem.Text = "C&lipped View";
            this.clippedViewToolStripMenuItem.Click += new System.EventHandler(this.clippedViewToolStripMenuItem_Click);
            // 
            // FormVNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 649);
            this.Controls.Add(this.remoteDesktop1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormVNC";
            this.Text = "RemoteViewing - Example VNC Client";
            this.Load += new System.EventHandler(this.FormVNC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLALTDELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaledViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenRefreshToolStripMenuItem;
        private VncSharp.RemoteDesktop remoteDesktop1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clippedViewToolStripMenuItem;
    }
}