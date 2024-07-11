using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanTepUidNew : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string string_1;

	private string F3AEA7BA;

	private int int_0;

	public static bool C6248D1C;

	private IContainer icontainer_0 = null;

	private BunifuDragControl F020C6B0;

	private BunifuDragControl bunifuDragControl_0;

	private Panel C52A0635;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button E00FD9B8;

	private Button B5093514;

	private BunifuCards bunifuCards1;

	private Panel D39B3E01;

	private Button DF36291A;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label label5;

	private NumericUpDown A22E0CA1;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label CA876480;

	private NumericUpDown F99D94AB;

	private NumericUpDown FCB35B02;

	private Label label3;

	private Label label4;

	private Label label8;

	private RichTextBox txtLink;

	private Label E80BDB29;

	public fHDKetBanTepUidNew(string string_2, int ED3A0015 = 0, string string_3 = "")
	{
		InitializeComponent();
		C6248D1C = false;
		string_0 = string_2;
		F3AEA7BA = string_3;
		int_0 = ED3A0015;
		if (InteractSQL.B484648C("", "HDKetBanTepUidNew").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTepUidNew', 'Kết bạn theo tệp Uid v2');");
		}
		string text = "";
		switch (ED3A0015)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanTepUidNew");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			B5093514.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void F9B2A3BB()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label8);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(CA876480);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(label5);
		Language.smethod_0(E80BDB29);
		Language.smethod_0(B5093514);
		Language.smethod_0(E00FD9B8);
	}

	private void FA021095(object sender, EventArgs e)
	{
		try
		{
			txtLink.Text = gclass8_0.GetValue("txtLink");
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			A22E0CA1.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			FCB35B02.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 3);
			F99D94AB.Value = gclass8_0.GetValueInt("nudSoLuongTo", 3);
		}
		catch
		{
		}
	}

	private void DF36291A_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DF035215(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtLink", txtLink.Text);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", A22E0CA1.Value);
		gClass.GetJson("nudSoLuongFrom", FCB35B02.Value);
		gClass.GetJson("nudSoLuongTo", F99D94AB.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					C6248D1C = true;
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
			if (InteractSQL.smethod_13(F3AEA7BA, text, string_))
			{
				C6248D1C = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void CA133E3D(object sender, EventArgs e)
	{
		Close();
	}

	private void C52A0635_Paint(object sender, PaintEventArgs e)
	{
		if (C52A0635.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C52A0635.ClientSize.Width - num, C52A0635.ClientSize.Height - num));
		}
	}

	private void BD039807(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtLink.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label5.Text = string.Format(Language.GetValue("Danh sách Link bài viết ({0}):"), a2AB53A.Count.ToString());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTepUidNew));
		this.F020C6B0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D39B3E01 = new System.Windows.Forms.Panel();
		this.DF36291A = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C52A0635 = new System.Windows.Forms.Panel();
		this.txtLink = new System.Windows.Forms.RichTextBox();
		this.E80BDB29 = new System.Windows.Forms.Label();
		this.A22E0CA1 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.CA876480 = new System.Windows.Forms.Label();
		this.F99D94AB = new System.Windows.Forms.NumericUpDown();
		this.FCB35B02 = new System.Windows.Forms.NumericUpDown();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.E00FD9B8 = new System.Windows.Forms.Button();
		this.B5093514 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.D39B3E01.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.C52A0635.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.A22E0CA1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F99D94AB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FCB35B02).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.F020C6B0.Fixed = true;
		this.F020C6B0.Horizontal = true;
		this.F020C6B0.TargetControl = this.bunifuCustomLabel1;
		this.F020C6B0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp Uid v2";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.D39B3E01;
		this.bunifuDragControl_0.Vertical = true;
		this.D39B3E01.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D39B3E01.BackColor = System.Drawing.Color.White;
		this.D39B3E01.Controls.Add(this.DF36291A);
		this.D39B3E01.Controls.Add(this.pictureBox1);
		this.D39B3E01.Controls.Add(this.bunifuCustomLabel1);
		this.D39B3E01.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D39B3E01.Location = new System.Drawing.Point(0, 3);
		this.D39B3E01.Name = "pnlHeader";
		this.D39B3E01.Size = new System.Drawing.Size(359, 31);
		this.D39B3E01.TabIndex = 9;
		this.DF36291A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DF36291A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DF36291A.FlatAppearance.BorderSize = 0;
		this.DF36291A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DF36291A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DF36291A.ForeColor = System.Drawing.Color.White;
		this.DF36291A.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.DF36291A.Location = new System.Drawing.Point(328, 1);
		this.DF36291A.Name = "button1";
		this.DF36291A.Size = new System.Drawing.Size(30, 30);
		this.DF36291A.TabIndex = 77;
		this.DF36291A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.DF36291A.UseVisualStyleBackColor = true;
		this.DF36291A.Click += new System.EventHandler(DF36291A_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.C52A0635.BackColor = System.Drawing.Color.White;
		this.C52A0635.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C52A0635.Controls.Add(this.txtLink);
		this.C52A0635.Controls.Add(this.E80BDB29);
		this.C52A0635.Controls.Add(this.A22E0CA1);
		this.C52A0635.Controls.Add(this.nudDelayFrom);
		this.C52A0635.Controls.Add(this.label7);
		this.C52A0635.Controls.Add(this.label6);
		this.C52A0635.Controls.Add(this.CA876480);
		this.C52A0635.Controls.Add(this.F99D94AB);
		this.C52A0635.Controls.Add(this.FCB35B02);
		this.C52A0635.Controls.Add(this.label3);
		this.C52A0635.Controls.Add(this.label4);
		this.C52A0635.Controls.Add(this.label8);
		this.C52A0635.Controls.Add(this.txtTenHanhDong);
		this.C52A0635.Controls.Add(this.label5);
		this.C52A0635.Controls.Add(this.label1);
		this.C52A0635.Controls.Add(this.E00FD9B8);
		this.C52A0635.Controls.Add(this.B5093514);
		this.C52A0635.Controls.Add(this.bunifuCards1);
		this.C52A0635.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C52A0635.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C52A0635.Location = new System.Drawing.Point(0, 0);
		this.C52A0635.Name = "panel1";
		this.C52A0635.Size = new System.Drawing.Size(362, 417);
		this.C52A0635.TabIndex = 0;
		this.C52A0635.Paint += new System.Windows.Forms.PaintEventHandler(C52A0635_Paint);
		this.txtLink.Location = new System.Drawing.Point(31, 160);
		this.txtLink.Name = "txtLink";
		this.txtLink.Size = new System.Drawing.Size(297, 189);
		this.txtLink.TabIndex = 57;
		this.txtLink.Text = "";
		this.txtLink.WordWrap = false;
		this.txtLink.TextChanged += new System.EventHandler(BD039807);
		this.E80BDB29.AutoSize = true;
		this.E80BDB29.Location = new System.Drawing.Point(29, 352);
		this.E80BDB29.Name = "label10";
		this.E80BDB29.Size = new System.Drawing.Size(96, 16);
		this.E80BDB29.TabIndex = 58;
		this.E80BDB29.Text = "(Mỗi ID 1 dòng)";
		this.A22E0CA1.Location = new System.Drawing.Point(231, 109);
		this.A22E0CA1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A22E0CA1.Name = "nudDelayTo";
		this.A22E0CA1.Size = new System.Drawing.Size(56, 23);
		this.A22E0CA1.TabIndex = 50;
		this.nudDelayFrom.Location = new System.Drawing.Point(134, 109);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 49;
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(196, 111);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(28, 16);
		this.label7.TabIndex = 56;
		this.label7.Text = "đê\u0301n";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(292, 111);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 55;
		this.label6.Text = "giây";
		this.CA876480.AutoSize = true;
		this.CA876480.Location = new System.Drawing.Point(27, 111);
		this.CA876480.Name = "label2";
		this.CA876480.Size = new System.Drawing.Size(89, 16);
		this.CA876480.TabIndex = 54;
		this.CA876480.Text = "Thơ\u0300i gian chơ\u0300:";
		this.F99D94AB.Location = new System.Drawing.Point(231, 78);
		this.F99D94AB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F99D94AB.Name = "nudSoLuongTo";
		this.F99D94AB.Size = new System.Drawing.Size(56, 23);
		this.F99D94AB.TabIndex = 48;
		this.FCB35B02.Location = new System.Drawing.Point(134, 78);
		this.FCB35B02.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FCB35B02.Name = "nudSoLuongFrom";
		this.FCB35B02.Size = new System.Drawing.Size(56, 23);
		this.FCB35B02.TabIndex = 47;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(196, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(28, 16);
		this.label3.TabIndex = 53;
		this.label3.Text = "đê\u0301n";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(292, 80);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 52;
		this.label4.Text = "ba\u0323n";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(27, 80);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(88, 16);
		this.label8.TabIndex = 51;
		this.label8.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 141);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(163, 16);
		this.label5.TabIndex = 31;
		this.label5.Text = "Danh sách Link bài viết (0):";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.E00FD9B8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.E00FD9B8.BackColor = System.Drawing.Color.Maroon;
		this.E00FD9B8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E00FD9B8.FlatAppearance.BorderSize = 0;
		this.E00FD9B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E00FD9B8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E00FD9B8.ForeColor = System.Drawing.Color.White;
		this.E00FD9B8.Location = new System.Drawing.Point(189, 373);
		this.E00FD9B8.Name = "btnCancel";
		this.E00FD9B8.Size = new System.Drawing.Size(92, 29);
		this.E00FD9B8.TabIndex = 10;
		this.E00FD9B8.Text = "Đóng";
		this.E00FD9B8.UseVisualStyleBackColor = false;
		this.E00FD9B8.Click += new System.EventHandler(CA133E3D);
		this.B5093514.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.B5093514.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.B5093514.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B5093514.FlatAppearance.BorderSize = 0;
		this.B5093514.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B5093514.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B5093514.ForeColor = System.Drawing.Color.White;
		this.B5093514.Location = new System.Drawing.Point(82, 373);
		this.B5093514.Name = "btnAdd";
		this.B5093514.Size = new System.Drawing.Size(92, 29);
		this.B5093514.TabIndex = 9;
		this.B5093514.Text = "Thêm";
		this.B5093514.UseVisualStyleBackColor = false;
		this.B5093514.Click += new System.EventHandler(DF035215);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.D39B3E01);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 417);
		base.Controls.Add(this.C52A0635);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUidNew";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FA021095);
		this.D39B3E01.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.C52A0635.ResumeLayout(false);
		this.C52A0635.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.A22E0CA1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F99D94AB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FCB35B02).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
