using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fMoTrinhDuyet : Form
{
	public static bool C4097AB0;

	private IContainer CE131582 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button C1895203;

	private Button C08F5E27;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Panel CE39AC97;

	private Button E537258A;

	private Label label3;

	private Button btnSave;

	private CheckBox ckbAutoCloseChromeLoginFail;

	private TextBox txtLink;

	private CheckBox ckbAutoOpenLink;

	private CheckBox ckbKhongLuuTrinhDuyet;

	private CheckBox ckbLoginHotmail;

	private Panel plAddChromeVaoFormView;

	private NumericUpDown nudWidthChrome;

	private Label label35;

	private Label A3B4E5A2;

	private NumericUpDown nudHeighChrome;

	private CheckBox ckbAddChromeIntoForm;

	private Panel A9827688;

	private Label B0025811;

	private Label D0AAD634;

	private ComboBox cbbColumnChrome;

	private ComboBox cbbRowChrome;

	private Panel panel3;

	private RadioButton rbSuDungProfile;

	private RadioButton rbKhongDungProfile;

	private Label FE03CD87;

	public fMoTrinhDuyet()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		C4097AB0 = false;
	}

	private void C1895203_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C08F5E27_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E537258A_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fCauHinhChung());
	}

	private void fMoTrinhDuyet_Load(object sender, EventArgs e)
	{
		if (SettingsTool.GetSettings("configOpenBrowser").GetValueBool("isUseProfile", bool_0: true))
		{
			rbSuDungProfile.Checked = true;
		}
		else
		{
			rbKhongDungProfile.Checked = true;
		}
		ckbAddChromeIntoForm.Checked = SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbAddChromeIntoForm");
		nudWidthChrome.Value = SettingsTool.GetSettings("configOpenBrowser").GetValueInt("nudWidthChrome", 520);
		nudHeighChrome.Value = SettingsTool.GetSettings("configOpenBrowser").GetValueInt("nudHeighChrome", 480);
		cbbColumnChrome.Text = SettingsTool.GetSettings("configOpenBrowser").GetValue("cbbColumnChrome", "5");
		cbbRowChrome.Text = SettingsTool.GetSettings("configOpenBrowser").GetValue("cbbRowChrome", "2");
		ckbKhongLuuTrinhDuyet.Checked = SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbKhongLuuTrinhDuyet");
		ckbAutoCloseChromeLoginFail.Checked = SettingsTool.GetSettings("configOpenBrowser").GetValueBool("isAutoCloseChromeLoginFail");
		ckbAutoOpenLink.Checked = SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbAutoOpenLink");
		txtLink.Text = SettingsTool.GetSettings("configOpenBrowser").GetValue("txtLink");
		ckbLoginHotmail.Checked = SettingsTool.GetSettings("configOpenBrowser").GetValueBool("ckbLoginHotmail");
		B8A20BB1(null, null);
		method_0(null, null);
		E4338B27(null, null);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (rbSuDungProfile.Checked)
		{
			SettingsTool.GetSettings("configOpenBrowser").GetJson("isUseProfile", true);
		}
		else
		{
			SettingsTool.GetSettings("configOpenBrowser").GetJson("isUseProfile", false);
		}
		SettingsTool.GetSettings("configOpenBrowser").GetJson("ckbAddChromeIntoForm", ckbAddChromeIntoForm.Checked);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("nudWidthChrome", nudWidthChrome.Value);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("nudHeighChrome", nudHeighChrome.Value);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("cbbColumnChrome", cbbColumnChrome.Text);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("cbbRowChrome", cbbRowChrome.Text);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("ckbKhongLuuTrinhDuyet", ckbKhongLuuTrinhDuyet.Checked);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("isAutoCloseChromeLoginFail", ckbAutoCloseChromeLoginFail.Checked);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("ckbAutoOpenLink", ckbAutoOpenLink.Checked);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("txtLink", txtLink.Text);
		SettingsTool.GetSettings("configOpenBrowser").GetJson("ckbLoginHotmail", ckbLoginHotmail.Checked);
		SettingsTool.Save("configOpenBrowser");
		C4097AB0 = true;
		Close();
	}

	private void CB8418B1(object sender, EventArgs e)
	{
	}

	private void B8A20BB1(object sender, EventArgs e)
	{
		txtLink.Enabled = ckbAutoOpenLink.Checked;
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void E4338B27(object sender, EventArgs e)
	{
		plAddChromeVaoFormView.Enabled = ckbAddChromeIntoForm.Checked;
		A9827688.Enabled = !ckbAddChromeIntoForm.Checked;
	}

	private void CE39AC97_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && CE131582 != null)
		{
			CE131582.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.CE131582 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMoTrinhDuyet));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C1895203 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.C08F5E27 = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.CE131582);
		this.CE39AC97 = new System.Windows.Forms.Panel();
		this.A9827688 = new System.Windows.Forms.Panel();
		this.B0025811 = new System.Windows.Forms.Label();
		this.D0AAD634 = new System.Windows.Forms.Label();
		this.cbbColumnChrome = new System.Windows.Forms.ComboBox();
		this.cbbRowChrome = new System.Windows.Forms.ComboBox();
		this.plAddChromeVaoFormView = new System.Windows.Forms.Panel();
		this.nudWidthChrome = new System.Windows.Forms.NumericUpDown();
		this.label35 = new System.Windows.Forms.Label();
		this.A3B4E5A2 = new System.Windows.Forms.Label();
		this.nudHeighChrome = new System.Windows.Forms.NumericUpDown();
		this.ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
		this.ckbLoginHotmail = new System.Windows.Forms.CheckBox();
		this.txtLink = new System.Windows.Forms.TextBox();
		this.E537258A = new System.Windows.Forms.Button();
		this.ckbAutoOpenLink = new System.Windows.Forms.CheckBox();
		this.ckbAutoCloseChromeLoginFail = new System.Windows.Forms.CheckBox();
		this.ckbKhongLuuTrinhDuyet = new System.Windows.Forms.CheckBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbSuDungProfile = new System.Windows.Forms.RadioButton();
		this.rbKhongDungProfile = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.FE03CD87 = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.CE39AC97.SuspendLayout();
		this.A9827688.SuspendLayout();
		this.plAddChromeVaoFormView.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudWidthChrome).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudHeighChrome).BeginInit();
		this.panel3.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(452, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.C1895203);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(452, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.C1895203.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C1895203.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C1895203.FlatAppearance.BorderSize = 0;
		this.C1895203.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C1895203.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C1895203.ForeColor = System.Drawing.Color.White;
		this.C1895203.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.C1895203.Location = new System.Drawing.Point(419, -1);
		this.C1895203.Name = "btnMinimize";
		this.C1895203.Size = new System.Drawing.Size(32, 32);
		this.C1895203.TabIndex = 9;
		this.C1895203.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C1895203.UseVisualStyleBackColor = true;
		this.C1895203.Click += new System.EventHandler(C1895203_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(452, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cấu hình Mở trình duyệt";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C08F5E27.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C08F5E27.BackColor = System.Drawing.Color.Maroon;
		this.C08F5E27.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C08F5E27.FlatAppearance.BorderSize = 0;
		this.C08F5E27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C08F5E27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C08F5E27.ForeColor = System.Drawing.Color.White;
		this.C08F5E27.Location = new System.Drawing.Point(233, 260);
		this.C08F5E27.Name = "btnCancel";
		this.C08F5E27.Size = new System.Drawing.Size(92, 29);
		this.C08F5E27.TabIndex = 4;
		this.C08F5E27.Text = "Đo\u0301ng";
		this.C08F5E27.UseVisualStyleBackColor = false;
		this.C08F5E27.Click += new System.EventHandler(C08F5E27_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.CE39AC97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.CE39AC97.Controls.Add(this.A9827688);
		this.CE39AC97.Controls.Add(this.plAddChromeVaoFormView);
		this.CE39AC97.Controls.Add(this.ckbAddChromeIntoForm);
		this.CE39AC97.Controls.Add(this.ckbLoginHotmail);
		this.CE39AC97.Controls.Add(this.txtLink);
		this.CE39AC97.Controls.Add(this.E537258A);
		this.CE39AC97.Controls.Add(this.ckbAutoOpenLink);
		this.CE39AC97.Controls.Add(this.ckbAutoCloseChromeLoginFail);
		this.CE39AC97.Controls.Add(this.ckbKhongLuuTrinhDuyet);
		this.CE39AC97.Controls.Add(this.btnSave);
		this.CE39AC97.Controls.Add(this.C08F5E27);
		this.CE39AC97.Controls.Add(this.panel3);
		this.CE39AC97.Controls.Add(this.label3);
		this.CE39AC97.Controls.Add(this.FE03CD87);
		this.CE39AC97.Dock = System.Windows.Forms.DockStyle.Fill;
		this.CE39AC97.Location = new System.Drawing.Point(0, 0);
		this.CE39AC97.Name = "panel1";
		this.CE39AC97.Size = new System.Drawing.Size(453, 302);
		this.CE39AC97.TabIndex = 5;
		this.CE39AC97.Paint += new System.Windows.Forms.PaintEventHandler(CE39AC97_Paint);
		this.A9827688.Controls.Add(this.B0025811);
		this.A9827688.Controls.Add(this.D0AAD634);
		this.A9827688.Controls.Add(this.cbbColumnChrome);
		this.A9827688.Controls.Add(this.cbbRowChrome);
		this.A9827688.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A9827688.Location = new System.Drawing.Point(32, 145);
		this.A9827688.Name = "plSapXepCuaSoChrome";
		this.A9827688.Size = new System.Drawing.Size(358, 28);
		this.A9827688.TabIndex = 159;
		this.B0025811.AutoSize = true;
		this.B0025811.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B0025811.Location = new System.Drawing.Point(3, 4);
		this.B0025811.Name = "label10";
		this.B0025811.Size = new System.Drawing.Size(147, 16);
		this.B0025811.TabIndex = 33;
		this.B0025811.Text = "Sắp xếp cửa sổ chrome:";
		this.D0AAD634.AutoSize = true;
		this.D0AAD634.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D0AAD634.Location = new System.Drawing.Point(245, 2);
		this.D0AAD634.Name = "label11";
		this.D0AAD634.Size = new System.Drawing.Size(23, 23);
		this.D0AAD634.TabIndex = 33;
		this.D0AAD634.Text = "X";
		this.cbbColumnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbColumnChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbColumnChrome.FormattingEnabled = true;
		this.cbbColumnChrome.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		this.cbbColumnChrome.Location = new System.Drawing.Point(200, 2);
		this.cbbColumnChrome.Name = "cbbColumnChrome";
		this.cbbColumnChrome.Size = new System.Drawing.Size(41, 24);
		this.cbbColumnChrome.TabIndex = 145;
		this.cbbRowChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbRowChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbRowChrome.FormattingEnabled = true;
		this.cbbRowChrome.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		this.cbbRowChrome.Location = new System.Drawing.Point(272, 2);
		this.cbbRowChrome.Name = "cbbRowChrome";
		this.cbbRowChrome.Size = new System.Drawing.Size(41, 24);
		this.cbbRowChrome.TabIndex = 145;
		this.plAddChromeVaoFormView.Controls.Add(this.nudWidthChrome);
		this.plAddChromeVaoFormView.Controls.Add(this.label35);
		this.plAddChromeVaoFormView.Controls.Add(this.A3B4E5A2);
		this.plAddChromeVaoFormView.Controls.Add(this.nudHeighChrome);
		this.plAddChromeVaoFormView.Location = new System.Drawing.Point(224, 118);
		this.plAddChromeVaoFormView.Name = "plAddChromeVaoFormView";
		this.plAddChromeVaoFormView.Size = new System.Drawing.Size(175, 27);
		this.plAddChromeVaoFormView.TabIndex = 158;
		this.nudWidthChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudWidthChrome.Location = new System.Drawing.Point(41, 2);
		this.nudWidthChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudWidthChrome.Name = "nudWidthChrome";
		this.nudWidthChrome.Size = new System.Drawing.Size(53, 23);
		this.nudWidthChrome.TabIndex = 151;
		this.nudWidthChrome.Value = new decimal(new int[4] { 516, 0, 0, 0 });
		this.label35.AutoSize = true;
		this.label35.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label35.Location = new System.Drawing.Point(95, 2);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(23, 23);
		this.label35.TabIndex = 33;
		this.label35.Text = "X";
		this.A3B4E5A2.AutoSize = true;
		this.A3B4E5A2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A3B4E5A2.Location = new System.Drawing.Point(3, 4);
		this.A3B4E5A2.Name = "label33";
		this.A3B4E5A2.Size = new System.Drawing.Size(36, 16);
		this.A3B4E5A2.TabIndex = 33;
		this.A3B4E5A2.Text = "Size:";
		this.nudHeighChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.nudHeighChrome.Location = new System.Drawing.Point(118, 2);
		this.nudHeighChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudHeighChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudHeighChrome.Name = "nudHeighChrome";
		this.nudHeighChrome.Size = new System.Drawing.Size(53, 23);
		this.nudHeighChrome.TabIndex = 151;
		this.nudHeighChrome.Value = new decimal(new int[4] { 480, 0, 0, 0 });
		this.ckbAddChromeIntoForm.AutoSize = true;
		this.ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAddChromeIntoForm.Location = new System.Drawing.Point(37, 120);
		this.ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
		this.ckbAddChromeIntoForm.Size = new System.Drawing.Size(187, 20);
		this.ckbAddChromeIntoForm.TabIndex = 157;
		this.ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
		this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
		this.ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(E4338B27);
		this.ckbLoginHotmail.AutoSize = true;
		this.ckbLoginHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLoginHotmail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbLoginHotmail.Location = new System.Drawing.Point(37, 229);
		this.ckbLoginHotmail.Name = "ckbLoginHotmail";
		this.ckbLoginHotmail.Size = new System.Drawing.Size(184, 20);
		this.ckbLoginHotmail.TabIndex = 25;
		this.ckbLoginHotmail.Text = "Tự động đăng nhập hotmail";
		this.ckbLoginHotmail.UseVisualStyleBackColor = true;
		this.txtLink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtLink.Location = new System.Drawing.Point(183, 201);
		this.txtLink.Name = "txtLink";
		this.txtLink.Size = new System.Drawing.Size(233, 23);
		this.txtLink.TabIndex = 24;
		this.txtLink.TextChanged += new System.EventHandler(CB8418B1);
		this.E537258A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E537258A.Location = new System.Drawing.Point(160, 62);
		this.E537258A.Name = "btnCauHinh";
		this.E537258A.Size = new System.Drawing.Size(75, 23);
		this.E537258A.TabIndex = 5;
		this.E537258A.Text = "Cấu hình";
		this.E537258A.Click += new System.EventHandler(E537258A_Click);
		this.ckbAutoOpenLink.AutoSize = true;
		this.ckbAutoOpenLink.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoOpenLink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAutoOpenLink.Location = new System.Drawing.Point(37, 203);
		this.ckbAutoOpenLink.Name = "ckbAutoOpenLink";
		this.ckbAutoOpenLink.Size = new System.Drawing.Size(149, 20);
		this.ckbAutoOpenLink.TabIndex = 21;
		this.ckbAutoOpenLink.Text = "Tự động mở website:";
		this.ckbAutoOpenLink.UseVisualStyleBackColor = true;
		this.ckbAutoOpenLink.CheckedChanged += new System.EventHandler(B8A20BB1);
		this.ckbAutoCloseChromeLoginFail.AutoSize = true;
		this.ckbAutoCloseChromeLoginFail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoCloseChromeLoginFail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbAutoCloseChromeLoginFail.Location = new System.Drawing.Point(37, 177);
		this.ckbAutoCloseChromeLoginFail.Name = "ckbAutoCloseChromeLoginFail";
		this.ckbAutoCloseChromeLoginFail.Size = new System.Drawing.Size(326, 20);
		this.ckbAutoCloseChromeLoginFail.TabIndex = 21;
		this.ckbAutoCloseChromeLoginFail.Text = "Tự động đóng những tab chrome đăng nhập thất bại";
		this.ckbAutoCloseChromeLoginFail.UseVisualStyleBackColor = true;
		this.ckbKhongLuuTrinhDuyet.AutoSize = true;
		this.ckbKhongLuuTrinhDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongLuuTrinhDuyet.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbKhongLuuTrinhDuyet.Location = new System.Drawing.Point(37, 378);
		this.ckbKhongLuuTrinhDuyet.Name = "ckbKhongLuuTrinhDuyet";
		this.ckbKhongLuuTrinhDuyet.Size = new System.Drawing.Size(232, 20);
		this.ckbKhongLuuTrinhDuyet.TabIndex = 21;
		this.ckbKhongLuuTrinhDuyet.Text = "Không lưu trình duyệt khi đăng nhập";
		this.ckbKhongLuuTrinhDuyet.UseVisualStyleBackColor = true;
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(125, 260);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 20;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.panel3.Controls.Add(this.rbSuDungProfile);
		this.panel3.Controls.Add(this.rbKhongDungProfile);
		this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.panel3.Location = new System.Drawing.Point(157, 88);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(273, 26);
		this.panel3.TabIndex = 8;
		this.rbSuDungProfile.AutoSize = true;
		this.rbSuDungProfile.Checked = true;
		this.rbSuDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbSuDungProfile.Location = new System.Drawing.Point(3, 3);
		this.rbSuDungProfile.Name = "rbSuDungProfile";
		this.rbSuDungProfile.Size = new System.Drawing.Size(113, 20);
		this.rbSuDungProfile.TabIndex = 4;
		this.rbSuDungProfile.TabStop = true;
		this.rbSuDungProfile.Text = "Sử dụng Profile";
		this.rbSuDungProfile.UseVisualStyleBackColor = true;
		this.rbKhongDungProfile.AutoSize = true;
		this.rbKhongDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbKhongDungProfile.Location = new System.Drawing.Point(127, 3);
		this.rbKhongDungProfile.Name = "rbKhongDungProfile";
		this.rbKhongDungProfile.Size = new System.Drawing.Size(132, 20);
		this.rbKhongDungProfile.TabIndex = 4;
		this.rbKhongDungProfile.Text = "Không dùng Profile";
		this.rbKhongDungProfile.UseVisualStyleBackColor = true;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(34, 64);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(98, 16);
		this.label3.TabIndex = 7;
		this.label3.Text = "Cấu hình đổi IP:";
		this.FE03CD87.AutoSize = true;
		this.FE03CD87.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FE03CD87.Location = new System.Drawing.Point(34, 93);
		this.FE03CD87.Name = "label1";
		this.FE03CD87.Size = new System.Drawing.Size(104, 16);
		this.FE03CD87.TabIndex = 7;
		this.FE03CD87.Text = "Tùy chọn Profile:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(453, 302);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.CE39AC97);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fMoTrinhDuyet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fMoTrinhDuyet_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.CE39AC97.ResumeLayout(false);
		this.CE39AC97.PerformLayout();
		this.A9827688.ResumeLayout(false);
		this.A9827688.PerformLayout();
		this.plAddChromeVaoFormView.ResumeLayout(false);
		this.plAddChromeVaoFormView.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudWidthChrome).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudHeighChrome).EndInit();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		base.ResumeLayout(false);
	}
}
