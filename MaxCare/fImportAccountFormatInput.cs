using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportAccountFormatInput : Form
{
	private List<ComboBox> list_0;

	public string string_0 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button A83B6DAD;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl D9B91DAA;

	private PictureBox pictureBox1;

	private Panel panel1;

	private Panel D281C41E;

	private ComboBox FC8F7B17;

	private ComboBox cbbDinhDang2;

	private ComboBox FA01CA11;

	private ComboBox cbbDinhDang4;

	private Label B2897D95;

	private Label label18;

	private Label F693DD9B;

	private ComboBox D838A809;

	private Label label1;

	private ComboBox cbbDinhDang10;

	private Label label17;

	private ComboBox cbbDinhDang8;

	private Label label13;

	private ComboBox cbbDinhDang11;

	private ComboBox cbbDinhDang6;

	private ComboBox FC0B1983;

	private Label label12;

	private ComboBox cbbDinhDang7;

	private Label F3B1DA2B;

	private Label FC1E9C9A;

	private Label CBA32483;

	public fImportAccountFormatInput()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		method_0();
	}

	private void method_0()
	{
		list_0 = new List<ComboBox>
		{
			FC8F7B17, cbbDinhDang2, FA01CA11, cbbDinhDang4, D838A809, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, FC0B1983, cbbDinhDang10,
			cbbDinhDang11
		};
		foreach (ComboBox item in list_0)
		{
			Common.F714B10E(item, new List<string>
			{
				"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
				"Bạn bè", "Ngày tạo", "Mail khôi phục"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
	}

	private void C009BD29(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			string_0 = string_0 + list_0[i].Text + "|";
		}
		string_0 = string_0.TrimEnd('|');
		if (string_0 == "")
		{
			MessageBoxHelper.Show("Vui lòng chọn định dạng tài khoản!", 3);
		}
		else
		{
			Close();
		}
	}

	private void EA043D9A(object sender, EventArgs e)
	{
		Close();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportAccountFormatInput));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.A83B6DAD = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.D9B91DAA = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.panel1 = new System.Windows.Forms.Panel();
		this.D281C41E = new System.Windows.Forms.Panel();
		this.FC8F7B17 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		this.FA01CA11 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		this.B2897D95 = new System.Windows.Forms.Label();
		this.label18 = new System.Windows.Forms.Label();
		this.F693DD9B = new System.Windows.Forms.Label();
		this.D838A809 = new System.Windows.Forms.ComboBox();
		this.label1 = new System.Windows.Forms.Label();
		this.cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		this.label17 = new System.Windows.Forms.Label();
		this.cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		this.label13 = new System.Windows.Forms.Label();
		this.cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		this.cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		this.FC0B1983 = new System.Windows.Forms.ComboBox();
		this.label12 = new System.Windows.Forms.Label();
		this.cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		this.F3B1DA2B = new System.Windows.Forms.Label();
		this.FC1E9C9A = new System.Windows.Forms.Label();
		this.CBA32483 = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.D281C41E.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1044, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.A83B6DAD);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1043, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.A83B6DAD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A83B6DAD.Dock = System.Windows.Forms.DockStyle.Right;
		this.A83B6DAD.FlatAppearance.BorderSize = 0;
		this.A83B6DAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A83B6DAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A83B6DAD.ForeColor = System.Drawing.Color.White;
		this.A83B6DAD.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.A83B6DAD.Location = new System.Drawing.Point(1011, 0);
		this.A83B6DAD.Name = "btnMinimize";
		this.A83B6DAD.Size = new System.Drawing.Size(32, 32);
		this.A83B6DAD.TabIndex = 9;
		this.A83B6DAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A83B6DAD.UseVisualStyleBackColor = true;
		this.A83B6DAD.Click += new System.EventHandler(C009BD29);
		this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1043, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Thêm Định dạng nhập tài khoản";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(528, 106);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Hủy";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(EA043D9A);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(424, 106);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.D9B91DAA.Fixed = true;
		this.D9B91DAA.Horizontal = true;
		this.D9B91DAA.TargetControl = this.bunifuCustomLabel1;
		this.D9B91DAA.Vertical = true;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.D281C41E);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1045, 146);
		this.panel1.TabIndex = 48;
		this.D281C41E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D281C41E.Controls.Add(this.FC8F7B17);
		this.D281C41E.Controls.Add(this.cbbDinhDang2);
		this.D281C41E.Controls.Add(this.FA01CA11);
		this.D281C41E.Controls.Add(this.cbbDinhDang4);
		this.D281C41E.Controls.Add(this.B2897D95);
		this.D281C41E.Controls.Add(this.label18);
		this.D281C41E.Controls.Add(this.F693DD9B);
		this.D281C41E.Controls.Add(this.D838A809);
		this.D281C41E.Controls.Add(this.label1);
		this.D281C41E.Controls.Add(this.cbbDinhDang10);
		this.D281C41E.Controls.Add(this.label17);
		this.D281C41E.Controls.Add(this.cbbDinhDang8);
		this.D281C41E.Controls.Add(this.label13);
		this.D281C41E.Controls.Add(this.cbbDinhDang11);
		this.D281C41E.Controls.Add(this.cbbDinhDang6);
		this.D281C41E.Controls.Add(this.FC0B1983);
		this.D281C41E.Controls.Add(this.label12);
		this.D281C41E.Controls.Add(this.cbbDinhDang7);
		this.D281C41E.Controls.Add(this.F3B1DA2B);
		this.D281C41E.Controls.Add(this.FC1E9C9A);
		this.D281C41E.Controls.Add(this.CBA32483);
		this.D281C41E.Location = new System.Drawing.Point(11, 52);
		this.D281C41E.Name = "plDinhDangNhap";
		this.D281C41E.Size = new System.Drawing.Size(1019, 36);
		this.D281C41E.TabIndex = 47;
		this.FC8F7B17.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FC8F7B17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.FC8F7B17.DropDownWidth = 100;
		this.FC8F7B17.FormattingEnabled = true;
		this.FC8F7B17.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.FC8F7B17.Location = new System.Drawing.Point(4, 5);
		this.FC8F7B17.Name = "cbbDinhDang1";
		this.FC8F7B17.Size = new System.Drawing.Size(78, 24);
		this.FC8F7B17.TabIndex = 40;
		this.cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang2.DropDownWidth = 100;
		this.cbbDinhDang2.FormattingEnabled = true;
		this.cbbDinhDang2.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang2.Location = new System.Drawing.Point(97, 5);
		this.cbbDinhDang2.Name = "cbbDinhDang2";
		this.cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang2.TabIndex = 40;
		this.FA01CA11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FA01CA11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.FA01CA11.DropDownWidth = 100;
		this.FA01CA11.FormattingEnabled = true;
		this.FA01CA11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.FA01CA11.Location = new System.Drawing.Point(190, 5);
		this.FA01CA11.Name = "cbbDinhDang3";
		this.FA01CA11.Size = new System.Drawing.Size(78, 24);
		this.FA01CA11.TabIndex = 40;
		this.cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang4.DropDownWidth = 100;
		this.cbbDinhDang4.FormattingEnabled = true;
		this.cbbDinhDang4.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang4.Location = new System.Drawing.Point(283, 5);
		this.cbbDinhDang4.Name = "cbbDinhDang4";
		this.cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang4.TabIndex = 40;
		this.B2897D95.AutoSize = true;
		this.B2897D95.Font = new System.Drawing.Font("Tahoma", 12f);
		this.B2897D95.Location = new System.Drawing.Point(920, 5);
		this.B2897D95.Name = "label19";
		this.B2897D95.Size = new System.Drawing.Size(15, 19);
		this.B2897D95.TabIndex = 41;
		this.B2897D95.Text = "|";
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label18.Location = new System.Drawing.Point(733, 5);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(15, 19);
		this.label18.TabIndex = 41;
		this.label18.Text = "|";
		this.F693DD9B.AutoSize = true;
		this.F693DD9B.Font = new System.Drawing.Font("Tahoma", 12f);
		this.F693DD9B.Location = new System.Drawing.Point(547, 5);
		this.F693DD9B.Name = "label14";
		this.F693DD9B.Size = new System.Drawing.Size(15, 19);
		this.F693DD9B.TabIndex = 41;
		this.F693DD9B.Text = "|";
		this.D838A809.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D838A809.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.D838A809.DropDownWidth = 100;
		this.D838A809.FormattingEnabled = true;
		this.D838A809.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.D838A809.Location = new System.Drawing.Point(376, 5);
		this.D838A809.Name = "cbbDinhDang5";
		this.D838A809.Size = new System.Drawing.Size(78, 24);
		this.D838A809.TabIndex = 40;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label1.Location = new System.Drawing.Point(827, 7);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(15, 19);
		this.label1.TabIndex = 41;
		this.label1.Text = "|";
		this.cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang10.DropDownWidth = 100;
		this.cbbDinhDang10.FormattingEnabled = true;
		this.cbbDinhDang10.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang10.Location = new System.Drawing.Point(842, 5);
		this.cbbDinhDang10.Name = "cbbDinhDang10";
		this.cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang10.TabIndex = 40;
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label17.Location = new System.Drawing.Point(640, 5);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(15, 19);
		this.label17.TabIndex = 41;
		this.label17.Text = "|";
		this.cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang8.DropDownWidth = 100;
		this.cbbDinhDang8.FormattingEnabled = true;
		this.cbbDinhDang8.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang8.Location = new System.Drawing.Point(655, 5);
		this.cbbDinhDang8.Name = "cbbDinhDang8";
		this.cbbDinhDang8.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang8.TabIndex = 40;
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label13.Location = new System.Drawing.Point(454, 5);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(15, 19);
		this.label13.TabIndex = 41;
		this.label13.Text = "|";
		this.cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang11.DropDownWidth = 100;
		this.cbbDinhDang11.FormattingEnabled = true;
		this.cbbDinhDang11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang11.Location = new System.Drawing.Point(935, 5);
		this.cbbDinhDang11.Name = "cbbDinhDang11";
		this.cbbDinhDang11.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang11.TabIndex = 40;
		this.cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang6.DropDownWidth = 100;
		this.cbbDinhDang6.FormattingEnabled = true;
		this.cbbDinhDang6.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang6.Location = new System.Drawing.Point(469, 5);
		this.cbbDinhDang6.Name = "cbbDinhDang6";
		this.cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang6.TabIndex = 40;
		this.FC0B1983.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FC0B1983.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.FC0B1983.DropDownWidth = 100;
		this.FC0B1983.FormattingEnabled = true;
		this.FC0B1983.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.FC0B1983.Location = new System.Drawing.Point(748, 5);
		this.FC0B1983.Name = "cbbDinhDang9";
		this.FC0B1983.Size = new System.Drawing.Size(78, 24);
		this.FC0B1983.TabIndex = 40;
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Tahoma", 12f);
		this.label12.Location = new System.Drawing.Point(361, 5);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(15, 19);
		this.label12.TabIndex = 41;
		this.label12.Text = "|";
		this.cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbDinhDang7.DropDownWidth = 100;
		this.cbbDinhDang7.FormattingEnabled = true;
		this.cbbDinhDang7.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		this.cbbDinhDang7.Location = new System.Drawing.Point(562, 5);
		this.cbbDinhDang7.Name = "cbbDinhDang7";
		this.cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		this.cbbDinhDang7.TabIndex = 40;
		this.F3B1DA2B.AutoSize = true;
		this.F3B1DA2B.Font = new System.Drawing.Font("Tahoma", 12f);
		this.F3B1DA2B.Location = new System.Drawing.Point(268, 5);
		this.F3B1DA2B.Name = "label11";
		this.F3B1DA2B.Size = new System.Drawing.Size(15, 19);
		this.F3B1DA2B.TabIndex = 41;
		this.F3B1DA2B.Text = "|";
		this.FC1E9C9A.AutoSize = true;
		this.FC1E9C9A.Font = new System.Drawing.Font("Tahoma", 12f);
		this.FC1E9C9A.Location = new System.Drawing.Point(82, 5);
		this.FC1E9C9A.Name = "label9";
		this.FC1E9C9A.Size = new System.Drawing.Size(15, 19);
		this.FC1E9C9A.TabIndex = 41;
		this.FC1E9C9A.Text = "|";
		this.CBA32483.AutoSize = true;
		this.CBA32483.Font = new System.Drawing.Font("Tahoma", 12f);
		this.CBA32483.Location = new System.Drawing.Point(175, 5);
		this.CBA32483.Name = "label10";
		this.CBA32483.Size = new System.Drawing.Size(15, 19);
		this.CBA32483.TabIndex = 41;
		this.CBA32483.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1045, 146);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportAccountFormatInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.D281C41E.ResumeLayout(false);
		this.D281C41E.PerformLayout();
		base.ResumeLayout(false);
	}
}
