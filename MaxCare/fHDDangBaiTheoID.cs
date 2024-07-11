using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDDangBaiTheoID : Form
{
	private JSON_Settings F62D3487;

	private string FB36BD8A;

	private string string_0;

	private string string_1;

	private int C9A8901D;

	public static bool bool_0;

	private List<string> list_0 = new List<string>();

	private IContainer A6B3AA12 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button A0B3068B;

	private Button btnAdd;

	private BunifuCards C0BE0F2B;

	private Panel F181429E;

	private Button button1;

	private PictureBox F1861910;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown F7966589;

	private NumericUpDown nudDelayFrom;

	private Label label20;

	private Label label19;

	private Label label15;

	private GroupBox F6210B29;

	private Panel plDangBaiLenPage;

	private Label DE1A6730;

	private Label DEA53913;

	private NumericUpDown B4ABE282;

	private Label E4217C3B;

	private NumericUpDown C087083A;

	private Panel plDangBaiLenNhom;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown nudCountGroupFrom;

	private Label label24;

	private Label C0396702;

	private Label A40F7D2F;

	private CheckBox ckbDangBaiLenNhom;

	private CheckBox ckbDangBaiLenTuong;

	private CheckBox ckbOnlyDangNhomKhongKiemDuyet;

	private CheckBox ckbDelete;

	private Label label2;

	private CheckBox ckbDangBaiLenPage;

	private Panel B9AAE488;

	private Button F800B91A;

	private RadioButton rbNhomTuNhap;

	private RadioButton rbNgauNhienNhomThamGia;

	private Label label27;

	private RichTextBox txtIdPost;

	public fHDDangBaiTheoID(string A10ED5BB, int E41DA3AD = 0, string D62BE490 = "")
	{
		BDAEE411();
		bool_0 = false;
		FB36BD8A = A10ED5BB;
		string_1 = D62BE490;
		C9A8901D = E41DA3AD;
		string text = base.Name.Substring(1);
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', 'Đăng bài clone ID');");
		}
		string text2 = "";
		switch (E41DA3AD)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text2 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(D62BE490);
			text2 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F62D3487 = new JSON_Settings(text2, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label15);
		Language.smethod_0(label20);
		Language.smethod_0(label19);
		Language.smethod_0(F6210B29);
		Language.smethod_0(ckbDangBaiLenTuong);
		Language.smethod_0(ckbDangBaiLenNhom);
		Language.smethod_0(A40F7D2F);
		Language.smethod_0(label24);
		Language.smethod_0(C0396702);
		Language.smethod_0(ckbOnlyDangNhomKhongKiemDuyet);
		Language.smethod_0(ckbDangBaiLenPage);
		Language.smethod_0(DE1A6730);
		Language.smethod_0(E4217C3B);
		Language.smethod_0(DEA53913);
		Language.smethod_0(btnAdd);
		Language.smethod_0(A0B3068B);
	}

	private void E3130D01(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = F62D3487.GetValueInt("nudDelayFrom", 3);
			F7966589.Value = F62D3487.GetValueInt("nudDelayTo", 5);
			ckbDangBaiLenTuong.Checked = F62D3487.GetValueBool("ckbDangBaiLenTuong");
			ckbDangBaiLenNhom.Checked = F62D3487.GetValueBool("ckbDangBaiLenNhom");
			if (F62D3487.GetValueInt("typePost") == 0)
			{
				rbNgauNhienNhomThamGia.Checked = true;
			}
			else
			{
				rbNhomTuNhap.Checked = true;
			}
			list_0 = F62D3487.GetValueList("lstNhomTuNhap");
			ckbOnlyDangNhomKhongKiemDuyet.Checked = F62D3487.GetValueBool("ckbOnlyDangNhomKhongKiemDuyet");
			nudCountGroupFrom.Value = F62D3487.GetValueInt("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = F62D3487.GetValueInt("nudCountGroupTo", 1);
			ckbDangBaiLenPage.Checked = F62D3487.GetValueBool("ckbDangBaiLenPage");
			C087083A.Value = F62D3487.GetValueInt("nudCountPageFrom", 1);
			B4ABE282.Value = F62D3487.GetValueInt("nudCountPageTo", 1);
			txtIdPost.Text = F62D3487.GetValue("txtIdPost");
			ckbDelete.Checked = F62D3487.GetValueBool("ckbDelete");
		}
		catch (Exception)
		{
		}
		method_1();
	}

	private void button1_Click(object sender, EventArgs e)
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
		if (txtIdPost.Text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p id post cần clone!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", F7966589.Value);
		gClass.GetJson("ckbDangBaiLenTuong", ckbDangBaiLenTuong.Checked);
		gClass.GetJson("ckbDangBaiLenNhom", ckbDangBaiLenNhom.Checked);
		int num = 0;
		if (rbNhomTuNhap.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typePost", num);
		gClass.method_5("lstNhomTuNhap", list_0);
		gClass.GetJson("ckbOnlyDangNhomKhongKiemDuyet", ckbOnlyDangNhomKhongKiemDuyet.Checked);
		gClass.GetJson("nudCountGroupFrom", nudCountGroupFrom.Value);
		gClass.GetJson("nudCountGroupTo", nudCountGroupTo.Value);
		gClass.GetJson("ckbDangBaiLenPage", ckbDangBaiLenPage.Checked);
		gClass.GetJson("nudCountPageFrom", C087083A.Value);
		gClass.GetJson("nudCountPageTo", B4ABE282.Value);
		gClass.GetJson("txtIdPost", txtIdPost.Text.Trim());
		gClass.GetJson("ckbDelete", ckbDelete.Checked);
		string string_ = gClass.D9A09B34();
		if (C9A8901D == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(FB36BD8A, text, string_0, string_))
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

	private void DE3DD09E(object sender, EventArgs e)
	{
		Close();
	}

	private void ABAF01A5(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		ckbDangBaiLenNhom_CheckedChanged(null, null);
		DB3ADA09(null, null);
		rbNhomTuNhap_CheckedChanged(null, null);
	}

	private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = ckbDangBaiLenNhom.Checked;
	}

	private void DB3ADA09(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbDangBaiLenPage.Checked;
	}

	private void F800B91A_Click(object sender, EventArgs e)
	{
		string text = Guid.NewGuid().ToString() + ".txt";
		Common.ShowForm(new fNhapDuLieu1(text, "Nhâ\u0323p danh sa\u0301ch ID nho\u0301m", "Danh sa\u0301ch ID nho\u0301m", "(Mô\u0303i nô\u0323i dung 1 do\u0300ng)", list_0));
		list_0 = File.ReadAllLines(text).ToList();
		try
		{
			File.Delete(text);
		}
		catch
		{
		}
	}

	private void rbNhomTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		F800B91A.Enabled = rbNhomTuNhap.Checked;
	}

	protected override void Dispose(bool A408C69E)
	{
		if (A408C69E && A6B3AA12 != null)
		{
			A6B3AA12.Dispose();
		}
		base.Dispose(A408C69E);
	}

	private void BDAEE411()
	{
		A6B3AA12 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDangBaiTheoID));
		bunifuDragControl_0 = new BunifuDragControl(A6B3AA12);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(A6B3AA12);
		F181429E = new Panel();
		F1861910 = new PictureBox();
		button1 = new Button();
		panel1 = new Panel();
		txtIdPost = new RichTextBox();
		ckbDelete = new CheckBox();
		label2 = new Label();
		F6210B29 = new GroupBox();
		plDangBaiLenPage = new Panel();
		DE1A6730 = new Label();
		DEA53913 = new Label();
		B4ABE282 = new NumericUpDown();
		E4217C3B = new Label();
		C087083A = new NumericUpDown();
		plDangBaiLenNhom = new Panel();
		B9AAE488 = new Panel();
		F800B91A = new Button();
		rbNhomTuNhap = new RadioButton();
		rbNgauNhienNhomThamGia = new RadioButton();
		label27 = new Label();
		ckbOnlyDangNhomKhongKiemDuyet = new CheckBox();
		nudCountGroupTo = new NumericUpDown();
		nudCountGroupFrom = new NumericUpDown();
		label24 = new Label();
		C0396702 = new Label();
		A40F7D2F = new Label();
		ckbDangBaiLenPage = new CheckBox();
		ckbDangBaiLenNhom = new CheckBox();
		ckbDangBaiLenTuong = new CheckBox();
		F7966589 = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label20 = new Label();
		label19 = new Label();
		label15 = new Label();
		btnAdd = new Button();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		A0B3068B = new Button();
		C0BE0F2B = new BunifuCards();
		F181429E.SuspendLayout();
		((ISupportInitialize)F1861910).BeginInit();
		panel1.SuspendLayout();
		F6210B29.SuspendLayout();
		plDangBaiLenPage.SuspendLayout();
		((ISupportInitialize)B4ABE282).BeginInit();
		((ISupportInitialize)C087083A).BeginInit();
		plDangBaiLenNhom.SuspendLayout();
		B9AAE488.SuspendLayout();
		((ISupportInitialize)nudCountGroupTo).BeginInit();
		((ISupportInitialize)nudCountGroupFrom).BeginInit();
		((ISupportInitialize)F7966589).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		C0BE0F2B.SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(372, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng bài theo ID";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = F181429E;
		bunifuDragControl_1.Vertical = true;
		F181429E.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F181429E.BackColor = Color.White;
		F181429E.Controls.Add(F1861910);
		F181429E.Controls.Add(bunifuCustomLabel1);
		F181429E.Cursor = Cursors.SizeAll;
		F181429E.Location = new Point(0, 3);
		F181429E.Name = "pnlHeader";
		F181429E.Size = new Size(372, 31);
		F181429E.TabIndex = 9;
		F1861910.Cursor = Cursors.Default;
		F1861910.Image = Resources.Bitmap_4;
		F1861910.Location = new Point(3, 2);
		F1861910.Name = "pictureBox1";
		F1861910.Size = new Size(34, 27);
		F1861910.SizeMode = PictureBoxSizeMode.Zoom;
		F1861910.TabIndex = 76;
		F1861910.TabStop = false;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(342, 5);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(txtIdPost);
		panel1.Controls.Add(ckbDelete);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(F6210B29);
		panel1.Controls.Add(F7966589);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(A0B3068B);
		panel1.Controls.Add(C0BE0F2B);
		panel1.Cursor = Cursors.Arrow;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(377, 642);
		panel1.TabIndex = 0;
		panel1.Paint += ABAF01A5;
		txtIdPost.Location = new Point(13, 406);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new Size(348, 155);
		txtIdPost.TabIndex = 66;
		txtIdPost.Text = "";
		ckbDelete.AutoSize = true;
		ckbDelete.Cursor = Cursors.Hand;
		ckbDelete.Location = new Point(13, 567);
		ckbDelete.Name = "ckbDelete";
		ckbDelete.Size = new Size(140, 20);
		ckbDelete.TabIndex = 65;
		ckbDelete.Text = "Tự động xóa id post";
		ckbDelete.UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		label2.Location = new Point(11, 387);
		label2.Name = "label2";
		label2.Size = new Size(115, 16);
		label2.TabIndex = 64;
		label2.Text = "Danh sách ID post:";
		F6210B29.Controls.Add(plDangBaiLenPage);
		F6210B29.Controls.Add(plDangBaiLenNhom);
		F6210B29.Controls.Add(ckbDangBaiLenPage);
		F6210B29.Controls.Add(ckbDangBaiLenNhom);
		F6210B29.Controls.Add(ckbDangBaiLenTuong);
		F6210B29.Location = new Point(14, 107);
		F6210B29.Name = "groupBox2";
		F6210B29.Size = new Size(347, 277);
		F6210B29.TabIndex = 62;
		F6210B29.TabStop = false;
		F6210B29.Text = "Tùy chọn đăng";
		plDangBaiLenPage.BorderStyle = BorderStyle.FixedSingle;
		plDangBaiLenPage.Controls.Add(DE1A6730);
		plDangBaiLenPage.Controls.Add(DEA53913);
		plDangBaiLenPage.Controls.Add(B4ABE282);
		plDangBaiLenPage.Controls.Add(E4217C3B);
		plDangBaiLenPage.Controls.Add(C087083A);
		plDangBaiLenPage.Location = new Point(25, 243);
		plDangBaiLenPage.Name = "plDangBaiLenPage";
		plDangBaiLenPage.Size = new Size(310, 27);
		plDangBaiLenPage.TabIndex = 1;
		DE1A6730.AutoSize = true;
		DE1A6730.Location = new Point(3, 3);
		DE1A6730.Name = "label21";
		DE1A6730.Size = new Size(95, 16);
		DE1A6730.TabIndex = 49;
		DE1A6730.Text = "Số lượng page:";
		DEA53913.AutoSize = true;
		DEA53913.Location = new Point(261, 3);
		DEA53913.Name = "label22";
		DEA53913.Size = new Size(35, 16);
		DEA53913.TabIndex = 50;
		DEA53913.Text = "page";
		B4ABE282.Location = new Point(205, 1);
		B4ABE282.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B4ABE282.Name = "nudCountPageTo";
		B4ABE282.Size = new Size(56, 23);
		B4ABE282.TabIndex = 48;
		E4217C3B.Location = new Point(170, 3);
		E4217C3B.Name = "label23";
		E4217C3B.Size = new Size(29, 16);
		E4217C3B.TabIndex = 51;
		E4217C3B.Text = "đê\u0301n";
		E4217C3B.TextAlign = ContentAlignment.MiddleCenter;
		C087083A.Location = new Point(108, 1);
		C087083A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C087083A.Name = "nudCountPageFrom";
		C087083A.Size = new Size(56, 23);
		C087083A.TabIndex = 47;
		plDangBaiLenNhom.BorderStyle = BorderStyle.FixedSingle;
		plDangBaiLenNhom.Controls.Add(B9AAE488);
		plDangBaiLenNhom.Controls.Add(label27);
		plDangBaiLenNhom.Controls.Add(ckbOnlyDangNhomKhongKiemDuyet);
		plDangBaiLenNhom.Controls.Add(nudCountGroupTo);
		plDangBaiLenNhom.Controls.Add(nudCountGroupFrom);
		plDangBaiLenNhom.Controls.Add(label24);
		plDangBaiLenNhom.Controls.Add(C0396702);
		plDangBaiLenNhom.Controls.Add(A40F7D2F);
		plDangBaiLenNhom.Location = new Point(25, 80);
		plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		plDangBaiLenNhom.Size = new Size(310, 131);
		plDangBaiLenNhom.TabIndex = 1;
		B9AAE488.BorderStyle = BorderStyle.FixedSingle;
		B9AAE488.Controls.Add(F800B91A);
		B9AAE488.Controls.Add(rbNhomTuNhap);
		B9AAE488.Controls.Add(rbNgauNhienNhomThamGia);
		B9AAE488.Location = new Point(20, 54);
		B9AAE488.Name = "panel4";
		B9AAE488.Size = new Size(285, 50);
		B9AAE488.TabIndex = 57;
		F800B91A.Cursor = Cursors.Hand;
		F800B91A.Location = new Point(205, 23);
		F800B91A.Name = "btnNhapNhom";
		F800B91A.Size = new Size(75, 23);
		F800B91A.TabIndex = 1;
		F800B91A.Text = "Nhâ\u0323p";
		F800B91A.Click += F800B91A_Click;
		rbNhomTuNhap.AutoSize = true;
		rbNhomTuNhap.Cursor = Cursors.Hand;
		rbNhomTuNhap.Location = new Point(4, 25);
		rbNhomTuNhap.Name = "rbNhomTuNhap";
		rbNhomTuNhap.Size = new Size(176, 20);
		rbNhomTuNhap.TabIndex = 0;
		rbNhomTuNhap.Text = "Nho\u0301m do ngươ\u0300i du\u0300ng nhâ\u0323p";
		rbNhomTuNhap.UseVisualStyleBackColor = true;
		rbNhomTuNhap.CheckedChanged += rbNhomTuNhap_CheckedChanged;
		rbNgauNhienNhomThamGia.AutoSize = true;
		rbNgauNhienNhomThamGia.Checked = true;
		rbNgauNhienNhomThamGia.Cursor = Cursors.Hand;
		rbNgauNhienNhomThamGia.Location = new Point(4, 3);
		rbNgauNhienNhomThamGia.Name = "rbNgauNhienNhomThamGia";
		rbNgauNhienNhomThamGia.Size = new Size(197, 20);
		rbNgauNhienNhomThamGia.TabIndex = 0;
		rbNgauNhienNhomThamGia.TabStop = true;
		rbNgauNhienNhomThamGia.Text = "Ngâ\u0303u nhiên nho\u0301m đa\u0303 tham gia";
		rbNgauNhienNhomThamGia.UseVisualStyleBackColor = true;
		label27.AutoSize = true;
		label27.Location = new Point(4, 35);
		label27.Name = "label27";
		label27.Size = new Size(154, 16);
		label27.TabIndex = 58;
		label27.Text = "Tu\u0300y cho\u0323n nho\u0301m đê\u0309 share:";
		ckbOnlyDangNhomKhongKiemDuyet.AutoSize = true;
		ckbOnlyDangNhomKhongKiemDuyet.Cursor = Cursors.Hand;
		ckbOnlyDangNhomKhongKiemDuyet.Location = new Point(7, 110);
		ckbOnlyDangNhomKhongKiemDuyet.Name = "ckbOnlyDangNhomKhongKiemDuyet";
		ckbOnlyDangNhomKhongKiemDuyet.Size = new Size(216, 20);
		ckbOnlyDangNhomKhongKiemDuyet.TabIndex = 2;
		ckbOnlyDangNhomKhongKiemDuyet.Text = "Chỉ đăng nhóm không kiểm duyệt";
		ckbOnlyDangNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		nudCountGroupTo.Location = new Point(205, 5);
		nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupTo.Name = "nudCountGroupTo";
		nudCountGroupTo.Size = new Size(56, 23);
		nudCountGroupTo.TabIndex = 53;
		nudCountGroupFrom.Location = new Point(108, 5);
		nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupFrom.Name = "nudCountGroupFrom";
		nudCountGroupFrom.Size = new Size(56, 23);
		nudCountGroupFrom.TabIndex = 52;
		label24.Location = new Point(170, 7);
		label24.Name = "label24";
		label24.Size = new Size(29, 16);
		label24.TabIndex = 56;
		label24.Text = "đê\u0301n";
		label24.TextAlign = ContentAlignment.MiddleCenter;
		C0396702.AutoSize = true;
		C0396702.Location = new Point(261, 7);
		C0396702.Name = "label25";
		C0396702.Size = new Size(39, 16);
		C0396702.TabIndex = 55;
		C0396702.Text = "nhóm";
		A40F7D2F.AutoSize = true;
		A40F7D2F.Location = new Point(3, 7);
		A40F7D2F.Name = "label26";
		A40F7D2F.Size = new Size(99, 16);
		A40F7D2F.TabIndex = 54;
		A40F7D2F.Text = "Số lượng nhóm:";
		ckbDangBaiLenPage.AutoSize = true;
		ckbDangBaiLenPage.Cursor = Cursors.Hand;
		ckbDangBaiLenPage.Location = new Point(11, 217);
		ckbDangBaiLenPage.Name = "ckbDangBaiLenPage";
		ckbDangBaiLenPage.Size = new Size(130, 20);
		ckbDangBaiLenPage.TabIndex = 0;
		ckbDangBaiLenPage.Text = "Đăng bài lên page";
		ckbDangBaiLenPage.UseVisualStyleBackColor = true;
		ckbDangBaiLenPage.CheckedChanged += DB3ADA09;
		ckbDangBaiLenNhom.AutoSize = true;
		ckbDangBaiLenNhom.Cursor = Cursors.Hand;
		ckbDangBaiLenNhom.Location = new Point(11, 54);
		ckbDangBaiLenNhom.Name = "ckbDangBaiLenNhom";
		ckbDangBaiLenNhom.Size = new Size(134, 20);
		ckbDangBaiLenNhom.TabIndex = 0;
		ckbDangBaiLenNhom.Text = "Đăng bài lên nhóm";
		ckbDangBaiLenNhom.UseVisualStyleBackColor = true;
		ckbDangBaiLenNhom.CheckedChanged += ckbDangBaiLenNhom_CheckedChanged;
		ckbDangBaiLenTuong.AutoSize = true;
		ckbDangBaiLenTuong.Cursor = Cursors.Hand;
		ckbDangBaiLenTuong.Location = new Point(11, 23);
		ckbDangBaiLenTuong.Name = "ckbDangBaiLenTuong";
		ckbDangBaiLenTuong.Size = new Size(135, 20);
		ckbDangBaiLenTuong.TabIndex = 0;
		ckbDangBaiLenTuong.Text = "Đăng bài lên tường";
		ckbDangBaiLenTuong.UseVisualStyleBackColor = true;
		F7966589.Location = new Point(222, 79);
		F7966589.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F7966589.Name = "nudDelayTo";
		F7966589.Size = new Size(58, 23);
		F7966589.TabIndex = 58;
		nudDelayFrom.Location = new Point(125, 79);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(58, 23);
		nudDelayFrom.TabIndex = 57;
		label20.Location = new Point(187, 81);
		label20.Name = "label20";
		label20.Size = new Size(31, 16);
		label20.TabIndex = 61;
		label20.Text = "đê\u0301n";
		label20.TextAlign = ContentAlignment.MiddleCenter;
		label19.Anchor = AnchorStyles.Left;
		label19.AutoSize = true;
		label19.Location = new Point(286, 81);
		label19.Name = "label19";
		label19.Size = new Size(30, 16);
		label19.TabIndex = 60;
		label19.Text = "giây";
		label15.AutoSize = true;
		label15.Location = new Point(11, 81);
		label15.Name = "label15";
		label15.Size = new Size(116, 16);
		label15.TabIndex = 59;
		label15.Text = "Khoảng cách đăng:";
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(92, 600);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		txtTenHanhDong.Location = new Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(195, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(11, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		A0B3068B.Anchor = AnchorStyles.Bottom;
		A0B3068B.BackColor = Color.Maroon;
		A0B3068B.Cursor = Cursors.Hand;
		A0B3068B.FlatAppearance.BorderSize = 0;
		A0B3068B.FlatStyle = FlatStyle.Flat;
		A0B3068B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A0B3068B.ForeColor = Color.White;
		A0B3068B.Location = new Point(191, 600);
		A0B3068B.Name = "btnCancel";
		A0B3068B.Size = new Size(92, 29);
		A0B3068B.TabIndex = 4;
		A0B3068B.Text = "Đóng";
		A0B3068B.UseVisualStyleBackColor = false;
		A0B3068B.Click += DE3DD09E;
		C0BE0F2B.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C0BE0F2B.BackColor = Color.White;
		C0BE0F2B.BorderRadius = 0;
		C0BE0F2B.BottomSahddow = true;
		C0BE0F2B.color = Color.DarkViolet;
		C0BE0F2B.Controls.Add(button1);
		C0BE0F2B.Controls.Add(F181429E);
		C0BE0F2B.LeftSahddow = false;
		C0BE0F2B.Location = new Point(1, 0);
		C0BE0F2B.Name = "bunifuCards1";
		C0BE0F2B.RightSahddow = true;
		C0BE0F2B.ShadowDepth = 20;
		C0BE0F2B.Size = new Size(375, 37);
		C0BE0F2B.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(377, 642);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDangBaiTheoID";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += E3130D01;
		F181429E.ResumeLayout(performLayout: false);
		((ISupportInitialize)F1861910).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		F6210B29.ResumeLayout(performLayout: false);
		F6210B29.PerformLayout();
		plDangBaiLenPage.ResumeLayout(performLayout: false);
		plDangBaiLenPage.PerformLayout();
		((ISupportInitialize)B4ABE282).EndInit();
		((ISupportInitialize)C087083A).EndInit();
		plDangBaiLenNhom.ResumeLayout(performLayout: false);
		plDangBaiLenNhom.PerformLayout();
		B9AAE488.ResumeLayout(performLayout: false);
		B9AAE488.PerformLayout();
		((ISupportInitialize)nudCountGroupTo).EndInit();
		((ISupportInitialize)nudCountGroupFrom).EndInit();
		((ISupportInitialize)F7966589).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		C0BE0F2B.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
