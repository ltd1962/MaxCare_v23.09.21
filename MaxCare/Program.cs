using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
			if (File.Exists(path))
			{
				try
				{
					List<string> list = new List<string> { "minsoftware" };
					using StreamReader streamReader = new StreamReader(path);
					string empty = string.Empty;
					while ((empty = streamReader.ReadLine()) != null)
					{
						foreach (string item in list)
						{
							if (empty.ToLower().Contains(item))
							{
								MessageBoxHelper.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
								Environment.Exit(0);
							}
						}
					}
				}
				catch
				{
				}
			}
			SetupFolder.CreateBasicFolder();
            //Application.Run(new fIntro());
            Application.Run(new fMain("MrCrack|MrCrack|2050/03/01 00:00:00 AM|MIN231C399297F9AD197CD2CBE0DBD92108"));
        }
		catch (Exception exception_)
		{
			MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!", 2);
			Common.ExportError(null, exception_, "Run Program2");
			Environment.Exit(0);
		}
	}
}
