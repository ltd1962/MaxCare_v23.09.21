using System.Runtime.InteropServices;

public class GClass11
{
	private GClass13 gclass13_0;

	private GClass16 gclass16_0;

	private GClass12 gclass12_0;

	private GClass1 gclass1_0;

	public static readonly GClass11 gclass11_0;

	public GClass12 GClass12_0
	{
		get
		{
			return (GClass12)new GClass7().method_5(new object[1] { this }, 29690);
		}
		private set
		{
			new GClass7().method_5(new object[2] { this, value }, 279026);
		}
	}

	public GClass16 GClass16_0
	{
		get
		{
			return (GClass16)new GClass7().method_5(new object[1] { this }, 29890);
		}
		private set
		{
			new GClass7().method_5(new object[2] { this, value }, 18498);
		}
	}

	public GClass13 GClass13_0
	{
		get
		{
			return (GClass13)new GClass7().method_5(new object[1] { this }, 388474);
		}
		private set
		{
			new GClass7().method_5(new object[2] { this, value }, 277942);
		}
	}

	public GClass1 GClass1_0
	{
		get
		{
			return (GClass1)new GClass7().method_5(new object[1] { this }, 282569);
		}
		private set
		{
			new GClass7().method_5(new object[2] { this, value }, 387418);
		}
	}

	public GClass11()
	{
		new GClass7().method_5(new object[1] { this }, 283039);
	}

	public static bool smethod_0(ref string string_0)
	{
		object[] array = new object[1] { string_0 };
		try
		{
			return (bool)new GClass7().method_5(array, 30482);
		}
		finally
		{
			string_0 = (string)array[0];
		}
	}

	internal static bool smethod_1(byte[] byte_0)
	{
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (num + 3 >= byte_0.Length || byte_0[num] != 81 || byte_0[num + 1] != 69 || byte_0[num + 2] != 77 || byte_0[num + 3] != 85)
				{
					if (num + -72 >= byte_0.Length || byte_0[num] != 77 || byte_0[num + 1] != 105 || byte_0[num + 2] != 99 || byte_0[num + 3] != 114 || byte_0[num + 4] != 111 || byte_0[num + 5] != 115 || byte_0[num + 6] != 111 || byte_0[num + 7] != 102 || byte_0[num + 8] != 116)
					{
						if (num + 6 >= byte_0.Length || byte_0[num] != 105 || byte_0[num + 1] != 110 || byte_0[num + 2] != 110 || byte_0[num + 3] != 111 || byte_0[num + 4] != 116 || byte_0[num + 5] != 101 || byte_0[num + 6] != 107)
						{
							if (num + 2143289353 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 105 || byte_0[num + 2] != 114 || byte_0[num + 3] != 116 || byte_0[num + 4] != 117 || byte_0[num + 5] != 97 || byte_0[num + 6] != 108 || byte_0[num + 7] != 66 || byte_0[num + 8] != 111 || byte_0[num + 9] != 120)
							{
								if (num + 5 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 77 || byte_0[num + 2] != 119 || byte_0[num + 3] != 97 || byte_0[num + 4] != 114 || byte_0[num + 5] != 101)
								{
									if (num + 8 < byte_0.Length && byte_0[num] == 80 && byte_0[num + 1] == 97 && byte_0[num + 2] == 114 && byte_0[num + 3] == 97 && byte_0[num + 4] == 108 && byte_0[num + 5] == 108 && byte_0[num + 6] == 101 && byte_0[num + 7] == 108 && byte_0[num + 8] == 115)
									{
										break;
									}
									num++;
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static string smethod_2(uint uint_0)
	{
		return (string)new GClass7().method_5(new object[1] { uint_0 }, 385666);
	}

	public static bool smethod_3()
	{
		return (bool)new GClass7().method_5(null, 26294);
	}

	public unsafe static bool smethod_4()
	{
		if (GClass15.smethod_9())
		{
			return false;
		}
		uint num = *(uint*)(void*)Class49.smethod_1(31128u);
		uint num2 = 279296u;
		bool result = true;
		if (*(uint*)(void*)Class49.smethod_1(17859u) != GClass8.smethod_0(Class49.smethod_1(279296u), num))
		{
			result = false;
		}
		GClass5 gClass = new GClass5();
		for (uint num3 = 0u; num3 < num; num3 += 12)
		{
			uint* ptr = (uint*)(void*)Class49.smethod_1(num2 + num3);
			uint uint_ = gClass.method_0(*ptr);
			uint uint_2 = gClass.method_0(ptr[1]);
			uint num4 = gClass.method_0(ptr[2]);
			if (GClass8.smethod_0(Class49.smethod_1(uint_), uint_2) != num4)
			{
				result = false;
			}
		}
		num = GClass15.smethod_1();
		uint num5 = *(uint*)(void*)Class49.smethod_1(num + 4);
		uint num6 = *(uint*)(void*)Class49.smethod_1(num + 8);
		if (num5 != 0)
		{
			long num7 = Class49.smethod_0();
			Class52.Struct5* ptr2 = (Class52.Struct5*)num7;
			if (ptr2->ushort_0 == 23117)
			{
				uint uint_3 = ptr2->uint_0;
				Class52.Struct6* ptr3 = (Class52.Struct6*)(num7 + uint_3);
				if (ptr3->uint_0 == 17744)
				{
					uint_3 += (uint)Marshal.SizeOf(typeof(Class52.Struct6));
					switch (*(ushort*)(num7 + uint_3))
					{
					}
				}
			}
		}
		num = *(uint*)(void*)Class49.smethod_1(num);
		num2 = GClass15.smethod_7();
		if (*(uint*)(void*)Class49.smethod_1(GClass15.smethod_2()) != GClass8.smethod_0(Class49.smethod_1(num2), num))
		{
			result = false;
		}
		GClass5 gClass2 = new GClass5();
		for (uint num8 = 0u; num8 < num; num8 += 12)
		{
			uint* ptr4 = (uint*)(void*)Class49.smethod_1(num2 + num8);
			uint num9 = gClass2.method_0(*ptr4);
			uint uint_4 = gClass2.method_0(ptr4[1]);
			uint num10 = gClass2.method_0(ptr4[2]);
			if ((num9 < num5 || num9 >= num6) && GClass8.smethod_0(Class49.smethod_1(num9), uint_4) != num10)
			{
				result = false;
			}
		}
		return result;
	}

	private static void smethod_5()
	{
		new GClass7().method_5(null, 390459);
	}

	static GClass11()
	{
		new GClass7().method_5(null, 281985);
	}

	public static void smethod_6(string string_0)
	{
		new GClass7().method_5(new object[1] { string_0 }, 385118);
	}

	public static bool smethod_7(bool bool_0)
	{
		return (bool)new GClass7().method_5(new object[1] { bool_0 }, 387927);
	}
}
