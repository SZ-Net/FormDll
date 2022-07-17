using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib.Tools;
using DLLClientLink.Tool;

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
            if (Environment.OSVersion.Version.Major >= 6)
            {
                Utils.SetProcessDPIAware();
            }
            
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;//处理非UI线程异常


            if (IsDuplicateInstance())
            {
                try
                {
                    //read handle from reg and show the window
                    long.TryParse(Utils.RegReadValue(GlobalData.MyRegPath, Utils.WindowHwndKey, ""), out long llong);
                    if (llong > 0)
                    {
                        var hwnd = (IntPtr)llong;
                        if (Utils.IsWindow(hwnd))
                        {
                            Utils.ShowWindow(hwnd, 4);
                            Utils.SwitchToThisWindow(hwnd, true);
                            return;
                        }
                    }
                }
                catch { }
                UI.ShowWarning($"ClientLink is already running(ClientLink已经运行)");
            }
            else
            {
                GlobalData.textLogger = new TextLogger($"logs/{DateTime.Now:yyMMdd}.log");
                //设置语言环境
                string lang = Utils.RegReadValue(GlobalData.MyRegPath, GlobalData.MyRegKeyLanguage, "zh-Hans");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
                

                BaseLib.fmLogin fmLogin = new BaseLib.fmLogin();
                fmLogin.ShowDialog();
                if (fmLogin.LoginACK)
                {

                    fmLogin.Close();
                    Utils.SaveLog($"ClientLink start up | {Utils.GetVersion()} | {Utils.GetExePath()}");
                    Application.EnableVisualStyles();
                    //Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ClientMain());
                    
                }
            }



        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Utils.SaveLog("Application_ThreadException", e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Utils.SaveLog("CurrentDomain_UnhandledException", (Exception)e.ExceptionObject);
        }



        /// <summary> 
        /// 检查是否已在运行
        /// </summary> 
        public static bool IsDuplicateInstance()
        {
            //string name = "ClientLink";

            string name = Utils.GetExePath(); // Allow different locations to run
            name = name.Replace("\\", "/"); // https://stackoverflow.com/questions/20714120/could-not-find-a-part-of-the-path-error-while-creating-mutex

            GlobalData.mutexObj = new Mutex(false, name, out bool bCreatedNew);
            return !bCreatedNew;
        }
    }
}
