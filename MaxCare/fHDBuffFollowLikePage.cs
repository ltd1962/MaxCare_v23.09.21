using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBuffFollowLikePage : Form
{
	private JSON_Settings gclass8_0;

	private string CC369A8D;

	private string string_0;

	private string string_1;

	private int B28CFBA9;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel A9B14B3B;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox B611D19A;

	private Label label7;

	private Label D3006730;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel B40C418D;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label E83AA130;

	private CheckBox ckbTuDongXoaUid;

	private NumericUpDown D4B53737;

	private NumericUpDown nudSoLuongFrom;

	private Label label3;

	private Label label4;

	private Label label8;

	private RichTextBox txtUid;

	private Label CCAA129F;

	private CheckBox F687DA81;

	private CheckBox ckbLike;

	public fHDBuffFollowLikePage(string string_2, int int_0 = 0, string E2825C28 = "")
	{
		CD0E66BE();
		bool_0 = false;
		CC369A8D = string_2;
		string_1 = E2825C28;
		B28CFBA9 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Buff Like, Follow page";
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
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B611D19A.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E2825C28);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B611D19A.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDBuffFollowLikePage_Load(object sender, EventArgs e)
	{
		try
		{
			ckbLike.Checked = gclass8_0.GetValueBool("ckbLike");
			F687DA81.Checked = gclass8_0.GetValueBool("ckbFollow");
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			D4B53737.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			txtUid.Text = gclass8_0.GetValue("txtUid");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = B611D19A.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid page!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", D4B53737.Value);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("ckbLike", ckbLike.Checked);
		gClass.GetJson("ckbFollow", F687DA81.Checked);
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		string string_ = gClass.D9A09B34();
		if (B28CFBA9 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(CC369A8D, text, string_0, string_))
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

	private void B1BEC488(object sender, EventArgs e)
	{
		Close();
	}

	private void A9B14B3B_Paint(object sender, PaintEventArgs e)
	{
		if (A9B14B3B.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A9B14B3B.ClientSize.Width - num, A9B14B3B.ClientSize.Height - num));
		}
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtUid, E83AA130);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void CD0E66BE()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBuffFollowLikePage));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		B40C418D = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		A9B14B3B = new Panel();
		txtUid = new RichTextBox();
		ckbTuDongXoaUid = new CheckBox();
		D4B53737 = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		label3 = new Label();
		label4 = new Label();
		CCAA129F = new Label();
		label8 = new Label();
		F687DA81 = new CheckBox();
		ckbLike = new CheckBox();
		E83AA130 = new Label();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		B611D19A = new TextBox();
		label7 = new Label();
		D3006730 = new Label();
		label5 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		B40C418D.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		A9B14B3B.SuspendLayout();
		((ISupportInitialize)D4B53737).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(377, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Buff Like, Follow page";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = B40C418D;
		bunifuDragControl_1.Vertical = true;
		B40C418D.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B40C418D.BackColor = Color.White;
		B40C418D.Controls.Add(button1);
		B40C418D.Controls.Add(pictureBox1);
		B40C418D.Controls.Add(bunifuCustomLabel1);
		B40C418D.Cursor = Cursors.SizeAll;
		B40C418D.Location = new Point(0, 3);
		B40C418D.Name = "pnlHeader";
		B40C418D.Size = new Size(377, 31);
		B40C418D.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(346, 1);
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
		A9B14B3B.BackColor = Color.White;
		A9B14B3B.BorderStyle = BorderStyle.FixedSingle;
		A9B14B3B.Controls.Add(txtUid);
		A9B14B3B.Controls.Add(ckbTuDongXoaUid);
		A9B14B3B.Controls.Add(D4B53737);
		A9B14B3B.Controls.Add(nudSoLuongFrom);
		A9B14B3B.Controls.Add(label3);
		A9B14B3B.Controls.Add(label4);
		A9B14B3B.Controls.Add(CCAA129F);
		A9B14B3B.Controls.Add(label8);
		A9B14B3B.Controls.Add(F687DA81);
		A9B14B3B.Controls.Add(ckbLike);
		A9B14B3B.Controls.Add(E83AA130);
		A9B14B3B.Controls.Add(nudDelayTo);
		A9B14B3B.Controls.Add(nudDelayFrom);
		A9B14B3B.Controls.Add(B611D19A);
		A9B14B3B.Controls.Add(label7);
		A9B14B3B.Controls.Add(D3006730);
		A9B14B3B.Controls.Add(label5);
		A9B14B3B.Controls.Add(label1);
		A9B14B3B.Controls.Add(btnCancel);
		A9B14B3B.Controls.Add(btnAdd);
		A9B14B3B.Controls.Add(bunifuCards1);
		A9B14B3B.Cursor = Cursors.Arrow;
		A9B14B3B.Dock = DockStyle.Fill;
		A9B14B3B.Location = new Point(0, 0);
		A9B14B3B.Name = "panel1";
		A9B14B3B.Size = new Size(380, 405);
		A9B14B3B.TabIndex = 0;
		A9B14B3B.Paint += A9B14B3B_Paint;
		txtUid.Location = new Point(31, 179);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(318, 146);
		txtUid.TabIndex = 50;
		txtUid.Text = "";
		txtUid.TextChanged += txtUid_TextChanged;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = Cursors.Hand;
		ckbTuDongXoaUid.Location = new Point(30, 329);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new Size(303, 20);
		ckbTuDongXoaUid.TabIndex = 49;
		ckbTuDongXoaUid.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		D4B53737.Location = new Point(256, 107);
		D4B53737.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D4B53737.Name = "nudSoLuongTo";
		D4B53737.Size = new Size(56, 23);
		D4B53737.TabIndex = 45;
		nudSoLuongFrom.Location = new Point(159, 107);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 44;
		label3.Location = new Point(221, 109);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 48;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new Point(314, 109);
		label4.Name = "label4";
		label4.Size = new Size(35, 16);
		label4.TabIndex = 47;
		label4.Text = "Page";
		CCAA129F.AutoSize = true;
		CCAA129F.Location = new Point(27, 137);
		CCAA129F.Name = "label9";
		CCAA129F.Size = new Size(64, 16);
		CCAA129F.TabIndex = 46;
		CCAA129F.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new Point(27, 109);
		label8.Name = "label8";
		label8.Size = new Size(118, 16);
		label8.TabIndex = 46;
		label8.Text = "Số lượng Page/Uid:";
		F687DA81.AutoSize = true;
		F687DA81.Cursor = Cursors.Hand;
		F687DA81.Location = new Point(256, 136);
		F687DA81.Name = "ckbFollow";
		F687DA81.Size = new Size(95, 20);
		F687DA81.TabIndex = 43;
		F687DA81.Text = "Follow page";
		F687DA81.UseVisualStyleBackColor = true;
		ckbLike.AutoSize = true;
		ckbLike.Cursor = Cursors.Hand;
		ckbLike.Location = new Point(159, 136);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new Size(80, 20);
		ckbLike.TabIndex = 42;
		ckbLike.Text = "Like page";
		ckbLike.UseVisualStyleBackColor = true;
		E83AA130.AutoSize = true;
		E83AA130.Location = new Point(27, 159);
		E83AA130.Name = "label2";
		E83AA130.Size = new Size(139, 16);
		E83AA130.TabIndex = 40;
		E83AA130.Text = "Danh sa\u0301ch Id Page (0):";
		nudDelayTo.Location = new Point(256, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(159, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		B611D19A.Location = new Point(159, 49);
		B611D19A.Name = "txtTenHanhDong";
		B611D19A.Size = new Size(190, 23);
		B611D19A.TabIndex = 0;
		label7.Location = new Point(221, 80);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		D3006730.AutoSize = true;
		D3006730.Location = new Point(314, 80);
		D3006730.Name = "label6";
		D3006730.Size = new Size(30, 16);
		D3006730.TabIndex = 36;
		D3006730.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 80);
		label5.Name = "label5";
		label5.Size = new Size(99, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian delay:";
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
		btnCancel.Location = new Point(198, 363);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += B1BEC488;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(91, 363);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(B40C418D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(377, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(380, 405);
		base.Controls.Add(A9B14B3B);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBuffFollowLikePage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDBuffFollowLikePage_Load;
		B40C418D.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		A9B14B3B.ResumeLayout(performLayout: false);
		A9B14B3B.PerformLayout();
		((ISupportInitialize)D4B53737).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
