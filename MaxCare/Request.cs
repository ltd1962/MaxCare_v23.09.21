using System;
using System.Linq;
using xNet;


public class Request
{
    private xNet.HttpRequest request;

    public Request(string cookie = "", string userAgent = "", string proxy = "", int typeProxy = 0)
    {
        if (userAgent == "")
        {
            userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
        }
        request = new xNet.HttpRequest
        {
            KeepAlive = true,
            AllowAutoRedirect = true,
            Cookies = new CookieDictionary(),
            UserAgent = userAgent
        };
        request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
        request.AddHeader("Accept-Language", "en-US,en;q=0.9");
        if (cookie != "")
        {
            AddCookie(cookie);
        }
        if (!(proxy != ""))
        {
            return;
        }
        switch (proxy.Split(':').Count())
        {
            case 1:
                request.Proxy = Socks5ProxyClient.Parse("127.0.0.1:" + proxy);
                break;
            case 2:
                if (typeProxy == 0)
                {
                    request.Proxy = HttpProxyClient.Parse(proxy);
                }
                else
                {
                    request.Proxy = Socks5ProxyClient.Parse(proxy);
                }
                break;
            case 4:
                request.Proxy = new HttpProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
                break;
            case 3:
                break;
        }
    }

    public void AddProxy(string proxy)
    {
        string[] array = proxy.Split(':');
        if (array.Length > 2)
        {
            Socks5ProxyClient socks5ProxyClient = Socks5ProxyClient.Parse(array[0] + ":" + array[1]);
            socks5ProxyClient.Username = array[2].ToString();
            socks5ProxyClient.Password = array[3].ToString();
            request.Proxy = socks5ProxyClient;
        }
        else
        {
            HttpProxyClient proxy2 = HttpProxyClient.Parse(array[0] + ":" + array[1]);
            request.Proxy = proxy2;
        }
    }

    public string RequestGet(string url)
    {
        try
        {
            return request.Get(url).ToString();
        }
        catch
        {
            return null;
        }
    }

    public byte[] GetBytes(string url)
    {
        return request.Get(url).ToBytes();
    }

    public string RequestPost(string url, string data = "", string contentType = "application/x-www-form-urlencoded")
    {
        if (data == "" || contentType == "")
        {
            return request.Post(url).ToString();
        }
        return request.Post(url, data, contentType).ToString();
    }

    public string UpLoad(string url, MultipartContent data = null)
    {
        return request.Post(url, data).ToString();
    }

    public void AddCookie(string cookie)
    {
        string[] array = cookie.Split(';');
        string[] array2 = array;
        string[] array3 = array2;
        foreach (string text in array3)
        {
            string[] array4 = text.Split('=');
            if (array4.Count() > 1)
            {
                try
                {
                    request.Cookies.Add(array4[0], array4[1]);
                }
                catch
                {
                }
            }
        }
    }

    public void AddFile(string name, string path)
    {
        request.AddFile(name, path);
    }

    public bool DownLoad(string url, string path)
    {
        try
        {
            request.Get(url).ToFile(path);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public string GetCookie()
    {
        return request.Cookies.ToString();
    }

    public string Uri()
    {
        return request.Address.AbsoluteUri;
    }

    public void AddParam(string name, string value)
    {
        request.AddParam(name, value);
    }

    public void AddHeader(string name, string value)
    {
        request.AddHeader(name, value);
    }

    public void userAgent(string useragent)
    {
        request.UserAgent = useragent;
    }

    public string RequestPut(string url, string data = "")
    {
        if (data == "")
        {
            return request.Raw(HttpMethod.PUT, url).ToString();
        }
        HttpContent content = new StringContent(data);
        return request.Raw(HttpMethod.PUT, url, content).ToString();
    }
}

