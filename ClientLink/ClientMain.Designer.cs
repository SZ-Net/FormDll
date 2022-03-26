
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
            this.menuItemSetUp = new System.Windows.Forms.MenuItem();
            this.menuItemSystem = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemRefresh = new System.Windows.Forms.MenuItem();
            this.TileHorizontal = new System.Windows.Forms.MenuItem();
            this.TileVertical = new System.Windows.Forms.MenuItem();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.ClientStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.RamValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PanelLeftAll = new System.Windows.Forms.Panel();
            this.PanelTreePanelSearch = new System.Windows.Forms.Panel();
            this.tView = new System.Windows.Forms.TreeView();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.pbGo = new System.Windows.Forms.PictureBox();
            this.tbGO = new System.Windows.Forms.TextBox();
            this.PanelExpander = new System.Windows.Forms.Panel();
            this.ExpanderPictureBox = new System.Windows.Forms.PictureBox();
            this.ClientStatusStrip.SuspendLayout();
            this.PanelLeftAll.SuspendLayout();
            this.PanelTreePanelSearch.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).BeginInit();
            this.PanelExpander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemSetUp
            // 
            this.menuItemSetUp.Index = 0;
            this.menuItemSetUp.Text = "SetUp";
            // 
            // menuItemSystem
            // 
            this.menuItemSystem.Index = 0;
            this.menuItemSystem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSetUp});
            this.menuItemSystem.Text = "System";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 0;
            this.menuItemAbout.Text = "&About Client";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 1;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Text = "&Help";
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSystem,
            this.menuItemHelp,
            this.menuItemRefresh,
            this.TileHorizontal,
            this.TileVertical});
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Index = 2;
            this.menuItemRefresh.Text = "Refresh";
            this.menuItemRefresh.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // TileHorizontal
            // 
            this.TileHorizontal.Index = 3;
            this.TileHorizontal.Text = "TileHorizontal";
            this.TileHorizontal.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // TileVertical
            // 
            this.TileVertical.Index = 4;
            this.TileVertical.Text = "TileVertical";
            this.TileVertical.Click += new System.EventHandler(this.menuItem_Click);
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
            this.toolStripStatusLabel1,
            this.RamValue});
            this.ClientStatusStrip.Location = new System.Drawing.Point(0, 408);
            this.ClientStatusStrip.Name = "ClientStatusStrip";
            this.ClientStatusStrip.Size = new System.Drawing.Size(697, 26);
            this.ClientStatusStrip.TabIndex = 26;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 20);
            this.toolStripStatusLabel1.Text = "加载dll数量：";
            // 
            // RamValue
            // 
            this.RamValue.Name = "RamValue";
            this.RamValue.Size = new System.Drawing.Size(45, 20);
            this.RamValue.Text = "Ram:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(178, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 408);
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
            this.PanelLeftAll.Size = new System.Drawing.Size(178, 408);
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
            this.PanelTreePanelSearch.Size = new System.Drawing.Size(156, 408);
            this.PanelTreePanelSearch.TabIndex = 29;
            // 
            // tView
            // 
            this.tView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tView.Location = new System.Drawing.Point(0, 27);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(156, 381);
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
            this.PanelSearch.Size = new System.Drawing.Size(156, 27);
            this.PanelSearch.TabIndex = 9;
            this.PanelSearch.Visible = false;
            // 
            // pbGo
            // 
            this.pbGo.Image = global::DLLClientLink.Properties.Resources.Authority;
            this.pbGo.Location = new System.Drawing.Point(120, 4);
            this.pbGo.Name = "pbGo";
            this.pbGo.Size = new System.Drawing.Size(30, 23);
            this.pbGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGo.TabIndex = 12;
            this.pbGo.TabStop = false;
            // 
            // tbGO
            // 
            this.tbGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbGO.Location = new System.Drawing.Point(6, 3);
            this.tbGO.Name = "tbGO";
            this.tbGO.Size = new System.Drawing.Size(111, 24);
            this.tbGO.TabIndex = 11;
            // 
            // PanelExpander
            // 
            this.PanelExpander.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelExpander.Controls.Add(this.ExpanderPictureBox);
            this.PanelExpander.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelExpander.Location = new System.Drawing.Point(156, 0);
            this.PanelExpander.Name = "PanelExpander";
            this.PanelExpander.Size = new System.Drawing.Size(22, 408);
            this.PanelExpander.TabIndex = 16;
            // 
            // ExpanderPictureBox
            // 
            this.ExpanderPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpanderPictureBox.Image = global::DLLClientLink.Properties.Resources.change;
            this.ExpanderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ExpanderPictureBox.Name = "ExpanderPictureBox";
            this.ExpanderPictureBox.Size = new System.Drawing.Size(22, 27);
            this.ExpanderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpanderPictureBox.TabIndex = 0;
            this.ExpanderPictureBox.TabStop = false;
            this.ExpanderPictureBox.Click += new System.EventHandler(this.Expander_Click);
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 434);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.PanelLeftAll);
            this.Controls.Add(this.ClientStatusStrip);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu = this.MainMenu;
            this.Name = "ClientMain";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientMain_FormClosed);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.Shown += new System.EventHandler(this.ClientMain_Shown);
            this.ClientStatusStrip.ResumeLayout(false);
            this.ClientStatusStrip.PerformLayout();
            this.PanelLeftAll.ResumeLayout(false);
            this.PanelTreePanelSearch.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).EndInit();
            this.PanelExpander.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuItem menuItemSetUp;
        private System.Windows.Forms.MenuItem menuItemSystem;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.StatusStrip ClientStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuItem menuItemRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel PanelLeftAll;
        private System.Windows.Forms.Panel PanelTreePanelSearch;
        private System.Windows.Forms.TreeView tView;
        public System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.PictureBox pbGo;
        private System.Windows.Forms.TextBox tbGO;
        private System.Windows.Forms.Panel PanelExpander;
        private System.Windows.Forms.PictureBox ExpanderPictureBox;
        private System.Windows.Forms.MenuItem TileHorizontal;
        private System.Windows.Forms.MenuItem TileVertical;
        private System.Windows.Forms.ToolStripStatusLabel RamValue;
    }
}

