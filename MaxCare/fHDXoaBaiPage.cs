using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXoaBaiPage : Form
{
	private JSON_Settings gclass8_0 = null;

	private string A70838B0;

	private string string_0;

	private string B0A6DDBA;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel C9A16A01;

	private NumericUpDown nudDelayTo;

	private NumericUpDown A2097B1A;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label AF3A4906;

	private Label E706913D;

	private Button EA2049B7;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox BE16DA89;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown A7214EB7;

	private NumericUpDown B5039D90;

	private TextBox txtIdPage;

	private Label E8957109;

	private Label B0128E9D;

	private Label D0A76B99;

	private Label label2;

	public fHDXoaBaiPage(string string_1, int int_1 = 0, string string_2 = "")
	{
		B8969C01();
		bool_0 = false;
		A70838B0 = string_1;
		B0A6DDBA = string_2;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDXoaBaiPage").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaBaiPage', 'Xóa bài page');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXoaBaiPage");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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

	private void D1B2A918()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(E706913D);
		Language.smethod_0(AF3A4906);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(EA2049B7);
	}

	private void fHDXoaBaiPage_Load(object sender, EventArgs e)
	{
		try
		{
			txtIdPage.Text = gclass8_0.GetValue("txtIdPage");
			B5039D90.Value = gclass8_0.GetValueInt("nudSoLuongBaiFrom", 3);
			A7214EB7.Value = gclass8_0.GetValueInt("nudSoLuongBaiTo", 3);
			A2097B1A.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
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
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtIdPage", txtIdPage.Text);
		gClass.GetJson("nudSoLuongBaiFrom", B5039D90.Value);
		gClass.GetJson("nudSoLuongBaiTo", A7214EB7.Value);
		gClass.GetJson("nudDelayFrom", A2097B1A.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(A70838B0, text, string_0, text2))
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
			if (InteractSQL.smethod_13(B0A6DDBA, text, text2))
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

	private void B5AE4311(object sender, EventArgs e)
	{
		Close();
	}

	private void C9A16A01_Paint(object sender, PaintEventArgs e)
	{
		if (C9A16A01.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C9A16A01.ClientSize.Width - num, C9A16A01.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void B8969C01()
	{
		icontainer_0 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		BE16DA89 = new PictureBox();
		C9A16A01 = new Panel();
		A7214EB7 = new NumericUpDown();
		nudDelayTo = new NumericUpDown();
		B5039D90 = new NumericUpDown();
		A2097B1A = new NumericUpDown();
		txtIdPage = new TextBox();
		E8957109 = new Label();
		txtTenHanhDong = new TextBox();
		B0128E9D = new Label();
		label7 = new Label();
		label6 = new Label();
		D0A76B99 = new Label();
		label2 = new Label();
		AF3A4906 = new Label();
		E706913D = new Label();
		EA2049B7 = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)BE16DA89).BeginInit();
		C9A16A01.SuspendLayout();
		((ISupportInitialize)A7214EB7).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)B5039D90).BeginInit();
		((ISupportInitialize)A2097B1A).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Xóa bài viết trên Fanpage";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(BE16DA89);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
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
		button1.Image = Resources.C400940B;
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		BE16DA89.Cursor = Cursors.Default;
		BE16DA89.Image = Resources.Bitmap_4;
		BE16DA89.Location = new Point(3, 2);
		BE16DA89.Name = "pictureBox1";
		BE16DA89.Size = new Size(34, 27);
		BE16DA89.SizeMode = PictureBoxSizeMode.Zoom;
		BE16DA89.TabIndex = 76;
		BE16DA89.TabStop = false;
		C9A16A01.BackColor = Color.White;
		C9A16A01.BorderStyle = BorderStyle.FixedSingle;
		C9A16A01.Controls.Add(A7214EB7);
		C9A16A01.Controls.Add(nudDelayTo);
		C9A16A01.Controls.Add(B5039D90);
		C9A16A01.Controls.Add(A2097B1A);
		C9A16A01.Controls.Add(txtIdPage);
		C9A16A01.Controls.Add(E8957109);
		C9A16A01.Controls.Add(txtTenHanhDong);
		C9A16A01.Controls.Add(B0128E9D);
		C9A16A01.Controls.Add(label7);
		C9A16A01.Controls.Add(label6);
		C9A16A01.Controls.Add(D0A76B99);
		C9A16A01.Controls.Add(label2);
		C9A16A01.Controls.Add(AF3A4906);
		C9A16A01.Controls.Add(E706913D);
		C9A16A01.Controls.Add(EA2049B7);
		C9A16A01.Controls.Add(btnAdd);
		C9A16A01.Controls.Add(bunifuCards1);
		C9A16A01.Cursor = Cursors.Arrow;
		C9A16A01.Dock = DockStyle.Fill;
		C9A16A01.Location = new Point(0, 0);
		C9A16A01.Name = "panel1";
		C9A16A01.Size = new Size(362, 216);
		C9A16A01.TabIndex = 0;
		C9A16A01.Paint += C9A16A01_Paint;
		A7214EB7.Location = new Point(229, 107);
		A7214EB7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A7214EB7.Name = "nudSoLuongBaiTo";
		A7214EB7.Size = new Size(56, 23);
		A7214EB7.TabIndex = 4;
		nudDelayTo.Location = new Point(229, 136);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		B5039D90.Location = new Point(132, 107);
		B5039D90.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B5039D90.Name = "nudSoLuongBaiFrom";
		B5039D90.Size = new Size(56, 23);
		B5039D90.TabIndex = 3;
		A2097B1A.Location = new Point(132, 136);
		A2097B1A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A2097B1A.Name = "nudDelayFrom";
		A2097B1A.Size = new Size(56, 23);
		A2097B1A.TabIndex = 3;
		txtIdPage.Location = new Point(132, 78);
		txtIdPage.Name = "txtIdPage";
		txtIdPage.Size = new Size(194, 23);
		txtIdPage.TabIndex = 0;
		E8957109.Location = new Point(194, 109);
		E8957109.Name = "label8";
		E8957109.Size = new Size(29, 16);
		E8957109.TabIndex = 38;
		E8957109.Text = "đê\u0301n";
		E8957109.TextAlign = ContentAlignment.MiddleCenter;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		B0128E9D.AutoSize = true;
		B0128E9D.Location = new Point(287, 109);
		B0128E9D.Name = "label4";
		B0128E9D.Size = new Size(24, 16);
		B0128E9D.TabIndex = 36;
		B0128E9D.Text = "bài";
		label7.Location = new Point(194, 138);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 138);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		D0A76B99.AutoSize = true;
		D0A76B99.Location = new Point(27, 109);
		D0A76B99.Name = "label3";
		D0A76B99.Size = new Size(84, 16);
		D0A76B99.TabIndex = 34;
		D0A76B99.Text = "Số lượng bài:";
		label2.AutoSize = true;
		label2.Location = new Point(27, 81);
		label2.Name = "label2";
		label2.Size = new Size(56, 16);
		label2.TabIndex = 31;
		label2.Text = "ID Page:";
		AF3A4906.AutoSize = true;
		AF3A4906.Location = new Point(27, 138);
		AF3A4906.Name = "label5";
		AF3A4906.Size = new Size(89, 16);
		AF3A4906.TabIndex = 34;
		AF3A4906.Text = "Thơ\u0300i gian chơ\u0300:";
		E706913D.AutoSize = true;
		E706913D.Location = new Point(27, 52);
		E706913D.Name = "label1";
		E706913D.Size = new Size(98, 16);
		E706913D.TabIndex = 31;
		E706913D.Text = "Tên ha\u0300nh đô\u0323ng:";
		EA2049B7.Anchor = AnchorStyles.Bottom;
		EA2049B7.BackColor = Color.Maroon;
		EA2049B7.Cursor = Cursors.Hand;
		EA2049B7.FlatAppearance.BorderSize = 0;
		EA2049B7.FlatStyle = FlatStyle.Flat;
		EA2049B7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		EA2049B7.ForeColor = Color.White;
		EA2049B7.Location = new Point(189, 174);
		EA2049B7.Name = "btnCancel";
		EA2049B7.Size = new Size(92, 29);
		EA2049B7.TabIndex = 10;
		EA2049B7.Text = "Đóng";
		EA2049B7.UseVisualStyleBackColor = false;
		EA2049B7.Click += B5AE4311;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 174);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
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
		base.ClientSize = new Size(362, 216);
		base.Controls.Add(C9A16A01);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXoaBaiPage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDXoaBaiPage_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)BE16DA89).EndInit();
		C9A16A01.ResumeLayout(performLayout: false);
		C9A16A01.PerformLayout();
		((ISupportInitialize)A7214EB7).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)B5039D90).EndInit();
		((ISupportInitialize)A2097B1A).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
