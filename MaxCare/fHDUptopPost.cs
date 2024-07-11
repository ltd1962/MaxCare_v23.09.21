using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDUptopPost : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string DAA1F784;

	private string string_1;

	private int AA25AE29;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer AAAD8681 = null;

	private BunifuDragControl E12E033A;

	private BunifuDragControl DB19EB19;

	private Panel panel1;

	private NumericUpDown DE35B429;

	private NumericUpDown C02C70AE;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button E1B1349A;

	private BunifuCards bunifuCards1;

	private Panel F1A16CA9;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox C215FC01;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudTimeFrom;

	private Label B6932519;

	private Label label3;

	private Panel plComment;

	private RichTextBox txtComment;

	private Label F02B9D12;

	private RichTextBox txtLinkUser;

	private CheckBox ckbComment;

	private Panel plInteract;

	private CheckBox ckbAngry;

	private CheckBox ckbSad;

	private CheckBox ckbWow;

	private CheckBox A08AC005;

	private CheckBox F3393A15;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	private Panel panel7;

	private RadioButton FE917390;

	private RadioButton radioButton4;

	private Label label26;

	private NumericUpDown EB1E9092;

	private NumericUpDown nudSoLuongTo;

	private Label label66;

	private Label label49;

	private CheckBox ckbDeleteComment;

	private Panel plDeleteComment;

	private Panel FF187A86;

	private RadioButton FA90D029;

	private RadioButton radioButton2;

	private Label label4;

	private Label label6;

	private Label label10;

	private NumericUpDown F816EA10;

	private NumericUpDown DBB5F038;

	public fHDUptopPost(string C719080D, int A2AEDB15 = 0, string BE0B5AB3 = "")
	{
		BB8402AF();
		bool_0 = false;
		string_0 = C719080D;
		string_1 = BE0B5AB3;
		AA25AE29 = A2AEDB15;
		string text = base.Name.Substring(1);
		string text2 = "Uptop Post";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (A2AEDB15)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			DAA1F784 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BE0B5AB3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			E1B1349A.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
		list_0 = new List<CheckBox> { ckbLike, ckbLove, F3393A15, A08AC005, ckbWow, ckbSad, ckbAngry };
	}

	private void fHDUptopPost_Load(object sender, EventArgs e)
	{
		try
		{
			txtLinkUser.Text = gclass8_0.GetValue("txtLinkUser");
			nudTimeFrom.Value = gclass8_0.GetValueInt("nudTimeFrom", 3);
			nudTimeTo.Value = gclass8_0.GetValueInt("nudTimeTo", 5);
			C02C70AE.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			DE35B429.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			EB1E9092.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 3);
			C215FC01.Checked = gclass8_0.GetValueBool("ckbInteract");
			List<string> list = gclass8_0.GetValue("typeReaction", "Like|Love").Split('|').ToList();
			for (int i = 0; i < list.Count; i++)
			{
				foreach (CheckBox item in list_0)
				{
					if (item.Name.Substring(3) == list[i])
					{
						item.Checked = true;
					}
				}
			}
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			ckbDeleteComment.Checked = gclass8_0.GetValueBool("ckbDeleteComment");
			F816EA10.Value = gclass8_0.GetValueInt("nudDelayDeleteFrom", 3);
			DBB5F038.Value = gclass8_0.GetValueInt("nudDelayDeleteTo", 5);
		}
		catch
		{
		}
		EA89C80B();
	}

	private void BA838EB8(object sender, EventArgs e)
	{
		Close();
	}

	private void E1B1349A_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtLinkUser.Lines.ToList();
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
		gClass.GetJson("txtLinkUser", txtLinkUser.Text.Trim());
		gClass.GetJson("nudTimeFrom", nudTimeFrom.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", C02C70AE.Value);
		gClass.GetJson("nudDelayTo", DE35B429.Value);
		gClass.GetJson("nudSoLuongFrom", EB1E9092.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("ckbInteract", C215FC01.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + list_0[i].Name.Substring(3) + "|";
			}
		}
		gClass.GetJson("typeReaction", text2.TrimEnd('|'));
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("ckbDeleteComment", ckbDeleteComment.Checked);
		gClass.GetJson("nudDelayDeleteFrom", F816EA10.Value);
		gClass.GetJson("nudDelayDeleteTo", DBB5F038.Value);
		string string_ = gClass.D9A09B34();
		if (AA25AE29 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, DAA1F784, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BA12B031(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, F02B9D12);
	}

	private void EA89C80B()
	{
		C215FC01_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		method_0(null, null);
		txtComment_TextChanged(null, null);
		ckbDeleteComment_CheckedChanged(null, null);
	}

	private void C215FC01_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = C215FC01.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtLinkUser_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtLinkUser, label2);
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void D5B9EFB6(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void ckbDeleteComment_CheckedChanged(object sender, EventArgs e)
	{
		plDeleteComment.Enabled = ckbDeleteComment.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && AAAD8681 != null)
		{
			AAAD8681.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void BB8402AF()
	{
		AAAD8681 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDUptopPost));
		E12E033A = new BunifuDragControl(AAAD8681);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		DB19EB19 = new BunifuDragControl(AAAD8681);
		F1A16CA9 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		EB1E9092 = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		label66 = new Label();
		DE35B429 = new NumericUpDown();
		C02C70AE = new NumericUpDown();
		label7 = new Label();
		plComment = new Panel();
		txtComment = new RichTextBox();
		F02B9D12 = new Label();
		ckbDeleteComment = new CheckBox();
		plDeleteComment = new Panel();
		FF187A86 = new Panel();
		FA90D029 = new RadioButton();
		radioButton2 = new RadioButton();
		label4 = new Label();
		label6 = new Label();
		label10 = new Label();
		F816EA10 = new NumericUpDown();
		DBB5F038 = new NumericUpDown();
		plInteract = new Panel();
		ckbAngry = new CheckBox();
		ckbSad = new CheckBox();
		ckbWow = new CheckBox();
		A08AC005 = new CheckBox();
		F3393A15 = new CheckBox();
		ckbLove = new CheckBox();
		ckbLike = new CheckBox();
		panel7 = new Panel();
		FE917390 = new RadioButton();
		radioButton4 = new RadioButton();
		label26 = new Label();
		label49 = new Label();
		txtLinkUser = new RichTextBox();
		ckbComment = new CheckBox();
		label2 = new Label();
		C215FC01 = new CheckBox();
		nudTimeTo = new NumericUpDown();
		nudTimeFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		B6932519 = new Label();
		label3 = new Label();
		label5 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		E1B1349A = new Button();
		bunifuCards1 = new BunifuCards();
		F1A16CA9.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)EB1E9092).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)DE35B429).BeginInit();
		((ISupportInitialize)C02C70AE).BeginInit();
		plComment.SuspendLayout();
		plDeleteComment.SuspendLayout();
		FF187A86.SuspendLayout();
		((ISupportInitialize)F816EA10).BeginInit();
		((ISupportInitialize)DBB5F038).BeginInit();
		plInteract.SuspendLayout();
		panel7.SuspendLayout();
		((ISupportInitialize)nudTimeTo).BeginInit();
		((ISupportInitialize)nudTimeFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		E12E033A.Fixed = true;
		E12E033A.Horizontal = true;
		E12E033A.TargetControl = bunifuCustomLabel1;
		E12E033A.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(717, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Uptop Post";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		DB19EB19.Fixed = true;
		DB19EB19.Horizontal = true;
		DB19EB19.TargetControl = F1A16CA9;
		DB19EB19.Vertical = true;
		F1A16CA9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F1A16CA9.BackColor = Color.White;
		F1A16CA9.Controls.Add(button1);
		F1A16CA9.Controls.Add(pictureBox1);
		F1A16CA9.Controls.Add(bunifuCustomLabel1);
		F1A16CA9.Cursor = Cursors.SizeAll;
		F1A16CA9.Location = new Point(0, 3);
		F1A16CA9.Name = "pnlHeader";
		F1A16CA9.Size = new Size(717, 31);
		F1A16CA9.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(686, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += BA838EB8;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += D5B9EFB6;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(EB1E9092);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(DE35B429);
		panel1.Controls.Add(C02C70AE);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(txtLinkUser);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(C215FC01);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(B6932519);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(E1B1349A);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(720, 506);
		panel1.TabIndex = 0;
		panel1.Click += panel1_Click;
		panel1.Paint += BA12B031;
		EB1E9092.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		EB1E9092.Location = new Point(496, 73);
		EB1E9092.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		EB1E9092.Name = "nudSoLuongFrom";
		EB1E9092.Size = new Size(56, 23);
		EB1E9092.TabIndex = 167;
		EB1E9092.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		nudSoLuongTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongTo.Location = new Point(593, 73);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 168;
		nudSoLuongTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label66.Location = new Point(558, 75);
		label66.Name = "label66";
		label66.Size = new Size(29, 16);
		label66.TabIndex = 171;
		label66.Text = ">";
		label66.TextAlign = ContentAlignment.MiddleCenter;
		DE35B429.Location = new Point(593, 131);
		DE35B429.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DE35B429.Name = "nudDelayTo";
		DE35B429.Size = new Size(56, 23);
		DE35B429.TabIndex = 4;
		C02C70AE.Location = new Point(496, 131);
		C02C70AE.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C02C70AE.Name = "nudDelayFrom";
		C02C70AE.Size = new Size(56, 23);
		C02C70AE.TabIndex = 3;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(558, 133);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(F02B9D12);
		plComment.Controls.Add(ckbDeleteComment);
		plComment.Controls.Add(plDeleteComment);
		plComment.Location = new Point(378, 243);
		plComment.Name = "plComment";
		plComment.Size = new Size(312, 205);
		plComment.TabIndex = 164;
		txtComment.Location = new Point(7, 25);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(299, 115);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += txtComment_TextChanged;
		F02B9D12.AutoSize = true;
		F02B9D12.Location = new Point(3, 5);
		F02B9D12.Name = "lblComment";
		F02B9D12.Size = new Size(139, 16);
		F02B9D12.TabIndex = 0;
		F02B9D12.Text = "Nội dung bình luận (0):";
		ckbDeleteComment.AutoSize = true;
		ckbDeleteComment.Cursor = Cursors.Hand;
		ckbDeleteComment.Location = new Point(7, 146);
		ckbDeleteComment.Name = "ckbDeleteComment";
		ckbDeleteComment.Size = new Size(105, 20);
		ckbDeleteComment.TabIndex = 163;
		ckbDeleteComment.Text = "Xóa comment";
		ckbDeleteComment.UseVisualStyleBackColor = true;
		ckbDeleteComment.CheckedChanged += ckbDeleteComment_CheckedChanged;
		plDeleteComment.BorderStyle = BorderStyle.FixedSingle;
		plDeleteComment.Controls.Add(FF187A86);
		plDeleteComment.Controls.Add(label4);
		plDeleteComment.Controls.Add(label6);
		plDeleteComment.Controls.Add(label10);
		plDeleteComment.Controls.Add(F816EA10);
		plDeleteComment.Controls.Add(DBB5F038);
		plDeleteComment.Location = new Point(25, 169);
		plDeleteComment.Name = "plDeleteComment";
		plDeleteComment.Size = new Size(281, 29);
		plDeleteComment.TabIndex = 180;
		FF187A86.Controls.Add(FA90D029);
		FF187A86.Controls.Add(radioButton2);
		FF187A86.Location = new Point(67, 300);
		FF187A86.Name = "panel3";
		FF187A86.Size = new Size(200, 43);
		FF187A86.TabIndex = 43;
		FA90D029.AutoSize = true;
		FA90D029.Checked = true;
		FA90D029.Cursor = Cursors.Hand;
		FA90D029.Location = new Point(3, 2);
		FA90D029.Name = "radioButton1";
		FA90D029.Size = new Size(201, 20);
		FA90D029.TabIndex = 3;
		FA90D029.TabStop = true;
		FA90D029.Text = "Comment theo thứ tự nội dung";
		FA90D029.UseVisualStyleBackColor = true;
		radioButton2.AutoSize = true;
		radioButton2.Cursor = Cursors.Hand;
		radioButton2.Location = new Point(3, 23);
		radioButton2.Name = "radioButton2";
		radioButton2.Size = new Size(200, 20);
		radioButton2.TabIndex = 3;
		radioButton2.Text = "Comment ngẫu nhiên nội dung";
		radioButton2.UseVisualStyleBackColor = true;
		label4.AutoSize = true;
		label4.Location = new Point(4, 302);
		label4.Name = "label4";
		label4.Size = new Size(64, 16);
		label4.TabIndex = 2;
		label4.Text = "Tùy chọn:";
		label6.AutoSize = true;
		label6.Location = new Point(3, 4);
		label6.Name = "label6";
		label6.Size = new Size(135, 16);
		label6.TabIndex = 34;
		label6.Text = "Chờ xóa comment (s):";
		label10.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label10.Location = new Point(197, 4);
		label10.Name = "label10";
		label10.Size = new Size(19, 16);
		label10.TabIndex = 38;
		label10.Text = ">";
		label10.TextAlign = ContentAlignment.MiddleCenter;
		F816EA10.Location = new Point(138, 2);
		F816EA10.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F816EA10.Name = "nudDelayDeleteFrom";
		F816EA10.Size = new Size(56, 23);
		F816EA10.TabIndex = 3;
		DBB5F038.Location = new Point(220, 2);
		DBB5F038.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DBB5F038.Name = "nudDelayDeleteTo";
		DBB5F038.Size = new Size(56, 23);
		DBB5F038.TabIndex = 4;
		plInteract.BorderStyle = BorderStyle.FixedSingle;
		plInteract.Controls.Add(ckbAngry);
		plInteract.Controls.Add(ckbSad);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(A08AC005);
		plInteract.Controls.Add(F3393A15);
		plInteract.Controls.Add(ckbLove);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(panel7);
		plInteract.Controls.Add(label26);
		plInteract.Location = new Point(378, 182);
		plInteract.Name = "plInteract";
		plInteract.Size = new Size(312, 33);
		plInteract.TabIndex = 180;
		ckbAngry.Cursor = Cursors.Hand;
		ckbAngry.Image = Resources.Bitmap_7;
		ckbAngry.Location = new Point(266, 1);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new Size(40, 30);
		ckbAngry.TabIndex = 179;
		ckbAngry.Tag = "Angry";
		ckbAngry.UseVisualStyleBackColor = true;
		ckbSad.Cursor = Cursors.Hand;
		ckbSad.Image = Resources.Bitmap_167;
		ckbSad.Location = new Point(222, 1);
		ckbSad.Name = "ckbSad";
		ckbSad.Size = new Size(40, 30);
		ckbSad.TabIndex = 178;
		ckbSad.Tag = "Sad";
		ckbSad.UseVisualStyleBackColor = true;
		ckbWow.Cursor = Cursors.Hand;
		ckbWow.Image = Resources.BBAD6B14;
		ckbWow.Location = new Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.Tag = "Wow";
		ckbWow.UseVisualStyleBackColor = true;
		A08AC005.Cursor = Cursors.Hand;
		A08AC005.Image = Resources.Bitmap_34;
		A08AC005.Location = new Point(134, 1);
		A08AC005.Name = "ckbHaha";
		A08AC005.Size = new Size(40, 30);
		A08AC005.TabIndex = 176;
		A08AC005.Tag = "Haha";
		A08AC005.UseVisualStyleBackColor = true;
		F3393A15.Cursor = Cursors.Hand;
		F3393A15.Image = Resources.Bitmap_14;
		F3393A15.Location = new Point(90, 1);
		F3393A15.Name = "ckbCare";
		F3393A15.Size = new Size(40, 30);
		F3393A15.TabIndex = 175;
		F3393A15.Tag = "Care";
		F3393A15.UseVisualStyleBackColor = true;
		ckbLove.Cursor = Cursors.Hand;
		ckbLove.Image = Resources.Bitmap_154;
		ckbLove.Location = new Point(46, 1);
		ckbLove.Name = "ckbLove";
		ckbLove.Size = new Size(40, 30);
		ckbLove.TabIndex = 174;
		ckbLove.Tag = "Love";
		ckbLove.UseVisualStyleBackColor = true;
		ckbLike.Cursor = Cursors.Hand;
		ckbLike.Image = Resources.B41E983E;
		ckbLike.Location = new Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.Tag = "Like";
		ckbLike.UseVisualStyleBackColor = true;
		panel7.Controls.Add(FE917390);
		panel7.Controls.Add(radioButton4);
		panel7.Location = new Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new Size(200, 43);
		panel7.TabIndex = 43;
		FE917390.AutoSize = true;
		FE917390.Checked = true;
		FE917390.Cursor = Cursors.Hand;
		FE917390.Location = new Point(3, 2);
		FE917390.Name = "radioButton3";
		FE917390.Size = new Size(201, 20);
		FE917390.TabIndex = 3;
		FE917390.TabStop = true;
		FE917390.Text = "Comment theo thứ tự nội dung";
		FE917390.UseVisualStyleBackColor = true;
		radioButton4.AutoSize = true;
		radioButton4.Cursor = Cursors.Hand;
		radioButton4.Location = new Point(3, 23);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new Size(200, 20);
		radioButton4.TabIndex = 3;
		radioButton4.Text = "Comment ngẫu nhiên nội dung";
		radioButton4.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new Point(4, 302);
		label26.Name = "label26";
		label26.Size = new Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(357, 75);
		label49.Name = "label49";
		label49.Size = new Size(106, 16);
		label49.TabIndex = 169;
		label49.Text = "Sô\u0301 bài tương tác:";
		txtLinkUser.Location = new Point(30, 96);
		txtLinkUser.Name = "txtLinkUser";
		txtLinkUser.Size = new Size(297, 352);
		txtLinkUser.TabIndex = 1;
		txtLinkUser.Text = "";
		txtLinkUser.WordWrap = false;
		txtLinkUser.TextChanged += txtLinkUser_TextChanged;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(360, 219);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(78, 20);
		ckbComment.TabIndex = 163;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += ckbComment_CheckedChanged;
		label2.AutoSize = true;
		label2.Location = new Point(27, 76);
		label2.Name = "label2";
		label2.Size = new Size(148, 16);
		label2.TabIndex = 40;
		label2.Text = "Danh sa\u0301ch Link User (0):";
		C215FC01.AutoSize = true;
		C215FC01.Cursor = Cursors.Hand;
		C215FC01.Location = new Point(360, 160);
		C215FC01.Name = "ckbInteract";
		C215FC01.Size = new Size(99, 20);
		C215FC01.TabIndex = 5;
		C215FC01.Text = "Thả cảm xúc";
		C215FC01.UseVisualStyleBackColor = true;
		C215FC01.CheckedChanged += C215FC01_CheckedChanged;
		nudTimeTo.Location = new Point(593, 102);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new Size(56, 23);
		nudTimeTo.TabIndex = 4;
		nudTimeFrom.Location = new Point(496, 102);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new Size(56, 23);
		nudTimeFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(143, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(184, 23);
		txtTenHanhDong.TabIndex = 0;
		B6932519.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B6932519.Location = new Point(558, 104);
		B6932519.Name = "label9";
		B6932519.Size = new Size(29, 16);
		B6932519.TabIndex = 38;
		B6932519.Text = ">";
		B6932519.TextAlign = ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new Point(357, 104);
		label3.Name = "label3";
		label3.Size = new Size(103, 16);
		label3.TabIndex = 34;
		label3.Text = "Xem bài viết (s):";
		label5.AutoSize = true;
		label5.Location = new Point(357, 133);
		label5.Name = "label5";
		label5.Size = new Size(133, 16);
		label5.TabIndex = 34;
		label5.Text = "Delay sau mỗi bài (s):";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(349, 464);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		E1B1349A.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		E1B1349A.BackColor = Color.FromArgb(53, 120, 229);
		E1B1349A.Cursor = Cursors.Hand;
		E1B1349A.FlatAppearance.BorderSize = 0;
		E1B1349A.FlatStyle = FlatStyle.Flat;
		E1B1349A.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E1B1349A.ForeColor = Color.White;
		E1B1349A.Location = new Point(242, 464);
		E1B1349A.Name = "btnAdd";
		E1B1349A.Size = new Size(92, 29);
		E1B1349A.TabIndex = 9;
		E1B1349A.Text = "Thêm";
		E1B1349A.UseVisualStyleBackColor = false;
		E1B1349A.Click += E1B1349A_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(F1A16CA9);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(717, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(720, 506);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDUptopPost";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDUptopPost_Load;
		F1A16CA9.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)EB1E9092).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)DE35B429).EndInit();
		((ISupportInitialize)C02C70AE).EndInit();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		plDeleteComment.ResumeLayout(performLayout: false);
		plDeleteComment.PerformLayout();
		FF187A86.ResumeLayout(performLayout: false);
		FF187A86.PerformLayout();
		((ISupportInitialize)F816EA10).EndInit();
		((ISupportInitialize)DBB5F038).EndInit();
		plInteract.ResumeLayout(performLayout: false);
		plInteract.PerformLayout();
		panel7.ResumeLayout(performLayout: false);
		panel7.PerformLayout();
		((ISupportInitialize)nudTimeTo).EndInit();
		((ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
