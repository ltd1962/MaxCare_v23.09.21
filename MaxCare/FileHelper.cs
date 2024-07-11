using System;
using System.IO;
using System.Windows.Forms;

public class FileHelper
{
	public static string GetPathToCurrentFolder()
	{
		return Path.GetDirectoryName(Application.ExecutablePath);
	}

	public static string smethod_1()
	{
		string result = "";
		try
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				result = folderBrowserDialog.SelectedPath;
			}
		}
		catch
		{
		}
		return result;
	}

	public static string C61FF4B9(string DC333287 = "Chọn File txt", string string_0 = "C:\\", string string_1 = "txt Files (*.txt)|*.txt|All files (*.*)|*.*")
	{
		string result = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = string_1;
			openFileDialog.InitialDirectory = string_0;
			openFileDialog.Title = DC333287;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_2(string string_0, string string_1, bool DA22B515)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			if (!directoryInfo.Exists)
			{
				return false;
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			Directory.CreateDirectory(string_1);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				string destFileName = Path.Combine(string_1, fileInfo.Name);
				fileInfo.CopyTo(destFileName, overwrite: true);
			}
			if (DA22B515)
			{
				DirectoryInfo[] array2 = directories;
				foreach (DirectoryInfo directoryInfo2 in array2)
				{
					string string_2 = Path.Combine(string_1, directoryInfo2.Name);
					smethod_2(directoryInfo2.FullName, string_2, DA22B515);
				}
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void smethod_3(string string_0)
	{
		try
		{
			File.AppendAllText(string_0, "");
		}
		catch
		{
		}
	}

	public static void smethod_4(string string_0)
	{
		try
		{
			Directory.CreateDirectory(string_0);
		}
		catch
		{
		}
	}
}
