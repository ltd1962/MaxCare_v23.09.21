using System;
using System.Collections.Generic;
using System.Reflection;

public class GClass13
{
	private readonly Dictionary<string, uint> dictionary_0;

	private GClass14 gclass14_0;

	private Assembly method_0(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return (Assembly)new GClass7().method_5(new object[3] { this, object_0, resolveEventArgs_0 }, 27970);
	}

	private void method_1(ref byte[] byte_0, uint uint_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)(byte_0[i] ^ (GClass2.smethod_2(uint_0, i) + i));
		}
	}

	public GClass13()
	{
		new GClass7().method_5(new object[1] { this }, 276024);
	}
}
