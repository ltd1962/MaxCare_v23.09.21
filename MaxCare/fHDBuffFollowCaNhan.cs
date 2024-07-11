using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;


public class fHDBuffFollowCaNhan : Form
{
	private JObject C69FBF96;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl C9397B17;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label C681ADB0;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button B7289825;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button CDA4DC35;

	private PictureBox pictureBox1;

	private BunifuCustomLabel F80A60A2;

	private Label D01E3ABA;

	private TextBox txtUid;

	private Label A1ABDEA2;

	public fHDBuffFollowCaNhan(string string_3, int int_1 = 0, string string_4 = "")
	{
		E5246691();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDBuffFollowCaNhan").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffFollowCaNhan', '{  \"txtUid\": \"\",\"nudDelayFrom\": \"5\",  \"nudDelayTo\": \"10\"}', 'Buff Follow ca\u0301 nhân');");
		}
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBuffFollowCaNhan");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C69FBF96 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(F80A60A2);
		Language.smethod_0(label1);
		Language.smethod_0(label5);
		Language.smethod_0(C681ADB0);
		Language.smethod_0(label6);
		Language.smethod_0(A1ABDEA2);
		Language.smethod_0(D01E3ABA);
		Language.smethod_0(btnAdd);
		Language.smethod_0(B7289825);
	}

	private void fHDBuffFollowCaNhan_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = Convert.ToInt32(C69FBF96["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(C69FBF96["nudDelayTo"]);
			txtUid.Text = C69FBF96["txtUid"].ToString();
		}
		catch
		{
		}
	}

	private void E71DD42D(object sender, EventArgs e)
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
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid ca\u0301 nhân!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
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
			if (InteractSQL.smethod_13(string_2, text, string_))
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

	private void B7289825_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EFB1CE2A(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void AD137F1B(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			A1ABDEA2.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid Ca\u0301 nhân ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
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

	private void E5246691()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBuffFollowCaNhan));
		C9397B17 = new BunifuDragControl(icontainer_0);
		F80A60A2 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		CDA4DC35 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		D01E3ABA = new Label();
		txtUid = new TextBox();
		A1ABDEA2 = new Label();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		C681ADB0 = new Label();
		label6 = new Label();
		label5 = new Label();
		label1 = new Label();
		B7289825 = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		C9397B17.Fixed = true;
		C9397B17.Horizontal = true;
		C9397B17.TargetControl = F80A60A2;
		C9397B17.Vertical = true;
		F80A60A2.BackColor = Color.Transparent;
		F80A60A2.Cursor = Cursors.SizeAll;
		F80A60A2.Dock = DockStyle.Fill;
		F80A60A2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F80A60A2.ForeColor = Color.Black;
		F80A60A2.Location = new Point(0, 0);
		F80A60A2.Name = "bunifuCustomLabel1";
		F80A60A2.Size = new Size(359, 31);
		F80A60A2.TabIndex = 12;
		F80A60A2.Text = "Cấu hình Buff Follow ca\u0301 nhân";
		F80A60A2.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(CDA4DC35);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F80A60A2);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		CDA4DC35.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CDA4DC35.Cursor = Cursors.Hand;
		CDA4DC35.FlatAppearance.BorderSize = 0;
		CDA4DC35.FlatStyle = FlatStyle.Flat;
		CDA4DC35.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		CDA4DC35.ForeColor = Color.White;
		CDA4DC35.Image = (Image)componentResourceManager.GetObject("button1.Image");
		CDA4DC35.Location = new Point(328, 1);
		CDA4DC35.Name = "button1";
		CDA4DC35.Size = new Size(30, 30);
		CDA4DC35.TabIndex = 77;
		CDA4DC35.TextImageRelation = TextImageRelation.ImageBeforeText;
		CDA4DC35.UseVisualStyleBackColor = true;
		CDA4DC35.Click += E71DD42D;
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
		panel1.Controls.Add(D01E3ABA);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(A1ABDEA2);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(C681ADB0);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(B7289825);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 391);
		panel1.TabIndex = 0;
		panel1.Paint += EFB1CE2A;
		D01E3ABA.AutoSize = true;
		D01E3ABA.Location = new Point(28, 322);
		D01E3ABA.Name = "label10";
		D01E3ABA.Size = new Size(102, 16);
		D01E3ABA.TabIndex = 39;
		D01E3ABA.Text = "(Mỗi Uid 1 dòng)";
		txtUid.Location = new Point(31, 125);
		txtUid.Multiline = true;
		txtUid.Name = "txtUid";
		txtUid.ScrollBars = ScrollBars.Both;
		txtUid.Size = new Size(297, 194);
		txtUid.TabIndex = 41;
		txtUid.WordWrap = false;
		txtUid.TextChanged += AD137F1B;
		A1ABDEA2.AutoSize = true;
		A1ABDEA2.Location = new Point(27, 105);
		A1ABDEA2.Name = "label2";
		A1ABDEA2.Size = new Size(165, 16);
		A1ABDEA2.TabIndex = 40;
		A1ABDEA2.Text = "Danh sa\u0301ch Uid Ca\u0301 nhân (0):";
		nudDelayTo.Location = new Point(231, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(134, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		C681ADB0.Location = new Point(196, 80);
		C681ADB0.Name = "label7";
		C681ADB0.Size = new Size(29, 16);
		C681ADB0.TabIndex = 38;
		C681ADB0.Text = "đê\u0301n";
		C681ADB0.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(289, 80);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
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
		B7289825.BackColor = Color.Maroon;
		B7289825.Cursor = Cursors.Hand;
		B7289825.FlatAppearance.BorderSize = 0;
		B7289825.FlatStyle = FlatStyle.Flat;
		B7289825.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B7289825.ForeColor = Color.White;
		B7289825.Location = new Point(188, 347);
		B7289825.Name = "btnCancel";
		B7289825.Size = new Size(92, 29);
		B7289825.TabIndex = 10;
		B7289825.Text = "Đóng";
		B7289825.UseVisualStyleBackColor = false;
		B7289825.Click += B7289825_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(81, 347);
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
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 391);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBuffFollowCaNhan";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDBuffFollowCaNhan_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
