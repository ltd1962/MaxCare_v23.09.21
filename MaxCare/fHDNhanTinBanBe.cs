using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDNhanTinBanBe : Form
{
	private JSON_Settings CD234C00;

	private string string_0;

	private string D20D9681;

	private string B489451F;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown CFBEEA96;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button BA3C5499;

	private Button C29D19B9;

	private BunifuCards B2A3072E;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel F6857FA9;

	private Label label8;

	private Label lblStatusTinNhan;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F428B5AA;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label BC1D0E19;

	private Panel CE22E491;

	private Label lblStatusUid;

	private LinkLabel linkLabel1;

	private Panel F8291103;

	private Button button3;

	private Button A285B803;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label11;

	private Button BE37F184;

	private Button CA05FD36;

	private RichTextBox F6A45B22;

	private RichTextBox txtUidChiDinh;

	private ComboBox AC19BFBF;

	private Label label10;

	private ComboBox cbbDoiTuongNhanTin;

	public fHDNhanTinBanBe(string EFB55091, int int_1 = 0, string string_1 = "")
	{
		F4B93326();
		bool_0 = false;
		string_0 = EFB55091;
		B489451F = string_1;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDNhanTinBanBe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			D20D9681 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_1);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			C29D19B9.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CD234C00 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDNhanTinBanBe_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = CD234C00.GetValueInt("nudSoLuongFrom");
			CFBEEA96.Value = CD234C00.GetValueInt("nudSoLuongTo");
			F428B5AA.Value = CD234C00.GetValueInt("nudDelayFrom");
			nudDelayTo.Value = CD234C00.GetValueInt("nudDelayTo");
			F6A45B22.Text = CD234C00.GetValue("txtTinNhan");
			if (CD234C00.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			cbbDoiTuongNhanTin.SelectedValue = CD234C00.GetValue("typeDoiTuong");
			txtUidChiDinh.Text = CD234C00.GetValue("txtUidChiDinh");
			AC19BFBF.SelectedIndex = CD234C00.GetValueInt("cbbFacebookWeb");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Ngẫu nhiên danh sách bạn");
		dictionary.Add("1", "UID chỉ định");
		dictionary.Add("2", "Đang trực tuyến");
		dictionary.Add("3", "Tin nhắn Spam");
		dictionary.Add("4", "Tin nhắn Chờ");
		Common.F5A0B829(cbbDoiTuongNhanTin, dictionary);
	}

	private void F7AB5318(object sender, EventArgs e)
	{
		Close();
	}

	private void C29D19B9_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = F6A45B22.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n!", 3);
			return;
		}
		CD234C00.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		CD234C00.GetJson("nudSoLuongTo", CFBEEA96.Value);
		CD234C00.GetJson("nudDelayFrom", F428B5AA.Value);
		CD234C00.GetJson("nudDelayTo", nudDelayTo.Value);
		CD234C00.GetJson("txtTinNhan", F6A45B22.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		CD234C00.GetJson("typeNganCach", num);
		CD234C00.GetJson("typeDoiTuong", cbbDoiTuongNhanTin.SelectedValue);
		CD234C00.GetJson("txtUidChiDinh", txtUidChiDinh.Text.Trim());
		CD234C00.GetJson("cbbFacebookWeb", AC19BFBF.SelectedIndex);
		string text2 = CD234C00.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, D20D9681, text2))
				{
					bool_0 = true;
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
			if (InteractSQL.smethod_13(B489451F, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void BA3C5499_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!");
	}

	private void D01404B7(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void BE37F184_Click(object sender, EventArgs e)
	{
		F8291103.Height = 336;
	}

	private void CA05FD36_Click(object sender, EventArgs e)
	{
		F8291103.Height = 288;
	}

	private void D719A82C()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? F6A45B22.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : F6A45B22.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatusTinNhan.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhắn ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void EAB8172A(object sender, EventArgs e)
	{
		D719A82C();
	}

	private void BB0BCF37(object sender, EventArgs e)
	{
		D719A82C();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		F6A45B22.Focus();
	}

	private void A285B803_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		F6A45B22.Focus();
	}

	private void D291508D(object sender, EventArgs e)
	{
		Common.F9202C12(txtUidChiDinh, lblStatusUid);
	}

	private void F6A45B22_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(F6A45B22, lblStatusTinNhan);
	}

	private void cbbDoiTuongNhanTin_SelectedIndexChanged(object sender, EventArgs e)
	{
		CE22E491.Enabled = cbbDoiTuongNhanTin.SelectedValue.ToString() == "1";
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void F4B93326()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDNhanTinBanBe));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		F6857FA9 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		F8291103 = new Panel();
		F6A45B22 = new RichTextBox();
		button3 = new Button();
		A285B803 = new Button();
		rbNganCachKyTu = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		label11 = new Label();
		BE37F184 = new Button();
		CA05FD36 = new Button();
		lblStatusTinNhan = new Label();
		linkLabel1 = new LinkLabel();
		label8 = new Label();
		cbbDoiTuongNhanTin = new ComboBox();
		AC19BFBF = new ComboBox();
		CE22E491 = new Panel();
		txtUidChiDinh = new RichTextBox();
		lblStatusUid = new Label();
		BC1D0E19 = new Label();
		nudDelayTo = new NumericUpDown();
		F428B5AA = new NumericUpDown();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		CFBEEA96 = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		label4 = new Label();
		label10 = new Label();
		label2 = new Label();
		label1 = new Label();
		BA3C5499 = new Button();
		C29D19B9 = new Button();
		B2A3072E = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		F8291103.SuspendLayout();
		CE22E491.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)F428B5AA).BeginInit();
		((ISupportInitialize)CFBEEA96).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		B2A3072E.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F6857FA9;
		bunifuDragControl_0.Vertical = true;
		F6857FA9.BackColor = Color.Transparent;
		F6857FA9.Cursor = Cursors.SizeAll;
		F6857FA9.Dock = DockStyle.Fill;
		F6857FA9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F6857FA9.ForeColor = Color.Black;
		F6857FA9.Location = new Point(0, 0);
		F6857FA9.Name = "bunifuCustomLabel1";
		F6857FA9.Size = new Size(676, 31);
		F6857FA9.TabIndex = 12;
		F6857FA9.Text = "Cấu hình Nhă\u0301n tin ba\u0323n be\u0300";
		F6857FA9.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F6857FA9);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(676, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(645, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += F7AB5318;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(F8291103);
		panel1.Controls.Add(cbbDoiTuongNhanTin);
		panel1.Controls.Add(AC19BFBF);
		panel1.Controls.Add(CE22E491);
		panel1.Controls.Add(BC1D0E19);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(F428B5AA);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(CFBEEA96);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(BA3C5499);
		panel1.Controls.Add(C29D19B9);
		panel1.Controls.Add(B2A3072E);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(679, 484);
		panel1.TabIndex = 0;
		panel1.Click += panel1_Click;
		panel1.Paint += panel1_Paint;
		F8291103.BorderStyle = BorderStyle.FixedSingle;
		F8291103.Controls.Add(F6A45B22);
		F8291103.Controls.Add(button3);
		F8291103.Controls.Add(A285B803);
		F8291103.Controls.Add(rbNganCachKyTu);
		F8291103.Controls.Add(rbNganCachMoiDong);
		F8291103.Controls.Add(label11);
		F8291103.Controls.Add(BE37F184);
		F8291103.Controls.Add(CA05FD36);
		F8291103.Controls.Add(lblStatusTinNhan);
		F8291103.Controls.Add(linkLabel1);
		F8291103.Controls.Add(label8);
		F8291103.Location = new Point(30, 136);
		F8291103.Name = "panel2";
		F8291103.Size = new Size(296, 288);
		F8291103.TabIndex = 190;
		F6A45B22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F6A45B22.Location = new Point(6, 22);
		F6A45B22.Name = "txtTinNhan";
		F6A45B22.Size = new Size(286, 239);
		F6A45B22.TabIndex = 197;
		F6A45B22.Text = "";
		F6A45B22.WordWrap = false;
		F6A45B22.TextChanged += F6A45B22_TextChanged;
		button3.Cursor = Cursors.Help;
		button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(225, 310);
		button3.Name = "button3";
		button3.Size = new Size(21, 23);
		button3.TabIndex = 195;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += button3_Click;
		A285B803.Cursor = Cursors.Help;
		A285B803.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A285B803.Location = new Point(225, 287);
		A285B803.Name = "button4";
		A285B803.Size = new Size(21, 23);
		A285B803.TabIndex = 196;
		A285B803.Text = "?";
		A285B803.UseVisualStyleBackColor = true;
		A285B803.Click += A285B803_Click;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = Cursors.Hand;
		rbNganCachKyTu.Location = new Point(69, 310);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new Size(159, 20);
		rbNganCachKyTu.TabIndex = 194;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += BB0BCF37;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(69, 289);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(155, 20);
		rbNganCachMoiDong.TabIndex = 193;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += EAB8172A;
		label11.AutoSize = true;
		label11.Location = new Point(4, 289);
		label11.Name = "label11";
		label11.Size = new Size(64, 16);
		label11.TabIndex = 192;
		label11.Text = "Tùy chọn:";
		BE37F184.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		BE37F184.BackgroundImage = Resources.Bitmap_83;
		BE37F184.Cursor = Cursors.Hand;
		BE37F184.FlatAppearance.BorderColor = Color.Silver;
		BE37F184.FlatStyle = FlatStyle.Flat;
		BE37F184.Location = new Point(235, -1);
		BE37F184.Name = "btnDown";
		BE37F184.Size = new Size(25, 25);
		BE37F184.TabIndex = 190;
		BE37F184.Click += BE37F184_Click;
		CA05FD36.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CA05FD36.BackgroundImage = Resources.E536C319;
		CA05FD36.Cursor = Cursors.Hand;
		CA05FD36.FlatAppearance.BorderColor = Color.Silver;
		CA05FD36.FlatStyle = FlatStyle.Flat;
		CA05FD36.Location = new Point(266, -1);
		CA05FD36.Name = "btnUp";
		CA05FD36.Size = new Size(25, 25);
		CA05FD36.TabIndex = 191;
		CA05FD36.Click += CA05FD36_Click;
		lblStatusTinNhan.AutoSize = true;
		lblStatusTinNhan.Location = new Point(3, 3);
		lblStatusTinNhan.Name = "lblStatusTinNhan";
		lblStatusTinNhan.Size = new Size(142, 16);
		lblStatusTinNhan.TabIndex = 0;
		lblStatusTinNhan.Text = "Danh sa\u0301ch tin nhă\u0301n (0):";
		linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = Cursors.Hand;
		linkLabel1.Location = new Point(212, 265);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(81, 16);
		linkLabel1.TabIndex = 189;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += D01404B7;
		label8.AutoSize = true;
		label8.Location = new Point(2, 265);
		label8.Name = "label8";
		label8.Size = new Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		cbbDoiTuongNhanTin.Cursor = Cursors.Hand;
		cbbDoiTuongNhanTin.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDoiTuongNhanTin.DropDownWidth = 200;
		cbbDoiTuongNhanTin.FormattingEnabled = true;
		cbbDoiTuongNhanTin.Location = new Point(365, 71);
		cbbDoiTuongNhanTin.Name = "cbbDoiTuongNhanTin";
		cbbDoiTuongNhanTin.Size = new Size(281, 24);
		cbbDoiTuongNhanTin.TabIndex = 191;
		cbbDoiTuongNhanTin.SelectedIndexChanged += cbbDoiTuongNhanTin_SelectedIndexChanged;
		AC19BFBF.Cursor = Cursors.Hand;
		AC19BFBF.DropDownStyle = ComboBoxStyle.DropDownList;
		AC19BFBF.DropDownWidth = 200;
		AC19BFBF.FormattingEnabled = true;
		AC19BFBF.Items.AddRange(new object[2] { "https://m.facebook.com", "https://mbasic.facebook.com" });
		AC19BFBF.Location = new Point(68, 443);
		AC19BFBF.Name = "cbbFacebookWeb";
		AC19BFBF.Size = new Size(150, 24);
		AC19BFBF.TabIndex = 191;
		CE22E491.BorderStyle = BorderStyle.FixedSingle;
		CE22E491.Controls.Add(txtUidChiDinh);
		CE22E491.Controls.Add(lblStatusUid);
		CE22E491.Location = new Point(365, 101);
		CE22E491.Name = "plUidChiDinh";
		CE22E491.Size = new Size(281, 323);
		CE22E491.TabIndex = 49;
		txtUidChiDinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtUidChiDinh.Location = new Point(3, 22);
		txtUidChiDinh.Name = "txtUidChiDinh";
		txtUidChiDinh.Size = new Size(273, 296);
		txtUidChiDinh.TabIndex = 197;
		txtUidChiDinh.Text = "";
		txtUidChiDinh.WordWrap = false;
		txtUidChiDinh.TextChanged += D291508D;
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new Point(0, 3);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new Size(116, 16);
		lblStatusUid.TabIndex = 0;
		lblStatusUid.Text = "Danh sách UID (0):";
		BC1D0E19.AutoSize = true;
		BC1D0E19.Location = new Point(362, 52);
		BC1D0E19.Name = "label9";
		BC1D0E19.Size = new Size(172, 16);
		BC1D0E19.TabIndex = 47;
		BC1D0E19.Text = "Tùy chọn đối tượng nhắn tin:";
		nudDelayTo.Location = new Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		F428B5AA.Location = new Point(132, 107);
		F428B5AA.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F428B5AA.Name = "nudDelayFrom";
		F428B5AA.Size = new Size(56, 23);
		F428B5AA.TabIndex = 3;
		label7.AutoSize = true;
		label7.Location = new Point(194, 109);
		label7.Name = "label7";
		label7.Size = new Size(28, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new Point(287, 109);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 109);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		CFBEEA96.Location = new Point(229, 78);
		CFBEEA96.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CFBEEA96.Name = "nudSoLuongTo";
		CFBEEA96.Size = new Size(56, 23);
		CFBEEA96.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new Point(194, 80);
		label3.Name = "label3";
		label3.Size = new Size(28, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new Point(287, 80);
		label4.Name = "label4";
		label4.Size = new Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label10.AutoSize = true;
		label10.Location = new Point(28, 446);
		label10.Name = "label10";
		label10.Size = new Size(38, 16);
		label10.TabIndex = 32;
		label10.Text = "Web:";
		label2.AutoSize = true;
		label2.Location = new Point(27, 80);
		label2.Name = "label2";
		label2.Size = new Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		BA3C5499.Anchor = AnchorStyles.Bottom;
		BA3C5499.BackColor = Color.Maroon;
		BA3C5499.Cursor = Cursors.Hand;
		BA3C5499.FlatAppearance.BorderSize = 0;
		BA3C5499.FlatStyle = FlatStyle.Flat;
		BA3C5499.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BA3C5499.ForeColor = Color.White;
		BA3C5499.Location = new Point(346, 440);
		BA3C5499.Name = "btnCancel";
		BA3C5499.Size = new Size(92, 29);
		BA3C5499.TabIndex = 7;
		BA3C5499.Text = "Đóng";
		BA3C5499.UseVisualStyleBackColor = false;
		BA3C5499.Click += BA3C5499_Click;
		C29D19B9.Anchor = AnchorStyles.Bottom;
		C29D19B9.BackColor = Color.FromArgb(53, 120, 229);
		C29D19B9.Cursor = Cursors.Hand;
		C29D19B9.FlatAppearance.BorderSize = 0;
		C29D19B9.FlatStyle = FlatStyle.Flat;
		C29D19B9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C29D19B9.ForeColor = Color.White;
		C29D19B9.Location = new Point(239, 440);
		C29D19B9.Name = "btnAdd";
		C29D19B9.Size = new Size(92, 29);
		C29D19B9.TabIndex = 6;
		C29D19B9.Text = "Thêm";
		C29D19B9.UseVisualStyleBackColor = false;
		C29D19B9.Click += C29D19B9_Click;
		B2A3072E.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B2A3072E.BackColor = Color.White;
		B2A3072E.BorderRadius = 0;
		B2A3072E.BottomSahddow = true;
		B2A3072E.color = Color.DarkViolet;
		B2A3072E.Controls.Add(pnlHeader);
		B2A3072E.LeftSahddow = false;
		B2A3072E.Location = new Point(1, 0);
		B2A3072E.Name = "bunifuCards1";
		B2A3072E.RightSahddow = true;
		B2A3072E.ShadowDepth = 20;
		B2A3072E.Size = new Size(676, 37);
		B2A3072E.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(679, 484);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDNhanTinBanBe";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDNhanTinBanBe_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		F8291103.ResumeLayout(performLayout: false);
		F8291103.PerformLayout();
		CE22E491.ResumeLayout(performLayout: false);
		CE22E491.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)F428B5AA).EndInit();
		((ISupportInitialize)CFBEEA96).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		B2A3072E.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
