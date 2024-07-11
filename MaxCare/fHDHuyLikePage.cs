using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDHuyLikePage : Form
{
	private JSON_Settings gclass8_0;

	private string A58A9F31;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl DE0BEBBF;

	private BunifuDragControl bunifuDragControl_0;

	private Panel A03B7F0A;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label D32F55AD;

	private Label ACBC771F;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown D307990F;

	private NumericUpDown BA873A99;

	private Label AA1D2F92;

	private Label label6;

	private Label A4965637;

	public fHDHuyLikePage(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		A58A9F31 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDHuyLikePage").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDHuyLikePage', 'Hủy like page');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDHuyLikePage");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void C81E2639()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(ACBC771F);
		Language.smethod_0(label3);
		Language.smethod_0(D32F55AD);
		Language.smethod_0(A4965637);
		Language.smethod_0(AA1D2F92);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void ECABC6B3_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 3);
			BA873A99.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			D307990F.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void E11B2414(object sender, EventArgs e)
	{
		Close();
	}

	private void CF8B4F1C(object sender, EventArgs e)
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
		gClass.GetJson("nudDelayFrom", BA873A99.Value);
		gClass.GetJson("nudDelayTo", D307990F.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(A58A9F31, text, string_0, string_))
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

	private void EB0AC836(object sender, EventArgs e)
	{
		Close();
	}

	private void C117F28D(object sender, PaintEventArgs e)
	{
		if (A03B7F0A.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A03B7F0A.ClientSize.Width - num, A03B7F0A.ClientSize.Height - num));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyLikePage));
		this.DE0BEBBF = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.A03B7F0A = new System.Windows.Forms.Panel();
		this.D307990F = new System.Windows.Forms.NumericUpDown();
		this.BA873A99 = new System.Windows.Forms.NumericUpDown();
		this.AA1D2F92 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.A4965637 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.D32F55AD = new System.Windows.Forms.Label();
		this.ACBC771F = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.A03B7F0A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D307990F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.BA873A99).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.DE0BEBBF.Fixed = true;
		this.DE0BEBBF.Horizontal = true;
		this.DE0BEBBF.TargetControl = this.bunifuCustomLabel1;
		this.DE0BEBBF.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Hủy like page";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
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
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(E11B2414);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.A03B7F0A.BackColor = System.Drawing.Color.White;
		this.A03B7F0A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A03B7F0A.Controls.Add(this.D307990F);
		this.A03B7F0A.Controls.Add(this.BA873A99);
		this.A03B7F0A.Controls.Add(this.AA1D2F92);
		this.A03B7F0A.Controls.Add(this.label6);
		this.A03B7F0A.Controls.Add(this.A4965637);
		this.A03B7F0A.Controls.Add(this.nudSoLuongTo);
		this.A03B7F0A.Controls.Add(this.nudSoLuongFrom);
		this.A03B7F0A.Controls.Add(this.txtTenHanhDong);
		this.A03B7F0A.Controls.Add(this.label3);
		this.A03B7F0A.Controls.Add(this.D32F55AD);
		this.A03B7F0A.Controls.Add(this.ACBC771F);
		this.A03B7F0A.Controls.Add(this.label1);
		this.A03B7F0A.Controls.Add(this.btnCancel);
		this.A03B7F0A.Controls.Add(this.btnAdd);
		this.A03B7F0A.Controls.Add(this.bunifuCards1);
		this.A03B7F0A.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.A03B7F0A.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A03B7F0A.Location = new System.Drawing.Point(0, 0);
		this.A03B7F0A.Name = "panel1";
		this.A03B7F0A.Size = new System.Drawing.Size(362, 206);
		this.A03B7F0A.TabIndex = 0;
		this.A03B7F0A.Paint += new System.Windows.Forms.PaintEventHandler(C117F28D);
		this.D307990F.Location = new System.Drawing.Point(223, 112);
		this.D307990F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D307990F.Name = "nudDelayTo";
		this.D307990F.Size = new System.Drawing.Size(56, 23);
		this.D307990F.TabIndex = 4;
		this.BA873A99.Location = new System.Drawing.Point(132, 112);
		this.BA873A99.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.BA873A99.Name = "nudDelayFrom";
		this.BA873A99.Size = new System.Drawing.Size(56, 23);
		this.BA873A99.TabIndex = 3;
		this.AA1D2F92.Location = new System.Drawing.Point(191, 114);
		this.AA1D2F92.Name = "label7";
		this.AA1D2F92.Size = new System.Drawing.Size(29, 16);
		this.AA1D2F92.TabIndex = 46;
		this.AA1D2F92.Text = "đê\u0301n";
		this.AA1D2F92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(280, 114);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.A4965637.AutoSize = true;
		this.A4965637.Location = new System.Drawing.Point(27, 114);
		this.A4965637.Name = "label5";
		this.A4965637.Size = new System.Drawing.Size(89, 16);
		this.A4965637.TabIndex = 44;
		this.A4965637.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(223, 81);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 81);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(191, 83);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D32F55AD.AutoSize = true;
		this.D32F55AD.Location = new System.Drawing.Point(280, 83);
		this.D32F55AD.Name = "label4";
		this.D32F55AD.Size = new System.Drawing.Size(35, 16);
		this.D32F55AD.TabIndex = 35;
		this.D32F55AD.Text = "page";
		this.ACBC771F.AutoSize = true;
		this.ACBC771F.Location = new System.Drawing.Point(27, 83);
		this.ACBC771F.Name = "label2";
		this.ACBC771F.Size = new System.Drawing.Size(63, 16);
		this.ACBC771F.TabIndex = 32;
		this.ACBC771F.Text = "Sô\u0301 lươ\u0323ng:";
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
		this.btnCancel.Location = new System.Drawing.Point(191, 158);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(EB0AC836);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(84, 158);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(CF8B4F1C);
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
		base.ClientSize = new System.Drawing.Size(362, 206);
		base.Controls.Add(this.A03B7F0A);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyLikePage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(ECABC6B3_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.A03B7F0A.ResumeLayout(false);
		this.A03B7F0A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.D307990F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.BA873A99).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
