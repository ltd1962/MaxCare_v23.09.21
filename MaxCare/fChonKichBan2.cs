using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonKichBan2 : Form
{
	public string string_0 = "";

	private IContainer E5013113 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel BC28E819;

	private Button btnMinimize;

	private Button btnCancel;

	private Button BC15D60A;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private ComboBox cbbKichBan;

	private Button B5B48034;

	private Label label1;

	private Panel panel1;

	public fChonKichBan2()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void C4066B14(object sender, EventArgs e)
	{
		Close();
	}

	private void BC15D60A_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.ShowMessages(string.Format(Language.GetValue("Bạn có thực sự muốn chọn kịch bản [{0}] không?"), cbbKichBan.Text)) == DialogResult.Yes)
		{
			string_0 = cbbKichBan.SelectedValue.ToString();
			Close();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B5B48034_Click(object sender, EventArgs e)
	{
		string text = "";
		try
		{
			if (cbbKichBan.Items.Count > 0)
			{
				text = cbbKichBan.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		Common.ShowForm(new fDanhSachKichBan_Old(text));
		FDB1DB19();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void BB2C0905(object sender, EventArgs e)
	{
	}

	private void CC22689D()
	{
		method_0(null, null);
		BB2C0905(null, null);
		F19E399C(null, null);
		E12AF185(null, null);
		D99FDD36(null, null);
		method_1(null, null);
		E4A71D03(null, null);
	}

	private void A62B3888(object sender, EventArgs e)
	{
		FDB1DB19();
		CC22689D();
	}

	private void FDB1DB19()
	{
		int num = -1;
		if (cbbKichBan.SelectedIndex != -1)
		{
			num = cbbKichBan.SelectedIndex;
		}
		DataTable dataSource = InteractSQL.GetAllKichBan();
		cbbKichBan.DataSource = dataSource;
		cbbKichBan.ValueMember = "Id_KichBan";
		cbbKichBan.DisplayMember = "Ten";
		if (num != -1 && num != 0 && cbbKichBan.Items.Count >= num + 1)
		{
			cbbKichBan.SelectedIndex = num;
		}
		else if (cbbKichBan.Items.Count > 0)
		{
			cbbKichBan.SelectedIndex = 0;
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void E12AF185(object sender, EventArgs e)
	{
	}

	private void F19E399C(object sender, EventArgs e)
	{
	}

	private void D99FDD36(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void E4A71D03(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E5013113 != null)
		{
			E5013113.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.E5013113 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonKichBan2));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.BC28E819 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.btnCancel = new System.Windows.Forms.Button();
		this.BC15D60A = new System.Windows.Forms.Button();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.E5013113);
		this.label1 = new System.Windows.Forms.Label();
		this.B5B48034 = new System.Windows.Forms.Button();
		this.cbbKichBan = new System.Windows.Forms.ComboBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.FromArgb(24, 119, 242);
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(2, 1);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(434, 38);
		this.bunifuCards1.TabIndex = 0;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.BC28E819);
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(434, 32);
		this.pnlHeader.TabIndex = 9;
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 78;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(400, -2);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 9;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(C4066B14);
		this.BC28E819.BackColor = System.Drawing.Color.Transparent;
		this.BC28E819.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BC28E819.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BC28E819.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BC28E819.ForeColor = System.Drawing.Color.Black;
		this.BC28E819.Location = new System.Drawing.Point(0, 0);
		this.BC28E819.Name = "bunifuCustomLabel1";
		this.BC28E819.Size = new System.Drawing.Size(434, 32);
		this.BC28E819.TabIndex = 1;
		this.BC28E819.Text = "Chọn kịch bản";
		this.BC28E819.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(222, 96);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.BC15D60A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.BC15D60A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.BC15D60A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BC15D60A.FlatAppearance.BorderSize = 0;
		this.BC15D60A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BC15D60A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BC15D60A.ForeColor = System.Drawing.Color.White;
		this.BC15D60A.Location = new System.Drawing.Point(124, 96);
		this.BC15D60A.Name = "btnAdd";
		this.BC15D60A.Size = new System.Drawing.Size(92, 29);
		this.BC15D60A.TabIndex = 3;
		this.BC15D60A.Text = "Lưu";
		this.BC15D60A.UseVisualStyleBackColor = false;
		this.BC15D60A.Click += new System.EventHandler(BC15D60A_Click);
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.BC28E819;
		this.bunifuDragControl_0.Vertical = true;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(25, 59);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(92, 16);
		this.label1.TabIndex = 0;
		this.label1.Text = "Chọn kịch bản:";
		this.B5B48034.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5B48034.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.B5B48034.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B5B48034.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B5B48034.Location = new System.Drawing.Point(294, 56);
		this.B5B48034.Name = "btnQuanLyKichBan";
		this.B5B48034.Size = new System.Drawing.Size(112, 24);
		this.B5B48034.TabIndex = 1;
		this.B5B48034.Text = "Quản lý kịch bản";
		this.B5B48034.Click += new System.EventHandler(B5B48034_Click);
		this.cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbKichBan.DropDownWidth = 300;
		this.cbbKichBan.FormattingEnabled = true;
		this.cbbKichBan.Location = new System.Drawing.Point(124, 56);
		this.cbbKichBan.Name = "cbbKichBan";
		this.cbbKichBan.Size = new System.Drawing.Size(164, 24);
		this.cbbKichBan.TabIndex = 1;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.BC15D60A);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.cbbKichBan);
		this.panel1.Controls.Add(this.B5B48034);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(436, 138);
		this.panel1.TabIndex = 8;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(436, 138);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonKichBan2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "fAddFile";
		base.Load += new System.EventHandler(A62B3888);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
	}
}
