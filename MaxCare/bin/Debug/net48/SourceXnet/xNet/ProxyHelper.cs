using System;

namespace xNet;

internal static class ProxyHelper
{
	public static ProxyClient CreateProxyClient(ProxyType proxyType, string host = null, int port = 0, string username = null, string password = null)
	{
		return proxyType switch
		{
			ProxyType.Http => (port == 0) ? new HttpProxyClient(host) : new HttpProxyClient(host, port, username, password), 
			ProxyType.Socks4 => (port == 0) ? new Socks4ProxyClient(host) : new Socks4ProxyClient(host, port, username), 
			ProxyType.Socks4a => (port == 0) ? new Socks4aProxyClient(host) : new Socks4aProxyClient(host, port, username), 
			ProxyType.Socks5 => (port == 0) ? new Socks5ProxyClient(host) : new Socks5ProxyClient(host, port, username, password), 
			_ => throw new InvalidOperationException(), 
		};
	}
}
