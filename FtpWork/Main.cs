using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FtpWork.Utils;
using FluentFTP;
using Newtonsoft.Json;

namespace FtpWork
{
    public partial class Main : Form
    {
        FTPService fTPService;
        Thread uploadThread;
        Thread downloadThread;
        ulong fileLength;
        List<ProgressBar> progresList;
        List<ListViewItem> selectedItems;
        ProgressBar currentProgress;


        public Main()
        {
            InitializeComponent();

            progresList = new List<ProgressBar>();
            selectedItems = new List<ListViewItem>();

            listLocalFile.SmallImageList = iconList;
            listRemoteFile.SmallImageList = iconList;

            loadLocalDirList();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLocalToRemote_Click(object sender, EventArgs e)
        {

            if (listLocalFile.SelectedItems.Count == 0)
            {
                return;
            }

            selectedItems.Clear();
            foreach (ListViewItem item in listLocalFile.SelectedItems)
            {
                selectedItems.Add(item);
            }
            progresList.Clear();
            foreach (ListViewItem item in selectedItems)
            {
                progresList.Add(addProgress(item.Text, lblLocalDirPath.Text, lblRemoteDirPath.Text));
            }

            try
            {
                uploadThread = new Thread(() => uploadThreadFunc());

                uploadThread.IsBackground = true;
                uploadThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            loadRemoteDirList();
        }

        private void btnRemoteToLocal_Click(object sender, EventArgs e)
        {

            if (listRemoteFile.SelectedItems.Count == 0)
            {
                return;
            }

            selectedItems.Clear();
            foreach (ListViewItem item in listRemoteFile.SelectedItems)
            {
                selectedItems.Add(item);
            }
            progresList.Clear();
            foreach (ListViewItem item in selectedItems)
            {
                progresList.Add(addProgress(item.Text, lblRemoteDirPath.Text, lblLocalDirPath.Text));
            }

            try
            {
                downloadThread = new Thread(() => downloadThreadFunc());

                downloadThread.IsBackground = true;
                downloadThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            loadLocalDirList();
        }

        private void btnFtpConnect_Click(object sender, EventArgs e)
        {
            try
            {
                fTPService = new FTPService(tbFtpHost.Text, 21, tbFtpUserName.Text, tbPassword.Text);

                lblRemoteDirPath.Text = "/";
                loadRemoteDirList();
                btnRemoteToLocal.Enabled = true;
                btnLocalToRemote.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void loadRemoteDirList()
        {
            listRemoteFile.Items.Clear();
            listRemoteFile.Items.Add(new ListViewItem(new string[] { "..", "" }, 1));
            try
            {
                FtpListItem[] listItems = JsonConvert.DeserializeObject<FtpListItem[]>(fTPService.GetFtpListItemsJson(lblRemoteDirPath.Text));
                foreach (var entry in listItems)
                {
                    String FileNameOnly = entry.Name;
                    String FileSize = entry.Size.ToString();
                    string[] items = new string[] { FileNameOnly, FileSize };
                    if (entry.Type == FtpFileSystemObjectType.Directory)
                    {
                        Console.WriteLine("000000000" + entry.Type);
                        listRemoteFile.Items.Add(new ListViewItem(items, 1));
                    }
                    else 
                    {
                        Console.WriteLine("111111111" + entry.Type);
                        listRemoteFile.Items.Add(new ListViewItem(items, 0));
                    }
                    

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void loadLocalDirList()
        {
            listLocalFile.Items.Clear();

            listLocalFile.Items.Add(new ListViewItem(new string[] { "..", "" }, 1));

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(lblLocalDirPath.Text);
            foreach (System.IO.DirectoryInfo Dir in di.GetDirectories())
            {
                String FileNameOnly = Dir.Name;

                string[] items = new string[] { FileNameOnly, "" };
                ListViewItem lvi = new ListViewItem(items, 1);
                listLocalFile.Items.Add(lvi);
            }
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                String FileNameOnly = File.Name;
                String FullFileName = File.FullName;
                String FileSize = File.Length.ToString("#,##0") + "B";

                string[] items = new string[] { FileNameOnly, FileSize };
                ListViewItem lvi = new ListViewItem(items, 0);
                listLocalFile.Items.Add(lvi);
            }
        }

        private void listRemoteFile_DoubleClick(object sender, EventArgs e)
        {
            if (listRemoteFile.SelectedItems[0].Text == ".")
            {
                loadRemoteDirList();
                return;
            }
            if (listRemoteFile.SelectedItems[0].Text == "..")
            {
                lblRemoteDirPath.Text = get_parent_dir_path(lblRemoteDirPath.Text);
                loadRemoteDirList();
                return;
            }
            if (listRemoteFile.SelectedItems[0].ImageIndex == 1)
            {
                lblRemoteDirPath.Text += "/" + listRemoteFile.SelectedItems[0].Text;
                loadRemoteDirList();
            }
        }

        private void listLocalFile_DoubleClick(object sender, EventArgs e)
        {
            if (listLocalFile.SelectedItems[0].Text == ".")
            {
                loadLocalDirList();
                return;
            }
            if (listLocalFile.SelectedItems[0].Text == "..")
            {
                lblLocalDirPath.Text = get_parent_dir_path(lblLocalDirPath.Text);
                loadLocalDirList();
                return;
            }
            if (listLocalFile.SelectedItems[0].ImageIndex == 1)
            {
                lblLocalDirPath.Text += "/" + listLocalFile.SelectedItems[0].Text;
                loadLocalDirList();
            }
        }

        private string get_parent_dir_path(string path)
        {
            // notice that i used two separators windows style "\\" and linux "/" (for bad formed paths)
            // We make sure to remove extra unneeded characters.
            string trim = path.TrimEnd('/', '\\');
            int index = trim.LastIndexOfAny(new char[] { '\\', '/' });

            // now if index is >= 0 that means we have at least one parent directory, otherwise the given path is the root most.
            if (index >= 0)
            {
                if (path.Remove(index).Last() == ':')
                {
                    return path.Remove(index) + "/";
                }
                else
                {
                    return path.Remove(index);
                }
            }
            else
            {
                return path;
            }
        }

        private void btnStatusClear_Click(object sender, EventArgs e)
        {
            listProgressStatus.Items.Clear();
            listProgressStatus.Controls.Clear();
        }
        private void downloadThreadFunc()
        {
            try
            {

                int current = 0;
                foreach (ListViewItem item in selectedItems)
                {
                    string localPath = lblLocalDirPath.Text + "/" + item.Text;
                    string remotePath = lblRemoteDirPath.Text + "/" + item.Text;
                    Stream fileStream = File.Create(localPath);
                    //fTPService.Download(remotePath, localPath);
                    FtpClient ftpClient = new FtpClient("47.103.68.175", 21, "test", "123456");
                    ftpClient.Connect();
                    ftpClient.Download(fileStream, remotePath, 0, FtpProgress);

                    fileStream.Close();
                    current++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            this.Invoke(new Action(loadLocalDirList));
        }



        private void FtpProgress(FtpProgress obj)
        {

            double progress;
            long bytesTransferred;
            double transferspeed;
            TimeSpan remainingtime;
            string localPath;
            string remotePath;
            FtpProgress metaProgress;
            Console.WriteLine((int)(Math.Round((obj.Progress), 0)));
            int percent = (int)(obj.Progress);
   
            progressBar1.Invoke(
                (MethodInvoker)delegate { progressBar1.Value = percent; });

        }

        private void uploadThreadFunc()
        {
            try
            {
                int current = 0;
                foreach (ListViewItem item in selectedItems)
                {
                    string localPath = lblLocalDirPath.Text + "/" + item.Text;
                    string remotePath = lblRemoteDirPath.Text + "/" + item.Text;

                    fTPService.UploadFile(localPath, remotePath);
                    current++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            this.Invoke(new Action(loadRemoteDirList));
        }

        private ProgressBar addProgress(string fileName, string source, string dest)
        {
            ListViewItem lvi = new ListViewItem();
            ProgressBar pb = new ProgressBar();
            lvi.SubItems[0].Text = "ddd";
            lvi.SubItems.Add(fileName);
            lvi.SubItems.Add(source);
            lvi.SubItems.Add(dest);
            listProgressStatus.Items.Add(lvi);

            Rectangle r = lvi.SubItems[0].Bounds;
            pb.SetBounds(r.X, r.Y, 100, r.Height);
            pb.Minimum = 0;
            pb.Maximum = 100;
            pb.Value = 0;
            pb.Parent = listProgressStatus;
            listProgressStatus.Controls.Add(pb);
            
           

            return pb;
        }

        private void InitProgresBar(ProgressBar progress, ulong max)
        {
            fileLength = max;
            currentProgress = progress;
            // Update progress bar on foreground thread
            progress.Invoke(
                (MethodInvoker)delegate { progress.Value = (int)0; progress.Maximum = (int)100; });
        }

        private void UpdateProgresBar(double uploaded)
        {
            int percent = (int)((uploaded * 100) / fileLength);
            // Update progress bar on foreground thread
            currentProgress.Invoke(
                (MethodInvoker)delegate { currentProgress.Value = percent; });
        }


        private void listProgressStatus_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.NewWidth = listProgressStatus.Columns[e.ColumnIndex].Width;
                e.Cancel = true;
            }
        }

        private void btnRemoteFileDelete_Click(object sender, EventArgs e)
        {

            if (listRemoteFile.SelectedItems.Count == 0)
            {
                return;
            }

            try
            {
                foreach (ListViewItem item in listRemoteFile.SelectedItems)
                {
                    string remotePath = lblRemoteDirPath.Text + "/" + item.Text;
                    fTPService.Delete(remotePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            loadRemoteDirList();
        }

        private void btnLocalFileDelete_Click(object sender, EventArgs e)
        {
            if (listLocalFile.SelectedItems.Count == 0)
            {
                return;
            }

            foreach (ListViewItem item in listLocalFile.SelectedItems)
            {
                string localPath = lblLocalDirPath.Text + "/" + item.Text;
                File.Delete(localPath);
            }

            loadLocalDirList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
