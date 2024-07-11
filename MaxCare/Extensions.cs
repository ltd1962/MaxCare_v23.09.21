using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public static class Extensions
{
	[CompilerGenerated]
	private sealed class FD8CF8B9
	{
		public Control control_0;

		public bool bool_0;

		internal void method_0()
		{
			control_0.Enabled = bool_0;
		}
	}

	public static Bitmap F1845086(this string string_0)
	{
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
			memoryStream.Write(array, 0, array.Length);
			Image original = Image.FromStream(memoryStream, useEmbeddedColorManagement: true);
			return new Bitmap(original);
		}
		catch
		{
		}
		return null;
	}

	public static void F42CCD8F(this Control control_0, bool CA37A49D)
	{
		try
		{
			control_0.Invoke((MethodInvoker)delegate
			{
				control_0.Enabled = CA37A49D;
			});
		}
		catch
		{
		}
	}

	public static string ToUrlEncode(this string string_0)
	{
		return WebUtility.UrlEncode(string_0);
	}

	public static string ToHtmlDecode(this string string_0)
	{
		return WebUtility.HtmlDecode(string_0);
	}

	public static void F128E894(this Form form_0)
	{
		if (form_0.WindowState == FormWindowState.Maximized)
		{
			form_0.WindowState = FormWindowState.Normal;
			return;
		}
		Rectangle workingArea = Screen.FromHandle(form_0.Handle).WorkingArea;
		workingArea.Location = new Point(0, 0);
		form_0.MaximumSize = workingArea.Size;
		form_0.WindowState = FormWindowState.Maximized;
	}

	public static void B992B8A4(this Control control_0, string FC84D690 = "Search...")
	{
		control_0.Tag = FC84D690;
		if (control_0.Text == "" || control_0.Text == FC84D690)
		{
			control_0.Text = FC84D690;
			control_0.ForeColor = Color.Gray;
		}
		control_0.Leave += smethod_2;
		control_0.Enter += smethod_1;
	}

	private static void smethod_1(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Text == control.Tag.ToString())
		{
			control.Text = "";
			control.ForeColor = Color.Black;
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Text == "")
		{
			control.Text = control.Tag.ToString();
			control.ForeColor = Color.Gray;
		}
	}
}
