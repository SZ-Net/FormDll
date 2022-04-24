using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLib
{
    /// <summary>
    /// 登录
    /// </summary>
    public partial class fmLogin : Form
    {
        private string userId;
        private string password;
        private bool loginACK = false;

        public string UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public bool LoginACK { get => loginACK; set => loginACK = value; }

        public fmLogin()
        {
            InitializeComponent();
        }

        //注册
        private void btnSignUp_Click(object sender, EventArgs e)
        {

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

            this.UserId = txtID.Text;
            this.Password = txtPwd.Text;

            if (true)
            {
               //DB check user
               this.loginACK = true;
                this.Close();
            }
            else
            {           
                MessageBox.Show("No matching member information.");
            }


        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null,null);
            }
        }
    }
}
