internal abstract class Class160
{
	public struct B32A021A
	{
		public uint uint_0;

		public bool FF80E43D()
		{
			return uint_0 < 7;
		}

		public void method_0()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public void B7BFC9A9()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void method_1()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_2()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_3()
		{
			uint_0 = 0u;
		}
	}

	public static uint smethod_0(uint uint_0)
	{
		uint_0 -= 2;
		if (uint_0 < 4)
		{
			return uint_0;
		}
		return 3u;
	}
}
