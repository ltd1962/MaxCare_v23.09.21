using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXoaSdt : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string DB2A6FAF;

	private string string_1;

	private int A99F7291;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl B3BF1D0D;

	private BunifuDragControl C49AD207;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button BEB3532E;

	private Button btnAdd;

	private BunifuCards FA11EDBA;

	private Panel C616C629;

	private Button DD9BF308;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ComboBox cbbFacebookWeb;

	private Label label10;

	public fHDXoaSdt(string string_2, int int_0 = 0, string BF17491D = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = BF17491D;
		A99F7291 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Xóa Sđt";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			DB2A6FAF = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BF17491D);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void EF2B3B0A(object sender, EventArgs e)
	{
		try
		{
			method_0();
			cbbFacebookWeb.SelectedValue = gclass8_0.GetValue("cbbFacebookWeb", "1");
		}
		catch (Exception)
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("1", "Sử dụng m.fb");
		dictionary.Add("4", "Sử dụng mbasic");
		dictionary.Add("0", "Sử dụng www");
		dictionary.Add("2", "Sử dụng tut không pass");
		dictionary.Add("3", "Sử dụng Accounts Center");
		Common.F5A0B829(cbbFacebookWeb, dictionary);
	}

	private void C91CC995(object sender, EventArgs e)
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
		gclass8_0.GetJson("cbbFacebookWeb", cbbFacebookWeb.SelectedValue);
		string string_ = gclass8_0.D9A09B34();
		if (A99F7291 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, DB2A6FAF, string_))
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

	private void BEB3532E_Click(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXoaSdt));
		this.B3BF1D0D = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.C49AD207 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.C616C629 = new System.Windows.Forms.Panel();
		this.DD9BF308 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		this.label10 = new System.Windows.Forms.Label();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.BEB3532E = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.FA11EDBA = new Bunifu.Framework.UI.BunifuCards();
		this.C616C629.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.FA11EDBA.SuspendLayout();
		base.SuspendLayout();
		this.B3BF1D0D.Fixed = true;
		this.B3BF1D0D.Horizontal = true;
		this.B3BF1D0D.TargetControl = this.bunifuCustomLabel1;
		this.B3BF1D0D.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Xóa Sđt";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C49AD207.Fixed = true;
		this.C49AD207.Horizontal = true;
		this.C49AD207.TargetControl = this.C616C629;
		this.C49AD207.Vertical = true;
		this.C616C629.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C616C629.BackColor = System.Drawing.Color.White;
		this.C616C629.Controls.Add(this.DD9BF308);
		this.C616C629.Controls.Add(this.pictureBox1);
		this.C616C629.Controls.Add(this.bunifuCustomLabel1);
		this.C616C629.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.C616C629.Location = new System.Drawing.Point(0, 3);
		this.C616C629.Name = "pnlHeader";
		this.C616C629.Size = new System.Drawing.Size(359, 31);
		this.C616C629.TabIndex = 9;
		this.DD9BF308.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DD9BF308.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD9BF308.FlatAppearance.BorderSize = 0;
		this.DD9BF308.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DD9BF308.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DD9BF308.ForeColor = System.Drawing.Color.White;
		this.DD9BF308.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.DD9BF308.Location = new System.Drawing.Point(328, 1);
		this.DD9BF308.Name = "button1";
		this.DD9BF308.Size = new System.Drawing.Size(30, 30);
		this.DD9BF308.TabIndex = 77;
		this.DD9BF308.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.DD9BF308.UseVisualStyleBackColor = true;
		this.DD9BF308.Click += new System.EventHandler(C91CC995);
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
		this.panel1.Controls.Add(this.cbbFacebookWeb);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.BEB3532E);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.FA11EDBA);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 165);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbFacebookWeb.DropDownWidth = 200;
		this.cbbFacebookWeb.FormattingEnabled = true;
		this.cbbFacebookWeb.Location = new System.Drawing.Point(132, 78);
		this.cbbFacebookWeb.Name = "cbbFacebookWeb";
		this.cbbFacebookWeb.Size = new System.Drawing.Size(194, 24);
		this.cbbFacebookWeb.TabIndex = 193;
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(27, 81);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(64, 16);
		this.label10.TabIndex = 192;
		this.label10.Text = "Tùy chọn:";
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.BEB3532E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.BEB3532E.BackColor = System.Drawing.Color.Maroon;
		this.BEB3532E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BEB3532E.FlatAppearance.BorderSize = 0;
		this.BEB3532E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BEB3532E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BEB3532E.ForeColor = System.Drawing.Color.White;
		this.BEB3532E.Location = new System.Drawing.Point(189, 121);
		this.BEB3532E.Name = "btnCancel";
		this.BEB3532E.Size = new System.Drawing.Size(92, 29);
		this.BEB3532E.TabIndex = 10;
		this.BEB3532E.Text = "Đóng";
		this.BEB3532E.UseVisualStyleBackColor = false;
		this.BEB3532E.Click += new System.EventHandler(BEB3532E_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 121);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.FA11EDBA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.FA11EDBA.BackColor = System.Drawing.Color.White;
		this.FA11EDBA.BorderRadius = 0;
		this.FA11EDBA.BottomSahddow = true;
		this.FA11EDBA.color = System.Drawing.Color.DarkViolet;
		this.FA11EDBA.Controls.Add(this.C616C629);
		this.FA11EDBA.LeftSahddow = false;
		this.FA11EDBA.Location = new System.Drawing.Point(1, 0);
		this.FA11EDBA.Name = "bunifuCards1";
		this.FA11EDBA.RightSahddow = true;
		this.FA11EDBA.ShadowDepth = 20;
		this.FA11EDBA.Size = new System.Drawing.Size(359, 37);
		this.FA11EDBA.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 165);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaSdt";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(EF2B3B0A);
		this.C616C629.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.FA11EDBA.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
