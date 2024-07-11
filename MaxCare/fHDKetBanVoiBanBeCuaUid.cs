using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanVoiBanBeCuaUid : Form
{
	private JSON_Settings CE8228A1;

	private string BB86990C;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B01EBF91;

	private Panel E208802A;

	private NumericUpDown BA2E1E88;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label E7380A27;

	private Label label2;

	private Label label1;

	private Button B93CEF23;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button D31CEA87;

	private PictureBox DBB67A08;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label EB2CFD33;

	private RichTextBox CCA3C318;

	private ToolTip C81494B6;

	private CheckBox ckbTuDongXoaUid;

	public fHDKetBanVoiBanBeCuaUid(string string_2, int A30957BB = 0, string string_3 = "")
	{
		AE831CA9();
		bool_0 = false;
		BB86990C = string_2;
		string_1 = string_3;
		int_0 = A30957BB;
		if (InteractSQL.B484648C("", "HDKetBanVoiBanBeCuaUid").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanVoiBanBeCuaUid', 'Kết bạn với bạn bè của Uid');");
		}
		string text = "";
		switch (A30957BB)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanVoiBanBeCuaUid");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CE8228A1 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void E13958A6(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = CE8228A1.GetValueInt("nudSoLuongFrom", 3);
			BA2E1E88.Value = CE8228A1.GetValueInt("nudSoLuongTo", 5);
			nudDelayFrom.Value = CE8228A1.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = CE8228A1.GetValueInt("nudDelayTo", 5);
			CCA3C318.Text = CE8228A1.GetValue("txtUid");
			ckbTuDongXoaUid.Checked = CE8228A1.GetValueBool("ckbTuDongXoaUid");
		}
		catch
		{
		}
	}

	private void D31CEA87_Click(object sender, EventArgs e)
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
		List<string> a2AB53A = CCA3C318.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", BA2E1E88.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtUid", CCA3C318.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(BB86990C, text, string_0, string_))
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

	private void AFB9A182(object sender, EventArgs e)
	{
		Close();
	}

	private void E208802A_Paint(object sender, PaintEventArgs e)
	{
		if (E208802A.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E208802A.ClientSize.Width - num, E208802A.ClientSize.Height - num));
		}
	}

	private void CCA3C318_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(CCA3C318, lblStatus);
	}

	protected override void Dispose(bool EF9BA191)
	{
		if (EF9BA191 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(EF9BA191);
	}

	private void AE831CA9()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDKetBanVoiBanBeCuaUid));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		B01EBF91 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		D31CEA87 = new Button();
		DBB67A08 = new PictureBox();
		E208802A = new Panel();
		ckbTuDongXoaUid = new CheckBox();
		CCA3C318 = new RichTextBox();
		nudDelayTo = new NumericUpDown();
		lblStatus = new Label();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		label6 = new Label();
		EB2CFD33 = new Label();
		BA2E1E88 = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		E7380A27 = new Label();
		label2 = new Label();
		label1 = new Label();
		B93CEF23 = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		C81494B6 = new ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)DBB67A08).BeginInit();
		E208802A.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)BA2E1E88).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn với bạn bè của Uid";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		B01EBF91.Fixed = true;
		B01EBF91.Horizontal = true;
		B01EBF91.TargetControl = pnlHeader;
		B01EBF91.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D31CEA87);
		pnlHeader.Controls.Add(DBB67A08);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		D31CEA87.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D31CEA87.Cursor = Cursors.Hand;
		D31CEA87.FlatAppearance.BorderSize = 0;
		D31CEA87.FlatStyle = FlatStyle.Flat;
		D31CEA87.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D31CEA87.ForeColor = Color.White;
		D31CEA87.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D31CEA87.Location = new Point(328, 1);
		D31CEA87.Name = "button1";
		D31CEA87.Size = new Size(30, 30);
		D31CEA87.TabIndex = 77;
		D31CEA87.TextImageRelation = TextImageRelation.ImageBeforeText;
		D31CEA87.UseVisualStyleBackColor = true;
		D31CEA87.Click += D31CEA87_Click;
		DBB67A08.Cursor = Cursors.Default;
		DBB67A08.Image = Resources.Bitmap_4;
		DBB67A08.Location = new Point(3, 2);
		DBB67A08.Name = "pictureBox1";
		DBB67A08.Size = new Size(34, 27);
		DBB67A08.SizeMode = PictureBoxSizeMode.Zoom;
		DBB67A08.TabIndex = 76;
		DBB67A08.TabStop = false;
		E208802A.BackColor = Color.White;
		E208802A.BorderStyle = BorderStyle.FixedSingle;
		E208802A.Controls.Add(ckbTuDongXoaUid);
		E208802A.Controls.Add(CCA3C318);
		E208802A.Controls.Add(nudDelayTo);
		E208802A.Controls.Add(lblStatus);
		E208802A.Controls.Add(nudDelayFrom);
		E208802A.Controls.Add(label7);
		E208802A.Controls.Add(label6);
		E208802A.Controls.Add(EB2CFD33);
		E208802A.Controls.Add(BA2E1E88);
		E208802A.Controls.Add(nudSoLuongFrom);
		E208802A.Controls.Add(txtTenHanhDong);
		E208802A.Controls.Add(label3);
		E208802A.Controls.Add(E7380A27);
		E208802A.Controls.Add(label2);
		E208802A.Controls.Add(label1);
		E208802A.Controls.Add(B93CEF23);
		E208802A.Controls.Add(btnAdd);
		E208802A.Controls.Add(bunifuCards1);
		E208802A.Cursor = Cursors.Arrow;
		E208802A.Dock = DockStyle.Fill;
		E208802A.Location = new Point(0, 0);
		E208802A.Name = "panel1";
		E208802A.Size = new Size(362, 383);
		E208802A.TabIndex = 0;
		E208802A.Paint += E208802A_Paint;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = Cursors.Hand;
		ckbTuDongXoaUid.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new Point(30, 300);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new Size(170, 20);
		ckbTuDongXoaUid.TabIndex = 115;
		ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 dùng";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		CCA3C318.BorderStyle = BorderStyle.FixedSingle;
		CCA3C318.Location = new Point(31, 159);
		CCA3C318.Name = "txtUid";
		CCA3C318.Size = new Size(295, 136);
		CCA3C318.TabIndex = 114;
		CCA3C318.Text = "";
		CCA3C318.WordWrap = false;
		CCA3C318.TextChanged += CCA3C318_TextChanged;
		nudDelayTo.Location = new Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(27, 139);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(114, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Uid (0):";
		nudDelayFrom.Location = new Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.AutoSize = true;
		label7.Location = new Point(194, 113);
		label7.Name = "label7";
		label7.Size = new Size(28, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new Point(290, 113);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		EB2CFD33.AutoSize = true;
		EB2CFD33.Location = new Point(27, 113);
		EB2CFD33.Name = "label5";
		EB2CFD33.Size = new Size(89, 16);
		EB2CFD33.TabIndex = 44;
		EB2CFD33.Text = "Thơ\u0300i gian chơ\u0300:";
		BA2E1E88.Location = new Point(229, 80);
		BA2E1E88.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BA2E1E88.Name = "nudSoLuongTo";
		BA2E1E88.Size = new Size(56, 23);
		BA2E1E88.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new Point(194, 82);
		label3.Name = "label3";
		label3.Size = new Size(28, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		E7380A27.AutoSize = true;
		E7380A27.Location = new Point(290, 82);
		E7380A27.Name = "label4";
		E7380A27.Size = new Size(28, 16);
		E7380A27.TabIndex = 35;
		E7380A27.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(27, 82);
		label2.Name = "label2";
		label2.Size = new Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		B93CEF23.Anchor = AnchorStyles.Bottom;
		B93CEF23.BackColor = Color.Maroon;
		B93CEF23.Cursor = Cursors.Hand;
		B93CEF23.FlatAppearance.BorderSize = 0;
		B93CEF23.FlatStyle = FlatStyle.Flat;
		B93CEF23.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B93CEF23.ForeColor = Color.White;
		B93CEF23.Location = new Point(190, 337);
		B93CEF23.Name = "btnCancel";
		B93CEF23.Size = new Size(92, 29);
		B93CEF23.TabIndex = 7;
		B93CEF23.Text = "Đóng";
		B93CEF23.UseVisualStyleBackColor = false;
		B93CEF23.Click += AFB9A182;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(83, 337);
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
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		C81494B6.AutomaticDelay = 0;
		C81494B6.AutoPopDelay = 0;
		C81494B6.InitialDelay = 0;
		C81494B6.ReshowDelay = 0;
		C81494B6.ShowAlways = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 383);
		base.Controls.Add(E208802A);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVoiBanBeCuaUid";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += E13958A6;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)DBB67A08).EndInit();
		E208802A.ResumeLayout(performLayout: false);
		E208802A.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)BA2E1E88).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
