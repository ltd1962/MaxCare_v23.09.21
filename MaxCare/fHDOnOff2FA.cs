using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDOnOff2FA : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string FD80C125;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl ED0F8C2F;

	private BunifuDragControl bunifuDragControl_0;

	private Panel C79E0994;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button E022B221;

	private Button FF2CF882;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button FF89C637;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private RadioButton rbBat2FA;

	private RadioButton D893923B;

	private Panel F683C510;

	private RadioButton D3A4D697;

	private RadioButton rbGiu2FACu;

	private RadioButton C73F0D2F;

	private Label CC861BAB;

	public fHDOnOff2FA(string D7325C1B, int B616E505 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = D7325C1B;
		FD80C125 = string_2;
		int_0 = B616E505;
		string text = base.Name.Substring(1);
		string text2 = "Bật - Tắt 2FA";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (B616E505)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			FF2CF882.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(D893923B);
		Language.smethod_0(rbBat2FA);
		Language.smethod_0(FF2CF882);
		Language.smethod_0(E022B221);
	}

	private void DD02CB29(object sender, EventArgs e)
	{
		try
		{
			if (gclass8_0.GetValueInt("typeOnOff2FA") == 0)
			{
				D893923B.Checked = true;
			}
			else
			{
				rbBat2FA.Checked = true;
			}
			if (gclass8_0.GetValueInt("neuDaCo2FA") == 0)
			{
				C73F0D2F.Checked = true;
			}
			else if (gclass8_0.GetValueInt("neuDaCo2FA") == 1)
			{
				rbGiu2FACu.Checked = true;
			}
			else
			{
				D3A4D697.Checked = true;
			}
			method_1(null, null);
			FCA42E34(null, null);
		}
		catch
		{
		}
	}

	private void A12C6D0D(object sender, EventArgs e)
	{
		Close();
	}

	private void FF2CF882_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		if (D893923B.Checked)
		{
			gClass.GetJson("typeOnOff2FA", 0);
		}
		else
		{
			gClass.GetJson("typeOnOff2FA", 1);
		}
		if (C73F0D2F.Checked)
		{
			gClass.GetJson("neuDaCo2FA", 0);
		}
		else if (rbGiu2FACu.Checked)
		{
			gClass.GetJson("neuDaCo2FA", 1);
		}
		else
		{
			gClass.GetJson("neuDaCo2FA", 2);
		}
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(FD80C125, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void E022B221_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C79E0994_Paint(object sender, PaintEventArgs e)
	{
		if (C79E0994.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C79E0994.ClientSize.Width - num, C79E0994.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void FCA42E34(object sender, EventArgs e)
	{
		F683C510.Enabled = rbBat2FA.Checked;
	}

	private void FA361404(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool FB95D219)
	{
		if (FB95D219 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FB95D219);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDOnOff2FA));
		this.ED0F8C2F = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.FF89C637 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C79E0994 = new System.Windows.Forms.Panel();
		this.F683C510 = new System.Windows.Forms.Panel();
		this.D3A4D697 = new System.Windows.Forms.RadioButton();
		this.rbGiu2FACu = new System.Windows.Forms.RadioButton();
		this.C73F0D2F = new System.Windows.Forms.RadioButton();
		this.CC861BAB = new System.Windows.Forms.Label();
		this.rbBat2FA = new System.Windows.Forms.RadioButton();
		this.D893923B = new System.Windows.Forms.RadioButton();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.E022B221 = new System.Windows.Forms.Button();
		this.FF2CF882 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.C79E0994.SuspendLayout();
		this.F683C510.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.ED0F8C2F.Fixed = true;
		this.ED0F8C2F.Horizontal = true;
		this.ED0F8C2F.TargetControl = this.bunifuCustomLabel1;
		this.ED0F8C2F.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(358, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Bật - Tắt 2FA";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.FF89C637);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(358, 31);
		this.pnlHeader.TabIndex = 9;
		this.FF89C637.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.FF89C637.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FF89C637.FlatAppearance.BorderSize = 0;
		this.FF89C637.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FF89C637.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FF89C637.ForeColor = System.Drawing.Color.White;
		this.FF89C637.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.FF89C637.Location = new System.Drawing.Point(327, 1);
		this.FF89C637.Name = "button1";
		this.FF89C637.Size = new System.Drawing.Size(30, 30);
		this.FF89C637.TabIndex = 77;
		this.FF89C637.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.FF89C637.UseVisualStyleBackColor = true;
		this.FF89C637.Click += new System.EventHandler(A12C6D0D);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(FA361404);
		this.C79E0994.BackColor = System.Drawing.Color.White;
		this.C79E0994.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C79E0994.Controls.Add(this.F683C510);
		this.C79E0994.Controls.Add(this.rbBat2FA);
		this.C79E0994.Controls.Add(this.D893923B);
		this.C79E0994.Controls.Add(this.txtTenHanhDong);
		this.C79E0994.Controls.Add(this.label1);
		this.C79E0994.Controls.Add(this.E022B221);
		this.C79E0994.Controls.Add(this.FF2CF882);
		this.C79E0994.Controls.Add(this.bunifuCards1);
		this.C79E0994.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C79E0994.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C79E0994.Location = new System.Drawing.Point(0, 0);
		this.C79E0994.Name = "panel1";
		this.C79E0994.Size = new System.Drawing.Size(361, 263);
		this.C79E0994.TabIndex = 0;
		this.C79E0994.Paint += new System.Windows.Forms.PaintEventHandler(C79E0994_Paint);
		this.F683C510.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F683C510.Controls.Add(this.D3A4D697);
		this.F683C510.Controls.Add(this.rbGiu2FACu);
		this.F683C510.Controls.Add(this.C73F0D2F);
		this.F683C510.Controls.Add(this.CC861BAB);
		this.F683C510.Location = new System.Drawing.Point(131, 105);
		this.F683C510.Name = "plBat2FA";
		this.F683C510.Size = new System.Drawing.Size(204, 97);
		this.F683C510.TabIndex = 48;
		this.D3A4D697.AutoSize = true;
		this.D3A4D697.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D3A4D697.Location = new System.Drawing.Point(6, 72);
		this.D3A4D697.Name = "rbXoa2FACu";
		this.D3A4D697.Size = new System.Drawing.Size(193, 20);
		this.D3A4D697.TabIndex = 34;
		this.D3A4D697.TabStop = true;
		this.D3A4D697.Text = "Xóa 2FA cũ rồi thêm 2FA mới";
		this.D3A4D697.UseVisualStyleBackColor = true;
		this.rbGiu2FACu.AutoSize = true;
		this.rbGiu2FACu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbGiu2FACu.Location = new System.Drawing.Point(6, 47);
		this.rbGiu2FACu.Name = "rbGiu2FACu";
		this.rbGiu2FACu.Size = new System.Drawing.Size(188, 20);
		this.rbGiu2FACu.TabIndex = 33;
		this.rbGiu2FACu.TabStop = true;
		this.rbGiu2FACu.Text = "Giữ 2FA cũ và thêm 2FA mới";
		this.rbGiu2FACu.UseVisualStyleBackColor = true;
		this.C73F0D2F.AutoSize = true;
		this.C73F0D2F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C73F0D2F.Location = new System.Drawing.Point(6, 22);
		this.C73F0D2F.Name = "rbKhongBat2FA";
		this.C73F0D2F.Size = new System.Drawing.Size(134, 20);
		this.C73F0D2F.TabIndex = 32;
		this.C73F0D2F.TabStop = true;
		this.C73F0D2F.Text = "Không bật 2FA nữa";
		this.C73F0D2F.UseVisualStyleBackColor = true;
		this.CC861BAB.AutoSize = true;
		this.CC861BAB.Location = new System.Drawing.Point(3, 2);
		this.CC861BAB.Name = "label2";
		this.CC861BAB.Size = new System.Drawing.Size(169, 16);
		this.CC861BAB.TabIndex = 31;
		this.CC861BAB.Text = "Nếu tài khoản đã có 2FA thì:";
		this.rbBat2FA.AutoSize = true;
		this.rbBat2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbBat2FA.Location = new System.Drawing.Point(30, 105);
		this.rbBat2FA.Name = "rbBat2FA";
		this.rbBat2FA.Size = new System.Drawing.Size(69, 20);
		this.rbBat2FA.TabIndex = 47;
		this.rbBat2FA.Text = "Bật 2FA";
		this.rbBat2FA.UseVisualStyleBackColor = true;
		this.rbBat2FA.CheckedChanged += new System.EventHandler(FCA42E34);
		this.D893923B.AutoSize = true;
		this.D893923B.Checked = true;
		this.D893923B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D893923B.Location = new System.Drawing.Point(29, 81);
		this.D893923B.Name = "rbTat2FA";
		this.D893923B.Size = new System.Drawing.Size(70, 20);
		this.D893923B.TabIndex = 47;
		this.D893923B.TabStop = true;
		this.D893923B.Text = "Tắt 2FA";
		this.D893923B.UseVisualStyleBackColor = true;
		this.txtTenHanhDong.Location = new System.Drawing.Point(131, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(204, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(26, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.E022B221.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.E022B221.BackColor = System.Drawing.Color.Maroon;
		this.E022B221.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E022B221.FlatAppearance.BorderSize = 0;
		this.E022B221.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E022B221.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E022B221.ForeColor = System.Drawing.Color.White;
		this.E022B221.Location = new System.Drawing.Point(187, 218);
		this.E022B221.Name = "btnCancel";
		this.E022B221.Size = new System.Drawing.Size(92, 29);
		this.E022B221.TabIndex = 7;
		this.E022B221.Text = "Đóng";
		this.E022B221.UseVisualStyleBackColor = false;
		this.E022B221.Click += new System.EventHandler(E022B221_Click);
		this.FF2CF882.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.FF2CF882.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.FF2CF882.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FF2CF882.FlatAppearance.BorderSize = 0;
		this.FF2CF882.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FF2CF882.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FF2CF882.ForeColor = System.Drawing.Color.White;
		this.FF2CF882.Location = new System.Drawing.Point(80, 218);
		this.FF2CF882.Name = "btnAdd";
		this.FF2CF882.Size = new System.Drawing.Size(92, 29);
		this.FF2CF882.TabIndex = 6;
		this.FF2CF882.Text = "Thêm";
		this.FF2CF882.UseVisualStyleBackColor = false;
		this.FF2CF882.Click += new System.EventHandler(FF2CF882_Click);
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
		this.bunifuCards1.Size = new System.Drawing.Size(358, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(361, 263);
		base.Controls.Add(this.C79E0994);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDOnOff2FA";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DD02CB29);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.C79E0994.ResumeLayout(false);
		this.C79E0994.PerformLayout();
		this.F683C510.ResumeLayout(false);
		this.F683C510.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
