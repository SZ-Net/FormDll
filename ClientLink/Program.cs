using ClientLink;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Utiliyt;

namespace DLLClientLink
{
    static class Program
    {
        public static bool CanPortable { get; private set; } = true;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEV1
            InitLog();
            if (Environment.OSVersion.Version.Major >= 6)
            {
                Utils.SetProcessDPIAware();
            }
            ConsoleManager.Show();

            SimpleLogHelper.Debug("Program Start.");
#endif

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;//处理非UI线程异常
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalData.textLogger = new Common.Tools.TextLogger($"logs/{DateTime.Now:yyMMdd}.log");  //Log
            Utils.SaveLog(GlobalData.LogoTxt.ToString());

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
                MessageBoxUI.ShowWarning($"ClientLink is already running(ClientLink已经运行)");
            }
            else
            {

                //设置语言环境
                string lang = Utils.RegReadValue(GlobalData.MyRegPath, GlobalData.MyRegKeyLanguage, "zh-Hans");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

                Common.fmLogin fmLogin = new Common.fmLogin();
                fmLogin.ShowDialog();
                if (fmLogin.LoginACK)
                {

                    fmLogin.Close();
                    Utils.SaveLog($"ClientLink start up | {Utils.GetVersion()} | {Utils.GetExePath()}");

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

        public static void InitLog()
        {
            var baseDir = CanPortable ? Environment.CurrentDirectory : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GlobalData.AppName);

            SimpleLogHelper.WriteLogEnumLogLevel = SimpleLogHelper.EnumLogLevel.Warning;
            SimpleLogHelper.PrintLogEnumLogLevel = SimpleLogHelper.EnumLogLevel.Debug;
            // init log file placement
            var logFilePath = Path.Combine(baseDir, "Logs", $"{GlobalData.AppName}.log.md");
            var fi = new FileInfo(logFilePath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
            SimpleLogHelper.LogFileName = logFilePath;

            // old version log files cleanup
            if (CanPortable)
            {
                var diLogs = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GlobalData.AppName, "Logs"));
                if (diLogs.Exists)
                    diLogs.Delete(true);
                var diApp = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GlobalData.AppName));
                if (diApp.Exists)
                {
                    var fis = diApp.GetFiles("*.md");
                    foreach (var info in fis)
                    {
                        info.Delete();
                    }
                }
            }
        }
    }
}
