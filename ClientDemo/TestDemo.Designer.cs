
namespace ClientDemo
{
    partial class TestDemo
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
            this.userControlHead1 = new svr.UserControls.UserControlHead();
            this.visualStudioToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.dateTimePicker1 = new svr.UserControls.DateTimePicker();
            this.SuspendLayout();
            // 
            // userControlHead1
            // 
            this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlHead1.Location = new System.Drawing.Point(0, 0);
            this.userControlHead1.Name = "userControlHead1";
            this.userControlHead1.ProtocolInfo = "******";
            this.userControlHead1.Size = new System.Drawing.Size(800, 55);
            this.userControlHead1.SupportListVisiable = true;
            this.userControlHead1.TabIndex = 0;
            // 
            // visualStudioToolStripExtender1
            // 
            this.visualStudioToolStripExtender1.DefaultRenderer = null;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Location = new System.Drawing.Point(69, 106);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(427, 266);
            this.dockPanel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DtpFrom = new System.DateTime(2022, 3, 26, 23, 46, 45, 949);
            this.dateTimePicker1.DtpTo = new System.DateTime(2022, 3, 26, 23, 46, 45, 949);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // TestDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.userControlHead1);
            this.Name = "TestDemo";
            this.Text = "TestDemo";
            this.Load += new System.EventHandler(this.TestDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private svr.UserControls.UserControlHead userControlHead1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender visualStudioToolStripExtender1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private svr.UserControls.DateTimePicker dateTimePicker1;
    }
}