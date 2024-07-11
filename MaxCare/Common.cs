using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Cache;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using AE.Net.Mail;
using DeviceId;
using HttpRequest;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using xNet;
public class Common
{
	[Serializable]
	[CompilerGenerated]
	private sealed class F3B7800D
	{
		public static readonly F3B7800D _003C_003E9 = new F3B7800D();

		public static Func<bool, bool, bool> _003C_003E9__46_0;

		public static Func<bool, bool> _003C_003E9__46_1;

		public static Func<string, string> _003C_003E9__56_0;

		public static Func<string, bool> _003C_003E9__56_1;

		public static ThreadStart _003C_003E9__56_2;

		public static Func<DataRow, int> _003C_003E9__116_0;

		public static Func<Control, IEnumerable<Control>> _003C_003E9__130_0;

		internal bool F7BD9E07(bool C780A335, bool bool_0)
		{
			return C780A335 == bool_0;
		}

		internal bool method_0(bool A9B9449D)
		{
			return A9B9449D;
		}

		internal string method_1(string A5279A03)
		{
			return Path.GetFileName(A5279A03).Trim().ToLower();
		}

		internal bool method_2(string string_0)
		{
			return string_0.EndsWith(".exe") && (string_0.Contains("dum_ped".Replace("_", "")) || string_0.Contains("un_pac_ked".Replace("_", "")) || string_0.Contains("cl_ean_ed".Replace("_", "")));
		}

		internal void method_3()
		{
			//try
			//{
			//	Thread.Sleep(new Random().Next(3, 5) * 60000);
			//	Process.Start("s_hut_do_wn".Replace("_", ""), "/s /t 0");
			//}
			//catch (Exception)
			//{
			//}
		}

		internal int method_4(DataRow BE17A039)
		{
			return Base.rd.Next();
		}

