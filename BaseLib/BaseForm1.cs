using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLib
{
    public partial class BaseForm1 : Form
    {
        public BaseForm1()
        {
            InitializeComponent();
        }


		public virtual void ErrorMSG(string errorMSG)
		{
			prgMSG.ForeColor = Color.Red;
			prgMSG.Text = errorMSG;
		}

		public virtual void WarningMSG(string warningMSG)
		{
			prgMSG.ForeColor = Color.Yellow;
			prgMSG.Text = warningMSG;
		}

		public virtual void SuccessMSG(string successMSG)
		{
			prgMSG.ForeColor = Color.Blue;
			prgMSG.Text = successMSG;
		}
	}
}
