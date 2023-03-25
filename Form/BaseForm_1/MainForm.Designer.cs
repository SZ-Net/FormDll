namespace BaseForm_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lvServers = new BaseLib.Base.ListViewFlickerFree();
            this.Body.SuspendLayout();
            this.Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 307);
            this.Footer.Size = new System.Drawing.Size(800, 143);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.lvServers);
            this.Body.Controls.Add(this.button1);
            this.Body.Size = new System.Drawing.Size(800, 450);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(800, 51);
            // 
            // Head
            // 
            this.Head.Size = new System.Drawing.Size(800, 51);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvServers
            // 
            this.lvServers.HideSelection = false;
            this.lvServers.Location = new System.Drawing.Point(142, 70);
            this.lvServers.Name = "lvServers";
            this.lvServers.Size = new System.Drawing.Size(654, 234);
            this.lvServers.TabIndex = 1;
            this.lvServers.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Body.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BaseLib.Base.ListViewFlickerFree lvServers;
    }
}

