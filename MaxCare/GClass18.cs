using System;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json.Linq;

public class GClass18
{
	public int int_0 = 5;

	public int int_1 = 100;

	public int int_2 = 300;

	private int E316E79B = 0;

	private int D48C3909 = 300;

	private object F89FC0A1 = new object();

	private bool method_0()
	{
		return Environment.TickCount - E316E79B > D48C3909 * 1000;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetConfigs(byte[] byte_0);

	public GClass18 method_1()
	{
		if (method_0() && Monitor.TryEnter(F89FC0A1))
		{
			E316E79B = Environment.TickCount;
			lock (F89FC0A1)
			{
				string json = Common.smethod_6(GetConfigs(Common.B2B3DBBA("")));
				try
				{
					JObject jObject = JObject.Parse(json);
					int_0 = Convert.ToInt32(jObject["delay_action_jobs_min"]);
					int_1 = Convert.ToInt32(jObject["delay_action_jobs_max"]);
					int_2 = Convert.ToInt32(jObject["max_jobs_daily"]);
				}
				catch (Exception)
				{
				}
			}
		}
		return this;
	}
}
