using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDChaySeeding : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string DA928B81;

	private string string_1;

	private int D30B5325;

	public static bool bool_0;

	private List<CheckBox> list_0 = null;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel A5138626;

	private TextBox txtTenHanhDong;

	private Label D2273C85;

	private Button CBADDEB5;

	private Button B19B6419;

	private BunifuCards bunifuCards1;

	private Panel B1954FBB;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F506DB91;

	private Label F19C0638;

	private Label label5;

	private NumericUpDown A23BA227;

	private NumericUpDown nudLimitFrom;

	private Label A3A1CA08;

	private Label label3;

	private TextBox txtApiKey;

	private Label label6;

	private NumericUpDown B5A71423;

	private Label label8;

	private Label label10;

	private CheckBox ckbUnlock956;

	private LinkLabel C89E190C;

	private NumericUpDown nudMaxJobFail;

	private Label A6B396A1;

	private Label B8BB3800;

	private CheckBox ckbRunByToken;

	private NumericUpDown nudMaxJobToday;

	private GroupBox BCA72688;

	private CheckBox ckbCheckAll;

	private CheckBox B21A13AB;

	private CheckBox ckbComment;

	private CheckBox ckbLike;

	private CheckBox DB9E14B0;

	private CheckBox CB311E05;

	private CheckBox F1A9BD10;

	private CheckBox ckbSad;

	private CheckBox B21B479C;

	private CheckBox E9048C82;

	private CheckBox ckbJoinGroup;

	private CheckBox DCBC2F2B;

	private CheckBox ckbCare;

	private CheckBox ckbAngry;

	private Label CC02451A;

	private Label label14;

	private Label F490F314;

	private Label label15;

	private NumericUpDown nudChoLayJobFrom;

	private Label label9;

	private Button button3;

	public fHDChaySeeding(string string_2, int int_0 = 0, string string_3 = "")
	{
		FE0C7103();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		D30B5325 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Kiếm tiền Golike";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			DA928B81 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			B19B6419.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void B7886F8A(object sender, EventArgs e)
	{
		list_0 = new List<CheckBox>
		{
			ckbLike, E9048C82, ckbCare, DCBC2F2B, CB311E05, ckbSad, ckbAngry, B21A13AB, F1A9BD10, ckbJoinGroup,
			B21B479C, ckbComment, DB9E14B0
		};
		txtApiKey.Text = gclass8_0.GetValue("txtApiKey");
		nudLimitFrom.Value = gclass8_0.GetValueInt("nudLimitFrom", 3);
		A23BA227.Value = gclass8_0.GetValueInt("nudLimitTo", 3);
		nudChoLayJobFrom.Value = gclass8_0.GetValueInt("nudChoLayJobFrom", 5);
		B5A71423.Value = gclass8_0.GetValueInt("nudChoLayJobTo", 5);
		F506DB91.Value = ((gclass8_0.GetValueInt("nudDelayFrom", 10) < 10) ? 10 : gclass8_0.GetValueInt("nudDelayFrom", 10));
		nudDelayTo.Value = ((gclass8_0.GetValueInt("nudDelayTo", 10) < 10) ? 10 : gclass8_0.GetValueInt("nudDelayTo", 10));
		nudMaxJobFail.Value = gclass8_0.GetValueInt("nudMaxJobFail", 5);
		nudMaxJobToday.Value = gclass8_0.GetValueInt("nudMaxJobToday");
		List<string> list = gclass8_0.GetValue("lstType").Split(',').ToList();
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list.Contains(list_0[i].Text))
			{
				list_0[i].Checked = true;
			}
		}
		ckbRunByToken.Checked = gclass8_0.GetValueBool("ckbRunByToken", bool_0: true);
		ckbUnlock956.Checked = gclass8_0.GetValueBool("ckbUnlock956");
		ckbUnlock956_CheckedChanged(null, null);
		ckbRunByToken_CheckedChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B19B6419_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		gclass8_0.GetJson("txtApiKey", txtApiKey.Text);
		gclass8_0.GetJson("nudLimitFrom", nudLimitFrom.Value);
		gclass8_0.GetJson("nudLimitTo", A23BA227.Value);
		gclass8_0.GetJson("nudChoLayJobFrom", nudChoLayJobFrom.Value);
		gclass8_0.GetJson("nudChoLayJobTo", B5A71423.Value);
		gclass8_0.GetJson("nudDelayFrom", F506DB91.Value);
		gclass8_0.GetJson("nudDelayTo", nudDelayTo.Value);
		gclass8_0.GetJson("nudMaxJobFail", nudMaxJobFail.Value);
		gclass8_0.GetJson("nudMaxJobToday", nudMaxJobToday.Value);
		gclass8_0.GetJson("ckbUnlock956", ckbUnlock956.Checked);
		gclass8_0.GetJson("ckbRunByToken", ckbRunByToken.Checked);
		string text2 = "";
		foreach (CheckBox item in list_0)
		{
			text2 += (item.Checked ? (item.Text + ",") : "");
		}
		gclass8_0.GetJson("lstType", text2.TrimEnd(','));
		string string_ = gclass8_0.D9A09B34();
		if (D30B5325 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, DA928B81, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_1, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void CBADDEB5_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A5138626_Paint(object sender, PaintEventArgs e)
	{
		if (A5138626.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A5138626.ClientSize.Width - num, A5138626.ClientSize.Height - num));
		}
	}

	private void D2ACA92B(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fCauHinhCheckPoint());
	}

	private void AD3E0D8F(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.CA2A5A03("https://auto.golike.net/");
	}

	private void ckbUnlock956_CheckedChanged(object sender, EventArgs e)
	{
		C89E190C.Enabled = ckbUnlock956.Checked;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			nudMaxJobToday.Visible = !nudMaxJobToday.Visible;
		}
	}

	private void ckbCheckAll_CheckedChanged(object sender, EventArgs e)
	{
		foreach (CheckBox item in list_0)
		{
			item.Checked = ckbCheckAll.Checked;
		}
	}

	private void ckbRunByToken_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void CABC9FBF(object sender, EventArgs e)
	{
		string text = txtApiKey.Text.Trim();
		string object_ = GClass17.smethod_0(text);
		MessageBoxHelper.Show(object_);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void FE0C7103()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDChaySeeding));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		B1954FBB = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		A5138626 = new Panel();
		button3 = new Button();
		BCA72688 = new GroupBox();
		ckbCheckAll = new CheckBox();
		B21A13AB = new CheckBox();
		ckbComment = new CheckBox();
		ckbLike = new CheckBox();
		DB9E14B0 = new CheckBox();
		CB311E05 = new CheckBox();
		F1A9BD10 = new CheckBox();
		ckbSad = new CheckBox();
		B21B479C = new CheckBox();
		E9048C82 = new CheckBox();
		ckbJoinGroup = new CheckBox();
		DCBC2F2B = new CheckBox();
		ckbCare = new CheckBox();
		ckbAngry = new CheckBox();
		ckbRunByToken = new CheckBox();
		C89E190C = new LinkLabel();
		ckbUnlock956 = new CheckBox();
		A23BA227 = new NumericUpDown();
		nudLimitFrom = new NumericUpDown();
		A3A1CA08 = new Label();
		label3 = new Label();
		B5A71423 = new NumericUpDown();
		nudDelayTo = new NumericUpDown();
		nudChoLayJobFrom = new NumericUpDown();
		label9 = new Label();
		nudMaxJobToday = new NumericUpDown();
		nudMaxJobFail = new NumericUpDown();
		F506DB91 = new NumericUpDown();
		F19C0638 = new Label();
		CC02451A = new Label();
		label15 = new Label();
		A6B396A1 = new Label();
		label14 = new Label();
		label10 = new Label();
		label8 = new Label();
		F490F314 = new Label();
		B8BB3800 = new Label();
		label5 = new Label();
		txtApiKey = new TextBox();
		label6 = new Label();
		txtTenHanhDong = new TextBox();
		D2273C85 = new Label();
		CBADDEB5 = new Button();
		B19B6419 = new Button();
		bunifuCards1 = new BunifuCards();
		B1954FBB.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		A5138626.SuspendLayout();
		BCA72688.SuspendLayout();
		((ISupportInitialize)A23BA227).BeginInit();
		((ISupportInitialize)nudLimitFrom).BeginInit();
		((ISupportInitialize)B5A71423).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudChoLayJobFrom).BeginInit();
		((ISupportInitialize)nudMaxJobToday).BeginInit();
		((ISupportInitialize)nudMaxJobFail).BeginInit();
		((ISupportInitialize)F506DB91).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(627, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kiếm tiền Golike";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = B1954FBB;
		bunifuDragControl_1.Vertical = true;
		B1954FBB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B1954FBB.BackColor = Color.White;
		B1954FBB.Controls.Add(button1);
		B1954FBB.Controls.Add(pictureBox1);
		B1954FBB.Controls.Add(bunifuCustomLabel1);
		B1954FBB.Cursor = Cursors.SizeAll;
		B1954FBB.Location = new Point(0, 3);
		B1954FBB.Name = "pnlHeader";
		B1954FBB.Size = new Size(627, 31);
		B1954FBB.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(596, 1);
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
		pictureBox1.Click += pictureBox1_Click;
		A5138626.BackColor = Color.White;
		A5138626.BorderStyle = BorderStyle.FixedSingle;
		A5138626.Controls.Add(button3);
		A5138626.Controls.Add(BCA72688);
		A5138626.Controls.Add(ckbRunByToken);
		A5138626.Controls.Add(C89E190C);
		A5138626.Controls.Add(ckbUnlock956);
		A5138626.Controls.Add(A23BA227);
		A5138626.Controls.Add(nudLimitFrom);
		A5138626.Controls.Add(A3A1CA08);
		A5138626.Controls.Add(label3);
		A5138626.Controls.Add(B5A71423);
		A5138626.Controls.Add(nudDelayTo);
		A5138626.Controls.Add(nudChoLayJobFrom);
		A5138626.Controls.Add(label9);
		A5138626.Controls.Add(nudMaxJobToday);
		A5138626.Controls.Add(nudMaxJobFail);
		A5138626.Controls.Add(F506DB91);
		A5138626.Controls.Add(F19C0638);
		A5138626.Controls.Add(CC02451A);
		A5138626.Controls.Add(label15);
		A5138626.Controls.Add(A6B396A1);
		A5138626.Controls.Add(label14);
		A5138626.Controls.Add(label10);
		A5138626.Controls.Add(label8);
		A5138626.Controls.Add(F490F314);
		A5138626.Controls.Add(B8BB3800);
		A5138626.Controls.Add(label5);
		A5138626.Controls.Add(txtApiKey);
		A5138626.Controls.Add(label6);
		A5138626.Controls.Add(txtTenHanhDong);
		A5138626.Controls.Add(D2273C85);
		A5138626.Controls.Add(CBADDEB5);
		A5138626.Controls.Add(B19B6419);
		A5138626.Controls.Add(bunifuCards1);
		A5138626.Cursor = Cursors.Arrow;
		A5138626.Dock = DockStyle.Fill;
		A5138626.Location = new Point(0, 0);
		A5138626.Name = "panel1";
		A5138626.Size = new Size(630, 355);
		A5138626.TabIndex = 0;
		A5138626.Paint += A5138626_Paint;
		button3.Cursor = Cursors.Hand;
		button3.Location = new Point(302, 77);
		button3.Name = "button3";
		button3.Size = new Size(51, 25);
		button3.TabIndex = 92;
		button3.Text = "Check";
		button3.UseVisualStyleBackColor = true;
		button3.Click += CABC9FBF;
		BCA72688.Controls.Add(ckbCheckAll);
		BCA72688.Controls.Add(B21A13AB);
		BCA72688.Controls.Add(ckbComment);
		BCA72688.Controls.Add(ckbLike);
		BCA72688.Controls.Add(DB9E14B0);
		BCA72688.Controls.Add(CB311E05);
		BCA72688.Controls.Add(F1A9BD10);
		BCA72688.Controls.Add(ckbSad);
		BCA72688.Controls.Add(B21B479C);
		BCA72688.Controls.Add(E9048C82);
		BCA72688.Controls.Add(ckbJoinGroup);
		BCA72688.Controls.Add(DCBC2F2B);
		BCA72688.Controls.Add(ckbCare);
		BCA72688.Controls.Add(ckbAngry);
		BCA72688.Location = new Point(389, 78);
		BCA72688.Name = "groupBox2";
		BCA72688.Size = new Size(210, 202);
		BCA72688.TabIndex = 48;
		BCA72688.TabStop = false;
		BCA72688.Text = " ";
		ckbCheckAll.AutoSize = true;
		ckbCheckAll.Cursor = Cursors.Hand;
		ckbCheckAll.Location = new Point(16, -1);
		ckbCheckAll.Name = "ckbCheckAll";
		ckbCheckAll.Size = new Size(78, 20);
		ckbCheckAll.TabIndex = 1;
		ckbCheckAll.Text = "Chọn Job";
		ckbCheckAll.UseVisualStyleBackColor = true;
		ckbCheckAll.CheckedChanged += ckbCheckAll_CheckedChanged;
		B21A13AB.AutoSize = true;
		B21A13AB.Cursor = Cursors.Hand;
		B21A13AB.Location = new Point(98, 23);
		B21A13AB.Name = "ckbFollow";
		B21A13AB.Size = new Size(60, 20);
		B21A13AB.TabIndex = 0;
		B21A13AB.Text = "follow";
		B21A13AB.UseVisualStyleBackColor = true;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(98, 125);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(79, 20);
		ckbComment.TabIndex = 0;
		ckbComment.Text = "comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbLike.AutoSize = true;
		ckbLike.Cursor = Cursors.Hand;
		ckbLike.Location = new Point(16, 23);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new Size(45, 20);
		ckbLike.TabIndex = 0;
		ckbLike.Text = "like";
		ckbLike.UseVisualStyleBackColor = true;
		DB9E14B0.AutoSize = true;
		DB9E14B0.Cursor = Cursors.Hand;
		DB9E14B0.Location = new Point(98, 151);
		DB9E14B0.Name = "ckbShare";
		DB9E14B0.Size = new Size(58, 20);
		DB9E14B0.TabIndex = 0;
		DB9E14B0.Text = "share";
		DB9E14B0.UseVisualStyleBackColor = true;
		CB311E05.AutoSize = true;
		CB311E05.Cursor = Cursors.Hand;
		CB311E05.Location = new Point(16, 125);
		CB311E05.Name = "ckbWow";
		CB311E05.Size = new Size(53, 20);
		CB311E05.TabIndex = 0;
		CB311E05.Text = "wow";
		CB311E05.UseVisualStyleBackColor = true;
		F1A9BD10.AutoSize = true;
		F1A9BD10.Cursor = Cursors.Hand;
		F1A9BD10.Location = new Point(98, 48);
		F1A9BD10.Name = "ckbLikePage";
		F1A9BD10.Size = new Size(80, 20);
		F1A9BD10.TabIndex = 0;
		F1A9BD10.Text = "like_page";
		F1A9BD10.UseVisualStyleBackColor = true;
		ckbSad.AutoSize = true;
		ckbSad.Cursor = Cursors.Hand;
		ckbSad.Location = new Point(16, 151);
		ckbSad.Name = "ckbSad";
		ckbSad.Size = new Size(46, 20);
		ckbSad.TabIndex = 0;
		ckbSad.Text = "sad";
		ckbSad.UseVisualStyleBackColor = true;
		B21B479C.AutoSize = true;
		B21B479C.Cursor = Cursors.Hand;
		B21B479C.Location = new Point(98, 100);
		B21B479C.Name = "ckbLikeComment";
		B21B479C.Size = new Size(105, 20);
		B21B479C.TabIndex = 0;
		B21B479C.Text = "like_comment";
		B21B479C.UseVisualStyleBackColor = true;
		E9048C82.AutoSize = true;
		E9048C82.Cursor = Cursors.Hand;
		E9048C82.Location = new Point(16, 48);
		E9048C82.Name = "ckbLove";
		E9048C82.Size = new Size(49, 20);
		E9048C82.TabIndex = 0;
		E9048C82.Text = "love";
		E9048C82.UseVisualStyleBackColor = true;
		ckbJoinGroup.AutoSize = true;
		ckbJoinGroup.Cursor = Cursors.Hand;
		ckbJoinGroup.Location = new Point(98, 74);
		ckbJoinGroup.Name = "ckbJoinGroup";
		ckbJoinGroup.Size = new Size(87, 20);
		ckbJoinGroup.TabIndex = 0;
		ckbJoinGroup.Text = "join_group";
		ckbJoinGroup.UseVisualStyleBackColor = true;
		DCBC2F2B.AutoSize = true;
		DCBC2F2B.Cursor = Cursors.Hand;
		DCBC2F2B.Location = new Point(16, 100);
		DCBC2F2B.Name = "ckbHaha";
		DCBC2F2B.Size = new Size(54, 20);
		DCBC2F2B.TabIndex = 0;
		DCBC2F2B.Text = "haha";
		DCBC2F2B.UseVisualStyleBackColor = true;
		ckbCare.AutoSize = true;
		ckbCare.Cursor = Cursors.Hand;
		ckbCare.Location = new Point(16, 74);
		ckbCare.Name = "ckbCare";
		ckbCare.Size = new Size(51, 20);
		ckbCare.TabIndex = 0;
		ckbCare.Text = "care";
		ckbCare.UseVisualStyleBackColor = true;
		ckbAngry.AutoSize = true;
		ckbAngry.Cursor = Cursors.Hand;
		ckbAngry.Location = new Point(16, 177);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new Size(58, 20);
		ckbAngry.TabIndex = 0;
		ckbAngry.Text = "angry";
		ckbAngry.UseVisualStyleBackColor = true;
		ckbRunByToken.AutoSize = true;
		ckbRunByToken.Cursor = Cursors.Hand;
		ckbRunByToken.Location = new Point(31, 250);
		ckbRunByToken.Name = "ckbRunByToken";
		ckbRunByToken.Size = new Size(121, 20);
		ckbRunByToken.TabIndex = 47;
		ckbRunByToken.Text = "Chạy bằng token";
		ckbRunByToken.UseVisualStyleBackColor = true;
		ckbRunByToken.CheckedChanged += ckbRunByToken_CheckedChanged;
		C89E190C.AutoSize = true;
		C89E190C.Cursor = Cursors.Hand;
		C89E190C.Location = new Point(260, 277);
		C89E190C.Name = "lblUnlock956";
		C89E190C.Size = new Size(57, 16);
		C89E190C.TabIndex = 46;
		C89E190C.TabStop = true;
		C89E190C.Text = "Cấu hình";
		C89E190C.LinkClicked += D2ACA92B;
		ckbUnlock956.AutoSize = true;
		ckbUnlock956.Cursor = Cursors.Hand;
		ckbUnlock956.Location = new Point(31, 276);
		ckbUnlock956.Name = "ckbUnlock956";
		ckbUnlock956.Size = new Size(224, 20);
		ckbUnlock956.TabIndex = 45;
		ckbUnlock956.Text = "Tự động Unlock 956 khi checkpoint";
		ckbUnlock956.UseVisualStyleBackColor = true;
		ckbUnlock956.CheckedChanged += ckbUnlock956_CheckedChanged;
		A23BA227.Location = new Point(263, 107);
		A23BA227.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A23BA227.Name = "nudLimitTo";
		A23BA227.Size = new Size(56, 23);
		A23BA227.TabIndex = 40;
		nudLimitFrom.Location = new Point(166, 107);
		nudLimitFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLimitFrom.Name = "nudLimitFrom";
		nudLimitFrom.Size = new Size(56, 23);
		nudLimitFrom.TabIndex = 39;
		A3A1CA08.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A3A1CA08.Location = new Point(228, 109);
		A3A1CA08.Name = "label4";
		A3A1CA08.Size = new Size(29, 16);
		A3A1CA08.TabIndex = 43;
		A3A1CA08.Text = ">";
		A3A1CA08.TextAlign = ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new Point(27, 109);
		label3.Name = "label3";
		label3.Size = new Size(133, 16);
		label3.TabIndex = 41;
		label3.Text = "Số lượng job success:";
		B5A71423.Location = new Point(263, 136);
		B5A71423.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B5A71423.Name = "nudChoLayJobTo";
		B5A71423.Size = new Size(56, 23);
		B5A71423.TabIndex = 40;
		nudDelayTo.Location = new Point(263, 165);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 40;
		nudDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		nudChoLayJobFrom.Location = new Point(166, 136);
		nudChoLayJobFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudChoLayJobFrom.Name = "nudChoLayJobFrom";
		nudChoLayJobFrom.Size = new Size(56, 23);
		nudChoLayJobFrom.TabIndex = 39;
		label9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label9.Location = new Point(228, 138);
		label9.Name = "label9";
		label9.Size = new Size(29, 16);
		label9.TabIndex = 43;
		label9.Text = ">";
		label9.TextAlign = ContentAlignment.MiddleCenter;
		nudMaxJobToday.Location = new Point(263, 223);
		nudMaxJobToday.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMaxJobToday.Name = "nudMaxJobToday";
		nudMaxJobToday.Size = new Size(56, 23);
		nudMaxJobToday.TabIndex = 39;
		nudMaxJobFail.Location = new Point(263, 194);
		nudMaxJobFail.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMaxJobFail.Name = "nudMaxJobFail";
		nudMaxJobFail.Size = new Size(56, 23);
		nudMaxJobFail.TabIndex = 39;
		F506DB91.Location = new Point(166, 165);
		F506DB91.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F506DB91.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		F506DB91.Name = "nudDelayFrom";
		F506DB91.Size = new Size(56, 23);
		F506DB91.TabIndex = 39;
		F506DB91.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		F19C0638.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F19C0638.Location = new Point(228, 167);
		F19C0638.Name = "label7";
		F19C0638.Size = new Size(29, 16);
		F19C0638.TabIndex = 43;
		F19C0638.Text = ">";
		F19C0638.TextAlign = ContentAlignment.MiddleCenter;
		CC02451A.AutoSize = true;
		CC02451A.Location = new Point(322, 225);
		CC02451A.Name = "label13";
		CC02451A.Size = new Size(31, 16);
		CC02451A.TabIndex = 41;
		CC02451A.Text = "jobs";
		label15.AutoSize = true;
		label15.Location = new Point(322, 109);
		label15.Name = "label15";
		label15.Size = new Size(31, 16);
		label15.TabIndex = 41;
		label15.Text = "jobs";
		A6B396A1.AutoSize = true;
		A6B396A1.Location = new Point(322, 196);
		A6B396A1.Name = "label12";
		A6B396A1.Size = new Size(31, 16);
		A6B396A1.TabIndex = 41;
		A6B396A1.Text = "jobs";
		label14.AutoSize = true;
		label14.Location = new Point(322, 167);
		label14.Name = "label14";
		label14.Size = new Size(30, 16);
		label14.TabIndex = 41;
		label14.Text = "giây";
		label10.AutoSize = true;
		label10.Location = new Point(322, 138);
		label10.Name = "label10";
		label10.Size = new Size(32, 16);
		label10.TabIndex = 41;
		label10.Text = "phút";
		label8.AutoSize = true;
		label8.Location = new Point(27, 138);
		label8.Name = "label8";
		label8.Size = new Size(125, 16);
		label8.TabIndex = 41;
		label8.Text = "Timeout chờ lấy job:";
		F490F314.AutoSize = true;
		F490F314.Location = new Point(27, 225);
		F490F314.Name = "label2";
		F490F314.Size = new Size(174, 16);
		F490F314.TabIndex = 41;
		F490F314.Text = "Số job tối đa/tài khoản/ngày:";
		B8BB3800.AutoSize = true;
		B8BB3800.Location = new Point(27, 196);
		B8BB3800.Name = "label11";
		B8BB3800.Size = new Size(132, 16);
		B8BB3800.TabIndex = 41;
		B8BB3800.Text = "Dừng khi fail liên tiếp:";
		label5.AutoSize = true;
		label5.Location = new Point(27, 167);
		label5.Name = "label5";
		label5.Size = new Size(99, 16);
		label5.TabIndex = 41;
		label5.Text = "Nghỉ giữa 2 job:";
		txtApiKey.Location = new Point(166, 78);
		txtApiKey.Name = "txtApiKey";
		txtApiKey.Size = new Size(130, 23);
		txtApiKey.TabIndex = 0;
		label6.AutoSize = true;
		label6.Location = new Point(27, 81);
		label6.Name = "label6";
		label6.Size = new Size(54, 16);
		label6.TabIndex = 31;
		label6.Text = "Api Key:";
		txtTenHanhDong.Location = new Point(166, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(186, 23);
		txtTenHanhDong.TabIndex = 0;
		D2273C85.AutoSize = true;
		D2273C85.Location = new Point(27, 52);
		D2273C85.Name = "label1";
		D2273C85.Size = new Size(98, 16);
		D2273C85.TabIndex = 31;
		D2273C85.Text = "Tên ha\u0300nh đô\u0323ng:";
		CBADDEB5.Anchor = AnchorStyles.Bottom;
		CBADDEB5.BackColor = Color.Maroon;
		CBADDEB5.Cursor = Cursors.Hand;
		CBADDEB5.FlatAppearance.BorderSize = 0;
		CBADDEB5.FlatStyle = FlatStyle.Flat;
		CBADDEB5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CBADDEB5.ForeColor = Color.White;
		CBADDEB5.Location = new Point(323, 311);
		CBADDEB5.Name = "btnCancel";
		CBADDEB5.Size = new Size(92, 29);
		CBADDEB5.TabIndex = 10;
		CBADDEB5.Text = "Đóng";
		CBADDEB5.UseVisualStyleBackColor = false;
		CBADDEB5.Click += CBADDEB5_Click;
		B19B6419.Anchor = AnchorStyles.Bottom;
		B19B6419.BackColor = Color.FromArgb(53, 120, 229);
		B19B6419.Cursor = Cursors.Hand;
		B19B6419.FlatAppearance.BorderSize = 0;
		B19B6419.FlatStyle = FlatStyle.Flat;
		B19B6419.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B19B6419.ForeColor = Color.White;
		B19B6419.Location = new Point(216, 311);
		B19B6419.Name = "btnAdd";
		B19B6419.Size = new Size(92, 29);
		B19B6419.TabIndex = 9;
		B19B6419.Text = "Thêm";
		B19B6419.UseVisualStyleBackColor = false;
		B19B6419.Click += B19B6419_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(B1954FBB);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(627, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(630, 355);
		base.Controls.Add(A5138626);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDChaySeeding";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += B7886F8A;
		B1954FBB.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		A5138626.ResumeLayout(performLayout: false);
		A5138626.PerformLayout();
		BCA72688.ResumeLayout(performLayout: false);
		BCA72688.PerformLayout();
		((ISupportInitialize)A23BA227).EndInit();
		((ISupportInitialize)nudLimitFrom).EndInit();
		((ISupportInitialize)B5A71423).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudChoLayJobFrom).EndInit();
		((ISupportInitialize)nudMaxJobToday).EndInit();
		((ISupportInitialize)nudMaxJobFail).EndInit();
		((ISupportInitialize)F506DB91).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
