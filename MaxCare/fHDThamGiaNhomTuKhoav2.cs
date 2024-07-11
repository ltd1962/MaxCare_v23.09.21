using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDThamGiaNhomTuKhoav2 : Form
{
	private JSON_Settings D21E5CAB;

	private string string_0;

	private string F031EC8B;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl E18F1C12;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label DFBAD3A2;

	private Label BA300F80;

	private Label label1;

	private Button btnCancel;

	private Button E9B40713;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C03AFE13;

	private Label D0275E22;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown BA32FC35;

	private Label label7;

	private Label label6;

	private Label label5;

	private RichTextBox txtTuKhoa;

	private ToolTip toolTip_0;

	private Panel plTuongTac;

	private CheckBox ckbTuDongTraLoiCauHoi;

	private TextBox A28DC327;

	private Label label9;

	private Label F987A415;

	public fHDThamGiaNhomTuKhoav2(string string_2, int int_1 = 0, string B18C2D1E = "")
	{
		DDBB3BA6();
		bool_0 = false;
		string_0 = string_2;
		string_1 = B18C2D1E;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDThamGiaNhomTuKhoav2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomTuKhoav2', 'Tham gia nhóm theo từ khóa v2');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDThamGiaNhomTuKhoav2");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			F031EC8B = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(B18C2D1E);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			E9B40713.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D21E5CAB = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(C03AFE13);
		Language.smethod_0(label1);
		Language.smethod_0(BA300F80);
		Language.smethod_0(label3);
		Language.smethod_0(DFBAD3A2);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(lblStatus);
		Language.smethod_0(D0275E22);
		Language.smethod_0(ckbTuDongTraLoiCauHoi);
		Language.smethod_0(F987A415);
		Language.smethod_0(label9);
		Language.smethod_0(E9B40713);
		Language.smethod_0(btnCancel);
	}

	private void fHDThamGiaNhomTuKhoav2_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = D21E5CAB.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = D21E5CAB.GetValueInt("nudSoLuongTo", 3);
			BA32FC35.Value = D21E5CAB.GetValueInt("nudDelayFrom", 2);
			nudDelayTo.Value = D21E5CAB.GetValueInt("nudDelayTo", 4);
			txtTuKhoa.Text = D21E5CAB.GetValue("txtTuKhoa");
			ckbTuDongTraLoiCauHoi.Checked = D21E5CAB.GetValueBool("ckbTuDongTraLoiCauHoi");
			A28DC327.Text = D21E5CAB.GetValue("txtCauTraLoi");
		}
		catch
		{
		}
		method_1();
	}

	private void method_1()
	{
		B78F5412(null, null);
	}

	private void A2BA9810(object sender, EventArgs e)
	{
		Close();
	}

	private void E9B40713_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtTuKhoa.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách từ khóa!", 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
		{
			a2AB53A = A28DC327.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", BA32FC35.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtTuKhoa", txtTuKhoa.Text.Trim());
		gClass.GetJson("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		gClass.GetJson("txtCauTraLoi", A28DC327.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, F031EC8B, string_))
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
			if (InteractSQL.smethod_13(string_1, text, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
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

	private void CA985333(object sender, EventArgs e)
	{
	}

	private void E13620A4(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTuKhoa.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch từ khóa ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void A28DC327_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = A28DC327.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			F987A415.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void B78F5412(object sender, EventArgs e)
	{
		plTuongTac.Enabled = ckbTuDongTraLoiCauHoi.Checked;
	}

	protected override void Dispose(bool EAA38B08)
	{
		if (EAA38B08 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(EAA38B08);
	}

	private void DDBB3BA6()
	{
		icontainer_0 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		C03AFE13 = new BunifuCustomLabel();
		E18F1C12 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plTuongTac = new Panel();
		A28DC327 = new TextBox();
		label9 = new Label();
		F987A415 = new Label();
		ckbTuDongTraLoiCauHoi = new CheckBox();
		txtTuKhoa = new RichTextBox();
		nudDelayTo = new NumericUpDown();
		D0275E22 = new Label();
		lblStatus = new Label();
		BA32FC35 = new NumericUpDown();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		DFBAD3A2 = new Label();
		BA300F80 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		E9B40713 = new Button();
		bunifuCards1 = new BunifuCards();
		toolTip_0 = new ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plTuongTac.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)BA32FC35).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C03AFE13;
		bunifuDragControl_0.Vertical = true;
		C03AFE13.BackColor = Color.Transparent;
		C03AFE13.Cursor = Cursors.SizeAll;
		C03AFE13.Dock = DockStyle.Fill;
		C03AFE13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C03AFE13.ForeColor = Color.Black;
		C03AFE13.Location = new Point(0, 0);
		C03AFE13.Name = "bunifuCustomLabel1";
		C03AFE13.Size = new Size(687, 31);
		C03AFE13.TabIndex = 12;
		C03AFE13.Text = "Cấu hình Tham gia nhóm theo từ khóa v2";
		C03AFE13.TextAlign = ContentAlignment.MiddleCenter;
		E18F1C12.Fixed = true;
		E18F1C12.Horizontal = true;
		E18F1C12.TargetControl = pnlHeader;
		E18F1C12.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(C03AFE13);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(687, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = Resources.C400940B;
		button1.Location = new Point(656, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += A2BA9810;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(plTuongTac);
		panel1.Controls.Add(ckbTuDongTraLoiCauHoi);
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(D0275E22);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(BA32FC35);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(DFBAD3A2);
		panel1.Controls.Add(BA300F80);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(E9B40713);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(690, 375);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		plTuongTac.BorderStyle = BorderStyle.FixedSingle;
		plTuongTac.Controls.Add(A28DC327);
		plTuongTac.Controls.Add(label9);
		plTuongTac.Controls.Add(F987A415);
		plTuongTac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plTuongTac.Location = new Point(367, 74);
		plTuongTac.Name = "plTuongTac";
		plTuongTac.Size = new Size(310, 238);
		plTuongTac.TabIndex = 116;
		A28DC327.Location = new Point(7, 25);
		A28DC327.Multiline = true;
		A28DC327.Name = "txtCauTraLoi";
		A28DC327.ScrollBars = ScrollBars.Both;
		A28DC327.Size = new Size(294, 190);
		A28DC327.TabIndex = 1;
		A28DC327.WordWrap = false;
		A28DC327.TextChanged += A28DC327_TextChanged;
		label9.AutoSize = true;
		label9.Location = new Point(3, 218);
		label9.Name = "label9";
		label9.Size = new Size(266, 16);
		label9.TabIndex = 0;
		label9.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		F987A415.AutoSize = true;
		F987A415.Location = new Point(3, 4);
		F987A415.Name = "lblStatusComment";
		F987A415.Size = new Size(154, 16);
		F987A415.TabIndex = 0;
		F987A415.Text = "Danh sách câu trả lời (0):";
		ckbTuDongTraLoiCauHoi.AutoSize = true;
		ckbTuDongTraLoiCauHoi.Cursor = Cursors.Hand;
		ckbTuDongTraLoiCauHoi.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuDongTraLoiCauHoi.Location = new Point(349, 51);
		ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		ckbTuDongTraLoiCauHoi.Size = new Size(157, 20);
		ckbTuDongTraLoiCauHoi.TabIndex = 115;
		ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		ckbTuDongTraLoiCauHoi.CheckedChanged += B78F5412;
		txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
		txtTuKhoa.Location = new Point(31, 159);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new Size(295, 136);
		txtTuKhoa.TabIndex = 114;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += E13620A4;
		nudDelayTo.Location = new Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		D0275E22.AutoSize = true;
		D0275E22.Location = new Point(28, 296);
		D0275E22.Name = "label8";
		D0275E22.Size = new Size(260, 16);
		D0275E22.TabIndex = 0;
		D0275E22.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(27, 139);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(140, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch từ khóa (0):";
		BA32FC35.Location = new Point(132, 111);
		BA32FC35.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BA32FC35.Name = "nudDelayFrom";
		BA32FC35.Size = new Size(56, 23);
		BA32FC35.TabIndex = 3;
		label7.Location = new Point(194, 113);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 113);
		label6.Name = "label6";
		label6.Size = new Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 113);
		label5.Name = "label5";
		label5.Size = new Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new Point(194, 82);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		DFBAD3A2.AutoSize = true;
		DFBAD3A2.Location = new Point(287, 82);
		DFBAD3A2.Name = "label4";
		DFBAD3A2.Size = new Size(40, 16);
		DFBAD3A2.TabIndex = 35;
		DFBAD3A2.Text = "nhóm";
		BA300F80.AutoSize = true;
		BA300F80.Location = new Point(27, 82);
		BA300F80.Name = "label2";
		BA300F80.Size = new Size(64, 16);
		BA300F80.TabIndex = 32;
		BA300F80.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(354, 329);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		E9B40713.BackColor = Color.FromArgb(53, 120, 229);
		E9B40713.Cursor = Cursors.Hand;
		E9B40713.FlatAppearance.BorderSize = 0;
		E9B40713.FlatStyle = FlatStyle.Flat;
		E9B40713.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E9B40713.ForeColor = Color.White;
		E9B40713.Location = new Point(247, 329);
		E9B40713.Name = "btnAdd";
		E9B40713.Size = new Size(92, 29);
		E9B40713.TabIndex = 6;
		E9B40713.Text = "Thêm";
		E9B40713.UseVisualStyleBackColor = false;
		E9B40713.Click += E9B40713_Click;
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
		bunifuCards1.Size = new Size(687, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(690, 375);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomTuKhoav2";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDThamGiaNhomTuKhoav2_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plTuongTac.ResumeLayout(performLayout: false);
		plTuongTac.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)BA32FC35).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
