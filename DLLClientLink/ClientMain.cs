using System;
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

namespace DLLClientLink
{
    public partial class ClientMain : Form
    {
        public ClientMain()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            base.IsMdiContainer = true;
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Maximized;
            ShowForm("fm001", "t001");
        }
        private void ShowForm(string packageName, string frmName, bool downloadFlag = true)
        {
            byte[] array = null;
            Assembly assembly = null;
            Type type = null;
            Type type2 = null;
            string text = "";
            object obj = null;
            object[] array2 = null;
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
            text = Path.Combine(Application.StartupPath, "DllLib", packageName + ".dll");
            try
            {
                if (!true)
                {
                    assembly = Assembly.LoadFrom(text);
                }
                else
                {
                    array = File.ReadAllBytes(text);
                    assembly = Assembly.Load(array);
                }
            }
            finally
            {
            }
            type2 = assembly.GetType(packageName + "." + frmName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm("fm001", "t001");
        }
    }
}
