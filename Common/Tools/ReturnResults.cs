using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    [Serializable]
    public class ReturnResults
    {
        public ReturnResults()
        {
        }
        private bool status;

        private string message;

        private object[] arges;

        private object anything;

        public bool Status { get => status; set => status = value; }
        public string Message { get => message; set => message = value; }
        public object[] Arges { get => arges; set => arges = value; }
        public object Anything { get => anything; set => anything = value; }
    }

}
