using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Bunifu.Framework.UI;

public class fHDSharePage : Form
{
	private JSON_Settings CC8A6233;

	private string string_0;

	private string string_1;

	private string string_2;

	private int DE2CE89C;

	public static bool bool_0;

	private IContainer B825081F = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A5231EA2;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox C33F8D98;

	private Label label3;

	private Label B6953FA6;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button BE31BEA1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button C2BD651B;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown FA1CBE9D;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label BA152D2F;

	private Label D7931B22;

	private TextBox txtToCookie;

	private Label BE933290;

	private CheckBox ckbLeavePage;

	public fHDSharePage(string E5B8F8B0, int int_0 = 0, string string_3 = "")
	{
		DA3A950F();
		bool_0 = false;
		string_0 = E5B8F8B0;
		string_2 = string_3;
		DE2CE89C = int_0;
		if (InteractSQL.B484648C("", "HDSharePage").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSharePage', 'Share page');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDSharePage");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C33F8D98.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			BE31BEA1.Text = "Câ\u0323p nhâ\u0323t";
			C33F8D98.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CC8A6233 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void C09554B7_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = CC8A6233.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = CC8A6233.GetValueInt("nudSoLuongTo", 1);
			nudDelayFrom.Value = CC8A6233.GetValueInt("nudDelayFrom", 3);
			FA1CBE9D.Value = CC8A6233.GetValueInt("nudDelayTo", 5);
			txtToCookie.Text = CC8A6233.GetValue("txtToCookie");
			ckbLeavePage.Checked = CC8A6233.GetValueBool("ckbLeavePage");
		}
		catch
		{
		}
	}

	private void BE0EC081(object sender, EventArgs e)
	{
		Close();
	}

