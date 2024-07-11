using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDAnMail : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string string_1;

	private string E52A0B24;

	private int int_0;

	public static bool bool_0;

	private IContainer E2250C2E = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button A1857099;

	private Button D78DF00E;

	private BunifuCards DF81403E;

	private Panel pnlHeader;

	private Button E30AAD25;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDAnMail(string C11F442D, int int_1 = 0, string F69FC685 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = C11F442D;
		E52A0B24 = F69FC685;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDAnMail").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDAnMail', 'Ẩn mail');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDAnMail");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(F69FC685);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			D78DF00E.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(D78DF00E);
		Language.smethod_0(A1857099);
	}

	private void DA1C1AA7_Load(object sender, EventArgs e)
	{
		try
		{
		}
		catch
		{
		}
	}

	private void E30AAD25_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AE37CF1B(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(E52A0B24, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void A1857099_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool FD17D78F)
	{
		if (FD17D78F && E2250C2E != null)
		{
			E2250C2E.Dispose();
		}
		base.Dispose(FD17D78F);
	}

	private void InitializeComponent()
	{
		this.E2250C2E = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDAnMail));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.E2250C2E);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.E2250C2E);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.E30AAD25 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.A1857099 = new System.Windows.Forms.Button();
		this.D78DF00E = new System.Windows.Forms.Button();
		this.DF81403E = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.DF81403E.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Ẩn mail";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.E30AAD25);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.E30AAD25.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.E30AAD25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E30AAD25.FlatAppearance.BorderSize = 0;
		this.E30AAD25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E30AAD25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E30AAD25.ForeColor = System.Drawing.Color.White;
		this.E30AAD25.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.E30AAD25.Location = new System.Drawing.Point(328, 1);
		this.E30AAD25.Name = "button1";
		this.E30AAD25.Size = new System.Drawing.Size(30, 30);
		this.E30AAD25.TabIndex = 77;
		this.E30AAD25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.E30AAD25.UseVisualStyleBackColor = true;
		this.E30AAD25.Click += new System.EventHandler(E30AAD25_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.A1857099);
		this.panel1.Controls.Add(this.D78DF00E);
		this.panel1.Controls.Add(this.DF81403E);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 160);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.A1857099.BackColor = System.Drawing.Color.Maroon;
		this.A1857099.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1857099.FlatAppearance.BorderSize = 0;
		this.A1857099.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A1857099.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A1857099.ForeColor = System.Drawing.Color.White;
		this.A1857099.Location = new System.Drawing.Point(189, 116);
		this.A1857099.Name = "btnCancel";
		this.A1857099.Size = new System.Drawing.Size(92, 29);
		this.A1857099.TabIndex = 10;
		this.A1857099.Text = "Đóng";
		this.A1857099.UseVisualStyleBackColor = false;
		this.A1857099.Click += new System.EventHandler(A1857099_Click);
		this.D78DF00E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.D78DF00E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D78DF00E.FlatAppearance.BorderSize = 0;
		this.D78DF00E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D78DF00E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D78DF00E.ForeColor = System.Drawing.Color.White;
		this.D78DF00E.Location = new System.Drawing.Point(82, 116);
		this.D78DF00E.Name = "btnAdd";
		this.D78DF00E.Size = new System.Drawing.Size(92, 29);
		this.D78DF00E.TabIndex = 9;
		this.D78DF00E.Text = "Thêm";
		this.D78DF00E.UseVisualStyleBackColor = false;
		this.D78DF00E.Click += new System.EventHandler(AE37CF1B);
		this.DF81403E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DF81403E.BackColor = System.Drawing.Color.White;
		this.DF81403E.BorderRadius = 0;
		this.DF81403E.BottomSahddow = true;
		this.DF81403E.color = System.Drawing.Color.DarkViolet;
		this.DF81403E.Controls.Add(this.pnlHeader);
		this.DF81403E.LeftSahddow = false;
		this.DF81403E.Location = new System.Drawing.Point(1, 0);
		this.DF81403E.Name = "bunifuCards1";
		this.DF81403E.RightSahddow = true;
		this.DF81403E.ShadowDepth = 20;
		this.DF81403E.Size = new System.Drawing.Size(359, 37);
		this.DF81403E.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 160);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDAnMail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DA1C1AA7_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.DF81403E.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
