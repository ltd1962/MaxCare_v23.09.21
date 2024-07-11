using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

public class JSON_Settings
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A035B98B
	{
		public static readonly A035B98B _003C_003E9 = new A035B98B();

		public static Func<KeyValuePair<string, object>, global::B8A27D05<KeyValuePair<string, object>, string>> _003C_003E9__3_0;

		public static Func<global::B8A27D05<KeyValuePair<string, object>, string>, global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>> _003C_003E9__3_1;

		public static Func<global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>, bool> _003C_003E9__3_2;

		public static Func<global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>, string> _003C_003E9__3_3;

		public static Func<KeyValuePair<string, object>, global::B8A27D05<KeyValuePair<string, object>, string>> _003C_003E9__3_4;

		public static Func<global::B8A27D05<KeyValuePair<string, object>, string>, global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>> _003C_003E9__3_5;

		public static Func<global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>, bool> _003C_003E9__3_6;

		public static Func<global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>, string> _003C_003E9__3_7;

		public static Func<JToken, object> _003C_003E9__3_10;

		internal global::B8A27D05<KeyValuePair<string, object>, string> method_0(KeyValuePair<string, object> keyValuePair_0)
		{
			KeyValuePair<string, object> keyValuePair = keyValuePair_0;
			return new global::B8A27D05<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
		}

		internal global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object> method_1(global::B8A27D05<KeyValuePair<string, object>, string> AA880BB0)
		{
			return new global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>(AA880BB0, AA880BB0.Prop_0.Value);
		}

		internal bool method_2(global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object> AF3E23A8)
		{
			return AF3E23A8.Prop_1.GetType() == typeof(JObject);
		}

		internal string C9124920(global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object> A215423B)
		{
			return A215423B.Prop_0.Prop_1;
		}

		internal global::B8A27D05<KeyValuePair<string, object>, string> method_3(KeyValuePair<string, object> A3920CA8)
		{
			KeyValuePair<string, object> keyValuePair = A3920CA8;
			return new global::B8A27D05<KeyValuePair<string, object>, string>(A3920CA8, keyValuePair.Key);
		}

		internal global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object> method_4(global::B8A27D05<KeyValuePair<string, object>, string> FA13F4AE)
		{
			return new global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>(FA13F4AE, FA13F4AE.Prop_0.Value);
		}

		internal bool method_5(global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object> E9285898)
		{
			return E9285898.Prop_1.GetType() == typeof(JArray);
		}

		internal string method_6(global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object> A31D4AA9)
		{
			return A31D4AA9.Prop_0.Prop_1;
		}

		internal object method_7(JToken jtoken_0)
		{
			return ((JValue)jtoken_0).Value;
		}
	}

	[CompilerGenerated]
	private sealed class AD8D6383
	{
		public Dictionary<string, object> dictionary_0;

		public JSON_Settings gclass8_0;

		internal void method_0(string AD02E221)
		{
			dictionary_0[AD02E221] = (from jtoken_0 in ((JArray)dictionary_0[AD02E221]).Values()
				select ((JValue)jtoken_0).Value).ToArray();
		}

		internal void method_1(string AA250BAA)
		{
			dictionary_0[AA250BAA] = gclass8_0.FF9F3A87(dictionary_0[AA250BAA] as JObject);
		}
	}

	private string E2235E2D;

	private JObject json;

	public JSON_Settings(string string_0, bool BE9E4429 = false)
	{
		if (BE9E4429)
		{
			if (string_0.Trim() == "")
			{
				string_0 = "{}";
			}
			json = JObject.Parse(string_0);
			return;
		}
		try
		{
			E2235E2D = "settings\\" + string_0 + ".json";
			if (!File.Exists(E2235E2D))
			{
				using (File.AppendText(E2235E2D))
				{
				}
			}
			json = JObject.Parse(File.ReadAllText(E2235E2D));
		}
		catch
		{
			json = new JObject();
		}
	}

	public Dictionary<string, object> FF9F3A87(JObject E91F719F = null)
	{
		Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();
		try
		{
			if (E91F719F == null)
			{
				E91F719F = json;
			}
			dictionary_0 = E91F719F.ToObject<Dictionary<string, object>>();
			List<string> list = (from AA880BB0 in dictionary_0.Select(delegate(KeyValuePair<string, object> keyValuePair_0)
				{
					KeyValuePair<string, object> keyValuePair2 = keyValuePair_0;
					return new global::B8A27D05<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair2.Key);
				})
				select new global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>(AA880BB0, AA880BB0.Prop_0.Value) into AF3E23A8
				where AF3E23A8.Prop_1.GetType() == typeof(JObject)
				select AF3E23A8 into A215423B
				select A215423B.Prop_0.Prop_1).ToList();
			List<string> list2 = (from FA13F4AE in dictionary_0.Select(delegate(KeyValuePair<string, object> A3920CA8)
				{
					KeyValuePair<string, object> keyValuePair = A3920CA8;
					return new global::B8A27D05<KeyValuePair<string, object>, string>(A3920CA8, keyValuePair.Key);
				})
				select new global::A00CC422<global::B8A27D05<KeyValuePair<string, object>, string>, object>(FA13F4AE, FA13F4AE.Prop_0.Value) into E9285898
				where E9285898.Prop_1.GetType() == typeof(JArray)
				select E9285898 into A31D4AA9
				select A31D4AA9.Prop_0.Prop_1).ToList();
			list2.ForEach(delegate(string AD02E221)
			{
				dictionary_0[AD02E221] = (from jtoken_0 in ((JArray)dictionary_0[AD02E221]).Values()
					select ((JValue)jtoken_0).Value).ToArray();
			});
			list.ForEach(delegate(string AA250BAA)
			{
				dictionary_0[AA250BAA] = FF9F3A87(dictionary_0[AA250BAA] as JObject);
			});
		}
		catch
		{
		}
		return dictionary_0;
	}

	public JSON_Settings()
	{
		json = new JObject();
	}

	public string GetValue(string string_0, string A22EE51B = "")
	{
		string result = A22EE51B;
		try
		{
			result = ((json[string_0] == null) ? A22EE51B : json[string_0].ToString());
		}
		catch
		{
		}
		return result;
	}

	public bool method_1(string B128230D)
	{
		return json.ContainsKey(B128230D);
	}

	public List<string> GetValueList(string string_0, int D2824A15 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			list = ((D2824A15 != 0) ? GetValue(string_0).Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : GetValue(string_0).Split('\n').ToList());
			list = Common.RemoveEmptyItems(list);
		}
		catch
		{
		}
		return list;
	}

	public int GetValueInt(string string_0, int int_0 = 0)
	{
		int result = int_0;
		try
		{
			result = ((json[string_0] == null) ? int_0 : Convert.ToInt32(json[string_0].ToString()));
		}
		catch
		{
		}
		return result;
	}

	public bool GetValueBool(string C281739F, bool bool_0 = false)
	{
		bool result = bool_0;
		try
		{
			result = ((json[C281739F] == null) ? bool_0 : Convert.ToBoolean(json[C281739F].ToString()));
		}
		catch
		{
		}
		return result;
	}

	public void method_3(string string_0, string C9AE6D14)
	{
		try
		{
			if (!json.ContainsKey(string_0))
			{
				json.Add(string_0, C9AE6D14);
			}
			else
			{
				json[string_0] = C9AE6D14;
			}
		}
		catch (Exception)
		{
		}
	}

	public void GetJson(string EF0D8002, object object_0)
	{
		try
		{
			json[EF0D8002] = object_0.ToString();
		}
		catch
		{
		}
	}

	public void method_5(string string_0, List<string> list_0)
	{
		try
		{
			bool flag = false;
			foreach (string item in list_0)
			{
				if (item.Contains("\n"))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				json[string_0] = string.Join("\n|\n", list_0).ToString();
			}
			else
			{
				json[string_0] = string.Join("\n", list_0).ToString();
			}
		}
		catch
		{
		}
	}

	public void method_6(string string_0)
	{
		try
		{
			json.Remove(string_0);
		}
		catch
		{
		}
	}

	public void method_7(string string_0 = "")
	{
		try
		{
			if (string_0 == "")
			{
				string_0 = E2235E2D;
			}
			File.WriteAllText(string_0, json.ToString());
		}
		catch
		{
		}
	}

	public string D9A09B34()
	{
		string result = "";
		try
		{
			result = json.ToString().Replace("\r\n", "");
		}
		catch (Exception)
		{
		}
		return result;
	}
}
