using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fLocTheoDanhSachUid : Form
{
	public List<string> CB22AE1B = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards CB988BA4;

	private Panel pnlHeader;

	private BunifuCustomLabel C7391921;

	private Button btnMinimize;

	private Button E7B241B4;

	private Button AC2C93A0;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label D5B05789;

	private RichTextBox txtUseragent;

	public fLocTheoDanhSachUid()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		CB22AE1B = new List<string>();
	}

	private void method_0()
	{
		Language.smethod_0(C7391921);
		Language.smethod_0(D5B05789);
		Language.smethod_0(AC2C93A0);
		Language.smethod_0(E7B241B4);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AC2C93A0_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUseragent.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p thêm UID!", 3);
				return;
			}
			CB22AE1B = Common.CloneList(a2AB53A);
			Close();
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void E7B241B4_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B09DE91D(object sender, EventArgs e)
	{
		Common.F9202C12(txtUseragent, D5B05789);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLocTheoDanhSachUid));
		this.CB988BA4 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.C7391921 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E7B241B4 = new System.Windows.Forms.Button();
		this.AC2C93A0 = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D5B05789 = new System.Windows.Forms.Label();
		this.txtUseragent = new System.Windows.Forms.RichTextBox();
		this.CB988BA4.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.CB988BA4.BackColor = System.Drawing.Color.White;
		this.CB988BA4.BorderRadius = 0;
		this.CB988BA4.BottomSahddow = true;
		this.CB988BA4.color = System.Drawing.Color.SaddleBrown;
		this.CB988BA4.Controls.Add(this.pnlHeader);
		this.CB988BA4.Dock = System.Windows.Forms.DockStyle.Top;
		this.CB988BA4.LeftSahddow = false;
		this.CB988BA4.Location = new System.Drawing.Point(0, 0);
		this.CB988BA4.Name = "bunifuCards1";
		this.CB988BA4.RightSahddow = true;
		this.CB988BA4.ShadowDepth = 20;
		this.CB988BA4.Size = new System.Drawing.Size(477, 38);
		this.CB988BA4.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.C7391921);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(477, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(4, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(445, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.C7391921.BackColor = System.Drawing.Color.Transparent;
		this.C7391921.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C7391921.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C7391921.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C7391921.ForeColor = System.Drawing.Color.Black;
		this.C7391921.Location = new System.Drawing.Point(0, 0);
		this.C7391921.Name = "bunifuCustomLabel1";
		this.C7391921.Size = new System.Drawing.Size(477, 32);
		this.C7391921.TabIndex = 1;
		this.C7391921.Text = "Nhâ\u0323p Danh sách UID/Email cần lọc";
		this.C7391921.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E7B241B4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.E7B241B4.BackColor = System.Drawing.Color.Maroon;
		this.E7B241B4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E7B241B4.FlatAppearance.BorderSize = 0;
		this.E7B241B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E7B241B4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E7B241B4.ForeColor = System.Drawing.Color.White;
		this.E7B241B4.Location = new System.Drawing.Point(245, 280);
		this.E7B241B4.Name = "btnCancel";
		this.E7B241B4.Size = new System.Drawing.Size(92, 29);
		this.E7B241B4.TabIndex = 4;
		this.E7B241B4.Text = "Đo\u0301ng";
		this.E7B241B4.UseVisualStyleBackColor = false;
		this.E7B241B4.Click += new System.EventHandler(E7B241B4_Click);
		this.AC2C93A0.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.AC2C93A0.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.AC2C93A0.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AC2C93A0.FlatAppearance.BorderSize = 0;
		this.AC2C93A0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AC2C93A0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AC2C93A0.ForeColor = System.Drawing.Color.White;
		this.AC2C93A0.Location = new System.Drawing.Point(136, 280);
		this.AC2C93A0.Name = "btnAdd";
		this.AC2C93A0.Size = new System.Drawing.Size(92, 29);
		this.AC2C93A0.TabIndex = 3;
		this.AC2C93A0.Text = "Xa\u0301c nhâ\u0323n";
		this.AC2C93A0.UseVisualStyleBackColor = false;
		this.AC2C93A0.Click += new System.EventHandler(AC2C93A0_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.C7391921;
		this.bunifuDragControl_0.Vertical = true;
		this.D5B05789.AutoSize = true;
		this.D5B05789.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D5B05789.Location = new System.Drawing.Point(30, 47);
		this.D5B05789.Name = "lblStatus";
		this.D5B05789.Size = new System.Drawing.Size(152, 16);
		this.D5B05789.TabIndex = 6;
		this.D5B05789.Text = "Danh sa\u0301ch UID/Email (0):";
		this.txtUseragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtUseragent.Location = new System.Drawing.Point(34, 66);
		this.txtUseragent.Name = "txtUseragent";
		this.txtUseragent.Size = new System.Drawing.Size(409, 181);
		this.txtUseragent.TabIndex = 118;
		this.txtUseragent.Text = "";
		this.txtUseragent.WordWrap = false;
		this.txtUseragent.TextChanged += new System.EventHandler(B09DE91D);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 323);
		base.Controls.Add(this.txtUseragent);
		base.Controls.Add(this.D5B05789);
		base.Controls.Add(this.E7B241B4);
		base.Controls.Add(this.AC2C93A0);
		base.Controls.Add(this.CB988BA4);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fLocTheoDanhSachUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.CB988BA4.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
