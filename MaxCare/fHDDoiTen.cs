using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDDoiTen : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string CA376EAE;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private List<string> AF8861B8 = new List<string>();

	private List<string> BF921193 = new List<string>();

	private List<string> list_0 = new List<string>();

	private IContainer B1A4822B = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label B7B15F9E;

	private Button B90F7115;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel B99BA0A2;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel AD17D98F;

	private Panel plTenTuDat;

	private Button button8;

	private Button B0A46805;

	private Button A59E6F10;

	private RadioButton E20E029D;

	private RadioButton CD2A78B3;

	private Panel plTenNgauNhien;

	private RadioButton rdTenRandomNgoai;

	private RadioButton rdTenRandomViet;

	public fHDDoiTen(string D59109A9, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = D59109A9;
		string_1 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đổi tên";
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
			CA376EAE = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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

	private void method_0()
	{
		Language.smethod_0(AD17D98F);
		Language.smethod_0(B7B15F9E);
		Language.smethod_0(btnAdd);
		Language.smethod_0(B90F7115);
	}

	private void fHDDoiTen_Load(object sender, EventArgs e)
	{
		try
		{
			if (gclass8_0.GetValueInt("typeDatTen") == 0)
			{
				CD2A78B3.Checked = true;
			}
			else
			{
				E20E029D.Checked = true;
			}
			if (gclass8_0.GetValueInt("typeTenRandom") == 0)
			{
				rdTenRandomViet.Checked = true;
			}
			else
			{
				rdTenRandomNgoai.Checked = true;
			}
			AF8861B8 = gclass8_0.GetValueList("lstHo");
			BF921193 = gclass8_0.GetValueList("lstTenDem");
			list_0 = gclass8_0.GetValueList("lstTen");
			CF3B22A4(null, null);
			F51ADC02(null, null);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A1378922(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		int num = 0;
		if (E20E029D.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeDatTen", num);
		int num2 = 0;
		if (rdTenRandomNgoai.Checked)
		{
			num2 = 1;
		}
		gClass.GetJson("typeTenRandom", num2);
		gClass.method_5("lstHo", AF8861B8);
		gClass.method_5("lstTenDem", BF921193);
		gClass.method_5("lstTen", list_0);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, CA376EAE, string_))
				{
					bool_0 = true;
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
			if (InteractSQL.smethod_13(string_1, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void B90F7115_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F0AD6615(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void CF3B22A4(object sender, EventArgs e)
	{
		plTenTuDat.Enabled = E20E029D.Checked;
	}

	private void F51ADC02(object sender, EventArgs e)
	{
		plTenNgauNhien.Enabled = CD2A78B3.Checked;
	}

	private void A59E6F10_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(AF8861B8, "Nhâ\u0323p danh sa\u0301ch Họ", "Danh sa\u0301ch Họ", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		AF8861B8 = fNhapDuLieu3.C82C3629;
	}

	private void E5159138(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(BF921193, "Nhâ\u0323p danh sa\u0301ch Tên đệm", "Danh sa\u0301ch Tên đệm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		BF921193 = fNhapDuLieu3.C82C3629;
	}

	private void button8_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch Tên", "Danh sa\u0301ch Tên", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_0 = fNhapDuLieu3.C82C3629;
	}

	protected override void Dispose(bool E387DA94)
	{
		if (E387DA94 && B1A4822B != null)
		{
			B1A4822B.Dispose();
		}
		base.Dispose(E387DA94);
	}

	private void InitializeComponent()
	{
		this.B1A4822B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDoiTen));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.B1A4822B);
		this.AD17D98F = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.B1A4822B);
		this.B99BA0A2 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plTenTuDat = new System.Windows.Forms.Panel();
		this.button8 = new System.Windows.Forms.Button();
		this.B0A46805 = new System.Windows.Forms.Button();
		this.A59E6F10 = new System.Windows.Forms.Button();
		this.E20E029D = new System.Windows.Forms.RadioButton();
		this.CD2A78B3 = new System.Windows.Forms.RadioButton();
		this.plTenNgauNhien = new System.Windows.Forms.Panel();
		this.rdTenRandomNgoai = new System.Windows.Forms.RadioButton();
		this.rdTenRandomViet = new System.Windows.Forms.RadioButton();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.B7B15F9E = new System.Windows.Forms.Label();
		this.B90F7115 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.B99BA0A2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plTenTuDat.SuspendLayout();
		this.plTenNgauNhien.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.AD17D98F;
		this.bunifuDragControl_0.Vertical = true;
		this.AD17D98F.BackColor = System.Drawing.Color.Transparent;
		this.AD17D98F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.AD17D98F.Dock = System.Windows.Forms.DockStyle.Fill;
		this.AD17D98F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AD17D98F.ForeColor = System.Drawing.Color.Black;
		this.AD17D98F.Location = new System.Drawing.Point(0, 0);
		this.AD17D98F.Name = "bunifuCustomLabel1";
		this.AD17D98F.Size = new System.Drawing.Size(320, 31);
		this.AD17D98F.TabIndex = 12;
		this.AD17D98F.Text = "Cấu hình Đổi tên";
		this.AD17D98F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.B99BA0A2;
		this.bunifuDragControl_1.Vertical = true;
		this.B99BA0A2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B99BA0A2.BackColor = System.Drawing.Color.White;
		this.B99BA0A2.Controls.Add(this.button1);
		this.B99BA0A2.Controls.Add(this.pictureBox1);
		this.B99BA0A2.Controls.Add(this.AD17D98F);
		this.B99BA0A2.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B99BA0A2.Location = new System.Drawing.Point(0, 3);
		this.B99BA0A2.Name = "pnlHeader";
		this.B99BA0A2.Size = new System.Drawing.Size(320, 31);
		this.B99BA0A2.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(289, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plTenTuDat);
		this.panel1.Controls.Add(this.E20E029D);
		this.panel1.Controls.Add(this.CD2A78B3);
		this.panel1.Controls.Add(this.plTenNgauNhien);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.B7B15F9E);
		this.panel1.Controls.Add(this.B90F7115);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(323, 238);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(F0AD6615);
		this.plTenTuDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTenTuDat.Controls.Add(this.button8);
		this.plTenTuDat.Controls.Add(this.B0A46805);
		this.plTenTuDat.Controls.Add(this.A59E6F10);
		this.plTenTuDat.Location = new System.Drawing.Point(44, 150);
		this.plTenTuDat.Name = "plTenTuDat";
		this.plTenTuDat.Size = new System.Drawing.Size(240, 29);
		this.plTenTuDat.TabIndex = 136;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Location = new System.Drawing.Point(171, 0);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(67, 27);
		this.button8.TabIndex = 124;
		this.button8.Text = "Nhập tên";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.B0A46805.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B0A46805.Location = new System.Drawing.Point(69, 0);
		this.B0A46805.Name = "button7";
		this.B0A46805.Size = new System.Drawing.Size(96, 27);
		this.B0A46805.TabIndex = 124;
		this.B0A46805.Text = "Nhập tên đệm";
		this.B0A46805.UseVisualStyleBackColor = true;
		this.B0A46805.Click += new System.EventHandler(E5159138);
		this.A59E6F10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A59E6F10.Location = new System.Drawing.Point(0, 0);
		this.A59E6F10.Name = "button6";
		this.A59E6F10.Size = new System.Drawing.Size(63, 27);
		this.A59E6F10.TabIndex = 124;
		this.A59E6F10.Text = "Nhập họ";
		this.A59E6F10.UseVisualStyleBackColor = true;
		this.A59E6F10.Click += new System.EventHandler(A59E6F10_Click);
		this.E20E029D.AutoSize = true;
		this.E20E029D.Checked = true;
		this.E20E029D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E20E029D.Location = new System.Drawing.Point(29, 127);
		this.E20E029D.Name = "rdTenTuDat";
		this.E20E029D.Size = new System.Drawing.Size(155, 20);
		this.E20E029D.TabIndex = 138;
		this.E20E029D.TabStop = true;
		this.E20E029D.Text = "Tên do người dùng đặt";
		this.E20E029D.UseVisualStyleBackColor = true;
		this.E20E029D.CheckedChanged += new System.EventHandler(CF3B22A4);
		this.CD2A78B3.AutoSize = true;
		this.CD2A78B3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CD2A78B3.Location = new System.Drawing.Point(29, 78);
		this.CD2A78B3.Name = "rdTenRandom";
		this.CD2A78B3.Size = new System.Drawing.Size(114, 20);
		this.CD2A78B3.TabIndex = 137;
		this.CD2A78B3.Text = "Tên ngẫu nhiên";
		this.CD2A78B3.UseVisualStyleBackColor = true;
		this.CD2A78B3.CheckedChanged += new System.EventHandler(F51ADC02);
		this.plTenNgauNhien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTenNgauNhien.Controls.Add(this.rdTenRandomNgoai);
		this.plTenNgauNhien.Controls.Add(this.rdTenRandomViet);
		this.plTenNgauNhien.Location = new System.Drawing.Point(44, 98);
		this.plTenNgauNhien.Name = "plTenNgauNhien";
		this.plTenNgauNhien.Size = new System.Drawing.Size(240, 25);
		this.plTenNgauNhien.TabIndex = 139;
		this.rdTenRandomNgoai.AutoSize = true;
		this.rdTenRandomNgoai.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTenRandomNgoai.Location = new System.Drawing.Point(80, 1);
		this.rdTenRandomNgoai.Name = "rdTenRandomNgoai";
		this.rdTenRandomNgoai.Size = new System.Drawing.Size(82, 20);
		this.rdTenRandomNgoai.TabIndex = 134;
		this.rdTenRandomNgoai.Text = "Tên ngoại";
		this.rdTenRandomNgoai.UseVisualStyleBackColor = true;
		this.rdTenRandomViet.AutoSize = true;
		this.rdTenRandomViet.Checked = true;
		this.rdTenRandomViet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rdTenRandomViet.Location = new System.Drawing.Point(2, 1);
		this.rdTenRandomViet.Name = "rdTenRandomViet";
		this.rdTenRandomViet.Size = new System.Drawing.Size(71, 20);
		this.rdTenRandomViet.TabIndex = 134;
		this.rdTenRandomViet.TabStop = true;
		this.rdTenRandomViet.Text = "Tên việt";
		this.rdTenRandomViet.UseVisualStyleBackColor = true;
		this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(159, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.B7B15F9E.AutoSize = true;
		this.B7B15F9E.Location = new System.Drawing.Point(26, 52);
		this.B7B15F9E.Name = "label1";
		this.B7B15F9E.Size = new System.Drawing.Size(98, 16);
		this.B7B15F9E.TabIndex = 31;
		this.B7B15F9E.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.B90F7115.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.B90F7115.BackColor = System.Drawing.Color.Maroon;
		this.B90F7115.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B90F7115.FlatAppearance.BorderSize = 0;
		this.B90F7115.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B90F7115.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B90F7115.ForeColor = System.Drawing.Color.White;
		this.B90F7115.Location = new System.Drawing.Point(168, 193);
		this.B90F7115.Name = "btnCancel";
		this.B90F7115.Size = new System.Drawing.Size(92, 29);
		this.B90F7115.TabIndex = 7;
		this.B90F7115.Text = "Đóng";
		this.B90F7115.UseVisualStyleBackColor = false;
		this.B90F7115.Click += new System.EventHandler(B90F7115_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(61, 193);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(A1378922);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.B99BA0A2);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(320, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(323, 238);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDoiTen";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDoiTen_Load);
		this.B99BA0A2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plTenTuDat.ResumeLayout(false);
		this.plTenNgauNhien.ResumeLayout(false);
		this.plTenNgauNhien.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
