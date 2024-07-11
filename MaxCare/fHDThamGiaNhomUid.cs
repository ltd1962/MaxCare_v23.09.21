using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDThamGiaNhomUid : Form
{
	private JSON_Settings BF310F2F;

	private string string_0;

	private string string_1;

	private string string_2;

	private int E18F7339;

	public static bool B90547A7;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown D8091219;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label FF0191BF;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B615872E;

	private Panel F1888793;

	private Button B6AC3004;

	private PictureBox F70535BB;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label lblStatus;

	private NumericUpDown EA2767B1;

	private NumericUpDown E7304BB4;

	private Label label7;

	private Label E889F083;

	private Label label5;

	private RichTextBox txtUid;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip D41BEBB4;

	private Panel FB801B0D;

	private CheckBox ckbTuDongTraLoiCauHoi;

	private Label D6B0C305;

	private RichTextBox F025ACBD;

	private Label label8;

	private ComboBox B3B1D20D;

	public fHDThamGiaNhomUid(string string_3, int int_0 = 0, string C700AC06 = "")
	{
		FC032D20();
		B90547A7 = false;
		string_0 = string_3;
		string_2 = C700AC06;
		E18F7339 = int_0;
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDThamGiaNhomUid");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(C700AC06);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = "Câ\u0323p nhâ\u0323t";
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		BF310F2F = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void F43A9F90(object sender, EventArgs e)
	{
		method_2();
		try
		{
			D8091219.Value = BF310F2F.GetValueInt("nudSoLuongFrom");
			nudSoLuongTo.Value = BF310F2F.GetValueInt("nudSoLuongTo");
			E7304BB4.Value = BF310F2F.GetValueInt("nudDelayFrom");
			EA2767B1.Value = BF310F2F.GetValueInt("nudDelayTo");
			txtUid.Text = BF310F2F.GetValue("txtUid");
			ckbTuDongTraLoiCauHoi.Checked = BF310F2F.GetValueBool("ckbTuDongTraLoiCauHoi");
			ckbTuDongXoaUid.Checked = BF310F2F.GetValueBool("ckbTuDongXoaUid");
			F025ACBD.Text = BF310F2F.GetValue("txtCauTraLoi");
			B3B1D20D.SelectedIndex = BF310F2F.GetValueInt("cbbCauTraLoi");
		}
		catch
		{
		}
		method_0();
	}

	private void method_0()
	{
		ckbTuDongTraLoiCauHoi_CheckedChanged(null, null);
	}

	private void B6AC3004_Click(object sender, EventArgs e)
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
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
		{
			a2AB53A = F025ACBD.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", D8091219.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", E7304BB4.Value);
		gClass.GetJson("nudDelayTo", EA2767B1.Value);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.GetJson("txtCauTraLoi", F025ACBD.Text.Trim());
		gClass.GetJson("cbbCauTraLoi", B3B1D20D.SelectedIndex);
		string string_ = gClass.D9A09B34();
		if (E18F7339 == 0)
		{
			if (MessageBox.Show("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?", "Thông ba\u0301o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					B90547A7 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBox.Show("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?", "Thông ba\u0301o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_2, text, string_))
			{
				B90547A7 = true;
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

	private void method_1(object sender, EventArgs e)
	{
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = "Danh sa\u0301ch Uid nhóm cần tham gia (" + a2AB53A.Count + "):";
		}
		catch
		{
		}
	}

	private void ckbTuDongTraLoiCauHoi_CheckedChanged(object sender, EventArgs e)
	{
		FB801B0D.Enabled = ckbTuDongTraLoiCauHoi.Checked;
	}

	private void E733CF2F(object sender, EventArgs e)
	{
	}

	private void F025ACBD_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(F025ACBD, D6B0C305);
	}

	private void method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Random câu trả lời");
		dictionary.Add("1", "Trả lời theo thứ tự");
		Common.F5A0B829(B3B1D20D, dictionary);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void FC032D20()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDThamGiaNhomUid));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		F1888793 = new Panel();
		B6AC3004 = new Button();
		F70535BB = new PictureBox();
		panel1 = new Panel();
		FB801B0D = new Panel();
		B3B1D20D = new ComboBox();
		label8 = new Label();
		F025ACBD = new RichTextBox();
		D6B0C305 = new Label();
		ckbTuDongTraLoiCauHoi = new CheckBox();
		txtUid = new RichTextBox();
		ckbTuDongXoaUid = new CheckBox();
		EA2767B1 = new NumericUpDown();
		lblStatus = new Label();
		E7304BB4 = new NumericUpDown();
		label7 = new Label();
		E889F083 = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		D8091219 = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		label4 = new Label();
		FF0191BF = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		B615872E = new BunifuCards();
		D41BEBB4 = new ToolTip(icontainer_0);
		F1888793.SuspendLayout();
		((ISupportInitialize)F70535BB).BeginInit();
		panel1.SuspendLayout();
		FB801B0D.SuspendLayout();
		((ISupportInitialize)EA2767B1).BeginInit();
		((ISupportInitialize)E7304BB4).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)D8091219).BeginInit();
		B615872E.SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(687, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tham gia nhóm theo tệp UID";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = F1888793;
		bunifuDragControl_1.Vertical = true;
		F1888793.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F1888793.BackColor = Color.White;
		F1888793.Controls.Add(B6AC3004);
		F1888793.Controls.Add(F70535BB);
		F1888793.Controls.Add(bunifuCustomLabel1);
		F1888793.Cursor = Cursors.SizeAll;
		F1888793.Location = new Point(0, 3);
		F1888793.Name = "pnlHeader";
		F1888793.Size = new Size(687, 31);
		F1888793.TabIndex = 9;
		B6AC3004.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B6AC3004.Cursor = Cursors.Hand;
		B6AC3004.FlatAppearance.BorderSize = 0;
		B6AC3004.FlatStyle = FlatStyle.Flat;
		B6AC3004.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B6AC3004.ForeColor = Color.White;
		B6AC3004.Image = (Image)componentResourceManager.GetObject("button1.Image");
		B6AC3004.Location = new Point(656, 1);
		B6AC3004.Name = "button1";
		B6AC3004.Size = new Size(30, 30);
		B6AC3004.TabIndex = 77;
		B6AC3004.TextImageRelation = TextImageRelation.ImageBeforeText;
		B6AC3004.UseVisualStyleBackColor = true;
		B6AC3004.Click += B6AC3004_Click;
		F70535BB.Cursor = Cursors.Default;
		F70535BB.Image = Resources.Bitmap_4;
		F70535BB.Location = new Point(3, 2);
		F70535BB.Name = "pictureBox1";
		F70535BB.Size = new Size(34, 27);
		F70535BB.SizeMode = PictureBoxSizeMode.Zoom;
		F70535BB.TabIndex = 76;
		F70535BB.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(FB801B0D);
		panel1.Controls.Add(ckbTuDongTraLoiCauHoi);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(ckbTuDongXoaUid);
		panel1.Controls.Add(EA2767B1);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(E7304BB4);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(E889F083);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(D8091219);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(FF0191BF);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B615872E);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(690, 404);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		FB801B0D.BorderStyle = BorderStyle.FixedSingle;
		FB801B0D.Controls.Add(B3B1D20D);
		FB801B0D.Controls.Add(label8);
		FB801B0D.Controls.Add(F025ACBD);
		FB801B0D.Controls.Add(D6B0C305);
		FB801B0D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FB801B0D.Location = new Point(48, 162);
		FB801B0D.Name = "plTuongTac";
		FB801B0D.Size = new Size(278, 179);
		FB801B0D.TabIndex = 116;
		B3B1D20D.Cursor = Cursors.Hand;
		B3B1D20D.DropDownStyle = ComboBoxStyle.DropDownList;
		B3B1D20D.FormattingEnabled = true;
		B3B1D20D.Location = new Point(73, 149);
		B3B1D20D.Name = "cbbCauTraLoi";
		B3B1D20D.Size = new Size(198, 24);
		B3B1D20D.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new Point(3, 152);
		label8.Name = "label8";
		label8.Size = new Size(64, 16);
		label8.TabIndex = 3;
		label8.Text = "Tùy chọn:";
		F025ACBD.Location = new Point(6, 22);
		F025ACBD.Name = "txtCauTraLoi";
		F025ACBD.Size = new Size(267, 122);
		F025ACBD.TabIndex = 2;
		F025ACBD.Text = "";
		F025ACBD.TextChanged += F025ACBD_TextChanged;
		D6B0C305.AutoSize = true;
		D6B0C305.Location = new Point(3, 3);
		D6B0C305.Name = "lblCauTraLoi";
		D6B0C305.Size = new Size(153, 16);
		D6B0C305.TabIndex = 0;
		D6B0C305.Text = "Danh sách câu trả lời (0):";
		ckbTuDongTraLoiCauHoi.AutoSize = true;
		ckbTuDongTraLoiCauHoi.Cursor = Cursors.Hand;
		ckbTuDongTraLoiCauHoi.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuDongTraLoiCauHoi.Location = new Point(30, 139);
		ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		ckbTuDongTraLoiCauHoi.Size = new Size(156, 20);
		ckbTuDongTraLoiCauHoi.TabIndex = 115;
		ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		ckbTuDongTraLoiCauHoi.CheckedChanged += ckbTuDongTraLoiCauHoi_CheckedChanged;
		txtUid.BorderStyle = BorderStyle.FixedSingle;
		txtUid.Location = new Point(356, 72);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(295, 246);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += txtUid_TextChanged;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = Cursors.Hand;
		ckbTuDongXoaUid.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new Point(355, 324);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new Size(298, 20);
		ckbTuDongXoaUid.TabIndex = 113;
		ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid nho\u0301m đa\u0303 gư\u0309i yêu câ\u0300u tham gia";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		EA2767B1.Location = new Point(229, 111);
		EA2767B1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EA2767B1.Name = "nudDelayTo";
		EA2767B1.Size = new Size(56, 23);
		EA2767B1.TabIndex = 4;
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(352, 52);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(228, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Uid nhóm cần tham gia (0):";
		lblStatus.Click += E733CF2F;
		E7304BB4.Location = new Point(132, 111);
		E7304BB4.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E7304BB4.Name = "nudDelayFrom";
		E7304BB4.Size = new Size(56, 23);
		E7304BB4.TabIndex = 3;
		label7.AutoSize = true;
		label7.Location = new Point(194, 113);
		label7.Name = "label7";
		label7.Size = new Size(28, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		E889F083.AutoSize = true;
		E889F083.Location = new Point(290, 113);
		E889F083.Name = "label6";
		E889F083.Size = new Size(30, 16);
		E889F083.TabIndex = 45;
		E889F083.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 113);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		D8091219.Location = new Point(132, 80);
		D8091219.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D8091219.Name = "nudSoLuongFrom";
		D8091219.Size = new Size(56, 23);
		D8091219.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new Point(194, 82);
		label3.Name = "label3";
		label3.Size = new Size(28, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new Point(290, 82);
		label4.Name = "label4";
		label4.Size = new Size(39, 16);
		label4.TabIndex = 35;
		label4.Text = "nhóm";
		FF0191BF.AutoSize = true;
		FF0191BF.Location = new Point(27, 82);
		FF0191BF.Name = "label2";
		FF0191BF.Size = new Size(63, 16);
		FF0191BF.TabIndex = 32;
		FF0191BF.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
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
		btnCancel.Location = new Point(355, 361);
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
		btnAdd.Location = new Point(248, 361);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		B615872E.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B615872E.BackColor = Color.White;
		B615872E.BorderRadius = 0;
		B615872E.BottomSahddow = true;
		B615872E.color = Color.DarkViolet;
		B615872E.Controls.Add(F1888793);
		B615872E.LeftSahddow = false;
		B615872E.Location = new Point(1, 0);
		B615872E.Name = "bunifuCards1";
		B615872E.RightSahddow = true;
		B615872E.ShadowDepth = 20;
		B615872E.Size = new Size(687, 37);
		B615872E.TabIndex = 28;
		D41BEBB4.AutomaticDelay = 0;
		D41BEBB4.AutoPopDelay = 0;
		D41BEBB4.InitialDelay = 0;
		D41BEBB4.ReshowDelay = 0;
		D41BEBB4.ShowAlways = true;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(690, 404);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomUid";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += F43A9F90;
		F1888793.ResumeLayout(performLayout: false);
		((ISupportInitialize)F70535BB).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		FB801B0D.ResumeLayout(performLayout: false);
		FB801B0D.PerformLayout();
		((ISupportInitialize)EA2767B1).EndInit();
		((ISupportInitialize)E7304BB4).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)D8091219).EndInit();
		B615872E.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
