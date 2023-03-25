using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    /// <summary>
    /// 登录
    /// </summary>
    public partial class fmLogin : Form
    {
        public UserInfo userInfo =new UserInfo();

        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //TODO 注册
        }

        //单击取消按钮时发生的事件
        private void XorCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Please enter your identity and password.");
                return;
            }
            //TODO user validate
            this.userInfo= new UserInfo() { 
                UserName= txtID.Text,
                Password= txtPwd.Text,
                IsState= true,
                Description= txtID.Text,
            };
            this.Close();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null,null);
            }
        }
    }

    public class UserInfo
    {
        public string UserName;
        public string Password;
        public bool IsState = false;
        public string Description;
    }
}
