using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTimKiemGoogle : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string B290342A;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer FE2D7783 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl DAA78FA9;

	private Panel D2B62015;

	private TextBox E68F4C06;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel BA1E0593;

	private Button C89F3DBA;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label AC9AC3AC;

	private RichTextBox txtTuKhoa;

	private NumericUpDown nudCountTimeScrollTo;

	private NumericUpDown nudCountLinkClickTo;

	private NumericUpDown nudCountPageTo;

	private NumericUpDown nudCountTuKhoaTo;

	private NumericUpDown nudCountTimeScrollFrom;

	private NumericUpDown nudCountLinkClickFrom;

	private NumericUpDown nudCountPageFrom;

	private NumericUpDown FF9CE2AA;

	private Label label4;

	private Label label17;

	private Label label14;

	private Label label3;

	private Label label13;

	private Label label16;

	private Label D4386C93;

	private Label label11;

	private Label label15;

	private Label B6B1859C;

	private Label F6ADC336;

	public fHDTimKiemGoogle(string string_2, int int_1 = 0, string B40DFC24 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = B40DFC24;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDTimKiemGoogle").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTimKiemGoogle', 'Ti\u0300m kiê\u0301m Google');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTimKiemGoogle");
			B290342A = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			E68F4C06.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(B40DFC24);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			E68F4C06.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
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
		Language.smethod_0(AC9AC3AC);
		Language.smethod_0(F6ADC336);
		Language.smethod_0(label13);
		Language.smethod_0(label11);
		Language.smethod_0(B6B1859C);
		Language.smethod_0(label14);
		Language.smethod_0(D4386C93);
		Language.smethod_0(label15);
		Language.smethod_0(label17);
		Language.smethod_0(label16);
		Language.smethod_0(label2);
		Language.smethod_0(label4);
		Language.smethod_0(label3);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void AC359501(object sender, EventArgs e)
	{
		try
		{
			FF9CE2AA.Value = gclass8_0.GetValueInt("nudCountTuKhoaFrom", 1);
			nudCountTuKhoaTo.Value = gclass8_0.GetValueInt("nudCountTuKhoaTo", 1);
			nudCountPageFrom.Value = gclass8_0.GetValueInt("nudCountPageFrom", 3);
			nudCountPageTo.Value = gclass8_0.GetValueInt("nudCountPageTo", 3);
			nudCountLinkClickFrom.Value = gclass8_0.GetValueInt("nudCountLinkClickFrom", 3);
			nudCountLinkClickTo.Value = gclass8_0.GetValueInt("nudCountLinkClickTo", 5);
			nudCountTimeScrollFrom.Value = gclass8_0.GetValueInt("nudCountTimeScrollFrom", 30);
			nudCountTimeScrollTo.Value = gclass8_0.GetValueInt("nudCountTimeScrollTo", 30);
			txtTuKhoa.Text = gclass8_0.GetValue("txtTuKhoa");
		}
		catch
		{
		}
	}

	private void AA85F509(object sender, EventArgs e)
	{
		Close();
	}

	private void A10E312D(object sender, EventArgs e)
	{
		string text = E68F4C06.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudCountTuKhoaFrom", FF9CE2AA.Value);
		gClass.GetJson("nudCountTuKhoaTo", nudCountTuKhoaTo.Value);
		gClass.GetJson("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.GetJson("nudCountPageTo", nudCountPageTo.Value);
		gClass.GetJson("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		gClass.GetJson("nudCountLinkClickTo", nudCountLinkClickTo.Value);
		gClass.GetJson("nudCountTimeScrollFrom", nudCountTimeScrollFrom.Value);
		gClass.GetJson("nudCountTimeScrollTo", nudCountTimeScrollTo.Value);
		gClass.GetJson("txtTuKhoa", txtTuKhoa.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, B290342A, string_))
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
			if (InteractSQL.smethod_13(string_1, text, string_))
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

	private void BF945C8C(object sender, EventArgs e)
	{
		Close();
	}

	private void D2B62015_Paint(object sender, PaintEventArgs e)
	{
		if (D2B62015.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D2B62015.ClientSize.Width - num, D2B62015.ClientSize.Height - num));
		}
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTuKhoa.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			AC9AC3AC.Text = string.Format(Language.GetValue("Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool B2A15619)
	{
		if (B2A15619 && FE2D7783 != null)
		{
			FE2D7783.Dispose();
		}
		base.Dispose(B2A15619);
	}

	private void InitializeComponent()
	{
		this.FE2D7783 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTimKiemGoogle));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.FE2D7783);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.DAA78FA9 = new Bunifu.Framework.UI.BunifuDragControl(this.FE2D7783);
		this.BA1E0593 = new System.Windows.Forms.Panel();
		this.C89F3DBA = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.D2B62015 = new System.Windows.Forms.Panel();
		this.nudCountTimeScrollFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		this.FF9CE2AA = new System.Windows.Forms.NumericUpDown();
		this.txtTuKhoa = new System.Windows.Forms.RichTextBox();
		this.AC9AC3AC = new System.Windows.Forms.Label();
		this.nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkClickTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.nudCountTuKhoaTo = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.E68F4C06 = new System.Windows.Forms.TextBox();
		this.label17 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.D4386C93 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.B6B1859C = new System.Windows.Forms.Label();
		this.F6ADC336 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.BA1E0593.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.D2B62015.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FF9CE2AA).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaTo).BeginInit();
		this.bunifuCards1.SuspendLayout();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Ti\u0300m kiê\u0301m Google";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DAA78FA9.Fixed = true;
		this.DAA78FA9.Horizontal = true;
		this.DAA78FA9.TargetControl = this.BA1E0593;
		this.DAA78FA9.Vertical = true;
		this.BA1E0593.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BA1E0593.BackColor = System.Drawing.Color.White;
		this.BA1E0593.Controls.Add(this.C89F3DBA);
		this.BA1E0593.Controls.Add(this.pictureBox1);
		this.BA1E0593.Controls.Add(this.bunifuCustomLabel1);
		this.BA1E0593.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BA1E0593.Location = new System.Drawing.Point(0, 3);
		this.BA1E0593.Name = "pnlHeader";
		this.BA1E0593.Size = new System.Drawing.Size(359, 31);
		this.BA1E0593.TabIndex = 9;
		this.C89F3DBA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C89F3DBA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C89F3DBA.FlatAppearance.BorderSize = 0;
		this.C89F3DBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C89F3DBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C89F3DBA.ForeColor = System.Drawing.Color.White;
		this.C89F3DBA.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.C89F3DBA.Location = new System.Drawing.Point(328, 1);
		this.C89F3DBA.Name = "button1";
		this.C89F3DBA.Size = new System.Drawing.Size(30, 30);
		this.C89F3DBA.TabIndex = 77;
		this.C89F3DBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C89F3DBA.UseVisualStyleBackColor = true;
		this.C89F3DBA.Click += new System.EventHandler(AA85F509);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.D2B62015.BackColor = System.Drawing.Color.White;
		this.D2B62015.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D2B62015.Controls.Add(this.nudCountTimeScrollFrom);
		this.D2B62015.Controls.Add(this.nudCountLinkClickFrom);
		this.D2B62015.Controls.Add(this.nudCountPageFrom);
		this.D2B62015.Controls.Add(this.FF9CE2AA);
		this.D2B62015.Controls.Add(this.txtTuKhoa);
		this.D2B62015.Controls.Add(this.AC9AC3AC);
		this.D2B62015.Controls.Add(this.nudCountTimeScrollTo);
		this.D2B62015.Controls.Add(this.nudCountLinkClickTo);
		this.D2B62015.Controls.Add(this.nudCountPageTo);
		this.D2B62015.Controls.Add(this.nudCountTuKhoaTo);
		this.D2B62015.Controls.Add(this.label4);
		this.D2B62015.Controls.Add(this.E68F4C06);
		this.D2B62015.Controls.Add(this.label17);
		this.D2B62015.Controls.Add(this.label14);
		this.D2B62015.Controls.Add(this.label3);
		this.D2B62015.Controls.Add(this.label13);
		this.D2B62015.Controls.Add(this.label16);
		this.D2B62015.Controls.Add(this.D4386C93);
		this.D2B62015.Controls.Add(this.label11);
		this.D2B62015.Controls.Add(this.label15);
		this.D2B62015.Controls.Add(this.B6B1859C);
		this.D2B62015.Controls.Add(this.F6ADC336);
		this.D2B62015.Controls.Add(this.label2);
		this.D2B62015.Controls.Add(this.label1);
		this.D2B62015.Controls.Add(this.btnCancel);
		this.D2B62015.Controls.Add(this.btnAdd);
		this.D2B62015.Controls.Add(this.bunifuCards1);
		this.D2B62015.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.D2B62015.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D2B62015.Location = new System.Drawing.Point(0, 0);
		this.D2B62015.Name = "panel1";
		this.D2B62015.Size = new System.Drawing.Size(362, 413);
		this.D2B62015.TabIndex = 0;
		this.D2B62015.Paint += new System.Windows.Forms.PaintEventHandler(D2B62015_Paint);
		this.nudCountTimeScrollFrom.Location = new System.Drawing.Point(192, 330);
		this.nudCountTimeScrollFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
		this.nudCountTimeScrollFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollFrom.TabIndex = 1;
		this.nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 302);
		this.nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		this.nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickFrom.TabIndex = 1;
		this.nudCountPageFrom.Location = new System.Drawing.Point(192, 274);
		this.nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageFrom.Name = "nudCountPageFrom";
		this.nudCountPageFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountPageFrom.TabIndex = 1;
		this.FF9CE2AA.Location = new System.Drawing.Point(192, 246);
		this.FF9CE2AA.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FF9CE2AA.Name = "nudCountTuKhoaFrom";
		this.FF9CE2AA.Size = new System.Drawing.Size(36, 23);
		this.FF9CE2AA.TabIndex = 1;
		this.txtTuKhoa.Location = new System.Drawing.Point(30, 96);
		this.txtTuKhoa.Name = "txtTuKhoa";
		this.txtTuKhoa.Size = new System.Drawing.Size(298, 142);
		this.txtTuKhoa.TabIndex = 42;
		this.txtTuKhoa.Text = "";
		this.txtTuKhoa.WordWrap = false;
		this.txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		this.AC9AC3AC.AutoSize = true;
		this.AC9AC3AC.Location = new System.Drawing.Point(27, 77);
		this.AC9AC3AC.Name = "lblStatus";
		this.AC9AC3AC.Size = new System.Drawing.Size(201, 16);
		this.AC9AC3AC.TabIndex = 0;
		this.AC9AC3AC.Text = "Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web (0):";
		this.nudCountTimeScrollTo.Location = new System.Drawing.Point(248, 330);
		this.nudCountTimeScrollTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
		this.nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollTo.TabIndex = 2;
		this.nudCountLinkClickTo.Location = new System.Drawing.Point(248, 302);
		this.nudCountLinkClickTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
		this.nudCountLinkClickTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickTo.TabIndex = 2;
		this.nudCountPageTo.Location = new System.Drawing.Point(248, 274);
		this.nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageTo.Name = "nudCountPageTo";
		this.nudCountPageTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountPageTo.TabIndex = 2;
		this.nudCountTuKhoaTo.Location = new System.Drawing.Point(248, 246);
		this.nudCountTuKhoaTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
		this.nudCountTuKhoaTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountTuKhoaTo.TabIndex = 2;
		this.label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new System.Drawing.Point(226, 332);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(26, 16);
		this.label4.TabIndex = 37;
		this.label4.Text = ">";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E68F4C06.Location = new System.Drawing.Point(134, 49);
		this.E68F4C06.Name = "txtTenHanhDong";
		this.E68F4C06.Size = new System.Drawing.Size(194, 23);
		this.E68F4C06.TabIndex = 0;
		this.label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label17.Location = new System.Drawing.Point(226, 304);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(26, 16);
		this.label17.TabIndex = 37;
		this.label17.Text = ">";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(226, 276);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(26, 16);
		this.label14.TabIndex = 37;
		this.label14.Text = ">";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(284, 332);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(30, 16);
		this.label3.TabIndex = 35;
		this.label3.Text = "giây";
		this.label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label13.Location = new System.Drawing.Point(226, 248);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(26, 16);
		this.label13.TabIndex = 37;
		this.label13.Text = ">";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(284, 304);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(26, 16);
		this.label16.TabIndex = 35;
		this.label16.Text = "link";
		this.D4386C93.AutoSize = true;
		this.D4386C93.Location = new System.Drawing.Point(284, 276);
		this.D4386C93.Name = "label12";
		this.D4386C93.Size = new System.Drawing.Size(37, 16);
		this.D4386C93.TabIndex = 35;
		this.D4386C93.Text = "trang";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(284, 248);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(50, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "tư\u0300 khóa";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(28, 304);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(164, 16);
		this.label15.TabIndex = 34;
		this.label15.Text = "Click random link trên web:";
		this.B6B1859C.AutoSize = true;
		this.B6B1859C.Location = new System.Drawing.Point(27, 276);
		this.B6B1859C.Name = "label10";
		this.B6B1859C.Size = new System.Drawing.Size(150, 16);
		this.B6B1859C.TabIndex = 34;
		this.B6B1859C.Text = "Sô\u0301 trang ti\u0300m kiê\u0301m tô\u0301i đa:";
		this.F6ADC336.AutoSize = true;
		this.F6ADC336.Location = new System.Drawing.Point(27, 248);
		this.F6ADC336.Name = "label9";
		this.F6ADC336.Size = new System.Drawing.Size(120, 16);
		this.F6ADC336.TabIndex = 32;
		this.F6ADC336.Text = "Sô\u0301 tư\u0300 kho\u0301a câ\u0300n ti\u0300m:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 332);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(146, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Thơ\u0300i gian lươ\u0301t trên web:";
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
		this.btnCancel.Location = new System.Drawing.Point(189, 369);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(BF945C8C);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 369);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(A10E312D);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.BA1E0593);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 413);
		base.Controls.Add(this.D2B62015);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTimKiemGoogle";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AC359501);
		this.BA1E0593.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.D2B62015.ResumeLayout(false);
		this.D2B62015.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FF9CE2AA).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountTuKhoaTo).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
