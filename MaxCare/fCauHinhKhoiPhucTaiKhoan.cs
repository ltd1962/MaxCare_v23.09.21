using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhKhoiPhucTaiKhoan : Form
{
	public static bool B40D8608 = false;

	public static int A9177C27 = 0;

	public static string C5292A37 = "";

	private int int_0 = 0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel ED035EA6;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button DD9CF6A6;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private RadioButton rbThuMucCu;

	private RadioButton rbThuMucKhac;

	private Button button1;

	private ComboBox cbbThuMuc;

	private Panel plThuMucKhac;

	public fCauHinhKhoiPhucTaiKhoan()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		method_0();
		B40D8608 = false;
		A9177C27 = 0;
		C5292A37 = "";
	}

	private void C9157584()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(rbThuMucCu);
		Language.smethod_0(rbThuMucKhac);
		Language.smethod_0(button1);
		Language.smethod_0(DD9CF6A6);
		Language.smethod_0(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DD9CF6A6_Click(object sender, EventArgs e)
	{
		if (rbThuMucKhac.Checked)
		{
			if (cbbThuMuc.SelectedIndex == -1)
			{
				MessageBoxHelper.Show("Vui lòng thêm thư mục để lưu tài khoản!", 3);
				return;
			}
			A9177C27 = 1;
			C5292A37 = cbbThuMuc.SelectedValue.ToString();
		}
		B40D8608 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F5AB9E10(object sender, EventArgs e)
	{
		E400DE83(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		Common.ShowForm(form_);
		if (fAddFile.bool_0)
		{
			method_0();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 1;
		}
	}

	private void method_0()
	{
		int_0 = cbbThuMuc.SelectedIndex;
		DataTable dataTable = CommonSQL.C6B3348F();
		if (dataTable.Rows.Count > 0)
		{
			cbbThuMuc.DataSource = dataTable;
			cbbThuMuc.ValueMember = "id";
			cbbThuMuc.DisplayMember = "name";
			if (int_0 == -1)
			{
				int_0 = 0;
			}
			cbbThuMuc.SelectedIndex = int_0;
		}
	}

	private void E400DE83(object sender, EventArgs e)
	{
		plThuMucKhac.Enabled = rbThuMucKhac.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhKhoiPhucTaiKhoan));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.ED035EA6 = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.DD9CF6A6 = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.rbThuMucCu = new System.Windows.Forms.RadioButton();
		this.rbThuMucKhac = new System.Windows.Forms.RadioButton();
		this.button1 = new System.Windows.Forms.Button();
		this.cbbThuMuc = new System.Windows.Forms.ComboBox();
		this.plThuMucKhac = new System.Windows.Forms.Panel();
		this.bunifuCards1.SuspendLayout();
		this.ED035EA6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.plThuMucKhac.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.ED035EA6);
		this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(365, 34);
		this.bunifuCards1.TabIndex = 0;
		this.ED035EA6.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.ED035EA6.BackColor = System.Drawing.Color.White;
		this.ED035EA6.Controls.Add(this.pictureBox1);
		this.ED035EA6.Controls.Add(this.btnMinimize);
		this.ED035EA6.Controls.Add(this.bunifuCustomLabel1);
		this.ED035EA6.Location = new System.Drawing.Point(0, 3);
		this.ED035EA6.Name = "pnlHeader";
		this.ED035EA6.Size = new System.Drawing.Size(365, 28);
		this.ED035EA6.TabIndex = 9;
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
		this.btnMinimize.Location = new System.Drawing.Point(333, 0);
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(365, 28);
		this.bunifuCustomLabel1.TabIndex = 1;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Khôi phu\u0323c ta\u0300i khoa\u0309n";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(188, 162);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đo\u0301ng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.DD9CF6A6.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.DD9CF6A6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD9CF6A6.FlatAppearance.BorderSize = 0;
		this.DD9CF6A6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DD9CF6A6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DD9CF6A6.ForeColor = System.Drawing.Color.White;
		this.DD9CF6A6.Location = new System.Drawing.Point(84, 162);
		this.DD9CF6A6.Name = "btnAdd";
		this.DD9CF6A6.Size = new System.Drawing.Size(92, 29);
		this.DD9CF6A6.TabIndex = 3;
		this.DD9CF6A6.Text = "Lưu";
		this.DD9CF6A6.UseVisualStyleBackColor = false;
		this.DD9CF6A6.Click += new System.EventHandler(DD9CF6A6_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.rbThuMucCu.AutoSize = true;
		this.rbThuMucCu.Checked = true;
		this.rbThuMucCu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbThuMucCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbThuMucCu.Location = new System.Drawing.Point(36, 56);
		this.rbThuMucCu.Name = "rbThuMucCu";
		this.rbThuMucCu.Size = new System.Drawing.Size(165, 20);
		this.rbThuMucCu.TabIndex = 5;
		this.rbThuMucCu.TabStop = true;
		this.rbThuMucCu.Text = "Khôi phu\u0323c vê\u0300 thư mu\u0323c cu\u0303";
		this.rbThuMucCu.UseVisualStyleBackColor = true;
		this.rbThuMucKhac.AutoSize = true;
		this.rbThuMucKhac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbThuMucKhac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.rbThuMucKhac.Location = new System.Drawing.Point(36, 82);
		this.rbThuMucKhac.Name = "rbThuMucKhac";
		this.rbThuMucKhac.Size = new System.Drawing.Size(179, 20);
		this.rbThuMucKhac.TabIndex = 5;
		this.rbThuMucKhac.Text = "Chuyê\u0309n sang thư mu\u0323c kha\u0301c";
		this.rbThuMucKhac.UseVisualStyleBackColor = true;
		this.rbThuMucKhac.CheckedChanged += new System.EventHandler(E400DE83);
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.Location = new System.Drawing.Point(210, 2);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(62, 27);
		this.button1.TabIndex = 48;
		this.button1.Text = "Thêm";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbThuMuc.DropDownWidth = 269;
		this.cbbThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.cbbThuMuc.FormattingEnabled = true;
		this.cbbThuMuc.Location = new System.Drawing.Point(3, 3);
		this.cbbThuMuc.Name = "cbbThuMuc";
		this.cbbThuMuc.Size = new System.Drawing.Size(201, 24);
		this.cbbThuMuc.TabIndex = 47;
		this.plThuMucKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plThuMucKhac.Controls.Add(this.cbbThuMuc);
		this.plThuMucKhac.Controls.Add(this.button1);
		this.plThuMucKhac.Location = new System.Drawing.Point(55, 108);
		this.plThuMucKhac.Name = "plThuMucKhac";
		this.plThuMucKhac.Size = new System.Drawing.Size(278, 33);
		this.plThuMucKhac.TabIndex = 49;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(365, 205);
		base.Controls.Add(this.plThuMucKhac);
		base.Controls.Add(this.rbThuMucKhac);
		base.Controls.Add(this.rbThuMucCu);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.DD9CF6A6);
		base.Controls.Add(this.bunifuCards1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhKhoiPhucTaiKhoan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(F5AB9E10);
		this.bunifuCards1.ResumeLayout(false);
		this.ED035EA6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.plThuMucKhac.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
