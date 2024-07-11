using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal static class Class2
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Class3.string_1 = Regex.Match(File.ReadAllText(Application.StartupPath + "\\update.ini"), "\\[(.*?)\\]").Groups[1].Value;
		Application.Run(new fUpdate());
	}
}
