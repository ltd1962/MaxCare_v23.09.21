using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class GClass16
{
	public class GClass18 : GClass17
	{
		private string string_2;
	}

	public class GClass17
	{
		[Serializable]
		private sealed class Class55
		{
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public static readonly Class55 class55_0 = new Class55();

			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}
		}

		private string string_0;

		private string string_1;

		public string String_0
		{
			get
			{
				return string_0;
			}
			private set
			{
				string_0 = value;
			}
		}

		public string String_1
		{
			get
			{
				return string_1;
			}
			private set
			{
				string_1 = value;
			}
		}

		protected void method_0(string string_2, string string_3)
		{
			method_2(string_2, bool_0: false);
			method_2(string_3, bool_0: true);
		}

		protected void method_1()
		{
			String_1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(String_1));
		}

		private void method_2(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(String_1);
				foreach (char c in string_2)
				{
					switch (c)
					{
					default:
						stringBuilder.Append(c);
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '+':
						stringBuilder.Append("%2B");
						break;
					}
				}
				String_1 = stringBuilder.ToString();
			}
			else
			{
				String_1 += string_2;
			}
		}

		protected bool method_3(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			String_1 = Encoding.UTF8.GetString(byte_0, index, num);
			if (String_1[String_1.Length - 1] != '/')
			{
				String_1 += "/";
			}
			return true;
		}
	}

	public class GClass19 : GClass17
	{
	}

	private uint uint_0;

	private readonly int int_0;

	private GEnum0 genum0_0;

	private byte[] byte_0;

	private long long_0;

	private int int_1;

	private readonly object object_0;

	private readonly byte[] byte_1;

	public GClass16(byte[] byte_2)
	{
		new GClass7().method_5(new object[2] { this, byte_2 }, 297699);
	}

	public GClass16()
	{
		new GClass7().method_5(new object[1] { this }, 25274);
	}
}
