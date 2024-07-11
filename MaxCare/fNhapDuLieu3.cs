using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu3 : Form
{
	private string string_0 = "";

	private string string_1 = "";

	public string FA0375B6 = "";

	public int FAA1F037 = 0;

	private IContainer icontainer_0 = null;

	private BunifuCards CA993438;

	private Panel FF2409A8;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button BA8C55BA;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel C8A82E15;

	private Label F8AC5A3A;

	private Button C826BD10;

	private Button btnAdd;

	private Label lblFooter;

	private RichTextBox txtComment;

	private Button CCAEC3BE;

	private Button button1;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	public fNhapDuLieu3(string EB9FE43C, string string_2 = "Nhập danh sách Uid cần clone", string string_3 = "Danh sách Uid", string string_4 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> E3A2983A = null)
	{
		EF096CA8();
		Common.CreateFile(EB9FE43C);
		string_0 = EB9FE43C;
		string_1 = string_3;
		C8A82E15.Text = string_2;
		F8AC5A3A.Text = string_3 + " (0):";
		lblFooter.Text = string_4;
		if (E3A2983A != null)
		{
			File.WriteAllLines(EB9FE43C, E3A2983A);
			txtComment.Lines = E3A2983A.ToArray();
		}
		else
		{
			txtComment.Lines = File.ReadAllLines(EB9FE43C);
		}
		C7ACD70A(null, null);
		Language.SetLanguage(this);
	}

	public fNhapDuLieu3(string string_2, int int_0, string string_3 = "Nhập danh sách Uid cần clone", string string_4 = "Danh sách Uid", string string_5 = "(Spin nội dung {a|b|c})")
	{
		EF096CA8();
		FA0375B6 = string_2;
		FAA1F037 = int_0;
		string_1 = string_4;
		C8A82E15.Text = string_3;
		F8AC5A3A.Text = string_4 + " (0):";
		lblFooter.Text = string_5;
		Language.SetLanguage(this);
	}

	private void B0901420_Load(object sender, EventArgs e)
	{
		if (FAA1F037 == 0)
		{
			rbNganCachMoiDong.Checked = true;
		}
		else
		{
			rbNganCachKyTu.Checked = true;
		}
		if (string_0 != "")
		{
			txtComment.Lines = File.ReadAllLines(string_0);
		}
		else
		{
			txtComment.Text = FA0375B6;
		}
	}

	private void FF2409A8_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BA8C55BA_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CEB62308(object sender, EventArgs e)
	{
		try
		{
			if (string_0 != "")
			{
				File.WriteAllText(string_0, txtComment.Text.Trim());
			}
			else
			{
				FA0375B6 = txtComment.Text;
				FAA1F037 = ((!rbNganCachMoiDong.Checked) ? 1 : 0);
			}
			if (MessageBoxHelper.ShowMessages("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		catch
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void C826BD10_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C7ACD70A(object sender, EventArgs e)
	{
		int int_ = ((!rbNganCachMoiDong.Checked) ? 1 : 0);
		Common.F9202C12(txtComment, F8AC5A3A, int_);
	}

	private void DD8D103F(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void B0309A00(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
	}

	private void E790620C(object sender, EventArgs e)
	{
		C7ACD70A(null, null);
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		C7ACD70A(null, null);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void EF096CA8()
	{
		icontainer_0 = new Container();
		CA993438 = new BunifuCards();
		FF2409A8 = new Panel();
		CCAEC3BE = new Button();
		button1 = new Button();
		rbNganCachKyTu = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		label9 = new Label();
		txtComment = new RichTextBox();
		lblFooter = new Label();
		F8AC5A3A = new Label();
		C826BD10 = new Button();
		btnAdd = new Button();
		bunifuCards2 = new BunifuCards();
		pnlHeader = new Panel();
		BA8C55BA = new Button();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		C8A82E15 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		toolTip_0 = new ToolTip(icontainer_0);
		FF2409A8.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		CA993438.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		CA993438.BackColor = Color.White;
		CA993438.BorderRadius = 5;
		CA993438.BottomSahddow = true;
		CA993438.color = Color.SaddleBrown;
		CA993438.LeftSahddow = false;
		CA993438.Location = new Point(0, 0);
		CA993438.Margin = new Padding(3, 4, 3, 4);
		CA993438.Name = "bunifuCards1";
		CA993438.RightSahddow = true;
		CA993438.ShadowDepth = 20;
		CA993438.Size = new Size(234, 47);
		CA993438.TabIndex = 12;
		FF2409A8.BackColor = Color.White;
		FF2409A8.BorderStyle = BorderStyle.FixedSingle;
		FF2409A8.Controls.Add(CCAEC3BE);
		FF2409A8.Controls.Add(button1);
		FF2409A8.Controls.Add(rbNganCachKyTu);
		FF2409A8.Controls.Add(rbNganCachMoiDong);
		FF2409A8.Controls.Add(label9);
		FF2409A8.Controls.Add(txtComment);
		FF2409A8.Controls.Add(lblFooter);
		FF2409A8.Controls.Add(F8AC5A3A);
		FF2409A8.Controls.Add(C826BD10);
		FF2409A8.Controls.Add(btnAdd);
		FF2409A8.Controls.Add(bunifuCards2);
		FF2409A8.Dock = DockStyle.Fill;
		FF2409A8.Location = new Point(0, 0);
		FF2409A8.Margin = new Padding(3, 4, 3, 4);
		FF2409A8.Name = "panel1";
		FF2409A8.Size = new Size(563, 355);
		FF2409A8.TabIndex = 37;
		FF2409A8.Paint += FF2409A8_Paint;
		CCAEC3BE.Cursor = Cursors.Help;
		CCAEC3BE.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CCAEC3BE.Location = new Point(237, 274);
		CCAEC3BE.Name = "button3";
		CCAEC3BE.Size = new Size(21, 23);
		CCAEC3BE.TabIndex = 198;
		CCAEC3BE.Text = "?";
		CCAEC3BE.UseVisualStyleBackColor = true;
		CCAEC3BE.Click += B0309A00;
		button1.Cursor = Cursors.Help;
		button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button1.Location = new Point(237, 251);
		button1.Name = "button1";
		button1.Size = new Size(21, 23);
		button1.TabIndex = 199;
		button1.Text = "?";
		button1.UseVisualStyleBackColor = true;
		button1.Click += DD8D103F;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = Cursors.Hand;
		rbNganCachKyTu.Location = new Point(78, 275);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new Size(159, 20);
		rbNganCachKyTu.TabIndex = 197;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += rbNganCachKyTu_CheckedChanged;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(78, 253);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(155, 20);
		rbNganCachMoiDong.TabIndex = 196;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += E790620C;
		label9.AutoSize = true;
		label9.Location = new Point(13, 253);
		label9.Name = "label9";
		label9.Size = new Size(64, 16);
		label9.TabIndex = 195;
		label9.Text = "Tùy chọn:";
		txtComment.Location = new Point(16, 64);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(528, 186);
		txtComment.TabIndex = 50;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += C7ACD70A;
		lblFooter.AutoSize = true;
		lblFooter.Location = new Point(404, 253);
		lblFooter.Name = "lblFooter";
		lblFooter.Size = new Size(143, 16);
		lblFooter.TabIndex = 49;
		lblFooter.Text = "(Spin nội dung {a|b|c})";
		F8AC5A3A.AutoSize = true;
		F8AC5A3A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		F8AC5A3A.Location = new Point(13, 45);
		F8AC5A3A.Name = "lblStatus";
		F8AC5A3A.Size = new Size(139, 16);
		F8AC5A3A.TabIndex = 47;
		F8AC5A3A.Text = "Nội dung bình luận (0):";
		C826BD10.Anchor = AnchorStyles.Bottom;
		C826BD10.BackColor = Color.Maroon;
		C826BD10.Cursor = Cursors.Hand;
		C826BD10.FlatAppearance.BorderSize = 0;
		C826BD10.FlatStyle = FlatStyle.Flat;
		C826BD10.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C826BD10.ForeColor = Color.White;
		C826BD10.Location = new Point(287, 313);
		C826BD10.Name = "btnCancel";
		C826BD10.Size = new Size(92, 29);
		C826BD10.TabIndex = 46;
		C826BD10.Text = "Đóng";
		C826BD10.UseVisualStyleBackColor = false;
		C826BD10.Click += C826BD10_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(183, 313);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += CEB62308;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(561, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(BA8C55BA);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(C8A82E15);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(561, 31);
		pnlHeader.TabIndex = 9;
		BA8C55BA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		BA8C55BA.Cursor = Cursors.Hand;
		BA8C55BA.FlatAppearance.BorderSize = 0;
		BA8C55BA.FlatStyle = FlatStyle.Flat;
		BA8C55BA.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BA8C55BA.ForeColor = Color.White;
		BA8C55BA.Image = Resources.C400940B;
		BA8C55BA.Location = new Point(530, 1);
		BA8C55BA.Name = "button2";
		BA8C55BA.Size = new Size(30, 30);
		BA8C55BA.TabIndex = 77;
		BA8C55BA.TextImageRelation = TextImageRelation.ImageBeforeText;
		BA8C55BA.UseVisualStyleBackColor = true;
		BA8C55BA.Click += BA8C55BA_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Location = new Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		C8A82E15.BackColor = Color.Transparent;
		C8A82E15.Cursor = Cursors.SizeAll;
		C8A82E15.Dock = DockStyle.Fill;
		C8A82E15.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C8A82E15.ForeColor = Color.Black;
		C8A82E15.Location = new Point(0, 0);
		C8A82E15.Name = "lblTitle";
		C8A82E15.Size = new Size(561, 31);
		C8A82E15.TabIndex = 12;
		C8A82E15.Text = "Nhập nội dung comment";
		C8A82E15.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C8A82E15;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(563, 355);
		base.Controls.Add(FF2409A8);
		base.Controls.Add(CA993438);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu3";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += B0901420_Load;
		FF2409A8.ResumeLayout(performLayout: false);
		FF2409A8.PerformLayout();
		bunifuCards2.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
