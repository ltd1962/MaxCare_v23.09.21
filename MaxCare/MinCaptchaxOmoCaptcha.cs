using System;
using System.Threading;
using Newtonsoft.Json.Linq;
using xNet;

public class MinCaptchaxOmoCaptcha
{
	public static string smethod_0(string string_0, string AC92D985, int E681CAAC = 0)
	{
		string text = "https://omocaptcha.com";
		if (E681CAAC == 1)
		{
			text = "https://mincaptcha.com";
		}
		try
		{
			string text2 = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiZGF0YSI6IHsKCQkidHlwZV9qb2JfaWQiOiAiMzAiLAoJCSJpbWFnZV9iYXNlNjQiOiAie2ltYWdlQmFzZTY0fSIKCX0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{imageBase64}", AC92D985);
			string json = new EF086887("", "", "", 0).method_1(text + "/api/createJob", text2, "application/json").ToString();
			string newValue = JObject.Parse(json)["job_id"].ToString();
			text2 = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{job_id}", newValue);
			int tickCount = Environment.TickCount;
			do
			{
				json = new EF086887("", "", "", 0).method_1(text + "/api/getJobResult", text2, "application/json");
				string text3 = JObject.Parse(json)["status"].ToString();
				if (!(text3 == "fail") && !(text3 == "timeout"))
				{
					if (text3 == "success")
					{
						break;
					}
					Common.Sleep(1.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!json.Contains("result"))
			{
				return "";
			}
			return JObject.Parse(json)["result"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_1(string BC1587A4, string string_0, int int_0 = 0, fMain c120353C_0 = null, int F79FAD20 = 0, string string_1 = "")
	{
		string text = "https://omocaptcha.com";
		if (int_0 == 1)
		{
			text = "https://mincaptcha.com";
		}
		try
		{
			string text2 = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiZGF0YSI6IHsKCQkidHlwZV9qb2JfaWQiOiAiNDEiLAoJCSJpbnB1dCI6ICJ7aW5wdXR9IgoJfQp9");
			text2 = text2.Replace("{apiKey}", BC1587A4);
			text2 = text2.Replace("{input}", string_0);
			string text3 = "";
			string text4 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text3 = new RequestXNet("", "", "", 0).RequestPost(text + "/api/createJob", text2, "application/json");
					text4 = JObject.Parse(text3)["job_id"].ToString();
					if (text4 != "")
					{
						break;
					}
				}
				catch
				{
				}
				Common.Sleep(3.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text4 == "")
			{
				return "";
			}
			text2 = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text2 = text2.Replace("{apiKey}", BC1587A4);
			text2 = text2.Replace("{job_id}", text4);
			do
			{
				text3 = new RequestXNet("", "", "", 0).RequestPost(text + "/api/getJobResult", text2, "application/json");
				string text5 = JObject.Parse(text3)["status"].ToString();
				if (!(text5 == "fail") && !(text5 == "timeout"))
				{
					if (text5 == "success")
					{
						break;
					}
					Common.Sleep(3.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text3.Contains("result"))
			{
				return "";
			}
			return JObject.Parse(text3)["result"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_2(string string_0, string B190560B = "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR", string string_1 = "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", int A189D295 = 0, fMain c120353C_0 = null, int C710C4A3 = 0, string string_2 = "")
	{
		string text = "https://omocaptcha.com";
		if (A189D295 == 1)
		{
			text = "https://mincaptcha.com";
		}
		try
		{
			string text2 = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiZGF0YSI6IHsKCQkidHlwZV9qb2JfaWQiOiAiMiIsCgkJIndlYnNpdGVfdXJsIjogInt3ZWJzaXRlVVJMfSIsCgkJIndlYnNpdGVfa2V5IjogInt3ZWJzaXRlS2V5fSIKCX0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{websiteKey}", B190560B);
			text2 = text2.Replace("{websiteURL}", string_1);
			string text3 = "";
			string text4 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text3 = new RequestXNet("", "", "", 0).RequestPost(text + "/api/createJob", text2, "application/json");
					text4 = JObject.Parse(text3)["job_id"].ToString();
					if (text4 != "")
					{
						break;
					}
				}
				catch
				{
				}
				Common.Sleep(3.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text4 == "")
			{
				return "";
			}
			text2 = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{job_id}", text4);
			do
			{
				text3 = new RequestXNet("", "", "", 0).RequestPost(text + "/api/getJobResult", text2, "application/json");
				string text5 = JObject.Parse(text3)["status"].ToString();
				if (!(text5 == "fail") && !(text5 == "timeout"))
				{
					if (text5 == "success")
					{
						break;
					}
					Common.Sleep(3.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text3.Contains("result"))
			{
				return "";
			}
			return JObject.Parse(text3)["result"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string E9880D36(string B2171E36, string string_0)
	{
		try
		{
			string text = SettingsTool.GetSettings("configGeneral").GetValue("host", "https://minsoftware.xyz/");
			text = text.TrimEnd('/');
			string text2 = "4";
			RequestParams requestParams = new RequestParams();
			requestParams["apiToken"] = B2171E36;
			requestParams["typeJob"] = text2.ToString();
			requestParams["imageBase64"] = string_0;
			string text3 = new RequestXNet("", "", "", 0).httpRequest.Post(text + "/bypasscaptcha/api.php/AddJob", requestParams).ToString();
			string text4 = JObject.Parse(text3)["id"].ToString();
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text3 = new RequestXNet("", "", "", 0).RequestPost(text + "/bypasscaptcha/api.php/GetResult", "apiToken=" + B2171E36 + "&id=" + text4);
					if (text3.Contains("ByPass_Fail"))
					{
						return "";
					}
					if (text3.Contains("result"))
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(2000);
			}
			while (Environment.TickCount - tickCount < 60000);
			if (!text3.Contains("result"))
			{
				return "";
			}
			return JObject.Parse(text3)["result"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_3(string C136B817, string E5950E0E = "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR", string string_0 = "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com")
	{
		try
		{
			string text = SettingsTool.GetSettings("configGeneral").GetValue("host", "https://minsoftware.xyz/");
			text = text.TrimEnd('/');
			string text2 = "6";
			RequestParams requestParams = new RequestParams();
			requestParams["apiToken"] = C136B817;
			requestParams["typeJob"] = text2.ToString();
			requestParams["imageBase64"] = "";
			string json = new RequestXNet("", "", "", 0).httpRequest.Post(text + "/bypasscaptcha/api.php/AddJob", requestParams).ToString();
			string text3 = JObject.Parse(json)["id"].ToString();
			int tickCount = Environment.TickCount;
			do
			{
				json = new RequestXNet("", "", "", 0).RequestPost(text + "/bypasscaptcha/api.php/GetResult", "apiToken=" + C136B817 + "&id=" + text3);
				if (!json.Contains("ByPass_Fail"))
				{
					if (json.Contains("result"))
					{
						break;
					}
					Common.Sleep(2.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 60000);
			if (!json.Contains("result"))
			{
				return "";
			}
			return JObject.Parse(json)["result"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}
}
