using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDKetBanTheoTuKhoa : Form
{
	private JObject jobject_0;

	private string C0185329;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer B3098EAB = null;

	private BunifuDragControl B634489E;

	private BunifuDragControl bunifuDragControl_0;

	private Panel F5A75E9A;

	private NumericUpDown EFAE98B0;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label E0B03D19;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards F19B9C8F;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox E8196515;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label A695F91C;

	private Label lblStatus;

	private TextBox B9B9409D;

	private NumericUpDown B3A11FBC;

	private NumericUpDown nudDelayFrom;

	private Label FC0E4EB7;

	private Label F6AE4308;

	private Label label5;

	public fHDKetBanTheoTuKhoa(string string_2, int EF83108C = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		C0185329 = string_2;
		string_1 = string_3;
		int_0 = EF83108C;
		string json = "";
		switch (EF83108C)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanTheoTuKhoa");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(E0B03D19);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(FC0E4EB7);
		Language.smethod_0(F6AE4308);
		Language.smethod_0(lblStatus);
		Language.smethod_0(A695F91C);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void fHDKetBanTheoTuKhoa_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			EFAE98B0.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			B3A11FBC.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			B9B9409D.Text = jobject_0["txtTuKhoa"].ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B290712C(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = B9B9409D.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p từ khóa!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", EFAE98B0.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", B3A11FBC.Value);
		gClass.GetJson("txtTuKhoa", B9B9409D.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(C0185329, text, string_0, string_))
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

	private void A91EA30C(object sender, EventArgs e)
	{
		Close();
	}

	private void AA0F2939(object sender, PaintEventArgs e)
	{
		if (F5A75E9A.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F5A75E9A.ClientSize.Width - num, F5A75E9A.ClientSize.Height - num));
		}
	}

	private void F2BCFF3F(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = B9B9409D.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch từ khóa ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool FF8AFB8F)
	{
		if (FF8AFB8F && B3098EAB != null)
		{
			B3098EAB.Dispose();
		}
		base.Dispose(FF8AFB8F);
	}

	private void InitializeComponent()
	{
		this.B3098EAB = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTheoTuKhoa));
		this.B634489E = new Bunifu.Framework.UI.BunifuDragControl(this.B3098EAB);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.B3098EAB);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.E8196515 = new System.Windows.Forms.PictureBox();
		this.F5A75E9A = new System.Windows.Forms.Panel();
		this.B9B9409D = new System.Windows.Forms.TextBox();
		this.B3A11FBC = new System.Windows.Forms.NumericUpDown();
		this.A695F91C = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.FC0E4EB7 = new System.Windows.Forms.Label();
		this.F6AE4308 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.EFAE98B0 = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.E0B03D19 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.F19B9C8F = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E8196515).BeginInit();
		this.F5A75E9A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B3A11FBC).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EFAE98B0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.F19B9C8F.SuspendLayout();
		base.SuspendLayout();
		this.B634489E.Fixed = true;
		this.B634489E.Horizontal = true;
		this.B634489E.TargetControl = this.bunifuCustomLabel1;
		this.B634489E.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo từ khóa";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.E8196515);
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
		this.button1.Click += new System.EventHandler(button1_Click);
		this.E8196515.Cursor = System.Windows.Forms.Cursors.Default;
		this.E8196515.Image = Resources.Bitmap_4;
		this.E8196515.Location = new System.Drawing.Point(3, 2);
		this.E8196515.Name = "pictureBox1";
		this.E8196515.Size = new System.Drawing.Size(34, 27);
		this.E8196515.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E8196515.TabIndex = 76;
		this.E8196515.TabStop = false;
		this.F5A75E9A.BackColor = System.Drawing.Color.White;
		this.F5A75E9A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F5A75E9A.Controls.Add(this.B9B9409D);
		this.F5A75E9A.Controls.Add(this.B3A11FBC);
		this.F5A75E9A.Controls.Add(this.A695F91C);
		this.F5A75E9A.Controls.Add(this.lblStatus);
		this.F5A75E9A.Controls.Add(this.nudDelayFrom);
		this.F5A75E9A.Controls.Add(this.FC0E4EB7);
		this.F5A75E9A.Controls.Add(this.F6AE4308);
		this.F5A75E9A.Controls.Add(this.label5);
		this.F5A75E9A.Controls.Add(this.EFAE98B0);
		this.F5A75E9A.Controls.Add(this.nudSoLuongFrom);
		this.F5A75E9A.Controls.Add(this.txtTenHanhDong);
		this.F5A75E9A.Controls.Add(this.E0B03D19);
		this.F5A75E9A.Controls.Add(this.label4);
		this.F5A75E9A.Controls.Add(this.label2);
		this.F5A75E9A.Controls.Add(this.label1);
		this.F5A75E9A.Controls.Add(this.btnCancel);
		this.F5A75E9A.Controls.Add(this.btnAdd);
		this.F5A75E9A.Controls.Add(this.F19B9C8F);
		this.F5A75E9A.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.F5A75E9A.Dock = System.Windows.Forms.DockStyle.Fill;
		this.F5A75E9A.Location = new System.Drawing.Point(0, 0);
		this.F5A75E9A.Name = "panel1";
		this.F5A75E9A.Size = new System.Drawing.Size(362, 385);
		this.F5A75E9A.TabIndex = 0;
		this.F5A75E9A.Paint += new System.Windows.Forms.PaintEventHandler(AA0F2939);
		this.B9B9409D.Location = new System.Drawing.Point(31, 164);
		this.B9B9409D.Multiline = true;
		this.B9B9409D.Name = "txtTuKhoa";
		this.B9B9409D.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.B9B9409D.Size = new System.Drawing.Size(295, 138);
		this.B9B9409D.TabIndex = 5;
		this.B9B9409D.WordWrap = false;
		this.B9B9409D.TextChanged += new System.EventHandler(F2BCFF3F);
		this.B3A11FBC.Location = new System.Drawing.Point(229, 111);
		this.B3A11FBC.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B3A11FBC.Name = "nudDelayTo";
		this.B3A11FBC.Size = new System.Drawing.Size(56, 23);
		this.B3A11FBC.TabIndex = 4;
		this.A695F91C.AutoSize = true;
		this.A695F91C.Location = new System.Drawing.Point(28, 305);
		this.A695F91C.Name = "label8";
		this.A695F91C.Size = new System.Drawing.Size(259, 16);
		this.A695F91C.TabIndex = 0;
		this.A695F91C.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(27, 142);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch từ khóa (0):";
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.FC0E4EB7.Location = new System.Drawing.Point(194, 113);
		this.FC0E4EB7.Name = "label7";
		this.FC0E4EB7.Size = new System.Drawing.Size(29, 16);
		this.FC0E4EB7.TabIndex = 46;
		this.FC0E4EB7.Text = "đê\u0301n";
		this.FC0E4EB7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F6AE4308.AutoSize = true;
		this.F6AE4308.Location = new System.Drawing.Point(287, 113);
		this.F6AE4308.Name = "label6";
		this.F6AE4308.Size = new System.Drawing.Size(30, 16);
		this.F6AE4308.TabIndex = 45;
		this.F6AE4308.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.EFAE98B0.Location = new System.Drawing.Point(229, 80);
		this.EFAE98B0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.EFAE98B0.Name = "nudSoLuongTo";
		this.EFAE98B0.Size = new System.Drawing.Size(56, 23);
		this.EFAE98B0.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.E0B03D19.Location = new System.Drawing.Point(194, 82);
		this.E0B03D19.Name = "label3";
		this.E0B03D19.Size = new System.Drawing.Size(29, 16);
		this.E0B03D19.TabIndex = 37;
		this.E0B03D19.Text = "đê\u0301n";
		this.E0B03D19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
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
		this.btnCancel.Click += new System.EventHandler(A91EA30C);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(78, 336);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(B290712C);
		this.F19B9C8F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.F19B9C8F.BackColor = System.Drawing.Color.White;
		this.F19B9C8F.BorderRadius = 0;
		this.F19B9C8F.BottomSahddow = true;
		this.F19B9C8F.color = System.Drawing.Color.DarkViolet;
		this.F19B9C8F.Controls.Add(this.pnlHeader);
		this.F19B9C8F.LeftSahddow = false;
		this.F19B9C8F.Location = new System.Drawing.Point(1, 0);
		this.F19B9C8F.Name = "bunifuCards1";
		this.F19B9C8F.RightSahddow = true;
		this.F19B9C8F.ShadowDepth = 20;
		this.F19B9C8F.Size = new System.Drawing.Size(359, 37);
		this.F19B9C8F.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 385);
		base.Controls.Add(this.F5A75E9A);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTheoTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTheoTuKhoa_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E8196515).EndInit();
		this.F5A75E9A.ResumeLayout(false);
		this.F5A75E9A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.B3A11FBC).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EFAE98B0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.F19B9C8F.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
