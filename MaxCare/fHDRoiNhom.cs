using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDRoiNhom : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string E309761A;

	private string B828E58D;

	private int AD118A32;

	public static bool AF9F1289;

	private IContainer icontainer_0 = null;

	private BunifuDragControl D403D485;

	private BunifuDragControl C595BC8A;

	private Panel A029FB2B;

	private NumericUpDown C09A3B9F;

	private NumericUpDown nudSoLuongFrom;

	private TextBox BF9F6F30;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button B79350A7;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox AE82BDA6;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown A3B1CDB9;

	private NumericUpDown A4A92D0B;

	private Label D59E5BAF;

	private Label label6;

	private Label C33A2085;

	private Label label9;

	private Panel plUidChiDinh;

	private Label label10;

	private Label E5AAFE92;

	private Panel plDieuKienTuKhoa;

	private CheckBox C6042317;

	private CheckBox ckbDieuKienThanhVien;

	private NumericUpDown nudThanhVienToiDa;

	private RichTextBox txtIDNhomGiuLai;

	private Label lblIDNhomGiuLai;

	private Panel panel2;

	private Label lblIdNhomRoi;

	private Label label13;

	private CheckBox D5948DA9;

	private RichTextBox C4B7E207;

	private RichTextBox C29EDE86;

	private ComboBox cbbTypeRoiNhom;

	public fHDRoiNhom(string B0B48B88, int C32B029A = 0, string string_1 = "")
	{
		InitializeComponent();
		AF9F1289 = false;
		string_0 = B0B48B88;
		B828E58D = string_1;
		AD118A32 = C32B029A;
		string text = "";
		switch (C32B029A)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDRoiNhom");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			E309761A = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BF9F6F30.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_1);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			B79350A7.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			BF9F6F30.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(C33A2085);
		Language.smethod_0(D59E5BAF);
		Language.smethod_0(label6);
		Language.smethod_0(label9);
		Language.smethod_0(ckbDieuKienThanhVien);
		Language.smethod_0(C6042317);
		Language.smethod_0(E5AAFE92);
		Language.smethod_0(label10);
		Language.smethod_0(lblIDNhomGiuLai);
		Language.smethod_0(B79350A7);
		Language.smethod_0(btnCancel);
	}

	private void FF3A61A8_Load(object sender, EventArgs e)
	{
		D8151587();
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			C09A3B9F.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			A4A92D0B.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			A3B1CDB9.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			cbbTypeRoiNhom.SelectedIndex = gclass8_0.GetValueInt("typeRoiNhom");
			ckbDieuKienThanhVien.Checked = gclass8_0.GetValueBool("ckbDieuKienThanhVien");
			nudThanhVienToiDa.Value = gclass8_0.GetValueInt("nudThanhVienToiDa");
			C6042317.Checked = gclass8_0.GetValueBool("ckbDieuKienTuKhoa");
			C4B7E207.Text = gclass8_0.GetValue("txtTuKhoa");
			txtIDNhomGiuLai.Text = gclass8_0.GetValue("txtIDNhomGiuLai");
			D5948DA9.Checked = gclass8_0.GetValueBool("ckbDieuKienID");
			C29EDE86.Text = gclass8_0.GetValue("txtIdNhomRoi");
		}
		catch
		{
		}
		method_1();
	}

	private void D8151587()
	{
		List<string> e6A5AC = new List<string> { "Ngẫu nhiên danh sách nhóm", "Rời nhóm kiểm duyệt bài viết", "Rời nhóm theo điều kiện" };
		Common.F714B10E(cbbTypeRoiNhom, e6A5AC);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D409499D(object sender, EventArgs e)
	{
		string text = BF9F6F30.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (cbbTypeRoiNhom.SelectedIndex == 2)
		{
			if (!ckbDieuKienThanhVien.Checked && !C6042317.Checked && !D5948DA9.Checked)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n i\u0301t nhâ\u0301t mô\u0323t điê\u0300u kiê\u0323n rơ\u0300i nho\u0301m!", 3);
				return;
			}
			if (C6042317.Checked)
			{
				List<string> a2AB53A = C4B7E207.Lines.ToList();
				a2AB53A = Common.RemoveEmptyItems(a2AB53A);
				if (a2AB53A.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch tư\u0300 kho\u0301a!", 3);
					return;
				}
			}
			else if (D5948DA9.Checked)
			{
				List<string> a2AB53A2 = C29EDE86.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch nhóm cần rời!", 3);
					return;
				}
			}
		}
		gclass8_0.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gclass8_0.GetJson("nudSoLuongTo", C09A3B9F.Value);
		gclass8_0.GetJson("nudDelayFrom", A4A92D0B.Value);
		gclass8_0.GetJson("nudDelayTo", A3B1CDB9.Value);
		gclass8_0.GetJson("typeRoiNhom", cbbTypeRoiNhom.SelectedIndex);
		gclass8_0.GetJson("ckbDieuKienThanhVien", ckbDieuKienThanhVien.Checked);
		gclass8_0.GetJson("nudThanhVienToiDa", nudThanhVienToiDa.Value);
		gclass8_0.GetJson("ckbDieuKienTuKhoa", C6042317.Checked);
		gclass8_0.GetJson("txtTuKhoa", C4B7E207.Text.Trim());
		gclass8_0.GetJson("txtIDNhomGiuLai", txtIDNhomGiuLai.Text);
		gclass8_0.GetJson("ckbDieuKienID", D5948DA9.Checked);
		gclass8_0.GetJson("txtIdNhomRoi", C29EDE86.Text.Trim());
		string text2 = gclass8_0.D9A09B34();
		if (AD118A32 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, E309761A, text2))
				{
					AF9F1289 = true;
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
			if (InteractSQL.smethod_13(B828E58D, text, text2))
			{
				AF9F1289 = true;
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

	private void C815B83A(object sender, PaintEventArgs e)
	{
		if (A029FB2B.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A029FB2B.ClientSize.Width - num, A029FB2B.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		ckbDieuKienThanhVien_CheckedChanged(null, null);
		C6042317_CheckedChanged(null, null);
		method_2(null, null);
		CEA2E3A0(null, null);
	}

	private void ckbDieuKienThanhVien_CheckedChanged(object sender, EventArgs e)
	{
		nudThanhVienToiDa.Enabled = ckbDieuKienThanhVien.Checked;
	}

	private void C6042317_CheckedChanged(object sender, EventArgs e)
	{
		plDieuKienTuKhoa.Enabled = C6042317.Checked;
	}

	private void lblIDNhomGiuLai_Click(object sender, EventArgs e)
	{
	}

	private void txtIDNhomGiuLai_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtIDNhomGiuLai, lblIDNhomGiuLai);
	}

	private void method_2(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = C29EDE86.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblIdNhomRoi.Text = string.Format(Language.GetValue("Danh sách ID nhóm ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void CEA2E3A0(object sender, EventArgs e)
	{
		panel2.Enabled = D5948DA9.Checked;
	}

	private void C4B7E207_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(C4B7E207, E5AAFE92);
	}

	private void C29EDE86_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(C29EDE86, lblIdNhomRoi);
	}

	private void cbbTypeRoiNhom_SelectedIndexChanged(object sender, EventArgs e)
	{
		plUidChiDinh.Enabled = cbbTypeRoiNhom.SelectedIndex == 2;
	}

	protected override void Dispose(bool AF975AA8)
	{
		if (AF975AA8 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AF975AA8);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDRoiNhom));
		this.D403D485 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.C595BC8A = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.AE82BDA6 = new System.Windows.Forms.PictureBox();
		this.A029FB2B = new System.Windows.Forms.Panel();
		this.cbbTypeRoiNhom = new System.Windows.Forms.ComboBox();
		this.txtIDNhomGiuLai = new System.Windows.Forms.RichTextBox();
		this.lblIDNhomGiuLai = new System.Windows.Forms.Label();
		this.plUidChiDinh = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.C29EDE86 = new System.Windows.Forms.RichTextBox();
		this.lblIdNhomRoi = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.D5948DA9 = new System.Windows.Forms.CheckBox();
		this.plDieuKienTuKhoa = new System.Windows.Forms.Panel();
		this.C4B7E207 = new System.Windows.Forms.RichTextBox();
		this.E5AAFE92 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.C6042317 = new System.Windows.Forms.CheckBox();
		this.ckbDieuKienThanhVien = new System.Windows.Forms.CheckBox();
		this.nudThanhVienToiDa = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.A3B1CDB9 = new System.Windows.Forms.NumericUpDown();
		this.A4A92D0B = new System.Windows.Forms.NumericUpDown();
		this.D59E5BAF = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.C33A2085 = new System.Windows.Forms.Label();
		this.C09A3B9F = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.BF9F6F30 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.B79350A7 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AE82BDA6).BeginInit();
		this.A029FB2B.SuspendLayout();
		this.plUidChiDinh.SuspendLayout();
		this.panel2.SuspendLayout();
		this.plDieuKienTuKhoa.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThanhVienToiDa).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A3B1CDB9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A4A92D0B).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C09A3B9F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.D403D485.Fixed = true;
		this.D403D485.Horizontal = true;
		this.D403D485.TargetControl = this.bunifuCustomLabel1;
		this.D403D485.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(676, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Rơ\u0300i nho\u0301m";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C595BC8A.Fixed = true;
		this.C595BC8A.Horizontal = true;
		this.C595BC8A.TargetControl = this.pnlHeader;
		this.C595BC8A.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.AE82BDA6);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(676, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(645, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.AE82BDA6.Cursor = System.Windows.Forms.Cursors.Default;
		this.AE82BDA6.Image = Resources.Bitmap_4;
		this.AE82BDA6.Location = new System.Drawing.Point(3, 2);
		this.AE82BDA6.Name = "pictureBox1";
		this.AE82BDA6.Size = new System.Drawing.Size(34, 27);
		this.AE82BDA6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.AE82BDA6.TabIndex = 76;
		this.AE82BDA6.TabStop = false;
		this.A029FB2B.BackColor = System.Drawing.Color.White;
		this.A029FB2B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A029FB2B.Controls.Add(this.cbbTypeRoiNhom);
		this.A029FB2B.Controls.Add(this.txtIDNhomGiuLai);
		this.A029FB2B.Controls.Add(this.lblIDNhomGiuLai);
		this.A029FB2B.Controls.Add(this.plUidChiDinh);
		this.A029FB2B.Controls.Add(this.label9);
		this.A029FB2B.Controls.Add(this.A3B1CDB9);
		this.A029FB2B.Controls.Add(this.A4A92D0B);
		this.A029FB2B.Controls.Add(this.D59E5BAF);
		this.A029FB2B.Controls.Add(this.label6);
		this.A029FB2B.Controls.Add(this.C33A2085);
		this.A029FB2B.Controls.Add(this.C09A3B9F);
		this.A029FB2B.Controls.Add(this.nudSoLuongFrom);
		this.A029FB2B.Controls.Add(this.BF9F6F30);
		this.A029FB2B.Controls.Add(this.label3);
		this.A029FB2B.Controls.Add(this.label4);
		this.A029FB2B.Controls.Add(this.label2);
		this.A029FB2B.Controls.Add(this.label1);
		this.A029FB2B.Controls.Add(this.btnCancel);
		this.A029FB2B.Controls.Add(this.B79350A7);
		this.A029FB2B.Controls.Add(this.bunifuCards1);
		this.A029FB2B.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.A029FB2B.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A029FB2B.Location = new System.Drawing.Point(0, 0);
		this.A029FB2B.Name = "panel1";
		this.A029FB2B.Size = new System.Drawing.Size(679, 575);
		this.A029FB2B.TabIndex = 0;
		this.A029FB2B.Paint += new System.Windows.Forms.PaintEventHandler(C815B83A);
		this.cbbTypeRoiNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeRoiNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeRoiNhom.FormattingEnabled = true;
		this.cbbTypeRoiNhom.Location = new System.Drawing.Point(420, 79);
		this.cbbTypeRoiNhom.Name = "cbbTypeRoiNhom";
		this.cbbTypeRoiNhom.Size = new System.Drawing.Size(229, 24);
		this.cbbTypeRoiNhom.TabIndex = 121;
		this.cbbTypeRoiNhom.SelectedIndexChanged += new System.EventHandler(cbbTypeRoiNhom_SelectedIndexChanged);
		this.txtIDNhomGiuLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtIDNhomGiuLai.Location = new System.Drawing.Point(30, 158);
		this.txtIDNhomGiuLai.Name = "txtIDNhomGiuLai";
		this.txtIDNhomGiuLai.Size = new System.Drawing.Size(296, 361);
		this.txtIDNhomGiuLai.TabIndex = 120;
		this.txtIDNhomGiuLai.Text = "";
		this.txtIDNhomGiuLai.WordWrap = false;
		this.txtIDNhomGiuLai.TextChanged += new System.EventHandler(txtIDNhomGiuLai_TextChanged);
		this.lblIDNhomGiuLai.AutoSize = true;
		this.lblIDNhomGiuLai.Location = new System.Drawing.Point(27, 139);
		this.lblIDNhomGiuLai.Name = "lblIDNhomGiuLai";
		this.lblIDNhomGiuLai.Size = new System.Drawing.Size(207, 16);
		this.lblIDNhomGiuLai.TabIndex = 118;
		this.lblIDNhomGiuLai.Text = "Danh sách ID nhóm cần giữ lại (0):";
		this.lblIDNhomGiuLai.Click += new System.EventHandler(lblIDNhomGiuLai_Click);
		this.plUidChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plUidChiDinh.Controls.Add(this.panel2);
		this.plUidChiDinh.Controls.Add(this.D5948DA9);
		this.plUidChiDinh.Controls.Add(this.plDieuKienTuKhoa);
		this.plUidChiDinh.Controls.Add(this.C6042317);
		this.plUidChiDinh.Controls.Add(this.ckbDieuKienThanhVien);
		this.plUidChiDinh.Controls.Add(this.nudThanhVienToiDa);
		this.plUidChiDinh.Location = new System.Drawing.Point(354, 111);
		this.plUidChiDinh.Name = "plUidChiDinh";
		this.plUidChiDinh.Size = new System.Drawing.Size(295, 408);
		this.plUidChiDinh.TabIndex = 49;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.C29EDE86);
		this.panel2.Controls.Add(this.lblIdNhomRoi);
		this.panel2.Controls.Add(this.label13);
		this.panel2.Location = new System.Drawing.Point(20, 241);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(269, 160);
		this.panel2.TabIndex = 52;
		this.C29EDE86.Location = new System.Drawing.Point(6, 22);
		this.C29EDE86.Name = "txtIdNhomRoi";
		this.C29EDE86.Size = new System.Drawing.Size(258, 114);
		this.C29EDE86.TabIndex = 1;
		this.C29EDE86.Text = "";
		this.C29EDE86.WordWrap = false;
		this.C29EDE86.TextChanged += new System.EventHandler(C29EDE86_TextChanged);
		this.lblIdNhomRoi.AutoSize = true;
		this.lblIdNhomRoi.Location = new System.Drawing.Point(3, 3);
		this.lblIdNhomRoi.Name = "lblIdNhomRoi";
		this.lblIdNhomRoi.Size = new System.Drawing.Size(144, 16);
		this.lblIdNhomRoi.TabIndex = 0;
		this.lblIdNhomRoi.Text = "Danh sách ID nhóm (0):";
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(3, 138);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(132, 16);
		this.label13.TabIndex = 0;
		this.label13.Text = "(Mỗi ID nhóm 1 dòng)";
		this.D5948DA9.AutoSize = true;
		this.D5948DA9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D5948DA9.Location = new System.Drawing.Point(6, 218);
		this.D5948DA9.Name = "ckbDieuKienID";
		this.D5948DA9.Size = new System.Drawing.Size(125, 20);
		this.D5948DA9.TabIndex = 51;
		this.D5948DA9.Text = "Rời theo ID nhóm";
		this.D5948DA9.UseVisualStyleBackColor = true;
		this.D5948DA9.CheckedChanged += new System.EventHandler(CEA2E3A0);
		this.plDieuKienTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDieuKienTuKhoa.Controls.Add(this.C4B7E207);
		this.plDieuKienTuKhoa.Controls.Add(this.E5AAFE92);
		this.plDieuKienTuKhoa.Controls.Add(this.label10);
		this.plDieuKienTuKhoa.Location = new System.Drawing.Point(24, 55);
		this.plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
		this.plDieuKienTuKhoa.Size = new System.Drawing.Size(265, 160);
		this.plDieuKienTuKhoa.TabIndex = 50;
		this.C4B7E207.Location = new System.Drawing.Point(6, 22);
		this.C4B7E207.Name = "txtTuKhoa";
		this.C4B7E207.Size = new System.Drawing.Size(254, 114);
		this.C4B7E207.TabIndex = 1;
		this.C4B7E207.Text = "";
		this.C4B7E207.WordWrap = false;
		this.C4B7E207.TextChanged += new System.EventHandler(C4B7E207_TextChanged);
		this.E5AAFE92.AutoSize = true;
		this.E5AAFE92.Location = new System.Drawing.Point(3, 3);
		this.E5AAFE92.Name = "lblTuKhoa";
		this.E5AAFE92.Size = new System.Drawing.Size(139, 16);
		this.E5AAFE92.TabIndex = 0;
		this.E5AAFE92.Text = "Danh sách tư\u0300 kho\u0301a (0):";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(4, 139);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(127, 16);
		this.label10.TabIndex = 0;
		this.label10.Text = "(Mỗi tư\u0300 kho\u0301a 1 dòng)";
		this.C6042317.AutoSize = true;
		this.C6042317.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C6042317.Location = new System.Drawing.Point(6, 29);
		this.C6042317.Name = "ckbDieuKienTuKhoa";
		this.C6042317.Size = new System.Drawing.Size(209, 20);
		this.C6042317.TabIndex = 2;
		this.C6042317.Text = "Tên nho\u0301m co\u0301 chư\u0301a tư\u0300 kho\u0301a sau:";
		this.C6042317.UseVisualStyleBackColor = true;
		this.C6042317.CheckedChanged += new System.EventHandler(C6042317_CheckedChanged);
		this.ckbDieuKienThanhVien.AutoSize = true;
		this.ckbDieuKienThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDieuKienThanhVien.Location = new System.Drawing.Point(6, 3);
		this.ckbDieuKienThanhVien.Name = "ckbDieuKienThanhVien";
		this.ckbDieuKienThanhVien.Size = new System.Drawing.Size(181, 20);
		this.ckbDieuKienThanhVien.TabIndex = 2;
		this.ckbDieuKienThanhVien.Text = "Sô\u0301 lươ\u0323ng tha\u0300nh viên i\u0301t hơn:";
		this.ckbDieuKienThanhVien.UseVisualStyleBackColor = true;
		this.ckbDieuKienThanhVien.CheckedChanged += new System.EventHandler(ckbDieuKienThanhVien_CheckedChanged);
		this.nudThanhVienToiDa.Location = new System.Drawing.Point(197, 2);
		this.nudThanhVienToiDa.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		this.nudThanhVienToiDa.Name = "nudThanhVienToiDa";
		this.nudThanhVienToiDa.Size = new System.Drawing.Size(92, 23);
		this.nudThanhVienToiDa.TabIndex = 1;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(351, 82);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 47;
		this.label9.Text = "Tùy chọn:";
		this.A3B1CDB9.Location = new System.Drawing.Point(229, 107);
		this.A3B1CDB9.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A3B1CDB9.Name = "nudDelayTo";
		this.A3B1CDB9.Size = new System.Drawing.Size(56, 23);
		this.A3B1CDB9.TabIndex = 4;
		this.A4A92D0B.Location = new System.Drawing.Point(132, 107);
		this.A4A92D0B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A4A92D0B.Name = "nudDelayFrom";
		this.A4A92D0B.Size = new System.Drawing.Size(56, 23);
		this.A4A92D0B.TabIndex = 3;
		this.D59E5BAF.Location = new System.Drawing.Point(194, 109);
		this.D59E5BAF.Name = "label7";
		this.D59E5BAF.Size = new System.Drawing.Size(29, 16);
		this.D59E5BAF.TabIndex = 46;
		this.D59E5BAF.Text = "đê\u0301n";
		this.D59E5BAF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.C33A2085.AutoSize = true;
		this.C33A2085.Location = new System.Drawing.Point(27, 109);
		this.C33A2085.Name = "label5";
		this.C33A2085.Size = new System.Drawing.Size(89, 16);
		this.C33A2085.TabIndex = 44;
		this.C33A2085.Text = "Thơ\u0300i gian chơ\u0300:";
		this.C09A3B9F.Location = new System.Drawing.Point(229, 78);
		this.C09A3B9F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C09A3B9F.Name = "nudSoLuongTo";
		this.C09A3B9F.Size = new System.Drawing.Size(56, 23);
		this.C09A3B9F.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.BF9F6F30.Location = new System.Drawing.Point(132, 49);
		this.BF9F6F30.Name = "txtTenHanhDong";
		this.BF9F6F30.Size = new System.Drawing.Size(194, 23);
		this.BF9F6F30.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 80);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(39, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "nho\u0301m";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 80);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(99, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(347, 533);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.B79350A7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.B79350A7.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.B79350A7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B79350A7.FlatAppearance.BorderSize = 0;
		this.B79350A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B79350A7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B79350A7.ForeColor = System.Drawing.Color.White;
		this.B79350A7.Location = new System.Drawing.Point(242, 533);
		this.B79350A7.Name = "btnAdd";
		this.B79350A7.Size = new System.Drawing.Size(92, 29);
		this.B79350A7.TabIndex = 6;
		this.B79350A7.Text = "Thêm";
		this.B79350A7.UseVisualStyleBackColor = false;
		this.B79350A7.Click += new System.EventHandler(D409499D);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(676, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(679, 575);
		base.Controls.Add(this.A029FB2B);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDRoiNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FF3A61A8_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.AE82BDA6).EndInit();
		this.A029FB2B.ResumeLayout(false);
		this.A029FB2B.PerformLayout();
		this.plUidChiDinh.ResumeLayout(false);
		this.plUidChiDinh.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.plDieuKienTuKhoa.ResumeLayout(false);
		this.plDieuKienTuKhoa.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudThanhVienToiDa).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A3B1CDB9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A4A92D0B).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C09A3B9F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
