using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXoaNhatKyHoatDong : Form
{
	private JSON_Settings CBA62423;

	private string ADBE9513;

	private string string_0;

	private string DFAD2F08;

	private int int_0;

	public static bool F1B5E793;

	private IContainer AC3D9E9E = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl EC2CBF28;

	private Panel panel1;

	private NumericUpDown C199A8A4;

	private TextBox txtTenHanhDong;

	private Label label4;

	private Label label2;

	private Label AE39B613;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox E81EE991;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown A2B3AA27;

	private NumericUpDown DB1DB026;

	private Label FE05B824;

	private Label D132AE89;

	private Label F01BA438;

	private CheckBox ckbXoaThangNay;

	public fHDXoaNhatKyHoatDong(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		F1B5E793 = false;
		ADBE9513 = string_1;
		DFAD2F08 = string_2;
		int_0 = int_1;
		string text = "";
		if (InteractSQL.B484648C("", "HDXoaNhatKyHoatDong").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaNhatKyHoatDong', 'Xóa nhật ký hoạt động');");
		}
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXoaNhatKyHoatDong");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CBA62423 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(AE39B613);
		Language.smethod_0(label2);
		Language.smethod_0(label4);
		Language.smethod_0(F01BA438);
		Language.smethod_0(FE05B824);
		Language.smethod_0(D132AE89);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void BDBA7614(object sender, EventArgs e)
	{
		try
		{
			C199A8A4.Value = CBA62423.GetValueInt("nudSoLuong");
			DB1DB026.Value = CBA62423.GetValueInt("nudDelayFrom");
			A2B3AA27.Value = CBA62423.GetValueInt("nudDelayTo");
			ckbXoaThangNay.Checked = CBA62423.GetValueBool("ckbXoaThangNay");
		}
		catch
		{
		}
	}

	private void AD9AE486(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuong", C199A8A4.Value);
		gClass.GetJson("nudDelayFrom", DB1DB026.Value);
		gClass.GetJson("nudDelayTo", A2B3AA27.Value);
		gClass.GetJson("ckbXoaThangNay", ckbXoaThangNay.Checked);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(ADBE9513, text, string_0, text2))
				{
					F1B5E793 = true;
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
			if (InteractSQL.smethod_13(DFAD2F08, text, text2))
			{
				F1B5E793 = true;
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

	private void F11830AF(object sender, PaintEventArgs e)
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
		if (C615E7BC && AC3D9E9E != null)
		{
			AC3D9E9E.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.AC3D9E9E = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXoaNhatKyHoatDong));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.AC3D9E9E);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.EC2CBF28 = new Bunifu.Framework.UI.BunifuDragControl(this.AC3D9E9E);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.E81EE991 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.ckbXoaThangNay = new System.Windows.Forms.CheckBox();
		this.A2B3AA27 = new System.Windows.Forms.NumericUpDown();
		this.DB1DB026 = new System.Windows.Forms.NumericUpDown();
		this.FE05B824 = new System.Windows.Forms.Label();
		this.D132AE89 = new System.Windows.Forms.Label();
		this.F01BA438 = new System.Windows.Forms.Label();
		this.C199A8A4 = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.AE39B613 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E81EE991).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.A2B3AA27).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DB1DB026).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C199A8A4).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Xóa nhật ký hoạt động";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.EC2CBF28.Fixed = true;
		this.EC2CBF28.Horizontal = true;
		this.EC2CBF28.TargetControl = this.pnlHeader;
		this.EC2CBF28.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.E81EE991);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
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
		this.button1.Click += new System.EventHandler(AD9AE486);
		this.E81EE991.Cursor = System.Windows.Forms.Cursors.Default;
		this.E81EE991.Image = Resources.Bitmap_4;
		this.E81EE991.Location = new System.Drawing.Point(3, 2);
		this.E81EE991.Name = "pictureBox1";
		this.E81EE991.Size = new System.Drawing.Size(34, 27);
		this.E81EE991.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E81EE991.TabIndex = 76;
		this.E81EE991.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.ckbXoaThangNay);
		this.panel1.Controls.Add(this.A2B3AA27);
		this.panel1.Controls.Add(this.DB1DB026);
		this.panel1.Controls.Add(this.FE05B824);
		this.panel1.Controls.Add(this.D132AE89);
		this.panel1.Controls.Add(this.F01BA438);
		this.panel1.Controls.Add(this.C199A8A4);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.AE39B613);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 274);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(F11830AF);
		this.ckbXoaThangNay.AutoSize = true;
		this.ckbXoaThangNay.Location = new System.Drawing.Point(30, 148);
		this.ckbXoaThangNay.Name = "ckbXoaThangNay";
		this.ckbXoaThangNay.Size = new System.Drawing.Size(130, 20);
		this.ckbXoaThangNay.TabIndex = 47;
		this.ckbXoaThangNay.Text = "Xóa tháng hiện tại";
		this.ckbXoaThangNay.UseVisualStyleBackColor = true;
		this.A2B3AA27.Location = new System.Drawing.Point(229, 112);
		this.A2B3AA27.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A2B3AA27.Name = "nudDelayTo";
		this.A2B3AA27.Size = new System.Drawing.Size(56, 23);
		this.A2B3AA27.TabIndex = 4;
		this.DB1DB026.Location = new System.Drawing.Point(132, 112);
		this.DB1DB026.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DB1DB026.Name = "nudDelayFrom";
		this.DB1DB026.Size = new System.Drawing.Size(56, 23);
		this.DB1DB026.TabIndex = 3;
		this.FE05B824.Location = new System.Drawing.Point(194, 114);
		this.FE05B824.Name = "label7";
		this.FE05B824.Size = new System.Drawing.Size(29, 16);
		this.FE05B824.TabIndex = 46;
		this.FE05B824.Text = "đê\u0301n";
		this.FE05B824.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D132AE89.AutoSize = true;
		this.D132AE89.Location = new System.Drawing.Point(287, 114);
		this.D132AE89.Name = "label6";
		this.D132AE89.Size = new System.Drawing.Size(30, 16);
		this.D132AE89.TabIndex = 45;
		this.D132AE89.Text = "giây";
		this.F01BA438.AutoSize = true;
		this.F01BA438.Location = new System.Drawing.Point(27, 114);
		this.F01BA438.Name = "label5";
		this.F01BA438.Size = new System.Drawing.Size(89, 16);
		this.F01BA438.TabIndex = 44;
		this.F01BA438.Text = "Thơ\u0300i gian chơ\u0300:";
		this.C199A8A4.Location = new System.Drawing.Point(132, 81);
		this.C199A8A4.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C199A8A4.Name = "nudSoLuong";
		this.C199A8A4.Size = new System.Drawing.Size(56, 23);
		this.C199A8A4.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(194, 83);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(39, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "tháng";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 83);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng:";
		this.AE39B613.AutoSize = true;
		this.AE39B613.Location = new System.Drawing.Point(27, 52);
		this.AE39B613.Name = "label1";
		this.AE39B613.Size = new System.Drawing.Size(98, 16);
		this.AE39B613.TabIndex = 31;
		this.AE39B613.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(187, 230);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(80, 230);
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
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 274);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaNhatKyHoatDong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BDBA7614);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E81EE991).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.A2B3AA27).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DB1DB026).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C199A8A4).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
