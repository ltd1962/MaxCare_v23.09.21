using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDChocBanBe : Form
{
	private JObject jobject_0;

	private string EB1AB902;

	private string string_0;

	private string C8A4F712;

	private int FC95AA2E;

	public static bool B088360B;

	private IContainer icontainer_0 = null;

	private BunifuDragControl CE2B5F24;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown E6276707;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown CFBE6629;

	private TextBox txtTenHanhDong;

	private Label F0A5842F;

	private Label label3;

	private Label label6;

	private Label D4B6223E;

	private Label label5;

	private Label label2;

	private Label CA2DBA8F;

	private Button C43A6088;

	private Button A011BD1E;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button BC20E7A3;

	private PictureBox pictureBox1;

	private BunifuCustomLabel FCB48C97;

	public fHDChocBanBe(string string_1, int E4AD81A2 = 0, string string_2 = "")
	{
		InitializeComponent();
		B088360B = false;
		EB1AB902 = string_1;
		C8A4F712 = string_2;
		FC95AA2E = E4AD81A2;
		string json = "";
		switch (E4AD81A2)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDChocBanBe");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			A011BD1E.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void C63E0680()
	{
		Language.smethod_0(FCB48C97);
		Language.smethod_0(CA2DBA8F);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(D4B6223E);
		Language.smethod_0(label5);
		Language.smethod_0(F0A5842F);
		Language.smethod_0(label6);
		Language.smethod_0(A011BD1E);
		Language.smethod_0(C43A6088);
	}

	private void F305BCBF(object sender, EventArgs e)
	{
		try
		{
			CFBE6629.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			E6276707.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void F983DA96(object sender, EventArgs e)
	{
		Close();
	}

	private void A011BD1E_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", CFBE6629.Value);
		gClass.GetJson("nudSoLuongTo", E6276707.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.D9A09B34();
		if (FC95AA2E == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(EB1AB902, text, string_0, text2))
				{
					B088360B = true;
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
			if (InteractSQL.smethod_13(C8A4F712, text, text2))
			{
				B088360B = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void C43A6088_Click(object sender, EventArgs e)
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
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChocBanBe));
		this.CE2B5F24 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.FCB48C97 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.BC20E7A3 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.E6276707 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.CFBE6629 = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.F0A5842F = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.D4B6223E = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.CA2DBA8F = new System.Windows.Forms.Label();
		this.C43A6088 = new System.Windows.Forms.Button();
		this.A011BD1E = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E6276707).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CFBE6629).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.CE2B5F24.Fixed = true;
		this.CE2B5F24.Horizontal = true;
		this.CE2B5F24.TargetControl = this.FCB48C97;
		this.CE2B5F24.Vertical = true;
		this.FCB48C97.BackColor = System.Drawing.Color.Transparent;
		this.FCB48C97.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.FCB48C97.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FCB48C97.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FCB48C97.ForeColor = System.Drawing.Color.Black;
		this.FCB48C97.Location = new System.Drawing.Point(0, 0);
		this.FCB48C97.Name = "bunifuCustomLabel1";
		this.FCB48C97.Size = new System.Drawing.Size(359, 31);
		this.FCB48C97.TabIndex = 12;
		this.FCB48C97.Text = "Cấu hình Cho\u0323c ba\u0323n be\u0300";
		this.FCB48C97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.BC20E7A3);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.FCB48C97);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.BC20E7A3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BC20E7A3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BC20E7A3.FlatAppearance.BorderSize = 0;
		this.BC20E7A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BC20E7A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BC20E7A3.ForeColor = System.Drawing.Color.White;
		this.BC20E7A3.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.BC20E7A3.Location = new System.Drawing.Point(328, 1);
		this.BC20E7A3.Name = "button1";
		this.BC20E7A3.Size = new System.Drawing.Size(30, 30);
		this.BC20E7A3.TabIndex = 77;
		this.BC20E7A3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.BC20E7A3.UseVisualStyleBackColor = true;
		this.BC20E7A3.Click += new System.EventHandler(F983DA96);
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
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.E6276707);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.CFBE6629);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.F0A5842F);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.D4B6223E);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.CA2DBA8F);
		this.panel1.Controls.Add(this.C43A6088);
		this.panel1.Controls.Add(this.A011BD1E);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 199);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.nudDelayTo.Location = new System.Drawing.Point(229, 107);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.E6276707.Location = new System.Drawing.Point(229, 78);
		this.E6276707.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E6276707.Name = "nudSoLuongTo";
		this.E6276707.Size = new System.Drawing.Size(56, 23);
		this.E6276707.TabIndex = 2;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.CFBE6629.Location = new System.Drawing.Point(132, 78);
		this.CFBE6629.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CFBE6629.Name = "nudSoLuongFrom";
		this.CFBE6629.Size = new System.Drawing.Size(56, 23);
		this.CFBE6629.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.F0A5842F.Location = new System.Drawing.Point(194, 109);
		this.F0A5842F.Name = "label7";
		this.F0A5842F.Size = new System.Drawing.Size(29, 16);
		this.F0A5842F.TabIndex = 38;
		this.F0A5842F.Text = "đê\u0301n";
		this.F0A5842F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(194, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.D4B6223E.AutoSize = true;
		this.D4B6223E.Location = new System.Drawing.Point(287, 80);
		this.D4B6223E.Name = "label4";
		this.D4B6223E.Size = new System.Drawing.Size(28, 16);
		this.D4B6223E.TabIndex = 35;
		this.D4B6223E.Text = "ba\u0323n";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 109);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 80);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(93, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng cho\u0323c:";
		this.CA2DBA8F.AutoSize = true;
		this.CA2DBA8F.Location = new System.Drawing.Point(27, 52);
		this.CA2DBA8F.Name = "label1";
		this.CA2DBA8F.Size = new System.Drawing.Size(98, 16);
		this.CA2DBA8F.TabIndex = 31;
		this.CA2DBA8F.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.C43A6088.BackColor = System.Drawing.Color.Maroon;
		this.C43A6088.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C43A6088.FlatAppearance.BorderSize = 0;
		this.C43A6088.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C43A6088.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C43A6088.ForeColor = System.Drawing.Color.White;
		this.C43A6088.Location = new System.Drawing.Point(189, 154);
		this.C43A6088.Name = "btnCancel";
		this.C43A6088.Size = new System.Drawing.Size(92, 29);
		this.C43A6088.TabIndex = 10;
		this.C43A6088.Text = "Đóng";
		this.C43A6088.UseVisualStyleBackColor = false;
		this.C43A6088.Click += new System.EventHandler(C43A6088_Click);
		this.A011BD1E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.A011BD1E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A011BD1E.FlatAppearance.BorderSize = 0;
		this.A011BD1E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A011BD1E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A011BD1E.ForeColor = System.Drawing.Color.White;
		this.A011BD1E.Location = new System.Drawing.Point(82, 154);
		this.A011BD1E.Name = "btnAdd";
		this.A011BD1E.Size = new System.Drawing.Size(92, 29);
		this.A011BD1E.TabIndex = 9;
		this.A011BD1E.Text = "Thêm";
		this.A011BD1E.UseVisualStyleBackColor = false;
		this.A011BD1E.Click += new System.EventHandler(A011BD1E_Click);
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
		base.ClientSize = new System.Drawing.Size(362, 199);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChocBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F305BCBF);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E6276707).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CFBE6629).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
