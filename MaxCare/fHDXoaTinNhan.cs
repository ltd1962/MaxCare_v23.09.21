using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXoaTinNhan : Form
{
	private JSON_Settings E090C31A = null;

	private string string_0;

	private string string_1;

	private string B73480A6;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl D0A9243A;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label C62FC22F;

	private Label label1;

	private Button btnCancel;

	private Button F43CFF34;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button D227FFB4;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown C12D7C30;

	private Label D286192B;

	private Label C39FB9B1;

	private Label label4;

	public fHDXoaTinNhan(string B4129FB0, int BE8CD805 = 0, string string_2 = "")
	{
		E808D986();
		bool_0 = false;
		string_0 = B4129FB0;
		B73480A6 = string_2;
		int_0 = BE8CD805;
		if (InteractSQL.B484648C("", "HDXoaTinNhan").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaTinNhan', 'Xóa tin nhắn');");
		}
		string text = "";
		switch (BE8CD805)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXoaTinNhan");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			F43CFF34.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E090C31A = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(C62FC22F);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(F43CFF34);
		Language.smethod_0(btnCancel);
	}

	private void BAADEE80_Load(object sender, EventArgs e)
	{
		try
		{
			C12D7C30.Value = E090C31A.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = E090C31A.GetValueInt("nudSoLuongTo", 3);
			nudDelayFrom.Value = E090C31A.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = E090C31A.GetValueInt("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void D227FFB4_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E7913095(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", C12D7C30.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
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
			if (InteractSQL.smethod_13(B73480A6, text, string_))
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

	private void AB24939D(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
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

	private void E808D986()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXoaTinNhan));
		D0A9243A = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		D227FFB4 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		nudSoLuongTo = new NumericUpDown();
		C12D7C30 = new NumericUpDown();
		D286192B = new Label();
		C39FB9B1 = new Label();
		label4 = new Label();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		label6 = new Label();
		C62FC22F = new Label();
		label1 = new Label();
		btnCancel = new Button();
		F43CFF34 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)C12D7C30).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D0A9243A.Fixed = true;
		D0A9243A.Horizontal = true;
		D0A9243A.TargetControl = bunifuCustomLabel1;
		D0A9243A.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xóa tin nhắn";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D227FFB4);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		D227FFB4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D227FFB4.Cursor = Cursors.Hand;
		D227FFB4.FlatAppearance.BorderSize = 0;
		D227FFB4.FlatStyle = FlatStyle.Flat;
		D227FFB4.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D227FFB4.ForeColor = Color.White;
		D227FFB4.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D227FFB4.Location = new Point(328, 1);
		D227FFB4.Name = "button1";
		D227FFB4.Size = new Size(30, 30);
		D227FFB4.TabIndex = 77;
		D227FFB4.TextImageRelation = TextImageRelation.ImageBeforeText;
		D227FFB4.UseVisualStyleBackColor = true;
		D227FFB4.Click += D227FFB4_Click;
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
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(C12D7C30);
		panel1.Controls.Add(D286192B);
		panel1.Controls.Add(C39FB9B1);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(C62FC22F);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F43CFF34);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 182);
		panel1.TabIndex = 0;
		panel1.Paint += AB24939D;
		nudSoLuongTo.Location = new Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 40;
		C12D7C30.Location = new Point(132, 78);
		C12D7C30.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C12D7C30.Name = "nudSoLuongFrom";
		C12D7C30.Size = new Size(56, 23);
		C12D7C30.TabIndex = 39;
		D286192B.Location = new Point(194, 80);
		D286192B.Name = "label2";
		D286192B.Size = new Size(29, 16);
		D286192B.TabIndex = 43;
		D286192B.Text = "đê\u0301n";
		D286192B.TextAlign = ContentAlignment.MiddleCenter;
		C39FB9B1.AutoSize = true;
		C39FB9B1.Location = new Point(287, 80);
		C39FB9B1.Name = "label3";
		C39FB9B1.Size = new Size(53, 16);
		C39FB9B1.TabIndex = 42;
		C39FB9B1.Text = "tin nhắn";
		label4.AutoSize = true;
		label4.Location = new Point(27, 80);
		label4.Name = "label4";
		label4.Size = new Size(63, 16);
		label4.TabIndex = 41;
		label4.Text = "Số lượng:";
		nudDelayTo.Location = new Point(229, 108);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(132, 108);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new Point(194, 110);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 110);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		C62FC22F.AutoSize = true;
		C62FC22F.Location = new Point(27, 110);
		C62FC22F.Name = "label5";
		C62FC22F.Size = new Size(89, 16);
		C62FC22F.TabIndex = 34;
		C62FC22F.Text = "Thơ\u0300i gian chơ\u0300:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(190, 140);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		F43CFF34.BackColor = Color.FromArgb(53, 120, 229);
		F43CFF34.Cursor = Cursors.Hand;
		F43CFF34.FlatAppearance.BorderSize = 0;
		F43CFF34.FlatStyle = FlatStyle.Flat;
		F43CFF34.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F43CFF34.ForeColor = Color.White;
		F43CFF34.Location = new Point(83, 140);
		F43CFF34.Name = "btnAdd";
		F43CFF34.Size = new Size(92, 29);
		F43CFF34.TabIndex = 9;
		F43CFF34.Text = "Thêm";
		F43CFF34.UseVisualStyleBackColor = false;
		F43CFF34.Click += E7913095;
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
		base.ClientSize = new Size(362, 182);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXoaTinNhan";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += BAADEE80_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)C12D7C30).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
