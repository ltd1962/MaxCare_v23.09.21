using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDKetBanNewfeed : Form
{
	private JSON_Settings gclass8_0;

	private string FBBB9117;

	private string C9939E12;

	private string string_0;

	private int C590381A;

	public static bool AB0E318A;

	private IContainer DA811EA9 = null;

	private BunifuDragControl D13C3BAC;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown DF80A524;

	private TextBox F594B123;

	private Label A69D5511;

	private Label label4;

	private Label label2;

	private Label F4050E85;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel E237093D;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label F8BD339C;

	private NumericUpDown nudTimesWarning;

	private Label AF8E108D;

	private Label D3343B8F;

	public fHDKetBanNewfeed(string string_1, int int_0 = 0, string BB2D3732 = "")
	{
		InitializeComponent();
		AB0E318A = false;
		FBBB9117 = string_1;
		string_0 = BB2D3732;
		C590381A = int_0;
		if (InteractSQL.B484648C("", "HDKetBanNewfeed").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanNewfeed', 'Kết bạn Newfeed');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanNewfeed");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			C9939E12 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F594B123.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BB2D3732);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F594B123.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(E237093D);
		Language.smethod_0(F4050E85);
		Language.smethod_0(label2);
		Language.smethod_0(A69D5511);
		Language.smethod_0(label4);
		Language.smethod_0(F8BD339C);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void AE17053C(object sender, EventArgs e)
	{
		try
		{
			DF80A524.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 5);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			nudTimesWarning.Value = gclass8_0.GetValueInt("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void AF2F4915(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = F594B123.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", DF80A524.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("nudTimesWarning", nudTimesWarning.Value);
		string text2 = gClass.D9A09B34();
		if (C590381A == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(FBBB9117, text, C9939E12, text2))
				{
					AB0E318A = true;
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
				AB0E318A = true;
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
		if (C615E7BC && DA811EA9 != null)
		{
			DA811EA9.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.DA811EA9 = new System.ComponentModel.Container();
		this.D13C3BAC = new Bunifu.Framework.UI.BunifuDragControl(this.DA811EA9);
		this.E237093D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.DA811EA9);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.nudTimesWarning = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.AF8E108D = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.D3343B8F = new System.Windows.Forms.Label();
		this.F8BD339C = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.DF80A524 = new System.Windows.Forms.NumericUpDown();
		this.F594B123 = new System.Windows.Forms.TextBox();
		this.A69D5511 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.F4050E85 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimesWarning).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DF80A524).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.D13C3BAC.Fixed = true;
		this.D13C3BAC.Horizontal = true;
		this.D13C3BAC.TargetControl = this.E237093D;
		this.D13C3BAC.Vertical = true;
		this.E237093D.BackColor = System.Drawing.Color.Transparent;
		this.E237093D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.E237093D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.E237093D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E237093D.ForeColor = System.Drawing.Color.Black;
		this.E237093D.Location = new System.Drawing.Point(0, 0);
		this.E237093D.Name = "bunifuCustomLabel1";
		this.E237093D.Size = new System.Drawing.Size(359, 31);
		this.E237093D.TabIndex = 12;
		this.E237093D.Text = "Cấu hình Kết bạn Newfeed";
		this.E237093D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.E237093D);
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
		this.button1.Image = Resources.C400940B;
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(AF2F4915);
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
		this.panel1.Controls.Add(this.nudTimesWarning);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.AF8E108D);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.D3343B8F);
		this.panel1.Controls.Add(this.F8BD339C);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.DF80A524);
		this.panel1.Controls.Add(this.F594B123);
		this.panel1.Controls.Add(this.A69D5511);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.F4050E85);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 192);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.nudTimesWarning.Location = new System.Drawing.Point(253, 221);
		this.nudTimesWarning.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimesWarning.Name = "nudTimesWarning";
		this.nudTimesWarning.Size = new System.Drawing.Size(43, 23);
		this.nudTimesWarning.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(229, 112);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.AF8E108D.AutoSize = true;
		this.AF8E108D.Location = new System.Drawing.Point(299, 223);
		this.AF8E108D.Name = "label9";
		this.AF8E108D.Size = new System.Drawing.Size(25, 16);
		this.AF8E108D.TabIndex = 45;
		this.AF8E108D.Text = "lần";
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(194, 114);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 114);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.D3343B8F.AutoSize = true;
		this.D3343B8F.Location = new System.Drawing.Point(27, 223);
		this.D3343B8F.Name = "label8";
		this.D3343B8F.Size = new System.Drawing.Size(226, 16);
		this.D3343B8F.TabIndex = 44;
		this.D3343B8F.Text = "Dừng khi gặp cảnh báo của Facebook:";
		this.F8BD339C.AutoSize = true;
		this.F8BD339C.Location = new System.Drawing.Point(27, 114);
		this.F8BD339C.Name = "label5";
		this.F8BD339C.Size = new System.Drawing.Size(90, 16);
		this.F8BD339C.TabIndex = 44;
		this.F8BD339C.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 81);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.DF80A524.Location = new System.Drawing.Point(132, 81);
		this.DF80A524.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DF80A524.Name = "nudSoLuongFrom";
		this.DF80A524.Size = new System.Drawing.Size(56, 23);
		this.DF80A524.TabIndex = 1;
		this.F594B123.Location = new System.Drawing.Point(132, 49);
		this.F594B123.Name = "txtTenHanhDong";
		this.F594B123.Size = new System.Drawing.Size(194, 23);
		this.F594B123.TabIndex = 0;
		this.A69D5511.AutoSize = true;
		this.A69D5511.Location = new System.Drawing.Point(194, 83);
		this.A69D5511.Name = "label3";
		this.A69D5511.Size = new System.Drawing.Size(29, 16);
		this.A69D5511.TabIndex = 37;
		this.A69D5511.Text = "đê\u0301n";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 83);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 83);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(89, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.F4050E85.AutoSize = true;
		this.F4050E85.Location = new System.Drawing.Point(27, 52);
		this.F4050E85.Name = "label1";
		this.F4050E85.Size = new System.Drawing.Size(99, 16);
		this.F4050E85.TabIndex = 31;
		this.F4050E85.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(191, 148);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(84, 148);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 192);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanNewfeed";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AE17053C);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimesWarning).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DF80A524).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
