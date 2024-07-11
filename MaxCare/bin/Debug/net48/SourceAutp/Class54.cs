using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class54
{
	public struct Struct13
	{
		public readonly uint uint_0;

		public readonly IntPtr intptr_0;

		public readonly IntPtr intptr_1;

		public readonly uint uint_1;

		public readonly IntPtr intptr_2;

		public readonly IntPtr intptr_3;

		 
	}

	public struct Struct14
	{
		public uint uint_0;

		public uint uint_1;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate3(IntPtr intptr_0);

	public struct Struct15
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public enum Enum3
	{
		const_0 = 17
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate4(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum4 enum4_0, out Enum4 enum4_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate5(out IntPtr intptr_0, uint uint_0, ref Struct13 struct13_0, ref Struct14 struct14_0, Enum4 enum4_0, uint uint_1, IntPtr intptr_1);

	public struct Struct16
	{
		public byte byte_0;

		public byte byte_1;
	}

	public enum Enum4 : uint
	{
		const_0 = 16u,
		const_1 = 64u,
		const_2 = 4u,
		const_3 = 2u,
		const_4 = 1u,
		const_5 = 8u,
		const_6 = 32u,
		const_7 = 256u
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate6(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Enum6 enum6_0);

	public struct Struct17
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public byte byte_0;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate7(IntPtr intptr_0, IntPtr intptr_1, out IntPtr intptr_2, UIntPtr uintptr_0, UIntPtr uintptr_1, Struct14 struct14_0, ref UIntPtr uintptr_2, uint uint_0, uint uint_1, Enum4 enum4_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate8(IntPtr intptr_0, Enum3 enum3_0, IntPtr intptr_1, uint uint_0);

	public enum Enum5 : uint
	{
		const_0 = 8192u,
		const_1 = 4096u
	}

	public struct Struct18
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public IntPtr intptr_5;
	}

	public enum Enum6 : uint
	{
		const_0 = 0x8000u
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate9(IntPtr intptr_0, Enum10 enum10_0, IntPtr intptr_1, uint uint_0, out uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate10(Enum9 enum9_0, IntPtr intptr_0, uint uint_0, out uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate11(IntPtr intptr_0, ref IntPtr intptr_1, IntPtr intptr_2, ref UIntPtr uintptr_0, Enum5 enum5_0, Enum4 enum4_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate12(uint uint_0, uint uint_1, uint uint_2, IntPtr[] intptr_0, uint uint_3, out Enum7 enum7_0);

	public struct Struct19
	{
		public readonly ushort ushort_0;

		public readonly ushort ushort_1;

		private readonly IntPtr intptr_0;

		 
	}

	public enum Enum7
	{
		const_0 = 1,
		const_1 = 0,
		const_2 = 8,
		const_3 = 4,
		const_4 = 3,
		const_5 = 6,
		const_6 = 5,
		const_7 = 2,
		const_8 = 7
	}

	public enum Enum8 : uint
	{
		const_0 = 4u,
		const_1 = 1u,
		const_2 = 8u,
		const_3 = 2u
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate13(IntPtr intptr_0, IntPtr intptr_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate14(out IntPtr intptr_0, uint uint_0, ref Struct13 struct13_0, out Struct20 struct20_0, uint uint_1, uint uint_2);

	public struct Struct20
	{
		public uint uint_0;

		public IntPtr intptr_0;
	}

	public enum Enum9
	{
		const_0 = 35,
		const_1 = 0,
		const_2 = 76
	}

	public enum Enum10
	{
		const_0 = 7,
		const_1 = 30,
		const_2 = 0
	}

	private static Delegate13 delegate13_0;

	private static Delegate5 delegate5_0;

	private static Delegate14 delegate14_0;

	private static Delegate7 delegate7_0;

	private static Delegate3 delegate3_0;

	public static readonly IntPtr intptr_0;

	private static Delegate6 delegate6_0;

	private static IntPtr intptr_1;

	public static readonly IntPtr intptr_2;

	private static Delegate12 delegate12_0;

	private static Delegate9 delegate9_0;

	private static Delegate11 delegate11_0;

	private static Delegate4 delegate4_0;

	private static Delegate8 delegate8_0;

	private static Delegate10 delegate10_0;

	public static readonly IntPtr intptr_3;

	public static IntPtr smethod_0(string string_0, uint uint_0, uint uint_1)
	{
		return (IntPtr)new GClass7().method_5(new object[3] { string_0, uint_0, uint_1 }, 722919);
	}

	internal static IntPtr smethod_1(uint uint_0)
	{
		return (IntPtr)new GClass7().method_5(new object[1] { uint_0 }, 727233);
	}

	public static IntPtr smethod_2(IntPtr intptr_4, IntPtr intptr_5, Enum4 enum4_0, uint uint_0, uint uint_1, string string_0)
	{
		return (IntPtr)new GClass7().method_5(new object[6] { intptr_4, intptr_5, enum4_0, uint_0, uint_1, string_0 }, 735661);
	}

 
	public static IntPtr smethod_4(IntPtr intptr_4, UIntPtr uintptr_0, Enum5 enum5_0, Enum4 enum4_0)
	{
		return (IntPtr)new GClass7().method_5(new object[4] { intptr_4, uintptr_0, enum5_0, enum4_0 }, 1048028);
	}

	public static bool smethod_5(IntPtr intptr_4)
	{
		return (bool)new GClass7().method_5(new object[1] { intptr_4 }, 1029300);
	}

	public static uint smethod_6(IntPtr intptr_4, Enum3 enum3_0, IntPtr intptr_5, uint uint_0)
	{
		return (uint)new GClass7().method_5(new object[4] { intptr_4, enum3_0, intptr_5, uint_0 }, 1042062);
	}

	 

	public static byte[] smethod_9(uint uint_0)
	{
		return (byte[])new GClass7().method_5(new object[1] { uint_0 }, 1048619);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string string_0);

	public static IntPtr smethod_10(IntPtr intptr_4, Enum8 enum8_0, uint uint_0, uint uint_1, ref UIntPtr uintptr_0)
	{
		object[] array = new object[5] { intptr_4, enum8_0, uint_0, uint_1, uintptr_0 };
		try
		{
			return (IntPtr)new GClass7().method_5(array, 735372);
		}
		finally
		{
			uintptr_0 = (UIntPtr)array[4];
		}
	}

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	public static bool smethod_11()
	{
		return (bool)new GClass7().method_5(null, 1052557);
	}

	internal static IntPtr smethod_12(IntPtr intptr_4, object object_0)
	{
		return (IntPtr)new GClass7().method_5(new object[2] { intptr_4, object_0 }, 1040913);
	}

	public static bool smethod_13()
	{
		return (bool)new GClass7().method_5(null, 1047013);
	}

	public static bool smethod_14(IntPtr intptr_4, UIntPtr uintptr_0, Enum6 enum6_0)
	{
		return (bool)new GClass7().method_5(new object[3] { intptr_4, uintptr_0, enum6_0 }, 1053022);
	}

	public static void smethod_15(string string_0, string string_1, GEnum2 genum2_0, GEnum1 genum1_0)
	{
		new GClass7().method_5(new object[4] { string_0, string_1, genum2_0, genum1_0 }, 1039372);
	}

	public static byte[] smethod_16(uint uint_0, uint uint_1)
	{
		return (byte[])new GClass7().method_5(new object[2] { uint_0, uint_1 }, 1039902);
	}

	public static bool smethod_17(IntPtr intptr_4)
	{
		return (bool)new GClass7().method_5(new object[1] { intptr_4 }, 1049678);
	}

	public static bool smethod_18()
	{
		return (bool)new GClass7().method_5(null, 721506);
	}

	static Class54()
	{
		new GClass7().method_5(null, 1043732);
	}
}
