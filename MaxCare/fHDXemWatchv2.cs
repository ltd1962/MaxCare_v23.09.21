using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXemWatchv2 : Form
{
	private JSON_Settings gclass8_0;

	private string E998BAB4;

	private string string_0;

	private string CA8C6094;

	private int BBAEA72F;

	public static bool bool_0;

	private IContainer F9254203 = null;

	private BunifuDragControl EC295705;

	private BunifuDragControl EF36772C;

	private Panel panel1;

	private NumericUpDown nudTimeWatchTo;

	private NumericUpDown C405F63B;

	private NumericUpDown nudTimeWatchFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label B0068A3A;

	private Label E7B19233;

	private Label F2350A81;

	private Label label4;

	private Label label5;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel E1A607B9;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D98DD689;

	private Panel plComment;

	private Label label8;

	private Label lblStatus;

	private CheckBox B6273212;

	private CheckBox ckbInteract;

	private CheckBox EEB88885;

	private Panel F4B0DA04;

	private NumericUpDown CC3F65AB;

	private Label label13;

	private Label label14;

	private NumericUpDown nudCountCommentTo;

	private Panel A532032D;

	private NumericUpDown nudCountShareFrom;

	private Label label11;

	private Label label12;

	private NumericUpDown nudCountShareTo;

	private Panel plCountLike;

	private NumericUpDown nudCountLikeFrom;

	private Label label9;

	private Label label10;

	private NumericUpDown C390343B;

	private RichTextBox txtComment;

	public fHDXemWatchv2(string FB9CB403, int int_0 = 0, string BDA528A0 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E998BAB4 = FB9CB403;
		CA8C6094 = BDA528A0;
		BBAEA72F = int_0;
		if (InteractSQL.B484648C("", "HDXemWatchv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXemWatchv2', 'Xem watch v2');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXemWatchv2");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BDA528A0);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(D98DD689);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(E7B19233);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(B0068A3A);
		Language.smethod_0(F2350A81);
		Language.smethod_0(label10);
		Language.smethod_0(label9);
		Language.smethod_0(label12);
		Language.smethod_0(label11);
		Language.smethod_0(label14);
		Language.smethod_0(label13);
		Language.smethod_0(lblStatus);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void F0BEB820_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom");
			C405F63B.Value = gclass8_0.GetValueInt("nudSoLuongTo");
			nudTimeWatchFrom.Value = gclass8_0.GetValueInt("nudTimeWatchFrom");
			nudTimeWatchTo.Value = gclass8_0.GetValueInt("nudTimeWatchTo");
			ckbInteract.Checked = gclass8_0.GetValueBool("ckbInteract");
			B6273212.Checked = gclass8_0.GetValueBool("ckbComment");
			EEB88885.Checked = gclass8_0.GetValueBool("ckbShareWall");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			nudCountLikeFrom.Value = gclass8_0.GetValueInt("nudCountLikeFrom", 1);
			C390343B.Value = gclass8_0.GetValueInt("nudCountLikeTo", 3);
			nudCountShareFrom.Value = gclass8_0.GetValueInt("nudCountShareFrom", 1);
			nudCountShareTo.Value = gclass8_0.GetValueInt("nudCountShareTo", 3);
			CC3F65AB.Value = gclass8_0.GetValueInt("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = gclass8_0.GetValueInt("nudCountCommentTo", 3);
		}
		catch
		{
		}
		E827E534();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F89CC52C(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (B6273212.Checked)
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", C405F63B.Value);
		gClass.GetJson("nudTimeWatchFrom", nudTimeWatchFrom.Value);
		gClass.GetJson("nudTimeWatchTo", nudTimeWatchTo.Value);
		gClass.GetJson("ckbInteract", ckbInteract.Checked);
		gClass.GetJson("ckbShareWall", EEB88885.Checked);
		gClass.GetJson("ckbComment", B6273212.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.GetJson("nudCountLikeTo", C390343B.Value);
		gClass.GetJson("nudCountShareFrom", nudCountShareFrom.Value);
		gClass.GetJson("nudCountShareTo", nudCountShareTo.Value);
		gClass.GetJson("nudCountCommentFrom", CC3F65AB.Value);
		gClass.GetJson("nudCountCommentTo", nudCountCommentTo.Value);
		string text2 = gClass.D9A09B34();
		if (BBAEA72F == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E998BAB4, text, string_0, text2))
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
			if (InteractSQL.smethod_13(CA8C6094, text, text2))
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

	private void EF8EE905(object sender, EventArgs e)
	{
		Close();
	}

	private void FD2CEC0B(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void FAAA1117(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void E827E534()
	{
		E51C4420(null, null);
		A29A6F1B(null, null);
		C1A5C88B(null, null);
	}

	private void A29A6F1B(object sender, EventArgs e)
	{
		plComment.Enabled = B6273212.Checked;
		F4B0DA04.Enabled = B6273212.Checked;
	}

	private void E51C4420(object sender, EventArgs e)
	{
		plCountLike.Enabled = ckbInteract.Checked;
	}

	private void C1A5C88B(object sender, EventArgs e)
	{
		A532032D.Enabled = EEB88885.Checked;
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void B53E8BA9(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F9254203 != null)
		{
			F9254203.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F9254203 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemWatchv2));
		this.EC295705 = new Bunifu.Framework.UI.BunifuDragControl(this.F9254203);
		this.D98DD689 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.EF36772C = new Bunifu.Framework.UI.BunifuDragControl(this.F9254203);
		this.E1A607B9 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.F4B0DA04 = new System.Windows.Forms.Panel();
		this.CC3F65AB = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		this.A532032D = new System.Windows.Forms.Panel();
		this.nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		this.plCountLike = new System.Windows.Forms.Panel();
		this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.C390343B = new System.Windows.Forms.NumericUpDown();
		this.plComment = new System.Windows.Forms.Panel();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.B6273212 = new System.Windows.Forms.CheckBox();
		this.EEB88885 = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudTimeWatchTo = new System.Windows.Forms.NumericUpDown();
		this.C405F63B = new System.Windows.Forms.NumericUpDown();
		this.nudTimeWatchFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.B0068A3A = new System.Windows.Forms.Label();
		this.E7B19233 = new System.Windows.Forms.Label();
		this.F2350A81 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.E1A607B9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.F4B0DA04.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CC3F65AB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
		this.A532032D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).BeginInit();
		this.plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C390343B).BeginInit();
		this.plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C405F63B).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.EC295705.Fixed = true;
		this.EC295705.Horizontal = true;
		this.EC295705.TargetControl = this.D98DD689;
		this.EC295705.Vertical = true;
		this.D98DD689.BackColor = System.Drawing.Color.Transparent;
		this.D98DD689.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D98DD689.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D98DD689.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D98DD689.ForeColor = System.Drawing.Color.Black;
		this.D98DD689.Location = new System.Drawing.Point(0, 0);
		this.D98DD689.Name = "bunifuCustomLabel1";
		this.D98DD689.Size = new System.Drawing.Size(359, 31);
		this.D98DD689.TabIndex = 12;
		this.D98DD689.Text = "Cấu hình Xem Watch v2";
		this.D98DD689.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.EF36772C.Fixed = true;
		this.EF36772C.Horizontal = true;
		this.EF36772C.TargetControl = this.E1A607B9;
		this.EF36772C.Vertical = true;
		this.E1A607B9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E1A607B9.BackColor = System.Drawing.Color.White;
		this.E1A607B9.Controls.Add(this.button1);
		this.E1A607B9.Controls.Add(this.pictureBox1);
		this.E1A607B9.Controls.Add(this.D98DD689);
		this.E1A607B9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.E1A607B9.Location = new System.Drawing.Point(0, 3);
		this.E1A607B9.Name = "pnlHeader";
		this.E1A607B9.Size = new System.Drawing.Size(359, 31);
		this.E1A607B9.TabIndex = 9;
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
		this.panel1.Controls.Add(this.F4B0DA04);
		this.panel1.Controls.Add(this.A532032D);
		this.panel1.Controls.Add(this.plCountLike);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.B6273212);
		this.panel1.Controls.Add(this.EEB88885);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.nudTimeWatchTo);
		this.panel1.Controls.Add(this.C405F63B);
		this.panel1.Controls.Add(this.nudTimeWatchFrom);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.B0068A3A);
		this.panel1.Controls.Add(this.E7B19233);
		this.panel1.Controls.Add(this.F2350A81);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 436);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(FD2CEC0B);
		this.F4B0DA04.Controls.Add(this.CC3F65AB);
		this.F4B0DA04.Controls.Add(this.label13);
		this.F4B0DA04.Controls.Add(this.label14);
		this.F4B0DA04.Controls.Add(this.nudCountCommentTo);
		this.F4B0DA04.Location = new System.Drawing.Point(132, 186);
		this.F4B0DA04.Name = "plCountComment";
		this.F4B0DA04.Size = new System.Drawing.Size(200, 25);
		this.F4B0DA04.TabIndex = 44;
		this.CC3F65AB.Location = new System.Drawing.Point(1, 1);
		this.CC3F65AB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CC3F65AB.Name = "nudCountCommentFrom";
		this.CC3F65AB.Size = new System.Drawing.Size(56, 23);
		this.CC3F65AB.TabIndex = 1;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(159, 3);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(24, 16);
		this.label13.TabIndex = 35;
		this.label13.Text = "lần";
		this.label14.Location = new System.Drawing.Point(63, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 37;
		this.label14.Text = "đê\u0301n";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentTo.Name = "nudCountCommentTo";
		this.nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentTo.TabIndex = 2;
		this.A532032D.Controls.Add(this.nudCountShareFrom);
		this.A532032D.Controls.Add(this.label11);
		this.A532032D.Controls.Add(this.label12);
		this.A532032D.Controls.Add(this.nudCountShareTo);
		this.A532032D.Location = new System.Drawing.Point(132, 158);
		this.A532032D.Name = "plCountShareWall";
		this.A532032D.Size = new System.Drawing.Size(200, 25);
		this.A532032D.TabIndex = 43;
		this.nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountShareFrom.Name = "nudCountShareFrom";
		this.nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountShareFrom.TabIndex = 1;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(159, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(24, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "lần";
		this.label12.Location = new System.Drawing.Point(63, 3);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(29, 16);
		this.label12.TabIndex = 37;
		this.label12.Text = "đê\u0301n";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountShareTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountShareTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountShareTo.Name = "nudCountShareTo";
		this.nudCountShareTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountShareTo.TabIndex = 2;
		this.plCountLike.Controls.Add(this.nudCountLikeFrom);
		this.plCountLike.Controls.Add(this.label9);
		this.plCountLike.Controls.Add(this.label10);
		this.plCountLike.Controls.Add(this.C390343B);
		this.plCountLike.Location = new System.Drawing.Point(132, 130);
		this.plCountLike.Name = "plCountLike";
		this.plCountLike.Size = new System.Drawing.Size(200, 25);
		this.plCountLike.TabIndex = 42;
		this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeFrom.Name = "nudCountLikeFrom";
		this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeFrom.TabIndex = 1;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(159, 3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(24, 16);
		this.label9.TabIndex = 35;
		this.label9.Text = "lần";
		this.label10.Location = new System.Drawing.Point(63, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 37;
		this.label10.Text = "đê\u0301n";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C390343B.Location = new System.Drawing.Point(98, 1);
		this.C390343B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C390343B.Name = "nudCountLikeTo";
		this.C390343B.Size = new System.Drawing.Size(56, 23);
		this.C390343B.TabIndex = 2;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(48, 214);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(278, 164);
		this.plComment.TabIndex = 8;
		this.txtComment.Location = new System.Drawing.Point(6, 24);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(264, 114);
		this.txtComment.TabIndex = 45;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(FAAA1117);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 141);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(265, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.B6273212.AutoSize = true;
		this.B6273212.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B6273212.Location = new System.Drawing.Point(30, 188);
		this.B6273212.Name = "ckbComment";
		this.B6273212.Size = new System.Drawing.Size(81, 20);
		this.B6273212.TabIndex = 7;
		this.B6273212.Text = "Comment";
		this.B6273212.UseVisualStyleBackColor = true;
		this.B6273212.CheckedChanged += new System.EventHandler(A29A6F1B);
		this.EEB88885.AutoSize = true;
		this.EEB88885.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EEB88885.Location = new System.Drawing.Point(30, 160);
		this.EEB88885.Name = "ckbShareWall";
		this.EEB88885.Size = new System.Drawing.Size(89, 20);
		this.EEB88885.TabIndex = 6;
		this.EEB88885.Text = "Share Wall";
		this.EEB88885.UseVisualStyleBackColor = true;
		this.EEB88885.CheckedChanged += new System.EventHandler(C1A5C88B);
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(30, 132);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(48, 20);
		this.ckbInteract.TabIndex = 5;
		this.ckbInteract.Text = "Like";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(E51C4420);
		this.nudTimeWatchTo.Location = new System.Drawing.Point(229, 103);
		this.nudTimeWatchTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWatchTo.Name = "nudTimeWatchTo";
		this.nudTimeWatchTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWatchTo.TabIndex = 4;
		this.C405F63B.Location = new System.Drawing.Point(229, 76);
		this.C405F63B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C405F63B.Name = "nudSoLuongTo";
		this.C405F63B.Size = new System.Drawing.Size(56, 23);
		this.C405F63B.TabIndex = 2;
		this.nudTimeWatchFrom.Location = new System.Drawing.Point(132, 103);
		this.nudTimeWatchFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWatchFrom.Name = "nudTimeWatchFrom";
		this.nudTimeWatchFrom.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWatchFrom.TabIndex = 3;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 76);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.B0068A3A.Location = new System.Drawing.Point(194, 105);
		this.B0068A3A.Name = "label7";
		this.B0068A3A.Size = new System.Drawing.Size(29, 16);
		this.B0068A3A.TabIndex = 38;
		this.B0068A3A.Text = "đê\u0301n";
		this.B0068A3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E7B19233.Location = new System.Drawing.Point(194, 78);
		this.E7B19233.Name = "label3";
		this.E7B19233.Size = new System.Drawing.Size(29, 16);
		this.E7B19233.TabIndex = 37;
		this.E7B19233.Text = "đê\u0301n";
		this.E7B19233.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F2350A81.AutoSize = true;
		this.F2350A81.Location = new System.Drawing.Point(290, 105);
		this.F2350A81.Name = "label6";
		this.F2350A81.Size = new System.Drawing.Size(30, 16);
		this.F2350A81.TabIndex = 36;
		this.F2350A81.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 78);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(37, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "video";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 105);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(93, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian xem:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 78);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(97, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng video:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 393);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(EF8EE905);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 393);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(F89CC52C);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.E1A607B9);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 436);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatchv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F0BEB820_Load);
		this.E1A607B9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.F4B0DA04.ResumeLayout(false);
		this.F4B0DA04.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CC3F65AB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
		this.A532032D.ResumeLayout(false);
		this.A532032D.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).EndInit();
		this.plCountLike.ResumeLayout(false);
		this.plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C390343B).EndInit();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C405F63B).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
