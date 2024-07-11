using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDUpCover : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string B8A95B81;

	private string string_1;

	private int int_0;

	public static bool D6397D15;

	private IContainer EBA362B6 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox C517DD8B;

	private Label B393B39F;

	private Label D9842A01;

	private Button btnCancel;

	private Button F18EA83B;

	private BunifuCards E23AC8A3;

	private Panel pnlHeader;

	private Button D894AF92;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private TextBox A5203516;

	private CheckBox AA1B7F92;

	private CheckBox C80155A8;

	public fHDUpCover(string string_2, int int_1 = 0, string EAB7A703 = "")
	{
		InitializeComponent();
		D6397D15 = false;
		string_0 = string_2;
		string_1 = EAB7A703;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Up Cover";
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
			B8A95B81 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C517DD8B.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(EAB7A703);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			F18EA83B.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			C517DD8B.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(D9842A01);
		Language.smethod_0(B393B39F);
		Language.smethod_0(F18EA83B);
		Language.smethod_0(btnCancel);
	}

	private void fHDUpCover_Load(object sender, EventArgs e)
	{
		try
		{
			A5203516.Text = gclass8_0.GetValue("txtPathFolder");
			AA1B7F92.Checked = gclass8_0.GetValueBool("ckbXoaAnhDaDung");
			C80155A8.Checked = gclass8_0.GetValueBool("ckbSkipIfHave");
		}
		catch
		{
		}
	}

	private void E70E3726(object sender, EventArgs e)
	{
		Close();
	}

	private void F18EA83B_Click(object sender, EventArgs e)
	{
		string text = C517DD8B.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		_ = A5203516.Text;
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtPathFolder", A5203516.Text);
		gClass.GetJson("ckbXoaAnhDaDung", AA1B7F92.Checked);
		gClass.GetJson("ckbSkipIfHave", C80155A8.Checked);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, B8A95B81, string_))
				{
					D6397D15 = true;
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
			if (InteractSQL.smethod_13(string_1, text, string_))
			{
				D6397D15 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D7399310(object sender, EventArgs e)
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

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && EBA362B6 != null)
		{
			EBA362B6.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.EBA362B6 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDUpCover));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.EBA362B6);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.EBA362B6);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.D894AF92 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.C80155A8 = new System.Windows.Forms.CheckBox();
		this.AA1B7F92 = new System.Windows.Forms.CheckBox();
		this.A5203516 = new System.Windows.Forms.TextBox();
		this.C517DD8B = new System.Windows.Forms.TextBox();
		this.B393B39F = new System.Windows.Forms.Label();
		this.D9842A01 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.F18EA83B = new System.Windows.Forms.Button();
		this.E23AC8A3 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.E23AC8A3.SuspendLayout();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Up Cover";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.D894AF92);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.D894AF92.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.D894AF92.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D894AF92.FlatAppearance.BorderSize = 0;
		this.D894AF92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D894AF92.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D894AF92.ForeColor = System.Drawing.Color.White;
		this.D894AF92.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.D894AF92.Location = new System.Drawing.Point(328, 1);
		this.D894AF92.Name = "button1";
		this.D894AF92.Size = new System.Drawing.Size(30, 30);
		this.D894AF92.TabIndex = 77;
		this.D894AF92.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.D894AF92.UseVisualStyleBackColor = true;
		this.D894AF92.Click += new System.EventHandler(E70E3726);
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
		this.panel1.Controls.Add(this.C80155A8);
		this.panel1.Controls.Add(this.AA1B7F92);
		this.panel1.Controls.Add(this.A5203516);
		this.panel1.Controls.Add(this.C517DD8B);
		this.panel1.Controls.Add(this.B393B39F);
		this.panel1.Controls.Add(this.D9842A01);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.F18EA83B);
		this.panel1.Controls.Add(this.E23AC8A3);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 211);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.C80155A8.AutoSize = true;
		this.C80155A8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C80155A8.Location = new System.Drawing.Point(132, 134);
		this.C80155A8.Name = "ckbSkipIfHave";
		this.C80155A8.Size = new System.Drawing.Size(171, 20);
		this.C80155A8.TabIndex = 36;
		this.C80155A8.Text = "Bỏ qua nếu đã có ảnh bìa";
		this.C80155A8.UseVisualStyleBackColor = true;
		this.AA1B7F92.AutoSize = true;
		this.AA1B7F92.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AA1B7F92.Location = new System.Drawing.Point(132, 108);
		this.AA1B7F92.Name = "ckbXoaAnhDaDung";
		this.AA1B7F92.Size = new System.Drawing.Size(173, 20);
		this.AA1B7F92.TabIndex = 35;
		this.AA1B7F92.Text = "Tự động xóa ảnh đã dùng";
		this.AA1B7F92.UseVisualStyleBackColor = true;
		this.A5203516.Location = new System.Drawing.Point(132, 79);
		this.A5203516.Name = "txtPathFolder";
		this.A5203516.Size = new System.Drawing.Size(194, 23);
		this.A5203516.TabIndex = 0;
		this.C517DD8B.Location = new System.Drawing.Point(132, 49);
		this.C517DD8B.Name = "txtTenHanhDong";
		this.C517DD8B.Size = new System.Drawing.Size(194, 23);
		this.C517DD8B.TabIndex = 0;
		this.B393B39F.AutoSize = true;
		this.B393B39F.Location = new System.Drawing.Point(27, 82);
		this.B393B39F.Name = "label5";
		this.B393B39F.Size = new System.Drawing.Size(73, 16);
		this.B393B39F.TabIndex = 34;
		this.B393B39F.Text = "Folder ảnh:";
		this.D9842A01.AutoSize = true;
		this.D9842A01.Location = new System.Drawing.Point(27, 52);
		this.D9842A01.Name = "label1";
		this.D9842A01.Size = new System.Drawing.Size(98, 16);
		this.D9842A01.TabIndex = 31;
		this.D9842A01.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 166);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(D7399310);
		this.F18EA83B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F18EA83B.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.F18EA83B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F18EA83B.FlatAppearance.BorderSize = 0;
		this.F18EA83B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F18EA83B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F18EA83B.ForeColor = System.Drawing.Color.White;
		this.F18EA83B.Location = new System.Drawing.Point(82, 166);
		this.F18EA83B.Name = "btnAdd";
		this.F18EA83B.Size = new System.Drawing.Size(92, 29);
		this.F18EA83B.TabIndex = 9;
		this.F18EA83B.Text = "Thêm";
		this.F18EA83B.UseVisualStyleBackColor = false;
		this.F18EA83B.Click += new System.EventHandler(F18EA83B_Click);
		this.E23AC8A3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E23AC8A3.BackColor = System.Drawing.Color.White;
		this.E23AC8A3.BorderRadius = 0;
		this.E23AC8A3.BottomSahddow = true;
		this.E23AC8A3.color = System.Drawing.Color.DarkViolet;
		this.E23AC8A3.Controls.Add(this.pnlHeader);
		this.E23AC8A3.LeftSahddow = false;
		this.E23AC8A3.Location = new System.Drawing.Point(1, 0);
		this.E23AC8A3.Name = "bunifuCards1";
		this.E23AC8A3.RightSahddow = true;
		this.E23AC8A3.ShadowDepth = 20;
		this.E23AC8A3.Size = new System.Drawing.Size(359, 37);
		this.E23AC8A3.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 211);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDUpCover";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDUpCover_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.E23AC8A3.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
