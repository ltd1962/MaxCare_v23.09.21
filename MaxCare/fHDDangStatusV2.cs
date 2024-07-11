using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangStatusV2 : Form
{
	private JSON_Settings A40932B8;

	private string F7012C16;

	private string B90B879F;

	private string string_0;

	private int int_0;

	public static bool CBB17307;

	private IContainer EB214B1D = null;

	private BunifuDragControl BE908593;

	private BunifuDragControl CB9B9387;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label D7AA1429;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards A91AC686;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox B10FAA1C;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox D193D10F;

	private CheckBox ckbVanBan;

	private Panel CD010706;

	private Label label8;

	private Label D80072A0;

	private Panel plAnh;

	private TextBox txtPathAnh;

	private Label label3;

	private RichTextBox txtNoiDung;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private Button DF9A04A0;

	private Button btnUp;

	private Panel plTag;

	private Label label10;

	private CheckBox ckbTag;

	private NumericUpDown B5A83DA2;

	private NumericUpDown DBBAA19B;

	private Label label19;

	private Label label20;

	private NumericUpDown nudKhoangCachTo;

	private NumericUpDown nudKhoangCachFrom;

	private Label label18;

	private Label label17;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label16;

	private Label F9A156A2;

	private NumericUpDown AE8D5526;

	private NumericUpDown nudSoLuongAnhFrom;

	private Label FC8C70A6;

	private Label A9258F94;

	private CheckBox E0A67B14;

	private CheckBox ckbDangAnhTheoThuTu;

	private Label label4;

	private Label F5B8749C;

	private NumericUpDown FDBBE335;

	private NumericUpDown nudDelayTagFrom;

	private Label ED351E97;

	public fHDDangStatusV2(string string_1, int F496BD8C = 0, string CDACD7BB = "")
	{
		InitializeComponent();
		CBB17307 = false;
		F7012C16 = string_1;
		string_0 = CDACD7BB;
		int_0 = F496BD8C;
		string text = "HDDangStatusV2";
		string text2 = "Đăng status v2";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (F496BD8C)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			B90B879F = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(CDACD7BB);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A40932B8 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(D7AA1429);
		Language.smethod_0(F9A156A2);
		Language.smethod_0(label17);
		Language.smethod_0(label18);
		Language.smethod_0(label16);
		Language.smethod_0(label20);
		Language.smethod_0(label19);
		Language.smethod_0(ckbVanBan);
		Language.smethod_0(D80072A0);
		Language.smethod_0(label8);
		Language.smethod_0(D193D10F);
		Language.smethod_0(label3);
		Language.smethod_0(A9258F94);
		Language.smethod_0(FC8C70A6);
		Language.smethod_0(label4);
		Language.smethod_0(ckbTag);
		Language.smethod_0(label10);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void CE01EC8D_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = A40932B8.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = A40932B8.GetValueInt("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = A40932B8.GetValueInt("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = A40932B8.GetValueInt("nudKhoangCachTo", 10);
			ckbVanBan.Checked = A40932B8.GetValueBool("ckbVanBan");
			txtNoiDung.Text = A40932B8.GetValue("txtNoiDung");
			D193D10F.Checked = A40932B8.GetValueBool("ckbAnh");
			ckbDangAnhTheoThuTu.Checked = A40932B8.GetValueBool("ckbDangAnhTheoThuTu");
			nudSoLuongAnhFrom.Value = A40932B8.GetValueInt("nudSoLuongAnhFrom", 1);
			AE8D5526.Value = A40932B8.GetValueInt("nudSoLuongAnhTo", 1);
			txtPathAnh.Text = A40932B8.GetValue("txtPathAnh");
			if (A40932B8.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbTag.Checked = A40932B8.GetValueBool("ckbTag");
			DBBAA19B.Value = A40932B8.GetValueInt("nudUidFrom", 1);
			B5A83DA2.Value = A40932B8.GetValueInt("nudUidTo", 1);
			E0A67B14.Checked = A40932B8.GetValueBool("ckbOnlyTagVNName");
			nudDelayTagFrom.Value = A40932B8.GetValueInt("nudDelayTagFrom");
			FDBBE335.Value = A40932B8.GetValueInt("nudDelayTagTo");
		}
		catch (Exception)
		{
		}
		E202BF8E();
	}

	private void B131288C(object sender, EventArgs e)
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
		if (D193D10F.Checked && !Directory.Exists(txtPathAnh.Text.Trim()))
		{
			MessageBoxHelper.Show("Đường dẫn ảnh không tồn tại!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		gClass.GetJson("nudKhoangCachTo", nudKhoangCachTo.Value);
		gClass.GetJson("ckbVanBan", ckbVanBan.Checked);
		gClass.GetJson("ckbAnh", D193D10F.Checked);
		gClass.GetJson("ckbDangAnhTheoThuTu", ckbDangAnhTheoThuTu.Checked);
		gClass.GetJson("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.GetJson("nudSoLuongAnhTo", AE8D5526.Value);
		gClass.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.GetJson("txtPathAnh", txtPathAnh.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		gClass.GetJson("ckbTag", ckbTag.Checked);
		gClass.GetJson("nudUidFrom", DBBAA19B.Value);
		gClass.GetJson("nudUidTo", B5A83DA2.Value);
		gClass.GetJson("ckbOnlyTagVNName", E0A67B14.Checked);
		gClass.GetJson("nudDelayTagFrom", nudDelayTagFrom.Value);
		gClass.GetJson("nudDelayTagTo", FDBBE335.Value);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(F7012C16, text, B90B879F, text2))
				{
					CBB17307 = true;
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
				CBB17307 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void A436E685(object sender, EventArgs e)
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

	private void E202BF8E()
	{
		ckbVanBan_CheckedChanged(null, null);
		D193D10F_CheckedChanged(null, null);
		ckbTag_CheckedChanged(null, null);
		B79693BC(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		CD010706.Enabled = ckbVanBan.Checked;
	}

	private void D193D10F_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = D193D10F.Checked;
	}

	private void F31DF324(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			D80072A0.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void B10FAA1C_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			DF9A04A0.Visible = true;
		}
	}

	private void DF9A04A0_Click(object sender, EventArgs e)
	{
		CD010706.Height = 235;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		CD010706.Height = 187;
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void ACA50B03(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbTag_CheckedChanged(object sender, EventArgs e)
	{
		plTag.Enabled = ckbTag.Checked;
	}

	private void B79693BC(object sender, EventArgs e)
	{
	}

	private void txtPathAnh_TextChanged(object sender, EventArgs e)
	{
	}

	private void E12DAB9B(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	protected override void Dispose(bool A11C6B8F)
	{
		if (A11C6B8F && EB214B1D != null)
		{
			EB214B1D.Dispose();
		}
		base.Dispose(A11C6B8F);
	}

	private void InitializeComponent()
	{
		this.EB214B1D = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangStatusV2));
		this.BE908593 = new Bunifu.Framework.UI.BunifuDragControl(this.EB214B1D);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.CB9B9387 = new Bunifu.Framework.UI.BunifuDragControl(this.EB214B1D);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.B10FAA1C = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.label19 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
		this.nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.F9A156A2 = new System.Windows.Forms.Label();
		this.plTag = new System.Windows.Forms.Panel();
		this.F5B8749C = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.FDBBE335 = new System.Windows.Forms.NumericUpDown();
		this.B5A83DA2 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTagFrom = new System.Windows.Forms.NumericUpDown();
		this.DBBAA19B = new System.Windows.Forms.NumericUpDown();
		this.ED351E97 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.E0A67B14 = new System.Windows.Forms.CheckBox();
		this.CD010706 = new System.Windows.Forms.Panel();
		this.DF9A04A0 = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.D80072A0 = new System.Windows.Forms.Label();
		this.btnAdd = new System.Windows.Forms.Button();
		this.plAnh = new System.Windows.Forms.Panel();
		this.AE8D5526 = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		this.FC8C70A6 = new System.Windows.Forms.Label();
		this.A9258F94 = new System.Windows.Forms.Label();
		this.txtPathAnh = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbDangAnhTheoThuTu = new System.Windows.Forms.CheckBox();
		this.ckbTag = new System.Windows.Forms.CheckBox();
		this.D193D10F = new System.Windows.Forms.CheckBox();
		this.ckbVanBan = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.D7AA1429 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.A91AC686 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B10FAA1C).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.plTag.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.FDBBE335).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B5A83DA2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTagFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DBBAA19B).BeginInit();
		this.CD010706.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AE8D5526).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).BeginInit();
		this.A91AC686.SuspendLayout();
		base.SuspendLayout();
		this.BE908593.Fixed = true;
		this.BE908593.Horizontal = true;
		this.BE908593.TargetControl = this.bunifuCustomLabel1;
		this.BE908593.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(678, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Đăng status";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CB9B9387.Fixed = true;
		this.CB9B9387.Horizontal = true;
		this.CB9B9387.TargetControl = this.pnlHeader;
		this.CB9B9387.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.B10FAA1C);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(678, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(647, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 0;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(B131288C);
		this.B10FAA1C.Cursor = System.Windows.Forms.Cursors.Default;
		this.B10FAA1C.Image = Resources.Bitmap_4;
		this.B10FAA1C.Location = new System.Drawing.Point(3, 2);
		this.B10FAA1C.Name = "pictureBox1";
		this.B10FAA1C.Size = new System.Drawing.Size(34, 27);
		this.B10FAA1C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.B10FAA1C.TabIndex = 76;
		this.B10FAA1C.TabStop = false;
		this.B10FAA1C.Click += new System.EventHandler(B10FAA1C_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.nudKhoangCachTo);
		this.panel1.Controls.Add(this.nudKhoangCachFrom);
		this.panel1.Controls.Add(this.label18);
		this.panel1.Controls.Add(this.label17);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.label16);
		this.panel1.Controls.Add(this.F9A156A2);
		this.panel1.Controls.Add(this.plTag);
		this.panel1.Controls.Add(this.CD010706);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbTag);
		this.panel1.Controls.Add(this.D193D10F);
		this.panel1.Controls.Add(this.ckbVanBan);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.D7AA1429);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.A91AC686);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(681, 412);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(291, 108);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(30, 16);
		this.label19.TabIndex = 43;
		this.label19.Text = "giây";
		this.label20.Location = new System.Drawing.Point(205, 108);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(29, 16);
		this.label20.TabIndex = 42;
		this.label20.Text = "đến";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudKhoangCachTo.Location = new System.Drawing.Point(236, 106);
		this.nudKhoangCachTo.Name = "nudKhoangCachTo";
		this.nudKhoangCachTo.Size = new System.Drawing.Size(51, 23);
		this.nudKhoangCachTo.TabIndex = 41;
		this.nudKhoangCachFrom.Location = new System.Drawing.Point(151, 106);
		this.nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		this.nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		this.nudKhoangCachFrom.TabIndex = 40;
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(291, 83);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(24, 16);
		this.label18.TabIndex = 39;
		this.label18.Text = "bài";
		this.label17.Location = new System.Drawing.Point(205, 83);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(29, 16);
		this.label17.TabIndex = 38;
		this.label17.Text = "đến";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudSoLuongTo.Location = new System.Drawing.Point(236, 78);
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTo.TabIndex = 37;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(151, 78);
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongFrom.TabIndex = 36;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(30, 108);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(116, 16);
		this.label16.TabIndex = 35;
		this.label16.Text = "Khoảng cách đăng:";
		this.F9A156A2.AutoSize = true;
		this.F9A156A2.Location = new System.Drawing.Point(30, 83);
		this.F9A156A2.Name = "label15";
		this.F9A156A2.Size = new System.Drawing.Size(108, 16);
		this.F9A156A2.TabIndex = 34;
		this.F9A156A2.Text = "Số lượng bài viết:";
		this.plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTag.Controls.Add(this.F5B8749C);
		this.plTag.Controls.Add(this.label4);
		this.plTag.Controls.Add(this.FDBBE335);
		this.plTag.Controls.Add(this.B5A83DA2);
		this.plTag.Controls.Add(this.nudDelayTagFrom);
		this.plTag.Controls.Add(this.DBBAA19B);
		this.plTag.Controls.Add(this.ED351E97);
		this.plTag.Controls.Add(this.label10);
		this.plTag.Controls.Add(this.E0A67B14);
		this.plTag.Enabled = false;
		this.plTag.Location = new System.Drawing.Point(368, 264);
		this.plTag.Name = "plTag";
		this.plTag.Size = new System.Drawing.Size(278, 82);
		this.plTag.TabIndex = 33;
		this.F5B8749C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F5B8749C.Location = new System.Drawing.Point(192, 55);
		this.F5B8749C.Name = "label6";
		this.F5B8749C.Size = new System.Drawing.Size(29, 16);
		this.F5B8749C.TabIndex = 33;
		this.F5B8749C.Text = ">";
		this.F5B8749C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(192, 5);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 33;
		this.label4.Text = ">";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FDBBE335.Location = new System.Drawing.Point(227, 53);
		this.FDBBE335.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FDBBE335.Name = "nudDelayTagTo";
		this.FDBBE335.Size = new System.Drawing.Size(46, 23);
		this.FDBBE335.TabIndex = 39;
		this.FDBBE335.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.B5A83DA2.Location = new System.Drawing.Point(227, 3);
		this.B5A83DA2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B5A83DA2.Name = "nudUidTo";
		this.B5A83DA2.Size = new System.Drawing.Size(46, 23);
		this.B5A83DA2.TabIndex = 39;
		this.B5A83DA2.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.nudDelayTagFrom.Location = new System.Drawing.Point(141, 53);
		this.nudDelayTagFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTagFrom.Name = "nudDelayTagFrom";
		this.nudDelayTagFrom.Size = new System.Drawing.Size(46, 23);
		this.nudDelayTagFrom.TabIndex = 38;
		this.nudDelayTagFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.DBBAA19B.Location = new System.Drawing.Point(141, 3);
		this.DBBAA19B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DBBAA19B.Name = "nudUidFrom";
		this.DBBAA19B.Size = new System.Drawing.Size(46, 23);
		this.DBBAA19B.TabIndex = 38;
		this.DBBAA19B.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.ED351E97.AutoSize = true;
		this.ED351E97.Location = new System.Drawing.Point(3, 55);
		this.ED351E97.Name = "label5";
		this.ED351E97.Size = new System.Drawing.Size(140, 16);
		this.ED351E97.TabIndex = 0;
		this.ED351E97.Text = "Delay mỗi lần chọn (s):";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(3, 5);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(131, 16);
		this.label10.TabIndex = 0;
		this.label10.Text = "Số người cần tag/bài:";
		this.E0A67B14.AutoSize = true;
		this.E0A67B14.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E0A67B14.Location = new System.Drawing.Point(6, 30);
		this.E0A67B14.Name = "ckbOnlyTagVNName";
		this.E0A67B14.Size = new System.Drawing.Size(192, 20);
		this.E0A67B14.TabIndex = 32;
		this.E0A67B14.Text = "Chỉ gắn thẻ ngươ\u0300i co\u0301 tên Việt";
		this.E0A67B14.UseVisualStyleBackColor = true;
		this.CD010706.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.CD010706.Controls.Add(this.DF9A04A0);
		this.CD010706.Controls.Add(this.btnUp);
		this.CD010706.Controls.Add(this.rbNganCachKyTu);
		this.CD010706.Controls.Add(this.rbNganCachMoiDong);
		this.CD010706.Controls.Add(this.label9);
		this.CD010706.Controls.Add(this.txtNoiDung);
		this.CD010706.Controls.Add(this.label8);
		this.CD010706.Controls.Add(this.D80072A0);
		this.CD010706.Location = new System.Drawing.Point(47, 159);
		this.CD010706.Name = "plVanBan";
		this.CD010706.Size = new System.Drawing.Size(278, 187);
		this.CD010706.TabIndex = 33;
		this.DF9A04A0.BackgroundImage = Resources.Bitmap_83;
		this.DF9A04A0.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DF9A04A0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.DF9A04A0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DF9A04A0.Location = new System.Drawing.Point(221, -1);
		this.DF9A04A0.Name = "btnDown";
		this.DF9A04A0.Size = new System.Drawing.Size(25, 25);
		this.DF9A04A0.TabIndex = 38;
		this.DF9A04A0.Click += new System.EventHandler(DF9A04A0_Click);
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(252, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 39;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 210);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(202, 20);
		this.rbNganCachKyTu.TabIndex = 37;
		this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(ACA50B03);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 189);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(170, 20);
		this.rbNganCachMoiDong.TabIndex = 36;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(4, 189);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 35;
		this.label9.Text = "Tùy chọn:";
		this.label9.Click += new System.EventHandler(E12DAB9B);
		this.txtNoiDung.Location = new System.Drawing.Point(7, 24);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(263, 137);
		this.txtNoiDung.TabIndex = 34;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(F31DF324);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(2, 164);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(143, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.D80072A0.AutoSize = true;
		this.D80072A0.Location = new System.Drawing.Point(3, 5);
		this.D80072A0.Name = "lblStatus";
		this.D80072A0.Size = new System.Drawing.Size(145, 16);
		this.D80072A0.TabIndex = 0;
		this.D80072A0.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(243, 367);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.AE8D5526);
		this.plAnh.Controls.Add(this.nudSoLuongAnhFrom);
		this.plAnh.Controls.Add(this.FC8C70A6);
		this.plAnh.Controls.Add(this.A9258F94);
		this.plAnh.Controls.Add(this.txtPathAnh);
		this.plAnh.Controls.Add(this.label3);
		this.plAnh.Controls.Add(this.ckbDangAnhTheoThuTu);
		this.plAnh.Location = new System.Drawing.Point(368, 157);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(278, 82);
		this.plAnh.TabIndex = 33;
		this.AE8D5526.Location = new System.Drawing.Point(228, 30);
		this.AE8D5526.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.AE8D5526.Name = "nudSoLuongAnhTo";
		this.AE8D5526.Size = new System.Drawing.Size(45, 23);
		this.AE8D5526.TabIndex = 7;
		this.nudSoLuongAnhFrom.Location = new System.Drawing.Point(137, 30);
		this.nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		this.nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongAnhFrom.TabIndex = 8;
		this.FC8C70A6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FC8C70A6.Location = new System.Drawing.Point(191, 32);
		this.FC8C70A6.Name = "label2";
		this.FC8C70A6.Size = new System.Drawing.Size(29, 16);
		this.FC8C70A6.TabIndex = 4;
		this.FC8C70A6.Text = ">";
		this.FC8C70A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A9258F94.AutoSize = true;
		this.A9258F94.Location = new System.Drawing.Point(3, 32);
		this.A9258F94.Name = "label21";
		this.A9258F94.Size = new System.Drawing.Size(110, 16);
		this.A9258F94.TabIndex = 6;
		this.A9258F94.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		this.txtPathAnh.Location = new System.Drawing.Point(136, 2);
		this.txtPathAnh.Name = "txtPathAnh";
		this.txtPathAnh.Size = new System.Drawing.Size(138, 23);
		this.txtPathAnh.TabIndex = 1;
		this.txtPathAnh.TextChanged += new System.EventHandler(txtPathAnh_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 5);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(137, 16);
		this.label3.TabIndex = 0;
		this.label3.Text = "Đường dẫn folder ảnh:";
		this.ckbDangAnhTheoThuTu.AutoSize = true;
		this.ckbDangAnhTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDangAnhTheoThuTu.Location = new System.Drawing.Point(7, 57);
		this.ckbDangAnhTheoThuTu.Name = "ckbDangAnhTheoThuTu";
		this.ckbDangAnhTheoThuTu.Size = new System.Drawing.Size(170, 20);
		this.ckbDangAnhTheoThuTu.TabIndex = 32;
		this.ckbDangAnhTheoThuTu.Text = "Đăng file a\u0309nh theo thư\u0301 tư\u0323";
		this.ckbDangAnhTheoThuTu.UseVisualStyleBackColor = true;
		this.ckbTag.AutoSize = true;
		this.ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTag.Location = new System.Drawing.Point(354, 242);
		this.ckbTag.Name = "ckbTag";
		this.ckbTag.Size = new System.Drawing.Size(182, 20);
		this.ckbTag.TabIndex = 32;
		this.ckbTag.Text = "Gắn thẻ bạn bè vào bài viết";
		this.ckbTag.UseVisualStyleBackColor = true;
		this.ckbTag.CheckedChanged += new System.EventHandler(ckbTag_CheckedChanged);
		this.D193D10F.AutoSize = true;
		this.D193D10F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D193D10F.Location = new System.Drawing.Point(354, 135);
		this.D193D10F.Name = "ckbAnh";
		this.D193D10F.Size = new System.Drawing.Size(48, 20);
		this.D193D10F.TabIndex = 32;
		this.D193D10F.Text = "A\u0309nh";
		this.D193D10F.UseVisualStyleBackColor = true;
		this.D193D10F.CheckedChanged += new System.EventHandler(D193D10F_CheckedChanged);
		this.ckbVanBan.AutoSize = true;
		this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVanBan.Location = new System.Drawing.Point(33, 135);
		this.ckbVanBan.Name = "ckbVanBan";
		this.ckbVanBan.Size = new System.Drawing.Size(73, 20);
		this.ckbVanBan.TabIndex = 32;
		this.ckbVanBan.Text = "Văn ba\u0309n";
		this.ckbVanBan.UseVisualStyleBackColor = true;
		this.ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		this.txtTenHanhDong.Location = new System.Drawing.Point(151, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(174, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.D7AA1429.AutoSize = true;
		this.D7AA1429.Location = new System.Drawing.Point(30, 52);
		this.D7AA1429.Name = "label1";
		this.D7AA1429.Size = new System.Drawing.Size(98, 16);
		this.D7AA1429.TabIndex = 31;
		this.D7AA1429.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(342, 367);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(A436E685);
		this.A91AC686.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.A91AC686.BackColor = System.Drawing.Color.White;
		this.A91AC686.BorderRadius = 0;
		this.A91AC686.BottomSahddow = true;
		this.A91AC686.color = System.Drawing.Color.DarkViolet;
		this.A91AC686.Controls.Add(this.pnlHeader);
		this.A91AC686.LeftSahddow = false;
		this.A91AC686.Location = new System.Drawing.Point(1, 0);
		this.A91AC686.Name = "bunifuCards1";
		this.A91AC686.RightSahddow = true;
		this.A91AC686.ShadowDepth = 20;
		this.A91AC686.Size = new System.Drawing.Size(678, 37);
		this.A91AC686.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(681, 412);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangStatusV2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CE01EC8D_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.B10FAA1C).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.plTag.ResumeLayout(false);
		this.plTag.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.FDBBE335).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B5A83DA2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTagFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DBBAA19B).EndInit();
		this.CD010706.ResumeLayout(false);
		this.CD010706.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.AE8D5526).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).EndInit();
		this.A91AC686.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
