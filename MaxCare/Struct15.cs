internal struct Struct15
{
	private readonly Struct16[] F312BEB4;

	private readonly int D62A2CA7;

	public uint method_0(Class158 F8386081)
	{
		for (int num = D62A2CA7; num > 0; num--)
		{
			_ = 2 + F312BEB4[1].method_0(F8386081);
		}
		return (uint)(1 - (1 << D62A2CA7));
	}

	public void FB06CAA8()
	{
		while (1L < 1 << D62A2CA7)
		{
			F312BEB4[1].method_1();
		}
	}

	public static uint smethod_0(Struct16[] struct16_0, uint uint_0, Class158 class158_0, int int_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			struct16_0[uint_0 + 1].method_0(class158_0);
		}
		return 0u;
	}

	public uint method_1(Class158 class158_0)
	{
		for (int i = 0; i < D62A2CA7; i++)
		{
			F312BEB4[1].method_0(class158_0);
		}
		return 0u;
	}

	public Struct15(int int_0)
	{
		D62A2CA7 = int_0;
		F312BEB4 = new Struct16[1 << int_0];
	}
}
