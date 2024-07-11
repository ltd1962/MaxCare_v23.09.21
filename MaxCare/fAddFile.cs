using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fAddFile : Form
{
	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuCards B19AF18C;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button F127503C;

	private Button E312441B;

	private Label B61D98AA;

	private BunifuDragControl bunifuDragControl_0;

	private TextBox BB3B76AB;

	private PictureBox pictureBox1;

	public fAddFile()
	{
		InitializeComponent();
		bool_0 = false;
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(B61D98AA);
		Language.smethod_0(E312441B);
		Language.smethod_0(F127503C);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BC096018(object sender, EventArgs e)
	{
		string text = BB3B76AB.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lòng điền tên thư mục!");
			BB3B76AB.Focus();
		}
		else if (CommonSQL.smethod_0(text))
		{
			MessageBoxHelper.Show("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!");
			BB3B76AB.Focus();
		}
		else if (CommonSQL.B623BF13(text))
		{
			bool_0 = true;
			if (MessageBoxHelper.ShowMessages("Thêm thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show("Thêm thư mục lỗi!");
		}
	}

	private void F127503C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BB3B76AB_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			BC096018(null, null);
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddFile));
		this.B19AF18C = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F127503C = new System.Windows.Forms.Button();
		this.E312441B = new System.Windows.Forms.Button();
		this.B61D98AA = new System.Windows.Forms.Label();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.BB3B76AB = new System.Windows.Forms.TextBox();
		this.B19AF18C.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.B19AF18C.BackColor = System.Drawing.Color.White;
		this.B19AF18C.BorderRadius = 0;
		this.B19AF18C.BottomSahddow = true;
		this.B19AF18C.color = System.Drawing.Color.SaddleBrown;
		this.B19AF18C.Controls.Add(this.pnlHeader);
		this.B19AF18C.Dock = System.Windows.Forms.DockStyle.Top;
		this.B19AF18C.LeftSahddow = false;
		this.B19AF18C.Location = new System.Drawing.Point(0, 0);
		this.B19AF18C.Name = "bunifuCards1";
		this.B19AF18C.RightSahddow = true;
		this.B19AF18C.ShadowDepth = 20;
		this.B19AF18C.Size = new System.Drawing.Size(396, 38);
		this.B19AF18C.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(396, 32);
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
		this.btnMinimize.Location = new System.Drawing.Point(364, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Thêm thư mục";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F127503C.BackColor = System.Drawing.Color.Maroon;
		this.F127503C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F127503C.FlatAppearance.BorderSize = 0;
		this.F127503C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F127503C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F127503C.ForeColor = System.Drawing.Color.White;
		this.F127503C.Location = new System.Drawing.Point(204, 105);
		this.F127503C.Name = "btnCancel";
		this.F127503C.Size = new System.Drawing.Size(92, 29);
		this.F127503C.TabIndex = 4;
		this.F127503C.Text = "Hủy";
		this.F127503C.UseVisualStyleBackColor = false;
		this.F127503C.Click += new System.EventHandler(F127503C_Click);
		this.E312441B.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.E312441B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E312441B.FlatAppearance.BorderSize = 0;
		this.E312441B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E312441B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E312441B.ForeColor = System.Drawing.Color.White;
		this.E312441B.Location = new System.Drawing.Point(100, 105);
		this.E312441B.Name = "btnAdd";
		this.E312441B.Size = new System.Drawing.Size(92, 29);
		this.E312441B.TabIndex = 3;
		this.E312441B.Text = "Thêm";
		this.E312441B.UseVisualStyleBackColor = false;
		this.E312441B.Click += new System.EventHandler(BC096018);
		this.B61D98AA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.B61D98AA.Location = new System.Drawing.Point(33, 69);
		this.B61D98AA.Name = "label1";
		this.B61D98AA.Size = new System.Drawing.Size(86, 16);
		this.B61D98AA.TabIndex = 20;
		this.B61D98AA.Text = "Tên thư mu\u0323c:";
		this.B61D98AA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.BB3B76AB.Location = new System.Drawing.Point(125, 66);
		this.BB3B76AB.Name = "txbNameFile";
		this.BB3B76AB.Size = new System.Drawing.Size(234, 23);
		this.BB3B76AB.TabIndex = 2;
		this.BB3B76AB.KeyDown += new System.Windows.Forms.KeyEventHandler(BB3B76AB_KeyDown);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(this.B61D98AA);
		base.Controls.Add(this.F127503C);
		base.Controls.Add(this.E312441B);
		base.Controls.Add(this.BB3B76AB);
		base.Controls.Add(this.B19AF18C);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fAddFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		this.B19AF18C.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
