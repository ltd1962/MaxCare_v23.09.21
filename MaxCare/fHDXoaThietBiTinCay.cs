using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Bunifu.Framework.UI;

public class fHDXoaThietBiTinCay : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string string_1;

	private string C2BD92BF;

	private int int_0;

	public static bool B7A3BCAE;

	private IContainer icontainer_0 = null;

	private BunifuDragControl DC1C0E17;

	private BunifuDragControl DF2766B6;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label BA9A2D91;

	private Button C8B85236;

	private Button btnAdd;

	private BunifuCards B0037B87;

	private Panel E3AA85A6;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDXoaThietBiTinCay(string string_2, int int_1 = 0, string string_3 = "")
	{
		ED201CA5();
		B7A3BCAE = false;
		string_0 = string_2;
		C2BD92BF = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Xóa thiết bị tin cậy";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
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
		Language.smethod_0(BA9A2D91);
		Language.smethod_0(btnAdd);
		Language.smethod_0(C8B85236);
	}

	private void fHDXoaThietBiTinCay_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
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
		string string_ = gclass8_0.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					B7A3BCAE = true;
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
			if (InteractSQL.smethod_13(C2BD92BF, text, string_))
			{
				B7A3BCAE = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void FE341D19(object sender, EventArgs e)
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

	protected override void Dispose(bool FBA412A6)
	{
		if (FBA412A6 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FBA412A6);
	}

	private void ED201CA5()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXoaThietBiTinCay));
		DC1C0E17 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		DF2766B6 = new BunifuDragControl(icontainer_0);
		E3AA85A6 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		txtTenHanhDong = new TextBox();
		BA9A2D91 = new Label();
		C8B85236 = new Button();
		btnAdd = new Button();
		B0037B87 = new BunifuCards();
		E3AA85A6.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		B0037B87.SuspendLayout();
		SuspendLayout();
		DC1C0E17.Fixed = true;
		DC1C0E17.Horizontal = true;
		DC1C0E17.TargetControl = bunifuCustomLabel1;
		DC1C0E17.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xóa thiết bị tin cậy";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		DF2766B6.Fixed = true;
		DF2766B6.Horizontal = true;
		DF2766B6.TargetControl = E3AA85A6;
		DF2766B6.Vertical = true;
		E3AA85A6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E3AA85A6.BackColor = Color.White;
		E3AA85A6.Controls.Add(button1);
		E3AA85A6.Controls.Add(pictureBox1);
		E3AA85A6.Controls.Add(bunifuCustomLabel1);
		E3AA85A6.Cursor = Cursors.SizeAll;
		E3AA85A6.Location = new Point(0, 3);
		E3AA85A6.Name = "pnlHeader";
		E3AA85A6.Size = new Size(359, 31);
		E3AA85A6.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(BA9A2D91);
		panel1.Controls.Add(C8B85236);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B0037B87);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 135);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		BA9A2D91.AutoSize = true;
		BA9A2D91.Location = new Point(27, 52);
		BA9A2D91.Name = "label1";
		BA9A2D91.Size = new Size(98, 16);
		BA9A2D91.TabIndex = 31;
		BA9A2D91.Text = "Tên ha\u0300nh đô\u0323ng:";
		C8B85236.Anchor = AnchorStyles.Bottom;
		C8B85236.BackColor = Color.Maroon;
		C8B85236.Cursor = Cursors.Hand;
		C8B85236.FlatAppearance.BorderSize = 0;
		C8B85236.FlatStyle = FlatStyle.Flat;
		C8B85236.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C8B85236.ForeColor = Color.White;
		C8B85236.Location = new Point(189, 91);
		C8B85236.Name = "btnCancel";
		C8B85236.Size = new Size(92, 29);
		C8B85236.TabIndex = 10;
		C8B85236.Text = "Đóng";
		C8B85236.UseVisualStyleBackColor = false;
		C8B85236.Click += FE341D19;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 91);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		B0037B87.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B0037B87.BackColor = Color.White;
		B0037B87.BorderRadius = 0;
		B0037B87.BottomSahddow = true;
		B0037B87.color = Color.DarkViolet;
		B0037B87.Controls.Add(E3AA85A6);
		B0037B87.LeftSahddow = false;
		B0037B87.Location = new Point(1, 0);
		B0037B87.Name = "bunifuCards1";
		B0037B87.RightSahddow = true;
		B0037B87.ShadowDepth = 20;
		B0037B87.Size = new Size(359, 37);
		B0037B87.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 135);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXoaThietBiTinCay";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDXoaThietBiTinCay_Load;
		E3AA85A6.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		B0037B87.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
