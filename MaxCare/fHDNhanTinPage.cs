using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDNhanTinPage : Form
{
	private JObject jobject_0;

	private string ACBCD9B0;

	private string string_0;

	private string string_1;

	private int B8391920;

	public static bool bool_0;

	private IContainer B9B87AA4 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl DD3A3615;

	private Panel panel1;

	private NumericUpDown FEA20FBF;

	private NumericUpDown nudSoLuongFrom;

	private TextBox ACBC0FB2;

	private Label D402628F;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button AF2DC22D;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button B9B437BD;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label A2AF0A1C;

	private Label BF979503;

	private TextBox txtTinNhan;

	private NumericUpDown B01B918C;

	private NumericUpDown nudDelayFrom;

	private Label A73F4D1A;

	private Label label6;

	private Label label5;

	private TextBox txtIdPage;

	private Label B00FB5AE;

	public fHDNhanTinPage(string string_2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		ACBCD9B0 = string_2;
		string_1 = string_3;
		B8391920 = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDNhanTinPage");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			ACBC0FB2.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			ACBC0FB2.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(D402628F);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(A73F4D1A);
		Language.smethod_0(label6);
		Language.smethod_0(B00FB5AE);
		Language.smethod_0(BF979503);
		Language.smethod_0(A2AF0A1C);
		Language.smethod_0(btnAdd);
		Language.smethod_0(AF2DC22D);
	}

	private void A300B4B9(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			FEA20FBF.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			B01B918C.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			txtIdPage.Text = jobject_0["txtIdPage"].ToString();
			txtTinNhan.Text = jobject_0["txtTinNhan"].ToString();
		}
		catch
		{
		}
	}

	private void B9B437BD_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A0A7969C(object sender, EventArgs e)
	{
		string text = ACBC0FB2.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtIdPage.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch ID Page!", 3);
			return;
		}
		a2AB53A = txtTinNhan.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", FEA20FBF.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", B01B918C.Value);
		gClass.GetJson("txtIdPage", txtIdPage.Text.Trim());
		gClass.GetJson("txtTinNhan", txtTinNhan.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (B8391920 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(ACBCD9B0, text, string_0, string_))
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

	private void AF2DC22D_Click(object sender, EventArgs e)
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

	private void txtTinNhan_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTinNhan.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			BF979503.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void E2810AA9(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtIdPage.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			B00FB5AE.Text = string.Format(Language.GetValue("Danh sa\u0301ch ID Page ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && B9B87AA4 != null)
		{
			B9B87AA4.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.B9B87AA4 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDNhanTinPage));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.B9B87AA4);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.DD3A3615 = new Bunifu.Framework.UI.BunifuDragControl(this.B9B87AA4);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.B9B437BD = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtIdPage = new System.Windows.Forms.TextBox();
		this.txtTinNhan = new System.Windows.Forms.TextBox();
		this.B01B918C = new System.Windows.Forms.NumericUpDown();
		this.A2AF0A1C = new System.Windows.Forms.Label();
		this.B00FB5AE = new System.Windows.Forms.Label();
		this.BF979503 = new System.Windows.Forms.Label();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.A73F4D1A = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.FEA20FBF = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.ACBC0FB2 = new System.Windows.Forms.TextBox();
		this.D402628F = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.AF2DC22D = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B01B918C).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FEA20FBF).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Nhă\u0301n tin page";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DD3A3615.Fixed = true;
		this.DD3A3615.Horizontal = true;
		this.DD3A3615.TargetControl = this.pnlHeader;
		this.DD3A3615.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.B9B437BD);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.B9B437BD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.B9B437BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B9B437BD.FlatAppearance.BorderSize = 0;
		this.B9B437BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B9B437BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B9B437BD.ForeColor = System.Drawing.Color.White;
		this.B9B437BD.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.B9B437BD.Location = new System.Drawing.Point(328, 1);
		this.B9B437BD.Name = "button1";
		this.B9B437BD.Size = new System.Drawing.Size(30, 30);
		this.B9B437BD.TabIndex = 77;
		this.B9B437BD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.B9B437BD.UseVisualStyleBackColor = true;
		this.B9B437BD.Click += new System.EventHandler(B9B437BD_Click);
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
		this.panel1.Controls.Add(this.txtIdPage);
		this.panel1.Controls.Add(this.txtTinNhan);
		this.panel1.Controls.Add(this.B01B918C);
		this.panel1.Controls.Add(this.A2AF0A1C);
		this.panel1.Controls.Add(this.B00FB5AE);
		this.panel1.Controls.Add(this.BF979503);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.A73F4D1A);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.FEA20FBF);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.ACBC0FB2);
		this.panel1.Controls.Add(this.D402628F);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.AF2DC22D);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 500);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtIdPage.Location = new System.Drawing.Point(32, 161);
		this.txtIdPage.Multiline = true;
		this.txtIdPage.Name = "txtIdPage";
		this.txtIdPage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtIdPage.Size = new System.Drawing.Size(295, 98);
		this.txtIdPage.TabIndex = 5;
		this.txtIdPage.WordWrap = false;
		this.txtIdPage.TextChanged += new System.EventHandler(E2810AA9);
		this.txtTinNhan.Location = new System.Drawing.Point(31, 286);
		this.txtTinNhan.Multiline = true;
		this.txtTinNhan.Name = "txtTinNhan";
		this.txtTinNhan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtTinNhan.Size = new System.Drawing.Size(295, 138);
		this.txtTinNhan.TabIndex = 5;
		this.txtTinNhan.WordWrap = false;
		this.txtTinNhan.TextChanged += new System.EventHandler(txtTinNhan_TextChanged);
		this.B01B918C.Location = new System.Drawing.Point(229, 111);
		this.B01B918C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B01B918C.Name = "nudDelayTo";
		this.B01B918C.Size = new System.Drawing.Size(56, 23);
		this.B01B918C.TabIndex = 4;
		this.A2AF0A1C.AutoSize = true;
		this.A2AF0A1C.Location = new System.Drawing.Point(28, 427);
		this.A2AF0A1C.Name = "label8";
		this.A2AF0A1C.Size = new System.Drawing.Size(265, 16);
		this.A2AF0A1C.TabIndex = 0;
		this.A2AF0A1C.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.B00FB5AE.AutoSize = true;
		this.B00FB5AE.Location = new System.Drawing.Point(28, 139);
		this.B00FB5AE.Name = "lblStatusPage";
		this.B00FB5AE.Size = new System.Drawing.Size(140, 16);
		this.B00FB5AE.TabIndex = 0;
		this.B00FB5AE.Text = "Danh sa\u0301ch ID Page (0):";
		this.BF979503.AutoSize = true;
		this.BF979503.Location = new System.Drawing.Point(27, 264);
		this.BF979503.Name = "lblStatus";
		this.BF979503.Size = new System.Drawing.Size(142, 16);
		this.BF979503.TabIndex = 0;
		this.BF979503.Text = "Danh sa\u0301ch tin nhă\u0301n (0):";
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.A73F4D1A.AutoSize = true;
		this.A73F4D1A.Location = new System.Drawing.Point(194, 113);
		this.A73F4D1A.Name = "label7";
		this.A73F4D1A.Size = new System.Drawing.Size(28, 16);
		this.A73F4D1A.TabIndex = 46;
		this.A73F4D1A.Text = "đê\u0301n";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.FEA20FBF.Location = new System.Drawing.Point(229, 80);
		this.FEA20FBF.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FEA20FBF.Name = "nudSoLuongTo";
		this.FEA20FBF.Size = new System.Drawing.Size(56, 23);
		this.FEA20FBF.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.ACBC0FB2.Location = new System.Drawing.Point(132, 49);
		this.ACBC0FB2.Name = "txtTenHanhDong";
		this.ACBC0FB2.Size = new System.Drawing.Size(194, 23);
		this.ACBC0FB2.TabIndex = 0;
		this.D402628F.AutoSize = true;
		this.D402628F.Location = new System.Drawing.Point(194, 82);
		this.D402628F.Name = "label3";
		this.D402628F.Size = new System.Drawing.Size(28, 16);
		this.D402628F.TabIndex = 37;
		this.D402628F.Text = "đê\u0301n";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(95, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng page:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.AF2DC22D.BackColor = System.Drawing.Color.Maroon;
		this.AF2DC22D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AF2DC22D.FlatAppearance.BorderSize = 0;
		this.AF2DC22D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AF2DC22D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AF2DC22D.ForeColor = System.Drawing.Color.White;
		this.AF2DC22D.Location = new System.Drawing.Point(185, 456);
		this.AF2DC22D.Name = "btnCancel";
		this.AF2DC22D.Size = new System.Drawing.Size(92, 29);
		this.AF2DC22D.TabIndex = 7;
		this.AF2DC22D.Text = "Đóng";
		this.AF2DC22D.UseVisualStyleBackColor = false;
		this.AF2DC22D.Click += new System.EventHandler(AF2DC22D_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(78, 456);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(A0A7969C);
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
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 500);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDNhanTinPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A300B4B9);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.B01B918C).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FEA20FBF).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
