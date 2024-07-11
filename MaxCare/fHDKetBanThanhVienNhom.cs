using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDKetBanThanhVienNhom : Form
{
	private JObject jobject_0;

	private string string_0;

	private string string_1;

	private string A832E424;

	private int int_0;

	public static bool FE2F2423;

	private IContainer F885829C = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A321548A;

	private Panel E82A2034;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown DA01AC87;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label D310F19D;

	private Label label1;

	private Button btnCancel;

	private Button F8036726;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private RichTextBox txtUid;

	private ToolTip toolTip_0;

	private CheckBox ckbTenViet;

	public fHDKetBanThanhVienNhom(string string_2, int int_1 = 0, string FD1D1BA0 = "")
	{
		ADA9422A();
		FE2F2423 = false;
		string_0 = string_2;
		A832E424 = FD1D1BA0;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanThanhVienNhom");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(FD1D1BA0);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			F8036726.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void fHDKetBanThanhVienNhom_Load(object sender, EventArgs e)
	{
		try
		{
			DA01AC87.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			ckbTenViet.Checked = Convert.ToBoolean(jobject_0["ckbTenViet"]);
			txtUid.Text = jobject_0["txtUid"].ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AC8652B4(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", DA01AC87.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbTenViet", ckbTenViet.Checked);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					FE2F2423 = true;
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
			if (InteractSQL.smethod_13(A832E424, text, string_))
			{
				FE2F2423 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void BA1AB9A9(object sender, EventArgs e)
	{
		Close();
	}

	private void E82A2034_Paint(object sender, PaintEventArgs e)
	{
		if (E82A2034.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E82A2034.ClientSize.Width - num, E82A2034.ClientSize.Height - num));
		}
	}

	private void DFB9C332(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid nhóm ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && F885829C != null)
		{
			F885829C.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void ADA9422A()
	{
		F885829C = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDKetBanThanhVienNhom));
		bunifuDragControl_0 = new BunifuDragControl(F885829C);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		A321548A = new BunifuDragControl(F885829C);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		E82A2034 = new Panel();
		txtUid = new RichTextBox();
		nudDelayTo = new NumericUpDown();
		lblStatus = new Label();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		DA01AC87 = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		label4 = new Label();
		D310F19D = new Label();
		label1 = new Label();
		btnCancel = new Button();
		F8036726 = new Button();
		bunifuCards1 = new BunifuCards();
		ckbTenViet = new CheckBox();
		toolTip_0 = new ToolTip(F885829C);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		E82A2034.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)DA01AC87).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(353, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn thành viên nhóm";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		A321548A.Fixed = true;
		A321548A.Horizontal = true;
		A321548A.TargetControl = pnlHeader;
		A321548A.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(353, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(322, 1);
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
		E82A2034.BackColor = Color.White;
		E82A2034.BorderStyle = BorderStyle.FixedSingle;
		E82A2034.Controls.Add(txtUid);
		E82A2034.Controls.Add(nudDelayTo);
		E82A2034.Controls.Add(lblStatus);
		E82A2034.Controls.Add(nudDelayFrom);
		E82A2034.Controls.Add(label7);
		E82A2034.Controls.Add(label6);
		E82A2034.Controls.Add(label5);
		E82A2034.Controls.Add(nudSoLuongTo);
		E82A2034.Controls.Add(DA01AC87);
		E82A2034.Controls.Add(txtTenHanhDong);
		E82A2034.Controls.Add(label3);
		E82A2034.Controls.Add(label4);
		E82A2034.Controls.Add(D310F19D);
		E82A2034.Controls.Add(label1);
		E82A2034.Controls.Add(btnCancel);
		E82A2034.Controls.Add(F8036726);
		E82A2034.Controls.Add(bunifuCards1);
		E82A2034.Controls.Add(ckbTenViet);
		E82A2034.Cursor = Cursors.Arrow;
		E82A2034.Dock = DockStyle.Fill;
		E82A2034.Location = new Point(0, 0);
		E82A2034.Name = "panel1";
		E82A2034.Size = new Size(356, 350);
		E82A2034.TabIndex = 0;
		E82A2034.Paint += E82A2034_Paint;
		txtUid.BorderStyle = BorderStyle.FixedSingle;
		txtUid.Location = new Point(31, 157);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(295, 136);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += DFB9C332;
		nudDelayTo.Location = new Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(27, 137);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(150, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Uid nhóm (0):";
		nudDelayFrom.Location = new Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new Point(194, 109);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 109);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 109);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		DA01AC87.Location = new Point(132, 78);
		DA01AC87.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DA01AC87.Name = "nudSoLuongFrom";
		DA01AC87.Size = new Size(56, 23);
		DA01AC87.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new Point(194, 80);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new Point(287, 80);
		label4.Name = "label4";
		label4.Size = new Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		D310F19D.AutoSize = true;
		D310F19D.Location = new Point(27, 80);
		D310F19D.Name = "label2";
		D310F19D.Size = new Size(88, 16);
		D310F19D.TabIndex = 32;
		D310F19D.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
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
		btnCancel.Location = new Point(190, 311);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += BA1AB9A9;
		F8036726.Anchor = AnchorStyles.Bottom;
		F8036726.BackColor = Color.FromArgb(53, 120, 229);
		F8036726.Cursor = Cursors.Hand;
		F8036726.FlatAppearance.BorderSize = 0;
		F8036726.FlatStyle = FlatStyle.Flat;
		F8036726.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F8036726.ForeColor = Color.White;
		F8036726.Location = new Point(83, 311);
		F8036726.Name = "btnAdd";
		F8036726.Size = new Size(92, 29);
		F8036726.TabIndex = 6;
		F8036726.Text = "Thêm";
		F8036726.UseVisualStyleBackColor = false;
		F8036726.Click += AC8652B4;
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
		bunifuCards1.Size = new Size(353, 37);
		bunifuCards1.TabIndex = 28;
		ckbTenViet.AutoSize = true;
		ckbTenViet.Cursor = Cursors.Hand;
		ckbTenViet.Location = new Point(31, 170);
		ckbTenViet.Name = "ckbTenViet";
		ckbTenViet.Size = new Size(156, 20);
		ckbTenViet.TabIndex = 115;
		ckbTenViet.Text = "Chỉ kết bạn với tên việt";
		ckbTenViet.UseVisualStyleBackColor = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(356, 350);
		base.Controls.Add(E82A2034);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanThanhVienNhom";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDKetBanThanhVienNhom_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		E82A2034.ResumeLayout(performLayout: false);
		E82A2034.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)DA01AC87).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
