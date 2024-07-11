using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

internal class UpdateStatus
{
	[Serializable]
	[CompilerGenerated]
	private sealed class E2270382
	{
		public static readonly E2270382 _003C_003E9 = new E2270382();

		public static Func<DataRow, string> _003C_003E9__4_0;

		public static Func<DataRow, string> _003C_003E9__4_1;

		public static Func<KeyValuePair<string, string>, bool> _003C_003E9__5_0;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__5_1;

		internal string B403203F(DataRow dataRow_0)
		{
			return dataRow_0[0].ToString();
		}

		internal string method_0(DataRow CD27D50A)
		{
			return CD27D50A[1].ToString();
		}

		internal bool A9AD3181(KeyValuePair<string, string> CD05B308)
		{
			KeyValuePair<string, string> keyValuePair = CD05B308;
			return keyValuePair.Value.Trim() != "";
		}

		internal string method_1(KeyValuePair<string, string> A92670B1)
		{
			KeyValuePair<string, string> keyValuePair = A92670B1;
			string key = keyValuePair.Key;
			keyValuePair = A92670B1;
			return key + "|" + keyValuePair.Value;
		}
	}

	private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	public static bool isSaveSettings = false;

	public static string smethod_0(string C823522A)
	{
		if (!isSaveSettings)
		{
			return "";
		}
		string result = "";
		if (dictionary_0.ContainsKey(C823522A))
		{
			result = dictionary_0[C823522A];
		}
		return result;
	}

	public static void B1176AAC(string F3B52937, string D71D248A)
	{
		if (isSaveSettings)
		{
			if (dictionary_0.ContainsKey(F3B52937))
			{
				dictionary_0[F3B52937] = D71D248A;
			}
			else
			{
				dictionary_0.Add(F3B52937, D71D248A);
			}
		}
	}

	public static void A08BDA39()
	{
		if (isSaveSettings)
		{
			DataTable source = CommonSQL.smethod_5();
			dictionary_0 = source.AsEnumerable().ToDictionary((DataRow dataRow_0) => dataRow_0[0].ToString(), (DataRow CD27D50A) => CD27D50A[1].ToString());
		}
	}

	public static void smethod_1()
	{
		if (isSaveSettings)
		{
			List<string> c595F6B = dictionary_0.Where(delegate(KeyValuePair<string, string> CD05B308)
			{
				KeyValuePair<string, string> keyValuePair2 = CD05B308;
				return keyValuePair2.Value.Trim() != "";
			}).Select(delegate(KeyValuePair<string, string> A92670B1)
			{
				KeyValuePair<string, string> keyValuePair = A92670B1;
				string key = keyValuePair.Key;
				keyValuePair = A92670B1;
				return key + "|" + keyValuePair.Value;
			}).ToList();
			CommonSQL.smethod_4("status", c595F6B);
		}
	}
}
