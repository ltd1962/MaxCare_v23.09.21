using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTuongTac_Old : Form
{
	private string string_0 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button D88658B3;

	private Button btnCancel;

	private Button B5AC6737;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private GroupBox groupBox2;

	private CheckBox ckbRandomHanhDong;

	private ComboBox cbbKichBan;

	private Button btnQuanLyKichBan;

	private Label A9A2B009;

	private CheckBox EE81321A;

	private CheckBox A01B9023;

	private CheckBox ckbCapNhatThongTin;

	private CheckBox D68A930A;

	private Panel panel1;

	private CheckBox ckbRepeatAll;

	private CheckBox ckbLogOut;

	private CheckBox E612C090;

	private Label label3;

	private Label B2B53532;

	private CheckBox C4BC71BD;

	private Panel plRepeatAll;

	private Label label6;

	private Label label4;

	private NumericUpDown nudDelayTurnFrom;

	private Label A01C5517;

	private NumericUpDown B60B9FAF;

	private Label B68E0B92;

	private NumericUpDown nudSoLuotChay;

	private Label AE2FC510;

	private CheckBox ckbReviewTag;

	private CheckBox F9B43D09;

	private CheckBox ckbDontSaveBrowser;

	private CheckBox E4A2132F;

	private CheckBox ckbCauHinhTaiKhoan;

	private CheckBox A1A4C321;

	private Panel F22BD89B;

	private CheckBox FE8BC096;

	private CheckBox ckbFollow;

	private CheckBox B5A1B002;

	private CheckBox D1B24B37;

	private CheckBox ckbNgayTao;

	private CheckBox D29350A5;

	private CheckBox ckbGender;

	private CheckBox C1245DB5;

	private Panel plGioiHanThoiGianChayKichBan;

	private Label label7;

	private NumericUpDown nudThoiGianChayKichBanTo;

	private NumericUpDown F899BE87;

	private Panel plGioiHanThoiGianChayTaiKhoan;

	private Label label13;

	private NumericUpDown nudThoiGianChayTaiKhoanTo;

	private NumericUpDown nudThoiGianChayTaiKhoanFrom;

	private CheckBox ckbGioiHanThoiGianChayKichBan;

	private CheckBox C11F8134;

	private CheckBox B5379BBB;

	private CheckBox ckbBackupDB;

	private CheckBox CD39A98D;

	private CheckBox ckbPhone;

	private ComboBox B5B7DD18;

	private ComboBox cbbTypeLogin;

	private ComboBox cbbFacebookWeb;

	private CheckBox ckbAvatar;

	private CheckBox A22E3085;

	private CheckBox ckbLocation;

	private LinkLabel lblSelectBackupDB;

	private CheckBox B03BFD05;

	private CheckBox ckbBM;

	private CheckBox ckbAds;

	private CheckBox D793EBAD;

	private CheckBox ckbPagePro5;

	private GroupBox FD99239F;

	private GroupBox C5B98B86;

	private CheckBox CB84C11F;

	private CheckBox ckbDisableChatSettings;

	private CheckBox E6271AA7;

	private CheckBox ckbFbBlock;

	public fCauHinhTuongTac_Old()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void D88658B3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D6257A03(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configInteractGeneral").GetJson("typeLogin", cbbTypeLogin.SelectedIndex);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("typeBrowserLogin", cbbFacebookWeb.SelectedIndex);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCreateProfile", EE81321A.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGetToken", D68A930A.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("typeToken", B5B7DD18.SelectedIndex);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGetCookie", A01B9023.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCapNhatThongTin", ckbCapNhatThongTin.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbName", C1245DB5.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGender", ckbGender.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBirthday", D29350A5.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbNgayTao", ckbNgayTao.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbEmail", FE8BC096.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbFriend", D1B24B37.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGroup", B5A1B002.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbPage", B03BFD05.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbPagePro5", ckbPagePro5.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbFollow", ckbFollow.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbPhone", ckbPhone.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbAvatar", ckbAvatar.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbDating", D793EBAD.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbAds", ckbAds.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBM", ckbBM.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbLocation", ckbLocation.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbHometown", CB84C11F.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbFbBlock", ckbFbBlock.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCheckLiveUid", F9B43D09.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbDontSaveBrowser", ckbDontSaveBrowser.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbRepeatAll", ckbRepeatAll.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudDelayTurnFrom", nudDelayTurnFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudDelayTurnTo", B60B9FAF.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudSoLuotChay", nudSoLuotChay.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("RepeatAllVIP", "false");
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbLogOut", ckbLogOut.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbAllowFollow", C4BC71BD.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbReviewTag", ckbReviewTag.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBatThongBaoDangNhap", E4A2132F.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCauHinhTaiKhoan", ckbCauHinhTaiKhoan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbWallPosts", E6271AA7.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCheckSpam", CD39A98D.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCongKhaiBanBe", E612C090.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBackupDB", ckbBackupDB.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("txtBackupDBPath", string_0);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbRandomThuTuTaiKhoan", A22E3085.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("cbbKichBan", cbbKichBan.SelectedValue);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbRandomHanhDong", ckbRandomHanhDong.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbXoaCache", A1A4C321.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCheckBanBeGoiY", B5379BBB.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGioiHanThoiGianChayTaiKhoan", C11F8134.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayTaiKhoanFrom", nudThoiGianChayTaiKhoanFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayTaiKhoanTo", nudThoiGianChayTaiKhoanTo.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGioiHanThoiGianChayKichBan", ckbGioiHanThoiGianChayKichBan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayKichBanFrom", F899BE87.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayKichBanTo", nudThoiGianChayKichBanTo.Value);
		SettingsTool.Save("configInteractGeneral");
		if (MessageBoxHelper.ShowMessages("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnQuanLyKichBan_Click(object sender, EventArgs e)
	{
		string text = "";
		try
		{
			if (cbbKichBan.Items.Count > 0)
			{
				text = cbbKichBan.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		Common.ShowForm(new fDanhSachKichBan_Old(text));
		LoadCbbKichBan();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void D5229E17(object sender, EventArgs e)
	{
	}

	private void BB0B4203()
	{
		method_0(null, null);
		D5229E17(null, null);
		ckbRepeatAll_CheckedChanged(null, null);
		ckbCapNhatThongTin_CheckedChanged(null, null);
		C11F8134_CheckedChanged(null, null);
		ckbGioiHanThoiGianChayKichBan_CheckedChanged(null, null);
		A69C4018(null, null);
		D40E6101(null, null);
	}

	private void A604E73C_Load(object sender, EventArgs e)
	{
		LoadCbbKichBan();
		CDB88F30();
		BB0B4203();
	}

	private void CDB88F30()
	{
		try
		{
			cbbTypeLogin.SelectedIndex = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeLogin");
			cbbFacebookWeb.SelectedIndex = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeBrowserLogin");
			EE81321A.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCreateProfile");
			D68A930A.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetToken");
			B5B7DD18.SelectedIndex = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeToken");
			A01B9023.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie");
			ckbCapNhatThongTin.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCapNhatThongTin");
			C1245DB5.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbName");
			ckbGender.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGender");
			D29350A5.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBirthday");
			ckbNgayTao.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbNgayTao");
			FE8BC096.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbEmail");
			D1B24B37.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFriend");
			B5A1B002.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGroup");
			B03BFD05.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPage");
			ckbPagePro5.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPagePro5");
			ckbFollow.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFollow");
			ckbPhone.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPhone");
			ckbAvatar.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAvatar");
			D793EBAD.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDating");
			ckbAds.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAds");
			ckbBM.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBM");
			ckbLocation.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbLocation");
			CB84C11F.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbHometown");
			ckbFbBlock.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFbBlock");
			F9B43D09.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckLiveUid");
			ckbDontSaveBrowser.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDontSaveBrowser");
			ckbRepeatAll.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll");
			nudDelayTurnFrom.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnFrom");
			B60B9FAF.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnTo");
			nudSoLuotChay.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudSoLuotChay");
			ckbLogOut.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbLogOut");
			C4BC71BD.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAllowFollow");
			ckbReviewTag.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbReviewTag");
			E4A2132F.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBatThongBaoDangNhap");
			E6271AA7.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbWallPosts");
			ckbCauHinhTaiKhoan.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCauHinhTaiKhoan");
			CD39A98D.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckSpam");
			E612C090.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCongKhaiBanBe");
			ckbBackupDB.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBackupDB", bool_0: true);
			string_0 = SettingsTool.GetSettings("configInteractGeneral").GetValue("txtBackupDBPath", Environment.GetEnvironmentVariable("LocalAppData") + "\\database");
			Common.CreateFolder(string_0);
			A22E3085.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomThuTuTaiKhoan");
			cbbKichBan.SelectedValue = SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan");
			ckbRandomHanhDong.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomHanhDong");
			A1A4C321.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbXoaCache");
			B5379BBB.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckBanBeGoiY");
			C11F8134.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayTaiKhoan");
			nudThoiGianChayTaiKhoanFrom.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayTaiKhoanFrom", 1);
			nudThoiGianChayTaiKhoanTo.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayTaiKhoanTo", 1);
			ckbGioiHanThoiGianChayKichBan.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayKichBan");
			F899BE87.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanFrom", 1);
			nudThoiGianChayKichBanTo.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanTo", 1);
		}
		catch
		{
		}
	}

	private void LoadCbbKichBan()
	{
		int num = -1;
		if (cbbKichBan.SelectedIndex != -1)
		{
			num = cbbKichBan.SelectedIndex;
		}
		DataTable dataSource = InteractSQL.GetAllKichBan();
		cbbKichBan.DataSource = dataSource;
		cbbKichBan.ValueMember = "Id_KichBan";
		cbbKichBan.DisplayMember = "Ten";
		if (num != -1 && num != 0 && cbbKichBan.Items.Count >= num + 1)
		{
			cbbKichBan.SelectedIndex = num;
		}
		else if (cbbKichBan.Items.Count > 0)
		{
			cbbKichBan.SelectedIndex = 0;
		}
	}

	private void E2849DAF(object sender, PaintEventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
	{
		F22BD89B.Enabled = ckbCapNhatThongTin.Checked;
	}

	private void D68A930A_Click(object sender, EventArgs e)
	{
	}

	private void ckbRepeatAll_CheckedChanged(object sender, EventArgs e)
	{
		plRepeatAll.Enabled = ckbRepeatAll.Checked;
	}

	private void CD39A98D_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void BA278307(object sender, EventArgs e)
	{
	}

	private void C11F8134_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayTaiKhoan.Enabled = C11F8134.Checked;
	}

	private void ckbGioiHanThoiGianChayKichBan_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayKichBan.Enabled = ckbGioiHanThoiGianChayKichBan.Checked;
	}

	private void A69C4018(object sender, EventArgs e)
	{
		B5B7DD18.Enabled = D68A930A.Checked;
	}

	private void ACAE04A0(object sender, EventArgs e)
	{
		if (B5A1B002.Checked && MessageBoxHelper.ShowMessages("Sư\u0309 du\u0323ng ti\u0301nh năng na\u0300y co\u0301 thê\u0309 dâ\u0303n đê\u0301n ta\u0300i khoa\u0309n Facebook bi\u0323 kho\u0301a!\r\nBa\u0323n co\u0301 chă\u0301c vâ\u0303n muô\u0301n sư\u0309 du\u0323ng?") == DialogResult.No)
		{
			B5A1B002.Checked = false;
		}
	}

	private void lblSelectBackupDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (!Directory.Exists(string_0))
		{
			string_0 = Environment.GetEnvironmentVariable("LocalAppData") + "\\database";
			Common.CreateFolder(string_0);
		}
		string text = Common.SelectFolder(string_0);
		if (text != "")
		{
			string_0 = text;
		}
	}

	private void D40E6101(object sender, EventArgs e)
	{
		lblSelectBackupDB.Enabled = ckbBackupDB.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTuongTac_Old));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.D88658B3 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.B5AC6737 = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.plGioiHanThoiGianChayKichBan = new System.Windows.Forms.Panel();
		this.label7 = new System.Windows.Forms.Label();
		this.nudThoiGianChayKichBanTo = new System.Windows.Forms.NumericUpDown();
		this.F899BE87 = new System.Windows.Forms.NumericUpDown();
		this.plGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.Panel();
		this.label13 = new System.Windows.Forms.Label();
		this.nudThoiGianChayTaiKhoanTo = new System.Windows.Forms.NumericUpDown();
		this.nudThoiGianChayTaiKhoanFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbGioiHanThoiGianChayKichBan = new System.Windows.Forms.CheckBox();
		this.A9A2B009 = new System.Windows.Forms.Label();
		this.C11F8134 = new System.Windows.Forms.CheckBox();
		this.btnQuanLyKichBan = new System.Windows.Forms.Button();
		this.ckbRandomHanhDong = new System.Windows.Forms.CheckBox();
		this.cbbKichBan = new System.Windows.Forms.ComboBox();
		this.label3 = new System.Windows.Forms.Label();
		this.B2B53532 = new System.Windows.Forms.Label();
		this.EE81321A = new System.Windows.Forms.CheckBox();
		this.A01B9023 = new System.Windows.Forms.CheckBox();
		this.ckbRepeatAll = new System.Windows.Forms.CheckBox();
		this.C4BC71BD = new System.Windows.Forms.CheckBox();
		this.E612C090 = new System.Windows.Forms.CheckBox();
		this.ckbLogOut = new System.Windows.Forms.CheckBox();
		this.ckbCapNhatThongTin = new System.Windows.Forms.CheckBox();
		this.D68A930A = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.FD99239F = new System.Windows.Forms.GroupBox();
		this.E6271AA7 = new System.Windows.Forms.CheckBox();
		this.lblSelectBackupDB = new System.Windows.Forms.LinkLabel();
		this.cbbTypeLogin = new System.Windows.Forms.ComboBox();
		this.cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		this.B5B7DD18 = new System.Windows.Forms.ComboBox();
		this.ckbBackupDB = new System.Windows.Forms.CheckBox();
		this.ckbReviewTag = new System.Windows.Forms.CheckBox();
		this.A1A4C321 = new System.Windows.Forms.CheckBox();
		this.ckbCauHinhTaiKhoan = new System.Windows.Forms.CheckBox();
		this.ckbDisableChatSettings = new System.Windows.Forms.CheckBox();
		this.CD39A98D = new System.Windows.Forms.CheckBox();
		this.C5B98B86 = new System.Windows.Forms.GroupBox();
		this.A22E3085 = new System.Windows.Forms.CheckBox();
		this.F22BD89B = new System.Windows.Forms.Panel();
		this.CB84C11F = new System.Windows.Forms.CheckBox();
		this.ckbLocation = new System.Windows.Forms.CheckBox();
		this.ckbNgayTao = new System.Windows.Forms.CheckBox();
		this.ckbPagePro5 = new System.Windows.Forms.CheckBox();
		this.B03BFD05 = new System.Windows.Forms.CheckBox();
		this.FE8BC096 = new System.Windows.Forms.CheckBox();
		this.ckbBM = new System.Windows.Forms.CheckBox();
		this.ckbFbBlock = new System.Windows.Forms.CheckBox();
		this.ckbAds = new System.Windows.Forms.CheckBox();
		this.D793EBAD = new System.Windows.Forms.CheckBox();
		this.ckbAvatar = new System.Windows.Forms.CheckBox();
		this.ckbPhone = new System.Windows.Forms.CheckBox();
		this.ckbFollow = new System.Windows.Forms.CheckBox();
		this.B5A1B002 = new System.Windows.Forms.CheckBox();
		this.D1B24B37 = new System.Windows.Forms.CheckBox();
		this.D29350A5 = new System.Windows.Forms.CheckBox();
		this.ckbGender = new System.Windows.Forms.CheckBox();
		this.C1245DB5 = new System.Windows.Forms.CheckBox();
		this.plRepeatAll = new System.Windows.Forms.Panel();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.nudDelayTurnFrom = new System.Windows.Forms.NumericUpDown();
		this.A01C5517 = new System.Windows.Forms.Label();
		this.B60B9FAF = new System.Windows.Forms.NumericUpDown();
		this.B68E0B92 = new System.Windows.Forms.Label();
		this.nudSoLuotChay = new System.Windows.Forms.NumericUpDown();
		this.AE2FC510 = new System.Windows.Forms.Label();
		this.F9B43D09 = new System.Windows.Forms.CheckBox();
		this.ckbDontSaveBrowser = new System.Windows.Forms.CheckBox();
		this.B5379BBB = new System.Windows.Forms.CheckBox();
		this.E4A2132F = new System.Windows.Forms.CheckBox();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.groupBox2.SuspendLayout();
		this.plGioiHanThoiGianChayKichBan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F899BE87).BeginInit();
		this.plGioiHanThoiGianChayTaiKhoan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanFrom).BeginInit();
		this.panel1.SuspendLayout();
		this.FD99239F.SuspendLayout();
		this.C5B98B86.SuspendLayout();
		this.F22BD89B.SuspendLayout();
		this.plRepeatAll.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B60B9FAF).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.FromArgb(24, 119, 242);
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(2, 1);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(877, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.D88658B3);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(877, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 78;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.D88658B3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.D88658B3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D88658B3.FlatAppearance.BorderSize = 0;
		this.D88658B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D88658B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D88658B3.ForeColor = System.Drawing.Color.White;
		this.D88658B3.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.D88658B3.Location = new System.Drawing.Point(843, -2);
		this.D88658B3.Name = "btnMinimize";
		this.D88658B3.Size = new System.Drawing.Size(32, 32);
		this.D88658B3.TabIndex = 9;
		this.D88658B3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.D88658B3.UseVisualStyleBackColor = true;
		this.D88658B3.Click += new System.EventHandler(D88658B3_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(877, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(446, 385);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.B5AC6737.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.B5AC6737.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.B5AC6737.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5AC6737.FlatAppearance.BorderSize = 0;
		this.B5AC6737.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B5AC6737.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B5AC6737.ForeColor = System.Drawing.Color.White;
		this.B5AC6737.Location = new System.Drawing.Point(348, 385);
		this.B5AC6737.Name = "btnAdd";
		this.B5AC6737.Size = new System.Drawing.Size(92, 29);
		this.B5AC6737.TabIndex = 3;
		this.B5AC6737.Text = "Lưu";
		this.B5AC6737.UseVisualStyleBackColor = false;
		this.B5AC6737.Click += new System.EventHandler(D6257A03);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.groupBox2.Controls.Add(this.plGioiHanThoiGianChayKichBan);
		this.groupBox2.Controls.Add(this.plGioiHanThoiGianChayTaiKhoan);
		this.groupBox2.Controls.Add(this.ckbGioiHanThoiGianChayKichBan);
		this.groupBox2.Controls.Add(this.A9A2B009);
		this.groupBox2.Controls.Add(this.C11F8134);
		this.groupBox2.Controls.Add(this.btnQuanLyKichBan);
		this.groupBox2.Controls.Add(this.ckbRandomHanhDong);
		this.groupBox2.Controls.Add(this.cbbKichBan);
		this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox2.Location = new System.Drawing.Point(446, 233);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(421, 138);
		this.groupBox2.TabIndex = 7;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn kiểu tương tác";
		this.plGioiHanThoiGianChayKichBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.label7);
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.nudThoiGianChayKichBanTo);
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.F899BE87);
		this.plGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(269, 103);
		this.plGioiHanThoiGianChayKichBan.Name = "plGioiHanThoiGianChayKichBan";
		this.plGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(121, 27);
		this.plGioiHanThoiGianChayKichBan.TabIndex = 17;
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new System.Drawing.Point(50, 4);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(18, 16);
		this.label7.TabIndex = 4;
		this.label7.Text = ">";
		this.nudThoiGianChayKichBanTo.Location = new System.Drawing.Point(69, 1);
		this.nudThoiGianChayKichBanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayKichBanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanTo.Name = "nudThoiGianChayKichBanTo";
		this.nudThoiGianChayKichBanTo.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayKichBanTo.TabIndex = 3;
		this.nudThoiGianChayKichBanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.F899BE87.Location = new System.Drawing.Point(1, 1);
		this.F899BE87.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.F899BE87.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.F899BE87.Name = "nudThoiGianChayKichBanFrom";
		this.F899BE87.Size = new System.Drawing.Size(48, 23);
		this.F899BE87.TabIndex = 3;
		this.F899BE87.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.plGioiHanThoiGianChayTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.label13);
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.nudThoiGianChayTaiKhoanTo);
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.nudThoiGianChayTaiKhoanFrom);
		this.plGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(269, 71);
		this.plGioiHanThoiGianChayTaiKhoan.Name = "plGioiHanThoiGianChayTaiKhoan";
		this.plGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(121, 27);
		this.plGioiHanThoiGianChayTaiKhoan.TabIndex = 18;
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.Location = new System.Drawing.Point(50, 4);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(18, 16);
		this.label13.TabIndex = 4;
		this.label13.Text = ">";
		this.nudThoiGianChayTaiKhoanTo.Location = new System.Drawing.Point(69, 1);
		this.nudThoiGianChayTaiKhoanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayTaiKhoanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayTaiKhoanTo.Name = "nudThoiGianChayTaiKhoanTo";
		this.nudThoiGianChayTaiKhoanTo.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayTaiKhoanTo.TabIndex = 3;
		this.nudThoiGianChayTaiKhoanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayTaiKhoanFrom.Location = new System.Drawing.Point(1, 1);
		this.nudThoiGianChayTaiKhoanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayTaiKhoanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayTaiKhoanFrom.Name = "nudThoiGianChayTaiKhoanFrom";
		this.nudThoiGianChayTaiKhoanFrom.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayTaiKhoanFrom.TabIndex = 3;
		this.nudThoiGianChayTaiKhoanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.ckbGioiHanThoiGianChayKichBan.AutoSize = true;
		this.ckbGioiHanThoiGianChayKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(12, 107);
		this.ckbGioiHanThoiGianChayKichBan.Name = "ckbGioiHanThoiGianChayKichBan";
		this.ckbGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(246, 20);
		this.ckbGioiHanThoiGianChayKichBan.TabIndex = 15;
		this.ckbGioiHanThoiGianChayKichBan.Text = "Giới hạn thời gian chạy/kịch bản (phút)";
		this.ckbGioiHanThoiGianChayKichBan.UseVisualStyleBackColor = true;
		this.ckbGioiHanThoiGianChayKichBan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayKichBan_CheckedChanged);
		this.A9A2B009.AutoSize = true;
		this.A9A2B009.Location = new System.Drawing.Point(9, 26);
		this.A9A2B009.Name = "label1";
		this.A9A2B009.Size = new System.Drawing.Size(92, 16);
		this.A9A2B009.TabIndex = 0;
		this.A9A2B009.Text = "Chọn kịch bản:";
		this.C11F8134.AutoSize = true;
		this.C11F8134.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C11F8134.Location = new System.Drawing.Point(12, 74);
		this.C11F8134.Name = "ckbGioiHanThoiGianChayTaiKhoan";
		this.C11F8134.Size = new System.Drawing.Size(249, 20);
		this.C11F8134.TabIndex = 16;
		this.C11F8134.Text = "Giới hạn thời gian chạy/tài khoản (giây)";
		this.C11F8134.UseVisualStyleBackColor = true;
		this.C11F8134.CheckedChanged += new System.EventHandler(C11F8134_CheckedChanged);
		this.btnQuanLyKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnQuanLyKichBan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnQuanLyKichBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnQuanLyKichBan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnQuanLyKichBan.Location = new System.Drawing.Point(278, 23);
		this.btnQuanLyKichBan.Name = "btnQuanLyKichBan";
		this.btnQuanLyKichBan.Size = new System.Drawing.Size(112, 25);
		this.btnQuanLyKichBan.TabIndex = 1;
		this.btnQuanLyKichBan.Text = "Quản lý kịch bản";
		this.btnQuanLyKichBan.Click += new System.EventHandler(btnQuanLyKichBan_Click);
		this.ckbRandomHanhDong.AutoSize = true;
		this.ckbRandomHanhDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRandomHanhDong.Location = new System.Drawing.Point(12, 52);
		this.ckbRandomHanhDong.Name = "ckbRandomHanhDong";
		this.ckbRandomHanhDong.Size = new System.Drawing.Size(199, 20);
		this.ckbRandomHanhDong.TabIndex = 2;
		this.ckbRandomHanhDong.Text = "Random thứ tự các hành động";
		this.ckbRandomHanhDong.UseVisualStyleBackColor = true;
		this.cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbKichBan.DropDownWidth = 300;
		this.cbbKichBan.FormattingEnabled = true;
		this.cbbKichBan.Location = new System.Drawing.Point(108, 23);
		this.cbbKichBan.Name = "cbbKichBan";
		this.cbbKichBan.Size = new System.Drawing.Size(164, 24);
		this.cbbKichBan.TabIndex = 1;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(12, 51);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(110, 16);
		this.label3.TabIndex = 3;
		this.label3.Text = "Trang đăng nhâ\u0323p:";
		this.B2B53532.AutoSize = true;
		this.B2B53532.Location = new System.Drawing.Point(11, 21);
		this.B2B53532.Name = "label2";
		this.B2B53532.Size = new System.Drawing.Size(100, 16);
		this.B2B53532.TabIndex = 3;
		this.B2B53532.Text = "Kiểu đăng nhâ\u0323p:";
		this.EE81321A.AutoSize = true;
		this.EE81321A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EE81321A.Location = new System.Drawing.Point(18, 22);
		this.EE81321A.Name = "ckbCreateProfile";
		this.EE81321A.Size = new System.Drawing.Size(183, 20);
		this.EE81321A.TabIndex = 2;
		this.EE81321A.Text = "Tự động lưu profile chrome";
		this.EE81321A.UseVisualStyleBackColor = true;
		this.A01B9023.AutoSize = true;
		this.A01B9023.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A01B9023.Location = new System.Drawing.Point(230, 22);
		this.A01B9023.Name = "ckbGetCookie";
		this.A01B9023.Size = new System.Drawing.Size(186, 20);
		this.A01B9023.TabIndex = 2;
		this.A01B9023.Text = "Tự động lấy Cookie khi chạy";
		this.A01B9023.UseVisualStyleBackColor = true;
		this.ckbRepeatAll.AutoSize = true;
		this.ckbRepeatAll.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRepeatAll.Location = new System.Drawing.Point(18, 234);
		this.ckbRepeatAll.Name = "ckbRepeatAll";
		this.ckbRepeatAll.Size = new System.Drawing.Size(344, 20);
		this.ckbRepeatAll.TabIndex = 2;
		this.ckbRepeatAll.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
		this.ckbRepeatAll.UseVisualStyleBackColor = true;
		this.ckbRepeatAll.CheckedChanged += new System.EventHandler(ckbRepeatAll_CheckedChanged);
		this.C4BC71BD.AutoSize = true;
		this.C4BC71BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C4BC71BD.Location = new System.Drawing.Point(227, 104);
		this.C4BC71BD.Name = "ckbAllowFollow";
		this.C4BC71BD.Size = new System.Drawing.Size(187, 20);
		this.C4BC71BD.TabIndex = 2;
		this.C4BC71BD.Text = "Cho phe\u0301p ngươ\u0300i kha\u0301c Follow";
		this.C4BC71BD.UseVisualStyleBackColor = true;
		this.E612C090.AutoSize = true;
		this.E612C090.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E612C090.Location = new System.Drawing.Point(227, 156);
		this.E612C090.Name = "ckbCongKhaiBanBe";
		this.E612C090.Size = new System.Drawing.Size(187, 20);
		this.E612C090.TabIndex = 2;
		this.E612C090.Text = "Công khai danh sách bạn bè";
		this.E612C090.UseVisualStyleBackColor = true;
		this.E612C090.CheckedChanged += new System.EventHandler(CD39A98D_CheckedChanged);
		this.ckbLogOut.AutoSize = true;
		this.ckbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLogOut.Location = new System.Drawing.Point(230, 48);
		this.ckbLogOut.Name = "ckbLogOut";
		this.ckbLogOut.Size = new System.Drawing.Size(186, 20);
		this.ckbLogOut.TabIndex = 2;
		this.ckbLogOut.Text = "Đăng xuất sau khi tương tác";
		this.ckbLogOut.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.AutoSize = true;
		this.ckbCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCapNhatThongTin.Location = new System.Drawing.Point(18, 48);
		this.ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
		this.ckbCapNhatThongTin.Size = new System.Drawing.Size(181, 20);
		this.ckbCapNhatThongTin.TabIndex = 2;
		this.ckbCapNhatThongTin.Text = "Tự động cập nhật thông tin";
		this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.CheckedChanged += new System.EventHandler(ckbCapNhatThongTin_CheckedChanged);
		this.D68A930A.AutoSize = true;
		this.D68A930A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D68A930A.Location = new System.Drawing.Point(16, 80);
		this.D68A930A.Name = "ckbGetToken";
		this.D68A930A.Size = new System.Drawing.Size(84, 20);
		this.D68A930A.TabIndex = 2;
		this.D68A930A.Text = "Get Token";
		this.D68A930A.UseVisualStyleBackColor = true;
		this.D68A930A.CheckedChanged += new System.EventHandler(A69C4018);
		this.D68A930A.Click += new System.EventHandler(D68A930A_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.FD99239F);
		this.panel1.Controls.Add(this.B5AC6737);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.C5B98B86);
		this.panel1.Controls.Add(this.B5379BBB);
		this.panel1.Controls.Add(this.E4A2132F);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(879, 427);
		this.panel1.TabIndex = 8;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(E2849DAF);
		this.FD99239F.Controls.Add(this.E612C090);
		this.FD99239F.Controls.Add(this.E6271AA7);
		this.FD99239F.Controls.Add(this.lblSelectBackupDB);
		this.FD99239F.Controls.Add(this.B2B53532);
		this.FD99239F.Controls.Add(this.cbbTypeLogin);
		this.FD99239F.Controls.Add(this.label3);
		this.FD99239F.Controls.Add(this.cbbFacebookWeb);
		this.FD99239F.Controls.Add(this.D68A930A);
		this.FD99239F.Controls.Add(this.B5B7DD18);
		this.FD99239F.Controls.Add(this.C4BC71BD);
		this.FD99239F.Controls.Add(this.ckbBackupDB);
		this.FD99239F.Controls.Add(this.ckbReviewTag);
		this.FD99239F.Controls.Add(this.A1A4C321);
		this.FD99239F.Controls.Add(this.ckbCauHinhTaiKhoan);
		this.FD99239F.Controls.Add(this.ckbDisableChatSettings);
		this.FD99239F.Controls.Add(this.CD39A98D);
		this.FD99239F.Location = new System.Drawing.Point(446, 45);
		this.FD99239F.Name = "groupBox3";
		this.FD99239F.Size = new System.Drawing.Size(421, 182);
		this.FD99239F.TabIndex = 11;
		this.FD99239F.TabStop = false;
		this.FD99239F.Text = "Cấu hình nâng cao";
		this.E6271AA7.AutoSize = true;
		this.E6271AA7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E6271AA7.Location = new System.Drawing.Point(145, 156);
		this.E6271AA7.Name = "ckbWallPosts";
		this.E6271AA7.Size = new System.Drawing.Size(113, 20);
		this.E6271AA7.TabIndex = 0;
		this.E6271AA7.Text = "Wall Posts (ẩn)";
		this.E6271AA7.UseVisualStyleBackColor = true;
		this.lblSelectBackupDB.AutoSize = true;
		this.lblSelectBackupDB.Location = new System.Drawing.Point(349, 81);
		this.lblSelectBackupDB.Name = "lblSelectBackupDB";
		this.lblSelectBackupDB.Size = new System.Drawing.Size(42, 16);
		this.lblSelectBackupDB.TabIndex = 11;
		this.lblSelectBackupDB.TabStop = true;
		this.lblSelectBackupDB.Text = "Select";
		this.lblSelectBackupDB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lblSelectBackupDB_LinkClicked);
		this.cbbTypeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeLogin.DropDownWidth = 120;
		this.cbbTypeLogin.FormattingEnabled = true;
		this.cbbTypeLogin.Items.AddRange(new object[4] { "Uid|Pass", "Email|Pass", "Cookie", "Cookie>Pass" });
		this.cbbTypeLogin.Location = new System.Drawing.Point(132, 18);
		this.cbbTypeLogin.Name = "cbbTypeLogin";
		this.cbbTypeLogin.Size = new System.Drawing.Size(169, 24);
		this.cbbTypeLogin.TabIndex = 10;
		this.cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbFacebookWeb.DropDownWidth = 120;
		this.cbbFacebookWeb.FormattingEnabled = true;
		this.cbbFacebookWeb.Items.AddRange(new object[4] { "m.fb", "www", "mbasic", "www->m.fb" });
		this.cbbFacebookWeb.Location = new System.Drawing.Point(132, 48);
		this.cbbFacebookWeb.Name = "cbbFacebookWeb";
		this.cbbFacebookWeb.Size = new System.Drawing.Size(169, 24);
		this.cbbFacebookWeb.TabIndex = 10;
		this.B5B7DD18.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5B7DD18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.B5B7DD18.DropDownWidth = 120;
		this.B5B7DD18.FormattingEnabled = true;
		this.B5B7DD18.Items.AddRange(new object[3] { "EAAG", "EAABw", "EAABs" });
		this.B5B7DD18.Location = new System.Drawing.Point(100, 78);
		this.B5B7DD18.Name = "cbbGetToken";
		this.B5B7DD18.Size = new System.Drawing.Size(96, 24);
		this.B5B7DD18.TabIndex = 10;
		this.ckbBackupDB.AutoSize = true;
		this.ckbBackupDB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBackupDB.Location = new System.Drawing.Point(227, 80);
		this.ckbBackupDB.Name = "ckbBackupDB";
		this.ckbBackupDB.Size = new System.Drawing.Size(127, 20);
		this.ckbBackupDB.TabIndex = 9;
		this.ckbBackupDB.Text = "Backup Database ";
		this.ckbBackupDB.UseVisualStyleBackColor = true;
		this.ckbBackupDB.CheckedChanged += new System.EventHandler(D40E6101);
		this.ckbReviewTag.AutoSize = true;
		this.ckbReviewTag.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbReviewTag.Location = new System.Drawing.Point(16, 104);
		this.ckbReviewTag.Name = "ckbReviewTag";
		this.ckbReviewTag.Size = new System.Drawing.Size(188, 20);
		this.ckbReviewTag.TabIndex = 2;
		this.ckbReviewTag.Text = "Bật duyệt bài viết trên tường";
		this.ckbReviewTag.UseVisualStyleBackColor = true;
		this.A1A4C321.AutoSize = true;
		this.A1A4C321.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1A4C321.Location = new System.Drawing.Point(227, 130);
		this.A1A4C321.Name = "ckbXoaCache";
		this.A1A4C321.Size = new System.Drawing.Size(169, 20);
		this.A1A4C321.TabIndex = 9;
		this.A1A4C321.Text = "Xoá cache trước khi chạy";
		this.A1A4C321.UseVisualStyleBackColor = true;
		this.ckbCauHinhTaiKhoan.AutoSize = true;
		this.ckbCauHinhTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCauHinhTaiKhoan.Location = new System.Drawing.Point(16, 156);
		this.ckbCauHinhTaiKhoan.Name = "ckbCauHinhTaiKhoan";
		this.ckbCauHinhTaiKhoan.Size = new System.Drawing.Size(132, 20);
		this.ckbCauHinhTaiKhoan.TabIndex = 8;
		this.ckbCauHinhTaiKhoan.Text = "Cấu hình tài khoản";
		this.ckbCauHinhTaiKhoan.UseVisualStyleBackColor = true;
		this.ckbDisableChatSettings.AutoSize = true;
		this.ckbDisableChatSettings.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDisableChatSettings.Location = new System.Drawing.Point(112, 130);
		this.ckbDisableChatSettings.Name = "ckbDisableChatSettings";
		this.ckbDisableChatSettings.Size = new System.Drawing.Size(140, 20);
		this.ckbDisableChatSettings.TabIndex = 2;
		this.ckbDisableChatSettings.Text = "Tắt Popup chat (ẩn)";
		this.ckbDisableChatSettings.UseVisualStyleBackColor = true;
		this.ckbDisableChatSettings.CheckedChanged += new System.EventHandler(CD39A98D_CheckedChanged);
		this.CD39A98D.AutoSize = true;
		this.CD39A98D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CD39A98D.Location = new System.Drawing.Point(16, 130);
		this.CD39A98D.Name = "ckbCheckSpam";
		this.CD39A98D.Size = new System.Drawing.Size(95, 20);
		this.CD39A98D.TabIndex = 2;
		this.CD39A98D.Text = "Check spam";
		this.CD39A98D.UseVisualStyleBackColor = true;
		this.CD39A98D.CheckedChanged += new System.EventHandler(CD39A98D_CheckedChanged);
		this.C5B98B86.Controls.Add(this.A22E3085);
		this.C5B98B86.Controls.Add(this.EE81321A);
		this.C5B98B86.Controls.Add(this.F22BD89B);
		this.C5B98B86.Controls.Add(this.ckbLogOut);
		this.C5B98B86.Controls.Add(this.plRepeatAll);
		this.C5B98B86.Controls.Add(this.ckbRepeatAll);
		this.C5B98B86.Controls.Add(this.A01B9023);
		this.C5B98B86.Controls.Add(this.ckbCapNhatThongTin);
		this.C5B98B86.Controls.Add(this.F9B43D09);
		this.C5B98B86.Controls.Add(this.ckbDontSaveBrowser);
		this.C5B98B86.Location = new System.Drawing.Point(11, 45);
		this.C5B98B86.Name = "groupBox1";
		this.C5B98B86.Size = new System.Drawing.Size(429, 326);
		this.C5B98B86.TabIndex = 10;
		this.C5B98B86.TabStop = false;
		this.C5B98B86.Text = "Cấu hình cơ bản";
		this.A22E3085.AutoSize = true;
		this.A22E3085.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A22E3085.Location = new System.Drawing.Point(18, 211);
		this.A22E3085.Name = "ckbRandomThuTuTaiKhoan";
		this.A22E3085.Size = new System.Drawing.Size(254, 20);
		this.A22E3085.TabIndex = 15;
		this.A22E3085.Text = "Xáo trộn thứ tự tài khoản trước khi chạy";
		this.A22E3085.UseVisualStyleBackColor = true;
		this.F22BD89B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F22BD89B.Controls.Add(this.CB84C11F);
		this.F22BD89B.Controls.Add(this.ckbLocation);
		this.F22BD89B.Controls.Add(this.ckbNgayTao);
		this.F22BD89B.Controls.Add(this.ckbPagePro5);
		this.F22BD89B.Controls.Add(this.B03BFD05);
		this.F22BD89B.Controls.Add(this.FE8BC096);
		this.F22BD89B.Controls.Add(this.ckbBM);
		this.F22BD89B.Controls.Add(this.ckbFbBlock);
		this.F22BD89B.Controls.Add(this.ckbAds);
		this.F22BD89B.Controls.Add(this.D793EBAD);
		this.F22BD89B.Controls.Add(this.ckbAvatar);
		this.F22BD89B.Controls.Add(this.ckbPhone);
		this.F22BD89B.Controls.Add(this.ckbFollow);
		this.F22BD89B.Controls.Add(this.B5A1B002);
		this.F22BD89B.Controls.Add(this.D1B24B37);
		this.F22BD89B.Controls.Add(this.D29350A5);
		this.F22BD89B.Controls.Add(this.ckbGender);
		this.F22BD89B.Controls.Add(this.C1245DB5);
		this.F22BD89B.Location = new System.Drawing.Point(18, 75);
		this.F22BD89B.Name = "plCapNhatThongTin";
		this.F22BD89B.Size = new System.Drawing.Size(396, 107);
		this.F22BD89B.TabIndex = 14;
		this.CB84C11F.AutoSize = true;
		this.CB84C11F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CB84C11F.Location = new System.Drawing.Point(95, 82);
		this.CB84C11F.Name = "ckbHometown";
		this.CB84C11F.Size = new System.Drawing.Size(163, 20);
		this.CB84C11F.TabIndex = 0;
		this.CB84C11F.Text = "Hometown, Current City";
		this.CB84C11F.UseVisualStyleBackColor = true;
		this.ckbLocation.AutoSize = true;
		this.ckbLocation.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLocation.Location = new System.Drawing.Point(4, 82);
		this.ckbLocation.Name = "ckbLocation";
		this.ckbLocation.Size = new System.Drawing.Size(73, 20);
		this.ckbLocation.TabIndex = 0;
		this.ckbLocation.Text = "Location";
		this.ckbLocation.UseVisualStyleBackColor = true;
		this.ckbNgayTao.AutoSize = true;
		this.ckbNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNgayTao.Location = new System.Drawing.Point(282, 4);
		this.ckbNgayTao.Name = "ckbNgayTao";
		this.ckbNgayTao.Size = new System.Drawing.Size(76, 20);
		this.ckbNgayTao.TabIndex = 0;
		this.ckbNgayTao.Text = "Ngày tạo";
		this.ckbNgayTao.UseVisualStyleBackColor = true;
		this.ckbPagePro5.AutoSize = true;
		this.ckbPagePro5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbPagePro5.Location = new System.Drawing.Point(67, 56);
		this.ckbPagePro5.Name = "ckbPagePro5";
		this.ckbPagePro5.Size = new System.Drawing.Size(84, 20);
		this.ckbPagePro5.TabIndex = 1;
		this.ckbPagePro5.Text = "Page pro5";
		this.ckbPagePro5.UseVisualStyleBackColor = true;
		this.B03BFD05.AutoSize = true;
		this.B03BFD05.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B03BFD05.Location = new System.Drawing.Point(4, 56);
		this.B03BFD05.Name = "ckbPage";
		this.B03BFD05.Size = new System.Drawing.Size(54, 20);
		this.B03BFD05.TabIndex = 1;
		this.B03BFD05.Text = "Page";
		this.B03BFD05.UseVisualStyleBackColor = true;
		this.FE8BC096.AutoSize = true;
		this.FE8BC096.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FE8BC096.Location = new System.Drawing.Point(216, 4);
		this.FE8BC096.Name = "ckbEmail";
		this.FE8BC096.Size = new System.Drawing.Size(57, 20);
		this.FE8BC096.TabIndex = 1;
		this.FE8BC096.Text = "Email";
		this.FE8BC096.UseVisualStyleBackColor = true;
		this.ckbBM.AutoSize = true;
		this.ckbBM.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBM.Location = new System.Drawing.Point(156, 56);
		this.ckbBM.Name = "ckbBM";
		this.ckbBM.Size = new System.Drawing.Size(43, 20);
		this.ckbBM.TabIndex = 0;
		this.ckbBM.Text = "BM";
		this.ckbBM.UseVisualStyleBackColor = true;
		this.ckbFbBlock.AutoSize = true;
		this.ckbFbBlock.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFbBlock.Location = new System.Drawing.Point(282, 82);
		this.ckbFbBlock.Name = "ckbFbBlock";
		this.ckbFbBlock.Size = new System.Drawing.Size(73, 20);
		this.ckbFbBlock.TabIndex = 0;
		this.ckbFbBlock.Text = "Fb Block";
		this.ckbFbBlock.UseVisualStyleBackColor = true;
		this.ckbAds.AutoSize = true;
		this.ckbAds.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAds.Location = new System.Drawing.Point(282, 56);
		this.ckbAds.Name = "ckbAds";
		this.ckbAds.Size = new System.Drawing.Size(47, 20);
		this.ckbAds.TabIndex = 0;
		this.ckbAds.Text = "Ads";
		this.ckbAds.UseVisualStyleBackColor = true;
		this.D793EBAD.AutoSize = true;
		this.D793EBAD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D793EBAD.Location = new System.Drawing.Point(216, 56);
		this.D793EBAD.Name = "ckbDating";
		this.D793EBAD.Size = new System.Drawing.Size(62, 20);
		this.D793EBAD.TabIndex = 0;
		this.D793EBAD.Text = "Dating";
		this.D793EBAD.UseVisualStyleBackColor = true;
		this.ckbAvatar.AutoSize = true;
		this.ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAvatar.Location = new System.Drawing.Point(282, 30);
		this.ckbAvatar.Name = "ckbAvatar";
		this.ckbAvatar.Size = new System.Drawing.Size(63, 20);
		this.ckbAvatar.TabIndex = 0;
		this.ckbAvatar.Text = "Avatar";
		this.ckbAvatar.UseVisualStyleBackColor = true;
		this.ckbPhone.AutoSize = true;
		this.ckbPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbPhone.Location = new System.Drawing.Point(216, 30);
		this.ckbPhone.Name = "ckbPhone";
		this.ckbPhone.Size = new System.Drawing.Size(61, 20);
		this.ckbPhone.TabIndex = 0;
		this.ckbPhone.Text = "Phone";
		this.ckbPhone.UseVisualStyleBackColor = true;
		this.ckbFollow.AutoSize = true;
		this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFollow.Location = new System.Drawing.Point(140, 30);
		this.ckbFollow.Name = "ckbFollow";
		this.ckbFollow.Size = new System.Drawing.Size(63, 20);
		this.ckbFollow.TabIndex = 0;
		this.ckbFollow.Text = "Follow";
		this.ckbFollow.UseVisualStyleBackColor = true;
		this.B5A1B002.AutoSize = true;
		this.B5A1B002.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5A1B002.Location = new System.Drawing.Point(67, 30);
		this.B5A1B002.Name = "ckbGroup";
		this.B5A1B002.Size = new System.Drawing.Size(60, 20);
		this.B5A1B002.TabIndex = 0;
		this.B5A1B002.Text = "Group";
		this.B5A1B002.UseVisualStyleBackColor = true;
		this.B5A1B002.Click += new System.EventHandler(ACAE04A0);
		this.D1B24B37.AutoSize = true;
		this.D1B24B37.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D1B24B37.Location = new System.Drawing.Point(4, 30);
		this.D1B24B37.Name = "ckbFriend";
		this.D1B24B37.Size = new System.Drawing.Size(62, 20);
		this.D1B24B37.TabIndex = 0;
		this.D1B24B37.Text = "Friend";
		this.D1B24B37.UseVisualStyleBackColor = true;
		this.D29350A5.AutoSize = true;
		this.D29350A5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D29350A5.Location = new System.Drawing.Point(140, 4);
		this.D29350A5.Name = "ckbBirthday";
		this.D29350A5.Size = new System.Drawing.Size(72, 20);
		this.D29350A5.TabIndex = 0;
		this.D29350A5.Text = "Birthday";
		this.D29350A5.UseVisualStyleBackColor = true;
		this.ckbGender.AutoSize = true;
		this.ckbGender.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGender.Location = new System.Drawing.Point(67, 4);
		this.ckbGender.Name = "ckbGender";
		this.ckbGender.Size = new System.Drawing.Size(72, 20);
		this.ckbGender.TabIndex = 0;
		this.ckbGender.Text = "Giới tính";
		this.ckbGender.UseVisualStyleBackColor = true;
		this.C1245DB5.AutoSize = true;
		this.C1245DB5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C1245DB5.Location = new System.Drawing.Point(4, 4);
		this.C1245DB5.Name = "ckbName";
		this.C1245DB5.Size = new System.Drawing.Size(59, 20);
		this.C1245DB5.TabIndex = 0;
		this.C1245DB5.Text = "Name";
		this.C1245DB5.UseVisualStyleBackColor = true;
		this.plRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plRepeatAll.Controls.Add(this.label6);
		this.plRepeatAll.Controls.Add(this.label4);
		this.plRepeatAll.Controls.Add(this.nudDelayTurnFrom);
		this.plRepeatAll.Controls.Add(this.A01C5517);
		this.plRepeatAll.Controls.Add(this.B60B9FAF);
		this.plRepeatAll.Controls.Add(this.B68E0B92);
		this.plRepeatAll.Controls.Add(this.nudSoLuotChay);
		this.plRepeatAll.Controls.Add(this.AE2FC510);
		this.plRepeatAll.Location = new System.Drawing.Point(38, 256);
		this.plRepeatAll.Name = "plRepeatAll";
		this.plRepeatAll.Size = new System.Drawing.Size(376, 64);
		this.plRepeatAll.TabIndex = 13;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 8);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(83, 16);
		this.label6.TabIndex = 5;
		this.label6.Text = "Sô\u0301 lươ\u0323t cha\u0323y:";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(3, 36);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(144, 16);
		this.label4.TabIndex = 6;
		this.label4.Text = "Chờ cha\u0323y lươ\u0323t tiê\u0301p theo:";
		this.nudDelayTurnFrom.Location = new System.Drawing.Point(154, 34);
		this.nudDelayTurnFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudDelayTurnFrom.Name = "nudDelayTurnFrom";
		this.nudDelayTurnFrom.Size = new System.Drawing.Size(65, 23);
		this.nudDelayTurnFrom.TabIndex = 9;
		this.A01C5517.Location = new System.Drawing.Point(222, 9);
		this.A01C5517.Name = "label5";
		this.A01C5517.Size = new System.Drawing.Size(30, 16);
		this.A01C5517.TabIndex = 10;
		this.A01C5517.Text = "lươ\u0323t";
		this.A01C5517.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A01C5517.Click += new System.EventHandler(BA278307);
		this.B60B9FAF.Location = new System.Drawing.Point(252, 34);
		this.B60B9FAF.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.B60B9FAF.Name = "nudDelayTurnTo";
		this.B60B9FAF.Size = new System.Drawing.Size(65, 23);
		this.B60B9FAF.TabIndex = 8;
		this.B68E0B92.AutoSize = true;
		this.B68E0B92.Location = new System.Drawing.Point(320, 37);
		this.B68E0B92.Name = "label11";
		this.B68E0B92.Size = new System.Drawing.Size(32, 16);
		this.B68E0B92.TabIndex = 11;
		this.B68E0B92.Text = "phút";
		this.nudSoLuotChay.Location = new System.Drawing.Point(154, 6);
		this.nudSoLuotChay.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudSoLuotChay.Name = "nudSoLuotChay";
		this.nudSoLuotChay.Size = new System.Drawing.Size(65, 23);
		this.nudSoLuotChay.TabIndex = 7;
		this.AE2FC510.Location = new System.Drawing.Point(222, 37);
		this.AE2FC510.Name = "label10";
		this.AE2FC510.Size = new System.Drawing.Size(29, 16);
		this.AE2FC510.TabIndex = 12;
		this.AE2FC510.Text = "đến";
		this.AE2FC510.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F9B43D09.AutoSize = true;
		this.F9B43D09.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F9B43D09.Location = new System.Drawing.Point(18, 188);
		this.F9B43D09.Name = "ckbCheckLiveUid";
		this.F9B43D09.Size = new System.Drawing.Size(171, 20);
		this.F9B43D09.TabIndex = 2;
		this.F9B43D09.Text = "Check wall trước khi chạy";
		this.F9B43D09.UseVisualStyleBackColor = true;
		this.ckbDontSaveBrowser.AutoSize = true;
		this.ckbDontSaveBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDontSaveBrowser.Location = new System.Drawing.Point(224, 188);
		this.ckbDontSaveBrowser.Name = "ckbDontSaveBrowser";
		this.ckbDontSaveBrowser.Size = new System.Drawing.Size(199, 20);
		this.ckbDontSaveBrowser.TabIndex = 2;
		this.ckbDontSaveBrowser.Text = "Không lưu trình duyệt khi login";
		this.ckbDontSaveBrowser.UseVisualStyleBackColor = true;
		this.B5379BBB.AutoSize = true;
		this.B5379BBB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5379BBB.Location = new System.Drawing.Point(923, 554);
		this.B5379BBB.Name = "ckbCheckBanBeGoiY";
		this.B5379BBB.Size = new System.Drawing.Size(134, 20);
		this.B5379BBB.TabIndex = 9;
		this.B5379BBB.Text = "Check bạn bè gợi ý";
		this.B5379BBB.UseVisualStyleBackColor = true;
		this.B5379BBB.Visible = false;
		this.E4A2132F.AutoSize = true;
		this.E4A2132F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E4A2132F.Location = new System.Drawing.Point(928, 535);
		this.E4A2132F.Name = "ckbBatThongBaoDangNhap";
		this.E4A2132F.Size = new System.Drawing.Size(169, 20);
		this.E4A2132F.TabIndex = 7;
		this.E4A2132F.Text = "Bật thông báo đăng nhập";
		this.E4A2132F.UseVisualStyleBackColor = true;
		this.E4A2132F.Visible = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(879, 427);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTuongTac_Old";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(A604E73C_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plGioiHanThoiGianChayKichBan.ResumeLayout(false);
		this.plGioiHanThoiGianChayKichBan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F899BE87).EndInit();
		this.plGioiHanThoiGianChayTaiKhoan.ResumeLayout(false);
		this.plGioiHanThoiGianChayTaiKhoan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanFrom).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.FD99239F.ResumeLayout(false);
		this.FD99239F.PerformLayout();
		this.C5B98B86.ResumeLayout(false);
		this.C5B98B86.PerformLayout();
		this.F22BD89B.ResumeLayout(false);
		this.F22BD89B.PerformLayout();
		this.plRepeatAll.ResumeLayout(false);
		this.plRepeatAll.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B60B9FAF).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).EndInit();
		base.ResumeLayout(false);
	}
}
