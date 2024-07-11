using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhHotmail : Form
{
	public bool D48D743C = false;

	private List<string> list_0 = new List<string>();

	private IContainer ED039307 = null;

	private BunifuDragControl B0126FB6;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button C19D09AB;

	private PictureBox pictureBox1;

	private BunifuCustomLabel B9953125;

	private BackgroundWorker backgroundWorker_0;

	private CheckBox ckbCloseChrome;

	private CheckBox ckbUseProfile;

	private ComboBox cbbChangeIP;

	private Label label15;

	private GroupBox F60522B0;

	private GroupBox E0BB2F89;

	private CheckBox CCB24B05;

	private Panel plThemKyTuGetnada;

	private RadioButton rbKyTuChiDinh;

	private RadioButton rbKyTuRandom;

	private TextBox FFAFF897;

	private Label label1;

	private NumericUpDown nudTimeoutGetOtpGetnada;

	private GroupBox A4819A8A;

	private RadioButton rbPassChiDinh;

	private RadioButton rbPassRandom;

	private TextBox EF0A271B;

	private CheckBox ckbXoaMailKhoiPhucCu;

	private Label label2;

	private ComboBox cbbDomain;

	private GroupBox grUnlockHotmail;

	private ComboBox cbbTypePhone;

	private TextBox txtApiPhone;

	private NumericUpDown B4979310;

	private Label label4;

	private CheckBox ckbThemMailKhoiPhuc;

	private GroupBox groupBox1;

	private Button button2;

	public fCauHinhHotmail(string D6B5D1AE = "")
	{
		InitializeComponent();
		D48D743C = false;
		F60522B0.Enabled = D6B5D1AE.Contains("LoginHotmail");
		E0BB2F89.Enabled = D6B5D1AE.Contains("ThemMailKhoiPhuc");
		A4819A8A.Enabled = D6B5D1AE.Contains("DoiPassHotmail");
		grUnlockHotmail.Enabled = D6B5D1AE.Contains("UnlockHotmail");
		if (D6B5D1AE.Contains("UnlockHotmail"))
		{
			base.Height = 570;
		}
		Language.SetLanguage(this);
	}

	private void fCauHinhHotmail_Load(object sender, EventArgs e)
	{
		method_0();
		B793BE82();
		EE3DDE07();
		try
		{
			ckbUseProfile.Checked = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbUseProfile");
			ckbCloseChrome.Checked = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbCloseChrome");
			cbbChangeIP.SelectedValue = SettingsTool.GetSettings("configHotmail").GetValue("cbbChangeIP", "0");
			int num = SettingsTool.GetSettings("configHotmail").GetValueInt("typeSim");
			try
			{
				cbbTypePhone.SelectedValue = num.ToString();
			}
			catch
			{
			}
			txtApiPhone.Text = SettingsTool.GetSettings("configHotmail").GetValue("txtApiPhone_" + num);
			B4979310.Value = SettingsTool.GetSettings("configHotmail").GetValueInt("nudTimeoutGetOtpPhone", 60);
			ckbThemMailKhoiPhuc.Checked = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbThemMailKhoiPhuc");
			CCB24B05.Checked = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbThemKyTuGetnada");
			if (SettingsTool.GetSettings("configHotmail").GetValueInt("typeKyTu") == 0)
			{
				rbKyTuRandom.Checked = true;
			}
			else
			{
				rbKyTuChiDinh.Checked = true;
			}
			FFAFF897.Text = SettingsTool.GetSettings("configHotmail").GetValue("txtKyTuChiDinh");
			nudTimeoutGetOtpGetnada.Value = SettingsTool.GetSettings("configHotmail").GetValueInt("nudTimeoutGetOtpGetnada", 60);
			if (nudTimeoutGetOtpGetnada.Value == 0m)
			{
				nudTimeoutGetOtpGetnada.Value = 60m;
			}
			ckbXoaMailKhoiPhucCu.Checked = SettingsTool.GetSettings("configHotmail").GetValueBool("ckbXoaMailKhoiPhucCu", bool_0: true);
			cbbDomain.Text = SettingsTool.GetSettings("configHotmail").GetValue("cbbDomain", "getnada.com");
			list_0 = SettingsTool.GetSettings("configHotmail").GetValueList("lstProxyGetnada");
			if (SettingsTool.GetSettings("configHotmail").GetValueInt("typePassword") == 0)
			{
				rbPassRandom.Checked = true;
			}
			else
			{
				rbPassChiDinh.Checked = true;
			}
			EF0A271B.Text = SettingsTool.GetSettings("configHotmail").GetValue("txtPassChiDinh");
		}
		catch
		{
		}
		B59CA28C();
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Không đổi IP");
		dictionary.Add("9", "Proxy (Đã gán vào tài khoản)");
		Common.F5A0B829(cbbChangeIP, dictionary);
	}

	private void B793BE82()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "blondmail.com");
		dictionary.Add("1", "chapsmail.com");
		dictionary.Add("2", "clowmail.com");
		dictionary.Add("3", "dropjar.com");
		dictionary.Add("4", "fivermail.com");
		dictionary.Add("5", "getairmail.com");
		dictionary.Add("6", "getmule.com");
		dictionary.Add("7", "getnada.com");
		dictionary.Add("8", "gimpmail.com");
		dictionary.Add("9", "givmail.com");
		dictionary.Add("10", "guysmail.com");
		dictionary.Add("11", "inboxbear.com");
		dictionary.Add("12", "replyloop.com");
		dictionary.Add("13", "robot-mail.com");
		dictionary.Add("14", "spicysoda.com");
		dictionary.Add("15", "tafmail.com");
		dictionary.Add("16", "temptami.com");
		dictionary.Add("17", "tupmail.com");
		dictionary.Add("18", "vomoto.com");
		Common.F5A0B829(cbbDomain, dictionary);
	}

	private void EE3DDE07()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("38", "https://app.server-otponline.xyz/");
		dictionary.Add("36", "https://xotp.pro/");
		dictionary.Add("32", "https://sellotpvn.com/");
		dictionary.Add("19", "http://hcotp.com/");
		dictionary.Add("8", "https://viotp.com/");
		Common.F5A0B829(cbbTypePhone, dictionary);
	}

	private void C19D09AB_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			SettingsTool.GetSettings("configHotmail").GetJson("ckbUseProfile", ckbUseProfile.Checked);
			SettingsTool.GetSettings("configHotmail").GetJson("ckbCloseChrome", ckbCloseChrome.Checked);
			SettingsTool.GetSettings("configHotmail").GetJson("cbbChangeIP", cbbChangeIP.SelectedValue);
			SettingsTool.GetSettings("configHotmail").GetJson("ckbCloseChrome", ckbCloseChrome.Checked);
			int num = 0;
			try
			{
				num = Convert.ToInt32(cbbTypePhone.SelectedValue);
			}
			catch (Exception)
			{
			}
			SettingsTool.GetSettings("configHotmail").GetJson("typeSim", num);
			SettingsTool.GetSettings("configHotmail").GetJson("txtApiPhone_" + num, txtApiPhone.Text);
			SettingsTool.GetSettings("configHotmail").GetJson("nudTimeoutGetOtpPhone", B4979310.Value);
			SettingsTool.GetSettings("configHotmail").GetJson("ckbThemMailKhoiPhuc", ckbThemMailKhoiPhuc.Checked);
			SettingsTool.GetSettings("configHotmail").GetJson("ckbThemKyTuGetnada", CCB24B05.Checked);
			int num2 = 0;
			if (rbKyTuChiDinh.Checked)
			{
				num2 = 1;
			}
			SettingsTool.GetSettings("configHotmail").GetJson("typeKyTu", num2);
			SettingsTool.GetSettings("configHotmail").GetJson("txtKyTuChiDinh", FFAFF897.Text);
			SettingsTool.GetSettings("configHotmail").GetJson("nudTimeoutGetOtpGetnada", nudTimeoutGetOtpGetnada.Value);
			SettingsTool.GetSettings("configHotmail").GetJson("ckbXoaMailKhoiPhucCu", true);
			SettingsTool.GetSettings("configHotmail").GetJson("cbbDomain", cbbDomain.Text);
			SettingsTool.GetSettings("configHotmail").method_5("lstProxyGetnada", list_0);
			int num3 = 0;
			if (rbPassChiDinh.Checked)
			{
				num3 = 1;
			}
			SettingsTool.GetSettings("configHotmail").GetJson("typePassword", num3);
			SettingsTool.GetSettings("configHotmail").GetJson("txtPassChiDinh", EF0A271B.Text);
			SettingsTool.Save("configHotmail");
			D48D743C = true;
			Close();
		}
		catch
		{
			MessageBoxHelper.Show("Vui lòng thử lại sau!", 2);
		}
	}

	private void B59CA28C()
	{
		CCB24B05_CheckedChanged(null, null);
		F21BDD31(null, null);
		rbPassChiDinh_CheckedChanged(null, null);
		ckbThemMailKhoiPhuc_CheckedChanged(null, null);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BF3FD811(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void CCB24B05_CheckedChanged(object sender, EventArgs e)
	{
		plThemKyTuGetnada.Enabled = CCB24B05.Checked;
	}

	private void F21BDD31(object sender, EventArgs e)
	{
		FFAFF897.Enabled = rbKyTuChiDinh.Checked;
	}

	private void rbPassChiDinh_CheckedChanged(object sender, EventArgs e)
	{
		EF0A271B.Enabled = rbPassChiDinh.Checked;
	}

	private void ckbThemMailKhoiPhuc_CheckedChanged(object sender, EventArgs e)
	{
		if (grUnlockHotmail.Enabled)
		{
			E0BB2F89.Enabled = ckbThemMailKhoiPhuc.Checked;
		}
	}

	private void B800A730(object sender, EventArgs e)
	{
		string text = "0";
		try
		{
			text = cbbTypePhone.SelectedValue.ToString();
		}
		catch
		{
		}
		txtApiPhone.Text = SettingsTool.GetSettings("configHotmail").GetValue("txtApiPhone_" + text);
	}

	private void E32F5C33(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch proxy dùng để lấy otp từ getnada", "Danh sa\u0301ch proxy", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_0 = fNhapDuLieu3.C82C3629;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && ED039307 != null)
		{
			ED039307.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.ED039307 = new System.ComponentModel.Container();
		this.B0126FB6 = new Bunifu.Framework.UI.BunifuDragControl(this.ED039307);
		this.B9953125 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.ED039307);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.C19D09AB = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label15 = new System.Windows.Forms.Label();
		this.cbbChangeIP = new System.Windows.Forms.ComboBox();
		this.E0BB2F89 = new System.Windows.Forms.GroupBox();
		this.ckbXoaMailKhoiPhucCu = new System.Windows.Forms.CheckBox();
		this.CCB24B05 = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.plThemKyTuGetnada = new System.Windows.Forms.Panel();
		this.rbKyTuChiDinh = new System.Windows.Forms.RadioButton();
		this.rbKyTuRandom = new System.Windows.Forms.RadioButton();
		this.FFAFF897 = new System.Windows.Forms.TextBox();
		this.cbbDomain = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.nudTimeoutGetOtpGetnada = new System.Windows.Forms.NumericUpDown();
		this.A4819A8A = new System.Windows.Forms.GroupBox();
		this.rbPassChiDinh = new System.Windows.Forms.RadioButton();
		this.rbPassRandom = new System.Windows.Forms.RadioButton();
		this.EF0A271B = new System.Windows.Forms.TextBox();
		this.F60522B0 = new System.Windows.Forms.GroupBox();
		this.ckbUseProfile = new System.Windows.Forms.CheckBox();
		this.ckbCloseChrome = new System.Windows.Forms.CheckBox();
		this.grUnlockHotmail = new System.Windows.Forms.GroupBox();
		this.ckbThemMailKhoiPhuc = new System.Windows.Forms.CheckBox();
		this.cbbTypePhone = new System.Windows.Forms.ComboBox();
		this.txtApiPhone = new System.Windows.Forms.TextBox();
		this.B4979310 = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
		this.button2 = new System.Windows.Forms.Button();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.E0BB2F89.SuspendLayout();
		this.plThemKyTuGetnada.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeoutGetOtpGetnada).BeginInit();
		this.A4819A8A.SuspendLayout();
		this.F60522B0.SuspendLayout();
		this.grUnlockHotmail.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B4979310).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.B0126FB6.Fixed = true;
		this.B0126FB6.Horizontal = true;
		this.B0126FB6.TargetControl = this.B9953125;
		this.B0126FB6.Vertical = true;
		this.B9953125.BackColor = System.Drawing.Color.Transparent;
		this.B9953125.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B9953125.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B9953125.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B9953125.ForeColor = System.Drawing.Color.Black;
		this.B9953125.Location = new System.Drawing.Point(0, 0);
		this.B9953125.Name = "bunifuCustomLabel1";
		this.B9953125.Size = new System.Drawing.Size(400, 31);
		this.B9953125.TabIndex = 12;
		this.B9953125.Text = "Cấu hình Hotmail";
		this.B9953125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.C19D09AB);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.B9953125);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(400, 31);
		this.pnlHeader.TabIndex = 9;
		this.C19D09AB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C19D09AB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C19D09AB.FlatAppearance.BorderSize = 0;
		this.C19D09AB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C19D09AB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C19D09AB.ForeColor = System.Drawing.Color.White;
		this.C19D09AB.Image = Resources.A13F2207;
		this.C19D09AB.Location = new System.Drawing.Point(369, 1);
		this.C19D09AB.Name = "button1";
		this.C19D09AB.Size = new System.Drawing.Size(30, 30);
		this.C19D09AB.TabIndex = 77;
		this.C19D09AB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C19D09AB.UseVisualStyleBackColor = true;
		this.C19D09AB.Click += new System.EventHandler(C19D09AB_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.E0BB2F89);
		this.panel1.Controls.Add(this.A4819A8A);
		this.panel1.Controls.Add(this.F60522B0);
		this.panel1.Controls.Add(this.grUnlockHotmail);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(403, 461);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(BF3FD811);
		this.groupBox1.Controls.Add(this.label15);
		this.groupBox1.Controls.Add(this.cbbChangeIP);
		this.groupBox1.Location = new System.Drawing.Point(27, 53);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(346, 48);
		this.groupBox1.TabIndex = 206;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình chung";
		this.label15.AutoSize = true;
		this.label15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label15.Location = new System.Drawing.Point(6, 19);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(126, 16);
		this.label15.TabIndex = 200;
		this.label15.Text = "Tùy chọn Change IP:";
		this.cbbChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbChangeIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbChangeIP.FormattingEnabled = true;
		this.cbbChangeIP.Location = new System.Drawing.Point(136, 16);
		this.cbbChangeIP.Name = "cbbChangeIP";
		this.cbbChangeIP.Size = new System.Drawing.Size(206, 24);
		this.cbbChangeIP.TabIndex = 199;
		this.E0BB2F89.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.E0BB2F89.Controls.Add(this.button2);
		this.E0BB2F89.Controls.Add(this.ckbXoaMailKhoiPhucCu);
		this.E0BB2F89.Controls.Add(this.CCB24B05);
		this.E0BB2F89.Controls.Add(this.label2);
		this.E0BB2F89.Controls.Add(this.plThemKyTuGetnada);
		this.E0BB2F89.Controls.Add(this.cbbDomain);
		this.E0BB2F89.Controls.Add(this.label1);
		this.E0BB2F89.Controls.Add(this.nudTimeoutGetOtpGetnada);
		this.E0BB2F89.Location = new System.Drawing.Point(27, 184);
		this.E0BB2F89.Name = "grThemMailKhoiPhuc";
		this.E0BB2F89.Size = new System.Drawing.Size(346, 136);
		this.E0BB2F89.TabIndex = 204;
		this.E0BB2F89.TabStop = false;
		this.E0BB2F89.Text = "Thêm mail khôi phục";
		this.ckbXoaMailKhoiPhucCu.AutoSize = true;
		this.ckbXoaMailKhoiPhucCu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaMailKhoiPhucCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbXoaMailKhoiPhucCu.Location = new System.Drawing.Point(6, 136);
		this.ckbXoaMailKhoiPhucCu.Name = "ckbXoaMailKhoiPhucCu";
		this.ckbXoaMailKhoiPhucCu.Size = new System.Drawing.Size(151, 20);
		this.ckbXoaMailKhoiPhucCu.TabIndex = 8;
		this.ckbXoaMailKhoiPhucCu.Text = "Xóa mail khôi phục cũ";
		this.ckbXoaMailKhoiPhucCu.UseVisualStyleBackColor = true;
		this.CCB24B05.AutoSize = true;
		this.CCB24B05.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CCB24B05.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CCB24B05.Location = new System.Drawing.Point(6, 22);
		this.CCB24B05.Name = "ckbThemKyTuGetnada";
		this.CCB24B05.Size = new System.Drawing.Size(222, 20);
		this.CCB24B05.TabIndex = 8;
		this.CCB24B05.Text = "Thêm kí tự vào cuối mail getnada:";
		this.CCB24B05.UseVisualStyleBackColor = true;
		this.CCB24B05.CheckedChanged += new System.EventHandler(CCB24B05_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(3, 163);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(115, 16);
		this.label2.TabIndex = 200;
		this.label2.Text = "Chọn domain mail:";
		this.plThemKyTuGetnada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plThemKyTuGetnada.Controls.Add(this.rbKyTuChiDinh);
		this.plThemKyTuGetnada.Controls.Add(this.rbKyTuRandom);
		this.plThemKyTuGetnada.Controls.Add(this.FFAFF897);
		this.plThemKyTuGetnada.Location = new System.Drawing.Point(28, 43);
		this.plThemKyTuGetnada.Name = "plThemKyTuGetnada";
		this.plThemKyTuGetnada.Size = new System.Drawing.Size(314, 58);
		this.plThemKyTuGetnada.TabIndex = 9;
		this.rbKyTuChiDinh.AutoSize = true;
		this.rbKyTuChiDinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbKyTuChiDinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbKyTuChiDinh.Location = new System.Drawing.Point(3, 30);
		this.rbKyTuChiDinh.Name = "rbKyTuChiDinh";
		this.rbKyTuChiDinh.Size = new System.Drawing.Size(71, 20);
		this.rbKyTuChiDinh.TabIndex = 7;
		this.rbKyTuChiDinh.TabStop = true;
		this.rbKyTuChiDinh.Text = "Chỉ định";
		this.rbKyTuChiDinh.UseVisualStyleBackColor = true;
		this.rbKyTuChiDinh.CheckedChanged += new System.EventHandler(F21BDD31);
		this.rbKyTuRandom.AutoSize = true;
		this.rbKyTuRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbKyTuRandom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbKyTuRandom.Location = new System.Drawing.Point(3, 3);
		this.rbKyTuRandom.Name = "rbKyTuRandom";
		this.rbKyTuRandom.Size = new System.Drawing.Size(89, 20);
		this.rbKyTuRandom.TabIndex = 7;
		this.rbKyTuRandom.TabStop = true;
		this.rbKyTuRandom.Text = "Ngẫu nhiên";
		this.rbKyTuRandom.UseVisualStyleBackColor = true;
		this.FFAFF897.Location = new System.Drawing.Point(104, 29);
		this.FFAFF897.Name = "txtKyTuChiDinh";
		this.FFAFF897.Size = new System.Drawing.Size(205, 23);
		this.FFAFF897.TabIndex = 7;
		this.cbbDomain.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDomain.FormattingEnabled = true;
		this.cbbDomain.Items.AddRange(new object[2] { "Đổi màu nền dòng", "Đổi màu chữ" });
		this.cbbDomain.Location = new System.Drawing.Point(133, 160);
		this.cbbDomain.Name = "cbbDomain";
		this.cbbDomain.Size = new System.Drawing.Size(209, 24);
		this.cbbDomain.TabIndex = 199;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(6, 109);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(123, 16);
		this.label1.TabIndex = 201;
		this.label1.Text = "Timeout get otp (s):";
		this.nudTimeoutGetOtpGetnada.Location = new System.Drawing.Point(133, 107);
		this.nudTimeoutGetOtpGetnada.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeoutGetOtpGetnada.Name = "nudTimeoutGetOtpGetnada";
		this.nudTimeoutGetOtpGetnada.Size = new System.Drawing.Size(56, 23);
		this.nudTimeoutGetOtpGetnada.TabIndex = 202;
		this.A4819A8A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.A4819A8A.Controls.Add(this.rbPassChiDinh);
		this.A4819A8A.Controls.Add(this.rbPassRandom);
		this.A4819A8A.Controls.Add(this.EF0A271B);
		this.A4819A8A.Location = new System.Drawing.Point(27, 326);
		this.A4819A8A.Name = "grDoiPassHotmail";
		this.A4819A8A.Size = new System.Drawing.Size(346, 77);
		this.A4819A8A.TabIndex = 203;
		this.A4819A8A.TabStop = false;
		this.A4819A8A.Text = "Đổi mật khẩu hotmail";
		this.rbPassChiDinh.AutoSize = true;
		this.rbPassChiDinh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbPassChiDinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbPassChiDinh.Location = new System.Drawing.Point(6, 48);
		this.rbPassChiDinh.Name = "rbPassChiDinh";
		this.rbPassChiDinh.Size = new System.Drawing.Size(125, 20);
		this.rbPassChiDinh.TabIndex = 6;
		this.rbPassChiDinh.TabStop = true;
		this.rbPassChiDinh.Text = "Mật khẩu chỉ định";
		this.rbPassChiDinh.UseVisualStyleBackColor = true;
		this.rbPassChiDinh.CheckedChanged += new System.EventHandler(rbPassChiDinh_CheckedChanged);
		this.rbPassRandom.AutoSize = true;
		this.rbPassRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbPassRandom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbPassRandom.Location = new System.Drawing.Point(6, 22);
		this.rbPassRandom.Name = "rbPassRandom";
		this.rbPassRandom.Size = new System.Drawing.Size(144, 20);
		this.rbPassRandom.TabIndex = 5;
		this.rbPassRandom.TabStop = true;
		this.rbPassRandom.Text = "Mật khẩu ngẫu nhiên";
		this.rbPassRandom.UseVisualStyleBackColor = true;
		this.EF0A271B.Location = new System.Drawing.Point(133, 47);
		this.EF0A271B.Name = "txtPassChiDinh";
		this.EF0A271B.Size = new System.Drawing.Size(209, 23);
		this.EF0A271B.TabIndex = 7;
		this.F60522B0.Controls.Add(this.ckbUseProfile);
		this.F60522B0.Controls.Add(this.ckbCloseChrome);
		this.F60522B0.Location = new System.Drawing.Point(27, 107);
		this.F60522B0.Name = "grLoginHotmail";
		this.F60522B0.Size = new System.Drawing.Size(346, 72);
		this.F60522B0.TabIndex = 205;
		this.F60522B0.TabStop = false;
		this.F60522B0.Text = "Login hotmail";
		this.ckbUseProfile.AutoSize = true;
		this.ckbUseProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseProfile.Location = new System.Drawing.Point(6, 22);
		this.ckbUseProfile.Name = "ckbUseProfile";
		this.ckbUseProfile.Size = new System.Drawing.Size(134, 20);
		this.ckbUseProfile.TabIndex = 32;
		this.ckbUseProfile.Text = "Lưu profile chrome";
		this.ckbUseProfile.UseVisualStyleBackColor = true;
		this.ckbCloseChrome.AutoSize = true;
		this.ckbCloseChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCloseChrome.Location = new System.Drawing.Point(6, 48);
		this.ckbCloseChrome.Name = "ckbCloseChrome";
		this.ckbCloseChrome.Size = new System.Drawing.Size(211, 20);
		this.ckbCloseChrome.TabIndex = 32;
		this.ckbCloseChrome.Text = "Đóng chrome sau khi đăng nhập";
		this.ckbCloseChrome.UseVisualStyleBackColor = true;
		this.grUnlockHotmail.Controls.Add(this.ckbThemMailKhoiPhuc);
		this.grUnlockHotmail.Controls.Add(this.cbbTypePhone);
		this.grUnlockHotmail.Controls.Add(this.txtApiPhone);
		this.grUnlockHotmail.Controls.Add(this.B4979310);
		this.grUnlockHotmail.Controls.Add(this.label4);
		this.grUnlockHotmail.Location = new System.Drawing.Point(27, 185);
		this.grUnlockHotmail.Name = "grUnlockHotmail";
		this.grUnlockHotmail.Size = new System.Drawing.Size(346, 102);
		this.grUnlockHotmail.TabIndex = 204;
		this.grUnlockHotmail.TabStop = false;
		this.grUnlockHotmail.Text = "Unlock hotmail";
		this.ckbThemMailKhoiPhuc.AutoSize = true;
		this.ckbThemMailKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThemMailKhoiPhuc.Location = new System.Drawing.Point(6, 78);
		this.ckbThemMailKhoiPhuc.Name = "ckbThemMailKhoiPhuc";
		this.ckbThemMailKhoiPhuc.Size = new System.Drawing.Size(145, 20);
		this.ckbThemMailKhoiPhuc.TabIndex = 202;
		this.ckbThemMailKhoiPhuc.Text = "Thêm mail khôi phục";
		this.ckbThemMailKhoiPhuc.UseVisualStyleBackColor = true;
		this.ckbThemMailKhoiPhuc.CheckedChanged += new System.EventHandler(ckbThemMailKhoiPhuc_CheckedChanged);
		this.cbbTypePhone.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypePhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypePhone.DropDownWidth = 200;
		this.cbbTypePhone.FormattingEnabled = true;
		this.cbbTypePhone.Location = new System.Drawing.Point(6, 22);
		this.cbbTypePhone.Name = "cbbTypePhone";
		this.cbbTypePhone.Size = new System.Drawing.Size(123, 24);
		this.cbbTypePhone.TabIndex = 193;
		this.cbbTypePhone.SelectedIndexChanged += new System.EventHandler(B800A730);
		this.txtApiPhone.Location = new System.Drawing.Point(133, 23);
		this.txtApiPhone.Name = "txtApiPhone";
		this.txtApiPhone.Size = new System.Drawing.Size(209, 23);
		this.txtApiPhone.TabIndex = 34;
		this.B4979310.Location = new System.Drawing.Point(133, 52);
		this.B4979310.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B4979310.Name = "nudTimeoutGetOtpPhone";
		this.B4979310.Size = new System.Drawing.Size(56, 23);
		this.B4979310.TabIndex = 38;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(3, 54);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(123, 16);
		this.label4.TabIndex = 201;
		this.label4.Text = "Timeout get otp (s):";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(208, 415);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(101, 415);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		this.bunifuCards1.Size = new System.Drawing.Size(400, 37);
		this.bunifuCards1.TabIndex = 28;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Location = new System.Drawing.Point(193, 106);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(150, 25);
		this.button2.TabIndex = 204;
		this.button2.Text = "Proxy (get otp getnada)";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(E32F5C33);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(403, 461);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fCauHinhHotmail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fCauHinhHotmail_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.E0BB2F89.ResumeLayout(false);
		this.E0BB2F89.PerformLayout();
		this.plThemKyTuGetnada.ResumeLayout(false);
		this.plThemKyTuGetnada.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeoutGetOtpGetnada).EndInit();
		this.A4819A8A.ResumeLayout(false);
		this.A4819A8A.PerformLayout();
		this.F60522B0.ResumeLayout(false);
		this.F60522B0.PerformLayout();
		this.grUnlockHotmail.ResumeLayout(false);
		this.grUnlockHotmail.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.B4979310).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
