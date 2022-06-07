using FluentFTP;
using FluentFTP.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FtpWork.Utils
{
    public class FTPService : IFTPService
    {
        private string _host;
        private int _port;
        private string _user;
        private string _password;
        private FtpClient _ftpClient;
        /// <summary>
        /// https://github.com/robinrodricks/FluentFTP/wiki
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public FTPService(string host, int port, string user, string password)
        {
            this._host = host;
            this._port = port;
            this._user = user;
            this._password = password;
            _ftpClient = new FtpClient(_host, _port, _user, _password);
            
        }

        public Boolean Download(string remotePath, string destFullPath, Action<FtpProgress> ftpProgress)
        {
            string destPath = Path.GetDirectoryName(destFullPath);

            string destFileName = Path.GetFileName(destFullPath);

            if (!Directory.Exists(destPath))//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(destPath);
            }

            FileStream fileStream = new FileStream(destFullPath, FileMode.OpenOrCreate);

            try
            {
                if (!_ftpClient.IsConnected)
                {
                    _ftpClient.AutoConnect();
                }

                string workPath = Path.GetDirectoryName(remotePath);
                _ftpClient.SetWorkingDirectory(workPath);


                Boolean result = _ftpClient.Download(fileStream, remotePath, 0L, ftpProgress);
                fileStream.Close();
                return result;
            }
            catch (Exception e)
            {
                fileStream.Close();
                throw new Exception("Download error:" + (e.InnerException == null ? e.Message : e.InnerException.Message) + ",remote:" + remotePath + ",dest:" + destFullPath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

       

        public Boolean Upload(string sourceFullPath, string remotePath, Action<FtpProgress> ftpProgress)
        {
            FileStream fileStream = new FileStream(sourceFullPath, FileMode.OpenOrCreate);
            try
            {
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }

                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(remotePath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(remotePath));
                }

                Boolean result = _ftpClient.Upload(fileStream, remotePath, FtpRemoteExists.Overwrite, false , ftpProgress).IsSuccess();
                fileStream.Close();

                return result;
            }
            catch (Exception e)
            {
                fileStream.Close();
                throw new Exception("Upload error:" + (e.InnerException == null ? e.Message : e.InnerException.Message) + ",source:" + sourceFullPath + ",remote:" + remotePath);
            }
            finally
            {
                if (this._ftpClient.IsConnected)
                {
                    this._ftpClient.Disconnect();
                }
            }
        }

        public Boolean UploadFile(string sourceFullPath, string remotePath)
        {
            string test = string.Empty;
            try
            {
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }

                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(remotePath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(remotePath));
                }
                Boolean result = false;
                try
                {
                    if (!File.Exists(sourceFullPath))
                    {
                        throw new Exception("file not found:" + sourceFullPath);
                    }
                    _ftpClient.SetWorkingDirectory(Path.GetDirectoryName(remotePath));
                    result = _ftpClient.UploadFile(sourceFullPath, Path.GetFileName(remotePath), FtpRemoteExists.Overwrite).IsSuccess();
                }
                catch (Exception ex)
                {
                    throw new Exception("FtpUploadFile error:" + (ex.InnerException == null ? ex.Message + "," + ex.StackTrace : ex.InnerException.Message + "," + ex.InnerException.StackTrace) + ",source:" + sourceFullPath + ",remote:" + remotePath);
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception("UploadFile error:" + (e.InnerException == null ? e.Message + "," + e.StackTrace : e.InnerException.Message + "," + e.InnerException.StackTrace) + ",source:" + sourceFullPath + ",remote:" + remotePath);
            }
            finally
            {
                if (this._ftpClient.IsConnected)
                {
                    this._ftpClient.Disconnect();
                    _ftpClient.Dispose();
                }
            }
        }

        public void Delete(string fullPath)
        {
            try
            {
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }
                _ftpClient.DeleteFile(fullPath);
            }
            catch (Exception e)
            {
                string message = (e.InnerException == null ? e.Message : e.InnerException.Message);
                throw new Exception("Delete error:" + message + ",path:" + fullPath);
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
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }
                _ftpClient.DeleteDirectory(path);
            }
            catch (Exception e)
            {
                string message = (e.InnerException == null ? e.Message : e.InnerException.Message);
                throw new Exception("DeleteDirectory error:" + message + ",path:" + path);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public Boolean Move(string sourceFullPath, string destFullPath)
        {
            try
            {
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }
                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(destFullPath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(destFullPath));
                }
                Boolean result = _ftpClient.MoveFile(sourceFullPath, destFullPath, FtpRemoteExists.Overwrite);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Move error:" + (e.InnerException == null ? e.Message : e.InnerException.Message) + ",source:" + sourceFullPath + ",dest:" + destFullPath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public Boolean Copy(string sourceFullPath, string destFullPath)
        {
            try
            {
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }
                if (!_ftpClient.DirectoryExists(Path.GetDirectoryName(destFullPath)))
                {
                    _ftpClient.CreateDirectory(Path.GetDirectoryName(destFullPath));
                }
                Boolean result = _ftpClient.MoveFile(sourceFullPath, destFullPath, FtpRemoteExists.Overwrite);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Move error:" + (e.InnerException == null ? e.Message : e.InnerException.Message) + ",source:" + sourceFullPath + ",dest:" + destFullPath);
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
                if (!this._ftpClient.IsConnected)
                {
                    this._ftpClient.AutoConnect();
                }
                _ftpClient.Encoding = Encoding.GetEncoding("UTF-8");
                if (!string.IsNullOrEmpty(workingDirectory))
                    _ftpClient.SetWorkingDirectory(workingDirectory);
                FtpListItem[] listItems = _ftpClient.GetListing();

                var serializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()//,
                    //NullValueHandling = NullValueHandling.Ignore
                };
                _ftpClient.Disconnect();
                return JsonConvert.SerializeObject(listItems, serializerSettings);
            }
            catch (Exception e)
            {
                throw new Exception("GetFtpListItemsJson:" + (e.InnerException == null ? e.Message : e.InnerException.Message));
            }
            finally
            {
                if (this._ftpClient.IsConnected)
                {
                    this._ftpClient.Disconnect();
                }
            }
        }

        public string FindFtpFileName(string remotePath)
        {
            try
            {
                string workPath = Path.GetDirectoryName(remotePath);
                string fileName = Path.GetFileName(remotePath);
                string result = string.Empty;
                if (!_ftpClient.FileExists(remotePath))
                {
                    _ftpClient.SetWorkingDirectory(workPath);
                    FtpListItem[] listItems = _ftpClient.GetListing();
                    foreach (var item in listItems)
                    {
                        if (item.Name.Contains(fileName))
                        {
                            result = item.Name;
                            break;
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("FindFtpFile error:" + (e.InnerException == null ? e.Message : e.InnerException.Message) + ",remote:" + remotePath);
            }
            finally
            {
                if (_ftpClient.IsConnected)
                {
                    _ftpClient.Disconnect();
                }
            }
        }

        public string FindFtpMapId(string remotePath, int idStart, int idLength, string slotNo)
        {
            try
            {
                string workPath = Path.GetDirectoryName(remotePath);
                //string fileName = Path.GetFileName(remotePath);
                string result = string.Empty;
                if (_ftpClient.DirectoryExists(workPath))
                {
                    _ftpClient.SetWorkingDirectory(workPath);
                    FtpListItem[] listItems = _ftpClient.GetListing();
                    foreach (var item in listItems)
                    {
                        string slot = item.Name.Substring(idStart, idLength).Replace(".", "");
                        // 去除非数字
                        slot = Regex.Replace(slot, @"[^\d]*", "");
                        slot = slot.PadLeft(idLength, '0');
                        if (slot == slotNo)
                        {
                            result = item.Name;
                            break;
                        }
                    }
                }
                if (string.IsNullOrEmpty(result))
                {
                    throw new Exception("Cant find slot:" + slotNo + ",ftpWorkingDir:" + _ftpClient.GetWorkingDirectory() + ",remotePath para:" + remotePath);
                }
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("FindFtpMapId error:" + (e.InnerException == null ? e.Message : e.InnerException.Message) + ",remote:" + remotePath);
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

}
