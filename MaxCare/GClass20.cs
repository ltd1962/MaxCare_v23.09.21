using System.IO;

public class GClass20
{
	public uint uint_0;

	private uint uint_1;

	private uint uint_2 = 1u;

	private uint uint_3;

	private uint uint_4;

	private Stream EB2C6292;

	private byte[] B18BEB9A;

	public void E39A1B11(Stream C688FC38, bool bool_0)
	{
		method_3();
		EB2C6292 = C688FC38;
		if (!bool_0)
		{
			uint_4 = 0u;
			uint_3 = 0u;
			uint_0 = 0u;
		}
	}

	public byte method_0(uint uint_5)
	{
		if (0 < uint_1)
		{
		}
		return B18BEB9A[0];
	}

	public void method_1()
	{
	}

	public void F62CF602(uint uint_5, uint D6279384)
	{
		if (0 >= uint_1)
		{
		}
		while (D6279384 != 0)
		{
			if (0 < uint_1)
			{
			}
			B18BEB9A[uint_3++] = B18BEB9A[0];
			if (uint_3 >= uint_1)
			{
				method_1();
			}
			D6279384--;
		}
	}

	public void method_2(byte DE9F21AB)
	{
		B18BEB9A[uint_3++] = DE9F21AB;
		if (uint_3 >= uint_1)
		{
			method_1();
		}
	}

	public void method_3()
	{
		method_1();
		EB2C6292 = null;
	}

	public void D1B0EC38(uint F03D3F22)
	{
		if (uint_1 != F03D3F22)
		{
			B18BEB9A = new byte[F03D3F22];
		}
		uint_1 = F03D3F22;
		uint_3 = 0u;
		uint_4 = 0u;
	}
}
