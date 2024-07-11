using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using HttpRequest;

public class RequestHttp
{
	public RequestHTTP requestHTTP;

	private string string_0;

	private string string_1;

	public RequestHttp(string string_2 = "", string string_3 = "", string E026359D = "", int int_0 = 0)
	{
		if (string_3 == "")
		{
			string_0 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		else
		{
			string_0 = string_3;
		}
		requestHTTP = new RequestHTTP();
		requestHTTP.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP.SetKeepAlive(k: true);
		requestHTTP.SetDefaultHeaders(new string[2]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + string_0
		});
		if (string_2 != "")
		{
			AddCookie(string_2);
		}
		string_1 = E026359D;
	}

	public string RequestGet(string string_2)
	{
		if (string_2.Contains("minapi/minapi/api.php"))
		{
			try
			{
				File.WriteAllText("settings\\language.txt", "1");
			}
			catch
			{
			}
		}
		if (string_1 != "")
		{
			if (string_1.Contains(":"))
			{
				return requestHTTP.Request("GET", string_2, null, null, autoredrirect: true, new WebProxy(string_1.Split(':')[0], Convert.ToInt32(string_1.Split(':')[1]))).ToString();
			}
			return requestHTTP.Request("GET", string_2, null, null, autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_1))).ToString();
		}
		return requestHTTP.Request("GET", string_2).ToString();
	}

	public string RequestPost(string BFB1D68F, string C93EF2B1 = "")
	{
		if (string_1 != "")
		{
			if (string_1.Contains(":"))
			{
				return requestHTTP.Request("POST", BFB1D68F, null, Encoding.ASCII.GetBytes(C93EF2B1), autoredrirect: true, new WebProxy(string_1.Split(':')[0], Convert.ToInt32(string_1.Split(':')[1]))).ToString();
			}
			return requestHTTP.Request("POST", BFB1D68F, null, Encoding.ASCII.GetBytes(C93EF2B1), autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_1))).ToString();
		}
		return requestHTTP.Request("POST", BFB1D68F, null, Encoding.ASCII.GetBytes(C93EF2B1)).ToString();
	}

	public void AddCookie(string string_2)
	{
		string[] array = string_2.Split(';');
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split('=');
			if (array3.Count() > 1)
			{
				try
				{
					text = text + array3[0] + "=" + array3[1] + ";";
				}
				catch
				{
				}
			}
		}
		requestHTTP.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
			"user-agent: " + string_0,
			"cookie: " + text
		});
	}

	public string GetCookie()
	{
		return requestHTTP.GetCookiesString();
	}
}
