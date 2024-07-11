using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct MOUSEKEYBDHARDWAREINPUT
{
	[FieldOffset(0)]
	public HARDWAREINPUT Hardware;

	[FieldOffset(0)]
	public KEYBDINPUT keyboard;

	[FieldOffset(0)]
	public MOUSEINPUT Mouse;
}
