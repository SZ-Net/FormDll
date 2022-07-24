using DLLClientLink.Handler;
using DLLClientLink.Resx;
using DLLClientLink.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DLLClientLink
{
    public partial class SetUp : DLLClientLink.Forms.BaseForm
	{

        public SetUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region C#通过鼠标点击panel移动来控制无边框窗体移动
        Point point = new Point(-10, -10);
        bool mouseDown = false;
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            point = e.Location;

        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (point != e.Location)
                {
                    this.Location = new Point(this.Location.X + (e.Location.X - point.X), this.Location.Y + (e.Location.Y - point.Y));
                    Application.DoEvents();
                }
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Location = new Point(this.Location.X + (e.Location.X - point.X), this.Location.Y + (e.Location.Y - point.Y));
        }
        #endregion



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SaveGUI() != 0)
            {
                return;
            }

            if (ConfigHandler.SaveConfig(ref config) == 0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                UI.ShowWarning(ResUI.OperationFailed);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void SetUp_Load(object sender, EventArgs e)
        {
            InitGUI();
        }

        private void InitGUI()
        {
            //绑定枚举值
            cmbConnectionType.DataSource = System.Enum.GetNames(typeof(Mode.ConnectionType));
            cmbLoginType.DataSource = System.Enum.GetNames(typeof(Mode.LoginType));

            this.txtcurrentLanguage.Text = config.language.ToString();
            this.cmbConnectionType.Text = config.connectionType.ToString();
            this.cmbLoginType.Text = config.loginType.ToString();
            this.checkUpdateEnabled.Checked = config.checkUpdate;
            this.chklogEnabled.Checked = config.logEnabled;
            this.cmbloglevel.Text = config.loglevel;
            this.chkAutoRun.Checked = Utils.IsAutoRun();//开机自动启动
        }
        /// <summary>
        /// 保存GUI设置
        /// </summary>
        /// <returns></returns>
        private int SaveGUI()
        {
            //开机自动启动
            Utils.SetAutoRun(chkAutoRun.Checked);
            config.connectionType = (Mode.ConnectionType)Enum.Parse(typeof(Mode.ConnectionType), cmbConnectionType.SelectedItem.ToString(), false);
            config.loginType = (Mode.LoginType)Enum.Parse(typeof(Mode.LoginType), cmbLoginType.SelectedItem.ToString(), false);
            config.logEnabled = chklogEnabled.Checked;
            config.loglevel = config.loglevel;


            return 0;
        }

    }
}
