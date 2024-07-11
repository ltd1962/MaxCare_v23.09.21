using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhHienThi : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards D3995412;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button CD089E89;

	private Button C494ACA7;

	private Button btnAdd;

	private BunifuDragControl C4B03229;

	private BunifuCustomLabel E20C5C26;

	private PictureBox BA9FC40D;

	private CheckBox E0041C21;

	private CheckBox ckbCookie;

	private CheckBox ckbEmail;

	private CheckBox BB3E5894;

	private CheckBox ckbBanBe;

	private CheckBox ckbNhom;

	private CheckBox E90F3F8B;

	private CheckBox F7B6198E;

	private CheckBox F0362822;

	private CheckBox ckbMatKhauMail;

	private CheckBox D5B29221;

	private CheckBox ckbMa2FA;

	private CheckBox ckbUseragent;

	private CheckBox ckbProxy;

	private CheckBox EF221122;

	private CheckBox ckbAvatar;

	private CheckBox A9321336;

	private CheckBox C2934819;

	private CheckBox F3BEE71C;

	private CheckBox AF14B628;

	private CheckBox ckbFollow;

	private CheckBox DA38FFB8;

	private CheckBox FBB2228D;

	private CheckBox C7ACB0BD;

	private CheckBox BC96F889;

	private CheckBox B3AB429A;

	private CheckBox B92BF226;

	private CheckBox ckbAds;

	private CheckBox ckbBM;

	private CheckBox DE824A85;

	private CheckBox B82AE734;

	private CheckBox ckbCurrentCity;

	private CheckBox ckbWallPosts;

	private CheckBox B4BB6519;

	private CheckBox ckbJob;

	private CheckBox ckbStatus282;

	private CheckBox E13C8621;

	private CheckBox ckbKichBan;

	public fCauHinhHienThi()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void CD089E89_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			ckbWallPosts.Visible = true;
			ckbKichBan.Visible = true;
		}
		else
		{
			Close();
		}
	}

	private void DAB6AD34(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configDatagridview").GetJson("cToken", E0041C21.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbCookie", ckbCookie.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbEmail", ckbEmail.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbEmailFull", E13C8621.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbTen", BB3E5894.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbBanBe", ckbBanBe.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbNhom", ckbNhom.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbPage", B3AB429A.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbPagePro5", DE824A85.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbNgaySinh", E90F3F8B.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbGioiTinh", F7B6198E.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbMatKhau", F0362822.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbMatKhauMail", ckbMatKhauMail.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbBackup", D5B29221.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbMa2FA", ckbMa2FA.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbUseragent", ckbUseragent.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbProxy", ckbProxy.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbNgayTao", EF221122.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbAvatar", ckbAvatar.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbProfile", A9321336.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbTinhTrang", C2934819.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbThuMuc", AF14B628.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbGhiChu", F3BEE71C.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbStatus282", ckbStatus282.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbFollow", ckbFollow.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbInteractEnd", DA38FFB8.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbMailRecovery", FBB2228D.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbPhone", C7ACB0BD.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbHometown", B82AE734.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbLocation", BC96F889.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbCurrentCity", ckbCurrentCity.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbJob", ckbJob.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbDating", B92BF226.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbAds", ckbAds.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbBM", ckbBM.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbWallPosts", ckbWallPosts.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbFbBlock", B4BB6519.Checked);
		SettingsTool.GetSettings("configDatagridview").GetJson("ckbKichBan", ckbKichBan.Checked);
		if (ckbMa2FA.Checked && !Base.smethod_3())
		{
			SettingsTool.GetSettings("configDatagridview").GetJson("ckbMa2FA", false);
		}
		SettingsTool.Save("configDatagridview");
		Close();
	}

	private void DB153A3C(object sender, EventArgs e)
	{
		Close();
	}

	private void E20C5C26_Click(object sender, EventArgs e)
	{
	}

	private void fCauHinhHienThi_Load(object sender, EventArgs e)
	{
		E0041C21.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("cToken");
		ckbCookie.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbCookie");
		ckbEmail.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbEmail");
		E13C8621.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbEmailFull");
		BB3E5894.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbTen");
		ckbBanBe.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBanBe");
		ckbNhom.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNhom");
		B3AB429A.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPage");
		DE824A85.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPagePro5");
		E90F3F8B.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNgaySinh");
		F7B6198E.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbGioiTinh");
		F0362822.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMatKhau");
		ckbMatKhauMail.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMatKhauMail");
		D5B29221.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBackup");
		ckbMa2FA.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMa2FA");
		ckbUseragent.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbUseragent");
		ckbProxy.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbProxy");
		EF221122.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbNgayTao");
		ckbAvatar.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbAvatar");
		A9321336.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbProfile");
		C2934819.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbTinhTrang");
		AF14B628.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbThuMuc");
		F3BEE71C.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbGhiChu");
		ckbStatus282.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbStatus282");
		ckbFollow.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbFollow");
		DA38FFB8.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbInteractEnd");
		FBB2228D.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbMailRecovery");
		C7ACB0BD.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbPhone");
		B82AE734.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbHometown");
		BC96F889.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbLocation");
		ckbCurrentCity.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbCurrentCity");
		ckbJob.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbJob");
		B92BF226.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbDating");
		ckbAds.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbAds");
		ckbBM.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbBM");
		ckbWallPosts.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbWallPosts");
		B4BB6519.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbFbBlock");
		ckbKichBan.Checked = SettingsTool.GetSettings("configDatagridview").GetValueBool("ckbKichBan");
		ckbEmail_CheckedChanged(null, null);
	}

	private void ckbEmail_CheckedChanged(object sender, EventArgs e)
	{
		if (!ckbEmail.Checked)
		{
			E13C8621.Enabled = false;
			E13C8621.Checked = false;
		}
		else
		{
			E13C8621.Enabled = true;
		}
	}

	protected override void Dispose(bool ABA8E31E)
	{
		if (ABA8E31E && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(ABA8E31E);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhHienThi));
		this.D3995412 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.BA9FC40D = new System.Windows.Forms.PictureBox();
		this.CD089E89 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.C494ACA7 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.C4B03229 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.E20C5C26 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E0041C21 = new System.Windows.Forms.CheckBox();
		this.ckbCookie = new System.Windows.Forms.CheckBox();
		this.ckbEmail = new System.Windows.Forms.CheckBox();
		this.BB3E5894 = new System.Windows.Forms.CheckBox();
		this.ckbBanBe = new System.Windows.Forms.CheckBox();
		this.ckbNhom = new System.Windows.Forms.CheckBox();
		this.E90F3F8B = new System.Windows.Forms.CheckBox();
		this.F7B6198E = new System.Windows.Forms.CheckBox();
		this.F0362822 = new System.Windows.Forms.CheckBox();
		this.ckbMatKhauMail = new System.Windows.Forms.CheckBox();
		this.D5B29221 = new System.Windows.Forms.CheckBox();
		this.ckbMa2FA = new System.Windows.Forms.CheckBox();
		this.ckbUseragent = new System.Windows.Forms.CheckBox();
		this.ckbProxy = new System.Windows.Forms.CheckBox();
		this.EF221122 = new System.Windows.Forms.CheckBox();
		this.ckbAvatar = new System.Windows.Forms.CheckBox();
		this.A9321336 = new System.Windows.Forms.CheckBox();
		this.C2934819 = new System.Windows.Forms.CheckBox();
		this.F3BEE71C = new System.Windows.Forms.CheckBox();
		this.AF14B628 = new System.Windows.Forms.CheckBox();
		this.ckbFollow = new System.Windows.Forms.CheckBox();
		this.DA38FFB8 = new System.Windows.Forms.CheckBox();
		this.FBB2228D = new System.Windows.Forms.CheckBox();
		this.C7ACB0BD = new System.Windows.Forms.CheckBox();
		this.BC96F889 = new System.Windows.Forms.CheckBox();
		this.B3AB429A = new System.Windows.Forms.CheckBox();
		this.B92BF226 = new System.Windows.Forms.CheckBox();
		this.ckbAds = new System.Windows.Forms.CheckBox();
		this.ckbBM = new System.Windows.Forms.CheckBox();
		this.DE824A85 = new System.Windows.Forms.CheckBox();
		this.B82AE734 = new System.Windows.Forms.CheckBox();
		this.ckbCurrentCity = new System.Windows.Forms.CheckBox();
		this.ckbWallPosts = new System.Windows.Forms.CheckBox();
		this.B4BB6519 = new System.Windows.Forms.CheckBox();
		this.ckbJob = new System.Windows.Forms.CheckBox();
		this.ckbStatus282 = new System.Windows.Forms.CheckBox();
		this.E13C8621 = new System.Windows.Forms.CheckBox();
		this.ckbKichBan = new System.Windows.Forms.CheckBox();
		this.D3995412.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BA9FC40D).BeginInit();
		base.SuspendLayout();
		this.D3995412.BackColor = System.Drawing.Color.White;
		this.D3995412.BorderRadius = 0;
		this.D3995412.BottomSahddow = true;
		this.D3995412.color = System.Drawing.Color.SaddleBrown;
		this.D3995412.Controls.Add(this.pnlHeader);
		this.D3995412.Dock = System.Windows.Forms.DockStyle.Top;
		this.D3995412.LeftSahddow = false;
		this.D3995412.Location = new System.Drawing.Point(0, 0);
		this.D3995412.Name = "bunifuCards1";
		this.D3995412.RightSahddow = true;
		this.D3995412.ShadowDepth = 20;
		this.D3995412.Size = new System.Drawing.Size(613, 38);
		this.D3995412.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.BA9FC40D);
		this.pnlHeader.Controls.Add(this.CD089E89);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(613, 32);
		this.pnlHeader.TabIndex = 9;
		this.BA9FC40D.Cursor = System.Windows.Forms.Cursors.Default;
		this.BA9FC40D.Image = Resources.Bitmap_4;
		this.BA9FC40D.Location = new System.Drawing.Point(3, 2);
		this.BA9FC40D.Name = "pictureBox1";
		this.BA9FC40D.Size = new System.Drawing.Size(34, 27);
		this.BA9FC40D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.BA9FC40D.TabIndex = 17;
		this.BA9FC40D.TabStop = false;
		this.CD089E89.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CD089E89.Dock = System.Windows.Forms.DockStyle.Right;
		this.CD089E89.FlatAppearance.BorderSize = 0;
		this.CD089E89.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CD089E89.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CD089E89.ForeColor = System.Drawing.Color.White;
		this.CD089E89.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.CD089E89.Location = new System.Drawing.Point(581, 0);
		this.CD089E89.Name = "btnMinimize";
		this.CD089E89.Size = new System.Drawing.Size(32, 32);
		this.CD089E89.TabIndex = 9;
		this.CD089E89.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.CD089E89.UseVisualStyleBackColor = true;
		this.CD089E89.Click += new System.EventHandler(CD089E89_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(613, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C494ACA7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C494ACA7.BackColor = System.Drawing.Color.Maroon;
		this.C494ACA7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C494ACA7.FlatAppearance.BorderSize = 0;
		this.C494ACA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C494ACA7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C494ACA7.ForeColor = System.Drawing.Color.White;
		this.C494ACA7.Location = new System.Drawing.Point(314, 279);
		this.C494ACA7.Name = "btnCancel";
		this.C494ACA7.Size = new System.Drawing.Size(92, 29);
		this.C494ACA7.TabIndex = 4;
		this.C494ACA7.Text = "Đo\u0301ng";
		this.C494ACA7.UseVisualStyleBackColor = false;
		this.C494ACA7.Click += new System.EventHandler(DB153A3C);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(210, 279);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(DAB6AD34);
		this.C4B03229.Fixed = true;
		this.C4B03229.Horizontal = true;
		this.C4B03229.TargetControl = this.bunifuCustomLabel1;
		this.C4B03229.Vertical = true;
		this.E20C5C26.BackColor = System.Drawing.Color.Transparent;
		this.E20C5C26.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.E20C5C26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E20C5C26.ForeColor = System.Drawing.Color.Black;
		this.E20C5C26.Location = new System.Drawing.Point(51, 41);
		this.E20C5C26.Name = "lblStatus";
		this.E20C5C26.Size = new System.Drawing.Size(384, 32);
		this.E20C5C26.TabIndex = 21;
		this.E20C5C26.Text = "Vui lo\u0300ng cho\u0323n như\u0303ng cô\u0323t câ\u0300n hiê\u0309n thi\u0323!";
		this.E20C5C26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E20C5C26.Click += new System.EventHandler(E20C5C26_Click);
		this.E0041C21.AutoSize = true;
		this.E0041C21.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E0041C21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E0041C21.Location = new System.Drawing.Point(31, 137);
		this.E0041C21.Name = "ckbToken";
		this.E0041C21.Size = new System.Drawing.Size(61, 20);
		this.E0041C21.TabIndex = 22;
		this.E0041C21.Text = "Token";
		this.E0041C21.UseVisualStyleBackColor = true;
		this.ckbCookie.AutoSize = true;
		this.ckbCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbCookie.Location = new System.Drawing.Point(31, 163);
		this.ckbCookie.Name = "ckbCookie";
		this.ckbCookie.Size = new System.Drawing.Size(64, 20);
		this.ckbCookie.TabIndex = 22;
		this.ckbCookie.Text = "Cookie";
		this.ckbCookie.UseVisualStyleBackColor = true;
		this.ckbEmail.AutoSize = true;
		this.ckbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbEmail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbEmail.Location = new System.Drawing.Point(31, 189);
		this.ckbEmail.Name = "ckbEmail";
		this.ckbEmail.Size = new System.Drawing.Size(57, 20);
		this.ckbEmail.TabIndex = 22;
		this.ckbEmail.Text = "Email";
		this.ckbEmail.UseVisualStyleBackColor = true;
		this.ckbEmail.CheckedChanged += new System.EventHandler(ckbEmail_CheckedChanged);
		this.BB3E5894.AutoSize = true;
		this.BB3E5894.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB3E5894.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BB3E5894.Location = new System.Drawing.Point(158, 85);
		this.BB3E5894.Name = "ckbTen";
		this.BB3E5894.Size = new System.Drawing.Size(48, 20);
		this.BB3E5894.TabIndex = 22;
		this.BB3E5894.Text = "Tên";
		this.BB3E5894.UseVisualStyleBackColor = true;
		this.ckbBanBe.AutoSize = true;
		this.ckbBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBanBe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbBanBe.Location = new System.Drawing.Point(158, 137);
		this.ckbBanBe.Name = "ckbBanBe";
		this.ckbBanBe.Size = new System.Drawing.Size(65, 20);
		this.ckbBanBe.TabIndex = 22;
		this.ckbBanBe.Text = "Ba\u0323n be\u0300";
		this.ckbBanBe.UseVisualStyleBackColor = true;
		this.ckbNhom.AutoSize = true;
		this.ckbNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNhom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbNhom.Location = new System.Drawing.Point(158, 163);
		this.ckbNhom.Name = "ckbNhom";
		this.ckbNhom.Size = new System.Drawing.Size(59, 20);
		this.ckbNhom.TabIndex = 22;
		this.ckbNhom.Text = "Nho\u0301m";
		this.ckbNhom.UseVisualStyleBackColor = true;
		this.E90F3F8B.AutoSize = true;
		this.E90F3F8B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E90F3F8B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E90F3F8B.Location = new System.Drawing.Point(158, 241);
		this.E90F3F8B.Name = "ckbNgaySinh";
		this.E90F3F8B.Size = new System.Drawing.Size(81, 20);
		this.E90F3F8B.TabIndex = 22;
		this.E90F3F8B.Text = "Nga\u0300y sinh";
		this.E90F3F8B.UseVisualStyleBackColor = true;
		this.F7B6198E.AutoSize = true;
		this.F7B6198E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F7B6198E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F7B6198E.Location = new System.Drawing.Point(265, 111);
		this.F7B6198E.Name = "ckbGioiTinh";
		this.F7B6198E.Size = new System.Drawing.Size(72, 20);
		this.F7B6198E.TabIndex = 22;
		this.F7B6198E.Text = "Giơ\u0301i ti\u0301nh";
		this.F7B6198E.UseVisualStyleBackColor = true;
		this.F0362822.AutoSize = true;
		this.F0362822.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F0362822.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F0362822.Location = new System.Drawing.Point(31, 85);
		this.F0362822.Name = "ckbMatKhau";
		this.F0362822.Size = new System.Drawing.Size(78, 20);
		this.F0362822.TabIndex = 22;
		this.F0362822.Text = "Mâ\u0323t khâ\u0309u";
		this.F0362822.UseVisualStyleBackColor = true;
		this.ckbMatKhauMail.AutoSize = true;
		this.ckbMatKhauMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMatKhauMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMatKhauMail.Location = new System.Drawing.Point(31, 215);
		this.ckbMatKhauMail.Name = "ckbMatKhauMail";
		this.ckbMatKhauMail.Size = new System.Drawing.Size(106, 20);
		this.ckbMatKhauMail.TabIndex = 22;
		this.ckbMatKhauMail.Text = "Mâ\u0323t khâ\u0309u mail";
		this.ckbMatKhauMail.UseVisualStyleBackColor = true;
		this.D5B29221.AutoSize = true;
		this.D5B29221.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D5B29221.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D5B29221.Location = new System.Drawing.Point(265, 137);
		this.D5B29221.Name = "ckbBackup";
		this.D5B29221.Size = new System.Drawing.Size(66, 20);
		this.D5B29221.TabIndex = 22;
		this.D5B29221.Text = "Backup";
		this.D5B29221.UseVisualStyleBackColor = true;
		this.ckbMa2FA.AutoSize = true;
		this.ckbMa2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbMa2FA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbMa2FA.Location = new System.Drawing.Point(31, 111);
		this.ckbMa2FA.Name = "ckbMa2FA";
		this.ckbMa2FA.Size = new System.Drawing.Size(69, 20);
		this.ckbMa2FA.TabIndex = 22;
		this.ckbMa2FA.Text = "Ma\u0303 2FA";
		this.ckbMa2FA.UseVisualStyleBackColor = true;
		this.ckbUseragent.AutoSize = true;
		this.ckbUseragent.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbUseragent.Location = new System.Drawing.Point(265, 163);
		this.ckbUseragent.Name = "ckbUseragent";
		this.ckbUseragent.Size = new System.Drawing.Size(84, 20);
		this.ckbUseragent.TabIndex = 22;
		this.ckbUseragent.Text = "Useragent";
		this.ckbUseragent.UseVisualStyleBackColor = true;
		this.ckbProxy.AutoSize = true;
		this.ckbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbProxy.Location = new System.Drawing.Point(265, 189);
		this.ckbProxy.Name = "ckbProxy";
		this.ckbProxy.Size = new System.Drawing.Size(57, 20);
		this.ckbProxy.TabIndex = 22;
		this.ckbProxy.Text = "Proxy";
		this.ckbProxy.UseVisualStyleBackColor = true;
		this.EF221122.AutoSize = true;
		this.EF221122.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EF221122.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EF221122.Location = new System.Drawing.Point(265, 215);
		this.EF221122.Name = "ckbNgayTao";
		this.EF221122.Size = new System.Drawing.Size(76, 20);
		this.EF221122.TabIndex = 22;
		this.EF221122.Text = "Nga\u0300y ta\u0323o";
		this.EF221122.UseVisualStyleBackColor = true;
		this.ckbAvatar.AutoSize = true;
		this.ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAvatar.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAvatar.Location = new System.Drawing.Point(265, 241);
		this.ckbAvatar.Name = "ckbAvatar";
		this.ckbAvatar.Size = new System.Drawing.Size(63, 20);
		this.ckbAvatar.TabIndex = 22;
		this.ckbAvatar.Text = "Avatar";
		this.ckbAvatar.UseVisualStyleBackColor = true;
		this.A9321336.AutoSize = true;
		this.A9321336.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A9321336.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A9321336.Location = new System.Drawing.Point(373, 85);
		this.A9321336.Name = "ckbProfile";
		this.A9321336.Size = new System.Drawing.Size(62, 20);
		this.A9321336.TabIndex = 22;
		this.A9321336.Text = "Profile";
		this.A9321336.UseVisualStyleBackColor = true;
		this.C2934819.AutoSize = true;
		this.C2934819.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C2934819.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C2934819.Location = new System.Drawing.Point(373, 137);
		this.C2934819.Name = "ckbTinhTrang";
		this.C2934819.Size = new System.Drawing.Size(85, 20);
		this.C2934819.TabIndex = 22;
		this.C2934819.Text = "Ti\u0300nh tra\u0323ng";
		this.C2934819.UseVisualStyleBackColor = true;
		this.F3BEE71C.AutoSize = true;
		this.F3BEE71C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F3BEE71C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F3BEE71C.Location = new System.Drawing.Point(373, 189);
		this.F3BEE71C.Name = "ckbGhiChu";
		this.F3BEE71C.Size = new System.Drawing.Size(68, 20);
		this.F3BEE71C.TabIndex = 22;
		this.F3BEE71C.Text = "Ghi chú";
		this.F3BEE71C.UseVisualStyleBackColor = true;
		this.AF14B628.AutoSize = true;
		this.AF14B628.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AF14B628.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.AF14B628.Location = new System.Drawing.Point(373, 163);
		this.AF14B628.Name = "ckbThuMuc";
		this.AF14B628.Size = new System.Drawing.Size(77, 20);
		this.AF14B628.TabIndex = 22;
		this.AF14B628.Text = "Thư mục";
		this.AF14B628.UseVisualStyleBackColor = true;
		this.ckbFollow.AutoSize = true;
		this.ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbFollow.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbFollow.Location = new System.Drawing.Point(158, 111);
		this.ckbFollow.Name = "ckbFollow";
		this.ckbFollow.Size = new System.Drawing.Size(76, 20);
		this.ckbFollow.TabIndex = 22;
		this.ckbFollow.Text = "Theo do\u0303i";
		this.ckbFollow.UseVisualStyleBackColor = true;
		this.DA38FFB8.AutoSize = true;
		this.DA38FFB8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DA38FFB8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DA38FFB8.Location = new System.Drawing.Point(373, 111);
		this.DA38FFB8.Name = "ckbInteractEnd";
		this.DA38FFB8.Size = new System.Drawing.Size(111, 20);
		this.DA38FFB8.TabIndex = 22;
		this.DA38FFB8.Text = "Tương ta\u0301c cuô\u0301i";
		this.DA38FFB8.UseVisualStyleBackColor = true;
		this.FBB2228D.AutoSize = true;
		this.FBB2228D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FBB2228D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FBB2228D.Location = new System.Drawing.Point(30, 241);
		this.FBB2228D.Name = "ckbMailRecovery";
		this.FBB2228D.Size = new System.Drawing.Size(107, 20);
		this.FBB2228D.TabIndex = 22;
		this.FBB2228D.Text = "Mail khôi phục";
		this.FBB2228D.UseVisualStyleBackColor = true;
		this.C7ACB0BD.AutoSize = true;
		this.C7ACB0BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C7ACB0BD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C7ACB0BD.Location = new System.Drawing.Point(265, 85);
		this.C7ACB0BD.Name = "ckbPhone";
		this.C7ACB0BD.Size = new System.Drawing.Size(61, 20);
		this.C7ACB0BD.TabIndex = 22;
		this.C7ACB0BD.Text = "Phone";
		this.C7ACB0BD.UseVisualStyleBackColor = true;
		this.BC96F889.AutoSize = true;
		this.BC96F889.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BC96F889.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BC96F889.Location = new System.Drawing.Point(496, 137);
		this.BC96F889.Name = "ckbLocation";
		this.BC96F889.Size = new System.Drawing.Size(73, 20);
		this.BC96F889.TabIndex = 22;
		this.BC96F889.Text = "Location";
		this.BC96F889.UseVisualStyleBackColor = true;
		this.B3AB429A.AutoSize = true;
		this.B3AB429A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B3AB429A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B3AB429A.Location = new System.Drawing.Point(158, 189);
		this.B3AB429A.Name = "ckbPage";
		this.B3AB429A.Size = new System.Drawing.Size(54, 20);
		this.B3AB429A.TabIndex = 22;
		this.B3AB429A.Text = "Page";
		this.B3AB429A.UseVisualStyleBackColor = true;
		this.B92BF226.AutoSize = true;
		this.B92BF226.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B92BF226.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B92BF226.Location = new System.Drawing.Point(373, 215);
		this.B92BF226.Name = "ckbDating";
		this.B92BF226.Size = new System.Drawing.Size(62, 20);
		this.B92BF226.TabIndex = 22;
		this.B92BF226.Text = "Dating";
		this.B92BF226.UseVisualStyleBackColor = true;
		this.ckbAds.AutoSize = true;
		this.ckbAds.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAds.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAds.Location = new System.Drawing.Point(496, 85);
		this.ckbAds.Name = "ckbAds";
		this.ckbAds.Size = new System.Drawing.Size(47, 20);
		this.ckbAds.TabIndex = 22;
		this.ckbAds.Text = "Ads";
		this.ckbAds.UseVisualStyleBackColor = true;
		this.ckbBM.AutoSize = true;
		this.ckbBM.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBM.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbBM.Location = new System.Drawing.Point(496, 111);
		this.ckbBM.Name = "ckbBM";
		this.ckbBM.Size = new System.Drawing.Size(43, 20);
		this.ckbBM.TabIndex = 22;
		this.ckbBM.Text = "BM";
		this.ckbBM.UseVisualStyleBackColor = true;
		this.DE824A85.AutoSize = true;
		this.DE824A85.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE824A85.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DE824A85.Location = new System.Drawing.Point(158, 215);
		this.DE824A85.Name = "ckbPagePro5";
		this.DE824A85.Size = new System.Drawing.Size(84, 20);
		this.DE824A85.TabIndex = 22;
		this.DE824A85.Text = "Page pro5";
		this.DE824A85.UseVisualStyleBackColor = true;
		this.B82AE734.AutoSize = true;
		this.B82AE734.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B82AE734.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B82AE734.Location = new System.Drawing.Point(496, 163);
		this.B82AE734.Name = "ckbHometown";
		this.B82AE734.Size = new System.Drawing.Size(87, 20);
		this.B82AE734.TabIndex = 22;
		this.B82AE734.Text = "Hometown";
		this.B82AE734.UseVisualStyleBackColor = true;
		this.ckbCurrentCity.AutoSize = true;
		this.ckbCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCurrentCity.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbCurrentCity.Location = new System.Drawing.Point(496, 189);
		this.ckbCurrentCity.Name = "ckbCurrentCity";
		this.ckbCurrentCity.Size = new System.Drawing.Size(94, 20);
		this.ckbCurrentCity.TabIndex = 22;
		this.ckbCurrentCity.Text = "Current City";
		this.ckbCurrentCity.UseVisualStyleBackColor = true;
		this.ckbWallPosts.AutoSize = true;
		this.ckbWallPosts.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWallPosts.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbWallPosts.Location = new System.Drawing.Point(496, 267);
		this.ckbWallPosts.Name = "ckbWallPosts";
		this.ckbWallPosts.Size = new System.Drawing.Size(85, 20);
		this.ckbWallPosts.TabIndex = 22;
		this.ckbWallPosts.Text = "Wall posts";
		this.ckbWallPosts.UseVisualStyleBackColor = true;
		this.ckbWallPosts.Visible = false;
		this.B4BB6519.AutoSize = true;
		this.B4BB6519.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B4BB6519.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B4BB6519.Location = new System.Drawing.Point(496, 241);
		this.B4BB6519.Name = "ckbFbBlock";
		this.B4BB6519.Size = new System.Drawing.Size(73, 20);
		this.B4BB6519.TabIndex = 22;
		this.B4BB6519.Text = "Fb Block";
		this.B4BB6519.UseVisualStyleBackColor = true;
		this.ckbJob.AutoSize = true;
		this.ckbJob.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbJob.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbJob.Location = new System.Drawing.Point(496, 215);
		this.ckbJob.Name = "ckbJob";
		this.ckbJob.Size = new System.Drawing.Size(45, 20);
		this.ckbJob.TabIndex = 22;
		this.ckbJob.Text = "Job";
		this.ckbJob.UseVisualStyleBackColor = true;
		this.ckbStatus282.AutoSize = true;
		this.ckbStatus282.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbStatus282.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbStatus282.Location = new System.Drawing.Point(373, 241);
		this.ckbStatus282.Name = "ckbStatus282";
		this.ckbStatus282.Size = new System.Drawing.Size(87, 20);
		this.ckbStatus282.TabIndex = 22;
		this.ckbStatus282.Text = "Status 282";
		this.ckbStatus282.UseVisualStyleBackColor = true;
		this.E13C8621.AutoSize = true;
		this.E13C8621.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E13C8621.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E13C8621.Location = new System.Drawing.Point(85, 189);
		this.E13C8621.Name = "ckbEmailFull";
		this.E13C8621.Size = new System.Drawing.Size(46, 20);
		this.E13C8621.TabIndex = 22;
		this.E13C8621.Text = "Full";
		this.E13C8621.UseVisualStyleBackColor = true;
		this.ckbKichBan.AutoSize = true;
		this.ckbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKichBan.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbKichBan.Location = new System.Drawing.Point(496, 293);
		this.ckbKichBan.Name = "ckbKichBan";
		this.ckbKichBan.Size = new System.Drawing.Size(74, 20);
		this.ckbKichBan.TabIndex = 22;
		this.ckbKichBan.Text = "Kịch bản";
		this.ckbKichBan.UseVisualStyleBackColor = true;
		this.ckbKichBan.Visible = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(613, 321);
		base.Controls.Add(this.E90F3F8B);
		base.Controls.Add(this.AF14B628);
		base.Controls.Add(this.C7ACB0BD);
		base.Controls.Add(this.ckbBM);
		base.Controls.Add(this.ckbAds);
		base.Controls.Add(this.B92BF226);
		base.Controls.Add(this.B4BB6519);
		base.Controls.Add(this.ckbKichBan);
		base.Controls.Add(this.ckbWallPosts);
		base.Controls.Add(this.ckbJob);
		base.Controls.Add(this.ckbCurrentCity);
		base.Controls.Add(this.B82AE734);
		base.Controls.Add(this.BC96F889);
		base.Controls.Add(this.FBB2228D);
		base.Controls.Add(this.ckbStatus282);
		base.Controls.Add(this.F3BEE71C);
		base.Controls.Add(this.DA38FFB8);
		base.Controls.Add(this.C2934819);
		base.Controls.Add(this.A9321336);
		base.Controls.Add(this.ckbAvatar);
		base.Controls.Add(this.EF221122);
		base.Controls.Add(this.ckbProxy);
		base.Controls.Add(this.ckbUseragent);
		base.Controls.Add(this.ckbMa2FA);
		base.Controls.Add(this.D5B29221);
		base.Controls.Add(this.ckbMatKhauMail);
		base.Controls.Add(this.F0362822);
		base.Controls.Add(this.F7B6198E);
		base.Controls.Add(this.DE824A85);
		base.Controls.Add(this.B3AB429A);
		base.Controls.Add(this.ckbNhom);
		base.Controls.Add(this.ckbFollow);
		base.Controls.Add(this.ckbBanBe);
		base.Controls.Add(this.BB3E5894);
		base.Controls.Add(this.E13C8621);
		base.Controls.Add(this.ckbEmail);
		base.Controls.Add(this.ckbCookie);
		base.Controls.Add(this.E0041C21);
		base.Controls.Add(this.E20C5C26);
		base.Controls.Add(this.C494ACA7);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.D3995412);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhHienThi";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhHienThi_Load);
		this.D3995412.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BA9FC40D).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
