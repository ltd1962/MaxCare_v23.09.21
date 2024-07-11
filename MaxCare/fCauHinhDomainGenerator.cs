using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhDomainGenerator : Form
{
	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private Button F3161427;

	private Button btnAdd;

	private BunifuDragControl B20ECD22;

	private BunifuCards FCAEF933;

	private Button btnClose;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D0B8D807;

	private Panel panel2;

	private RichTextBox txtPass;

	private Label lblTitle;

	public fCauHinhDomainGenerator()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configGeneral").GetJson("txtGeneratorDomain", txtPass.Text.Trim());
		SettingsTool.Save("configGeneral");
		bool_0 = true;
		Close();
	}

	private void F3161427_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhDomainGenerator_Load(object sender, EventArgs e)
	{
		txtPass.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtGeneratorDomain");
		D2AE80A7(null, null);
	}

	private void D2AE80A7(object sender, EventArgs e)
	{
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void txtPass_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtPass, lblTitle);
	}

	protected override void Dispose(bool D8152D85)
	{
		if (D8152D85 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D8152D85);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.F3161427 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.B20ECD22 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D0B8D807 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.FCAEF933 = new Bunifu.Framework.UI.BunifuCards();
		this.btnClose = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.txtPass = new System.Windows.Forms.RichTextBox();
		this.lblTitle = new System.Windows.Forms.Label();
		this.FCAEF933.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.F3161427.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F3161427.BackColor = System.Drawing.Color.Maroon;
		this.F3161427.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F3161427.FlatAppearance.BorderSize = 0;
		this.F3161427.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F3161427.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F3161427.ForeColor = System.Drawing.Color.White;
		this.F3161427.Location = new System.Drawing.Point(172, 251);
		this.F3161427.Name = "btnCancel";
		this.F3161427.Size = new System.Drawing.Size(92, 29);
		this.F3161427.TabIndex = 4;
		this.F3161427.Text = "Đo\u0301ng";
		this.F3161427.UseVisualStyleBackColor = false;
		this.F3161427.Click += new System.EventHandler(F3161427_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(68, 251);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Lưu";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.B20ECD22.Fixed = true;
		this.B20ECD22.Horizontal = true;
		this.B20ECD22.TargetControl = this.D0B8D807;
		this.B20ECD22.Vertical = true;
		this.D0B8D807.BackColor = System.Drawing.Color.Transparent;
		this.D0B8D807.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D0B8D807.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D0B8D807.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D0B8D807.ForeColor = System.Drawing.Color.Black;
		this.D0B8D807.Location = new System.Drawing.Point(0, 0);
		this.D0B8D807.Name = "bunifuCustomLabel1";
		this.D0B8D807.Size = new System.Drawing.Size(330, 38);
		this.D0B8D807.TabIndex = 12;
		this.D0B8D807.Text = "Cấu hình Domain Generator";
		this.D0B8D807.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FCAEF933.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.FCAEF933.BackColor = System.Drawing.Color.White;
		this.FCAEF933.BorderRadius = 0;
		this.FCAEF933.BottomSahddow = true;
		this.FCAEF933.color = System.Drawing.Color.DarkViolet;
		this.FCAEF933.Controls.Add(this.btnClose);
		this.FCAEF933.Controls.Add(this.pictureBox1);
		this.FCAEF933.Controls.Add(this.D0B8D807);
		this.FCAEF933.LeftSahddow = false;
		this.FCAEF933.Location = new System.Drawing.Point(1, 0);
		this.FCAEF933.Name = "bunifuCards1";
		this.FCAEF933.RightSahddow = true;
		this.FCAEF933.ShadowDepth = 20;
		this.FCAEF933.Size = new System.Drawing.Size(330, 38);
		this.FCAEF933.TabIndex = 29;
		this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnClose.FlatAppearance.BorderSize = 0;
		this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnClose.ForeColor = System.Drawing.Color.White;
		this.btnClose.Image = Resources.A13F2207;
		this.btnClose.Location = new System.Drawing.Point(298, 5);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new System.Drawing.Size(30, 30);
		this.btnClose.TabIndex = 77;
		this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnClose.UseVisualStyleBackColor = true;
		this.btnClose.Click += new System.EventHandler(btnClose_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(2, 6);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.txtPass);
		this.panel2.Controls.Add(this.lblTitle);
		this.panel2.Controls.Add(this.FCAEF933);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(332, 292);
		this.panel2.TabIndex = 30;
		this.txtPass.Location = new System.Drawing.Point(34, 69);
		this.txtPass.Name = "txtPass";
		this.txtPass.Size = new System.Drawing.Size(267, 170);
		this.txtPass.TabIndex = 31;
		this.txtPass.Text = "";
		this.txtPass.WordWrap = false;
		this.txtPass.TextChanged += new System.EventHandler(txtPass_TextChanged);
		this.lblTitle.AutoSize = true;
		this.lblTitle.Location = new System.Drawing.Point(31, 50);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(138, 16);
		this.lblTitle.TabIndex = 30;
		this.lblTitle.Text = "Danh sách domain (0):";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(332, 292);
		base.Controls.Add(this.F3161427);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.panel2);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhDomainGenerator";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhDomainGenerator_Load);
		this.FCAEF933.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		base.ResumeLayout(false);
	}
}
