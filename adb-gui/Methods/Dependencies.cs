using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.Threading;
namespace adbGUI.Methods
{
	public static class Dependencies
	{
		private static readonly string appPath = Path.Combine(Thread.GetDomain().BaseDirectory);
		private static readonly string downloadedZipFile = appPath + "platform-tools-latest-windows.zip";

		private static readonly string libPath = Path.Combine(appPath, "dev-lib");
	
		public static readonly Uri downloadUri = new Uri("https://dl.google.com/android/repository/platform-tools-latest-windows.zip");

		private static readonly string[] StrFiles =
			{"adb.exe", "AdbWinApi.dll", "AdbWinUsbApi.dll", "fastboot.exe", "libwinpthread-1.dll"};

		public static void Check()
		{ 
            var pass =
				MessageBox.Show("刷机有风险，由此软件产生的对你设备的损坏，本项目所有作者均不负担由你操作失误带来的损失",
				"警告",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
				);
			switch(pass)
            {
				case DialogResult.Yes:
					break;
				default: Environment.Exit(0);
					break;
			}

			SetEnvVariable();

			if (FilesExist()) return;

			var dialogResult =
				MessageBox.Show(
					@"依赖的adb库文件缺失，现在下载?",
					@"错误：文件缺失！",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Error);
            
            switch (dialogResult)
			{
				case DialogResult.Yes:
					DownloadFiles();
					ExtractFiles();
					
					MessageBox.Show(@"文件已下载", @"已完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				default:
					Environment.Exit(0);

			break;

			}

		}

		private static bool FilesExist()
		{
			foreach (var file in StrFiles)
				if (!File.Exists(Path.Combine(@"adb-lib", file)))
					return false;
			return true;
		}

		private static void DownloadFiles()
		{
			using (var wc = new WebClient())
			{
				wc.DownloadFile(downloadUri, downloadedZipFile);
			}
		}

		private static void ExtractFiles()
		{
			try
			{
				ZipFile.ExtractToDirectory(downloadedZipFile, appPath);

			}
			catch
            {
            }
			Directory.CreateDirectory("adb-lib");
			foreach (var file in StrFiles)
				File.Copy(Path.Combine(appPath, "platform-tools", file), Path.Combine(appPath, "adb-lib",file));
		}

		private static void SetEnvVariable()
		{
			string oldValue = Environment.GetEnvironmentVariable("PATH");

			Environment.SetEnvironmentVariable("PATH", oldValue + ";" + appPath+"adb-lib");
		}

		private static void ExtractionCompleted()
		{
			var extractedFilesPath = Path.GetTempPath() + "platform-tools";

			foreach (var item in StrFiles)
				try
				{
					File.Copy(extractedFilesPath + "\\" + item, item);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
		}
	}
}