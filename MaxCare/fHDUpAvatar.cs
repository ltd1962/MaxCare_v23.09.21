using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDUpAvatar : Form
{
	private JSON_Settings gclass8_0 = null;

	private string A1AC840E;

	private string AF860F1F;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B7A57C15;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label5;

	private Label E01C06BF;

	private Button A8ABAF18;

	private Button C03D2137;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button ED1C3E01;

	private PictureBox E099BFBC;

	private BunifuCustomLabel D1A40D2B;

	private TextBox FF2FBF38;

	private CheckBox ckbXoaAnhDaDung;

	private CheckBox ckbSkipIfHave;

	private CheckBox ckbThemKhungAvatar;

	public fHDUpAvatar(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		A1AC840E = string_1;
		string_0 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Up Avatar";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			AF860F1F = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			C03D2137.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(D1A40D2B);
		Language.smethod_0(E01C06BF);
		Language.smethod_0(label5);
		Language.smethod_0(C03D2137);
		Language.smethod_0(A8ABAF18);
	}

	private void AEA10AA0_Load(object sender, EventArgs e)
	{
		try
		{
			FF2FBF38.Text = gclass8_0.GetValue("txtPathFolder");
			ckbXoaAnhDaDung.Checked = gclass8_0.GetValueBool("ckbXoaAnhDaDung");
			ckbThemKhungAvatar.Checked = gclass8_0.GetValueBool("ckbThemKhungAvatar");
			ckbSkipIfHave.Checked = gclass8_0.GetValueBool("ckbSkipIfHave");
		}
		catch
		{
		}
	}

	private void ED1C3E01_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C03D2137_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		_ = FF2FBF38.Text;
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtPathFolder", FF2FBF38.Text);
		gClass.GetJson("ckbXoaAnhDaDung", ckbXoaAnhDaDung.Checked);
		gClass.GetJson("ckbThemKhungAvatar", ckbThemKhungAvatar.Checked);
		gClass.GetJson("ckbSkipIfHave", ckbSkipIfHave.Checked);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(A1AC840E, text, AF860F1F, text2))
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
			if (InteractSQL.smethod_13(string_0, text, text2))
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

	private void D4BEA72A(object sender, EventArgs e)
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

	private void E099BFBC_Click(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDUpAvatar));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D1A40D2B = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.B7A57C15 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.ED1C3E01 = new System.Windows.Forms.Button();
		this.E099BFBC = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbSkipIfHave = new System.Windows.Forms.CheckBox();
		this.FF2FBF38 = new System.Windows.Forms.TextBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.E01C06BF = new System.Windows.Forms.Label();
		this.A8ABAF18 = new System.Windows.Forms.Button();
		this.C03D2137 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.ckbThemKhungAvatar = new System.Windows.Forms.CheckBox();
		this.ckbXoaAnhDaDung = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E099BFBC).BeginInit();
		this.panel1.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.D1A40D2B;
		this.bunifuDragControl_0.Vertical = true;
		this.D1A40D2B.BackColor = System.Drawing.Color.Transparent;
		this.D1A40D2B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D1A40D2B.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D1A40D2B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D1A40D2B.ForeColor = System.Drawing.Color.Black;
		this.D1A40D2B.Location = new System.Drawing.Point(0, 0);
		this.D1A40D2B.Name = "bunifuCustomLabel1";
		this.D1A40D2B.Size = new System.Drawing.Size(359, 31);
		this.D1A40D2B.TabIndex = 12;
		this.D1A40D2B.Text = "Cấu hình Up Avatar";
		this.D1A40D2B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B7A57C15.Fixed = true;
		this.B7A57C15.Horizontal = true;
		this.B7A57C15.TargetControl = this.pnlHeader;
		this.B7A57C15.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.ED1C3E01);
		this.pnlHeader.Controls.Add(this.E099BFBC);
		this.pnlHeader.Controls.Add(this.D1A40D2B);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.ED1C3E01.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.ED1C3E01.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ED1C3E01.FlatAppearance.BorderSize = 0;
		this.ED1C3E01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ED1C3E01.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ED1C3E01.ForeColor = System.Drawing.Color.White;
		this.ED1C3E01.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.ED1C3E01.Location = new System.Drawing.Point(328, 1);
		this.ED1C3E01.Name = "button1";
		this.ED1C3E01.Size = new System.Drawing.Size(30, 30);
		this.ED1C3E01.TabIndex = 77;
		this.ED1C3E01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.ED1C3E01.UseVisualStyleBackColor = true;
		this.ED1C3E01.Click += new System.EventHandler(ED1C3E01_Click);
		this.E099BFBC.Cursor = System.Windows.Forms.Cursors.Default;
		this.E099BFBC.Image = Resources.Bitmap_4;
		this.E099BFBC.Location = new System.Drawing.Point(3, 2);
		this.E099BFBC.Name = "pictureBox1";
		this.E099BFBC.Size = new System.Drawing.Size(34, 27);
		this.E099BFBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E099BFBC.TabIndex = 76;
		this.E099BFBC.TabStop = false;
		this.E099BFBC.Click += new System.EventHandler(E099BFBC_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.ckbSkipIfHave);
		this.panel1.Controls.Add(this.FF2FBF38);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.E01C06BF);
		this.panel1.Controls.Add(this.A8ABAF18);
		this.panel1.Controls.Add(this.C03D2137);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Controls.Add(this.ckbThemKhungAvatar);
		this.panel1.Controls.Add(this.ckbXoaAnhDaDung);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 243);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.ckbSkipIfHave.AutoSize = true;
		this.ckbSkipIfHave.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSkipIfHave.Location = new System.Drawing.Point(132, 159);
		this.ckbSkipIfHave.Name = "ckbSkipIfHave";
		this.ckbSkipIfHave.Size = new System.Drawing.Size(165, 20);
		this.ckbSkipIfHave.TabIndex = 35;
		this.ckbSkipIfHave.Text = "Bỏ qua nếu đã có avatar";
		this.ckbSkipIfHave.UseVisualStyleBackColor = true;
		this.FF2FBF38.Location = new System.Drawing.Point(132, 79);
		this.FF2FBF38.Name = "txtPathFolder";
		this.FF2FBF38.Size = new System.Drawing.Size(194, 23);
		this.FF2FBF38.TabIndex = 0;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 82);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(73, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Folder ảnh:";
		this.E01C06BF.AutoSize = true;
		this.E01C06BF.Location = new System.Drawing.Point(27, 52);
		this.E01C06BF.Name = "label1";
		this.E01C06BF.Size = new System.Drawing.Size(98, 16);
		this.E01C06BF.TabIndex = 31;
		this.E01C06BF.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.A8ABAF18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.A8ABAF18.BackColor = System.Drawing.Color.Maroon;
		this.A8ABAF18.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A8ABAF18.FlatAppearance.BorderSize = 0;
		this.A8ABAF18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A8ABAF18.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A8ABAF18.ForeColor = System.Drawing.Color.White;
		this.A8ABAF18.Location = new System.Drawing.Point(189, 198);
		this.A8ABAF18.Name = "btnCancel";
		this.A8ABAF18.Size = new System.Drawing.Size(92, 29);
		this.A8ABAF18.TabIndex = 10;
		this.A8ABAF18.Text = "Đóng";
		this.A8ABAF18.UseVisualStyleBackColor = false;
		this.A8ABAF18.Click += new System.EventHandler(D4BEA72A);
		this.C03D2137.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C03D2137.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C03D2137.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C03D2137.FlatAppearance.BorderSize = 0;
		this.C03D2137.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C03D2137.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C03D2137.ForeColor = System.Drawing.Color.White;
		this.C03D2137.Location = new System.Drawing.Point(82, 198);
		this.C03D2137.Name = "btnAdd";
		this.C03D2137.Size = new System.Drawing.Size(92, 29);
		this.C03D2137.TabIndex = 9;
		this.C03D2137.Text = "Thêm";
		this.C03D2137.UseVisualStyleBackColor = false;
		this.C03D2137.Click += new System.EventHandler(C03D2137_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		this.ckbThemKhungAvatar.AutoSize = true;
		this.ckbThemKhungAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThemKhungAvatar.Location = new System.Drawing.Point(132, 133);
		this.ckbThemKhungAvatar.Name = "ckbThemKhungAvatar";
		this.ckbThemKhungAvatar.Size = new System.Drawing.Size(137, 20);
		this.ckbThemKhungAvatar.TabIndex = 35;
		this.ckbThemKhungAvatar.Text = "Thêm khung avatar";
		this.ckbThemKhungAvatar.UseVisualStyleBackColor = true;
		this.ckbXoaAnhDaDung.AutoSize = true;
		this.ckbXoaAnhDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaAnhDaDung.Location = new System.Drawing.Point(132, 108);
		this.ckbXoaAnhDaDung.Name = "ckbXoaAnhDaDung";
		this.ckbXoaAnhDaDung.Size = new System.Drawing.Size(173, 20);
		this.ckbXoaAnhDaDung.TabIndex = 35;
		this.ckbXoaAnhDaDung.Text = "Tự động xóa ảnh đã dùng";
		this.ckbXoaAnhDaDung.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 243);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDUpAvatar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AEA10AA0_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E099BFBC).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
