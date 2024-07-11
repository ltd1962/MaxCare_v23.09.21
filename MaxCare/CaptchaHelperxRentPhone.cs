using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Linq;
using xNet;

public class CaptchaHelperxRentPhone
{
	public static string smethod_0(int FB0B369F, string BD1AB094, fMain DE886B06, int int_0, string E3033A05)
	{
		string result = "";
		if (FB0B369F == 2)
		{
			result = DD8303B7(BD1AB094, "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR");
		}
		else if (FB0B369F == 0 || FB0B369F == 1)
		{
			result = TwoCaptcha.F23A910B(FB0B369F, BD1AB094, "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR", "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com");
		}
		else
		{
			switch (FB0B369F)
			{
			case 4:
				result = MinCaptchaxOmoCaptcha.smethod_2(BD1AB094, "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR", "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", 0, DE886B06, int_0, E3033A05);
				break;
			case 5:
				result = MinCaptchaxOmoCaptcha.smethod_3(BD1AB094);
				break;
			case 6:
				result = MinCaptchaxOmoCaptcha.smethod_2(BD1AB094, "6Lc9qjcUAAAAADTnJq5kJMjN9aD1lxpRLMnCS2TR", "https://fbsbx.com/captcha/recaptcha/iframe/?referer=https://m.facebook.com", 1);
				break;
			case 7:
				result = Captcha1st.DDAF47AA(BD1AB094);
				break;
			}
		}
		return result;
	}

	public static string BA30A117(int C0905E89, string B88276BB, string string_0)
	{
		string result = "";
		if (C0905E89 == 0 || C0905E89 == 1)
		{
			result = TwoCaptcha.smethod_0(C0905E89, B88276BB, string_0);
		}
		else
		{
			switch (C0905E89)
			{
			case 2:
				result = smethod_1(B88276BB, string_0);
				break;
			case 3:
				result = TwoCaptcha.smethod_1(B88276BB, string_0, 1);
				break;
			case 4:
				result = MinCaptchaxOmoCaptcha.smethod_0(B88276BB, string_0);
				break;
			case 5:
				result = MinCaptchaxOmoCaptcha.E9880D36(B88276BB, string_0);
				break;
			case 6:
				result = MinCaptchaxOmoCaptcha.smethod_0(B88276BB, string_0, 1);
				break;
			case 7:
				result = Captcha1st.smethod_0(B88276BB, string_0);
				break;
			}
		}
		return result;
	}

	public static string smethod_1(string AF99E79C, string B194B916)
	{
		string result = "";
		try
		{
			xNet.HttpRequest httpRequest = new xNet.HttpRequest();
			httpRequest.KeepAlive = true;
			httpRequest.Cookies = new CookieDictionary();
			httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
			httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string text = Common.Base64Decode("ew0KICAgICJjbGllbnRLZXkiOiAieHh4eHh4eHh4IiwNCiAgICAidGFzayI6IHsNCiAgICAgICAgInR5cGUiOiAiSW1hZ2VUb1RleHRUYXNrIiwNCiAgICAgICAgImJvZHkiOiAienp6enp6enp6eiIsDQogICAgICAgICJzdWJUeXBlIjogIkZBQ0VCT09LIg0KICAgIH0NCn0=");
			text = text.Replace("xxxxxxxxx", AF99E79C);
			text = text.Replace("zzzzzzzzzz", B194B916);
			string text2 = httpRequest.Post("https://api.anycaptcha.com/createTask", text, "application/json").ToString();
			if (!text2.Contains("\"errorId\":0"))
			{
				return result;
			}
			string value = Regex.Match(text2, "taskId\":(.*?)}").Groups[1].Value;
			string text3 = Common.Base64Decode("ewogICAgImNsaWVudEtleSI6Inl5eXl5eXl5eSIsCiAgICAidGFza0lkIjogeHh4Cn0=");
			text3 = text3.Replace("yyyyyyyyy", AF99E79C);
			text3 = text3.Replace("xxx", value);
			Thread.Sleep(1000);
			for (int i = 0; i < 62; i++)
			{
				text2 = httpRequest.Post("https://api.anycaptcha.com/getTaskResult", text3, "application/json").ToString();
				if (!text2.Contains("processing"))
				{
					break;
				}
				Common.Sleep(1.0);
				if (i > 60)
				{
					Console.WriteLine("Time out!!!");
					return result;
				}
			}
			string value2 = Regex.Match(text2, "text\":\"(.*?)\"").Groups[1].Value;
			result = value2;
		}
		catch
		{
		}
		return result;
	}

