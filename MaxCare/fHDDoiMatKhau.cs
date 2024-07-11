using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDDoiMatKhau : Form
{
	private JSON_Settings BA81390A;

	private string string_0;

	private string D3341A1C;

	private string BB0AEFA7;

	private int B01C0DBE;

	public static bool CC18D121;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel BC868F35;

	private TextBox A2A6481E;

	private Label D42AF40B;

	private Button C705CF17;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ToolTip toolTip_0;

	private Label label2;

	private TextBox B1158294;

	private Button F3A9C1A7;

	private ComboBox cbbTypeDoiMatKhau;

	private Label B3A9D0AD;

	public fHDDoiMatKhau(string string_1, int E8B5D415 = 0, string C7B4D53A = "")
	{
		E388A4B4();
		CC18D121 = false;
		string_0 = string_1;
		BB0AEFA7 = C7B4D53A;
		B01C0DBE = E8B5D415;
		string text = base.Name.Substring(1);
		string text2 = "Đổi mật khẩu";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (E8B5D415)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			D3341A1C = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A2A6481E.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(C7B4D53A);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A2A6481E.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		BA81390A = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDDoiMatKhau_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			cbbTypeDoiMatKhau.SelectedIndex = BA81390A.GetValueInt("cbbTypeDoiMatKhau");
			B1158294.Text = BA81390A.GetValue("txtNewPass");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Sử dụng m.fb", "Sử dụng link hacked" };
		Common.F714B10E(cbbTypeDoiMatKhau, e6A5AC);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = A2A6481E.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("txtNewPass", B1158294.Text.Trim());
		gClass.GetJson("cbbTypeDoiMatKhau", cbbTypeDoiMatKhau.SelectedIndex);
		string text2 = gClass.D9A09B34();
		if (B01C0DBE == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, D3341A1C, text2))
				{
					CC18D121 = true;
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
			if (InteractSQL.smethod_13(BB0AEFA7, text, text2))
			{
				CC18D121 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void C705CF17_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BC868F35_Paint(object sender, PaintEventArgs e)
	{
		if (BC868F35.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BC868F35.ClientSize.Width - num, BC868F35.ClientSize.Height - num));
		}
	}

	private void ADAE4494(object sender, EventArgs e)
	{
	}

	private void F3A9C1A7_Click(object sender, EventArgs e)
	{
		string object_ = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		MessageBoxHelper.Show(object_);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void E388A4B4()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDoiMatKhau));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		BC868F35 = new Panel();
		cbbTypeDoiMatKhau = new ComboBox();
		F3A9C1A7 = new Button();
		B3A9D0AD = new Label();
		label2 = new Label();
		B1158294 = new TextBox();
		A2A6481E = new TextBox();
		D42AF40B = new Label();
		C705CF17 = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		toolTip_0 = new ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		BC868F35.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(345, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đổi mật khẩu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(345, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(314, 1);
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
		BC868F35.BackColor = Color.White;
		BC868F35.BorderStyle = BorderStyle.FixedSingle;
		BC868F35.Controls.Add(cbbTypeDoiMatKhau);
		BC868F35.Controls.Add(F3A9C1A7);
		BC868F35.Controls.Add(B3A9D0AD);
		BC868F35.Controls.Add(label2);
		BC868F35.Controls.Add(B1158294);
		BC868F35.Controls.Add(A2A6481E);
		BC868F35.Controls.Add(D42AF40B);
		BC868F35.Controls.Add(C705CF17);
		BC868F35.Controls.Add(btnAdd);
		BC868F35.Controls.Add(bunifuCards1);
		BC868F35.Cursor = Cursors.Arrow;
		BC868F35.Dock = DockStyle.Fill;
		BC868F35.Location = new Point(0, 0);
		BC868F35.Name = "panel1";
		BC868F35.Size = new Size(348, 191);
		BC868F35.TabIndex = 0;
		BC868F35.Paint += BC868F35_Paint;
		cbbTypeDoiMatKhau.Cursor = Cursors.Hand;
		cbbTypeDoiMatKhau.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeDoiMatKhau.FormattingEnabled = true;
		cbbTypeDoiMatKhau.Location = new Point(125, 78);
		cbbTypeDoiMatKhau.Name = "cbbTypeDoiMatKhau";
		cbbTypeDoiMatKhau.Size = new Size(194, 24);
		cbbTypeDoiMatKhau.TabIndex = 153;
		F3A9C1A7.Cursor = Cursors.Hand;
		F3A9C1A7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F3A9C1A7.Location = new Point(295, 107);
		F3A9C1A7.Name = "button2";
		F3A9C1A7.Size = new Size(24, 24);
		F3A9C1A7.TabIndex = 152;
		F3A9C1A7.Text = "?";
		F3A9C1A7.UseVisualStyleBackColor = true;
		F3A9C1A7.Click += F3A9C1A7_Click;
		B3A9D0AD.AutoSize = true;
		B3A9D0AD.Location = new Point(20, 81);
		B3A9D0AD.Name = "label3";
		B3A9D0AD.Size = new Size(64, 16);
		B3A9D0AD.TabIndex = 31;
		B3A9D0AD.Text = "Tùy chọn:";
		label2.AutoSize = true;
		label2.Location = new Point(20, 111);
		label2.Name = "label2";
		label2.Size = new Size(89, 16);
		label2.TabIndex = 31;
		label2.Text = "Mật khẩu mới:";
		B1158294.Location = new Point(125, 108);
		B1158294.Name = "txtNewPass";
		B1158294.Size = new Size(167, 23);
		B1158294.TabIndex = 0;
		A2A6481E.Location = new Point(125, 49);
		A2A6481E.Name = "txtTenHanhDong";
		A2A6481E.Size = new Size(194, 23);
		A2A6481E.TabIndex = 0;
		D42AF40B.AutoSize = true;
		D42AF40B.Location = new Point(20, 52);
		D42AF40B.Name = "label1";
		D42AF40B.Size = new Size(98, 16);
		D42AF40B.TabIndex = 31;
		D42AF40B.Text = "Tên ha\u0300nh đô\u0323ng:";
		C705CF17.Anchor = AnchorStyles.Bottom;
		C705CF17.BackColor = Color.Maroon;
		C705CF17.Cursor = Cursors.Hand;
		C705CF17.FlatAppearance.BorderSize = 0;
		C705CF17.FlatStyle = FlatStyle.Flat;
		C705CF17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C705CF17.ForeColor = Color.White;
		C705CF17.Location = new Point(184, 148);
		C705CF17.Name = "btnCancel";
		C705CF17.Size = new Size(92, 29);
		C705CF17.TabIndex = 7;
		C705CF17.Text = "Đóng";
		C705CF17.UseVisualStyleBackColor = false;
		C705CF17.Click += C705CF17_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(77, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(345, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(348, 191);
		base.Controls.Add(BC868F35);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDoiMatKhau";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDoiMatKhau_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		BC868F35.ResumeLayout(performLayout: false);
		BC868F35.PerformLayout();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
