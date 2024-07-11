using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBaiVietNewsfeed : Form
{
	private JSON_Settings D6014730;

	private string string_0;

	private string string_1;

	private string BF9F2FAF;

	private int int_0;

	public static bool C4B3DD27;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel B81A248D;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown F50BCEA6;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label6;

	private Label label4;

	private Label D81B8182;

	private Label F72C4E10;

	private Label D72172AF;

	private Button btnCancel;

	private Button CF3FCA39;

	private BunifuCards bunifuCards1;

	private Panel C207D502;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plCommentText;

	private Label AB39B412;

	private CheckBox ckbComment;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private RichTextBox txtComment;

	private Button C53D97BD;

	private Button A0A4F903;

	private RadioButton B2A87A9E;

	private RadioButton E9380E18;

	private Label label9;

	private Label label8;

	private Button button2;

	private Button button3;

	private Button button4;

	private LinkLabel linkLabel1;

	private Panel BD2883AC;

	private CheckBox ckbCommentText;

	private CheckBox ckbSendAnh;

	private Panel B53548B6;

	private TextBox F23EF138;

	private Label E10A2592;

	public fHDBaiVietNewsfeed(string string_2, int int_1 = 0, string string_3 = "")
	{
		A10E540F();
		C4B3DD27 = false;
		string_0 = string_2;
		BF9F2FAF = string_3;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietNewsfeed");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			CF3FCA39.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D6014730 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void AF0A0D88()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(D72172AF);
		Language.smethod_0(F72C4E10);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(D81B8182);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(ckbShareWall);
		Language.smethod_0(ckbComment);
		Language.smethod_0(AB39B412);
		Language.smethod_0(button2);
		Language.smethod_0(label8);
		Language.smethod_0(CF3FCA39);
		Language.smethod_0(btnCancel);
	}

	private void C43DC98F_Load(object sender, EventArgs e)
	{
		try
		{
			F50BCEA6.Value = D6014730.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = D6014730.GetValueInt("nudSoLuongTo", 5);
			nudDelayFrom.Value = D6014730.GetValueInt("nudDelayFrom", 5);
			nudDelayTo.Value = D6014730.GetValueInt("nudDelayTo", 7);
			ckbInteract.Checked = D6014730.GetValueBool("ckbInteract");
			ckbShareWall.Checked = D6014730.GetValueBool("ckbShareWall");
			ckbComment.Checked = D6014730.GetValueBool("ckbComment");
			ckbCommentText.Checked = D6014730.GetValueBool("ckbCommentText");
			txtComment.Text = D6014730.GetValue("txtComment");
			if (D6014730.GetValueInt("typeNganCach") == 1)
			{
				B2A87A9E.Checked = true;
			}
			else
			{
				E9380E18.Checked = true;
			}
			ckbSendAnh.Checked = D6014730.GetValueBool("ckbSendAnh");
			F23EF138.Text = D6014730.GetValue("txtAnh");
		}
		catch
		{
		}
		CBA60E83();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B72E52A6(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") != DialogResult.Yes)
			{
				return;
			}
			string text = txtTenHanhDong.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			if (ckbComment.Checked)
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
			gClass.GetJson("nudSoLuongFrom", F50BCEA6.Value);
			gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
			gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass.GetJson("ckbInteract", ckbInteract.Checked);
			gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass.GetJson("ckbComment", ckbComment.Checked);
			gClass.GetJson("ckbCommentText", ckbCommentText.Checked);
			gClass.GetJson("txtComment", txtComment.Text.Trim());
			int num = 0;
			if (B2A87A9E.Checked)
			{
				num = 1;
			}
			gClass.GetJson("typeNganCach", num);
			gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass.GetJson("txtAnh", F23EF138.Text.Trim());
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(string_0, text, string_1, string_))
			{
				C4B3DD27 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		else
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") != DialogResult.Yes)
			{
				return;
			}
			string text2 = txtTenHanhDong.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> a2AB53A2 = txtComment.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudSoLuongFrom", F50BCEA6.Value);
			gClass2.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
			gClass2.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass2.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass2.GetJson("ckbInteract", ckbInteract.Checked);
			gClass2.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass2.GetJson("ckbComment", ckbComment.Checked);
			gClass2.GetJson("ckbCommentText", ckbCommentText.Checked);
			gClass2.GetJson("txtComment", txtComment.Text.Trim());
			int num2 = 0;
			if (B2A87A9E.Checked)
			{
				num2 = 1;
			}
			gClass2.GetJson("typeNganCach", num2);
			gClass2.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.GetJson("txtAnh", F23EF138.Text.Trim());
			string text3 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(BF9F2FAF, text2, text3))
			{
				C4B3DD27 = true;
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

	private void B81A248D_Paint(object sender, PaintEventArgs e)
	{
		if (B81A248D.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B81A248D.ClientSize.Width - num, B81A248D.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			AB39B412.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void CBA60E83()
	{
		method_2(null, null);
		ckbComment_CheckedChanged(null, null);
		A83B5508(null, null);
		ckbCommentText_CheckedChanged(null, null);
		E4A2B893(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		BD2883AC.Enabled = ckbComment.Checked;
	}

	private void F524980F(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_3()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!E9380E18.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			AB39B412.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void C53D97BD_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 207;
	}

	private void A0A4F903_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 165;
	}

	private void A83B5508(object sender, EventArgs e)
	{
		method_3();
	}

	private void D28B2E82(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			A0A4F903.Visible = true;
			C53D97BD.Visible = true;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void D6B6F585(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtComment.Focus();
	}

	private void EB8CA2B7(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void plCommentText_Paint(object sender, PaintEventArgs e)
	{
	}

	private void F5208094(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void BD2883AC_Paint(object sender, PaintEventArgs e)
	{
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
	}

	private void E4A2B893(object sender, EventArgs e)
	{
		B53548B6.Enabled = ckbSendAnh.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A10E540F()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBaiVietNewsfeed));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		C207D502 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		B81A248D = new Panel();
		BD2883AC = new Panel();
		plCommentText = new Panel();
		linkLabel1 = new LinkLabel();
		button3 = new Button();
		button4 = new Button();
		button2 = new Button();
		txtComment = new RichTextBox();
		C53D97BD = new Button();
		A0A4F903 = new Button();
		B2A87A9E = new RadioButton();
		E9380E18 = new RadioButton();
		label9 = new Label();
		label8 = new Label();
		AB39B412 = new Label();
		B53548B6 = new Panel();
		F23EF138 = new TextBox();
		E10A2592 = new Label();
		ckbSendAnh = new CheckBox();
		ckbCommentText = new CheckBox();
		ckbComment = new CheckBox();
		ckbShareWall = new CheckBox();
		ckbInteract = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		F50BCEA6 = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		label3 = new Label();
		label6 = new Label();
		label4 = new Label();
		D81B8182 = new Label();
		F72C4E10 = new Label();
		D72172AF = new Label();
		btnCancel = new Button();
		CF3FCA39 = new Button();
		bunifuCards1 = new BunifuCards();
		C207D502.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		B81A248D.SuspendLayout();
		BD2883AC.SuspendLayout();
		plCommentText.SuspendLayout();
		B53548B6.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)F50BCEA6).BeginInit();
		bunifuCards1.SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Newsfeed";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = C207D502;
		bunifuDragControl_1.Vertical = true;
		C207D502.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C207D502.BackColor = Color.White;
		C207D502.Controls.Add(button1);
		C207D502.Controls.Add(pictureBox1);
		C207D502.Controls.Add(bunifuCustomLabel1);
		C207D502.Cursor = Cursors.SizeAll;
		C207D502.Location = new Point(0, 3);
		C207D502.Name = "pnlHeader";
		C207D502.Size = new Size(359, 31);
		C207D502.TabIndex = 9;
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
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += D28B2E82;
		B81A248D.BackColor = Color.White;
		B81A248D.BorderStyle = BorderStyle.FixedSingle;
		B81A248D.Controls.Add(BD2883AC);
		B81A248D.Controls.Add(ckbComment);
		B81A248D.Controls.Add(ckbShareWall);
		B81A248D.Controls.Add(ckbInteract);
		B81A248D.Controls.Add(nudDelayTo);
		B81A248D.Controls.Add(nudSoLuongTo);
		B81A248D.Controls.Add(nudDelayFrom);
		B81A248D.Controls.Add(F50BCEA6);
		B81A248D.Controls.Add(txtTenHanhDong);
		B81A248D.Controls.Add(label7);
		B81A248D.Controls.Add(label3);
		B81A248D.Controls.Add(label6);
		B81A248D.Controls.Add(label4);
		B81A248D.Controls.Add(D81B8182);
		B81A248D.Controls.Add(F72C4E10);
		B81A248D.Controls.Add(D72172AF);
		B81A248D.Controls.Add(btnCancel);
		B81A248D.Controls.Add(CF3FCA39);
		B81A248D.Controls.Add(bunifuCards1);
		B81A248D.Cursor = Cursors.Arrow;
		B81A248D.Dock = DockStyle.Fill;
		B81A248D.Location = new Point(0, 0);
		B81A248D.Name = "panel1";
		B81A248D.Size = new Size(362, 524);
		B81A248D.TabIndex = 0;
		B81A248D.Paint += B81A248D_Paint;
		BD2883AC.BorderStyle = BorderStyle.FixedSingle;
		BD2883AC.Controls.Add(plCommentText);
		BD2883AC.Controls.Add(B53548B6);
		BD2883AC.Controls.Add(ckbSendAnh);
		BD2883AC.Controls.Add(ckbCommentText);
		BD2883AC.Location = new Point(30, 213);
		BD2883AC.Name = "plComment";
		BD2883AC.Size = new Size(306, 262);
		BD2883AC.TabIndex = 39;
		BD2883AC.Paint += BD2883AC_Paint;
		plCommentText.BorderStyle = BorderStyle.FixedSingle;
		plCommentText.Controls.Add(linkLabel1);
		plCommentText.Controls.Add(button3);
		plCommentText.Controls.Add(button4);
		plCommentText.Controls.Add(button2);
		plCommentText.Controls.Add(txtComment);
		plCommentText.Controls.Add(C53D97BD);
		plCommentText.Controls.Add(A0A4F903);
		plCommentText.Controls.Add(B2A87A9E);
		plCommentText.Controls.Add(E9380E18);
		plCommentText.Controls.Add(label9);
		plCommentText.Controls.Add(label8);
		plCommentText.Controls.Add(AB39B412);
		plCommentText.Location = new Point(24, 29);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new Size(278, 164);
		plCommentText.TabIndex = 8;
		plCommentText.Paint += plCommentText_Paint;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = Cursors.Hand;
		linkLabel1.Location = new Point(163, 142);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(81, 16);
		linkLabel1.TabIndex = 176;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += F5208094;
		button3.Cursor = Cursors.Help;
		button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(227, 185);
		button3.Name = "button3";
		button3.Size = new Size(21, 23);
		button3.TabIndex = 127;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += EB8CA2B7;
		button4.Cursor = Cursors.Help;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(227, 162);
		button4.Name = "button4";
		button4.Size = new Size(21, 23);
		button4.TabIndex = 128;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button4.Click += D6B6F585;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(247, 139);
		button2.Name = "button2";
		button2.Size = new Size(23, 23);
		button2.TabIndex = 126;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		txtComment.Location = new Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(263, 111);
		txtComment.TabIndex = 114;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += F524980F;
		C53D97BD.BackgroundImage = Resources.Bitmap_83;
		C53D97BD.Cursor = Cursors.Hand;
		C53D97BD.FlatAppearance.BorderColor = Color.Silver;
		C53D97BD.FlatStyle = FlatStyle.Flat;
		C53D97BD.Location = new Point(221, -1);
		C53D97BD.Name = "btnDown";
		C53D97BD.Size = new Size(25, 25);
		C53D97BD.TabIndex = 112;
		C53D97BD.Click += C53D97BD_Click;
		A0A4F903.BackgroundImage = Resources.E536C319;
		A0A4F903.Cursor = Cursors.Hand;
		A0A4F903.FlatAppearance.BorderColor = Color.Silver;
		A0A4F903.FlatStyle = FlatStyle.Flat;
		A0A4F903.Location = new Point(252, -1);
		A0A4F903.Name = "btnUp";
		A0A4F903.Size = new Size(25, 25);
		A0A4F903.TabIndex = 113;
		A0A4F903.Click += A0A4F903_Click;
		B2A87A9E.AutoSize = true;
		B2A87A9E.Cursor = Cursors.Hand;
		B2A87A9E.Location = new Point(68, 182);
		B2A87A9E.Name = "rbNganCachKyTu";
		B2A87A9E.Size = new Size(159, 20);
		B2A87A9E.TabIndex = 111;
		B2A87A9E.Text = "Nội dung có nhiều dòng";
		B2A87A9E.UseVisualStyleBackColor = true;
		B2A87A9E.CheckedChanged += A83B5508;
		E9380E18.AutoSize = true;
		E9380E18.Checked = true;
		E9380E18.Cursor = Cursors.Hand;
		E9380E18.Location = new Point(68, 161);
		E9380E18.Name = "rbNganCachMoiDong";
		E9380E18.Size = new Size(155, 20);
		E9380E18.TabIndex = 110;
		E9380E18.TabStop = true;
		E9380E18.Text = "Nội dung chỉ có 1 dòng";
		E9380E18.UseVisualStyleBackColor = true;
		E9380E18.CheckedChanged += A83B5508;
		label9.AutoSize = true;
		label9.Location = new Point(3, 161);
		label9.Name = "label9";
		label9.Size = new Size(64, 16);
		label9.TabIndex = 109;
		label9.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new Point(3, 142);
		label8.Name = "label8";
		label8.Size = new Size(143, 16);
		label8.TabIndex = 107;
		label8.Text = "(Spin nội dung {a|b|c})";
		AB39B412.AutoSize = true;
		AB39B412.Location = new Point(4, 4);
		AB39B412.Name = "lblStatus";
		AB39B412.Size = new Size(139, 16);
		AB39B412.TabIndex = 0;
		AB39B412.Text = "Nội dung bình luận (0):";
		B53548B6.BorderStyle = BorderStyle.FixedSingle;
		B53548B6.Controls.Add(F23EF138);
		B53548B6.Controls.Add(E10A2592);
		B53548B6.Enabled = false;
		B53548B6.Location = new Point(21, 223);
		B53548B6.Name = "plAnh";
		B53548B6.Size = new Size(281, 31);
		B53548B6.TabIndex = 169;
		F23EF138.Location = new Point(136, 3);
		F23EF138.Name = "txtAnh";
		F23EF138.Size = new Size(140, 23);
		F23EF138.TabIndex = 155;
		E10A2592.AutoSize = true;
		E10A2592.Location = new Point(3, 6);
		E10A2592.Name = "label16";
		E10A2592.Size = new Size(137, 16);
		E10A2592.TabIndex = 39;
		E10A2592.Text = "Đường dẫn folder ảnh:";
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = Cursors.Hand;
		ckbSendAnh.Location = new Point(4, 199);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new Size(103, 20);
		ckbSendAnh.TabIndex = 10;
		ckbSendAnh.Text = "Bình luận ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += E4A2B893;
		ckbCommentText.AutoSize = true;
		ckbCommentText.Cursor = Cursors.Hand;
		ckbCommentText.Location = new Point(4, 4);
		ckbCommentText.Name = "ckbCommentText";
		ckbCommentText.Size = new Size(127, 20);
		ckbCommentText.TabIndex = 9;
		ckbCommentText.Text = "Bình luận văn bản";
		ckbCommentText.UseVisualStyleBackColor = true;
		ckbCommentText.CheckedChanged += ckbCommentText_CheckedChanged;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(30, 193);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(130, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += ckbComment_CheckedChanged;
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = Cursors.Hand;
		ckbShareWall.Location = new Point(30, 167);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new Size(122, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Chia sẻ về tường";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = Cursors.Hand;
		ckbInteract.Location = new Point(30, 141);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new Size(48, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudSoLuongTo.Location = new Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudDelayFrom.Location = new Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		F50BCEA6.Location = new Point(132, 80);
		F50BCEA6.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F50BCEA6.Name = "nudSoLuongFrom";
		F50BCEA6.Size = new Size(56, 23);
		F50BCEA6.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new Point(194, 113);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label3.Location = new Point(194, 82);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(290, 113);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new Point(290, 82);
		label4.Name = "label4";
		label4.Size = new Size(24, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		D81B8182.AutoSize = true;
		D81B8182.Location = new Point(27, 113);
		D81B8182.Name = "label5";
		D81B8182.Size = new Size(89, 16);
		D81B8182.TabIndex = 34;
		D81B8182.Text = "Thơ\u0300i gian chơ\u0300:";
		F72C4E10.AutoSize = true;
		F72C4E10.Location = new Point(27, 82);
		F72C4E10.Name = "label2";
		F72C4E10.Size = new Size(108, 16);
		F72C4E10.TabIndex = 32;
		F72C4E10.Text = "Sô\u0301 lươ\u0323ng ba\u0300i viê\u0301t:";
		D72172AF.AutoSize = true;
		D72172AF.Location = new Point(27, 52);
		D72172AF.Name = "label1";
		D72172AF.Size = new Size(98, 16);
		D72172AF.TabIndex = 31;
		D72172AF.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(189, 481);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		CF3FCA39.Anchor = AnchorStyles.Bottom;
		CF3FCA39.BackColor = Color.FromArgb(53, 120, 229);
		CF3FCA39.Cursor = Cursors.Hand;
		CF3FCA39.FlatAppearance.BorderSize = 0;
		CF3FCA39.FlatStyle = FlatStyle.Flat;
		CF3FCA39.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CF3FCA39.ForeColor = Color.White;
		CF3FCA39.Location = new Point(82, 481);
		CF3FCA39.Name = "btnAdd";
		CF3FCA39.Size = new Size(92, 29);
		CF3FCA39.TabIndex = 9;
		CF3FCA39.Text = "Thêm";
		CF3FCA39.UseVisualStyleBackColor = false;
		CF3FCA39.Click += B72E52A6;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(C207D502);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 524);
		base.Controls.Add(B81A248D);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNewsfeed";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C43DC98F_Load;
		C207D502.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		B81A248D.ResumeLayout(performLayout: false);
		B81A248D.PerformLayout();
		BD2883AC.ResumeLayout(performLayout: false);
		BD2883AC.PerformLayout();
		plCommentText.ResumeLayout(performLayout: false);
		plCommentText.PerformLayout();
		B53548B6.ResumeLayout(performLayout: false);
		B53548B6.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)F50BCEA6).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
