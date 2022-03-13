using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MainFormLib;
namespace svr
{
    public partial class Version : Form
    {
		public enum FileInfoFlags
		{
			SHGFI_ICON = 0x100,
			SHGFI_DISPLAYNAME = 0x200,
			SHGFI_TYPENAME = 0x400,
			SHGFI_ATTRIBUTES = 0x800,
			SHGFI_ICONLOCATION = 0x1000,
			SHGFI_EXETYPE = 0x2000,
			SHGFI_SYSICONINDEX = 0x4000,
			SHGFI_LINKOVERLAY = 0x8000,
			SHGFI_ATTR_SPECIFIED = 0x20000,
			SHGFI_LARGEICON = 0,
			SHGFI_SMALLICON = 1,
			SHGFI_OPENICON = 2,
			SHGFI_SHELLICONSIZE = 4,
			SHGFI_PIDL = 8,
			SHGFI_USEFILEATTRIBUTES = 0x10,
			SHGFI_ADDOVERLAYS = 0x20,
			SHGFI_OVERLAYINDEX = 0x40
		}

		public struct FileInfoStruct
		{
			public IntPtr hIcon;

			public int iIcon;

			public int dwAttributes;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}

	
		public Version(string text)
        {
            InitializeComponent();
			Text = text;
		}

		private void FormVersion_Load(object sender, EventArgs e)
		{
			labelApplication.Text = GetFileInfomation(Assembly.GetEntryAssembly());//GetEntryAssembly获取的是当前应用程序第一个启动的程序，一般就是xxx.exe文件。
			labelSrvtools.Text = GetFileInfomation(Assembly.GetExecutingAssembly());//GetExecutingAssembly获取的是当前执行的方法所在的程序文件，可能是.exe，也可能是当前方法所在的.dll文件。
			labelInfoRemoteModule.Text = GetFileInfomation(Assembly.GetAssembly(typeof(BaseForm)));
			//labelInfoRemoteModule.Text = GetFileInfomation(Assembly.GetCallingAssembly());
			if (File.Exists(Application.StartupPath + "\\MainFormLib.dll"))
			{
				labelFLRunTime.Text = GetFileInfomation(Application.StartupPath + "\\MainFormLib.dll", includecaption: false);
			}
			else
			{
				base.Height = 298;
				groupBox4.Visible = false;
			}
			if (base.Owner != null && base.Owner != null)
			{
				Form owner = base.Owner;
				if (owner.Icon != null)
				{
					pictureBoxApplication.Image = owner.Icon.ToBitmap();
				}
			}
			Icon largeIcon = GetLargeIcon(Environment.SystemDirectory + "\\shell32.dll");
			if (largeIcon != null)
			{
				Bitmap image = largeIcon.ToBitmap();
				image.Save(@"C:\Users\admin\Desktop\dll.png", System.Drawing.Imaging.ImageFormat.Png);
				pictureBoxSrvtools.Image = image;
				pictureBoxInfoRemoteModule.Image = image;
				pictureBoxFLRunTime.Image = image;
			}
		}

		private void buttonAssembly_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Application.StartupPath;
			openFileDialog.Title = "Select a file:";
			openFileDialog.Filter = "Assembly File(*.exe;*.dll)|*.exe;*.dll";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, GetFileInfomation(openFileDialog.FileName, includecaption: true), "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private string GetFileInfomation(string filename, bool includecaption)
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filename);
			StringBuilder stringBuilder = new StringBuilder();
			if (includecaption)
			{
				stringBuilder.AppendLine($"Name:\t\t{Path.GetFileName(filename)}");
				stringBuilder.AppendLine($"Version:\t\t{versionInfo.FileVersion}");
				stringBuilder.AppendLine($"Description:\t{versionInfo.Comments}");
			}
			else
			{
				stringBuilder.AppendLine(Path.GetFileName(filename));
				stringBuilder.AppendLine(versionInfo.FileVersion);
				stringBuilder.AppendLine(versionInfo.Comments);
			}
			return stringBuilder.ToString();
		}

		private string GetFileInfomation(Assembly assembly)
		{
			return GetFileInfomation(assembly.Location, includecaption: false);
		}

		[DllImport("shell32.dll ", EntryPoint = "SHGetFileInfo")]
		public static extern int GetFileInfo(string pszPath, int dwFileAttributes, ref FileInfoStruct psfi, int cbFileInfo, int uFlags);

		public static Icon GetLargeIcon(string pFilePath)
		{
			FileInfoStruct psfi = default(FileInfoStruct);
			GetFileInfo(pFilePath, 0, ref psfi, Marshal.SizeOf((object)psfi), 256);
			try
			{
				return Icon.FromHandle(psfi.hIcon);
			}
			catch
			{
				return null;
			}
		}

		public static Icon GetSmallIcon(string pFilePath)
		{
			FileInfoStruct psfi = default(FileInfoStruct);
			GetFileInfo(pFilePath, 0, ref psfi, Marshal.SizeOf((object)psfi), 257);
			try
			{
				return Icon.FromHandle(psfi.hIcon);
			}
			catch
			{
				return null;
			}
		}


	}
}
