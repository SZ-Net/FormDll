using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLib
{
    /// <summary>
    /// 继承BaseForm 样式
    /// 反射代码的时候，反射载入的代码还依赖其他的代码也要引入否者异常
    /// </summary>
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

        }

        public virtual void ErrorMSG(string errorMSG)
        {
            string[] msg = new string[2];
            msg[0] = "[APP 错误消息] " + DateTime.Now.ToString() + " | ";
            msg[1] = "errorMSG";
            ShowLog(msg, vLog.display, Color.Red);
        }

        public virtual void WarningMSG(string warningMSG)
        {
            string[] msg = new string[2];
            msg[0] = "[APP 警告消息] " + DateTime.Now.ToString() + " | ";
            msg[1] = "warningMSG"; 
          
            ShowLog(msg, vLog.display, Color.Yellow);
        }

        public virtual void SuccessMSG(string successMSG)
        {
            string[] msg = new string[2];
            msg[0] = "[APP 成功消息] " + DateTime.Now.ToString() + " | ";
            msg[1] = "successMSG";
            ShowLog(msg, vLog.display, Color.Blue);
        }


        public enum vLog
        {
            display,
            record
        }
        /// <summary>
        /// 记录log的方法 :ShowLog("log", "logtype 枚举 vLog", Color.Green);
        /// </summary>
        /// <param name="strLog"></param>
        /// <param name="type"></param>
        /// <param name="color"></param>
        public virtual void ShowLog(string[] strLog, vLog logType, Color color)
        {
            ListView lv = null;
            if (logType == vLog.display)
                lv = LvMsg;
            else
            {
                //log.txt
            }
            if (lv != null)
            {
                lv.Invoke((MethodInvoker)delegate
                {
                    //string strLogTmp = strLog.Insert(0, DateTime.Now.ToString());
                    if (lv.Items.Count > 100)
                    {
                        lv.Items.RemoveAt(lv.Items.Count - 1);
                    }
                     this.LvMsg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //width
                    if (strLog[0].ToString().Length > lv.Columns[0].Width)
                        lv.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize); //width跟随head width
                    //ListViewItem objLVI = lv.Items.Insert(0, strLogTmp); 
                    ListViewItem objLVI = lv.Items.Insert(0,
                        new ListViewItem(new string[] { strLog[0].ToString(), strLog[1].ToString() })); //插入集合
                    lv.TopItem = objLVI;
                    objLVI.ForeColor = color;
                });
            }

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            LvMsg_SizeChanged(null, null);
#if DEBUG

            //ErrorMSG("配置中开启ErrorMSG级别日志");
            //WarningMSG("配置中开启WarningMSG级别日志");
            //SuccessMSG("配置中开启SuccessMSG级别日志");
#endif

        }



        /// <summary>
        /// 跟随窗体尺寸变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void LvMsg_SizeChanged(object sender, EventArgs e)
        {
            LvMsg.Columns[1].Width = LvMsg.ClientSize.Width - LvMsg.Columns[0].Width;
        }

        private void HelpLinkButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/"); // 默认浏览器
        }
    }
}
