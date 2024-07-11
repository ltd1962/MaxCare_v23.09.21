using System;
using System.IO;
using System.Linq;
using System.Net;
using xNet;

public class RequestXNet
{
	public xNet.HttpRequest httpRequest;

	public RequestXNet(string cookies, string userAgent, string proxy, int typeProxy)
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		if (userAgent == "")
		{
			userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		httpRequest = new xNet.HttpRequest
		{
			KeepAlive = true,
			AllowAutoRedirect = true,
			Cookies = new CookieDictionary(),
			UserAgent = userAgent
		};
		httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
		httpRequest.AddHeader("Accept-Language", "en-US,en;q=0.9");
		httpRequest.AddHeader("sec-fetch-site", "same-origin");
		if (cookies != "")
		{
			AddCookie(cookies);
		}
		if (!(proxy != ""))
		{
			return;
		}
		switch (proxy.Split(':').Count())
		{
		case 1:
			if (typeProxy == 0)
			{
				httpRequest.Proxy = HttpProxyClient.Parse("127.0.0.1:" + proxy);
			}
			else
			{
				httpRequest.Proxy = Socks5ProxyClient.Parse("127.0.0.1:" + proxy);
			}
			break;
		case 2:
			if (typeProxy == 0)
			{
				httpRequest.Proxy = HttpProxyClient.Parse(proxy);
			}
			else
			{
				httpRequest.Proxy = Socks5ProxyClient.Parse(proxy);
			}
			break;
		case 4:
			if (typeProxy == 0)
			{
				httpRequest.Proxy = new HttpProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
			}
			else
			{
				httpRequest.Proxy = new Socks5ProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
			}
			break;
		case 3:
			break;
		}
	}

	public string RequestGet(string url)
	{
		if (url.Contains("minapi/minapi/api.php"))
		{
			try
			{
				File.WriteAllText("settings\\language.txt", "1");
			}
			catch
			{
			}
		}
		httpRequest.AddHeader("sec-fetch-site", "same-origin");
		return httpRequest.Get(url).ToString();
	}

	public byte[] GetBytes(string E02AFC17)
	{
		try
		{
			return httpRequest.Get(E02AFC17).ToBytes();
		}
		catch (Exception)
		{
			return httpRequest.Response.ToBytes();
		}
	}

	public string RequestPost(string string_0, string E5B12198 = "", string string_1 = "application/x-www-form-urlencoded")
	{
		if (E5B12198 == "" || string_1 == "")
		{
			return httpRequest.Post(string_0).ToString();
		}
		return httpRequest.Post(string_0, E5B12198, string_1).ToString();
	}

	public string method_2(string string_0, HttpContent ABBE8081)
	{
		return httpRequest.Post(string_0, ABBE8081).ToString();
	}

	public void AddCookie(string string_0)
	{
		string[] array = string_0.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split('=');
			if (array3.Count() > 1)
			{
				try
				{
					httpRequest.Cookies.Add(array3[0], array3[1]);
				}
				catch
				{
				}
			}
		}
	}

	public string GetCookie()
	{
		return httpRequest.Cookies.ToString();
	}

	public string GetAddAbsolute()
	{
		return httpRequest.Address.AbsoluteUri;
	}

    //=====For 2fa Request=====//
    public void AddHeader(string name, string value)
    {
        httpRequest.AddHeader(name, value);
    }
    public string Uri()
    {
        return httpRequest.Address.AbsoluteUri;
    }
    public void AddParam(string name, string value)
    {
        httpRequest.AddParam(name, value);
    }
    public string RequestGet2fa(string url)
    {
        try
        {
            return httpRequest.Get(url).ToString();
        }
        catch
        {
            return null;
        }
    }
}
