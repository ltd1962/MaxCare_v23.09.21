using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhChung : Form
{
	private string string_0 = "";

	private JSON_Settings json = new JSON_Settings();

	private string string_1 = "";

	private IContainer A4388412 = null;

	private BunifuCards bunifuCards1;

	private Label label3;

	private NumericUpDown A395893A;

	private Label label4;

	private Label label5;

	private NumericUpDown nudHideThread;

	private Label label6;

	private Label label9;

	private TextBox txbPathProfile;

	private Panel C20904A3;

	private GroupBox grCauHinhChung;

	private CheckBox E4A78182;

	private ComboBox AB94A2A0;

	private Panel plNordVPN;

	private Label A0B2E523;

	private TextBox txtNordVPN;

	private Button btnSSH;

	private RadioButton rbSSH;

	private RadioButton rbExpressVPN;

	private RadioButton C0A51F90;

	private RadioButton AB356E83;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private Button btnCancel;

	private Button E0A1033A;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button2;

	private ComboBox F297C488;

	private ComboBox cbbColumnChrome;

	private Label label10;

	private Label label11;

	private Panel FC075CBE;

	private Label EE935139;

	private TextBox textBox1;

	private RadioButton radioButton5;

	private RadioButton A514F5A0;

	private RadioButton B8203D89;

	private RadioButton D403D403;

	private GroupBox FD22F009;

	private TextBox txtLinkToOtherBrowser;

	private Label label19;

	private NumericUpDown nudDelayOpenChromeTo;

	private Label label20;

	private GroupBox grCauHinhKhac;

	private Label EE333C12;

	private NumericUpDown B5301DBB;

	private Label CD8791AF;

	private NumericUpDown AAAC80AB;

	private NumericUpDown D4ADFB28;

	private ComboBox cbbSizeChrome;

	private Label label34;

	private Button AddFileAccount;

	private Panel plSizeChrome;

	private Label E12CFC11;

	private NumericUpDown CF813A26;

	private NumericUpDown ED9207B7;

	private CheckBox ED3D279F;

	private Label label35;

	private Panel E61FF030;

	private Panel plSapXepCuaSoChrome;

	private Panel plUsePortable;

	private Label A4A85536;

	private CheckBox B39104B5;

	private TextBox txtPathToPortableZip;

	private Panel B536B128;

	private RichTextBox txtListProxyVitech;

	private RadioButton CFBCAFA1;

	private RadioButton F506A61F;

	private Label label40;

	private Label EBBF2F8C;

	private Label CAA02B2A;

	private NumericUpDown nudLuongPerIPVitech;

	private Label A52E1B32;

	private TextBox txtApiVitech;

	private RadioButton rbVitech;

	private CheckBox F190F63D;

	private GroupBox groupBox3;

	private TabControl tabChangeIP;

	private TabPage tabDcom;

	private Panel BEA9001C;

	private Button D511079E;

	private TextBox D009C92E;

	private TextBox txtProfileNameDcom;

	private RadioButton rbDcomHilink;

	private Label label36;

	private RadioButton D70F2306;

	private TabPage F21A1896;

	private Panel plTinsoft;

	private CheckBox FE0F3907;

	private Panel plApiProxy;

	private Label lblCountApiProxy;

	private Label label28;

	private TextBox C32E2592;

	private Button button7;

	private Panel C407F398;

	private Label label1;

	private TextBox txtApiUser;

	private Button button3;

	private ComboBox cbbLocationTinsoft;

	private RadioButton A91F0B23;

	private RadioButton B9076107;

	private Label label7;

	private Label label8;

	private NumericUpDown B8212D2C;

	private TabPage tabXProxy;

	private Panel plXproxy;

	private TabPage tabObcProxy;

	private Panel plObcProxy;

	private Label label54;

	private RadioButton rbObcSock5Proxy;

	private RadioButton F62E182B;

	private Label label55;

	private RichTextBox E2B2E584;

	private Label FDAEAD8C;

	private Label label69;

	private NumericUpDown nudLuongPerIPObcProxy;

	private Label label71;

	private TextBox E2B51810;

	private TabPage D712360D;

	private Panel FF02F896;

	private RichTextBox A39E4405;

	private Label DC225194;

	private Label label44;

	private NumericUpDown F313873D;

	private TabPage tabProxyShopLike;

	private Panel plShopLike;

	private RichTextBox txtApiShopLike;

	private Label C38A97B5;

	private Label label48;

	private NumericUpDown nudLuongPerIPShopLike;

	private TabPage BD9C2992;

	private Panel E139C418;

	private CheckBox ckbWaitDoneAllTMProxy;

	private RichTextBox CAAE8196;

	private Label label24;

	private Button button8;

	private Label label25;

	private NumericUpDown AF1C9A1A;

	private TabPage A7961637;

	private Panel F119783A;

	private TabPage D0125C86;

	private Panel panel5;

	private RadioButton C20C5E2F;

	private RadioButton B50F8F2F;

	private Button button10;

	private RichTextBox BC278C3F;

	private Label label49;

	private Label E83B6223;

	private NumericUpDown B185D991;

	private Label label37;

	private NumericUpDown nudDelayCheckIP;

	private Label label38;

	private Panel FDB6E8B2;

	private Button FCAE6F85;

	private Label CDB6C69E;

	private NumericUpDown nudChangeIpCount;

	private Label C884DD9D;

	private CheckBox CE3B5195;

	private Label label53;

	private CheckBox ckbWaitDoneAllXproxy;

	private RichTextBox txtListProxy;

	private RadioButton rbSock5Proxy;

	private RadioButton rbHttpProxy;

	private Label BC12710C;

	private Label label17;

	private Label D2BDB785;

	private NumericUpDown E235F70D;

	private Label D827EF03;

	private TextBox txtServiceURLXProxy;

	private Panel panel3;

	private Panel plDelayCloseChrome;

	private Label label2;

	private CheckBox D70761BB;

	private ComboBox cbbTocDoGoVanBan;

	private Button btnDown;

	private Button D828DF03;

	private ComboBox A3259409;

	private Button metroButton2;

	private Button DD28E6A5;

	private Button metroButton4;

	private ComboBox cbbChangeIP;

	private ComboBox BAA2EC20;

	private ComboBox cbbTypeRunObcProxy;

	private ComboBox EF0B4A91;

	private Label label21;

	private Label label15;

	private Panel D28F098F;

	private Panel DD0EE58B;

	private CheckBox C00AFD1D;

	private Button button1;

	private Panel plDongBoMaxCare;

	private Label label22;

	private TextBox ED077C96;

	private CheckBox ckbDongBoMaxCare;

	private TabPage tabProxyFb;

	private RichTextBox txtApiKeyProxyFb;

	private Label BFBE55B5;

	private Label C00ECC0F;

	private NumericUpDown nudLuongPerIPProxyFb;

	private TabPage D39D6C05;

	private ComboBox cbbProxy;

	private RichTextBox AAAB429A;

	private Label B9A6449A;

	private Label label33;

	private Panel plTuyChonProxy;

	private ComboBox C13A4096;

	private Label label45;

	private Button EAB05F35;

	private Button button9;

	private TextBox txtTokenDonglaomail;

	private Label label56;

	private CheckBox ckbHideBrowser;

	private LinkLabel lblSelectBackupDB;

	private CheckBox C7260BB4;

	public fCauHinhChung()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	public fCauHinhChung(ref JSON_Settings jsonSettings)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		json = jsonSettings;
	}

	private void method_0()
	{
		Dictionary<string, string> dataSource = method_1();
		cbbLocationTinsoft.DataSource = new BindingSource(dataSource, null);
		cbbLocationTinsoft.ValueMember = "Key";
		cbbLocationTinsoft.DisplayMember = "Value";
	}

	public Dictionary<string, string> method_1()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		List<string> list = SetupFolder.GetListCountryTinsoft();
		for (int i = 0; i < list.Count; i++)
		{
			string[] array = list[i].Split('|');
			dictionary.Add(array[0], array[1]);
		}
		return dictionary;
	}

	private void BE0FF39B(object sender, EventArgs e)
	{
		Close();
	}

	private void F1B6B88A(object sender, EventArgs e)
	{
		DF1E2696();
		method_3();
		method_4();
		method_5();
		method_0();
		method_7();
		method_2();
		A395893A.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudInteractThread", 3);
		nudHideThread.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHideThread", 5);
		txbPathProfile.Text = SettingsTool.GetPathProfile();
		if (!Directory.Exists(txbPathProfile.Text) || txbPathProfile.Text.Trim() == "profiles")
		{
			txbPathProfile.Text = FileHelper.GetPathToCurrentFolder() + "\\profiles";
		}
		SettingsTool.GetSettings("configGeneral").GetJson("txbPathProfile", txbPathProfile.Text);
		E4A78182.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbShowImageInteract");
		C00AFD1D.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUseExtensionProxy");
		ckbDongBoMaxCare.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbDongBoMaxCare");
		ED077C96.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtPathMaxCare");
		string_0 = (ckbDongBoMaxCare.Checked ? ED077C96.Text : "");
		ckbHideBrowser.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbHideBrowser");
		ED3D279F.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbAddChromeIntoForm");
		ED9207B7.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudWidthChrome", 320);
		CF813A26.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudHeighChrome", 480);
		B5301DBB.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeFrom", 1);
		nudDelayOpenChromeTo.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayOpenChromeTo", 1);
		AAAC80AB.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCloseChromeFrom");
		D4ADFB28.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCloseChromeTo");
		D70761BB.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbDelayCloseChrome");
		cbbColumnChrome.Text = ((SettingsTool.GetSettings("configGeneral").GetValue("cbbColumnChrome") == "") ? "3" : SettingsTool.GetSettings("configGeneral").GetValue("cbbColumnChrome"));
		F297C488.Text = ((SettingsTool.GetSettings("configGeneral").GetValue("cbbRowChrome") == "") ? "2" : SettingsTool.GetSettings("configGeneral").GetValue("cbbRowChrome"));
		txtLinkToOtherBrowser.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkToOtherBrowser");
		B39104B5.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbUsePortable");
		txtPathToPortableZip.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtPathToPortableZip");
		cbbSizeChrome.SelectedValue = SettingsTool.GetSettings("configGeneral").GetValue("sizeChrome", "default").ToString();
		if (cbbSizeChrome.SelectedValue == null)
		{
			cbbSizeChrome.SelectedValue = "default";
		}
		cbbTocDoGoVanBan.SelectedIndex = SettingsTool.GetSettings("configGeneral").GetValueInt("tocDoGoVanBan");
		CE3B5195.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongCheckIP");
		nudChangeIpCount.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("ip_nudChangeIpCount", 1);
		nudDelayCheckIP.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudDelayCheckIP");
		cbbChangeIP.SelectedValue = SettingsTool.GetSettings("configGeneral").GetValue("ip_iTypeChangeIp");
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeDcom") == 0)
		{
			D70F2306.Checked = true;
		}
		else
		{
			rbDcomHilink.Checked = true;
		}
		txtProfileNameDcom.Text = SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom");
		D009C92E.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink", "http://192.168.1.1/html/home.html");
		txtNordVPN.Text = SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN");
		AB94A2A0.SelectedIndex = SettingsTool.GetSettings("configGeneral").GetValueInt("ip_cbbHostpot");
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeApiTinsoft") == 0)
		{
			B9076107.Checked = true;
		}
		else
		{
			A91F0B23.Checked = true;
		}
		txtApiUser.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiUser");
		C32E2592.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiProxy");
		cbbLocationTinsoft.SelectedValue = ((SettingsTool.GetSettings("configGeneral").GetValue("cbbLocationTinsoft") == "") ? "0" : SettingsTool.GetSettings("configGeneral").GetValue("cbbLocationTinsoft"));
		B8212D2C.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTinsoft");
		FE0F3907.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTinsoft");
		txtServiceURLXProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtServiceURLXProxy");
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeProxy") == 0)
		{
			rbHttpProxy.Checked = true;
		}
		else
		{
			rbSock5Proxy.Checked = true;
		}
		txtListProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtListProxy");
		E235F70D.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPXProxy");
		ckbWaitDoneAllXproxy.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllXproxy");
		BAA2EC20.SelectedIndex = SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunXproxy");
		CAAE8196.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyTMProxy");
		AF1C9A1A.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPTMProxy", 1);
		ckbWaitDoneAllTMProxy.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbWaitDoneAllTMProxy");
		A39E4405.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtListProxyv6");
		F313873D.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyv6");
		cbbProxy.SelectedValue = SettingsTool.GetSettings("configGeneral").GetValue("cbbProxy", "0");
		AAAB429A.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtProxy");
		C13A4096.SelectedValue = SettingsTool.GetSettings("configGeneral").GetValue("cbbProxyType", "0");
		txtApiShopLike.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiShopLike");
		nudLuongPerIPShopLike.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPShopLike");
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typeMin") == 0)
		{
			B50F8F2F.Checked = true;
		}
		else
		{
			C20C5E2F.Checked = true;
		}
		EF0B4A91.SelectedIndex = SettingsTool.GetSettings("configGeneral").GetValueInt("typeProxyMin");
		BC278C3F.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyMinProxy");
		B185D991.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPMinProxy");
		E2B51810.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy");
		E2B2E584.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtListObcProxy");
		nudLuongPerIPObcProxy.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPObcProxy", 1);
		cbbTypeRunObcProxy.SelectedIndex = SettingsTool.GetSettings("configGeneral").GetValueInt("typeRunObcProxy");
		txtApiKeyProxyFb.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyProxyFb");
		nudLuongPerIPProxyFb.Value = SettingsTool.GetSettings("configGeneral").GetValueInt("nudLuongPerIPProxyFb");
		C7260BB4.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBackupDB");
		string_1 = SettingsTool.GetSettings("configInteractGeneral").GetValue("txtBackupDBPath");
		Common.CreateFolder(string_1);
		if (!Directory.Exists(string_1))
		{
			string_1 = Environment.GetEnvironmentVariable("LocalAppData") + "\\database";
			Common.CreateFolder(string_1);
		}
		A3259409.SelectedIndex = SettingsTool.GetSettings("configGeneral").GetValueInt("typePhanBietMau");
		F190F63D.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbLuuTrangThai");
		txtTokenDonglaomail.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtTokenDonglaomail");
		A92E9118();
		D9A83383();
	}

	private void DF1E2696()
	{
		List<string> e6A5AC = new List<string> { "Chậm", "Bình thường", "Nhanh" };
		Common.F714B10E(cbbTocDoGoVanBan, e6A5AC);
	}

	private void method_2()
	{
		List<string> e6A5AC = new List<string> { "Đổi màu nền dòng", "Đổi màu chữ" };
		Common.F714B10E(A3259409, e6A5AC);
	}

	private void method_3()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Không đổi IP");
		dictionary.Add("2", "Dcom");
		dictionary.Add("1", "HMA");
		dictionary.Add("9", "Proxy");
		dictionary.Add("13", "https://minproxy.vn/");
		dictionary.Add("7", "https://tinsoftproxy.com/");
		dictionary.Add("8", "Xproxy, Mobi, Eager, S Proxy, OBC proxy");
		dictionary.Add("14", "OBC Proxy");
		dictionary.Add("11", "https://proxyv6.net/");
		dictionary.Add("12", "http://proxy.shoplike.vn/");
		dictionary.Add("15", "https://proxyfb.com/");
		dictionary.Add("10", "https://tmproxy.com/");
		Common.F5A0B829(cbbChangeIP, dictionary);
	}

	private void method_4()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Đã gán vào mỗi tài khoản");
		dictionary.Add("1", "Ngẫu nhiên trong danh sách");
		Common.F5A0B829(cbbProxy, dictionary);
	}

	private void method_5()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Http");
		dictionary.Add("1", "Sock5");
		Common.F5A0B829(C13A4096, dictionary);
	}

	private void E0A1033A_Click(object sender, EventArgs e)
	{
		try
		{
			SettingsTool.GetSettings("configGeneral").GetJson("nudInteractThread", A395893A.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudHideThread", nudHideThread.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("txbPathProfile", txbPathProfile.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbShowImageInteract", E4A78182.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbUseExtensionProxy", C00AFD1D.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbDongBoMaxCare", ckbDongBoMaxCare.Checked);
			string text = ED077C96.Text.Trim();
			if (ckbDongBoMaxCare.Checked && !File.Exists(text + "\\database\\db_maxcare.sqlite"))
			{
				MessageBoxHelper.Show("Đươ\u0300ng dâ\u0303n MaxCare không hơ\u0323p lê\u0323!", 3);
				return;
			}
			SettingsTool.GetSettings("configGeneral").GetJson("txtPathMaxCare", text);
			if (!ckbDongBoMaxCare.Checked)
			{
				text = "";
			}
			SettingsTool.GetSettings("configGeneral").GetJson("ckbHideBrowser", ckbHideBrowser.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbAddChromeIntoForm", ED3D279F.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("nudWidthChrome", ED9207B7.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudHeighChrome", CF813A26.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudDelayOpenChromeFrom", B5301DBB.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudDelayOpenChromeTo", nudDelayOpenChromeTo.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudDelayCloseChromeFrom", AAAC80AB.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudDelayCloseChromeTo", D4ADFB28.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbDelayCloseChrome", D70761BB.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("cbbColumnChrome", cbbColumnChrome.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("cbbRowChrome", F297C488.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("txtLinkToOtherBrowser", txtLinkToOtherBrowser.Text.Trim());
			SettingsTool.GetSettings("configGeneral").GetJson("ckbUsePortable", B39104B5.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("txtPathToPortableZip", txtPathToPortableZip.Text.Trim());
			if (cbbSizeChrome.Items.Count > 0 && cbbSizeChrome.SelectedValue.ToString() != "")
			{
				SettingsTool.GetSettings("configGeneral").GetJson("sizeChrome", cbbSizeChrome.SelectedValue.ToString());
			}
			SettingsTool.GetSettings("configGeneral").GetJson("tocDoGoVanBan", cbbTocDoGoVanBan.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbKhongCheckIP", CE3B5195.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("ip_nudChangeIpCount", nudChangeIpCount.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("nudDelayCheckIP", nudDelayCheckIP.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("ip_iTypeChangeIp", cbbChangeIP.SelectedValue);
			if (D70F2306.Checked)
			{
				SettingsTool.GetSettings("configGeneral").GetJson("typeDcom", 0);
			}
			else
			{
				SettingsTool.GetSettings("configGeneral").GetJson("typeDcom", 1);
			}
			SettingsTool.GetSettings("configGeneral").GetJson("txtUrlHilink", D009C92E.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("ip_txtProfileNameDcom", txtProfileNameDcom.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("ip_txtNordVPN", txtNordVPN.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("ip_cbbHostpot", AB94A2A0.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("typeApiTinsoft", (!B9076107.Checked) ? 1 : 0);
			SettingsTool.GetSettings("configGeneral").GetJson("txtApiUser", txtApiUser.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("txtApiProxy", C32E2592.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("cbbLocationTinsoft", cbbLocationTinsoft.SelectedValue);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPTinsoft", B8212D2C.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbWaitDoneAllTinsoft", FE0F3907.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("txtServiceURLXProxy", txtServiceURLXProxy.Text);
			int num = 0;
			if (rbSock5Proxy.Checked)
			{
				num = 1;
			}
			SettingsTool.GetSettings("configGeneral").GetJson("typeProxy", num);
			SettingsTool.GetSettings("configGeneral").GetJson("txtListProxy", txtListProxy.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPXProxy", E235F70D.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbWaitDoneAllXproxy", ckbWaitDoneAllXproxy.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("typeRunXproxy", BAA2EC20.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("txtApiKeyTMProxy", CAAE8196.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPTMProxy", AF1C9A1A.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbWaitDoneAllTMProxy", ckbWaitDoneAllTMProxy.Checked);
			SettingsTool.GetSettings("configGeneral").GetJson("txtListProxyv6", A39E4405.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPProxyv6", F313873D.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("cbbProxy", cbbProxy.SelectedValue);
			SettingsTool.GetSettings("configGeneral").GetJson("txtProxy", AAAB429A.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("cbbProxyType", C13A4096.SelectedValue);
			SettingsTool.GetSettings("configGeneral").GetJson("txtApiShopLike", txtApiShopLike.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPShopLike", nudLuongPerIPShopLike.Value);
			int num2 = 0;
			if (C20C5E2F.Checked)
			{
				num2 = 1;
			}
			SettingsTool.GetSettings("configGeneral").GetJson("typeMin", BAA2EC20.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("typeMin", num2);
			SettingsTool.GetSettings("configGeneral").GetJson("typeProxyMin", EF0B4A91.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("txtApiKeyMinProxy", BC278C3F.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPMinProxy", B185D991.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("txtLinkWebObcProxy", E2B51810.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("txtListObcProxy", E2B2E584.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPObcProxy", nudLuongPerIPObcProxy.Value);
			SettingsTool.GetSettings("configGeneral").GetJson("typeRunObcProxy", cbbTypeRunObcProxy.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("txtApiKeyProxyFb", txtApiKeyProxyFb.Text);
			SettingsTool.GetSettings("configGeneral").GetJson("nudLuongPerIPProxyFb", nudLuongPerIPProxyFb.Value);
			SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBackupDB", C7260BB4.Checked);
			SettingsTool.GetSettings("configInteractGeneral").GetJson("txtBackupDBPath", string_1);
			SettingsTool.GetSettings("configInteractGeneral").method_7();
			SettingsTool.GetSettings("configGeneral").GetJson("typePhanBietMau", A3259409.SelectedIndex);
			SettingsTool.GetSettings("configGeneral").GetJson("ckbLuuTrangThai", F190F63D.Checked);
			UpdateStatus.isSaveSettings = F190F63D.Checked;
			SettingsTool.GetSettings("configGeneral").GetJson("txtTokenDonglaomail", txtTokenDonglaomail.Text);
			SettingsTool.Save("configGeneral");
			if (MessageBoxHelper.ShowMessages("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
			if (string_0 != text)
			{
				Base.txtPathMaxCare = Base.GettxtPathMaxCare();
				json.GetJson("isChangePathDatabase", true);
			}
		}
		catch
		{
			MessageBoxHelper.Show("Lỗi!");
		}
	}

	private void FCAE6F85_Click(object sender, EventArgs e)
	{
		if (Convert.ToInt32(cbbChangeIP.SelectedValue) == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn loại đổi IP", 3);
			return;
		}
		int int_ = 0;
		if (rbDcomHilink.Checked)
		{
			int_ = 1;
		}
		if (Common.ChangeIP(Convert.ToInt32(cbbChangeIP.SelectedValue), int_, txtProfileNameDcom.Text.Trim(), D009C92E.Text.Trim(), AB94A2A0.SelectedIndex, txtNordVPN.Text.Trim()))
		{
			MessageBoxHelper.Show("Đổi IP thành công!");
		}
		else
		{
			MessageBoxHelper.Show("Đổi IP thất bại!", 2);
		}
	}

	private void btnSSH_Click(object sender, EventArgs e)
	{
		Process.Start("changeip\\ssh.txt");
	}

	private void B8203D89_CheckedChanged(object sender, EventArgs e)
	{
		FC075CBE.Enabled = C0A51F90.Checked;
	}

	private void A92E9118()
	{
		D394221D(null, null);
		method_6(null, null);
		ED3D279F_CheckedChanged(null, null);
		B39104B5_CheckedChanged(null, null);
		E321BCA3(null, null);
		D70F2306_CheckedChanged(null, null);
		D70761BB_CheckedChanged(null, null);
		D18772B9(null, null);
		C20C5E2F_CheckedChanged(null, null);
		C7260BB4_CheckedChanged(null, null);
	}

	private void CA845C28(object sender, EventArgs e)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			};
			Process process = Process.Start(startInfo);
			string text = process.StandardOutput.ReadToEnd();
			if (text.Split('\n').Length <= 3)
			{
				MessageBoxHelper.Show("Vui lòng kết nối Dcom trước!", 2);
				return;
			}
			txtProfileNameDcom.Text = text.Split('\n').ToList()[1];
			MessageBoxHelper.Show("Lấy tên cấu hình Dcom thành công!");
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "change ip dcom");
			MessageBoxHelper.Show("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if (((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control) && (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			plSizeChrome.Visible = false;
		}
	}

	private void D9A83383()
	{
		F237353C(null, null);
		txtListProxy_TextChanged(null, null);
		E7957584(null, null);
		D9983815(null, null);
		F1A61523(null, null);
		txtApiShopLike_TextChanged(null, null);
		CD98BA1C(null, null);
		AAAB429A_TextChanged(null, null);
		CB8EE694(null, null);
	}

	private void F237353C(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = C32E2592.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblCountApiProxy.Text = "(" + a2AB53A.Count + ")";
		}
		catch
		{
		}
	}

	private void D394221D(object sender, EventArgs e)
	{
		C407F398.Enabled = B9076107.Checked;
	}

	private void method_6(object sender, EventArgs e)
	{
		plApiProxy.Enabled = A91F0B23.Checked;
	}

	private void A1B2E79D(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbWaitDoneAllXproxy.Visible = true;
		}
	}

	private void C9916FB7(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbWaitDoneAllTMProxy.Visible = true;
		}
	}

	private void AddFileAccount_Click(object sender, EventArgs e)
	{
	}

	private void method_7()
	{
	}

	private void C412A8A4(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> a2AB53A = CAAE8196.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		foreach (string item in a2AB53A)
		{
			if (TMProxy.D72EC423(item))
			{
				list.Add(item);
			}
		}
		CAAE8196.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show("Không có proxy khả dụng!", 2);
		}
	}

	private void F1A61523(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = CAAE8196.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label24.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtListProxy.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label17.Text = string.Format(Language.GetValue("Nhập Proxy ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void CC862939(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			Process.Start(txbPathProfile.Text.Trim());
		}
	}

	private void ED3D279F_CheckedChanged(object sender, EventArgs e)
	{
		E61FF030.Enabled = ED3D279F.Checked;
		plSapXepCuaSoChrome.Enabled = !ED3D279F.Checked;
	}

	private void A7907C0C(object sender, PaintEventArgs e)
	{
	}

	private void B39104B5_CheckedChanged(object sender, EventArgs e)
	{
		A4A85536.Enabled = B39104B5.Checked;
		txtPathToPortableZip.Enabled = B39104B5.Checked;
	}

	private void panel3_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			plUsePortable.BringToFront();
		}
	}

	private void D70F2306_CheckedChanged(object sender, EventArgs e)
	{
		D511079E.Enabled = D70F2306.Checked;
		txtProfileNameDcom.Enabled = D70F2306.Checked;
	}

	private void E321BCA3(object sender, EventArgs e)
	{
		label36.Enabled = rbDcomHilink.Checked;
		D009C92E.Enabled = rbDcomHilink.Checked;
	}

	private void CD98BA1C(object sender, EventArgs e)
	{
		Common.F9202C12(A39E4405, DC225194);
	}

	private void txtListProxyVitech_TextChanged(object sender, EventArgs e)
	{
		List<string> a2AB53A = txtListProxyVitech.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		EBBF2F8C.Text = string.Format(Language.GetValue("Nhập Proxy ({0}):"), a2AB53A.Count.ToString());
	}

	private void txtApiShopLike_TextChanged(object sender, EventArgs e)
	{
		List<string> a2AB53A = txtApiShopLike.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		C38A97B5.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), a2AB53A.Count.ToString());
	}

	private void C20904A3_Paint(object sender, PaintEventArgs e)
	{
	}

	private void txbPathProfile_TextChanged(object sender, EventArgs e)
	{
	}

	private void D9983815(object sender, EventArgs e)
	{
		Common.F9202C12(BC278C3F, label49);
	}

	private void F68C7C86(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> a2AB53A = BC278C3F.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		int int_ = 0;
		if (C20C5E2F.Checked)
		{
			int_ = 1;
		}
		foreach (string item in a2AB53A)
		{
			if (MinProxy.BF3F4BB9(int_, item))
			{
				list.Add(item);
			}
		}
		BC278C3F.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show("Không có proxy khả dụng!", 2);
		}
	}

	private void E7957584(object sender, EventArgs e)
	{
		Common.F9202C12(E2B2E584, FDAEAD8C);
	}

	private void CF879D86(object sender, EventArgs e)
	{
		string a2911CA = txtApiUser.Text.Trim();
		List<string> list = TinsoftProxy.smethod_1(a2911CA);
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show("Không có proxy khả dụng!", 2);
		}
	}

	private void A91F0B23_CheckedChanged(object sender, EventArgs e)
	{
		plApiProxy.Enabled = A91F0B23.Checked;
	}

	private void button7_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> a2AB53A = C32E2592.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		foreach (string item in a2AB53A)
		{
			if (TinsoftProxy.smethod_0(item))
			{
				list.Add(item);
			}
		}
		C32E2592.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show("Không có proxy khả dụng!", 2);
		}
	}

	private void C20C5E2F_CheckedChanged(object sender, EventArgs e)
	{
		D28F098F.Enabled = C20C5E2F.Checked;
	}

	private void D70761BB_CheckedChanged(object sender, EventArgs e)
	{
		plDelayCloseChrome.Enabled = D70761BB.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			ckbHideBrowser.Visible = true;
			FD22F009.Height = 190;
		}
		else
		{
			FD22F009.Height = 167;
		}
	}

	private void D828DF03_Click(object sender, EventArgs e)
	{
		FD22F009.Height = 137;
	}

	private void BFB0AA82(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			grCauHinhChung.Height = 159;
		}
		else
		{
			grCauHinhChung.Height = 111;
		}
	}

	private void DD28E6A5_Click(object sender, EventArgs e)
	{
		grCauHinhChung.Height = 53;
	}

	private void D7183714(object sender, EventArgs e)
	{
		DD0EE58B.Visible = true;
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			EAB05F35.Visible = true;
		}
	}

	private void D22C5003(object sender, EventArgs e)
	{
		object selectedValue = cbbChangeIP.SelectedValue;
		object obj = selectedValue;
		if (obj is string text && text != null)
		{
			int length = text.Length;
			if (length == 1)
			{
				switch (text[0])
				{
				case '7':
					break;
				case '8':
					goto IL_0186;
				case '9':
					goto IL_0199;
				case '2':
					goto IL_01ac;
				default:
					goto IL_01bf;
				}
				tabChangeIP.SelectedTab = F21A1896;
				goto IL_01d0;
			}
			if (length == 2)
			{
				switch (text[1])
				{
				case '0':
					break;
				case '1':
					goto IL_008e;
				case '2':
					goto IL_00b4;
				case '3':
					goto IL_00da;
				case '4':
					goto IL_0100;
				case '5':
					goto IL_0126;
				default:
					goto IL_01bf;
				}
				if (text == "10")
				{
					tabChangeIP.SelectedTab = BD9C2992;
					goto IL_01d0;
				}
			}
		}
		goto IL_01bf;
		IL_00b4:
		if (!(text == "12"))
		{
			goto IL_01bf;
		}
		tabChangeIP.SelectedTab = tabProxyShopLike;
		goto IL_01d0;
		IL_01ac:
		tabChangeIP.SelectedTab = tabDcom;
		goto IL_01d0;
		IL_008e:
		if (!(text == "11"))
		{
			goto IL_01bf;
		}
		tabChangeIP.SelectedTab = D712360D;
		goto IL_01d0;
		IL_01bf:
		tabChangeIP.SelectedTab = A7961637;
		goto IL_01d0;
		IL_0126:
		if (!(text == "15"))
		{
			goto IL_01bf;
		}
		tabChangeIP.SelectedTab = tabProxyFb;
		goto IL_01d0;
		IL_0199:
		tabChangeIP.SelectedTab = D39D6C05;
		goto IL_01d0;
		IL_0100:
		if (!(text == "14"))
		{
			goto IL_01bf;
		}
		tabChangeIP.SelectedTab = tabObcProxy;
		goto IL_01d0;
		IL_0186:
		tabChangeIP.SelectedTab = tabXProxy;
		goto IL_01d0;
		IL_00da:
		if (!(text == "13"))
		{
			goto IL_01bf;
		}
		tabChangeIP.SelectedTab = D0125C86;
		goto IL_01d0;
		IL_01d0:
		FDB6E8B2.Enabled = cbbChangeIP.SelectedValue.ToString() == "1" || cbbChangeIP.SelectedValue.ToString() == "2";
	}

	private void FCB19E00(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> a2AB53A = A39E4405.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		foreach (string item in a2AB53A)
		{
			if (Proxyv6.smethod_0(item))
			{
				list.Add(item);
			}
		}
		A39E4405.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show("Không có proxy khả dụng!", 2);
		}
	}

	private void D18772B9(object sender, EventArgs e)
	{
		plDongBoMaxCare.Enabled = ckbDongBoMaxCare.Checked;
	}

	private void cbbProxy_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (cbbProxy.SelectedValue != null)
			{
				plTuyChonProxy.Enabled = cbbProxy.SelectedValue.ToString() == "1";
			}
		}
		catch (Exception)
		{
		}
	}

	private void AAAB429A_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(AAAB429A, label33);
	}

	private void CB8EE694(object sender, EventArgs e)
	{
		Common.F9202C12(txtApiKeyProxyFb, BFBE55B5);
	}

	private void B4104C3C(object sender, EventArgs e)
	{
		Common.ShowForm(new fCauHinhDomainGenerator());
	}

	private void button9_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages("Bạn có muốn cập nhật ChromeDriver không?") != DialogResult.Yes)
		{
			return;
		}
		try
		{
			Common.KillProcess("chromedriver");
			string text = Common.smethod_65();
			if (!(text == ""))
			{
				string text2 = "";
				string input = new RequestXNet("", "", "", 0).RequestGet("https://api.nuget.org/v3-flatcontainer/Selenium.WebDriver.ChromeDriver/index.json");
				foreach (Match item in Regex.Matches(input, "\"(\\d+\\.0\\.\\d+\\.\\d+)\""))
				{
					if (item.Groups[1].Value == text || item.Groups[1].Value.StartsWith(text.Split('.')[0]))
					{
						text2 = item.Groups[1].Value;
						break;
					}
				}
				if (!(text2 == ""))
				{
					Common.DeleteFilex(FileHelper.GetPathToCurrentFolder() + "\\chromedriver.exe");
					string text3 = "https://api.nuget.org/v3-flatcontainer/Selenium.WebDriver.ChromeDriver/" + text2 + "/selenium.webdriver.chromedriver." + text2 + ".nupkg";
					Common.DownloadFile(text3);
					MessageBoxHelper.Show("Cập nhật ChromeDriver thành công!");
					return;
				}
			}
		}
		catch
		{
		}
		MessageBoxHelper.Show("Cập nhật ChromeDriver thất bại!", 2);
	}

	private void lblSelectBackupDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = Common.SelectFolder(string_1);
		if (text != "")
		{
			string_1 = text;
		}
	}

	private void C7260BB4_CheckedChanged(object sender, EventArgs e)
	{
		lblSelectBackupDB.Enabled = C7260BB4.Checked;
	}

	protected override void Dispose(bool B0357608)
	{
		if (B0357608 && A4388412 != null)
		{
			A4388412.Dispose();
		}
		base.Dispose(B0357608);
	}

	private void InitializeComponent()
	{
		A4388412 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fCauHinhChung));
		bunifuCards1 = new BunifuCards();
		label3 = new Label();
		A395893A = new NumericUpDown();
		label4 = new Label();
		label5 = new Label();
		nudHideThread = new NumericUpDown();
		label6 = new Label();
		label9 = new Label();
		txbPathProfile = new TextBox();
		C20904A3 = new Panel();
		grCauHinhChung = new GroupBox();
		plDongBoMaxCare = new Panel();
		label22 = new Label();
		ED077C96 = new TextBox();
		ckbDongBoMaxCare = new CheckBox();
		metroButton2 = new Button();
		DD28E6A5 = new Button();
		FD22F009 = new GroupBox();
		button9 = new Button();
		plSizeChrome = new Panel();
		nudDelayOpenChromeTo = new NumericUpDown();
		B5301DBB = new NumericUpDown();
		label20 = new Label();
		plDelayCloseChrome = new Panel();
		D4ADFB28 = new NumericUpDown();
		AAAC80AB = new NumericUpDown();
		label2 = new Label();
		CD8791AF = new Label();
		D70761BB = new CheckBox();
		btnDown = new Button();
		D828DF03 = new Button();
		cbbTocDoGoVanBan = new ComboBox();
		E12CFC11 = new Label();
		plSapXepCuaSoChrome = new Panel();
		cbbColumnChrome = new ComboBox();
		label10 = new Label();
		F297C488 = new ComboBox();
		label11 = new Label();
		E61FF030 = new Panel();
		ED9207B7 = new NumericUpDown();
		CF813A26 = new NumericUpDown();
		label35 = new Label();
		AddFileAccount = new Button();
		C00AFD1D = new CheckBox();
		ckbHideBrowser = new CheckBox();
		E4A78182 = new CheckBox();
		ED3D279F = new CheckBox();
		cbbSizeChrome = new ComboBox();
		label34 = new Label();
		panel3 = new Panel();
		label19 = new Label();
		txtLinkToOtherBrowser = new TextBox();
		plUsePortable = new Panel();
		txtPathToPortableZip = new TextBox();
		A4A85536 = new Label();
		B39104B5 = new CheckBox();
		grCauHinhKhac = new GroupBox();
		metroButton4 = new Button();
		lblSelectBackupDB = new LinkLabel();
		DD0EE58B = new Panel();
		EAB05F35 = new Button();
		label56 = new Label();
		txtTokenDonglaomail = new TextBox();
		C7260BB4 = new CheckBox();
		F190F63D = new CheckBox();
		A3259409 = new ComboBox();
		EE333C12 = new Label();
		B536B128 = new Panel();
		txtListProxyVitech = new RichTextBox();
		CFBCAFA1 = new RadioButton();
		F506A61F = new RadioButton();
		label40 = new Label();
		EBBF2F8C = new Label();
		CAA02B2A = new Label();
		nudLuongPerIPVitech = new NumericUpDown();
		A52E1B32 = new Label();
		txtApiVitech = new TextBox();
		AB94A2A0 = new ComboBox();
		rbVitech = new RadioButton();
		bunifuCards2 = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		FC075CBE = new Panel();
		EE935139 = new Label();
		textBox1 = new TextBox();
		E0A1033A = new Button();
		plNordVPN = new Panel();
		A0B2E523 = new Label();
		txtNordVPN = new TextBox();
		btnSSH = new Button();
		A514F5A0 = new RadioButton();
		AB356E83 = new RadioButton();
		radioButton5 = new RadioButton();
		C0A51F90 = new RadioButton();
		D403D403 = new RadioButton();
		rbSSH = new RadioButton();
		B8203D89 = new RadioButton();
		rbExpressVPN = new RadioButton();
		groupBox3 = new GroupBox();
		tabChangeIP = new TabControl();
		tabDcom = new TabPage();
		BEA9001C = new Panel();
		D511079E = new Button();
		D009C92E = new TextBox();
		txtProfileNameDcom = new TextBox();
		rbDcomHilink = new RadioButton();
		label36 = new Label();
		D70F2306 = new RadioButton();
		F21A1896 = new TabPage();
		plTinsoft = new Panel();
		FE0F3907 = new CheckBox();
		plApiProxy = new Panel();
		lblCountApiProxy = new Label();
		label28 = new Label();
		C32E2592 = new TextBox();
		button7 = new Button();
		C407F398 = new Panel();
		label1 = new Label();
		txtApiUser = new TextBox();
		button3 = new Button();
		cbbLocationTinsoft = new ComboBox();
		A91F0B23 = new RadioButton();
		B9076107 = new RadioButton();
		label7 = new Label();
		label8 = new Label();
		B8212D2C = new NumericUpDown();
		tabXProxy = new TabPage();
		plXproxy = new Panel();
		label53 = new Label();
		ckbWaitDoneAllXproxy = new CheckBox();
		BAA2EC20 = new ComboBox();
		txtListProxy = new RichTextBox();
		rbSock5Proxy = new RadioButton();
		rbHttpProxy = new RadioButton();
		BC12710C = new Label();
		label17 = new Label();
		D2BDB785 = new Label();
		E235F70D = new NumericUpDown();
		D827EF03 = new Label();
		txtServiceURLXProxy = new TextBox();
		tabObcProxy = new TabPage();
		plObcProxy = new Panel();
		cbbTypeRunObcProxy = new ComboBox();
		label54 = new Label();
		rbObcSock5Proxy = new RadioButton();
		F62E182B = new RadioButton();
		label55 = new Label();
		E2B2E584 = new RichTextBox();
		FDAEAD8C = new Label();
		label69 = new Label();
		nudLuongPerIPObcProxy = new NumericUpDown();
		label71 = new Label();
		E2B51810 = new TextBox();
		D712360D = new TabPage();
		FF02F896 = new Panel();
		button1 = new Button();
		A39E4405 = new RichTextBox();
		DC225194 = new Label();
		label44 = new Label();
		F313873D = new NumericUpDown();
		tabProxyShopLike = new TabPage();
		plShopLike = new Panel();
		txtApiShopLike = new RichTextBox();
		C38A97B5 = new Label();
		label48 = new Label();
		nudLuongPerIPShopLike = new NumericUpDown();
		BD9C2992 = new TabPage();
		E139C418 = new Panel();
		ckbWaitDoneAllTMProxy = new CheckBox();
		CAAE8196 = new RichTextBox();
		label24 = new Label();
		button8 = new Button();
		label25 = new Label();
		AF1C9A1A = new NumericUpDown();
		A7961637 = new TabPage();
		F119783A = new Panel();
		D0125C86 = new TabPage();
		panel5 = new Panel();
		C20C5E2F = new RadioButton();
		B50F8F2F = new RadioButton();
		button10 = new Button();
		BC278C3F = new RichTextBox();
		label49 = new Label();
		E83B6223 = new Label();
		D28F098F = new Panel();
		EF0B4A91 = new ComboBox();
		label21 = new Label();
		B185D991 = new NumericUpDown();
		tabProxyFb = new TabPage();
		txtApiKeyProxyFb = new RichTextBox();
		BFBE55B5 = new Label();
		C00ECC0F = new Label();
		nudLuongPerIPProxyFb = new NumericUpDown();
		D39D6C05 = new TabPage();
		plTuyChonProxy = new Panel();
		C13A4096 = new ComboBox();
		label45 = new Label();
		label33 = new Label();
		AAAB429A = new RichTextBox();
		cbbProxy = new ComboBox();
		B9A6449A = new Label();
		cbbChangeIP = new ComboBox();
		label15 = new Label();
		label37 = new Label();
		nudDelayCheckIP = new NumericUpDown();
		label38 = new Label();
		FDB6E8B2 = new Panel();
		FCAE6F85 = new Button();
		CDB6C69E = new Label();
		nudChangeIpCount = new NumericUpDown();
		C884DD9D = new Label();
		CE3B5195 = new CheckBox();
		bunifuDragControl_0 = new BunifuDragControl(A4388412);
		toolTip_0 = new ToolTip(A4388412);
		((ISupportInitialize)A395893A).BeginInit();
		((ISupportInitialize)nudHideThread).BeginInit();
		C20904A3.SuspendLayout();
		grCauHinhChung.SuspendLayout();
		plDongBoMaxCare.SuspendLayout();
		FD22F009.SuspendLayout();
		plSizeChrome.SuspendLayout();
		((ISupportInitialize)nudDelayOpenChromeTo).BeginInit();
		((ISupportInitialize)B5301DBB).BeginInit();
		plDelayCloseChrome.SuspendLayout();
		((ISupportInitialize)D4ADFB28).BeginInit();
		((ISupportInitialize)AAAC80AB).BeginInit();
		plSapXepCuaSoChrome.SuspendLayout();
		E61FF030.SuspendLayout();
		((ISupportInitialize)ED9207B7).BeginInit();
		((ISupportInitialize)CF813A26).BeginInit();
		panel3.SuspendLayout();
		plUsePortable.SuspendLayout();
		grCauHinhKhac.SuspendLayout();
		DD0EE58B.SuspendLayout();
		B536B128.SuspendLayout();
		((ISupportInitialize)nudLuongPerIPVitech).BeginInit();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		FC075CBE.SuspendLayout();
		plNordVPN.SuspendLayout();
		groupBox3.SuspendLayout();
		tabChangeIP.SuspendLayout();
		tabDcom.SuspendLayout();
		BEA9001C.SuspendLayout();
		F21A1896.SuspendLayout();
		plTinsoft.SuspendLayout();
		plApiProxy.SuspendLayout();
		C407F398.SuspendLayout();
		((ISupportInitialize)B8212D2C).BeginInit();
		tabXProxy.SuspendLayout();
		plXproxy.SuspendLayout();
		((ISupportInitialize)E235F70D).BeginInit();
		tabObcProxy.SuspendLayout();
		plObcProxy.SuspendLayout();
		((ISupportInitialize)nudLuongPerIPObcProxy).BeginInit();
		D712360D.SuspendLayout();
		FF02F896.SuspendLayout();
		((ISupportInitialize)F313873D).BeginInit();
		tabProxyShopLike.SuspendLayout();
		plShopLike.SuspendLayout();
		((ISupportInitialize)nudLuongPerIPShopLike).BeginInit();
		BD9C2992.SuspendLayout();
		E139C418.SuspendLayout();
		((ISupportInitialize)AF1C9A1A).BeginInit();
		A7961637.SuspendLayout();
		D0125C86.SuspendLayout();
		panel5.SuspendLayout();
		D28F098F.SuspendLayout();
		((ISupportInitialize)B185D991).BeginInit();
		tabProxyFb.SuspendLayout();
		((ISupportInitialize)nudLuongPerIPProxyFb).BeginInit();
		D39D6C05.SuspendLayout();
		plTuyChonProxy.SuspendLayout();
		((ISupportInitialize)nudDelayCheckIP).BeginInit();
		FDB6E8B2.SuspendLayout();
		((ISupportInitialize)nudChangeIpCount).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(476, 38);
		bunifuCards1.TabIndex = 12;
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(32, 26);
		label3.Name = "label3";
		label3.Size = new Size(111, 16);
		label3.TabIndex = 23;
		label3.Text = "Số luồng Chrome:";
		A395893A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A395893A.Location = new Point(173, 24);
		A395893A.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		A395893A.Name = "nudInteractThread";
		A395893A.Size = new Size(89, 23);
		A395893A.TabIndex = 24;
		label4.AutoSize = true;
		label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(265, 26);
		label4.Name = "label4";
		label4.Size = new Size(41, 16);
		label4.TabIndex = 25;
		label4.Text = "Luồng";
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label5.Location = new Point(265, 55);
		label5.Name = "label5";
		label5.Size = new Size(41, 16);
		label5.TabIndex = 28;
		label5.Text = "Luồng";
		nudHideThread.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nudHideThread.Location = new Point(173, 53);
		nudHideThread.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		nudHideThread.Name = "nudHideThread";
		nudHideThread.Size = new Size(89, 23);
		nudHideThread.TabIndex = 27;
		label6.AutoSize = true;
		label6.Cursor = Cursors.Help;
		label6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label6.Location = new Point(32, 55);
		label6.Name = "label6";
		label6.Size = new Size(125, 16);
		label6.TabIndex = 26;
		label6.Text = "Số luồng Check info:";
		toolTip_0.SetToolTip(label6, "La\u0300 sô\u0301 luô\u0300ng khi cha\u0323y ca\u0301c chư\u0301c năng không liên quan gi\u0300 đê\u0301n tri\u0300nh duyê\u0323t.\r\nVi\u0301 du\u0323 như: Check wall, Check Avatar,...\r\n(Khuyê\u0301n ca\u0301o nên đê\u0309 10 luô\u0300ng)");
		label9.AutoSize = true;
		label9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.Location = new Point(32, 85);
		label9.Name = "label9";
		label9.Size = new Size(94, 16);
		label9.TabIndex = 33;
		label9.Text = "Folder profiles:";
		txbPathProfile.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txbPathProfile.Location = new Point(173, 82);
		txbPathProfile.Name = "txbPathProfile";
		txbPathProfile.Size = new Size(386, 23);
		txbPathProfile.TabIndex = 32;
		txbPathProfile.Click += CC862939;
		txbPathProfile.TextChanged += txbPathProfile_TextChanged;
		C20904A3.BorderStyle = BorderStyle.FixedSingle;
		C20904A3.Controls.Add(grCauHinhChung);
		C20904A3.Controls.Add(FD22F009);
		C20904A3.Controls.Add(grCauHinhKhac);
		C20904A3.Controls.Add(B536B128);
		C20904A3.Controls.Add(AB94A2A0);
		C20904A3.Controls.Add(rbVitech);
		C20904A3.Controls.Add(bunifuCards2);
		C20904A3.Controls.Add(btnCancel);
		C20904A3.Controls.Add(FC075CBE);
		C20904A3.Controls.Add(E0A1033A);
		C20904A3.Controls.Add(plNordVPN);
		C20904A3.Controls.Add(btnSSH);
		C20904A3.Controls.Add(A514F5A0);
		C20904A3.Controls.Add(AB356E83);
		C20904A3.Controls.Add(radioButton5);
		C20904A3.Controls.Add(C0A51F90);
		C20904A3.Controls.Add(D403D403);
		C20904A3.Controls.Add(rbSSH);
		C20904A3.Controls.Add(B8203D89);
		C20904A3.Controls.Add(rbExpressVPN);
		C20904A3.Controls.Add(groupBox3);
		C20904A3.Dock = DockStyle.Fill;
		C20904A3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C20904A3.Location = new Point(0, 0);
		C20904A3.Name = "panel1";
		C20904A3.Size = new Size(1059, 382);
		C20904A3.TabIndex = 37;
		C20904A3.Paint += C20904A3_Paint;
		grCauHinhChung.Controls.Add(plDongBoMaxCare);
		grCauHinhChung.Controls.Add(ckbDongBoMaxCare);
		grCauHinhChung.Controls.Add(metroButton2);
		grCauHinhChung.Controls.Add(label5);
		grCauHinhChung.Controls.Add(DD28E6A5);
		grCauHinhChung.Controls.Add(nudHideThread);
		grCauHinhChung.Controls.Add(label6);
		grCauHinhChung.Controls.Add(label9);
		grCauHinhChung.Controls.Add(txbPathProfile);
		grCauHinhChung.Controls.Add(label4);
		grCauHinhChung.Controls.Add(A395893A);
		grCauHinhChung.Controls.Add(label3);
		grCauHinhChung.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		grCauHinhChung.Location = new Point(7, 39);
		grCauHinhChung.Name = "grCauHinhChung";
		grCauHinhChung.Size = new Size(568, 53);
		grCauHinhChung.TabIndex = 38;
		grCauHinhChung.TabStop = false;
		grCauHinhChung.Text = "Cấu hình chung";
		plDongBoMaxCare.Controls.Add(label22);
		plDongBoMaxCare.Controls.Add(ED077C96);
		plDongBoMaxCare.Location = new Point(48, 129);
		plDongBoMaxCare.Name = "plDongBoMaxCare";
		plDongBoMaxCare.Size = new Size(517, 23);
		plDongBoMaxCare.TabIndex = 168;
		label22.AutoSize = true;
		label22.Location = new Point(3, 3);
		label22.Name = "label22";
		label22.Size = new Size(102, 16);
		label22.TabIndex = 158;
		label22.Text = "Folder MaxCare:";
		ED077C96.Location = new Point(125, 0);
		ED077C96.Name = "txtPathMaxCare";
		ED077C96.Size = new Size(386, 23);
		ED077C96.TabIndex = 159;
		ckbDongBoMaxCare.AutoSize = true;
		ckbDongBoMaxCare.Cursor = Cursors.Hand;
		ckbDongBoMaxCare.Location = new Point(35, 108);
		ckbDongBoMaxCare.Name = "ckbDongBoMaxCare";
		ckbDongBoMaxCare.Size = new Size(191, 20);
		ckbDongBoMaxCare.TabIndex = 167;
		ckbDongBoMaxCare.Text = "Đô\u0300ng bô\u0323 dư\u0303 liê\u0323u vơ\u0301i MaxCare";
		ckbDongBoMaxCare.UseVisualStyleBackColor = true;
		ckbDongBoMaxCare.CheckedChanged += D18772B9;
		metroButton2.BackgroundImage = Resources.Bitmap_83;
		metroButton2.Cursor = Cursors.Hand;
		metroButton2.Location = new Point(512, 8);
		metroButton2.Name = "metroButton2";
		metroButton2.Size = new Size(25, 25);
		metroButton2.TabIndex = 158;
		metroButton2.Click += BFB0AA82;
		DD28E6A5.BackgroundImage = Resources.E536C319;
		DD28E6A5.Cursor = Cursors.Hand;
		DD28E6A5.Location = new Point(543, 8);
		DD28E6A5.Name = "metroButton1";
		DD28E6A5.Size = new Size(25, 25);
		DD28E6A5.TabIndex = 159;
		DD28E6A5.Click += DD28E6A5_Click;
		FD22F009.Controls.Add(button9);
		FD22F009.Controls.Add(plSizeChrome);
		FD22F009.Controls.Add(btnDown);
		FD22F009.Controls.Add(D828DF03);
		FD22F009.Controls.Add(cbbTocDoGoVanBan);
		FD22F009.Controls.Add(E12CFC11);
		FD22F009.Controls.Add(plSapXepCuaSoChrome);
		FD22F009.Controls.Add(E61FF030);
		FD22F009.Controls.Add(AddFileAccount);
		FD22F009.Controls.Add(C00AFD1D);
		FD22F009.Controls.Add(ckbHideBrowser);
		FD22F009.Controls.Add(E4A78182);
		FD22F009.Controls.Add(ED3D279F);
		FD22F009.Controls.Add(cbbSizeChrome);
		FD22F009.Controls.Add(label34);
		FD22F009.Controls.Add(panel3);
		FD22F009.Controls.Add(plUsePortable);
		FD22F009.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FD22F009.Location = new Point(7, 98);
		FD22F009.Name = "grCauHinhChrome";
		FD22F009.Size = new Size(568, 137);
		FD22F009.TabIndex = 38;
		FD22F009.TabStop = false;
		FD22F009.Text = "Cấu hình chrome";
		button9.Cursor = Cursors.Hand;
		button9.Location = new Point(295, 105);
		button9.Name = "button9";
		button9.Size = new Size(141, 26);
		button9.TabIndex = 160;
		button9.Text = "Update Chromedriver";
		button9.UseVisualStyleBackColor = true;
		button9.Click += button9_Click;
		plSizeChrome.Controls.Add(nudDelayOpenChromeTo);
		plSizeChrome.Controls.Add(B5301DBB);
		plSizeChrome.Controls.Add(label20);
		plSizeChrome.Controls.Add(plDelayCloseChrome);
		plSizeChrome.Controls.Add(CD8791AF);
		plSizeChrome.Controls.Add(D70761BB);
		plSizeChrome.Location = new Point(31, 77);
		plSizeChrome.Name = "plSizeChrome";
		plSizeChrome.Size = new Size(535, 25);
		plSizeChrome.TabIndex = 155;
		nudDelayOpenChromeTo.Location = new Point(204, 1);
		nudDelayOpenChromeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayOpenChromeTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudDelayOpenChromeTo.Name = "nudDelayOpenChromeTo";
		nudDelayOpenChromeTo.Size = new Size(41, 23);
		nudDelayOpenChromeTo.TabIndex = 151;
		nudDelayOpenChromeTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		B5301DBB.Location = new Point(142, 1);
		B5301DBB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B5301DBB.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		B5301DBB.Name = "nudDelayOpenChromeFrom";
		B5301DBB.Size = new Size(41, 23);
		B5301DBB.TabIndex = 151;
		B5301DBB.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label20.AutoSize = true;
		label20.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label20.Location = new Point(-3, 3);
		label20.Name = "label20";
		label20.Size = new Size(144, 16);
		label20.TabIndex = 33;
		label20.Text = "Delay Open chrome (s):";
		plDelayCloseChrome.Controls.Add(D4ADFB28);
		plDelayCloseChrome.Controls.Add(AAAC80AB);
		plDelayCloseChrome.Controls.Add(label2);
		plDelayCloseChrome.Location = new Point(425, 0);
		plDelayCloseChrome.Name = "plDelayCloseChrome";
		plDelayCloseChrome.Size = new Size(111, 24);
		plDelayCloseChrome.TabIndex = 159;
		D4ADFB28.Location = new Point(66, 1);
		D4ADFB28.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D4ADFB28.Name = "nudDelayCloseChromeTo";
		D4ADFB28.Size = new Size(43, 23);
		D4ADFB28.TabIndex = 151;
		AAAC80AB.Location = new Point(1, 1);
		AAAC80AB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AAAC80AB.Name = "nudDelayCloseChromeFrom";
		AAAC80AB.Size = new Size(44, 23);
		AAAC80AB.TabIndex = 151;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label2.Location = new Point(44, 4);
		label2.Name = "label2";
		label2.Size = new Size(23, 16);
		label2.TabIndex = 33;
		label2.Text = ">";
		label2.TextAlign = ContentAlignment.MiddleCenter;
		CD8791AF.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CD8791AF.Location = new Point(182, 4);
		CD8791AF.Name = "label29";
		CD8791AF.Size = new Size(23, 16);
		CD8791AF.TabIndex = 33;
		CD8791AF.Text = ">";
		CD8791AF.TextAlign = ContentAlignment.MiddleCenter;
		D70761BB.AutoSize = true;
		D70761BB.Cursor = Cursors.Hand;
		D70761BB.Location = new Point(264, 2);
		D70761BB.Name = "ckbDelayCloseChrome";
		D70761BB.Size = new Size(166, 20);
		D70761BB.TabIndex = 158;
		D70761BB.Text = "Delay Close Chrome (s):";
		D70761BB.UseVisualStyleBackColor = true;
		D70761BB.CheckedChanged += D70761BB_CheckedChanged;
		btnDown.BackgroundImage = Resources.Bitmap_83;
		btnDown.Cursor = Cursors.Hand;
		btnDown.Location = new Point(512, 8);
		btnDown.Name = "btnDown";
		btnDown.Size = new Size(25, 25);
		btnDown.TabIndex = 158;
		btnDown.Click += btnDown_Click;
		D828DF03.BackgroundImage = Resources.E536C319;
		D828DF03.Cursor = Cursors.Hand;
		D828DF03.Location = new Point(543, 8);
		D828DF03.Name = "btnUp";
		D828DF03.Size = new Size(25, 25);
		D828DF03.TabIndex = 159;
		D828DF03.Click += D828DF03_Click;
		cbbTocDoGoVanBan.Cursor = Cursors.Hand;
		cbbTocDoGoVanBan.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTocDoGoVanBan.FormattingEnabled = true;
		cbbTocDoGoVanBan.Items.AddRange(new object[3] { "Chậm", "Bình thường", "Nhanh" });
		cbbTocDoGoVanBan.Location = new Point(173, 107);
		cbbTocDoGoVanBan.Name = "cbbTocDoGoVanBan";
		cbbTocDoGoVanBan.Size = new Size(102, 24);
		cbbTocDoGoVanBan.TabIndex = 34;
		E12CFC11.AutoSize = true;
		E12CFC11.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E12CFC11.Location = new Point(28, 110);
		E12CFC11.Name = "label30";
		E12CFC11.Size = new Size(118, 16);
		E12CFC11.TabIndex = 33;
		E12CFC11.Text = "Tốc độ gõ văn bản:";
		plSapXepCuaSoChrome.Controls.Add(cbbColumnChrome);
		plSapXepCuaSoChrome.Controls.Add(label10);
		plSapXepCuaSoChrome.Controls.Add(F297C488);
		plSapXepCuaSoChrome.Controls.Add(label11);
		plSapXepCuaSoChrome.Location = new Point(25, 44);
		plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
		plSapXepCuaSoChrome.Size = new Size(251, 29);
		plSapXepCuaSoChrome.TabIndex = 157;
		cbbColumnChrome.Cursor = Cursors.Hand;
		cbbColumnChrome.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbColumnChrome.FormattingEnabled = true;
		cbbColumnChrome.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		cbbColumnChrome.Location = new Point(148, 2);
		cbbColumnChrome.Name = "cbbColumnChrome";
		cbbColumnChrome.Size = new Size(40, 24);
		cbbColumnChrome.TabIndex = 145;
		label10.AutoSize = true;
		label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label10.Location = new Point(3, 5);
		label10.Name = "label10";
		label10.Size = new Size(147, 16);
		label10.TabIndex = 33;
		label10.Text = "Sắp xếp cửa sổ chrome:";
		F297C488.Cursor = Cursors.Hand;
		F297C488.DropDownStyle = ComboBoxStyle.DropDownList;
		F297C488.FormattingEnabled = true;
		F297C488.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		F297C488.Location = new Point(210, 2);
		F297C488.Name = "cbbRowChrome";
		F297C488.Size = new Size(40, 24);
		F297C488.TabIndex = 145;
		label11.AutoSize = true;
		label11.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label11.Location = new Point(188, 2);
		label11.Name = "label11";
		label11.Size = new Size(23, 23);
		label11.TabIndex = 33;
		label11.Text = "X";
		E61FF030.Controls.Add(ED9207B7);
		E61FF030.Controls.Add(CF813A26);
		E61FF030.Controls.Add(label35);
		E61FF030.Location = new Point(456, 45);
		E61FF030.Name = "plAddChromeVaoFormView";
		E61FF030.Size = new Size(110, 27);
		E61FF030.TabIndex = 156;
		ED9207B7.Location = new Point(1, 2);
		ED9207B7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		ED9207B7.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		ED9207B7.Name = "nudWidthChrome";
		ED9207B7.Size = new Size(43, 23);
		ED9207B7.TabIndex = 151;
		ED9207B7.Value = new decimal(new int[4] { 320, 0, 0, 0 });
		CF813A26.Location = new Point(66, 2);
		CF813A26.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CF813A26.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		CF813A26.Name = "nudHeighChrome";
		CF813A26.Size = new Size(43, 23);
		CF813A26.TabIndex = 151;
		CF813A26.Value = new decimal(new int[4] { 480, 0, 0, 0 });
		label35.AutoSize = true;
		label35.Font = new Font("Tahoma", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label35.Location = new Point(44, 2);
		label35.Name = "label35";
		label35.Size = new Size(23, 23);
		label35.TabIndex = 33;
		label35.Text = "X";
		AddFileAccount.BackgroundImage = Resources.Bitmap_111;
		AddFileAccount.BackgroundImageLayout = ImageLayout.None;
		AddFileAccount.Cursor = Cursors.Hand;
		AddFileAccount.Location = new Point(414, 77);
		AddFileAccount.Name = "AddFileAccount";
		AddFileAccount.Size = new Size(25, 25);
		AddFileAccount.TabIndex = 154;
		AddFileAccount.Click += AddFileAccount_Click;
		C00AFD1D.AutoSize = true;
		C00AFD1D.Cursor = Cursors.Hand;
		C00AFD1D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C00AFD1D.Location = new Point(32, 169);
		C00AFD1D.Name = "ckbUseExtensionProxy";
		C00AFD1D.Size = new Size(140, 20);
		C00AFD1D.TabIndex = 112;
		C00AFD1D.Text = "Use extension proxy";
		C00AFD1D.UseVisualStyleBackColor = true;
		ckbHideBrowser.AutoSize = true;
		ckbHideBrowser.Cursor = Cursors.Hand;
		ckbHideBrowser.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ckbHideBrowser.Location = new Point(295, 22);
		ckbHideBrowser.Name = "ckbHideBrowser";
		ckbHideBrowser.Size = new Size(88, 20);
		ckbHideBrowser.TabIndex = 112;
		ckbHideBrowser.Text = "Ẩn chrome";
		ckbHideBrowser.UseVisualStyleBackColor = true;
		ckbHideBrowser.Visible = false;
		E4A78182.AutoSize = true;
		E4A78182.Cursor = Cursors.Hand;
		E4A78182.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E4A78182.Location = new Point(32, 22);
		E4A78182.Name = "ckbShowImageInteract";
		E4A78182.Size = new Size(183, 20);
		E4A78182.TabIndex = 112;
		E4A78182.Text = "Hiê\u0323n a\u0309nh khi mơ\u0309 tri\u0300nh duyê\u0323t";
		E4A78182.UseVisualStyleBackColor = true;
		ED3D279F.AutoSize = true;
		ED3D279F.Cursor = Cursors.Hand;
		ED3D279F.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ED3D279F.Location = new Point(295, 48);
		ED3D279F.Name = "ckbAddChromeIntoForm";
		ED3D279F.Size = new Size(163, 20);
		ED3D279F.TabIndex = 112;
		ED3D279F.Text = "Add Chrome Form View";
		ED3D279F.UseVisualStyleBackColor = true;
		ED3D279F.CheckedChanged += ED3D279F_CheckedChanged;
		cbbSizeChrome.Cursor = Cursors.Hand;
		cbbSizeChrome.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbSizeChrome.DropDownWidth = 200;
		cbbSizeChrome.FormattingEnabled = true;
		cbbSizeChrome.Location = new Point(225, 78);
		cbbSizeChrome.Name = "cbbSizeChrome";
		cbbSizeChrome.Size = new Size(183, 24);
		cbbSizeChrome.TabIndex = 145;
		label34.AutoSize = true;
		label34.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label34.Location = new Point(28, 83);
		label34.Name = "label34";
		label34.Size = new Size(160, 16);
		label34.TabIndex = 33;
		label34.Text = "Kích thước cửa số chrome:";
		panel3.Controls.Add(label19);
		panel3.Controls.Add(txtLinkToOtherBrowser);
		panel3.Location = new Point(30, 136);
		panel3.Name = "panel3";
		panel3.Size = new Size(535, 25);
		panel3.TabIndex = 156;
		panel3.Click += panel3_Click;
		label19.AutoSize = true;
		label19.Location = new Point(-3, 4);
		label19.Name = "label19";
		label19.Size = new Size(108, 16);
		label19.TabIndex = 148;
		label19.Text = "Path chrome.exe:";
		txtLinkToOtherBrowser.Location = new Point(143, 1);
		txtLinkToOtherBrowser.Name = "txtLinkToOtherBrowser";
		txtLinkToOtherBrowser.Size = new Size(390, 23);
		txtLinkToOtherBrowser.TabIndex = 149;
		plUsePortable.Controls.Add(txtPathToPortableZip);
		plUsePortable.Controls.Add(A4A85536);
		plUsePortable.Controls.Add(B39104B5);
		plUsePortable.Location = new Point(30, 136);
		plUsePortable.Name = "plUsePortable";
		plUsePortable.Size = new Size(502, 25);
		plUsePortable.TabIndex = 155;
		plUsePortable.Paint += A7907C0C;
		txtPathToPortableZip.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtPathToPortableZip.Location = new Point(194, 1);
		txtPathToPortableZip.Name = "txtPathToPortableZip";
		txtPathToPortableZip.Size = new Size(305, 23);
		txtPathToPortableZip.TabIndex = 32;
		txtPathToPortableZip.Click += CC862939;
		A4A85536.AutoSize = true;
		A4A85536.Location = new Point(139, 4);
		A4A85536.Name = "lblFileZip";
		A4A85536.Size = new Size(52, 16);
		A4A85536.TabIndex = 113;
		A4A85536.Text = "File zip:";
		B39104B5.AutoSize = true;
		B39104B5.Cursor = Cursors.Hand;
		B39104B5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B39104B5.Location = new Point(0, 3);
		B39104B5.Name = "ckbUsePortable";
		B39104B5.Size = new Size(125, 20);
		B39104B5.TabIndex = 112;
		B39104B5.Text = "Sử dụng Portable";
		B39104B5.UseVisualStyleBackColor = true;
		B39104B5.CheckedChanged += B39104B5_CheckedChanged;
		grCauHinhKhac.Controls.Add(metroButton4);
		grCauHinhKhac.Controls.Add(lblSelectBackupDB);
		grCauHinhKhac.Controls.Add(DD0EE58B);
		grCauHinhKhac.Controls.Add(C7260BB4);
		grCauHinhKhac.Controls.Add(F190F63D);
		grCauHinhKhac.Controls.Add(A3259409);
		grCauHinhKhac.Controls.Add(EE333C12);
		grCauHinhKhac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		grCauHinhKhac.Location = new Point(7, 241);
		grCauHinhKhac.Name = "grCauHinhKhac";
		grCauHinhKhac.Size = new Size(568, 86);
		grCauHinhKhac.TabIndex = 38;
		grCauHinhKhac.TabStop = false;
		grCauHinhKhac.Text = "Cấu hình khác";
		metroButton4.BackgroundImage = Resources.Bitmap_83;
		metroButton4.Cursor = Cursors.Hand;
		metroButton4.Location = new Point(543, 8);
		metroButton4.Name = "metroButton4";
		metroButton4.Size = new Size(25, 25);
		metroButton4.TabIndex = 158;
		metroButton4.Click += D7183714;
		lblSelectBackupDB.AutoSize = true;
		lblSelectBackupDB.Location = new Point(503, 22);
		lblSelectBackupDB.Name = "lblSelectBackupDB";
		lblSelectBackupDB.Size = new Size(42, 16);
		lblSelectBackupDB.TabIndex = 153;
		lblSelectBackupDB.TabStop = true;
		lblSelectBackupDB.Text = "Select";
		lblSelectBackupDB.LinkClicked += lblSelectBackupDB_LinkClicked;
		DD0EE58B.Controls.Add(EAB05F35);
		DD0EE58B.Controls.Add(label56);
		DD0EE58B.Controls.Add(txtTokenDonglaomail);
		DD0EE58B.Location = new Point(223, 50);
		DD0EE58B.Name = "plGetCode2FA";
		DD0EE58B.Size = new Size(319, 25);
		DD0EE58B.TabIndex = 152;
		DD0EE58B.Visible = false;
		EAB05F35.Cursor = Cursors.Hand;
		EAB05F35.Location = new Point(6, 0);
		EAB05F35.Name = "button6";
		EAB05F35.Size = new Size(314, 25);
		EAB05F35.TabIndex = 35;
		EAB05F35.Text = "Cấu hình Generator";
		EAB05F35.UseVisualStyleBackColor = true;
		EAB05F35.Visible = false;
		EAB05F35.Click += B4104C3C;
		label56.AutoSize = true;
		label56.Location = new Point(3, 4);
		label56.Name = "label56";
		label56.Size = new Size(120, 16);
		label56.TabIndex = 46;
		label56.Text = "Token donglaomail:";
		txtTokenDonglaomail.Location = new Point(129, 1);
		txtTokenDonglaomail.Name = "txtTokenDonglaomail";
		txtTokenDonglaomail.Size = new Size(187, 23);
		txtTokenDonglaomail.TabIndex = 47;
		C7260BB4.AutoSize = true;
		C7260BB4.Cursor = Cursors.Hand;
		C7260BB4.Location = new Point(384, 21);
		C7260BB4.Name = "ckbBackupDB";
		C7260BB4.Size = new Size(127, 20);
		C7260BB4.TabIndex = 152;
		C7260BB4.Text = "Backup Database ";
		C7260BB4.UseVisualStyleBackColor = true;
		C7260BB4.CheckedChanged += C7260BB4_CheckedChanged;
		F190F63D.AutoSize = true;
		F190F63D.Cursor = Cursors.Hand;
		F190F63D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F190F63D.Location = new Point(32, 53);
		F190F63D.Name = "ckbLuuTrangThai";
		F190F63D.Size = new Size(184, 20);
		F190F63D.TabIndex = 157;
		F190F63D.Text = "Lưu dư\u0303 liê\u0323u cô\u0323t [Tra\u0323ng tha\u0301i]";
		F190F63D.UseVisualStyleBackColor = true;
		A3259409.Cursor = Cursors.Hand;
		A3259409.DropDownStyle = ComboBoxStyle.DropDownList;
		A3259409.FormattingEnabled = true;
		A3259409.Location = new Point(229, 19);
		A3259409.Name = "cbbTypePhanBietMau";
		A3259409.Size = new Size(149, 24);
		A3259409.TabIndex = 34;
		EE333C12.AutoSize = true;
		EE333C12.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		EE333C12.Location = new Point(29, 22);
		EE333C12.Name = "label23";
		EE333C12.Size = new Size(194, 16);
		EE333C12.TabIndex = 33;
		EE333C12.Text = "Phân biệt [Tình trạng tài khoản]:";
		B536B128.BorderStyle = BorderStyle.FixedSingle;
		B536B128.Controls.Add(txtListProxyVitech);
		B536B128.Controls.Add(CFBCAFA1);
		B536B128.Controls.Add(F506A61F);
		B536B128.Controls.Add(label40);
		B536B128.Controls.Add(EBBF2F8C);
		B536B128.Controls.Add(CAA02B2A);
		B536B128.Controls.Add(nudLuongPerIPVitech);
		B536B128.Controls.Add(A52E1B32);
		B536B128.Controls.Add(txtApiVitech);
		B536B128.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B536B128.Location = new Point(11, 909);
		B536B128.Name = "plVitech";
		B536B128.Size = new Size(266, 170);
		B536B128.TabIndex = 151;
		B536B128.Visible = false;
		txtListProxyVitech.BorderStyle = BorderStyle.FixedSingle;
		txtListProxyVitech.Location = new Point(6, 71);
		txtListProxyVitech.Name = "txtListProxyVitech";
		txtListProxyVitech.Size = new Size(255, 68);
		txtListProxyVitech.TabIndex = 144;
		txtListProxyVitech.Text = "";
		txtListProxyVitech.WordWrap = false;
		txtListProxyVitech.TextChanged += txtListProxyVitech_TextChanged;
		CFBCAFA1.AutoSize = true;
		CFBCAFA1.Cursor = Cursors.Hand;
		CFBCAFA1.Enabled = false;
		CFBCAFA1.Location = new Point(137, 28);
		CFBCAFA1.Name = "radioButton9";
		CFBCAFA1.Size = new Size(59, 20);
		CFBCAFA1.TabIndex = 82;
		CFBCAFA1.Text = "Sock5";
		CFBCAFA1.UseVisualStyleBackColor = true;
		F506A61F.AutoSize = true;
		F506A61F.Checked = true;
		F506A61F.Cursor = Cursors.Hand;
		F506A61F.Location = new Point(74, 28);
		F506A61F.Name = "radioButton10";
		F506A61F.Size = new Size(48, 20);
		F506A61F.TabIndex = 82;
		F506A61F.TabStop = true;
		F506A61F.Text = "Http";
		F506A61F.UseVisualStyleBackColor = true;
		label40.AutoSize = true;
		label40.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label40.Location = new Point(3, 28);
		label40.Name = "label40";
		label40.Size = new Size(70, 16);
		label40.TabIndex = 79;
		label40.Text = "Loại Proxy:";
		EBBF2F8C.AutoSize = true;
		EBBF2F8C.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		EBBF2F8C.Location = new Point(3, 50);
		EBBF2F8C.Name = "label41";
		EBBF2F8C.Size = new Size(97, 16);
		EBBF2F8C.TabIndex = 79;
		EBBF2F8C.Text = "Nhập Proxy (0):";
		CAA02B2A.AutoSize = true;
		CAA02B2A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		CAA02B2A.Location = new Point(5, 143);
		CAA02B2A.Name = "label42";
		CAA02B2A.Size = new Size(78, 16);
		CAA02B2A.TabIndex = 139;
		CAA02B2A.Text = "Số luồng/IP:";
		nudLuongPerIPVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudLuongPerIPVitech.Location = new Point(90, 142);
		nudLuongPerIPVitech.Name = "nudLuongPerIPVitech";
		nudLuongPerIPVitech.Size = new Size(67, 23);
		nudLuongPerIPVitech.TabIndex = 140;
		nudLuongPerIPVitech.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		A52E1B32.AutoSize = true;
		A52E1B32.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		A52E1B32.Location = new Point(3, 5);
		A52E1B32.Name = "label46";
		A52E1B32.Size = new Size(55, 16);
		A52E1B32.TabIndex = 79;
		A52E1B32.Text = "API Key:";
		txtApiVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		txtApiVitech.ForeColor = Color.Black;
		txtApiVitech.Location = new Point(74, 2);
		txtApiVitech.Name = "txtApiVitech";
		txtApiVitech.Size = new Size(187, 23);
		txtApiVitech.TabIndex = 81;
		AB94A2A0.Cursor = Cursors.Hand;
		AB94A2A0.DropDownStyle = ComboBoxStyle.DropDownList;
		AB94A2A0.Enabled = false;
		AB94A2A0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		AB94A2A0.ForeColor = Color.Black;
		AB94A2A0.FormattingEnabled = true;
		AB94A2A0.Items.AddRange(new object[2] { "Chi\u0309 trong quô\u0301c gia đang cho\u0323n", "Toa\u0300n bô\u0323 quô\u0301c gia" });
		AB94A2A0.Location = new Point(1177, 563);
		AB94A2A0.Name = "cbbHostpot";
		AB94A2A0.Size = new Size(229, 24);
		AB94A2A0.TabIndex = 144;
		rbVitech.AutoSize = true;
		rbVitech.Cursor = Cursors.Hand;
		rbVitech.Enabled = false;
		rbVitech.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		rbVitech.Location = new Point(11, 885);
		rbVitech.Margin = new Padding(3, 4, 3, 4);
		rbVitech.Name = "rbVitech";
		rbVitech.Size = new Size(145, 20);
		rbVitech.TabIndex = 150;
		rbVitech.Text = "VitechCheap(Sắp có)";
		rbVitech.UseVisualStyleBackColor = true;
		rbVitech.Visible = false;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(1057, 37);
		bunifuCards2.TabIndex = 40;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(1057, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
		button2.Location = new Point(1026, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += BE0FF39B;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(1057, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh chung";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(580, 340);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 20;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += BE0FF39B;
		FC075CBE.BorderStyle = BorderStyle.FixedSingle;
		FC075CBE.Controls.Add(EE935139);
		FC075CBE.Controls.Add(textBox1);
		FC075CBE.Enabled = false;
		FC075CBE.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FC075CBE.Location = new Point(1176, 475);
		FC075CBE.Name = "panel2";
		FC075CBE.Size = new Size(232, 30);
		FC075CBE.TabIndex = 142;
		EE935139.AutoSize = true;
		EE935139.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		EE935139.Location = new Point(3, 5);
		EE935139.Name = "label12";
		EE935139.Size = new Size(75, 16);
		EE935139.TabIndex = 82;
		EE935139.Text = "Đường dẫn:";
		textBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		textBox1.ForeColor = Color.Black;
		textBox1.Location = new Point(87, 2);
		textBox1.Name = "textBox1";
		textBox1.Size = new Size(142, 23);
		textBox1.TabIndex = 83;
		E0A1033A.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		E0A1033A.BackColor = Color.FromArgb(53, 120, 229);
		E0A1033A.Cursor = Cursors.Hand;
		E0A1033A.FlatAppearance.BorderSize = 0;
		E0A1033A.FlatStyle = FlatStyle.Flat;
		E0A1033A.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E0A1033A.ForeColor = Color.White;
		E0A1033A.Location = new Point(480, 340);
		E0A1033A.Name = "btnSave";
		E0A1033A.Size = new Size(92, 29);
		E0A1033A.TabIndex = 19;
		E0A1033A.Text = "Lưu";
		E0A1033A.UseVisualStyleBackColor = false;
		E0A1033A.Click += E0A1033A_Click;
		plNordVPN.BorderStyle = BorderStyle.FixedSingle;
		plNordVPN.Controls.Add(A0B2E523);
		plNordVPN.Controls.Add(txtNordVPN);
		plNordVPN.Enabled = false;
		plNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plNordVPN.Location = new Point(1176, 475);
		plNordVPN.Name = "plNordVPN";
		plNordVPN.Size = new Size(232, 30);
		plNordVPN.TabIndex = 142;
		A0B2E523.AutoSize = true;
		A0B2E523.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		A0B2E523.Location = new Point(3, 5);
		A0B2E523.Name = "label14";
		A0B2E523.Size = new Size(75, 16);
		A0B2E523.TabIndex = 82;
		A0B2E523.Text = "Đường dẫn:";
		txtNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		txtNordVPN.ForeColor = Color.Black;
		txtNordVPN.Location = new Point(87, 2);
		txtNordVPN.Name = "txtNordVPN";
		txtNordVPN.Size = new Size(142, 23);
		txtNordVPN.TabIndex = 83;
		btnSSH.Cursor = Cursors.Hand;
		btnSSH.Enabled = false;
		btnSSH.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		btnSSH.ForeColor = Color.Black;
		btnSSH.Location = new Point(1263, 508);
		btnSSH.Margin = new Padding(3, 4, 3, 4);
		btnSSH.Name = "btnSSH";
		btnSSH.Size = new Size(106, 26);
		btnSSH.TabIndex = 130;
		btnSSH.Text = "Nhập IP SSH";
		btnSSH.UseVisualStyleBackColor = true;
		btnSSH.Click += btnSSH_Click;
		A514F5A0.AutoSize = true;
		A514F5A0.Cursor = Cursors.Hand;
		A514F5A0.Enabled = false;
		A514F5A0.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		A514F5A0.Location = new Point(1162, 426);
		A514F5A0.Margin = new Padding(3, 4, 3, 4);
		A514F5A0.Name = "radioButton4";
		A514F5A0.Size = new Size(130, 20);
		A514F5A0.TabIndex = 133;
		A514F5A0.Text = "Đổi IP ExpressVPN";
		A514F5A0.UseVisualStyleBackColor = true;
		AB356E83.AutoSize = true;
		AB356E83.Enabled = false;
		AB356E83.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		AB356E83.Location = new Point(1162, 539);
		AB356E83.Margin = new Padding(3, 4, 3, 4);
		AB356E83.Name = "rbHotspot";
		AB356E83.Size = new Size(145, 20);
		AB356E83.TabIndex = 135;
		AB356E83.Text = "Đổi IP Hotspot Shield";
		AB356E83.UseVisualStyleBackColor = true;
		radioButton5.AutoSize = true;
		radioButton5.Cursor = Cursors.Hand;
		radioButton5.Enabled = false;
		radioButton5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		radioButton5.Location = new Point(1162, 511);
		radioButton5.Margin = new Padding(3, 4, 3, 4);
		radioButton5.Name = "radioButton5";
		radioButton5.Size = new Size(87, 20);
		radioButton5.TabIndex = 132;
		radioButton5.Text = "Đổi IP SSH";
		radioButton5.UseVisualStyleBackColor = true;
		C0A51F90.AutoSize = true;
		C0A51F90.Enabled = false;
		C0A51F90.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C0A51F90.Location = new Point(1162, 451);
		C0A51F90.Margin = new Padding(3, 4, 3, 4);
		C0A51F90.Name = "rbNordVPN";
		C0A51F90.Size = new Size(113, 20);
		C0A51F90.TabIndex = 134;
		C0A51F90.Text = "Đổi IP NordVPN";
		C0A51F90.UseVisualStyleBackColor = true;
		C0A51F90.CheckedChanged += B8203D89_CheckedChanged;
		D403D403.AutoSize = true;
		D403D403.Cursor = Cursors.Hand;
		D403D403.Enabled = false;
		D403D403.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D403D403.Location = new Point(1162, 539);
		D403D403.Margin = new Padding(3, 4, 3, 4);
		D403D403.Name = "radioButton2";
		D403D403.Size = new Size(145, 20);
		D403D403.TabIndex = 135;
		D403D403.Text = "Đổi IP Hotspot Shield";
		D403D403.UseVisualStyleBackColor = true;
		rbSSH.AutoSize = true;
		rbSSH.Enabled = false;
		rbSSH.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		rbSSH.Location = new Point(1162, 511);
		rbSSH.Margin = new Padding(3, 4, 3, 4);
		rbSSH.Name = "rbSSH";
		rbSSH.Size = new Size(87, 20);
		rbSSH.TabIndex = 132;
		rbSSH.Text = "Đổi IP SSH";
		rbSSH.UseVisualStyleBackColor = true;
		B8203D89.AutoSize = true;
		B8203D89.Cursor = Cursors.Hand;
		B8203D89.Enabled = false;
		B8203D89.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B8203D89.Location = new Point(1162, 451);
		B8203D89.Margin = new Padding(3, 4, 3, 4);
		B8203D89.Name = "radioButton3";
		B8203D89.Size = new Size(113, 20);
		B8203D89.TabIndex = 134;
		B8203D89.Text = "Đổi IP NordVPN";
		B8203D89.UseVisualStyleBackColor = true;
		B8203D89.CheckedChanged += B8203D89_CheckedChanged;
		rbExpressVPN.AutoSize = true;
		rbExpressVPN.Enabled = false;
		rbExpressVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		rbExpressVPN.Location = new Point(1162, 426);
		rbExpressVPN.Margin = new Padding(3, 4, 3, 4);
		rbExpressVPN.Name = "rbExpressVPN";
		rbExpressVPN.Size = new Size(130, 20);
		rbExpressVPN.TabIndex = 133;
		rbExpressVPN.Text = "Đổi IP ExpressVPN";
		rbExpressVPN.UseVisualStyleBackColor = true;
		groupBox3.Controls.Add(tabChangeIP);
		groupBox3.Controls.Add(cbbChangeIP);
		groupBox3.Controls.Add(label15);
		groupBox3.Controls.Add(label37);
		groupBox3.Controls.Add(nudDelayCheckIP);
		groupBox3.Controls.Add(label38);
		groupBox3.Controls.Add(FDB6E8B2);
		groupBox3.Controls.Add(CE3B5195);
		groupBox3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		groupBox3.Location = new Point(580, 38);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new Size(471, 289);
		groupBox3.TabIndex = 39;
		groupBox3.TabStop = false;
		groupBox3.Text = "Cấu hình đổi IP";
		tabChangeIP.Alignment = TabAlignment.Bottom;
		tabChangeIP.Controls.Add(tabDcom);
		tabChangeIP.Controls.Add(F21A1896);
		tabChangeIP.Controls.Add(tabXProxy);
		tabChangeIP.Controls.Add(tabObcProxy);
		tabChangeIP.Controls.Add(D712360D);
		tabChangeIP.Controls.Add(tabProxyShopLike);
		tabChangeIP.Controls.Add(BD9C2992);
		tabChangeIP.Controls.Add(A7961637);
		tabChangeIP.Controls.Add(D0125C86);
		tabChangeIP.Controls.Add(tabProxyFb);
		tabChangeIP.Controls.Add(D39D6C05);
		tabChangeIP.Cursor = Cursors.Hand;
		tabChangeIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		tabChangeIP.Location = new Point(30, 107);
		tabChangeIP.Name = "tabChangeIP";
		tabChangeIP.SelectedIndex = 0;
		tabChangeIP.Size = new Size(440, 206);
		tabChangeIP.TabIndex = 146;
		tabDcom.Controls.Add(BEA9001C);
		tabDcom.Location = new Point(4, 4);
		tabDcom.Name = "tabDcom";
		tabDcom.Padding = new Padding(3);
		tabDcom.Size = new Size(432, 177);
		tabDcom.TabIndex = 0;
		tabDcom.Text = "Dcom";
		tabDcom.UseVisualStyleBackColor = true;
		BEA9001C.Controls.Add(D511079E);
		BEA9001C.Controls.Add(D009C92E);
		BEA9001C.Controls.Add(txtProfileNameDcom);
		BEA9001C.Controls.Add(rbDcomHilink);
		BEA9001C.Controls.Add(label36);
		BEA9001C.Controls.Add(D70F2306);
		BEA9001C.Dock = DockStyle.Fill;
		BEA9001C.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BEA9001C.Location = new Point(3, 3);
		BEA9001C.Name = "plDcom";
		BEA9001C.Size = new Size(426, 171);
		BEA9001C.TabIndex = 131;
		D511079E.Anchor = AnchorStyles.None;
		D511079E.Cursor = Cursors.Hand;
		D511079E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D511079E.ForeColor = Color.Black;
		D511079E.Location = new Point(279, 57);
		D511079E.Name = "button4";
		D511079E.Size = new Size(93, 25);
		D511079E.TabIndex = 143;
		D511079E.Text = "Lâ\u0301y tên Dcom";
		toolTip_0.SetToolTip(D511079E, "Lâ\u0301y tên dcom");
		D511079E.UseVisualStyleBackColor = true;
		D511079E.Click += CA845C28;
		D009C92E.Anchor = AnchorStyles.None;
		D009C92E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D009C92E.ForeColor = Color.Black;
		D009C92E.Location = new Point(151, 106);
		D009C92E.Name = "txtUrlHilink";
		D009C92E.Size = new Size(221, 23);
		D009C92E.TabIndex = 81;
		txtProfileNameDcom.Anchor = AnchorStyles.None;
		txtProfileNameDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		txtProfileNameDcom.ForeColor = Color.Black;
		txtProfileNameDcom.Location = new Point(87, 58);
		txtProfileNameDcom.Name = "txtProfileNameDcom";
		txtProfileNameDcom.Size = new Size(186, 23);
		txtProfileNameDcom.TabIndex = 81;
		rbDcomHilink.Anchor = AnchorStyles.None;
		rbDcomHilink.AutoSize = true;
		rbDcomHilink.Cursor = Cursors.Hand;
		rbDcomHilink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		rbDcomHilink.Location = new Point(68, 85);
		rbDcomHilink.Margin = new Padding(3, 4, 3, 4);
		rbDcomHilink.Name = "rbDcomHilink";
		rbDcomHilink.Size = new Size(55, 20);
		rbDcomHilink.TabIndex = 136;
		rbDcomHilink.Text = "Hilink";
		rbDcomHilink.UseVisualStyleBackColor = true;
		rbDcomHilink.CheckedChanged += E321BCA3;
		label36.Anchor = AnchorStyles.None;
		label36.AutoSize = true;
		label36.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label36.Location = new Point(84, 109);
		label36.Name = "label36";
		label36.Size = new Size(64, 16);
		label36.TabIndex = 79;
		label36.Text = "Link Web:";
		D70F2306.Anchor = AnchorStyles.None;
		D70F2306.AutoSize = true;
		D70F2306.Cursor = Cursors.Hand;
		D70F2306.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D70F2306.Location = new Point(68, 34);
		D70F2306.Margin = new Padding(3, 4, 3, 4);
		D70F2306.Name = "rbDcomThuong";
		D70F2306.Size = new Size(69, 20);
		D70F2306.TabIndex = 136;
		D70F2306.Text = "Thươ\u0300ng";
		D70F2306.UseVisualStyleBackColor = true;
		D70F2306.CheckedChanged += D70F2306_CheckedChanged;
		F21A1896.Controls.Add(plTinsoft);
		F21A1896.Location = new Point(4, 4);
		F21A1896.Name = "tabTinsoft";
		F21A1896.Padding = new Padding(3);
		F21A1896.Size = new Size(432, 177);
		F21A1896.TabIndex = 1;
		F21A1896.Text = "tinsoft";
		F21A1896.UseVisualStyleBackColor = true;
		plTinsoft.Controls.Add(FE0F3907);
		plTinsoft.Controls.Add(plApiProxy);
		plTinsoft.Controls.Add(C407F398);
		plTinsoft.Controls.Add(cbbLocationTinsoft);
		plTinsoft.Controls.Add(A91F0B23);
		plTinsoft.Controls.Add(B9076107);
		plTinsoft.Controls.Add(label7);
		plTinsoft.Controls.Add(label8);
		plTinsoft.Controls.Add(B8212D2C);
		plTinsoft.Dock = DockStyle.Fill;
		plTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plTinsoft.Location = new Point(3, 3);
		plTinsoft.Name = "plTinsoft";
		plTinsoft.Size = new Size(426, 171);
		plTinsoft.TabIndex = 143;
		FE0F3907.Anchor = AnchorStyles.None;
		FE0F3907.AutoSize = true;
		FE0F3907.Cursor = Cursors.Hand;
		FE0F3907.Location = new Point(199, 6);
		FE0F3907.Name = "ckbWaitDoneAllTinsoft";
		FE0F3907.Size = new Size(128, 20);
		FE0F3907.TabIndex = 145;
		FE0F3907.Text = "Đợi chạy xong hết";
		FE0F3907.UseVisualStyleBackColor = true;
		FE0F3907.Visible = false;
		plApiProxy.Anchor = AnchorStyles.None;
		plApiProxy.BorderStyle = BorderStyle.FixedSingle;
		plApiProxy.Controls.Add(lblCountApiProxy);
		plApiProxy.Controls.Add(label28);
		plApiProxy.Controls.Add(C32E2592);
		plApiProxy.Controls.Add(button7);
		plApiProxy.Location = new Point(73, 80);
		plApiProxy.Name = "plApiProxy";
		plApiProxy.Size = new Size(301, 58);
		plApiProxy.TabIndex = 35;
		lblCountApiProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		lblCountApiProxy.Location = new Point(1, 24);
		lblCountApiProxy.Name = "lblCountApiProxy";
		lblCountApiProxy.Size = new Size(32, 16);
		lblCountApiProxy.TabIndex = 82;
		lblCountApiProxy.Text = "(0)";
		lblCountApiProxy.TextAlign = ContentAlignment.MiddleCenter;
		label28.AutoSize = true;
		label28.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label28.Location = new Point(1, 5);
		label28.Name = "label28";
		label28.Size = new Size(31, 16);
		label28.TabIndex = 82;
		label28.Text = "API:";
		C32E2592.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C32E2592.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C32E2592.ForeColor = Color.Black;
		C32E2592.Location = new Point(35, 2);
		C32E2592.Multiline = true;
		C32E2592.Name = "txtApiProxy";
		C32E2592.Size = new Size(209, 51);
		C32E2592.TabIndex = 83;
		C32E2592.WordWrap = false;
		C32E2592.TextChanged += F237353C;
		button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button7.Cursor = Cursors.Hand;
		button7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		button7.ForeColor = Color.Black;
		button7.Location = new Point(247, 1);
		button7.Name = "button7";
		button7.Size = new Size(52, 27);
		button7.TabIndex = 143;
		button7.Text = "Check";
		button7.UseVisualStyleBackColor = true;
		button7.Click += button7_Click;
		C407F398.Anchor = AnchorStyles.None;
		C407F398.BorderStyle = BorderStyle.FixedSingle;
		C407F398.Controls.Add(label1);
		C407F398.Controls.Add(txtApiUser);
		C407F398.Controls.Add(button3);
		C407F398.Location = new Point(73, 27);
		C407F398.Name = "plApiUser";
		C407F398.Size = new Size(301, 29);
		C407F398.TabIndex = 35;
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label1.Location = new Point(1, 5);
		label1.Name = "label1";
		label1.Size = new Size(31, 16);
		label1.TabIndex = 82;
		label1.Text = "API:";
		txtApiUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtApiUser.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		txtApiUser.ForeColor = Color.Black;
		txtApiUser.Location = new Point(35, 2);
		txtApiUser.Name = "txtApiUser";
		txtApiUser.Size = new Size(209, 23);
		txtApiUser.TabIndex = 83;
		button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button3.Cursor = Cursors.Hand;
		button3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		button3.ForeColor = Color.Black;
		button3.Location = new Point(247, 0);
		button3.Name = "button3";
		button3.Size = new Size(52, 27);
		button3.TabIndex = 143;
		button3.Text = "Check";
		button3.UseVisualStyleBackColor = true;
		button3.Click += CF879D86;
		cbbLocationTinsoft.Anchor = AnchorStyles.None;
		cbbLocationTinsoft.Cursor = Cursors.Hand;
		cbbLocationTinsoft.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbLocationTinsoft.DropDownWidth = 120;
		cbbLocationTinsoft.FormattingEnabled = true;
		cbbLocationTinsoft.Location = new Point(128, 142);
		cbbLocationTinsoft.Name = "cbbLocationTinsoft";
		cbbLocationTinsoft.Size = new Size(112, 24);
		cbbLocationTinsoft.TabIndex = 84;
		A91F0B23.Anchor = AnchorStyles.None;
		A91F0B23.AutoSize = true;
		A91F0B23.Cursor = Cursors.Hand;
		A91F0B23.Location = new Point(70, 59);
		A91F0B23.Name = "rbApiProxy";
		A91F0B23.Size = new Size(135, 20);
		A91F0B23.TabIndex = 34;
		A91F0B23.Text = "Sử dụng Api Proxy:";
		A91F0B23.UseVisualStyleBackColor = true;
		A91F0B23.CheckedChanged += A91F0B23_CheckedChanged;
		B9076107.Anchor = AnchorStyles.None;
		B9076107.AutoSize = true;
		B9076107.Checked = true;
		B9076107.Cursor = Cursors.Hand;
		B9076107.Location = new Point(70, 6);
		B9076107.Name = "rbApiUser";
		B9076107.Size = new Size(130, 20);
		B9076107.TabIndex = 34;
		B9076107.TabStop = true;
		B9076107.Text = "Sử dụng Api User:";
		B9076107.UseVisualStyleBackColor = true;
		B9076107.CheckedChanged += D394221D;
		label7.Anchor = AnchorStyles.None;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label7.Location = new Point(70, 145);
		label7.Name = "label7";
		label7.Size = new Size(59, 16);
		label7.TabIndex = 82;
		label7.Text = "Location:";
		label8.Anchor = AnchorStyles.None;
		label8.AutoSize = true;
		label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label8.Location = new Point(246, 145);
		label8.Name = "label8";
		label8.Size = new Size(78, 16);
		label8.TabIndex = 139;
		label8.Text = "Số luồng/IP:";
		toolTip_0.SetToolTip(label8, "Là số tài khoản cùng chạy trên 1 Proxy (hay 1 IP)");
		B8212D2C.Anchor = AnchorStyles.None;
		B8212D2C.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B8212D2C.Location = new Point(328, 143);
		B8212D2C.Name = "nudLuongPerIPTinsoft";
		B8212D2C.Size = new Size(46, 23);
		B8212D2C.TabIndex = 140;
		B8212D2C.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		tabXProxy.Controls.Add(plXproxy);
		tabXProxy.Location = new Point(4, 4);
		tabXProxy.Name = "tabXProxy";
		tabXProxy.Padding = new Padding(3);
		tabXProxy.Size = new Size(432, 177);
		tabXProxy.TabIndex = 2;
		tabXProxy.Text = "Xproxy";
		tabXProxy.UseVisualStyleBackColor = true;
		plXproxy.Controls.Add(label53);
		plXproxy.Controls.Add(ckbWaitDoneAllXproxy);
		plXproxy.Controls.Add(BAA2EC20);
		plXproxy.Controls.Add(txtListProxy);
		plXproxy.Controls.Add(rbSock5Proxy);
		plXproxy.Controls.Add(rbHttpProxy);
		plXproxy.Controls.Add(BC12710C);
		plXproxy.Controls.Add(label17);
		plXproxy.Controls.Add(D2BDB785);
		plXproxy.Controls.Add(E235F70D);
		plXproxy.Controls.Add(D827EF03);
		plXproxy.Controls.Add(txtServiceURLXProxy);
		plXproxy.Dock = DockStyle.Fill;
		plXproxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plXproxy.Location = new Point(3, 3);
		plXproxy.Name = "plXproxy";
		plXproxy.Size = new Size(426, 171);
		plXproxy.TabIndex = 142;
		plXproxy.Click += A1B2E79D;
		label53.Anchor = AnchorStyles.None;
		label53.AutoSize = true;
		label53.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label53.Location = new Point(244, 139);
		label53.Name = "label53";
		label53.Size = new Size(82, 16);
		label53.TabIndex = 155;
		label53.Text = "Chế độ chạy:";
		ckbWaitDoneAllXproxy.Anchor = AnchorStyles.None;
		ckbWaitDoneAllXproxy.AutoSize = true;
		ckbWaitDoneAllXproxy.Cursor = Cursors.Hand;
		ckbWaitDoneAllXproxy.Location = new Point(115, 60);
		ckbWaitDoneAllXproxy.Name = "ckbWaitDoneAllXproxy";
		ckbWaitDoneAllXproxy.Size = new Size(128, 20);
		ckbWaitDoneAllXproxy.TabIndex = 145;
		ckbWaitDoneAllXproxy.Text = "Đợi chạy xong hết";
		ckbWaitDoneAllXproxy.UseVisualStyleBackColor = true;
		ckbWaitDoneAllXproxy.Visible = false;
		BAA2EC20.Anchor = AnchorStyles.None;
		BAA2EC20.Cursor = Cursors.Hand;
		BAA2EC20.DropDownStyle = ComboBoxStyle.DropDownList;
		BAA2EC20.DropDownWidth = 150;
		BAA2EC20.FormattingEnabled = true;
		BAA2EC20.Items.AddRange(new object[2] { "Reset từng proxy", "Reset tất cả proxy" });
		BAA2EC20.Location = new Point(332, 135);
		BAA2EC20.Name = "cbbTypeRunXproxy";
		BAA2EC20.Size = new Size(84, 24);
		BAA2EC20.TabIndex = 34;
		txtListProxy.Anchor = AnchorStyles.None;
		txtListProxy.BorderStyle = BorderStyle.FixedSingle;
		txtListProxy.Location = new Point(9, 82);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new Size(229, 78);
		txtListProxy.TabIndex = 144;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += txtListProxy_TextChanged;
		rbSock5Proxy.Anchor = AnchorStyles.None;
		rbSock5Proxy.AutoSize = true;
		rbSock5Proxy.Cursor = Cursors.Hand;
		rbSock5Proxy.Location = new Point(156, 36);
		rbSock5Proxy.Name = "rbSock5Proxy";
		rbSock5Proxy.Size = new Size(59, 20);
		rbSock5Proxy.TabIndex = 82;
		rbSock5Proxy.Text = "Sock5";
		rbSock5Proxy.UseVisualStyleBackColor = true;
		rbHttpProxy.Anchor = AnchorStyles.None;
		rbHttpProxy.AutoSize = true;
		rbHttpProxy.Checked = true;
		rbHttpProxy.Cursor = Cursors.Hand;
		rbHttpProxy.Location = new Point(93, 36);
		rbHttpProxy.Name = "rbHttpProxy";
		rbHttpProxy.Size = new Size(48, 20);
		rbHttpProxy.TabIndex = 82;
		rbHttpProxy.TabStop = true;
		rbHttpProxy.Text = "Http";
		rbHttpProxy.UseVisualStyleBackColor = true;
		BC12710C.Anchor = AnchorStyles.None;
		BC12710C.AutoSize = true;
		BC12710C.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BC12710C.Location = new Point(6, 36);
		BC12710C.Name = "label16";
		BC12710C.Size = new Size(70, 16);
		BC12710C.TabIndex = 79;
		BC12710C.Text = "Loại Proxy:";
		label17.Anchor = AnchorStyles.None;
		label17.AutoSize = true;
		label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label17.Location = new Point(6, 61);
		label17.Name = "label17";
		label17.Size = new Size(97, 16);
		label17.TabIndex = 79;
		label17.Text = "Nhập Proxy (0):";
		D2BDB785.Anchor = AnchorStyles.None;
		D2BDB785.AutoSize = true;
		D2BDB785.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D2BDB785.Location = new Point(244, 108);
		D2BDB785.Name = "label18";
		D2BDB785.Size = new Size(78, 16);
		D2BDB785.TabIndex = 139;
		D2BDB785.Text = "Số luồng/IP:";
		E235F70D.Anchor = AnchorStyles.None;
		E235F70D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E235F70D.Location = new Point(332, 106);
		E235F70D.Name = "nudLuongPerIPXProxy";
		E235F70D.Size = new Size(84, 23);
		E235F70D.TabIndex = 140;
		E235F70D.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		D827EF03.Anchor = AnchorStyles.None;
		D827EF03.AutoSize = true;
		D827EF03.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D827EF03.Location = new Point(6, 12);
		D827EF03.Name = "label13";
		D827EF03.Size = new Size(80, 16);
		D827EF03.TabIndex = 79;
		D827EF03.Text = "Service URL:";
		txtServiceURLXProxy.Anchor = AnchorStyles.None;
		txtServiceURLXProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		txtServiceURLXProxy.ForeColor = Color.Black;
		txtServiceURLXProxy.Location = new Point(93, 9);
		txtServiceURLXProxy.Name = "txtServiceURLXProxy";
		txtServiceURLXProxy.Size = new Size(327, 23);
		txtServiceURLXProxy.TabIndex = 81;
		tabObcProxy.Controls.Add(plObcProxy);
		tabObcProxy.Location = new Point(4, 4);
		tabObcProxy.Name = "tabObcProxy";
		tabObcProxy.Padding = new Padding(3);
		tabObcProxy.Size = new Size(432, 177);
		tabObcProxy.TabIndex = 3;
		tabObcProxy.Text = "OBC";
		tabObcProxy.UseVisualStyleBackColor = true;
		plObcProxy.Controls.Add(cbbTypeRunObcProxy);
		plObcProxy.Controls.Add(label54);
		plObcProxy.Controls.Add(rbObcSock5Proxy);
		plObcProxy.Controls.Add(F62E182B);
		plObcProxy.Controls.Add(label55);
		plObcProxy.Controls.Add(E2B2E584);
		plObcProxy.Controls.Add(FDAEAD8C);
		plObcProxy.Controls.Add(label69);
		plObcProxy.Controls.Add(nudLuongPerIPObcProxy);
		plObcProxy.Controls.Add(label71);
		plObcProxy.Controls.Add(E2B51810);
		plObcProxy.Dock = DockStyle.Fill;
		plObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plObcProxy.Location = new Point(3, 3);
		plObcProxy.Name = "plObcProxy";
		plObcProxy.Size = new Size(426, 171);
		plObcProxy.TabIndex = 142;
		cbbTypeRunObcProxy.Anchor = AnchorStyles.None;
		cbbTypeRunObcProxy.Cursor = Cursors.Hand;
		cbbTypeRunObcProxy.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeRunObcProxy.DropDownWidth = 150;
		cbbTypeRunObcProxy.FormattingEnabled = true;
		cbbTypeRunObcProxy.Items.AddRange(new object[2] { "Reset từng IP", "Reset cả dải IP" });
		cbbTypeRunObcProxy.Location = new Point(336, 136);
		cbbTypeRunObcProxy.Name = "cbbTypeRunObcProxy";
		cbbTypeRunObcProxy.Size = new Size(84, 24);
		cbbTypeRunObcProxy.TabIndex = 157;
		label54.Anchor = AnchorStyles.None;
		label54.AutoSize = true;
		label54.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label54.Location = new Point(244, 139);
		label54.Name = "label54";
		label54.Size = new Size(82, 16);
		label54.TabIndex = 155;
		label54.Text = "Chế độ chạy:";
		rbObcSock5Proxy.Anchor = AnchorStyles.None;
		rbObcSock5Proxy.AutoSize = true;
		rbObcSock5Proxy.Cursor = Cursors.Hand;
		rbObcSock5Proxy.Enabled = false;
		rbObcSock5Proxy.Location = new Point(156, 37);
		rbObcSock5Proxy.Name = "rbObcSock5Proxy";
		rbObcSock5Proxy.Size = new Size(59, 20);
		rbObcSock5Proxy.TabIndex = 154;
		rbObcSock5Proxy.Text = "Sock5";
		rbObcSock5Proxy.UseVisualStyleBackColor = true;
		F62E182B.Anchor = AnchorStyles.None;
		F62E182B.AutoSize = true;
		F62E182B.Checked = true;
		F62E182B.Cursor = Cursors.Hand;
		F62E182B.Location = new Point(93, 37);
		F62E182B.Name = "rbObcHttpProxy";
		F62E182B.Size = new Size(48, 20);
		F62E182B.TabIndex = 155;
		F62E182B.TabStop = true;
		F62E182B.Text = "Http";
		F62E182B.UseVisualStyleBackColor = true;
		label55.Anchor = AnchorStyles.None;
		label55.AutoSize = true;
		label55.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label55.Location = new Point(6, 37);
		label55.Name = "label55";
		label55.Size = new Size(70, 16);
		label55.TabIndex = 153;
		label55.Text = "Loại Proxy:";
		E2B2E584.Anchor = AnchorStyles.None;
		E2B2E584.BorderStyle = BorderStyle.FixedSingle;
		E2B2E584.Location = new Point(9, 77);
		E2B2E584.Name = "txtListObcProxy";
		E2B2E584.Size = new Size(229, 81);
		E2B2E584.TabIndex = 144;
		E2B2E584.Text = "";
		E2B2E584.WordWrap = false;
		E2B2E584.TextChanged += E7957584;
		FDAEAD8C.Anchor = AnchorStyles.None;
		FDAEAD8C.AutoSize = true;
		FDAEAD8C.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FDAEAD8C.Location = new Point(6, 58);
		FDAEAD8C.Name = "label67";
		FDAEAD8C.Size = new Size(97, 16);
		FDAEAD8C.TabIndex = 79;
		FDAEAD8C.Text = "Nhập Proxy (0):";
		label69.Anchor = AnchorStyles.None;
		label69.AutoSize = true;
		label69.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label69.Location = new Point(246, 108);
		label69.Name = "label69";
		label69.Size = new Size(78, 16);
		label69.TabIndex = 139;
		label69.Text = "Số luồng/IP:";
		nudLuongPerIPObcProxy.Anchor = AnchorStyles.None;
		nudLuongPerIPObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudLuongPerIPObcProxy.Location = new Point(336, 107);
		nudLuongPerIPObcProxy.Name = "nudLuongPerIPObcProxy";
		nudLuongPerIPObcProxy.Size = new Size(84, 23);
		nudLuongPerIPObcProxy.TabIndex = 140;
		nudLuongPerIPObcProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label71.Anchor = AnchorStyles.None;
		label71.AutoSize = true;
		label71.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label71.Location = new Point(6, 15);
		label71.Name = "label71";
		label71.Size = new Size(64, 16);
		label71.TabIndex = 79;
		label71.Text = "Link Web:";
		E2B51810.Anchor = AnchorStyles.None;
		E2B51810.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E2B51810.ForeColor = Color.Black;
		E2B51810.Location = new Point(93, 12);
		E2B51810.Name = "txtLinkWebObcProxy";
		E2B51810.Size = new Size(326, 23);
		E2B51810.TabIndex = 81;
		D712360D.Controls.Add(FF02F896);
		D712360D.Location = new Point(4, 4);
		D712360D.Name = "tabProxyV6";
		D712360D.Padding = new Padding(3);
		D712360D.Size = new Size(432, 177);
		D712360D.TabIndex = 4;
		D712360D.Text = "proxyv6.net";
		D712360D.UseVisualStyleBackColor = true;
		FF02F896.Controls.Add(button1);
		FF02F896.Controls.Add(A39E4405);
		FF02F896.Controls.Add(DC225194);
		FF02F896.Controls.Add(label44);
		FF02F896.Controls.Add(F313873D);
		FF02F896.Dock = DockStyle.Fill;
		FF02F896.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FF02F896.Location = new Point(3, 3);
		FF02F896.Name = "plProxyv6";
		FF02F896.Size = new Size(426, 171);
		FF02F896.TabIndex = 151;
		button1.Anchor = AnchorStyles.None;
		button1.Cursor = Cursors.Hand;
		button1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		button1.ForeColor = Color.Black;
		button1.Location = new Point(318, 135);
		button1.Name = "button1";
		button1.Size = new Size(52, 27);
		button1.TabIndex = 145;
		button1.Text = "Check";
		button1.UseVisualStyleBackColor = true;
		button1.Click += FCB19E00;
		A39E4405.Anchor = AnchorStyles.None;
		A39E4405.BorderStyle = BorderStyle.FixedSingle;
		A39E4405.Location = new Point(60, 31);
		A39E4405.Name = "txtListProxyv6";
		A39E4405.Size = new Size(310, 101);
		A39E4405.TabIndex = 144;
		A39E4405.Text = "";
		A39E4405.WordWrap = false;
		A39E4405.TextChanged += CD98BA1C;
		DC225194.Anchor = AnchorStyles.None;
		DC225194.AutoSize = true;
		DC225194.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		DC225194.Location = new Point(57, 10);
		DC225194.Name = "label43";
		DC225194.Size = new Size(110, 16);
		DC225194.TabIndex = 79;
		DC225194.Text = "Nhập API KEY (0):";
		label44.Anchor = AnchorStyles.None;
		label44.AutoSize = true;
		label44.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label44.Location = new Point(57, 139);
		label44.Name = "label44";
		label44.Size = new Size(78, 16);
		label44.TabIndex = 139;
		label44.Text = "Số luồng/IP:";
		F313873D.Anchor = AnchorStyles.None;
		F313873D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		F313873D.Location = new Point(139, 137);
		F313873D.Name = "nudLuongPerIPProxyv6";
		F313873D.Size = new Size(67, 23);
		F313873D.TabIndex = 140;
		F313873D.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		tabProxyShopLike.Controls.Add(plShopLike);
		tabProxyShopLike.Location = new Point(4, 4);
		tabProxyShopLike.Name = "tabProxyShopLike";
		tabProxyShopLike.Padding = new Padding(3);
		tabProxyShopLike.Size = new Size(432, 177);
		tabProxyShopLike.TabIndex = 5;
		tabProxyShopLike.Text = "shoplike";
		tabProxyShopLike.UseVisualStyleBackColor = true;
		plShopLike.Controls.Add(txtApiShopLike);
		plShopLike.Controls.Add(C38A97B5);
		plShopLike.Controls.Add(label48);
		plShopLike.Controls.Add(nudLuongPerIPShopLike);
		plShopLike.Dock = DockStyle.Fill;
		plShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plShopLike.Location = new Point(3, 3);
		plShopLike.Name = "plShopLike";
		plShopLike.Size = new Size(426, 171);
		plShopLike.TabIndex = 153;
		txtApiShopLike.Anchor = AnchorStyles.None;
		txtApiShopLike.BorderStyle = BorderStyle.FixedSingle;
		txtApiShopLike.Location = new Point(60, 31);
		txtApiShopLike.Name = "txtApiShopLike";
		txtApiShopLike.Size = new Size(310, 101);
		txtApiShopLike.TabIndex = 144;
		txtApiShopLike.Text = "";
		txtApiShopLike.WordWrap = false;
		txtApiShopLike.TextChanged += txtApiShopLike_TextChanged;
		C38A97B5.Anchor = AnchorStyles.None;
		C38A97B5.AutoSize = true;
		C38A97B5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C38A97B5.Location = new Point(57, 10);
		C38A97B5.Name = "label47";
		C38A97B5.Size = new Size(110, 16);
		C38A97B5.TabIndex = 79;
		C38A97B5.Text = "Nhập API KEY (0):";
		label48.Anchor = AnchorStyles.None;
		label48.AutoSize = true;
		label48.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label48.Location = new Point(57, 139);
		label48.Name = "label48";
		label48.Size = new Size(78, 16);
		label48.TabIndex = 139;
		label48.Text = "Số luồng/IP:";
		nudLuongPerIPShopLike.Anchor = AnchorStyles.None;
		nudLuongPerIPShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudLuongPerIPShopLike.Location = new Point(139, 137);
		nudLuongPerIPShopLike.Name = "nudLuongPerIPShopLike";
		nudLuongPerIPShopLike.Size = new Size(67, 23);
		nudLuongPerIPShopLike.TabIndex = 140;
		nudLuongPerIPShopLike.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		BD9C2992.Controls.Add(E139C418);
		BD9C2992.Location = new Point(4, 4);
		BD9C2992.Name = "tabTMProxy";
		BD9C2992.Padding = new Padding(3);
		BD9C2992.Size = new Size(432, 177);
		BD9C2992.TabIndex = 6;
		BD9C2992.Text = "tmproxy";
		BD9C2992.UseVisualStyleBackColor = true;
		E139C418.Controls.Add(ckbWaitDoneAllTMProxy);
		E139C418.Controls.Add(CAAE8196);
		E139C418.Controls.Add(label24);
		E139C418.Controls.Add(button8);
		E139C418.Controls.Add(label25);
		E139C418.Controls.Add(AF1C9A1A);
		E139C418.Dock = DockStyle.Fill;
		E139C418.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E139C418.Location = new Point(3, 3);
		E139C418.Name = "plTMProxy";
		E139C418.Size = new Size(426, 171);
		E139C418.TabIndex = 146;
		E139C418.Click += C9916FB7;
		ckbWaitDoneAllTMProxy.Anchor = AnchorStyles.None;
		ckbWaitDoneAllTMProxy.AutoSize = true;
		ckbWaitDoneAllTMProxy.Cursor = Cursors.Hand;
		ckbWaitDoneAllTMProxy.Location = new Point(223, 9);
		ckbWaitDoneAllTMProxy.Name = "ckbWaitDoneAllTMProxy";
		ckbWaitDoneAllTMProxy.Size = new Size(128, 20);
		ckbWaitDoneAllTMProxy.TabIndex = 145;
		ckbWaitDoneAllTMProxy.Text = "Đợi chạy xong hết";
		ckbWaitDoneAllTMProxy.UseVisualStyleBackColor = true;
		ckbWaitDoneAllTMProxy.Visible = false;
		CAAE8196.Anchor = AnchorStyles.None;
		CAAE8196.BorderStyle = BorderStyle.FixedSingle;
		CAAE8196.Location = new Point(60, 31);
		CAAE8196.Name = "txtApiKeyTMProxy";
		CAAE8196.Size = new Size(310, 101);
		CAAE8196.TabIndex = 144;
		CAAE8196.Text = "";
		CAAE8196.WordWrap = false;
		CAAE8196.TextChanged += F1A61523;
		label24.Anchor = AnchorStyles.None;
		label24.AutoSize = true;
		label24.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label24.Location = new Point(57, 10);
		label24.Name = "label24";
		label24.Size = new Size(110, 16);
		label24.TabIndex = 79;
		label24.Text = "Nhập API KEY (0):";
		button8.Anchor = AnchorStyles.None;
		button8.Cursor = Cursors.Hand;
		button8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		button8.ForeColor = Color.Black;
		button8.Location = new Point(318, 135);
		button8.Name = "button8";
		button8.Size = new Size(52, 27);
		button8.TabIndex = 143;
		button8.Text = "Check";
		button8.UseVisualStyleBackColor = true;
		button8.Click += C412A8A4;
		label25.Anchor = AnchorStyles.None;
		label25.AutoSize = true;
		label25.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label25.Location = new Point(57, 139);
		label25.Name = "label25";
		label25.Size = new Size(78, 16);
		label25.TabIndex = 139;
		label25.Text = "Số luồng/IP:";
		AF1C9A1A.Anchor = AnchorStyles.None;
		AF1C9A1A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		AF1C9A1A.Location = new Point(139, 137);
		AF1C9A1A.Name = "nudLuongPerIPTMProxy";
		AF1C9A1A.Size = new Size(67, 23);
		AF1C9A1A.TabIndex = 140;
		AF1C9A1A.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		A7961637.Controls.Add(F119783A);
		A7961637.Location = new Point(4, 4);
		A7961637.Name = "tabNone";
		A7961637.Padding = new Padding(3);
		A7961637.Size = new Size(432, 177);
		A7961637.TabIndex = 7;
		A7961637.Text = "tabNone";
		A7961637.UseVisualStyleBackColor = true;
		F119783A.Dock = DockStyle.Fill;
		F119783A.Location = new Point(3, 3);
		F119783A.Name = "panel16";
		F119783A.Size = new Size(426, 171);
		F119783A.TabIndex = 0;
		D0125C86.Controls.Add(panel5);
		D0125C86.Location = new Point(4, 4);
		D0125C86.Name = "tabMinProxy";
		D0125C86.Padding = new Padding(3);
		D0125C86.Size = new Size(432, 177);
		D0125C86.TabIndex = 8;
		D0125C86.Text = "minproxy";
		D0125C86.UseVisualStyleBackColor = true;
		panel5.Controls.Add(C20C5E2F);
		panel5.Controls.Add(B50F8F2F);
		panel5.Controls.Add(button10);
		panel5.Controls.Add(BC278C3F);
		panel5.Controls.Add(label49);
		panel5.Controls.Add(E83B6223);
		panel5.Controls.Add(D28F098F);
		panel5.Controls.Add(B185D991);
		panel5.Dock = DockStyle.Fill;
		panel5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		panel5.Location = new Point(3, 3);
		panel5.Name = "panel5";
		panel5.Size = new Size(426, 171);
		panel5.TabIndex = 153;
		C20C5E2F.Anchor = AnchorStyles.None;
		C20C5E2F.AutoSize = true;
		C20C5E2F.Cursor = Cursors.Hand;
		C20C5E2F.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C20C5E2F.Location = new Point(211, 8);
		C20C5E2F.Margin = new Padding(3, 4, 3, 4);
		C20C5E2F.Name = "rbProxyDanCu";
		C20C5E2F.Size = new Size(99, 20);
		C20C5E2F.TabIndex = 154;
		C20C5E2F.Text = "Proxy dân cư";
		C20C5E2F.UseVisualStyleBackColor = true;
		C20C5E2F.CheckedChanged += C20C5E2F_CheckedChanged;
		B50F8F2F.Anchor = AnchorStyles.None;
		B50F8F2F.AutoSize = true;
		B50F8F2F.Checked = true;
		B50F8F2F.Cursor = Cursors.Hand;
		B50F8F2F.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B50F8F2F.Location = new Point(92, 8);
		B50F8F2F.Margin = new Padding(3, 4, 3, 4);
		B50F8F2F.Name = "rbProxyDong";
		B50F8F2F.Size = new Size(107, 20);
		B50F8F2F.TabIndex = 153;
		B50F8F2F.TabStop = true;
		B50F8F2F.Text = "Proxy V6 động";
		B50F8F2F.UseVisualStyleBackColor = true;
		button10.Anchor = AnchorStyles.None;
		button10.Cursor = Cursors.Hand;
		button10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		button10.ForeColor = Color.Black;
		button10.Location = new Point(310, 136);
		button10.Name = "button10";
		button10.Size = new Size(52, 27);
		button10.TabIndex = 145;
		button10.Text = "Check";
		button10.UseVisualStyleBackColor = true;
		button10.Click += F68C7C86;
		BC278C3F.Anchor = AnchorStyles.None;
		BC278C3F.BorderStyle = BorderStyle.FixedSingle;
		BC278C3F.Location = new Point(92, 59);
		BC278C3F.Name = "txtApiKeyMinProxy";
		BC278C3F.Size = new Size(270, 76);
		BC278C3F.TabIndex = 144;
		BC278C3F.Text = "";
		BC278C3F.WordWrap = false;
		BC278C3F.TextChanged += D9983815;
		label49.Anchor = AnchorStyles.None;
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(89, 35);
		label49.Name = "label49";
		label49.Size = new Size(110, 16);
		label49.TabIndex = 79;
		label49.Text = "Nhập API KEY (0):";
		E83B6223.Anchor = AnchorStyles.None;
		E83B6223.AutoSize = true;
		E83B6223.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E83B6223.Location = new Point(89, 141);
		E83B6223.Name = "label50";
		E83B6223.Size = new Size(78, 16);
		E83B6223.TabIndex = 139;
		E83B6223.Text = "Số luồng/IP:";
		D28F098F.Anchor = AnchorStyles.None;
		D28F098F.Controls.Add(EF0B4A91);
		D28F098F.Controls.Add(label21);
		D28F098F.Location = new Point(202, 32);
		D28F098F.Name = "plTypeProxy";
		D28F098F.Size = new Size(164, 25);
		D28F098F.TabIndex = 146;
		EF0B4A91.Anchor = AnchorStyles.None;
		EF0B4A91.Cursor = Cursors.Hand;
		EF0B4A91.DropDownStyle = ComboBoxStyle.DropDownList;
		EF0B4A91.DropDownWidth = 150;
		EF0B4A91.FormattingEnabled = true;
		EF0B4A91.Items.AddRange(new object[4] { "Http Ipv4", "Http Ipv6", "Sock Ipv4", "Sock Ipv6" });
		EF0B4A91.Location = new Point(75, 1);
		EF0B4A91.Name = "cbbTypeProxyMin";
		EF0B4A91.Size = new Size(84, 24);
		EF0B4A91.TabIndex = 160;
		label21.Anchor = AnchorStyles.None;
		label21.AutoSize = true;
		label21.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label21.Location = new Point(2, 4);
		label21.Name = "label21";
		label21.Size = new Size(70, 16);
		label21.TabIndex = 159;
		label21.Text = "Loại Proxy:";
		B185D991.Anchor = AnchorStyles.None;
		B185D991.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B185D991.Location = new Point(174, 139);
		B185D991.Name = "nudLuongPerIPMinProxy";
		B185D991.Size = new Size(67, 23);
		B185D991.TabIndex = 140;
		B185D991.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		tabProxyFb.Controls.Add(txtApiKeyProxyFb);
		tabProxyFb.Controls.Add(BFBE55B5);
		tabProxyFb.Controls.Add(C00ECC0F);
		tabProxyFb.Controls.Add(nudLuongPerIPProxyFb);
		tabProxyFb.Location = new Point(4, 4);
		tabProxyFb.Name = "tabProxyFb";
		tabProxyFb.Size = new Size(432, 177);
		tabProxyFb.TabIndex = 9;
		tabProxyFb.Text = "tabProxyFb";
		tabProxyFb.UseVisualStyleBackColor = true;
		txtApiKeyProxyFb.Anchor = AnchorStyles.None;
		txtApiKeyProxyFb.BorderStyle = BorderStyle.FixedSingle;
		txtApiKeyProxyFb.Location = new Point(63, 34);
		txtApiKeyProxyFb.Name = "txtApiKeyProxyFb";
		txtApiKeyProxyFb.Size = new Size(310, 101);
		txtApiKeyProxyFb.TabIndex = 150;
		txtApiKeyProxyFb.Text = "";
		txtApiKeyProxyFb.WordWrap = false;
		txtApiKeyProxyFb.TextChanged += CB8EE694;
		BFBE55B5.Anchor = AnchorStyles.None;
		BFBE55B5.AutoSize = true;
		BFBE55B5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BFBE55B5.Location = new Point(60, 13);
		BFBE55B5.Name = "label31";
		BFBE55B5.Size = new Size(110, 16);
		BFBE55B5.TabIndex = 146;
		BFBE55B5.Text = "Nhập API KEY (0):";
		C00ECC0F.Anchor = AnchorStyles.None;
		C00ECC0F.AutoSize = true;
		C00ECC0F.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C00ECC0F.Location = new Point(60, 142);
		C00ECC0F.Name = "label32";
		C00ECC0F.Size = new Size(78, 16);
		C00ECC0F.TabIndex = 147;
		C00ECC0F.Text = "Số luồng/IP:";
		nudLuongPerIPProxyFb.Anchor = AnchorStyles.None;
		nudLuongPerIPProxyFb.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudLuongPerIPProxyFb.Location = new Point(142, 140);
		nudLuongPerIPProxyFb.Name = "nudLuongPerIPProxyFb";
		nudLuongPerIPProxyFb.Size = new Size(67, 23);
		nudLuongPerIPProxyFb.TabIndex = 148;
		nudLuongPerIPProxyFb.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		D39D6C05.Controls.Add(plTuyChonProxy);
		D39D6C05.Controls.Add(cbbProxy);
		D39D6C05.Controls.Add(B9A6449A);
		D39D6C05.Location = new Point(4, 4);
		D39D6C05.Name = "tabProxy";
		D39D6C05.Size = new Size(432, 177);
		D39D6C05.TabIndex = 10;
		D39D6C05.Text = "tabProxy";
		D39D6C05.UseVisualStyleBackColor = true;
		plTuyChonProxy.BorderStyle = BorderStyle.FixedSingle;
		plTuyChonProxy.Controls.Add(C13A4096);
		plTuyChonProxy.Controls.Add(label45);
		plTuyChonProxy.Controls.Add(label33);
		plTuyChonProxy.Controls.Add(AAAB429A);
		plTuyChonProxy.Location = new Point(70, 46);
		plTuyChonProxy.Name = "plTuyChonProxy";
		plTuyChonProxy.Size = new Size(304, 116);
		plTuyChonProxy.TabIndex = 161;
		C13A4096.Anchor = AnchorStyles.None;
		C13A4096.Cursor = Cursors.Hand;
		C13A4096.DropDownStyle = ComboBoxStyle.DropDownList;
		C13A4096.DropDownWidth = 150;
		C13A4096.FormattingEnabled = true;
		C13A4096.Items.AddRange(new object[2] { "Http", "Sock5" });
		C13A4096.Location = new Point(215, 3);
		C13A4096.Name = "cbbProxyType";
		C13A4096.Size = new Size(84, 24);
		C13A4096.TabIndex = 162;
		label45.Anchor = AnchorStyles.None;
		label45.AutoSize = true;
		label45.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label45.Location = new Point(142, 6);
		label45.Name = "label45";
		label45.Size = new Size(70, 16);
		label45.TabIndex = 161;
		label45.Text = "Loại Proxy:";
		label33.Anchor = AnchorStyles.None;
		label33.AutoSize = true;
		label33.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label33.Location = new Point(3, 6);
		label33.Name = "label33";
		label33.Size = new Size(97, 16);
		label33.TabIndex = 147;
		label33.Text = "Nhập Proxy (0):";
		AAAB429A.Anchor = AnchorStyles.None;
		AAAB429A.BorderStyle = BorderStyle.FixedSingle;
		AAAB429A.Location = new Point(6, 30);
		AAAB429A.Name = "txtProxy";
		AAAB429A.Size = new Size(294, 82);
		AAAB429A.TabIndex = 148;
		AAAB429A.Text = "";
		AAAB429A.WordWrap = false;
		AAAB429A.TextChanged += AAAB429A_TextChanged;
		cbbProxy.Anchor = AnchorStyles.None;
		cbbProxy.Cursor = Cursors.Hand;
		cbbProxy.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbProxy.DropDownWidth = 150;
		cbbProxy.FormattingEnabled = true;
		cbbProxy.Location = new Point(137, 16);
		cbbProxy.Name = "cbbProxy";
		cbbProxy.Size = new Size(237, 24);
		cbbProxy.TabIndex = 160;
		cbbProxy.SelectedIndexChanged += cbbProxy_SelectedIndexChanged;
		B9A6449A.Anchor = AnchorStyles.None;
		B9A6449A.AutoSize = true;
		B9A6449A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B9A6449A.Location = new Point(67, 19);
		B9A6449A.Name = "label39";
		B9A6449A.Size = new Size(64, 16);
		B9A6449A.TabIndex = 159;
		B9A6449A.Text = "Tùy chọn:";
		cbbChangeIP.Cursor = Cursors.Hand;
		cbbChangeIP.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbChangeIP.FormattingEnabled = true;
		cbbChangeIP.Location = new Point(157, 79);
		cbbChangeIP.Name = "cbbChangeIP";
		cbbChangeIP.Size = new Size(309, 24);
		cbbChangeIP.TabIndex = 34;
		cbbChangeIP.SelectedIndexChanged += D22C5003;
		label15.AutoSize = true;
		label15.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label15.Location = new Point(27, 82);
		label15.Name = "label15";
		label15.Size = new Size(126, 16);
		label15.TabIndex = 139;
		label15.Text = "Tùy chọn Change IP:";
		label37.AutoSize = true;
		label37.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label37.Location = new Point(27, 51);
		label37.Name = "label37";
		label37.Size = new Size(123, 16);
		label37.TabIndex = 139;
		label37.Text = "Delay sau khi đô\u0309i IP:";
		nudDelayCheckIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudDelayCheckIP.Location = new Point(157, 49);
		nudDelayCheckIP.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		nudDelayCheckIP.Name = "nudDelayCheckIP";
		nudDelayCheckIP.Size = new Size(46, 23);
		nudDelayCheckIP.TabIndex = 140;
		label38.AutoSize = true;
		label38.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label38.Location = new Point(202, 51);
		label38.Name = "label38";
		label38.Size = new Size(13, 16);
		label38.TabIndex = 141;
		label38.Text = "s";
		FDB6E8B2.Controls.Add(FCAE6F85);
		FDB6E8B2.Controls.Add(CDB6C69E);
		FDB6E8B2.Controls.Add(nudChangeIpCount);
		FDB6E8B2.Controls.Add(C884DD9D);
		FDB6E8B2.Location = new Point(233, 46);
		FDB6E8B2.Name = "plCheckDoiIP";
		FDB6E8B2.Size = new Size(237, 27);
		FDB6E8B2.TabIndex = 146;
		FCAE6F85.Cursor = Cursors.Hand;
		FCAE6F85.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FCAE6F85.ForeColor = Color.Black;
		FCAE6F85.Location = new Point(183, 0);
		FCAE6F85.Name = "button5";
		FCAE6F85.Size = new Size(50, 27);
		FCAE6F85.TabIndex = 143;
		FCAE6F85.Text = "Test";
		FCAE6F85.UseVisualStyleBackColor = true;
		FCAE6F85.Click += FCAE6F85_Click;
		CDB6C69E.AutoSize = true;
		CDB6C69E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		CDB6C69E.Location = new Point(3, 5);
		CDB6C69E.Name = "label26";
		CDB6C69E.Size = new Size(100, 16);
		CDB6C69E.TabIndex = 139;
		CDB6C69E.Text = "Thay đổi IP sau:";
		nudChangeIpCount.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudChangeIpCount.Location = new Point(104, 3);
		nudChangeIpCount.Name = "nudChangeIpCount";
		nudChangeIpCount.Size = new Size(46, 23);
		nudChangeIpCount.TabIndex = 140;
		nudChangeIpCount.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		C884DD9D.AutoSize = true;
		C884DD9D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C884DD9D.Location = new Point(152, 5);
		C884DD9D.Name = "label27";
		C884DD9D.Size = new Size(29, 16);
		C884DD9D.TabIndex = 141;
		C884DD9D.Text = "lượt";
		CE3B5195.AutoSize = true;
		CE3B5195.Cursor = Cursors.Hand;
		CE3B5195.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		CE3B5195.Location = new Point(30, 25);
		CE3B5195.Name = "ckbKhongCheckIP";
		CE3B5195.Size = new Size(198, 20);
		CE3B5195.TabIndex = 112;
		CE3B5195.Text = "Không Check IP trước khi chạy";
		CE3B5195.UseVisualStyleBackColor = true;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(1059, 382);
		base.Controls.Add(C20904A3);
		base.Controls.Add(bunifuCards1);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhChung";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += F1B6B88A;
		((ISupportInitialize)A395893A).EndInit();
		((ISupportInitialize)nudHideThread).EndInit();
		C20904A3.ResumeLayout(performLayout: false);
		C20904A3.PerformLayout();
		grCauHinhChung.ResumeLayout(performLayout: false);
		grCauHinhChung.PerformLayout();
		plDongBoMaxCare.ResumeLayout(performLayout: false);
		plDongBoMaxCare.PerformLayout();
		FD22F009.ResumeLayout(performLayout: false);
		FD22F009.PerformLayout();
		plSizeChrome.ResumeLayout(performLayout: false);
		plSizeChrome.PerformLayout();
		((ISupportInitialize)nudDelayOpenChromeTo).EndInit();
		((ISupportInitialize)B5301DBB).EndInit();
		plDelayCloseChrome.ResumeLayout(performLayout: false);
		((ISupportInitialize)D4ADFB28).EndInit();
		((ISupportInitialize)AAAC80AB).EndInit();
		plSapXepCuaSoChrome.ResumeLayout(performLayout: false);
		plSapXepCuaSoChrome.PerformLayout();
		E61FF030.ResumeLayout(performLayout: false);
		E61FF030.PerformLayout();
		((ISupportInitialize)ED9207B7).EndInit();
		((ISupportInitialize)CF813A26).EndInit();
		panel3.ResumeLayout(performLayout: false);
		panel3.PerformLayout();
		plUsePortable.ResumeLayout(performLayout: false);
		plUsePortable.PerformLayout();
		grCauHinhKhac.ResumeLayout(performLayout: false);
		grCauHinhKhac.PerformLayout();
		DD0EE58B.ResumeLayout(performLayout: false);
		DD0EE58B.PerformLayout();
		B536B128.ResumeLayout(performLayout: false);
		B536B128.PerformLayout();
		((ISupportInitialize)nudLuongPerIPVitech).EndInit();
		bunifuCards2.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		FC075CBE.ResumeLayout(performLayout: false);
		FC075CBE.PerformLayout();
		plNordVPN.ResumeLayout(performLayout: false);
		plNordVPN.PerformLayout();
		groupBox3.ResumeLayout(performLayout: false);
		groupBox3.PerformLayout();
		tabChangeIP.ResumeLayout(performLayout: false);
		tabDcom.ResumeLayout(performLayout: false);
		BEA9001C.ResumeLayout(performLayout: false);
		BEA9001C.PerformLayout();
		F21A1896.ResumeLayout(performLayout: false);
		plTinsoft.ResumeLayout(performLayout: false);
		plTinsoft.PerformLayout();
		plApiProxy.ResumeLayout(performLayout: false);
		plApiProxy.PerformLayout();
		C407F398.ResumeLayout(performLayout: false);
		C407F398.PerformLayout();
		((ISupportInitialize)B8212D2C).EndInit();
		tabXProxy.ResumeLayout(performLayout: false);
		plXproxy.ResumeLayout(performLayout: false);
		plXproxy.PerformLayout();
		((ISupportInitialize)E235F70D).EndInit();
		tabObcProxy.ResumeLayout(performLayout: false);
		plObcProxy.ResumeLayout(performLayout: false);
		plObcProxy.PerformLayout();
		((ISupportInitialize)nudLuongPerIPObcProxy).EndInit();
		D712360D.ResumeLayout(performLayout: false);
		FF02F896.ResumeLayout(performLayout: false);
		FF02F896.PerformLayout();
		((ISupportInitialize)F313873D).EndInit();
		tabProxyShopLike.ResumeLayout(performLayout: false);
		plShopLike.ResumeLayout(performLayout: false);
		plShopLike.PerformLayout();
		((ISupportInitialize)nudLuongPerIPShopLike).EndInit();
		BD9C2992.ResumeLayout(performLayout: false);
		E139C418.ResumeLayout(performLayout: false);
		E139C418.PerformLayout();
		((ISupportInitialize)AF1C9A1A).EndInit();
		A7961637.ResumeLayout(performLayout: false);
		D0125C86.ResumeLayout(performLayout: false);
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		D28F098F.ResumeLayout(performLayout: false);
		D28F098F.PerformLayout();
		((ISupportInitialize)B185D991).EndInit();
		tabProxyFb.ResumeLayout(performLayout: false);
		tabProxyFb.PerformLayout();
		((ISupportInitialize)nudLuongPerIPProxyFb).EndInit();
		D39D6C05.ResumeLayout(performLayout: false);
		D39D6C05.PerformLayout();
		plTuyChonProxy.ResumeLayout(performLayout: false);
		plTuyChonProxy.PerformLayout();
		((ISupportInitialize)nudDelayCheckIP).EndInit();
		FDB6E8B2.ResumeLayout(performLayout: false);
		FDB6E8B2.PerformLayout();
		((ISupportInitialize)nudChangeIpCount).EndInit();
		ResumeLayout(performLayout: false);
	}
}
