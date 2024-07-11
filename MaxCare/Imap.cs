using AE.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;

public class Imap
{
	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckConnectImap(byte[] byte_0, byte[] EBB28AB8);

    public static bool CheckConnectImap(string BA88300C, string BC268623)
    {
        int num = 0;
        while (true)
        {
            try
            {
                string text = "";
                if (BA88300C.EndsWith("@hotmail.com") || BA88300C.EndsWith("@outlook.com") || BA88300C.EndsWith("@nickpromail.com"))
                {
                    text = "outlook.office365.com";
                }
                else if (BA88300C.EndsWith("@yandex.com"))
                {
                    text = "imap.yandex.com";
                }
                if (text == "")
                {
                    return true;
                }
                ImapClient imapClient = new ImapClient(text, BA88300C, BC268623, AuthMethods.Login, 993, secure: true);
                imapClient.Dispose();
                return false;
            }
            catch (Exception ex)
            {
                if (!ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
                {
                    goto IL_00aa;
                }
                num++;
                if (num >= 10)
                {
                    goto IL_00aa;
                }
                goto end_IL_0088;
            IL_00aa:
                return true;
            end_IL_0088:;
            }
        }
    }


    public static string ConnectToImap(int D1AD4804, string string_0, string B230B8B9, int int_0, string string_1, string ABBD0FB7)
	{
		string text = "";
		try
		{
			if (D1AD4804 == 5)
			{
				D1AD4804 = 4;
			}
			int tickCount = Environment.TickCount;
			do
			{
				text = ConnectImap(D1AD4804, string_0, B230B8B9, string_1, ABBD0FB7);
				if (!text.Contains("error"))
				{
					if (!(text != ""))
					{
						Common.Sleep(1.0);
						continue;
					}
					break;
				}
				text = "fail";
				break;
			}
			while (Environment.TickCount - tickCount < int_0 * 1000);
		}
		catch
		{
		}
		return text;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr ConnectImap(byte[] BEA84D98, byte[] C3353D17, byte[] byte_0, byte[] byte_1, byte[] byte_2);

    public static string ConnectImap(int int_0, string string_0, string string_1, string string_2, string string_3)
    {
        string text = "";
        string text3;
        try
        {
            int tickCount = Environment.TickCount;
            ImapClient imapClient;
            for (; ; )
            {
                imapClient = smethod_4(string_0, string_1);
                if (imapClient == null)
                {
                    goto IL_151;
                }
                imapClient.SelectMailbox(string_0.Contains("@yandex.") ? "Spam" : "Inbox");
                Lazy<AE.Net.Mail.MailMessage>[] array;
                if (int_0 == 3)
                {
                    array = imapClient.SearchMessages(SearchCondition.To(string_0), false, false);
                }
                else
                {
                    array = imapClient.SearchMessages(SearchCondition.From("security@facebookmail.com").And(new SearchCondition[] { SearchCondition.Unseen() }), false, false);
                    if (array == null || array.Length == 0)
                    {
                        array = imapClient.SearchMessages(SearchCondition.From("registration@facebookmail.com").And(new SearchCondition[] { SearchCondition.Unseen() }), false, false);
                    }
                }
                if (array != null && array.Length != 0)
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        AE.Net.Mail.MailMessage value = array[i].Value;
                        if (DateTime.Now.Subtract(value.Date).TotalMinutes > 5.0)
                        {
                            break;
                        }
                        string text2 = value.AlternateViews[1].Body.ToString();
                        imapClient.DeleteMessage(value);
                        text = OtpMailHelper.GetOtpMail(text2, int_0, string_2, "");
                        if (text != "")
                        {
                            goto IL_149;
                        }
                    }
                }
                smethod_5(imapClient);
                if (Environment.TickCount - tickCount >= int_0 * 1000)
                {
                    goto IL_151;
                }
            }
        IL_149:
            smethod_5(imapClient);
            return text;
        IL_151:
            text3 = text;
        }
        catch
        {
            return text;
        }
        return text3;
    }
    public static string smethod_3(string string_0)
    {
        string text = "";
        if (!string_0.Contains("@hotmail.") && !string_0.Contains("@live.") && !string_0.Contains("@rickystar.") && !string_0.Contains("@outlook."))
        {
            if (string_0.Contains("@yandex."))
            {
                text = "imap.yandex.com";
            }
            else if (string_0.Contains("@gmail."))
            {
                text = "imap.gmail.com";
            }
        }
        else
        {
            text = "outlook.office365.com|imap-mail.outlook.com";
        }
        return text;
    }

    // Token: 0x060009FC RID: 2556 RVA: 0x00102990 File Offset: 0x00100B90
    public static ImapClient smethod_4(string string_0, string string_1)
    {
        ImapClient imapClient = null;
        string text = smethod_3(string_0);
        if (!(text == ""))
        {
            List<string> list = text.Split(new char[] { '|' }).ToList<string>();
            for (int i = 0; i < 10; i++)
            {
                bool flag = false;
                for (int j = 0; j < list.Count; j++)
                {
                    text = list[j];
                    try
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                        return new ImapClient(text, string_0, string_1, AuthMethods.Login, 993, true, false);
                    }
                    catch (Exception ex)
                    {
                        flag = ex.ToString().Contains("The remote certificate is invalid according to the validation procedure") || ex.ToString().Contains("An established connection was aborted by the software in your host machine");
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
        }
        return imapClient;
    }
    public static void smethod_5(ImapClient imapClient_0)
    {
        try
        {
            if (!imapClient_0.IsDisposed)
            {
                imapClient_0.Dispose();
            }
            if (imapClient_0.IsConnected)
            {
                imapClient_0.Disconnect();
            }
        }
        catch
        {
        }
    }
    public static string GetOtpFromMail(int type, string email, string passmail, int timeout = 120, string uidFb = "")
    {
        string text = "";
        string text3;
        try
        {
            int tickCount = Environment.TickCount;
            ImapClient imapClient;
            for (; ; )
            {
                imapClient = smethod_4(email, passmail);
                if (imapClient == null)
                {
                    goto IL_151;
                }
                imapClient.SelectMailbox(email.Contains("@yandex.") ? "Spam" : "Inbox");
                Lazy<AE.Net.Mail.MailMessage>[] array;
                if (type == 3)
                {
                    array = imapClient.SearchMessages(SearchCondition.To(email), false, false);
                }
                else
                {
                    array = imapClient.SearchMessages(SearchCondition.From("security@facebookmail.com").And(new SearchCondition[] { SearchCondition.Unseen() }), false, false);
                    if (array == null || array.Length == 0)
                    {
                        array = imapClient.SearchMessages(SearchCondition.From("registration@facebookmail.com").And(new SearchCondition[] { SearchCondition.Unseen() }), false, false);
                    }
                }
                if (array != null && array.Length != 0)
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {
                        AE.Net.Mail.MailMessage value = array[i].Value;
                        if (DateTime.Now.Subtract(value.Date).TotalMinutes > 5.0)
                        {
                            break;
                        }
                        string text2 = value.AlternateViews[1].Body.ToString();
                        imapClient.DeleteMessage(value);
                        text = OtpMailHelper.GetOtpMail(text2, type, uidFb, "");
                        if (text != "")
                        {
                            goto IL_149;
                        }
                    }
                }
                smethod_5(imapClient);
                if (Environment.TickCount - tickCount >= type * 1000)
                {
                    goto IL_151;
                }
            }
        IL_149:
            smethod_5(imapClient);
            return text;
        IL_151:
            text3 = text;
        }
        catch
        {
            return text;
        }
        return text3;
    }
}
