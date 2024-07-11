using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanGoiY : Form
{
	private JSON_Settings F6B27735;

	private string string_0;

	private string CC830E07;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl FB21961D;

	private BunifuDragControl bunifuDragControl_0;

	private Panel E58C0185;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label C2A2C496;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button BB2F7990;

	private Button btnAdd;

	private BunifuCards C91108BA;

	private Panel pnlHeader;

	private Button B7A23E1C;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A0B18995;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label F530D630;

	private Label label6;

	private Label label5;

	private NumericUpDown nudTimesWarning;

	private Label F5AC9F15;

	private Label label8;

	private CheckBox ckbChiKetBanTenCoDau;

	private CheckBox ckbOnlyAddFriendWithMutualFriends;

	public fHDKetBanGoiY(string A09C1AA1, int D100BD89 = 0, string CC3AED23 = "")
	{
		FF039C08();
		bool_0 = false;
		string_0 = A09C1AA1;
		string_1 = CC3AED23;
		int_0 = D100BD89;
		string text = "";
		switch (D100BD89)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanGoiY");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			CC830E07 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(CC3AED23);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F6B27735 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void E021110C()
	{
		Language.smethod_0(A0B18995);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(C2A2C496);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(F530D630);
		Language.smethod_0(label6);
		Language.smethod_0(ckbChiKetBanTenCoDau);
		Language.smethod_0(ckbOnlyAddFriendWithMutualFriends);
		Language.smethod_0(label8);
		Language.smethod_0(F5AC9F15);
		Language.smethod_0(btnAdd);
		Language.smethod_0(BB2F7990);
	}

	private void A1A22499_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = F6B27735.GetValueInt("nudSoLuongFrom");
			nudSoLuongTo.Value = F6B27735.GetValueInt("nudSoLuongTo");
			nudDelayFrom.Value = F6B27735.GetValueInt("nudDelayFrom");
			nudDelayTo.Value = F6B27735.GetValueInt("nudDelayTo");
			ckbChiKetBanTenCoDau.Checked = F6B27735.GetValueBool("ckbChiKetBanTenCoDau");
			ckbOnlyAddFriendWithMutualFriends.Checked = F6B27735.GetValueBool("ckbOnlyAddFriendWithMutualFriends");
			nudTimesWarning.Value = F6B27735.GetValueInt("nudTimesWarning", 5);
		}
		catch
		{
		}
	}

	private void B7A23E1C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EA024E27(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbChiKetBanTenCoDau", ckbChiKetBanTenCoDau.Checked);
		gClass.GetJson("ckbOnlyAddFriendWithMutualFriends", ckbOnlyAddFriendWithMutualFriends.Checked);
		gClass.GetJson("nudTimesWarning", nudTimesWarning.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, CC830E07, string_))
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

	private void BB2F7990_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E58C0185_Paint(object sender, PaintEventArgs e)
	{
		if (E58C0185.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E58C0185.ClientSize.Width - num, E58C0185.ClientSize.Height - num));
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

	private void FF039C08()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDKetBanGoiY));
		FB21961D = new BunifuDragControl(icontainer_0);
		A0B18995 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		B7A23E1C = new Button();
		pictureBox1 = new PictureBox();
		E58C0185 = new Panel();
		ckbOnlyAddFriendWithMutualFriends = new CheckBox();
		ckbChiKetBanTenCoDau = new CheckBox();
		nudTimesWarning = new NumericUpDown();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		F5AC9F15 = new Label();
		F530D630 = new Label();
		label6 = new Label();
		label8 = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		C2A2C496 = new Label();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		BB2F7990 = new Button();
		btnAdd = new Button();
		C91108BA = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		E58C0185.SuspendLayout();
		((ISupportInitialize)nudTimesWarning).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		C91108BA.SuspendLayout();
		SuspendLayout();
		FB21961D.Fixed = true;
		FB21961D.Horizontal = true;
		FB21961D.TargetControl = A0B18995;
		FB21961D.Vertical = true;
		A0B18995.BackColor = Color.Transparent;
		A0B18995.Cursor = Cursors.SizeAll;
		A0B18995.Dock = DockStyle.Fill;
		A0B18995.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A0B18995.ForeColor = Color.Black;
		A0B18995.Location = new Point(0, 0);
		A0B18995.Name = "bunifuCustomLabel1";
		A0B18995.Size = new Size(359, 31);
		A0B18995.TabIndex = 12;
		A0B18995.Text = "Cấu hình Kết bạn gợi ý";
		A0B18995.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(B7A23E1C);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(A0B18995);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		B7A23E1C.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B7A23E1C.Cursor = Cursors.Hand;
		B7A23E1C.FlatAppearance.BorderSize = 0;
		B7A23E1C.FlatStyle = FlatStyle.Flat;
		B7A23E1C.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B7A23E1C.ForeColor = Color.White;
		B7A23E1C.Image = (Image)componentResourceManager.GetObject("button1.Image");
		B7A23E1C.Location = new Point(328, 1);
		B7A23E1C.Name = "button1";
		B7A23E1C.Size = new Size(30, 30);
		B7A23E1C.TabIndex = 77;
		B7A23E1C.TextImageRelation = TextImageRelation.ImageBeforeText;
		B7A23E1C.UseVisualStyleBackColor = true;
		B7A23E1C.Click += B7A23E1C_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		E58C0185.BackColor = Color.White;
		E58C0185.BorderStyle = BorderStyle.FixedSingle;
		E58C0185.Controls.Add(ckbOnlyAddFriendWithMutualFriends);
		E58C0185.Controls.Add(ckbChiKetBanTenCoDau);
		E58C0185.Controls.Add(nudTimesWarning);
		E58C0185.Controls.Add(nudDelayTo);
		E58C0185.Controls.Add(nudDelayFrom);
		E58C0185.Controls.Add(F5AC9F15);
		E58C0185.Controls.Add(F530D630);
		E58C0185.Controls.Add(label6);
		E58C0185.Controls.Add(label8);
		E58C0185.Controls.Add(label5);
		E58C0185.Controls.Add(nudSoLuongTo);
		E58C0185.Controls.Add(nudSoLuongFrom);
		E58C0185.Controls.Add(txtTenHanhDong);
		E58C0185.Controls.Add(C2A2C496);
		E58C0185.Controls.Add(label4);
		E58C0185.Controls.Add(label2);
		E58C0185.Controls.Add(label1);
		E58C0185.Controls.Add(BB2F7990);
		E58C0185.Controls.Add(btnAdd);
		E58C0185.Controls.Add(C91108BA);
		E58C0185.Cursor = Cursors.Arrow;
		E58C0185.Dock = DockStyle.Fill;
		E58C0185.Location = new Point(0, 0);
		E58C0185.Name = "panel1";
		E58C0185.Size = new Size(362, 266);
		E58C0185.TabIndex = 0;
		E58C0185.Paint += E58C0185_Paint;
		ckbOnlyAddFriendWithMutualFriends.AutoSize = true;
		ckbOnlyAddFriendWithMutualFriends.Cursor = Cursors.Hand;
		ckbOnlyAddFriendWithMutualFriends.Location = new Point(30, 162);
		ckbOnlyAddFriendWithMutualFriends.Name = "ckbOnlyAddFriendWithMutualFriends";
		ckbOnlyAddFriendWithMutualFriends.Size = new Size(226, 20);
		ckbOnlyAddFriendWithMutualFriends.TabIndex = 47;
		ckbOnlyAddFriendWithMutualFriends.Text = "Chỉ kết bạn với người có bạn chung";
		ckbOnlyAddFriendWithMutualFriends.UseVisualStyleBackColor = true;
		ckbChiKetBanTenCoDau.AutoSize = true;
		ckbChiKetBanTenCoDau.Cursor = Cursors.Hand;
		ckbChiKetBanTenCoDau.Location = new Point(30, 136);
		ckbChiKetBanTenCoDau.Name = "ckbChiKetBanTenCoDau";
		ckbChiKetBanTenCoDau.Size = new Size(211, 20);
		ckbChiKetBanTenCoDau.TabIndex = 47;
		ckbChiKetBanTenCoDau.Text = "Chỉ kết bạn với người có tên Việt";
		ckbChiKetBanTenCoDau.UseVisualStyleBackColor = true;
		nudTimesWarning.Location = new Point(253, 188);
		nudTimesWarning.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimesWarning.Name = "nudTimesWarning";
		nudTimesWarning.Size = new Size(43, 23);
		nudTimesWarning.TabIndex = 4;
		nudDelayTo.Location = new Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		F5AC9F15.AutoSize = true;
		F5AC9F15.Location = new Point(299, 190);
		F5AC9F15.Name = "label9";
		F5AC9F15.Size = new Size(24, 16);
		F5AC9F15.TabIndex = 45;
		F5AC9F15.Text = "lần";
		F530D630.Location = new Point(194, 109);
		F530D630.Name = "label7";
		F530D630.Size = new Size(29, 16);
		F530D630.TabIndex = 46;
		F530D630.Text = "đê\u0301n";
		F530D630.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 109);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label8.AutoSize = true;
		label8.Location = new Point(27, 190);
		label8.Name = "label8";
		label8.Size = new Size(225, 16);
		label8.TabIndex = 44;
		label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		label5.AutoSize = true;
		label5.Location = new Point(27, 109);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
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
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		C2A2C496.Location = new Point(194, 80);
		C2A2C496.Name = "label3";
		C2A2C496.Size = new Size(29, 16);
		C2A2C496.TabIndex = 37;
		C2A2C496.Text = "đê\u0301n";
		C2A2C496.TextAlign = ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new Point(287, 80);
		label4.Name = "label4";
		label4.Size = new Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(27, 80);
		label2.Name = "label2";
		label2.Size = new Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		BB2F7990.Anchor = AnchorStyles.Bottom;
		BB2F7990.BackColor = Color.Maroon;
		BB2F7990.Cursor = Cursors.Hand;
		BB2F7990.FlatAppearance.BorderSize = 0;
		BB2F7990.FlatStyle = FlatStyle.Flat;
		BB2F7990.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BB2F7990.ForeColor = Color.White;
		BB2F7990.Location = new Point(187, 222);
		BB2F7990.Name = "btnCancel";
		BB2F7990.Size = new Size(92, 29);
		BB2F7990.TabIndex = 7;
		BB2F7990.Text = "Đóng";
		BB2F7990.UseVisualStyleBackColor = false;
		BB2F7990.Click += BB2F7990_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(80, 222);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += EA024E27;
		C91108BA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C91108BA.BackColor = Color.White;
		C91108BA.BorderRadius = 0;
		C91108BA.BottomSahddow = true;
		C91108BA.color = Color.DarkViolet;
		C91108BA.Controls.Add(pnlHeader);
		C91108BA.LeftSahddow = false;
		C91108BA.Location = new Point(1, 0);
		C91108BA.Name = "bunifuCards1";
		C91108BA.RightSahddow = true;
		C91108BA.ShadowDepth = 20;
		C91108BA.Size = new Size(359, 37);
		C91108BA.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 266);
		base.Controls.Add(E58C0185);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanGoiY";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += A1A22499_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		E58C0185.ResumeLayout(performLayout: false);
		E58C0185.PerformLayout();
		((ISupportInitialize)nudTimesWarning).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		C91108BA.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
