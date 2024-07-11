using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

public class JobGolikeHepler
{
	private fGolike fGolike;

	public bool bool_0;

	public int int_0 = 0;

	public string string_0 = "";

	public string CEAF9D00 = "";

	public string string_1 = "";

	public string ED0CA414 = "";

	public string A287EA01 = "";

	public string string_2 = "";

	public string AC9A1690 = "";

	public string string_3 = "";

	public string E4A35533 = "";

	public int D5A8B0B1 = 0;

	public bool F72EE4A0 = false;

	private Chrome f336F52E_0 = null;

	private Class65 E12BBDB2 = null;

	public int int_1;

	public int int_2;

	public JobGolikeHepler(fGolike bfb2AB91_1, int B18383B3)
	{
		fGolike = bfb2AB91_1;
		int_0 = B18383B3;
		string_0 = fGolike.method_93(B18383B3, "cId");
		CEAF9D00 = fGolike.method_93(B18383B3, "cUid");
		string_1 = fGolike.method_93(B18383B3, "cName");
		ED0CA414 = fGolike.method_93(B18383B3, "cPassword");
		A287EA01 = fGolike.method_93(B18383B3, "cFa2");
		string_2 = fGolike.method_93(B18383B3, "cEmail");
		AC9A1690 = fGolike.method_93(B18383B3, "cCookies");
		string_3 = fGolike.method_93(B18383B3, "cUseragent");
		F72EE4A0 = fGolike.method_93(B18383B3, "cFbBlock") == "Yes";
		string string_ = fGolike.method_93(B18383B3, "cToken");
		if (Convert.ToInt32(fGolike.method_113("cbbChangeIP")) == 1)
		{
			E4A35533 = fGolike.method_93(B18383B3, "cProxy");
			D5A8B0B1 = (E4A35533.EndsWith("*1") ? 1 : 0);
			if (E4A35533.EndsWith("*0") || E4A35533.EndsWith("*1"))
			{
				E4A35533 = E4A35533.Substring(0, E4A35533.Length - 2);
			}
		}
		if (string_1 == "")
		{
			string_1 = CheckInfoAccountv2.GetName(CEAF9D00, E4A35533, D5A8B0B1);
		}
		E12BBDB2 = new Class65(AC9A1690, string_3, E4A35533, D5A8B0B1, string_);
	}

	public void method_0(int C28A33A4, string A3A12C34, int int_3 = -1)
	{
		if (int_3 == -1)
		{
			fGolike.method_86(C28A33A4, A3A12C34);
			return;
		}
		int tickCount = Environment.TickCount;
		while ((Environment.TickCount - tickCount) / 1000 - int_3 < 0 && !bool_0)
		{
			fGolike.method_86(C28A33A4, A3A12C34.Replace("{time}", (int_3 - (Environment.TickCount - tickCount) / 1000).ToString()));
			method_8(0.5);
		}
	}

