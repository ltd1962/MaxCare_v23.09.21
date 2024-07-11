using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDLinkToInstagram : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string string_1;

	private string A93611A9;

	private int int_0;

	public static bool AD9B5B1F;

	private IContainer F2240914 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button F42969AB;

	private Button FD16D104;

	private BunifuCards BC3B858C;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A99938A2;

	private Button button1;

	private TextBox CDB4FD31;

	private Label label5;

	private RadioButton EBB054B1;

	private RadioButton rbPassRandom;

	private Label B1152895;

	private CheckBox ckbFollow;

	private TextBox txtPathFileSaveAcc;

	private Panel B232B823;

	private TextBox txtPathImage;

	private Label F5182402;

	private CheckBox ckbUpAvatar;

	private Panel panel2;

	private NumericUpDown F500A89E;

	private NumericUpDown BD14C202;

	private Label label4;

	private Label label3;

	private RichTextBox txtBio;

	private CheckBox FE206D2C;

	private Panel panel4;

	private Label BD177EBB;

	public fHDLinkToInstagram(string string_2, int ADA11506 = 0, string string_3 = "")
	{
		AFA6232C();
		AD9B5B1F = false;
		string_0 = string_2;
		A93611A9 = string_3;
		int_0 = ADA11506;
		if (InteractSQL.B484648C("", "HDLinkToInstagram").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDLinkToInstagram', 'Liên kết Instagram');");
		}
		string text = "";
		switch (ADA11506)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDLinkToInstagram");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			FD16D104.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(A99938A2);
		Language.smethod_0(label1);
		Language.smethod_0(B1152895);
		Language.smethod_0(F5182402);
		Language.smethod_0(label4);
		Language.smethod_0(label3);
		Language.smethod_0(FD16D104);
		Language.smethod_0(F42969AB);
	}

	private void DB098F96(object sender, EventArgs e)
	{
		try
		{
			if (gclass8_0.GetValueInt("typePass") == 0)
			{
				rbPassRandom.Checked = true;
			}
			else
			{
				EBB054B1.Checked = true;
			}
			CDB4FD31.Text = gclass8_0.GetValue("txtPassword");
			txtPathFileSaveAcc.Text = FileHelper.GetPathToCurrentFolder() + "\\accountIG.txt";
			ckbUpAvatar.Checked = gclass8_0.GetValueBool("ckbUpAvatar");
			txtPathImage.Text = gclass8_0.GetValue("txtPathImage");
			ckbFollow.Checked = gclass8_0.GetValueBool("ckbFollow");
			F500A89E.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			BD14C202.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			FE206D2C.Checked = gclass8_0.GetValueBool("ckbBio");
			txtBio.Text = gclass8_0.GetValue("txtBio");
		}
		catch
		{
		}
		EBB054B1_CheckedChanged(null, null);
		EB96B9B0(null, null);
		A30F91B8(null, null);
		FE206D2C_CheckedChanged(null, null);
		txtBio_TextChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FD16D104_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		int num = 0;
		if (EBB054B1.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typePass", num);
		gClass.GetJson("txtPassword", CDB4FD31.Text.Trim());
		gClass.GetJson("ckbUpAvatar", ckbUpAvatar.Checked);
		gClass.GetJson("txtPathImage", txtPathImage.Text.Trim());
		gClass.GetJson("ckbFollow", ckbFollow.Checked);
		gClass.GetJson("nudSoLuongFrom", F500A89E.Value);
		gClass.GetJson("nudSoLuongTo", BD14C202.Value);
		gClass.GetJson("ckbBio", FE206D2C.Checked);
		gClass.GetJson("txtBio", txtBio.Text);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					AD9B5B1F = true;
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
			if (InteractSQL.smethod_13(A93611A9, text, string_))
			{
				AD9B5B1F = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F42969AB_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B90EFA34(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void EBB054B1_CheckedChanged(object sender, EventArgs e)
	{
		CDB4FD31.Enabled = EBB054B1.Checked;
	}

	private void txtPathFileSaveAcc_TextChanged(object sender, EventArgs e)
	{
	}

	private void EB96B9B0(object sender, EventArgs e)
	{
		B232B823.Enabled = ckbUpAvatar.Checked;
	}

	private void A30F91B8(object sender, EventArgs e)
	{
		panel2.Enabled = ckbFollow.Checked;
	}

	private void FE206D2C_CheckedChanged(object sender, EventArgs e)
	{
		panel4.Enabled = FE206D2C.Checked;
	}

	private void txtBio_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = txtBio.Lines.ToList();
			list = Common.RemoveEmptyItems(list);
			BD177EBB.Text = string.Format(Language.GetValue("Danh sách Bio ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F2240914 != null)
		{
			F2240914.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void AFA6232C()
	{
		F2240914 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(F2240914);
		A99938A2 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(F2240914);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		B232B823 = new Panel();
		txtPathImage = new TextBox();
		F5182402 = new Label();
		ckbUpAvatar = new CheckBox();
		panel2 = new Panel();
		F500A89E = new NumericUpDown();
		BD14C202 = new NumericUpDown();
		label4 = new Label();
		label3 = new Label();
		ckbFollow = new CheckBox();
		label5 = new Label();
		EBB054B1 = new RadioButton();
		rbPassRandom = new RadioButton();
		CDB4FD31 = new TextBox();
		B1152895 = new Label();
		txtPathFileSaveAcc = new TextBox();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		F42969AB = new Button();
		FD16D104 = new Button();
		BC3B858C = new BunifuCards();
		FE206D2C = new CheckBox();
		txtBio = new RichTextBox();
		panel4 = new Panel();
		BD177EBB = new Label();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		B232B823.SuspendLayout();
		panel2.SuspendLayout();
		((ISupportInitialize)F500A89E).BeginInit();
		((ISupportInitialize)BD14C202).BeginInit();
		BC3B858C.SuspendLayout();
		panel4.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = A99938A2;
		bunifuDragControl_0.Vertical = true;
		A99938A2.BackColor = Color.Transparent;
		A99938A2.Cursor = Cursors.SizeAll;
		A99938A2.Dock = DockStyle.Fill;
		A99938A2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A99938A2.ForeColor = Color.Black;
		A99938A2.Location = new Point(0, 0);
		A99938A2.Name = "bunifuCustomLabel1";
		A99938A2.Size = new Size(394, 31);
		A99938A2.TabIndex = 12;
		A99938A2.Text = "Cấu hình Liên kết Instagram";
		A99938A2.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(A99938A2);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(394, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = Resources.C400940B;
		button1.Location = new Point(363, 1);
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
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(panel4);
		panel1.Controls.Add(FE206D2C);
		panel1.Controls.Add(B232B823);
		panel1.Controls.Add(ckbUpAvatar);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(ckbFollow);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(EBB054B1);
		panel1.Controls.Add(rbPassRandom);
		panel1.Controls.Add(CDB4FD31);
		panel1.Controls.Add(B1152895);
		panel1.Controls.Add(txtPathFileSaveAcc);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(F42969AB);
		panel1.Controls.Add(FD16D104);
		panel1.Controls.Add(BC3B858C);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(397, 443);
		panel1.TabIndex = 0;
		panel1.Paint += B90EFA34;
		B232B823.Controls.Add(txtPathImage);
		B232B823.Controls.Add(F5182402);
		B232B823.Location = new Point(145, 156);
		B232B823.Name = "panel3";
		B232B823.Size = new Size(231, 27);
		B232B823.TabIndex = 47;
		txtPathImage.Location = new Point(97, 2);
		txtPathImage.Name = "txtPathImage";
		txtPathImage.Size = new Size(131, 23);
		txtPathImage.TabIndex = 0;
		F5182402.AutoSize = true;
		F5182402.Location = new Point(3, 5);
		F5182402.Name = "label2";
		F5182402.Size = new Size(88, 16);
		F5182402.TabIndex = 41;
		F5182402.Text = "Thư mục ảnh:";
		ckbUpAvatar.AutoSize = true;
		ckbUpAvatar.Location = new Point(31, 159);
		ckbUpAvatar.Name = "ckbUpAvatar";
		ckbUpAvatar.Size = new Size(87, 20);
		ckbUpAvatar.TabIndex = 42;
		ckbUpAvatar.Text = "Up Avatar:";
		ckbUpAvatar.UseVisualStyleBackColor = true;
		ckbUpAvatar.CheckedChanged += EB96B9B0;
		panel2.Controls.Add(F500A89E);
		panel2.Controls.Add(BD14C202);
		panel2.Controls.Add(label4);
		panel2.Controls.Add(label3);
		panel2.Location = new Point(145, 186);
		panel2.Name = "panel2";
		panel2.Size = new Size(200, 27);
		panel2.TabIndex = 47;
		F500A89E.Location = new Point(1, 2);
		F500A89E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F500A89E.Name = "nudSoLuongFrom";
		F500A89E.Size = new Size(56, 23);
		F500A89E.TabIndex = 43;
		BD14C202.Location = new Point(97, 2);
		BD14C202.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BD14C202.Name = "nudSoLuongTo";
		BD14C202.Size = new Size(56, 23);
		BD14C202.TabIndex = 44;
		label4.AutoSize = true;
		label4.Location = new Point(155, 4);
		label4.Name = "label4";
		label4.Size = new Size(39, 16);
		label4.TabIndex = 45;
		label4.Text = "người";
		label3.Location = new Point(62, 4);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 46;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		ckbFollow.AutoSize = true;
		ckbFollow.Location = new Point(31, 189);
		ckbFollow.Name = "ckbFollow";
		ckbFollow.Size = new Size(99, 20);
		ckbFollow.TabIndex = 42;
		ckbFollow.Text = "Follow gợi ý:";
		ckbFollow.UseVisualStyleBackColor = true;
		ckbFollow.CheckedChanged += A30F91B8;
		label5.AutoSize = true;
		label5.Location = new Point(28, 131);
		label5.Name = "label5";
		label5.Size = new Size(110, 16);
		label5.TabIndex = 41;
		label5.Text = "File lưu tài khoản:";
		EBB054B1.AutoSize = true;
		EBB054B1.Location = new Point(145, 100);
		EBB054B1.Name = "rbPassTuNhap";
		EBB054B1.Size = new Size(78, 20);
		EBB054B1.TabIndex = 40;
		EBB054B1.Text = "Tự nhập:";
		EBB054B1.UseVisualStyleBackColor = true;
		EBB054B1.CheckedChanged += EBB054B1_CheckedChanged;
		rbPassRandom.AutoSize = true;
		rbPassRandom.Checked = true;
		rbPassRandom.Location = new Point(145, 76);
		rbPassRandom.Name = "rbPassRandom";
		rbPassRandom.Size = new Size(89, 20);
		rbPassRandom.TabIndex = 39;
		rbPassRandom.TabStop = true;
		rbPassRandom.Text = "Ngẫu nhiên";
		rbPassRandom.UseVisualStyleBackColor = true;
		CDB4FD31.Location = new Point(230, 99);
		CDB4FD31.Name = "txtPassword";
		CDB4FD31.Size = new Size(146, 23);
		CDB4FD31.TabIndex = 38;
		B1152895.AutoSize = true;
		B1152895.Location = new Point(28, 75);
		B1152895.Name = "lblStatus";
		B1152895.Size = new Size(64, 16);
		B1152895.TabIndex = 0;
		B1152895.Text = "Mật khẩu:";
		txtPathFileSaveAcc.Location = new Point(145, 128);
		txtPathFileSaveAcc.Name = "txtPathFileSaveAcc";
		txtPathFileSaveAcc.ReadOnly = true;
		txtPathFileSaveAcc.Size = new Size(231, 23);
		txtPathFileSaveAcc.TabIndex = 0;
		txtPathFileSaveAcc.TextChanged += txtPathFileSaveAcc_TextChanged;
		txtTenHanhDong.Location = new Point(145, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(231, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		F42969AB.Anchor = AnchorStyles.Bottom;
		F42969AB.BackColor = Color.Maroon;
		F42969AB.Cursor = Cursors.Hand;
		F42969AB.FlatAppearance.BorderSize = 0;
		F42969AB.FlatStyle = FlatStyle.Flat;
		F42969AB.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F42969AB.ForeColor = Color.White;
		F42969AB.Location = new Point(210, 402);
		F42969AB.Name = "btnCancel";
		F42969AB.Size = new Size(92, 29);
		F42969AB.TabIndex = 10;
		F42969AB.Text = "Đóng";
		F42969AB.UseVisualStyleBackColor = false;
		F42969AB.Click += F42969AB_Click;
		FD16D104.Anchor = AnchorStyles.Bottom;
		FD16D104.BackColor = Color.FromArgb(53, 120, 229);
		FD16D104.Cursor = Cursors.Hand;
		FD16D104.FlatAppearance.BorderSize = 0;
		FD16D104.FlatStyle = FlatStyle.Flat;
		FD16D104.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		FD16D104.ForeColor = Color.White;
		FD16D104.Location = new Point(103, 402);
		FD16D104.Name = "btnAdd";
		FD16D104.Size = new Size(92, 29);
		FD16D104.TabIndex = 9;
		FD16D104.Text = "Thêm";
		FD16D104.UseVisualStyleBackColor = false;
		FD16D104.Click += FD16D104_Click;
		BC3B858C.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		BC3B858C.BackColor = Color.White;
		BC3B858C.BorderRadius = 0;
		BC3B858C.BottomSahddow = true;
		BC3B858C.color = Color.DarkViolet;
		BC3B858C.Controls.Add(pnlHeader);
		BC3B858C.LeftSahddow = false;
		BC3B858C.Location = new Point(1, 0);
		BC3B858C.Name = "bunifuCards1";
		BC3B858C.RightSahddow = true;
		BC3B858C.ShadowDepth = 20;
		BC3B858C.Size = new Size(394, 37);
		BC3B858C.TabIndex = 28;
		FE206D2C.AutoSize = true;
		FE206D2C.Location = new Point(31, 224);
		FE206D2C.Name = "ckbBio";
		FE206D2C.Size = new Size(85, 20);
		FE206D2C.TabIndex = 48;
		FE206D2C.Text = "Thêm bio:";
		FE206D2C.UseVisualStyleBackColor = true;
		FE206D2C.CheckedChanged += FE206D2C_CheckedChanged;
		txtBio.Location = new Point(11, 29);
		txtBio.Name = "txtBio";
		txtBio.Size = new Size(317, 111);
		txtBio.TabIndex = 49;
		txtBio.Text = "";
		txtBio.TextChanged += txtBio_TextChanged;
		panel4.BorderStyle = BorderStyle.FixedSingle;
		panel4.Controls.Add(BD177EBB);
		panel4.Controls.Add(txtBio);
		panel4.Location = new Point(55, 251);
		panel4.Name = "panel4";
		panel4.Size = new Size(337, 145);
		panel4.TabIndex = 50;
		BD177EBB.AutoSize = true;
		BD177EBB.Location = new Point(11, 7);
		BD177EBB.Name = "label6";
		BD177EBB.Size = new Size(113, 16);
		BD177EBB.TabIndex = 50;
		BD177EBB.Text = "Danh sách bio (0):";
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(397, 443);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDLinkToInstagram";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += DB098F96;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		B232B823.ResumeLayout(performLayout: false);
		B232B823.PerformLayout();
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		((ISupportInitialize)F500A89E).EndInit();
		((ISupportInitialize)BD14C202).EndInit();
		BC3B858C.ResumeLayout(performLayout: false);
		panel4.ResumeLayout(performLayout: false);
		panel4.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
