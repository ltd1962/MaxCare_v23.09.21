using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapMailAdd : Form
{
	private string string_0 = "configschange\\addmail\\hotmail.txt";

	private string string_1 = "";

	private IContainer ABAD6593 = null;

	private BunifuCards bunifuCards1;

	private Panel E99E0925;

	private BunifuDragControl D387A4A3;

	private ToolTip DBA2BC04;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button B5AAC496;

	private BunifuCustomLabel lblTitle;

	private Label F61EEC05;

	private Button btnCancel;

	private Button btnAdd;

	private Label B8A5E526;

	private RichTextBox txtComment;

	private Label label3;

	private Label label4;

	private Label E18D3616;

	private Label label1;

	public fNhapMailAdd()
	{
		B6805915();
		Language.SetLanguage(this);
		Common.CreateFile(string_0);
	}

	private void method_0()
	{
		Language.smethod_0(lblTitle);
		Language.smethod_0(F61EEC05);
		Language.smethod_0(B8A5E526);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void D681BE0F(object sender, EventArgs e)
	{
		Close();
	}

	private void E6B767BD_Load(object sender, EventArgs e)
	{
		txtComment.Lines = File.ReadAllLines(string_0);
	}

	private void A59B8927(object sender, EventArgs e)
	{
	}

	private void E99E0925_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			File.WriteAllText(string_0, txtComment.Text.Trim());
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			F61EEC05.Text = "Danh sách Email (" + a2AB53A.Count + "):";
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && ABAD6593 != null)
		{
			ABAD6593.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void B6805915()
	{
		ABAD6593 = new Container();
		bunifuCards1 = new BunifuCards();
		E99E0925 = new Panel();
		txtComment = new RichTextBox();
		B8A5E526 = new Label();
		F61EEC05 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards2 = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		B5AAC496 = new Button();
		lblTitle = new BunifuCustomLabel();
		D387A4A3 = new BunifuDragControl(ABAD6593);
		DBA2BC04 = new ToolTip(ABAD6593);
		label1 = new Label();
		E18D3616 = new Label();
		label3 = new Label();
		label4 = new Label();
		E99E0925.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Margin = new Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(234, 47);
		bunifuCards1.TabIndex = 12;
		E99E0925.BackColor = Color.White;
		E99E0925.BorderStyle = BorderStyle.FixedSingle;
		E99E0925.Controls.Add(label3);
		E99E0925.Controls.Add(label4);
		E99E0925.Controls.Add(E18D3616);
		E99E0925.Controls.Add(txtComment);
		E99E0925.Controls.Add(B8A5E526);
		E99E0925.Controls.Add(label1);
		E99E0925.Controls.Add(F61EEC05);
		E99E0925.Controls.Add(btnCancel);
		E99E0925.Controls.Add(btnAdd);
		E99E0925.Controls.Add(bunifuCards2);
		E99E0925.Dock = DockStyle.Fill;
		E99E0925.Location = new Point(0, 0);
		E99E0925.Margin = new Padding(3, 4, 3, 4);
		E99E0925.Name = "panel1";
		E99E0925.Size = new Size(563, 364);
		E99E0925.TabIndex = 37;
		E99E0925.Paint += E99E0925_Paint;
		txtComment.Location = new Point(16, 64);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(528, 231);
		txtComment.TabIndex = 50;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += txtComment_TextChanged;
		B8A5E526.AutoSize = true;
		B8A5E526.Location = new Point(13, 299);
		B8A5E526.Name = "lblFooter";
		B8A5E526.Size = new Size(134, 16);
		B8A5E526.TabIndex = 49;
		B8A5E526.Text = "(Mỗi nội dung 1 dòng)";
		F61EEC05.AutoSize = true;
		F61EEC05.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		F61EEC05.Location = new Point(13, 45);
		F61EEC05.Name = "lblStatus";
		F61EEC05.Size = new Size(128, 16);
		F61EEC05.TabIndex = 47;
		F61EEC05.Text = "Danh sách Email (0):";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(286, 321);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 46;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(182, 321);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
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
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(B5AAC496);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(561, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = Resources.C400940B;
		button2.Location = new Point(530, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		B5AAC496.Cursor = Cursors.Hand;
		B5AAC496.FlatAppearance.BorderSize = 0;
		B5AAC496.FlatStyle = FlatStyle.Flat;
		B5AAC496.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B5AAC496.ForeColor = Color.White;
		B5AAC496.Location = new Point(899, 1);
		B5AAC496.Name = "btnMinimize";
		B5AAC496.Size = new Size(30, 30);
		B5AAC496.TabIndex = 9;
		B5AAC496.TextImageRelation = TextImageRelation.ImageBeforeText;
		B5AAC496.UseVisualStyleBackColor = true;
		lblTitle.BackColor = Color.Transparent;
		lblTitle.Cursor = Cursors.SizeAll;
		lblTitle.Dock = DockStyle.Fill;
		lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTitle.ForeColor = Color.Black;
		lblTitle.Location = new Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new Size(561, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Nhâ\u0323p danh sa\u0301ch Email cần add";
		lblTitle.TextAlign = ContentAlignment.MiddleCenter;
		D387A4A3.Fixed = true;
		D387A4A3.Horizontal = true;
		D387A4A3.TargetControl = lblTitle;
		D387A4A3.Vertical = true;
		DBA2BC04.AutomaticDelay = 0;
		DBA2BC04.AutoPopDelay = 10000;
		DBA2BC04.InitialDelay = 200;
		DBA2BC04.ReshowDelay = 40;
		label1.AutoSize = true;
		label1.BackColor = Color.Transparent;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label1.ForeColor = Color.DarkRed;
		label1.Location = new Point(187, 45);
		label1.Name = "label1";
		label1.Size = new Size(103, 16);
		label1.TabIndex = 47;
		label1.Text = "Định dạng nhập:";
		E18D3616.AutoSize = true;
		E18D3616.ForeColor = Color.DarkGreen;
		E18D3616.Location = new Point(286, 45);
		E18D3616.Name = "label2";
		E18D3616.Size = new Size(102, 16);
		E18D3616.TabIndex = 51;
		E18D3616.Text = "Email|Pass Mail ";
		label3.AutoSize = true;
		label3.BackColor = Color.Transparent;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label3.ForeColor = Color.DarkRed;
		label3.Location = new Point(381, 45);
		label3.Name = "label3";
		label3.Size = new Size(35, 16);
		label3.TabIndex = 47;
		label3.Text = "hoặc";
		label4.AutoSize = true;
		label4.ForeColor = Color.DarkGreen;
		label4.Location = new Point(414, 45);
		label4.Name = "label4";
		label4.Size = new Size(133, 16);
		label4.TabIndex = 51;
		label4.Text = "Email|Pass Mail|Imap";
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(563, 364);
		base.Controls.Add(E99E0925);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fNhapMailAdd";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += E6B767BD_Load;
		E99E0925.ResumeLayout(performLayout: false);
		E99E0925.PerformLayout();
		bunifuCards2.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
