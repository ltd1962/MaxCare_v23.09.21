using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium.Interactions;

public class AutoChrome
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Process C431CF11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal IntPtr intptr_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Chrome f336F52E_0;

	public Process DD9D7628
	{
		[CompilerGenerated]
		get
		{
			return C431CF11;
		}
		[CompilerGenerated]
		set
		{
			C431CF11 = value;
		}
	}

	public IntPtr IntPtr_0
	{
		[CompilerGenerated]
		get
		{
			return intptr_0;
		}
		[CompilerGenerated]
		set
		{
			intptr_0 = value;
		}
	}

	public Chrome B4A7A528
	{
		[CompilerGenerated]
		get
		{
			return f336F52E_0;
		}
		[CompilerGenerated]
		set
		{
			f336F52E_0 = value;
		}
	}

	public AutoChrome(Chrome f336F52E_1)
	{
		DD9D7628 = f336F52E_1.Process_0;
		IntPtr_0 = DD9D7628.MainWindowHandle;
		B4A7A528 = f336F52E_1;
	}

	public Image D297B380(IntPtr E6960330)
	{
		IntPtr windowDC = User32.GetWindowDC(E6960330);
		User32.RECT AB2FC = default(User32.RECT);
		User32.GetWindowRect(E6960330, ref AB2FC);
		int num = AB2FC.int_1 - AB2FC.A43AE48F;
		int num2 = AB2FC.int_2 - AB2FC.int_0;
		IntPtr c4178FAC = GDI32.CreateCompatibleDC(windowDC);
		IntPtr intPtr = GDI32.CreateCompatibleBitmap(windowDC, num, num2);
		IntPtr f3BA9A0E = GDI32.SelectObject(c4178FAC, intPtr);
		GDI32.BitBlt(c4178FAC, 0, 0, num, num2, windowDC, 0, 0, 13369376);
		GDI32.SelectObject(c4178FAC, f3BA9A0E);
		GDI32.DeleteDC(c4178FAC);
		User32.ReleaseDC(E6960330, windowDC);
		Image result = Image.FromHbitmap(intPtr);
		GDI32.DeleteObject(intPtr);
		return result;
	}

	public bool D938CB3D(string C8B36A89, string E9868AA3)
	{
		bool result = false;
		try
		{
			(D297B380(IntPtr_0) as Bitmap).Save(C8B36A89 + (C8B36A89.EndsWith("\\") ? "" : "\\") + E9868AA3 + ".png", ImageFormat.Png);
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.ScreenCapture(" + C8B36A89 + "," + E9868AA3 + ")");
		}
		return result;
	}

	public Bitmap F432DF85(int int_0 = 1)
	{
		Bitmap result = null;
		try
		{
			for (int i = 0; i < int_0; i++)
			{
				try
				{
					result = (Bitmap)D297B380(IntPtr_0);
				}
				catch (Exception exception_)
				{
					smethod_0(this, exception_, "CaptureWindow");
					Common.Sleep(1.0);
					continue;
				}
				break;
			}
		}
		catch (Exception exception_2)
		{
			smethod_0(null, exception_2, "AutoChrome.ScreenCapture()");
		}
		return result;
	}

	public void F81A19A9(double double_0)
	{
		try
		{
			Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, $"chrome.DelayTime({double_0})");
		}
	}

	public bool method_0(string string_0)
	{
		bool result = false;
		try
		{
			AutoControl.smethod_16(IntPtr_0, string_0);
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendKeys(" + string_0 + ")");
		}
		return result;
	}

	public bool method_1(string string_0, double double_0)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				AutoControl.smethod_16(IntPtr_0, string_0[i].ToString());
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendKeys(" + string_0 + ")");
		}
		return result;
	}

	public bool method_2(string C7B4E932)
	{
		bool result = false;
		try
		{
			new Actions(B4A7A528.chromeDriver).SendKeys(C7B4E932).Perform();
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendKeys(" + C7B4E932 + ")");
		}
		return result;
	}

	public bool method_3(string string_0, double D72622B3)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				new Actions(B4A7A528.chromeDriver).SendKeys(string_0[i].ToString()).Perform();
				Thread.Sleep(Convert.ToInt32(D72622B3 * 1000.0));
			}
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, $"AutoChrome.SendKeys({string_0},{D72622B3})");
		}
		return result;
	}

	public bool B41A3785()
	{
		bool result = false;
		try
		{
			AutoControl.smethod_11(IntPtr_0, VKeys.const_8);
			result = true;
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.SendEnter()");
		}
		return result;
	}

	public void FD035D96()
	{
		try
		{
			DD9D7628.Kill();
		}
		catch (Exception exception_)
		{
			smethod_0(null, exception_, "AutoChrome.Close()");
		}
	}

	public void method_4(int B919C9AD)
	{
		try
		{
			B4A7A528.ExecuteScript("window.scrollBy({ top: " + B919C9AD + ",behavior: 'smooth'});");
		}
		catch
		{
		}
	}

	public bool method_5(int int_0, int int_1)
	{
		bool result = false;
		try
		{
			AutoControl.SendClickOnPosition(IntPtr_0, int_0, int_1);
			result = true;
		}
		catch
		{
		}
		return result;
	}

	public bool method_6(Point? nullable_0)
	{
		bool result = false;
		try
		{
			if (nullable_0.HasValue)
			{
				AutoControl.SendClickOnPosition(IntPtr_0, nullable_0.Value.X, nullable_0.Value.Y);
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public void CFAD1233(int B03573A8 = 10, double D7A22D31 = 100.0)
	{
		try
		{
			for (int i = 0; i < B03573A8; i++)
			{
				AutoControl.smethod_11(IntPtr_0, VKeys.ED1CDF23);
				F81A19A9(D7A22D31);
			}
		}
		catch
		{
		}
	}

	public void method_7(int int_0 = 10, double FA12EB9A = 100.0)
	{
		try
		{
			for (int i = 0; i < int_0; i++)
			{
				AutoControl.smethod_11(IntPtr_0, VKeys.EE2CB527);
				F81A19A9(FA12EB9A);
			}
		}
		catch
		{
		}
	}

	public static void smethod_0(AutoChrome b729443B_0, Exception exception_0, string AF8890AF = "")
	{
		try
		{
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			b729443B_0?.D938CB3D("log\\images\\", text);
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (AF8890AF != "")
			{
				streamWriter.WriteLine("Error: " + AF8890AF);
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
