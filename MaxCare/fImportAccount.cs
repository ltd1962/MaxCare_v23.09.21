using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportAccount : Form
{
	[CompilerGenerated]
	private sealed class C7303527
	{
		public bool A11815B7;

		public int F7A65311;

		public string FBA8B434;

		public List<string> list_0;

		public fImportAccount BF3031AE;

		internal void D224CF10()
		{
			try
			{
				BF3031AE.E39561B4.Invoke((MethodInvoker)delegate
				{
					BF3031AE.E39561B4.Enabled = false;
				});
				BF3031AE.D08969A4(Language.GetValue("Chuẩn bị thêm tài khoản..."), BF3031AE.lblStatus);
				if (A11815B7)
				{
					int num = 0;
					while (num < BF3031AE.BCAFA792.Count)
					{
						if (BF3031AE.list_1.Count < F7A65311)
						{
							E80BF79F CS_0024_003C_003E8__locals0 = new E80BF79F
							{
								A910DDB8 = this,
								CF0FE200 = num++
							};
							BF3031AE.D08969A4($"Check info {CS_0024_003C_003E8__locals0.CF0FE200 + 1}/{BF3031AE.BCAFA792.Count}...", BF3031AE.lblStatus);
							Thread thread = new Thread((ThreadStart)delegate
							{
								try
								{
									string text3 = CS_0024_003C_003E8__locals0.A910DDB8.BF3031AE.BCAFA792[CS_0024_003C_003E8__locals0.CF0FE200];
									if (text3 != "")
									{
										string text4 = CS_0024_003C_003E8__locals0.A910DDB8.BF3031AE.D3053C82(CS_0024_003C_003E8__locals0.A910DDB8.FBA8B434, text3, CS_0024_003C_003E8__locals0.A910DDB8.A11815B7);
										if (text4 != "")
										{
											lock (CS_0024_003C_003E8__locals0.A910DDB8.list_0)
											{
												CS_0024_003C_003E8__locals0.A910DDB8.list_0.Add(text4);
												return;
											}
										}
									}
								}
								catch (Exception)
								{
								}
							});
							BF3031AE.list_1.Add(thread);
							thread.Start();
							continue;
						}
						for (int i = 0; i < BF3031AE.list_1.Count; i++)
						{
							if (!BF3031AE.list_1[i].IsAlive)
							{
								BF3031AE.list_1.RemoveAt(i--);
							}
						}
					}
					for (int j = 0; j < BF3031AE.list_1.Count; j++)
					{
						BF3031AE.list_1[j].Join();
					}
				}
				else
				{
					for (int k = 0; k < BF3031AE.BCAFA792.Count; k++)
					{
						try
						{
							string text = BF3031AE.BCAFA792[k];
							if (text != "")
							{
								string text2 = BF3031AE.D3053C82(FBA8B434, text, A11815B7);
								if (text2 != "")
								{
									list_0.Add(text2);
								}
							}
						}
						catch
						{
						}
					}
				}
				BF3031AE.D08969A4(Language.GetValue("Đang thêm tài khoản..."), BF3031AE.lblStatus);
				if (list_0.Count >= 0)
				{
					list_0 = CommonSQL.AC0DF4A0(list_0);
					for (int l = 0; l < list_0.Count; l++)
					{
						BF3031AE.AE8BFE84(BF3031AE.lblSuccess, Connector.Instance.ExecuteNonQuery(list_0[l]));
					}
				}
				BF3031AE.D08969A4((Convert.ToInt32(BF3031AE.lblTotal.Text) - Convert.ToInt32(BF3031AE.lblSuccess.Text)).ToString() ?? "", BF3031AE.AB0E6A91);
				BF3031AE.E39561B4.Invoke((MethodInvoker)delegate
				{
					BF3031AE.E39561B4.Enabled = true;
				});
				BF3031AE.D08969A4(Language.GetValue("Thêm tài khoản thành công!"), BF3031AE.lblStatus);
				MessageBoxHelper.Show("Thêm tài khoản thành công!");
				BF3031AE.bool_0 = true;
				BF3031AE.int_0 = Convert.ToInt32(FBA8B434);
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "AddAccount");
			}
		}
	}

	[CompilerGenerated]
	private sealed class E80BF79F
	{
		public int CF0FE200;

		public C7303527 A910DDB8;

		internal void B23FB82D()
		{
			try
			{
				string text = A910DDB8.BF3031AE.BCAFA792[CF0FE200];
				if (!(text != ""))
				{
					return;
				}
				string text2 = A910DDB8.BF3031AE.D3053C82(A910DDB8.FBA8B434, text, A910DDB8.A11815B7);
				if (text2 != "")
				{
					lock (A910DDB8.list_0)
					{
						A910DDB8.list_0.Add(text2);
						return;
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class70
	{
		public Label label_0;

		public string F3A6B18D;

		internal void E8195724()
		{
			Application.DoEvents();
			label_0.Text = F3A6B18D;
		}
	}

	[CompilerGenerated]
	private sealed class Class71
	{
		public Label label_0;

		public int EAA6CC1A;

		internal void method_0()
		{
			Application.DoEvents();
			label_0.Text = (Convert.ToInt32(label_0.Text) + ((EAA6CC1A == -1) ? 1 : EAA6CC1A)).ToString();
		}

		internal void method_1()
		{
			Application.DoEvents();
			label_0.Text = (Convert.ToInt32(label_0.Text) + EAA6CC1A).ToString();
		}
	}

	public bool bool_0 = false;

	public int int_0 = -1;

	public bool D0294328 = false;

	private List<ComboBox> list_0;

	private int BBA8CE36 = 0;

	private List<string> BCAFA792 = new List<string>();

	private List<Thread> list_1 = null;

	private object object_0 = new object();

	private List<string> C6BABD14 = new List<string>();

	private string string_0 = FileHelper.GetPathToCurrentFolder() + "\\settings\\inputformat.txt";

	private IContainer icontainer_0 = null;

	private BunifuCards CF238E18;

	private Button E39561B4;

	private Button btnCancel;

	private Label lblSuccess;

	private Label AB0E6A91;

	private Label lblTotal;

	private Label EA3F8634;

	private Label label4;

	private Label label7;

	private Label lblStatus;

	private Label C8269B31;

	private ComboBox B33A3934;

	private ComboBox CFB4B685;

	private Label BBA0B200;

	private ComboBox cbbDinhDang2;

	private Label label10;

	private ComboBox F63FB188;

	private Label label11;

	private ComboBox A39FFC23;

	private Label CE0D2C3A;

	private ComboBox cbbDinhDang5;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label14;

	private ComboBox cbbDinhDang7;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl BD27F589;

	private Panel AE834AB7;

	private PictureBox F99E368A;

	private Label label16;

	private ComboBox E7B8F49E;

	private Button button1;

	private RichTextBox txbAccount;

	private Label label18;

	private Label label17;

	private ComboBox cbbDinhDang8;

	private ComboBox C79627B1;

	private Button button2;

	private Button button3;

	private Label A21C6420;

	private Label label1;

	private ComboBox cbbDinhDang10;

	private ComboBox cbbDinhDang11;

	private Panel pnlHeader;

	private Button A107EC81;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button A500998E;

	private Button AddFileAccount;

	private Panel panel1;

	private CheckBox ckbCheckThongTin;

	public fImportAccount(string B28F90A4)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		method_1();
		if (B28F90A4 != "" && B28F90A4 != "-1" && B28F90A4 != "999999")
		{
			E7B8F49E.SelectedValue = B28F90A4;
		}
		B33A3934.SelectedIndex = 0;
		D0294328 = false;
		bool_0 = false;
		int_0 = -1;
		method_0();
	}

	private void method_0()
	{
		list_0 = new List<ComboBox>
		{
			CFB4B685, cbbDinhDang2, F63FB188, A39FFC23, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, C79627B1, cbbDinhDang10,
			cbbDinhDang11
		};
		foreach (ComboBox item in list_0)
		{
			Common.F714B10E(item, new List<string>
			{
				"", "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy",
				"Birthday", "Bạn bè", "Ngày tạo", "Mail khôi phục", "Ghi chú"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
	}

	private void method_1()
	{
		BBA8CE36 = E7B8F49E.SelectedIndex;
		DataTable dataTable = CommonSQL.C6B3348F();
		if (dataTable.Rows.Count > 0)
		{
			E7B8F49E.DataSource = dataTable;
			E7B8F49E.ValueMember = "id";
			E7B8F49E.DisplayMember = "name";
			if (BBA8CE36 == -1)
			{
				BBA8CE36 = 0;
			}
			E7B8F49E.SelectedIndex = BBA8CE36;
		}
	}

	private void A1834CA9(object sender, EventArgs e)
	{
		Close();
	}

	private void A0BC61B6(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txbAccount.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!"), 3);
				txbAccount.Focus();
				return;
			}
			if (E7B8F49E.SelectedValue == null)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng cho\u0323n thư mu\u0323c!"), 3);
				return;
			}
			string FBA8B434 = E7B8F49E.SelectedValue.ToString();
			bool A11815B7 = ckbCheckThongTin.Checked;
			string text = B33A3934.Text;
			int selectedIndex = B33A3934.SelectedIndex;
			if (selectedIndex == B33A3934.Items.Count - 1)
			{
				bool flag = false;
				for (int i = 0; i < this.list_0.Count; i++)
				{
					if (this.list_0[i].SelectedIndex > 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!", 3);
					return;
				}
				text = "";
				for (int j = 0; j < this.list_0.Count; j++)
				{
					text = text + this.list_0[j].Text + "|";
				}
				text = text.TrimEnd('|');
			}
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!");
				return;
			}
			int F7A65311 = 100;
			if (a2AB53A.Count < 100)
			{
				F7A65311 = a2AB53A.Count;
			}
			lblSuccess.Text = "0";
			AB0E6A91.Text = "0";
			BCAFA792 = new List<string>();
			List<string> list = text.Split('|').ToList();
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
			for (int k = 0; k < a2AB53A.Count; k++)
			{
				string[] array = a2AB53A[k].Split('|');
				try
				{
					for (int l = 0; l < list.Count; l++)
					{
						switch (list[l])
						{
						case "Uid":
							text2 = array[l];
							break;
						case "2FA":
							text8 = array[l];
							break;
						case "Pass":
							text3 = array[l];
							break;
						case "Token":
							text4 = array[l];
							break;
						case "Proxy":
							text10 = ((!(array[l].Trim() == "")) ? (array[l] + "*0") : "");
							break;
						case "Email":
							text6 = array[l];
							break;
						case "Cookie":
							text5 = array[l];
							break;
						case "Note":
						case "Ghi chú":
							text15 = array[l];
							break;
						case "Bạn bè":
						case "Friends":
							text12 = array[l];
							break;
						case "Useragent":
							text9 = array[l];
							break;
						case "Birthday":
						case "Ngày sinh":
							text11 = array[l];
							break;
						case "Pass Email":
							text7 = array[l];
							break;
						case "Ngày tạo":
						case "Date created":
							text13 = array[l];
							break;
						case "Email recover":
						case "Mail khôi phục":
							text14 = array[l];
							break;
						}
					}
					BCAFA792.Add(text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14 + "|" + text15);
				}
				catch
				{
					AE8BFE84(AB0E6A91);
				}
			}
			List<string> list_0 = new List<string>();
			list_1 = new List<Thread>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					E39561B4.Invoke((MethodInvoker)delegate
					{
						E39561B4.Enabled = false;
					});
					D08969A4(Language.GetValue("Chuẩn bị thêm tài khoản..."), lblStatus);
					if (A11815B7)
					{
						int num = 0;
						while (num < BCAFA792.Count)
						{
							if (list_1.Count < F7A65311)
							{
								int CF0FE200 = num++;
								D08969A4($"Check info {CF0FE200 + 1}/{BCAFA792.Count}...", lblStatus);
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										string text18 = BCAFA792[CF0FE200];
										if (text18 != "")
										{
											string text19 = D3053C82(FBA8B434, text18, A11815B7);
											if (text19 != "")
											{
												lock (list_0)
												{
													list_0.Add(text19);
													return;
												}
											}
										}
									}
									catch (Exception)
									{
									}
								});
								list_1.Add(thread);
								thread.Start();
							}
							else
							{
								for (int m = 0; m < list_1.Count; m++)
								{
									if (!list_1[m].IsAlive)
									{
										list_1.RemoveAt(m--);
									}
								}
							}
						}
						for (int n = 0; n < list_1.Count; n++)
						{
							list_1[n].Join();
						}
					}
					else
					{
						for (int num2 = 0; num2 < BCAFA792.Count; num2++)
						{
							try
							{
								string text16 = BCAFA792[num2];
								if (text16 != "")
								{
									string text17 = D3053C82(FBA8B434, text16, A11815B7);
									if (text17 != "")
									{
										list_0.Add(text17);
									}
								}
							}
							catch
							{
							}
						}
					}
					D08969A4(Language.GetValue("Đang thêm tài khoản..."), lblStatus);
					if (list_0.Count >= 0)
					{
						list_0 = CommonSQL.AC0DF4A0(list_0);
						for (int num3 = 0; num3 < list_0.Count; num3++)
						{
							AE8BFE84(lblSuccess, Connector.Instance.ExecuteNonQuery(list_0[num3]));
						}
					}
					D08969A4((Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(lblSuccess.Text)).ToString() ?? "", AB0E6A91);
					E39561B4.Invoke((MethodInvoker)delegate
					{
						E39561B4.Enabled = true;
					});
					D08969A4(Language.GetValue("Thêm tài khoản thành công!"), lblStatus);
					MessageBoxHelper.Show("Thêm tài khoản thành công!");
					bool_0 = true;
					int_0 = Convert.ToInt32(FBA8B434);
				}
				catch (Exception exception_2)
				{
					Common.ExportError(null, exception_2, "AddAccount");
				}
			}).Start();
		}
		catch (Exception exception_)
		{
			MessageBoxHelper.Show("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			Common.ExportError(null, exception_, "AddAccount");
		}
	}

	private string D3053C82(string string_1, string A32B1931, bool bool_1)
	{
		try
		{
			string[] array = A32B1931.Split('|');
			string text = array[0];
			string aEA7D = array[1];
			string d53167B = array[2];
			string input = array[3];
			string string_2 = array[4];
			string fCB8341A = array[5];
			string e20C2E = array[6];
			string bC25EBB = array[7];
			string string_3 = array[8];
			string aD1D821B = array[9];
			string eBA5F = array[10];
			string a09C = array[11];
			string fFB63DA = array[12];
			string string_4 = "";
			string string_5 = "";
			string string_6 = "";
			string a3BBB82D = "unknow";
			string bF82C72E = array[13];
			if (text == "")
			{
				text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			}
			if (bool_1 && text != "")
			{
				string text2 = CheckInfoAccountv2.CheckInfoUid_Old(text);
				if (text2.StartsWith("0|"))
				{
					if (CheckInfoAccountv2.CheckLiveWall(text).StartsWith("0|"))
					{
						a3BBB82D = "Die";
					}
				}
				else if (text2.StartsWith("1|"))
				{
					string[] array2 = text2.Split('|');
					string_4 = array2[1];
					eBA5F = array2[2];
					a09C = array2[3];
					a3BBB82D = "Live";
				}
			}
			return CommonSQL.ConvertToSqlInsertAccount(text, aEA7D, d53167B, input, string_2, string_4, eBA5F, string_5, aD1D821B, string_6, a3BBB82D, e20C2E, string_1, fCB8341A, bC25EBB, string_3, a09C, fFB63DA, bF82C72E);
		}
		catch (Exception)
		{
		}
		return "";
	}

	private void D08969A4(string string_1, Label A6A41A2F)
	{
		A6A41A2F.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			A6A41A2F.Text = string_1;
		});
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetFormatInput(byte[] byte_0);

	public static string smethod_0(string string_1)
	{
		return Common.smethod_6(GetFormatInput(Common.B2B3DBBA(string_1)));
	}

	private void txbAccount_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txbAccount.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblTotal.Text = a2AB53A.Count.ToString();
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			int num = a2AB53A.Count;
			if (num > 10)
			{
				num = 10;
			}
			for (int i = 0; i < num; i++)
			{
				string string_ = a2AB53A[i];
				list2 = smethod_0(string_).Split('|').ToList();
				if (list.Count == 0)
				{
					list = new List<string>(list2);
				}
				else
				{
					if (list.Count < list2.Count)
					{
						_ = list.Count;
					}
					else
						_ = list2.Count;
					for (int j = 0; j < list.Count; j++)
					{
						if (list[j] == "" && list2[j] != "")
						{
							list[j] = list2[j];
						}
					}
				}
				if (!list.Contains(""))
				{
					break;
				}
			}
			string item = string.Join("|", list);
			if (C6BABD14.Contains(item))
			{
				B33A3934.Text = item;
				return;
			}
			B33A3934.SelectedIndex = B33A3934.Items.Count - 1;
			int num2 = ((list.Count < list_0.Count) ? list.Count : list_0.Count);
			for (int k = 0; k < num2; k++)
			{
				list_0[k].Text = list[k];
			}
			for (int l = num2; l < list_0.Count; l++)
			{
				list_0[l].Text = "";
			}
		}
		catch
		{
		}
	}

	private void AE8BFE84(Label AD98E31C, int int_1 = -1)
	{
		if (int_1 == -1)
		{
			AD98E31C.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				AD98E31C.Text = (Convert.ToInt32(AD98E31C.Text) + ((int_1 == -1) ? 1 : int_1)).ToString();
			});
		}
		else
		{
			AD98E31C.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				AD98E31C.Text = (Convert.ToInt32(AD98E31C.Text) + int_1).ToString();
			});
		}
	}

	private void B33A3934_SelectedIndexChanged(object sender, EventArgs e)
	{
		AE834AB7.Visible = B33A3934.SelectedIndex == B33A3934.Items.Count - 1;
		if (AE834AB7.Visible)
		{
			EE0CBCB2();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		Common.ShowForm(form_);
		if (fAddFile.bool_0)
		{
			method_1();
			E7B8F49E.SelectedIndex = E7B8F49E.Items.Count - 1;
			D0294328 = true;
		}
	}

	private bool FA28D28C()
	{
		return false;
	}

	private void C79627B1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (FA28D28C())
		{
			MessageBoxHelper.Show("Tu\u0300y cho\u0323n na\u0300y đa\u0303 tô\u0300n ta\u0323i, vui lo\u0300ng cho\u0323n tu\u0300y cho\u0323n kha\u0301c!", 3);
			(sender as ComboBox).SelectedIndex = -1;
		}
	}

	private void B384BD83(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		A439728E();
	}

	private void CA99E4BD(object sender, EventArgs e)
	{
		method_2();
	}

	private void A439728E()
	{
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			string text = "";
			for (int i = 0; i < list_0.Count; i++)
			{
				text = text + list_0[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			SettingsTool.GetSettings("configFormat").GetJson("pasteFormat", text);
			SettingsTool.GetSettings("configFormat").method_7();
		}
		catch
		{
		}
	}

	private void EE0CBCB2()
	{
		try
		{
			string text = SettingsTool.GetSettings("configFormat").GetValue("pasteFormat");
			if (text != "")
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					list_0[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
	}

	private void AddFileAccount_Click(object sender, EventArgs e)
	{
		fImportAccountFormatInput fImportAccountFormatInput2 = new fImportAccountFormatInput();
		Common.ShowForm(fImportAccountFormatInput2);
		string text = fImportAccountFormatInput2.string_0.Trim();
		if (text != "" && !C6BABD14.Contains(text))
		{
			C6BABD14.Add(text);
			File.WriteAllLines(string_0, C6BABD14);
			method_3();
			B33A3934.SelectedIndex = B33A3934.Items.Count - 2;
		}
	}

	private void D5101EAF(object sender, EventArgs e)
	{
		int selectedIndex = B33A3934.SelectedIndex;
		if (selectedIndex == -1 || selectedIndex == B33A3934.Items.Count - 1)
		{
			MessageBoxHelper.Show("Không thể xóa định dạng này!", 3);
			return;
		}
		string text = B33A3934.Text;
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n xóa định dạng \"{0}\"?"), text)) == DialogResult.Yes)
		{
			C6BABD14.Remove(text);
			File.WriteAllLines(string_0, C6BABD14);
			method_3();
			B33A3934.SelectedIndex = ((selectedIndex != 0 || B33A3934.Items.Count <= 0) ? (selectedIndex - 1) : 0);
		}
	}

	private void FC937A03_Load(object sender, EventArgs e)
	{
		Common.CreateFile(string_0);
		C6BABD14 = File.ReadAllText(string_0).Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (C6BABD14.Count == 0)
		{
			C6BABD14 = new List<string> { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA" };
		}
		method_3();
		B33A3934.SelectedIndex = 0;
	}

	private void method_3()
	{
		B33A3934.Items.Clear();
		for (int i = 0; i < C6BABD14.Count; i++)
		{
			B33A3934.Items.Add(C6BABD14[i]);
		}
		B33A3934.Items.Add("Other...");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportAccount));
		this.CF238E18 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.F99E368A = new System.Windows.Forms.PictureBox();
		this.A107EC81 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E39561B4 = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.lblSuccess = new System.Windows.Forms.Label();
		this.AB0E6A91 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.EA3F8634 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.C8269B31 = new System.Windows.Forms.Label();
		this.B33A3934 = new System.Windows.Forms.ComboBox();
		this.CFB4B685 = new System.Windows.Forms.ComboBox();
		this.BBA0B200 = new System.Windows.Forms.Label();
		this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		this.label10 = new System.Windows.Forms.Label();
		this.F63FB188 = new System.Windows.Forms.ComboBox();
		this.label11 = new System.Windows.Forms.Label();
		this.A39FFC23 = new System.Windows.Forms.ComboBox();
		this.CE0D2C3A = new System.Windows.Forms.Label();
		this.cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		this.label13 = new System.Windows.Forms.Label();
		this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		this.label14 = new System.Windows.Forms.Label();
		this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.BD27F589 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.AE834AB7 = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.A21C6420 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		this.label17 = new System.Windows.Forms.Label();
		this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		this.C79627B1 = new System.Windows.Forms.ComboBox();
		this.label16 = new System.Windows.Forms.Label();
		this.E7B8F49E = new System.Windows.Forms.ComboBox();
		this.button1 = new System.Windows.Forms.Button();
		this.txbAccount = new System.Windows.Forms.RichTextBox();
		this.A500998E = new System.Windows.Forms.Button();
		this.AddFileAccount = new System.Windows.Forms.Button();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbCheckThongTin = new System.Windows.Forms.CheckBox();
		this.CF238E18.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.F99E368A).BeginInit();
		this.AE834AB7.SuspendLayout();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.CF238E18.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CF238E18.BackColor = System.Drawing.Color.White;
		this.CF238E18.BorderRadius = 0;
		this.CF238E18.BottomSahddow = true;
		this.CF238E18.color = System.Drawing.Color.DarkViolet;
		this.CF238E18.Controls.Add(this.pnlHeader);
		this.CF238E18.LeftSahddow = false;
		this.CF238E18.Location = new System.Drawing.Point(1, 0);
		this.CF238E18.Name = "bunifuCards1";
		this.CF238E18.RightSahddow = true;
		this.CF238E18.ShadowDepth = 20;
		this.CF238E18.Size = new System.Drawing.Size(1142, 37);
		this.CF238E18.TabIndex = 11;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.F99E368A);
		this.pnlHeader.Controls.Add(this.A107EC81);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1142, 31);
		this.pnlHeader.TabIndex = 9;
		this.F99E368A.Cursor = System.Windows.Forms.Cursors.Default;
		this.F99E368A.Image = Resources.Bitmap_4;
		this.F99E368A.Location = new System.Drawing.Point(3, 2);
		this.F99E368A.Name = "pictureBox1";
		this.F99E368A.Size = new System.Drawing.Size(34, 27);
		this.F99E368A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.F99E368A.TabIndex = 76;
		this.F99E368A.TabStop = false;
		this.A107EC81.Anchor = System.Windows.Forms.AnchorStyles.Right;
		this.A107EC81.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A107EC81.FlatAppearance.BorderSize = 0;
		this.A107EC81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A107EC81.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A107EC81.ForeColor = System.Drawing.Color.White;
		this.A107EC81.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.A107EC81.Location = new System.Drawing.Point(1110, 2);
		this.A107EC81.Name = "btnMinimize";
		this.A107EC81.Size = new System.Drawing.Size(30, 30);
		this.A107EC81.TabIndex = 9;
		this.A107EC81.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A107EC81.UseVisualStyleBackColor = true;
		this.A107EC81.Click += new System.EventHandler(A1834CA9);
		this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1104, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Nhập Tài Khoản";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E39561B4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.E39561B4.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.E39561B4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E39561B4.FlatAppearance.BorderSize = 0;
		this.E39561B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E39561B4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E39561B4.ForeColor = System.Drawing.Color.White;
		this.E39561B4.Location = new System.Drawing.Point(459, 480);
		this.E39561B4.Name = "btnAdd";
		this.E39561B4.Size = new System.Drawing.Size(107, 31);
		this.E39561B4.TabIndex = 13;
		this.E39561B4.Text = "Thêm";
		this.E39561B4.UseVisualStyleBackColor = false;
		this.E39561B4.Click += new System.EventHandler(A0BC61B6);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(573, 480);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(107, 31);
		this.btnCancel.TabIndex = 14;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(A1834CA9);
		this.lblSuccess.AutoSize = true;
		this.lblSuccess.BackColor = System.Drawing.SystemColors.Control;
		this.lblSuccess.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.lblSuccess.Location = new System.Drawing.Point(106, 51);
		this.lblSuccess.Name = "lblSuccess";
		this.lblSuccess.Size = new System.Drawing.Size(19, 19);
		this.lblSuccess.TabIndex = 23;
		this.lblSuccess.Text = "0";
		this.AB0E6A91.AutoSize = true;
		this.AB0E6A91.BackColor = System.Drawing.SystemColors.Control;
		this.AB0E6A91.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AB0E6A91.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		this.AB0E6A91.Location = new System.Drawing.Point(528, 51);
		this.AB0E6A91.Name = "lblError";
		this.AB0E6A91.Size = new System.Drawing.Size(19, 19);
		this.AB0E6A91.TabIndex = 24;
		this.AB0E6A91.Text = "0";
		this.lblTotal.AutoSize = true;
		this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
		this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTotal.ForeColor = System.Drawing.Color.Teal;
		this.lblTotal.Location = new System.Drawing.Point(910, 51);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(19, 19);
		this.lblTotal.TabIndex = 26;
		this.lblTotal.Text = "0";
		this.EA3F8634.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.EA3F8634.Location = new System.Drawing.Point(22, 53);
		this.EA3F8634.Name = "label3";
		this.EA3F8634.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.EA3F8634.Size = new System.Drawing.Size(87, 16);
		this.EA3F8634.TabIndex = 34;
		this.EA3F8634.Text = "Tha\u0300nh công:";
		this.EA3F8634.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label4.Location = new System.Drawing.Point(480, 53);
		this.label4.Name = "label4";
		this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label4.Size = new System.Drawing.Size(52, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "Lỗi:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(851, 53);
		this.label7.Name = "label7";
		this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label7.Size = new System.Drawing.Size(63, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "Tô\u0309ng sô\u0301:";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.Location = new System.Drawing.Point(12, 86);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(1023, 28);
		this.lblStatus.TabIndex = 27;
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C8269B31.AutoSize = true;
		this.C8269B31.Location = new System.Drawing.Point(12, 397);
		this.C8269B31.Name = "label8";
		this.C8269B31.Size = new System.Drawing.Size(102, 16);
		this.C8269B31.TabIndex = 39;
		this.C8269B31.Text = "Định dạng nhập:";
		this.B33A3934.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B33A3934.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.B33A3934.FormattingEnabled = true;
		this.B33A3934.Items.AddRange(new object[7] { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Other..." });
		this.B33A3934.Location = new System.Drawing.Point(115, 394);
		this.B33A3934.Name = "cbbDinhDangNhap";
		this.B33A3934.Size = new System.Drawing.Size(269, 24);
		this.B33A3934.TabIndex = 40;
		this.B33A3934.SelectedIndexChanged += new System.EventHandler(B33A3934_SelectedIndexChanged);
		this.CFB4B685.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CFB4B685.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CFB4B685.DropDownWidth = 100;
		this.CFB4B685.FormattingEnabled = true;
		this.CFB4B685.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.CFB4B685.Location = new System.Drawing.Point(3, 3);
		this.CFB4B685.Name = "cbbDinhDang1";
		this.CFB4B685.Size = new System.Drawing.Size(78, 24);
		this.CFB4B685.TabIndex = 40;
		this.CFB4B685.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.BBA0B200.AutoSize = true;
		this.BBA0B200.Font = new System.Drawing.Font("Tahoma", 12f);
		this.BBA0B200.Location = new System.Drawing.Point(81, 3);
		this.BBA0B200.Name = "label9";
		this.BBA0B200.Size = new System.Drawing.Size(15, 19);
		this.BBA0B200.TabIndex = 41;
		this.BBA0B200.Text = "|";
		this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang2.DropDownWidth = 100;
		this.cbbDinhDang2.FormattingEnabled = true;
		this.cbbDinhDang2.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang2.Location = new System.Drawing.Point(96, 3);
		this.cbbDinhDang2.Name = "cbbDinhDang2";
		this.cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang2.TabIndex = 40;
		this.cbbDinhDang2.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label10.Location = new System.Drawing.Point(174, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(15, 19);
		this.label10.TabIndex = 41;
		this.label10.Text = "|";
		this.F63FB188.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F63FB188.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.F63FB188.DropDownWidth = 100;
		this.F63FB188.FormattingEnabled = true;
		this.F63FB188.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.F63FB188.Location = new System.Drawing.Point(189, 3);
		this.F63FB188.Name = "cbbDinhDang3";
		this.F63FB188.Size = new System.Drawing.Size(78, 24);
		this.F63FB188.TabIndex = 40;
		this.F63FB188.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.label11.AutoSize = true;
		this.label11.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label11.Location = new System.Drawing.Point(267, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(15, 19);
		this.label11.TabIndex = 41;
		this.label11.Text = "|";
		this.A39FFC23.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A39FFC23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.A39FFC23.DropDownWidth = 100;
		this.A39FFC23.FormattingEnabled = true;
		this.A39FFC23.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.A39FFC23.Location = new System.Drawing.Point(282, 3);
		this.A39FFC23.Name = "cbbDinhDang4";
		this.A39FFC23.Size = new System.Drawing.Size(78, 24);
		this.A39FFC23.TabIndex = 40;
		this.A39FFC23.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.CE0D2C3A.AutoSize = true;
		this.CE0D2C3A.Font = new System.Drawing.Font("Tahoma", 12f);
		this.CE0D2C3A.Location = new System.Drawing.Point(360, 3);
		this.CE0D2C3A.Name = "label12";
		this.CE0D2C3A.Size = new System.Drawing.Size(15, 19);
		this.CE0D2C3A.TabIndex = 41;
		this.CE0D2C3A.Text = "|";
		this.cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang5.DropDownWidth = 100;
		this.cbbDinhDang5.FormattingEnabled = true;
		this.cbbDinhDang5.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang5.Location = new System.Drawing.Point(375, 3);
		this.cbbDinhDang5.Name = "cbbDinhDang5";
		this.cbbDinhDang5.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang5.TabIndex = 40;
		this.cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label13.Location = new System.Drawing.Point(453, 3);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(15, 19);
		this.label13.TabIndex = 41;
		this.label13.Text = "|";
		this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang6.DropDownWidth = 100;
		this.cbbDinhDang6.FormattingEnabled = true;
		this.cbbDinhDang6.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang6.Location = new System.Drawing.Point(468, 3);
		this.cbbDinhDang6.Name = "cbbDinhDang6";
		this.cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang6.TabIndex = 40;
		this.cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label14.Location = new System.Drawing.Point(546, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(15, 19);
		this.label14.TabIndex = 41;
		this.label14.Text = "|";
		this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang7.DropDownWidth = 100;
		this.cbbDinhDang7.FormattingEnabled = true;
		this.cbbDinhDang7.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang7.Location = new System.Drawing.Point(561, 3);
		this.cbbDinhDang7.Name = "cbbDinhDang7";
		this.cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang7.TabIndex = 40;
		this.cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.BD27F589.Fixed = true;
		this.BD27F589.Horizontal = true;
		this.BD27F589.TargetControl = this.pnlHeader;
		this.BD27F589.Vertical = true;
		this.AE834AB7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.AE834AB7.Controls.Add(this.button2);
		this.AE834AB7.Controls.Add(this.button3);
		this.AE834AB7.Controls.Add(this.CFB4B685);
		this.AE834AB7.Controls.Add(this.cbbDinhDang2);
		this.AE834AB7.Controls.Add(this.F63FB188);
		this.AE834AB7.Controls.Add(this.A39FFC23);
		this.AE834AB7.Controls.Add(this.A21C6420);
		this.AE834AB7.Controls.Add(this.label18);
		this.AE834AB7.Controls.Add(this.label14);
		this.AE834AB7.Controls.Add(this.cbbDinhDang5);
		this.AE834AB7.Controls.Add(this.label1);
		this.AE834AB7.Controls.Add(this.cbbDinhDang10);
		this.AE834AB7.Controls.Add(this.label17);
		this.AE834AB7.Controls.Add(this.cbbDinhDang8);
		this.AE834AB7.Controls.Add(this.label13);
		this.AE834AB7.Controls.Add(this.cbbDinhDang11);
		this.AE834AB7.Controls.Add(this.cbbDinhDang6);
		this.AE834AB7.Controls.Add(this.C79627B1);
		this.AE834AB7.Controls.Add(this.CE0D2C3A);
		this.AE834AB7.Controls.Add(this.cbbDinhDang7);
		this.AE834AB7.Controls.Add(this.label11);
		this.AE834AB7.Controls.Add(this.BBA0B200);
		this.AE834AB7.Controls.Add(this.label10);
		this.AE834AB7.Location = new System.Drawing.Point(115, 420);
		this.AE834AB7.Name = "plDinhDangNhap";
		this.AE834AB7.Size = new System.Drawing.Size(1016, 32);
		this.AE834AB7.TabIndex = 46;
		this.button2.BackColor = System.Drawing.Color.DarkOrange;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Location = new System.Drawing.Point(379, 35);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(121, 29);
		this.button2.TabIndex = 43;
		this.button2.Text = "Reset định dạng";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.button3.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.FlatAppearance.BorderSize = 0;
		this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.ForeColor = System.Drawing.Color.White;
		this.button3.Location = new System.Drawing.Point(516, 35);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(120, 29);
		this.button3.TabIndex = 42;
		this.button3.Text = "Lưu định dạng";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new System.EventHandler(CA99E4BD);
		this.A21C6420.AutoSize = true;
		this.A21C6420.Font = new System.Drawing.Font("Tahoma", 12f);
		this.A21C6420.Location = new System.Drawing.Point(919, 3);
		this.A21C6420.Name = "label19";
		this.A21C6420.Size = new System.Drawing.Size(15, 19);
		this.A21C6420.TabIndex = 41;
		this.A21C6420.Text = "|";
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label18.Location = new System.Drawing.Point(732, 3);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(15, 19);
		this.label18.TabIndex = 41;
		this.label18.Text = "|";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label1.Location = new System.Drawing.Point(826, 5);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(15, 19);
		this.label1.TabIndex = 41;
		this.label1.Text = "|";
		this.cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang10.DropDownWidth = 100;
		this.cbbDinhDang10.FormattingEnabled = true;
		this.cbbDinhDang10.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang10.Location = new System.Drawing.Point(841, 3);
		this.cbbDinhDang10.Name = "cbbDinhDang10";
		this.cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang10.TabIndex = 40;
		this.cbbDinhDang10.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label17.Location = new System.Drawing.Point(639, 3);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(15, 19);
		this.label17.TabIndex = 41;
		this.label17.Text = "|";
		this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang8.DropDownWidth = 100;
		this.cbbDinhDang8.FormattingEnabled = true;
		this.cbbDinhDang8.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang8.Location = new System.Drawing.Point(654, 3);
		this.cbbDinhDang8.Name = "cbbDinhDang8";
		this.cbbDinhDang8.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang8.TabIndex = 40;
		this.cbbDinhDang8.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang11.DropDownWidth = 100;
		this.cbbDinhDang11.FormattingEnabled = true;
		this.cbbDinhDang11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang11.Location = new System.Drawing.Point(934, 3);
		this.cbbDinhDang11.Name = "cbbDinhDang11";
		this.cbbDinhDang11.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang11.TabIndex = 40;
		this.cbbDinhDang11.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.C79627B1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C79627B1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.C79627B1.DropDownWidth = 100;
		this.C79627B1.FormattingEnabled = true;
		this.C79627B1.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.C79627B1.Location = new System.Drawing.Point(747, 3);
		this.C79627B1.Name = "cbbDinhDang9";
		this.C79627B1.Size = new System.Drawing.Size(78, 24);
		this.C79627B1.TabIndex = 40;
		this.C79627B1.SelectedIndexChanged += new System.EventHandler(C79627B1_SelectedIndexChanged);
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(12, 368);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(92, 16);
		this.label16.TabIndex = 39;
		this.label16.Text = "Cho\u0323n thư mu\u0323c:";
		this.E7B8F49E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E7B8F49E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.E7B8F49E.DropDownWidth = 269;
		this.E7B8F49E.FormattingEnabled = true;
		this.E7B8F49E.Location = new System.Drawing.Point(115, 365);
		this.E7B8F49E.Name = "cbbThuMuc";
		this.E7B8F49E.Size = new System.Drawing.Size(268, 24);
		this.E7B8F49E.TabIndex = 40;
		this.E7B8F49E.SelectedIndexChanged += new System.EventHandler(B384BD83);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Location = new System.Drawing.Point(389, 364);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(58, 26);
		this.button1.TabIndex = 45;
		this.button1.Text = "Thêm";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txbAccount.Location = new System.Drawing.Point(13, 120);
		this.txbAccount.Name = "txbAccount";
		this.txbAccount.Size = new System.Drawing.Size(1118, 238);
		this.txbAccount.TabIndex = 48;
		this.txbAccount.Text = "";
		this.txbAccount.WordWrap = false;
		this.txbAccount.TextChanged += new System.EventHandler(txbAccount_TextChanged);
		this.A500998E.BackgroundImage = Resources.Bitmap_138;
		this.A500998E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.A500998E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A500998E.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.A500998E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A500998E.Location = new System.Drawing.Point(421, 393);
		this.A500998E.Name = "metroButton1";
		this.A500998E.Size = new System.Drawing.Size(25, 25);
		this.A500998E.TabIndex = 50;
		this.A500998E.Click += new System.EventHandler(D5101EAF);
		this.AddFileAccount.BackgroundImage = (System.Drawing.Image)resources.GetObject("AddFileAccount.BackgroundImage");
		this.AddFileAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.AddFileAccount.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AddFileAccount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.AddFileAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AddFileAccount.Location = new System.Drawing.Point(390, 393);
		this.AddFileAccount.Name = "AddFileAccount";
		this.AddFileAccount.Size = new System.Drawing.Size(25, 25);
		this.AddFileAccount.TabIndex = 51;
		this.AddFileAccount.Click += new System.EventHandler(AddFileAccount_Click);
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.ckbCheckThongTin);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1143, 524);
		this.panel1.TabIndex = 52;
		this.ckbCheckThongTin.AutoSize = true;
		this.ckbCheckThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckThongTin.Location = new System.Drawing.Point(12, 455);
		this.ckbCheckThongTin.Name = "ckbCheckThongTin";
		this.ckbCheckThongTin.Size = new System.Drawing.Size(255, 20);
		this.ckbCheckThongTin.TabIndex = 0;
		this.ckbCheckThongTin.Text = "Check thông tin (Tên, Bạn bè, Ngày tạo)";
		this.ckbCheckThongTin.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1143, 524);
		base.Controls.Add(this.A500998E);
		base.Controls.Add(this.AddFileAccount);
		base.Controls.Add(this.txbAccount);
		base.Controls.Add(this.AE834AB7);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.E7B8F49E);
		base.Controls.Add(this.B33A3934);
		base.Controls.Add(this.label16);
		base.Controls.Add(this.C8269B31);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.EA3F8634);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.AB0E6A91);
		base.Controls.Add(this.lblSuccess);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.E39561B4);
		base.Controls.Add(this.CF238E18);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportAccount";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Nhập tài khoản";
		base.Load += new System.EventHandler(FC937A03_Load);
		this.CF238E18.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.F99E368A).EndInit();
		this.AE834AB7.ResumeLayout(false);
		this.AE834AB7.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void D1AA16B8()
	{
		E39561B4.Enabled = false;
	}

	[CompilerGenerated]
	private void method_4()
	{
		E39561B4.Enabled = true;
	}
}
