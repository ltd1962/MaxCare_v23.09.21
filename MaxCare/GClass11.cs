using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class GClass11
{
	private static Dictionary<Control, bool> F23B7F10 = new Dictionary<Control, bool>();

	private static Size D1B02811;

	public static void AF142CA5(this Control control_0, bool bool_0)
	{
		if (bool_0)
		{
			if (!F23B7F10.ContainsKey(control_0))
			{
				F23B7F10.Add(control_0, value: false);
				control_0.MouseDown += smethod_0;
				control_0.MouseMove += smethod_1;
			}
		}
		else if (F23B7F10.ContainsKey(control_0))
		{
			control_0.MouseDown -= smethod_0;
			control_0.MouseMove -= smethod_1;
			F23B7F10.Remove(control_0);
		}
	}

	private static void smethod_0(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			D1B02811 = new Size(e.Location);
			F23B7F10[(Control)sender] = true;
			(sender as Control).BringToFront();
		}
	}

	private static void smethod_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && F23B7F10[(Control)sender])
		{
			Point point = e.Location - D1B02811;
			((Control)sender).Left += point.X;
			((Control)sender).Top += point.Y;
		}
	}
}
