using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu1 : Form
{
	private string string_0 = "";

	private string E82EB422 = "";

	public List<string> C82C3629 = new List<string>();

	private IContainer B5A2F606 = null;

	private BunifuCards BE9EB399;

	private Panel panel1;

	private BunifuDragControl F23F78BD;

	private ToolTip EDA7E3B1;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox E005938C;

	private Button EC14AC26;

	private BunifuCustomLabel lblTitle;

	private Label lblStatus;

	private Button btnCancel;

	private Button btnAdd;

	private Label lblFooter;

	private RichTextBox E8185190;

	public fNhapDuLieu1(string ECAFF426, string FB0D0EB3 = "Nhập danh sách Uid cần clone", string A7A3D434 = "Danh sách Uid", string string_1 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> list_0 = null)
	{
		InitializeComponent();
		Common.CreateFile(ECAFF426);
		string_0 = ECAFF426;
		E82EB422 = A7A3D434;
		lblTitle.Text = FB0D0EB3;
		lblStatus.Text = A7A3D434 + " (0):";
		lblFooter.Text = string_1;
		if (list_0 != null)
		{
			File.WriteAllLines(ECAFF426, list_0);
			E8185190.Lines = list_0.ToArray();
		}
		else
		{
			E8185190.Lines = File.ReadAllLines(ECAFF426);
		}
		E8185190_TextChanged(null, null);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(lblTitle);
		Language.smethod_0(lblStatus);
		Language.smethod_0(lblFooter);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	public fNhapDuLieu1(List<string> FD8FA681, string A1A1B207 = "Nhập danh sách Uid cần clone", string string_1 = "Danh sách Uid", string string_2 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		InitializeComponent();
		C82C3629 = FD8FA681;
		E82EB422 = string_1;
		lblTitle.Text = A1A1B207;
		lblStatus.Text = string_1 + " (0):";
		lblFooter.Text = string_2;
		Language.SetLanguage(this);
	}

	private void fNhapDuLieu1_Load(object sender, EventArgs e)
	{
		if (string_0 != "")
		{
			E8185190.Lines = File.ReadAllLines(string_0);
		}
		else
		{
			E8185190.Lines = C82C3629.ToArray();
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void FA9EC90A(object sender, EventArgs e)
	{
		Close();
	}

	private void CD3F6930(object sender, EventArgs e)
	{
		try
		{
			if (string_0 != "")
			{
				File.WriteAllText(string_0, E8185190.Text.Trim());
			}
			else
			{
				C82C3629 = E8185190.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			}
			Close();
		}
		catch
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void A4236CBE(object sender, EventArgs e)
	{
		Close();
	}

	private void E8185190_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = E8185190.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = E82EB422 + " (" + a2AB53A.Count + "):";
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && B5A2F606 != null)
		{
			B5A2F606.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.B5A2F606 = new System.ComponentModel.Container();
		this.BE9EB399 = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.lblFooter = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.E005938C = new System.Windows.Forms.PictureBox();
		this.EC14AC26 = new System.Windows.Forms.Button();
		this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F23F78BD = new Bunifu.Framework.UI.BunifuDragControl(this.B5A2F606);
		this.EDA7E3B1 = new System.Windows.Forms.ToolTip(this.B5A2F606);
		this.E8185190 = new System.Windows.Forms.RichTextBox();
		this.panel1.SuspendLayout();
		this.bunifuCards2.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E005938C).BeginInit();
		base.SuspendLayout();
		this.BE9EB399.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BE9EB399.BackColor = System.Drawing.Color.White;
		this.BE9EB399.BorderRadius = 5;
		this.BE9EB399.BottomSahddow = true;
		this.BE9EB399.color = System.Drawing.Color.SaddleBrown;
		this.BE9EB399.LeftSahddow = false;
		this.BE9EB399.Location = new System.Drawing.Point(0, 0);
		this.BE9EB399.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.BE9EB399.Name = "bunifuCards1";
		this.BE9EB399.RightSahddow = true;
		this.BE9EB399.ShadowDepth = 20;
		this.BE9EB399.Size = new System.Drawing.Size(234, 47);
		this.BE9EB399.TabIndex = 12;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.E8185190);
		this.panel1.Controls.Add(this.lblFooter);
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards2);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(563, 364);
		this.panel1.TabIndex = 37;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.lblFooter.AutoSize = true;
		this.lblFooter.Location = new System.Drawing.Point(13, 299);
		this.lblFooter.Name = "lblFooter";
		this.lblFooter.Size = new System.Drawing.Size(266, 16);
		this.lblFooter.TabIndex = 49;
		this.lblFooter.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.lblStatus.Location = new System.Drawing.Point(13, 45);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(140, 16);
		this.lblStatus.TabIndex = 47;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(286, 321);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 46;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(A4236CBE);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(182, 321);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 45;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(CD3F6930);
		this.bunifuCards2.BackColor = System.Drawing.Color.White;
		this.bunifuCards2.BorderRadius = 0;
		this.bunifuCards2.BottomSahddow = true;
		this.bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards2.Controls.Add(this.pnlHeader);
		this.bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards2.LeftSahddow = false;
		this.bunifuCards2.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards2.Name = "bunifuCards2";
		this.bunifuCards2.RightSahddow = true;
		this.bunifuCards2.ShadowDepth = 20;
		this.bunifuCards2.Size = new System.Drawing.Size(561, 37);
		this.bunifuCards2.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.E005938C);
		this.pnlHeader.Controls.Add(this.EC14AC26);
		this.pnlHeader.Controls.Add(this.lblTitle);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(561, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Resources.C400940B;
		this.button2.Location = new System.Drawing.Point(530, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(FA9EC90A);
		this.E005938C.Cursor = System.Windows.Forms.Cursors.Default;
		this.E005938C.Image = Resources.Bitmap_4;
		this.E005938C.Location = new System.Drawing.Point(3, 2);
		this.E005938C.Name = "pictureBox1";
		this.E005938C.Size = new System.Drawing.Size(34, 27);
		this.E005938C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E005938C.TabIndex = 76;
		this.E005938C.TabStop = false;
		this.EC14AC26.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EC14AC26.FlatAppearance.BorderSize = 0;
		this.EC14AC26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EC14AC26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EC14AC26.ForeColor = System.Drawing.Color.White;
		this.EC14AC26.Location = new System.Drawing.Point(899, 1);
		this.EC14AC26.Name = "btnMinimize";
		this.EC14AC26.Size = new System.Drawing.Size(30, 30);
		this.EC14AC26.TabIndex = 9;
		this.EC14AC26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.EC14AC26.UseVisualStyleBackColor = true;
		this.lblTitle.BackColor = System.Drawing.Color.Transparent;
		this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblTitle.ForeColor = System.Drawing.Color.Black;
		this.lblTitle.Location = new System.Drawing.Point(0, 0);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(561, 31);
		this.lblTitle.TabIndex = 12;
		this.lblTitle.Text = "Nhập nội dung comment";
		this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F23F78BD.Fixed = true;
		this.F23F78BD.Horizontal = true;
		this.F23F78BD.TargetControl = this.lblTitle;
		this.F23F78BD.Vertical = true;
		this.EDA7E3B1.AutomaticDelay = 0;
		this.EDA7E3B1.AutoPopDelay = 10000;
		this.EDA7E3B1.InitialDelay = 200;
		this.EDA7E3B1.ReshowDelay = 40;
		this.E8185190.Location = new System.Drawing.Point(16, 64);
		this.E8185190.Name = "txtComment";
		this.E8185190.Size = new System.Drawing.Size(528, 231);
		this.E8185190.TabIndex = 50;
		this.E8185190.Text = "";
		this.E8185190.WordWrap = false;
		this.E8185190.TextChanged += new System.EventHandler(E8185190_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(563, 364);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.BE9EB399);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fNhapDuLieu1_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.bunifuCards2.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E005938C).EndInit();
		base.ResumeLayout(false);
	}
}
