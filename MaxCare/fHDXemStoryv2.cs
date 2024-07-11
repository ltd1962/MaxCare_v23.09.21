using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXemStoryv2 : Form
{
	private JSON_Settings E02ADF0B;

	private string BFA0232B;

	private string string_0;

	private string AD03910D;

	private int int_0;

	public static bool bool_0;

	private IContainer B6022F92 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown A818B1BE;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown EABB300F;

	private TextBox txtTenHanhDong;

	private Label E392C081;

	private Label label3;

	private Label DC8942B8;

	private Label label4;

	private Label DB908199;

	private Label D48AB93A;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel DB86E603;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private Label FE92B4B7;

	private Panel plInteract;

	private Label B29CEF19;

	private Label label26;

	private Label label27;

	private Label CD133BB5;

	private Label label29;

	private Label label30;

	private CheckBox ckbGian;

	private CheckBox A61AFA1D;

	private CheckBox ckbWow;

	private CheckBox A321B20C;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox E9B3D810;

	private Label label32;

	private CheckBox ckbComment;

	private CheckBox ckbInteract;

	private TextBox EDA1EC35;

	private Button DD335F00;

	private Label label8;

	public fHDXemStoryv2(string string_1, int int_1 = 0, string BA1E4004 = "")
	{
		B9A3E59E();
		bool_0 = false;
		BFA0232B = string_1;
		AD03910D = BA1E4004;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDXemStoryv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXemStoryv2', 'Xem story v2');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXemStory");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BA1E4004);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E02ADF0B = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(D48AB93A);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(DB908199);
		Language.smethod_0(E392C081);
		Language.smethod_0(DC8942B8);
		Language.smethod_0(ckbInteract);
		Language.smethod_0(label26);
		Language.smethod_0(label27);
		Language.smethod_0(label30);
		Language.smethod_0(label32);
		Language.smethod_0(ckbComment);
		Language.smethod_0(FE92B4B7);
		Language.smethod_0(DD335F00);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void F4189213_Load(object sender, EventArgs e)
	{
		try
		{
			EABB300F.Value = E02ADF0B.GetValueInt("nudSoLuongFrom", 3);
			A818B1BE.Value = E02ADF0B.GetValueInt("nudSoLuongTo", 5);
			nudDelayFrom.Value = E02ADF0B.GetValueInt("nudDelayFrom", 5);
			nudDelayTo.Value = E02ADF0B.GetValueInt("nudDelayTo", 7);
			ckbInteract.Checked = E02ADF0B.GetValueBool("ckbInteract");
			string text = E02ADF0B.GetValue("typeReaction");
			List<CheckBox> list = new List<CheckBox> { E9B3D810, ckbTym, ckbThuong, A321B20C, ckbWow, A61AFA1D, ckbGian };
			for (int i = 0; i < list.Count; i++)
			{
				if (text.Contains(i.ToString()))
				{
					list[i].Checked = true;
				}
			}
			ckbComment.Checked = E02ADF0B.GetValueBool("ckbComment");
			EDA1EC35.Text = E02ADF0B.GetValue("txtComment");
		}
		catch
		{
		}
		method_1();
	}

	private void FCB9DC9F(object sender, EventArgs e)
	{
		Close();
	}

	private void C5967F8E(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> a2AB53A = EDA1EC35.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", EABB300F.Value);
		gClass.GetJson("nudSoLuongTo", A818B1BE.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		List<CheckBox> list = new List<CheckBox> { E9B3D810, ckbTym, ckbThuong, A321B20C, ckbWow, A61AFA1D, ckbGian };
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Checked)
			{
				text2 += i;
			}
		}
		gClass.GetJson("typeReaction", text2);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", EDA1EC35.Text.Trim());
		string text3 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(BFA0232B, text, string_0, text3))
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
			if (InteractSQL.smethod_13(AD03910D, text, text3))
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

	private void C22F203C(object sender, EventArgs e)
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

	private void EDA1EC35_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = EDA1EC35.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			FE92B4B7.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void B29CEF19_Click(object sender, EventArgs e)
	{
		E9B3D810.Checked = !E9B3D810.Checked;
	}

	private void label26_Click(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void label27_Click(object sender, EventArgs e)
	{
		ckbThuong.Checked = !ckbThuong.Checked;
	}

	private void CD133BB5_Click(object sender, EventArgs e)
	{
		A321B20C.Checked = !A321B20C.Checked;
	}

	private void label29_Click(object sender, EventArgs e)
	{
		ckbWow.Checked = !ckbWow.Checked;
	}

	private void C29AE902(object sender, EventArgs e)
	{
		A61AFA1D.Checked = !A61AFA1D.Checked;
	}

	private void FA033B14(object sender, EventArgs e)
	{
		ckbGian.Checked = !ckbGian.Checked;
	}

	private void DD335F00_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng story!");
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && B6022F92 != null)
		{
			B6022F92.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void B9A3E59E()
	{
		B6022F92 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXemStoryv2));
		bunifuDragControl_0 = new BunifuDragControl(B6022F92);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(B6022F92);
		DB86E603 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plComment = new Panel();
		DD335F00 = new Button();
		label8 = new Label();
		EDA1EC35 = new TextBox();
		FE92B4B7 = new Label();
		plInteract = new Panel();
		B29CEF19 = new Label();
		label26 = new Label();
		label27 = new Label();
		CD133BB5 = new Label();
		label29 = new Label();
		label30 = new Label();
		ckbGian = new CheckBox();
		A61AFA1D = new CheckBox();
		ckbWow = new CheckBox();
		A321B20C = new CheckBox();
		ckbThuong = new CheckBox();
		ckbTym = new CheckBox();
		E9B3D810 = new CheckBox();
		label32 = new Label();
		ckbComment = new CheckBox();
		ckbInteract = new CheckBox();
		nudDelayTo = new NumericUpDown();
		A818B1BE = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		EABB300F = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		E392C081 = new Label();
		label3 = new Label();
		DC8942B8 = new Label();
		label4 = new Label();
		DB908199 = new Label();
		D48AB93A = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		DB86E603.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		plInteract.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)A818B1BE).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)EABB300F).BeginInit();
		bunifuCards1.SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xem Story v2";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = DB86E603;
		bunifuDragControl_1.Vertical = true;
		DB86E603.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		DB86E603.BackColor = Color.White;
		DB86E603.Controls.Add(button1);
		DB86E603.Controls.Add(pictureBox1);
		DB86E603.Controls.Add(bunifuCustomLabel1);
		DB86E603.Cursor = Cursors.SizeAll;
		DB86E603.Location = new Point(0, 3);
		DB86E603.Name = "pnlHeader";
		DB86E603.Size = new Size(359, 31);
		DB86E603.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += FCB9DC9F;
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
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(A818B1BE);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(EABB300F);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(E392C081);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(DC8942B8);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(DB908199);
		panel1.Controls.Add(D48AB93A);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 447);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(DD335F00);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(EDA1EC35);
		plComment.Controls.Add(FE92B4B7);
		plComment.Location = new Point(48, 234);
		plComment.Name = "plComment";
		plComment.Size = new Size(278, 164);
		plComment.TabIndex = 8;
		DD335F00.Cursor = Cursors.Help;
		DD335F00.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DD335F00.Location = new Point(246, 2);
		DD335F00.Name = "button2";
		DD335F00.Size = new Size(23, 23);
		DD335F00.TabIndex = 3;
		DD335F00.Text = "?";
		DD335F00.UseVisualStyleBackColor = true;
		DD335F00.Click += DD335F00_Click;
		label8.AutoSize = true;
		label8.Location = new Point(3, 141);
		label8.Name = "label8";
		label8.Size = new Size(265, 16);
		label8.TabIndex = 2;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		EDA1EC35.Location = new Point(7, 27);
		EDA1EC35.Multiline = true;
		EDA1EC35.Name = "txtComment";
		EDA1EC35.ScrollBars = ScrollBars.Both;
		EDA1EC35.Size = new Size(261, 111);
		EDA1EC35.TabIndex = 1;
		EDA1EC35.WordWrap = false;
		EDA1EC35.TextChanged += EDA1EC35_TextChanged;
		FE92B4B7.AutoSize = true;
		FE92B4B7.Location = new Point(3, 5);
		FE92B4B7.Name = "lblStatus";
		FE92B4B7.Size = new Size(139, 16);
		FE92B4B7.TabIndex = 0;
		FE92B4B7.Text = "Nội dung bình luận (0):";
		plInteract.BorderStyle = BorderStyle.FixedSingle;
		plInteract.Controls.Add(B29CEF19);
		plInteract.Controls.Add(label26);
		plInteract.Controls.Add(label27);
		plInteract.Controls.Add(CD133BB5);
		plInteract.Controls.Add(label29);
		plInteract.Controls.Add(label30);
		plInteract.Controls.Add(ckbGian);
		plInteract.Controls.Add(A61AFA1D);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(A321B20C);
		plInteract.Controls.Add(ckbThuong);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(E9B3D810);
		plInteract.Controls.Add(label32);
		plInteract.Location = new Point(48, 165);
		plInteract.Name = "plInteract";
		plInteract.Size = new Size(278, 40);
		plInteract.TabIndex = 6;
		B29CEF19.Cursor = Cursors.Hand;
		B29CEF19.Location = new Point(4, 1);
		B29CEF19.Name = "label25";
		B29CEF19.Size = new Size(30, 16);
		B29CEF19.TabIndex = 0;
		B29CEF19.Text = "Like";
		B29CEF19.TextAlign = ContentAlignment.MiddleCenter;
		B29CEF19.Click += B29CEF19_Click;
		label26.Cursor = Cursors.Hand;
		label26.Location = new Point(40, 1);
		label26.Name = "label26";
		label26.Size = new Size(33, 16);
		label26.TabIndex = 2;
		label26.Text = "Tym";
		label26.TextAlign = ContentAlignment.MiddleCenter;
		label26.Click += label26_Click;
		label27.Cursor = Cursors.Hand;
		label27.Location = new Point(75, 1);
		label27.Name = "label27";
		label27.Size = new Size(52, 16);
		label27.TabIndex = 4;
		label27.Text = "Thương";
		label27.TextAlign = ContentAlignment.MiddleCenter;
		label27.Click += label27_Click;
		CD133BB5.Cursor = Cursors.Hand;
		CD133BB5.Location = new Point(128, 1);
		CD133BB5.Name = "label28";
		CD133BB5.Size = new Size(37, 16);
		CD133BB5.TabIndex = 6;
		CD133BB5.Text = "Haha";
		CD133BB5.TextAlign = ContentAlignment.MiddleCenter;
		CD133BB5.Click += CD133BB5_Click;
		label29.Cursor = Cursors.Hand;
		label29.Location = new Point(167, 1);
		label29.Name = "label29";
		label29.Size = new Size(37, 16);
		label29.TabIndex = 8;
		label29.Text = "Wow";
		label29.TextAlign = ContentAlignment.MiddleCenter;
		label29.Click += label29_Click;
		label30.Cursor = Cursors.Hand;
		label30.Location = new Point(206, 1);
		label30.Name = "label30";
		label30.Size = new Size(36, 16);
		label30.TabIndex = 10;
		label30.Text = "Buồn";
		label30.TextAlign = ContentAlignment.MiddleCenter;
		label30.Click += C29AE902;
		ckbGian.AutoSize = true;
		ckbGian.Cursor = Cursors.Hand;
		ckbGian.Location = new Point(252, 20);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new Size(15, 14);
		ckbGian.TabIndex = 13;
		ckbGian.UseVisualStyleBackColor = true;
		A61AFA1D.AutoSize = true;
		A61AFA1D.Cursor = Cursors.Hand;
		A61AFA1D.Location = new Point(218, 20);
		A61AFA1D.Name = "ckbBuon";
		A61AFA1D.Size = new Size(15, 14);
		A61AFA1D.TabIndex = 11;
		A61AFA1D.UseVisualStyleBackColor = true;
		ckbWow.AutoSize = true;
		ckbWow.Cursor = Cursors.Hand;
		ckbWow.Location = new Point(179, 20);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new Size(15, 14);
		ckbWow.TabIndex = 9;
		ckbWow.UseVisualStyleBackColor = true;
		A321B20C.AutoSize = true;
		A321B20C.Cursor = Cursors.Hand;
		A321B20C.Location = new Point(139, 20);
		A321B20C.Name = "ckbHaha";
		A321B20C.Size = new Size(15, 14);
		A321B20C.TabIndex = 7;
		A321B20C.UseVisualStyleBackColor = true;
		ckbThuong.AutoSize = true;
		ckbThuong.Cursor = Cursors.Hand;
		ckbThuong.Location = new Point(94, 20);
		ckbThuong.Name = "ckbThuong";
		ckbThuong.Size = new Size(15, 14);
		ckbThuong.TabIndex = 5;
		ckbThuong.UseVisualStyleBackColor = true;
		ckbTym.AutoSize = true;
		ckbTym.Cursor = Cursors.Hand;
		ckbTym.Location = new Point(48, 20);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new Size(15, 14);
		ckbTym.TabIndex = 3;
		ckbTym.UseVisualStyleBackColor = true;
		E9B3D810.AutoSize = true;
		E9B3D810.Cursor = Cursors.Hand;
		E9B3D810.Location = new Point(11, 20);
		E9B3D810.Name = "ckbLike";
		E9B3D810.Size = new Size(15, 14);
		E9B3D810.TabIndex = 1;
		E9B3D810.UseVisualStyleBackColor = true;
		label32.Cursor = Cursors.Hand;
		label32.Location = new Point(242, 1);
		label32.Name = "label32";
		label32.Size = new Size(33, 16);
		label32.TabIndex = 12;
		label32.Text = "Giận";
		label32.TextAlign = ContentAlignment.MiddleCenter;
		label32.Click += FA033B14;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(30, 209);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(130, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += ckbComment_CheckedChanged;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = Cursors.Hand;
		ckbInteract.Location = new Point(30, 141);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new Size(112, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += ckbInteract_CheckedChanged;
		nudDelayTo.Location = new Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		A818B1BE.Location = new Point(229, 80);
		A818B1BE.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A818B1BE.Name = "nudSoLuongTo";
		A818B1BE.Size = new Size(56, 23);
		A818B1BE.TabIndex = 2;
		nudDelayFrom.Location = new Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		EABB300F.Location = new Point(132, 80);
		EABB300F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EABB300F.Name = "nudSoLuongFrom";
		EABB300F.Size = new Size(56, 23);
		EABB300F.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		E392C081.Location = new Point(194, 113);
		E392C081.Name = "label7";
		E392C081.Size = new Size(29, 16);
		E392C081.TabIndex = 38;
		E392C081.Text = "đê\u0301n";
		E392C081.TextAlign = ContentAlignment.MiddleCenter;
		label3.Location = new Point(194, 82);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		DC8942B8.AutoSize = true;
		DC8942B8.Location = new Point(290, 113);
		DC8942B8.Name = "label6";
		DC8942B8.Size = new Size(30, 16);
		DC8942B8.TabIndex = 36;
		DC8942B8.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new Point(290, 82);
		label4.Name = "label4";
		label4.Size = new Size(35, 16);
		label4.TabIndex = 35;
		label4.Text = "story";
		DB908199.AutoSize = true;
		DB908199.Location = new Point(27, 113);
		DB908199.Name = "label5";
		DB908199.Size = new Size(89, 16);
		DB908199.TabIndex = 34;
		DB908199.Text = "Thơ\u0300i gian chơ\u0300:";
		D48AB93A.AutoSize = true;
		D48AB93A.Location = new Point(27, 82);
		D48AB93A.Name = "label2";
		D48AB93A.Size = new Size(95, 16);
		D48AB93A.TabIndex = 32;
		D48AB93A.Text = "Sô\u0301 lươ\u0323ng story:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(189, 406);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += C22F203C;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 406);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += C5967F8E;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(DB86E603);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 447);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXemStoryv2";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += F4189213_Load;
		DB86E603.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		plInteract.ResumeLayout(performLayout: false);
		plInteract.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)A818B1BE).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)EABB300F).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
