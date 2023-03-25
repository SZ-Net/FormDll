namespace Srvtools
{
	// Token: 0x0200005B RID: 91
	public partial class ErrorDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x0003A858 File Offset: 0x00038A58
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0003A890 File Offset: 0x00038A90
		private void InitializeComponent()
		{
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblStackTrace = new System.Windows.Forms.Label();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.btnSOrHStack = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.buttonServerInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(586, 342);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 46);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFeedback.Location = new System.Drawing.Point(744, 342);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(140, 46);
            this.btnFeedback.TabIndex = 1;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(44, 54);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(852, 240);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Location = new System.Drawing.Point(40, 22);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(126, 29);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message:";
            // 
            // lblStackTrace
            // 
            this.lblStackTrace.AutoSize = true;
            this.lblStackTrace.BackColor = System.Drawing.Color.Transparent;
            this.lblStackTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStackTrace.ForeColor = System.Drawing.Color.Maroon;
            this.lblStackTrace.Location = new System.Drawing.Point(40, 310);
            this.lblStackTrace.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStackTrace.Name = "lblStackTrace";
            this.lblStackTrace.Size = new System.Drawing.Size(84, 29);
            this.lblStackTrace.TabIndex = 4;
            this.lblStackTrace.Text = "Stack:";
            // 
            // txtStack
            // 
            this.txtStack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStack.Location = new System.Drawing.Point(44, 342);
            this.txtStack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStack.Multiline = true;
            this.txtStack.Name = "txtStack";
            this.txtStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStack.Size = new System.Drawing.Size(852, 254);
            this.txtStack.TabIndex = 5;
            // 
            // btnSOrHStack
            // 
            this.btnSOrHStack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSOrHStack.Location = new System.Drawing.Point(210, 342);
            this.btnSOrHStack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSOrHStack.Name = "btnSOrHStack";
            this.btnSOrHStack.Size = new System.Drawing.Size(160, 46);
            this.btnSOrHStack.TabIndex = 6;
            this.btnSOrHStack.Text = "Show Stack";
            this.btnSOrHStack.UseVisualStyleBackColor = true;
            this.btnSOrHStack.Click += new System.EventHandler(this.btnSOrHStack_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuit.Location = new System.Drawing.Point(52, 342);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(140, 46);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // buttonServerInfo
            // 
            this.buttonServerInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonServerInfo.Enabled = false;
            this.buttonServerInfo.Location = new System.Drawing.Point(388, 342);
            this.buttonServerInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonServerInfo.Name = "buttonServerInfo";
            this.buttonServerInfo.Size = new System.Drawing.Size(180, 46);
            this.buttonServerInfo.TabIndex = 8;
            this.buttonServerInfo.Text = "Server Stack";
            this.buttonServerInfo.UseVisualStyleBackColor = true;
            this.buttonServerInfo.Click += new System.EventHandler(this.buttonServerInfo_Click);
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 418);
            this.Controls.Add(this.buttonServerInfo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSOrHStack);
            this.Controls.Add(this.lblStackTrace);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtStack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Message";
            this.Load += new System.EventHandler(this.ErrorDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040002C2 RID: 706
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.Button btnFeedback;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.TextBox txtMessage;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.Label lblMessage;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.Label lblStackTrace;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.TextBox txtStack;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.Button btnSOrHStack;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.Button btnQuit;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.Button buttonServerInfo;
	}
}
