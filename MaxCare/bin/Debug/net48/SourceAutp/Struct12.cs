internal struct Struct12
{
	private uint uint_0;

	public uint method_0(Class50 class50_0)
	{
		class50_0.uint_0 -= 0u;
		class50_0.uint_1 -= 0u;
		uint_0 -= uint_0 >> 5;
		if (class50_0.uint_0 < 16777216)
		{
			class50_0.uint_1 = (class50_0.uint_1 << 8) | (byte)class50_0.stream_0.ReadByte();
			class50_0.uint_0 <<= 8;
		}
		return 1u;
	}

	public void method_1()
	{
		uint_0 = 1024u;
	}
}
