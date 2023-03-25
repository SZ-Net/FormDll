
using ClientLink.Mode;
using EasyNetQ;
using System.Collections.Generic;
using System.Timers;
using Utility;

namespace ClientLink
{
    class GlobalData
    {
        public const string LogoTxt = @" ";

        public const string AppName = "ClientLink";

        public static Common.Tools.TextLogger textLogger;

        public static Dictionary<string, SimpleLogger> dicLogger = new Dictionary<string, SimpleLogger>();
        public static SimpleLogger logger;
        /// <summary>
        /// 注册表路径
        /// </summary>
        public const string MyRegPath = "Software\\ClientLinkUI";

        /// <summary>
        /// Language
        /// </summary>
        public const string MyRegKeyLanguage = "CurrentLanguage";

        /// <summary>
        /// Config Path
        /// </summary>
        public const string ConfigFileName = "GuiConfig.json";

        /// <summary>
        /// webpath
        /// </summary>
        public const string PromotionUrl = @"http://47.103.68.175/";

        /// <summary>
        /// dll Path
        /// </summary>
        public static string dllPath = Utils.StartupPath() + "\\List";

        /// <summary>
        /// dll type name
        /// </summary>
        public const string TypeName = "MainForm";
        public static System.Threading.Mutex mutexObj { get; set; }

        /// <summary>
        /// 是否需要上传配置
        /// </summary>
        public static bool upload
        {
            get; set;
        }

        public static Job processJob { get; set; }

        /// <summary>
        /// timer
        /// </summary>
        public static Timer timer { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        public static UserInfo userInfo { get; set; }

        /// <summary>
        /// EasyNetQ IBus
        /// </summary>
        public static IBus Bus { get; set; }

        /// <summary>
        /// Assembly 加载方式
        /// </summary>
        public static bool LoadInMemory { get; set; } = true;
    }
}
