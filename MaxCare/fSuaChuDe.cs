using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fSuaChuDe : Form
{
	private IContainer F9818395 = null;

	private BunifuCards bunifuCards1;

	private Panel FB26ADAA;

	private BunifuDragControl C3829F9E;

	private ToolTip E48EFA86;

	private BunifuCards F5221411;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox BD0A4290;

	private Button CD9AB509;

	private BunifuCustomLabel A405DB84;

	private ContextMenuStrip C2A28D00;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label FA0D6513;

	private Button btnCancel;

	private Button DAAC4A95;

	private TextBox txtNewChuDe;

	private Label label1;

	private TextBox CCAB882E;

	public fSuaChuDe(string CBBA1707)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		CCAB882E.Text = CBBA1707;
	}

	private void fSuaChuDe_Load(object sender, EventArgs e)
	{
	}

	private void FB26ADAA_Paint(object sender, PaintEventArgs e)
	{
	}

	private void AB859487(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void DAAC4A95_Click(object sender, EventArgs e)
	{
		List<string> list = CommonSQL.smethod_21();
		string string_ = CCAB882E.Text;
		string text = txtNewChuDe.Text;
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập tên chủ đề mới!", 2);
		}
		else if (!list.Contains(text))
		{
			CommonSQL.smethod_28(string_, text);
			if (MessageBoxHelper.ShowMessages("Cập nhật thành công, bạn có muốn đóng cửa sổ?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show("Tên chủ đề đã tồn tại, vui lòng đổi tên khác!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fSuaChuDe_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F9818395 != null)
		{
			F9818395.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F9818395 = new System.ComponentModel.Container();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.FB26ADAA = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.FA0D6513 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.CCAB882E = new System.Windows.Forms.TextBox();
		this.DAAC4A95 = new System.Windows.Forms.Button();
		this.txtNewChuDe = new System.Windows.Forms.TextBox();
		this.F5221411 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.BD0A4290 = new System.Windows.Forms.PictureBox();
		this.CD9AB509 = new System.Windows.Forms.Button();
		this.A405DB84 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.C2A28D00 = new System.Windows.Forms.ContextMenuStrip(this.F9818395);
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.C3829F9E = new Bunifu.Framework.UI.BunifuDragControl(this.F9818395);
		this.E48EFA86 = new System.Windows.Forms.ToolTip(this.F9818395);
		this.FB26ADAA.SuspendLayout();
		this.F5221411.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BD0A4290).BeginInit();
		this.C2A28D00.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(0, 47);
		this.bunifuCards1.TabIndex = 12;
		this.FB26ADAA.BackColor = System.Drawing.Color.White;
		this.FB26ADAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FB26ADAA.Controls.Add(this.label1);
		this.FB26ADAA.Controls.Add(this.FA0D6513);
		this.FB26ADAA.Controls.Add(this.btnCancel);
		this.FB26ADAA.Controls.Add(this.CCAB882E);
		this.FB26ADAA.Controls.Add(this.DAAC4A95);
		this.FB26ADAA.Controls.Add(this.txtNewChuDe);
		this.FB26ADAA.Controls.Add(this.F5221411);
		this.FB26ADAA.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FB26ADAA.Location = new System.Drawing.Point(0, 0);
		this.FB26ADAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.FB26ADAA.Name = "panel1";
		this.FB26ADAA.Size = new System.Drawing.Size(329, 164);
		this.FB26ADAA.TabIndex = 37;
		this.FB26ADAA.Paint += new System.Windows.Forms.PaintEventHandler(FB26ADAA_Paint);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(28, 49);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(94, 16);
		this.label1.TabIndex = 47;
		this.label1.Text = "Tên chủ đề cũ:";
		this.FA0D6513.AutoSize = true;
		this.FA0D6513.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.FA0D6513.Location = new System.Drawing.Point(28, 78);
		this.FA0D6513.Name = "label2";
		this.FA0D6513.Size = new System.Drawing.Size(102, 16);
		this.FA0D6513.TabIndex = 47;
		this.FA0D6513.Text = "Tên chủ đề mới:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(173, 116);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 46;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.CCAB882E.Lines = new string[0];
		this.CCAB882E.Location = new System.Drawing.Point(138, 46);
		this.CCAB882E.MaxLength = 32767;
		this.CCAB882E.Name = "txtChude";
		this.CCAB882E.PasswordChar = '\0';
		this.CCAB882E.ReadOnly = true;
		this.CCAB882E.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.CCAB882E.SelectedText = "";
		this.CCAB882E.SelectionLength = 0;
		this.CCAB882E.SelectionStart = 0;
		this.CCAB882E.ShortcutsEnabled = true;
		this.CCAB882E.Size = new System.Drawing.Size(153, 23);
		this.CCAB882E.TabIndex = 44;
		this.DAAC4A95.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.DAAC4A95.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DAAC4A95.FlatAppearance.BorderSize = 0;
		this.DAAC4A95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DAAC4A95.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DAAC4A95.ForeColor = System.Drawing.Color.White;
		this.DAAC4A95.Location = new System.Drawing.Point(69, 116);
		this.DAAC4A95.Name = "btnAdd";
		this.DAAC4A95.Size = new System.Drawing.Size(92, 29);
		this.DAAC4A95.TabIndex = 45;
		this.DAAC4A95.Text = "Cập nhật";
		this.DAAC4A95.UseVisualStyleBackColor = false;
		this.DAAC4A95.Click += new System.EventHandler(DAAC4A95_Click);
		this.txtNewChuDe.Lines = new string[0];
		this.txtNewChuDe.Location = new System.Drawing.Point(138, 75);
		this.txtNewChuDe.MaxLength = 32767;
		this.txtNewChuDe.Name = "txtNewChuDe";
		this.txtNewChuDe.PasswordChar = '\0';
		this.txtNewChuDe.ScrollBars = System.Windows.Forms.ScrollBars.None;
		this.txtNewChuDe.SelectedText = "";
		this.txtNewChuDe.SelectionLength = 0;
		this.txtNewChuDe.SelectionStart = 0;
		this.txtNewChuDe.ShortcutsEnabled = true;
		this.txtNewChuDe.Size = new System.Drawing.Size(153, 23);
		this.txtNewChuDe.TabIndex = 44;
		this.F5221411.BackColor = System.Drawing.Color.White;
		this.F5221411.BorderRadius = 0;
		this.F5221411.BottomSahddow = true;
		this.F5221411.color = System.Drawing.Color.SaddleBrown;
		this.F5221411.Controls.Add(this.pnlHeader);
		this.F5221411.Dock = System.Windows.Forms.DockStyle.Top;
		this.F5221411.LeftSahddow = false;
		this.F5221411.Location = new System.Drawing.Point(0, 0);
		this.F5221411.Name = "bunifuCards2";
		this.F5221411.RightSahddow = true;
		this.F5221411.ShadowDepth = 20;
		this.F5221411.Size = new System.Drawing.Size(327, 37);
		this.F5221411.TabIndex = 43;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button2);
		this.pnlHeader.Controls.Add(this.BD0A4290);
		this.pnlHeader.Controls.Add(this.CD9AB509);
		this.pnlHeader.Controls.Add(this.A405DB84);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(327, 31);
		this.pnlHeader.TabIndex = 9;
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.FlatAppearance.BorderSize = 0;
		this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Image = Resources.C400940B;
		this.button2.Location = new System.Drawing.Point(296, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(30, 30);
		this.button2.TabIndex = 77;
		this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(AB859487);
		this.BD0A4290.Cursor = System.Windows.Forms.Cursors.Default;
		this.BD0A4290.Image = Resources.Bitmap_4;
		this.BD0A4290.Location = new System.Drawing.Point(3, 2);
		this.BD0A4290.Name = "pictureBox1";
		this.BD0A4290.Size = new System.Drawing.Size(34, 27);
		this.BD0A4290.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.BD0A4290.TabIndex = 76;
		this.BD0A4290.TabStop = false;
		this.CD9AB509.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CD9AB509.FlatAppearance.BorderSize = 0;
		this.CD9AB509.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CD9AB509.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CD9AB509.ForeColor = System.Drawing.Color.White;
		this.CD9AB509.Location = new System.Drawing.Point(899, 1);
		this.CD9AB509.Name = "btnMinimize";
		this.CD9AB509.Size = new System.Drawing.Size(30, 30);
		this.CD9AB509.TabIndex = 9;
		this.CD9AB509.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.CD9AB509.UseVisualStyleBackColor = true;
		this.A405DB84.BackColor = System.Drawing.Color.Transparent;
		this.A405DB84.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.A405DB84.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A405DB84.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A405DB84.ForeColor = System.Drawing.Color.Black;
		this.A405DB84.Location = new System.Drawing.Point(0, 0);
		this.A405DB84.Name = "bunifuCustomLabel1";
		this.A405DB84.Size = new System.Drawing.Size(327, 31);
		this.A405DB84.TabIndex = 12;
		this.A405DB84.Text = "Cập nhật chủ đề";
		this.A405DB84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C2A28D00.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2 });
		this.C2A28D00.Name = "contextMenuStrip1";
		this.C2A28D00.Size = new System.Drawing.Size(153, 70);
		this.toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_0.Text = "Thêm chủ đề";
		this.toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		this.toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(152, 22);
		this.toolStripMenuItem_2.Text = "Xóa chủ đề";
		this.C3829F9E.Fixed = true;
		this.C3829F9E.Horizontal = true;
		this.C3829F9E.TargetControl = this.A405DB84;
		this.C3829F9E.Vertical = true;
		this.E48EFA86.AutomaticDelay = 0;
		this.E48EFA86.AutoPopDelay = 10000;
		this.E48EFA86.InitialDelay = 200;
		this.E48EFA86.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(329, 164);
		base.Controls.Add(this.FB26ADAA);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fSuaChuDe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình chung";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fSuaChuDe_FormClosing);
		base.Load += new System.EventHandler(fSuaChuDe_Load);
		this.FB26ADAA.ResumeLayout(false);
		this.FB26ADAA.PerformLayout();
		this.F5221411.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.BD0A4290).EndInit();
		this.C2A28D00.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
