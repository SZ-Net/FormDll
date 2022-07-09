using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VncSharp;

namespace WinRemoteDesktop
{
    public partial class FormVNC : Form
    {
        public string ip;
        public int port;
        public string password;
        public FormVNC()
        {
            InitializeComponent();
        }
        public string GetPassword()
        {
            return  this.password;
        }
        private void FormVNC_Load(object sender, EventArgs e)
        {
             

            try
            {
                VncSharp.AuthenticateDelegate p = new VncSharp.AuthenticateDelegate(GetPassword);
                remoteDesktop1.GetPassword = p;
                remoteDesktop1.VncPort = Convert.ToInt32(port);
                remoteDesktop1.Connect(ip, false, true);
                
            }
            catch (VncProtocolException vex)
            {

                MessageBox.Show(this,
                                    string.Format("Unable to connect to VNC host:\n\n{0}.\n\nCheck that a VNC host is running there.", vex.Message),
                                    string.Format("Unable to Connect to {0}", ip),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                                    string.Format("Unable to connect to host.  Error was: {0}", ex.Message),
                                    string.Format("Unable to Connect to {0}", ip),
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                this.Close();
            }

        }


        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.Disconnect();
            this.Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            // If the user tries to close the window without doing a clean
            // shutdown of the remote connection, do it for them.
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.Disconnect();

            base.OnClosing(e);
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将本地剪贴板的内容复制到服务器的剪贴板中
            //以便粘贴。只适用于文本。
            if (remoteDesktop1.IsConnected)
            {
                remoteDesktop1.FillServerClipboard();

                MessageBox.Show(this,
                                "Your clipboard's text was copied to the remote host.",
                                "Clipboard Copied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
        }
        #region 快捷键
        private void cTRLALTDELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SendSpecialKeys(SpecialKeys.CtrlAltDel);
        }


        private void aLTF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SendSpecialKeys(SpecialKeys.AltF4);
        }

        private void cTRLESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SendSpecialKeys(SpecialKeys.CtrlEsc);
        }

        private void cTRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SendSpecialKeys(SpecialKeys.Ctrl, false /* don't release CTRL */);
        }

        private void aLTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SendSpecialKeys(SpecialKeys.Alt, false /* don't release ALT */);
        }


        #endregion

        private void clippedViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭缩放并使用剪裁
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SetScalingMode(false);
        }

        private void scaledViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 关闭剪裁并使用缩放
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.SetScalingMode(true);
        }

        private void fullScreenRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 请求全屏更新（通常会发送增量更新）
            if (remoteDesktop1.IsConnected)
                remoteDesktop1.FullScreenUpdate();
        }


    }
}
