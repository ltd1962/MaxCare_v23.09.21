using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDThamGiaNhomUidv2 : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string C03F7F8C;

	private int int_0;

	public static bool bool_0;

	private IContainer F18F8B1B = null;

	private BunifuDragControl D91AB00C;

	private BunifuDragControl F2BC8806;

	private Panel BB376302;

	private NumericUpDown F6078FAD;

	private NumericUpDown FB3FADB0;

	private TextBox D8AA0F36;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label AF87B106;

	private Button B537091F;

	private Button D4135DBE;

	private BunifuCards bunifuCards1;

	private Panel FD0EABA5;

	private Button button1;

	private PictureBox CAA9F32B;

	private BunifuCustomLabel B0A2F10D;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown D4B5F8A3;

	private Label label7;

	private Label label6;

	private Label D69D9603;

	private RichTextBox txtUid;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip E8A4CA0D;

	private Panel plTuongTac;

	private CheckBox ckbTuDongTraLoiCauHoi;

	private TextBox C0801736;

	private Label lblStatusComment;

	private Label D9255F82;

	private CheckBox A6B3BA83;

	private Panel E290C9A4;

	private NumericUpDown nudCountPageTo;

	private NumericUpDown nudCountPageFrom;

	private Label label10;

	private Label C6170C9D;

	private Label label12;

	private Label label8;

	private ComboBox cbbCountPage;

	private Panel plCountPage;

	public fHDThamGiaNhomUidv2(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		C03F7F8C = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tham gia nhóm theo tệp UID v2";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D8AA0F36.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			D4135DBE.Text = "Câ\u0323p nhâ\u0323t";
			D8AA0F36.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDThamGiaNhomUidv2_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			FB3FADB0.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			F6078FAD.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			D4B5F8A3.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			txtUid.Text = gclass8_0.GetValue("txtUid");
			ckbTuDongTraLoiCauHoi.Checked = gclass8_0.GetValueBool("ckbTuDongTraLoiCauHoi");
			ckbTuDongXoaUid.Checked = gclass8_0.GetValueBool("ckbTuDongXoaUid");
			C0801736.Text = gclass8_0.GetValue("txtCauTraLoi");
			A6B3BA83.Checked = gclass8_0.GetValueBool("ckbUsePagePro5");
			cbbCountPage.SelectedIndex = gclass8_0.GetValueInt("cbbCountPage");
			nudCountPageFrom.Value = gclass8_0.GetValueInt("nudCountPageFrom", 1);
			nudCountPageTo.Value = gclass8_0.GetValueInt("nudCountPageTo", 1);
		}
		catch
		{
		}
		E28910A4();
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Sử dụng tất cả page", "Sử dụng ngẫu nhiên page" };
		Common.F714B10E(cbbCountPage, e6A5AC);
	}

	private void E28910A4()
	{
		B69B3F07(null, null);
		F8002B83(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E614C6BC(object sender, EventArgs e)
	{
		string text = D8AA0F36.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
		{
			a2AB53A = C0801736.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", FB3FADB0.Value);
		gClass.GetJson("nudSoLuongTo", F6078FAD.Value);
		gClass.GetJson("nudDelayFrom", D4B5F8A3.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.GetJson("txtCauTraLoi", C0801736.Text.Trim());
		gClass.GetJson("ckbUsePagePro5", A6B3BA83.Checked);
		gClass.GetJson("cbbCountPage", cbbCountPage.SelectedIndex);
		gClass.GetJson("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.GetJson("nudCountPageTo", nudCountPageTo.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBox.Show("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?", "Thông ba\u0301o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
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
		else if (MessageBox.Show("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?", "Thông ba\u0301o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(C03F7F8C, text, string_))
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

	private void B537091F_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BB376302_Paint(object sender, PaintEventArgs e)
	{
		if (BB376302.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BB376302.ClientSize.Width - num, BB376302.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = "Danh sa\u0301ch Uid nhóm cần tham gia (" + a2AB53A.Count + "):";
		}
		catch
		{
		}
	}

	private void CB30F4B5(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = C0801736.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatusComment.Text = "Danh sách câu trả lời (" + a2AB53A.Count + "):";
		}
		catch
		{
		}
	}

	private void B69B3F07(object sender, EventArgs e)
	{
		plTuongTac.Enabled = ckbTuDongTraLoiCauHoi.Checked;
	}

	private void lblStatus_Click(object sender, EventArgs e)
	{
	}

	private void F8002B83(object sender, EventArgs e)
	{
		E290C9A4.Enabled = A6B3BA83.Checked;
	}

	private void cbbCountPage_SelectedIndexChanged(object sender, EventArgs e)
	{
		plCountPage.Enabled = cbbCountPage.SelectedIndex == 1;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F18F8B1B != null)
		{
			F18F8B1B.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F18F8B1B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDThamGiaNhomUidv2));
		this.D91AB00C = new Bunifu.Framework.UI.BunifuDragControl(this.F18F8B1B);
		this.B0A2F10D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F2BC8806 = new Bunifu.Framework.UI.BunifuDragControl(this.F18F8B1B);
		this.FD0EABA5 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.CAA9F32B = new System.Windows.Forms.PictureBox();
		this.BB376302 = new System.Windows.Forms.Panel();
		this.A6B3BA83 = new System.Windows.Forms.CheckBox();
		this.E290C9A4 = new System.Windows.Forms.Panel();
		this.plCountPage = new System.Windows.Forms.Panel();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		this.C6170C9D = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.cbbCountPage = new System.Windows.Forms.ComboBox();
		this.plTuongTac = new System.Windows.Forms.Panel();
		this.D9255F82 = new System.Windows.Forms.Label();
		this.C0801736 = new System.Windows.Forms.TextBox();
		this.lblStatusComment = new System.Windows.Forms.Label();
		this.ckbTuDongTraLoiCauHoi = new System.Windows.Forms.CheckBox();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.lblStatus = new System.Windows.Forms.Label();
		this.D4B5F8A3 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.D69D9603 = new System.Windows.Forms.Label();
		this.F6078FAD = new System.Windows.Forms.NumericUpDown();
		this.FB3FADB0 = new System.Windows.Forms.NumericUpDown();
		this.D8AA0F36 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.AF87B106 = new System.Windows.Forms.Label();
		this.B537091F = new System.Windows.Forms.Button();
		this.D4135DBE = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.E8A4CA0D = new System.Windows.Forms.ToolTip(this.F18F8B1B);
		this.FD0EABA5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CAA9F32B).BeginInit();
		this.BB376302.SuspendLayout();
		this.E290C9A4.SuspendLayout();
		this.plCountPage.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
		this.plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D4B5F8A3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F6078FAD).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FB3FADB0).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.D91AB00C.Fixed = true;
		this.D91AB00C.Horizontal = true;
		this.D91AB00C.TargetControl = this.B0A2F10D;
		this.D91AB00C.Vertical = true;
		this.B0A2F10D.BackColor = System.Drawing.Color.Transparent;
		this.B0A2F10D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B0A2F10D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B0A2F10D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B0A2F10D.ForeColor = System.Drawing.Color.Black;
		this.B0A2F10D.Location = new System.Drawing.Point(0, 0);
		this.B0A2F10D.Name = "bunifuCustomLabel1";
		this.B0A2F10D.Size = new System.Drawing.Size(687, 31);
		this.B0A2F10D.TabIndex = 12;
		this.B0A2F10D.Text = "Cấu hình Tham gia nhóm theo tệp UID";
		this.B0A2F10D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F2BC8806.Fixed = true;
		this.F2BC8806.Horizontal = true;
		this.F2BC8806.TargetControl = this.FD0EABA5;
		this.F2BC8806.Vertical = true;
		this.FD0EABA5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.FD0EABA5.BackColor = System.Drawing.Color.White;
		this.FD0EABA5.Controls.Add(this.button1);
		this.FD0EABA5.Controls.Add(this.CAA9F32B);
		this.FD0EABA5.Controls.Add(this.B0A2F10D);
		this.FD0EABA5.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.FD0EABA5.Location = new System.Drawing.Point(0, 3);
		this.FD0EABA5.Name = "pnlHeader";
		this.FD0EABA5.Size = new System.Drawing.Size(687, 31);
		this.FD0EABA5.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(656, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.CAA9F32B.Cursor = System.Windows.Forms.Cursors.Default;
		this.CAA9F32B.Image = Resources.Bitmap_4;
		this.CAA9F32B.Location = new System.Drawing.Point(3, 2);
		this.CAA9F32B.Name = "pictureBox1";
		this.CAA9F32B.Size = new System.Drawing.Size(34, 27);
		this.CAA9F32B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.CAA9F32B.TabIndex = 76;
		this.CAA9F32B.TabStop = false;
		this.BB376302.BackColor = System.Drawing.Color.White;
		this.BB376302.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BB376302.Controls.Add(this.A6B3BA83);
		this.BB376302.Controls.Add(this.E290C9A4);
		this.BB376302.Controls.Add(this.plTuongTac);
		this.BB376302.Controls.Add(this.ckbTuDongTraLoiCauHoi);
		this.BB376302.Controls.Add(this.txtUid);
		this.BB376302.Controls.Add(this.ckbTuDongXoaUid);
		this.BB376302.Controls.Add(this.nudDelayTo);
		this.BB376302.Controls.Add(this.lblStatus);
		this.BB376302.Controls.Add(this.D4B5F8A3);
		this.BB376302.Controls.Add(this.label7);
		this.BB376302.Controls.Add(this.label6);
		this.BB376302.Controls.Add(this.D69D9603);
		this.BB376302.Controls.Add(this.F6078FAD);
		this.BB376302.Controls.Add(this.FB3FADB0);
		this.BB376302.Controls.Add(this.D8AA0F36);
		this.BB376302.Controls.Add(this.label3);
		this.BB376302.Controls.Add(this.label4);
		this.BB376302.Controls.Add(this.label2);
		this.BB376302.Controls.Add(this.AF87B106);
		this.BB376302.Controls.Add(this.B537091F);
		this.BB376302.Controls.Add(this.D4135DBE);
		this.BB376302.Controls.Add(this.bunifuCards1);
		this.BB376302.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.BB376302.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BB376302.Location = new System.Drawing.Point(0, 0);
		this.BB376302.Name = "panel1";
		this.BB376302.Size = new System.Drawing.Size(690, 403);
		this.BB376302.TabIndex = 0;
		this.BB376302.Paint += new System.Windows.Forms.PaintEventHandler(BB376302_Paint);
		this.A6B3BA83.AutoSize = true;
		this.A6B3BA83.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A6B3BA83.Location = new System.Drawing.Point(30, 446);
		this.A6B3BA83.Name = "ckbUsePagePro5";
		this.A6B3BA83.Size = new System.Drawing.Size(146, 20);
		this.A6B3BA83.TabIndex = 118;
		this.A6B3BA83.Text = "Sử dụng Page profile";
		this.A6B3BA83.UseVisualStyleBackColor = true;
		this.A6B3BA83.CheckedChanged += new System.EventHandler(F8002B83);
		this.E290C9A4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.E290C9A4.Controls.Add(this.plCountPage);
		this.E290C9A4.Controls.Add(this.label8);
		this.E290C9A4.Controls.Add(this.cbbCountPage);
		this.E290C9A4.Location = new System.Drawing.Point(48, 469);
		this.E290C9A4.Name = "plUsePagePro5";
		this.E290C9A4.Size = new System.Drawing.Size(278, 62);
		this.E290C9A4.TabIndex = 117;
		this.plCountPage.Controls.Add(this.nudCountPageTo);
		this.plCountPage.Controls.Add(this.label12);
		this.plCountPage.Controls.Add(this.nudCountPageFrom);
		this.plCountPage.Controls.Add(this.C6170C9D);
		this.plCountPage.Controls.Add(this.label10);
		this.plCountPage.Location = new System.Drawing.Point(-1, 30);
		this.plCountPage.Name = "plCountPage";
		this.plCountPage.Size = new System.Drawing.Size(274, 27);
		this.plCountPage.TabIndex = 119;
		this.nudCountPageTo.Location = new System.Drawing.Point(157, 2);
		this.nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageTo.Name = "nudCountPageTo";
		this.nudCountPageTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageTo.TabIndex = 39;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 4);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(63, 16);
		this.label12.TabIndex = 40;
		this.label12.Text = "Sô\u0301 lươ\u0323ng:";
		this.nudCountPageFrom.Location = new System.Drawing.Point(73, 2);
		this.nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageFrom.Name = "nudCountPageFrom";
		this.nudCountPageFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageFrom.TabIndex = 38;
		this.C6170C9D.AutoSize = true;
		this.C6170C9D.Location = new System.Drawing.Point(216, 4);
		this.C6170C9D.Name = "label11";
		this.C6170C9D.Size = new System.Drawing.Size(35, 16);
		this.C6170C9D.TabIndex = 41;
		this.C6170C9D.Text = "page";
		this.label10.AutoSize = true;
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(134, 4);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(18, 16);
		this.label10.TabIndex = 42;
		this.label10.Text = ">";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(3, 7);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(64, 16);
		this.label8.TabIndex = 1;
		this.label8.Text = "Tùy chọn:";
		this.cbbCountPage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbCountPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbCountPage.FormattingEnabled = true;
		this.cbbCountPage.Location = new System.Drawing.Point(73, 4);
		this.cbbCountPage.Name = "cbbCountPage";
		this.cbbCountPage.Size = new System.Drawing.Size(200, 24);
		this.cbbCountPage.TabIndex = 0;
		this.cbbCountPage.SelectedIndexChanged += new System.EventHandler(cbbCountPage_SelectedIndexChanged);
		this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTac.Controls.Add(this.D9255F82);
		this.plTuongTac.Controls.Add(this.C0801736);
		this.plTuongTac.Controls.Add(this.lblStatusComment);
		this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTac.Location = new System.Drawing.Point(48, 162);
		this.plTuongTac.Name = "plTuongTac";
		this.plTuongTac.Size = new System.Drawing.Size(278, 179);
		this.plTuongTac.TabIndex = 116;
		this.D9255F82.AutoSize = true;
		this.D9255F82.Location = new System.Drawing.Point(3, 156);
		this.D9255F82.Name = "label9";
		this.D9255F82.Size = new System.Drawing.Size(265, 16);
		this.D9255F82.TabIndex = 2;
		this.D9255F82.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.C0801736.Location = new System.Drawing.Point(6, 25);
		this.C0801736.Multiline = true;
		this.C0801736.Name = "txtCauTraLoi";
		this.C0801736.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.C0801736.Size = new System.Drawing.Size(265, 128);
		this.C0801736.TabIndex = 1;
		this.C0801736.WordWrap = false;
		this.C0801736.TextChanged += new System.EventHandler(CB30F4B5);
		this.lblStatusComment.AutoSize = true;
		this.lblStatusComment.Location = new System.Drawing.Point(3, 4);
		this.lblStatusComment.Name = "lblStatusComment";
		this.lblStatusComment.Size = new System.Drawing.Size(153, 16);
		this.lblStatusComment.TabIndex = 0;
		this.lblStatusComment.Text = "Danh sách câu trả lời (0):";
		this.ckbTuDongTraLoiCauHoi.AutoSize = true;
		this.ckbTuDongTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongTraLoiCauHoi.Location = new System.Drawing.Point(30, 139);
		this.ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		this.ckbTuDongTraLoiCauHoi.Size = new System.Drawing.Size(156, 20);
		this.ckbTuDongTraLoiCauHoi.TabIndex = 115;
		this.ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		this.ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		this.ckbTuDongTraLoiCauHoi.CheckedChanged += new System.EventHandler(B69B3F07);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(356, 72);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(295, 246);
		this.txtUid.TabIndex = 114;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(355, 324);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(298, 20);
		this.ckbTuDongXoaUid.TabIndex = 113;
		this.ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid nho\u0301m đa\u0303 gư\u0309i yêu câ\u0300u tham gia";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(352, 52);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(228, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Uid nhóm cần tham gia (0):";
		this.lblStatus.Click += new System.EventHandler(lblStatus_Click);
		this.D4B5F8A3.Location = new System.Drawing.Point(132, 111);
		this.D4B5F8A3.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D4B5F8A3.Name = "nudDelayFrom";
		this.D4B5F8A3.Size = new System.Drawing.Size(56, 23);
		this.D4B5F8A3.TabIndex = 3;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(194, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(28, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.D69D9603.AutoSize = true;
		this.D69D9603.Location = new System.Drawing.Point(27, 113);
		this.D69D9603.Name = "label5";
		this.D69D9603.Size = new System.Drawing.Size(89, 16);
		this.D69D9603.TabIndex = 44;
		this.D69D9603.Text = "Thơ\u0300i gian chơ\u0300:";
		this.F6078FAD.Location = new System.Drawing.Point(229, 80);
		this.F6078FAD.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F6078FAD.Name = "nudSoLuongTo";
		this.F6078FAD.Size = new System.Drawing.Size(56, 23);
		this.F6078FAD.TabIndex = 2;
		this.FB3FADB0.Location = new System.Drawing.Point(132, 80);
		this.FB3FADB0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FB3FADB0.Name = "nudSoLuongFrom";
		this.FB3FADB0.Size = new System.Drawing.Size(56, 23);
		this.FB3FADB0.TabIndex = 1;
		this.D8AA0F36.Location = new System.Drawing.Point(132, 49);
		this.D8AA0F36.Name = "txtTenHanhDong";
		this.D8AA0F36.Size = new System.Drawing.Size(194, 23);
		this.D8AA0F36.TabIndex = 0;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(28, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(39, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "nhóm";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng:";
		this.AF87B106.AutoSize = true;
		this.AF87B106.Location = new System.Drawing.Point(27, 52);
		this.AF87B106.Name = "label1";
		this.AF87B106.Size = new System.Drawing.Size(98, 16);
		this.AF87B106.TabIndex = 31;
		this.AF87B106.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.B537091F.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.B537091F.BackColor = System.Drawing.Color.Maroon;
		this.B537091F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B537091F.FlatAppearance.BorderSize = 0;
		this.B537091F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B537091F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B537091F.ForeColor = System.Drawing.Color.White;
		this.B537091F.Location = new System.Drawing.Point(355, 360);
		this.B537091F.Name = "btnCancel";
		this.B537091F.Size = new System.Drawing.Size(92, 29);
		this.B537091F.TabIndex = 7;
		this.B537091F.Text = "Đóng";
		this.B537091F.UseVisualStyleBackColor = false;
		this.B537091F.Click += new System.EventHandler(B537091F_Click);
		this.D4135DBE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D4135DBE.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.D4135DBE.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D4135DBE.FlatAppearance.BorderSize = 0;
		this.D4135DBE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D4135DBE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D4135DBE.ForeColor = System.Drawing.Color.White;
		this.D4135DBE.Location = new System.Drawing.Point(248, 360);
		this.D4135DBE.Name = "btnAdd";
		this.D4135DBE.Size = new System.Drawing.Size(92, 29);
		this.D4135DBE.TabIndex = 6;
		this.D4135DBE.Text = "Thêm";
		this.D4135DBE.UseVisualStyleBackColor = false;
		this.D4135DBE.Click += new System.EventHandler(E614C6BC);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.FD0EABA5);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(687, 37);
		this.bunifuCards1.TabIndex = 28;
		this.E8A4CA0D.AutomaticDelay = 0;
		this.E8A4CA0D.AutoPopDelay = 0;
		this.E8A4CA0D.InitialDelay = 0;
		this.E8A4CA0D.ReshowDelay = 0;
		this.E8A4CA0D.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(690, 403);
		base.Controls.Add(this.BB376302);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomUidv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDThamGiaNhomUidv2_Load);
		this.FD0EABA5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.CAA9F32B).EndInit();
		this.BB376302.ResumeLayout(false);
		this.BB376302.PerformLayout();
		this.E290C9A4.ResumeLayout(false);
		this.E290C9A4.PerformLayout();
		this.plCountPage.ResumeLayout(false);
		this.plCountPage.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
		this.plTuongTac.ResumeLayout(false);
		this.plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D4B5F8A3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F6078FAD).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FB3FADB0).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
