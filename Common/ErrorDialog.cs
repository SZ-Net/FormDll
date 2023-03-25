using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Common
{
	public partial class ErrorDialog : Form
	{
		public ErrorDialog()
		{
			this.InitializeComponent();
		}
		public ErrorDialog(string errMessage, string stackTrace, string serverTrace)
		{
			this.InitializeComponent();
			this.txtMessage.Text = errMessage;
			this.txtStack.Text = stackTrace;
			this._errMessage = errMessage;
			this._stack = stackTrace;
			this._serverstack = serverTrace;
		}
		public bool IsFeedback
		{
			get
			{
				return this._isFeedback;
			}
			set
			{
				this._isFeedback = value;
			}
		}
		public string ErrDescrip
		{
			get
			{
				return this._errDescrip;
			}
			set
			{
				this._errDescrip = value;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnFeedback_Click(object sender, EventArgs e)
		{
			//TODO Mail Feedback
			base.Close();
		}

		private void ErrorDialog_Load(object sender, EventArgs e)
		{
			this.lblStackTrace.Hide();
			this.txtStack.Hide();
		}

		private void txtMessage_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.txtMessage.Text == null || this.txtMessage.Text.Length == 0;
			if (flag)
			{
				this.btnFeedback.Enabled = false;
			}
			else
			{
				this.btnFeedback.Enabled = true;
			}
		}

		private void btnSOrHStack_Click(object sender, EventArgs e)
		{
			bool flag = string.Compare(this.btnSOrHStack.Text, "show stack", true) == 0;
			if (flag)
			{
				base.Height = this.txtStack.Location.Y + this.txtStack.Height + 4 * this.btnFeedback.Height;
				this.lblStackTrace.Show();
				this.txtStack.Show();
				this.btnSOrHStack.Text = "Hide Stack";
				this.buttonServerInfo.Enabled = true;
			}
			else
			{
				base.Height = this.txtMessage.Location.Y + this.txtMessage.Height + 4 * this.btnFeedback.Height;
				this.txtMessage.Show();
				this.lblStackTrace.Hide();
				this.txtStack.Hide();
				this.btnSOrHStack.Text = "Show Stack";
				this.buttonServerInfo.Enabled = false;
			}
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			try
			{
				//TODO
			}
			catch (Exception ex)
			{
				bool flag = ex is WebException && (ex as WebException).Status == WebExceptionStatus.ConnectFailure;
				if (flag)
				{
					Application.Exit();
				}
			}
			Application.Exit();
		}


		private void buttonServerInfo_Click(object sender, EventArgs e)
		{
			bool flag = string.Compare(this.btnSOrHStack.Text, "hide stack", true) == 0;
			if (flag)
			{
				this.txtStack.Text = ((string.Compare(this.buttonServerInfo.Text, "server stack", true) == 0) ? this._serverstack : this._stack);
				this.buttonServerInfo.Text = ((string.Compare(this.buttonServerInfo.Text, "server stack", true) == 0) ? "Client Stack" : "Server Stack");
			}
		}

		private string _errMessage;

		private string _stack;

		private string _serverstack;

		private bool _isFeedback;

		private string _errDescrip;
	}
}
