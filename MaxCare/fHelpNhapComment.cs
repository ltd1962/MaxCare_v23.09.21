using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHelpNhapComment : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards FC267C2A;

	private Panel CA1F6AA0;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button E437BE07;

	private BunifuDragControl FDB5E637;

	private PictureBox pictureBox1;

	private Label label1;

	private PictureBox pictureBox2;

	private Panel FB9C7E3C;

	public fHelpNhapComment()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		method_0();
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(E437BE07);
	}

	private void B9A55936(object sender, EventArgs e)
	{
		Close();
	}

	private void C09E620B(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool BC908180)
	{
		if (BC908180 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(BC908180);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHelpNhapComment));
		this.FC267C2A = new Bunifu.Framework.UI.BunifuCards();
		this.CA1F6AA0 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E437BE07 = new System.Windows.Forms.Button();
		this.FDB5E637 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.FB9C7E3C = new System.Windows.Forms.Panel();
		this.FC267C2A.SuspendLayout();
		this.CA1F6AA0.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.FC267C2A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.FC267C2A.BackColor = System.Drawing.Color.White;
		this.FC267C2A.BorderRadius = 0;
		this.FC267C2A.BottomSahddow = true;
		this.FC267C2A.color = System.Drawing.Color.SaddleBrown;
		this.FC267C2A.Controls.Add(this.CA1F6AA0);
		this.FC267C2A.LeftSahddow = false;
		this.FC267C2A.Location = new System.Drawing.Point(1, 0);
		this.FC267C2A.Name = "bunifuCards1";
		this.FC267C2A.RightSahddow = true;
		this.FC267C2A.ShadowDepth = 20;
		this.FC267C2A.Size = new System.Drawing.Size(577, 38);
		this.FC267C2A.TabIndex = 0;
		this.CA1F6AA0.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CA1F6AA0.BackColor = System.Drawing.Color.White;
		this.CA1F6AA0.Controls.Add(this.pictureBox1);
		this.CA1F6AA0.Controls.Add(this.btnMinimize);
		this.CA1F6AA0.Controls.Add(this.bunifuCustomLabel1);
		this.CA1F6AA0.Location = new System.Drawing.Point(0, 5);
		this.CA1F6AA0.Name = "pnlHeader";
		this.CA1F6AA0.Size = new System.Drawing.Size(577, 32);
		this.CA1F6AA0.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(544, -1);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(B9A55936);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(577, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Hướng dẫn nhập Nội dung có nhiều dòng";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E437BE07.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.E437BE07.BackColor = System.Drawing.Color.Maroon;
		this.E437BE07.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E437BE07.FlatAppearance.BorderSize = 0;
		this.E437BE07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E437BE07.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E437BE07.ForeColor = System.Drawing.Color.White;
		this.E437BE07.Location = new System.Drawing.Point(246, 380);
		this.E437BE07.Name = "btnCancel";
		this.E437BE07.Size = new System.Drawing.Size(92, 29);
		this.E437BE07.TabIndex = 4;
		this.E437BE07.Text = "Đo\u0301ng";
		this.E437BE07.UseVisualStyleBackColor = false;
		this.E437BE07.Click += new System.EventHandler(C09E620B);
		this.FDB5E637.Fixed = true;
		this.FDB5E637.Horizontal = true;
		this.FDB5E637.TargetControl = this.bunifuCustomLabel1;
		this.FDB5E637.Vertical = true;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(28, 60);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(366, 16);
		this.label1.TabIndex = 5;
		this.label1.Text = "Vui lòng nhập các nội dung ngăn cách nhau bởi dấu | như sau:";
		this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		this.pictureBox2.Location = new System.Drawing.Point(31, 86);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(516, 273);
		this.pictureBox2.TabIndex = 6;
		this.pictureBox2.TabStop = false;
		this.FB9C7E3C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FB9C7E3C.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FB9C7E3C.Location = new System.Drawing.Point(0, 0);
		this.FB9C7E3C.Name = "panel1";
		this.FB9C7E3C.Size = new System.Drawing.Size(578, 421);
		this.FB9C7E3C.TabIndex = 7;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(578, 421);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.E437BE07);
		base.Controls.Add(this.FC267C2A);
		base.Controls.Add(this.FB9C7E3C);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fHelpNhapComment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.FC267C2A.ResumeLayout(false);
		this.CA1F6AA0.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
