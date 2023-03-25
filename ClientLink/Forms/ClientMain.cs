
using ClientLink.Handler;
using ClientLink.Mode;
using ClientLink.Model;
using ClientLink.Properties;
using ClientLink.Resx;
using NHotkey;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ClientLink
{
    public partial class ClientMain : Forms.BaseForm
    {

        private int lx;
        private int sx;
        private List<MenuList> MenuTree = new List<MenuList>();

        #region Window 事件

        /// <summary>
        ///  C# Winform 窗体打开时闪烁问题
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        public ClientMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            try
            {
                TEST();
                InitMenuTreeViewData();
                InitStatusBar();
                MainFormHandler.Instance.RegisterGlobalHotkey(config, OnHotkeyHandler, UpdateTaskHandler); //快捷键
            }
            catch (Exception ex)
            {
                this.mainMsgControl1.AppendText(ex.ToString());
            }
        }
        private void OnHotkeyHandler(object sender, HotkeyEventArgs e)
        {
            switch (Utils.ToInt(e.Name))
            {
                case (int)GlobalHotkey.ShowForm:
                    if (ShowInTaskbar) HideForm(); else ShowForm();
                    break;
                case (int)GlobalHotkey.JumpBrowser:
                    Process.Start($"{GlobalData.PromotionUrl}?t={DateTime.Now.Ticks}");
                    break;

            }
            e.Handled = true;
        }

        private void ClientMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    break;
                case CloseReason.ApplicationExitCall:
                case CloseReason.FormOwnerClosing:
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    Utils.SaveLog("MyAppExit Begin");
                    ConfigHandler.SaveConfig(ref config);
                    Utils.SaveLog("MyAppExit End");
                    break;
            }
        }

        private void ClientMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideForm();
            }
        }

        #endregion

        #region 托盘菜单
        /// <summary>
        /// 托盘菜单-双击托盘图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
            WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 托盘菜单-显示窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsMenuNotifyShow_Click(object sender, EventArgs e)
        {
            ShowForm();
            WindowState = FormWindowState.Maximized;

        }
        /// <summary>
        /// 托盘菜单-退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsMenuNotifyExit_Click(object sender, EventArgs e)
        {
            if (MessageBoxUI.ShowYesNo(ResUI.ExitSystem, ResUI.Tips) == DialogResult.Yes)
            {
                MdiFormClose();
                Application.ExitThread();
                Application.Exit();
            }
        }

        private void ShowForm()
        {
            Show();
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            //Activate();
            ShowInTaskbar = true;
            mainMsgControl1.ScrollToCaret();
            SetVisibleCore(true);
            this.MainMenu.GetForm().Show();
        }

        private void HideForm()
        {
            //Hide(); // 隐藏当前窗体 mid 有bug
            ShowInTaskbar = false;
            SetVisibleCore(false);

            //write Handle to reg
            if (IsHandleCreated)
            {
                Utils.RegWriteValue(GlobalData.MyRegPath, Utils.WindowHwndKey, Convert.ToString((long)Handle));
            }
        }

        #endregion

        #region 功能按钮
        private void pbGo_Click(object sender, EventArgs e)
        {
            try
            {
                string controlText = this.MenuTree.Where(x => x.Name == this.tbSearch.Text).Select(m => m.Path).Distinct().SingleOrDefault();
                if (!string.IsNullOrEmpty(controlText))
                {
                    showForm(controlText);
                }
                else
                {
                    MessageBox.Show($"doesn't exist");
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"doesn't exist");
            }


        }
        private void Expander_Click(object sender, EventArgs e)
        {
            bool ExpanderFlag = false;
            if (!ExpanderFlag)
            {
                lx = this.ExpanderPictureBox.Location.X;
                sx = PanelLeftAll.Size.Width;
                ExpanderPictureBox.Image = Resources.Expander;
                ExpanderPictureBox.Location = new Point(0, ExpanderPictureBox.Location.Y);
                PanelLeftAll.Size = new Size(ExpanderPictureBox.Size.Width, PanelLeftAll.Size.Height);
                ExpanderFlag = true;
            }
            else
            {
                ExpanderPictureBox.Image = Resources.Expander;
                ExpanderPictureBox.Location = new Point(lx, ExpanderPictureBox.Location.Y);
                PanelLeftAll.Size = new Size(sx, PanelLeftAll.Size.Height);
                ExpanderFlag = false;
            }
            Refresh();
        }
        private void menuItem_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            switch (menuItem.Text.ToString())
            {
                case "Login":
                    Common.fmLogin fmLogin = new Common.fmLogin();
                    fmLogin.ShowDialog();
                    if (fmLogin.LoginACK)
                    {
                        this.User.Text = fmLogin.UserId;
                        fmLogin.Close();
                    }
                    break;
                case "SetUp":
                    SetUp setUp = new SetUp();
                    setUp.ShowDialog();
                    break;
                case "Exit":
                    System.Environment.Exit(0);
                    break;

                case "About Client":
                    Common.Version version = new Common.Version("About Client");
                    version.ShowDialog(this);
                    break;
                case "Cascade":
                    LayoutMdi(MdiLayout.Cascade);
                    break;
                case "TileHorizontal":
                    LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "TileVertical":
                    LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "Language-[English]":
                    SetCurrentLanguage("en");
                    break;
                case "语言-[中文简体]":
                    SetCurrentLanguage("zh-Hans");
                    break;
                case "ShowLog":
                    bool bShow = ShowLog.Checked; //Panel2Collapsed
                    MsgPanel.Visible = !bShow;
                    ShowLog.Checked = !bShow;
                    break;

            }
        }
        private void SetCurrentLanguage(string value)
        {
            Utils.RegWriteValue(GlobalData.MyRegPath, GlobalData.MyRegKeyLanguage, value);
            //Application.Restart();
        }
        private void tView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tView.SelectedNode != null && tView.SelectedNode.GetNodeCount(includeSubTrees: true) == 0)
            {
                string controlText = ((TreeView)sender).SelectedNode.Tag.ToString();
                showForm(controlText);
            }
        }

        #endregion

        private void TEST()
        {

            GlobalData.processJob = new Job();

            if (ConfigHandler.LoadConfig(ref config) != 0)
            {
                MessageBoxUI.ShowWarning($"Loading GUI configuration file is abnormal,please restart the application{Environment.NewLine}加载GUI配置文件异常,请重启应用");
                Environment.Exit(0);
                return;
            }

            Start();


            GlobalData.timer = new System.Timers.Timer()
            {
                Interval = 1000 * 10,
                AutoReset = true,
            };
            GlobalData.timer.Elapsed += (sender, args) =>
            {
                Utiliyt.SimpleLogHelper.Debug("System.Timers.Timer().");
                GlobalData.timer.Interval = 1000 * 10; // next time check,  eta *..
                Timer_Tick();
            };
            GlobalData.timer.Start();

        }
        private void InitMenuTreeViewData()
        {
            try
            {
                tView.Nodes.Clear();
                string[] array = Directory.GetFiles(GlobalData.dllPath);

                for (int i = 0; i < array.Length; i++)
                {
                    string text = array[i].Substring(array[i].LastIndexOf('\\') + 1);
                    string[] arraySplit = text.Split('.');
                    if (arraySplit.AsQueryable().Last().ToUpper() == "DLL")
                    {
                        Assembly assembly = null;
                        if (GlobalData.LoadInMemory)
                        {
                            //首先把dll加载到内存中,然后在在加载成Assembly ,这样的话,dll完全跟程序解耦了,只要加载完成,你就是把dll给删除了,程序也一样照常运行。
                            assembly = Assembly.Load(File.ReadAllBytes(array[i]));
                        }
                        else
                        {
                            // Assembly.LoadFile只载入相应的dll文件;Assembly.LoadFrom 会载入dll文件及其引用的其他dll
                            assembly = Assembly.LoadFile(array[i]);
                        }


                        string ruleName = arraySplit[0] + $".{GlobalData.TypeName}";
                        Type type = assembly.GetType(ruleName);
                        if (type != null)
                        {

                            this.MenuTree.Add(new MenuList()
                            {
                                Guid = Guid.NewGuid(),
                                Name = text.Substring(0, text.LastIndexOf('.')),
                                Path = array[i],
                                Description = array[i],
                            });
                        }
                        else
                        {
                            this.mainMsgControl1.AppendText("Assembly content is not acceptable. It must be named " + array[i]);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                this.mainMsgControl1.AppendText(ex.ToString());
            }
            finally
            {
                object a = this.MenuTree;
                initializeTreeView();
            }

        }
        private void initializeTreeView()
        {
            ImgList.Images.Add(Resources.treeIcon);
            ImgList.ImageSize = new Size(22, 22);
            tView.ImageList = ImgList;
            tView.ImageIndex = 0;
            foreach (var item in this.MenuTree)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = item.Name;
                treeNode.SelectedImageKey = item.Guid.ToString();
                treeNode.ImageKey = item.Guid.ToString();
                treeNode.Tag = item.Description;
                tView.Nodes.Add(treeNode);
            }
        }
        private void InitStatusBar()
        {
            this.Text = Utils.GetVersion();
            this.ClientStatusStrip.Items["LocalIP"].Text = $"IP: {Utils.GetClientIP()}";
            this.ClientStatusStrip.Items["dllCount"].Text = $"Count: " + MenuTree.Count.ToString();
        }
        private void showForm(string ControlText)
        {
            Assembly assembly = null;
            Form[] mdiChildren = this.MdiChildren;
            Type type = null;
            object obj = null;
            bool activate = false;
            string treeSelectText = tView.SelectedNode.Text;
            string PackagePath = ControlText;

            try
            {
                foreach (Form form in mdiChildren)
                {
                    type = form.GetType();
                    if (type.Namespace == treeSelectText && type.Name == GlobalData.TypeName)
                    {
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                        // form.WindowState = FormWindowState.Maximized; //最大化
                        form.Activate(); //激活该窗口
                        activate = true;
                        break;
                    }
                }
                if (activate)
                    return;

                assembly = Assembly.LoadFrom(PackagePath);

                Type type2 = assembly.GetType(treeSelectText + "." + GlobalData.TypeName);
                if (type2 != null)
                {
                    //使用与指定参数匹配程度最高的构造函数来创建指定类型的实例
                    obj = Activator.CreateInstance(type2);

                    PropertyInfo property = type2.GetProperty("MdiParent");
                    property.SetValue(obj, this, null);
                    ((Form)obj).FormClosed += InternalFormClosed; // bug 释放资源

                    ((Control)obj).Show();
                    if (((Form)obj).WindowState == FormWindowState.Maximized)
                    {
                        ((Form)obj).Hide();
                        ((Form)obj).WindowState = FormWindowState.Normal;
                        ((Form)obj).WindowState = FormWindowState.Maximized;
                        ((Form)obj).Show();
                    }
                }
                else
                {
                    MessageBox.Show($"Form: doesn't exist");
                }
            }
            catch (Exception ex)
            {
                this.mainMsgControl1.AppendText(ex.ToString());
            }

        }
        private void InternalFormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Form infoForm = (Form)sender;
                infoForm.Dispose();
            }
            catch (Exception ex)
            {
                this.mainMsgControl1.AppendText(ex.ToString());
            }
        }

        private void MdiFormClose()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
        }

        private Process cur = null;
        private PerformanceCounter curpcp = null;
        private void Timer_Tick()
        {
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(ThreadPoolCheckVersion), null);

            if (curpcp != null)
            {
                string RamInfo = (curpcp.NextValue() / (1024 * 1024)).ToString("F1") + "MB";
                this.RamValue.Text = "Ram: " + RamInfo;

            }
        }
        private void ThreadPoolCheckVersion(object state)
        {
            cur = Process.GetCurrentProcess();
            this.mainMsgControl1.AppendText(cur.ProcessName);
            curpcp = new PerformanceCounter("Process", "Working Set - Private", cur.ProcessName);
        }


        private async void UpdateTaskHandler(bool success, string msg)
        {
        }


        private void Start()
        {

            try
            {
                string fileName = Utils.GetPath("mail.exe");
                if (fileName == "") return;

                Process p = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = fileName,
                        Arguments = "",
                        WorkingDirectory = Utils.StartupPath(),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        StandardOutputEncoding = Encoding.UTF8
                    }
                };
                p.OutputDataReceived += (sender, e) =>
                {
                    if (!String.IsNullOrEmpty(e.Data))
                    {
                        string msg = e.Data + Environment.NewLine;
                    }
                };
                p.Start();
                p.PriorityClass = ProcessPriorityClass.High;
                p.BeginOutputReadLine();
                //processId = p.Id;
                Process _process = p;

                if (p.WaitForExit(1000))
                {
                    throw new Exception(p.StandardError.ReadToEnd());
                }

                GlobalData.processJob.AddProcess(p.Handle);
            }
            catch (Exception ex)
            {
                Utils.SaveLog(ex.Message, ex);
                string msg = ex.Message;
            }
        }


    }
}
