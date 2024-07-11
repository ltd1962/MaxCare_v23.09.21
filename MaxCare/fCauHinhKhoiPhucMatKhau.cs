using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhKhoiPhucMatKhau : Form
{
	public static bool A28F963C;

	private IContainer icontainer_0 = null;

	private Button btnCancel;

	private Button D4375627;

	private BunifuDragControl bunifuDragControl_0;

	private RadioButton rbPassNgauNhien;

	private RadioButton rbPassTuDat;

	private TextBox txtPass;

	private BunifuCards bunifuCards1;

	private Button btnClose;

	private PictureBox DA3D3D88;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel panel2;

	private CheckBox ckbKhongSuDungProfile;

	private CheckBox ckbKillSession;

	public fCauHinhKhoiPhucMatKhau()
	{
		A5B27D02();
		Language.SetLanguage(this);
		A28F963C = false;
	}

	private void A78CF48F()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(D4375627);
		Language.smethod_0(btnCancel);
	}

	private void D29F3535(object sender, EventArgs e)
	{
		Close();
	}

	private void ED1D7D11(object sender, EventArgs e)
	{
		int num = 0;
		if (rbPassNgauNhien.Checked)
		{
			num = 1;
		}
		SettingsTool.GetSettings("configGeneral").GetJson("typePass", num);
		SettingsTool.GetSettings("configGeneral").GetJson("txtPass", txtPass.Text.Trim());
		SettingsTool.GetSettings("configGeneral").GetJson("ckbKillSession", ckbKillSession.Checked);
		SettingsTool.GetSettings("configGeneral").GetJson("ckbKhongSuDungProfile", ckbKhongSuDungProfile.Checked);
		SettingsTool.Save("configGeneral");
		A28F963C = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FFB66313_Load(object sender, EventArgs e)
	{
		if (SettingsTool.GetSettings("configGeneral").GetValueInt("typePass") == 0)
		{
			rbPassTuDat.Checked = true;
		}
		else
		{
			rbPassNgauNhien.Checked = true;
		}
		txtPass.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtPass");
		ckbKillSession.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKillSession");
		ckbKhongSuDungProfile.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbKhongSuDungProfile");
		rbPassTuDat_CheckedChanged(null, null);
	}

	private void rbPassTuDat_CheckedChanged(object sender, EventArgs e)
	{
		txtPass.Enabled = rbPassTuDat.Checked;
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A5B27D02()
	{
		icontainer_0 = new Container();
		btnCancel = new Button();
		D4375627 = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		rbPassNgauNhien = new RadioButton();
		rbPassTuDat = new RadioButton();
		txtPass = new TextBox();
		bunifuCards1 = new BunifuCards();
		btnClose = new Button();
		DA3D3D88 = new PictureBox();
		panel2 = new Panel();
		ckbKhongSuDungProfile = new CheckBox();
		ckbKillSession = new CheckBox();
		bunifuCards1.SuspendLayout();
		((ISupportInitialize)DA3D3D88).BeginInit();
		panel2.SuspendLayout();
		SuspendLayout();
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(172, 165);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		D4375627.Anchor = AnchorStyles.Bottom;
		D4375627.BackColor = Color.FromArgb(53, 120, 229);
		D4375627.Cursor = Cursors.Hand;
		D4375627.FlatAppearance.BorderSize = 0;
		D4375627.FlatStyle = FlatStyle.Flat;
		D4375627.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D4375627.ForeColor = Color.White;
		D4375627.Location = new Point(68, 165);
		D4375627.Name = "btnAdd";
		D4375627.Size = new Size(92, 29);
		D4375627.TabIndex = 3;
		D4375627.Text = "Lưu";
		D4375627.UseVisualStyleBackColor = false;
		D4375627.Click += ED1D7D11;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(330, 38);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Khôi phục mật khẩu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		rbPassNgauNhien.AutoSize = true;
		rbPassNgauNhien.Cursor = Cursors.Hand;
		rbPassNgauNhien.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbPassNgauNhien.Location = new Point(27, 81);
		rbPassNgauNhien.Name = "rbPassNgauNhien";
		rbPassNgauNhien.Size = new Size(118, 20);
		rbPassNgauNhien.TabIndex = 5;
		rbPassNgauNhien.TabStop = true;
		rbPassNgauNhien.Text = "Pass ngẫu nhiên";
		rbPassNgauNhien.UseVisualStyleBackColor = true;
		rbPassTuDat.AutoSize = true;
		rbPassTuDat.Cursor = Cursors.Hand;
		rbPassTuDat.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbPassTuDat.Location = new Point(27, 55);
		rbPassTuDat.Name = "rbPassTuDat";
		rbPassTuDat.Size = new Size(104, 20);
		rbPassTuDat.TabIndex = 6;
		rbPassTuDat.TabStop = true;
		rbPassTuDat.Text = "Pass chỉ định:";
		rbPassTuDat.UseVisualStyleBackColor = true;
		rbPassTuDat.CheckedChanged += rbPassTuDat_CheckedChanged;
		txtPass.Location = new Point(127, 54);
		txtPass.Name = "txtPass";
		txtPass.Size = new Size(168, 23);
		txtPass.TabIndex = 7;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(btnClose);
		bunifuCards1.Controls.Add(DA3D3D88);
		bunifuCards1.Controls.Add(bunifuCustomLabel1);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(330, 38);
		bunifuCards1.TabIndex = 29;
		btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnClose.Cursor = Cursors.Hand;
		btnClose.FlatAppearance.BorderSize = 0;
		btnClose.FlatStyle = FlatStyle.Flat;
		btnClose.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnClose.ForeColor = Color.White;
		btnClose.Image = Resources.A13F2207;
		btnClose.Location = new Point(298, 5);
		btnClose.Name = "btnClose";
		btnClose.Size = new Size(30, 30);
		btnClose.TabIndex = 77;
		btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnClose.UseVisualStyleBackColor = true;
		btnClose.Click += btnClose_Click;
		DA3D3D88.Cursor = Cursors.Default;
		DA3D3D88.Image = Resources.Bitmap_4;
		DA3D3D88.Location = new Point(2, 6);
		DA3D3D88.Name = "pictureBox1";
		DA3D3D88.Size = new Size(34, 27);
		DA3D3D88.SizeMode = PictureBoxSizeMode.Zoom;
		DA3D3D88.TabIndex = 76;
		DA3D3D88.TabStop = false;
		panel2.BorderStyle = BorderStyle.FixedSingle;
		panel2.Controls.Add(txtPass);
		panel2.Controls.Add(ckbKillSession);
		panel2.Controls.Add(ckbKhongSuDungProfile);
		panel2.Controls.Add(rbPassTuDat);
		panel2.Controls.Add(rbPassNgauNhien);
		panel2.Controls.Add(bunifuCards1);
		panel2.Dock = DockStyle.Fill;
		panel2.Location = new Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new Size(332, 206);
		panel2.TabIndex = 30;
		ckbKhongSuDungProfile.AutoSize = true;
		ckbKhongSuDungProfile.Cursor = Cursors.Hand;
		ckbKhongSuDungProfile.Location = new Point(27, 133);
		ckbKhongSuDungProfile.Name = "ckbKhongSuDungProfile";
		ckbKhongSuDungProfile.Size = new Size(198, 20);
		ckbKhongSuDungProfile.TabIndex = 30;
		ckbKhongSuDungProfile.Text = "Không sử dụng profile chrome";
		ckbKhongSuDungProfile.UseVisualStyleBackColor = true;
		ckbKillSession.AutoSize = true;
		ckbKillSession.Cursor = Cursors.Hand;
		ckbKillSession.Location = new Point(27, 107);
		ckbKillSession.Name = "ckbKillSession";
		ckbKillSession.Size = new Size(144, 20);
		ckbKillSession.TabIndex = 30;
		ckbKillSession.Text = "Đăng xuất thiết bị cũ";
		ckbKillSession.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(332, 206);
		base.Controls.Add(btnCancel);
		base.Controls.Add(D4375627);
		base.Controls.Add(panel2);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhKhoiPhucMatKhau";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += FFB66313_Load;
		bunifuCards1.ResumeLayout(performLayout: false);
		((ISupportInitialize)DA3D3D88).EndInit();
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
