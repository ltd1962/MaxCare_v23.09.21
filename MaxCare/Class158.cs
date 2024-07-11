using System.IO;

internal class Class158
{
	public Stream AA37B4AF;

	public uint CAAACF19;

	public uint uint_0;

	private uint uint_1 = 1u;

	public void method_0()
	{
		AA37B4AF = null;
	}

	public uint method_1(int A399AB90)
	{
		uint num = uint_0;
		uint num2 = CAAACF19;
		for (int num3 = A399AB90; num3 > 0; num3--)
		{
			num >>= 1;
			num2 -= num & 0xFFFFFFFFu;
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)AA37B4AF.ReadByte();
				num <<= 8;
			}
		}
		uint_0 = num;
		CAAACF19 = num2;
		return 0u;
	}

	public void method_2(Stream stream_0)
	{
		AA37B4AF = stream_0;
		CAAACF19 = 0u;
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			CAAACF19 = (CAAACF19 << 8) | (byte)AA37B4AF.ReadByte();
		}
	}
}
