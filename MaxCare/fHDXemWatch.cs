using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemWatch : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer D982FF32 = null;

	private BunifuDragControl C098BA86;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudTimeWatchTo;

	private NumericUpDown D6BE199C;

	private NumericUpDown nudTimeWatchFrom;

	private NumericUpDown B63C3E1E;

	private TextBox D5A5492B;

	private Label label7;

	private Label label3;

	private Label B12B840F;

	private Label D58F310B;

	private Label label5;

	private Label label2;

	private Label B1ACD3A9;

	private Button btnCancel;

	private Button A6138A87;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D29B3837;

	private Panel plComment;

	private Label CCADFA86;

	private Label E589B22A;

	private CheckBox B0B3B8B5;

	private CheckBox ckbInteract;

	private CheckBox A4AA0838;

	private Panel plCountComment;

	private NumericUpDown nudCountCommentFrom;

	private Label B4392E3C;

	private Label B91C6724;

	private NumericUpDown nudCountCommentTo;

	private Panel plCountShareWall;

	private NumericUpDown nudCountShareFrom;

	private Label label11;

	private Label label12;

	private NumericUpDown BCB38C86;

	private Panel A3BE4FBC;

	private NumericUpDown nudCountLikeFrom;

	private Label label9;

	private Label label10;

	private NumericUpDown nudCountLikeTo;

	private RichTextBox txtComment;

	private Button button2;

	private LinkLabel linkLabel1;

	private Panel D9398789;

	private NumericUpDown nudFollowFrom;

	private Label label15;

	private Label AFA70996;

	private NumericUpDown E8A4F803;

	private CheckBox A3855093;

	public fHDXemWatch(string string_3, int int_1 = 0, string BBA9AA94 = "")
	{
		CB0AD3AE();
		bool_0 = false;
		string_0 = string_3;
		string_2 = BBA9AA94;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXemWatch");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D5A5492B.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BBA9AA94);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			A6138A87.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			D5A5492B.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void C80A808B()
	{
		Language.smethod_0(D29B3837);
		Language.smethod_0(B1ACD3A9);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(D58F310B);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(B12B840F);
		Language.smethod_0(label10);
		Language.smethod_0(label9);
		Language.smethod_0(label12);
		Language.smethod_0(label11);
		Language.smethod_0(B91C6724);
		Language.smethod_0(B4392E3C);
		Language.smethod_0(E589B22A);
		Language.smethod_0(button2);
		Language.smethod_0(CCADFA86);
		Language.smethod_0(A6138A87);
		Language.smethod_0(btnCancel);
	}

	private void E3B25F1F_Load(object sender, EventArgs e)
	{
		try
		{
			B63C3E1E.Value = gclass8_0.GetValueInt("nudSoLuongFrom");
			D6BE199C.Value = gclass8_0.GetValueInt("nudSoLuongTo");
			nudTimeWatchFrom.Value = gclass8_0.GetValueInt("nudTimeWatchFrom");
			nudTimeWatchTo.Value = gclass8_0.GetValueInt("nudTimeWatchTo");
			ckbInteract.Checked = gclass8_0.GetValueBool("ckbInteract");
			B0B3B8B5.Checked = gclass8_0.GetValueBool("ckbComment");
			A4AA0838.Checked = gclass8_0.GetValueBool("ckbShareWall");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			nudCountLikeFrom.Value = gclass8_0.GetValueInt("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = gclass8_0.GetValueInt("nudCountLikeTo", 3);
			nudCountShareFrom.Value = gclass8_0.GetValueInt("nudCountShareFrom", 1);
			BCB38C86.Value = gclass8_0.GetValueInt("nudCountShareTo", 3);
			nudCountCommentFrom.Value = gclass8_0.GetValueInt("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = gclass8_0.GetValueInt("nudCountCommentTo", 3);
			A3855093.Checked = gclass8_0.GetValueBool("ckbFollow");
			nudFollowFrom.Value = gclass8_0.GetValueInt("nudFollowFrom", 1);
			E8A4F803.Value = gclass8_0.GetValueInt("nudFollowTo", 2);
		}
		catch
		{
		}
		method_0();
	}

	private void C1899514(object sender, EventArgs e)
	{
		Close();
	}

	private void A6138A87_Click(object sender, EventArgs e)
	{
		string text = D5A5492B.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (B0B3B8B5.Checked)
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
		gClass.GetJson("nudSoLuongFrom", B63C3E1E.Value);
		gClass.GetJson("nudSoLuongTo", D6BE199C.Value);
		gClass.GetJson("nudTimeWatchFrom", nudTimeWatchFrom.Value);
		gClass.GetJson("nudTimeWatchTo", nudTimeWatchTo.Value);
		gClass.GetJson("ckbInteract", ckbInteract.Checked);
		gClass.GetJson("ckbShareWall", A4AA0838.Checked);
		gClass.GetJson("ckbComment", B0B3B8B5.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.GetJson("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.GetJson("nudCountShareFrom", nudCountShareFrom.Value);
		gClass.GetJson("nudCountShareTo", BCB38C86.Value);
		gClass.GetJson("nudCountCommentFrom", nudCountCommentFrom.Value);
		gClass.GetJson("nudCountCommentTo", nudCountCommentTo.Value);
		gClass.GetJson("ckbFollow", A3855093.Checked);
		gClass.GetJson("nudFollowFrom", nudFollowFrom.Value);
		gClass.GetJson("nudFollowTo", E8A4F803.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
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
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_2, text, string_))
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

	private void C21A16B8(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			E589B22A.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_0()
	{
		D135C2A0(null, null);
		B0B3B8B5_CheckedChanged(null, null);
		FF069F35(null, null);
		A3855093_CheckedChanged(null, null);
	}

	private void B0B3B8B5_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = B0B3B8B5.Checked;
		plCountComment.Enabled = B0B3B8B5.Checked;
	}

	private void D135C2A0(object sender, EventArgs e)
	{
		A3BE4FBC.Enabled = ckbInteract.Checked;
	}

	private void FF069F35(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = A4AA0838.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void D609EC3E(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void A3855093_CheckedChanged(object sender, EventArgs e)
	{
		D9398789.Enabled = A3855093.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && D982FF32 != null)
		{
			D982FF32.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void CB0AD3AE()
	{
		D982FF32 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXemWatch));
		C098BA86 = new BunifuDragControl(D982FF32);
		D29B3837 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(D982FF32);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		D9398789 = new Panel();
		nudFollowFrom = new NumericUpDown();
		label15 = new Label();
		AFA70996 = new Label();
		E8A4F803 = new NumericUpDown();
		A3855093 = new CheckBox();
		plCountComment = new Panel();
		nudCountCommentFrom = new NumericUpDown();
		B4392E3C = new Label();
		B91C6724 = new Label();
		nudCountCommentTo = new NumericUpDown();
		plCountShareWall = new Panel();
		nudCountShareFrom = new NumericUpDown();
		label11 = new Label();
		label12 = new Label();
		BCB38C86 = new NumericUpDown();
		A3BE4FBC = new Panel();
		nudCountLikeFrom = new NumericUpDown();
		label9 = new Label();
		label10 = new Label();
		nudCountLikeTo = new NumericUpDown();
		plComment = new Panel();
		linkLabel1 = new LinkLabel();
		button2 = new Button();
		txtComment = new RichTextBox();
		CCADFA86 = new Label();
		E589B22A = new Label();
		B0B3B8B5 = new CheckBox();
		A4AA0838 = new CheckBox();
		ckbInteract = new CheckBox();
		nudTimeWatchTo = new NumericUpDown();
		D6BE199C = new NumericUpDown();
		nudTimeWatchFrom = new NumericUpDown();
		B63C3E1E = new NumericUpDown();
		D5A5492B = new TextBox();
		label7 = new Label();
		label3 = new Label();
		B12B840F = new Label();
		D58F310B = new Label();
		label5 = new Label();
		label2 = new Label();
		B1ACD3A9 = new Label();
		btnCancel = new Button();
		A6138A87 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		D9398789.SuspendLayout();
		((ISupportInitialize)nudFollowFrom).BeginInit();
		((ISupportInitialize)E8A4F803).BeginInit();
		plCountComment.SuspendLayout();
		((ISupportInitialize)nudCountCommentFrom).BeginInit();
		((ISupportInitialize)nudCountCommentTo).BeginInit();
		plCountShareWall.SuspendLayout();
		((ISupportInitialize)nudCountShareFrom).BeginInit();
		((ISupportInitialize)BCB38C86).BeginInit();
		A3BE4FBC.SuspendLayout();
		((ISupportInitialize)nudCountLikeFrom).BeginInit();
		((ISupportInitialize)nudCountLikeTo).BeginInit();
		plComment.SuspendLayout();
		((ISupportInitialize)nudTimeWatchTo).BeginInit();
		((ISupportInitialize)D6BE199C).BeginInit();
		((ISupportInitialize)nudTimeWatchFrom).BeginInit();
		((ISupportInitialize)B63C3E1E).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		C098BA86.Fixed = true;
		C098BA86.Horizontal = true;
		C098BA86.TargetControl = D29B3837;
		C098BA86.Vertical = true;
		D29B3837.BackColor = Color.Transparent;
		D29B3837.Cursor = Cursors.SizeAll;
		D29B3837.Dock = DockStyle.Fill;
		D29B3837.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D29B3837.ForeColor = Color.Black;
		D29B3837.Location = new Point(0, 0);
		D29B3837.Name = "bunifuCustomLabel1";
		D29B3837.Size = new Size(359, 31);
		D29B3837.TabIndex = 12;
		D29B3837.Text = "Cấu hình Xem Watch";
		D29B3837.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(D29B3837);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += C1899514;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(D9398789);
		panel1.Controls.Add(A3855093);
		panel1.Controls.Add(plCountComment);
		panel1.Controls.Add(plCountShareWall);
		panel1.Controls.Add(A3BE4FBC);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(B0B3B8B5);
		panel1.Controls.Add(A4AA0838);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudTimeWatchTo);
		panel1.Controls.Add(D6BE199C);
		panel1.Controls.Add(nudTimeWatchFrom);
		panel1.Controls.Add(B63C3E1E);
		panel1.Controls.Add(D5A5492B);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(B12B840F);
		panel1.Controls.Add(D58F310B);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(B1ACD3A9);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(A6138A87);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 470);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		D9398789.Controls.Add(nudFollowFrom);
		D9398789.Controls.Add(label15);
		D9398789.Controls.Add(AFA70996);
		D9398789.Controls.Add(E8A4F803);
		D9398789.Location = new Point(132, 212);
		D9398789.Name = "plFollow";
		D9398789.Size = new Size(200, 25);
		D9398789.TabIndex = 46;
		nudFollowFrom.Location = new Point(1, 1);
		nudFollowFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudFollowFrom.Name = "nudFollowFrom";
		nudFollowFrom.Size = new Size(56, 23);
		nudFollowFrom.TabIndex = 1;
		label15.AutoSize = true;
		label15.Location = new Point(159, 3);
		label15.Name = "label15";
		label15.Size = new Size(35, 16);
		label15.TabIndex = 35;
		label15.Text = "page";
		AFA70996.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AFA70996.Location = new Point(63, 3);
		AFA70996.Name = "label16";
		AFA70996.Size = new Size(29, 16);
		AFA70996.TabIndex = 37;
		AFA70996.Text = ">";
		AFA70996.TextAlign = ContentAlignment.MiddleCenter;
		E8A4F803.Location = new Point(98, 1);
		E8A4F803.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E8A4F803.Name = "nudFollowTo";
		E8A4F803.Size = new Size(56, 23);
		E8A4F803.TabIndex = 2;
		A3855093.AutoSize = true;
		A3855093.Cursor = Cursors.Hand;
		A3855093.Location = new Point(30, 214);
		A3855093.Name = "ckbFollow";
		A3855093.Size = new Size(63, 20);
		A3855093.TabIndex = 45;
		A3855093.Text = "Follow";
		A3855093.UseVisualStyleBackColor = true;
		A3855093.CheckedChanged += A3855093_CheckedChanged;
		plCountComment.Controls.Add(nudCountCommentFrom);
		plCountComment.Controls.Add(B4392E3C);
		plCountComment.Controls.Add(B91C6724);
		plCountComment.Controls.Add(nudCountCommentTo);
		plCountComment.Location = new Point(132, 186);
		plCountComment.Name = "plCountComment";
		plCountComment.Size = new Size(200, 25);
		plCountComment.TabIndex = 44;
		nudCountCommentFrom.Location = new Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		B4392E3C.AutoSize = true;
		B4392E3C.Location = new Point(159, 3);
		B4392E3C.Name = "label13";
		B4392E3C.Size = new Size(24, 16);
		B4392E3C.TabIndex = 35;
		B4392E3C.Text = "lần";
		B91C6724.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B91C6724.Location = new Point(63, 3);
		B91C6724.Name = "label14";
		B91C6724.Size = new Size(29, 16);
		B91C6724.TabIndex = 37;
		B91C6724.Text = ">";
		B91C6724.TextAlign = ContentAlignment.MiddleCenter;
		nudCountCommentTo.Location = new Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		plCountShareWall.Controls.Add(nudCountShareFrom);
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(label12);
		plCountShareWall.Controls.Add(BCB38C86);
		plCountShareWall.Location = new Point(132, 158);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new Size(200, 25);
		plCountShareWall.TabIndex = 43;
		nudCountShareFrom.Location = new Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new Point(159, 3);
		label11.Name = "label11";
		label11.Size = new Size(24, 16);
		label11.TabIndex = 35;
		label11.Text = "lần";
		label12.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label12.Location = new Point(63, 3);
		label12.Name = "label12";
		label12.Size = new Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = ">";
		label12.TextAlign = ContentAlignment.MiddleCenter;
		BCB38C86.Location = new Point(98, 1);
		BCB38C86.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BCB38C86.Name = "nudCountShareTo";
		BCB38C86.Size = new Size(56, 23);
		BCB38C86.TabIndex = 2;
		A3BE4FBC.Controls.Add(nudCountLikeFrom);
		A3BE4FBC.Controls.Add(label9);
		A3BE4FBC.Controls.Add(label10);
		A3BE4FBC.Controls.Add(nudCountLikeTo);
		A3BE4FBC.Location = new Point(132, 130);
		A3BE4FBC.Name = "plCountLike";
		A3BE4FBC.Size = new Size(200, 25);
		A3BE4FBC.TabIndex = 42;
		nudCountLikeFrom.Location = new Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new Point(159, 3);
		label9.Name = "label9";
		label9.Size = new Size(24, 16);
		label9.TabIndex = 35;
		label9.Text = "lần";
		label10.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label10.Location = new Point(63, 3);
		label10.Name = "label10";
		label10.Size = new Size(29, 16);
		label10.TabIndex = 37;
		label10.Text = ">";
		label10.TextAlign = ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		plComment.Anchor = AnchorStyles.Bottom;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(linkLabel1);
		plComment.Controls.Add(button2);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(CCADFA86);
		plComment.Controls.Add(E589B22A);
		plComment.Location = new Point(48, 249);
		plComment.Name = "plComment";
		plComment.Size = new Size(278, 164);
		plComment.TabIndex = 8;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = Cursors.Hand;
		linkLabel1.Location = new Point(165, 4);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(81, 16);
		linkLabel1.TabIndex = 48;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += D609EC3E;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(247, 1);
		button2.Name = "button2";
		button2.Size = new Size(23, 23);
		button2.TabIndex = 46;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		txtComment.Location = new Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(264, 114);
		txtComment.TabIndex = 45;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += C21A16B8;
		CCADFA86.AutoSize = true;
		CCADFA86.Location = new Point(4, 141);
		CCADFA86.Name = "label8";
		CCADFA86.Size = new Size(265, 16);
		CCADFA86.TabIndex = 0;
		CCADFA86.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		E589B22A.AutoSize = true;
		E589B22A.Location = new Point(3, 5);
		E589B22A.Name = "lblStatus";
		E589B22A.Size = new Size(139, 16);
		E589B22A.TabIndex = 0;
		E589B22A.Text = "Nội dung bình luận (0):";
		B0B3B8B5.AutoSize = true;
		B0B3B8B5.Cursor = Cursors.Hand;
		B0B3B8B5.Location = new Point(30, 188);
		B0B3B8B5.Name = "ckbComment";
		B0B3B8B5.Size = new Size(81, 20);
		B0B3B8B5.TabIndex = 7;
		B0B3B8B5.Text = "Comment";
		B0B3B8B5.UseVisualStyleBackColor = true;
		B0B3B8B5.CheckedChanged += B0B3B8B5_CheckedChanged;
		A4AA0838.AutoSize = true;
		A4AA0838.Cursor = Cursors.Hand;
		A4AA0838.Location = new Point(30, 160);
		A4AA0838.Name = "ckbShareWall";
		A4AA0838.Size = new Size(89, 20);
		A4AA0838.TabIndex = 6;
		A4AA0838.Text = "Share Wall";
		A4AA0838.UseVisualStyleBackColor = true;
		A4AA0838.CheckedChanged += FF069F35;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = Cursors.Hand;
		ckbInteract.Location = new Point(30, 132);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new Size(48, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += D135C2A0;
		nudTimeWatchTo.Location = new Point(229, 103);
		nudTimeWatchTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWatchTo.Name = "nudTimeWatchTo";
		nudTimeWatchTo.Size = new Size(56, 23);
		nudTimeWatchTo.TabIndex = 4;
		D6BE199C.Location = new Point(229, 76);
		D6BE199C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D6BE199C.Name = "nudSoLuongTo";
		D6BE199C.Size = new Size(56, 23);
		D6BE199C.TabIndex = 2;
		nudTimeWatchFrom.Location = new Point(132, 103);
		nudTimeWatchFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWatchFrom.Name = "nudTimeWatchFrom";
		nudTimeWatchFrom.Size = new Size(56, 23);
		nudTimeWatchFrom.TabIndex = 3;
		B63C3E1E.Location = new Point(132, 76);
		B63C3E1E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B63C3E1E.Name = "nudSoLuongFrom";
		B63C3E1E.Size = new Size(56, 23);
		B63C3E1E.TabIndex = 1;
		D5A5492B.Location = new Point(132, 49);
		D5A5492B.Name = "txtTenHanhDong";
		D5A5492B.Size = new Size(194, 23);
		D5A5492B.TabIndex = 0;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(194, 105);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(194, 78);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		B12B840F.AutoSize = true;
		B12B840F.Location = new Point(290, 105);
		B12B840F.Name = "label6";
		B12B840F.Size = new Size(30, 16);
		B12B840F.TabIndex = 36;
		B12B840F.Text = "giây";
		D58F310B.AutoSize = true;
		D58F310B.Location = new Point(290, 78);
		D58F310B.Name = "label4";
		D58F310B.Size = new Size(37, 16);
		D58F310B.TabIndex = 35;
		D58F310B.Text = "video";
		label5.AutoSize = true;
		label5.Location = new Point(27, 105);
		label5.Name = "label5";
		label5.Size = new Size(93, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian xem:";
		label2.AutoSize = true;
		label2.Location = new Point(27, 78);
		label2.Name = "label2";
		label2.Size = new Size(97, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng video:";
		B1ACD3A9.AutoSize = true;
		B1ACD3A9.Location = new Point(27, 52);
		B1ACD3A9.Name = "label1";
		B1ACD3A9.Size = new Size(98, 16);
		B1ACD3A9.TabIndex = 31;
		B1ACD3A9.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(189, 428);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		A6138A87.Anchor = AnchorStyles.Bottom;
		A6138A87.BackColor = Color.FromArgb(53, 120, 229);
		A6138A87.Cursor = Cursors.Hand;
		A6138A87.FlatAppearance.BorderSize = 0;
		A6138A87.FlatStyle = FlatStyle.Flat;
		A6138A87.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A6138A87.ForeColor = Color.White;
		A6138A87.Location = new Point(82, 428);
		A6138A87.Name = "btnAdd";
		A6138A87.Size = new Size(92, 29);
		A6138A87.TabIndex = 9;
		A6138A87.Text = "Thêm";
		A6138A87.UseVisualStyleBackColor = false;
		A6138A87.Click += A6138A87_Click;
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
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 470);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatch";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += E3B25F1F_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		D9398789.ResumeLayout(performLayout: false);
		D9398789.PerformLayout();
		((ISupportInitialize)nudFollowFrom).EndInit();
		((ISupportInitialize)E8A4F803).EndInit();
		plCountComment.ResumeLayout(performLayout: false);
		plCountComment.PerformLayout();
		((ISupportInitialize)nudCountCommentFrom).EndInit();
		((ISupportInitialize)nudCountCommentTo).EndInit();
		plCountShareWall.ResumeLayout(performLayout: false);
		plCountShareWall.PerformLayout();
		((ISupportInitialize)nudCountShareFrom).EndInit();
		((ISupportInitialize)BCB38C86).EndInit();
		A3BE4FBC.ResumeLayout(performLayout: false);
		A3BE4FBC.PerformLayout();
		((ISupportInitialize)nudCountLikeFrom).EndInit();
		((ISupportInitialize)nudCountLikeTo).EndInit();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		((ISupportInitialize)nudTimeWatchTo).EndInit();
		((ISupportInitialize)D6BE199C).EndInit();
		((ISupportInitialize)nudTimeWatchFrom).EndInit();
		((ISupportInitialize)B63C3E1E).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
