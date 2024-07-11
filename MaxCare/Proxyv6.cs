using System;
using Newtonsoft.Json.Linq;

internal class Proxyv6 : GClass3
{
	private object object_0 = new object();

	private object object_1 = new object();

	public int C3AE3F0D;

	private string D8050211;

	public string AB97B814;

	public string string_0 = "";

	public int int_0 = 0;

	public int int_1 = 0;

	public int F2B49F13 = 3;

	public Proxyv6(string string_1, int int_2)
	{
		D8050211 = string_1;
		F2B49F13 = int_2;
		string_0 = "";
	}

	public static bool smethod_0(string string_1)
	{
		try
		{
			string text = Common.RequestGet("https://api.proxyv6.net/key/get-current-ip?api_key_rotating=" + string_1 + "&authIp=" + Common.CheckIP(""));
			return text.Contains("SUCCESS");
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool method_0()
	{
		bool result = false;
		try
		{
			while (true)
			{
				string e1AF = "https://api.proxyv6.net/key/get-new-ip?api_key_rotating=" + D8050211 + "&authIp=" + Common.CheckIP("");
				try
				{
					string json = Common.RequestGet(e1AF);
					JObject jObject = JObject.Parse(json);
					if (jObject["message"].ToString() == "SUCCESS")
					{
						AB97B814 = jObject["data"]["host"].ToString() + ":" + jObject["data"]["port"].ToString();
						string_0 = jObject["data"]["ip"].ToString();
						result = true;
					}
					else if (jObject["message"].ToString() == "GET_IP_TOO_FAST")
					{
						int num = Convert.ToInt32(jObject["data"]["remainTime"].ToString());
						Common.Sleep(num + 1);
						continue;
					}
				}
				catch (Exception)
				{
				}
				break;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void method_1()
	{
		lock (object_0)
		{
			int_0--;
			if (int_0 == 0 && int_1 == F2B49F13)
			{
				int_1 = 0;
			}
		}
	}
}
