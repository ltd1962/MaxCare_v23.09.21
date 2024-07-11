using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTaoShortcut : Form
{
	public static bool bool_0;

	private string CF39EBBB = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel CF0C2036;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl CD87B496;

	private PictureBox pictureBox1;

	private Label label1;

	private TextBox txtPathShortcut;

	private Button metroButton1;

	private Label CA1AAF34;

	private TextBox E0BFB9B3;

	private Button metroButton2;

	public fCauHinhTaoShortcut()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
		string text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		string text2 = "C:\\Program Files (x64)\\Google\\Chrome\\Application\\chrome.exe";
		string text3 = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
		if (!File.Exists(text))
		{
			if (!File.Exists(text2))
			{
				if (File.Exists(text3))
				{
					CF39EBBB = text3;
				}
			}
			else
			{
				CF39EBBB = text2;
			}
		}
		else
		{
			CF39EBBB = text;
		}
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(metroButton1);
		Language.smethod_0(CA1AAF34);
		Language.smethod_0(metroButton2);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F9B5AC0D(object sender, EventArgs e)
	{
		if (txtPathShortcut.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n Thư mu\u0323c lưu Shortcut!", 3);
			return;
		}
		if (E0BFB9B3.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n chrome.exe!", 3);
			return;
		}
		if (!E0BFB9B3.Text.Trim().EndsWith("chrome.exe"))
		{
			MessageBoxHelper.Show("Đươ\u0300ng dâ\u0303n đê\u0301n chrome.exe không hơ\u0323p lê\u0323!", 3);
			return;
		}
		SettingsTool.GetSettings("configInteractGeneral").GetJson("txtPathShortcut", txtPathShortcut.Text.Trim());
		SettingsTool.GetSettings("configInteractGeneral").GetJson("txtPathChromeOrigin", E0BFB9B3.Text.Trim());
		SettingsTool.Save("configInteractGeneral");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DD9B0F9A(object sender, EventArgs e)
	{
	}

	private void D48DD126(object sender, EventArgs e)
	{
		txtPathShortcut.Text = SettingsTool.GetSettings("configInteractGeneral").GetValue("txtPathShortcut");
		if (txtPathShortcut.Text.Trim() == "" || !Directory.Exists(txtPathShortcut.Text.Trim()))
		{
			txtPathShortcut.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}
		if (File.Exists(SettingsTool.GetSettings("configInteractGeneral").GetValue("txtPathChromeOrigin")))
		{
			E0BFB9B3.Text = SettingsTool.GetSettings("configInteractGeneral").GetValue("txtPathChromeOrigin");
		}
		else
		{
			E0BFB9B3.Text = CF39EBBB;
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		txtPathShortcut.Text = Common.SelectFolder();
	}

	private void C50886B0(object sender, EventArgs e)
	{
		E0BFB9B3.Text = Common.SelectFile(Language.GetValue("Cho\u0323n File"), "");
	}

	protected override void Dispose(bool A3183000)
	{
		if (A3183000 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A3183000);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTaoShortcut));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.CF0C2036 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.CD87B496 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.label1 = new System.Windows.Forms.Label();
		this.txtPathShortcut = new System.Windows.Forms.TextBox();
		this.metroButton1 = new System.Windows.Forms.Button();
		this.CA1AAF34 = new System.Windows.Forms.Label();
		this.E0BFB9B3 = new System.Windows.Forms.TextBox();
		this.metroButton2 = new System.Windows.Forms.Button();
		this.bunifuCards1.SuspendLayout();
		this.CF0C2036.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.CF0C2036);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(594, 38);
		this.bunifuCards1.TabIndex = 0;
		this.CF0C2036.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CF0C2036.BackColor = System.Drawing.Color.White;
		this.CF0C2036.Controls.Add(this.pictureBox1);
		this.CF0C2036.Controls.Add(this.btnMinimize);
		this.CF0C2036.Controls.Add(this.bunifuCustomLabel1);
		this.CF0C2036.Location = new System.Drawing.Point(0, 5);
		this.CF0C2036.Name = "pnlHeader";
		this.CF0C2036.Size = new System.Drawing.Size(594, 32);
		this.CF0C2036.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 17;
		this.pictureBox1.TabStop = false;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(562, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(594, 32);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh ta\u0323o Shortcut Chrome";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(303, 139);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(199, 139);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(F9B5AC0D);
		this.CD87B496.Fixed = true;
		this.CD87B496.Horizontal = true;
		this.CD87B496.TargetControl = this.bunifuCustomLabel1;
		this.CD87B496.Vertical = true;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(33, 60);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(104, 16);
		this.label1.TabIndex = 5;
		this.label1.Text = "Nơi lưu Shortcut:";
		this.txtPathShortcut.Location = new System.Drawing.Point(157, 58);
		this.txtPathShortcut.Name = "txtPathShortcut";
		this.txtPathShortcut.Size = new System.Drawing.Size(352, 23);
		this.txtPathShortcut.TabIndex = 6;
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(515, 58);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(47, 24);
		this.metroButton1.TabIndex = 7;
		this.metroButton1.Text = "Cho\u0323n";
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.CA1AAF34.AutoSize = true;
		this.CA1AAF34.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.CA1AAF34.Location = new System.Drawing.Point(33, 91);
		this.CA1AAF34.Name = "label2";
		this.CA1AAF34.Size = new System.Drawing.Size(124, 16);
		this.CA1AAF34.TabIndex = 5;
		this.CA1AAF34.Text = "Đươ\u0300ng dâ\u0303n Chrome:";
		this.E0BFB9B3.Location = new System.Drawing.Point(157, 89);
		this.E0BFB9B3.Name = "txtPathChromeOrigin";
		this.E0BFB9B3.Size = new System.Drawing.Size(352, 23);
		this.E0BFB9B3.TabIndex = 6;
		this.E0BFB9B3.Text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton2.Location = new System.Drawing.Point(515, 89);
		this.metroButton2.Name = "metroButton2";
		this.metroButton2.Size = new System.Drawing.Size(47, 24);
		this.metroButton2.TabIndex = 7;
		this.metroButton2.Text = "Cho\u0323n";
		this.metroButton2.Click += new System.EventHandler(C50886B0);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(594, 187);
		base.Controls.Add(this.metroButton2);
		base.Controls.Add(this.metroButton1);
		base.Controls.Add(this.E0BFB9B3);
		base.Controls.Add(this.CA1AAF34);
		base.Controls.Add(this.txtPathShortcut);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTaoShortcut";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(D48DD126);
		this.bunifuCards1.ResumeLayout(false);
		this.CF0C2036.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
