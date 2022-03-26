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

namespace ClientDemo
{
    
    public partial class FormMain : Form
    {
        public static Color ThemeColor = Color.FromArgb(64, 64, 64);
        private ImageList imageList;
        private Dictionary<string, int> formIconImageIndex = new Dictionary<string, int>();

        private System.Windows.Forms.Timer timer;
        private Process cur = null;
        private PerformanceCounter curpcp = null;
        private const int MB_DIV = 1024 * 1024;
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

            ThemeColor = menuStrip1.BackColor;

            new FormLogin().Show(dockPanel1);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            TreeViewIni();
        }
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
            TreeNode melsecNode = new TreeNode("Melsec Plc [三菱]", 8, 8);
            melsecNode.Nodes.Add(GetTreeNodeByIndex("EtherNet/IP(CIP)", 8, typeof(FormLogin)));
           
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
                
            }
        }
    }
}
