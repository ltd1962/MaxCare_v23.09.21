using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTemplateForm : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards AFA4E4A7;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button DF0B1008;

	private Button DF9B0205;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Panel panel1;

	public fTemplateForm()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void C5075003()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(DF9B0205);
	}

	private void F1031B8B(object sender, EventArgs e)
	{
		Close();
	}

	private void EE8DFCBE(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool D337DB32)
	{
		if (D337DB32 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D337DB32);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTemplateForm));
		this.AFA4E4A7 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.DF0B1008 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.DF9B0205 = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.panel1 = new System.Windows.Forms.Panel();
		this.AFA4E4A7.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.AFA4E4A7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.AFA4E4A7.BackColor = System.Drawing.Color.White;
		this.AFA4E4A7.BorderRadius = 0;
		this.AFA4E4A7.BottomSahddow = true;
		this.AFA4E4A7.color = System.Drawing.Color.SaddleBrown;
		this.AFA4E4A7.Controls.Add(this.pnlHeader);
		this.AFA4E4A7.LeftSahddow = false;
		this.AFA4E4A7.Location = new System.Drawing.Point(1, 0);
		this.AFA4E4A7.Name = "bunifuCards1";
		this.AFA4E4A7.RightSahddow = true;
		this.AFA4E4A7.ShadowDepth = 20;
		this.AFA4E4A7.Size = new System.Drawing.Size(832, 38);
		this.AFA4E4A7.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.DF0B1008);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(832, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.DF0B1008.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DF0B1008.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DF0B1008.FlatAppearance.BorderSize = 0;
		this.DF0B1008.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DF0B1008.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DF0B1008.ForeColor = System.Drawing.Color.White;
		this.DF0B1008.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.DF0B1008.Location = new System.Drawing.Point(799, -1);
		this.DF0B1008.Name = "btnMinimize";
		this.DF0B1008.Size = new System.Drawing.Size(32, 32);
		this.DF0B1008.TabIndex = 9;
		this.DF0B1008.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.DF0B1008.UseVisualStyleBackColor = true;
		this.DF0B1008.Click += new System.EventHandler(F1031B8B);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(832, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Hướng dẫn nhập Nội dung có nhiều dòng";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DF9B0205.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.DF9B0205.BackColor = System.Drawing.Color.Maroon;
		this.DF9B0205.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DF9B0205.FlatAppearance.BorderSize = 0;
		this.DF9B0205.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DF9B0205.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DF9B0205.ForeColor = System.Drawing.Color.White;
		this.DF9B0205.Location = new System.Drawing.Point(370, 501);
		this.DF9B0205.Name = "btnCancel";
		this.DF9B0205.Size = new System.Drawing.Size(92, 29);
		this.DF9B0205.TabIndex = 4;
		this.DF9B0205.Text = "Đo\u0301ng";
		this.DF9B0205.UseVisualStyleBackColor = false;
		this.DF9B0205.Click += new System.EventHandler(EE8DFCBE);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(833, 542);
		this.panel1.TabIndex = 5;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(833, 542);
		base.Controls.Add(this.DF9B0205);
		base.Controls.Add(this.AFA4E4A7);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTemplateForm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.AFA4E4A7.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
