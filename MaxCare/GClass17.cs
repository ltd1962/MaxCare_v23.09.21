using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

public class GClass17
{
	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetInfo(byte[] byte_0);

	public static string smethod_0(string string_0)
	{
		string result = "fail";
		try
		{
			string json = Common.smethod_6(GetInfo(Common.B2B3DBBA(string_0)));
			result = "Số dư: " + JObject.Parse(json)["coin_statistics"]["current_coin"].ToString();
		}
		catch
		{
		}
		return result;
	}
}
