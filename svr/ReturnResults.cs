using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svr
{
    [Serializable]
    public class ReturnResults
    {
        public ReturnResults()
        {
        }
        private bool statusField;

        private string msgCodeField;

        private string messageField;

        private object[] argesField;

        private object anythingField;

        public bool Status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }

        public string MSGCode
        {
            get
            {
                return msgCodeField;
            }
            set
            {
                msgCodeField = value;
            }
        }

        public string Message
        {
            get
            {
                return messageField;
            }
            set
            {
                messageField = value;
            }
        }

        public object[] Arges
        {
            get
            {
                return argesField;
            }
            set
            {
                argesField = value;
            }
        }

        public object Anything
        {
            get
            {
                return anythingField;
            }
            set
            {
                anythingField = value;
            }
        }



        public bool state { get; set; }
        public string msg { get; set; }
       

        private ReturnResults(bool _state, string _msg)
        {
            this.state = _state;
            this.msg = _msg;
        }

        public static ReturnResults Success(String msg)
        {
            return new ReturnResults(true, msg);
        }
        public static ReturnResults Error(String msg)
        {
            return new ReturnResults(false, msg);
        }

        public static ReturnResults vAnything(bool state, String msg)
        {
            return new ReturnResults(state, msg);
        }
    }

}
