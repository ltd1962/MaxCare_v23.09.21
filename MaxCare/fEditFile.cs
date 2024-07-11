using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fEditFile : Form
{
	private string FD1ACE27;

	private string string_0;

	public bool bool_0 = false;

	private IContainer A73CF22F = null;

	private BunifuCards D62AAF9E;

	private Panel B0167D07;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button BA9B8F82;

	private Button E119F0B7;

	private Button btnAdd;

	private Label label1;

	private BunifuDragControl E2B751B7;

	private TextBox C99E6E06;

	private PictureBox pictureBox1;

	private TextBox B7B47D35;

	private Label BFAA1824;

	public fEditFile(string A33F50A0, string string_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		FD1ACE27 = A33F50A0;
		string_0 = string_1;
		bool_0 = false;
	}

	private void BA9B8F82_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(BFAA1824);
		Language.smethod_0(btnAdd);
		Language.smethod_0(E119F0B7);
	}

	private void CD9DCC89(object sender, EventArgs e)
	{
		string text = B7B47D35.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lòng điền tên thư mục mới!", 3);
			B7B47D35.Focus();
		}
		else if (CommonSQL.smethod_0(text))
		{
			MessageBoxHelper.Show("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!", 3);
			B7B47D35.Focus();
		}
		else if (text.Equals(C99E6E06.Text.Trim()))
		{
			MessageBoxHelper.Show("Tên thư mục mới phải khác thư mục cũ!", 3);
			B7B47D35.Focus();
		}
		else if (CommonSQL.smethod_2(FD1ACE27, text))
		{
			bool_0 = true;
			if (MessageBoxHelper.ShowMessages("Cập nhật thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show("Cập nhật tên thư mục lỗi!");
		}
	}

	private void E119F0B7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B7B47D35_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			CD9DCC89(null, null);
		}
	}

	private void fEditFile_Load(object sender, EventArgs e)
	{
		C99E6E06.Text = string_0;
	}

	protected override void Dispose(bool B399918F)
	{
		if (B399918F && A73CF22F != null)
		{
			A73CF22F.Dispose();
		}
		base.Dispose(B399918F);
	}

	private void InitializeComponent()
	{
		this.A73CF22F = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditFile));
		this.D62AAF9E = new Bunifu.Framework.UI.BunifuCards();
		this.B0167D07 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.BA9B8F82 = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E119F0B7 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.E2B751B7 = new Bunifu.Framework.UI.BunifuDragControl(this.A73CF22F);
		this.C99E6E06 = new System.Windows.Forms.TextBox();
		this.B7B47D35 = new System.Windows.Forms.TextBox();
		this.BFAA1824 = new System.Windows.Forms.Label();
		this.D62AAF9E.SuspendLayout();
		this.B0167D07.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.D62AAF9E.BackColor = System.Drawing.Color.White;
		this.D62AAF9E.BorderRadius = 0;
		this.D62AAF9E.BottomSahddow = true;
		this.D62AAF9E.color = System.Drawing.Color.SaddleBrown;
		this.D62AAF9E.Controls.Add(this.B0167D07);
		this.D62AAF9E.Dock = System.Windows.Forms.DockStyle.Top;
		this.D62AAF9E.LeftSahddow = false;
		this.D62AAF9E.Location = new System.Drawing.Point(0, 0);
		this.D62AAF9E.Name = "bunifuCards1";
		this.D62AAF9E.RightSahddow = true;
		this.D62AAF9E.ShadowDepth = 20;
		this.D62AAF9E.Size = new System.Drawing.Size(396, 38);
		this.D62AAF9E.TabIndex = 0;
		this.B0167D07.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B0167D07.BackColor = System.Drawing.Color.White;
		this.B0167D07.Controls.Add(this.pictureBox1);
		this.B0167D07.Controls.Add(this.BA9B8F82);
		this.B0167D07.Controls.Add(this.bunifuCustomLabel1);
		this.B0167D07.Location = new System.Drawing.Point(0, 5);
		this.B0167D07.Name = "pnlHeader";
		this.B0167D07.Size = new System.Drawing.Size(396, 32);
		this.B0167D07.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(4, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 77;
		this.pictureBox1.TabStop = false;
		this.BA9B8F82.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BA9B8F82.FlatAppearance.BorderSize = 0;
		this.BA9B8F82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BA9B8F82.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BA9B8F82.ForeColor = System.Drawing.Color.White;
		this.BA9B8F82.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.BA9B8F82.Location = new System.Drawing.Point(362, -2);
		this.BA9B8F82.Name = "btnMinimize";
		this.BA9B8F82.Size = new System.Drawing.Size(32, 32);
		this.BA9B8F82.TabIndex = 9;
		this.BA9B8F82.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BA9B8F82.UseVisualStyleBackColor = true;
		this.BA9B8F82.Click += new System.EventHandler(BA9B8F82_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E119F0B7.BackColor = System.Drawing.Color.Maroon;
		this.E119F0B7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E119F0B7.FlatAppearance.BorderSize = 0;
		this.E119F0B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E119F0B7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E119F0B7.ForeColor = System.Drawing.Color.White;
		this.E119F0B7.Location = new System.Drawing.Point(204, 138);
		this.E119F0B7.Name = "btnCancel";
		this.E119F0B7.Size = new System.Drawing.Size(92, 29);
		this.E119F0B7.TabIndex = 4;
		this.E119F0B7.Text = "Hủy";
		this.E119F0B7.UseVisualStyleBackColor = false;
		this.E119F0B7.Click += new System.EventHandler(E119F0B7_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(100, 138);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Cập nhật";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(CD9DCC89);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new System.Drawing.Point(33, 69);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(102, 16);
		this.label1.TabIndex = 20;
		this.label1.Text = "Tên thư mu\u0323c cũ:";
		this.E2B751B7.Fixed = true;
		this.E2B751B7.Horizontal = true;
		this.E2B751B7.TargetControl = this.bunifuCustomLabel1;
		this.E2B751B7.Vertical = true;
		this.C99E6E06.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		this.C99E6E06.Location = new System.Drawing.Point(150, 66);
		this.C99E6E06.Name = "txtNameFileOld";
		this.C99E6E06.ReadOnly = true;
		this.C99E6E06.Size = new System.Drawing.Size(209, 23);
		this.C99E6E06.TabIndex = 2;
		this.C99E6E06.KeyDown += new System.Windows.Forms.KeyEventHandler(B7B47D35_KeyDown);
		this.B7B47D35.Location = new System.Drawing.Point(150, 95);
		this.B7B47D35.Name = "txtNameFileNew";
		this.B7B47D35.Size = new System.Drawing.Size(209, 23);
		this.B7B47D35.TabIndex = 2;
		this.B7B47D35.KeyDown += new System.Windows.Forms.KeyEventHandler(B7B47D35_KeyDown);
		this.BFAA1824.AutoSize = true;
		this.BFAA1824.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.BFAA1824.Location = new System.Drawing.Point(33, 98);
		this.BFAA1824.Name = "label2";
		this.BFAA1824.Size = new System.Drawing.Size(110, 16);
		this.BFAA1824.TabIndex = 20;
		this.BFAA1824.Text = "Tên thư mu\u0323c mới:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 182);
		base.Controls.Add(this.BFAA1824);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.E119F0B7);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.B7B47D35);
		base.Controls.Add(this.C99E6E06);
		base.Controls.Add(this.D62AAF9E);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fEditFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fEditFile_Load);
		this.D62AAF9E.ResumeLayout(false);
		this.B0167D07.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
