internal struct Struct16
{
	private uint uint_0;

	public uint method_0(Class158 class158_0)
	{
		class158_0.uint_0 -= 0u;
		class158_0.CAAACF19 -= 0u;
		uint_0 -= uint_0 >> 5;
		if (class158_0.uint_0 < 16777216)
		{
			class158_0.CAAACF19 = (class158_0.CAAACF19 << 8) | (byte)class158_0.AA37B4AF.ReadByte();
			class158_0.uint_0 <<= 8;
		}
		return 1u;
	}

	public void method_1()
	{
		uint_0 = 1024u;
	}
}
