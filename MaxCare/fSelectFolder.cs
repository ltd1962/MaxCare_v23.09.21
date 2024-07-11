using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fSelectFolder : Form
{
	public static string A6B9FE13 = "";

	private IContainer CE83C780 = null;

	private BunifuCards bunifuCards1;

	private Panel D59E9396;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button E839B001;

	private Button EE36CD9C;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox A78FBCBE;

	private Label label2;

	private TextBox FA8C9039;

	public fSelectFolder()
	{
		F9ACCEA3();
		Language.SetLanguage(this);
		A6B9FE13 = "";
	}

	private void D30EBFB2()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label2);
		Language.smethod_0(btnAdd);
		Language.smethod_0(EE36CD9C);
	}

	private void D6BA6D9A(object sender, EventArgs e)
	{
		Close();
	}

	private void D6BBCB3A(object sender, EventArgs e)
	{
		A6B9FE13 = FA8C9039.Text.Trim();
		if (A6B9FE13 == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n Folder!", 2);
			FA8C9039.Focus();
		}
		else
		{
			Close();
		}
	}

	private void FFBE919C(object sender, EventArgs e)
	{
		Close();
	}

	private void fSelectFolder_Load(object sender, EventArgs e)
	{
		A6B9FE13 = "";
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && CE83C780 != null)
		{
			CE83C780.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void F9ACCEA3()
	{
		CE83C780 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fSelectFolder));
		bunifuCards1 = new BunifuCards();
		D59E9396 = new Panel();
		A78FBCBE = new PictureBox();
		E839B001 = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		EE36CD9C = new Button();
		btnAdd = new Button();
		bunifuDragControl_0 = new BunifuDragControl(CE83C780);
		label2 = new Label();
		FA8C9039 = new TextBox();
		bunifuCards1.SuspendLayout();
		D59E9396.SuspendLayout();
		((ISupportInitialize)A78FBCBE).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(D59E9396);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(449, 34);
		bunifuCards1.TabIndex = 0;
		D59E9396.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		D59E9396.BackColor = Color.White;
		D59E9396.Controls.Add(A78FBCBE);
		D59E9396.Controls.Add(E839B001);
		D59E9396.Controls.Add(bunifuCustomLabel1);
		D59E9396.Location = new Point(0, 3);
		D59E9396.Name = "pnlHeader";
		D59E9396.Size = new Size(449, 28);
		D59E9396.TabIndex = 9;
		A78FBCBE.Cursor = Cursors.Default;
		A78FBCBE.Image = Resources.Bitmap_4;
		A78FBCBE.Location = new Point(3, 2);
		A78FBCBE.Name = "pictureBox1";
		A78FBCBE.Size = new Size(34, 27);
		A78FBCBE.SizeMode = PictureBoxSizeMode.Zoom;
		A78FBCBE.TabIndex = 17;
		A78FBCBE.TabStop = false;
		E839B001.Cursor = Cursors.Hand;
		E839B001.Dock = DockStyle.Right;
		E839B001.FlatAppearance.BorderSize = 0;
		E839B001.FlatStyle = FlatStyle.Flat;
		E839B001.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E839B001.ForeColor = Color.White;
		E839B001.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		E839B001.Location = new Point(417, 0);
		E839B001.Name = "btnMinimize";
		E839B001.Size = new Size(32, 28);
		E839B001.TabIndex = 9;
		E839B001.TextImageRelation = TextImageRelation.ImageBeforeText;
		E839B001.UseVisualStyleBackColor = true;
		E839B001.Click += D6BA6D9A;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cho\u0323n nơi lưu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		EE36CD9C.BackColor = Color.Maroon;
		EE36CD9C.Cursor = Cursors.Hand;
		EE36CD9C.FlatAppearance.BorderSize = 0;
		EE36CD9C.FlatStyle = FlatStyle.Flat;
		EE36CD9C.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		EE36CD9C.ForeColor = Color.White;
		EE36CD9C.Location = new Point(230, 108);
		EE36CD9C.Name = "btnCancel";
		EE36CD9C.Size = new Size(92, 29);
		EE36CD9C.TabIndex = 4;
		EE36CD9C.Text = "Đo\u0301ng";
		EE36CD9C.UseVisualStyleBackColor = false;
		EE36CD9C.Click += FFBE919C;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(126, 108);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += D6BBCB3A;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(31, 61);
		label2.Name = "label2";
		label2.Size = new Size(146, 16);
		label2.TabIndex = 36;
		label2.Text = "Nhâ\u0323p đươ\u0300ng dâ\u0303n Folder:";
		FA8C9039.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FA8C9039.Location = new Point(184, 58);
		FA8C9039.Name = "txtPathFolder";
		FA8C9039.Size = new Size(227, 23);
		FA8C9039.TabIndex = 35;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(449, 159);
		base.Controls.Add(label2);
		base.Controls.Add(FA8C9039);
		base.Controls.Add(EE36CD9C);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fSelectFolder";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += fSelectFolder_Load;
		bunifuCards1.ResumeLayout(performLayout: false);
		D59E9396.ResumeLayout(performLayout: false);
		((ISupportInitialize)A78FBCBE).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
