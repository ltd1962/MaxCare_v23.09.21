using System;
using System.Collections.Generic;
using System.Linq;

public static class CollectionHelper
{
	public static bool A69D960A(List<string> list_0, List<string> list_1)
	{
		List<string> source = list_0.Except(list_1).ToList();
		List<string> source2 = list_1.Except(list_0).ToList();
		return !source.Any() && !source2.Any();
	}

	public static List<string> ShuffleList(List<string> list_0)
	{
		string text = "";
		int num = list_0.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Base.rd.Next(0, list_0.Count);
			num--;
			text = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = text;
		}
		return list_0;
	}

	public static List<string> CloneList(List<string> BC13D290)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < BC13D290.Count; i++)
			{
				list.Add(BC13D290[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<List<string>> smethod_0(List<string> B2A67E1D, int int_0)
	{
		List<List<string>> list = new List<List<string>>();
		try
		{
			int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)B2A67E1D.Count * 1.0 / (double)int_0)));
			for (int i = 0; i < num; i++)
			{
				list.Add(B2A67E1D.GetRange(int_0 * i, (int_0 * i + int_0 <= B2A67E1D.Count) ? int_0 : (B2A67E1D.Count % int_0)));
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_1(List<string> list_0, string B23BC316 = "\r\n")
	{
		return string.Join(B23BC316, list_0);
	}

	public static string smethod_2(List<string> list_0)
	{
		string result = "";
		if (list_0.Count > 0)
		{
			result = list_0.Last();
			list_0.RemoveAt(list_0.Count - 1);
		}
		return result;
	}

	public static List<string> smethod_3(List<string> list_0, List<string> list_1)
	{
		foreach (string item in list_1)
		{
			list_0.Remove(item);
		}
		return list_0;
	}

	public static int D331D504(int E52E5ABE)
	{
		return smethod_4(0, E52E5ABE - 1);
	}

	public static int smethod_4(int int_0, int int_1)
	{
		return Base.rd.Next(int_0, int_1 + 1);
	}

	public static int smethod_5(this List<string> list_0)
	{
		return D331D504(list_0.Count);
	}

	public static string GetRandomItem(this List<string> list_0)
	{
		if (list_0.Count == 0)
		{
			return null;
		}
		return list_0[list_0.smethod_5()];
	}
}
