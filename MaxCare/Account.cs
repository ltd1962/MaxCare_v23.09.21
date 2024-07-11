using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

public class Account
{
	[CompilerGenerated]
	private sealed class Class1
	{
		public Account dcbefe8F_0;

		public int B796EAB9;

		internal void method_0()
		{
			try
			{
				while (Environment.TickCount - dcbefe8F_0.Int32_0 < B796EAB9 * 1000 && dcbefe8F_0.EA242007.IsAlive)
				{
					Thread.Sleep(1000);
				}
				dcbefe8F_0.EA242007.Abort();
				while (dcbefe8F_0.EA242007.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Thread thread_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int DBBAFE0C;

	private Thread EA242007
	{
		[CompilerGenerated]
		get
		{
			return thread_0;
		}
		[CompilerGenerated]
		set
		{
			thread_0 = value;
		}
	}

	private int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return DBBAFE0C;
		}
		[CompilerGenerated]
		set
		{
			DBBAFE0C = value;
		}
	}

	public Account(Thread thread_1, int E499D18D = 0)
	{
		Account dcbefe8F_0 = this;
		EA242007 = thread_1;
		Int32_0 = Environment.TickCount;
		if (E499D18D <= 0)
		{
			return;
		}
		new Thread((ThreadStart)delegate
		{
			try
			{
				while (Environment.TickCount - dcbefe8F_0.Int32_0 < E499D18D * 1000 && dcbefe8F_0.EA242007.IsAlive)
				{
					Thread.Sleep(1000);
				}
				dcbefe8F_0.EA242007.Abort();
				while (dcbefe8F_0.EA242007.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	public string method_0()
	{
		return Common.ConvertSecondsToTime((Environment.TickCount - Int32_0) / 1000);
	}
}
