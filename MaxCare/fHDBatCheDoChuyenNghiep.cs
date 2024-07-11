using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBatCheDoChuyenNghiep : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string string_1;

	private string B99C5A05;

	private int AF9C27BD;

	public static bool bool_0;

	private IContainer E186CA8F = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label EC8623B4;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards E3157403;

	private Panel DD0A7488;

	private Button button1;

	private PictureBox EFB5CA8C;

	private BunifuCustomLabel AA945292;

	private ComboBox cbbTuyChon;

	private Label label2;

	public fHDBatCheDoChuyenNghiep(string string_2, int int_0 = 0, string C0B93033 = "")
	{
		B82A9696();
		bool_0 = false;
		string_0 = string_2;
		B99C5A05 = C0B93033;
		AF9C27BD = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Bật chế độ chuyên nghiệp";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(C0B93033);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDBatCheDoChuyenNghiep_Load(object sender, EventArgs e)
	{
		List<string> e6A5AC = new List<string> { "Bật", "Tắt" };
		Common.F714B10E(cbbTuyChon, e6A5AC);
		cbbTuyChon.SelectedIndex = gclass8_0.GetValueInt("cbbTuyChon");
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
		gclass8_0.GetJson("cbbTuyChon", cbbTuyChon.SelectedIndex);
		string string_ = gclass8_0.D9A09B34();
		if (AF9C27BD == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
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
			if (InteractSQL.smethod_13(B99C5A05, text, string_))
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

	protected override void Dispose(bool BF0D732A)
	{
		if (BF0D732A && E186CA8F != null)
		{
			E186CA8F.Dispose();
		}
		base.Dispose(BF0D732A);
	}

	private void B82A9696()
	{
		E186CA8F = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBatCheDoChuyenNghiep));
		bunifuDragControl_0 = new BunifuDragControl(E186CA8F);
		AA945292 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(E186CA8F);
		DD0A7488 = new Panel();
		button1 = new Button();
		EFB5CA8C = new PictureBox();
		panel1 = new Panel();
		cbbTuyChon = new ComboBox();
		label2 = new Label();
		txtTenHanhDong = new TextBox();
		EC8623B4 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		E3157403 = new BunifuCards();
		DD0A7488.SuspendLayout();
		((ISupportInitialize)EFB5CA8C).BeginInit();
		panel1.SuspendLayout();
		E3157403.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AA945292;
		bunifuDragControl_0.Vertical = true;
		AA945292.BackColor = Color.Transparent;
		AA945292.Cursor = Cursors.SizeAll;
		AA945292.Dock = DockStyle.Fill;
		AA945292.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AA945292.ForeColor = Color.Black;
		AA945292.Location = new Point(0, 0);
		AA945292.Name = "bunifuCustomLabel1";
		AA945292.Size = new Size(359, 31);
		AA945292.TabIndex = 12;
		AA945292.Text = "Cấu hình Bật chế độ chuyên nghiệp";
		AA945292.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = DD0A7488;
		bunifuDragControl_1.Vertical = true;
		DD0A7488.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		DD0A7488.BackColor = Color.White;
		DD0A7488.Controls.Add(button1);
		DD0A7488.Controls.Add(EFB5CA8C);
		DD0A7488.Controls.Add(AA945292);
		DD0A7488.Cursor = Cursors.SizeAll;
		DD0A7488.Location = new Point(0, 3);
		DD0A7488.Name = "pnlHeader";
		DD0A7488.Size = new Size(359, 31);
		DD0A7488.TabIndex = 9;
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
		EFB5CA8C.Cursor = Cursors.Default;
		EFB5CA8C.Image = Resources.Bitmap_4;
		EFB5CA8C.Location = new Point(3, 2);
		EFB5CA8C.Name = "pictureBox1";
		EFB5CA8C.Size = new Size(34, 27);
		EFB5CA8C.SizeMode = PictureBoxSizeMode.Zoom;
		EFB5CA8C.TabIndex = 76;
		EFB5CA8C.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(cbbTuyChon);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(EC8623B4);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(E3157403);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 164);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		cbbTuyChon.Cursor = Cursors.Hand;
		cbbTuyChon.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTuyChon.FormattingEnabled = true;
		cbbTuyChon.Location = new Point(132, 78);
		cbbTuyChon.Name = "cbbTuyChon";
		cbbTuyChon.Size = new Size(194, 24);
		cbbTuyChon.TabIndex = 33;
		label2.AutoSize = true;
		label2.Location = new Point(30, 81);
		label2.Name = "label2";
		label2.Size = new Size(64, 16);
		label2.TabIndex = 32;
		label2.Text = "Tùy chọn:";
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		EC8623B4.AutoSize = true;
		EC8623B4.Location = new Point(27, 52);
		EC8623B4.Name = "label1";
		EC8623B4.Size = new Size(98, 16);
		EC8623B4.TabIndex = 31;
		EC8623B4.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(189, 120);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 120);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		E3157403.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E3157403.BackColor = Color.White;
		E3157403.BorderRadius = 0;
		E3157403.BottomSahddow = true;
		E3157403.color = Color.DarkViolet;
		E3157403.Controls.Add(DD0A7488);
		E3157403.LeftSahddow = false;
		E3157403.Location = new Point(1, 0);
		E3157403.Name = "bunifuCards1";
		E3157403.RightSahddow = true;
		E3157403.ShadowDepth = 20;
		E3157403.Size = new Size(359, 37);
		E3157403.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 164);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBatCheDoChuyenNghiep";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDBatCheDoChuyenNghiep_Load;
		DD0A7488.ResumeLayout(performLayout: false);
		((ISupportInitialize)EFB5CA8C).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		E3157403.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
