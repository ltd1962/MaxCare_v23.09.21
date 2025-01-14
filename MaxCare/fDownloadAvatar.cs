using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDownloadAvatar : Form
{
	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel C5974433;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Button metroButton1;

	private TextBox txtPathFolder;

	private Label label1;

	private CheckBox ckbUseProxy;

	public fDownloadAvatar()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configGeneral").GetJson("pathFolderAvatar", txtPathFolder.Text);
		SettingsTool.GetSettings("configGeneral").GetJson("ckbDownAvatarUseProxy", ckbUseProxy.Checked);
		SettingsTool.Save("configGeneral");
		bool_0 = true;
		Close();
	}

	private void DB8F26A2(object sender, EventArgs e)
	{
		Close();
	}

	private void DF28AD1E(object sender, EventArgs e)
	{
		txtPathFolder.Text = SettingsTool.GetSettings("configGeneral").GetValue("pathFolderAvatar");
		ckbUseProxy.Checked = SettingsTool.GetSettings("configGeneral").GetValueBool("ckbDownAvatarUseProxy");
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		txtPathFolder.Text = Common.SelectFolder();
	}

	protected override void Dispose(bool D8234582)
	{
		if (D8234582 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D8234582);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDownloadAvatar));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.C5974433 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.metroButton1 = new System.Windows.Forms.Button();
		this.txtPathFolder = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.ckbUseProxy = new System.Windows.Forms.CheckBox();
		this.bunifuCards1.SuspendLayout();
		this.C5974433.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.C5974433);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(449, 34);
		this.bunifuCards1.TabIndex = 0;
		this.C5974433.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C5974433.BackColor = System.Drawing.Color.White;
		this.C5974433.Controls.Add(this.pictureBox1);
		this.C5974433.Controls.Add(this.btnMinimize);
		this.C5974433.Controls.Add(this.bunifuCustomLabel1);
		this.C5974433.Location = new System.Drawing.Point(0, 3);
		this.C5974433.Name = "pnlHeader";
		this.C5974433.Size = new System.Drawing.Size(449, 28);
		this.C5974433.TabIndex = 9;
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
		this.btnMinimize.Location = new System.Drawing.Point(417, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 28);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(449, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Cấu hình Tải xuống avatar";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(231, 122);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(DB8F26A2);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(127, 122);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.metroButton1.Location = new System.Drawing.Point(349, 56);
		this.metroButton1.Name = "metroButton1";
		this.metroButton1.Size = new System.Drawing.Size(61, 23);
		this.metroButton1.TabIndex = 37;
		this.metroButton1.Text = "Chọn";
		this.metroButton1.Click += new System.EventHandler(metroButton1_Click);
		this.txtPathFolder.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtPathFolder.Location = new System.Drawing.Point(147, 56);
		this.txtPathFolder.Name = "txtPathFolder";
		this.txtPathFolder.Size = new System.Drawing.Size(196, 23);
		this.txtPathFolder.TabIndex = 35;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(31, 59);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(93, 16);
		this.label1.TabIndex = 36;
		this.label1.Text = "Nơi lưu Avatar:";
		this.ckbUseProxy.AutoSize = true;
		this.ckbUseProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ckbUseProxy.Location = new System.Drawing.Point(34, 85);
		this.ckbUseProxy.Name = "ckbUseProxy";
		this.ckbUseProxy.Size = new System.Drawing.Size(281, 20);
		this.ckbUseProxy.TabIndex = 38;
		this.ckbUseProxy.Text = "Sử dụng proxy đã gán mỗi tài khoản để chạy";
		this.ckbUseProxy.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 166);
		base.Controls.Add(this.ckbUseProxy);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.txtPathFolder);
		base.Controls.Add(this.metroButton1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fDownloadAvatar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(DF28AD1E);
		this.bunifuCards1.ResumeLayout(false);
		this.C5974433.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
