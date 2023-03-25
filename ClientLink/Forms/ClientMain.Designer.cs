
namespace ClientLink
{
    partial class ClientMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMain));
            this.SetUp = new System.Windows.Forms.MenuItem();
            this.menuItem_System = new System.Windows.Forms.MenuItem();
            this.Login = new System.Windows.Forms.MenuItem();
            this.Exit = new System.Windows.Forms.MenuItem();
            this.About = new System.Windows.Forms.MenuItem();
            this.menuItem_Help = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.LanguageDefault = new System.Windows.Forms.MenuItem();
            this.LanguageZhHans = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.ShowLog = new System.Windows.Forms.MenuItem();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem_MDILayout = new System.Windows.Forms.MenuItem();
            this.Cascade = new System.Windows.Forms.MenuItem();
            this.TileHorizontal = new System.Windows.Forms.MenuItem();
            this.TileVertical = new System.Windows.Forms.MenuItem();
            this.menuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.ClientStatusStrip = new System.Windows.Forms.StatusStrip();
            this.dllCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.RamValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.LocalIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.User = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PanelLeftAll = new System.Windows.Forms.Panel();
            this.PanelTreePanelSearch = new System.Windows.Forms.Panel();
            this.tView = new System.Windows.Forms.TreeView();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.pbGo = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.PanelExpander = new System.Windows.Forms.Panel();
            this.ExpanderPictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuNotifyShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MsgPanel = new System.Windows.Forms.Panel();
            this.mainMsgControl1 = new ClientLink.Forms.Message();
            this.ClientStatusStrip.SuspendLayout();
            this.PanelLeftAll.SuspendLayout();
            this.PanelTreePanelSearch.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).BeginInit();
            this.PanelExpander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.MsgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetUp
            // 
            this.SetUp.Index = 1;
            resources.ApplyResources(this.SetUp, "SetUp");
            this.SetUp.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_System
            // 
            this.menuItem_System.Index = 0;
            this.menuItem_System.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Login,
            this.SetUp,
            this.Exit});
            resources.ApplyResources(this.menuItem_System, "menuItem_System");
            // 
            // Login
            // 
            this.Login.Index = 0;
            resources.ApplyResources(this.Login, "Login");
            this.Login.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Index = 2;
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // About
            // 
            this.About.Index = 0;
            resources.ApplyResources(this.About, "About");
            this.About.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.Index = 3;
            this.menuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.About,
            this.menuItem1,
            this.LanguageDefault,
            this.LanguageZhHans,
            this.menuItem3,
            this.ShowLog});
            resources.ApplyResources(this.menuItem_Help, "menuItem_Help");
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // LanguageDefault
            // 
            this.LanguageDefault.Index = 2;
            resources.ApplyResources(this.LanguageDefault, "LanguageDefault");
            this.LanguageDefault.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // LanguageZhHans
            // 
            this.LanguageZhHans.Index = 3;
            resources.ApplyResources(this.LanguageZhHans, "LanguageZhHans");
            this.LanguageZhHans.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // ShowLog
            // 
            this.ShowLog.Index = 5;
            resources.ApplyResources(this.ShowLog, "ShowLog");
            this.ShowLog.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_System,
            this.menuItem_MDILayout,
            this.menuItem_Refresh,
            this.menuItem_Help});
            this.MainMenu.Tag = "1";
            // 
            // menuItem_MDILayout
            // 
            this.menuItem_MDILayout.Index = 1;
            this.menuItem_MDILayout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Cascade,
            this.TileHorizontal,
            this.TileVertical});
            resources.ApplyResources(this.menuItem_MDILayout, "menuItem_MDILayout");
            // 
            // Cascade
            // 
            this.Cascade.Index = 0;
            resources.ApplyResources(this.Cascade, "Cascade");
            this.Cascade.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // TileHorizontal
            // 
            this.TileHorizontal.Index = 1;
            resources.ApplyResources(this.TileHorizontal, "TileHorizontal");
            this.TileHorizontal.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // TileVertical
            // 
            this.TileVertical.Index = 2;
            resources.ApplyResources(this.TileVertical, "TileVertical");
            this.TileVertical.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_Refresh
            // 
            this.menuItem_Refresh.Index = 2;
            resources.ApplyResources(this.menuItem_Refresh, "menuItem_Refresh");
            this.menuItem_Refresh.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.ImgList, "ImgList");
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ClientStatusStrip
            // 
            this.ClientStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ClientStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dllCount,
            this.RamValue,
            this.LocalIP,
            this.User});
            resources.ApplyResources(this.ClientStatusStrip, "ClientStatusStrip");
            this.ClientStatusStrip.Name = "ClientStatusStrip";
            // 
            // dllCount
            // 
            this.dllCount.Name = "dllCount";
            resources.ApplyResources(this.dllCount, "dllCount");
            // 
            // RamValue
            // 
            this.RamValue.Name = "RamValue";
            resources.ApplyResources(this.RamValue, "RamValue");
            // 
            // LocalIP
            // 
            this.LocalIP.Name = "LocalIP";
            resources.ApplyResources(this.LocalIP, "LocalIP");
            // 
            // User
            // 
            this.User.Name = "User";
            resources.ApplyResources(this.User, "User");
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // PanelLeftAll
            // 
            resources.ApplyResources(this.PanelLeftAll, "PanelLeftAll");
            this.PanelLeftAll.Controls.Add(this.PanelTreePanelSearch);
            this.PanelLeftAll.Controls.Add(this.PanelExpander);
            this.PanelLeftAll.Name = "PanelLeftAll";
            // 
            // PanelTreePanelSearch
            // 
            resources.ApplyResources(this.PanelTreePanelSearch, "PanelTreePanelSearch");
            this.PanelTreePanelSearch.Controls.Add(this.tView);
            this.PanelTreePanelSearch.Controls.Add(this.PanelSearch);
            this.PanelTreePanelSearch.Name = "PanelTreePanelSearch";
            // 
            // tView
            // 
            this.tView.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.tView, "tView");
            this.tView.Name = "tView";
            this.tView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tView_MouseDoubleClick);
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.pbGo);
            this.PanelSearch.Controls.Add(this.tbSearch);
            resources.ApplyResources(this.PanelSearch, "PanelSearch");
            this.PanelSearch.Name = "PanelSearch";
            // 
            // pbGo
            // 
            resources.ApplyResources(this.pbGo, "pbGo");
            this.pbGo.Image = global::ClientLink.Properties.Resources.query;
            this.pbGo.Name = "pbGo";
            this.pbGo.TabStop = false;
            this.pbGo.Click += new System.EventHandler(this.pbGo_Click);
            // 
            // tbSearch
            // 
            resources.ApplyResources(this.tbSearch, "tbSearch");
            this.tbSearch.Name = "tbSearch";
            // 
            // PanelExpander
            // 
            this.PanelExpander.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelExpander.Controls.Add(this.ExpanderPictureBox);
            resources.ApplyResources(this.PanelExpander, "PanelExpander");
            this.PanelExpander.Name = "PanelExpander";
            // 
            // ExpanderPictureBox
            // 
            resources.ApplyResources(this.ExpanderPictureBox, "ExpanderPictureBox");
            this.ExpanderPictureBox.Image = global::ClientLink.Properties.Resources.Expander;
            this.ExpanderPictureBox.Name = "ExpanderPictureBox";
            this.ExpanderPictureBox.TabStop = false;
            this.ExpanderPictureBox.Click += new System.EventHandler(this.Expander_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuNotifyShow,
            this.toolStripMenuItem2,
            this.tsMenuNotifyExit});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // tsMenuNotifyShow
            // 
            this.tsMenuNotifyShow.Image = global::ClientLink.Properties.Resources.show;
            this.tsMenuNotifyShow.Name = "tsMenuNotifyShow";
            resources.ApplyResources(this.tsMenuNotifyShow, "tsMenuNotifyShow");
            this.tsMenuNotifyShow.Click += new System.EventHandler(this.tsMenuNotifyShow_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // tsMenuNotifyExit
            // 
            this.tsMenuNotifyExit.Name = "tsMenuNotifyExit";
            resources.ApplyResources(this.tsMenuNotifyExit, "tsMenuNotifyExit");
            this.tsMenuNotifyExit.Click += new System.EventHandler(this.tsMenuNotifyExit_Click);
            // 
            // MsgPanel
            // 
            this.MsgPanel.Controls.Add(this.mainMsgControl1);
            resources.ApplyResources(this.MsgPanel, "MsgPanel");
            this.MsgPanel.Name = "MsgPanel";
            // 
            // mainMsgControl1
            // 
            resources.ApplyResources(this.mainMsgControl1, "mainMsgControl1");
            this.mainMsgControl1.Name = "mainMsgControl1";
            // 
            // ClientMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MsgPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PanelLeftAll);
            this.Controls.Add(this.ClientStatusStrip);
            this.Menu = this.MainMenu;
            this.Name = "ClientMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientMain_FormClosing);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.Resize += new System.EventHandler(this.ClientMain_Resize);
            this.ClientStatusStrip.ResumeLayout(false);
            this.ClientStatusStrip.PerformLayout();
            this.PanelLeftAll.ResumeLayout(false);
            this.PanelTreePanelSearch.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).EndInit();
            this.PanelExpander.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.MsgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuItem SetUp;
        private System.Windows.Forms.MenuItem menuItem_System;
        private System.Windows.Forms.MenuItem About;
        private System.Windows.Forms.MenuItem menuItem_Help;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.StatusStrip ClientStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel dllCount;
        private System.Windows.Forms.MenuItem menuItem_Refresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel PanelLeftAll;
        private System.Windows.Forms.Panel PanelTreePanelSearch;
        private System.Windows.Forms.TreeView tView;
        public System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.PictureBox pbGo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel PanelExpander;
        private System.Windows.Forms.PictureBox ExpanderPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel RamValue;
        private System.Windows.Forms.ToolStripStatusLabel LocalIP;
        private System.Windows.Forms.MenuItem Exit;
        private System.Windows.Forms.MenuItem menuItem_MDILayout;
        private System.Windows.Forms.MenuItem Cascade;
        private System.Windows.Forms.MenuItem TileHorizontal;
        private System.Windows.Forms.MenuItem TileVertical;
        private System.Windows.Forms.MenuItem Login;
        private System.Windows.Forms.ToolStripStatusLabel User;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNotifyShow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNotifyExit;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem LanguageDefault;
        private System.Windows.Forms.MenuItem LanguageZhHans;
        private System.Windows.Forms.Panel MsgPanel;
        private Forms.Message mainMsgControl1;
        private System.Windows.Forms.MenuItem ShowLog;
        private System.Windows.Forms.MenuItem menuItem3;
    }
}

