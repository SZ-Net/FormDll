using BaseLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm_1
{
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ftp ftp1 = new ftp("47.103.68.175", 21, "test", "123456");
            var Data = ftp1.GetFtpListItemsJson("/");

            SuccessMSG(Data.ToString());
        }
    }
}
