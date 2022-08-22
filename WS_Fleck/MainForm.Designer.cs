namespace WS_Fleck
{
    partial class MainForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvWebManager = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvClient = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConnectTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUIClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitter1.Location = new System.Drawing.Point(0, 272);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 10);
            this.splitter1.TabIndex = 61;
            this.splitter1.TabStop = false;
            // 
            // lvWebManager
            // 
            this.lvWebManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.lvWebManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvWebManager.FullRowSelect = true;
            this.lvWebManager.HideSelection = false;
            this.lvWebManager.Location = new System.Drawing.Point(0, 282);
            this.lvWebManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvWebManager.Name = "lvWebManager";
            this.lvWebManager.Size = new System.Drawing.Size(800, 168);
            this.lvWebManager.TabIndex = 60;
            this.lvWebManager.UseCompatibleStateImageBehavior = false;
            this.lvWebManager.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Log";
            this.columnHeader9.Width = 1000;
            // 
            // lvClient
            // 
            this.lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colIP,
            this.colPort,
            this.colConnectTime});
            this.lvClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClient.HideSelection = false;
            this.lvClient.Location = new System.Drawing.Point(0, 0);
            this.lvClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvClient.Name = "lvClient";
            this.lvClient.Size = new System.Drawing.Size(800, 450);
            this.lvClient.TabIndex = 59;
            this.lvClient.UseCompatibleStateImageBehavior = false;
            this.lvClient.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 200;
            // 
            // colIP
            // 
            this.colIP.Text = "Client IP";
            this.colIP.Width = 200;
            // 
            // colPort
            // 
            this.colPort.Text = "Client Port";
            this.colPort.Width = 120;
            // 
            // colConnectTime
            // 
            this.colConnectTime.Text = "Connect Time";
            this.colConnectTime.Width = 200;
            // 
            // lvUIClient
            // 
            this.lvUIClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvUIClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUIClient.HideSelection = false;
            this.lvUIClient.Location = new System.Drawing.Point(0, 0);
            this.lvUIClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvUIClient.Name = "lvUIClient";
            this.lvUIClient.Size = new System.Drawing.Size(800, 272);
            this.lvUIClient.TabIndex = 62;
            this.lvUIClient.UseCompatibleStateImageBehavior = false;
            this.lvUIClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client IP";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Client Port";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Connect Time";
            this.columnHeader4.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvUIClient);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lvWebManager);
            this.Controls.Add(this.lvClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lvWebManager;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvClient;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colIP;
        private System.Windows.Forms.ColumnHeader colPort;
        private System.Windows.Forms.ColumnHeader colConnectTime;
        private System.Windows.Forms.ListView lvUIClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

