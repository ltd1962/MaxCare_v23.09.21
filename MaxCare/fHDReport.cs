using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDReport : Form
{
	private JSON_Settings F08DC3AB;

	private string string_0;

	private string E30463A0;

	private string string_1;

	private int E513CC0D;

	public static bool D21E13B6;

	private IContainer E7A28F27 = null;

	private BunifuDragControl A09EC823;

	private BunifuDragControl bunifuDragControl_0;

	private Panel DCA25685;

	private NumericUpDown DA9136BA;

	private NumericUpDown nudSoLuongFrom;

	private TextBox A72A1680;

	private Label label3;

	private Label label4;

	private Label F82F0891;

	private Label label1;

	private Button F6B70180;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C0AABB91;

	private NumericUpDown DDBAB021;

	private NumericUpDown F4327909;

	private Label A034729B;

	private Label CBA5B68D;

	private Label B592DBBA;

	private CheckBox A5B1222A;

	private CheckBox C31397B4;

	private Label label9;

	private Panel BD0B0D0F;

	private CheckBox A6AE769D;

	private CheckBox ckbKhac;

	private CheckBox ckbNoiDungCam;

	private CheckBox DAA2633E;

	private CheckBox ckbXucPham;

	private CheckBox B1BDA235;

	private Label E6826293;

	private RichTextBox txtIdAds;

	public fHDReport(string string_2, int int_0 = 0, string string_3 = "")
	{
		A233EB1B();
		D21E13B6 = false;
		string_0 = string_2;
		string_1 = string_3;
		E513CC0D = int_0;
		if (InteractSQL.B484648C("", "HDReport").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDReport', 'Report');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDReport");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			E30463A0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A72A1680.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A72A1680.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F08DC3AB = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void DD9F8A3D()
	{
		Language.smethod_0(C0AABB91);
		Language.smethod_0(label1);
		Language.smethod_0(F82F0891);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(B592DBBA);
		Language.smethod_0(A034729B);
		Language.smethod_0(CBA5B68D);
		Language.smethod_0(A5B1222A);
		Language.smethod_0(C31397B4);
		Language.smethod_0(btnAdd);
		Language.smethod_0(F6B70180);
	}

	private void F18E4138(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = F08DC3AB.GetValueInt("nudSoLuongFrom", 1);
			DA9136BA.Value = F08DC3AB.GetValueInt("nudSoLuongTo", 1);
			F4327909.Value = F08DC3AB.GetValueInt("nudDelayFrom", 10);
			DDBAB021.Value = F08DC3AB.GetValueInt("nudDelayTo", 15);
			txtIdAds.Text = F08DC3AB.GetValue("txtIdAds");
			A5B1222A.Checked = F08DC3AB.GetValue("typeReport").Contains("1");
			C31397B4.Checked = F08DC3AB.GetValue("typeReport").Contains("2");
			ckbXucPham.Checked = F08DC3AB.GetValue("typeReport").Contains("3");
			B1BDA235.Checked = F08DC3AB.GetValue("typeReport").Contains("4");
			ckbNoiDungCam.Checked = F08DC3AB.GetValue("typeReport").Contains("5");
			DAA2633E.Checked = F08DC3AB.GetValue("typeReport").Contains("6");
			A6AE769D.Checked = F08DC3AB.GetValue("typeReport").Contains("7");
			ckbKhac.Checked = F08DC3AB.GetValue("typeReport").Contains("8");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = A72A1680.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", DA9136BA.Value);
		gClass.GetJson("nudDelayFrom", F4327909.Value);
		gClass.GetJson("nudDelayTo", DDBAB021.Value);
		gClass.GetJson("txtIdAds", txtIdAds.Text);
		List<int> list = new List<int>();
		if (A5B1222A.Checked)
		{
			list.Add(1);
		}
		if (C31397B4.Checked)
		{
			list.Add(2);
		}
		if (ckbXucPham.Checked)
		{
			list.Add(3);
		}
		if (B1BDA235.Checked)
		{
			list.Add(4);
		}
		if (ckbNoiDungCam.Checked)
		{
			list.Add(5);
		}
		if (DAA2633E.Checked)
		{
			list.Add(6);
		}
		if (A6AE769D.Checked)
		{
			list.Add(7);
		}
		if (ckbKhac.Checked)
		{
			list.Add(8);
		}
		gClass.GetJson("typeReport", string.Join("\n", list));
		string string_ = gClass.D9A09B34();
		if (E513CC0D == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, E30463A0, string_))
				{
					D21E13B6 = true;
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
				D21E13B6 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void B78B83AC(object sender, EventArgs e)
	{
		Close();
	}

	private void DCA25685_Paint(object sender, PaintEventArgs e)
	{
		if (DCA25685.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, DCA25685.ClientSize.Width - num, DCA25685.ClientSize.Height - num));
		}
	}

	private void txtIdAds_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtIdAds.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			E6826293.Text = string.Format(Language.GetValue("Danh sách ID ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool EABA1683)
	{
		if (EABA1683 && E7A28F27 != null)
		{
			E7A28F27.Dispose();
		}
		base.Dispose(EABA1683);
	}

	private void A233EB1B()
	{
		E7A28F27 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDReport));
		A09EC823 = new BunifuDragControl(E7A28F27);
		C0AABB91 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(E7A28F27);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		DCA25685 = new Panel();
		label9 = new Label();
		BD0B0D0F = new Panel();
		A6AE769D = new CheckBox();
		ckbKhac = new CheckBox();
		ckbNoiDungCam = new CheckBox();
		DAA2633E = new CheckBox();
		ckbXucPham = new CheckBox();
		B1BDA235 = new CheckBox();
		A5B1222A = new CheckBox();
		C31397B4 = new CheckBox();
		E6826293 = new Label();
		txtIdAds = new RichTextBox();
		DDBAB021 = new NumericUpDown();
		F4327909 = new NumericUpDown();
		A034729B = new Label();
		CBA5B68D = new Label();
		B592DBBA = new Label();
		DA9136BA = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		A72A1680 = new TextBox();
		label3 = new Label();
		label4 = new Label();
		F82F0891 = new Label();
		label1 = new Label();
		F6B70180 = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		DCA25685.SuspendLayout();
		BD0B0D0F.SuspendLayout();
		((ISupportInitialize)DDBAB021).BeginInit();
		((ISupportInitialize)F4327909).BeginInit();
		((ISupportInitialize)DA9136BA).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A09EC823.Fixed = true;
		A09EC823.Horizontal = true;
		A09EC823.TargetControl = C0AABB91;
		A09EC823.Vertical = true;
		C0AABB91.BackColor = Color.Transparent;
		C0AABB91.Cursor = Cursors.SizeAll;
		C0AABB91.Dock = DockStyle.Fill;
		C0AABB91.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C0AABB91.ForeColor = Color.Black;
		C0AABB91.Location = new Point(0, 0);
		C0AABB91.Name = "bunifuCustomLabel1";
		C0AABB91.Size = new Size(672, 31);
		C0AABB91.TabIndex = 12;
		C0AABB91.Text = "Cấu hình Report";
		C0AABB91.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(C0AABB91);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(672, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(641, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		DCA25685.BackColor = Color.White;
		DCA25685.BorderStyle = BorderStyle.FixedSingle;
		DCA25685.Controls.Add(label9);
		DCA25685.Controls.Add(BD0B0D0F);
		DCA25685.Controls.Add(E6826293);
		DCA25685.Controls.Add(txtIdAds);
		DCA25685.Controls.Add(DDBAB021);
		DCA25685.Controls.Add(F4327909);
		DCA25685.Controls.Add(A034729B);
		DCA25685.Controls.Add(CBA5B68D);
		DCA25685.Controls.Add(B592DBBA);
		DCA25685.Controls.Add(DA9136BA);
		DCA25685.Controls.Add(nudSoLuongFrom);
		DCA25685.Controls.Add(A72A1680);
		DCA25685.Controls.Add(label3);
		DCA25685.Controls.Add(label4);
		DCA25685.Controls.Add(F82F0891);
		DCA25685.Controls.Add(label1);
		DCA25685.Controls.Add(F6B70180);
		DCA25685.Controls.Add(btnAdd);
		DCA25685.Controls.Add(bunifuCards1);
		DCA25685.Cursor = Cursors.Arrow;
		DCA25685.Dock = DockStyle.Fill;
		DCA25685.Location = new Point(0, 0);
		DCA25685.Name = "panel1";
		DCA25685.Size = new Size(675, 454);
		DCA25685.TabIndex = 0;
		DCA25685.Paint += DCA25685_Paint;
		label9.AutoSize = true;
		label9.Location = new Point(347, 144);
		label9.Name = "label9";
		label9.Size = new Size(64, 16);
		label9.TabIndex = 51;
		label9.Text = "Tùy chọn:";
		BD0B0D0F.BorderStyle = BorderStyle.FixedSingle;
		BD0B0D0F.Controls.Add(A6AE769D);
		BD0B0D0F.Controls.Add(ckbKhac);
		BD0B0D0F.Controls.Add(ckbNoiDungCam);
		BD0B0D0F.Controls.Add(DAA2633E);
		BD0B0D0F.Controls.Add(ckbXucPham);
		BD0B0D0F.Controls.Add(B1BDA235);
		BD0B0D0F.Controls.Add(A5B1222A);
		BD0B0D0F.Controls.Add(C31397B4);
		BD0B0D0F.Location = new Point(364, 169);
		BD0B0D0F.Name = "panel2";
		BD0B0D0F.Size = new Size(246, 213);
		BD0B0D0F.TabIndex = 50;
		A6AE769D.AutoSize = true;
		A6AE769D.Cursor = Cursors.Hand;
		A6AE769D.Location = new Point(3, 159);
		A6AE769D.Name = "ckbTinGia";
		A6AE769D.Size = new Size(65, 20);
		A6AE769D.TabIndex = 52;
		A6AE769D.Text = "Tin giả";
		A6AE769D.UseVisualStyleBackColor = true;
		ckbKhac.AutoSize = true;
		ckbKhac.Cursor = Cursors.Hand;
		ckbKhac.Location = new Point(3, 185);
		ckbKhac.Name = "ckbKhac";
		ckbKhac.Size = new Size(53, 20);
		ckbKhac.TabIndex = 53;
		ckbKhac.Text = "Khác";
		ckbKhac.UseVisualStyleBackColor = true;
		ckbNoiDungCam.AutoSize = true;
		ckbNoiDungCam.Cursor = Cursors.Hand;
		ckbNoiDungCam.Location = new Point(3, 107);
		ckbNoiDungCam.Name = "ckbNoiDungCam";
		ckbNoiDungCam.Size = new Size(118, 20);
		ckbNoiDungCam.TabIndex = 50;
		ckbNoiDungCam.Text = "Nội dung bị cấm";
		ckbNoiDungCam.UseVisualStyleBackColor = true;
		DAA2633E.AutoSize = true;
		DAA2633E.Cursor = Cursors.Hand;
		DAA2633E.Location = new Point(3, 133);
		DAA2633E.Name = "ckbSpam";
		DAA2633E.Size = new Size(59, 20);
		DAA2633E.TabIndex = 51;
		DAA2633E.Text = "Spam";
		DAA2633E.UseVisualStyleBackColor = true;
		ckbXucPham.AutoSize = true;
		ckbXucPham.Cursor = Cursors.Hand;
		ckbXucPham.Location = new Point(3, 55);
		ckbXucPham.Name = "ckbXucPham";
		ckbXucPham.Size = new Size(83, 20);
		ckbXucPham.TabIndex = 48;
		ckbXucPham.Text = "Xúc phạm";
		ckbXucPham.UseVisualStyleBackColor = true;
		B1BDA235.AutoSize = true;
		B1BDA235.Cursor = Cursors.Hand;
		B1BDA235.Location = new Point(3, 81);
		B1BDA235.Name = "ckbBaoLuc";
		B1BDA235.Size = new Size(68, 20);
		B1BDA235.TabIndex = 49;
		B1BDA235.Text = "Bạo lực";
		B1BDA235.UseVisualStyleBackColor = true;
		A5B1222A.AutoSize = true;
		A5B1222A.Cursor = Cursors.Hand;
		A5B1222A.Location = new Point(3, 3);
		A5B1222A.Name = "ckbLuaDao";
		A5B1222A.Size = new Size(189, 20);
		A5B1222A.TabIndex = 47;
		A5B1222A.Text = "Gây hiểu nhầm hoặc lừa đảo";
		A5B1222A.UseVisualStyleBackColor = true;
		C31397B4.AutoSize = true;
		C31397B4.Cursor = Cursors.Hand;
		C31397B4.Location = new Point(3, 29);
		C31397B4.Name = "ckbTinhDuc";
		C31397B4.Size = new Size(208, 20);
		C31397B4.TabIndex = 47;
		C31397B4.Text = "Thiếu đứng đắn về mặt tình dục";
		C31397B4.UseVisualStyleBackColor = true;
		E6826293.AutoSize = true;
		E6826293.Location = new Point(27, 150);
		E6826293.Name = "label8";
		E6826293.Size = new Size(108, 16);
		E6826293.TabIndex = 49;
		E6826293.Text = "Danh sách ID (0):";
		txtIdAds.Location = new Point(30, 169);
		txtIdAds.Name = "txtIdAds";
		txtIdAds.Size = new Size(276, 213);
		txtIdAds.TabIndex = 48;
		txtIdAds.Text = "";
		txtIdAds.TextChanged += txtIdAds_TextChanged;
		DDBAB021.Location = new Point(229, 112);
		DDBAB021.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DDBAB021.Name = "nudDelayTo";
		DDBAB021.Size = new Size(56, 23);
		DDBAB021.TabIndex = 4;
		F4327909.Location = new Point(132, 112);
		F4327909.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F4327909.Name = "nudDelayFrom";
		F4327909.Size = new Size(56, 23);
		F4327909.TabIndex = 3;
		A034729B.Location = new Point(194, 114);
		A034729B.Name = "label7";
		A034729B.Size = new Size(29, 16);
		A034729B.TabIndex = 46;
		A034729B.Text = "đê\u0301n";
		A034729B.TextAlign = ContentAlignment.MiddleCenter;
		CBA5B68D.AutoSize = true;
		CBA5B68D.Location = new Point(287, 114);
		CBA5B68D.Name = "label6";
		CBA5B68D.Size = new Size(30, 16);
		CBA5B68D.TabIndex = 45;
		CBA5B68D.Text = "giây";
		B592DBBA.AutoSize = true;
		B592DBBA.Location = new Point(27, 114);
		B592DBBA.Name = "label5";
		B592DBBA.Size = new Size(89, 16);
		B592DBBA.TabIndex = 44;
		B592DBBA.Text = "Thơ\u0300i gian chơ\u0300:";
		DA9136BA.Location = new Point(229, 81);
		DA9136BA.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DA9136BA.Name = "nudSoLuongTo";
		DA9136BA.Size = new Size(56, 23);
		DA9136BA.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 81);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		A72A1680.Location = new Point(132, 49);
		A72A1680.Name = "txtTenHanhDong";
		A72A1680.Size = new Size(194, 23);
		A72A1680.TabIndex = 0;
		label3.Location = new Point(194, 83);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new Point(287, 83);
		label4.Name = "label4";
		label4.Size = new Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		F82F0891.AutoSize = true;
		F82F0891.Location = new Point(27, 83);
		F82F0891.Name = "label2";
		F82F0891.Size = new Size(63, 16);
		F82F0891.TabIndex = 32;
		F82F0891.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		F6B70180.Anchor = AnchorStyles.Bottom;
		F6B70180.BackColor = Color.Maroon;
		F6B70180.Cursor = Cursors.Hand;
		F6B70180.FlatAppearance.BorderSize = 0;
		F6B70180.FlatStyle = FlatStyle.Flat;
		F6B70180.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F6B70180.ForeColor = Color.White;
		F6B70180.Location = new Point(343, 416);
		F6B70180.Name = "btnCancel";
		F6B70180.Size = new Size(92, 29);
		F6B70180.TabIndex = 7;
		F6B70180.Text = "Đóng";
		F6B70180.UseVisualStyleBackColor = false;
		F6B70180.Click += B78B83AC;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(236, 416);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
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
		bunifuCards1.Size = new Size(672, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(675, 454);
		base.Controls.Add(DCA25685);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDReport";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += F18E4138;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		DCA25685.ResumeLayout(performLayout: false);
		DCA25685.PerformLayout();
		BD0B0D0F.ResumeLayout(performLayout: false);
		BD0B0D0F.PerformLayout();
		((ISupportInitialize)DDBAB021).EndInit();
		((ISupportInitialize)F4327909).EndInit();
		((ISupportInitialize)DA9136BA).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
