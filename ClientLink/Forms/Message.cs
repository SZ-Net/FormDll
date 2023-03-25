using ClientLink.Base;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClientLink.Forms
{
    public partial class Message : UserControl
    {
        private string _msgFilter = string.Empty;
        delegate void AppendTextDelegate(string text);

        public Message()
        {
            InitializeComponent();
        }

        private void MainMsgControl_Load(object sender, EventArgs e)
        {

        }

        #region 提示信息

        public void AppendText(string text)
        {
            if (txtMsgBox.InvokeRequired)
            {
                Invoke(new AppendTextDelegate(AppendText), text);
            }
            else
            {
                if (!Utils.IsNullOrEmpty(_msgFilter))
                {
                    if (!Regex.IsMatch(text, _msgFilter))
                    {
                        return;
                    }
                }
                //this.txtMsgBox.AppendText(text);
                ShowMsg(text);
            }
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMsg(string msg)
        {
            if (txtMsgBox.Lines.Length > 999)
            {
                ClearMsg();
            }
            txtMsgBox.AppendText(msg);
            if (!msg.EndsWith(Environment.NewLine))
            {
                txtMsgBox.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// 清除信息
        /// </summary>
        public void ClearMsg()
        {
            txtMsgBox.Invoke((Action)delegate
            {
                txtMsgBox.Clear();
            });
        }


        public void ScrollToCaret()
        {
            txtMsgBox.ScrollToCaret();
        }
        #endregion


        #region MsgBoxMenu
        private void menuMsgBoxSelectAll_Click(object sender, EventArgs e)
        {
            txtMsgBox.Focus();
            txtMsgBox.SelectAll();
        }

        private void menuMsgBoxCopy_Click(object sender, EventArgs e)
        {
            var data = txtMsgBox.SelectedText.TrimEx();
            Utils.SetClipboardData(data);
        }

        private void menuMsgBoxCopyAll_Click(object sender, EventArgs e)
        {
            var data = txtMsgBox.Text;
            Utils.SetClipboardData(data);
        }
        private void menuMsgBoxClear_Click(object sender, EventArgs e)
        {
            txtMsgBox.Clear();
        }


        private void txtMsgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        menuMsgBoxSelectAll_Click(null, null);
                        break;
                    case Keys.C:
                        menuMsgBoxCopy_Click(null, null);
                        break;

                }
            }

        }

        private void ssMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (!Utils.IsNullOrEmpty(e.ClickedItem.Text))
            {
                Utils.SetClipboardData(e.ClickedItem.Text);
            }
        }
        #endregion


    }
}
