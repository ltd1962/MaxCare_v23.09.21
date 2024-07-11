using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDTuongTacLivestream : Form
{
	private JSON_Settings D5364C8E;

	private List<CheckBox> list_0;

	private string C0229D28;

	private string string_0;

	private string AD3CBEAA;

	private int F4A189BC;

	public static bool B084CCB0;

	private IContainer A80D96B4 = null;

	private BunifuDragControl C387C190;

	private BunifuDragControl BABD2716;

	private Panel panel1;

	private NumericUpDown nudTimeTo;

	private NumericUpDown A8003B9F;

	private TextBox txtTenHanhDong;

	private Label DB2A6534;

	private Label C6B8BC88;

	private Label label1;

	private Button btnCancel;

	private Button F911AC87;

	private BunifuCards CB9BC424;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private CheckBox C8A0A6A2;

	private CheckBox F42C0E29;

	private NumericUpDown nudLapLaiTuongTacDelayTo;

	private Label D5A19599;

	private NumericUpDown nudLapLaiTuongTacDelayFrom;

	private Label label6;

	private TextBox txtLinkVideo;

	private Label FFBF3601;

	private CheckBox ckbTuDongXoaNoiDung;

	private Panel F9932F04;

	private CheckBox ckbGian;

	private CheckBox B9B6370E;

	private CheckBox B9BE009F;

	private CheckBox ckbHaha;

	private CheckBox E73952BE;

	private CheckBox ckbTym;

	private CheckBox AC833F0D;

	private Panel panel7;

	private RadioButton E0880CBF;

	private RadioButton radioButton4;

	private Label CEA303B0;

	private RichTextBox txtComment;

	private Label label11;

	private Label lblComment;

	private Panel plLapLaiTuongTac;

	private Panel panel3;

	private RadioButton C43E520A;

	private RadioButton radioButton2;

	private CheckBox ckbLapLaiTuongTacInteract;

	private CheckBox ckbLapLaiTuongTacComment;

	private Label A79DB513;

	private CheckBox ckbLapLaiTuongTac;

	public fHDTuongTacLivestream(string string_1, int FE3BE6A0 = 0, string string_2 = "")
	{
		InitializeComponent();
		B084CCB0 = false;
		C0229D28 = string_1;
		AD3CBEAA = string_2;
		F4A189BC = FE3BE6A0;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác Livestream";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (FE3BE6A0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			F911AC87.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D5364C8E = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
		list_0 = new List<CheckBox> { AC833F0D, ckbTym, E73952BE, ckbHaha, B9BE009F, B9B6370E, ckbGian };
	}

	private void fHDTuongTacLivestream_Load(object sender, EventArgs e)
	{
		try
		{
			txtLinkVideo.Text = D5364C8E.GetValue("txtLinkVideo");
			A8003B9F.Value = D5364C8E.GetValueInt("nudTimeFrom", 30);
			nudTimeTo.Value = D5364C8E.GetValueInt("nudTimeTo", 30);
			F42C0E29.Checked = D5364C8E.GetValueBool("ckbInteract");
			string text = D5364C8E.GetValue("typeReaction");
			new List<CheckBox> { AC833F0D, ckbTym, ckbHaha, B9BE009F, B9B6370E, ckbGian };
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Split('|').Contains(i.ToString());
			}
			C8A0A6A2.Checked = D5364C8E.GetValueBool("ckbComment");
			txtComment.Text = D5364C8E.GetValue("txtComment");
			ckbTuDongXoaNoiDung.Checked = D5364C8E.GetValueBool("ckbTuDongXoaNoiDung");
			ckbLapLaiTuongTac.Checked = D5364C8E.GetValueBool("ckbLapLaiTuongTac");
			nudLapLaiTuongTacDelayFrom.Value = D5364C8E.GetValueInt("nudLapLaiTuongTacDelayFrom", 10);
			nudLapLaiTuongTacDelayTo.Value = D5364C8E.GetValueInt("nudLapLaiTuongTacDelayTo", 10);
			ckbLapLaiTuongTacInteract.Checked = D5364C8E.GetValueBool("ckbLapLaiTuongTacInteract");
			ckbLapLaiTuongTacComment.Checked = D5364C8E.GetValueBool("ckbLapLaiTuongTacComment");
		}
		catch
		{
		}
		method_0();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D6A22E27(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!");
			return;
		}
		if (C8A0A6A2.Checked)
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!");
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtLinkVideo", txtLinkVideo.Text.Trim());
		gClass.GetJson("nudTimeFrom", A8003B9F.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("ckbInteract", F42C0E29.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + i + "|";
			}
		}
		gClass.GetJson("typeReaction", text2.TrimEnd('|'));
		gClass.GetJson("ckbComment", C8A0A6A2.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		gClass.GetJson("ckbLapLaiTuongTac", ckbLapLaiTuongTac.Checked);
		gClass.GetJson("nudLapLaiTuongTacDelayFrom", nudLapLaiTuongTacDelayFrom.Value);
		gClass.GetJson("nudLapLaiTuongTacDelayTo", nudLapLaiTuongTacDelayTo.Value);
		gClass.GetJson("ckbLapLaiTuongTacInteract", ckbLapLaiTuongTacInteract.Checked);
		gClass.GetJson("ckbLapLaiTuongTacComment", ckbLapLaiTuongTacComment.Checked);
		string text3 = gClass.D9A09B34();
		if (F4A189BC == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(C0229D28, text, string_0, text3))
				{
					B084CCB0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!");
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(AD3CBEAA, text, text3))
			{
				B084CCB0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!");
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
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

	private void method_0()
	{
		F42C0E29_CheckedChanged(null, null);
		C8A0A6A2_CheckedChanged(null, null);
		ckbLapLaiTuongTac_CheckedChanged(null, null);
	}

	private void F42C0E29_CheckedChanged(object sender, EventArgs e)
	{
		F9932F04.Enabled = F42C0E29.Checked;
		if (F42C0E29.Checked)
		{
			ckbLapLaiTuongTacInteract.Enabled = true;
			return;
		}
		ckbLapLaiTuongTacInteract.Checked = false;
		ckbLapLaiTuongTacInteract.Enabled = false;
	}

	private void C8A0A6A2_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = C8A0A6A2.Checked;
		if (C8A0A6A2.Checked)
		{
			ckbLapLaiTuongTacComment.Enabled = true;
			return;
		}
		ckbLapLaiTuongTacComment.Checked = false;
		ckbLapLaiTuongTacComment.Enabled = false;
	}

	private void A4AA3E3C(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, lblComment);
	}

	private void ckbLapLaiTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		plLapLaiTuongTac.Enabled = ckbLapLaiTuongTac.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && A80D96B4 != null)
		{
			A80D96B4.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.A80D96B4 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacLivestream));
		this.C387C190 = new Bunifu.Framework.UI.BunifuDragControl(this.A80D96B4);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.BABD2716 = new Bunifu.Framework.UI.BunifuDragControl(this.A80D96B4);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plLapLaiTuongTac = new System.Windows.Forms.Panel();
		this.nudLapLaiTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
		this.panel3 = new System.Windows.Forms.Panel();
		this.C43E520A = new System.Windows.Forms.RadioButton();
		this.radioButton2 = new System.Windows.Forms.RadioButton();
		this.ckbLapLaiTuongTacInteract = new System.Windows.Forms.CheckBox();
		this.D5A19599 = new System.Windows.Forms.Label();
		this.ckbLapLaiTuongTacComment = new System.Windows.Forms.CheckBox();
		this.nudLapLaiTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.A79DB513 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.F9932F04 = new System.Windows.Forms.Panel();
		this.ckbGian = new System.Windows.Forms.CheckBox();
		this.B9B6370E = new System.Windows.Forms.CheckBox();
		this.B9BE009F = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.E73952BE = new System.Windows.Forms.CheckBox();
		this.ckbTym = new System.Windows.Forms.CheckBox();
		this.AC833F0D = new System.Windows.Forms.CheckBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.E0880CBF = new System.Windows.Forms.RadioButton();
		this.radioButton4 = new System.Windows.Forms.RadioButton();
		this.CEA303B0 = new System.Windows.Forms.Label();
		this.plComment = new System.Windows.Forms.Panel();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.lblComment = new System.Windows.Forms.Label();
		this.ckbTuDongXoaNoiDung = new System.Windows.Forms.CheckBox();
		this.ckbLapLaiTuongTac = new System.Windows.Forms.CheckBox();
		this.C8A0A6A2 = new System.Windows.Forms.CheckBox();
		this.F42C0E29 = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.A8003B9F = new System.Windows.Forms.NumericUpDown();
		this.txtLinkVideo = new System.Windows.Forms.TextBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.DB2A6534 = new System.Windows.Forms.Label();
		this.FFBF3601 = new System.Windows.Forms.Label();
		this.C6B8BC88 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.F911AC87 = new System.Windows.Forms.Button();
		this.CB9BC424 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plLapLaiTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLapLaiTuongTacDelayTo).BeginInit();
		this.panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLapLaiTuongTacDelayFrom).BeginInit();
		this.F9932F04.SuspendLayout();
		this.panel7.SuspendLayout();
		this.plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A8003B9F).BeginInit();
		this.CB9BC424.SuspendLayout();
		base.SuspendLayout();
		this.C387C190.Fixed = true;
		this.C387C190.Horizontal = true;
		this.C387C190.TargetControl = this.bunifuCustomLabel1;
		this.C387C190.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(388, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Livestream";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.BABD2716.Fixed = true;
		this.BABD2716.Horizontal = true;
		this.BABD2716.TargetControl = this.pnlHeader;
		this.BABD2716.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(388, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(357, 1);
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
		this.panel1.Controls.Add(this.plLapLaiTuongTac);
		this.panel1.Controls.Add(this.F9932F04);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.ckbLapLaiTuongTac);
		this.panel1.Controls.Add(this.C8A0A6A2);
		this.panel1.Controls.Add(this.F42C0E29);
		this.panel1.Controls.Add(this.nudTimeTo);
		this.panel1.Controls.Add(this.A8003B9F);
		this.panel1.Controls.Add(this.txtLinkVideo);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.DB2A6534);
		this.panel1.Controls.Add(this.FFBF3601);
		this.panel1.Controls.Add(this.C6B8BC88);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.F911AC87);
		this.panel1.Controls.Add(this.CB9BC424);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(391, 544);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plLapLaiTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plLapLaiTuongTac.Controls.Add(this.nudLapLaiTuongTacDelayTo);
		this.plLapLaiTuongTac.Controls.Add(this.panel3);
		this.plLapLaiTuongTac.Controls.Add(this.ckbLapLaiTuongTacInteract);
		this.plLapLaiTuongTac.Controls.Add(this.D5A19599);
		this.plLapLaiTuongTac.Controls.Add(this.ckbLapLaiTuongTacComment);
		this.plLapLaiTuongTac.Controls.Add(this.nudLapLaiTuongTacDelayFrom);
		this.plLapLaiTuongTac.Controls.Add(this.A79DB513);
		this.plLapLaiTuongTac.Controls.Add(this.label6);
		this.plLapLaiTuongTac.Location = new System.Drawing.Point(48, 426);
		this.plLapLaiTuongTac.Name = "plLapLaiTuongTac";
		this.plLapLaiTuongTac.Size = new System.Drawing.Size(310, 59);
		this.plLapLaiTuongTac.TabIndex = 180;
		this.nudLapLaiTuongTacDelayTo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudLapLaiTuongTacDelayTo.Location = new System.Drawing.Point(185, 4);
		this.nudLapLaiTuongTacDelayTo.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		this.nudLapLaiTuongTacDelayTo.Name = "nudLapLaiTuongTacDelayTo";
		this.nudLapLaiTuongTacDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudLapLaiTuongTacDelayTo.TabIndex = 22;
		this.panel3.Controls.Add(this.C43E520A);
		this.panel3.Controls.Add(this.radioButton2);
		this.panel3.Location = new System.Drawing.Point(67, 300);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(200, 43);
		this.panel3.TabIndex = 43;
		this.C43E520A.AutoSize = true;
		this.C43E520A.Checked = true;
		this.C43E520A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C43E520A.Location = new System.Drawing.Point(3, 2);
		this.C43E520A.Name = "radioButton1";
		this.C43E520A.Size = new System.Drawing.Size(201, 20);
		this.C43E520A.TabIndex = 3;
		this.C43E520A.TabStop = true;
		this.C43E520A.Text = "Comment theo thứ tự nội dung";
		this.C43E520A.UseVisualStyleBackColor = true;
		this.radioButton2.AutoSize = true;
		this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton2.Location = new System.Drawing.Point(3, 23);
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.Size = new System.Drawing.Size(200, 20);
		this.radioButton2.TabIndex = 3;
		this.radioButton2.Text = "Comment ngẫu nhiên nội dung";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.ckbLapLaiTuongTacInteract.AutoSize = true;
		this.ckbLapLaiTuongTacInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLapLaiTuongTacInteract.Location = new System.Drawing.Point(6, 32);
		this.ckbLapLaiTuongTacInteract.Name = "ckbLapLaiTuongTacInteract";
		this.ckbLapLaiTuongTacInteract.Size = new System.Drawing.Size(112, 20);
		this.ckbLapLaiTuongTacInteract.TabIndex = 5;
		this.ckbLapLaiTuongTacInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		this.ckbLapLaiTuongTacInteract.UseVisualStyleBackColor = true;
		this.ckbLapLaiTuongTacInteract.CheckedChanged += new System.EventHandler(F42C0E29_CheckedChanged);
		this.D5A19599.AutoSize = true;
		this.D5A19599.Location = new System.Drawing.Point(2, 6);
		this.D5A19599.Name = "lblmc1";
		this.D5A19599.Size = new System.Drawing.Size(92, 16);
		this.D5A19599.TabIndex = 18;
		this.D5A19599.Text = "Delay time (s):";
		this.ckbLapLaiTuongTacComment.AutoSize = true;
		this.ckbLapLaiTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLapLaiTuongTacComment.Location = new System.Drawing.Point(134, 32);
		this.ckbLapLaiTuongTacComment.Name = "ckbLapLaiTuongTacComment";
		this.ckbLapLaiTuongTacComment.Size = new System.Drawing.Size(81, 20);
		this.ckbLapLaiTuongTacComment.TabIndex = 7;
		this.ckbLapLaiTuongTacComment.Text = "Comment";
		this.ckbLapLaiTuongTacComment.UseVisualStyleBackColor = true;
		this.ckbLapLaiTuongTacComment.CheckedChanged += new System.EventHandler(C8A0A6A2_CheckedChanged);
		this.nudLapLaiTuongTacDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.nudLapLaiTuongTacDelayFrom.Location = new System.Drawing.Point(94, 4);
		this.nudLapLaiTuongTacDelayFrom.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		this.nudLapLaiTuongTacDelayFrom.Name = "nudLapLaiTuongTacDelayFrom";
		this.nudLapLaiTuongTacDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudLapLaiTuongTacDelayFrom.TabIndex = 21;
		this.A79DB513.AutoSize = true;
		this.A79DB513.Location = new System.Drawing.Point(4, 302);
		this.A79DB513.Name = "label4";
		this.A79DB513.Size = new System.Drawing.Size(64, 16);
		this.A79DB513.TabIndex = 2;
		this.A79DB513.Text = "Tùy chọn:";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.Location = new System.Drawing.Point(159, 5);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(18, 16);
		this.label6.TabIndex = 20;
		this.label6.Text = ">";
		this.F9932F04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F9932F04.Controls.Add(this.ckbGian);
		this.F9932F04.Controls.Add(this.B9B6370E);
		this.F9932F04.Controls.Add(this.B9BE009F);
		this.F9932F04.Controls.Add(this.ckbHaha);
		this.F9932F04.Controls.Add(this.E73952BE);
		this.F9932F04.Controls.Add(this.ckbTym);
		this.F9932F04.Controls.Add(this.AC833F0D);
		this.F9932F04.Controls.Add(this.panel7);
		this.F9932F04.Controls.Add(this.CEA303B0);
		this.F9932F04.Location = new System.Drawing.Point(48, 159);
		this.F9932F04.Name = "plInteract";
		this.F9932F04.Size = new System.Drawing.Size(310, 33);
		this.F9932F04.TabIndex = 180;
		this.ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGian.Image = Resources.Bitmap_7;
		this.ckbGian.Location = new System.Drawing.Point(266, 1);
		this.ckbGian.Name = "ckbGian";
		this.ckbGian.Size = new System.Drawing.Size(40, 30);
		this.ckbGian.TabIndex = 179;
		this.ckbGian.UseVisualStyleBackColor = true;
		this.B9B6370E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B9B6370E.Image = Resources.Bitmap_167;
		this.B9B6370E.Location = new System.Drawing.Point(222, 1);
		this.B9B6370E.Name = "ckbBuon";
		this.B9B6370E.Size = new System.Drawing.Size(40, 30);
		this.B9B6370E.TabIndex = 178;
		this.B9B6370E.UseVisualStyleBackColor = true;
		this.B9BE009F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B9BE009F.Image = Resources.BBAD6B14;
		this.B9BE009F.Location = new System.Drawing.Point(178, 1);
		this.B9BE009F.Name = "ckbWow";
		this.B9BE009F.Size = new System.Drawing.Size(40, 30);
		this.B9BE009F.TabIndex = 177;
		this.B9BE009F.UseVisualStyleBackColor = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Image = Resources.Bitmap_34;
		this.ckbHaha.Location = new System.Drawing.Point(134, 1);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(40, 30);
		this.ckbHaha.TabIndex = 176;
		this.ckbHaha.UseVisualStyleBackColor = true;
		this.E73952BE.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E73952BE.Image = Resources.Bitmap_14;
		this.E73952BE.Location = new System.Drawing.Point(90, 1);
		this.E73952BE.Name = "ckbThuong";
		this.E73952BE.Size = new System.Drawing.Size(40, 30);
		this.E73952BE.TabIndex = 175;
		this.E73952BE.UseVisualStyleBackColor = true;
		this.ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTym.Image = Resources.Bitmap_154;
		this.ckbTym.Location = new System.Drawing.Point(46, 1);
		this.ckbTym.Name = "ckbTym";
		this.ckbTym.Size = new System.Drawing.Size(40, 30);
		this.ckbTym.TabIndex = 174;
		this.ckbTym.UseVisualStyleBackColor = true;
		this.AC833F0D.Checked = true;
		this.AC833F0D.CheckState = System.Windows.Forms.CheckState.Checked;
		this.AC833F0D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AC833F0D.Image = Resources.B41E983E;
		this.AC833F0D.Location = new System.Drawing.Point(2, 1);
		this.AC833F0D.Name = "ckbLike";
		this.AC833F0D.Size = new System.Drawing.Size(40, 30);
		this.AC833F0D.TabIndex = 173;
		this.AC833F0D.UseVisualStyleBackColor = true;
		this.panel7.Controls.Add(this.E0880CBF);
		this.panel7.Controls.Add(this.radioButton4);
		this.panel7.Location = new System.Drawing.Point(67, 300);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(200, 43);
		this.panel7.TabIndex = 43;
		this.E0880CBF.AutoSize = true;
		this.E0880CBF.Checked = true;
		this.E0880CBF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E0880CBF.Location = new System.Drawing.Point(3, 2);
		this.E0880CBF.Name = "radioButton3";
		this.E0880CBF.Size = new System.Drawing.Size(201, 20);
		this.E0880CBF.TabIndex = 3;
		this.E0880CBF.TabStop = true;
		this.E0880CBF.Text = "Comment theo thứ tự nội dung";
		this.E0880CBF.UseVisualStyleBackColor = true;
		this.radioButton4.AutoSize = true;
		this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton4.Location = new System.Drawing.Point(3, 23);
		this.radioButton4.Name = "radioButton4";
		this.radioButton4.Size = new System.Drawing.Size(200, 20);
		this.radioButton4.TabIndex = 3;
		this.radioButton4.Text = "Comment ngẫu nhiên nội dung";
		this.radioButton4.UseVisualStyleBackColor = true;
		this.CEA303B0.AutoSize = true;
		this.CEA303B0.Location = new System.Drawing.Point(4, 302);
		this.CEA303B0.Name = "label26";
		this.CEA303B0.Size = new System.Drawing.Size(64, 16);
		this.CEA303B0.TabIndex = 2;
		this.CEA303B0.Text = "Tùy chọn:";
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.label11);
		this.plComment.Controls.Add(this.lblComment);
		this.plComment.Controls.Add(this.ckbTuDongXoaNoiDung);
		this.plComment.Location = new System.Drawing.Point(48, 221);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(310, 176);
		this.plComment.TabIndex = 8;
		this.txtComment.Location = new System.Drawing.Point(6, 24);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(297, 102);
		this.txtComment.TabIndex = 199;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(A4AA3E3C);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(4, 129);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(143, 16);
		this.label11.TabIndex = 197;
		this.label11.Text = "(Spin nội dung {a|b|c})";
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(2, 4);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(139, 16);
		this.lblComment.TabIndex = 198;
		this.lblComment.Text = "Nội dung bình luận (0):";
		this.ckbTuDongXoaNoiDung.AutoSize = true;
		this.ckbTuDongXoaNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongXoaNoiDung.Location = new System.Drawing.Point(7, 151);
		this.ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		this.ckbTuDongXoaNoiDung.Size = new System.Drawing.Size(201, 20);
		this.ckbTuDongXoaNoiDung.TabIndex = 196;
		this.ckbTuDongXoaNoiDung.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 dùng";
		this.ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		this.ckbLapLaiTuongTac.AutoSize = true;
		this.ckbLapLaiTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLapLaiTuongTac.Location = new System.Drawing.Point(30, 403);
		this.ckbLapLaiTuongTac.Name = "ckbLapLaiTuongTac";
		this.ckbLapLaiTuongTac.Size = new System.Drawing.Size(121, 20);
		this.ckbLapLaiTuongTac.TabIndex = 7;
		this.ckbLapLaiTuongTac.Text = "Lặp lại tương tác";
		this.ckbLapLaiTuongTac.UseVisualStyleBackColor = true;
		this.ckbLapLaiTuongTac.CheckedChanged += new System.EventHandler(ckbLapLaiTuongTac_CheckedChanged);
		this.C8A0A6A2.AutoSize = true;
		this.C8A0A6A2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C8A0A6A2.Location = new System.Drawing.Point(30, 198);
		this.C8A0A6A2.Name = "ckbComment";
		this.C8A0A6A2.Size = new System.Drawing.Size(81, 20);
		this.C8A0A6A2.TabIndex = 7;
		this.C8A0A6A2.Text = "Comment";
		this.C8A0A6A2.UseVisualStyleBackColor = true;
		this.C8A0A6A2.CheckedChanged += new System.EventHandler(C8A0A6A2_CheckedChanged);
		this.F42C0E29.AutoSize = true;
		this.F42C0E29.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F42C0E29.Location = new System.Drawing.Point(30, 136);
		this.F42C0E29.Name = "ckbInteract";
		this.F42C0E29.Size = new System.Drawing.Size(112, 20);
		this.F42C0E29.TabIndex = 5;
		this.F42C0E29.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		this.F42C0E29.UseVisualStyleBackColor = true;
		this.F42C0E29.CheckedChanged += new System.EventHandler(F42C0E29_CheckedChanged);
		this.nudTimeTo.Location = new System.Drawing.Point(236, 107);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeTo.TabIndex = 2;
		this.A8003B9F.Location = new System.Drawing.Point(143, 107);
		this.A8003B9F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A8003B9F.Name = "nudTimeFrom";
		this.A8003B9F.Size = new System.Drawing.Size(56, 23);
		this.A8003B9F.TabIndex = 1;
		this.txtLinkVideo.Location = new System.Drawing.Point(143, 78);
		this.txtLinkVideo.Name = "txtLinkVideo";
		this.txtLinkVideo.Size = new System.Drawing.Size(215, 23);
		this.txtLinkVideo.TabIndex = 0;
		this.txtTenHanhDong.Location = new System.Drawing.Point(143, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(215, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.DB2A6534.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DB2A6534.Location = new System.Drawing.Point(203, 109);
		this.DB2A6534.Name = "label3";
		this.DB2A6534.Size = new System.Drawing.Size(29, 16);
		this.DB2A6534.TabIndex = 37;
		this.DB2A6534.Text = ">";
		this.DB2A6534.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FFBF3601.AutoSize = true;
		this.FFBF3601.Location = new System.Drawing.Point(27, 81);
		this.FFBF3601.Name = "label9";
		this.FFBF3601.Size = new System.Drawing.Size(97, 16);
		this.FFBF3601.TabIndex = 31;
		this.FFBF3601.Text = "Link livestream:";
		this.C6B8BC88.AutoSize = true;
		this.C6B8BC88.Location = new System.Drawing.Point(27, 109);
		this.C6B8BC88.Name = "label2";
		this.C6B8BC88.Size = new System.Drawing.Size(113, 16);
		this.C6B8BC88.TabIndex = 32;
		this.C6B8BC88.Text = "Thời gian xem (s):";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(203, 500);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.F911AC87.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F911AC87.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.F911AC87.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F911AC87.FlatAppearance.BorderSize = 0;
		this.F911AC87.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F911AC87.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F911AC87.ForeColor = System.Drawing.Color.White;
		this.F911AC87.Location = new System.Drawing.Point(96, 500);
		this.F911AC87.Name = "btnAdd";
		this.F911AC87.Size = new System.Drawing.Size(92, 29);
		this.F911AC87.TabIndex = 9;
		this.F911AC87.Text = "Thêm";
		this.F911AC87.UseVisualStyleBackColor = false;
		this.F911AC87.Click += new System.EventHandler(D6A22E27);
		this.CB9BC424.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CB9BC424.BackColor = System.Drawing.Color.White;
		this.CB9BC424.BorderRadius = 0;
		this.CB9BC424.BottomSahddow = true;
		this.CB9BC424.color = System.Drawing.Color.DarkViolet;
		this.CB9BC424.Controls.Add(this.pnlHeader);
		this.CB9BC424.LeftSahddow = false;
		this.CB9BC424.Location = new System.Drawing.Point(1, 0);
		this.CB9BC424.Name = "bunifuCards1";
		this.CB9BC424.RightSahddow = true;
		this.CB9BC424.ShadowDepth = 20;
		this.CB9BC424.Size = new System.Drawing.Size(388, 37);
		this.CB9BC424.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(391, 544);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacLivestream";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacLivestream_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plLapLaiTuongTac.ResumeLayout(false);
		this.plLapLaiTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLapLaiTuongTacDelayTo).EndInit();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudLapLaiTuongTacDelayFrom).EndInit();
		this.F9932F04.ResumeLayout(false);
		this.F9932F04.PerformLayout();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A8003B9F).EndInit();
		this.CB9BC424.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
