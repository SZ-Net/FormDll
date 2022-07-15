namespace DLLClientLink
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSystem = new System.Windows.Forms.ToolStripDropDownButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuItem_Help = new System.Windows.Forms.MenuItem();
            this.About = new System.Windows.Forms.MenuItem();
            this.menuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.menuItem_MDILayout = new System.Windows.Forms.MenuItem();
            this.Cascade = new System.Windows.Forms.MenuItem();
            this.TileHorizontal = new System.Windows.Forms.MenuItem();
            this.TileVertical = new System.Windows.Forms.MenuItem();
            this.menuItem_System = new System.Windows.Forms.MenuItem();
            this.Login = new System.Windows.Forms.MenuItem();
            this.SetUp = new System.Windows.Forms.MenuItem();
            this.Exit = new System.Windows.Forms.MenuItem();
            this.tsMenuNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuNotifyShow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.User = new System.Windows.Forms.ToolStripStatusLabel();
            this.LocalIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.RamValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.dllCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClientStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsMain.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.ClientStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSystem});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(800, 47);
            this.tsMain.TabIndex = 0;
            // 
            // tsbSystem
            // 
            this.tsbSystem.Image = global::DLLClientLink.Properties.Resources.server;
            this.tsbSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSystem.Name = "tsbSystem";
            this.tsbSystem.Size = new System.Drawing.Size(76, 44);
            this.tsbSystem.Text = "System";
            this.tsbSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 47);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 33);
            this.topPanel.TabIndex = 1;
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.Index = -1;
            this.menuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.About});
            this.menuItem_Help.Text = "Help";
            // 
            // About
            // 
            this.About.Index = 0;
            this.About.Text = "About Client";
            // 
            // menuItem_Refresh
            // 
            this.menuItem_Refresh.Index = -1;
            this.menuItem_Refresh.Text = "Refresh";
            // 
            // menuItem_MDILayout
            // 
            this.menuItem_MDILayout.Index = -1;
            this.menuItem_MDILayout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Cascade,
            this.TileHorizontal,
            this.TileVertical});
            this.menuItem_MDILayout.Text = "MDILayout";
            // 
            // Cascade
            // 
            this.Cascade.Index = 0;
            this.Cascade.Text = "Cascade";
            // 
            // TileHorizontal
            // 
            this.TileHorizontal.Index = 1;
            this.TileHorizontal.Text = "TileHorizontal";
            // 
            // TileVertical
            // 
            this.TileVertical.Index = 2;
            this.TileVertical.Text = "TileVertical";
            // 
            // menuItem_System
            // 
            this.menuItem_System.Index = -1;
            this.menuItem_System.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Login,
            this.SetUp,
            this.Exit});
            this.menuItem_System.Text = "System";
            // 
            // Login
            // 
            this.Login.Index = 0;
            this.Login.Text = "Login";
            // 
            // SetUp
            // 
            this.SetUp.Index = 1;
            this.SetUp.Text = "SetUp";
            // 
            // Exit
            // 
            this.Exit.Index = 2;
            this.Exit.Text = "Exit";
            // 
            // tsMenuNotifyExit
            // 
            this.tsMenuNotifyExit.Name = "tsMenuNotifyExit";
            this.tsMenuNotifyExit.Size = new System.Drawing.Size(124, 38);
            this.tsMenuNotifyExit.Text = "退出";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // tsMenuNotifyShow
            // 
            this.tsMenuNotifyShow.Image = global::DLLClientLink.Properties.Resources.show;
            this.tsMenuNotifyShow.Name = "tsMenuNotifyShow";
            this.tsMenuNotifyShow.Size = new System.Drawing.Size(124, 38);
            this.tsMenuNotifyShow.Text = "显示";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuNotifyShow,
            this.toolStripMenuItem2,
            this.tsMenuNotifyExit});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 86);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Client";
            this.notifyIcon1.Visible = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 80);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 344);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // User
            // 
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(46, 20);
            this.User.Text = "User:";
            // 
            // LocalIP
            // 
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(26, 20);
            this.LocalIP.Text = "IP:";
            // 
            // RamValue
            // 
            this.RamValue.Name = "RamValue";
            this.RamValue.Size = new System.Drawing.Size(45, 20);
            this.RamValue.Text = "Ram:";
            // 
            // dllCount
            // 
            this.dllCount.Name = "dllCount";
            this.dllCount.Size = new System.Drawing.Size(102, 20);
            this.dllCount.Text = "加载dll数量：";
            // 
            // ClientStatusStrip
            // 
            this.ClientStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ClientStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dllCount,
            this.RamValue,
            this.LocalIP,
            this.User});
            this.ClientStatusStrip.Location = new System.Drawing.Point(0, 424);
            this.ClientStatusStrip.Name = "ClientStatusStrip";
            this.ClientStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ClientStatusStrip.Size = new System.Drawing.Size(800, 26);
            this.ClientStatusStrip.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ClientStatusStrip);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.tsMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ClientStatusStrip.ResumeLayout(false);
            this.ClientStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsbSystem;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuItem menuItem_Help;
        private System.Windows.Forms.MenuItem About;
        private System.Windows.Forms.MenuItem menuItem_Refresh;
        private System.Windows.Forms.MenuItem menuItem_MDILayout;
        private System.Windows.Forms.MenuItem Cascade;
        private System.Windows.Forms.MenuItem TileHorizontal;
        private System.Windows.Forms.MenuItem TileVertical;
        private System.Windows.Forms.MenuItem menuItem_System;
        private System.Windows.Forms.MenuItem Login;
        private System.Windows.Forms.MenuItem SetUp;
        private System.Windows.Forms.MenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNotifyExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNotifyShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel User;
        private System.Windows.Forms.ToolStripStatusLabel LocalIP;
        private System.Windows.Forms.ToolStripStatusLabel RamValue;
        private System.Windows.Forms.ToolStripStatusLabel dllCount;
        private System.Windows.Forms.StatusStrip ClientStatusStrip;
    }
}