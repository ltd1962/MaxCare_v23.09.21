using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Bunifu.Framework.UI;

public class fHDDangReel : Form
{
	private ucTuongTacReel ucTuongTacReel_0;

	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool F52E31AA;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel C4B9B307;

	private TextBox A3B0C3B4;

	private Label label1;

	private Button btnCancel;

	private Button B3A6F09E;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button C6901F09;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbVanBan;

	private Panel E2B62D89;

	private Label F400F188;

	private Label lblNoiDung;

	private RichTextBox txtNoiDung;

	private Label DD3548AD;

	private NumericUpDown BA1E638C;

	private NumericUpDown C735CDA2;

	private Label E7B5D796;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label16;

	private Label label15;

	private CheckBox ckbXoaNguyenLieuDaDung;

	private LinkLabel A7188FB8;

	private TextBox txtPathAnh;

	private Label label3;

	private NumericUpDown nudTimeOutLoadVideo;

	private Label DE2DC3A9;

	private Label F5325B0F;

	private CheckBox CF298C9E;

	private Panel plHashtag;

	private RichTextBox AB01CB3A;

	private Label lblHashtag;

	private Label DEB6FEBB;

	private NumericUpDown nudSoHashtagFrom;

	private NumericUpDown nudSoHashtagTo;

	private Label E1910988;

	private CheckBox ckbXoaVideoDaDang;

	private LinkLabel B5A0A2B4;

	private CheckBox ckbTuongTacReel;

	private TextBox DAA09109;

	private CheckBox AF9A042F;

	private TextBox txtThuMucMedia;

	private CheckBox B6AFFB2B;

	private Button button2;

	private Label label9;

	private ComboBox CF2BD586;

	public fHDDangReel(string string_3, int int_1 = 0, string DB1D11BE = "")
	{
		A4058322();
		F52E31AA = false;
		string_0 = string_3;
		string_2 = DB1D11BE;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng Reel";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A3B0C3B4.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(DB1D11BE);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			B3A6F09E.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A3B0C3B4.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		ucTuongTacReel_0 = new ucTuongTacReel(gclass8_0)
		{
			Visible = false
		};
		base.Controls.Add(ucTuongTacReel_0);
		ucTuongTacReel_0.AF142CA5(bool_0: true);
		Language.SetLanguage(this);
	}

