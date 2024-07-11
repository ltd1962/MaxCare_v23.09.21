using System;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct0
{
	private readonly int int_0;

	private readonly uint[] uint_0;

	private static readonly Struct0 struct0_0 = new Struct0(-1, new uint[1] { 2147483648u });

	private static readonly Struct0 struct0_1 = new Struct0(1);

	private static readonly Struct0 struct0_2 = new Struct0(0);

	private static readonly Struct0 struct0_3 = new Struct0(-1);

	internal int Int32_0 => int_0;

	private int Int32_1 => (int_0 >> 31) - (-int_0 >> 31);

	internal uint[] UInt32_0 => uint_0;

	private bool Boolean_0
	{
		get
		{
			if (uint_0 != null)
			{
				return (uint_0[0] & 1) == 0;
			}
			return (int_0 & 1) == 0;
		}
	}

	private static Struct0 Struct0_0 => struct0_1;

	internal static Struct0 smethod_0(Struct0 struct0_4, Struct0 struct0_5, Struct0 struct0_6)
	{
		if (struct0_5.Int32_1 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool boolean_ = struct0_5.Boolean_0;
		Struct21 struct21_ = new Struct21(Struct0_0, ref int_);
		Struct21 struct21_2 = new Struct21(struct0_4, ref int_2);
		Struct21 struct21_3 = new Struct21(struct0_6, ref int_3);
		Struct21 struct21_4 = new Struct21(struct21_2.Int32_1);
		struct21_.method_0(ref struct21_3);
		if (struct0_5.uint_0 == null)
		{
			smethod_11((uint)struct0_5.int_0, ref struct21_, ref struct21_2, ref struct21_3, ref struct21_4);
		}
		else
		{
			int num = smethod_4(struct0_5.uint_0);
			for (int i = 0; i < num - 1; i++)
			{
				smethod_3(struct0_5.uint_0[i], ref struct21_, ref struct21_2, ref struct21_3, ref struct21_4);
			}
			smethod_11(struct0_5.uint_0[num - 1], ref struct21_, ref struct21_2, ref struct21_3, ref struct21_4);
		}
		return struct21_.method_6((struct0_4.int_0 > 0) ? 1 : (boolean_ ? 1 : (-1)));
	}

	[SpecialName]
	public static bool smethod_1(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_0(struct0_5) >= 0;
	}

	[SpecialName]
	public static bool smethod_2(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.Equals(struct0_5);
	}

	private static void smethod_3(uint uint_1, ref Struct21 struct21_0, ref Struct21 struct21_1, ref Struct21 struct21_2, ref Struct21 struct21_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_1 & 1) == 1)
			{
				smethod_12(ref struct21_0, ref struct21_1, ref struct21_2, ref struct21_3);
			}
			smethod_8(ref struct21_1, ref struct21_2, ref struct21_3);
			uint_1 >>= 1;
		}
	}

	internal Struct0(int int_1, uint[] uint_1)
	{
		int_0 = int_1;
		uint_0 = uint_1;
	}

	public override int GetHashCode()
	{
		if (uint_0 == null)
		{
			return int_0;
		}
		int result = int_0;
		int num = smethod_4(uint_0);
		while (--num >= 0)
		{
			result = Class51.smethod_4(result, (int)uint_0[num]);
		}
		return result;
	}

	private static int smethod_4(uint[] uint_1)
	{
		int num = uint_1.Length;
		if (uint_1[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	internal Struct0(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = byte_0.Length;
		bool flag = num > 0 && (byte_0[num - 1] & 0x80) == 128;
		while (num > 0 && byte_0[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			int_0 = 0;
			uint_0 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				int_0 = -1;
			}
			else
			{
				int_0 = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				int_0 <<= 8;
				int_0 |= byte_0[num2];
			}
			uint_0 = null;
			if (int_0 < 0 && !flag)
			{
				uint_0 = new uint[1];
				uint_0[0] = (uint)int_0;
				int_0 = 1;
			}
			if (int_0 == int.MinValue)
			{
				this = struct0_0;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (byte_0[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= byte_0[num5];
			}
		}
		if (flag2)
		{
			this = struct0_2;
		}
		else if (flag)
		{
			Class51.smethod_8(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = struct0_3;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = struct0_0;
					return;
				}
				int_0 = -1 * (int)array[0];
				uint_0 = null;
			}
			else if (num6 != array.Length)
			{
				int_0 = -1;
				uint_0 = new uint[num6];
				Array.Copy(array, uint_0, num6);
			}
			else
			{
				int_0 = -1;
				uint_0 = array;
			}
		}
		else
		{
			int_0 = 1;
			uint_0 = array;
		}
	}

	[SpecialName]
	public static bool smethod_5(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_0(struct0_5) < 0;
	}

	private int method_0(Struct0 struct0_4)
	{
		if ((int_0 ^ struct0_4.int_0) < 0)
		{
			if (int_0 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (uint_0 == null)
		{
			if (struct0_4.uint_0 == null)
			{
				if (int_0 >= struct0_4.int_0)
				{
					if (int_0 <= struct0_4.int_0)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -struct0_4.int_0;
		}
		int num;
		int num2;
		if (struct0_4.uint_0 != null && (num = smethod_4(uint_0)) <= (num2 = smethod_4(struct0_4.uint_0)))
		{
			if (num < num2)
			{
				return -int_0;
			}
			int num3 = smethod_6(uint_0, struct0_4.uint_0, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (uint_0[num3 - 1] >= struct0_4.uint_0[num3 - 1])
			{
				return int_0;
			}
			return -int_0;
		}
		return int_0;
	}

	private static int smethod_6(uint[] uint_1, uint[] uint_2, int int_1)
	{
		int num = int_1;
		do
		{
			if (--num < 0)
			{
				return 0;
			}
		}
		while (uint_1[num] == uint_2[num]);
		return num + 1;
	}

	[SpecialName]
	public static bool smethod_7(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_0(struct0_5) <= 0;
	}

	private static void smethod_8(ref Struct21 struct21_0, ref Struct21 struct21_1, ref Struct21 struct21_2)
	{
		Class51.smethod_6(ref struct21_0, ref struct21_2);
		struct21_0.method_9(ref struct21_2, ref struct21_2);
		struct21_0.method_0(ref struct21_1);
	}

	[SpecialName]
	public static bool smethod_9(Struct0 struct0_4, Struct0 struct0_5)
	{
		return struct0_4.method_0(struct0_5) > 0;
	}

	[SpecialName]
	public static bool smethod_10(Struct0 struct0_4, Struct0 struct0_5)
	{
		return !struct0_4.Equals(struct0_5);
	}

	private Struct0(int int_1)
	{
		if (int_1 == int.MinValue)
		{
			this = struct0_0;
			return;
		}
		int_0 = int_1;
		uint_0 = null;
	}

	private static void smethod_11(uint uint_1, ref Struct21 struct21_0, ref Struct21 struct21_1, ref Struct21 struct21_2, ref Struct21 struct21_3)
	{
		while (uint_1 != 0)
		{
			if ((uint_1 & 1) == 1)
			{
				smethod_12(ref struct21_0, ref struct21_1, ref struct21_2, ref struct21_3);
			}
			if (uint_1 != 1)
			{
				smethod_8(ref struct21_1, ref struct21_2, ref struct21_3);
				uint_1 >>= 1;
				continue;
			}
			break;
		}
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Struct0))
		{
			return false;
		}
		return Equals((Struct0)obj);
	}

	private static void smethod_12(ref Struct21 struct21_0, ref Struct21 struct21_1, ref Struct21 struct21_2, ref Struct21 struct21_3)
	{
		Class51.smethod_6(ref struct21_0, ref struct21_3);
		struct21_0.method_9(ref struct21_3, ref struct21_1);
		struct21_0.method_0(ref struct21_2);
	}

	internal byte[] method_1()
	{
		if (uint_0 == null && int_0 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (uint_0 == null)
		{
			array = new uint[1] { (uint)int_0 };
			b = (byte)((int_0 < 0) ? 255u : 0u);
		}
		else if (int_0 == -1)
		{
			array = (uint[])uint_0.Clone();
			Class51.smethod_8(array);
			b = byte.MaxValue;
		}
		else
		{
			array = uint_0;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFFu);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	private void method_2()
	{
		if (uint_0 != null)
		{
			smethod_4(uint_0);
		}
	}
}
