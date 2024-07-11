using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using MinsoftLib;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

internal class CheckInfoAccountv2
{
	private static object object_0 = new object();

	public static string smethod_0(string D0B9BF85, string string_0, string string_1, string string_2, string string_3 = "", int A08EE8B1 = 0)
	{
		string result = "";
		try
		{
			RequestHttp d33C2C = new RequestHttp(string_2, "", string_3, A08EE8B1);
			string text = Regex.Match(string_2 + ";", "datr=(.*?);").Groups[1].Value;
			if (text == "")
			{
				text = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			}
			string text2 = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			string text3 = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			string text4 = Common.RandomStringOrNumber(8, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(4, "0_a_A") + "-" + Common.RandomStringOrNumber(12, "0_a_A");
			string c93EF2B = "adid=" + text3 + "&format=json&device_id=" + text2 + "&email=" + D0B9BF85 + "&password=" + string_0 + "&generate_analytics_claim=1&community_id=&cpl=true&try_num=1&family_device_id=" + text2 + "&secure_family_device_id=" + text4 + "&credentials_type=password&fb4a_shared_phone_cpl_experiment=fb4a_shared_phone_nonce_cpl_at_risk_v3&fb4a_shared_phone_cpl_group=enable_v3_at_risk&enroll_misauth=false&generate_session_cookies=1&error_detail_type=button_with_disabled&source=login&machine_id=" + text + "&jazoest=22421&meta_inf_fbmeta=&advertiser_id=" + text3 + "&encrypted_msisdn=&currently_logged_in_userid=0&locale=vi_VN&client_country_code=VN&fb_api_req_friendly_name=authenticate&fb_api_caller_class=Fb4aAuthHandler&api_key=882a8490361da98702bf97a021ddc14d&access_token=350685531728|62f8ce9f74b12f84c123cc23437a4a32";
			string text5 = d33C2C.RequestPost("https://b-graph.facebook.com/auth/login", c93EF2B);
			if (text5.Contains("Invalid username or password"))
			{
				return "Invalid username or password";
			}
			JObject jObject = JObject.Parse(text5);
			try
			{
				if (!(jObject["error"]["error_subcode"].ToString() == "1348077") && !(jObject["error"]["error_subcode"].ToString() == "1348131"))
				{
					goto end_IL_02ce;
				}
				goto end_IL_0006;
				end_IL_02ce:;
			}
			catch (Exception)
			{
			}
			try
			{
				if (!(jObject["error"]["error_subcode"].ToString() == "1348162") && !(jObject["error"]["error_subcode"].ToString() == "1348199"))
				{
					goto end_IL_032a;
				}
				string text6 = jObject["error"]["error_data"]["login_first_factor"].ToString();
				string text7 = jObject["error"]["error_data"]["uid"].ToString();
				string text8 = Common.GetTotp(string_1);
				c93EF2B = "adid=" + text3 + "&format=json&device_id=" + text2 + "&email=" + D0B9BF85 + "&password=" + text8 + "&generate_analytics_claim=1&community_id=&cpl=true&try_num=2&family_device_id=" + text2 + "&secure_family_device_id=" + text4 + "&sim_serials=[]&credentials_type=two_factor&fb4a_shared_phone_cpl_experiment=fb4a_shared_phone_nonce_cpl_at_risk_v3&fb4a_shared_phone_cpl_group=enable_v3_at_risk&enroll_misauth=false&generate_session_cookies=1&error_detail_type=button_with_disabled&source=login&machine_id=" + text + "&jazoest=22327&meta_inf_fbmeta=&twofactor_code=" + text8 + "&userid=" + text7 + "&first_factor=" + text6 + "&advertiser_id=" + text3 + "&encrypted_msisdn=&currently_logged_in_userid=0&locale=vi_VN&client_country_code=VN&fb_api_req_friendly_name=authenticate&fb_api_caller_class=Fb4aAuthHandler&api_key=882a8490361da98702bf97a021ddc14d&access_token=350685531728|62f8ce9f74b12f84c123cc23437a4a32";
				text5 = d33C2C.RequestPost("https://b-graph.facebook.com/auth/login", c93EF2B);
				if (!text5.Contains("\"code\":401"))
				{
					jObject = JObject.Parse(text5);
					goto end_IL_032a;
				}
				goto end_IL_0006;
				end_IL_032a:;
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

	public static string CheckLiveCookie(string EE876A81, string string_0, string string_1, int int_0)
	{
		string result = "0|0";
		try
		{
			(string status, string info) tuple = CheckLiveDieAccount(EE876A81, "", 0);
			_ = tuple.status;
			string item = tuple.info;
			if (item == "Live")
			{
				result = "1|1";
			}
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_1(string string_0, string C437A4A2, string string_1, string string_2, int int_0)
	{
		List<string> list = new List<string>();
		try
		{
			string value = Regex.Match(string_0, "c_user=(\\d+)").Groups[1].Value;
			RequestXNet fB87CFA = new RequestXNet(string_0, string_1, string_2, int_0);
			fB87CFA.httpRequest.AddHeader("Authorization", "OAuth " + C437A4A2);
			string json = fB87CFA.RequestGet("https://graph.facebook.com/?ids=" + value + "&fields=friends{id,name}");
			JObject jObject = JObject.Parse(json);
			JToken jToken = jObject[value]["friends"];
			if (jToken["data"].Count() > 0)
			{
				for (int i = 0; i < jToken["data"].Count(); i++)
				{
					string item = jToken["data"][i]["id"].ToString();
					list.Add(item);
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static List<string> E6A2E585(string string_0, string ED34F71F, string D628CF2F, string string_1, string B51BC031, int int_0, int B21EAF0B = 20, bool AA820688 = false)
	{
		List<string> list = new List<string>();
		try
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			string[] array = string_0.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				dictionary.Add(array[i], new List<string>());
			}
			try
			{
				RequestXNet fB87CFA = new RequestXNet(ED34F71F, string_1, B51BC031, int_0);
				fB87CFA.httpRequest.AddHeader("Authorization", "OAuth " + D628CF2F);
				string aDBFD1B = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=id,name,photos.limit(" + B21EAF0B + "){images}";
				string text = fB87CFA.RequestGet(aDBFD1B);
				JObject jObject = JObject.Parse(text);
				if (jObject != null && text.Contains("images"))
				{
					string[] array2 = string_0.Split(',');
					foreach (string text2 in array2)
					{
						string text3 = jObject[text2]["name"].ToString();
						try
						{
							foreach (JToken item in (IEnumerable<JToken>)jObject[text2]["photos"]["data"])
							{
								try
								{
									int num = item["images"].ToList().Count - 1;
									dictionary[text2].Add(text2 + "*" + text3 + "*" + item["images"][num]["source"]?.ToString() + "|" + item["images"][num]["width"]?.ToString() + "|" + item["images"][num]["height"]);
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
				}
			}
			catch
			{
			}
			if (AA820688)
			{
				try
				{
					RequestXNet fB87CFA2 = new RequestXNet(ED34F71F, string_1, B51BC031, int_0);
					fB87CFA2.httpRequest.AddHeader("Authorization", "OAuth " + D628CF2F);
					string aDBFD1B2 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=name,albums.limit(3){photos.limit(10){width,height,images}}";
					string text4 = fB87CFA2.RequestGet(aDBFD1B2);
					JObject jObject2 = JObject.Parse(text4);
					if (jObject2 != null && text4.Contains("images"))
					{
						string[] array3 = string_0.Split(',');
						foreach (string text5 in array3)
						{
							string text6 = jObject2[text5]["name"].ToString();
							foreach (JToken item2 in (IEnumerable<JToken>)jObject2[text5]["albums"]["data"])
							{
								try
								{
									foreach (JToken item3 in (IEnumerable<JToken>)item2["photos"]["data"])
									{
										try
										{
											int num2 = item3["images"].ToList().Count - 1;
											if (dictionary[text5].Count >= B21EAF0B)
											{
												goto end_IL_04a3;
											}
											dictionary[text5].Add(text5 + "*" + text6 + "*" + item3["images"][num2]["source"]?.ToString() + "|" + item3["images"][num2]["width"]?.ToString() + "|" + item3["images"][num2]["height"]);
											continue;
										}
										catch (Exception)
										{
											continue;
										}
									}
								}
								catch (Exception)
								{
								}
								continue;
								end_IL_04a3:
								break;
							}
						}
					}
				}
				catch
				{
				}
			}
			foreach (KeyValuePair<string, List<string>> item4 in dictionary)
			{
				if (item4.Value.Count > 0)
				{
					list.AddRange(item4.Value);
					list.Add("");
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static Bitmap smethod_2(string string_0, bool bool_0 = false)
	{
		try
		{
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string e02AFC = "https://graph.facebook.com/" + string_0 + "/picture?height=500&access_token=6628568379%7Cc1e620fa708a1d5696fb991c1bde5662";
			byte[] array = fB87CFA.GetBytes(e02AFC);
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(array, 0, Convert.ToInt32(array.Length));
			Bitmap bitmap = new Bitmap(memoryStream, useIcm: false);
			if (bool_0)
			{
				string text = FileHelper.GetPathToCurrentFolder() + "\\avatar";
				Common.CreateFolder(text);
				bitmap.Save(text + "\\" + string_0 + ".png");
			}
			return bitmap;
		}
		catch
		{
		}
		return null;
	}

	public static string DownLoadImageByUid(string string_0, string string_1, string string_2 = "", int int_0 = 0)
	{
		try
		{
			string aDBFD1B = "https://graph.facebook.com/" + string_0 + "/picture?width=9999&access_token=6628568379|c1e620fa708a1d5696fb991c1bde5662&redirect=false";
			RequestXNet fB87CFA = new RequestXNet("", "", string_2, int_0);
			string text = fB87CFA.RequestGet(aDBFD1B);
			text = text.Trim('"');
			return DownloadImage282V2(text, string_1, string_0);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Error DownLoadImageByUid");
		}
		return "";
	}

	public static string CC211485(string string_0)
	{
		string result = "";
		try
		{
			using WebClient webClient = new WebClient();
			byte[] inArray = webClient.DownloadData(string_0);
			result = Convert.ToBase64String(inArray);
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static string DownloadImage282V2(string A1839AA3, string string_0 = "", string C093A71A = "")
	{
		string_0 = ((string_0 == "") ? (FileHelper.GetPathToCurrentFolder() + "\\photos") : string_0.Trim('\\')) + "\\";
		string text = "";
		for (int i = 0; i < 2; i++)
		{
			try
			{
				using WebClient webClient = new WebClient();
				byte[] buffer = webClient.DownloadData(A1839AA3);
				using MemoryStream stream = new MemoryStream(buffer);
				using Image image = Image.FromStream(stream);
				text = string_0 + ((C093A71A == "") ? Guid.NewGuid().ToString() : C093A71A);
				try
				{
					image.Save(text + ".png", ImageFormat.Png);
					text += ".png";
				}
				catch
				{
					image.Save(text + ".jpg", ImageFormat.Jpeg);
					text += ".jpg";
				}
			}
			catch (Exception)
			{
			}
			if (text != "")
			{
				break;
			}
			string input = new RequestXNet("", "", "", 0).RequestGet(A1839AA3);
			A1839AA3 = Regex.Match(input, "src=\"(.*?)\"").Groups[1].Value;
			if (A1839AA3 == "")
			{
				break;
			}
		}
		return text;
	}
    private static List<bool> GetPixel(Bitmap bitmap_0)
    {
        List<bool> list = new List<bool>();
        Bitmap bitmap = new Bitmap(bitmap_0, new Size(16, 16));
        for (int i = 0; i < bitmap.Height; i++)
        {
            for (int j = 0; j < bitmap.Width; j++)
            {
                list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
            }
        }
        return list;
    }

    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckLiveWall(byte[] byte_0);

	public static string CheckLiveWall(string uid)
	{
        //string text = Common.GetListHoEN(CheckLiveWall(Common.B2B3DBBA(cookies)));
        //return text + "|";
        //return MinsoftLib.CheckInfoAccountv2.CheckLiveWall(string_0);
        RequestXNet gClass = new RequestXNet("", SetupFolder.GetUseragentIphone(), "", 0);
        string text = "";
        try
        {
            text = gClass.RequestGet("https://graph.facebook.com/" + uid + "/picture?redirect=false");
            if (!string.IsNullOrEmpty(text))
            {
                if (text.Contains("height") && text.Contains("width"))
                {
                    return "1|";
                }
                return "0|";
            }
        }
        catch (Exception)
        {
        }
        return "2|";
    }

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckAvatar(byte[] byte_0, byte[] byte_1, byte[] DD03CDBD);

	public static string CheckAvatar(string uid, string string_1 = "", int F01976B9 = 0)
	{
        //byte[] byte_ = Common.B2B3DBBA(cookies);
        //byte[] byte_2 = Common.B2B3DBBA(proxy);
        //byte[] dD03CDBD = Common.B2B3DBBA(F01976B9.ToString());
        //return Common.CheckAvatar(CheckAvatar(byte_, byte_2, dD03CDBD));
        //return MinsoftLib.CheckInfoAccountv2.CheckAvatar(string_0, string_1, F01976B9);
        int num = 0;
        try
        {
            if (string_1 != "")
            {
                RequestXNet requestXnet = new RequestXNet("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36", "", 0);
                string text = requestXnet.RequestGet("https://graph.facebook.com/" + uid + "/picture?width=73&redirect=false&access_token=" + string_1);
                if (text.Contains(".gif") || text.Contains("143086968_2856368904622192_1959732218791162458") || text.Contains("84628273_176159830277856_972693363922829312_n"))
                {
                    return "0";
                }
                return "1";
            }
            List<bool> first = smethod_15(Base.jsonAvatar.F1845086());
            List<bool> second = smethod_15(SaveImageAvatar(uid));
            double num2 = first.Zip(second, (bool bool_0, bool bool_1) => bool_0 == bool_1).Count((bool bool_0) => bool_0) / 256;
            if (num2 == 0.0)
            {
                return "1";
            }
            return "0";
        }
        catch
        {
            return "2";
        }
    }
    public static Bitmap SaveImageAvatar(string string_0, bool bool_0 = false)
    {
        try
        {
            RequestXNet requestXnet = new RequestXNet("", "", "", 0);
            string string_ = "https://graph.facebook.com/" + string_0 + "/picture?height=500&access_token=6628568379%7Cc1e620fa708a1d5696fb991c1bde5662";
            byte[] array = requestXnet.GetBytes(string_);
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(array, 0, Convert.ToInt32(array.Length));
            Bitmap bitmap = new Bitmap(memoryStream, useIcm: false);
            if (bool_0)
            {
                string text = FileHelper.GetPathToCurrentFolder() + "\\avatar";
                Common.CreateFolder(text);
                bitmap.Save(text + "\\" + string_0 + ".png");
            }
            return bitmap;
        }
        catch
        {
        }
        return null;
    }

    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetName(byte[] byte_0, byte[] byte_1, byte[] C412650C);

	public static string GetName(string uid, string CF1AC1BB = "", int int_0 = 0)
	{
        //byte[] byte_ = Common.B2B3DBBA(cookies);
        //byte[] byte_2 = Common.B2B3DBBA(CF1AC1BB);
        //byte[] c412650C = Common.B2B3DBBA(num.ToString());
        //return Common.GetListHoEN(GetName(byte_, byte_2, c412650C));
        //return MinsoftLib.CheckInfoAccountv2.GetName(string_0, CF1AC1BB, int_0);
        try
        {
            JObject jObject = JObject.Parse(new RequestHttp("", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_2 like Mac OS X) AppleWebKit/603.2.4 (KHTML, like Gecko) Mobile/14F89").RequestPost("https://www.facebook.com/api/graphql", "q=node(" + uid + "){name}"));
            if (string.IsNullOrEmpty(jObject[uid].ToString()))
            {
                return "";
            }
            return jObject[uid]["name"].ToString();
        }
        catch
        {
        }
        return "";
    }

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckInfoUid(byte[] byte_0, byte[] byte_1, byte[] C0A334B4);

	public static string CheckInfoUid_Old(string uid, string proxy = "", int typeProxy = 0)
	{
        //byte[] byte_ = Common.B2B3DBBA(cookies);
        //byte[] byte_2 = Common.B2B3DBBA(proxy);
        //byte[] c0A334B = Common.B2B3DBBA(num.ToString());
        //string text = Common.GetListHoEN(CheckInfoUid_Old(byte_, byte_2, c0A334B));
        //return ((text == "||") ? "0" : "1") + "|" + text;

        RequestHttp gclass = new RequestHttp("", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_2 like Mac OS X) AppleWebKit/603.2.4 (KHTML, like Gecko) Mobile/14F89", proxy, typeProxy);
        try
        {
            JObject jobject = JObject.Parse(gclass.RequestPost("https://www.facebook.com/api/graphql", "q=node(" + uid + "){name}"));
            if (string.IsNullOrEmpty(jobject[uid].ToString()))
            {
                return "0|";
            }
            string text = jobject[uid]["name"].ToString();
            jobject = JObject.Parse(gclass.RequestPost("https://www.facebook.com/api/graphql", "q=node(" + uid + "){friends{count}}"));
            if (string.IsNullOrEmpty(jobject[uid].ToString()))
            {
                return "0|";
            }
            string text2 = jobject[uid]["friends"]["count"].ToString();
            jobject = JObject.Parse(gclass.RequestPost("https://www.facebook.com/api/graphql", "q=node(" + uid + "){created_time}"));
            if (string.IsNullOrEmpty(jobject[uid].ToString()))
            {
                return "0|";
            }
            //string text3 = jobject[uid]["created_time"].ToString();
            string text3 = Common.ConvertTimeStampToDateTime(Convert.ToDouble(jobject[uid]["created_time"].ToString())).ToString();
            return string.Concat(new string[] { "1|", text, "|", text2, "|", text3 });
        }
        catch (Exception)
        {
        }
        return "2|";
    }
	public static string CheckInfoUid(string cookies, string token, string proxy = "", int typeProxy = 0)
	{
        //return MinsoftLib.CheckInfoAccountv2.CheckInfoUid(cookies, token, proxy, typeProxy);
        try
        {
            RequestXNet requestXNet = new RequestXNet(cookies, SetupFolder.GetUseragentIphone(), proxy, typeProxy);
            string json = requestXNet.RequestGet("https://graph.facebook.com/v18.0/me" + "?fields=name,birthday,email,gender,hometown,location,relationship_status,friends.limit(0)&access_token=" + token);
            JObject jObject = JObject.Parse(json);
            string name = "";
            string birthday = "";
            string email = "";
            string gender = "";
            string hometown = "";
            string location = "";
            string relationship = "";
            string friends = "";
            try { name = jObject["name"]!.ToString(); } catch { }
            try { birthday = jObject["birthday"]!.ToString(); } catch { }
            try { email = jObject["email"]!.ToString(); } catch { }
            try { gender = jObject["gender"]!.ToString(); } catch { }
            try { hometown = jObject["hometown"]!["name"]!.ToString(); } catch { hometown = "x"; }
            try { location = jObject["location"]!["name"]!.ToString(); } catch { location = "x"; }
            try { relationship = jObject["relationship_status"]!.ToString(); if (relationship.Contains("Độc thân")) { relationship = "Yes"; } else { relationship = "No"; } } catch { relationship = "No"; }
            try { friends = jObject["friends"]!["summary"]!["total_count"]!.ToString(); } catch { }


            return "1|" + name + "|" + birthday + "|" + email + "|" + gender + "|" + hometown + "|" + location + "|" + relationship + "|" + friends;
        }
        catch
        {
            return "";
        }
    }
    public static string CheckCreateDatetime(string cookies, string token, string proxy = "", int typeProxy = 0)
    {
        //return MinsoftLib.CheckInfoAccountv2.CheckCreateDatetime(cookies, token, proxy, typeProxy);
        try
        {
            RequestXNet requestXNet = new RequestXNet(cookies, SetupFolder.GetUseragentIphone(), proxy, typeProxy);
            string json = requestXNet.RequestGet("https://graph.facebook.com/v18.0/me/adaccounts" + "?fields=account_id,created_time&access_token=" + token);
            JObject jObject = JObject.Parse(json);
            string datetime = "";
            try { datetime = jObject["data"][0]["created_time"].ToString(); } catch { }


            return "1|" + datetime;
        }
        catch
        {
            return "";
        }
    }
    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckToken(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	public static bool CheckToken(string cookies, string token, string userAgent, string proxy, int typeProxy = 0)
    {
        //string text = Common.GetListHoEN(CheckToken(Common.B2B3DBBA(cookies), Common.B2B3DBBA(F4B9183E), Common.B2B3DBBA(proxy), Common.B2B3DBBA(userAgenr), Common.B2B3DBBA(F4A95EB7.ToString())));
        //if (text == "1")
        //{
        //	return true;
        //}
        //return false;
        //return MinsoftLib.CheckInfoAccountv2.CheckToken(cookies, token, userAgenr, proxy, typeProxy);
        bool result = false;
        try
        {
            RequestHttp gClass = new RequestHttp(cookies, token, userAgent, typeProxy);
            gClass.RequestGet("https://graph.facebook.com/me?access_token=" + token);
            result = true;
        }
        catch
        {
        }
        return result;
    }

	public static string GetTokenEAABapi(string cookies, string userAgent, string proxy, int num = 0)
	{
		string text = "";
		try
		{
			RequestXNet fB87CFA = new RequestXNet(cookies, "", proxy, num);
			fB87CFA.httpRequest.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			fB87CFA.httpRequest.AddHeader("accept-language", "en-US,en;q=0.9");
			fB87CFA.httpRequest.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
			fB87CFA.httpRequest.AddHeader("sec-ch-ua-mobile", "?0");
			fB87CFA.httpRequest.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			fB87CFA.httpRequest.AddHeader("sec-fetch-dest", "document");
			fB87CFA.httpRequest.AddHeader("sec-fetch-mode", "navigate");
			fB87CFA.httpRequest.AddHeader("sec-fetch-site", "none");
			fB87CFA.httpRequest.AddHeader("sec-fetch-user", "?1");
			fB87CFA.httpRequest.AddHeader("upgrade-insecure-requests", "1");
			fB87CFA.httpRequest.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
			string input = fB87CFA.RequestGet("https://www.facebook.com/adsmanager/manage/campaigns?act=");
			text = Regex.Match(input, "EAAB(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
		}
		catch
		{
			if (!CheckLiveCookie(cookies, userAgent, proxy, num).StartsWith("1|"))
			{
				return "-1";
			}
		}
		if (text == "" && !CheckLiveCookie(cookies, userAgent, proxy, num).StartsWith("1|"))
		{
			return "-1";
		}
		return text;
	}

	public static string GetTokenEAAGapi(string cookies, string userAgent, string proxy, int num)
	{
		string text = "";
		try
		{
            HttpRequest.RequestHTTP requestHTTP = new HttpRequest.RequestHTTP();
            requestHTTP.SetSSL(SecurityProtocolType.Tls12);
            requestHTTP.SetKeepAlive(k: true);
            requestHTTP.SetDefaultHeaders(new string[3]
            {
                "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
                "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
                "cookie: " + cookies
            });
            string input = requestHTTP.Request("GET", "https://business.facebook.com/business_locations/");
            return Regex.Match(input, "EAAG(.*?)\"").Value.Replace("\"", "");
        }
		catch
		{
			if (!CheckLiveCookie(cookies, userAgent, proxy, num).StartsWith("1|"))
			{
				return "-1";
			}
		}
		if (text == "" && !CheckLiveCookie(cookies, userAgent, proxy, num).StartsWith("1|"))
		{
			return "-1";
		}
		return text;
	}

	public static string CheckCheckpoint(string FC230E3C)
	{
		string result = "";
		int num = 0;
		switch (FC230E3C)
		{
		case "id_upload":
			result = "Up a\u0309nh";
			break;
		case "2":
			result = ((num != 0) ? "Birthday" : "Ngày sinh");
			break;
		case "3":
			result = ((num != 0) ? "Image" : "Ảnh");
			break;
		case "20":
			result = ((num != 0) ? "Message" : "Tin nhắn");
			break;
		case "14":
			result = ((num != 0) ? "Device" : "Thiết bị");
			break;
		case "4":
		case "34":
			result = "Otp phone";
			break;
		case "35":
			result = "Login google";
			break;
		case "26":
			result = ((num != 0) ? "Friend" : "Nhơ\u0300 bạn bè");
			break;
		case "37":
			result = "Otp mail";
			break;
		case "18":
			result = ((num != 0) ? "comment" : "Bình luận");
			break;
		case "vhh":
			result = ((num != 0) ? "disable" : "Vô hiệu hóa");
			break;
		case "72h":
			result = ((num != 0) ? "72 hours" : "72h");
			break;
		case "2fa":
			result = "Co\u0301 2fa";
			break;
		default:
			File.AppendAllText("data\\dangcp.txt", FC230E3C);
			break;
		}
		return result;
	}

	public static string smethod_12(string DD2F9405, string CD0B280B, string CA3D63BE, string E085F204, int B5877A2B)
	{
		string text = "";
		try
		{
			string e5B = "email=" + WebUtility.UrlEncode(DD2F9405) + "&pass=" + WebUtility.UrlEncode(CD0B280B);
			RequestXNet fB87CFA = new RequestXNet("", CA3D63BE, E085F204, B5877A2B);
			string text2 = fB87CFA.RequestPost("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", e5B).ToString();
			if (text2.Contains("id=\"checkpointSubmitButton\""))
			{
				if (text2.Contains("id=\"approvals_code\""))
				{
					text = "5|";
				}
				else
				{
					text = "2|";
					fB87CFA = new RequestXNet("", CA3D63BE, E085F204, B5877A2B);
					fB87CFA.RequestGet("https://www.facebook.com").ToString();
					text2 = fB87CFA.RequestPost("https://www.facebook.com/login/device-based/regular/login/?login_attempt=1&lwv=100", e5B).ToString();
					string value = Regex.Match(text2, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
					string value2 = Regex.Match(text2, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
					string value3 = Regex.Match(text2, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
					string value4 = Regex.Match(text2, "\"__spin_r\":(.*?),").Groups[1].Value;
					string value5 = Regex.Match(text2, "\"__spin_t\":(.*?),").Groups[1].Value;
					string e5B2 = "jazoest=" + value2 + "&fb_dtsg=" + value + "&nh=" + value3 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=7xe6Fo4OQ1PyUhxOnFwn84a2i5U4e1Fx-ewSwMxW0DUeUhw5cx60Vo1upE4W0OE2WxO0SobEa87i0n2US1vw4Ugao881FU3rw&__csr=&__req=5&__beoa=0&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + value4 + "&__s=op5tkm%3A2d4a9m%3A37z92b&__hsi=6789153697588537525-0&__spin_r=" + value4 + "&__spin_b=trunk&__spin_t=" + value5;
					text2 = fB87CFA.RequestPost("https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", e5B2);
					text2 = fB87CFA.RequestGet("https://www.facebook.com/checkpoint/?next");
					MatchCollection matchCollection = Regex.Matches(text2, "verification_method\" value=\"(.*?)\"");
					if (matchCollection.Count > 0)
					{
						for (int i = 0; i < matchCollection.Count; i++)
						{
							text = text + CheckCheckpoint(matchCollection[i].Groups[1].Value) + "-";
						}
						text = text.TrimEnd('-');
					}
					else if (text2.Contains("/checkpoint/dyi/?referrer=disabled_checkpoint"))
					{
						text += CheckCheckpoint("vhh");
					}
					else if (text2.Contains("captcha-recaptcha"))
					{
						text += CheckCheckpoint("72h");
					}
					else if (text2.Contains("name=\"submit[Log Out]\"") || text2.Contains("name=\"submit[__placeholder__]\""))
					{
						text += "không thê\u0309 xmdt";
					}
					else if (text2.Contains("name=\"submit[Continue]\""))
					{
						text += "Thiê\u0301t bi\u0323";
					}
				}
			}
			else if (text2.Contains("login_error"))
			{
				text = ((!text2.Contains("m_login_email")) ? "0|" : "3|");
			}
			else if (text2.Contains("action_set_contact_point"))
			{
				text = "2|" + CheckCheckpoint("34");
			}
			else
			{
				string text3 = fB87CFA.GetCookie();
				text = ((!CheckLiveCookie(text3, CA3D63BE, E085F204, B5877A2B).StartsWith("1|")) ? "2|" : (text + "1|" + text3));
			}
		}
		catch
		{
			text = "0|";
		}
		return text;
	}

	public static string D7A5B03D(string DB9C412E, string string_0, string BD1CF89A, string string_1, string string_2, int int_0)
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
			RequestXNet fB87CFA = new RequestXNet(DB9C412E, string_1, string_2, int_0);
			if (BD1CF89A == "")
			{
				BD1CF89A = "me";
			}
			string json = fB87CFA.RequestGet("https://graph.facebook.com/v2.11/" + BD1CF89A + "?fields=name,email,gender,birthday,friends.limit(0)&access_token=" + string_0);
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
			try
			{
				text7 = jObject["friends"]["summary"]["total_count"].ToString();
			}
			catch
			{
			}
		}
		catch
		{
			if (!CheckToken(DB9C412E, string_0, "", ""))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	public static string GetInfoAccountFromUidUsingCookie(string B1B42DA9, string E2A4F89F, string DE083D05, int int_0)
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
		string text9 = "";
		string text10 = "";
		try
		{
			string value = Regex.Match(B1B42DA9, "c_user=(\\d+)").Groups[1].Value;
			RequestXNet fB87CFA = new RequestXNet(B1B42DA9, E2A4F89F, DE083D05, int_0);
			string aDBFD1B = "https://business.facebook.com/business_locations/";
			string input = fB87CFA.RequestGet(aDBFD1B);
			string value2 = Regex.Match(input, "dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
			text9 = Regex.Match(input, "EAAA(.*?)\"").Value.TrimEnd('"', '\\');
			text2 = JObject.Parse("{" + Regex.Match(input, "\"NAME\":\"(.*?)\"").Value + "}")["NAME"].ToString();
			text2 = WebUtility.HtmlDecode(text2);
			string text11 = Common.Base64Decode("LS0tLS0tV2ViS2l0Rm9ybUJvdW5kYXJ5MnlnMEV6RHBTWk9DWGdCUgpDb250ZW50LURpc3Bvc2l0aW9uOiBmb3JtLWRhdGE7IG5hbWU9ImZiX2R0c2ciCgp7e2ZiX2R0c2d9fQotLS0tLS1XZWJLaXRGb3JtQm91bmRhcnkyeWcwRXpEcFNaT0NYZ0JSCkNvbnRlbnQtRGlzcG9zaXRpb246IGZvcm0tZGF0YTsgbmFtZT0icSIKCm5vZGUoe3t1aWR9fSl7ZnJpZW5kc3tjb3VudH0sc3Vic2NyaWJlcnN7Y291bnR9LGdyb3VwcyxjcmVhdGVkX3RpbWV9Ci0tLS0tLVdlYktpdEZvcm1Cb3VuZGFyeTJ5ZzBFekRwU1pPQ1hnQlItLQ==");
			text11 = text11.Replace("{{fb_dtsg}}", value2);
			text11 = text11.Replace("{{uid}}", value);
			input = fB87CFA.RequestPost("https://www.facebook.com/api/graphql/", text11, "multipart/form-data; boundary=----WebKitFormBoundary2yg0EzDpSZOCXgBR");
			JObject jObject = JObject.Parse(input);
			text7 = jObject[value]["friends"]["count"].ToString();
			text8 = jObject[value]["groups"]["count"].ToString();
			text10 = jObject[value]["created_time"].ToString();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
		}
		catch
		{
			if (!CheckLiveCookie(B1B42DA9, E2A4F89F, DE083D05, int_0).Contains("1|"))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	public static string BB09B49F(string A7AEAD9F, string string_0)
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
		string text9 = "";
		string text10 = "";
		try
		{
			string text11 = "c_user=" + Regex.Match(string_0 + ";", "c_user=(\\d+)").Groups[1].Value + "; xs=xs=" + Regex.Match(string_0 + ";", "xs=(.*?);").Groups[1].Value + ";";
			RequestXNet fB87CFA = new RequestXNet(text11 + " useragent=TW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzc0LjAuMjMwMi42MSBTYWZhcmkvNTM3LjM2", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0", "", 0);
			string string_ = "https://www.facebook.com/api/graphql";
			string e5B = "q=user(" + A7AEAD9F + ")%7Bfriends%7Bcount%7D%2Cgroups%7Bcount%7D%2Cid%2Cname%2Cgender%2Cbirthday%2Cemail_addresses%2Cusername%7D";
			string json = fB87CFA.RequestPost(string_, e5B);
			JObject jObject = JObject.Parse(json);
			text7 = jObject[A7AEAD9F]["friends"]["count"].ToString();
			text8 = jObject[A7AEAD9F]["groups"]["count"].ToString();
			text2 = jObject[A7AEAD9F]["name"].ToString();
			text4 = ((jObject[A7AEAD9F]["birthday"] != null) ? jObject[A7AEAD9F]["birthday"].ToString() : "");
			text3 = jObject[A7AEAD9F]["gender"].ToString().ToLower();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
			flag = true;
		}
		catch
		{
			if (!CheckLiveCookie(string_0, "", "", 0).StartsWith("1|"))
			{
				return "-1";
			}
			flag = false;
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	internal static (string status, string info) CheckLiveDieAccount(string A1196394, string string_0, int int_0)
	{
		string item = "";
		string item2 = "";
		try
		{
			RequestXNet request = new RequestXNet(A1196394, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", string_0, int_0);
			string text = "";
			try
			{
				text = request.RequestGet("https://d.facebook.com/");
			}
			catch (Exception)
			{
				try
				{
					text = request.RequestGet("https://mobile.facebook.com/");
				}
				catch (Exception)
				{
					text = request.httpRequest.Response.ToString();
				}
			}
			string text2 = request.GetAddAbsolute();
			if (text2.Contains("checkpoint/disabled"))
			{
				item = "Vô hiệu hóa";
				item2 = "Checkpoint: vhh";
			}
			else if (text2.Contains("828281030927956"))
			{
				string text3 = "956";
				if (text.Contains("/x/checkpoint/828281030927956/stepper/") || text.Contains("BJIhXF-EEq9.png"))
				{
					text3 += "-Bắt đầu";
				}
				else if (text.Contains("KGOvhWyM65Y.png") || text.Contains("CCnQRnuNDBB.png") || text.Contains("FpkwdkKVsK1.png") || text.Contains("/help/203305893040179") || text.Contains("/images/checkpoint/epsilon/comet/limbo-light.png"))
				{
					text3 += "-Tìm hiểu thêm";
				}
				item = "Checkpoint: " + text3;
				item2 = "Checkpoint: " + text3;
			}
			else if (text2.Contains("1501092823525282"))
			{
				switch (Common.smethod_68(text, new List<string>
				{
					"name=\"action_proceed\"", "id=\"captcha\"", "name=\"code\"", "name=\"contact_point\"", "id=\"mobile_image_data\"", "name=\"contact_point_index\"", "id=\"m_login_email\"", "name=\"action_set_contact_point\"", "/help/contact/571927962827151", "qV0ToI14MZv.png",
					"tGIsE6jdnU6.png", "bfCKqoUg0E4.png", "CdZCxLZ7L5L.png" //Update231207
                }))
				{
				case "name=\"contact_point\"":
					item = ((!text.Contains("email") || text.Contains("name=\"country_code\"")) ? ("Phone-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")) : ("Email-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
					break;
				case "id=\"mobile_image_data\"":
					item = "Image-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
					break;
				case "name=\"contact_point_index\"":
					item = ((!text.Contains("name=\"action_use_different_phone\"")) ? ("Phone Old-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")) : ("Phone-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
					break;
				case "name=\"code\"":
					item = "Phone-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
					break;
				case "id=\"captcha\"":
					item = "Captcha-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
					break;
				case "qV0ToI14MZv.png":
				case "tGIsE6jdnU6.png":
					item = "Đợi xét duyệt (" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ")";
					break;
				case "/help/contact/571927962827151":
					item = "Spam-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
					break;
				}
				item2 = "Checkpoint: 282";
			}
			else if (text2.Contains("facebook.com/gettingstarted") || (text.Contains("href=\"/menu/bookmarks/") && text.Contains("id=\"mbasic_logout_button\"")) || (text.Contains("id=\"MComposer\"") && text.Contains("id=\"MBackNavBar\"")))
			{
				item2 = "Live";
				item = "Tài khoản live";
			}
			else
			{
				item = ((!text.Contains("facebook.com/login.php") && !text.Contains("name=\"login\"")) ? ((text.Contains("confirmation") && !text.Contains("preconfirmation")) ? "Novery Live" : (text.Contains("/login/device-based/validate-pin/") ? "Cookie bị đăng xuất" : ((!text.Contains("/help/117450615006715") && !text.Contains("eid=147943945047188")) ? "Dạng Checkpoint khác" : "Checkpoint: cp login"))) : "No login");
			}
		}
		catch (Exception)
		{
			item = "Không check được";
		}
		return (item, item2);
	}
    private static List<bool> smethod_15(Bitmap bitmap_0)
    {
        List<bool> list = new List<bool>();
        Bitmap bitmap = new Bitmap(bitmap_0, new Size(16, 16));
        for (int i = 0; i < bitmap.Height; i++)
        {
            for (int j = 0; j < bitmap.Width; j++)
            {
                list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
            }
        }
        return list;
    }
    internal static (string status, string info, string newPass) smethod_15(EF086887 ef086887_0, string B0A4DABF, string string_0, string A216F1AE, string string_1)
	{
		string item = "";
		string item2 = "";
		string text = "";
		bool flag = false;
		int num = 0;
		try
		{
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			int num2 = 0;
			int num3 = 3;
			string text7 = "";
			bool flag2 = true;
			string text8 = ef086887_0.method_0("https://mbasic.facebook.com");
			int tickCount = Environment.TickCount;
			while (true)
			{
				text4 = Regex.Match(text8, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				text5 = Regex.Match(text8, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
				text6 = Regex.Match(text8, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
				string text9 = Common.smethod_68(text8, new List<string>
				{
					"/x/checkpoint/828281030927956/stepper/", "/x/checkpoint/828281030927956/anti_scripting/", "/x/checkpoint/828281030927956/cp/intro/", "/x/checkpoint/828281030927956/change_password/", "/x/checkpoint/828281030927956/cp/selection/", "/x/checkpoint/828281030927956/outro/", "/x/checkpoint/hacked_cleanup/", "/epsilon/select_challenge/async/", "/epsilon/sc/async/select/", "/epsilon/sc/async/verify/",
					"/epsilon/sc/async/bc/", "/epsilon/sc/async/change_password/", "/checkpoint/block/", "id=\"m_login_email\"", "/help/contact/571927962827151"
				});
				switch (text9)
				{
				case "/epsilon/sc/async/bc/":
				{
					num++;
					string text14 = "";
					string text15 = "";
					string text16 = "";
					if (num == 1)
					{
						text14 = string_1.Split('/')[1];
						text15 = string_1.Split('/')[0];
						text16 = string_1.Split('/')[2];
					}
					else
					{
						if (num != 2)
						{
							item = "Checkpoint ngày sinh (Sai ngày sinh)";
							break;
						}
						text14 = string_1.Split('/')[0];
						text15 = string_1.Split('/')[1];
						text16 = string_1.Split('/')[2];
					}
					if (text14.Length == 1)
					{
						text14 = "0" + text14;
					}
					if (text15.Length == 1)
					{
						text15 = "0" + text15;
					}
					text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
					text2 = text2.Replace("&amp;", "&");
					text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&day=" + text14 + "&month=" + text15 + "&year=" + text16;
					text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, text3);
					goto IL_0b06;
				}
				case "/checkpoint/block/":
					text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
					text2 = text2.Replace("&amp;", "&");
					if (text8.Contains("password_new"))
					{
						if (flag2)
						{
							flag2 = false;
							text8 = ef086887_0.method_0("https://mbasic.facebook.com");
							goto IL_0b06;
						}
						text = Common.smethod_71();
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&password_new=" + text + "&submit[Next]=Ti%E1%BA%BFp&nh=" + text6;
					}
					else if (text8.Contains("submit[Yes]"))
					{
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Yes]=C%C3%B3&nh=" + text6;
					}
					else if (text8.Contains("submit[Get Started]"))
					{
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Get Started]=Get+Started&nh=" + text6;
					}
					else if (text8.Contains("submit[Unlike]"))
					{
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Unlike]=Unlike&nh=" + text6;
					}
					else if (text8.Contains("submit[Delete]"))
					{
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Delete]=Delete&nh=" + text6;
					}
					else if (text8.Contains("submit[Done]"))
					{
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Done]=Done&nh=" + text6;
					}
					else if (text8.Contains("submit[Continue]"))
					{
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Continue]=Continue&nh=" + text6;
					}
					else
					{
						if (!text8.Contains("submit[Okay]"))
						{
							if (text8.Contains("submit[Log Out]"))
							{
								item = "Chưa thể xác minh";
								break;
							}
							smethod_16(text8, B0A4DABF);
							item = "Unlock 956 Fail (Đã có lỗi xảy ra, vui lòng thử lại sau)";
							break;
						}
						text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&submit[Okay]=OK&nh=" + text6;
					}
					text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, text3);
					goto IL_0b06;
				case "/epsilon/select_challenge/async/":
				{
					List<string> list = new List<string>();
					MatchCollection matchCollection = Regex.Matches(text8, "type=\"radio\".*?value=\"(.*?)\".*?name=\"challenge\"");
					foreach (Match item3 in matchCollection)
					{
						list.Add(item3.Groups[1].Value);
					}
					string text12 = "";
					if (list.Contains("email_captcha") && string_0 != "")
					{
						text12 = "email_captcha";
					}
					if (list.Contains("birthday_captcha") && string_1.Split('/').Length >= 3)
					{
						text12 = "birthday_captcha";
					}
					if (!(text12 == ""))
					{
						text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
						text2 = text2.Replace("&amp;", "&");
						text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&challenge=" + text12);
						goto IL_0b06;
					}
					string text13 = "";
					if (list.Contains("email_captcha"))
					{
						text13 += "-Otp mail";
					}
					if (list.Contains("text_message_captcha"))
					{
						text13 += "-Phone";
					}
					if (list.Contains("id_captcha"))
					{
						text13 += "-Xmdt";
					}
					if (text13 != "")
					{
						text13 = text13.Substring(1);
						item2 = (item = "Checkpoint: 956 (" + text13 + ")");
					}
					else
					{
						item2 = (item = "Checkpoint: 956 (" + string.Join(",", list) + ")");
					}
					break;
				}
				case "/epsilon/sc/async/change_password/":
					text = Common.smethod_71();
					text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
					text2 = text2.Replace("&amp;", "&");
					text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&pw=" + text);
					goto IL_0b06;
				case "/x/checkpoint/828281030927956/cp/selection/":
				case "/x/checkpoint/828281030927956/anti_scripting/":
				case "/x/checkpoint/828281030927956/change_password/":
				case "/x/checkpoint/828281030927956/stepper/":
				case "/x/checkpoint/828281030927956/cp/intro/":
					text2 = Regex.Match(text8, "href=\"(" + text9 + ".*?)\"").Groups[1].Value;
					if (text2 == "")
					{
						text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
					}
					text2 = text2.Replace("&amp;", "&");
					text8 = ef086887_0.method_0("https://mbasic.facebook.com" + text2);
					goto IL_0b06;
				case "/epsilon/sc/async/verify/":
					num2++;
					if (num2 < num3)
					{
						string text10 = OtpMailHelper.GetOTPMailHelp(1, string_0, A216F1AE, 60, B0A4DABF, text7);
						if (!(text10 == "fail"))
						{
							if (text10 == "")
							{
								text2 = Regex.Match(text8, "action=\"(/epsilon/sc/async/resend_code/.*?)\"").Groups[1].Value;
								text2 = text2.Replace("&amp;", "&");
								text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&code=&data=ec:0&resend=Resend+code";
								text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, text3);
							}
							else
							{
								text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
								text2 = text2.Replace("&amp;", "&");
								text3 = "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&code=" + text10 + "&data=ec:0";
								text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, text3);
							}
							goto IL_0b06;
						}
						item = "Unlock 956 Fail (Không thể kết nối mail)";
						break;
					}
					item = "Unlock 956 Fail (Không lấy được otp)";
					break;
				case "/epsilon/sc/async/select/":
				{
					string text11 = string_0.Substring(string_0.IndexOf('@') - 1, 3).Replace("@", "&#064;");
					string value = Regex.Match(text8, text11 + ".*?type=\"radio\".*?value=\"(ec.*?)\"").Groups[1].Value;
					if (!(value == "") && text8.Contains(text11))
					{
						text7 = OtpMailHelper.GetOTPMailHelp(1, string_0, A216F1AE, 0, B0A4DABF, "");
						if (!(text7 == "fail"))
						{
							text2 = Regex.Match(text8, "action=\"(" + text9 + ".*?)\"").Groups[1].Value;
							text2 = text2.Replace("&amp;", "&");
							text8 = ef086887_0.CEA7950B("https://mbasic.facebook.com" + text2, "fb_dtsg=" + text4 + "&jazoest=" + text5 + "&index=" + value);
							goto IL_0b06;
						}
						item = "Unlock 956 Fail (Không thể kết nối mail)";
						break;
					}
					item = "Unlock 956 Fail (Fb bắt xác minh email không có trên tool)";
					break;
				}
				case "id=\"m_login_email\"":
					item = "Unlock 956 Fail (1)";
					break;
				case "/help/contact/571927962827151":
					item = "Unlock 956 Fail (Spam)";
					break;
				case "/x/checkpoint/hacked_cleanup/":
				case "/x/checkpoint/828281030927956/outro/":
					flag = true;
					break;
				default:
					{
						if (ef086887_0.method_2().Contains("1501092823525282"))
						{
							item2 = (item = "Checkpoint: 282");
						}
						else if (ef086887_0.method_2().Contains("828281030927956"))
						{
							if (text8.Contains("KGOvhWyM65Y.png") || text8.Contains("CCnQRnuNDBB.png") || text8.Contains("FpkwdkKVsK1.png") || text8.Contains("/help/203305893040179") || text8.Contains("/images/checkpoint/epsilon/comet/limbo-light.png"))
							{
								item2 = (item = "Checkpoint: 956-Tìm hiểu thêm");
								break;
							}
							smethod_16(text8, B0A4DABF);
							item = "Unlock 956 Fail (Đã có lỗi xảy ra, vui lòng thử lại sau)";
						}
						else if (text8.Contains("/friends/") || ef086887_0.method_2().Contains("facebook.com/gettingstarted"))
						{
							flag = true;
						}
						else if (text8 != "")
						{
							smethod_16(text8, B0A4DABF);
							item = "Unlock 956 Fail (Đã có lỗi xảy ra, vui lòng thử lại sau)";
						}
						else
						{
							item = "Unlock 956 Fail (Đã có lỗi xảy ra, vui lòng thử lại sau)";
						}
						break;
					}
					IL_0b06:
					if (Environment.TickCount - tickCount < 600000)
					{
						goto IL_0b1d;
					}
					item = "Unlock 956 Fail (Timeout)";
					break;
				}
				break;
				IL_0b1d:
				Common.Sleep(1.0);
			}
		}
		catch (Exception ex)
		{
			smethod_16(ex.ToString(), B0A4DABF);
			item = "Unlock 956 Fail (Đã có lỗi xảy ra, vui lòng thử lại sau)";
		}
		if (flag)
		{
			item2 = "Live";
			item = "Unlock checkpoint success";
		}
		return (item, item2, text);
	}

	public static void smethod_16(string C9195B95, string string_0)
	{
		string path = "log\\unlock956.txt";
		lock (object_0)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (string_0 != "")
				{
					File.AppendAllText(path, "Uid: " + string_0 + "\r\n");
				}
				File.AppendAllText(path, C9195B95 + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}
}