	public static string DD8303B7(string EBB0E506, string CAA80A87, string string_0)
	{
		string result = "";
		try
		{
			xNet.HttpRequest httpRequest = new xNet.HttpRequest();
			httpRequest.KeepAlive = true;
			httpRequest.Cookies = new CookieDictionary();
			httpRequest.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
			httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string text = Common.Base64Decode("ewogICAgImNsaWVudEtleSI6ICJ4eHh4eHh4eHgiLAogICAgInRhc2siOiB7CiAgICAgICAgInR5cGUiOiAiUmVjYXB0Y2hhVjJUYXNrUHJveHlsZXNzIiwKICAgICAgICAid2Vic2l0ZVVSTCI6ICJ6enp6enp6enp6IiwKICAgICAgICAid2Vic2l0ZUtleSI6ICJ5eXl5eXl5eXkiCiAgICB9Cn0=");
			text = text.Replace("xxxxxxxxx", EBB0E506);
			text = text.Replace("yyyyyyyyy", string_0);
			text = text.Replace("zzzzzzzzzz", CAA80A87);
			string text2 = httpRequest.Post("https://api.anycaptcha.com/createTask", text, "application/json").ToString();
			if (!text2.Contains("\"errorId\":0"))
			{
				return result;
			}
			string value = Regex.Match(text2, "taskId\":(.*?)}").Groups[1].Value;
			string text3 = Common.Base64Decode("ewogICAgImNsaWVudEtleSI6Inl5eXl5eXl5eSIsCiAgICAidGFza0lkIjogeHh4Cn0=");
			text3 = text3.Replace("yyyyyyyyy", EBB0E506);
			text3 = text3.Replace("xxx", value);
			Common.Sleep(1.0);
			for (int i = 0; i < 120; i++)
			{
				text2 = httpRequest.Post("https://api.anycaptcha.com/getTaskResult", text3, "application/json").ToString();
				if (!text2.Contains("processing"))
				{
					break;
				}
				Common.Sleep(1.0);
				if (i > 60)
				{
					Console.WriteLine("Time out!!!");
					return result;
				}
			}
			string value2 = Regex.Match(text2, "gRecaptchaResponse\":\"(.*?)\"").Groups[1].Value;
			result = value2;
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_2(int int_0, string string_0, int int_1, string string_1 = "", string B40EAA15 = "")
	{
		string result = "";
		switch (int_0)
		{
		case 1:
			result = smethod_39(string_0, int_1);
			break;
		case 2:
			result = GetPhoneGrizzly(string_0, int_1);
			break;
		case 3:
			result = B32A93B3(string_0, int_1);
			break;
		case 4:
			result = smethod_31(string_0, int_1);
			break;
		case 5:
			result = smethod_33(string_0, int_1);
			break;
		case 6:
			result = smethod_35(string_0, int_1);
			break;
		case 8:
			result = smethod_5(string_0, int_1);
			break;
		case 9:
			result = smethod_9(string_0, int_1);
			break;
		case 10:
			result = smethod_29(string_0, int_1, string_1);
			break;
		case 12:
			result = smethod_21(string_0, int_1);
			break;
		case 13:
			result = EC239B8D(string_0, int_1);
			break;
		case 14:
			result = CB383E95(string_0, int_1);
			break;
		case 15:
			result = smethod_20(string_0, int_1);
			break;
		case 16:
			result = smethod_4(string_0, int_1);
			break;
		case 17:
			result = smethod_3(string_0, int_1);
			break;
		case 18:
			result = B99429A2(string_0, int_1);
			break;
		case 19:
			result = D38EEB86(string_0, int_1);
			break;
		case 21:
			result = smethod_19(string_0, int_1);
			break;
		case 23:
			result = AA20BE80(string_0, int_1);
			break;
		case 25:
			result = C504E021(string_0, int_1);
			break;
		case 26:
			result = BC3E218C(string_0, int_1);
			break;
		case 27:
			result = smethod_6(string_0, int_1);
			break;
		case 28:
			result = smethod_17(string_0, int_1);
			break;
		case 29:
			result = FC1C38B6(string_0, int_1);
			break;
		case 30:
			result = C799029C(string_0, int_1);
			break;
		case 31:
			result = smethod_18(string_0, int_1);
			break;
		case 32:
			result = B526A50D(string_0, int_1);
			break;
		case 33:
			result = smethod_22(string_0, int_1);
			break;
		case 34:
			result = FBB6F49D(string_0, int_1);
			break;
		case 35:
			result = smethod_7(string_0, int_1);
			break;
		case 36:
			result = E0373F24(string_0, int_1);
			break;
		case 38:
			result = DAB48829(string_0, int_1);
			break;
		case 39:
			result = AA35D682(string_0, int_1);
			break;
		case 40:
			result = smethod_8(string_0, int_1);
			break;
		case 41:
			result = C799029C(string_0, int_1, 428);
			break;
		case 42:
			result = AEB3938B(string_0, int_1);
			break;
		}
		return result;
	}

	private static string smethod_3(string string_0, int int_0)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		List<string> list = new List<string>();
		do
		{
			for (int num = 4; num > 0; num--)
			{
				try
				{
					string string_ = $"https://2ndline.io/apiv1/order?apikey={string_0}&serviceId=275&networkId={num}&allowVoiceSms=false";
					text = d33C2C.RequestGet(string_);
					JObject jObject = JObject.Parse(text);
					text3 = jObject["id"].ToString();
					text2 = jObject["phone"].ToString();
					if (text3 != "" && text2 != "")
					{
						return text3 + "|" + text2;
					}
					if (text3 != "")
					{
						list.Add(text3);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		while (list.Count <= 0);
		do
		{
			for (int i = 0; i < list.Count; i++)
			{
				text3 = list[i];
				try
				{
					text = d33C2C.RequestGet("https://2ndline.io/apiv1/ordercheck?apikey=" + string_0 + "&id=" + text3);
					JObject jObject2 = JObject.Parse(text);
					text2 = jObject2["data"]["phone"].ToString();
					if (text3 != "" && text2 != "")
					{
						return text3 + "|" + text2;
					}
				}
				catch (Exception)
				{
				}
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text2;
	}

	private static string smethod_4(string string_0, int B41B710C)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("https://otp282.com/api/createRequestOTP/" + string_0 + "/service_id/1");
				JObject jObject = JObject.Parse(text);
				text3 = jObject["data"][0]["request_id"].ToString();
				text2 = jObject["data"][0]["phone"].ToString();
				if (text3 != "" && text2 != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < B41B710C * 1000);
		return text3 + "|" + text2;
	}

	private static string AA20BE80(string string_0, int int_0)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestPost("https://codeotp.site/api/getphone", "token=" + string_0 + "&appid=9");
				JObject jObject = JObject.Parse(text);
				text3 = jObject["msg"]["id"].ToString();
				text2 = jObject["msg"]["number"].ToString();
				if (text3 != "" && text2 != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text2;
	}

	private static string D38EEB86(string string_0, int FDBBC621)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("http://hcotp.com/api/v2/createrequest?token=" + string_0 + "&serviceId=1&carrier=all");
				JObject jObject = JObject.Parse(text);
				text3 = jObject["id"].ToString();
				text2 = jObject["phoneNum"].ToString();
				if (text3 != "" && text2 != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < FDBBC621 * 1000);
		return text3 + "|" + text2;
	}

	public static string smethod_5(string B42AA6AF, int C4308A16, int int_0 = 7)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://api.viotp.com/request/getv2?token=" + B42AA6AF + "&serviceId=" + int_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]["request_id"].ToString();
				if (text3 != "")
				{
					text = jObject["data"]["phone_number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C4308A16 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_6(string string_0, int C52D3930)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("http://otptele.com/json/request/getv2.php?token=" + string_0 + "&serviceId=63c1131b0e33b");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]["request_id"].ToString();
				if (text3 != "")
				{
					text = jObject["data"]["phone_number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C52D3930 * 1000);
		return text3 + "|" + text;
	}

	public static string FC1C38B6(string string_0, int BEB710BA)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://otpngon.com/public/api/getNumber?api_key=" + string_0 + "&service_id=1");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Data"][0]["Request_ID"].ToString();
				if (text3 != "")
				{
					text = jObject["Data"][0]["Phone"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < BEB710BA * 1000);
		return text3 + "|" + text;
	}

	public static string FBB6F49D(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://atmteamfb.com/public/api/getNumber?api_key=" + string_0 + "&service_id=1");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Data"][0]["Request_ID"].ToString();
				if (text3 != "")
				{
					text = jObject["Data"][0]["Phone"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_7(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://tskvb.com/pick_isdn?service=Facebook&apikey=" + string_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"].ToString();
				if (text3 != "")
				{
					text = jObject["isdn"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string E0373F24(string string_0, int AB218935)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://xotp.pro/api/v1/create-request?apikey=" + string_0 + "&service=facebook");/*&softid=minsoftware*/
                JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"].ToString();
				if (text3 != "")
				{
					text = jObject["phone"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < AB218935 * 1000);
		return text3 + "|" + text;
	}

	public static string AEB3938B(string DDA68905, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://api.thuesim.cloud/utils/request-number-for-tool?clientId=" + DDA68905 + "&appCode=Facebook");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["requestId"].ToString();
				if (text3 != "")
				{
					text = jObject["number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string AA35D682(string string_0, int C328B0A7)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("http://api.smartotp.net:3001/api/facebook/" + string_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"].ToString();
				if (text3 != "")
				{
					text = jObject["phoneNumber"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C328B0A7 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_8(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://access.thuesimgiare.com/api/sim-request?token=" + string_0 + "&service=19");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"].ToString();
				if (text3 != "")
				{
					text = jObject["phone"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string DAB48829(string string_0, int int_0)
	{
		string text = "";
		RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				fB87CFA.httpRequest.AddHeader("code", "maxcarecutevippro");
				text2 = fB87CFA.RequestGet("https://api.server-otponline.xyz/api/public/user/sim/buy/v2?apiKey=" + string_0 + "&appId=34");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["resultObj"]["value"]["id"].ToString();
				text = jObject["resultObj"]["value"]["number"].ToString();
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_9(string string_0, int AD943411, int int_0 = 1)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("http://otptextnow.com/api/?key=" + string_0 + "&action=get_number&id=" + int_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["request_id"].ToString();
				if (text3 != "")
				{
					text = jObject["number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < AD943411 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_10(string C0123D17, string string_0, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://api.viotp.com/session/getv2?requestId=" + string_0 + "&token=" + C0123D17);
				JObject jObject = JObject.Parse(json);
				if (jObject["status_code"].ToString() == "200")
				{
					try
					{
						text = Regex.Match(jObject["data"]["Code"].ToString(), "\\d+").Value;
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string smethod_11(string string_0, string A43D7819, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("http://otptele.com/json/session/getv2.php?requestId=" + A43D7819 + "&token=" + string_0);
				JObject jObject = JObject.Parse(json);
				text = jObject["data"]["Code"].ToString();
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string FAB16B38(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://otpngon.com/public/api/getOTP?api_key=" + string_0 + "&request_id=" + string_1);
				JObject jObject = JObject.Parse(json);
				text = jObject["Data"][0]["OTP"].ToString();
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_12(string string_0, string A89EE331, int B90A4D37 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= B90A4D37 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://atmteamfb.com/public/api/getOTP?api_key=" + string_0 + "&request_id=" + A89EE331);
				JObject jObject = JObject.Parse(json);
				text = jObject["Data"][0]["OTP"].ToString();
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_13(string B0AAC31B, string string_0, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://tskvb.com/get_otp?id_order=" + string_0 + "&apikey=" + B0AAC31B);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["data"][0]["content"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string BC949FB0(string string_0, string string_1, int CD0A63A8 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= CD0A63A8 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://xotp.pro/api/v1/get-request?apikey=" + string_0 + "&id=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["code"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_14(string BDAB5DA6, string string_0, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://api.thuesim.cloud/utils/get-code-for-tool?clientId=" + BDAB5DA6 + "&requestId=" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["content"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_15(string string_0, string C7BD56B3, int A11F428B = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= A11F428B * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("http://smartotp.net:3001/api/order/" + C7BD56B3 + "/" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["content"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string D5341684(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://access.thuesimgiare.com/api/get-message?token=" + string_0 + "&phone=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["message"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_16(string A8A45BB0, string string_0, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://api.server-otponline.xyz/api/public/user/sim/v2?orderId=" + string_0 + "&apiKey=" + A8A45BB0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["resultObj"]["code"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string A40A5401(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("http://otptextnow.com/api/?key=" + string_0 + "&action=get_code&id=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["otp_code"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string CB383E95(string string_0, int ECB1D904)
	{
		RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = fB87CFA.RequestGet("https://administrator.codetext247.com/api/sim-request?token=" + string_0 + "&service=19");
				JObject jObject = JObject.Parse(text);
				text2 = jObject["phone"].ToString();
				if (text2 != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < ECB1D904 * 1000);
		return text2;
	}

	public static string B99429A2(string string_0, int int_0)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("https://sosotps.com/get_sdt.php?apikey=" + string_0 + "&dichvu=10");
				if (text.Split('|')[0] == "OK")
				{
					text2 = text.Split('|')[1];
				}
				if (text2 != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text2;
	}

	public static string smethod_17(string string_0, int D42735B3)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("http://171.244.56.172:9152/pick_isdn?service=Facebook&apikey=" + string_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"].ToString();
				if (text3 != "")
				{
					text = jObject["isdn"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < D42735B3 * 1000);
		return text3 + "|" + text;
	}

	public static string EC239B8D(string FA1B2084, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://sim24.cc/api?action=number&service=facebook&apikey=" + FA1B2084);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]["id"].ToString();
				if (text3 != "")
				{
					text = jObject["Result"]["number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_18(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					text2 = d33C2C.RequestGet("https://sell282.xyz/api/sim/buy?api_key=" + string_0 + "&service=9");
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["data"]["code_order"].ToString();
					text = jObject["data"]["phone"].ToString();
				}
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string B526A50D(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					text2 = d33C2C.RequestGet("http://api.sellotpvn.com:8080/api/facebook/" + string_0);
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["id"].ToString();
					text = jObject["phoneNumber"].ToString();
				}
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string C504E021(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					text2 = d33C2C.RequestGet("https://numberotp.co/public/api/gsm/order/facebook/" + string_0);
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["id"].ToString();
					text = jObject["phoneNumber"].ToString();
				}
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_19(string CF2E111E, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					d33C2C.requestHTTP.SetDefaultHeaders(new string[1] { "Authorization: Basic " + CF2E111E });
					text2 = d33C2C.RequestGet("https://zimablue.click/zimablue/getmsisdn/Facebook");
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["request_id"].ToString();
					text = jObject["msisdn"].ToString();
				}
				if (text3 != "")
				{
					if (text != "")
					{
						break;
					}
					d33C2C.requestHTTP.SetDefaultHeaders(new string[1] { "Authorization: Basic " + CF2E111E });
					text2 = d33C2C.RequestGet("https://zimablue.click/zimablue/getcontent/" + text3);
					JObject jObject2 = JObject.Parse(text2);
					text = jObject2["msisdn"].ToString();
					if (text != "")
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string BC3E218C(string string_0, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				d33C2C.requestHTTP.SetDefaultHeaders(new string[1] { "Authorization: OTP " + string_0 });
				text2 = d33C2C.RequestPost("https://trumotpvn.com/api/v1/order", "service=9");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]["id"].ToString();
				text = jObject["data"]["phoneNumber"].ToString();
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_20(string EC13F11A, int int_0)
	{
		string text = "";
		RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		string text4 = Common.Base64Decode("ewkKCSJhcGlfa2V5Ijoie2FwaV9rZXl9IiwKCSJhcHBJZCI6InthcHBJZH0iCn0=");
		text4 = text4.Replace("{api_key}", EC13F11A);
		text4 = text4.Replace("{appId}", "9");
		do
		{
			try
			{
				text2 = fB87CFA.RequestPost("https://api.goodotp.xyz/api/dangkysim", text4, "application/json");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]["id"].ToString();
				if (text3 != "")
				{
					text = jObject["Result"]["number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_21(string string_0, int DF02CA90)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text2 == "")
				{
					text = d33C2C.RequestGet("https://api.winmail.shop/phone/rent?clientId=" + string_0 + "&serviceId=facebook");
					JObject jObject = JObject.Parse(text);
					text3 = jObject["email"]["phone"].ToString();
					text2 = jObject["email"]["phoneId"].ToString();
				}
				if (text2 != "")
				{
					if (text3 != "")
					{
						break;
					}
					text = d33C2C.RequestGet("https://api.winmail.shop/phone/code?clientId=" + string_0 + "&phoneId=" + text2);
					JObject jObject2 = JObject.Parse(text);
					text3 = jObject2["result"]["phone"].ToString();
					if (text3 != "")
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < DF02CA90 * 1000);
		return text2 + "|" + text3;
	}

	public static string smethod_22(string string_0, int int_0)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text2 == "")
				{
					text = d33C2C.RequestGet("https://api.tempsms.co/create?api_key=" + string_0 + "&service_id=13");
					JObject jObject = JObject.Parse(text);
					text2 = jObject["request_id"].ToString();
				}
				if (text2 != "")
				{
					if (text3 != "")
					{
						break;
					}
					text = d33C2C.RequestGet("https://api.tempsms.co/detail?api_key=" + string_0 + "&request_id=" + text2);
					JObject jObject2 = JObject.Parse(text);
					text3 = jObject2["phone"].ToString();
					if (text3 != "")
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text2 + "|" + text3;
	}

	public static string smethod_23(string D5109595, string A305EB90, int EA302280 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("https://api.winmail.shop/phone/code?clientId=" + D5109595 + "&phoneId=" + A305EB90);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["result"]["code"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
		while (Environment.TickCount - tickCount <= EA302280 * 1000);
		return text;
	}

	public static string smethod_24(string EB161A9F, string C0266D86, int BA8B11AB = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("https://api.tempsms.co/detail?api_key=" + EB161A9F + "&request_id=" + C0266D86);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["otp"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
		while (Environment.TickCount - tickCount <= BA8B11AB * 1000);
		return text;
	}

	public static string smethod_25(string string_0, string A1B8AE06, int F69432AF = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("https://sim24.cc/api?action=code&id=" + A1B8AE06 + "&apikey=" + string_0);
				JObject jObject = JObject.Parse(json);
				if (!(jObject["ResponseCode"].ToString() == "2"))
				{
					text = Regex.Match(jObject["Result"]["SMS"].ToString(), "\\d+").Value;
					if (!(text != ""))
					{
						goto IL_00a1;
					}
				}
			}
			catch
			{
				goto IL_00a1;
			}
			break;
			IL_00a1:
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= F69432AF * 1000);
		return text;
	}

	public static string smethod_26(string BD2F1F3A, string string_0, int A70E3E37 = 120)
	{
		string text = "";
		new RequestXNet("", "", "", 0);
		int tickCount = Environment.TickCount;
		string text2 = Common.Base64Decode("ewkKCSJhcGlfa2V5Ijoie2FwaV9rZXl9IiwKCSJpZCI6IntpZH0iCn0=");
		text2 = text2.Replace("{api_key}", BD2F1F3A);
		text2 = text2.Replace("{id}", string_0);
		do
		{
			try
			{
				string json = new RequestXNet("", "", "", 0).RequestPost("https://api.goodotp.xyz/api/layotpByID", text2, "application/json");
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["Result"][0]["message"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= A70E3E37 * 1000);
		return text;
	}

	public static string E0164B97(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = fB87CFA.RequestGet("https://administrator.codetext247.com/api/get-message?token=" + string_0 + "&phone=" + string_1);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["message"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string C4BE3284(string D8873F9C, string E4BE4D93, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestPost("https://codeotp.site/api/getotp", "token=" + D8873F9C + "&id=" + E4BE4D93);
				JObject jObject = JObject.Parse(json);
				text = jObject["msg"]["otp"].ToString();
				if (text == "")
				{
					text = Regex.Match(jObject["msg"]["msg"].ToString(), "\\d+").Value;
				}
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string smethod_27(string C41A028F, string string_0, int BB806EAF = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string text2 = d33C2C.RequestGet("https://sosotps.com/get_code.php?apikey=" + C41A028F + "&dichvu=10&sdt=" + string_0);
				text2 = text2.Replace("NO|||", "");
				if (text2.Split('|')[0] == "OK")
				{
					text = text2.Split('|')[2];
				}
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= BB806EAF * 1000);
		return text;
	}

	public static string smethod_28(string string_0, string CE0D339B, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("http://171.244.56.172:9152/get_otp?id_order=" + CE0D339B + "&apikey=" + string_0);
				text = Regex.Match(JObject.Parse(json)["data"][0]["content"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string smethod_29(string string_0, int A6A8D1A9, string string_1)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestPost("https://tempcode.co/api/orders.php", "api_key=" + string_0 + "&act=buy_number&service_id=" + string_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]["order_id"].ToString();
				if (text3 != "")
				{
					text = (jObject["data"]["phonenumber"].ToString().Contains("+") ? jObject["data"]["phonenumber"].ToString().Remove(0, 2) : jObject["data"]["phonenumber"].ToString().Remove(0, 1));
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < A6A8D1A9 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_30(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestPost("https://tempcode.co/api/orders.php", "api_key=" + string_0 + "&act=read_message&order_id=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["data"]["otp"].ToString(), "\\d+").Value;
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string C799029C(string string_0, int C22640AA, int C598CA28 = 7)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://ironsim.com/api/phone/new-session?token=" + string_0 + "&service=" + C598CA28);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]["session"].ToString();
				if (text3 != "")
				{
					text = jObject["data"]["phone_number"].ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < C22640AA * 1000);
		return text3 + "|" + text;
	}

	public static string D12B3AA1(string string_0, string string_1, int int_0 = 90)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("https://ironsim.com/api/session/" + string_1 + "/get-otp?token=" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = jObject["data"]["messages"][0]["otp"].ToString();
					if (text != "")
					{
						break;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string B32A93B3(string FA36B9B4, int E8BD0891)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("https://otpmmo.xyz/textnow/api.php?apikey=" + FA36B9B4 + "&type=getphone&qty=1");
				if (text != "")
				{
					return text;
				}
				Thread.Sleep(3000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < E8BD0891 * 1000);
		return "";
	}

	public static string AD933A34(string string_0, string string_1, int int_0 = 60)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			try
			{
				text = d33C2C.RequestGet("https://otpmmo.xyz/textnow/api.php?apikey=" + string_0 + "&type=getotp&sdt=" + string_1);
				if (text != "")
				{
					text = text.Remove(0, 1);
					text = text.Remove(text.Length - 1, 1);
					JObject jObject = JObject.Parse(text);
					text2 = jObject["otp"].ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_31(string C13F2930, int int_0)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("http://primeotp.me/api.php?apikey=" + C13F2930 + "&action=create-request&serviceId=1&count=1");
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["results"]["data"][0]["requestId"].ToString() + "|" + jObject["results"]["data"][0]["sdt"].ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public static string smethod_32(string string_0, string string_1, int int_0 = 60)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			try
			{
				text = d33C2C.RequestGet("http://primeotp.me/api.php?apikey=" + string_0 + "&action=data-request&requestId=" + string_1);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["data"][0]["otp"].ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_33(string C88CE022, int ADB3F6B8, string FC8EDF97 = "servertextnow.xyz")
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("http://" + FC8EDF97 + "/api/get-phone/?access_token=" + C88CE022);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["phone"].ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < ADB3F6B8 * 1000);
		return "";
	}

	public static string smethod_34(string string_0, string BF212188, string string_1 = "servertextnow.xyz", int int_0 = 60)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("http://" + string_1 + "/api/get-otp/?access_token=" + string_0 + "&phone=" + BF212188);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["otp"].ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public static string smethod_35(string string_0, int int_0)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = d33C2C.RequestGet("http://otpfb.com/api.php?apikey=" + string_0 + "&action=create-request&serviceId=1&count=1");
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["results"]["data"][0]["requestId"].ToString() + "|" + jObject["results"]["data"][0]["sdt"].ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public static string AD3F739F(string BFBCA1AF, string string_0, int B0009A34 = 60)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		string text2 = "";
		for (int i = 0; i < B0009A34; i++)
		{
			try
			{
				text = d33C2C.RequestGet("http://otpfb.com/api.php?apikey=" + BFBCA1AF + "&action=data-request&requestId=" + string_0);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["data"][0]["otp"].ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_36(string string_0, string EB8E0191, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("http://otpsim.com/api/sessions/" + EB8E0191 + "?token=" + string_0);
				JObject jObject = JObject.Parse(json);
				if (Convert.ToBoolean(jObject["success"].ToString()))
				{
					try
					{
						text = JObject.Parse(json)["data"]["messages"][0]["otp"].ToString();
						if (text != "")
						{
							break;
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string GetPhoneGrizzly(string C4934A93, int AB97C59E, int FF879510 = 1001)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://api.grizzlysms.com/stubs/handler_api.php?api_key=" + C4934A93 + "&action=getNumber&service=fb");

                JObject jObject = JObject.Parse(text2);
				if (!(text2.Contains("NO_BALANCE")))
				{
					string[] arrayx = text2.Split(':');
					text3 = arrayx[1];
					if (text3 != "")
					{
						text = arrayx[2];
						break;
					}
				}
                //text3 = jObject["Result"]["Id"].ToString();
                //if (text3 != "")
                //{
                //	text = jObject["Result"]["Number"].ToString();
                //	break;
                //}
            }
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < AB97C59E * 1000);
		return text3 + "|" + text;
	}

	public static string GetCodeGrizzly(string string_0, string A73B6C20, int int_0 = 120)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = d33C2C.RequestGet("https://api.grizzlysms.com/stubs/handler_api.php?api_key=" + string_0 + "&action=getStatus&id=" + A73B6C20);
				JObject jObject = JObject.Parse(json);
				if (json.Contains("STATUS_OK"))
				{
					string[] arrayx = json.Split(':');
                    try
                    {
						text = arrayx[1];
                        if (text != "")
                        {
                            break;
                        }
                    }
                    catch
                    {
                    }
                }
				//if (jObject["ResponseCode"].ToString() == "0")
				//{
				//	try
				//	{
				//		text = jObject["Result"]["Code"].ToString();
				//		if (text != "")
				//		{
				//			break;
				//		}
				//	}
				//	catch
				//	{
				//	}
				//}
				Thread.Sleep(3000);
				continue;
			}
			catch
			{
				continue;
			}
		}
		return text;
	}

	public static string smethod_39(string string_0, int int_0, int int_1 = 7)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			text2 = d33C2C.RequestGet("http://otpsim.com/api/phones/request?token=" + string_0 + "&service=" + int_1);
			try
			{
				JObject jObject = JObject.Parse(text2);
				if (!Convert.ToBoolean(jObject["success"].ToString()))
				{
					goto IL_00cc;
				}
				text = JObject.Parse(text2)["data"]["phone_number"].ToString();
				text3 = JObject.Parse(text2)["data"]["session"].ToString();
				if (!(text != "") || !(text3 != ""))
				{
					goto IL_00cc;
				}
				goto end_IL_004d;
				IL_00cc:
				Thread.Sleep(5000);
				continue;
				end_IL_004d:;
			}
			catch
			{
				continue;
			}
			break;
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string GetPhoneFromSite(int int_0, string string_0, string string_1, string string_2, int int_1)
	{
		string result = "";
		switch (int_0)
		{
		case 1:
			result = smethod_36(string_0, string_1, int_1);
			break;
		case 2:
			result = GetCodeGrizzly(string_0, string_1, int_1);
			break;
		case 3:
			result = AD933A34(string_0, string_2, int_1);
			break;
		case 4:
			result = smethod_32(string_0, string_1, int_1);
			break;
		case 5:
			result = smethod_34(string_0, string_2, "servertextnow.xyz", int_1);
			break;
		case 6:
			result = AD3F739F(string_0, string_1, int_1);
			break;
		case 8:
			result = smethod_10(string_0, string_1, int_1);
			break;
		case 9:
			result = A40A5401(string_0, string_1, int_1);
			break;
		case 10:
			result = smethod_30(string_0, string_1, int_1);
			break;
		case 12:
			result = smethod_23(string_0, string_1, int_1);
			break;
		case 13:
			result = smethod_25(string_0, string_1, int_1);
			break;
		case 14:
			result = E0164B97(string_0, string_2, int_1);
			break;
		case 15:
			result = smethod_26(string_0, string_1, int_1);
			break;
		case 16:
			result = smethod_41(string_0, string_1, int_1);
			break;
		case 17:
			result = smethod_40(string_0, string_1, int_1);
			break;
		case 18:
			result = smethod_27(string_0, string_2, int_1);
			break;
		case 19:
			result = B2813637(string_0, string_1, int_1);
			break;
		case 21:
			result = DD86BA1A(string_0, string_1, int_1);
			break;
		case 23:
			result = C4BE3284(string_0, string_1, int_1);
			break;
		case 25:
			result = smethod_47(string_0, string_1, int_1);
			break;
		case 26:
			result = AEBCF1A3(string_0, string_1, int_1);
			break;
		case 27:
			result = smethod_11(string_0, string_1, int_1);
			break;
		case 28:
			result = smethod_28(string_0, string_1, int_1);
			break;
		case 29:
			result = FAB16B38(string_0, string_1, int_1);
			break;
		case 31:
			result = smethod_45(string_0, string_1, int_1);
			break;
		case 32:
			result = smethod_46(string_0, string_1, int_1);
			break;
		case 33:
			result = smethod_24(string_0, string_1, int_1);
			break;
		case 34:
			result = smethod_12(string_0, string_1, int_1);
			break;
		case 35:
			result = smethod_13(string_0, string_1, int_1);
			break;
		case 36:
			result = BC949FB0(string_0, string_1, int_1);
			break;
		case 38:
			result = smethod_16(string_0, string_1, int_1);
			break;
		case 39:
			result = smethod_15(string_0, string_1, int_1);
			break;
		case 40:
			result = D5341684(string_0, string_2, int_1);
			break;
		case 30:
		case 41:
			result = D12B3AA1(string_0, string_1, int_1);
			break;
		case 42:
			result = smethod_14(string_0, string_1, int_1);
			break;
		}
		return result;
	}

	private static string smethod_40(string string_0, string AF883B80, int E0A9B9AA)
	{
		RequestHttp d33C2C = new RequestHttp();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("https://2ndline.io/apiv1/ordercheck?apikey=" + string_0 + "&id=" + AF883B80);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["data"]["message"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < E0A9B9AA * 1000);
		return text;
	}

	private static string smethod_41(string string_0, string string_1, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("https://otp282.com/api/getOTPCode/" + string_0 + "/request_id/" + string_1);
				JObject jObject = JObject.Parse(json);
				text = jObject["otpcode"].ToString();
				if (text == "")
				{
					text = Regex.Match(jObject["message"].ToString(), "\\d+").Value;
				}
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	private static string B2813637(string string_0, string string_1, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = d33C2C.RequestGet("http://hcotp.com/api/v2/getcode?token=" + string_0 + "&requestId=" + string_1);
				JObject jObject = JObject.Parse(json);
				text = jObject["code"].ToString();
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	internal static void smethod_42(int int_0, string string_0, string string_1, string string_2)
	{
		switch (int_0)
		{
		case 15:
			D105A399(string_0, string_1);
			break;
		case 12:
			D228B4BD(string_0, string_2);
			break;
		case 36:
			smethod_43(string_0, string_2);
			break;
		case 33:
			smethod_44(string_0, string_2);
			break;
		case 30:
			F0853792(string_0, string_2);
			break;
		}
	}

	public static bool smethod_43(string AB25AD09, string string_0, int DDA1C22D = 120)
	{
		RequestHttp d33C2C = new RequestHttp();
		try
		{
			string text = d33C2C.RequestGet("https://xotp.pro/api/v1/cancel-request?apikey=" + AB25AD09 + "&id=" + string_0);
			return text.Trim() == "{}";
		}
		catch
		{
		}
		return false;
	}

	public static bool D228B4BD(string BA294B39, string string_0, int D2BD969B = 120)
	{
		RequestHttp d33C2C = new RequestHttp();
		try
		{
			string json = d33C2C.RequestGet("https://api.winmail.shop/phone/cancel?clientId=" + BA294B39 + "&phoneId=" + string_0);
			JObject jObject = JObject.Parse(json);
			return jObject["status"].ToString() == "canceled";
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_44(string string_0, string string_1, int CB08FC8C = 120)
	{
		RequestHttp d33C2C = new RequestHttp();
		try
		{
			string json = d33C2C.RequestGet("https://api.tempsms.co/cancel?api_key=" + string_0 + "&request_id=" + string_1);
			JObject jObject = JObject.Parse(json);
			return jObject["status_code"].ToString() == "0";
		}
		catch
		{
		}
		return false;
	}

	public static string D105A399(string string_0, string E32A6617)
	{
		string result = "";
		new RequestXNet("", "", "", 0);
		string text = Common.Base64Decode("ewkKCSJhcGlfa2V5Ijoie2FwaV9rZXl9IiwKCSJhcHBfaWQiOiJ7YXBwX2lkfSIsCiAgICAgICAgIm51bWJlciI6IntudW1iZXJ9Igp9");
		text = text.Replace("{api_key}", string_0);
		text = text.Replace("{app_id}", "9");
		text = text.Replace("{number}", E32A6617);
		try
		{
			string json = new RequestXNet("", "", "", 0).RequestPost("https://api.goodotp.xyz/api/huydangky", text, "application/json");
			JObject.Parse(json);
		}
		catch
		{
		}
		return result;
	}

	public static string F0853792(string string_0, string DD9B5792)
	{
		string result = "";
		RequestHttp d33C2C = new RequestHttp();
		try
		{
			string json = d33C2C.RequestGet("https://ironsim.com/api/session/cancel?token=" + string_0 + "&session=" + DD9B5792);
			JObject jObject = JObject.Parse(json);
			result = jObject["success"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_45(string string_0, string string_1, int F882EBB6)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://sell282.xyz/api/sim/code?api_key=" + string_0 + "&code_order=" + string_1);
				JObject jObject = JObject.Parse(text2);
				text = Regex.Match(jObject["data"]["code"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < F882EBB6 * 1000);
		return text;
	}

	public static string smethod_46(string string_0, string E4260A31, int AB200C2C)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("http://api.sellotpvn.com:8080/api/order/" + E4260A31 + "/" + string_0);
				JObject jObject = JObject.Parse(text2);
				text = Regex.Match(jObject["content"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < AB200C2C * 1000);
		return text;
	}

	public static string smethod_47(string FD3CE117, string string_0, int BEAFD593)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = d33C2C.RequestGet("https://numberotp.co/public/api/gsm/get-order/" + string_0 + "/" + FD3CE117);
				JObject jObject = JObject.Parse(text2);
				text = Regex.Match(jObject["content"].ToString(), "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < BEAFD593 * 1000);
		return text;
	}

	public static string DD86BA1A(string string_0, string string_1, int int_0)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				d33C2C.requestHTTP.SetDefaultHeaders(new string[1] { "Authorization: Basic " + string_0 });
				text2 = d33C2C.RequestGet("https://zimablue.click/zimablue/getcontent/" + string_1);
				JObject jObject = JObject.Parse(text2);
				text = jObject["otp"].ToString();
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text;
	}

	public static string AEBCF1A3(string string_0, string string_1, int C58B2333)
	{
		string text = "";
		RequestHttp d33C2C = new RequestHttp();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				d33C2C.requestHTTP.SetDefaultHeaders(new string[1] { "Authorization: OTP " + string_0 });
				text2 = d33C2C.RequestGet("https://trumotpvn.com/api/v1/order/" + string_1);
				JObject jObject = JObject.Parse(text2);
				text = jObject["data"]["content"].ToString();
				text = Regex.Match(text, "\\d+").Value;
				if (text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C58B2333 * 1000);
		return text;
	}
}
