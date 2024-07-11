using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTuongTac : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel D488BB0E;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button BB88522D;

	private Button D796C312;

	private Button btnAdd;

	private BunifuDragControl CF32702B;

	private PictureBox pictureBox1;

	private CheckBox AFACC218;

	private CheckBox ckbGetCookie;

	private CheckBox ckbCapNhatThongTin;

	private CheckBox CA110CB2;

	private Panel panel1;

	private CheckBox ckbLogOut;

	private CheckBox E381E83E;

	private Label FF27BE17;

	private Label F9882390;

	private CheckBox ckbAllowFollow;

	private CheckBox C5202DA4;

	private CheckBox ckbCheckLiveUid;

	private CheckBox ckbDontSaveBrowser;

	private CheckBox ckbBatThongBaoDangNhap;

	private CheckBox DC2496A9;

	private CheckBox ckbXoaCache;

	private Panel plCapNhatThongTin;

	private CheckBox ckbEmail;

	private CheckBox D332013C;

	private CheckBox BB3702B3;

	private CheckBox ckbFriend;

	private CheckBox ckbNgayTao;

	private CheckBox ckbBirthday;

	private CheckBox ckbGender;

	private CheckBox ckbName;

	private CheckBox F38E65A5;

	private CheckBox ckbCheckSpam;

	private CheckBox ckbPhone;

	private ComboBox cbbGetToken;

	private ComboBox cbbTypeLogin;

	private ComboBox AA1D3282;

	private CheckBox ckbAvatar;

	private CheckBox BC8DB68F;

	private CheckBox ckbLocation;

	private CheckBox ckbPage;

	private CheckBox B505AB2D;

	private CheckBox ckbAds;

	private CheckBox ckbDating;

	private CheckBox A884BCAF;

	private CheckBox ckbHometown;

	private CheckBox ckbDisableChatSettings;

	private CheckBox ckbWallPosts;

	private CheckBox ckbFbBlock;

	private GroupBox grLogin;

	private GroupBox groupBox6;

	private GroupBox C696B30A;

	private Button DD32B702;

	private Button button1;

	private CheckBox ckbCapNhatThongTinTruocKhiTuongTac;

	private GroupBox groupBox2;

	private Panel D8842515;

	private Label FC2799B0;

	private ComboBox cbbKichBan;

	private Button btnQuanLyKichBan;

	private CheckBox ckbChayKichBanDaGan;

	private Button btnDown;

	private Button btnUp;

	private Panel plGioiHanThoiGianChayKichBan;

	private Label E40ADC1D;

	private NumericUpDown nudThoiGianChayKichBanTo;

	private NumericUpDown nudThoiGianChayKichBanFrom;

	private Panel D430E69B;

	private Label label6;

	private Label label4;

	private NumericUpDown nudDelayTurnFrom;

	private Label A1B1FF3E;

	private NumericUpDown ACB22CAE;

	private Label D4A962A7;

	private NumericUpDown nudSoLuotChay;

	private Label label10;

	private Panel plGioiHanThoiGianChayTaiKhoan;

	private Label EF067D26;

	private NumericUpDown nudThoiGianChayTaiKhoanTo;

	private NumericUpDown nudThoiGianChayTaiKhoanFrom;

	private CheckBox E6138415;

	private CheckBox E89C7334;

	private CheckBox ckbGioiHanThoiGianChayTaiKhoan;

	private CheckBox D103D4B7;

	public fCauHinhTuongTac()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void B5AE6E0E(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			ckbChayKichBanDaGan.Visible = true;
		}
		else
		{
			Close();
		}
	}

	private void C9222F2C(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configInteractGeneral").GetJson("typeLogin", cbbTypeLogin.SelectedIndex);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("typeBrowserLogin", AA1D3282.SelectedIndex);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCreateProfile", AFACC218.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGetToken", CA110CB2.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("typeToken", cbbGetToken.SelectedIndex);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGetCookie", ckbGetCookie.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCapNhatThongTin", ckbCapNhatThongTin.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCapNhatThongTinTruocKhiTuongTac", ckbCapNhatThongTinTruocKhiTuongTac.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbName", ckbName.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGender", ckbGender.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBirthday", ckbBirthday.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbNgayTao", ckbNgayTao.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbEmail", ckbEmail.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbFriend", ckbFriend.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGroup", BB3702B3.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbPage", ckbPage.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbPagePro5", A884BCAF.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbFollow", D332013C.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbPhone", ckbPhone.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbAvatar", ckbAvatar.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbDating", ckbDating.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbAds", ckbAds.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBM", B505AB2D.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbLocation", ckbLocation.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbHometown", ckbHometown.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbFbBlock", ckbFbBlock.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCheckLiveUid", ckbCheckLiveUid.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbDontSaveBrowser", ckbDontSaveBrowser.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbRepeatAll", E89C7334.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudDelayTurnFrom", nudDelayTurnFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudDelayTurnTo", ACB22CAE.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudSoLuotChay", nudSoLuotChay.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("RepeatAllVIP", "false");
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbLogOut", ckbLogOut.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbAllowFollow", ckbAllowFollow.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbReviewTag", C5202DA4.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbBatThongBaoDangNhap", ckbBatThongBaoDangNhap.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCauHinhTaiKhoan", DC2496A9.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbWallPosts", ckbWallPosts.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCheckSpam", ckbCheckSpam.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCongKhaiBanBe", E381E83E.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbRandomThuTuTaiKhoan", BC8DB68F.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbChayKichBanDaGan", ckbChayKichBanDaGan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("cbbKichBan", cbbKichBan.SelectedValue);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbRandomHanhDong", D103D4B7.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbXoaCache", ckbXoaCache.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbCheckBanBeGoiY", F38E65A5.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGioiHanThoiGianChayTaiKhoan", ckbGioiHanThoiGianChayTaiKhoan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayTaiKhoanFrom", nudThoiGianChayTaiKhoanFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayTaiKhoanTo", nudThoiGianChayTaiKhoanTo.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("ckbGioiHanThoiGianChayKichBan", E6138415.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayKichBanFrom", nudThoiGianChayKichBanFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetJson("nudThoiGianChayKichBanTo", nudThoiGianChayKichBanTo.Value);
		SettingsTool.Save("configInteractGeneral");
		if (MessageBoxHelper.ShowMessages("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void D796C312_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnQuanLyKichBan_Click(object sender, EventArgs e)
	{
		string string_ = "";
		try
		{
			if (cbbKichBan.Items.Count > 0)
			{
				string_ = cbbKichBan.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		Common.ShowForm(new fDanhSachKichBan_Old(string_));
		method_2();
	}

	private void D60E030A(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
		D60E030A(null, null);
		method_0(null, null);
		E89C7334_CheckedChanged(null, null);
		ckbCapNhatThongTinTruocKhiTuongTac_CheckedChanged(null, null);
		ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(null, null);
		E6138415_CheckedChanged(null, null);
		CA110CB2_CheckedChanged(null, null);
		ckbChayKichBanDaGan_CheckedChanged(null, null);
	}

	private void fCauHinhTuongTac_Load(object sender, EventArgs e)
	{
		method_2();
		D2ACB492();
		method_1();
	}

	private void D2ACB492()
	{
		try
		{
			cbbTypeLogin.SelectedIndex = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeLogin");
			AA1D3282.SelectedIndex = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeBrowserLogin");
			AFACC218.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCreateProfile");
			CA110CB2.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetToken");
			cbbGetToken.SelectedIndex = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("typeToken");
			ckbGetCookie.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGetCookie");
			ckbCapNhatThongTin.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCapNhatThongTin");
			ckbCapNhatThongTinTruocKhiTuongTac.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCapNhatThongTinTruocKhiTuongTac");
			ckbName.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbName");
			ckbGender.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGender");
			ckbBirthday.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBirthday");
			ckbNgayTao.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbNgayTao");
			ckbEmail.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbEmail");
			ckbFriend.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFriend");
			BB3702B3.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGroup");
			ckbPage.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPage");
			A884BCAF.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPagePro5");
			D332013C.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFollow");
			ckbPhone.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbPhone");
			ckbAvatar.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAvatar");
			ckbDating.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDating");
			ckbAds.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAds");
			B505AB2D.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBM");
			ckbLocation.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbLocation");
			ckbHometown.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbHometown");
			ckbFbBlock.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbFbBlock");
			ckbCheckLiveUid.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckLiveUid");
			ckbDontSaveBrowser.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbDontSaveBrowser");
			E89C7334.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRepeatAll");
			nudDelayTurnFrom.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnFrom");
			ACB22CAE.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudDelayTurnTo");
			int num = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudSoLuotChay", 2);
			nudSoLuotChay.Value = ((num >= 2) ? num : 2);
			ckbLogOut.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbLogOut");
			ckbAllowFollow.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbAllowFollow");
			C5202DA4.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbReviewTag");
			ckbBatThongBaoDangNhap.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbBatThongBaoDangNhap");
			ckbWallPosts.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbWallPosts");
			DC2496A9.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCauHinhTaiKhoan");
			ckbCheckSpam.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckSpam");
			E381E83E.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCongKhaiBanBe");
			BC8DB68F.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomThuTuTaiKhoan");
			ckbChayKichBanDaGan.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbChayKichBanDaGan");
			cbbKichBan.SelectedValue = SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan");
			D103D4B7.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbRandomHanhDong");
			ckbXoaCache.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbXoaCache");
			F38E65A5.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbCheckBanBeGoiY");
			ckbGioiHanThoiGianChayTaiKhoan.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayTaiKhoan");
			nudThoiGianChayTaiKhoanFrom.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayTaiKhoanFrom", 1);
			nudThoiGianChayTaiKhoanTo.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayTaiKhoanTo", 1);
			E6138415.Checked = SettingsTool.GetSettings("configInteractGeneral").GetValueBool("ckbGioiHanThoiGianChayKichBan");
			nudThoiGianChayKichBanFrom.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanFrom", 1);
			nudThoiGianChayKichBanTo.Value = SettingsTool.GetSettings("configInteractGeneral").GetValueInt("nudThoiGianChayKichBanTo", 1);
		}
		catch
		{
		}
	}

	private void method_2()
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

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void ckbCapNhatThongTinTruocKhiTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		plCapNhatThongTin.Enabled = ckbCapNhatThongTin.Checked;
		ckbCapNhatThongTinTruocKhiTuongTac.Enabled = ckbCapNhatThongTin.Checked;
		if (!ckbCapNhatThongTin.Checked)
		{
			ckbCapNhatThongTinTruocKhiTuongTac.Checked = false;
		}
	}

	private void CA110CB2_Click(object sender, EventArgs e)
	{
	}

	private void E89C7334_CheckedChanged(object sender, EventArgs e)
	{
		D430E69B.Enabled = E89C7334.Checked;
	}

	private void ckbCheckSpam_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void E21FEDA9(object sender, EventArgs e)
	{
	}

	private void ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayTaiKhoan.Enabled = ckbGioiHanThoiGianChayTaiKhoan.Checked;
	}

	private void E6138415_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayKichBan.Enabled = E6138415.Checked;
	}

	private void CA110CB2_CheckedChanged(object sender, EventArgs e)
	{
		cbbGetToken.Enabled = CA110CB2.Checked;
	}

	private void BB3702B3_Click(object sender, EventArgs e)
	{
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		base.Height = 510;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		base.Height = 416;
	}

	private void DD32B702_Click(object sender, EventArgs e)
	{
		grLogin.Height = 105;
	}

	private void ED126A9E(object sender, EventArgs e)
	{
		grLogin.Height = 82;
	}

	private void ckbCapNhatThongTin_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			ckbCapNhatThongTinTruocKhiTuongTac.Visible = true;
		}
	}

	private void ckbChayKichBanDaGan_CheckedChanged(object sender, EventArgs e)
	{
		D8842515.Enabled = !ckbChayKichBanDaGan.Checked;
	}

	protected override void Dispose(bool E89F1193)
	{
		if (E89F1193 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E89F1193);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTuongTac));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.D488BB0E = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.BB88522D = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.D796C312 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.CF32702B = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.FF27BE17 = new System.Windows.Forms.Label();
		this.F9882390 = new System.Windows.Forms.Label();
		this.AFACC218 = new System.Windows.Forms.CheckBox();
		this.ckbGetCookie = new System.Windows.Forms.CheckBox();
		this.ckbAllowFollow = new System.Windows.Forms.CheckBox();
		this.E381E83E = new System.Windows.Forms.CheckBox();
		this.ckbLogOut = new System.Windows.Forms.CheckBox();
		this.ckbCapNhatThongTin = new System.Windows.Forms.CheckBox();
		this.CA110CB2 = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox6 = new System.Windows.Forms.GroupBox();
		this.cbbGetToken = new System.Windows.Forms.ComboBox();
		this.ckbWallPosts = new System.Windows.Forms.CheckBox();
		this.ckbDisableChatSettings = new System.Windows.Forms.CheckBox();
		this.ckbCheckSpam = new System.Windows.Forms.CheckBox();
		this.ckbCapNhatThongTinTruocKhiTuongTac = new System.Windows.Forms.CheckBox();
		this.C5202DA4 = new System.Windows.Forms.CheckBox();
		this.DC2496A9 = new System.Windows.Forms.CheckBox();
		this.plCapNhatThongTin = new System.Windows.Forms.Panel();
		this.ckbHometown = new System.Windows.Forms.CheckBox();
		this.ckbLocation = new System.Windows.Forms.CheckBox();
		this.ckbNgayTao = new System.Windows.Forms.CheckBox();
		this.A884BCAF = new System.Windows.Forms.CheckBox();
		this.ckbPage = new System.Windows.Forms.CheckBox();
		this.ckbEmail = new System.Windows.Forms.CheckBox();
		this.B505AB2D = new System.Windows.Forms.CheckBox();
		this.ckbFbBlock = new System.Windows.Forms.CheckBox();
		this.ckbAds = new System.Windows.Forms.CheckBox();
		this.ckbDating = new System.Windows.Forms.CheckBox();
		this.ckbAvatar = new System.Windows.Forms.CheckBox();
		this.ckbPhone = new System.Windows.Forms.CheckBox();
		this.D332013C = new System.Windows.Forms.CheckBox();
		this.BB3702B3 = new System.Windows.Forms.CheckBox();
		this.ckbFriend = new System.Windows.Forms.CheckBox();
		this.ckbBirthday = new System.Windows.Forms.CheckBox();
		this.ckbGender = new System.Windows.Forms.CheckBox();
		this.ckbName = new System.Windows.Forms.CheckBox();
		this.C696B30A = new System.Windows.Forms.GroupBox();
		this.BC8DB68F = new System.Windows.Forms.CheckBox();
		this.ckbCheckLiveUid = new System.Windows.Forms.CheckBox();
		this.ckbXoaCache = new System.Windows.Forms.CheckBox();
		this.grLogin = new System.Windows.Forms.GroupBox();
		this.DD32B702 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.AA1D3282 = new System.Windows.Forms.ComboBox();
		this.cbbTypeLogin = new System.Windows.Forms.ComboBox();
		this.ckbDontSaveBrowser = new System.Windows.Forms.CheckBox();
		this.F38E65A5 = new System.Windows.Forms.CheckBox();
		this.ckbBatThongBaoDangNhap = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.D8842515 = new System.Windows.Forms.Panel();
		this.FC2799B0 = new System.Windows.Forms.Label();
		this.cbbKichBan = new System.Windows.Forms.ComboBox();
		this.btnQuanLyKichBan = new System.Windows.Forms.Button();
		this.ckbChayKichBanDaGan = new System.Windows.Forms.CheckBox();
		this.btnDown = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.plGioiHanThoiGianChayKichBan = new System.Windows.Forms.Panel();
		this.E40ADC1D = new System.Windows.Forms.Label();
		this.nudThoiGianChayKichBanTo = new System.Windows.Forms.NumericUpDown();
		this.nudThoiGianChayKichBanFrom = new System.Windows.Forms.NumericUpDown();
		this.D430E69B = new System.Windows.Forms.Panel();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.nudDelayTurnFrom = new System.Windows.Forms.NumericUpDown();
		this.A1B1FF3E = new System.Windows.Forms.Label();
		this.ACB22CAE = new System.Windows.Forms.NumericUpDown();
		this.D4A962A7 = new System.Windows.Forms.Label();
		this.nudSoLuotChay = new System.Windows.Forms.NumericUpDown();
		this.label10 = new System.Windows.Forms.Label();
		this.plGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.Panel();
		this.EF067D26 = new System.Windows.Forms.Label();
		this.nudThoiGianChayTaiKhoanTo = new System.Windows.Forms.NumericUpDown();
		this.nudThoiGianChayTaiKhoanFrom = new System.Windows.Forms.NumericUpDown();
		this.E6138415 = new System.Windows.Forms.CheckBox();
		this.E89C7334 = new System.Windows.Forms.CheckBox();
		this.ckbGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.CheckBox();
		this.D103D4B7 = new System.Windows.Forms.CheckBox();
		this.bunifuCards1.SuspendLayout();
		this.D488BB0E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox6.SuspendLayout();
		this.plCapNhatThongTin.SuspendLayout();
		this.C696B30A.SuspendLayout();
		this.grLogin.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.D8842515.SuspendLayout();
		this.plGioiHanThoiGianChayKichBan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanFrom).BeginInit();
		this.D430E69B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ACB22CAE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).BeginInit();
		this.plGioiHanThoiGianChayTaiKhoan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanFrom).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.FromArgb(24, 119, 242);
		this.bunifuCards1.Controls.Add(this.D488BB0E);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(2, 1);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(818, 38);
		this.bunifuCards1.TabIndex = 0;
		this.D488BB0E.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D488BB0E.BackColor = System.Drawing.Color.White;
		this.D488BB0E.Controls.Add(this.pictureBox1);
		this.D488BB0E.Controls.Add(this.BB88522D);
		this.D488BB0E.Controls.Add(this.bunifuCustomLabel1);
		this.D488BB0E.Location = new System.Drawing.Point(0, 5);
		this.D488BB0E.Name = "pnlHeader";
		this.D488BB0E.Size = new System.Drawing.Size(818, 32);
		this.D488BB0E.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 78;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.BB88522D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BB88522D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB88522D.FlatAppearance.BorderSize = 0;
		this.BB88522D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BB88522D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BB88522D.ForeColor = System.Drawing.Color.White;
		this.BB88522D.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.BB88522D.Location = new System.Drawing.Point(784, -2);
		this.BB88522D.Name = "btnMinimize";
		this.BB88522D.Size = new System.Drawing.Size(32, 32);
		this.BB88522D.TabIndex = 9;
		this.BB88522D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BB88522D.UseVisualStyleBackColor = true;
		this.BB88522D.Click += new System.EventHandler(B5AE6E0E);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(818, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D796C312.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D796C312.BackColor = System.Drawing.Color.Maroon;
		this.D796C312.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D796C312.FlatAppearance.BorderSize = 0;
		this.D796C312.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D796C312.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D796C312.ForeColor = System.Drawing.Color.White;
		this.D796C312.Location = new System.Drawing.Point(414, 374);
		this.D796C312.Name = "btnCancel";
		this.D796C312.Size = new System.Drawing.Size(92, 29);
		this.D796C312.TabIndex = 4;
		this.D796C312.Text = "Đóng";
		this.D796C312.UseVisualStyleBackColor = false;
		this.D796C312.Click += new System.EventHandler(D796C312_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(316, 374);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(C9222F2C);
		this.CF32702B.Fixed = true;
		this.CF32702B.Horizontal = true;
		this.CF32702B.TargetControl = this.bunifuCustomLabel1;
		this.CF32702B.Vertical = true;
		this.FF27BE17.AutoSize = true;
		this.FF27BE17.Location = new System.Drawing.Point(10, 54);
		this.FF27BE17.Name = "label3";
		this.FF27BE17.Size = new System.Drawing.Size(102, 16);
		this.FF27BE17.TabIndex = 3;
		this.FF27BE17.Text = "Web đăng nhâ\u0323p:";
		this.F9882390.AutoSize = true;
		this.F9882390.Location = new System.Drawing.Point(9, 24);
		this.F9882390.Name = "label2";
		this.F9882390.Size = new System.Drawing.Size(100, 16);
		this.F9882390.TabIndex = 3;
		this.F9882390.Text = "Kiểu đăng nhâ\u0323p:";
		this.AFACC218.AutoSize = true;
		this.AFACC218.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AFACC218.Location = new System.Drawing.Point(13, 22);
		this.AFACC218.Name = "ckbCreateProfile";
		this.AFACC218.Size = new System.Drawing.Size(161, 20);
		this.AFACC218.TabIndex = 2;
		this.AFACC218.Text = "Sử dụng profile chrome";
		this.AFACC218.UseVisualStyleBackColor = true;
		this.ckbGetCookie.AutoSize = true;
		this.ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGetCookie.Location = new System.Drawing.Point(21, 22);
		this.ckbGetCookie.Name = "ckbGetCookie";
		this.ckbGetCookie.Size = new System.Drawing.Size(134, 20);
		this.ckbGetCookie.TabIndex = 2;
		this.ckbGetCookie.Text = "Tự động lấy cookie";
		this.ckbGetCookie.UseVisualStyleBackColor = true;
		this.ckbAllowFollow.AutoSize = true;
		this.ckbAllowFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAllowFollow.Location = new System.Drawing.Point(21, 235);
		this.ckbAllowFollow.Name = "ckbAllowFollow";
		this.ckbAllowFollow.Size = new System.Drawing.Size(187, 20);
		this.ckbAllowFollow.TabIndex = 2;
		this.ckbAllowFollow.Text = "Cho phe\u0301p ngươ\u0300i kha\u0301c Follow";
		this.ckbAllowFollow.UseVisualStyleBackColor = true;
		this.E381E83E.AutoSize = true;
		this.E381E83E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E381E83E.Location = new System.Drawing.Point(21, 183);
		this.E381E83E.Name = "ckbCongKhaiBanBe";
		this.E381E83E.Size = new System.Drawing.Size(187, 20);
		this.E381E83E.TabIndex = 2;
		this.E381E83E.Text = "Công khai danh sách bạn bè";
		this.E381E83E.UseVisualStyleBackColor = true;
		this.E381E83E.CheckedChanged += new System.EventHandler(ckbCheckSpam_CheckedChanged);
		this.ckbLogOut.AutoSize = true;
		this.ckbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLogOut.Location = new System.Drawing.Point(21, 287);
		this.ckbLogOut.Name = "ckbLogOut";
		this.ckbLogOut.Size = new System.Drawing.Size(140, 20);
		this.ckbLogOut.TabIndex = 2;
		this.ckbLogOut.Text = "Đăng xuất tài khoản";
		this.ckbLogOut.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.AutoSize = true;
		this.ckbCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCapNhatThongTin.Location = new System.Drawing.Point(21, 48);
		this.ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
		this.ckbCapNhatThongTin.Size = new System.Drawing.Size(181, 20);
		this.ckbCapNhatThongTin.TabIndex = 2;
		this.ckbCapNhatThongTin.Text = "Tự động cập nhật thông tin";
		this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTin.CheckedChanged += new System.EventHandler(ckbCapNhatThongTinTruocKhiTuongTac_CheckedChanged);
		this.ckbCapNhatThongTin.Click += new System.EventHandler(ckbCapNhatThongTin_Click);
		this.CA110CB2.AutoSize = true;
		this.CA110CB2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CA110CB2.Location = new System.Drawing.Point(166, 22);
		this.CA110CB2.Name = "ckbGetToken";
		this.CA110CB2.Size = new System.Drawing.Size(129, 20);
		this.CA110CB2.TabIndex = 2;
		this.CA110CB2.Text = "Tự động lấy token";
		this.CA110CB2.UseVisualStyleBackColor = true;
		this.CA110CB2.CheckedChanged += new System.EventHandler(CA110CB2_CheckedChanged);
		this.CA110CB2.Click += new System.EventHandler(CA110CB2_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.groupBox6);
		this.panel1.Controls.Add(this.C696B30A);
		this.panel1.Controls.Add(this.grLogin);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.D796C312);
		this.panel1.Controls.Add(this.F38E65A5);
		this.panel1.Controls.Add(this.ckbBatThongBaoDangNhap);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(820, 416);
		this.panel1.TabIndex = 8;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox6.Controls.Add(this.cbbGetToken);
		this.groupBox6.Controls.Add(this.ckbWallPosts);
		this.groupBox6.Controls.Add(this.E381E83E);
		this.groupBox6.Controls.Add(this.ckbDisableChatSettings);
		this.groupBox6.Controls.Add(this.ckbAllowFollow);
		this.groupBox6.Controls.Add(this.ckbCheckSpam);
		this.groupBox6.Controls.Add(this.ckbCapNhatThongTinTruocKhiTuongTac);
		this.groupBox6.Controls.Add(this.ckbCapNhatThongTin);
		this.groupBox6.Controls.Add(this.C5202DA4);
		this.groupBox6.Controls.Add(this.ckbLogOut);
		this.groupBox6.Controls.Add(this.DC2496A9);
		this.groupBox6.Controls.Add(this.plCapNhatThongTin);
		this.groupBox6.Controls.Add(this.ckbGetCookie);
		this.groupBox6.Controls.Add(this.CA110CB2);
		this.groupBox6.Location = new System.Drawing.Point(414, 44);
		this.groupBox6.Name = "groupBox6";
		this.groupBox6.Size = new System.Drawing.Size(394, 318);
		this.groupBox6.TabIndex = 13;
		this.groupBox6.TabStop = false;
		this.groupBox6.Text = "Sau khi tương tác";
		this.cbbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbGetToken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbGetToken.DropDownWidth = 120;
		this.cbbGetToken.FormattingEnabled = true;
		this.cbbGetToken.Items.AddRange(new object[3] { "EAAG", "EAABw", "EAABs" });
		this.cbbGetToken.Location = new System.Drawing.Point(291, 20);
		this.cbbGetToken.Name = "cbbGetToken";
		this.cbbGetToken.Size = new System.Drawing.Size(96, 24);
		this.cbbGetToken.TabIndex = 10;
		this.ckbWallPosts.AutoSize = true;
		this.ckbWallPosts.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWallPosts.Location = new System.Drawing.Point(238, 259);
		this.ckbWallPosts.Name = "ckbWallPosts";
		this.ckbWallPosts.Size = new System.Drawing.Size(113, 20);
		this.ckbWallPosts.TabIndex = 0;
		this.ckbWallPosts.Text = "Wall Posts (ẩn)";
		this.ckbWallPosts.UseVisualStyleBackColor = true;
		this.ckbDisableChatSettings.AutoSize = true;
		this.ckbDisableChatSettings.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDisableChatSettings.Location = new System.Drawing.Point(238, 285);
		this.ckbDisableChatSettings.Name = "ckbDisableChatSettings";
		this.ckbDisableChatSettings.Size = new System.Drawing.Size(140, 20);
		this.ckbDisableChatSettings.TabIndex = 2;
		this.ckbDisableChatSettings.Text = "Tắt Popup chat (ẩn)";
		this.ckbDisableChatSettings.UseVisualStyleBackColor = true;
		this.ckbDisableChatSettings.CheckedChanged += new System.EventHandler(ckbCheckSpam_CheckedChanged);
		this.ckbCheckSpam.AutoSize = true;
		this.ckbCheckSpam.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckSpam.Location = new System.Drawing.Point(238, 183);
		this.ckbCheckSpam.Name = "ckbCheckSpam";
		this.ckbCheckSpam.Size = new System.Drawing.Size(95, 20);
		this.ckbCheckSpam.TabIndex = 2;
		this.ckbCheckSpam.Text = "Check spam";
		this.ckbCheckSpam.UseVisualStyleBackColor = true;
		this.ckbCheckSpam.CheckedChanged += new System.EventHandler(ckbCheckSpam_CheckedChanged);
		this.ckbCapNhatThongTinTruocKhiTuongTac.AutoSize = true;
		this.ckbCapNhatThongTinTruocKhiTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCapNhatThongTinTruocKhiTuongTac.Location = new System.Drawing.Point(255, 48);
		this.ckbCapNhatThongTinTruocKhiTuongTac.Name = "ckbCapNhatThongTinTruocKhiTuongTac";
		this.ckbCapNhatThongTinTruocKhiTuongTac.Size = new System.Drawing.Size(138, 20);
		this.ckbCapNhatThongTinTruocKhiTuongTac.TabIndex = 2;
		this.ckbCapNhatThongTinTruocKhiTuongTac.Text = "Trươ\u0301c khi tương ta\u0301c";
		this.ckbCapNhatThongTinTruocKhiTuongTac.UseVisualStyleBackColor = true;
		this.ckbCapNhatThongTinTruocKhiTuongTac.Visible = false;
		this.ckbCapNhatThongTinTruocKhiTuongTac.CheckedChanged += new System.EventHandler(ckbCapNhatThongTinTruocKhiTuongTac_CheckedChanged);
		this.C5202DA4.AutoSize = true;
		this.C5202DA4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C5202DA4.Location = new System.Drawing.Point(21, 209);
		this.C5202DA4.Name = "ckbReviewTag";
		this.C5202DA4.Size = new System.Drawing.Size(188, 20);
		this.C5202DA4.TabIndex = 2;
		this.C5202DA4.Text = "Bật duyệt bài viết trên tường";
		this.C5202DA4.UseVisualStyleBackColor = true;
		this.DC2496A9.AutoSize = true;
		this.DC2496A9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DC2496A9.Location = new System.Drawing.Point(21, 261);
		this.DC2496A9.Name = "ckbCauHinhTaiKhoan";
		this.DC2496A9.Size = new System.Drawing.Size(132, 20);
		this.DC2496A9.TabIndex = 8;
		this.DC2496A9.Text = "Cấu hình tài khoản";
		this.DC2496A9.UseVisualStyleBackColor = true;
		this.plCapNhatThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCapNhatThongTin.Controls.Add(this.ckbHometown);
		this.plCapNhatThongTin.Controls.Add(this.ckbLocation);
		this.plCapNhatThongTin.Controls.Add(this.ckbNgayTao);
		this.plCapNhatThongTin.Controls.Add(this.A884BCAF);
		this.plCapNhatThongTin.Controls.Add(this.ckbPage);
		this.plCapNhatThongTin.Controls.Add(this.ckbEmail);
		this.plCapNhatThongTin.Controls.Add(this.B505AB2D);
		this.plCapNhatThongTin.Controls.Add(this.ckbFbBlock);
		this.plCapNhatThongTin.Controls.Add(this.ckbAds);
		this.plCapNhatThongTin.Controls.Add(this.ckbDating);
		this.plCapNhatThongTin.Controls.Add(this.ckbAvatar);
		this.plCapNhatThongTin.Controls.Add(this.ckbPhone);
		this.plCapNhatThongTin.Controls.Add(this.D332013C);
		this.plCapNhatThongTin.Controls.Add(this.BB3702B3);
		this.plCapNhatThongTin.Controls.Add(this.ckbFriend);
		this.plCapNhatThongTin.Controls.Add(this.ckbBirthday);
		this.plCapNhatThongTin.Controls.Add(this.ckbGender);
		this.plCapNhatThongTin.Controls.Add(this.ckbName);
		this.plCapNhatThongTin.Location = new System.Drawing.Point(21, 70);
		this.plCapNhatThongTin.Name = "plCapNhatThongTin";
		this.plCapNhatThongTin.Size = new System.Drawing.Size(366, 107);
		this.plCapNhatThongTin.TabIndex = 14;
		this.ckbHometown.AutoSize = true;
		this.ckbHometown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHometown.Location = new System.Drawing.Point(95, 82);
		this.ckbHometown.Name = "ckbHometown";
		this.ckbHometown.Size = new System.Drawing.Size(163, 20);
		this.ckbHometown.TabIndex = 0;
		this.ckbHometown.Text = "Hometown, Current City";
		this.ckbHometown.UseVisualStyleBackColor = true;
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
		this.A884BCAF.AutoSize = true;
		this.A884BCAF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A884BCAF.Location = new System.Drawing.Point(67, 56);
		this.A884BCAF.Name = "ckbPagePro5";
		this.A884BCAF.Size = new System.Drawing.Size(84, 20);
		this.A884BCAF.TabIndex = 1;
		this.A884BCAF.Text = "Page pro5";
		this.A884BCAF.UseVisualStyleBackColor = true;
		this.ckbPage.AutoSize = true;
		this.ckbPage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbPage.Location = new System.Drawing.Point(4, 56);
		this.ckbPage.Name = "ckbPage";
		this.ckbPage.Size = new System.Drawing.Size(54, 20);
		this.ckbPage.TabIndex = 1;
		this.ckbPage.Text = "Page";
		this.ckbPage.UseVisualStyleBackColor = true;
		this.ckbEmail.AutoSize = true;
		this.ckbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbEmail.Location = new System.Drawing.Point(216, 4);
		this.ckbEmail.Name = "ckbEmail";
		this.ckbEmail.Size = new System.Drawing.Size(57, 20);
		this.ckbEmail.TabIndex = 1;
		this.ckbEmail.Text = "Email";
		this.ckbEmail.UseVisualStyleBackColor = true;
		this.B505AB2D.AutoSize = true;
		this.B505AB2D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B505AB2D.Location = new System.Drawing.Point(156, 56);
		this.B505AB2D.Name = "ckbBM";
		this.B505AB2D.Size = new System.Drawing.Size(43, 20);
		this.B505AB2D.TabIndex = 0;
		this.B505AB2D.Text = "BM";
		this.B505AB2D.UseVisualStyleBackColor = true;
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
		this.ckbDating.AutoSize = true;
		this.ckbDating.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDating.Location = new System.Drawing.Point(216, 56);
		this.ckbDating.Name = "ckbDating";
		this.ckbDating.Size = new System.Drawing.Size(62, 20);
		this.ckbDating.TabIndex = 0;
		this.ckbDating.Text = "Dating";
		this.ckbDating.UseVisualStyleBackColor = true;
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
		this.D332013C.AutoSize = true;
		this.D332013C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D332013C.Location = new System.Drawing.Point(140, 30);
		this.D332013C.Name = "ckbFollow";
		this.D332013C.Size = new System.Drawing.Size(63, 20);
		this.D332013C.TabIndex = 0;
		this.D332013C.Text = "Follow";
		this.D332013C.UseVisualStyleBackColor = true;
		this.BB3702B3.AutoSize = true;
		this.BB3702B3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB3702B3.Location = new System.Drawing.Point(67, 30);
		this.BB3702B3.Name = "ckbGroup";
		this.BB3702B3.Size = new System.Drawing.Size(60, 20);
		this.BB3702B3.TabIndex = 0;
		this.BB3702B3.Text = "Group";
		this.BB3702B3.UseVisualStyleBackColor = true;
		this.BB3702B3.Click += new System.EventHandler(BB3702B3_Click);
		this.ckbFriend.AutoSize = true;
		this.ckbFriend.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFriend.Location = new System.Drawing.Point(4, 30);
		this.ckbFriend.Name = "ckbFriend";
		this.ckbFriend.Size = new System.Drawing.Size(62, 20);
		this.ckbFriend.TabIndex = 0;
		this.ckbFriend.Text = "Friend";
		this.ckbFriend.UseVisualStyleBackColor = true;
		this.ckbBirthday.AutoSize = true;
		this.ckbBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBirthday.Location = new System.Drawing.Point(140, 4);
		this.ckbBirthday.Name = "ckbBirthday";
		this.ckbBirthday.Size = new System.Drawing.Size(72, 20);
		this.ckbBirthday.TabIndex = 0;
		this.ckbBirthday.Text = "Birthday";
		this.ckbBirthday.UseVisualStyleBackColor = true;
		this.ckbGender.AutoSize = true;
		this.ckbGender.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGender.Location = new System.Drawing.Point(67, 4);
		this.ckbGender.Name = "ckbGender";
		this.ckbGender.Size = new System.Drawing.Size(72, 20);
		this.ckbGender.TabIndex = 0;
		this.ckbGender.Text = "Giới tính";
		this.ckbGender.UseVisualStyleBackColor = true;
		this.ckbName.AutoSize = true;
		this.ckbName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbName.Location = new System.Drawing.Point(4, 4);
		this.ckbName.Name = "ckbName";
		this.ckbName.Size = new System.Drawing.Size(59, 20);
		this.ckbName.TabIndex = 0;
		this.ckbName.Text = "Name";
		this.ckbName.UseVisualStyleBackColor = true;
		this.C696B30A.Controls.Add(this.BC8DB68F);
		this.C696B30A.Controls.Add(this.AFACC218);
		this.C696B30A.Controls.Add(this.ckbCheckLiveUid);
		this.C696B30A.Controls.Add(this.ckbXoaCache);
		this.C696B30A.Location = new System.Drawing.Point(11, 44);
		this.C696B30A.Name = "groupBox5";
		this.C696B30A.Size = new System.Drawing.Size(397, 72);
		this.C696B30A.TabIndex = 13;
		this.C696B30A.TabStop = false;
		this.C696B30A.Text = "Trước khi chạy";
		this.BC8DB68F.AutoSize = true;
		this.BC8DB68F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BC8DB68F.Location = new System.Drawing.Point(224, 46);
		this.BC8DB68F.Name = "ckbRandomThuTuTaiKhoan";
		this.BC8DB68F.Size = new System.Drawing.Size(170, 20);
		this.BC8DB68F.TabIndex = 15;
		this.BC8DB68F.Text = "Xáo trộn thứ tự tài khoản";
		this.BC8DB68F.UseVisualStyleBackColor = true;
		this.ckbCheckLiveUid.AutoSize = true;
		this.ckbCheckLiveUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCheckLiveUid.Location = new System.Drawing.Point(13, 46);
		this.ckbCheckLiveUid.Name = "ckbCheckLiveUid";
		this.ckbCheckLiveUid.Size = new System.Drawing.Size(135, 20);
		this.ckbCheckLiveUid.TabIndex = 2;
		this.ckbCheckLiveUid.Text = "Check wall account";
		this.ckbCheckLiveUid.UseVisualStyleBackColor = true;
		this.ckbXoaCache.AutoSize = true;
		this.ckbXoaCache.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaCache.Location = new System.Drawing.Point(224, 22);
		this.ckbXoaCache.Name = "ckbXoaCache";
		this.ckbXoaCache.Size = new System.Drawing.Size(132, 20);
		this.ckbXoaCache.TabIndex = 9;
		this.ckbXoaCache.Text = "Xoá cache chrome";
		this.ckbXoaCache.UseVisualStyleBackColor = true;
		this.grLogin.Controls.Add(this.DD32B702);
		this.grLogin.Controls.Add(this.F9882390);
		this.grLogin.Controls.Add(this.button1);
		this.grLogin.Controls.Add(this.AA1D3282);
		this.grLogin.Controls.Add(this.FF27BE17);
		this.grLogin.Controls.Add(this.cbbTypeLogin);
		this.grLogin.Controls.Add(this.ckbDontSaveBrowser);
		this.grLogin.Location = new System.Drawing.Point(11, 122);
		this.grLogin.Name = "grLogin";
		this.grLogin.Size = new System.Drawing.Size(397, 82);
		this.grLogin.TabIndex = 12;
		this.grLogin.TabStop = false;
		this.grLogin.Text = "Đăng nhập";
		this.DD32B702.BackColor = System.Drawing.Color.White;
		this.DD32B702.BackgroundImage = Resources.Bitmap_83;
		this.DD32B702.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD32B702.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.DD32B702.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DD32B702.Location = new System.Drawing.Point(341, 8);
		this.DD32B702.Name = "button2";
		this.DD32B702.Size = new System.Drawing.Size(25, 25);
		this.DD32B702.TabIndex = 160;
		this.DD32B702.UseVisualStyleBackColor = false;
		this.DD32B702.Click += new System.EventHandler(DD32B702_Click);
		this.button1.BackColor = System.Drawing.Color.White;
		this.button1.BackgroundImage = Resources.E536C319;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Location = new System.Drawing.Point(372, 8);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(25, 25);
		this.button1.TabIndex = 161;
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(ED126A9E);
		this.AA1D3282.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AA1D3282.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.AA1D3282.DropDownWidth = 120;
		this.AA1D3282.FormattingEnabled = true;
		this.AA1D3282.Items.AddRange(new object[4] { "m.fb", "www", "mbasic", "www->m.fb" });
		this.AA1D3282.Location = new System.Drawing.Point(118, 51);
		this.AA1D3282.Name = "cbbFacebookWeb";
		this.AA1D3282.Size = new System.Drawing.Size(181, 24);
		this.AA1D3282.TabIndex = 10;
		this.cbbTypeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeLogin.DropDownWidth = 120;
		this.cbbTypeLogin.FormattingEnabled = true;
		this.cbbTypeLogin.Items.AddRange(new object[4] { "Uid|Pass", "Email|Pass", "Cookie", "Cookie>Pass" });
		this.cbbTypeLogin.Location = new System.Drawing.Point(118, 21);
		this.cbbTypeLogin.Name = "cbbTypeLogin";
		this.cbbTypeLogin.Size = new System.Drawing.Size(181, 24);
		this.cbbTypeLogin.TabIndex = 10;
		this.ckbDontSaveBrowser.AutoSize = true;
		this.ckbDontSaveBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDontSaveBrowser.Location = new System.Drawing.Point(12, 81);
		this.ckbDontSaveBrowser.Name = "ckbDontSaveBrowser";
		this.ckbDontSaveBrowser.Size = new System.Drawing.Size(244, 20);
		this.ckbDontSaveBrowser.TabIndex = 2;
		this.ckbDontSaveBrowser.Text = "Không lưu trình duyệt khi facebook hỏi";
		this.ckbDontSaveBrowser.UseVisualStyleBackColor = true;
		this.F38E65A5.AutoSize = true;
		this.F38E65A5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F38E65A5.Location = new System.Drawing.Point(1028, 643);
		this.F38E65A5.Name = "ckbCheckBanBeGoiY";
		this.F38E65A5.Size = new System.Drawing.Size(134, 20);
		this.F38E65A5.TabIndex = 9;
		this.F38E65A5.Text = "Check bạn bè gợi ý";
		this.F38E65A5.UseVisualStyleBackColor = true;
		this.F38E65A5.Visible = false;
		this.ckbBatThongBaoDangNhap.AutoSize = true;
		this.ckbBatThongBaoDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBatThongBaoDangNhap.Location = new System.Drawing.Point(1028, 614);
		this.ckbBatThongBaoDangNhap.Name = "ckbBatThongBaoDangNhap";
		this.ckbBatThongBaoDangNhap.Size = new System.Drawing.Size(169, 20);
		this.ckbBatThongBaoDangNhap.TabIndex = 7;
		this.ckbBatThongBaoDangNhap.Text = "Bật thông báo đăng nhập";
		this.ckbBatThongBaoDangNhap.UseVisualStyleBackColor = true;
		this.ckbBatThongBaoDangNhap.Visible = false;
		this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.groupBox2.Controls.Add(this.D8842515);
		this.groupBox2.Controls.Add(this.ckbChayKichBanDaGan);
		this.groupBox2.Controls.Add(this.btnDown);
		this.groupBox2.Controls.Add(this.btnUp);
		this.groupBox2.Controls.Add(this.plGioiHanThoiGianChayKichBan);
		this.groupBox2.Controls.Add(this.D430E69B);
		this.groupBox2.Controls.Add(this.plGioiHanThoiGianChayTaiKhoan);
		this.groupBox2.Controls.Add(this.E6138415);
		this.groupBox2.Controls.Add(this.E89C7334);
		this.groupBox2.Controls.Add(this.ckbGioiHanThoiGianChayTaiKhoan);
		this.groupBox2.Controls.Add(this.D103D4B7);
		this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox2.Location = new System.Drawing.Point(11, 210);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(397, 152);
		this.groupBox2.TabIndex = 7;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tương tác";
		this.D8842515.Controls.Add(this.FC2799B0);
		this.D8842515.Controls.Add(this.cbbKichBan);
		this.D8842515.Controls.Add(this.btnQuanLyKichBan);
		this.D8842515.Location = new System.Drawing.Point(6, 39);
		this.D8842515.Name = "plChonKichBan";
		this.D8842515.Size = new System.Drawing.Size(387, 26);
		this.D8842515.TabIndex = 14;
		this.FC2799B0.AutoSize = true;
		this.FC2799B0.Location = new System.Drawing.Point(3, 4);
		this.FC2799B0.Name = "label1";
		this.FC2799B0.Size = new System.Drawing.Size(92, 16);
		this.FC2799B0.TabIndex = 0;
		this.FC2799B0.Text = "Chọn kịch bản:";
		this.cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbKichBan.DropDownWidth = 300;
		this.cbbKichBan.FormattingEnabled = true;
		this.cbbKichBan.Location = new System.Drawing.Point(102, 1);
		this.cbbKichBan.Name = "cbbKichBan";
		this.cbbKichBan.Size = new System.Drawing.Size(164, 24);
		this.cbbKichBan.TabIndex = 1;
		this.btnQuanLyKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnQuanLyKichBan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnQuanLyKichBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnQuanLyKichBan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnQuanLyKichBan.Location = new System.Drawing.Point(272, 1);
		this.btnQuanLyKichBan.Name = "btnQuanLyKichBan";
		this.btnQuanLyKichBan.Size = new System.Drawing.Size(112, 24);
		this.btnQuanLyKichBan.TabIndex = 1;
		this.btnQuanLyKichBan.Text = "Quản lý kịch bản";
		this.btnQuanLyKichBan.Click += new System.EventHandler(btnQuanLyKichBan_Click);
		this.ckbChayKichBanDaGan.AutoSize = true;
		this.ckbChayKichBanDaGan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChayKichBanDaGan.Location = new System.Drawing.Point(12, 17);
		this.ckbChayKichBanDaGan.Name = "ckbChayKichBanDaGan";
		this.ckbChayKichBanDaGan.Size = new System.Drawing.Size(234, 20);
		this.ckbChayKichBanDaGan.TabIndex = 162;
		this.ckbChayKichBanDaGan.Text = "Chạy kịch bản đã gán từng tài khoản";
		this.ckbChayKichBanDaGan.UseVisualStyleBackColor = true;
		this.ckbChayKichBanDaGan.Visible = false;
		this.ckbChayKichBanDaGan.CheckedChanged += new System.EventHandler(ckbChayKichBanDaGan_CheckedChanged);
		this.btnDown.BackColor = System.Drawing.Color.White;
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(341, 8);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 160;
		this.btnDown.UseVisualStyleBackColor = false;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackColor = System.Drawing.Color.White;
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(372, 8);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 161;
		this.btnUp.UseVisualStyleBackColor = false;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.plGioiHanThoiGianChayKichBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.E40ADC1D);
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.nudThoiGianChayKichBanTo);
		this.plGioiHanThoiGianChayKichBan.Controls.Add(this.nudThoiGianChayKichBanFrom);
		this.plGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(269, 118);
		this.plGioiHanThoiGianChayKichBan.Name = "plGioiHanThoiGianChayKichBan";
		this.plGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(121, 27);
		this.plGioiHanThoiGianChayKichBan.TabIndex = 17;
		this.E40ADC1D.AutoSize = true;
		this.E40ADC1D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E40ADC1D.Location = new System.Drawing.Point(50, 4);
		this.E40ADC1D.Name = "label7";
		this.E40ADC1D.Size = new System.Drawing.Size(18, 16);
		this.E40ADC1D.TabIndex = 4;
		this.E40ADC1D.Text = ">";
		this.nudThoiGianChayKichBanTo.Location = new System.Drawing.Point(69, 1);
		this.nudThoiGianChayKichBanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayKichBanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanTo.Name = "nudThoiGianChayKichBanTo";
		this.nudThoiGianChayKichBanTo.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayKichBanTo.TabIndex = 3;
		this.nudThoiGianChayKichBanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanFrom.Location = new System.Drawing.Point(1, 1);
		this.nudThoiGianChayKichBanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudThoiGianChayKichBanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudThoiGianChayKichBanFrom.Name = "nudThoiGianChayKichBanFrom";
		this.nudThoiGianChayKichBanFrom.Size = new System.Drawing.Size(48, 23);
		this.nudThoiGianChayKichBanFrom.TabIndex = 3;
		this.nudThoiGianChayKichBanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.D430E69B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D430E69B.Controls.Add(this.label6);
		this.D430E69B.Controls.Add(this.label4);
		this.D430E69B.Controls.Add(this.nudDelayTurnFrom);
		this.D430E69B.Controls.Add(this.A1B1FF3E);
		this.D430E69B.Controls.Add(this.ACB22CAE);
		this.D430E69B.Controls.Add(this.D4A962A7);
		this.D430E69B.Controls.Add(this.nudSoLuotChay);
		this.D430E69B.Controls.Add(this.label10);
		this.D430E69B.Location = new System.Drawing.Point(32, 173);
		this.D430E69B.Name = "plRepeatAll";
		this.D430E69B.Size = new System.Drawing.Size(358, 64);
		this.D430E69B.TabIndex = 13;
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
		this.A1B1FF3E.Location = new System.Drawing.Point(222, 9);
		this.A1B1FF3E.Name = "label5";
		this.A1B1FF3E.Size = new System.Drawing.Size(30, 16);
		this.A1B1FF3E.TabIndex = 10;
		this.A1B1FF3E.Text = "lươ\u0323t";
		this.A1B1FF3E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A1B1FF3E.Click += new System.EventHandler(E21FEDA9);
		this.ACB22CAE.Location = new System.Drawing.Point(244, 34);
		this.ACB22CAE.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.ACB22CAE.Name = "nudDelayTurnTo";
		this.ACB22CAE.Size = new System.Drawing.Size(65, 23);
		this.ACB22CAE.TabIndex = 8;
		this.D4A962A7.AutoSize = true;
		this.D4A962A7.Location = new System.Drawing.Point(310, 37);
		this.D4A962A7.Name = "label11";
		this.D4A962A7.Size = new System.Drawing.Size(32, 16);
		this.D4A962A7.TabIndex = 11;
		this.D4A962A7.Text = "phút";
		this.nudSoLuotChay.Location = new System.Drawing.Point(154, 6);
		this.nudSoLuotChay.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		this.nudSoLuotChay.Minimum = new decimal(new int[4] { 2, 0, 0, 0 });
		this.nudSoLuotChay.Name = "nudSoLuotChay";
		this.nudSoLuotChay.Size = new System.Drawing.Size(65, 23);
		this.nudSoLuotChay.TabIndex = 7;
		this.nudSoLuotChay.Value = new decimal(new int[4] { 2, 0, 0, 0 });
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(219, 37);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(24, 16);
		this.label10.TabIndex = 12;
		this.label10.Text = ">";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plGioiHanThoiGianChayTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.EF067D26);
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.nudThoiGianChayTaiKhoanTo);
		this.plGioiHanThoiGianChayTaiKhoan.Controls.Add(this.nudThoiGianChayTaiKhoanFrom);
		this.plGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(269, 86);
		this.plGioiHanThoiGianChayTaiKhoan.Name = "plGioiHanThoiGianChayTaiKhoan";
		this.plGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(121, 27);
		this.plGioiHanThoiGianChayTaiKhoan.TabIndex = 18;
		this.EF067D26.AutoSize = true;
		this.EF067D26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EF067D26.Location = new System.Drawing.Point(50, 4);
		this.EF067D26.Name = "label13";
		this.EF067D26.Size = new System.Drawing.Size(18, 16);
		this.EF067D26.TabIndex = 4;
		this.EF067D26.Text = ">";
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
		this.E6138415.AutoSize = true;
		this.E6138415.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E6138415.Location = new System.Drawing.Point(12, 122);
		this.E6138415.Name = "ckbGioiHanThoiGianChayKichBan";
		this.E6138415.Size = new System.Drawing.Size(246, 20);
		this.E6138415.TabIndex = 15;
		this.E6138415.Text = "Giới hạn thời gian chạy/kịch bản (phút)";
		this.E6138415.UseVisualStyleBackColor = true;
		this.E6138415.CheckedChanged += new System.EventHandler(E6138415_CheckedChanged);
		this.E89C7334.AutoSize = true;
		this.E89C7334.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E89C7334.Location = new System.Drawing.Point(12, 151);
		this.E89C7334.Name = "ckbRepeatAll";
		this.E89C7334.Size = new System.Drawing.Size(344, 20);
		this.E89C7334.TabIndex = 2;
		this.E89C7334.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
		this.E89C7334.UseVisualStyleBackColor = true;
		this.E89C7334.CheckedChanged += new System.EventHandler(E89C7334_CheckedChanged);
		this.ckbGioiHanThoiGianChayTaiKhoan.AutoSize = true;
		this.ckbGioiHanThoiGianChayTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(12, 89);
		this.ckbGioiHanThoiGianChayTaiKhoan.Name = "ckbGioiHanThoiGianChayTaiKhoan";
		this.ckbGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(249, 20);
		this.ckbGioiHanThoiGianChayTaiKhoan.TabIndex = 16;
		this.ckbGioiHanThoiGianChayTaiKhoan.Text = "Giới hạn thời gian chạy/tài khoản (giây)";
		this.ckbGioiHanThoiGianChayTaiKhoan.UseVisualStyleBackColor = true;
		this.ckbGioiHanThoiGianChayTaiKhoan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged);
		this.D103D4B7.AutoSize = true;
		this.D103D4B7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D103D4B7.Location = new System.Drawing.Point(12, 67);
		this.D103D4B7.Name = "ckbRandomHanhDong";
		this.D103D4B7.Size = new System.Drawing.Size(178, 20);
		this.D103D4B7.TabIndex = 2;
		this.D103D4B7.Text = "Xáo trộn thứ tự hành động";
		this.D103D4B7.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(820, 416);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTuongTac";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTuongTac_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.D488BB0E.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox6.ResumeLayout(false);
		this.groupBox6.PerformLayout();
		this.plCapNhatThongTin.ResumeLayout(false);
		this.plCapNhatThongTin.PerformLayout();
		this.C696B30A.ResumeLayout(false);
		this.C696B30A.PerformLayout();
		this.grLogin.ResumeLayout(false);
		this.grLogin.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.D8842515.ResumeLayout(false);
		this.D8842515.PerformLayout();
		this.plGioiHanThoiGianChayKichBan.ResumeLayout(false);
		this.plGioiHanThoiGianChayKichBan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayKichBanFrom).EndInit();
		this.D430E69B.ResumeLayout(false);
		this.D430E69B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ACB22CAE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).EndInit();
		this.plGioiHanThoiGianChayTaiKhoan.ResumeLayout(false);
		this.plGioiHanThoiGianChayTaiKhoan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudThoiGianChayTaiKhoanFrom).EndInit();
		base.ResumeLayout(false);
	}
}
