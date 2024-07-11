using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDDocThongBaov2 : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer C4029131 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl EBB66B34;

	private Panel F72673A6;

	private NumericUpDown E33172AB;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown B0AC88BF;

	private NumericUpDown B1B80D30;

	private TextBox BB9BEC8B;

	private Label label7;

	private Label A196F80E;

	private Label label6;

	private Label A589F6BC;

	private Label ED164E17;

	private Label C49C2235;

	private Label B211AF10;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards A9224191;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A8B4A397;

	public fHDDocThongBaov2(string D58759B2, int BCBE46BF = 0, string string_3 = "")
	{
		B10A753F();
		bool_0 = false;
		string_0 = D58759B2;
		string_2 = string_3;
		int_0 = BCBE46BF;
		if (InteractSQL.B484648C("", "HDDocThongBaov2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDDocThongBaov2', 'Đọc thông báo v2');");
		}
		string text = "";
		switch (BCBE46BF)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDDocThongBaov2");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BB9BEC8B.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			BB9BEC8B.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(A8B4A397);
		Language.smethod_0(B211AF10);
		Language.smethod_0(C49C2235);
		Language.smethod_0(A196F80E);
		Language.smethod_0(A589F6BC);
		Language.smethod_0(ED164E17);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void fHDDocThongBaov2_Load(object sender, EventArgs e)
	{
		try
		{
			B1B80D30.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			B0AC88BF.Value = gclass8_0.GetValueInt("nudDelayFrom", 2);
			E33172AB.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A993868C(object sender, EventArgs e)
	{
		string text = BB9BEC8B.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", B1B80D30.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", B0AC88BF.Value);
		gClass.GetJson("nudDelayTo", E33172AB.Value);
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

	private void CD340819(object sender, EventArgs e)
	{
		Close();
	}

	private void D9B833A3(object sender, PaintEventArgs e)
	{
		if (F72673A6.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F72673A6.ClientSize.Width - num, F72673A6.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && C4029131 != null)
		{
			C4029131.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void B10A753F()
	{
		C4029131 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(C4029131);
		A8B4A397 = new BunifuCustomLabel();
		EBB66B34 = new BunifuDragControl(C4029131);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		F72673A6 = new Panel();
		E33172AB = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		B0AC88BF = new NumericUpDown();
		B1B80D30 = new NumericUpDown();
		BB9BEC8B = new TextBox();
		label7 = new Label();
		A196F80E = new Label();
		label6 = new Label();
		A589F6BC = new Label();
		ED164E17 = new Label();
		C49C2235 = new Label();
		B211AF10 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		A9224191 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		F72673A6.SuspendLayout();
		((ISupportInitialize)E33172AB).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)B0AC88BF).BeginInit();
		((ISupportInitialize)B1B80D30).BeginInit();
		A9224191.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = A8B4A397;
		bunifuDragControl_0.Vertical = true;
		A8B4A397.BackColor = Color.Transparent;
		A8B4A397.Cursor = Cursors.SizeAll;
		A8B4A397.Dock = DockStyle.Fill;
		A8B4A397.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A8B4A397.ForeColor = Color.Black;
		A8B4A397.Location = new Point(0, 0);
		A8B4A397.Name = "bunifuCustomLabel1";
		A8B4A397.Size = new Size(359, 31);
		A8B4A397.TabIndex = 12;
		A8B4A397.Text = "Cấu hình Đọc thông báo v2";
		A8B4A397.TextAlign = ContentAlignment.MiddleCenter;
		EBB66B34.Fixed = true;
		EBB66B34.Horizontal = true;
		EBB66B34.TargetControl = pnlHeader;
		EBB66B34.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(A8B4A397);
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
		button1.Image = Resources.A13F2207;
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
		F72673A6.BackColor = Color.White;
		F72673A6.BorderStyle = BorderStyle.FixedSingle;
		F72673A6.Controls.Add(E33172AB);
		F72673A6.Controls.Add(nudSoLuongTo);
		F72673A6.Controls.Add(B0AC88BF);
		F72673A6.Controls.Add(B1B80D30);
		F72673A6.Controls.Add(BB9BEC8B);
		F72673A6.Controls.Add(label7);
		F72673A6.Controls.Add(A196F80E);
		F72673A6.Controls.Add(label6);
		F72673A6.Controls.Add(A589F6BC);
		F72673A6.Controls.Add(ED164E17);
		F72673A6.Controls.Add(C49C2235);
		F72673A6.Controls.Add(B211AF10);
		F72673A6.Controls.Add(btnCancel);
		F72673A6.Controls.Add(btnAdd);
		F72673A6.Controls.Add(A9224191);
		F72673A6.Cursor = Cursors.Arrow;
		F72673A6.Dock = DockStyle.Fill;
		F72673A6.Location = new Point(0, 0);
		F72673A6.Name = "panel1";
		F72673A6.Size = new Size(362, 188);
		F72673A6.TabIndex = 0;
		F72673A6.Paint += D9B833A3;
		E33172AB.Location = new Point(216, 109);
		E33172AB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E33172AB.Name = "nudDelayTo";
		E33172AB.Size = new Size(56, 23);
		E33172AB.TabIndex = 6;
		nudSoLuongTo.Location = new Point(216, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		B0AC88BF.Location = new Point(122, 109);
		B0AC88BF.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B0AC88BF.Name = "nudDelayFrom";
		B0AC88BF.Size = new Size(56, 23);
		B0AC88BF.TabIndex = 5;
		B1B80D30.Location = new Point(122, 80);
		B1B80D30.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B1B80D30.Name = "nudSoLuongFrom";
		B1B80D30.Size = new Size(56, 23);
		B1B80D30.TabIndex = 1;
		BB9BEC8B.Location = new Point(122, 49);
		BB9BEC8B.Name = "txtTenHanhDong";
		BB9BEC8B.Size = new Size(222, 23);
		BB9BEC8B.TabIndex = 0;
		label7.Location = new Point(182, 111);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		A196F80E.Location = new Point(182, 82);
		A196F80E.Name = "label3";
		A196F80E.Size = new Size(29, 16);
		A196F80E.TabIndex = 37;
		A196F80E.Text = "đê\u0301n";
		A196F80E.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(277, 111);
		label6.Name = "label6";
		label6.Size = new Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		A589F6BC.AutoSize = true;
		A589F6BC.Location = new Point(274, 82);
		A589F6BC.Name = "label4";
		A589F6BC.Size = new Size(65, 16);
		A589F6BC.TabIndex = 35;
		A589F6BC.Text = "thông ba\u0301o";
		ED164E17.AutoSize = true;
		ED164E17.Location = new Point(17, 111);
		ED164E17.Name = "label5";
		ED164E17.Size = new Size(90, 16);
		ED164E17.TabIndex = 34;
		ED164E17.Text = "Thơ\u0300i gian chơ\u0300:";
		C49C2235.AutoSize = true;
		C49C2235.Location = new Point(17, 82);
		C49C2235.Name = "label2";
		C49C2235.Size = new Size(64, 16);
		C49C2235.TabIndex = 32;
		C49C2235.Text = "Sô\u0301 lươ\u0323ng:";
		B211AF10.AutoSize = true;
		B211AF10.Location = new Point(17, 52);
		B211AF10.Name = "label1";
		B211AF10.Size = new Size(99, 16);
		B211AF10.TabIndex = 31;
		B211AF10.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(187, 148);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 8;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += CD340819;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(83, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 7;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += A993868C;
		A9224191.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		A9224191.BackColor = Color.White;
		A9224191.BorderRadius = 0;
		A9224191.BottomSahddow = true;
		A9224191.color = Color.DarkViolet;
		A9224191.Controls.Add(pnlHeader);
		A9224191.LeftSahddow = false;
		A9224191.Location = new Point(1, 0);
		A9224191.Name = "bunifuCards1";
		A9224191.RightSahddow = true;
		A9224191.ShadowDepth = 20;
		A9224191.Size = new Size(359, 37);
		A9224191.TabIndex = 9;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 188);
		base.Controls.Add(F72673A6);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDocThongBaov2";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDocThongBaov2_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		F72673A6.ResumeLayout(performLayout: false);
		F72673A6.PerformLayout();
		((ISupportInitialize)E33172AB).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)B0AC88BF).EndInit();
		((ISupportInitialize)B1B80D30).EndInit();
		A9224191.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
