using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

internal class Class65
{
    private RequestXNet ABBACF05;

    private Chrome gclass4_0;

    private string string_0 = "";

    private string F936C306 = "";

    public string D791CF00;

	private string string_0x;

	private string string_1;

	private int int_0;

	public string string_2;
    private Dictionary<string, int> dictionary_0 = new Dictionary<string, int>
    {
        { "like", 1 },
        { "love", 2 },
        { "care", 16 },
        { "haha", 4 },
        { "wow", 3 },
        { "sad", 7 },
        { "angry", 8 }
    };

    public Class65(string string_3, string string_4, string string_5, int DF3A02A1, string string_6)
	{
		D791CF00 = string_3;
		string_0x = string_4;
		string_1 = string_5;
		int_0 = DF3A02A1;
		string_2 = string_6;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Like(byte[] byte_0, byte[] byte_1, byte[] AB3BE58A, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	public string method_0(string string_3)
	{
        //string text = gclass4_0.GetCookieFromChrome();
        //string text2 = gclass4_0.GetUseragent();
        //string string_2 = gclass4_0.String_5;
        //int b9ADE = gclass4_0.B9ADE836;
        //string text3 = BC05D8B6();
        return Common.smethod_6(Like(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(string_2), Common.B2B3DBBA(string_3)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Comment(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] byte_5, byte[] BC0AA1A9);

	public string EF220E88(string string_3, string FB1C7D0A)
	{
		return Common.smethod_6(Comment(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(string_2), Common.B2B3DBBA(string_3), Common.B2B3DBBA(FB1C7D0A)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr ShareWall(byte[] byte_0, byte[] byte_1, byte[] DB15AD34, byte[] B9877433, byte[] byte_2, byte[] E69D4586);

	public string C01DED93(string E9A9828C)
	{
		return Common.smethod_6(ShareWall(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(string_2), Common.B2B3DBBA(E9A9828C)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetPostIdFromGroup(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] EB05E238, byte[] byte_3);

	public string method_1(string EAAB0B81)
	{
		return Common.smethod_6(GetPostIdFromGroup(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(EAAB0B81)));
	}

	private string method_2(string string_3)
	{
		return Common.A4A02BB3(D791CF00, string_0x, string_1, int_0, string_3);
	}

	public bool method_3(string C5AEEAA9)
	{
		return C5AEEAA9.Contains("You cannot access the app till you log in to www.facebook.com and follow the instructions given") || C5AEEAA9.Contains("The user is enrolled in a blocking, logged-in checkpoint") || C5AEEAA9.Contains("The session has been invalidated") || C5AEEAA9.Contains("Sessions for the user are not allowed") || C5AEEAA9.Contains("Malformed access token") || C5AEEAA9.Contains("Error loading application") || C5AEEAA9.Contains("Invalid OAuth access token - Cannot parse access token");
	}

	public (bool isSuccess, string error) method_4(JSON_Settings BA13B780)
	{
		string text = BA13B780.GetValue("id");
		bool item = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		while (true)
		{
			text4 = method_0(text);
			if (!(text4 == "true"))
			{
				if (!method_3(text4))
				{
					if (!text4.Contains("temporarily restricted"))
					{
						if (text.Contains("_"))
						{
							break;
						}
						try
						{
							text3 = "https://graph.facebook.com/" + text + "?fields=id,from{id}&access_token=" + string_2;
							text4 = method_2(text3);
							JObject jObject = JObject.Parse(text4);
							text = jObject["from"]["id"]?.ToString() + "_" + jObject["id"];
						}
						catch
						{
							if (text4.Contains("\"id\"") && text4.Contains("\"created_time\""))
							{
								break;
							}
							if (text4.Contains("does not exist") || text4.Contains("nonexisting field"))
							{
								text2 += "job_die";
								break;
							}
							if (method_3(text4))
							{
								text2 += "token_die";
								string_2 = "";
								break;
							}
							if (!text4.Contains("Insufficient permission"))
							{
								goto IL_016d;
							}
							text = method_1(text);
							if (!text.Contains("_"))
							{
								goto IL_016d;
							}
							goto end_IL_00cd;
							IL_016d:
							if (!text4.Contains("Invalid request") && text4 != "")
							{
								GClass16.smethod_3(text3 + "\n" + text4, null);
							}
							break;
							end_IL_00cd:;
						}
						continue;
					}
					text2 += "fb_blocked";
					break;
				}
				text2 += "token_die";
				string_2 = "";
				break;
			}
			item = true;
			break;
		}
		return (item, text2);
	}

	public (bool isSuccess, string error) method_5(JSON_Settings gclass8_0)
	{
		string text = gclass8_0.GetValue("id");
		bool item = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		text4 = method_0(text);
		if (text4 == "true")
		{
			item = true;
		}
		else if (text4.Contains("does not exist") || text4.Contains("nonexisting field"))
		{
			text2 += "job_die";
		}
		else if (method_3(text4))
		{
			text2 += "token_die";
			string_2 = "";
		}
		else if (text4.Contains("temporarily restricted"))
		{
			text2 += "fb_blocked";
		}
		else if (!text.Contains("_") && !text4.Contains("Invalid request"))
		{
			GClass16.smethod_3(text3 + "\n" + text4, null);
		}
		return (item, text2);
	}

	public (bool isSuccess, string error) C79C56AA(JSON_Settings gclass8_0)
	{
		string text = gclass8_0.GetValue("id");
		string text2 = gclass8_0.GetValue("content");
		bool item = false;
		string text3 = "";
		string text4 = "";
		string text5 = "";
		text5 = EF220E88(text, Common.UrlEncode(text2));
		if (text5.Contains("\"id\""))
		{
			item = true;
		}
		else if (text5.Contains("does not exist") || text5.Contains("nonexisting field"))
		{
			text3 += "job_die";
		}
		else if (method_3(text5))
		{
			text3 += "token_die";
			string_2 = "";
		}
		else if (text5.Contains("temporarily restricted"))
		{
			text3 += "fb_blocked";
		}
		else if (!text.Contains("_") && !text5.Contains("Invalid request"))
		{
			GClass16.smethod_3(text4 + "\n" + text5, null);
		}
		return (item, text3);
	}

	public (bool isSuccess, string error) method_6(JSON_Settings gclass8_0)
	{
		string text = gclass8_0.GetValue("id");
		bool item = false;
		string text2 = "";
		string text3 = text;
		if (!text3.StartsWith("http"))
		{
			text3 = "https://www.facebook.com/" + text3;
		}
		string text4 = "";
		string text5 = "";
		text5 = C01DED93(text3);
		if (text5.Contains("\"id\""))
		{
			item = true;
		}
		else if (text5.Contains("does not exist") || text5.Contains("nonexisting field"))
		{
			text2 += "job_die";
		}
		else if (method_3(text5))
		{
			text2 += "token_die";
			string_2 = "";
		}
		else if (text5.Contains("temporarily restricted"))
		{
			text2 += "fb_blocked";
		}
		else if (!text5.Contains("Invalid request"))
		{
			GClass16.smethod_3(text4 + "\n" + text5, null);
		}
		return (item, text2);
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr AddFriend(byte[] E238E0BB, byte[] byte_0, byte[] byte_1, byte[] BE9C0383, byte[] byte_2, byte[] A0164DB2, byte[] byte_3);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Follow(byte[] byte_0, byte[] byte_1, byte[] EF2C3C87, byte[] AD0F5308, byte[] E2312510, byte[] BE821309, byte[] A31B9A9B);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr LikePage(byte[] byte_0, byte[] C8AA8D17, byte[] C4334306, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr JoinGroup(byte[] EBB0128E, byte[] C5AC9E1C, byte[] A628A9A7, byte[] AE3B8F82, byte[] byte_0, byte[] byte_1, byte[] C10C7D15);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Reaction(byte[] D89BC03C, byte[] E316E8AC, byte[] byte_0, byte[] DDB61639, byte[] CF8BF798, byte[] byte_1);

	public (bool isSuccess, string error) F51A8802(string string_3, JSON_Settings CF338C9F)
	{
		string a0988CA = CF338C9F.GetValue("id");
		string a0988CA2 = CF338C9F.GetValue("reaction");
		bool item = false;
		string item2 = "";
		string a0988CA3 = "";
		string text = "";
		switch (string_3)
		{
		case "reaction":
			text = Common.smethod_6(Reaction(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA(a0988CA2)));
			break;
		case "join_group":
			text = Common.smethod_6(JoinGroup(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(a0988CA3), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA("3")));
			break;
		case "like_page":
			text = Common.smethod_6(LikePage(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(a0988CA3), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA("3")));
			break;
		case "follow":
			text = Common.smethod_6(Follow(Common.B2B3DBBA(D791CF00), Common.B2B3DBBA(string_0x), Common.B2B3DBBA(string_1), Common.B2B3DBBA(int_0.ToString()), Common.B2B3DBBA(a0988CA3), Common.B2B3DBBA(a0988CA), Common.B2B3DBBA("3")));
			break;
		}
		switch (text)
		{
		case "job_die":
		case "fb_blocked":
			item2 = text;
			break;
		case "true":
			item = true;
			break;
		}
		return (item, item2);
	}
}
