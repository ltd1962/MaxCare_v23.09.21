using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDShareBai : Form
{
	private BA076FAA ba076FAA_0;

	private ucTuongTacProfile ucTuongTacProfile_0;

	private JSON_Settings gclass8_0;

	private string E80D17BD;

	private string D30D26B3;

	private string string_0;

	private int int_0;

	public static bool CC1F0516;

	private IContainer BCADB48A = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl F03C6CB8;

	private Panel panel1;

	private TextBox C81A2D8E;

	private Label EB89B5A9;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards E83DFF9C;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox C318CA9C;

	private Panel plVanBan;

	private NumericUpDown C982D331;

	private NumericUpDown E836869B;

	private Label label20;

	private Label BC8CD4B9;

	private GroupBox groupBox2;

	private Panel plDangBaiLenPage;

	private Label F53BAE8A;

	private NumericUpDown DAB9AC98;

	private Label label23;

	private NumericUpDown A1B8A7BD;

	private Panel plDangBaiLenNhom;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown C70A4222;

	private Label label24;

	private Label label26;

	private CheckBox ckbShareBaiLenPage;

	private CheckBox CEBB5423;

	private CheckBox ckbShareBaiLenTuong;

	private Label lblLinkChiaSe;

	private CheckBox ckbOnlyShareNhomKhongKiemDuyet;

	private Label label3;

	private CheckBox B81BAE2B;

	private CheckBox ckbKhongShareTrung;

	private CheckBox ckbUuTienNhomNhieuThanhVien;

	private Panel F936D597;

	private RadioButton F1B0D28B;

	private RadioButton F41A2B3E;

	private Label CBB79138;

	private ToolTip toolTip_0;

	private Panel D228E034;

	private RichTextBox txtNhomTuNhap;

	private CheckBox ckbChiShareNhomDaThamGia;

	private ComboBox cbbKieuShare;

	private RichTextBox txtLinkChiaSe;

	private CheckBox A6BA0D98;

	private ComboBox E1ACEB85;

	private Button btnHuongDanNhapNoiDung;

	private LinkLabel B105539A;

	private RichTextBox txtNoiDung;

	private Label label4;

	private Label label8;

	private Label lblNoiDung;

	private LinkLabel CE91B62E;

	private LinkLabel lblTuongTacNhom;

	private CheckBox ckbTuDongXoaNoiDung;

	public fHDShareBai(string string_1, int int_1 = 0, string ECBDFB12 = "")
	{
		InitializeComponent();
		CC1F0516 = false;
		E80D17BD = string_1;
		string_0 = ECBDFB12;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Share bài";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			D30D26B3 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C81A2D8E.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(ECBDFB12);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			C81A2D8E.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
		ba076FAA_0 = new BA076FAA(gclass8_0)
		{
			Visible = false
		};
		base.Controls.Add(ba076FAA_0);
		ba076FAA_0.AF142CA5(bool_0: true);
		ucTuongTacProfile_0 = new ucTuongTacProfile(gclass8_0)
		{
			Visible = false
		};
		base.Controls.Add(ucTuongTacProfile_0);
		ucTuongTacProfile_0.AF142CA5(bool_0: true);
	}

	private void BA81EE26(object sender, EventArgs e)
	{
		method_0();
		method_1();
		try
		{
			E836869B.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			C982D331.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			txtLinkChiaSe.Text = gclass8_0.GetValue("txtLinkChiaSe");
			cbbKieuShare.SelectedIndex = gclass8_0.GetValueInt("cbbKieuShare");
			C318CA9C.Checked = gclass8_0.GetValueBool("ckbVanBan");
			txtNoiDung.Text = gclass8_0.GetValue("txtNoiDung");
			E1ACEB85.SelectedIndex = gclass8_0.GetValueInt("typeNganCach");
			ckbTuDongXoaNoiDung.Checked = gclass8_0.GetValueBool("ckbTuDongXoaNoiDung");
			A6BA0D98.Checked = gclass8_0.GetValueBool("ckbTuongTacBaiViet");
			ckbShareBaiLenTuong.Checked = gclass8_0.GetValueBool("ckbShareBaiLenTuong");
			CEBB5423.Checked = gclass8_0.GetValueBool("ckbShareBaiLenNhom");
			C70A4222.Value = gclass8_0.GetValueInt("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = gclass8_0.GetValueInt("nudCountGroupTo", 1);
			if (gclass8_0.GetValueInt("typeShare") == 0)
			{
				F41A2B3E.Checked = true;
			}
			else
			{
				F1B0D28B.Checked = true;
			}
			txtNhomTuNhap.Text = gclass8_0.GetValue("lstNhomTuNhap");
			ckbChiShareNhomDaThamGia.Checked = gclass8_0.GetValueBool("ckbChiShareNhomDaThamGia");
			ckbOnlyShareNhomKhongKiemDuyet.Checked = gclass8_0.GetValueBool("ckbOnlyShareNhomKhongKiemDuyet");
			ckbUuTienNhomNhieuThanhVien.Checked = gclass8_0.GetValueBool("ckbUuTienNhomNhieuThanhVien");
			ckbKhongShareTrung.Checked = gclass8_0.GetValueBool("ckbKhongShareTrung");
			B81BAE2B.Checked = gclass8_0.GetValueBool("ckbTuongTacNhom");
			ckbShareBaiLenPage.Checked = gclass8_0.GetValueBool("ckbShareBaiLenPage");
			A1B8A7BD.Value = gclass8_0.GetValueInt("nudCountPageFrom", 1);
			DAB9AC98.Value = gclass8_0.GetValueInt("nudCountPageTo", 1);
		}
		catch (Exception)
		{
		}
		A43D822C();
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "(m.fb) Đăng link", "(m.fb) Mở Link > click Chia sẻ", "(www) Đăng link" };
		Common.F714B10E(cbbKieuShare, e6A5AC);
	}

	private void method_1()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(E1ACEB85, e6A5AC);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = C81A2D8E.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		gclass8_0.GetJson("nudDelayFrom", E836869B.Value);
		gclass8_0.GetJson("nudDelayTo", C982D331.Value);
		gclass8_0.GetJson("txtLinkChiaSe", txtLinkChiaSe.Text.Trim());
		gclass8_0.GetJson("cbbKieuShare", cbbKieuShare.SelectedIndex);
		gclass8_0.GetJson("ckbVanBan", C318CA9C.Checked);
		gclass8_0.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		gclass8_0.GetJson("typeNganCach", E1ACEB85.SelectedIndex);
		gclass8_0.GetJson("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		gclass8_0.GetJson("ckbTuongTacBaiViet", A6BA0D98.Checked);
		gclass8_0.GetJson("ckbShareBaiLenTuong", ckbShareBaiLenTuong.Checked);
		gclass8_0.GetJson("ckbShareBaiLenNhom", CEBB5423.Checked);
		gclass8_0.GetJson("nudCountGroupFrom", C70A4222.Value);
		gclass8_0.GetJson("nudCountGroupTo", nudCountGroupTo.Value);
		int num = 0;
		if (F1B0D28B.Checked)
		{
			num = 1;
		}
		gclass8_0.GetJson("typeShare", num);
		gclass8_0.GetJson("lstNhomTuNhap", txtNhomTuNhap.Text);
		gclass8_0.GetJson("ckbChiShareNhomDaThamGia", ckbChiShareNhomDaThamGia.Checked);
		gclass8_0.GetJson("ckbOnlyShareNhomKhongKiemDuyet", ckbOnlyShareNhomKhongKiemDuyet.Checked);
		gclass8_0.GetJson("ckbUuTienNhomNhieuThanhVien", ckbUuTienNhomNhieuThanhVien.Checked);
		gclass8_0.GetJson("ckbKhongShareTrung", ckbKhongShareTrung.Checked);
		gclass8_0.GetJson("ckbTuongTacNhom", B81BAE2B.Checked);
		gclass8_0.GetJson("ckbShareBaiLenPage", ckbShareBaiLenPage.Checked);
		gclass8_0.GetJson("nudCountPageFrom", A1B8A7BD.Value);
		gclass8_0.GetJson("nudCountPageTo", DAB9AC98.Value);
		string text2 = gclass8_0.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E80D17BD, text, D30D26B3, text2))
				{
					CC1F0516 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_0, text, text2))
			{
				CC1F0516 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AB03C61F(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void A43D822C()
	{
		CEBB5423_CheckedChanged(null, null);
		ckbShareBaiLenPage_CheckedChanged(null, null);
		C318CA9C_CheckedChanged(null, null);
		BC830E0A(null, null);
		A6BA0D98_CheckedChanged(null, null);
		F1B0D28B_CheckedChanged(null, null);
	}

	private void C318CA9C_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = C318CA9C.Checked;
	}

	private void CEBB5423_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = CEBB5423.Checked;
	}

	private void ckbShareBaiLenPage_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbShareBaiLenPage.Checked;
	}

	private void BC830E0A(object sender, EventArgs e)
	{
		lblTuongTacNhom.Enabled = B81BAE2B.Checked;
	}

	private void F1B0D28B_CheckedChanged(object sender, EventArgs e)
	{
		D228E034.Enabled = F1B0D28B.Checked;
		if (F1B0D28B.Checked)
		{
			if (!ckbChiShareNhomDaThamGia.Checked)
			{
				ckbOnlyShareNhomKhongKiemDuyet.Checked = false;
				ckbOnlyShareNhomKhongKiemDuyet.Enabled = false;
				ckbUuTienNhomNhieuThanhVien.Checked = false;
				ckbUuTienNhomNhieuThanhVien.Enabled = false;
			}
		}
		else
		{
			ckbOnlyShareNhomKhongKiemDuyet.Enabled = true;
			ckbUuTienNhomNhieuThanhVien.Enabled = true;
		}
	}

	private void AF3CA4B3(object sender, EventArgs e)
	{
		Common.smethod_49(sender as RichTextBox, F1B0D28B);
	}

	private void ckbChiShareNhomDaThamGia_CheckedChanged(object sender, EventArgs e)
	{
		if (!ckbChiShareNhomDaThamGia.Checked)
		{
			ckbOnlyShareNhomKhongKiemDuyet.Checked = false;
			ckbOnlyShareNhomKhongKiemDuyet.Enabled = false;
			ckbUuTienNhomNhieuThanhVien.Checked = false;
			ckbUuTienNhomNhieuThanhVien.Enabled = false;
		}
		else
		{
			ckbOnlyShareNhomKhongKiemDuyet.Enabled = true;
			ckbUuTienNhomNhieuThanhVien.Enabled = true;
		}
	}

	private void txtLinkChiaSe_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtLinkChiaSe, lblLinkChiaSe);
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtNoiDung, lblNoiDung, E1ACEB85.SelectedIndex);
	}

	private void B5A3D826(object sender, EventArgs e)
	{
		if (E1ACEB85.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtNoiDung.Focus();
	}

	private void B105539A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void A6BA0D98_CheckedChanged(object sender, EventArgs e)
	{
		CE91B62E.Enabled = A6BA0D98.Checked;
	}

	private void CE91B62E_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_18(ba076FAA_0, this);
	}

	private void AFB900AA(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_18(ucTuongTacProfile_0, this);
	}

	private void F7AC4A80(object sender, EventArgs e)
	{
		Common.F9202C12(txtNoiDung, lblNoiDung, E1ACEB85.SelectedIndex);
	}

	private void cbbKieuShare_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool FA8D7CA4)
	{
		if (FA8D7CA4 && BCADB48A != null)
		{
			BCADB48A.Dispose();
		}
		base.Dispose(FA8D7CA4);
	}

	private void InitializeComponent()
	{
		this.BCADB48A = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDShareBai));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.BCADB48A);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F03C6CB8 = new Bunifu.Framework.UI.BunifuDragControl(this.BCADB48A);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.A6BA0D98 = new System.Windows.Forms.CheckBox();
		this.txtLinkChiaSe = new System.Windows.Forms.RichTextBox();
		this.CE91B62E = new System.Windows.Forms.LinkLabel();
		this.cbbKieuShare = new System.Windows.Forms.ComboBox();
		this.label3 = new System.Windows.Forms.Label();
		this.lblLinkChiaSe = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.plDangBaiLenPage = new System.Windows.Forms.Panel();
		this.F53BAE8A = new System.Windows.Forms.Label();
		this.DAB9AC98 = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.A1B8A7BD = new System.Windows.Forms.NumericUpDown();
		this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
		this.ckbKhongShareTrung = new System.Windows.Forms.CheckBox();
		this.ckbUuTienNhomNhieuThanhVien = new System.Windows.Forms.CheckBox();
		this.lblTuongTacNhom = new System.Windows.Forms.LinkLabel();
		this.ckbOnlyShareNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
		this.F936D597 = new System.Windows.Forms.Panel();
		this.D228E034 = new System.Windows.Forms.Panel();
		this.txtNhomTuNhap = new System.Windows.Forms.RichTextBox();
		this.ckbChiShareNhomDaThamGia = new System.Windows.Forms.CheckBox();
		this.F1B0D28B = new System.Windows.Forms.RadioButton();
		this.F41A2B3E = new System.Windows.Forms.RadioButton();
		this.CBB79138 = new System.Windows.Forms.Label();
		this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		this.B81BAE2B = new System.Windows.Forms.CheckBox();
		this.C70A4222 = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.ckbShareBaiLenPage = new System.Windows.Forms.CheckBox();
		this.CEBB5423 = new System.Windows.Forms.CheckBox();
		this.ckbShareBaiLenTuong = new System.Windows.Forms.CheckBox();
		this.C982D331 = new System.Windows.Forms.NumericUpDown();
		this.E836869B = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.BC8CD4B9 = new System.Windows.Forms.Label();
		this.plVanBan = new System.Windows.Forms.Panel();
		this.ckbTuDongXoaNoiDung = new System.Windows.Forms.CheckBox();
		this.E1ACEB85 = new System.Windows.Forms.ComboBox();
		this.btnHuongDanNhapNoiDung = new System.Windows.Forms.Button();
		this.B105539A = new System.Windows.Forms.LinkLabel();
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.lblNoiDung = new System.Windows.Forms.Label();
		this.btnAdd = new System.Windows.Forms.Button();
		this.C318CA9C = new System.Windows.Forms.CheckBox();
		this.C81A2D8E = new System.Windows.Forms.TextBox();
		this.EB89B5A9 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.E83DFF9C = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.BCADB48A);
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.plDangBaiLenPage.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DAB9AC98).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A1B8A7BD).BeginInit();
		this.plDangBaiLenNhom.SuspendLayout();
		this.F936D597.SuspendLayout();
		this.D228E034.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C70A4222).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C982D331).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E836869B).BeginInit();
		this.plVanBan.SuspendLayout();
		this.E83DFF9C.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(755, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Share bài";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F03C6CB8.Fixed = true;
		this.F03C6CB8.Horizontal = true;
		this.F03C6CB8.TargetControl = this.pnlHeader;
		this.F03C6CB8.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(755, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(724, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 0;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
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
		this.panel1.Controls.Add(this.A6BA0D98);
		this.panel1.Controls.Add(this.txtLinkChiaSe);
		this.panel1.Controls.Add(this.CE91B62E);
		this.panel1.Controls.Add(this.cbbKieuShare);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.lblLinkChiaSe);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.C982D331);
		this.panel1.Controls.Add(this.E836869B);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.BC8CD4B9);
		this.panel1.Controls.Add(this.plVanBan);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.C318CA9C);
		this.panel1.Controls.Add(this.C81A2D8E);
		this.panel1.Controls.Add(this.EB89B5A9);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.E83DFF9C);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(758, 604);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(AB03C61F);
		this.A6BA0D98.AutoSize = true;
		this.A6BA0D98.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A6BA0D98.Location = new System.Drawing.Point(21, 525);
		this.A6BA0D98.Name = "ckbTuongTacBaiViet";
		this.A6BA0D98.Size = new System.Drawing.Size(219, 20);
		this.A6BA0D98.TabIndex = 107;
		this.A6BA0D98.Text = "Tương ta\u0301c bài viết trươ\u0301c khi share";
		this.A6BA0D98.UseVisualStyleBackColor = true;
		this.A6BA0D98.CheckedChanged += new System.EventHandler(A6BA0D98_CheckedChanged);
		this.txtLinkChiaSe.Location = new System.Drawing.Point(21, 124);
		this.txtLinkChiaSe.Name = "txtLinkChiaSe";
		this.txtLinkChiaSe.Size = new System.Drawing.Size(331, 89);
		this.txtLinkChiaSe.TabIndex = 34;
		this.txtLinkChiaSe.Text = "";
		this.txtLinkChiaSe.WordWrap = false;
		this.txtLinkChiaSe.TextChanged += new System.EventHandler(txtLinkChiaSe_TextChanged);
		this.CE91B62E.AutoSize = true;
		this.CE91B62E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CE91B62E.Location = new System.Drawing.Point(236, 526);
		this.CE91B62E.Name = "lblCaiDatTuongTacBaiViet";
		this.CE91B62E.Size = new System.Drawing.Size(47, 16);
		this.CE91B62E.TabIndex = 183;
		this.CE91B62E.TabStop = true;
		this.CE91B62E.Text = "Cài đặt";
		this.CE91B62E.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(CE91B62E_LinkClicked);
		this.cbbKieuShare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbKieuShare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbKieuShare.FormattingEnabled = true;
		this.cbbKieuShare.Location = new System.Drawing.Point(96, 219);
		this.cbbKieuShare.Name = "cbbKieuShare";
		this.cbbKieuShare.Size = new System.Drawing.Size(256, 24);
		this.cbbKieuShare.TabIndex = 106;
		this.cbbKieuShare.SelectedIndexChanged += new System.EventHandler(cbbKieuShare_SelectedIndexChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(18, 222);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(72, 16);
		this.label3.TabIndex = 66;
		this.label3.Text = "Kiểu share:";
		this.lblLinkChiaSe.AutoSize = true;
		this.lblLinkChiaSe.Location = new System.Drawing.Point(18, 106);
		this.lblLinkChiaSe.Name = "lblLinkChiaSe";
		this.lblLinkChiaSe.Size = new System.Drawing.Size(136, 16);
		this.lblLinkChiaSe.TabIndex = 64;
		this.lblLinkChiaSe.Text = "Link bài cần share (0):";
		this.groupBox2.Controls.Add(this.plDangBaiLenPage);
		this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbShareBaiLenPage);
		this.groupBox2.Controls.Add(this.CEBB5423);
		this.groupBox2.Controls.Add(this.ckbShareBaiLenTuong);
		this.groupBox2.Location = new System.Drawing.Point(373, 78);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(358, 467);
		this.groupBox2.TabIndex = 62;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn";
		this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenPage.Controls.Add(this.F53BAE8A);
		this.plDangBaiLenPage.Controls.Add(this.DAB9AC98);
		this.plDangBaiLenPage.Controls.Add(this.label23);
		this.plDangBaiLenPage.Controls.Add(this.A1B8A7BD);
		this.plDangBaiLenPage.Location = new System.Drawing.Point(33, 434);
		this.plDangBaiLenPage.Name = "plDangBaiLenPage";
		this.plDangBaiLenPage.Size = new System.Drawing.Size(313, 27);
		this.plDangBaiLenPage.TabIndex = 1;
		this.F53BAE8A.AutoSize = true;
		this.F53BAE8A.Location = new System.Drawing.Point(3, 3);
		this.F53BAE8A.Name = "label21";
		this.F53BAE8A.Size = new System.Drawing.Size(95, 16);
		this.F53BAE8A.TabIndex = 49;
		this.F53BAE8A.Text = "Số lượng page:";
		this.DAB9AC98.Location = new System.Drawing.Point(187, 1);
		this.DAB9AC98.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DAB9AC98.Name = "nudCountPageTo";
		this.DAB9AC98.Size = new System.Drawing.Size(56, 23);
		this.DAB9AC98.TabIndex = 48;
		this.label23.AutoSize = true;
		this.label23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label23.Location = new System.Drawing.Point(166, 3);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(18, 16);
		this.label23.TabIndex = 51;
		this.label23.Text = ">";
		this.A1B8A7BD.Location = new System.Drawing.Point(108, 1);
		this.A1B8A7BD.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A1B8A7BD.Name = "nudCountPageFrom";
		this.A1B8A7BD.Size = new System.Drawing.Size(56, 23);
		this.A1B8A7BD.TabIndex = 47;
		this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenNhom.Controls.Add(this.ckbKhongShareTrung);
		this.plDangBaiLenNhom.Controls.Add(this.ckbUuTienNhomNhieuThanhVien);
		this.plDangBaiLenNhom.Controls.Add(this.lblTuongTacNhom);
		this.plDangBaiLenNhom.Controls.Add(this.ckbOnlyShareNhomKhongKiemDuyet);
		this.plDangBaiLenNhom.Controls.Add(this.F936D597);
		this.plDangBaiLenNhom.Controls.Add(this.CBB79138);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
		this.plDangBaiLenNhom.Controls.Add(this.B81BAE2B);
		this.plDangBaiLenNhom.Controls.Add(this.C70A4222);
		this.plDangBaiLenNhom.Controls.Add(this.label24);
		this.plDangBaiLenNhom.Controls.Add(this.label26);
		this.plDangBaiLenNhom.Location = new System.Drawing.Point(33, 72);
		this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		this.plDangBaiLenNhom.Size = new System.Drawing.Size(313, 334);
		this.plDangBaiLenNhom.TabIndex = 1;
		this.ckbKhongShareTrung.AutoSize = true;
		this.ckbKhongShareTrung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongShareTrung.Location = new System.Drawing.Point(6, 281);
		this.ckbKhongShareTrung.Name = "ckbKhongShareTrung";
		this.ckbKhongShareTrung.Size = new System.Drawing.Size(167, 20);
		this.ckbKhongShareTrung.TabIndex = 2;
		this.ckbKhongShareTrung.Text = "Không share trùng nhóm";
		this.ckbKhongShareTrung.UseVisualStyleBackColor = true;
		this.ckbUuTienNhomNhieuThanhVien.AutoSize = true;
		this.ckbUuTienNhomNhieuThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUuTienNhomNhieuThanhVien.Location = new System.Drawing.Point(6, 255);
		this.ckbUuTienNhomNhieuThanhVien.Name = "ckbUuTienNhomNhieuThanhVien";
		this.ckbUuTienNhomNhieuThanhVien.Size = new System.Drawing.Size(254, 20);
		this.ckbUuTienNhomNhieuThanhVien.TabIndex = 1;
		this.ckbUuTienNhomNhieuThanhVien.Text = "Ưu tiên share nhóm có nhiều thành viên";
		this.ckbUuTienNhomNhieuThanhVien.UseVisualStyleBackColor = true;
		this.lblTuongTacNhom.AutoSize = true;
		this.lblTuongTacNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblTuongTacNhom.Location = new System.Drawing.Point(213, 308);
		this.lblTuongTacNhom.Name = "lblTuongTacNhom";
		this.lblTuongTacNhom.Size = new System.Drawing.Size(47, 16);
		this.lblTuongTacNhom.TabIndex = 183;
		this.lblTuongTacNhom.TabStop = true;
		this.lblTuongTacNhom.Text = "Cài đặt";
		this.lblTuongTacNhom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(AFB900AA);
		this.ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
		this.ckbOnlyShareNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyShareNhomKhongKiemDuyet.Location = new System.Drawing.Point(6, 229);
		this.ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
		this.ckbOnlyShareNhomKhongKiemDuyet.Size = new System.Drawing.Size(220, 20);
		this.ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
		this.ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
		this.ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		this.F936D597.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F936D597.Controls.Add(this.D228E034);
		this.F936D597.Controls.Add(this.F1B0D28B);
		this.F936D597.Controls.Add(this.F41A2B3E);
		this.F936D597.Location = new System.Drawing.Point(6, 52);
		this.F936D597.Name = "panel3";
		this.F936D597.Size = new System.Drawing.Size(300, 171);
		this.F936D597.TabIndex = 67;
		this.D228E034.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D228E034.Controls.Add(this.txtNhomTuNhap);
		this.D228E034.Controls.Add(this.ckbChiShareNhomDaThamGia);
		this.D228E034.Location = new System.Drawing.Point(22, 49);
		this.D228E034.Name = "plTuNhap";
		this.D228E034.Size = new System.Drawing.Size(273, 117);
		this.D228E034.TabIndex = 193;
		this.txtNhomTuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtNhomTuNhap.Location = new System.Drawing.Point(3, 3);
		this.txtNhomTuNhap.Name = "txtNhomTuNhap";
		this.txtNhomTuNhap.Size = new System.Drawing.Size(265, 88);
		this.txtNhomTuNhap.TabIndex = 34;
		this.txtNhomTuNhap.Text = "";
		this.txtNhomTuNhap.WordWrap = false;
		this.txtNhomTuNhap.TextChanged += new System.EventHandler(AF3CA4B3);
		this.ckbChiShareNhomDaThamGia.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbChiShareNhomDaThamGia.AutoSize = true;
		this.ckbChiShareNhomDaThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChiShareNhomDaThamGia.Location = new System.Drawing.Point(3, 92);
		this.ckbChiShareNhomDaThamGia.Name = "ckbChiShareNhomDaThamGia";
		this.ckbChiShareNhomDaThamGia.Size = new System.Drawing.Size(190, 20);
		this.ckbChiShareNhomDaThamGia.TabIndex = 33;
		this.ckbChiShareNhomDaThamGia.Text = "Chỉ Share nhóm đã tham gia";
		this.ckbChiShareNhomDaThamGia.UseVisualStyleBackColor = true;
		this.ckbChiShareNhomDaThamGia.CheckedChanged += new System.EventHandler(ckbChiShareNhomDaThamGia_CheckedChanged);
		this.F1B0D28B.AutoSize = true;
		this.F1B0D28B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F1B0D28B.Location = new System.Drawing.Point(3, 27);
		this.F1B0D28B.Name = "rbTuNhap";
		this.F1B0D28B.Size = new System.Drawing.Size(197, 20);
		this.F1B0D28B.TabIndex = 1;
		this.F1B0D28B.Text = "Nhóm do người dùng nhập (0)";
		this.F1B0D28B.UseVisualStyleBackColor = true;
		this.F1B0D28B.CheckedChanged += new System.EventHandler(F1B0D28B_CheckedChanged);
		this.F41A2B3E.AutoSize = true;
		this.F41A2B3E.Checked = true;
		this.F41A2B3E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F41A2B3E.Location = new System.Drawing.Point(3, 3);
		this.F41A2B3E.Name = "rbRandom";
		this.F41A2B3E.Size = new System.Drawing.Size(197, 20);
		this.F41A2B3E.TabIndex = 0;
		this.F41A2B3E.TabStop = true;
		this.F41A2B3E.Text = "Ngẫu nhiên nhóm đã tham gia";
		this.F41A2B3E.UseVisualStyleBackColor = true;
		this.CBB79138.AutoSize = true;
		this.CBB79138.Location = new System.Drawing.Point(3, 31);
		this.CBB79138.Name = "label11";
		this.CBB79138.Size = new System.Drawing.Size(100, 16);
		this.CBB79138.TabIndex = 66;
		this.CBB79138.Text = "Tùy chọn nhóm:";
		this.nudCountGroupTo.Location = new System.Drawing.Point(187, 4);
		this.nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupTo.Name = "nudCountGroupTo";
		this.nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupTo.TabIndex = 53;
		this.B81BAE2B.AutoSize = true;
		this.B81BAE2B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B81BAE2B.Location = new System.Drawing.Point(6, 307);
		this.B81BAE2B.Name = "ckbTuongTacNhom";
		this.B81BAE2B.Size = new System.Drawing.Size(210, 20);
		this.B81BAE2B.TabIndex = 57;
		this.B81BAE2B.Text = "Tương tác nhóm trước khi share";
		this.B81BAE2B.UseVisualStyleBackColor = true;
		this.B81BAE2B.CheckedChanged += new System.EventHandler(BC830E0A);
		this.C70A4222.Location = new System.Drawing.Point(108, 4);
		this.C70A4222.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C70A4222.Name = "nudCountGroupFrom";
		this.C70A4222.Size = new System.Drawing.Size(56, 23);
		this.C70A4222.TabIndex = 52;
		this.label24.AutoSize = true;
		this.label24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label24.Location = new System.Drawing.Point(166, 6);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(18, 16);
		this.label24.TabIndex = 56;
		this.label24.Text = ">";
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(3, 6);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(99, 16);
		this.label26.TabIndex = 54;
		this.label26.Text = "Số lượng nhóm:";
		this.ckbShareBaiLenPage.AutoSize = true;
		this.ckbShareBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareBaiLenPage.Location = new System.Drawing.Point(10, 410);
		this.ckbShareBaiLenPage.Name = "ckbShareBaiLenPage";
		this.ckbShareBaiLenPage.Size = new System.Drawing.Size(134, 20);
		this.ckbShareBaiLenPage.TabIndex = 0;
		this.ckbShareBaiLenPage.Text = "Share bài lên page";
		this.ckbShareBaiLenPage.UseVisualStyleBackColor = true;
		this.ckbShareBaiLenPage.CheckedChanged += new System.EventHandler(ckbShareBaiLenPage_CheckedChanged);
		this.CEBB5423.AutoSize = true;
		this.CEBB5423.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CEBB5423.Location = new System.Drawing.Point(10, 48);
		this.CEBB5423.Name = "ckbShareBaiLenNhom";
		this.CEBB5423.Size = new System.Drawing.Size(138, 20);
		this.CEBB5423.TabIndex = 0;
		this.CEBB5423.Text = "Share bài lên nhóm";
		this.CEBB5423.UseVisualStyleBackColor = true;
		this.CEBB5423.CheckedChanged += new System.EventHandler(CEBB5423_CheckedChanged);
		this.ckbShareBaiLenTuong.AutoSize = true;
		this.ckbShareBaiLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareBaiLenTuong.Location = new System.Drawing.Point(10, 22);
		this.ckbShareBaiLenTuong.Name = "ckbShareBaiLenTuong";
		this.ckbShareBaiLenTuong.Size = new System.Drawing.Size(139, 20);
		this.ckbShareBaiLenTuong.TabIndex = 0;
		this.ckbShareBaiLenTuong.Text = "Share bài lên tường";
		this.ckbShareBaiLenTuong.UseVisualStyleBackColor = true;
		this.C982D331.Location = new System.Drawing.Point(250, 78);
		this.C982D331.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C982D331.Name = "nudDelayTo";
		this.C982D331.Size = new System.Drawing.Size(56, 23);
		this.C982D331.TabIndex = 58;
		this.E836869B.Location = new System.Drawing.Point(164, 78);
		this.E836869B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E836869B.Name = "nudDelayFrom";
		this.E836869B.Size = new System.Drawing.Size(56, 23);
		this.E836869B.TabIndex = 57;
		this.label20.AutoSize = true;
		this.label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.Location = new System.Drawing.Point(226, 80);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(18, 16);
		this.label20.TabIndex = 61;
		this.label20.Text = ">";
		this.BC8CD4B9.AutoSize = true;
		this.BC8CD4B9.Location = new System.Drawing.Point(18, 80);
		this.BC8CD4B9.Name = "label15";
		this.BC8CD4B9.Size = new System.Drawing.Size(140, 16);
		this.BC8CD4B9.TabIndex = 59;
		this.BC8CD4B9.Text = "Khoảng cách share (s):";
		this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVanBan.Controls.Add(this.ckbTuDongXoaNoiDung);
		this.plVanBan.Controls.Add(this.E1ACEB85);
		this.plVanBan.Controls.Add(this.btnHuongDanNhapNoiDung);
		this.plVanBan.Controls.Add(this.B105539A);
		this.plVanBan.Controls.Add(this.txtNoiDung);
		this.plVanBan.Controls.Add(this.label4);
		this.plVanBan.Controls.Add(this.label8);
		this.plVanBan.Controls.Add(this.lblNoiDung);
		this.plVanBan.Location = new System.Drawing.Point(40, 275);
		this.plVanBan.Name = "plVanBan";
		this.plVanBan.Size = new System.Drawing.Size(312, 246);
		this.plVanBan.TabIndex = 33;
		this.ckbTuDongXoaNoiDung.AutoSize = true;
		this.ckbTuDongXoaNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongXoaNoiDung.Location = new System.Drawing.Point(7, 222);
		this.ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		this.ckbTuDongXoaNoiDung.Size = new System.Drawing.Size(219, 20);
		this.ckbTuDongXoaNoiDung.TabIndex = 197;
		this.ckbTuDongXoaNoiDung.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 sư\u0309 du\u0323ng";
		this.ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		this.E1ACEB85.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E1ACEB85.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.E1ACEB85.FormattingEnabled = true;
		this.E1ACEB85.Location = new System.Drawing.Point(81, 194);
		this.E1ACEB85.Name = "cbbTuyChonNoiDung";
		this.E1ACEB85.Size = new System.Drawing.Size(190, 24);
		this.E1ACEB85.TabIndex = 184;
		this.E1ACEB85.SelectedIndexChanged += new System.EventHandler(F7AC4A80);
		this.btnHuongDanNhapNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHuongDanNhapNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnHuongDanNhapNoiDung.Location = new System.Drawing.Point(277, 193);
		this.btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		this.btnHuongDanNhapNoiDung.Size = new System.Drawing.Size(26, 26);
		this.btnHuongDanNhapNoiDung.TabIndex = 182;
		this.btnHuongDanNhapNoiDung.Text = "?";
		this.btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		this.btnHuongDanNhapNoiDung.Click += new System.EventHandler(B5A3D826);
		this.B105539A.AutoSize = true;
		this.B105539A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B105539A.Location = new System.Drawing.Point(222, 170);
		this.B105539A.Name = "linkLabel1";
		this.B105539A.Size = new System.Drawing.Size(81, 16);
		this.B105539A.TabIndex = 183;
		this.B105539A.TabStop = true;
		this.B105539A.Text = "Random icon";
		this.B105539A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B105539A_LinkClicked);
		this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(297, 143);
		this.txtNoiDung.TabIndex = 180;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(4, 170);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(143, 16);
		this.label4.TabIndex = 178;
		this.label4.Text = "(Spin nội dung {a|b|c})";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 197);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(64, 16);
		this.label8.TabIndex = 181;
		this.label8.Text = "Tùy chọn:";
		this.lblNoiDung.AutoSize = true;
		this.lblNoiDung.Location = new System.Drawing.Point(3, 4);
		this.lblNoiDung.Name = "lblNoiDung";
		this.lblNoiDung.Size = new System.Drawing.Size(83, 16);
		this.lblNoiDung.TabIndex = 179;
		this.lblNoiDung.Text = "Nội dung (0):";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(282, 562);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.C318CA9C.AutoSize = true;
		this.C318CA9C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C318CA9C.Location = new System.Drawing.Point(21, 249);
		this.C318CA9C.Name = "ckbVanBan";
		this.C318CA9C.Size = new System.Drawing.Size(76, 20);
		this.C318CA9C.TabIndex = 32;
		this.C318CA9C.Text = "Nội dung";
		this.C318CA9C.UseVisualStyleBackColor = true;
		this.C318CA9C.CheckedChanged += new System.EventHandler(C318CA9C_CheckedChanged);
		this.C81A2D8E.Location = new System.Drawing.Point(164, 49);
		this.C81A2D8E.Name = "txtTenHanhDong";
		this.C81A2D8E.Size = new System.Drawing.Size(188, 23);
		this.C81A2D8E.TabIndex = 0;
		this.EB89B5A9.AutoSize = true;
		this.EB89B5A9.Location = new System.Drawing.Point(18, 52);
		this.EB89B5A9.Name = "label1";
		this.EB89B5A9.Size = new System.Drawing.Size(98, 16);
		this.EB89B5A9.TabIndex = 31;
		this.EB89B5A9.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(392, 562);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.E83DFF9C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E83DFF9C.BackColor = System.Drawing.Color.White;
		this.E83DFF9C.BorderRadius = 0;
		this.E83DFF9C.BottomSahddow = true;
		this.E83DFF9C.color = System.Drawing.Color.DarkViolet;
		this.E83DFF9C.Controls.Add(this.pnlHeader);
		this.E83DFF9C.LeftSahddow = false;
		this.E83DFF9C.Location = new System.Drawing.Point(1, 0);
		this.E83DFF9C.Name = "bunifuCards1";
		this.E83DFF9C.RightSahddow = true;
		this.E83DFF9C.ShadowDepth = 20;
		this.E83DFF9C.Size = new System.Drawing.Size(755, 37);
		this.E83DFF9C.TabIndex = 28;
		this.toolTip_0.AutomaticDelay = 100;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(758, 604);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDShareBai";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BA81EE26);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plDangBaiLenPage.ResumeLayout(false);
		this.plDangBaiLenPage.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DAB9AC98).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A1B8A7BD).EndInit();
		this.plDangBaiLenNhom.ResumeLayout(false);
		this.plDangBaiLenNhom.PerformLayout();
		this.F936D597.ResumeLayout(false);
		this.F936D597.PerformLayout();
		this.D228E034.ResumeLayout(false);
		this.D228E034.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C70A4222).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C982D331).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E836869B).EndInit();
		this.plVanBan.ResumeLayout(false);
		this.plVanBan.PerformLayout();
		this.E83DFF9C.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
