using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Bunifu.Framework.UI;

public class fHDSeedingByVideo : Form
{
	private JSON_Settings F730BC33;

	private string string_0;

	private string FB344083;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl D6AF9833;

	private BunifuDragControl bunifuDragControl_0;

	private Panel FC14B187;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label C5BEEF14;

	private Label label1;

	private Button E99F69A4;

	private Button A4ADDC81;

	private BunifuCards bunifuCards1;

	private Panel ACB3110D;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label A1BF1421;

	private Label label2;

	private Panel plComment;

	private RadioButton B19051B1;

	private RadioButton rbNganCachMoiDong;

	private Label E9B19188;

	private RichTextBox txtComment;

	private Label A50C39B5;

	private Label E3B088AB;

	private Panel plVideo;

	private Button button3;

	private TextBox txtVideo;

	private RichTextBox txtIdPost;

	private CheckBox ckbSendVideo;

	private CheckBox ckbComment;

	public fHDSeedingByVideo(string EF10F81B, int int_1 = 0, string EE258020 = "")
	{
		FFBAFB1E();
		bool_0 = false;
		string_0 = EF10F81B;
		string_1 = EE258020;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDSeedingByVideo").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSeedingByVideo', 'Seeding bằng video');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDSeedingByVideo");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			FB344083 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(EE258020);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			A4ADDC81.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F730BC33 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(C5BEEF14);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(label2);
		Language.smethod_0(A1BF1421);
		Language.smethod_0(A1BF1421);
		Language.smethod_0(ckbComment);
		Language.smethod_0(E3B088AB);
		Language.smethod_0(A50C39B5);
		Language.smethod_0(E9B19188);
		Language.smethod_0(rbNganCachMoiDong);
		Language.smethod_0(B19051B1);
		Language.smethod_0(ckbSendVideo);
		Language.smethod_0(button3);
		Language.smethod_0(A4ADDC81);
		Language.smethod_0(E99F69A4);
	}

	private void E83C8C88(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = F730BC33.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = F730BC33.GetValueInt("nudDelayTo", 5);
			ckbComment.Checked = F730BC33.GetValueBool("ckbComment");
			txtComment.Text = F730BC33.GetValue("txtComment");
			txtIdPost.Text = F730BC33.GetValue("txtIdPost");
			ckbSendVideo.Checked = F730BC33.GetValueBool("ckbSendVideo");
			txtVideo.Text = F730BC33.GetValue("txtVideo");
			if (F730BC33.GetValueInt("typeNganCach") == 1)
			{
				B19051B1.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		method_1();
	}

	private void AC8C5A90(object sender, EventArgs e)
	{
		Close();
	}

	private void CB9F11AB(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtIdPost.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id ba\u0300i viê\u0301t câ\u0300n buff like, comment!", 3);
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
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("txtIdPost", txtIdPost.Text.Trim());
		gClass.GetJson("ckbSendVideo", ckbSendVideo.Checked);
		gClass.GetJson("txtVideo", txtVideo.Text.Trim());
		int num = 0;
		if (B19051B1.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, FB344083, string_))
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
			if (InteractSQL.smethod_13(string_1, text, string_))
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

	private void E99F69A4_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E0B69B8B(object sender, PaintEventArgs e)
	{
		if (FC14B187.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FC14B187.ClientSize.Width - num, FC14B187.ClientSize.Height - num));
		}
	}

	private void C909413C(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			E3B088AB.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		BD24ACA4(null, null);
		F7ABAB8B(null, null);
	}

	private void BD24ACA4(object sender, EventArgs e)
	{
	}

	private void F7ABAB8B(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtIdPost.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label2.Text = string.Format(Language.GetValue("Danh sa\u0301ch ID bài viết ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		txtVideo.Text = Common.SelectFolder();
	}

	private void ckbSendVideo_CheckedChanged(object sender, EventArgs e)
	{
		plVideo.Enabled = ckbSendVideo.Checked;
	}

	private void DB14ED84(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool A38FF225)
	{
		if (A38FF225 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A38FF225);
	}

	private void FFBAFB1E()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDSeedingByVideo));
		D6AF9833 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		ACB3110D = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		FC14B187 = new Panel();
		plComment = new Panel();
		B19051B1 = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		E9B19188 = new Label();
		txtComment = new RichTextBox();
		A50C39B5 = new Label();
		E3B088AB = new Label();
		plVideo = new Panel();
		button3 = new Button();
		txtVideo = new TextBox();
		txtIdPost = new RichTextBox();
		ckbSendVideo = new CheckBox();
		ckbComment = new CheckBox();
		A1BF1421 = new Label();
		label2 = new Label();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		label6 = new Label();
		C5BEEF14 = new Label();
		label1 = new Label();
		E99F69A4 = new Button();
		A4ADDC81 = new Button();
		bunifuCards1 = new BunifuCards();
		ACB3110D.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		FC14B187.SuspendLayout();
		plComment.SuspendLayout();
		plVideo.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D6AF9833.Fixed = true;
		D6AF9833.Horizontal = true;
		D6AF9833.TargetControl = bunifuCustomLabel1;
		D6AF9833.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(684, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Seeding ba\u0300i viê\u0301t";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = ACB3110D;
		bunifuDragControl_0.Vertical = true;
		ACB3110D.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		ACB3110D.BackColor = Color.White;
		ACB3110D.Controls.Add(button1);
		ACB3110D.Controls.Add(pictureBox1);
		ACB3110D.Controls.Add(bunifuCustomLabel1);
		ACB3110D.Cursor = Cursors.SizeAll;
		ACB3110D.Location = new Point(0, 3);
		ACB3110D.Name = "pnlHeader";
		ACB3110D.Size = new Size(684, 31);
		ACB3110D.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(653, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += AC8C5A90;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		FC14B187.BackColor = Color.White;
		FC14B187.BorderStyle = BorderStyle.FixedSingle;
		FC14B187.Controls.Add(plComment);
		FC14B187.Controls.Add(plVideo);
		FC14B187.Controls.Add(txtIdPost);
		FC14B187.Controls.Add(ckbSendVideo);
		FC14B187.Controls.Add(ckbComment);
		FC14B187.Controls.Add(A1BF1421);
		FC14B187.Controls.Add(label2);
		FC14B187.Controls.Add(nudDelayTo);
		FC14B187.Controls.Add(nudDelayFrom);
		FC14B187.Controls.Add(txtTenHanhDong);
		FC14B187.Controls.Add(label7);
		FC14B187.Controls.Add(label6);
		FC14B187.Controls.Add(C5BEEF14);
		FC14B187.Controls.Add(label1);
		FC14B187.Controls.Add(E99F69A4);
		FC14B187.Controls.Add(A4ADDC81);
		FC14B187.Controls.Add(bunifuCards1);
		FC14B187.Cursor = Cursors.Arrow;
		FC14B187.Dock = DockStyle.Fill;
		FC14B187.Location = new Point(0, 0);
		FC14B187.Name = "panel1";
		FC14B187.Size = new Size(687, 437);
		FC14B187.TabIndex = 0;
		FC14B187.Click += DB14ED84;
		FC14B187.Paint += E0B69B8B;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(B19051B1);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(E9B19188);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(A50C39B5);
		plComment.Controls.Add(E3B088AB);
		plComment.Location = new Point(371, 104);
		plComment.Name = "plComment";
		plComment.Size = new Size(281, 193);
		plComment.TabIndex = 164;
		B19051B1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		B19051B1.AutoSize = true;
		B19051B1.Cursor = Cursors.Hand;
		B19051B1.Location = new Point(70, 168);
		B19051B1.Name = "rbNganCachKyTu";
		B19051B1.Size = new Size(202, 20);
		B19051B1.TabIndex = 3;
		B19051B1.Text = "Các nội dung ngăn cách bởi \"|\"";
		B19051B1.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(70, 147);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(170, 20);
		rbNganCachMoiDong.TabIndex = 3;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		E9B19188.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		E9B19188.AutoSize = true;
		E9B19188.Location = new Point(4, 147);
		E9B19188.Name = "label8";
		E9B19188.Size = new Size(64, 16);
		E9B19188.TabIndex = 2;
		E9B19188.Text = "Tùy chọn:";
		txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtComment.Location = new Point(7, 25);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(263, 99);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		A50C39B5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		A50C39B5.AutoSize = true;
		A50C39B5.Location = new Point(5, 127);
		A50C39B5.Name = "label11";
		A50C39B5.Size = new Size(133, 16);
		A50C39B5.TabIndex = 0;
		A50C39B5.Text = "Spin nội dung {a|b|c}";
		E3B088AB.AutoSize = true;
		E3B088AB.Location = new Point(3, 5);
		E3B088AB.Name = "lblStatus";
		E3B088AB.Size = new Size(118, 16);
		E3B088AB.TabIndex = 0;
		E3B088AB.Text = "Nội dung bình luận:";
		plVideo.BorderStyle = BorderStyle.FixedSingle;
		plVideo.Controls.Add(button3);
		plVideo.Controls.Add(txtVideo);
		plVideo.Enabled = false;
		plVideo.Location = new Point(371, 325);
		plVideo.Name = "plVideo";
		plVideo.Size = new Size(281, 31);
		plVideo.TabIndex = 166;
		button3.Cursor = Cursors.Hand;
		button3.Location = new Point(217, 2);
		button3.Name = "button3";
		button3.Size = new Size(59, 25);
		button3.TabIndex = 156;
		button3.Text = "Chọn";
		button3.UseVisualStyleBackColor = true;
		button3.Click += button3_Click;
		txtVideo.Location = new Point(3, 3);
		txtVideo.Name = "txtVideo";
		txtVideo.Size = new Size(208, 23);
		txtVideo.TabIndex = 155;
		txtIdPost.Location = new Point(30, 129);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new Size(297, 230);
		txtIdPost.TabIndex = 1;
		txtIdPost.Text = "";
		txtIdPost.WordWrap = false;
		txtIdPost.TextChanged += txtIdPost_TextChanged;
		ckbSendVideo.AutoSize = true;
		ckbSendVideo.Cursor = Cursors.Hand;
		ckbSendVideo.Location = new Point(353, 303);
		ckbSendVideo.Name = "ckbSendVideo";
		ckbSendVideo.Size = new Size(112, 20);
		ckbSendVideo.TabIndex = 165;
		ckbSendVideo.Text = "Bình luận video";
		ckbSendVideo.UseVisualStyleBackColor = true;
		ckbSendVideo.CheckedChanged += ckbSendVideo_CheckedChanged;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(353, 79);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(127, 20);
		ckbComment.TabIndex = 163;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += F7ABAB8B;
		A1BF1421.AutoSize = true;
		A1BF1421.Location = new Point(27, 362);
		A1BF1421.Name = "label10";
		A1BF1421.Size = new Size(96, 16);
		A1BF1421.TabIndex = 39;
		A1BF1421.Text = "(Mỗi ID 1 dòng)";
		label2.AutoSize = true;
		label2.Location = new Point(27, 108);
		label2.Name = "label2";
		label2.Size = new Size(153, 16);
		label2.TabIndex = 40;
		label2.Text = "Danh sa\u0301ch ID bài viết (0):";
		nudDelayTo.Location = new Point(231, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(134, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.AutoSize = true;
		label7.Location = new Point(196, 80);
		label7.Name = "label7";
		label7.Size = new Size(28, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new Point(292, 80);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		C5BEEF14.AutoSize = true;
		C5BEEF14.Location = new Point(27, 80);
		C5BEEF14.Name = "label5";
		C5BEEF14.Size = new Size(99, 16);
		C5BEEF14.TabIndex = 34;
		C5BEEF14.Text = "Thơ\u0300i gian delay:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		E99F69A4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		E99F69A4.BackColor = Color.Maroon;
		E99F69A4.Cursor = Cursors.Hand;
		E99F69A4.FlatAppearance.BorderSize = 0;
		E99F69A4.FlatStyle = FlatStyle.Flat;
		E99F69A4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E99F69A4.ForeColor = Color.White;
		E99F69A4.Location = new Point(343, 395);
		E99F69A4.Name = "btnCancel";
		E99F69A4.Size = new Size(92, 29);
		E99F69A4.TabIndex = 10;
		E99F69A4.Text = "Đóng";
		E99F69A4.UseVisualStyleBackColor = false;
		E99F69A4.Click += E99F69A4_Click;
		A4ADDC81.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		A4ADDC81.BackColor = Color.FromArgb(53, 120, 229);
		A4ADDC81.Cursor = Cursors.Hand;
		A4ADDC81.FlatAppearance.BorderSize = 0;
		A4ADDC81.FlatStyle = FlatStyle.Flat;
		A4ADDC81.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A4ADDC81.ForeColor = Color.White;
		A4ADDC81.Location = new Point(236, 395);
		A4ADDC81.Name = "btnAdd";
		A4ADDC81.Size = new Size(92, 29);
		A4ADDC81.TabIndex = 9;
		A4ADDC81.Text = "Thêm";
		A4ADDC81.UseVisualStyleBackColor = false;
		A4ADDC81.Click += CB9F11AB;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(ACB3110D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(684, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(687, 437);
		base.Controls.Add(FC14B187);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDSeedingByVideo";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += E83C8C88;
		ACB3110D.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		FC14B187.ResumeLayout(performLayout: false);
		FC14B187.PerformLayout();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		plVideo.ResumeLayout(performLayout: false);
		plVideo.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
