using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

internal class TinsoftProxy : GClass3
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string FCAFC08A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int A50D2D2A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_2;

	private object CD8F76B0 = new object();

	public string D3A4AE01 = "";

	private string string_2 = "http://api.proxyfb.com";

	private int DE99D7A9 = 0;

	public bool CF3B9316 = true;

	public int B932E618 = 0;

	public int int_3 = 0;

	public int E18568BD = 3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string B08A5B2F
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return FCAFC08A;
		}
		[CompilerGenerated]
		set
		{
			FCAFC08A = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return A50D2D2A;
		}
		[CompilerGenerated]
		set
		{
			A50D2D2A = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int FFADCD2A
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public TinsoftProxy()
	{
	}

	public TinsoftProxy(string string_3, string string_4, int int_4, int CD9279B8 = 0)
	{
		string_2 = string_3;
		String_0 = string_4;
		B08A5B2F = "";
		String_1 = "";
		Int32_0 = 0;
		Int32_1 = 0;
		FFADCD2A = 0;
		Int32_2 = CD9279B8;
		E18568BD = int_4;
		B932E618 = 0;
		int_3 = 0;
		CF3B9316 = true;
	}

	public void E2854D06()
	{
		lock (CD8F76B0)
		{
			B932E618--;
			if (B932E618 == 0 && int_3 == E18568BD)
			{
				int_3 = 0;
			}
		}
	}

	public bool BF3327BD()
	{
		if (FF924F09())
		{
			try
			{
				string text = new RequestXNet("", "", "", 0).RequestGet($"{string_2}/api/changeProxy.php?key={String_0}&location={Int32_2}");
				if (JObject.Parse(text)["success"].ToString().ToLower() == "true")
				{
					return method_1(text);
				}
			}
			catch
			{
			}
		}
		else
		{
			D3A4AE01 = "Request so fast!";
		}
		return false;
	}

	public string method_0()
	{
		while (!method_1())
		{
		}
		return B08A5B2F;
	}

	public bool method_1(string string_3 = "")
	{
		D3A4AE01 = "";
		FFADCD2A = 0;
		B08A5B2F = "";
		String_1 = "";
		Int32_0 = 0;
		Int32_1 = 0;
		try
		{
			if (string_3 == "")
			{
				string_3 = new RequestXNet("", "", "", 0).RequestGet(string_2 + "/api/getProxy.php?key=" + String_0);
			}
			JObject jObject = JObject.Parse(string_3);
			if (bool.Parse(jObject["success"].ToString()))
			{
				B08A5B2F = jObject["proxy"].ToString();
				string[] array = B08A5B2F.Split(':');
				String_1 = array[0];
				Int32_0 = int.Parse(array[1]);
				Int32_1 = int.Parse(jObject["timeout"].ToString());
				FFADCD2A = int.Parse(jObject["next_change"].ToString());
				D3A4AE01 = "";
				return true;
			}
			D3A4AE01 = jObject["description"].ToString();
			if (jObject["next_change"] != null)
			{
				FFADCD2A = int.Parse(jObject["next_change"].ToString());
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	private bool FF924F09()
	{
		try
		{
			DateTime dateTime = new DateTime(2001, 1, 1);
			long ticks = DateTime.Now.Ticks - dateTime.Ticks;
			int num = (int)new TimeSpan(ticks).TotalSeconds;
			if (num - DE99D7A9 >= 10)
			{
				DE99D7A9 = num;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static string F39AA926(string string_3)
	{
		Console.WriteLine(string_3);
		string text = "";
		try
		{
			using WebClient webClient = new WebClient();
			text = webClient.DownloadString(string_3);
		}
		catch (Exception)
		{
		}
		if (string.IsNullOrEmpty(text))
		{
			text = "";
		}
		return text;
	}

	public static bool smethod_0(string string_3)
	{
		string text = F39AA926("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + string_3);
		if (text != "")
		{
			JObject jObject = JObject.Parse(text);
			if (bool.Parse(jObject["success"].ToString()))
			{
				return true;
			}
		}
		return false;
	}

	public static List<string> smethod_1(string A2911CA5)
	{
		List<string> list = new List<string>();
		try
		{
			RequestXNet fB87CFA = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
			string json = fB87CFA.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + A2911CA5);
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)jObject["data"])
			{
				if (Convert.ToBoolean(item["success"].ToString()))
				{
					list.Add(item["key"].ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}
}
