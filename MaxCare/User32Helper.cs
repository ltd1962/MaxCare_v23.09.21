using System;
using System.Runtime.InteropServices;

public class User32Helper
{
	public const int int_0 = 3;

	public const int int_1 = 6;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern long SetParent(IntPtr EA82918D, IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr intptr_0, int int_2, int A62B9D17, int int_3, int int_4, bool B0AC9610);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr F710DD3E, int int_2);
}
