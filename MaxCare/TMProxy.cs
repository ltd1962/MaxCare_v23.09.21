using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class TMProxy : GClass3
{
	[CompilerGenerated]
	private sealed class Class21
	{
		public string string_0;
	}

	[CompilerGenerated]
	private sealed class Class22
	{
		public HttpContent httpContent_0;

		public Class21 class21_0;

		internal Task<string> F082163F()
		{
			return E9B9A51A(new Uri(class21_0.string_0), httpContent_0);
		}
	}

	[CompilerGenerated]
	private sealed class F5233BA4
	{
		public string string_0;

		internal Task<string> method_0()
		{
			return smethod_1(new Uri(string_0));
		}
	}

	[CompilerGenerated]
	private sealed class EA0DF538 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public Uri F48272BE;

		private string E7070B2D;

		private HttpClient httpClient_0;

		private HttpResponseMessage C52C2B31;

		private HttpResponseMessage httpResponseMessage_0;

		private string string_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> C0A315A0;

		private void DB353AB5()
		{
			int num = int_0;
			string e7070B2D;
			try
			{
				if ((uint)num > 1u)
				{
					E7070B2D = string.Empty;
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
							awaiter = C0A315A0;
							C0A315A0 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0121;
						}
						awaiter2 = httpClient_0.GetAsync(F48272BE).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							EA0DF538 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					httpResponseMessage_0 = awaiter2.GetResult();
					C52C2B31 = httpResponseMessage_0;
					httpResponseMessage_0 = null;
					if (C52C2B31.IsSuccessStatusCode)
					{
						awaiter = C52C2B31.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							C0A315A0 = awaiter;
							EA0DF538 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0121;
					}
					goto IL_0141;
					IL_0121:
					string_0 = awaiter.GetResult();
					E7070B2D = string_0;
					string_0 = null;
					goto IL_0141;
					IL_0141:
					C52C2B31 = null;
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
				httpClient_0 = null;
				e7070B2D = E7070B2D;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				E7070B2D = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			E7070B2D = null;
			asyncTaskMethodBuilder_0.SetResult(e7070B2D);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in DB353AB5
			this.DB353AB5();
		}

		[DebuggerHidden]
		private void D2B33A3A(IAsyncStateMachine E8879291)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine E8879291)
		{
			//ILSpy generated this explicit interface implementation from .override directive in D2B33A3A
			this.D2B33A3A(E8879291);
		}
	}

	[CompilerGenerated]
	private sealed class E398C408 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public Uri uri_0;

		public HttpContent httpContent_0;

		private string string_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage B53A2E81;

		private HttpResponseMessage httpResponseMessage_0;

		private string string_1;

		private TaskAwaiter<HttpResponseMessage> CB1BF11B;

		private TaskAwaiter<string> A509A19B;

		void IAsyncStateMachine.MoveNext()
		{
			int num = int_0;
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
							awaiter = A509A19B;
							A509A19B = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0127;
						}
						awaiter2 = httpClient_0.PostAsync(uri_0, httpContent_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							CB1BF11B = awaiter2;
							E398C408 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
							return;
						}
					}
					else
					{
						awaiter2 = CB1BF11B;
						CB1BF11B = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					httpResponseMessage_0 = awaiter2.GetResult();
					B53A2E81 = httpResponseMessage_0;
					httpResponseMessage_0 = null;
					if (B53A2E81.IsSuccessStatusCode)
					{
						awaiter = B53A2E81.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							A509A19B = awaiter;
							E398C408 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0127;
					}
					goto IL_0147;
					IL_0127:
					string_1 = awaiter.GetResult();
					string_0 = string_1;
					string_1 = null;
					goto IL_0147;
					IL_0147:
					B53A2E81 = null;
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
				int_0 = -2;
				string_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			string_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		[DebuggerHidden]
		private void F12BFA31(IAsyncStateMachine AC0D64AA)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine AC0D64AA)
		{
			//ILSpy generated this explicit interface implementation from .override directive in F12BFA31
			this.F12BFA31(AC0D64AA);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string EA926592;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string EE163713;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_3;

	private object F6925D24 = new object();

	private object C60C1110 = new object();

	public int int_4 = 0;

	public int int_5 = 0;

	public int int_6 = 3;

	public string D8304E1A
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

	public string F137CCAF
	{
		[CompilerGenerated]
		get
		{
			return EA926592;
		}
		[CompilerGenerated]
		set
		{
			EA926592 = value;
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

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return EE163713;
		}
		[CompilerGenerated]
		set
		{
			EE163713 = value;
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

	public TMProxy(string D8053B19, int int_7, int EB1B9C90)
	{
		D8304E1A = D8053B19;
		F137CCAF = "";
		String_0 = "";
		Int32_2 = 0;
		Int32_3 = 0;
		Int32_0 = int_7;
		int_6 = EB1B9C90;
		int_4 = 0;
		int_5 = 0;
	}

	public static bool D72EC423(string string_1)
	{
		string string_2 = "{\"api_key\": \"" + string_1 + "\"}";
		string text = smethod_0("https://tmproxy.com/api/proxy/stats", string_2);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				string text2 = jObject["data"]["expired_at"].ToString();
				DateTime t = Common.ConvertStringToDatetime(text2, "HH:mm:ss dd/MM/yyyy");
				if (DateTime.Compare(t, DateTime.Now) > 0)
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

	public string CBAF1CB4()
	{
		lock (F6925D24)
		{
			if (int_4 == 0)
			{
				if (int_5 > 0 && int_5 < int_6)
				{
					if (A418572E() < 30 && !A9AD7D9C())
					{
						return "0";
					}
				}
				else if (!A9AD7D9C())
				{
					return "0";
				}
			}
			else
			{
				if (int_5 >= int_6)
				{
					return "2";
				}
				if (A418572E() < 30 && !A9AD7D9C())
				{
					return "0";
				}
			}
			int_5++;
			int_4++;
			return "1";
		}
	}

	public int A418572E()
	{
		method_0();
		return Int32_1;
	}

	public void B4ACC783()
	{
		lock (C60C1110)
		{
			int_4--;
			if (int_4 == 0 && int_5 == int_6)
			{
				int_5 = 0;
			}
		}
	}

	public bool A9AD7D9C()
	{
		Int32_3 = 0;
		F137CCAF = "";
		String_0 = "";
		Int32_2 = 0;
		string string_ = "{\"api_key\": \"" + D8304E1A + "\"}";
		string text = smethod_0("https://tmproxy.com/api/proxy/get-new-proxy", string_);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				string value = Regex.Match(JObject.Parse(text)["message"].ToString(), "\\d+").Value;
				Int32_3 = ((!(value == "")) ? int.Parse(value) : 0);
				if (Int32_3 == 0)
				{
					if (Int32_0 == 0)
					{
						F137CCAF = jObject["data"]["https"].ToString();
						string[] array = F137CCAF.Split(':');
						String_0 = array[0];
						Int32_2 = int.Parse(array[1]);
					}
					else
					{
						F137CCAF = jObject["data"]["socks5"].ToString();
						string[] array2 = F137CCAF.Split(':');
						String_0 = array2[0];
						Int32_2 = int.Parse(array2[1]);
					}
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	private string CD00EB38(string string_1)
	{
		string text = "";
		try
		{
			text = new RequestHttp().RequestGet(string_1);
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
		}
		return text;
	}

	public bool method_0()
	{
		Int32_3 = 0;
		F137CCAF = "";
		String_0 = "";
		Int32_2 = 0;
		Int32_1 = 0;
		string string_ = "{\"api_key\": \"" + D8304E1A + "\"}";
		string text = smethod_0("https://tmproxy.com/api/proxy/get-current-proxy", string_);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"].ToString() == "0")
				{
					Int32_3 = Convert.ToInt32(jObject["data"]["next_request"].ToString());
					Int32_1 = Convert.ToInt32(jObject["data"]["timeout"].ToString());
					if (Int32_0 == 0)
					{
						F137CCAF = jObject["data"]["https"].ToString();
						string[] array = F137CCAF.Split(':');
						String_0 = array[0];
						Int32_2 = int.Parse(array[1]);
					}
					else
					{
						F137CCAF = jObject["data"]["socks5"].ToString();
						string[] array2 = F137CCAF.Split(':');
						String_0 = array2[0];
						Int32_2 = int.Parse(array2[1]);
					}
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string BA90DC8B()
	{
		while (!method_0())
		{
		}
		return F137CCAF;
	}

	private static string smethod_0(string string_1, string string_2)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpContent httpContent_0 = new StringContent(string_2, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => E9B9A51A(new Uri(string_1), httpContent_0));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request Post");
			return "";
		}
	}

	public static string D731E188(string F8043395)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => smethod_1(new Uri(F8043395)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request get");
			return "";
		}
	}

	[AsyncStateMachine(typeof(E398C408))]
	[DebuggerStepThrough]
	private static Task<string> E9B9A51A(Uri uri_0, HttpContent httpContent_0)
	{
		E398C408 stateMachine = new E398C408();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.uri_0 = uri_0;
		stateMachine.httpContent_0 = httpContent_0;
		stateMachine.int_0 = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}

	[AsyncStateMachine(typeof(EA0DF538))]
	[DebuggerStepThrough]
	private static Task<string> smethod_1(Uri AC287A92)
	{
		EA0DF538 stateMachine = new EA0DF538();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.F48272BE = AC287A92;
		stateMachine.int_0 = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}
}
