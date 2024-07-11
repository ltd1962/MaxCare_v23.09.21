using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class OBCProxy
{
	private string string_0 = "";

	private string string_1 = "";

	private string A602E5AC = "";

	private List<OBCProxyv2> B50A86B0;

	public OBCProxy(string string_2)
	{
		A602E5AC = string_2;
		B50A86B0 = new List<OBCProxyv2>();
	}

	public string method_0()
	{
		return A602E5AC;
	}

	public void DC37D601(OBCProxyv2 B91433AE)
	{
		string_0 = B91433AE.method_3();
		string_1 = B91433AE.BB2329B6();
		B50A86B0.Add(B91433AE);
	}

	public List<OBCProxyv2> method_1()
	{
		return B50A86B0;
	}

	public List<OBCProxyv2> BD05969B()
	{
		List<OBCProxyv2> list = new List<OBCProxyv2>();
		for (int i = 0; i < B50A86B0.Count; i++)
		{
			OBCProxyv2 b = B50A86B0[i];
			if (b.bool_0 && b.int_1 < b.A239012F)
			{
				list.Add(b);
			}
		}
		return list;
	}

	public bool resetOBCProxy()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string aDBFD1B = string_0.TrimEnd('/') + "/reset?proxy=" + string_1 + "&type=deep";
			RequestXNet fB87CFA = new RequestXNet("", "", "", 0);
			string json = fB87CFA.RequestGet(aDBFD1B);
			JObject jObject = JObject.Parse(json);
			if (jObject.ContainsKey("msg") && (JObject.Parse(json)["msg"].ToString() == "command_sent" || JObject.Parse(json)["msg"].ToString() == "OK" || JObject.Parse(json)["msg"].ToString().ToLower() == "ok"))
			{
				result = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(json)["error_code"].ToString().ToLower() == "0")
			{
				result = true;
			}
		}
		catch
		{
		}
		foreach (OBCProxyv2 item in B50A86B0)
		{
			item.int_1 = 0;
		}
		return result;
	}

	public bool method_3()
	{
		int num = 0;
		while (true)
		{
			if (num < B50A86B0.Count)
			{
				OBCProxyv2 b = B50A86B0[num];
				if (b.bool_0 && (b.int_1 != b.A239012F || b.FDB04602 != 0))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static Dictionary<string, List<string>> CF83EB05(string string_2)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			string_2 = string_2.TrimEnd('/') + "/api/v1/dongles/all";
			string text = new RequestXNet("", "", "", 0).RequestGet(string_2);
			text = "{data:" + text + "}";
			JObject jObject = JObject.Parse(text);
			foreach (JToken item2 in (IEnumerable<JToken>)jObject["data"])
			{
				string key = item2["rootId"].ToString();
				string item = item2["httpPortV6"].ToString();
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, new List<string>());
				}
				dictionary[key].Add(item);
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	public static OBCProxy smethod_0(List<OBCProxy> list_0, string string_2)
	{
		OBCProxy result = null;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].method_0() == string_2)
			{
				result = list_0[i];
				break;
			}
		}
		return result;
	}
}
