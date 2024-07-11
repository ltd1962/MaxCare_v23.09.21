using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Class64
{
	[CompilerGenerated]
	private sealed class F98F708D
	{
		public Control control_0;

		public bool D7A30C8B;

		internal void method_0()
		{
			control_0.Enabled = D7A30C8B;
		}
	}

	public static void smethod_0(Control control_0, bool bool_0, bool EA33DE2B)
	{
		try
		{
			if (EA33DE2B)
			{
				control_0.Invoke((MethodInvoker)delegate
				{
					control_0.Enabled = bool_0;
				});
			}
			else
			{
				control_0.Enabled = bool_0;
			}
		}
		catch (Exception)
		{
		}
	}
}
