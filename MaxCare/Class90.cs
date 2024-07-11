using System;

internal static class Class90
{
	internal static uint smethod_0(ulong AA8FEB10)
	{
		return (uint)AA8FEB10;
	}

	private static uint[] smethod_1(uint[] DBADF2A5, int DCA3D699)
	{
		if (DBADF2A5.Length == DCA3D699)
		{
			return DBADF2A5;
		}
		uint[] array = new uint[DCA3D699];
		int num = Math.Min(DBADF2A5.Length, DCA3D699);
		for (int i = 0; i < num; i++)
		{
			array[i] = DBADF2A5[i];
		}
		return array;
	}

	internal static uint smethod_2(ulong C5249BA7)
	{
		return (uint)(C5249BA7 >> 32);
	}

	private static uint E51B2F9D(uint FA968E19, uint uint_0)
	{
		return ((FA968E19 << 7) | (FA968E19 >> 25)) ^ uint_0;
	}

	internal static int CB28E8BD(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return 32;
		}
		int num = 0;
		if ((uint_0 & 0xFFFF0000u) == 0)
		{
			num += 16;
			uint_0 <<= 16;
		}
		if ((uint_0 & 0xFF000000u) == 0)
		{
			num += 8;
			uint_0 <<= 8;
		}
		if ((uint_0 & 0xF0000000u) == 0)
		{
			num += 4;
			uint_0 <<= 4;
		}
		if ((uint_0 & 0xC0000000u) == 0)
		{
			num += 2;
			uint_0 <<= 2;
		}
		if ((uint_0 & 0x80000000u) == 0)
		{
			num++;
		}
		return num;
	}

	internal static int smethod_3(int int_0, int int_1)
	{
		return (int)E51B2F9D((uint)int_0, (uint)int_1);
	}

	internal static ulong E5BAE221(uint uint_0, uint uint_1)
	{
		return ((ulong)uint_0 << 32) | uint_1;
	}

	internal static void smethod_4<T>(ref T DBA1BC89, ref T CBB05EA6)
	{
		T val = DBA1BC89;
		DBA1BC89 = CBB05EA6;
		CBB05EA6 = val;
	}

	internal static void smethod_5(uint[] FD91DC20)
	{
		for (int i = 0; i < FD91DC20.Length; i++)
		{
			FD91DC20[i] = 0u;
		}
		FD91DC20 = smethod_1(FD91DC20, FD91DC20.Length + 1);
		FD91DC20[FD91DC20.Length - 1] = 1u;
	}
}
