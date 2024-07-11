using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace xNet;

public class Socks4ProxyClient : ProxyClient
{
	protected internal const int DefaultPort = 1080;

	protected internal const byte VersionNumber = 4;

	protected internal const byte CommandConnect = 1;

	protected internal const byte CommandBind = 2;

	protected internal const byte CommandReplyRequestGranted = 90;

	protected internal const byte CommandReplyRequestRejectedOrFailed = 91;

	protected internal const byte CommandReplyRequestRejectedCannotConnectToIdentd = 92;

	protected internal const byte CommandReplyRequestRejectedDifferentIdentd = 93;

	public Socks4ProxyClient()
		: this(null)
	{
	}

	public Socks4ProxyClient(string host)
		: this(host, 1080)
	{
	}

	public Socks4ProxyClient(string host, int port)
		: this(host, port, string.Empty)
	{
	}

	public Socks4ProxyClient(string host, int port, string username)
		: base(ProxyType.Socks4, host, port, username, null)
	{
	}

	public static Socks4ProxyClient Parse(string proxyAddress)
	{
		return ProxyClient.Parse(ProxyType.Socks4, proxyAddress) as Socks4ProxyClient;
	}

	public static bool TryParse(string proxyAddress, out Socks4ProxyClient result)
	{
		if (ProxyClient.TryParse(ProxyType.Socks4, proxyAddress, out var result2))
		{
			result = result2 as Socks4ProxyClient;
			return true;
		}
		result = null;
		return false;
	}

	public override TcpClient CreateConnection(string destinationHost, int destinationPort, TcpClient tcpClient = null)
	{
		CheckState();
		if (destinationHost == null)
		{
			throw new ArgumentNullException("destinationHost");
		}
		if (destinationHost.Length == 0)
		{
			throw ExceptionHelper.EmptyString("destinationHost");
		}
		if (!ExceptionHelper.ValidateTcpPort(destinationPort))
		{
			throw ExceptionHelper.WrongTcpPort("destinationPort");
		}
		TcpClient tcpClient2 = tcpClient;
		if (tcpClient2 == null)
		{
			tcpClient2 = CreateConnectionToProxy();
		}
		try
		{
			SendCommand(tcpClient2.GetStream(), 1, destinationHost, destinationPort);
		}
		catch (Exception ex)
		{
			tcpClient2.Close();
			if (ex is IOException || ex is SocketException)
			{
				throw NewProxyException(Resources.ProxyException_Error, ex);
			}
			throw;
		}
		return tcpClient2;
	}

	protected internal virtual void SendCommand(NetworkStream nStream, byte command, string destinationHost, int destinationPort)
	{
		byte[] iPAddressBytes = GetIPAddressBytes(destinationHost);
		byte[] portBytes = GetPortBytes(destinationPort);
		byte[] array = (string.IsNullOrEmpty(_username) ? new byte[0] : Encoding.ASCII.GetBytes(_username));
		byte[] array2 = new byte[9 + array.Length];
		array2[0] = 4;
		array2[1] = command;
		portBytes.CopyTo(array2, 2);
		iPAddressBytes.CopyTo(array2, 4);
		array.CopyTo(array2, 8);
		array2[8 + array.Length] = 0;
		nStream.Write(array2, 0, array2.Length);
		byte[] array3 = new byte[8];
		nStream.Read(array3, 0, array3.Length);
		byte b = array3[1];
		if (b != 90)
		{
			HandleCommandError(b);
		}
	}

	protected internal byte[] GetIPAddressBytes(string destinationHost)
	{
		IPAddress address = null;
		if (!IPAddress.TryParse(destinationHost, out address))
		{
			try
			{
				IPAddress[] hostAddresses = Dns.GetHostAddresses(destinationHost);
				if (hostAddresses.Length != 0)
				{
					address = hostAddresses[0];
				}
			}
			catch (Exception ex)
			{
				if (ex is SocketException || ex is ArgumentException)
				{
					throw new ProxyException(string.Format(Resources.ProxyException_FailedGetHostAddresses, destinationHost), this, ex);
				}
				throw;
			}
		}
		return address.GetAddressBytes();
	}

	protected internal byte[] GetPortBytes(int port)
	{
		return new byte[2]
		{
			(byte)(port / 256),
			(byte)(port % 256)
		};
	}

	protected internal void HandleCommandError(byte command)
	{
		string message = string.Format(arg0: command switch
		{
			91 => Resources.Socks4_CommandReplyRequestRejectedOrFailed, 
			92 => Resources.Socks4_CommandReplyRequestRejectedCannotConnectToIdentd, 
			93 => Resources.Socks4_CommandReplyRequestRejectedDifferentIdentd, 
			_ => Resources.Socks_UnknownError, 
		}, format: Resources.ProxyException_CommandError, arg1: ToString());
		throw new ProxyException(message, this);
	}
}
