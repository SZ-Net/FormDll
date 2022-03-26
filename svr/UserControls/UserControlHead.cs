using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svr.UserControls
{
	public partial class UserControlHead : UserControl
	{
		public UserControlHead()
		{
			InitializeComponent();
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(linkLabel1.Text);
			}
			catch (Exception ex)
			{
				
			}
		}

		private void UserControlHead_Load(object sender, EventArgs e)
		{

				//label2.Visible = false;
				//linkLabel1.Visible = false;
		

			//BackColor = FormSelect.ThemeColor;
		}

		[Browsable(true)]
		[Category("github/naiop")]
		[DefaultValue("https://github.com/naiop")]
		public string HelpLink
		{
			get => linkLabel1.Text;
			set
			{
				linkLabel1.Text = value;
			}
		}


		[Browsable(true)]
		[Category("github/naiop")]
		[DefaultValue("naiop")]
		public string ProtocolInfo
		{
			get => label5.Text;
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					label4.Visible = false;
				}
				else
				{
					label4.Visible = true;
				}
				label5.Text = value;
			}
		}

		[Browsable(true)]
		[Category("github/naiop")]
		[DefaultValue(false)]
		public bool SupportListVisiable
		{
			get => linkLabel3.Visible;
			set => linkLabel3.Visible = value;
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (SaveConnectEvent == null)
			{
				MessageBox.Show(new NotImplementedException().Message);
				return;
			}
			SaveConnectEvent?.Invoke(sender, new EventArgs());
		}

		public event EventHandler<EventArgs> SaveConnectEvent;

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (SaveConnectEvent == null)
			{
				MessageBox.Show(new NotImplementedException().Message);
				return;
			}
			SaveConnectEvent?.Invoke(sender, new EventArgs());
		}
	}
}
