using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDHuyKetBan : Form
{
	private JSON_Settings gclass8_0;

	private string AD905CAF;

	private string string_0;

	private string string_1;

	private int CF03C40C;

	public static bool C41AFC20;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel E9839234;

	private NumericUpDown B136F02F;

	private NumericUpDown E9A608A9;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label C933601B;

	private Label D722C780;

	private Label label1;

	private Button D89F79A0;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel F3A9A314;

	private Button A12A4BBC;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown C035E089;

	private NumericUpDown F418953F;

	private Label label7;

	private Label label6;

	private Label C68616BC;

	private RichTextBox B135CC21;

	private Label B32E7936;

	private ComboBox D0926981;

	private Panel plDieuKienID;

	private RichTextBox txtUidHuyKetBan;

	private Label lblUidHuyKetBan;

	private Label A81ECE15;

	public fHDHuyKetBan(string string_2, int int_0 = 0, string E5808C39 = "")
	{
		InitializeComponent();
		C41AFC20 = false;
		AD905CAF = string_2;
		string_1 = E5808C39;
		CF03C40C = int_0;
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDHuyKetBan");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E5808C39);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void DC0F2B04_Load(object sender, EventArgs e)
	{
		C7808013();
		try
		{
			E9A608A9.Value = gclass8_0.GetValueInt("nudSoLuongFrom");
			B136F02F.Value = gclass8_0.GetValueInt("nudSoLuongTo");
			F418953F.Value = gclass8_0.GetValueInt("nudDelayFrom");
			C035E089.Value = gclass8_0.GetValueInt("nudDelayTo");
			D0926981.SelectedIndex = gclass8_0.GetValueInt("cbbTypeHuyKetBan");
			txtUidHuyKetBan.Text = gclass8_0.GetValue("txtUidHuyKetBan");
			B135CC21.Text = gclass8_0.GetValue("txtUidKhongHuyKetBan");
		}
		catch
		{
		}
	}

	private void C7808013()
	{
		List<string> e6A5AC = new List<string> { "Ngẫu nhiên danh sách bạn", "Hủy kết bạn với tài khoản tên ngoại", "Hủy kết bạn theo UID" };
		Common.F714B10E(D0926981, e6A5AC);
	}

	private void A12A4BBC_Click(object sender, EventArgs e)
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
		gClass.GetJson("nudSoLuongFrom", E9A608A9.Value);
		gClass.GetJson("nudSoLuongTo", B136F02F.Value);
		gClass.GetJson("nudDelayFrom", F418953F.Value);
		gClass.GetJson("nudDelayTo", C035E089.Value);
		gClass.GetJson("cbbTypeHuyKetBan", D0926981.SelectedIndex);
		gClass.GetJson("txtUidHuyKetBan", txtUidHuyKetBan.Text);
		gClass.GetJson("txtUidKhongHuyKetBan", B135CC21.Text);
		string string_ = gClass.D9A09B34();
		if (CF03C40C == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(AD905CAF, text, string_0, string_))
				{
					C41AFC20 = true;
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
				C41AFC20 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D89F79A0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F8B5B203(object sender, PaintEventArgs e)
	{
		if (E9839234.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E9839234.ClientSize.Width - num, E9839234.ClientSize.Height - num));
		}
	}

	private void CBB227BA(object sender, EventArgs e)
	{
	}

	private void C7ACA403(object sender, EventArgs e)
	{
	}

	private void B135CC21_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(B135CC21, B32E7936);
	}

	private void B32E7936_Click(object sender, EventArgs e)
	{
	}

	private void D0926981_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDieuKienID.Enabled = D0926981.SelectedIndex == 2;
	}

	private void txtUidHuyKetBan_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtUidHuyKetBan, lblUidHuyKetBan);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyKetBan));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.F3A9A314 = new System.Windows.Forms.Panel();
		this.A12A4BBC = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.E9839234 = new System.Windows.Forms.Panel();
		this.plDieuKienID = new System.Windows.Forms.Panel();
		this.txtUidHuyKetBan = new System.Windows.Forms.RichTextBox();
		this.lblUidHuyKetBan = new System.Windows.Forms.Label();
		this.D0926981 = new System.Windows.Forms.ComboBox();
		this.A81ECE15 = new System.Windows.Forms.Label();
		this.D722C780 = new System.Windows.Forms.Label();
		this.C933601B = new System.Windows.Forms.Label();
		this.B135CC21 = new System.Windows.Forms.RichTextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.E9A608A9 = new System.Windows.Forms.NumericUpDown();
		this.B136F02F = new System.Windows.Forms.NumericUpDown();
		this.C035E089 = new System.Windows.Forms.NumericUpDown();
		this.F418953F = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.B32E7936 = new System.Windows.Forms.Label();
		this.C68616BC = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.D89F79A0 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.F3A9A314.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.E9839234.SuspendLayout();
		this.plDieuKienID.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E9A608A9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B136F02F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C035E089).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F418953F).BeginInit();
		this.bunifuCards1.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(651, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.F3A9A314;
		this.bunifuDragControl_1.Vertical = true;
		this.F3A9A314.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.F3A9A314.BackColor = System.Drawing.Color.White;
		this.F3A9A314.Controls.Add(this.A12A4BBC);
		this.F3A9A314.Controls.Add(this.pictureBox1);
		this.F3A9A314.Controls.Add(this.bunifuCustomLabel1);
		this.F3A9A314.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.F3A9A314.Location = new System.Drawing.Point(0, 3);
		this.F3A9A314.Name = "pnlHeader";
		this.F3A9A314.Size = new System.Drawing.Size(651, 31);
		this.F3A9A314.TabIndex = 9;
		this.A12A4BBC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.A12A4BBC.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A12A4BBC.FlatAppearance.BorderSize = 0;
		this.A12A4BBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A12A4BBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A12A4BBC.ForeColor = System.Drawing.Color.White;
		this.A12A4BBC.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.A12A4BBC.Location = new System.Drawing.Point(620, 1);
		this.A12A4BBC.Name = "button1";
		this.A12A4BBC.Size = new System.Drawing.Size(30, 30);
		this.A12A4BBC.TabIndex = 77;
		this.A12A4BBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A12A4BBC.UseVisualStyleBackColor = true;
		this.A12A4BBC.Click += new System.EventHandler(A12A4BBC_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.E9839234.BackColor = System.Drawing.Color.White;
		this.E9839234.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.E9839234.Controls.Add(this.plDieuKienID);
		this.E9839234.Controls.Add(this.D0926981);
		this.E9839234.Controls.Add(this.A81ECE15);
		this.E9839234.Controls.Add(this.D722C780);
		this.E9839234.Controls.Add(this.C933601B);
		this.E9839234.Controls.Add(this.B135CC21);
		this.E9839234.Controls.Add(this.label3);
		this.E9839234.Controls.Add(this.E9A608A9);
		this.E9839234.Controls.Add(this.B136F02F);
		this.E9839234.Controls.Add(this.C035E089);
		this.E9839234.Controls.Add(this.F418953F);
		this.E9839234.Controls.Add(this.label7);
		this.E9839234.Controls.Add(this.label6);
		this.E9839234.Controls.Add(this.B32E7936);
		this.E9839234.Controls.Add(this.C68616BC);
		this.E9839234.Controls.Add(this.txtTenHanhDong);
		this.E9839234.Controls.Add(this.label1);
		this.E9839234.Controls.Add(this.D89F79A0);
		this.E9839234.Controls.Add(this.btnAdd);
		this.E9839234.Controls.Add(this.bunifuCards1);
		this.E9839234.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.E9839234.Dock = System.Windows.Forms.DockStyle.Fill;
		this.E9839234.Location = new System.Drawing.Point(0, 0);
		this.E9839234.Name = "panel1";
		this.E9839234.Size = new System.Drawing.Size(654, 425);
		this.E9839234.TabIndex = 0;
		this.E9839234.Paint += new System.Windows.Forms.PaintEventHandler(F8B5B203);
		this.plDieuKienID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDieuKienID.Controls.Add(this.txtUidHuyKetBan);
		this.plDieuKienID.Controls.Add(this.lblUidHuyKetBan);
		this.plDieuKienID.Location = new System.Drawing.Point(30, 170);
		this.plDieuKienID.Name = "plDieuKienID";
		this.plDieuKienID.Size = new System.Drawing.Size(295, 188);
		this.plDieuKienID.TabIndex = 52;
		this.txtUidHuyKetBan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtUidHuyKetBan.Location = new System.Drawing.Point(6, 22);
		this.txtUidHuyKetBan.Name = "txtUidHuyKetBan";
		this.txtUidHuyKetBan.Size = new System.Drawing.Size(284, 161);
		this.txtUidHuyKetBan.TabIndex = 1;
		this.txtUidHuyKetBan.Text = "";
		this.txtUidHuyKetBan.WordWrap = false;
		this.txtUidHuyKetBan.TextChanged += new System.EventHandler(txtUidHuyKetBan_TextChanged);
		this.lblUidHuyKetBan.AutoSize = true;
		this.lblUidHuyKetBan.Location = new System.Drawing.Point(3, 3);
		this.lblUidHuyKetBan.Name = "lblUidHuyKetBan";
		this.lblUidHuyKetBan.Size = new System.Drawing.Size(114, 16);
		this.lblUidHuyKetBan.TabIndex = 0;
		this.lblUidHuyKetBan.Text = "Danh sách Uid (0):";
		this.D0926981.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D0926981.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.D0926981.DropDownWidth = 220;
		this.D0926981.FormattingEnabled = true;
		this.D0926981.Location = new System.Drawing.Point(132, 140);
		this.D0926981.Name = "cbbTypeHuyKetBan";
		this.D0926981.Size = new System.Drawing.Size(193, 24);
		this.D0926981.TabIndex = 124;
		this.D0926981.SelectedIndexChanged += new System.EventHandler(D0926981_SelectedIndexChanged);
		this.A81ECE15.AutoSize = true;
		this.A81ECE15.Location = new System.Drawing.Point(27, 143);
		this.A81ECE15.Name = "label12";
		this.A81ECE15.Size = new System.Drawing.Size(64, 16);
		this.A81ECE15.TabIndex = 122;
		this.A81ECE15.Text = "Tùy chọn:";
		this.D722C780.AutoSize = true;
		this.D722C780.Location = new System.Drawing.Point(27, 80);
		this.D722C780.Name = "label2";
		this.D722C780.Size = new System.Drawing.Size(63, 16);
		this.D722C780.TabIndex = 32;
		this.D722C780.Text = "Sô\u0301 lươ\u0323ng:";
		this.C933601B.AutoSize = true;
		this.C933601B.Location = new System.Drawing.Point(284, 80);
		this.C933601B.Name = "label4";
		this.C933601B.Size = new System.Drawing.Size(28, 16);
		this.C933601B.TabIndex = 35;
		this.C933601B.Text = "ba\u0323n";
		this.B135CC21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.B135CC21.Location = new System.Drawing.Point(364, 101);
		this.B135CC21.Name = "txtUidKhongHuyKetBan";
		this.B135CC21.Size = new System.Drawing.Size(257, 257);
		this.B135CC21.TabIndex = 117;
		this.B135CC21.Text = "";
		this.B135CC21.WordWrap = false;
		this.B135CC21.TextChanged += new System.EventHandler(B135CC21_TextChanged);
		this.label3.Location = new System.Drawing.Point(192, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E9A608A9.Location = new System.Drawing.Point(132, 78);
		this.E9A608A9.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E9A608A9.Name = "nudSoLuongFrom";
		this.E9A608A9.Size = new System.Drawing.Size(56, 23);
		this.E9A608A9.TabIndex = 1;
		this.B136F02F.Location = new System.Drawing.Point(226, 78);
		this.B136F02F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B136F02F.Name = "nudSoLuongTo";
		this.B136F02F.Size = new System.Drawing.Size(56, 23);
		this.B136F02F.TabIndex = 2;
		this.C035E089.Location = new System.Drawing.Point(226, 107);
		this.C035E089.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C035E089.Name = "nudDelayTo";
		this.C035E089.Size = new System.Drawing.Size(56, 23);
		this.C035E089.TabIndex = 4;
		this.F418953F.Location = new System.Drawing.Point(132, 107);
		this.F418953F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F418953F.Name = "nudDelayFrom";
		this.F418953F.Size = new System.Drawing.Size(56, 23);
		this.F418953F.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(192, 109);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(285, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.B32E7936.AutoSize = true;
		this.B32E7936.Location = new System.Drawing.Point(361, 82);
		this.B32E7936.Name = "label10";
		this.B32E7936.Size = new System.Drawing.Size(222, 16);
		this.B32E7936.TabIndex = 44;
		this.B32E7936.Text = "Danh sách UID bạn bè cần giữ lại (0):";
		this.B32E7936.Click += new System.EventHandler(B32E7936_Click);
		this.C68616BC.AutoSize = true;
		this.C68616BC.Location = new System.Drawing.Point(27, 109);
		this.C68616BC.Name = "label5";
		this.C68616BC.Size = new System.Drawing.Size(89, 16);
		this.C68616BC.TabIndex = 44;
		this.C68616BC.Text = "Thơ\u0300i gian chơ\u0300:";
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.D89F79A0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D89F79A0.BackColor = System.Drawing.Color.Maroon;
		this.D89F79A0.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D89F79A0.FlatAppearance.BorderSize = 0;
		this.D89F79A0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D89F79A0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D89F79A0.ForeColor = System.Drawing.Color.White;
		this.D89F79A0.Location = new System.Drawing.Point(349, 378);
		this.D89F79A0.Name = "btnCancel";
		this.D89F79A0.Size = new System.Drawing.Size(92, 29);
		this.D89F79A0.TabIndex = 7;
		this.D89F79A0.Text = "Đóng";
		this.D89F79A0.UseVisualStyleBackColor = false;
		this.D89F79A0.Click += new System.EventHandler(D89F79A0_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(242, 378);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.F3A9A314);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(651, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(654, 425);
		base.Controls.Add(this.E9839234);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DC0F2B04_Load);
		this.F3A9A314.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.E9839234.ResumeLayout(false);
		this.E9839234.PerformLayout();
		this.plDieuKienID.ResumeLayout(false);
		this.plDieuKienID.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.E9A608A9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B136F02F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C035E089).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F418953F).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
