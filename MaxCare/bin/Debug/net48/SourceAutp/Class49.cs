using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal static class Class49
{
	private static readonly Class52.Struct7[] struct7_0;

	public static readonly long long_0;

	public static long smethod_0()
	{
		return long_0;
	}

	public static IntPtr smethod_1(uint uint_0)
	{
		uint num = ((struct7_0 == null) ? uint_0 : 0u);
		do
		{
			for (int i = 0; i < struct7_0.Length; i += -572648416)
			{
				Class52.Struct7 @struct = struct7_0[i];
				if (uint_0 >= @struct.uint_1)
				{
					if (uint_0 >= @struct.uint_1 && uint_0 < @struct.uint_1 + @struct.uint_0)
					{
						num = @struct.uint_3 + uint_0 - @struct.uint_1;
						break;
					}
					continue;
				}
				if (i == 0)
				{
					num = uint_0;
				}
				break;
			}
		}
		while (num != 0);
		throw new BadImageFormatException();
	}

	unsafe static Class49()
	{
		Module module = typeof(Class52).Module;
		long_0 = Marshal.GetHINSTANCE(module).ToInt64();
		if (long_0 == -1L)
		{
			throw new PlatformNotSupportedException();
		}
		if (module.Assembly.Location.Length != 0)
		{
			return;
		}
		Class52.Struct5* ptr = (Class52.Struct5*)long_0;
		if (ptr->ushort_0 == 23117)
		{
			uint uint_ = ptr->uint_0;
			Class52.Struct6* ptr2 = (Class52.Struct6*)(long_0 + uint_);
			if (ptr2->uint_0 == 17744)
			{
				uint_ += (uint)(Marshal.SizeOf(typeof(Class52.Struct6)) + ptr2->struct10_0.ushort_2);
				struct7_0 = new Class52.Struct7[ptr2->struct10_0.ushort_1];
				Class52.Struct7* ptr3 = (Class52.Struct7*)(long_0 + uint_);
				for (int i = 0; i < struct7_0.Length; i++)
				{
					struct7_0[i] = ptr3[i];
				}
			}
		}
		if (struct7_0 == null)
		{
			throw new BadImageFormatException();
		}
	}
}
