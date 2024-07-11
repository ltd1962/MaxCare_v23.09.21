using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace fUpdate;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
        Tool.softname = Regex.Match(File.ReadAllText(Application.StartupPath + "\\update.ini"), "\\[(.*?)\\]").Groups[1].Value;
        Application.Run(new fUpdate());
	}
}
