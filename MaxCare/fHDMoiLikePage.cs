using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDMoiLikePage : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string D42ED400;

	private string string_1;

	private int int_0;

	public static bool A5877313;

	private IContainer D83831BD = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B99C0C06;

	private Panel AA156927;

	private PictureBox pictureBox1;

	private BunifuCustomLabel DF932E15;

	private Label A6B9033D;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label13;

	private Label label11;

	private Label label9;

	private NumericUpDown D3A35A33;

	private Label CCA22BAD;

	private Label B58507B6;

	private Label label4;

	private NumericUpDown nudDelayFrom;

	private Button B02FBC81;

	private TextBox txtIdPage;

	public fHDMoiLikePage(string FA956012, int int_1 = 0, string E10D5623 = "")
	{
		B0B8F105();
		A5877313 = false;
		string_0 = FA956012;
		string_1 = E10D5623;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDMoiLikePage").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDMoiLikePage', 'Mời like Page');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDMoiLikePage");
			D42ED400 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E10D5623);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(DF932E15);
		Language.smethod_0(label1);
		Language.smethod_0(A6B9033D);
		Language.smethod_0(label9);
		Language.smethod_0(label13);
		Language.smethod_0(label11);
		Language.smethod_0(CCA22BAD);
		Language.smethod_0(label4);
		Language.smethod_0(B58507B6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void A83A5F03_Load(object sender, EventArgs e)
	{
		try
		{
			txtIdPage.Text = gclass8_0.GetValue("txtIdPage");
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 30);
			D3A35A33.Value = gclass8_0.GetValueInt("nudDelayTo", 30);
		}
		catch
		{
		}
	}

	private void D7956C9F(object sender, EventArgs e)
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
		gClass.GetJson("txtIdPage", txtIdPage.Text.Trim());
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", D3A35A33.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, D42ED400, string_))
				{
					A5877313 = true;
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
				A5877313 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void E30823A9(object sender, EventArgs e)
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

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && D83831BD != null)
		{
			D83831BD.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void B0B8F105()
	{
		D83831BD = new Container();
		bunifuDragControl_0 = new BunifuDragControl(D83831BD);
		DF932E15 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(D83831BD);
		AA156927 = new Panel();
		B02FBC81 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		D3A35A33 = new NumericUpDown();
		CCA22BAD = new Label();
		B58507B6 = new Label();
		label4 = new Label();
		nudDelayFrom = new NumericUpDown();
		A6B9033D = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label13 = new Label();
		label11 = new Label();
		label9 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		B99C0C06 = new BunifuCards();
		txtIdPage = new TextBox();
		AA156927.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)D3A35A33).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		B99C0C06.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DF932E15;
		bunifuDragControl_0.Vertical = true;
		DF932E15.BackColor = Color.Transparent;
		DF932E15.Cursor = Cursors.SizeAll;
		DF932E15.Dock = DockStyle.Fill;
		DF932E15.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DF932E15.ForeColor = Color.Black;
		DF932E15.Location = new Point(0, 0);
		DF932E15.Name = "bunifuCustomLabel1";
		DF932E15.Size = new Size(359, 31);
		DF932E15.TabIndex = 12;
		DF932E15.Text = "Cấu hình Mời like Page";
		DF932E15.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = AA156927;
		bunifuDragControl_1.Vertical = true;
		AA156927.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		AA156927.BackColor = Color.White;
		AA156927.Controls.Add(B02FBC81);
		AA156927.Controls.Add(pictureBox1);
		AA156927.Controls.Add(DF932E15);
		AA156927.Cursor = Cursors.SizeAll;
		AA156927.Location = new Point(0, 3);
		AA156927.Name = "pnlHeader";
		AA156927.Size = new Size(359, 31);
		AA156927.TabIndex = 9;
		B02FBC81.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B02FBC81.Cursor = Cursors.Hand;
		B02FBC81.FlatAppearance.BorderSize = 0;
		B02FBC81.FlatStyle = FlatStyle.Flat;
		B02FBC81.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B02FBC81.ForeColor = Color.White;
		B02FBC81.Image = Resources.C400940B;
		B02FBC81.Location = new Point(328, 1);
		B02FBC81.Name = "button1";
		B02FBC81.Size = new Size(30, 30);
		B02FBC81.TabIndex = 77;
		B02FBC81.TextImageRelation = TextImageRelation.ImageBeforeText;
		B02FBC81.UseVisualStyleBackColor = true;
		B02FBC81.Click += D7956C9F;
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
		panel1.Controls.Add(txtIdPage);
		panel1.Controls.Add(D3A35A33);
		panel1.Controls.Add(CCA22BAD);
		panel1.Controls.Add(B58507B6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(A6B9033D);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label13);
		panel1.Controls.Add(label11);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B99C0C06);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 222);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		D3A35A33.Location = new Point(205, 136);
		D3A35A33.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D3A35A33.Name = "nudDelayTo";
		D3A35A33.Size = new Size(36, 23);
		D3A35A33.TabIndex = 2;
		CCA22BAD.AutoSize = true;
		CCA22BAD.Location = new Point(28, 138);
		CCA22BAD.Name = "label2";
		CCA22BAD.Size = new Size(100, 16);
		CCA22BAD.TabIndex = 32;
		CCA22BAD.Text = "Thời gian delay:";
		B58507B6.AutoSize = true;
		B58507B6.Location = new Point(247, 138);
		B58507B6.Name = "label3";
		B58507B6.Size = new Size(31, 16);
		B58507B6.TabIndex = 35;
		B58507B6.Text = "giây";
		label4.Location = new Point(173, 138);
		label4.Name = "label4";
		label4.Size = new Size(29, 16);
		label4.TabIndex = 37;
		label4.Text = "đê\u0301n";
		label4.TextAlign = ContentAlignment.MiddleCenter;
		nudDelayFrom.Location = new Point(134, 136);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(36, 23);
		nudDelayFrom.TabIndex = 1;
		A6B9033D.AutoSize = true;
		A6B9033D.Location = new Point(28, 78);
		A6B9033D.Name = "lblStatus";
		A6B9033D.Size = new Size(90, 16);
		A6B9033D.TabIndex = 0;
		A6B9033D.Text = "Nhập ID Page:";
		nudSoLuongTo.Location = new Point(205, 107);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(36, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(134, 107);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(36, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label13.Location = new Point(173, 109);
		label13.Name = "label13";
		label13.Size = new Size(29, 16);
		label13.TabIndex = 37;
		label13.Text = "đê\u0301n";
		label13.TextAlign = ContentAlignment.MiddleCenter;
		label11.AutoSize = true;
		label11.Location = new Point(247, 109);
		label11.Name = "label11";
		label11.Size = new Size(40, 16);
		label11.TabIndex = 35;
		label11.Text = "người";
		label9.AutoSize = true;
		label9.Location = new Point(27, 109);
		label9.Name = "label9";
		label9.Size = new Size(102, 16);
		label9.TabIndex = 32;
		label9.Text = "Sô\u0301 bạn cần mời:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(193, 181);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += E30823A9;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(86, 181);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		B99C0C06.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B99C0C06.BackColor = Color.White;
		B99C0C06.BorderRadius = 0;
		B99C0C06.BottomSahddow = true;
		B99C0C06.color = Color.DarkViolet;
		B99C0C06.Controls.Add(AA156927);
		B99C0C06.LeftSahddow = false;
		B99C0C06.Location = new Point(1, 0);
		B99C0C06.Name = "bunifuCards1";
		B99C0C06.RightSahddow = true;
		B99C0C06.ShadowDepth = 20;
		B99C0C06.Size = new Size(359, 37);
		B99C0C06.TabIndex = 28;
		txtIdPage.Location = new Point(134, 78);
		txtIdPage.Name = "txtIdPage";
		txtIdPage.Size = new Size(194, 23);
		txtIdPage.TabIndex = 38;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 222);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDMoiLikePage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += A83A5F03_Load;
		AA156927.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)D3A35A33).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		B99C0C06.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
