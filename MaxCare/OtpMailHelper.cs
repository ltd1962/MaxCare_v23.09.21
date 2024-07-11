using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Linq;
using MinsoftLib;
using System.Collections.Generic;

internal class OtpMailHelper
{
	internal static string GetOtpFromDomain(int int_0, string string_0, string C038B5B3, string B5A63A0A = "", int int_1 = 60)
	{
		RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
		string_0 = string_0.Substring(0, string_0.LastIndexOf("=") + 1) + C038B5B3;
		int tickCount = Environment.TickCount;
		do
		{
			string text = fB87CFA.RequestGet(string_0);
			try
			{
				text = "{\"data\":" + text + "}";
				JObject jObject = JObject.Parse(text);
				int num = jObject["data"].Count() - 1;
				while (num >= 0)
				{
					jObject["data"][num]["created_at"].ToString();
					string fF9E5DBC = jObject["data"][num]["body"].ToString();
					string text2 = GetOtpMail(fF9E5DBC, int_0, B5A63A0A);
					if (!(text2 != ""))
					{
						num--;
						continue;
					}
					return text2;
				}
			}
			catch
			{
			}
			Common.Sleep(3.0);
		}
		while (Environment.TickCount - tickCount < int_1 * 1000);
		return "";
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtp(byte[] byte_0, byte[] byte_1, byte[] byte_2);

    public static string GetOtpMail(string string_0, int int_0, string string_1 = "", string string_2 = "")
    {
        string text = "";
        switch (int_0)
        {
            case 0:
                text = Regex.Match(string_0, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
                if (text == "")
                {
                    text = Regex.Match(string_0, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
                }
                if (text == "")
                {
                    text = Regex.Match(string_0, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\n").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
                }
                break;
            case 1:
                text = Regex.Match(string_0, ">(\\d{8})<").Groups[1].Value.Trim();
                if (text == "")
                {
                    text = Regex.Match(string_0, "\\d{8}").Value.Trim();
                }
                if (string_1.StartsWith(text))
                {
                    text = "";
                }
                break;
            case 2:
                {
                    string value = Regex.Match(string_0, "\\?n=(.*?)&").Groups[1].Value;
                    if (value == "")
                    {
                        value = Regex.Match(string_0, "reset code:(\\d+)").Groups[1].Value;
                    }
                    if (value == "")
                    {
                        value = Regex.Match(string_0, ":(\\d+)N").Groups[1].Value;
                    }
                    string text2 = Regex.Match(string_0, ";id=(.*?)&").Groups[1].Value;
                    if (text2 == "")
                    {
                        text2 = string_1;
                    }
                    if (value != "" && text2 != "")
                    {
                        text = "https://m.facebook.com/recover/password/?u=" + text2 + "&n=" + value + "&fl=default_recover&sih=0&msgr=0";
                    }
                    break;
                }
            case 3:
                text = Regex.Match(string_0, ">\\d+<").Value.Trim().Replace(">", "").Replace("<", "");
                if (text == "")
                {
                    text = Regex.Match(string_0, "Security code: \\d+").Value;
                    text = Regex.Match(text, "\\d+").Value;
                }
                break;
            case 4:
                text = Regex.Match(string_0, "c=(\\d+)&").Groups[1].Value;
                break;
            case 5:
                text = Regex.Match(string_0, "code=(\\d+)&").Groups[1].Value;
                break;
        }
        return text;
    }


    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckDonglaomail(byte[] byte_0);

	public static bool GetOtpDongLaoMail(string F83D3D1E)
	{
		string value = Common.smethod_6(CheckDonglaomail(Common.B2B3DBBA(F83D3D1E)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpByDonglaomail(byte[] byte_0, byte[] D20BE301, byte[] byte_1, byte[] AB33FF30, byte[] A58081B0, byte[] byte_2);

	public static string GetOtpByDonglaomail(int int_0, string E09B7696, string string_0, int int_1 = 60, string string_1 = "", string string_2 = "")
	{
		string_0 = SettingsTool.GetSettings("configGeneral").GetValue("txtTokenDonglaomail");
		return Common.smethod_6(GetOtpByDonglaomail(Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(E09B7696), Common.B2B3DBBA(string_0), Common.B2B3DBBA(int_1.ToString()), Common.B2B3DBBA(string_1), Common.B2B3DBBA(string_2)));
	}

    //[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    //private static extern IntPtr GetOtpOtpgmail(byte[] byte_0, byte[] C2A57782, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4);

    public static string GetOTPGmail(int int_0, string string_0, string string_1, int C9B1A03A, string string_2, string string_3)
    {
        if (string_1 == "")
        {
            return "fail";
        }
        try
        {
            RequestHttp f72618A = new RequestHttp();
            int tickCount = Environment.TickCount;
            while (true)
            {
                string text = f72618A.RequestGet("http://otpgmail.com/api_mail/api.php/GetMessage?mail=" + string_0 + "&password=" + string_1);
                if (text != "")
                {
                    if (text.Contains("Mail or password is incorrect."))
                    {
                        return "fail";
                    }
                    try
                    {
                        text = "{\"data\":" + text + "}";
                        JObject jObject = JObject.Parse(text);
                        int num = jObject["data"].Count() - 1;
                        while (num >= 0)
                        {
                            jObject["data"][num]["created_at"].ToString();
                            string string_4 = jObject["data"][num]["body"].ToString();
                            string text2 = GetOtpMail(string_4, int_0, string_2, string_3);
                            if (!(text2 != ""))
                            {
                                num--;
                                continue;
                            }
                            return text2;
                        }
                    }
                    catch
                    {
                    }
                }
                if (Environment.TickCount - tickCount <= C9B1A03A * 1000)
                {
                    Common.Sleep(3.0);
                    continue;
                }
                break;
            }
        }
        catch (Exception)
        {
        }
        return "";
    }

    public static string GetOtpGenerator(int E83F4F25, string mail, int timeOut, string string_0, string string_1)
	{
		return GetOTPGenerator_Old(E83F4F25, mail, timeOut, string_0, string_1);
	}
    public static string GetOTPGenerator_Old(int E83F4F25, string mail, int timeOut, string string_0, string string_1)
    {
        RequestHttp requestHttp = new RequestHttp();
        string text = "";
        _ = "/" + mail.Split('@')[1] + "/" + mail.Split('@')[0] + "/(.*?)\"";
        int tickCount = Environment.TickCount;
        while (Environment.TickCount - tickCount <= timeOut * 1000)
        {
            string input = requestHttp.RequestGet("https://generator.email/" + mail);
            text = Regex.Match(input, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\"").Value.TrimEnd('"');
            text = Regex.Match(text, "c=(.*?)&").Groups[1].Value;
            if (text != "")
            {
                break;
            }
        }
        return text;
        //return Common.smethod_6(GetOtpGenerator(Common.B2B3DBBA(E83F4F25.ToString()), Common.B2B3DBBA(mail), Common.B2B3DBBA(timeOut.ToString()), Common.B2B3DBBA(string_0), Common.B2B3DBBA(string_1)));
    }
    public static string smethod_4(string string_0)
	{
		string text = Common.ConvertToUnSign((from string_0z in SetupFolder.GetListHoVN()
			orderby Guid.NewGuid()
			select string_0z).First() + (from EDB22114 in SetupFolder.GetListTenVN()
			orderby Guid.NewGuid()
			select EDB22114).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6);
		return text + "@" + string_0;
	}

	public static string GetOTPMailHelp(int C48A7D1C, string D5977E9B, string EEB59886, int int_0, string string_0, string string_1)
	{
		string text = "";
		if (Common.smethod_68(D5977E9B, SettingsTool.GetSettings("configGeneral").GetValueList("txtGeneratorDomain")) != "")
		{
			text = GetOtpGenerator(C48A7D1C, D5977E9B, int_0, string_0, text);
		}
		else if (GetOtpDongLaoMail(D5977E9B))
		{
			text = GetOtpByDonglaomail(C48A7D1C, D5977E9B, "", int_0, string_0, string_1);
		}
		else if (D5977E9B.Contains("@otpgmail.com"))
		{
			text = GetOTPGmail(C48A7D1C, D5977E9B, EEB59886, int_0, string_0, string_1);
		}
		else if (text == "")
		{
			text = Imap.ConnectToImap(C48A7D1C, D5977E9B, EEB59886, int_0, string_0, string_1);
		}
		if (text == "")
		{
			text = string_1;
		}
		return text;
	}
    public static string GetOtpByDongVanFb(string email, string passMail, int type = 0)
    {
        try
        {
            string text = "";
            RequestHttp requestHttp = new RequestHttp();
            for (int i = 0; i < 10; i++)
            {
                string text2 = requestHttp.RequestGet("https://tools.dongvanfb.com/api/get_messages?mail=" + email + "&pass=" + passMail);
                if (!(text2 != ""))
                {
                    continue;
                }
                foreach (JToken item in (IEnumerable<JToken>)JObject.Parse(text2)["messages"])
                {
                    if (!(item["from"].ToString() == "security@facebookmail.com"))
                    {
                        continue;
                    }
                    string input = item["message"].ToString();
                    switch (type)
                    {
                        case 0:
                            text = Regex.Match(input, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("\"", "");
                            break;
                        case 1:
                            text = Regex.Match(input, "\\d{8}").Value.Trim();
                            break;
                        case 2:
                            text = Regex.Match(input, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\"").Value.Trim().Replace("\"", "");
                            if (text == "")
                            {
                                text = Regex.Match(input, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("\"", "");
                            }
                            break;
                        case 3:
                            text = Regex.Match(input, "confirmcontact.php\\?c=(.*?)&").Groups[1].Value;
                            break;
                        case 4:
                            text = Regex.Match(input, "c=(.*?)&").Groups[1].Value;
                            break;
                        case 5:
                            text = Regex.Match(input, "code=(.*?)&").Groups[1].Value;
                            break;
                    }
                    if (text != "")
                    {
                        return text;
                    }
                }
            }
        }
        catch (Exception)
        {
        }
        return "";
    }
    private string GetOtpFromGetnada(string mailAdd, int number)
    {
        int num = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLimitTimeGetOtpGetnada", 120);
        string result = "";
        string text2 = "";
        try
        {
            RequestXNet requestXNet = new RequestXNet("", "", "", 0);
            for (int i = 0; i < 10; i++)
            {
                string json = requestXNet.RequestGet("https://getnada.com/api/v1/inboxes/" + mailAdd);
                JObject jObject = JObject.Parse(json);
                text2 = jObject["msgs"]![0]!["uid"]!.ToString();
                if (text2 != "")
                {
                    //json = requestXNet.RequestGet("https://getnada.com/api/v1/messages/html/" + cName);
                    //text = Regex.Match(json, ">(\\d{" + number + "})<").Groups[1].Value;
                    //if (text != "")
                    //{
                    //    try
                    //    {
                    //        requestXNet.httpRequest_0.Raw(HttpMethod.DELETE, "https://getnada.com/api/v1/messages/" + cName, null);
                    //        break;
                    //    }
                    //    catch
                    //    {
                    //    }
                    //    return text;
                    //}
                    json = requestXNet.RequestGet("https://getnada.com/api/v1/messages/html/" + text2).ToString();
                    result = Regex.Match(json, "font-size:14px; font-weight:bold; color:#2a2a2a;\">(.*?)</span>").Groups[1].ToString();
                    break;
                }
            }
            //while (Environment.TickCount - tickCount < num * 1000);
        }
        catch
        {
        }
        return result;
    }

    public static string CreateMoakt(RequestXNet request, string mailrecovery)
    {
        string text = "";
        try
        {
            string text2 = request.RequestGet("https://moakt.com/en");
            string json = "domain=moakt.cc&username=" + mailrecovery.Split('@')[0] + "&setemail=Create&preferred_domain=";
            text2 = request.RequestPost("https://moakt.com/en/inbox", json);
            if (text2.Contains("Your Email was created"))
            {
                return "OK";
            }
            return "Fail";
        }
        catch
        {
            return "Fail";
        }
    }
    public static string GetOtpFromMoakt(RequestXNet request, int count)
    {
        string result = "";
        try
        {
            string text = "";
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(1000);
                text = request.RequestGet("https://moakt.com/en/inbox");
                if (text.Contains("Microsoft account security code"))
                {
                    string text2 = Regex.Match(text, "id=\"email-control\"><a href=\"(.*?)/delete\"").Groups[1].ToString() + "/content";
                    text = request.RequestGet("https://moakt.com" + text2);
                    if (text.Contains("code"))
                    {
                        result = Regex.Match(text, "font-weight:bold; color:#2a2a2a;\">(.*?)</span>").Groups[1].ToString();
                        break;
                    }
                }
                else if (i == count - 1)
                {
                    result = "";
                }
            }
            string text3 = request.RequestGet("https://moakt.com/en/inbox/logout");
        }
        catch
        {
            result = "";
            string text4 = request.RequestGet("https://moakt.com/en/inbox/logout");
        }
        return result;
    }
    private static string inboxes()
    {
        string text = "";
        try
        {
            for (int i = 0; i < 10; i++)
            {
                string text2 = new RequestXNet("", "", "", 0).RequestPost("https://inboxes.com/api/v2/signup", "", "application/x-www-form-urlencoded");
                text = JObject.Parse(text2)["token"].ToString();
                if (!(text == ""))
                {
                    break;
                }
                Thread.Sleep(3000);
            }
        }
        catch (Exception)
        {
        }
        return text;
    }
    private static string inboxes_Fix(string string_2 = "")
    {
        string text = "";
        try
        {
            for (int i = 0; i < 10; i++)
            {
                string text2 = new RequestXNet("", "", string_2, 0).RequestPost("https://inboxes.com/api/v2/signup", "", "application/x-www-form-urlencoded");
                text = JObject.Parse(text2)["token"].ToString();
                if (!(text == ""))
                {
                    break;
                }
                Thread.Sleep(3000);
            }
        }
        catch (Exception)
        {
        }
        return text;
    }
    //

    // Token: 0x06000A38 RID: 2616 RVA: 0x000AB040 File Offset: 0x000A9240
    public static string GetOtpGetnada_New(string string_1, int int_4)
    {
        string text = "";
        string text2 = inboxes();
        string text3;
        if (text2 == "")
        {
            text3 = text;
        }
        else
        {
            try
            {
                RequestXNet requestXnet = new RequestXNet("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36", "", 0);
                //RequestXNet requestXnet = new RequestXNet("", "", "", 0);
                int tickCount = Environment.TickCount;
                do
                {
                    requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                    string text4 = requestXnet.RequestGet("https://inboxes.com/api/v2/inbox/" + string_1);
                    try
                    {
                        JToken[] array = JObject.Parse(text4)["msgs"].ToArray<JToken>();
                        for (int i = 0; i < array.Length; i++)
                        {
                            string text5 = array[i]["uid"].ToString();
                            if (text5 != "")
                            {
                                requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                                text4 = requestXnet.RequestGet("https://inboxes.com/api/v2/message/html/" + text5);
                                try
                                {
                                    requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                                    requestXnet.httpRequest.Raw(xNet.HttpMethod.DELETE, "https://inboxes.com/api/v2/inbox/" + string_1, null);
                                    goto IL_136;
                                }
                                catch
                                {
                                    goto IL_136;
                                }
                                goto IL_12B;
                            IL_136:
                                text = E22BB683(DE0AF1A5(smethod_06(B9BD5112(text4, ">(\\d+)<")), 1));
                                if (text != "")
                                {
                                    return text;
                                }
                            }
                        IL_12B:;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    Thread.Sleep(3000);
                }
                while (Environment.TickCount - tickCount < int_4 * 1000);
            }
            catch (Exception)
            {
            }
            text3 = text;
        }
        return text3;
    }

    // Token: 0x06000A39 RID: 2617 RVA: 0x000AB230 File Offset: 0x000A9430
    private string B20E4FA1(string F4355AA3, int A7AB5A81 = 300)
    {
        string text = "";
        string text2 = inboxes();
        string text3;
        if (text2 == "")
        {
            text3 = text;
        }
        else
        {
            try
            {
                RequestXNet requestXnet = new RequestXNet("", "", "", 0);
                int tickCount = Environment.TickCount;
                do
                {
                    requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                    string text4 = requestXnet.RequestGet("https://inboxes.com/api/v2/inbox/" + F4355AA3);
                    try
                    {
                        JToken[] array = JObject.Parse(text4)["msgs"].ToArray<JToken>();
                        for (int i = 0; i < array.Length; i++)
                        {
                            string text5 = array[i]["uid"].ToString();
                            if (text5 != "")
                            {
                                requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                                text4 = requestXnet.RequestGet("https://inboxes.com/api/v2/message/html/" + text5);
                                string text6 = Regex.Match(text4, "https://account.live.com(.*?)\"").Value;
                                text6 = text6.Replace("\"", "");
                                text = Common.HtmlDecode(text6);
                                try
                                {
                                    requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                                    requestXnet.httpRequest.Raw(xNet.HttpMethod.DELETE, "https://inboxes.com/api/v2/inbox/" + F4355AA3, null);
                                    goto IL_171;
                                }
                                catch
                                {
                                    goto IL_171;
                                }
                                goto IL_166;
                            IL_171:
                                if (FD874D1D(text, ""))
                                {
                                    return text;
                                }
                            }
                        IL_166:;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    Thread.Sleep(3000);
                }
                while (Environment.TickCount - tickCount < A7AB5A81 * 1000);
            }
            catch
            {
            }
            text3 = text;
        }
        return text3;
    }
    //
    public static string GetOtpFromGetnada_Fix(string string_1, string string_2, int int_4 = 300)
    {
        string text = "";
        string text2 = inboxes_Fix(string_2);
        string text3;
        if (text2 == "")
        {
            text3 = text;
        }
        else
        {
            try
            {
                RequestXNet requestXnet = new RequestXNet("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36", string_2, 0);
                int tickCount = Environment.TickCount;
                do
                {
                    requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                    string text4 = requestXnet.RequestGet("https://inboxes.com/api/v2/inbox/" + string_1);
                    try
                    {
                        JToken[] array = JObject.Parse(text4)["msgs"].ToArray<JToken>();
                        for (int i = 0; i < array.Length; i++)
                        {
                            string text5 = array[i]["uid"].ToString();
                            if (text5 != "")
                            {
                                requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                                text4 = requestXnet.RequestGet("https://inboxes.com/api/v2/message/html/" + text5);
                                try
                                {
                                    requestXnet.httpRequest.AddHeader("Authorization", "Bearer " + text2);
                                    requestXnet.httpRequest.Raw(xNet.HttpMethod.DELETE, "https://inboxes.com/api/v2/inbox/" + string_1, null);
                                    goto IL_136;
                                }
                                catch
                                {
                                    goto IL_136;
                                }
                                goto IL_12B;
                            IL_136:
                                text = E22BB683(DE0AF1A5(smethod_06(B9BD5112(text4, ">(\\d+)<")), 1));
                                // text = Regex.Match(json, ">(\\d{" + number + "})<").Groups[1].Value;
                                if (text != "")
                                {
                                    return text;
                                }
                            }
                        IL_12B:;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    Thread.Sleep(3000);
                }
                while (Environment.TickCount - tickCount < int_4 * 1000);
            }
            catch (Exception)
            {
            }
            text3 = text;
        }
        return text3;
        //
    }

    internal static string E22BB683(object object_0)
    {
        return ((Capture)object_0).Value;
    }
    internal static object DE0AF1A5(object object_0, int int_0)
    {
        return ((GroupCollection)object_0)[int_0];
    }
    internal static object smethod_06(object object_0)
    {
        return ((Match)object_0).Groups;
    }
    internal static object B9BD5112(string string_0, string string_1)
    {
        return Regex.Match(string_0, string_1);
    }
    internal static bool FD874D1D(string string_0, string string_1)
    {
        return string_0 != string_1;
    }
}
