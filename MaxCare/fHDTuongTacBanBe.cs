using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBanBe : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string AC1BB301;

	private string string_1;

	private int int_0;

	public static bool B70A01A3;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A98CE115;

	private Panel CD13F8BA;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button B511AF93;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button D59B0FAA;

	private PictureBox AFB7D0BD;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plCommentText;

	private Label label8;

	private Label lblStatus;

	private CheckBox DE2D4DB3;

	private CheckBox C51C5014;

	private CheckBox AF835B87;

	private RadioButton rbNganCachKyTu;

	private RadioButton B5BB230D;

	private Label label9;

	private Button btnDown;

	private Button btnUp;

	private RichTextBox txtComment;

	private Panel plCountComment;

	private NumericUpDown E4B08C25;

	private Label label13;

	private Label E61EB088;

	private NumericUpDown D1B56205;

	private Panel F72D32BD;

	private NumericUpDown nudCountShareFrom;

	private Label label11;

	private Label FB9ED222;

	private NumericUpDown C11487A9;

	private Panel plCountLike;

	private NumericUpDown nudCountLikeFrom;

	private Label label2;

	private Label C61F7409;

	private NumericUpDown nudCountLikeTo;

	private NumericUpDown nudDelayTo;

	private NumericUpDown ADA119B2;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown E9A63D0E;

	private Label label15;

	private Label E78E3602;

	private Label label17;

	private Label DEAB1615;

	private Label C1032D1C;

	private Label EF8C1F07;

	private GroupBox C21C1938;

	private Label label49;

	private NumericUpDown DEA79B92;

	private Label label68;

	private NumericUpDown D2A62F27;

	private Label label66;

	private Button A5855D19;

	private Button AAA5943B;

	private Button button4;

	private LinkLabel A839A2B0;

	private Panel D805462D;

	private TextBox DF267494;

	private Label label3;

	private CheckBox ckbSendAnh;

	private Label label4;

	private Panel plComment;

	private CheckBox ckbCommentText;

	private CheckBox ckbNangCao;

	public fHDTuongTacBanBe(string string_2, int E98F2007 = 0, string string_3 = "")
	{
		A3095B1C();
		B70A01A3 = false;
		string_0 = string_2;
		string_1 = string_3;
		int_0 = E98F2007;
		if (InteractSQL.B484648C("", "HDTuongTacBanBe").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBanBe', 'Tương tác Bạn bè');");
		}
		string text = "";
		switch (E98F2007)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTuongTacBanBe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			AC1BB301 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			B511AF93.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void B2290127()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label49);
		Language.smethod_0(label66);
		Language.smethod_0(label68);
		Language.smethod_0(C21C1938);
		Language.smethod_0(EF8C1F07);
		Language.smethod_0(E78E3602);
		Language.smethod_0(DEAB1615);
		Language.smethod_0(C1032D1C);
		Language.smethod_0(label15);
		Language.smethod_0(label17);
		Language.smethod_0(C61F7409);
		Language.smethod_0(label2);
		Language.smethod_0(FB9ED222);
		Language.smethod_0(label11);
		Language.smethod_0(E61EB088);
		Language.smethod_0(label13);
		Language.smethod_0(lblStatus);
		Language.smethod_0(A5855D19);
		Language.smethod_0(label8);
		Language.smethod_0(B511AF93);
		Language.smethod_0(btnCancel);
	}

	private void C72A5117_Load(object sender, EventArgs e)
	{
		try
		{
			DEA79B92.Value = gclass8_0.GetValueInt("nudSoLuongBanBeFrom", 1);
			D2A62F27.Value = gclass8_0.GetValueInt("nudSoLuongBanBeTo", 3);
			E9A63D0E.Value = gclass8_0.GetValueInt("nudTimeFrom", 10);
			ADA119B2.Value = gclass8_0.GetValueInt("nudTimeTo", 30);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 1);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 3);
			nudCountLikeFrom.Value = gclass8_0.GetValueInt("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = gclass8_0.GetValueInt("nudCountLikeTo", 3);
			nudCountShareFrom.Value = gclass8_0.GetValueInt("nudCountShareFrom", 1);
			C11487A9.Value = gclass8_0.GetValueInt("nudCountShareTo", 3);
			E4B08C25.Value = gclass8_0.GetValueInt("nudCountCommentFrom", 1);
			D1B56205.Value = gclass8_0.GetValueInt("nudCountCommentTo", 3);
			C51C5014.Checked = gclass8_0.GetValueBool("ckbInteract");
			AF835B87.Checked = gclass8_0.GetValueBool("ckbShareWall");
			ckbNangCao.Checked = gclass8_0.GetValueBool("ckbNangCao");
			DE2D4DB3.Checked = gclass8_0.GetValueBool("ckbComment");
			ckbCommentText.Checked = gclass8_0.GetValueBool("ckbCommentText");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			ckbSendAnh.Checked = gclass8_0.GetValueBool("ckbSendAnh");
			DF267494.Text = gclass8_0.GetValue("txtAnh");
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				B5BB230D.Checked = true;
			}
		}
		catch
		{
		}
		method_1();
	}

	private void D59B0FAA_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B511AF93_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (DE2D4DB3.Checked)
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
		gClass.GetJson("nudSoLuongBanBeFrom", DEA79B92.Value);
		gClass.GetJson("nudSoLuongBanBeTo", D2A62F27.Value);
		gClass.GetJson("nudTimeFrom", E9A63D0E.Value);
		gClass.GetJson("nudTimeTo", ADA119B2.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbInteract", C51C5014.Checked);
		gClass.GetJson("ckbShareWall", AF835B87.Checked);
		gClass.GetJson("ckbNangCao", ckbNangCao.Checked);
		gClass.GetJson("ckbComment", DE2D4DB3.Checked);
		gClass.GetJson("ckbCommentText", ckbCommentText.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.GetJson("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.GetJson("nudCountShareFrom", nudCountShareFrom.Value);
		gClass.GetJson("nudCountShareTo", C11487A9.Value);
		gClass.GetJson("nudCountCommentFrom", E4B08C25.Value);
		gClass.GetJson("nudCountCommentTo", D1B56205.Value);
		gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
		gClass.GetJson("txtAnh", DF267494.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, AC1BB301, string_))
				{
					B70A01A3 = true;
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
				B70A01A3 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void E6A59B21(object sender, EventArgs e)
	{
		Close();
	}

	private void CD13F8BA_Paint(object sender, PaintEventArgs e)
	{
		if (CD13F8BA.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, CD13F8BA.ClientSize.Width - num, CD13F8BA.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!B5BB230D.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		C51C5014_CheckedChanged(null, null);
		DE2D4DB3_CheckedChanged(null, null);
		CA882083(null, null);
		ckbCommentText_CheckedChanged(null, null);
	}

	private void DE2D4DB3_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = DE2D4DB3.Checked;
	}

	private void A9AF42B3(object sender, EventArgs e)
	{
		plCommentText.Height = 162;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 210;
	}

	private void ED1D1786(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void C4AE8CA3(object sender, EventArgs e)
	{
		method_0();
	}

	private void A48D71AB(object sender, EventArgs e)
	{
		method_0();
	}

	private void C51C5014_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = C51C5014.Checked;
	}

	private void CA882083(object sender, EventArgs e)
	{
		F72D32BD.Enabled = AF835B87.Checked;
	}

	private void CE854921(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtComment.Focus();
	}

	private void AAA5943B_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void A839A2B0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void AA8BE038(object sender, EventArgs e)
	{
		D805462D.Enabled = ckbSendAnh.Checked;
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A3095B1C()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDTuongTacBanBe));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		A98CE115 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		D59B0FAA = new Button();
		AFB7D0BD = new PictureBox();
		CD13F8BA = new Panel();
		C21C1938 = new GroupBox();
		ckbNangCao = new CheckBox();
		plComment = new Panel();
		plCommentText = new Panel();
		A839A2B0 = new LinkLabel();
		AAA5943B = new Button();
		button4 = new Button();
		A5855D19 = new Button();
		txtComment = new RichTextBox();
		btnDown = new Button();
		btnUp = new Button();
		rbNganCachKyTu = new RadioButton();
		B5BB230D = new RadioButton();
		label9 = new Label();
		label8 = new Label();
		lblStatus = new Label();
		label4 = new Label();
		ckbCommentText = new CheckBox();
		plCountComment = new Panel();
		E4B08C25 = new NumericUpDown();
		label13 = new Label();
		E61EB088 = new Label();
		D1B56205 = new NumericUpDown();
		D805462D = new Panel();
		DF267494 = new TextBox();
		label3 = new Label();
		ckbSendAnh = new CheckBox();
		EF8C1F07 = new Label();
		C51C5014 = new CheckBox();
		AF835B87 = new CheckBox();
		DE2D4DB3 = new CheckBox();
		C1032D1C = new Label();
		DEAB1615 = new Label();
		F72D32BD = new Panel();
		nudCountShareFrom = new NumericUpDown();
		label11 = new Label();
		FB9ED222 = new Label();
		C11487A9 = new NumericUpDown();
		label17 = new Label();
		plCountLike = new Panel();
		nudCountLikeFrom = new NumericUpDown();
		label2 = new Label();
		C61F7409 = new Label();
		nudCountLikeTo = new NumericUpDown();
		E78E3602 = new Label();
		nudDelayTo = new NumericUpDown();
		label15 = new Label();
		ADA119B2 = new NumericUpDown();
		E9A63D0E = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label49 = new Label();
		DEA79B92 = new NumericUpDown();
		label68 = new Label();
		D2A62F27 = new NumericUpDown();
		label66 = new Label();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		B511AF93 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)AFB7D0BD).BeginInit();
		CD13F8BA.SuspendLayout();
		C21C1938.SuspendLayout();
		plComment.SuspendLayout();
		plCommentText.SuspendLayout();
		plCountComment.SuspendLayout();
		((ISupportInitialize)E4B08C25).BeginInit();
		((ISupportInitialize)D1B56205).BeginInit();
		D805462D.SuspendLayout();
		F72D32BD.SuspendLayout();
		((ISupportInitialize)nudCountShareFrom).BeginInit();
		((ISupportInitialize)C11487A9).BeginInit();
		plCountLike.SuspendLayout();
		((ISupportInitialize)nudCountLikeFrom).BeginInit();
		((ISupportInitialize)nudCountLikeTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)ADA119B2).BeginInit();
		((ISupportInitialize)E9A63D0E).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)DEA79B92).BeginInit();
		((ISupportInitialize)D2A62F27).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(384, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Bạn bè";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		A98CE115.Fixed = true;
		A98CE115.Horizontal = true;
		A98CE115.TargetControl = pnlHeader;
		A98CE115.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D59B0FAA);
		pnlHeader.Controls.Add(AFB7D0BD);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(384, 31);
		pnlHeader.TabIndex = 9;
		D59B0FAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D59B0FAA.Cursor = Cursors.Hand;
		D59B0FAA.FlatAppearance.BorderSize = 0;
		D59B0FAA.FlatStyle = FlatStyle.Flat;
		D59B0FAA.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D59B0FAA.ForeColor = Color.White;
		D59B0FAA.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D59B0FAA.Location = new Point(353, 1);
		D59B0FAA.Name = "button1";
		D59B0FAA.Size = new Size(30, 30);
		D59B0FAA.TabIndex = 77;
		D59B0FAA.TextImageRelation = TextImageRelation.ImageBeforeText;
		D59B0FAA.UseVisualStyleBackColor = true;
		D59B0FAA.Click += D59B0FAA_Click;
		AFB7D0BD.Cursor = Cursors.Default;
		AFB7D0BD.Image = Resources.Bitmap_4;
		AFB7D0BD.Location = new Point(3, 2);
		AFB7D0BD.Name = "pictureBox1";
		AFB7D0BD.Size = new Size(34, 27);
		AFB7D0BD.SizeMode = PictureBoxSizeMode.Zoom;
		AFB7D0BD.TabIndex = 76;
		AFB7D0BD.TabStop = false;
		AFB7D0BD.Click += ED1D1786;
		CD13F8BA.BackColor = Color.White;
		CD13F8BA.BorderStyle = BorderStyle.FixedSingle;
		CD13F8BA.Controls.Add(C21C1938);
		CD13F8BA.Controls.Add(label49);
		CD13F8BA.Controls.Add(DEA79B92);
		CD13F8BA.Controls.Add(label68);
		CD13F8BA.Controls.Add(D2A62F27);
		CD13F8BA.Controls.Add(label66);
		CD13F8BA.Controls.Add(txtTenHanhDong);
		CD13F8BA.Controls.Add(label1);
		CD13F8BA.Controls.Add(btnCancel);
		CD13F8BA.Controls.Add(B511AF93);
		CD13F8BA.Controls.Add(bunifuCards1);
		CD13F8BA.Cursor = Cursors.Arrow;
		CD13F8BA.Dock = DockStyle.Fill;
		CD13F8BA.Location = new Point(0, 0);
		CD13F8BA.Name = "panel1";
		CD13F8BA.Size = new Size(387, 628);
		CD13F8BA.TabIndex = 0;
		CD13F8BA.Paint += CD13F8BA_Paint;
		C21C1938.Controls.Add(ckbNangCao);
		C21C1938.Controls.Add(plComment);
		C21C1938.Controls.Add(EF8C1F07);
		C21C1938.Controls.Add(C51C5014);
		C21C1938.Controls.Add(AF835B87);
		C21C1938.Controls.Add(DE2D4DB3);
		C21C1938.Controls.Add(C1032D1C);
		C21C1938.Controls.Add(DEAB1615);
		C21C1938.Controls.Add(F72D32BD);
		C21C1938.Controls.Add(label17);
		C21C1938.Controls.Add(plCountLike);
		C21C1938.Controls.Add(E78E3602);
		C21C1938.Controls.Add(nudDelayTo);
		C21C1938.Controls.Add(label15);
		C21C1938.Controls.Add(ADA119B2);
		C21C1938.Controls.Add(E9A63D0E);
		C21C1938.Controls.Add(nudDelayFrom);
		C21C1938.Location = new Point(21, 111);
		C21C1938.Name = "groupBox1";
		C21C1938.Size = new Size(343, 455);
		C21C1938.TabIndex = 124;
		C21C1938.TabStop = false;
		C21C1938.Text = "Cấu hình tương tác/Bạn bè";
		ckbNangCao.AutoSize = true;
		ckbNangCao.Cursor = Cursors.Hand;
		ckbNangCao.Location = new Point(119, 140);
		ckbNangCao.Name = "ckbNangCao";
		ckbNangCao.Size = new Size(129, 20);
		ckbNangCao.TabIndex = 173;
		ckbNangCao.Text = "Random nâng cao";
		ckbNangCao.UseVisualStyleBackColor = true;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(plCommentText);
		plComment.Controls.Add(label4);
		plComment.Controls.Add(ckbCommentText);
		plComment.Controls.Add(plCountComment);
		plComment.Controls.Add(D805462D);
		plComment.Controls.Add(ckbSendAnh);
		plComment.Location = new Point(21, 164);
		plComment.Name = "plComment";
		plComment.Size = new Size(317, 282);
		plComment.TabIndex = 172;
		plCommentText.BorderStyle = BorderStyle.FixedSingle;
		plCommentText.Controls.Add(A839A2B0);
		plCommentText.Controls.Add(AAA5943B);
		plCommentText.Controls.Add(button4);
		plCommentText.Controls.Add(A5855D19);
		plCommentText.Controls.Add(txtComment);
		plCommentText.Controls.Add(btnDown);
		plCommentText.Controls.Add(btnUp);
		plCommentText.Controls.Add(rbNganCachKyTu);
		plCommentText.Controls.Add(B5BB230D);
		plCommentText.Controls.Add(label9);
		plCommentText.Controls.Add(label8);
		plCommentText.Controls.Add(lblStatus);
		plCommentText.Location = new Point(27, 52);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new Size(281, 162);
		plCommentText.TabIndex = 10;
		A839A2B0.AutoSize = true;
		A839A2B0.Cursor = Cursors.Hand;
		A839A2B0.Location = new Point(167, 141);
		A839A2B0.Name = "linkLabel1";
		A839A2B0.Size = new Size(81, 16);
		A839A2B0.TabIndex = 180;
		A839A2B0.TabStop = true;
		A839A2B0.Text = "Random icon";
		A839A2B0.LinkClicked += A839A2B0_LinkClicked;
		AAA5943B.Cursor = Cursors.Help;
		AAA5943B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AAA5943B.Location = new Point(224, 182);
		AAA5943B.Name = "button3";
		AAA5943B.Size = new Size(21, 23);
		AAA5943B.TabIndex = 126;
		AAA5943B.Text = "?";
		AAA5943B.UseVisualStyleBackColor = true;
		AAA5943B.Click += AAA5943B_Click;
		button4.Cursor = Cursors.Help;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(224, 159);
		button4.Name = "button4";
		button4.Size = new Size(21, 23);
		button4.TabIndex = 127;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button4.Click += button4_Click;
		A5855D19.Cursor = Cursors.Help;
		A5855D19.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A5855D19.Location = new Point(250, 138);
		A5855D19.Name = "button2";
		A5855D19.Size = new Size(23, 23);
		A5855D19.TabIndex = 125;
		A5855D19.Text = "?";
		A5855D19.UseVisualStyleBackColor = true;
		A5855D19.Click += CE854921;
		txtComment.Location = new Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(266, 111);
		txtComment.TabIndex = 106;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += txtComment_TextChanged;
		btnDown.BackgroundImage = Resources.Bitmap_83;
		btnDown.Cursor = Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = Color.Silver;
		btnDown.FlatStyle = FlatStyle.Flat;
		btnDown.Location = new Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new Size(25, 25);
		btnDown.TabIndex = 7;
		btnDown.Click += btnDown_Click;
		btnUp.BackgroundImage = Resources.E536C319;
		btnUp.Cursor = Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = Color.Silver;
		btnUp.FlatStyle = FlatStyle.Flat;
		btnUp.Location = new Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new Size(25, 25);
		btnUp.TabIndex = 7;
		btnUp.Click += A9AF42B3;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = Cursors.Hand;
		rbNganCachKyTu.Location = new Point(69, 182);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new Size(159, 20);
		rbNganCachKyTu.TabIndex = 6;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += A48D71AB;
		B5BB230D.AutoSize = true;
		B5BB230D.Checked = true;
		B5BB230D.Cursor = Cursors.Hand;
		B5BB230D.Location = new Point(69, 161);
		B5BB230D.Name = "rbNganCachMoiDong";
		B5BB230D.Size = new Size(155, 20);
		B5BB230D.TabIndex = 5;
		B5BB230D.TabStop = true;
		B5BB230D.Text = "Nội dung chỉ có 1 dòng";
		B5BB230D.UseVisualStyleBackColor = true;
		B5BB230D.CheckedChanged += C4AE8CA3;
		label9.AutoSize = true;
		label9.Location = new Point(4, 161);
		label9.Name = "label9";
		label9.Size = new Size(64, 16);
		label9.TabIndex = 4;
		label9.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new Point(4, 141);
		label8.Name = "label8";
		label8.Size = new Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		label4.AutoSize = true;
		label4.Location = new Point(3, 7);
		label4.Name = "label4";
		label4.Size = new Size(63, 16);
		label4.TabIndex = 110;
		label4.Text = "Số lượng:";
		ckbCommentText.AutoSize = true;
		ckbCommentText.Cursor = Cursors.Hand;
		ckbCommentText.Location = new Point(6, 31);
		ckbCommentText.Name = "ckbCommentText";
		ckbCommentText.Size = new Size(127, 20);
		ckbCommentText.TabIndex = 171;
		ckbCommentText.Text = "Bình luận văn bản";
		ckbCommentText.UseVisualStyleBackColor = true;
		ckbCommentText.CheckedChanged += ckbCommentText_CheckedChanged;
		plCountComment.Controls.Add(E4B08C25);
		plCountComment.Controls.Add(label13);
		plCountComment.Controls.Add(E61EB088);
		plCountComment.Controls.Add(D1B56205);
		plCountComment.Location = new Point(95, 3);
		plCountComment.Name = "plCountComment";
		plCountComment.Size = new Size(196, 25);
		plCountComment.TabIndex = 118;
		E4B08C25.Location = new Point(1, 1);
		E4B08C25.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E4B08C25.Name = "nudCountCommentFrom";
		E4B08C25.Size = new Size(56, 23);
		E4B08C25.TabIndex = 1;
		label13.AutoSize = true;
		label13.Location = new Point(156, 3);
		label13.Name = "label13";
		label13.Size = new Size(24, 16);
		label13.TabIndex = 35;
		label13.Text = "lần";
		E61EB088.Location = new Point(63, 3);
		E61EB088.Name = "label14";
		E61EB088.Size = new Size(29, 16);
		E61EB088.TabIndex = 37;
		E61EB088.Text = "đê\u0301n";
		E61EB088.TextAlign = ContentAlignment.MiddleCenter;
		D1B56205.Location = new Point(98, 1);
		D1B56205.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D1B56205.Name = "nudCountCommentTo";
		D1B56205.Size = new Size(56, 23);
		D1B56205.TabIndex = 2;
		D805462D.BorderStyle = BorderStyle.FixedSingle;
		D805462D.Controls.Add(DF267494);
		D805462D.Controls.Add(label3);
		D805462D.Enabled = false;
		D805462D.Location = new Point(24, 241);
		D805462D.Name = "plAnh";
		D805462D.Size = new Size(284, 31);
		D805462D.TabIndex = 170;
		DF267494.Location = new Point(137, 3);
		DF267494.Name = "txtAnh";
		DF267494.Size = new Size(140, 23);
		DF267494.TabIndex = 155;
		label3.AutoSize = true;
		label3.Location = new Point(3, 6);
		label3.Name = "label3";
		label3.Size = new Size(137, 16);
		label3.TabIndex = 39;
		label3.Text = "Đường dẫn folder ảnh:";
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = Cursors.Hand;
		ckbSendAnh.Location = new Point(6, 218);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new Size(103, 20);
		ckbSendAnh.TabIndex = 169;
		ckbSendAnh.Text = "Bình luận ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += AA8BE038;
		EF8C1F07.AutoSize = true;
		EF8C1F07.Location = new Point(6, 25);
		EF8C1F07.Name = "label21";
		EF8C1F07.Size = new Size(91, 16);
		EF8C1F07.TabIndex = 110;
		EF8C1F07.Text = "Thơ\u0300i gian lươ\u0301t:";
		C51C5014.AutoSize = true;
		C51C5014.Cursor = Cursors.Hand;
		C51C5014.Location = new Point(9, 82);
		C51C5014.Name = "ckbInteract";
		C51C5014.Size = new Size(48, 20);
		C51C5014.TabIndex = 7;
		C51C5014.Text = "Like";
		C51C5014.UseVisualStyleBackColor = true;
		C51C5014.CheckedChanged += C51C5014_CheckedChanged;
		AF835B87.AutoSize = true;
		AF835B87.Cursor = Cursors.Hand;
		AF835B87.Location = new Point(9, 111);
		AF835B87.Name = "ckbShareWall";
		AF835B87.Size = new Size(89, 20);
		AF835B87.TabIndex = 8;
		AF835B87.Text = "Share Wall";
		AF835B87.UseVisualStyleBackColor = true;
		AF835B87.CheckedChanged += CA882083;
		DE2D4DB3.AutoSize = true;
		DE2D4DB3.Cursor = Cursors.Hand;
		DE2D4DB3.Location = new Point(9, 140);
		DE2D4DB3.Name = "ckbComment";
		DE2D4DB3.Size = new Size(81, 20);
		DE2D4DB3.TabIndex = 9;
		DE2D4DB3.Text = "Comment";
		DE2D4DB3.UseVisualStyleBackColor = true;
		DE2D4DB3.CheckedChanged += DE2D4DB3_CheckedChanged;
		C1032D1C.AutoSize = true;
		C1032D1C.Location = new Point(6, 53);
		C1032D1C.Name = "label20";
		C1032D1C.Size = new Size(110, 16);
		C1032D1C.TabIndex = 111;
		C1032D1C.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		DEAB1615.AutoSize = true;
		DEAB1615.Location = new Point(273, 25);
		DEAB1615.Name = "label18";
		DEAB1615.Size = new Size(30, 16);
		DEAB1615.TabIndex = 112;
		DEAB1615.Text = "giây";
		F72D32BD.Controls.Add(nudCountShareFrom);
		F72D32BD.Controls.Add(label11);
		F72D32BD.Controls.Add(FB9ED222);
		F72D32BD.Controls.Add(C11487A9);
		F72D32BD.Location = new Point(116, 109);
		F72D32BD.Name = "plCountShareWall";
		F72D32BD.Size = new Size(196, 25);
		F72D32BD.TabIndex = 117;
		nudCountShareFrom.Location = new Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new Point(156, 3);
		label11.Name = "label11";
		label11.Size = new Size(24, 16);
		label11.TabIndex = 35;
		label11.Text = "lần";
		FB9ED222.Location = new Point(63, 3);
		FB9ED222.Name = "label12";
		FB9ED222.Size = new Size(29, 16);
		FB9ED222.TabIndex = 37;
		FB9ED222.Text = "đê\u0301n";
		FB9ED222.TextAlign = ContentAlignment.MiddleCenter;
		C11487A9.Location = new Point(98, 1);
		C11487A9.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C11487A9.Name = "nudCountShareTo";
		C11487A9.Size = new Size(56, 23);
		C11487A9.TabIndex = 2;
		label17.AutoSize = true;
		label17.Location = new Point(273, 53);
		label17.Name = "label17";
		label17.Size = new Size(30, 16);
		label17.TabIndex = 113;
		label17.Text = "giây";
		plCountLike.Controls.Add(nudCountLikeFrom);
		plCountLike.Controls.Add(label2);
		plCountLike.Controls.Add(C61F7409);
		plCountLike.Controls.Add(nudCountLikeTo);
		plCountLike.Location = new Point(116, 80);
		plCountLike.Name = "plCountLike";
		plCountLike.Size = new Size(196, 25);
		plCountLike.TabIndex = 116;
		nudCountLikeFrom.Location = new Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		label2.AutoSize = true;
		label2.Location = new Point(156, 3);
		label2.Name = "label2";
		label2.Size = new Size(24, 16);
		label2.TabIndex = 35;
		label2.Text = "lần";
		C61F7409.Location = new Point(63, 3);
		C61F7409.Name = "label10";
		C61F7409.Size = new Size(29, 16);
		C61F7409.TabIndex = 37;
		C61F7409.Text = "đê\u0301n";
		C61F7409.TextAlign = ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		E78E3602.Location = new Point(179, 25);
		E78E3602.Name = "label16";
		E78E3602.Size = new Size(29, 16);
		E78E3602.TabIndex = 114;
		E78E3602.Text = "đê\u0301n";
		E78E3602.TextAlign = ContentAlignment.MiddleCenter;
		nudDelayTo.Location = new Point(214, 51);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 109;
		label15.Location = new Point(179, 53);
		label15.Name = "label15";
		label15.Size = new Size(29, 16);
		label15.TabIndex = 115;
		label15.Text = "đê\u0301n";
		label15.TextAlign = ContentAlignment.MiddleCenter;
		ADA119B2.Location = new Point(214, 23);
		ADA119B2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		ADA119B2.Name = "nudTimeTo";
		ADA119B2.Size = new Size(56, 23);
		ADA119B2.TabIndex = 107;
		E9A63D0E.Location = new Point(117, 23);
		E9A63D0E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E9A63D0E.Name = "nudTimeFrom";
		E9A63D0E.Size = new Size(56, 23);
		E9A63D0E.TabIndex = 106;
		nudDelayFrom.Location = new Point(117, 51);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 108;
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(18, 82);
		label49.Name = "label49";
		label49.Size = new Size(106, 16);
		label49.TabIndex = 121;
		label49.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		DEA79B92.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		DEA79B92.Location = new Point(129, 80);
		DEA79B92.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DEA79B92.Name = "nudSoLuongBanBeFrom";
		DEA79B92.Size = new Size(56, 23);
		DEA79B92.TabIndex = 119;
		DEA79B92.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label68.Location = new Point(287, 82);
		label68.Name = "label68";
		label68.Size = new Size(28, 16);
		label68.TabIndex = 122;
		label68.Text = "ba\u0323n";
		D2A62F27.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D2A62F27.Location = new Point(226, 80);
		D2A62F27.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		D2A62F27.Name = "nudSoLuongBanBeTo";
		D2A62F27.Size = new Size(56, 23);
		D2A62F27.TabIndex = 120;
		D2A62F27.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.AutoSize = true;
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label66.Location = new Point(191, 82);
		label66.Name = "label66";
		label66.Size = new Size(28, 16);
		label66.TabIndex = 123;
		label66.Text = "đê\u0301n";
		txtTenHanhDong.Location = new Point(129, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(235, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(18, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(201, 583);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += E6A59B21;
		B511AF93.Anchor = AnchorStyles.Bottom;
		B511AF93.BackColor = Color.FromArgb(53, 120, 229);
		B511AF93.Cursor = Cursors.Hand;
		B511AF93.FlatAppearance.BorderSize = 0;
		B511AF93.FlatStyle = FlatStyle.Flat;
		B511AF93.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B511AF93.ForeColor = Color.White;
		B511AF93.Location = new Point(94, 583);
		B511AF93.Name = "btnAdd";
		B511AF93.Size = new Size(92, 29);
		B511AF93.TabIndex = 11;
		B511AF93.Text = "Thêm";
		B511AF93.UseVisualStyleBackColor = false;
		B511AF93.Click += B511AF93_Click;
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
		bunifuCards1.Size = new Size(384, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(387, 628);
		base.Controls.Add(CD13F8BA);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBanBe";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C72A5117_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)AFB7D0BD).EndInit();
		CD13F8BA.ResumeLayout(performLayout: false);
		CD13F8BA.PerformLayout();
		C21C1938.ResumeLayout(performLayout: false);
		C21C1938.PerformLayout();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		plCommentText.ResumeLayout(performLayout: false);
		plCommentText.PerformLayout();
		plCountComment.ResumeLayout(performLayout: false);
		plCountComment.PerformLayout();
		((ISupportInitialize)E4B08C25).EndInit();
		((ISupportInitialize)D1B56205).EndInit();
		D805462D.ResumeLayout(performLayout: false);
		D805462D.PerformLayout();
		F72D32BD.ResumeLayout(performLayout: false);
		F72D32BD.PerformLayout();
		((ISupportInitialize)nudCountShareFrom).EndInit();
		((ISupportInitialize)C11487A9).EndInit();
		plCountLike.ResumeLayout(performLayout: false);
		plCountLike.PerformLayout();
		((ISupportInitialize)nudCountLikeFrom).EndInit();
		((ISupportInitialize)nudCountLikeTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)ADA119B2).EndInit();
		((ISupportInitialize)E9A63D0E).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)DEA79B92).EndInit();
		((ISupportInitialize)D2A62F27).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
