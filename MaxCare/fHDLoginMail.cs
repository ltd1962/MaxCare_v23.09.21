using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDLoginMail : Form
{
	private JSON_Settings gclass8_0 = null;

	private string AE34F61E;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl AF9B1389;

	private BunifuDragControl bunifuDragControl_0;

	private Panel D73E9BAA;

	private TextBox BB0E7CB1;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards D70ED13E;

	private Panel BBA169B5;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDLoginMail(string C634B2AE, int BB95A392 = 0, string E1937A21 = "")
	{
		InitializeComponent();
		bool_0 = false;
		AE34F61E = C634B2AE;
		string_1 = E1937A21;
		int_0 = BB95A392;
		if (InteractSQL.B484648C("", "HDLoginMail").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDLoginMail', 'Login Hotmail');");
		}
		string text = "";
		switch (BB95A392)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDLoginMail");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BB0E7CB1.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E1937A21);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			BB0E7CB1.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void B7372CBE()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void B282F089(object sender, EventArgs e)
	{
		try
		{
		}
		catch
		{
		}
	}

	private void F4AF3994(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = BB0E7CB1.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(AE34F61E, text, string_0, string_))
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

	private void CD9AF38B(object sender, EventArgs e)
	{
		Close();
	}

	private void D385A889(object sender, PaintEventArgs e)
	{
		if (D73E9BAA.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D73E9BAA.ClientSize.Width - num, D73E9BAA.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B690449B)
	{
		if (B690449B && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B690449B);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDLoginMail));
		this.AF9B1389 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.BBA169B5 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.D73E9BAA = new System.Windows.Forms.Panel();
		this.BB0E7CB1 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.D70ED13E = new Bunifu.Framework.UI.BunifuCards();
		this.BBA169B5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.D73E9BAA.SuspendLayout();
		this.D70ED13E.SuspendLayout();
		base.SuspendLayout();
		this.AF9B1389.Fixed = true;
		this.AF9B1389.Horizontal = true;
		this.AF9B1389.TargetControl = this.bunifuCustomLabel1;
		this.AF9B1389.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Login Hotmail";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.BBA169B5;
		this.bunifuDragControl_0.Vertical = true;
		this.BBA169B5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.BBA169B5.BackColor = System.Drawing.Color.White;
		this.BBA169B5.Controls.Add(this.button1);
		this.BBA169B5.Controls.Add(this.pictureBox1);
		this.BBA169B5.Controls.Add(this.bunifuCustomLabel1);
		this.BBA169B5.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BBA169B5.Location = new System.Drawing.Point(0, 3);
		this.BBA169B5.Name = "pnlHeader";
		this.BBA169B5.Size = new System.Drawing.Size(359, 31);
		this.BBA169B5.TabIndex = 9;
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
		this.button1.Click += new System.EventHandler(F4AF3994);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.D73E9BAA.BackColor = System.Drawing.Color.White;
		this.D73E9BAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D73E9BAA.Controls.Add(this.BB0E7CB1);
		this.D73E9BAA.Controls.Add(this.label1);
		this.D73E9BAA.Controls.Add(this.btnCancel);
		this.D73E9BAA.Controls.Add(this.btnAdd);
		this.D73E9BAA.Controls.Add(this.D70ED13E);
		this.D73E9BAA.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.D73E9BAA.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D73E9BAA.Location = new System.Drawing.Point(0, 0);
		this.D73E9BAA.Name = "panel1";
		this.D73E9BAA.Size = new System.Drawing.Size(362, 160);
		this.D73E9BAA.TabIndex = 0;
		this.D73E9BAA.Paint += new System.Windows.Forms.PaintEventHandler(D385A889);
		this.BB0E7CB1.Location = new System.Drawing.Point(132, 49);
		this.BB0E7CB1.Name = "txtTenHanhDong";
		this.BB0E7CB1.Size = new System.Drawing.Size(194, 23);
		this.BB0E7CB1.TabIndex = 0;
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
		this.btnCancel.Click += new System.EventHandler(CD9AF38B);
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
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.D70ED13E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D70ED13E.BackColor = System.Drawing.Color.White;
		this.D70ED13E.BorderRadius = 0;
		this.D70ED13E.BottomSahddow = true;
		this.D70ED13E.color = System.Drawing.Color.DarkViolet;
		this.D70ED13E.Controls.Add(this.BBA169B5);
		this.D70ED13E.LeftSahddow = false;
		this.D70ED13E.Location = new System.Drawing.Point(1, 0);
		this.D70ED13E.Name = "bunifuCards1";
		this.D70ED13E.RightSahddow = true;
		this.D70ED13E.ShadowDepth = 20;
		this.D70ED13E.Size = new System.Drawing.Size(359, 37);
		this.D70ED13E.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 160);
		base.Controls.Add(this.D73E9BAA);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDLoginMail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B282F089);
		this.BBA169B5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.D73E9BAA.ResumeLayout(false);
		this.D73E9BAA.PerformLayout();
		this.D70ED13E.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
