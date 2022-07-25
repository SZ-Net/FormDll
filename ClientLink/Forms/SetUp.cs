using DLLClientLink.Handler;
using DLLClientLink.Mode;
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
        List<KeyEventItem> lstKey;
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
            InitShortcutKey();
            InitGUI();
        }

        private void InitShortcutKey()
        {
            if (config.globalHotkeys == null)
            {
                config.globalHotkeys = new List<KeyEventItem>();
            }

            foreach (GlobalHotkey it in Enum.GetValues(typeof(GlobalHotkey)))
            {
                if (config.globalHotkeys.FindIndex(t => t.GlobalHotkey == it) >= 0)
                {
                    continue;
                }

                config.globalHotkeys.Add(new KeyEventItem()
                {
                    GlobalHotkey = it,
                    Alt = false,
                    Control = false,
                    Shift = false,
                    KeyCode = null
                });
            }

            lstKey = Utils.DeepCopy(config.globalHotkeys);

            txtGlobalHotkey0.KeyDown += TxtGlobalHotkey_KeyDown;
            txtGlobalHotkey1.KeyDown += TxtGlobalHotkey_KeyDown;


            BindingData(-1);
        }

        private void BindingData(int v)
        {
            for (int k = 0; k < lstKey.Count; k++)
            {
                if (v >= 0 && v != k)
                {
                    continue;
                }
                var item = lstKey[k];
                var keys = string.Empty;

                if (item.Control)
                {
                    keys += $"{Keys.Control.ToString()} + ";
                }
                if (item.Alt)
                {
                    keys += $"{Keys.Alt.ToString()} + ";
                }
                if (item.Shift)
                {
                    keys += $"{Keys.Shift.ToString()} + ";
                }
                if (item.KeyCode != null)
                {
                    keys += $"{item.KeyCode.ToString()}";
                }

                Panel_ShortcutKey.Controls[$"txtGlobalHotkey{k}"].Text = keys;
            }
        }

        private void TxtGlobalHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = ((TextBox)sender);
            var index = Utils.ToInt(txt.Name.Substring(txt.Name.Length - 1, 1));

            lstKey[index].KeyCode = e.KeyCode;
            lstKey[index].Alt = e.Alt;
            lstKey[index].Control = e.Control;
            lstKey[index].Shift = e.Shift;

            BindingData(index);
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

            config.globalHotkeys = lstKey;

            return 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstKey.Clear();
            foreach (GlobalHotkey it in Enum.GetValues(typeof(GlobalHotkey)))
            {
                if (lstKey.FindIndex(t => t.GlobalHotkey == it) >= 0)
                {
                    continue;
                }

                lstKey.Add(new KeyEventItem()
                {
                    GlobalHotkey = it,
                    Alt = false,
                    Control = false,
                    Shift = false,
                    KeyCode = null
                });
            }
            BindingData(-1);
        }
    }
}
