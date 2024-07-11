using System;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct12
{
	private readonly int int_0;

	private readonly uint[] uint_0;

	private static readonly Struct12 struct12_0 = new Struct12(-1, new uint[1] { 2147483648u });

	private static readonly Struct12 struct12_1 = new Struct12(1);

	private static readonly Struct12 F5278B0F = new Struct12(0);

	private static readonly Struct12 FFB21315 = new Struct12(-1);

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

	private int Int32_0 => (int_0 >> 31) - (-int_0 >> 31);

	internal uint[] UInt32_0 => uint_0;

	internal int Int32_1 => int_0;

	private static Struct12 Struct12_0 => struct12_1;

	[SpecialName]
	public static bool smethod_0(Struct12 struct12_2, Struct12 A01E1098)
	{
		return struct12_2.Equals(A01E1098);
	}

	[SpecialName]
	public static bool smethod_1(Struct12 struct12_2, Struct12 struct12_3)
	{
		return struct12_2.method_1(struct12_3) > 0;
	}

	internal byte[] method_0()
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
			Class90.smethod_5(array);
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

	private static int smethod_2(uint[] uint_1, uint[] uint_2, int EDAF6211)
	{
		int num = EDAF6211;
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

	private static void smethod_3(uint uint_1, ref Struct11 struct11_0, ref Struct11 FEAE1DA8, ref Struct11 struct11_1, ref Struct11 C6822503)
	{
		while (uint_1 != 0)
		{
			if ((uint_1 & 1) == 1)
			{
				smethod_8(ref struct11_0, ref FEAE1DA8, ref struct11_1, ref C6822503);
			}
			if (uint_1 != 1)
			{
				CB9FB62F(ref FEAE1DA8, ref struct11_1, ref C6822503);
				uint_1 >>= 1;
				continue;
			}
			break;
		}
	}

	[SpecialName]
	public static bool E4A6E3AD(Struct12 F00A6035, Struct12 F62FA43D)
	{
		return F00A6035.method_1(F62FA43D) >= 0;
	}

	[SpecialName]
	public static bool C2B80809(Struct12 struct12_2, Struct12 struct12_3)
	{
		return struct12_2.method_1(struct12_3) < 0;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Struct12))
		{
			return false;
		}
		return Equals((Struct12)obj);
	}

	[SpecialName]
	public static bool smethod_4(Struct12 DC0C233D, Struct12 struct12_2)
	{
		return !DC0C233D.Equals(struct12_2);
	}

	internal static Struct12 smethod_5(Struct12 struct12_2, Struct12 E73FC120, Struct12 E999F397)
	{
		if (E73FC120.Int32_0 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool boolean_ = E73FC120.Boolean_0;
		Struct11 struct11_ = new Struct11(struct12_1, ref int_);
		Struct11 FEAE1DA = new Struct11(struct12_2, ref int_2);
		Struct11 struct11_2 = new Struct11(E999F397, ref int_3);
		Struct11 C = new Struct11(FEAE1DA.FAACA12E);
		struct11_.BBBE2FBD(ref struct11_2);
		if (E73FC120.uint_0 == null)
		{
			smethod_3((uint)E73FC120.int_0, ref struct11_, ref FEAE1DA, ref struct11_2, ref C);
		}
		else
		{
			int num = A823EC35(E73FC120.uint_0);
			for (int i = 0; i < num - 1; i++)
			{
				smethod_6(E73FC120.uint_0[i], ref struct11_, ref FEAE1DA, ref struct11_2, ref C);
			}
			smethod_3(E73FC120.uint_0[num - 1], ref struct11_, ref FEAE1DA, ref struct11_2, ref C);
		}
		return struct11_.method_7((struct12_2.int_0 > 0) ? 1 : (boolean_ ? 1 : (-1)));
	}

	internal Struct12(int int_1, uint[] uint_1)
	{
		int_0 = int_1;
		uint_0 = uint_1;
	}
	 
	private static void smethod_6(uint C0354CAD, ref Struct11 FA2D3629, ref Struct11 struct11_0, ref Struct11 B72A0793, ref Struct11 struct11_1)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((C0354CAD & 1) == 1)
			{
				smethod_8(ref FA2D3629, ref struct11_0, ref B72A0793, ref struct11_1);
			}
			CB9FB62F(ref struct11_0, ref B72A0793, ref struct11_1);
			C0354CAD >>= 1;
		}
	}

	internal Struct12(byte[] CB301637)
	{
		if (CB301637 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = CB301637.Length;
		bool flag = num > 0 && (CB301637[num - 1] & 0x80) == 128;
		while (num > 0 && CB301637[num - 1] == 0)
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
				int_0 |= CB301637[num2];
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
				this = struct12_0;
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
				if (CB301637[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= CB301637[num5];
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
				if (CB301637[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= CB301637[num5];
			}
		}
		if (flag2)
		{
			this = F5278B0F;
		}
		else if (flag)
		{
			Class90.smethod_5(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = FFB21315;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = struct12_0;
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

	private Struct12(int int_1)
	{
		if (int_1 == int.MinValue)
		{
			this = struct12_0;
			return;
		}
		int_0 = int_1;
		uint_0 = null;
	}

	private int method_1(Struct12 B990638F)
	{
		if ((int_0 ^ B990638F.int_0) < 0)
		{
			if (int_0 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (uint_0 == null)
		{
			if (B990638F.uint_0 == null)
			{
				if (int_0 >= B990638F.int_0)
				{
					if (int_0 <= B990638F.int_0)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -B990638F.int_0;
		}
		int num;
		int num2;
		if (B990638F.uint_0 != null && (num = A823EC35(uint_0)) <= (num2 = A823EC35(B990638F.uint_0)))
		{
			if (num < num2)
			{
				return -int_0;
			}
			int num3 = smethod_2(uint_0, B990638F.uint_0, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (uint_0[num3 - 1] >= B990638F.uint_0[num3 - 1])
			{
				return int_0;
			}
			return -int_0;
		}
		return int_0;
	}

	[SpecialName]
	public static bool smethod_7(Struct12 struct12_2, Struct12 struct12_3)
	{
		return struct12_2.method_1(struct12_3) <= 0;
	}

	private static int A823EC35(uint[] uint_1)
	{
		int num = uint_1.Length;
		if (uint_1[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	private static void smethod_8(ref Struct11 struct11_0, ref Struct11 struct11_1, ref Struct11 struct11_2, ref Struct11 struct11_3)
	{
		Class90.smethod_4(ref struct11_0, ref struct11_3);
		struct11_0.method_6(ref struct11_3, ref struct11_1);
		struct11_0.BBBE2FBD(ref struct11_2);
	}

	private static void CB9FB62F(ref Struct11 B92782B9, ref Struct11 struct11_0, ref Struct11 A423F40D)
	{
		Class90.smethod_4(ref B92782B9, ref A423F40D);
		B92782B9.method_6(ref A423F40D, ref A423F40D);
		B92782B9.BBBE2FBD(ref struct11_0);
	}

	private void C7A3F78C()
	{
		if (uint_0 != null)
		{
			A823EC35(uint_0);
		}
	}
}
