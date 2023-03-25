
using ClientLink.Mode;
using EasyNetQ;
using System.Timers;

namespace ClientLink
{
    class GlobalData
    {
        public const string LogoTxt = @"
   ___      _       _                      _       _        _              _     
  / __|    | |     (_)     ___    _ _     | |_    | |      (_)    _ _     | |__  
 | (__     | |     | |    / -_)  | ' \    |  _|   | |__    | |   | ' \    | / /  
  \___|   _|_|_   _|_|_   \___|  |_||_|   _\__|   |____|  _|_|_  |_||_|   |_\_\  
        
                键盘在手                                        编程我有
┌───┐   ┌───┬───┬───┬───┐ ┌───┬───┬───┬───┐ ┌───┬───┬───┬───┐ ┌───┬───┬───┐
│Esc│   │ F1│ F2│ F3│ F4│ │ F5│ F6│ F7│ F8│ │ F9│F10│F11│F12│ │P/S│S L│P/B│  ┌┐    ┌┐    ┌┐
└───┘   └───┴───┴───┴───┘ └───┴───┴───┴───┘ └───┴───┴───┴───┘ └───┴───┴───┘  └┘    └┘    └┘
┌───┬───┬───┬───┬───┬───┬───┬───┬───┬───┬───┬───┬───┬───────┐ ┌───┬───┬───┐ ┌───┬───┬───┬───┐
│~ `│! 1│@ 2│# 3│$ 4│% 5│^ 6│& 7│* 8│( 9│) 0│_ -│+ =│ BacSp │ │Ins│Hom│PUp│ │N L│ / │ * │ - │
├───┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─────┤ ├───┼───┼───┤ ├───┼───┼───┼───┤
│ Tab │ Q │ W │ E │ R │ T │ Y │ U │ I │ O │ P │{ [│} ]│ | \ │ │Del│End│PDn│ │ 7 │ 8 │ 9 │   │
├─────┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴┬──┴─────┤ └───┴───┴───┘ ├───┼───┼───┤ + │
│ Caps │ A │ S │ D │ F │ G │ H │ J │ K │ L │: ;│  '│ Enter  │               │ 4 │ 5 │ 6 │   │
├──────┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴─┬─┴────────┤     ┌───┐     ├───┼───┼───┼───┤
│ Shift  │ Z │ X │ C │ V │ B │ N │ M │< ,│> .│? /│  Shift   │     │ ↑ │     │ 1 │ 2 │ 3 │   │
├─────┬──┴─┬─┴──┬┴───┴───┴───┴───┴───┴──┬┴───┼───┴┬────┬────┤ ┌───┼───┼───┐ ├───┴───┼───┤ E││
│ Ctrl│    │Alt │         Space         │ Alt│    │    │Ctrl│ │ ← │ ↓ │ → │ │   0   │ . │←─┘│
└─────┴────┴────┴───────────────────────┴────┴────┴────┴────┘ └───┴───┴───┘ └───────┴───┴───┘
        ";

        public const string AppName = "ClientLink_Debug";

        public static Common.Tools.TextLogger textLogger;
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
        public static System.Threading.Mutex mutexObj
        {
            get; set;
        }

        /// <summary>
        /// 是否需要上传配置
        /// </summary>
        public static bool upload
        {
            get; set;
        }

        public static Job processJob
        {
            get; set;
        }

        public static Timer timer
        {
            get; set;
        }


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
