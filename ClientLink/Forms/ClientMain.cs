using BaseLib;
using BaseLib.Tools;
using DLLClientLink.Handler;
using DLLClientLink.Mode;
using DLLClientLink.Properties;
using DLLClientLink.Resx;
using DLLClientLink.Tool;
using NHotkey;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;

namespace DLLClientLink
{
    public partial class ClientMain : DLLClientLink.Forms.BaseForm
    {
       
        private int lx;
        private int sx;
        private bool flag = false;

        private ArrayList MenuIDList = new ArrayList();
        private ArrayList CaptionList = new ArrayList();
        private ArrayList ParentList = new ArrayList();

        private ArrayList ListMainID = new ArrayList();
        private ArrayList ListMainCaption = new ArrayList();
        private ArrayList ListChildrenID = new ArrayList();
        private ArrayList ListOwnerParentID = new ArrayList();
        private ArrayList ListChildrenCaption = new ArrayList();

        #region Window 事件
        public ClientMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            
            GlobalData.processJob = new Job();
            Application.ApplicationExit += (sender, args) => { MyAppExit(); };
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            if (ConfigHandler.LoadConfig(ref config) != 0)
            {
                UI.ShowWarning($"Loading GUI configuration file is abnormal,please restart the application{Environment.NewLine}加载GUI配置文件异常,请重启应用");
                Environment.Exit(0);
                return;
            }
        }

        private void ClientMain_Shown(object sender, EventArgs e)
        {
            InitUI();
            MainFormHandler.Instance.RegisterGlobalHotkey(config, OnHotkeyHandler, UpdateTaskHandler);
        }

        private void InitUI()
        {
            this.Text = Utils.GetVersion();
            this.LocalIP.Text = $"IP: {Utils.GetClientIP()}";

            GlobalData.timer = new Timer();
            GlobalData.timer.Interval = 1000;
            GlobalData.timer.Tick += Timer_Tick;
            GlobalData.timer.Start();

            DllToLoadMenu(GlobalData.dllPath);
            // ShowForm("HslCommunicationDemo", "FormSelect");
        }

        private void MyAppExit()
        {
            try
            {
                Utils.SaveLog("MyAppExit Begin");
                ConfigHandler.SaveConfig(ref config);
                Utils.SaveLog("MyAppExit End");
            }
            catch { }
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

        private void DllToLoadMenu(string dllLocation)
        {
            int num = 0;
            CheckDll checkDll = new CheckDll();
            string[] array = null;
            tView.Nodes.Clear();
            MenuIDList.Clear();
            CaptionList.Clear();
            ParentList.Clear();

            array = Directory.GetFiles(dllLocation);
            for (int i = 0; i < array.Length; i++)
            {
                checkDll.SetDllFilePath(array[i]);
                ReturnResults returnResults = checkDll.Exec();
                if (returnResults.Status)
                {
                    num++;
                    ParentList.Add("");
                    MenuIDList.Add(num);
                    CaptionList.Add(returnResults.Anything.ToString());
                }
            }
            initializeTreeView(MenuIDList, CaptionList, ParentList);
        }

        private void initializeTreeView(ArrayList menuIDList, ArrayList menuCaptionList, ArrayList menuParentIDList)
        {
            int count = menuIDList.Count;
            this.dllCount.Text = "Dll Count: " + menuIDList.Count.ToString();
            ImgList.Images.Add(Resources.treeIcon);
            
            ImgList.ImageSize = new Size(22,22);
            tView.ImageList = ImgList;
            tView.ImageIndex = 0;
            for (int i = 0; i < count; i++)
            {
                if (menuParentIDList[i].ToString() == string.Empty)
                {
                    ListMainID.Add(menuIDList[i].ToString());
                    ListMainCaption.Add(menuCaptionList[i].ToString());
                }
                else
                {
                    ListChildrenID.Add(menuIDList[i].ToString());
                    ListOwnerParentID.Add(menuParentIDList[i].ToString());
                    ListChildrenCaption.Add(menuCaptionList[i].ToString());
                }
            }
            for (int j = 0; j < ListMainID.Count; j++)
            {
                TreeNode treeNode = new TreeNode();
                tView.Nodes.Add(treeNode);
                treeNode.Text = ListMainCaption[j].ToString();
                treeNode.SelectedImageKey = ListMainID[j].ToString();
                treeNode.ImageKey = ListMainID[j].ToString();
                treeNode.Tag = ListMainID[j].ToString();
            }
            for (int k = 0; k < tView.Nodes.Count; k++)
            {
                InitialNode(tView.Nodes[k]);
            }
        }

        private void InitialNode(TreeNode node)
        {
            for (int i = 0; i < ListChildrenID.Count; i++)
            {
                if (node.Tag.ToString() == ListOwnerParentID[i].ToString())
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = ListChildrenCaption[i].ToString();
                    treeNode.SelectedImageKey = ListChildrenID[i].ToString();
                    treeNode.ImageKey = ListChildrenID[i].ToString();
                    treeNode.Tag = ListChildrenID[i].ToString();
                    node.Nodes.Add(treeNode);
                }
            }
            for (int j = 0; j < node.Nodes.Count; j++)
            {
                InitialNode(node.Nodes[j]);
            }
        }

