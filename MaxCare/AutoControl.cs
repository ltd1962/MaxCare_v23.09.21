using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class AutoControl
{
	public delegate bool CallBack(IntPtr intptr_0, IntPtr intptr_1);

	private delegate bool EnumWindowProc(IntPtr intptr_0, IntPtr intptr_1);

	[Flags]
	public enum MouseEventFlags : uint
	{
		BE2C6284 = 2u,
		flag_1 = 4u,
		flag_2 = 0x20u,
		E612FE34 = 0x40u,
		flag_4 = 1u,
		flag_5 = 0x8000u,
		B8848988 = 8u,
		flag_7 = 0x10u,
		flag_8 = 0x800u,
		flag_9 = 0x80u,
		B2898C8D = 0x100u,
		C3BF4F25 = 1u,
		flag_12 = 2u
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class E8024305
	{
		public static readonly E8024305 _003C_003E9 = new E8024305();

		public static Func<Process, bool> _003C_003E9__27_0;

		public static Func<Process, bool> _003C_003E9__28_0;

		public static EnumWindowProc _003C_003E9__32_0;

		internal bool method_0(Process F401853E)
		{
			return F401853E.MainWindowHandle != IntPtr.Zero;
		}

		internal bool D5833320(Process DEB9D5BD)
		{
			return DEB9D5BD.MainWindowHandle != IntPtr.Zero;
		}

		internal bool method_1(IntPtr intptr_0, IntPtr D40A36B9)
		{
			GCHandle gCHandle = GCHandle.FromIntPtr(D40A36B9);
			if (gCHandle.Target == null)
			{
				return false;
			}
			List<IntPtr> list = gCHandle.Target as List<IntPtr>;
			list.Add(intptr_0);
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class Class4
	{
		public string AB022EA5;

		public string string_0;

		internal bool method_0(IntPtr intptr_0)
		{
			string text = D49893BB(intptr_0);
			string text2 = F6B7279D(intptr_0);
			return text == AB022EA5 || text2 == string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class5
	{
		public string FDAE4F9B;

		public string string_0;

		internal bool C6281110(IntPtr intptr_0)
		{
			string text = D49893BB(intptr_0);
			string text2 = F6B7279D(intptr_0);
			return text == FDAE4F9B || text2 == string_0;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("User32.dll")]
	public static extern bool EnumChildWindows(IntPtr intptr_0, CallBack gdelegate0_0, IntPtr intptr_1);

	[DllImport("User32.dll")]
	public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int B832100C);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int FC160432);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindow_1(IntPtr F412B0B7, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint EB202BBB, IntPtr intptr_1, IntPtr D60D9B8C);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_1(IntPtr intptr_0, int BAB4BE3B, int C9042F90, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_2(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr EEAE7417);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_3(IntPtr D7046F3E, int int_0, IntPtr intptr_0, string B625E32D);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	public static extern int SendMessage_4(IntPtr intptr_0, int A62CBA81, int int_0, string string_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDlgItem(IntPtr F8ADB91B, int E423D60A);

	[DllImport("user32.dll")]
	private static extern bool SetDlgItemTextA(IntPtr intptr_0, int B63332B0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr C33ED98B, string string_0, string string_1);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr intptr_0, int AB0FDE31, IntPtr C6B78C35, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "PostMessage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage_1(IntPtr intptr_0, int E5A207A0, IntPtr intptr_1, string A71A4289);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr A33C8AA8);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr intptr_0, ref RECT D18AA083);

	[DllImport("user32", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumChildWindows_1(IntPtr intptr_0, EnumWindowProc cf1B2BBD_0, IntPtr intptr_1);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(uint uint_0, int B792A0B0, int int_0, int int_1, UIntPtr A4936EA0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr intptr_0, int C7BC4B1C, int E3B8ED2D, int EC0C248D, int F1170F03, bool E9294006);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint EAB0C387, INPUT[] C28CAAA6, int B92A8B27);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr A680EF19);

	public static IntPtr C88AD718(string string_0, string E195AD9C = null)
	{
		IntPtr intPtr = FindWindow(string_0, E195AD9C);
		SetForegroundWindow(intPtr);
		return intPtr;
	}

	public static IntPtr F72F0AA9(IntPtr intptr_0)
	{
		SetForegroundWindow(intptr_0);
		return intptr_0;
	}

	public static bool smethod_0(IntPtr intptr_0)
	{
		return IsWindowVisible(intptr_0);
	}

	public static IntPtr smethod_1(string string_0, string D49011B1)
	{
		return FindWindow(string_0, D49011B1);
	}

	[DllImport("User32.dll")]
	public static extern bool ShowWindow(IntPtr C9B29018, int AE3D72B7);

	public static List<IntPtr> smethod_2(string string_0, string string_1, int int_0 = 1)
	{
		Process[] processes = Process.GetProcesses();
		List<IntPtr> list = new List<IntPtr>();
		int num = 0;
		foreach (Process item in processes.Where((Process F401853E) => F401853E.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = D49893BB(mainWindowHandle);
			string text2 = F6B7279D(mainWindowHandle);
			if (text == string_0 || text2 == string_1)
			{
				list.Add(mainWindowHandle);
				if (num >= int_0)
				{
					break;
				}
				num++;
			}
		}
		return list;
	}

	public static IntPtr FB11C430(string string_0, string EAAC8787)
	{
		Process[] processes = Process.GetProcesses();
		IntPtr result = IntPtr.Zero;
		foreach (Process item in processes.Where((Process DEB9D5BD) => DEB9D5BD.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = D49893BB(mainWindowHandle);
			string text2 = F6B7279D(mainWindowHandle);
			if (text == string_0 || text2 == EAAC8787)
			{
				result = mainWindowHandle;
				break;
			}
		}
		return result;
	}

	public static IntPtr smethod_3(IntPtr intptr_0, string string_0, string E18129B9)
	{
		return FindWindowEx(intptr_0, IntPtr.Zero, E18129B9, string_0);
	}

	private static IntPtr FA36DCAE(IntPtr intptr_0, int int_0)
	{
		if (int_0 == 0)
		{
			return intptr_0;
		}
		int num = 0;
		IntPtr intPtr = IntPtr.Zero;
		do
		{
			intPtr = FindWindowEx(intptr_0, intPtr, "Button", null);
			if (intPtr != IntPtr.Zero)
			{
				num++;
			}
		}
		while (num < int_0 && intPtr != IntPtr.Zero);
		return intPtr;
	}

	public static IntPtr D1AC3187(IntPtr intptr_0, int C69A0597)
	{
		return GetDlgItem(intptr_0, C69A0597);
	}

	public static List<IntPtr> EE0F370D(IntPtr intptr_0)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		IntPtr intptr_ = GCHandle.ToIntPtr(value);
		try
		{
			EnumWindowProc cf1B2BBD_ = delegate(IntPtr intptr_0, IntPtr D40A36B9)
			{
				GCHandle gCHandle = GCHandle.FromIntPtr(D40A36B9);
				if (gCHandle.Target == null)
				{
					return false;
				}
				List<IntPtr> list2 = gCHandle.Target as List<IntPtr>;
				list2.Add(intptr_0);
				return true;
			};
			EnumChildWindows_1(intptr_0, cf1B2BBD_, intptr_);
		}
		finally
		{
			value.Free();
		}
		return list;
	}

	[DllImport("user32.dll")]
	public static extern bool ShowWindowAsync(HandleRef DF1D7622, int int_0);

	public static IntPtr F42417B4(List<IntPtr> CA94E7AF, string string_0, string string_1)
	{
		return CA94E7AF.Find(delegate(IntPtr intptr_0)
		{
			string text = D49893BB(intptr_0);
			string text2 = F6B7279D(intptr_0);
			return text == string_0 || text2 == string_1;
		});
	}

	public static List<IntPtr> smethod_4(List<IntPtr> list_0, string string_0, string string_1)
	{
		new List<IntPtr>();
		IEnumerable<IntPtr> source = list_0.Where(delegate(IntPtr intptr_0)
		{
			string text = D49893BB(intptr_0);
			string text2 = F6B7279D(intptr_0);
			return text == string_0 || text2 == string_1;
		});
		return source.ToList();
	}

	public static IntPtr E8AA0231(IntPtr intptr_0, string DAB7C73D, string string_0)
	{
		return F42417B4(EE0F370D(intptr_0), DAB7C73D, string_0);
	}

	public static List<IntPtr> smethod_5(IntPtr intptr_0, string EE9EFDA6, string string_0)
	{
		return smethod_4(EE0F370D(intptr_0), EE9EFDA6, string_0);
	}

	public static bool smethod_6(IntPtr E5A1171A, IntPtr intptr_0)
	{
		string text = F6B7279D(E5A1171A);
		string text2 = D49893BB(E5A1171A);
		if (text == "&Options >>" && text2.StartsWith("ToolbarWindow32"))
		{
			SendMessage_2(E5A1171A, 0, IntPtr.Zero, IntPtr.Zero);
			return false;
		}
		return true;
	}

	public static void D7B1A1B0(IntPtr FAB4DF92, int int_0)
	{
		IntPtr dlgItem = GetDlgItem(FAB4DF92, int_0);
		int c9042F = 0 | (int_0 & 0xFFFF);
		SendMessage_1(FAB4DF92, 273, c9042F, dlgItem);
	}

	public static void BD0AA090(IntPtr FD0E5FB8)
	{
		SendMessage_2(FD0E5FB8, 513, IntPtr.Zero, IntPtr.Zero);
		SendMessage_2(FD0E5FB8, 514, IntPtr.Zero, IntPtr.Zero);
	}

	public static void SendClickOnPosition(IntPtr D2BF8210, int int_0, int int_1, EMouseKey genum0_0 = EMouseKey.LEFT, int E29F283D = 1)
	{
		int aB0FDE = 0;
		int aB0FDE2 = 0;
		if (genum0_0 == EMouseKey.LEFT)
		{
			aB0FDE = 513;
			aB0FDE2 = 514;
		}
		if (genum0_0 == EMouseKey.RIGHT)
		{
			aB0FDE = 516;
			aB0FDE2 = 517;
		}
		IntPtr intptr_ = smethod_32(int_0, int_1);
		if (genum0_0 == EMouseKey.LEFT || genum0_0 == EMouseKey.RIGHT)
		{
			for (int i = 0; i < E29F283D; i++)
			{
				PostMessage(D2BF8210, 6, new IntPtr(1), intptr_);
				PostMessage(D2BF8210, aB0FDE, new IntPtr(1), intptr_);
				PostMessage(D2BF8210, aB0FDE2, new IntPtr(0), intptr_);
			}
			return;
		}
		if (genum0_0 == EMouseKey.DOUBLE_LEFT)
		{
			aB0FDE = 515;
			aB0FDE2 = 514;
		}
		if (genum0_0 == EMouseKey.DOUBLE_RIGHT)
		{
			aB0FDE = 518;
			aB0FDE2 = 517;
		}
		PostMessage(D2BF8210, aB0FDE, new IntPtr(1), intptr_);
		PostMessage(D2BF8210, aB0FDE2, new IntPtr(0), intptr_);
	}

	public static void smethod_8(IntPtr intptr_0, int int_0, int int_1, int int_2, int DA2FE984, int int_3 = 10, int int_4 = 10, double double_0 = 0.05)
	{
		int aB0FDE = 513;
		int aB0FDE2 = 514;
		IntPtr intptr_ = smethod_32(int_0, int_1);
		IntPtr intptr_2 = smethod_32(int_2, DA2FE984);
		if (int_2 < int_0)
		{
			int_3 *= -1;
		}
		if (DA2FE984 < int_1)
		{
			int_4 *= -1;
		}
		PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
		PostMessage(intptr_0, aB0FDE, new IntPtr(1), intptr_);
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			PostMessage(intptr_0, 512, new IntPtr(1), smethod_32(int_0, int_1));
			if (int_3 <= 0)
			{
				if (int_0 > int_2)
				{
					int_0 += int_3;
				}
				else
				{
					flag = true;
				}
			}
			else if (int_0 < int_2)
			{
				int_0 += int_3;
			}
			else
			{
				flag = true;
			}
			if (int_4 > 0)
			{
				if (int_1 < DA2FE984)
				{
					int_1 += int_4;
				}
				else
				{
					flag2 = true;
				}
			}
			else if (int_1 > DA2FE984)
			{
				int_1 += int_4;
			}
			else
			{
				flag2 = true;
			}
			if (flag && flag2)
			{
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
		PostMessage(intptr_0, aB0FDE2, new IntPtr(0), intptr_2);
	}

	public static void E5016238(IntPtr AC252125, int C204F902, int int_0, EMouseKey genum0_0 = EMouseKey.LEFT, int int_1 = 1)
	{
		int aB0FDE = 0;
		if (genum0_0 == EMouseKey.LEFT)
		{
			aB0FDE = 513;
		}
		if (genum0_0 == EMouseKey.RIGHT)
		{
			aB0FDE = 516;
		}
		IntPtr intptr_ = smethod_32(C204F902, int_0);
		for (int i = 0; i < int_1; i++)
		{
			PostMessage(AC252125, 6, new IntPtr(1), intptr_);
			PostMessage(AC252125, aB0FDE, new IntPtr(1), intptr_);
		}
	}

	public static void smethod_9(IntPtr intptr_0, int int_0, int int_1, EMouseKey F2054238 = EMouseKey.LEFT, int int_2 = 1)
	{
		int int_3 = 0;
		if (F2054238 == EMouseKey.LEFT)
		{
			int_3 = 514;
		}
		if (F2054238 == EMouseKey.RIGHT)
		{
			int_3 = 517;
		}
		IntPtr intPtr = smethod_32(int_0, int_1);
		for (int i = 0; i < int_2; i++)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), intPtr);
			SendMessage_2(intptr_0, int_3, new IntPtr(0), intPtr);
		}
	}

	public static void smethod_10(IntPtr intptr_0, string string_0)
	{
		SendMessage_4(intptr_0, 12, 0, string_0);
	}

	public static void smethod_11(IntPtr intptr_0, VKeys e92C0AB8_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 256, new IntPtr((int)e92C0AB8_0), new IntPtr(1));
		PostMessage(intptr_0, 257, new IntPtr((int)e92C0AB8_0), new IntPtr(0));
	}

	public static void smethod_12(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
	{
		string text = string_0.ToLower();
		foreach (char c in text)
		{
			VKeys e92C0AB8_ = VKeys.const_31;
			switch (c)
			{
			case 'a':
				e92C0AB8_ = VKeys.const_41;
				break;
			case 'b':
				e92C0AB8_ = VKeys.const_42;
				break;
			case 'c':
				e92C0AB8_ = VKeys.const_62;
				break;
			case 'd':
				e92C0AB8_ = VKeys.const_44;
				break;
			case 'e':
				e92C0AB8_ = VKeys.const_45;
				break;
			case 'f':
				e92C0AB8_ = VKeys.const_46;
				break;
			case 'g':
				e92C0AB8_ = VKeys.const_47;
				break;
			case 'h':
				e92C0AB8_ = VKeys.const_48;
				break;
			case 'i':
				e92C0AB8_ = VKeys.const_49;
				break;
			case 'j':
				e92C0AB8_ = VKeys.const_50;
				break;
			case 'k':
				e92C0AB8_ = VKeys.const_51;
				break;
			case 'l':
				e92C0AB8_ = VKeys.const_52;
				break;
			case 'm':
				e92C0AB8_ = VKeys.D3963F3D;
				break;
			case 'n':
				e92C0AB8_ = VKeys.A33A10AA;
				break;
			case 'o':
				e92C0AB8_ = VKeys.A18E66B2;
				break;
			case 'p':
				e92C0AB8_ = VKeys.const_56;
				break;
			case 'q':
				e92C0AB8_ = VKeys.A53DC71F;
				break;
			case 'r':
				e92C0AB8_ = VKeys.const_58;
				break;
			case 's':
				e92C0AB8_ = VKeys.BA377A09;
				break;
			case 't':
				e92C0AB8_ = VKeys.const_60;
				break;
			case 'u':
				e92C0AB8_ = VKeys.const_61;
				break;
			case 'v':
				e92C0AB8_ = VKeys.const_62;
				break;
			case 'w':
				e92C0AB8_ = VKeys.F780EC2E;
				break;
			case 'x':
				e92C0AB8_ = VKeys.CE194322;
				break;
			case 'y':
				e92C0AB8_ = VKeys.BF1BBC03;
				break;
			case 'z':
				e92C0AB8_ = VKeys.const_66;
				break;
			case '0':
				e92C0AB8_ = VKeys.const_31;
				break;
			case '1':
				e92C0AB8_ = VKeys.const_32;
				break;
			case '2':
				e92C0AB8_ = VKeys.const_33;
				break;
			case '3':
				e92C0AB8_ = VKeys.const_34;
				break;
			case '4':
				e92C0AB8_ = VKeys.C524862F;
				break;
			case '5':
				e92C0AB8_ = VKeys.BCA7470D;
				break;
			case '6':
				e92C0AB8_ = VKeys.const_37;
				break;
			case '7':
				e92C0AB8_ = VKeys.E61A06A9;
				break;
			case '8':
				e92C0AB8_ = VKeys.const_39;
				break;
			case '9':
				e92C0AB8_ = VKeys.B082CE98;
				break;
			}
			smethod_11(intptr_0, e92C0AB8_);
			Thread.Sleep(TimeSpan.FromSeconds(float_0));
		}
	}

	public static void smethod_13(IntPtr intptr_0, VKeys B50DA98B)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 257, new IntPtr((int)B50DA98B), new IntPtr(0));
	}

	public static void AA23D212(IntPtr DE8F9719, VKeys B129583F)
	{
		PostMessage(DE8F9719, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(DE8F9719, 258, new IntPtr((int)B129583F), new IntPtr(0));
	}

	public static void smethod_14(IntPtr A41F2C26, int int_0)
	{
		PostMessage(A41F2C26, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(A41F2C26, 258, new IntPtr(int_0), new IntPtr(0));
	}

	public static void smethod_15(IntPtr ACA10316, VKeys FBACF69E)
	{
		PostMessage(ACA10316, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(ACA10316, 256, new IntPtr((int)FBACF69E), new IntPtr(0));
	}

	public static void smethod_16(IntPtr intptr_0, string FF1B19A6, float C6A16BAD = 0.1f)
	{
		string text = FF1B19A6.ToLower();
		foreach (char int_ in text)
		{
			smethod_14(intptr_0, int_);
		}
	}

	public static void smethod_17(KeyCode f88DF3A1_0)
	{
		smethod_20(f88DF3A1_0);
	}

	public static void smethod_18(KeyCode[] E6133E35)
	{
		foreach (KeyCode c21BA39C in E6133E35)
		{
			smethod_22(c21BA39C);
		}
		foreach (KeyCode fFA87DB in E6133E35)
		{
			smethod_23(fFA87DB);
		}
	}

	public static void smethod_19(string A8906908)
	{
		Clipboard.SetText(A8906908);
		smethod_18(new KeyCode[2]
		{
			KeyCode.const_107,
			KeyCode.const_94
		});
	}

	public static void smethod_20(KeyCode f88DF3A1_0)
	{
		INPUT f41DE13C = default(INPUT);
		f41DE13C.Type = 1u;
		INPUT f41DE13C2 = f41DE13C;
		f41DE13C2.Data.keyboard = new KEYBDINPUT
		{
			ushort_0 = (ushort)f88DF3A1_0,
			ushort_1 = 0,
			uint_0 = 0u,
			D6953A3F = 0u,
			FD339A09 = IntPtr.Zero
		};
		f41DE13C = default(INPUT);
		f41DE13C.Type = 1u;
		INPUT f41DE13C3 = f41DE13C;
		f41DE13C3.Data.keyboard = new KEYBDINPUT
		{
			ushort_0 = (ushort)f88DF3A1_0,
			ushort_1 = 0,
			uint_0 = 2u,
			D6953A3F = 0u,
			FD339A09 = IntPtr.Zero
		};
		INPUT[] c28CAAA = new INPUT[2] { f41DE13C2, f41DE13C3 };
		if (SendInput(2u, c28CAAA, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_21(string DF957FA2, double double_0 = 0.5)
	{
		for (int i = 0; i < DF957FA2.Length; i++)
		{
			switch (DF957FA2[i])
			{
			case '0':
				smethod_20(KeyCode.const_63);
				break;
			case '1':
				smethod_20(KeyCode.D898B894);
				break;
			case '2':
				smethod_20(KeyCode.const_65);
				break;
			case '3':
				smethod_20(KeyCode.F5B12807);
				break;
			case '4':
				smethod_20(KeyCode.const_67);
				break;
			case '5':
				smethod_20(KeyCode.const_68);
				break;
			case '6':
				smethod_20(KeyCode.const_69);
				break;
			case '7':
				smethod_20(KeyCode.A82ECEBA);
				break;
			case '8':
				smethod_20(KeyCode.C59A1988);
				break;
			case '9':
				smethod_20(KeyCode.const_72);
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
	}

	public static void smethod_22(KeyCode C21BA39C)
	{
		INPUT f41DE13C = default(INPUT);
		f41DE13C.Type = 1u;
		INPUT f41DE13C2 = f41DE13C;
		f41DE13C2.Data.keyboard = default(KEYBDINPUT);
		f41DE13C2.Data.keyboard.ushort_0 = (ushort)C21BA39C;
		f41DE13C2.Data.keyboard.ushort_1 = 0;
		f41DE13C2.Data.keyboard.uint_0 = 0u;
		f41DE13C2.Data.keyboard.D6953A3F = 0u;
		f41DE13C2.Data.keyboard.FD339A09 = IntPtr.Zero;
		INPUT[] c28CAAA = new INPUT[1] { f41DE13C2 };
		if (SendInput(1u, c28CAAA, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_23(KeyCode FFA87DB3)
	{
		INPUT f41DE13C = default(INPUT);
		f41DE13C.Type = 1u;
		INPUT f41DE13C2 = f41DE13C;
		f41DE13C2.Data.keyboard = default(KEYBDINPUT);
		f41DE13C2.Data.keyboard.ushort_0 = (ushort)FFA87DB3;
		f41DE13C2.Data.keyboard.ushort_1 = 0;
		f41DE13C2.Data.keyboard.uint_0 = 2u;
		f41DE13C2.Data.keyboard.D6953A3F = 0u;
		f41DE13C2.Data.keyboard.FD339A09 = IntPtr.Zero;
		INPUT[] c28CAAA = new INPUT[1] { f41DE13C2 };
		if (SendInput(1u, c28CAAA, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_24(int D9917534, int int_0, EMouseKey genum0_0 = EMouseKey.LEFT)
	{
		Cursor.Position = new Point(D9917534, int_0);
		smethod_28(genum0_0);
	}

	public static void smethod_25(Point DAAF6830, int int_0, bool bool_0 = false)
	{
		Cursor.Position = DAAF6830;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < int_0; i++)
		{
			if (!bool_0)
			{
				mouse_event(1u, 1, 0, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, -1, 0, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void F014273D(Point point_0, int F6A052B3, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < F6A052B3; i++)
		{
			if (!bool_0)
			{
				mouse_event(1u, 0, 1, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, 0, -1, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_26(Point point_0, int int_0, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2048u, 0, 0, int_0, UIntPtr.Zero);
	}

	public static void smethod_27(Point point_0, EMouseKey genum0_0 = EMouseKey.LEFT)
	{
		Cursor.Position = point_0;
		smethod_28(genum0_0);
	}

	public static void smethod_28(EMouseKey F59BF10D = EMouseKey.LEFT)
	{
		switch (F59BF10D)
		{
		case EMouseKey.LEFT:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case EMouseKey.RIGHT:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		case EMouseKey.DOUBLE_LEFT:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case EMouseKey.DOUBLE_RIGHT:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		}
	}

	public static RECT smethod_29(IntPtr B83B918F)
	{
		RECT D18AA = default(RECT);
		GetWindowRect(B83B918F, ref D18AA);
		return D18AA;
	}

	public static Point BB0A9A82(IntPtr intptr_0, Point? CE042408 = null)
	{
		Point result = default(Point);
		RECT gStruct = smethod_29(intptr_0);
		if (!CE042408.HasValue)
		{
			CE042408 = default(Point);
		}
		result.X = CE042408.Value.X + gStruct.int_0;
		result.Y = CE042408.Value.Y + gStruct.int_1;
		return result;
	}

	public static Point smethod_30(IntPtr intptr_0, int int_0 = 0, int F10E3424 = 0)
	{
		Point result = default(Point);
		RECT gStruct = smethod_29(intptr_0);
		result.X = int_0 + gStruct.int_0;
		result.Y = F10E3424 + gStruct.int_1;
		return result;
	}

	public static string F6B7279D(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(intptr_0, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static string D49893BB(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetClassName(intptr_0, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static IntPtr smethod_31(int F08C010B, int int_0)
	{
		return (IntPtr)((int_0 << 16) | (F08C010B & 0xFFFF));
	}

	public static IntPtr smethod_32(int int_0, int int_1)
	{
		return (IntPtr)((int_1 << 16) | int_0);
	}
}
