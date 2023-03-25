using System;
using System.IO;
using System.Text;

namespace Utiliyt
{
    internal class StreamWith : FileStream
    {
        private string v1;
        private long _maxFileLength;
        private int _maxFileCount;
        private FileMode append;
        private bool _canSplitData;
        private string _directory;
        private int int_1;

        private int int_2;
        private string _fileName;

        private string _extension;
        public bool CanSplitData
        {
            get
            {
                return _canSplitData;
            }
            set
            {
                _canSplitData = value;
            }
        }

        public int MaxFileCount => _maxFileCount;
        public long MaxFileLength => _maxFileLength;

        public StreamWith(string path, long maxFileLength, int maxFileCount, FileMode append)
            : base(path, getModel(append), FileAccess.Write)
        {
            method_0(path, maxFileLength, maxFileCount, append);
        }

        private void method_0(string filePath, long maxFileLength, int maxFileCount, FileMode mode)
        {
            if (maxFileLength <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid maximum file length");
            }
            if (maxFileCount <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid maximum file count");
            }
            _maxFileLength = maxFileLength;
            _maxFileCount = maxFileCount;
            _canSplitData = true;
            string fullPath = Path.GetFullPath(filePath);
            _directory = Path.GetDirectoryName(fullPath);
            _fileName = Path.GetFileNameWithoutExtension(fullPath);
            _extension = Path.GetExtension(fullPath);
            int_1 = 1;
            for (int num = 10; num < _maxFileCount; num *= 10)
            {
                int_1++;
            }
            if ((uint)(mode - 1) <= 1u || mode == FileMode.Truncate)
            {
                for (int i = 0; i < _maxFileCount; i++)
                {
                    string newFileName = getNewFileName(i);
                    if (File.Exists(newFileName))
                    {
                        File.Delete(newFileName);
                    }
                }
                return;
            }
            for (int i = 0; i < _maxFileCount; i++)
            {
                if (File.Exists(getNewFileName(i)))
                {
                    int_2 = i + 1;
                }
            }
            if (int_2 == _maxFileCount)
            {
                int_2 = 0;
            }
            Seek(0L, SeekOrigin.End);
        }

        private string getNewFileName(int int_3)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("D{0}", int_1);
            StringBuilder stringBuilder2 = new StringBuilder();
            if (_extension.Length > 0)
            {
                stringBuilder2.AppendFormat("{0}{1}{2}", _fileName, int_3.ToString(stringBuilder.ToString()), _extension);
            }
            else
            {
                stringBuilder2.AppendFormat("{0}{1}", _fileName, int_3.ToString(stringBuilder.ToString()));
            }
            return Path.Combine(_directory, stringBuilder2.ToString());
        }

        private static FileMode getModel(FileMode fileMode)
        {
            return (fileMode == FileMode.Append) ? FileMode.OpenOrCreate : fileMode;
        }
    }
}