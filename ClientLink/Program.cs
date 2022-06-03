﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib.Tools;

namespace DLLClientLink
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalData.textLogger = new TextLogger($"logs/{DateTime.Now:yyMMdd}.log");
            Exception e = null;
            try
            {  
                //设置应用程序处理异常方式：ThreadException处理
                 Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


                #region 应用程序的主入口点
                ReturnResults returnResults = new ReturnResults();
                bool createdNew = false;
                Mutex mutex = new Mutex(initiallyOwned: false, "ClientLink.exe", out createdNew);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!createdNew)
                {
                    returnResults.Message = "ClientLink is running!";
                    MessageBox.Show(returnResults.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    
                    BaseLib.fmLogin fmLogin = new BaseLib.fmLogin();
                    fmLogin.ShowDialog();
                    if (fmLogin.LoginACK)
                    {
                        Application.Run(new ClientMain());
                        fmLogin.Close();
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                e = ex;
                string str = GetExceptionMsg(e, string.Empty);
                MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                if (e != null) {
                    string str = GetExceptionMsg(e, string.Empty);
                    GlobalData.textLogger.WriteText(str);
                }
                 
            }
            		
		}

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            
            string str = GetExceptionMsg(e.Exception, e.ToString());
            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            GlobalData.textLogger.WriteText(str);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            GlobalData.textLogger.WriteText(str);

        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************异常文本****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            if (ex != null)
            {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
            }
            else
            {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }
    }
}
