using DLLClientLink.Mode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLClientLink.Forms
{
    public partial class BaseForm : Form
    {
        protected static Config config;
        public BaseForm()
        {
            InitializeComponent();
            LoadCustom();
        }

        private void LoadCustom()
        {
            
        }

        /// <summary>
        ///  C# Winform 窗体打开时闪烁问题
        ///  主要原因是对于Winform来说，一个窗体中绘制多个控件是很花时间的。特别是默认的按钮控件。Form先画出背景，然后留下控件需要的“洞”。如果控件的背景是透明的，那么这些“洞”就会先以白色或黑色出现，然后每个控件的“洞”再被填充，就是我们所看到的闪烁，在WinForm中没有现成的解决方案。设置控件双缓冲并不能解决它，因为它只适用于自己，而不是复合控件集。
        ///  protected 受保护的，只有本类及继承的子类可以访问。
        ///  override 复写, 对父类中的相同名称的方法重新其修改内容。
        /// </summary>
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams paras = base.CreateParams;
        //        paras.ExStyle |= 0x02000000;
        //        return paras;
        //    }
        //}

    }
}
