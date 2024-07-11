using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class ucTuongTacProfile : UserControl
{
	private JSON_Settings gclass8_0;

	private List<CheckBox> list_0;

	private IContainer F128D5BE = null;

	private Panel plCommentText;

	private CheckBox A787B498;

	private Button B2A187BB;

	private LinkLabel DD36E78F;

	private Panel panel3;

	private RadioButton DE004E35;

	private RadioButton A1281933;

	private Label label13;

	private Label D4851F0F;

	private RichTextBox txtTTPComment;

	private Label F31A49B9;

	private Label lblComment;

	private Panel plCommentImage;

	private TextBox F3901130;

	private Label label12;

	private CheckBox AC859406;

	private CheckBox ckbTTPCommentText;

	private CheckBox E8B9B281;

	private CheckBox ckbTTPInteract;

	private ComboBox cbbTTPTuyChonNoiDung;

	private Panel FA8E3182;

	private CheckBox B413DD10;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Panel B4818100;

	private RadioButton radioButton3;

	private RadioButton A0AC1689;

	private Label label26;

	private Button btnSave;

	private Button btnCancel;

	private Label B917F3BE;

	private NumericUpDown nudTTPDelayTo;

	private NumericUpDown D73ADB3C;

	private NumericUpDown B99BBCB9;

	private NumericUpDown nudTTPSoLuongFrom;

	private Label label3;

	private Label label5;

	private Label label1;

	public ucTuongTacProfile(JSON_Settings gclass8_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		gclass8_0 = gclass8_1;
		list_0 = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, ckbWow, ckbBuon, B413DD10 };
		D93B1CB1();
	}

	private void B5905713(object sender, EventArgs e)
	{
		Common.F9202C12(txtTTPComment, lblComment, cbbTTPTuyChonNoiDung.SelectedIndex);
	}

	private void D93B1CB1()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(cbbTTPTuyChonNoiDung, e6A5AC);
	}

	private void B422651F(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void FF33480C(object sender, EventArgs e)
	{
		if (cbbTTPTuyChonNoiDung.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtTTPComment.Focus();
	}

	private void ckbTTPInteract_CheckedChanged(object sender, EventArgs e)
	{
		FA8E3182.Enabled = ckbTTPInteract.Checked;
	}

	private void AF296B9B(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbTTPCommentText.Checked;
	}

	private void B297DA32(object sender, EventArgs e)
	{
		plCommentImage.Enabled = AC859406.Checked;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Hide();
	}

	private void ucTuongTacProfile_Load(object sender, EventArgs e)
	{
		FC95DC11();
		ckbTTPInteract_CheckedChanged(null, null);
		AF296B9B(null, null);
		B297DA32(null, null);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		method_0();
		Hide();
	}

	private void FC95DC11()
	{
		nudTTPSoLuongFrom.Value = gclass8_0.GetValueInt("nudTTPSoLuongFrom", 1);
		D73ADB3C.Value = gclass8_0.GetValueInt("nudTTPSoLuongTo", 1);
		B99BBCB9.Value = gclass8_0.GetValueInt("nudTTPDelayFrom", 3);
		nudTTPDelayTo.Value = gclass8_0.GetValueInt("nudTTPDelayTo", 5);
		ckbTTPInteract.Checked = gclass8_0.GetValueBool("ckbTTPInteract");
		string text = gclass8_0.GetValue("TTPtypeReaction", "0");
		for (int i = 0; i < list_0.Count; i++)
		{
			list_0[i].Checked = text.Split('|').Contains(i.ToString());
		}
		ckbTTPCommentText.Checked = gclass8_0.GetValueBool("ckbTTPCommentText");
		txtTTPComment.Text = gclass8_0.GetValue("txtTTPComment");
		cbbTTPTuyChonNoiDung.SelectedIndex = gclass8_0.GetValueInt("cbbTTPTuyChonNoiDung");
		AC859406.Checked = gclass8_0.GetValueBool("ckbTTPCommentImage");
		F3901130.Text = gclass8_0.GetValue("txtTTPImagePath");
		E8B9B281.Checked = gclass8_0.GetValueBool("ckbTTPShareWall");
	}

	private void method_0()
	{
		gclass8_0.GetJson("nudTTPSoLuongFrom", nudTTPSoLuongFrom.Value);
		gclass8_0.GetJson("nudTTPSoLuongTo", D73ADB3C.Value);
		gclass8_0.GetJson("nudTTPDelayFrom", B99BBCB9.Value);
		gclass8_0.GetJson("nudTTPDelayTo", nudTTPDelayTo.Value);
		gclass8_0.GetJson("ckbTTPInteract", ckbTTPInteract.Checked);
		string text = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text = text + i + "|";
			}
		}
		gclass8_0.GetJson("TTPtypeReaction", text.TrimEnd('|'));
		gclass8_0.GetJson("ckbTTPCommentText", ckbTTPCommentText.Checked);
		gclass8_0.GetJson("txtTTPComment", txtTTPComment.Text);
		gclass8_0.GetJson("cbbTTPTuyChonNoiDung", cbbTTPTuyChonNoiDung.SelectedIndex);
		gclass8_0.GetJson("ckbTTPCommentImage", AC859406.Checked);
		gclass8_0.GetJson("txtTTPImagePath", F3901130.Text);
		gclass8_0.GetJson("ckbTTPShareWall", E8B9B281.Checked);
	}

	private void FE9C032A(object sender, EventArgs e)
	{
		Common.F9202C12(txtTTPComment, lblComment, cbbTTPTuyChonNoiDung.SelectedIndex);
	}

	private void ucTuongTacProfile_VisibleChanged(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			FC95DC11();
		}
	}

	protected override void Dispose(bool E3024128)
	{
		if (E3024128 && F128D5BE != null)
		{
			F128D5BE.Dispose();
		}
		base.Dispose(E3024128);
	}

	private void InitializeComponent()
	{
		this.plCommentText = new System.Windows.Forms.Panel();
		this.cbbTTPTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		this.A787B498 = new System.Windows.Forms.CheckBox();
		this.B2A187BB = new System.Windows.Forms.Button();
		this.DD36E78F = new System.Windows.Forms.LinkLabel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.DE004E35 = new System.Windows.Forms.RadioButton();
		this.A1281933 = new System.Windows.Forms.RadioButton();
		this.label13 = new System.Windows.Forms.Label();
		this.txtTTPComment = new System.Windows.Forms.RichTextBox();
		this.F31A49B9 = new System.Windows.Forms.Label();
		this.D4851F0F = new System.Windows.Forms.Label();
		this.lblComment = new System.Windows.Forms.Label();
		this.plCommentImage = new System.Windows.Forms.Panel();
		this.F3901130 = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.AC859406 = new System.Windows.Forms.CheckBox();
		this.ckbTTPCommentText = new System.Windows.Forms.CheckBox();
		this.E8B9B281 = new System.Windows.Forms.CheckBox();
		this.ckbTTPInteract = new System.Windows.Forms.CheckBox();
		this.FA8E3182 = new System.Windows.Forms.Panel();
		this.B413DD10 = new System.Windows.Forms.CheckBox();
		this.ckbBuon = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbThuong = new System.Windows.Forms.CheckBox();
		this.ckbTym = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.B4818100 = new System.Windows.Forms.Panel();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.A0AC1689 = new System.Windows.Forms.RadioButton();
		this.label26 = new System.Windows.Forms.Label();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.B917F3BE = new System.Windows.Forms.Label();
		this.nudTTPDelayTo = new System.Windows.Forms.NumericUpDown();
		this.D73ADB3C = new System.Windows.Forms.NumericUpDown();
		this.B99BBCB9 = new System.Windows.Forms.NumericUpDown();
		this.nudTTPSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.plCommentText.SuspendLayout();
		this.panel3.SuspendLayout();
		this.plCommentImage.SuspendLayout();
		this.FA8E3182.SuspendLayout();
		this.B4818100.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTTPDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D73ADB3C).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B99BBCB9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTTPSoLuongFrom).BeginInit();
		base.SuspendLayout();
		this.plCommentText.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.cbbTTPTuyChonNoiDung);
		this.plCommentText.Controls.Add(this.A787B498);
		this.plCommentText.Controls.Add(this.B2A187BB);
		this.plCommentText.Controls.Add(this.DD36E78F);
		this.plCommentText.Controls.Add(this.panel3);
		this.plCommentText.Controls.Add(this.label13);
		this.plCommentText.Controls.Add(this.txtTTPComment);
		this.plCommentText.Controls.Add(this.F31A49B9);
		this.plCommentText.Controls.Add(this.D4851F0F);
		this.plCommentText.Controls.Add(this.lblComment);
		this.plCommentText.Location = new System.Drawing.Point(39, 154);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(310, 184);
		this.plCommentText.TabIndex = 176;
		this.cbbTTPTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTTPTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTTPTuyChonNoiDung.FormattingEnabled = true;
		this.cbbTTPTuyChonNoiDung.Location = new System.Drawing.Point(82, 153);
		this.cbbTTPTuyChonNoiDung.Name = "cbbTTPTuyChonNoiDung";
		this.cbbTTPTuyChonNoiDung.Size = new System.Drawing.Size(190, 24);
		this.cbbTTPTuyChonNoiDung.TabIndex = 177;
		this.cbbTTPTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(FE9C032A);
		this.A787B498.AutoSize = true;
		this.A787B498.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A787B498.Location = new System.Drawing.Point(8, 182);
		this.A787B498.Name = "ckbAutoDeleteComment";
		this.A787B498.Size = new System.Drawing.Size(225, 20);
		this.A787B498.TabIndex = 176;
		this.A787B498.Text = "Tự động xóa nội dung đã bình luận";
		this.A787B498.UseVisualStyleBackColor = true;
		this.B2A187BB.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B2A187BB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B2A187BB.Location = new System.Drawing.Point(278, 152);
		this.B2A187BB.Name = "btnHuongDanNhapNoiDung";
		this.B2A187BB.Size = new System.Drawing.Size(26, 26);
		this.B2A187BB.TabIndex = 173;
		this.B2A187BB.Text = "?";
		this.B2A187BB.UseVisualStyleBackColor = true;
		this.B2A187BB.Click += new System.EventHandler(FF33480C);
		this.DD36E78F.AutoSize = true;
		this.DD36E78F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD36E78F.Location = new System.Drawing.Point(223, 129);
		this.DD36E78F.Name = "linkLabel1";
		this.DD36E78F.Size = new System.Drawing.Size(81, 16);
		this.DD36E78F.TabIndex = 175;
		this.DD36E78F.TabStop = true;
		this.DD36E78F.Text = "Random icon";
		this.DD36E78F.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B422651F);
		this.panel3.Controls.Add(this.DE004E35);
		this.panel3.Controls.Add(this.A1281933);
		this.panel3.Location = new System.Drawing.Point(66, 397);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(200, 43);
		this.panel3.TabIndex = 43;
		this.DE004E35.AutoSize = true;
		this.DE004E35.Checked = true;
		this.DE004E35.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE004E35.Location = new System.Drawing.Point(3, 2);
		this.DE004E35.Name = "rbCommentTheoThuTu";
		this.DE004E35.Size = new System.Drawing.Size(201, 20);
		this.DE004E35.TabIndex = 3;
		this.DE004E35.TabStop = true;
		this.DE004E35.Text = "Comment theo thứ tự nội dung";
		this.DE004E35.UseVisualStyleBackColor = true;
		this.A1281933.AutoSize = true;
		this.A1281933.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1281933.Location = new System.Drawing.Point(3, 23);
		this.A1281933.Name = "rbCommentNgauNhien";
		this.A1281933.Size = new System.Drawing.Size(200, 20);
		this.A1281933.TabIndex = 3;
		this.A1281933.Text = "Comment ngẫu nhiên nội dung";
		this.A1281933.UseVisualStyleBackColor = true;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(3, 399);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(64, 16);
		this.label13.TabIndex = 2;
		this.label13.Text = "Tùy chọn:";
		this.txtTTPComment.Location = new System.Drawing.Point(7, 24);
		this.txtTTPComment.Name = "txtTTPComment";
		this.txtTTPComment.Size = new System.Drawing.Size(297, 102);
		this.txtTTPComment.TabIndex = 1;
		this.txtTTPComment.Text = "";
		this.txtTTPComment.WordWrap = false;
		this.txtTTPComment.TextChanged += new System.EventHandler(B5905713);
		this.F31A49B9.AutoSize = true;
		this.F31A49B9.Location = new System.Drawing.Point(5, 129);
		this.F31A49B9.Name = "label11";
		this.F31A49B9.Size = new System.Drawing.Size(143, 16);
		this.F31A49B9.TabIndex = 0;
		this.F31A49B9.Text = "(Spin nội dung {a|b|c})";
		this.D4851F0F.AutoSize = true;
		this.D4851F0F.Location = new System.Drawing.Point(5, 156);
		this.D4851F0F.Name = "label8";
		this.D4851F0F.Size = new System.Drawing.Size(64, 16);
		this.D4851F0F.TabIndex = 2;
		this.D4851F0F.Text = "Tùy chọn:";
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(3, 4);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(139, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Nội dung bình luận (0):";
		this.plCommentImage.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.plCommentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentImage.Controls.Add(this.F3901130);
		this.plCommentImage.Controls.Add(this.label12);
		this.plCommentImage.Enabled = false;
		this.plCommentImage.Location = new System.Drawing.Point(39, 366);
		this.plCommentImage.Name = "plCommentImage";
		this.plCommentImage.Size = new System.Drawing.Size(310, 31);
		this.plCommentImage.TabIndex = 178;
		this.F3901130.Location = new System.Drawing.Point(82, 3);
		this.F3901130.Name = "txtTTPImagePath";
		this.F3901130.Size = new System.Drawing.Size(222, 23);
		this.F3901130.TabIndex = 155;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(73, 16);
		this.label12.TabIndex = 39;
		this.label12.Text = "Folder ảnh:";
		this.AC859406.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.AC859406.AutoSize = true;
		this.AC859406.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AC859406.Location = new System.Drawing.Point(21, 343);
		this.AC859406.Name = "ckbTTPCommentImage";
		this.AC859406.Size = new System.Drawing.Size(103, 20);
		this.AC859406.TabIndex = 177;
		this.AC859406.Text = "Bình luận ảnh";
		this.AC859406.UseVisualStyleBackColor = true;
		this.AC859406.CheckedChanged += new System.EventHandler(B297DA32);
		this.ckbTTPCommentText.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ckbTTPCommentText.AutoSize = true;
		this.ckbTTPCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTTPCommentText.Location = new System.Drawing.Point(21, 132);
		this.ckbTTPCommentText.Name = "ckbTTPCommentText";
		this.ckbTTPCommentText.Size = new System.Drawing.Size(127, 20);
		this.ckbTTPCommentText.TabIndex = 174;
		this.ckbTTPCommentText.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.ckbTTPCommentText.UseVisualStyleBackColor = true;
		this.ckbTTPCommentText.CheckedChanged += new System.EventHandler(AF296B9B);
		this.E8B9B281.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.E8B9B281.AutoSize = true;
		this.E8B9B281.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E8B9B281.Location = new System.Drawing.Point(21, 401);
		this.E8B9B281.Name = "ckbTTPShareWall";
		this.E8B9B281.Size = new System.Drawing.Size(143, 20);
		this.E8B9B281.TabIndex = 170;
		this.E8B9B281.Text = "Chia sẻ bài về tường";
		this.E8B9B281.UseVisualStyleBackColor = true;
		this.ckbTTPInteract.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.ckbTTPInteract.AutoSize = true;
		this.ckbTTPInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTTPInteract.Location = new System.Drawing.Point(21, 73);
		this.ckbTTPInteract.Name = "ckbTTPInteract";
		this.ckbTTPInteract.Size = new System.Drawing.Size(112, 20);
		this.ckbTTPInteract.TabIndex = 169;
		this.ckbTTPInteract.Text = "Bày tỏ cảm xúc";
		this.ckbTTPInteract.UseVisualStyleBackColor = true;
		this.ckbTTPInteract.CheckedChanged += new System.EventHandler(ckbTTPInteract_CheckedChanged);
		this.FA8E3182.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.FA8E3182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FA8E3182.Controls.Add(this.B413DD10);
		this.FA8E3182.Controls.Add(this.ckbBuon);
		this.FA8E3182.Controls.Add(this.ckbWow);
		this.FA8E3182.Controls.Add(this.ckbHaha);
		this.FA8E3182.Controls.Add(this.ckbThuong);
		this.FA8E3182.Controls.Add(this.ckbTym);
		this.FA8E3182.Controls.Add(this.ckbLike);
		this.FA8E3182.Controls.Add(this.B4818100);
		this.FA8E3182.Controls.Add(this.label26);
		this.FA8E3182.Location = new System.Drawing.Point(39, 94);
		this.FA8E3182.Name = "plInteract";
		this.FA8E3182.Size = new System.Drawing.Size(310, 33);
		this.FA8E3182.TabIndex = 179;
		this.B413DD10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B413DD10.Image = Resources.Bitmap_7;
		this.B413DD10.Location = new System.Drawing.Point(266, 1);
		this.B413DD10.Name = "ckbGian";
		this.B413DD10.Size = new System.Drawing.Size(40, 30);
		this.B413DD10.TabIndex = 179;
		this.B413DD10.UseVisualStyleBackColor = true;
		this.ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBuon.Image = Resources.Bitmap_167;
		this.ckbBuon.Location = new System.Drawing.Point(222, 1);
		this.ckbBuon.Name = "ckbBuon";
		this.ckbBuon.Size = new System.Drawing.Size(40, 30);
		this.ckbBuon.TabIndex = 178;
		this.ckbBuon.UseVisualStyleBackColor = true;
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Image = Resources.BBAD6B14;
		this.ckbWow.Location = new System.Drawing.Point(178, 1);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(40, 30);
		this.ckbWow.TabIndex = 177;
		this.ckbWow.UseVisualStyleBackColor = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Image = Resources.Bitmap_34;
		this.ckbHaha.Location = new System.Drawing.Point(134, 1);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(40, 30);
		this.ckbHaha.TabIndex = 176;
		this.ckbHaha.UseVisualStyleBackColor = true;
		this.ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThuong.Image = Resources.Bitmap_14;
		this.ckbThuong.Location = new System.Drawing.Point(90, 1);
		this.ckbThuong.Name = "ckbThuong";
		this.ckbThuong.Size = new System.Drawing.Size(40, 30);
		this.ckbThuong.TabIndex = 175;
		this.ckbThuong.UseVisualStyleBackColor = true;
		this.ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTym.Image = Resources.Bitmap_154;
		this.ckbTym.Location = new System.Drawing.Point(46, 1);
		this.ckbTym.Name = "ckbTym";
		this.ckbTym.Size = new System.Drawing.Size(40, 30);
		this.ckbTym.TabIndex = 174;
		this.ckbTym.UseVisualStyleBackColor = true;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Image = Resources.B41E983E;
		this.ckbLike.Location = new System.Drawing.Point(2, 1);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(40, 30);
		this.ckbLike.TabIndex = 173;
		this.ckbLike.UseVisualStyleBackColor = true;
		this.B4818100.Controls.Add(this.radioButton3);
		this.B4818100.Controls.Add(this.A0AC1689);
		this.B4818100.Location = new System.Drawing.Point(67, 300);
		this.B4818100.Name = "panel7";
		this.B4818100.Size = new System.Drawing.Size(200, 43);
		this.B4818100.TabIndex = 43;
		this.radioButton3.AutoSize = true;
		this.radioButton3.Checked = true;
		this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton3.Location = new System.Drawing.Point(3, 2);
		this.radioButton3.Name = "radioButton3";
		this.radioButton3.Size = new System.Drawing.Size(201, 20);
		this.radioButton3.TabIndex = 3;
		this.radioButton3.TabStop = true;
		this.radioButton3.Text = "Comment theo thứ tự nội dung";
		this.radioButton3.UseVisualStyleBackColor = true;
		this.A0AC1689.AutoSize = true;
		this.A0AC1689.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A0AC1689.Location = new System.Drawing.Point(3, 23);
		this.A0AC1689.Name = "radioButton4";
		this.A0AC1689.Size = new System.Drawing.Size(200, 20);
		this.A0AC1689.TabIndex = 3;
		this.A0AC1689.Text = "Comment ngẫu nhiên nội dung";
		this.A0AC1689.UseVisualStyleBackColor = true;
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(4, 302);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(64, 16);
		this.label26.TabIndex = 2;
		this.label26.Text = "Tùy chọn:";
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnSave.FlatAppearance.BorderSize = 0;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSave.ForeColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(84, 433);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(92, 29);
		this.btnSave.TabIndex = 180;
		this.btnSave.Text = "Lưu";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(194, 433);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 181;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.B917F3BE.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.B917F3BE.AutoSize = true;
		this.B917F3BE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.B917F3BE.Location = new System.Drawing.Point(18, 17);
		this.B917F3BE.Name = "label19";
		this.B917F3BE.Size = new System.Drawing.Size(72, 16);
		this.B917F3BE.TabIndex = 191;
		this.B917F3BE.Text = "Sô\u0301 ba\u0300i viết:";
		this.nudTTPDelayTo.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudTTPDelayTo.Location = new System.Drawing.Point(230, 44);
		this.nudTTPDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudTTPDelayTo.Name = "nudTTPDelayTo";
		this.nudTTPDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudTTPDelayTo.TabIndex = 185;
		this.D73ADB3C.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.D73ADB3C.Location = new System.Drawing.Point(230, 15);
		this.D73ADB3C.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.D73ADB3C.Name = "nudTTPSoLuongTo";
		this.D73ADB3C.Size = new System.Drawing.Size(56, 23);
		this.D73ADB3C.TabIndex = 183;
		this.B99BBCB9.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.B99BBCB9.Location = new System.Drawing.Point(133, 44);
		this.B99BBCB9.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.B99BBCB9.Name = "nudTTPDelayFrom";
		this.B99BBCB9.Size = new System.Drawing.Size(56, 23);
		this.B99BBCB9.TabIndex = 184;
		this.nudTTPSoLuongFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.nudTTPSoLuongFrom.Location = new System.Drawing.Point(133, 15);
		this.nudTTPSoLuongFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudTTPSoLuongFrom.Name = "nudTTPSoLuongFrom";
		this.nudTTPSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudTTPSoLuongFrom.TabIndex = 182;
		this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(195, 17);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 189;
		this.label3.Text = ">";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(18, 46);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(109, 16);
		this.label5.TabIndex = 186;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300 (s):";
		this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(195, 46);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(29, 16);
		this.label1.TabIndex = 189;
		this.label1.Text = ">";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		base.Controls.Add(this.B917F3BE);
		base.Controls.Add(this.nudTTPDelayTo);
		base.Controls.Add(this.D73ADB3C);
		base.Controls.Add(this.B99BBCB9);
		base.Controls.Add(this.nudTTPSoLuongFrom);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.FA8E3182);
		base.Controls.Add(this.plCommentText);
		base.Controls.Add(this.plCommentImage);
		base.Controls.Add(this.AC859406);
		base.Controls.Add(this.ckbTTPCommentText);
		base.Controls.Add(this.E8B9B281);
		base.Controls.Add(this.ckbTTPInteract);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacProfile";
		base.Size = new System.Drawing.Size(367, 475);
		base.Load += new System.EventHandler(ucTuongTacProfile_Load);
		base.VisibleChanged += new System.EventHandler(ucTuongTacProfile_VisibleChanged);
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.plCommentImage.ResumeLayout(false);
		this.plCommentImage.PerformLayout();
		this.FA8E3182.ResumeLayout(false);
		this.FA8E3182.PerformLayout();
		this.B4818100.ResumeLayout(false);
		this.B4818100.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTTPDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D73ADB3C).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B99BBCB9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTTPSoLuongFrom).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
