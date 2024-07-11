using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class ShopLike : GClass3
{
	[CompilerGenerated]
	private sealed class D99CF19F
	{
		public string string_0;

		internal Task<string> method_0()
		{
			return smethod_2(new Uri(string_0));
		}
	}

	[CompilerGenerated]
	private sealed class A69C93A8 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public Uri uri_0;

		private string F0A4D537;

		private HttpClient FB0CEE95;

		private HttpResponseMessage EE29D8AB;

		private HttpResponseMessage E3AC7B36;

		private string string_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> AF214AB1;

		private void A796781D()
		{
			int num = int_0;
			string f0A4D;
			try
			{
				if ((uint)num > 1u)
				{
					F0A4D537 = string.Empty;
					FB0CEE95 = new HttpClient();
				}
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = AF214AB1;
							AF214AB1 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0121;
						}
						awaiter2 = FB0CEE95.GetAsync(uri_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							A69C93A8 stateMachine = this;
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
					E3AC7B36 = awaiter2.GetResult();
					EE29D8AB = E3AC7B36;
					E3AC7B36 = null;
					if (EE29D8AB.IsSuccessStatusCode)
					{
						awaiter = EE29D8AB.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							AF214AB1 = awaiter;
							A69C93A8 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0121;
					}
					goto IL_0141;
					IL_0121:
					string_0 = awaiter.GetResult();
					F0A4D537 = string_0;
					string_0 = null;
					goto IL_0141;
					IL_0141:
					EE29D8AB = null;
				}
				finally
				{
					if (num < 0 && FB0CEE95 != null)
					{
						((IDisposable)FB0CEE95).Dispose();
					}
				}
				FB0CEE95 = null;
				f0A4D = F0A4D537;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				F0A4D537 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			F0A4D537 = null;
			asyncTaskMethodBuilder_0.SetResult(f0A4D);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A796781D
			this.A796781D();
		}

		[DebuggerHidden]
		private void D0A2C81A(IAsyncStateMachine B6198A23)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine B6198A23)
		{
			//ILSpy generated this explicit interface implementation from .override directive in D0A2C81A
			this.D0A2C81A(B6198A23);
		}
	}

	[CompilerGenerated]
	private sealed class EBA6E22B : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> DE3B053E;

		public Uri AA9A2C8C;

		public HttpContent httpContent_0;

		private string string_0;

		private HttpClient B41AE11B;

		private HttpResponseMessage httpResponseMessage_0;

		private HttpResponseMessage httpResponseMessage_1;

		private string EF3AA694;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		void IAsyncStateMachine.MoveNext()
		{
			int num = int_0;
			string result;
			try
			{
				if ((uint)num > 1u)
				{
					string_0 = string.Empty;
					B41AE11B = new HttpClient();
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
							int_0 = -1;
							goto IL_0127;
						}
						awaiter2 = B41AE11B.PostAsync(AA9A2C8C, httpContent_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							EBA6E22B stateMachine = this;
							DE3B053E.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
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
					httpResponseMessage_1 = awaiter2.GetResult();
					httpResponseMessage_0 = httpResponseMessage_1;
					httpResponseMessage_1 = null;
					if (httpResponseMessage_0.IsSuccessStatusCode)
					{
						awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							EBA6E22B stateMachine = this;
							DE3B053E.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0127;
					}
					goto IL_0147;
					IL_0127:
					EF3AA694 = awaiter.GetResult();
					string_0 = EF3AA694;
					EF3AA694 = null;
					goto IL_0147;
					IL_0147:
					httpResponseMessage_0 = null;
				}
				finally
				{
					if (num < 0 && B41AE11B != null)
					{
						((IDisposable)B41AE11B).Dispose();
					}
				}
				B41AE11B = null;
				result = string_0;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				string_0 = null;
				DE3B053E.SetException(exception);
				return;
			}
			int_0 = -2;
			string_0 = null;
			DE3B053E.SetResult(result);
		}

		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string C81372BD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	private object F7869607 = new object();

	public int F69E79B7 = 0;

	public int int_2 = 0;

	public int A7082819 = 3;

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

	public string String_1
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

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return C81372BD;
		}
		[CompilerGenerated]
		set
		{
			C81372BD = value;
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

	public ShopLike(string string_2, int A5885CB7, int F8ACAA00)
	{
		String_0 = string_2;
		String_1 = "";
		String_2 = "";
		Int32_1 = 0;
		Int32_0 = A5885CB7;
		A7082819 = F8ACAA00;
		F69E79B7 = 0;
		int_2 = 0;
	}

	public void D438FA8D()
	{
		lock (F7869607)
		{
			F69E79B7--;
			if (F69E79B7 == 0 && int_2 == A7082819)
			{
				int_2 = 0;
			}
		}
	}

	public bool method_0()
	{
		try
		{
			String_1 = "";
			String_2 = "";
			Int32_1 = 0;
			string text = smethod_0("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + String_0);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (jObject["status"].ToString() == "success")
					{
						if (Int32_0 == 0)
						{
							String_1 = jObject["data"]["proxy"].ToString();
							string[] array = String_1.Split(':');
							String_2 = array[0];
							Int32_1 = int.Parse(array[1]);
						}
						return true;
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public bool CFA24F26()
	{
		String_1 = "";
		String_2 = "";
		Int32_1 = 0;
		string text = smethod_0("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + String_0);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["status"].ToString() == "success")
				{
					String_1 = jObject["data"]["proxy"].ToString();
					string[] array = String_1.Split(':');
					String_2 = array[0];
					Int32_1 = int.Parse(array[1]);
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_1()
	{
		while (!CFA24F26())
		{
		}
		return String_1;
	}

	public static string smethod_0(string string_2)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => smethod_2(new Uri(string_2)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request get");
			return "";
		}
	}

	[AsyncStateMachine(typeof(EBA6E22B))]
	[DebuggerStepThrough]
	private static Task<string> smethod_1(Uri uri_0, HttpContent A88E0518)
	{
		EBA6E22B stateMachine = new EBA6E22B();
		stateMachine.DE3B053E = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.AA9A2C8C = uri_0;
		stateMachine.httpContent_0 = A88E0518;
		stateMachine.int_0 = -1;
		stateMachine.DE3B053E.Start(ref stateMachine);
		return stateMachine.DE3B053E.Task;
	}

	[AsyncStateMachine(typeof(A69C93A8))]
	[DebuggerStepThrough]
	private static Task<string> smethod_2(Uri uri_0)
	{
		A69C93A8 stateMachine = new A69C93A8();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.uri_0 = uri_0;
		stateMachine.int_0 = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}
}
