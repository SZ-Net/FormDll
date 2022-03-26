using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ClientDemo
{
    
    public partial class FormMain : Form
    {
        public static Color Color = Color.FromArgb(64, 64, 64);
        private ImageList imageList;
        private Dictionary<string, int> formIconImageIndex = new Dictionary<string, int>();

        private System.Windows.Forms.Timer timer;
        public FormMain()
        {
           
            InitializeComponent();
             Form = this;
            imageList = new ImageList();
        }

        public static FormMain Form { get; set; }

        private void FormMain_Load(object sender, EventArgs e)
        {

            dockPanel1.Theme = vS2015BlueTheme1;
            //dockPanel1.Theme = vS2015DarkTheme1;
            //dockPanel1.Theme = vS2015LightTheme1;

            Color = menuStrip1.BackColor;

            //new FormLogin().Show(dockPanel1);
            //窗体加载的时候
            //DockContent form = new FormLogin();
            //form.Name = "WelcomeForm";
            //form.TabText = "Welcome";
            //form.Show(dockPanel1);



            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            TreeViewIni();
        }

        //treeview
        private TreeNode GetTreeNodeByIndex(string name, int index, Type form)
        {
            formIconImageIndex.Add(form.Name, index);
            return new TreeNode(name, index, index)
            {
                Tag = form
            };
        }
        private void TreeViewIni()
        {
            TreeNode melsecNode = new TreeNode("TestONE", 8, 8);
            melsecNode.Nodes.Add(GetTreeNodeByIndex("Login", 8, typeof(FormLogin)));
            melsecNode.Nodes.Add(GetTreeNodeByIndex("TestDemo", 8, typeof(TestDemo)));
            treeView1.Nodes.Add(melsecNode);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
          
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode treeNode = treeView1.SelectedNode;
            if (treeNode == null) return;
            if (treeNode.Tag == null) return;

            if (treeNode.Tag is Type type)
            {

                //type.Show(dockPanel1);
                var type111 = Type.GetType(treeNode.Tag.ToString());
                ShowDocument(Type.GetType(treeNode.Tag.ToString()), treeNode.Name);

            }
        }
        public void ShowDocument(Type formType, string tabText, params object[] args)
        {
            IDockContent docForm = FindDocument(formType.Name);
            if (docForm == null)
            {
                try
                {
                    DockContent form = (DockContent)Activator.CreateInstance(formType, args);
                    form.Name = formType.Name;
                    form.TabText = tabText;
                    if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
                    {
                        form.MdiParent = this;
                        form.Show(dockPanel1);
                    }
                    else
                    {
                        form.Show(dockPanel1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                docForm.DockHandler.Activate();
            }
        }

        private IDockContent FindDocument(string text)
        {
            if (dockPanel1.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;
                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel1.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
        }



    }
}
