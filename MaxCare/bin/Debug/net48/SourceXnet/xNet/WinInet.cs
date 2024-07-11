using System;
using System.IO;
using System.Security;
using Microsoft.Win32;

namespace xNet;

public static class WinInet
{
	private const string PathToInternetOptions = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";

	public static bool InternetConnected
	{
		get
		{
			SafeNativeMethods.InternetConnectionState lpdwFlags = (SafeNativeMethods.InternetConnectionState)0;
			return SafeNativeMethods.InternetGetConnectedState(ref lpdwFlags, 0);
		}
	}

	public static bool InternetThroughModem => EqualConnectedState(SafeNativeMethods.InternetConnectionState.INTERNET_CONNECTION_MODEM);

	public static bool InternetThroughLan => EqualConnectedState(SafeNativeMethods.InternetConnectionState.INTERNET_CONNECTION_LAN);

	public static bool InternetThroughProxy => EqualConnectedState(SafeNativeMethods.InternetConnectionState.INTERNET_CONNECTION_PROXY);

	public static bool IEProxyEnable
	{
		get
		{
			try
			{
				return GetIEProxyEnable();
			}
			catch (IOException)
			{
				return false;
			}
			catch (SecurityException)
			{
				return false;
			}
			catch (ObjectDisposedException)
			{
				return false;
			}
			catch (UnauthorizedAccessException)
			{
				return false;
			}
		}
		set
		{
			try
			{
				SetIEProxyEnable(value);
			}
			catch (IOException)
			{
			}
			catch (SecurityException)
			{
			}
			catch (ObjectDisposedException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
	}

	public static HttpProxyClient IEProxy
	{
		get
		{
			string iEProxy;
			try
			{
				iEProxy = GetIEProxy();
			}
			catch (IOException)
			{
				return null;
			}
			catch (SecurityException)
			{
				return null;
			}
			catch (ObjectDisposedException)
			{
				return null;
			}
			catch (UnauthorizedAccessException)
			{
				return null;
			}
			HttpProxyClient.TryParse(iEProxy, out var result);
			return result;
		}
		set
		{
			try
			{
				if (value != null)
				{
					SetIEProxy(value.ToString());
				}
				else
				{
					SetIEProxy(string.Empty);
				}
			}
			catch (SecurityException)
			{
			}
			catch (ObjectDisposedException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
	}

	public static bool GetIEProxyEnable()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
		object value = registryKey.GetValue("ProxyEnable");
		if (value == null)
		{
			return false;
		}
		return ((int)value != 0) ? true : false;
	}

	public static void SetIEProxyEnable(bool enabled)
	{
		using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
		registryKey.SetValue("ProxyEnable", enabled ? 1 : 0);
	}

	public static string GetIEProxy()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
		return (registryKey.GetValue("ProxyServer") as string) ?? string.Empty;
	}

	public static void SetIEProxy(string host, int port)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (host.Length == 0)
		{
			throw ExceptionHelper.EmptyString("host");
		}
		if (!ExceptionHelper.ValidateTcpPort(port))
		{
			throw ExceptionHelper.WrongTcpPort("port");
		}
		SetIEProxy(host + ":" + port);
	}

	public static void SetIEProxy(string hostAndPort)
	{
		using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
		registryKey.SetValue("ProxyServer", hostAndPort ?? string.Empty);
	}

	private static bool EqualConnectedState(SafeNativeMethods.InternetConnectionState expected)
	{
		SafeNativeMethods.InternetConnectionState lpdwFlags = (SafeNativeMethods.InternetConnectionState)0;
		SafeNativeMethods.InternetGetConnectedState(ref lpdwFlags, 0);
		return (lpdwFlags & expected) != 0;
	}
}
