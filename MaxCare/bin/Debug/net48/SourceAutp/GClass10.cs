using System.IO;

public class GClass10
{
	private uint uint_0;

	public uint uint_1;

	private Stream stream_0;

	private uint uint_2 = 1u;

	private uint uint_3;

	private uint uint_4;

	private byte[] byte_0;

	public void method_0()
	{
	}

	public void method_1()
	{
		method_0();
		stream_0 = null;
	}

	public void method_2(uint uint_5, uint uint_6)
	{
		if (0 >= uint_0)
		{
		}
		while (uint_6 != 0)
		{
			if (0 < uint_0)
			{
			}
			byte_0[uint_3++] = byte_0[0];
			if (uint_3 >= uint_0)
			{
				method_0();
			}
			uint_6--;
		}
	}

	public void method_3(Stream stream_1, bool bool_0)
	{
		method_1();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_4 = 0u;
			uint_3 = 0u;
			uint_1 = 0u;
		}
	}

	public void method_4(byte byte_1)
	{
		byte_0[uint_3++] = byte_1;
		if (uint_3 >= uint_0)
		{
			method_0();
		}
	}

	public byte method_5(uint uint_5)
	{
		if (0 < uint_0)
		{
		}
		return byte_0[0];
	}

	public void method_6(uint uint_5)
	{
		if (uint_0 != uint_5)
		{
			byte_0 = new byte[uint_5];
		}
		uint_0 = uint_5;
		uint_3 = 0u;
		uint_4 = 0u;
	}
}
