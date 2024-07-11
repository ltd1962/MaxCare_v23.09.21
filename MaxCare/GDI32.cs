using System;
using System.Runtime.InteropServices;

internal class GDI32
{
	public const int int_0 = 13369376;

	[DllImport("gdi32.dll")]
	public static extern bool BitBlt(IntPtr intptr_0, int C2985232, int int_1, int int_2, int A995C828, IntPtr D98D0887, int F182B486, int A397AB39, int EC31E1BE);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleBitmap(IntPtr E7A5D818, int E9B256AF, int C594673E);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleDC(IntPtr DF89BB35);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteDC(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern IntPtr SelectObject(IntPtr C4178FAC, IntPtr F3BA9A0E);
}
