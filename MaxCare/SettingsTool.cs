using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SettingsTool
{
	private static Dictionary<string, JSON_Settings> dictionary_0 = new Dictionary<string, JSON_Settings>();

	public static JSON_Settings GetSettings(string string_0, bool bool_0 = false)
	{
		if (bool_0)
		{
			smethod_1(string_0);
		}
		else if (!dictionary_0.ContainsKey(string_0))
		{
			dictionary_0.Add(string_0, new JSON_Settings(string_0));
		}
		return dictionary_0[string_0];
	}

	private static void smethod_1(string string_0)
	{
		if (dictionary_0.ContainsKey(string_0))
		{
			dictionary_0[string_0] = new JSON_Settings(string_0);
		}
		else
		{
			dictionary_0.Add(string_0, new JSON_Settings(string_0));
		}
	}

	public static void Save(string E40CDAB2)
	{
		if (dictionary_0.ContainsKey(E40CDAB2))
		{
			dictionary_0[E40CDAB2].method_7();
		}
		smethod_1(E40CDAB2);
	}

	public static string GetPathProfile()
	{
		string text = dictionary_0["configGeneral"].GetValue("txbPathProfile");
		if (!text.Contains('\\'))
		{
			text = FileHelper.GetPathToCurrentFolder() + "\\" + ((text == "") ? "profiles" : text);
		}
		if (!Directory.Exists(text))
		{
			return FileHelper.GetPathToCurrentFolder() + "\\profiles";
		}
		return text;
	}

	public static string B69B10B2()
	{
		return FileHelper.GetPathToCurrentFolder() + "\\backup";
	}
}
