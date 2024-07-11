using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDKetBanVip : Form
{
	private JSON_Settings gclass8_0;

	private string BE13B014;

	private string B33518B1;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer F993F13F = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel C217D328;

	private NumericUpDown F812479E;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label E8BC6DA7;

	private Label CF3ECE88;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button C68C3206;

	private PictureBox C79A92A3;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label F8132983;

	private Label label5;

	private RichTextBox txtCode;

	private Label D01D91A6;

	private TextBox txtLink;

	private Label E7AE3382;

	public fHDKetBanVip(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		BE13B014 = string_1;
		string_0 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Kết bạn vip";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			B33518B1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDKetBanVip_Load(object sender, EventArgs e)
	{
		try
		{
			txtLink.Text = gclass8_0.GetValue("txtLink");
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom");
			F812479E.Value = gclass8_0.GetValueInt("nudSoLuongTo");
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom");
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo");
			txtCode.Text = gclass8_0.GetValue("txtCode");
		}
		catch
		{
		}
	}

	private void B930082E(object sender, EventArgs e)
	{
		Close();
	}

	private void A1113DB9(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtLink", txtLink.Text);
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", F812479E.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtCode", txtCode.Text);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(BE13B014, text, B33518B1, text2))
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
			if (InteractSQL.smethod_13(string_0, text, text2))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C217D328_Paint(object sender, PaintEventArgs e)
	{
		if (C217D328.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C217D328.ClientSize.Width - num, C217D328.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F993F13F != null)
		{
			F993F13F.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.F993F13F = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanVip));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.F993F13F);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.F993F13F);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.C68C3206 = new System.Windows.Forms.Button();
		this.C79A92A3 = new System.Windows.Forms.PictureBox();
		this.C217D328 = new System.Windows.Forms.Panel();
		this.txtCode = new System.Windows.Forms.RichTextBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.F8132983 = new System.Windows.Forms.Label();
		this.D01D91A6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.F812479E = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtLink = new System.Windows.Forms.TextBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.E7AE3382 = new System.Windows.Forms.Label();
		this.E8BC6DA7 = new System.Windows.Forms.Label();
		this.CF3ECE88 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.C79A92A3).BeginInit();
		this.C217D328.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F812479E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn vip";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.C68C3206);
		this.pnlHeader.Controls.Add(this.C79A92A3);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.C68C3206.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C68C3206.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C68C3206.FlatAppearance.BorderSize = 0;
		this.C68C3206.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C68C3206.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C68C3206.ForeColor = System.Drawing.Color.White;
		this.C68C3206.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.C68C3206.Location = new System.Drawing.Point(328, 1);
		this.C68C3206.Name = "button1";
		this.C68C3206.Size = new System.Drawing.Size(30, 30);
		this.C68C3206.TabIndex = 77;
		this.C68C3206.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C68C3206.UseVisualStyleBackColor = true;
		this.C68C3206.Click += new System.EventHandler(B930082E);
		this.C79A92A3.Cursor = System.Windows.Forms.Cursors.Default;
		this.C79A92A3.Image = Resources.Bitmap_4;
		this.C79A92A3.Location = new System.Drawing.Point(3, 2);
		this.C79A92A3.Name = "pictureBox1";
		this.C79A92A3.Size = new System.Drawing.Size(34, 27);
		this.C79A92A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.C79A92A3.TabIndex = 76;
		this.C79A92A3.TabStop = false;
		this.C217D328.BackColor = System.Drawing.Color.White;
		this.C217D328.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C217D328.Controls.Add(this.txtCode);
		this.C217D328.Controls.Add(this.nudDelayTo);
		this.C217D328.Controls.Add(this.nudDelayFrom);
		this.C217D328.Controls.Add(this.label7);
		this.C217D328.Controls.Add(this.F8132983);
		this.C217D328.Controls.Add(this.D01D91A6);
		this.C217D328.Controls.Add(this.label5);
		this.C217D328.Controls.Add(this.F812479E);
		this.C217D328.Controls.Add(this.nudSoLuongFrom);
		this.C217D328.Controls.Add(this.txtLink);
		this.C217D328.Controls.Add(this.txtTenHanhDong);
		this.C217D328.Controls.Add(this.label3);
		this.C217D328.Controls.Add(this.label4);
		this.C217D328.Controls.Add(this.E7AE3382);
		this.C217D328.Controls.Add(this.E8BC6DA7);
		this.C217D328.Controls.Add(this.CF3ECE88);
		this.C217D328.Controls.Add(this.btnCancel);
		this.C217D328.Controls.Add(this.btnAdd);
		this.C217D328.Controls.Add(this.bunifuCards1);
		this.C217D328.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C217D328.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C217D328.Location = new System.Drawing.Point(0, 0);
		this.C217D328.Name = "panel1";
		this.C217D328.Size = new System.Drawing.Size(362, 303);
		this.C217D328.TabIndex = 0;
		this.C217D328.Paint += new System.Windows.Forms.PaintEventHandler(C217D328_Paint);
		this.txtCode.Location = new System.Drawing.Point(141, 165);
		this.txtCode.Name = "txtCode";
		this.txtCode.Size = new System.Drawing.Size(185, 79);
		this.txtCode.TabIndex = 47;
		this.txtCode.Text = "";
		this.txtCode.WordWrap = false;
		this.nudDelayTo.Location = new System.Drawing.Point(218, 136);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(141, 136);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new System.Drawing.Point(194, 138);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = ">";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F8132983.AutoSize = true;
		this.F8132983.Location = new System.Drawing.Point(276, 138);
		this.F8132983.Name = "label6";
		this.F8132983.Size = new System.Drawing.Size(30, 16);
		this.F8132983.TabIndex = 45;
		this.F8132983.Text = "giây";
		this.D01D91A6.AutoSize = true;
		this.D01D91A6.Location = new System.Drawing.Point(27, 165);
		this.D01D91A6.Name = "label8";
		this.D01D91A6.Size = new System.Drawing.Size(95, 16);
		this.D01D91A6.TabIndex = 44;
		this.D01D91A6.Text = "Code cần chạy:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 138);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(109, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Delay cuộn chuột:";
		this.F812479E.Location = new System.Drawing.Point(218, 107);
		this.F812479E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F812479E.Name = "nudSoLuongTo";
		this.F812479E.Size = new System.Drawing.Size(56, 23);
		this.F812479E.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(141, 107);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtLink.Location = new System.Drawing.Point(141, 78);
		this.txtLink.Name = "txtLink";
		this.txtLink.Size = new System.Drawing.Size(185, 23);
		this.txtLink.TabIndex = 0;
		this.txtTenHanhDong.Location = new System.Drawing.Point(141, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(185, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(194, 109);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = ">";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(276, 109);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "lần";
		this.E7AE3382.AutoSize = true;
		this.E7AE3382.Location = new System.Drawing.Point(27, 81);
		this.E7AE3382.Name = "label9";
		this.E7AE3382.Size = new System.Drawing.Size(92, 16);
		this.E7AE3382.TabIndex = 31;
		this.E7AE3382.Text = "Nhập link web:";
		this.E8BC6DA7.AutoSize = true;
		this.E8BC6DA7.Location = new System.Drawing.Point(27, 109);
		this.E8BC6DA7.Name = "label2";
		this.E8BC6DA7.Size = new System.Drawing.Size(114, 16);
		this.E8BC6DA7.TabIndex = 32;
		this.E8BC6DA7.Text = "Số lần cuộn chuột:";
		this.CF3ECE88.AutoSize = true;
		this.CF3ECE88.Location = new System.Drawing.Point(27, 52);
		this.CF3ECE88.Name = "label1";
		this.CF3ECE88.Size = new System.Drawing.Size(98, 16);
		this.CF3ECE88.TabIndex = 31;
		this.CF3ECE88.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(187, 259);
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
		this.btnAdd.Location = new System.Drawing.Point(80, 259);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(A1113DB9);
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
		base.ClientSize = new System.Drawing.Size(362, 303);
		base.Controls.Add(this.C217D328);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVip";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanVip_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.C79A92A3).EndInit();
		this.C217D328.ResumeLayout(false);
		this.C217D328.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F812479E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
