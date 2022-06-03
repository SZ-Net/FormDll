using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib.Tools
{
    /// <summary>
    ///  private readonly TextLogger textLogger;
    ///   textLogger = new TextLogger($"logs/{DateTime.Now:yyMMdd}.log");
    /// </summary>
    public class TextLogger
    {
        public readonly string _filePath;
        public readonly string _dir;

        /// <summary>
        ///   初始化 <see cref="T:System.Object" /> 类的新实例。
        /// </summary>
        public TextLogger(string filePath)
        {
            if (filePath.StartsWith("/"))
            {
                filePath = filePath.TrimStart('/');
            }
            _filePath = Path.Combine(Directory.GetCurrentDirectory(), filePath.Replace("/", "\\"));
            _dir = Path.GetDirectoryName(_filePath);
            try
            {
                if (!Directory.Exists(_dir))
                {
                    Directory.CreateDirectory(_dir);
                }
            }
            catch
            {

            }

        }

        public List<string> ReadLines()
        {
            var datas = new List<string>();
            using (FileStream fs = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
            {
                var strLine = sr.ReadLine();
                while (strLine != null)
                {
                    datas.Add(strLine);
                    strLine = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }

            return datas;

        }
        public void WriteText(string content)
        {
            using (FileStream fs = new FileStream(_filePath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    sw.WriteLine(content);
                    sw.Close();
                }

                fs.Close();
            }

        }
        public void WriteText(Exception content)
        {
            using (FileStream fs = new FileStream(_filePath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("****************************异常文本****************************");
                    sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
                    if (content != null)
                    {
                        sb.AppendLine("【异常类型】：" + content.GetType().Name);
                        sb.AppendLine("【异常信息】：" + content.Message);
                        sb.AppendLine("【堆栈调用】：" + content.StackTrace);
                    }
                    else
                    {
                        sb.AppendLine("【未处理异常】：" + "null");
                    }
                    sb.AppendLine("***************************************************************");
                    sw.WriteLine(sb);
                    sw.Close();
                }

                fs.Close();
            }

        }
    }
}
