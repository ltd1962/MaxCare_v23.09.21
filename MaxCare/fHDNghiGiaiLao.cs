using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Bunifu.Framework.UI;

public class fHDNghiGiaiLao : Form
{
	private JSON_Settings gclass8_0 = null;

	private string E9B06594;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl AD087386;

	private BunifuDragControl F8844E93;

	private Panel panel1;

	private NumericUpDown F80BB719;

	private NumericUpDown EB27DE32;

	private TextBox AB375E8D;

	private Label label7;

	private Label A81F7591;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel B7910FB5;

	public fHDNghiGiaiLao(string E2A6B1BE, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E9B06594 = E2A6B1BE;
		string_1 = string_2;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDNghiGiaiLao").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDNghiGiaiLao', 'Nghỉ giải lao');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDNghiGiaiLao");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			AB375E8D.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			AB375E8D.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(B7910FB5);
		Language.smethod_0(label1);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(A81F7591);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void fHDNghiGiaiLao_Load(object sender, EventArgs e)
	{
		try
		{
			EB27DE32.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			F80BB719.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EB93010A(object sender, EventArgs e)
	{
		string text = AB375E8D.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudDelayFrom", EB27DE32.Value);
		gClass.GetJson("nudDelayTo", F80BB719.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E9B06594, text, string_0, string_))
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

	protected override void Dispose(bool BFB89506)
	{
		if (BFB89506 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(BFB89506);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDNghiGiaiLao));
		this.AD087386 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.B7910FB5 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F8844E93 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.F80BB719 = new System.Windows.Forms.NumericUpDown();
		this.EB27DE32 = new System.Windows.Forms.NumericUpDown();
		this.AB375E8D = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.A81F7591 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.F80BB719).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EB27DE32).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.AD087386.Fixed = true;
		this.AD087386.Horizontal = true;
		this.AD087386.TargetControl = this.B7910FB5;
		this.AD087386.Vertical = true;
		this.B7910FB5.BackColor = System.Drawing.Color.Transparent;
		this.B7910FB5.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B7910FB5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.B7910FB5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B7910FB5.ForeColor = System.Drawing.Color.Black;
		this.B7910FB5.Location = new System.Drawing.Point(0, 0);
		this.B7910FB5.Name = "bunifuCustomLabel1";
		this.B7910FB5.Size = new System.Drawing.Size(359, 31);
		this.B7910FB5.TabIndex = 12;
		this.B7910FB5.Text = "Cấu hình Nghỉ giải lao";
		this.B7910FB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F8844E93.Fixed = true;
		this.F8844E93.Horizontal = true;
		this.F8844E93.TargetControl = this.pnlHeader;
		this.F8844E93.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.B7910FB5);
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
		this.panel1.Controls.Add(this.F80BB719);
		this.panel1.Controls.Add(this.EB27DE32);
		this.panel1.Controls.Add(this.AB375E8D);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.A81F7591);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 160);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.F80BB719.Location = new System.Drawing.Point(229, 80);
		this.F80BB719.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F80BB719.Name = "nudDelayTo";
		this.F80BB719.Size = new System.Drawing.Size(56, 23);
		this.F80BB719.TabIndex = 4;
		this.EB27DE32.Location = new System.Drawing.Point(132, 80);
		this.EB27DE32.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.EB27DE32.Name = "nudDelayFrom";
		this.EB27DE32.Size = new System.Drawing.Size(56, 23);
		this.EB27DE32.TabIndex = 3;
		this.AB375E8D.Location = new System.Drawing.Point(132, 49);
		this.AB375E8D.Name = "txtTenHanhDong";
		this.AB375E8D.Size = new System.Drawing.Size(194, 23);
		this.AB375E8D.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(194, 82);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A81F7591.AutoSize = true;
		this.A81F7591.Location = new System.Drawing.Point(287, 82);
		this.A81F7591.Name = "label6";
		this.A81F7591.Size = new System.Drawing.Size(30, 16);
		this.A81F7591.TabIndex = 36;
		this.A81F7591.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 82);
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
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 116);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 116);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(EB93010A);
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
		base.ClientSize = new System.Drawing.Size(362, 160);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDNghiGiaiLao";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDNghiGiaiLao_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.F80BB719).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EB27DE32).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
