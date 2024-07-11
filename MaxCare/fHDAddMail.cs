using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDAddMail : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string EC1F6521;

	private int int_0;

	public static bool bool_0;

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards F49962A9;

	private Panel pnlHeader;

	private Button D6A4B282;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A1A6199F;

	private CheckBox FA077FB4;

	private ToolTip toolTip_0;

	private Panel plAddMail;

	private CheckBox ckbAddMail;

	private Panel plMatKhauMoi;

	private Label EF2C8711;

	private TextBox txtNewPass;

	private ComboBox B8082F10;

	private ComboBox cbbXoaMailCu;

	private ComboBox cbbAddMail;

	private Button F78DFC02;

	private Label label3;

	private Label label4;

	private CheckBox ckbAnMail;

	private Button FC0A4784;

	private NumericUpDown nudDelayOtp;

	private Label label5;

	public fHDAddMail(string DC38759F, int int_1 = 0, string string_2 = "")
	{
		F23ACB38();
		bool_0 = false;
		string_0 = DC38759F;
		EC1F6521 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Add mail";
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
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDAddMail_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
			B984E02A();
			ckbAddMail.Checked = gclass8_0.GetValueBool("ckbAddMail");
			cbbAddMail.SelectedValue = gclass8_0.GetValue("typeAddMail", "3");
			B8082F10.SelectedIndex = gclass8_0.GetValueInt("cbbTypeMail");
			list_0 = gclass8_0.GetValueList("lstHotmail");
			list_1 = gclass8_0.GetValueList("lstMailDomain");
			list_2 = gclass8_0.GetValueList("lstDomain");
			nudDelayOtp.Value = gclass8_0.GetValueInt("nudDelayOtp", 60);
			FA077FB4.Checked = gclass8_0.GetValueBool("ckbXoaMailCu");
			cbbXoaMailCu.SelectedValue = gclass8_0.GetValue("typeXoaMail", "0");
			txtNewPass.Text = gclass8_0.GetValue("txtNewPass");
			ckbAnMail.Checked = gclass8_0.GetValueBool("ckbAnMail");
			ckbAddMail_CheckedChanged(null, null);
			AAB56B1E(null, null);
			method_2();
			method_3();
		}
		catch
		{
		}
	}

	private void B984E02A()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Sử dụng m.fb");
		dictionary.Add("1", "Sử dụng link hacked");
		dictionary.Add("2", "Sử dụng www");
		dictionary.Add("3", "Sử dụng tut không pass");
		Common.F5A0B829(cbbXoaMailCu, dictionary);
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("3", "Sử dụng m.fb");
		dictionary.Add("1", "Sử dụng link hacked");
		dictionary.Add("4", "Sử dụng mbasic");
		dictionary.Add("0", "Sử dụng tut không pass");
		Common.F5A0B829(cbbAddMail, dictionary);
	}

	private void D6A4B282_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("ckbAddMail", ckbAddMail.Checked);
		gClass.GetJson("typeAddMail", cbbAddMail.SelectedValue);
		gClass.GetJson("cbbTypeMail", B8082F10.SelectedIndex);
		gClass.method_5("lstHotmail", list_0);
		gClass.method_5("lstMailDomain", list_1);
		gClass.method_5("lstDomain", list_2);
		gClass.GetJson("nudDelayOtp", nudDelayOtp.Value);
		gClass.GetJson("ckbXoaMailCu", FA077FB4.Checked);
		gClass.GetJson("typeXoaMail", cbbXoaMailCu.SelectedValue);
		gClass.GetJson("txtNewPass", txtNewPass.Text.Trim());
		gClass.GetJson("ckbAnMail", ckbAnMail.Checked);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
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
			if (InteractSQL.smethod_13(EC1F6521, text, string_))
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

	private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
	{
		plAddMail.Enabled = ckbAddMail.Checked;
		method_2();
	}

	private void AAB56B1E(object sender, EventArgs e)
	{
		cbbXoaMailCu.Enabled = FA077FB4.Checked;
		method_2();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void cbbXoaMailCu_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_2()
	{
		plMatKhauMoi.Enabled = (cbbAddMail.Enabled && cbbAddMail.Text.ToLower().Contains("hacked")) || (cbbXoaMailCu.Enabled && cbbXoaMailCu.Text.ToLower().Contains("hacked"));
	}

	private void B8082F10_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_3()
	{
		switch (B8082F10.SelectedIndex)
		{
		case 0:
			Common.BE3BB914(F78DFC02, list_0.Count);
			break;
		case 1:
			Common.BE3BB914(F78DFC02, list_1.Count);
			break;
		case 2:
			Common.BE3BB914(F78DFC02, list_2.Count);
			break;
		}
	}

	private void F78DFC02_Click(object sender, EventArgs e)
	{
		switch (B8082F10.SelectedIndex)
		{
		case 0:
		{
			fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch hotmail (mail|pass mail)", "Danh sa\u0301ch mail|pass mail", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.ShowForm(fNhapDuLieu3);
			list_0 = fNhapDuLieu3.C82C3629;
			Common.BE3BB914(F78DFC02, list_0.Count);
			break;
		}
		case 1:
		{
			fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch link mail domain", "Danh sa\u0301ch link mail domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.ShowForm(fNhapDuLieu3);
			list_1 = fNhapDuLieu3.C82C3629;
			Common.BE3BB914(F78DFC02, list_1.Count);
			break;
		}
		case 2:
		{
			fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_2, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.ShowForm(fNhapDuLieu3);
			list_2 = fNhapDuLieu3.C82C3629;
			Common.BE3BB914(F78DFC02, list_2.Count);
			break;
		}
		}
	}

	private void cbbAddMail_Click(object sender, EventArgs e)
	{
	}

	private void FC0A4784_Click(object sender, EventArgs e)
	{
		string object_ = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		MessageBoxHelper.Show(object_);
	}

	private void cbbAddMail_SelectionChangeCommitted(object sender, EventArgs e)
	{
		method_2();
	}

	private void panel1_ParentChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void F23ACB38()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDAddMail));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		A1A6199F = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		D6A4B282 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plAddMail = new Panel();
		nudDelayOtp = new NumericUpDown();
		cbbAddMail = new ComboBox();
		F78DFC02 = new Button();
		B8082F10 = new ComboBox();
		label3 = new Label();
		label5 = new Label();
		label4 = new Label();
		cbbXoaMailCu = new ComboBox();
		plMatKhauMoi = new Panel();
		FC0A4784 = new Button();
		EF2C8711 = new Label();
		txtNewPass = new TextBox();
		ckbAddMail = new CheckBox();
		ckbAnMail = new CheckBox();
		FA077FB4 = new CheckBox();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		F49962A9 = new BunifuCards();
		toolTip_0 = new ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plAddMail.SuspendLayout();
		((ISupportInitialize)nudDelayOtp).BeginInit();
		plMatKhauMoi.SuspendLayout();
		F49962A9.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = A1A6199F;
		bunifuDragControl_0.Vertical = true;
		A1A6199F.BackColor = Color.Transparent;
		A1A6199F.Cursor = Cursors.SizeAll;
		A1A6199F.Dock = DockStyle.Fill;
		A1A6199F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A1A6199F.ForeColor = Color.Black;
		A1A6199F.Location = new Point(0, 0);
		A1A6199F.Name = "bunifuCustomLabel1";
		A1A6199F.Size = new Size(356, 31);
		A1A6199F.TabIndex = 12;
		A1A6199F.Text = "Cấu hình Add Mail";
		A1A6199F.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D6A4B282);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(A1A6199F);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(356, 31);
		pnlHeader.TabIndex = 9;
		D6A4B282.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D6A4B282.Cursor = Cursors.Hand;
		D6A4B282.FlatAppearance.BorderSize = 0;
		D6A4B282.FlatStyle = FlatStyle.Flat;
		D6A4B282.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D6A4B282.ForeColor = Color.White;
		D6A4B282.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D6A4B282.Location = new Point(325, 1);
		D6A4B282.Name = "button1";
		D6A4B282.Size = new Size(30, 30);
		D6A4B282.TabIndex = 77;
		D6A4B282.TextImageRelation = TextImageRelation.ImageBeforeText;
		D6A4B282.UseVisualStyleBackColor = true;
		D6A4B282.Click += D6A4B282_Click;
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
		panel1.Controls.Add(plAddMail);
		panel1.Controls.Add(cbbXoaMailCu);
		panel1.Controls.Add(plMatKhauMoi);
		panel1.Controls.Add(ckbAddMail);
		panel1.Controls.Add(ckbAnMail);
		panel1.Controls.Add(FA077FB4);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(F49962A9);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(359, 343);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		panel1.ParentChanged += panel1_ParentChanged;
		plAddMail.BorderStyle = BorderStyle.FixedSingle;
		plAddMail.Controls.Add(nudDelayOtp);
		plAddMail.Controls.Add(cbbAddMail);
		plAddMail.Controls.Add(F78DFC02);
		plAddMail.Controls.Add(B8082F10);
		plAddMail.Controls.Add(label3);
		plAddMail.Controls.Add(label5);
		plAddMail.Controls.Add(label4);
		plAddMail.Location = new Point(23, 100);
		plAddMail.Name = "plAddMail";
		plAddMail.Size = new Size(311, 94);
		plAddMail.TabIndex = 115;
		nudDelayOtp.Location = new Point(101, 64);
		nudDelayOtp.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		nudDelayOtp.Name = "nudDelayOtp";
		nudDelayOtp.Size = new Size(68, 23);
		nudDelayOtp.TabIndex = 118;
		cbbAddMail.Cursor = Cursors.Hand;
		cbbAddMail.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbAddMail.FormattingEnabled = true;
		cbbAddMail.Location = new Point(101, 4);
		cbbAddMail.Name = "cbbAddMail";
		cbbAddMail.Size = new Size(205, 24);
		cbbAddMail.TabIndex = 116;
		cbbAddMail.SelectionChangeCommitted += cbbAddMail_SelectionChangeCommitted;
		cbbAddMail.Click += cbbAddMail_Click;
		F78DFC02.Cursor = Cursors.Hand;
		F78DFC02.Location = new Point(220, 33);
		F78DFC02.Name = "btnNhapMail";
		F78DFC02.Size = new Size(86, 26);
		F78DFC02.TabIndex = 117;
		F78DFC02.Text = "Nhập (0)";
		F78DFC02.UseVisualStyleBackColor = true;
		F78DFC02.Click += F78DFC02_Click;
		B8082F10.Cursor = Cursors.Hand;
		B8082F10.DropDownStyle = ComboBoxStyle.DropDownList;
		B8082F10.DropDownWidth = 200;
		B8082F10.FormattingEnabled = true;
		B8082F10.Items.AddRange(new object[3] { "Hotmail", "Mail domain", "https://generator.email/" });
		B8082F10.Location = new Point(101, 34);
		B8082F10.Name = "cbbTypeMail";
		B8082F10.Size = new Size(113, 24);
		B8082F10.TabIndex = 116;
		B8082F10.SelectedIndexChanged += B8082F10_SelectedIndexChanged;
		label3.AutoSize = true;
		label3.Location = new Point(1, 7);
		label3.Name = "label3";
		label3.Size = new Size(64, 16);
		label3.TabIndex = 31;
		label3.Text = "Tùy chọn:";
		label5.AutoSize = true;
		label5.Location = new Point(1, 66);
		label5.Name = "label5";
		label5.Size = new Size(96, 16);
		label5.TabIndex = 31;
		label5.Text = "Chờ lấy otp (s):";
		label4.AutoSize = true;
		label4.Location = new Point(1, 37);
		label4.Name = "label4";
		label4.Size = new Size(63, 16);
		label4.TabIndex = 31;
		label4.Text = "Loại mail:";
		cbbXoaMailCu.Cursor = Cursors.Hand;
		cbbXoaMailCu.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbXoaMailCu.FormattingEnabled = true;
		cbbXoaMailCu.Location = new Point(125, 200);
		cbbXoaMailCu.Name = "cbbXoaMailCu";
		cbbXoaMailCu.Size = new Size(209, 24);
		cbbXoaMailCu.TabIndex = 116;
		cbbXoaMailCu.SelectedIndexChanged += cbbXoaMailCu_SelectedIndexChanged;
		plMatKhauMoi.BorderStyle = BorderStyle.FixedSingle;
		plMatKhauMoi.Controls.Add(FC0A4784);
		plMatKhauMoi.Controls.Add(EF2C8711);
		plMatKhauMoi.Controls.Add(txtNewPass);
		plMatKhauMoi.Location = new Point(23, 230);
		plMatKhauMoi.Name = "plMatKhauMoi";
		plMatKhauMoi.Size = new Size(311, 31);
		plMatKhauMoi.TabIndex = 115;
		FC0A4784.Cursor = Cursors.Help;
		FC0A4784.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		FC0A4784.Location = new Point(282, 3);
		FC0A4784.Name = "button2";
		FC0A4784.Size = new Size(24, 24);
		FC0A4784.TabIndex = 151;
		FC0A4784.Text = "?";
		FC0A4784.UseVisualStyleBackColor = true;
		FC0A4784.Click += FC0A4784_Click;
		EF2C8711.AutoSize = true;
		EF2C8711.Location = new Point(2, 6);
		EF2C8711.Name = "label2";
		EF2C8711.Size = new Size(89, 16);
		EF2C8711.TabIndex = 31;
		EF2C8711.Text = "Mật khẩu mới:";
		txtNewPass.Location = new Point(101, 3);
		txtNewPass.Name = "txtNewPass";
		txtNewPass.Size = new Size(178, 23);
		txtNewPass.TabIndex = 0;
		ckbAddMail.AutoSize = true;
		ckbAddMail.Cursor = Cursors.Hand;
		ckbAddMail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbAddMail.Location = new Point(23, 78);
		ckbAddMail.Name = "ckbAddMail";
		ckbAddMail.Size = new Size(75, 20);
		ckbAddMail.TabIndex = 113;
		ckbAddMail.Text = "Add Mail";
		ckbAddMail.UseVisualStyleBackColor = true;
		ckbAddMail.CheckedChanged += ckbAddMail_CheckedChanged;
		ckbAnMail.AutoSize = true;
		ckbAnMail.Cursor = Cursors.Hand;
		ckbAnMail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbAnMail.Location = new Point(23, 267);
		ckbAnMail.Name = "ckbAnMail";
		ckbAnMail.Size = new Size(69, 20);
		ckbAnMail.TabIndex = 113;
		ckbAnMail.Text = "Ẩn mail";
		ckbAnMail.UseVisualStyleBackColor = true;
		FA077FB4.AutoSize = true;
		FA077FB4.Cursor = Cursors.Hand;
		FA077FB4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FA077FB4.Location = new Point(23, 202);
		FA077FB4.Name = "ckbXoaMailCu";
		FA077FB4.Size = new Size(76, 20);
		FA077FB4.TabIndex = 113;
		FA077FB4.Text = "Xóa mail";
		FA077FB4.UseVisualStyleBackColor = true;
		FA077FB4.CheckedChanged += AAB56B1E;
		txtTenHanhDong.Location = new Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(209, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(20, 52);
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
		btnCancel.Location = new Point(189, 300);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 300);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		F49962A9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F49962A9.BackColor = Color.White;
		F49962A9.BorderRadius = 0;
		F49962A9.BottomSahddow = true;
		F49962A9.color = Color.DarkViolet;
		F49962A9.Controls.Add(pnlHeader);
		F49962A9.LeftSahddow = false;
		F49962A9.Location = new Point(1, 0);
		F49962A9.Name = "bunifuCards1";
		F49962A9.RightSahddow = true;
		F49962A9.ShadowDepth = 20;
		F49962A9.Size = new Size(356, 37);
		F49962A9.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(359, 343);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDAddMail";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDAddMail_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plAddMail.ResumeLayout(performLayout: false);
		plAddMail.PerformLayout();
		((ISupportInitialize)nudDelayOtp).EndInit();
		plMatKhauMoi.ResumeLayout(performLayout: false);
		plMatKhauMoi.PerformLayout();
		F49962A9.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
