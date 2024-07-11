using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GClass16
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string A2AAF427;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string E032618A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string B53B1CBC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal GClass15 gclass15_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string EEB50BAA;

	public static object object_0 = new object();

	public static object FD0B713B = new object();

	private static object object_1 = new object();

	private static object D90CA6B4 = new object();

	public string CABD57AC
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

	[JsonProperty("id")]
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

	[JsonProperty("uid")]
	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return A2AAF427;
		}
		[CompilerGenerated]
		set
		{
			A2AAF427 = value;
		}
	}

	[JsonProperty("object_id")]
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

	[JsonProperty("link")]
	public string A73254B6
	{
		[CompilerGenerated]
		get
		{
			return E032618A;
		}
		[CompilerGenerated]
		set
		{
			E032618A = value;
		}
	}

	[JsonProperty("type")]
	public string F88FDA31
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	[JsonProperty("reaction")]
	public string B601CD91
	{
		[CompilerGenerated]
		get
		{
			return B53B1CBC;
		}
		[CompilerGenerated]
		set
		{
			B53B1CBC = value;
		}
	}

	[JsonProperty("data_comment")]
	public GClass15 GClass15_0
	{
		[CompilerGenerated]
		get
		{
			return gclass15_0;
		}
		[CompilerGenerated]
		set
		{
			gclass15_0 = value;
		}
	}

	public string B73B363D
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return EEB50BAA;
		}
		[CompilerGenerated]
		set
		{
			EEB50BAA = value;
		}
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetJobs(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] byte_5);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr UpdateJob(byte[] F31A113C, byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] BF9B9887, byte[] byte_4);

	public static (List<GClass16> lstJobs, string error) smethod_0(string string_4, string DE287D83, string string_5, string string_6, string DE9CFD34, int DC9EAE1C = 10)
	{
		List<GClass16> list = new List<GClass16>();
		string text = "";
		string_5 = Common.UrlEncode(string_5);
		string text2 = Common.smethod_6(GetJobs(Common.B2B3DBBA(string_4), Common.B2B3DBBA(DE287D83), Common.B2B3DBBA(string_5), Common.B2B3DBBA(string_6), Common.B2B3DBBA(DE9CFD34), Common.B2B3DBBA(DC9EAE1C.ToString())));
		try
		{
			JObject jObject = JObject.Parse(text2);
			if (Convert.ToBoolean(jObject["success"]))
			{
				list = JsonConvert.DeserializeObject<List<GClass16>>(JObject.Parse(text2)["data"].ToString());
				foreach (GClass16 item in list)
				{
					item.CABD57AC = string_4;
					item.String_0 = DE287D83;
					try
					{
						item.B73B363D = item.GClass15_0.String_1;
						item.String_2 = item.GClass15_0.String_0;
					}
					catch (Exception)
					{
					}
				}
			}
			else
			{
				text = jObject["message"].ToString();
				if (text.Contains("Đã yêu cầu kháng đang chờ"))
				{
					text = "đã yêu cầu kháng, chờ check lại";
				}
				else if (text.Contains("lý do Acc die"))
				{
					text = "acc die, vui lòng gỡ và kháng lại";
				}
				else if (text.Contains("account nằm ở 1 tài khoản khác"))
				{
					text = "acc nằm ở 1 tài khoản khác";
				}
				else if (text.Contains("tên ngoại"))
				{
					text = "tên ngoại";
				}
				else if (text.Contains("làm quá") || text.Contains("jobs trong ngày"))
				{
					text = "làm quá jobs trong ngày";
				}
				else
				{
					smethod_1(text, DE287D83);
				}
			}
		}
		catch
		{
			if (text2.Contains("Gửi yêu cầu lấy jobs thành công ! thử lại sau vài giây,..."))
			{
				text2 = "Gửi yêu cầu lấy jobs thành công ! thử lại sau vài giây,...";
			}
			else if (text2.Contains("Hệ thống đang xử lý phân jobs, thử lại sau vài giây,..."))
			{
				text2 = "Hệ thống đang xử lý phân jobs, thử lại sau vài giây,...";
			}
			else if (text2.Contains("Server Error"))
			{
				text2 = "Internal Server Error";
			}
			smethod_1(text2, DE287D83);
		}
		return (list, text);
	}

	public void method_0(bool bool_0, string string_4 = "", bool bool_1 = false)
	{
		if (bool_0)
		{
			string_4 = "";
			bool_1 = false;
		}
		string a0988CA = "other";
		if (bool_1)
		{
			a0988CA = "job_die";
		}
		string a0988CA2 = "0";
		if (!string.IsNullOrEmpty(String_2))
		{
			a0988CA2 = String_2;
		}
		string text = "";
		for (int i = 0; i < 10; i++)
		{
			text = Common.smethod_6(UpdateJob(Common.B2B3DBBA(CABD57AC), Common.B2B3DBBA(Int32_0.ToString()), Common.B2B3DBBA(String_0), Common.B2B3DBBA(bool_0.ToString().ToLower()), Common.B2B3DBBA(string_4), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA(a0988CA2)));
			try
			{
				JObject jObject = JObject.Parse(text);
				if (Convert.ToBoolean(JObject.Parse(text)["success"]))
				{
					return;
				}
				if (jObject["message"].ToString() != "Vui lòng đăng nhập lại")
				{
					break;
				}
			}
			catch
			{
				if (!text.Contains("html"))
				{
					break;
				}
			}
			Common.Sleep(5 + i);
		}
		if (text.Contains("Server Error"))
		{
			text = "Internal Server Error";
		}
		BE08DFB9(this, text, String_0);
	}

	public static void smethod_1(string A63C9B82, string string_4)
	{
		string path = "golike\\getjob.txt";
		lock (object_0)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (string_4 != "")
				{
					File.AppendAllText(path, "Uid: " + string_4 + "\r\n");
				}
				File.AppendAllText(path, A63C9B82 + "\r\n");
			}
			catch
			{
			}
		}
	}

	public static void BE08DFB9(GClass16 gclass16_0, string F1292A98, string CE872A19)
	{
		string path = "golike\\updatejob.txt";
		lock (FD0B713B)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (CE872A19 != "")
				{
					File.AppendAllText(path, "Uid: " + CE872A19 + "\r\n");
				}
				if (gclass16_0 != null)
				{
					File.AppendAllText(path, "job_id: " + gclass16_0.Int32_0 + "\r\n");
					File.AppendAllText(path, "job_type: " + gclass16_0.F88FDA31 + "\r\n");
					File.AppendAllText(path, "object_id: " + gclass16_0.String_1 + "\r\n");
				}
				File.AppendAllText(path, F1292A98 + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}

	public static void smethod_2(GClass16 A3A80730, string A58BD50E, string AC8E9E84)
	{
		if (A58BD50E == "" || (A58BD50E.Contains(":") && A58BD50E.Split(':').Last().Trim() == ""))
		{
			return;
		}
		string path = "golike\\failjob.txt";
		lock (object_1)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (AC8E9E84 != "")
				{
					File.AppendAllText(path, "Uid: " + AC8E9E84 + "\r\n");
				}
				if (A3A80730 != null)
				{
					File.AppendAllText(path, "job_id: " + A3A80730.Int32_0 + "\r\n");
					File.AppendAllText(path, "job_type: " + A3A80730.F88FDA31 + "\r\n");
					File.AppendAllText(path, "object_id: " + A3A80730.String_1 + "\r\n");
				}
				File.AppendAllText(path, A58BD50E + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}

	public static void smethod_3(string D5B2EFBF, string B01730A7)
	{
		if (D5B2EFBF == "" || (D5B2EFBF.Contains(":") && D5B2EFBF.Split(':').Last().Trim() == ""))
		{
			return;
		}
		string path = "golike\\tokenResponse.txt";
		lock (D90CA6B4)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (B01730A7 != "")
				{
					File.AppendAllText(path, "Uid: " + B01730A7 + "\r\n");
				}
				File.AppendAllText(path, D5B2EFBF + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}
}
