using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MinsoftLib;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class Chrome
{
	[Serializable]
	[CompilerGenerated]
	private sealed class AD3A1C88
	{
		public static readonly AD3A1C88 _003C_003E9 = new AD3A1C88();

		public static Func<string, Guid> _003C_003E9__276_0;

		public static Func<string, Guid> _003C_003E9__276_1;

		public static Func<string, Guid> _003C_003E9__276_2;

		internal Guid A690F18E(string D8849F0A)
		{
			return Guid.NewGuid();
		}

		internal Guid method_0(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_1(string string_0)
		{
			return Guid.NewGuid();
		}
	}

	[CompilerGenerated]
	private sealed class Class6
	{
		public string C1240F05;

		public Func<Process, bool> BAAC0D1D;

		internal bool method_0(Process CD3DE091)
		{
			return CD3DE091.MainWindowTitle.Contains(C1240F05);
		}
	}

	[CompilerGenerated]
	private sealed class B8390399
	{
		public List<string> list_0;

		public List<string> A21DE59F;
	}

	[CompilerGenerated]
	private sealed class Class7
	{
		public string string_0;

		public string string_1;

		public string D282268C;

		public int int_0;

		public int int_1;

		public B8390399 b8390399_0;
	}

	[CompilerGenerated]
	private sealed class Class8
	{
		public int DC2E9580;

		public Class7 D29ED0BC;

		internal void method_0()
		{
			try
			{
				bool flag = false;
				string text = D29ED0BC.b8390399_0.list_0[DC2E9580].Split('|')[0];
				RequestXNet fB87CFA = new RequestXNet(D29ED0BC.string_0, D29ED0BC.string_1, D29ED0BC.D282268C, D29ED0BC.int_0);
				string text2 = fB87CFA.RequestGet("https://mbasic.facebook.com/groups/" + text + "/madminpanel");
				if (text2.Contains("/help/contact/571927962827151") || text2.Contains("madminpanel/pending/"))
				{
					flag = true;
				}
				lock (D29ED0BC.b8390399_0.A21DE59F)
				{
					D29ED0BC.b8390399_0.A21DE59F.Add(D29ED0BC.b8390399_0.list_0[DC2E9580] + "|" + flag);
				}
			}
			catch
			{
			}
			Interlocked.Decrement(ref D29ED0BC.int_1);
		}
	}

	public int IndexChrome;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Process A2BDBA84;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Process process_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal ChromeDriver A909A5B8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool EE8DC698;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool A5A50CB0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool BFB3D8B6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool ECAD223E;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string AD30A339;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point E3AAD00E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point point_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool D3071E91;

	private string string_1;

	private int A913A7A8;

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private string C6AAE28C = "";

	private bool bool_1 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_2 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_3 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string BC18C125;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int F33FABBE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string C688AB0C;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal double double_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point AF22A10E;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal StatusChromeAccount genum1_0;

	private int int_3 = 0;

	private int int_4 = 0;

	private int int_5 = 0;

	private int CCBFAD0B = 0;

	private string string_9 = "";

	private const string string_10 = "\r\n            function callbackFn(details)\r\n            {\r\n\t            return {\r\n\t\t            {Auth}\r\n\t            };\r\n            }\r\n            chrome.webRequest.onAuthRequired.addListener(\r\n\t            callbackFn,\r\n\t            { urls:[\"<all_urls>\"] },\r\n                ['blocking']\r\n            );";

	private const string string_11 = "\r\n            {\r\n                \"version\": \"1.0.0\",\r\n                \"manifest_version\": 2,\r\n                \"name\": \"Chrome Proxy\",\r\n                \"permissions\": [\r\n                    \"proxy\",\r\n                    \"tabs\",\r\n                    \"unlimitedStorage\",\r\n                    \"storage\",\r\n                    \"<all_urls>\",\r\n                    \"webRequest\",\r\n                    \"webRequestBlocking\"\r\n                ],\r\n                \"background\": {\r\n                    \"scripts\": [\"background.js\"]\r\n\t            },\r\n                \"minimum_chrome_version\":\"22.0.0\"\r\n            }";

	public Process Process_0
	{
		[CompilerGenerated]
		get
		{
			return A2BDBA84;
		}
		[CompilerGenerated]
		set
		{
			A2BDBA84 = value;
		}
	}

	public Process BE38893F
	{
		[CompilerGenerated]
		get
		{
			return process_0;
		}
		[CompilerGenerated]
		set
		{
			process_0 = value;
		}
	}

	public ChromeDriver chromeDriver
	{
		[CompilerGenerated]
		get
		{
			return A909A5B8;
		}
		[CompilerGenerated]
		set
		{
			A909A5B8 = value;
		}
	}

	public bool HideBrowser
	{
		[CompilerGenerated]
		get
		{
			return EE8DC698;
		}
		[CompilerGenerated]
		set
		{
			EE8DC698 = value;
		}
	}

	public bool Incognito
	{
		[CompilerGenerated]
		get
		{
			return A5A50CB0;
		}
		[CompilerGenerated]
		set
		{
			A5A50CB0 = value;
		}
	}

	public bool DisableImage
	{
		[CompilerGenerated]
		get
		{
			return BFB3D8B6;
		}
		[CompilerGenerated]
		set
		{
			BFB3D8B6 = value;
		}
	}

	public bool DisableSound
	{
		[CompilerGenerated]
		get
		{
			return ECAD223E;
		}
		[CompilerGenerated]
		set
		{
			ECAD223E = value;
		}
	}

	public bool AutoPlayVideo
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public string UserAgent
	{
		[CompilerGenerated]
		get
		{
			return AD30A339;
		}
		[CompilerGenerated]
		set
		{
			AD30A339 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public string ProfilePath
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public Point Size
	{
		[CompilerGenerated]
		get
		{
			return E3AAD00E;
		}
		[CompilerGenerated]
		set
		{
			E3AAD00E = value;
		}
	}

	public Point Position
	{
		[CompilerGenerated]
		get
		{
			return point_0;
		}
		[CompilerGenerated]
		set
		{
			point_0 = value;
		}
	}

	private bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return D3071E91;
		}
		[CompilerGenerated]
		set
		{
			D3071E91 = value;
		}
	}

	public string cId
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public int Row
	{
		get
		{
			return A913A7A8;
		}
		set
		{
			A913A7A8 = value;
		}
	}

	public string cUid
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public string cPassword
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public string cFa2
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	public string cToken
	{
		get
		{
			return C6AAE28C;
		}
		set
		{
			C6AAE28C = value;
		}
	}

	public bool Boolean_2
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public bool Boolean_3
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool EEB3408F
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public string Proxy
	{
		[CompilerGenerated]
		get
		{
			return BC18C125;
		}
		[CompilerGenerated]
		set
		{
			BC18C125 = value;
		}
	}

	public int TypeProxy
	{
		[CompilerGenerated]
		get
		{
			return F33FABBE;
		}
		[CompilerGenerated]
		set
		{
			F33FABBE = value;
		}
	}

	public string App
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	public string LinkToOtherBrowser
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
		[CompilerGenerated]
		set
		{
			string_6 = value;
		}
	}

	public string PathExtension
	{
		[CompilerGenerated]
		get
		{
			return string_7;
		}
		[CompilerGenerated]
		set
		{
			string_7 = value;
		}
	}

	public bool IsUseEmulator
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public bool IsUsePortable
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public string PathToPortableZip
	{
		[CompilerGenerated]
		get
		{
			return C688AB0C;
		}
		[CompilerGenerated]
		set
		{
			C688AB0C = value;
		}
	}

	public double Double_0
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
		[CompilerGenerated]
		set
		{
			double_0 = value;
		}
	}

	public Point Size_Emulator
	{
		[CompilerGenerated]
		get
		{
			return AF22A10E;
		}
		[CompilerGenerated]
		set
		{
			AF22A10E = value;
		}
	}

	public int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public string String_7
	{
		[CompilerGenerated]
		get
		{
			return string_8;
		}
		[CompilerGenerated]
		set
		{
			string_8 = value;
		}
	}

	public StatusChromeAccount Status
	{
		[CompilerGenerated]
		get
		{
			return genum1_0;
		}
		[CompilerGenerated]
		set
		{
			genum1_0 = value;
		}
	}

	public Chrome()
	{
		IndexChrome = 0;
		HideBrowser = false;
		DisableImage = false;
		DisableSound = true;
		Incognito = false;
		UserAgent = "";
		ProfilePath = "";
		Size = new Point(300, 300);
		Size = new Point(Size.X, Size.Y);
		Proxy = "";
		TypeProxy = 0;
		Position = new Point(Position.X, Position.Y);
		App = "";
		AutoPlayVideo = false;
		LinkToOtherBrowser = "";
		PathExtension = "data\\extension";
		IsUseEmulator = false;
		Size_Emulator = new Point(300, 300);
		Status = StatusChromeAccount.Empty;
		IsUsePortable = false;
		PathToPortableZip = "";
		Double_0 = 1.0;
	}

	public (bool success, string error) Open()
	{
		if (SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").Contains("x"))
		{
			IsUseEmulator = true;
			string text = SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").Substring(0, SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").LastIndexOf('x'));
			int int32_ = Convert.ToInt32(SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").Split('x')[2]);
			Size_Emulator = new Point(Convert.ToInt32(text.Split('x')[0]), Convert.ToInt32(text.Split('x')[1]));
			Int32_0 = int32_;
			UserAgent = UserAgent;
		}
		LinkToOtherBrowser = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkToOtherBrowser").Trim();
		IsUsePortable = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUsePortable");
		PathToPortableZip = SettingsTool.GetSettings("configGeneral").GetValue("txtPathToPortableZip");
		if (!HideBrowser)
		{
			HideBrowser = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbHideBrowser");
		}
		if (Boolean_3 || EEB3408F)
		{
			DisableImage = false;
			HideBrowser = false;
		}
		if (HideBrowser)
		{
			DisableImage = true;
		}
		bool item = false;
		try
		{
			ChromeOptions chromeOptions = new ChromeOptions();
			int_5 = Size.X;
			CCBFAD0B = Size.Y;
			int_3 = Position.X;
			int_4 = Position.Y;
			chromeOptions.AddArguments("--window-size=" + Size.X + "," + Size.Y, "--window-position=" + Position.X + "," + Position.Y);
			chromeOptions.AddArguments("--disable-3d-apis", "--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--disable-webgl", "--enable-blink-features=ShadowDOMV0", "--enable-logging", "--disable-notifications", "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=BlockCredentialedSubresources", "--disable-popup-blocking", "--no-default-browser-check", "--no-first-run");
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 0);
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 0);
			if (DisableSound)
			{
				chromeOptions.AddArgument("--mute-audio");
			}
			chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
			chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
			chromeOptions.AddExcludedArgument("enable-automation");
			chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
			if (Double_0 != 1.0)
			{
				chromeOptions.AddArgument("--force-device-scale-factor=" + Double_0);
				chromeOptions.AddArgument("high-dpi-support=" + Double_0);
			}
			if (LinkToOtherBrowser != "" && File.Exists(LinkToOtherBrowser))
			{
				chromeOptions.BinaryLocation = LinkToOtherBrowser;
			}
			if (HideBrowser)
			{
				chromeOptions.AddArgument("--headless=new");
			}
			if (DisableImage)
			{
				chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
			}
			if (!string.IsNullOrEmpty(ProfilePath.Trim()))
			{
				if (IsUsePortable)
				{
					if (!Directory.Exists(ProfilePath))
					{
						ZipFile.ExtractToDirectory(PathToPortableZip, ProfilePath);
					}
					chromeOptions.BinaryLocation = ProfilePath + "\\App\\Chrome-bin\\chrome.exe";
					chromeOptions.AddArgument("--user-data-dir=" + ProfilePath + "\\Data\\profile");
				}
				else
				{
					try
					{
						chromeOptions.AddArgument("--user-data-dir=" + ProfilePath);
						Common.DeleteFilex(ProfilePath + "\\Default\\Preferences");
					}
					catch (Exception)
					{
					}
				}
			}
			if (Incognito)
			{
				chromeOptions.AddArguments("--incognito");
			}
			if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUseExtensionProxy"))
			{
				method_91(chromeOptions);
			}
			else if (!string.IsNullOrEmpty(Proxy.Trim()))
			{
				switch (Proxy.Split(':').Count())
				{
					case 1:
						chromeOptions.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + "127.0.0.1:" + Proxy);
						break;
					case 2:
						chromeOptions.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + Proxy);
						break;
					case 4:
						chromeOptions.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
						chromeOptions.AddExtension("extension\\proxy1.crx");
						break;
				}
			}
			if (!string.IsNullOrEmpty(UserAgent))
			{
				chromeOptions.AddArgument("--user-agent=" + UserAgent);
			}
			bool flag = false;
			if (PathExtension.Trim() != "")
			{
				if (!Directory.Exists(PathExtension))
				{
					Directory.CreateDirectory(PathExtension);
				}
				List<string> list = Common.GetFiles(PathExtension);
				if (list.Count > 0)
				{
					flag = true;
				}
				for (int i = 0; i < list.Count; i++)
				{
					chromeOptions.AddExtension(list[i]);
				}
			}
			if (!flag && !string.IsNullOrEmpty(App.Trim()))
			{
				chromeOptions.AddArgument("--app= " + App);
			}
			if (AutoPlayVideo)
			{
				chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
			}
			ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
			chromeDriverService.HideCommandPromptWindow = true;
			chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
			BE38893F = Process.GetProcessById(chromeDriverService.ProcessId);
			chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3.0);
			chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
			if (!HideBrowser)
			{
				GetProcess();
			}
			if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUseExtensionProxy") && Proxy.Split(':').Count() == 4)
			{
				ExecuteScript("document.title=\"proxyauth=" + Proxy + "\"");
				int num = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP");
				if (num < 3)
				{
					num = 3;
				}
				DelayTime(num);
				GotoURL("https://ifconfig.co/ip");
			}
			String_7 = chromeDriver.SessionId.ToString();
			Int32_3 = chromeDriverService.Port;
			item = true;
		}
		catch (Exception ex2)
		{
			if (ex2.ToString().Contains("session timed out after"))
			{
				Common.KillProcess("chrome");
				Common.KillProcess("chromedriver");
			}
			if (ex2.ToString().Contains("This version of ChromeDriver only supports Chrome version"))
			{
				return (item, "Update chromedriver");
			}
			ExportError(ex2, "chrome.Open()");
		}
		return (item, "");
	}
    public (bool success, string error) OpenHide()
    {
        if (SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").Contains("x"))
        {
            IsUseEmulator = true;
            string text = SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").Substring(0, SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").LastIndexOf('x'));
            int int32_ = Convert.ToInt32(SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome").Split('x')[2]);
            Size_Emulator = new Point(Convert.ToInt32(text.Split('x')[0]), Convert.ToInt32(text.Split('x')[1]));
            Int32_0 = int32_;
            UserAgent = UserAgent;
        }
        LinkToOtherBrowser = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkToOtherBrowser").Trim();
        IsUsePortable = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUsePortable");
        PathToPortableZip = SettingsTool.GetSettings("configGeneral").GetValue("txtPathToPortableZip");
        
        HideBrowser = true;
		DisableImage = true;
        //if (Boolean_3 || EEB3408F)
        //{
        //    DisableImage = false;
        //    HideBrowser = false;
        //}
        
        
        
        bool item = false;
        try
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            int_5 = Size.X;
            CCBFAD0B = Size.Y;
            int_3 = Position.X;
            int_4 = Position.Y;
            chromeOptions.AddArguments("--window-size=" + Size.X + "," + Size.Y, "--window-position=" + Position.X + "," + Position.Y);
            chromeOptions.AddArguments("--disable-3d-apis", "--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--disable-webgl", "--enable-blink-features=ShadowDOMV0", "--enable-logging", "--disable-notifications", "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=BlockCredentialedSubresources", "--disable-popup-blocking", "--no-default-browser-check", "--no-first-run");
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 0);
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 0);
            if (DisableSound)
            {
                chromeOptions.AddArgument("--mute-audio");
            }
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            chromeOptions.AddExcludedArgument("enable-automation");
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            if (Double_0 != 1.0)
            {
                chromeOptions.AddArgument("--force-device-scale-factor=" + Double_0);
                chromeOptions.AddArgument("high-dpi-support=" + Double_0);
            }
            if (LinkToOtherBrowser != "" && File.Exists(LinkToOtherBrowser))
            {
                chromeOptions.BinaryLocation = LinkToOtherBrowser;
            }
            if (HideBrowser)
            {
                chromeOptions.AddArgument("--headless=new");
            }
            if (DisableImage)
            {
                chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
            }
            if (!string.IsNullOrEmpty(ProfilePath.Trim()))
            {
                if (IsUsePortable)
                {
                    if (!Directory.Exists(ProfilePath))
                    {
                        ZipFile.ExtractToDirectory(PathToPortableZip, ProfilePath);
                    }
                    chromeOptions.BinaryLocation = ProfilePath + "\\App\\Chrome-bin\\chrome.exe";
                    chromeOptions.AddArgument("--user-data-dir=" + ProfilePath + "\\Data\\profile");
                }
                else
                {
                    try
                    {
                        chromeOptions.AddArgument("--user-data-dir=" + ProfilePath);
                        Common.DeleteFilex(ProfilePath + "\\Default\\Preferences");
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (Incognito)
            {
                chromeOptions.AddArguments("--incognito");
            }
            if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUseExtensionProxy"))
            {
                method_91(chromeOptions);
            }
            else if (!string.IsNullOrEmpty(Proxy.Trim()))
            {
                switch (Proxy.Split(':').Count())
                {
                    case 1:
                        chromeOptions.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + "127.0.0.1:" + Proxy);
                        break;
                    case 2:
                        chromeOptions.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + Proxy);
                        break;
                    case 4:
                        chromeOptions.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + Proxy.Split(':')[0] + ":" + Proxy.Split(':')[1]);
                        chromeOptions.AddExtension("extension\\proxy1.crx");
                        break;
                }
            }
            if (!string.IsNullOrEmpty(UserAgent))
            {
                chromeOptions.AddArgument("--user-agent=" + UserAgent);
            }
            bool flag = false;
            if (PathExtension.Trim() != "")
            {
                if (!Directory.Exists(PathExtension))
                {
                    Directory.CreateDirectory(PathExtension);
                }
                List<string> list = Common.GetFiles(PathExtension);
                if (list.Count > 0)
                {
                    flag = true;
                }
                for (int i = 0; i < list.Count; i++)
                {
                    chromeOptions.AddExtension(list[i]);
                }
            }
            if (!flag && !string.IsNullOrEmpty(App.Trim()))
            {
                chromeOptions.AddArgument("--app= " + App);
            }
            if (AutoPlayVideo)
            {
                chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
            }
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
            BE38893F = Process.GetProcessById(chromeDriverService.ProcessId);
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3.0);
            chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
            if (!HideBrowser)
            {
                GetProcess();
            }
            if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUseExtensionProxy") && Proxy.Split(':').Count() == 4)
            {
                ExecuteScript("document.title=\"proxyauth=" + Proxy + "\"");
                int num = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP");
                if (num < 3)
                {
                    num = 3;
                }
                DelayTime(num);
                GotoURL("https://ifconfig.co/ip");
            }
            String_7 = chromeDriver.SessionId.ToString();
            Int32_3 = chromeDriverService.Port;
            item = true;
        }
        catch (Exception ex2)
        {
            if (ex2.ToString().Contains("session timed out after"))
            {
                Common.KillProcess("chrome");
                Common.KillProcess("chromedriver");
            }
            if (ex2.ToString().Contains("This version of ChromeDriver only supports Chrome version"))
            {
                return (item, "Update chromedriver");
            }
            ExportError(ex2, "chrome.Open()");
        }
        return (item, "");
    }

    public void method_0()
	{
		User32Helper.ShowWindow(Process_0.MainWindowHandle, 6);
	}

	public string GetPageSource()
	{
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			return chromeDriver.PageSource;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return "";
	}

	public bool CheckIsLive()
	{
		if (Boolean_1)
		{
			return true;
		}
		if (Process_0 != null && Process_0.HasExited)
		{
			Boolean_1 = true;
		}
		return Boolean_1;
	}

	public string GetCssSelector(string BEB4F103, string BE22FE1D, string E6919B20)
	{
		string result = "";
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			result = chromeDriver.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + BEB4F103 + "','" + BE22FE1D + "','" + E6919B20 + "')").ToString();
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.GetCssSelector(" + BEB4F103 + "," + BE22FE1D + "," + E6919B20 + ")");
		}
		return result;
	}

	public string GetAttributeValue(string string_12, string string_13)
	{
		string result = "";
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			result = chromeDriver.ExecuteScript("return " + FindElement(string_12) + ".getAttribute('" + string_13 + "')").ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public string GetAttributeValue(string string_12)
	{
		string result = "";
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			result = ExecuteScript("return " + FindElement(string_12) + ".value").ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public string GetAttributeInnerText(string FE84113A)
	{
		string result = "";
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			result = ExecuteScript("return " + FindElement(FE84113A) + ".innerText").ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public int ScrollSmooth(int int_6)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			string text = ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString();
			ExecuteScript("window.scrollBy({ top: " + int_6 + ",behavior: 'smooth'});");
			DelayTime(0.1);
			if (text == ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString())
			{
				return 2;
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.ScrollSmooth({int_6})");
		}
		return 1;
	}

	public string GetUseragent()
	{
		string result = "";
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			result = chromeDriver.ExecuteScript("return navigator.userAgent").ToString();
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return result;
	}

	public int SendKeyDown(int int_6, string BE09C92B)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			switch (int_6)
			{
				case 1:
					chromeDriver.FindElementById(BE09C92B).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 2:
					chromeDriver.FindElementByName(BE09C92B).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 3:
					chromeDriver.FindElementByXPath(BE09C92B).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 4:
					chromeDriver.FindElementByCssSelector(BE09C92B).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeyDown({int_6},{BE09C92B})");
		}
		return flag ? 1 : 0;
	}

	public string GetURL()
	{
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			return chromeDriver.Url;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.GetURL()");
		}
		return "";
	}

	public int GotoURL(string string_12)
	{
		bool flag = false;
		for (int i = 0; i < 2; i++)
		{
			if (!CheckIsLive())
			{
				try
				{
					if (i == 0)
					{
						chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5.0);
					}
					else
					{
						chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
					}
					chromeDriver.Navigate().GoToUrl(string_12);
					flag = true;
				}
				catch (Exception exception_)
				{
					ExportError(exception_);
					continue;
				}
				break;
			}
			return -2;
		}
		chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
		return flag ? 1 : 0;
	}

	public int GotoURLIfNotExist(string string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (GetURL() != string_12)
			{
				chromeDriver.Navigate().GoToUrl(string_12);
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.GotoURL(" + string_12 + ")");
		}
		return flag ? 1 : 0;
	}

	public int Refresh()
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.Navigate().Refresh();
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.Refresh()");
		}
		return flag ? 1 : 0;
	}

	public int GotoBackPage(int int_6 = 1)
	{
		bool flag = false;
		try
		{
			for (int i = 0; i < int_6; i++)
			{
				if (!CheckIsLive())
				{
					chromeDriver.Navigate().Back();
					DelayTime(0.5);
					continue;
				}
				return -2;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.GotoBackPage()");
		}
		return flag ? 1 : 0;
	}

	public int HoverElement(int int_6, string CC9DA4B4, double CA22B6A8)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			WebDriverWait webDriverWait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10.0));
			switch (int_6)
			{
				case 1:
					new Actions(chromeDriver).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(CC9DA4B4)))).Perform();
					break;
				case 2:
					new Actions(chromeDriver).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(CC9DA4B4)))).Perform();
					break;
				case 3:
					new Actions(chromeDriver).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(CC9DA4B4)))).Perform();
					break;
				case 4:
					new Actions(chromeDriver).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(CC9DA4B4)))).Perform();
					break;
			}
			Thread.Sleep(Convert.ToInt32(CA22B6A8 * 1000.0));
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.HoverElement({int_6}, {CC9DA4B4}, {CA22B6A8})");
		}
		return flag ? 1 : 0;
	}

	public object ExecuteScript(string C8093289)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			return chromeDriver.ExecuteScript(C8093289);
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.ExecuteJS(" + C8093289 + ")");
		}
		return "";
	}
	public string RequestGetv2(string string_10, string string_11 = "")
	{
		try
		{
			if (string_11 == "")
			{
				string_11 = GetURL();
			}
			if (DomainFacebook(string_11) != DomainFacebook(string_10))
			{
				GotoURL(DomainFacebook(string_10));
				ExecuteScript("document.querySelector('body').innerHTML='LTD SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			string text = "async function RequestGet() { var output = ''; try { var response = await fetch('{url}'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;";
			text = text.Replace("{url}", string_10);
			return ExecuteScript(text).ToString();
		}
		catch
		{
		}
		return "";
	}
	public Image CaptureWindow(IntPtr A6157411)
	{
		IntPtr windowDC = User32.GetWindowDC(A6157411);
		User32.RECT AB2FC = default(User32.RECT);
		User32.GetWindowRect(A6157411, ref AB2FC);
		int e9B256AF = AB2FC.int_1 - AB2FC.A43AE48F;
		int num = AB2FC.int_2 - AB2FC.int_0;
		IntPtr intPtr = GDI32.CreateCompatibleDC(windowDC);
		IntPtr intPtr2 = GDI32.CreateCompatibleBitmap(windowDC, e9B256AF, num);
		IntPtr f3BA9A0E = GDI32.SelectObject(intPtr, intPtr2);
		GDI32.BitBlt(intPtr, 0, 0, e9B256AF, num, windowDC, 0, 0, 13369376);
		GDI32.SelectObject(intPtr, f3BA9A0E);
		GDI32.DeleteDC(intPtr);
		User32.ReleaseDC(A6157411, windowDC);
		Image result = Image.FromHbitmap(intPtr2);
		GDI32.DeleteObject(intPtr2);
		return result;
	}

	public Bitmap ScreenCapture(int int_6 = 1)
	{
		Bitmap result = null;
		try
		{
			for (int i = 0; i < int_6; i++)
			{
				try
				{
					result = (Bitmap)CaptureWindow(Process_0.MainWindowHandle);
				}
				catch (Exception exception_)
				{
					ExportError(exception_, "CaptureWindow");
					Common.Sleep(1.0);
					continue;
				}
				break;
			}
		}
		catch (Exception exception_2)
		{
			ExportError(exception_2, "AutoChrome.ScreenCapture()");
		}
		return result;
	}

	public string CheckExistElements(double double_1, List<string> list_0)
	{
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			int num = 0;
			int tickCount = Environment.TickCount;
			while (true)
			{
				num = ((!list_0[0].StartsWith("/") && !list_0[0].StartsWith("(/")) ? Convert.ToInt32(chromeDriver.ExecuteScript("var arr='" + string.Join("|", list_0) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); ")) : Convert.ToInt32(chromeDriver.ExecuteScript("var arr='" + string.Join("|", list_0) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.evaluate(arr[i], document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue != null) { output = i + 1; break;}; } return (output + '');")));
				if (num == 0)
				{
					if (!((double)(Environment.TickCount - tickCount) > double_1 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
				return list_0[num - 1];
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return "";
	}

	private bool StartWithXpath(string string_12)
	{
		if (string_12.StartsWith("("))
		{
			string_12 = string_12.TrimStart('(');
		}
		return string_12.StartsWith("/");
	}

	public string FindElement(string string_12)
	{
		if (StartWithXpath(string_12))
		{
			string_12 = string_12.Replace("'", "\\'");
			return "document.evaluate('" + string_12 + "', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue";
		}
		string text = "";
		string text2 = "";
		int num = 0;
		int num2 = 0;
		string[] array = string_12.Split('|');
		switch (array.Length)
		{
			case 1:
				text = array[0].Trim();
				break;
			case 2:
				text = array[0].Trim();
				num = Convert.ToInt32(array[1].Trim());
				break;
			case 3:
				text = array[0].Trim();
				num = Convert.ToInt32(array[1].Trim());
				text2 = array[2].Trim();
				break;
			case 4:
				text = array[0].Trim();
				num = Convert.ToInt32(array[1].Trim());
				text2 = array[2].Trim();
				num2 = Convert.ToInt32(array[3].Trim());
				break;
		}
		if (num2 == 0)
		{
			return string.Format("document.querySelectorAll('{0}')[{1}]", text.Replace("'", "\\'"), num);
		}
		return string.Format("document.querySelectorAll('{0}')[{1}].querySelectorAll('{2}')[{3}]", text.Replace("'", "\\'"), num, text2.Replace("'", "\\'"), num2);
	}

	public IWebElement GetElement(string string_12)
	{
		if (StartWithXpath(string_12))
		{
			return chromeDriver.FindElementByXPath(string_12);
		}
		string cssSelector = "";
		string cssSelectorToFind = "";
		int index = 0;
		int num = 0;
		string[] array = string_12.Split('|');
		switch (array.Length)
		{
			case 1:
				cssSelector = array[0].Trim();
				break;
			case 2:
				cssSelector = array[0].Trim();
				index = Convert.ToInt32(array[1].Trim());
				break;
			case 3:
				cssSelector = array[0].Trim();
				index = Convert.ToInt32(array[1].Trim());
				cssSelectorToFind = array[2].Trim();
				break;
			case 4:
				cssSelector = array[0].Trim();
				index = Convert.ToInt32(array[1].Trim());
				cssSelectorToFind = array[2].Trim();
				num = Convert.ToInt32(array[3].Trim());
				break;
		}
		if (num == 0)
		{
			return chromeDriver.FindElementsByCssSelector(cssSelector)[index];
		}
		return chromeDriver.FindElementsByCssSelector(cssSelector)[index].FindElements(By.CssSelector(cssSelectorToFind))[num];
	}

	public int method_12(int E1007105, string[] EA922D04)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			List<string> list = EA922D04.ToList();
			do
			{
				string text = CheckExistElements(E1007105, list);
				if (!(text == ""))
				{
					if (!(flag = Click(text)))
					{
						flag = ExecuteJSClick(text);
					}
					list.Remove(text);
					continue;
				}
				break;
			}
			while (!flag && list.Count > 0);
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public int ExecuteJSClickFB(int int_6 = 0, params string[] string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			string text = CheckExistElements(int_6, string_12.ToList());
			if (text != "")
			{
				flag = ExecuteJSClick(text);
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public int ClickWithActionAll(string string_12)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			IWebElement onElement = chromeDriver.FindElementByCssSelector(string_12);
			new Actions(chromeDriver).Click(onElement).Perform();
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return 0;
	}

	public bool Click(string string_12)
	{
		if (CheckIsLive())
		{
			return false;
		}
		try
		{
			IWebElement webElement = GetElement(string_12);
			webElement.Click();
			return true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return false;
	}

	public bool A31CC706(string string_12)
	{
		if (CheckIsLive())
		{
			return false;
		}
		try
		{
			Scroll_IntoVIew(string_12);
			IWebElement webElement = GetElement(string_12);
			webElement.Click();
			return true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return false;
	}

	public bool Scroll_IntoVIew(string string_12, int int_6 = 1)
	{
		if (CheckIsLive())
		{
			return false;
		}
		try
		{
			if (scrollIntoView(string_12) == 1)
			{
				DelayTime(int_6);
			}
			return true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return false;
	}
	public void ScrollIntoViewv2(string elements)
	{
        IWebElement element = chromeDriver.FindElement(By.XPath(elements));
        IJavaScriptExecutor js = (IJavaScriptExecutor)chromeDriver;
        js.ExecuteScript("arguments[0].scrollIntoView({ behavior: 'smooth', block: 'center', inline: 'nearest' });", element);
    }
	public bool ExecuteJSClick(string string_12)
	{
		if (CheckIsLive())
		{
			return false;
		}
		try
		{
			ExecuteScript(FindElement(string_12) + ".click()");
			return true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return false;
	}

	public int SendKeys(string cssSelectorsOrXpath, string content, bool isSpinText = true)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (isSpinText)
			{
				content = Common.SpinText(content);
			}
			IWebElement webElement = GetElement(cssSelectorsOrXpath);
			if (Common.CheckStringIsContainIcon(content))
			{
				Click(cssSelectorsOrXpath);
				content = content.Replace("\r\n", "*rr*nn").Replace("\n", "*rr*nn");
				content = content.Replace("*rr*nn", "\\r\\n").Replace("\"", "\\\"");
				ExecuteScript(FindElement(cssSelectorsOrXpath) + ".value=\"" + content + "\"");
				webElement.SendKeys(" ");
			}
			else
			{
				webElement.SendKeys(content);
				if (content.Contains(" "))
				{
					webElement.SendKeys(" ");
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public int ClearText(string string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			IWebElement webElement = GetElement(string_12);
			webElement.Clear();
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public int SendEnter(string D915BA06)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			IWebElement webElement = GetElement(D915BA06);
			webElement.SendKeys(OpenQA.Selenium.Keys.Enter);
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public string method_17(string string_12, string string_13 = "")
	{
		if (string_13 == "")
		{
			string_13 = GetURL();
		}
		string newValue = DomainFacebook(string_13);
		string oldValue = DomainFacebook(string_12);
		return string_12.Replace(oldValue, newValue);
	}

	public string DomainFacebook(string string_12 = "")
	{
		if (string_12 == "")
		{
			string_12 = GetURL();
		}
		return Regex.Match(string_12, "https://(.*?)facebook.com").Value;
	}

	public string GetLinkFromId(string A2224B0E, string A63C9D08 = "https://mobile.facebook.com")
	{
		return A2224B0E.StartsWith("https://") ? A2224B0E.Replace(Regex.Match(A2224B0E, "https://(.*?)facebook.com").Value, A63C9D08) : (A63C9D08 + "/" + A2224B0E);
	}

	public int Click(int C035B521, string string_12, int DA90F216 = 0, int int_6 = 0, string string_13 = "", int CFB161AA = 0, int B920B2B3 = 1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		for (int i = 0; i < B920B2B3; DelayTime(1.0), i++)
		{
			try
			{
				if (int_6 == 0)
				{
					switch (C035B521)
					{
						case 1:
							chromeDriver.FindElementsById(string_12)[DA90F216].Click();
							break;
						case 2:
							chromeDriver.FindElementsByName(string_12)[DA90F216].Click();
							break;
						case 3:
							chromeDriver.FindElementsByXPath(string_12)[DA90F216].Click();
							break;
						case 4:
							chromeDriver.FindElementsByCssSelector(string_12)[DA90F216].Click();
							break;
					}
				}
				else
				{
					switch (C035B521)
					{
						case 1:
							chromeDriver.FindElementsById(string_12)[DA90F216].FindElements(By.Id(string_13))[CFB161AA].Click();
							break;
						case 2:
							chromeDriver.FindElementsByName(string_12)[DA90F216].FindElements(By.Name(string_13))[CFB161AA].Click();
							break;
						case 3:
							chromeDriver.FindElementsByXPath(string_12)[DA90F216].FindElements(By.XPath(string_13))[CFB161AA].Click();
							break;
						case 4:
							chromeDriver.FindElementsByCssSelector(string_12)[DA90F216].FindElements(By.CssSelector(string_13))[CFB161AA].Click();
							break;
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				ExportError(exception_, $"chrome.Click({C035B521},{string_12})");
				continue;
			}
			break;
		}
		return flag ? 1 : 0;
	}

	public int FindAndClick(double double_1, int int_6, string string_12, int CE1771AC = 0, int A712FB35 = 0, string F0162122 = "", int int_7 = 0)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				try
				{
					if (A712FB35 == 0)
					{
						switch (int_6)
						{
							case 1:
								chromeDriver.FindElementsById(string_12)[CE1771AC].Click();
								break;
							case 2:
								chromeDriver.FindElementsByName(string_12)[CE1771AC].Click();
								break;
							case 3:
								chromeDriver.FindElementsByXPath(string_12)[CE1771AC].Click();
								break;
							case 4:
								chromeDriver.FindElementsByCssSelector(string_12)[CE1771AC].Click();
								break;
						}
					}
					else
					{
						switch (int_6)
						{
							case 1:
								chromeDriver.FindElementsById(string_12)[CE1771AC].FindElements(By.Id(F0162122))[int_7].Click();
								break;
							case 2:
								chromeDriver.FindElementsByName(string_12)[CE1771AC].FindElements(By.Name(F0162122))[int_7].Click();
								break;
							case 3:
								chromeDriver.FindElementsByXPath(string_12)[CE1771AC].FindElements(By.XPath(F0162122))[int_7].Click();
								break;
							case 4:
								chromeDriver.FindElementsByCssSelector(string_12)[CE1771AC].FindElements(By.CssSelector(F0162122))[int_7].Click();
								break;
						}
					}
					flag = true;
					DelayTime(1.0);
				}
				catch (Exception exception_)
				{
					ExportError(exception_);
					goto IL_01bf;
				}
				break;
			IL_01bf:
				if (!((double)(Environment.TickCount - tickCount) >= double_1 * 1000.0))
				{
					DelayTime(1.0);
					continue;
				}
				break;
			}
		}
		catch (Exception exception_2)
		{
			ExportError(exception_2, $"chrome.FindAndClick({double_1},{int_6},{string_12},{CE1771AC},{A712FB35},{F0162122},{int_7}");
		}
		return flag ? 1 : 0;
	}

	public int ClickWithAction(int int_6, string string_12, int int_7 = 0, int int_8 = 0, string string_13 = "", int F13DE4B2 = 0)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (int_8 != 0)
			{
				switch (int_6)
				{
					case 1:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsById(string_12)[int_7].FindElements(By.Id(string_13))[F13DE4B2]).Perform();
						break;
					case 2:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsByName(string_12)[int_7].FindElements(By.Name(string_13))[F13DE4B2]).Perform();
						break;
					case 3:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsByXPath(string_12)[int_7].FindElements(By.XPath(string_13))[F13DE4B2]).Perform();
						break;
					case 4:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsByCssSelector(string_12)[int_7].FindElements(By.CssSelector(string_13))[F13DE4B2]).Perform();
						break;
				}
			}
			else
			{
				switch (int_6)
				{
					case 1:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsById(string_12)[int_7]).Perform();
						break;
					case 2:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsByName(string_12)[int_7]).Perform();
						break;
					case 3:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsByXPath(string_12)[int_7]).Perform();
						break;
					case 4:
						new Actions(chromeDriver).Click(chromeDriver.FindElementsByCssSelector(string_12)[int_7]).Perform();
						break;
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.ClickWithAction({int_6},{string_12})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeys(int int_6, string string_12, string string_13, bool bool_6 = true, double double_1 = 0.1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (bool_6)
			{
				Click(int_6, string_12);
				DelayTime(double_1);
			}
			switch (int_6)
			{
				case 1:
					chromeDriver.FindElementById(string_12).SendKeys(string_13);
					break;
				case 2:
					chromeDriver.FindElementByName(string_12).SendKeys(string_13);
					break;
				case 3:
					chromeDriver.FindElementByXPath(string_12).SendKeys(string_13);
					break;
				case 4:
					chromeDriver.FindElementByCssSelector(string_12).SendKeys(string_13);
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeys({int_6},{string_12},{string_13},{bool_6})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeys(int int_6, string CC9530A5, int C60E4D19, string string_12, bool bool_6 = true, double double_1 = 0.1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (bool_6)
			{
				Click(int_6, CC9530A5);
				DelayTime(double_1);
			}
			switch (int_6)
			{
				case 1:
					chromeDriver.FindElementsById(CC9530A5)[C60E4D19].SendKeys(string_12);
					break;
				case 2:
					chromeDriver.FindElementsByName(CC9530A5)[C60E4D19].SendKeys(string_12);
					break;
				case 3:
					chromeDriver.FindElementsByXPath(CC9530A5)[C60E4D19].SendKeys(string_12);
					break;
				case 4:
					chromeDriver.FindElementsByCssSelector(CC9530A5)[C60E4D19].SendKeys(string_12);
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeys({int_6},{CC9530A5},{string_12},{bool_6})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeys(int CD004386, string FBA9F11A, string string_12, double double_1, bool isClick = true, double double_2 = 0.1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (isClick)
			{
				Click(CD004386, FBA9F11A);
				DelayTime(double_2);
			}
			for (int i = 0; i < string_12.Length; i++)
			{
				switch (CD004386)
				{
					case 1:
						chromeDriver.FindElementById(FBA9F11A).SendKeys(string_12[i].ToString());
						break;
					case 2:
						chromeDriver.FindElementByName(FBA9F11A).SendKeys(string_12[i].ToString());
						break;
					case 3:
						chromeDriver.FindElementByXPath(FBA9F11A).SendKeys(string_12[i].ToString());
						break;
					case 4:
						chromeDriver.FindElementByCssSelector(FBA9F11A).SendKeys(string_12[i].ToString());
						break;
				}
				if (double_1 > 0.0)
				{
					int num = Convert.ToInt32(double_1 * 1000.0);
					if (num < 100)
					{
						num = 100;
					}
					Thread.Sleep(Base.rd.Next(num, num + 50));
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeys({CD004386},{FBA9F11A},{string_12},{double_1},{isClick})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeys(int int_6, string E204A72C, int int_7, string string_12, double D8963C9B, bool bool_6 = true, double double_1 = 0.1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (bool_6)
			{
				Click(int_6, E204A72C);
				DelayTime(double_1);
			}
			for (int i = 0; i < string_12.Length; i++)
			{
				switch (int_6)
				{
					case 1:
						chromeDriver.FindElementsById(E204A72C)[int_7].SendKeys(string_12[i].ToString());
						break;
					case 2:
						chromeDriver.FindElementsByName(E204A72C)[int_7].SendKeys(string_12[i].ToString());
						break;
					case 3:
						chromeDriver.FindElementsByXPath(E204A72C)[int_7].SendKeys(string_12[i].ToString());
						break;
					case 4:
						chromeDriver.FindElementsByCssSelector(E204A72C)[int_7].SendKeys(string_12[i].ToString());
						break;
				}
				if (D8963C9B > 0.0)
				{
					int num = Convert.ToInt32(D8963C9B * 1000.0);
					if (num < 100)
					{
						num = 100;
					}
					Thread.Sleep(Base.rd.Next(num, num + 50));
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeys({int_6},{E204A72C},{string_12},{D8963C9B},{bool_6})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeys(Random D9210824, int EB270E94, string A9B5769E, string string_12, double double_1, bool bool_6 = true, double E6A06433 = 0.1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (bool_6)
			{
				Click(EB270E94, A9B5769E);
				DelayTime(E6A06433);
			}
			int num = 0;
			int num2 = D9210824.Next(1, 1000) % 3;
			if (string_12.Length < 3)
			{
				num2 = 2;
				int num3 = 2;
				int num4 = 2;
			}
			else
			{
				num = D9210824.Next(1, string_12.Length * 3 / 4);
				switch (num2)
				{
					case 0:
						{
							string string_15 = string_12.Substring(0, num);
							SendKeys(EB270E94, A9B5769E, string_15, Convert.ToDouble(D9210824.Next(10, 100)) / 1000.0);
							DelayTime(D9210824.Next(1, 3));
							int num5 = D9210824.Next(1, num);
							for (int i = 0; i < num5; i++)
							{
								SendBackspace(EB270E94, A9B5769E);
								DelayTime(Convert.ToDouble(D9210824.Next(1000, 2000)) / 10000.0);
							}
							string text = "";
							switch (EB270E94)
							{
								case 1:
									text = "#" + A9B5769E;
									break;
								case 2:
									text = "[name=\"" + A9B5769E + "\"]";
									break;
								case 4:
									text = A9B5769E;
									break;
							}
							string_15 = string_12.Substring(chromeDriver.ExecuteScript("return document.querySelector('" + text + "').value+''").ToString().Length);
							DelayTime(D9210824.Next(1, 3));
							SendKeys(EB270E94, A9B5769E, string_15, Convert.ToDouble(D9210824.Next(100, 300)) / 1000.0, isClick: false);
							DelayTime(D9210824.Next(1, 3));
							goto IL_02ce;
						}
					case 1:
						{
							string string_13 = string_12.Substring(0, num);
							string string_14 = string_12.Substring(num);
							SendKeys(EB270E94, A9B5769E, string_13, Convert.ToDouble(D9210824.Next(10, 100)) / 1000.0);
							DelayTime(D9210824.Next(1, 3));
							SendKeys(EB270E94, A9B5769E, string_14, Convert.ToDouble(D9210824.Next(100, 300)) / 1000.0, isClick: false);
							DelayTime(D9210824.Next(1, 3));
							goto IL_02ce;
						}
					case 2:
						break;
					default:
						goto IL_02ce;
				}
			}
			SendKeys(EB270E94, A9B5769E, string_12, Convert.ToDouble(D9210824.Next(100, 200)) / 1000.0);
			DelayTime(D9210824.Next(1, 3));
			goto IL_02ce;
		IL_02ce:
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeys({EB270E94},{A9B5769E},{string_12},{double_1},{bool_6})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeysV2(int E70060AB, string A5A48D1E, int int_6, int int_7, string string_12, int int_8, string E4098938, bool F8931425 = true, double double_1 = 0.1)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (F8931425)
			{
				Click(E70060AB, A5A48D1E, int_6, int_7, string_12, int_8);
				DelayTime(double_1);
			}
			if (int_7 == 0)
			{
				switch (E70060AB)
				{
					case 1:
						chromeDriver.FindElementsById(A5A48D1E)[int_6].SendKeys(E4098938);
						break;
					case 2:
						chromeDriver.FindElementsByName(A5A48D1E)[int_6].SendKeys(E4098938);
						break;
					case 3:
						chromeDriver.FindElementsByXPath(A5A48D1E)[int_6].SendKeys(E4098938);
						break;
					case 4:
						chromeDriver.FindElementsByCssSelector(A5A48D1E)[int_6].SendKeys(E4098938);
						break;
				}
			}
			else
			{
				switch (E70060AB)
				{
					case 1:
						chromeDriver.FindElementsById(A5A48D1E)[int_6].FindElements(By.Id(string_12))[int_8].SendKeys(E4098938);
						break;
					case 2:
						chromeDriver.FindElementsByName(A5A48D1E)[int_6].FindElements(By.Name(string_12))[int_8].SendKeys(E4098938);
						break;
					case 3:
						chromeDriver.FindElementsByXPath(A5A48D1E)[int_6].FindElements(By.XPath(string_12))[int_8].SendKeys(E4098938);
						break;
					case 4:
						chromeDriver.FindElementsByCssSelector(A5A48D1E)[int_6].FindElements(By.CssSelector(string_12))[int_8].SendKeys(E4098938);
						break;
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendKeys({E70060AB},{A5A48D1E},{E4098938},{F8931425})");
		}
		return flag ? 1 : 0;
	}

	public int SendKeysWithSpeed(string E9B7023D, string string_12, double F803F301, bool bool_6 = true, double double_1 = 0.1)
	{
		int result = 0;
		try
		{
			int num = 4;
			if (CheckIsLive())
			{
				return -2;
			}
			if (bool_6)
			{
				Click(num, E9B7023D);
				DelayTime(double_1);
			}
			switch (SettingsTool.GetSettings("configGeneral").GetValueInt("tocDoGoVanBan"))
			{
				case 2:
					switch (num)
					{
						case 1:
							chromeDriver.FindElementById(E9B7023D).SendKeys(string_12);
							break;
						case 2:
							chromeDriver.FindElementByName(E9B7023D).SendKeys(string_12);
							break;
						case 3:
							chromeDriver.FindElementByXPath(E9B7023D).SendKeys(string_12);
							break;
						case 4:
							chromeDriver.FindElementByCssSelector(E9B7023D).SendKeys(string_12);
							break;
					}
					break;
				case 0:
				case 1:
					{
						for (int i = 0; i < string_12.Length; i++)
						{
							switch (num)
							{
								case 1:
									chromeDriver.FindElementById(E9B7023D).SendKeys(string_12[i].ToString());
									break;
								case 2:
									chromeDriver.FindElementByName(E9B7023D).SendKeys(string_12[i].ToString());
									break;
								case 3:
									chromeDriver.FindElementByXPath(E9B7023D).SendKeys(string_12[i].ToString());
									break;
								case 4:
									chromeDriver.FindElementByCssSelector(E9B7023D).SendKeys(string_12[i].ToString());
									break;
							}
							if (F803F301 > 0.0)
							{
								int num2 = Convert.ToInt32(F803F301 * 1000.0);
								if (num2 < 100)
								{
									num2 = 100;
								}
								Thread.Sleep(Base.rd.Next(num2, num2 + 50));
							}
						}
						break;
					}
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public int SendBackspace(int F72BC402, string F83D0CBF)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			switch (F72BC402)
			{
				case 1:
					chromeDriver.FindElementById(F83D0CBF).SendKeys(OpenQA.Selenium.Keys.Backspace);
					break;
				case 2:
					chromeDriver.FindElementByName(F83D0CBF).SendKeys(OpenQA.Selenium.Keys.Backspace);
					break;
				case 3:
					chromeDriver.FindElementByXPath(F83D0CBF).SendKeys(OpenQA.Selenium.Keys.Backspace);
					break;
				case 4:
					chromeDriver.FindElementByCssSelector(F83D0CBF).SendKeys(OpenQA.Selenium.Keys.Backspace);
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendBackspace({F72BC402},{F83D0CBF})");
		}
		return flag ? 1 : 0;
	}

	public void DelayThaoTacNho(int int_6 = 0, Random random_0 = null)
	{
		if (random_0 == null)
		{
			random_0 = new Random();
		}
		DelayTime(random_0.Next(int_6 + 1, int_6 + 4));
	}

	public void DelayRandom(int int_6, int CF918537)
	{
		if (int_6 > CF918537)
		{
			DelayTime(Base.rd.Next(CF918537, int_6 + 1));
		}
		else
		{
			DelayTime(Base.rd.Next(int_6, CF918537 + 1));
		}
	}

	public int SendEnter(int int_6, string D7A9BC92, int int_7 = 0, int AD8F6098 = 0, string B008540E = "", int BD33C613 = 0)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (AD8F6098 == 0)
			{
				switch (int_6)
				{
					case 1:
						chromeDriver.FindElementsById(D7A9BC92)[int_7].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 2:
						chromeDriver.FindElementsByName(D7A9BC92)[int_7].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 3:
						chromeDriver.FindElementsByXPath(D7A9BC92)[int_7].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 4:
						chromeDriver.FindElementsByCssSelector(D7A9BC92)[int_7].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
				}
			}
			else
			{
				switch (int_6)
				{
					case 1:
						chromeDriver.FindElementsById(D7A9BC92)[int_7].FindElements(By.Id(B008540E))[BD33C613].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 2:
						chromeDriver.FindElementsByName(D7A9BC92)[int_7].FindElements(By.Name(B008540E))[BD33C613].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 3:
						chromeDriver.FindElementsByXPath(D7A9BC92)[int_7].FindElements(By.XPath(B008540E))[BD33C613].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
					case 4:
						chromeDriver.FindElementsByCssSelector(D7A9BC92)[int_7].FindElements(By.CssSelector(B008540E))[BD33C613].SendKeys(OpenQA.Selenium.Keys.Enter);
						break;
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendEnter({int_6},{D7A9BC92},{int_7})");
		}
		return flag ? 1 : 0;
	}

	public int CheckLinkLogin(int int_6)
	{
		bool flag = false;
		try
		{
			switch (int_6)
			{
				case 1:
					GotoURL("https://www.facebook.com/login");
					break;
				case 2:
					GotoURL("https://mobile.facebook.com/login");
					break;
				case 3:
					GotoURL("https://mbasic.facebook.com/login");
					break;
			}
			flag = true;
			DelayTime(1.0);
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public int SelectText(int int_6, string A000DA19)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			switch (int_6)
			{
				case 1:
					chromeDriver.FindElementById(A000DA19).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 2:
					chromeDriver.FindElementByName(A000DA19).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 3:
					chromeDriver.FindElementByXPath(A000DA19).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 4:
					chromeDriver.FindElementByCssSelector(A000DA19).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SelectText({int_6},{A000DA19})");
		}
		return flag ? 1 : 0;
	}

	public int SelectText(string string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			IWebElement webElement = GetElement(string_12);
			webElement.SendKeys(OpenQA.Selenium.Keys.Control + "a");
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return flag ? 1 : 0;
	}

	public int ClearText(int int_6, string string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			switch (int_6)
			{
				case 1:
					chromeDriver.FindElementById(string_12).Clear();
					break;
				case 2:
					chromeDriver.FindElementByName(string_12).Clear();
					break;
				case 3:
					chromeDriver.FindElementByXPath(string_12).Clear();
					break;
				case 4:
					chromeDriver.FindElementByCssSelector(string_12).Clear();
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.ClearText({int_6},{string_12})");
		}
		return flag ? 1 : 0;
	}
    public int CountElement(string querySelector)
    {
        int result = 0;
        if (!CheckIsLive())
        {
            return -2;
        }
        try
        {
            result = Convert.ToInt32(chromeDriver.ExecuteScript("return document.querySelectorAll('" + querySelector.Replace("'", "\\'") + "').length+''").ToString());
            return result;
        }
        catch (Exception ex)
        {
            ExportError(ex, "chrome.CountElement(" + querySelector + ")");
            return result;
        }
    }
    public int CountElementWithXpath(string string_12)
	{
		int result = 0;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			result = ((!StartWithXpath(string_12)) ? Convert.ToInt32(chromeDriver.ExecuteScript("return document.querySelectorAll('" + string_12.Replace("'", "\\'") + "').length+''").ToString()) : Convert.ToInt32(chromeDriver.ExecuteScript("return document.evaluate('count(" + string_12.Replace("'", "\\'") + ")', document, null, XPathResult.NUMBER_TYPE, null).numberValue").ToString()));
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return result;
	}

	public void method_31(string CD13EA3C)
	{
		try
		{
			string text = FindElement(CD13EA3C);
			ExecuteScript(text + ".remove();");
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
	}

	public int CheckExistElement(string D31DE502, double DA08FD0E = 0.0)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			do
			{
				string text = FindElement(D31DE502);
				if (!(ExecuteScript("return " + text + "!=null").ToString().ToLower() == "true"))
				{
					if (!CheckIsLive())
					{
						if (DA08FD0E != 0.0)
						{
							DelayTime(1.0);
							continue;
						}
						break;
					}
					return -2;
				}
				return 1;
			}
			while ((double)(Environment.TickCount - tickCount) < DA08FD0E * 1000.0);
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return 0;
	}

	public int EC08DFBA(string string_12, double double_1 = 0.0)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		return CheckExistElement("//*[translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz')=\"" + string_12 + "\"]", double_1);
	}

	public int CheckExistElementv2(string FC0D973C, double double_1 = 0.0)
	{
		bool flag = true;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while ((string)chromeDriver.ExecuteScript("return " + FC0D973C + ".length+''") == "0")
			{
				if (!((double)(Environment.TickCount - tickCount) > double_1 * 1000.0))
				{
					Thread.Sleep(1000);
					continue;
				}
				flag = false;
				break;
			}
		}
		catch (Exception exception_)
		{
			flag = false;
			ExportError(exception_, $"chrome.CheckExistElement({FC0D973C},{double_1})");
		}
		return flag ? 1 : 0;
	}

	public int WaitForSearchElement(string string_12, int int_6 = 0, double EE9E7C1B = 0.0)
	{
		bool flag = true;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			if (int_6 == 0)
			{
				while ((string)chromeDriver.ExecuteScript("return document.querySelectorAll('" + string_12.Replace("'", "\\'") + "').length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > EE9E7C1B * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					flag = false;
					break;
				}
			}
			else
			{
				while ((string)chromeDriver.ExecuteScript("return document.querySelectorAll('" + string_12.Replace("'", "\\'") + "').length+''") != "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > EE9E7C1B * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					flag = false;
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			flag = false;
			ExportError(exception_, $"chrome.WaitForSearchElement({string_12},{int_6},{EE9E7C1B})");
		}
		return flag ? 1 : 0;
	}

	public int CheckExistElements(double double_1 = 0.0, params string[] string_12)
	{
		int num = 0;
		if (CheckIsLive())
		{
			return 0;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				num = Convert.ToInt32(chromeDriver.ExecuteScript("var arr='" + string.Join("|", string_12) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
				if (num == 0)
				{
					if (!((double)(Environment.TickCount - tickCount) > double_1 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
				return num;
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_, string.Format("chrome.CheckExistElements({0},{1})", double_1, string.Join("|", string_12)));
		}
		return num;
	}

	public string CheckExistElementsV2(double double_1 = 0.0, params string[] string_12)
	{
		int num = 0;
		if (CheckIsLive())
		{
			return "-2";
		}
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				num = Convert.ToInt32(chromeDriver.ExecuteScript("var arr='" + string.Join("|", string_12) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
				if (num == 0)
				{
					if (!((double)(Environment.TickCount - tickCount) > double_1 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
				return string_12[num - 1];
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_, string.Format("chrome.CheckExistElements({0},{1})", double_1, string.Join("|", string_12)));
		}
		return "";
	}

	public int SendEnter(int int_6, string string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			switch (int_6)
			{
				case 1:
					chromeDriver.FindElementById(string_12).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 2:
					chromeDriver.FindElementByName(string_12).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 3:
					chromeDriver.FindElementByXPath(string_12).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 4:
					chromeDriver.FindElementByCssSelector(string_12).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.SendEnter({int_6},{string_12})");
		}
		return flag ? 1 : 0;
	}

	public int Scroll(int AB833A3A, int int_6)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			string script = $"window.scrollTo({AB833A3A}, {int_6})";
			chromeDriver.ExecuteScript(script);
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.Scroll({AB833A3A},{int_6})");
		}
		return flag ? 1 : 0;
	}

	public int scrollIntoView(string A183EB9E)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.ExecuteScript(FindElement(A183EB9E) + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
			return 0;
		}
	}

	public int ScrollSmooth(string F61A7B3F)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.ExecuteScript(F61A7B3F + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.ScrollSmooth(" + F61A7B3F + ")");
			return 0;
		}
	}

	public int ScrollSmoothIfNotExistOnScreen(string string_12)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			if (CheckExistElementOnScreen(string_12) != 0)
			{
				chromeDriver.ExecuteScript(string_12 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
				return 1;
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.ScrollSmoothIfNotExistOnScreen(" + string_12 + ")");
		}
		return 0;
	}

	public int CheckExistElementOnScreen(string string_12, int int_6 = 0)
	{
		int num = -3;
		int tickCount = Environment.TickCount;
		do
		{
			if (!CheckIsLive())
			{
				try
				{
					num = Convert.ToInt32(chromeDriver.ExecuteScript("var check='';x=" + string_12 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
					if (num == 0)
					{
						break;
					}
				}
				catch (Exception exception_)
				{
					ExportError(exception_);
				}
				if (int_6 != 0)
				{
					DelayTime(1.0);
					continue;
				}
				break;
			}
			return -2;
		}
		while (Environment.TickCount - tickCount < int_6 * 1000);
		return num;
	}

	public Point GetSizeChrome()
	{
		Point result = new Point(0, 0);
		if (CheckIsLive())
		{
			return result;
		}
		try
		{
			string text = chromeDriver.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
			result.X = Convert.ToInt32(text.Split('|')[1]);
			result.Y = Convert.ToInt32(text.Split('|')[0]);
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return result;
	}

	public int CloseChrome()
	{
		if (!CheckIsLive())
		{
			try
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						chromeDriver.Quit();
					}
					catch (Exception)
					{
					}
				});
				thread.IsBackground = true;
				thread.Start();
				if (!thread.Join(5000))
				{
					thread.Abort();
				}
			}
			catch
			{
			}
		}
		try
		{
			if (Process_0 != null && !Process_0.HasExited)
			{
				Process_0.Kill();
			}
			if (BE38893F != null && !BE38893F.HasExited)
			{
				BE38893F.Kill();
			}
		}
		catch
		{
		}
		Process_0 = null;
		BE38893F = null;
		Boolean_1 = true;
		return 1;
	}

	public int ClearText()
	{
		if (CheckIsLive())
		{
			return -2;
		}
		new Actions(chromeDriver).KeyDown(OpenQA.Selenium.Keys.Shift).SendKeys(OpenQA.Selenium.Keys.ArrowUp).SendKeys(OpenQA.Selenium.Keys.ArrowUp)
			.SendKeys(OpenQA.Selenium.Keys.ArrowUp)
			.SendKeys(OpenQA.Selenium.Keys.Delete)
			.KeyUp(OpenQA.Selenium.Keys.Shift)
			.Build()
			.Perform();
		return 1;
	}

	public int ScreenCapture(string A9951A25, string BB80FB97)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			Screenshot screenshot = ((ITakesScreenshot)chromeDriver).GetScreenshot();
			screenshot.SaveAsFile(A9951A25 + (A9951A25.EndsWith("\\") ? "" : "\\") + BB80FB97 + ".png");
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.ScreenCapture(" + A9951A25 + "," + BB80FB97 + ")");
		}
		return flag ? 1 : 0;
	}

	public int AddCookieIntoChrome(string string_12, string string_13 = ".facebook.com")
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			string[] array = string_12.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Trim() != "")
				{
					string[] array3 = text.Split('=');
					if (array3.Count() > 1 && array3[0].Trim() != "")
					{
						Cookie cookie = null;
						cookie = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_13, "/", DateTime.Now.AddDays(10.0));
						chromeDriver.Manage().Cookies.AddCookie(cookie);
					}
				}
			}
			DeleteCookieNamedz("i_user");
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.AddCookieIntoChrome(" + string_12 + "," + string_13 + ")");
			return 0;
		}
	}

	public int DeleteCookieNamedz(string string_12)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.Manage().Cookies.DeleteCookieNamed(string_12);
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
			return 0;
		}
	}

	public string GetCookieFromChrome(string string_12 = "facebook")
	{
		string text = "";
		if (CheckIsLive())
		{
			return "";
		}
		try
		{
			Cookie[] array = chromeDriver.Manage().Cookies.AllCookies.ToArray();
			Cookie[] array2 = array;
			foreach (Cookie cookie in array2)
			{
				if (cookie.Domain.Contains(string_12))
				{
					text = text + cookie.Name + "=" + cookie.Value + ";";
				}
			}
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.GetCookieFromChrome(" + string_12 + ")");
		}
		return text;
	}

	public string GetUIDFromCookies()
	{
		return Regex.Match(GetCookieFromChrome(), "c_user=(\\d+)").Groups[1].Value;
	}

	public string GetFbdtsgv1()
	{
		string text = "";
		try
		{
			string input = RequestGetHelper("https://mobile.facebook.com/help");
			text = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			if (text == "")
			{
				text = Regex.Match(input, Common.Base64Decode("ZHRzZyI6eyJ0b2tlbiI6IiguKj8pIg==")).Groups[1].Value;
			}
		}
		catch
		{
		}
		return text;
	}

	public int OpenNewTab(string string_12 = "", bool bool_6 = true)
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.ExecuteScript("window.open('" + string_12 + "', '_blank').focus();");
			if (bool_6)
			{
				chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.Last());
			}
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.OpenNewTab({string_12},{bool_6})");
			return 0;
		}
	}

	public int CloseCurrentTab()
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.Close();
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.CloseCurrentTab()");
			return 0;
		}
	}

	public int SwitchToFirstTab()
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.First());
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.SwitchToFirstTab()");
			return 0;
		}
	}

	public int SwitchToLastTab()
	{
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			chromeDriver.SwitchTo().Window(chromeDriver.WindowHandles.Last());
			return 1;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, "chrome.SwitchToLastTab()");
			return 0;
		}
	}

	public void DelayTime(double F4AF2301)
	{
		if (!CheckIsLive())
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(F4AF2301 * 1000.0));
			}
			catch (Exception exception_)
			{
				ExportError(exception_, $"chrome.DelayTime({F4AF2301})");
			}
		}
	}

	public void DelayTime(int int_6, int D3AACB16)
	{
		if (int_6 > D3AACB16)
		{
			DelayTime(Base.rd.Next(D3AACB16, int_6 + 1));
		}
		else
		{
			DelayTime(Base.rd.Next(int_6, D3AACB16 + 1));
		}
	}

	public void ExportError(Exception exception_0, string string_12 = "")
	{
		try
		{
			if (exception_0 != null && exception_0.ToString().Contains("timed out"))
			{
				Boolean_1 = true;
			}
			else
			{
				if (!(string_12 == "chrome.Open()"))
				{
					return;
				}
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
				if (chromeDriver != null)
				{
					string contents = ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
					ScreenCapture("log\\images\\", text);
					File.WriteAllText("log\\html\\" + text + ".html", contents);
				}
				using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
				streamWriter.WriteLine("-----------------------------------------------------------------------------");
				streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
				streamWriter.WriteLine("File: " + text);
				if (string_12 != "")
				{
					streamWriter.WriteLine("Error: " + string_12);
				}
				streamWriter.WriteLine();
				if (exception_0 != null)
				{
					streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
					streamWriter.WriteLine("Message: " + exception_0.Message);
					streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
					exception_0 = exception_0.InnerException;
				}
				return;
			}
		}
		catch
		{
		}
	}

	public int Select(int EC2CA231, string AFA1F1A8, string string_12)
	{
		bool flag = false;
		if (CheckIsLive())
		{
			return -2;
		}
		try
		{
			switch (EC2CA231)
			{
				case 1:
					new SelectElement(chromeDriver.FindElementById(AFA1F1A8)).SelectByValue(string_12);
					break;
				case 2:
					new SelectElement(chromeDriver.FindElementByName(AFA1F1A8)).SelectByValue(string_12);
					break;
				case 3:
					new SelectElement(chromeDriver.FindElementByXPath(AFA1F1A8)).SelectByValue(string_12);
					break;
				case 4:
					new SelectElement(chromeDriver.FindElementByCssSelector(AFA1F1A8)).SelectByValue(string_12);
					break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			ExportError(exception_, $"chrome.Select({EC2CA231},{AFA1F1A8},{string_12})");
		}
		return flag ? 1 : 0;
	}

	private bool GetProcess()
	{
		try
		{
			if (Process_0 != null)
			{
				return true;
			}
			if (chromeDriver.WindowHandles.Count() > 1)
			{
				SwitchToFirstTab();
				CloseCurrentTab();
				SwitchToFirstTab();
			}
			string C1240F5 = "";
			for (int i = 0; i < 10; i++)
			{
				try
				{
					try
					{
						C1240F5 = chromeDriver.CurrentWindowHandle;
					}
					catch
					{
						C1240F5 = Common.CreateRandomStringNumber(15);
					}
					if (C1240F5 != "")
					{
						for (int j = 0; j < 30; j++)
						{
							chromeDriver.ExecuteScript("document.title='" + C1240F5 + "'");
							DelayTime(1.0);
							Process_0 = (from CD3DE091 in Process.GetProcessesByName("chrome")
										 where CD3DE091.MainWindowTitle.Contains(C1240F5)
										 select CD3DE091).FirstOrDefault();
							if (Process_0 != null)
							{
								return true;
							}
						}
					}
				}
				catch (Exception exception_)
				{
					ExportError(exception_);
				}
				DelayTime(1.0);
			}
		}
		catch (Exception exception_2)
		{
			ExportError(exception_2);
		}
		return false;
	}

	public bool CheckLiveAccount()
	{
		string text = GetURL();
		if (text.Contains("checkpoint/disabled"))
		{
			return false;
		}
		string text2 = DomainFacebook(text);
		text = ExecuteScript("async function Request(){try{let a=await fetch(\"" + text2 + "/me\"),b=\"\";return a.ok&&(b=a.url),b}catch{}}var c=await Request();return c").ToString();
		if (text.Contains("checkpoint/disabled") || text.Contains("828281030927956") || text.Contains("1501092823525282"))
		{
			return false;
		}
		bool flag = false;
		List<string> list = chromeDriver.ExecuteScript("arrAction = []; document.querySelectorAll('form[method]').forEach(e => arrAction.push(e.getAttribute('action'))); return arrAction.join('|');").ToString().Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries)
			.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			if (!list[i].StartsWith("/a/home.php?") && !list[i].StartsWith("/search/?") && !list[i].StartsWith("/composer/mbasic/?"))
			{
				if (list[i].Equals("/logout.php?button_location=settings&button_name=logout") && CheckInfoAccountv2.CheckLiveWall(cUid).StartsWith("1"))
				{
					flag = true;
					break;
				}
				continue;
			}
			flag = true;
			break;
		}
		if (!flag)
		{
			string text3 = RequestGetHelper("https://mbasic.facebook.com/home.php").ToString();
			flag = text3.Contains("href=\"/menu/bookmarks/") && text3.Contains("id=\"mbasic_logout_button\"");
		}
		return flag;
	}

	public string RequestGetHelper(string string_12, string EEA61527 = "")
	{
		try
		{
			if (EEA61527 == "")
			{
				EEA61527 = GetURL();
			}
			if (DomainFacebook(EEA61527) != DomainFacebook(string_12))
			{
				GotoURL(DomainFacebook(string_12));
				ExecuteScript("document.querySelector('body').innerHTML='LTD SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			//string text = Common.GetText("RequestGet");
			string text = "async function RequestGet() { var output = ''; try { var response = await fetch('{url}'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;";
			text = text.Replace("{url}", string_12);
			return ExecuteScript(text).ToString();
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return "";
	}

	public string RequestPostHelper(string url, string data, string contentType = "application/x-www-form-urlencoded", string currentUrl = "")
	{
		try
		{
			if (currentUrl == "")
			{
				currentUrl = GetURL();
			}
			if (DomainFacebook(currentUrl) != DomainFacebook(url))
			{
				GotoURL(DomainFacebook(url));
				ExecuteScript("document.querySelector('body').innerHTML='LTD SOFTWARE'; document.querySelector('body').style = 'text-align: center; background-color:#fff'");
			}
			data = data.Replace("\n", "\\n").Replace("\"", "\\\"");
            //string text = Common.GetText("RequestPost");
            //text = text.Replace("{url}", url);
            //text = text.Replace("{data}", data);
            //text = text.Replace("{contentType}", contentType);
            //return ExecuteScript(text).ToString();
            return (string)ExecuteScript("async function RequestPost() { var output = ''; try { var response = await fetch('" + url + "', { method: 'POST', body: '" + data + "', headers: { 'Content-Type': '" + contentType + "' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
        }
        catch (Exception exception_)
		{
			ExportError(exception_);
		}
		return "";
	}

	internal int SetFbLanguage(string EF22B18A = "en_US")
	{
		//string value = RunCode("SetFbLanguage('" + cssSelectorsOrXpath + "')");
		//return Convert.ToInt32(value);
		string text = DomainFacebook(GetURL());
		string input = RequestGetHelper(text + "/language");
		string value = Regex.Match(input, "<html.*?lang=\"(.*?)\".*?>").Groups[1].Value.Split('_')[0].Split('-')[0];
		if (EF22B18A.StartsWith(value))
		{
			return 2;
		}
		string text2 = GetURL();
		int num = CommonChrome.CheckTypeWebFacebookFromUrl(text2);
		bool flag = false;
		string text3 = GetUIDFromCookies();
		string value2 = Regex.Match(input, "\\[\"DTSGInitData\",\\[\\],{\"token\":\"(.*?)\"").Groups[1].Value;
		if (value2 == "")
		{
			value2 = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
		}
		if (value2 == "")
		{
			value2 = Regex.Match(input, "\"dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
		}
		switch (num)
		{
			case 3:
				{
					string string_3 = "fb_dtsg=" + value2 + "&jazoest=";
					input = RequestPostHelper("https://mbasic.facebook.com/intl/save_locale/?loc=" + EF22B18A + "&href=" + text2 + "ls_ref=mobile_suggested_locale_selector", string_3);
					flag = true;
					break;
				}
			case 1:
				{
					string string_2 = "av=" + text3 + "&__user=" + text3 + "&__a=1&__dyn=7AzHxqU5a5Q1ryUqxenFw9uu2i5U4e0ykdwSwAyUco2qwJxS1NwJwpUe8hw6vwb-q7oc81xoswaq221FwgolzUO0n2US2G5Usw9m1YwBgK7o884y0Mo5W3S1lwlE-U2exi4UaEW2G1NxGm2SUbElxm3y11xfxm16wUws9ovUaU3VBwJCwLyES0Io5d08O321bwzwTwNwLwFg667EW26&__csr=gbJgx9FrmKhGhebly4FeiuGLgBtvgV5Qp3W8fyQmWGWCyqQqmWByVWBCDgN4QKm4oCbzWBKFqUGmbgC2qczo-eDy8OeGm48S2yjwIiAUbFU4-688WDwnEeE-mm2q6U5q489U2qAyocpA1awCwsU6um784a2y1iBwfe0Xo3ewcS3C4UcEeUkwd21xwb-0TU0bhE03kqw1ra00D3U1cE0qwy80nBw&__req=s&__hs=19341.HYP%3Acomet_plat_default_pkg.2.1.0.2.1&dpr=1&__ccg=EXCELLENT&__rev=1006744097&__s=6wdrff%3Av1ddfc%3Aivypow&__hsi=7177392587978281303&__comet_req=1&fb_dtsg=" + value2 + "&jazoest=25561&lsd=28LQ-iX8-krHlH1-04tYFF&__spin_r=1006744097&__spin_b=trunk&__spin_t=1671116936&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=useCometLocaleSelectorLanguageChangeMutation&variables=%7B%22locale%22%3A%22" + EF22B18A + "%22%2C%22referrer%22%3A%22WWW_ACCOUNT_SETTINGS%22%2C%22fallback_locale%22%3Anull%7D&server_timestamps=true&doc_id=5299223003435639&fb_api_analytics_tags=%5B%22qpl_active_flow_ids%3D30605361%22%5D";
					input = RequestPostHelper("https://www.facebook.com/api/graphql/", string_2);
					flag = Regex.Match(input, "{\"success\":(.*?)}").Groups[1].Value == "true";
					break;
				}
			default:
				{
					string string_ = "loc=" + EF22B18A + "&ref=m_touch_locale_selector&should_redirect=false&fb_dtsg=" + value2 + "&jazoest=22683&lsd=&__dyn=&__csr=&__req=m&__a=&__user=" + text3;
					input = RequestPostHelper("https://m.facebook.com/intl/ajax/save_locale", string_);
					flag = Regex.Match(input, "{\"success\":(.*?)}").Groups[1].Value == "true";
					break;
				}
		}
		input = RequestGetHelper(text + "/help");
		value = Regex.Match(input, "<html.*?lang=\"(.*?)\".*?>").Groups[1].Value.Split('_')[0].Split('-')[0];
		if (!EF22B18A.StartsWith(value))
		{
			GotoURL("https://mbasic.facebook.com/language");
			string bFB7BA2D = CheckExistElements(0.0, new List<string>
			{
				"form[action*=\"loc=" + EF22B18A + "\"] [type=\"submit\"]",
				"[value=\"" + EF22B18A + "\"]"
			});
			ExecuteJSClick(bFB7BA2D);
			DelayTime(2.0);
			flag = true;
		}
		return flag ? 1 : 0;
	}

	public int method_53(int int_6, int int_7)
	{
		return Base.rd.Next(int_6, int_7 + 1);
	}

	public void method_54(int int_6 = 0, int C283A93C = 0)
	{
		if (!CheckIsLive())
		{
			try
			{
				int_3 = int_6;
				int_4 = C283A93C;
				chromeDriver.Manage().Window.Position = new Point(int_6, C283A93C);
			}
			catch (Exception exception_)
			{
				ExportError(exception_);
			}
		}
	}

	public void D8B8FC06()
	{
		if (!CheckIsLive())
		{
			try
			{
				chromeDriver.Manage().Window.Position = new Point(int_3, int_4);
			}
			catch (Exception exception_)
			{
				ExportError(exception_);
			}
		}
	}

	public void SetSize(int int_6 = 500, int F7AE6306 = 700)
	{
		if (!CheckIsLive())
		{
			try
			{
				int_5 = chromeDriver.Manage().Window.Size.Width;
				CCBFAD0B = chromeDriver.Manage().Window.Size.Height;
				chromeDriver.Manage().Window.Size = new Size(int_6, F7AE6306);
			}
			catch (Exception exception_)
			{
				ExportError(exception_);
			}
		}
	}

	public void RetoreSize()
	{
		if (!CheckIsLive())
		{
			try
			{
				chromeDriver.Manage().Window.Size = new Size(int_5, CCBFAD0B);
			}
			catch (Exception exception_)
			{
				ExportError(exception_);
			}
		}
	}

	internal string GetElementReaction(string B11A5305)
	{
		string text = "";
		List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
		try
		{
			int index = Convert.ToInt32(B11A5305.Split('|').ToList().GetRandomItem());
			text = list[index];
		}
		catch (Exception)
		{
			text = list.First();
		}
		return $"//*[@aria-label=\"Reactions\" and not(ancestor::*/@hidden)]//*[contains(@aria-label,\"{text}\")]";
	}

	private List<string> method_58(List<string> BDBD1D0C)
	{
		List<string> A21DE59F = new List<string>();
		try
		{
			int int_1 = 0;
			int num = ((BDBD1D0C.Count < 100) ? BDBD1D0C.Count : 100);
			string string_0 = GetCookieFromChrome();
			string string_1 = GetUseragent();
			string D282268C = Proxy;
			int int_0 = TypeProxy;
			int num2 = 0;
			while (num2 < BDBD1D0C.Count)
			{
				if (int_1 < num)
				{
					Interlocked.Increment(ref int_1);
					int DC2E9580 = num2++;
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							bool flag = false;
							string text = BDBD1D0C[DC2E9580].Split('|')[0];
							RequestXNet fB87CFA = new RequestXNet(string_0, string_1, D282268C, int_0);
							string text2 = fB87CFA.RequestGet("https://mbasic.facebook.com/groups/" + text + "/madminpanel");
							if (text2.Contains("/help/contact/571927962827151") || text2.Contains("madminpanel/pending/"))
							{
								flag = true;
							}
							lock (A21DE59F)
							{
								A21DE59F.Add(BDBD1D0C[DC2E9580] + "|" + flag);
							}
						}
						catch
						{
						}
						Interlocked.Decrement(ref int_1);
					});
					thread.IsBackground = true;
					thread.Start();
				}
				else
				{
					Application.DoEvents();
					Thread.Sleep(200);
				}
			}
			while (int_1 > 0)
			{
				Application.DoEvents();
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
		return A21DE59F;
	}

	public List<string> CheckGroupByToken(bool bool_6)
	{
		List<string> list = new List<string>();
		try
		{
			string input = GetCookieFromChrome();
			string value = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			string input2 = RequestGetHelper("https://mobile.facebook.com/help/");
			string value2 = Regex.Match(input2, Common.Base64Decode("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
			if (value2 == "")
			{
				value2 = Regex.Match(input2, "\"async_get_token\":\"(.*?)\"").Groups[1].Value;
			}
			if (value2 == "")
			{
				input2 = RequestGetHelper("https://m.facebook.com/help/");
				value2 = Regex.Match(input2, Common.Base64Decode("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
				if (value2 == "")
				{
					value2 = Regex.Match(input2, "\"async_get_token\":\"(.*?)\"").Groups[1].Value;
				}
			}
			string string_ = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + value2 + "&filter%5B0%5D=group&viewer=" + value + "&__user=" + value + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
			input2 = RequestGetHelper(string_).Replace("for (;;);", "");
			JObject jObject = JObject.Parse(input2);
			if (jObject["redirect"] != null)
			{
				string_ = jObject["redirect"].ToString();
				input2 = RequestGetHelper(string_).Replace("for (;;);", "");
				jObject = JObject.Parse(input2);
			}
			foreach (JToken item in (IEnumerable<JToken>)jObject["payload"]["entries"])
			{
				try
				{
					list.Add(string.Format("{0}|{1}|{2}", item["uid"], item["text"], item["size"]));
				}
				catch
				{
				}
			}
			if (bool_6)
			{
				list = method_58(list);
			}
		}
		catch
		{
		}
		return list;
	}

	public void CheckLoginFacebook()
	{
		try
		{
			if (GetFbWeb() != 1)
			{
				return;
			}
			for (int i = 0; i < 3; i++)
			{
				string text = CheckExistElements(0.0, new List<string>
				{
					"[role=\"dialog\"] [aria-label=\"[object Object]\"]", "[role=\"dialog\"] [aria-label=\"Not Now\"]", "[role=\"dialog\"] [aria-label=\"Use Page\"]", "[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]", "[aria-label=\"Done\"]", "[aria-label=\"Xong\"]", "[data-visualcompletion=\"ignore\"] [role=\"dialog\"] [role=\"button\"]", "[style=\"transform: translateX(0%) translateZ(1px);\"]>div>div:nth-child(2)>div:nth-child(3)>div", "[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]", "[style=\"padding-top: 40px;\"]>div>div>[role=\"button\"]",
					"[style=\"transform: translateX(0%) translateZ(1px);\"] [role=\"button\"]", "[role=\"dialog\"]>div>div>div:nth-child(3)>div", "[role=\"dialog\"] [style*=\"transform: translate\"]>div>div>div [role=\"button\"]"
				});
				string text2 = text;
				string text3 = text2;
				if (text3 == null)
				{
					break;
				}
				switch (text3.Length)
				{
					default:
						return;
					case 39:
						if (!(text3 == "[role=\"dialog\"] [aria-label=\"Use Page\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 38:
						if (!(text3 == "[role=\"dialog\"] [aria-label=\"Not Now\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 19:
						switch (text3[13])
						{
							default:
								return;
							case 'X':
								if (!(text3 == "[aria-label=\"Xong\"]"))
								{
									return;
								}
								break;
							case 'D':
								if (!(text3 == "[aria-label=\"Done\"]"))
								{
									return;
								}
								break;
						}
						goto IL_02b3;
					case 52:
						if (!(text3 == "[style=\"padding-top: 40px;\"]>div>div>[role=\"button\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 46:
						if (!(text3 == "[role=\"dialog\"] [aria-label=\"[object Object]\"]"))
						{
							return;
						}
						if (CheckExistElement("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]") == 1)
						{
							ExecuteJSClick("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]");
							break;
						}
						if (CheckExistElement("(//*[@role=\"dialog\"]//*[@role=\"radio\"])[last()]") == 1)
						{
							ExecuteJSClick("(//*[@role=\"dialog\"]//*[@role=\"radio\"])[last()]");
						}
						ExecuteJSClick("(//*[@role=\"dialog\"]//*[@aria-label=\"[object Object]\"])[last()]");
						break;
					case 44:
						if (!(text3 == "[role=\"dialog\"]>div>div>div:nth-child(3)>div"))
						{
							return;
						}
						goto IL_02b3;
					case 68:
						if (!(text3 == "[style=\"transform: translateX(0%) translateZ(1px);\"] [role=\"button\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 64:
						if (!(text3 == "[data-visualcompletion=\"ignore\"] [role=\"dialog\"] [role=\"button\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 58:
						if (!(text3 == "[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 94:
						if (!(text3 == "[style=\"transform: translateX(0%) translateZ(1px);\"]>div>div:nth-child(2)>div:nth-child(3)>div"))
						{
							return;
						}
						goto IL_02b3;
					case 75:
						if (!(text3 == "[role=\"dialog\"] [style*=\"transform: translate\"]>div>div>div [role=\"button\"]"))
						{
							return;
						}
						goto IL_02b3;
					case 72:
						{
							if (!(text3 == "[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]"))
							{
								return;
							}
							goto IL_02b3;
						}
					IL_02b3:
						ScrollSmooth(text);
						DelayTime(1.0);
						ExecuteJSClick(text);
						break;
				}
				DelayTime(1.0);
			}
		}
		catch
		{
		}
	}

	public int GetFbWeb(string string_12 = "")
	{
		if (string_12 == "")
		{
			string_12 = GetURL();
		}
		int result = 0;
		if (string_12.StartsWith("https://www.facebook") || string_12.StartsWith("https://facebook") || string_12.StartsWith("https://web.facebook"))
		{
			result = 1;
		}
		else if (string_12.StartsWith("https://m.facebook") || string_12.StartsWith("https://mobile.facebook"))
		{
			result = 2;
		}
		else if (string_12.StartsWith("https://mbasic.facebook") || string_12.StartsWith("https://d.facebook"))
		{
			result = 3;
		}
		return result;
	}

	internal void AcceptCookie()
	{
		if (CheckExistElement("[href=\"/\"]") == 1 && !GetURL().Contains("facebook.com/privacy/consent_framework/prompt/"))
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			if (GetFbWeb() != 1)
			{
				if (CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					ExecuteScript("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
					continue;
				}
				string text = GetURL();
				if (text.Contains("facebook.com/si/actor_experience/actor_gateway"))
				{
					string text2 = CheckExistElements(10.0, new List<string> { "[data-nt=\"NT:IMAGE\"]", "button[data-sigil=\"touchable\"]" });
					if (text2 == "[data-nt=\"NT:IMAGE\"]")
					{
						num++;
						if (num <= 1)
						{
							ExecuteJSClick(text2);
							DelayTime(2.0);
							continue;
						}
						break;
					}
					if (text2 == "button[data-sigil=\"touchable\"]")
					{
						Click(text2);
						DelayTime(2.0);
						break;
					}
				}
				if (text.Contains("facebook.com/legal_consent"))
				{
					ExecuteJSClick("button[type=\"submit\"]");
					DelayTime(1.0);
					ExecuteJSClick("button[type=\"submit\"]:last-child");
					DelayTime(1.0);
					ExecuteJSClick("button[type=\"submit\"]");
					DelayTime(1.0);
					ExecuteJSClick("#consent-page-container button[type=\"submit\"]:last-child");
					DelayTime(1.0);
					continue;
				}
				if (!text.Contains("facebook.com/privacy/consent_framework/prompt/"))
				{
					break;
				}
				if (CheckExistElement("[href=\"/\"]") == 1)
				{
					GotoURL("https://www.facebook.com/");
					continue;
				}
				if (CheckExistElement("[type=\"checkbox\"][name=\"personal_data_toggle\"]") == 1)
				{
					ExecuteScript("document.querySelector('[type=\"checkbox\"][name=\"personal_data_toggle\"]').checked=true;");
				}
				if (CheckExistElement("[type=\"checkbox\"][name=\"data_shared_3pd_toggle\"]") == 1)
				{
					ExecuteScript("document.querySelector('[type=\"checkbox\"][name=\"data_shared_3pd_toggle\"]').checked=true;");
				}
				if (CheckExistElement("[type=\"checkbox\"][name=\"cross_border_data_transfer_toggle\"]") == 1)
				{
					ExecuteScript("document.querySelector('[type=\"checkbox\"][name=\"cross_border_data_transfer_toggle\"]').checked=true;");
				}
				if (CheckExistElement("[type=\"checkbox\"][name=\"location_info_toggle\"]") == 1)
				{
					ExecuteScript("document.querySelector('[type=\"checkbox\"][name=\"location_info_toggle\"]').checked=true;");
				}
				ExecuteJSClick("button[name=\"primary_consent_button\"]");
				DelayTime(2.0);
				continue;
			}
			if (GetURL().Contains("facebook.com/privacy/consent/"))
			{
				if (CheckExistElement("input[role=\"switch\"]") == 1)
				{
					ExecuteScript("document.querySelectorAll('input[role=\"switch\"]').forEach(elm => {if (elm.checked!==true) {elm.click();}})");
				}
				Click("(//div[@role=\"button\"])[last()]");
				break;
			}
			if (CheckExistElement("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label][role=\"button\"]:has(svg)") == 1 && ExecuteJSClick("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label][role=\"button\"]:has(svg)"))
			{
				DelayTime(2.0);
			}
			for (int j = 0; j < 10; j++)
			{
				if (!GetURL().Contains(".facebook.com/privacy/consent/"))
				{
					break;
				}
				if (CheckExistElement("input[role=\"switch\"]") == 1)
				{
					ExecuteScript("document.querySelectorAll('input[role=\"switch\"]').forEach(elm => {if (elm.checked!==true) {elm.click();}})");
				}
				Click("(//div[@role=\"button\"])[last()]");
				DelayTime(2.0);
			}
			break;
		}
	}

	public void E2AE03B6(string F49B4838 = "")
	{
		if (F49B4838 == "")
		{
			F49B4838 = GetURL();
		}
		string_9 = F49B4838;
	}

	public bool method_59(int int_6, string string_12 = "")
	{
		int tickCount = Environment.TickCount;
		while (!CheckIsLive())
		{
			if (string_12 == "")
			{
				string_12 = GetURL();
			}
			if (!(string_9 != string_12))
			{
				if (int_6 == 0)
				{
					break;
				}
				DelayTime(1.0);
				string_12 = "";
				if (Environment.TickCount - tickCount >= int_6 * 1000)
				{
					break;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	internal void method_60()
	{
		string text = "300645083384735";
		GotoURL("https://mobile.facebook.com/privacy/touch/composer/selector/?logging_source=composer_options&paipv=0");
		if (ExecuteScript("return document.querySelector('[href^=\"/privacy/save/\"] [name=\"privacyx\"][value=\"" + text + "\"]').checked").ToString().ToLower() != "true")
		{
			string text2 = ExecuteScript("return document.querySelector('[href^=\"/privacy/save/?privacy_x=" + text + "\"]').getAttribute('href')").ToString();
			if (text2 != "")
			{
				string text3 = DomainFacebook(GetURL());
				text2 = text3 + text2;
				GotoURL(text2);
			}
			else if (CheckExistElement("#modalDialogView [type=\"submit\"]", 5.0) == 1)
			{
				ExecuteJSClick("#modalDialog [data-sigil=\"audience-options-list\"] input[type=\"radio\"]");
				DelayTime(2.0);
				ExecuteJSClick("#modalDialogView [type=\"submit\"]");
				DelayTime(2.0);
			}
		}
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RunScript(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] AA9D2E9C, byte[] byte_3);

	public string RunScript(string content, string json)
	{
		string text = "";
		if (content.Contains("LoginHotmail"))
		{

		}
		else if (content.Contains("GetBase64Captcha"))
		{

			text = ExecuteScript(Common.GetBase64Captcha()).ToString().Replace("data:image/png;base64,", "");
		}
		else if (content.Contains("GetTokenEAAG"))
		{

		}else if (content.Contains("GetTokenEAABs"))
		{

		}else if (content.Contains("Logout")){ }

        return text;

		//string a0988CA = "";
		//if (SettingsTool.GetSettings("configDebug").GetValueBool("ckbUseScriptFile"))
		//{
		//	a0988CA = SettingsTool.GetSettings("configDebug").GetValue("txtFilePath");
		//}
		//return Common.GetListHoEN(RunScript(Common.B2B3DBBA(Int32_3.ToString()), Common.B2B3DBBA(String_7), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA(A3B1A1A9), Common.B2B3DBBA(cssSelectorsOrXpath)));
	}
	public string RunScriptByChrome(Chrome chrome, string content, string json)
	{
		string text = "";
		if (content.Contains("LoginHotmail"))
		{

		}
		else if (content.Contains("GetBase64Captcha"))
		{

			text = ExecuteScript(Common.GetBase64Captcha()).ToString().Replace("data:image/png;base64,", "");
		}
		else if (content.Contains("GetTokenEAAG"))
		{

		}else if (content.Contains("GetTokenEAABs"))
		{

		}else if (content.Contains("Logout")){ }

        return text;

		//string a0988CA = "";
		//if (SettingsTool.GetSettings("configDebug").GetValueBool("ckbUseScriptFile"))
		//{
		//	a0988CA = SettingsTool.GetSettings("configDebug").GetValue("txtFilePath");
		//}
		//return Common.GetListHoEN(RunScript(Common.B2B3DBBA(Int32_3.ToString()), Common.B2B3DBBA(String_7), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA(A3B1A1A9), Common.B2B3DBBA(cssSelectorsOrXpath)));
	}
    public void ClosePopup()
    {
        try
        {
            for (int i = 0; i < 3; i++)
            {
                switch (CheckExistElements(5.0, "[aria-label=\"Done\"]", "[aria-label=\"Xong\"]", "body > div > div > div > div > div > div > div > div > div > div > div > div:nth-child(5) > div", "[data-visualcompletion=\"ignore\"] [role=\"dialog\"] [role=\"button\"]", "[style=\"transform: translateX(0%) translateZ(1px);\"]>div>div:nth-child(2)>div:nth-child(3)>div", "[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]", "[style=\"padding-top: 40px;\"]>div>div>[role=\"button\"]", "[style=\"transform: translateX(0%) translateZ(1px);\"] [role=\"button\"]", "[role=\"dialog\"]>div>div>div:nth-child(3)>div", "[role=\"dialog\"] [style*=\"transform: translate\"]>div>div>div [role=\"button\"]"))
                {
                    default:
                        return;
                    case 1:
                        ScrollSmooth("document.querySelector('[aria-label=\"Done\"]')");
                        DelayTime(1.0);
                        chromeDriver.ExecuteScript("document.querySelector('[aria-label=\"Done\"]').click()");
                        break;
                    case 2:
                        ScrollSmooth("document.querySelector('[aria-label=\"Xong\"]')");
                        DelayTime(1.0);
                        Click(4, "[aria-label=\"Xong\"]");
                        break;
                    case 4:
                        ExecuteScript("document.querySelector('[data-visualcompletion=\"ignore\"] [role=\"dialog\"] [role=\"button\"]').click()");
                        DelayTime(1.0);
                        break;
                    case 5:
                        ScrollSmooth("document.querySelector('[method=\"POST\"]>div>div:nth-child(2)>div>div>div:nth-child(2)>div:nth-child(3) [role=\"button\"]')");
                        DelayTime(1.0);
                        Click(4, "[method=\"POST\"]>div>div:nth-child(2)>div>div>div:nth-child(2)>div:nth-child(3) [role=\"button\"]");
                        DelayTime(1.0);
                        break;
                    case 6:
                        ScrollSmooth("document.querySelector('[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]')");
                        DelayTime(1.0);
                        Click(4, "[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]");
                        DelayTime(1.0);
                        break;
                    case 7:
                        Click(4, "[style=\"padding-top: 40px;\"]>div>div>[role=\"button\"]");
                        DelayTime(1.0);
                        break;
                    case 8:
                        ExecuteScript("document.querySelector('[style=\"transform: translateX(0%) translateZ(1px);\"] [role=\"button\"]').click()");
                        DelayTime(1.0);
                        break;
                    case 9:
                        ExecuteScript("document.querySelector('[role=\"dialog\"]>div>div>div:nth-child(3)>div').click()");
                        DelayRandom(2, 4);
                        break;
                    case 10:
                        ExecuteScript("document.querySelector('[role=\"dialog\"] [style*=\"transform: translate\"]>div>div>div [role=\"button\"]').click()");
                        DelayTime(1.0);
                        break;
                    case 3:
                        break;
                }
                DelayTime(1.0);
            }
        }
        catch
        {
        }
    }

    public void D38ABC24(int int_6 = 2)
	{
		List<string> list = new List<string>();
		switch (int_6)
		{
			case 1:
				list = new List<string> { "https://facebook.com", "https://www.facebook.com", "https://web.facebook.com" };
				break;
			case 2:
				list = new List<string> { "https://mobile.facebook.com", "https://m.facebook.com" };
				break;
			case 3:
				list = new List<string> { "https://d.facebook.com", "https://mbasic.facebook.com" };
				break;
		}
		foreach (string item in list)
		{
			string text = GetURL();
			if (GetFbWeb(text) != int_6)
			{
				string value = Regex.Match(text, "https://(.*?)facebook.com").Value;
				text = text.Replace(value, item);
				if (text.Contains("?") && !text.Contains("?id=") && !text.Contains("?story_fbid") && !text.Contains("recover/password") && !text.Contains("?fbid=") && !text.Contains("?v="))
				{
					text = text.Split('?')[0].TrimEnd('/');
				}
				GotoURL(text);
				DelayTime(2.0);
				continue;
			}
			break;
		}
	}

	internal List<string> GetPhone()
	{
		//string text = RunScript("GetPhone", "");
		//return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (!GetURL().StartsWith("https://mbasic.facebook.com"))
		{
			GotoURL("https://mbasic.facebook.com");
		}
		//string string_ = Common.GetText1("GetPhone");
		string string_ = Common.Getphone();
		string text = ExecuteScript(string_).ToString();
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	internal List<string> GetEmail()
	{
		if (!GetURL().StartsWith("https://www.facebook.com"))
		{
			GotoURL("https://www.facebook.com/api/graphql/");
		}
		//string c = Common.GetText("GetEmail");
		string c = Common.Getemail();
		string text = ExecuteScript(c).ToString();
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	internal string EEAC820C(string string_12)
	{
		if (!GetURL().StartsWith("https://www.facebook.com"))
		{
			GotoURL("https://www.facebook.com/api/graphql/");
		}
		string c = Common.GetText("CheckGroup").Replace("{fb_dtsg}", string_12);
		return ExecuteScript(c).ToString();
	}

	internal string CheckGroupByToken(string string_12)
	{
		if (!GetURL().StartsWith("https://graph.facebook.com/"))
		{
			GotoURL("https://graph.facebook.com/");
		}
		string c = Common.GetText("CheckGroup2").Replace("{token}", string_12);
		return ExecuteScript(c).ToString();
	}

	internal string CheckBM(string string_12)
	{
		if (!GetURL().StartsWith("https://graph.facebook.com/"))
		{
			GotoURL("https://graph.facebook.com/");
		}
		//string cssSelectorsOrXpath = Common.GetText1("CheckBM").Replace("{token}", string_11);
		//return ExecuteScript(cssSelectorsOrXpath).ToString();
		string text = Common.CheckBM(string_11);
		return ExecuteScript(text).ToString();
	} 

        internal string CheckNgayTao_Friend(string string_12)
	{
		if (!GetURL().StartsWith("https://graph.facebook.com/"))
		{
			GotoURL("https://graph.facebook.com/");
		}
		string c = Common.GetText("CheckNgayTao_Friend").Replace("{token}", string_12);
		return ExecuteScript(c).ToString();
	}

	internal string Check_friend_page_ads(string string_10, string string_11, string string_12, string string_13)
	{
        if (!GetURL().StartsWith("https://graph.facebook.com/"))
        {
            GotoURL("https://graph.facebook.com/");
        }
        //string string_14 = Common.GetText1("Check_friend_page_ads").Replace("{token}", string_11).Replace("{friend}", cssSelectorsOrXpath)
        //	.Replace("{page}", EC9B0028)
        //	.Replace("{ads}", content);
        string text = Common.Check_friend_page_ads(string_10,string_11,string_12,string_13);
        return ExecuteScript(text).ToString();
    }

    internal string CheckDating()
    {
        if (!GetURL().StartsWith("https://www.facebook.com"))
        {
            GotoURL("https://www.facebook.com/api/graphql/");
        }
		//string string_ = Common.GetText1("CheckDating");
		string text = Common.CheckDating();
		return ExecuteScript(text).ToString();
    }

    internal void method_65(List<string> F911029D)
	{
		if (!GetURL().StartsWith("https://www.facebook.com") || GetURL().Contains("https://www.facebook.com/api/graphql"))
		{
			GotoURL("https://www.facebook.com/");
		}
		string text = Common.GetText("DeletePhone");
		foreach (string item in F911029D)
		{
			if (ExecuteScript(text.Replace("{phone}", item)).ToString().Contains("Confirmation Required"))
			{
				break;
			}
		}
	}

	public string CheckLocation()
	{
        string result = "";
        try
        {
            if (!GetURL().StartsWith("https://www.facebook.com") || GetURL().Contains("https://www.facebook.com/api/graphql"))
            {
                GotoURL("https://www.facebook.com/");
            }
			//string string_ = Common.GetText1("CheckLocation");
			string string_ = Common.CheckLocation();
			result = ExecuteScript(string_).ToString();
        }
        catch
        {
        }
        return result;
    }

	public string CheckPrimaryLocation()
	{
        string result = "";
        try
        {
            if (!GetURL().StartsWith("https://www.facebook.com"))
            {
                GotoURL("https://www.facebook.com/api/graphql");
            }
			//string string_ = Common.GetText1("CheckPrimaryLocation");
			string text2 = Common.CheckPrimaryLocation();

            result = ExecuteScript(text2).ToString();
        }
        catch
        {
        }
        return result;
    }

	internal void method_66(List<string> FC302F2C)
	{
		if (!GetURL().StartsWith("https://accountscenter.facebook.com/"))
		{
			GotoURL("https://accountscenter.facebook.com/");
		}
		string text = Common.GetText("DeletePhone2");
		foreach (string item in FC302F2C)
		{
			ExecuteScript(text.Replace("{phone}", item)).ToString();
		}
	}

	internal bool AF18F302(string string_12)
	{
		string_12 = string_12.ToLower();
		string string_13 = "[{\"name\":\"email\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = RunScript("AddEmail", string_13);
		try
		{
			JObject jObject = JObject.Parse(json);
			return Convert.ToBoolean(jObject["success"]);
		}
		catch
		{
		}
		return false;
	}

	internal bool AA162921(string string_12)
	{
		string_12 = string_12.ToLower();
		List<string> list = GetEmail();
		list.Remove(string_12);
		if (list.Count == 0)
		{
			return true;
		}
		foreach (string item in list)
		{
			string string_13 = "[{\"name\":\"email\", \"value\":\"" + item + "\", \"type\":\"text\"}]";
			RunScript("DeleteEmail", string_13);
		}
		list = GetEmail();
		list.Remove(string_12);
		return list.Count == 0;
	}

	internal void F525711E(List<string> E9312C22)
	{
		string text = Common.GetText("DeleteMail2");
		if (!GetURL().StartsWith("https://accountscenter.facebook.com/"))
		{
			GotoURL("https://accountscenter.facebook.com/");
		}
		foreach (string item in E9312C22)
		{
			ExecuteScript(text.Replace("{email}", item)).ToString();
		}
	}

	internal void FA9CB799(bool CD26589B, bool bool_6)
	{
		string text = "";
		string c = Common.GetText("CheckSessionFb");
		if (!GetURL().StartsWith("https://www.facebook.com") || GetURL().Contains("https://www.facebook.com/api/graphql"))
		{
			GotoURL("https://www.facebook.com/");
		}
		text = ExecuteScript(c).ToString();
		c = Common.GetText("LogoutOldDevice");
		try
		{
			string text2 = "";
			JObject jObject = JObject.Parse(text);
			JToken jToken = jObject["data"]["security_settings"]["sessions"]["edges"];
			foreach (JToken item in (IEnumerable<JToken>)jToken)
			{
				try
				{
					bool flag = Convert.ToBoolean(item["node"]["is_active"].ToString());
					string text3 = item["node"]["sid"].ToString();
					if (text3 != "")
					{
						if (flag && bool_6)
						{
							text2 = text3;
						}
						if (!flag && CD26589B)
						{
							text = ExecuteScript(c.Replace("{sid}", text3)).ToString();
						}
					}
				}
				catch
				{
				}
			}
			if (text2 != "")
			{
				text = ExecuteScript(c.Replace("{sid}", text2)).ToString();
			}
		}
		catch
		{
		}
	}

	public bool F23E289E(string string_12, string string_13)
	{
		bool result = false;
		if (!Base.bool_0)
		{
			return false;
		}
		return result;
	}

	internal string CC10F3A8(string string_12, string string_13)
	{
		string text = "";
		string_12 = string_12.RandomChar();
		if (string_12 == "")
		{
			string text2 = (from D8849F0A in SetupFolder.GetListHoVN()
				orderby Guid.NewGuid()
				select D8849F0A).First();
			string text3 = (from string_0 in SetupFolder.GetListTenDemVN()
				orderby Guid.NewGuid()
				select string_0).First().Trim();
			string text4 = (from string_0 in SetupFolder.GetListTenVN()
				orderby Guid.NewGuid()
				select string_0).First();
			string_12 = text2 + ((text3 == "") ? " " : (" " + text3 + " ")) + text4;
		}
		if (string_13 == "")
		{
			string_13 = Common.RandomStringOrNumber(1, "a_A");
		}
		if (!Base.bool_0 || !Common.IsNumber(string_13))
		{
			string string_14 = "[aria-label^=\"Category\"] input";
			string text5 = "[role=\"listbox\"] [role=\"option\"]";
			string text6 = "[aria-label=\"Create Page\"]";
			string string_15 = text6 + " [role=\"progressbar\"]";
			SetFbLanguage();
			SetSize();
			GotoURL("https://www.facebook.com/pages/?category=your_pages&ref=bookmarks");
			DelayTime(2.0);
			//List<string> second = HDKhangSpam();
			int tickCount = Environment.TickCount;
			int num = 60;
			while (true)
			{
				string text7 = CheckExistElements(0.0, new List<string> { "[aria-label^=\"Page name\"] input", "[href^=\"/pages/creation/\"]" });
				string text8 = text7;
				string text9 = text8;
				if (text9 == "[href^=\"/pages/creation/\"]")
				{
					Click(text7);
				}
				else if (!(text9 == "[aria-label^=\"Page name\"] input"))
				{
					CheckLoginFacebook();
				}
				else
				{
					Click(text7);
					SelectText(text7);
					SendKeys(text7, string_12);
					DelayTime(2.0);
					Click(string_14);
					SendKeys(string_14, string_13);
					DelayTime(2.0);
					if (CheckExistElement(text5, 10.0) == 0)
					{
						ClearText();
					}
					else
					{
						Click(text5);
						DelayTime(2.0);
						Click(text6);
						DelayTime(2.0);
						if (WaitForSearchElement(string_15, 1, 30.0) != 0)
						{
                            //text = HDKhangSpam().Except(second).FirstOrDefault();
                            text = "";
                            if (!string.IsNullOrEmpty(text))
							{
								Refresh();
								try
								{
									chromeDriver.SwitchTo().Alert().Accept();
								}
								catch
								{
								}
							}
							break;
						}
					}
				}
				if (Environment.TickCount - tickCount > num * 1000)
				{
					break;
				}
				DelayTime(2.0);
			}
			RetoreSize();
		}
		return text;
	}

	internal bool method_67(string DEA61187, string string_12)
	{
		bool result = false;
		if (!Base.bool_0)
		{
		}
		return result;
	}

	public string method_68()
	{
		return Regex.Match(GetCookieFromChrome(), "i_user=(\\d+)").Groups[1].Value;
	}

	internal bool C2A86A3B(string string_12, string A8389323)
	{
		if (!Base.bool_0)
		{
			return false;
		}
		return false;
	}

	public List<string> method_69()
	{
		List<string> list = new List<string>();
		if (!GetURL().StartsWith("https://www.facebook.com"))
		{
			GotoURL("https://www.facebook.com/api/graphql");
		}
		string c = Common.GetText("GetPagePro5");
		string text = ExecuteScript(c).ToString();
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	public void method_70(string string_12)
	{
		try
		{
			Cookie cookie = new Cookie("i_user", string_12, ".facebook.com", "/", DateTime.Now.AddDays(10.0));
			chromeDriver.Manage().Cookies.AddCookie(cookie);
			Refresh();
		}
		catch (Exception exception_)
		{
			ExportError(exception_);
		}
	}

	public void method_71()
	{
		if (GetFbWeb() != 1)
		{
			GotoURL("https://www.facebook.com/");
		}
		string c = Common.GetText("IncomingCallSounds");
		ExecuteScript(c).ToString();
		c = Common.GetText("MessageSounds");
		ExecuteScript(c).ToString();
		c = Common.GetText("PopupNewMessages");
		ExecuteScript(c).ToString();
		c = Common.GetText("ShowContacts");
		ExecuteScript(c).ToString();
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RunCode(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	public string RunCode(string string_12)
	{
		return Common.smethod_6(RunCode(Common.B2B3DBBA(Int32_3.ToString()), Common.B2B3DBBA(String_7), Common.B2B3DBBA(string_12)));
	}

	public string GetTokenEAABs()
	{
		string text = RunScript("GetTokenEAABs", "");
		if (!text.StartsWith("EAA"))
		{
			text = "";
		}
		return text;
        //string result = "";
        //try
        //{
        //    instance.ClearText("https://www.facebook.com/adsmanager/manage/campaigns?act=");
        //    string input = instance.method_4();
        //    CreateRandomStringNumber(instance, "https://www.facebook.com/adsmanager/manage/campaigns?act=", instance.Click());
        //    result = Regex.Match(input, "(EAABs.*?)\"").Groups[1].Value;
        //}
        //catch
        //{
        //}
        //return result;
    }

	public string GetTokenEAABw()
	{
		string text = RunScript("GetTokenEAABw", "");
		if (!text.StartsWith("EAA"))
		{
			text = "";
		}
		return text;
        //try
        //{
        //    if (!instance.Click().StartsWith("https://www.face"))
        //    {
        //        instance.ClearText("https://www.facebook.com/");
        //    }
        //    instance.HDHuyKetBan(1.0);
        //    string text = instance.HDTimKiemGoogle("return require('DTSGInitData').token").ToString();
        //    string value = Regex.Match(instance.HDTimKiemGoogle("return document.cookie").ToString(), "c_user=(.*?);").Groups[1].Value;
        //    string string_ = "fb_dtsg=" + text + "&app_id=124024574287414&redirect_uri=fbconnect%3A%2F%2Fsuccess&display=page&access_token=&from_post=1&return_format=access_token&domain=&sso_device=ios&_CONFIRM=1&_user=" + value;
        //    string input = CreateRandomNumber(instance, "https://www.facebook.com/v1.0/dialog/oauth/confirm", string_, instance.Click());
        //    result = Regex.Match(input, "access_token=(.*?)&").Groups[1].Value;
        //}
        //catch
        //{
        //}
    }

	public string GetTokenEAAG()
	{
		string text = "";
		for (int i = 0; i < 3; i++)
		{
			string text2 = cFa2;
			string string_ = "[{\"name\":\"fa2\", \"value\":\"" + text2 + "\", \"type\":\"text\"}]";
			text = RunScript("GetTokenEAAG", string_);
			if (text.StartsWith("EAA"))
			{
				break;
			}
			DelayTime(3.0);
		}
		return text;
		//string result = "";
		//try
		//{
		//    if (!chrome.GetURL().Contains("https://business.facebook.com/business_locations"))
		//    {
		//        chrome.GotoURL("https://business.facebook.com/business_locations");
		//        chrome.DelayTime(1.0);
		//    }
		//    for (int i = 0; i < 5; i++)
		//    {
		//        if (chrome.CheckExistElement("#globalContainer [type=\"text\"]") != 1)
		//        {
		//            break;
		//        }
		//        chrome.ClearText(4, "#globalContainer [type=\"text\"]");
		//        chrome.DelayTime(1.0);
		//        chrome.SendKeys(4, "#globalContainer [type=\"text\"]", Common.GetTotp(text));
		//        chrome.DelayTime(1.0);
		//        chrome.SendEnter(4, "#globalContainer [type=\"text\"]");
		//        chrome.DelayTime(5.0);
		//    }
		//    string input = chrome.GetPageSource();
		//    result = Regex.Match(input, "EAAG(.*?)\"").Value.Replace("'", "").Replace("\"", "");
		//}
		//catch
		//{
		//}
		//return result;
	}

	public bool Logout()
	{
		try
		{
			string json = RunScript("Logout", "");
			JObject jObject = JObject.Parse(json);
			return Convert.ToBoolean(jObject["success"]);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public string UnlinkInstagram()
	{
		return RunScript("UnlinkInstagram", "");
	}

	public string UnlockProfile()
	{
		return RunScript("UnlockProfile", "");
	}

	public string LoginHotmail(string string_12, string string_13, string FB195F99)
	{
		bool flag = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbThemKyTuGetnada");
		int num = SettingsTool.GetSettings("configHotmail").GetValueInt("typeKyTu");
		string text = SettingsTool.GetSettings("configHotmail").GetValue("txtKyTuChiDinh");
		int num2 = SettingsTool.GetSettings("configHotmail").GetValueInt("nudTimeoutGetOtpGetnada", 60);
		string text2 = SettingsTool.GetSettings("configHotmail").GetValue("cbbDomain", "getnada.com");
		int num3 = SettingsTool.GetSettings("configHotmail").GetValueInt("typePassword");
		string text3 = SettingsTool.GetSettings("configHotmail").GetValue("txtPassChiDinh");
		string text4 = SettingsTool.GetSettings("configHotmail").GetValueList("lstProxyGetnada").GetRandomItem();
		string string_14 = "[{\"name\":\"email\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"passmail\", \"value\":\"" + string_13 + "\", \"type\":\"text\"},{\"name\":\"mailRecover\", \"value\":\"" + FB195F99 + "\", \"type\":\"text\"}" + $",{{\"name\":\"timeout\", \"value\":\"{num2 + 60}\", \"type\":\"number\"}}" + $",{{\"name\":\"timeoutGetOtp\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"isThemKyTu\", \"value\":\"{flag}\", \"type\":\"bool\"}}" + $",{{\"name\":\"typeKyTu\", \"value\":\"{num}\", \"type\":\"number\"}}" + ",{\"name\":\"domain\", \"value\":\"" + text2 + "\", \"type\":\"text\"},{\"name\":\"kyTuChiDinh\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"typePassword\", \"value\":\"{num3}\", \"type\":\"number\"}}" + ",{\"name\":\"passChiDinh\", \"value\":\"" + text3 + "\", \"type\":\"text\"},{\"name\":\"proxyGetnada\", \"value\":\"" + text4 + "\", \"type\":\"text\"}]";
		return RunScript("LoginHotmail", string_14);
	}
	public string LoginHotmailChrome(int row, int typemail, string email, string passmail, Chrome chrome)
	{
        //login hotmail
        bool flaglogin = false;
        switch (typemail)
        {
            case 1:
                {
                    chrome.GotoURL("https://accounts.google.com/signin/v2/identifier?flowName=GlifWebSignIn&flowEntry=ServiceLogin");
                    chrome.DelayTime(1.0);
                    if (chrome.CheckExistElementv2("[name=\"identifier\"]", 10.0) != 1)
                    {
                        break;
                    }
                    chrome.SendKeys(2, "identifier", email);
                    chrome.DelayTime(0.1);
                    chrome.Click(4, "#identifierNext button");
                    for (int j = 0; j < 10; j++)
                    {
                        if (chrome.CheckExistElementv2("[name=\"password\"]") == 1)
                        {
                            break;
                        }
                        string text2sc = chrome.ExecuteScript("var out=''; document.querySelectorAll('form[method=\"post\"] [aria-live=\"assertive\"]').forEach(e=>{out+=e.innerText});return out").ToString();
                        if (!(text2sc != ""))
                        {
                            if (!chrome.GetURL().Contains("deleted_account"))
                            {
                                if (!chrome.GetURL().Contains("deniedsigninrejected"))
                                {
                                    chrome.DelayTime(1.0);
                                    continue;
                                }
                                return "Trình duyệt không cho đăng nhập!";
                            }
                            return "Tài khoản đã bị xóa!";
                        }
                        return text2sc;
                    }
                    if (chrome.CheckExistElementv2("[name=\"password\"]") == 1)
                    {
                        chrome.DelayTime(2.0);
                        chrome.SendKeys(2, "password", passmail);
                        chrome.DelayTime(2.0);
                        chrome.Click(4, "#passwordNext button", 0, 0, "", 0, 10);
                        int num4 = 0;
                        while (true)
                        {
                            if (num4 < 10)
                            {
                                string text3sc = chrome.ExecuteScript("var out=''; document.querySelectorAll('form[method=\"post\"] [aria-live=\"assertive\"]').forEach(e=>{out+=e.innerText});return out").ToString();
                                if (!(text3sc != ""))
                                {
                                    if (chrome.GetURL().Contains("myaccount.google.com") || chrome.GetURL().Contains("https://gds.google.com/web/chip") || chrome.GetURL().Contains("https://mail.google.com/mail/u/0/"))
                                    {
                                        break;
                                    }
                                    if (chrome.GetURL().Contains("https://accounts.google.com/speedbump/gaplustos"))
                                    {
                                        chrome.Click(4, "[name=\"accept\"]");
                                    }
                                    if (chrome.CheckExistElementv2("#phoneNumberId") != 1)
                                    {
                                        chrome.DelayTime(1.0);
                                        num4++;
                                        continue;
                                    }
                                    return "Bắt xác minh sdt!";
                                }
                                return text3sc;
                            }
                            if (!chrome.GetURL().Contains("https://accounts.google.com/signin/v2/challenge/"))
                            {
                                break;
                            }
                            return "Bắt xác minh!";
                        }
                        if (!chrome.GetURL().StartsWith("https://mail.google.com/mail/u/0/"))
                        {
                            chrome.GotoURL("https://mail.google.com/mail/u/0/");
                        }
                        if (chrome.GetURL().Contains("https://www.google.com/intl/vi/gmail/about/"))
                        {
                            return "Đăng nhập thất bại!";
                        }
                        break;
                    }
                    return "Đăng nhập thất bại!";
                }
            case 0:

                if (email.Contains("hotmail") || email.Contains("outlook"))
                {
                    chrome.GotoURL("https://login.live.com/login.srf");
                    chrome.DelayTime(1.0);
                    if (!(chrome.chromeDriver.Url.Contains("https://login.live.com/login.srf")))
                    {
                        flaglogin = true;
                        break;
                    }
                    if (chrome.CheckExistElementv2("[name=\"loginfmt\"]", 10.0) != 1)
                    {
                        break;
                    }
                    chrome.SendKeys(2, "loginfmt", email);
                    chrome.DelayTime(0.1);
                    chrome.Click(1, "idSIButton9");
                    if (chrome.CheckExistElementv2("[name=\"passwd\"]", 10.0) != 1)
                    {
                        break;
                    }
                    chrome.DelayTime(2.0);
                    chrome.SendKeys(2, "passwd", passmail);
                    chrome.DelayTime(2.0);
                    chrome.Click(1, "idSIButton9", 0, 0, "", 0, 10);
                    try
                    {
                        chrome.DelayTime(1.0);
                        chrome.Click(1, "id__0", 0, 0, "", 0, 10);
                        chrome.DelayTime(.0);
                        chrome.Click(1, "id__0", 0, 0, "", 0, 10);

                    }
                    catch { }
                    for (int i = 0; i < 10; chrome.DelayTime(1.0), i++)
                    {
                        switch (chrome.CheckExistElements(0.0, "[name=\"DontShowAgain\"]", "#O365_MainLink_NavMenu", "#reload-button", "#iProof0"))
                        {
                            default:
                                switch (chrome.CheckExistElements(0.0, "#idA_IL_ForgotPassword0", "[name=\"passwd\"]"))
                                {
                                    case 2:
                                        return "Không có pass mail!";
                                    case 1:
                                        return "Mail sai pass!";
                                }
                                if (chrome.GetURL().Contains("https://account.live.com/Abuse"))
                                {
                                    return "Mail đã bị khóa!";
                                }
                                continue;
                            case 3:
                                chrome.Click(4, "#reload-button");
                                continue;
                            case 4:
                                if (chrome.chromeDriver.PageSource.Contains("@getnada.com"))
                                {
                                    //chrome.ExecuteScript("document.querySelector('#iProof0').click()");
                                    chrome.ExecuteScript("document.querySelectorAll('[name=\"proof\"]').forEach(e=>{if(e.getAttribute('value').includes('getnada.com')) e.click()})");
                                    chrome.DelayTime(1.0);
                                    string textz = email.Split('@')[0];
                                    //if (textz == "")
                                    //{
                                    //    SetCellAccount(row, "cMailRecovery", email.Split('@')[0] + "@getnada.com");
                                    //    CommonSQL.UpdateFieldToAccount(cellAccount, "mailrecovery", email.Split('@')[0] + "@getnada.com");
                                    //    text3 = notice2.Split('@')[0];
                                    //}
                                    //else
                                    //{
                                    //    text3 = text3.Split('@')[0];
                                    //}
                                    chrome.SendKeys(1, "iProofEmail", textz);
                                    chrome.DelayTime(1.0);
                                    chrome.ExecuteScript("document.querySelector('#iSelectProofAction').click()");
                                    chrome.DelayTime(5.0);
                                    if (chrome.CheckExistElementv2("#iOttText", 10.0) == 1)
                                    {
                                        string otpFromGetnada = OtpMailHelper.GetOtpGetnada_New(textz + "@getnada.com", 7);
                                        if (otpFromGetnada != "")
                                        {
                                            chrome.SendKeys(1, "iOttText", otpFromGetnada);
                                            chrome.DelayTime(1.0);
                                            chrome.ExecuteScript("document.querySelector('#iVerifyCodeAction').click()");
                                            chrome.DelayTime(1.0);
                                        }
                                    }
                                    continue;
                                }
                                return "Không tìm thấy mail khôi phục!";
                            case 1:
                                chrome.Click(2, "DontShowAgain");
                                chrome.DelayTime(0.1);
                                chrome.Click(1, "idSIButton9");
                                break;
                            case 2:
                                break;
                        }
                        break;
                    }
                    if (!chrome.GetURL().StartsWith("https://outlook.live.com"))
                    {
                        chrome.GotoURL("https://outlook.live.com/mail/0/");
                    }
                    if (chrome.CheckExistElementv2("#iShowSkip") == 1)
                    {
                        chrome.Click(4, "#iShowSkip");
                    }
                    flaglogin = true;
                    break;
                }
                if (email.Contains("yandex"))
                {
                    chrome.GotoURL("https://passport.yandex.com/auth?from=mail&origin=hostroot_homer_auth_com&retpath=https%3A%2F%2Fmail.yandex.com%2F&backpath=https%3A%2F%2Fmail.yandex.com%3Fnoretpath%3D1");
                    chrome.DelayTime(1.0);
                    if (chrome.CheckExistElementv2("#passp-field-login", 10.0) != 1)
                    {
                        break;
                    }
                    chrome.SendKeys(1, "passp-field-login", email);
                    chrome.DelayTime(0.1);
                    chrome.Click(4, ".Button2_type_submit");
                    if (chrome.CheckExistElementv2("#passp-field-passwd", 10.0) != 1)
                    {
                        break;
                    }
                    chrome.SendKeys(1, "passp-field-passwd", passmail);
                    chrome.DelayTime(0.1);
                    chrome.Click(4, ".Button2_type_submit");
                    while (true)
                    {
                        switch (chrome.CheckExistElements(10.0, ".mail-ComposeButton", ".Textinput-Hint_state_error", "[data-t=\"phone_skip\"]"))
                        {
                            case 3:
                                goto IL_0db6;
                            case 1:
                                flaglogin = true;
                                break;
                        }
                        break;
                    IL_0db6:
                        chrome.DelayTime(1.0);
                        chrome.Click(4, "[data-t=\"phone_skip\"]");
                        chrome.DelayTime(2.0);
                    }
                    break;
                }
                chrome.GotoURL("https://outlook.office.com/mail/inbox");
                chrome.DelayTime(1.0);
                if (chrome.CheckExistElementv2("[name=\"loginfmt\"]", 10.0) != 1)
                {
                    break;
                }
                chrome.SendKeys(2, "loginfmt", email);
                chrome.DelayTime(0.1);
                chrome.Click(1, "idSIButton9");
                if (chrome.CheckExistElementv2("[name=\"passwd\"]", 10.0) == 1)
                {
                    chrome.SendKeys(2, "passwd", passmail);
                    chrome.DelayTime(2.0);
                    chrome.Click(1, "idSIButton9", 0, 0, "", 0, 10);
                    int num = chrome.CheckExistElements(10.0, "[name=\"DontShowAgain\"]", "#O365_MainLink_NavMenu");
                    int num3 = num;
                    if (num3 == 1)
                    {
                        chrome.Click(2, "DontShowAgain");
                        chrome.DelayTime(0.1);
                        chrome.Click(1, "idSIButton9");
                    }
                    chrome.GotoURLIfNotExist("https://outlook.office.com/mail/inbox");
                    flaglogin = true;
                }
                break;
        }
        if (flaglogin)
        {
			return "Đăng nhâ\u0323p thành công!";
        }
        else
        {
			return "Đăng nhâ\u0323p thất bại!";
        }
    }

	public string ProfessionalMode(bool E924BE9D)
	{
		string string_ = $"[{{\"name\":\"isEnable\", \"value\":\"{E924BE9D}\", \"type\":\"bool\"}}]";
		return RunScript("ProfessionalMode", string_);
	}

	public string AddMailKhoiPhuc(string FD08643F, string string_12, string string_13)
	{
		bool flag = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbThemKyTuGetnada");
		int num = SettingsTool.GetSettings("configHotmail").GetValueInt("typeKyTu");
		string text = SettingsTool.GetSettings("configHotmail").GetValue("txtKyTuChiDinh");
		int num2 = SettingsTool.GetSettings("configHotmail").GetValueInt("nudTimeoutGetOtpGetnada", 60);
		string text2 = SettingsTool.GetSettings("configHotmail").GetValue("cbbDomain", "getnada.com");
		int num3 = SettingsTool.GetSettings("configHotmail").GetValueInt("typePassword");
		string text3 = SettingsTool.GetSettings("configHotmail").GetValue("txtPassChiDinh");
		string text4 = SettingsTool.GetSettings("configHotmail").GetValueList("lstProxyGetnada").GetRandomItem();
		string string_14 = "[{\"name\":\"email\", \"value\":\"" + FD08643F + "\", \"type\":\"text\"},{\"name\":\"passmail\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"mailRecover\", \"value\":\"" + string_13 + "\", \"type\":\"text\"}" + $",{{\"name\":\"timeout\", \"value\":\"{num2 + 60}\", \"type\":\"number\"}}" + $",{{\"name\":\"timeoutGetOtp\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"isThemKyTu\", \"value\":\"{flag}\", \"type\":\"bool\"}}" + $",{{\"name\":\"typeKyTu\", \"value\":\"{num}\", \"type\":\"number\"}}" + ",{\"name\":\"domain\", \"value\":\"" + text2 + "\", \"type\":\"text\"},{\"name\":\"kyTuChiDinh\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"typePassword\", \"value\":\"{num3}\", \"type\":\"number\"}}" + ",{\"name\":\"passChiDinh\", \"value\":\"" + text3 + "\", \"type\":\"text\"},{\"name\":\"proxyGetnada\", \"value\":\"" + text4 + "\", \"type\":\"text\"}]";
		return RunScript("AddMailKhoiPhuc", string_14);
	}

	public string XoaMailKhoiPhuc(string string_12, string string_13, string string_14)
	{
		string text = SettingsTool.GetSettings("configHotmail").GetValueList("lstProxyGetnada").GetRandomItem();
		string string_15 = "[{\"name\":\"email\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"passmail\", \"value\":\"" + string_13 + "\", \"type\":\"text\"},{\"name\":\"mailRecover\", \"value\":\"" + string_14 + "\", \"type\":\"text\"},{\"name\":\"timeout\", \"value\":\"120\", \"type\":\"number\"},{\"name\":\"timeoutGetOtp\", \"value\":\"60\", \"type\":\"number\"},{\"name\":\"proxyGetnada\", \"value\":\"" + text + "\", \"type\":\"text\"}]";
		return RunScript("XoaMailKhoiPhuc", string_15);
	}

	public string DoiPassHotmail(string DF82D3BA, string FB34CFB5, string string_12)
	{
		bool flag = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbThemKyTuGetnada");
		int num = SettingsTool.GetSettings("configHotmail").GetValueInt("typeKyTu");
		string text = SettingsTool.GetSettings("configHotmail").GetValue("txtKyTuChiDinh");
		int num2 = SettingsTool.GetSettings("configHotmail").GetValueInt("nudTimeoutGetOtpGetnada", 60);
		string text2 = SettingsTool.GetSettings("configHotmail").GetValue("cbbDomain", "getnada.com");
		int num3 = SettingsTool.GetSettings("configHotmail").GetValueInt("typePassword");
		string text3 = SettingsTool.GetSettings("configHotmail").GetValue("txtPassChiDinh");
		string text4 = SettingsTool.GetSettings("configHotmail").GetValueList("lstProxyGetnada").GetRandomItem();
		string string_13 = "[{\"name\":\"email\", \"value\":\"" + DF82D3BA + "\", \"type\":\"text\"},{\"name\":\"passmail\", \"value\":\"" + FB34CFB5 + "\", \"type\":\"text\"},{\"name\":\"mailRecover\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}" + $",{{\"name\":\"timeout\", \"value\":\"{num2 + 60}\", \"type\":\"number\"}}" + $",{{\"name\":\"timeoutGetOtp\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"isThemKyTu\", \"value\":\"{flag}\", \"type\":\"bool\"}}" + $",{{\"name\":\"typeKyTu\", \"value\":\"{num}\", \"type\":\"number\"}}" + ",{\"name\":\"domain\", \"value\":\"" + text2 + "\", \"type\":\"text\"},{\"name\":\"kyTuChiDinh\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"typePassword\", \"value\":\"{num3}\", \"type\":\"number\"}}" + ",{\"name\":\"passChiDinh\", \"value\":\"" + text3 + "\", \"type\":\"text\"},{\"name\":\"proxyGetnada\", \"value\":\"" + text4 + "\", \"type\":\"text\"}]";
		return RunScript("DoiPassHotmail", string_13);
	}

	public string ChangeBirthday(string string_12, string DC8FA593, string BB3CBF31)
	{
		string string_13 = "[{\"name\":\"day\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"month\", \"value\":\"" + DC8FA593 + "\", \"type\":\"text\"},{\"name\":\"year\", \"value\":\"" + BB3CBF31 + "\", \"type\":\"text\"}]";
		return RunScript("ChangeBirthday", string_13);
	}

	public string ChangeNickname(string string_12)
	{
		string string_13 = "[{\"name\":\"name\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		return RunScript("ChangeNickname", string_13);
	}

	public string XoaThietBiTinCay()
	{
		return RunScript("XoaThietBiTinCay", "");
	}
    public bool XoaThietBiTinCayChrome(Chrome chrome)
    {
        bool result = false;
        try
        {
            chrome.GotoURL("https://m.facebook.com/settings/security/two_factor/devices/");
            int tickCount = Environment.TickCount;
            do
            {
                if (chrome.CheckExistElementv2("[data-sigil$=\"removable-area-button\"]", 5.0) == 1)
                {
                    chrome.DelayTime(1.0);
                    chrome.SelectText("[data-sigil$=\"removable-area-button\"]");
                    continue;
                }
                return result;
            }
            while (Environment.TickCount - tickCount < 60000);
            return result;
        }
        catch
        {
            return result;
        }
    }

    public string AllowFollow()
	{
		return RunScript("AllowFollow", "");
	}
    public bool AllowFollowChrome(Chrome chrome)
    {
        bool result = true;
        try
        {
            chrome.GotoURL("https://m.facebook.com/settings/subscribe/");
            chrome.DelayTime(1.0);
            string text = chrome.CheckExistElements(10.0, new List<string> { "[data-sigil=\"audience-options-list\"]>label", "[href^=\"/settings/subscribe/save/?setting=follow_optin&optin=\"]" });
            if (text == "[href^=\"/settings/subscribe/save/?setting=follow_optin&optin=\"]")
            {
                chrome.SelectText("[href^=\"/settings/subscribe/save/?setting=follow_optin&optin=1\"]");
                return result;
            }
            if (text == "[data-sigil=\"audience-options-list\"]>label")
            {
                chrome.SelectText("[data-sigil=\"audience-options-list\"]>label");
                return result;
            }
            return result;
        }
        catch
        {
            return result;
        }
    }

    public string RemoveEmailMfb(string FA329E92, string A99F7DA0)
	{
		string string_ = "[{\"name\":\"password\", \"value\":\"" + FA329E92 + "\", \"type\":\"text\"},{\"name\":\"email\", \"value\":\"" + A99F7DA0 + "\", \"type\":\"text\"}]";
		return RunScript("RemoveEmailMfb", string_);
	}

	public string RemovePhone(string B3BA973F, int F6960AA6)
	{
		string string_ = $"[{{\"name\":\"password\", \"value\":\"{B3BA973F}\", \"type\":\"text\"}},{{\"name\":\"typeWeb\", \"value\":\"{F6960AA6}\", \"type\":\"number\"}}]";
		return RunScript("RemovePhone", string_);
	}

	public string Disable2FA(string E509760E)
	{
		string string_ = "[{\"name\":\"password\", \"value\":\"" + E509760E + "\", \"type\":\"text\"}]";
		return RunScript("Disable2FA", string_);
	}

	public string Enable2FA(string string_12, int int_6)
	{
		string string_13 = $"[{{\"name\":\"password\", \"value\":\"{string_12}\", \"type\":\"text\"}},{{\"name\":\"neuDaCo2FA\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		return RunScript("Enable2FA", string_13);
	}

	public bool CheckFacebookBlocked()
	{
		if (Boolean_2)
		{
			return true;
		}
		bool flag = false;
		string text = GetURL();
		if (text.Contains("facebook.com/feature_limit_notice") || text.Contains("facebook.com/si/actor_experience/actor_gateway"))
		{
			flag = true;
		}
		else if (CheckExistElements(0.0, "[href*=\"facebook.com/help/177066345680802\"]", "[href*=\"facebook.com/help/contact/571927962827151\"]", "#captcha_response") != 0)
		{
			flag = true;
		}
		else if (CheckExistElement("//span[starts-with(text(),'Your account is restricted')]") == 1)
		{
			flag = true;
		}
		if (flag)
		{
			Boolean_2 = true;
		}
		return flag;
	}

	internal string CrawlPost(string E6275029)
	{
		string string_ = "[{\"name\":\"id\", \"value\":\"" + E6275029 + "\", \"type\":\"text\"}]";
		return RunScript("CrawlPost", string_);
	}

	internal bool ReactionWWW(string string_12, int int_6 = -1)
	{
		string string_13 = "[{\"name\":\"reaction\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		string json = RunScript("ReactionWWW", string_13);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			Boolean_2 = jObject["error"].ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_86(string AA13368D, string string_12)
	{
		bool result = false;
		while (true)
		{
			if (cToken == "")
			{
				cToken = GetTokenEAAG();
				if (cToken == "")
				{
					break;
				}
			}
			string string_13 = "https://graph.beta.facebook.com/" + AA13368D + "/comments?access_token=" + cToken + "&method=post&message=" + Common.UrlEncode(string_12);
			GotoURL(string_13);
			string text = GetPageSource();
			if (!text.Contains("\"id\""))
			{
				if (new Class65("", "", "", 0, "").method_3(text))
				{
					cToken = "";
					continue;
				}
				if (text.Contains("temporarily restricted"))
				{
					Boolean_2 = true;
				}
				break;
			}
			result = true;
			break;
		}
		return result;
	}

	internal bool CommentWWW(JSON_Settings gclass8_0, int EB3356A7 = -1)
	{
		string text = gclass8_0.GetValue("content").Replace("\r\n", "\n").Replace("\n", "\\\\n");
		string text2 = gclass8_0.GetValue("image").Replace("\\", "\\\\\\\\");
		bool flag = gclass8_0.GetValueBool("ckbDeleteComment");
		int num = gclass8_0.GetValueInt("nudDelayDeleteFrom");
		int num2 = gclass8_0.GetValueInt("nudDelayDeleteTo");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"},{\"name\":\"image\", \"value\":\"" + text2 + "\", \"type\":\"text\"}" + $",{{\"name\":\"ckbDeleteComment\", \"value\":\"{flag}\", \"type\":\"bool\"}}" + $",{{\"name\":\"nudDelayDeleteFrom\", \"value\":\"{num}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayDeleteTo\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"indexPost\", \"value\":\"{EB3356A7}\", \"type\":\"number\"}}]";
		string json = RunScript("CommentWWW", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			Boolean_2 = jObject["error"].ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_88(JSON_Settings gclass8_0, int int_6 = -1)
	{
		string text = gclass8_0.GetValue("content").Replace("\r\n", "\n").Replace("\n", "\\\\n");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		string json = RunScript("ShareWallWWW", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			Boolean_2 = jObject["error"].ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool F3A70432(string string_12, int int_6 = -1)
	{
		string string_13 = "[{\"name\":\"reaction\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		string json = RunScript("ReactionMfb", string_13);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			Boolean_2 = jObject["error"].ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_89(JSON_Settings gclass8_0, int int_6 = -1)
	{
		string text = gclass8_0.GetValue("content").Replace("\r\n", "\n").Replace("\n", "\\\\n");
		string text2 = gclass8_0.GetValue("image").Replace("\\", "\\\\\\\\");
		bool flag = gclass8_0.GetValueBool("ckbDeleteComment");
		int num = gclass8_0.GetValueInt("nudDelayDeleteFrom");
		int num2 = gclass8_0.GetValueInt("nudDelayDeleteTo");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"},{\"name\":\"image\", \"value\":\"" + text2 + "\", \"type\":\"text\"}" + $",{{\"name\":\"ckbDeleteComment\", \"value\":\"{flag}\", \"type\":\"bool\"}}" + $",{{\"name\":\"nudDelayDeleteFrom\", \"value\":\"{num}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayDeleteTo\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		string json = RunScript("CommentMfb", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			Boolean_2 = jObject["error"].ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool D780FF06(JSON_Settings gclass8_0, int B025092C = -1)
	{
		string text = gclass8_0.GetValue("content").Replace("\r\n", "\n").Replace("\n", "\\\\n");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{B025092C}\", \"type\":\"number\"}}]";
		string json = RunScript("ShareWallMfb", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			Boolean_2 = jObject["error"].ToString() == "fb_blocked";
		}
		return result;
	}

	internal void method_90(int int_6 = 1, int C6B18C82 = 1)
	{
		Point point = GetSizeChrome();
		int int_7 = int_6 * Base.rd.Next(point.Y / 2, point.Y);
		for (int i = 0; i < C6B18C82; i++)
		{
			ScrollSmooth(int_7);
		}
	}

	public void method_91(ChromeOptions F615460E)
	{
		string text = "\r\n            function callbackFn(details)\r\n            {\r\n\t            return {\r\n\t\t            {Auth}\r\n\t            };\r\n            }\r\n            chrome.webRequest.onAuthRequired.addListener(\r\n\t            callbackFn,\r\n\t            { urls:[\"<all_urls>\"] },\r\n                ['blocking']\r\n            );";
		string newValue = "";
		string text2 = "";
		string newValue2 = "";
		if (Proxy == "")
		{
			text2 = "direct";
		}
		else
		{
			string text3 = "";
			string text4 = "";
			text2 = "fixed_servers";
			newValue = "\r\n                    rules: {\r\n                        singleProxy: {\r\n                            scheme: \"{TypeProxy}\",\r\n                            host: \"{HOST}\",\r\n                            port: parseInt({PORT})\r\n                        },\r\n                        bypassList: []\r\n\t                }\r\n                ";
			switch (Proxy.Split(':').Length)
			{
			case 1:
				text3 = "127.0.0.1";
				text4 = Proxy;
				break;
			case 2:
				text3 = Proxy.Split(':')[0];
				text4 = Proxy.Split(':')[1];
				break;
			case 4:
			{
				text3 = Proxy.Split(':')[0];
				text4 = Proxy.Split(':')[1];
				string newValue3 = Proxy.Split(':')[2];
				string newValue4 = Proxy.Split(':')[3];
				newValue2 = "\r\n                            authCredentials:\r\n\t\t                    {\r\n\t\t\t                    username: \"{USERNAME}\",\r\n\t\t\t                    password: \"{PASSWORD}\"\r\n\t\t                    }\r\n                        ";
				newValue2 = newValue2.Replace("{USERNAME}", newValue3).Replace("{PASSWORD}", newValue4);
				break;
			}
			}
			newValue = newValue.Replace("{HOST}", text3).Replace("{PORT}", text4.ToString()).Replace("{TypeProxy}", (TypeProxy == 0) ? "http" : "socks5");
			F615460E.AddArgument("--proxy-server= " + ((TypeProxy == 0) ? "" : "socks5://") + text3 + ":" + text4);
		}
		text = "\r\n            function callbackFn(details)\r\n            {\r\n\t            return {\r\n\t\t            {Auth}\r\n\t            };\r\n            }\r\n            chrome.webRequest.onAuthRequired.addListener(\r\n\t            callbackFn,\r\n\t            { urls:[\"<all_urls>\"] },\r\n                ['blocking']\r\n            );".Replace("{Mode}", text2).Replace("{Rules}", newValue).Replace("{Auth}", newValue2);
		if (!Directory.Exists("Plugins"))
		{
			Directory.CreateDirectory("Plugins");
		}
		string text5 = Guid.NewGuid().ToString();
		string text6 = "Plugins/manifest_" + text5 + ".json";
		string text7 = "Plugins/background_" + text5 + ".js";
		string text8 = "Plugins/proxy_auth_plugin_" + text5 + ".zip";
		File.WriteAllText(text6, "\r\n            {\r\n                \"version\": \"1.0.0\",\r\n                \"manifest_version\": 2,\r\n                \"name\": \"Chrome Proxy\",\r\n                \"permissions\": [\r\n                    \"proxy\",\r\n                    \"tabs\",\r\n                    \"unlimitedStorage\",\r\n                    \"storage\",\r\n                    \"<all_urls>\",\r\n                    \"webRequest\",\r\n                    \"webRequestBlocking\"\r\n                ],\r\n                \"background\": {\r\n                    \"scripts\": [\"background.js\"]\r\n\t            },\r\n                \"minimum_chrome_version\":\"22.0.0\"\r\n            }");
		File.WriteAllText(text7, text);
		using (ZipArchive destination = ZipFile.Open(text8, ZipArchiveMode.Create))
		{
			destination.CreateEntryFromFile(text6, "manifest.json");
			destination.CreateEntryFromFile(text7, "background.js");
		}
		File.Delete(text6);
		File.Delete(text7);
		F615460E.AddExtension(text8);
	}

	internal bool EC83A132()
	{
		GotoURL("https://www.facebook.com");
		if (CheckExistElement("i[style*=\"Puy01JAc-41.png\"]", 10.0) == 0)
		{
			return false;
		}
		DelayTime(1.0);
		Click("i[style*=\"Puy01JAc-41.png\"]");
		if (CheckExistElement("i[style*=\"nwrCcydySV3.png\"]", 10.0) == 1 && CheckExistElement("i[style*=\"xs4o8GcFCU6.png\"]") == 1)
		{
			RunScript("Switch282To956", "");
			return true;
		}
		return false;
	}

	internal List<string> method_92(string string_12, int D3842988)
	{
		List<string> list = new List<string>();
		if (!GetURL().StartsWith("https://mbasic.facebook.com/"))
		{
			GotoURL("https://mbasic.facebook.com/");
		}
		string text = "https://mbasic.facebook.com/" + string_12;
		do
		{
			string input = RequestGetHelper(text);
			MatchCollection matchCollection = Regex.Matches(input, "top_level_post_id&quot;:&quot;(.*?)&quot;");
			foreach (Match item2 in matchCollection)
			{
				string item = string_12 + "_" + item2.Groups[1].Value;
				if (!list.Contains(item))
				{
					list.Add(item);
					if (D3842988 <= list.Count)
					{
						goto end_IL_010f;
					}
				}
			}
			text = Regex.Match(input, "href=\"(/groups/\\d+\\?bacr.*?)\"").Groups[1].Value;
			if (text != "")
			{
				text = "https://mbasic.facebook.com" + text.Replace("&amp;", "&");
			}
			continue;
			end_IL_010f:
			break;
		}
		while (text != "" && D3842988 > list.Count);
		return list;
	}

	[CompilerGenerated]
	private void method_93()
	{
		try
		{
			chromeDriver.Quit();
		}
		catch (Exception)
		{
		}
	}

}
