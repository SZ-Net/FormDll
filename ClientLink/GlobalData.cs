using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLib.Tools;

namespace DLLClientLink
{
    class GlobalData
    {
        public static TextLogger textLogger;
        /// <summary>
        /// MyRegPath
        /// </summary>
        public const string MyRegPath = "Software\\ClientLinkUI";

        /// <summary>
        /// Language
        /// </summary>
        public const string MyRegKeyLanguage = "CurrentLanguage";


        public static System.Threading.Mutex mutexObj
        {
            get; set;
        }
    }
}
