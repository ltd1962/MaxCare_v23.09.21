using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class FireFox
{
	private FirefoxDriver firefoxDriver_0;

	public bool A71C5329 = false;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool EE9FA694;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string A6A6BBA4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Point point_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int F9009599;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Point point_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int DF1128B2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string A7AF37A4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int B28B8D12;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string E5293702;

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return EE9FA694;
		}
		[CompilerGenerated]
		set
		{
			EE9FA694 = value;
		}
	}

	public bool Boolean_1
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

	public bool Boolean_2
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
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

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return A6A6BBA4;
		}
		[CompilerGenerated]
		set
		{
			A6A6BBA4 = value;
		}
	}

	public string String_1
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

	public Point Point_0
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

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return F9009599;
		}
		[CompilerGenerated]
		set
		{
			F9009599 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public Point Point_1
	{
		[CompilerGenerated]
		get
		{
			return point_1;
		}
		[CompilerGenerated]
		set
		{
			point_1 = value;
		}
	}

	public int A98BF9BA
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

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return DF1128B2;
		}
		[CompilerGenerated]
		set
		{
			DF1128B2 = value;
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

	public int Int32_4
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public string D900C1B7
	{
		[CompilerGenerated]
		get
		{
			return A7AF37A4;
		}
		[CompilerGenerated]
		set
		{
			A7AF37A4 = value;
		}
	}

	public int Int32_5
	{
		[CompilerGenerated]
		get
		{
			return B28B8D12;
		}
		[CompilerGenerated]
		set
		{
			B28B8D12 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string String_4
	{
		[CompilerGenerated]
		get
		{
			return E5293702;
		}
		[CompilerGenerated]
		set
		{
			E5293702 = value;
		}
	}

	public FireFox()
	{
		Boolean_1 = true;
		Boolean_2 = false;
		String_0 = "";
		String_1 = "";
		Int32_0 = 300;
		Int32_1 = 300;
		Point_0 = new Point(Int32_1, Int32_0);
		A98BF9BA = 300;
		Int32_2 = 0;
		D900C1B7 = "";
		Int32_5 = 0;
		Point_1 = new Point(A98BF9BA, Int32_2);
		Int32_3 = 0;
		Int32_4 = 5;
		String_2 = "";
		Boolean_3 = false;
		String_3 = "";
		String_4 = "data\\extension";
	}

	public bool method_0()
	{
		bool result = false;
		A71C5329 = true;
		try
		{
			FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
			firefoxDriverService.HideCommandPromptWindow = true;
			FirefoxOptions firefoxOptions = new FirefoxOptions();
			firefoxOptions.SetPreference("security.notification_enable_delay", 0);
			firefoxOptions.SetPreference("dom.webnotifications.enabled", preferenceValue: false);
			firefoxOptions.SetPreference("permissions.default.image", Boolean_1 ? 1 : 0);
			firefoxOptions.SetPreference("browser.download.folderList", 2);
			firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", preferenceValue: false);
			firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");
			firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.focusWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.useDownloadDir", preferenceValue: true);
			firefoxOptions.SetPreference("browser.helperApps.alwaysAsk.force", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.closeWhenDone", preferenceValue: true);
			firefoxOptions.SetPreference("browser.download.manager.showAlertOnComplete", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.useWindow", preferenceValue: false);
			firefoxOptions.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("pdfjs.disabled", preferenceValue: true);
			firefoxOptions.AddArguments("-width=" + Point_0.X, "-height=" + Point_0.Y);
			if (String_0 != "")
			{
				firefoxOptions.SetPreference("general.useragent.override", String_0);
			}
			else
			{
				firefoxOptions.SetPreference("general.useragent.override", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0");
			}
			new FirefoxProfileManager();
			firefoxDriver_0 = new FirefoxDriver(firefoxDriverService, firefoxOptions);
			firefoxDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(Int32_4);
			firefoxDriver_0.Manage().Window.Position = Point_1;
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, "firefox.Open()");
		}
		return result;
	}

	public static string smethod_0(FirefoxOptions firefoxOptions_0, int int_4)
	{
		int num = 0;
		int num2 = 0;
		int width = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		int num3 = width / 3;
		int num4 = height / 2;
		if (int_4 < 3)
		{
			num = num3 * int_4;
			num2 = 0;
		}
		else
		{
			num = num3 * (int_4 % 3);
			int num5 = int_4 / 2;
			num2 = ((num5 % 2 != 0) ? num4 : 0);
		}
		firefoxOptions_0.AddArgument($"--width={num3}");
		firefoxOptions_0.AddArgument($"--height={num4}");
		return num + "|" + num2;
	}

	public string D71759AF(string string_3, string string_4, string string_5)
	{
		string result = "";
		if (A71C5329)
		{
			try
			{
				result = firefoxDriver_0.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + string_3 + "','" + string_4 + "','" + string_5 + "')").ToString();
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetCssSelector(" + string_3 + "," + string_4 + "," + string_5 + ")");
			}
		}
		return result;
	}

	public string method_1(string D7976FBF, string DCB4C083)
	{
		string result = "";
		if (A71C5329)
		{
			try
			{
				result = firefoxDriver_0.ExecuteScript("return document.querySelector('" + D7976FBF + "').getAttribute('" + DCB4C083 + "')").ToString();
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetAttributeValue(" + D7976FBF + "," + DCB4C083 + ")");
			}
		}
		return result;
	}

	public void C91D94BA(int int_4)
	{
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.ExecuteScript("window.scrollBy({ top: " + int_4 + ",behavior: 'smooth'});");
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"chrome.ScrollSmooth({int_4})");
			}
		}
	}

	public string CB9D0EBB()
	{
		string result = "";
		try
		{
			result = firefoxDriver_0.ExecuteScript("return navigator.userAgent").ToString();
		}
		catch
		{
		}
		return result;
	}

	public bool C5154434(int int_4, string string_3)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				switch (int_4)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendKeyDown({int_4},{string_3})");
			}
		}
		return result;
	}

	public string D68B981B()
	{
		if (A71C5329)
		{
			try
			{
				return firefoxDriver_0.Url;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetURL()");
			}
		}
		return "";
	}

	public bool method_2(string EE88DFBF)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.Navigate().GoToUrl(EE88DFBF);
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GotoURL(" + EE88DFBF + ")");
			}
		}
		return result;
	}

	public bool method_3()
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.Navigate().Refresh();
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.Refresh()");
			}
		}
		return result;
	}

	public bool method_4()
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.Navigate().Back();
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GotoBackPage()");
			}
		}
		return result;
	}

	public bool method_5(int int_4, string D3056B34, double double_0)
	{
		if (A71C5329)
		{
			try
			{
				switch (int_4)
				{
				case 1:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.Id(D3056B34))).Perform();
					break;
				case 2:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.Name(D3056B34))).Perform();
					break;
				case 3:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.XPath(D3056B34))).Perform();
					break;
				case 4:
					new Actions(firefoxDriver_0).MoveToElement(firefoxDriver_0.FindElement(By.CssSelector(D3056B34))).Perform();
					break;
				}
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				return true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.HoverElement({int_4}, {D3056B34}, {double_0})");
			}
		}
		return false;
	}

	public bool F511161D(int CD067612, string string_3, int int_4 = 0, int int_5 = 0, string string_4 = "", int int_6 = 0)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				if (int_5 == 0)
				{
					switch (CD067612)
					{
					case 1:
						firefoxDriver_0.FindElementsById(string_3)[int_4].Click();
						break;
					case 2:
						firefoxDriver_0.FindElementsByName(string_3)[int_4].Click();
						break;
					case 3:
						firefoxDriver_0.FindElementsByXPath(string_3)[int_4].Click();
						break;
					case 4:
						firefoxDriver_0.FindElementsByCssSelector(string_3)[int_4].Click();
						break;
					}
				}
				else
				{
					switch (CD067612)
					{
					case 1:
						firefoxDriver_0.FindElementsById(string_3)[int_4].FindElements(By.Id(string_4))[int_6].Click();
						break;
					case 2:
						firefoxDriver_0.FindElementsByName(string_3)[int_4].FindElements(By.Name(string_4))[int_6].Click();
						break;
					case 3:
						firefoxDriver_0.FindElementsByXPath(string_3)[int_4].FindElements(By.XPath(string_4))[int_6].Click();
						break;
					case 4:
						firefoxDriver_0.FindElementsByCssSelector(string_3)[int_4].FindElements(By.CssSelector(string_4))[int_6].Click();
						break;
					}
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.Click({CD067612},{string_3})");
			}
		}
		return result;
	}

	public bool method_6(int int_4, string F4085C05, int B2ACC7BD = 0, int int_5 = 0, string string_3 = "", int A19CBC1E = 0)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				if (int_5 != 0)
				{
					switch (int_4)
					{
					case 1:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsById(F4085C05)[B2ACC7BD].FindElements(By.Id(string_3))[A19CBC1E]).Perform();
						break;
					case 2:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByName(F4085C05)[B2ACC7BD].FindElements(By.Name(string_3))[A19CBC1E]).Perform();
						break;
					case 3:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByXPath(F4085C05)[B2ACC7BD].FindElements(By.XPath(string_3))[A19CBC1E]).Perform();
						break;
					case 4:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByCssSelector(F4085C05)[B2ACC7BD].FindElements(By.CssSelector(string_3))[A19CBC1E]).Perform();
						break;
					}
				}
				else
				{
					switch (int_4)
					{
					case 1:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsById(F4085C05)[B2ACC7BD]).Perform();
						break;
					case 2:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByName(F4085C05)[B2ACC7BD]).Perform();
						break;
					case 3:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByXPath(F4085C05)[B2ACC7BD]).Perform();
						break;
					case 4:
						new Actions(firefoxDriver_0).Click(firefoxDriver_0.FindElementsByCssSelector(F4085C05)[B2ACC7BD]).Perform();
						break;
					}
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.ClickWithAction({int_4},{F4085C05})");
			}
		}
		return result;
	}

	public bool method_7(int FB9A9720, string string_3, string C4A0D7AC, bool CD0EFD1C = true)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				if (CD0EFD1C)
				{
					F511161D(FB9A9720, string_3);
				}
				switch (FB9A9720)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_3).SendKeys(C4A0D7AC);
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_3).SendKeys(C4A0D7AC);
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_3).SendKeys(C4A0D7AC);
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_3).SendKeys(C4A0D7AC);
					break;
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendKeys({FB9A9720},{string_3},{C4A0D7AC},{CD0EFD1C})");
			}
		}
		return result;
	}

	public bool method_8(int int_4, string B4168D97, string string_3, double EBB2B90C, bool A1897707 = true)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				if (A1897707)
				{
					F511161D(int_4, B4168D97);
				}
				for (int i = 0; i < string_3.Length; i++)
				{
					switch (int_4)
					{
					case 1:
						firefoxDriver_0.FindElementById(B4168D97).SendKeys(string_3[i].ToString());
						break;
					case 2:
						firefoxDriver_0.FindElementByName(B4168D97).SendKeys(string_3[i].ToString());
						break;
					case 3:
						firefoxDriver_0.FindElementByXPath(B4168D97).SendKeys(string_3[i].ToString());
						break;
					case 4:
						firefoxDriver_0.FindElementByCssSelector(B4168D97).SendKeys(string_3[i].ToString());
						break;
					}
					Thread.Sleep(Convert.ToInt32(EBB2B90C * 1000.0));
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendKeys({int_4},{B4168D97},{string_3},{EBB2B90C},{A1897707})");
			}
		}
		return result;
	}

	public bool method_9(int D9121522, string string_3)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				switch (D9121522)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_3).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_3).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_3).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_3).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SelectText({D9121522},{string_3})");
			}
		}
		return result;
	}

	public bool CB3C2294(int FD8959B9, string string_3)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				switch (FD8959B9)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_3).Clear();
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_3).Clear();
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_3).Clear();
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_3).Clear();
					break;
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.ClearText({FD8959B9},{string_3})");
			}
		}
		return result;
	}

	public bool method_10(string E937B927, double double_0 = 0.0)
	{
		bool result = true;
		if (A71C5329)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + E937B927 + "').length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					result = false;
					break;
				}
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_1(null, exception_, $"firefox.CheckExistElement({E937B927},{double_0})");
			}
		}
		return result;
	}

	public bool method_11(string CBA75BBD, double double_0 = 0.0)
	{
		bool result = true;
		if (A71C5329)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)firefoxDriver_0.ExecuteScript("return " + CBA75BBD + ".length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					result = false;
					break;
				}
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_1(null, exception_, $"firefox.CheckExistElement({CBA75BBD},{double_0})");
			}
		}
		return result;
	}

	public bool method_12()
	{
		bool result = true;
		if (A71C5329)
		{
			try
			{
				_ = firefoxDriver_0.Title;
				result = false;
			}
			catch (Exception exception_)
			{
				A71C5329 = false;
				smethod_1(null, exception_, "firefox.CheckChromeClosed()");
			}
		}
		return result;
	}

	public bool method_13(string A9B3F83C, int E7A9E938 = 0, double double_0 = 0.0)
	{
		bool result = true;
		if (A71C5329)
		{
			try
			{
				int tickCount = Environment.TickCount;
				if (E7A9E938 == 0)
				{
					while ((string)firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + A9B3F83C + "').length+''") == "0")
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						result = false;
						break;
					}
				}
				else
				{
					while ((string)firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + A9B3F83C + "').length+''") != "0")
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						result = false;
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				result = false;
				smethod_1(null, exception_, $"firefox.WaitForSearchElement({A9B3F83C},{E7A9E938},{double_0})");
			}
		}
		return result;
	}

	public int A12FEA27(double double_0 = 0.0, params string[] string_3)
	{
		int result = 0;
		if (A71C5329)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					for (int i = 0; i < string_3.Length; i++)
					{
						if (method_10(string_3[i]))
						{
							return i + 1;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, string.Format("firefox.CheckExistElements({0},{1})", double_0, string.Join("|", string_3)));
			}
		}
		return result;
	}

	public bool FF2F9CAA(int A3314085, string string_3)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				switch (A3314085)
				{
				case 1:
					firefoxDriver_0.FindElementById(string_3).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 2:
					firefoxDriver_0.FindElementByName(string_3).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 3:
					firefoxDriver_0.FindElementByXPath(string_3).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 4:
					firefoxDriver_0.FindElementByCssSelector(string_3).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.SendEnter({A3314085},{string_3})");
			}
		}
		return result;
	}

	public bool method_14(int int_4, int int_5)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				string script = $"window.scrollTo({int_4}, {int_5})";
				firefoxDriver_0.ExecuteScript(script);
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.Scroll({int_4},{int_5})");
			}
		}
		return result;
	}

	public void method_15(string string_3)
	{
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.ExecuteScript(string_3 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.ScrollSmooth(" + string_3 + ")");
			}
		}
	}

	public int B0B7E206(string string_3)
	{
		int result = -2;
		if (A71C5329)
		{
			try
			{
				result = Convert.ToInt32(firefoxDriver_0.ExecuteScript("var check='';x=" + string_3 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.CheckExistElementOnScreen(" + string_3 + ")");
			}
		}
		return result;
	}

	public Point C092C510()
	{
		Point result = new Point(0, 0);
		if (A71C5329)
		{
			try
			{
				string text = firefoxDriver_0.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
				result.X = Convert.ToInt32(text.Split('|')[1]);
				result.Y = Convert.ToInt32(text.Split('|')[0]);
			}
			catch
			{
			}
		}
		return result;
	}

	public void method_16()
	{
		try
		{
			if (firefoxDriver_0 != null)
			{
				firefoxDriver_0.Quit();
			}
			A71C5329 = false;
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, "firefox.Close()");
		}
	}

	public void method_17(string DFA07523, string CA31EF9C = ".facebook.com")
	{
		if (!A71C5329)
		{
			return;
		}
		try
		{
			string[] array = DFA07523.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Trim() != "")
				{
					string[] array3 = text.Split('=');
					if (array3.Count() > 1 && array3[0].Trim() != "")
					{
						Cookie cookie = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), CA31EF9C, "/", DateTime.Now.AddDays(10.0));
						firefoxDriver_0.Manage().Cookies.AddCookie(cookie);
					}
				}
			}
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, "firefox.AddCookieIntoChrome(" + DFA07523 + "," + CA31EF9C + ")");
		}
	}

	public string D039D604(string C9A33288 = "facebook")
	{
		string text = "";
		if (A71C5329)
		{
			try
			{
				Cookie[] array = firefoxDriver_0.Manage().Cookies.AllCookies.ToArray();
				Cookie[] array2 = array;
				foreach (Cookie cookie in array2)
				{
					if (cookie.Domain.Contains(C9A33288))
					{
						text = text + cookie.Name + "=" + cookie.Value + ";";
					}
				}
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.GetCookieFromChrome(" + C9A33288 + ")");
			}
		}
		return text;
	}

	public void method_18(string C0246DA7, bool bool_3 = true)
	{
		if (!A71C5329)
		{
			return;
		}
		try
		{
			firefoxDriver_0.ExecuteScript("window.open('" + C0246DA7 + "', '_blank').focus();");
			if (bool_3)
			{
				firefoxDriver_0.SwitchTo().Window(firefoxDriver_0.WindowHandles.Last());
			}
		}
		catch (Exception exception_)
		{
			smethod_1(null, exception_, $"firefox.OpenNewTab({C0246DA7},{bool_3})");
		}
	}

	public void method_19()
	{
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.Close();
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.CloseCurrentTab()");
			}
		}
	}

	public void method_20()
	{
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.SwitchTo().Window(firefoxDriver_0.WindowHandles.First());
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.SwitchToFirstTab()");
			}
		}
	}

	public void method_21()
	{
		if (A71C5329)
		{
			try
			{
				firefoxDriver_0.SwitchTo().Window(firefoxDriver_0.WindowHandles.Last());
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.SwitchToLastTab()");
			}
		}
	}

	public void DF995E97(double double_0)
	{
		if (A71C5329)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.DelayTime({double_0})");
			}
		}
	}

	public bool method_22(int C03F730C, string string_3, string string_4)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				switch (C03F730C)
				{
				case 1:
					new SelectElement(firefoxDriver_0.FindElementById(string_3)).SelectByValue(string_4);
					break;
				case 2:
					new SelectElement(firefoxDriver_0.FindElementByName(string_3)).SelectByValue(string_4);
					break;
				case 3:
					new SelectElement(firefoxDriver_0.FindElementByXPath(string_3)).SelectByValue(string_4);
					break;
				case 4:
					new SelectElement(firefoxDriver_0.FindElementByCssSelector(string_3)).SelectByValue(string_4);
					break;
				}
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, $"firefox.Select({C03F730C},{string_3},{string_4})");
			}
		}
		return result;
	}

	public bool method_23(string string_3, string A192562E)
	{
		bool result = false;
		if (A71C5329)
		{
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)firefoxDriver_0).GetScreenshot();
				screenshot.SaveAsFile(string_3 + (string_3.EndsWith("\\") ? "" : "\\") + A192562E + ".png");
				result = true;
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "chrome.ScreenCapture(" + string_3 + "," + A192562E + ")");
			}
		}
		return result;
	}

	public object method_24(string string_3)
	{
		if (A71C5329)
		{
			try
			{
				return firefoxDriver_0.ExecuteScript(string_3);
			}
			catch (Exception exception_)
			{
				smethod_1(null, exception_, "firefox.ExecuteScript(" + string_3 + ")");
			}
		}
		return "";
	}

	public static void smethod_1(Chrome A9116C1C, Exception exception_0, string string_3 = "")
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
			if (A9116C1C != null)
			{
				string contents = A9116C1C.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;").ToString();
				A9116C1C.ScreenCapture("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (string_3 != "")
			{
				streamWriter.WriteLine("Error: " + string_3);
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
}
