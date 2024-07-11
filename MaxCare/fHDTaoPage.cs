using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTaoPage : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string D12BC690;

	private string E6235EB0;

	private int int_0;

	public static bool bool_0;

	private IContainer E0B2A739 = null;

	private BunifuDragControl A9385C25;

	private BunifuDragControl F813DA35;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label D3140CA7;

	private Label C3018934;

	private Label BABB9A80;

	private Label label1;

	private Button btnCancel;

	private Button F3359638;

	private BunifuCards bunifuCards1;

	private Panel CC29873D;

	private Button button1;

	private PictureBox DC13DB8D;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F42F8F08;

	private Label label7;

	private Label E40B509C;

	private Label label5;

	private RichTextBox txtPageName;

	private RichTextBox BF956D1B;

	private Label lblPageName;

	private Label CCAC809B;

	private TextBox txtToCookie;

	private Label lblToCookie;

	public fHDTaoPage(string AEA23AAB, int int_1 = 0, string string_1 = "")
	{
		E1843CB5();
		bool_0 = false;
		string_0 = AEA23AAB;
		E6235EB0 = string_1;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDTaoPage").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTaoPage', 'Tạo Page');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTaoPage");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			D12BC690 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_1);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			F3359638.Text = "Câ\u0323p nhâ\u0323t";
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
		lblToCookie.Visible = Base.bool_0;
		txtToCookie.Visible = Base.bool_0;
	}

	private void AB1D91BB(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			F42F8F08.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			txtPageName.Text = gclass8_0.GetValue("txtPageName");
			BF956D1B.Text = gclass8_0.GetValue("txtCatagory");
			txtToCookie.Text = gclass8_0.GetValue("txtToCookie");
		}
		catch
		{
		}
		txtPageName.B992B8A4("Nhập tên page (có thể sử dụng ký tự * để random 1 số từ 0 -> 9, ví dụ: Phần mềm nuôi nick ***)...");
		BF956D1B.B992B8A4("Nhập tên danh mục page bằng tiếng anh (ví dụ: digital creator, creator)...");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F3359638_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", F42F8F08.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtPageName", (txtPageName.Text == "Nhập tên page (có thể sử dụng ký tự * để random 1 số từ 0 -> 9, ví dụ: Phần mềm nuôi nick ***)...") ? "" : txtPageName.Text);
		gClass.GetJson("txtCatagory", (BF956D1B.Text == "Nhập tên danh mục page bằng tiếng anh (ví dụ: digital creator, creator)...") ? "" : BF956D1B.Text);
		gClass.GetJson("txtToCookie", txtToCookie.Text);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, D12BC690, text2))
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
			if (InteractSQL.smethod_13(E6235EB0, text, text2))
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

	private void D716820F(object sender, EventArgs e)
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

	private void txtPageName_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtPageName, lblPageName);
	}

	private void E83DD71B(object sender, EventArgs e)
	{
		Common.F9202C12(BF956D1B, CCAC809B);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E0B2A739 != null)
		{
			E0B2A739.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void E1843CB5()
	{
		E0B2A739 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDTaoPage));
		A9385C25 = new BunifuDragControl(E0B2A739);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		F813DA35 = new BunifuDragControl(E0B2A739);
		CC29873D = new Panel();
		button1 = new Button();
		DC13DB8D = new PictureBox();
		panel1 = new Panel();
		txtPageName = new RichTextBox();
		BF956D1B = new RichTextBox();
		nudDelayTo = new NumericUpDown();
		lblPageName = new Label();
		CCAC809B = new Label();
		F42F8F08 = new NumericUpDown();
		label7 = new Label();
		E40B509C = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		D3140CA7 = new Label();
		C3018934 = new Label();
		BABB9A80 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		F3359638 = new Button();
		bunifuCards1 = new BunifuCards();
		txtToCookie = new TextBox();
		lblToCookie = new Label();
		CC29873D.SuspendLayout();
		((ISupportInitialize)DC13DB8D).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)F42F8F08).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A9385C25.Fixed = true;
		A9385C25.Horizontal = true;
		A9385C25.TargetControl = bunifuCustomLabel1;
		A9385C25.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(352, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tạo page";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		F813DA35.Fixed = true;
		F813DA35.Horizontal = true;
		F813DA35.TargetControl = CC29873D;
		F813DA35.Vertical = true;
		CC29873D.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		CC29873D.BackColor = Color.White;
		CC29873D.Controls.Add(button1);
		CC29873D.Controls.Add(DC13DB8D);
		CC29873D.Controls.Add(bunifuCustomLabel1);
		CC29873D.Cursor = Cursors.SizeAll;
		CC29873D.Location = new Point(0, 3);
		CC29873D.Name = "pnlHeader";
		CC29873D.Size = new Size(352, 31);
		CC29873D.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(321, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		DC13DB8D.Cursor = Cursors.Default;
		DC13DB8D.Image = Resources.Bitmap_4;
		DC13DB8D.Location = new Point(3, 2);
		DC13DB8D.Name = "pictureBox1";
		DC13DB8D.Size = new Size(34, 27);
		DC13DB8D.SizeMode = PictureBoxSizeMode.Zoom;
		DC13DB8D.TabIndex = 76;
		DC13DB8D.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(txtPageName);
		panel1.Controls.Add(BF956D1B);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(lblPageName);
		panel1.Controls.Add(CCAC809B);
		panel1.Controls.Add(F42F8F08);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(E40B509C);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D3140CA7);
		panel1.Controls.Add(C3018934);
		panel1.Controls.Add(BABB9A80);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F3359638);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(txtToCookie);
		panel1.Controls.Add(lblToCookie);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(355, 438);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		txtPageName.Location = new Point(30, 152);
		txtPageName.Name = "txtPageName";
		txtPageName.Size = new Size(295, 98);
		txtPageName.TabIndex = 47;
		txtPageName.Text = "";
		txtPageName.WordWrap = false;
		txtPageName.TextChanged += txtPageName_TextChanged;
		BF956D1B.Location = new Point(30, 272);
		BF956D1B.Name = "txtCatagory";
		BF956D1B.Size = new Size(295, 98);
		BF956D1B.TabIndex = 47;
		BF956D1B.Text = "";
		BF956D1B.WordWrap = false;
		BF956D1B.TextChanged += E83DD71B;
		nudDelayTo.Location = new Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		lblPageName.AutoSize = true;
		lblPageName.Location = new Point(27, 133);
		lblPageName.Name = "lblPageName";
		lblPageName.Size = new Size(87, 16);
		lblPageName.TabIndex = 0;
		lblPageName.Text = "Tên page (0):";
		CCAC809B.AutoSize = true;
		CCAC809B.Location = new Point(27, 253);
		CCAC809B.Name = "lblCatagory";
		CCAC809B.Size = new Size(122, 16);
		CCAC809B.TabIndex = 0;
		CCAC809B.Text = "Danh mục page (0):";
		F42F8F08.Location = new Point(132, 107);
		F42F8F08.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F42F8F08.Name = "nudDelayFrom";
		F42F8F08.Size = new Size(56, 23);
		F42F8F08.TabIndex = 3;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(199, 109);
		label7.Name = "label7";
		label7.Size = new Size(18, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		E40B509C.AutoSize = true;
		E40B509C.Location = new Point(288, 109);
		E40B509C.Name = "label6";
		E40B509C.Size = new Size(13, 16);
		E40B509C.TabIndex = 45;
		E40B509C.Text = "s";
		label5.AutoSize = true;
		label5.Location = new Point(27, 109);
		label5.Name = "label5";
		label5.Size = new Size(92, 16);
		label5.TabIndex = 44;
		label5.Text = "Delay time (s):";
		nudSoLuongTo.Location = new Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D3140CA7.AutoSize = true;
		D3140CA7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D3140CA7.Location = new Point(199, 80);
		D3140CA7.Name = "label3";
		D3140CA7.Size = new Size(18, 16);
		D3140CA7.TabIndex = 37;
		D3140CA7.Text = ">";
		C3018934.AutoSize = true;
		C3018934.Location = new Point(288, 80);
		C3018934.Name = "label4";
		C3018934.Size = new Size(35, 16);
		C3018934.TabIndex = 35;
		C3018934.Text = "page";
		BABB9A80.AutoSize = true;
		BABB9A80.Location = new Point(27, 80);
		BABB9A80.Name = "label2";
		BABB9A80.Size = new Size(95, 16);
		BABB9A80.TabIndex = 32;
		BABB9A80.Text = "Sô\u0301 lươ\u0323ng page:";
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
		btnCancel.Location = new Point(184, 394);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += D716820F;
		F3359638.Anchor = AnchorStyles.Bottom;
		F3359638.BackColor = Color.FromArgb(53, 120, 229);
		F3359638.Cursor = Cursors.Hand;
		F3359638.FlatAppearance.BorderSize = 0;
		F3359638.FlatStyle = FlatStyle.Flat;
		F3359638.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F3359638.ForeColor = Color.White;
		F3359638.Location = new Point(77, 394);
		F3359638.Name = "btnAdd";
		F3359638.Size = new Size(92, 29);
		F3359638.TabIndex = 6;
		F3359638.Text = "Thêm";
		F3359638.UseVisualStyleBackColor = false;
		F3359638.Click += F3359638_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(CC29873D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(352, 37);
		bunifuCards1.TabIndex = 28;
		txtToCookie.Location = new Point(147, 375);
		txtToCookie.Name = "txtToCookie";
		txtToCookie.Size = new Size(178, 23);
		txtToCookie.TabIndex = 0;
		lblToCookie.AutoSize = true;
		lblToCookie.Location = new Point(27, 377);
		lblToCookie.Name = "lblToCookie";
		lblToCookie.Size = new Size(114, 16);
		lblToCookie.TabIndex = 31;
		lblToCookie.Text = "Cookie nhận page:";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(355, 438);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDTaoPage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += AB1D91BB;
		CC29873D.ResumeLayout(performLayout: false);
		((ISupportInitialize)DC13DB8D).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)F42F8F08).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
