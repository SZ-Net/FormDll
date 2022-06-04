
namespace DLLClientLink
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
            this.tbGO = new System.Windows.Forms.TextBox();
            this.PanelExpander = new System.Windows.Forms.Panel();
            this.ExpanderPictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuNotifyShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientStatusStrip.SuspendLayout();
            this.PanelLeftAll.SuspendLayout();
            this.PanelTreePanelSearch.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).BeginInit();
            this.PanelExpander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetUp
            // 
            this.SetUp.Index = 1;
            this.SetUp.Text = "SetUp";
            this.SetUp.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_System
            // 
            this.menuItem_System.Index = 0;
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
            this.Login.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Index = 2;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // About
            // 
            this.About.Index = 0;
            this.About.Text = "About Client";
            this.About.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_Help
            // 
            this.menuItem_Help.Index = 3;
            this.menuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.About});
            this.menuItem_Help.Text = "Help";
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_System,
            this.menuItem_MDILayout,
            this.menuItem_Refresh,
            this.menuItem_Help});
            // 
            // menuItem_MDILayout
            // 
            this.menuItem_MDILayout.Index = 1;
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
            this.Cascade.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // TileHorizontal
            // 
            this.TileHorizontal.Index = 1;
            this.TileHorizontal.Text = "TileHorizontal";
            this.TileHorizontal.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // TileVertical
            // 
            this.TileVertical.Index = 2;
            this.TileVertical.Text = "TileVertical";
            this.TileVertical.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem_Refresh
            // 
            this.menuItem_Refresh.Index = 2;
            this.menuItem_Refresh.Text = "Refresh";
            this.menuItem_Refresh.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgList.ImageSize = new System.Drawing.Size(16, 16);
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
            this.ClientStatusStrip.Location = new System.Drawing.Point(0, 459);
            this.ClientStatusStrip.Name = "ClientStatusStrip";
            this.ClientStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ClientStatusStrip.Size = new System.Drawing.Size(784, 26);
            this.ClientStatusStrip.TabIndex = 26;
            // 
            // dllCount
            // 
            this.dllCount.Name = "dllCount";
            this.dllCount.Size = new System.Drawing.Size(102, 20);
            this.dllCount.Text = "加载dll数量：";
            // 
            // RamValue
            // 
            this.RamValue.Name = "RamValue";
            this.RamValue.Size = new System.Drawing.Size(45, 20);
            this.RamValue.Text = "Ram:";
            // 
            // LocalIP
            // 
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(26, 20);
            this.LocalIP.Text = "IP:";
            // 
            // User
            // 
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(46, 20);
            this.User.Text = "User:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 459);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // PanelLeftAll
            // 
            this.PanelLeftAll.AutoScroll = true;
            this.PanelLeftAll.Controls.Add(this.PanelTreePanelSearch);
            this.PanelLeftAll.Controls.Add(this.PanelExpander);
            this.PanelLeftAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftAll.Location = new System.Drawing.Point(0, 0);
            this.PanelLeftAll.Name = "PanelLeftAll";
            this.PanelLeftAll.Size = new System.Drawing.Size(200, 459);
            this.PanelLeftAll.TabIndex = 27;
            // 
            // PanelTreePanelSearch
            // 
            this.PanelTreePanelSearch.AutoScroll = true;
            this.PanelTreePanelSearch.Controls.Add(this.tView);
            this.PanelTreePanelSearch.Controls.Add(this.PanelSearch);
            this.PanelTreePanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTreePanelSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelTreePanelSearch.Name = "PanelTreePanelSearch";
            this.PanelTreePanelSearch.Size = new System.Drawing.Size(175, 459);
            this.PanelTreePanelSearch.TabIndex = 29;
            // 
            // tView
            // 
            this.tView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tView.Location = new System.Drawing.Point(0, 29);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(175, 430);
            this.tView.TabIndex = 10;
            this.tView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tView_MouseDoubleClick);
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.pbGo);
            this.PanelSearch.Controls.Add(this.tbGO);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(175, 29);
            this.PanelSearch.TabIndex = 9;
            // 
            // pbGo
            // 
            this.pbGo.Image = global::DLLClientLink.Properties.Resources.query;
            this.pbGo.Location = new System.Drawing.Point(135, 3);
            this.pbGo.Name = "pbGo";
            this.pbGo.Size = new System.Drawing.Size(34, 25);
            this.pbGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGo.TabIndex = 12;
            this.pbGo.TabStop = false;
            this.pbGo.Click += new System.EventHandler(this.pbGo_Click);
            // 
            // tbGO
            // 
            this.tbGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbGO.Location = new System.Drawing.Point(7, 3);
            this.tbGO.Name = "tbGO";
            this.tbGO.Size = new System.Drawing.Size(124, 24);
            this.tbGO.TabIndex = 11;
            // 
            // PanelExpander
            // 
            this.PanelExpander.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelExpander.Controls.Add(this.ExpanderPictureBox);
            this.PanelExpander.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelExpander.Location = new System.Drawing.Point(175, 0);
            this.PanelExpander.Name = "PanelExpander";
            this.PanelExpander.Size = new System.Drawing.Size(25, 459);
            this.PanelExpander.TabIndex = 16;
            // 
            // ExpanderPictureBox
            // 
            this.ExpanderPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpanderPictureBox.Image = global::DLLClientLink.Properties.Resources.Expander;
            this.ExpanderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ExpanderPictureBox.Name = "ExpanderPictureBox";
            this.ExpanderPictureBox.Size = new System.Drawing.Size(25, 29);
            this.ExpanderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpanderPictureBox.TabIndex = 0;
            this.ExpanderPictureBox.TabStop = false;
            this.ExpanderPictureBox.Click += new System.EventHandler(this.Expander_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Client";
            this.notifyIcon1.Visible = true;
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
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 86);
            // 
            // tsMenuNotifyShow
            // 
            this.tsMenuNotifyShow.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuNotifyShow.Image")));
            this.tsMenuNotifyShow.Name = "tsMenuNotifyShow";
            this.tsMenuNotifyShow.Size = new System.Drawing.Size(124, 38);
            this.tsMenuNotifyShow.Text = "显示";
            this.tsMenuNotifyShow.Click += new System.EventHandler(this.tsMenuNotifyShow_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // tsMenuNotifyExit
            // 
            this.tsMenuNotifyExit.Name = "tsMenuNotifyExit";
            this.tsMenuNotifyExit.Size = new System.Drawing.Size(124, 38);
            this.tsMenuNotifyExit.Text = "退出";
            this.tsMenuNotifyExit.Click += new System.EventHandler(this.tsMenuNotifyExit_Click);
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PanelLeftAll);
            this.Controls.Add(this.ClientStatusStrip);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu = this.MainMenu;
            this.Name = "ClientMain";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientMain_FormClosed);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.Shown += new System.EventHandler(this.ClientMain_Shown);
            this.SizeChanged += new System.EventHandler(this.ClientMain_SizeChanged);
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
        private System.Windows.Forms.TextBox tbGO;
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
    }
}

