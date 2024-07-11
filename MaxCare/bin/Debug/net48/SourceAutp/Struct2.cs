internal struct Struct2
{
	private readonly Struct12[] struct12_0;

	private readonly int int_0;

	public uint method_0(Class50 class50_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			struct12_0[1].method_0(class50_0);
		}
		return 0u;
	}

	public void method_1()
	{
		while (1L < 1 << int_0)
		{
			struct12_0[1].method_1();
		}
	}

	public static uint smethod_0(Struct12[] struct12_1, uint uint_0, Class50 class50_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			struct12_1[uint_0 + 1].method_0(class50_0);
		}
		return 0u;
	}

	public uint method_2(Class50 class50_0)
	{
		for (int num = int_0; num > 0; num--)
		{
			_ = 2 + struct12_0[1].method_0(class50_0);
		}
		return (uint)(1 - (1 << int_0));
	}

	public Struct2(int int_1)
	{
		int_0 = int_1;
		struct12_0 = new Struct12[1 << int_1];
	}
}
