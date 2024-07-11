using System;
using System.Threading;
using Newtonsoft.Json.Linq;

internal class XproxyProxy : GClass3
{
	public int E807DD1D;

	private string DB274835;

	public string FF82632A;

	public string F601A63A = "";

	public bool bool_0 = true;

	public int int_0 = 0;

	public int int_1 = 0;

	public int int_2 = 3;

	public XproxyProxy(string A7A5F793, string string_0, int int_3, int int_4)
	{
		DB274835 = A7A5F793;
		FF82632A = string_0;
		int_2 = int_4;
		F601A63A = "";
		E807DD1D = int_3;
	}

	private void method_0(string string_0)
	{
	}

	public int resetXProxy()
	{
		bool flag = false;
		try
		{
			_ = Environment.TickCount;
			DB274835 = DB274835.TrimEnd('/');
			string text = DB274835 + "/reset?proxy=" + FF82632A.Split(':')[0] + ":" + FF82632A.Split(':')[1];
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string text2 = fB87CFA.RequestGet(text);
			if (text2.Contains("reset_too_much"))
			{
				Thread.Sleep(5000);
				return 2;
			}
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"].ToString() == "command_sent" || JObject.Parse(text2)["msg"].ToString() == "OK" || JObject.Parse(text2)["msg"].ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"].ToString().ToLower() == "0")
			{
				flag = true;
			}
			else
			{
				method_0(text + ": " + text2);
			}
		}
		catch (Exception)
		{
		}
		return flag ? 1 : 0;
	}

	public int method_2()
	{
		try
		{
			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				num = resetXProxy();
				if (num == 1)
				{
					Common.Sleep(3.0);
					num = (C002B100() ? 1 : 0);
				}
				if (num == 1)
				{
					break;
				}
			}
			return num;
		}
		catch
		{
		}
		return 0;
	}

	public bool C002B100(int int_3 = -1)
	{
		if (int_3 == -1)
		{
			int_3 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayResetXProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			DB274835 = DB274835.TrimEnd('/');
			string aDBFD1B = DB274835 + "/status?proxy=" + FF82632A.Split(':')[0] + ":" + FF82632A.Split(':')[1];
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string text = "";
			do
			{
				text = fB87CFA.RequestGet(aDBFD1B);
				try
				{
					if (!text.Contains("public_ip_v6") && !text.Contains("public_ip"))
					{
						if (flag = Convert.ToBoolean(JObject.Parse(text)["status"].ToString()))
						{
							flag = JObject.Parse(text)["msg"].ToString() == "MODEM_READY";
						}
					}
					else
					{
						string text2 = FF82632A.Split(':')[1];
						flag = ((!text2.StartsWith("4") && !text2.StartsWith("5")) ? ((!text2.StartsWith("6") && !text2.StartsWith("7")) ? Convert.ToBoolean(JObject.Parse(text)["status"].ToString()) : (JObject.Parse(text)["public_ip_v6"].ToString() != "" && JObject.Parse(text)["public_ip_v6"].ToString() != "CONNECT_INTERNET_ERROR")) : (JObject.Parse(text)["public_ip"].ToString() != "" && JObject.Parse(text)["public_ip"].ToString() != "CONNECT_INTERNET_ERROR"));
					}
				}
				catch
				{
					flag = JObject.Parse(text)["error_code"].ToString() == "0";
				}
				Thread.Sleep(1000);
			}
			while (!flag && Environment.TickCount - tickCount < int_3 * 1000);
		}
		catch (Exception)
		{
		}
		return flag;
	}

	public void method_3()
	{
		int_0--;
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 0 && int_0 == 0 && int_1 == int_2)
		{
			int_1 = 0;
		}
	}
}
