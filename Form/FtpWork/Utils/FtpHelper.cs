using FluentFTP;
using FluentFTP.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FtpWork.Utils
{
    public class FtpHelper : IFtpHelper
    {
        private string _host;

        private int _port;

        private string _user;

        private string _password;

        private FtpClient _ftpClient;

        public FtpHelper(string host, int port, string user, string password)
        {
            _host = host;
            _port = port;
            _user = user;
            _password = password;
            _ftpClient = new FtpClient(_host, _user, _password, _port);
        }
        public bool Download(string remotePath, string destFullPath)
        {
            string directoryName = Path.GetDirectoryName(destFullPath);
            string fileName = Path.GetFileName(destFullPath);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }

            FileStream fileStream = new FileStream(destFullPath, FileMode.OpenOrCreate);
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                string directoryName2 = Path.GetDirectoryName(remotePath);
                _ftpClient.SetWorkingDirectory(directoryName2);
                _ftpClient.DownloadFile(fileName, remotePath);
                fileStream.Close();
                return false;
            }
            catch (Exception ex)
            {
                fileStream.Close();
                throw new Exception("Download error:" + ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message) + ",remote:" + remotePath + ",dest:" + destFullPath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public bool Upload(string sourceFullPath, string remotePath)
        {
            //FileStream fileStream = new FileStream(sourceFullPath, FileMode.OpenOrCreate);
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(remotePath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(remotePath));
                }

                bool result = _ftpClient.UploadFile(sourceFullPath, remotePath).IsSuccess();
                // fileStream.Close();
                return result;
            }
            catch (Exception ex)
            {
                //fileStream.Close();
                throw new Exception("Upload error:" + ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message) + ",source:" + sourceFullPath + ",remote:" + remotePath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public bool UploadFile(string sourceFullPath, string remotePath)
        {
            string empty = string.Empty;
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(remotePath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(remotePath));
                }

                bool flag = false;
                try
                {
                    if (!File.Exists(sourceFullPath))
                    {
                        throw new Exception("file not found:" + sourceFullPath);
                    }

                    _ftpClient.SetWorkingDirectory(Path.GetDirectoryName(remotePath));
                    return _ftpClient.UploadFile(sourceFullPath, Path.GetFileName(remotePath)).IsSuccess();
                }
                catch (Exception ex)
                {
                    throw new Exception("FtpUploadFile error:" + ((ex.InnerException == null) ? (ex.Message + "," + ex.StackTrace) : (ex.InnerException.Message + "," + ex.InnerException.StackTrace)) + ",source:" + sourceFullPath + ",remote:" + remotePath);
                }
            }
            catch (Exception ex2)
            {
                throw new Exception("UploadFile error:" + ((ex2.InnerException == null) ? (ex2.Message + "," + ex2.StackTrace) : (ex2.InnerException.Message + "," + ex2.InnerException.StackTrace)) + ",source:" + sourceFullPath + ",remote:" + remotePath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                    _ftpClient.Dispose();
                }
            }
        }

        public void Delete(string fullPath)
        {
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                FtpClient ftpClient = new FtpClient(_host, _user, _password, _port);
                ftpClient.DeleteFile(fullPath);
            }
            catch (Exception ex)
            {
                string text = ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message);
                throw new Exception("Delete error:" + text + ",path:" + fullPath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public void DeleteDir(string path)
        {
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                _ftpClient.DeleteDirectory(path);
            }
            catch (Exception ex)
            {
                string text = ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message);
                throw new Exception("DeleteDirectory error:" + text + ",path:" + path);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public bool Move(string sourceFullPath, string destFullPath)
        {
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(destFullPath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(destFullPath));
                }

                return _ftpClient.MoveFile(sourceFullPath, destFullPath);
            }
            catch (Exception ex)
            {
                throw new Exception("Move error:" + ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message) + ",source:" + sourceFullPath + ",dest:" + destFullPath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public bool Copy(string sourceFullPath, string destFullPath)
        {
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(destFullPath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(destFullPath));
                }

                return _ftpClient.MoveFile(sourceFullPath, destFullPath);
            }
            catch (Exception ex)
            {
                throw new Exception("Move error:" + ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message) + ",source:" + sourceFullPath + ",dest:" + destFullPath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public string GetFtpListItemsJson(string workingDirectory)
        {
            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.Connect();
                }

                //_ftpClient.Encoding = Encoding.GetEncoding("gb2312");
                if (!string.IsNullOrEmpty(workingDirectory))
                {
                    _ftpClient.SetWorkingDirectory(workingDirectory);
                }

                FtpListItem[] listing = _ftpClient.GetListing();
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                _ftpClient.Disconnect();
                return JsonConvert.SerializeObject(listing, settings);
            }
            catch (Exception ex)
            {
                throw new Exception("GetFtpListItemsJson:" + ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message));
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public string FindFtpFileName(string remotePath)
        {
            try
            {
                string directoryName = Path.GetDirectoryName(remotePath);
                string fileName = Path.GetFileName(remotePath);
                string result = string.Empty;
                if (!_ftpClient.FileExists(remotePath))
                {
                    _ftpClient.SetWorkingDirectory(directoryName);
                    FtpListItem[] listing = _ftpClient.GetListing();
                    FtpListItem[] array = listing;
                    foreach (FtpListItem ftpListItem in array)
                    {
                        if (ftpListItem.Name.Contains(fileName))
                        {
                            result = ftpListItem.Name;
                            break;
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("FindFtpFile error:" + ((ex.InnerException == null) ? ex.Message : ex.InnerException.Message) + ",remote:" + remotePath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }


    }

    interface IFtpHelper
    {
        Boolean Download(string remotePath, string destFullPath);
        Boolean Upload(string sourceFullPath, string remotePath);
        void Delete(string fullPath);
        Boolean Move(string sourceFullPath, string destFullPath);
        string GetFtpListItemsJson(string workingDirectory);
        string FindFtpFileName(string remotePath);
    }
}
