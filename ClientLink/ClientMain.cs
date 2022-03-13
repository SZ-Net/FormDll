
using DLLClientLink.Properties;
using svr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLibrary;
using UtilityLibrary.LogHelper;

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

            Application.EnableVisualStyles();
            base.IsMdiContainer = true;
            base.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            var handle = base.Handle;
            dllLocation = Environment.CurrentDirectory + "\\DllLib\\";

        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            //division(25, 0);
            DllToLoadMenu(dllLocation);
            //ShowForm("fm001", "t001");
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
                Log.WriteLog(Log.WriteExceptionMsg(e,string.Empty));
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
                ExecutionResult executionResult = checkDll.Exec();
                if (executionResult.Status)
                {
                    num++;
                    ParentList.Add("");
                    MenuIDList.Add(num);
                    CaptionList.Add(executionResult.AnythingObj.ToString());
                }
            }
            initializeTreeView(MenuIDList, CaptionList, ParentList);
        }

        private void initializeTreeView(ArrayList menuIDList, ArrayList menuCaptionList, ArrayList menuParentIDList)
        {
            int count = menuIDList.Count;
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
                ExpanderPictureBox.Image = Resources.change;
                ExpanderPictureBox.Location = new Point(0, ExpanderPictureBox.Location.Y);
                PanelLeftAll.Size = new Size(ExpanderPictureBox.Size.Width, PanelLeftAll.Size.Height);
                flag = true;
            }
            else
            {
                ExpanderPictureBox.Image = Resources.change;
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
                case "Refresh":
                    Refresh();
                    break;
                case "&About Client":
                    svr.Version version = new svr.Version("About Client");
                    version.ShowDialog(this);
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
            
            Form[] mdiChildren = base.MdiChildren;
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
                    form.Activate();
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
                Log.WriteLog(Log.WriteExceptionMsg(e, string.Empty));
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


    }
}
