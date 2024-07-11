using System;

internal struct Struct11
{
	private int int_0;

	private uint E510E285;

	private uint[] DAB84111;

	private bool E5A47C19;

	private int Int32_0
	{
		get
		{
			int num = 0;
			for (int num2 = int_0; num2 >= 0; num2--)
			{
				if (DAB84111[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	internal int FAACA12E => int_0 + 1;

	private static void smethod_0(ref Struct11 ACBD241A, ref Struct11 AF23D4AD, bool E4A06036, ref Struct11 struct11_0)
	{
		struct11_0.method_8(0u);
		if (ACBD241A.int_0 < AF23D4AD.int_0)
		{
			return;
		}
		int num = AF23D4AD.int_0 + 1;
		int num2 = ACBD241A.int_0 - AF23D4AD.int_0;
		int num3 = num2;
		int num4 = ACBD241A.int_0;
		while (true)
		{
			if (num4 >= num2)
			{
				if (AF23D4AD.DAB84111[num4 - num2] == ACBD241A.DAB84111[num4])
				{
					num4--;
					continue;
				}
				if (AF23D4AD.DAB84111[num4 - num2] < ACBD241A.DAB84111[num4])
				{
					num3++;
				}
				break;
			}
			num3++;
			break;
		}
		if (num3 == 0)
		{
			return;
		}
		if (E4A06036)
		{
			struct11_0.method_4(num3);
		}
		uint num5 = AF23D4AD.DAB84111[num - 1];
		uint num6 = AF23D4AD.DAB84111[num - 2];
		int num7 = Class90.CB28E8BD(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= AF23D4AD.DAB84111[num - 3] >> num8;
			}
		}
		ACBD241A.method_1();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= ACBD241A.int_0) ? ACBD241A.DAB84111[num9 + num] : 0u);
			ulong num11 = Class90.E5BAE221(num10, ACBD241A.DAB84111[num9 + num - 1]);
			uint num12 = ACBD241A.DAB84111[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= ACBD241A.DAB84111[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > 4294967295L)
			{
				num14 += num5 * (num13 - 4294967295L);
				num13 = 4294967295uL;
			}
			for (; num14 <= 4294967295L && num13 * num6 > Class90.E5BAE221((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 > 0L)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += AF23D4AD.DAB84111[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (ACBD241A.DAB84111[num9 + i] < num16)
					{
						num15++;
					}
					ACBD241A.DAB84111[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint f489B0A = 0u;
					for (int j = 0; j < num; j++)
					{
						f489B0A = smethod_2(ref ACBD241A.DAB84111[num9 + j], AF23D4AD.DAB84111[j], f489B0A);
					}
					num13--;
				}
				ACBD241A.int_0 = num9 + num - 1;
			}
			if (E4A06036)
			{
				if (num3 == 1)
				{
					struct11_0.E510E285 = (uint)num13;
				}
				else
				{
					struct11_0.DAB84111[num9] = (uint)num13;
				}
			}
		}
		ACBD241A.int_0 = num - 1;
		ACBD241A.method_0();
	}

	private static uint B4B5F60A(ref Struct11 struct11_0, uint uint_0)
	{
		if (uint_0 == 1)
		{
			return 0u;
		}
		if (struct11_0.int_0 == 0)
		{
			return struct11_0.E510E285 % uint_0;
		}
		ulong num = 0uL;
		for (int num2 = struct11_0.int_0; num2 >= 0; num2--)
		{
			num = Class90.E5BAE221((uint)num, struct11_0.DAB84111[num2]);
			num %= uint_0;
		}
		return (uint)num;
	}

	private void method_0()
	{
		if (int_0 > 0 && DAB84111[int_0] == 0)
		{
			E510E285 = DAB84111[0];
			while (--int_0 > 0 && DAB84111[int_0] == 0)
			{
			}
		}
	}

	private void EB240920(ulong ulong_0)
	{
		uint num = Class90.smethod_2(ulong_0);
		if (num == 0)
		{
			E510E285 = Class90.smethod_0(ulong_0);
			int_0 = 0;
		}
		else
		{
			method_4(2);
			DAB84111[0] = (uint)ulong_0;
			DAB84111[1] = num;
		}
	}

	internal void BBBE2FBD(ref Struct11 struct11_0)
	{
		if (struct11_0.int_0 == 0)
		{
			method_8(B4B5F60A(ref this, struct11_0.E510E285));
		}
		else if (int_0 != 0)
		{
			Struct11 struct11_ = default(Struct11);
			smethod_0(ref this, ref struct11_0, E4A06036: false, ref struct11_);
		}
	}

	private void method_1(int F78FA630 = 0)
	{
		if (!E5A47C19)
		{
			uint[] array = new uint[int_0 + 1 + F78FA630];
			Array.Copy(DAB84111, array, int_0 + 1);
			DAB84111 = array;
			E5A47C19 = true;
		}
	}

	private static uint smethod_1(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		ulong num = (ulong)((long)uint_1 * (long)uint_2 + uint_0 + uint_3);
		uint_0 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_2(int int_1)
	{
		if (int_1 <= 1)
		{
			int_0 = 0;
			E510E285 = 0u;
			return;
		}
		if (E5A47C19 && DAB84111.Length >= int_1)
		{
			Array.Clear(DAB84111, 0, int_1);
		}
		else
		{
			DAB84111 = new uint[int_1];
			E5A47C19 = true;
		}
		int_0 = int_1 - 1;
	}

	private void method_3(ref Struct11 D39B9B2D, int int_1)
	{
		if (D39B9B2D.int_0 == 0)
		{
			E510E285 = D39B9B2D.E510E285;
			int_0 = 0;
			return;
		}
		if (!E5A47C19 || DAB84111.Length <= D39B9B2D.int_0)
		{
			DAB84111 = new uint[D39B9B2D.int_0 + 1 + int_1];
			E5A47C19 = true;
		}
		int_0 = D39B9B2D.int_0;
		Array.Copy(D39B9B2D.DAB84111, DAB84111, int_0 + 1);
	}

	private void EA853B97(uint uint_0)
	{
		switch (uint_0)
		{
		case 0u:
			method_8(0u);
			return;
		case 1u:
			return;
		}
		if (int_0 == 0)
		{
			EB240920((ulong)E510E285 * (ulong)uint_0);
			return;
		}
		method_1(1);
		uint num = 0u;
		for (int i = 0; i <= int_0; i++)
		{
			num = D90DEB22(ref DAB84111[i], uint_0, num);
		}
		if (num != 0)
		{
			method_5(int_0 + 2, 0);
			DAB84111[int_0] = num;
		}
	}

	internal Struct11(int int_1)
	{
		int_0 = 0;
		E510E285 = 0u;
		if (int_1 > 1)
		{
			DAB84111 = new uint[int_1];
			E5A47C19 = true;
		}
		else
		{
			DAB84111 = null;
			E5A47C19 = false;
		}
	}

	private static uint D90DEB22(ref uint uint_0, uint B1065481, uint EA8FF68A)
	{
		ulong num = (ulong)((long)uint_0 * (long)B1065481 + EA8FF68A);
		uint_0 = (uint)num;
		return (uint)(num >> 32);
	}

	internal Struct11(Struct12 struct12_0, ref int int_1)
	{
		E5A47C19 = false;
		DAB84111 = struct12_0.UInt32_0;
		int int32_ = struct12_0.Int32_1;
		int num = int32_ >> 31;
		int_1 = (int_1 ^ num) - num;
		if (DAB84111 == null)
		{
			int_0 = 0;
			E510E285 = (uint)((int32_ ^ num) - num);
			return;
		}
		int_0 = DAB84111.Length - 1;
		E510E285 = DAB84111[0];
		while (int_0 > 0 && DAB84111[int_0] == 0)
		{
			int_0--;
		}
	}

	private void B89BF892(int A41C72AB, out int int_1, out uint[] uint_0)
	{
		if (int_0 == 0)
		{
			if (E510E285 <= int.MaxValue)
			{
				int_1 = A41C72AB * (int)E510E285;
				uint_0 = null;
				return;
			}
			if (DAB84111 == null)
			{
				DAB84111 = new uint[1] { E510E285 };
			}
			else if (E5A47C19)
			{
				DAB84111[0] = E510E285;
			}
			else if (DAB84111[0] != E510E285)
			{
				DAB84111 = new uint[1] { E510E285 };
			}
		}
		int_1 = A41C72AB;
		int num = DAB84111.Length - int_0 - 1;
		if (num <= 1)
		{
			if (num == 0 || DAB84111[int_0 + 1] == 0)
			{
				E5A47C19 = false;
				uint_0 = DAB84111;
				return;
			}
			if (E5A47C19)
			{
				DAB84111[int_0 + 1] = 0u;
				E5A47C19 = false;
				uint_0 = DAB84111;
				return;
			}
		}
		uint_0 = DAB84111;
		Array.Resize(ref uint_0, int_0 + 1);
		if (!E5A47C19)
		{
			DAB84111 = uint_0;
		}
	}

	private void method_4(int B39C4390)
	{
		if (B39C4390 <= 1)
		{
			int_0 = 0;
			return;
		}
		if (!E5A47C19 || DAB84111.Length < B39C4390)
		{
			DAB84111 = new uint[B39C4390];
			E5A47C19 = true;
		}
		int_0 = B39C4390 - 1;
	}

	private void method_5(int int_1, int int_2)
	{
		if (int_1 <= 1)
		{
			if (int_0 > 0)
			{
				E510E285 = DAB84111[0];
			}
			int_0 = 0;
			return;
		}
		if (E5A47C19 && DAB84111.Length >= int_1)
		{
			if (int_0 + 1 < int_1)
			{
				Array.Clear(DAB84111, int_0 + 1, int_1 - int_0 - 1);
				if (int_0 == 0)
				{
					DAB84111[0] = E510E285;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_1 + int_2];
			if (int_0 == 0)
			{
				array[0] = E510E285;
			}
			else
			{
				Array.Copy(DAB84111, array, Math.Min(int_1, int_0 + 1));
			}
			DAB84111 = array;
			E5A47C19 = true;
		}
		int_0 = int_1 - 1;
	}

	internal void method_6(ref Struct11 struct11_0, ref Struct11 struct11_1)
	{
		if (struct11_0.int_0 == 0)
		{
			if (struct11_1.int_0 == 0)
			{
				EB240920((ulong)struct11_0.E510E285 * (ulong)struct11_1.E510E285);
				return;
			}
			method_3(ref struct11_1, 1);
			EA853B97(struct11_0.E510E285);
			return;
		}
		if (struct11_1.int_0 == 0)
		{
			method_3(ref struct11_0, 1);
			EA853B97(struct11_1.E510E285);
			return;
		}
		method_2(struct11_0.int_0 + struct11_1.int_0 + 2);
		uint[] dAB;
		int num;
		uint[] dAB2;
		int num2;
		if (struct11_0.Int32_0 <= struct11_1.Int32_0)
		{
			dAB = struct11_0.DAB84111;
			num = struct11_0.int_0 + 1;
			dAB2 = struct11_1.DAB84111;
			num2 = struct11_1.int_0 + 1;
		}
		else
		{
			dAB = struct11_1.DAB84111;
			num = struct11_1.int_0 + 1;
			dAB2 = struct11_0.DAB84111;
			num2 = struct11_0.int_0 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = dAB[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = smethod_1(ref DAB84111[num5], num3, dAB2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = smethod_2(ref DAB84111[num5++], 0u, num4);
				}
			}
		}
		method_0();
	}

	private static uint smethod_2(ref uint uint_0, uint D98226BF, uint F489B0A5)
	{
		ulong num = (ulong)((long)uint_0 + (long)D98226BF + F489B0A5);
		uint_0 = (uint)num;
		return (uint)(num >> 32);
	}

	internal Struct12 method_7(int int_1)
	{
		B89BF892(int_1, out int_1, out var uint_);
		return new Struct12(int_1, uint_);
	}

	private void method_8(uint uint_0)
	{
		E510E285 = uint_0;
		int_0 = 0;
	}

	private void method_9(bool A60EBE33)
	{
	}
}
