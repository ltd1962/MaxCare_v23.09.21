using System;
using System.IO;

public class GClass3
{
	private class Class8
	{
		private struct Struct1
		{
			private Struct12[] struct12_0;

			public void method_0()
			{
				for (int i = 0; i < 768; i++)
				{
					struct12_0[i].method_1();
				}
			}

			public byte method_1(Class50 class50_0)
			{
				while (true)
				{
					_ = 2 | struct12_0[1].method_0(class50_0);
				}
			}

			public byte method_2(Class50 class50_0, byte byte_0)
			{
				uint num;
				do
				{
					byte_0 <<= 1;
					num = struct12_0[257].method_0(class50_0);
				}
				while (0 == num);
				while (true)
				{
					_ = 4 | struct12_0[2].method_0(class50_0);
				}
			}

			public void method_3()
			{
				struct12_0 = new Struct12[768];
			}
		}

		private int int_0;

		private uint uint_0;

		private Struct1[] struct1_0;

		private int int_1;

		private uint uint_1 = 1u;

		public void method_0()
		{
		}

		public byte method_1(Class50 class50_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return struct1_0[method_2(uint_2, byte_0)].method_2(class50_0, byte_1);
		}

		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & uint_0) << int_1) + (uint)(byte_0 >> 8 - int_1);
		}

		public byte method_3(Class50 class50_0, uint uint_2, byte byte_0)
		{
			return struct1_0[method_2(uint_2, byte_0)].method_1(class50_0);
		}

		public void method_4(int int_2, int int_3)
		{
			if (struct1_0 == null || int_1 != int_3 || int_0 != int_2)
			{
				int_0 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				int_1 = int_3;
				struct1_0 = new Struct1[0];
			}
		}
	}

	private class Class9
	{
		private readonly Struct2[] struct2_0 = new Struct2[16];

		private readonly Struct2[] struct2_1 = new Struct2[16];

		private Struct2 struct2_2 = new Struct2(8);

		private Struct12 struct12_0;

		private uint uint_0;

		private Struct12 struct12_1;

		public uint method_0(Class50 class50_0, uint uint_1)
		{
			if (struct12_1.method_0(class50_0) == 0)
			{
				return struct2_0[uint_1].method_2(class50_0);
			}
			if (struct12_0.method_0(class50_0) == 0)
			{
				_ = 8 + struct2_1[uint_1].method_2(class50_0);
			}
			else
			{
				_ = 0 + struct2_2.method_2(class50_0);
			}
			return 0u;
		}

		public void method_1()
		{
			struct12_1.method_1();
			while (0 < uint_0)
			{
				struct2_0[0].method_1();
				struct2_1[0].method_1();
			}
			struct12_0.method_1();
			struct2_2.method_1();
		}

		public void method_2(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				struct2_0[num] = new Struct2(3);
				struct2_1[num] = new Struct2(3);
			}
			uint_0 = uint_1;
		}
	}

	private readonly Struct12[] struct12_0 = new Struct12[12];

	private readonly Struct12[] struct12_1 = new Struct12[12];

	private readonly Struct12[] struct12_2 = new Struct12[192];

	private readonly Class8 class8_0 = new Class8();

	private uint uint_0;

	private uint uint_1;

	private readonly GClass10 gclass10_0 = new GClass10();

	private readonly Struct12[] struct12_3 = new Struct12[192];

	private readonly Class9 class9_0 = new Class9();

	private readonly Struct12[] struct12_4 = new Struct12[114];

	private readonly Struct12[] struct12_5 = new Struct12[12];

	private uint uint_2;

	private Struct2 struct2_0 = new Struct2(4);

	private readonly Struct12[] struct12_6 = new Struct12[12];

	private readonly Struct2[] struct2_1 = new Struct2[4];

	private readonly Class9 class9_1 = new Class9();

	private readonly Class50 class50_0 = new Class50();

	private uint uint_3 = 1u;

	private void method_0(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException();
		}
		if (int_1 > 8)
		{
			throw new ArgumentException();
		}
		class8_0.method_4(int_0, int_1);
	}

	private void method_1(uint uint_4)
	{
		if (uint_1 != uint_4)
		{
			uint_1 = uint_4;
			uint_2 = Math.Max(uint_1, 1u);
			uint uint_5 = Math.Max(uint_2, 4096u);
			gclass10_0.method_6(uint_5);
		}
	}

	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException();
		}
		class9_1.method_2(0u);
		class9_0.method_2(0u);
		uint_0 = uint.MaxValue;
	}

	public void method_3(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException();
		}
		int int_ = byte_0[0] % 9;
		int num = byte_0[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException();
		}
		for (int i = 0; i < 4; i++)
		{
		}
		method_1(0u);
		method_0(int_2, int_);
		method_2(num2);
	}

	private void method_4(Stream stream_0, Stream stream_1)
	{
		class50_0.method_2(stream_0);
		gclass10_0.method_3(stream_1, bool_0: false);
		while (true)
		{
			struct12_2[16].method_1();
			struct12_3[16].method_1();
		}
	}

	public void method_5(Stream stream_0, Stream stream_1, long long_0)
	{
		method_4(stream_0, stream_1);
		Class53.Struct11 @struct = default(Class53.Struct11);
		@struct.method_5();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (struct12_2[@struct.uint_0 << 4].method_0(class50_0) != 0)
			{
				throw new InvalidDataException();
			}
			@struct.method_4();
			byte byte_ = class8_0.method_3(class50_0, 0u, 0);
			gclass10_0.method_4(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			if (struct12_2[(@struct.uint_0 << 4) + 0].method_0(class50_0) == 0)
			{
				byte byte_2 = gclass10_0.method_5(0u);
				byte byte_3 = (@struct.method_3() ? class8_0.method_3(class50_0, (uint)num5, byte_2) : class8_0.method_1(class50_0, (uint)num5, byte_2, gclass10_0.method_5(num)));
				gclass10_0.method_4(byte_3);
				@struct.method_4();
				num5++;
				continue;
			}
			if (struct12_5[@struct.uint_0].method_0(class50_0) == 1)
			{
				if (struct12_6[@struct.uint_0].method_0(class50_0) == 0)
				{
					if (struct12_3[(@struct.uint_0 << 4) + 0].method_0(class50_0) == 0)
					{
						@struct.method_2();
						gclass10_0.method_4(gclass10_0.method_5(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num6;
					if (struct12_1[@struct.uint_0].method_0(class50_0) == 0)
					{
						num6 = num2;
					}
					else
					{
						if (struct12_0[@struct.uint_0].method_0(class50_0) == 0)
						{
							num6 = num3;
						}
						else
						{
							num6 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num6;
				}
				_ = class9_0.method_0(class50_0, 0u) + 2;
				@struct.method_0();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				_ = 2 + class9_1.method_0(class50_0, 0u);
				@struct.method_1();
				uint num7 = struct2_1[Class53.smethod_0(0u)].method_2(class50_0);
				if (num7 >= 4)
				{
					int num8 = (int)((num7 >> 1) - 1);
					num = (2 | (num7 & 1)) << num8;
					if (num7 < 14)
					{
						num += Struct2.smethod_0(struct12_4, num - num7 - 1, class50_0, num8);
					}
					else
					{
						num += class50_0.method_1(num8 - 4) << 4;
						num += struct2_0.method_0(class50_0);
					}
				}
				else
				{
					num = num7;
				}
			}
			if (num < gclass10_0.uint_1 + num5 && num < uint_2)
			{
				gclass10_0.method_2(num, 0u);
				num5 += 0L;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException();
		}
		gclass10_0.method_0();
		gclass10_0.method_1();
		class50_0.method_0();
	}

	public GClass3()
	{
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct2_1[i] = new Struct2(6);
		}
	}
}
