using System.IO;

internal class Class50
{
	public Stream stream_0;

	public uint uint_0;

	public uint uint_1;

	private uint uint_2 = 1u;

	public void method_0()
	{
		stream_0 = null;
	}

	public uint method_1(int int_0)
	{
		uint num = uint_0;
		uint num2 = uint_1;
		for (int num3 = int_0; num3 > 0; num3--)
		{
			num >>= 1;
			num2 -= num & 0xFFFFFFFFu;
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)stream_0.ReadByte();
				num <<= 8;
			}
		}
		uint_0 = num;
		uint_1 = num2;
		return 0u;
	}

	public void method_2(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_1 = 0u;
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_1 = (uint_1 << 8) | (byte)stream_0.ReadByte();
		}
	}
}
