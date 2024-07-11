using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class CommonChrome
{

    public static string GetTokenEAAG(Chrome chrome, string c2fa)
    {
        string text = "";
        try
        {
            if (!chrome.GetURL().Contains("https://business.facebook.com/business_locations"))
            {
                chrome.GotoURL("https://business.facebook.com/business_locations");
                chrome.DelayTime(1.0);
            }
            for (int i = 0; i < 5; i++)
            {
                if (chrome.CheckExistElement("#globalContainer [type=\"text\"]") != 1)
                {
                    break;
                }
                chrome.ClearText(4, "#globalContainer [type=\"text\"]");
                chrome.DelayTime(1.0);
                chrome.SendKeys(4, "#globalContainer [type=\"text\"]", Common.GetTotp(c2fa));
                chrome.DelayTime(1.0);
                chrome.SendEnter(4, "#globalContainer [type=\"text\"]");
                chrome.DelayTime(5.0);
            }
            string input = chrome.GetPageSource();
            text = Regex.Match(input, "EAAG(.*?)\"").Value.Replace("'", "").Replace("\"", "");
        }
        catch
        {
        }
        return text;
    } 
	public static string GetTokenEAABs(Chrome chrome)
    {
        //try
        //{
        //    chrome.GotoURL("https://www.facebook.com/adsmanager/manage/campaigns?act=");
        //    string input = chrome.GetPageSource();
        //    CommonChrome.RequestGet(chrome, "https://www.facebook.com/adsmanager/manage/campaigns?act=", chrome.GetURL());
        //    token = Regex.Match(input, "(EAABs.*?)\"").Groups[1].Value;
        //}
        //catch
        //{
        //}
        string text = "";
        try
        {
            if (!chrome.GetURL().StartsWith("https://adsmanager.facebook.com/"))
            {
                chrome.GotoURL("https://adsmanager.facebook.com/api/graphql/");
            }
			string text2 = chrome.RequestGetv2("https://adsmanager.facebook.com/adsmanager/manage/campaigns?act=", chrome.GetURL());
			string text3 = Regex.Match(text2, "(https:\\\\/\\\\/adsmanager.facebook.com\\\\/adsmanager\\\\/manage\\\\/campaigns\\?act=.*?)\"").Groups[1].Value;
			if (text3 != "")
			{
				text3 = text3.Replace("\\", "");
				text2 = chrome.RequestGetv2(text3, "");
			}
			text = Regex.Match(text2, "(EAABs.*?)\"").Groups[1].Value;
		}
        catch
        {
        }
        return text;
    }
	public static string GetTokenEAABw(Chrome chrome)
    {
        string text = "";
        try
        {
            if (!chrome.GetURL().StartsWith("https://www.face"))
            {
                chrome.GotoURL("https://www.facebook.com/");
            }
            chrome.DelayTime(1.0);
            string textx = chrome.ExecuteScript("return require('DTSGInitData').token").ToString();
            string value = Regex.Match(chrome.ExecuteScript("return document.cookie").ToString(), "c_user=(.*?);").Groups[1].Value;
            string string_ = "fb_dtsg=" + textx + "&app_id=124024574287414&redirect_uri=fbconnect%3A%2F%2Fsuccess&display=page&access_token=&from_post=1&return_format=access_token&domain=&sso_device=ios&_CONFIRM=1&_user=" + value;
            string input = CommonChrome.RequestPost(chrome, "https://www.facebook.com/v1.0/dialog/oauth/confirm", string_, chrome.GetURL());
            text = Regex.Match(input, "access_token=(.*?)&").Groups[1].Value;
        }
        catch
        {
        }
        return text;
    }
    public static bool CheckFacebookBlocked(Chrome chrome)
    {
        if (chrome.GetURL().StartsWith("https://m.facebook.com/feature_limit_notice/") || chrome.CheckExistElements(0.0, "[href*=\"facebook.com/help/177066345680802\"]", "[href*=\"facebook.com/help/contact/\"]") != 0 || chrome.GetURL().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
        {
            return true;
        }
        return false;
    }
    public static void AnswerQuestionWhenJoinGroup(Chrome B794B596, List<string> list_0)
	{
		List<string> list = new List<string>();
		int num = B794B596.CountElementWithXpath("textarea");
		string text = "";
		for (int i = 0; i < num; i++)
		{
			if (list.Count == 0)
			{
				list = Common.CloneList(list_0);
			}
			text = list[Base.rd.Next(0, list.Count)];
			text = Common.SpinText(text);
			list.Remove(text);
			B794B596.ScrollSmooth($"document.querySelectorAll('textarea')[{num}]");
			B794B596.DelayRandom(1, 2);
			B794B596.SendKeys(4, "textarea", i, text, 0.1);
			B794B596.DelayRandom(1, 2);
		}
	}

	public static void E2019F99(Chrome chrome, List<string> list_0)
	{
		List<string> list = new List<string>();
		string text = "[aria-label=\"Answer Questions\"][role=\"dialog\"] [data-visualcompletion=\"ignore-dynamic\"]";
		string text2 = "";
		int num = 0;
		int num2 = Convert.ToInt32(chrome.ExecuteScript("return document.querySelectorAll('" + text + "').length").ToString());
		for (int i = 0; i < num2; i++)
		{
			if (chrome.ExecuteScript("return document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"radio\"]')+''").ToString() != "null")
			{
				num = 1;
			}
			else if (chrome.ExecuteScript("return document.querySelectorAll('" + text + "')[" + i + "].querySelector('textarea')+''").ToString() != "null")
			{
				num = 2;
			}
			else if (chrome.ExecuteScript("return document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"checkbox\"]')+''").ToString() != "null")
			{
				num = 3;
			}
			chrome.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('" + text + "')[" + i + "]");
			chrome.DelayTime(1.0);
			switch (num)
			{
			case 1:
				chrome.ExecuteScript("document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"radio\"]').click()");
				chrome.DelayTime(1.0);
				break;
			case 2:
				if (list.Count == 0)
				{
					list = Common.CloneList(list_0);
				}
				text2 = list[Base.rd.Next(0, list.Count)];
				list.Remove(text2);
				chrome.SendKeysV2(4, text ?? "", i, 4, "textarea", 0, text2);
				chrome.DelayTime(1.0);
				break;
			case 3:
				chrome.ExecuteScript("document.querySelectorAll('" + text + "')[" + i + "].querySelector('[name=\"checkbox\"]').click()");
				chrome.DelayTime(1.0);
				break;
			}
		}
		if (chrome.CheckExistElement("[name=\"agree-to-group-rules\"]") == 1)
		{
			if (chrome.Click(2, "agree-to-group-rules") == 0)
			{
				chrome.ExecuteScript("document.querySelector('[name=\"agree-to-group-rules\"]').click()");
			}
			chrome.DelayTime(1.0);
		}
	}

	public static bool CheckCaptchaRespon(Chrome CD3D1D16)
	{
		try
		{
			List<string> list = new List<string> { "#captcha_response", "[name=\"captcha_response\"]", "[name=\"verification_method\"]", "[name=\"password_new\"]", "[href=\"https://www.facebook.com/communitystandards/\"]" };
			return CD3D1D16.CheckExistElements(0.0, list.ToArray()) > 0;
		}
		catch
		{
			return false;
		}
	}

	public static int smethod_0(Chrome E802D69F, string string_0, string string_1, string string_2 = "", string string_3 = "https://www.facebook.com")
	{
		new Random();
		int result = 0;
		try
		{
			int num = 0;
			num = CheckTypeWebFacebookFromUrl(E802D69F.GetURL());
			if (num != 0)
			{
				goto IL_003e;
			}
			if (E802D69F.GotoURL(string_3) != -2)
			{
				num = CheckTypeWebFacebookFromUrl(E802D69F.GetURL());
				goto IL_003e;
			}
			result = -2;
			goto end_IL_0008;
			IL_003e:
			if (E802D69F.CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
			{
				E802D69F.Click(4, "[data-cookiebanner=\"accept_button\"]");
				E802D69F.DelayTime(1.0);
			}
			if (num == 1)
			{
				E802D69F.GotoURLIfNotExist("https://www.facebook.com/login");
				if (E802D69F.CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					E802D69F.Click(4, "[data-cookiebanner=\"accept_button\"]");
					E802D69F.DelayTime(1.0);
				}
				if (E802D69F.SendKeys(1, "email", string_0, 0.1) == -2)
				{
					result = -2;
				}
				else
				{
					E802D69F.DelayTime(1.0);
					if (E802D69F.SendKeys(1, "pass", string_1, 0.1) == -2)
					{
						result = -2;
					}
					else
					{
						E802D69F.DelayTime(1.0);
						if (E802D69F.Click(1, "loginbutton") != -2)
						{
							E802D69F.DelayTime(1.0);
							if (E802D69F.CheckExistElement("#approvals_code", 5.0) == 1 && string_2 != "")
							{
								string text = Common.GetTotp(string_2.Replace(" ", "").Replace("\n", ""));
								if (text != "")
								{
									E802D69F.SendKeys(1, "approvals_code", text, 0.1);
									E802D69F.DelayTime(1.0);
									E802D69F.Click(1, "checkpointSubmitButton");
									E802D69F.DelayTime(1.0);
								}
							}
							int num2 = 0;
							while (E802D69F.CheckExistElement("#checkpointSubmitButton", 3.0) == 1)
							{
								if (!E802D69F.CheckIsLive())
								{
									if (!E802D69F.GetURL().Contains("m.facebook"))
									{
										E802D69F.GotoURL(E802D69F.GetURL().Replace("www", "m").Replace("mbasic", "m"));
									}
									if (CheckCaptchaRespon(E802D69F) || num2 == 7)
									{
										break;
									}
									E802D69F.Click(1, "checkpointSubmitButton");
									E802D69F.DelayTime(1.0);
									num2++;
									continue;
								}
								result = -2;
								goto end_IL_0008;
							}
							goto IL_062a;
						}
						result = -2;
					}
				}
			}
			else
			{
				int num3 = E802D69F.GotoURLIfNotExist("https://mobile.facebook.com/login");
				if (E802D69F.CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					E802D69F.Click(4, "[data-cookiebanner=\"accept_button\"]");
					E802D69F.DelayTime(1.0);
				}
				num3 = E802D69F.CheckExistElement("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0);
				int num4 = num3;
				int num5 = num4;
				if (num5 != -2)
				{
					if (num5 != 1)
					{
						if (E802D69F.SendKeys(1, "m_login_email", string_0, 0.1) == 1)
						{
							E802D69F.DelayThaoTacNho();
							string fBA9F11A = ((E802D69F.CheckExistElements(3.0, "#m_login_password", "[name=\"pass\"]") == 1) ? "#m_login_password" : "[name=\"pass\"]");
							E802D69F.SendKeys(4, fBA9F11A, string_1, 0.1);
							E802D69F.DelayThaoTacNho();
							E802D69F.Click(2, "login");
							E802D69F.DelayThaoTacNho();
						}
						goto IL_04eb;
					}
					E802D69F.DelayThaoTacNho();
					if (E802D69F.Click(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") != -2)
					{
						E802D69F.DelayThaoTacNho(2);
						switch (E802D69F.CheckExistElements(10.0, "[name=\"pass\"]", "#approvals_code"))
						{
						case -2:
							result = -2;
							goto end_IL_0008;
						case 1:
							if (E802D69F.SendKeys(2, "pass", string_1, 0.1) == 1)
							{
								E802D69F.DelayThaoTacNho();
								if (E802D69F.Click(4, E802D69F.GetCssSelector("button", "data-sigil", "password_login_button")) == 1)
								{
									E802D69F.DelayTime(1.0);
								}
							}
							break;
						}
						goto IL_04eb;
					}
					result = -2;
				}
				else
				{
					result = -2;
				}
			}
			goto end_IL_0008;
			IL_062a:
			E802D69F.DelayTime(1.0);
			return CheckLiveCookie(E802D69F);
			IL_04eb:
			switch (E802D69F.CheckExistElements(5.0, "#approvals_code", "#identify_search_text_input"))
			{
			case -2:
				result = -2;
				goto end_IL_0008;
			case 1:
				if (string_2.Trim() != "")
				{
					string text2 = Common.GetTotp(string_2.Replace(" ", "").Replace("\n", ""));
					if (text2 != "")
					{
						E802D69F.SendKeys(1, "approvals_code", text2, 0.1);
						E802D69F.DelayThaoTacNho(-1);
						E802D69F.SendEnter("#approvals_code");
						E802D69F.DelayThaoTacNho();
					}
				}
				goto default;
			default:
			{
				int num6 = 0;
				while (E802D69F.CheckExistElement("#checkpointSubmitButton-actual-button", 3.0) == 1 && E802D69F.CheckExistElement("[name=\"password_new\"]") != 1)
				{
					if (!E802D69F.CheckIsLive())
					{
						if (CheckCaptchaResponse(E802D69F) || num6 == 7)
						{
							break;
						}
						E802D69F.Click(1, "checkpointSubmitButton-actual-button");
						E802D69F.DelayThaoTacNho();
						num6++;
						continue;
					}
					result = -2;
					goto end_IL_0008;
				}
				break;
			}
			}
			goto IL_062a;
			end_IL_0008:;
		}
		catch (Exception exception_)
		{
			Common.ExportError(E802D69F, exception_, "Login Uid Pass Fail");
		}
		return result;
	}

	public static string GetNameFromPost(Chrome f336F52E_0)
	{
		string text = f336F52E_0.ExecuteScript("var x='';document.querySelectorAll('[property=\"og:title\"]').length>0&&(x=document.querySelector('[property=\"og:title\"]').getAttribute('content')),''==x&&document.querySelectorAll('[data-gt] a').length>0&&(x=document.querySelector('[data-gt] a').innerText),''==x&&document.querySelectorAll('.actor').length>0&&(x=document.querySelector('.actor').innerText), x+''; return x;").ToString();
		if (text == "")
		{
			text = f336F52E_0.ExecuteScript("return document.title").ToString().Split('-', '|')[0].Trim();
		}
		return text;
	}

	public static string smethod_1(Chrome f336F52E_0)
	{
		return f336F52E_0.ExecuteScript("var x='';document.querySelectorAll('.overflowText').length>0&&(x=document.querySelector('.overflowText').innerText), x+''; return x;").ToString();
	}

	public static int GoToHome(Chrome chrome)
	{
		try
		{
			if (chrome == null)
			{
				return -1;
			}
			int tickCount = Environment.TickCount;
			int num = 30;
			do
			{
				if (!chrome.CheckIsLive())
				{
					string text = chrome.GetURL();
					if (!text.StartsWith(chrome.method_17("https://mobile.facebook.com/home.php", text)) && !(text == chrome.method_17("https://mobile.facebook.com", text)))
					{
						if (!chrome.Click("#feed_jewel a"))
						{
							chrome.GotoURL("https://mobile.facebook.com/home.php");
						}
						if (chrome.CheckExistElement("#nux-nav-button") == 1)
						{
							chrome.ClickWithActionAll("#nux-nav-button");
							if (chrome.CheckExistElement("#qf_skip_dialog_skip_link", 5.0) == 1)
							{
								chrome.ClickWithActionAll("#qf_skip_dialog_skip_link");
							}
						}
						chrome.DelayTime(1.0);
						continue;
					}
					return 1;
				}
				return -2;
			}
			while (Environment.TickCount - tickCount < num * 1000);
		}
		catch
		{
		}
		return 0;
	}

	public static int GoToFriend(Chrome f336F52E_0)
	{
		try
		{
			if (f336F52E_0 != null)
			{
				if (f336F52E_0.CheckIsLive())
				{
					return -2;
				}
				if (f336F52E_0.CheckExistElement("#requests_jewel a") == 1)
				{
					f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelector('#requests_jewel a')");
					f336F52E_0.DelayThaoTacNho();
				}
				int num = f336F52E_0.Click(4, "#requests_jewel a");
				if (num != 1)
				{
					GoToHome(f336F52E_0);
					f336F52E_0.DelayThaoTacNho(2);
					num = f336F52E_0.Click(4, "#requests_jewel a");
				}
				if (num == 1)
				{
					f336F52E_0.DelayThaoTacNho(1);
					if (f336F52E_0.Click(4, "[href=\"/friends/center/friends/?mff_nav=1\"]") == 1)
					{
						f336F52E_0.DelayThaoTacNho();
						return 1;
					}
				}
				return f336F52E_0.GotoURL("https://mobile.facebook.com/friends/center/friends/?mff_nav=1");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_4(Chrome f336F52E_0)
	{
		try
		{
			if (f336F52E_0 != null)
			{
				if (f336F52E_0.CheckIsLive())
				{
					return -2;
				}
				f336F52E_0.GotoURL("https://mobile.facebook.com/groups_browse/your_groups/");
				f336F52E_0.D38ABC24();
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int A3985F1D(Chrome A40E900C)
	{
		try
		{
			if (A40E900C != null)
			{
				if (A40E900C.CheckIsLive())
				{
					return -2;
				}
				A40E900C.GotoURL("https://mobile.facebook.com/watch/?ref=bookmarks");
				A40E900C.D38ABC24();
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_5(Chrome f336F52E_0)
	{
		return f336F52E_0.GotoURL("https://mobile.facebook.com/messages/?folder=unread&ref=bookmarks");
	}

	public static int smethod_6(Chrome DDB126BF)
	{
		try
		{
			if (DDB126BF != null)
			{
				if (DDB126BF.CheckIsLive())
				{
					return -2;
				}
				if (DDB126BF.CheckExistElement("#notifications_jewel a") == 1)
				{
					DDB126BF.ScrollSmoothIfNotExistOnScreen("document.querySelector('#search_jewel a')");
					DDB126BF.DelayThaoTacNho();
				}
				int num = DDB126BF.Click(4, "#search_jewel a");
				if (num != 1)
				{
					GoToHome(DDB126BF);
					DDB126BF.DelayThaoTacNho();
					num = DDB126BF.Click(4, "#search_jewel a");
					if (num != 1)
					{
						num = DDB126BF.Click(1, "search_jewel_container_sigil");
					}
				}
				if (num == 1 && DDB126BF.CheckExistElement("#main-search-input") == 1)
				{
					DDB126BF.DelayThaoTacNho(1);
					return 1;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_7(Chrome f336F52E_0, string string_0, int int_0 = 0)
	{
		try
		{
			if (f336F52E_0 != null)
			{
				if (f336F52E_0.CheckIsLive())
				{
					return -2;
				}
				if (smethod_6(f336F52E_0) == 1)
				{
					bool flag = false;
					if (f336F52E_0.CheckExistElement("#main-search-input") == 1)
					{
						string_0 = Common.SpinText(string_0);
						f336F52E_0.SendKeysWithSpeed("#main-search-input", string_0, 0.1);
						f336F52E_0.DelayThaoTacNho();
						f336F52E_0.SendEnter(1, "main-search-input");
						f336F52E_0.DelayThaoTacNho(2);
						string text = f336F52E_0.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
						if (text != "")
						{
							if (f336F52E_0.Click(4, text) == 0)
							{
								if (f336F52E_0.Click(4, "[data-sigil=\" flyout-causal\"]") == 1)
								{
									f336F52E_0.DelayThaoTacNho();
									text = f336F52E_0.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
									if (text != "")
									{
										flag = true;
										f336F52E_0.Click(4, text);
										f336F52E_0.DelayThaoTacNho(2);
									}
								}
							}
							else
							{
								flag = true;
								f336F52E_0.DelayThaoTacNho(2);
							}
						}
					}
					if (!flag)
					{
						f336F52E_0.GotoURL("https://mobile.facebook.com/search/groups/?q=" + string_0);
						f336F52E_0.DelayThaoTacNho(2);
						flag = true;
					}
					if (flag)
					{
						f336F52E_0.DelayThaoTacNho(1);
						return 1;
					}
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_8(Chrome BCB0F027, string string_0, int int_0 = 0)
	{
		try
		{
			if (BCB0F027 != null)
			{
				if (BCB0F027.CheckIsLive())
				{
					return -2;
				}
				if (smethod_6(BCB0F027) == 1)
				{
					bool flag = false;
					if (BCB0F027.CheckExistElement("#main-search-input") == 1)
					{
						string_0 = Common.SpinText(string_0);
						switch (int_0)
						{
						case 0:
							BCB0F027.SendKeys(Base.rd, 1, "main-search-input", string_0, 0.1);
							break;
						case 1:
							BCB0F027.SendKeys(1, "main-search-input", string_0, 0.1);
							break;
						case 2:
							BCB0F027.SendKeys(1, "main-search-input", string_0);
							break;
						}
						BCB0F027.DelayThaoTacNho();
						BCB0F027.SendEnter(1, "main-search-input");
						BCB0F027.DelayThaoTacNho(2);
						string text = BCB0F027.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
						if (text != "")
						{
							if (BCB0F027.Click(4, text) == 0)
							{
								if (BCB0F027.Click(4, "[data-sigil=\" flyout-causal\"]") == 1)
								{
									BCB0F027.DelayThaoTacNho();
									text = BCB0F027.GetCssSelector("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
									if (text != "")
									{
										flag = true;
										BCB0F027.Click(4, text);
										BCB0F027.DelayThaoTacNho(2);
									}
								}
							}
							else
							{
								flag = true;
								BCB0F027.DelayThaoTacNho(2);
							}
						}
					}
					if (!flag)
					{
						BCB0F027.GotoURL("https://mobile.facebook.com/search/people/?q=" + string_0 + "&source=filter&isTrending=0");
						BCB0F027.DelayThaoTacNho(2);
						flag = true;
					}
					if (flag)
					{
						BCB0F027.DelayThaoTacNho(1);
						return 1;
					}
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int BF2CBD02(Chrome AA334306)
	{
		try
		{
			if (AA334306 != null)
			{
				if (AA334306.GotoURL("https://mobile.facebook.com/browse/birthdays/") != -2)
				{
					AA334306.DelayRandom(2, 5);
					return 1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_9(Chrome EC289489)
	{
		try
		{
			if (EC289489 != null)
			{
				if (EC289489.GotoURL("https://mobile.facebook.com/pokes/") != -2)
				{
					EC289489.DelayRandom(2, 5);
					return 1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int ScrollRandom(Chrome f336F52E_0, int int_0 = 3, int AA349628 = 5)
	{
		try
		{
			if (f336F52E_0.CheckIsLive())
			{
				return -2;
			}
			int num = Base.rd.Next(int_0, AA349628 + 1);
			int num2 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
			if (f336F52E_0.ScrollSmooth(Base.rd.Next(f336F52E_0.GetSizeChrome().Y / 2, f336F52E_0.GetSizeChrome().Y)) == 1)
			{
				f336F52E_0.DelayRandom(1, 3);
				int num3 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
				if (num2 != num3)
				{
					for (int i = 0; i < num - 1; i++)
					{
						num2 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
						if (f336F52E_0.ScrollSmooth(((Base.rd.Next(1, 1000) % 5 != 0) ? 1 : (-1)) * Base.rd.Next(f336F52E_0.GetSizeChrome().Y / 2, f336F52E_0.GetSizeChrome().Y)) != -2)
						{
							f336F52E_0.DelayRandom(1, 3);
							num3 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
							if (num2 == num3)
							{
								break;
							}
							f336F52E_0.DelayRandom(1, 2);
							continue;
						}
						return -2;
					}
				}
				return 1;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_11(Chrome f336F52E_0)
	{
		try
		{
			if (f336F52E_0 != null)
			{
				if (f336F52E_0.CheckIsLive())
				{
					return -2;
				}
				switch (f336F52E_0.CheckExistElement("[jsselect=\"suggestionsSummaryList\"]"))
				{
				default:
					if (IsCheckpoint(f336F52E_0))
					{
						return -1;
					}
					break;
				case 1:
					return -3;
				case -2:
					return -2;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static string smethod_12(Chrome DB8C081A, string C636610F, string CF13CD3A = "https://www.facebook.com")
	{
		try
		{
			DB8C081A.GotoURLIfNotExist(CF13CD3A);
			DB8C081A.AddCookieIntoChrome(C636610F);
			DB8C081A.Refresh();
			return CheckLiveCookie(DB8C081A).ToString() ?? "";
		}
		catch
		{
		}
		return "0";
	}

	public static int CheckTypeWebFacebookFromUrl(string string_0)
	{
		int result = 0;
		if (string_0.StartsWith("https://www.facebook") || string_0.StartsWith("https://facebook") || string_0.StartsWith("https://web.facebook"))
		{
			result = 1;
		}
		else if (string_0.StartsWith("https://m.facebook") || string_0.StartsWith("https://mobile.facebook"))
		{
			result = 2;
		}
		else if (string_0.StartsWith("https://mbasic.facebook") || string_0.StartsWith("https://d.facebook"))
		{
			result = 3;
		}
		return result;
	}

	public static int CheckFacebookWebsite(Chrome B1BA7A3F, string string_0)
	{
		if (B1BA7A3F.CheckIsLive())
		{
			return -2;
		}
		int num = 0;
		for (int i = 0; i < 2; i++)
		{
			num = CheckTypeWebFacebookFromUrl(B1BA7A3F.GetURL());
			if (num != 0)
			{
				break;
			}
			B1BA7A3F.GotoURL(string_0);
			B1BA7A3F.DelayTime(1.0);
		}
		return num;
	}

	public static int GotoLogin(Chrome f336F52E_0, int int_0)
	{
		bool flag = false;
		try
		{
			switch (int_0)
			{
			case 1:
				f336F52E_0.GotoURL("https://www.facebook.com/login");
				break;
			case 2:
				f336F52E_0.GotoURL("https://mobile.facebook.com/login");
				break;
			case 3:
				f336F52E_0.GotoURL("https://mbasic.facebook.com/login");
				break;
			}
			flag = true;
			f336F52E_0.DelayTime(1.0);
		}
		catch (Exception)
		{
		}
		return flag ? 1 : 0;
	}

	public static string LoginFacebook(Chrome f336F52E_0, int int_0, string DE20CC2D, string string_0, string string_1, string string_2, string A48CCA36, string string_3, bool bool_0, bool bool_1 = false)
	{
		string result = "";
		switch (int_0)
		{
		case 0:
			if (string_0.Trim() == "" || string_2.Trim() == "")
			{
				if (string_0.Trim() == "")
				{
					result = Language.GetValue("Không ti\u0300m thâ\u0301y UID!");
				}
				else if (string_2.Trim() == "")
				{
					result = Language.GetValue("Không ti\u0300m thâ\u0301y Pass!");
				}
			}
			else
			{
				result = LoginFacebookUsingUidPassNew(f336F52E_0, string_0, string_2, A48CCA36, DE20CC2D, bool_0, 120, bool_1);
			}
			break;
		case 1:
			if (string_1.Trim() == "" || string_2.Trim() == "")
			{
				if (string_1.Trim() == "")
				{
					result = Language.GetValue("Không ti\u0300m thâ\u0301y Email!");
				}
				else if (string_2.Trim() == "")
				{
					result = Language.GetValue("Không ti\u0300m thâ\u0301y Pass!");
				}
			}
			else
			{
				result = LoginFacebookUsingUidPassNew(f336F52E_0, string_1, string_2, A48CCA36, DE20CC2D, bool_0, 120, bool_1);
			}
			break;
		case 2:
		case 3:
			result = ((!(string_3.Trim() == "")) ? smethod_12(f336F52E_0, string_3, DE20CC2D) : Language.GetValue("Không ti\u0300m thâ\u0301y Cookie!"));
			break;
		}
		return result;
	}

	public static string LoginFacebookUsingUidPassNew(Chrome C8819A33, string EF3C5192, string string_0, string string_1 = "", string string_2 = "https://mobile.facebook.com", bool bool_0 = false, int A3B59696 = 120, bool bool_1 = false)
	{
		int num = 0;
		string text = C8819A33.GetURL();
		if (text.Contains("1501092823525282") || text.Contains("828281030927956") || (text.Contains("facebook.com/nt/screen/?params=") && text.Contains("checkpoint")))
		{
			num = 2;
		}
		else
		{
			int num2 = 0;
			int tickCount = Environment.TickCount;
			try
			{
				if (C8819A33.GetFbWeb() != C8819A33.GetFbWeb(string_2))
				{
					C8819A33.GotoURL(string_2);
				}
				int int_ = CheckFacebookWebsite(C8819A33, string_2);
				while (true)
				{
					IL_136e:
					if (C8819A33.CheckExistElement("[name='email']") != 1 || C8819A33.CheckExistElement("[name='pass']") != 1 || C8819A33.CheckExistElement("[name='login']") != 1 || C8819A33.CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
					{
						if (C8819A33.GetURL().Contains("facebook.com/user_cookie_prompt"))
						{
							C8819A33.GotoURL("https://mobile.facebook.com/");
						}
						if (C8819A33.CheckExistElement("[name=\"accept_only_essential\"][value=\"0\"]") == 1)
						{
							C8819A33.Click("[name=\"accept_only_essential\"][value=\"0\"]");
						}
						C8819A33.ExecuteScript("document.querySelector('[name=\"primary_consent_button\"]').click()");
						C8819A33.ExecuteScript("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
						C8819A33.ExecuteScript("document.querySelectorAll('[data-testid=\"cookie-policy-manage-dialog-accept-button\"]')[1].click()");
						if (C8819A33.CheckExistElement("[name=\"pass\"]") != 1)
						{
							C8819A33.CheckLinkLogin(int_);
							C8819A33.ExecuteScript("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
							C8819A33.ExecuteScript("document.querySelectorAll('[data-testid=\"cookie-policy-manage-dialog-accept-button\"]')[1].click()");
						}
					}
					if (C8819A33.GetFbWeb() == 1)
					{
						if (C8819A33.method_12(0, new string[2] { "[data-userid] [name=\"login\"]", "[data-userid]" }) == 1 && C8819A33.CheckExistElement("[role=\"dialog\"] [name=\"pass\"]", 5.0) == 1)
						{
							C8819A33.DelayTime(1.0);
							C8819A33.SendKeysWithSpeed("[role=\"dialog\"] [name=\"pass\"]", string_0, 0.1);
							C8819A33.DelayTime(1.0);
							C8819A33.ExecuteJSClick("[role=\"dialog\"] [name=\"login\"]");
						}
					}
					else if (C8819A33.CheckExistElement("[name='email']") != 1 || C8819A33.CheckExistElement("[name='pass']") != 1 || C8819A33.CheckExistElement("[name='login']") != 1)
					{
						if (C8819A33.method_12(0, new string[2] { "[data-sigil=\"login_profile_form\"] div[role=\"button\"]", "[action*=\"/login/device-based/\"] [type=\"submit\"]" }) == 1)
						{
							if (C8819A33.CheckExistElements(5.0, new List<string> { "[name=\"pass\"]", "#approvals_code" }) == "[name=\"pass\"]")
							{
								C8819A33.DelayTime(1.0);
								C8819A33.SendKeysWithSpeed("[name=\"pass\"]", string_0, 0.1);
								C8819A33.DelayTime(1.0);
								C8819A33.SendEnter(2, "pass");
							}
						}
						else if (C8819A33.GetFbWeb() == 2)
						{
							C8819A33.FindAndClick(0.0, 4, "[id=\"nux-nav-button\"]");
						}
					}
					if (C8819A33.CheckExistElement("[name='email']") == 1 && C8819A33.CheckExistElement("[name='pass']") == 1 && C8819A33.CheckExistElement("[name='login']") == 1)
					{
						string text2 = C8819A33.GetURL();
						num2 = C8819A33.SendKeysWithSpeed("[name='email']", EF3C5192, 0.1);
						C8819A33.DelayTime(1.0);
						num2 = C8819A33.SendKeysWithSpeed("[name='pass']", string_0, 0.1);
						C8819A33.DelayTime(1.0);
						num2 = C8819A33.Click(2, "login");
						C8819A33.DelayTime(2.0);
						for (int i = 0; i < 10; i++)
						{
							if (C8819A33.GetURL() != text2)
							{
								break;
							}
							if (C8819A33.ExecuteScript("return document.querySelectorAll('[name=\"email\"]')[0].value").ToString() == "")
							{
								break;
							}
							C8819A33.DelayTime(2.0);
						}
					}
					int num3 = 0;
					int num4 = 5;
					int num5 = 0;
					int num6 = 2;
					int num7 = 0;
					int num8 = 2;
					int num9 = 0;
					string text3 = "";
					while (!C8819A33.CheckIsLive() && Environment.TickCount - tickCount < A3B59696 * 1000)
					{
						switch (C8819A33.CheckExistElements(0.0, new List<string>
						{
							"[name=\"login\"]", "[name=\"approvals_code\"]", "[name=\"verification_method\"]", "#checkpointSubmitButton", "#qf_skip_dialog_skip_link", "#nux-nav-button", "[name=\"n\"]", "[name=\"reset_action\"]", "#checkpointBottomBar", "[name=\"primary_consent_button\"]",
							"#identify_search_text_input", "[action*=\"/login/device-based/update-nonce/\"]"
						}))
						{
						case "#nux-nav-button":
							C8819A33.Click(1, "nux-nav-button");
							C8819A33.DelayTime(2.0);
							goto IL_12e2;
						case "#checkpointBottomBar":
							if (num7 > 1)
							{
								num = 6;
							}
							else if (C8819A33.CheckExistElements(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]") != 0 || CheckStringContainKeyword(C8819A33.GetPageSource(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395", "checkpoint/828281030927956" }))
							{
								num = 2;
							}
							else
							{
								num2 = C8819A33.CheckExistElements(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]");
								if (num9 < 10)
								{
									if (C8819A33.CheckExistElement("[value=\"dont_save\"]") == 1 && bool_0)
									{
										C8819A33.Click(4, "[value=\"dont_save\"]");
									}
									num9++;
									if (num2 == 1)
									{
										C8819A33.Click(4, "button#checkpointSubmitButton");
									}
									else
									{
										C8819A33.method_12(0, new string[3] { "#checkpointSubmitButton [type=\"submit\"]", "[name=\"submit[Get Started]\"]", "#checkpointBottomBar [name=\"submit[Continue]\"]" });
										C8819A33.DelayTime(2.0);
										C8819A33.WaitForSearchElement("#hcs_prog_o>#hcs_prog_i[style]", 1, 60.0);
									}
									C8819A33.DelayTime(1.0);
								}
								else
								{
									num = 0;
								}
							}
							goto IL_12e2;
						case "[name=\"login\"]":
						case "[name=\"reset_action\"]":
							if (num7 == 0 && num9 == 0)
							{
								string text7 = "";
								switch (CheckTypeWebFacebookFromUrl(C8819A33.GetURL()))
								{
								case 2:
									text7 = C8819A33.ExecuteScript("var out='';var x=document.querySelector('#login_error');if(x!=null) out=x.innerText;return out;").ToString();
									break;
								case 1:
									text7 = C8819A33.GetAttributeInnerText("#error_box");
									text7 = ((text7.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Count() > 1) ? text7.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim() : text7);
									break;
								}
								if (text7 != "")
								{
									return text7;
								}
								if (C8819A33.CheckExistElement("[href=\"/login/identify/\"]") == 1)
								{
									num = 4;
								}
								else if (C8819A33.CheckExistElement("#account_recovery_initiate_view_label") == 1)
								{
									num = 5;
								}
								else if (!Convert.ToBoolean(C8819A33.ExecuteScript("return (document.querySelector('[name=\"email\"]').value!='' && document.querySelector('[name=\"pass\"]').value!='')+''").ToString()))
								{
									if (C8819A33.ExecuteScript("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
									{
										num = 4;
									}
									else if (C8819A33.ExecuteScript("return document.querySelector('[name=\"pass\"]').value").ToString().Trim() == "")
									{
										num = 5;
									}
								}
							}
							else if (C8819A33.ExecuteScript("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
							{
								num = 0;
								goto end_IL_12eb;
							}
							goto IL_12e2;
						case "[name=\"approvals_code\"]":
							if (string_1 == "")
							{
								num = 3;
							}
							else if (num7 >= num8)
							{
								num = 6;
							}
							else
							{
								if (bool_1)
								{
									C8819A33.GotoURL(C8819A33.GetURL().Replace("www.face", "m.face"));
									for (int m = 0; m < 10; m++)
									{
										if (C8819A33.CheckExistElement("[name=\"approvals_code\"]") == 1)
										{
											break;
										}
										C8819A33.DelayTime(1.0);
									}
								}
								string text4 = Common.GetTotp(string_1.Replace(" ", "").Replace("\n", "").Trim());
								if (text4 == "")
								{
									num = 6;
								}
								else
								{
									num7++;
									C8819A33.SendKeys(2, "approvals_code", text4);
									C8819A33.DelayTime(1.0);
									C8819A33.SendEnter("[name='approvals_code']");
									C8819A33.DelayTime(1.0);
								}
							}
							goto IL_12e2;
						case "#checkpointSubmitButton":
							if (C8819A33.CheckExistElement("[name=\"checkpointU2Fauth\"]") == 1)
							{
								C8819A33.GotoURL("https://www.facebook.com/checkpoint/?next&no_fido=true");
							}
							else if (C8819A33.CheckExistElements(0.0, new List<string> { "#SupportFormRow\\\\.382907505152522", "[href=\"/help/117450615006715\"]" }) != "")
							{
								num = 2;
							}
							else
							{
								num3++;
								if (num3 >= num4)
								{
									num = 2;
								}
								else
								{
									if (C8819A33.CheckExistElement("#checkpointSubmitButton>input") == 1)
									{
										C8819A33.ExecuteJSClick("#checkpointSubmitButton>input");
									}
									else if (C8819A33.CheckExistElement("#checkpointSubmitButton>button") == 1)
									{
										if (C8819A33.CheckExistElement("[value=\"dont_save\"]") == 1 && bool_0)
										{
											C8819A33.Click(4, "[value=\"dont_save\"]");
										}
										if (C8819A33.CheckExistElement("[name=\"password_new\"]") == 1)
										{
											string text5 = Common.smethod_71();
											C8819A33.SendKeys("[name=\"password_new\"]", text5);
											C8819A33.DelayTime(1.0);
											C8819A33.SendKeys("[name=\"password_confirm\"]", text5);
											C8819A33.DelayTime(1.0);
											fMain.AABB4798.SetCellAccountRoww(C8819A33.cId, "pass", C8819A33.Row, "cPassword", text5);
										}
										C8819A33.ExecuteJSClick("#checkpointSubmitButton>button");
										C8819A33.DelayTime(2.0);
										C8819A33.WaitForSearchElement("#checkpointSubmitButton>button [role=\"progressbar\"]", 1, 30.0);
									}
									else
									{
										if (C8819A33.CheckExistElement("[name=\"password_new\"]") == 1)
										{
											string text6 = Common.smethod_71();
											C8819A33.SendKeys("[name=\"password_new\"]", text6);
											C8819A33.DelayTime(1.0);
											C8819A33.SendKeys("[name=\"password_confirm\"]", text6);
											C8819A33.DelayTime(1.0);
											fMain.AABB4798.SetCellAccountRoww(C8819A33.cId, "pass", C8819A33.Row, "cPassword", text6);
										}
										if (C8819A33.CheckExistElement("button[name=\"submit[This was me]\"]") == 1)
										{
											num3--;
											num5++;
											if (num5 <= num6)
											{
												C8819A33.Click("button[name=\"submit[This was me]\"]");
											}
											else
											{
												C8819A33.Click("button[name=\"submit[This wasn't me]\"]");
											}
										}
										else
										{
											C8819A33.ExecuteJSClick("#checkpointSubmitButton");
										}
										C8819A33.DelayTime(2.0);
										C8819A33.WaitForSearchElement("#checkpointSubmitButton[disabled]", 1, 30.0);
									}
									C8819A33.DelayTime(1.0);
								}
							}
							goto IL_12e2;
						case "#qf_skip_dialog_skip_link":
							if (C8819A33.ClickWithAction(1, "qf_skip_dialog_skip_link") == 0)
							{
								C8819A33.ExecuteScript("document.getElementById('qf_skip_dialog_skip_link').click()");
							}
							C8819A33.DelayTime(2.0);
							goto IL_12e2;
						case "[name=\"verification_method\"]":
							num = 2;
							goto IL_12e2;
						case "[name=\"n\"]":
							num = 5;
							goto IL_12e2;
						case "[action*=\"/login/device-based/update-nonce/\"]":
							C8819A33.Click("[action*=\"/login/device-based/update-nonce/\"] [type=\"submit\"]");
							goto IL_12e2;
						case "[name=\"primary_consent_button\"]":
						{
							int num10 = C8819A33.CountElementWithXpath("[name=\"primary_consent_button\"]");
							C8819A33.Click(4, "[name=\"primary_consent_button\"]", num10 - 1);
							goto IL_12e2;
						}
						default:
							if (C8819A33.CheckIsLive())
							{
								num = -2;
							}
							else if (C8819A33.CheckExistElement("[href*=\"/help/contact/571927962827151\"]") == 1)
							{
								num = 9;
							}
							else if (C8819A33.GetFbWeb() == 1 && C8819A33.GetURL().Contains(".facebook.com/privacy/consent/"))
							{
								if (C8819A33.CheckExistElement("input[role=\"switch\"]") == 1)
								{
									C8819A33.ExecuteScript("document.querySelectorAll('input[role=\"switch\"]').forEach(elm => {if (elm.checked!==true) {elm.click();}})");
								}
								C8819A33.Click("(//div[@role=\"button\"])[last()]");
							}
							else
							{
								object obj = C8819A33.ExecuteScript("async function checkCookie(){try{let a=await fetch(\"https://www.facebook.com/me\"),b=\"0|0\";if(a.ok){if(a.url.includes(\"checkpoint\"))b=\"0|1\";else if(a.url.includes(\"com/?refsrc\")||\"https://www.facebook.com/\"==a.url)b=\"0|2\";else{let d=await a.text();if(d.includes(\"/photos/change/profile_picture\"))b=\"1|1\";else{let e=d.match(/\"USER_ID\"\\:\"([0-9]{0,})\"/)[1],f=document.cookie.match(/c_user\\=([0-9]{0,})/)[1];e==f&&(b=\"1|1\")}}}return b}catch{}}var c=await checkCookie(); return c") ?? "";
								if (obj.ToString().StartsWith("0|"))
								{
									num = 2;
								}
								else if (C8819A33.CheckExistElement("[href=\"/\"]") == 1 && C8819A33.GetURL().Contains("facebook.com/privacy/consent_framework/prompt/"))
								{
									C8819A33.GotoURL("https://www.facebook.com/");
								}
								else if (smethod_28(C8819A33))
								{
									num = 8;
								}
								else if (C8819A33.GetURL().Contains("facebook.com/checkpoint/1501092823525282/") || C8819A33.GetURL().Contains("checkpoint/828281030927956"))
								{
									num = 2;
								}
								else if (C8819A33.GetURL().Contains("facebook.com/user_cookie_prompt"))
								{
									C8819A33.GotoURL("https://mobile.facebook.com/");
								}
								else if (C8819A33.GetURL().Contains("facebook.com/nt/screen/?params=%7B%22token") || C8819A33.CheckExistElements(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]") != 0 || CheckStringContainKeyword(C8819A33.GetPageSource(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395" }))
								{
									num = 2;
								}
								else if (CheckLoginSuccess(C8819A33))
								{
									num = 1;
								}
								else if (CheckTypeWebFacebookFromUrl(C8819A33.GetURL()) == 2)
								{
									if (C8819A33.GetURL().StartsWith("https://mobile.facebook.com/zero/policy/optin"))
									{
										C8819A33.DelayTime(1.0);
										C8819A33.ExecuteScript("document.querySelector('a[data-sigil=\"touchable\"]').click()");
										C8819A33.DelayTime(3.0);
										if (C8819A33.CheckExistElement("button[data-sigil=\"touchable\"]", 10.0) == 1)
										{
											C8819A33.DelayTime(1.0);
											C8819A33.ExecuteScript("document.querySelector('button[data-sigil=\"touchable\"]').click()");
											C8819A33.DelayTime(3.0);
										}
									}
									if (Convert.ToBoolean(C8819A33.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
									{
										for (int j = 0; j < 5; j++)
										{
											Common.Sleep(2.0);
											if (!Convert.ToBoolean(C8819A33.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
											{
												break;
											}
										}
										for (int k = 0; k < 5; k++)
										{
											Common.Sleep(2.0);
											if (!Convert.ToBoolean(C8819A33.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
											{
												break;
											}
										}
										if (C8819A33.CheckExistElement("[href=\"/home.php\"]") == 1)
										{
											C8819A33.Click(4, "[href=\"/home.php\"]");
										}
									}
									if (C8819A33.GetURL().Contains("facebook.com/legal_consent"))
									{
										C8819A33.ExecuteScript("document.querySelector('button').click()");
										C8819A33.DelayTime(1.0);
										C8819A33.ExecuteScript("document.querySelectorAll('button')[1].click()");
										C8819A33.DelayTime(1.0);
										C8819A33.ExecuteScript("document.querySelector('button').click()");
										C8819A33.DelayTime(1.0);
										C8819A33.ExecuteScript("document.querySelectorAll('button')[1].click()");
										C8819A33.DelayTime(1.0);
									}
									if (C8819A33.GetURL().Contains("facebook.com/si/actor_experience/actor_gateway"))
									{
										C8819A33.Click(4, "[data-sigil=\"touchable\"]");
										C8819A33.DelayTime(1.0);
									}
									if (C8819A33.CheckExistElement("button[value=\"OK\"]") == 1)
									{
										C8819A33.Click(4, "button[value=\"OK\"]");
										C8819A33.DelayTime(1.0);
									}
									if (C8819A33.CheckExistElement("[data-store-id=\"2\"]>span") == 1)
									{
										C8819A33.Click(4, "[data-store-id=\"2\"]>span");
										C8819A33.DelayTime(1.0);
									}
									if (C8819A33.CheckExistElement("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
									{
										C8819A33.Click(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
										C8819A33.DelayTime(3.0);
									}
								}
								else if (C8819A33.GetURL().StartsWith("https://www.facebook.com/legal_consent"))
								{
									for (int l = 0; l < 5; l++)
									{
										if (C8819A33.CheckExistElement("button") != 1)
										{
											break;
										}
										C8819A33.ExecuteScript("document.querySelector('button').click()");
										C8819A33.DelayTime(1.0);
									}
								}
							}
							goto IL_12e2;
						case "#identify_search_text_input":
							break;
							IL_12e2:
							if (num == 0)
							{
								continue;
							}
							goto end_IL_12eb;
						}
						C8819A33.GotoURL("https://www.facebook.com/login");
						C8819A33.DelayTime(1.0);
						int_ = 0;
						goto IL_136e;
						continue;
						end_IL_12eb:
						break;
					}
					break;
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(C8819A33, exception_, "Error Login Uid Pass");
			}
		}
		return num.ToString() ?? "";
	}

	public static string smethod_16(Chrome f336F52E_0, string string_0)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		try
		{
			string json = RequestGet(f336F52E_0, "https://graph.facebook.com/v2.11/me?fields=name,email,gender,birthday&access_token=" + string_0, "https://graph.facebook.com/");
			JObject jObject = JObject.Parse(json);
			flag = true;
			text2 = jObject["name"].ToString();
			try
			{
				text3 = jObject["gender"].ToString();
			}
			catch
			{
			}
			try
			{
				text4 = jObject["birthday"].ToString();
			}
			catch
			{
			}
			try
			{
				text6 = jObject["email"].ToString();
			}
			catch
			{
			}
		}
		catch
		{
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	public static string smethod_17(Chrome f336F52E_0)
	{
		string result = "";
		try
		{
			result = f336F52E_0.GetTokenEAABw();
		}
		catch
		{
		}
		return result;
	}

	public static int CheckLiveCookie(Chrome chrome, string FC993F34 = "https://mobile.facebook.com")
	{
		try
		{
			if (chrome.CheckIsLive())
			{
				return -2;
			}
			if (chrome.CheckExistElement("#m_login_email,#m_login_password,[name=\"login\"]") == 1)
			{
				return 0;
			}
			if (CheckCheckpoint(chrome))
			{
				return 2;
			}
			if (chrome.CheckFacebookBlocked())
			{
				return 9;
			}
			if (chrome.GetFbWeb() != chrome.GetFbWeb(FC993F34))
			{
				chrome.GotoURL(FC993F34);
			}
			if (chrome.GetFbWeb() == 2)
			{
				chrome.ExecuteJSClickFB(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
			}
			if (smethod_28(chrome))
			{
				return 8;
			}
			string text = (string)chrome.ExecuteScript("async function checkCookie(){try{let a=await fetch(\"/me\"),b=\"0|0\";if(a.ok){if(a.url.includes(\"checkpoint\"))b=\"0|1\";else if(a.url.includes(\"com/?refsrc\")||\"https://www.facebook.com/\"==a.url)b=\"0|2\";else{let d=await a.text();if(d.includes(\"/photos/change/profile_picture\"))b=\"1|1\";else{let e=d.match(/\"USER_ID\"\\:\"([0-9]{0,})\"/)[1],f=document.cookie.match(/c_user\\=([0-9]{0,})/)[1];e==f&&(b=\"1|1\")}}}return b}catch{}}var c=await checkCookie(); return c");
			if (text != null)
			{
				if (text.Equals("0|1"))
				{
					return 2;
				}
				if (text.Equals("1|1"))
				{
					return 1;
				}
			}
			string text2 = chrome.GetURL();
			if (text2.Contains("facebook.com/checkpoint/") || text2.Contains("facebook.com/nt/screen/?params=%7B%22token") || text2.Contains("facebook.com/x/checkpoint/"))
			{
				return 2;
			}
			if (chrome.GetURL().Contains("facebook.com/user_cookie_prompt"))
			{
				chrome.GotoURL("https://mobile.facebook.com/");
			}
			switch (CheckFacebookWebsite(chrome, FC993F34))
			{
			case 2:
			{
				for (int i = 0; i < 30; i++)
				{
					if (chrome.GetURL().Contains("facebook.com/si/actor_experience/actor_gateway/nt/?flow_id="))
					{
						break;
					}
					CheckStatusAccount(chrome, isSendRequest: true);
					switch (chrome.Status)
					{
					case StatusChromeAccount.ChromeClosed:
						return -2;
					case StatusChromeAccount.LoginWithUserPass:
						return 0;
					case StatusChromeAccount.Checkpoint:
						return 2;
					case StatusChromeAccount.Logined:
						return 1;
					case StatusChromeAccount.NoInternet:
						return -3;
					case StatusChromeAccount.Noveri:
						return 3;
					}
					chrome.AcceptCookie();
					if (chrome.CheckExistElement("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1)
					{
						chrome.ExecuteScript("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
						chrome.DelayTime(3.0);
						if (chrome.CheckExistElement("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1)
						{
							chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
							chrome.DelayTime(3.0);
						}
					}
					if (chrome.GetURL().Contains("facebook.com/zero/optin/write/"))
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						chrome.DelayTime(3.0);
					}
					if (chrome.GetURL().Contains("facebook.com/zero/policy/optin"))
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript("document.querySelector('a[data-sigil=\"touchable\"]').click()");
						chrome.DelayTime(3.0);
						if (chrome.CheckExistElement("button[data-sigil=\"touchable\"]", 10.0) == 1)
						{
							chrome.DelayTime(1.0);
							chrome.ExecuteScript("document.querySelector('button[data-sigil=\"touchable\"]').click()");
							chrome.DelayTime(3.0);
						}
					}
					if (Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
					{
						for (int j = 0; j < 5; j++)
						{
							Common.Sleep(2.0);
							if (!Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
							{
								break;
							}
						}
						for (int k = 0; k < 5; k++)
						{
							Common.Sleep(2.0);
							if (!Convert.ToBoolean(chrome.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
							{
								break;
							}
						}
						if (chrome.CheckExistElement("[href=\"/home.php\"]") == 1)
						{
							chrome.Click(4, "[href=\"/home.php\"]");
						}
					}
					if (chrome.GetURL().Contains("facebook.com/si/actor_experience/actor_gateway"))
					{
						chrome.Click(4, "[data-sigil=\"touchable\"]");
						chrome.DelayTime(1.0);
					}
					if (chrome.CheckExistElement("button[value=\"OK\"]") == 1)
					{
						chrome.Click(4, "button[value=\"OK\"]");
						chrome.DelayTime(1.0);
					}
					if (chrome.CheckExistElement("[data-store-id=\"2\"]>span") == 1)
					{
						chrome.Click(4, "[data-store-id=\"2\"]>span");
						chrome.DelayTime(1.0);
					}
					if (chrome.CheckExistElement("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
					{
						chrome.Click(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
						chrome.DelayTime(3.0);
					}
					if (chrome.CheckExistElement("#nux-nav-button") == 1)
					{
						bool flag = false;
						for (int l = 0; l < 5; l++)
						{
							if (flag)
							{
								break;
							}
							switch (chrome.CheckExistElements(3.0, "#qf_skip_dialog_skip_link", "#nux-nav-button"))
							{
							default:
								flag = true;
								break;
							case 2:
								chrome.Click(1, "nux-nav-button");
								chrome.DelayTime(2.0);
								break;
							case 1:
								chrome.ExecuteScript("document.querySelector('#qf_skip_dialog_skip_link').click()");
								chrome.DelayTime(1.0);
								break;
							}
						}
					}
					chrome.FindAndClick(0.0, 4, "[name=\"primary_consent_button\"]");
					chrome.DelayTime(2.0);
					if (chrome.CheckExistElement("#nux-nav-button") == 1)
					{
						chrome.Click(1, "nux-nav-button");
						if (chrome.CheckExistElement("#qf_skip_dialog_skip_link", 10.0) == 1 && chrome.ClickWithAction(1, "qf_skip_dialog_skip_link") == 0)
						{
							chrome.ExecuteScript("document.getElementById('qf_skip_dialog_skip_link').click()");
						}
					}
				}
				break;
			}
			case 1:
			{
				if (!chrome.GetURL().StartsWith("https://www.facebook.com/legal_consent"))
				{
					break;
				}
				for (int m = 0; m < 5; m++)
				{
					if (chrome.CheckExistElement("button") != 1)
					{
						break;
					}
					chrome.ExecuteScript("document.querySelector('button').click()");
					chrome.DelayTime(1.0);
				}
				break;
			}
			case 3:
				if (chrome.CheckExistElement("[name=\"accept_only_essential\"][value=\"0\"]") == 1)
				{
					chrome.Click("[name=\"accept_only_essential\"][value=\"0\"]");
				}
				break;
			}
			CheckStatusAccount(chrome, isSendRequest: true);
			switch (chrome.Status)
			{
			case StatusChromeAccount.ChromeClosed:
				return -2;
			case StatusChromeAccount.LoginWithUserPass:
				return 0;
			case StatusChromeAccount.Checkpoint:
				return 2;
			case StatusChromeAccount.Logined:
				return 1;
			case StatusChromeAccount.NoInternet:
				return -3;
			case StatusChromeAccount.Blocked:
				break;
			case StatusChromeAccount.Noveri:
				return 3;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int CheckLiveCookieWhenGiaiCP(Chrome f336F52E_0, string string_0 = "https://mobile.facebook.com")
	{
		try
		{
			if (f336F52E_0.CheckIsLive())
			{
				return -2;
			}
			if (f336F52E_0.GetURL().Contains("facebook.com/x/checkpoint/hacked_cleanup") || f336F52E_0.CheckExistElement("#checkpointButtonGetStarted") == 1)
			{
				return 1;
			}
			if (CheckTypeWebFacebookFromUrl(f336F52E_0.GetURL()) == 0)
			{
				f336F52E_0.GotoURL(string_0);
			}
			switch (CheckFacebookWebsite(f336F52E_0, string_0))
			{
			case 2:
				if (f336F52E_0.CheckExistElement("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0) == 1)
				{
					f336F52E_0.ExecuteScript("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
					f336F52E_0.DelayTime(3.0);
					if (f336F52E_0.CheckExistElement("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0) == 1)
					{
						f336F52E_0.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						f336F52E_0.DelayTime(3.0);
					}
				}
				if (f336F52E_0.GetURL().Contains("facebook.com/zero/optin/write/"))
				{
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
					f336F52E_0.DelayTime(3.0);
				}
				if (f336F52E_0.GetURL().Contains("facebook.com/zero/policy/optin"))
				{
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelector('a[data-sigil=\"touchable\"]').click()");
					f336F52E_0.DelayTime(3.0);
					if (f336F52E_0.CheckExistElement("button[data-sigil=\"touchable\"]", 10.0) == 1)
					{
						f336F52E_0.DelayTime(1.0);
						f336F52E_0.ExecuteScript("document.querySelector('button[data-sigil=\"touchable\"]').click()");
						f336F52E_0.DelayTime(3.0);
					}
				}
				if (Convert.ToBoolean(f336F52E_0.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
				{
					for (int j = 0; j < 5; j++)
					{
						Common.Sleep(2.0);
						if (!Convert.ToBoolean(f336F52E_0.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
						{
							break;
						}
					}
					for (int k = 0; k < 5; k++)
					{
						Common.Sleep(2.0);
						if (!Convert.ToBoolean(f336F52E_0.ExecuteScript("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
						{
							break;
						}
					}
					if (f336F52E_0.CheckExistElement("[href=\"/home.php\"]") == 1)
					{
						f336F52E_0.Click(4, "[href=\"/home.php\"]");
					}
				}
				if (f336F52E_0.GetURL().Contains("facebook.com/legal_consent"))
				{
					f336F52E_0.ExecuteScript("document.querySelector('button').click()");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelectorAll('button')[1].click()");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelector('button').click()");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelectorAll('button')[1].click()");
					f336F52E_0.DelayTime(1.0);
				}
				if (f336F52E_0.GetURL().Contains("facebook.com/si/actor_experience/actor_gateway"))
				{
					f336F52E_0.Click(4, "[data-sigil=\"touchable\"]");
					f336F52E_0.DelayTime(1.0);
				}
				if (f336F52E_0.CheckExistElement("button[value=\"OK\"]") == 1)
				{
					f336F52E_0.Click(4, "button[value=\"OK\"]");
					f336F52E_0.DelayTime(1.0);
				}
				if (f336F52E_0.CheckExistElement("[data-store-id=\"2\"]>span") == 1)
				{
					f336F52E_0.Click(4, "[data-store-id=\"2\"]>span");
					f336F52E_0.DelayTime(1.0);
				}
				if (f336F52E_0.CheckExistElement("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
				{
					f336F52E_0.Click(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
					f336F52E_0.DelayTime(3.0);
				}
				break;
			case 1:
			{
				if (!f336F52E_0.GetURL().Contains("facebook.com/legal_consent"))
				{
					break;
				}
				for (int i = 0; i < 5; i++)
				{
					if (f336F52E_0.CheckExistElement("button") != 1)
					{
						break;
					}
					f336F52E_0.ExecuteScript("document.querySelector('button').click()");
					f336F52E_0.DelayTime(1.0);
				}
				break;
			}
			}
			CheckStatusAccount(f336F52E_0, isSendRequest: true);
			switch (f336F52E_0.Status)
			{
			case StatusChromeAccount.ChromeClosed:
				return -2;
			case StatusChromeAccount.LoginWithUserPass:
				return 0;
			case StatusChromeAccount.Checkpoint:
				return 2;
			case StatusChromeAccount.Logined:
				return 1;
			case StatusChromeAccount.NoInternet:
				return -3;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static bool IsCheckpoint(Chrome chrome)
	{
		try
		{
			if (chrome.CheckExistElements(0.0, "#checkpointSubmitButton", "#captcha_response", "[name=\"verification_method\"]", "#checkpointBottomBar", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
			{
				return true;
			}
			if (chrome.GetURL().Contains("nt/screen/?params="))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool CheckCaptchaResponse(Chrome f336F52E_0)
	{
		try
		{
			if (f336F52E_0.CheckExistElements(0.0, "[name=\"captcha_response\"]", "#captcha_response", "[name=\"password_new\"]", "[name=\"verification_method\"]", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string RequestGet(Chrome chrome, string url, string website)
	{
		try
		{
			if (website.Split('/').Length > 2)
			{
				website = website.Replace("//", "__");
				website = website.Split('/')[0];
				website = website.Replace("__", "//");
			}
			if (!chrome.GetURL().StartsWith(website))
			{
				chrome.GotoURL(website);
				chrome.DelayTime(1.0);
				chrome.ExecuteScript("document.querySelector('body').innerHTML='LTD SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			return (string)chrome.ExecuteScript("async function RequestGet() { var output = ''; try { var response = await fetch('" + url + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
		}
		catch
		{
		}
		return "";
	}

	public static string RequestPost(Chrome f336F52E_0, string C73FA326, string F32755A3, string string_0, string string_1 = "application/x-www-form-urlencoded")
	{
		try
		{
			if (!f336F52E_0.GetURL().StartsWith(string_0))
			{
				f336F52E_0.GotoURL(string_0);
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.ExecuteScript("document.querySelector('body').innerHTML='LTD SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			f336F52E_0.DelayTime(1.0);
			F32755A3 = F32755A3.Replace("\n", "\\n").Replace("\"", "\\\"");
			return (string)f336F52E_0.ExecuteScript("async function RequestPost() { var output = ''; try { var response = await fetch('" + C73FA326 + "', { method: 'POST', body: '" + F32755A3 + "', headers: { 'Content-Type': '" + string_1 + "' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
		}
		catch
		{
		}
		return "";
	}

	public static List<string> GetListFriendsOnline(Chrome f336F52E_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = f336F52E_0.GetFbdtsgv1();
			string json = RequestPost(f336F52E_0, "https://mobile.facebook.com/buddylist.php", "data_fetch=true&send_full_data=true&fb_dtsg=" + text + "&jazoest=&lsd=r&__dyn=&__csr=&__req=a&__a=&__user=" + string_0, "https://mobile.facebook.com/").Replace("for (;;);", "");
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)jObject["payload"]["buddylist"])
			{
				list.Add(item["id"].ToString());
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static List<string> GetListPending(Chrome f336F52E_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = "/messages/?folder=other";
			do
			{
				string input = f336F52E_0.RequestGetHelper("https://mobile.facebook.com" + text).Replace("&amp;", "&");
				text = Regex.Match(input, "href=\"(/messages/\\?pageNum=.*?)\"").Groups[1].Value;
				MatchCollection matchCollection = Regex.Matches(input, "/messages/read/\\?tid=cid\\.c\\.(.*?)%");
				foreach (Match item in matchCollection)
				{
					list.Add(item.Groups[1].Value);
				}
			}
			while (text != "");
		}
		catch (Exception)
		{
		}
		list.Remove(string_0);
		return list;
	}

	public static List<string> smethod_23(Chrome C127D420, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = "/messages/?folder=pending";
			do
			{
				string input = C127D420.RequestGetHelper("https://mobile.facebook.com" + text).Replace("&amp;", "&");
				text = Regex.Match(input, "href=\"(/messages/\\?pageNum=.*?)\"").Groups[1].Value;
				MatchCollection matchCollection = Regex.Matches(input, "/messages/read/\\?tid=cid\\.c\\.(.*?)%");
				foreach (Match item in matchCollection)
				{
					list.Add(item.Groups[1].Value);
				}
			}
			while (text != "");
		}
		catch (Exception)
		{
		}
		list.Remove(string_0);
		return list;
	}

	public static string GetBirthday(Chrome f336F52E_0, string AB925839)
	{
		string result = "";
		try
		{
			if (!f336F52E_0.GetURL().Contains("https://graph.facebook.com/"))
			{
				f336F52E_0.GotoURL("https://graph.facebook.com/");
			}
			string json = (string)f336F52E_0.ExecuteScript("async function RequestGet() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me?fields=id,birthday,name&access_token=" + AB925839 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
			JObject jObject = JObject.Parse(json);
			return jObject["id"].ToString() + "|" + jObject["birthday"].ToString() + "|" + jObject["name"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> GetMyListUidMessage(Chrome f336F52E_0)
	{
		List<string> list = new List<string>();
		try
		{
			if (!f336F52E_0.GetURL().Contains("https://mbasic.facebook.com/"))
			{
				f336F52E_0.GotoURL("https://mbasic.facebook.com/");
			}
			string input = (string)f336F52E_0.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com/messages/'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			int num = 1;
			string text = "";
			string text2 = "";
			do
			{
				MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					try
					{
						text2 = matchCollection[i].Groups[1].Value.Replace("\"", "");
						text2 = WebUtility.HtmlDecode(text2);
						if (!list.Contains(text2))
						{
							list.Add(text2);
						}
					}
					catch
					{
					}
				}
				text = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
				input = (string)f336F52E_0.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com" + text + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				num++;
			}
			while (num < 5 && text != "");
		}
		catch
		{
		}
		return list;
	}

	public static List<string> GetMyListComments(Chrome AD116908, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			if (!AD116908.GetURL().Contains("https://mbasic.facebook.com/"))
			{
				AD116908.GotoURL("https://mbasic.facebook.com/");
			}
			string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
			string text = AD116908.ExecuteScript("return (document.cookie + ';').match(new RegExp('c_user=(.*?);'))[1]").ToString();
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			MatchCollection matchCollection = null;
			List<string> list2 = new List<string>();
			for (int i = 0; i < int_0; i++)
			{
				DateTime dateTime = DateTime.Now.AddMonths(2 - i);
				DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
				text2 = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
				text3 = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
				text4 = string.Format(format, text, text2, text3);
				list2.Add(text4);
			}
			for (int j = 0; j < list2.Count; j++)
			{
				text4 = list2[j];
				bool flag = false;
				do
				{
					flag = false;
					text5 = RequestGet(AD116908, text4, "https://mbasic.facebook.com/");
					text5 = WebUtility.HtmlDecode(text5);
					matchCollection = Regex.Matches(text5, "<span>(.*?)</h4>");
					for (int k = 0; k < matchCollection.Count; k++)
					{
						string value = matchCollection[k].Groups[1].Value;
						value = value.Substring(0, value.LastIndexOf('<'));
						MatchCollection matchCollection2 = Regex.Matches(value, "<(.*?)>");
						for (int l = 0; l < matchCollection2.Count; l++)
						{
							value = value.Replace(matchCollection2[l].Value, "");
						}
						if (value != "" && !list.Contains(value))
						{
							list.Add(value);
						}
					}
					if (Regex.IsMatch(text5, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\""))
					{
						text4 = "https://mbasic.facebook.com" + Regex.Match(text5, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
						flag = true;
					}
				}
				while (flag);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_25(Chrome f336F52E_0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = smethod_17(f336F52E_0);
			if (!f336F52E_0.GetURL().Contains("https://graph.facebook.com/"))
			{
				f336F52E_0.GotoURL("https://graph.facebook.com/");
			}
			string json = (string)f336F52E_0.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=id,name&access_token=" + text + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			JObject jObject = JObject.Parse(json);
			if (jObject["data"].Count() > 0)
			{
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					string text2 = jObject["data"][i]["id"].ToString();
					string text3 = jObject["data"][i]["name"].ToString();
					list.Add(text2 + "|" + text3);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	internal static void CheckStatusAccount(Chrome C798D885, bool isSendRequest)
	{
		int int_ = 0;
		smethod_27(C798D885, isSendRequest, ref int_);
	}

	internal static void smethod_27(Chrome f336F52E_0, bool D508DE1B, ref int int_0)
	{
		try
		{
			if (f336F52E_0.CheckExistElement("[name=\"email\"]") == 1 && f336F52E_0.CheckExistElement("[name=\"pass\"]") == 1)
			{
				f336F52E_0.Status = StatusChromeAccount.LoginWithUserPass;
			}
			else
			{
				if (f336F52E_0.CheckExistElement("[href=\"/\"]") == 1 || f336F52E_0.CheckFacebookBlocked())
				{
					return;
				}
				if (f336F52E_0.CheckIsLive())
				{
					f336F52E_0.Status = StatusChromeAccount.ChromeClosed;
					return;
				}
				if (f336F52E_0.GetFbWeb() == 2)
				{
					f336F52E_0.ExecuteJSClickFB(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
				}
				if (f336F52E_0.GetURL().StartsWith("https://free.facebook.com/") || f336F52E_0.CheckExistElement("[href^=\"/upsell/advanced_upsell/in_line\"]") == 1)
				{
					f336F52E_0.ExecuteJSClickFB(0, "[href^=\"/upsell/advanced_upsell/in_line\"]");
					f336F52E_0.ExecuteJSClickFB(5, "#upsell_upgrade_confirm_button");
					int_0 = 1;
				}
				string text = f336F52E_0.GetURL();
				if (text.Contains("facebook.com/error/index.php"))
				{
					f336F52E_0.GotoURL("https://www.facebook.com/notifications");
					f336F52E_0.DelayTime(2.0);
					if (f336F52E_0.Click("[role=\"complementary\"] [role=\"toolbar\"] [aria-pressed]|1"))
					{
						f336F52E_0.DelayTime(2.0);
					}
					if (f336F52E_0.Click("[role=\"complementary\"] [role=\"grid\"] [role=\"row\"] a|0"))
					{
						f336F52E_0.DelayTime(2.0);
					}
					f336F52E_0.GotoURL(text);
					f336F52E_0.DelayTime(2.0);
				}
				if (f336F52E_0.CheckExistElement("[href^=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]") == 1)
				{
					f336F52E_0.ExecuteJSClick("[href^=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]");
					f336F52E_0.ExecuteJSClickFB(5, "[action^=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button");
					int_0 = 1;
				}
				if (f336F52E_0.CheckExistElement("#nux-nav-button") == 1)
				{
					f336F52E_0.ClickWithActionAll("#nux-nav-button");
					if (f336F52E_0.CheckExistElement("#qf_skip_dialog_skip_link", 5.0) == 1)
					{
						f336F52E_0.ClickWithActionAll("#qf_skip_dialog_skip_link");
					}
					int_0 = 1;
				}
				if (f336F52E_0.CheckExistElement("[name=\"email\"]") == 1 && f336F52E_0.CheckExistElement("[name=\"pass\"]") == 1)
				{
					f336F52E_0.Status = StatusChromeAccount.LoginWithUserPass;
					return;
				}
				if (CheckLoginSuccess(f336F52E_0))
				{
					f336F52E_0.Status = StatusChromeAccount.Logined;
					return;
				}
				string text2 = "";
				if (D508DE1B)
				{
					text = f336F52E_0.DomainFacebook() + "/login";
					text2 = RequestGet(f336F52E_0, text, text);
				}
				else
				{
					text2 = f336F52E_0.GetPageSource();
				}
				if (text2 == "-2")
				{
					f336F52E_0.Status = StatusChromeAccount.ChromeClosed;
				}
				else if (Regex.IsMatch(text2, "login_form") || text2.Contains("/login/?next"))
				{
					if (f336F52E_0.CheckExistElement("[href*=\"/login/?next\"]") == 1)
					{
						f336F52E_0.Click(4, "[href*=\"/login/?next\"]");
					}
					f336F52E_0.Status = StatusChromeAccount.LoginWithUserPass;
				}
				else if (Regex.IsMatch(text2, "login_profile_form") || Regex.IsMatch(text2, "/login/device-based/validate-p") || Convert.ToBoolean(f336F52E_0.ExecuteScript("var kq=false;if(document.querySelector('#mErrorView')!=null && !document.querySelector('#mErrorView').getAttribute('style').includes('display:none')) kq=true;return kq+''")) || Regex.IsMatch(text2, "href=\"https://m.facebook.com/login.php") || Regex.IsMatch(text2, "href=\"https://mobile.facebook.com/login.php"))
				{
					f336F52E_0.Status = StatusChromeAccount.LoginWithUserPass;
				}
				else if (smethod_28(f336F52E_0))
				{
					f336F52E_0.Status = StatusChromeAccount.Noveri;
				}
				else if (CheckCheckpoint(f336F52E_0))
				{
					f336F52E_0.Status = StatusChromeAccount.Checkpoint;
				}
				else if (text2.Contains("error-information-popup-content") || text2.Contains("suggestionsSummaryList"))
				{
					f336F52E_0.Status = StatusChromeAccount.NoInternet;
				}
			}
		}
		catch
		{
		}
	}

	public static bool smethod_28(Chrome f336F52E_0)
	{
		string bF020FA = f336F52E_0.GetURL();
		List<string> list_ = new List<string> { "facebook.com/confirmemail", "facebook.com/confirmation", "facebook.com/conf/strongrec/?contact=" };
		if (CheckStringContainKeyword(bF020FA, list_))
		{
			return true;
		}
		List<string> list = new List<string> { "[name=\"c\"]" };
		if (f336F52E_0.CheckExistElements(0.0, list.ToArray()) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool CheckCheckpoint(Chrome chrome)
	{
		string currentUrl = chrome.GetURL();
		List<string> lstKerword = new List<string> { "facebook.com/checkpoint/828281030927956", "facebook.com/checkpoint/1501092823525282", "facebook.com/x/checkpoint/", "facebook.com/checkpoint/block" };
		if (CheckStringContainKeyword(currentUrl, lstKerword))
		{
			return true;
		}
		if (currentUrl.Contains("facebook.com/nt/screen/?params=") && currentUrl.Contains("checkpoint"))
		{
			return true;
		}
		string html = chrome.GetPageSource();
		List<string> list_2 = new List<string>
		{
			"verification_method", "submit[Yes]", "send_code", "/checkpoint/dyi", "facebook.com/communitystandards/", "help/121104481304395", "help/166863010078512", "help/117450615006715", "checkpoint/1501092823525282", "checkpoint/828281030927956",
			"name=\"code_1\""
		};
		if (CheckStringContainKeyword(html, list_2))
		{
			return true;
		}
		List<string> list = new List<string> { "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "[href*=\"facebook.com/communitystandards/\"]", "[name=\"code_1\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]" };
		if (chrome.CheckExistElements(0.0, list.ToArray()) > 0)
		{
			return true;
		}
		return false;
	}

	public static bool CheckLoginSuccess(Chrome chrome)
	{
		try
		{
			if (chrome.GetFbWeb() == 2)
			{
				chrome.ExecuteJSClickFB(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
			}
			string bF020FA = chrome.GetURL();
			List<string> list_ = new List<string> { "facebook.com/home.php" };
			if (CheckStringContainKeyword(bF020FA, list_))
			{
				return true;
			}
			string bF020FA2 = chrome.GetPageSource();
			List<string> list_2 = new List<string> { "/friends/", "/logout.php?button_location=settings&amp;button_name=logout" };
			if (CheckStringContainKeyword(bF020FA2, list_2))
			{
				return true;
			}
			List<string> list = new List<string> { "a[href*=\"/friends/\"]", "[action=\"/logout.php?button_location=settings&button_name=logout\"]" };
			if (chrome.CheckExistElements(0.0, list.ToArray()) > 0)
			{
				return true;
			}
			if (chrome.CheckExistElement("[name=\"email\"]") == 1 && chrome.CheckExistElement("[name=\"pass\"]") == 1)
			{
				return false;
			}
			return chrome.CheckLiveAccount();
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool CheckStringContainKeyword(string BF020FA1, List<string> list_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (Regex.IsMatch(BF020FA1, list_0[num]) || BF020FA1.Contains(list_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static List<string> BackupImageOne(Chrome CF89E500, string string_0, string string_1, string string_2, int AD12540F = 20)
	{
		List<string> list = new List<string>();
		try
		{
			if (!CF89E500.GetURL().Contains("https://graph.facebook.com/"))
			{
				CF89E500.GotoURL("https://graph.facebook.com/");
			}
			string text = (string)CF89E500.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/" + string_0 + "/photos?fields=images&limit=" + AD12540F + "&access_token=" + string_2 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			JObject jObject = JObject.Parse(text);
			int num = 0;
			if (jObject != null && text.Contains("images"))
			{
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					num = jObject["data"][i]["images"].ToList().Count - 1;
					list.Add(string_0 + "*" + string_1 + "*" + jObject["data"][i]["images"][num]["source"]?.ToString() + "|" + jObject["data"][i]["images"][num]["width"]?.ToString() + "|" + jObject["data"][i]["images"][num]["height"]);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> GetMyListUidFriend(Chrome f336F52E_0, int int_0 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			string propertyName = f336F52E_0.GetUIDFromCookies();
			string text = f336F52E_0.GetFbdtsgv1();
			if (!f336F52E_0.GetURL().Contains("https://www.facebook.com/api/graphql"))
			{
				f336F52E_0.GotoURL("https://www.facebook.com/api/graphql");
			}
			string json = (string)f336F52E_0.ExecuteScript("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[propertyName]["friends"]["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				if (int_0 != 0)
				{
					try
					{
						string string_ = jObject[propertyName]["friends"]["nodes"][i]["name"].ToString();
						if ((int_0 == 1 && Common.smethod_62(string_)) || (int_0 == 2 && !Common.smethod_62(string_)))
						{
							list.Add(jObject[propertyName]["friends"]["nodes"][i]["id"].ToString());
						}
					}
					catch
					{
					}
				}
				else
				{
					list.Add(jObject[propertyName]["friends"]["nodes"][i]["id"].ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static bool smethod_33(Chrome f336F52E_0, int C4A3C5B1 = 3)
	{
		if (f336F52E_0.CheckExistElement("[data-sigil$=\"m-overlay-layer\"] form button") == 1 && f336F52E_0.CheckExistElement("[style=\"display: none;\"]>[data-sigil$=\"m-overlay-layer\"] form button") == 1)
		{
			return false;
		}
		return f336F52E_0.ExecuteJSClickFB(C4A3C5B1, "[action*=\"facebook.com/a/friends/profile/add\"] [type=\"submit\"]", "[data-sigil$=\"m-overlay-layer\"] [value=\"OK\"]", "[data-sigil$=\"m-overlay-layer\"] form button", "[data-sigil$=\"m-error-overlay-done\"]", "[data-sigil$=\"m-overlay-layer\"]", "[data-sigil$=\"m-error-overlay-cancel\"]", "[role=\"dialog\"] [aria-label^=\"Add \"]") == 1;
	}

	public static List<string> GetListPageSuggestion2(Chrome chrome)
	{
		_ = chrome.cFa2;
		List<string> result = new List<string>();
		try
		{
			string input = RequestGet(chrome, "https://mbasic.facebook.com/pages/?viewallpywo=1", "https://mbasic.facebook.com/");
			List<string> list = new List<string>();
			MatchCollection matchCollection = Regex.Matches(input, "page_suggestion_(\\d+)\"");
			foreach (Match item in matchCollection)
			{
				list.Add(item.Groups[1].Value);
			}
			List<string> list2 = new List<string>();
			matchCollection = Regex.Matches(input, "id=(\\d+)&");
			foreach (Match item2 in matchCollection)
			{
				list2.Add(item2.Groups[1].Value);
			}
			result = list.Except(list2).ToList();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static Bitmap GetBoundingClientRectAsString(Chrome f336F52E_0, string string_0)
	{
		f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + string_0 + "')");
		f336F52E_0.DelayTime(1.0);
		string text = f336F52E_0.ExecuteScript("var img=document.querySelector('" + string_0 + "').getBoundingClientRect(); return Math.floor(img.x)+'|'+Math.floor(img.y)+'|'+Math.ceil(img.width)+'|'+Math.ceil(img.height);").ToString();
		int num = Convert.ToInt32(text.Split('|')[0]) + 10;
		int num2 = Convert.ToInt32(text.Split('|')[1]) + 30;
		int width = Convert.ToInt32(text.Split('|')[2]);
		int height = Convert.ToInt32(text.Split('|')[3]);
		Bitmap image = f336F52E_0.ScreenCapture();
		Bitmap bitmap = new Bitmap(width, height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(image, -num, -num2);
		return bitmap;
	}

	public static string GetTokenEAAAAU(Chrome f336F52E_0, string string_0, string string_1, string string_2)
	{
		string result = "";
		try
		{
			string text = f336F52E_0.GetCookieFromChrome();
			string value = Regex.Match(text + ";", "datr=(.*?);").Groups[1].Value;
			string text2 = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			string text3 = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			string text4 = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			string c0931F1E = "adid=" + text3 + "&format=json&device_id=" + text2 + "&email=" + string_0 + "&password=" + string_1 + "&generate_analytics_claim=1&community_id=&cpl=true&try_num=1&family_device_id=" + text2 + "&secure_family_device_id=" + text4 + "&credentials_type=password&fb4a_shared_phone_cpl_experiment=fb4a_shared_phone_nonce_cpl_at_risk_v3&fb4a_shared_phone_cpl_group=enable_v3_at_risk&enroll_misauth=false&generate_session_cookies=1&error_detail_type=button_with_disabled&source=login&machine_id=" + value + "&jazoest=22421&meta_inf_fbmeta=&advertiser_id=" + text3 + "&encrypted_msisdn=&currently_logged_in_userid=0&locale=vi_VN&client_country_code=VN&fb_api_req_friendly_name=authenticate&fb_api_caller_class=Fb4aAuthHandler&api_key=882a8490361da98702bf97a021ddc14d&access_token=350685531728|62f8ce9f74b12f84c123cc23437a4a32";
			string json = f336F52E_0.RequestPostHelper("https://b-graph.facebook.com/auth/login", c0931F1E);
			JObject jObject = JObject.Parse(json);
			try
			{
				if (!(jObject["error"]["error_subcode"].ToString() == "1348077") && !(jObject["error"]["error_subcode"].ToString() == "1348131"))
				{
					goto end_IL_0239;
				}
				goto end_IL_0006;
				end_IL_0239:;
			}
			catch (Exception)
			{
			}
			try
			{
				if (!(jObject["error"]["error_subcode"].ToString() == "1348162") && !(jObject["error"]["error_subcode"].ToString() == "1348199"))
				{
					goto end_IL_0295;
				}
				string text5 = jObject["error"]["error_data"]["login_first_factor"].ToString();
				string text6 = jObject["error"]["error_data"]["uid"].ToString();
				string text7 = Common.GetTotp(string_2);
				c0931F1E = "adid=" + text3 + "&format=json&device_id=" + text2 + "&email=" + string_0 + "&password=" + text7 + "&generate_analytics_claim=1&community_id=&cpl=true&try_num=2&family_device_id=" + text2 + "&secure_family_device_id=" + text4 + "&sim_serials=[]&credentials_type=two_factor&fb4a_shared_phone_cpl_experiment=fb4a_shared_phone_nonce_cpl_at_risk_v3&fb4a_shared_phone_cpl_group=enable_v3_at_risk&enroll_misauth=false&generate_session_cookies=1&error_detail_type=button_with_disabled&source=login&machine_id=" + value + "&jazoest=22327&meta_inf_fbmeta=&twofactor_code=" + text7 + "&userid=" + text6 + "&first_factor=" + text5 + "&advertiser_id=" + text3 + "&encrypted_msisdn=&currently_logged_in_userid=0&locale=vi_VN&client_country_code=VN&fb_api_req_friendly_name=authenticate&fb_api_caller_class=Fb4aAuthHandler&api_key=882a8490361da98702bf97a021ddc14d&access_token=350685531728|62f8ce9f74b12f84c123cc23437a4a32";
				json = f336F52E_0.RequestPostHelper("https://b-graph.facebook.com/auth/login", c0931F1E);
				if (!json.Contains("\"code\":401"))
				{
					jObject = JObject.Parse(json);
					goto end_IL_0295;
				}
				goto end_IL_0006;
				end_IL_0295:;
			}
			catch (Exception)
			{
			}
			result = jObject["access_token"].ToString();
			end_IL_0006:;
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_37(Chrome A6375A23, bool E90CCE06 = false)
	{
		List<string> list = new List<string>();
		try
		{
			string propertyName = A6375A23.GetUIDFromCookies();
			string text = A6375A23.GetFbdtsgv1();
			if (!A6375A23.GetURL().Contains("https://www.facebook.com/api/graphql"))
			{
				A6375A23.GotoURL("https://www.facebook.com/api/graphql");
			}
			string json = (string)A6375A23.ExecuteScript("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[propertyName]["friends"]["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				try
				{
					string text2 = jObject[propertyName]["friends"]["nodes"][i]["name"].ToString();
					if (E90CCE06)
					{
						if (Common.smethod_62(text2))
						{
							list.Add(text2);
						}
					}
					else
					{
						list.Add(text2);
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		if (list.Count == 0)
		{
			try
			{
				string text3 = A6375A23.GetTokenEAABs();
				if (!A6375A23.GetURL().Contains("https://graph.facebook.com/"))
				{
					A6375A23.GotoURL("https://graph.facebook.com/");
				}
				string json2 = (string)A6375A23.ExecuteScript("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=name&access_token=" + text3 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				JObject jObject2 = JObject.Parse(json2);
				for (int j = 0; j < jObject2["data"].Count(); j++)
				{
					try
					{
						string text4 = jObject2["data"][j]["name"].ToString();
						if (E90CCE06)
						{
							if (Common.smethod_62(text4))
							{
								list.Add(text4);
							}
						}
						else
						{
							list.Add(text4);
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		return list;
	}

	public static string smethod_38(Chrome f336F52E_0)
	{
		return "";
	}
}
