using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBuffViewVideo : Form
{
	private JSON_Settings A68F200D;

	private string string_0;

	private string AD170C31;

	private string F5AC149A;

	private int DC1D238E;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel C6B85634;

	private NumericUpDown D19ED1BB;

	private NumericUpDown nudTimeFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards AC999C23;

	private Panel B8941727;

	private Button F9AC07B7;

	private PictureBox EDA6202F;

	private BunifuCustomLabel C7971B2F;

	private Label label2;

	private RichTextBox BB8C8213;

	public fHDBuffViewVideo(string string_1, int int_0 = 0, string string_2 = "")
	{
		EAB5EF1A();
		bool_0 = false;
		string_0 = string_1;
		F5AC149A = string_2;
		DC1D238E = int_0;
		if (InteractSQL.B484648C("", "HDBuffViewVideo").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffViewVideo', 'Buff View Video');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBuffViewVideo");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			AD170C31 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A68F200D = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDBuffViewVideo_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = A68F200D.GetValueInt("nudTimeFrom", 30);
			D19ED1BB.Value = A68F200D.GetValueInt("nudTimeTo", 30);
			BB8C8213.Text = A68F200D.GetValue("txtUid");
		}
		catch
		{
		}
	}

	private void F9AC07B7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B19A28AB(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = BB8C8213.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid ca\u0301 nhân!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudTimeFrom", nudTimeFrom.Value);
		gClass.GetJson("nudTimeTo", D19ED1BB.Value);
		gClass.GetJson("txtUid", BB8C8213.Text.Trim());
		string text2 = gClass.D9A09B34();
		if (DC1D238E == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, AD170C31, text2))
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
			if (InteractSQL.smethod_13(F5AC149A, text, text2))
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

	private void C6B85634_Paint(object sender, PaintEventArgs e)
	{
		if (C6B85634.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C6B85634.ClientSize.Width - num, C6B85634.ClientSize.Height - num));
		}
	}

	private void F3076593(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = BB8C8213.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label2.Text = string.Format(Language.GetValue("Nhập danh sách ID Video ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void AEB359A2(object sender, EventArgs e)
	{
		Common.F9202C12(BB8C8213, label2);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void EAB5EF1A()
	{
		icontainer_0 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		C7971B2F = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		B8941727 = new Panel();
		F9AC07B7 = new Button();
		EDA6202F = new PictureBox();
		C6B85634 = new Panel();
		label2 = new Label();
		D19ED1BB = new NumericUpDown();
		nudTimeFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		AC999C23 = new BunifuCards();
		BB8C8213 = new RichTextBox();
		B8941727.SuspendLayout();
		((ISupportInitialize)EDA6202F).BeginInit();
		C6B85634.SuspendLayout();
		((ISupportInitialize)D19ED1BB).BeginInit();
		((ISupportInitialize)nudTimeFrom).BeginInit();
		AC999C23.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C7971B2F;
		bunifuDragControl_0.Vertical = true;
		C7971B2F.BackColor = Color.Transparent;
		C7971B2F.Cursor = Cursors.SizeAll;
		C7971B2F.Dock = DockStyle.Fill;
		C7971B2F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C7971B2F.ForeColor = Color.Black;
		C7971B2F.Location = new Point(0, 0);
		C7971B2F.Name = "bunifuCustomLabel1";
		C7971B2F.Size = new Size(359, 31);
		C7971B2F.TabIndex = 12;
		C7971B2F.Text = "Cấu hình Buff View Video";
		C7971B2F.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = B8941727;
		bunifuDragControl_1.Vertical = true;
		B8941727.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B8941727.BackColor = Color.White;
		B8941727.Controls.Add(F9AC07B7);
		B8941727.Controls.Add(EDA6202F);
		B8941727.Controls.Add(C7971B2F);
		B8941727.Cursor = Cursors.SizeAll;
		B8941727.Location = new Point(0, 3);
		B8941727.Name = "pnlHeader";
		B8941727.Size = new Size(359, 31);
		B8941727.TabIndex = 9;
		F9AC07B7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		F9AC07B7.Cursor = Cursors.Hand;
		F9AC07B7.FlatAppearance.BorderSize = 0;
		F9AC07B7.FlatStyle = FlatStyle.Flat;
		F9AC07B7.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F9AC07B7.ForeColor = Color.White;
		F9AC07B7.Image = Resources.C400940B;
		F9AC07B7.Location = new Point(328, 1);
		F9AC07B7.Name = "button1";
		F9AC07B7.Size = new Size(30, 30);
		F9AC07B7.TabIndex = 77;
		F9AC07B7.TextImageRelation = TextImageRelation.ImageBeforeText;
		F9AC07B7.UseVisualStyleBackColor = true;
		F9AC07B7.Click += F9AC07B7_Click;
		EDA6202F.Cursor = Cursors.Default;
		EDA6202F.Image = Resources.Bitmap_4;
		EDA6202F.Location = new Point(3, 2);
		EDA6202F.Name = "pictureBox1";
		EDA6202F.Size = new Size(34, 27);
		EDA6202F.SizeMode = PictureBoxSizeMode.Zoom;
		EDA6202F.TabIndex = 76;
		EDA6202F.TabStop = false;
		C6B85634.BackColor = Color.White;
		C6B85634.BorderStyle = BorderStyle.FixedSingle;
		C6B85634.Controls.Add(BB8C8213);
		C6B85634.Controls.Add(label2);
		C6B85634.Controls.Add(D19ED1BB);
		C6B85634.Controls.Add(nudTimeFrom);
		C6B85634.Controls.Add(txtTenHanhDong);
		C6B85634.Controls.Add(label7);
		C6B85634.Controls.Add(label6);
		C6B85634.Controls.Add(label5);
		C6B85634.Controls.Add(label1);
		C6B85634.Controls.Add(btnCancel);
		C6B85634.Controls.Add(btnAdd);
		C6B85634.Controls.Add(AC999C23);
		C6B85634.Cursor = Cursors.Arrow;
		C6B85634.Dock = DockStyle.Fill;
		C6B85634.Location = new Point(0, 0);
		C6B85634.Name = "panel1";
		C6B85634.Size = new Size(362, 392);
		C6B85634.TabIndex = 0;
		C6B85634.Paint += C6B85634_Paint;
		label2.AutoSize = true;
		label2.Location = new Point(27, 105);
		label2.Name = "label2";
		label2.Size = new Size(203, 16);
		label2.TabIndex = 40;
		label2.Text = "Nhập danh sách ID/Link Video (0):";
		D19ED1BB.Location = new Point(231, 78);
		D19ED1BB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D19ED1BB.Name = "nudTimeTo";
		D19ED1BB.Size = new Size(56, 23);
		D19ED1BB.TabIndex = 4;
		nudTimeFrom.Location = new Point(134, 78);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new Size(56, 23);
		nudTimeFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new Point(196, 80);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(289, 80);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 80);
		label5.Name = "label5";
		label5.Size = new Size(93, 16);
		label5.TabIndex = 34;
		label5.Text = "Thời gian xem:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(188, 350);
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
		btnAdd.Location = new Point(81, 350);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += B19A28AB;
		AC999C23.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		AC999C23.BackColor = Color.White;
		AC999C23.BorderRadius = 0;
		AC999C23.BottomSahddow = true;
		AC999C23.color = Color.DarkViolet;
		AC999C23.Controls.Add(B8941727);
		AC999C23.LeftSahddow = false;
		AC999C23.Location = new Point(1, 0);
		AC999C23.Name = "bunifuCards1";
		AC999C23.RightSahddow = true;
		AC999C23.ShadowDepth = 20;
		AC999C23.Size = new Size(359, 37);
		AC999C23.TabIndex = 28;
		BB8C8213.Location = new Point(31, 125);
		BB8C8213.Name = "txtUid";
		BB8C8213.Size = new Size(297, 216);
		BB8C8213.TabIndex = 41;
		BB8C8213.Text = "";
		BB8C8213.WordWrap = false;
		BB8C8213.TextChanged += AEB359A2;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 392);
		base.Controls.Add(C6B85634);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBuffViewVideo";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDBuffViewVideo_Load;
		B8941727.ResumeLayout(performLayout: false);
		((ISupportInitialize)EDA6202F).EndInit();
		C6B85634.ResumeLayout(performLayout: false);
		C6B85634.PerformLayout();
		((ISupportInitialize)D19ED1BB).EndInit();
		((ISupportInitialize)nudTimeFrom).EndInit();
		AC999C23.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
