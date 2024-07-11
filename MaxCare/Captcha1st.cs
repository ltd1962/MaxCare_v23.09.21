using System;
using Newtonsoft.Json.Linq;

internal class Captcha1st
{
	public static string smethod_0(string BF12ABA1, string string_0)
	{
		try
		{
			string text = Common.Base64Decode("ewogICAgICJBcGlrZXkiOiAie2FwaUtleX0iLAogICAgICJUeXBlIjogImltYWdldG90ZXh0IiwKICAgICAiSW1hZ2UiOiAie2ltYWdlQmFzZTY0fSIsCiAgICAgIkN1c3RvbWl6ZSI6ICJGQUNFQk9PSyIKfQ==");
			text = text.Replace("{apiKey}", BF12ABA1);
			text = text.Replace("{imageBase64}", string_0);
			string text2 = "";
			string text3 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text2 = new RequestXNet("", "", "", 0).httpRequest.Post("https://api.1stcaptcha.com/Recognition", text, "application/json").ToString();
					text3 = JObject.Parse(text2)["TaskId"].ToString();
					if (text3 != "")
					{
						break;
					}
				}
				catch
				{
				}
				Common.Sleep(1.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text3 == "")
			{
				return "";
			}
			text = Common.Base64Decode("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text = text.Replace("{apiKey}", BF12ABA1);
			text = text.Replace("{job_id}", text3);
			do
			{
				text2 = new RequestXNet("", "", "", 0).RequestGet("https://api.1stcaptcha.com/getresult?apikey=" + BF12ABA1 + "&taskid=" + text3);
				string text4 = JObject.Parse(text2)["Status"].ToString();
				if (!(text4 == "ERROR"))
				{
					if (text4 == "SUCCESS")
					{
						break;
					}
					Common.Sleep(1.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text2.Contains("Data"))
			{
				return "";
			}
			return JObject.Parse(text2)["Data"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string DDAF47AA(string string_0, string string_1 = "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR", string string_2 = "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com")
	{
		try
		{
			string text = "https://api.1stcaptcha.com/recaptchav2?apikey={apiKey}&sitekey={websiteKey}&siteurl={websiteURL}&invisible=false&affiliateid=25206";
			text = text.Replace("{apiKey}", string_0);
			text = text.Replace("{websiteKey}", string_1);
			text = text.Replace("{websiteURL}", string_2);
			string text2 = "";
			string text3 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text2 = new RequestXNet("", "", "", 0).RequestGet(text);
					text3 = JObject.Parse(text2)["TaskId"].ToString();
					if (text3 != "")
					{
						break;
					}
				}
				catch
				{
				}
				Common.Sleep(1.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text3 == "")
			{
				return "";
			}
			text = "https://api.1stcaptcha.com/getresult?apikey={apiKey}&taskid={job_id}";
			text = text.Replace("{apiKey}", string_0);
			text = text.Replace("{job_id}", text3);
			do
			{
				text2 = new RequestXNet("", "", "", 0).RequestGet(text);
				string text4 = JObject.Parse(text2)["Status"].ToString();
				if (!(text4 == "ERROR"))
				{
					if (text4 == "SUCCESS")
					{
						break;
					}
					Common.Sleep(3.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text2.Contains("Data"))
			{
				return "";
			}
			return JObject.Parse(text2)["Data"]["Token"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}
}
