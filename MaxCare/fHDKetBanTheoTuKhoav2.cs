using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDKetBanTheoTuKhoav2 : Form
{
	private JSON_Settings D5825811;

	private string DF1D63A9;

	private string string_0;

	private string string_1;

	private int EA285D18;

	public static bool D6ADFB12;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl E92F5F37;

	private Panel EC8E2E2E;

	private NumericUpDown EFA860B5;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label C8883D89;

	private Label label2;

	private Label FD89E885;

	private Button btnCancel;

	private Button E3BE5B2A;

	private BunifuCards bunifuCards1;

	private Panel B80063A2;

	private Button E82FEE2F;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A193C38D;

	private Label label8;

	private Label lblStatus;

	private TextBox txtTuKhoa;

	private NumericUpDown CA322EB1;

	private NumericUpDown B53CCE24;

	private Label label7;

	private Label label6;

	private Label label5;

	public fHDKetBanTheoTuKhoav2(string string_2, int int_0 = 0, string E7A7E39C = "")
	{
		InitializeComponent();
		D6ADFB12 = false;
		DF1D63A9 = string_2;
		string_1 = E7A7E39C;
		EA285D18 = int_0;
		if (InteractSQL.B484648C("", "HDKetBanTheoTuKhoav2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTheoTuKhoav2', 'Kết bạn theo từ khóa v2');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanTheoTuKhoav2");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E7A7E39C);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			E3BE5B2A.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D5825811 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void C3BC77B2()
	{
		Language.smethod_0(A193C38D);
		Language.smethod_0(FD89E885);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(C8883D89);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(lblStatus);
		Language.smethod_0(label8);
		Language.smethod_0(E3BE5B2A);
		Language.smethod_0(btnCancel);
	}

	private void fHDKetBanTheoTuKhoav2_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = D5825811.GetValueInt("nudSoLuongFrom", 1);
			EFA860B5.Value = D5825811.GetValueInt("nudSoLuongTo", 3);
			B53CCE24.Value = D5825811.GetValueInt("nudDelayFrom", 2);
			CA322EB1.Value = D5825811.GetValueInt("nudDelayTo", 4);
			txtTuKhoa.Text = D5825811.GetValue("txtTuKhoa");
		}
		catch
		{
		}
	}

	private void BD3F7A0A(object sender, EventArgs e)
	{
		Close();
	}

	private void B23284B8(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtTuKhoa.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p từ khóa!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", EFA860B5.Value);
		gClass.GetJson("nudDelayFrom", B53CCE24.Value);
		gClass.GetJson("nudDelayTo", CA322EB1.Value);
		gClass.GetJson("txtTuKhoa", txtTuKhoa.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (EA285D18 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(DF1D63A9, text, string_0, string_))
				{
					D6ADFB12 = true;
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
				D6ADFB12 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void C4BEF50D(object sender, EventArgs e)
	{
		Close();
	}

	private void CD98A51D(object sender, PaintEventArgs e)
	{
		if (EC8E2E2E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, EC8E2E2E.ClientSize.Width - num, EC8E2E2E.ClientSize.Height - num));
		}
	}

	private void CC99D02C(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTuKhoa.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch từ khóa ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTheoTuKhoav2));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.A193C38D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E92F5F37 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.B80063A2 = new System.Windows.Forms.Panel();
		this.E82FEE2F = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.EC8E2E2E = new System.Windows.Forms.Panel();
		this.txtTuKhoa = new System.Windows.Forms.TextBox();
		this.CA322EB1 = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.B53CCE24 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.EFA860B5 = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.C8883D89 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.FD89E885 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.E3BE5B2A = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.B80063A2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.EC8E2E2E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CA322EB1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B53CCE24).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EFA860B5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.A193C38D;
		this.bunifuDragControl_0.Vertical = true;
		this.A193C38D.BackColor = System.Drawing.Color.Transparent;
		this.A193C38D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.A193C38D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A193C38D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A193C38D.ForeColor = System.Drawing.Color.Black;
		this.A193C38D.Location = new System.Drawing.Point(0, 0);
		this.A193C38D.Name = "bunifuCustomLabel1";
		this.A193C38D.Size = new System.Drawing.Size(359, 31);
		this.A193C38D.TabIndex = 12;
		this.A193C38D.Text = "Cấu hình Kết bạn theo từ khóa v2";
		this.A193C38D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E92F5F37.Fixed = true;
		this.E92F5F37.Horizontal = true;
		this.E92F5F37.TargetControl = this.B80063A2;
		this.E92F5F37.Vertical = true;
		this.B80063A2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B80063A2.BackColor = System.Drawing.Color.White;
		this.B80063A2.Controls.Add(this.E82FEE2F);
		this.B80063A2.Controls.Add(this.pictureBox1);
		this.B80063A2.Controls.Add(this.A193C38D);
		this.B80063A2.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B80063A2.Location = new System.Drawing.Point(0, 3);
		this.B80063A2.Name = "pnlHeader";
		this.B80063A2.Size = new System.Drawing.Size(359, 31);
		this.B80063A2.TabIndex = 9;
		this.E82FEE2F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.E82FEE2F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E82FEE2F.FlatAppearance.BorderSize = 0;
		this.E82FEE2F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E82FEE2F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E82FEE2F.ForeColor = System.Drawing.Color.White;
		this.E82FEE2F.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.E82FEE2F.Location = new System.Drawing.Point(328, 1);
		this.E82FEE2F.Name = "button1";
		this.E82FEE2F.Size = new System.Drawing.Size(30, 30);
		this.E82FEE2F.TabIndex = 77;
		this.E82FEE2F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.E82FEE2F.UseVisualStyleBackColor = true;
		this.E82FEE2F.Click += new System.EventHandler(BD3F7A0A);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.EC8E2E2E.BackColor = System.Drawing.Color.White;
		this.EC8E2E2E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.EC8E2E2E.Controls.Add(this.txtTuKhoa);
		this.EC8E2E2E.Controls.Add(this.CA322EB1);
		this.EC8E2E2E.Controls.Add(this.label8);
		this.EC8E2E2E.Controls.Add(this.lblStatus);
		this.EC8E2E2E.Controls.Add(this.B53CCE24);
		this.EC8E2E2E.Controls.Add(this.label7);
		this.EC8E2E2E.Controls.Add(this.label6);
		this.EC8E2E2E.Controls.Add(this.label5);
		this.EC8E2E2E.Controls.Add(this.EFA860B5);
		this.EC8E2E2E.Controls.Add(this.nudSoLuongFrom);
		this.EC8E2E2E.Controls.Add(this.txtTenHanhDong);
		this.EC8E2E2E.Controls.Add(this.label3);
		this.EC8E2E2E.Controls.Add(this.C8883D89);
		this.EC8E2E2E.Controls.Add(this.label2);
		this.EC8E2E2E.Controls.Add(this.FD89E885);
		this.EC8E2E2E.Controls.Add(this.btnCancel);
		this.EC8E2E2E.Controls.Add(this.E3BE5B2A);
		this.EC8E2E2E.Controls.Add(this.bunifuCards1);
		this.EC8E2E2E.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.EC8E2E2E.Dock = System.Windows.Forms.DockStyle.Fill;
		this.EC8E2E2E.Location = new System.Drawing.Point(0, 0);
		this.EC8E2E2E.Name = "panel1";
		this.EC8E2E2E.Size = new System.Drawing.Size(362, 385);
		this.EC8E2E2E.TabIndex = 0;
		this.EC8E2E2E.Paint += new System.Windows.Forms.PaintEventHandler(CD98A51D);
		this.txtTuKhoa.Location = new System.Drawing.Point(31, 164);
		this.txtTuKhoa.Multiline = true;
		this.txtTuKhoa.Name = "txtTuKhoa";
		this.txtTuKhoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtTuKhoa.Size = new System.Drawing.Size(295, 138);
		this.txtTuKhoa.TabIndex = 5;
		this.txtTuKhoa.WordWrap = false;
		this.txtTuKhoa.TextChanged += new System.EventHandler(CC99D02C);
		this.CA322EB1.Location = new System.Drawing.Point(229, 111);
		this.CA322EB1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CA322EB1.Name = "nudDelayTo";
		this.CA322EB1.Size = new System.Drawing.Size(56, 23);
		this.CA322EB1.TabIndex = 4;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(28, 305);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(259, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(27, 142);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch từ khóa (0):";
		this.B53CCE24.Location = new System.Drawing.Point(132, 111);
		this.B53CCE24.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B53CCE24.Name = "nudDelayFrom";
		this.B53CCE24.Size = new System.Drawing.Size(56, 23);
		this.B53CCE24.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(194, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.EFA860B5.Location = new System.Drawing.Point(229, 80);
		this.EFA860B5.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.EFA860B5.Name = "nudSoLuongTo";
		this.EFA860B5.Size = new System.Drawing.Size(56, 23);
		this.EFA860B5.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C8883D89.AutoSize = true;
		this.C8883D89.Location = new System.Drawing.Point(287, 82);
		this.C8883D89.Name = "label4";
		this.C8883D89.Size = new System.Drawing.Size(28, 16);
		this.C8883D89.TabIndex = 35;
		this.C8883D89.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.FD89E885.AutoSize = true;
		this.FD89E885.Location = new System.Drawing.Point(27, 52);
		this.FD89E885.Name = "label1";
		this.FD89E885.Size = new System.Drawing.Size(98, 16);
		this.FD89E885.TabIndex = 31;
		this.FD89E885.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(185, 336);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(C4BEF50D);
		this.E3BE5B2A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.E3BE5B2A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E3BE5B2A.FlatAppearance.BorderSize = 0;
		this.E3BE5B2A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E3BE5B2A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E3BE5B2A.ForeColor = System.Drawing.Color.White;
		this.E3BE5B2A.Location = new System.Drawing.Point(78, 336);
		this.E3BE5B2A.Name = "btnAdd";
		this.E3BE5B2A.Size = new System.Drawing.Size(92, 29);
		this.E3BE5B2A.TabIndex = 6;
		this.E3BE5B2A.Text = "Thêm";
		this.E3BE5B2A.UseVisualStyleBackColor = false;
		this.E3BE5B2A.Click += new System.EventHandler(B23284B8);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.B80063A2);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 385);
		base.Controls.Add(this.EC8E2E2E);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTheoTuKhoav2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTheoTuKhoav2_Load);
		this.B80063A2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.EC8E2E2E.ResumeLayout(false);
		this.EC8E2E2E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CA322EB1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B53CCE24).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EFA860B5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
