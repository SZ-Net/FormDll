
namespace Demo10002
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ClientStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExpanderPictureBox = new System.Windows.Forms.PictureBox();
            this.tView = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbGo = new System.Windows.Forms.PictureBox();
            this.tbGO = new System.Windows.Forms.TextBox();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.PanelLeftAll = new System.Windows.Forms.Panel();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Body.SuspendLayout();
            this.Head.SuspendLayout();
            this.ClientStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).BeginInit();
            this.PanelSearch.SuspendLayout();
            this.PanelLeftAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 434);
            this.Footer.Size = new System.Drawing.Size(800, 106);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.button1);
            this.Body.Controls.Add(this.splitter1);
            this.Body.Controls.Add(this.ClientStatusStrip);
            this.Body.Controls.Add(this.PanelLeftAll);
            this.Body.Size = new System.Drawing.Size(800, 383);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(800, 51);
            // 
            // Head
            // 
            this.Head.Size = new System.Drawing.Size(800, 51);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(202, 21);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 333);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // ClientStatusStrip
            // 
            this.ClientStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ClientStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ClientStatusStrip.Location = new System.Drawing.Point(202, 354);
            this.ClientStatusStrip.Name = "ClientStatusStrip";
            this.ClientStatusStrip.Size = new System.Drawing.Size(594, 26);
            this.ClientStatusStrip.TabIndex = 29;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 20);
            this.toolStripStatusLabel1.Text = "加载dll数量：";
            // 
            // ExpanderPictureBox
            // 
            this.ExpanderPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpanderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExpanderPictureBox.Image")));
            this.ExpanderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ExpanderPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ExpanderPictureBox.Name = "ExpanderPictureBox";
            this.ExpanderPictureBox.Size = new System.Drawing.Size(26, 24);
            this.ExpanderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExpanderPictureBox.TabIndex = 0;
            this.ExpanderPictureBox.TabStop = false;
            // 
            // tView
            // 
            this.tView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tView.Location = new System.Drawing.Point(0, 0);
            this.tView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(172, 359);
            this.tView.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExpanderPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 359);
            this.panel2.TabIndex = 16;
            // 
            // pbGo
            // 
            this.pbGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGo.Location = new System.Drawing.Point(120, 3);
            this.pbGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGo.Name = "pbGo";
            this.pbGo.Size = new System.Drawing.Size(32, 29);
            this.pbGo.TabIndex = 12;
            this.pbGo.TabStop = false;
            // 
            // tbGO
            // 
            this.tbGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbGO.Location = new System.Drawing.Point(6, 4);
            this.tbGO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGO.Name = "tbGO";
            this.tbGO.Size = new System.Drawing.Size(111, 24);
            this.tbGO.TabIndex = 11;
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelSearch.Controls.Add(this.pbGo);
            this.PanelSearch.Controls.Add(this.tbGO);
            this.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearch.Location = new System.Drawing.Point(0, 0);
            this.PanelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(172, 32);
            this.PanelSearch.TabIndex = 18;
            this.PanelSearch.Visible = false;
            // 
            // PanelLeftAll
            // 
            this.PanelLeftAll.AutoScroll = true;
            this.PanelLeftAll.Controls.Add(this.PanelSearch);
            this.PanelLeftAll.Controls.Add(this.tView);
            this.PanelLeftAll.Controls.Add(this.panel2);
            this.PanelLeftAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftAll.Location = new System.Drawing.Point(4, 21);
            this.PanelLeftAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelLeftAll.Name = "PanelLeftAll";
            this.PanelLeftAll.Size = new System.Drawing.Size(198, 359);
            this.PanelLeftAll.TabIndex = 30;
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "10002";
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.Head.ResumeLayout(false);
            this.ClientStatusStrip.ResumeLayout(false);
            this.ClientStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanderPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGo)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.PanelLeftAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip ClientStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel PanelLeftAll;
        public System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.PictureBox pbGo;
        private System.Windows.Forms.TextBox tbGO;
        private System.Windows.Forms.TreeView tView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ExpanderPictureBox;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Button button1;
    }
}