	private void BB0401B1(object sender, EventArgs e)
	{
		string text = C33F8D98.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", FA1CBE9D.Value);
		gClass.GetJson("txtToCookie", txtToCookie.Text);
		gClass.GetJson("ckbLeavePage", ckbLeavePage.Checked);
		string string_ = gClass.D9A09B34();
		if (DE2CE89C == 0)
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

	protected override void Dispose(bool A78F2430)
	{
		if (A78F2430 && B825081F != null)
		{
			B825081F.Dispose();
		}
		base.Dispose(A78F2430);
	}

	private void DA3A950F()
	{
		B825081F = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDSharePage));
		bunifuDragControl_0 = new BunifuDragControl(B825081F);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		A5231EA2 = new BunifuDragControl(B825081F);
		pnlHeader = new Panel();
		C2BD651B = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		ckbLeavePage = new CheckBox();
		FA1CBE9D = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		BA152D2F = new Label();
		D7931B22 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtToCookie = new TextBox();
		C33F8D98 = new TextBox();
		label3 = new Label();
		B6953FA6 = new Label();
		BE933290 = new Label();
		label2 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		BE31BEA1 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)FA1CBE9D).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(352, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Share page";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		A5231EA2.Fixed = true;
		A5231EA2.Horizontal = true;
		A5231EA2.TargetControl = pnlHeader;
		A5231EA2.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(C2BD651B);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(352, 31);
		pnlHeader.TabIndex = 9;
		C2BD651B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C2BD651B.Cursor = Cursors.Hand;
		C2BD651B.FlatAppearance.BorderSize = 0;
		C2BD651B.FlatStyle = FlatStyle.Flat;
		C2BD651B.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C2BD651B.ForeColor = Color.White;
		C2BD651B.Image = (Image)componentResourceManager.GetObject("button1.Image");
		C2BD651B.Location = new Point(321, 1);
		C2BD651B.Name = "button1";
		C2BD651B.Size = new Size(30, 30);
		C2BD651B.TabIndex = 77;
		C2BD651B.TextImageRelation = TextImageRelation.ImageBeforeText;
		C2BD651B.UseVisualStyleBackColor = true;
		C2BD651B.Click += BE0EC081;
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
		panel1.Controls.Add(ckbLeavePage);
		panel1.Controls.Add(FA1CBE9D);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(BA152D2F);
		panel1.Controls.Add(D7931B22);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtToCookie);
		panel1.Controls.Add(C33F8D98);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(B6953FA6);
		panel1.Controls.Add(BE933290);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(BE31BEA1);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(355, 240);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		ckbLeavePage.AutoSize = true;
		ckbLeavePage.Cursor = Cursors.Hand;
		ckbLeavePage.Location = new Point(30, 164);
		ckbLeavePage.Name = "ckbLeavePage";
		ckbLeavePage.Size = new Size(223, 20);
		ckbLeavePage.TabIndex = 47;
		ckbLeavePage.Text = "Rời page sau khi share thành công";
		ckbLeavePage.UseVisualStyleBackColor = true;
		FA1CBE9D.Location = new Point(229, 107);
		FA1CBE9D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FA1CBE9D.Name = "nudDelayTo";
		FA1CBE9D.Size = new Size(56, 23);
		FA1CBE9D.TabIndex = 4;
		nudDelayFrom.Location = new Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(199, 109);
		label7.Name = "label7";
		label7.Size = new Size(18, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		BA152D2F.AutoSize = true;
		BA152D2F.Location = new Point(290, 109);
		BA152D2F.Name = "label6";
		BA152D2F.Size = new Size(13, 16);
		BA152D2F.TabIndex = 45;
		BA152D2F.Text = "s";
		D7931B22.AutoSize = true;
		D7931B22.Location = new Point(27, 109);
		D7931B22.Name = "label5";
		D7931B22.Size = new Size(92, 16);
		D7931B22.TabIndex = 44;
		D7931B22.Text = "Delay time (s):";
		nudSoLuongTo.Location = new Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtToCookie.Location = new Point(132, 135);
		txtToCookie.Name = "txtToCookie";
		txtToCookie.Size = new Size(194, 23);
		txtToCookie.TabIndex = 0;
		C33F8D98.Location = new Point(132, 49);
		C33F8D98.Name = "txtTenHanhDong";
		C33F8D98.Size = new Size(194, 23);
		C33F8D98.TabIndex = 0;
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(199, 80);
		label3.Name = "label3";
		label3.Size = new Size(18, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		B6953FA6.AutoSize = true;
		B6953FA6.Location = new Point(290, 80);
		B6953FA6.Name = "label4";
		B6953FA6.Size = new Size(35, 16);
		B6953FA6.TabIndex = 35;
		B6953FA6.Text = "page";
		BE933290.AutoSize = true;
		BE933290.Location = new Point(27, 137);
		BE933290.Name = "label10";
		BE933290.Size = new Size(82, 16);
		BE933290.TabIndex = 31;
		BE933290.Text = "Cookie nhận:";
		label2.AutoSize = true;
		label2.Location = new Point(27, 80);
		label2.Name = "label2";
		label2.Size = new Size(95, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng page:";
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
		btnCancel.Location = new Point(184, 196);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		BE31BEA1.Anchor = AnchorStyles.Bottom;
		BE31BEA1.BackColor = Color.FromArgb(53, 120, 229);
		BE31BEA1.Cursor = Cursors.Hand;
		BE31BEA1.FlatAppearance.BorderSize = 0;
		BE31BEA1.FlatStyle = FlatStyle.Flat;
		BE31BEA1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BE31BEA1.ForeColor = Color.White;
		BE31BEA1.Location = new Point(77, 196);
		BE31BEA1.Name = "btnAdd";
		BE31BEA1.Size = new Size(92, 29);
		BE31BEA1.TabIndex = 6;
		BE31BEA1.Text = "Thêm";
		BE31BEA1.UseVisualStyleBackColor = false;
		BE31BEA1.Click += BB0401B1;
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
		bunifuCards1.Size = new Size(352, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(355, 240);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDSharePage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C09554B7_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)FA1CBE9D).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