        private void ShowForm(string packageName, string frmName, bool downloadFlag = true)
        {
            Assembly assembly = null;
            Type type = null;
            object obj = null;
         
            bool flag = false;
            Form[] mdiChildren = base.MdiChildren;
            foreach (Form form in mdiChildren)
            {
                type = form.GetType();
                if (type.Namespace == packageName && form.Name == frmName)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.Activate();
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                return;
            }
            string text = Path.Combine(Application.StartupPath, "DllLib", packageName + ".dll");
            try
            {
               assembly = Assembly.LoadFrom(text);
                /* byte[] array = File.ReadAllBytes(text);
                assembly = Assembly.Load(array);*/
            }
            finally
            {
            }
            Type type2 = assembly.GetType(packageName + "." + frmName);
            if (type2 != null)
            {
                try
                {
                    obj = Activator.CreateInstance(type2);
                }
                catch (Exception)
                {
                    return;
                }
                finally
                {
                }
                PropertyInfo property = type2.GetProperty("MdiParent");
                property.SetValue(obj, this, null);

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
                MessageBox.Show($"Form: {frmName} doesn't exist");
            }
        }
        private void showForm(string ControlText)
        {
            object obj = null;
            Assembly assembly = null;
            bool flag = false;
            string treeSelectText = tView.SelectedNode.Text;
            string PackagePath = ((GlobalData.dllPath.LastIndexOf("\\") <= 2) ? (GlobalData.dllPath + "\\" + treeSelectText + ".dll") : (GlobalData.dllPath + treeSelectText + ".dll"));

            Form[] mdiChildren = MdiChildren;
            Type type = null;
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
                    flag = true;
                    break;
                }
            }
            if (flag)
                return;
            try
            {
                // Assembly.LoadFile只载入相应的dll文件;Assembly.LoadFrom 会载入dll文件及其引用的其他dll 
                assembly = Assembly.LoadFrom(PackagePath);
                /*byte[] array = File.ReadAllBytes(PackagePath);
                assembly = Assembly.Load(array);
                Console.WriteLine("1" + assembly.DefinedTypes.ToString());
                Console.WriteLine("2" + assembly.ExportedTypes.ToString());*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                // Log.WriteLog(Log.WriteExceptionMsg(e, string.Empty));
                GlobalData.textLogger.WriteText(e.ToString());
            }
            Type type2 = assembly.GetType(treeSelectText + "." + GlobalData.TypeName);
            if (type2 != null)
            {
                try
                {
                    obj = Activator.CreateInstance(type2);
                }
                catch (Exception)
                {
                    return;
                }
                finally
                {
                }
                PropertyInfo property = type2.GetProperty("MdiParent");
                property.SetValue(obj, this, null);

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

        #region 功能按钮
        private void pbGo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"doesn't exist");
        }
        private void Expander_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                lx = this.ExpanderPictureBox.Location.X;
                sx = PanelLeftAll.Size.Width;
                ExpanderPictureBox.Image = Resources.Expander;
                ExpanderPictureBox.Location = new Point(0, ExpanderPictureBox.Location.Y);
                PanelLeftAll.Size = new Size(ExpanderPictureBox.Size.Width, PanelLeftAll.Size.Height);
                flag = true;
            }
            else
            {
                ExpanderPictureBox.Image = Resources.Expander;
                ExpanderPictureBox.Location = new Point(lx, ExpanderPictureBox.Location.Y);
                PanelLeftAll.Size = new Size(sx, PanelLeftAll.Size.Height);
                flag = false;
            }
            Refresh();
        }
        private void menuItem_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            switch (menuItem.Text.ToString())
            {
                case "Login":
                    fmLogin fmLogin = new fmLogin();
                    fmLogin.ShowDialog();
                    if (fmLogin.LoginACK) {
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
                    BaseLib.Version version = new BaseLib.Version("About Client");
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

        private void MdiFormClose()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
        }

        private Process cur = null;
        private PerformanceCounter curpcp = null;
        private void Timer_Tick(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(ThreadPoolCheckVersion), null);
            
            if (curpcp != null)
            {
                string RamInfo = (curpcp.NextValue() / (1024 * 1024) ).ToString("F1") + "MB";
                this.RamValue.Text = "Ram: " + RamInfo;

            }
        }
        private void ThreadPoolCheckVersion(object state)
        {
            cur = Process.GetCurrentProcess();
            this.mainMsgControl1.AppendText(cur.ProcessName);
            curpcp = new PerformanceCounter("Process", "Working Set - Private", cur.ProcessName);
        }

        #region 托盘菜单
        // 托盘菜单-双击托盘图标
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
            WindowState = FormWindowState.Maximized;
        }
        // 托盘菜单-显示窗口
        private void tsMenuNotifyShow_Click(object sender, EventArgs e)
        {
            ShowForm();
            WindowState = FormWindowState.Maximized;
            
        }
        // 托盘菜单-退出
        private void tsMenuNotifyExit_Click(object sender, EventArgs e)
        {
            if (UI.ShowYesNo(ResUI.ExitSystem, ResUI.Tips) == DialogResult.Yes)
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

        private async void UpdateTaskHandler(bool success, string msg)
        {
        }
        

    }
}
