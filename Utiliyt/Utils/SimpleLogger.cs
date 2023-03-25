using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Utiliyt
{
    public class SimpleLogger
    {
        public delegate void LogMonitorHandler(string message);
        private bool _active;
        private int _padRight;
        private int maxFileCount;
        public long logLengthLimit;
        private LogMonitorHandler logMonitorHandler;
        private long _maxFileLength;
        private StreamWriter streamWriter;
        private string _path;
        private string _currentLogDateTime;
        private string _eqpName;
        private string _logfilePrefix;
        private string _logPath;
        private string _timeFormat;
        private StringBuilder stringBuilder;
        private TraceSwitch traceSwitch = new TraceSwitch("Application", "General");
        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }
        public string DateTimeFormat
        {
            get
            {
                return _timeFormat;
            }
            set
            {
                _timeFormat = value;
            }
        }
        public TraceLevel LogLevel
        {
            get
            {
                return traceSwitch.Level;
            }
            set
            {
                traceSwitch.Level = value;
            }
        }
        public int PadRight
        {
            get
            {
                return _padRight;
            }
            set
            {
                _padRight = value;
            }
        }
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }
        public event LogMonitorHandler LogMonitorNotification;
        public event LogMonitorHandler LogTrace;
        public SimpleLogger()
        {
            _padRight = 1;
            _maxFileLength = 100000L;
            logLengthLimit = 200000L;
            maxFileCount = 300;
            _timeFormat = "yyyy/MM/dd HH:mm:ss.fff";
            stringBuilder = new StringBuilder();
        }
        public SimpleLogger(string path, bool createFile)
        {
            _padRight = 1;
            _maxFileLength = 100000L;
            logLengthLimit = 200000L;
            maxFileCount = 300;
            _timeFormat = "yyyy/MM/dd HH:mm:ss.fff";
            _currentLogDateTime = DateTime.Now.ToString("yyyyMMdd");
            _logPath = path;
            path = path + "-" + _currentLogDateTime + ".log";
            _path = path;
            stringBuilder = new StringBuilder();
            if (createFile)
            {
                createDirectory(path);
                streamWriter = new StreamWriter(new FileStream(path, FileMode.Append));

                streamWriter.AutoFlush = true;
            }
        }
        public SimpleLogger(string logPath, string logfilePrefix, string equipmentName, long maxFileLength, string logLevel)
        {
            createDirectory(logPath);
            _padRight = 1;
            _maxFileLength = 100000L;
            logLengthLimit = 200000L;
            maxFileCount = 300;
            _timeFormat = "yyyy/MM/dd HH:mm:ss.fff";
            stringBuilder = new StringBuilder();
            _logPath = logPath;
            _eqpName = equipmentName;
            _logfilePrefix = logfilePrefix;
            _currentLogDateTime = DateTime.Now.ToString("yyyyMMdd");
            _maxFileLength = maxFileLength;
            streamWriter = new StreamWriter(new StreamWith(logPath + "\\" + logfilePrefix + "-" + equipmentName + "-" + _currentLogDateTime + ".log", maxFileLength, 1000, FileMode.Append));
            streamWriter.AutoFlush = true;
            switch (logLevel)
            {
                case "Error":
                    traceSwitch.Level = TraceLevel.Error;
                    break;
                case "Warning":
                    traceSwitch.Level = TraceLevel.Warning;
                    break;
                case "Verbose":
                    traceSwitch.Level = TraceLevel.Verbose;
                    break;
                case "Info":
                    traceSwitch.Level = TraceLevel.Info;
                    break;
                default:
                    traceSwitch.Level = TraceLevel.Info;
                    break;
            }
        }
        private void createDirectory(string name)
        {
            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }
        }
        public void Close()
        {
            try
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
            catch (Exception value)
            {
                Console.WriteLine(value);
            }
        }
        public void Error(string message)
        {
            try
            {
                if (_active)
                {
                    CheckChangeOfDay();
                    if (traceSwitch.TraceError)
                    {
                        streamWriter.WriteLine(Log("ERR", message));
                    }
                }
            }
            catch
            {
            }
        }
        public virtual void Error(object source, string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<-- ");
            stringBuilder.Append(DateTime.Now.ToString("HH:mm:ss").PadRight(10, ' '));
            stringBuilder.Append("ERROR: ");
            stringBuilder.Append(text + "\n");
            if (source != null)
            {
                stringBuilder.Append("Source: " + source.ToString());
            }
            string text2 = stringBuilder.ToString();
            if (_active)
            {
                try
                {
                    CheckChangeOfDay();
                    streamWriter.WriteLine(text2);
                    streamWriter.Flush();
                }
                catch
                {
                }
            }
            OnLogMonitor(text2);
        }
        public virtual void Indent()
        {
            stringBuilder.Append("   ");
        }
        public void Info(string message)
        {
            try
            {
                if (_active)
                {
                    CheckChangeOfDay();
                    if (traceSwitch.TraceInfo)
                    {
                        streamWriter.WriteLine(Log("INFO", message));
                    }
                }
            }
            catch
            {
            }
        }
        private string GetCurrentTimeString()
        {
            return DateTime.Now.ToString(_timeFormat);
        }
        private string Log(string level, string log)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(GetCurrentTimeString());
            stringBuilder.Append(" ");
            stringBuilder.Append("[" + level + "]");
            stringBuilder.Append(" ");
            stringBuilder.Append(log);
            return stringBuilder.ToString();
        }
        private void OnLogMonitor(string message)
        {
            if (logMonitorHandler != null)
            {
                logMonitorHandler(message);
            }
        }
        private void CheckChangeOfDay()
        {
            string text = DateTime.Now.ToString("yyyyMMdd");
            bool flag = text != _currentLogDateTime;
            _currentLogDateTime = text;
            string path = _logPath + "\\" + _logfilePrefix + "-" + _eqpName + "-" + _currentLogDateTime + ".log";
            /*if (flag)
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
                SECsStreamWithBackup sECsStreamWithBackup = new SECsStreamWithBackup(path, _maxFileLength, maxFileCount, FileMode.Append);
                sECsStreamWithBackup.CanSplitData = false;
                streamWriter = new StreamWriter(sECsStreamWithBackup);
                streamWriter.AutoFlush = true;
            }
            if (streamWriter == null)
            {
                SECsStreamWithBackup sECsStreamWithBackup = new SECsStreamWithBackup(path, _maxFileLength, maxFileCount, FileMode.Append);
                sECsStreamWithBackup.CanSplitData = false;
                streamWriter = new StreamWriter(sECsStreamWithBackup);
                streamWriter.AutoFlush = true;
            }*/
        }
        public virtual void Trace(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.stringBuilder.ToString());
            if (text.Length <= logLengthLimit)
            {
                stringBuilder.Append(text);
            }
            else
            {
                text = text.Substring(0, 10) + " ... (truncated)";
            }
            string text2 = stringBuilder.ToString();
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine(text2);
                streamWriter.Flush();
            }
            OnLogMonitor(text2);
        }
        public virtual void Unindent()
        {
            stringBuilder.Remove(0, 3);
        }
        public void Verbose(string message)
        {
            try
            {
                if (_active)
                {
                    CheckChangeOfDay();
                    if (traceSwitch.TraceVerbose)
                    {
                        streamWriter.WriteLine(Log("VERB", message));
                    }
                }
            }
            catch
            {
            }
        }
        public void Warning(string message)
        {
            try
            {
                if (_active)
                {
                    CheckChangeOfDay();
                    if (traceSwitch.TraceWarning)
                    {
                        streamWriter.WriteLine(Log("WARN", message));
                    }
                }
            }
            catch
            {
            }
        }
        public virtual void WriteIn(string stype, byte[] buffer)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<-- ");
            stringBuilder.Append(DateTime.Now.ToString("HH:mm:ss").PadRight(10, ' '));
            stringBuilder.Append(stype.PadRight(_padRight, ' '));
            if (buffer.Length <= logLengthLimit)
            {
                stringBuilder.Append("(");
                stringBuilder.Append(BitConverter.ToString(buffer).Replace("-", " "));
                stringBuilder.Append(")");
            }
            else
            {
                stringBuilder.Append("(");
                stringBuilder.Append("Message Truncated... Too Long to be logged");
                stringBuilder.Append(")");
            }
            string text = stringBuilder.ToString();
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine(text);
                streamWriter.Flush();
            }
            OnLogMonitor(text);
        }
        public virtual string WriteLine(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.stringBuilder.ToString());
            if (text.Length <= logLengthLimit)
            {
                stringBuilder.Append(text);
            }
            else
            {
                text = text.Substring(0, 10) + " ... (truncated)";
            }
            string text2 = stringBuilder.ToString();
            if (_active)
            {
                try
                {
                    CheckChangeOfDay();
                    streamWriter.WriteLine(text2);
                    streamWriter.Flush();
                }
                catch
                {
                }
            }
            OnLogMonitor(text2);
            return text2;
        }
        public virtual void WriteOut(string stype, byte[] buffer)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("--> ");
            stringBuilder.Append(DateTime.Now.ToString("HH:mm:ss").PadRight(10, ' '));
            stringBuilder.Append(stype.PadRight(_padRight, ' '));
            if (buffer.Length <= logLengthLimit)
            {
                stringBuilder.Append("(");
                stringBuilder.Append(BitConverter.ToString(buffer).Replace("-", " "));
                stringBuilder.Append(")");
            }
            else
            {
                stringBuilder.Append("(");
                stringBuilder.Append("Message Truncated... Too Long to be logged");
                stringBuilder.Append(")");
            }
            string text = stringBuilder.ToString();
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine(text);
                streamWriter.Flush();
            }
            OnLogMonitor(text);
        }
        public void WriteReceiveTime()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(DateTime.Now.ToString(_timeFormat));
            stringBuilder.Append(" - Received");
            string text = stringBuilder.ToString();
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine(text);
                streamWriter.Flush();
            }
            OnLogMonitor(text);
        }
        public void WriteSendTime()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(DateTime.Now.ToString(_timeFormat));
            stringBuilder.Append(" - Sending");
            string text = stringBuilder.ToString();
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine(text);
                streamWriter.Flush();
            }
            OnLogMonitor(text);
        }
        public virtual void WriteSeparator()
        {
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine("");
                streamWriter.Flush();
            }
            OnLogMonitor("");
        }
        public void WriteSmlHeader(string header)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(header);
            string text = stringBuilder.ToString();
            if (_active)
            {
                CheckChangeOfDay();
                streamWriter.WriteLine(text);
                streamWriter.Flush();
            }
            OnLogMonitor(text);
        }
    }
}