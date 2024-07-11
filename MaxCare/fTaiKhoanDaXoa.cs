using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WindowsFormsControlLibrary1;

public class fTaiKhoanDaXoa : Form
{
	[CompilerGenerated]
	private sealed class DFA5D3A8
	{
		public fTaiKhoanDaXoa B7954F25;

		public List<string> C61DF78B;

		internal void method_0()
		{
			try
			{
				string text = "";
				for (int i = 0; i < B7954F25.dtgvAcc.RowCount; i++)
				{
					text = B7954F25.CA943614(i, "cGhiChu");
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
						if (text != "" && !C61DF78B.Contains(text))
						{
							C61DF78B.Add(text);
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
	private sealed class C8A480BD
	{
		public fTaiKhoanDaXoa fTaiKhoanDaXoa_0;

		public List<string> list_0;

		internal void method_0()
		{
			try
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < fTaiKhoanDaXoa_0.dtgvAcc.RowCount; i++)
				{
					text = fTaiKhoanDaXoa_0.CA943614(i, "cStatus").Trim();
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

		internal void DDB0763B()
		{
			try
			{
				string text = "";
				for (int i = 0; i < fTaiKhoanDaXoa_0.dtgvAcc.RowCount; i++)
				{
					text = fTaiKhoanDaXoa_0.CA943614(i, "cInfo");
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
	private sealed class Class57
	{
		public string string_0;

		public fTaiKhoanDaXoa B3308F25;

		internal void F79DB59A()
		{
			try
			{
				if (string_0 == "start")
				{
					B3308F25.BA918591.Enabled = false;
					B3308F25.method_9();
				}
				else if (string_0 == "stop")
				{
					B3308F25.BA918591.Enabled = true;
					B3308F25.method_10();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class58
	{
		public fTaiKhoanDaXoa fTaiKhoanDaXoa_0;

		public int EB84BEA1;

		public int int_0;

		public int CD1398AC;

		public bool bool_0;

		internal void method_0()
		{
			fTaiKhoanDaXoa_0.method_12("start");
			int num = 0;
			while (num < fTaiKhoanDaXoa_0.dtgvAcc.Rows.Count && !fTaiKhoanDaXoa_0.bool_0)
			{
				if (Convert.ToBoolean(fTaiKhoanDaXoa_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (EB84BEA1 < int_0)
					{
						Class59 CS_0024_003C_003E8__locals0 = new Class59
						{
							class58_0 = this
						};
						Interlocked.Increment(ref EB84BEA1);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.CC9B882B(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang kiểm tra..."));
							switch (CS_0024_003C_003E8__locals0.class58_0.CD1398AC)
							{
							case 0:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.D387202E(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 1:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.method_15(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 2:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.method_16(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 3:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.method_17(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 4:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.FFBAED86(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 5:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.method_13(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class58_0.bool_0);
								break;
							case 6:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.method_19(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class58_0.bool_0);
								break;
							case 7:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.method_14(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 8:
								CS_0024_003C_003E8__locals0.class58_0.fTaiKhoanDaXoa_0.F221DF2E(CS_0024_003C_003E8__locals0.int_0);
								break;
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class58_0.EB84BEA1);
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
			while (EB84BEA1 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.Sleep(1.0);
			}
			fTaiKhoanDaXoa_0.method_12("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class59
	{
		public int int_0;

		public Class58 class58_0;

		internal void F0AACE30()
		{
			class58_0.fTaiKhoanDaXoa_0.CC9B882B(int_0, Language.GetValue("Đang kiểm tra..."));
			switch (class58_0.CD1398AC)
			{
			case 0:
				class58_0.fTaiKhoanDaXoa_0.D387202E(int_0);
				break;
			case 1:
				class58_0.fTaiKhoanDaXoa_0.method_15(int_0);
				break;
			case 2:
				class58_0.fTaiKhoanDaXoa_0.method_16(int_0);
				break;
			case 3:
				class58_0.fTaiKhoanDaXoa_0.method_17(int_0);
				break;
			case 4:
				class58_0.fTaiKhoanDaXoa_0.FFBAED86(int_0);
				break;
			case 5:
				class58_0.fTaiKhoanDaXoa_0.method_13(int_0, class58_0.bool_0);
				break;
			case 6:
				class58_0.fTaiKhoanDaXoa_0.method_19(int_0, class58_0.bool_0);
				break;
			case 7:
				class58_0.fTaiKhoanDaXoa_0.method_14(int_0);
				break;
			case 8:
				class58_0.fTaiKhoanDaXoa_0.F221DF2E(int_0);
				break;
			}
			Interlocked.Decrement(ref class58_0.EB84BEA1);
		}
	}

	[CompilerGenerated]
	private sealed class Class60
	{
		public fTaiKhoanDaXoa fTaiKhoanDaXoa_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			fTaiKhoanDaXoa_0.method_12("start");
			int num = 0;
			while (num < fTaiKhoanDaXoa_0.dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (fTaiKhoanDaXoa_0.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(fTaiKhoanDaXoa_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						E59C6B99 CS_0024_003C_003E8__locals0 = new E59C6B99
						{
							class60_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class60_0.fTaiKhoanDaXoa_0.CC9B882B(CS_0024_003C_003E8__locals0.int_0, Language.GetValue("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.class60_0.fTaiKhoanDaXoa_0.method_21(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class60_0.int_0);
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
			fTaiKhoanDaXoa_0.method_12("stop");
		}
	}

	[CompilerGenerated]
	private sealed class E59C6B99
	{
		public int int_0;

		public Class60 class60_0;

		internal void method_0()
		{
			class60_0.fTaiKhoanDaXoa_0.CC9B882B(int_0, Language.GetValue("Đang kiểm tra..."));
			class60_0.fTaiKhoanDaXoa_0.method_21(int_0);
			Interlocked.Decrement(ref class60_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class AEB4E0BC
	{
		public int int_0;

		public int BE851F19;

		public fTaiKhoanDaXoa fTaiKhoanDaXoa_0;

		internal void C8B530B2()
		{
			int num = 0;
			while (num < fTaiKhoanDaXoa_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fTaiKhoanDaXoa_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < BE851F19)
					{
						F3821F85 CS_0024_003C_003E8__locals0 = new F3821F85
						{
							aeb4E0BC_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.CF05A7A6 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.aeb4E0BC_0.fTaiKhoanDaXoa_0.CC9B882B(CS_0024_003C_003E8__locals0.CF05A7A6, Language.GetValue("Đang xo\u0301a profile..."));
							CS_0024_003C_003E8__locals0.aeb4E0BC_0.fTaiKhoanDaXoa_0.method_22(CS_0024_003C_003E8__locals0.CF05A7A6);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.aeb4E0BC_0.int_0);
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
	private sealed class F3821F85
	{
		public int CF05A7A6;

		public AEB4E0BC aeb4E0BC_0;

		internal void method_0()
		{
			aeb4E0BC_0.fTaiKhoanDaXoa_0.CC9B882B(CF05A7A6, Language.GetValue("Đang xo\u0301a profile..."));
			aeb4E0BC_0.fTaiKhoanDaXoa_0.method_22(CF05A7A6);
			Interlocked.Decrement(ref aeb4E0BC_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class61
	{
		public fTaiKhoanDaXoa FE14BBB5;

		public int A5937002;

		public int int_0;

		public string FC050D80;

		internal void method_0()
		{
			int num = 0;
			while (num < FE14BBB5.dtgvAcc.RowCount)
			{
				if (Convert.ToBoolean(FE14BBB5.CA943614(num, "cChose")))
				{
					if (A5937002 < int_0)
					{
						Class62 CS_0024_003C_003E8__locals0 = new Class62
						{
							class61_0 = this
						};
						Interlocked.Increment(ref A5937002);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class61_0.FE14BBB5.CC9B882B(CS_0024_003C_003E8__locals0.int_0, "Check profile...");
							CS_0024_003C_003E8__locals0.class61_0.FE14BBB5.method_23(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class61_0.FC050D80);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class61_0.A5937002);
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
	private sealed class Class62
	{
		public int int_0;

		public Class61 class61_0;

		internal void E200A588()
		{
			class61_0.FE14BBB5.CC9B882B(int_0, "Check profile...");
			class61_0.FE14BBB5.method_23(int_0, class61_0.FC050D80);
			Interlocked.Decrement(ref class61_0.A5937002);
		}
	}

	[CompilerGenerated]
	private sealed class DA1C3922
	{
		public fTaiKhoanDaXoa D8A9B92E;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			D8A9B92E.method_12("start");
			int num = 0;
			while (num < D8A9B92E.dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (D8A9B92E.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(D8A9B92E.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						E5904119 CS_0024_003C_003E8__locals0 = new E5904119
						{
							F185871E = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.E11ACE35 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.F185871E.D8A9B92E.CC9B882B(CS_0024_003C_003E8__locals0.E11ACE35, Language.GetValue("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.F185871E.D8A9B92E.E41010BF(CS_0024_003C_003E8__locals0.E11ACE35);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.F185871E.int_0);
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
			D8A9B92E.method_12("stop");
		}
	}

	[CompilerGenerated]
	private sealed class E5904119
	{
		public int E11ACE35;

		public DA1C3922 F185871E;

		internal void method_0()
		{
			F185871E.D8A9B92E.CC9B882B(E11ACE35, Language.GetValue("Đang kiểm tra..."));
			F185871E.D8A9B92E.E41010BF(E11ACE35);
			Interlocked.Decrement(ref F185871E.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class C5264208
	{
		public int int_0;

		public int int_1;

		public fTaiKhoanDaXoa fTaiKhoanDaXoa_0;

		internal void method_0()
		{
			int num = 0;
			while (num < fTaiKhoanDaXoa_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fTaiKhoanDaXoa_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class63 CS_0024_003C_003E8__locals0 = new Class63
						{
							c5264208_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.E50577BF = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.c5264208_0.fTaiKhoanDaXoa_0.CC9B882B(CS_0024_003C_003E8__locals0.E50577BF, Language.GetValue("Đang xo\u0301a Cache Profile..."));
							CS_0024_003C_003E8__locals0.c5264208_0.fTaiKhoanDaXoa_0.B10EAB09(CS_0024_003C_003E8__locals0.E50577BF);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.c5264208_0.int_0);
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
	private sealed class Class63
	{
		public int E50577BF;

		public C5264208 c5264208_0;

		internal void A0805BAB()
		{
			c5264208_0.fTaiKhoanDaXoa_0.CC9B882B(E50577BF, Language.GetValue("Đang xo\u0301a Cache Profile..."));
			c5264208_0.fTaiKhoanDaXoa_0.B10EAB09(E50577BF);
			Interlocked.Decrement(ref c5264208_0.int_0);
		}
	}

	private bool bool_0;

	private int int_0 = 0;

	private object object_0 = new object();

	private int int_1 = -1;

	private bool bool_1 = true;

	private object DB229586 = new object();

	private int A38767B1 = -1;

	private bool bool_2 = true;

	private bool bool_3 = false;

	private bool E2AD8200 = false;

	private int FB1C2E30 = 0;

	private IContainer icontainer_0 = null;

	public static string string_0 = "";

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox AF8B4199;

	private Button A2809128;

	private Button F280A4B4;

	private Button EA3C260E;

	private BunifuCustomLabel bunifuCustomLabel1;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem A99E220E;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem EF833C8C;

	private ToolStripMenuItem CF1FBE80;

	private ToolStripMenuItem C8B57E02;

	private ToolStripMenuItem E19FFB83;

	private ToolStripMenuItem E9258D38;

	private ToolStripMenuItem DF9450A5;

	private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

	private ToolStripMenuItem E4162C82;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem FA2F9135;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem mnuChucNang;

	private ToolStripMenuItem mailPassMailToolStripMenuItem;

	private ToolStripMenuItem ABBFFBA6;

	private ToolStripMenuItem EF179FAA;

	private ToolStripMenuItem A31ED438;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem FBBE8798;

	private ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem checkProfileToolStripMenuItem;

	private ToolStripMenuItem fAToolStripMenuItem;

	private ToolStripMenuItem tinhTrangToolStripMenuItem;

	private ToolStripMenuItem locTrungToolStripMenuItem;

	private ToolStripMenuItem uidPass2FaToolStripMenuItem;

	private BunifuDragControl bunifuDragControl_1;

	private ToolTip A980CC36;

	private ToolStripMenuItem E48FA72C;

	private ToolStripMenuItem D0B49F16;

	private ToolStripMenuItem DF1CF299;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem EDB4650D;

	private ToolStripMenuItem proxyToolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem checkAvatarToolStripMenuItem;

	private ToolStripMenuItem D7089B3D;

	private ToolStripMenuItem checkProfileToolStripMenuItem1;

	private ToolStripMenuItem checkInfoUIDToolStripMenuItem;

	private ToolStripMenuItem E88A3F85;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ToolStripMenuItem E62338AA;

	private ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem E10BDA29;

	private ToolStripMenuItem checkProxyToolStripMenuItem1;

	private ToolStripMenuItem AE8C1620;

	private ToolStripMenuItem D8B89E9C;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem B089488F;

	private StatusStrip F731FF2E;

	private ToolStripStatusLabel toolStripStatusLabel4;

	private ToolStripStatusLabel lblCountHighline;

	private ToolStripStatusLabel toolStripStatusLabel5;

	private ToolStripStatusLabel D81400AF;

	private ToolStripStatusLabel toolStripStatusLabel7;

	private ToolStripStatusLabel lblCountTotal;

	private Panel EDB05919;

	private Button BtnSearch;

	private ComboBox F997392D;

	private BunifuCustomTextbox txbSearch;

	private Panel BA918591;

	private Label label1;

	private Label label2;

	private ComboBox cbbThuMuc;

	private ComboBox cbbTinhTrang;

	private Panel panel1;

	private StatusStrip EE084518;

	public DataGridView dtgvAcc;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem F5016F30;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem F02810BC;

	private ToolStripMenuItem getTokenEAAAAUToolStripMenuItem;

	private ToolStripMenuItem getTokenEAAAAUBToolStripMenuItem;

	private ToolStripMenuItem C325F411;

	private ToolStripMenuItem checkStatusXproxyToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem B182B083;

	private Button BEA51F18;

	private Button button3;

	private Button button9;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripMenuItem A202378C;

	private DataGridViewCheckBoxColumn cChose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn C7BCAC1A;

	private DataGridViewTextBoxColumn A3BB4204;

	private DataGridViewTextBoxColumn cToken;

	private DataGridViewTextBoxColumn D129E7AF;

	private DataGridViewTextBoxColumn cEmail;

	private DataGridViewTextBoxColumn cPhone;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cFollow;

	private DataGridViewTextBoxColumn cFriend;

	private DataGridViewTextBoxColumn DA9AE1A0;

	private DataGridViewTextBoxColumn cPage;

	private DataGridViewTextBoxColumn cPagePro5;

	private DataGridViewTextBoxColumn cBirthday;

	private DataGridViewTextBoxColumn cGender;

	private DataGridViewTextBoxColumn D735B51D;

	private DataGridViewTextBoxColumn C52EF59C;

	private DataGridViewTextBoxColumn cPassMail;

	private DataGridViewTextBoxColumn cBackup;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cUseragent;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cDateCreateAcc;

	private DataGridViewTextBoxColumn cAvatar;

	private DataGridViewTextBoxColumn cProfile;

	private DataGridViewTextBoxColumn D39B6B28;

	private DataGridViewTextBoxColumn C111C000;

	private DataGridViewTextBoxColumn A53EC3AA;

	private DataGridViewTextBoxColumn C48060B1;

	private DataGridViewTextBoxColumn cLocation;

	private DataGridViewTextBoxColumn cHometown;

	private DataGridViewTextBoxColumn AC257A8E;

	private DataGridViewTextBoxColumn E4810589;

	private DataGridViewTextBoxColumn cAds;

	private DataGridViewTextBoxColumn C237E4AB;

	private DataGridViewTextBoxColumn E223F80C;

	private DataGridViewTextBoxColumn CB169920;

	private DataGridViewTextBoxColumn cJob;

	private DataGridViewTextBoxColumn D49B29AC;

	private DataGridViewTextBoxColumn cStatus;

	private ToolStripMenuItem DE87B91F;

	private ToolStripMenuItem CB08B697;

	public fTaiKhoanDaXoa()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		Language.LangCtmsAcc(ctmsAcc);
		txbSearch.B992B8A4();
	}

	protected override void OnLoad(EventArgs A5B3D39B)
	{
		Application.Idle += F39BCA23;
	}

	private void F39BCA23(object sender, EventArgs e)
	{
		Application.Idle -= F39BCA23;
		method_0();
		method_31();
		method_1(1);
		CC1AE596();
		menuStrip1.Cursor = Cursors.Hand;
	}

	private void method_0()
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
		F997392D.DataSource = new BindingSource(dataSource, null);
		F997392D.ValueMember = "Key";
		F997392D.DisplayMember = "Value";
	}

	private void method_1(int int_2 = -1)
	{
		bool_1 = false;
		DataTable dataSource = CommonSQL.C6B3348F(CAB18A83: true, bool_0: true);
		cbbThuMuc.DataSource = dataSource;
		cbbThuMuc.ValueMember = "id";
		cbbThuMuc.DisplayMember = "name";
		if (int_2 != -1 && cbbThuMuc.Items.Count >= int_2)
		{
			cbbThuMuc.SelectedIndex = int_2;
		}
		else if (cbbThuMuc.Items.Count == 2)
		{
			cbbThuMuc.SelectedIndex = -1;
		}
		bool_1 = true;
	}

	private void CC1AE596(List<string> CF310BB4 = null)
	{
		try
		{
			DataTable dataSource = CommonSQL.smethod_6(CF310BB4, EA1E5E83: false);
			cbbTinhTrang.DataSource = dataSource;
			cbbTinhTrang.ValueMember = "id";
			cbbTinhTrang.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void EA3C260E_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D301FD9B(object sender, EventArgs e)
	{
		this.F128E894();
	}

	private void C9396029(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	public void BEA51F18_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (cbbThuMuc.SelectedValue != null)
			{
				text = cbbThuMuc.SelectedValue.ToString();
			}
			method_1();
			if (text != "999999" && text != "-1")
			{
				int_1 = -1;
				cbbThuMuc.SelectedValue = text;
				return;
			}
			bool_1 = false;
			cbbThuMuc.SelectedValue = text;
			bool_1 = true;
			CC1AE596(fChonThuMuc.DE35F309);
		}
		catch (Exception)
		{
		}
	}

	private List<string> F7B8BF17()
	{
		List<string> result = null;
		try
		{
			string text = cbbThuMuc.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				result = ((text2 == "999999") ?  CollectionHelper.CloneList(fChonThuMuc.DE35F309) : new List<string> { cbbThuMuc.SelectedValue.ToString() });
			}
		}
		catch
		{
		}
		return result;
	}

	private void C9BFE690(List<string> list_0 = null, string string_1 = "")
	{
		try
		{
			dtgvAcc.Rows.Clear();
			if (string_1 == "[Tất cả tình trạng]" || string_1 == Language.GetValue("[Tất cả tình trạng]"))
			{
				string_1 = "";
			}
			DataTable f5807B = CommonSQL.C8978B14(list_0, string_1, B2A883B3: false);
			AD17A83B(f5807B);
		}
		catch (Exception)
		{
		}
	}

	private void AD17A83B(DataTable F5807B92)
	{
		DatagridviewHelper.smethod_6(dtgvAcc, F5807B92, F58C3000: true);
		CC12ED13(0);
		C139263D();
		B100FA38();
	}

	private void method_2(string string_1)
	{
		switch (string_1)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < dtgvAcc.SelectedRows.Count; k++)
			{
				int index = dtgvAcc.SelectedRows[k].Index;
				method_28(index, "cChose", !Convert.ToBoolean(CA943614(index, "cChose")));
			}
			CC12ED13();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				method_28(selectedRows[j].Index, "cChose", true);
			}
			CC12ED13();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < dtgvAcc.RowCount; l++)
			{
				method_28(l, "cChose", false);
			}
			CC12ED13(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				method_28(i, "cChose", true);
			}
			CC12ED13(dtgvAcc.RowCount);
			break;
		}
		}
	}

	private void method_3(string string_1)
	{
		if (method_25())
		{
			try
			{
				List<string> values = E691A39B(string_1);
				Common.SetTextToClipboard(string.Join("\r\n", values));
			}
			catch
			{
			}
		}
	}

	private List<string> E691A39B(string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_1.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				List<string> list3 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = CA943614(i, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = Common.GetTotp(CA943614(i, "cFa2"));
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

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_2("All");
	}

	private void CF1FBE80_Click(object sender, EventArgs e)
	{
		method_2("SelectHighline");
	}

	private void E884D2AA(object sender, EventArgs e)
	{
		method_2("UnAll");
	}

	private void D2981131(object sender, EventArgs e)
	{
		method_3("cToken");
	}

	private void E9258D38_Click(object sender, EventArgs e)
	{
		method_3("cCookies");
	}

	private void uidToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_3("cUid");
	}

	private void E8B8431A(object sender, EventArgs e)
	{
		method_3("cPassword");
	}

	private void DF9450A5_Click(object sender, EventArgs e)
	{
		method_3("cUid|cPassword");
	}

	private void E8165F2A(object sender, EventArgs e)
	{
		method_3("cUid|cPassword|cToken|cCookies");
	}

	private void method_4(object sender, EventArgs e)
	{
		Common.ShowForm(new fAddFile());
		if (fAddFile.bool_0)
		{
			method_1();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 2;
		}
	}

	private void ctmsAcc_Opening(object sender, CancelEventArgs e)
	{
		A31ED438.DropDownItems.Clear();
		List<string> list_0 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text2 = "";
				string text3 = "";
				for (int l = 0; l < dtgvAcc.RowCount; l++)
				{
					text2 = CA943614(l, "cStatus").Trim();
					if (text2 != "")
					{
						text3 = Regex.Match(text2, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
						if (text3 != "")
						{
							text2 = text2.Replace(text3, "").Trim();
						}
						text3 = Regex.Match(text2, "\\[(.*?)\\]").Value;
						if (text3 != "")
						{
							text2 = text2.Replace(text3, "").Trim();
						}
						if (text2 != "" && !list_0.Contains(text2))
						{
							list_0.Add(text2);
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
		for (int i = 0; i < list_0.Count; i++)
		{
			A31ED438.DropDownItems.Add(list_0[i]);
			A31ED438.DropDownItems[i].Click += method_6;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		list_0 = new List<string>();
		thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text = "";
				for (int k = 0; k < dtgvAcc.RowCount; k++)
				{
					text = CA943614(k, "cInfo");
					if (!text.Equals("") && !list_0.Contains(text))
					{
						list_0.Add(text);
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
			tinhTrangToolStripMenuItem.DropDownItems.Add(list_0[j]);
			tinhTrangToolStripMenuItem.DropDownItems[j].Click += method_5;
		}
		C325F411.DropDownItems.Clear();
		E2AD8200 = true;
	}

	private void method_5(object sender, EventArgs e)
	{
		method_7("cInfo", (sender as ToolStripMenuItem).Text);
	}

	private void method_6(object sender, EventArgs e)
	{
		method_7("cStatus", (sender as ToolStripMenuItem).Text);
	}

	private void method_7(string FC15E9AB, string A03C5F00)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			dtgvAcc.Rows[i].Cells["cChose"].Value = CA943614(i, FC15E9AB).Contains(A03C5F00);
		}
		CC12ED13();
	}

	private void method_8(string A12BF598)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
				}
			}
			if (CommonSQL.smethod_9(list, "idfile", A12BF598))
			{
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						dtgvAcc.Rows.RemoveAt(j--);
					}
				}
				C139263D();
				method_18();
				CC12ED13(0);
				B100FA38();
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

	private void method_9()
	{
		try
		{
			dtgvAcc.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in dtgvAcc.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}
			});
		}
		catch (Exception)
		{
		}
	}

	private void method_10()
	{
		try
		{
			dtgvAcc.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in dtgvAcc.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.Automatic;
				}
			});
		}
		catch
		{
		}
	}

	private void method_11(int F821B327, string string_1, string string_2, string string_3, int B1AB1A13)
	{
		try
		{
			RequestXNet fB87CFA = new RequestXNet(string_2, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", string_3, B1AB1A13);
			string text = fB87CFA.RequestGet("https://d.facebook.com/");
			string text2 = fB87CFA.GetAddAbsolute();
			if (text2.Contains("checkpoint/disabled"))
			{
				CC9B882B(F821B327, string_1 + "Vô hiệu hóa!");
				B7B39F35(F821B327, "Checkpoint: vhh");
				D48EFE81(F821B327, 1);
			}
			else if (text2.Contains("828281030927956"))
			{
				string text3 = "956";
				if (text.Contains("/x/checkpoint/828281030927956/stepper/"))
				{
					text3 += "-Bắt đầu";
				}
				else if (text.Contains("KGOvhWyM65Y.png") || text.Contains("CCnQRnuNDBB.png") || text.Contains("FpkwdkKVsK1.png") || text.Contains("/help/203305893040179") || text.Contains("/images/checkpoint/epsilon/comet/limbo-light.png"))
				{
					text3 += "-Tìm hiểu thêm";
				}
				else if (text.Contains("BJIhXF-EEq9.png"))
				{
					text3 += "-Bắt đầu";
				}
				CC9B882B(F821B327, string_1 + "Checkpoint " + text3 + "!");
				B7B39F35(F821B327, "Checkpoint: " + text3);
				D48EFE81(F821B327, 1);
			}
			else if (text2.Contains("1501092823525282"))
			{
				B7B39F35(F821B327, "Checkpoint: 282");
				CC9B882B(F821B327, string_1 + "Checkpoint 282!");
			}
			else if (text2.Contains("facebook.com/gettingstarted") || (text.Contains("href=\"/menu/bookmarks/") && text.Contains("id=\"mbasic_logout_button\"")) || (text.Contains("id=\"MComposer\"") && text.Contains("id=\"MBackNavBar\"")))
			{
				B7B39F35(F821B327, "Live");
				CC9B882B(F821B327, "Tài khoản live!");
				D48EFE81(F821B327, 2);
			}
			else if (text.Contains("facebook.com/login.php") || text.Contains("name=\"login\""))
			{
				CC9B882B(F821B327, string_1 + "No login!");
			}
			else if (text.Contains("confirmation") && !text.Contains("preconfirmation"))
			{
				CC9B882B(F821B327, string_1 + "Novery Live!");
				D48EFE81(F821B327, 2);
			}
			else if (text.Contains("/login/device-based/validate-pin/"))
			{
				CC9B882B(F821B327, string_1 + "Cookie bị đăng xuất!");
				D48EFE81(F821B327, 2);
			}
			else
			{
				CC9B882B(F821B327, string_1 + "Dạng Checkpoint khác!");
				D48EFE81(F821B327, 1);
			}
		}
		catch (Exception)
		{
			CC9B882B(F821B327, string_1 + "Không check được!");
		}
	}

	private void F221DF2E(int int_2)
	{
		string text = CA943614(int_2, "cCookies");
		if (text.Trim() == "")
		{
			CC9B882B(int_2, Language.GetValue("Cookie trô\u0301ng!"));
			return;
		}
		CA943614(int_2, "cUseragent").Trim();
		string text2 = "";
		int c73C0B3B = 0;
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
		{
			text2 = CA943614(int_2, "cProxy");
			c73C0B3B = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		CC9B882B(int_2, Language.GetValue("Checking..."));
		try
		{
			RequestXNet fB87CFA = new RequestXNet(text, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", text2, c73C0B3B);
			string input = fB87CFA.RequestGet("https://d.facebook.com/");
			string value = Regex.Match(text, "c_user=(\\d+)").Groups[1].Value;
			string value2 = Regex.Match(input, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			string text3 = "av=" + value + "&__user=" + value + "&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=" + value2 + "&jazoest=22037&lsd=" + value3 + "&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern";
			string text4 = "https://www.facebook.com/api/graphql/";
			string e5B = text3 + "&fb_api_req_friendly_name=useUFACSubmitActionMutation&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + value + "%22%2C%22action%22%3A%22APPEAL_HACKED_DISABLED_OPTIONS_MENU%22%2C%22enrollment_id%22%3Anull%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=6666461530033597";
			input = fB87CFA.RequestPost(text4, e5B);
			CC9B882B(int_2, "Done!");
		}
		catch (Exception)
		{
			CC9B882B(int_2, "Fail!");
		}
	}

	private void method_12(string AD2BBF0B)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (AD2BBF0B == "start")
				{
					BA918591.Enabled = false;
					method_9();
				}
				else if (AD2BBF0B == "stop")
				{
					BA918591.Enabled = true;
					method_10();
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void F999798A(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			method_2("ToggleCheck");
		}
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		BEA51F18_Click(null, null);
	}

	private void AC1CA9AB(object sender, EventArgs e)
	{
		if (!bool_1 || cbbThuMuc.SelectedValue == null || !StringHelper.CheckStringIsNumber(cbbThuMuc.SelectedValue.ToString()) || (cbbThuMuc.SelectedValue.ToString() != "999999" && int_1 == cbbThuMuc.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				CC1AE596(F7B8BF17());
			}
			else
			{
				Common.ShowForm(new fChonThuMuc(bool_2: true));
				if (!fChonThuMuc.bool_1 || fChonThuMuc.list_0 == null || fChonThuMuc.list_0.Count == 0)
				{
					bool_1 = false;
					cbbThuMuc.SelectedIndex = ((int_1 == -1) ? 1 : int_1);
					bool_1 = true;
				}
				else
				{
					CC1AE596(fChonThuMuc.list_0);
				}
			}
		}
		else
		{
			CC1AE596();
		}
		int_1 = cbbThuMuc.SelectedIndex;
	}

	private void mailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_3("cEmail|cPassMail");
	}

	private void B134852F(object sender, EventArgs e)
	{
		method_3("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void B100FA38()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void CC12ED13(int int_2 = -1)
	{
		if (int_2 == -1)
		{
			int_2 = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					int_2++;
				}
			}
		}
		D81400AF.Text = int_2.ToString();
	}

	private void E6874DBB(int int_2, bool A2209095 = false)
	{
		int EB84BEA1 = 0;
		int int_3 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		SettingsTool.GetSettings("configGeneral").GetValue("token");
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_12("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count && !bool_0)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (EB84BEA1 < int_3)
					{
						Interlocked.Increment(ref EB84BEA1);
						int int_4 = num++;
						new Thread((ThreadStart)delegate
						{
							CC9B882B(int_4, Language.GetValue("Đang kiểm tra..."));
							switch (int_2)
							{
							case 0:
								D387202E(int_4);
								break;
							case 1:
								method_15(int_4);
								break;
							case 2:
								method_16(int_4);
								break;
							case 3:
								method_17(int_4);
								break;
							case 4:
								FFBAED86(int_4);
								break;
							case 5:
								method_13(int_4, A2209095);
								break;
							case 6:
								method_19(int_4, A2209095);
								break;
							case 7:
								method_14(int_4);
								break;
							case 8:
								F221DF2E(int_4);
								break;
							}
							Interlocked.Decrement(ref EB84BEA1);
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
			while (EB84BEA1 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.Sleep(1.0);
			}
			method_12("stop");
		}).Start();
	}

	private void method_13(int int_2, bool bool_4)
	{
		try
		{
			string text = CA943614(int_2, "cId");
			string text2 = CA943614(int_2, "cUid");
			string text3 = "";
			int num = 0;
			if (bool_4)
			{
				text3 = CA943614(int_2, "cProxy");
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
					CC9B882B(int_2, Language.GetValue("Tài khoản Die!"));
					B7B39F35(int_2, "Die");
				}
				else
				{
					CC9B882B(int_2, Language.GetValue("Không check đươ\u0323c!"));
				}
			}
			else if (text5.StartsWith("1|"))
			{
				string[] array = text5.Split('|');
				string text6 = array[1];
				string text7 = array[2];
				string text8 = array[3];
				CommonSQL.B52E91B6(text, "name|friends|dateCreateAcc", text6 + "|" + text7 + "|" + text8);
				method_28(int_2, "cName", text6);
				method_28(int_2, "cFriend", text7);
				method_28(int_2, "cDateCreateAcc", text8);
				B7B39F35(int_2, "Live");
				text4 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				CC9B882B(int_2, text4);
			}
			else
			{
				CC9B882B(int_2, Language.GetValue("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			CC9B882B(int_2, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void FFBAED86(int int_2)
	{
		try
		{
			string text = "";
			string text2 = "";
			text = dtgvAcc.Rows[int_2].Cells["cEmail"].Value.ToString();
			text2 = dtgvAcc.Rows[int_2].Cells["cPassMail"].Value.ToString();
			if (text == "" || text2 == "")
			{
				CC9B882B(int_2, Language.GetValue("Không tìm thấy mail!"));
			}
			else if (Imap.CheckConnectImap(text, text2))
			{
				CC9B882B(int_2, Language.GetValue("Success!"));
				D48EFE81(int_2, 2);
			}
			else
			{
				CC9B882B(int_2, Language.GetValue("Fail!"));
				D48EFE81(int_2, 1);
			}
		}
		catch (Exception)
		{
			CC9B882B(int_2, Language.GetValue("Lỗi!"));
		}
	}

	private void method_14(int int_2)
	{
		try
		{
			string text = CA943614(int_2, "cName");
			string text2 = "";
			text2 = ((text.Trim() == "") ? Language.GetValue("Không tìm thấy tên!") : ((!Common.smethod_62(text)) ? Language.GetValue("No") : Language.GetValue("Yes")));
			CC9B882B(int_2, text2);
		}
		catch
		{
			CC9B882B(int_2, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void D387202E(int int_2)
	{
		try
		{
			CA943614(int_2, "cId");
			string text = CA943614(int_2, "cUid");
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
			CC9B882B(int_2, text3);
			if (text2 != "")
			{
				B7B39F35(int_2, text2);
			}
		}
		catch
		{
			CC9B882B(int_2, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_15(int C010C88C)
	{
		try
		{
			string text = "";
			CA943614(C010C88C, "cId");
			string f4B9183E = CA943614(C010C88C, "cCookies");
			string text2 = CA943614(C010C88C, "cToken");
			if (text2.Trim() == "")
			{
				CC9B882B(C010C88C, Language.GetValue("Token trô\u0301ng!"));
				return;
			}
			string string_ = CA943614(C010C88C, "cUseragent").Trim();
			string text3 = "";
			int f4A95EB = 0;
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
			{
				text3 = CA943614(C010C88C, "cProxy");
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
			CC9B882B(C010C88C, text4);
			if (text != "")
			{
				B7B39F35(C010C88C, text);
			}
		}
		catch
		{
			CC9B882B(C010C88C, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_16(int int_2)
	{
		try
		{
			string text = "";
			CA943614(int_2, "cId");
			string text2 = CA943614(int_2, "cCookies");
			if (text2.Trim() == "")
			{
				CC9B882B(int_2, Language.GetValue("Cookie trô\u0301ng!"));
				return;
			}
			string text3 = CA943614(int_2, "cUseragent").Trim();
			string text4 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
			{
				text4 = CA943614(int_2, "cProxy");
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
			CC9B882B(int_2, text5);
			if (text != "")
			{
				B7B39F35(int_2, text);
			}
		}
		catch
		{
			CC9B882B(int_2, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_17(int int_2)
	{
		dtgvAcc.Rows[int_2].Cells["cId"].Value.ToString();
		string text = CA943614(int_2, "cCookies");
		if (text.Trim() == "")
		{
			CC9B882B(int_2, Language.GetValue("Cookie trô\u0301ng!"));
			return;
		}
		CA943614(int_2, "cUseragent").Trim();
		string text2 = "";
		int b1AB1A = 0;
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
		{
			text2 = CA943614(int_2, "cProxy");
			b1AB1A = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		CC9B882B(int_2, Language.GetValue("Checking..."));
		method_11(int_2, "", text, text2, b1AB1A);
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		E6874DBB(0);
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?") == DialogResult.Yes)
		{
			E6874DBB(1);
		}
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		E6874DBB(3);
	}

	private void FBBE8798_Click(object sender, EventArgs e)
	{
		method_3("cEmail");
	}

	private void BtnSearch_Click(object sender, EventArgs e)
	{
		try
		{
			if (F997392D.SelectedIndex == -1)
			{
				MessageBoxHelper.Show("Vui lòng chọn kiểu tìm kiếm!", 3);
				return;
			}
			string columnName = F997392D.SelectedValue.ToString();
			string text = txbSearch.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lòng nhập nội dung tìm kiếm!", 3);
				return;
			}
			List<int> list = new List<int>();
			text = Common.ConvertToUnSign(text.ToLower());
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				string text2 = dtgvAcc.Rows[i].Cells[columnName].Value.ToString();
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
				num = dtgvAcc.CurrentRow.Index;
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
			dtgvAcc.CurrentCell = dtgvAcc.Rows[index2].Cells[columnName];
			dtgvAcc.ClearSelection();
			dtgvAcc.Rows[index2].Selected = true;
		}
		catch (Exception)
		{
		}
	}

	private void E80EE696(object sender, EventArgs e)
	{
		if (Base.smethod_3())
		{
			method_3("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
		}
	}

	private void method_18()
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			method_28(i, "cSTT", i + 1);
		}
	}

	private void BC1B3D31(object sender, EventArgs e)
	{
		if (Base.smethod_3())
		{
			method_3("cFa2");
		}
	}

	private void toolStripMenuItem_14_Click(object sender, EventArgs e)
	{
		E6874DBB(6);
	}

	private void method_19(int EB86022A, bool AD1BD2AF)
	{
		try
		{
			string text = "";
			int f01976B = 0;
			if (AD1BD2AF)
			{
				text = CA943614(EB86022A, "cProxy");
				f01976B = (text.EndsWith("*1") ? 1 : 0);
				if (text.EndsWith("*0") || text.EndsWith("*1"))
				{
					text = text.Substring(0, text.Length - 2);
				}
			}
			string text2 = dtgvAcc.Rows[EB86022A].Cells["cUid"].Value.ToString();
			switch (CheckInfoAccountv2.CheckAvatar(text2, text, f01976B))
			{
			case "2":
				CC9B882B(EB86022A, Language.GetValue("Không check được!"));
				break;
			case "1":
				CC9B882B(EB86022A, Language.GetValue("Đa\u0303 co\u0301 avatar!"));
				method_29(EB86022A, "cAvatar", "Yes", "avatar");
				break;
			case "0":
				CC9B882B(EB86022A, Language.GetValue("Không co\u0301 avatar!"));
				method_29(EB86022A, "cAvatar", "No", "avatar");
				break;
			}
		}
		catch
		{
			CC9B882B(EB86022A, "Lỗi!");
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_12("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							CC9B882B(int_2, Language.GetValue("Đang kiểm tra..."));
							method_21(int_2);
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
			method_12("stop");
		}).Start();
	}

	private void method_21(int int_2)
	{
		string text = dtgvAcc.Rows[int_2].Cells["cCookies"].Value.ToString();
		dtgvAcc.Rows[int_2].Cells["cId"].Value.ToString();
		string text2 = CA943614(int_2, "cUseragent").Trim();
		string text3 = "";
		int num = 0;
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("ip_iTypeChangeIp") == 9)
		{
			text3 = CA943614(int_2, "cProxy");
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
		CC9B882B(int_2, text4);
	}

	private void locTrungToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					string item = CA943614(i, "cUid");
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
			List<string> list_ = Common.CloneList(list);
			DataTable dataTable = CommonSQL.smethod_11(list_, bool_0: false);
			dataTable.DefaultView.Sort = "uid ASC";
			dataTable = dataTable.DefaultView.ToTable();
			dtgvAcc.Rows.Clear();
			AD17A83B(dataTable);
		}
		catch (Exception)
		{
		}
	}

	private void A628EFB5(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), method_24())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int BE851F19 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < BE851F19)
					{
						Interlocked.Increment(ref int_0);
						int CF05A7A6 = num++;
						new Thread((ThreadStart)delegate
						{
							CC9B882B(CF05A7A6, Language.GetValue("Đang xo\u0301a profile..."));
							method_22(CF05A7A6);
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

	private void method_22(int AD2A301E)
	{
		try
		{
			string text = dtgvAcc.Rows[AD2A301E].Cells["cId"].Value.ToString();
			string text2 = dtgvAcc.Rows[AD2A301E].Cells["cUid"].Value.ToString();
			if (text2.Trim() == "")
			{
				CC9B882B(AD2A301E, Language.GetValue("Chưa tạo profile!"));
				return;
			}
			string path = SettingsTool.GetPathProfile() + "\\" + text2;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				CC9B882B(AD2A301E, Language.GetValue("Xóa profile thành công!"));
				method_28(AD2A301E, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(text, "profile", "No");
			}
			else
			{
				CC9B882B(AD2A301E, Language.GetValue("Chưa tạo profile!"));
			}
		}
		catch
		{
			CC9B882B(AD2A301E, Language.GetValue("Xóa profile thất bại!"));
		}
	}

	private void checkProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int A5937002 = 0;
		int int_0 = 10;
		string FC050D80 = SettingsTool.GetPathProfile();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.RowCount)
			{
				if (Convert.ToBoolean(CA943614(num, "cChose")))
				{
					if (A5937002 < int_0)
					{
						Interlocked.Increment(ref A5937002);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							CC9B882B(int_, "Check profile...");
							method_23(int_, FC050D80);
							Interlocked.Decrement(ref A5937002);
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

	private void method_23(int int_2, string E8BE2683)
	{
		try
		{
			string text = CA943614(int_2, "cId");
			string text2 = CA943614(int_2, "cUid");
			E8BE2683 = E8BE2683 + "\\" + text2;
			if (Directory.Exists(E8BE2683))
			{
				CC9B882B(int_2, Language.GetValue("Đã có profile!"));
				method_28(int_2, "cProfile", "Yes");
				CommonSQL.UpdateFieldToAccount(text, "profile", "Yes");
			}
			else
			{
				CC9B882B(int_2, Language.GetValue("Chưa tạo profile!"));
				method_28(int_2, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(text, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void E5A6ED37(object sender, EventArgs e)
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

	private void AF8B4199_DoubleClick(object sender, EventArgs e)
	{
		Common.KillProcess("chrome");
	}

	private void EE084518_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
	}

	private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Base.smethod_3())
		{
			method_3("cUid|cPassword|cFa2");
		}
	}

	private void A99E220E_Click(object sender, EventArgs e)
	{
		JSON_Settings gclass8_ = new JSON_Settings();
		Common.ShowForm(new fCauHinhChung(ref gclass8_));
		if (gclass8_.GetValueBool("isChangePathDatabase"))
		{
			method_1();
			int_1 = -1;
			cbbThuMuc.SelectedIndex = -1;
			cbbThuMuc.SelectedIndex = 0;
		}
	}

	private void E48FA72C_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = E691A39B("cUid|cPassword|cToken|cCookies|cEmail|cEmail2|cPassMail|cFa2|cUseragent|cProxy|cName|cGender|cFollow|cFriend|cGroup|cBirthday|cDateCreateAcc|cGhiChu|cLocation|cMailRecovery|cInteractEnd|cDating|cAds|cBM");
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

	private void D0B49F16_Click(object sender, EventArgs e)
	{
		method_3("cMa2Fa");
	}

	private void C322F512(object sender, EventArgs e)
	{
	}

	private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		DatagridviewHelper.smethod_7(e);
	}

	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		string text = SettingsTool.GetSettings("configDatagridview").D9A09B34();
		Common.ShowForm(new fCauHinhHienThi());
		if (SettingsTool.GetSettings("configDatagridview").D9A09B34() != text)
		{
			method_31();
		}
	}

	private void DF855FAE(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_12("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int E11ACE35 = num++;
						new Thread((ThreadStart)delegate
						{
							CC9B882B(E11ACE35, Language.GetValue("Đang kiểm tra..."));
							E41010BF(E11ACE35);
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
			method_12("stop");
		}).Start();
	}

	private void E41010BF(int int_2)
	{
		try
		{
			string text = dtgvAcc.Rows[int_2].Cells["cProxy"].Value.ToString();
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
				CC9B882B(int_2, "Proxy Die!");
			}
			else
			{
				CC9B882B(int_2, "Proxy Live!");
			}
		}
		catch
		{
			CC9B882B(int_2, "Lỗi!");
		}
	}

	private void EDB4650D_Click(object sender, EventArgs e)
	{
		method_3("cUseragent");
	}

	private void proxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		method_3("cProxy");
	}

	private void B31E6381(object sender, EventArgs e)
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

	private void BE1D39A9(object sender, EventArgs e)
	{
		if (!bool_2 || cbbTinhTrang.SelectedValue == null || !StringHelper.CheckStringIsNumber(cbbTinhTrang.SelectedValue.ToString()) || (cbbTinhTrang.SelectedValue.ToString() != "-1" && A38767B1 == cbbTinhTrang.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				C9BFE690(F7B8BF17(), cbbTinhTrang.Text);
			}
			else
			{
				C9BFE690(fChonThuMuc.list_0, cbbTinhTrang.Text);
			}
		}
		else
		{
			C9BFE690(null, cbbTinhTrang.Text);
		}
		A38767B1 = cbbTinhTrang.SelectedIndex;
	}

	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
		E6874DBB(4);
	}

	public int method_24()
	{
		int result = 0;
		try
		{
			result = Convert.ToInt32(D81400AF.Text);
		}
		catch
		{
		}
		return result;
	}

	private bool method_25()
	{
		if (method_24() == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return false;
		}
		return true;
	}

	private void A396BF8A(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có chắc muốn xóa Cache Profile của {0} tài khoản?"), method_24())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int E50577BF = num++;
						new Thread((ThreadStart)delegate
						{
							CC9B882B(E50577BF, Language.GetValue("Đang xo\u0301a Cache Profile..."));
							B10EAB09(E50577BF);
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

	private void B10EAB09(int int_2)
	{
		try
		{
			dtgvAcc.Rows[int_2].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_2].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				CC9B882B(int_2, Language.GetValue("Chưa tạo profile!"));
				return;
			}
			string text2 = SettingsTool.GetPathProfile() + "\\" + text;
			if (Directory.Exists(text2))
			{
				Common.DeleteFile(text2 + "\\Default\\Cache");
				Common.DeleteFile(text2 + "\\Default\\Code Cache");
				Common.DeleteFile(text2 + "\\OptimizationGuidePredictionModels");
				Common.DeleteFile(text2 + "\\Default\\optimization_guide_prediction_model_downloads");
				Common.DeleteFile(text2 + "\\SwReporter");
				Common.DeleteFile(text2 + "\\pnacl");
				CC9B882B(int_2, Language.GetValue("Xóa Cache Profile thành công!"));
			}
			else
			{
				CC9B882B(int_2, Language.GetValue("Chưa tạo profile!"));
			}
		}
		catch
		{
			CC9B882B(int_2, Language.GetValue("Xóa Cache Profile thất bại!"));
		}
	}

	private void B030A50B(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchLocTrung());
	}

	private void BCA2F1BB(object sender, EventArgs e)
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

	private void E4162C82_Click(object sender, EventArgs e)
	{
	}

	private void C428B0BB(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckImapHotmail());
	}

	private void A00D4083(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.RowIndex > -1)
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				CC12ED13();
			}
		}
		catch
		{
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		List<string> list = F7B8BF17();
		if (list != null && list.Count == 1)
		{
			fEditFile fEditFile2 = new fEditFile(list[0], cbbThuMuc.Text);
			fEditFile2.ShowInTaskbar = false;
			fEditFile2.ShowDialog();
			int selectedIndex = cbbThuMuc.SelectedIndex;
			if (fEditFile2.bool_0)
			{
				method_1();
				int_1 = -1;
				cbbThuMuc.SelectedIndex = selectedIndex;
			}
		}
	}

	private void checkProxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckProxy());
	}

	private void AE8C1620_Click(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid f029BA8C = new fLocTheoDanhSachUid();
		Common.ShowForm(f029BA8C);
		if (f029BA8C.CB22AE1B.Count > 0)
		{
			List<string> list_ = Common.CloneList(f029BA8C.CB22AE1B);
			DataTable f5807B = CommonSQL.smethod_11(list_, bool_0: false);
			dtgvAcc.Rows.Clear();
			AD17A83B(f5807B);
		}
	}

	public void CC9B882B(int D796299E, string string_1, int int_2 = -1)
	{
		switch (int_2)
		{
		default:
			DatagridviewHelper.smethod_3(dtgvAcc, D796299E, "cStatus", int_2, string_1);
			break;
		case -1:
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, D796299E, "cStatus", string_1);
			break;
		case 0:
			break;
		}
	}

	public void method_27(int int_2, string string_1, int DC843D0B, int int_3)
	{
		int int_4 = Base.rd.Next(DC843D0B, int_3 + 1);
		CC9B882B(int_2, string_1, int_4);
	}

	public void B7B39F35(int F71963AC, string string_1)
	{
		DatagridviewHelper.SetStatusDataGridView(dtgvAcc, F71963AC, "cInfo", string_1);
		C139263D(F71963AC);
		CommonSQL.UpdateFieldToAccount(CA943614(F71963AC, "cId"), "info", string_1);
	}

	public void method_28(int int_2, string string_1, object object_1, bool B6BED19E = true)
	{
		if ((!(string_1 == "cUid") || !(object_1.ToString().Trim() == "")) && (B6BED19E || !(object_1.ToString().Trim() == "")))
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, int_2, string_1, object_1);
		}
	}

	public void A506C23D(string string_1, string F6BDFDA9, int CCAABC9B, string string_2, string string_3, bool bool_4 = true)
	{
		if ((bool_4 || !(string_3.ToString().Trim() == "")) && !(string_3 == "-2"))
		{
			DatagridviewHelper.SetStatusDataGridView(dtgvAcc, CCAABC9B, string_2, string_3);
			CommonSQL.UpdateFieldToAccount(string_1, F6BDFDA9, string_3);
		}
	}

	public void method_29(int A627E011, string string_1, string D08ECD00, string string_2, bool bool_4 = true)
	{
		A506C23D(CA943614(A627E011, "cId"), string_2, A627E011, string_1, D08ECD00, bool_4);
	}

	public string method_30(int B98FC38C)
	{
		return DatagridviewHelper.GetStatusDataGridView(dtgvAcc, B98FC38C, "cInfo");
	}

	public string CA943614(int int_2, string B7BD5693)
	{
		return DatagridviewHelper.GetStatusDataGridView(dtgvAcc, int_2, B7BD5693);
	}

	private void C139263D(int int_2 = -1)
	{
		DatagridviewHelper.smethod_1(dtgvAcc, int_2);
	}

	private void D48EFE81(int int_2, int A118523E)
	{
		DatagridviewHelper.smethod_2(dtgvAcc, int_2, A118523E);
	}

	private void method_31()
	{
		dtgvAcc.Columns["cToken"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("cToken");
		dtgvAcc.Columns["cCookies"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbCookie");
		dtgvAcc.Columns["cEmail"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbEmail");
		dtgvAcc.Columns["cName"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbTen");
		dtgvAcc.Columns["cFriend"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBanBe");
		dtgvAcc.Columns["cGroup"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNhom");
		dtgvAcc.Columns["cPage"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPage");
		dtgvAcc.Columns["cPagePro5"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPagePro5");
		dtgvAcc.Columns["cBirthday"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNgaySinh");
		dtgvAcc.Columns["cGender"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbGioiTinh");
		dtgvAcc.Columns["cPassword"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMatKhau");
		dtgvAcc.Columns["cPassMail"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMatKhauMail");
		dtgvAcc.Columns["cBackup"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBackup");
		dtgvAcc.Columns["cFa2"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMa2FA");
		dtgvAcc.Columns["cUseragent"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbUseragent");
		dtgvAcc.Columns["cProxy"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbProxy");
		dtgvAcc.Columns["cDateCreateAcc"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNgayTao");
		dtgvAcc.Columns["cAvatar"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbAvatar");
		dtgvAcc.Columns["cProfile"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbProfile");
		dtgvAcc.Columns["cInfo"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbTinhTrang");
		dtgvAcc.Columns["cThuMuc"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbThuMuc");
		dtgvAcc.Columns["cGhiChu"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbGhiChu");
		dtgvAcc.Columns["cFollow"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbFollow");
		dtgvAcc.Columns["cInteractEnd"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbInteractEnd");
		dtgvAcc.Columns["cMailRecovery"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMailRecovery");
		dtgvAcc.Columns["cPhone"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPhone");
		dtgvAcc.Columns["cHometown"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbHometown");
		dtgvAcc.Columns["cCurrentCity"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbCurrentCity");
		dtgvAcc.Columns["cJob"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbJob");
		dtgvAcc.Columns["cLocation"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbLocation");
		dtgvAcc.Columns["cDating"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbDating");
		dtgvAcc.Columns["cAds"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbAds");
		dtgvAcc.Columns["cBM"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBM");
		dtgvAcc.Columns["cWallPosts"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbWallPosts");
		dtgvAcc.Columns["cFbBlock"].Visible = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbFbBlock");
	}

	private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (bool_3 && e.ColumnIndex == 0)
		{
			CC12ED13();
		}
	}

	private void method_32(string string_1)
	{
		Common.ShowForm(new fSelectFolder());
		string a6B9FE = fSelectFolder.A6B9FE13;
		if (a6B9FE == "")
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			try
			{
				if (Convert.ToBoolean(CA943614(i, "cChose")))
				{
					string text = CA943614(i, "cUid");
					list.Add(string_1 + "\\" + text + "|" + a6B9FE + "\\" + text);
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

	private void D8B89E9C_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckLiveUid());
	}

	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fContact());
	}

	private void F618AA80(object sender, EventArgs e)
	{
		lblCountHighline.Text = dtgvAcc.SelectedRows.Count.ToString();
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				CC12ED13();
			}
			catch
			{
			}
		}
	}

	private void E480D282(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				dtgvAcc.Rows.RemoveAt(i--);
			}
		}
		method_18();
		B100FA38();
		CC12ED13(0);
	}

	private void B089488F_Click(object sender, EventArgs e)
	{
		method_3("cEmail|cPassMail|cMailRecovery");
	}

	private void txbSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			BtnSearch_Click(null, null);
		}
	}

	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		E6874DBB(5);
	}

	private void F5016F30_Click(object sender, EventArgs e)
	{
		E6874DBB(5, A2209095: true);
	}

	private void toolStripMenuItem_13_Click(object sender, EventArgs e)
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
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				string text = CA943614(i, "cEmail");
				if (text != "" && text.Contains("@"))
				{
					text = text.Substring(text.IndexOf('@'));
					method_28(i, "cChose", list.Contains(text));
				}
			}
		}
		else
		{
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				string item = CA943614(j, "cUid");
				string item2 = CA943614(j, "cEmail");
				method_28(j, "cChose", list.Contains(item) || list.Contains(item2));
			}
		}
		CC12ED13();
	}

	private void pnlHeader_DoubleClick(object sender, EventArgs e)
	{
		this.F128E894();
	}

	private void F02810BC_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchTestSpinContent());
	}

	private void C325F411_MouseEnter(object sender, EventArgs e)
	{
		if (!E2AD8200)
		{
			return;
		}
		E2AD8200 = false;
		C325F411.DropDownItems.Clear();
		List<string> C61DF78B = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text = "";
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					text = CA943614(j, "cGhiChu");
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
						if (text != "" && !C61DF78B.Contains(text))
						{
							C61DF78B.Add(text);
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
		for (int i = 0; i < C61DF78B.Count; i++)
		{
			C325F411.DropDownItems.Add(C61DF78B[i]);
			C325F411.DropDownItems[i].Click += CB1AD625;
		}
	}

	private void CB1AD625(object sender, EventArgs e)
	{
		method_7("cGhiChu", (sender as ToolStripMenuItem).Text);
	}

	private void checkStatusXproxyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fTienIchCheckStatusXProxy());
	}

	private void B182B083_Click(object sender, EventArgs e)
	{
		E6874DBB(6, A2209095: true);
	}

	private void bunifuCustomLabel1_DoubleClick(object sender, EventArgs e)
	{
		FB1C2E30++;
		if (FB1C2E30 >= 3)
		{
			FB1C2E30 = 0;
			new fCauHinhDebug().ShowDialog();
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		F6BECEAA();
	}

	private void F6BECEAA()
	{
		if (!method_25())
		{
			return;
		}
		Common.ShowForm(new fCauHinhKhoiPhucTaiKhoan());
		if (fCauHinhKhoiPhucTaiKhoan.B40D8608)
		{
			try
			{
				if (fCauHinhKhoiPhucTaiKhoan.A9177C27 == 0)
				{
					List<string> list = new List<string>();
					List<string> list2 = new List<string>();
					for (int i = 0; i < dtgvAcc.RowCount; i++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
						{
							string text = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, i, "cId");
							string item = CommonSQL.BD3E5F36(text);
							list.Add(text);
							list2.Add(item);
							dtgvAcc.Rows.RemoveAt(i--);
						}
					}
					method_18();
					CommonSQL.smethod_10(list2, "active", "1");
					if (CommonSQL.smethod_9(list, "active", "1"))
					{
						MessageBoxHelper.Show(string.Format(Language.GetValue("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list.Count));
					}
					else
					{
						MessageBoxHelper.Show("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
					}
				}
				else
				{
					string c5292A = fCauHinhKhoiPhucTaiKhoan.C5292A37;
					List<string> list3 = new List<string>();
					for (int j = 0; j < dtgvAcc.RowCount; j++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
						{
							string item2 = DatagridviewHelper.GetStatusDataGridView(dtgvAcc, j, "cId");
							list3.Add(item2);
							dtgvAcc.Rows.RemoveAt(j--);
						}
					}
					method_18();
					if (CommonSQL.smethod_9(list3, "idFile", c5292A) && CommonSQL.smethod_9(list3, "active", "1"))
					{
						MessageBoxHelper.Show(string.Format(Language.GetValue("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list3.Count));
					}
					else
					{
						MessageBoxHelper.Show("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
					}
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "Khoi Phuc Tai Khoan");
			}
		}
		B100FA38();
		CC12ED13();
	}

	private void method_33()
	{
		if (!method_25())
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản cần xóa!", 3);
			return;
		}
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có thực sự muốn xóa {0} tài khoản đã chọn?"), list.Count) + "\r\n\r\n" + Language.GetValue("Chu\u0301 y\u0301: Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a thi\u0300 không thê\u0309 khôi phu\u0323c la\u0323i đươ\u0323c nư\u0303a!")) == DialogResult.Yes)
		{
			if (!CommonSQL.smethod_15(list, B798F03E: true))
			{
				MessageBoxHelper.Show("Xóa thất bại, vui lòng thử lại sau!", 2);
				return;
			}
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
				{
					dtgvAcc.Rows.RemoveAt(j--);
				}
			}
			CommonSQL.E816EF1E();
			method_18();
		}
		B100FA38();
		CC12ED13();
	}

	private void BE32D9AE(object sender, EventArgs e)
	{
		method_33();
	}

	private void D8BDCF9B(object sender, EventArgs e)
	{
		F6BECEAA();
	}

	private void DA859FAB(object sender, EventArgs e)
	{
		method_33();
	}

	private void F5A0D033(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				dtgvAcc.Rows.RemoveAt(i--);
			}
		}
		method_18();
		B100FA38();
		CC12ED13(0);
	}

	private void CB08B697_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				dtgvAcc.Rows.RemoveAt(i--);
			}
		}
		method_18();
		B100FA38();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTaiKhoanDaXoa));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		this.ctmsAcc = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.EF833C8C = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.CF1FBE80 = new System.Windows.Forms.ToolStripMenuItem();
		this.tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.A31ED438 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		this.C325F411 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DE87B91F = new System.Windows.Forms.ToolStripMenuItem();
		this.CB08B697 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		this.A202378C = new System.Windows.Forms.ToolStripMenuItem();
		this.C8B57E02 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FA2F9135 = new System.Windows.Forms.ToolStripMenuItem();
		this.E19FFB83 = new System.Windows.Forms.ToolStripMenuItem();
		this.E9258D38 = new System.Windows.Forms.ToolStripMenuItem();
		this.FBBE8798 = new System.Windows.Forms.ToolStripMenuItem();
		this.fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.D0B49F16 = new System.Windows.Forms.ToolStripMenuItem();
		this.DF9450A5 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.mailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.B089488F = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ABBFFBA6 = new System.Windows.Forms.ToolStripMenuItem();
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EDB4650D = new System.Windows.Forms.ToolStripMenuItem();
		this.proxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.E48FA72C = new System.Windows.Forms.ToolStripMenuItem();
		this.E4162C82 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkInfoUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		this.F5016F30 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		this.B182B083 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		this.D7089B3D = new System.Windows.Forms.ToolStripMenuItem();
		this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
		this.AE8C1620 = new System.Windows.Forms.ToolStripMenuItem();
		this.locTrungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EF179FAA = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		this.DF1CF299 = new System.Windows.Forms.ToolStripMenuItem();
		this.E88A3F85 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.getTokenEAAAAUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.getTokenEAAAAUBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.AF8B4199 = new System.Windows.Forms.PictureBox();
		this.A2809128 = new System.Windows.Forms.Button();
		this.F280A4B4 = new System.Windows.Forms.Button();
		this.EA3C260E = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		this.A99E220E = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		this.D8B89E9C = new System.Windows.Forms.ToolStripMenuItem();
		this.checkProxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.E10BDA29 = new System.Windows.Forms.ToolStripMenuItem();
		this.E62338AA = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		this.checkStatusXproxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.F02810BC = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.A980CC36 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.BEA51F18 = new System.Windows.Forms.Button();
		this.F731FF2E = new System.Windows.Forms.StatusStrip();
		this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountHighline = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
		this.D81400AF = new System.Windows.Forms.ToolStripStatusLabel();
		this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		this.EDB05919 = new System.Windows.Forms.Panel();
		this.BtnSearch = new System.Windows.Forms.Button();
		this.F997392D = new System.Windows.Forms.ComboBox();
		this.txbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		this.BA918591 = new System.Windows.Forms.Panel();
		this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.cbbThuMuc = new System.Windows.Forms.ComboBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.button3 = new System.Windows.Forms.Button();
		this.button9 = new System.Windows.Forms.Button();
		this.EE084518 = new System.Windows.Forms.StatusStrip();
		this.dtgvAcc = new System.Windows.Forms.DataGridView();
		this.cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C7BCAC1A = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.A3BB4204 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D129E7AF = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DA9AE1A0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPagePro5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D735B51D = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C52EF59C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cBackup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cUseragent = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cDateCreateAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D39B6B28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C111C000 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.A53EC3AA = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C48060B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cHometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.AC257A8E = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.E4810589 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cAds = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.C237E4AB = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.E223F80C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CB169920 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.D49B29AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ctmsAcc.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AF8B4199).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		this.EDB05919.SuspendLayout();
		this.BA918591.SuspendLayout();
		this.panel1.SuspendLayout();
		this.EE084518.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
		base.SuspendLayout();
		this.ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.EF833C8C, this.toolStripMenuItem_1, this.DE87B91F, this.CB08B697, this.toolStripMenuItem_15, this.A202378C, this.C8B57E02, this.E4162C82, this.mnuChucNang, this.EF179FAA,
			this.toolStripMenuItem_4
		});
		this.ctmsAcc.Name = "ctmsAcc";
		this.ctmsAcc.Size = new System.Drawing.Size(198, 246);
		this.ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
		this.EF833C8C.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.toolStripMenuItem_0, this.CF1FBE80, this.tinhTrangToolStripMenuItem, this.A31ED438, this.toolStripMenuItem_13, this.C325F411 });
		this.EF833C8C.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		this.EF833C8C.Name = "chọnLiveToolStripMenuItem";
		this.EF833C8C.Size = new System.Drawing.Size(197, 22);
		this.EF833C8C.Text = "Chọn";
		this.toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		this.toolStripMenuItem_0.Name = "tấtCảToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(128, 22);
		this.toolStripMenuItem_0.Text = "Tất cả";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.CF1FBE80.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		this.CF1FBE80.Name = "liveToolStripMenuItem";
		this.CF1FBE80.Size = new System.Drawing.Size(128, 22);
		this.CF1FBE80.Text = "Bôi đen";
		this.CF1FBE80.Click += new System.EventHandler(CF1FBE80_Click);
		this.tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		this.tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
		this.tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		this.A31ED438.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		this.A31ED438.Name = "trạngTháiToolStripMenuItem";
		this.A31ED438.Size = new System.Drawing.Size(128, 22);
		this.A31ED438.Text = "Trạng thái";
		this.A31ED438.Click += new System.EventHandler(C322F512);
		this.toolStripMenuItem_13.Image = Resources.CFBEC037;
		this.toolStripMenuItem_13.Name = "chDanhSáchTheoUIDEmailToolStripMenuItem";
		this.toolStripMenuItem_13.Size = new System.Drawing.Size(128, 22);
		this.toolStripMenuItem_13.Text = "Theo Uid";
		this.toolStripMenuItem_13.Click += new System.EventHandler(toolStripMenuItem_13_Click);
		this.C325F411.Image = (System.Drawing.Image)resources.GetObject("ghiChúToolStripMenuItem.Image");
		this.C325F411.Name = "ghiChúToolStripMenuItem";
		this.C325F411.Size = new System.Drawing.Size(128, 22);
		this.C325F411.Text = "Ghi chu\u0301";
		this.C325F411.MouseEnter += new System.EventHandler(C325F411_MouseEnter);
		this.toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		this.toolStripMenuItem_1.Name = "bỏChọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_1.Text = "Bỏ chọn tất cả";
		this.toolStripMenuItem_1.Click += new System.EventHandler(E884D2AA);
		this.DE87B91F.Image = Resources.Bitmap_89;
		this.DE87B91F.Name = "toolStripMenuItem1";
		this.DE87B91F.Size = new System.Drawing.Size(197, 22);
		this.DE87B91F.Text = "Ẩn dòng tích chọn";
		this.DE87B91F.Click += new System.EventHandler(F5A0D033);
		this.CB08B697.Image = Resources.Bitmap_89;
		this.CB08B697.Name = "toolStripMenuItem2";
		this.CB08B697.Size = new System.Drawing.Size(197, 22);
		this.CB08B697.Text = "Ẩn dòng không tích";
		this.CB08B697.Click += new System.EventHandler(CB08B697_Click);
		this.toolStripMenuItem_15.Image = Resources.Bitmap_139;
		this.toolStripMenuItem_15.Name = "khôiPhucTaiKhoanToolStripMenuItem";
		this.toolStripMenuItem_15.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_15.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		this.toolStripMenuItem_15.Click += new System.EventHandler(D8BDCF9B);
		this.A202378C.Image = Resources.Bitmap_74;
		this.A202378C.Name = "xóaTàiKhoảnToolStripMenuItem";
		this.A202378C.Size = new System.Drawing.Size(197, 22);
		this.A202378C.Text = "Xóa ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		this.A202378C.Click += new System.EventHandler(DA859FAB);
		this.C8B57E02.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[17]
		{
			this.uidToolStripMenuItem, this.FA2F9135, this.E19FFB83, this.E9258D38, this.FBBE8798, this.fAToolStripMenuItem, this.D0B49F16, this.DF9450A5, this.uidPass2FaToolStripMenuItem, this.mailPassMailToolStripMenuItem,
			this.B089488F, this.uidPassTokenCookieToolStripMenuItem, this.ABBFFBA6, this.uidPassTokenCookieMailPassMail2faToolStripMenuItem, this.EDB4650D, this.proxyToolStripMenuItem1, this.E48FA72C
		});
		this.C8B57E02.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		this.C8B57E02.Name = "copyToolStripMenuItem";
		this.C8B57E02.Size = new System.Drawing.Size(197, 22);
		this.C8B57E02.Text = "Copy";
		this.uidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		this.uidToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidToolStripMenuItem.Text = "Uid";
		this.uidToolStripMenuItem.Click += new System.EventHandler(uidToolStripMenuItem_Click);
		this.FA2F9135.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		this.FA2F9135.Name = "passToolStripMenuItem";
		this.FA2F9135.Size = new System.Drawing.Size(289, 22);
		this.FA2F9135.Text = "Pass";
		this.FA2F9135.Click += new System.EventHandler(E8B8431A);
		this.E19FFB83.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		this.E19FFB83.Name = "tokenToolStripMenuItem";
		this.E19FFB83.Size = new System.Drawing.Size(289, 22);
		this.E19FFB83.Text = "Token";
		this.E19FFB83.Click += new System.EventHandler(D2981131);
		this.E9258D38.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		this.E9258D38.Name = "cookieToolStripMenuItem";
		this.E9258D38.Size = new System.Drawing.Size(289, 22);
		this.E9258D38.Text = "Cookie";
		this.E9258D38.Click += new System.EventHandler(E9258D38_Click);
		this.FBBE8798.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		this.FBBE8798.Name = "mailToolStripMenuItem";
		this.FBBE8798.Size = new System.Drawing.Size(289, 22);
		this.FBBE8798.Text = "Email";
		this.FBBE8798.Click += new System.EventHandler(FBBE8798_Click);
		this.fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		this.fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		this.fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.fAToolStripMenuItem.Text = "2FA";
		this.fAToolStripMenuItem.Click += new System.EventHandler(BC1B3D31);
		this.D0B49F16.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		this.D0B49F16.Name = "maBaoMât6SôToolStripMenuItem";
		this.D0B49F16.Size = new System.Drawing.Size(289, 22);
		this.D0B49F16.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301 từ 2FA";
		this.D0B49F16.Click += new System.EventHandler(D0B49F16_Click);
		this.DF9450A5.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		this.DF9450A5.Name = "uidPassToolStripMenuItem";
		this.DF9450A5.Size = new System.Drawing.Size(289, 22);
		this.DF9450A5.Text = "Uid|Pass";
		this.DF9450A5.Click += new System.EventHandler(DF9450A5_Click);
		this.uidPass2FaToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		this.uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
		this.uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		this.uidPass2FaToolStripMenuItem.Click += new System.EventHandler(uidPass2FaToolStripMenuItem_Click);
		this.mailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		this.mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
		this.mailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
		this.mailPassMailToolStripMenuItem.Click += new System.EventHandler(mailPassMailToolStripMenuItem_Click);
		this.B089488F.Image = Resources.Bitmap_152;
		this.B089488F.Name = "emailPassMailMailKpToolStripMenuItem";
		this.B089488F.Size = new System.Drawing.Size(289, 22);
		this.B089488F.Text = "Email|PassMail|MailKp";
		this.B089488F.Click += new System.EventHandler(B089488F_Click);
		this.uidPassTokenCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
		this.uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";
		this.uidPassTokenCookieToolStripMenuItem.Click += new System.EventHandler(E8165F2A);
		this.ABBFFBA6.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		this.ABBFFBA6.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		this.ABBFFBA6.Size = new System.Drawing.Size(289, 22);
		this.ABBFFBA6.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		this.ABBFFBA6.Click += new System.EventHandler(B134852F);
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new System.EventHandler(E80EE696);
		this.EDB4650D.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		this.EDB4650D.Name = "useragentToolStripMenuItem1";
		this.EDB4650D.Size = new System.Drawing.Size(289, 22);
		this.EDB4650D.Text = "Useragent";
		this.EDB4650D.Click += new System.EventHandler(EDB4650D_Click);
		this.proxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		this.proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
		this.proxyToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
		this.proxyToolStripMenuItem1.Text = "Proxy";
		this.proxyToolStripMenuItem1.Click += new System.EventHandler(proxyToolStripMenuItem1_Click);
		this.E48FA72C.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		this.E48FA72C.Name = "đinhDangKhacToolStripMenuItem";
		this.E48FA72C.Size = new System.Drawing.Size(289, 22);
		this.E48FA72C.Text = "Other...";
		this.E48FA72C.Click += new System.EventHandler(E48FA72C_Click);
		this.E4162C82.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.toolStripMenuItem_5, this.checkInfoUIDToolStripMenuItem, this.toolStripMenuItem_3, this.toolStripMenuItem_2, this.checkAvatarToolStripMenuItem, this.checkProfileToolStripMenuItem1, this.toolStripMenuItem_8, this.D7089B3D });
		this.E4162C82.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		this.E4162C82.Name = "checkCookieToolStripMenuItem";
		this.E4162C82.Size = new System.Drawing.Size(197, 22);
		this.E4162C82.Text = "Kiểm tra tài khoản";
		this.E4162C82.Click += new System.EventHandler(E4162C82_Click);
		this.toolStripMenuItem_5.Name = "kiểmTraWallToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_5.Text = "Check Wall";
		this.toolStripMenuItem_5.ToolTipText = "Không cần dùng token";
		this.toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		this.checkInfoUIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_12, this.F5016F30 });
		this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
		this.checkInfoUIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		this.checkInfoUIDToolStripMenuItem.Text = "Check Info Uid";
		this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		this.toolStripMenuItem_12.Name = "sửDụngIPMáyToolStripMenuItem";
		this.toolStripMenuItem_12.Size = new System.Drawing.Size(190, 22);
		this.toolStripMenuItem_12.Text = "Không đổi IP";
		this.toolStripMenuItem_12.Click += new System.EventHandler(toolStripMenuItem_12_Click);
		this.F5016F30.Name = "sửDụngProxyĐãGánToolStripMenuItem";
		this.F5016F30.Size = new System.Drawing.Size(190, 22);
		this.F5016F30.Text = "Sử dụng proxy đã gán";
		this.F5016F30.Click += new System.EventHandler(F5016F30_Click);
		this.toolStripMenuItem_3.Name = "kiểmTraTokenToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_3.Text = "Check Token";
		this.toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		this.toolStripMenuItem_2.Name = "kiểmTraCookieToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_2.Text = "Check Cookie";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.checkAvatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_14, this.B182B083 });
		this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		this.checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
		this.toolStripMenuItem_14.Name = "khôngĐổiIPToolStripMenuItem";
		this.toolStripMenuItem_14.Size = new System.Drawing.Size(190, 22);
		this.toolStripMenuItem_14.Text = "Không đổi IP";
		this.toolStripMenuItem_14.Click += new System.EventHandler(toolStripMenuItem_14_Click);
		this.B182B083.Name = "sửDụngProxyĐãGánToolStripMenuItem1";
		this.B182B083.Size = new System.Drawing.Size(190, 22);
		this.B182B083.Text = "Sử dụng proxy đã gán";
		this.B182B083.Click += new System.EventHandler(B182B083_Click);
		this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
		this.checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
		this.checkProfileToolStripMenuItem1.Text = "Check Profile";
		this.checkProfileToolStripMenuItem1.Click += new System.EventHandler(checkProfileToolStripMenuItem_Click);
		this.toolStripMenuItem_8.Name = "kiểmTraMailpassMailToolStripMenuItem";
		this.toolStripMenuItem_8.Size = new System.Drawing.Size(199, 22);
		this.toolStripMenuItem_8.Text = "Check Connect hotmail";
		this.toolStripMenuItem_8.Click += new System.EventHandler(toolStripMenuItem_8_Click);
		this.D7089B3D.Name = "checkProxyToolStripMenuItem";
		this.D7089B3D.Size = new System.Drawing.Size(199, 22);
		this.D7089B3D.Text = "Check Proxy";
		this.D7089B3D.Click += new System.EventHandler(DF855FAE);
		this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.AE8C1620, this.locTrungToolStripMenuItem });
		this.mnuChucNang.Image = (System.Drawing.Image)resources.GetObject("mnuChucNang.Image");
		this.mnuChucNang.Name = "mnuChucNang";
		this.mnuChucNang.Size = new System.Drawing.Size(197, 22);
		this.mnuChucNang.Text = "Chức năng";
		this.AE8C1620.Image = (System.Drawing.Image)resources.GetObject("lToolStripMenuItem.Image");
		this.AE8C1620.Name = "lToolStripMenuItem";
		this.AE8C1620.Size = new System.Drawing.Size(207, 22);
		this.AE8C1620.Text = "Lọc tài khoản theo Uid";
		this.AE8C1620.Click += new System.EventHandler(AE8C1620_Click);
		this.locTrungToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("locTrungToolStripMenuItem.Image");
		this.locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
		this.locTrungToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
		this.locTrungToolStripMenuItem.Text = "Lọc tài khoản trùng nhau";
		this.locTrungToolStripMenuItem.Click += new System.EventHandler(locTrungToolStripMenuItem_Click);
		this.EF179FAA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.checkProfileToolStripMenuItem, this.toolStripMenuItem_6, this.DF1CF299, this.E88A3F85 });
		this.EF179FAA.Image = (System.Drawing.Image)resources.GetObject("profileToolStripMenuItem.Image");
		this.EF179FAA.Name = "profileToolStripMenuItem";
		this.EF179FAA.Size = new System.Drawing.Size(197, 22);
		this.EF179FAA.Text = "Profile Chrome";
		this.checkProfileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkProfileToolStripMenuItem.Image");
		this.checkProfileToolStripMenuItem.Name = "checkProfileToolStripMenuItem";
		this.checkProfileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
		this.checkProfileToolStripMenuItem.Text = "Check profile";
		this.checkProfileToolStripMenuItem.Click += new System.EventHandler(checkProfileToolStripMenuItem_Click);
		this.toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("xóaProfileToolStripMenuItem.Image");
		this.toolStripMenuItem_6.Name = "xóaProfileToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new System.Drawing.Size(167, 22);
		this.toolStripMenuItem_6.Text = "Xóa profile";
		this.toolStripMenuItem_6.Click += new System.EventHandler(A628EFB5);
		this.DF1CF299.Image = (System.Drawing.Image)resources.GetObject("donDepProfileToolStripMenuItem.Image");
		this.DF1CF299.Name = "donDepProfileToolStripMenuItem";
		this.DF1CF299.Size = new System.Drawing.Size(167, 22);
		this.DF1CF299.Text = "Do\u0323n de\u0323p profile";
		this.DF1CF299.Click += new System.EventHandler(E5A6ED37);
		this.E88A3F85.Image = (System.Drawing.Image)resources.GetObject("xóaCacheToolStripMenuItem.Image");
		this.E88A3F85.Name = "xóaCacheToolStripMenuItem";
		this.E88A3F85.Size = new System.Drawing.Size(167, 22);
		this.E88A3F85.Text = "Xóa Cache Profile";
		this.E88A3F85.Click += new System.EventHandler(A396BF8A);
		this.toolStripMenuItem_4.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		this.toolStripMenuItem_4.Name = "tảiLạiDanhSáchToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(197, 22);
		this.toolStripMenuItem_4.Text = "Tải lại danh sách";
		this.toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		this.getTokenEAAAAUToolStripMenuItem.Name = "getTokenEAAAAUToolStripMenuItem";
		this.getTokenEAAAAUToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		this.getTokenEAAAAUToolStripMenuItem.Text = "Get Token EAAAAU";
		this.getTokenEAAAAUBToolStripMenuItem.Name = "getTokenEAAAAUBToolStripMenuItem";
		this.getTokenEAAAAUBToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		this.getTokenEAAAAUBToolStripMenuItem.Text = "Get Token EAAAAU + Bật 2FA";
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.AF8B4199);
		this.pnlHeader.Controls.Add(this.A2809128);
		this.pnlHeader.Controls.Add(this.F280A4B4);
		this.pnlHeader.Controls.Add(this.EA3C260E);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(2, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1220, 29);
		this.pnlHeader.TabIndex = 0;
		this.pnlHeader.DoubleClick += new System.EventHandler(pnlHeader_DoubleClick);
		this.AF8B4199.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.AF8B4199.Image = Resources.Bitmap_4;
		this.AF8B4199.Location = new System.Drawing.Point(6, 1);
		this.AF8B4199.Name = "pictureBox1";
		this.AF8B4199.Size = new System.Drawing.Size(34, 27);
		this.AF8B4199.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.AF8B4199.TabIndex = 12;
		this.AF8B4199.TabStop = false;
		this.AF8B4199.Click += new System.EventHandler(B31E6381);
		this.AF8B4199.DoubleClick += new System.EventHandler(AF8B4199_DoubleClick);
		this.A2809128.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A2809128.Dock = System.Windows.Forms.DockStyle.Right;
		this.A2809128.FlatAppearance.BorderSize = 0;
		this.A2809128.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A2809128.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A2809128.ForeColor = System.Drawing.Color.White;
		this.A2809128.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.A2809128.Location = new System.Drawing.Point(1124, 0);
		this.A2809128.Name = "btnMinimize";
		this.A2809128.Size = new System.Drawing.Size(32, 29);
		this.A2809128.TabIndex = 0;
		this.A2809128.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A2809128.UseVisualStyleBackColor = true;
		this.A2809128.Click += new System.EventHandler(C9396029);
		this.F280A4B4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F280A4B4.Dock = System.Windows.Forms.DockStyle.Right;
		this.F280A4B4.FlatAppearance.BorderSize = 0;
		this.F280A4B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F280A4B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F280A4B4.ForeColor = System.Drawing.Color.White;
		this.F280A4B4.Image = (System.Drawing.Image)resources.GetObject("btnMaximize.Image");
		this.F280A4B4.Location = new System.Drawing.Point(1156, 0);
		this.F280A4B4.Name = "btnMaximize";
		this.F280A4B4.Size = new System.Drawing.Size(32, 29);
		this.F280A4B4.TabIndex = 1;
		this.F280A4B4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.F280A4B4.UseVisualStyleBackColor = true;
		this.F280A4B4.Click += new System.EventHandler(D301FD9B);
		this.EA3C260E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EA3C260E.Dock = System.Windows.Forms.DockStyle.Right;
		this.EA3C260E.FlatAppearance.BorderSize = 0;
		this.EA3C260E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EA3C260E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EA3C260E.ForeColor = System.Drawing.Color.White;
		this.EA3C260E.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		this.EA3C260E.Location = new System.Drawing.Point(1188, 0);
		this.EA3C260E.Name = "btnClose";
		this.EA3C260E.Size = new System.Drawing.Size(32, 29);
		this.EA3C260E.TabIndex = 2;
		this.EA3C260E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.EA3C260E.UseVisualStyleBackColor = true;
		this.EA3C260E.Click += new System.EventHandler(EA3C260E_Click);
		this.bunifuCustomLabel1.AutoSize = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(185, 16);
		this.bunifuCustomLabel1.TabIndex = 3;
		this.bunifuCustomLabel1.Text = "Danh sách tài khoản đã xóa";
		this.bunifuCustomLabel1.DoubleClick += new System.EventHandler(bunifuCustomLabel1_DoubleClick);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkRed;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1223, 38);
		this.bunifuCards1.TabIndex = 0;
		this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.menuStrip1.AutoSize = false;
		this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.A99E220E, this.toolStripMenuItem_7, this.toolStripMenuItem_9, this.toolStripMenuItem_11 });
		this.menuStrip1.Location = new System.Drawing.Point(1, 37);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.menuStrip1.Size = new System.Drawing.Size(1221, 25);
		this.menuStrip1.Stretch = false;
		this.menuStrip1.TabIndex = 1;
		this.menuStrip1.Text = "menuStrip1";
		this.A99E220E.Image = (System.Drawing.Image)resources.GetObject("hệThốngToolStripMenuItem.Image");
		this.A99E220E.Name = "hệThốngToolStripMenuItem";
		this.A99E220E.Size = new System.Drawing.Size(123, 21);
		this.A99E220E.Text = "Câ\u0301u hi\u0300nh chung";
		this.A99E220E.Click += new System.EventHandler(A99E220E_Click);
		this.toolStripMenuItem_7.Image = (System.Drawing.Image)resources.GetObject("thoátToolStripMenuItem.Image");
		this.toolStripMenuItem_7.Name = "thoátToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new System.Drawing.Size(131, 21);
		this.toolStripMenuItem_7.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		this.toolStripMenuItem_7.Click += new System.EventHandler(toolStripMenuItem_7_Click);
		this.toolStripMenuItem_9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.D8B89E9C, this.checkProxyToolStripMenuItem1, this.E10BDA29, this.E62338AA, this.toolStripMenuItem_10, this.checkStatusXproxyToolStripMenuItem, this.F02810BC });
		this.toolStripMenuItem_9.Image = (System.Drawing.Image)resources.GetObject("tiệnÍchToolStripMenuItem.Image");
		this.toolStripMenuItem_9.Name = "tiệnÍchToolStripMenuItem";
		this.toolStripMenuItem_9.Size = new System.Drawing.Size(80, 21);
		this.toolStripMenuItem_9.Text = "Tiện ích";
		this.D8B89E9C.Image = (System.Drawing.Image)resources.GetObject("checkLiveUidToolStripMenuItem.Image");
		this.D8B89E9C.Name = "checkLiveUidToolStripMenuItem";
		this.D8B89E9C.Size = new System.Drawing.Size(204, 22);
		this.D8B89E9C.Text = "Check Live Uid";
		this.D8B89E9C.Click += new System.EventHandler(D8B89E9C_Click);
		this.checkProxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("checkProxyToolStripMenuItem1.Image");
		this.checkProxyToolStripMenuItem1.Name = "checkProxyToolStripMenuItem1";
		this.checkProxyToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
		this.checkProxyToolStripMenuItem1.Text = "Check Proxy";
		this.checkProxyToolStripMenuItem1.Click += new System.EventHandler(checkProxyToolStripMenuItem1_Click);
		this.E10BDA29.Image = (System.Drawing.Image)resources.GetObject("checkHotmailToolStripMenuItem.Image");
		this.E10BDA29.Name = "checkHotmailToolStripMenuItem";
		this.E10BDA29.Size = new System.Drawing.Size(204, 22);
		this.E10BDA29.Text = "Check Connect hotmail";
		this.E10BDA29.Click += new System.EventHandler(C428B0BB);
		this.E62338AA.Image = (System.Drawing.Image)resources.GetObject("lọcTrùngDữLiệuToolStripMenuItem.Image");
		this.E62338AA.Name = "lọcTrùngDữLiệuToolStripMenuItem";
		this.E62338AA.Size = new System.Drawing.Size(204, 22);
		this.E62338AA.Text = "Lọc trùng dữ liệu";
		this.E62338AA.Click += new System.EventHandler(B030A50B);
		this.toolStripMenuItem_10.Image = (System.Drawing.Image)resources.GetObject("xửLýChuỗiOnlineToolStripMenuItem.Image");
		this.toolStripMenuItem_10.Name = "xửLýChuỗiOnlineToolStripMenuItem";
		this.toolStripMenuItem_10.Size = new System.Drawing.Size(204, 22);
		this.toolStripMenuItem_10.Text = "Xử lý chuỗi cơ bản";
		this.toolStripMenuItem_10.Click += new System.EventHandler(BCA2F1BB);
		this.checkStatusXproxyToolStripMenuItem.Image = Resources.Bitmap_21;
		this.checkStatusXproxyToolStripMenuItem.Name = "checkStatusXproxyToolStripMenuItem";
		this.checkStatusXproxyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		this.checkStatusXproxyToolStripMenuItem.Text = "Check Xproxy";
		this.checkStatusXproxyToolStripMenuItem.Click += new System.EventHandler(checkStatusXproxyToolStripMenuItem_Click);
		this.F02810BC.Image = Resources.A995969B;
		this.F02810BC.Name = "testSpinTextToolStripMenuItem";
		this.F02810BC.Size = new System.Drawing.Size(204, 22);
		this.F02810BC.Text = "Test Spin Content";
		this.F02810BC.Click += new System.EventHandler(F02810BC_Click);
		this.toolStripMenuItem_11.Image = (System.Drawing.Image)resources.GetObject("liênHệToolStripMenuItem.Image");
		this.toolStripMenuItem_11.Name = "liênHệToolStripMenuItem";
		this.toolStripMenuItem_11.Size = new System.Drawing.Size(76, 21);
		this.toolStripMenuItem_11.Text = "Liên hệ";
		this.toolStripMenuItem_11.Click += new System.EventHandler(toolStripMenuItem_11_Click);
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_1.Vertical = true;
		this.A980CC36.AutomaticDelay = 0;
		this.A980CC36.AutoPopDelay = 30000;
		this.A980CC36.InitialDelay = 0;
		this.A980CC36.ReshowDelay = 40;
		this.BEA51F18.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnLoadAcc.BackgroundImage");
		this.BEA51F18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		this.BEA51F18.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BEA51F18.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.BEA51F18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BEA51F18.Location = new System.Drawing.Point(395, 2);
		this.BEA51F18.Name = "btnLoadAcc";
		this.BEA51F18.Size = new System.Drawing.Size(25, 25);
		this.BEA51F18.TabIndex = 6;
		this.A980CC36.SetToolTip(this.BEA51F18, "Load lại danh sách");
		this.BEA51F18.Click += new System.EventHandler(BEA51F18_Click);
		this.F731FF2E.AccessibleName = "New item selection";
		this.F731FF2E.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
		this.F731FF2E.AutoSize = false;
		this.F731FF2E.BackColor = System.Drawing.SystemColors.Control;
		this.F731FF2E.Dock = System.Windows.Forms.DockStyle.None;
		this.F731FF2E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F731FF2E.Location = new System.Drawing.Point(0, 0);
		this.F731FF2E.Name = "miniToolStrip";
		this.F731FF2E.Size = new System.Drawing.Size(1222, 22);
		this.F731FF2E.SizingGrip = false;
		this.F731FF2E.TabIndex = 9;
		this.toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
		this.toolStripStatusLabel4.Size = new System.Drawing.Size(59, 17);
		this.toolStripStatusLabel4.Text = "Bôi đen:";
		this.lblCountHighline.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountHighline.ForeColor = System.Drawing.Color.Blue;
		this.lblCountHighline.Name = "lblCountHighline";
		this.lblCountHighline.Size = new System.Drawing.Size(15, 17);
		this.lblCountHighline.Text = "0";
		this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
		this.toolStripStatusLabel5.Size = new System.Drawing.Size(65, 17);
		this.toolStripStatusLabel5.Text = "Đã chọn:";
		this.D81400AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D81400AF.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		this.D81400AF.Name = "lblCountSelect";
		this.D81400AF.Size = new System.Drawing.Size(15, 17);
		this.D81400AF.Text = "0";
		this.toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
		this.toolStripStatusLabel7.Size = new System.Drawing.Size(52, 17);
		this.toolStripStatusLabel7.Text = "Tất cả:";
		this.lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		this.lblCountTotal.Name = "lblCountTotal";
		this.lblCountTotal.Size = new System.Drawing.Size(15, 17);
		this.lblCountTotal.Text = "0";
		this.EDB05919.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.EDB05919.Controls.Add(this.BtnSearch);
		this.EDB05919.Controls.Add(this.F997392D);
		this.EDB05919.Controls.Add(this.txbSearch);
		this.EDB05919.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EDB05919.Location = new System.Drawing.Point(8, 71);
		this.EDB05919.Name = "panel2";
		this.EDB05919.Size = new System.Drawing.Size(269, 31);
		this.EDB05919.TabIndex = 10;
		this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BtnSearch.BackgroundImage = Resources.CA1C599E;
		this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BtnSearch.Location = new System.Drawing.Point(240, 3);
		this.BtnSearch.Name = "BtnSearch";
		this.BtnSearch.Size = new System.Drawing.Size(24, 23);
		this.BtnSearch.TabIndex = 3;
		this.BtnSearch.Click += new System.EventHandler(BtnSearch_Click);
		this.F997392D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F997392D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.F997392D.DropDownWidth = 100;
		this.F997392D.FormattingEnabled = true;
		this.F997392D.Location = new System.Drawing.Point(3, 3);
		this.F997392D.Name = "cbbSearch";
		this.F997392D.Size = new System.Drawing.Size(86, 24);
		this.F997392D.TabIndex = 0;
		this.txbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txbSearch.BorderColor = System.Drawing.Color.SeaGreen;
		this.txbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
		this.txbSearch.Location = new System.Drawing.Point(95, 3);
		this.txbSearch.Name = "txbSearch";
		this.txbSearch.Size = new System.Drawing.Size(139, 23);
		this.txbSearch.TabIndex = 1;
		this.txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(txbSearch_KeyDown);
		this.BA918591.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BA918591.Controls.Add(this.cbbTinhTrang);
		this.BA918591.Controls.Add(this.BEA51F18);
		this.BA918591.Controls.Add(this.label1);
		this.BA918591.Controls.Add(this.label2);
		this.BA918591.Controls.Add(this.cbbThuMuc);
		this.BA918591.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BA918591.Location = new System.Drawing.Point(283, 71);
		this.BA918591.Name = "plQuanLyThuMuc";
		this.BA918591.Size = new System.Drawing.Size(424, 31);
		this.BA918591.TabIndex = 10;
		this.cbbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTinhTrang.DropDownWidth = 300;
		this.cbbTinhTrang.FormattingEnabled = true;
		this.cbbTinhTrang.ItemHeight = 16;
		this.cbbTinhTrang.Items.AddRange(new object[1] { "[Tất cả tình trạng]" });
		this.cbbTinhTrang.Location = new System.Drawing.Point(268, 3);
		this.cbbTinhTrang.Name = "cbbTinhTrang";
		this.cbbTinhTrang.Size = new System.Drawing.Size(121, 24);
		this.cbbTinhTrang.TabIndex = 3;
		this.cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(BE1D39A9);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(-1, 6);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(63, 16);
		this.label1.TabIndex = 0;
		this.label1.Text = "Thư mục:";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(232, 5);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(31, 16);
		this.label2.TabIndex = 2;
		this.label2.Text = "Lọc:";
		this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbThuMuc.DropDownWidth = 350;
		this.cbbThuMuc.FormattingEnabled = true;
		this.cbbThuMuc.ItemHeight = 16;
		this.cbbThuMuc.Location = new System.Drawing.Point(63, 3);
		this.cbbThuMuc.Name = "cbbThuMuc";
		this.cbbThuMuc.Size = new System.Drawing.Size(167, 24);
		this.cbbThuMuc.TabIndex = 1;
		this.cbbThuMuc.SelectedIndexChanged += new System.EventHandler(AC1CA9AB);
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.button3);
		this.panel1.Controls.Add(this.button9);
		this.panel1.Controls.Add(this.BA918591);
		this.panel1.Controls.Add(this.EDB05919);
		this.panel1.Controls.Add(this.EE084518);
		this.panel1.Controls.Add(this.dtgvAcc);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1224, 610);
		this.panel1.TabIndex = 11;
		this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button3.BackColor = System.Drawing.Color.White;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Image = Resources.Bitmap_74;
		this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button3.Location = new System.Drawing.Point(1011, 70);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(201, 32);
		this.button3.TabIndex = 13;
		this.button3.Text = "Xo\u0301a ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(BE32D9AE);
		this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button9.BackColor = System.Drawing.Color.White;
		this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button9.Image = Resources.Bitmap_139;
		this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.button9.Location = new System.Drawing.Point(847, 70);
		this.button9.Name = "button9";
		this.button9.Size = new System.Drawing.Size(158, 32);
		this.button9.TabIndex = 14;
		this.button9.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.button9.UseVisualStyleBackColor = true;
		this.button9.Click += new System.EventHandler(button9_Click);
		this.EE084518.BackColor = System.Drawing.SystemColors.Control;
		this.EE084518.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EE084518.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.toolStripStatusLabel4, this.lblCountHighline, this.toolStripStatusLabel5, this.D81400AF, this.toolStripStatusLabel7, this.lblCountTotal });
		this.EE084518.Location = new System.Drawing.Point(0, 586);
		this.EE084518.Name = "statusStrip1";
		this.EE084518.Size = new System.Drawing.Size(1222, 22);
		this.EE084518.SizingGrip = false;
		this.EE084518.TabIndex = 9;
		this.EE084518.Text = "statusStrip1";
		this.EE084518.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(EE084518_ItemClicked);
		this.dtgvAcc.AllowUserToAddRows = false;
		this.dtgvAcc.AllowUserToDeleteRows = false;
		this.dtgvAcc.AllowUserToResizeRows = false;
		this.dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		this.dtgvAcc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dtgvAcc.Columns.AddRange(this.cChose, this.cStt, this.C7BCAC1A, this.A3BB4204, this.cToken, this.D129E7AF, this.cEmail, this.cPhone, this.cName, this.cFollow, this.cFriend, this.DA9AE1A0, this.cPage, this.cPagePro5, this.cBirthday, this.cGender, this.D735B51D, this.C52EF59C, this.cPassMail, this.cBackup, this.cFa2, this.cUseragent, this.cProxy, this.cDateCreateAcc, this.cAvatar, this.cProfile, this.D39B6B28, this.C111C000, this.A53EC3AA, this.C48060B1, this.cLocation, this.cHometown, this.AC257A8E, this.E4810589, this.cAds, this.C237E4AB, this.E223F80C, this.CB169920, this.cJob, this.D49B29AC, this.cStatus);
		this.dtgvAcc.ContextMenuStrip = this.ctmsAcc;
		this.dtgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.dtgvAcc.Location = new System.Drawing.Point(8, 108);
		this.dtgvAcc.Name = "dtgvAcc";
		this.dtgvAcc.RowHeadersVisible = false;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.dtgvAcc.RowsDefaultCellStyle = dataGridViewCellStyle2;
		this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dtgvAcc.Size = new System.Drawing.Size(1204, 475);
		this.dtgvAcc.TabIndex = 0;
		this.dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		this.dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(A00D4083);
		this.dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellValueChanged);
		this.dtgvAcc.SelectionChanged += new System.EventHandler(F618AA80);
		this.dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(dtgvAcc_SortCompare);
		this.dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(F999798A);
		this.cChose.HeaderText = "Chọn";
		this.cChose.Name = "cChose";
		this.cChose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.cChose.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
		this.cStt.HeaderText = "STT";
		this.cStt.Name = "cStt";
		this.cStt.Width = 35;
		this.C7BCAC1A.HeaderText = "Id";
		this.C7BCAC1A.Name = "cId";
		this.C7BCAC1A.Visible = false;
		this.C7BCAC1A.Width = 90;
		this.A3BB4204.HeaderText = "UID";
		this.A3BB4204.Name = "cUid";
		this.A3BB4204.Width = 80;
		this.cToken.HeaderText = "Token";
		this.cToken.Name = "cToken";
		this.cToken.Width = 70;
		this.D129E7AF.HeaderText = "Cookie";
		this.D129E7AF.Name = "cCookies";
		this.D129E7AF.Width = 70;
		this.cEmail.HeaderText = "Email";
		this.cEmail.Name = "cEmail";
		this.cEmail.Width = 60;
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
		this.DA9AE1A0.HeaderText = "Nho\u0301m";
		this.DA9AE1A0.Name = "cGroup";
		this.DA9AE1A0.Visible = false;
		this.DA9AE1A0.Width = 60;
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
		this.D735B51D.HeaderText = "Mật khẩu";
		this.D735B51D.Name = "cPassword";
		this.D735B51D.Visible = false;
		this.D735B51D.Width = 85;
		this.C52EF59C.HeaderText = "Email khôi phục";
		this.C52EF59C.Name = "cMailRecovery";
		this.C52EF59C.Visible = false;
		this.C52EF59C.Width = 125;
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
		this.D39B6B28.HeaderText = "Thư mục";
		this.D39B6B28.Name = "cThuMuc";
		this.D39B6B28.Visible = false;
		this.C111C000.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		this.C111C000.Name = "cInteractEnd";
		this.C111C000.Visible = false;
		this.C111C000.Width = 160;
		this.A53EC3AA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.A53EC3AA.HeaderText = "Tình Trạng";
		this.A53EC3AA.Name = "cInfo";
		this.A53EC3AA.Visible = false;
		this.C48060B1.HeaderText = "Ghi Chú";
		this.C48060B1.Name = "cGhiChu";
		this.C48060B1.Visible = false;
		this.C48060B1.Width = 90;
		this.cLocation.HeaderText = "Location";
		this.cLocation.Name = "cLocation";
		this.cLocation.Visible = false;
		this.cLocation.Width = 80;
		this.cHometown.HeaderText = "Hometown";
		this.cHometown.Name = "cHometown";
		this.cHometown.Visible = false;
		this.cHometown.Width = 90;
		this.AC257A8E.HeaderText = "Current City";
		this.AC257A8E.Name = "cCurrentCity";
		this.AC257A8E.Visible = false;
		this.E4810589.HeaderText = "Dating";
		this.E4810589.Name = "cDating";
		this.E4810589.Visible = false;
		this.cAds.HeaderText = "Ads";
		this.cAds.Name = "cAds";
		this.cAds.Visible = false;
		this.C237E4AB.HeaderText = "BM";
		this.C237E4AB.Name = "cBM";
		this.C237E4AB.Visible = false;
		this.E223F80C.HeaderText = "Wall Posts";
		this.E223F80C.Name = "cWallPosts";
		this.E223F80C.Visible = false;
		this.CB169920.HeaderText = "Fb Block";
		this.CB169920.Name = "cFbBlock";
		this.CB169920.Visible = false;
		this.cJob.HeaderText = "Job";
		this.cJob.Name = "cJob";
		this.cJob.Visible = false;
		this.D49B29AC.HeaderText = "Thơ\u0300i gian xo\u0301a";
		this.D49B29AC.Name = "cDateDelete";
		this.D49B29AC.Width = 115;
		this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.cStatus.HeaderText = "Trạng Thái";
		this.cStatus.MinimumWidth = 200;
		this.cStatus.Name = "cStatus";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1224, 610);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.menuStrip1);
		base.Controls.Add(this.panel1);
		this.DoubleBuffered = true;
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = this.menuStrip1;
		base.Name = "fTaiKhoanDaXoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE";
		this.ctmsAcc.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.AF8B4199).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.EDB05919.ResumeLayout(false);
		this.EDB05919.PerformLayout();
		this.BA918591.ResumeLayout(false);
		this.BA918591.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.EE084518.ResumeLayout(false);
		this.EE084518.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_34()
	{
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
	}

	[CompilerGenerated]
	private void D53A4D91()
	{
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			column.SortMode = DataGridViewColumnSortMode.Automatic;
		}
	}
}
