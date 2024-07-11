using System;
using System.Runtime.InteropServices;

internal class User32
{
	public struct RECT
	{
		public int A43AE48F;

		public int int_0;

		public int int_1;

		public int int_2;
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern IntPtr ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowRect(IntPtr intptr_0, ref RECT AB2FC237);
}
