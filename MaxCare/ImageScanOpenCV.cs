using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

internal class ImageScanOpenCV
{
	public static Bitmap smethod_0(string string_0)
	{
		return new Bitmap(string_0);
	}

	public static Bitmap F1B7D0A0(string string_0, string string_1, double double_0 = 0.9)
	{
		smethod_0(string_0);
		smethod_0(string_1);
		return F1B7D0A0(string_0, string_1, double_0);
	}

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr intptr_0);

	public static List<Point> smethod_1(Bitmap bitmap_0, Color DE3B8C92)
	{
		int num = DE3B8C92.ToArgb();
		List<Point> list = new List<Point>();
		try
		{
			for (int i = 0; i < bitmap_0.Width; i++)
			{
				for (int j = 0; j < bitmap_0.Height; j++)
				{
					if (num.Equals(bitmap_0.GetPixel(i, j).ToArgb()))
					{
						list.Add(new Point(i, j));
					}
				}
			}
		}
		finally
		{
			((IDisposable)bitmap_0)?.Dispose();
		}
		return list;
	}
}
