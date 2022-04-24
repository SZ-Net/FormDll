namespace BaseLib
{
    partial class BaseForm1
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
            this.prgMain = new System.Windows.Forms.GroupBox();
            this.prgFooter = new System.Windows.Forms.GroupBox();
            this.prgMSG = new System.Windows.Forms.Label();
            this.prgTitle = new System.Windows.Forms.Label();
            this.prgBanner = new System.Windows.Forms.Panel();
            this.prgFooter.SuspendLayout();
            this.prgBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgMain
            // 
            this.prgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgMain.Location = new System.Drawing.Point(0, 51);
            this.prgMain.Margin = new System.Windows.Forms.Padding(4);
            this.prgMain.Name = "prgMain";
            this.prgMain.Padding = new System.Windows.Forms.Padding(4);
            this.prgMain.Size = new System.Drawing.Size(443, 220);
            this.prgMain.TabIndex = 9;
            this.prgMain.TabStop = false;
            // 
            // prgFooter
            // 
            this.prgFooter.Controls.Add(this.prgMSG);
            this.prgFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgFooter.Location = new System.Drawing.Point(0, 271);
            this.prgFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.prgFooter.Name = "prgFooter";
            this.prgFooter.Padding = new System.Windows.Forms.Padding(4);
            this.prgFooter.Size = new System.Drawing.Size(443, 53);
            this.prgFooter.TabIndex = 6;
            this.prgFooter.TabStop = false;
            // 
            // prgMSG
            // 
            this.prgMSG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgMSG.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prgMSG.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prgMSG.Location = new System.Drawing.Point(4, 21);
            this.prgMSG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.prgMSG.Name = "prgMSG";
            this.prgMSG.Size = new System.Drawing.Size(435, 28);
            this.prgMSG.TabIndex = 0;
            this.prgMSG.Text = "Message";
            this.prgMSG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prgTitle
            // 
            this.prgTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgTitle.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prgTitle.ForeColor = System.Drawing.Color.Black;
            this.prgTitle.Location = new System.Drawing.Point(0, 0);
            this.prgTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prgTitle.Name = "prgTitle";
            this.prgTitle.Size = new System.Drawing.Size(443, 51);
            this.prgTitle.TabIndex = 0;
            this.prgTitle.Text = "Title";
            this.prgTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prgBanner
            // 
            this.prgBanner.BackColor = System.Drawing.Color.Transparent;
            this.prgBanner.BackgroundImage = global::BaseLib.Properties.Resources.background;
            this.prgBanner.Controls.Add(this.prgTitle);
            this.prgBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgBanner.Location = new System.Drawing.Point(0, 0);
            this.prgBanner.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.prgBanner.Name = "prgBanner";
            this.prgBanner.Size = new System.Drawing.Size(443, 51);
            this.prgBanner.TabIndex = 8;
            // 
            // BaseForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 324);
            this.Controls.Add(this.prgMain);
            this.Controls.Add(this.prgFooter);
            this.Controls.Add(this.prgBanner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm1";
            this.Text = "BaseForm1";
            this.prgFooter.ResumeLayout(false);
            this.prgBanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox prgMain;
        public System.Windows.Forms.GroupBox prgFooter;
        public System.Windows.Forms.Label prgMSG;
        public System.Windows.Forms.Label prgTitle;
        public System.Windows.Forms.Panel prgBanner;
    }
}