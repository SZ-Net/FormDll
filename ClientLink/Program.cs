using ClientLink;
using EasyNetQ.Logging;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Utility;

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
#if DEV1
            
            if (Environment.OSVersion.Version.Major >= 6)
            {
                Utils.SetProcessDPIAware();
            }
            ConsoleManager.Show();

            SimpleLogHelper.Debug("Program Start.");
#endif

            InitLog();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;//处理非UI线程异常
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
                catch
                {
                    throw;
                }
                MessageBoxUI.ShowWarning($"ClientLink is already running(ClientLink已经运行)");
            }
            else
            {
                //设置语言环境
                string lang = Utils.RegReadValue(GlobalData.MyRegPath, GlobalData.MyRegKeyLanguage, "zh-Hans");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

                Common.fmLogin fmLogin = new Common.fmLogin();
                fmLogin.ShowDialog();
                if (fmLogin.userInfo.IsState)
                {
                    GlobalData.userInfo = new ClientLink.Mode.UserInfo()
                    {
                        UserName = fmLogin.userInfo.UserName,
                        Password = fmLogin.userInfo.Password,
                        IsState = fmLogin.userInfo.IsState,
                        Description = fmLogin.userInfo.Description,
                    };
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
            string name = Utils.GetExePath();
            name = name.Replace("\\", "/");

            GlobalData.mutexObj = new Mutex(false, name, out bool bCreatedNew);
            return !bCreatedNew;
        }

        public static void InitLog()
        {
            GlobalData.textLogger = new Common.Tools.TextLogger($"LogFiles//{GlobalData.AppName}_{DateTime.Now:yyMMdd}.log");
            GlobalData.logger = new SimpleLogger(System.Environment.CurrentDirectory + "\\LogFiles", "Logger", GlobalData.AppName, 10000000, "Info");
            GlobalData.logger.Active = true;
            GlobalData.logger.Info("Hello World !");
            GlobalData.dicLogger.Add(GlobalData.AppName, GlobalData.logger);
        }
    }
}
