using System;
using System.Threading;
using Newtonsoft.Json.Linq;

public class OBCProxyv2 : GClass3
{
	public int int_0;

	private string string_0;

	public string B8A4A88E;

	public string string_1 = "";

	public bool bool_0 = true;

	public int FDB04602 = 0;

	public int int_1 = 0;

	public int A239012F = 3;

	private string string_2 = "";

	public OBCProxyv2(string string_3, string string_4, int B4A9042F, int D6396EB2, string string_5)
	{
		string_0 = string_3;
		B8A4A88E = string_4;
		A239012F = D6396EB2;
		string_1 = "";
		int_0 = B4A9042F;
		method_2(string_5);
	}

	private void F9A4E331(string string_3)
	{
	}

	public bool resetOBCProxyv2()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + B8A4A88E;
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string text2 = fB87CFA.RequestGet(text);
			F9A4E331(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"].ToString() == "command_sent" || JObject.Parse(text2)["msg"].ToString() == "OK" || JObject.Parse(text2)["msg"].ToString().ToLower() == "ok"))
			{
				result = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"].ToString().ToLower() == "0")
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public bool method_1()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + B8A4A88E;
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string text2 = fB87CFA.RequestGet(text);
			F9A4E331(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			bool flag = false;
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"].ToString() == "command_sent" || JObject.Parse(text2)["msg"].ToString() == "OK" || JObject.Parse(text2)["msg"].ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"].ToString().ToLower() == "0")
			{
				flag = true;
			}
			if (flag)
			{
				return AD1782BC();
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void DB92108C(int BCAB3D0C = 1)
	{
		FDB04602--;
		if (BCAB3D0C == 0 && FDB04602 == 0 && int_1 == A239012F)
		{
			int_1 = 0;
		}
	}

	public bool AD1782BC(int int_2 = -1)
	{
		if (int_2 == -1)
		{
			int_2 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIPObcProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/status?proxy=" + B8A4A88E;
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string text2 = "";
			do
			{
				text2 = fB87CFA.RequestGet(text);
				F9A4E331(text + ": " + text2);
				try
				{
					if (!text2.Contains("public_ip_v6") && !text2.Contains("public_ip"))
					{
						flag = Convert.ToBoolean(JObject.Parse(text2)["status"].ToString());
					}
					else
					{
						string text3 = B8A4A88E.Split(':')[1];
						if (text3.StartsWith("4") || text3.StartsWith("5"))
						{
							flag = JObject.Parse(text2)["public_ip"].ToString() != "" && JObject.Parse(text2)["public_ip"].ToString() != "CONNECT_INTERNET_ERROR";
						}
						else if (text3.StartsWith("6") || text3.StartsWith("7"))
						{
							flag = JObject.Parse(text2)["public_ip_v6"].ToString() != "" && JObject.Parse(text2)["public_ip_v6"].ToString() != "CONNECT_INTERNET_ERROR";
						}
					}
				}
				catch
				{
					flag = JObject.Parse(text2)["error_code"].ToString() == "0";
				}
				Thread.Sleep(1000);
			}
			while (!flag && Environment.TickCount - tickCount < int_2 * 1000);
		}
		catch
		{
		}
		return flag;
	}

	public string C63B269D()
	{
		return string_2;
	}

	public void method_2(string E506B80E)
	{
		string_2 = E506B80E;
	}

	public string method_3()
	{
		return string_0;
	}

	public string BB2329B6()
	{
		return B8A4A88E.Split(':')[1];
	}
}
