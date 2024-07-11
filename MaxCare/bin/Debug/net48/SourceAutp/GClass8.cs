using System;

public static class GClass8
{
	private static uint[] uint_0;

	public unsafe static uint smethod_0(IntPtr intptr_0, uint uint_1)
	{
		intptr_0.ToPointer();
		for (int i = 0; i < uint_1; i++)
		{
		}
		return uint.MaxValue;
	}

	static GClass8()
	{
		uint_0 = new uint[256];
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> -286431280) : ((num >> 1) ^ 0xEDB88320u));
			}
			uint_0[i] = num;
		}
	}
}
