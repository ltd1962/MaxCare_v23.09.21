using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDKetBanVoiBanCuaBanBe : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer D320398C = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl FF31AB20;

	private Panel panel1;

	private NumericUpDown BA85E109;

	private NumericUpDown FE09A416;

	private TextBox BA19423E;

	private Label C227DEA4;

	private Label label4;

	private Label label2;

	private Label C621CEA6;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox D9AB843C;

	private BunifuCustomLabel F011ED2F;

	private NumericUpDown D334C805;

	private NumericUpDown F29F508A;

	private Label label7;

	private Label C7B8199A;

	private Label B6956994;

	private NumericUpDown BF238F21;

	private Label ED941D8E;

	private Label DDBE922D;

	public fHDKetBanVoiBanCuaBanBe(string E4051DA6, int int_1 = 0, string string_3 = "")
	{
		B2835826();
		bool_0 = false;
		string_0 = E4051DA6;
		string_2 = string_3;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDKetBanVoiBanCuaBanBe").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanVoiBanCuaBanBe', 'Kết bạn với bạn của Bạn bè');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanVoiBanCuaBanBe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BA19423E.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			BA19423E.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(F011ED2F);
		Language.smethod_0(C621CEA6);
		Language.smethod_0(label2);
		Language.smethod_0(C227DEA4);
		Language.smethod_0(label4);
		Language.smethod_0(B6956994);
		Language.smethod_0(label7);
		Language.smethod_0(C7B8199A);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void CD83072B(object sender, EventArgs e)
	{
		try
		{
			FE09A416.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 3);
			BA85E109.Value = gclass8_0.GetValueInt("nudSoLuongTo", 5);
			F29F508A.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			D334C805.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			BF238F21.Value = gclass8_0.GetValueInt("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D6A36908(object sender, EventArgs e)
	{
		string text = BA19423E.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", FE09A416.Value);
		gClass.GetJson("nudSoLuongTo", BA85E109.Value);
		gClass.GetJson("nudDelayFrom", F29F508A.Value);
		gClass.GetJson("nudDelayTo", D334C805.Value);
		gClass.GetJson("nudTimesWarning", BF238F21.Value);
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

	protected override void Dispose(bool D4ABCA91)
	{
		if (D4ABCA91 && D320398C != null)
		{
			D320398C.Dispose();
		}
		base.Dispose(D4ABCA91);
	}

	private void B2835826()
	{
		D320398C = new Container();
		bunifuDragControl_0 = new BunifuDragControl(D320398C);
		F011ED2F = new BunifuCustomLabel();
		FF31AB20 = new BunifuDragControl(D320398C);
		pnlHeader = new Panel();
		button1 = new Button();
		D9AB843C = new PictureBox();
		panel1 = new Panel();
		BF238F21 = new NumericUpDown();
		D334C805 = new NumericUpDown();
		F29F508A = new NumericUpDown();
		ED941D8E = new Label();
		label7 = new Label();
		C7B8199A = new Label();
		DDBE922D = new Label();
		B6956994 = new Label();
		BA85E109 = new NumericUpDown();
		FE09A416 = new NumericUpDown();
		BA19423E = new TextBox();
		C227DEA4 = new Label();
		label4 = new Label();
		label2 = new Label();
		C621CEA6 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)D9AB843C).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)BF238F21).BeginInit();
		((ISupportInitialize)D334C805).BeginInit();
		((ISupportInitialize)F29F508A).BeginInit();
		((ISupportInitialize)BA85E109).BeginInit();
		((ISupportInitialize)FE09A416).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F011ED2F;
		bunifuDragControl_0.Vertical = true;
		F011ED2F.BackColor = Color.Transparent;
		F011ED2F.Cursor = Cursors.SizeAll;
		F011ED2F.Dock = DockStyle.Fill;
		F011ED2F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F011ED2F.ForeColor = Color.Black;
		F011ED2F.Location = new Point(0, 0);
		F011ED2F.Name = "bunifuCustomLabel1";
		F011ED2F.Size = new Size(359, 31);
		F011ED2F.TabIndex = 12;
		F011ED2F.Text = "Cấu hình Kết bạn với bạn của Bạn bè";
		F011ED2F.TextAlign = ContentAlignment.MiddleCenter;
		FF31AB20.Fixed = true;
		FF31AB20.Horizontal = true;
		FF31AB20.TargetControl = pnlHeader;
		FF31AB20.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(D9AB843C);
		pnlHeader.Controls.Add(F011ED2F);
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
		D9AB843C.Cursor = Cursors.Default;
		D9AB843C.Image = Resources.Bitmap_4;
		D9AB843C.Location = new Point(3, 2);
		D9AB843C.Name = "pictureBox1";
		D9AB843C.Size = new Size(34, 27);
		D9AB843C.SizeMode = PictureBoxSizeMode.Zoom;
		D9AB843C.TabIndex = 76;
		D9AB843C.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(BF238F21);
		panel1.Controls.Add(D334C805);
		panel1.Controls.Add(F29F508A);
		panel1.Controls.Add(ED941D8E);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(C7B8199A);
		panel1.Controls.Add(DDBE922D);
		panel1.Controls.Add(B6956994);
		panel1.Controls.Add(BA85E109);
		panel1.Controls.Add(FE09A416);
		panel1.Controls.Add(BA19423E);
		panel1.Controls.Add(C227DEA4);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(C621CEA6);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 187);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		BF238F21.Location = new Point(253, 220);
		BF238F21.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BF238F21.Name = "nudTimesWarning";
		BF238F21.Size = new Size(43, 23);
		BF238F21.TabIndex = 4;
		D334C805.Location = new Point(229, 112);
		D334C805.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D334C805.Name = "nudDelayTo";
		D334C805.Size = new Size(56, 23);
		D334C805.TabIndex = 4;
		F29F508A.Location = new Point(132, 112);
		F29F508A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F29F508A.Name = "nudDelayFrom";
		F29F508A.Size = new Size(56, 23);
		F29F508A.TabIndex = 3;
		ED941D8E.AutoSize = true;
		ED941D8E.Location = new Point(299, 222);
		ED941D8E.Name = "label9";
		ED941D8E.Size = new Size(25, 16);
		ED941D8E.TabIndex = 45;
		ED941D8E.Text = "lần";
		label7.AutoSize = true;
		label7.Location = new Point(194, 114);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		C7B8199A.AutoSize = true;
		C7B8199A.Location = new Point(290, 114);
		C7B8199A.Name = "label6";
		C7B8199A.Size = new Size(31, 16);
		C7B8199A.TabIndex = 45;
		C7B8199A.Text = "giây";
		DDBE922D.AutoSize = true;
		DDBE922D.Location = new Point(27, 222);
		DDBE922D.Name = "label8";
		DDBE922D.Size = new Size(226, 16);
		DDBE922D.TabIndex = 44;
		DDBE922D.Text = "Dừng khi gặp cảnh báo của Facebook:";
		B6956994.AutoSize = true;
		B6956994.Location = new Point(27, 114);
		B6956994.Name = "label5";
		B6956994.Size = new Size(90, 16);
		B6956994.TabIndex = 44;
		B6956994.Text = "Thơ\u0300i gian chơ\u0300:";
		BA85E109.Location = new Point(229, 81);
		BA85E109.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BA85E109.Name = "nudSoLuongTo";
		BA85E109.Size = new Size(56, 23);
		BA85E109.TabIndex = 2;
		FE09A416.Location = new Point(132, 81);
		FE09A416.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FE09A416.Name = "nudSoLuongFrom";
		FE09A416.Size = new Size(56, 23);
		FE09A416.TabIndex = 1;
		BA19423E.Location = new Point(132, 49);
		BA19423E.Name = "txtTenHanhDong";
		BA19423E.Size = new Size(194, 23);
		BA19423E.TabIndex = 0;
		C227DEA4.AutoSize = true;
		C227DEA4.Location = new Point(194, 83);
		C227DEA4.Name = "label3";
		C227DEA4.Size = new Size(29, 16);
		C227DEA4.TabIndex = 37;
		C227DEA4.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new Point(290, 83);
		label4.Name = "label4";
		label4.Size = new Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(27, 83);
		label2.Name = "label2";
		label2.Size = new Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		C621CEA6.AutoSize = true;
		C621CEA6.Location = new Point(27, 52);
		C621CEA6.Name = "label1";
		C621CEA6.Size = new Size(99, 16);
		C621CEA6.TabIndex = 31;
		C621CEA6.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(193, 146);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(86, 146);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += D6A36908;
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
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 187);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVoiBanCuaBanBe";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += CD83072B;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)D9AB843C).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)BF238F21).EndInit();
		((ISupportInitialize)D334C805).EndInit();
		((ISupportInitialize)F29F508A).EndInit();
		((ISupportInitialize)BA85E109).EndInit();
		((ISupportInitialize)FE09A416).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
