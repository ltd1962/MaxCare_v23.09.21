using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;
using WindowsFormsControlLibrary1;

public class fGolike : Form
{
	private enum D524C910
	{
		const_0,
		const_1,
		const_2
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class C09B4EB5
	{
		public static readonly C09B4EB5 _003C_003E9 = new C09B4EB5();

		public static Func<string, Guid> _003C_003E9__135_0;

		public static Func<string, bool> _003C_003E9__135_1;

		public static Func<string, string> _003C_003E9__135_2;

		public static Comparison<string> _003C_003E9__135_3;

		public static Func<string, Guid> _003C_003E9__135_4;

		public static Func<string, Guid> _003C_003E9__135_6;

		public static Func<string, Guid> _003C_003E9__135_7;

		public static Func<string, Guid> _003C_003E9__135_8;

		public static Func<string, Guid> _003C_003E9__135_9;

		public static Func<string, bool> _003C_003E9__135_10;

		public static Func<string, string> _003C_003E9__135_11;

		public static Comparison<string> _003C_003E9__135_12;

		public static Func<string, Guid> _003C_003E9__135_13;

		public static Func<string, Guid> _003C_003E9__135_15;

		public static Func<string, Guid> _003C_003E9__135_16;

		public static Func<string, Guid> _003C_003E9__135_17;

		public static Func<string, Guid> _003C_003E9__135_18;

		public static Func<string, bool> _003C_003E9__135_19;

		public static Func<string, string> _003C_003E9__135_20;

		public static Comparison<string> _003C_003E9__135_21;

		public static Func<string, Guid> _003C_003E9__135_22;

		public static Func<string, Guid> _003C_003E9__135_24;

		public static Func<string, Guid> _003C_003E9__135_25;

		public static Func<string, Guid> _003C_003E9__135_26;

		public static Converter<string, string> _003C_003E9__145_0;

		internal Guid method_0(string string_0)
		{
			return Guid.NewGuid();
		}

		internal bool method_1(string string_0)
		{
			return string_0.Split('|')[3].ToLower() == "false";
		}

		internal string method_2(string string_0)
		{
			return string_0;
		}

		internal int method_3(string string_0, string BD8DBA9F)
		{
			return int.Parse(BD8DBA9F.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2]));
		}

		internal Guid A2BA1638(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_4(string A529A99D)
		{
			return Guid.NewGuid();
		}

		internal Guid method_5(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid CEBC8B0B(string D7A01224)
		{
			return Guid.NewGuid();
		}

		internal Guid A509751C(string F11D2D07)
		{
			return Guid.NewGuid();
		}

		internal bool method_6(string string_0)
		{
			return string_0.Split('|')[3].ToLower() == "false";
		}

		internal string method_7(string AFA4149C)
		{
			return AFA4149C;
		}

		internal int BA3A200F(string string_0, string string_1)
		{
			return int.Parse(string_1.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2]));
		}

		internal Guid B096F1BA(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_8(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_9(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_10(string CD232288)
		{
			return Guid.NewGuid();
		}

		internal Guid B531A6B4(string B530EA38)
		{
			return Guid.NewGuid();
		}

		internal bool C613A316(string BD1E849C)
		{
			return BD1E849C.Split('|')[3].ToLower() == "false";
		}

		internal string CA84EB2D(string string_0)
		{
			return string_0;
		}

		internal int D42B5B33(string string_0, string string_1)
		{
			return int.Parse(string_1.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2]));
		}

		internal Guid method_11(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_12(string BFACCBA3)
		{
			return Guid.NewGuid();
		}

		internal Guid A80A862C(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_13(string string_0)
		{
			return Guid.NewGuid();
		}

		internal string method_14(string string_0)
		{
			return string_0.ToLower();
		}
	}

	[CompilerGenerated]
	private sealed class ACA7A8A1
	{
		public JSON_Settings gclass8_0;

		public fGolike bfb2AB91_0;

		public MethodInvoker methodInvoker_0;

		internal void method_0()
		{
			bfb2AB91_0.method_82();
		}
	}

	[CompilerGenerated]
	private sealed class Class23
	{
		public int int_0;

		public List<int> DF99F409;

		public int AE28CC9C;

		public bool bool_0;

		public ACA7A8A1 aca7A8A1_0;

		public ThreadStart CFBB4400;

		public ThreadStart A3B89BBF;

		internal void C4BCF729()
		{
			try
			{
				if (aca7A8A1_0.gclass8_0.GetValueBool("Interact"))
				{
					Class24 CS_0024_003C_003E8__locals0 = new Class24
					{
						B92ADB11 = this
					};
					List<string> list = new List<string>();
					CS_0024_003C_003E8__locals0.string_0 = "";
					string text = "";
					int num = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudSoLuotChay", 1);
					if (num == 0)
					{
						num = 1;
					}
					for (int i = 0; i < num; i++)
					{
						list = new List<string>();
						if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
						{
							text = ((num > 1) ? string.Format(Language.GetValue("Lượt {0}/{1}. "), i + 1, num) : "");
							if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("RepeatAllVIP"))
							{
								list = SettingsTool.GetSettings("configInteractGeneral").GetValueList("lstIdKichBan");
								if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomKichBan"))
								{
									list = Common.ShuffleList(list);
									list = Common.ShuffleList(list);
									list = Common.ShuffleList(list);
								}
							}
							else
							{
								list.Add(SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan"));
							}
						}
						else
						{
							list.Add(SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan"));
						}
						for (int j = 0; j < list.Count; j++)
						{
							if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbXoaCache"))
							{
								Thread thread = new Thread(new Class25
								{
									class24_0 = CS_0024_003C_003E8__locals0,
									int_0 = 0,
									E3BE2AA9 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10)
								}.method_0);
								thread.IsBackground = true;
								thread.Start();
							}
							if (aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								break;
							}
							CS_0024_003C_003E8__locals0.string_0 = list[j];
							if (text != "")
							{
								aca7A8A1_0.bfb2AB91_0.method_58(text + string.Format(Language.GetValue("Kịch bản") + ": {0}...", InteractSQL.smethod_1(CS_0024_003C_003E8__locals0.string_0)));
							}
							if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomThuTuTaiKhoan"))
							{
								aca7A8A1_0.bfb2AB91_0.D030FA3A.Invoke((MethodInvoker)delegate
								{
									aca7A8A1_0.bfb2AB91_0.method_82();
								});
							}
							aca7A8A1_0.bfb2AB91_0.dictionary_0 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDThamGiaNhomUid");
							aca7A8A1_0.bfb2AB91_0.dictionary_1 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDThamGiaNhomUidv2");
							aca7A8A1_0.bfb2AB91_0.dictionary_17 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDKetBanVoiBanBeCuaUid");
							aca7A8A1_0.bfb2AB91_0.E23B4A9D = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDKetBanTepUid");
							aca7A8A1_0.bfb2AB91_0.dictionary_2 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDKetBanTepUidv2");
							aca7A8A1_0.bfb2AB91_0.D683B016 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDBaiVietProfile");
							aca7A8A1_0.bfb2AB91_0.dictionary_3 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDSpamBaiViet");
							aca7A8A1_0.bfb2AB91_0.DBA18A3F = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDSpamBaiVietv2");
							aca7A8A1_0.bfb2AB91_0.dictionary_4 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDSpamBaiViet", "txtComment");
							aca7A8A1_0.bfb2AB91_0.E895F516 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDSpamBaiVietv2", "txtComment");
							aca7A8A1_0.bfb2AB91_0.A004CC2C = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDBuffTinNhanProfile");
							aca7A8A1_0.bfb2AB91_0.dictionary_5 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDKetBanTepUidNew", "txtLink");
							aca7A8A1_0.bfb2AB91_0.AD043507 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDBuffLikeComment", "txtComment");
							aca7A8A1_0.bfb2AB91_0.dictionary_6 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDBuffLikeComment", "txtComment");
							aca7A8A1_0.bfb2AB91_0.dictionary_7 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangStatus", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.F425F288 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangStatus", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.dictionary_8 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangStatusV2", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.dictionary_9 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangStatusV2", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.E1B23AB3 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDPhanHoiBinhLuan");
							aca7A8A1_0.bfb2AB91_0.EA2797A9 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDBuffLikeComment", "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.FB142A84 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangBaiTheoID", "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.A8BA2C20 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDBuffFollowLikePage");
							aca7A8A1_0.bfb2AB91_0.B9A41D39 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDShareBaiTut", "txtLinkChiaSe");
							aca7A8A1_0.bfb2AB91_0.dictionary_10 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDLinkToInstagram", "txtBio");
							aca7A8A1_0.bfb2AB91_0.FE8A1487 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDLinkToInstagram", "txtBio");
							aca7A8A1_0.bfb2AB91_0.dictionary_11 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDReviewPage");
							aca7A8A1_0.bfb2AB91_0.dictionary_12 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDNhanTinBanBe", "txtTinNhan");
							aca7A8A1_0.bfb2AB91_0.A19F8027 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDNhanTinBanBe", "txtTinNhan");
							aca7A8A1_0.bfb2AB91_0.D9B53233 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangBai", "lstNhomTuNhap");
							aca7A8A1_0.bfb2AB91_0.dictionary_13 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangBai", "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.F3B2F19D = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDTuongTacLivestream", "txtComment");
							aca7A8A1_0.bfb2AB91_0.C8327704 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangBai", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.C00CDC8B = new Dictionary<string, List<string>>();
							aca7A8A1_0.bfb2AB91_0.dictionary_14 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDAddMail", "lstHotmail");
							aca7A8A1_0.bfb2AB91_0.dictionary_15 = new Dictionary<string, List<string>>();
							aca7A8A1_0.bfb2AB91_0.dictionary_16 = new Dictionary<string, List<string>>();
							aca7A8A1_0.bfb2AB91_0.E02E651E = new Dictionary<string, Dictionary<string, int>>();
							aca7A8A1_0.bfb2AB91_0.dictionary_25 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDPhanHoiBinhLuan", "txtComment");
							aca7A8A1_0.bfb2AB91_0.dictionary_18 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDDangReel", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.dictionary_19 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDShareBai", "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.B2BDD2A9 = aca7A8A1_0.bfb2AB91_0.A033DABA(CS_0024_003C_003E8__locals0.string_0, "HDChaySpam", "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.dictionary_20 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDChaySpam", "txtComment");
							aca7A8A1_0.bfb2AB91_0.dictionary_21 = aca7A8A1_0.bfb2AB91_0.method_11(CS_0024_003C_003E8__locals0.string_0, "HDChaySpam", "txtComment");
							aca7A8A1_0.bfb2AB91_0.method_15();
							aca7A8A1_0.bfb2AB91_0.C923A3A2 = new Dictionary<string, List<string>>();
							aca7A8A1_0.bfb2AB91_0.dictionary_24 = new Dictionary<string, List<string>>();
							aca7A8A1_0.bfb2AB91_0.dictionary_22 = new Dictionary<string, List<string>>();
							aca7A8A1_0.bfb2AB91_0.dictionary_23 = new Dictionary<string, List<string>>();
							if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 1)
							{
								for (int k = 0; k < aca7A8A1_0.bfb2AB91_0.list_0.Count; k++)
								{
									(aca7A8A1_0.bfb2AB91_0.list_0[k] as XproxyProxy).resetXProxy();
								}
							}
							if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 14)
							{
								for (int l = 0; l < aca7A8A1_0.bfb2AB91_0.F93ADB36.Count; l++)
								{
									aca7A8A1_0.bfb2AB91_0.F93ADB36[l].resetOBCProxy();
								}
							}
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								try
								{
									int num17 = 0;
									while (num17 < CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count && !CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
									{
										if (Convert.ToBoolean(CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num17].Cells["cChose"].Value))
										{
											if (CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
											{
												break;
											}
											if (CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count < CS_0024_003C_003E8__locals0.B92ADB11.int_0)
											{
												BB324D81 CS_0024_003C_003E8__locals3 = new BB324D81
												{
													class24_0 = CS_0024_003C_003E8__locals0
												};
												if (CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
												{
													break;
												}
												CS_0024_003C_003E8__locals3.int_0 = num17++;
												Thread thread7 = new Thread((ThreadStart)delegate
												{
													int num23 = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals3.class24_0.B92ADB11.DF99F409);
													try
													{
														CS_0024_003C_003E8__locals3.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_19(CS_0024_003C_003E8__locals3.int_0, num23, CS_0024_003C_003E8__locals3.class24_0.string_0, CS_0024_003C_003E8__locals3.class24_0.B92ADB11.aca7A8A1_0.gclass8_0);
														Common.FillIndexPossition(ref CS_0024_003C_003E8__locals3.class24_0.B92ADB11.DF99F409, num23);
														bool flag = false;
														if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
														{
															flag = true;
														}
														else
														{
															string text2 = CS_0024_003C_003E8__locals3.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_92(CS_0024_003C_003E8__locals3.int_0);
															if (text2 != "Live")
															{
																flag = true;
															}
															if (!flag)
															{
																string text3 = CS_0024_003C_003E8__locals3.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals3.int_0).ToLower();
																flag = text3.Contains("checkpoint") || text3.Contains("invalid username or password") || text3.Contains("Proxy chưa ủy quyền!".ToLower()) || text3.Contains("fb block") || text3.Contains("Max Job Today".ToLower());
															}
														}
														if (flag)
														{
															CS_0024_003C_003E8__locals3.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals3.int_0, "cChose", false);
														}
													}
													catch (Exception ex5)
													{
														if (ex5.ToString().Contains("Thread was being aborted."))
														{
															Common.FillIndexPossition(ref CS_0024_003C_003E8__locals3.class24_0.B92ADB11.DF99F409, num23);
															if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
															{
																CS_0024_003C_003E8__locals3.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals3.int_0, "cChose", false);
															}
														}
													}
												})
												{
													Name = CS_0024_003C_003E8__locals3.int_0.ToString()
												};
												CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Add(thread7);
												Common.Sleep(1.0);
												thread7.Start();
											}
											else
											{
												if (CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
												{
													break;
												}
												if ((SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 7 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 10 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy")))
												{
													for (int num18 = 0; num18 < CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num18++)
													{
														CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[num18].Join();
														CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(num18--);
													}
												}
												else if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2)
												{
													for (int num19 = 0; num19 < CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num19++)
													{
														CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[num19].Join();
														CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(num19--);
													}
													if (CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
													{
														break;
													}
													Interlocked.Increment(ref CS_0024_003C_003E8__locals0.B92ADB11.AE28CC9C);
													if (CS_0024_003C_003E8__locals0.B92ADB11.AE28CC9C >= SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1))
													{
														for (int num20 = 0; num20 < 3; num20++)
														{
															CS_0024_003C_003E8__locals0.B92ADB11.bool_0 = Common.ChangeIP(SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
															if (CS_0024_003C_003E8__locals0.B92ADB11.bool_0)
															{
																break;
															}
														}
														if (!CS_0024_003C_003E8__locals0.B92ADB11.bool_0)
														{
															MessageBoxHelper.Show("Không thê\u0309 đô\u0309i ip!", 2);
															CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0 = true;
															return;
														}
														CS_0024_003C_003E8__locals0.B92ADB11.AE28CC9C = 0;
													}
												}
												else
												{
													for (int num21 = 0; num21 < CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num21++)
													{
														if (!CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[num21].IsAlive)
														{
															CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(num21--);
														}
													}
												}
											}
										}
										else
										{
											num17++;
										}
										if (CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
										{
											break;
										}
									}
									for (int num22 = 0; num22 < CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num22++)
									{
										CS_0024_003C_003E8__locals0.B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[num22].Join();
									}
								}
								catch (ThreadAbortException ex4)
								{
									if (ex4.ToString().Contains("Thread was being aborted."))
									{
									}
								}
							});
							thread2.IsBackground = true;
							thread2.Start();
							if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayKichBan"))
							{
								int num2 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanTo") + 1);
								if (!thread2.Join(num2 * 60000))
								{
									thread2.Abort();
									for (int m = 0; m < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; m++)
									{
										aca7A8A1_0.bfb2AB91_0.E2B4308C[m].Abort();
										while (aca7A8A1_0.bfb2AB91_0.E2B4308C[m].IsAlive)
										{
											Thread.Sleep(1000);
										}
									}
									while (thread2.IsAlive)
									{
										Thread.Sleep(1000);
									}
								}
							}
							else
							{
								thread2.Join();
							}
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_0);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_1);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_17);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.E23B4A9D);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_2);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.D683B016);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_3);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.DBA18A3F);
							aca7A8A1_0.bfb2AB91_0.method_13(aca7A8A1_0.bfb2AB91_0.AD043507, bool_5: true, "txtComment");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_4, "txtComment");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.E895F516, "txtComment");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.A004CC2C);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_5, "txtLink");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.EA2797A9, "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.FB142A84, "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.A8BA2C20);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.B9A41D39, "txtLinkChiaSe");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_10, "txtBio");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_11);
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.D9B53233, "lstNhomTuNhap");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_13, "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.F3B2F19D, "txtComment");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.C8327704, "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_14, "lstHotmail");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_25, "txtComment");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_18, "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.method_12(aca7A8A1_0.bfb2AB91_0.dictionary_19, "txtNoiDung");
							aca7A8A1_0.bfb2AB91_0.method_14(aca7A8A1_0.bfb2AB91_0.B2BDD2A9, "txtIdPost");
							aca7A8A1_0.bfb2AB91_0.method_13(aca7A8A1_0.bfb2AB91_0.dictionary_20, bool_5: true, "txtComment");
							if (aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								break;
							}
							if (j + 1 >= list.Count)
							{
								continue;
							}
							int num3 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayKichBanFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayKichBanTo") + 1);
							int tickCount = Environment.TickCount;
							while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
							{
								aca7A8A1_0.bfb2AB91_0.method_58(text + string.Format(Language.GetValue("Chạy kịch bản tiếp theo sau {time} giây...").Replace("{time}", (num3 - (Environment.TickCount - tickCount) / 1000).ToString())));
								Common.Sleep(0.5);
								if (aca7A8A1_0.bfb2AB91_0.bool_0)
								{
									break;
								}
							}
						}
						if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll") || aca7A8A1_0.bfb2AB91_0.bool_0)
						{
							break;
						}
						if (i + 1 < num)
						{
							int num4 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnTo") + 1) * 60;
							int tickCount2 = Environment.TickCount;
							while ((Environment.TickCount - tickCount2) / 1000 - num4 < 0)
							{
								aca7A8A1_0.bfb2AB91_0.method_58(text + string.Format(Language.GetValue("Chạy lượt tiếp theo sau {time} giây...").Replace("{time}", (num4 - (Environment.TickCount - tickCount2) / 1000).ToString())));
								Common.Sleep(0.5);
								if (aca7A8A1_0.bfb2AB91_0.bool_0)
								{
									break;
								}
							}
						}
						if (aca7A8A1_0.bfb2AB91_0.bool_0)
						{
							break;
						}
					}
				}
				else if (aca7A8A1_0.gclass8_0.GetValueBool("OpenBrowser"))
				{
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 1)
					{
						for (int n = 0; n < aca7A8A1_0.bfb2AB91_0.list_0.Count; n++)
						{
							(aca7A8A1_0.bfb2AB91_0.list_0[n] as XproxyProxy).resetXProxy();
						}
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 14)
					{
						for (int num5 = 0; num5 < aca7A8A1_0.bfb2AB91_0.F93ADB36.Count; num5++)
						{
							aca7A8A1_0.bfb2AB91_0.F93ADB36[num5].resetOBCProxy();
						}
					}
					Thread thread3 = new Thread((ThreadStart)delegate
					{
						try
						{
							int num15 = 0;
							while (num15 < aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count && !aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								if (Convert.ToBoolean(aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num15].Cells["cChose"].Value))
								{
									if (aca7A8A1_0.bfb2AB91_0.bool_0 || aca7A8A1_0.bfb2AB91_0.E2B4308C.Count >= int_0)
									{
										break;
									}
									Class26 CS_0024_003C_003E8__locals2 = new Class26
									{
										CC1B6A2F = this
									};
									if (aca7A8A1_0.bfb2AB91_0.bool_0)
									{
										break;
									}
									CS_0024_003C_003E8__locals2.int_0 = num15++;
									Thread thread6 = new Thread((ThreadStart)delegate
									{
										int int_ = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals2.CC1B6A2F.DF99F409);
										try
										{
											CS_0024_003C_003E8__locals2.CC1B6A2F.aca7A8A1_0.bfb2AB91_0.method_19(CS_0024_003C_003E8__locals2.int_0, int_, "", CS_0024_003C_003E8__locals2.CC1B6A2F.aca7A8A1_0.gclass8_0);
										}
										catch (Exception exception_2)
										{
											Common.ExportError(null, exception_2);
										}
									})
									{
										Name = CS_0024_003C_003E8__locals2.int_0.ToString()
									};
									aca7A8A1_0.bfb2AB91_0.E2B4308C.Add(thread6);
									Common.Sleep(1.0);
									thread6.Start();
								}
								else
								{
									num15++;
								}
							}
							for (int num16 = 0; num16 < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num16++)
							{
								aca7A8A1_0.bfb2AB91_0.E2B4308C[num16].Join();
							}
						}
						catch (ThreadAbortException ex3)
						{
							if (ex3.ToString().Contains("Thread was being aborted."))
							{
							}
						}
					});
					thread3.IsBackground = true;
					thread3.Start();
					thread3.Join();
				}
				else
				{
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 1)
					{
						for (int num6 = 0; num6 < aca7A8A1_0.bfb2AB91_0.list_0.Count; num6++)
						{
							(aca7A8A1_0.bfb2AB91_0.list_0[num6] as XproxyProxy).resetXProxy();
						}
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 14)
					{
						for (int num7 = 0; num7 < aca7A8A1_0.bfb2AB91_0.F93ADB36.Count; num7++)
						{
							aca7A8A1_0.bfb2AB91_0.F93ADB36[num7].resetOBCProxy();
						}
					}
					Thread thread4 = new Thread((ThreadStart)delegate
					{
						try
						{
							int num8 = 0;
							while (num8 < aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count && !aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								if (Convert.ToBoolean(aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num8].Cells["cChose"].Value))
								{
									if (aca7A8A1_0.bfb2AB91_0.bool_0)
									{
										break;
									}
									if (aca7A8A1_0.bfb2AB91_0.E2B4308C.Count < int_0)
									{
										E10564AE CS_0024_003C_003E8__locals1 = new E10564AE
										{
											D3962509 = this
										};
										if (aca7A8A1_0.bfb2AB91_0.bool_0)
										{
											break;
										}
										CS_0024_003C_003E8__locals1.int_0 = num8++;
										Thread thread5 = new Thread((ThreadStart)delegate
										{
											int num14 = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals1.D3962509.DF99F409);
											try
											{
												CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.method_19(CS_0024_003C_003E8__locals1.int_0, num14, "", CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.gclass8_0);
												Common.FillIndexPossition(ref CS_0024_003C_003E8__locals1.D3962509.DF99F409, num14);
												if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll") || CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.method_92(CS_0024_003C_003E8__locals1.int_0) != "Live" || CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals1.int_0).ToLower().Contains("checkpoint") || CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals1.int_0).ToLower().Contains("invalid username or password") || CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals1.int_0).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
												{
													CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals1.int_0, "cChose", false);
												}
											}
											catch (Exception ex2)
											{
												if (ex2.ToString().Contains("Thread was being aborted."))
												{
													Common.FillIndexPossition(ref CS_0024_003C_003E8__locals1.D3962509.DF99F409, num14);
													if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
													{
														CS_0024_003C_003E8__locals1.D3962509.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals1.int_0, "cChose", false);
													}
												}
											}
										})
										{
											Name = CS_0024_003C_003E8__locals1.int_0.ToString()
										};
										aca7A8A1_0.bfb2AB91_0.E2B4308C.Add(thread5);
										Common.Sleep(1.0);
										thread5.Start();
									}
									else
									{
										if (aca7A8A1_0.bfb2AB91_0.bool_0)
										{
											break;
										}
										if ((SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 7 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 10 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy")))
										{
											for (int num9 = 0; num9 < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num9++)
											{
												aca7A8A1_0.bfb2AB91_0.E2B4308C[num9].Join();
												aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(num9--);
											}
										}
										else if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2)
										{
											for (int num10 = 0; num10 < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num10++)
											{
												aca7A8A1_0.bfb2AB91_0.E2B4308C[num10].Join();
												aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(num10--);
											}
											if (aca7A8A1_0.bfb2AB91_0.bool_0)
											{
												break;
											}
											Interlocked.Increment(ref AE28CC9C);
											if (AE28CC9C >= SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1))
											{
												for (int num11 = 0; num11 < 3; num11++)
												{
													bool_0 = Common.ChangeIP(SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
													if (bool_0)
													{
														break;
													}
												}
												if (!bool_0)
												{
													MessageBoxHelper.Show("Không thê\u0309 đô\u0309i ip!", 2);
													aca7A8A1_0.bfb2AB91_0.bool_0 = true;
													return;
												}
												AE28CC9C = 0;
											}
										}
										else
										{
											for (int num12 = 0; num12 < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num12++)
											{
												if (!aca7A8A1_0.bfb2AB91_0.E2B4308C[num12].IsAlive)
												{
													aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(num12--);
												}
											}
										}
									}
								}
								else
								{
									num8++;
								}
								if (aca7A8A1_0.bfb2AB91_0.bool_0)
								{
									break;
								}
							}
							for (int num13 = 0; num13 < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; num13++)
							{
								aca7A8A1_0.bfb2AB91_0.E2B4308C[num13].Join();
							}
						}
						catch (ThreadAbortException ex)
						{
							if (ex.ToString().Contains("Thread was being aborted."))
							{
							}
						}
					});
					thread4.IsBackground = true;
					thread4.Start();
					thread4.Join();
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_);
			}
			aca7A8A1_0.bfb2AB91_0.E8AFC193();
			aca7A8A1_0.bfb2AB91_0.method_59("stop");
			aca7A8A1_0.bfb2AB91_0.bool_3 = false;
		}

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count && !aca7A8A1_0.bfb2AB91_0.bool_0)
				{
					if (Convert.ToBoolean(aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (aca7A8A1_0.bfb2AB91_0.bool_0 || aca7A8A1_0.bfb2AB91_0.E2B4308C.Count >= int_0)
						{
							break;
						}
						Class26 CS_0024_003C_003E8__locals0 = new Class26
						{
							CC1B6A2F = this
						};
						if (aca7A8A1_0.bfb2AB91_0.bool_0)
						{
							break;
						}
						CS_0024_003C_003E8__locals0.int_0 = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							int int_ = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals0.CC1B6A2F.DF99F409);
							try
							{
								CS_0024_003C_003E8__locals0.CC1B6A2F.aca7A8A1_0.bfb2AB91_0.method_19(CS_0024_003C_003E8__locals0.int_0, int_, "", CS_0024_003C_003E8__locals0.CC1B6A2F.aca7A8A1_0.gclass8_0);
							}
							catch (Exception exception_)
							{
								Common.ExportError(null, exception_);
							}
						})
						{
							Name = CS_0024_003C_003E8__locals0.int_0.ToString()
						};
						aca7A8A1_0.bfb2AB91_0.E2B4308C.Add(thread);
						Common.Sleep(1.0);
						thread.Start();
					}
					else
					{
						num++;
					}
				}
				for (int i = 0; i < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; i++)
				{
					aca7A8A1_0.bfb2AB91_0.E2B4308C[i].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}

		internal void method_1()
		{
			try
			{
				int num = 0;
				while (num < aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count && !aca7A8A1_0.bfb2AB91_0.bool_0)
				{
					if (Convert.ToBoolean(aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (aca7A8A1_0.bfb2AB91_0.bool_0)
						{
							break;
						}
						if (aca7A8A1_0.bfb2AB91_0.E2B4308C.Count < int_0)
						{
							E10564AE CS_0024_003C_003E8__locals0 = new E10564AE
							{
								D3962509 = this
							};
							if (aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								break;
							}
							CS_0024_003C_003E8__locals0.int_0 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								int num2 = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals0.D3962509.DF99F409);
								try
								{
									CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.method_19(CS_0024_003C_003E8__locals0.int_0, num2, "", CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.gclass8_0);
									Common.FillIndexPossition(ref CS_0024_003C_003E8__locals0.D3962509.DF99F409, num2);
									if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll") || CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.method_92(CS_0024_003C_003E8__locals0.int_0) != "Live" || CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("checkpoint") || CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("invalid username or password") || CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
									{
										CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
									}
								}
								catch (Exception ex2)
								{
									if (ex2.ToString().Contains("Thread was being aborted."))
									{
										Common.FillIndexPossition(ref CS_0024_003C_003E8__locals0.D3962509.DF99F409, num2);
										if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
										{
											CS_0024_003C_003E8__locals0.D3962509.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
										}
									}
								}
							})
							{
								Name = CS_0024_003C_003E8__locals0.int_0.ToString()
							};
							aca7A8A1_0.bfb2AB91_0.E2B4308C.Add(thread);
							Common.Sleep(1.0);
							thread.Start();
						}
						else
						{
							if (aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								break;
							}
							if ((SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 7 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 10 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy")))
							{
								for (int i = 0; i < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; i++)
								{
									aca7A8A1_0.bfb2AB91_0.E2B4308C[i].Join();
									aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(i--);
								}
							}
							else if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2)
							{
								for (int j = 0; j < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; j++)
								{
									aca7A8A1_0.bfb2AB91_0.E2B4308C[j].Join();
									aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(j--);
								}
								if (aca7A8A1_0.bfb2AB91_0.bool_0)
								{
									break;
								}
								Interlocked.Increment(ref AE28CC9C);
								if (AE28CC9C >= SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1))
								{
									for (int k = 0; k < 3; k++)
									{
										bool_0 = Common.ChangeIP(SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
										if (bool_0)
										{
											break;
										}
									}
									if (!bool_0)
									{
										MessageBoxHelper.Show("Không thê\u0309 đô\u0309i ip!", 2);
										aca7A8A1_0.bfb2AB91_0.bool_0 = true;
										return;
									}
									AE28CC9C = 0;
								}
							}
							else
							{
								for (int l = 0; l < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; l++)
								{
									if (!aca7A8A1_0.bfb2AB91_0.E2B4308C[l].IsAlive)
									{
										aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(l--);
									}
								}
							}
						}
					}
					else
					{
						num++;
					}
					if (aca7A8A1_0.bfb2AB91_0.bool_0)
					{
						break;
					}
				}
				for (int m = 0; m < aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; m++)
				{
					aca7A8A1_0.bfb2AB91_0.E2B4308C[m].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class24
	{
		public string string_0;

		public Class23 B92ADB11;

		public ThreadStart threadStart_0;

		internal void E9998E98()
		{
			try
			{
				int num = 0;
				while (num < B92ADB11.aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count && !B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
				{
					if (Convert.ToBoolean(B92ADB11.aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
						{
							break;
						}
						if (B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count < B92ADB11.int_0)
						{
							BB324D81 CS_0024_003C_003E8__locals0 = new BB324D81
							{
								class24_0 = this
							};
							if (B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								break;
							}
							CS_0024_003C_003E8__locals0.int_0 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								int num2 = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals0.class24_0.B92ADB11.DF99F409);
								try
								{
									CS_0024_003C_003E8__locals0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_19(CS_0024_003C_003E8__locals0.int_0, num2, CS_0024_003C_003E8__locals0.class24_0.string_0, CS_0024_003C_003E8__locals0.class24_0.B92ADB11.aca7A8A1_0.gclass8_0);
									Common.FillIndexPossition(ref CS_0024_003C_003E8__locals0.class24_0.B92ADB11.DF99F409, num2);
									bool flag = false;
									if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
									{
										flag = true;
									}
									else
									{
										string text = CS_0024_003C_003E8__locals0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_92(CS_0024_003C_003E8__locals0.int_0);
										if (text != "Live")
										{
											flag = true;
										}
										if (!flag)
										{
											string text2 = CS_0024_003C_003E8__locals0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D491BE25(CS_0024_003C_003E8__locals0.int_0).ToLower();
											flag = text2.Contains("checkpoint") || text2.Contains("invalid username or password") || text2.Contains("Proxy chưa ủy quyền!".ToLower()) || text2.Contains("fb block") || text2.Contains("Max Job Today".ToLower());
										}
									}
									if (flag)
									{
										CS_0024_003C_003E8__locals0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
									}
								}
								catch (Exception ex2)
								{
									if (ex2.ToString().Contains("Thread was being aborted."))
									{
										Common.FillIndexPossition(ref CS_0024_003C_003E8__locals0.class24_0.B92ADB11.DF99F409, num2);
										if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
										{
											CS_0024_003C_003E8__locals0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.B034598F(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
										}
									}
								}
							})
							{
								Name = CS_0024_003C_003E8__locals0.int_0.ToString()
							};
							B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Add(thread);
							Common.Sleep(1.0);
							thread.Start();
						}
						else
						{
							if (B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
							{
								break;
							}
							if ((SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 7 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 10 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy")))
							{
								for (int i = 0; i < B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; i++)
								{
									B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[i].Join();
									B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(i--);
								}
							}
							else if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2)
							{
								for (int j = 0; j < B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; j++)
								{
									B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[j].Join();
									B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(j--);
								}
								if (B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
								{
									break;
								}
								Interlocked.Increment(ref B92ADB11.AE28CC9C);
								if (B92ADB11.AE28CC9C >= SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1))
								{
									for (int k = 0; k < 3; k++)
									{
										B92ADB11.bool_0 = Common.ChangeIP(SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
										if (B92ADB11.bool_0)
										{
											break;
										}
									}
									if (!B92ADB11.bool_0)
									{
										MessageBoxHelper.Show("Không thê\u0309 đô\u0309i ip!", 2);
										B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0 = true;
										return;
									}
									B92ADB11.AE28CC9C = 0;
								}
							}
							else
							{
								for (int l = 0; l < B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; l++)
								{
									if (!B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[l].IsAlive)
									{
										B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.RemoveAt(l--);
									}
								}
							}
						}
					}
					else
					{
						num++;
					}
					if (B92ADB11.aca7A8A1_0.bfb2AB91_0.bool_0)
					{
						break;
					}
				}
				for (int m = 0; m < B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C.Count; m++)
				{
					B92ADB11.aca7A8A1_0.bfb2AB91_0.E2B4308C[m].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class25
	{
		public int int_0;

		public int E3BE2AA9;

		public Class24 class24_0;

		internal void method_0()
		{
			int num = 0;
			while (num < class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < E3BE2AA9)
					{
						C4A8D09E CS_0024_003C_003E8__locals0 = new C4A8D09E
						{
							class25_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.FFA5E11B = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class25_0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_86(CS_0024_003C_003E8__locals0.FFA5E11B, Language.GetValue("Đang xo\u0301a Cache Profile..."));
							CS_0024_003C_003E8__locals0.class25_0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_85(CS_0024_003C_003E8__locals0.FFA5E11B);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class25_0.int_0);
						});
						thread.IsBackground = true;
						thread.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class C4A8D09E
	{
		public int FFA5E11B;

		public Class25 class25_0;

		internal void E70487B6()
		{
			class25_0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_86(FFA5E11B, Language.GetValue("Đang xo\u0301a Cache Profile..."));
			class25_0.class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_85(FFA5E11B);
			Interlocked.Decrement(ref class25_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class BB324D81
	{
		public int int_0;

		public Class24 class24_0;

		internal void method_0()
		{
			int num = Common.GetIndexOfPossitionApp(ref class24_0.B92ADB11.DF99F409);
			try
			{
				class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_19(int_0, num, class24_0.string_0, class24_0.B92ADB11.aca7A8A1_0.gclass8_0);
				Common.FillIndexPossition(ref class24_0.B92ADB11.DF99F409, num);
				bool flag = false;
				if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
				{
					flag = true;
				}
				else
				{
					string text = class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.method_92(int_0);
					if (text != "Live")
					{
						flag = true;
					}
					if (!flag)
					{
						string text2 = class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.D491BE25(int_0).ToLower();
						flag = text2.Contains("checkpoint") || text2.Contains("invalid username or password") || text2.Contains("Proxy chưa ủy quyền!".ToLower()) || text2.Contains("fb block") || text2.Contains("Max Job Today".ToLower());
					}
				}
				if (flag)
				{
					class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.B034598F(int_0, "cChose", false);
				}
			}
			catch (Exception ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
					Common.FillIndexPossition(ref class24_0.B92ADB11.DF99F409, num);
					if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
					{
						class24_0.B92ADB11.aca7A8A1_0.bfb2AB91_0.B034598F(int_0, "cChose", false);
					}
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class26
	{
		public int int_0;

		public Class23 CC1B6A2F;

		internal void CC8CEFB1()
		{
			int int_ = Common.GetIndexOfPossitionApp(ref CC1B6A2F.DF99F409);
			try
			{
				CC1B6A2F.aca7A8A1_0.bfb2AB91_0.method_19(int_0, int_, "", CC1B6A2F.aca7A8A1_0.gclass8_0);
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_);
			}
		}
	}

	[CompilerGenerated]
	private sealed class E10564AE
	{
		public int int_0;

		public Class23 D3962509;

		internal void method_0()
		{
			int num = Common.GetIndexOfPossitionApp(ref D3962509.DF99F409);
			try
			{
				D3962509.aca7A8A1_0.bfb2AB91_0.method_19(int_0, num, "", D3962509.aca7A8A1_0.gclass8_0);
				Common.FillIndexPossition(ref D3962509.DF99F409, num);
				if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll") || D3962509.aca7A8A1_0.bfb2AB91_0.method_92(int_0) != "Live" || D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(int_0).ToLower().Contains("checkpoint") || D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(int_0).ToLower().Contains("invalid username or password") || D3962509.aca7A8A1_0.bfb2AB91_0.D491BE25(int_0).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
				{
					D3962509.aca7A8A1_0.bfb2AB91_0.B034598F(int_0, "cChose", false);
				}
			}
			catch (Exception ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
					Common.FillIndexPossition(ref D3962509.DF99F409, num);
					if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
					{
						D3962509.aca7A8A1_0.bfb2AB91_0.B034598F(int_0, "cChose", false);
					}
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class27
	{
		public string string_0;

		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.Contains(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class28
	{
		public string string_0;

		public Func<string, bool> func_0;

		internal bool method_0(string FA0993AA)
		{
			return FA0993AA.Contains(string_0.Substring(string_0.IndexOf('@') - 1, 3)) && FA0993AA.StartsWith(string_0.Substring(0, 1)) && FA0993AA.EndsWith(string_0.Substring(string_0.LastIndexOf('.')));
		}
	}

	[CompilerGenerated]
	private sealed class AF1F989E
	{
		public List<string> CDAD559C;

		internal bool F281359E(string string_0)
		{
			return CDAD559C.Contains(string_0.Split('|')[0]);
		}

		internal bool method_0(string string_0)
		{
			return CDAD559C.Contains(string_0.Split('|')[0]);
		}

		internal bool BC045625(string string_0)
		{
			return CDAD559C.Contains(string_0.Split('|')[0]);
		}
	}

	[CompilerGenerated]
	private sealed class CC26A525
	{
		public fGolike bfb2AB91_0;

		public string D21C8AAB;

		internal void method_0()
		{
			if (!bfb2AB91_0.plTrangThai.Visible)
			{
				bfb2AB91_0.plTrangThai.Visible = true;
			}
		}

		internal void A3195DB0()
		{
			bfb2AB91_0.AE250EB9.Text = D21C8AAB;
		}
	}

	[CompilerGenerated]
	private sealed class Class29
	{
		public string string_0;

		public fGolike F410B2AB;

		internal void F781AD35()
		{
			try
			{
				if (string_0 == "start")
				{
					F410B2AB.plQuanLyThuMuc.Enabled = false;
					DatagridviewHelper.smethod_0(F410B2AB.D030FA3A, bool_0: false);
				}
				else if (string_0 == "stop")
				{
					F410B2AB.plQuanLyThuMuc.Enabled = true;
					DatagridviewHelper.smethod_0(F410B2AB.D030FA3A, bool_0: true);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class30
	{
		public fGolike DE904D9A;

		public int C1266AAB;

		public int BA06A5AC;

		public int CD0FCF99;

		public bool bool_0;

		internal void method_0()
		{
			DE904D9A.method_59("start");
			int num = 0;
			while (num < DE904D9A.D030FA3A.Rows.Count && !DE904D9A.bool_0)
			{
				if (Convert.ToBoolean(DE904D9A.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (C1266AAB < BA06A5AC)
					{
						Class31 CS_0024_003C_003E8__locals0 = new Class31
						{
							class30_0 = this
						};
						Interlocked.Increment(ref C1266AAB);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class30_0.DE904D9A.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang kiểm tra..."));
							switch (CS_0024_003C_003E8__locals0.class30_0.CD0FCF99)
							{
							case 0:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.method_63(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 1:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.method_64(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 2:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.D23C2D97(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 3:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.method_65(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 4:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.E6880C9A(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 5:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.AC879403(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class30_0.bool_0);
								break;
							case 6:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.F93F490D(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class30_0.bool_0);
								break;
							case 7:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.E184843A(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 8:
								CS_0024_003C_003E8__locals0.class30_0.DE904D9A.method_25(CS_0024_003C_003E8__locals0.int_0);
								break;
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class30_0.C1266AAB);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (C1266AAB > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.Sleep(1.0);
			}
			DE904D9A.method_59("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class31
	{
		public int int_0;

		public Class30 class30_0;

		internal void method_0()
		{
			class30_0.DE904D9A.method_86(int_0, Language.GetValue("Đang kiểm tra..."));
			switch (class30_0.CD0FCF99)
			{
			case 0:
				class30_0.DE904D9A.method_63(int_0);
				break;
			case 1:
				class30_0.DE904D9A.method_64(int_0);
				break;
			case 2:
				class30_0.DE904D9A.D23C2D97(int_0);
				break;
			case 3:
				class30_0.DE904D9A.method_65(int_0);
				break;
			case 4:
				class30_0.DE904D9A.E6880C9A(int_0);
				break;
			case 5:
				class30_0.DE904D9A.AC879403(int_0, class30_0.bool_0);
				break;
			case 6:
				class30_0.DE904D9A.F93F490D(int_0, class30_0.bool_0);
				break;
			case 7:
				class30_0.DE904D9A.E184843A(int_0);
				break;
			case 8:
				class30_0.DE904D9A.method_25(int_0);
				break;
			}
			Interlocked.Decrement(ref class30_0.C1266AAB);
		}
	}

	[CompilerGenerated]
	private sealed class Class32
	{
		public fGolike bfb2AB91_0;

		public int int_0;

		public int CE2917A4;

		internal void C1258837()
		{
			bfb2AB91_0.method_59("start");
			int num = 0;
			while (num < bfb2AB91_0.D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (bfb2AB91_0.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < CE2917A4)
					{
						Class33 CS_0024_003C_003E8__locals0 = new Class33
						{
							B1334008 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.B1334008.bfb2AB91_0.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.B1334008.bfb2AB91_0.DBA980B2(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.B1334008.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			bfb2AB91_0.method_59("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class33
	{
		public int int_0;

		public Class32 B1334008;

		internal void B63CC119()
		{
			B1334008.bfb2AB91_0.method_86(int_0, Language.GetValue("Đang kiểm tra..."));
			B1334008.bfb2AB91_0.DBA980B2(int_0);
			Interlocked.Decrement(ref B1334008.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class34
	{
		public int E5AEA61C;

		public int int_0;

		public fGolike D7300FBD;

		internal void method_0()
		{
			int num = 0;
			while (num < D7300FBD.D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(D7300FBD.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (E5AEA61C < int_0)
					{
						Class35 CS_0024_003C_003E8__locals0 = new Class35
						{
							AF3ACA11 = this
						};
						Interlocked.Increment(ref E5AEA61C);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.AF3ACA11.D7300FBD.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang xo\u0301a profile..."));
							CS_0024_003C_003E8__locals0.AF3ACA11.D7300FBD.method_67(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.AF3ACA11.E5AEA61C);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class35
	{
		public int int_0;

		public Class34 AF3ACA11;

		internal void F712869B()
		{
			AF3ACA11.D7300FBD.method_86(int_0, Language.GetValue("Đang xo\u0301a profile..."));
			AF3ACA11.D7300FBD.method_67(int_0);
			Interlocked.Decrement(ref AF3ACA11.E5AEA61C);
		}
	}

	[CompilerGenerated]
	private sealed class Class36
	{
		public fGolike F2842A1C;

		public int int_0;

		public int int_1;

		public string C123AB3E;

		internal void method_0()
		{
			int num = 0;
			while (num < F2842A1C.D030FA3A.RowCount)
			{
				if (Convert.ToBoolean(F2842A1C.method_93(num, "cChose")))
				{
					if (int_0 < int_1)
					{
						Class37 CS_0024_003C_003E8__locals0 = new Class37
						{
							class36_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class36_0.F2842A1C.method_86(CS_0024_003C_003E8__locals0.int_0, "Check profile...");
							CS_0024_003C_003E8__locals0.class36_0.F2842A1C.method_68(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class36_0.C123AB3E);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class36_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class37
	{
		public int int_0;

		public Class36 class36_0;

		internal void method_0()
		{
			class36_0.F2842A1C.method_86(int_0, "Check profile...");
			class36_0.F2842A1C.method_68(int_0, class36_0.C123AB3E);
			Interlocked.Decrement(ref class36_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class38
	{
		public fGolike bfb2AB91_0;

		public int A502321C;

		public int int_0;

		public string string_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < bfb2AB91_0.D030FA3A.Rows.Count)
				{
					if (Convert.ToBoolean(bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (A502321C < int_0)
						{
							Class39 CS_0024_003C_003E8__locals0 = new Class39
							{
								class38_0 = this
							};
							Interlocked.Increment(ref A502321C);
							CS_0024_003C_003E8__locals0.A78A2F3C = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									CS_0024_003C_003E8__locals0.class38_0.bfb2AB91_0.method_72(CS_0024_003C_003E8__locals0.A78A2F3C, CS_0024_003C_003E8__locals0.class38_0.string_0);
									Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class38_0.A502321C);
								}
								catch (Exception ex2)
								{
									Common.ExportError2(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							Common.Sleep(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (A502321C > 0)
				{
					Common.Sleep(1.0);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError2(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class39
	{
		public int A78A2F3C;

		public Class38 class38_0;

		internal void method_0()
		{
			try
			{
				class38_0.bfb2AB91_0.method_72(A78A2F3C, class38_0.string_0);
				Interlocked.Decrement(ref class38_0.A502321C);
			}
			catch (Exception ex)
			{
				Common.ExportError2(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class F1A73F26
	{
		public fGolike bfb2AB91_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < bfb2AB91_0.D030FA3A.Rows.Count)
				{
					if (Convert.ToBoolean(bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Class40 CS_0024_003C_003E8__locals0 = new Class40
							{
								E4B6091A = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals0.int_0 = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = DatagridviewHelper.GetStatusDataGridView(CS_0024_003C_003E8__locals0.E4B6091A.bfb2AB91_0.D030FA3A, CS_0024_003C_003E8__locals0.int_0, "cCookies");
									string text = DatagridviewHelper.GetStatusDataGridView(CS_0024_003C_003E8__locals0.E4B6091A.bfb2AB91_0.D030FA3A, CS_0024_003C_003E8__locals0.int_0, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(FileHelper.GetPathToCurrentFolder() + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										DatagridviewHelper.SetStatusDataGridView(CS_0024_003C_003E8__locals0.E4B6091A.bfb2AB91_0.D030FA3A, CS_0024_003C_003E8__locals0.int_0, "cStatus", Language.GetValue("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.E4B6091A.int_0);
								}
								catch (Exception ex2)
								{
									Common.ExportError2(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							Common.Sleep(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_0 > 0)
				{
					Common.Sleep(1.0);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError2(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class40
	{
		public int int_0;

		public F1A73F26 E4B6091A;

		internal void method_0()
		{
			try
			{
				string input = DatagridviewHelper.GetStatusDataGridView(E4B6091A.bfb2AB91_0.D030FA3A, int_0, "cCookies");
				string text = DatagridviewHelper.GetStatusDataGridView(E4B6091A.bfb2AB91_0.D030FA3A, int_0, "cUid");
				if (text == "")
				{
					text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
				}
				if (File.Exists("backup\\" + text + "\\" + text + ".html"))
				{
					Process.Start(FileHelper.GetPathToCurrentFolder() + "\\backup\\" + text + "\\" + text + ".html");
				}
				else
				{
					DatagridviewHelper.SetStatusDataGridView(E4B6091A.bfb2AB91_0.D030FA3A, int_0, "cStatus", Language.GetValue("Chưa tạo html!"));
				}
				Interlocked.Decrement(ref E4B6091A.int_0);
			}
			catch (Exception ex)
			{
				Common.ExportError2(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class41
	{
		public fGolike DC394006;

		public int int_0;

		public int int_1;

		internal void AB3F78B0()
		{
			DC394006.method_59("start");
			int num = 0;
			while (num < DC394006.D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (DC394006.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(DC394006.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class42 CS_0024_003C_003E8__locals0 = new Class42
						{
							EC0BCDBD = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.EC0BCDBD.DC394006.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.EC0BCDBD.DC394006.method_76(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.EC0BCDBD.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			DC394006.method_59("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class42
	{
		public int int_0;

		public Class41 EC0BCDBD;

		internal void method_0()
		{
			EC0BCDBD.DC394006.method_86(int_0, Language.GetValue("Đang kiểm tra..."));
			EC0BCDBD.DC394006.method_76(int_0);
			Interlocked.Decrement(ref EC0BCDBD.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class A5947F12
	{
		public int int_0;

		public int CAA1F72D;

		public fGolike F2A26B33;

		internal void C198878E()
		{
			F2A26B33.method_59("start");
			int num = 0;
			while (num < F2A26B33.D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (F2A26B33.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(F2A26B33.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < CAA1F72D)
					{
						Class43 CS_0024_003C_003E8__locals0 = new Class43
						{
							F5A1B639 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang ta\u0323o Shortcut..."));
							try
							{
								CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.D030FA3A.Rows[CS_0024_003C_003E8__locals0.int_0].Cells["cId"].Value.ToString();
								string text = CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.D030FA3A.Rows[CS_0024_003C_003E8__locals0.int_0].Cells["cUid"].Value.ToString();
								string text2 = CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.D030FA3A.Rows[CS_0024_003C_003E8__locals0.int_0].Cells["cName"].Value.ToString();
								string string_ = ((text2 == "") ? text : (text2 + "_" + text));
								string text3 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
								if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUsePortable") && Directory.Exists(SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text + "\\Data\\profile"))
								{
									text3 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text + "\\Data\\profile";
								}
								Common.CreateFolder(text3);
								bool flag;
								if (!(flag = CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.method_81(text3, string_)))
								{
									string_ = text;
									flag = CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.method_81(text3, string_);
								}
								if (!flag)
								{
									CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Lô\u0303i ta\u0323o Shortcut!"));
								}
								else
								{
									CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Ta\u0323o Shortcut thành công!"));
								}
							}
							catch
							{
								CS_0024_003C_003E8__locals0.F5A1B639.F2A26B33.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Lỗi!"));
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.F5A1B639.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			F2A26B33.method_59("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class43
	{
		public int int_0;

		public A5947F12 F5A1B639;

		internal void F2118110()
		{
			F5A1B639.F2A26B33.method_86(int_0, Language.GetValue("Đang ta\u0323o Shortcut..."));
			try
			{
				F5A1B639.F2A26B33.D030FA3A.Rows[int_0].Cells["cId"].Value.ToString();
				string text = F5A1B639.F2A26B33.D030FA3A.Rows[int_0].Cells["cUid"].Value.ToString();
				string text2 = F5A1B639.F2A26B33.D030FA3A.Rows[int_0].Cells["cName"].Value.ToString();
				string string_ = ((text2 == "") ? text : (text2 + "_" + text));
				string text3 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
				if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUsePortable") && Directory.Exists(SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text + "\\Data\\profile"))
				{
					text3 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text + "\\Data\\profile";
				}
				Common.CreateFolder(text3);
				bool flag;
				if (!(flag = F5A1B639.F2A26B33.method_81(text3, string_)))
				{
					string_ = text;
					flag = F5A1B639.F2A26B33.method_81(text3, string_);
				}
				if (!flag)
				{
					F5A1B639.F2A26B33.method_86(int_0, Language.GetValue("Lô\u0303i ta\u0323o Shortcut!"));
				}
				else
				{
					F5A1B639.F2A26B33.method_86(int_0, Language.GetValue("Ta\u0323o Shortcut thành công!"));
				}
			}
			catch
			{
				F5A1B639.F2A26B33.method_86(int_0, Language.GetValue("Lỗi!"));
			}
			Interlocked.Decrement(ref F5A1B639.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class44
	{
		public int int_0;

		public int DEB1F8A8;

		public fGolike FE17B928;

		internal void method_0()
		{
			int num = 0;
			while (num < FE17B928.D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(FE17B928.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < DEB1F8A8)
					{
						BC89CA0D CS_0024_003C_003E8__locals0 = new BC89CA0D
						{
							B3BCC120 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.B3BCC120.FE17B928.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang xo\u0301a dữ liệu backup..."));
							CS_0024_003C_003E8__locals0.B3BCC120.FE17B928.method_83(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.B3BCC120.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class BC89CA0D
	{
		public int int_0;

		public Class44 B3BCC120;

		internal void EF95D638()
		{
			B3BCC120.FE17B928.method_86(int_0, Language.GetValue("Đang xo\u0301a dữ liệu backup..."));
			B3BCC120.FE17B928.method_83(int_0);
			Interlocked.Decrement(ref B3BCC120.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class45
	{
		public fGolike bfb2AB91_0;

		public int int_0;

		public int int_1;

		public string string_0;

		internal void method_0()
		{
			int num = 0;
			while (num < bfb2AB91_0.D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						BD3209AF CS_0024_003C_003E8__locals0 = new BD3209AF
						{
							class45_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.CBAAC9B0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class45_0.bfb2AB91_0.method_86(CS_0024_003C_003E8__locals0.CBAAC9B0, "Check backup...");
							CS_0024_003C_003E8__locals0.class45_0.bfb2AB91_0.BD3664B7(CS_0024_003C_003E8__locals0.CBAAC9B0, CS_0024_003C_003E8__locals0.class45_0.string_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class45_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class BD3209AF
	{
		public int CBAAC9B0;

		public Class45 class45_0;

		internal void method_0()
		{
			class45_0.bfb2AB91_0.method_86(CBAAC9B0, "Check backup...");
			class45_0.bfb2AB91_0.BD3664B7(CBAAC9B0, class45_0.string_0);
			Interlocked.Decrement(ref class45_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class46
	{
		public int int_0;

		public int int_1;

		public string string_0;

		public fGolike bfb2AB91_0;

		internal void A6A28229()
		{
			bfb2AB91_0.method_59("start");
			int num = 0;
			while (num < bfb2AB91_0.D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (bfb2AB91_0.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						A9855D2C CS_0024_003C_003E8__locals0 = new A9855D2C
						{
							class46_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.DE8B699B = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class46_0.bfb2AB91_0.method_86(CS_0024_003C_003E8__locals0.DE8B699B, Language.GetValue("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.class46_0.bfb2AB91_0.BE072D08(CS_0024_003C_003E8__locals0.DE8B699B, CS_0024_003C_003E8__locals0.class46_0.string_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class46_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			bfb2AB91_0.method_59("stop");
		}
	}

	[CompilerGenerated]
	private sealed class A9855D2C
	{
		public int DE8B699B;

		public Class46 class46_0;

		internal void method_0()
		{
			class46_0.bfb2AB91_0.method_86(DE8B699B, Language.GetValue("Đang kiểm tra..."));
			class46_0.bfb2AB91_0.BE072D08(DE8B699B, class46_0.string_0);
			Interlocked.Decrement(ref class46_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class47
	{
		public int B72C5D8D;

		public int int_0;

		public fGolike bfb2AB91_0;

		internal void method_0()
		{
			int num = 0;
			while (num < bfb2AB91_0.D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(bfb2AB91_0.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (B72C5D8D < int_0)
					{
						BC04E9B5 CS_0024_003C_003E8__locals0 = new BC04E9B5
						{
							class47_0 = this
						};
						Interlocked.Increment(ref B72C5D8D);
						CS_0024_003C_003E8__locals0.B007A43E = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class47_0.bfb2AB91_0.method_86(CS_0024_003C_003E8__locals0.B007A43E, Language.GetValue("Đang xo\u0301a Cache Profile..."));
							CS_0024_003C_003E8__locals0.class47_0.bfb2AB91_0.method_85(CS_0024_003C_003E8__locals0.B007A43E);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class47_0.B72C5D8D);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class BC04E9B5
	{
		public int B007A43E;

		public Class47 class47_0;

		internal void method_0()
		{
			class47_0.bfb2AB91_0.method_86(B007A43E, Language.GetValue("Đang xo\u0301a Cache Profile..."));
			class47_0.bfb2AB91_0.method_85(B007A43E);
			Interlocked.Decrement(ref class47_0.B72C5D8D);
		}
	}

	[CompilerGenerated]
	private sealed class Class48
	{
		public fGolike A59B231B;

		public JSON_Settings gclass8_0;
	}

	[CompilerGenerated]
	private sealed class Class49
	{
		public int F4A1A7B3;

		public List<int> C184FF1E;

		public Class48 D69CAA8B;

		public ThreadStart AC0434A7;

		internal void method_0()
		{
			try
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						int num = 0;
						while (num < D69CAA8B.A59B231B.D030FA3A.Rows.Count && !D69CAA8B.A59B231B.bool_0)
						{
							if (Convert.ToBoolean(D69CAA8B.A59B231B.D030FA3A.Rows[num].Cells["cChose"].Value))
							{
								if (D69CAA8B.A59B231B.bool_0)
								{
									break;
								}
								if (D69CAA8B.A59B231B.E2B4308C.Count < F4A1A7B3)
								{
									Class50 CS_0024_003C_003E8__locals0 = new Class50
									{
										class49_0 = this
									};
									if (D69CAA8B.A59B231B.bool_0)
									{
										break;
									}
									CS_0024_003C_003E8__locals0.int_0 = num++;
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										int num2 = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals0.class49_0.C184FF1E);
										try
										{
											CS_0024_003C_003E8__locals0.class49_0.D69CAA8B.A59B231B.method_106(CS_0024_003C_003E8__locals0.int_0, num2, CS_0024_003C_003E8__locals0.class49_0.D69CAA8B.gclass8_0);
										}
										catch (Exception)
										{
										}
										Common.FillIndexPossition(ref CS_0024_003C_003E8__locals0.class49_0.C184FF1E, num2);
										CS_0024_003C_003E8__locals0.class49_0.D69CAA8B.A59B231B.B034598F(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
									})
									{
										Name = CS_0024_003C_003E8__locals0.int_0.ToString()
									};
									D69CAA8B.A59B231B.E2B4308C.Add(thread2);
									Common.Sleep(1.0);
									thread2.Start();
								}
								else
								{
									if (D69CAA8B.A59B231B.bool_0)
									{
										break;
									}
									for (int i = 0; i < D69CAA8B.A59B231B.E2B4308C.Count; i++)
									{
										if (!D69CAA8B.A59B231B.E2B4308C[i].IsAlive)
										{
											D69CAA8B.A59B231B.E2B4308C.RemoveAt(i--);
										}
									}
								}
							}
							else
							{
								num++;
							}
							if (D69CAA8B.A59B231B.bool_0)
							{
								break;
							}
						}
						for (int j = 0; j < D69CAA8B.A59B231B.E2B4308C.Count; j++)
						{
							D69CAA8B.A59B231B.E2B4308C[j].Join();
						}
					}
					catch (ThreadAbortException ex)
					{
						if (ex.ToString().Contains("Thread was being aborted."))
						{
						}
					}
				});
				thread.IsBackground = true;
				thread.Start();
				thread.Join();
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_);
			}
			D69CAA8B.A59B231B.E8AFC193();
			D69CAA8B.A59B231B.method_59("stop");
			D69CAA8B.A59B231B.bool_3 = false;
		}

		internal void method_1()
		{
			try
			{
				int num = 0;
				while (num < D69CAA8B.A59B231B.D030FA3A.Rows.Count && !D69CAA8B.A59B231B.bool_0)
				{
					if (Convert.ToBoolean(D69CAA8B.A59B231B.D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (D69CAA8B.A59B231B.bool_0)
						{
							break;
						}
						if (D69CAA8B.A59B231B.E2B4308C.Count < F4A1A7B3)
						{
							Class50 CS_0024_003C_003E8__locals0 = new Class50
							{
								class49_0 = this
							};
							if (D69CAA8B.A59B231B.bool_0)
							{
								break;
							}
							CS_0024_003C_003E8__locals0.int_0 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								int num2 = Common.GetIndexOfPossitionApp(ref CS_0024_003C_003E8__locals0.class49_0.C184FF1E);
								try
								{
									CS_0024_003C_003E8__locals0.class49_0.D69CAA8B.A59B231B.method_106(CS_0024_003C_003E8__locals0.int_0, num2, CS_0024_003C_003E8__locals0.class49_0.D69CAA8B.gclass8_0);
								}
								catch (Exception)
								{
								}
								Common.FillIndexPossition(ref CS_0024_003C_003E8__locals0.class49_0.C184FF1E, num2);
								CS_0024_003C_003E8__locals0.class49_0.D69CAA8B.A59B231B.B034598F(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
							})
							{
								Name = CS_0024_003C_003E8__locals0.int_0.ToString()
							};
							D69CAA8B.A59B231B.E2B4308C.Add(thread);
							Common.Sleep(1.0);
							thread.Start();
						}
						else
						{
							if (D69CAA8B.A59B231B.bool_0)
							{
								break;
							}
							for (int i = 0; i < D69CAA8B.A59B231B.E2B4308C.Count; i++)
							{
								if (!D69CAA8B.A59B231B.E2B4308C[i].IsAlive)
								{
									D69CAA8B.A59B231B.E2B4308C.RemoveAt(i--);
								}
							}
						}
					}
					else
					{
						num++;
					}
					if (D69CAA8B.A59B231B.bool_0)
					{
						break;
					}
				}
				for (int j = 0; j < D69CAA8B.A59B231B.E2B4308C.Count; j++)
				{
					D69CAA8B.A59B231B.E2B4308C[j].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class50
	{
		public int int_0;

		public Class49 class49_0;

		internal void A0A33DA8()
		{
			int num = Common.GetIndexOfPossitionApp(ref class49_0.C184FF1E);
			try
			{
				class49_0.D69CAA8B.A59B231B.method_106(int_0, num, class49_0.D69CAA8B.gclass8_0);
			}
			catch (Exception)
			{
			}
			Common.FillIndexPossition(ref class49_0.C184FF1E, num);
			class49_0.D69CAA8B.A59B231B.B034598F(int_0, "cChose", false);
		}
	}

	[CompilerGenerated]
	private sealed class Class51
	{
		public fGolike E0216037;

		public List<string> A73ADD17;

		internal void method_0()
		{
			try
			{
				string text = "";
				for (int i = 0; i < E0216037.D030FA3A.RowCount; i++)
				{
					text = E0216037.method_93(i, "cGhiChu");
					if (text != "")
					{
						string value = Regex.Match(text, "\\((.*?)\\)", RegexOptions.Singleline).Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						value = Regex.Match(text, "\\[(.*?)\\]").Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						if (text.StartsWith("282-") && text.Split('-').Length > 1)
						{
							text = text.Split('-')[0] + "-" + text.Split('-')[1];
						}
						if (text != "" && !A73ADD17.Contains(text))
						{
							A73ADD17.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class E32D363D
	{
		public fGolike F4045E37;

		public int AB871936;

		public int int_0;

		internal void F01D3400()
		{
			F4045E37.method_59("start");
			int num = 0;
			while (num < F4045E37.D030FA3A.Rows.Count && !F4045E37.bool_0)
			{
				if (Convert.ToBoolean(F4045E37.D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (AB871936 < int_0)
					{
						Class52 CS_0024_003C_003E8__locals0 = new Class52
						{
							e32D363D_0 = this
						};
						Interlocked.Increment(ref AB871936);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang kiểm tra..."));
							try
							{
								string text = CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_93(CS_0024_003C_003E8__locals0.int_0, "cEmail");
								string text2 = CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_93(CS_0024_003C_003E8__locals0.int_0, "cPassMail");
								if (text == "" || text2 == "")
								{
									CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Không tìm thấy mail!"));
									return;
								}
								string text3 = CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_32(6, text, text2, 0, "", "");
								if (text3 != "" && text3 != "fail")
								{
									CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.BC0C40BD(CS_0024_003C_003E8__locals0.int_0, "cEmail", text3, "email");
									CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Lấy thành công!"));
								}
								else
								{
									CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Lấy thất bại!"));
								}
							}
							catch (Exception ex)
							{
								MessageBoxHelper.Show(ex.ToString());
								CS_0024_003C_003E8__locals0.e32D363D_0.F4045E37.method_86(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Lỗi!"));
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.e32D363D_0.AB871936);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			_ = Environment.TickCount;
			while (AB871936 > 0)
			{
				Common.Sleep(1.0);
			}
			F4045E37.method_59("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class52
	{
		public int int_0;

		public E32D363D e32D363D_0;

		internal void DD98B986()
		{
			e32D363D_0.F4045E37.method_86(int_0, Language.GetValue("Đang kiểm tra..."));
			try
			{
				string text = e32D363D_0.F4045E37.method_93(int_0, "cEmail");
				string text2 = e32D363D_0.F4045E37.method_93(int_0, "cPassMail");
				if (text == "" || text2 == "")
				{
					e32D363D_0.F4045E37.method_86(int_0, Language.GetValue("Không tìm thấy mail!"));
					return;
				}
				string text3 = e32D363D_0.F4045E37.method_32(6, text, text2, 0, "", "");
				if (text3 != "" && text3 != "fail")
				{
					e32D363D_0.F4045E37.BC0C40BD(int_0, "cEmail", text3, "email");
					e32D363D_0.F4045E37.method_86(int_0, Language.GetValue("Lấy thành công!"));
				}
				else
				{
					e32D363D_0.F4045E37.method_86(int_0, Language.GetValue("Lấy thất bại!"));
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.Show(ex.ToString());
				e32D363D_0.F4045E37.method_86(int_0, Language.GetValue("Lỗi!"));
			}
			Interlocked.Decrement(ref e32D363D_0.AB871936);
		}
	}

	[CompilerGenerated]
	private sealed class Class53
	{
		public fGolike bfb2AB91_0;

		public List<string> list_0;

		internal void method_0()
		{
			try
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < bfb2AB91_0.D030FA3A.RowCount; i++)
				{
					text = bfb2AB91_0.method_93(i, "cStatus").Trim();
					if (text != "")
					{
						text2 = Regex.Match(text, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
						if (text2 != "")
						{
							text = text.Replace(text2, "").Trim();
						}
						text2 = Regex.Match(text, "\\[(.*?)\\]").Value;
						if (text2 != "")
						{
							text = text.Replace(text2, "").Trim();
						}
						if (text != "" && !list_0.Contains(text))
						{
							list_0.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		internal void method_1()
		{
			try
			{
				string text = "";
				for (int i = 0; i < bfb2AB91_0.D030FA3A.RowCount; i++)
				{
					text = bfb2AB91_0.method_93(i, "cInfo");
					if (!text.Equals("") && !list_0.Contains(text))
					{
						list_0.Add(text);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class D12F1910
	{
		public string string_0;

		public object EA9D1A3E;

		public fGolike D53135A3;

		internal void method_0()
		{
			string text = string_0;
			string text2 = text;
			if (text2 == null)
			{
				return;
			}
			switch (text2.Length)
			{
			case 7:
				if (text2 == "jobType")
				{
					EA9D1A3E = D53135A3.F5303017();
				}
				break;
			case 9:
				switch (text2[0])
				{
				case 't':
					if (text2 == "txtApiKey")
					{
						EA9D1A3E = D53135A3.FFA8ECA5.Text.Trim();
					}
					break;
				case 'n':
					if (text2 == "nudThread")
					{
						EA9D1A3E = D53135A3.nudThread.Value;
					}
					break;
				}
				break;
			case 10:
				if (text2 == "nudDelayTo")
				{
					EA9D1A3E = D53135A3.nudDelayTo.Value;
				}
				break;
			case 11:
				if (text2 == "cbbChangeIP")
				{
					EA9D1A3E = D53135A3.cbbChangeIP.SelectedIndex;
				}
				break;
			case 12:
				switch (text2[3])
				{
				case 'M':
					if (text2 == "nudMaxChrome")
					{
						EA9D1A3E = D53135A3.EDA3E782.Value;
					}
					break;
				case 'B':
					if (!(text2 == "ckbBreakTime"))
					{
						if (text2 == "nudBreakTime")
						{
							EA9D1A3E = D53135A3.nudBreakTime.Value;
						}
					}
					else
					{
						EA9D1A3E = D53135A3.ckbBreakTime.Checked;
					}
					break;
				case 'C':
					if (text2 == "cbbCheDoChay")
					{
						EA9D1A3E = D53135A3.cbbCheDoChay.SelectedIndex;
					}
					break;
				case 'D':
					if (text2 == "nudDelayFrom")
					{
						EA9D1A3E = D53135A3.nudDelayFrom.Value;
					}
					break;
				case 'U':
					if (text2 == "ckbUnlock956")
					{
						EA9D1A3E = D53135A3.ckbUnlock956.Checked;
					}
					break;
				case 'T':
					if (text2 == "cbbTypeLogin")
					{
						EA9D1A3E = D53135A3.cbbTypeLogin.SelectedIndex;
					}
					break;
				}
				break;
			case 14:
				switch (text2[3])
				{
				case 'M':
					if (text2 == "nudMaxJobToday")
					{
						EA9D1A3E = D53135A3.nudMaxJobToday.Value;
					}
					break;
				case 'D':
					if (text2 == "nudDelayGetJob")
					{
						EA9D1A3E = D53135A3.FFAB18BE.method_1().int_0;
					}
					break;
				case 'F':
					if (text2 == "cbbFacebookWeb")
					{
						EA9D1A3E = D53135A3.cbbFacebookWeb.SelectedIndex;
					}
					break;
				case 'H':
					if (text2 == "ckbHideBrowser")
					{
						EA9D1A3E = D53135A3.FF16D4B5.Checked;
					}
					break;
				}
				break;
			case 15:
				switch (text2[0])
				{
				case 'n':
					if (text2 == "nudBreakTimeJob")
					{
						EA9D1A3E = D53135A3.nudBreakTimeJob.Value;
					}
					break;
				case 'c':
					if (text2 == "cbbTypeGetToken")
					{
						EA9D1A3E = D53135A3.DE11733F.SelectedIndex;
					}
					break;
				}
				break;
			case 20:
				switch (text2[0])
				{
				case 'n':
					if (text2 == "nudDelayOpenChromeTo")
					{
						EA9D1A3E = D53135A3.DDBC7438.Value;
					}
					break;
				case 'c':
					if (text2 == "ckbShowImageInteract")
					{
						EA9D1A3E = D53135A3.ckbShowImageInteract.Checked;
					}
					break;
				}
				break;
			case 21:
				if (text2 == "nudMaxJobFailLienTiep")
				{
					EA9D1A3E = D53135A3.BA05D285.Value;
				}
				break;
			case 22:
				if (text2 == "nudDelayOpenChromeFrom")
				{
					EA9D1A3E = D53135A3.C481F21A.Value;
				}
				break;
			case 8:
			case 13:
			case 16:
			case 17:
			case 18:
			case 19:
				break;
			}
		}
	}

	[CompilerGenerated]
	private sealed class ED91F233
	{
		public Control control_0;

		public MethodInvoker D4262598;

		internal void method_0()
		{
			try
			{
				Class54 CS_0024_003C_003E8__locals0 = new Class54
				{
					ed91F233_0 = this,
					string_0 = control_0.Text
				};
				control_0.Invoke((MethodInvoker)delegate
				{
					control_0.Enabled = false;
				});
				CS_0024_003C_003E8__locals0.int_0 = 5;
				CS_0024_003C_003E8__locals0.E6007922 = Environment.TickCount;
				while ((Environment.TickCount - CS_0024_003C_003E8__locals0.E6007922) / 1000 - CS_0024_003C_003E8__locals0.int_0 < 0)
				{
					control_0.Invoke((MethodInvoker)delegate
					{
						CS_0024_003C_003E8__locals0.ed91F233_0.control_0.Text = "Đợi " + (CS_0024_003C_003E8__locals0.int_0 - (Environment.TickCount - CS_0024_003C_003E8__locals0.E6007922) / 1000) + "s...";
					});
					Common.Sleep(0.5);
				}
				control_0.Invoke((MethodInvoker)delegate
				{
					CS_0024_003C_003E8__locals0.ed91F233_0.control_0.Text = CS_0024_003C_003E8__locals0.string_0;
					CS_0024_003C_003E8__locals0.ed91F233_0.control_0.Enabled = true;
				});
			}
			catch (Exception)
			{
			}
		}

		internal void method_1()
		{
			control_0.Enabled = false;
		}
	}

	[CompilerGenerated]
	private sealed class Class54
	{
		public int int_0;

		public int E6007922;

		public string string_0;

		public ED91F233 ed91F233_0;

		internal void method_0()
		{
			ed91F233_0.control_0.Text = "Đợi " + (int_0 - (Environment.TickCount - E6007922) / 1000) + "s...";
		}

		internal void method_1()
		{
			ed91F233_0.control_0.Text = string_0;
			ed91F233_0.control_0.Enabled = true;
		}
	}

	[CompilerGenerated]
	private sealed class Class55
	{
		public int F4A2D21D;

		public fGolike bfb2AB91_0;
	}

	[CompilerGenerated]
	private sealed class Class56
	{
		public int AFBE3422;

		public Class55 class55_0;

		internal void FD33FB39()
		{
			class55_0.bfb2AB91_0.method_86(AFBE3422, Language.GetValue("Đang xo\u0301a profile..."));
			class55_0.bfb2AB91_0.method_67(AFBE3422);
			Interlocked.Decrement(ref class55_0.F4A2D21D);
		}
	}

	private bool bool_0;

	private JSON_Settings gclass8_0;

	private GClass18 FFAB18BE;

	private List<Thread> E2B4308C = null;

	private List<GClass3> list_0 = null;

	private List<OBCProxy> F93ADB36 = null;

	private Dictionary<string, List<string>> dictionary_0 = null;

	private Dictionary<string, List<string>> dictionary_1 = null;

	private Dictionary<string, List<string>> E23B4A9D = null;

	private Dictionary<string, List<string>> dictionary_2 = null;

	private Dictionary<string, List<string>> D683B016 = null;

	private Dictionary<string, List<string>> dictionary_3 = null;

	private Dictionary<string, List<string>> DBA18A3F = null;

	private Dictionary<string, List<string>> E1B02C9B = null;

	private Dictionary<string, List<string>> dictionary_4 = null;

	private Dictionary<string, List<string>> E895F516 = null;

	private Dictionary<string, List<string>> A004CC2C = null;

	private Dictionary<string, List<string>> dictionary_5 = null;

	private Dictionary<string, List<string>> AD043507 = null;

	private Dictionary<string, List<string>> dictionary_6 = null;

	private Dictionary<string, List<string>> dictionary_7 = null;

	private Dictionary<string, List<string>> F425F288 = null;

	private Dictionary<string, List<string>> dictionary_8 = null;

	private Dictionary<string, List<string>> dictionary_9 = null;

	private Dictionary<string, List<string>> E1B23AB3 = null;

	private Dictionary<string, List<string>> EA2797A9 = null;

	private Dictionary<string, List<string>> FB142A84 = null;

	private Dictionary<string, List<string>> A8BA2C20 = null;

	private Dictionary<string, List<string>> B9A41D39 = null;

	private Dictionary<string, List<string>> dictionary_10 = null;

	private Dictionary<string, List<string>> FE8A1487 = null;

	private Dictionary<string, List<string>> dictionary_11 = null;

	private Dictionary<string, List<string>> dictionary_12 = null;

	private Dictionary<string, List<string>> A19F8027 = null;

	private Dictionary<string, List<string>> D9B53233 = null;

	private Dictionary<string, List<string>> dictionary_13 = null;

	private Dictionary<string, List<string>> F3B2F19D = null;

	private Dictionary<string, List<string>> C8327704 = null;

	private Dictionary<string, List<string>> C00CDC8B = null;

	private Dictionary<string, List<string>> dictionary_14 = null;

	private Dictionary<string, List<string>> dictionary_15 = null;

	private Dictionary<string, List<string>> dictionary_16 = null;

	private Dictionary<string, List<string>> dictionary_17 = null;

	private Dictionary<string, List<string>> dictionary_18 = null;

	private Dictionary<string, List<string>> dictionary_19 = null;

	private Dictionary<string, Dictionary<string, List<string>>> B2BDD2A9 = null;

	private Dictionary<string, List<string>> dictionary_20 = null;

	private Dictionary<string, List<string>> dictionary_21 = null;

	private Dictionary<string, List<string>> dictionary_22 = null;

	private Dictionary<string, List<string>> dictionary_23 = null;

	private Dictionary<string, List<string>> C923A3A2 = null;

	private Dictionary<string, List<string>> dictionary_24 = null;

	private Dictionary<string, Dictionary<string, int>> E02E651E = null;

	private Dictionary<string, List<string>> dictionary_25 = null;

	private object AF386606 = new object();

	private object object_0 = new object();

	private List<string> list_1 = new List<string>();

	private Dictionary<string, List<string>> dictionary_26 = new Dictionary<string, List<string>>();

	private object object_1 = new object();

	private object CF220819 = new object();

	private int int_0 = -1;

	private bool bool_1 = true;

	private object CDBB2C83 = new object();

	private object object_2 = new object();

	private object object_3 = new object();

	private object object_4 = new object();

	private object BF971D0D = new object();

	private int int_1 = -1;

	private bool bool_2 = true;

	private bool bool_3 = false;

	private List<string> list_2 = new List<string>();

	private bool bool_4 = false;

	private int int_2 = 0;

	private List<CheckBox> list_3 = null;

	public object BF286719 = new object();

	public int int_3 = 0;

	public object D685EAA7 = new object();

	private int BFACE4AB = 0;

	private Dictionary<int, JobGolikeHepler> dictionary_27 = new Dictionary<int, JobGolikeHepler>();

	private IContainer icontainer_0 = null;

	public static string string_0 = "";

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button C1931ABB;

	private Button btnMaximize;

	private Button btnClose;

	private BunifuCustomLabel bunifuCustomLabel1;

	private MenuStrip menuStrip1;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem BFB97634;

	private ToolStripMenuItem C385F93D;

	private ToolStripMenuItem B615D829;

	private ToolStripMenuItem C52A61A1;

	private ToolStripMenuItem tokenToolStripMenuItem;

	private ToolStripMenuItem cookieToolStripMenuItem;

	private ToolStripMenuItem uidPassToolStripMenuItem;

	private ToolStripMenuItem D29578BE;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem checkCookieToolStripMenuItem;

	private ToolStripMenuItem FD2AC222;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem passToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem mnuChucNang;

	private ToolStripMenuItem BA1A38BA;

	private ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

	private ToolStripMenuItem EC2D66B3;

	private ToolStripMenuItem E8AA4812;

	private ToolStripMenuItem mailToolStripMenuItem;

	private ToolStripMenuItem EDBEA69E;

	private ToolStripMenuItem fAToolStripMenuItem;

	private ToolStripMenuItem tinhTrangToolStripMenuItem;

	private ToolStripMenuItem locTrungToolStripMenuItem;

	private ToolStripMenuItem uidPass2FaToolStripMenuItem;

	private BunifuDragControl bunifuDragControl_1;

	private ToolTip A22FCD01;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ToolStripMenuItem B831D839;

	private ToolStripMenuItem proxyToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_10;

	private Panel plTrangThai;

	private Label AE250EB9;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem checkAvatarToolStripMenuItem;

	private ToolStripMenuItem checkProxyToolStripMenuItem;

	private ToolStripMenuItem checkProfileToolStripMenuItem1;

	private ToolStripMenuItem C4973C30;

	private ToolStripMenuItem EA9F931E;

	private ToolStripMenuItem A023B3BA;

	private ToolStripMenuItem A19CDB1C;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem checkHotmailToolStripMenuItem;

	private ToolStripMenuItem checkProxyToolStripMenuItem1;

	private ToolStripMenuItem lToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem DF895BAD;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem B02B2108;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem emailPassMailMailKpToolStripMenuItem;

	private StatusStrip miniToolStrip;

	private ToolStripStatusLabel toolStripStatusLabel4;

	private ToolStripStatusLabel A0976198;

	private ToolStripStatusLabel F0AC1D35;

	private ToolStripStatusLabel lblCountSelect;

	private ToolStripStatusLabel AE8CEF20;

	private ToolStripStatusLabel lblCountTotal;

	private Button metroButton1;

	private Panel A7A6E116;

	private Button C60C5426;

	private ComboBox AE25A29C;

	private BunifuCustomTextbox AA21FF22;

	private Panel plQuanLyThuMuc;

	private Button btnLoadAcc;

	private Label FE9A040E;

	private Button btnEditFile;

	private Button button9;

	private Button C9344F86;

	private Label label2;

	private Button AddFileAccount;

	private ComboBox D68F8BB7;

	private ComboBox EDBCFD26;

	private Panel B68285B2;

	private StatusStrip AC8B928D;

	private ToolStripMenuItem C1266B0F;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripMenuItem toolStripMenuItem_16;

	private ToolStripMenuItem toolStripMenuItem_17;

	private ToolStripMenuItem C90731BD;

	private ToolStripMenuItem F73AFA39;

	private ToolStripMenuItem getTokenEAAAAUBToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_18;

	private ToolStripMenuItem checkStatusXproxyToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_19;

	private ToolStripMenuItem toolStripMenuItem_20;

	private ToolStripMenuItem A51EC48F;

	private ToolStripMenuItem C8B5958B;

	private ToolStripMenuItem toolStripMenuItem1;

	private GroupBox groupBox1;

	private LinkLabel lblUnlock956;

	private CheckBox ckbUnlock956;

	private TextBox FFA8ECA5;

	private Label DF92EF15;

	private GroupBox FCAD272E;

	private CheckBox ckbSad;

	private CheckBox ckbCare;

	private CheckBox ckbWow;

	private CheckBox ckbLove;

	private CheckBox ckbAngry;

	private CheckBox ckbHaha;

	private CheckBox ckbLike;

	private Button button2;

	private Button button1;

	private Button btnInteract;

	private CheckBox ckbFollow;

	private CheckBox ckbComment;

	private CheckBox ckbShare;

	private CheckBox C69FE504;

	private CheckBox ckbLikeComment;

	private CheckBox ckbJoinGroup;

	private CheckBox ckbCheckAll;

	private ComboBox DE11733F;

	private Label label5;

	private Button F52CE993;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudMaxJobToday;

	private NumericUpDown BA05D285;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label13;

	private Label label12;

	private Label E13363B0;

	private Label label3;

	private Label label11;

	private Label BA00D8A9;

	private GroupBox grCauHinhChrome;

	private NumericUpDown C481F21A;

	private Label label20;

	private Button button6;

	private Label label29;

	private Button E8A87D36;

	private CheckBox FF16D4B5;

	private CheckBox ckbShowImageInteract;

	private Label B38D3A0B;

	private ComboBox cbbTypeLogin;

	private Label ADB609AA;

	private ComboBox cbbFacebookWeb;

	private ComboBox cbbChangeIP;

	private Label label9;

	private NumericUpDown DDBC7438;

	public DataGridView D030FA3A;

	private DataGridViewCheckBoxColumn B03820BB;

	private DataGridViewTextBoxColumn D0BA988C;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cToken;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn cEmail;

	private DataGridViewTextBoxColumn cEmail2;

	private DataGridViewTextBoxColumn cPhone;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cFollow;

	private DataGridViewTextBoxColumn cFriend;

	private DataGridViewTextBoxColumn A1910C2B;

	private DataGridViewTextBoxColumn cPage;

	private DataGridViewTextBoxColumn cPagePro5;

	private DataGridViewTextBoxColumn cBirthday;

	private DataGridViewTextBoxColumn cGender;

	private DataGridViewTextBoxColumn BF07A8B2;

	private DataGridViewTextBoxColumn cMailRecovery;

	private DataGridViewTextBoxColumn cPassMail;

	private DataGridViewTextBoxColumn cBackup;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cUseragent;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cDateCreateAcc;

	private DataGridViewTextBoxColumn cAvatar;

	private DataGridViewTextBoxColumn cProfile;

	private DataGridViewTextBoxColumn cThuMuc;

	private DataGridViewTextBoxColumn C3840526;

	private DataGridViewTextBoxColumn cInfo;

	private DataGridViewTextBoxColumn EF902E9F;

	private DataGridViewTextBoxColumn cStatus282;

	private DataGridViewTextBoxColumn B11E23A8;

	private DataGridViewTextBoxColumn cHometown;

	private DataGridViewTextBoxColumn cCurrentCity;

	private DataGridViewTextBoxColumn AEAE4632;

	private DataGridViewTextBoxColumn EC8E7E16;

	private DataGridViewTextBoxColumn A78524B2;

	private DataGridViewTextBoxColumn cWallPosts;

	private DataGridViewTextBoxColumn D5AC983B;

	private DataGridViewTextBoxColumn cJob;

	private DataGridViewTextBoxColumn cStatus;

	private ToolStripMenuItem ED10C803;

	private ToolStripMenuItem checkProfileToolStripMenuItem;

	private ToolStripMenuItem EB88070A;

	private ToolStripMenuItem FFB9D70A;

	private ToolStripMenuItem F18F9E83;

	private ToolStripMenuItem E80102B9;

	private Button btnHienCaiDat;

	private ComboBox cbbCheDoChay;

	private Label label10;

	private NumericUpDown EDA3E782;

	private Label label16;

	private ToolStripMenuItem checkGolikeToolStripMenuItem;

	private NumericUpDown nudThread;

	private Label label17;

	private NumericUpDown nudDelayGetJob;

	private Label label18;

	private ToolStripStatusLabel CB82F694;

	private ToolStripStatusLabel B6218EA3;

	private Label label19;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private ToolStripStatusLabel lblCountChrome;

	private NumericUpDown nudBreakTimeJob;

	private Label label22;

	private CheckBox ckbBreakTime;

	private NumericUpDown nudBreakTime;

	private Label label24;

	private Panel AB39C701;

	public fGolike()
	{
		InitializeComponent();
		CB9C2737();
		AA21FF22.B992B8A4();
	}

	private void CB9C2737()
	{
		Language.SetLanguage(this);
		Language.LangCtmsAcc(ctmsAcc);
	}

	protected override void OnLoad(EventArgs CFB0D5A8)
	{
		Application.Idle += method_0;
	}

	private void method_0(object sender, EventArgs e)
	{
		Application.Idle -= method_0;
		method_1();
		method_98();
		method_2(1);
		method_3();
		menuStrip1.Cursor = Cursors.Hand;
		list_3 = new List<CheckBox>
		{
			ckbLike, ckbLove, ckbCare, ckbHaha, ckbWow, ckbSad, ckbAngry, ckbFollow, C69FE504, ckbJoinGroup,
			ckbLikeComment, ckbComment, ckbShare
		};
		method_4();
		method_112(null, null);
		ckbUnlock956_CheckedChanged(null, null);
		ckbBreakTime_CheckedChanged(null, null);
		FFAB18BE = new GClass18();
	}

	private void method_1()
	{
		Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "cUid", "UID" },
			{
				"cPassword",
				Language.GetValue("Mật khẩu")
			},
			{
				"cName",
				Language.GetValue("Tên")
			},
			{
				"cBirthday",
				Language.GetValue("Ngày sinh")
			},
			{
				"cGender",
				Language.GetValue("Giới tính")
			},
			{ "cToken", "Token" },
			{ "cCookies", "Cookie" },
			{ "cEmail", "Email" },
			{ "cPassMail", "Pass email" },
			{ "cFa2", "2FA" },
			{
				"cGhiChu",
				Language.GetValue("Ghi chu\u0301")
			},
			{
				"cInteractEnd",
				Language.GetValue("Tương ta\u0301c cuô\u0301i")
			}
		};
		AE25A29C.DataSource = new BindingSource(dataSource, null);
		AE25A29C.ValueMember = "Key";
		AE25A29C.DisplayMember = "Value";
	}

	private void method_2(int int_4 = -1)
	{
		bool_1 = false;
		DataTable dataSource = CommonSQL.C6B3348F(CAB18A83: true);
		D68F8BB7.DataSource = dataSource;
		D68F8BB7.ValueMember = "id";
		D68F8BB7.DisplayMember = "name";
		if (int_4 != -1 && D68F8BB7.Items.Count >= int_4)
		{
			D68F8BB7.SelectedIndex = int_4;
		}
		else if (D68F8BB7.Items.Count == 2)
		{
			D68F8BB7.SelectedIndex = -1;
		}
		bool_1 = true;
	}

	private void method_3(List<string> list_4 = null)
	{
		try
		{
			DataTable dataSource = CommonSQL.smethod_6(list_4);
			EDBCFD26.DataSource = dataSource;
			EDBCFD26.ValueMember = "id";
			EDBCFD26.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void method_4()
	{
		gclass8_0 = new JSON_Settings("golike");
		FFA8ECA5.Text = gclass8_0.GetValue("txtApiKey");
		nudDelayFrom.Value = ((gclass8_0.GetValueInt("nudDelayFrom", 10) < 10) ? 10 : gclass8_0.GetValueInt("nudDelayFrom", 10));
		nudDelayTo.Value = ((gclass8_0.GetValueInt("nudDelayTo", 10) < 10) ? 10 : gclass8_0.GetValueInt("nudDelayTo", 10));
		BA05D285.Value = gclass8_0.GetValueInt("nudMaxJobFailLienTiep", 5);
		nudMaxJobToday.Value = gclass8_0.GetValueInt("nudMaxJobToday", 100);
		nudDelayGetJob.Value = ((gclass8_0.GetValueInt("nudDelayGetJob", 5) < 5) ? 5 : gclass8_0.GetValueInt("nudDelayGetJob", 5));
		DE11733F.SelectedIndex = gclass8_0.GetValueInt("cbbTypeGetToken");
		cbbCheDoChay.SelectedIndex = gclass8_0.GetValueInt("cbbCheDoChay");
		ckbUnlock956.Checked = gclass8_0.GetValueBool("ckbUnlock956");
		ckbBreakTime.Checked = gclass8_0.GetValueBool("ckbBreakTime");
		nudBreakTimeJob.Value = gclass8_0.GetValueInt("nudBreakTimeJob", 10);
		nudBreakTime.Value = gclass8_0.GetValueInt("nudBreakTime", 60);
		List<string> list = gclass8_0.GetValue("jobType").Split(',').ToList();
		for (int i = 0; i < list_3.Count; i++)
		{
			list_3[i].Checked = list.Contains(list_3[i].Text);
		}
		nudThread.Value = gclass8_0.GetValueInt("nudThread", 10);
		EDA3E782.Value = gclass8_0.GetValueInt("nudMaxChrome", 10);
		ckbShowImageInteract.Checked = gclass8_0.GetValueBool("ckbShowImageInteract");
		FF16D4B5.Checked = gclass8_0.GetValueBool("ckbHideBrowser");
		C481F21A.Value = gclass8_0.GetValueInt("nudDelayOpenChromeFrom", 1);
		DDBC7438.Value = gclass8_0.GetValueInt("nudDelayOpenChromeTo", 1);
		cbbTypeLogin.SelectedIndex = gclass8_0.GetValueInt("cbbTypeLogin", 3);
		cbbFacebookWeb.SelectedIndex = gclass8_0.GetValueInt("cbbFacebookWeb");
		cbbChangeIP.SelectedIndex = gclass8_0.GetValueInt("cbbChangeIP", 1);
		if (gclass8_0.GetValueBool("hideSettings"))
		{
			C8183AA3(null, null);
		}
	}

	private void method_5()
	{
		try
		{
			gclass8_0.GetJson("txtApiKey", FFA8ECA5.Text);
			gclass8_0.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gclass8_0.GetJson("nudDelayTo", nudDelayTo.Value);
			gclass8_0.GetJson("nudMaxJobFailLienTiep", BA05D285.Value);
			gclass8_0.GetJson("nudMaxJobToday", nudMaxJobToday.Value);
			gclass8_0.GetJson("nudDelayGetJob", nudDelayGetJob.Value);
			gclass8_0.GetJson("cbbTypeGetToken", DE11733F.SelectedIndex);
			gclass8_0.GetJson("cbbCheDoChay", cbbCheDoChay.SelectedIndex);
			gclass8_0.GetJson("ckbUnlock956", ckbUnlock956.Checked);
			gclass8_0.GetJson("ckbBreakTime", ckbBreakTime.Checked);
			gclass8_0.GetJson("nudBreakTimeJob", nudBreakTimeJob.Value);
			gclass8_0.GetJson("nudBreakTime", nudBreakTime.Value);
			string text = F5303017();
			gclass8_0.GetJson("jobType", text);
			gclass8_0.GetJson("nudThread", nudThread.Value);
			gclass8_0.GetJson("nudMaxChrome", EDA3E782.Value);
			gclass8_0.GetJson("ckbShowImageInteract", ckbShowImageInteract.Checked);
			gclass8_0.GetJson("ckbHideBrowser", FF16D4B5.Checked);
			gclass8_0.GetJson("nudDelayOpenChromeFrom", C481F21A.Value);
			gclass8_0.GetJson("nudDelayOpenChromeTo", DDBC7438.Value);
			gclass8_0.GetJson("cbbTypeLogin", cbbTypeLogin.SelectedIndex);
			gclass8_0.GetJson("cbbFacebookWeb", cbbFacebookWeb.SelectedIndex);
			gclass8_0.GetJson("cbbChangeIP", cbbChangeIP.SelectedIndex);
			gclass8_0.method_7();
		}
		catch (Exception)
		{
		}
	}

	private void B92415BB(object sender, EventArgs e)
	{
		method_5();
		Close();
	}

	private void btnMaximize_Click(object sender, EventArgs e)
	{
		this.F128E894();
	}

	private void C1931ABB_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	public void DDA41599(object sender, EventArgs e)
	{
		string text = "";
		if (D68F8BB7.SelectedValue != null)
		{
			text = D68F8BB7.SelectedValue.ToString();
		}
		method_2();
		if (text != "999999" && text != "-1")
		{
			int_0 = -1;
			D68F8BB7.SelectedValue = text;
			return;
		}
		bool_1 = false;
		D68F8BB7.SelectedValue = text;
		bool_1 = true;
		method_3(fChonThuMuc.DE35F309);
	}

	private List<string> method_6()
	{
		List<string> result = null;
		try
		{
			string text = D68F8BB7.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				result = ((text2 == "999999") ?  CollectionHelper.CloneList(fChonThuMuc.DE35F309) : new List<string> { D68F8BB7.SelectedValue.ToString() });
			}
		}
		catch
		{
		}
		return result;
	}

	private void EA21F124(List<string> C40A7623 = null, string string_1 = "")
	{
		try
		{
			D030FA3A.Rows.Clear();
			if (string_1 == "[Tất cả tình trạng]" || string_1 == Language.GetValue("[Tất cả tình trạng]"))
			{
				string_1 = "";
			}
			DataTable dataTable_ = CommonSQL.C8978B14(C40A7623, string_1);
			method_7(dataTable_);
		}
		catch (Exception)
		{
		}
	}

	private void method_7(DataTable dataTable_0)
	{
		DatagridviewHelper.smethod_6(D030FA3A, dataTable_0);
		method_61(0);
		method_95();
		method_60();
	}

	private void EF0CEA02(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (D68F8BB7.SelectedValue != null)
			{
				text = D68F8BB7.SelectedValue.ToString();
			}
			fImportAccount fC937A = new fImportAccount(text);
			Common.ShowForm(fC937A);
			if (fC937A.bool_0 || fC937A.D0294328)
			{
				method_2();
				int_0 = -1;
				if (fC937A.bool_0)
				{
					D68F8BB7.SelectedValue = fC937A.int_0;
				}
				else
				{
					D68F8BB7.SelectedValue = text;
				}
			}
		}
		catch
		{
		}
	}

	private void AC34650F(string E69F2625)
	{
		switch (E69F2625)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < D030FA3A.SelectedRows.Count; k++)
			{
				int index = D030FA3A.SelectedRows[k].Index;
				B034598F(index, "cChose", !Convert.ToBoolean(method_93(index, "cChose")));
			}
			method_61();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = D030FA3A.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				B034598F(selectedRows[j].Index, "cChose", true);
			}
			method_61();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < D030FA3A.RowCount; l++)
			{
				B034598F(l, "cChose", false);
			}
			method_61(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				B034598F(i, "cChose", true);
			}
			method_61(D030FA3A.RowCount);
			break;
		}
		}
	}

	private void method_8(string string_1)
	{
		if (A28928BD())
		{
			try
			{
				List<string> values = FF2742AE(string_1);
				Common.SetTextToClipboard(string.Join("\r\n", values));
			}
			catch
			{
			}
		}
	}

	private List<string> FF2742AE(string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_1.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				List<string> list3 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = method_93(i, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = Common.GetTotp(method_93(i, "cFa2"));
					}
					list3.Add(text);
				}
				list.Add(string.Join("|", list3));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private void FD2AC222_Click(object sender, EventArgs e)
	{
		AC34650F("All");
	}

	private void D829AA95(object sender, EventArgs e)
	{
		AC34650F("SelectHighline");
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		AC34650F("UnAll");
	}

	private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_8("cToken");
	}

	private void cookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_8("cCookies");
	}

	private void uidToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_8("cUid");
	}

	private void F099B437(object sender, EventArgs e)
	{
		method_8("cPassword");
	}

	private void uidPassToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_8("cUid|cPassword");
	}

	private void D29578BE_Click(object sender, EventArgs e)
	{
		method_8("cUid|cPassword|cToken|cCookies");
	}

	private void E2B11600(object sender, EventArgs e)
	{
		Common.ShowForm(new fAddFile());
		if (fAddFile.bool_0)
		{
			method_2();
			D68F8BB7.SelectedIndex = D68F8BB7.Items.Count - 2;
		}
	}

	private void C9187631(object sender, CancelEventArgs e)
	{
		toolStripMenuItem_1.DropDownItems.Clear();
		DataTable dataTable = CommonSQL.smethod_1();
		int num = 0;
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			DataRow dataRow = dataTable.Rows[i];
			string text = "";
			if (dataRow["id"].ToString() != text)
			{
				toolStripMenuItem_1.DropDownItems.Add(dataRow["Ten"].ToString());
				toolStripMenuItem_1.DropDownItems[i - num].Tag = dataRow["id"];
				toolStripMenuItem_1.DropDownItems[i - num].Click += method_10;
			}
			else
			{
				num++;
			}
		}
		EC2D66B3.DropDownItems.Clear();
		List<string> list_0 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text3 = "";
				string text4 = "";
				for (int m = 0; m < D030FA3A.RowCount; m++)
				{
					text3 = method_93(m, "cStatus").Trim();
					if (text3 != "")
					{
						text4 = Regex.Match(text3, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
						if (text4 != "")
						{
							text3 = text3.Replace(text4, "").Trim();
						}
						text4 = Regex.Match(text3, "\\[(.*?)\\]").Value;
						if (text4 != "")
						{
							text3 = text3.Replace(text4, "").Trim();
						}
						if (text3 != "" && !list_0.Contains(text3))
						{
							list_0.Add(text3);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		if (!thread.Join(5000))
		{
			thread.Abort();
		}
		for (int j = 0; j < list_0.Count; j++)
		{
			EC2D66B3.DropDownItems.Add(list_0[j]);
			EC2D66B3.DropDownItems[j].Click += C8ACD219;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		list_0 = new List<string>();
		thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text2 = "";
				for (int l = 0; l < D030FA3A.RowCount; l++)
				{
					text2 = method_93(l, "cInfo");
					if (!text2.Equals("") && !list_0.Contains(text2))
					{
						list_0.Add(text2);
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		if (!thread.Join(5000))
		{
			thread.Abort();
		}
		for (int k = 0; k < list_0.Count; k++)
		{
			tinhTrangToolStripMenuItem.DropDownItems.Add(list_0[k]);
			tinhTrangToolStripMenuItem.DropDownItems[k].Click += C506BF81;
		}
		toolStripMenuItem_18.DropDownItems.Clear();
		bool_4 = true;
	}

	private void C506BF81(object sender, EventArgs e)
	{
		method_9("cInfo", (sender as ToolStripMenuItem).Text);
	}

	private void C8ACD219(object sender, EventArgs e)
	{
		method_9("cStatus", (sender as ToolStripMenuItem).Text);
	}

	private void method_9(string string_1, string string_2)
	{
		for (int i = 0; i < D030FA3A.RowCount; i++)
		{
			D030FA3A.Rows[i].Cells["cChose"].Value = method_93(i, string_1).Contains(string_2);
		}
		method_61();
	}

	private void method_10(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có thực sự muốn chuyển {0} tài khoản sang thư mục [{1}]?"), lblCountSelect.Text, toolStripMenuItem.Text)) == DialogResult.Yes)
			{
				CE26883A(toolStripMenuItem.Tag.ToString());
			}
		}
	}

	private void CE26883A(string string_1)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
				{
					list.Add(D030FA3A.Rows[i].Cells["cId"].Value.ToString());
				}
			}
			if (CommonSQL.smethod_9(list, "idfile", string_1))
			{
				for (int j = 0; j < D030FA3A.RowCount; j++)
				{
					if (Convert.ToBoolean(D030FA3A.Rows[j].Cells["cChose"].Value))
					{
						D030FA3A.Rows.RemoveAt(j--);
					}
				}
				method_95();
				B0A4EF35();
				method_61(0);
				method_60();
				MessageBoxHelper.Show(string.Format(Language.GetValue("Chuyển thành công {0} tài khoản!"), list.Count));
			}
			else
			{
				MessageBoxHelper.Show("Chuyển thất bại, vui lòng thử lại sau!", 2);
			}
		}
		catch
		{
		}
	}

	private void CCA7CEA8(bool bool_5)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < D030FA3A.RowCount; i++)
		{
			if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
			{
				list.Add(D030FA3A.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản cần xóa!");
		}
		else
		{
			if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có muốn xóa {0} tài khoản đã chọn?"), B1ABC129()) + "\r\n\r\n" + Language.GetValue("(Ta\u0300i khoa\u0309n sau khi xo\u0301a se\u0303 đươ\u0323c lưu ta\u0323i mu\u0323c [Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a])")) != DialogResult.Yes)
			{
				return;
			}
			if (bool_5)
			{
				int F4A2D21D = 0;
				int num = 0;
				while (num < D030FA3A.Rows.Count)
				{
					if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (F4A2D21D < 10)
						{
							Interlocked.Increment(ref F4A2D21D);
							int AFBE3422 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								method_86(AFBE3422, Language.GetValue("Đang xo\u0301a profile..."));
								method_67(AFBE3422);
								Interlocked.Decrement(ref F4A2D21D);
							});
							thread.IsBackground = true;
							thread.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				while (F4A2D21D > 0)
				{
					Common.Sleep(1.0);
				}
			}
			if (CommonSQL.smethod_15(list))
			{
				for (int j = 0; j < D030FA3A.RowCount; j++)
				{
					if (Convert.ToBoolean(D030FA3A.Rows[j].Cells["cChose"].Value))
					{
						D030FA3A.Rows.RemoveAt(j--);
					}
				}
				B0A4EF35();
				method_60();
				method_61(0);
			}
			else
			{
				MessageBoxHelper.Show("Xóa thất bại, vui lòng thử lại sau!", 2);
			}
		}
	}

	public List<string> EF9D6E89()
	{
		List<string> list = new List<string>();
		try
		{
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeApiTinsoft") == 0)
			{
				RequestXNet fB87CFA = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
				string json = fB87CFA.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + SettingsTool.GetSettings("configGeneral").GetValue("txtApiUser"));
				JObject jObject = JObject.Parse(json);
				foreach (JToken item in (IEnumerable<JToken>)jObject["data"])
				{
					if (Convert.ToBoolean(item["success"].ToString()))
					{
						list.Add(item["key"].ToString());
					}
				}
			}
			else
			{
				List<string> list2 = SettingsTool.GetSettings("configGeneral").GetValueList("txtApiProxy");
				foreach (string item2 in list2)
				{
					if (TinsoftProxy.smethod_0(item2))
					{
						list.Add(item2);
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	private Dictionary<string, List<string>> method_11(string string_1, string FAA08E90, string string_2 = "txtUid")
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			List<string> list = InteractSQL.A28D1728(string_1, FAA08E90);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string text = list[i];
					JSON_Settings gClass = new JSON_Settings(InteractSQL.smethod_15(text), BE9E4429: true);
					List<string> list2 = new List<string>();
					list2 = ((!new List<string> { "txtUid", "lstNhomTuNhap", "txtLinkChiaSe", "txtIdPost", "txtLink" }.Contains(string_2)) ? gClass.GetValueList(string_2, gClass.GetValueInt("typeNganCach")) : gClass.GetValueList(string_2));
					dictionary.Add(text, list2);
				}
			}
		}
		catch
		{
		}
		return dictionary;
	}

	private void method_12(Dictionary<string, List<string>> dictionary_28, string string_1 = "txtUid")
	{
		if (dictionary_28.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> item in dictionary_28)
		{
			string key = item.Key;
			List<string> value = item.Value;
			JSON_Settings gClass = new JSON_Settings(InteractSQL.smethod_15(key), BE9E4429: true);
			gClass.method_5(string_1, value);
			InteractSQL.smethod_13(key, "", gClass.D9A09B34());
		}
	}

	private void method_13(Dictionary<string, List<string>> dictionary_28, bool bool_5, string F78800B6 = "txtUid")
	{
		if (dictionary_28.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> item in dictionary_28)
		{
			string key = item.Key;
			List<string> value = item.Value;
			JSON_Settings gClass = new JSON_Settings(InteractSQL.smethod_15(key), BE9E4429: true);
			if (bool_5 && gClass.GetValueBool("ckbAutoDeleteComment"))
			{
				gClass.method_5(F78800B6, value);
				InteractSQL.smethod_13(key, "", gClass.D9A09B34());
			}
		}
	}

	private Dictionary<string, Dictionary<string, List<string>>> A033DABA(string string_1, string string_2, string string_3 = "txtUid")
	{
		Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
		try
		{
			List<string> list = InteractSQL.A28D1728(string_1, string_2);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string text = list[i];
					JSON_Settings gClass = new JSON_Settings(InteractSQL.smethod_15(text), BE9E4429: true);
					List<string> list2 = new List<string>();
					list2 = ((!new List<string> { "txtUid", "lstNhomTuNhap", "txtLinkChiaSe", "txtIdPost", "txtLink" }.Contains(string_3)) ? gClass.GetValueList(string_3, gClass.GetValueInt("typeNganCach")) : gClass.GetValueList(string_3));
					Dictionary<string, List<string>> dictionary2 = new Dictionary<string, List<string>>();
					for (int j = 0; j < list2.Count; j++)
					{
						if (list2[j].Contains("_"))
						{
							string key = list2[j].Split('_')[0];
							if (!dictionary2.ContainsKey(key))
							{
								dictionary2.Add(key, new List<string>());
							}
							dictionary2[key].Add(list2[j]);
						}
					}
					dictionary.Add(text, dictionary2);
				}
			}
		}
		catch
		{
		}
		return dictionary;
	}

	private void method_14(Dictionary<string, Dictionary<string, List<string>>> dictionary_28, string FC984F02 = "txtUid")
	{
		if (dictionary_28.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, Dictionary<string, List<string>>> item in dictionary_28)
		{
			string key = item.Key;
			Dictionary<string, List<string>> value = item.Value;
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, List<string>> item2 in value)
			{
				list.AddRange(item2.Value);
			}
			JSON_Settings gClass = new JSON_Settings(InteractSQL.smethod_15(key), BE9E4429: true);
			gClass.method_5(FC984F02, list);
			InteractSQL.smethod_13(key, "", gClass.D9A09B34());
		}
	}

	private bool AE38A6B4(string string_1, string F6BF6D8F)
	{
		try
		{
			string text = string_1.Split(':')[1];
			string text2 = F6BF6D8F.Split(':')[1];
			if (text.Substring(1) == text2.Substring(1))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void method_15()
	{
		E1B02C9B = new Dictionary<string, List<string>>();
		try
		{
			string text = SettingsTool.GetSettings("configGeneral").GetValue("pathResult", "output\\resultSpam");
			if (text == "output\\resultSpam")
			{
				Common.CreateFolder("output");
				Common.CreateFolder("output\\resultSpam");
			}
		}
		catch
		{
		}
	}

	private bool method_16(string string_1)
	{
		foreach (KeyValuePair<string, List<string>> item in E1B02C9B)
		{
			if (item.Value.Contains(string_1))
			{
				return true;
			}
		}
		return false;
	}

	private void DA809F35(JSON_Settings gclass8_1 = null)
	{
		try
		{
			if (!A28928BD())
			{
				return;
			}
			int int_0 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudInteractThread", 3);
			if (gclass8_1.GetValueBool("OpenBrowser"))
			{
				int_0 = B1ABC129();
			}
			list_0 = method_20(ref int_0);
			if (list_0 != null && list_0.Count == 0)
			{
				MessageBoxHelper.Show("Proxy không đủ, vui lòng cấu hình lại!", 2);
				return;
			}
			List<int> DF99F409 = new List<int>();
			for (int i = 0; i < int_0; i++)
			{
				DF99F409.Add(0);
			}
			method_59("start");
			dictionary_26 = new Dictionary<string, List<string>>();
			bool_3 = true;
			this.bool_0 = false;
			int AE28CC9C = 0;
			bool bool_0 = false;
			int_3 = 0;
			E2B4308C = new List<Thread>();
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					if (gclass8_1.GetValueBool("Interact"))
					{
						List<string> list = new List<string>();
						string string_0 = "";
						string text = "";
						int num = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudSoLuotChay", 1);
						if (num == 0)
						{
							num = 1;
						}
						for (int j = 0; j < num; j++)
						{
							list = new List<string>();
							if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
							{
								text = ((num > 1) ? string.Format(Language.GetValue("Lượt {0}/{1}. "), j + 1, num) : "");
								if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("RepeatAllVIP"))
								{
									list = SettingsTool.GetSettings("configInteractGeneral").GetValueList("lstIdKichBan");
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomKichBan"))
									{
										list = Common.ShuffleList(list);
										list = Common.ShuffleList(list);
										list = Common.ShuffleList(list);
									}
								}
								else
								{
									list.Add(SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan"));
								}
							}
							else
							{
								list.Add(SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan"));
							}
							for (int k = 0; k < list.Count; k++)
							{
								if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbXoaCache"))
								{
									int int_ = 0;
									int E3BE2AA9 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										int num25 = 0;
										while (num25 < D030FA3A.Rows.Count)
										{
											if (Convert.ToBoolean(D030FA3A.Rows[num25].Cells["cChose"].Value))
											{
												if (int_ < E3BE2AA9)
												{
													Interlocked.Increment(ref int_);
													int FFA5E11B = num25++;
													Thread thread9 = new Thread((ThreadStart)delegate
													{
														method_86(FFA5E11B, Language.GetValue("Đang xo\u0301a Cache Profile..."));
														method_85(FFA5E11B);
														Interlocked.Decrement(ref int_);
													});
													thread9.IsBackground = true;
													thread9.Start();
												}
												else
												{
													Application.DoEvents();
													Thread.Sleep(200);
												}
											}
											else
											{
												num25++;
											}
										}
									});
									thread2.IsBackground = true;
									thread2.Start();
								}
								if (this.bool_0)
								{
									break;
								}
								string_0 = list[k];
								if (text != "")
								{
									method_58(text + string.Format(Language.GetValue("Kịch bản") + ": {0}...", InteractSQL.smethod_1(string_0)));
								}
								if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomThuTuTaiKhoan"))
								{
									D030FA3A.Invoke((MethodInvoker)delegate
									{
										method_82();
									});
								}
								dictionary_0 = method_11(string_0, "HDThamGiaNhomUid");
								dictionary_1 = method_11(string_0, "HDThamGiaNhomUidv2");
								dictionary_17 = method_11(string_0, "HDKetBanVoiBanBeCuaUid");
								E23B4A9D = method_11(string_0, "HDKetBanTepUid");
								dictionary_2 = method_11(string_0, "HDKetBanTepUidv2");
								D683B016 = method_11(string_0, "HDBaiVietProfile");
								dictionary_3 = method_11(string_0, "HDSpamBaiViet");
								DBA18A3F = method_11(string_0, "HDSpamBaiVietv2");
								dictionary_4 = method_11(string_0, "HDSpamBaiViet", "txtComment");
								E895F516 = method_11(string_0, "HDSpamBaiVietv2", "txtComment");
								A004CC2C = method_11(string_0, "HDBuffTinNhanProfile");
								dictionary_5 = method_11(string_0, "HDKetBanTepUidNew", "txtLink");
								AD043507 = method_11(string_0, "HDBuffLikeComment", "txtComment");
								dictionary_6 = method_11(string_0, "HDBuffLikeComment", "txtComment");
								dictionary_7 = method_11(string_0, "HDDangStatus", "txtNoiDung");
								F425F288 = method_11(string_0, "HDDangStatus", "txtNoiDung");
								dictionary_8 = method_11(string_0, "HDDangStatusV2", "txtNoiDung");
								dictionary_9 = method_11(string_0, "HDDangStatusV2", "txtNoiDung");
								E1B23AB3 = method_11(string_0, "HDPhanHoiBinhLuan");
								EA2797A9 = method_11(string_0, "HDBuffLikeComment", "txtIdPost");
								FB142A84 = method_11(string_0, "HDDangBaiTheoID", "txtIdPost");
								A8BA2C20 = method_11(string_0, "HDBuffFollowLikePage");
								B9A41D39 = method_11(string_0, "HDShareBaiTut", "txtLinkChiaSe");
								dictionary_10 = method_11(string_0, "HDLinkToInstagram", "txtBio");
								FE8A1487 = method_11(string_0, "HDLinkToInstagram", "txtBio");
								dictionary_11 = method_11(string_0, "HDReviewPage");
								dictionary_12 = method_11(string_0, "HDNhanTinBanBe", "txtTinNhan");
								A19F8027 = method_11(string_0, "HDNhanTinBanBe", "txtTinNhan");
								D9B53233 = method_11(string_0, "HDDangBai", "lstNhomTuNhap");
								dictionary_13 = method_11(string_0, "HDDangBai", "txtIdPost");
								F3B2F19D = method_11(string_0, "HDTuongTacLivestream", "txtComment");
								C8327704 = method_11(string_0, "HDDangBai", "txtNoiDung");
								C00CDC8B = new Dictionary<string, List<string>>();
								dictionary_14 = method_11(string_0, "HDAddMail", "lstHotmail");
								dictionary_15 = new Dictionary<string, List<string>>();
								dictionary_16 = new Dictionary<string, List<string>>();
								E02E651E = new Dictionary<string, Dictionary<string, int>>();
								dictionary_25 = method_11(string_0, "HDPhanHoiBinhLuan", "txtComment");
								dictionary_18 = method_11(string_0, "HDDangReel", "txtNoiDung");
								dictionary_19 = method_11(string_0, "HDShareBai", "txtNoiDung");
								B2BDD2A9 = A033DABA(string_0, "HDChaySpam", "txtIdPost");
								dictionary_20 = method_11(string_0, "HDChaySpam", "txtComment");
								dictionary_21 = method_11(string_0, "HDChaySpam", "txtComment");
								method_15();
								C923A3A2 = new Dictionary<string, List<string>>();
								dictionary_24 = new Dictionary<string, List<string>>();
								dictionary_22 = new Dictionary<string, List<string>>();
								dictionary_23 = new Dictionary<string, List<string>>();
								if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 1)
								{
									for (int l = 0; l < list_0.Count; l++)
									{
										(list_0[l] as XproxyProxy).resetXProxy();
									}
								}
								if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 14)
								{
									for (int m = 0; m < F93ADB36.Count; m++)
									{
										F93ADB36[m].resetOBCProxy();
									}
								}
								Thread thread3 = new Thread((ThreadStart)delegate
								{
									try
									{
										int num18 = 0;
										while (num18 < D030FA3A.Rows.Count && !this.bool_0)
										{
											if (Convert.ToBoolean(D030FA3A.Rows[num18].Cells["cChose"].Value))
											{
												if (this.bool_0)
												{
													break;
												}
												if (E2B4308C.Count < int_0)
												{
													if (this.bool_0)
													{
														break;
													}
													int int_5 = num18++;
													Thread thread8 = new Thread((ThreadStart)delegate
													{
														int num24 = Common.GetIndexOfPossitionApp(ref DF99F409);
														try
														{
															method_19(int_5, num24, string_0, gclass8_1);
															Common.FillIndexPossition(ref DF99F409, num24);
															bool flag = false;
															if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
															{
																flag = true;
															}
															else
															{
																string text2 = method_92(int_5);
																if (text2 != "Live")
																{
																	flag = true;
																}
																if (!flag)
																{
																	string text3 = D491BE25(int_5).ToLower();
																	flag = text3.Contains("checkpoint") || text3.Contains("invalid username or password") || text3.Contains("Proxy chưa ủy quyền!".ToLower()) || text3.Contains("fb block") || text3.Contains("Max Job Today".ToLower());
																}
															}
															if (flag)
															{
																B034598F(int_5, "cChose", false);
															}
														}
														catch (Exception ex5)
														{
															if (ex5.ToString().Contains("Thread was being aborted."))
															{
																Common.FillIndexPossition(ref DF99F409, num24);
																if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
																{
																	B034598F(int_5, "cChose", false);
																}
															}
														}
													})
													{
														Name = int_5.ToString()
													};
													E2B4308C.Add(thread8);
													Common.Sleep(1.0);
													thread8.Start();
												}
												else
												{
													if (this.bool_0)
													{
														break;
													}
													if ((SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 7 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 10 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy")))
													{
														for (int num19 = 0; num19 < E2B4308C.Count; num19++)
														{
															E2B4308C[num19].Join();
															E2B4308C.RemoveAt(num19--);
														}
													}
													else if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2)
													{
														for (int num20 = 0; num20 < E2B4308C.Count; num20++)
														{
															E2B4308C[num20].Join();
															E2B4308C.RemoveAt(num20--);
														}
														if (this.bool_0)
														{
															break;
														}
														Interlocked.Increment(ref AE28CC9C);
														if (AE28CC9C >= SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1))
														{
															for (int num21 = 0; num21 < 3; num21++)
															{
																bool_0 = Common.ChangeIP(SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
																if (bool_0)
																{
																	break;
																}
															}
															if (!bool_0)
															{
																MessageBoxHelper.Show("Không thê\u0309 đô\u0309i ip!", 2);
																this.bool_0 = true;
																return;
															}
															AE28CC9C = 0;
														}
													}
													else
													{
														for (int num22 = 0; num22 < E2B4308C.Count; num22++)
														{
															if (!E2B4308C[num22].IsAlive)
															{
																E2B4308C.RemoveAt(num22--);
															}
														}
													}
												}
											}
											else
											{
												num18++;
											}
											if (this.bool_0)
											{
												break;
											}
										}
										for (int num23 = 0; num23 < E2B4308C.Count; num23++)
										{
											E2B4308C[num23].Join();
										}
									}
									catch (ThreadAbortException ex4)
									{
										if (ex4.ToString().Contains("Thread was being aborted."))
										{
										}
									}
								});
								thread3.IsBackground = true;
								thread3.Start();
								if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayKichBan"))
								{
									int num2 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanTo") + 1);
									if (!thread3.Join(num2 * 60000))
									{
										thread3.Abort();
										for (int n = 0; n < E2B4308C.Count; n++)
										{
											E2B4308C[n].Abort();
											while (E2B4308C[n].IsAlive)
											{
												Thread.Sleep(1000);
											}
										}
										while (thread3.IsAlive)
										{
											Thread.Sleep(1000);
										}
									}
								}
								else
								{
									thread3.Join();
								}
								method_12(dictionary_0);
								method_12(dictionary_1);
								method_12(dictionary_17);
								method_12(E23B4A9D);
								method_12(dictionary_2);
								method_12(D683B016);
								method_12(dictionary_3);
								method_12(DBA18A3F);
								method_13(AD043507, bool_5: true, "txtComment");
								method_12(dictionary_4, "txtComment");
								method_12(E895F516, "txtComment");
								method_12(A004CC2C);
								method_12(dictionary_5, "txtLink");
								method_12(EA2797A9, "txtIdPost");
								method_12(FB142A84, "txtIdPost");
								method_12(A8BA2C20);
								method_12(B9A41D39, "txtLinkChiaSe");
								method_12(dictionary_10, "txtBio");
								method_12(dictionary_11);
								method_12(D9B53233, "lstNhomTuNhap");
								method_12(dictionary_13, "txtIdPost");
								method_12(F3B2F19D, "txtComment");
								method_12(C8327704, "txtNoiDung");
								method_12(dictionary_14, "lstHotmail");
								method_12(dictionary_25, "txtComment");
								method_12(dictionary_18, "txtNoiDung");
								method_12(dictionary_19, "txtNoiDung");
								method_14(B2BDD2A9, "txtIdPost");
								method_13(dictionary_20, bool_5: true, "txtComment");
								if (this.bool_0)
								{
									break;
								}
								if (k + 1 < list.Count)
								{
									int num3 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayKichBanFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayKichBanTo") + 1);
									int tickCount = Environment.TickCount;
									while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
									{
										method_58(text + string.Format(Language.GetValue("Chạy kịch bản tiếp theo sau {time} giây...").Replace("{time}", (num3 - (Environment.TickCount - tickCount) / 1000).ToString())));
										Common.Sleep(0.5);
										if (this.bool_0)
										{
											break;
										}
									}
								}
							}
							if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll") || this.bool_0)
							{
								break;
							}
							if (j + 1 < num)
							{
								int num4 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnTo") + 1) * 60;
								int tickCount2 = Environment.TickCount;
								while ((Environment.TickCount - tickCount2) / 1000 - num4 < 0)
								{
									method_58(text + string.Format(Language.GetValue("Chạy lượt tiếp theo sau {time} giây...").Replace("{time}", (num4 - (Environment.TickCount - tickCount2) / 1000).ToString())));
									Common.Sleep(0.5);
									if (this.bool_0)
									{
										break;
									}
								}
							}
							if (this.bool_0)
							{
								break;
							}
						}
					}
					else if (gclass8_1.GetValueBool("OpenBrowser"))
					{
						if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 1)
						{
							for (int num5 = 0; num5 < list_0.Count; num5++)
							{
								(list_0[num5] as XproxyProxy).resetXProxy();
							}
						}
						if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 14)
						{
							for (int num6 = 0; num6 < F93ADB36.Count; num6++)
							{
								F93ADB36[num6].resetOBCProxy();
							}
						}
						Thread thread4 = new Thread((ThreadStart)delegate
						{
							try
							{
								int num16 = 0;
								while (num16 < D030FA3A.Rows.Count && !this.bool_0)
								{
									if (Convert.ToBoolean(D030FA3A.Rows[num16].Cells["cChose"].Value))
									{
										if (this.bool_0 || E2B4308C.Count >= int_0)
										{
											break;
										}
										if (this.bool_0)
										{
											break;
										}
										int int_3 = num16++;
										Thread thread7 = new Thread((ThreadStart)delegate
										{
											int int_4 = Common.GetIndexOfPossitionApp(ref DF99F409);
											try
											{
												method_19(int_3, int_4, "", gclass8_1);
											}
											catch (Exception exception_3)
											{
												Common.ExportError(null, exception_3);
											}
										})
										{
											Name = int_3.ToString()
										};
										E2B4308C.Add(thread7);
										Common.Sleep(1.0);
										thread7.Start();
									}
									else
									{
										num16++;
									}
								}
								for (int num17 = 0; num17 < E2B4308C.Count; num17++)
								{
									E2B4308C[num17].Join();
								}
							}
							catch (ThreadAbortException ex3)
							{
								if (ex3.ToString().Contains("Thread was being aborted."))
								{
								}
							}
						});
						thread4.IsBackground = true;
						thread4.Start();
						thread4.Join();
					}
					else
					{
						if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 1)
						{
							for (int num7 = 0; num7 < list_0.Count; num7++)
							{
								(list_0[num7] as XproxyProxy).resetXProxy();
							}
						}
						if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 14)
						{
							for (int num8 = 0; num8 < F93ADB36.Count; num8++)
							{
								F93ADB36[num8].resetOBCProxy();
							}
						}
						Thread thread5 = new Thread((ThreadStart)delegate
						{
							try
							{
								int num9 = 0;
								while (num9 < D030FA3A.Rows.Count && !this.bool_0)
								{
									if (Convert.ToBoolean(D030FA3A.Rows[num9].Cells["cChose"].Value))
									{
										if (this.bool_0)
										{
											break;
										}
										if (E2B4308C.Count < int_0)
										{
											if (this.bool_0)
											{
												break;
											}
											int int_2 = num9++;
											Thread thread6 = new Thread((ThreadStart)delegate
											{
												int num15 = Common.GetIndexOfPossitionApp(ref DF99F409);
												try
												{
													method_19(int_2, num15, "", gclass8_1);
													Common.FillIndexPossition(ref DF99F409, num15);
													if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll") || method_92(int_2) != "Live" || D491BE25(int_2).ToLower().Contains("checkpoint") || D491BE25(int_2).ToLower().Contains("invalid username or password") || D491BE25(int_2).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
													{
														B034598F(int_2, "cChose", false);
													}
												}
												catch (Exception ex2)
												{
													if (ex2.ToString().Contains("Thread was being aborted."))
													{
														Common.FillIndexPossition(ref DF99F409, num15);
														if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll"))
														{
															B034598F(int_2, "cChose", false);
														}
													}
												}
											})
											{
												Name = int_2.ToString()
											};
											E2B4308C.Add(thread6);
											Common.Sleep(1.0);
											thread6.Start();
										}
										else
										{
											if (this.bool_0)
											{
												break;
											}
											if ((SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 7 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 8 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy")) || (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 10 && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy")))
											{
												for (int num10 = 0; num10 < E2B4308C.Count; num10++)
												{
													E2B4308C[num10].Join();
													E2B4308C.RemoveAt(num10--);
												}
											}
											else if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2)
											{
												for (int num11 = 0; num11 < E2B4308C.Count; num11++)
												{
													E2B4308C[num11].Join();
													E2B4308C.RemoveAt(num11--);
												}
												if (this.bool_0)
												{
													break;
												}
												Interlocked.Increment(ref AE28CC9C);
												if (AE28CC9C >= SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1))
												{
													for (int num12 = 0; num12 < 3; num12++)
													{
														bool_0 = Common.ChangeIP(SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
														if (bool_0)
														{
															break;
														}
													}
													if (!bool_0)
													{
														MessageBoxHelper.Show("Không thê\u0309 đô\u0309i ip!", 2);
														this.bool_0 = true;
														return;
													}
													AE28CC9C = 0;
												}
											}
											else
											{
												for (int num13 = 0; num13 < E2B4308C.Count; num13++)
												{
													if (!E2B4308C[num13].IsAlive)
													{
														E2B4308C.RemoveAt(num13--);
													}
												}
											}
										}
									}
									else
									{
										num9++;
									}
									if (this.bool_0)
									{
										break;
									}
								}
								for (int num14 = 0; num14 < E2B4308C.Count; num14++)
								{
									E2B4308C[num14].Join();
								}
							}
							catch (ThreadAbortException ex)
							{
								if (ex.ToString().Contains("Thread was being aborted."))
								{
								}
							}
						});
						thread5.IsBackground = true;
						thread5.Start();
						thread5.Join();
					}
				}
				catch (Exception exception_2)
				{
					Common.ExportError(null, exception_2);
				}
				E8AFC193();
				method_59("stop");
				bool_3 = false;
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			method_59("stop");
			bool_3 = false;
		}
	}

	private bool method_17(Chrome B002371F)
	{
		return true;
	}

	private int method_18(int int_4, string string_1, Chrome f336F52E_0, List<string> list_4, int int_5, int int_6, int int_7, int D58A4123, int int_8, int EB2BBCB6, int int_9, int int_10, string string_2)
	{
		int result = 0;
		try
		{
			int num = Base.rd.Next(int_5, int_6 + 1);
			for (int i = 0; i < num; i++)
			{
				method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_2} ({i}/{num})...");
				if (list_4.Count == 0)
				{
					break;
				}
				string text = list_4[Base.rd.Next(0, list_4.Count)];
				list_4.Remove(text);
				string string_3 = text.Split('|')[0];
				string text2 = text.Split('|')[1];
				if (!f336F52E_0.CheckIsLive())
				{
					f336F52E_0.GotoURL("https://www.google.com.vn/");
					f336F52E_0.DelayRandom(2, 3);
					string text3 = "textarea[role=\"combobox\"]";
					if (f336F52E_0.CheckExistElement(text3, 3.0) != 1)
					{
						continue;
					}
					f336F52E_0.DelayRandom(1, 2);
					if (f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + text3 + "')") == 1)
					{
						f336F52E_0.DelayRandom(1, 2);
					}
					f336F52E_0.SendKeysWithSpeed(text3, string_3, 0.08);
					f336F52E_0.DelayRandom(2, 3);
					f336F52E_0.SendEnter(4, text3);
					f336F52E_0.DelayRandom(2, 3);
					string text4 = "a[href*=\"" + text2 + "\"]";
					if (f336F52E_0.CheckExistElement(text4) == 0)
					{
						int num2 = Base.rd.Next(int_7, D58A4123 + 1);
						for (int j = 0; j < num2 - 1 && f336F52E_0.CheckExistElement("[aria-label=\"Page " + (j + 2) + "\"]") == 1; j++)
						{
							f336F52E_0.ScrollSmooth("document.querySelector('[aria-label=\"Page " + (j + 2) + "\"]')");
							f336F52E_0.DelayRandom(2, 3);
							f336F52E_0.Click(4, "[aria-label=\"Page " + (j + 2) + "\"]");
							f336F52E_0.DelayRandom(2, 3);
							if (f336F52E_0.CheckExistElement(text4) == 1)
							{
								break;
							}
						}
					}
					if (f336F52E_0.CheckExistElement(text4) == 1)
					{
						for (int k = 0; k < 10; k++)
						{
							if (Base.rd.Next(0, 100) % 5 == 1)
							{
								f336F52E_0.ScrollSmooth(-Base.rd.Next(100, 300));
							}
							else
							{
								f336F52E_0.ScrollSmooth(Base.rd.Next(100, 300));
							}
							f336F52E_0.DelayRandom(1, 2);
						}
						if (f336F52E_0.CheckExistElementOnScreen("document.querySelector('" + text4 + "')") != 0)
						{
							f336F52E_0.ScrollSmooth("document.querySelector('" + text4 + "')");
						}
						f336F52E_0.DelayRandom(2, 3);
						f336F52E_0.Click(4, text4);
					}
					else
					{
						f336F52E_0.GotoURL(text2);
					}
					int num3 = Base.rd.Next(int_8, EB2BBCB6 + 1);
					int num4 = Convert.ToInt32(f336F52E_0.ExecuteScript("var count=0; document.querySelectorAll('a').forEach(e=>{if(e.getAttribute('href')!=null && e.getAttribute('href')!='') count++}); return count+''").ToString());
					for (int l = 0; l < num3; l++)
					{
						if (num4 == 0)
						{
							break;
						}
						int dA90F = Base.rd.Next(1, num4 + 1);
						f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('a')[" + dA90F + "]");
						f336F52E_0.DelayRandom(2, 3);
						f336F52E_0.Click(4, "a", dA90F);
						f336F52E_0.DelayTime(3.0);
						int num5 = Base.rd.Next(1, 3);
						for (int m = 0; m < num5; m++)
						{
							f336F52E_0.ScrollSmooth(Base.rd.Next(100, 300));
							f336F52E_0.DelayRandom(2, 3);
						}
						if (f336F52E_0.GetURL() != text2)
						{
							f336F52E_0.GotoBackPage();
							f336F52E_0.DelayRandom(2, 3);
						}
					}
					int num6 = Base.rd.Next(int_9, int_10 + 1);
					int tickCount = Environment.TickCount;
					int num7 = 1;
					do
					{
						num7 = ((Base.rd.Next(1, 1000) % 5 != 0) ? 1 : (-1));
						f336F52E_0.ScrollSmooth(num7 * Base.rd.Next(100, 300));
						f336F52E_0.DelayRandom(2, 3);
					}
					while (Environment.TickCount - tickCount < num6 * 1000);
					continue;
				}
				return -2;
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(f336F52E_0, exception_, "HDSearchGoogle");
			result = -1;
		}
		return result;
	}

	private int AC1D2CB6(int int_4, string string_1, Chrome f336F52E_0, List<string> E526558A, int int_5, int D2224525, int int_6, int int_7, int int_8, int E1A1DAAA, bool bool_5, string string_2)
	{
		int result = 0;
		try
		{
			int num = Base.rd.Next(int_5, D2224525 + 1);
			for (int i = 0; i < num; i++)
			{
				method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_2} ({i}/{num})...");
				if (E526558A.Count == 0)
				{
					break;
				}
				string text = E526558A[Base.rd.Next(0, E526558A.Count)];
				E526558A.Remove(text);
				if (!f336F52E_0.CheckIsLive())
				{
					f336F52E_0.GotoURL(text);
					int num2 = Base.rd.Next(int_6, int_7 + 1);
					int num3 = Convert.ToInt32(f336F52E_0.ExecuteScript("var count=0; document.querySelectorAll('a').forEach(e=>{if(e.getAttribute('href')!=null && e.getAttribute('href')!='') count++}); return count+''").ToString());
					for (int j = 0; j < num2; j++)
					{
						if (num3 == 0)
						{
							break;
						}
						int dA90F = Base.rd.Next(1, num3 + 1);
						f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('a')[" + dA90F + "]");
						f336F52E_0.DelayRandom(2, 3);
						f336F52E_0.Click(4, "a", dA90F);
						f336F52E_0.DelayTime(3.0);
						int num4 = Base.rd.Next(1, 3);
						for (int k = 0; k < num4; k++)
						{
							f336F52E_0.ScrollSmooth(Base.rd.Next(100, 300));
							f336F52E_0.DelayRandom(2, 3);
						}
						if (f336F52E_0.GetURL() != text)
						{
							f336F52E_0.GotoBackPage();
							f336F52E_0.DelayRandom(2, 3);
						}
					}
					int num5 = Base.rd.Next(int_8, E1A1DAAA + 1);
					if (bool_5)
					{
						int tickCount = Environment.TickCount;
						int num6 = 1;
						do
						{
							num6 = ((Base.rd.Next(1, 1000) % 6 != 0) ? 1 : (-1));
							f336F52E_0.ScrollSmooth(num6 * Base.rd.Next(100, 300));
							f336F52E_0.DelayRandom(2, 3);
						}
						while (Environment.TickCount - tickCount < num5 * 1000);
					}
					else
					{
						f336F52E_0.DelayTime(num5);
					}
					continue;
				}
				return -2;
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(f336F52E_0, exception_, "HDSearchGoogle");
			result = -1;
		}
		return result;
	}

	private void method_19(int int_4, int int_5, string E18CA92A, JSON_Settings gclass8_1)
	{
		if (gclass8_1 == null)
		{
			gclass8_1 = new JSON_Settings();
		}
		int e499D18D = 0;
		if (gclass8_1.GetValueBool("Interact") && SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayTaiKhoan"))
		{
			e499D18D = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayTaiKhoanFrom"), SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayTaiKhoanTo") + 1);
		}
		Account dCBEFE8F = new Account(Thread.CurrentThread, e499D18D);
		string string_ = "";
		Chrome f336F52E = null;
		int num = 0;
		string F8A1A = "";
		int A01ECB = 0;
		string string_2 = "";
		TinsoftProxy f722CFA1_ = null;
		XproxyProxy d918F1B6_ = null;
		TMProxy class10_ = null;
		Proxyv6 AC3DEE = null;
		ShopLike C6B = null;
		MinProxy gclass4_ = null;
		OBCProxyv2 b1818408_ = null;
		bool flag = false;
		bool flag2 = false;
		string text = "";
		int num2 = 0;
		bool flag3 = false;
		string text2 = "";
		int num3 = 0;
		int num4 = 0;
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		string text11 = "";
		string text12 = "";
		string text13 = "";
		string text14 = "";
		string text15 = "";
		string text16 = "";
		int num5 = -1;
		int num6 = -1;
		int num7 = -1;
		string text17 = "";
		string text18 = method_93(int_4, "cUid");
		string string_3 = method_93(int_4, "cId");
		string text19 = method_93(int_4, "cEmail");
		string text20 = method_93(int_4, "cPassMail");
		string text21 = method_93(int_4, "cMailRecovery");
		string text22 = method_93(int_4, "cFa2");
		string text23 = method_93(int_4, "cPassword");
		string text24 = method_93(int_4, "cCookies");
		string text25 = method_93(int_4, "cToken");
		string text26 = method_93(int_4, "cUseragent");
		if (gclass8_1.GetValueBool("Unlock956") && gclass8_1.GetValueInt("TypeUnlock956") == 2)
		{
			text26 = "";
		}
		if (text18 == "")
		{
			text18 = Regex.Match(text24, "c_user=(\\d+)").Groups[1].Value;
		}
		try
		{
			if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckLiveUid") && Common.IsUid(text18) && CheckInfoAccountv2.CheckLiveWall(text18).StartsWith("0|") && gclass8_1.GetValueBool("Interact"))
			{
				method_86(int_4, Language.GetValue("Tài khoản Die!"));
				method_87(int_4, "Die");
				num2 = 1;
			}
			else if (bool_0)
			{
				method_86(int_4, F8A1A + Language.GetValue("Đã dừng!"));
				num2 = 1;
			}
			else
			{
				method_21(int_4, ref bool_0, ref string_, ref A01ECB, ref F8A1A, ref string_2, ref f722CFA1_, ref d918F1B6_, ref class10_, ref AC3DEE, ref C6B, ref gclass4_, ref b1818408_);
				if (bool_0)
				{
					method_86(int_4, F8A1A + Language.GetValue("Đã dừng!"));
					num2 = 1;
				}
				else
				{
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 0 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 1 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 2 || SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
						{
							if (string_ != "")
							{
								F8A1A = "(IP: " + string_.Split(':')[0] + ") ";
							}
							method_86(int_4, F8A1A + "Check IP...");
							bool flag4 = false;
							int num8 = 0;
							while (num8 < 30)
							{
								Common.Sleep(1.0);
								string_2 = Common.CheckIP(string_, A01ECB);
								if (!(string_2 != ""))
								{
									if (!bool_0)
									{
										num8++;
										continue;
									}
									goto IL_046c;
								}
								flag4 = true;
								break;
							}
							if (!flag4)
							{
								if (string_ != "")
								{
									method_86(int_4, F8A1A + Language.GetValue("Không thể kết nối proxy!"));
								}
								else
								{
									method_86(int_4, F8A1A + Language.GetValue("Không có kết nối Internet!"));
								}
								num2 = 1;
								goto IL_221e;
							}
						}
						F8A1A = "(IP: " + string_ + "=>" + string_2 + ") ";
					}
					if (bool_0)
					{
						method_86(int_4, F8A1A + Language.GetValue("Đã dừng!"));
						num2 = 1;
					}
					else
					{
						try
						{
							bool flag5 = false;
							if (gclass8_1.GetValueBool("Unlock282"))
							{
								flag5 = true;
								method_27(int_4, F8A1A, text24, string_, A01ECB);
							}
							if (!gclass8_1.GetValueBool("GetTokenEAAAAU"))
							{
								goto IL_0596;
							}
							flag5 = true;
							method_86(int_4, "Get Token...");
							string string_4 = "Get Token fail!";
							text25 = CheckInfoAccountv2.smethod_0(text18, text23, text22, text24, string_, A01ECB);
							if (!(text25 == "Invalid username or password"))
							{
								if (text25 != "")
								{
									BC0C40BD(int_4, "cToken", text25, "token");
									string_4 = "Get Token Success!";
								}
								method_86(int_4, string_4);
								goto IL_0596;
							}
							method_86(int_4, "Get token fail (Sai pass)");
							num2 = 1;
							goto end_IL_04e5;
							IL_0929:
							method_86(int_4, F8A1A + Language.GetValue("Chờ đến lượt..."));
							lock (BF286719)
							{
								if (int_3 > 0)
								{
									int num9 = Base.rd.Next(SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeFrom", 1), SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeTo", 1) + 1);
									if (num9 > 0)
									{
										int tickCount = Environment.TickCount;
										while ((Environment.TickCount - tickCount) / 1000 - num9 < 0)
										{
											method_86(int_4, F8A1A + Language.GetValue("Mở tri\u0300nh duyê\u0323t sau") + " {time}s...".Replace("{time}", (num9 - (Environment.TickCount - tickCount) / 1000).ToString()));
											Common.Sleep(0.5);
											if (!bool_0)
											{
												continue;
											}
											method_86(int_4, F8A1A + Language.GetValue("Đã dừng!"));
											num2 = 1;
											goto end_IL_04e5;
										}
									}
								}
								else
								{
									int_3++;
								}
							}
							method_86(int_4, F8A1A + Language.GetValue("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
							string text27 = "data:,";
							Point c81213A;
							Point point_;
							if (gclass8_1.GetValueBool("OpenBrowser"))
							{
								text27 = "";
								if (SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbAddChromeIntoForm"))
								{
									c81213A = new Point(-1000, 0);
									point_ = new Point(SettingsTool.GetSettings("configOpenBrowser").GetValueInt("nudWidthChrome") + 16, SettingsTool.GetSettings("configOpenBrowser").GetValueInt("nudHeighChrome"));
								}
								else
								{
									c81213A = Common.GetPointFromIndexPosition(int_5, SettingsTool.GetSettings("configOpenBrowser").GetValueInt("cbbColumnChrome", 3), SettingsTool.GetSettings("configOpenBrowser").GetValueInt("cbbRowChrome", 2));
									point_ = Common.GetSizeChrome(SettingsTool.GetSettings("configOpenBrowser").GetValueInt("cbbColumnChrome", 3), SettingsTool.GetSettings("configOpenBrowser").GetValueInt("cbbRowChrome", 2));
								}
							}
							else if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbAddChromeIntoForm"))
							{
								if (text27 == "")
								{
									c81213A = new Point(-1000, 0);
									point_ = new Point(SettingsTool.GetSettings("configGeneral").GetValueInt("nudWidthChrome") + 16, SettingsTool.GetSettings("configGeneral").GetValueInt("nudHeighChrome") + 132);
								}
								else
								{
									c81213A = new Point(-1000, 0);
									point_ = new Point(SettingsTool.GetSettings("configGeneral").GetValueInt("nudWidthChrome") + 33, SettingsTool.GetSettings("configGeneral").GetValueInt("nudHeighChrome") + 39);
								}
							}
							else
							{
								c81213A = Common.GetPointFromIndexPosition(int_5, SettingsTool.GetSettings("configGeneral").GetValueInt("cbbColumnChrome", 3), SettingsTool.GetSettings("configGeneral").GetValueInt("cbbRowChrome", 2));
								point_ = Common.GetSizeChrome(SettingsTool.GetSettings("configGeneral").GetValueInt("cbbColumnChrome", 3), SettingsTool.GetSettings("configGeneral").GetValueInt("cbbRowChrome", 2));
							}
							string text28 = SettingsTool.GetPathProfile();
							string text29 = "";
							if (text28 != "" && text18 != "")
							{
								text29 = text28 + "\\" + text18;
							}
							if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCreateProfile"))
							{
								text29 = "";
							}
							if (gclass8_1.GetValueBool("OpenBrowser") && !SettingsTool.GetSettings("configOpenBrowser").GetValueBool("isUseProfile"))
							{
								text29 = "";
							}
							f336F52E = new Chrome
							{
								IndexChrome = int_4,
								DisableImage = !SettingsTool.GetSettings("configGeneral").GetValueBool("ckbShowImageInteract"),
								UserAgent = text26,
								ProfilePath = text29,
								Size = point_,
								Position = c81213A,
								Proxy = string_,
								TypeProxy = A01ECB,
								DisableSound = true,
								App = text27,
								cUid = text18,
								cPassword = text23,
								cFa2 = text22,
								cToken = text25,
								cId = string_3,
								Row = int_4
							};
							if (gclass8_1.GetValueBool("Unlock956"))
							{
								f336F52E.Boolean_3 = true;
							}
							string text32;
							if (bool_0)
							{
								method_86(int_4, F8A1A + Language.GetValue("Đã dừng!"));
								num2 = 1;
							}
							else
							{
								int num10 = 0;
								while (true)
								{
									var (flag6, text30) = f336F52E.Open();
									bool flag8;
									string text35;
									bool flag9;
									if (flag6)
									{
										if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP") && string_.Split(':').Length > 1)
										{
											f336F52E.GotoURL("https://api.myip.com/");
											f336F52E.DelayTime(1.0);
											string text31 = f336F52E.GetPageSource();
											if (!text31.Contains("ip"))
											{
												f336F52E.CloseChrome();
												num10++;
												if (num10 >= 3)
												{
													method_86(int_4, F8A1A + Language.GetValue("Lỗi kết nối proxy!"));
													num2 = 1;
													break;
												}
												continue;
											}
										}
										method_100(f336F52E);
										if (gclass8_1.GetValueBool("OpenBrowser"))
										{
											if (SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbAddChromeIntoForm"))
											{
												fViewChrome.DFADBD37.method_3(f336F52E.IndexChrome, f336F52E.Size.X, f336F52E.Size.Y - 10);
												fViewChrome.DFADBD37.method_1(f336F52E.Process_0.MainWindowHandle, f336F52E.IndexChrome, f336F52E.Size.X + 17, f336F52E.Size.Y, -10, 0);
											}
										}
										else if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbAddChromeIntoForm"))
										{
											if (text27 != "")
											{
												fViewChrome.DFADBD37.method_3(f336F52E.IndexChrome, f336F52E.Size.X - 33, f336F52E.Size.Y - 39);
												fViewChrome.DFADBD37.method_1(f336F52E.Process_0.MainWindowHandle, f336F52E.IndexChrome, f336F52E.Size.X, f336F52E.Size.Y);
											}
											else
											{
												fViewChrome.DFADBD37.method_3(f336F52E.IndexChrome, f336F52E.Size.X - 16, f336F52E.Size.Y - 132);
												fViewChrome.DFADBD37.method_1(f336F52E.Process_0.MainWindowHandle, f336F52E.IndexChrome, f336F52E.Size.X + 17, f336F52E.Size.Y, -10, -125);
											}
										}
										if (gclass8_1.GetValueBool("RecoverPass"))
										{
											int num11 = 0;
											int num12 = 3;
											while (true)
											{
												IL_11a2:
												f336F52E.GotoURL(text32);
												f336F52E.D38ABC24();
												bool flag7 = false;
												int num13 = 0;
												while (true)
												{
													if (num13 < 60)
													{
														if (f336F52E.CheckExistElement("[name=\"password_new\"]") != 1)
														{
															if (f336F52E.CheckExistElement("[href*=\"/login/identify/?ctx=recover\"]") != 1)
															{
																if (!CommonChrome.CheckCheckpoint(f336F52E))
																{
																	f336F52E.DelayTime(1.0);
																	num13++;
																	continue;
																}
																method_86(int_4, "Checkpoint!");
																method_87(int_4, "Checkpoint");
																num2 = 1;
																break;
															}
															if (f336F52E.CheckExistElement("[href*=\"/help/177066345680802\"]") == 1)
															{
																method_86(int_4, F8A1A + "Fb Block!");
																num2 = 1;
																break;
															}
															num11++;
															if (num11 >= num12)
															{
																method_86(int_4, F8A1A + "Không lấy được otp!");
																num2 = 1;
																break;
															}
															method_86(int_4, F8A1A + "Get otp...");
															text32 = method_32(2, text19, text20, 60, text18, text32);
															if (text32.StartsWith("https"))
															{
																goto IL_11a2;
															}
														}
														else
														{
															flag7 = true;
														}
													}
													if (flag7)
													{
														flag7 = false;
														f336F52E.DelayTime(2.0);
														string text33 = AE8404BB();
														f336F52E.SendKeys(4, "[name=\"password_new\"]", text33);
														f336F52E.DelayRandom(2, 3);
														f336F52E.Click("[value=\"kill_sessions\"]");
														f336F52E.SendEnter("[name=\"password_new\"]");
														method_91(string_3, "pass", int_4, "cPassword", text33);
														for (int i = 0; i < 60; i++)
														{
															string text34 = f336F52E.GetURL();
															if (!text34.Contains("facebook.com/si/actor_experience/actor_gateway"))
															{
																if (!(f336F52E.CheckExistElements(0.0, new List<string> { "[name=\"approvals_code\"]", "#MComposer", "[href*=\"facebook.com/secure_account_learn_more\"]", "[name=\"manage-sessions\"]" }) != ""))
																{
																	if (f336F52E.CheckExistElement("[name=\"submit_action\"]") != 1)
																	{
																		if (f336F52E.CheckExistElement("[data-sigil=\"m_login_email\"]") == 1)
																		{
																			break;
																		}
																		if (!CommonChrome.CheckCheckpoint(f336F52E))
																		{
																			f336F52E.DelayTime(1.0);
																			continue;
																		}
																		method_87(int_4, "Checkpoint");
																		flag7 = true;
																		break;
																	}
																	f336F52E.DelayRandom(2, 3);
																	f336F52E.Click(4, "[name=\"submit_action\"]");
																	if (f336F52E.CheckExistElement("[value=\"OK\"]", 10.0) == 1)
																	{
																		f336F52E.DelayRandom(2, 3);
																		f336F52E.Click(4, "[value=\"OK\"]");
																	}
																	flag7 = true;
																	break;
																}
																flag7 = true;
																break;
															}
															flag7 = true;
															break;
														}
													}
													if (flag7)
													{
														method_87(int_4, "Live");
														method_96(int_4, 2);
														method_86(int_4, F8A1A + "Khôi phục mật khẩu thành công!");
													}
													else
													{
														method_96(int_4, 1);
														method_86(int_4, F8A1A + "Khôi phục mật khẩu thất bại!");
													}
													num2 = 1;
													break;
												}
												break;
											}
											break;
										}
										method_86(int_4, F8A1A + Language.GetValue("Đang đăng nhâ\u0323p..."));
										flag8 = false;
										text35 = "https://www.facebook.com/";
										switch (SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeBrowserLogin"))
										{
										case 0:
											text35 = "https://m.facebook.com/";
											break;
										case 2:
											text35 = "https://mbasic.facebook.com";
											break;
										case 3:
											flag8 = true;
											break;
										}
										if (gclass8_1.GetValueBool("Unlock956") && gclass8_1.GetValueInt("TypeUnlock956") == 2)
										{
											text35 = "https://www.facebook.com/";
										}
										if (!f336F52E.GetURL().Contains("facebook.com"))
										{
											f336F52E.GotoURL(text35);
											if (f336F52E.GetCookieFromChrome().Contains("i_user"))
											{
												f336F52E.DeleteCookieNamedz("i_user");
												f336F52E.GotoURL(text35);
												f336F52E.SetSize(point_.X, point_.Y);
												f336F52E.method_54(c81213A.X, c81213A.Y);
											}
										}
										if (f336F52E.Proxy != "")
										{
											f336F52E.DelayTime(2.0);
											if (f336F52E.GetPageSource() == "<html><head></head><body></body></html>")
											{
												method_86(int_4, F8A1A + "Proxy yêu cầu User/Pass!");
												num2 = 1;
												break;
											}
										}
										flag9 = false;
										if (text29.Trim() != "")
										{
											f336F52E.AcceptCookie();
											switch (CommonChrome.CheckLiveCookie(f336F52E, text35))
											{
											case -3:
												f336F52E.Status = StatusChromeAccount.NoInternet;
												goto end_IL_0e80;
											case -2:
												f336F52E.Status = StatusChromeAccount.ChromeClosed;
												goto end_IL_0e80;
											case 1:
												flag = true;
												goto IL_1655;
											case 2:
												break;
											default:
												goto IL_1655;
											}
											f336F52E.Status = StatusChromeAccount.Checkpoint;
											if (flag2 = !Common.IsUid(text18))
											{
												text = text18;
												text18 = f336F52E.GetUIDFromCookies();
												BC0C40BD(int_4, "cUid", text18, "uid");
											}
											if (gclass8_1.GetValueBool("Unlock956"))
											{
												flag9 = true;
												goto IL_1a28;
											}
											if (!method_30(f336F52E, int_4, F8A1A))
											{
												num2 = 1;
												break;
											}
											flag = true;
										}
										goto IL_1655;
									}
									method_86(int_4, F8A1A + Language.GetValue("Lỗi mở trình duyệt!") + ((text30 != "") ? (" (" + text30 + ")") : ""));
									num2 = 1;
									break;
									IL_1951:
									method_86(int_4, F8A1A + Language.GetValue("Mã 2fa không đúng!"));
									goto IL_1a07;
									IL_186f:
									f336F52E.Status = StatusChromeAccount.Checkpoint;
									if (flag2 = !Common.IsUid(text18))
									{
										text = text18;
										text18 = f336F52E.GetUIDFromCookies();
										CommonSQL.UpdateFieldToAccount(string_3, "uid", text18);
										B034598F(int_4, "cUid", text18);
									}
									if (gclass8_1.GetValueBool("Unlock956"))
									{
										flag9 = true;
										goto IL_1a28;
									}
									flag = method_30(f336F52E, int_4, F8A1A);
									goto IL_1a07;
									IL_18d9:
									int num14;
									if (num14 != 2)
									{
										method_86(int_4, F8A1A + Language.GetValue("Không có 2fa!"));
									}
									else
									{
										flag = true;
									}
									goto IL_1a07;
									IL_1909:
									method_86(int_4, F8A1A + Language.GetValue("Tài khoản không đúng!"));
									goto IL_1a07;
									IL_1867:
									flag = true;
									goto IL_1a07;
									IL_1a28:
									if (gclass8_1.GetValueBool("Unlock956"))
									{
										if (flag9)
										{
											f336F52E.Status = StatusChromeAccount.Empty;
											bool flag10;
											if (flag10 = method_30(f336F52E, int_4, F8A1A, gclass8_1.GetValueBool("Unlock956"), gclass8_1.GetValueInt("TypeUnlock956")))
											{
												method_87(int_4, "Live");
												method_86(int_4, "Unlock checkpoint success!");
											}
											method_96(int_4, (!flag10) ? 1 : 2);
										}
										else if (flag)
										{
											method_87(int_4, "Live");
											method_86(int_4, F8A1A + Language.GetValue("Đăng nhâ\u0323p tha\u0300nh công!"));
											method_96(int_4, 2);
										}
										if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || text24 == "")
										{
											text24 = f336F52E.GetCookieFromChrome();
											if (text24 != "")
											{
												BC0C40BD(int_4, "cCookies", text24, "cookie1");
											}
										}
										num2 = 1;
										break;
									}
									method_87(int_4, "Live");
									method_86(int_4, F8A1A + Language.GetValue("Đăng nhâ\u0323p tha\u0300nh công!"));
									method_96(int_4, 2);
									if (f336F52E.CheckExistElement("[href=\"/\"]") == 0)
									{
										f336F52E.AcceptCookie();
										if (f336F52E.GetURL().Contains("facebook.com/si/actor_experience/actor_gateway") && f336F52E.CheckExistElement("[data-nt=\"NT:IMAGE\"]", 15.0) == 1)
										{
											f336F52E.ExecuteJSClick("[data-nt=\"NT:IMAGE\"]");
											f336F52E.DelayTime(2.0);
										}
										if (f336F52E.CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
										{
											f336F52E.ExecuteJSClick("[data-cookiebanner=\"accept_button\"]");
										}
										if (f336F52E.GetFbWeb() == 2)
										{
											f336F52E.ExecuteJSClickFB(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
										}
										if (f336F52E.GetURL().StartsWith("https://free.facebook.com/") || f336F52E.CheckExistElement("[href^=\"/upsell/advanced_upsell/in_line\"]") == 1)
										{
											f336F52E.ExecuteJSClickFB(0, "[href^=\"/upsell/advanced_upsell/in_line\"]");
											f336F52E.ExecuteJSClickFB(5, "#upsell_upgrade_confirm_button");
										}
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || text24 == "")
									{
										text24 = f336F52E.GetCookieFromChrome();
										if (text24 != "")
										{
											BC0C40BD(int_4, "cCookies", text24, "cookie1");
										}
									}
									if (text18 != f336F52E.GetUIDFromCookies())
									{
										f336F52E.method_70(text18);
									}
									if (flag2 = !Common.IsUid(text18))
									{
										text = text18;
										text18 = f336F52E.GetUIDFromCookies();
										CommonSQL.UpdateFieldToAccount(string_3, "uid", text18);
										B034598F(int_4, "cUid", text18);
									}
									method_100(f336F52E);
									if (gclass8_1.GetValueBool("OpenBrowser"))
									{
										if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetToken"))
										{
											switch (SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeToken"))
											{
											case 0:
												text25 = f336F52E.GetTokenEAAG();
												break;
											case 1:
												text25 = f336F52E.GetTokenEAABw();
												break;
											case 2:
												text25 = f336F52E.GetTokenEAABs();
												break;
											case 3:
												text25 = CommonChrome.GetTokenEAAAAU(f336F52E, text18, text23, text22);
												break;
											}
											if (text25 != "")
											{
												CommonSQL.UpdateFieldToAccount(string_3, "token", text25);
												B034598F(int_4, "cToken", text25);
											}
										}
										num2 = 1;
										break;
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDisableChatSettings"))
									{
										f336F52E.method_71();
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckBanBeGoiY") && text5 == "")
									{
										method_86(int_4, F8A1A + Language.GetValue("Check gợi ý kết bạn..."));
										text5 = "Yes";
										f336F52E.GotoURL("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
										if (f336F52E.ExecuteScript("return document.querySelectorAll('[data-sigil=\"m-add-friend-button-container\"]>div>div>div>a').length+''").ToString() == "0")
										{
											text5 = "No";
										}
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckSpam"))
									{
										string text36 = CommonChrome.RequestGet(f336F52E, "https://mbasic.facebook.com/support/?ref=settings", "https://mbasic.facebook.com/");
										if (text36.Contains("background-color: #4a90e2"))
										{
											flag3 = true;
										}
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAllowFollow"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Cho phe\u0301p ngươ\u0300i kha\u0301c follow..."));
										f336F52E.AllowFollow();
										method_57();
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbReviewTag"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Bật duyệt bài viết..."));
										method_17(f336F52E);
										method_57();
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBatThongBaoDangNhap"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Bật thông báo đăng nhập..."));
										AA17DFA0(f336F52E, int_4);
										method_57();
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCapNhatThongTin"))
									{
										try
										{
											method_86(int_4, F8A1A + Language.GetValue("Cập nhật thông tin..."));
											method_70(f336F52E, int_4, string_, A01ECB);
											f336F52E.DelayTime(2.0);
										}
										catch (Exception ex)
										{
											Common.ExportError2(null, ex.ToString());
										}
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetToken"))
									{
										switch (SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeToken"))
										{
										case 0:
											text25 = f336F52E.GetTokenEAAG();
											break;
										case 1:
											text25 = f336F52E.GetTokenEAABw();
											break;
										case 2:
											text25 = f336F52E.GetTokenEAABs();
											break;
										case 3:
											text25 = CommonChrome.GetTokenEAAAAU(f336F52E, text18, text23, text22);
											break;
										}
										if (text25 != "")
										{
											CommonSQL.UpdateFieldToAccount(string_3, "token", text25);
											B034598F(int_4, "cToken", text25);
										}
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbWallPosts"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Check Wall posts..."));
										f336F52E.GotoURL("https://mbasic.facebook.com/me?v=timeline");
										int num15 = f336F52E.CountElementWithXpath("#structured_composer_async_container>section>article");
										if (num15 >= 0)
										{
											if (f336F52E.CheckExistElement("[href^=\"/profile/timeline/stream/?cursor=\"]") == 1)
											{
												BC0C40BD(int_4, "cWallPosts", num15 + "+", "wallPosts");
											}
											else
											{
												BC0C40BD(int_4, "cWallPosts", num15.ToString() ?? "", "wallPosts");
											}
										}
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCauHinhTaiKhoan"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Cấu hình tài khoản..."));
										method_33(f336F52E);
										f336F52E.DelayTime(2.0);
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCongKhaiBanBe"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Cấu hình tài khoản..."));
										A9B660BC(f336F52E);
										f336F52E.DelayTime(2.0);
									}
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbLogOut"))
									{
										method_86(int_4, F8A1A + Language.GetValue("Đăng xuất..."));
										E5116117(f336F52E);
									}
									break;
									IL_1a07:
									if (!flag)
									{
										method_96(int_4, 1);
										method_37(f336F52E, text18, 1);
										num2 = 1;
										break;
									}
									goto IL_1a28;
									IL_1655:
									string text37;
									if (!flag)
									{
										num14 = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeLogin");
										bool flag11 = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDontSaveBrowser");
										if (gclass8_1.GetValueBool("OpenBrowser") && SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbKhongLuuTrinhDuyet"))
										{
											flag11 = true;
										}
										switch (num14)
										{
										case 1:
											method_86(int_4, F8A1A + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng email|pass..."));
											goto default;
										case 2:
										case 3:
											method_86(int_4, F8A1A + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng cookie..."));
											goto default;
										case 0:
											method_86(int_4, F8A1A + Language.GetValue("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
											goto default;
										default:
										{
											text37 = CommonChrome.LoginFacebook(f336F52E, num14, text35, text18, text19, text23, text22, text24, flag11, flag8);
											if (num14 != 3 || new List<string> { "1", "2", "8" }.Contains(text37))
											{
												break;
											}
											num14 = 0;
											int num16 = 0;
											int num17 = 0;
											goto case 0;
										}
										}
										string text38 = text37;
										string text39 = text38;
										if (text39 != null)
										{
											int length = text39.Length;
											if (length == 1)
											{
												switch (text39[0])
												{
												case '0':
													break;
												case '1':
													goto IL_1867;
												case '2':
													goto IL_186f;
												case '3':
													goto IL_18d9;
												case '4':
													goto IL_1909;
												case '5':
													goto IL_1927;
												case '6':
													goto IL_1951;
												case '8':
													goto IL_196f;
												default:
													goto IL_19f6;
												}
												method_86(int_4, F8A1A + Language.GetValue("Đăng nhập thất bại!"));
												goto IL_1a07;
											}
											if (length == 2)
											{
												char c = text39[1];
												if (c != '2')
												{
													if (c == '3' && text39 == "-3")
													{
														f336F52E.Status = StatusChromeAccount.NoInternet;
														break;
													}
												}
												else if (text39 == "-2")
												{
													f336F52E.Status = StatusChromeAccount.ChromeClosed;
													goto IL_1a07;
												}
											}
										}
										goto IL_19f6;
									}
									goto IL_1a07;
									IL_1927:
									method_86(int_4, F8A1A + Language.GetValue("Mật khẩu không đúng!"));
									method_87(int_4, "Changed pass");
									goto IL_1a07;
									IL_196f:
									method_87(int_4, "Live");
									method_96(int_4, 2);
									if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || text24 == "")
									{
										text24 = f336F52E.GetCookieFromChrome();
										if (text24 != "")
										{
											BC0C40BD(int_4, "cCookies", text24, "cookie1");
										}
									}
									method_86(int_4, F8A1A + Language.GetValue("Account Novery!"));
									goto IL_1a07;
									IL_19f6:
									method_86(int_4, F8A1A + text37);
									goto IL_1a07;
									continue;
									end_IL_0e80:
									break;
								}
							}
							goto end_IL_04e5;
							IL_0596:
							if (gclass8_1.GetValueBool("Bat2FA"))
							{
								flag5 = true;
								method_86(int_4, "Bật 2FA...");
								string string_5 = "Bật 2fa fail!";
								if (text25.Trim() != "")
								{
									string text40 = method_28(text23, text25, string_, A01ECB);
									if (text40 != "")
									{
										BC0C40BD(int_4, "cFa2", text40, "fa2");
										string_5 = "Bật 2fa Success!";
									}
								}
								method_86(int_4, string_5);
							}
							if (gclass8_1.GetValueBool("UpAvatar"))
							{
								flag5 = true;
								method_86(int_4, "Up Avatar...");
								string string_6 = "Up Avatar fail!";
								if (text25.Trim() != "")
								{
									RequestXNet fB87CFA = new RequestXNet("", "", string_, A01ECB);
									string text41 = "";
									try
									{
										text41 = fB87CFA.RequestPost("https://graph.facebook.com/me/photos?access_token=" + text25, "url=" + new RequestXNet("", "", "", 0).RequestGet("https://download.minsoftware.vn/photos/"));
										if (text41 != "")
										{
											JObject jObject = JObject.Parse(text41);
											string text42 = jObject["id"].ToString();
											text41 = fB87CFA.RequestPost("https://graph.facebook.com/me/picture?access_token=" + text25, "focus_y=0.49902534&focus_x=0.5&photo=" + text42 + "&no_feed_story=false&locale=en_US&client_country_code=VN&fb_api_req_friendly_name=set_cover_photo&fb_api_caller_class=SetCoverPhotoHandlerImpl");
											if (text41 != "")
											{
												string_6 = "Up Avatar Success!";
											}
										}
									}
									catch (Exception)
									{
										text41 = fB87CFA.httpRequest.Response.ToString();
									}
								}
								method_86(int_4, string_6);
							}
							if (flag5)
							{
								num2 = 1;
							}
							else
							{
								text32 = "";
								if (!gclass8_1.GetValueBool("RecoverPass"))
								{
									goto IL_0929;
								}
								method_86(int_4, F8A1A + "Check Email|Passmail...");
								method_86(int_4, F8A1A + "Gư\u0309i yêu câ\u0300u khôi phục mật khẩu...");
								num = method_23(text19, string_, A01ECB);
								switch (num)
								{
								case 0:
									method_86(int_4, F8A1A + "Mail chưa đăng ky\u0301 Fb!");
									break;
								case 1:
									method_86(int_4, F8A1A + "Gư\u0309i yêu câ\u0300u tha\u0300nh công!");
									break;
								case 2:
									method_86(int_4, F8A1A + "Lô\u0303i gửi yêu cầu!");
									break;
								case 3:
									method_86(int_4, F8A1A + "Gư\u0309i yêu câ\u0300u thâ\u0301t ba\u0323i!");
									break;
								case 4:
									method_86(int_4, F8A1A + "Chặn tính năng!");
									break;
								}
								if (num == 1)
								{
									int num18 = 0;
									while (true)
									{
										if (num18 >= 2)
										{
											goto IL_08d7;
										}
										method_86(int_4, F8A1A + "Get otp...");
										text32 = method_32(2, text19, text20, 60, text18, "");
										if (!(text32 == "fail"))
										{
											if (!text32.StartsWith("https") && num18 != 1)
											{
												method_86(int_4, F8A1A + "Gư\u0309i yêu câ\u0300u khôi phục mật khẩu (2)...");
												method_23(text19, string_, A01ECB);
												num18++;
												continue;
											}
											goto IL_08d7;
										}
										method_86(int_4, F8A1A + "Không lấy được otp!");
										num2 = 1;
										goto end_IL_04e5;
										IL_08d7:
										if (!(text32 == "") && text32.StartsWith("https"))
										{
											method_86(int_4, F8A1A + "Get otp thành công!");
											break;
										}
										method_86(int_4, F8A1A + "Không lấy được otp!");
										num2 = 1;
										goto end_IL_04e5;
									}
									goto IL_0929;
								}
								num2 = 1;
							}
							end_IL_04e5:;
						}
						catch (Exception exception_)
						{
							method_86(int_4, F8A1A + Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
							num2 = 1;
							Common.ExportError(f336F52E, exception_, Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
						}
					}
				}
			}
			goto IL_221e;
			IL_046c:
			method_86(int_4, F8A1A + Language.GetValue("Đã dừng!"));
			num2 = 1;
			goto IL_221e;
			IL_221e:
			string text43 = "";
			if (num2 == 1)
			{
				if (f336F52E != null)
				{
					if (f336F52E.Status == StatusChromeAccount.Checkpoint)
					{
						method_37(f336F52E, text18, 0);
					}
					switch (f336F52E.Status)
					{
					default:
						text43 = D491BE25(int_4);
						break;
					case StatusChromeAccount.ChromeClosed:
					case StatusChromeAccount.Checkpoint:
					case StatusChromeAccount.NoInternet:
						method_96(int_4, 1);
						text43 = GetContentStatusChrome.D6001D3E(f336F52E.Status);
						text24 = f336F52E.GetCookieFromChrome();
						break;
					}
				}
				else
				{
					text43 = D491BE25(int_4);
				}
			}
			else if (Common.IsUid(text18) && CheckInfoAccountv2.CheckLiveWall(text18).StartsWith("0|"))
			{
				method_87(int_4, "Die");
				text43 = Language.GetValue("Tài khoản Die!");
			}
			else
			{
				f336F52E.Status = StatusChromeAccount.Empty;
				CommonChrome.CheckStatusAccount(f336F52E, isSendRequest: true);
				switch (f336F52E.Status)
				{
				case StatusChromeAccount.ChromeClosed:
				case StatusChromeAccount.Checkpoint:
				case StatusChromeAccount.NoInternet:
					method_96(int_4, 1);
					text43 = GetContentStatusChrome.D6001D3E(f336F52E.Status);
					text24 = f336F52E.GetCookieFromChrome();
					break;
				}
			}
			if (gclass8_1.GetValueBool("OpenBrowser"))
			{
				if (!flag && SettingsTool.GetSettings("configOpenBrowser").GetValueBool("isAutoCloseChromeLoginFail"))
				{
					method_29(int_4, F8A1A, f336F52E);
				}
				else
				{
					if (SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbAutoOpenLink"))
					{
						f336F52E.GotoURL(SettingsTool.GetSettings("configOpenBrowser").GetValue("txtLink"));
					}
					if (SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbLoginHotmail") && (text19.Contains("hotmail") || text19.Contains("outlook")))
					{
						f336F52E.OpenNewTab("https://outlook.live.com");
						string json = f336F52E.LoginHotmail(text19, text20, text21);
						JObject jObject2 = JObject.Parse(json);
						if (!Convert.ToBoolean(jObject2["success"]))
						{
							text43 = F8A1A + jObject2["error"].ToString() + "!";
						}
						else
						{
							if (jObject2["mailRecover"].ToString() != "" && jObject2["mailRecover"].ToString() != text21)
							{
								text21 = jObject2["mailRecover"].ToString();
								BC0C40BD(int_4, "cMailRecovery", text21, "mailrecovery");
							}
							if (text20 != jObject2["passmail"].ToString())
							{
								text20 = jObject2["passmail"].ToString();
								BC0C40BD(int_4, "cPassMail", text20, "passmail");
							}
							text43 = F8A1A + "Login hotmail success!";
						}
					}
				}
			}
			else
			{
				try
				{
					if (f336F52E != null)
					{
						if (!f336F52E.CheckIsLive() && SettingsTool.GetSettings("configGeneral").GetValueBool("ckbDelayCloseChrome"))
						{
							int int_6 = Base.rd.Next(SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCloseChromeFrom"), SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCloseChromeTo") + 1);
							method_86(int_4, F8A1A + "Đóng tri\u0300nh duyê\u0323t sau {time}s...", int_6);
						}
						method_29(int_4, F8A1A, f336F52E);
					}
				}
				catch
				{
				}
			}
			string text44 = "";
			if (text3 != "")
			{
				text44 = text44 + "- " + text3;
			}
			if (text4 != "")
			{
				text44 = text44 + "- " + text4;
			}
			if (text5 != "")
			{
				text44 = text44 + "- " + Language.GetValue("Gợi ý Kb: ") + text5;
			}
			if (text6 != "")
			{
				text44 = text44 + "- " + Language.GetValue("Xóa Sđt: ") + text6;
			}
			if (text7 != "")
			{
				text44 = text44 + "- Add mail: " + text7;
			}
			if (text8 != "")
			{
				text44 = text44 + "- Xóa mail: " + text8;
			}
			if (text9 != "")
			{
				text44 = text44 + "- Đổi pass: " + text9;
			}
			if (text10 != "")
			{
				text44 = text44 + "- Đổi tên: " + text10;
			}
			if (text11 != "")
			{
				text44 = text44 + "- Up avatar: " + text11;
			}
			if (text12 != "")
			{
				text44 = text44 + "- Up cover: " + text12;
			}
			if (text13 != "")
			{
				text44 = text44 + "- 2FA: " + text13;
			}
			if (text14 != "")
			{
				text44 = text44 + "- Tạo page: " + text14;
			}
			if (text16 != "")
			{
				text44 = text44 + "- Share page: " + text16;
			}
			if (f336F52E != null && f336F52E.Boolean_2)
			{
				text44 += "- Fb Block";
				BC0C40BD(int_4, "cFbBlock", "Yes", "fbBlock");
			}
			if (num5 > -1)
			{
				text44 = text44 + "- Share: " + num5;
			}
			if (num7 > -1)
			{
				text44 = text44 + "- Job success: " + num7;
				method_89(int_4, num7);
			}
			if (text17 != "")
			{
				text44 = text44 + " (" + text17 + ")";
			}
			if (num6 > -1 && Base.bool_0)
			{
				text44 = text44 + "- Comment: " + num6;
			}
			if (text15 != "")
			{
				text44 = text44 + "- Unlink Instagram: " + text15;
			}
			string text45 = text43;
			string text46 = text45;
			if (!(text46 == ""))
			{
				method_86(int_4, F8A1A + text43);
			}
			else
			{
				string text47 = "";
				switch (num4)
				{
				case 1:
					text47 += " -Like page success!";
					break;
				case 2:
					text47 += " -Like page fail!";
					break;
				}
				switch (num3)
				{
				case 1:
					text47 += " -Follow success!";
					break;
				case 2:
					text47 += " -Follow fail!";
					break;
				}
				method_86(int_4, F8A1A + Language.GetValue("Đã tương tác xong!") + (flag3 ? "- Facebook spam!" : "") + text47 + ((text2 != "") ? ("- " + text2) : "") + text44 + " [" + dCBEFE8F.method_0() + "(s)]");
				BC0C40BD(int_4, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
				if (method_92(int_4) != "Changed pass")
				{
					method_87(int_4, "Live");
				}
			}
			if (flag2 && Directory.Exists(SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text) && text != "")
			{
				string c63B = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
				string string_7 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text18;
				if (!Common.MoveFile(c63B, string_7) && Common.CopyFolder(c63B, string_7))
				{
					Common.DeleteFile(c63B);
				}
			}
			method_22(f722CFA1_, d918F1B6_, class10_, AC3DEE, C6B, gclass4_, b1818408_);
		}
		catch (Exception ex3)
		{
			if (ex3.ToString().Contains("Thread was being aborted."))
			{
				try
				{
					method_29(int_4, F8A1A, f336F52E);
					method_86(int_4, F8A1A + Language.GetValue("Đã tương tác xong!") + " [" + dCBEFE8F.method_0() + "(s)]");
					B034598F(int_4, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					CommonSQL.UpdateFieldToAccount(string_3, "interactEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					method_22(f722CFA1_, d918F1B6_, class10_, AC3DEE, C6B, gclass4_, b1818408_);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private List<GClass3> method_20(ref int int_4)
	{
		List<GClass3> list = new List<GClass3>();
		switch (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"))
		{
		case 7:
		{
			List<string> list5 = EF9D6E89();
			if (list5.Count != 0)
			{
				for (int l = 0; l < list5.Count; l++)
				{
					list.Add(new TinsoftProxy("http://proxy.tinsoftsv.com", list5[l], SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTinsoft"), SettingsTool.GetSettings("configGeneral").GetValueInt("cbbLocationTinsoft")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTinsoft") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTinsoft");
				}
			}
			break;
		}
		case 8:
		{
			List<string> list7 = SettingsTool.GetSettings("configGeneral").GetValueList("txtListProxy");
			if (list7.Count != 0)
			{
				for (int n = 0; n < list7.Count; n++)
				{
					list.Add(new XproxyProxy(SettingsTool.GetSettings("configGeneral").GetValue("txtServiceURLXProxy"), list7[n], SettingsTool.GetSettings("configGeneral").GetValueInt("typeProxy"), SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPXProxy")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPXProxy") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPXProxy");
				}
			}
			break;
		}
		default:
			list = null;
			break;
		case 10:
		{
			List<string> list3 = SettingsTool.GetSettings("configGeneral").GetValueList("txtApiKeyTMProxy");
			if (list3.Count != 0)
			{
				for (int j = 0; j < list3.Count; j++)
				{
					list.Add(new TMProxy(list3[j], 0, SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTMProxy")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTMProxy") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTMProxy");
				}
			}
			break;
		}
		case 11:
		{
			List<string> list8 = SettingsTool.GetSettings("configGeneral").GetValueList("txtListProxyv6");
			if (list8.Count != 0)
			{
				for (int num = 0; num < list8.Count; num++)
				{
					list.Add(new Proxyv6(list8[num], SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyv6")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyv6") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyv6");
				}
			}
			break;
		}
		case 12:
		{
			List<string> list9 = SettingsTool.GetSettings("configGeneral").GetValueList("txtApiShopLike");
			if (list9.Count != 0)
			{
				for (int num2 = 0; num2 < list9.Count; num2++)
				{
					list.Add(new ShopLike(list9[num2], 0, SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPShopLike")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPShopLike") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPShopLike");
				}
			}
			break;
		}
		case 13:
		{
			List<string> list4 = SettingsTool.GetSettings("configGeneral").GetValueList("txtApiKeyMinProxy");
			if (list4.Count != 0)
			{
				for (int k = 0; k < list4.Count; k++)
				{
					list.Add(new MinProxy(SettingsTool.GetSettings("configGeneral").GetValueInt("typeMin"), list4[k], SettingsTool.GetSettings("configGeneral").GetValueInt("typeProxyMin"), SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPMinProxy")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPMinProxy") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPMinProxy");
				}
			}
			break;
		}
		case 14:
		{
			List<string> list6 = SettingsTool.GetSettings("configGeneral").GetValueList("txtListObcProxy");
			if (list6.Count == 0)
			{
				break;
			}
			F93ADB36 = new List<OBCProxy>();
			Dictionary<string, List<string>> source = OBCProxy.CF83EB05(SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy"));
			for (int m = 0; m < list6.Count; m++)
			{
				string string_0 = list6[m].Split(':')[1];
				string key = source.FirstOrDefault((KeyValuePair<string, List<string>> keyValuePair_0) => keyValuePair_0.Value.Contains(string_0)).Key;
				if (!string.IsNullOrEmpty(key))
				{
					OBCProxy gClass = OBCProxy.smethod_0(F93ADB36, key);
					if (gClass == null)
					{
						gClass = new OBCProxy(key);
						F93ADB36.Add(gClass);
					}
					OBCProxyv2 b = new OBCProxyv2(SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy"), list6[m], 0, SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPObcProxy"), key);
					list.Add(b);
					gClass.DC37D601(b);
				}
			}
			if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPObcProxy") < int_4)
			{
				int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPObcProxy");
			}
			break;
		}
		case 15:
		{
			List<string> list2 = SettingsTool.GetSettings("configGeneral").GetValueList("txtApiKeyProxyFb");
			if (list2.Count != 0)
			{
				for (int i = 0; i < list2.Count; i++)
				{
					list.Add(new TinsoftProxy("http://api.proxyfb.com", list2[i], SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyFb")));
				}
				if (list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyFb") < int_4)
				{
					int_4 = list.Count * SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyFb");
				}
			}
			break;
		}
		}
		return list;
	}

	private void method_21(int AB928E97, ref bool bool_5, ref string string_1, ref int A01ECB00, ref string F8A1A713, ref string string_2, ref TinsoftProxy f722CFA1_0, ref XproxyProxy d918F1B6_0, ref TMProxy class10_0, ref Proxyv6 AC3DEE88, ref ShopLike C6B50303, ref MinProxy gclass4_0, ref OBCProxyv2 b1818408_0)
	{
		while (true)
		{
			bool flag4;
			int num;
			int num2;
			switch (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"))
			{
			case 7:
			case 15:
				method_86(AB928E97, "Get Proxy...");
				lock (AF386606)
				{
					while (!bool_5)
					{
						f722CFA1_0 = null;
						while (!bool_5)
						{
							foreach (TinsoftProxy item in list_0)
							{
								if (f722CFA1_0 == null || item.int_3 < f722CFA1_0.int_3)
								{
									f722CFA1_0 = item;
								}
							}
							if (f722CFA1_0.int_3 != f722CFA1_0.E18568BD)
							{
								break;
							}
						}
						if (bool_5)
						{
							break;
						}
						if (f722CFA1_0.int_3 > 0 || f722CFA1_0.BF3327BD())
						{
							string_1 = f722CFA1_0.B08A5B2F;
							if (string_1 == "")
							{
								string_1 = f722CFA1_0.method_0();
							}
							f722CFA1_0.B932E618++;
							f722CFA1_0.int_3++;
							break;
						}
					}
					if (bool_5)
					{
						return;
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay after change ip {time}s...", SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					bool flag7 = true;
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1.Split(':')[0] + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						string_2 = Common.CheckIP(string_1, 0);
						if (string_2 == "")
						{
							flag7 = false;
						}
					}
					if (!flag7)
					{
						f722CFA1_0.B932E618--;
						f722CFA1_0.int_3--;
						break;
					}
					return;
				}
			case 14:
				method_86(AB928E97, "Get Proxy...");
				lock (AF386606)
				{
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunObcProxy") == 0)
					{
						while (!bool_5)
						{
							b1818408_0 = null;
							List<OBCProxyv2> list2 = new List<OBCProxyv2>();
							foreach (OBCProxyv2 item2 in list_0)
							{
								if (item2.bool_0)
								{
									if (item2.int_1 < item2.A239012F)
									{
										list2.Add(item2);
									}
									else if (item2.FDB04602 == 0)
									{
										item2.resetOBCProxyv2();
										item2.int_1 = 0;
									}
								}
							}
							for (int k = 0; k < list2.Count; k++)
							{
								if (list2[k].AD1782BC(0))
								{
									b1818408_0 = list2[k];
									break;
								}
							}
							if (b1818408_0 != null)
							{
								string_1 = b1818408_0.B8A4A88E;
								A01ECB00 = b1818408_0.int_0;
								b1818408_0.FDB04602++;
								b1818408_0.int_1++;
								break;
							}
						}
					}
					else
					{
						while (!bool_5)
						{
							b1818408_0 = null;
							List<OBCProxyv2> list3 = new List<OBCProxyv2>();
							foreach (OBCProxy item3 in F93ADB36)
							{
								if (item3.method_3())
								{
									item3.resetOBCProxy();
									list3.AddRange(item3.method_1());
								}
								else
								{
									list3.AddRange(item3.BD05969B());
								}
							}
							for (int l = 0; l < list3.Count; l++)
							{
								if (list3[l].AD1782BC(0))
								{
									b1818408_0 = list3[l];
									break;
								}
							}
							if (b1818408_0 != null)
							{
								string_1 = b1818408_0.B8A4A88E;
								A01ECB00 = b1818408_0.int_0;
								b1818408_0.FDB04602++;
								b1818408_0.int_1++;
								break;
							}
						}
					}
					if (bool_5)
					{
						method_86(AB928E97, F8A1A713 + Language.GetValue("Đã dừng!"));
						return;
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay after change ip {time}s...", SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					bool flag6 = true;
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1 + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						string_2 = Common.CheckIP(string_1, A01ECB00);
						if (string_2 == "")
						{
							b1818408_0.bool_0 = false;
							flag6 = false;
						}
					}
					if (!flag6)
					{
						b1818408_0.FDB04602--;
						b1818408_0.int_1--;
						break;
					}
					return;
				}
			case 13:
				method_86(AB928E97, Language.GetValue("Đang lấy Api MinProxy..."));
				A01ECB00 = ((SettingsTool.GetSettings("configGeneral").GetValueInt("typeProxyMin") >= 2) ? 1 : 0);
				gclass4_0 = null;
				flag4 = false;
				num = 0;
				if (bool_5)
				{
					return;
				}
				lock (AF386606)
				{
					while (!bool_5)
					{
						foreach (MinProxy item4 in list_0)
						{
							if (item4.int_5 != 0)
							{
								if (gclass4_0 == null || item4.F888B48E < gclass4_0.F888B48E)
								{
									gclass4_0 = item4;
								}
								continue;
							}
							gclass4_0 = item4;
							break;
						}
						if (gclass4_0.F888B48E < gclass4_0.F939E28A)
						{
							break;
						}
					}
					if (gclass4_0 != null)
					{
						gclass4_0.int_5++;
						gclass4_0.F888B48E++;
						num = gclass4_0.F888B48E;
						goto IL_067c;
					}
				}
				goto IL_08e0;
			case 12:
				method_86(AB928E97, "Get Proxy...");
				lock (AF386606)
				{
					while (!bool_5)
					{
						C6B50303 = null;
						while (!bool_5)
						{
							foreach (ShopLike item5 in list_0)
							{
								if (C6B50303 == null || item5.int_2 < C6B50303.int_2)
								{
									C6B50303 = item5;
								}
							}
							if (C6B50303.int_2 != C6B50303.A7082819)
							{
								break;
							}
						}
						if (bool_5)
						{
							break;
						}
						if (C6B50303.int_2 > 0 || C6B50303.method_0())
						{
							string_1 = C6B50303.String_1;
							if (string_1 == "")
							{
								string_1 = C6B50303.method_1();
							}
							C6B50303.F69E79B7++;
							C6B50303.int_2++;
							break;
						}
					}
					if (bool_5)
					{
						return;
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay after change ip {time}s...", SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					bool flag3 = true;
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1.Split(':')[0] + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						string_2 = Common.CheckIP(string_1, 0);
						if (string_2 == "")
						{
							flag3 = false;
						}
					}
					if (!flag3)
					{
						C6B50303.F69E79B7--;
						C6B50303.int_2--;
						break;
					}
					return;
				}
			case 11:
				method_86(AB928E97, "Get Proxy...");
				lock (AF386606)
				{
					while (!bool_5)
					{
						AC3DEE88 = null;
						while (!bool_5)
						{
							foreach (Proxyv6 item6 in list_0)
							{
								if (AC3DEE88 == null || item6.int_1 < AC3DEE88.int_1)
								{
									AC3DEE88 = item6;
								}
							}
							if (AC3DEE88.int_1 != AC3DEE88.F2B49F13)
							{
								break;
							}
						}
						if (bool_5)
						{
							break;
						}
						if (AC3DEE88.int_1 > 0 || AC3DEE88.method_0())
						{
							string_1 = AC3DEE88.AB97B814;
							A01ECB00 = AC3DEE88.C3AE3F0D;
							AC3DEE88.int_0++;
							AC3DEE88.int_1++;
							break;
						}
					}
					if (bool_5)
					{
						return;
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay after change ip {time}s...", SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					bool flag5 = true;
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1.Split(':')[0] + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						for (int j = 0; j < 30; j++)
						{
							Common.Sleep(1.0);
							string_2 = Common.CheckIP(string_1, A01ECB00);
							if (string_2 != "")
							{
								break;
							}
							if (bool_5)
							{
								return;
							}
						}
						if (string_2 == "")
						{
							flag5 = false;
						}
					}
					if (!flag5)
					{
						AC3DEE88.int_0--;
						AC3DEE88.int_1--;
						break;
					}
					return;
				}
			case 10:
				method_86(AB928E97, "Get Proxy...");
				lock (AF386606)
				{
					while (!bool_5)
					{
						class10_0 = null;
						while (!bool_5)
						{
							foreach (TMProxy item7 in list_0)
							{
								if (class10_0 == null || item7.int_5 < class10_0.int_5)
								{
									class10_0 = item7;
								}
							}
							if (class10_0.int_5 != class10_0.int_6)
							{
								break;
							}
						}
						if (bool_5)
						{
							break;
						}
						if (class10_0.int_5 > 0 || class10_0.A9AD7D9C())
						{
							string_1 = class10_0.F137CCAF;
							if (string_1 == "")
							{
								string_1 = class10_0.BA90DC8B();
							}
							class10_0.int_4++;
							class10_0.int_5++;
							break;
						}
					}
					if (bool_5)
					{
						return;
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay after change ip {time}s...", SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					bool flag8 = true;
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1.Split(':')[0] + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						string_2 = Common.CheckIP(string_1, 0);
						if (string_2 == "")
						{
							flag8 = false;
						}
					}
					if (!flag8)
					{
						class10_0.int_4--;
						class10_0.int_5--;
						break;
					}
					return;
				}
			case 8:
				method_86(AB928E97, "Get Proxy...");
				lock (AF386606)
				{
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy") == 0)
					{
						while (!bool_5)
						{
							d918F1B6_0 = null;
							while (!bool_5)
							{
								foreach (XproxyProxy item8 in list_0)
								{
									if (item8.bool_0 && (d918F1B6_0 == null || item8.int_1 < d918F1B6_0.int_1))
									{
										d918F1B6_0 = item8;
									}
								}
								if (d918F1B6_0.int_1 != d918F1B6_0.int_2)
								{
									break;
								}
							}
							if (bool_5)
							{
								break;
							}
							if (d918F1B6_0.bool_0)
							{
								bool flag = false;
								if (d918F1B6_0.int_1 > 0)
								{
									flag = true;
								}
								else
								{
									switch (d918F1B6_0.method_2())
									{
									case 0:
										d918F1B6_0.bool_0 = false;
										break;
									case 1:
										flag = true;
										break;
									}
								}
								if (flag)
								{
									string_1 = d918F1B6_0.FF82632A;
									A01ECB00 = d918F1B6_0.E807DD1D;
									d918F1B6_0.int_0++;
									d918F1B6_0.int_1++;
									break;
								}
							}
							else
							{
								d918F1B6_0.bool_0 = false;
							}
						}
					}
					else
					{
						while (!bool_5)
						{
							d918F1B6_0 = null;
							List<XproxyProxy> list = new List<XproxyProxy>();
							foreach (XproxyProxy item9 in list_0)
							{
								if (item9.bool_0)
								{
									if (item9.int_1 < item9.int_2)
									{
										list.Add(item9);
									}
									else if (item9.int_0 == 0)
									{
										item9.resetXProxy();
										item9.int_1 = 0;
									}
								}
							}
							for (int i = 0; i < list.Count; i++)
							{
								if (list[i].C002B100(0))
								{
									d918F1B6_0 = list[i];
									break;
								}
							}
							if (d918F1B6_0 != null)
							{
								string_1 = d918F1B6_0.FF82632A;
								A01ECB00 = d918F1B6_0.E807DD1D;
								d918F1B6_0.int_0++;
								d918F1B6_0.int_1++;
								break;
							}
						}
					}
					if (bool_5)
					{
						return;
					}
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay after change ip {time}s...", SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					bool flag2 = true;
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1 + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						string_2 = Common.CheckIP(string_1, A01ECB00);
						if (string_2 == "")
						{
							d918F1B6_0.bool_0 = false;
							flag2 = false;
						}
					}
					if (!flag2)
					{
						d918F1B6_0.int_0--;
						d918F1B6_0.int_1--;
						break;
					}
					return;
				}
			default:
				return;
			case 9:
				{
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("cbbProxy") == 0)
					{
						string_1 = method_93(AB928E97, "cProxy");
						A01ECB00 = (string_1.EndsWith("*1") ? 1 : 0);
						if (string_1.EndsWith("*0") || string_1.EndsWith("*1"))
						{
							string_1 = string_1.Substring(0, string_1.Length - 2);
						}
					}
					else
					{
						string_1 = SettingsTool.GetSettings("configGeneral").GetValueList("txtProxy").GetRandomItem();
						if (string_1 == null)
						{
							string_1 = "";
						}
						A01ECB00 = SettingsTool.GetSettings("configGeneral").GetValueInt("cbbProxyType");
					}
					return;
				}
				IL_08e0:
				if (!flag4)
				{
					gclass4_0.int_5--;
					gclass4_0.F888B48E--;
					break;
				}
				return;
				IL_067c:
				method_86(AB928E97, Language.GetValue("Đang lấy Proxy từ API..."));
				num2 = 0;
				if (num > 1)
				{
					while (gclass4_0.bool_0)
					{
						Common.Sleep(1.0);
						num2++;
						if (num2 > 60)
						{
							break;
						}
					}
					string_1 = gclass4_0.D4B8F42D();
				}
				else
				{
					while (!bool_5)
					{
						switch (gclass4_0.method_2())
						{
						case 0:
							method_86(AB928E97, Language.GetValue("Đang lấy Proxy từ API: Chờ " + gclass4_0.Int32_3 + " s"));
							if (gclass4_0.Int32_3 > 10)
							{
								Common.Sleep(10.0);
							}
							else if (gclass4_0.Int32_3 > 0)
							{
								Common.Sleep(gclass4_0.Int32_3);
							}
							goto IL_0776;
						case 1:
							string_1 = gclass4_0.F3003736;
							gclass4_0.bool_0 = false;
							goto IL_0776;
						default:
							goto IL_0776;
						case -2:
							method_86(AB928E97, Language.GetValue("Api không đúng"));
							lock (AF386606)
							{
								list_0.Remove(gclass4_0);
							}
							break;
						case -1:
							method_86(AB928E97, Language.GetValue("Api hết hạn"));
							lock (AF386606)
							{
								list_0.Remove(gclass4_0);
							}
							break;
						}
						goto end_IL_12c9;
						IL_0776:
						if (string_1 != "")
						{
							break;
						}
					}
				}
				if (!(string_1 == ""))
				{
					flag4 = true;
					if (SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP") > 0)
					{
						method_86(AB928E97, F8A1A713 + "Delay check IP...");
						Common.Sleep(SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP"));
					}
					if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP"))
					{
						F8A1A713 = "(IP: " + string_1 + ") ";
						method_86(AB928E97, F8A1A713 + "Check IP...");
						string_2 = Common.CheckIP(string_1, A01ECB00);
						if (string_2 == "")
						{
							flag4 = false;
						}
					}
				}
				goto IL_08e0;
				end_IL_12c9:
				break;
			}
		}
	}

	private void method_22(TinsoftProxy f722CFA1_0, XproxyProxy d918F1B6_0, TMProxy class10_0, Proxyv6 class9_0, ShopLike D43F6FB9, MinProxy BFB70819, OBCProxyv2 b1818408_0)
	{
		lock (object_0)
		{
			switch (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp"))
			{
			case 8:
				d918F1B6_0?.method_3();
				break;
			case 10:
				class10_0?.B4ACC783();
				break;
			case 11:
				class9_0?.method_1();
				break;
			case 12:
				D43F6FB9?.D438FA8D();
				break;
			case 13:
				BFB70819?.method_1();
				break;
			case 14:
				b1818408_0?.DB92108C();
				break;
			case 7:
			case 15:
				f722CFA1_0?.E2854D06();
				break;
			case 9:
				break;
			}
		}
	}

	private int method_23(string EDA079BF, string string_1, int int_4)
	{
		try
		{
			RequestXNet fB87CFA = new RequestXNet("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", string_1, int_4);
			string text = fB87CFA.RequestGet("https://m.facebook.com/login/identify/?ctx=recover&c=https%3A%2F%2Fm.facebook.com%2F&multiple_results=0&ars=facebook_login&lwv=100&_rdr");
			string value = Regex.Match(text, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			string value2 = Regex.Match(text, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			if (text.Contains("cookie-policy-manage-dialog-accept-button"))
			{
				return 3;
			}
			string e5B = "lsd=" + value + "&jazoest=" + value2 + "&email=" + WebUtility.UrlEncode(EDA079BF) + "&did_submit=T%C3%ACm+ki%E1%BA%BFm";
			string text2 = fB87CFA.RequestPost("https://m.facebook.com/login/identify/?ctx=recover&c=%2Flogin%2F&search_attempts=1&ars=facebook_login&alternate_search=0&show_friend_search_filtered_list=0&birth_month_search=0&city_search=0", e5B);
			if (text2.Contains("login_identify_search_error_msg"))
			{
				return 0;
			}
			if (text2.Contains("571927962827151"))
			{
				return 4;
			}
			text2 = fB87CFA.RequestGet("https://m.facebook.com/recover/initiate/?c=%2Flogin%2F&fl=initiate_view&ctx=msite_initiate_view");
			value = Regex.Match(text2, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			value2 = Regex.Match(text2, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			text2 = fB87CFA.RequestPost("https://m.facebook.com/ajax/recover/initiate/?c=%2Flogin%2F&sr=0", "lsd=" + value + "&jazoest=" + value2 + "&recover_method=send_email&reset_action=Ti%E1%BA%BFp+t%E1%BB%A5c");
			if (text2.Contains("name=\"n\"") && text2.Contains(WebUtility.UrlEncode(EDA079BF)))
			{
				return 1;
			}
			return 3;
		}
		catch
		{
		}
		return 2;
	}

	public void AE1FE684(int E7369534, string D29A2311, string string_1, string F72D259B, int D13A5E0F)
	{
		var (text, text2) = CheckInfoAccountv2.CheckLiveDieAccount(string_1, F72D259B, D13A5E0F);
		if (text2 != "")
		{
			method_87(E7369534, text2);
		}
		if (text == "")
		{
			text = text2;
		}
		method_86(E7369534, D29A2311 + text + "!");
		string text3 = (text2 + text).ToLower();
		if (text3.Contains("live"))
		{
			method_96(E7369534, 2);
		}
		else if (text3.Contains("checkpoint"))
		{
			method_96(E7369534, 1);
		}
	}

	public void method_24(int int_4, string string_1, EF086887 ef086887_0)
	{
		string b0A4DABF = method_93(int_4, "cUid");
		string text = method_93(int_4, "cEmail");
		string a216F1AE = method_93(int_4, "cPassMail");
		string string_2 = method_93(int_4, "cBirthday");
		method_86(int_4, string_1 + "Unlock 956...");
		var (text2, text3, text4) = CheckInfoAccountv2.smethod_15(ef086887_0, b0A4DABF, text, a216F1AE, string_2);
		method_86(int_4, string_1 + text2 + "!");
		if (text3 != "")
		{
			method_87(int_4, text3);
		}
		if (text4 != "")
		{
			BC0C40BD(int_4, "cPassword", text4, "pass");
		}
		string text5 = (text3 + text2).ToLower();
		if (text5.Contains("live") || text5.Contains("success"))
		{
			method_96(int_4, 2);
		}
		else if (text5.Contains("checkpoint"))
		{
			method_96(int_4, 1);
		}
	}

	private void method_25(int int_4)
	{
		string text = method_93(int_4, "cCookies");
		if (text.Trim() == "")
		{
			method_86(int_4, Language.GetValue("Cookie trô\u0301ng!"));
			return;
		}
		method_93(int_4, "cUseragent").Trim();
		string text2 = "";
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
		{
			text2 = method_93(int_4, "cProxy");
			if (!text2.EndsWith("*1"))
			{
			}
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		method_86(int_4, Language.GetValue("Checking..."));
		try
		{
		}
		catch (Exception)
		{
			method_86(int_4, "Fail!");
		}
	}

	private int method_26(Chrome f336F52E_0, string string_1 = "")
	{
		string text = f336F52E_0.DomainFacebook(f336F52E_0.GetURL());
		if (string_1 == "")
		{
			string_1 = f336F52E_0.RequestGetHelper(text);
		}
		string string_2 = text + Regex.Match(string_1, "(/checkpoint/1501092823525282/logout/.*?)\"").Groups[1].Value.Replace("&amp;", "&");
		string_1 = f336F52E_0.RequestGetHelper(string_2);
		string value = Regex.Match(string_1, "sau (\\d+) ngày").Groups[1].Value;
		if (value == "")
		{
			value = Regex.Match(string_1, "are (\\d+) days").Groups[1].Value;
		}
		if (Common.IsNumber(value))
		{
			return Convert.ToInt32(value);
		}
		return -1;
	}

	private string D0BC6012(RequestXNet fb87CFA5_0, string string_1)
	{
		string result = "";
		for (int i = 0; i < 5; Common.Sleep(1.0), i++)
		{
			try
			{
				result = fb87CFA5_0.RequestGet(string_1);
			}
			catch (Exception)
			{
				continue;
			}
			break;
		}
		return result;
	}

	private void method_27(int int_4, string C08AA388, string string_1, string B2BBBA91, int int_5)
	{
		new RequestXNet(string_1, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", B2BBBA91, int_5);
	}

	public string method_28(string string_1, string string_2, string D9B6DC3C, int int_4)
	{
		string text = "";
		try
		{
			string text2 = "[FBAN/FB4A;FBAV/322.0.0.35.121;FBBV/297186297;FBDM/{density=2.75,width=1080,height=2130};FBLC/en_US;FBRV/298570471;FBCR/Viettel;FBMF/Xiaomi;FBBD/xiaomi;FBPN/com.facebook.katana;FBDV/Redmi Note 8;FBSV/10;FBOP/1;FBCA/arm64-v8a:;]";
			RequestXNet fB87CFA = new RequestXNet("", text2, D9B6DC3C, int_4);
			fB87CFA.httpRequest.AddHeader("Authorization", "OAuth " + string_2);
			string e5B = "method=POST&challenge_type=PASSWORD&challenge_params={\"password\":\"" + string_1 + "\"}&locale=en_US&client_country_code=VN&fb_api_req_friendly_name=validate_challenge&fb_api_caller_class=SecuredActionServiceHandler";
			string text3 = fB87CFA.RequestPost("https://graph.facebook.com/secured_action/validate_challenge", e5B);
			fB87CFA.httpRequest.AddHeader("X-FB-Net-HNI", " 45204");
			fB87CFA.httpRequest.AddHeader("X-FB-SIM-HNI", " 45201");
			fB87CFA.httpRequest.AddHeader("Authorization", " OAuth " + string_2);
			fB87CFA.httpRequest.AddHeader("X-FB-Connection-Type", " WIFI");
			fB87CFA.httpRequest.AddHeader("X-Tigon-Is-Retry", " False");
			fB87CFA.httpRequest.AddHeader("x-fb-rmd", " state=NO_MATCH");
			fB87CFA.httpRequest.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			fB87CFA.httpRequest.AddHeader("x-fb-device-group", " 5120");
			fB87CFA.httpRequest.AddHeader("X-FB-Friendly-Name", " PageCreationNewPage");
			fB87CFA.httpRequest.AddHeader("X-FB-Request-Analytics-Tags", " graphservice");
			fB87CFA.httpRequest.AddHeader("X-FB-HTTP-Engine", " Liger");
			fB87CFA.httpRequest.AddHeader("X-FB-Client-IP", " True");
			fB87CFA.httpRequest.AddHeader("X-FB-Server-Cluster", " True");
			fB87CFA.httpRequest.AddHeader("x-fb-connection-token", " f36ca4f6f658dd2e6a1f0ff6e43e6051");
			e5B = "doc_id=4330798123599254&method=post&locale=en_US&pretty=false&format=json&purpose=fetch&variables={\"params\":{\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"},\"path\":\"security/2fac/nt/setup/qr_code\",\"params\":\"{\\\"start_screen_id\\\":\\\"[\\\\\\\"__ntid:uu97dx:0__\\\\\\\",null]\\\"}\",\"extra_client_data\":{}},\"scale\":\"3\",\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"}}&fb_api_req_friendly_name=NativeTemplateScreenQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=[\"GraphServices\"]&server_timestamps=true";
			text3 = fB87CFA.RequestPost("https://graph.facebook.com/graphql/", e5B);
			text = Regex.Match(text3, "secret=(.*?)&").Groups[1].Value;
			if (text != "")
			{
				string text4 = Common.GetTotp(text);
				fB87CFA.httpRequest.AddHeader("X-FB-Net-HNI", " 45204");
				fB87CFA.httpRequest.AddHeader("X-FB-SIM-HNI", " 45201");
				fB87CFA.httpRequest.AddHeader("Authorization", "OAuth " + string_2);
				fB87CFA.httpRequest.AddHeader("X-FB-Connection-Type", " WIFI");
				fB87CFA.httpRequest.AddHeader("X-Tigon-Is-Retry", " False");
				fB87CFA.httpRequest.AddHeader("x-fb-rmd", " state=NO_MATCH");
				fB87CFA.httpRequest.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
				fB87CFA.httpRequest.AddHeader("x-fb-device-group", " 5120");
				e5B = "doc_id=6091464777534071&method=post&locale=en_US&pretty=false&format=json&variables=%7B%22scale%22%3A%223%22%2C%22params%22%3A%7B%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22payload%22%3A%22security%2F2fac%2Fnt%2Fsetup%2Fcode_entry%2Fsubmit%3Fcontent_id%3D%255B%2522__ntid%253Av10gun%253A1__%2522%252Cnull%255D%26error_element_id%3D%255B%2522__ntid%253Av10gun%253A6__%2522%252Cnull%255D%26submit_button_id%3D%255B%2522__ntid%253Av10gun%253A4__%2522%252Cnull%255D%26progress_id%3D%255B%2522__ntid%253Av10gun%253A5__%2522%252Cnull%255D%26form_id%3D%255B%2522__ntid%253Av10gun%253A2__%2522%252Cnull%255D%26start_screen_id%3D%255B%2522__ntid%253Auu97dx%253A0__%2522%252Cnull%255D%22%2C%22client_data%22%3A%7B%22sensitive_string_value%22%3A%22%5B%5B%5C%22code%5B%5D%5C%22%2C%5C%22" + text4 + "%5C%22%5D%2C%5B%5C%22code_handler_type%5C%22%2C%5C%22third_party_qr_auth%5C%22%5D%5D%22%7D%7D%2C%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22profile_image_size%22%3A258%2C%22include_image_ranges%22%3Atrue%7D&fb_api_req_friendly_name=NativeTemplateAsyncQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=%5B%22GraphServices%22%5D&server_timestamps=true";
				text3 = fB87CFA.RequestPost("https://graph.facebook.com/graphql/", e5B);
				if (text3.Contains("error"))
				{
					text = "";
				}
			}
		}
		catch
		{
		}
		return text;
	}

	private void method_29(int int_4, string string_1, Chrome f336F52E_0)
	{
		try
		{
			if (f336F52E_0 != null)
			{
				method_86(int_4, string_1 + "Close chrome...");
				f336F52E_0.CloseChrome();
				if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbAddChromeIntoForm"))
				{
					fViewChrome.DFADBD37.method_2(f336F52E_0.IndexChrome);
				}
			}
		}
		catch
		{
		}
	}

	private bool method_30(Chrome f336F52E_0, int int_4, string string_1, bool bool_5 = false, int D303411C = 2)
	{
		string text = "";
		string text2 = "[href*=\"facebook.com/security/2fac/setup/intro/\"]";
		if (f336F52E_0.CheckExistElement(text2) == 1)
		{
			string text3 = method_93(int_4, "cPassword");
			if (!(text3 == ""))
			{
				int num = 0;
				int num2 = 3;
				string text4 = "";
				int tickCount = Environment.TickCount;
				do
				{
					string text5 = f336F52E_0.CheckExistElements(0.0, new List<string> { "[type=\"submit\"]" });
					string text6 = text5;
					string text7 = text6;
					if (text7 == "[type=\"submit\"]")
					{
						if (f336F52E_0.CheckExistElement("[href^=\"/security/2fac/setup/turn_off/\"]") == 1)
						{
							if (text4 != "")
							{
								BC0C40BD(int_4, "cFa2", text4, "fa2");
								return true;
							}
							if (f336F52E_0.CheckExistElement("[href*=\"/security/2fac/setup/qrcode/generate/\"]") == 1)
							{
								text5 = "[href*=\"/security/2fac/setup/qrcode/generate/\"]";
								string value = Regex.Match(f336F52E_0.GetURL(), "https://(.*?)facebook.com").Value;
								string text8 = f336F52E_0.GetAttributeValue(text5, "href");
								if (!text8.StartsWith("http"))
								{
									text8 = value + text8;
								}
								f336F52E_0.GotoURL(text8);
							}
						}
						else if (f336F52E_0.CheckExistElement("[name=\"pass\"]") == 1)
						{
							if (f336F52E_0.ExecuteScript("return document.querySelector('[data-sigil=\"marea\"] .mfsm').innerText").ToString() != "")
							{
								method_87(int_4, "Changed pass");
								method_86(int_4, string_1 + Language.GetValue("Mật khẩu không đúng!"));
								return false;
							}
							f336F52E_0.SendKeys("[name=\"pass\"]", text3);
							f336F52E_0.DelayTime(2.0);
							f336F52E_0.Click("[name=\"save\"]");
						}
						else if (f336F52E_0.CheckExistElement("[name=\"code\"]") == 1)
						{
							string text9 = Common.GetTotp(text4);
							if (text9 == "")
							{
								break;
							}
							if (text9 != "")
							{
								f336F52E_0.SendKeys("[name=\"code\"]", text9);
								f336F52E_0.DelayTime(1.0);
								f336F52E_0.Click("#submit_code_button");
								f336F52E_0.DelayTime(2.0);
							}
						}
						else if (f336F52E_0.CheckExistElement("[href^=\"otpauth://totp/ID:\"]") == 1)
						{
							text5 = "[href^=\"otpauth://totp/ID:\"]";
							for (int i = 0; i < 3; i++)
							{
								text4 = f336F52E_0.ExecuteScript("return document.querySelector('" + text5 + "').href.match(new RegExp('secret=(.*?)&'))[1]").ToString().Replace(" ", "");
								if (text4 != "")
								{
									break;
								}
								f336F52E_0.Refresh();
								f336F52E_0.DelayTime(2.0);
							}
							if (text4 == "")
							{
								break;
							}
							f336F52E_0.ExecuteJSClick("#qr_confirm_button");
						}
						else if (f336F52E_0.CheckExistElement("[href*=\"/security/2fac/setup/qrcode/generate/\"]") == 1)
						{
							text5 = "[href*=\"/security/2fac/setup/qrcode/generate/\"]";
							string value2 = Regex.Match(f336F52E_0.GetURL(), "https://(.*?)facebook.com").Value;
							string text10 = f336F52E_0.GetAttributeValue(text5, "href");
							if (!text10.StartsWith("http"))
							{
								text10 = value2 + text10;
							}
							f336F52E_0.GotoURL(text10);
						}
						else
						{
							text = f336F52E_0.GetURL();
							if (text.Contains("1501092823525282") || text.Contains("828281030927956") || (text.Contains("facebook.com/nt/screen/?params=") && text.Contains("checkpoint")))
							{
								goto IL_0671;
							}
							if (f336F52E_0.CheckExistElement("#MComposer") == 1)
							{
								if (text4 != "")
								{
									BC0C40BD(int_4, "cFa2", text4, "fa2");
								}
								return true;
							}
							if (f336F52E_0.CheckExistElement(text2) == 1)
							{
								f336F52E_0.Click(text2);
							}
							else
							{
								f336F52E_0.ExecuteJSClick(text5);
							}
						}
					}
					else if (f336F52E_0.CheckExistElement("[href=\"/\"]") == 1)
					{
						if (num >= num2)
						{
							break;
						}
						num++;
						f336F52E_0.GotoBackPage();
					}
					else if (CommonChrome.CheckCheckpoint(f336F52E_0))
					{
						goto IL_0671;
					}
					f336F52E_0.DelayTime(2.0);
				}
				while (Environment.TickCount - tickCount < 300000);
			}
			method_87(int_4, "Checkpoint: Bật 2FA");
			method_86(int_4, string_1 + "Checkpoint: Bật 2FA");
			return false;
		}
		string text11 = "[name=\"password_new\"]";
		bool flag;
		string text12;
		if (f336F52E_0.CheckExistElement(text11) == 1)
		{
			flag = false;
			text12 = "";
			string text13 = method_93(int_4, "cPassword");
			string text14 = "[name=\"password_old\"]";
			string text15 = "[name=\"password_confirm\"]";
			if (f336F52E_0.CheckExistElement(text14) == 1)
			{
				if (text13 == "")
				{
					goto IL_0624;
				}
				f336F52E_0.SendKeys(text14, text13);
				f336F52E_0.DelayTime(1.0);
			}
			text12 = Common.CreateRandomNumber(10);
			f336F52E_0.SendKeys(text11, text12);
			f336F52E_0.DelayTime(1.0);
			f336F52E_0.SendKeys(text15, text12);
			f336F52E_0.DelayTime(1.0);
			f336F52E_0.E2AE03B6();
			f336F52E_0.SendEnter(text15);
			int tickCount2 = Environment.TickCount;
			int num3 = 30;
			while (true)
			{
				if (!f336F52E_0.method_59(0) && f336F52E_0.CheckExistElement(text11) == 1)
				{
					if ((f336F52E_0.CheckExistElement(text11) == 1 && f336F52E_0.GetAttributeValue(text11) == "") || Environment.TickCount - tickCount2 > num3 * 1000)
					{
						break;
					}
					f336F52E_0.DelayTime(1.0);
					continue;
				}
				flag = true;
				break;
			}
			goto IL_0624;
		}
		goto IL_0671;
		IL_0671:
		string text16 = "";
		int num4 = 0;
		if (bool_5 && f336F52E_0.CheckExistElement("[href*=\"facebook.com/secure_account_learn_more\"]") == 1)
		{
			bool flag2;
			if (flag2 = DFB38F3E(f336F52E_0, int_4, string_1))
			{
				method_87(int_4, "Live");
				method_86(int_4, "Unlock checkpoint success!");
			}
			method_96(int_4, (!flag2) ? 1 : 2);
			return flag2;
		}
		if (f336F52E_0.CheckExistElement("#checkpointButtonGetStarted-actual-button") == 1)
		{
			f336F52E_0.GotoURL("https://d.facebook.com/");
			string text17 = Common.CreateRandomString(6) + Common.CreateRandomNumber(4) + Common.CreateRandomString(5);
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("typePass") == 0)
			{
				text17 = SettingsTool.GetSettings("configGeneral").GetValue("txtPass").RandomChar(2);
			}
			bool flag3 = false;
			int tickCount3 = Environment.TickCount;
			int num5 = 300;
			while (true)
			{
				string text18 = f336F52E_0.CheckExistElements(0.0, new List<string> { "[value=\"someone_accessed\"]", "[name=\"submit[Get Started]\"]", "[name=\"submit[Continue]\"]", "[name=\"new_cp\"]", "[name=\"code\"]", "[name=\"submit[Go to News Feed]\"]" });
				switch (text18)
				{
				case "[value=\"someone_accessed\"]":
					f336F52E_0.ExecuteJSClick(text18);
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.Click("[type=\"submit\"]");
					break;
				case "[name=\"submit[Continue]\"]":
					if (f336F52E_0.CheckExistElement("[name=\"password_new\"]") == 1)
					{
						f336F52E_0.SendKeys("[name=\"password_new\"]", text17);
						f336F52E_0.DelayTime(1.0);
						method_91(f336F52E_0.cId, "pass", int_4, "cPassword", text17);
						if (f336F52E_0.CheckExistElement("[name=\"password_confirm\"]") == 1)
						{
							f336F52E_0.SendKeys("[name=\"password_confirm\"]", text17);
							f336F52E_0.DelayTime(1.0);
						}
						if (f336F52E_0.CheckExistElement("[name=\"password_old\"]") == 1)
						{
							if (flag3 && f336F52E_0.ExecuteScript("return document.querySelector('[name=\"password_old\"]').value;").ToString() == "")
							{
								method_91(f336F52E_0.cId, "pass", int_4, "cPassword", f336F52E_0.cPassword);
								method_87(int_4, "Changed pass");
								method_86(int_4, string_1 + Language.GetValue("Mật khẩu không đúng!"));
								return false;
							}
							flag3 = true;
							f336F52E_0.SendKeys("[name=\"password_old\"]", f336F52E_0.cPassword);
							f336F52E_0.DelayTime(1.0);
						}
						f336F52E_0.Click(text18);
					}
					else
					{
						f336F52E_0.Click(text18);
					}
					break;
				case "[name=\"submit[Get Started]\"]":
					f336F52E_0.Click(text18);
					f336F52E_0.DelayTime(2.0);
					f336F52E_0.WaitForSearchElement("[name=\"submit[Continue]\"][disabled]", 1, 30.0);
					break;
				case "[name=\"submit[Go to News Feed]\"]":
					f336F52E_0.Click(text18);
					method_87(int_4, "Live");
					method_86(int_4, "Đăng nhập thành công!");
					return true;
				}
				if (Environment.TickCount - tickCount3 > num5 * 1000)
				{
					break;
				}
				f336F52E_0.DelayTime(2.0);
			}
		}
		text = f336F52E_0.GetURL();
		if (f336F52E_0.GetURL().Contains("checkpoint/disabled"))
		{
			text16 = "vhh";
		}
		else if (text.Contains("facebook.com/si/actor_experience/actor_gateway/nt") && f336F52E_0.GetFbWeb(text) != 3)
		{
			f336F52E_0.GotoURL("https://d.facebook.com/");
			if (!f336F52E_0.GetURL().Contains("checkpoint/disabled"))
			{
				goto IL_0d29;
			}
			text16 = "vhh";
		}
		else
		{
			if (text.Contains("828281030927956"))
			{
				goto IL_0d29;
			}
			if (f336F52E_0.CheckExistElement("#SupportFormRow\\\\.382907505152522") == 1)
			{
				text16 = "Change name";
			}
			else
			{
				f336F52E_0.GotoURL(f336F52E_0.GetURL().Replace("www", "m").Replace("mbasic", "m")
					.Replace("d", "m"));
				if (!f336F52E_0.GetURL().Contains("checkpoint/disabled"))
				{
					if (CommonChrome.CheckTypeWebFacebookFromUrl(f336F52E_0.GetURL()) != 2)
					{
						f336F52E_0.GotoURL("https://m.facebook.com/");
					}
					goto IL_0d29;
				}
				text16 = "vhh";
			}
		}
		goto IL_0fd1;
		IL_0fd1:
		method_87(int_4, "Checkpoint: " + text16);
		method_86(int_4, string_1 + "Checkpoint: " + text16);
		return false;
		IL_0d29:
		while (true)
		{
			num4++;
			text = f336F52E_0.GetURL();
			if (!text.Contains("facebook.com/si/actor_experience/actor_gateway/nt") || f336F52E_0.GetFbWeb(text) != 3)
			{
				if (!text.Contains("checkpoint/disabled"))
				{
					if (!text.Contains("1501092823525282"))
					{
						if (!text.Contains("828281030927956"))
						{
							if (f336F52E_0.CheckExistElement("[name=\"verification_method\"]") != 1)
							{
								if (num4 == 1)
								{
									if (CommonChrome.CheckTypeWebFacebookFromUrl(f336F52E_0.GetURL()) != 3)
									{
										f336F52E_0.GotoURL("https://d.facebook.com/");
									}
									continue;
								}
								switch (f336F52E_0.CheckExistElements(5.0, "[name=\"email\"]", "#checkpoint_title"))
								{
								case 2:
									if (f336F52E_0.CheckExistElement("[name=\"submit[Go to Support Inbox]\"]") == 1)
									{
										f336F52E_0.Click("[name=\"submit[Go to Support Inbox]\"]");
										f336F52E_0.DelayTime(2.0);
										f336F52E_0.GotoBackPage();
										f336F52E_0.DelayTime(2.0);
										continue;
									}
									if (f336F52E_0.CheckExistElement("#checkpointSubmitButton>[name=\"submit[Yes]\"]") == 1)
									{
										f336F52E_0.Click("#checkpointSubmitButton>[name=\"submit[Yes]\"]");
										f336F52E_0.DelayTime(2.0);
										if (f336F52E_0.CheckExistElement("[name=\"new_password\"],[name=\"password_new\"]") == 1)
										{
											string text19 = Common.smethod_71();
											f336F52E_0.SendKeys(4, "[name=\"new_password\"],[name=\"password_new\"]", text19);
											BC0C40BD(int_4, "cPassword", text19, "pass");
											f336F52E_0.DelayTime(1.0);
											f336F52E_0.E2AE03B6();
											if (f336F52E_0.CheckExistElement("[name=\"new_password\"],[name=\"password_new\"]") == 1)
											{
												f336F52E_0.SendEnter("[name=\"new_password\"],[name=\"password_new\"]");
											}
											f336F52E_0.method_59(30);
										}
										continue;
									}
									text16 = "cp login";
									break;
								case 1:
									text16 = "unknow";
									break;
								default:
									if (Regex.IsMatch(f336F52E_0.GetPageSource(), "/friends/") || f336F52E_0.CheckExistElement("a[href*='/friends/']") == 1 || f336F52E_0.GetURL().StartsWith("https://m.facebook.com/home.php"))
									{
										method_87(int_4, "Live");
										method_86(int_4, "Đăng nhập thành công!");
										return true;
									}
									text16 = "unknow";
									break;
								}
								break;
							}
							List<string> list = f336F52E_0.ExecuteScript("var s='';document.getElementsByName('verification_method').forEach(element => {s+=element.value+'|'}); return s;").ToString().TrimEnd('|')
								.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries)
								.ToList();
							for (int j = 0; j < list.Count; j++)
							{
								text16 = text16 + CheckInfoAccountv2.CheckCheckpoint(list[j]) + "-";
							}
							text16 = text16.TrimEnd('-');
							break;
						}
						if (bool_5)
						{
							text16 = "956";
							method_87(int_4, "Checkpoint: " + text16);
							bool flag4 = false;
							if (D303411C == 1)
							{
								flag4 = method_31(f336F52E_0, int_4, string_1);
							}
							if (D303411C == 2)
							{
								flag4 = C3B38631(f336F52E_0, int_4, string_1);
							}
							if (flag4)
							{
								method_87(int_4, "Live");
								method_86(int_4, "Unlock checkpoint success!");
							}
							method_96(int_4, (!flag4) ? 1 : 2);
							return flag4;
						}
						if (f336F52E_0.GetPageSource().Contains("/help/203305893040179"))
						{
							text16 = "956-Tìm hiểu thêm";
							break;
						}
						text16 = "956-Bắt đầu";
						string text20 = f336F52E_0.GetURL();
						int num6 = CommonChrome.CheckTypeWebFacebookFromUrl(text20);
						if (num6 != 3)
						{
							f336F52E_0.GotoURL("https://d.facebook.com/");
							f336F52E_0.DelayTime(2.0);
							if (!f336F52E_0.GetPageSource().Contains("/x/checkpoint/828281030927956/stepper/"))
							{
								text16 = "956-Tìm hiểu thêm";
							}
						}
						break;
					}
					text16 = "282";
					string text21 = f336F52E_0.GetPageSource();
					if (text21.Contains("Chúng tôi đã nhận được thông tin của bạn") || text21.Contains("bạn đã không tán thành với quyết định") || text21.Contains("Đã yêu cầu xem xét"))
					{
						text16 = "282-Đợi xét duyệt!";
						break;
					}
					int num7 = method_26(f336F52E_0, f336F52E_0.GetPageSource());
					if (num7 > 0)
					{
						text16 = "282" + ((num7 == -1) ? "" : $"-{num7} ngày");
					}
					break;
				}
				text16 = "vhh";
				break;
			}
			text16 = "spam";
			break;
		}
		goto IL_0fd1;
		IL_0624:
		if (flag)
		{
			method_91(f336F52E_0.cId, "pass", int_4, "cPassword", text12);
			return true;
		}
		method_87(int_4, "Checkpoint: Đổi pass");
		method_86(int_4, string_1 + "Checkpoint: Đổi pass");
		return false;
	}

	private bool method_31(Chrome f336F52E_0, int B982129E, string string_1)
	{
		return false;
	}

	private bool DFB38F3E(Chrome f336F52E_0, int int_4, string string_1)
	{
		string e43BC = method_93(int_4, "cUid").ToLower();
		string text = method_93(int_4, "cPassword");
		string string_2 = method_93(int_4, "cEmail").ToLower();
		string string_3 = method_93(int_4, "cPassMail");
		method_86(int_4, string_1 + "Unlock checkpoint...");
		f336F52E_0.SetSize();
		if (f336F52E_0.GetFbWeb() != 1)
		{
			f336F52E_0.GotoURL("https://www.facebook.com");
		}
		string text2 = "";
		string text3 = "";
		int num = 0;
		int num2 = 3;
		bool result = false;
		int tickCount = Environment.TickCount;
		int num3 = 600000;
		while (true)
		{
			string text4 = f336F52E_0.CheckExistElements(0.0, new List<string> { "#checkpointSubmitButton[name=\"submit[Continue]\"]", "#checkpointSubmitButton[name=\"submit[Yes]\"]", "[name=\"password_new\"]" });
			switch (text4)
			{
			case "#checkpointSubmitButton[name=\"submit[Continue]\"]":
				if (f336F52E_0.CheckExistElement("[name=\"verification_method\"]") == 1)
				{
					List<string> list = f336F52E_0.ExecuteScript("var s='';document.getElementsByName('verification_method').forEach(element => {s+=element.value+'|'}); return s;").ToString().TrimEnd('|')
						.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries)
						.ToList();
					string text5 = "";
					for (int i = 0; i < list.Count; i++)
					{
						text5 = text5 + CheckInfoAccountv2.CheckCheckpoint(list[i]) + "-";
					}
					text5 = text5.TrimEnd('-');
					method_87(int_4, "Checkpoint: " + text5);
					if (!list.Contains("37"))
					{
						method_86(int_4, string_1 + "Checkpoint: " + text5);
						break;
					}
					if (string_2.IndexOf('@') <= 0)
					{
						method_86(int_4, "Unlock checkpoint fail (Mail không hợp lệ)!");
						break;
					}
					f336F52E_0.ExecuteJSClick("[name=\"verification_method\"][value=\"37\"]");
					f336F52E_0.Click("#checkpointSubmitButton");
				}
				else
				{
					if (f336F52E_0.CheckExistElement("[name=\"send_code\"]") == 1)
					{
						if (f336F52E_0.CheckExistElement("[name=\"captcha_response\"]") == 1)
						{
							num++;
							if (num >= num2)
							{
								method_86(int_4, string_1 + Language.GetValue("Không lấy được otp!"));
								return false;
							}
							string text6 = method_32(1, string_2, string_3, 60, e43BC, text3);
							if (text6 == "fail")
							{
								method_86(int_4, string_1 + Language.GetValue("Không thể kết nối mail!"));
								return false;
							}
							if (text6 == "")
							{
								f336F52E_0.Click("[name=\"send_code\"]");
								goto IL_035a;
							}
							f336F52E_0.SelectText(4, "[name=\"captcha_response\"]");
							f336F52E_0.SendKeys("[name=\"captcha_response\"]", text6);
							f336F52E_0.DelayTime(1.0);
						}
						if (f336F52E_0.CheckExistElement("input[name=\"eindex\"]") == 1)
						{
							List<string> list2 = f336F52E_0.ExecuteScript("arr = []; document.querySelectorAll('input[name=\"eindex\"]').forEach(e => arr.push(e.value)); return arr.join('|');").ToString().Split('|')
								.ToList();
							if (list2[0].Contains("@"))
							{
								string text7 = list2.Where((string FA0993AA) => FA0993AA.Contains(string_2.Substring(string_2.IndexOf('@') - 1, 3)) && FA0993AA.StartsWith(string_2.Substring(0, 1)) && FA0993AA.EndsWith(string_2.Substring(string_2.LastIndexOf('.')))).FirstOrDefault();
								if (string.IsNullOrEmpty(text7))
								{
									method_86(int_4, string_1 + Language.GetValue("Fb bắt xác minh email không có trên tool!"));
									return false;
								}
								text3 = method_32(1, string_2, string_3, 0, e43BC, "");
								if (text3 == "fail")
								{
									method_86(int_4, string_1 + Language.GetValue("Không thể kết nối mail!"));
									return false;
								}
								f336F52E_0.ExecuteJSClick("input[name=\"eindex\"][value=\"" + text7 + "\"]");
								f336F52E_0.DelayTime(1.0);
							}
						}
					}
					f336F52E_0.Click(text4);
				}
				goto IL_035a;
			default:
				if (f336F52E_0.CheckLiveAccount())
				{
					result = true;
					break;
				}
				goto IL_035a;
			case "[name=\"password_new\"]":
				if (!(text2 != ""))
				{
					text2 = Common.smethod_71();
					if (f336F52E_0.CheckExistElement("[name=\"password_old\"]") == 1)
					{
						f336F52E_0.SelectText(4, "[name=\"password_old\"]");
						f336F52E_0.SendKeys("[name=\"password_old\"]", text);
						f336F52E_0.DelayTime(1.0);
					}
					f336F52E_0.SelectText(4, text4);
					f336F52E_0.SendKeys(text4, text2);
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.SelectText(4, "[name=\"password_confirm\"]");
					f336F52E_0.SendKeys("[name=\"password_confirm\"]", text2);
					BC0C40BD(int_4, "cPassword", text2, "pass");
					f336F52E_0.Click("#checkpointSubmitButton[name=\"submit[Next]\"]");
					goto IL_035a;
				}
				BC0C40BD(int_4, "cPassword", text, "pass");
				method_86(int_4, "Unlock checkpoint fail (Lỗi đổi pass mới)!");
				break;
			case "#checkpointSubmitButton[name=\"submit[Yes]\"]":
				{
					f336F52E_0.Click(text4);
					goto IL_035a;
				}
				IL_035a:
				if (Environment.TickCount - tickCount < num3)
				{
					goto IL_036e;
				}
				method_86(int_4, "Unlock checkpoint fail (Timeout)!");
				break;
			}
			break;
			IL_036e:
			f336F52E_0.DelayTime(2.0);
			f336F52E_0.WaitForSearchElement("#checkpointSubmitButton[disabled]", 1, 30.0);
		}
		f336F52E_0.RetoreSize();
		return result;
	}

	private bool C3B38631(Chrome B130CA9C, int int_4, string F2BE4289)
	{
		string e43BC = method_93(int_4, "cUid").ToLower();
		string text = method_93(int_4, "cEmail").ToLower();
		string string_ = method_93(int_4, "cPassMail");
		string text2 = method_93(int_4, "cBirthday");
		string text3 = "";
		string text4 = "";
		string text5 = "";
		int num = 0;
		method_86(int_4, F2BE4289 + "Unlock 956...");
		B130CA9C.SetFbLanguage();
		B130CA9C.SetSize();
		B130CA9C.GotoURL("https://facebook.com/");
		string text6 = "";
		string text7 = "";
		int num2 = 0;
		int num3 = 3;
		bool result = false;
		int tickCount = Environment.TickCount;
		int num4 = 600000;
		while (true)
		{
			string text8 = B130CA9C.GetURL();
			if (!text8.Contains("1501092823525282"))
			{
				string text9 = B130CA9C.CheckExistElements(3.0, new List<string> { "[role=\"progressbar\"]", "[aria-label=\"Close\"]", "[aria-label=\"Next\"]", "[aria-label=\"Get started\"],[aria-label=\"Get Started\"],[aria-label=\"Start security steps\"]", "[aria-label=\"Get code\"]", "[aria-label=\"Type or paste code\"]", "[aria-label=\"Enter new password\"]", "[aria-label=\"Back to Facebook\"]" });
				switch (text9)
				{
				case "[aria-label=\"Next\"]":
					if (B130CA9C.CheckExistElement("//*[text()=\"Enter your birthday\" or text()=\"Enter your date of birth\"]") == 1)
					{
						if (text2 == "" || text2.Split('/').Length < 3)
						{
							method_86(int_4, "Checkpoint ngày sinh (Không có ngày sinh)!");
							break;
						}
						num++;
						if (num == 1)
						{
							text3 = text2.Split('/')[1];
							text4 = text2.Split('/')[0];
							text5 = text2.Split('/')[2];
						}
						else
						{
							if (num != 2)
							{
								method_86(int_4, "Checkpoint ngày sinh (Sai ngày sinh)!");
								break;
							}
							text3 = text2.Split('/')[0];
							text4 = text2.Split('/')[1];
							text5 = text2.Split('/')[2];
						}
						if (text3.Length == 1)
						{
							text3 = "0" + text3;
						}
						if (text4.Length == 1)
						{
							text4 = "0" + text4;
						}
						B130CA9C.SelectText(4, "[aria-label=\"day\"] input[type=\"text\"]");
						B130CA9C.SendKeys("[aria-label=\"day\"] input[type=\"text\"]", text3);
						B130CA9C.DelayTime(1.0);
						B130CA9C.SelectText(4, "[aria-label=\"month\"] input[type=\"text\"]");
						B130CA9C.SendKeys("[aria-label=\"month\"] input[type=\"text\"]", text4);
						B130CA9C.DelayTime(1.0);
						B130CA9C.SelectText(4, "[aria-label=\"year\"] input[type=\"text\"]");
						B130CA9C.SendKeys("[aria-label=\"year\"] input[type=\"text\"]", text5);
						B130CA9C.DelayTime(1.0);
					}
					B130CA9C.ExecuteJSClick(text9);
					goto case "[role=\"progressbar\"]";
				case "[aria-label=\"Close\"]":
					if (B130CA9C.CheckExistElement("[href*=\"facebook.com/help/contact/571927962827151\"]") != 1)
					{
						B130CA9C.ExecuteJSClick(text9);
						goto case "[role=\"progressbar\"]";
					}
					method_86(int_4, "Checkpoint: 956 (fb block)");
					method_87(int_4, "Checkpoint: 956 (fb block)");
					break;
				case "[aria-label=\"Get code\"]":
				{
					string text10 = text.Substring(text.IndexOf('@') - 1, 3);
					if (B130CA9C.CheckExistElement("//*[contains(text(),\"" + text10 + "\")]") != 0)
					{
						text6 = method_32(1, text, string_, 0, e43BC, "");
						if (!(text6 == "fail"))
						{
							B130CA9C.ExecuteJSClick("//*[contains(text(),\"" + text10 + "\")]");
							B130CA9C.DelayTime(1.0);
							B130CA9C.ExecuteJSClick(text9);
							goto case "[role=\"progressbar\"]";
						}
						method_86(int_4, F2BE4289 + Language.GetValue("Không thể kết nối mail!"));
						return false;
					}
					method_86(int_4, F2BE4289 + Language.GetValue("Fb bắt xác minh email không có trên tool!"));
					return false;
				}
				case "[aria-label=\"Get started\"],[aria-label=\"Get Started\"],[aria-label=\"Start security steps\"]":
					if (B130CA9C.CheckExistElement("//*[translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz')='help us confirm your identity']") != 1)
					{
						B130CA9C.ExecuteJSClick(text9);
						goto case "[role=\"progressbar\"]";
					}
					text7 = text7 + ((text7 == "") ? "" : "-") + "Xmdt";
					method_86(int_4, "Checkpoint: 956 (" + text7 + ")");
					method_87(int_4, "Checkpoint: 956 (" + text7 + ")");
					break;
				case "[aria-label=\"Type or paste code\"]":
					num2++;
					if (num2 < num3)
					{
						string text16 = method_32(1, text, string_, 60, e43BC, text6);
						if (!(text16 == "fail"))
						{
							if (text16 == "")
							{
								B130CA9C.ExecuteJSClick("//*[contains(text(),\"Resend code\")]");
							}
							else
							{
								B130CA9C.SelectText(4, "input[type=\"text\"]");
								B130CA9C.SendKeys("input[type=\"text\"]", text16);
								B130CA9C.DelayTime(1.0);
								B130CA9C.Click("[aria-label=\"Submit\"]");
							}
							goto case "[role=\"progressbar\"]";
						}
						method_86(int_4, F2BE4289 + Language.GetValue("Không thể kết nối mail!"));
						return false;
					}
					method_86(int_4, F2BE4289 + Language.GetValue("Không lấy được otp!"));
					return false;
				case "[aria-label=\"Enter new password\"]":
				{
					string text14 = "";
					string text15 = "";
					for (int i = 0; i < 5; i++)
					{
						if (!(text14 != ""))
						{
							goto IL_0645;
						}
						B130CA9C.ExecuteJSClick("[aria-label=\"Save changes\"],[aria-label=\"Confirm password\"]");
						bool flag = false;
						int num5 = 0;
						while (true)
						{
							if (num5 < 60)
							{
								if (B130CA9C.CheckExistElement("//*[contains(text(),\"Your new login\")]") != 1)
								{
									if (B130CA9C.CheckExistElement("//*[contains(text(),\"Error performing query\")]") == 1 || B130CA9C.CheckExistElement("//*[contains(text(),\"Something went wrong\")]") == 1)
									{
										break;
									}
									if (B130CA9C.CheckExistElement("[aria-label=\"Close\"]") != 1)
									{
										B130CA9C.DelayTime(1.0);
										num5++;
										continue;
									}
									B130CA9C.Click("[aria-label=\"Close\"]");
								}
								else
								{
									flag = true;
								}
							}
							if (flag)
							{
								goto end_IL_06d1;
							}
							goto IL_0645;
						}
						goto IL_0a94;
						IL_0645:
						if (!(text15 != B130CA9C.ExecuteScript("return document.documentElement.innerText;").ToString()))
						{
							continue;
						}
						if (!B130CA9C.GetURL().Contains("1501092823525282"))
						{
							text14 = Common.smethod_71();
							B130CA9C.SelectText(4, "input[type=\"password\"]");
							B130CA9C.SendKeys("input[type=\"password\"]", text14);
							BC0C40BD(int_4, "cPassword", text14, "pass");
							B130CA9C.DelayTime(1.0);
							text15 = B130CA9C.ExecuteScript("return document.documentElement.innerText;").ToString();
							continue;
						}
						goto IL_0ab6;
						continue;
						end_IL_06d1:
						break;
					}
					goto case "[role=\"progressbar\"]";
				}
				default:
					if (B130CA9C.CheckExistElement("//*[contains(text(),\"verification challenge\")]") == 1)
					{
						if (B130CA9C.ExecuteScript("return document.querySelector('input[type=\"text\"]').value+'';").ToString() != "")
						{
							B130CA9C.Refresh();
						}
						else
						{
							int c0905E = SettingsTool.GetSettings("configCheckpoint").GetValueInt("typeCaptcha");
							string text11 = SettingsTool.GetSettings("configCheckpoint").GetValue("txtCaptcha_" + c0905E);
							if (text11 == "")
							{
								method_86(int_4, "Facebook bắt giải captcha!");
								break;
							}
							string text12 = B130CA9C.ExecuteScript("var img=document.querySelector('[src*=\"/captcha/tfbimage/\"]');var d=document.createElement('canvas');d.height=70;d.width=280;var ctx=d.getContext('2d');ctx.drawImage(img,0,0);var x=d.toDataURL(); return x").ToString().Replace("data:image/png;base64,", "");
							if (text12 == "")
							{
								B130CA9C.Refresh();
							}
							else
							{
								string text13 = CaptchaHelperxRentPhone.BA30A117(c0905E, text11, text12);
								if (text13 != "")
								{
									B130CA9C.SendKeys("input[type=\"text\"]", text13);
									B130CA9C.DelayTime(1.0);
									B130CA9C.Click("[aria-label=\"Confirm\"]");
								}
								else
								{
									B130CA9C.Refresh();
								}
							}
						}
					}
					else
					{
						if (B130CA9C.CheckExistElement("//*[text()=\"No longer available\"]") == 1)
						{
							method_86(int_4, "Không có phương thức giải!");
							break;
						}
						if (B130CA9C.CheckExistElement("//*[contains(text(),\"t remove anything\") or contains(text(),\"t Remove Anything\")]") != 1)
						{
							if (B130CA9C.CheckExistElement("//*[text()=\"Enter your birthday\" or text()=\"Enter your date of birth\"]") == 1)
							{
								text7 = "Birthday";
								if (text2.Split('/').Length == 3)
								{
									B130CA9C.ExecuteJSClick("//*[text()=\"Enter your birthday\" or text()=\"Enter your date of birth\"]");
									goto case "[role=\"progressbar\"]";
								}
							}
							if (B130CA9C.CheckExistElement("//*[text()=\"Get a code by email\"]") == 1)
							{
								text7 = text7 + ((text7 == "") ? "" : "-") + "Otp mail";
								if (text != "")
								{
									B130CA9C.ExecuteJSClick("//*[text()=\"Get a code by email\"]");
									goto case "[role=\"progressbar\"]";
								}
							}
							if (B130CA9C.CheckExistElement("//*[text()=\"Confirm your identity\"]") == 1)
							{
								text7 = text7 + ((text7 == "") ? "" : "-") + "Xmdt";
							}
							if (B130CA9C.CheckExistElement("//*[text()=\"Get a code on your phone\"]") == 1)
							{
								text7 = text7 + ((text7 == "") ? "" : "-") + "Phone";
							}
							if (B130CA9C.CheckExistElement("//*[text()=\"Verify your credit card\"]") == 1)
							{
								text7 = text7 + ((text7 == "") ? "" : "-") + "Verify card";
							}
							if (text7 != "")
							{
								method_86(int_4, "Checkpoint: 956 (" + text7 + ")");
								method_87(int_4, "Checkpoint: 956 (" + text7 + ")");
							}
							else if (B130CA9C.CheckLiveAccount())
							{
								result = true;
							}
							else
							{
								method_86(int_4, "Unlock checkpoint fail (2)!");
							}
							break;
						}
						B130CA9C.ExecuteJSClick("//*[contains(text(),\"t remove anything\") or contains(text(),\"t Remove Anything\")]");
					}
					goto case "[role=\"progressbar\"]";
				case "[role=\"progressbar\"]":
					if (Environment.TickCount - tickCount < num4)
					{
						goto IL_0906;
					}
					method_86(int_4, "Unlock checkpoint fail (Timeout)!");
					Common.ExportError(B130CA9C, null, "Unlock 956");
					break;
				case "[aria-label=\"Back to Facebook\"]":
					{
						if (B130CA9C.CheckLiveAccount())
						{
							result = true;
						}
						else
						{
							method_86(int_4, "Unlock checkpoint fail (1)!");
						}
						break;
					}
					IL_0a94:
					if (B130CA9C.CheckLiveAccount())
					{
						result = true;
					}
					else
					{
						method_86(int_4, "Unlock checkpoint fail (3)!");
					}
					break;
					IL_0ab6:
					method_87(int_4, "Checkpoint: 282");
					method_86(int_4, F2BE4289 + "Checkpoint: 282");
					break;
				}
			}
			else
			{
				method_87(int_4, "Checkpoint: 282");
				method_86(int_4, F2BE4289 + "Checkpoint: 282");
			}
			break;
			IL_0906:
			B130CA9C.DelayTime(2.0);
		}
		B130CA9C.RetoreSize();
		return result;
	}

	private string method_32(int AE08A827, string string_1, string string_2, int int_4, string E43BC534, string EBB5B60D)
	{
		return "";
	}

	private void A9B660BC(Chrome f336F52E_0)
	{
		try
		{
			f336F52E_0.GotoURL("https://m.facebook.com/settings/how_people_find_and_contact_you/");
			f336F52E_0.DelayTime(1.0);
			if (f336F52E_0.CheckExistElement("[data-store*=\"8787365733\"]", 15.0) != 1)
			{
				return;
			}
			f336F52E_0.Click(4, "[data-store*=\"8787365733\"]");
			f336F52E_0.DelayTime(1.0);
			if (f336F52E_0.CheckExistElement("[name=\"privacyx\"]", 15.0) == 1)
			{
				if (f336F52E_0.Click(2, "privacyx") == 0)
				{
					f336F52E_0.ExecuteScript("document.querySelector('[name=\"privacyx\"]').click()");
				}
				f336F52E_0.DelayTime(3.0);
			}
		}
		catch
		{
		}
	}

	private void method_33(Chrome f336F52E_0)
	{
		try
		{
			f336F52E_0.GotoURL("https://m.facebook.com/settings/how_people_find_and_contact_you/");
			f336F52E_0.DelayTime(1.0);
			if (f336F52E_0.CheckExistElement("[data-store*=\"8787540733\"]", 20.0) == 1)
			{
				f336F52E_0.Click(4, "[data-store*=\"8787540733\"]");
				f336F52E_0.DelayTime(1.0);
				if (f336F52E_0.CheckExistElement("[name=\"privacyx\"]", 15.0) == 1)
				{
					if (f336F52E_0.Click(2, "privacyx") == 0)
					{
						f336F52E_0.ExecuteScript("document.querySelector('[name=\"privacyx\"]').click()");
					}
					f336F52E_0.DelayTime(3.0);
				}
			}
			f336F52E_0.GotoURL("https://m.facebook.com/settings/framework/msite/posts/?entry_point=unknown");
			f336F52E_0.DelayTime(1.0);
			if (f336F52E_0.CheckExistElement("#root [role=\"button\"]", 15.0) == 1)
			{
				f336F52E_0.Click(4, "#root [role=\"button\"]");
				f336F52E_0.DelayTime(1.0);
				if (f336F52E_0.CheckExistElement("[name=\"privacyx\"]", 15.0) == 1)
				{
					if (f336F52E_0.Click(2, "privacyx") == 0)
					{
						f336F52E_0.ExecuteScript("document.querySelector('[name=\"privacyx\"]').click()");
					}
					f336F52E_0.DelayTime(3.0);
				}
			}
			f336F52E_0.GotoURL("https://m.facebook.com/privacy/touch/timeline_and_tagging");
			f336F52E_0.DelayTime(1.0);
			if (f336F52E_0.CheckExistElement("[data-store*=\"10153940308610734\"]", 15.0) == 1)
			{
				f336F52E_0.Click(4, "[data-store*=\"10153940308610734\"]");
				f336F52E_0.DelayTime(1.0);
				if (f336F52E_0.CheckExistElement("[data-store*=\"286958161406148\"]", 15.0) == 1)
				{
					if (f336F52E_0.Click(4, "[data-store*=\"286958161406148\"]") == 0)
					{
						f336F52E_0.ExecuteScript("document.querySelector('[data-store*=\"286958161406148\"]').click()");
					}
					f336F52E_0.DelayTime(3.0);
				}
			}
			f336F52E_0.GotoURL("https://m.facebook.com/privacy/touch/timeline_and_tagging");
			if (f336F52E_0.CheckExistElement("[data-store*=\"8787530733\"]", 15.0) != 1)
			{
				return;
			}
			f336F52E_0.Click(4, "[data-store*=\"8787530733\"]");
			f336F52E_0.DelayTime(1.0);
			if (f336F52E_0.CheckExistElement("[value=\"286958161406148\"]", 15.0) == 1)
			{
				if (f336F52E_0.Click(4, "[value=\"286958161406148\"]") == 0)
				{
					f336F52E_0.ExecuteScript("document.querySelector('[value=\"286958161406148\"]').click()");
				}
				f336F52E_0.DelayTime(3.0);
			}
		}
		catch
		{
		}
	}

	private int AA17DFA0(Chrome CDBAB195, int int_4)
	{
		int result = 1;
		string string_ = method_93(int_4, "cPassword");
		try
		{
			CDBAB195.GotoURL("https://m.facebook.com/login_alerts/settings/");
			method_57();
			for (int i = 0; i < 2; i++)
			{
				if (CDBAB195.CheckExistElement("article [data-sigil=\"touchable\"] a", 5.0) != 1)
				{
					continue;
				}
				CDBAB195.Click(4, "article [data-sigil=\"touchable\"] a", i);
				CDBAB195.DelayTime(1.0);
				if (CDBAB195.CheckExistElement("fieldset label:nth-child(1) [checked=\"1\"]", 5.0) == 1)
				{
					CDBAB195.Click(4, "fieldset label:nth-child(1)");
					CDBAB195.DelayTime(1.0);
					CDBAB195.Click(4, "[type=\"submit\"]");
					CDBAB195.DelayTime(1.0);
					if (CDBAB195.CheckExistElement("[type=\"password\"]", 5.0) == 1)
					{
						CDBAB195.SendKeys(4, "[type=\"password\"]", string_);
						method_57();
						CDBAB195.Click(4, "[type=\"submit\"]");
						method_57();
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private void method_34(int E41DFD26, string D88A9EAF, Chrome A10BC6BE, JSON_Settings gclass8_1)
	{
		int minValue = gclass8_1.GetValueInt("nudTTBVTimeFrom", 3);
		int num = gclass8_1.GetValueInt("nudTTBVTimeTo", 3);
		bool flag = gclass8_1.GetValueBool("ckbTTBVInteract");
		string text = gclass8_1.GetValue("TTBVtypeReaction", "0");
		bool flag2 = gclass8_1.GetValueBool("ckbTTBVCommentText");
		List<string> f8388D = gclass8_1.GetValueList("txtTTBVComment", gclass8_1.GetValueInt("cbbTTBVTuyChonNoiDung"));
		bool flag3 = gclass8_1.GetValueBool("ckbTTBVCommentImage");
		string b985E2A = gclass8_1.GetValue("txtTTBVImagePath");
		bool flag4 = gclass8_1.GetValueBool("ckbTTBVShareWall");
		if (A10BC6BE.CheckExistElements(5.0, "[data-sigil=\"m-feed-voice-subtitle\"]", "[data-sigil=\"timestamp\"]") != 1)
		{
			return;
		}
		if (A10BC6BE.CountElementWithXpath("[data-sigil=\"m-feed-voice-subtitle\"] > a") > 1)
		{
			A10BC6BE.Click("[data-sigil=\"m-feed-voice-subtitle\"] > a");
			A10BC6BE.DelayTime(2.0);
		}
		if (A10BC6BE.CheckExistElement("[data-sigil=\"m-video-play-button playInlineVideo\"]") == 1)
		{
			A10BC6BE.scrollIntoView("[data-sigil=\"m-video-play-button playInlineVideo\"]");
			A10BC6BE.DelayTime(2.0);
			A10BC6BE.ClickWithActionAll("[data-sigil=\"m-video-play-button playInlineVideo\"]");
			A10BC6BE.DelayTime(2.0);
		}
		method_86(E41DFD26, D88A9EAF + Language.GetValue("Xem bài viết ({time}s)..."), Base.rd.Next(minValue, num + 1));
		if (flag)
		{
			method_86(E41DFD26, D88A9EAF + Language.GetValue("Thả cảm xúc..."));
			string text2 = "[data-uri*=\"facebook.com/ufi/reaction/\"]";
			if (A10BC6BE.CheckExistElement(text2) == 1)
			{
				if (A10BC6BE.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + text2 + "')") == 1)
				{
					A10BC6BE.DelayRandom(1, 3);
				}
				int num2 = Convert.ToInt32(text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList().GetRandomItem());
				if (num2 == 0)
				{
					A10BC6BE.Click(text2);
				}
				else
				{
					A10BC6BE.ExecuteJSClick("[data-sigil=\"screenreader-reactions-trigger\"]");
					if (A10BC6BE.CheckExistElementOnScreen("document.querySelector('[data-sigil=\"reaction-item\"]')", 3) == 0)
					{
						A10BC6BE.DelayTime(1.0);
						A10BC6BE.Click(4, "[data-sigil=\"reaction-item\"]", num2);
					}
				}
			}
		}
		if (flag2 || flag3)
		{
			method_86(E41DFD26, D88A9EAF + Language.GetValue("Comment..."));
			int int_ = 0;
			D1B7E1B8(ref int_, E41DFD26, D88A9EAF, A10BC6BE, flag2, f8388D, flag3, b985E2A);
		}
		if (flag4)
		{
			method_86(E41DFD26, D88A9EAF + Language.GetValue("Share wall..."));
			method_35(A10BC6BE);
		}
	}

	private void D1B7E1B8(ref int int_4, int int_5, string string_1, Chrome f336F52E_0, bool DE0D66BD, List<string> F8388D25, bool CC2025B9, string B985E2A1)
	{
		string text = "#composerInput";
		if (f336F52E_0.CheckExistElement(text) != 1)
		{
			return;
		}
		if (f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelector('" + text + "')") == 1)
		{
			f336F52E_0.DelayTime(1, 2);
		}
		bool flag = false;
		if (CC2025B9)
		{
			method_86(int_5, string_1 + Language.GetValue("Comment Ảnh..."));
			List<string> list = Common.GetFiles(B985E2A1);
			if (list.Count > 0)
			{
				string string_2 = list.GetRandomItem();
				f336F52E_0.SendKeys("[data-sigil=\"m-raw-file-input\"]", string_2);
				int num = 30;
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < num * 1000)
				{
					f336F52E_0.DelayTime(1.0);
					if (f336F52E_0.CheckExistElement("[data-sigil=\"touchable\"]>img") == 1)
					{
						break;
					}
				}
				flag = true;
			}
		}
		if (DE0D66BD)
		{
			method_86(int_5, string_1 + Language.GetValue("Comment Text..."));
			if (F8388D25.Count > 0)
			{
				string string_3 = F8388D25.GetRandomItem();
				f336F52E_0.SendKeys(text, string_3);
				f336F52E_0.DelayTime(1, 2);
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		method_86(int_5, string_1 + Language.GetValue("Submit..."));
		for (int i = 0; i < 10; i++)
		{
			if (f336F52E_0.Click(2, "submit") == 1)
			{
				break;
			}
			f336F52E_0.DelayTime(1.0);
		}
		for (int j = 0; j < 60; j++)
		{
			if (f336F52E_0.ExecuteScript("return document.querySelector('" + text + "').value").ToString() == "")
			{
				break;
			}
			Common.Sleep(1.0);
		}
	}

	private bool method_35(Chrome A20C3A37, string FFA5C596 = "")
	{
		string text = "[data-sigil=\"share-popup\"]";
		if (A20C3A37.CheckExistElement(text) == 0)
		{
			return false;
		}
		A20C3A37.Scroll_IntoVIew(text);
		A20C3A37.Click(text);
		A20C3A37.DelayTime(1, 2);
		List<string> list = new List<string> { "#share-with-message-button", "[data-sigil=\"privacy-composer-menu\"] :not([data-store*=\"300645083384735\"]).checked", "#share_msg_input", "#share-one-click-button", "#share-post-one-click-button", "#share_submit" };
		if (FFA5C596 == "")
		{
			list.Remove("#share-with-message-button");
			list.Remove("#share_msg_input");
		}
		int tickCount = Environment.TickCount;
		int num = 60;
		while (true)
		{
			string text2 = A20C3A37.CheckExistElements(0.0, list);
			switch (text2)
			{
			case "#share-with-message-button":
				A20C3A37.Click(text2);
				list.Remove(text2);
				goto default;
			default:
				if (Environment.TickCount - tickCount <= num * 1000)
				{
					goto IL_00de;
				}
				return false;
			case "[data-sigil=\"privacy-composer-menu\"] :not([data-store*=\"300645083384735\"]).checked":
				if (A20C3A37.Click("[data-sigil~=\"privacy-button\"]"))
				{
					A20C3A37.DelayTime(1.0);
					A20C3A37.Click("[data-sigil=\"privacy-composer-menu\"] [data-store*=\"300645083384735\"]");
					A20C3A37.DelayTime(1.0);
				}
				list.Remove(text2);
				goto default;
			case "#share-one-click-button":
			case "#share-post-one-click-button":
			case "#share_submit":
				A20C3A37.Click(text2);
				break;
			case "#share_msg_input":
				A20C3A37.SendKeys("#share_msg_input", FFA5C596);
				A20C3A37.DelayTime(2.0);
				A20C3A37.Click("#share_submit");
				break;
			}
			break;
			IL_00de:
			A20C3A37.DelayTime(1.0);
		}
		return true;
	}

	private void AB2CF090(int int_4, string string_1, Chrome f336F52E_0, JSON_Settings gclass8_1, string string_2 = "")
	{
		int num = gclass8_1.GetValueInt("nudTTPSoLuongFrom");
		int num2 = gclass8_1.GetValueInt("nudTTPSoLuongTo");
		int num3 = gclass8_1.GetValueInt("nudTTPDelayFrom");
		int num4 = gclass8_1.GetValueInt("nudTTPDelayTo");
		bool flag = gclass8_1.GetValueBool("ckbTTPInteract");
		string text = gclass8_1.GetValue("TTPtypeReaction", "0");
		bool flag2 = gclass8_1.GetValueBool("ckbTTPCommentText");
		List<string> f8388D = gclass8_1.GetValueList("txtTTPComment", gclass8_1.GetValueInt("cbbTTPTuyChonNoiDung"));
		bool flag3 = gclass8_1.GetValueBool("ckbTTPCommentImage");
		string b985E2A = gclass8_1.GetValue("txtTTPImagePath");
		bool flag4 = gclass8_1.GetValueBool("ckbTTPShareWall");
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num5 = Common.DelayRandom(num, num2);
		int num6 = 0;
		int num7 = 0;
		for (int i = 1; i < num5 + 10; i++)
		{
			if (num6 >= num5)
			{
				break;
			}
			bool flag5 = false;
			if (f336F52E_0.CheckIsLive() || f336F52E_0.CheckExistElement($"[data-store*=\"linkdata\"]|{i}") == 0)
			{
				break;
			}
			if (f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + i + "]") == 1)
			{
				f336F52E_0.DelayTime(1, 2);
			}
			if (flag)
			{
				string text2 = "[data-uri*=\"https://m.facebook.com/ufi/reaction/\"]";
				if (Convert.ToBoolean(f336F52E_0.ExecuteScript($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{i}].querySelector('" + text2 + "')!=null)+''")))
				{
					if (f336F52E_0.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + i + "].querySelector('" + text2 + "')") == 1)
					{
						f336F52E_0.DelayRandom(1, 3);
					}
					int num8 = Convert.ToInt32(text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList().GetRandomItem());
					if (num8 == 0)
					{
						if (f336F52E_0.Click(4, "[data-store*=\"linkdata\"]", i, 4, text2) == 1)
						{
							f336F52E_0.DelayTime(1.0);
							flag5 = true;
						}
					}
					else
					{
						f336F52E_0.ExecuteScript($"document.querySelectorAll('[data-store*=\"linkdata\"]')[{i}].querySelector('[data-sigil=\"screenreader-reactions-trigger\"]').click()");
						if (f336F52E_0.CheckExistElementOnScreen("document.querySelector('[data-sigil=\"reaction-item\"]')", 3) == 0)
						{
							f336F52E_0.DelayTime(1.0);
							if (f336F52E_0.Click(4, "[data-sigil=\"reaction-item\"]", num8) == 1)
							{
								f336F52E_0.DelayTime(1.0);
								flag5 = true;
							}
						}
					}
				}
			}
			if ((flag2 || flag3) && Convert.ToBoolean(f336F52E_0.ExecuteScript($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{i}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''")))
			{
				f336F52E_0.ExecuteScript($"return JSON.parse(document.querySelectorAll('[data-store*=\"linkdata\"]')[{i}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]').getAttribute('data-click')).target_id").ToString();
				f336F52E_0.scrollIntoView("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + i + "].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')");
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.Click(4, "[data-store*=\"linkdata\"]", i, 4, "[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]");
				f336F52E_0.DelayTime(1.0);
				int int_5 = 0;
				D1B7E1B8(ref int_5, int_4, string_1, f336F52E_0, flag2, f8388D, flag3, b985E2A);
				if (int_5 != 0)
				{
					break;
				}
				f336F52E_0.GotoBackPage();
				f336F52E_0.DelayRandom(2, 3);
				if (string_2.EndsWith("posts"))
				{
					f336F52E_0.Scroll(0, 1000);
					f336F52E_0.DelayTime(1.0);
				}
			}
			if (flag4 && Convert.ToBoolean(f336F52E_0.ExecuteScript($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{i}].querySelector('[data-sigil=\"share-popup\"]')!=null)+''")))
			{
				flag5 = true;
				string string_3 = f336F52E_0.GetURL();
				f336F52E_0.Click(4, "[data-store*=\"linkdata\"]", i, 4, "[data-sigil=\"share-popup\"]");
				string text3 = f336F52E_0.CheckExistElements(5.0, new List<string> { "#share-one-click-button", "#share-post-one-click-button", "#share_submit" });
				if (text3 != "")
				{
					f336F52E_0.Click(text3);
					f336F52E_0.DelayTime(3.0);
					if (text3 == "#share_submit")
					{
						f336F52E_0.GotoURL(string_3);
					}
				}
			}
			if (flag5)
			{
				num7 = 0;
				num6++;
				if (f336F52E_0.CheckIsLive())
				{
					break;
				}
				method_86(int_4, string_1 + $"({num6}/{num5}), đợi {{time}}s...", Common.DelayRandom(num3, num4));
			}
			else
			{
				num7++;
				if (num7 == 5)
				{
					break;
				}
			}
		}
	}

	private int B006E595(Chrome DDB548AB, string string_1, string C90FDFAD, D524C910 d524C910_0)
	{
		string text = "";
		switch (d524C910_0)
		{
		case D524C910.const_0:
			text = "[aria-label$=\"imeline\"]~div";
			break;
		case D524C910.const_1:
			text = "(//a[@aria-label=\"Profile\"]/ancestor::div)[last()]/div";
			break;
		case D524C910.const_2:
			text = "[aria-label=\"Create post\"]";
			break;
		}
		if (C90FDFAD == "")
		{
			C90FDFAD = " ";
		}
		int tickCount = Environment.TickCount;
		int num = 300;
		while (true)
		{
			if (DDB548AB.CheckExistElement("[role=\"dialog\"] form[method=\"POST\"] [role=\"progressbar\"]") != 1)
			{
				if (DDB548AB.CheckExistElement("[role=\"dialog\"] form[method=\"POST\"] [role=\"textbox\"]") == 1)
				{
					string string_2 = "[role=\"dialog\"] form[method=\"POST\"] [role=\"textbox\"]";
					if (d524C910_0 == D524C910.const_0 && DDB548AB.CheckExistElement("[role=\"dialog\"] form[method=\"POST\"] [aria-label^=\"Edit privacy. Sharing with Public\"]") == 0)
					{
						DDB548AB.Click("[role=\"dialog\"] form[method=\"POST\"] [aria-label^=\"Edit privacy\"]");
						DDB548AB.DelayTime(2.0);
						DDB548AB.Click("[role=\"dialog\"] form[method=\"POST\"] [role=\"radio\"]");
						DDB548AB.DelayTime(1.0);
						DDB548AB.Click("//*[@role=\"dialog\"]/form[@method=\"POST\"]//*[text()=\"Set as default audience.\"]");
						DDB548AB.DelayTime(1.0);
						DDB548AB.Click("[role=\"dialog\"] form[method=\"POST\"] [aria-label=\"Done\"],[aria-label=\"Save\"]");
					}
					if (string_1 != "")
					{
						DDB548AB.SendKeys(string_2, string_1);
						if (DDB548AB.CheckExistElement("[role=\"dialog\"] form[method=\"POST\"] [aria-label=\"Remove link preview from your post\"]", 30.0) == 1)
						{
							DDB548AB.WaitForSearchElement("[role=\"dialog\"] form[method=\"POST\"] [role=\"progressbar\"]", 1, 30.0);
						}
						DDB548AB.SelectText(string_2);
						DDB548AB.DelayTime(1.0);
					}
					C90FDFAD = Common.SpinText(C90FDFAD);
					C90FDFAD = Common.smethod_72(C90FDFAD);
					DDB548AB.SendKeys(string_2, C90FDFAD);
					DDB548AB.DelayTime(2.0);
					if (DDB548AB.Click("[role=\"dialog\"] form[method=\"POST\"] [aria-label=\"Post\"]:not([aria-disabled=\"true\"])"))
					{
						DDB548AB.DelayRandom(3, 5);
						while (true)
						{
							if (DDB548AB.CheckExistElement("[role=\"dialog\"] form[method=\"POST\"] [role=\"progressbar\"]") == 0)
							{
								if (DDB548AB.CheckExistElement("[role=\"dialog\"] form[method=\"POST\"]") == 0)
								{
									return 1;
								}
								if (DDB548AB.CheckFacebookBlocked())
								{
									return -4;
								}
							}
							if (Environment.TickCount - tickCount > num * 1000)
							{
								break;
							}
							DDB548AB.DelayTime(2.0);
						}
						return 0;
					}
				}
				if (DDB548AB.CheckExistElement("//*[@role=\"dialog\"]/form[@method=\"POST\"]//*[text()=\"Default audience\"]") == 1)
				{
					DDB548AB.Click("[role=\"dialog\"] form[method=\"POST\"] [role=\"radio\"]");
					DDB548AB.DelayTime(1.0);
					DDB548AB.Click("//*[@role=\"dialog\"]/form[@method=\"POST\"]//*[text()=\"Set as default audience.\"]");
					DDB548AB.DelayTime(1.0);
					DDB548AB.Click("[role=\"dialog\"] form[method=\"POST\"] [aria-label=\"Done\"],[aria-label=\"Save\"]");
				}
				else if (DDB548AB.CheckExistElement(text) == 1)
				{
					DDB548AB.Click(text);
				}
				else if (Environment.TickCount - tickCount > num * 1000)
				{
					break;
				}
			}
			DDB548AB.DelayTime(2.0);
		}
		return 0;
	}

	private int D233BB3D(ref int int_4, int int_5, string string_1, Chrome DDA5D83C, JSON_Settings gclass8_1, string string_2, string string_3)
	{
		int_4 = 0;
		int num = gclass8_1.GetValueInt("nudDelayFrom");
		int num2 = gclass8_1.GetValueInt("nudDelayTo");
		List<string> list = gclass8_1.GetValueList("txtLinkChiaSe");
		int num3 = gclass8_1.GetValueInt("cbbKieuShare");
		bool flag = gclass8_1.GetValueBool("ckbVanBan");
		bool flag2 = gclass8_1.GetValueBool("ckbTuDongXoaNoiDung");
		bool flag3 = gclass8_1.GetValueBool("ckbTuongTacBaiViet");
		bool flag4 = gclass8_1.GetValueBool("ckbShareBaiLenTuong");
		bool flag5 = gclass8_1.GetValueBool("ckbShareBaiLenNhom");
		int minValue = gclass8_1.GetValueInt("nudCountGroupFrom");
		int num4 = gclass8_1.GetValueInt("nudCountGroupTo");
		int num5 = gclass8_1.GetValueInt("typeShare");
		List<string> CDAD559C = gclass8_1.GetValueList("lstNhomTuNhap");
		bool flag6 = gclass8_1.GetValueBool("ckbChiShareNhomDaThamGia");
		bool flag7 = gclass8_1.GetValueBool("ckbOnlyShareNhomKhongKiemDuyet");
		bool flag8 = gclass8_1.GetValueBool("ckbUuTienNhomNhieuThanhVien");
		bool flag9 = gclass8_1.GetValueBool("ckbKhongShareTrung");
		bool flag10 = gclass8_1.GetValueBool("ckbTuongTacNhom");
		bool flag11 = gclass8_1.GetValueBool("ckbShareBaiLenPage");
		int minValue2 = gclass8_1.GetValueInt("nudCountPageFrom");
		int num6 = gclass8_1.GetValueInt("nudCountPageTo");
		if (flag9 && !dictionary_26.ContainsKey(string_3))
		{
			dictionary_26.Add(string_3, new List<string>());
		}
		new List<string>();
		List<string> list2 = new List<string>();
		string text = list[int_5 % list.Count];
		text = Common.SpinText(text);
		string value = Regex.Match(text, "https://(.*?)facebook.com/").Value;
		if (value != "")
		{
			text = text.Replace(value, "https://m.facebook.com/");
		}
		int num7 = 0;
		try
		{
			if (flag3)
			{
				DDA5D83C.GotoURL(text);
				DDA5D83C.DelayTime(2.0);
				method_34(int_5, string_1 + Language.GetValue("Đang tương tác bài viết "), DDA5D83C, gclass8_1);
			}
			switch (num3)
			{
			case 0:
			{
				if (flag4)
				{
					method_86(int_5, string_1 + Language.GetValue("Share tường") + "...");
					if (DDA5D83C.CheckIsLive())
					{
						return -2;
					}
					int num14;
					do
					{
						DDA5D83C.GotoURL("https://m.facebook.com/profile.php");
						num14 = method_51(DDA5D83C);
					}
					while (num14 == 1);
					if (new List<int> { -3, -2, -1, 2 }.Contains(num14))
					{
						return -1;
					}
					if (DDA5D83C.method_12(10, new string[2] { "[data-sigil=\"show_composer\"]", "#timelineBody > div > div > div > div:nth-child(2)" }) == 1)
					{
						DDA5D83C.DelayTime(2.0);
						if (DDA5D83C.CheckExistElement("[data-sigil=\"touchable aaa_public\"]") == 1)
						{
							DDA5D83C.Click(4, "[data-sigil=\"touchable aaa_public\"]");
						}
						string text4 = DDA5D83C.CheckExistElements(10.0, new List<string> { "[data-sigil=\"composer-textarea m-textarea-input\"]", "[data-sigil=\"m-textarea-input composer-textarea\"]", "[data-sigil=\"m-textarea-input composer-placeholder-textarea\"]" });
						if (text4 != "")
						{
							if (DDA5D83C.CheckExistElement("input[value=\"300645083384735\"]") != 1)
							{
								DDA5D83C.DelayTime(1.0);
								if (DDA5D83C.Click(4, "#m_composer_privacy_selector #m_privacy_button_text_id") == 1)
								{
									if (DDA5D83C.CheckExistElement("input[value=\"300645083384735\"]", 5.0) == 1)
									{
										DDA5D83C.E2AE03B6();
										DDA5D83C.DelayTime(1.0);
										DDA5D83C.ExecuteJSClick("input[value=\"300645083384735\"]");
										if (!DDA5D83C.method_59(3))
										{
											DDA5D83C.ExecuteScript("document.querySelector('#m_composer_set_as_default_privacy_selector').checked=true;");
											DDA5D83C.DelayTime(1.0);
											DDA5D83C.Click("#modalDialogView button[type=\"submit\"]");
											DDA5D83C.DelayTime(1.0);
										}
									}
									else
									{
										DDA5D83C.ExecuteScript("document.querySelector('[data-sigil=\"dialog-cancel-button\"]').click()");
									}
								}
							}
							DDA5D83C.SendKeys(text4, text);
							DDA5D83C.DelayRandom(3, 5);
							DDA5D83C.ClearText(4, text4);
							DDA5D83C.DelayTime(2.0);
							if (flag && dictionary_19[string_3].Count > 0)
							{
								string string_4 = "";
								if (!flag2)
								{
									string_4 = dictionary_19[string_3].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
								}
								else
								{
									lock (dictionary_19)
									{
										int index4 = dictionary_19[string_3].smethod_5();
										string_4 = dictionary_19[string_3][index4];
										dictionary_19[string_3].RemoveAt(index4);
									}
								}
								DDA5D83C.SendKeys(text4, string_4);
								DDA5D83C.DelayTime(2.0);
							}
							if (DDA5D83C.Click(4, "#composer-main-view-id > div > div > div:nth-child(3) > div button") == 1)
							{
								DDA5D83C.DelayRandom(3, 5);
								for (int j = 0; j < 60; j++)
								{
									if (!DDA5D83C.CheckFacebookBlocked())
									{
										try
										{
											if (!Convert.ToBoolean(DDA5D83C.ExecuteScript("var x='false'; if(document.querySelector('[data-sigil=\"inprogress\"]')!=null) x=(document.querySelector('[data-sigil=\"inprogress\"]').getAttribute('style')=='')+''; return x")))
											{
												break;
											}
										}
										catch
										{
											break;
										}
										Common.Sleep(1.0);
										continue;
									}
									return -4;
								}
								int_4++;
								method_86(int_5, string_1 + Language.GetValue("Đã share tường xong, đợi {time}s..."), Common.DelayRandom(num, num2));
							}
						}
					}
				}
				if (flag5)
				{
					num7 = 0;
					if (DDA5D83C.CheckIsLive())
					{
						return -2;
					}
					List<string> source2 = new List<string>();
					if (num5 == 0 || (num5 == 1 && flag6))
					{
						method_86(int_5, string_1 + Language.GetValue("Scan group..."));
						source2 = DDA5D83C.CheckGroupByToken(flag7);
					}
					list2 = ((!flag7) ? source2.Select((string string_0) => string_0).ToList() : source2.Where((string string_0) => string_0.Split('|')[3].ToLower() == "false").ToList());
					if (flag8)
					{
						list2.Sort((string string_0, string BD8DBA9F) => int.Parse(BD8DBA9F.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2])));
					}
					else
					{
						list2 = list2.OrderBy((string string_0) => Guid.NewGuid()).ToList();
					}
					if (num5 == 1)
					{
						if (flag6)
						{
							source2 = Common.CloneList(list2);
							list2 = source2.Where((string string_0) => CDAD559C.Contains(string_0.Split('|')[0])).ToList();
						}
						else
						{
							list2 = new List<string>(CDAD559C);
							list2 = list2.OrderBy((string A529A99D) => Guid.NewGuid()).ToList();
						}
					}
					int num15 = Base.rd.Next(minValue, num4 + 1);
					string text5 = "";
					if (list2.Count > 0)
					{
						method_86(int_5, string_1 + Language.GetValue("Đang share nhóm") + "...");
						int num16 = 0;
						while (num16 < num15)
						{
							while (list2.Count != 0)
							{
								text5 = list2[0];
								list2.Remove(text5);
								text5 = text5.Split('|')[0];
								if (flag9)
								{
									lock (dictionary_26[string_3])
									{
										if (dictionary_26[string_3].Contains(text5))
										{
											continue;
										}
										dictionary_26[string_3].Add(text5);
										goto IL_084f;
									}
								}
								goto IL_084f;
							}
							break;
							IL_084f:
							if (flag10)
							{
								DDA5D83C.GotoURL("https://m.facebook.com/groups/" + text5);
								DDA5D83C.DelayTime(2.0);
								AB2CF090(int_5, string_1 + Language.GetValue("Đang tương tác "), DDA5D83C, gclass8_1, text5);
							}
							int num17;
							do
							{
								DDA5D83C.GotoURL("https://m.facebook.com/groups/" + text5);
								num17 = method_51(DDA5D83C);
							}
							while (num17 == 1);
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num17))
							{
								DDA5D83C.CheckExistElements(10.0, new List<string> { "#MRoot>div>div:nth-child(3) [role=\"button\"]", "[data-sigil=\"show_composer touchable\"]", "#MRoot > div > div> div > div > div:nth-child(2)", "#root > div > div > div > div > div:nth-child(2) > div" });
								if (DDA5D83C.method_12(10, new string[4] { "#MRoot>div>div:nth-child(3) [role=\"button\"]", "[data-sigil=\"show_composer touchable\"]", "#MRoot > div > div> div > div > div:nth-child(2)", "#root > div > div > div > div > div:nth-child(2) > div" }) == 1)
								{
									DDA5D83C.DelayTime(2.0);
									string text6 = DDA5D83C.CheckExistElements(10.0, new List<string> { "[data-sigil=\"composer-textarea m-textarea-input\"]", "[data-sigil=\"m-textarea-input composer-textarea\"]" });
									if (text6 != "")
									{
										DDA5D83C.SendKeys(text6, text);
										DDA5D83C.DelayRandom(3, 5);
										DDA5D83C.ClearText(4, text6);
										DDA5D83C.DelayTime(2.0);
										if (flag && dictionary_19[string_3].Count > 0)
										{
											string string_5 = "";
											if (!flag2)
											{
												string_5 = dictionary_19[string_3].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
											}
											else
											{
												lock (dictionary_19)
												{
													int index5 = dictionary_19[string_3].smethod_5();
													string_5 = dictionary_19[string_3][index5];
													dictionary_19[string_3].RemoveAt(index5);
												}
											}
											DDA5D83C.SendKeys(text6, string_5);
											DDA5D83C.DelayTime(2.0);
										}
										if (DDA5D83C.Click(4, "#composer-main-view-id > div > div > div:nth-child(3) > div button") == 1)
										{
											DDA5D83C.DelayRandom(3, 5);
											for (int k = 0; k < 60; k++)
											{
												if (!DDA5D83C.CheckFacebookBlocked())
												{
													try
													{
														if (!Convert.ToBoolean(DDA5D83C.ExecuteScript("var x='false'; if(document.querySelector('[data-sigil=\"inprogress\"]')!=null) x=(document.querySelector('[data-sigil=\"inprogress\"]').getAttribute('style')=='')+''; return x")))
														{
															break;
														}
													}
													catch
													{
														break;
													}
													Common.Sleep(1.0);
													continue;
												}
												return -4;
											}
											int_4++;
											num7++;
											method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share nhóm") + " ({0}/{1})", num7, num15) + ", đợi {time}s...", Common.DelayRandom(num, num2));
										}
									}
								}
								num16++;
								continue;
							}
							return -1;
						}
					}
				}
				if (!flag11)
				{
					break;
				}
				num7 = 0;
				if (DDA5D83C.CheckIsLive())
				{
					return -2;
				}
				method_86(int_5, string_1 + Language.GetValue("Scan page..."));
				List<string> list4 = CommonChrome.GetListPageSuggestion2(DDA5D83C);
				int num18 = Base.rd.Next(minValue2, num6 + 1);
				string text7 = "";
				if (list4.Count <= 0)
				{
					break;
				}
				method_86(int_5, string_1 + Language.GetValue("Đang share page") + "...");
				for (int l = 0; l < num18; l++)
				{
					if (list4.Count == 0)
					{
						break;
					}
					text7 = list4[Base.rd.Next(0, list4.Count)];
					list4.Remove(text7);
					int num19;
					do
					{
						DDA5D83C.GotoURL("https://m.facebook.com/" + text7 + "/posts");
						num19 = method_51(DDA5D83C);
					}
					while (num19 == 1);
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num19))
					{
						if (DDA5D83C.method_12(10, new string[2] { "#rootcontainer>div>div>div>div:nth-child(3)>div>div>div>div>span", "body>div>div>div:nth-child(4)>div>div:nth-child(1)>div>div:nth-child(4)>div>div:nth-child(2)>div:nth-child(1)>div>div>div:nth-child(1)" }) != 1)
						{
							continue;
						}
						DDA5D83C.DelayTime(2.0);
						string text8 = DDA5D83C.CheckExistElements(10.0, new List<string> { "[data-sigil=\"composer-textarea m-textarea-input\"]", "[data-sigil=\"m-textarea-input composer-textarea\"]" });
						if (!(text8 != ""))
						{
							continue;
						}
						DDA5D83C.SendKeys(4, text8, text);
						DDA5D83C.DelayRandom(3, 5);
						DDA5D83C.ClearText(4, text8);
						DDA5D83C.DelayTime(2.0);
						if (flag && dictionary_19[string_3].Count > 0)
						{
							string string_6 = "";
							if (!flag2)
							{
								string_6 = dictionary_19[string_3].OrderBy((string D7A01224) => Guid.NewGuid()).FirstOrDefault();
							}
							else
							{
								lock (dictionary_19)
								{
									int index6 = dictionary_19[string_3].smethod_5();
									string_6 = dictionary_19[string_3][index6];
									dictionary_19[string_3].RemoveAt(index6);
								}
							}
							DDA5D83C.SendKeys(text8, string_6);
							DDA5D83C.DelayTime(2.0);
						}
						if (DDA5D83C.Click(4, "#composer-main-view-id > div > div > div:nth-child(3) > div button") != 1)
						{
							continue;
						}
						DDA5D83C.DelayRandom(3, 5);
						for (int m = 0; m < 60; m++)
						{
							if (!DDA5D83C.CheckFacebookBlocked())
							{
								try
								{
									if (!Convert.ToBoolean(DDA5D83C.ExecuteScript("var x='false'; if(document.querySelector('[data-sigil=\"inprogress\"]')!=null) x=(document.querySelector('[data-sigil=\"inprogress\"]').getAttribute('style')=='')+''; return x")))
									{
										break;
									}
								}
								catch
								{
									break;
								}
								Common.Sleep(1.0);
								continue;
							}
							return -4;
						}
						int_4++;
						num7++;
						method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share page") + " ({0}/{1})", num7, num18) + ", đợi {time}s...", Common.DelayRandom(num, num2));
						continue;
					}
					return -1;
				}
				break;
			}
			case 1:
			{
				if (flag4)
				{
					method_86(int_5, string_1 + Language.GetValue("Share tường") + "...");
					if (DDA5D83C.CheckIsLive())
					{
						return -2;
					}
					DDA5D83C.GotoURL(text);
					DDA5D83C.DelayTime(1.0);
					string text9 = "";
					if (flag && dictionary_19[string_3].Count > 0)
					{
						if (!flag2)
						{
							text9 = dictionary_19[string_3].OrderBy((string F11D2D07) => Guid.NewGuid()).FirstOrDefault();
						}
						else
						{
							lock (dictionary_19)
							{
								int index7 = dictionary_19[string_3].smethod_5();
								text9 = dictionary_19[string_3][index7];
								dictionary_19[string_3].RemoveAt(index7);
							}
						}
						string newValue = DDA5D83C.ExecuteScript("return document.title").ToString();
						text9 = text9.Replace("[u]", newValue);
					}
					method_35(DDA5D83C, text9);
					if (DDA5D83C.CheckFacebookBlocked())
					{
						return -4;
					}
					int_4++;
					method_86(int_5, string_1 + Language.GetValue("Đã share tường xong, đợi {time}s..."), Common.DelayRandom(num, num2));
				}
				if (flag5)
				{
					List<string> source3 = new List<string>();
					if (num5 == 0 || (num5 == 1 && flag6))
					{
						method_86(int_5, string_1 + Language.GetValue("Scan group..."));
						source3 = DDA5D83C.CheckGroupByToken(flag7);
					}
					list2 = ((!flag7) ? source3.Select((string AFA4149C) => AFA4149C).ToList() : source3.Where((string string_0) => string_0.Split('|')[3].ToLower() == "false").ToList());
					if (flag8)
					{
						list2.Sort((string string_0, string string_1) => int.Parse(string_1.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2])));
					}
					else
					{
						list2 = list2.OrderBy((string string_0) => Guid.NewGuid()).ToList();
					}
					if (num5 == 1)
					{
						if (flag6)
						{
							source3 = Common.CloneList(list2);
							list2 = source3.Where((string string_0) => CDAD559C.Contains(string_0.Split('|')[0])).ToList();
						}
						else
						{
							list2 = new List<string>(CDAD559C);
							list2 = list2.OrderBy((string string_0) => Guid.NewGuid()).ToList();
						}
					}
					num7 = 0;
					string text10 = "";
					int num20 = Base.rd.Next(minValue, num4 + 1);
					if (list2.Count > 0)
					{
						method_86(int_5, string_1 + Language.GetValue("Đang share nhóm") + "...");
						int num21 = 0;
						while (num21 < num20)
						{
							while (list2.Count != 0)
							{
								text10 = list2[0];
								list2.Remove(text10);
								text10 = text10.Split('|')[0];
								if (flag9)
								{
									lock (dictionary_26[string_3])
									{
										if (dictionary_26[string_3].Contains(text10))
										{
											continue;
										}
										dictionary_26[string_3].Add(text10);
										goto IL_130a;
									}
								}
								goto IL_130a;
							}
							break;
							IL_130a:
							if (flag10)
							{
								DDA5D83C.GotoURL("https://m.facebook.com/groups/" + text10);
								DDA5D83C.DelayTime(2.0);
								AB2CF090(int_5, string_1 + Language.GetValue("Đang tương tác "), DDA5D83C, gclass8_1, text10);
							}
							int num22;
							do
							{
								DDA5D83C.GotoURL(text);
								DDA5D83C.DelayTime(1.0);
								num22 = method_51(DDA5D83C);
							}
							while (num22 == 1);
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num22))
							{
								if (DDA5D83C.CheckExistElement("[data-sigil=\"share-popup\"]", 10.0) == 1)
								{
									DDA5D83C.Click(4, "[data-sigil=\"share-popup\"]");
									DDA5D83C.DelayTime(1.0);
									if (DDA5D83C.CheckExistElement("[data-sigil=\"touchable touchable share-in-a-group-button\"]", 5.0) == 1)
									{
										DDA5D83C.Click(4, "[data-sigil=\"touchable touchable share-in-a-group-button\"]");
										DDA5D83C.DelayTime(1.0);
										if (DDA5D83C.CheckExistElement("[name=\"group_target\"]", 10.0) == 1)
										{
											DDA5D83C.ExecuteScript("document.querySelector('[name=\"group_target\"]').value=\"" + text10 + "\"");
											DDA5D83C.DelayTime(1.0);
											if (flag && dictionary_19[string_3].Count > 0)
											{
												string string_7 = "";
												if (!flag2)
												{
													string_7 = dictionary_19[string_3].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
												}
												else
												{
													lock (dictionary_19)
													{
														int index8 = dictionary_19[string_3].smethod_5();
														string_7 = dictionary_19[string_3][index8];
														dictionary_19[string_3].RemoveAt(index8);
													}
												}
												DDA5D83C.SendKeys("#share_msg_input", string_7);
												DDA5D83C.DelayTime(1.0);
											}
											DDA5D83C.Click(1, "share_submit");
											DDA5D83C.DelayTime(1.0);
										}
									}
								}
								if (!DDA5D83C.CheckFacebookBlocked())
								{
									int_4++;
									num7++;
									method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share nhóm") + " ({0}/{1})", num7, num20) + ", đợi {time}s...", Common.DelayRandom(num, num2));
									num21++;
									continue;
								}
								return -4;
							}
							return -1;
						}
					}
				}
				if (!flag11)
				{
					break;
				}
				num7 = 0;
				if (DDA5D83C.CheckIsLive())
				{
					return -2;
				}
				method_86(int_5, string_1 + Language.GetValue("Scan page..."));
				List<string> list5 = CommonChrome.GetListPageSuggestion2(DDA5D83C);
				int num23 = Base.rd.Next(minValue2, num6 + 1);
				string text11 = "";
				if (list5.Count <= 0)
				{
					break;
				}
				for (int n = 0; n < num23; n++)
				{
					method_86(int_5, string_1 + Language.GetValue("Đang share page") + "...");
					if (list5.Count == 0)
					{
						break;
					}
					text11 = list5[Base.rd.Next(0, list5.Count)];
					list5.Remove(text11);
					int num24;
					do
					{
						DDA5D83C.GotoURL(text);
						DDA5D83C.DelayTime(1.0);
						num24 = method_51(DDA5D83C);
					}
					while (num24 == 1);
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num24))
					{
						if (DDA5D83C.CheckExistElement("[data-sigil=\"share-popup\"]", 10.0) == 1)
						{
							DDA5D83C.Click(4, "[data-sigil=\"share-popup\"]");
							DDA5D83C.DelayTime(1.0);
							if (DDA5D83C.CheckExistElement("#share-with-message-button", 5.0) == 1)
							{
								DDA5D83C.Click(1, "share-with-message-button");
								DDA5D83C.DelayTime(1.0);
								if (DDA5D83C.CheckExistElement("[data-sigil=\"chevron\"]", 5.0) == 1)
								{
									DDA5D83C.Click(4, "[data-sigil=\"chevron\"]");
									DDA5D83C.DelayTime(1.0);
									if (DDA5D83C.CheckExistElement("#modalDialog > div > div > div > div:nth-child(2) > a:nth-child(4)") == 1)
									{
										DDA5D83C.Click(4, "#modalDialog > div > div > div > div:nth-child(2) > a:nth-child(4)");
										DDA5D83C.DelayTime(1.0);
										DDA5D83C.Select(2, "page_target", text11);
										DDA5D83C.DelayTime(1.0);
										if (flag && dictionary_19[string_3].Count > 0)
										{
											string string_8 = "";
											if (!flag2)
											{
												string_8 = dictionary_19[string_3].OrderBy((string CD232288) => Guid.NewGuid()).FirstOrDefault();
											}
											else
											{
												lock (dictionary_19)
												{
													int index9 = dictionary_19[string_3].smethod_5();
													string_8 = dictionary_19[string_3][index9];
													dictionary_19[string_3].RemoveAt(index9);
												}
											}
											DDA5D83C.SendKeys("#share_msg_input", string_8);
											DDA5D83C.DelayTime(1.0);
										}
										DDA5D83C.Click(1, "share_submit");
										DDA5D83C.DelayTime(3.0);
									}
								}
							}
						}
						if (!DDA5D83C.CheckFacebookBlocked())
						{
							int_4++;
							num7++;
							if (num7 < num23)
							{
								method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share page") + " ({0}/{1})", num7, num23) + ", đợi {time}s...", Common.DelayRandom(num, num2));
								continue;
							}
							break;
						}
						return -4;
					}
					return -1;
				}
				break;
			}
			case 2:
				DDA5D83C.SetSize();
				DDA5D83C.SetFbLanguage();
				if (flag4)
				{
					method_86(int_5, string_1 + Language.GetValue("Share tường") + "...");
					if (DDA5D83C.CheckIsLive())
					{
						return -2;
					}
					int num8;
					do
					{
						DDA5D83C.GotoURL("https://www.facebook.com/profile.php");
						num8 = method_51(DDA5D83C);
					}
					while (num8 == 1);
					if (new List<int> { -3, -2, -1, 2 }.Contains(num8))
					{
						return -1;
					}
					string c90FDFAD = "";
					if (flag && dictionary_19[string_3].Count > 0)
					{
						if (!flag2)
						{
							c90FDFAD = dictionary_19[string_3].OrderBy((string B530EA38) => Guid.NewGuid()).FirstOrDefault();
						}
						else
						{
							lock (dictionary_19)
							{
								int index = dictionary_19[string_3].smethod_5();
								c90FDFAD = dictionary_19[string_3][index];
								dictionary_19[string_3].RemoveAt(index);
							}
						}
					}
					switch (B006E595(DDA5D83C, text, c90FDFAD, D524C910.const_0))
					{
					case -4:
						return -4;
					case 1:
						int_4++;
						method_86(int_5, string_1 + Language.GetValue("Share tường xong, đợi {time}s..."), Common.DelayRandom(num, num2));
						break;
					}
				}
				if (flag5)
				{
					num7 = 0;
					if (DDA5D83C.CheckIsLive())
					{
						return -2;
					}
					List<string> source = new List<string>();
					if (num5 == 0 || (num5 == 1 && flag6))
					{
						method_86(int_5, string_1 + Language.GetValue("Scan group..."));
						source = DDA5D83C.CheckGroupByToken(flag7);
					}
					list2 = ((!flag7) ? source.Select((string string_0) => string_0).ToList() : source.Where((string BD1E849C) => BD1E849C.Split('|')[3].ToLower() == "false").ToList());
					if (flag8)
					{
						list2.Sort((string string_0, string string_1) => int.Parse(string_1.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2])));
					}
					else
					{
						list2 = list2.OrderBy((string string_0) => Guid.NewGuid()).ToList();
					}
					if (num5 == 1)
					{
						if (flag6)
						{
							source = Common.CloneList(list2);
							list2 = source.Where((string string_0) => CDAD559C.Contains(string_0.Split('|')[0])).ToList();
						}
						else
						{
							list2 = new List<string>(CDAD559C);
							list2 = list2.OrderBy((string BFACCBA3) => Guid.NewGuid()).ToList();
						}
					}
					int num9 = Base.rd.Next(minValue, num4 + 1);
					string text2 = "";
					if (list2.Count > 0)
					{
						method_86(int_5, string_1 + Language.GetValue("Đang share nhóm") + "...");
						int num10 = 0;
						while (num10 < num9)
						{
							while (list2.Count != 0)
							{
								text2 = list2[0];
								list2.Remove(text2);
								text2 = text2.Split('|')[0];
								if (flag9)
								{
									lock (dictionary_26[string_3])
									{
										if (dictionary_26[string_3].Contains(text2))
										{
											continue;
										}
										dictionary_26[string_3].Add(text2);
										goto IL_1e0e;
									}
								}
								goto IL_1e0e;
							}
							break;
							IL_1e0e:
							if (flag10)
							{
								DDA5D83C.GotoURL("https://m.facebook.com/groups/" + text2);
								DDA5D83C.DelayTime(2.0);
								AB2CF090(int_5, string_1 + Language.GetValue("Đang tương tác "), DDA5D83C, gclass8_1, text2);
							}
							method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share nhóm") + " ({0}/{1})", num7 + 1, num9) + "...");
							int num11;
							do
							{
								DDA5D83C.GotoURL("https://wwww.facebook.com/groups/" + text2);
								num11 = method_51(DDA5D83C);
							}
							while (num11 == 1);
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num11))
							{
								string c90FDFAD2 = "";
								if (flag && dictionary_19[string_3].Count > 0)
								{
									if (!flag2)
									{
										c90FDFAD2 = dictionary_19[string_3].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
									}
									else
									{
										lock (dictionary_19)
										{
											int index2 = dictionary_19[string_3].smethod_5();
											c90FDFAD2 = dictionary_19[string_3][index2];
											dictionary_19[string_3].RemoveAt(index2);
										}
									}
								}
								switch (B006E595(DDA5D83C, text, c90FDFAD2, D524C910.const_1))
								{
								case 1:
									int_4++;
									num7++;
									method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share nhóm") + " ({0}/{1})", num7, num9) + ", đợi {time}s...", Common.DelayRandom(num, num2));
									break;
								case -4:
									return -4;
								}
								num10++;
								continue;
							}
							return -1;
						}
					}
				}
				if (flag11)
				{
					num7 = 0;
					if (DDA5D83C.CheckIsLive())
					{
						return -2;
					}
					method_86(int_5, string_1 + Language.GetValue("Scan page..."));
					List<string> list3 = CommonChrome.GetListPageSuggestion2(DDA5D83C);
					int num12 = Base.rd.Next(minValue2, num6 + 1);
					string text3 = "";
					if (list3.Count > 0)
					{
						method_86(int_5, string_1 + Language.GetValue("Đang share page") + "...");
						for (int i = 0; i < num12; i++)
						{
							if (list3.Count == 0)
							{
								break;
							}
							text3 = list3[Base.rd.Next(0, list3.Count)];
							list3.Remove(text3);
							method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share page") + " ({0}/{1})", num7 + 1, num12) + "...");
							int num13;
							do
							{
								DDA5D83C.GotoURL("https://www.facebook.com/" + text3 + "/posts");
								num13 = method_51(DDA5D83C);
							}
							while (num13 == 1);
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num13))
							{
								string c90FDFAD3 = "";
								if (flag && dictionary_19[string_3].Count > 0)
								{
									if (!flag2)
									{
										c90FDFAD3 = dictionary_19[string_3].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
									}
									else
									{
										lock (dictionary_19)
										{
											int index3 = dictionary_19[string_3].smethod_5();
											c90FDFAD3 = dictionary_19[string_3][index3];
											dictionary_19[string_3].RemoveAt(index3);
										}
									}
								}
								switch (B006E595(DDA5D83C, text, c90FDFAD3, D524C910.const_2))
								{
								case 1:
									int_4++;
									num7++;
									method_86(int_5, string_1 + string.Format(Language.GetValue("Đang share page") + " ({0}/{1})", num7, num12) + ", đợi {time}s...", Common.DelayRandom(num, num2));
									break;
								case -4:
									return -4;
								}
								continue;
							}
							return -1;
						}
					}
				}
				DDA5D83C.RetoreSize();
				break;
			}
		}
		catch
		{
		}
		return num7;
	}

	public string EB087C0C(string B6962527)
	{
		string text = "";
		if (!B6962527.EndsWith("/"))
		{
			B6962527 += "/";
		}
		List<string> list = new List<string>
		{
			"story_fbid=(.*?)&", "permalink/(.*?)/", "v=(.*?)&", "post_id=(.*?)&", "v=(.*?)/", "videos/(.*?)/", "videos/(.*?)\\?", "posts/(.*?)/", "posts/(.*?)\\?", "view_tray_pagination/(.*?)/",
			"fbid=(.*?)&", "multi_permalinks=(.*?)&"
		};
		for (int i = 0; i < list.Count; i++)
		{
			text = Regex.Match(B6962527, list[i].Replace("(.*?)", "\\d+")).Value;
			if (text != "")
			{
				text = text.Replace(list[i].Split(new string[1] { "(.*?)" }, StringSplitOptions.None)[0], "");
				text = text.Replace(list[i].Split(new string[1] { "(.*?)" }, StringSplitOptions.None)[1], "");
				text = text.Replace("?", "");
				if (!text.StartsWith("0"))
				{
					break;
				}
			}
			else
			{
				text = Regex.Match(B6962527, list[i]).Groups[1].Value;
				if (text != "" && !text.Contains("&"))
				{
					break;
				}
			}
		}
		if (text == "" && B6962527.Contains("photos"))
		{
			MatchCollection matchCollection = Regex.Matches(B6962527, "/\\d+/");
			if (matchCollection.Count > 0)
			{
				text = matchCollection[matchCollection.Count - 1].Value;
				text = text.Replace("/", "");
			}
		}
		return text;
	}

	private int method_36(int int_4, string C39D60A9, JSON_Settings gclass8_1, string string_1)
	{
		D689A787(int_4, C39D60A9 + string.Format(Language.GetValue("Đang {0}, " + Language.GetValue("đợi") + " {{time}}s..."), string_1), gclass8_1.GetValueInt("nudDelayFrom"), gclass8_1.GetValueInt("nudDelayTo"));
		return 1;
	}

	private void method_37(Chrome BA810037, string string_1, int D58D8898)
	{
		try
		{
			if (BA810037 != null)
			{
				string text = FileHelper.GetPathToCurrentFolder() + "\\log_capture";
				switch (D58D8898)
				{
				case 0:
					text += "\\checkpoint";
					break;
				case 1:
					text += "\\loginfail";
					break;
				case 2:
					text += "\\disconnect";
					break;
				}
				Common.CreateFolder(text);
				BA810037.ScreenCapture(text, string_1);
				File.WriteAllText(text + "\\" + string_1 + ".txt", BA810037.GetURL());
				File.WriteAllText(text + "\\" + string_1 + ".html", BA810037.GetPageSource());
			}
		}
		catch
		{
		}
	}

	private bool method_38(Chrome f336F52E_0)
	{
		bool flag = false;
		try
		{
			f336F52E_0.GotoURL("https://www.instagram.com/");
			method_57();
			switch (f336F52E_0.CheckExistElements(10.0, "[href=\"/accounts/activity/\"]", "form button"))
			{
			case 2:
				f336F52E_0.Click(4, "form button", 1);
				switch (f336F52E_0.CheckExistElements(10.0, "[href=\"/accounts/activity/\"]", "[name=\"__CONFIRM__\"]", "[name=\"username\"]"))
				{
				case 2:
				{
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.Click(2, "__CONFIRM__");
					string text = "minsoft" + Common.CreateRandomString(3) + Common.CreateRandomString(5);
					f336F52E_0.SendKeys(2, "username", text);
					Common.Sleep(1.0);
					string text2 = "Minsoft_" + Common.CreateRandomString(6);
					f336F52E_0.SendKeys(2, "password", text2);
					method_57();
					f336F52E_0.Click(4, "form button[type=\"submit\"]");
					method_57();
					if (f336F52E_0.CheckExistElement("[href=\"/accounts/activity/\"]", 10.0) == 1)
					{
						flag = true;
					}
					if (!flag && f336F52E_0.CheckExistElement("[type=\"button\"]") == 1)
					{
						flag = true;
					}
					if (flag)
					{
						lock (object_1)
						{
							File.AppendAllText("accountIG.txt", text + "|" + text2 + Environment.NewLine);
						}
					}
					break;
				}
				case 1:
				case 3:
					break;
				}
				break;
			case 1:
				flag = true;
				break;
			}
		}
		catch
		{
		}
		return flag;
	}

	private void E5116117(Chrome f336F52E_0)
	{
		try
		{
			if (!f336F52E_0.Logout())
			{
				f336F52E_0.FA9CB799(CD26589B: false, bool_6: true);
			}
		}
		catch
		{
		}
	}

	private bool A00E03BA(Chrome f336F52E_0)
	{
		bool result = false;
		try
		{
			if (f336F52E_0.GetFbWeb() != 1)
			{
				f336F52E_0.GotoURLIfNotExist("https://www.facebook.com");
			}
			switch (f336F52E_0.GetFbWeb())
			{
			case 2:
			{
				f336F52E_0.GotoURL("https://m.facebook.com/settings/security_login/sessions/log_out_all/confirm/");
				f336F52E_0.DelayTime(1.0);
				string text = "";
				for (int i = 0; i < 10; i++)
				{
					text = f336F52E_0.ExecuteScript("return document.documentElement.innerHTML.match(new RegExp('/security/settings/sessions/log_out_all/(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
					if (!(text != ""))
					{
						f336F52E_0.DelayTime(1.0);
						continue;
					}
					f336F52E_0.GotoURL("https://m.facebook.com" + text);
					result = true;
					break;
				}
				break;
			}
			case 1:
				f336F52E_0.FA9CB799(CD26589B: true, bool_6: false);
				break;
			}
		}
		catch
		{
		}
		return result;
	}

	public int method_39(int int_4, string string_1, Chrome C4863692, string string_2, int BA218CBF, int D395E10B, int CF015EB8, int B80FA123, int C80DE3AB, bool bool_5, int int_5, bool bool_6, List<string> FE058839, List<string> list_4, bool B0A39BAB, List<string> F398AF97, string string_3, int int_6, string string_4 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = Base.rd.Next(BA218CBF, D395E10B + 1);
		string text = "";
		List<string> list = new List<string>();
		try
		{
			string e00FDA = C4863692.GetUseragent().Split('$')[0];
			string_2 = C4863692.GetCookieFromChrome();
			list = method_41(C4863692, string_2, e00FDA, string_3, int_6, C80DE3AB, bool_5, int_5, bool_6, FE058839, B0A39BAB, F398AF97);
			if (list_4.Count > 0)
			{
				list = list.Except(list_4).ToList();
			}
			if (list.Count != 0)
			{
				int num3 = 0;
				while (num < num2 && list.Count != 0)
				{
					text = list[Base.rd.Next(0, list.Count)];
					list.Remove(text);
					while (true)
					{
						string text2 = CommonChrome.RequestGet(C4863692, "https://m.facebook.com/groups/" + text + "/?notif_t=added_to_group_reminder", C4863692.GetURL());
						if (!text2.Contains("invite_response=accept"))
						{
							C4863692.GotoURL("https://m.facebook.com/groups/" + text + "?view=info");
							C4863692.DelayTime(2.0);
							int num4 = method_51(C4863692);
							if (num4 == 1)
							{
								continue;
							}
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num4))
							{
								if (C4863692.CheckExistElement("[href=\"/\"]") == 1 || C4863692.CheckFacebookBlocked())
								{
									goto end_IL_0430;
								}
								for (int i = 0; i < 3; i++)
								{
									string text3 = C4863692.GetCssSelector("a", "href", "/group/leave/");
									if (!(text3 != ""))
									{
										C4863692.DelayTime(2.0);
										continue;
									}
									C4863692.Click(4, text3);
									C4863692.DelayTime(3.0);
									break;
								}
								if (C4863692.CheckExistElement("[name=\"confirm\"]", 10.0) == 1)
								{
									num3 = 0;
									method_57();
									C4863692.Click(2, "confirm");
									method_57();
									num++;
									if (string_4 == "")
									{
										method_86(int_4, string_1 + Language.GetValue("Đang Rời nhóm") + $" ({num}/{num2})...");
									}
									else
									{
										method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_4} ({num}/{num2})...");
									}
									C4863692.DelayTime(Base.rd.Next(CF015EB8, B80FA123 + 1));
								}
								else
								{
									num3++;
									if (num3 == 20)
									{
										goto end_IL_0430;
									}
								}
								break;
							}
							return -1;
						}
						C4863692.GotoURL("https://m.facebook.com/groups/" + text + "/?notif_t=added_to_group_reminder");
						C4863692.DelayTime(1.0);
						string text4 = C4863692.GetURL();
						if (C4863692.CheckExistElement("[data-ajaxify-href*=\"invite_response=decline\"]", 10.0) != 1)
						{
							break;
						}
						if (C4863692.Click(4, "[data-ajaxify-href*=\"invite_response=decline\"]") != 1)
						{
							C4863692.ExecuteScript("document.querySelector('[data-ajaxify-href*=\"invite_response=decline\"]').click()");
						}
						for (int j = 0; j < 20; j++)
						{
							if (C4863692.GetURL() != text4)
							{
								break;
							}
							Thread.Sleep(1000);
						}
						num++;
						if (string_4 == "")
						{
							method_86(int_4, string_1 + Language.GetValue("Đang Rời nhóm") + $" ({num}/{num2})...");
						}
						else
						{
							method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_4} ({num}/{num2})...");
						}
						C4863692.DelayTime(Base.rd.Next(CF015EB8, B80FA123 + 1));
						break;
					}
					continue;
					end_IL_0430:
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(C4863692, exception_, "Error Leave Group");
		}
		return num;
	}

	private bool method_40(string string_1, List<string> list_4)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < list_4.Count; i++)
			{
				if (Common.ConvertToUnSign(string_1).ToLower().Contains(Common.ConvertToUnSign(list_4[i]).ToLower()))
				{
					result = true;
					break;
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private List<string> method_41(Chrome f336F52E_0, string string_1, string E00FDA93, string string_2, int F9B40AA6, int int_4, bool bool_5, int C60BB2A5, bool AA89C083, List<string> list_4, bool EA88A996, List<string> list_5)
	{
		List<string> list = new List<string>();
		try
		{
			if (int_4 == 2)
			{
				list_4 = list_4.ConvertAll((string string_0) => string_0.ToLower());
			}
			string input = CommonChrome.RequestGet(f336F52E_0, "https://m.facebook.com/help", "https://m.facebook.com");
			string value = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string text = f336F52E_0.GetUIDFromCookies();
			input = CommonChrome.RequestPost(f336F52E_0, "https://www.facebook.com/api/graphql/", "q=nodes(" + text + "){groups{nodes{id,name,viewer_post_status,visibility,group_member_profiles{count}}}}&fb_dtsg=" + value, "https://www.facebook.com/api/graphql/");
			JObject jObject = JObject.Parse(input);
			foreach (JToken item in (IEnumerable<JToken>)jObject[text]["groups"]["nodes"])
			{
				try
				{
					switch (int_4)
					{
					case 0:
						list.Add(item["id"].ToString());
						continue;
					case 1:
						if (item["viewer_post_status"].ToString() == "CAN_POST_AFTER_APPROVAL" || item["viewer_post_status"].ToString() == "CANNOT_POST")
						{
							list.Add(item["id"].ToString());
						}
						continue;
					}
					string text2 = item["id"].ToString();
					string string_3 = item["name"].ToString();
					string value2 = item["group_member_profiles"]["count"].ToString();
					if ((bool_5 && Convert.ToInt32(value2) < C60BB2A5) || (AA89C083 && method_40(string_3, list_4)) || (EA88A996 && method_40(text2, list_5)))
					{
						list.Add(text2);
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
		return list;
	}

	public int method_42(int int_4, string D481B39E, Chrome f336F52E_0, int EB0F5606, int int_5, int ADBE1B87, int int_6, bool AA1C4D24, List<string> list_4, string string_1 = "")
	{
		AA1C4D24 = false;
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			num2 = Base.rd.Next(EB0F5606, int_5 + 1);
			num4 = ((num2 >= 100) ? 10 : 5);
			string text = "";
			while (list_4.Count > 0)
			{
				text = list_4[Base.rd.Next(0, list_4.Count)];
				list_4.Remove(text);
				int num5;
				do
				{
					f336F52E_0.GotoURL("https://m.facebook.com/browse/group/members/?id=" + text + "&start=0&listType=list_nonfriend_nonadmin");
					f336F52E_0.DelayTime(2.0);
					num5 = method_51(f336F52E_0);
				}
				while (num5 == 1);
				if (!new List<int> { -3, -2, -1, 2 }.Contains(num5))
				{
					string text2 = "[data-sigil=\"m-add-friend-flyout\"]:not([style*=\"display: none\"])";
					while (true)
					{
						if (f336F52E_0.CheckExistElement(text2) == 0)
						{
							for (int i = 1; i < 5; i++)
							{
								f336F52E_0.Scroll(0, i * 1000);
								f336F52E_0.DelayTime(2.0);
								if (f336F52E_0.CheckExistElement(text2) > 0)
								{
									break;
								}
							}
							if (f336F52E_0.CheckExistElement(text2) == 0)
							{
								break;
							}
						}
						num3 = (CommonChrome.smethod_33(f336F52E_0, 0) ? (num3 + 1) : 0);
						if (num3 >= num4)
						{
							goto end_IL_0270;
						}
						bool flag = true;
						if (AA1C4D24)
						{
							string text3 = f336F52E_0.ExecuteScript("return document.querySelector('[id^=\"member_\"]:has(" + text2 + ") h3').innerText").ToString();
							if (!Common.smethod_62(text3))
							{
								flag = false;
							}
						}
						if (!flag)
						{
							continue;
						}
						f336F52E_0.ScrollSmooth("document.querySelector('" + text2 + "')");
						f336F52E_0.DelayTime(1.0);
						if (f336F52E_0.Click(text2))
						{
							num++;
							if (num >= num2)
							{
								goto end_IL_0270;
							}
							D689A787(int_4, D481B39E + Language.GetValue("Đang") + string.Format(" {0} ({1}/{2}), {3} {{time}}s...", string_1, num, num2, Language.GetValue("đợi")), ADBE1B87, int_6);
						}
					}
					continue;
				}
				return -1;
				continue;
				end_IL_0270:
				break;
			}
		}
		catch
		{
		}
		return num;
	}

	public int method_43(int int_4, string B1B5DC2A, Chrome f336F52E_0, JSON_Settings gclass8_1, string string_1 = "")
	{
		int minValue = gclass8_1.GetValueInt("nudSoLuongFrom");
		int num = gclass8_1.GetValueInt("nudSoLuongTo");
		int int_5 = gclass8_1.GetValueInt("nudDelayFrom");
		int int_6 = gclass8_1.GetValueInt("nudDelayTo");
		List<string> list = gclass8_1.GetValueList("txtTuKhoa");
		bool flag = gclass8_1.GetValueBool("ckbTuDongTraLoiCauHoi");
		List<string> list2 = gclass8_1.GetValueList("txtCauTraLoi");
		List<string> list3 = new List<string>();
		if (gclass8_1.GetValueBool("ckbGroupId"))
		{
			list3 = gclass8_1.GetValueList("txtGroupId");
		}
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int result = 0;
		try
		{
			int num2 = Base.rd.Next(minValue, num + 1);
			string text = list.GetRandomItem();
			text = Common.SpinText(text);
			int num3;
			do
			{
				f336F52E_0.GotoURL("https://mbasic.facebook.com/search/groups/?q=" + text.ToUrlEncode() + "&source=filter&isTrending=0&paipv=0");
				f336F52E_0.DelayTime(2.0);
				num3 = method_51(f336F52E_0);
			}
			while (num3 == 1);
			if (new List<int> { -3, -2, -1, 2 }.Contains(num3))
			{
				return -1;
			}
			int num4 = 0;
			while (true)
			{
				string string_2 = f336F52E_0.GetURL();
				bool flag2 = false;
				int num5 = f336F52E_0.CountElementWithXpath("[href*=\"/a/group/join/\"]");
				for (int i = 0; i < num5; i++)
				{
					string value = Regex.Match(f336F52E_0.GetAttributeValue("[href*=\"/a/group/join/\"]|" + i, "href"), "group_id=(\\d+)&").Groups[1].Value;
					if (list3.Count <= 0 || list3.Contains(value))
					{
						f336F52E_0.Click("[href*=\"/a/group/join/\"]|" + i);
						f336F52E_0.DelayTime(2.0);
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					if (f336F52E_0.GetPageSource().Contains("group-membership-criteria-answer-form") && flag)
					{
						CommonChrome.AnswerQuestionWhenJoinGroup(f336F52E_0, list2);
						if (f336F52E_0.Click("#group-membership-criteria-answer-form [type=\"submit\"]"))
						{
							f336F52E_0.DelayTime(2, 3);
						}
					}
					num4++;
					if (num4 >= num2)
					{
						break;
					}
					method_86(int_4, B1B5DC2A + Language.GetValue("Đang") + string.Format(" {0} ({1}/{2}), {3}{{time}}s...", string_1, num4, num2, Language.GetValue("đợi")), f336F52E_0.method_53(int_5, int_6));
					f336F52E_0.GotoURL(string_2);
				}
				else
				{
					if (f336F52E_0.CheckExistElement("#see_more_pager a") != 1)
					{
						break;
					}
					f336F52E_0.scrollIntoView("#see_more_pager a");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.Click("#see_more_pager a");
				}
				f336F52E_0.DelayTime(2.0);
				num3 = method_51(f336F52E_0);
				if (new List<int> { -3, -2, -1, 1, 2 }.Contains(num3))
				{
					return -1;
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public int CA8B3990(int int_4, string string_1, Chrome E81B53B5, int int_5, int FA1E4E3D, int int_6, int int_7, List<string> list_4, bool bool_5, List<string> list_5, string string_2 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		E81B53B5.SetSize();
		E81B53B5.SetFbLanguage();
		list_4 = Common.RemoveEmptyItems(list_4);
		list_5 = Common.RemoveEmptyItems(list_5);
		B483A38F(list_5);
		try
		{
			int num2 = Base.rd.Next(int_5, FA1E4E3D + 1);
			string text = "";
			int num3 = 0;
			while (true)
			{
				IL_03c2:
				E81B53B5.GotoURL("https://www.facebook.com");
				E81B53B5.DelayTime(2.0);
				E81B53B5.CheckLoginFacebook();
				while (list_4.Count > 0)
				{
					text = list_4[Base.rd.Next(0, list_4.Count)];
					text = Common.SpinText(text);
					list_4.Remove(text);
					num3 = 0;
					while (E81B53B5.CheckExistElement("[type=\"search\"]", 5.0) == 1)
					{
						E81B53B5.Click(4, "[type=\"search\"]");
						E81B53B5.DelayTime(1.0);
						E81B53B5.SendKeys(4, "[type=\"search\"]", text, bool_6: false);
						E81B53B5.DelayTime(1.0);
						E81B53B5.SendEnter(4, "[type=\"search\"]");
						E81B53B5.DelayTime(1.0);
						if (E81B53B5.CheckExistElement("a[href*=\"/search/groups/\"]", 30.0) != 1)
						{
							break;
						}
						E81B53B5.ScrollSmoothIfNotExistOnScreen("document.querySelector('a[href*=\"/search/groups/\"]')");
						E81B53B5.DelayTime(1.0);
						E81B53B5.Click(4, "a[href*=\"/search/groups/\"]");
						E81B53B5.DelayTime(1.0);
						E81B53B5.Scroll(500, 0);
						E81B53B5.DelayTime(3.0);
						if (E81B53B5.CheckExistElement("[role=\"article\"] [role=\"button\"]", 15.0) != 1)
						{
							break;
						}
						while (true)
						{
							int num4 = method_51(E81B53B5);
							if (num4 == 1)
							{
								break;
							}
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num4))
							{
								if (E81B53B5.ExecuteScript("return document.querySelectorAll('[role=\"article\"] [role=\"button\"]')[" + num3 + "]+''").ToString() != "")
								{
									_ = Base.rd.Next(1, 100) % 1 == 0;
									E81B53B5.ScrollSmooth("document.querySelectorAll('[role=\"article\"] [role=\"button\"]')[" + num3 + "]");
									E81B53B5.DelayTime(1.0);
									while (E81B53B5.Click(4, "[role=\"article\"] [role=\"button\"]", num3) != 1)
									{
									}
									E81B53B5.DelayTime(5.0);
									if (Convert.ToInt32(E81B53B5.ExecuteScript("return document.querySelectorAll('[role=\"dialog\"]>div:nth-child(3)>div:nth-child(2)>div>div:nth-child(2)>div').length").ToString()) > 0)
									{
										if (bool_5)
										{
											CommonChrome.E2019F99(E81B53B5, list_5);
											if (E81B53B5.CheckExistElement("[role=\"dialog\"]>div:nth-child(3)>div:nth-child(3)>div:nth-child(3) [role=\"button\"]") == 1)
											{
												E81B53B5.Click(4, "[role=\"dialog\"]>div:nth-child(3)>div:nth-child(3)>div:nth-child(3) [role=\"button\"]");
												E81B53B5.DelayTime(1.0);
											}
										}
										else
										{
											E81B53B5.Click(4, "[role=\"dialog\"]>div:nth-child(3)>div:nth-child(3)>div:nth-child(2) [role=\"button\"]");
											E81B53B5.DelayTime(2.0);
											E81B53B5.Click(4, "[role=\"dialog\"]>div:nth-child(3)>div >div:nth-child(2) [role=\"button\"]");
										}
									}
									num++;
									method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_2} ({num}/{num2})...");
									if (num < num2)
									{
										E81B53B5.DelayTime(Base.rd.Next(int_6, int_7 + 1));
										continue;
									}
									goto end_IL_03b1;
								}
								goto IL_03c2;
							}
							return -1;
						}
					}
					continue;
					end_IL_03b1:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		E81B53B5.RetoreSize();
		return num;
	}

	public int method_44(int int_4, string string_1, Chrome E68D7817, JSON_Settings gclass8_1, string string_2 = "")
	{
		int num = gclass8_1.GetValueInt("cbbTypeHuyKetBan");
		int minValue = gclass8_1.GetValueInt("nudSoLuongFrom");
		int num2 = gclass8_1.GetValueInt("nudSoLuongTo");
		int minValue2 = gclass8_1.GetValueInt("nudDelayFrom");
		int num3 = gclass8_1.GetValueInt("nudDelayTo");
		List<string> second = gclass8_1.GetValueList("txtUidHuyKetBan");
		List<string> list = gclass8_1.GetValueList("txtUidKhongHuyKetBan");
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num4 = 0;
		int num5 = Base.rd.Next(minValue, num2 + 1);
		List<string> list2 = CommonChrome.GetMyListUidFriend(E68D7817, (num == 1) ? 2 : 0);
		if (num == 2)
		{
			list2 = list2.Intersect(second).ToList();
		}
		if (list.Count > 0)
		{
			list2 = list2.Except(list).ToList();
		}
		if (num5 > 0)
		{
			string text = "";
			try
			{
				if (list2.Count == 0)
				{
					return num4;
				}
				while (list2.Count != 0)
				{
					text = list2[Base.rd.Next(0, list2.Count)];
					list2.Remove(text);
					int num6;
					do
					{
						E68D7817.GotoURL("https://m.facebook.com/removefriend.php?friend_id=" + text + "&unref=bd_profile_button");
						method_57();
						num6 = method_51(E68D7817);
					}
					while (num6 == 1);
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
					{
						if (E68D7817.CheckExistElement("[name=\"confirm\"]", 10.0) == 1)
						{
							method_57();
							E68D7817.Click(2, "confirm");
							num4++;
							method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_2} ({num4}/{num5})...");
							if (num4 >= num5)
							{
								break;
							}
							E68D7817.DelayTime(Base.rd.Next(minValue2, num3 + 1));
						}
						continue;
					}
					return -1;
				}
			}
			catch
			{
			}
		}
		return num4;
	}

	public int method_45(int int_4, string string_1, Chrome f336F52E_0, string C8BC922A, string B29DC320, int int_5, int int_6, int int_7, List<string> E6936DA7, int C1872B90, int int_8, List<string> A91CBDBE, string string_2, int int_9, string string_3 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = Base.rd.Next(int_6, int_7 + 1);
		string text = f336F52E_0.GetUseragent().Split('$')[0];
		B29DC320 = f336F52E_0.GetCookieFromChrome();
		if (C8BC922A == "" || !CheckInfoAccountv2.CheckToken(B29DC320, C8BC922A, text, string_2, int_9))
		{
			C8BC922A = CommonChrome.smethod_17(f336F52E_0);
		}
		List<string> list = new List<string>();
		if (int_5 == 1)
		{
			list = method_56(C8BC922A, B29DC320, text, string_2, int_9);
			list = Common.GetIntersectItemBetweenTwoList(list, E6936DA7);
		}
		if (num2 > 0)
		{
			string item = "";
			try
			{
				if (int_5 == 0)
				{
					try
					{
						while (true)
						{
							IL_00d7:
							f336F52E_0.GotoURL("https://m.facebook.com/friends/center/friends");
							method_57();
							int num3 = 0;
							while (f336F52E_0.ScrollSmooth("document.querySelectorAll('[data-sigil=\"are-friends-popup\"]')[" + num3 + "]") == 1)
							{
								f336F52E_0.DelayTime(1.0);
								try
								{
									item = f336F52E_0.ExecuteScript("return JSON.parse(document.querySelectorAll('[data-sigil=\"undoable-action\"] [data-sigil=\"touchable check m-cancel-request\"]')[" + num3 + "].getAttribute('data-store')).id").ToString();
								}
								catch
								{
								}
								if (!A91CBDBE.Contains(item))
								{
									f336F52E_0.Click(4, "[data-sigil=\"are-friends-popup\"]", num3);
									f336F52E_0.DelayTime(1.0);
									f336F52E_0.ExecuteScript("document.querySelector('[data-sigil=\"touchable touchable mflyout-remove-on-click m-unfriend-request\"]').click()");
									int num4 = method_51(f336F52E_0);
									if (num4 == 1)
									{
										goto IL_00d7;
									}
									if (new List<int> { -3, -2, -1, 2 }.Contains(num4))
									{
										return -1;
									}
									num++;
									method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_3} ({num}/{num2})...");
									if (num == num2)
									{
										break;
									}
									f336F52E_0.DelayTime(Base.rd.Next(C1872B90, int_8 + 1));
								}
								num3++;
							}
							break;
						}
					}
					catch
					{
					}
				}
				else
				{
					while (list.Count != 0)
					{
						item = list[Base.rd.Next(0, list.Count)];
						list.Remove(item);
						int num5;
						do
						{
							f336F52E_0.GotoURL("https://m.facebook.com/removefriend.php?friend_id=" + item + "&unref=bd_profile_button");
							method_57();
							num5 = method_51(f336F52E_0);
						}
						while (num5 == 1);
						if (!new List<int> { -3, -2, -1, 2 }.Contains(num5))
						{
							if (f336F52E_0.CheckExistElement("[name=\"confirm\"]", 10.0) == 1)
							{
								method_57();
								f336F52E_0.Click(2, "confirm");
								num++;
								method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_3} ({num}/{num2})...");
								if (num >= num2)
								{
									break;
								}
								f336F52E_0.DelayTime(Base.rd.Next(C1872B90, int_8 + 1));
							}
							continue;
						}
						return -1;
					}
				}
			}
			catch
			{
			}
		}
		return num;
	}

	public int method_46(int int_4, string E3A10D24, Chrome f336F52E_0, int int_5, int int_6, int int_7, int int_8, string string_1 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = Base.rd.Next(int_5, int_6 + 1);
		int num3 = 0;
		int num4 = 0;
		try
		{
			int num5;
			do
			{
				f336F52E_0.GotoURL("https://m.facebook.com/friends/center/requests/outgoing/");
				method_57();
				num5 = method_51(f336F52E_0);
			}
			while (num5 == 1);
			if (new List<int> { -3, -2, -1, 2 }.Contains(num5))
			{
				return -1;
			}
			if (f336F52E_0.CheckExistElement("[data-sigil=\"context-layer-root content-pane\"]", 10.0) == 1)
			{
				if (Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelectorAll('[data-sigil=\"undoable-action\"]').length").ToString()) == 0)
				{
					return num;
				}
				while (num < num2)
				{
					if (!f336F52E_0.CheckIsLive())
					{
						if (f336F52E_0.ExecuteScript("return document.querySelectorAll('[data-sigil=\"undoable-action\"]')[" + num4 + "].getAttribute('data-sigil')").ToString() != "")
						{
							method_57();
							f336F52E_0.ScrollSmooth("document.querySelectorAll('[data-sigil=\"touchable check m-cancel-request\"]')[" + num4 + "]");
							method_57();
							f336F52E_0.Click(4, "[data-sigil=\"touchable check m-cancel-request\"]", num4);
							num++;
							num4++;
							method_86(int_4, E3A10D24 + Language.GetValue("Đang") + $" {string_1} ({num}/{num2})...");
							f336F52E_0.DelayTime(Base.rd.Next(int_7, int_8 + 1));
							continue;
						}
						break;
					}
					return -2;
				}
			}
		}
		catch
		{
		}
		return num;
	}

	public List<string> method_47(Chrome f336F52E_0, string B122D4B7, bool D12ACF05 = false)
	{
		List<string> list = new List<string>();
		try
		{
			string input = CommonChrome.RequestGet(f336F52E_0, "https://m.facebook.com/help", "https://m.facebook.com");
			string value = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			if (!f336F52E_0.GetURL().Contains("https://www.facebook.com/api/graphql"))
			{
				f336F52E_0.GotoURL("https://www.facebook.com/api/graphql");
			}
			string json = (string)f336F52E_0.ExecuteScript("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + value + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[B122D4B7]["friends"]["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				if (D12ACF05)
				{
					try
					{
						string text = jObject[B122D4B7]["friends"]["nodes"][i]["name"].ToString();
						if (Common.smethod_62(text))
						{
							list.Add(jObject[B122D4B7]["friends"]["nodes"][i]["name"].ToString());
						}
					}
					catch
					{
					}
				}
				else
				{
					list.Add(jObject[B122D4B7]["friends"]["nodes"][i]["name"].ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public int D31F4A94(int int_4, string string_1, Chrome f336F52E_0, string string_2, int int_5, int int_6, int int_7, int C026C282, List<string> list_4, int int_8, string string_3, int int_9, string string_4 = "")
	{
		string b122D4B = method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = 0;
		string text = "";
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		List<string> list = new List<string>();
		List<string> list_5 = new List<string>();
		try
		{
			if (int_8 == 0)
			{
				list_5 = method_47(f336F52E_0, b122D4B);
			}
			for (int i = 0; i < list_4.Count; i++)
			{
				method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_4}({i + 1}/{list_4.Count})...");
				num5 = Base.rd.Next(int_5, int_6 + 1);
				if (int_8 == 0)
				{
					list = B483A38F(list_5);
				}
				while (true)
				{
					IL_021c:
					f336F52E_0.GotoURL("https://m.facebook.com/groups/members/search/?group_id=" + list_4[i]);
					method_57(1);
					int num6 = method_51(f336F52E_0);
					if (num6 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
					{
						if (int_8 == 0)
						{
							if (f336F52E_0.CheckExistElement("[data-sigil=\" tokenizer-input focus-receiver\"]", 5.0) != 1)
							{
								break;
							}
							while (list.Count > 0)
							{
								num6 = method_51(f336F52E_0);
								if (num6 != 1)
								{
									if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
									{
										text = list[Base.rd.Next(0, list.Count)];
										list.Remove(text);
										num3 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelectorAll('[data-sigil=\"tokenizer-input-container\"]>div>span').length").ToString());
										f336F52E_0.SendKeys(4, "[data-sigil=\" tokenizer-input focus-receiver\"]", text);
										f336F52E_0.DelayTime(0.5);
										f336F52E_0.SendEnter(4, "[data-sigil=\" tokenizer-input focus-receiver\"]");
										num4 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelectorAll('[data-sigil=\"tokenizer-input-container\"]>div>span').length").ToString());
										if (num3 == num4)
										{
											f336F52E_0.ClearText(4, "[data-sigil=\" tokenizer-input focus-receiver\"]");
										}
										if (num4 == num5)
										{
											break;
										}
										continue;
									}
									return -1;
								}
								goto IL_021c;
							}
							f336F52E_0.Click(4, "[data-testid=\"addSelectedButton\"]");
							method_57(3);
							if (f336F52E_0.CheckExistElement("#addMembersInfoArea>span", 5.0) == 1)
							{
								num += Convert.ToInt32(Regex.Match(f336F52E_0.ExecuteScript("return document.querySelector('#addMembersInfoArea>span').innerText").ToString(), "(.*?) ").Groups[1].Value);
							}
							break;
						}
						f336F52E_0.GotoURL("https://mbasic.facebook.com/groups/members/search/?group_id=" + list_4[i] + "&refid=18");
						f336F52E_0.DelayTime(1.0);
						if (f336F52E_0.CheckExistElement("[name*=\"addees\"]", 10.0) != 1)
						{
							break;
						}
						num2 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelectorAll('[name*=\"addees\"]').length").ToString());
						for (int j = 0; j < num2; j++)
						{
							f336F52E_0.Click(4, "[name*=\"addees\"]", j);
							f336F52E_0.DelayTime(1.0);
							num++;
							if (num >= num5)
							{
								break;
							}
						}
						f336F52E_0.Click(2, "add");
						f336F52E_0.DelayTime(3.0);
						break;
					}
					return -1;
				}
			}
		}
		catch
		{
		}
		return num;
	}

	public int method_48(int D83E360E, string string_1, Chrome f336F52E_0, int int_4, int F601ED36, int int_5, int int_6, List<string> list_4, string DCB0CC12 = "")
	{
		method_93(D83E360E, "cUid");
		method_93(D83E360E, "cPassword");
		method_93(D83E360E, "cFa2");
		int num = 0;
		int num2 = Base.rd.Next(int_4, F601ED36 + 1);
		int num3 = 0;
		string text = "";
		List<string> list = B483A38F(list_4);
		try
		{
			while (true)
			{
				IL_038a:
				if (CommonChrome.smethod_5(f336F52E_0) != -2)
				{
					int num4 = method_51(f336F52E_0);
					if (num4 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num4))
					{
						int num5 = 0;
						while (true)
						{
							if (num5 < 5 && f336F52E_0.CheckExistElement("#see_older_threads", 3.0) == 1)
							{
								num3 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelectorAll('#threadlist_rows a').length").ToString()) - 1;
								if (num3 >= num2)
								{
									break;
								}
								f336F52E_0.Click(1, "see_older_threads");
								method_57();
								num5++;
								continue;
							}
							num3 = Convert.ToInt32(f336F52E_0.ExecuteScript("return document.querySelectorAll('#threadlist_rows a').length").ToString());
							if (num3 != 0)
							{
								break;
							}
							return num;
						}
						int num6 = 0;
						while (num6 < num3 && num < num2)
						{
							num4 = method_51(f336F52E_0);
							if (num4 != 1)
							{
								if (!new List<int> { -3, -2, -1, 2 }.Contains(num4))
								{
									f336F52E_0.Click(4, "#threadlist_rows a", num6);
									method_57();
									if (f336F52E_0.CheckExistElement("[data-sigil=\"m-textarea-input photo-textarea\"]", 10.0) == 1)
									{
										if (list.Count == 0)
										{
											list = B483A38F(list_4);
										}
										text = list[Base.rd.Next(0, list.Count)];
										list.Remove(text);
										text = Common.SpinText(text);
										string newValue = f336F52E_0.ExecuteScript("return document.title.split('-')[0]").ToString();
										text = text.Replace("[u]", newValue);
										if (!Common.CheckStringIsContainIcon(text))
										{
											f336F52E_0.SendKeysWithSpeed("[data-sigil=\"m-textarea-input photo-textarea\"]", text + " ", 0.1);
											method_57();
										}
										else
										{
											f336F52E_0.ExecuteScript("document.querySelector('[data-sigil=\"m-textarea-input photo-textarea\"]').value=\"" + text + "\"");
											f336F52E_0.DelayTime(1.0);
											f336F52E_0.SendKeys(4, "[data-sigil=\"m-textarea-input photo-textarea\"]", " ");
											method_57();
										}
										num4 = f336F52E_0.CheckExistElements(5.0, "[name=\"Send\"]", "[name=\"send\"]");
										if (num4 == 1)
										{
											f336F52E_0.Click(4, "[name=\"Send\"]");
										}
										else
										{
											f336F52E_0.Click(4, "[name=\"send\"]");
										}
										if (f336F52E_0.CheckExistElement("[data-sigil=\"context-layer-root content-pane\"]>div>span>div", 5.0) != 1)
										{
											num++;
										}
										method_86(D83E360E, string_1 + Language.GetValue("Đang") + $" {DCB0CC12} ({num}/{num2})...");
										f336F52E_0.DelayTime(Base.rd.Next(int_5, int_6 + 1));
										if (CommonChrome.smethod_5(f336F52E_0) == -2)
										{
											return -2;
										}
									}
									num6++;
									continue;
								}
								return -1;
							}
							goto IL_038a;
						}
						break;
					}
					return -1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return num;
	}

	public int method_49(int int_4, string string_1, Chrome f336F52E_0, int int_5, int FE9556AB, int AEB52B10, int int_6, bool E8920D14, int B193F383, int int_7, bool bool_5, int A93410BA, int int_8, bool E997E3A0, List<string> list_4, int E89AFFA3, int int_9, bool bool_6, int int_10, int BDAEE7B3, string string_2 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		if (E8920D14)
		{
			num7 = Base.rd.Next(B193F383, int_7 + 1);
		}
		list_4 = Common.RemoveEmptyItems(list_4);
		List<string> list = B483A38F(list_4);
		string text = "";
		if (E997E3A0)
		{
			Base.rd.Next(E89AFFA3, int_9 + 1);
		}
		if (bool_5)
		{
			num8 = Base.rd.Next(A93410BA, int_8 + 1);
		}
		if (bool_6)
		{
			num9 = Base.rd.Next(int_10, BDAEE7B3 + 1);
		}
		try
		{
			int num10 = Base.rd.Next(int_5, FE9556AB + 1);
			while (true)
			{
				IL_0690:
				if (CommonChrome.A3985F1D(f336F52E_0) != -2)
				{
					int num11 = method_51(f336F52E_0);
					if (num11 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num11))
					{
						if (f336F52E_0.CheckExistElement("[data-sigil=\"m-video-play-button playInlineVideo\"]", 10.0) != 1)
						{
							break;
						}
						while (num < num10)
						{
							num11 = method_51(f336F52E_0);
							if (num11 != 1)
							{
								if (!new List<int> { -3, -2, -1, 2 }.Contains(num11))
								{
									if (Base.rd.Next(1, 100) % 5 == 0)
									{
										continue;
									}
									object obj;
									switch (f336F52E_0.CheckExistElements(2.0, "#mobile_video_feed_pagelet > div > div:nth-child(2) > div", "#mobile_video_feed_pagelet > div > div > div"))
									{
									default:
										obj = "#mobile_video_feed_pagelet > div > div > div";
										break;
									case 1:
										obj = "#mobile_video_feed_pagelet > div > div:nth-child(2) > div";
										break;
									case 0:
										goto end_IL_0684;
									}
									string text2 = (string)obj;
									f336F52E_0.ScrollSmooth("document.querySelectorAll('" + text2 + "')[" + num2 + "].querySelector('[data-sigil=\"playInlineVideo\"]')");
									method_57(1);
									f336F52E_0.ClickWithAction(4, text2, num2, 4, "[data-sigil=\"playInlineVideo\"]");
									method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_2} ({num}/{num10})...");
									f336F52E_0.DelayTime(Base.rd.Next(AEB52B10, int_6 + 1));
									if (E8920D14 && num3 < num7 && Base.rd.Next(1, 100) % 2 == 0)
									{
										method_57(2);
										if (f336F52E_0.CheckExistElementv2("document.querySelectorAll('" + text2 + "')[" + num2 + "].querySelector('[data-sigil=\"touchable ufi-inline-like like-reaction-flyout\"]')") == 1)
										{
											f336F52E_0.ScrollSmooth("document.querySelectorAll('[data-sigil=\"touchable ufi-inline-like like-reaction-flyout\"]')[" + num2 + "]");
											method_57();
											f336F52E_0.Click(4, "[data-sigil=\"touchable ufi-inline-like like-reaction-flyout\"]", num2);
											method_57(2);
											num3++;
										}
									}
									if (bool_5 && num5 < num8 && Base.rd.Next(1, 100) % 2 == 0 && f336F52E_0.CheckExistElementv2("document.querySelectorAll('[data-sigil=\"share-popup\"]')[" + num2 + "]") == 1)
									{
										f336F52E_0.Click(4, "[data-sigil=\"share-popup\"]", num2);
										method_57();
										f336F52E_0.method_12(5, new string[3] { "#share-one-click-button", "#share-post-one-click-button", "#share_submit" });
										f336F52E_0.DelayTime(3.0);
										num5++;
										if (f336F52E_0.GetURL().Contains("facebook.com/error/index.php"))
										{
											f336F52E_0.GotoBackPage();
											bool_5 = false;
										}
									}
									if (E997E3A0 && Base.rd.Next(1, 100) % 2 == 0)
									{
										if (list.Count == 0)
										{
											list = B483A38F(list_4);
										}
										if (f336F52E_0.CheckExistElementv2("document.querySelectorAll('[data-store*=\"unit_position\"]')[" + num2 + "].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')") == 1)
										{
											f336F52E_0.Click(4, "[data-store*=\"unit_position\"]", num2, 4, "[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]");
											method_57();
											if (f336F52E_0.CheckExistElement("[data-sigil=\"textarea mufi-composer m-textarea-input\"]", 10.0) == 1)
											{
												text = list[Base.rd.Next(0, list.Count)];
												list.Remove(text);
												text = Common.SpinText(text);
												string newValue = CommonChrome.GetNameFromPost(f336F52E_0);
												text = text.Replace("[u]", newValue);
												string text3 = "[data-sigil=\"textarea mufi-composer m-textarea-input\"]";
												if (Common.CheckStringIsContainIcon(text))
												{
													text = text.Replace("\r\n", "*r*n").Replace("\n", "*r*n");
													text = text.Replace("*r*n", "\\r\\n").Replace("\"", "\\\"");
													f336F52E_0.Click(4, text3);
													f336F52E_0.ExecuteScript("document.querySelector('" + text3 + "').value=\"" + text + "\"");
													f336F52E_0.SendKeys(4, text3, " ", 0.1, isClick: false);
												}
												else
												{
													f336F52E_0.SendKeysWithSpeed(text3, text + " ", 0.1);
												}
												method_57();
												f336F52E_0.Click(4, "[name=\"submit\"]");
												method_57(2);
												if (f336F52E_0.CheckFacebookBlocked())
												{
													return -4;
												}
												f336F52E_0.GotoBackPage();
												num4++;
											}
										}
									}
									if (bool_6 && Base.rd.Next(0, 100) % 2 == 0 && num6 < num9 && f336F52E_0.ExecuteScript("return document.querySelectorAll('[data-sigil=\"story-div story-popup-metadata feed-ufi-metadata\"]>div>header>div:nth-child(2)>div>div>div>div>div:nth-child(3)>div')[" + num2 + "].getAttribute('id')+''").ToString() != "null")
									{
										f336F52E_0.Click(4, "[data-sigil=\"story-div story-popup-metadata feed-ufi-metadata\"]>div>header>div:nth-child(2)>div>div>div>div>div:nth-child(3)>div", num2);
										f336F52E_0.DelayTime(1.0);
									}
									num2++;
									if (num2 == 3)
									{
										f336F52E_0.Refresh();
										num2 = 0;
									}
									num++;
									continue;
								}
								return -1;
							}
							goto IL_0690;
							continue;
							end_IL_0684:
							break;
						}
						break;
					}
					return -1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return num;
	}

	public int method_50(int int_4, string BCA88282, Chrome f336F52E_0, int F026540D, int int_5, int int_6, int int_7, int int_8, string EEB8AD33 = "")
	{
		return 0;
	}

	private int method_51(Chrome f336F52E_0, bool bool_5 = false)
	{
		int num = 0;
		string string_ = f336F52E_0.cUid;
		string string_2 = f336F52E_0.cPassword;
		string string_3 = f336F52E_0.cFa2;
		CommonChrome.smethod_27(f336F52E_0, bool_5, ref num);
		if (num == 0)
		{
			switch (f336F52E_0.Status)
			{
			case StatusChromeAccount.ChromeClosed:
				num = -2;
				break;
			case StatusChromeAccount.LoginWithUserPass:
			{
				string text = CommonChrome.LoginFacebookUsingUidPassNew(f336F52E_0, string_, string_2, string_3, "https://m.facebook.com/", SettingsTool.GetSettings("configGeneral").GetValueBool("ckbDontSaveBrowser"));
				num = ((text == "1") ? 1 : 2);
				break;
			}
			case StatusChromeAccount.Checkpoint:
				num = -1;
				break;
			case StatusChromeAccount.NoInternet:
				num = -3;
				break;
			}
		}
		return num;
	}

	public int method_52(int int_4, string string_1, Chrome BDB3D2B5, int AAB5B28D, int int_5, int E1BB5A9C, int FA06C187, bool bool_5, string string_2, bool bool_6, List<string> list_4, string string_3 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		string text = "";
		try
		{
			while (true)
			{
				IL_0306:
				if (CommonChrome.GoToHome(BDB3D2B5) != -2)
				{
					int num2 = method_51(BDB3D2B5);
					if (num2 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num2))
					{
						int num3 = Base.rd.Next(AAB5B28D, int_5 + 1);
						int num4 = 0;
						string text2 = "0";
						List<string> list = new List<string>();
						list = B483A38F(list_4);
						if (BDB3D2B5.CheckExistElement("[data-sigil=\"m-stories-rectangular-item-title\"]", 10.0) != 1)
						{
							break;
						}
						num4 = Convert.ToInt32(BDB3D2B5.ExecuteScript("return document.querySelectorAll('[data-sigil=\"m-stories-rectangular-item-title\"]').length").ToString());
						if (num4 <= 0)
						{
							break;
						}
						BDB3D2B5.Click(4, "[data-sigil=\"m-stories-rectangular-item-title\"]", 1);
						method_57();
						while (num < num3)
						{
							num2 = method_51(BDB3D2B5);
							if (num2 != 1)
							{
								if (!new List<int> { -3, -2, -1, 2 }.Contains(num2))
								{
									if (BDB3D2B5.CheckExistElement("[data-sigil=\"m-stories-next-button\"]") != 1)
									{
										break;
									}
									if (BDB3D2B5.CheckExistElement("[data-sigil=\"m-video-play-button playInlineVideo\"]", 1.0) == 1)
									{
										BDB3D2B5.ClickWithAction(4, "[data-sigil=\"m-video-play-button playInlineVideo\"]");
									}
									BDB3D2B5.DelayTime(Base.rd.Next(E1BB5A9C, FA06C187 + 1));
									if (bool_5)
									{
										text2 = string_2[Base.rd.Next(0, string_2.Length)].ToString();
										BDB3D2B5.Click(4, "[data-sigil=\"m-stories-reply-reaction-li\"]", Convert.ToInt32(text2));
										method_57();
									}
									if (bool_6)
									{
										if (list.Count == 0)
										{
											list = B483A38F(list_4);
										}
										text = list[Base.rd.Next(0, list.Count)];
										list.Remove(text);
										text = Common.SpinText(text);
										text = text.Replace("[u]", CommonChrome.smethod_1(BDB3D2B5));
										method_57();
										BDB3D2B5.SendKeysWithSpeed("[data-sigil=\"m-stories-reply-input\"]", text, 0.1);
										method_57();
										BDB3D2B5.SendEnter(4, "[data-sigil=\"m-stories-reply-input\"]");
									}
									num++;
									method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_3} ({num}/{num3})...");
									method_57();
									if (BDB3D2B5.CheckExistElement("[data-sigil=\"m-stories-next-button\"]") == 1)
									{
										BDB3D2B5.Click(4, "[data-sigil=\"m-stories-next-button\"]");
										continue;
									}
									break;
								}
								return -1;
							}
							goto IL_0306;
						}
						break;
					}
					return -1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return num;
	}

	private int D5836FB5(int int_4, string F0B5D70F, Chrome f336F52E_0, JSON_Settings C8319837, string string_1)
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int result = 0;
		try
		{
			List<string> list = C8319837.GetValueList("txtLinkStory");
			C8319837.GetValueBool("ckbInteract");
			C8319837.GetValue("typeReaction");
			C8319837.GetValueBool("ckbComment");
			List<string> e4B628A = C8319837.GetValueList("txtComment");
			Common.CloneList(e4B628A);
			for (int i = 0; i < list.Count; i++)
			{
				method_86(int_4, F0B5D70F + Language.GetValue("Đang") + $" {string_1} ({i + 1}/{list.Count})...");
				string text = list[i];
				f336F52E_0.GotoURL(text.Replace("https://www.facebook.com/", "https://m.facebook.com/"));
				int num = f336F52E_0.CheckExistElements(8.0, "[data-sigil=\"m-stories-tap-overlay\"]", "[href=\"/help/?ref=404\"]");
				if (num != 1)
				{
					continue;
				}
				f336F52E_0.Click(4, "[data-sigil=\"m-stories-tap-overlay\"]");
				text = f336F52E_0.GetURL();
				string text2 = CommonChrome.smethod_1(f336F52E_0);
				for (int j = 0; j < 300; j++)
				{
					if (f336F52E_0.CheckExistElement("[data-sigil=\"m-video-play-button playInlineVideo\"]", 3.0) == 1)
					{
						f336F52E_0.Click(4, "[data-sigil=\"m-video-play-button playInlineVideo\"]");
					}
					if (f336F52E_0.GetURL() != text || text2 != CommonChrome.smethod_1(f336F52E_0))
					{
						break;
					}
					f336F52E_0.DelayTime(1.0);
				}
			}
			f336F52E_0.GotoURL("https://m.facebook.com/");
		}
		catch
		{
		}
		return result;
	}

	private int method_53(int A7BE41BD, string C19BC287, Chrome A63F2D9B, JSON_Settings D1BF1C86, string BFA34135)
	{
		int result = 0;
		string text = method_93(A7BE41BD, "cUid");
		string text2 = method_93(A7BE41BD, "cEmail");
		string text3 = "#";
		try
		{
			string aD82AD = D1BF1C86.GetValue("txtPathAnh");
			List<string> list = Common.GetFiles(aD82AD);
			A63F2D9B.GotoURL("https://m.facebook.com/");
			A63F2D9B.DelayRandom(2, 3);
			text3 = A63F2D9B.ExecuteScript("var link='#';var x=document.querySelector('#m-stories-owner-bucket');if(x.hasAttribute('data-href')) link=x.getAttribute('data-href'); link=link.split('?')[0]; return link").ToString();
			if ((text3 == "#" || text3 == "") && A63F2D9B.CheckExistElement("#m-stories-production-input") == 1)
			{
				A63F2D9B.SendKeys(1, "m-stories-production-input", list[Base.rd.Next(list.Count)], bool_6: false);
				A63F2D9B.DelayTime(3.0);
				A63F2D9B.Click(4, "[data-sigil=\"touchable m-stories-production-share-button\"]");
				A63F2D9B.DelayTime(3.0);
				for (int i = 0; i < 10; i++)
				{
					text3 = A63F2D9B.ExecuteScript("var link='#';var x=document.querySelector('#m-stories-owner-bucket');if(x.hasAttribute('data-href')) link=x.getAttribute('data-href'); link=link.split('?')[0]; return link").ToString();
					if (text3 != "" && text3 != "#")
					{
						break;
					}
					A63F2D9B.DelayTime(3.0);
					A63F2D9B.Refresh();
				}
				if (text3 != "" && text3 != "#")
				{
					A63F2D9B.GotoURL("https://m.facebook.com/stories/settings/");
					if (A63F2D9B.CheckExistElement("[value=\"public\"]", 5.0) == 1)
					{
						A63F2D9B.DelayTime(2.0);
						string text4 = A63F2D9B.GetURL();
						A63F2D9B.ExecuteScript("document.querySelector('[value=\"public\"]').click()");
						A63F2D9B.DelayTime(2.0);
						A63F2D9B.ExecuteScript("document.querySelector('[data-sigil=\"touchable m-stories-privacy-selector-change-confirm\"]').click()");
						A63F2D9B.DelayTime(2.0);
						A63F2D9B.ExecuteScript("document.querySelector('[data-sigil=\"m-stories-settings-back-button\"]').click()");
						for (int j = 0; j < 10; j++)
						{
							if (!(A63F2D9B.GetURL() != text4))
							{
								A63F2D9B.DelayTime(1.0);
								continue;
							}
							A63F2D9B.DelayTime(3.0);
							break;
						}
					}
				}
			}
			text3 = ((text3 != "#") ? ("https://m.facebook.com" + text3) : "");
			File.AppendAllText("LinkStory.txt", text + "|" + text2 + "|" + text3 + "\r\n");
		}
		catch
		{
		}
		return result;
	}

	public int method_54(int FE1F7494, string string_1, Chrome FC875A20, JSON_Settings F6AB578B, string string_2)
	{
		int minValue = F6AB578B.GetValueInt("nudSoLuongFrom");
		int num = F6AB578B.GetValueInt("nudSoLuongTo");
		int int_ = F6AB578B.GetValueInt("nudDelayFrom");
		int int_2 = F6AB578B.GetValueInt("nudDelayTo");
		bool flag = F6AB578B.GetValueBool("ckbChiKetBanTenCoDau");
		bool flag2 = F6AB578B.GetValueBool("ckbOnlyAddFriendWithMutualFriends");
		int num2 = F6AB578B.GetValueInt("nudTimesWarning", 5);
		bool flag3 = F6AB578B.GetValueBool("ckbAddFriendApi");
		string text = Common.GetText("XacNhanKetBan");
		method_93(FE1F7494, "cUid");
		method_93(FE1F7494, "cPassword");
		method_93(FE1F7494, "cFa2");
		int num3 = 0;
		int num4 = 0;
		try
		{
			int num5 = Base.rd.Next(minValue, num + 1);
			if (flag3)
			{
				method_86(FE1F7494, string_1 + Language.GetValue("Đang") + " " + string_2 + ": Get uid...");
				List<string> list = new List<string>();
				if (!FC875A20.GetURL().StartsWith("https://mbasic.facebook.com"))
				{
					FC875A20.GotoURL("https://mbasic.facebook.com/");
				}
				string text2 = "https://mbasic.facebook.com/friends/center/requests/all";
				do
				{
					string input = FC875A20.RequestGetHelper(text2);
					MatchCollection matchCollection = Regex.Matches(input, "friends/hovercard/mbasic/\\?uid=(\\d+)");
					foreach (Match item in matchCollection)
					{
						list.Add(item.Groups[1].Value);
					}
					method_86(FE1F7494, string_1 + Language.GetValue("Đang") + $" {string_2}: Get uid({list.Count})...");
					if (list.Count >= num5)
					{
						break;
					}
					text2 = Regex.Match(input, "href=\"(/friends/center/requests/all.*?)\"").Groups[1].Value;
					text2 = text2.Replace("&amp;", "&");
					if (text2 != "")
					{
						text2 = "https://mbasic.facebook.com" + text2;
					}
				}
				while (text2 != "");
				method_86(FE1F7494, string_1 + Language.GetValue("Đang") + " " + string_2 + ": Add friend...");
				for (int i = 0; i < list.Count; i++)
				{
					string newValue = list[i];
					if (!FC875A20.GetURL().StartsWith("https://www.facebook.com"))
					{
						FC875A20.GotoURL("https://www.facebook.com/");
					}
					FC875A20.ExecuteScript(text.Replace("{uid}", newValue)).ToString();
					num4++;
					method_86(FE1F7494, string_1 + Language.GetValue("Đang") + $" {string_2} ({num4}/{num5})...");
					if (num4 < num5)
					{
						if (!FC875A20.CheckIsLive())
						{
							D689A787(FE1F7494, string_1 + Language.GetValue("Đang") + $" {string_2} ({num4}/{num5}), đợi {{time}}s...", int_, int_2);
							continue;
						}
						return -2;
					}
					break;
				}
			}
			else
			{
				while (true)
				{
					if (FC875A20.GotoURL("https://m.facebook.com/friends/center/requests/all") != -2)
					{
						FC875A20.DelayRandom(2, 3);
						int num6 = method_51(FC875A20);
						if (num6 == 1)
						{
							continue;
						}
						if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
						{
							if (num5 == 0)
							{
								break;
							}
							int num7 = 0;
							int num8 = -1;
							while (true)
							{
								num8++;
								if (num8 % 10 == 0)
								{
									num6 = method_51(FC875A20);
									if (num6 == 1)
									{
										break;
									}
									if (new List<int> { -3, -2, -1, 2 }.Contains(num6))
									{
										return -1;
									}
								}
								if (FC875A20.CheckExistElement($"[data-sigil*=\"m-optimistic-response-root\"]|{num8}") == 0)
								{
									if (num8 != 0 && num7 < 2)
									{
										num7++;
										if (FC875A20.GotoURL("https://m.facebook.com/friends/center/requests/all") != -2)
										{
											FC875A20.DelayRandom(2, 3);
											num8 = -1;
											continue;
										}
										return -2;
									}
									goto end_IL_05f3;
								}
								num3 = (CommonChrome.smethod_33(FC875A20, 0) ? (num3 + 1) : 0);
								if (num3 >= num2)
								{
									goto end_IL_05f3;
								}
								if (FC875A20.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('button[data-sigil$=\"confirm-request\"]')[" + num8 + "]") == 1)
								{
									FC875A20.DelayTime(1.0);
								}
								bool flag4 = true;
								if (flag)
								{
									string text3 = FC875A20.ExecuteScript("return document.querySelectorAll('[data-sigil*=\"m-optimistic-response-root\"] h3,[data-sigil*=\"m-optimistic-response-root\"] h1')[" + num8 + "].innerText").ToString();
									if (!Common.smethod_62(text3))
									{
										flag4 = false;
									}
								}
								if (flag4 && flag2)
								{
									string text4 = FC875A20.ExecuteScript("return document.querySelectorAll('[data-sigil=\"m-add-friend-source-replaceable\"]')[" + num8 + "].innerText").ToString();
									flag4 = Common.IsContainNumber(text4);
								}
								if (flag4)
								{
									num7 = 0;
									FC875A20.Click($"[data-sigil$=\"confirm-request\"]|{num8}");
									num4++;
									method_86(FE1F7494, string_1 + Language.GetValue("Đang") + $" {string_2} ({num4}/{num5})...");
									if (num4 >= num5)
									{
										goto end_IL_05f3;
									}
									if (FC875A20.CheckIsLive())
									{
										return -2;
									}
									D689A787(FE1F7494, string_1 + Language.GetValue("Đang") + $" {string_2} ({num4}/{num5}), đợi {{time}}s...", int_, int_2);
								}
							}
							continue;
						}
						return -1;
					}
					return -2;
					continue;
					end_IL_05f3:
					break;
				}
			}
		}
		catch
		{
			num4 = -1;
		}
		return num4;
	}

	public int C485CA0C(int A4A1199A, string F2A659AC, Chrome f336F52E_0, int int_4, int int_5, int FC926D94, int A8062433, string AE05C486 = "", bool bool_5 = false, bool bool_6 = false)
	{
		method_93(A4A1199A, "cUid");
		method_93(A4A1199A, "cPassword");
		method_93(A4A1199A, "cFa2");
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = f336F52E_0.chromeDriver.Manage().Window.Size.Width;
		int num6 = f336F52E_0.chromeDriver.Manage().Window.Size.Height;
		try
		{
			int num7 = Base.rd.Next(int_4, int_5 + 1);
			while (true)
			{
				IL_0354:
				if (f336F52E_0.GotoURL("https://www.facebook.com/friends/requests") != -2)
				{
					f336F52E_0.chromeDriver.Manage().Window.Size = new Size(500, 700);
					f336F52E_0.DelayRandom(3, 5);
					f336F52E_0.CheckLoginFacebook();
					int num8 = method_51(f336F52E_0);
					if (num8 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num8))
					{
						if (num7 <= 0)
						{
							break;
						}
						while (num < num7)
						{
							num8 = method_51(f336F52E_0);
							if (num8 != 1)
							{
								if (!new List<int> { -3, -2, -1, 2 }.Contains(num8))
								{
									int num9 = f336F52E_0.CheckExistElements(5.0, "[role=\"navigation\"] [role=\"grid\"] > div:nth-child(2) div [role=\"button\"]:nth-child(1) [dir=\"auto\"]", "[role=\"navigation\"] [role=\"grid\"] > div:nth-child(3) div [role=\"button\"]:nth-child(1) [dir=\"auto\"]");
									if (num9 == 0)
									{
										break;
									}
									if (f336F52E_0.ScrollSmooth("document.querySelectorAll('[role=\"navigation\"] [role=\"grid\"] > div:nth-child(" + (num9 + 1) + ") div [role=\"button\"]:nth-child(1) [dir=\"auto\"]')[0]") == 1)
									{
										f336F52E_0.DelayTime(1.0);
										bool flag = true;
										if (bool_5)
										{
											string text = f336F52E_0.ExecuteScript("return document.querySelectorAll('[role=\"navigation\"] [role=\"gridcell\"]>span')[0].innerText").ToString();
											if (!Common.smethod_62(text))
											{
												flag = false;
											}
										}
										if (flag && bool_6)
										{
											string text2 = f336F52E_0.ExecuteScript("return document.querySelectorAll('[role=\"navigation\"] [role=\"row\"] [role=\"link\"] [dir=\"auto\"] [role=\"grid\"]')[0].innerText").ToString();
											flag = ((!(text2 == "")) ? true : false);
										}
										if (flag)
										{
											f336F52E_0.Click(4, "[role=\"navigation\"] [role=\"grid\"] > div:nth-child(" + (num9 + 1) + ") div [role=\"button\"]:nth-child(1) [dir=\"auto\"]");
											method_57();
											if (CommonChrome.smethod_33(f336F52E_0))
											{
												num3++;
												if (num3 >= num4)
												{
													break;
												}
											}
											else
											{
												num3 = 0;
											}
											num++;
											if (AE05C486 == "")
											{
												method_86(A4A1199A, F2A659AC + Language.GetValue("Đang xác nhận kết bạn") + $" ({num}/{num7})...");
											}
											else
											{
												method_86(A4A1199A, F2A659AC + Language.GetValue("Đang") + $" {AE05C486} ({num}/{num7})...");
											}
											if (num >= num7)
											{
												break;
											}
											if (f336F52E_0.CheckIsLive())
											{
												return -2;
											}
											FC926D94 = ((FC926D94 > 2) ? (FC926D94 - 2) : 0);
											A8062433 = ((A8062433 > 2) ? (A8062433 - 2) : 0);
											f336F52E_0.DelayTime(Base.rd.Next(FC926D94, A8062433 + 1));
										}
										else
										{
											f336F52E_0.ExecuteScript("document.querySelectorAll('[role=\"navigation\"] [role=\"grid\"] > div:nth-child(3) div')[0].remove()");
										}
									}
									else
									{
										num2++;
										if (num2 == 5)
										{
											break;
										}
									}
									continue;
								}
								return -1;
							}
							goto IL_0354;
						}
						break;
					}
					return -1;
				}
				return -2;
			}
		}
		catch
		{
			num = -1;
		}
		f336F52E_0.chromeDriver.Manage().Window.Size = new Size(num5, num6);
		return num;
	}

	public int method_55(int int_4, string string_1, Chrome f336F52E_0, List<string> D312A793, int F1A19695, int int_5, int int_6, int int_7, string string_2 = "")
	{
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num = 0;
		int num2 = -1;
		int num3 = 0;
		int num4 = 0;
		try
		{
			D312A793 = Common.RemoveEmptyItems(D312A793);
			string text = D312A793[Base.rd.Next(0, D312A793.Count)];
			int num5 = Base.rd.Next(F1A19695, int_5 + 1);
			while (true)
			{
				IL_0068:
				if (CommonChrome.smethod_8(f336F52E_0, text, SettingsTool.GetSettings("configGeneral").GetValueInt("tocDoGoVanBan")) != -2)
				{
					int num6 = method_51(f336F52E_0);
					if (num6 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
					{
						if (f336F52E_0.CheckExistElement("#BrowseResultsContainer", 5.0) != 1)
						{
							break;
						}
						CommonChrome.ScrollRandom(f336F52E_0);
						bool flag = false;
						while (num < num5)
						{
							num6 = method_51(f336F52E_0);
							if (num6 == 1)
							{
								goto IL_0068;
							}
							if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
							{
								num2++;
								try
								{
									flag = Convert.ToBoolean(f336F52E_0.ExecuteScript("return (document.querySelectorAll('[data-nt-switch-case=\\'{\\\"v\":\\\"CAN_REQUEST\\\"}\\']')[" + num2 + "].getAttribute('style')==null)+''"));
								}
								catch
								{
									flag = false;
								}
								if (flag)
								{
									num4 = 0;
									if (Base.rd.Next(1, 100) % 2 == 0)
									{
										f336F52E_0.ScrollSmooth("document.querySelectorAll('[data-nt-switch-case=\\'{\\\"v\\\":\\\"CAN_REQUEST\\\"}\\']')[" + num2 + "]");
										method_57();
										f336F52E_0.Click(4, "[data-nt-switch-case='{\\\"v\\\":\\\"CAN_REQUEST\\\"}']>button", num2);
										method_57();
										num3 = (CommonChrome.smethod_33(f336F52E_0) ? (num3 + 1) : 0);
										if (num3 >= 5)
										{
											break;
										}
										num++;
										if (string_2 == "")
										{
											method_86(int_4, string_1 + Language.GetValue("Đang kết bạn theo từ khóa") + $" ({num}/{num5})...");
										}
										else
										{
											method_86(int_4, string_1 + Language.GetValue("Đang") + $" {string_2}({num}/{num5})...");
										}
										if (f336F52E_0.CheckIsLive())
										{
											return -2;
										}
										int_6 = ((int_6 > 2) ? (int_6 - 2) : 0);
										int_7 = ((int_7 > 2) ? (int_7 - 2) : 0);
										f336F52E_0.DelayTime(Base.rd.Next(int_6, int_7 + 1));
									}
								}
								else
								{
									num4++;
									if (num4 == 50)
									{
										break;
									}
								}
								continue;
							}
							return -1;
						}
						break;
					}
					return -1;
				}
				return -2;
			}
		}
		catch
		{
			num = -1;
		}
		return num;
	}

	public int B4A2F689(ref string string_1, int int_4, string D00E4194, Chrome A739BD18, JSON_Settings C80C6D32, string string_2)
	{
		int minValue = C80C6D32.GetValueInt("nudSoLuongFrom");
		int num = C80C6D32.GetValueInt("nudSoLuongTo");
		int int_5 = C80C6D32.GetValueInt("nudDelayFrom");
		int cF = C80C6D32.GetValueInt("nudDelayTo");
		bool flag = C80C6D32.GetValueBool("ckbChiKetBanTenCoDau");
		bool flag2 = C80C6D32.GetValueBool("ckbOnlyAddFriendWithMutualFriends");
		int num2 = C80C6D32.GetValueInt("nudTimesWarning", 5);
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int num3 = 0;
		int num4 = 0;
		try
		{
			int num5 = Base.rd.Next(minValue, num + 1);
			while (true)
			{
				A739BD18.GotoURL("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
				A739BD18.DelayTime(2.0);
				int num6 = method_51(A739BD18);
				if (num6 == 1)
				{
					continue;
				}
				if (!new List<int> { -3, -2, -1, 2 }.Contains(num6))
				{
					if (num5 == 0)
					{
						break;
					}
					string_1 = "No";
					int num7 = -1;
					while (true)
					{
						num7++;
						if (num7 % 10 == 0)
						{
							num6 = method_51(A739BD18);
							if (num6 == 1)
							{
								break;
							}
							if (new List<int> { -3, -2, -1, 2 }.Contains(num6))
							{
								return -1;
							}
						}
						if (A739BD18.CheckExistElement($"[data-sigil=\"undoable-action\"]|{num7}") == 0)
						{
							goto end_IL_02b8;
						}
						string_1 = "Yes";
						num3 = (CommonChrome.smethod_33(A739BD18, 0) ? (num3 + 1) : 0);
						if (num3 >= num2)
						{
							goto end_IL_02b8;
						}
						if (A739BD18.ScrollSmoothIfNotExistOnScreen("document.querySelectorAll('[data-sigil=\"undoable-action\"] [data-sigil$=\"m-add-friend\"]>button')[" + num7 + "]") == 1)
						{
							A739BD18.DelayTime(1.0);
						}
						bool flag3 = true;
						if (flag)
						{
							string text = A739BD18.ExecuteScript("return document.querySelectorAll('[data-sigil=\"undoable-action\"] h3>a,[data-sigil=\"undoable-action\"] h1>a')[" + num7 + "].innerText").ToString();
							if (!Common.smethod_62(text))
							{
								flag3 = false;
							}
						}
						if (flag3 && flag2)
						{
							string text2 = A739BD18.ExecuteScript("return document.querySelectorAll('[data-sigil=\"m-add-friend-source-replaceable\"]')[" + num7 + "].innerText").ToString();
							flag3 = Common.IsContainNumber(text2);
						}
						if (flag3)
						{
							A739BD18.Click($"[data-sigil$=\"m-add-friend\"]|{num7}");
							num4++;
							method_86(int_4, D00E4194 + Language.GetValue("Đang") + $" {string_2} ({num4}/{num5})...");
							if (num4 >= num5)
							{
								goto end_IL_02b8;
							}
							if (A739BD18.CheckIsLive())
							{
								return -2;
							}
							A739BD18.DelayRandom(int_5, cF);
						}
					}
					continue;
				}
				return -1;
				continue;
				end_IL_02b8:
				break;
			}
		}
		catch
		{
			num4 = -1;
		}
		return num4;
	}

	public int A008D48D(int int_4, string string_1, Chrome f336F52E_0, JSON_Settings gclass8_1, string E41B971E)
	{
		int minValue = gclass8_1.GetValueInt("nudSoLuongFrom");
		int num = gclass8_1.GetValueInt("nudSoLuongTo");
		int int_5 = gclass8_1.GetValueInt("nudDelayFrom");
		int cF = gclass8_1.GetValueInt("nudDelayTo");
		string string_2 = gclass8_1.GetValue("txtLink");
		string text = gclass8_1.GetValue("txtCode");
		method_93(int_4, "cUid");
		method_93(int_4, "cPassword");
		method_93(int_4, "cFa2");
		int result = 0;
		try
		{
			int num2 = Base.rd.Next(minValue, num + 1);
			int num3;
			do
			{
				f336F52E_0.GotoURL(string_2);
				f336F52E_0.DelayTime(2.0);
				num3 = method_51(f336F52E_0);
			}
			while (num3 == 1);
			if (new List<int> { -3, -2, -1, 2 }.Contains(num3))
			{
				return -1;
			}
			if (num2 != 0)
			{
				int num4 = Base.rd.Next(minValue, num + 1);
				for (int i = 0; i < num4; i++)
				{
					f336F52E_0.ScrollSmooth(1000);
					f336F52E_0.DelayRandom(int_5, cF);
				}
				f336F52E_0.ExecuteScript(text.Replace("''", "'"));
				f336F52E_0.DelayTime(3.0);
			}
		}
		catch
		{
			result = -1;
		}
		return result;
	}

	public List<string> method_56(string string_1, string F7A31A08, string string_2, string FFAF64B9, int int_4)
	{
		List<string> list = new List<string>();
		try
		{
			string value = Regex.Match(F7A31A08, "c_user=(\\d+)").Groups[1].Value;
			RequestXNet fB87CFA = new RequestXNet(F7A31A08, string_2, FFAF64B9, int_4);
			fB87CFA.httpRequest.AddHeader("Authorization", "OAuth " + string_1);
			string json = fB87CFA.RequestGet("https://graph.facebook.com/?ids=" + value + "&pretty=0&fields=friends.limit(5000){id}");
			JObject jObject = JObject.Parse(json);
			JToken jToken = jObject[value]["friends"];
			if (jToken["data"].Count() > 0)
			{
				for (int i = 0; i < jToken["data"].Count(); i++)
				{
					string item = jToken["data"][i]["id"].ToString();
					list.Add(item);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public List<string> B483A38F(List<string> list_4)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < list_4.Count; i++)
			{
				list.Add(list_4[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	private void method_57(int int_4 = 0)
	{
		Common.Sleep(Base.rd.Next(int_4 + 1, int_4 + 3));
	}

	private void method_58(string string_1)
	{
		plTrangThai.Invoke((MethodInvoker)delegate
		{
			if (!plTrangThai.Visible)
			{
				plTrangThai.Visible = true;
			}
		});
		AE250EB9.Invoke((MethodInvoker)delegate
		{
			AE250EB9.Text = string_1;
		});
	}

	private void E8AFC193()
	{
		plTrangThai.Invoke((MethodInvoker)delegate
		{
			if (plTrangThai.Visible)
			{
				plTrangThai.Visible = false;
			}
		});
	}

	private void method_59(string C78E001D)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (C78E001D == "start")
				{
					plQuanLyThuMuc.Enabled = false;
					DatagridviewHelper.smethod_0(D030FA3A, bool_0: false);
				}
				else if (C78E001D == "stop")
				{
					plQuanLyThuMuc.Enabled = true;
					DatagridviewHelper.smethod_0(D030FA3A, bool_0: true);
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void D030FA3A_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			AC34650F("ToggleCheck");
		}
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		DDA41599(null, null);
	}

	private void D31C4BA0(object sender, EventArgs e)
	{
		int selectedIndex = D68F8BB7.SelectedIndex;
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có thực sự muốn xóa thư mục [{0}] không?"), D68F8BB7.Text)) == DialogResult.Yes)
		{
			if (CommonSQL.smethod_3(D68F8BB7.SelectedValue.ToString()))
			{
				MessageBoxHelper.Show(string.Format(Language.GetValue("Xoá thành công thư mục [{0}] !"), D68F8BB7.Text));
				method_2();
				D68F8BB7.SelectedIndex = selectedIndex - 1;
			}
			else
			{
				MessageBoxHelper.Show(string.Format(Language.GetValue("Không thể xóa thư mục [{0}] !"), D68F8BB7.Text), 2);
			}
		}
	}

	private void D68F8BB7_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1 || D68F8BB7.SelectedValue == null || !StringHelper.CheckStringIsNumber(D68F8BB7.SelectedValue.ToString()) || (D68F8BB7.SelectedValue.ToString() != "999999" && int_0 == D68F8BB7.SelectedIndex))
		{
			return;
		}
		string text = D68F8BB7.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				method_3(method_6());
			}
			else
			{
				Common.ShowForm(new fChonThuMuc());
				if (!fChonThuMuc.bool_1 || fChonThuMuc.DE35F309 == null || fChonThuMuc.DE35F309.Count == 0)
				{
					bool_1 = false;
					D68F8BB7.SelectedIndex = ((int_0 == -1) ? 1 : int_0);
					bool_1 = true;
				}
				else
				{
					method_3(fChonThuMuc.DE35F309);
				}
			}
		}
		else
		{
			method_3();
		}
		int_0 = D68F8BB7.SelectedIndex;
		if (D68F8BB7.SelectedValue != null)
		{
			string text3 = D68F8BB7.SelectedValue.ToString();
			if (text3 == "-1" || text3 == "999999")
			{
				C9344F86.BackColor = Color.Gray;
				C9344F86.Enabled = false;
				btnEditFile.BackColor = Color.Gray;
				btnEditFile.Enabled = false;
			}
			else
			{
				C9344F86.BackColor = Color.White;
				C9344F86.Enabled = true;
				btnEditFile.BackColor = Color.White;
				btnEditFile.Enabled = true;
			}
		}
	}

	private void D4926BAB(object sender, EventArgs e)
	{
		method_8("cEmail|cPassMail");
	}

	private void DB14BA87(object sender, EventArgs e)
	{
		method_8("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void method_60()
	{
		try
		{
			lblCountTotal.Text = D030FA3A.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	public void method_61(int AC848E03 = -1)
	{
		try
		{
			if (AC848E03 == -1)
			{
				AC848E03 = 0;
				for (int i = 0; i < D030FA3A.Rows.Count; i++)
				{
					if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
					{
						AC848E03++;
					}
				}
			}
			lblCountSelect.Text = AC848E03.ToString();
		}
		catch (Exception)
		{
		}
	}

	private void method_62(int int_4, bool bool_5 = false)
	{
		int C1266AAB = 0;
		int BA06A5AC = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		SettingsTool.GetSettings("configGeneral").GetValue("token");
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_59("start");
			int num = 0;
			while (num < D030FA3A.Rows.Count && !bool_0)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (C1266AAB < BA06A5AC)
					{
						Interlocked.Increment(ref C1266AAB);
						int int_5 = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_5, Language.GetValue("Đang kiểm tra..."));
							switch (int_4)
							{
							case 0:
								method_63(int_5);
								break;
							case 1:
								method_64(int_5);
								break;
							case 2:
								D23C2D97(int_5);
								break;
							case 3:
								method_65(int_5);
								break;
							case 4:
								E6880C9A(int_5);
								break;
							case 5:
								AC879403(int_5, bool_5);
								break;
							case 6:
								F93F490D(int_5, bool_5);
								break;
							case 7:
								E184843A(int_5);
								break;
							case 8:
								method_25(int_5);
								break;
							}
							Interlocked.Decrement(ref C1266AAB);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (C1266AAB > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.Sleep(1.0);
			}
			method_59("stop");
		}).Start();
	}

	private void AC879403(int int_4, bool bool_5)
	{
		try
		{
			string text = method_93(int_4, "cId");
			string text2 = method_93(int_4, "cUid");
			string text3 = "";
			int num = 0;
			if (bool_5)
			{
				text3 = method_93(int_4, "cProxy");
				num = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			string text4 = "";
			string text5 = CheckInfoAccountv2.CheckInfoUid_Old(text2, text3, num);
			if (text5.StartsWith("0|"))
			{
				if (CheckInfoAccountv2.CheckLiveWall(text2).StartsWith("0|"))
				{
					method_86(int_4, Language.GetValue("Tài khoản Die!"));
					method_87(int_4, "Die");
				}
				else
				{
					method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
				}
			}
			else if (text5.StartsWith("1|"))
			{
				string[] array = text5.Split('|');
				string text6 = array[1];
				string text7 = array[2];
				string text8 = array[3];
				CommonSQL.B52E91B6(text, "name|friends|dateCreateAcc", text6 + "|" + text7 + "|" + text8);
				B034598F(int_4, "cName", text6);
				B034598F(int_4, "cFriend", text7);
				B034598F(int_4, "cDateCreateAcc", text8);
				method_87(int_4, "Live");
				text4 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				method_86(int_4, text4);
			}
			else
			{
				method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void E6880C9A(int F4B61039)
	{
		try
		{
			string text = "";
			string text2 = "";
			text = D030FA3A.Rows[F4B61039].Cells["cEmail"].Value.ToString();
			text2 = D030FA3A.Rows[F4B61039].Cells["cPassMail"].Value.ToString();
			if (text == "" || text2 == "")
			{
				method_86(F4B61039, Language.GetValue("Không tìm thấy mail!"));
			}
			else if (Imap.CheckConnectImap(text, text2))
			{
				method_86(F4B61039, Language.GetValue("Success!"));
				method_96(F4B61039, 2);
			}
			else
			{
				method_86(F4B61039, Language.GetValue("Fail!"));
				method_96(F4B61039, 1);
			}
		}
		catch (Exception)
		{
			method_86(F4B61039, Language.GetValue("Lỗi!"));
		}
	}

	private void E184843A(int CCAF5298)
	{
		try
		{
			string text = method_93(CCAF5298, "cName");
			string text2 = "";
			text2 = ((text.Trim() == "") ? Language.GetValue("Không tìm thấy tên!") : ((!Common.smethod_62(text)) ? Language.GetValue("No") : Language.GetValue("Yes")));
			method_86(CCAF5298, text2);
		}
		catch
		{
			method_86(CCAF5298, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_63(int int_4)
	{
		try
		{
			method_93(int_4, "cId");
			string text = method_93(int_4, "cUid");
			string text2 = "";
			string text3 = "";
			string text4 = CheckInfoAccountv2.CheckLiveWall(text);
			if (text4.StartsWith("0|"))
			{
				text2 = "Die";
				text3 = "Wall die";
			}
			else if (text4.StartsWith("1|"))
			{
				text2 = "Live";
				text3 = "Wall live";
			}
			else
			{
				text3 = Language.GetValue("Không check được!");
			}
			method_86(int_4, text3);
			if (text2 != "")
			{
				method_87(int_4, text2);
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_64(int int_4)
	{
		try
		{
			string text = "";
			method_93(int_4, "cId");
			string f4B9183E = method_93(int_4, "cCookies");
			string text2 = method_93(int_4, "cToken");
			if (text2.Trim() == "")
			{
				method_86(int_4, Language.GetValue("Token trô\u0301ng!"));
				return;
			}
			string string_ = method_93(int_4, "cUseragent").Trim();
			string text3 = "";
			int f4A95EB = 0;
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
			{
				text3 = method_93(int_4, "cProxy");
				f4A95EB = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			string text4 = "";
			if (!CheckInfoAccountv2.CheckToken(f4B9183E, text2, string_, text3, f4A95EB))
			{
				text4 = "Token die";
			}
			else
			{
				text = "Live";
				text4 = "Token live";
			}
			method_86(int_4, text4);
			if (text != "")
			{
				method_87(int_4, text);
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void D23C2D97(int int_4)
	{
		try
		{
			string text = "";
			method_93(int_4, "cId");
			string text2 = method_93(int_4, "cCookies");
			if (text2.Trim() == "")
			{
				method_86(int_4, Language.GetValue("Cookie trô\u0301ng!"));
				return;
			}
			string text3 = method_93(int_4, "cUseragent").Trim();
			string text4 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
			{
				text4 = method_93(int_4, "cProxy");
				num = (text4.EndsWith("*1") ? 1 : 0);
				if (text4.EndsWith("*0") || text4.EndsWith("*1"))
				{
					text4 = text4.Substring(0, text4.Length - 2);
				}
			}
			string text5 = "";
			if (!CheckInfoAccountv2.CheckLiveCookie(text2, text3, text4, num).StartsWith("1|"))
			{
				text5 = "Cookie die";
			}
			else
			{
				text = "Live";
				text5 = "Cookie live";
			}
			method_86(int_4, text5);
			if (text != "")
			{
				method_87(int_4, text);
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_65(int C5B5AB0F)
	{
		D030FA3A.Rows[C5B5AB0F].Cells["cId"].Value.ToString();
		string text = method_93(C5B5AB0F, "cCookies");
		if (text.Trim() == "")
		{
			method_86(C5B5AB0F, Language.GetValue("Cookie trô\u0301ng!"));
			return;
		}
		method_93(C5B5AB0F, "cUseragent").Trim();
		string text2 = "";
		int d13A5E0F = 0;
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
		{
			text2 = method_93(C5B5AB0F, "cProxy");
			d13A5E0F = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		method_86(C5B5AB0F, Language.GetValue("Checking..."));
		AE1FE684(C5B5AB0F, "", text, text2, d13A5E0F);
	}

	private void BA0DD9BE(object sender, EventArgs e)
	{
		method_62(0);
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?") == DialogResult.Yes)
		{
			method_62(1);
		}
	}

	private void F2357DAD(object sender, EventArgs e)
	{
		method_62(3);
	}

	private void mailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_8("cEmail");
	}

	private void F32CD491(object sender, EventArgs e)
	{
		try
		{
			if (AE25A29C.SelectedIndex == -1)
			{
				MessageBoxHelper.Show("Vui lòng chọn kiểu tìm kiếm!", 3);
				return;
			}
			string columnName = AE25A29C.SelectedValue.ToString();
			string text = AA21FF22.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lòng nhập nội dung tìm kiếm!", 3);
				return;
			}
			List<int> list = new List<int>();
			text = Common.ConvertToUnSign(text.ToLower());
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				string text2 = D030FA3A.Rows[i].Cells[columnName].Value.ToString();
				text2 = Common.ConvertToUnSign(text2.ToLower());
				text = Common.ConvertToUnSign(text.ToLower());
				if (text2.Contains(text))
				{
					list.Add(i);
				}
			}
			int index = 0;
			int num = -1;
			try
			{
				num = D030FA3A.CurrentRow.Index;
			}
			catch
			{
				num = -1;
			}
			if (list.Count <= 0)
			{
				return;
			}
			if (num >= list[list.Count - 1])
			{
				index = 0;
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (num < list[j])
					{
						index = j;
						break;
					}
				}
			}
			int index2 = list[index];
			D030FA3A.CurrentCell = D030FA3A.Rows[index2].Cells[columnName];
			D030FA3A.ClearSelection();
			D030FA3A.Rows[index2].Selected = true;
		}
		catch (Exception)
		{
		}
	}

	private void EDBEA69E_Click(object sender, EventArgs e)
	{
		if (Base.smethod_3())
		{
			method_8("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
		}
	}

	private void B0A4EF35()
	{
		for (int i = 0; i < D030FA3A.RowCount; i++)
		{
			B034598F(i, "cSTT", i + 1);
		}
	}

	private void fAToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Base.smethod_3())
		{
			method_8("cFa2");
		}
	}

	private void EBAB703A(object sender, EventArgs e)
	{
		method_62(6);
	}

	private void F93F490D(int int_4, bool B883BC88)
	{
		try
		{
			string text = "";
			int f01976B = 0;
			if (B883BC88)
			{
				text = method_93(int_4, "cProxy");
				f01976B = (text.EndsWith("*1") ? 1 : 0);
				if (text.EndsWith("*0") || text.EndsWith("*1"))
				{
					text = text.Substring(0, text.Length - 2);
				}
			}
			string text2 = D030FA3A.Rows[int_4].Cells["cUid"].Value.ToString();
			switch (CheckInfoAccountv2.CheckAvatar(text2, text, f01976B))
			{
			case "2":
				method_86(int_4, Language.GetValue("Không check được!"));
				break;
			case "1":
				method_86(int_4, Language.GetValue("Đa\u0303 co\u0301 avatar!"));
				BC0C40BD(int_4, "cAvatar", "Yes", "avatar");
				break;
			case "0":
				method_86(int_4, Language.GetValue("Không co\u0301 avatar!"));
				BC0C40BD(int_4, "cAvatar", "No", "avatar");
				break;
			}
		}
		catch
		{
			method_86(int_4, "Lỗi!");
		}
	}

	private void method_66(object sender, EventArgs e)
	{
		int int_0 = 0;
		int CE2917A4 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_59("start");
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < CE2917A4)
					{
						Interlocked.Increment(ref int_0);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_, Language.GetValue("Đang kiểm tra..."));
							DBA980B2(int_);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_59("stop");
		}).Start();
	}

	private void DBA980B2(int int_4)
	{
		string text = D030FA3A.Rows[int_4].Cells["cCookies"].Value.ToString();
		D030FA3A.Rows[int_4].Cells["cId"].Value.ToString();
		string text2 = method_93(int_4, "cUseragent").Trim();
		string text3 = "";
		int num = 0;
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
		{
			text3 = method_93(int_4, "cProxy");
			num = (text3.EndsWith("*1") ? 1 : 0);
			if (text3.EndsWith("*0") || text3.EndsWith("*1"))
			{
				text3 = text3.Substring(0, text3.Length - 2);
			}
		}
		string text4 = "";
		if (text == "")
		{
			text4 = "Cookie trống!";
		}
		else
		{
			string text5 = CheckInfoAccountv2.CheckLiveCookie(text, text2, text3, num);
			if (text5.Split('|')[0] == "1")
			{
				text4 = ((!(text5.Split('|')[1] == "1")) ? (text4 + Language.GetValue("Chưa veri!")) : (text4 + Language.GetValue("Đa\u0303 veri!")));
			}
			else if (text5.Split('|')[0] == "0")
			{
				text4 += "Cookie Die!";
			}
			else if (text5.Split('|')[0] == "2")
			{
				text4 += Language.GetValue("Lô\u0303i khi check!");
			}
		}
		method_86(int_4, text4);
	}

	private void locTrungToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
				{
					string item = method_93(i, "cUid");
					if (list2.Contains(item))
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
			}
			if (list.Count == 0)
			{
				MessageBoxHelper.Show("Không có tài khoản trùng nhau!");
				return;
			}
			List<string> list3 = Common.CloneList(list);
			DataTable dataTable = CommonSQL.smethod_11(list3);
			dataTable.DefaultView.Sort = "uid ASC";
			dataTable = dataTable.DefaultView.ToTable();
			D030FA3A.Rows.Clear();
			method_7(dataTable);
		}
		catch (Exception)
		{
		}
	}

	private void F118D3BF(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), B1ABC129())) != DialogResult.Yes)
		{
			return;
		}
		int E5AEA61C = 0;
		int int_0 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (E5AEA61C < int_0)
					{
						Interlocked.Increment(ref E5AEA61C);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_, Language.GetValue("Đang xo\u0301a profile..."));
							method_67(int_);
							Interlocked.Decrement(ref E5AEA61C);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_67(int int_4)
	{
		try
		{
			string text = D030FA3A.Rows[int_4].Cells["cId"].Value.ToString();
			string text2 = D030FA3A.Rows[int_4].Cells["cUid"].Value.ToString();
			if (text2.Trim() == "")
			{
				method_86(int_4, Language.GetValue("Chưa tạo profile!"));
				return;
			}
			string path = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text2;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_86(int_4, Language.GetValue("Xóa profile thành công!"));
				B034598F(int_4, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(text, "profile", "No");
			}
			else
			{
				method_86(int_4, Language.GetValue("Chưa tạo profile!"));
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Xóa profile thất bại!"));
		}
	}

	private void EE05D28C(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		string C123AB3E = SettingsTool.GetPathProfile();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < D030FA3A.RowCount)
			{
				if (Convert.ToBoolean(method_93(num, "cChose")))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_2, "Check profile...");
							method_68(int_2, C123AB3E);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_68(int int_4, string string_1)
	{
		try
		{
			string text = method_93(int_4, "cId");
			string text2 = method_93(int_4, "cUid");
			string_1 = string_1 + "\\" + text2;
			if (Directory.Exists(string_1))
			{
				method_86(int_4, Language.GetValue("Đã có profile!"));
				B034598F(int_4, "cProfile", "Yes");
				CommonSQL.UpdateFieldToAccount(text, "profile", "Yes");
			}
			else
			{
				method_86(int_4, Language.GetValue("Chưa tạo profile!"));
				B034598F(int_4, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(text, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void FFB9D70A_Click(object sender, EventArgs e)
	{
		try
		{
			Common.ShowForm(new fClearProfile());
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString(), 3);
		}
	}

	private void pictureBox1_DoubleClick(object sender, EventArgs e)
	{
		Common.KillProcess("chrome");
	}

	private void AC8B928D_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
	}

	private void D50AB197(object sender, EventArgs e)
	{
		if (Base.smethod_3())
		{
			method_8("cUid|cPassword|cFa2");
		}
	}

	private void AABC4210(object sender, EventArgs e)
	{
		JSON_Settings gclass8_ = new JSON_Settings();
		Common.ShowForm(new fCauHinhChung(ref gclass8_));
		if (gclass8_.GetValueBool("isChangePathDatabase"))
		{
			method_2();
			int_0 = -1;
			D68F8BB7.SelectedIndex = -1;
			D68F8BB7.SelectedIndex = 0;
		}
	}

	private void AF3EB901(object sender, EventArgs e)
	{
		try
		{
			List<string> list = FF2742AE("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2|cUseragent|cProxy|cName|cGender|cFollow|cFriend|cGroup|cBirthday|cDateCreateAcc|cGhiChu|cLocation|cMailRecovery|cInteractEnd|cDating|cAds|cBM");
			if (list.Count <= 0)
			{
				MessageBoxHelper.Show("Vui lòng chọn danh sách tài khoản muốn copy thông tin!", 3);
			}
			else
			{
				Common.ShowForm(new fCopy(list));
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Error Copy");
		}
	}

	private void AF847F9F(object sender, EventArgs e)
	{
		method_8("cMa2Fa");
	}

	private void EC2D66B3_Click(object sender, EventArgs e)
	{
	}

	private void method_69(int int_4)
	{
		try
		{
			string text = method_93(int_4, "cId");
			string text2 = method_93(int_4, "cCookies");
			method_93(int_4, "cToken");
			string e2A4F89F = method_93(int_4, "cUseragent").Trim();
			string text3 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
			{
				text3 = method_93(int_4, "cProxy");
				num = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			string text4 = "";
			string text5 = "";
			if (text2 == "")
			{
				text4 = Language.GetValue("Cookie trô\u0301ng");
			}
			else
			{
				string text6 = CheckInfoAccountv2.GetInfoAccountFromUidUsingCookie(text2, e2A4F89F, text3, num);
				if (text6 == "-1")
				{
					text4 = "Cookie die";
				}
				else
				{
					string[] array = text6.Split('|');
					if (Convert.ToBoolean(array[0]))
					{
						text5 = "Live";
						CommonSQL.B52E91B6(text, "name|gender|birthday|friends|groups" + ((array[5] != "") ? "|email" : ""), array[1] + "|" + array[2] + "|" + array[3] + "|" + array[6] + "|" + array[7] + ((array[5] != "") ? ("|" + array[5]) : ""));
						B034598F(int_4, "cName", array[1]);
						B034598F(int_4, "cGender", array[2]);
						B034598F(int_4, "cBirthday", array[3]);
						if (array[5] != "")
						{
							B034598F(int_4, "cEmail", array[5]);
						}
						B034598F(int_4, "cFriend", array[6]);
						B034598F(int_4, "cGroup", array[7]);
						text4 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
					}
					else
					{
						text5 = "Die";
						text4 = Language.GetValue("Tài khoản die!");
					}
				}
			}
			method_86(int_4, text4);
			if (text5 != "")
			{
				method_87(int_4, text5);
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private bool C3B8512F(int int_4, string string_1)
	{
		try
		{
			string text = method_93(int_4, "cId");
			string a7AEAD9F = method_93(int_4, "cUid");
			string text2 = "";
			string text3 = CheckInfoAccountv2.BB09B49F(a7AEAD9F, string_1);
			if (text3 == "-1")
			{
				method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
				return false;
			}
			string[] array = text3.Split('|');
			if (Convert.ToBoolean(array[0]))
			{
				CommonSQL.B52E91B6(text, "name|gender", array[1] + "|" + array[2]);
				B034598F(int_4, "cName", array[1]);
				B034598F(int_4, "cGender", array[2]);
				if (array[6] != "")
				{
					B034598F(int_4, "cFriend", array[6]);
					CommonSQL.UpdateFieldToAccount(text, "friends", array[6]);
				}
				if (array[7] != "")
				{
					B034598F(int_4, "cGroup", array[7]);
					CommonSQL.UpdateFieldToAccount(text, "groups", array[7]);
				}
				method_87(int_4, "Live");
				text2 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
			}
			else
			{
				method_87(int_4, "Die");
				text2 = Language.GetValue("Tài khoản Die!");
			}
			method_86(int_4, text2);
		}
		catch
		{
			method_86(int_4, Language.GetValue("Không check đươ\u0323c!"));
		}
		return true;
	}

	private void A61EED02(Chrome B91E898B, int int_4)
	{
		try
		{
			B91E898B.SetFbLanguage("vi_VN");
			B91E898B.GotoURL("https://m.facebook.com/account_status");
			string text = B91E898B.ExecuteScript("return document.querySelector('[data-nt=\"NT:DECOR\"]').innerText.split('\\n').filter(e => e.includes('không thể'))[0]??''").ToString();
			if (text != "")
			{
				BC0C40BD(int_4, "cGhiChu", "(" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ") " + text, "ghiChu");
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_70(Chrome D7B0D393, int int_4, string string_1, int FFB46912)
	{
		try
		{
			string text = D7B0D393.GetUIDFromCookies();
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			string text14 = "";
			string text15 = "";
			string text16 = "";
			string text17 = "";
			string text18 = "";
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbName"))
			{
				text2 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGender"))
			{
				text6 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBirthday"))
			{
				text10 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbNgayTao"))
			{
				text14 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbEmail"))
			{
				text13 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFriend"))
			{
				text3 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGroup"))
			{
				text7 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPage"))
			{
				text4 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPagePro5"))
			{
				text5 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFollow"))
			{
				text11 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPhone"))
			{
				text15 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbHometown"))
			{
				text8 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbLocation"))
			{
				text9 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAvatar"))
			{
				text17 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDating"))
			{
				text12 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAds"))
			{
				text16 = "-";
			}
			if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBM"))
			{
				text18 = "-";
			}
			string text19 = "";
			if (text17 == "")
			{
				string text20 = CheckInfoAccountv2.CheckAvatar(text);
				if (text20 == "0")
				{
					text17 = "No";
				}
				else if (text20 == "1")
				{
					text17 = "Yes";
				}
				BC0C40BD(int_4, "cAvatar", text17, "avatar", bool_5: false);
			}
			if (text2 == "" || text3 == "" || text14 == "")
			{
				string text21 = CheckInfoAccountv2.CheckInfoUid_Old(text, string_1, FFB46912);
				if (text21.StartsWith("1|"))
				{
					string[] array = text21.Split('|');
					if (text2 == "")
					{
						text2 = array[1];
						BC0C40BD(int_4, "cName", text2, "name", bool_5: false);
					}
					if (text3 == "")
					{
						text3 = array[2];
						if (text3 == "0")
						{
							text3 = "";
						}
						BC0C40BD(int_4, "cFriend", text3, "friends", bool_5: false);
					}
					if (text14 == "")
					{
						text14 = array[3];
						BC0C40BD(int_4, "cDateCreateAcc", text14, "dateCreateAcc", bool_5: false);
					}
				}
			}
			if (text15 == "" || text10 == "" || text6 == "")
			{
				if (!D7B0D393.GetURL().StartsWith("https://mbasic.facebook.com/"))
				{
					D7B0D393.GotoURL("https://mbasic.facebook.com/");
				}
				if (text15 == "")
				{
					BC0C40BD(int_4, "cPhone", text15, "phone");
				}
				if (text10 == "" || text6 == "")
				{
					string text22 = D7B0D393.ExecuteScript(Common.Base64Decode("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21iYXNpYy5mYWNlYm9vay5jb20vcHJvZmlsZS9lZGl0L2luZm90YWIvc2VjdGlvbi9mb3Jtcy8/c2VjdGlvbj1iYXNpYy1pbmZvJyk7Cmh0bWwgPSB1bmVzY2FwZShodG1sKS5yZXBsYWNlKC8mYW1wOy9nLCAnJicpCgp2YXIgZWwgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdodG1sJyk7CmVsLmlubmVySFRNTCA9IGh0bWw7Cgp2YXIgYmlydGhkYXkgPSBlbC5xdWVyeVNlbGVjdG9yKCdbbmFtZT0iYmlydGhkYXlfbW9udGgiXT5vcHRpb25bc2VsZWN0ZWQ9IjEiXScpLnZhbHVlICsgJy8nICsgZWwucXVlcnlTZWxlY3RvcignW25hbWU9ImJpcnRoZGF5X2RheSJdPm9wdGlvbltzZWxlY3RlZD0iMSJdJykudmFsdWUgKyAnLycgKwplbC5xdWVyeVNlbGVjdG9yKCdbbmFtZT0iYmlydGhkYXlfeWVhciJdPm9wdGlvbltzZWxlY3RlZD0iMSJdJykudmFsdWU7CnZhciBnZW5kZXIgPSBlbC5xdWVyeVNlbGVjdG9yKCdpbnB1dFtjaGVja2VkPSIxIl1bbmFtZT0iZ2VuZGVyIl0nKS52YWx1ZT09MT8nZmVtYWxlJzonbWFsZSc7CnJldHVybiBiaXJ0aGRheSsnfCcrZ2VuZGVyOw==")).ToString();
					if (text22.Split('|').Length > 1)
					{
						if (text10 == "")
						{
							text10 = text22.Split('|')[0];
							BC0C40BD(int_4, "cBirthday", text10, "birthday", bool_5: false);
						}
						if (text6 == "")
						{
							text6 = text22.Split('|')[1];
							BC0C40BD(int_4, "cGender", text6, "gender", bool_5: false);
						}
					}
				}
			}
			if (text2 == "" || text13 == "" || text11 == "" || text3 == "")
			{
				if (!D7B0D393.GetURL().StartsWith("https://mobile.facebook.com/"))
				{
					D7B0D393.GotoURL("https://mobile.facebook.com/");
				}
				if (text19 == "")
				{
					text19 = D7B0D393.GetFbdtsgv1();
				}
				if (text2 == "" || text13 == "")
				{
					string text23 = D7B0D393.ExecuteScript(Common.Base64Decode("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21vYmlsZS5mYWNlYm9vay5jb20vcHJvZmlsZS5waHA/dj1pbmZvJyk7Cmh0bWwgPSB1bmVzY2FwZShodG1sKS5yZXBsYWNlKC8mYW1wOy9nLCAnJicpCgp2YXIgZWwgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdodG1sJyk7CmVsLmlubmVySFRNTCA9IGh0bWw7Cgp2YXIgZW1haWwgPSBlbC5xdWVyeVNlbGVjdG9yKCdbaHJlZio9Im1haWx0bzoiXScpIT1udWxsP2VsLnF1ZXJ5U2VsZWN0b3IoJ1tocmVmKj0ibWFpbHRvOiJdJykuaW5uZXJUZXh0OiIiOwp2YXIgbmFtZSA9IGh0bWwubWF0Y2gobmV3IFJlZ0V4cCgnPHRpdGxlPiguKj8pPC90aXRsZT4nKSlbMV07CnJldHVybiBlbWFpbCsnfCcrbmFtZTsK")).ToString();
					if (text23.Split('|').Length > 1)
					{
						if (text13 == "")
						{
							text13 = text23.Split('|')[0];
							BC0C40BD(int_4, "cEmail", text13, "email", bool_5: false);
						}
						if (text2 == "")
						{
							text2 = text23.Split('|')[1];
							BC0C40BD(int_4, "cName", text2, "name", bool_5: false);
						}
					}
				}
				if (text11 == "")
				{
					text11 = D7B0D393.ExecuteScript(Common.Base64Decode("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21vYmlsZS5mYWNlYm9vay5jb20vbWU/dj1mb2xsb3dlcnMnKTsKaHRtbCA9IHVuZXNjYXBlKGh0bWwpLnJlcGxhY2UoLyZhbXA7L2csICcmJykKCnZhciBlbCA9IGRvY3VtZW50LmNyZWF0ZUVsZW1lbnQoJ2h0bWwnKTsKZWwuaW5uZXJIVE1MID0gaHRtbDsKCnZhciBmb2xsb3cgPSBlbC5xdWVyeVNlbGVjdG9yKCdbZGF0YS1zaWdpbD0icHJvZmlsZS1jYXJkLWhlYWRlciJdIHNwYW4nKS5pbm5lclRleHQucmVwbGFjZUFsbCgnLicsJycpLnJlcGxhY2VBbGwoJywnLCcnKTsKcmV0dXJuIGZvbGxvdzs=")).ToString();
					BC0C40BD(int_4, "cFollow", text11, "follow", bool_5: false);
				}
				if (text3 == "")
				{
					text3 = D7B0D393.ExecuteScript(Common.Base64Decode("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21vYmlsZS5mYWNlYm9vay5jb20vZnJpZW5kcy9jZW50ZXIvZnJpZW5kcy8/bWZmX25hdj0xJyk7Cmh0bWwgPSB1bmVzY2FwZShodG1sKS5yZXBsYWNlKC8mYW1wOy9nLCAnJicpCgp2YXIgZWwgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdodG1sJyk7CmVsLmlubmVySFRNTCA9IGh0bWw7Cgp2YXIgZnJpZW5kID0gZWwucXVlcnlTZWxlY3RvcignI2ZyaWVuZHNfY2VudGVyX21haW4gaGVhZGVyPmgzJykuaW5uZXJUZXh0LnJlcGxhY2VBbGwoJy4nLCcnKS5yZXBsYWNlQWxsKCcsJywnJykuc3BsaXQoJyAnKVswXTsKcmV0dXJuIGZyaWVuZDsK")).ToString();
					BC0C40BD(int_4, "cFriend", text3, "friends", bool_5: false);
				}
			}
			if (text7 == "" || text8 == "" || text9 == "" || text12 == "" || text13 == "" || text5 == "")
			{
				if (!D7B0D393.GetURL().StartsWith("https://www.facebook.com/"))
				{
					D7B0D393.GotoURL("https://www.facebook.com/api/graphql/");
				}
				if (text13 == "")
				{
					text13 = D7B0D393.GetEmail().FirstOrDefault();
					if (string.IsNullOrEmpty(text13))
					{
						text13 = "";
					}
					BC0C40BD(int_4, "cEmail", text13, "email", bool_5: false);
				}
				if (text7 == "")
				{
					if (text19 == "")
					{
						text19 = D7B0D393.GetFbdtsgv1();
					}
					text7 = D7B0D393.EEAC820C(text19);
					BC0C40BD(int_4, "cGroup", text7, "groups", bool_5: false);
				}
				if (text12 == "")
				{
					text12 = D7B0D393.CheckDating();
					BC0C40BD(int_4, "cDating", text12, "dating", bool_5: false);
				}
				if (text9 == "")
				{
					D7B0D393.SetFbLanguage();
					text9 = D7B0D393.CheckPrimaryLocation();
					BC0C40BD(int_4, "cLocation", text9, "location", bool_5: false);
				}
				if (text5 == "")
				{
					text5 = D7B0D393.method_69().Count.ToString();
					BC0C40BD(int_4, "cPagePro5", text5, "pagePro5", bool_5: false);
				}
				if (text8 == "")
				{
					D7B0D393.SetFbLanguage();
					text8 = D7B0D393.CheckLocation();
					BC0C40BD(int_4, "cHometown", text8.Split('|')[0], "hometown", bool_5: false);
					BC0C40BD(int_4, "cCurrentCity", text8.Split('|')[1], "currentCity", bool_5: false);
				}
			}
			if (!(text3 == "") && !(text7 == "") && !(text4 == "") && !(text16 == "") && !(text18 == "") && !(text14 == ""))
			{
				return;
			}
			string text24 = D7B0D393.GetTokenEAABs();
			if (text24 == "")
			{
				return;
			}
			if (!D7B0D393.GetURL().StartsWith("https://graph.facebook.com/"))
			{
				D7B0D393.GotoURL("https://graph.facebook.com/");
			}
			if (text3 == "" || text14 == "")
			{
				string text25 = D7B0D393.CheckNgayTao_Friend(text24);
				if (text25.Contains('|'))
				{
					if (text14 == "")
					{
						text14 = text25.Split('|')[0];
						text14 = Common.ConvertTimeStampToDateTime(Convert.ToDouble(text14)).ToString("dd/MM/yyyy HH:mm:ss tt");
						BC0C40BD(int_4, "cDateCreateAcc", text14, "dateCreateAcc", bool_5: false);
					}
					if (text3 == "")
					{
						text3 = text25.Split('|')[1];
						BC0C40BD(int_4, "cFriend", text3, "friends", bool_5: false);
					}
				}
			}
			if (text3 == "" || text4 == "" || text16 == "")
			{
				string text26 = D7B0D393.Check_friend_page_ads(text24, text3, text4, text16);
				if (text26 != "")
				{
					try
					{
						JObject jObject = JObject.Parse(text26);
						if (text3 == "")
						{
							text3 = jObject["friend"].ToString();
							BC0C40BD(int_4, "cFriend", text3, "friends", bool_5: false);
						}
						if (text4 == "")
						{
							text4 = jObject["page"].ToString();
							BC0C40BD(int_4, "cPage", text4, "pages", bool_5: false);
						}
						if (text16 == "")
						{
							text16 = jObject["ads"].ToString();
							BC0C40BD(int_4, "cAds", text16.Replace("|", "*"), "ads", bool_5: false);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			if (text7 == "")
			{
				text7 = D7B0D393.CheckGroupByToken(text24);
				BC0C40BD(int_4, "cGroup", text7, "groups", bool_5: false);
			}
			if (text18 == "")
			{
				text18 = D7B0D393.CheckBM(text24);
				BC0C40BD(int_4, "cBM", text18, "bm", bool_5: false);
			}
		}
		catch
		{
		}
	}

	private List<string> method_71(List<string> list_4, int int_4 = 50, string F89A638A = ",")
	{
		int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_4.Count * 1.0 / (double)int_4)));
		List<string> list = new List<string>();
		for (int i = 0; i < num; i++)
		{
			list.Add(string.Join(F89A638A, list_4.GetRange(int_4 * i, (int_4 * i + int_4 <= list_4.Count) ? int_4 : (list_4.Count % int_4))));
		}
		return list;
	}

	private void A8A0CF10(object sender, EventArgs e)
	{
		string string_0 = Base.B03CF4B4;
		int A502321C = 0;
		int int_0 = 10;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < D030FA3A.Rows.Count)
				{
					if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (A502321C < int_0)
						{
							Interlocked.Increment(ref A502321C);
							int A78A2F3C = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									method_72(A78A2F3C, string_0);
									Interlocked.Decrement(ref A502321C);
								}
								catch (Exception ex2)
								{
									Common.ExportError2(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							Common.Sleep(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (A502321C > 0)
				{
					Common.Sleep(1.0);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError2(null, ex.ToString());
			}
		}).Start();
	}

	private void method_72(int A7B1A22B, string D8029F24, bool bool_5 = false, string F9A5D90A = "")
	{
		try
		{
			string text = "";
			string input = DatagridviewHelper.GetStatusDataGridView(D030FA3A, A7B1A22B, "cCookie");
			string text2 = D030FA3A.Rows[A7B1A22B].Cells["cUid"].Value.ToString();
			if (text2 == "")
			{
				text2 = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			}
			text = ((!File.Exists("backup\\" + text2 + "\\ngaysinh.txt")) ? "||" : File.ReadAllText("backup\\" + text2 + "\\ngaysinh.txt"));
			DatagridviewHelper.SetStatusDataGridView(D030FA3A, A7B1A22B, "cStatus", Language.GetValue("Đang tạo file Html..."));
			if (text2 != "")
			{
				string text3 = text.Split('|')[2].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'");
				string text4 = text.Split('|')[1];
				if (text3 == "")
				{
					text3 = "NoName";
				}
				if (text4 == "")
				{
					text4 = "00/00/0000";
				}
				D8029F24 = D8029F24.Replace("{{uid}}", text2).Replace("{{birthday}}", text4).Replace("{{name}}", text3);
				string text5 = "backup\\" + text2;
				if (!Directory.Exists(text5))
				{
					return;
				}
				if (File.Exists(text5 + "\\lscomment.txt"))
				{
					string text6 = "";
					List<string> list = File.ReadAllLines(text5 + "\\lscomment.txt").ToList();
					int count = list.Count;
					for (int i = 0; i < count; i++)
					{
						text6 = text6 + "\"" + list[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
					}
					if (text6 != "")
					{
						text6 = text6.Remove(text6.Length - 1, 1);
						D8029F24 = D8029F24.Replace("{comments}", text6);
					}
					else
					{
						D8029F24 = D8029F24.Replace("{comments}", "");
					}
				}
				else
				{
					D8029F24 = D8029F24.Replace("{comments}", "");
				}
				if (File.Exists(text5 + "\\banbeinbox.txt"))
				{
					string text7 = "";
					List<string> list2 = File.ReadAllLines(text5 + "\\banbeinbox.txt").ToList();
					int count2 = list2.Count;
					for (int j = 0; j < count2; j++)
					{
						text7 = text7 + "\"" + list2[j].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
					}
					if (text7 != "")
					{
						text7 = text7.Remove(text7.Length - 1, 1);
						D8029F24 = D8029F24.Replace("{messages}", text7);
					}
					else
					{
						D8029F24 = D8029F24.Replace("{messages}", "");
					}
				}
				else
				{
					D8029F24 = D8029F24.Replace("{messages}", "");
				}
				if (File.Exists(text5 + "\\" + text2 + ".txt"))
				{
					string text8 = "";
					string text9 = "";
					string text10 = File.ReadAllText(text5 + "\\" + text2 + ".txt");
					string[] array = text10.Split(new string[1] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
					for (int k = 0; k < array.Length; k++)
					{
						string[] array2 = array[k].Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
						if (array2.Length != 0)
						{
							text9 = "";
							for (int l = 0; l < array2.Length; l++)
							{
								string[] array3 = array2[l].Split('*');
								text9 = text9 + "\"" + array3[2].Split('|')[0] + "\",";
							}
							text9 = text9.Remove(text9.Length - 1, 1);
							text8 = text8 + "{\"uid\":\"" + array2[0].Split('*')[0] + "\",\"name\":\"" + array2[0].Split('*')[1] + "\",\"photos\":[" + text9 + "],\"show\":true},";
						}
					}
					text8 = text8.Remove(text8.Length - 1, 1);
					D8029F24 = D8029F24.Replace("{photos}", text8);
				}
				else
				{
					D8029F24 = D8029F24.Replace("{photos}", "");
				}
				File.WriteAllText(text5 + "\\" + text2 + ".html", D8029F24);
				DatagridviewHelper.SetStatusDataGridView(D030FA3A, A7B1A22B, "cStatus", Language.GetValue("Ta\u0323o tha\u0300nh công!"));
			}
			else
			{
				DatagridviewHelper.SetStatusDataGridView(D030FA3A, A7B1A22B, "cStatus", Language.GetValue("Không co\u0301 uid!"));
			}
		}
		catch
		{
			DatagridviewHelper.SetStatusDataGridView(D030FA3A, A7B1A22B, "cStatus", Language.GetValue("Lô\u0303i ta\u0323o file!"));
		}
	}

	private bool method_73(string string_1, string string_2, string D5A02D25 = "backup\\")
	{
		bool result = false;
		try
		{
			string text = "";
			text = ((!File.Exists(D5A02D25 + "\\" + string_1 + "\\ngaysinh.txt")) ? "||" : File.ReadAllText(D5A02D25 + "\\" + string_1 + "\\ngaysinh.txt"));
			if (string_1 != "")
			{
				string text2 = text.Split('|')[2].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'");
				string text3 = text.Split('|')[1];
				if (text2 == "")
				{
					text2 = "NoName";
				}
				if (text3 == "")
				{
					text3 = "00/00/0000";
				}
				string_2 = string_2.Replace("{{uid}}", string_1).Replace("{{birthday}}", text3).Replace("{{name}}", text2);
				string text4 = D5A02D25 + "\\" + string_1;
				if (Directory.Exists(text4))
				{
					if (File.Exists(text4 + "\\lscomment.txt"))
					{
						string text5 = "";
						List<string> list = File.ReadAllLines(text4 + "\\lscomment.txt").ToList();
						int count = list.Count;
						for (int i = 0; i < count; i++)
						{
							text5 = text5 + "\"" + list[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
						}
						if (text5 != "")
						{
							text5 = text5.Remove(text5.Length - 1, 1);
							string_2 = string_2.Replace("{comments}", text5);
						}
						else
						{
							string_2 = string_2.Replace("{comments}", "");
						}
					}
					else
					{
						string_2 = string_2.Replace("{comments}", "");
					}
					if (File.Exists(text4 + "\\banbeinbox.txt"))
					{
						string text6 = "";
						List<string> list2 = File.ReadAllLines(text4 + "\\banbeinbox.txt").ToList();
						int count2 = list2.Count;
						for (int j = 0; j < count2; j++)
						{
							text6 = text6 + "\"" + list2[j].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
						}
						if (text6 != "")
						{
							text6 = text6.Remove(text6.Length - 1, 1);
							string_2 = string_2.Replace("{messages}", text6);
						}
						else
						{
							string_2 = string_2.Replace("{messages}", "");
						}
					}
					else
					{
						string_2 = string_2.Replace("{messages}", "");
					}
					if (File.Exists(text4 + "\\" + string_1 + ".txt"))
					{
						string text7 = "";
						string text8 = "";
						string text9 = File.ReadAllText(text4 + "\\" + string_1 + ".txt");
						string[] array = text9.Split(new string[1] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
						for (int k = 0; k < array.Length; k++)
						{
							string[] array2 = array[k].Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
							if (array2.Length != 0)
							{
								text8 = "";
								for (int l = 0; l < array2.Length; l++)
								{
									string[] array3 = array2[l].Split('*');
									text8 = text8 + "\"" + array3[2].Split('|')[0] + "\",";
								}
								text8 = text8.Remove(text8.Length - 1, 1);
								text7 = text7 + "{\"uid\":\"" + array2[0].Split('*')[0] + "\",\"name\":\"" + array2[0].Split('*')[1] + "\",\"photos\":[" + text8 + "],\"show\":true},";
							}
						}
						text7 = text7.Remove(text7.Length - 1, 1);
						string_2 = string_2.Replace("{photos}", text7);
					}
					else
					{
						string_2 = string_2.Replace("{photos}", "");
					}
					File.WriteAllText(text4 + "\\" + string_1 + ".html", string_2);
					result = true;
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private void method_74(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < D030FA3A.Rows.Count)
				{
					if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Interlocked.Increment(ref int_0);
							int int_2 = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = DatagridviewHelper.GetStatusDataGridView(D030FA3A, int_2, "cCookies");
									string text = DatagridviewHelper.GetStatusDataGridView(D030FA3A, int_2, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(FileHelper.GetPathToCurrentFolder() + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										DatagridviewHelper.SetStatusDataGridView(D030FA3A, int_2, "cStatus", Language.GetValue("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref int_0);
								}
								catch (Exception ex2)
								{
									Common.ExportError2(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							Common.Sleep(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_0 > 0)
				{
					Common.Sleep(1.0);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError2(null, ex.ToString());
			}
		}).Start();
	}

	private void AD8082AE(object sender, EventArgs e)
	{
		Common.ShowForm(new fSelectFolder());
		string a6B9FE = fSelectFolder.A6B9FE13;
		if (a6B9FE == "")
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < D030FA3A.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text = D030FA3A.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (File.Exists(FileHelper.GetPathToCurrentFolder() + "\\backup\\" + text + "\\" + text + ".html"))
					{
						File.Copy("backup\\" + text + "\\" + text + ".html", a6B9FE + "\\" + text + ".html");
						num++;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		MessageBoxHelper.Show(string.Format(Language.GetValue("Copy thành công {0} tệp backup html!"), num));
	}

	private void method_75(object sender, EventArgs e)
	{
		method_99(SettingsTool.B69B10B2());
	}

	private void D030FA3A_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		DatagridviewHelper.smethod_7(e);
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		string text = SettingsTool.GetSettings("configDatagridview").D9A09B34();
		Common.ShowForm(new fCauHinhHienThi());
		if (SettingsTool.GetSettings("configDatagridview").D9A09B34() != text)
		{
			method_98();
		}
	}

	private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_59("start");
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_2, Language.GetValue("Đang kiểm tra..."));
							method_76(int_2);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_59("stop");
		}).Start();
	}

	private void method_76(int int_4)
	{
		try
		{
			string text = D030FA3A.Rows[int_4].Cells["cProxy"].Value.ToString();
			int eA0A = 0;
			if (text.EndsWith("*1"))
			{
				eA0A = 1;
			}
			text = text.Substring(0, text.Length - 2);
			int num = 0;
			int num2 = 0;
			string text2 = "";
			bool flag = false;
			for (int i = 0; i < 10; i++)
			{
				text2 = Common.CheckIP(text, eA0A);
				if (text2 != "")
				{
					num++;
					if (num == 3)
					{
						flag = true;
						break;
					}
				}
				else
				{
					num2++;
					if (num2 == 3)
					{
						break;
					}
				}
			}
			if (!flag)
			{
				method_86(int_4, "Proxy Die!");
			}
			else
			{
				method_86(int_4, "Proxy Live!");
			}
		}
		catch
		{
			method_86(int_4, "Lỗi!");
		}
	}

	private void B831D839_Click(object sender, EventArgs e)
	{
		method_8("cUseragent");
	}

	private void proxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		method_8("cProxy");
	}

	private string AE8404BB()
	{
		string a319C18F = Common.CreateRandomString(6) + Common.CreateRandomNumber(4) + Common.CreateRandomString(5);
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typePass") == 0)
		{
			a319C18F = SettingsTool.GetSettings("configGeneral").GetValue("txtPass");
		}
		return a319C18F.RandomChar(1);
	}

	private int method_77(string string_1, string string_2, int int_4, string string_3, Chrome f336F52E_0)
	{
		int result = 0;
		bool flag = false;
		string text = Common.smethod_71();
		bool flag2 = false;
		string string_4 = method_93(int_4, "cPassword");
		int num = 0;
		int num2 = f336F52E_0.CheckExistElements(10.0, "[id=\"m_login_email\"]", "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"password_new\"]", "a[href=\"/checkpoint/dyi/create_file/\"]", "[name=\"send_code\"]", "section > div > div:nth-child(3) > div > div:nth-child(1) > div > fieldset > label");
		switch (num2)
		{
		case 0:
		case 1:
			result = 0;
			break;
		case 3:
			f336F52E_0.DelayTime(1.0);
			f336F52E_0.Click(4, "[name=\"submit[Yes]\"]");
			if (f336F52E_0.CheckExistElement("[name=\"password_new\"]", 10.0) == 1)
			{
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.SendKeys(4, "[name=\"password_new\"]", text);
				f336F52E_0.DelayTime(2.0);
				method_91(string_1, "pass", int_4, "cPassword", text);
				num = 0;
				do
				{
					f336F52E_0.SendEnter("[name=\"password_new\"]");
					f336F52E_0.DelayTime(1.0);
					num++;
				}
				while (num != 7 && f336F52E_0.CheckExistElement("#checkpointSubmitButton-actual-button") == 1);
				if (flag = CommonChrome.CheckLiveCookieWhenGiaiCP(f336F52E_0, "https://m.facebook.com/") == 1)
				{
					string text5 = f336F52E_0.GetCookieFromChrome();
					if (text5 != "")
					{
						CommonSQL.UpdateFieldToAccount(string_1, "cookie1", text5);
						B034598F(int_4, "cCookies", text5);
					}
					method_87(int_4, "Live");
					CommonSQL.UpdateFieldToAccount(string_1, "cookie1", text5);
					result = 2;
				}
				else
				{
					result = 3;
				}
			}
			else
			{
				result = 3;
			}
			break;
		case 4:
			f336F52E_0.DelayTime(1.0);
			result = ((!method_78(f336F52E_0, string_1, int_4, string_2)) ? 3 : 2);
			break;
		case 5:
			result = 1;
			break;
		case 2:
		case 6:
		case 7:
		{
			List<string> list = f336F52E_0.ExecuteScript("var s='';document.getElementsByName('verification_method').forEach(element => {s+=element.value+'|'}); return s;").ToString().TrimEnd('|')
				.Split('|')
				.ToList();
			if (list.Contains("2") || num2 == 7)
			{
				string text2 = method_93(int_4, "cBirthday");
				if (!(text2 != ""))
				{
					break;
				}
				method_86(int_4, string_3 + Language.GetValue("Gia\u0309i checkpoint nga\u0300y sinh..."));
				int num3 = Convert.ToInt32(text2.Split('/')[1].Trim());
				int num4 = Convert.ToInt32(text2.Split('/')[0].Trim());
				int num5 = Convert.ToInt32(text2.Split('/')[2].Trim());
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.ExecuteScript("document.querySelector('[value=\"2\"]').click()");
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.ExecuteScript("document.querySelector(\"#checkpointSubmitButton-actual-button\").click()");
				if (f336F52E_0.CheckExistElement("section > div > div:nth-child(3) > div > div:nth-child(1) > div > fieldset > label", 30.0) != 1)
				{
					break;
				}
				f336F52E_0.ExecuteScript("document.querySelector(\"section > div > div:nth-child(3) > div > div:nth-child(1) > div > fieldset > label:nth-child(" + num3 + ")\").click()");
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.ExecuteScript("document.querySelector(\"section > div > div:nth-child(3) > div > div:nth-child(2) > div > fieldset > label:nth-child(" + num4 + ")\").click()");
				f336F52E_0.DelayTime(1.0);
				f336F52E_0.ExecuteScript("document.querySelector(\"section > div > div:nth-child(3) > div > div:nth-child(3) > div > fieldset > label:nth-child(" + (DateTime.Now.Year - 12 - num5) + ")\").click()");
				f336F52E_0.DelayTime(1.0);
				for (int i = 0; i < 3; i++)
				{
					if (f336F52E_0.CheckExistElement("#checkpointSubmitButton-actual-button", 5.0) != 1)
					{
						break;
					}
					f336F52E_0.ExecuteScript("document.querySelector(\"#checkpointSubmitButton-actual-button\").click()");
					f336F52E_0.DelayTime(1.0);
				}
				for (int j = 0; j < 15; j++)
				{
					if (!flag2 && f336F52E_0.CheckExistElement("[name=\"password_new\"]", 3.0) == 1)
					{
						if (f336F52E_0.CheckExistElement("[name=\"password_old\"]") == 1)
						{
							f336F52E_0.SendKeys(2, "password_old", string_4);
						}
						f336F52E_0.DelayTime(1.0);
						f336F52E_0.SendKeys(2, "password_new", text);
						f336F52E_0.DelayTime(1.0);
						if (f336F52E_0.CheckExistElement("[name=\"password_confirm\"]") == 1)
						{
							f336F52E_0.SendKeys(2, "password_confirm", text);
						}
						flag2 = true;
						method_91(string_1, "pass", int_4, "cPassword", text);
					}
					num2 = f336F52E_0.CheckExistElements(flag2 ? 3 : 0, "#checkpointButtonContinue-actual-button", "#checkpointSubmitButton-actual-button");
					if (num2 == 0)
					{
						break;
					}
					f336F52E_0.DelayTime(1.0);
					switch (num2)
					{
					case 2:
						f336F52E_0.Click(1, "checkpointSubmitButton-actual-button");
						break;
					case 1:
						f336F52E_0.Click(1, "checkpointButtonContinue-actual-button");
						break;
					}
					f336F52E_0.DelayTime(2.0);
				}
				if (!(flag = CommonChrome.CheckLiveCookieWhenGiaiCP(f336F52E_0, "https://m.facebook.com/") == 1))
				{
					f336F52E_0.ExecuteScript("document.querySelector(\"section > div > div:nth-child(3) > div > div:nth-child(1) > div > fieldset > label:nth-child(" + num4 + ")\").click()");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelector(\"section > div > div:nth-child(3) > div > div:nth-child(2) > div > fieldset > label:nth-child(" + num3 + ")\").click()");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelector(\"section > div > div:nth-child(3) > div > div:nth-child(3) > div > fieldset > label:nth-child(" + (DateTime.Now.Year - 12 - num5) + ")\").click()");
					f336F52E_0.DelayTime(1.0);
					f336F52E_0.ExecuteScript("document.querySelector(\"#checkpointSubmitButton-actual-button\").click()");
					f336F52E_0.DelayTime(3.0);
					flag2 = false;
					for (int k = 0; k < 15; k++)
					{
						if (!flag2 && f336F52E_0.CheckExistElement("[name=\"password_new\"]", 3.0) == 1)
						{
							if (f336F52E_0.CheckExistElement("[name=\"password_old\"]") == 1)
							{
								f336F52E_0.SendKeys(2, "password_old", string_4);
							}
							f336F52E_0.DelayTime(1.0);
							f336F52E_0.SendKeys(2, "password_new", text);
							f336F52E_0.DelayTime(1.0);
							if (f336F52E_0.CheckExistElement("[name=\"password_confirm\"]") == 1)
							{
								f336F52E_0.SendKeys(2, "password_confirm", text);
							}
							flag2 = true;
							method_91(string_1, "pass", int_4, "cPassword", text);
						}
						num2 = f336F52E_0.CheckExistElements(flag2 ? 3 : 0, "#checkpointButtonContinue-actual-button", "#checkpointSubmitButton-actual-button");
						if (num2 == 0)
						{
							break;
						}
						f336F52E_0.DelayTime(1.0);
						switch (num2)
						{
						case 2:
							f336F52E_0.Click(1, "checkpointSubmitButton-actual-button");
							break;
						case 1:
							f336F52E_0.Click(1, "checkpointButtonContinue-actual-button");
							break;
						}
						f336F52E_0.DelayTime(2.0);
					}
					flag = CommonChrome.CheckLiveCookieWhenGiaiCP(f336F52E_0, "https://m.facebook.com/") == 1;
				}
				if (flag)
				{
					string text3 = f336F52E_0.GetCookieFromChrome();
					if (text3 != "")
					{
						CommonSQL.UpdateFieldToAccount(string_1, "cookie1", text3);
						B034598F(int_4, "cCookies", text3);
					}
					method_87(int_4, "Live");
					result = 2;
				}
				else
				{
					result = 3;
				}
			}
			else
			{
				string text4 = "";
				for (int l = 0; l < list.Count; l++)
				{
					text4 = text4 + CheckInfoAccountv2.CheckCheckpoint(list[l]) + "-";
				}
				text4 = text4.TrimEnd('-');
				string string_5 = "Checkpoint: " + text4;
				method_87(int_4, string_5);
				result = 1;
			}
			break;
		}
		}
		return result;
	}

	private bool method_78(Chrome D1927291, string string_1, int int_4, string string_2)
	{
		bool flag = false;
		string string_3 = method_93(int_4, "cPassword");
		string text = Common.smethod_71();
		int num = 0;
		for (int i = 0; i < 15; D1927291.DelayTime(2.0), i++)
		{
			num = D1927291.CheckExistElements(3.0, "[name=\"password_new\"]", "[name=\"pw\"]");
			if (!flag && num != 0)
			{
				if (D1927291.CheckExistElement("[name=\"password_old\"]") == 1)
				{
					D1927291.SendKeys(2, "password_old", string_3);
					D1927291.DelayTime(1.0);
				}
				D1927291.SendKeys(2, "password_new", text);
				D1927291.DelayTime(1.0);
				D1927291.SendKeys(2, "password_confirm", text);
				D1927291.DelayTime(1.0);
				D1927291.Click(1, "checkpointSubmitButton");
				method_91(string_1, "pass", int_4, "cPassword", text);
				flag = true;
			}
			num = D1927291.CheckExistElements(flag ? 3 : 0, "#approvals_code", "#checkpointSubmitButton", "#checkpointButtonContinue");
			if (num == 0)
			{
				break;
			}
			D1927291.DelayTime(1.0);
			switch (num)
			{
			case 1:
			{
				string text2 = "";
				if (string_2.Replace(" ", "").Replace("\n", "") != "")
				{
					text2 = Common.GetTotp(string_2.Replace(" ", "").Replace("\n", ""));
				}
				if (!(text2 != ""))
				{
					break;
				}
				D1927291.SendKeys(1, "approvals_code", text2, 0.1);
				D1927291.DelayTime(1.0);
				D1927291.Click(1, "checkpointSubmitButton");
				D1927291.DelayTime(1.0);
				int num2 = 0;
				for (int j = 0; j < 7; j++)
				{
					if (D1927291.Click(1, "checkpointSubmitButton") != 1)
					{
						break;
					}
					D1927291.DelayTime(1.0);
					num2++;
				}
				continue;
			}
			case 2:
				D1927291.Click(1, "checkpointSubmitButton", D1927291.CountElementWithXpath("#checkpointSubmitButton") - 1);
				continue;
			case 3:
				D1927291.Click(1, "checkpointButtonContinue");
				continue;
			default:
				continue;
			}
			break;
		}
		if (CommonChrome.CheckLiveCookieWhenGiaiCP(D1927291, "https://m.facebook.com/") == 1)
		{
			string text3 = D1927291.GetCookieFromChrome();
			if (text3 != "")
			{
				method_87(int_4, "Live");
				B034598F(int_4, "cCookies", text3);
				CommonSQL.UpdateFieldToAccount(string_1, "cookie1", text3);
			}
			return true;
		}
		return false;
	}

	private void method_79(object sender, EventArgs e)
	{
		bool_0 = false;
		for (int i = 0; i < D030FA3A.Rows.Count; i++)
		{
			if (bool_0)
			{
				break;
			}
			if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
			{
				continue;
			}
			string text = "backup\\" + method_93(i, "cUid");
			if (Directory.Exists(text))
			{
				try
				{
					Process.Start(text);
					method_86(i, Language.GetValue("Mở thành công!"));
				}
				catch
				{
					method_86(i, Language.GetValue("Mở thất bại!"));
				}
			}
			else
			{
				method_86(i, Language.GetValue("Chưa backup!"));
			}
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		Common.KillProcess("chromedriver");
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			try
			{
				Process.Start(FileHelper.GetPathToCurrentFolder());
			}
			catch
			{
			}
		}
	}

	private void EDBCFD26_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_2 || EDBCFD26.SelectedValue == null || !StringHelper.CheckStringIsNumber(EDBCFD26.SelectedValue.ToString()) || (EDBCFD26.SelectedValue.ToString() != "-1" && int_1 == EDBCFD26.SelectedIndex))
		{
			return;
		}
		string text = D68F8BB7.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				EA21F124(method_6(), EDBCFD26.Text);
			}
			else
			{
				EA21F124(fChonThuMuc.DE35F309, EDBCFD26.Text);
			}
		}
		else
		{
			EA21F124(null, EDBCFD26.Text);
		}
		int_1 = EDBCFD26.SelectedIndex;
	}

	private void method_80(object sender, EventArgs e)
	{
		Common.ShowForm(new fCauHinhTaoShortcut());
		if (!fCauHinhTaoShortcut.bool_0)
		{
			return;
		}
		int int_0 = 0;
		int CAA1F72D = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_59("start");
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < CAA1F72D)
					{
						Interlocked.Increment(ref int_0);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_, Language.GetValue("Đang ta\u0323o Shortcut..."));
							try
							{
								D030FA3A.Rows[int_].Cells["cId"].Value.ToString();
								string text = D030FA3A.Rows[int_].Cells["cUid"].Value.ToString();
								string text2 = D030FA3A.Rows[int_].Cells["cName"].Value.ToString();
								string string_ = ((text2 == "") ? text : (text2 + "_" + text));
								string string_2 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
								if (SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUsePortable") && Directory.Exists(SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text + "\\Data\\profile"))
								{
									string_2 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text + "\\Data\\profile";
								}
								Common.CreateFolder(string_2);
								bool flag;
								if (!(flag = method_81(string_2, string_)))
								{
									string_ = text;
									flag = method_81(string_2, string_);
								}
								if (!flag)
								{
									method_86(int_, Language.GetValue("Lô\u0303i ta\u0323o Shortcut!"));
								}
								else
								{
									method_86(int_, Language.GetValue("Ta\u0323o Shortcut thành công!"));
								}
							}
							catch
							{
								method_86(int_, Language.GetValue("Lỗi!"));
							}
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_59("stop");
		}).Start();
	}

	private bool method_81(string string_1, string string_2)
	{
		try
		{
			string_2 = Common.ConvertToUnSign(string_2);
			if (string_1.StartsWith("profiles\\"))
			{
				string_1 = FileHelper.GetPathToCurrentFolder() + "\\" + string_1;
			}
			string text = FileHelper.GetPathToCurrentFolder() + "\\images\\chrome.ico";
			if (!File.Exists(text))
			{
				using FileStream outputStream = new FileStream(text, FileMode.Create);
				Resources.Icon_0.Save(outputStream);
			}
			if (Common.CreateShortcutChrome(string_2, SettingsTool.GetSettings("configInteractGeneral").GetValue("txtPathShortcut"), string_1, text, SettingsTool.GetSettings("configInteractGeneral").GetValue("txtPathChromeOrigin")))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		CCA7CEA8(bool_5: false);
	}

	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		method_62(4);
	}

	private void method_82(int int_4 = 1)
	{
		try
		{
			for (int i = 0; i < int_4; i++)
			{
				if (D030FA3A.RowCount <= 1)
				{
					continue;
				}
				List<DataGridViewRow> list = new List<DataGridViewRow>();
				foreach (DataGridViewRow item in (IEnumerable)D030FA3A.Rows)
				{
					list.Add(item);
				}
				int num = list.Count;
				while (num > 1)
				{
					num--;
					int index = Base.rd.Next(num + 1);
					DataGridViewRow value = list[index];
					list[index] = list[num];
					list[num] = value;
				}
				D030FA3A.Rows.Clear();
				foreach (DataGridViewRow item2 in list)
				{
					D030FA3A.Rows.Add(item2);
				}
			}
		}
		catch
		{
		}
	}

	public int B1ABC129()
	{
		int result = 0;
		try
		{
			result = Convert.ToInt32(lblCountSelect.Text);
		}
		catch
		{
		}
		return result;
	}

	private bool A28928BD()
	{
		if (B1ABC129() == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return false;
		}
		return true;
	}

	private void D02B6F94(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), B1ABC129())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int DEB1F8A8 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < DEB1F8A8)
					{
						Interlocked.Increment(ref int_0);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_, Language.GetValue("Đang xo\u0301a dữ liệu backup..."));
							method_83(int_);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_83(int int_4)
	{
		try
		{
			string text = D030FA3A.Rows[int_4].Cells["cId"].Value.ToString();
			string text2 = D030FA3A.Rows[int_4].Cells["cUid"].Value.ToString();
			if (text2.Trim() == "")
			{
				method_86(int_4, Language.GetValue("Chưa backup!"));
				return;
			}
			string path = "backup\\" + text2;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_86(int_4, Language.GetValue("Xóa dữ liệu backup thành công!"));
				B034598F(int_4, "cBackup", "");
				CommonSQL.UpdateFieldToAccount(text, "backup", "");
			}
			else
			{
				method_86(int_4, Language.GetValue("Chưa backup!"));
			}
		}
		catch
		{
			method_86(int_4, Language.GetValue("Xóa dữ liệu backup thất bại!"));
		}
	}

	private void C6AFB38F(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		string string_0 = SettingsTool.B69B10B2();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int CBAAC9B0 = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(CBAAC9B0, "Check backup...");
							BD3664B7(CBAAC9B0, string_0);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void BD3664B7(int int_4, string string_1)
	{
		try
		{
			string text = D030FA3A.Rows[int_4].Cells["cId"].Value.ToString();
			string text2 = D030FA3A.Rows[int_4].Cells["cUid"].Value.ToString();
			string text3 = string_1 + "\\" + text2 + "\\" + text2 + ".txt";
			string text4 = string_1 + "\\" + text2 + "\\" + text2 + ".html";
			string text5 = (File.Exists(text3) ? text3 : (File.Exists(text4) ? text4 : ""));
			if (text5 != "")
			{
				method_86(int_4, Language.GetValue("Đã backup!"));
				string text6 = Common.smethod_14(text5);
				B034598F(int_4, "cBackup", text6);
				CommonSQL.UpdateFieldToAccount(text, "backup", text6);
			}
			else
			{
				method_86(int_4, Language.GetValue("Chưa backup!"));
				B034598F(int_4, "cBackup", "");
				CommonSQL.UpdateFieldToAccount(text, "backup", "");
			}
		}
		catch
		{
		}
	}

	private void method_84(object sender, EventArgs e)
	{
		Common.ShowForm(new fDownloadAvatar());
		if (!fDownloadAvatar.bool_0)
		{
			return;
		}
		string string_0 = SettingsTool.GetSettings("configGeneral").GetValue("pathFolderAvatar");
		if (!Directory.Exists(string_0))
		{
			MessageBoxHelper.Show("Vui lòng kiểm tra lại nơi lưu Avatar!", 2);
			return;
		}
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_59("start");
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int DE8B699B = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(DE8B699B, Language.GetValue("Đang kiểm tra..."));
							BE072D08(DE8B699B, string_0);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_59("stop");
		}).Start();
	}

	private void BE072D08(int EB0E362B, string string_1)
	{
		try
		{
			string text = D030FA3A.Rows[EB0E362B].Cells["cUid"].Value.ToString();
			D030FA3A.Rows[EB0E362B].Cells["cId"].Value.ToString();
			string text2 = method_93(EB0E362B, "cProxy");
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
			int num = (text2.EndsWith("*1") ? 1 : 0);
			if (!SettingsTool.GetSettings("configGeneral").GetValueBool("ckbDownAvatarUseProxy"))
			{
				text2 = "";
			}
			string text3 = CheckInfoAccountv2.DownLoadImageByUid(text, string_1, text2, num);
			if (text3 != "")
			{
				method_86(EB0E362B, Language.GetValue("Tải xuống thành công!"));
			}
			else
			{
				method_86(EB0E362B, Language.GetValue("Tải xuống thất bại!"));
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "DownloadAvatar");
			method_86(EB0E362B, Language.GetValue("Tải xuống thất bại!"));
		}
	}

	private void C80482BC(object sender, EventArgs e)
	{
		Common.ShowForm(new fTaiKhoanDaXoa());
	}

	private void F18F9E83_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có chắc muốn xóa Cache Profile của {0} tài khoản?"), B1ABC129())) != DialogResult.Yes)
		{
			return;
		}
		int B72C5D8D = 0;
		int int_0 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < D030FA3A.Rows.Count)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (B72C5D8D < int_0)
					{
						Interlocked.Increment(ref B72C5D8D);
						int B007A43E = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(B007A43E, Language.GetValue("Đang xo\u0301a Cache Profile..."));
							method_85(B007A43E);
							Interlocked.Decrement(ref B72C5D8D);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	public void AA856082(string string_1)
	{
		try
		{
			Directory.Delete(string_1, recursive: true);
		}
		catch (Exception)
		{
		}
	}

	private void method_85(int DA30FC1E)
	{
		try
		{
			D030FA3A.Rows[DA30FC1E].Cells["cId"].Value.ToString();
			string text = D030FA3A.Rows[DA30FC1E].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_86(DA30FC1E, Language.GetValue("Chưa tạo profile!"));
				return;
			}
			string text2 = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
			if (Directory.Exists(text2))
			{
				Common.DeleteFile(text2 + "\\Default\\Cache");
				Common.DeleteFile(text2 + "\\Default\\Code Cache");
				Common.DeleteFile(text2 + "\\OptimizationGuidePredictionModels");
				Common.DeleteFile(text2 + "\\Default\\optimization_guide_prediction_model_downloads");
				Common.DeleteFile(text2 + "\\SwReporter");
				Common.DeleteFile(text2 + "\\pnacl");
				method_86(DA30FC1E, Language.GetValue("Xóa Cache Profile thành công!"));
			}
			else
			{
				method_86(DA30FC1E, Language.GetValue("Chưa tạo profile!"));
			}
		}
		catch
		{
			method_86(DA30FC1E, Language.GetValue("Xóa Cache Profile thất bại!"));
		}
	}

	private void A19CDB1C_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchLocTrung());
	}

	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://app.minsoftware.vn/textfree.html");
		}
		catch
		{
			Process.Start("https://app.minsoftware.vn/textfree.html");
		}
	}

	private void checkCookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void checkHotmailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckImapHotmail());
	}

	private void D030FA3A_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.RowIndex > -1)
			{
				D030FA3A.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(D030FA3A.CurrentRow.Cells["cChose"].Value);
				method_61();
			}
		}
		catch
		{
		}
	}

	private void btnEditFile_Click(object sender, EventArgs e)
	{
		List<string> list = method_6();
		if (list != null && list.Count == 1)
		{
			fEditFile fEditFile2 = new fEditFile(list[0], D68F8BB7.Text);
			fEditFile2.ShowInTaskbar = false;
			fEditFile2.ShowDialog();
			int selectedIndex = D68F8BB7.SelectedIndex;
			if (fEditFile2.bool_0)
			{
				method_2();
				int_0 = -1;
				D68F8BB7.SelectedIndex = selectedIndex;
			}
		}
	}

	private void D3A30F12(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckProxy());
	}

	private void FD0F411A(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid f029BA8C = new fLocTheoDanhSachUid();
		Common.ShowForm(f029BA8C);
		if (f029BA8C.CB22AE1B.Count > 0)
		{
			List<string> list = Common.CloneList(f029BA8C.CB22AE1B);
			DataTable dataTable_ = CommonSQL.smethod_11(list);
			D030FA3A.Rows.Clear();
			method_7(dataTable_);
		}
	}

	private void F0281235(object sender, EventArgs e)
	{
		Common.ShowForm(new fCauHinhTuongTac());
	}

	public void method_86(int E6813628, string string_1, int int_4 = -1)
	{
		switch (int_4)
		{
		case -1:
			DatagridviewHelper.SetStatusDataGridView(D030FA3A, E6813628, "cStatus", string_1);
			return;
		case 0:
			return;
		}
		int tickCount = Environment.TickCount;
		while (true)
		{
			int num = int_4 - (Environment.TickCount - tickCount) / 1000;
			if (num > 0 && !bool_0)
			{
				DatagridviewHelper.SetStatusDataGridView(D030FA3A, E6813628, "cStatus", string_1.Replace("{time}", num.ToString()));
				Common.Sleep(0.5);
				continue;
			}
			break;
		}
	}

	public void D689A787(int int_4, string string_1, int int_5, int int_6)
	{
		int int_7 = Base.rd.Next(int_5, int_6 + 1);
		method_86(int_4, string_1, int_7);
	}

	public void method_87(int int_4, string string_1)
	{
		DatagridviewHelper.SetStatusDataGridView(D030FA3A, int_4, "cInfo", string_1);
		method_95(int_4);
		CommonSQL.UpdateFieldToAccount(method_93(int_4, "cId"), "info", string_1);
	}

	public int method_88(int int_4)
	{
		string text = method_93(int_4, "cJob").Trim();
		if (text == "")
		{
			return 0;
		}
		string text2 = DateTime.Now.ToString("dd/MM/yyyy");
		string text3 = text.Split(' ')[0].Trim().Substring(1, 10);
		if (text3 != text2)
		{
			return 0;
		}
		return Convert.ToInt32(text.Split(' ')[1].Trim());
	}

	public void method_89(int int_4, int BFB8F19F)
	{
		int num = method_88(int_4);
		string string_ = "(" + DateTime.Now.ToString("dd/MM/yyyy") + ") " + (BFB8F19F + num);
		BC0C40BD(int_4, "cJob", string_, "job");
	}

	public void B034598F(int int_4, string string_1, object object_5, bool bool_5 = true)
	{
		if ((!(string_1 == "cUid") || !(object_5.ToString().Trim() == "")) && (bool_5 || !(object_5.ToString().Trim() == "")))
		{
			DatagridviewHelper.SetStatusDataGridView(D030FA3A, int_4, string_1, object_5);
		}
	}

	public void method_90(int int_4, int int_5, object CF9051B6)
	{
		DatagridviewHelper.smethod_5(D030FA3A, int_4, int_5, CF9051B6);
	}

	public void method_91(string string_1, string string_2, int E7A85D10, string string_3, string D239E196, bool bool_5 = true)
	{
		if ((bool_5 || !(D239E196.ToString().Trim() == "")) && !(D239E196 == "-2"))
		{
			DatagridviewHelper.SetStatusDataGridView(D030FA3A, E7A85D10, string_3, D239E196);
			CommonSQL.UpdateFieldToAccount(string_1, string_2, D239E196);
		}
	}

	public void BC0C40BD(int C4BA4615, string string_1, string string_2, string B6AD149D, bool bool_5 = true)
	{
		method_91(method_93(C4BA4615, "cId"), B6AD149D, C4BA4615, string_1, string_2, bool_5);
	}

	public string D491BE25(int B62C8D9E)
	{
		string text = DatagridviewHelper.GetStatusDataGridView(D030FA3A, B62C8D9E, "cStatus");
		if (text.StartsWith("("))
		{
			return text.Substring(text.IndexOf(')') + 1).Trim();
		}
		return text;
	}

	public string method_92(int int_4)
	{
		return DatagridviewHelper.GetStatusDataGridView(D030FA3A, int_4, "cInfo");
	}

	public string method_93(int int_4, string string_1)
	{
		return DatagridviewHelper.GetStatusDataGridView(D030FA3A, int_4, string_1);
	}

	public string method_94(int int_4, int int_5)
	{
		return DatagridviewHelper.GetStatusDataGridView(D030FA3A, int_4, int_5);
	}

	public void method_95(int C8999C08 = -1)
	{
		DatagridviewHelper.smethod_1(D030FA3A, C8999C08);
	}

	public void method_96(int int_4, int int_5)
	{
		DatagridviewHelper.smethod_2(D030FA3A, int_4, int_5);
	}

	public int method_97(int int_4)
	{
		Color backColor = D030FA3A.Rows[int_4].DefaultCellStyle.BackColor;
		if (backColor == Color.White)
		{
			return 0;
		}
		if (backColor == Color.FromArgb(255, 182, 193))
		{
			return 1;
		}
		if (backColor == Color.FromArgb(212, 237, 182))
		{
			return 2;
		}
		return -1;
	}

	private void method_98()
	{
		D030FA3A.Columns["cToken"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("cToken");
		D030FA3A.Columns["cCookies"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbCookie");
		D030FA3A.Columns["cEmail"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbEmail");
		D030FA3A.Columns["cEmail2"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbEmailFull");
		D030FA3A.Columns["cName"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbTen");
		D030FA3A.Columns["cFriend"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBanBe");
		D030FA3A.Columns["cGroup"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNhom");
		D030FA3A.Columns["cPage"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPage");
		D030FA3A.Columns["cPagePro5"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPagePro5");
		D030FA3A.Columns["cBirthday"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNgaySinh");
		D030FA3A.Columns["cGender"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbGioiTinh");
		D030FA3A.Columns["cPassword"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMatKhau");
		D030FA3A.Columns["cPassMail"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMatKhauMail");
		D030FA3A.Columns["cBackup"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBackup");
		D030FA3A.Columns["cFa2"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMa2FA");
		D030FA3A.Columns["cUseragent"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbUseragent");
		D030FA3A.Columns["cProxy"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbProxy");
		D030FA3A.Columns["cDateCreateAcc"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNgayTao");
		D030FA3A.Columns["cAvatar"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbAvatar");
		D030FA3A.Columns["cProfile"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbProfile");
		D030FA3A.Columns["cInfo"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbTinhTrang");
		D030FA3A.Columns["cThuMuc"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbThuMuc");
		D030FA3A.Columns["cGhiChu"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbGhiChu");
		D030FA3A.Columns["cFollow"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbFollow");
		D030FA3A.Columns["cInteractEnd"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbInteractEnd");
		D030FA3A.Columns["cMailRecovery"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMailRecovery");
		D030FA3A.Columns["cPhone"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPhone");
		D030FA3A.Columns["cHometown"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbHometown");
		D030FA3A.Columns["cCurrentCity"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbCurrentCity");
		D030FA3A.Columns["cJob"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbJob");
		D030FA3A.Columns["cLocation"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbLocation");
		D030FA3A.Columns["cDating"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbDating");
		D030FA3A.Columns["cAds"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbAds");
		D030FA3A.Columns["cBM"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBM");
		D030FA3A.Columns["cWallPosts"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbWallPosts");
		D030FA3A.Columns["cFbBlock"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbFbBlock");
		D030FA3A.Columns["cStatus282"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbStatus282");
	}

	private void C8095A13(object sender, EventArgs e)
	{
		Common.ShowForm(new fCapNhatDuLieu());
		if (fCapNhatDuLieu.bool_0)
		{
			DDA41599(null, null);
		}
	}

	private void D030FA3A_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (bool_3 && e.ColumnIndex == 0)
		{
			method_61();
		}
	}

	private void E80102B9_Click(object sender, EventArgs e)
	{
		method_99(SettingsTool.GetPathProfile());
	}

	private void method_99(string A01FCA2A)
	{
		Common.ShowForm(new fSelectFolder());
		string a6B9FE = fSelectFolder.A6B9FE13;
		if (a6B9FE == "")
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < D030FA3A.Rows.Count; i++)
		{
			try
			{
				if (Convert.ToBoolean(method_93(i, "cChose")))
				{
					string text = method_93(i, "cUid");
					list.Add(A01FCA2A + "\\" + text + "|" + a6B9FE + "\\" + text);
				}
			}
			catch
			{
			}
		}
		if (list.Count > 0)
		{
			Common.ShowForm(new fShowProgressBar(list));
			MessageBoxHelper.Show("Đa\u0303 copy dư\u0303 liê\u0323u xong!");
		}
	}

	private void DF895BAD_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckLiveUid());
	}

	private void toolStripMenuItem_13_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fMoTrinhDuyet());
	}

	private bool method_100(Chrome FC8EBAA1)
	{
		if (SettingsTool.GetSettings("configDebug").GetValueBool("ckbModeDev"))
		{
			new fAutoChrome(FC8EBAA1.Int32_3, FC8EBAA1.String_7).ShowDialog();
			return true;
		}
		return false;
	}

	private void B02B2108_Click(object sender, EventArgs e)
	{
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("OpenBrowser", true);
		DA809F35(gClass);
	}

	private void A6102B0C(object sender, EventArgs e)
	{
	}

	private void method_101(object sender, EventArgs e)
	{
		try
		{
			Common.ShowForm(new fClearBackup());
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString(), 3);
		}
	}

	private void toolStripMenuItem_14_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fContact());
	}

	private void A0B69B35(object sender, EventArgs e)
	{
		Common.ShowForm(new fSelectFolder());
		string a6B9FE = fSelectFolder.A6B9FE13;
		if (a6B9FE == "")
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < D030FA3A.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text = D030FA3A.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (File.Exists(FileHelper.GetPathToCurrentFolder() + "\\backup\\" + text + "\\" + text + ".txt"))
					{
						File.Copy("backup\\" + text + "\\" + text + ".txt", a6B9FE + "\\" + text + ".txt");
						num++;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		MessageBoxHelper.Show(string.Format(Language.GetValue("Copy thành công {0} tệp backup txt!"), num));
	}

	private void C5097493(object sender, EventArgs e)
	{
		A0976198.Text = D030FA3A.SelectedRows.Count.ToString();
	}

	private void E81A0513(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			try
			{
				D030FA3A.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(D030FA3A.CurrentRow.Cells["cChose"].Value);
				method_61();
			}
			catch
			{
			}
		}
	}

	private void method_102(object sender, EventArgs e)
	{
	}

	private void method_103(object sender, EventArgs e)
	{
		Common.ShowForm(new fGiaiPhongDungLuong());
	}

	private void method_104(object sender, EventArgs e)
	{
		Common.ShowForm(new fGiaiPhongDungLuong(bool_1: true));
	}

	private void C8B5958B_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < D030FA3A.RowCount; i++)
		{
			if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
			{
				D030FA3A.Rows.RemoveAt(i--);
			}
		}
		B0A4EF35();
		method_60();
		method_61(0);
	}

	private void emailPassMailMailKpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_8("cEmail|cPassMail|cMailRecovery");
	}

	private void AA21FF22_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			F32CD491(null, null);
		}
	}

	private void DB8661AF(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		int num = 0;
		for (int i = 0; i < D030FA3A.RowCount; i++)
		{
			if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
			{
				continue;
			}
			try
			{
				string item = method_93(i, "cUid");
				if (list2.Contains(item))
				{
					list.Add(D030FA3A.Rows[i].Cells["cId"].Value.ToString());
					D030FA3A.Rows.RemoveAt(i);
					i--;
					num++;
				}
				else
				{
					list2.Add(item);
				}
			}
			catch
			{
			}
		}
		CommonSQL.smethod_15(list);
		B0A4EF35();
		method_60();
		method_61();
		MessageBoxHelper.Show($"Đã loại bỏ {num} tài khoản bị trùng!");
	}

	private void B307AC95(object sender, EventArgs e)
	{
		method_62(5);
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		method_62(5, bool_5: true);
	}

	private void B0B36437(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid f029BA8C = new fLocTheoDanhSachUid();
		Common.ShowForm(f029BA8C);
		List<string> list = Common.CloneList(f029BA8C.CB22AE1B);
		if (list.Count <= 0)
		{
			return;
		}
		if (list[0].StartsWith("@"))
		{
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				string text = method_93(i, "cEmail");
				if (text != "" && text.Contains("@"))
				{
					text = text.Substring(text.IndexOf('@'));
					B034598F(i, "cChose", list.Contains(text));
				}
			}
		}
		else
		{
			for (int j = 0; j < D030FA3A.RowCount; j++)
			{
				string item = method_93(j, "cUid");
				string item2 = method_93(j, "cEmail");
				B034598F(j, "cChose", list.Contains(item) || list.Contains(item2));
			}
		}
		method_61();
	}

	private void pnlHeader_DoubleClick(object sender, EventArgs e)
	{
		this.F128E894();
	}

	private void method_105(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			fCauHinhHotmail fCauHinhHotmail2 = new fCauHinhHotmail("LoginHotmail");
			Common.ShowForm(fCauHinhHotmail2);
			if (fCauHinhHotmail2.D48D743C)
			{
				JSON_Settings gClass = new JSON_Settings();
				gClass.GetJson("LoginHotmail", true);
				FB232335(gClass);
			}
		}
	}

	private void BBAF4FAE(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			fCauHinhHotmail fCauHinhHotmail2 = new fCauHinhHotmail("DoiPassHotmail");
			Common.ShowForm(fCauHinhHotmail2);
			if (fCauHinhHotmail2.D48D743C)
			{
				JSON_Settings gClass = new JSON_Settings();
				gClass.GetJson("DoiPassHotmail", true);
				FB232335(gClass);
			}
		}
	}

	private void B49EEC91(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			fCauHinhHotmail fCauHinhHotmail2 = new fCauHinhHotmail("ThemMailKhoiPhuc");
			Common.ShowForm(fCauHinhHotmail2);
			if (fCauHinhHotmail2.D48D743C)
			{
				JSON_Settings gClass = new JSON_Settings();
				gClass.GetJson("ThemMailKhoiPhuc", true);
				FB232335(gClass);
			}
		}
	}

	private void FB232335(JSON_Settings gclass8_1 = null)
	{
		try
		{
			if (!A28928BD())
			{
				return;
			}
			int F4A1A7B3 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudInteractThread", 3);
			List<int> C184FF1E = new List<int>();
			for (int i = 0; i < F4A1A7B3; i++)
			{
				C184FF1E.Add(0);
			}
			method_59("start");
			bool_3 = true;
			bool_0 = false;
			int_3 = 0;
			E2B4308C = new List<Thread>();
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						try
						{
							int num = 0;
							while (num < D030FA3A.Rows.Count && !bool_0)
							{
								if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
								{
									if (bool_0)
									{
										break;
									}
									if (E2B4308C.Count < F4A1A7B3)
									{
										if (bool_0)
										{
											break;
										}
										int int_0 = num++;
										Thread thread3 = new Thread((ThreadStart)delegate
										{
											int num2 = Common.GetIndexOfPossitionApp(ref C184FF1E);
											try
											{
												method_106(int_0, num2, gclass8_1);
											}
											catch (Exception)
											{
											}
											Common.FillIndexPossition(ref C184FF1E, num2);
											B034598F(int_0, "cChose", false);
										})
										{
											Name = int_0.ToString()
										};
										E2B4308C.Add(thread3);
										Common.Sleep(1.0);
										thread3.Start();
									}
									else
									{
										if (bool_0)
										{
											break;
										}
										for (int j = 0; j < E2B4308C.Count; j++)
										{
											if (!E2B4308C[j].IsAlive)
											{
												E2B4308C.RemoveAt(j--);
											}
										}
									}
								}
								else
								{
									num++;
								}
								if (bool_0)
								{
									break;
								}
							}
							for (int k = 0; k < E2B4308C.Count; k++)
							{
								E2B4308C[k].Join();
							}
						}
						catch (ThreadAbortException ex)
						{
							if (ex.ToString().Contains("Thread was being aborted."))
							{
							}
						}
					});
					thread2.IsBackground = true;
					thread2.Start();
					thread2.Join();
				}
				catch (Exception exception_2)
				{
					Common.ExportError(null, exception_2);
				}
				E8AFC193();
				method_59("stop");
				bool_3 = false;
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			method_59("stop");
			bool_3 = false;
		}
	}

	private void method_106(int int_4, int F5806D00, JSON_Settings gclass8_1)
	{
		if (gclass8_1 == null)
		{
			gclass8_1 = new JSON_Settings();
		}
		Chrome f336F52E = null;
		int int32_ = 0;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = method_93(int_4, "cUid");
		string text6 = method_93(int_4, "cEmail");
		string text7 = method_93(int_4, "cPassMail");
		string text8 = method_93(int_4, "cMailRecovery");
		if (!text6.Contains("hotmail.") && !text6.Contains("outlook."))
		{
			method_86(int_4, Language.GetValue("Mail chưa hỗ trợ!"));
			return;
		}
		if (text7 == "")
		{
			method_86(int_4, Language.GetValue("Không có pass mail!"));
			return;
		}
		int num = SettingsTool.GetSettings("configHotmail").GetValueInt("cbbChangeIP");
		int num2 = num;
		if (num2 == 9)
		{
			text = method_93(int_4, "cProxy");
			int32_ = (text.EndsWith("*1") ? 1 : 0);
			if (text.EndsWith("*0") || text.EndsWith("*1"))
			{
				text = text.Substring(0, text.Length - 2);
			}
		}
		if (bool_0)
		{
			method_86(int_4, Language.GetValue("Đã dừng!"));
		}
		else
		{
			try
			{
				if (bool_0)
				{
					method_86(int_4, text2 + Language.GetValue("Đã dừng!"));
				}
				else
				{
					method_86(int_4, text2 + Language.GetValue("Chờ đến lượt..."));
					lock (BF286719)
					{
						if (int_3 > 0)
						{
							int num3 = Base.rd.Next(SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeFrom", 1), SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeTo", 1) + 1);
							if (num3 > 0)
							{
								int tickCount = Environment.TickCount;
								while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
								{
									method_86(int_4, text2 + Language.GetValue("Mở tri\u0300nh duyê\u0323t sau") + " {time}s...".Replace("{time}", (num3 - (Environment.TickCount - tickCount) / 1000).ToString()));
									Common.Sleep(0.5);
									if (!bool_0)
									{
										continue;
									}
									method_86(int_4, text2 + Language.GetValue("Đã dừng!"));
									goto end_IL_0151;
								}
							}
						}
						else
						{
							int_3++;
						}
					}
					method_86(int_4, text2 + Language.GetValue("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
					string b59D = "data:,";
					Point c81213A = Common.GetPointFromIndexPosition(F5806D00, 5, 2);
					Point point_ = Common.GetSizeChrome(5, 2);
					if (gclass8_1.GetValueBool("LoginHotmail") && !SettingsTool.GetSettings("configHotmail").GetValueBool("ckbCloseChrome"))
					{
						b59D = "";
					}
					string text9 = SettingsTool.GetPathProfile();
					string text10 = "";
					if (text9 != "" && (text5 != "" || text6 != ""))
					{
						if (text5 != "")
						{
							text10 = text9 + "\\" + text5;
						}
						else if (text6 != "")
						{
							text10 = text9 + "\\" + text6;
						}
						if (!SettingsTool.GetSettings("configHotmail").GetValueBool("ckbUseProfile") && !Directory.Exists(text10))
						{
							text10 = "";
						}
					}
					if (gclass8_1.GetValueBool("LoginHotmail") && !SettingsTool.GetSettings("configHotmail").GetValueBool("ckbUseProfile"))
					{
						text10 = "";
					}
					f336F52E = new Chrome
					{
						IndexChrome = int_4,
						DisableImage = !SettingsTool.GetSettings("configGeneral").GetValueBool("ckbShowImageInteract"),
						ProfilePath = text10,
						Size = point_,
						Position = c81213A,
						Proxy = text,
						TypeProxy = int32_,
						DisableSound = true,
						App = b59D,
						Row = int_4
					};
					if (bool_0)
					{
						method_86(int_4, text2 + Language.GetValue("Đã dừng!"));
					}
					else
					{
						var (flag, text11) = f336F52E.Open();
						if (!flag)
						{
							method_86(int_4, text2 + Language.GetValue("Lỗi mở trình duyệt!") + ((text11 != "") ? (" (" + text11 + ")") : ""));
						}
						else
						{
							method_86(int_4, text2 + Language.GetValue("Đang đăng nhâ\u0323p..."));
							string json = f336F52E.LoginHotmail(text6, text7, text8);
							JObject jObject = JObject.Parse(json);
							if (!Convert.ToBoolean(jObject["success"]))
							{
								method_86(int_4, jObject["error"].ToString() + "!");
								method_96(int_4, 1);
							}
							else
							{
								if (jObject["mailRecover"].ToString() != "" && jObject["mailRecover"].ToString() != text8)
								{
									text3 = "success";
									text8 = jObject["mailRecover"].ToString();
									BC0C40BD(int_4, "cMailRecovery", text8, "mailrecovery");
								}
								if (text7 != jObject["passmail"].ToString())
								{
									text4 = "success";
									text7 = jObject["passmail"].ToString();
									BC0C40BD(int_4, "cPassMail", text7, "passmail");
								}
								method_86(int_4, "Login hotmail success!");
								method_96(int_4, 2);
								if (!gclass8_1.GetValueBool("LoginHotmail"))
								{
									if (!gclass8_1.GetValueBool("ThemMailKhoiPhuc") || !(text3 != "success"))
									{
										goto IL_0818;
									}
									bool flag2 = text8 != "";
									method_86(int_4, text2 + Language.GetValue("Thêm mail khôi phục..."));
									string json2 = f336F52E.AddMailKhoiPhuc(text6, text7, text8);
									JObject jObject2 = JObject.Parse(json2);
									if (!Convert.ToBoolean(jObject2["success"]))
									{
										text3 = "fail (" + jObject2["error"].ToString() + ")";
										method_86(int_4, jObject2["error"].ToString() + "!");
										method_96(int_4, 1);
									}
									else
									{
										if (jObject2["mailRecover"].ToString() != "" && jObject2["mailRecover"].ToString() != text8)
										{
											text3 = "success";
											text8 = jObject2["mailRecover"].ToString();
											BC0C40BD(int_4, "cMailRecovery", text8, "mailrecovery");
										}
										if (!flag2 || !(text3 == "success") || !SettingsTool.GetSettings("configHotmail").GetValueBool("ckbXoaMailKhoiPhucCu", bool_0: true))
										{
											goto IL_0818;
										}
										method_86(int_4, text2 + Language.GetValue("Xóa mail khôi phục cũ..."));
										string json3 = f336F52E.XoaMailKhoiPhuc(text6, text7, text8);
										JObject jObject3 = JObject.Parse(json3);
										if (Convert.ToBoolean(jObject3["success"]))
										{
											goto IL_0818;
										}
										_ = "fail (" + jObject3["error"].ToString() + ")";
										method_86(int_4, jObject3["error"].ToString() + "!");
										method_96(int_4, 1);
									}
								}
							}
						}
					}
				}
				goto end_IL_0151;
				IL_0818:
				if (gclass8_1.GetValueBool("DoiPassHotmail") && text4 != "success")
				{
					method_86(int_4, text2 + Language.GetValue("Đổi pass mail..."));
					string json4 = f336F52E.DoiPassHotmail(text6, text7, text8);
					JObject jObject4 = JObject.Parse(json4);
					if (jObject4["mailRecover"].ToString() != "" && jObject4["mailRecover"].ToString() != text8)
					{
						text3 = "success";
						text8 = jObject4["mailRecover"].ToString();
						BC0C40BD(int_4, "cMailRecovery", text8, "mailrecovery");
					}
					if (!Convert.ToBoolean(jObject4["success"]))
					{
						text4 = "fail (" + jObject4["error"].ToString() + ")";
						method_86(int_4, jObject4["error"].ToString() + "!");
						method_96(int_4, 1);
					}
					else if (text7 != jObject4["passmail"].ToString())
					{
						text4 = "success";
						text7 = jObject4["passmail"].ToString();
						BC0C40BD(int_4, "cPassMail", text7, "passmail");
					}
				}
				end_IL_0151:;
			}
			catch (Exception exception_)
			{
				method_86(int_4, text2 + Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
				Common.ExportError(f336F52E, exception_, Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
			}
		}
		string string_ = D491BE25(int_4);
		bool flag3 = true;
		if (gclass8_1.GetValueBool("LoginHotmail") && !SettingsTool.GetSettings("configHotmail").GetValueBool("ckbCloseChrome"))
		{
			flag3 = false;
		}
		if (flag3)
		{
			try
			{
				if (f336F52E != null)
				{
					method_29(int_4, text2, f336F52E);
				}
			}
			catch
			{
			}
		}
		if (!gclass8_1.GetValueBool("LoginHotmail"))
		{
			string text12 = "";
			if (text3 != "")
			{
				text12 = text12 + "- Add mail kp: " + text3;
			}
			if (text4 != "")
			{
				text12 = text12 + "- Đổi pass: " + text4;
			}
			if (text12 != "")
			{
				string_ = text12.TrimStart(' ', '-') + "!";
			}
		}
		method_86(int_4, string_);
	}

	private void BD0A532D(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchTestSpinContent());
	}

	private void F73AFA39_Click(object sender, EventArgs e)
	{
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("GetTokenEAAAAU", true);
		DA809F35(gClass);
	}

	private void AC25898B(object sender, EventArgs e)
	{
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("GetTokenEAAAAU", true);
		gClass.GetJson("Bat2FA", true);
		DA809F35(gClass);
	}

	private void method_107(object sender, EventArgs e)
	{
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("GetTokenEAAAAU", true);
		DA809F35(gClass);
	}

	private void toolStripMenuItem_18_MouseEnter(object sender, EventArgs e)
	{
		if (!bool_4)
		{
			return;
		}
		bool_4 = false;
		toolStripMenuItem_18.DropDownItems.Clear();
		List<string> A73ADD17 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text = "";
				for (int j = 0; j < D030FA3A.RowCount; j++)
				{
					text = method_93(j, "cGhiChu");
					if (text != "")
					{
						string value = Regex.Match(text, "\\((.*?)\\)", RegexOptions.Singleline).Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						value = Regex.Match(text, "\\[(.*?)\\]").Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						if (text.StartsWith("282-") && text.Split('-').Length > 1)
						{
							text = text.Split('-')[0] + "-" + text.Split('-')[1];
						}
						if (text != "" && !A73ADD17.Contains(text))
						{
							A73ADD17.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		if (!thread.Join(5000))
		{
			thread.Abort();
		}
		for (int i = 0; i < A73ADD17.Count; i++)
		{
			toolStripMenuItem_18.DropDownItems.Add(A73ADD17[i]);
			toolStripMenuItem_18.DropDownItems[i].Click += method_108;
		}
	}

	private void method_108(object sender, EventArgs e)
	{
		method_9("cGhiChu", (sender as ToolStripMenuItem).Text);
	}

	private void method_109(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			Common.ShowForm(new fCauHinhCheckPoint());
			if (fCauHinhCheckPoint.isOK)
			{
				JSON_Settings gClass = new JSON_Settings();
				gClass.GetJson("Unlock956", true);
				gClass.GetJson("TypeUnlock956", 2);
				DA809F35(gClass);
			}
		}
	}

	private void checkStatusXproxyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckStatusXProxy());
	}

	private void F2AD3610(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			Common.ShowForm(new fImportProxy());
		}
	}

	private void method_110(object sender, EventArgs e)
	{
		if (A28928BD())
		{
			Common.ShowForm(new fImportUseragent());
		}
	}

	private void method_111(object sender, EventArgs e)
	{
		int AB871936 = 0;
		int int_0 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		SettingsTool.GetSettings("configGeneral").GetValue("token");
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_59("start");
			int num = 0;
			while (num < D030FA3A.Rows.Count && !bool_0)
			{
				if (Convert.ToBoolean(D030FA3A.Rows[num].Cells["cChose"].Value))
				{
					if (AB871936 < int_0)
					{
						Interlocked.Increment(ref AB871936);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_86(int_, Language.GetValue("Đang kiểm tra..."));
							try
							{
								string text = method_93(int_, "cEmail");
								string text2 = method_93(int_, "cPassMail");
								if (text == "" || text2 == "")
								{
									method_86(int_, Language.GetValue("Không tìm thấy mail!"));
									return;
								}
								string text3 = method_32(6, text, text2, 0, "", "");
								if (text3 != "" && text3 != "fail")
								{
									BC0C40BD(int_, "cEmail", text3, "email");
									method_86(int_, Language.GetValue("Lấy thành công!"));
								}
								else
								{
									method_86(int_, Language.GetValue("Lấy thất bại!"));
								}
							}
							catch (Exception ex)
							{
								MessageBoxHelper.Show(ex.ToString());
								method_86(int_, Language.GetValue("Lỗi!"));
							}
							Interlocked.Decrement(ref AB871936);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			_ = Environment.TickCount;
			while (AB871936 > 0)
			{
				Common.Sleep(1.0);
			}
			method_59("stop");
		}).Start();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		fChuyenThuMuc fChuyenThuMuc2 = new fChuyenThuMuc();
		Common.ShowForm(fChuyenThuMuc2);
		if (fChuyenThuMuc2.string_0 != "" && A28928BD() && MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có thực sự muốn chuyển {0} tài khoản sang thư mục [{1}]?"), lblCountSelect.Text, fChuyenThuMuc2.string_1)) == DialogResult.Yes)
		{
			CE26883A(fChuyenThuMuc2.string_0);
		}
	}

	private void toolStripMenuItem_20_Click(object sender, EventArgs e)
	{
		method_62(6, bool_5: true);
	}

	private void A51EC48F_Click(object sender, EventArgs e)
	{
		method_62(7);
	}

	private void bunifuCustomLabel1_DoubleClick(object sender, EventArgs e)
	{
		int_2++;
		if (int_2 >= 3)
		{
			int_2 = 0;
			new fCauHinhDebug().ShowDialog();
		}
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < D030FA3A.RowCount; i++)
		{
			if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
			{
				D030FA3A.Rows.RemoveAt(i--);
			}
		}
		B0A4EF35();
		method_60();
	}

	private void ckbUnlock956_CheckedChanged(object sender, EventArgs e)
	{
		lblUnlock956.Enabled = ckbUnlock956.Checked;
	}

	private void method_112(object sender, EventArgs e)
	{
	}

	private void E709EEBF(object sender, EventArgs e)
	{
		foreach (CheckBox item in list_3)
		{
			item.Checked = ckbCheckAll.Checked && item.Enabled;
		}
	}

	private string F5303017()
	{
		string text = "";
		foreach (CheckBox item in list_3)
		{
			text += (item.Checked ? (item.Text + ",") : "");
		}
		return text.TrimEnd(',');
	}

	public object method_113(string EA824CA2)
	{
		object EA9D1A3E = null;
		Invoke((MethodInvoker)delegate
		{
			string text = EA824CA2;
			string text2 = text;
			if (text2 != null)
			{
				switch (text2.Length)
				{
				case 7:
					if (text2 == "jobType")
					{
						EA9D1A3E = F5303017();
					}
					break;
				case 9:
					switch (text2[0])
					{
					case 't':
						if (text2 == "txtApiKey")
						{
							EA9D1A3E = FFA8ECA5.Text.Trim();
						}
						break;
					case 'n':
						if (text2 == "nudThread")
						{
							EA9D1A3E = nudThread.Value;
						}
						break;
					}
					break;
				case 10:
					if (text2 == "nudDelayTo")
					{
						EA9D1A3E = nudDelayTo.Value;
					}
					break;
				case 11:
					if (text2 == "cbbChangeIP")
					{
						EA9D1A3E = cbbChangeIP.SelectedIndex;
					}
					break;
				case 12:
					switch (text2[3])
					{
					case 'M':
						if (text2 == "nudMaxChrome")
						{
							EA9D1A3E = EDA3E782.Value;
						}
						break;
					case 'B':
						if (!(text2 == "ckbBreakTime"))
						{
							if (text2 == "nudBreakTime")
							{
								EA9D1A3E = nudBreakTime.Value;
							}
						}
						else
						{
							EA9D1A3E = ckbBreakTime.Checked;
						}
						break;
					case 'C':
						if (text2 == "cbbCheDoChay")
						{
							EA9D1A3E = cbbCheDoChay.SelectedIndex;
						}
						break;
					case 'D':
						if (text2 == "nudDelayFrom")
						{
							EA9D1A3E = nudDelayFrom.Value;
						}
						break;
					case 'U':
						if (text2 == "ckbUnlock956")
						{
							EA9D1A3E = ckbUnlock956.Checked;
						}
						break;
					case 'T':
						if (text2 == "cbbTypeLogin")
						{
							EA9D1A3E = cbbTypeLogin.SelectedIndex;
						}
						break;
					}
					break;
				case 14:
					switch (text2[3])
					{
					case 'M':
						if (text2 == "nudMaxJobToday")
						{
							EA9D1A3E = nudMaxJobToday.Value;
						}
						break;
					case 'D':
						if (text2 == "nudDelayGetJob")
						{
							EA9D1A3E = FFAB18BE.method_1().int_0;
						}
						break;
					case 'F':
						if (text2 == "cbbFacebookWeb")
						{
							EA9D1A3E = cbbFacebookWeb.SelectedIndex;
						}
						break;
					case 'H':
						if (text2 == "ckbHideBrowser")
						{
							EA9D1A3E = FF16D4B5.Checked;
						}
						break;
					}
					break;
				case 15:
					switch (text2[0])
					{
					case 'n':
						if (text2 == "nudBreakTimeJob")
						{
							EA9D1A3E = nudBreakTimeJob.Value;
						}
						break;
					case 'c':
						if (text2 == "cbbTypeGetToken")
						{
							EA9D1A3E = DE11733F.SelectedIndex;
						}
						break;
					}
					break;
				case 20:
					switch (text2[0])
					{
					case 'n':
						if (text2 == "nudDelayOpenChromeTo")
						{
							EA9D1A3E = DDBC7438.Value;
						}
						break;
					case 'c':
						if (text2 == "ckbShowImageInteract")
						{
							EA9D1A3E = ckbShowImageInteract.Checked;
						}
						break;
					}
					break;
				case 21:
					if (text2 == "nudMaxJobFailLienTiep")
					{
						EA9D1A3E = BA05D285.Value;
					}
					break;
				case 22:
					if (text2 == "nudDelayOpenChromeFrom")
					{
						EA9D1A3E = C481F21A.Value;
					}
					break;
				case 8:
				case 13:
				case 16:
				case 17:
				case 18:
				case 19:
					break;
				}
			}
		});
		return EA9D1A3E;
	}

	public int method_114()
	{
		return BFACE4AB;
	}

	public void method_115()
	{
		if (BFACE4AB != 0)
		{
			BFACE4AB--;
			F01E7E36();
		}
	}

	public void E01D903C()
	{
		BFACE4AB++;
		F01E7E36();
	}

	private void F01E7E36()
	{
		try
		{
			Invoke((MethodInvoker)delegate
			{
				lblCountChrome.Text = BFACE4AB.ToString();
			});
		}
		catch (Exception)
		{
		}
	}

	private void method_116()
	{
		try
		{
			Invoke((MethodInvoker)delegate
			{
				B6218EA3.Text = dictionary_27.Count.ToString();
			});
		}
		catch
		{
		}
	}

	private void method_117(int int_4)
	{
		dictionary_27.Add(int_4, new JobGolikeHepler(this, int_4));
		try
		{
			dictionary_27[int_4].method_3();
			method_116();
		}
		catch (Exception)
		{
		}
	}

	public void method_118(int int_4)
	{
		try
		{
			dictionary_27.Remove(int_4);
			if (dictionary_27.Count == 0)
			{
				DatagridviewHelper.smethod_0(D030FA3A, bool_0: true);
				Class64.smethod_0(plQuanLyThuMuc, bool_0: true, EA33DE2B: true);
			}
			method_116();
		}
		catch (Exception)
		{
		}
	}

	private void btnInteract_Click(object sender, EventArgs e)
	{
		bool_0 = false;
		method_5();
		if (!A28928BD())
		{
			return;
		}
		DatagridviewHelper.smethod_0(D030FA3A, bool_0: false);
		Class64.smethod_0(plQuanLyThuMuc, bool_0: false, EA33DE2B: false);
		int_3 = 0;
		new Thread((ThreadStart)delegate
		{
			try
			{
				Class64.smethod_0(btnInteract, bool_0: false, EA33DE2B: true);
				for (int i = 0; i < D030FA3A.RowCount; i++)
				{
					if (bool_0)
					{
						break;
					}
					if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value) && !dictionary_27.ContainsKey(i))
					{
						if ((decimal)dictionary_27.Count >= nudThread.Value)
						{
							Common.Sleep(1.0);
							i--;
						}
						else
						{
							if (bool_0)
							{
								break;
							}
							method_117(i);
							Common.Sleep(0.1);
						}
					}
				}
				Class64.smethod_0(btnInteract, bool_0: true, EA33DE2B: true);
			}
			catch (Exception ex)
			{
				MessageBoxHelper.Show("btnInteract_Click\n" + ex.ToString());
			}
		}).Start();
	}

	private void method_119(Control control_0)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string string_0 = control_0.Text;
				control_0.Invoke((MethodInvoker)delegate
				{
					control_0.Enabled = false;
				});
				int int_0 = 5;
				int E6007922 = Environment.TickCount;
				while ((Environment.TickCount - E6007922) / 1000 - int_0 < 0)
				{
					control_0.Invoke((MethodInvoker)delegate
					{
						control_0.Text = "Đợi " + (int_0 - (Environment.TickCount - E6007922) / 1000) + "s...";
					});
					Common.Sleep(0.5);
				}
				control_0.Invoke((MethodInvoker)delegate
				{
					control_0.Text = string_0;
					control_0.Enabled = true;
				});
			}
			catch (Exception)
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void B68285B2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void DE11733F_SelectedIndexChanged(object sender, EventArgs e)
	{
		grCauHinhChrome.Enabled = DE11733F.SelectedIndex == 0;
	}

	private void F108D019(object sender, EventArgs e)
	{
		string text = FFA8ECA5.Text.Trim();
		string text2 = GClass17.smethod_0(text);
		MessageBoxHelper.Show(text2);
	}

	private void lblUnlock956_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fCauHinhCheckPoint());
	}

	private void D78B21AF(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_119(sender as Control);
		for (int i = 0; i < D030FA3A.Rows.Count; i++)
		{
			if (Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value))
			{
				int key = i;
				if (dictionary_27.ContainsKey(key))
				{
					dictionary_27[key].method_7();
				}
			}
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		method_119(sender as Control);
		foreach (KeyValuePair<int, JobGolikeHepler> item in dictionary_27)
		{
			item.Value.method_7();
		}
		bool_0 = true;
	}

	private void C8183AA3(object sender, EventArgs e)
	{
		if (btnHienCaiDat.Text == "Hiện cài đặt")
		{
			gclass8_0.GetJson("hideSettings", false);
			btnHienCaiDat.Text = "Ẩn cài đặt";
			D030FA3A.Location = new Point(D030FA3A.Location.X, D030FA3A.Location.Y + 216);
			D030FA3A.Size = new Size(D030FA3A.Size.Width, D030FA3A.Size.Height - 216);
		}
		else
		{
			gclass8_0.GetJson("hideSettings", true);
			btnHienCaiDat.Text = "Hiện cài đặt";
			D030FA3A.Location = new Point(D030FA3A.Location.X, D030FA3A.Location.Y - 216);
			D030FA3A.Size = new Size(D030FA3A.Size.Width, D030FA3A.Size.Height + 216);
		}
	}

	private void cbbCheDoChay_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (cbbCheDoChay.SelectedIndex)
		{
		case 0:
		{
			for (int j = 0; j < list_3.Count; j++)
			{
				list_3[j].Enabled = true;
			}
			break;
		}
		case 1:
		{
			List<string> list = new List<string> { "like", "comment", "share", "like_comment" };
			for (int i = 0; i < list_3.Count; i++)
			{
				if (!list.Contains(list_3[i].Text))
				{
					list_3[i].Checked = false;
					list_3[i].Enabled = false;
				}
			}
			break;
		}
		}
	}

	private void checkGolikeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchGolike2());
	}

	private void ckbBreakTime_CheckedChanged(object sender, EventArgs e)
	{
		AB39C701.Enabled = ckbBreakTime.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGolike));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		this.ctmsAcc = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.BFB97634 = new System.Windows.Forms.ToolStripMenuItem();
		this.FD2AC222 = new System.Windows.Forms.ToolStripMenuItem();
		this.C385F93D = new System.Windows.Forms.ToolStripMenuItem();
		this.tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EC2D66B3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.C8B5958B = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.C52A61A1 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.BA1A38BA = new System.Windows.Forms.ToolStripMenuItem();
		this.emailPassMailMailKpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.D29578BE = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieMailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EDBEA69E = new System.Windows.Forms.ToolStripMenuItem();
		this.B831D839 = new System.Windows.Forms.ToolStripMenuItem();
		this.proxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.B615D829 = new System.Windows.Forms.ToolStripMenuItem();
		this.B02B2108 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.E8AA4812 = new System.Windows.Forms.ToolStripMenuItem();
		this.C4973C30 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_19 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_20 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EA9F931E = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
		this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.locTrungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.C1266B0F = new System.Windows.Forms.ToolStripMenuItem();
		this.A51EC48F = new System.Windows.Forms.ToolStripMenuItem();
		this.ED10C803 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EB88070A = new System.Windows.Forms.ToolStripMenuItem();
		this.FFB9D70A = new System.Windows.Forms.ToolStripMenuItem();
		this.F18F9E83 = new System.Windows.Forms.ToolStripMenuItem();
		this.E80102B9 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.F73AFA39 = new System.Windows.Forms.ToolStripMenuItem();
		this.getTokenEAAAAUBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C1931ABB = new System.Windows.Forms.Button();
		this.btnMaximize = new System.Windows.Forms.Button();
		this.btnClose = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		this.toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		this.A023B3BA = new System.Windows.Forms.ToolStripMenuItem();
		this.DF895BAD = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkHotmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.A19CDB1C = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkStatusXproxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.C90731BD = new System.Windows.Forms.ToolStripMenuItem();
		this.checkGolikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.A22FCD01 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.AddFileAccount = new System.Windows.Forms.Button();
		this.C9344F86 = new System.Windows.Forms.Button();
		this.btnEditFile = new System.Windows.Forms.Button();
		this.btnLoadAcc = new System.Windows.Forms.Button();
		this.btnInteract = new System.Windows.Forms.Button();
		this.plTrangThai = new System.Windows.Forms.Panel();
		this.AE250EB9 = new System.Windows.Forms.Label();
		this.miniToolStrip = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		this.A0976198 = new System.Windows.Forms.ToolStripStatusLabel();
		this.F0AC1D35 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountSelect = new System.Windows.Forms.ToolStripStatusLabel();
		this.AE8CEF20 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		this.metroButton1 = new System.Windows.Forms.Button();
		this.A7A6E116 = new System.Windows.Forms.Panel();
		this.C60C5426 = new System.Windows.Forms.Button();
		this.AE25A29C = new System.Windows.Forms.ComboBox();
		this.AA21FF22 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		this.plQuanLyThuMuc = new System.Windows.Forms.Panel();
		this.EDBCFD26 = new System.Windows.Forms.ComboBox();
		this.FE9A040E = new System.Windows.Forms.Label();
		this.button9 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.D68F8BB7 = new System.Windows.Forms.ComboBox();
		this.B68285B2 = new System.Windows.Forms.Panel();
		this.D030FA3A = new System.Windows.Forms.DataGridView();
		this.B03820BB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.D0BA988C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cEmail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.A1910C2B = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPagePro5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.BF07A8B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUseragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cDateCreateAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C3840526 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.EF902E9F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStatus282 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.B11E23A8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cHometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cCurrentCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.AEAE4632 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.EC8E7E16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.A78524B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cWallPosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D5AC983B = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.AB39C701 = new System.Windows.Forms.Panel();
		this.nudBreakTimeJob = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.nudBreakTime = new System.Windows.Forms.NumericUpDown();
		this.ckbBreakTime = new System.Windows.Forms.CheckBox();
		this.F52CE993 = new System.Windows.Forms.Button();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudMaxJobToday = new System.Windows.Forms.NumericUpDown();
		this.nudDelayGetJob = new System.Windows.Forms.NumericUpDown();
		this.BA05D285 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.E13363B0 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.BA00D8A9 = new System.Windows.Forms.Label();
		this.cbbCheDoChay = new System.Windows.Forms.ComboBox();
		this.DE11733F = new System.Windows.Forms.ComboBox();
		this.lblUnlock956 = new System.Windows.Forms.LinkLabel();
		this.label10 = new System.Windows.Forms.Label();
		this.ckbUnlock956 = new System.Windows.Forms.CheckBox();
		this.label5 = new System.Windows.Forms.Label();
		this.FFA8ECA5 = new System.Windows.Forms.TextBox();
		this.DF92EF15 = new System.Windows.Forms.Label();
		this.nudThread = new System.Windows.Forms.NumericUpDown();
		this.cbbChangeIP = new System.Windows.Forms.ComboBox();
		this.label9 = new System.Windows.Forms.Label();
		this.grCauHinhChrome = new System.Windows.Forms.GroupBox();
		this.DDBC7438 = new System.Windows.Forms.NumericUpDown();
		this.EDA3E782 = new System.Windows.Forms.NumericUpDown();
		this.C481F21A = new System.Windows.Forms.NumericUpDown();
		this.B38D3A0B = new System.Windows.Forms.Label();
		this.cbbTypeLogin = new System.Windows.Forms.ComboBox();
		this.label16 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.ADB609AA = new System.Windows.Forms.Label();
		this.button6 = new System.Windows.Forms.Button();
		this.cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		this.label29 = new System.Windows.Forms.Label();
		this.E8A87D36 = new System.Windows.Forms.Button();
		this.FF16D4B5 = new System.Windows.Forms.CheckBox();
		this.ckbShowImageInteract = new System.Windows.Forms.CheckBox();
		this.label17 = new System.Windows.Forms.Label();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.FCAD272E = new System.Windows.Forms.GroupBox();
		this.ckbCheckAll = new System.Windows.Forms.CheckBox();
		this.ckbFollow = new System.Windows.Forms.CheckBox();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.ckbShare = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.C69FE504 = new System.Windows.Forms.CheckBox();
		this.ckbSad = new System.Windows.Forms.CheckBox();
		this.ckbLikeComment = new System.Windows.Forms.CheckBox();
		this.ckbLove = new System.Windows.Forms.CheckBox();
		this.ckbJoinGroup = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbCare = new System.Windows.Forms.CheckBox();
		this.ckbAngry = new System.Windows.Forms.CheckBox();
		this.btnHienCaiDat = new System.Windows.Forms.Button();
		this.AC8B928D = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.B6218EA3 = new System.Windows.Forms.ToolStripStatusLabel();
		this.CB82F694 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountChrome = new System.Windows.Forms.ToolStripStatusLabel();
		this.ctmsAcc.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		this.plTrangThai.SuspendLayout();
		this.A7A6E116.SuspendLayout();
		this.plQuanLyThuMuc.SuspendLayout();
		this.B68285B2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D030FA3A).BeginInit();
		this.groupBox1.SuspendLayout();
		this.AB39C701.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudBreakTimeJob).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudBreakTime).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudMaxJobToday).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayGetJob).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.BA05D285).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThread).BeginInit();
		this.grCauHinhChrome.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DDBC7438).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EDA3E782).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C481F21A).BeginInit();
		this.FCAD272E.SuspendLayout();
		this.AC8B928D.SuspendLayout();
		base.SuspendLayout();
		this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[13]
		{
			this.BFB97634, this.toolStripMenuItem_2, this.C8B5958B, this.toolStripMenuItem1, this.C52A61A1, this.B615D829, this.toolStripMenuItem_0, this.checkCookieToolStripMenuItem, this.toolStripMenuItem_6, this.toolStripMenuItem_1,
			this.mnuChucNang, this.ED10C803, this.toolStripMenuItem_5
		});
		this.ctmsAcc.Name = "ctmsAcc";
		this.ctmsAcc.Size = new System.Drawing.Size(181, 290);
		this.ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(C9187631);
		this.BFB97634.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.FD2AC222, this.C385F93D, this.tinhTrangToolStripMenuItem, this.EC2D66B3, this.toolStripMenuItem_17, this.toolStripMenuItem_18 });
		this.BFB97634.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		this.BFB97634.Name = "chọnLiveToolStripMenuItem";
		this.BFB97634.Size = new System.Drawing.Size(180, 22);
		this.BFB97634.Text = "Chọn";
		this.FD2AC222.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		this.FD2AC222.Name = "tấtCảToolStripMenuItem";
		this.FD2AC222.Size = new System.Drawing.Size(128, 22);
		this.FD2AC222.Text = "Tất cả";
		this.FD2AC222.Click += new System.EventHandler(FD2AC222_Click);
		this.C385F93D.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		this.C385F93D.Name = "liveToolStripMenuItem";
		this.C385F93D.Size = new System.Drawing.Size(128, 22);
		this.C385F93D.Text = "Bôi đen";
		this.C385F93D.Click += new System.EventHandler(D829AA95);
		this.tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		this.tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
		this.tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		this.EC2D66B3.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		this.EC2D66B3.Name = "trạngTháiToolStripMenuItem";
		this.EC2D66B3.Size = new System.Drawing.Size(128, 22);
		this.EC2D66B3.Text = "Trạng thái";
		this.EC2D66B3.Click += new System.EventHandler(EC2D66B3_Click);
		this.toolStripMenuItem_17.Image = Resources.CFBEC037;
		this.toolStripMenuItem_17.Name = "chDanhSáchTheoUIDEmailToolStripMenuItem";
		this.toolStripMenuItem_17.Size = new System.Drawing.Size(128, 22);
		this.toolStripMenuItem_17.Text = "Theo Uid";
		this.toolStripMenuItem_17.Click += new System.EventHandler(B0B36437);
		this.toolStripMenuItem_18.Image = (System.Drawing.Image)resources.GetObject("ghiChúToolStripMenuItem.Image");
		this.toolStripMenuItem_18.Name = "ghiChúToolStripMenuItem";
		this.toolStripMenuItem_18.Size = new System.Drawing.Size(128, 22);
		this.toolStripMenuItem_18.Text = "Ghi chu\u0301";
		this.toolStripMenuItem_18.MouseEnter += new System.EventHandler(toolStripMenuItem_18_MouseEnter);
		this.toolStripMenuItem_2.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		this.toolStripMenuItem_2.Name = "bỏChọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_2.Text = "Bỏ chọn tất cả";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.C8B5958B.Image = Resources.Bitmap_89;
		this.C8B5958B.Name = "ẩnKhỏiDanhSachToolStripMenuItem";
		this.C8B5958B.Size = new System.Drawing.Size(180, 22);
		this.C8B5958B.Text = "Ẩn dòng tích chọn";
		this.C8B5958B.Click += new System.EventHandler(C8B5958B_Click);
		this.toolStripMenuItem1.Image = Resources.Bitmap_89;
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem1.Text = "Ẩn dòng không tích";
		this.toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
		this.C52A61A1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[17]
		{
			this.uidToolStripMenuItem, this.passToolStripMenuItem, this.tokenToolStripMenuItem, this.cookieToolStripMenuItem, this.mailToolStripMenuItem, this.fAToolStripMenuItem, this.toolStripMenuItem_8, this.uidPassToolStripMenuItem, this.uidPass2FaToolStripMenuItem, this.BA1A38BA,
			this.emailPassMailMailKpToolStripMenuItem, this.D29578BE, this.uidPassTokenCookieMailPassMailToolStripMenuItem, this.EDBEA69E, this.B831D839, this.proxyToolStripMenuItem1, this.toolStripMenuItem_7
		});
		this.C52A61A1.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		this.C52A61A1.Name = "copyToolStripMenuItem";
		this.C52A61A1.Size = new System.Drawing.Size(180, 22);
		this.C52A61A1.Text = "Copy";
		this.uidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		this.uidToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidToolStripMenuItem.Text = "Uid";
		this.uidToolStripMenuItem.Click += new System.EventHandler(uidToolStripMenuItem_Click);
		this.passToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		this.passToolStripMenuItem.Name = "passToolStripMenuItem";
		this.passToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.passToolStripMenuItem.Text = "Pass";
		this.passToolStripMenuItem.Click += new System.EventHandler(F099B437);
		this.tokenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		this.tokenToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.tokenToolStripMenuItem.Text = "Token";
		this.tokenToolStripMenuItem.Click += new System.EventHandler(tokenToolStripMenuItem_Click);
		this.cookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
		this.cookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.cookieToolStripMenuItem.Text = "Cookie";
		this.cookieToolStripMenuItem.Click += new System.EventHandler(cookieToolStripMenuItem_Click);
		this.mailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
		this.mailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.mailToolStripMenuItem.Text = "Email";
		this.mailToolStripMenuItem.Click += new System.EventHandler(mailToolStripMenuItem_Click);
		this.fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		this.fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		this.fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.fAToolStripMenuItem.Text = "2FA";
		this.fAToolStripMenuItem.Click += new System.EventHandler(fAToolStripMenuItem_Click);
		this.toolStripMenuItem_8.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		this.toolStripMenuItem_8.Name = "maBaoMât6SôToolStripMenuItem";
		this.toolStripMenuItem_8.Size = new System.Drawing.Size(289, 22);
		this.toolStripMenuItem_8.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301 từ 2FA";
		this.toolStripMenuItem_8.Click += new System.EventHandler(AF847F9F);
		this.uidPassToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
		this.uidPassToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassToolStripMenuItem.Text = "Uid|Pass";
		this.uidPassToolStripMenuItem.Click += new System.EventHandler(uidPassToolStripMenuItem_Click);
		this.uidPass2FaToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		this.uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
		this.uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		this.uidPass2FaToolStripMenuItem.Click += new System.EventHandler(D50AB197);
		this.BA1A38BA.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		this.BA1A38BA.Name = "mailPassMailToolStripMenuItem";
		this.BA1A38BA.Size = new System.Drawing.Size(289, 22);
		this.BA1A38BA.Text = "Mail|Pass mail";
		this.BA1A38BA.Click += new System.EventHandler(D4926BAB);
		this.emailPassMailMailKpToolStripMenuItem.Image = Resources.Bitmap_152;
		this.emailPassMailMailKpToolStripMenuItem.Name = "emailPassMailMailKpToolStripMenuItem";
		this.emailPassMailMailKpToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.emailPassMailMailKpToolStripMenuItem.Text = "Email|PassMail|MailKp";
		this.emailPassMailMailKpToolStripMenuItem.Click += new System.EventHandler(emailPassMailMailKpToolStripMenuItem_Click);
		this.D29578BE.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		this.D29578BE.Name = "uidPassTokenCookieToolStripMenuItem";
		this.D29578BE.Size = new System.Drawing.Size(289, 22);
		this.D29578BE.Text = "Uid|Pass|Token|Cookie";
		this.D29578BE.Click += new System.EventHandler(D29578BE_Click);
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		this.uidPassTokenCookieMailPassMailToolStripMenuItem.Click += new System.EventHandler(DB14BA87);
		this.EDBEA69E.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		this.EDBEA69E.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		this.EDBEA69E.Size = new System.Drawing.Size(289, 22);
		this.EDBEA69E.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		this.EDBEA69E.Click += new System.EventHandler(EDBEA69E_Click);
		this.B831D839.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		this.B831D839.Name = "useragentToolStripMenuItem1";
		this.B831D839.Size = new System.Drawing.Size(289, 22);
		this.B831D839.Text = "Useragent";
		this.B831D839.Click += new System.EventHandler(B831D839_Click);
		this.proxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		this.proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
		this.proxyToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
		this.proxyToolStripMenuItem1.Text = "Proxy";
		this.proxyToolStripMenuItem1.Click += new System.EventHandler(proxyToolStripMenuItem1_Click);
		this.toolStripMenuItem_7.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		this.toolStripMenuItem_7.Name = "đinhDangKhacToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(289, 22);
		this.toolStripMenuItem_7.Text = "Other...";
		this.toolStripMenuItem_7.Click += new System.EventHandler(AF3EB901);
		this.B615D829.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.B02B2108, this.toolStripMenuItem_13 });
		this.B615D829.Image = (System.Drawing.Image)resources.GetObject("mởTrìnhDuyệtToolStripMenuItem.Image");
		this.B615D829.Name = "mởTrìnhDuyệtToolStripMenuItem";
		this.B615D829.Size = new System.Drawing.Size(180, 22);
		this.B615D829.Text = "Mở trình duyệt";
		this.B02B2108.Name = "mởLuônToolStripMenuItem";
		this.B02B2108.Size = new System.Drawing.Size(181, 22);
		this.B02B2108.Text = "Tiến hành mở";
		this.B02B2108.Click += new System.EventHandler(B02B2108_Click);
		this.toolStripMenuItem_13.Name = "càiĐặtCấuHìnhMởToolStripMenuItem";
		this.toolStripMenuItem_13.Size = new System.Drawing.Size(181, 22);
		this.toolStripMenuItem_13.Text = "Cài đặt cấu hình mở";
		this.toolStripMenuItem_13.Click += new System.EventHandler(toolStripMenuItem_13_Click);
		this.toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("xóaTàiKhoảnToolStripMenuItem.Image");
		this.toolStripMenuItem_0.Name = "xóaTàiKhoảnToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_0.Text = "Xóa ta\u0300i khoa\u0309n";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.E8AA4812, this.C4973C30, this.toolStripMenuItem_4, this.toolStripMenuItem_3, this.checkAvatarToolStripMenuItem, this.checkProfileToolStripMenuItem1, this.toolStripMenuItem_10, this.checkProxyToolStripMenuItem, this.EA9F931E });
		this.checkCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
		this.checkCookieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
		this.checkCookieToolStripMenuItem.Click += new System.EventHandler(checkCookieToolStripMenuItem_Click);
		this.E8AA4812.Name = "kiểmTraWallToolStripMenuItem";
		this.E8AA4812.Size = new System.Drawing.Size(199, 22);
		this.E8AA4812.Text = "Check Wall";
		this.E8AA4812.ToolTipText = "Không cần dùng token";
		this.E8AA4812.Click += new System.EventHandler(BA0DD9BE);
		this.C4973C30.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_15, this.toolStripMenuItem_16 });
		this.C4973C30.Name = "checkInfoUIDToolStripMenuItem";
		this.C4973C30.Size = new System.Drawing.Size(199, 22);
		this.C4973C30.Text = "Check Info Uid";
		this.C4973C30.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		this.toolStripMenuItem_15.Name = "sửDụngIPMáyToolStripMenuItem";
		this.toolStripMenuItem_15.Size = new System.Drawing.Size(190, 22);
		this.toolStripMenuItem_15.Text = "Không đổi IP";
		this.toolStripMenuItem_15.Click += new System.EventHandler(B307AC95);
		this.toolStripMenuItem_16.Name = "sửDụngProxyĐãGánToolStripMenuItem";
		this.toolStripMenuItem_16.Size = new System.Drawing.Size(190, 22);
		this.toolStripMenuItem_16.Text = "Sử dụng proxy đã gán";
		this.toolStripMenuItem_16.Click += new System.EventHandler(toolStripMenuItem_16_Click);
		this.toolStripMenuItem_4.Name = "kiểmTraTokenToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_4.Text = "Check Token";
		this.toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		this.toolStripMenuItem_3.Name = "kiểmTraCookieToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_3.Text = "Check Cookie";
		this.toolStripMenuItem_3.Click += new System.EventHandler(F2357DAD);
		this.checkAvatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_19, this.toolStripMenuItem_20 });
		this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		this.checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
		this.toolStripMenuItem_19.Name = "khôngĐổiIPToolStripMenuItem";
		this.toolStripMenuItem_19.Size = new System.Drawing.Size(190, 22);
		this.toolStripMenuItem_19.Text = "Không đổi IP";
		this.toolStripMenuItem_19.Click += new System.EventHandler(EBAB703A);
		this.toolStripMenuItem_20.Name = "sửDụngProxyĐãGánToolStripMenuItem1";
		this.toolStripMenuItem_20.Size = new System.Drawing.Size(190, 22);
		this.toolStripMenuItem_20.Text = "Sử dụng proxy đã gán";
		this.toolStripMenuItem_20.Click += new System.EventHandler(toolStripMenuItem_20_Click);
		this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
		this.checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
		this.checkProfileToolStripMenuItem1.Text = "Check Profile";
		this.checkProfileToolStripMenuItem1.Click += new System.EventHandler(EE05D28C);
		this.toolStripMenuItem_10.Name = "kiểmTraMailpassMailToolStripMenuItem";
		this.toolStripMenuItem_10.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_10.Text = "Check Connect hotmail";
		this.toolStripMenuItem_10.Click += new System.EventHandler(toolStripMenuItem_10_Click);
		this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
		this.checkProxyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		this.checkProxyToolStripMenuItem.Text = "Check Proxy";
		this.checkProxyToolStripMenuItem.Click += new System.EventHandler(checkProxyToolStripMenuItem_Click);
		this.EA9F931E.Name = "checkBackupToolStripMenuItem1";
		this.EA9F931E.Size = new System.Drawing.Size(199, 22);
		this.EA9F931E.Text = "Check Backup (ẩn)";
		this.EA9F931E.Click += new System.EventHandler(C6AFB38F);
		this.toolStripMenuItem_6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.toolStripMenuItem_12 });
		this.toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("cậpNhậtDữLiệuToolStripMenuItem.Image");
		this.toolStripMenuItem_6.Name = "cậpNhậtDữLiệuToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_6.Text = "Cập nhật dữ liệu";
		this.toolStripMenuItem_12.Image = (System.Drawing.Image)resources.GetObject("cậpToolStripMenuItem.Image");
		this.toolStripMenuItem_12.Name = "cậpToolStripMenuItem";
		this.toolStripMenuItem_12.Size = new System.Drawing.Size(175, 22);
		this.toolStripMenuItem_12.Text = "Cập nhật hàng loạt";
		this.toolStripMenuItem_12.Click += new System.EventHandler(C8095A13);
		this.toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("chuyểnThưMụcToolStripMenuItem.Image");
		this.toolStripMenuItem_1.Name = "chuyểnThưMụcToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_1.Text = "Chuyển thư mục";
		this.toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.lToolStripMenuItem, this.locTrungToolStripMenuItem, this.C1266B0F, this.A51EC48F });
		this.mnuChucNang.Image = (System.Drawing.Image)resources.GetObject("mnuChucNang.Image");
		this.mnuChucNang.Name = "mnuChucNang";
		this.mnuChucNang.Size = new System.Drawing.Size(180, 22);
		this.mnuChucNang.Text = "Chức năng";
		this.lToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("lToolStripMenuItem.Image");
		this.lToolStripMenuItem.Name = "lToolStripMenuItem";
		this.lToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
		this.lToolStripMenuItem.Text = "Lọc tài khoản theo Uid";
		this.lToolStripMenuItem.Click += new System.EventHandler(FD0F411A);
		this.locTrungToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("locTrungToolStripMenuItem.Image");
		this.locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
		this.locTrungToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
		this.locTrungToolStripMenuItem.Text = "Lọc tài khoản trùng nhau";
		this.locTrungToolStripMenuItem.Click += new System.EventHandler(locTrungToolStripMenuItem_Click);
		this.C1266B0F.Image = Resources.AEB9F726;
		this.C1266B0F.Name = "xóaTàiKhoảnTrùngNhauToolStripMenuItem";
		this.C1266B0F.Size = new System.Drawing.Size(208, 22);
		this.C1266B0F.Text = "Xóa tài khoản trùng nhau";
		this.C1266B0F.Click += new System.EventHandler(DB8661AF);
		this.A51EC48F.Image = Resources.Bitmap_62;
		this.A51EC48F.Name = "checkNameVNToolStripMenuItem";
		this.A51EC48F.Size = new System.Drawing.Size(208, 22);
		this.A51EC48F.Text = "Check name VN";
		this.A51EC48F.Click += new System.EventHandler(A51EC48F_Click);
		this.ED10C803.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.checkProfileToolStripMenuItem, this.EB88070A, this.FFB9D70A, this.F18F9E83, this.E80102B9 });
		this.ED10C803.Image = (System.Drawing.Image)resources.GetObject("profileToolStripMenuItem.Image");
		this.ED10C803.Name = "profileToolStripMenuItem";
		this.ED10C803.Size = new System.Drawing.Size(180, 22);
		this.ED10C803.Text = "Profile Chrome";
		this.checkProfileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkProfileToolStripMenuItem.Image");
		this.checkProfileToolStripMenuItem.Name = "checkProfileToolStripMenuItem";
		this.checkProfileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
		this.checkProfileToolStripMenuItem.Text = "Check profile";
		this.checkProfileToolStripMenuItem.Click += new System.EventHandler(EE05D28C);
		this.EB88070A.Image = (System.Drawing.Image)resources.GetObject("xóaProfileToolStripMenuItem.Image");
		this.EB88070A.Name = "xóaProfileToolStripMenuItem";
		this.EB88070A.Size = new System.Drawing.Size(167, 22);
		this.EB88070A.Text = "Xóa profile";
		this.EB88070A.Click += new System.EventHandler(F118D3BF);
		this.FFB9D70A.Image = (System.Drawing.Image)resources.GetObject("donDepProfileToolStripMenuItem.Image");
		this.FFB9D70A.Name = "donDepProfileToolStripMenuItem";
		this.FFB9D70A.Size = new System.Drawing.Size(167, 22);
		this.FFB9D70A.Text = "Do\u0323n de\u0323p profile";
		this.FFB9D70A.Click += new System.EventHandler(FFB9D70A_Click);
		this.F18F9E83.Image = (System.Drawing.Image)resources.GetObject("xóaCacheToolStripMenuItem.Image");
		this.F18F9E83.Name = "xóaCacheToolStripMenuItem";
		this.F18F9E83.Size = new System.Drawing.Size(167, 22);
		this.F18F9E83.Text = "Xóa Cache Profile";
		this.F18F9E83.Click += new System.EventHandler(F18F9E83_Click);
		this.E80102B9.Image = (System.Drawing.Image)resources.GetObject("copyProfileToolStripMenuItem.Image");
		this.E80102B9.Name = "copyProfileToolStripMenuItem";
		this.E80102B9.Size = new System.Drawing.Size(167, 22);
		this.E80102B9.Text = "Copy Profile";
		this.E80102B9.Click += new System.EventHandler(E80102B9_Click);
		this.toolStripMenuItem_5.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		this.toolStripMenuItem_5.Name = "tảiLạiDanhSáchToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(180, 22);
		this.toolStripMenuItem_5.Text = "Tải lại danh sách";
		this.toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		this.F73AFA39.Name = "getTokenEAAAAUToolStripMenuItem";
		this.F73AFA39.Size = new System.Drawing.Size(253, 22);
		this.F73AFA39.Text = "Get Token EAAAAU";
		this.F73AFA39.Click += new System.EventHandler(F73AFA39_Click);
		this.getTokenEAAAAUBToolStripMenuItem.Name = "getTokenEAAAAUBToolStripMenuItem";
		this.getTokenEAAAAUBToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		this.getTokenEAAAAUBToolStripMenuItem.Text = "Get Token EAAAAU + Bật 2FA";
		this.getTokenEAAAAUBToolStripMenuItem.Click += new System.EventHandler(AC25898B);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.C1931ABB);
		this.pnlHeader.Controls.Add(this.btnMaximize);
		this.pnlHeader.Controls.Add(this.btnClose);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(2, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1081, 29);
		this.pnlHeader.TabIndex = 0;
		this.pnlHeader.DoubleClick += new System.EventHandler(pnlHeader_DoubleClick);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(6, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.pictureBox1.DoubleClick += new System.EventHandler(pictureBox1_DoubleClick);
		this.C1931ABB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C1931ABB.Dock = System.Windows.Forms.DockStyle.Right;
		this.C1931ABB.FlatAppearance.BorderSize = 0;
		this.C1931ABB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C1931ABB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C1931ABB.ForeColor = System.Drawing.Color.White;
		this.C1931ABB.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.C1931ABB.Location = new System.Drawing.Point(985, 0);
		this.C1931ABB.Name = "btnMinimize";
		this.C1931ABB.Size = new System.Drawing.Size(32, 29);
		this.C1931ABB.TabIndex = 0;
		this.C1931ABB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C1931ABB.UseVisualStyleBackColor = true;
		this.C1931ABB.Click += new System.EventHandler(C1931ABB_Click);
		this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMaximize.FlatAppearance.BorderSize = 0;
		this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMaximize.ForeColor = System.Drawing.Color.White;
		this.btnMaximize.Image = (System.Drawing.Image)resources.GetObject("btnMaximize.Image");
		this.btnMaximize.Location = new System.Drawing.Point(1017, 0);
		this.btnMaximize.Name = "btnMaximize";
		this.btnMaximize.Size = new System.Drawing.Size(32, 29);
		this.btnMaximize.TabIndex = 1;
		this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMaximize.UseVisualStyleBackColor = true;
		this.btnMaximize.Click += new System.EventHandler(btnMaximize_Click);
		this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnClose.FlatAppearance.BorderSize = 0;
		this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnClose.ForeColor = System.Drawing.Color.White;
		this.btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		this.btnClose.Location = new System.Drawing.Point(1049, 0);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new System.Drawing.Size(32, 29);
		this.btnClose.TabIndex = 2;
		this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnClose.UseVisualStyleBackColor = true;
		this.btnClose.Click += new System.EventHandler(B92415BB);
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 16);
		this.bunifuCustomLabel1.TabIndex = 3;
		this.bunifuCustomLabel1.Text = "Kiếm tiền Golike";
		this.bunifuCustomLabel1.DoubleClick += new System.EventHandler(bunifuCustomLabel1_DoubleClick);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1084, 38);
		this.bunifuCards1.TabIndex = 0;
		this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.menuStrip1.AutoSize = false;
		this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_9, this.A023B3BA, this.toolStripMenuItem_14 });
		this.menuStrip1.Location = new System.Drawing.Point(1, 37);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.menuStrip1.Size = new System.Drawing.Size(1082, 25);
		this.menuStrip1.Stretch = false;
		this.menuStrip1.TabIndex = 1;
		this.menuStrip1.Text = "menuStrip1";
		this.toolStripMenuItem_9.Image = (System.Drawing.Image)resources.GetObject("thoátToolStripMenuItem.Image");
		this.toolStripMenuItem_9.Name = "thoátToolStripMenuItem";
		this.toolStripMenuItem_9.Size = new System.Drawing.Size(131, 21);
		this.toolStripMenuItem_9.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		this.toolStripMenuItem_9.Click += new System.EventHandler(toolStripMenuItem_9_Click);
		this.A023B3BA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.DF895BAD, this.checkProxyToolStripMenuItem1, this.checkHotmailToolStripMenuItem, this.A19CDB1C, this.toolStripMenuItem_11, this.checkStatusXproxyToolStripMenuItem, this.C90731BD, this.checkGolikeToolStripMenuItem });
		this.A023B3BA.Image = (System.Drawing.Image)resources.GetObject("tiệnÍchToolStripMenuItem.Image");
		this.A023B3BA.Name = "tiệnÍchToolStripMenuItem";
		this.A023B3BA.Size = new System.Drawing.Size(80, 21);
		this.A023B3BA.Text = "Tiện ích";
		this.DF895BAD.Image = (System.Drawing.Image)resources.GetObject("checkLiveUidToolStripMenuItem.Image");
		this.DF895BAD.Name = "checkLiveUidToolStripMenuItem";
		this.DF895BAD.Size = new System.Drawing.Size(204, 22);
		this.DF895BAD.Text = "Check Live Uid";
		this.DF895BAD.Click += new System.EventHandler(DF895BAD_Click);
		this.checkProxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("checkProxyToolStripMenuItem1.Image");
		this.checkProxyToolStripMenuItem1.Name = "checkProxyToolStripMenuItem1";
		this.checkProxyToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
		this.checkProxyToolStripMenuItem1.Text = "Check Proxy";
		this.checkProxyToolStripMenuItem1.Click += new System.EventHandler(D3A30F12);
		this.checkHotmailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkHotmailToolStripMenuItem.Image");
		this.checkHotmailToolStripMenuItem.Name = "checkHotmailToolStripMenuItem";
		this.checkHotmailToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		this.checkHotmailToolStripMenuItem.Text = "Check Connect hotmail";
		this.checkHotmailToolStripMenuItem.Click += new System.EventHandler(checkHotmailToolStripMenuItem_Click);
		this.A19CDB1C.Image = (System.Drawing.Image)resources.GetObject("lọcTrùngDữLiệuToolStripMenuItem.Image");
		this.A19CDB1C.Name = "lọcTrùngDữLiệuToolStripMenuItem";
		this.A19CDB1C.Size = new System.Drawing.Size(204, 22);
		this.A19CDB1C.Text = "Lọc trùng dữ liệu";
		this.A19CDB1C.Click += new System.EventHandler(A19CDB1C_Click);
		this.toolStripMenuItem_11.Image = (System.Drawing.Image)resources.GetObject("xửLýChuỗiOnlineToolStripMenuItem.Image");
		this.toolStripMenuItem_11.Name = "xửLýChuỗiOnlineToolStripMenuItem";
		this.toolStripMenuItem_11.Size = new System.Drawing.Size(204, 22);
		this.toolStripMenuItem_11.Text = "Xử lý chuỗi cơ bản";
		this.toolStripMenuItem_11.Click += new System.EventHandler(toolStripMenuItem_11_Click);
		this.checkStatusXproxyToolStripMenuItem.Image = Resources.Bitmap_21;
		this.checkStatusXproxyToolStripMenuItem.Name = "checkStatusXproxyToolStripMenuItem";
		this.checkStatusXproxyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		this.checkStatusXproxyToolStripMenuItem.Text = "Check Xproxy";
		this.checkStatusXproxyToolStripMenuItem.Click += new System.EventHandler(checkStatusXproxyToolStripMenuItem_Click);
		this.C90731BD.Image = Resources.A995969B;
		this.C90731BD.Name = "testSpinTextToolStripMenuItem";
		this.C90731BD.Size = new System.Drawing.Size(204, 22);
		this.C90731BD.Text = "Test Spin Content";
		this.C90731BD.Click += new System.EventHandler(BD0A532D);
		this.checkGolikeToolStripMenuItem.Image = Resources.F4B3DC3B;
		this.checkGolikeToolStripMenuItem.Name = "checkGolikeToolStripMenuItem";
		this.checkGolikeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		this.checkGolikeToolStripMenuItem.Text = "Check Golike";
		this.checkGolikeToolStripMenuItem.Click += new System.EventHandler(checkGolikeToolStripMenuItem_Click);
		this.toolStripMenuItem_14.Image = (System.Drawing.Image)resources.GetObject("liênHệToolStripMenuItem.Image");
		this.toolStripMenuItem_14.Name = "liênHệToolStripMenuItem";
		this.toolStripMenuItem_14.Size = new System.Drawing.Size(76, 21);
		this.toolStripMenuItem_14.Text = "Liên hệ";
		this.toolStripMenuItem_14.Click += new System.EventHandler(toolStripMenuItem_14_Click);
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_1.Vertical = true;
		this.A22FCD01.AutomaticDelay = 0;
		this.A22FCD01.AutoPopDelay = 30000;
		this.A22FCD01.InitialDelay = 0;
		this.A22FCD01.ReshowDelay = 40;
		this.AddFileAccount.BackgroundImage = (System.Drawing.Image)resources.GetObject("AddFileAccount.BackgroundImage");
		this.AddFileAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.AddFileAccount.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AddFileAccount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.AddFileAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AddFileAccount.Location = new System.Drawing.Point(395, 2);
		this.AddFileAccount.Name = "AddFileAccount";
		this.AddFileAccount.Size = new System.Drawing.Size(25, 25);
		this.AddFileAccount.TabIndex = 4;
		this.A22FCD01.SetToolTip(this.AddFileAccount, "Thêm thư mục");
		this.AddFileAccount.Click += new System.EventHandler(E2B11600);
		this.C9344F86.BackColor = System.Drawing.Color.White;
		this.C9344F86.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnDeleteFile.BackgroundImage");
		this.C9344F86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.C9344F86.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C9344F86.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.C9344F86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C9344F86.Location = new System.Drawing.Point(457, 2);
		this.C9344F86.Name = "btnDeleteFile";
		this.C9344F86.Size = new System.Drawing.Size(25, 25);
		this.C9344F86.TabIndex = 5;
		this.A22FCD01.SetToolTip(this.C9344F86, "Xóa thư mục");
		this.C9344F86.UseVisualStyleBackColor = false;
		this.C9344F86.Click += new System.EventHandler(D31C4BA0);
		this.btnEditFile.BackColor = System.Drawing.Color.White;
		this.btnEditFile.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnEditFile.BackgroundImage");
		this.btnEditFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.btnEditFile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnEditFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnEditFile.Location = new System.Drawing.Point(426, 2);
		this.btnEditFile.Name = "btnEditFile";
		this.btnEditFile.Size = new System.Drawing.Size(25, 25);
		this.btnEditFile.TabIndex = 5;
		this.A22FCD01.SetToolTip(this.btnEditFile, "Sửa tên thư mục");
		this.btnEditFile.UseVisualStyleBackColor = false;
		this.btnEditFile.Click += new System.EventHandler(btnEditFile_Click);
		this.btnLoadAcc.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnLoadAcc.BackgroundImage");
		this.btnLoadAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		this.btnLoadAcc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnLoadAcc.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnLoadAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnLoadAcc.Location = new System.Drawing.Point(489, 2);
		this.btnLoadAcc.Name = "btnLoadAcc";
		this.btnLoadAcc.Size = new System.Drawing.Size(25, 25);
		this.btnLoadAcc.TabIndex = 6;
		this.A22FCD01.SetToolTip(this.btnLoadAcc, "Load lại danh sách");
		this.btnLoadAcc.Click += new System.EventHandler(DDA41599);
		this.btnInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnInteract.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnInteract.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		this.btnInteract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnInteract.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnInteract.Image = Resources.AC9006A1;
		this.btnInteract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnInteract.Location = new System.Drawing.Point(8, 109);
		this.btnInteract.Name = "btnInteract";
		this.btnInteract.Size = new System.Drawing.Size(117, 32);
		this.btnInteract.TabIndex = 13;
		this.btnInteract.Text = "Chạy đã chọn";
		this.btnInteract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.A22FCD01.SetToolTip(this.btnInteract, "Bă\u0301t đâ\u0300u cha\u0323y tương ta\u0301c");
		this.btnInteract.UseVisualStyleBackColor = false;
		this.btnInteract.Click += new System.EventHandler(btnInteract_Click);
		this.plTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.plTrangThai.BackColor = System.Drawing.Color.Gainsboro;
		this.plTrangThai.Controls.Add(this.AE250EB9);
		this.plTrangThai.Location = new System.Drawing.Point(709, 36);
		this.plTrangThai.Name = "plTrangThai";
		this.plTrangThai.Size = new System.Drawing.Size(373, 26);
		this.plTrangThai.TabIndex = 10;
		this.plTrangThai.Visible = false;
		this.AE250EB9.Dock = System.Windows.Forms.DockStyle.Fill;
		this.AE250EB9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.AE250EB9.Location = new System.Drawing.Point(0, 0);
		this.AE250EB9.Name = "lblTrangThai";
		this.AE250EB9.Size = new System.Drawing.Size(373, 26);
		this.AE250EB9.TabIndex = 0;
		this.AE250EB9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.miniToolStrip.AccessibleName = "New item selection";
		this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
		this.miniToolStrip.AutoSize = false;
		this.miniToolStrip.BackColor = System.Drawing.SystemColors.Control;
		this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
		this.miniToolStrip.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
		this.miniToolStrip.Name = "miniToolStrip";
		this.miniToolStrip.Size = new System.Drawing.Size(1222, 22);
		this.miniToolStrip.SizingGrip = false;
		this.miniToolStrip.TabIndex = 9;
		this.toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
		this.toolStripStatusLabel4.Size = new System.Drawing.Size(59, 17);
		this.toolStripStatusLabel4.Text = "Bôi đen:";
		this.A0976198.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A0976198.ForeColor = System.Drawing.Color.Blue;
		this.A0976198.Name = "lblCountHighline";
		this.A0976198.Size = new System.Drawing.Size(15, 17);
		this.A0976198.Text = "0";
		this.F0AC1D35.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F0AC1D35.Name = "toolStripStatusLabel5";
		this.F0AC1D35.Size = new System.Drawing.Size(65, 17);
		this.F0AC1D35.Text = "Đã chọn:";
		this.lblCountSelect.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountSelect.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		this.lblCountSelect.Name = "lblCountSelect";
		this.lblCountSelect.Size = new System.Drawing.Size(15, 17);
		this.lblCountSelect.Text = "0";
		this.AE8CEF20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AE8CEF20.Name = "toolStripStatusLabel7";
		this.AE8CEF20.Size = new System.Drawing.Size(52, 17);
		this.AE8CEF20.Text = "Tất cả:";
		this.lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		this.lblCountTotal.Name = "lblCountTotal";
		this.lblCountTotal.Size = new System.Drawing.Size(15, 17);
		this.lblCountTotal.Text = "0";
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.metroButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.metroButton1.Location = new System.Drawing.Point(943, 71);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(130, 32);
		this.metroButton1.TabIndex = 7;
		this.metroButton1.Text = "Close Chromedriver";
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.A7A6E116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A7A6E116.Controls.Add(this.C60C5426);
		this.A7A6E116.Controls.Add(this.AE25A29C);
		this.A7A6E116.Controls.Add(this.AA21FF22);
		this.A7A6E116.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A7A6E116.Location = new System.Drawing.Point(8, 72);
		this.A7A6E116.Name = "panel2";
		this.A7A6E116.Size = new System.Drawing.Size(269, 31);
		this.A7A6E116.TabIndex = 10;
		this.C60C5426.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C60C5426.BackgroundImage = Resources.CA1C599E;
		this.C60C5426.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.C60C5426.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C60C5426.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.C60C5426.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C60C5426.Location = new System.Drawing.Point(240, 3);
		this.C60C5426.Name = "BtnSearch";
		this.C60C5426.Size = new System.Drawing.Size(24, 23);
		this.C60C5426.TabIndex = 3;
		this.C60C5426.Click += new System.EventHandler(F32CD491);
		this.AE25A29C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AE25A29C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.AE25A29C.DropDownWidth = 100;
		this.AE25A29C.FormattingEnabled = true;
		this.AE25A29C.Location = new System.Drawing.Point(3, 3);
		this.AE25A29C.Name = "cbbSearch";
		this.AE25A29C.Size = new System.Drawing.Size(86, 24);
		this.AE25A29C.TabIndex = 0;
		this.AA21FF22.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.AA21FF22.BorderColor = System.Drawing.Color.SeaGreen;
		this.AA21FF22.ForeColor = System.Drawing.SystemColors.WindowText;
		this.AA21FF22.Location = new System.Drawing.Point(95, 3);
		this.AA21FF22.Name = "txbSearch";
		this.AA21FF22.Size = new System.Drawing.Size(139, 23);
		this.AA21FF22.TabIndex = 1;
		this.AA21FF22.KeyDown += new System.Windows.Forms.KeyEventHandler(AA21FF22_KeyDown);
		this.plQuanLyThuMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plQuanLyThuMuc.Controls.Add(this.EDBCFD26);
		this.plQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
		this.plQuanLyThuMuc.Controls.Add(this.FE9A040E);
		this.plQuanLyThuMuc.Controls.Add(this.btnEditFile);
		this.plQuanLyThuMuc.Controls.Add(this.button9);
		this.plQuanLyThuMuc.Controls.Add(this.C9344F86);
		this.plQuanLyThuMuc.Controls.Add(this.label2);
		this.plQuanLyThuMuc.Controls.Add(this.AddFileAccount);
		this.plQuanLyThuMuc.Controls.Add(this.D68F8BB7);
		this.plQuanLyThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.plQuanLyThuMuc.Location = new System.Drawing.Point(283, 72);
		this.plQuanLyThuMuc.Name = "plQuanLyThuMuc";
		this.plQuanLyThuMuc.Size = new System.Drawing.Size(654, 31);
		this.plQuanLyThuMuc.TabIndex = 10;
		this.EDBCFD26.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EDBCFD26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.EDBCFD26.DropDownWidth = 300;
		this.EDBCFD26.FormattingEnabled = true;
		this.EDBCFD26.ItemHeight = 16;
		this.EDBCFD26.Items.AddRange(new object[1] { "[Tất cả tình trạng]" });
		this.EDBCFD26.Location = new System.Drawing.Point(268, 3);
		this.EDBCFD26.Name = "cbbTinhTrang";
		this.EDBCFD26.Size = new System.Drawing.Size(121, 24);
		this.EDBCFD26.TabIndex = 3;
		this.EDBCFD26.SelectedIndexChanged += new System.EventHandler(EDBCFD26_SelectedIndexChanged);
		this.FE9A040E.AutoSize = true;
		this.FE9A040E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FE9A040E.Location = new System.Drawing.Point(-1, 6);
		this.FE9A040E.Name = "label1";
		this.FE9A040E.Size = new System.Drawing.Size(63, 16);
		this.FE9A040E.TabIndex = 0;
		this.FE9A040E.Text = "Thư mục:";
		this.button9.BackColor = System.Drawing.Color.White;
		this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button9.Image = (System.Drawing.Image)resources.GetObject("button9.Image");
		this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button9.Location = new System.Drawing.Point(521, 1);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(130, 27);
		this.button9.TabIndex = 7;
		this.button9.Text = "Nhập tài khoản";
		this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(EF0CEA02);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(232, 5);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(31, 16);
		this.label2.TabIndex = 2;
		this.label2.Text = "Lọc:";
		this.D68F8BB7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D68F8BB7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.D68F8BB7.DropDownWidth = 350;
		this.D68F8BB7.FormattingEnabled = true;
		this.D68F8BB7.ItemHeight = 16;
		this.D68F8BB7.Location = new System.Drawing.Point(63, 3);
		this.D68F8BB7.Name = "cbbThuMuc";
		this.D68F8BB7.Size = new System.Drawing.Size(167, 24);
		this.D68F8BB7.TabIndex = 1;
		this.D68F8BB7.SelectedIndexChanged += new System.EventHandler(D68F8BB7_SelectedIndexChanged);
		this.B68285B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.B68285B2.Controls.Add(this.D030FA3A);
		this.B68285B2.Controls.Add(this.groupBox1);
		this.B68285B2.Controls.Add(this.nudThread);
		this.B68285B2.Controls.Add(this.cbbChangeIP);
		this.B68285B2.Controls.Add(this.label9);
		this.B68285B2.Controls.Add(this.grCauHinhChrome);
		this.B68285B2.Controls.Add(this.label17);
		this.B68285B2.Controls.Add(this.button2);
		this.B68285B2.Controls.Add(this.button1);
		this.B68285B2.Controls.Add(this.btnInteract);
		this.B68285B2.Controls.Add(this.FCAD272E);
		this.B68285B2.Controls.Add(this.plQuanLyThuMuc);
		this.B68285B2.Controls.Add(this.A7A6E116);
		this.B68285B2.Controls.Add(this.btnHienCaiDat);
		this.B68285B2.Controls.Add(this.metroButton1);
		this.B68285B2.Controls.Add(this.AC8B928D);
		this.B68285B2.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.B68285B2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B68285B2.Location = new System.Drawing.Point(0, 0);
		this.B68285B2.Name = "panel1";
		this.B68285B2.Size = new System.Drawing.Size(1085, 610);
		this.B68285B2.TabIndex = 11;
		this.B68285B2.Paint += new System.Windows.Forms.PaintEventHandler(B68285B2_Paint);
		this.D030FA3A.AllowUserToAddRows = false;
		this.D030FA3A.AllowUserToDeleteRows = false;
		this.D030FA3A.AllowUserToResizeRows = false;
		this.D030FA3A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D030FA3A.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		this.D030FA3A.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.D030FA3A.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.D030FA3A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.D030FA3A.Columns.AddRange(this.B03820BB, this.D0BA988C, this.cId, this.cUid, this.cToken, this.cCookies, this.cEmail, this.cEmail2, this.cPhone, this.cName, this.cFollow, this.cFriend, this.A1910C2B, this.cPage, this.cPagePro5, this.cBirthday, this.cGender, this.BF07A8B2, this.cMailRecovery, this.cPassMail, this.cBackup, this.cFa2, this.cUseragent, this.cProxy, this.cDateCreateAcc, this.cAvatar, this.cProfile, this.cThuMuc, this.C3840526, this.cInfo, this.EF902E9F, this.cStatus282, this.B11E23A8, this.cHometown, this.cCurrentCity, this.AEAE4632, this.EC8E7E16, this.A78524B2, this.cWallPosts, this.D5AC983B, this.cJob, this.cStatus);
		this.D030FA3A.ContextMenuStrip = this.ctmsAcc;
		this.D030FA3A.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.D030FA3A.Location = new System.Drawing.Point(8, 363);
		this.D030FA3A.Name = "dtgvAcc";
		this.D030FA3A.RowHeadersVisible = false;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D030FA3A.RowsDefaultCellStyle = dataGridViewCellStyle2;
		this.D030FA3A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.D030FA3A.Size = new System.Drawing.Size(1065, 220);
		this.D030FA3A.TabIndex = 202;
		this.D030FA3A.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(E81A0513);
		this.D030FA3A.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(D030FA3A_CellDoubleClick);
		this.D030FA3A.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(D030FA3A_CellValueChanged);
		this.D030FA3A.SelectionChanged += new System.EventHandler(C5097493);
		this.D030FA3A.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(D030FA3A_SortCompare);
		this.D030FA3A.KeyDown += new System.Windows.Forms.KeyEventHandler(D030FA3A_KeyDown);
		this.B03820BB.HeaderText = "Chọn";
		this.B03820BB.Name = "cChose";
		this.B03820BB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.B03820BB.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.D0BA988C.DefaultCellStyle = dataGridViewCellStyle3;
		this.D0BA988C.HeaderText = "STT";
		this.D0BA988C.Name = "cStt";
		this.D0BA988C.Width = 35;
		this.cId.HeaderText = "Id";
		this.cId.Name = "cId";
		this.cId.Visible = false;
		this.cId.Width = 90;
		this.cUid.HeaderText = "UID";
		this.cUid.Name = "cUid";
		this.cUid.Width = 80;
		this.cToken.HeaderText = "Token";
		this.cToken.Name = "cToken";
		this.cToken.Width = 70;
		this.cCookies.HeaderText = "Cookie";
		this.cCookies.Name = "cCookies";
		this.cCookies.Width = 70;
		this.cEmail.HeaderText = "Email";
		this.cEmail.Name = "cEmail";
		this.cEmail.Width = 60;
		this.cEmail2.HeaderText = "Email full";
		this.cEmail2.Name = "cEmail2";
		this.cPhone.HeaderText = "Phone";
		this.cPhone.Name = "cPhone";
		this.cPhone.Visible = false;
		this.cPhone.Width = 90;
		this.cName.HeaderText = "Tên";
		this.cName.Name = "cName";
		this.cName.Width = 70;
		this.cFollow.HeaderText = "Theo do\u0303i";
		this.cFollow.Name = "cFollow";
		this.cFollow.Visible = false;
		this.cFollow.Width = 85;
		this.cFriend.HeaderText = "Ba\u0323n be\u0300";
		this.cFriend.Name = "cFriend";
		this.cFriend.Width = 75;
		this.A1910C2B.HeaderText = "Nho\u0301m";
		this.A1910C2B.Name = "cGroup";
		this.A1910C2B.Visible = false;
		this.A1910C2B.Width = 60;
		this.cPage.HeaderText = "Page";
		this.cPage.Name = "cPage";
		this.cPage.Visible = false;
		this.cPage.Width = 60;
		this.cPagePro5.HeaderText = "Page pro5";
		this.cPagePro5.Name = "cPagePro5";
		this.cPagePro5.Visible = false;
		this.cBirthday.HeaderText = "Nga\u0300y sinh";
		this.cBirthday.Name = "cBirthday";
		this.cBirthday.Width = 90;
		this.cGender.HeaderText = "Giới Tính";
		this.cGender.Name = "cGender";
		this.cGender.Width = 82;
		this.BF07A8B2.HeaderText = "Mật khẩu";
		this.BF07A8B2.Name = "cPassword";
		this.BF07A8B2.Visible = false;
		this.BF07A8B2.Width = 85;
		this.cMailRecovery.HeaderText = "Email khôi phục";
		this.cMailRecovery.Name = "cMailRecovery";
		this.cMailRecovery.Visible = false;
		this.cMailRecovery.Width = 125;
		this.cPassMail.HeaderText = "Mật khẩu mail";
		this.cPassMail.Name = "cPassMail";
		this.cPassMail.Visible = false;
		this.cPassMail.Width = 120;
		this.cBackup.HeaderText = "Backup";
		this.cBackup.Name = "cBackup";
		this.cBackup.Visible = false;
		this.cBackup.Width = 70;
		this.cFa2.HeaderText = "Mã 2FA";
		this.cFa2.Name = "cFa2";
		this.cFa2.Width = 80;
		this.cUseragent.HeaderText = "Useragent";
		this.cUseragent.Name = "cUseragent";
		this.cUseragent.Visible = false;
		this.cUseragent.Width = 70;
		this.cProxy.HeaderText = "Proxy";
		this.cProxy.Name = "cProxy";
		this.cProxy.Visible = false;
		this.cProxy.Width = 55;
		this.cDateCreateAcc.HeaderText = "Nga\u0300y ta\u0323o";
		this.cDateCreateAcc.Name = "cDateCreateAcc";
		this.cDateCreateAcc.Visible = false;
		this.cDateCreateAcc.Width = 85;
		this.cAvatar.HeaderText = "Avatar";
		this.cAvatar.Name = "cAvatar";
		this.cAvatar.Visible = false;
		this.cAvatar.Width = 50;
		this.cProfile.HeaderText = "Profile";
		this.cProfile.Name = "cProfile";
		this.cProfile.Visible = false;
		this.cProfile.Width = 50;
		this.cThuMuc.HeaderText = "Thư mục";
		this.cThuMuc.Name = "cThuMuc";
		this.cThuMuc.Visible = false;
		this.C3840526.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		this.C3840526.Name = "cInteractEnd";
		this.C3840526.Visible = false;
		this.C3840526.Width = 160;
		this.cInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.cInfo.HeaderText = "Tình Trạng";
		this.cInfo.Name = "cInfo";
		this.cInfo.Visible = false;
		this.EF902E9F.HeaderText = "Ghi Chú";
		this.EF902E9F.Name = "cGhiChu";
		this.EF902E9F.Visible = false;
		this.EF902E9F.Width = 90;
		this.cStatus282.HeaderText = "Status 282";
		this.cStatus282.Name = "cStatus282";
		this.cStatus282.Visible = false;
		this.B11E23A8.HeaderText = "Location";
		this.B11E23A8.Name = "cLocation";
		this.B11E23A8.Visible = false;
		this.B11E23A8.Width = 80;
		this.cHometown.HeaderText = "Hometown";
		this.cHometown.Name = "cHometown";
		this.cHometown.Visible = false;
		this.cHometown.Width = 90;
		this.cCurrentCity.HeaderText = "Current City";
		this.cCurrentCity.Name = "cCurrentCity";
		this.cCurrentCity.Visible = false;
		this.AEAE4632.HeaderText = "Dating";
		this.AEAE4632.Name = "cDating";
		this.AEAE4632.Visible = false;
		this.EC8E7E16.HeaderText = "Ads";
		this.EC8E7E16.Name = "cAds";
		this.EC8E7E16.Visible = false;
		this.A78524B2.HeaderText = "BM";
		this.A78524B2.Name = "cBM";
		this.A78524B2.Visible = false;
		this.cWallPosts.HeaderText = "Wall Posts";
		this.cWallPosts.Name = "cWallPosts";
		this.cWallPosts.Visible = false;
		this.D5AC983B.HeaderText = "Fb Block";
		this.D5AC983B.Name = "cFbBlock";
		this.D5AC983B.Width = 80;
		this.cJob.HeaderText = "Job";
		this.cJob.Name = "cJob";
		this.cJob.Visible = false;
		this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cStatus.HeaderText = "Trạng Thái";
		this.cStatus.MinimumWidth = 200;
		this.cStatus.Name = "cStatus";
		this.groupBox1.Controls.Add(this.AB39C701);
		this.groupBox1.Controls.Add(this.ckbBreakTime);
		this.groupBox1.Controls.Add(this.F52CE993);
		this.groupBox1.Controls.Add(this.nudDelayTo);
		this.groupBox1.Controls.Add(this.nudMaxJobToday);
		this.groupBox1.Controls.Add(this.nudDelayGetJob);
		this.groupBox1.Controls.Add(this.BA05D285);
		this.groupBox1.Controls.Add(this.nudDelayFrom);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label13);
		this.groupBox1.Controls.Add(this.label12);
		this.groupBox1.Controls.Add(this.label19);
		this.groupBox1.Controls.Add(this.E13363B0);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.label11);
		this.groupBox1.Controls.Add(this.label18);
		this.groupBox1.Controls.Add(this.BA00D8A9);
		this.groupBox1.Controls.Add(this.cbbCheDoChay);
		this.groupBox1.Controls.Add(this.DE11733F);
		this.groupBox1.Controls.Add(this.lblUnlock956);
		this.groupBox1.Controls.Add(this.label10);
		this.groupBox1.Controls.Add(this.ckbUnlock956);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.FFA8ECA5);
		this.groupBox1.Controls.Add(this.DF92EF15);
		this.groupBox1.Location = new System.Drawing.Point(8, 147);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(358, 209);
		this.groupBox1.TabIndex = 11;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình Job";
		this.AB39C701.Controls.Add(this.nudBreakTimeJob);
		this.AB39C701.Controls.Add(this.label24);
		this.AB39C701.Controls.Add(this.label22);
		this.AB39C701.Controls.Add(this.nudBreakTime);
		this.AB39C701.Location = new System.Drawing.Point(107, 156);
		this.AB39C701.Name = "plBreakTime";
		this.AB39C701.Size = new System.Drawing.Size(215, 25);
		this.AB39C701.TabIndex = 93;
		this.nudBreakTimeJob.Location = new System.Drawing.Point(1, 1);
		this.nudBreakTimeJob.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudBreakTimeJob.Name = "nudBreakTimeJob";
		this.nudBreakTimeJob.Size = new System.Drawing.Size(41, 23);
		this.nudBreakTimeJob.TabIndex = 78;
		this.nudBreakTimeJob.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label24.AutoSize = true;
		this.label24.Location = new System.Drawing.Point(48, 3);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(70, 16);
		this.label24.TabIndex = 88;
		this.label24.Text = "job sẽ nghỉ";
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(185, 3);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(30, 16);
		this.label22.TabIndex = 83;
		this.label22.Text = "giây";
		this.nudBreakTime.Location = new System.Drawing.Point(126, 1);
		this.nudBreakTime.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudBreakTime.Name = "nudBreakTime";
		this.nudBreakTime.Size = new System.Drawing.Size(56, 23);
		this.nudBreakTime.TabIndex = 78;
		this.nudBreakTime.Value = new decimal(new int[4] { 60, 0, 0, 0 });
		this.ckbBreakTime.AutoSize = true;
		this.ckbBreakTime.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBreakTime.Location = new System.Drawing.Point(20, 158);
		this.ckbBreakTime.Name = "ckbBreakTime";
		this.ckbBreakTime.Size = new System.Drawing.Size(86, 20);
		this.ckbBreakTime.TabIndex = 92;
		this.ckbBreakTime.Text = "Chạy được";
		this.ckbBreakTime.UseVisualStyleBackColor = true;
		this.ckbBreakTime.CheckedChanged += new System.EventHandler(ckbBreakTime_CheckedChanged);
		this.F52CE993.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F52CE993.Location = new System.Drawing.Point(295, 16);
		this.F52CE993.Name = "button3";
		this.F52CE993.Size = new System.Drawing.Size(58, 25);
		this.F52CE993.TabIndex = 91;
		this.F52CE993.Text = "Check";
		this.F52CE993.UseVisualStyleBackColor = true;
		this.F52CE993.Click += new System.EventHandler(F108D019);
		this.nudDelayTo.Location = new System.Drawing.Point(233, 46);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 80;
		this.nudDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudMaxJobToday.Location = new System.Drawing.Point(233, 75);
		this.nudMaxJobToday.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudMaxJobToday.Name = "nudMaxJobToday";
		this.nudMaxJobToday.Size = new System.Drawing.Size(56, 23);
		this.nudMaxJobToday.TabIndex = 76;
		this.nudDelayGetJob.Location = new System.Drawing.Point(233, 241);
		this.nudDelayGetJob.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayGetJob.Minimum = new decimal(new int[4] { 5, 0, 0, 0 });
		this.nudDelayGetJob.Name = "nudDelayGetJob";
		this.nudDelayGetJob.Size = new System.Drawing.Size(56, 23);
		this.nudDelayGetJob.TabIndex = 77;
		this.nudDelayGetJob.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.BA05D285.Location = new System.Drawing.Point(233, 104);
		this.BA05D285.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.BA05D285.Name = "nudMaxJobFailLienTiep";
		this.BA05D285.Size = new System.Drawing.Size(56, 23);
		this.BA05D285.TabIndex = 77;
		this.nudDelayFrom.Location = new System.Drawing.Point(155, 46);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 78;
		this.nudDelayFrom.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new System.Drawing.Point(209, 48);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 90;
		this.label7.Text = ">";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(292, 77);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(31, 16);
		this.label13.TabIndex = 81;
		this.label13.Text = "jobs";
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(292, 106);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(31, 16);
		this.label12.TabIndex = 82;
		this.label12.Text = "jobs";
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(292, 243);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(30, 16);
		this.label19.TabIndex = 83;
		this.label19.Text = "giây";
		this.E13363B0.AutoSize = true;
		this.E13363B0.Location = new System.Drawing.Point(292, 48);
		this.E13363B0.Name = "label14";
		this.E13363B0.Size = new System.Drawing.Size(30, 16);
		this.E13363B0.TabIndex = 83;
		this.E13363B0.Text = "giây";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(17, 77);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(174, 16);
		this.label3.TabIndex = 86;
		this.label3.Text = "Số job tối đa/tài khoản/ngày:";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(17, 106);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(132, 16);
		this.label11.TabIndex = 87;
		this.label11.Text = "Dừng khi fail liên tiếp:";
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(17, 243);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(93, 16);
		this.label18.TabIndex = 87;
		this.label18.Text = "Delay get jobs:";
		this.BA00D8A9.AutoSize = true;
		this.BA00D8A9.Location = new System.Drawing.Point(17, 48);
		this.BA00D8A9.Name = "label4";
		this.BA00D8A9.Size = new System.Drawing.Size(99, 16);
		this.BA00D8A9.TabIndex = 88;
		this.BA00D8A9.Text = "Nghỉ giữa 2 job:";
		this.cbbCheDoChay.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbCheDoChay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbCheDoChay.FormattingEnabled = true;
		this.cbbCheDoChay.Items.AddRange(new object[2] { "Token + Cookie", "Token" });
		this.cbbCheDoChay.Location = new System.Drawing.Point(155, 299);
		this.cbbCheDoChay.Name = "cbbCheDoChay";
		this.cbbCheDoChay.Size = new System.Drawing.Size(197, 24);
		this.cbbCheDoChay.TabIndex = 74;
		this.cbbCheDoChay.SelectedIndexChanged += new System.EventHandler(cbbCheDoChay_SelectedIndexChanged);
		this.DE11733F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE11733F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.DE11733F.FormattingEnabled = true;
		this.DE11733F.Items.AddRange(new object[2] { "Mở chrome", "Chạy ẩn" });
		this.DE11733F.Location = new System.Drawing.Point(155, 269);
		this.DE11733F.Name = "cbbTypeGetToken";
		this.DE11733F.Size = new System.Drawing.Size(197, 24);
		this.DE11733F.TabIndex = 74;
		this.DE11733F.SelectedIndexChanged += new System.EventHandler(DE11733F_SelectedIndexChanged);
		this.lblUnlock956.AutoSize = true;
		this.lblUnlock956.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblUnlock956.Location = new System.Drawing.Point(229, 133);
		this.lblUnlock956.Name = "lblUnlock956";
		this.lblUnlock956.Size = new System.Drawing.Size(57, 16);
		this.lblUnlock956.TabIndex = 70;
		this.lblUnlock956.TabStop = true;
		this.lblUnlock956.Text = "Cấu hình";
		this.lblUnlock956.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lblUnlock956_LinkClicked);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(17, 299);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(82, 16);
		this.label10.TabIndex = 61;
		this.label10.Text = "Chế độ chạy:";
		this.ckbUnlock956.AutoSize = true;
		this.ckbUnlock956.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUnlock956.Location = new System.Drawing.Point(20, 132);
		this.ckbUnlock956.Name = "ckbUnlock956";
		this.ckbUnlock956.Size = new System.Drawing.Size(204, 20);
		this.ckbUnlock956.TabIndex = 69;
		this.ckbUnlock956.Text = "Tự động Unlock checkpoint 956";
		this.ckbUnlock956.UseVisualStyleBackColor = true;
		this.ckbUnlock956.CheckedChanged += new System.EventHandler(ckbUnlock956_CheckedChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(17, 269);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(119, 16);
		this.label5.TabIndex = 61;
		this.label5.Text = "Tùy chọn lấy token:";
		this.FFA8ECA5.Location = new System.Drawing.Point(77, 17);
		this.FFA8ECA5.Name = "txtApiKey";
		this.FFA8ECA5.Size = new System.Drawing.Size(212, 23);
		this.FFA8ECA5.TabIndex = 48;
		this.FFA8ECA5.TextChanged += new System.EventHandler(D78B21AF);
		this.DF92EF15.AutoSize = true;
		this.DF92EF15.Location = new System.Drawing.Point(17, 20);
		this.DF92EF15.Name = "label15";
		this.DF92EF15.Size = new System.Drawing.Size(54, 16);
		this.DF92EF15.TabIndex = 49;
		this.DF92EF15.Text = "Api Key:";
		this.nudThread.Location = new System.Drawing.Point(773, 335);
		this.nudThread.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudThread.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThread.Name = "nudThread";
		this.nudThread.Size = new System.Drawing.Size(51, 23);
		this.nudThread.TabIndex = 151;
		this.nudThread.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.cbbChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbChangeIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbChangeIP.FormattingEnabled = true;
		this.cbbChangeIP.Items.AddRange(new object[2] { "Không đổi IP", "Proxy" });
		this.cbbChangeIP.Location = new System.Drawing.Point(754, 305);
		this.cbbChangeIP.Name = "cbbChangeIP";
		this.cbbChangeIP.Size = new System.Drawing.Size(161, 24);
		this.cbbChangeIP.TabIndex = 200;
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label9.Location = new System.Drawing.Point(601, 308);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(100, 16);
		this.label9.TabIndex = 201;
		this.label9.Text = "Tùy chọn đổi IP:";
		this.grCauHinhChrome.Controls.Add(this.DDBC7438);
		this.grCauHinhChrome.Controls.Add(this.EDA3E782);
		this.grCauHinhChrome.Controls.Add(this.C481F21A);
		this.grCauHinhChrome.Controls.Add(this.B38D3A0B);
		this.grCauHinhChrome.Controls.Add(this.cbbTypeLogin);
		this.grCauHinhChrome.Controls.Add(this.label16);
		this.grCauHinhChrome.Controls.Add(this.label20);
		this.grCauHinhChrome.Controls.Add(this.ADB609AA);
		this.grCauHinhChrome.Controls.Add(this.button6);
		this.grCauHinhChrome.Controls.Add(this.cbbFacebookWeb);
		this.grCauHinhChrome.Controls.Add(this.label29);
		this.grCauHinhChrome.Controls.Add(this.E8A87D36);
		this.grCauHinhChrome.Controls.Add(this.FF16D4B5);
		this.grCauHinhChrome.Controls.Add(this.ckbShowImageInteract);
		this.grCauHinhChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.grCauHinhChrome.Location = new System.Drawing.Point(588, 146);
		this.grCauHinhChrome.Name = "grCauHinhChrome";
		this.grCauHinhChrome.Size = new System.Drawing.Size(333, 155);
		this.grCauHinhChrome.TabIndex = 195;
		this.grCauHinhChrome.TabStop = false;
		this.grCauHinhChrome.Text = "Cấu hình chrome";
		this.DDBC7438.Location = new System.Drawing.Point(228, 67);
		this.DDBC7438.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DDBC7438.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.DDBC7438.Name = "nudDelayOpenChromeTo";
		this.DDBC7438.Size = new System.Drawing.Size(41, 23);
		this.DDBC7438.TabIndex = 151;
		this.DDBC7438.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.EDA3E782.Location = new System.Drawing.Point(166, 39);
		this.EDA3E782.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.EDA3E782.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.EDA3E782.Name = "nudMaxChrome";
		this.EDA3E782.Size = new System.Drawing.Size(41, 23);
		this.EDA3E782.TabIndex = 151;
		this.EDA3E782.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.C481F21A.Location = new System.Drawing.Point(166, 67);
		this.C481F21A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C481F21A.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.C481F21A.Name = "nudDelayOpenChromeFrom";
		this.C481F21A.Size = new System.Drawing.Size(41, 23);
		this.C481F21A.TabIndex = 151;
		this.C481F21A.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.B38D3A0B.AutoSize = true;
		this.B38D3A0B.Location = new System.Drawing.Point(13, 97);
		this.B38D3A0B.Name = "label6";
		this.B38D3A0B.Size = new System.Drawing.Size(100, 16);
		this.B38D3A0B.TabIndex = 196;
		this.B38D3A0B.Text = "Kiểu đăng nhâ\u0323p:";
		this.cbbTypeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeLogin.DropDownWidth = 120;
		this.cbbTypeLogin.FormattingEnabled = true;
		this.cbbTypeLogin.Items.AddRange(new object[4] { "Uid|Pass", "Email|Pass", "Cookie", "Cookie>Pass" });
		this.cbbTypeLogin.Location = new System.Drawing.Point(166, 95);
		this.cbbTypeLogin.Name = "cbbTypeLogin";
		this.cbbTypeLogin.Size = new System.Drawing.Size(161, 24);
		this.cbbTypeLogin.TabIndex = 198;
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label16.Location = new System.Drawing.Point(13, 41);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(153, 16);
		this.label16.TabIndex = 33;
		this.label16.Text = "Số chrome mở đô\u0300ng thơ\u0300i:";
		this.label20.AutoSize = true;
		this.label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.Location = new System.Drawing.Point(13, 69);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(144, 16);
		this.label20.TabIndex = 33;
		this.label20.Text = "Delay Open chrome (s):";
		this.ADB609AA.AutoSize = true;
		this.ADB609AA.Location = new System.Drawing.Point(13, 127);
		this.ADB609AA.Name = "label8";
		this.ADB609AA.Size = new System.Drawing.Size(110, 16);
		this.ADB609AA.TabIndex = 197;
		this.ADB609AA.Text = "Trang đăng nhâ\u0323p:";
		this.button6.BackgroundImage = Resources.Bitmap_83;
		this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button6.Location = new System.Drawing.Point(512, 8);
		this.button6.Name = "button6";
		this.button6.Size = new System.Drawing.Size(25, 25);
		this.button6.TabIndex = 158;
		this.cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbFacebookWeb.DropDownWidth = 120;
		this.cbbFacebookWeb.FormattingEnabled = true;
		this.cbbFacebookWeb.Items.AddRange(new object[4] { "m.fb", "www", "mbasic", "www->m.fb" });
		this.cbbFacebookWeb.Location = new System.Drawing.Point(166, 124);
		this.cbbFacebookWeb.Name = "cbbFacebookWeb";
		this.cbbFacebookWeb.Size = new System.Drawing.Size(161, 24);
		this.cbbFacebookWeb.TabIndex = 199;
		this.label29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label29.Location = new System.Drawing.Point(206, 70);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(23, 16);
		this.label29.TabIndex = 33;
		this.label29.Text = ">";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E8A87D36.BackgroundImage = Resources.E536C319;
		this.E8A87D36.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E8A87D36.Location = new System.Drawing.Point(543, 8);
		this.E8A87D36.Name = "button7";
		this.E8A87D36.Size = new System.Drawing.Size(25, 25);
		this.E8A87D36.TabIndex = 159;
		this.FF16D4B5.AutoSize = true;
		this.FF16D4B5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FF16D4B5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FF16D4B5.Location = new System.Drawing.Point(228, 18);
		this.FF16D4B5.Name = "ckbHideBrowser";
		this.FF16D4B5.Size = new System.Drawing.Size(88, 20);
		this.FF16D4B5.TabIndex = 112;
		this.FF16D4B5.Text = "Ẩn chrome";
		this.FF16D4B5.UseVisualStyleBackColor = true;
		this.ckbShowImageInteract.AutoSize = true;
		this.ckbShowImageInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShowImageInteract.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbShowImageInteract.Location = new System.Drawing.Point(16, 18);
		this.ckbShowImageInteract.Name = "ckbShowImageInteract";
		this.ckbShowImageInteract.Size = new System.Drawing.Size(175, 20);
		this.ckbShowImageInteract.TabIndex = 112;
		this.ckbShowImageInteract.Text = "Hiê\u0323n a\u0309nh khi dùng chrome";
		this.ckbShowImageInteract.UseVisualStyleBackColor = true;
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label17.Location = new System.Drawing.Point(601, 337);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(170, 16);
		this.label17.TabIndex = 33;
		this.label17.Text = "Số tài khoản chạy đồng thời:";
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Image = Resources.Bitmap_137;
		this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button2.Location = new System.Drawing.Point(256, 109);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(111, 32);
		this.button2.TabIndex = 13;
		this.button2.Text = "Dừng tất cả";
		this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.Image = Resources.Bitmap_137;
		this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button1.Location = new System.Drawing.Point(131, 109);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(119, 32);
		this.button1.TabIndex = 13;
		this.button1.Text = "Dừng đã chọn";
		this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.FCAD272E.Controls.Add(this.ckbCheckAll);
		this.FCAD272E.Controls.Add(this.ckbFollow);
		this.FCAD272E.Controls.Add(this.ckbComment);
		this.FCAD272E.Controls.Add(this.ckbLike);
		this.FCAD272E.Controls.Add(this.ckbShare);
		this.FCAD272E.Controls.Add(this.ckbWow);
		this.FCAD272E.Controls.Add(this.C69FE504);
		this.FCAD272E.Controls.Add(this.ckbSad);
		this.FCAD272E.Controls.Add(this.ckbLikeComment);
		this.FCAD272E.Controls.Add(this.ckbLove);
		this.FCAD272E.Controls.Add(this.ckbJoinGroup);
		this.FCAD272E.Controls.Add(this.ckbHaha);
		this.FCAD272E.Controls.Add(this.ckbCare);
		this.FCAD272E.Controls.Add(this.ckbAngry);
		this.FCAD272E.Location = new System.Drawing.Point(372, 146);
		this.FCAD272E.Name = "groupBox2";
		this.FCAD272E.Size = new System.Drawing.Size(210, 210);
		this.FCAD272E.TabIndex = 12;
		this.FCAD272E.TabStop = false;
		this.FCAD272E.Text = " ";
		this.ckbCheckAll.AutoSize = true;
		this.ckbCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckAll.Location = new System.Drawing.Point(16, -1);
		this.ckbCheckAll.Name = "ckbCheckAll";
		this.ckbCheckAll.Size = new System.Drawing.Size(78, 20);
		this.ckbCheckAll.TabIndex = 1;
		this.ckbCheckAll.Text = "Chọn Job";
		this.ckbCheckAll.UseVisualStyleBackColor = true;
		this.ckbCheckAll.CheckedChanged += new System.EventHandler(E709EEBF);
		this.ckbFollow.AutoSize = true;
		this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFollow.Location = new System.Drawing.Point(98, 23);
		this.ckbFollow.Name = "ckbFollow";
		this.ckbFollow.Size = new System.Drawing.Size(60, 20);
		this.ckbFollow.TabIndex = 0;
		this.ckbFollow.Text = "follow";
		this.ckbFollow.UseVisualStyleBackColor = true;
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(98, 125);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(79, 20);
		this.ckbComment.TabIndex = 0;
		this.ckbComment.Text = "comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbLike.AutoSize = true;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Location = new System.Drawing.Point(16, 23);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(45, 20);
		this.ckbLike.TabIndex = 0;
		this.ckbLike.Text = "like";
		this.ckbLike.UseVisualStyleBackColor = true;
		this.ckbShare.AutoSize = true;
		this.ckbShare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShare.Location = new System.Drawing.Point(98, 151);
		this.ckbShare.Name = "ckbShare";
		this.ckbShare.Size = new System.Drawing.Size(58, 20);
		this.ckbShare.TabIndex = 0;
		this.ckbShare.Text = "share";
		this.ckbShare.UseVisualStyleBackColor = true;
		this.ckbWow.AutoSize = true;
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Location = new System.Drawing.Point(16, 125);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(53, 20);
		this.ckbWow.TabIndex = 0;
		this.ckbWow.Text = "wow";
		this.ckbWow.UseVisualStyleBackColor = true;
		this.C69FE504.AutoSize = true;
		this.C69FE504.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C69FE504.Location = new System.Drawing.Point(98, 48);
		this.C69FE504.Name = "ckbLikePage";
		this.C69FE504.Size = new System.Drawing.Size(80, 20);
		this.C69FE504.TabIndex = 0;
		this.C69FE504.Text = "like_page";
		this.C69FE504.UseVisualStyleBackColor = true;
		this.ckbSad.AutoSize = true;
		this.ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSad.Location = new System.Drawing.Point(16, 151);
		this.ckbSad.Name = "ckbSad";
		this.ckbSad.Size = new System.Drawing.Size(46, 20);
		this.ckbSad.TabIndex = 0;
		this.ckbSad.Text = "sad";
		this.ckbSad.UseVisualStyleBackColor = true;
		this.ckbLikeComment.AutoSize = true;
		this.ckbLikeComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLikeComment.Location = new System.Drawing.Point(98, 100);
		this.ckbLikeComment.Name = "ckbLikeComment";
		this.ckbLikeComment.Size = new System.Drawing.Size(105, 20);
		this.ckbLikeComment.TabIndex = 0;
		this.ckbLikeComment.Text = "like_comment";
		this.ckbLikeComment.UseVisualStyleBackColor = true;
		this.ckbLove.AutoSize = true;
		this.ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLove.Location = new System.Drawing.Point(16, 48);
		this.ckbLove.Name = "ckbLove";
		this.ckbLove.Size = new System.Drawing.Size(49, 20);
		this.ckbLove.TabIndex = 0;
		this.ckbLove.Text = "love";
		this.ckbLove.UseVisualStyleBackColor = true;
		this.ckbJoinGroup.AutoSize = true;
		this.ckbJoinGroup.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbJoinGroup.Location = new System.Drawing.Point(98, 74);
		this.ckbJoinGroup.Name = "ckbJoinGroup";
		this.ckbJoinGroup.Size = new System.Drawing.Size(87, 20);
		this.ckbJoinGroup.TabIndex = 0;
		this.ckbJoinGroup.Text = "join_group";
		this.ckbJoinGroup.UseVisualStyleBackColor = true;
		this.ckbHaha.AutoSize = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Location = new System.Drawing.Point(16, 100);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(54, 20);
		this.ckbHaha.TabIndex = 0;
		this.ckbHaha.Text = "haha";
		this.ckbHaha.UseVisualStyleBackColor = true;
		this.ckbCare.AutoSize = true;
		this.ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCare.Location = new System.Drawing.Point(16, 74);
		this.ckbCare.Name = "ckbCare";
		this.ckbCare.Size = new System.Drawing.Size(51, 20);
		this.ckbCare.TabIndex = 0;
		this.ckbCare.Text = "care";
		this.ckbCare.UseVisualStyleBackColor = true;
		this.ckbAngry.AutoSize = true;
		this.ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAngry.Location = new System.Drawing.Point(16, 177);
		this.ckbAngry.Name = "ckbAngry";
		this.ckbAngry.Size = new System.Drawing.Size(58, 20);
		this.ckbAngry.TabIndex = 0;
		this.ckbAngry.Text = "angry";
		this.ckbAngry.UseVisualStyleBackColor = true;
		this.btnHienCaiDat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnHienCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHienCaiDat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnHienCaiDat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		this.btnHienCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHienCaiDat.Location = new System.Drawing.Point(962, 109);
		this.btnHienCaiDat.Name = "btnHienCaiDat";
		this.btnHienCaiDat.Size = new System.Drawing.Size(111, 32);
		this.btnHienCaiDat.TabIndex = 7;
		this.btnHienCaiDat.Text = "Ẩn cài đặt";
		this.btnHienCaiDat.Click += new System.EventHandler(C8183AA3);
		this.AC8B928D.BackColor = System.Drawing.SystemColors.Control;
		this.AC8B928D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.AC8B928D.Items.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.toolStripStatusLabel4, this.A0976198, this.F0AC1D35, this.lblCountSelect, this.AE8CEF20, this.lblCountTotal, this.toolStripStatusLabel1, this.B6218EA3, this.CB82F694, this.lblCountChrome });
		this.AC8B928D.Location = new System.Drawing.Point(0, 586);
		this.AC8B928D.Name = "statusStrip1";
		this.AC8B928D.Size = new System.Drawing.Size(1083, 22);
		this.AC8B928D.SizingGrip = false;
		this.AC8B928D.TabIndex = 9;
		this.AC8B928D.Text = "statusStrip1";
		this.AC8B928D.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(AC8B928D_ItemClicked);
		this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
		this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
		this.toolStripStatusLabel1.Text = "Account:";
		this.B6218EA3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B6218EA3.ForeColor = System.Drawing.Color.Green;
		this.B6218EA3.Name = "lblCountRunning";
		this.B6218EA3.Size = new System.Drawing.Size(15, 17);
		this.B6218EA3.Text = "0";
		this.CB82F694.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CB82F694.Name = "toolStripStatusLabel2";
		this.CB82F694.Size = new System.Drawing.Size(61, 17);
		this.CB82F694.Text = "Chrome:";
		this.lblCountChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountChrome.ForeColor = System.Drawing.Color.RoyalBlue;
		this.lblCountChrome.Name = "lblCountChrome";
		this.lblCountChrome.Size = new System.Drawing.Size(15, 17);
		this.lblCountChrome.Text = "0";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1085, 610);
		base.Controls.Add(this.plTrangThai);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.menuStrip1);
		base.Controls.Add(this.B68285B2);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = this.menuStrip1;
		base.Name = "fGolike";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE";
		this.ctmsAcc.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.plTrangThai.ResumeLayout(false);
		this.A7A6E116.ResumeLayout(false);
		this.A7A6E116.PerformLayout();
		this.plQuanLyThuMuc.ResumeLayout(false);
		this.plQuanLyThuMuc.PerformLayout();
		this.B68285B2.ResumeLayout(false);
		this.B68285B2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.D030FA3A).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.AB39C701.ResumeLayout(false);
		this.AB39C701.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudBreakTimeJob).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudBreakTime).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudMaxJobToday).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayGetJob).EndInit();
		((System.ComponentModel.ISupportInitialize)this.BA05D285).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThread).EndInit();
		this.grCauHinhChrome.ResumeLayout(false);
		this.grCauHinhChrome.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DDBC7438).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EDA3E782).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C481F21A).EndInit();
		this.FCAD272E.ResumeLayout(false);
		this.FCAD272E.PerformLayout();
		this.AC8B928D.ResumeLayout(false);
		this.AC8B928D.PerformLayout();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_120()
	{
		if (plTrangThai.Visible)
		{
			plTrangThai.Visible = false;
		}
	}

	[CompilerGenerated]
	private void F097D4B9()
	{
		lblCountChrome.Text = BFACE4AB.ToString();
	}

	[CompilerGenerated]
	private void F513EF3F()
	{
		B6218EA3.Text = dictionary_27.Count.ToString();
	}

	[CompilerGenerated]
	private void method_121()
	{
		try
		{
			Class64.smethod_0(btnInteract, bool_0: false, EA33DE2B: true);
			for (int i = 0; i < D030FA3A.RowCount; i++)
			{
				if (bool_0)
				{
					break;
				}
				if (!Convert.ToBoolean(D030FA3A.Rows[i].Cells["cChose"].Value) || dictionary_27.ContainsKey(i))
				{
					continue;
				}
				if ((decimal)dictionary_27.Count >= nudThread.Value)
				{
					Common.Sleep(1.0);
					i--;
					continue;
				}
				if (bool_0)
				{
					break;
				}
				method_117(i);
				Common.Sleep(0.1);
			}
			Class64.smethod_0(btnInteract, bool_0: true, EA33DE2B: true);
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("btnInteract_Click\n" + ex.ToString());
		}
	}
}