	public int EE0C7B88()
	{
		try
		{
			string text = fGolike.method_93(int_0, "cJob").Trim();
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
		catch (Exception)
		{
		}
		return 0;
	}

	public void method_1(int int_3)
	{
		int num = EE0C7B88();
		string text = "(" + DateTime.Now.ToString("dd/MM/yyyy") + ") " + (int_3 + num);
		fGolike.BC0C40BD(int_0, "cJob", text, "job");
	}

	private bool method_2()
	{
		int num = Convert.ToInt32(fGolike.method_113("nudMaxJobToday"));
		if (EE0C7B88() >= num)
		{
			fGolike.method_86(int_0, "Max Job Today!");
			return true;
		}
		return false;
	}

	public void method_3()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				bool_0 = false;
				if (E12BBDB2.string_2 == "")
				{
					string text = method_11();
					if (text == "")
					{
						goto IL_0490;
					}
					E12BBDB2.string_2 = text;
				}
				while (!method_4() && !method_2() && !method_4())
				{
					List<GClass16> list = new List<GClass16>();
					string text2 = "";
					while (!method_4())
					{
						method_0(int_0, "Get job...");
						(list, text2) = GClass16.smethod_0(fGolike.method_113("txtApiKey").ToString(), CEAF9D00, string_1, "", fGolike.method_113("jobType").ToString(), 2);
						if (list.Count <= 0 && (!(text2 != "") || !(text2 != "Vui lòng đăng nhập lại") || (!(text2 == "làm quá jobs trong ngày") && num != 0)))
						{
							method_0(int_0, "Get job sau {time}s...", Convert.ToInt32(fGolike.method_113("nudDelayGetJob")));
							continue;
						}
						goto IL_014c;
					}
					break;
					IL_014c:
					if (text2 != "")
					{
						fGolike.method_86(int_0, "Get job fail: " + text2);
						break;
					}
					if (method_4())
					{
						break;
					}
					for (int i = 0; i < list.Count; i++)
					{
						if (method_4())
						{
							goto end_IL_0465;
						}
						GClass16 gClass = list[i];
						method_0(int_0, gClass.F88FDA31 + "...");
						(bool, string) tuple2 = method_12(gClass);
						if (tuple2.Item1)
						{
							if (F72EE4A0)
							{
								F72EE4A0 = false;
								fGolike.BC0C40BD(int_0, "cFbBlock", "", "fbBlock");
							}
							gClass.method_0(tuple2.Item1);
							num++;
							int_1 = 0;
							fGolike.method_96(int_0, 2);
							method_1(1);
							if (method_2())
							{
								goto end_IL_0465;
							}
							if (Convert.ToBoolean(fGolike.method_113("ckbBreakTime")) && num % Convert.ToInt32(fGolike.method_113("nudBreakTimeJob")) == 0)
							{
								i = list.Count;
								method_0(int_0, string.Format("Nghỉ sau {0} job success, đợi {{time}}s...", Convert.ToInt32(fGolike.method_113("nudBreakTimeJob"))), Convert.ToInt32(fGolike.method_113("nudBreakTime")));
							}
							else
							{
								method_0(int_0, gClass.F88FDA31 + " success, đợi {time}s...", Common.DelayRandom(Convert.ToInt32(fGolike.method_113("nudDelayFrom")), Convert.ToInt32(fGolike.method_113("nudDelayTo"))));
							}
						}
						else
						{
							bool flag = false;
							if (tuple2.Item2.Contains("job_die"))
							{
								flag = true;
								tuple2.Item2 = gClass.String_1 + ": job_die";
							}
							else if (tuple2.Item2.Contains("fb_blocked"))
							{
								int_2++;
								tuple2.Item2 = gClass.String_1 + ": fb_blocked";
							}
							else if (tuple2.Item2.Contains("token_die"))
							{
								tuple2.Item2 = gClass.String_1 + ": token_die";
							}
							GClass16.smethod_2(gClass, tuple2.Item2, CEAF9D00);
							gClass.method_0(tuple2.Item1, tuple2.Item2, flag);
							if (method_4() || method_4() || method_5())
							{
								goto end_IL_0465;
							}
							if (!flag)
							{
								int_1++;
								if (method_6())
								{
									goto end_IL_0465;
								}
							}
						}
						if (E12BBDB2.string_2 == "")
						{
							i = list.Count;
							string text3 = method_11();
							if (text3 == "")
							{
								goto end_IL_0465;
							}
							E12BBDB2.string_2 = text3;
						}
					}
					continue;
					end_IL_0465:
					break;
				}
				goto IL_0490;
				IL_0490:
				if (bool_0)
				{
					fGolike.method_86(int_0, "Đã dừng!");
				}
				fGolike.method_118(int_0);
				if (fGolike.method_97(int_0) == 2)
				{
					fGolike.method_96(int_0, 0);
				}
				fGolike.B034598F(int_0, "cChose", false);
				fGolike.method_61();
				fGolike.BC0C40BD(int_0, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
			}
			catch (Exception ex)
			{
				MessageBoxHelper.Show("Start\n" + ex.ToString());
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private bool method_4()
	{
		if (bool_0)
		{
			fGolike.method_86(int_0, "Đã dừng!");
			return true;
		}
		return false;
	}

	private bool method_5()
	{
		if (int_2 >= 1)
		{
			fGolike.method_86(int_0, "Fb blocked!");
			fGolike.BC0C40BD(int_0, "cFbBlock", "Yes", "fbBlock");
			return true;
		}
		return false;
	}

	private bool method_6()
	{
		int num = Convert.ToInt32(fGolike.method_113("nudMaxJobFailLienTiep"));
		if (int_1 >= num)
		{
			fGolike.BC0C40BD(int_0, "cFbBlock", "Yes", "fbBlock");
			fGolike.method_86(int_0, num + " job fail!");
			return true;
		}
		return false;
	}

	public void method_7()
	{
		bool_0 = true;
	}

	public void CD2B50A8(int int_3, int int_4)
	{
		int num = Common.DelayRandom(int_3, int_4);
		method_8(num);
	}

	public void method_8(double D784BF81)
	{
		int tickCount = Environment.TickCount;
		while (!bool_0 && !((double)(Environment.TickCount - tickCount) > D784BF81 * 1000.0))
		{
			Thread.Sleep(500);
		}
	}

	private Chrome method_9()
	{
		Chrome f336F52E = new Chrome();
		try
		{
			method_0(int_0, Language.GetValue("Chờ mơ\u0309 chrome..."));
			lock (fGolike.D685EAA7)
			{
				if (!bool_0)
				{
					while (true)
					{
						if (fGolike.method_114() < Convert.ToInt32(fGolike.method_113("nudMaxChrome")))
						{
							fGolike.E01D903C();
							break;
						}
						if (!bool_0)
						{
							method_8(1.0);
							continue;
						}
						goto end_IL_002c;
					}
					goto IL_009c;
				}
				end_IL_002c:;
			}
			goto end_IL_0006;
			IL_009c:
			if (!bool_0)
			{
				lock (fGolike.BF286719)
				{
					if (fGolike.int_3 > 0)
					{
						int int_ = Common.DelayRandom(Convert.ToInt32(fGolike.method_113("nudDelayOpenChromeFrom")), Convert.ToInt32(fGolike.method_113("nudDelayOpenChromeTo")));
						method_0(int_0, "Open chrome {time}s...", int_);
					}
					else
					{
						fGolike.int_3++;
					}
				}
				if (!bool_0)
				{
					method_0(int_0, "Open chrome...");
					string b59D = "data:,";
					Point c81213A = Common.GetPointFromIndexPosition(int_0 % 10, 5, 2);
					Point point_ = Common.GetSizeChrome(5, 2);
					f336F52E.Size = point_;
					f336F52E.Position = c81213A;
					f336F52E.App = b59D;
					f336F52E.DisableImage = Convert.ToBoolean(fGolike.method_113("ckbShowImageInteract"));
					f336F52E.HideBrowser = Convert.ToBoolean(fGolike.method_113("ckbHideBrowser"));
					f336F52E.IndexChrome = int_0;
					f336F52E.Proxy = E4A35533;
					f336F52E.TypeProxy = D5A8B0B1;
					f336F52E.cId = string_0;
					f336F52E.cUid = CEAF9D00;
					f336F52E.cPassword = ED0CA414;
					f336F52E.cFa2 = A287EA01;
					f336F52E.UserAgent = string_3;
					string text = SettingsTool.GetPathProfile();
					string b1AFA4A = "";
					if (text != "" && f336F52E.cUid != "")
					{
						b1AFA4A = text + "\\" + f336F52E.cUid;
					}
					if (!SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCreateProfile"))
					{
						b1AFA4A = "";
					}
					f336F52E.ProfilePath = b1AFA4A;
					if (!bool_0)
					{
						var (flag, text2) = f336F52E.Open();
						if (!flag)
						{
							method_0(int_0, Language.GetValue("Lỗi mở trình duyệt!") + ((text2 != "") ? (" (" + text2 + ")") : ""));
							f336F52E = null;
						}
					}
				}
			}
			end_IL_0006:;
		}
		catch (Exception)
		{
		}
		return f336F52E;
	}

	private void E196D5AE()
	{
		if (f336F52E_0 != null)
		{
			f336F52E_0.CloseChrome();
		}
		f336F52E_0 = null;
		fGolike.method_115();
	}

	private bool method_10(int int_3)
	{
		bool flag = false;
		try
		{
			f336F52E_0 = method_9();
			bool bool_;
			string text;
			if (!method_4() && f336F52E_0 != null)
			{
				method_0(int_3, "Login...");
				bool_ = false;
				text = "https://www.facebook.com/";
				switch (Convert.ToInt32(fGolike.method_113("cbbFacebookWeb")))
				{
				case 0:
					text = "https://mobile.facebook.com/";
					break;
				case 2:
					text = "https://mbasic.facebook.com";
					break;
				case 3:
					bool_ = true;
					break;
				}
				if (!f336F52E_0.GetURL().Contains("facebook.com"))
				{
					f336F52E_0.GotoURL(text);
					if (f336F52E_0.GetCookieFromChrome().Contains("i_user"))
					{
						f336F52E_0.DeleteCookieNamedz("i_user");
						f336F52E_0.GotoURL(text);
						f336F52E_0.RetoreSize();
						f336F52E_0.D8B8FC06();
					}
				}
				if (!(f336F52E_0.Proxy != ""))
				{
					goto IL_0151;
				}
				f336F52E_0.DelayTime(2.0);
				if (!(f336F52E_0.GetPageSource() == "<html><head></head><body></body></html>"))
				{
					goto IL_0151;
				}
				method_0(int_3, "Proxy yêu cầu User/Pass!");
			}
			goto end_IL_0002;
			IL_027e:
			int num;
			string text2;
			if (!method_4())
			{
				if (!flag)
				{
					num = Convert.ToInt32(fGolike.method_113("cbbTypeLogin"));
					bool flag2 = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDontSaveBrowser");
					switch (num)
					{
					case 1:
						method_0(int_3, Language.GetValue("Đăng nhâ\u0323p bă\u0300ng email|pass..."));
						goto default;
					case 2:
					case 3:
						method_0(int_3, Language.GetValue("Đăng nhâ\u0323p bă\u0300ng cookie..."));
						goto default;
					case 0:
						method_0(int_3, Language.GetValue("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
						goto default;
					default:
					{
						text2 = CommonChrome.LoginFacebook(f336F52E_0, num, text, CEAF9D00, string_2, ED0CA414, A287EA01, AC9A1690, flag2, bool_);
						if (num != 3 || new List<string> { "1", "2", "8" }.Contains(text2))
						{
							break;
						}
						num = 0;
						int num2 = 0;
						int num3 = 0;
						goto case 0;
					}
					}
					string text3 = text2;
					string text4 = text3;
					if (text4 == null)
					{
						goto IL_06c2;
					}
					int length = text4.Length;
					if (length != 1)
					{
						if (length != 2)
						{
							goto IL_06c2;
						}
						char c = text4[1];
						if (c != '2')
						{
							if (c != '3' || !(text4 == "-3"))
							{
								goto IL_06c2;
							}
							method_0(int_3, "No internet!");
						}
						else
						{
							if (!(text4 == "-2"))
							{
								goto IL_06c2;
							}
							method_0(int_3, "Chrome bị đóng!");
						}
					}
					else
					{
						switch (text4[0])
						{
						case '0':
							break;
						case '1':
							goto IL_047c;
						case '2':
							goto IL_04fb;
						case '3':
							goto IL_0596;
						case '4':
							goto IL_05be;
						case '5':
							goto IL_05d5;
						case '6':
							goto IL_05fd;
						case '8':
							goto IL_0614;
						case '9':
							goto IL_06b3;
						default:
							goto IL_06c2;
						}
						method_0(int_3, Language.GetValue("Đăng nhập thất bại!"));
					}
				}
				goto IL_06fc;
			}
			goto end_IL_0002;
			IL_047c:
			flag = true;
			if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || AC9A1690 == "")
			{
				AC9A1690 = f336F52E_0.GetCookieFromChrome();
				if (AC9A1690 != "")
				{
					fGolike.BC0C40BD(int_3, "cCookies", AC9A1690, "cookie1");
				}
			}
			goto IL_06fc;
			IL_06c2:
			if (text2.Contains("Invalid username or password") || text2.Contains("Tên người dùng hoặc mật khẩu không hợp lệ"))
			{
				fGolike.method_87(int_3, "Changed pass");
			}
			method_0(int_3, text2);
			goto IL_06fc;
			IL_06fc:
			if (fGolike.method_93(int_3, "cInfo").Contains("Checkpoint"))
			{
				method_0(int_3, "Checking...");
				fGolike.AE1FE684(int_3, "", AC9A1690, E4A35533, D5A8B0B1);
				string text5 = fGolike.D491BE25(int_3);
				if (text5.Contains("956") && Convert.ToBoolean(fGolike.method_113("ckbUnlock956")))
				{
					EF086887 ef086887_ = new EF086887(AC9A1690, string_3, E4A35533, D5A8B0B1);
					fGolike.method_24(int_3, "", ef086887_);
					flag = fGolike.method_92(int_3).Contains("Live");
				}
			}
			if (!flag)
			{
				fGolike.method_96(int_3, 1);
			}
			else
			{
				fGolike.method_87(int_3, "Live");
				method_0(int_3, Language.GetValue("Đăng nhâ\u0323p tha\u0300nh công!"));
				fGolike.method_96(int_3, 2);
				if (!method_4() && f336F52E_0.CheckExistElement("[href=\"/\"]") == 0)
				{
					f336F52E_0.AcceptCookie();
					if (f336F52E_0.GetURL().Contains("facebook.com/si/actor_experience/actor_gateway") && f336F52E_0.CheckExistElement("[data-nt=\"NT:IMAGE\"]", 15.0) == 1)
					{
						f336F52E_0.ExecuteJSClick("[data-nt=\"NT:IMAGE\"]");
						f336F52E_0.DelayTime(2.0);
					}
					if (f336F52E_0.CheckExistElement("[data-cookiebanner=\"accept_button\"]") == 1)
					{
						f336F52E_0.ExecuteJSClick("[data-cookiebanner=\"accept_button\"]");
					}
					if (f336F52E_0.GetFbWeb() == 2)
					{
						f336F52E_0.ExecuteJSClickFB(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
					}
					if (f336F52E_0.GetURL().StartsWith("https://free.facebook.com/") || f336F52E_0.CheckExistElement("[href^=\"/upsell/advanced_upsell/in_line\"]") == 1)
					{
						f336F52E_0.ExecuteJSClickFB(0, "[href^=\"/upsell/advanced_upsell/in_line\"]");
						f336F52E_0.ExecuteJSClickFB(5, "#upsell_upgrade_confirm_button");
					}
				}
			}
			goto end_IL_0002;
			IL_06b3:
			method_0(int_3, "Facebook blocked!");
			goto IL_06fc;
			IL_05d5:
			method_0(int_3, Language.GetValue("Mật khẩu không đúng!"));
			fGolike.method_87(int_3, "Changed pass");
			goto IL_06fc;
			IL_05be:
			method_0(int_3, Language.GetValue("Tài khoản không đúng!"));
			goto IL_06fc;
			IL_05fd:
			method_0(int_3, Language.GetValue("Mã 2fa không đúng!"));
			goto IL_06fc;
			IL_0596:
			if (num != 2)
			{
				method_0(int_3, Language.GetValue("Không có 2fa!"));
			}
			else
			{
				flag = true;
			}
			goto IL_06fc;
			IL_0614:
			fGolike.method_87(int_3, "Live");
			fGolike.method_96(int_3, 2);
			if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || AC9A1690 == "")
			{
				AC9A1690 = f336F52E_0.GetCookieFromChrome();
				if (AC9A1690 != "")
				{
					fGolike.BC0C40BD(int_3, "cCookies", AC9A1690, "cookie1");
				}
			}
			method_0(int_3, "Account Novery!");
			goto IL_06fc;
			IL_04fb:
			method_0(int_3, "Checkpoint!");
			fGolike.method_87(int_3, "Checkpoint");
			if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || AC9A1690 == "")
			{
				AC9A1690 = f336F52E_0.GetCookieFromChrome();
				if (AC9A1690 != "")
				{
					fGolike.BC0C40BD(int_3, "cCookies", AC9A1690, "cookie1");
				}
			}
			goto IL_06fc;
			IL_0151:
			if (!(f336F52E_0.ProfilePath.Trim() != ""))
			{
				goto IL_027e;
			}
			f336F52E_0.AcceptCookie();
			switch (CommonChrome.CheckLiveCookie(f336F52E_0, text))
			{
			case -3:
				method_0(int_3, "No internet!");
				goto end_IL_0002;
			case -2:
				method_0(int_3, "Chrome bị đóng!");
				goto end_IL_0002;
			case 1:
				flag = true;
				goto IL_027e;
			case 2:
				break;
			default:
				goto IL_027e;
			}
			method_0(int_3, "Checkpoint!");
			fGolike.method_87(int_3, "Checkpoint");
			if (SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie") || AC9A1690 == "")
			{
				AC9A1690 = f336F52E_0.GetCookieFromChrome();
				if (AC9A1690 != "")
				{
					fGolike.BC0C40BD(int_3, "cCookies", AC9A1690, "cookie1");
				}
			}
			goto IL_06fc;
			end_IL_0002:;
		}
		catch (Exception)
		{
		}
		return flag;
	}

	public string C48D8789()
	{
		string text = "";
		bool flag;
		if (flag = method_10(int_0))
		{
			text = f336F52E_0.GetCookieFromChrome();
		}
		E196D5AE();
		if (text != "")
		{
			fGolike.BC0C40BD(int_0, "cCookies", text, "cookie1");
		}
		else if (!bool_0 && flag)
		{
			fGolike.method_86(int_0, "Không lấy được cookie!");
		}
		return text;
	}

	public string method_11()
	{
		string text = "";
		int num = Convert.ToInt32(fGolike.method_113("cbbTypeGetToken"));
		bool flag = false;
		if (num == 0)
		{
			if ((flag = method_10(int_0)) && !method_4())
			{
				E12BBDB2.D791CF00 = f336F52E_0.GetCookieFromChrome();
				fGolike.method_86(int_0, "Get token...");
				text = f336F52E_0.GetTokenEAAG();
			}
			E196D5AE();
		}
		if (text != "")
		{
			fGolike.BC0C40BD(int_0, "cToken", text, "token");
		}
		else if (!bool_0 && flag)
		{
			fGolike.method_86(int_0, "Không lấy được token!");
		}
		return text;
	}

	public (bool isSuccess, string error) method_12(GClass16 BA3CF017)
	{
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("id", BA3CF017.String_1);
		(bool, string) result = (false, "");
		try
		{
			string f88FDA = BA3CF017.F88FDA31;
			string text = f88FDA;
			if (text != null)
			{
				switch (text.Length)
				{
				default:
					goto end_IL_0023;
				case 3:
					switch (text[0])
					{
					default:
						goto end_IL_0023;
					case 'w':
						if (text == "wow")
						{
							break;
						}
						goto end_IL_0023;
					case 's':
						if (text == "sad")
						{
							break;
						}
						goto end_IL_0023;
					}
					goto IL_0181;
				case 4:
				{
					char c = text[2];
					if ((uint)c > 107u)
					{
						switch (c)
						{
						default:
							goto end_IL_0023;
						case 'v':
							if (text == "love")
							{
								break;
							}
							goto end_IL_0023;
						case 'r':
							if (text == "care")
							{
								break;
							}
							goto end_IL_0023;
						}
						goto IL_0181;
					}
					if (c != 'h')
					{
						if (c == 'k' && text == "like")
						{
							break;
						}
					}
					else if (text == "haha")
					{
						goto IL_0181;
					}
					goto end_IL_0023;
				}
				case 5:
					switch (text[0])
					{
					default:
						goto end_IL_0023;
					case 's':
						if (text == "share")
						{
							result = E12BBDB2.method_6(gClass);
						}
						goto end_IL_0023;
					case 'a':
						if (text == "angry")
						{
							break;
						}
						goto end_IL_0023;
					}
					goto IL_0181;
				case 6:
					if (text == "follow")
					{
						goto IL_0210;
					}
					goto end_IL_0023;
				case 7:
					if (text == "comment")
					{
						gClass.GetJson("content", BA3CF017.B73B363D);
						result = E12BBDB2.C79C56AA(gClass);
					}
					goto end_IL_0023;
				case 9:
					if (text == "like_page")
					{
						goto IL_0210;
					}
					goto end_IL_0023;
				case 10:
					if (text == "join_group")
					{
						goto IL_0210;
					}
					goto end_IL_0023;
				case 12:
					if (text == "like_comment")
					{
						break;
					}
					goto end_IL_0023;
				case 8:
				case 11:
					goto end_IL_0023;
					IL_0210:
					result = E12BBDB2.F51A8802(BA3CF017.F88FDA31, gClass);
					goto end_IL_0023;
					IL_0181:
					gClass.GetJson("reaction", BA3CF017.F88FDA31);
					result = E12BBDB2.F51A8802("reaction", gClass);
					goto end_IL_0023;
				}
				if (BA3CF017.F88FDA31 == "like")
				{
					result = E12BBDB2.method_4(gClass);
				}
				else if (BA3CF017.F88FDA31 == "like_comment")
				{
					result = E12BBDB2.method_5(gClass);
				}
				if (!result.Item1 && result.Item2 != "fb_blocked" && Convert.ToInt32(fGolike.method_113("cbbCheDoChay")) == 0)
				{
					string item = result.Item2;
					gClass.GetJson("reaction", "like");
					result = E12BBDB2.F51A8802("reaction", gClass);
					if (!result.Item1 && result.Item2 == "" && item != "")
					{
						result.Item2 = item;
					}
				}
			}
			end_IL_0023:;
		}
		catch (Exception ex)
		{
			GClass16.smethod_2(BA3CF017, ex.ToString(), CEAF9D00);
		}
		return result;
	}

	[CompilerGenerated]
	private void method_13()
	{
		try
		{
			int num = 0;
			bool_0 = false;
			if (E12BBDB2.string_2 == "")
			{
				string text = method_11();
				if (text == "")
				{
					goto IL_0490;
				}
				E12BBDB2.string_2 = text;
			}
			while (!method_4() && !method_2() && !method_4())
			{
				List<GClass16> list = new List<GClass16>();
				string text2 = "";
				while (!method_4())
				{
					method_0(int_0, "Get job...");
					(list, text2) = GClass16.smethod_0(fGolike.method_113("txtApiKey").ToString(), CEAF9D00, string_1, "", fGolike.method_113("jobType").ToString(), 2);
					if (list.Count <= 0 && (!(text2 != "") || !(text2 != "Vui lòng đăng nhập lại") || (!(text2 == "làm quá jobs trong ngày") && num != 0)))
					{
						method_0(int_0, "Get job sau {time}s...", Convert.ToInt32(fGolike.method_113("nudDelayGetJob")));
						continue;
					}
					goto IL_014c;
				}
				break;
				IL_014c:
				if (!(text2 != ""))
				{
					if (method_4())
					{
						break;
					}
					for (int i = 0; i < list.Count; i++)
					{
						if (method_4())
						{
							goto end_IL_0465;
						}
						GClass16 gClass = list[i];
						method_0(int_0, gClass.F88FDA31 + "...");
						(bool, string) tuple2 = method_12(gClass);
						if (tuple2.Item1)
						{
							if (F72EE4A0)
							{
								F72EE4A0 = false;
								fGolike.BC0C40BD(int_0, "cFbBlock", "", "fbBlock");
							}
							gClass.method_0(tuple2.Item1);
							num++;
							int_1 = 0;
							fGolike.method_96(int_0, 2);
							method_1(1);
							if (method_2())
							{
								goto end_IL_0465;
							}
							if (Convert.ToBoolean(fGolike.method_113("ckbBreakTime")) && num % Convert.ToInt32(fGolike.method_113("nudBreakTimeJob")) == 0)
							{
								i = list.Count;
								method_0(int_0, string.Format("Nghỉ sau {0} job success, đợi {{time}}s...", Convert.ToInt32(fGolike.method_113("nudBreakTimeJob"))), Convert.ToInt32(fGolike.method_113("nudBreakTime")));
							}
							else
							{
								method_0(int_0, gClass.F88FDA31 + " success, đợi {time}s...", Common.DelayRandom(Convert.ToInt32(fGolike.method_113("nudDelayFrom")), Convert.ToInt32(fGolike.method_113("nudDelayTo"))));
							}
						}
						else
						{
							bool flag = false;
							if (tuple2.Item2.Contains("job_die"))
							{
								flag = true;
								tuple2.Item2 = gClass.String_1 + ": job_die";
							}
							else if (tuple2.Item2.Contains("fb_blocked"))
							{
								int_2++;
								tuple2.Item2 = gClass.String_1 + ": fb_blocked";
							}
							else if (tuple2.Item2.Contains("token_die"))
							{
								tuple2.Item2 = gClass.String_1 + ": token_die";
							}
							GClass16.smethod_2(gClass, tuple2.Item2, CEAF9D00);
							gClass.method_0(tuple2.Item1, tuple2.Item2, flag);
							if (method_4() || method_4() || method_5())
							{
								goto end_IL_0465;
							}
							if (!flag)
							{
								int_1++;
								if (method_6())
								{
									goto end_IL_0465;
								}
							}
						}
						if (E12BBDB2.string_2 == "")
						{
							i = list.Count;
							string text3 = method_11();
							if (text3 == "")
							{
								goto end_IL_0465;
							}
							E12BBDB2.string_2 = text3;
						}
					}
					continue;
				}
				fGolike.method_86(int_0, "Get job fail: " + text2);
				break;
				continue;
				end_IL_0465:
				break;
			}
			goto IL_0490;
			IL_0490:
			if (bool_0)
			{
				fGolike.method_86(int_0, "Đã dừng!");
			}
			fGolike.method_118(int_0);
			if (fGolike.method_97(int_0) == 2)
			{
				fGolike.method_96(int_0, 0);
			}
			fGolike.B034598F(int_0, "cChose", false);
			fGolike.method_61();
			fGolike.BC0C40BD(int_0, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Start\n" + ex.ToString());
		}
	}
}
