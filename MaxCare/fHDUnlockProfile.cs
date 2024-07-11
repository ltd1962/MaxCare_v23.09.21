using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDUnlockProfile : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool F130E896;

	private IContainer icontainer_0 = null;

	private BunifuDragControl E58F34A0;

	private BunifuDragControl A027331F;

	private Panel panel1;

	private TextBox DD10133F;

	private Label label1;

	private Button BB054DA8;

	private Button A8A79F13;

	private BunifuCards BC08C503;

	private Panel pnlHeader;

	private Button F48DFF21;

	private PictureBox DC3B4B2E;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDUnlockProfile(string string_3, int int_1 = 0, string string_4 = "")
	{
		DDAE5A97();
		F130E896 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Unlock profile";
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
			DD10133F.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			A8A79F13.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DD10133F.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
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
		Language.smethod_0(A8A79F13);
		Language.smethod_0(BB054DA8);
	}

	private void fHDUnlockProfile_Load(object sender, EventArgs e)
	{
	}

	private void F48DFF21_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A8A79F13_Click(object sender, EventArgs e)
	{
		string text = DD10133F.Text.Trim();
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
					F130E896 = true;
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
			if (InteractSQL.smethod_13(string_2, text, string_))
			{
				F130E896 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void FF1FA797(object sender, EventArgs e)
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

	private void DDAE5A97()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDUnlockProfile));
		E58F34A0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		A027331F = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		F48DFF21 = new Button();
		DC3B4B2E = new PictureBox();
		panel1 = new Panel();
		DD10133F = new TextBox();
		label1 = new Label();
		BB054DA8 = new Button();
		A8A79F13 = new Button();
		BC08C503 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)DC3B4B2E).BeginInit();
		panel1.SuspendLayout();
		BC08C503.SuspendLayout();
		SuspendLayout();
		E58F34A0.Fixed = true;
		E58F34A0.Horizontal = true;
		E58F34A0.TargetControl = bunifuCustomLabel1;
		E58F34A0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Unlock profile";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		A027331F.Fixed = true;
		A027331F.Horizontal = true;
		A027331F.TargetControl = pnlHeader;
		A027331F.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(F48DFF21);
		pnlHeader.Controls.Add(DC3B4B2E);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		F48DFF21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		F48DFF21.Cursor = Cursors.Hand;
		F48DFF21.FlatAppearance.BorderSize = 0;
		F48DFF21.FlatStyle = FlatStyle.Flat;
		F48DFF21.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F48DFF21.ForeColor = Color.White;
		F48DFF21.Image = (Image)componentResourceManager.GetObject("button1.Image");
		F48DFF21.Location = new Point(328, 1);
		F48DFF21.Name = "button1";
		F48DFF21.Size = new Size(30, 30);
		F48DFF21.TabIndex = 77;
		F48DFF21.TextImageRelation = TextImageRelation.ImageBeforeText;
		F48DFF21.UseVisualStyleBackColor = true;
		F48DFF21.Click += F48DFF21_Click;
		DC3B4B2E.Cursor = Cursors.Default;
		DC3B4B2E.Image = Resources.Bitmap_4;
		DC3B4B2E.Location = new Point(3, 2);
		DC3B4B2E.Name = "pictureBox1";
		DC3B4B2E.Size = new Size(34, 27);
		DC3B4B2E.SizeMode = PictureBoxSizeMode.Zoom;
		DC3B4B2E.TabIndex = 76;
		DC3B4B2E.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(DD10133F);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(BB054DA8);
		panel1.Controls.Add(A8A79F13);
		panel1.Controls.Add(BC08C503);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 132);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		DD10133F.Location = new Point(132, 49);
		DD10133F.Name = "txtTenHanhDong";
		DD10133F.Size = new Size(194, 23);
		DD10133F.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		BB054DA8.Anchor = AnchorStyles.Bottom;
		BB054DA8.BackColor = Color.Maroon;
		BB054DA8.Cursor = Cursors.Hand;
		BB054DA8.FlatAppearance.BorderSize = 0;
		BB054DA8.FlatStyle = FlatStyle.Flat;
		BB054DA8.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BB054DA8.ForeColor = Color.White;
		BB054DA8.Location = new Point(189, 88);
		BB054DA8.Name = "btnCancel";
		BB054DA8.Size = new Size(92, 29);
		BB054DA8.TabIndex = 10;
		BB054DA8.Text = "Đóng";
		BB054DA8.UseVisualStyleBackColor = false;
		BB054DA8.Click += FF1FA797;
		A8A79F13.Anchor = AnchorStyles.Bottom;
		A8A79F13.BackColor = Color.FromArgb(53, 120, 229);
		A8A79F13.Cursor = Cursors.Hand;
		A8A79F13.FlatAppearance.BorderSize = 0;
		A8A79F13.FlatStyle = FlatStyle.Flat;
		A8A79F13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A8A79F13.ForeColor = Color.White;
		A8A79F13.Location = new Point(82, 88);
		A8A79F13.Name = "btnAdd";
		A8A79F13.Size = new Size(92, 29);
		A8A79F13.TabIndex = 9;
		A8A79F13.Text = "Thêm";
		A8A79F13.UseVisualStyleBackColor = false;
		A8A79F13.Click += A8A79F13_Click;
		BC08C503.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		BC08C503.BackColor = Color.White;
		BC08C503.BorderRadius = 0;
		BC08C503.BottomSahddow = true;
		BC08C503.color = Color.DarkViolet;
		BC08C503.Controls.Add(pnlHeader);
		BC08C503.LeftSahddow = false;
		BC08C503.Location = new Point(1, 0);
		BC08C503.Name = "bunifuCards1";
		BC08C503.RightSahddow = true;
		BC08C503.ShadowDepth = 20;
		BC08C503.Size = new Size(359, 37);
		BC08C503.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 132);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDUnlockProfile";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDUnlockProfile_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)DC3B4B2E).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		BC08C503.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
