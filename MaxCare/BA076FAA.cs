using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class BA076FAA : UserControl
{
	private JSON_Settings D19578B2;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private Panel CF3B3484;

	private CheckBox ckbAutoDeleteComment;

	private Button btnHuongDanNhapNoiDung;

	private LinkLabel linkLabel1;

	private Panel panel3;

	private RadioButton rbCommentTheoThuTu;

	private RadioButton rbCommentNgauNhien;

	private Label label13;

	private Label label8;

	private RichTextBox txtTTBVComment;

	private Label CCB9A617;

	private Label B6840A97;

	private Panel F5AE1886;

	private TextBox txtTTBVImagePath;

	private Label BE25A009;

	private CheckBox ckbTTBVCommentImage;

	private CheckBox DAB5A18C;

	private CheckBox ckbTTBVShareWall;

	private CheckBox ckbTTBVInteract;

	private NumericUpDown nudTTBVTimeTo;

	private NumericUpDown nudTTBVTimeFrom;

	private Label CD14862F;

	private Label label3;

	private ComboBox cbbTTBVTuyChonNoiDung;

	private Panel plInteract;

	private CheckBox AB2B2711;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox F1A87E25;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Panel FF3E111D;

	private RadioButton CC3DF52F;

	private RadioButton E312361B;

	private Label FF81F124;

	private Button E200C3B0;

	private Button btnCancel;

	public BA076FAA(JSON_Settings gclass8_0)
	{
		C78C5815();
		Language.SetLanguage(this);
		D19578B2 = gclass8_0;
		list_0 = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, F1A87E25, ckbWow, ckbBuon, AB2B2711 };
		method_0();
	}

	private void E31A602B(object sender, EventArgs e)
	{
		Common.F9202C12(txtTTBVComment, B6840A97, cbbTTBVTuyChonNoiDung.SelectedIndex);
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(cbbTTBVTuyChonNoiDung, e6A5AC);
	}

	private void A2884C9B(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (cbbTTBVTuyChonNoiDung.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtTTBVComment.Focus();
	}

	private void ckbTTBVInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbTTBVInteract.Checked;
	}

	private void DAB5A18C_CheckedChanged(object sender, EventArgs e)
	{
		CF3B3484.Enabled = DAB5A18C.Checked;
	}

	private void F1A5760F(object sender, EventArgs e)
	{
		F5AE1886.Enabled = ckbTTBVCommentImage.Checked;
	}

	private void E216EE22(object sender, EventArgs e)
	{
		Hide();
	}

	private void E200C3B0_Click(object sender, EventArgs e)
	{
		method_1();
		Hide();
	}

	private void DFA59C8D()
	{
		nudTTBVTimeFrom.Value = D19578B2.GetValueInt("nudTTBVTimeFrom", 3);
		nudTTBVTimeTo.Value = D19578B2.GetValueInt("nudTTBVTimeTo", 5);
		ckbTTBVInteract.Checked = D19578B2.GetValueBool("ckbTTBVInteract");
		string text = D19578B2.GetValue("TTBVtypeReaction", "0");
		for (int i = 0; i < list_0.Count; i++)
		{
			list_0[i].Checked = text.Split('|').Contains(i.ToString());
		}
		DAB5A18C.Checked = D19578B2.GetValueBool("ckbTTBVCommentText");
		txtTTBVComment.Text = D19578B2.GetValue("txtTTBVComment");
		cbbTTBVTuyChonNoiDung.SelectedIndex = D19578B2.GetValueInt("cbbTTBVTuyChonNoiDung");
		ckbTTBVCommentImage.Checked = D19578B2.GetValueBool("ckbTTBVCommentImage");
		txtTTBVImagePath.Text = D19578B2.GetValue("txtTTBVImagePath");
		ckbTTBVShareWall.Checked = D19578B2.GetValueBool("ckbTTBVShareWall");
	}

	private void method_1()
	{
		D19578B2.GetJson("nudTTBVTimeFrom", nudTTBVTimeFrom.Value);
		D19578B2.GetJson("nudTTBVTimeTo", nudTTBVTimeTo.Value);
		D19578B2.GetJson("ckbTTBVInteract", ckbTTBVInteract.Checked);
		string text = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text = text + i + "|";
			}
		}
		D19578B2.GetJson("TTBVtypeReaction", text.TrimEnd('|'));
		D19578B2.GetJson("ckbTTBVCommentText", DAB5A18C.Checked);
		D19578B2.GetJson("txtTTBVComment", txtTTBVComment.Text);
		D19578B2.GetJson("cbbTTBVTuyChonNoiDung", cbbTTBVTuyChonNoiDung.SelectedIndex);
		D19578B2.GetJson("ckbTTBVCommentImage", ckbTTBVCommentImage.Checked);
		D19578B2.GetJson("txtTTBVImagePath", txtTTBVImagePath.Text);
		D19578B2.GetJson("ckbTTBVShareWall", ckbTTBVShareWall.Checked);
	}

	private void BA076FAA_Load(object sender, EventArgs e)
	{
		DFA59C8D();
		ckbTTBVInteract_CheckedChanged(null, null);
		DAB5A18C_CheckedChanged(null, null);
		F1A5760F(null, null);
	}

	private void cbbTTBVTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtTTBVComment, B6840A97, cbbTTBVTuyChonNoiDung.SelectedIndex);
	}

	private void BA076FAA_VisibleChanged(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			DFA59C8D();
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void C78C5815()
	{
		CF3B3484 = new Panel();
		cbbTTBVTuyChonNoiDung = new ComboBox();
		ckbAutoDeleteComment = new CheckBox();
		btnHuongDanNhapNoiDung = new Button();
		linkLabel1 = new LinkLabel();
		panel3 = new Panel();
		rbCommentTheoThuTu = new RadioButton();
		rbCommentNgauNhien = new RadioButton();
		label13 = new Label();
		txtTTBVComment = new RichTextBox();
		CCB9A617 = new Label();
		label8 = new Label();
		B6840A97 = new Label();
		F5AE1886 = new Panel();
		txtTTBVImagePath = new TextBox();
		BE25A009 = new Label();
		ckbTTBVCommentImage = new CheckBox();
		DAB5A18C = new CheckBox();
		ckbTTBVShareWall = new CheckBox();
		ckbTTBVInteract = new CheckBox();
		nudTTBVTimeTo = new NumericUpDown();
		nudTTBVTimeFrom = new NumericUpDown();
		CD14862F = new Label();
		label3 = new Label();
		plInteract = new Panel();
		AB2B2711 = new CheckBox();
		ckbBuon = new CheckBox();
		ckbWow = new CheckBox();
		F1A87E25 = new CheckBox();
		ckbThuong = new CheckBox();
		ckbTym = new CheckBox();
		ckbLike = new CheckBox();
		FF3E111D = new Panel();
		CC3DF52F = new RadioButton();
		E312361B = new RadioButton();
		FF81F124 = new Label();
		E200C3B0 = new Button();
		btnCancel = new Button();
		CF3B3484.SuspendLayout();
		panel3.SuspendLayout();
		F5AE1886.SuspendLayout();
		((ISupportInitialize)nudTTBVTimeTo).BeginInit();
		((ISupportInitialize)nudTTBVTimeFrom).BeginInit();
		plInteract.SuspendLayout();
		FF3E111D.SuspendLayout();
		SuspendLayout();
		CF3B3484.Anchor = AnchorStyles.None;
		CF3B3484.BorderStyle = BorderStyle.FixedSingle;
		CF3B3484.Controls.Add(cbbTTBVTuyChonNoiDung);
		CF3B3484.Controls.Add(ckbAutoDeleteComment);
		CF3B3484.Controls.Add(btnHuongDanNhapNoiDung);
		CF3B3484.Controls.Add(linkLabel1);
		CF3B3484.Controls.Add(panel3);
		CF3B3484.Controls.Add(label13);
		CF3B3484.Controls.Add(txtTTBVComment);
		CF3B3484.Controls.Add(CCB9A617);
		CF3B3484.Controls.Add(label8);
		CF3B3484.Controls.Add(B6840A97);
		CF3B3484.Location = new Point(37, 122);
		CF3B3484.Name = "plCommentText";
		CF3B3484.Size = new Size(310, 184);
		CF3B3484.TabIndex = 176;
		cbbTTBVTuyChonNoiDung.Cursor = Cursors.Hand;
		cbbTTBVTuyChonNoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTTBVTuyChonNoiDung.FormattingEnabled = true;
		cbbTTBVTuyChonNoiDung.Location = new Point(81, 153);
		cbbTTBVTuyChonNoiDung.Name = "cbbTTBVTuyChonNoiDung";
		cbbTTBVTuyChonNoiDung.Size = new Size(190, 24);
		cbbTTBVTuyChonNoiDung.TabIndex = 177;
		cbbTTBVTuyChonNoiDung.SelectedIndexChanged += cbbTTBVTuyChonNoiDung_SelectedIndexChanged;
		ckbAutoDeleteComment.AutoSize = true;
		ckbAutoDeleteComment.Cursor = Cursors.Hand;
		ckbAutoDeleteComment.Location = new Point(8, 182);
		ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		ckbAutoDeleteComment.Size = new Size(225, 20);
		ckbAutoDeleteComment.TabIndex = 176;
		ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Cursor = Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new Point(277, 152);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 173;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += btnHuongDanNhapNoiDung_Click;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = Cursors.Hand;
		linkLabel1.Location = new Point(222, 129);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(81, 16);
		linkLabel1.TabIndex = 175;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += A2884C9B;
		panel3.Controls.Add(rbCommentTheoThuTu);
		panel3.Controls.Add(rbCommentNgauNhien);
		panel3.Location = new Point(66, 397);
		panel3.Name = "panel3";
		panel3.Size = new Size(200, 43);
		panel3.TabIndex = 43;
		rbCommentTheoThuTu.AutoSize = true;
		rbCommentTheoThuTu.Checked = true;
		rbCommentTheoThuTu.Cursor = Cursors.Hand;
		rbCommentTheoThuTu.Location = new Point(3, 2);
		rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
		rbCommentTheoThuTu.Size = new Size(201, 20);
		rbCommentTheoThuTu.TabIndex = 3;
		rbCommentTheoThuTu.TabStop = true;
		rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
		rbCommentTheoThuTu.UseVisualStyleBackColor = true;
		rbCommentNgauNhien.AutoSize = true;
		rbCommentNgauNhien.Cursor = Cursors.Hand;
		rbCommentNgauNhien.Location = new Point(3, 23);
		rbCommentNgauNhien.Name = "rbCommentNgauNhien";
		rbCommentNgauNhien.Size = new Size(200, 20);
		rbCommentNgauNhien.TabIndex = 3;
		rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
		rbCommentNgauNhien.UseVisualStyleBackColor = true;
		label13.AutoSize = true;
		label13.Location = new Point(3, 399);
		label13.Name = "label13";
		label13.Size = new Size(64, 16);
		label13.TabIndex = 2;
		label13.Text = "Tùy chọn:";
		txtTTBVComment.Location = new Point(6, 24);
		txtTTBVComment.Name = "txtTTBVComment";
		txtTTBVComment.Size = new Size(297, 102);
		txtTTBVComment.TabIndex = 1;
		txtTTBVComment.Text = "";
		txtTTBVComment.WordWrap = false;
		txtTTBVComment.TextChanged += E31A602B;
		CCB9A617.AutoSize = true;
		CCB9A617.Location = new Point(4, 129);
		CCB9A617.Name = "label11";
		CCB9A617.Size = new Size(143, 16);
		CCB9A617.TabIndex = 0;
		CCB9A617.Text = "(Spin nội dung {a|b|c})";
		label8.AutoSize = true;
		label8.Location = new Point(4, 156);
		label8.Name = "label8";
		label8.Size = new Size(64, 16);
		label8.TabIndex = 2;
		label8.Text = "Tùy chọn:";
		B6840A97.AutoSize = true;
		B6840A97.Location = new Point(2, 4);
		B6840A97.Name = "lblComment";
		B6840A97.Size = new Size(139, 16);
		B6840A97.TabIndex = 0;
		B6840A97.Text = "Nội dung bình luận (0):";
		F5AE1886.Anchor = AnchorStyles.None;
		F5AE1886.BorderStyle = BorderStyle.FixedSingle;
		F5AE1886.Controls.Add(txtTTBVImagePath);
		F5AE1886.Controls.Add(BE25A009);
		F5AE1886.Enabled = false;
		F5AE1886.Location = new Point(37, 334);
		F5AE1886.Name = "plCommentImage";
		F5AE1886.Size = new Size(310, 31);
		F5AE1886.TabIndex = 178;
		txtTTBVImagePath.Location = new Point(82, 3);
		txtTTBVImagePath.Name = "txtTTBVImagePath";
		txtTTBVImagePath.Size = new Size(222, 23);
		txtTTBVImagePath.TabIndex = 155;
		BE25A009.AutoSize = true;
		BE25A009.Location = new Point(3, 6);
		BE25A009.Name = "label12";
		BE25A009.Size = new Size(73, 16);
		BE25A009.TabIndex = 39;
		BE25A009.Text = "Folder ảnh:";
		ckbTTBVCommentImage.Anchor = AnchorStyles.None;
		ckbTTBVCommentImage.AutoSize = true;
		ckbTTBVCommentImage.Cursor = Cursors.Hand;
		ckbTTBVCommentImage.Location = new Point(19, 311);
		ckbTTBVCommentImage.Name = "ckbTTBVCommentImage";
		ckbTTBVCommentImage.Size = new Size(103, 20);
		ckbTTBVCommentImage.TabIndex = 177;
		ckbTTBVCommentImage.Text = "Bình luận ảnh";
		ckbTTBVCommentImage.UseVisualStyleBackColor = true;
		ckbTTBVCommentImage.CheckedChanged += F1A5760F;
		DAB5A18C.Anchor = AnchorStyles.None;
		DAB5A18C.AutoSize = true;
		DAB5A18C.Cursor = Cursors.Hand;
		DAB5A18C.Location = new Point(19, 100);
		DAB5A18C.Name = "ckbTTBVCommentText";
		DAB5A18C.Size = new Size(127, 20);
		DAB5A18C.TabIndex = 174;
		DAB5A18C.Text = "Bi\u0300nh luâ\u0323n văn bản";
		DAB5A18C.UseVisualStyleBackColor = true;
		DAB5A18C.CheckedChanged += DAB5A18C_CheckedChanged;
		ckbTTBVShareWall.Anchor = AnchorStyles.None;
		ckbTTBVShareWall.AutoSize = true;
		ckbTTBVShareWall.Cursor = Cursors.Hand;
		ckbTTBVShareWall.Location = new Point(19, 369);
		ckbTTBVShareWall.Name = "ckbTTBVShareWall";
		ckbTTBVShareWall.Size = new Size(143, 20);
		ckbTTBVShareWall.TabIndex = 170;
		ckbTTBVShareWall.Text = "Chia sẻ bài về tường";
		ckbTTBVShareWall.UseVisualStyleBackColor = true;
		ckbTTBVInteract.Anchor = AnchorStyles.None;
		ckbTTBVInteract.AutoSize = true;
		ckbTTBVInteract.Cursor = Cursors.Hand;
		ckbTTBVInteract.Location = new Point(19, 41);
		ckbTTBVInteract.Name = "ckbTTBVInteract";
		ckbTTBVInteract.Size = new Size(112, 20);
		ckbTTBVInteract.TabIndex = 169;
		ckbTTBVInteract.Text = "Bày tỏ cảm xúc";
		ckbTTBVInteract.UseVisualStyleBackColor = true;
		ckbTTBVInteract.CheckedChanged += ckbTTBVInteract_CheckedChanged;
		nudTTBVTimeTo.Anchor = AnchorStyles.None;
		nudTTBVTimeTo.Location = new Point(258, 11);
		nudTTBVTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTTBVTimeTo.Name = "nudTTBVTimeTo";
		nudTTBVTimeTo.Size = new Size(51, 23);
		nudTTBVTimeTo.TabIndex = 168;
		nudTTBVTimeFrom.Anchor = AnchorStyles.None;
		nudTTBVTimeFrom.Location = new Point(180, 11);
		nudTTBVTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTTBVTimeFrom.Name = "nudTTBVTimeFrom";
		nudTTBVTimeFrom.Size = new Size(51, 23);
		nudTTBVTimeFrom.TabIndex = 167;
		CD14862F.Anchor = AnchorStyles.None;
		CD14862F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CD14862F.Location = new Point(231, 13);
		CD14862F.Name = "label9";
		CD14862F.Size = new Size(29, 16);
		CD14862F.TabIndex = 173;
		CD14862F.Text = ">";
		CD14862F.TextAlign = ContentAlignment.MiddleCenter;
		label3.Anchor = AnchorStyles.None;
		label3.AutoSize = true;
		label3.Location = new Point(16, 13);
		label3.Name = "label3";
		label3.Size = new Size(158, 16);
		label3.TabIndex = 171;
		label3.Text = "Thơ\u0300i gian xem bài viết (s):";
		plInteract.Anchor = AnchorStyles.None;
		plInteract.BorderStyle = BorderStyle.FixedSingle;
		plInteract.Controls.Add(AB2B2711);
		plInteract.Controls.Add(ckbBuon);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(F1A87E25);
		plInteract.Controls.Add(ckbThuong);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(FF3E111D);
		plInteract.Controls.Add(FF81F124);
		plInteract.Location = new Point(37, 61);
		plInteract.Name = "plInteract";
		plInteract.Size = new Size(310, 33);
		plInteract.TabIndex = 179;
		AB2B2711.Cursor = Cursors.Hand;
		AB2B2711.Image = Resources.Bitmap_7;
		AB2B2711.Location = new Point(266, 1);
		AB2B2711.Name = "ckbGian";
		AB2B2711.Size = new Size(40, 30);
		AB2B2711.TabIndex = 179;
		AB2B2711.UseVisualStyleBackColor = true;
		ckbBuon.Cursor = Cursors.Hand;
		ckbBuon.Image = Resources.Bitmap_167;
		ckbBuon.Location = new Point(222, 1);
		ckbBuon.Name = "ckbBuon";
		ckbBuon.Size = new Size(40, 30);
		ckbBuon.TabIndex = 178;
		ckbBuon.UseVisualStyleBackColor = true;
		ckbWow.Cursor = Cursors.Hand;
		ckbWow.Image = Resources.BBAD6B14;
		ckbWow.Location = new Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.UseVisualStyleBackColor = true;
		F1A87E25.Cursor = Cursors.Hand;
		F1A87E25.Image = Resources.Bitmap_34;
		F1A87E25.Location = new Point(134, 1);
		F1A87E25.Name = "ckbHaha";
		F1A87E25.Size = new Size(40, 30);
		F1A87E25.TabIndex = 176;
		F1A87E25.UseVisualStyleBackColor = true;
		ckbThuong.Cursor = Cursors.Hand;
		ckbThuong.Image = Resources.Bitmap_14;
		ckbThuong.Location = new Point(90, 1);
		ckbThuong.Name = "ckbThuong";
		ckbThuong.Size = new Size(40, 30);
		ckbThuong.TabIndex = 175;
		ckbThuong.UseVisualStyleBackColor = true;
		ckbTym.Cursor = Cursors.Hand;
		ckbTym.Image = Resources.Bitmap_154;
		ckbTym.Location = new Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		ckbLike.Checked = true;
		ckbLike.CheckState = CheckState.Checked;
		ckbLike.Cursor = Cursors.Hand;
		ckbLike.Image = Resources.B41E983E;
		ckbLike.Location = new Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.UseVisualStyleBackColor = true;
		FF3E111D.Controls.Add(CC3DF52F);
		FF3E111D.Controls.Add(E312361B);
		FF3E111D.Location = new Point(67, 300);
		FF3E111D.Name = "panel7";
		FF3E111D.Size = new Size(200, 43);
		FF3E111D.TabIndex = 43;
		CC3DF52F.AutoSize = true;
		CC3DF52F.Checked = true;
		CC3DF52F.Cursor = Cursors.Hand;
		CC3DF52F.Location = new Point(3, 2);
		CC3DF52F.Name = "radioButton3";
		CC3DF52F.Size = new Size(201, 20);
		CC3DF52F.TabIndex = 3;
		CC3DF52F.TabStop = true;
		CC3DF52F.Text = "Comment theo thứ tự nội dung";
		CC3DF52F.UseVisualStyleBackColor = true;
		E312361B.AutoSize = true;
		E312361B.Cursor = Cursors.Hand;
		E312361B.Location = new Point(3, 23);
		E312361B.Name = "radioButton4";
		E312361B.Size = new Size(200, 20);
		E312361B.TabIndex = 3;
		E312361B.Text = "Comment ngẫu nhiên nội dung";
		E312361B.UseVisualStyleBackColor = true;
		FF81F124.AutoSize = true;
		FF81F124.Location = new Point(4, 302);
		FF81F124.Name = "label26";
		FF81F124.Size = new Size(64, 16);
		FF81F124.TabIndex = 2;
		FF81F124.Text = "Tùy chọn:";
		E200C3B0.Anchor = AnchorStyles.Bottom;
		E200C3B0.BackColor = Color.FromArgb(53, 120, 229);
		E200C3B0.Cursor = Cursors.Hand;
		E200C3B0.FlatAppearance.BorderSize = 0;
		E200C3B0.FlatStyle = FlatStyle.Flat;
		E200C3B0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E200C3B0.ForeColor = Color.White;
		E200C3B0.Location = new Point(84, 402);
		E200C3B0.Name = "btnSave";
		E200C3B0.Size = new Size(92, 29);
		E200C3B0.TabIndex = 180;
		E200C3B0.Text = "Lưu";
		E200C3B0.UseVisualStyleBackColor = false;
		E200C3B0.Click += E200C3B0_Click;
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(194, 402);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 181;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += E216EE22;
		base.AutoScaleMode = AutoScaleMode.None;
		BackColor = Color.White;
		base.BorderStyle = BorderStyle.FixedSingle;
		base.Controls.Add(E200C3B0);
		base.Controls.Add(btnCancel);
		base.Controls.Add(plInteract);
		base.Controls.Add(CF3B3484);
		base.Controls.Add(F5AE1886);
		base.Controls.Add(ckbTTBVCommentImage);
		base.Controls.Add(DAB5A18C);
		base.Controls.Add(ckbTTBVShareWall);
		base.Controls.Add(ckbTTBVInteract);
		base.Controls.Add(nudTTBVTimeTo);
		base.Controls.Add(nudTTBVTimeFrom);
		base.Controls.Add(CD14862F);
		base.Controls.Add(label3);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacBaiViet";
		base.Size = new Size(367, 444);
		base.Load += BA076FAA_Load;
		base.VisibleChanged += BA076FAA_VisibleChanged;
		CF3B3484.ResumeLayout(performLayout: false);
		CF3B3484.PerformLayout();
		panel3.ResumeLayout(performLayout: false);
		panel3.PerformLayout();
		F5AE1886.ResumeLayout(performLayout: false);
		F5AE1886.PerformLayout();
		((ISupportInitialize)nudTTBVTimeTo).EndInit();
		((ISupportInitialize)nudTTBVTimeFrom).EndInit();
		plInteract.ResumeLayout(performLayout: false);
		plInteract.PerformLayout();
		FF3E111D.ResumeLayout(performLayout: false);
		FF3E111D.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
