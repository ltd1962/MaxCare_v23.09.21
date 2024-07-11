using System.Runtime.InteropServices;

internal class InternetConnection
{
	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int int_0, int B3A4C00C);

	public static bool smethod_0()
	{
		int int_;
		return InternetGetConnectedState(out int_, 0);
	}
}
