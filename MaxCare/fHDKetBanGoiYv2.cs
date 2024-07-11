using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanGoiYv2 : Form
{
	private JSON_Settings gclass8_0;

	private string F53274AA;

	private string D13E9385;

	private string EA9D6813;

	private int int_0;

	public static bool bool_0;

	private IContainer E5AA9308 = null;

	private BunifuDragControl C0103093;

	private BunifuDragControl ED9C190B;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button CA0D0D92;

	private Button btnAdd;

	private BunifuCards BF0E979D;

	private Panel E8303B33;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel B5376D12;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label FE077781;

	private NumericUpDown A6B37584;

	private Label F1262390;

	private Label label8;

	private CheckBox D631D216;

	private CheckBox ckbOnlyAddFriendWithMutualFriends;

	public fHDKetBanGoiYv2(string string_0, int C697771A = 0, string CEBFA709 = "")
	{
		InitializeComponent();
		bool_0 = false;
		F53274AA = string_0;
		EA9D6813 = CEBFA709;
		int_0 = C697771A;
		if (InteractSQL.B484648C("", "HDKetBanGoiYv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanGoiYv2', 'Kết bạn theo gợi ý v2');");
		}
		string string_ = "";
		switch (C697771A)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanGoiYv2");
			string_ = dataTable2.Rows[0]["CauHinh"].ToString();
			D13E9385 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(CEBFA709);
			string_ = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(string_, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(B5376D12);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(FE077781);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(D631D216);
		Language.smethod_0(ckbOnlyAddFriendWithMutualFriends);
		Language.smethod_0(label8);
		Language.smethod_0(F1262390);
		Language.smethod_0(btnAdd);
		Language.smethod_0(CA0D0D92);
	}

	private void DD370595(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 2);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			D631D216.Checked = gclass8_0.GetValueBool("ckbChiKetBanTenCoDau");
			ckbOnlyAddFriendWithMutualFriends.Checked = gclass8_0.GetValueBool("ckbOnlyAddFriendWithMutualFriends");
			A6B37584.Value = gclass8_0.GetValueInt("nudTimesWarning", 3);
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
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbChiKetBanTenCoDau", D631D216.Checked);
		gClass.GetJson("ckbOnlyAddFriendWithMutualFriends", ckbOnlyAddFriendWithMutualFriends.Checked);
		gClass.GetJson("nudTimesWarning", A6B37584.Value);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(F53274AA, text, D13E9385, text2))
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
			if (InteractSQL.smethod_13(EA9D6813, text, text2))
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

	private void CA0D0D92_Click(object sender, EventArgs e)
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

	protected override void Dispose(bool E83CCBAD)
	{
		if (E83CCBAD && E5AA9308 != null)
		{
			E5AA9308.Dispose();
		}
		base.Dispose(E83CCBAD);
	}

	private void InitializeComponent()
	{
		this.E5AA9308 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanGoiYv2));
		this.C0103093 = new Bunifu.Framework.UI.BunifuDragControl(this.E5AA9308);
		this.B5376D12 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.ED9C190B = new Bunifu.Framework.UI.BunifuDragControl(this.E5AA9308);
		this.E8303B33 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbOnlyAddFriendWithMutualFriends = new System.Windows.Forms.CheckBox();
		this.D631D216 = new System.Windows.Forms.CheckBox();
		this.A6B37584 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.F1262390 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.FE077781 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.CA0D0D92 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.BF0E979D = new Bunifu.Framework.UI.BunifuCards();
		this.E8303B33.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.A6B37584).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.BF0E979D.SuspendLayout();
		base.SuspendLayout();
		this.C0103093.Fixed = true;
		this.C0103093.Horizontal = true;
		this.C0103093.TargetControl = this.B5376D12;
		this.C0103093.Vertical = true;
		this.B5376D12.BackColor = System.Drawing.Color.Transparent;
		this.B5376D12.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B5376D12.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B5376D12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B5376D12.ForeColor = System.Drawing.Color.Black;
		this.B5376D12.Location = new System.Drawing.Point(0, 0);
		this.B5376D12.Name = "bunifuCustomLabel1";
		this.B5376D12.Size = new System.Drawing.Size(359, 31);
		this.B5376D12.TabIndex = 12;
		this.B5376D12.Text = "Cấu hình Kết bạn gợi ý v2";
		this.B5376D12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ED9C190B.Fixed = true;
		this.ED9C190B.Horizontal = true;
		this.ED9C190B.TargetControl = this.E8303B33;
		this.ED9C190B.Vertical = true;
		this.E8303B33.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E8303B33.BackColor = System.Drawing.Color.White;
		this.E8303B33.Controls.Add(this.button1);
		this.E8303B33.Controls.Add(this.pictureBox1);
		this.E8303B33.Controls.Add(this.B5376D12);
		this.E8303B33.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.E8303B33.Location = new System.Drawing.Point(0, 3);
		this.E8303B33.Name = "pnlHeader";
		this.E8303B33.Size = new System.Drawing.Size(359, 31);
		this.E8303B33.TabIndex = 9;
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
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.ckbOnlyAddFriendWithMutualFriends);
		this.panel1.Controls.Add(this.D631D216);
		this.panel1.Controls.Add(this.A6B37584);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.F1262390);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.FE077781);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.CA0D0D92);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.BF0E979D);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 274);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.ckbOnlyAddFriendWithMutualFriends.AutoSize = true;
		this.ckbOnlyAddFriendWithMutualFriends.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyAddFriendWithMutualFriends.Location = new System.Drawing.Point(30, 167);
		this.ckbOnlyAddFriendWithMutualFriends.Name = "ckbOnlyAddFriendWithMutualFriends";
		this.ckbOnlyAddFriendWithMutualFriends.Size = new System.Drawing.Size(226, 20);
		this.ckbOnlyAddFriendWithMutualFriends.TabIndex = 47;
		this.ckbOnlyAddFriendWithMutualFriends.Text = "Chỉ kết bạn với người có bạn chung";
		this.ckbOnlyAddFriendWithMutualFriends.UseVisualStyleBackColor = true;
		this.D631D216.AutoSize = true;
		this.D631D216.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D631D216.Location = new System.Drawing.Point(30, 141);
		this.D631D216.Name = "ckbChiKetBanTenCoDau";
		this.D631D216.Size = new System.Drawing.Size(211, 20);
		this.D631D216.TabIndex = 47;
		this.D631D216.Text = "Chỉ kết bạn với người có tên Việt";
		this.D631D216.UseVisualStyleBackColor = true;
		this.A6B37584.Location = new System.Drawing.Point(253, 193);
		this.A6B37584.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A6B37584.Name = "nudTimesWarning";
		this.A6B37584.Size = new System.Drawing.Size(43, 23);
		this.A6B37584.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(229, 112);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.F1262390.AutoSize = true;
		this.F1262390.Location = new System.Drawing.Point(299, 195);
		this.F1262390.Name = "label9";
		this.F1262390.Size = new System.Drawing.Size(24, 16);
		this.F1262390.TabIndex = 45;
		this.F1262390.Text = "lần";
		this.label7.Location = new System.Drawing.Point(194, 114);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 114);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(27, 195);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(225, 16);
		this.label8.TabIndex = 44;
		this.label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		this.FE077781.AutoSize = true;
		this.FE077781.Location = new System.Drawing.Point(27, 114);
		this.FE077781.Name = "label5";
		this.FE077781.Size = new System.Drawing.Size(89, 16);
		this.FE077781.TabIndex = 44;
		this.FE077781.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 81);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 81);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 83);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 83);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 83);
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
		this.CA0D0D92.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.CA0D0D92.BackColor = System.Drawing.Color.Maroon;
		this.CA0D0D92.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CA0D0D92.FlatAppearance.BorderSize = 0;
		this.CA0D0D92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CA0D0D92.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CA0D0D92.ForeColor = System.Drawing.Color.White;
		this.CA0D0D92.Location = new System.Drawing.Point(187, 230);
		this.CA0D0D92.Name = "btnCancel";
		this.CA0D0D92.Size = new System.Drawing.Size(92, 29);
		this.CA0D0D92.TabIndex = 7;
		this.CA0D0D92.Text = "Đóng";
		this.CA0D0D92.UseVisualStyleBackColor = false;
		this.CA0D0D92.Click += new System.EventHandler(CA0D0D92_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(80, 230);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.BF0E979D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BF0E979D.BackColor = System.Drawing.Color.White;
		this.BF0E979D.BorderRadius = 0;
		this.BF0E979D.BottomSahddow = true;
		this.BF0E979D.color = System.Drawing.Color.DarkViolet;
		this.BF0E979D.Controls.Add(this.E8303B33);
		this.BF0E979D.LeftSahddow = false;
		this.BF0E979D.Location = new System.Drawing.Point(1, 0);
		this.BF0E979D.Name = "bunifuCards1";
		this.BF0E979D.RightSahddow = true;
		this.BF0E979D.ShadowDepth = 20;
		this.BF0E979D.Size = new System.Drawing.Size(359, 37);
		this.BF0E979D.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 274);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanGoiYv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DD370595);
		this.E8303B33.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.A6B37584).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.BF0E979D.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
