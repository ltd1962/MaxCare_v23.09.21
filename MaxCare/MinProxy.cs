using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class MinProxy : GClass3
{
	[CompilerGenerated]
	private sealed class Class11
	{
		public string C20191AF;

		internal Task<string> method_0()
		{
			return F2B1B43F(new Uri(C20191AF));
		}
	}

	[CompilerGenerated]
	private sealed class A90CA605 : IAsyncStateMachine
	{
		public int B489120D;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public Uri E3104E0A;

		private string string_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage B21128BB;

		private HttpResponseMessage F81E04A9;

		private string BB83329E;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		void IAsyncStateMachine.MoveNext()
		{
			int num = B489120D;
			string result;
			try
			{
				if ((uint)num > 1u)
				{
					string_0 = string.Empty;
					httpClient_0 = new HttpClient();
				}
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<string>);
							num = -1;
							B489120D = -1;
							goto IL_0121;
						}
						awaiter2 = httpClient_0.GetAsync(E3104E0A).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							B489120D = 0;
							taskAwaiter_0 = awaiter2;
							A90CA605 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						B489120D = -1;
					}
					F81E04A9 = awaiter2.GetResult();
					B21128BB = F81E04A9;
					F81E04A9 = null;
					if (B21128BB.IsSuccessStatusCode)
					{
						awaiter = B21128BB.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							B489120D = 1;
							taskAwaiter_1 = awaiter;
							A90CA605 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0121;
					}
					goto IL_0141;
					IL_0121:
					BB83329E = awaiter.GetResult();
					string_0 = BB83329E;
					BB83329E = null;
					goto IL_0141;
					IL_0141:
					B21128BB = null;
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
				httpClient_0 = null;
				result = string_0;
			}
			catch (Exception exception)
			{
				B489120D = -2;
				string_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			B489120D = -2;
			string_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine F13285A8)
		{
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int D98ECCA9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string B6AE22B1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string CE02EB08;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string DE1116BC;

	private object object_0 = new object();

	private object object_1 = new object();

	private int int_4 = 0;

	public int int_5 = 0;

	public int F888B48E = 0;

	public int F939E28A = 3;

	public bool bool_0 = true;

	public int CA9EC50D
	{
		[CompilerGenerated]
		get
		{
			return D98ECCA9;
		}
		[CompilerGenerated]
		set
		{
			D98ECCA9 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string F3003736
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return B6AE22B1;
		}
		[CompilerGenerated]
		set
		{
			B6AE22B1 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return CE02EB08;
		}
		[CompilerGenerated]
		set
		{
			CE02EB08 = value;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return DE1116BC;
		}
		[CompilerGenerated]
		set
		{
			DE1116BC = value;
		}
	}

	public MinProxy(int A39BE124, string string_2, int DC141505, int int_6)
	{
		CA9EC50D = A39BE124;
		String_0 = string_2;
		F3003736 = "";
		String_1 = "";
		Int32_2 = 0;
		Int32_3 = 0;
		Int32_0 = DC141505;
		F939E28A = int_6;
		int_4 = 0;
		int_5 = 0;
		F888B48E = 0;
		String_2 = "";
		String_3 = "";
	}

	public static bool BF3F4BB9(int int_6, string string_2)
	{
		string text = "";
		text = ((int_6 != 0) ? smethod_0("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-status?api_key=" + string_2) : smethod_0("http://dash.minproxy.vn/api/rotating/v1/proxy/get-status?api_key=" + string_2));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"].ToString() == "1")
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_0()
	{
		lock (object_0)
		{
			if (int_5 == 0)
			{
				if (F888B48E > 0 && F888B48E < F939E28A)
				{
					if (C9181DB1() < 30 && method_2() != 1)
					{
						return "0";
					}
				}
				else if (method_2() != 1)
				{
					return "0";
				}
			}
			else
			{
				if (F888B48E >= F939E28A)
				{
					return "2";
				}
				if (C9181DB1() < 30 && method_2() != 1)
				{
					return "0";
				}
			}
			F888B48E++;
			int_5++;
			return "1";
		}
	}

	public int C9181DB1()
	{
		D2A6FBB6();
		return Int32_1;
	}

	public void method_1()
	{
		lock (object_1)
		{
			int_5--;
			if (int_5 == 0 && F888B48E == F939E28A)
			{
				bool_0 = true;
				F888B48E = 0;
			}
		}
	}

	public int method_2()
	{
		F3003736 = "";
		String_1 = "";
		Int32_2 = 0;
		string text = "";
		text = ((CA9EC50D != 0) ? smethod_0("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-new-proxy?api_key=" + String_0) : smethod_0("http://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + String_0));
		if (text != "")
		{
			if (text.Contains("api expired"))
			{
				return -1;
			}
			if (text.Contains("api wrong") || text.Contains("error"))
			{
				return -2;
			}
			try
			{
				JObject jObject = JObject.Parse(text);
				string value = Regex.Match(jObject["data"]["next_request"].ToString(), "\\d+").Value;
				Int32_3 = ((!(value == "")) ? int.Parse(value) : 0);
				if (jObject["code"].ToString() == "2")
				{
					String_2 = jObject["data"]["ip_allow"].ToString();
					String_3 = jObject["data"]["your_ip"].ToString();
					if (CA9EC50D == 0)
					{
						F3003736 = jObject["data"]["http_proxy"].ToString();
						string[] array = F3003736.Split(':');
						String_1 = array[0];
						Int32_2 = int.Parse(array[1]);
						return 1;
					}
					if (CA9EC50D == 1)
					{
						if (Int32_0 == 0)
						{
							F3003736 = jObject["data"]["http_proxy_ipv4"].ToString();
							string[] array2 = F3003736.Split(':');
							String_1 = array2[0];
							Int32_2 = int.Parse(array2[1]);
						}
						else if (Int32_0 == 1)
						{
							F3003736 = jObject["data"]["http_proxy_ipv6"].ToString();
							string[] array3 = F3003736.Split(':');
							String_1 = array3[0];
							Int32_2 = int.Parse(array3[1]);
						}
						else if (Int32_0 == 2)
						{
							F3003736 = jObject["data"]["sock_proxy_ipv4"].ToString();
							string[] array4 = F3003736.Split(':');
							String_1 = array4[0];
							Int32_2 = int.Parse(array4[1]);
						}
						else
						{
							F3003736 = jObject["data"]["sock_proxy_ipv6"].ToString();
							string[] array5 = F3003736.Split(':');
							String_1 = array5[0];
							Int32_2 = int.Parse(array5[1]);
						}
						return 1;
					}
				}
				return 0;
			}
			catch
			{
			}
		}
		Int32_3 = 0;
		return 0;
	}

	public bool D2A6FBB6()
	{
		Int32_3 = 0;
		F3003736 = "";
		String_1 = "";
		Int32_2 = 0;
		Int32_1 = 0;
		string text = "";
		text = ((CA9EC50D != 0) ? smethod_0("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-current-proxy?api_key=" + String_0) : smethod_0("http://dash.minproxy.vn/api/rotating/v1/proxy/get-current-proxy?api_key=" + String_0));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"].ToString() == "1")
				{
					Int32_3 = Convert.ToInt32(jObject["data"]["next_request"].ToString());
					Int32_1 = Convert.ToInt32(jObject["data"]["timeout"].ToString());
					String_2 = jObject["data"]["ip_allow"].ToString();
					String_3 = jObject["data"]["your_ip"].ToString();
					if (CA9EC50D == 0)
					{
						F3003736 = jObject["data"]["http_proxy"].ToString();
						string[] array = F3003736.Split(':');
						String_1 = array[0];
						Int32_2 = int.Parse(array[1]);
						return true;
					}
					if (CA9EC50D == 1)
					{
						if (Int32_0 == 0)
						{
							F3003736 = jObject["data"]["http_proxy_ipv4"].ToString();
							string[] array2 = F3003736.Split(':');
							String_1 = array2[0];
							Int32_2 = int.Parse(array2[1]);
						}
						else if (Int32_0 == 1)
						{
							F3003736 = jObject["data"]["http_proxy_ipv6"].ToString();
							string[] array3 = F3003736.Split(':');
							String_1 = array3[0];
							Int32_2 = int.Parse(array3[1]);
						}
						else if (Int32_0 == 2)
						{
							F3003736 = jObject["data"]["sock_proxy_ipv4"].ToString();
							string[] array4 = F3003736.Split(':');
							String_1 = array4[0];
							Int32_2 = int.Parse(array4[1]);
						}
						else
						{
							F3003736 = jObject["data"]["sock_proxy_ipv6"].ToString();
							string[] array5 = F3003736.Split(':');
							String_1 = array5[0];
							Int32_2 = int.Parse(array5[1]);
						}
						return true;
					}
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string D4B8F42D()
	{
		while (!D2A6FBB6())
		{
		}
		return F3003736;
	}

	public static string smethod_0(string string_2)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => F2B1B43F(new Uri(string_2)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request get");
			return "";
		}
	}

	[AsyncStateMachine(typeof(A90CA605))]
	[DebuggerStepThrough]
	private static Task<string> F2B1B43F(Uri uri_0)
	{
		A90CA605 stateMachine = new A90CA605();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.E3104E0A = uri_0;
		stateMachine.B489120D = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}
}
