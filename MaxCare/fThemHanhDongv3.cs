using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemHanhDongv3 : Form
{
	public string string_0;

	private IContainer F8907634 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private BunifuCards CA0A642B;

	private Panel pnlHeader;

	private PictureBox AC019336;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel panel1;

	private ToolTip toolTip_0;

	private Button BA0489A6;

	private GClass9 ckbGiaoDienMoi;

	private Label label1;

	private Panel D91ADB81;

	public fThemHanhDongv3(string A693919B)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		string_0 = A693919B;
	}

	private void B712DEB8(object sender, EventArgs e)
	{
		ckbGiaoDienMoi.Checked = false;
		C52602BC(null, null);
	}

	private void B1A3BE18(object sender, PaintEventArgs e)
	{
	}

	private void AC019336_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			base.Height = 508;
		}
	}

	private void BA0489A6_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C52602BC(object sender, EventArgs e)
	{
		base.Width = 1180;
		D91ADB81.Controls.Clear();
		if (ckbGiaoDienMoi.Checked)
		{
			D91ADB81.Controls.Add(new ucThemHanhDongv2());
		}
		else
		{
			D91ADB81.Controls.Add(new ucThemHanhDongv1(this));
		}
	}

	protected override void Dispose(bool CFA01D84)
	{
		if (CFA01D84 && F8907634 != null)
		{
			F8907634.Dispose();
		}
		base.Dispose(CFA01D84);
	}

	private void InitializeComponent()
	{
		this.F8907634 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemHanhDongv3));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.F8907634);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.F8907634);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.BA0489A6 = new System.Windows.Forms.Button();
		this.AC019336 = new System.Windows.Forms.PictureBox();
		this.CA0A642B = new Bunifu.Framework.UI.BunifuCards();
		this.panel1 = new System.Windows.Forms.Panel();
		this.D91ADB81 = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.ckbGiaoDienMoi = new GClass9();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.F8907634);
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AC019336).BeginInit();
		this.CA0A642B.SuspendLayout();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1175, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Danh sách hành động";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.BA0489A6);
		this.pnlHeader.Controls.Add(this.AC019336);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1175, 31);
		this.pnlHeader.TabIndex = 9;
		this.BA0489A6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BA0489A6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BA0489A6.FlatAppearance.BorderSize = 0;
		this.BA0489A6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BA0489A6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BA0489A6.ForeColor = System.Drawing.Color.White;
		this.BA0489A6.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		this.BA0489A6.Location = new System.Drawing.Point(1144, 0);
		this.BA0489A6.Name = "btnClose";
		this.BA0489A6.Size = new System.Drawing.Size(32, 31);
		this.BA0489A6.TabIndex = 77;
		this.BA0489A6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BA0489A6.UseVisualStyleBackColor = true;
		this.BA0489A6.Click += new System.EventHandler(BA0489A6_Click);
		this.AC019336.Cursor = System.Windows.Forms.Cursors.Default;
		this.AC019336.Image = Resources.Bitmap_4;
		this.AC019336.Location = new System.Drawing.Point(3, 2);
		this.AC019336.Name = "pictureBox1";
		this.AC019336.Size = new System.Drawing.Size(34, 27);
		this.AC019336.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.AC019336.TabIndex = 76;
		this.AC019336.TabStop = false;
		this.AC019336.Click += new System.EventHandler(AC019336_Click);
		this.CA0A642B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CA0A642B.BackColor = System.Drawing.Color.White;
		this.CA0A642B.BorderRadius = 0;
		this.CA0A642B.BottomSahddow = true;
		this.CA0A642B.color = System.Drawing.Color.DarkViolet;
		this.CA0A642B.Controls.Add(this.pnlHeader);
		this.CA0A642B.LeftSahddow = false;
		this.CA0A642B.Location = new System.Drawing.Point(1, 0);
		this.CA0A642B.Name = "bunifuCards1";
		this.CA0A642B.RightSahddow = true;
		this.CA0A642B.ShadowDepth = 20;
		this.CA0A642B.Size = new System.Drawing.Size(1177, 37);
		this.CA0A642B.TabIndex = 12;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.D91ADB81);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.ckbGiaoDienMoi);
		this.panel1.Controls.Add(this.CA0A642B);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1180, 546);
		this.panel1.TabIndex = 25;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(B1A3BE18);
		this.D91ADB81.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D91ADB81.Location = new System.Drawing.Point(3, 38);
		this.D91ADB81.Name = "plDanhSachHanhDong";
		this.D91ADB81.Size = new System.Drawing.Size(1171, 476);
		this.D91ADB81.TabIndex = 16;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(3, 520);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(90, 16);
		this.label1.TabIndex = 15;
		this.label1.Text = "Giao diê\u0323n mơ\u0301i:";
		this.label1.Visible = false;
		this.ckbGiaoDienMoi.AutoSize = true;
		this.ckbGiaoDienMoi.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGiaoDienMoi.Location = new System.Drawing.Point(93, 518);
		this.ckbGiaoDienMoi.MinimumSize = new System.Drawing.Size(45, 22);
		this.ckbGiaoDienMoi.Name = "ckbGiaoDienMoi";
		this.ckbGiaoDienMoi.Color_2 = System.Drawing.Color.Gray;
		this.ckbGiaoDienMoi.Color_3 = System.Drawing.Color.Gainsboro;
		this.ckbGiaoDienMoi.Color_0 = System.Drawing.Color.MediumSlateBlue;
		this.ckbGiaoDienMoi.Color_1 = System.Drawing.Color.WhiteSmoke;
		this.ckbGiaoDienMoi.Size = new System.Drawing.Size(45, 22);
		this.ckbGiaoDienMoi.TabIndex = 14;
		this.ckbGiaoDienMoi.UseVisualStyleBackColor = true;
		this.ckbGiaoDienMoi.Visible = false;
		this.ckbGiaoDienMoi.CheckedChanged += new System.EventHandler(C52602BC);
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 0;
		this.toolTip_0.InitialDelay = 500;
		this.toolTip_0.ReshowDelay = 0;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1180, 546);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemHanhDongv3";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B712DEB8);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.AC019336).EndInit();
		this.CA0A642B.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
	}
}