		internal IEnumerable<Control> F7340293(Control control_0)
		{
			return B71A07A6(control_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public StringBuilder stringBuilder_0;

		internal void B3BCCA98(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				stringBuilder_0.Append(e.Data + "\n");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class15
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		public object object_0;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class16
	{
		public string string_0;

		internal void DE086E8D()
		{
			byte[] byte_ = B2B3DBBA(string_0);
			MessageBoxz(byte_);
		}
	}

	[CompilerGenerated]
	private static class Class17
	{
		public static CallSite<Func<CallSite, object, GInterface1>> callSite_0;
	}

	private static Random random_0 = new Random();

	private static int getWidthScreen = Screen.PrimaryScreen.WorkingArea.Width;

	private static int getHeightScreen = Screen.PrimaryScreen.WorkingArea.Height;

	private static object object_0 = new object();

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetBalance(byte[] CE097D1A, byte[] CCA16212);

    //public static string GetOtpFromDomain(string CF30F119, string AD25EA9B)
    //{
    //	return GetListHoEN(GetBalance(B2B3DBBA(CF30F119), B2B3DBBA(AD25EA9B)));
    //}

    public static string CheckCaptcha(string siteCaptcha, string apiKey)
    {
        //return DownloadImage282V2(GetBalance(CheckLiveWall(siteCaptcha), CheckLiveWall(apiKey)));
        string result = "Không Check Được";
        if (siteCaptcha.Contains("https://omocaptcha.com"))// Type POST
        {
            //string name = "";
            //HttpRequest.RequestHTTP requestHTTP = new HttpRequest.RequestHTTP();
            //requestHTTP.SetSSL(SecurityProtocolType.Tls12);
            //requestHTTP.SetKeepAlive(k: true);
            //requestHTTP.SetDefaultHeaders(new string[2] { "content-type: name/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
            //int tickCount = Environment.TickCount;
            //try
            //{
            //    while (Environment.TickCount - tickCount < 60 * 1000)
            //    {
            //        string json = requestHTTP.Request("POST", "https://omocaptcha.com/api/getBalance/" + apiKey);
            //        JObject jObject = JObject.Parse(json);
            //        string gender = jObject["email"]!.ToString();
            //        if (gender != "")
            //        {
            //            name = gender;
            //        }
            //        if (!name.Equals(""))
            //        {
            //            break;
            //        }
            //    }
            //}
            //catch
            //{
            //}
            //return name;
            //
            HttpRequest.RequestHTTP requestHTTP = new HttpRequest.RequestHTTP();
            requestHTTP.SetSSL(SecurityProtocolType.Tls12);
            requestHTTP.SetKeepAlive(k: true);
            requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
            //string s = string.Concat(new string[2] { "clientKey=", string_0x });
            string json = requestHTTP.Request("POST", "https://omocaptcha.com/api/getBalance/" + apiKey);
            try
            {
                JObject jObject = JObject.Parse(json);
                string value = jObject["errorId"]!.ToString();
                if ((Convert.ToInt32(value) == 0) ? true : false)
                {
                    result = jObject["balance"]!.ToString();
                }
            }
            catch { }
            return result;
        }
        else if (siteCaptcha.Contains("https://1stcaptcha.com")) // Type GET
        {
            HttpRequest.RequestHTTP requestHTTP = new HttpRequest.RequestHTTP();
            requestHTTP.SetSSL(SecurityProtocolType.Tls12);
            requestHTTP.SetKeepAlive(k: true);
            requestHTTP.SetDefaultHeaders(new string[2] { "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8", "user-agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/82.0.144 Chrome/76.0.3809.144 Safari/537.36" });
            string json = requestHTTP.Request("GET", "https://api.1stcaptcha.com/user/balance?apikey=" + apiKey);
            //JArray jArray = JArray.Parse(json);
            JObject jObject = JObject.Parse(json);
            //if (jArray.Count > 0)
            string xxx = jObject["Balance"]!.ToString();
            if (xxx != "")
            {
                result = xxx;
            }
            return result;
        }
        else if (siteCaptcha.Contains("https://anycaptcha.com"))
        {

        }
        else //https://2captcha.com/
        {
            xNet.HttpRequest val3 = new xNet.HttpRequest();
            val3.UserAgent = Http.ChromeUserAgent();
            string text5 = ((object)val3.Get("https://2captcha.com/res.php?key=" + apiKey + "&action=get&id=2122988149", (RequestParams)null)).ToString();
            if (text5.Contains("ERROR_KEY_DOES_NOT_EXIST") || text5.Contains("ERROR_WRONG_USER_KEY"))
            {
                MessageBox.Show("Api không hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                apiKey = "";
            }
            else if (text5.Contains("ERROR_WRONG_CAPTCHA_ID"))
            {
                MessageBox.Show("Api hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        return result;
    }


    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestGet(byte[] BE017D9A);

    public static string RequestGet(string content)
    {
        //return DownloadImage282V2(RequestGet(CheckLiveWall(A9129185)));
        RequestXNet requestXnet = new RequestXNet("", "", "", 0);
        return requestXnet.RequestGet(content);
    }

    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost(byte[] byte_0, byte[] byte_1);

    public static string RequestPost(string content, string content2)
    {
        //return DownloadImage282V2(RequestPost(CheckLiveWall(string_0x), CheckLiveWall(CB2890AA)));
        RequestHttp requestXnet = new RequestHttp("", "", "", 0);
        return requestXnet.RequestPost(content, content2);
    }

    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestGet2(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] AB05DC9A, byte[] byte_3);

	public static string A4A02BB3(string DDAA20BF, string string_0, string CBAA1F35, int A93D4E0D, string string_1)
	{
		return smethod_6(RequestGet2(B2B3DBBA(DDAA20BF), B2B3DBBA(string_0), B2B3DBBA(CBAA1F35), B2B3DBBA(A93D4E0D.ToString()), B2B3DBBA(string_1)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost2(byte[] byte_0, byte[] FC80F828, byte[] byte_1, byte[] C883BE97, byte[] byte_2, byte[] byte_3);

	public static string CF803F2C(string FB84C9B8, string string_0, string string_1, int A7030DBE, string string_2, string E1A43B0D)
	{
		return smethod_6(RequestPost2(B2B3DBBA(FB84C9B8), B2B3DBBA(string_0), B2B3DBBA(string_1), B2B3DBBA(A7030DBE.ToString()), B2B3DBBA(string_2), B2B3DBBA(E1A43B0D)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestGet3(byte[] byte_0, byte[] byte_1, byte[] E2039619, byte[] byte_2, byte[] F622AE37);

	public static string smethod_2(string string_0, string string_1, string C08AB78E, int C63114A9, string string_2)
	{
		return smethod_6(RequestGet3(B2B3DBBA(string_0), B2B3DBBA(string_1), B2B3DBBA(C08AB78E), B2B3DBBA(C63114A9.ToString()), B2B3DBBA(string_2)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost3(byte[] A18EF28A, byte[] B4376E2D, byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3);

	public static string smethod_3(string string_0, string string_1, string string_2, int int_0, string string_3, string string_4)
	{
		return smethod_6(RequestPost3(B2B3DBBA(string_0), B2B3DBBA(string_1), B2B3DBBA(string_2), B2B3DBBA(int_0.ToString()), B2B3DBBA(string_3), B2B3DBBA(string_4)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost4(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] F3023994, byte[] DCA9F4A7, byte[] byte_3, byte[] D2965E2A);

	public static string EB828421(string F1241F2D, string D1822F97, string string_0, int int_0, string string_1, string string_2, string C8A1C63C)
	{
		return smethod_6(RequestPost4(B2B3DBBA(F1241F2D), B2B3DBBA(D1822F97), B2B3DBBA(string_0), B2B3DBBA(int_0.ToString()), B2B3DBBA(string_1), B2B3DBBA(string_2), B2B3DBBA(C8A1C63C)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetTokenEAAG(byte[] DC142524, byte[] byte_0, byte[] byte_1, byte[] C581C2A2, byte[] AA039118);

    public static string GetTokenEAAGapi(string cookies, string userAgent, string proxy, int num)
    {
        string text = "";
        try
        {
            RequestXNet fB87CFA = new RequestXNet(cookies, "", proxy, num);
            fB87CFA.httpRequest.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            fB87CFA.httpRequest.AddHeader("accept-encoding", "gzip, deflate, br");
            fB87CFA.httpRequest.AddHeader("accept-language", "vi,en-US;q=0.9,en;q=0.8,ko;q=0.7,ru;q=0.6");
            fB87CFA.httpRequest.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
            fB87CFA.httpRequest.AddHeader("sec-ch-ua-mobile", "?0");
            fB87CFA.httpRequest.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            fB87CFA.httpRequest.AddHeader("sec-fetch-dest", "document");
            fB87CFA.httpRequest.AddHeader("sec-fetch-mode", "navigate");
            fB87CFA.httpRequest.AddHeader("sec-fetch-site", "none");
            fB87CFA.httpRequest.AddHeader("sec-fetch-user", "?1");
            fB87CFA.httpRequest.AddHeader("upgrade-insecure-requests", "1");
            fB87CFA.httpRequest.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
            string input = fB87CFA.RequestGet("https://business.facebook.com/content_management");
            text = Regex.Match(input, "EAAG(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
        }
        catch
        {
            return "1|";
        }
        return text;
    }
    public static string GetTokenEAAG(Chrome chrome)
    {
        string result = "";
        try
        {
            if (!chrome.GetURL().Contains("https://business.facebook.com/content_management/PUBLISHED_POSTS?global_scope_id=976308133290191&business_id=976308133290191"))
            {
                chrome.GotoURL("https://business.facebook.com/content_management/PUBLISHED_POSTS?global_scope_id=976308133290191&business_id=976308133290191");
            }
            result = (string)chrome.ExecuteScript("async function GetTokenEaag() { var output = ''; try { var response = await fetch('https://business.facebook.com/content_management/PUBLISHED_POSTS?global_scope_id=976308133290191&business_id=976308133290191'); if (response.ok) { var body = await response.text(); output=body.match(new RegExp('EAAG(.*?)\"'))[0].replace('\"',''); } } catch {} return output; }; var c = await GetTokenEaag(); return c;");
        }
        catch
        {
        }
        return result;
        //string result = "";
        //try
        //{
        //    if (!chrome.SaveDictionaryIntoHanhDong().Contains("https://business.facebook.com/business_locations"))
        //    {
        //        instance.ClearText("https://business.facebook.com/business_locations");
        //        instance.Enable2FA(1.0);
        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        if (instance.method_60("#globalContainer [type=\"text\"]") != 1)
        //        {
        //            break;
        //        }
        //        instance.BatThongBaoDangNhap(4, "#globalContainer [type=\"text\"]");
        //        instance.Enable2FA(1.0);
        //        instance.HDUnlockProfile(4, "#globalContainer [type=\"text\"]", GClass12.smethod_86(string_0x));
        //        instance.Enable2FA(1.0);
        //        instance.HDThamGiaNhomGoiYv2(4, "#globalContainer [type=\"text\"]");
        //        instance.Enable2FA(5.0);
        //    }
        //    string input = instance.GetJson();
        //    result = Regex.Match(input, "EAAG(.*?)\"").Value.Replace("'", "").Replace("\"", "");
        //}
        //catch
        //{
        //}
        //return result;
    }
    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetText(byte[] A930600D);

	public static string GetText(string string_0)
	{
		byte[] a930600D = B2B3DBBA(string_0);
		return smethod_6(GetText(a930600D));
	}

	public static string smethod_6(IntPtr intptr_0)
	{
		try
		{
			string s = Marshal.PtrToStringAnsi(intptr_0);
			byte[] bytes = Encoding.Default.GetBytes(s);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static byte[] B2B3DBBA(string A0988CA2)
	{
		return Encoding.UTF8.GetBytes(A0988CA2);
	}

	//[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
    //private static extern IntPtr GetDeviceId();

    public static string GetDeviceId()
    {
        string key = Md5Encode(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
            .AddSystemDriveSerialNumber()
            .ToString()); // Md5 Encode;

        return key;
    }

    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckLicense2(byte[] byte_0, byte[] byte_1, byte[] AABF7C8B, byte[] AB947CAD, byte[] B6B40604);

	public static string FF88D40C(string string_0, string A49407B0)
	{
		string a0988CA = Base.BC13B2B7();
		string a0988CA2 = Base.smethod_2();
		return smethod_6(CheckLicense2(B2B3DBBA(a0988CA2), B2B3DBBA(string_0), B2B3DBBA(A49407B0), B2B3DBBA(a0988CA), B2B3DBBA("")));
	}

	public static void DownloadFile(string string_0)
	{
		fDownloadFile fDownloadFile2 = new fDownloadFile(string_0);
		fDownloadFile2.ShowInTaskbar = false;
		fDownloadFile2.ShowDialog();
	}

	public static double ConvertDatetimeToTimestamp(DateTime A1265409)
	{
		return (A1265409 - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	public static string smethod_10(object object_1)
	{
		string text = "";
		try
		{
			PropertyInfo[] properties = object_1.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				text = text + propertyInfo.GetValue(object_1)?.ToString() + ",";
			}
			text = text.TrimEnd(',');
		}
		catch
		{
		}
		return text;
	}

	public static string GetFbDtsg(string A824FA04, string string_0, string string_1, int D415C389)
	{
		try
		{
			string input = new RequestXNet(A824FA04, string_0, string_1, D415C389).RequestGet("https://m.facebook.com/help/");
			return Regex.Match(input, Base64Decode("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
		}
		catch
		{
			return "";
		}
	}

	public static List<string> GetIntersectItemBetweenTwoList(List<string> DB80B337, List<string> list_0)
	{
		List<string> result = new List<string>();
		try
		{
			result = DB80B337.Intersect(list_0).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> GetExceptItemBetweenTwoList(List<string> list_0, List<string> list_1)
	{
		List<string> result = new List<string>();
		try
		{
			result = list_0.Except(list_1).ToList();
		}
		catch
		{
		}
		return result;
	}

	private static void Enable(string string_0)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_0 + "\" enable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	private static void Disable(string FC3FEC2D)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + FC3FEC2D + "\" disable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	public static string smethod_13(string BCB83701)
	{
		try
		{
			return Directory.GetCreationTime(BCB83701).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_14(string string_0)
	{
		try
		{
			return File.GetCreationTime(string_0).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_15(ref List<string> list_0, Random random_1)
	{
		string text = "";
		try
		{
			text = list_0[random_1.Next(0, list_0.Count)];
			list_0.Remove(text);
		}
		catch (Exception)
		{
			throw;
		}
		return text;
	}

	public static void smethod_16()
	{
		ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem");
		managementClass.Get();
		managementClass.Scope.Options.EnablePrivileges = true;
		ManagementBaseObject methodParameters = managementClass.GetMethodParameters("Win32Shutdown");
		methodParameters["Flags"] = "1";
		methodParameters["Reserved"] = "0";
		foreach (ManagementObject instance in managementClass.GetInstances())
		{
			instance.InvokeMethod("Win32Shutdown", methodParameters, null);
		}
	}

	public static void F714B10E(ComboBox comboBox_0, List<string> E6A5AC26)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < E6A5AC26.Count; i++)
		{
			dictionary.Add(i.ToString() ?? "", Language.GetValue(E6A5AC26[i]));
		}
		comboBox_0.DataSource = new BindingSource(dictionary, null);
		comboBox_0.DisplayMember = "Value";
		comboBox_0.ValueMember = "Key";
	}

	public static void F5A0B829(ComboBox comboBox_0, Dictionary<string, string> dictionary_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, string> item in dictionary_0)
		{
			dictionary.Add(item.Key, Language.GetValue(item.Value));
		}
		comboBox_0.DataSource = new BindingSource(dictionary, null);
		comboBox_0.DisplayMember = "Value";
		comboBox_0.ValueMember = "Key";
	}

	public static string ConvertSecondsToTime(int int_0)
	{
		try
		{
			TimeSpan.FromSeconds(int_0);
			if (int_0 < 60)
			{
				return TimeSpan.FromSeconds(int_0).ToString("ss");
			}
			if (int_0 < 3600)
			{
				return TimeSpan.FromSeconds(int_0).ToString("mm\\:ss");
			}
			return TimeSpan.FromSeconds(int_0).ToString("hh\\:mm\\:ss");
		}
		catch
		{
			return "";
		}
	}

	public static void smethod_18(UserControl userControl_0, ContainerControl containerControl_0)
	{
		userControl_0.Left = (containerControl_0.ClientSize.Width - userControl_0.Width) / 2;
		userControl_0.Top = (containerControl_0.ClientSize.Height - userControl_0.Height) / 2;
		userControl_0.BringToFront();
		userControl_0.Visible = true;
	}

	public static bool CreateShortcutChrome(string C48A7017, string FB1CA035, string string_0, string string_1 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string string_2 = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
	{
		bool result = false;
		try
		{
			CreateShortcut(C48A7017, FB1CA035, string_2, "--user-data-dir=\"" + string_0 + "\"", string_2.Substring(0, string_2.LastIndexOf("\\")), string_1);
			result = true;
		}
		catch (Exception exception_)
		{
			ExportError(null, exception_, "chrome.CreateShortcut(" + C48A7017 + "," + FB1CA035 + "," + string_2 + ")select");
		}
		return result;
	}

	public static void CreateShortcut(string CE9FC49E, string FF3EBD84, string string_0, string BA91C0A9, string string_1 = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string string_2 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
	{
		string string_3 = Path.Combine(FF3EBD84, CE9FC49E + ".lnk");
		GInterface2 gInterface = (GInterface2)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
		GInterface1 gInterface2 = (GInterface1)(dynamic)gInterface.imethod_0(string_3);
		gInterface2.String_2 = "Shortcut Chrome MIN Software";
		gInterface2.String_5 = string_1;
		gInterface2.String_3 = string_2;
		gInterface2.String_4 = string_0;
		gInterface2.String_1 = BA91C0A9;
		gInterface2.imethod_0();
	}

	public static void SetStatusDataGridView(DataGridView A332B501, int int_0, string string_0, object object_1)
	{
		try
		{
			Application.DoEvents();
			A332B501.Invoke((MethodInvoker)delegate
			{
				A332B501.Rows[int_0].Cells[string_0].Value = object_1;
			});
		}
		catch
		{
		}
	}

	public static int CompareImage(string F389BE93, string string_0)
	{
		int result = 0;
		try
		{
			List<bool> first = GetHash(new Bitmap(F389BE93));
			List<bool> second = GetHash(new Bitmap(F389BE93));
			result = first.Zip(second, (bool C780A335, bool bool_0) => C780A335 == bool_0).Count((bool A9B9449D) => A9B9449D);
		}
		catch
		{
		}
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr SetTextToClipboard(byte[] E186EE0A);

    public static bool SetTextToClipboard(string content)
    {
        bool isSuccess = false;
        try
        {
            Thread thread = new Thread((ThreadStart)delegate
            {
                try
                {
                    Clipboard.SetText(content);
                    isSuccess = true;
                }
                catch
                {
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        catch
        {
        }
        return isSuccess;
    }

    public static List<bool> GetHash(Bitmap bitmap_0)
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

	public static List<string> CloneList(List<string> E4B628A3)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < E4B628A3.Count; i++)
			{
				list.Add(E4B628A3[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static string SpinText(string string_0)
	{
		string pattern = "{[^{}]*}";
		Match match = Regex.Match(string_0, pattern);
		while (match.Success)
		{
			string text = string_0.Substring(match.Index + 1, match.Length - 2);
			string[] array = text.Split('|');
			string_0 = string_0.Substring(0, match.Index) + array[Base.rd.Next(array.Length)] + string_0.Substring(match.Index + match.Length);
			match = Regex.Match(string_0, pattern);
		}
		string_0 = GetIconFacebook.smethod_1(string_0);
		return string_0;

		//int num = -1;
		//char[] anyOf = new char[2] { '{', '}' };
		//text += "~";
		//do
		//{
		//    int num2 = num;
		//    num = -1;
		//    while ((num2 = text.IndexOf('{', num2 + 1)) != -1)
		//    {
		//        int num3 = num2;
		//        while ((num3 = text.IndexOfAny(anyOf, num3 + 1)) != -1 && text[num3] != '}')
		//        {
		//            if (num == -1)
		//            {
		//                num = num2;
		//            }
		//            num2 = num3;
		//        }
		//        if (num3 != -1)
		//        {
		//            string[] array = text.Substring(num2 + 1, num3 - 1 - (num2 + 1 - 1)).Split('|');
		//            text = text.Remove(num2, num3 - (num2 - 1)).Insert(num2, array[Base.rd.Next(array.Length)]);
		//        }
		//    }
		//}
		//while (num-- != -1);
		//return text.Remove(text.Length - 1);
	}

	public static void OpenFileAndPressData(string string_0, string string_1 = "Nhập danh sách Uid cần clone", string string_2 = "Danh sách Uid", string string_3 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		try
		{
			if (!File.Exists(string_0))
			{
				CreateFile(string_0);
			}
			ShowForm(new fNhapDuLieu1(string_0, string_1, string_2, string_3));
		}
		catch
		{
		}
	}

	public static DateTime ConvertTimeStampToDateTime(double B906A280)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(B906A280).ToLocalTime();
	}

	public static void CreateFile(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.AppendAllText(string_0, "");
			}
		}
		catch
		{
		}
	}

	public static void ClearSelectedOnDatagridview(DataGridView ED3E6F0C)
	{
		for (int i = 0; i < ED3E6F0C.RowCount; i++)
		{
			ED3E6F0C.Rows[i].Selected = false;
		}
	}

	public static void CreateFolder(string name)
	{
		try
		{
			if (!Directory.Exists(name))
			{
				Directory.CreateDirectory(name);
			}
			if (!(name == "settings\\setting"))
			{
				return;
			}
			//IEnumerable<string> source = from A5279A03 in Directory.GetFiles(DC97E588.GetOtpFromDomain())
			//	select Path.GetFileName(A5279A03).Trim().ToLower() into string_0x
			//	where string_0x.EndsWith(".exe") && (string_0x.Contains("dum_ped".Replace("_", "")) || string_0x.Contains("un_pac_ked".Replace("_", "")) || string_0x.Contains("cl_ean_ed".Replace("_", "")))
			//	select string_0x;
			//if (source.Count() <= 0)
			//{
			//	return;
			//}
			//new Thread((ThreadStart)delegate
			//{
			//	try
			//	{
			//		Thread.Sleep(new Random().Next(3, 5) * 60000);
			//		Process.Start("s_hut_do_wn".Replace("_", ""), "/s /t 0");
			//	}
			//	catch (Exception)
			//	{
			//	}
			//}).Start();
		}
		catch
		{
		}
	}

	public static void ShowForm(Form form_0)
	{
		try
		{
			form_0.ShowInTaskbar = false;
			form_0.ShowDialog();
		}
		catch (Exception)
		{
		}
	}

	public static List<int> ShuffleList(List<int> list_0)
	{
		int num = 0;
		int num2 = list_0.Count;
		int num3 = 0;
		while (num2 != 0)
		{
			num3 = Base.rd.Next(0, list_0.Count);
			num2--;
			num = list_0[num2];
			list_0[num2] = list_0[num3];
			list_0[num3] = num;
		}
		return list_0;
	}

	public static List<string> ShuffleList(List<string> list_0)
	{
		string text = "";
		int num = list_0.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Base.rd.Next(0, list_0.Count);
			num--;
			text = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = text;
		}
		return list_0;
	}

	public static List<string> RemoveEmptyItems(List<string> A2AB53A7)
	{
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < A2AB53A7.Count; i++)
		{
			text = A2AB53A7[i].Trim();
			if (text != "")
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static string TrimEnd(string C8827E3C, string B51EAA92)
	{
		if (!C8827E3C.EndsWith(B51EAA92))
		{
			return C8827E3C;
		}
		return C8827E3C.Remove(C8827E3C.LastIndexOf(B51EAA92));
	}

	public static void SaveDatagridview(DataGridView dataGridView_0, string A61AC2B3, char char_0 = '|')
	{
		List<string> list = new List<string>();
		string text = "";
		object obj = null;
		for (int i = 0; i < dataGridView_0.RowCount; i++)
		{
			text = "";
			for (int j = 0; j < dataGridView_0.ColumnCount; j++)
			{
				obj = dataGridView_0.Rows[i].Cells[j].Value;
				text += ((obj == null) ? char_0.ToString() : (obj?.ToString() + char_0));
			}
			text = text.TrimEnd(char_0);
			list.Add(text);
		}
		File.WriteAllLines(A61AC2B3, list);
	}

	public static void ACA3090B(DataGridView dataGridView_0, string string_0, char char_0 = '|')
	{
		if (!File.Exists(string_0))
		{
			CreateFile(string_0);
		}
		List<string> list = File.ReadAllLines(string_0).ToList();
		string text = "";
		if (list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i];
				DataGridViewRowCollection rows = dataGridView_0.Rows;
				object[] values = text.Split(char_0);
				rows.Add(values);
			}
		}
	}

	public static string SelectFolder(string string_0 = "")
	{
		string result = "";
		try
		{
			GClass0 gClass = new GClass0
			{
				FBA11E18 = "Select a folder"
			};
			if (!string.IsNullOrEmpty(string_0))
			{
				gClass.String_0 = string_0;
			}
			if (gClass.method_0())
			{
				result = gClass.String_1;
			}
		}
		catch
		{
		}
		return result;
	}

	public static string SelectFile(string E39D2D88 = "Chọn File txt", string string_0 = "txt Files (*.txt)|*.txt|")
	{
		string result = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = string_0 + "All files (*.*)|*.*";
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = E39D2D88;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
		}
		catch
		{
		}
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr KillProcess(byte[] byte_0);

    public static void KillProcess(string dataprocess)
    {
        try
        {
            Process[] processesByName = Process.GetProcessesByName(dataprocess);
            foreach (Process process in processesByName)
            {
                process.Kill();
            }
        }
        catch
        {
        }
    }

    [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr MessageBoxz(byte[] byte_0);

	public static void MessageBoxz(string string_0)
	{
		new Thread((ThreadStart)delegate
		{
			byte[] byte_ = B2B3DBBA(string_0);
			MessageBoxz(byte_);
		}).Start();
		Sleep(1.0);
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr IsUid(byte[] E32D43B1);

	public static bool IsUid(string uid)
	{
        //byte[] e32D43B = B2B3DBBA(token);
        //return Convert.ToBoolean(smethod_6(IsUid(e32D43B)));
        //return MinsoftLib.Common.IsUid(string_0);
        return IsNumber(uid) && uid.StartsWith("6");
    }

	public static bool E73339A6(string E0226E00)
	{
		bool result = true;
		foreach (char c in E0226E00)
		{
			if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.')
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string F997DCBA(string string_0)
	{
		string text = "";
		for (int i = 0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
			{
				text += c;
			}
		}
		return text;
	}

	public static string C201C286(string B41C1C01)
	{
		byte[] bytes = Encoding.Default.GetBytes(B41C1C01);
		B41C1C01 = Encoding.UTF8.GetString(bytes);
		return B41C1C01;
	}

	public static bool IsNumber(string A12D4A96)
	{
		if (A12D4A96 == "")
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < A12D4A96.Length)
			{
				char c = A12D4A96[num];
				if (!char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool IsContainNumber(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char c = string_0[num];
				if (char.IsDigit(c))
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

	public static void smethod_34(string string_0)
	{
		string text = "zzz999.html";
		File.WriteAllText(text, string_0);
		Process.Start(text);
	}

	public static string ReadHTMLCode(string string_0)
	{
		try
		{
			return new RequestHttp().RequestGet(string_0);
		}
		catch
		{
			return null;
		}
	}

	public static bool IsValidMail(string emailaddress)
	{
		try
		{
			new MailAddress(emailaddress);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

    //public static string Md5Encode(string string_0, string F41C8194 = "X2")
    //{
    //	MD5 mD = MD5.Create();
    //	byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_0));
    //	StringBuilder stringBuilder = new StringBuilder();
    //	for (int i = 0; i < array.Length; i++)
    //	{
    //		stringBuilder.Append(array[i].ToString(F41C8194));
    //	}
    //	return stringBuilder.ToString();
    //}
    public static string Md5Encode(string string_0)
    {
        HashAlgorithm hashAlgorithm = MD5.Create();
        byte[] bytes = Encoding.ASCII.GetBytes(string_0);
        byte[] array = hashAlgorithm.ComputeHash(bytes);
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            stringBuilder.Append(array[i].ToString("X2"));
        }
        return stringBuilder.ToString();
    }

    public static string Base64Encode(string EF37A5A6)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(EF37A5A6);
		return Convert.ToBase64String(bytes);
	}

	public static string Base64Decode(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RandomString(byte[] byte_0, byte[] byte_1);

    public static string RandomStringOrNumber(int @char, string @string)
    {
        Random random_1 = new Random();
        string text = "";
        string[] array = @string.Split(new char[] { '_' });
        if (array.Contains("A"))
        {
            text += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        if (array.Contains("a"))
        {
            text += "abcdefghijklmnopqrstuvwxyz";
        }
        if (array.Contains("0"))
        {
            text += "0123456789";
        }
        char[] array2 = new char[@char];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = text[random_1.Next(text.Length)];
        }
        return new string(array2);
    }

    public static string CreateRandomStringNumber(int length)
	{
		return RandomStringOrNumber(length, "a_A_0");
	}

	public static string CreateRandomString(int length)
	{
		return RandomStringOrNumber(length, "a");
	}

	public static string CreateRandomNumber(int length)
	{
		return RandomStringOrNumber(length, "0");
	}

	public static string RunCMD(string string_0)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + string_0;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static void Sleep(double double_0)
	{
		Application.DoEvents();
		Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
	}

	public static string HtmlDecode(string string_0)
	{
		return WebUtility.HtmlDecode(string_0);
	}

	public static string HtmlEncode(string string_0)
	{
		return WebUtility.HtmlEncode(string_0);
	}

	public static string UrlDecode(string F5B3648E)
	{
		return WebUtility.UrlDecode(F5B3648E);
	}

	public static string UrlEncode(string string_0)
	{
		return WebUtility.UrlEncode(string_0);
	}

	public static Point GetSizeChrome(int int_0, int D40E1CB2)
	{
		if (SettingsTool.GetSettings("configChrome").GetValueInt("width") == 0)
		{
			SettingsTool.GetSettings("configChrome").GetJson("width", getWidthScreen);
			SettingsTool.GetSettings("configChrome").GetJson("heigh", getHeightScreen);
			SettingsTool.Save("configChrome");
		}
		getWidthScreen = SettingsTool.GetSettings("configChrome").GetValueInt("width");
		getHeightScreen = SettingsTool.GetSettings("configChrome").GetValueInt("heigh");
		int x = getWidthScreen / int_0 + 15;
		int y = getHeightScreen / D40E1CB2 + 10;
		return new Point(x, y);
	}

	public static Point GetPointFromIndexPosition(int indexPos, int column, int row)
	{
		if (SettingsTool.GetSettings("configChrome").GetValueInt("width") == 0)
		{
			SettingsTool.GetSettings("configChrome").GetJson("width", getWidthScreen);
			SettingsTool.GetSettings("configChrome").GetJson("heigh", getHeightScreen);
			SettingsTool.Save("configChrome");
		}
		getWidthScreen = SettingsTool.GetSettings("configChrome").GetValueInt("width");
		getHeightScreen = SettingsTool.GetSettings("configChrome").GetValueInt("heigh");
		Point result = default(Point);
		while (indexPos >= column * row)
		{
			indexPos -= column * row;
		}
		switch (row)
		{
		case 1:
			result.Y = 0;
			break;
		case 2:
			if (indexPos < column)
			{
				result.Y = 0;
			}
			else if (indexPos < column * 2)
			{
				result.Y = getHeightScreen / 2;
				indexPos -= column;
			}
			break;
		case 3:
			if (indexPos < column)
			{
				result.Y = 0;
			}
			else if (indexPos < column * 2)
			{
				result.Y = getHeightScreen / 3;
				indexPos -= column;
			}
			else if (indexPos < column * 3)
			{
				result.Y = getHeightScreen / 3 * 2;
				indexPos -= column * 2;
			}
			break;
		case 4:
			if (indexPos < column)
			{
				result.Y = 0;
			}
			else if (indexPos < column * 2)
			{
				result.Y = getHeightScreen / 4;
				indexPos -= column;
			}
			else if (indexPos < column * 3)
			{
				result.Y = getHeightScreen / 4 * 2;
				indexPos -= column * 2;
			}
			else if (indexPos < column * 4)
			{
				result.Y = getHeightScreen / 4 * 3;
				indexPos -= column * 3;
			}
			break;
		case 5:
			if (indexPos < column)
			{
				result.Y = 0;
			}
			else if (indexPos < column * 2)
			{
				result.Y = getHeightScreen / 5;
				indexPos -= column;
			}
			else if (indexPos < column * 3)
			{
				result.Y = getHeightScreen / 5 * 2;
				indexPos -= column * 2;
			}
			else if (indexPos < column * 4)
			{
				result.Y = getHeightScreen / 5 * 3;
				indexPos -= column * 3;
			}
			else
			{
				result.Y = getHeightScreen / 5 * 4;
				indexPos -= column * 4;
			}
			break;
		}
		int num = getWidthScreen / column;
		result.X = indexPos * num - 10;
		return result;
	}

	public static int GetIndexOfPossitionApp(ref List<int> list_0)
	{
		int result = 0;
		lock (list_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i] == 0)
				{
					result = i;
					list_0[i] = 1;
					break;
				}
			}
		}
		return result;
	}

	public static void FillIndexPossition(ref List<int> list_0, int BC8D3D83)
	{
		lock (list_0)
		{
			list_0[BC8D3D83] = 0;
		}
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckIP(byte[] byte_0);

    public static string CheckIP(string api)
    {
        string text = "";
        try
        {
            RequestHttp gclass = new RequestHttp("", "", "", 0);
            string text2 = gclass.RequestGet("http://lumtest.com/myip.json");
            text = JObject.Parse(text2)["ip"].ToString();
        }
        catch
        {
        }
        return text;
    }

    public static string CheckIP(string proxy, int typeProxy, int timeOut = 30)
	{
        //return CheckIP(proxy + "*" + typeProxy);
        string result = "";
        int tickCount = Environment.TickCount;
        List<string> list = new List<string> { "https://api64.ipify.org/", "http://v4v6.ipv6-test.com/api/myip.php/", "https://api.myip.com/" };
        while (Environment.TickCount - tickCount < timeOut * 1000)
        {
            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    RequestXNet requestXNet = new RequestXNet("", SetupFolder.GetUseragentIphone(), proxy, typeProxy);
                    requestXNet.httpRequest.Proxy.ConnectTimeout = 5000;
                    requestXNet.httpRequest.Proxy.ReadWriteTimeout = 5000;
                    requestXNet.httpRequest.ConnectTimeout = 5000;
                    requestXNet.httpRequest.ReadWriteTimeout = 5000;
                    requestXNet.httpRequest.KeepAliveTimeout = 5000;
                    result = requestXNet.RequestGet(list[i]);
                    return result;
                }
                catch
                {
                }
                if (Environment.TickCount - tickCount >= timeOut * 1000)
                {
                    break;
                }
            }
            Common.Sleep(1.0);
        }
        return result;
    }

	public static void F9202C12(RichTextBox richTextBox_0, Label CF11F20B, int int_0 = 0)
	{
		try
		{
			string text = CF11F20B.Text;
			List<string> list = new List<string>();
			CF11F20B.Text = text.Replace(newValue: "(" + ((int_0 != 0) ? richTextBox_0.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : richTextBox_0.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()).Count + ")", oldValue: Regex.Match(text, "\\((.*?)\\)").Value);
		}
		catch
		{
		}
	}

	public static void BE3BB914(Control control_0, int int_0)
	{
		try
		{
			string text = control_0.Text;
			control_0.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + int_0 + ")");
		}
		catch
		{
		}
	}

	public static void smethod_49(RichTextBox richTextBox_0, Control control_0, int int_0 = 0)
	{
		try
		{
			string text = control_0.Text;
			List<string> list = richTextBox_0.Lines.ToList();
			control_0.Text = text.Replace(newValue: "(" + ((int_0 != 0) ? richTextBox_0.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : richTextBox_0.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()).Count + ")", oldValue: Regex.Match(text, "\\((.*?)\\)").Value);
		}
		catch
		{
		}
	}

	public static void ExportError(Chrome f336F52E_0, Exception exception_0, string string_0 = "")
	{
		try
		{
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\html"))
			{
				Directory.CreateDirectory("log\\html");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			if (f336F52E_0 != null)
			{
				string contents = f336F52E_0.GetPageSource();
				f336F52E_0.ScreenCapture("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (string_0 != "")
			{
				streamWriter.WriteLine("Error: " + string_0);
			}
			streamWriter.WriteLine();
			if (exception_0 != null)
			{
				streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
				streamWriter.WriteLine("Message: " + exception_0.Message);
				streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
				exception_0 = exception_0.InnerException;
			}
		}
		catch
		{
		}
	}

	public static void ExportError2(Exception exception_0, string string_0 = "")
	{
		try
		{
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			if (string_0 != "")
			{
				streamWriter.WriteLine("Error: " + string_0);
			}
			streamWriter.WriteLine();
			if (exception_0 != null)
			{
				streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
				streamWriter.WriteLine("Message: " + exception_0.Message);
				streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
				exception_0 = exception_0.InnerException;
			}
		}
		catch
		{
		}
	}

	public static string smethod_52(string string_0, string D78206A9, int D81BC438 = 10)
	{
		Process process = new Process();
		process.StartInfo.FileName = string_0;
		process.StartInfo.Arguments = D78206A9;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
		process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
		StringBuilder stringBuilder_0 = new StringBuilder();
		process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				stringBuilder_0.Append(e.Data + "\n");
			}
		};
		process.Start();
		process.BeginOutputReadLine();
		if (D81BC438 < 0)
		{
			process.WaitForExit();
		}
		else
		{
			process.WaitForExit(D81BC438 * 1000);
		}
		process.Close();
		return stringBuilder_0.ToString();
	}

	public static bool ResetDcom(string string_0)
	{
		bool flag = false;
		string text = smethod_52("rasdial.exe", "\"" + string_0 + "\"", 3);
		if (text.Contains("Successfully connected to "))
		{
			flag = true;
		}
		else if (text.Contains("You are already connected to "))
		{
			for (int i = 0; i < 3; i++)
			{
				text = smethod_52("rasdial.exe", "\"" + string_0 + "\" /disconnect", 3);
				if (!(text.Trim() == "Command completed successfully."))
				{
					Sleep(1.0);
					continue;
				}
				flag = true;
				break;
			}
			Sleep(1.0);
			if (flag)
			{
				for (int j = 0; j < 3; j++)
				{
					text = smethod_52("rasdial.exe", "\"" + string_0 + "\"", 3);
					if (!text.Contains("Successfully connected to "))
					{
						Sleep(1.0);
						continue;
					}
					flag = true;
					break;
				}
			}
			Sleep(1.0);
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	public static bool ChangeIP(int int_0, int typeDcom, string profileDcom, string urlHilink, int int_2, string string_0)
	{
		bool result = false;
		string text = "";
		try
		{
			switch (int_0)
			{
			case 0:
				return true;
			case 1:
			{
				string text2 = CheckIP("");
				IntPtr intPtr = AutoControl.smethod_1(null, "HMA VPN");
				AutoControl.ShowWindow(intPtr, 1);
				AutoControl.F72F0AA9(intPtr);
				Thread.Sleep(1000);
				AutoControl.SendClickOnPosition(AutoControl.E8AA0231(intPtr, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				Thread.Sleep(5000);
				string text3 = CheckIP("");
				AutoControl.SendClickOnPosition(AutoControl.E8AA0231(intPtr, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				int tickCount = Environment.TickCount;
				do
				{
					text = CheckIP("");
				}
				while (Environment.TickCount - tickCount <= 20000 && (text == text2 || text == text3));
				if (text != text2)
				{
					result = true;
				}
				break;
			}
			case 2:
			{
				if (typeDcom == 0)
				{
					result = ResetDcom(profileDcom);
					break;
				}
				int num = ResetHilink(urlHilink);
				if (num == 0)
				{
					Thread.Sleep(2000);
					num = ResetHilink(urlHilink);
				}
				result = num == 1;
				break;
			}
			}
		}
		catch (Exception exception_)
		{
			ExportError(null, exception_, "Error ChangeIP");
		}
		return result;
	}

	public static int ResetHilink(string string_0)
	{
		int result = -1;
		try
		{
			string value = Regex.Match(string_0, "(http://.*?)/").Groups[1].Value;
			if (value == "")
			{
				value = Regex.Match(string_0, "(https://.*?)/").Groups[1].Value;
			}
			RequestHttp requestHttp = new RequestHttp("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36");
			string input = requestHttp.RequestGet(value);
			string text = "";
			try
			{
				text = Regex.Matches(input, "csrf_token\" content=\"(.*?)\"")[1].Groups[1].Value;
			}
			catch
			{
				text = Regex.Match(requestHttp.RequestGet(value + "/api/webserver/token"), "<token>(.*?)</token>").Groups[1].Value;
			}
			input = requestHttp.RequestGet(value + "/api/dialup/mobile-dataswitch");
			string text2 = "";
			if (input.Contains("dataswitch>1"))
			{
				text2 = input.Replace("response", "request").Replace("dataswitch>1", "dataswitch>0");
			}
			else
			{
				if (!input.Contains("dataswitch>0"))
				{
					return -1;
				}
				text2 = input.Replace("response", "request").Replace("dataswitch>0", "dataswitch>1");
			}
			requestHttp.requestHTTP.SetDefaultHeaders(new string[2]
			{
				"__RequestVerificationToken: " + text,
				"content-type: text/xml"
			});
			string text3 = requestHttp.RequestPost(value + "/api/dialup/mobile-dataswitch", text2);
			if (text3.Contains("OK"))
			{
				input = requestHttp.RequestGet(value + "/api/dialup/mobile-dataswitch");
				if (input.Contains("dataswitch>1<"))
				{
					for (int i = 0; i < 10; i++)
					{
						string text4 = requestHttp.RequestGet(value + "/api/monitoring/traffic-statistics");
						if (!text4.Contains("<CurrentUpload>0"))
						{
							break;
						}
						Thread.Sleep(1000);
					}
				}
				return Convert.ToInt32(Regex.Match(input, "dataswitch>(.*?)<").Groups[1].Value);
			}
			result = -1;
		}
		catch
		{
		}
		return result;
	}

	public static DateTime ConvertStringToDatetime(string string_0, string A91783B0 = "dd/MM/yyyy HH:mm:ss")
	{
		return DateTime.ParseExact(string_0, A91783B0, CultureInfo.InvariantCulture);
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetTotp(byte[] byte_0);

    public static string GetTotp(string key)
    {
        //return GetListHoEN(GetTotp(B2B3DBBA(E7047321)));
        return JObject.Parse(new WebClient().DownloadString("https://2fa.live/tok/" + key))["token"].ToString().Trim();
    }
    public static DataTable CopyToDataTable(DataTable FEAF691C)
	{
		DataTable result = new DataTable();
		try
		{
			result = (from DataRow BE17A039 in FEAF691C.Rows
				orderby Base.rd.Next()
				select BE17A039).CopyToDataTable();
		}
		catch
		{
		}
		return result;
	}

	public static bool CopyFolder(string pathFrom, string pathTo)
	{
		try
		{
			CreateFolder(pathTo);
			string[] directories = Directory.GetDirectories(pathFrom, "*", SearchOption.AllDirectories);
			foreach (string text in directories)
			{
				Directory.CreateDirectory(text.Replace(pathFrom, pathTo));
			}
			string[] files = Directory.GetFiles(pathFrom, "*.*", SearchOption.AllDirectories);
			foreach (string text2 in files)
			{
				File.Copy(text2, text2.Replace(pathFrom, pathTo), overwrite: true);
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool MoveFile(string C63B4928, string string_0)
	{
		try
		{
			Directory.Move(C63B4928, string_0);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool DeleteFile(string string_0)
	{
		try
		{
			Directory.Delete(string_0, recursive: true);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void DeleteFile(string string_0, string string_1)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (directoryInfo2.Name.StartsWith(string_1))
				{
					DeleteFile(string_0 + "\\" + directoryInfo2.Name);
				}
			}
		}
		catch
		{
		}
	}

	public static bool smethod_62(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0 == "")
		{
			return false;
		}
		return string_0 != ConvertToUnSign(string_0) && B7179305(string_0);
	}

	public static bool B7179305(string string_0)
	{
		bool result = true;
		string text = " abcdeghiklmnopqrstuvxyABCDEGHIKLMNOPQRSTUVXYaAeEoOuUiIdDyYáàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐÐýỳỵỷỹÝỲỴỶỸ";
		foreach (char value in string_0)
		{
			if (!text.ToCharArray().Contains(value))
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string ConvertToUnSign(string string_0)
	{
		Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
		string input = string_0.Normalize(NormalizationForm.FormD);
		return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
	}

	public static bool DeleteFilex(string string_0)
	{
		try
		{
			File.Delete(string_0);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool A7055AA2(List<string> list_0)
	{
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				DeleteFilex(list_0[i]);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_64()
	{
		string result = "";
		string newValue = "chrome.exe";
		object value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\<executableFileName>".Replace("<executableFileName>", newValue), "", null);
		if (value == null)
		{
			value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\<executableFileName>".Replace("<executableFileName>", newValue), "", null);
			if (value != null)
			{
				result = value.ToString();
			}
		}
		else
		{
			result = value.ToString();
		}
		return result;
	}

	public static string smethod_65()
	{
		return FileVersionInfo.GetVersionInfo(smethod_64().ToString()).FileVersion;
	}

	internal static int DelayRandom(int int_0, int int_1)
	{
		if (int_0 > int_1)
		{
			return Base.rd.Next(int_1, int_0 + 1);
		}
		return Base.rd.Next(int_0, int_1 + 1);
	}

	public static Form smethod_66(string B333362F, params object[] AB1CC521)
	{
		Type type = Type.GetType("maxcare." + B333362F);
		if (type != null)
		{
			try
			{
				return (Form)Activator.CreateInstance(type, AB1CC521);
			}
			catch (Exception)
			{
			}
		}
		return null;
	}

	public static IEnumerable<Control> B71A07A6(Control EAB37EAD)
	{
		IEnumerable<Control> enumerable = EAB37EAD.Controls.Cast<Control>();
		return enumerable.SelectMany((Control control_0) => B71A07A6(control_0)).Concat(enumerable);
	}

	internal static void E885AF8B(string string_0, string string_1, bool bool_0)
	{
		try
		{
			File.Copy(string_0, string_1, bool_0);
		}
		catch
		{
		}
	}

	public static void ChangeMD5(string string_0)
	{
		try
		{
			int num = Base.rd.Next(2, 7);
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = 0;
			}
			long length = new FileInfo(string_0).Length;
			if ((ulong)length <= 0uL)
			{
				return;
			}
			using (FileStream fileStream = new FileStream(string_0, FileMode.Append))
			{
				fileStream.Write(array, 0, array.Length);
			}
			int bufferSize = ((length > 1048576L) ? 1048576 : 4096);
			using MD5 mD = MD5.Create();
			using FileStream inputStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize);
			BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "");
		}
		catch
		{
		}
	}

	public static string F6082C1C(string C62798B6)
	{
		string result = "";
		try
		{
			long length = new FileInfo(C62798B6).Length;
			int bufferSize = ((length > 1048576L) ? 1048576 : 4096);
			using MD5 mD = MD5.Create();
			using FileStream inputStream = new FileStream(C62798B6, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize);
			result = BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "");
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_68(string string_0, List<string> list_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (string_0.Contains(list_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return list_0[num];
	}

	public static void smethod_69(ref DataGridView dataGridView_0, int E408C914, int B3152233, int C4B33617 = 1)
	{
		string text = "";
		for (int i = C4B33617; i < dataGridView_0.Columns.Count; i++)
		{
			text = DatagridviewHelper.GetStatusDataGridView(dataGridView_0, E408C914, i);
			DatagridviewHelper.smethod_5(dataGridView_0, E408C914, i, DatagridviewHelper.GetStatusDataGridView(dataGridView_0, B3152233, i));
			DatagridviewHelper.smethod_5(dataGridView_0, B3152233, i, text);
		}
	}

	internal static List<string> GetFiles(string AD82AD92)
	{
		if (Directory.Exists(AD82AD92))
		{
			return Directory.GetFiles(AD82AD92).ToList();
		}
		return new List<string>();
	}

	internal static void CA2A5A03(string E9011308)
	{
		try
		{
			Process.Start("chrome.exe", E9011308);
		}
		catch
		{
			Process.Start(E9011308);
		}
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CloneDatabase(byte[] byte_0, byte[] byte_1);

	public static bool CloneDatabase()
	{
        bool result = false;

        string text = Base.txtPathMaxCare + "\\database\\db_maxcare.sqlite";
		string fileName = Path.GetFileName(text);
		string text2 = SettingsTool.GetSettings("configInteractGeneral").GetValue("txtBackupDBPath", Environment.GetEnvironmentVariable("LocalAppData") + "\\database");
		CreateFolder(text2);
		if (!Directory.Exists(text2))
		{
			text2 = Environment.GetEnvironmentVariable("LocalAppData") + "\\database";
			CreateFolder(text2);
		}
		string a0988CA = text2 + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName;
		CloneDatabaseHelper.CloneDatabase("database\\db_maxcare.sqlite", text2);
        return result;
	}

	public static string smethod_71()
	{
		string a319C18F = DateTime.Now.ToString("yyMMdd") + CreateRandomNumber(4) + CreateRandomString(5);
		if (SettingsTool.GetSettings("configCheckpoint").GetValueInt("typePass") == 0)
		{
			a319C18F = SettingsTool.GetSettings("configCheckpoint").GetValue("txtPass");
		}
		return a319C18F.RandomChar(1);
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr DownloadImage282(byte[] BB932B8D, byte[] CE338D0A);

    public static string DownloadImage282(string txtImageUrl, string txtPathFolder)
    {
        Random rd = new Random();
        string result = "";
        string prx = "";
        string uid = "photo_" + rd.Next(1, 99999);

        string requestUriString = "https://api.unrealperson.com/person";
        try
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
            if (prx != "")
            {
                if (prx.Split(':').Length <= 2)
                {
                    httpWebRequest.Proxy = new WebProxy(prx);
                }
                else
                {
                    httpWebRequest.Proxy = new WebProxy(prx.Split(':')[0] + ":" + prx.Split(':')[1]);
                    httpWebRequest.Proxy.Credentials = new NetworkCredential(prx.Split(':')[2], prx.Split(':')[3]);
                }
            }
            httpWebRequest.KeepAlive = true;
            httpWebRequest.Host = "api.unrealperson.com";
            httpWebRequest.Headers["Origin"] = "https://www.unrealperson.com";
            httpWebRequest.Referer = "https://www.unrealperson.com/";
            httpWebRequest.Headers["sec-ch-ua"] = "\"Chromium\";v=\"110\", \"Not A(Brand\";v=\"24\", \"Google Chrome\";v=\"110\"";
            httpWebRequest.Headers["sec-ch-ua-mobile"] = "?0";
            httpWebRequest.Headers["sec-ch-ua-platform"] = "\"Windows\"";
            httpWebRequest.Headers["Sec-Fetch-Dest"] = "empty";
            httpWebRequest.Headers["Sec-Fetch-Mode"] = "cors";
            httpWebRequest.Headers["Sec-Fetch-Site"] = "same-site";
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string text = streamReader.ReadToEnd();
            if (!text.Contains("image_url"))
            {
                return "";
            }
            string value = Regex.Match(text, "image_url\":\"(.*?)\"").Groups[1].Value;
            if (!(value != "") || value == null)
            {
                return "";
            }
            string address = "https://api.unrealperson.com/image?name=" + value + "&type=tpdne";
            WebClient webClient = new WebClient();
            webClient.Headers["keep-alive"] = "true";
            webClient.Headers["Host"] = "api.unrealperson.com";
            webClient.Headers["Origin"] = "https://www.unrealperson.com";
            webClient.Headers["Referer"] = "https://www.unrealperson.com/";
            webClient.Headers["sec-ch-ua"] = "\"Chromium\";v=\"110\", \"Not A(Brand\";v=\"24\", \"Google Chrome\";v=\"110\"";
            webClient.Headers["sec-ch-ua-mobile"] = "?0";
            webClient.Headers["sec-ch-ua-platform"] = "\"Windows\"";
            webClient.Headers["Sec-Fetch-Dest"] = "empty";
            webClient.Headers["Sec-Fetch-Mode"] = "cors";
            webClient.Headers["Sec-Fetch-Site"] = "same-site";
            webClient.Headers["UserAgent"] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";
            Stream stream = webClient.OpenRead(address);
            new Bitmap(stream)?.Save(txtPathFolder + "\\" + uid + ".png");
            stream.Flush();
            stream.Close();
            webClient.Dispose();
        }
        catch
        {
            return "";
        }
        return "ok";
    }

    public static string smethod_72(string string_0)
	{
		return Regex.Replace(string_0, "\\p{Cs}", "");
	}

	public static bool CheckStringIsContainIcon(string string_0)
	{
		return string_0.Length != Regex.Replace(string_0, "\\p{Cs}", "").Length;
	}
    //public string CheckPrimaryLocation()
    //{
    //    Chrome chrome = new Chrome();
    //    string text = "";
    //    try
    //    {
    //        text = Regex.Match(chrome.RequestGetHelper("https://www.facebook.com/primary_location/info/"), GetText("regex_primary_location")).Groups[1].Value;
    //        text = Regex.Unescape(text);
    //    }
    //    catch
    //    {
    //    }
    //    return text;
    //}
 //   [DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	//private static extern IntPtr DeleteTempFile();

	internal static void DeleteTempFile()
	{
        //MinsoftLib.Common.DeleteTempFile();

        DeleteFile("C:\\Program Files", "chrome_BITS_");
        DeleteFile("C:\\Program Files (x86)", "scoped_dir");
        DeleteFile("C:\\Windows\\SystemTemp", "chrome_BITS_");
        //DeleteFile("C:\\Program Files", "chrome_ComponentUnpacker_");
        //DeleteFile("C:\\Program Files", "chrome_url_fetcher_");
        DeleteFile("C:\\Program Files (x86)", "scoped_dir");
    }
    public static string Getphone()
    {
        return "\n\tasync function RequestGet(url) {\n\t\tvar output = '';\n\t\ttry {\n\t\t\tvar response = await fetch(url);\n\t\t\tif (response.ok) {\n\t\t\t\tvar body = await response.text();\n\t\t\t\treturn body;\n\t\t\t}\n\t\t} catch { }\n\t\treturn output;\n\t};\n\n\tvar html = await RequestGet('https://mbasic.facebook.com/settings/sms/');\n\thtml = unescape(html).replace(/&amp;/g, '&')\n\n\tvar el = document.createElement('html');\n\tel.innerHTML = html;\n\tvar phone = [];\n\tel.querySelectorAll('[href*=\"/settings/sms/?remove\"]').forEach(e => phone.push(e.getAttribute('href').match(new RegExp('&phone_number=(.*?)&'))[1]));\n\treturn phone.join('|');";
    }
    public static string Getemail()
    {
        return "\n\tasync function RequestGet(url) {\n\t\tvar output = '';\n\t\ttry {\n\t\t\tvar response = await fetch(url);\n\t\t\tif (response.ok) {\n\t\t\t\tvar body = await response.text();\n\t\t\t\treturn body;\n\t\t\t}\n\t\t} catch { }\n\t\treturn output;\n\t};\n\n\tvar html = await RequestGet('https://mbasic.facebook.com/settings/email/');\n\thtml = unescape(html).replace(/&amp;/g, '&')\n\n\tvar el = document.createElement('html');\n\tel.innerHTML = html;\n\tvar email = [];\n\tel.querySelectorAll('[href*=\"/settings/email/?remove\"]').forEach(e => email.push(e.getAttribute('href').match(new RegExp('&email=(.*?)&'))[1]));\n\treturn email.join('|');";
    }

    public static string Check_friend_page_ads(string string_10, string string_11, string string_12, string string_13)
    {
        return "\n\tasync function RequestGet(url) {\n\t\tvar output = '';\n\t\ttry {\n\t\t\tvar response = await fetch(url);\n\t\t\tif (response.ok) {\n\t\t\t\tvar body = await response.text();\n\t\t\t\treturn body;\n\t\t\t}\n\t\t} catch { }\n\t\treturn output;\n\t};\n\n\tfriend = '{friend}'\n\tpage = '{page}'\n\tads = '{ads}'\n\tfields = ''\n\tif (friend == '')\n\t\tfields += 'friends.limit(0).summary(1),'\n\tif (page == '')\n\t\tfields += 'accounts.limit(0).summary(1),'\n\tif (ads == '')\n\t\tfields += 'adaccounts.limit(2){account_status,adtrust_dsl,currency,min_billing_threshold{amount}},'\n\tif (fields == '')\n\t\treturn ''\n\tfields = fields.slice(0, -1)\n\turl = 'https://graph.facebook.com/v18.0/me?fields='+fields+'&access_token={token}';\n\tc = await RequestGet(url);\n\n\tif (page == '')\n\t\tpage = JSON.parse(c)['accounts']['summary']['total_count']\n\tif (friend == '')\n\t\tfriend = JSON.parse(c)['friends']['summary']['total_count']\n\tif (ads == ''){\n\t\taccount_status = JSON.parse(c)['adaccounts']['data'][0]['account_status'].toString()\n\t\tswitch (account_status) {\n\t\t\tcase '1':\n\t\t\t\tads = 'Live|'\n\t\t\t\tbreak;\n\t\t\tcase '2':\n\t\t\t\tads = 'Die|'\n\t\t\t\tbreak;\n\t\t\tcase '100':\n\t\t\t\tads = 'Pending closed|'\n\t\t\t\tbreak;\n\t\t\tcase '101':\n\t\t\t\tads = 'Closed|'\n\t\t\t\tbreak;\n\t\t\tdefault:\n\t\t\t\tads = 'Unknow|'\n\t\t\t\tbreak;\t\n\t\t}\n\n\t\tcurrency = JSON.parse(c)['adaccounts']['data'][0]['currency']\n\t\tnguong = JSON.parse(c)['adaccounts']['data'][0]['min_billing_threshold']['amount']\n\t\tads += nguong + \" \"+currency\n\t\tads += \"|\"\n\n\t\tadtrust_dsl = JSON.parse(c)['adaccounts']['data'][0]['adtrust_dsl']\n\t\tif (adtrust_dsl == \"-1\")\n\t\t\tads += \"Nolimit\";\n\t\telse\n\t\t\tads += adtrust_dsl + \" \" + currency;\n\t}\n\n\tconst obj = {\n\t\tfriend: friend,\n\t\tpage: page,\n\t\tads: ads\n\t};\n\treturn JSON.stringify(obj)\n\t".Replace("{token}", string_10).Replace("{friend}", string_11).Replace("{page}", string_12)
            .Replace("{ads}", string_13);
    }
    public static string CheckBM(string jsonBM)
    {
        return "\n\tasync function RequestGet(url) {\n\t\tvar output = '';\n\t\ttry {\n\t\t\tvar response = await fetch(url);\n\t\t\tif (response.ok) {\n\t\t\t\tvar body = await response.text();\n\t\t\t\treturn body;\n\t\t\t}\n\t\t} catch { }\n\t\treturn output;\n\t};\n\n\turl = 'https://graph.facebook.com/v18.0/me/businesses?fields=id&limit=5000&access_token={token}';\n\tc = await RequestGet(url);\n\treturn JSON.parse(c)['data'].length\n\t".Replace("{token}", jsonBM);
    }
    public static string CheckDating()
    {
        return "\n\tasync function RequestGet(url) {\n\t\tvar output = '';\n\t\ttry {\n\t\t\tvar response = await fetch(url);\n\t\t\tif (response.ok) {\n\t\t\t\tvar body = await response.text();\n\t\t\t\treturn body;\n\t\t\t}\n\t\t} catch { }\n\t\treturn output;\n\t};\n\n\tvar html = await RequestGet('https://www.facebook.com/dating/get-started/');\n\tlet check = '';\n\tif (html.includes('download__section-heading')) check = 'Yes';\n\telse if (html.includes('unavailable__section-container')) check = 'No';\n\treturn check";

    }
    public static string CheckLocation()
    {
        return "\n\t\tvar spinR = require([\"SiteData\"]).__spin_r;\n\t\tvar spinB = require([\"SiteData\"]).__spin_b;\n\t\tvar spinT = require([\"SiteData\"]).__spin_t;\n\t\tvar jazoest = require([\"SprinkleConfig\"]).jazoest;\n\t\tvar fbdtsg = require([\"DTSGInitData\"]).token;\n\t\tvar userId = require([\"CurrentUserInitialData\"]).USER_ID;\n\t\tvar hsi = require([\"SiteData\"]).hsi;\n\t\tvar lsd = require([\"LSD\"]).token;\n\t\tvar defaultData = \"av=\"+userId+\"&__user=\"+userId+\"&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=\"+fbdtsg+\"&jazoest=22037&lsd=\"+lsd+\"&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern\";\n\n\tvar url = \"https://www.facebook.com/api/graphql/\";\n\tvar data = \"av=\"+userId+\"&__user=\"+userId+\"&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=\"+fbdtsg+\"&jazoest=\"+jazoest+\"&lsd=\"+lsd+\"&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern&variables=%7B%22privacySelectorRenderLocation%22%3A%22COMET_STREAM%22%2C%22renderLocation%22%3A%22timeline%22%2C%22scale%22%3A1.5%2C%22userID%22%3A%22\"+userId+\"%22%7D&server_timestamps=true&doc_id=8125724064106098\";\n\t\n\t\tasync function RequestPost() { \n\t\t\tvar output = ''; \n\t\t\ttry { \n\t\t\t\tvar response = await fetch(url, {\n\t\t\t\t\tmethod: 'POST',\n\t\t\t\t\tbody: data,\n\t\t\t\t\theaders: {'Content-Type': 'application/x-www-form-urlencoded'}\n\t\t\t\t}); \n\t\t\t\tif (response.ok) { \n\t\t\t\t\tvar body = await response.text(); \n\t\t\t\t\treturn body; \n\t\t\t\t} \n\t\t\t} catch {} \n\t\t\treturn output; \n\t\t}; \n\t\tvar c = await RequestPost(); \n\t\treturn c;\n";


    }
    public static string CheckPrimaryLocation()
    {
        return "\n\t\tvar spinR = require([\"SiteData\"]).__spin_r;\n\t\tvar spinB = require([\"SiteData\"]).__spin_b;\n\t\tvar spinT = require([\"SiteData\"]).__spin_t;\n\t\tvar jazoest = require([\"SprinkleConfig\"]).jazoest;\n\t\tvar fbdtsg = require([\"DTSGInitData\"]).token;\n\t\tvar userId = require([\"CurrentUserInitialData\"]).USER_ID;\n\t\tvar hsi = require([\"SiteData\"]).hsi;\n\t\tvar lsd = require([\"LSD\"]).token;\n\t\tvar defaultData = \"av=\"+userId+\"&__user=\"+userId+\"&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=\"+fbdtsg+\"&jazoest=22037&lsd=\"+lsd+\"&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern\";\n\n\tvar url = \"https://www.facebook.com/api/graphql/\";\n\tvar data = \"av=\"+userId+\"&__user=\"+userId+\"&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=\"+fbdtsg+\"&jazoest=\"+jazoest+\"&lsd=\"+lsd+\"&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern&variables=%7B%22privacySelectorRenderLocation%22%3A%22COMET_STREAM%22%2C%22renderLocation%22%3A%22timeline%22%2C%22scale%22%3A1.5%2C%22userID%22%3A%22\"+userId+\"%22%7D&server_timestamps=true&doc_id=8125724064106098\";\n\t\n\t\tasync function RequestPost() { \n\t\t\tvar output = ''; \n\t\t\ttry { \n\t\t\t\tvar response = await fetch(url, {\n\t\t\t\t\tmethod: 'POST',\n\t\t\t\t\tbody: data,\n\t\t\t\t\theaders: {'Content-Type': 'application/x-www-form-urlencoded'}\n\t\t\t\t}); \n\t\t\t\tif (response.ok) { \n\t\t\t\t\tvar body = await response.text(); \n\t\t\t\t\treturn body; \n\t\t\t\t} \n\t\t\t} catch {} \n\t\t\treturn output; \n\t\t}; \n\t\tvar c = await RequestPost(); \n\t\treturn c;\n";

    }
    public static string GetBase64Captcha()
    { return "var img=document.querySelector('#captcha > img');var d=document.createElement('canvas');d.height=70;d.width=280;var ctx=d.getContext('2d');ctx.drawImage(img,0,0);var x=d.toDataURL(); return x"; }
    public static string LTDSoftware()
    {
        return "document.querySelector('body').innerHTML='LTD SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'";
    }
}
