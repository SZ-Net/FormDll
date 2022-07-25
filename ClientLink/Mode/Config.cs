using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLClientLink.Mode
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class Config
    {
        #region property
        /// <summary>
        /// 允许日志
        /// </summary>
        public bool logEnabled{ get; set; }
        /// <summary>
        /// 日志等级
        /// </summary>
        public string loglevel{ get; set; }

        public string indexId { get; set; }

        public DateTime fixDate { get; set; }

        public LanguageType language { get; set; }

        public string dllPath { get; set; }

        public bool checkDomain { get; set; }

        public string currentUser { get; set; }

        public bool checkUpdate { get; set; }

        public ConnectionType connectionType { get; set; }

        public LoginType loginType { get; set; }

        #endregion

        public List<serverDB> dbList
        {
            get; set;
        }

        public List<feedback> feedback
        {
            get; set;
        }

        public List<KeyEventItem> globalHotkeys
        {
            get; set;
        }
        public List<GroupItem> groupItem
        {
            get; set;
        }
    }



    [Serializable]
    public class serverDB
    {
        public serverDB()
        {
            indexId = string.Empty;
            name = string.Empty;
            host = string.Empty;
            port = 0;
            user = string.Empty;
            password = string.Empty;
            remarks = string.Empty;
        }

        #region function
        public string GetNetwork()
        {

            return null;
        }

        #endregion

        public string indexId
        {
            get; set;
        }

        public string name
        {
            get; set;
        }

        /// <summary>
        /// 远程服务器地址
        /// </summary>
        public string host
        {
            get; set;
        }
        /// <summary>
        /// 远程服务器端口
        /// </summary>
        public int port
        {
            get; set;
        }
        public string user
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
        /// <summary>
        /// 备注或别名
        /// </summary>
        public string remarks
        {
            get; set;
        }

    }

    [Serializable]
    public class feedback
    {
        public string user
        {
            get; set;
        }
        public string e_mail
        {
            get; set;
        }
        public bool submit
        {
            get; set;
        }
        public DateTime Data
        {
            get; set;
        }

        public string content
        {
            get; set;
        }
    }

    [Serializable]
    public class KeyEventItem
    {
        public GlobalHotkey GlobalHotkey { get; set; }

        public bool Alt { get; set; }

        public bool Control { get; set; }

        public bool Shift { get; set; }

        public Keys? KeyCode { get; set; }

    }

    [Serializable]
    public class GroupItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string remarks
        {
            get; set;
        }
        public int sort
        {
            get; set;
        }
    }
}
