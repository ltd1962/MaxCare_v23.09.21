using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

internal class Apiv2PublicVitechcheap
{
	[CompilerGenerated]
	private sealed class F389EF06
	{
		public string CF186FA1;
	}

	[CompilerGenerated]
	private sealed class Class13
	{
		public HttpContent A03D3787;

		public F389EF06 CD28D920;

		internal Task<string> method_0()
		{
			return smethod_1(new Uri(CD28D920.CF186FA1), A03D3787);
		}
	}

	[CompilerGenerated]
	private sealed class FD380882 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> A02D01BF;

		public Uri uri_0;

		private string B0917D95;

		private HttpClient httpClient_0;

		private HttpResponseMessage AF249FB1;

		private HttpResponseMessage ED3AC527;

		private string string_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		void IAsyncStateMachine.MoveNext()
		{
			int num = int_0;
			string b0917D;
			try
			{
				if ((uint)num > 1u)
				{
					B0917D95 = string.Empty;
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
							int_0 = -1;
							goto IL_0121;
						}
						awaiter2 = httpClient_0.GetAsync(uri_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							FD380882 stateMachine = this;
							A02D01BF.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
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
					ED3AC527 = awaiter2.GetResult();
					AF249FB1 = ED3AC527;
					ED3AC527 = null;
					if (AF249FB1.IsSuccessStatusCode)
					{
						awaiter = AF249FB1.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							FD380882 stateMachine = this;
							A02D01BF.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0121;
					}
					goto IL_0141;
					IL_0121:
					string_0 = awaiter.GetResult();
					B0917D95 = string_0;
					string_0 = null;
					goto IL_0141;
					IL_0141:
					AF249FB1 = null;
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
				httpClient_0 = null;
				b0917D = B0917D95;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				B0917D95 = null;
				A02D01BF.SetException(exception);
				return;
			}
			int_0 = -2;
			B0917D95 = null;
			A02D01BF.SetResult(b0917D);
		}

		[DebuggerHidden]
		private void AE0DCD89(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in AE0DCD89
			this.AE0DCD89(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class A72E8184 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public Uri B9B7F09E;

		public HttpContent httpContent_0;

		private string string_0;

		private HttpClient D3244686;

		private HttpResponseMessage BDB93284;

		private HttpResponseMessage httpResponseMessage_0;

		private string string_1;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void C8905F85()
		{
			int num = int_0;
			string result;
			try
			{
				if ((uint)num > 1u)
				{
					string_0 = string.Empty;
					D3244686 = new HttpClient();
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
						awaiter2 = D3244686.PostAsync(B9B7F09E, httpContent_0).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							A72E8184 stateMachine = this;
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
					BDB93284 = httpResponseMessage_0;
					httpResponseMessage_0 = null;
					if (BDB93284.IsSuccessStatusCode)
					{
						awaiter = BDB93284.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							taskAwaiter_1 = awaiter;
							A72E8184 stateMachine = this;
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
					BDB93284 = null;
				}
				finally
				{
					if (num < 0 && D3244686 != null)
					{
						((IDisposable)D3244686).Dispose();
					}
				}
				D3244686 = null;
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

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C8905F85
			this.C8905F85();
		}

		[DebuggerHidden]
		private void CEBFAF3F(IAsyncStateMachine E6B01E99)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine E6B01E99)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CEBFAF3F
			this.CEBFAF3F(E6B01E99);
		}
	}

	private object object_0 = new object();

	private object object_1 = new object();

	public int D33A6C9B;

	private string E48A489D;

	public string string_0;

	public string string_1 = "";

	public int int_0 = 0;

	public int int_1 = 0;

	public int int_2 = 3;

	public Apiv2PublicVitechcheap(string string_2, string F1840212, int int_3, int DB105515)
	{
		E48A489D = string_2;
		string_0 = F1840212;
		int_2 = DB105515;
		string_1 = "";
		D33A6C9B = int_3;
	}

	public bool method_0()
	{
		bool result = false;
		try
		{
			string b00B0B = "https://apiv2-public.vitechcheap.com/v1/public/rotate";
			string string_ = "{\"proxy\": \"" + string_0 + "\"}";
			smethod_0(b00B0B, E48A489D, string_);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	private static string smethod_0(string B00B0B28, string DD8CBC2B, string string_2)
	{
		string text = "";
		try
		{
			HttpClient httpClient = new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", DD8CBC2B);
			HttpContent A03D3787 = new StringContent(string_2, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => smethod_1(new Uri(B00B0B28), A03D3787));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request Post");
			return "";
		}
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(A72E8184))]
	private static Task<string> smethod_1(Uri C523C007, HttpContent AD000C3B)
	{
		A72E8184 stateMachine = new A72E8184();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.B9B7F09E = C523C007;
		stateMachine.httpContent_0 = AD000C3B;
		stateMachine.int_0 = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FD380882))]
	private static Task<string> smethod_2(Uri uri_0)
	{
		FD380882 stateMachine = new FD380882();
		stateMachine.A02D01BF = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.uri_0 = uri_0;
		stateMachine.int_0 = -1;
		stateMachine.A02D01BF.Start(ref stateMachine);
		return stateMachine.A02D01BF.Task;
	}

	public void method_1()
	{
		lock (object_0)
		{
			int_0--;
			if (int_0 == 0 && int_1 == int_2)
			{
				int_1 = 0;
			}
		}
	}

	public bool method_2()
	{
		bool result = false;
		try
		{
		}
		catch
		{
		}
		return result;
	}
}
