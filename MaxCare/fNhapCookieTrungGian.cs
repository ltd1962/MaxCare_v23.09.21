using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapCookieTrungGian : Form
{
	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel B1800117;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label2;

	private TextBox txtCookie;

	private Button C01DC58F;

	public fNhapCookieTrungGian()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
	}

	private void E49E6A8E()
	{
		Language.smethod_0(B1800117);
		Language.smethod_0(label2);
		Language.smethod_0(label2);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A0B2EBBA(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configGeneral").GetJson("cookie", txtCookie.Text);
		SettingsTool.Save("configGeneral");
		bool_0 = true;
		Close();
	}

	private void D014828C(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapCookieTrungGian_Load(object sender, EventArgs e)
	{
		txtCookie.Text = SettingsTool.GetSettings("configGeneral").GetValue("cookie");
	}

	private void C01DC58F_Click(object sender, EventArgs e)
	{
		if (CheckInfoAccountv2.CheckLiveCookie(txtCookie.Text, "", "", 0).StartsWith("1|"))
		{
			MessageBoxHelper.Show("Cookie live!");
		}
		else
		{
			MessageBoxHelper.Show("Cookie die!");
		}
	}

	protected override void Dispose(bool C98FB39C)
	{
		if (C98FB39C && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C98FB39C);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapCookieTrungGian));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.B1800117 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label2 = new System.Windows.Forms.Label();
		this.txtCookie = new System.Windows.Forms.TextBox();
		this.C01DC58F = new System.Windows.Forms.Button();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(449, 34);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.B1800117);
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(449, 28);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
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
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.B1800117.BackColor = System.Drawing.Color.Transparent;
		this.B1800117.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B1800117.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B1800117.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B1800117.ForeColor = System.Drawing.Color.Black;
		this.B1800117.Location = new System.Drawing.Point(0, 0);
		this.B1800117.Name = "bunifuCustomLabel1";
		this.B1800117.Size = new System.Drawing.Size(449, 28);
		this.B1800117.TabIndex = 1;
		this.B1800117.Text = "Nhập Cookie trung gian";
		this.B1800117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(230, 112);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(D014828C);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(126, 112);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(A0B2EBBA);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.B1800117;
		this.bunifuDragControl_0.Vertical = true;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(31, 61);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(112, 16);
		this.label2.TabIndex = 36;
		this.label2.Text = "Cookie trung gian:";
		this.txtCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtCookie.Location = new System.Drawing.Point(147, 58);
		this.txtCookie.Name = "txtCookie";
		this.txtCookie.Size = new System.Drawing.Size(196, 23);
		this.txtCookie.TabIndex = 35;
		this.C01DC58F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C01DC58F.Location = new System.Drawing.Point(349, 58);
		this.C01DC58F.Name = "btnCheckLiveTokenTg";
		this.C01DC58F.Size = new System.Drawing.Size(65, 23);
		this.C01DC58F.TabIndex = 37;
		this.C01DC58F.Text = "Kiểm tra";
		this.C01DC58F.Click += new System.EventHandler(C01DC58F_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 159);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.txtCookie);
		base.Controls.Add(this.C01DC58F);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapCookieTrungGian";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fNhapCookieTrungGian_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
