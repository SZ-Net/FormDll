using MainFormLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTest
{
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strData1 = @"0000871900009C44A11D411E4368322F6E617572612D38696E63682F52463330302D38494E2D434F4F4C";
            string getData1 = "";
            // 声明一个byte数组，大小为 16进制字符串 长度的一半，因为16进制数据都是两个一组
            byte[] buf1 = new byte[strData1.Length / 2];
            for (int i = 0; i < strData1.Length; i += 2)
            {
                // 将 16进制字符串 中的每两个字符转换成 byte，并加入到新申请的 byte数组 中
                buf1[i / 2] = Convert.ToByte(strData1.Substring(i, 2), 16);
            }

            // 将 byte数组 解码成 字符串：
            getData1 = Encoding.Default.GetString(buf1);
            Console.WriteLine("56312E31 对应的字符串是：" + getData1);
            // MessageBox.Show(stringValue);
        }

        private static string Myparse(string str)
        {
            return str.Substring(str.IndexOf("'") + 1, str.LastIndexOf("'") - str.IndexOf("'") - 1); ;
        }
    }
}
