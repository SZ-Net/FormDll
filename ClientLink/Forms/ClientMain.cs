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

        public ClientMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            Text = Utils.GetVersion();
           

        }
        /// <summary>
        ///  C# Winform 窗体打开时闪烁问题
        ///  主要原因是对于Winform来说，一个窗体中绘制多个控件是很花时间的。特别是默认的按钮控件。Form先画出背景，然后留下控件需要的“洞”。如果控件的背景是透明的，那么这些“洞”就会先以白色或黑色出现，然后每个控件的“洞”再被填充，就是我们所看到的闪烁，在WinForm中没有现成的解决方案。设置控件双缓冲并不能解决它，因为它只适用于自己，而不是复合控件集。
        ///  protected 受保护的，只有本类及继承的子类可以访问。
        ///  override 复写, 对父类中的相同名称的方法重新其修改内容。
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
        private void ClientMain_Load(object sender, EventArgs e)
        {
            if (ConfigHandler.LoadConfig(ref config) != 0)
            {
                UI.ShowWarning($"Loading GUI configuration file is abnormal,please restart the application{Environment.NewLine}加载GUI配置文件异常,请重启应用");
                Environment.Exit(0);
                return;
            }


            this.LocalIP.Text = "IP: " + GetClientIP();
            timer = new Timer();
            timer.Interval = 1000;
            //timer.Tick += Timer_Tick;
            timer.Start();

            division(25, 0);
            DllToLoadMenu(GlobalData.dllPath);
           // ShowForm("HslCommunicationDemo", "FormSelect");
        }


        //异常测试
        public void division(int num1, int num2)
        {
            try 
            { 
                int result = num1 / num2; 
            }
            catch (Exception e)
            {
                GlobalData.textLogger.WriteText(e);
                mainMsgControl1.AppendText(e.ToString());
            }
        }


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


        /// <summary>
        /// Expander TieeView menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void pbGo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"doesn't exist");
        }



        /// <summary>
        /// 关闭所有MdiChildren
        /// </summary>
        private void MdiFormClose()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
        }

        private System.Windows.Forms.Timer timer;
        private Process cur = null;
        private PerformanceCounter curpcp = null;
        private const int MB_DIV = 1024 * 1024;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (curpcp != null)
            {
                string RamInfo = (curpcp.NextValue() / MB_DIV).ToString("F1") + "MB";
                this.RamValue.Text = "Ram: " + RamInfo;
                Console.Write(RamInfo);
            }

        }
        private static string GetClientIP()
        {
            string text = "";
            string text2 = "";
            IPHostEntry iPHostEntry = null;
            if (string.IsNullOrEmpty(text))
            {
                text2 = Dns.GetHostName();
                iPHostEntry = Dns.GetHostEntry(text2);
                IPAddress[] addressList = iPHostEntry.AddressList;
                foreach (IPAddress iPAddress in addressList)
                {
                    if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        text = iPAddress.ToString();
                        break;
                    }
                }
            }
            return text;
        }
        /// <summary>
        /// 窗体第一次显示时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientMain_Shown(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(ThreadPoolCheckVersion), null);

            MainFormHandler.Instance.RegisterGlobalHotkey(config, OnHotkeyHandler, UpdateTaskHandler);
        }

        private void ThreadPoolCheckVersion(object state)
        {
            cur = Process.GetCurrentProcess();
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
            else
            {

            }
        }
    }
}
