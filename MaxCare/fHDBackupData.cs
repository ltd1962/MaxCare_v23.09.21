using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBackupData : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string BD335021;

	private string F483DF37;

	private int F804191E;

	public static bool F4870BA0;

	private IContainer B7082891 = null;

	private BunifuDragControl CDBDA3AD;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards FA27ACA4;

	private Panel pnlHeader;

	private Button C9B4E781;

	private PictureBox EC029DB6;

	private BunifuCustomLabel DE0DF983;

	private Panel plAnh;

	private CheckBox ckbAnhBanBe;

	private CheckBox D603D9A5;

	private CheckBox F104A203;

	private NumericUpDown nudSoLuongAnh;

	private Label label10;

	private Label label7;

	private Label label3;

	private CheckBox ckbBinhLuan;

	private GroupBox groupBox1;

	private CheckBox ckbCreateHTML;

	private Panel plComment;

	private NumericUpDown nudSoThang;

	private Label BB3AB506;

	private Label AFA5BD98;

	private Label label5;

	private CheckBox A0146035;

	private Button button2;

	public fHDBackupData(string string_1, int B094B59C = 0, string string_2 = "")
	{
		CB087618();
		F4870BA0 = false;
		string_0 = string_1;
		F483DF37 = string_2;
		F804191E = B094B59C;
		if (InteractSQL.B484648C("", "HDBackupData").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBackupData', '{  \"ckbNgaySinh\": \"True\",  \"ckbAnhBanBe\": \"True\",  \"nudSoLuongAnh\": \"20\",  \"ckbNhanTin\": \"True\",  \"ckbBinhLuan\": \"True\",  \"ckbCreateHTML\": \"True\"}', 'Backup dữ liệu');");
		}
		string text = "";
		switch (B094B59C)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBackupData");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			BD335021 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void A0BFEA33()
	{
		Language.smethod_0(DE0DF983);
		Language.smethod_0(label1);
		Language.smethod_0(groupBox1);
		Language.smethod_0(D603D9A5);
		Language.smethod_0(ckbAnhBanBe);
		Language.smethod_0(label7);
		Language.smethod_0(label10);
		Language.smethod_0(A0146035);
		Language.smethod_0(button2);
		Language.smethod_0(F104A203);
		Language.smethod_0(ckbBinhLuan);
		Language.smethod_0(AFA5BD98);
		Language.smethod_0(BB3AB506);
		Language.smethod_0(ckbCreateHTML);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void B118DF83(object sender, EventArgs e)
	{
		try
		{
			D603D9A5.Checked = gclass8_0.GetValueBool("ckbNgaySinh", bool_0: true);
			ckbAnhBanBe.Checked = gclass8_0.GetValueBool("ckbAnhBanBe", bool_0: true);
			A0146035.Checked = gclass8_0.GetValueBool("ckbBackupImageNangCao");
			nudSoLuongAnh.Value = gclass8_0.GetValueInt("nudSoLuongAnh", 20);
			nudSoThang.Value = gclass8_0.GetValueInt("nudSoThang", 5);
			F104A203.Checked = gclass8_0.GetValueBool("ckbNhanTin", bool_0: true);
			ckbBinhLuan.Checked = gclass8_0.GetValueBool("ckbBinhLuan", bool_0: true);
			ckbCreateHTML.Checked = gclass8_0.GetValueBool("ckbCreateHTML", bool_0: true);
		}
		catch
		{
		}
		method_0();
	}

	private void C9B4E781_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (!D603D9A5.Checked && !ckbAnhBanBe.Checked && !F104A203.Checked && !ckbBinhLuan.Checked)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng chọn cấu hình backup!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("ckbNgaySinh", D603D9A5.Checked);
		gClass.GetJson("ckbAnhBanBe", ckbAnhBanBe.Checked);
		gClass.GetJson("ckbBackupImageNangCao", A0146035.Checked);
		gClass.GetJson("nudSoLuongAnh", nudSoLuongAnh.Value);
		gClass.GetJson("ckbNhanTin", F104A203.Checked);
		gClass.GetJson("ckbBinhLuan", ckbBinhLuan.Checked);
		gClass.GetJson("nudSoThang", nudSoThang.Value);
		gClass.GetJson("ckbCreateHTML", ckbCreateHTML.Checked);
		string text2 = gClass.D9A09B34();
		if (F804191E == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, BD335021, text2))
				{
					F4870BA0 = true;
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
			if (InteractSQL.smethod_13(F483DF37, text, text2))
			{
				F4870BA0 = true;
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

	private void method_0()
	{
		A6A5A22F(null, null);
		ckbAnhBanBe_CheckedChanged(null, null);
		ckbBinhLuan_CheckedChanged(null, null);
	}

	private void A6A5A22F(object sender, EventArgs e)
	{
	}

	private void ckbAnhBanBe_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnhBanBe.Checked;
	}

	private void ckbBinhLuan_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbBinhLuan.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Nếu tích tùy chọn này thì sẽ backup được nhiều ảnh bạn bè hơn.\r\nĐồng nghĩa với việc tốc độ backup sẽ chậm hơn!");
	}

	protected override void Dispose(bool FF297EB8)
	{
		if (FF297EB8 && B7082891 != null)
		{
			B7082891.Dispose();
		}
		base.Dispose(FF297EB8);
	}

	private void CB087618()
	{
		B7082891 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBackupData));
		CDBDA3AD = new BunifuDragControl(B7082891);
		DE0DF983 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(B7082891);
		pnlHeader = new Panel();
		C9B4E781 = new Button();
		EC029DB6 = new PictureBox();
		panel1 = new Panel();
		groupBox1 = new GroupBox();
		D603D9A5 = new CheckBox();
		F104A203 = new CheckBox();
		plComment = new Panel();
		nudSoThang = new NumericUpDown();
		BB3AB506 = new Label();
		AFA5BD98 = new Label();
		label5 = new Label();
		plAnh = new Panel();
		button2 = new Button();
		A0146035 = new CheckBox();
		nudSoLuongAnh = new NumericUpDown();
		label10 = new Label();
		label7 = new Label();
		label3 = new Label();
		ckbBinhLuan = new CheckBox();
		ckbAnhBanBe = new CheckBox();
		ckbCreateHTML = new CheckBox();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		FA27ACA4 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)EC029DB6).BeginInit();
		panel1.SuspendLayout();
		groupBox1.SuspendLayout();
		plComment.SuspendLayout();
		((ISupportInitialize)nudSoThang).BeginInit();
		plAnh.SuspendLayout();
		((ISupportInitialize)nudSoLuongAnh).BeginInit();
		FA27ACA4.SuspendLayout();
		SuspendLayout();
		CDBDA3AD.Fixed = true;
		CDBDA3AD.Horizontal = true;
		CDBDA3AD.TargetControl = DE0DF983;
		CDBDA3AD.Vertical = true;
		DE0DF983.BackColor = Color.Transparent;
		DE0DF983.Cursor = Cursors.SizeAll;
		DE0DF983.Dock = DockStyle.Fill;
		DE0DF983.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DE0DF983.ForeColor = Color.Black;
		DE0DF983.Location = new Point(0, 0);
		DE0DF983.Name = "bunifuCustomLabel1";
		DE0DF983.Size = new Size(359, 31);
		DE0DF983.TabIndex = 12;
		DE0DF983.Text = "Cấu hình Backup dữ liệu";
		DE0DF983.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(C9B4E781);
		pnlHeader.Controls.Add(EC029DB6);
		pnlHeader.Controls.Add(DE0DF983);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		C9B4E781.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C9B4E781.Cursor = Cursors.Hand;
		C9B4E781.FlatAppearance.BorderSize = 0;
		C9B4E781.FlatStyle = FlatStyle.Flat;
		C9B4E781.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C9B4E781.ForeColor = Color.White;
		C9B4E781.Image = (Image)componentResourceManager.GetObject("button1.Image");
		C9B4E781.Location = new Point(328, 1);
		C9B4E781.Name = "button1";
		C9B4E781.Size = new Size(30, 30);
		C9B4E781.TabIndex = 0;
		C9B4E781.TextImageRelation = TextImageRelation.ImageBeforeText;
		C9B4E781.UseVisualStyleBackColor = true;
		C9B4E781.Click += C9B4E781_Click;
		EC029DB6.Cursor = Cursors.Default;
		EC029DB6.Image = Resources.Bitmap_4;
		EC029DB6.Location = new Point(3, 2);
		EC029DB6.Name = "pictureBox1";
		EC029DB6.Size = new Size(34, 27);
		EC029DB6.SizeMode = PictureBoxSizeMode.Zoom;
		EC029DB6.TabIndex = 76;
		EC029DB6.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(ckbCreateHTML);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(FA27ACA4);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 373);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		groupBox1.Controls.Add(D603D9A5);
		groupBox1.Controls.Add(F104A203);
		groupBox1.Controls.Add(plComment);
		groupBox1.Controls.Add(plAnh);
		groupBox1.Controls.Add(ckbBinhLuan);
		groupBox1.Controls.Add(ckbAnhBanBe);
		groupBox1.Location = new Point(30, 82);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(295, 205);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		groupBox1.Text = "Cấu hình backup";
		D603D9A5.AutoSize = true;
		D603D9A5.Cursor = Cursors.Hand;
		D603D9A5.Location = new Point(12, 20);
		D603D9A5.Name = "ckbNgaySinh";
		D603D9A5.Size = new Size(81, 20);
		D603D9A5.TabIndex = 0;
		D603D9A5.Text = "Ngày sinh";
		D603D9A5.UseVisualStyleBackColor = true;
		F104A203.AutoSize = true;
		F104A203.Cursor = Cursors.Hand;
		F104A203.Location = new Point(12, 122);
		F104A203.Name = "ckbNhanTin";
		F104A203.Size = new Size(184, 20);
		F104A203.TabIndex = 2;
		F104A203.Text = "Danh sách nhắn tin gần đây";
		F104A203.UseVisualStyleBackColor = true;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(nudSoThang);
		plComment.Controls.Add(BB3AB506);
		plComment.Controls.Add(AFA5BD98);
		plComment.Controls.Add(label5);
		plComment.Location = new Point(30, 169);
		plComment.Name = "plComment";
		plComment.Size = new Size(221, 27);
		plComment.TabIndex = 8;
		nudSoThang.Location = new Point(119, 1);
		nudSoThang.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudSoThang.Name = "nudSoThang";
		nudSoThang.Size = new Size(52, 23);
		nudSoThang.TabIndex = 0;
		nudSoThang.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		BB3AB506.AutoSize = true;
		BB3AB506.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BB3AB506.Location = new Point(172, 3);
		BB3AB506.Name = "label2";
		BB3AB506.Size = new Size(39, 16);
		BB3AB506.TabIndex = 151;
		BB3AB506.Text = "tháng";
		AFA5BD98.AutoSize = true;
		AFA5BD98.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		AFA5BD98.Location = new Point(2, 3);
		AFA5BD98.Name = "label4";
		AFA5BD98.Size = new Size(99, 16);
		AFA5BD98.TabIndex = 152;
		AFA5BD98.Text = "Số lượng tháng:";
		label5.AutoSize = true;
		label5.Location = new Point(3, 0);
		label5.Name = "label5";
		label5.Size = new Size(0, 16);
		label5.TabIndex = 31;
		plAnh.BorderStyle = BorderStyle.FixedSingle;
		plAnh.Controls.Add(button2);
		plAnh.Controls.Add(A0146035);
		plAnh.Controls.Add(nudSoLuongAnh);
		plAnh.Controls.Add(label10);
		plAnh.Controls.Add(label7);
		plAnh.Controls.Add(label3);
		plAnh.Location = new Point(30, 69);
		plAnh.Name = "plAnh";
		plAnh.Size = new Size(221, 50);
		plAnh.TabIndex = 8;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(154, 25);
		button2.Name = "button2";
		button2.Size = new Size(23, 23);
		button2.TabIndex = 153;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		A0146035.AutoSize = true;
		A0146035.Cursor = Cursors.Hand;
		A0146035.Location = new Point(5, 26);
		A0146035.Name = "ckbBackupImageNangCao";
		A0146035.Size = new Size(147, 20);
		A0146035.TabIndex = 0;
		A0146035.Text = "Backup ảnh nâng cao";
		A0146035.UseVisualStyleBackColor = true;
		nudSoLuongAnh.Location = new Point(119, 1);
		nudSoLuongAnh.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudSoLuongAnh.Name = "nudSoLuongAnh";
		nudSoLuongAnh.Size = new Size(52, 23);
		nudSoLuongAnh.TabIndex = 0;
		nudSoLuongAnh.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label10.AutoSize = true;
		label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label10.Location = new Point(173, 3);
		label10.Name = "label10";
		label10.Size = new Size(28, 16);
		label10.TabIndex = 151;
		label10.Text = "a\u0309nh";
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label7.Location = new Point(2, 3);
		label7.Name = "label7";
		label7.Size = new Size(114, 16);
		label7.TabIndex = 152;
		label7.Text = "Số lươ\u0323ng a\u0309nh/ba\u0323n:";
		label3.AutoSize = true;
		label3.Location = new Point(3, 0);
		label3.Name = "label3";
		label3.Size = new Size(0, 16);
		label3.TabIndex = 31;
		ckbBinhLuan.AutoSize = true;
		ckbBinhLuan.Cursor = Cursors.Hand;
		ckbBinhLuan.Location = new Point(12, 148);
		ckbBinhLuan.Name = "ckbBinhLuan";
		ckbBinhLuan.Size = new Size(141, 20);
		ckbBinhLuan.TabIndex = 3;
		ckbBinhLuan.Text = "Danh sách bình luận";
		ckbBinhLuan.UseVisualStyleBackColor = true;
		ckbBinhLuan.CheckedChanged += ckbBinhLuan_CheckedChanged;
		ckbAnhBanBe.AutoSize = true;
		ckbAnhBanBe.Cursor = Cursors.Hand;
		ckbAnhBanBe.Location = new Point(12, 46);
		ckbAnhBanBe.Name = "ckbAnhBanBe";
		ckbAnhBanBe.Size = new Size(91, 20);
		ckbAnhBanBe.TabIndex = 1;
		ckbAnhBanBe.Text = "Ảnh bạn bè";
		ckbAnhBanBe.UseVisualStyleBackColor = true;
		ckbAnhBanBe.CheckedChanged += ckbAnhBanBe_CheckedChanged;
		ckbCreateHTML.AutoSize = true;
		ckbCreateHTML.Cursor = Cursors.Hand;
		ckbCreateHTML.Location = new Point(30, 293);
		ckbCreateHTML.Name = "ckbCreateHTML";
		ckbCreateHTML.Size = new Size(266, 20);
		ckbCreateHTML.TabIndex = 2;
		ckbCreateHTML.Text = "Tự động tạo luôn File Html sau khi backup";
		ckbCreateHTML.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(193, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
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
		btnCancel.Location = new Point(189, 327);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 327);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		FA27ACA4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		FA27ACA4.BackColor = Color.White;
		FA27ACA4.BorderRadius = 0;
		FA27ACA4.BottomSahddow = true;
		FA27ACA4.color = Color.DarkViolet;
		FA27ACA4.Controls.Add(pnlHeader);
		FA27ACA4.LeftSahddow = false;
		FA27ACA4.Location = new Point(1, 0);
		FA27ACA4.Name = "bunifuCards1";
		FA27ACA4.RightSahddow = true;
		FA27ACA4.ShadowDepth = 20;
		FA27ACA4.Size = new Size(359, 37);
		FA27ACA4.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 373);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBackupData";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += B118DF83;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)EC029DB6).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		((ISupportInitialize)nudSoThang).EndInit();
		plAnh.ResumeLayout(performLayout: false);
		plAnh.PerformLayout();
		((ISupportInitialize)nudSoLuongAnh).EndInit();
		FA27ACA4.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
