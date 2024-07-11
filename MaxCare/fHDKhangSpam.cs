using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDKhangSpam : Form
{
	private JSON_Settings E3A1D1A4 = null;

	private string string_0;

	private string string_1;

	private string A3332C31;

	private int int_0;

	public static bool bool_0;

	private IContainer F71610A3 = null;

	private BunifuDragControl A1014E28;

	private BunifuDragControl F6973915;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label E493269C;

	private Label D40C7691;

	private Label label1;

	private Button btnCancel;

	private Button EAAC602E;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox E5A9F89B;

	private BunifuCustomLabel C62B8CAC;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label2;

	private Label B78FAB98;

	private Label C783A9AF;

	public fHDKhangSpam(string string_2, int int_1 = 0, string E2B26515 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		A3332C31 = E2B26515;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDKhangSpam").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKhangSpam', 'Kháng spam');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKhangSpam");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E2B26515);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			EAAC602E.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E3A1D1A4 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(C62B8CAC);
		Language.smethod_0(label1);
		Language.smethod_0(D40C7691);
		Language.smethod_0(label7);
		Language.smethod_0(E493269C);
		Language.smethod_0(EAAC602E);
		Language.smethod_0(btnCancel);
	}

	private void AA2A5EAD_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = E3A1D1A4.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = E3A1D1A4.GetValueInt("nudSoLuongTo", 3);
			nudDelayFrom.Value = E3A1D1A4.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = E3A1D1A4.GetValueInt("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E5A61F0A(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
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
			if (InteractSQL.smethod_13(A3332C31, text, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
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
		if (C615E7BC && F71610A3 != null)
		{
			F71610A3.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F71610A3 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKhangSpam));
		this.A1014E28 = new Bunifu.Framework.UI.BunifuDragControl(this.F71610A3);
		this.C62B8CAC = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F6973915 = new Bunifu.Framework.UI.BunifuDragControl(this.F71610A3);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.E5A9F89B = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.B78FAB98 = new System.Windows.Forms.Label();
		this.C783A9AF = new System.Windows.Forms.Label();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.E493269C = new System.Windows.Forms.Label();
		this.D40C7691 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.EAAC602E = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E5A9F89B).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.A1014E28.Fixed = true;
		this.A1014E28.Horizontal = true;
		this.A1014E28.TargetControl = this.C62B8CAC;
		this.A1014E28.Vertical = true;
		this.C62B8CAC.BackColor = System.Drawing.Color.Transparent;
		this.C62B8CAC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C62B8CAC.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C62B8CAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C62B8CAC.ForeColor = System.Drawing.Color.Black;
		this.C62B8CAC.Location = new System.Drawing.Point(0, 0);
		this.C62B8CAC.Name = "bunifuCustomLabel1";
		this.C62B8CAC.Size = new System.Drawing.Size(359, 31);
		this.C62B8CAC.TabIndex = 12;
		this.C62B8CAC.Text = "Cấu hình Kháng spam";
		this.C62B8CAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F6973915.Fixed = true;
		this.F6973915.Horizontal = true;
		this.F6973915.TargetControl = this.pnlHeader;
		this.F6973915.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.E5A9F89B);
		this.pnlHeader.Controls.Add(this.C62B8CAC);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.E5A9F89B.Cursor = System.Windows.Forms.Cursors.Default;
		this.E5A9F89B.Image = Resources.Bitmap_4;
		this.E5A9F89B.Location = new System.Drawing.Point(3, 2);
		this.E5A9F89B.Name = "pictureBox1";
		this.E5A9F89B.Size = new System.Drawing.Size(34, 27);
		this.E5A9F89B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E5A9F89B.TabIndex = 76;
		this.E5A9F89B.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.B78FAB98);
		this.panel1.Controls.Add(this.C783A9AF);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.E493269C);
		this.panel1.Controls.Add(this.D40C7691);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.EAAC602E);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 158);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 40;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 39;
		this.label2.Location = new System.Drawing.Point(194, 80);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(29, 16);
		this.label2.TabIndex = 43;
		this.label2.Text = "đê\u0301n";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B78FAB98.AutoSize = true;
		this.B78FAB98.Location = new System.Drawing.Point(287, 214);
		this.B78FAB98.Name = "label3";
		this.B78FAB98.Size = new System.Drawing.Size(0, 16);
		this.B78FAB98.TabIndex = 42;
		this.C783A9AF.AutoSize = true;
		this.C783A9AF.Location = new System.Drawing.Point(27, 80);
		this.C783A9AF.Name = "label4";
		this.C783A9AF.Size = new System.Drawing.Size(63, 16);
		this.C783A9AF.TabIndex = 41;
		this.C783A9AF.Text = "Số lượng:";
		this.nudDelayTo.Location = new System.Drawing.Point(229, 242);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 242);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(194, 244);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E493269C.AutoSize = true;
		this.E493269C.Location = new System.Drawing.Point(287, 244);
		this.E493269C.Name = "label6";
		this.E493269C.Size = new System.Drawing.Size(30, 16);
		this.E493269C.TabIndex = 36;
		this.E493269C.Text = "giây";
		this.D40C7691.AutoSize = true;
		this.D40C7691.Location = new System.Drawing.Point(27, 244);
		this.D40C7691.Name = "label5";
		this.D40C7691.Size = new System.Drawing.Size(89, 16);
		this.D40C7691.TabIndex = 34;
		this.D40C7691.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(190, 116);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.EAAC602E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.EAAC602E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.EAAC602E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EAAC602E.FlatAppearance.BorderSize = 0;
		this.EAAC602E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EAAC602E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EAAC602E.ForeColor = System.Drawing.Color.White;
		this.EAAC602E.Location = new System.Drawing.Point(83, 116);
		this.EAAC602E.Name = "btnAdd";
		this.EAAC602E.Size = new System.Drawing.Size(92, 29);
		this.EAAC602E.TabIndex = 9;
		this.EAAC602E.Text = "Thêm";
		this.EAAC602E.UseVisualStyleBackColor = false;
		this.EAAC602E.Click += new System.EventHandler(E5A61F0A);
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
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 158);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKhangSpam";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AA2A5EAD_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E5A9F89B).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
