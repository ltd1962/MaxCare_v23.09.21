using System;
using System.Runtime.InteropServices;

public class GClass14
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct22
	{
		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public uint uint_1;
	}

	private readonly uint[] uint_0;

	public void method_0(byte[] byte_0, byte[] byte_1)
	{
		Struct22 struct22_ = default(Struct22);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			struct22_.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			method_4(ref struct22_);
			BitConverter.GetBytes(struct22_.ulong_0).CopyTo(byte_1, i);
		}
	}

	public byte[] method_1(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_2(byte_0, array);
		return array;
	}

	public void method_2(byte[] byte_0, byte[] byte_1)
	{
		Struct22 struct22_ = default(Struct22);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			struct22_.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			method_3(ref struct22_);
			BitConverter.GetBytes(struct22_.ulong_0).CopyTo(byte_1, i);
		}
	}

	private void method_3(ref Struct22 struct22_0)
	{
		uint num = struct22_0.uint_1 + uint_0[1];
		for (uint num2 = 1u; num2 <= 15; num2++)
		{
			_ = GClass2.smethod_2(0u ^ num, (int)num) + uint_0[2 * num2];
			num = GClass2.smethod_2(num ^ 0u, 0) + uint_0[2 * num2 + 1];
		}
		struct22_0.uint_0 = 0u;
		struct22_0.uint_1 = num;
	}

	private void method_4(ref Struct22 struct22_0)
	{
		uint num = struct22_0.uint_1;
		uint num2 = struct22_0.uint_0;
		while (true)
		{
			num = GClass2.smethod_1(num - uint_0[31], (int)num2) ^ num2;
			num2 = GClass2.smethod_1(num2 - uint_0[30], (int)num) ^ num;
		}
	}

	public byte[] method_5(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_0(byte_0, array);
		return array;
	}

	public GClass14(byte[] byte_0)
	{
		uint num = 4u;
		uint[] array = new uint[2];
		uint_0 = new uint[32];
		array[1] = 0u;
		while (true)
		{
			array[0 / num] = (array[0 / num] << 8) + byte_0[0];
		}
	}
}