	private void DE90DFB1_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			C735CDA2.Value = gclass8_0.GetValueInt("nudKhoangCachFrom", 5);
			BA1E638C.Value = gclass8_0.GetValueInt("nudKhoangCachTo", 10);
			ckbVanBan.Checked = gclass8_0.GetValueBool("ckbVanBan");
			ckbXoaNguyenLieuDaDung.Checked = gclass8_0.GetValueBool("ckbXoaNguyenLieuDaDung");
			txtNoiDung.Text = gclass8_0.GetValue("txtNoiDung");
			CF2BD586.SelectedIndex = gclass8_0.GetValueInt("typeNganCach");
			CF298C9E.Checked = gclass8_0.GetValueBool("ckbHashtag");
			AB01CB3A.Text = gclass8_0.GetValue("txtHashtag");
			nudSoHashtagFrom.Value = gclass8_0.GetValueInt("nudSoHashtagFrom", 1);
			nudSoHashtagTo.Value = gclass8_0.GetValueInt("nudSoHashtagTo", 1);
			txtPathAnh.Text = gclass8_0.GetValue("txtPathAnh");
			ckbXoaVideoDaDang.Checked = gclass8_0.GetValueBool("ckbXoaVideoDaDang");
			nudTimeOutLoadVideo.Value = gclass8_0.GetValueInt("nudTimeOutLoadVideo", 300);
			ckbTuongTacReel.Checked = gclass8_0.GetValueBool("ckbTuongTacReel");
			AF9A042F.Checked = gclass8_0.GetValueBool("ckbKhoNoiDung");
			DAA09109.Text = gclass8_0.GetValue("txtKhoNoiDung");
			B6AFFB2B.Checked = gclass8_0.GetValueBool("ckbThuMucMedia");
			txtThuMucMedia.Text = gclass8_0.GetValue("txtThuMucMedia");
		}
		catch (Exception)
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(CF2BD586, e6A5AC);
	}

	private void C6901F09_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B3A6F09E_Click(object sender, EventArgs e)
	{
		string text = A3B0C3B4.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		gclass8_0.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gclass8_0.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gclass8_0.GetJson("nudKhoangCachFrom", C735CDA2.Value);
		gclass8_0.GetJson("nudKhoangCachTo", BA1E638C.Value);
		gclass8_0.GetJson("ckbVanBan", ckbVanBan.Checked);
		gclass8_0.GetJson("ckbXoaNguyenLieuDaDung", ckbXoaNguyenLieuDaDung.Checked);
		gclass8_0.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		gclass8_0.GetJson("typeNganCach", CF2BD586.SelectedIndex);
		gclass8_0.GetJson("ckbHashtag", CF298C9E.Checked);
		gclass8_0.GetJson("txtHashtag", AB01CB3A.Text.Trim());
		gclass8_0.GetJson("nudSoHashtagFrom", nudSoHashtagFrom.Value);
		gclass8_0.GetJson("nudSoHashtagTo", nudSoHashtagTo.Value);
		gclass8_0.GetJson("txtPathAnh", txtPathAnh.Text.Trim());
		gclass8_0.GetJson("ckbXoaVideoDaDang", ckbXoaVideoDaDang.Checked);
		gclass8_0.GetJson("nudTimeOutLoadVideo", nudTimeOutLoadVideo.Value);
		gclass8_0.GetJson("ckbTuongTacReel", ckbTuongTacReel.Checked);
		gclass8_0.GetJson("ckbThuMucMedia", B6AFFB2B.Checked);
		gclass8_0.GetJson("txtThuMucMedia", txtThuMucMedia.Text);
		gclass8_0.GetJson("ckbKhoNoiDung", AF9A042F.Checked);
		gclass8_0.GetJson("txtKhoNoiDung", DAA09109.Text);
		string string_ = gclass8_0.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					F52E31AA = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_2, text, string_))
			{
				F52E31AA = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C4B9B307_Paint(object sender, PaintEventArgs e)
	{
		if (C4B9B307.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C4B9B307.ClientSize.Width - num, C4B9B307.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		ckbVanBan_CheckedChanged(null, null);
		method_2(null, null);
		CF298C9E_CheckedChanged(null, null);
		FC924C35(null, null);
		FC11D692(null, null);
		AAB50713(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		E2B62D89.Enabled = ckbVanBan.Checked;
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtNoiDung, lblNoiDung, CF2BD586.SelectedIndex);
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void A7188FB8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (CF2BD586.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtNoiDung.Focus();
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void AB01CB3A_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(AB01CB3A, lblHashtag);
	}

	private void CF298C9E_CheckedChanged(object sender, EventArgs e)
	{
		plHashtag.Enabled = CF298C9E.Checked;
	}

	private void DE819882(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_18(ucTuongTacReel_0, this);
	}

	private void FC924C35(object sender, EventArgs e)
	{
		B5A0A2B4.Enabled = ckbTuongTacReel.Checked;
	}

	private void FC11D692(object sender, EventArgs e)
	{
		DAA09109.Enabled = AF9A042F.Checked;
	}

	private void AAB50713(object sender, EventArgs e)
	{
		txtThuMucMedia.Enabled = B6AFFB2B.Checked;
	}

	private void CF2BD586_SelectedIndexChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtNoiDung, lblNoiDung, CF2BD586.SelectedIndex);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A4058322()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDangReel));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		C6901F09 = new Button();
		pictureBox1 = new PictureBox();
		C4B9B307 = new Panel();
		txtThuMucMedia = new TextBox();
		DAA09109 = new TextBox();
		txtPathAnh = new TextBox();
		DD3548AD = new Label();
		BA1E638C = new NumericUpDown();
		label3 = new Label();
		C735CDA2 = new NumericUpDown();
		ckbXoaVideoDaDang = new CheckBox();
		E7B5D796 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudTimeOutLoadVideo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		DE2DC3A9 = new Label();
		F5325B0F = new Label();
		label16 = new Label();
		label15 = new Label();
		E2B62D89 = new Panel();
		CF2BD586 = new ComboBox();
		A7188FB8 = new LinkLabel();
		button2 = new Button();
		label9 = new Label();
		txtNoiDung = new RichTextBox();
		F400F188 = new Label();
		lblNoiDung = new Label();
		ckbXoaNguyenLieuDaDung = new CheckBox();
		CF298C9E = new CheckBox();
		plHashtag = new Panel();
		nudSoHashtagFrom = new NumericUpDown();
		nudSoHashtagTo = new NumericUpDown();
		E1910988 = new Label();
		AB01CB3A = new RichTextBox();
		lblHashtag = new Label();
		DEB6FEBB = new Label();
		B6AFFB2B = new CheckBox();
		B3A6F09E = new Button();
		AF9A042F = new CheckBox();
		ckbVanBan = new CheckBox();
		A3B0C3B4 = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		bunifuCards1 = new BunifuCards();
		B5A0A2B4 = new LinkLabel();
		ckbTuongTacReel = new CheckBox();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		C4B9B307.SuspendLayout();
		((ISupportInitialize)BA1E638C).BeginInit();
		((ISupportInitialize)C735CDA2).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudTimeOutLoadVideo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		E2B62D89.SuspendLayout();
		plHashtag.SuspendLayout();
		((ISupportInitialize)nudSoHashtagFrom).BeginInit();
		((ISupportInitialize)nudSoHashtagTo).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(593, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng Reel";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(C6901F09);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(593, 31);
		pnlHeader.TabIndex = 9;
		C6901F09.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C6901F09.Cursor = Cursors.Hand;
		C6901F09.FlatAppearance.BorderSize = 0;
		C6901F09.FlatStyle = FlatStyle.Flat;
		C6901F09.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C6901F09.ForeColor = Color.White;
		C6901F09.Image = (Image)componentResourceManager.GetObject("button1.Image");
		C6901F09.Location = new Point(562, 1);
		C6901F09.Name = "button1";
		C6901F09.Size = new Size(30, 30);
		C6901F09.TabIndex = 0;
		C6901F09.TextImageRelation = TextImageRelation.ImageBeforeText;
		C6901F09.UseVisualStyleBackColor = true;
		C6901F09.Click += C6901F09_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		C4B9B307.BackColor = Color.White;
		C4B9B307.BorderStyle = BorderStyle.FixedSingle;
		C4B9B307.Controls.Add(txtThuMucMedia);
		C4B9B307.Controls.Add(DAA09109);
		C4B9B307.Controls.Add(txtPathAnh);
		C4B9B307.Controls.Add(DD3548AD);
		C4B9B307.Controls.Add(BA1E638C);
		C4B9B307.Controls.Add(label3);
		C4B9B307.Controls.Add(C735CDA2);
		C4B9B307.Controls.Add(ckbXoaVideoDaDang);
		C4B9B307.Controls.Add(E7B5D796);
		C4B9B307.Controls.Add(nudSoLuongTo);
		C4B9B307.Controls.Add(nudTimeOutLoadVideo);
		C4B9B307.Controls.Add(nudSoLuongFrom);
		C4B9B307.Controls.Add(DE2DC3A9);
		C4B9B307.Controls.Add(F5325B0F);
		C4B9B307.Controls.Add(label16);
		C4B9B307.Controls.Add(label15);
		C4B9B307.Controls.Add(E2B62D89);
		C4B9B307.Controls.Add(B6AFFB2B);
		C4B9B307.Controls.Add(B3A6F09E);
		C4B9B307.Controls.Add(AF9A042F);
		C4B9B307.Controls.Add(ckbVanBan);
		C4B9B307.Controls.Add(A3B0C3B4);
		C4B9B307.Controls.Add(label1);
		C4B9B307.Controls.Add(btnCancel);
		C4B9B307.Controls.Add(bunifuCards1);
		C4B9B307.Controls.Add(B5A0A2B4);
		C4B9B307.Controls.Add(ckbTuongTacReel);
		C4B9B307.Cursor = Cursors.Arrow;
		C4B9B307.Dock = DockStyle.Fill;
		C4B9B307.Location = new Point(0, 0);
		C4B9B307.Name = "panel1";
		C4B9B307.Size = new Size(596, 701);
		C4B9B307.TabIndex = 0;
		C4B9B307.Paint += C4B9B307_Paint;
		txtThuMucMedia.Location = new Point(168, 772);
		txtThuMucMedia.Name = "txtThuMucMedia";
		txtThuMucMedia.Size = new Size(393, 23);
		txtThuMucMedia.TabIndex = 1;
		DAA09109.Location = new Point(168, 801);
		DAA09109.Name = "txtKhoNoiDung";
		DAA09109.Size = new Size(393, 23);
		DAA09109.TabIndex = 1;
		txtPathAnh.Location = new Point(168, 136);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new Size(260, 23);
		txtPathAnh.TabIndex = 1;
		DD3548AD.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DD3548AD.Location = new Point(222, 109);
		DD3548AD.Name = "label20";
		DD3548AD.Size = new Size(29, 16);
		DD3548AD.TabIndex = 42;
		DD3548AD.Text = ">";
		DD3548AD.TextAlign = ContentAlignment.MiddleCenter;
		BA1E638C.Location = new Point(253, 107);
		BA1E638C.Name = "nudKhoangCachTo";
		BA1E638C.Size = new Size(51, 23);
		BA1E638C.TabIndex = 41;
		label3.AutoSize = true;
		label3.Location = new Point(30, 139);
		label3.Name = "label3";
		label3.Size = new Size(97, 16);
		label3.TabIndex = 0;
		label3.Text = "Thư mu\u0323c video:";
		C735CDA2.Location = new Point(168, 107);
		C735CDA2.Name = "nudKhoangCachFrom";
		C735CDA2.Size = new Size(51, 23);
		C735CDA2.TabIndex = 40;
		ckbXoaVideoDaDang.AutoSize = true;
		ckbXoaVideoDaDang.Cursor = Cursors.Hand;
		ckbXoaVideoDaDang.Location = new Point(436, 138);
		ckbXoaVideoDaDang.Name = "ckbXoaVideoDaDang";
		ckbXoaVideoDaDang.Size = new Size(132, 20);
		ckbXoaVideoDaDang.TabIndex = 32;
		ckbXoaVideoDaDang.Text = "Xóa video đã đăng";
		ckbXoaVideoDaDang.UseVisualStyleBackColor = true;
		ckbXoaVideoDaDang.CheckedChanged += ckbVanBan_CheckedChanged;
		E7B5D796.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E7B5D796.Location = new Point(222, 83);
		E7B5D796.Name = "label17";
		E7B5D796.Size = new Size(29, 16);
		E7B5D796.TabIndex = 38;
		E7B5D796.Text = ">";
		E7B5D796.TextAlign = ContentAlignment.MiddleCenter;
		nudSoLuongTo.Location = new Point(253, 78);
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(51, 23);
		nudSoLuongTo.TabIndex = 37;
		nudTimeOutLoadVideo.Location = new Point(168, 625);
		nudTimeOutLoadVideo.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		nudTimeOutLoadVideo.Name = "nudTimeOutLoadVideo";
		nudTimeOutLoadVideo.Size = new Size(51, 23);
		nudTimeOutLoadVideo.TabIndex = 36;
		nudSoLuongFrom.Location = new Point(168, 78);
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(51, 23);
		nudSoLuongFrom.TabIndex = 36;
		DE2DC3A9.AutoSize = true;
		DE2DC3A9.Location = new Point(225, 627);
		DE2DC3A9.Name = "label5";
		DE2DC3A9.Size = new Size(30, 16);
		DE2DC3A9.TabIndex = 34;
		DE2DC3A9.Text = "giây";
		F5325B0F.AutoSize = true;
		F5325B0F.Location = new Point(30, 627);
		F5325B0F.Name = "label4";
		F5325B0F.Size = new Size(132, 16);
		F5325B0F.TabIndex = 34;
		F5325B0F.Text = "Chờ load video tối đa:";
		label16.AutoSize = true;
		label16.Location = new Point(30, 109);
		label16.Name = "label16";
		label16.Size = new Size(136, 16);
		label16.TabIndex = 35;
		label16.Text = "Khoảng cách đăng (s):";
		label15.AutoSize = true;
		label15.Location = new Point(30, 80);
		label15.Name = "label15";
		label15.Size = new Size(89, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng reel:";
		E2B62D89.BorderStyle = BorderStyle.FixedSingle;
		E2B62D89.Controls.Add(CF2BD586);
		E2B62D89.Controls.Add(A7188FB8);
		E2B62D89.Controls.Add(button2);
		E2B62D89.Controls.Add(label9);
		E2B62D89.Controls.Add(txtNoiDung);
		E2B62D89.Controls.Add(F400F188);
		E2B62D89.Controls.Add(lblNoiDung);
		E2B62D89.Controls.Add(ckbXoaNguyenLieuDaDung);
		E2B62D89.Controls.Add(CF298C9E);
		E2B62D89.Controls.Add(plHashtag);
		E2B62D89.Location = new Point(47, 186);
		E2B62D89.Name = "plVanBan";
		E2B62D89.Size = new Size(514, 434);
		E2B62D89.TabIndex = 33;
		CF2BD586.Cursor = Cursors.Hand;
		CF2BD586.DropDownStyle = ComboBoxStyle.DropDownList;
		CF2BD586.DropDownWidth = 180;
		CF2BD586.FormattingEnabled = true;
		CF2BD586.Location = new Point(325, 197);
		CF2BD586.Name = "cbbTuyChonNoiDung";
		CF2BD586.Size = new Size(154, 24);
		CF2BD586.TabIndex = 196;
		CF2BD586.SelectedIndexChanged += CF2BD586_SelectedIndexChanged;
		A7188FB8.AutoSize = true;
		A7188FB8.Cursor = Cursors.Hand;
		A7188FB8.Location = new Point(154, 197);
		A7188FB8.Name = "linkLabel1";
		A7188FB8.Size = new Size(81, 16);
		A7188FB8.TabIndex = 195;
		A7188FB8.TabStop = true;
		A7188FB8.Text = "Random icon";
		A7188FB8.LinkClicked += A7188FB8_LinkClicked;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(485, 197);
		button2.Name = "button2";
		button2.Size = new Size(21, 24);
		button2.TabIndex = 194;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		label9.AutoSize = true;
		label9.Location = new Point(261, 200);
		label9.Name = "label9";
		label9.Size = new Size(64, 16);
		label9.TabIndex = 35;
		label9.Text = "Tùy chọn:";
		txtNoiDung.Location = new Point(7, 23);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new Size(499, 172);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += txtNoiDung_TextChanged;
		F400F188.AutoSize = true;
		F400F188.Location = new Point(4, 197);
		F400F188.Name = "label8";
		F400F188.Size = new Size(143, 16);
		F400F188.TabIndex = 0;
		F400F188.Text = "(Spin nội dung {a|b|c})";
		lblNoiDung.AutoSize = true;
		lblNoiDung.Location = new Point(3, 4);
		lblNoiDung.Name = "lblNoiDung";
		lblNoiDung.Size = new Size(145, 16);
		lblNoiDung.TabIndex = 0;
		lblNoiDung.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		ckbXoaNguyenLieuDaDung.AutoSize = true;
		ckbXoaNguyenLieuDaDung.Cursor = Cursors.Hand;
		ckbXoaNguyenLieuDaDung.Location = new Point(7, 220);
		ckbXoaNguyenLieuDaDung.Name = "ckbXoaNguyenLieuDaDung";
		ckbXoaNguyenLieuDaDung.Size = new Size(151, 20);
		ckbXoaNguyenLieuDaDung.TabIndex = 32;
		ckbXoaNguyenLieuDaDung.Text = "Xóa nội dung đã đăng";
		ckbXoaNguyenLieuDaDung.UseVisualStyleBackColor = true;
		ckbXoaNguyenLieuDaDung.CheckedChanged += ckbVanBan_CheckedChanged;
		CF298C9E.AutoSize = true;
		CF298C9E.Cursor = Cursors.Hand;
		CF298C9E.Location = new Point(7, 246);
		CF298C9E.Name = "ckbHashtag";
		CF298C9E.Size = new Size(101, 20);
		CF298C9E.TabIndex = 32;
		CF298C9E.Text = "Kèm Hashtag";
		CF298C9E.UseVisualStyleBackColor = true;
		CF298C9E.CheckedChanged += CF298C9E_CheckedChanged;
		plHashtag.BorderStyle = BorderStyle.FixedSingle;
		plHashtag.Controls.Add(nudSoHashtagFrom);
		plHashtag.Controls.Add(nudSoHashtagTo);
		plHashtag.Controls.Add(E1910988);
		plHashtag.Controls.Add(AB01CB3A);
		plHashtag.Controls.Add(lblHashtag);
		plHashtag.Controls.Add(DEB6FEBB);
		plHashtag.Location = new Point(19, 271);
		plHashtag.Name = "plHashtag";
		plHashtag.Size = new Size(487, 156);
		plHashtag.TabIndex = 33;
		nudSoHashtagFrom.Location = new Point(170, 127);
		nudSoHashtagFrom.Name = "nudSoHashtagFrom";
		nudSoHashtagFrom.Size = new Size(51, 23);
		nudSoHashtagFrom.TabIndex = 40;
		nudSoHashtagTo.Location = new Point(255, 127);
		nudSoHashtagTo.Name = "nudSoHashtagTo";
		nudSoHashtagTo.Size = new Size(51, 23);
		nudSoHashtagTo.TabIndex = 41;
		E1910988.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E1910988.Location = new Point(224, 129);
		E1910988.Name = "label7";
		E1910988.Size = new Size(29, 16);
		E1910988.TabIndex = 42;
		E1910988.Text = ">";
		E1910988.TextAlign = ContentAlignment.MiddleCenter;
		AB01CB3A.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		AB01CB3A.Location = new Point(7, 22);
		AB01CB3A.Name = "txtHashtag";
		AB01CB3A.Size = new Size(472, 102);
		AB01CB3A.TabIndex = 34;
		AB01CB3A.Text = "";
		AB01CB3A.WordWrap = false;
		AB01CB3A.TextChanged += AB01CB3A_TextChanged;
		lblHashtag.AutoSize = true;
		lblHashtag.Location = new Point(3, 3);
		lblHashtag.Name = "lblHashtag";
		lblHashtag.Size = new Size(141, 16);
		lblHashtag.TabIndex = 0;
		lblHashtag.Text = "Danh sa\u0301ch hashtag (0):";
		DEB6FEBB.AutoSize = true;
		DEB6FEBB.Location = new Point(4, 129);
		DEB6FEBB.Name = "label6";
		DEB6FEBB.Size = new Size(166, 16);
		DEB6FEBB.TabIndex = 35;
		DEB6FEBB.Text = "Số lượng hashtag/nội dung:";
		B6AFFB2B.AutoSize = true;
		B6AFFB2B.Cursor = Cursors.Hand;
		B6AFFB2B.Location = new Point(33, 774);
		B6AFFB2B.Name = "ckbThuMucMedia";
		B6AFFB2B.Size = new Size(121, 20);
		B6AFFB2B.TabIndex = 32;
		B6AFFB2B.Text = "Thư mục media:";
		B6AFFB2B.UseVisualStyleBackColor = true;
		B6AFFB2B.CheckedChanged += AAB50713;
		B3A6F09E.Anchor = AnchorStyles.Bottom;
		B3A6F09E.BackColor = Color.FromArgb(53, 120, 229);
		B3A6F09E.Cursor = Cursors.Hand;
		B3A6F09E.FlatAppearance.BorderSize = 0;
		B3A6F09E.FlatStyle = FlatStyle.Flat;
		B3A6F09E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B3A6F09E.ForeColor = Color.White;
		B3A6F09E.Location = new Point(205, 659);
		B3A6F09E.Name = "btnAdd";
		B3A6F09E.Size = new Size(92, 29);
		B3A6F09E.TabIndex = 3;
		B3A6F09E.Text = "Thêm";
		B3A6F09E.UseVisualStyleBackColor = false;
		B3A6F09E.Click += B3A6F09E_Click;
		AF9A042F.AutoSize = true;
		AF9A042F.Cursor = Cursors.Hand;
		AF9A042F.Location = new Point(33, 803);
		AF9A042F.Name = "ckbKhoNoiDung";
		AF9A042F.Size = new Size(140, 20);
		AF9A042F.TabIndex = 32;
		AF9A042F.Text = "Kho video/nội dung:";
		AF9A042F.UseVisualStyleBackColor = true;
		AF9A042F.CheckedChanged += FC11D692;
		ckbVanBan.AutoSize = true;
		ckbVanBan.Cursor = Cursors.Hand;
		ckbVanBan.Location = new Point(33, 162);
		ckbVanBan.Name = "ckbVanBan";
		ckbVanBan.Size = new Size(113, 20);
		ckbVanBan.TabIndex = 32;
		ckbVanBan.Text = "Nội dung mô tả";
		ckbVanBan.UseVisualStyleBackColor = true;
		ckbVanBan.CheckedChanged += ckbVanBan_CheckedChanged;
		A3B0C3B4.Location = new Point(168, 49);
		A3B0C3B4.Name = "txtTenHanhDong";
		A3B0C3B4.Size = new Size(174, 23);
		A3B0C3B4.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(30, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(304, 659);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(593, 37);
		bunifuCards1.TabIndex = 28;
		B5A0A2B4.AutoSize = true;
		B5A0A2B4.Cursor = Cursors.Hand;
		B5A0A2B4.Location = new Point(518, 189);
		B5A0A2B4.Name = "lblCaiDatTuongTacReel";
		B5A0A2B4.Size = new Size(47, 16);
		B5A0A2B4.TabIndex = 184;
		B5A0A2B4.TabStop = true;
		B5A0A2B4.Text = "Cài đặt";
		B5A0A2B4.LinkClicked += DE819882;
		ckbTuongTacReel.AutoSize = true;
		ckbTuongTacReel.Cursor = Cursors.Hand;
		ckbTuongTacReel.Location = new Point(334, 189);
		ckbTuongTacReel.Name = "ckbTuongTacReel";
		ckbTuongTacReel.Size = new Size(186, 20);
		ckbTuongTacReel.TabIndex = 32;
		ckbTuongTacReel.Text = "Tương tác reel sau khi đăng";
		ckbTuongTacReel.UseVisualStyleBackColor = true;
		ckbTuongTacReel.CheckedChanged += FC924C35;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(596, 701);
		base.Controls.Add(C4B9B307);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDangReel";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += DE90DFB1_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		C4B9B307.ResumeLayout(performLayout: false);
		C4B9B307.PerformLayout();
		((ISupportInitialize)BA1E638C).EndInit();
		((ISupportInitialize)C735CDA2).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudTimeOutLoadVideo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		E2B62D89.ResumeLayout(performLayout: false);
		E2B62D89.PerformLayout();
		plHashtag.ResumeLayout(performLayout: false);
		plHashtag.PerformLayout();
		((ISupportInitialize)nudSoHashtagFrom).EndInit();
		((ISupportInitialize)nudSoHashtagTo).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
