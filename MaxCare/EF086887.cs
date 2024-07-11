using System;
using Newtonsoft.Json.Linq;

public class EF086887
{
	private string string_0;

	private string B2BC3008;

	private string A2A2499A;

	private int B1BAD714;

	private string string_1;

	private string string_2;

	public EF086887(string string_3, string F40F22B8, string A7183C1E, int int_0)
	{
		string_0 = string_3;
		B2BC3008 = F40F22B8;
		A2A2499A = A7183C1E;
		B1BAD714 = int_0;
	}

	public string method_0(string string_3)
	{
		string json = Common.smethod_2(string_0, B2BC3008, A2A2499A, B1BAD714, string_3);
		try
		{
			JObject jObject = JObject.Parse(json);
			if (Convert.ToBoolean(jObject["success"]))
			{
				string_1 = jObject["url"].ToString();
				string_0 = jObject["cookie"].ToString();
				string_2 = jObject["response"].ToString();
				return string_2;
			}
			jObject["error"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public string CEA7950B(string string_3, string DF86971D = "")
	{
        //string json = Common.GetListHoVN(string_0, B2BC3008, A2A2499A, B1BAD714, string_3, DF86971D);
        string json = Common.smethod_3(string_0, B2BC3008, A2A2499A, B1BAD714, string_3, DF86971D);
        JObject jObject = JObject.Parse(json);
		if (Convert.ToBoolean(jObject["success"]))
		{
			string_1 = jObject["url"].ToString();
			string_0 = jObject["cookie"].ToString();
			string_2 = jObject["response"].ToString();
		}
		else
		{
			jObject["error"].ToString();
		}
		return string_2;
	}

	public string method_1(string string_3, string A4A1348A, string string_4)
	{
		string json = Common.EB828421(string_0, B2BC3008, A2A2499A, B1BAD714, string_3, A4A1348A, string_4);
		JObject jObject = JObject.Parse(json);
		if (Convert.ToBoolean(jObject["success"]))
		{
			string_1 = jObject["url"].ToString();
			string_0 = jObject["cookie"].ToString();
			string_2 = jObject["response"].ToString();
		}
		else
		{
			jObject["error"].ToString();
		}
		return string_2;
	}

	public string F22AE38F()
	{
		return string_0;
	}

	public string method_2()
	{
		return string_1;
	}
}
