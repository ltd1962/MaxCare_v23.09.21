using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDMoiBanBeVaoNhom : Form
{
	private JObject jobject_0;

	private string string_0;

	private string A119500C;

	private string E527A6AD;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown CF35EB85;

	private TextBox txtTenHanhDong;

	private Label A3BAAA8E;

	private Label label4;

	private Label label2;

	private Label BBAAE50C;

	private Button BB0C2B07;

	private Button btnAdd;

	private BunifuCards D4A61513;

	private Panel D93A132C;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A5A2BE1B;

	private Label label8;

	private Label FF970C30;

	private RichTextBox A61A400D;

	private ToolTip toolTip_0;

	private RadioButton rbInviteSuggest;

	private RadioButton rbInviteRandom;

	private Label ADB8D51B;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label9;

	private Label label7;

	private Label label6;

	public fHDMoiBanBeVaoNhom(string string_1, int C1013401 = 0, string F71E4332 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_1;
		E527A6AD = F71E4332;
		int_0 = C1013401;
		string json = "";
		switch (C1013401)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDMoiBanBeVaoNhom");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			A119500C = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(F71E4332);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void E21D3F9B()
	{
		Language.smethod_0(A5A2BE1B);
		Language.smethod_0(BBAAE50C);
		Language.smethod_0(label2);
		Language.smethod_0(A3BAAA8E);
		Language.smethod_0(label4);
		Language.smethod_0(label6);
		Language.smethod_0(label9);
		Language.smethod_0(label7);
		Language.smethod_0(ADB8D51B);
		Language.smethod_0(rbInviteRandom);
		Language.smethod_0(rbInviteSuggest);
		Language.smethod_0(FF970C30);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(BB0C2B07);
	}

	private void fHDMoiBanBeVaoNhom_Load(object sender, EventArgs e)
	{
		try
		{
			if (Convert.ToInt32(jobject_0["typeInvite"]) == 0)
			{
				rbInviteRandom.Checked = true;
			}
			else
			{
				rbInviteSuggest.Checked = true;
			}
			CF35EB85.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			A61A400D.Text = jobject_0["txtUid"].ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D23FC031(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = A61A400D.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", CF35EB85.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtUid", A61A400D.Text.Trim());
		if (rbInviteRandom.Checked)
		{
			gClass.GetJson("typeInvite", 0);
		}
		else
		{
			gClass.GetJson("typeInvite", 1);
		}
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, A119500C, text2))
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
			if (InteractSQL.smethod_13(E527A6AD, text, text2))
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

	private void BB0C2B07_Click(object sender, EventArgs e)
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

	private void A61A400D_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = A61A400D.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			FF970C30.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid nhóm cần mơ\u0300i ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool E403778A)
	{
		if (E403778A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E403778A);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDMoiBanBeVaoNhom));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.A5A2BE1B = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D93A132C = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.rbInviteSuggest = new System.Windows.Forms.RadioButton();
		this.rbInviteRandom = new System.Windows.Forms.RadioButton();
		this.A61A400D = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.ADB8D51B = new System.Windows.Forms.Label();
		this.FF970C30 = new System.Windows.Forms.Label();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.CF35EB85 = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.A3BAAA8E = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.BBAAE50C = new System.Windows.Forms.Label();
		this.BB0C2B07 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.D4A61513 = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.D93A132C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CF35EB85).BeginInit();
		this.D4A61513.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.A5A2BE1B;
		this.bunifuDragControl_0.Vertical = true;
		this.A5A2BE1B.BackColor = System.Drawing.Color.Transparent;
		this.A5A2BE1B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.A5A2BE1B.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A5A2BE1B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A5A2BE1B.ForeColor = System.Drawing.Color.Black;
		this.A5A2BE1B.Location = new System.Drawing.Point(0, 0);
		this.A5A2BE1B.Name = "bunifuCustomLabel1";
		this.A5A2BE1B.Size = new System.Drawing.Size(359, 31);
		this.A5A2BE1B.TabIndex = 12;
		this.A5A2BE1B.Text = "Cấu hình Mời bạn bè vào nhóm";
		this.A5A2BE1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.D93A132C;
		this.bunifuDragControl_1.Vertical = true;
		this.D93A132C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D93A132C.BackColor = System.Drawing.Color.White;
		this.D93A132C.Controls.Add(this.button1);
		this.D93A132C.Controls.Add(this.pictureBox1);
		this.D93A132C.Controls.Add(this.A5A2BE1B);
		this.D93A132C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D93A132C.Location = new System.Drawing.Point(0, 3);
		this.D93A132C.Name = "pnlHeader";
		this.D93A132C.Size = new System.Drawing.Size(359, 31);
		this.D93A132C.TabIndex = 9;
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
		this.panel1.Controls.Add(this.rbInviteSuggest);
		this.panel1.Controls.Add(this.rbInviteRandom);
		this.panel1.Controls.Add(this.A61A400D);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.ADB8D51B);
		this.panel1.Controls.Add(this.FF970C30);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.CF35EB85);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.A3BAAA8E);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.BBAAE50C);
		this.panel1.Controls.Add(this.BB0C2B07);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.D4A61513);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 410);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.rbInviteSuggest.AutoSize = true;
		this.rbInviteSuggest.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbInviteSuggest.Location = new System.Drawing.Point(132, 161);
		this.rbInviteSuggest.Name = "rbInviteSuggest";
		this.rbInviteSuggest.Size = new System.Drawing.Size(135, 20);
		this.rbInviteSuggest.TabIndex = 115;
		this.rbInviteSuggest.Text = "Gợi ý của Facebook";
		this.rbInviteSuggest.UseVisualStyleBackColor = true;
		this.rbInviteRandom.AutoSize = true;
		this.rbInviteRandom.Checked = true;
		this.rbInviteRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbInviteRandom.Location = new System.Drawing.Point(132, 138);
		this.rbInviteRandom.Name = "rbInviteRandom";
		this.rbInviteRandom.Size = new System.Drawing.Size(112, 20);
		this.rbInviteRandom.TabIndex = 115;
		this.rbInviteRandom.TabStop = true;
		this.rbInviteRandom.Text = "Mời ngẫu nhiên";
		this.rbInviteRandom.UseVisualStyleBackColor = true;
		this.A61A400D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A61A400D.Location = new System.Drawing.Point(31, 203);
		this.A61A400D.Name = "txtUid";
		this.A61A400D.Size = new System.Drawing.Size(295, 136);
		this.A61A400D.TabIndex = 114;
		this.A61A400D.Text = "";
		this.A61A400D.WordWrap = false;
		this.A61A400D.TextChanged += new System.EventHandler(A61A400D_TextChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(28, 342);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(102, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi Uid 1 dòng)";
		this.ADB8D51B.AutoSize = true;
		this.ADB8D51B.Location = new System.Drawing.Point(27, 140);
		this.ADB8D51B.Name = "label5";
		this.ADB8D51B.Size = new System.Drawing.Size(89, 16);
		this.ADB8D51B.TabIndex = 0;
		this.ADB8D51B.Text = "Tùy chọn mời:";
		this.FF970C30.AutoSize = true;
		this.FF970C30.Location = new System.Drawing.Point(27, 183);
		this.FF970C30.Name = "lblStatus";
		this.FF970C30.Size = new System.Drawing.Size(199, 16);
		this.FF970C30.TabIndex = 0;
		this.FF970C30.Text = "Danh sa\u0301ch Uid nhóm cần mơ\u0300i (0):";
		this.nudDelayTo.Location = new System.Drawing.Point(229, 109);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 2;
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 109);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 1;
		this.CF35EB85.Location = new System.Drawing.Point(132, 80);
		this.CF35EB85.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CF35EB85.Name = "nudSoLuongFrom";
		this.CF35EB85.Size = new System.Drawing.Size(56, 23);
		this.CF35EB85.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label9.Location = new System.Drawing.Point(194, 111);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 37;
		this.label9.Text = "đê\u0301n";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A3BAAA8E.Location = new System.Drawing.Point(194, 82);
		this.A3BAAA8E.Name = "label3";
		this.A3BAAA8E.Size = new System.Drawing.Size(29, 16);
		this.A3BAAA8E.TabIndex = 37;
		this.A3BAAA8E.Text = "đê\u0301n";
		this.A3BAAA8E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(287, 111);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(30, 16);
		this.label7.TabIndex = 35;
		this.label7.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(27, 111);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(99, 16);
		this.label6.TabIndex = 32;
		this.label6.Text = "Thơ\u0300i gian delay:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng/nho\u0301m:";
		this.BBAAE50C.AutoSize = true;
		this.BBAAE50C.Location = new System.Drawing.Point(27, 52);
		this.BBAAE50C.Name = "label1";
		this.BBAAE50C.Size = new System.Drawing.Size(98, 16);
		this.BBAAE50C.TabIndex = 31;
		this.BBAAE50C.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.BB0C2B07.BackColor = System.Drawing.Color.Maroon;
		this.BB0C2B07.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB0C2B07.FlatAppearance.BorderSize = 0;
		this.BB0C2B07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BB0C2B07.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BB0C2B07.ForeColor = System.Drawing.Color.White;
		this.BB0C2B07.Location = new System.Drawing.Point(191, 370);
		this.BB0C2B07.Name = "btnCancel";
		this.BB0C2B07.Size = new System.Drawing.Size(92, 29);
		this.BB0C2B07.TabIndex = 7;
		this.BB0C2B07.Text = "Đóng";
		this.BB0C2B07.UseVisualStyleBackColor = false;
		this.BB0C2B07.Click += new System.EventHandler(BB0C2B07_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(80, 370);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(D23FC031);
		this.D4A61513.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D4A61513.BackColor = System.Drawing.Color.White;
		this.D4A61513.BorderRadius = 0;
		this.D4A61513.BottomSahddow = true;
		this.D4A61513.color = System.Drawing.Color.DarkViolet;
		this.D4A61513.Controls.Add(this.D93A132C);
		this.D4A61513.LeftSahddow = false;
		this.D4A61513.Location = new System.Drawing.Point(1, 0);
		this.D4A61513.Name = "bunifuCards1";
		this.D4A61513.RightSahddow = true;
		this.D4A61513.ShadowDepth = 20;
		this.D4A61513.Size = new System.Drawing.Size(359, 37);
		this.D4A61513.TabIndex = 28;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 0;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 0;
		this.toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 410);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDMoiBanBeVaoNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDMoiBanBeVaoNhom_Load);
		this.D93A132C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CF35EB85).EndInit();
		this.D4A61513.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
