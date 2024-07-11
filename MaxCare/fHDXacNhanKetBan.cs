using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXacNhanKetBan : Form
{
	private JSON_Settings B69B7D13;

	private string string_0;

	private string F9BDFBBF;

	private string string_1;

	private int int_0;

	public static bool B12E03A4;

	private IContainer icontainer_0 = null;

	private BunifuDragControl AF957B00;

	private BunifuDragControl bunifuDragControl_0;

	private Panel D3A7CDAB;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox A1060BB2;

	private Label label3;

	private Label D6AC74A4;

	private Label label2;

	private Label label1;

	private Button E70A89BD;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown AA06B82D;

	private Label label7;

	private Label label6;

	private Label label5;

	private CheckBox C5065D25;

	private CheckBox ckbOnlyAddFriendWithMutualFriends;

	private NumericUpDown nudTimesWarning;

	private Label AA82FE1E;

	private Label label8;

	private CheckBox ckbAddFriendApi;

	public fHDXacNhanKetBan(string AAACAC84, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		B12E03A4 = false;
		string_0 = AAACAC84;
		string_1 = string_2;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXacNhanKetBan");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			F9BDFBBF = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A1060BB2.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A1060BB2.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B69B7D13 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(D6AC74A4);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(C5065D25);
		Language.smethod_0(ckbOnlyAddFriendWithMutualFriends);
		Language.smethod_0(btnAdd);
		Language.smethod_0(E70A89BD);
	}

	private void BC84E4B8(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = B69B7D13.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = B69B7D13.GetValueInt("nudSoLuongTo", 3);
			AA06B82D.Value = B69B7D13.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = B69B7D13.GetValueInt("nudDelayTo", 5);
			C5065D25.Checked = B69B7D13.GetValueBool("ckbChiKetBanTenCoDau");
			ckbOnlyAddFriendWithMutualFriends.Checked = B69B7D13.GetValueBool("ckbOnlyAddFriendWithMutualFriends");
			nudTimesWarning.Value = B69B7D13.GetValueInt("nudTimesWarning", 5);
			ckbAddFriendApi.Checked = B69B7D13.GetValueBool("ckbAddFriendApi");
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
		string text = A1060BB2.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", AA06B82D.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbChiKetBanTenCoDau", C5065D25.Checked);
		gClass.GetJson("ckbOnlyAddFriendWithMutualFriends", ckbOnlyAddFriendWithMutualFriends.Checked);
		gClass.GetJson("nudTimesWarning", nudTimesWarning.Value);
		gClass.GetJson("ckbAddFriendApi", ckbAddFriendApi.Checked);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, F9BDFBBF, string_))
				{
					B12E03A4 = true;
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
				B12E03A4 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F0174CBA(object sender, EventArgs e)
	{
		Close();
	}

	private void D3A7CDAB_Paint(object sender, PaintEventArgs e)
	{
		if (D3A7CDAB.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D3A7CDAB.ClientSize.Width - num, D3A7CDAB.ClientSize.Height - num));
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXacNhanKetBan));
		this.AF957B00 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.D3A7CDAB = new System.Windows.Forms.Panel();
		this.btnAdd = new System.Windows.Forms.Button();
		this.nudTimesWarning = new System.Windows.Forms.NumericUpDown();
		this.AA82FE1E = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.ckbOnlyAddFriendWithMutualFriends = new System.Windows.Forms.CheckBox();
		this.C5065D25 = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.AA06B82D = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.A1060BB2 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.D6AC74A4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.E70A89BD = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.ckbAddFriendApi = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.D3A7CDAB.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimesWarning).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.AA06B82D).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.AF957B00.Fixed = true;
		this.AF957B00.Horizontal = true;
		this.AF957B00.TargetControl = this.bunifuCustomLabel1;
		this.AF957B00.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Xác nhận kết bạn";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(328, 1);
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
		this.D3A7CDAB.BackColor = System.Drawing.Color.White;
		this.D3A7CDAB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D3A7CDAB.Controls.Add(this.btnAdd);
		this.D3A7CDAB.Controls.Add(this.nudTimesWarning);
		this.D3A7CDAB.Controls.Add(this.AA82FE1E);
		this.D3A7CDAB.Controls.Add(this.label8);
		this.D3A7CDAB.Controls.Add(this.ckbOnlyAddFriendWithMutualFriends);
		this.D3A7CDAB.Controls.Add(this.C5065D25);
		this.D3A7CDAB.Controls.Add(this.nudDelayTo);
		this.D3A7CDAB.Controls.Add(this.AA06B82D);
		this.D3A7CDAB.Controls.Add(this.label7);
		this.D3A7CDAB.Controls.Add(this.label6);
		this.D3A7CDAB.Controls.Add(this.label5);
		this.D3A7CDAB.Controls.Add(this.nudSoLuongTo);
		this.D3A7CDAB.Controls.Add(this.nudSoLuongFrom);
		this.D3A7CDAB.Controls.Add(this.A1060BB2);
		this.D3A7CDAB.Controls.Add(this.label3);
		this.D3A7CDAB.Controls.Add(this.D6AC74A4);
		this.D3A7CDAB.Controls.Add(this.label2);
		this.D3A7CDAB.Controls.Add(this.label1);
		this.D3A7CDAB.Controls.Add(this.E70A89BD);
		this.D3A7CDAB.Controls.Add(this.bunifuCards1);
		this.D3A7CDAB.Controls.Add(this.ckbAddFriendApi);
		this.D3A7CDAB.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.D3A7CDAB.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D3A7CDAB.Location = new System.Drawing.Point(0, 0);
		this.D3A7CDAB.Name = "panel1";
		this.D3A7CDAB.Size = new System.Drawing.Size(362, 272);
		this.D3A7CDAB.TabIndex = 0;
		this.D3A7CDAB.Paint += new System.Windows.Forms.PaintEventHandler(D3A7CDAB_Paint);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 228);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.nudTimesWarning.Location = new System.Drawing.Point(253, 183);
		this.nudTimesWarning.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimesWarning.Name = "nudTimesWarning";
		this.nudTimesWarning.Size = new System.Drawing.Size(43, 23);
		this.nudTimesWarning.TabIndex = 50;
		this.AA82FE1E.AutoSize = true;
		this.AA82FE1E.Location = new System.Drawing.Point(299, 185);
		this.AA82FE1E.Name = "label9";
		this.AA82FE1E.Size = new System.Drawing.Size(24, 16);
		this.AA82FE1E.TabIndex = 52;
		this.AA82FE1E.Text = "lần";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(27, 185);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(225, 16);
		this.label8.TabIndex = 51;
		this.label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		this.ckbOnlyAddFriendWithMutualFriends.AutoSize = true;
		this.ckbOnlyAddFriendWithMutualFriends.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyAddFriendWithMutualFriends.Location = new System.Drawing.Point(30, 160);
		this.ckbOnlyAddFriendWithMutualFriends.Name = "ckbOnlyAddFriendWithMutualFriends";
		this.ckbOnlyAddFriendWithMutualFriends.Size = new System.Drawing.Size(226, 20);
		this.ckbOnlyAddFriendWithMutualFriends.TabIndex = 49;
		this.ckbOnlyAddFriendWithMutualFriends.Text = "Chỉ kết bạn với người có bạn chung";
		this.ckbOnlyAddFriendWithMutualFriends.UseVisualStyleBackColor = true;
		this.C5065D25.AutoSize = true;
		this.C5065D25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C5065D25.Location = new System.Drawing.Point(30, 136);
		this.C5065D25.Name = "ckbChiKetBanTenCoDau";
		this.C5065D25.Size = new System.Drawing.Size(211, 20);
		this.C5065D25.TabIndex = 48;
		this.C5065D25.Text = "Chỉ kết bạn với người có tên Việt";
		this.C5065D25.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(229, 107);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.AA06B82D.Location = new System.Drawing.Point(132, 107);
		this.AA06B82D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.AA06B82D.Name = "nudDelayFrom";
		this.AA06B82D.Size = new System.Drawing.Size(56, 23);
		this.AA06B82D.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(194, 109);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 109);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.A1060BB2.Location = new System.Drawing.Point(132, 49);
		this.A1060BB2.Name = "txtTenHanhDong";
		this.A1060BB2.Size = new System.Drawing.Size(194, 23);
		this.A1060BB2.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D6AC74A4.AutoSize = true;
		this.D6AC74A4.Location = new System.Drawing.Point(287, 80);
		this.D6AC74A4.Name = "label4";
		this.D6AC74A4.Size = new System.Drawing.Size(28, 16);
		this.D6AC74A4.TabIndex = 35;
		this.D6AC74A4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 80);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.E70A89BD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.E70A89BD.BackColor = System.Drawing.Color.Maroon;
		this.E70A89BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E70A89BD.FlatAppearance.BorderSize = 0;
		this.E70A89BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E70A89BD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E70A89BD.ForeColor = System.Drawing.Color.White;
		this.E70A89BD.Location = new System.Drawing.Point(189, 228);
		this.E70A89BD.Name = "btnCancel";
		this.E70A89BD.Size = new System.Drawing.Size(92, 29);
		this.E70A89BD.TabIndex = 7;
		this.E70A89BD.Text = "Đóng";
		this.E70A89BD.UseVisualStyleBackColor = false;
		this.E70A89BD.Click += new System.EventHandler(F0174CBA);
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
		this.ckbAddFriendApi.AutoSize = true;
		this.ckbAddFriendApi.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddFriendApi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbAddFriendApi.Location = new System.Drawing.Point(30, 204);
		this.ckbAddFriendApi.Name = "ckbAddFriendApi";
		this.ckbAddFriendApi.Size = new System.Drawing.Size(99, 20);
		this.ckbAddFriendApi.TabIndex = 114;
		this.ckbAddFriendApi.Text = "Run API (ẩn)";
		this.ckbAddFriendApi.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 272);
		base.Controls.Add(this.D3A7CDAB);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXacNhanKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BC84E4B8);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.D3A7CDAB.ResumeLayout(false);
		this.D3A7CDAB.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimesWarning).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.AA06B82D).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
