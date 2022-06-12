using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using BaseLib.Tools;
using DLLClientLink.Properties;

namespace DLLClientLink
{
    public partial class ClientMain : Form
    {
        private string dllLocation; //dll path
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
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
            dllLocation = Environment.CurrentDirectory + "\\DllLib\\";

        }
        /// <summary>
        ///  C# Winform 窗体打开时闪烁问题
        ///  主要原因是对于Winform来说，一个窗体中绘制多个控件是很花时间的。特别是默认的按钮控件。Form先画出背景，然后留下控件需要的“洞”。如果控件的背景是透明的，那么这些“洞”就会先以白色或黑色出现，然后每个控件的“洞”再被填充，就是我们所看到的闪烁，在WinForm中没有现成的解决方案。设置控件双缓冲并不能解决它，因为它只适用于自己，而不是复合控件集。
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
            string[] s = new string[] { "1","2" };
            Console.WriteLine(s[1]);

            //byte[] bytes = new byte[] { 0x65, 0x31, 0x00 };

            //string s;
            //string f = string.Format("{0,:G}", "NS98W04-B6");
            //s = string.Format("{0,-12:G}", "NS98W04-B6");
            //byte[] str_byte = new byte[s.Length];
            //char[] str1 = new char[s.Length];
            //s.CopyTo(0, str1, 0, s.Length);
            //for (int i = 0; i < str1.Length; i++) str_byte[i] = Convert.ToByte(str1[i]);

            ////
            //List<byte> list = str_byte.ToList();
            //for (int i = str_byte.Length - 1; i >= 0; i--)
            //{
            //    if (str_byte[i] == 32)
            //    {
            //        list.RemoveAt(i);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //byte[] clearbytesnull = list.ToArray();

            //s = System.Text.Encoding.Default.GetString(clearbytesnull);
            //FileStream file1 = new FileStream(@"E:\tt.txt", FileMode.OpenOrCreate);
            //file1.Write(Encoding.ASCII.GetBytes("qwertyuiopsdfghjklxcvbnm,"),0,0);









            //this.LocalIP.Text = "IP: " + GetClientIP();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            division(25, 0);
            DllToLoadMenu(dllLocation);
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
            ImgList.Images.Add(Image.FromFile(Environment.CurrentDirectory + "\\Image\\" + @"\tv1.png"));
            
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

            }
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
            string  ClasseName = "Main";
            string PackagePath = ((dllLocation.LastIndexOf("\\") <= 2) ? (dllLocation + "\\" + treeSelectText + ".dll") : (dllLocation + treeSelectText + ".dll"));
            
            Form[] mdiChildren = MdiChildren;
            Type type = null;
            foreach (Form form in mdiChildren)
            {
                type = form.GetType();
                if (type.Namespace == treeSelectText && type.Name == "Main")
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
            Type type2 = assembly.GetType(treeSelectText + "." + ClasseName);
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
        /// 关闭Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //(MessageBox.Show("Are you sure you want to sign out?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            MdiFormClose();
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
            this.tsMenuNotifyShow_Click(sender, e);
        }
        // 托盘菜单-显示窗口
        private void tsMenuNotifyShow_Click(object sender, EventArgs e)
        {
            // 还原窗口
            WindowState = FormWindowState.Maximized;
            // 显示任务栏图标
            this.ShowInTaskbar = true;
        }
        // 托盘菜单-退出
        private void tsMenuNotifyExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void ClientMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }
        #endregion


    }
}
