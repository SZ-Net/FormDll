
namespace Common
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.Footer = new System.Windows.Forms.GroupBox();
            this.LvMsg = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Body = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.Head = new System.Windows.Forms.Panel();
            this.HelpLinkButton = new System.Windows.Forms.Button();
            this.Footer.SuspendLayout();
            this.Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.LvMsg);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 281);
            this.Footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Footer.Size = new System.Drawing.Size(609, 106);
            this.Footer.TabIndex = 0;
            this.Footer.TabStop = false;
            // 
            // LvMsg
            // 
            this.LvMsg.BackColor = System.Drawing.SystemColors.Window;
            this.LvMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LvMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvMsg.FullRowSelect = true;
            this.LvMsg.HideSelection = false;
            this.LvMsg.Location = new System.Drawing.Point(4, 20);
            this.LvMsg.Name = "LvMsg";
            this.LvMsg.Size = new System.Drawing.Size(601, 83);
            this.LvMsg.TabIndex = 59;
            this.LvMsg.UseCompatibleStateImageBehavior = false;
            this.LvMsg.View = System.Windows.Forms.View.Details;
            this.LvMsg.SizeChanged += new System.EventHandler(this.LvMsg_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 80;
            // 
            // Body
            // 
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Body.Size = new System.Drawing.Size(609, 387);
            this.Body.TabIndex = 5;
            this.Body.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(609, 51);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.Color.Transparent;
            this.Head.BackgroundImage = global::Common.Properties.Resources.background;
            this.Head.Controls.Add(this.HelpLinkButton);
            this.Head.Controls.Add(this.Title);
            this.Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.Head.Location = new System.Drawing.Point(0, 0);
            this.Head.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(609, 51);
            this.Head.TabIndex = 3;
            // 
            // HelpLinkButton
            // 
            this.HelpLinkButton.AutoSize = true;
            this.HelpLinkButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpLinkButton.BackgroundImage = global::Common.Properties.Resources.helplink;
            this.HelpLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HelpLinkButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpLinkButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HelpLinkButton.FlatAppearance.BorderSize = 0;
            this.HelpLinkButton.ForeColor = System.Drawing.Color.Transparent;
            this.HelpLinkButton.Location = new System.Drawing.Point(561, 0);
            this.HelpLinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.HelpLinkButton.Name = "HelpLinkButton";
            this.HelpLinkButton.Size = new System.Drawing.Size(48, 51);
            this.HelpLinkButton.TabIndex = 5;
            this.HelpLinkButton.UseVisualStyleBackColor = false;
            this.HelpLinkButton.Click += new System.EventHandler(this.HelpLinkButton_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 387);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.Body);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Footer.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Footer;
        public System.Windows.Forms.GroupBox Body;
        public System.Windows.Forms.Panel pInfo;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Panel Head;
        private System.Windows.Forms.ListView LvMsg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button HelpLinkButton;
    }
}

