using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChuyenThuMuc : Form
{
	public string string_0 = "";

	public string string_1 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel CFA05D19;

	private BunifuCustomLabel AC34FA13;

	private Button FAB2DA1F;

	private ComboBox F2A33319;

	private Label C7B3D38D;

	private Button A1833D0A;

	private Button C287FE94;

	private PictureBox pictureBox1;

	private Button button1;

	public fChuyenThuMuc()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		string_0 = "";
		string_1 = "";
	}

	private void C1383209(object sender, EventArgs e)
	{
		Close();
	}

	private void A1833D0A_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C287FE94_Click(object sender, EventArgs e)
	{
		string_0 = F2A33319.SelectedValue.ToString();
		string_1 = F2A33319.Text.ToString();
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		Common.ShowForm(form_);
		if (fAddFile.bool_0)
		{
			FE200107();
			F2A33319.SelectedIndex = F2A33319.Items.Count - 1;
		}
	}

	private void FE200107()
	{
		DataTable dataTable = CommonSQL.smethod_1();
		if (dataTable.Rows.Count > 0)
		{
			F2A33319.DataSource = dataTable;
			F2A33319.ValueMember = "id";
			F2A33319.DisplayMember = "Ten";
		}
	}

	private void fChuyenThuMuc_Load(object sender, EventArgs e)
	{
		FE200107();
	}

	protected override void Dispose(bool F2BA0394)
	{
		if (F2BA0394 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F2BA0394);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChuyenThuMuc));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.CFA05D19 = new System.Windows.Forms.Panel();
		this.FAB2DA1F = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.AC34FA13 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F2A33319 = new System.Windows.Forms.ComboBox();
		this.C7B3D38D = new System.Windows.Forms.Label();
		this.A1833D0A = new System.Windows.Forms.Button();
		this.C287FE94 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.bunifuCards1.SuspendLayout();
		this.CFA05D19.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 5;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.CFA05D19);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(416, 38);
		this.bunifuCards1.TabIndex = 12;
		this.CFA05D19.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CFA05D19.BackColor = System.Drawing.Color.White;
		this.CFA05D19.Controls.Add(this.FAB2DA1F);
		this.CFA05D19.Controls.Add(this.pictureBox1);
		this.CFA05D19.Controls.Add(this.AC34FA13);
		this.CFA05D19.Location = new System.Drawing.Point(0, 5);
		this.CFA05D19.Name = "pnlHeader";
		this.CFA05D19.Size = new System.Drawing.Size(416, 32);
		this.CFA05D19.TabIndex = 9;
		this.FAB2DA1F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FAB2DA1F.FlatAppearance.BorderSize = 0;
		this.FAB2DA1F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FAB2DA1F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FAB2DA1F.ForeColor = System.Drawing.Color.White;
		this.FAB2DA1F.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.FAB2DA1F.Location = new System.Drawing.Point(382, -1);
		this.FAB2DA1F.Name = "btnMinimize";
		this.FAB2DA1F.Size = new System.Drawing.Size(32, 32);
		this.FAB2DA1F.TabIndex = 9;
		this.FAB2DA1F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.FAB2DA1F.UseVisualStyleBackColor = true;
		this.FAB2DA1F.Click += new System.EventHandler(C1383209);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 79;
		this.pictureBox1.TabStop = false;
		this.AC34FA13.BackColor = System.Drawing.Color.Transparent;
		this.AC34FA13.Dock = System.Windows.Forms.DockStyle.Fill;
		this.AC34FA13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AC34FA13.ForeColor = System.Drawing.Color.Black;
		this.AC34FA13.Location = new System.Drawing.Point(0, 0);
		this.AC34FA13.Name = "bunifuCustomLabel1";
		this.AC34FA13.Size = new System.Drawing.Size(416, 32);
		this.AC34FA13.TabIndex = 12;
		this.AC34FA13.Text = "Chọn thư mục";
		this.AC34FA13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F2A33319.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F2A33319.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.F2A33319.DropDownWidth = 350;
		this.F2A33319.FormattingEnabled = true;
		this.F2A33319.ItemHeight = 16;
		this.F2A33319.Items.AddRange(new object[10] { "Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes" });
		this.F2A33319.Location = new System.Drawing.Point(111, 66);
		this.F2A33319.Name = "cbbThuMuc";
		this.F2A33319.Size = new System.Drawing.Size(190, 24);
		this.F2A33319.TabIndex = 13;
		this.C7B3D38D.AutoSize = true;
		this.C7B3D38D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C7B3D38D.Location = new System.Drawing.Point(42, 69);
		this.C7B3D38D.Name = "label1";
		this.C7B3D38D.Size = new System.Drawing.Size(63, 16);
		this.C7B3D38D.TabIndex = 14;
		this.C7B3D38D.Text = "Thư mục:";
		this.A1833D0A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.A1833D0A.BackColor = System.Drawing.Color.Maroon;
		this.A1833D0A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1833D0A.FlatAppearance.BorderSize = 0;
		this.A1833D0A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A1833D0A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A1833D0A.ForeColor = System.Drawing.Color.White;
		this.A1833D0A.Location = new System.Drawing.Point(209, 108);
		this.A1833D0A.Name = "btnCancel";
		this.A1833D0A.Size = new System.Drawing.Size(92, 29);
		this.A1833D0A.TabIndex = 18;
		this.A1833D0A.Text = "Đóng";
		this.A1833D0A.UseVisualStyleBackColor = false;
		this.A1833D0A.Click += new System.EventHandler(A1833D0A_Click);
		this.C287FE94.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C287FE94.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C287FE94.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C287FE94.FlatAppearance.BorderSize = 0;
		this.C287FE94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C287FE94.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C287FE94.ForeColor = System.Drawing.Color.White;
		this.C287FE94.Location = new System.Drawing.Point(111, 108);
		this.C287FE94.Name = "btnAdd";
		this.C287FE94.Size = new System.Drawing.Size(92, 29);
		this.C287FE94.TabIndex = 17;
		this.C287FE94.Text = "Lưu";
		this.C287FE94.UseVisualStyleBackColor = false;
		this.C287FE94.Click += new System.EventHandler(C287FE94_Click);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Location = new System.Drawing.Point(307, 65);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(58, 26);
		this.button1.TabIndex = 19;
		this.button1.Text = "Thêm";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(416, 150);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.A1833D0A);
		base.Controls.Add(this.C287FE94);
		base.Controls.Add(this.C7B3D38D);
		base.Controls.Add(this.F2A33319);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChuyenThuMuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fUpdateData";
		base.Load += new System.EventHandler(fChuyenThuMuc_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.CFA05D19.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
