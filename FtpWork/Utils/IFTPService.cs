using FluentFTP;
using System;

namespace FtpWork.Utils
{
    public interface IFTPService
    {

        Boolean Download(string remotePath, string destFullPath, Action<FtpProgress> ftpProgress);
        Boolean Upload(string sourceFullPath, string remotePath, Action<FtpProgress> ftpProgress);
        void Delete(string fullPath);
        Boolean Move(string sourceFullPath, string destFullPath);
        string GetFtpListItemsJson(string workingDirectory);
        string FindFtpFileName(string remotePath);
    }
}