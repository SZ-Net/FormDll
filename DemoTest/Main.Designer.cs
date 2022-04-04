
namespace DemoTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new svr.UserControls.DateTimePicker();
            this.Body.SuspendLayout();
            this.Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 434);
            this.Footer.Size = new System.Drawing.Size(800, 106);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.dateTimePicker1);
            this.Body.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DtpFrom = new System.DateTime(2022, 4, 3, 18, 33, 56, 62);
            this.dateTimePicker1.DtpTo = new System.DateTime(2022, 4, 3, 18, 33, 56, 62);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 35);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "测试";
            this.Body.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private svr.UserControls.DateTimePicker dateTimePicker1;
    }
}

