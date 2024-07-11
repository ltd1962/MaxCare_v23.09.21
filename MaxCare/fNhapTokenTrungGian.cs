using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapTokenTrungGian : Form
{
	public static bool bool_0;

	private IContainer FCB86D90 = null;

	private BunifuCards bunifuCards1;

	private Panel F034CCA5;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl ED140622;

	private PictureBox C7B8868A;

	private Label label2;

	private TextBox AF024510;

	private Button btnCheckLiveTokenTg;

	private Label label1;

	private TextBox txtCookie;

	public fNhapTokenTrungGian()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
	}

	private void A4B13F13(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configGeneral").GetJson("cookie", txtCookie.Text);
		SettingsTool.GetSettings("configGeneral").GetJson("token", AF024510.Text);
		SettingsTool.Save("configGeneral");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E51E682F(object sender, EventArgs e)
	{
		txtCookie.Text = SettingsTool.GetSettings("configGeneral").GetValue("cookie");
		AF024510.Text = SettingsTool.GetSettings("configGeneral").GetValue("token");
	}

	private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
	{
		string text = "";
		text = (CheckInfoAccountv2.CheckToken(txtCookie.Text, AF024510.Text, "", "") ? "Live" : ((!CheckInfoAccountv2.CheckLiveCookie(txtCookie.Text, "", "", 0).StartsWith("1|")) ? "Cookie die" : "Token die"));
		MessageBoxHelper.Show(text + "!");
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && FCB86D90 != null)
		{
			FCB86D90.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.FCB86D90 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapTokenTrungGian));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.F034CCA5 = new System.Windows.Forms.Panel();
		this.C7B8868A = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.ED140622 = new Bunifu.Framework.UI.BunifuDragControl(this.FCB86D90);
		this.label2 = new System.Windows.Forms.Label();
		this.AF024510 = new System.Windows.Forms.TextBox();
		this.btnCheckLiveTokenTg = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.txtCookie = new System.Windows.Forms.TextBox();
		this.bunifuCards1.SuspendLayout();
		this.F034CCA5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.C7B8868A).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.F034CCA5);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(449, 34);
		this.bunifuCards1.TabIndex = 0;
		this.F034CCA5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.F034CCA5.BackColor = System.Drawing.Color.White;
		this.F034CCA5.Controls.Add(this.C7B8868A);
		this.F034CCA5.Controls.Add(this.btnMinimize);
		this.F034CCA5.Controls.Add(this.bunifuCustomLabel1);
		this.F034CCA5.Location = new System.Drawing.Point(0, 3);
		this.F034CCA5.Name = "pnlHeader";
		this.F034CCA5.Size = new System.Drawing.Size(449, 28);
		this.F034CCA5.TabIndex = 9;
		this.C7B8868A.Cursor = System.Windows.Forms.Cursors.Default;
		this.C7B8868A.Image = Resources.Bitmap_4;
		this.C7B8868A.Location = new System.Drawing.Point(3, 2);
		this.C7B8868A.Name = "pictureBox1";
		this.C7B8868A.Size = new System.Drawing.Size(34, 27);
		this.C7B8868A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.C7B8868A.TabIndex = 17;
		this.C7B8868A.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(417, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(A4B13F13);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(449, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Nhập Token trung gian";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(230, 143);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(126, 143);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.ED140622.Fixed = true;
		this.ED140622.Horizontal = true;
		this.ED140622.TargetControl = this.bunifuCustomLabel1;
		this.ED140622.Vertical = true;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(26, 95);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(109, 16);
		this.label2.TabIndex = 36;
		this.label2.Text = "Token trung gian:";
		this.AF024510.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.AF024510.Location = new System.Drawing.Point(142, 92);
		this.AF024510.Name = "txtToken";
		this.AF024510.Size = new System.Drawing.Size(196, 23);
		this.AF024510.TabIndex = 35;
		this.btnCheckLiveTokenTg.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCheckLiveTokenTg.Location = new System.Drawing.Point(344, 62);
		this.btnCheckLiveTokenTg.Name = "btnCheckLiveTokenTg";
		this.btnCheckLiveTokenTg.Size = new System.Drawing.Size(65, 54);
		this.btnCheckLiveTokenTg.TabIndex = 37;
		this.btnCheckLiveTokenTg.Text = "Kiểm tra";
		this.btnCheckLiveTokenTg.Click += new System.EventHandler(btnCheckLiveTokenTg_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(26, 66);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(112, 16);
		this.label1.TabIndex = 39;
		this.label1.Text = "Cookie trung gian:";
		this.txtCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCookie.Location = new System.Drawing.Point(142, 63);
		this.txtCookie.Name = "txtCookie";
		this.txtCookie.Size = new System.Drawing.Size(196, 23);
		this.txtCookie.TabIndex = 38;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 190);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.txtCookie);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.AF024510);
		base.Controls.Add(this.btnCheckLiveTokenTg);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapTokenTrungGian";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(E51E682F);
		this.bunifuCards1.ResumeLayout(false);
		this.F034CCA5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.C7B8868A).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
