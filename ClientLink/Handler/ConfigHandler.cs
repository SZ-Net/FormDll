using ClientLink.Mode;
using System;
using System.Collections.Generic;
using System.IO;

namespace ClientLink.Handler
{
    class ConfigHandler
    {
        private static string configRes = GlobalData.ConfigFileName;
        private static readonly object objLock = new object();

        #region ConfigHandler

        /// <summary>
        /// 载入配置文件
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static int LoadConfig(ref Config config)
        {
            //载入配置文件 
            string result = Utils.LoadResource(Utils.GetPath(configRes));
            if (!Utils.IsNullOrEmpty(result))
            {
                //转成Json
                config = Utils.FromJson<Config>(result);
            }
            else
            {
                if (File.Exists(Utils.GetPath(configRes)))
                {
                    Utils.SaveLog("LoadConfig Exception");
                    return -1;
                }
            }

            if (config == null)
            {
                config = new Config
                {
                    logEnabled = true,
                    loglevel = "Info",
                    fixDate = new DateTime(),
                    indexId = Utils.GetGUID(false),
                    language = LanguageType.en,
                    dllPath = GlobalData.dllPath,

                    dbList = new List<serverDB>(),
                };
            }
            Utils.ToJsonFile(config,Utils.GetPath(GlobalData.ConfigFileName));
            return 0;
        }
        /// <summary>
        /// 保参数
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static int SaveConfig(ref Config config, bool upload = true)
        {
            GlobalData.upload = upload;

            ToJsonFile(config);

            return 0;
        }

        /// <summary>
        /// 存储文件
        /// </summary>
        /// <param name="config"></param>
        private static void ToJsonFile(Config config)
        {
            lock (objLock)
            {
                try
                {

                    //save temp file
                    var resPath = Utils.GetPath(configRes);
                    var tempPath = $"{resPath}_temp";
                    if (Utils.ToJsonFile(config, tempPath) != 0)
                    {
                        return;
                    }

                    if (File.Exists(resPath))
                    {
                        File.Delete(resPath);
                    }
                    //rename
                    File.Move(tempPath, resPath);
                }
                catch (Exception ex)
                {
                    Utils.SaveLog("ToJsonFile", ex);
                }
            }
        }

        #endregion
    }
}
