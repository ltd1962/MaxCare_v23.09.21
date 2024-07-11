using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXoaBaiTuong : Form
{
	private JSON_Settings DB85E00E = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int D2151707;

	public static bool bool_0;

	private IContainer DCB0191D = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl CF0EA702;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F9024C25;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button F3185E81;

	private Button A6A835A2;

	private BunifuCards CE89049C;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudSoLuongBaiTo;

	private NumericUpDown B233A63A;

	private Label label8;

	private Label label4;

	private Label label3;

	private CheckBox ckbOnlyDeleteTagPost;

	public fHDXoaBaiTuong(string string_3, int int_0 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		D2151707 = int_0;
		if (InteractSQL.B484648C("", "HDXoaBaiTuong").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaBaiTuong', 'Xóa bài trên tươ\u0300ng');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXoaBaiTuong");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			A6A835A2.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		DB85E00E = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(A6A835A2);
		Language.smethod_0(F3185E81);
	}

	private void fHDXoaBaiTuong_Load(object sender, EventArgs e)
	{
		try
		{
			B233A63A.Value = DB85E00E.GetValueInt("nudSoLuongBaiFrom", 3);
			nudSoLuongBaiTo.Value = DB85E00E.GetValueInt("nudSoLuongBaiTo", 3);
			F9024C25.Value = DB85E00E.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = DB85E00E.GetValueInt("nudDelayTo", 5);
			ckbOnlyDeleteTagPost.Checked = DB85E00E.GetValueBool("ckbOnlyDeleteTagPost");
		}
		catch
		{
		}
	}

	private void AD20D4AE(object sender, EventArgs e)
	{
		Close();
	}

	private void A6A835A2_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongBaiFrom", B233A63A.Value);
		gClass.GetJson("nudSoLuongBaiTo", nudSoLuongBaiTo.Value);
		gClass.GetJson("nudDelayFrom", F9024C25.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbOnlyDeleteTagPost", ckbOnlyDeleteTagPost.Checked);
		string string_ = gClass.D9A09B34();
		if (D2151707 == 0)
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
			if (InteractSQL.smethod_13(string_2, text, string_))
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

	private void F3185E81_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DB372B0E(object sender, PaintEventArgs e)
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
		if (C615E7BC && DCB0191D != null)
		{
			DCB0191D.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.DCB0191D = new System.ComponentModel.Container();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.DCB0191D);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.CF0EA702 = new Bunifu.Framework.UI.BunifuDragControl(this.DCB0191D);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.nudSoLuongBaiTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.B233A63A = new System.Windows.Forms.NumericUpDown();
		this.F9024C25 = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label4 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.F3185E81 = new System.Windows.Forms.Button();
		this.A6A835A2 = new System.Windows.Forms.Button();
		this.CE89049C = new Bunifu.Framework.UI.BunifuCards();
		this.ckbOnlyDeleteTagPost = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B233A63A).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F9024C25).BeginInit();
		this.CE89049C.SuspendLayout();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Xóa bài viết trên tươ\u0300ng";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CF0EA702.Fixed = true;
		this.CF0EA702.Horizontal = true;
		this.CF0EA702.TargetControl = this.pnlHeader;
		this.CF0EA702.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
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
		this.button1.Image = Resources.C400940B;
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(AD20D4AE);
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
		this.panel1.Controls.Add(this.ckbOnlyDeleteTagPost);
		this.panel1.Controls.Add(this.nudSoLuongBaiTo);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.B233A63A);
		this.panel1.Controls.Add(this.F9024C25);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.F3185E81);
		this.panel1.Controls.Add(this.A6A835A2);
		this.panel1.Controls.Add(this.CE89049C);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 202);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(DB372B0E);
		this.nudSoLuongBaiTo.Location = new System.Drawing.Point(229, 78);
		this.nudSoLuongBaiTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongBaiTo.Name = "nudSoLuongBaiTo";
		this.nudSoLuongBaiTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiTo.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(229, 107);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.B233A63A.Location = new System.Drawing.Point(132, 78);
		this.B233A63A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B233A63A.Name = "nudSoLuongBaiFrom";
		this.B233A63A.Size = new System.Drawing.Size(56, 23);
		this.B233A63A.TabIndex = 3;
		this.F9024C25.Location = new System.Drawing.Point(132, 107);
		this.F9024C25.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F9024C25.Name = "nudDelayFrom";
		this.F9024C25.Size = new System.Drawing.Size(56, 23);
		this.F9024C25.TabIndex = 3;
		this.label8.Location = new System.Drawing.Point(194, 80);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(29, 16);
		this.label8.TabIndex = 38;
		this.label8.Text = "đê\u0301n";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 80);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 16);
		this.label4.TabIndex = 36;
		this.label4.Text = "bài";
		this.label7.Location = new System.Drawing.Point(194, 109);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(27, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(84, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Số lượng bài:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 109);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.F3185E81.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F3185E81.BackColor = System.Drawing.Color.Maroon;
		this.F3185E81.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F3185E81.FlatAppearance.BorderSize = 0;
		this.F3185E81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F3185E81.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F3185E81.ForeColor = System.Drawing.Color.White;
		this.F3185E81.Location = new System.Drawing.Point(189, 163);
		this.F3185E81.Name = "btnCancel";
		this.F3185E81.Size = new System.Drawing.Size(92, 29);
		this.F3185E81.TabIndex = 10;
		this.F3185E81.Text = "Đóng";
		this.F3185E81.UseVisualStyleBackColor = false;
		this.F3185E81.Click += new System.EventHandler(F3185E81_Click);
		this.A6A835A2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.A6A835A2.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.A6A835A2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A6A835A2.FlatAppearance.BorderSize = 0;
		this.A6A835A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A6A835A2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A6A835A2.ForeColor = System.Drawing.Color.White;
		this.A6A835A2.Location = new System.Drawing.Point(82, 163);
		this.A6A835A2.Name = "btnAdd";
		this.A6A835A2.Size = new System.Drawing.Size(92, 29);
		this.A6A835A2.TabIndex = 9;
		this.A6A835A2.Text = "Thêm";
		this.A6A835A2.UseVisualStyleBackColor = false;
		this.A6A835A2.Click += new System.EventHandler(A6A835A2_Click);
		this.CE89049C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CE89049C.BackColor = System.Drawing.Color.White;
		this.CE89049C.BorderRadius = 0;
		this.CE89049C.BottomSahddow = true;
		this.CE89049C.color = System.Drawing.Color.DarkViolet;
		this.CE89049C.Controls.Add(this.pnlHeader);
		this.CE89049C.LeftSahddow = false;
		this.CE89049C.Location = new System.Drawing.Point(1, 0);
		this.CE89049C.Name = "bunifuCards1";
		this.CE89049C.RightSahddow = true;
		this.CE89049C.ShadowDepth = 20;
		this.CE89049C.Size = new System.Drawing.Size(359, 37);
		this.CE89049C.TabIndex = 28;
		this.ckbOnlyDeleteTagPost.AutoSize = true;
		this.ckbOnlyDeleteTagPost.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyDeleteTagPost.Location = new System.Drawing.Point(132, 135);
		this.ckbOnlyDeleteTagPost.Name = "ckbOnlyDeleteTagPost";
		this.ckbOnlyDeleteTagPost.Size = new System.Drawing.Size(160, 20);
		this.ckbOnlyDeleteTagPost.TabIndex = 39;
		this.ckbOnlyDeleteTagPost.Text = "Chỉ xóa bài viết gắn thẻ";
		this.ckbOnlyDeleteTagPost.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 202);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaBaiTuong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXoaBaiTuong_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B233A63A).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F9024C25).EndInit();
		this.CE89049C.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
