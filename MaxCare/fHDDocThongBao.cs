using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDDocThongBao : Form
{
	private JObject jobject_0;

	private string E3B4FBBF;

	private string F6A9300C;

	private string F0A97727;

	private int B90E2BBD;

	public static bool F592AD29;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A8BF0F0C;

	private Panel F00C51A7;

	private RadioButton F0A95D9B;

	private RadioButton rbLanLuot;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F682F321;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label D5150D0F;

	private Label label3;

	private Label label6;

	private Label label4;

	private Label label5;

	private Label E791DA29;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button B3B4F33A;

	private PictureBox pictureBox1;

	private BunifuCustomLabel E2025DAF;

	public fHDDocThongBao(string EB2853B5, int int_0 = 0, string D30E01B6 = "")
	{
		D52D0191();
		F592AD29 = false;
		E3B4FBBF = EB2853B5;
		F0A97727 = D30E01B6;
		B90E2BBD = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDDocThongBao");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			F6A9300C = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(D30E01B6);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void E9BBE734()
	{
		Language.smethod_0(E2025DAF);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(E791DA29);
		Language.smethod_0(rbLanLuot);
		Language.smethod_0(F0A95D9B);
		Language.smethod_0(label5);
		Language.smethod_0(D5150D0F);
		Language.smethod_0(label6);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void C42ED187(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			F682F321.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			if (jobject_0["typeDocThongBao"].ToString() == "0")
			{
				rbLanLuot.Checked = true;
			}
			else
			{
				F0A95D9B.Checked = true;
			}
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void B8288424(object sender, EventArgs e)
	{
		Close();
	}

	private void F1911993(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", F682F321.Value);
		int num = 0;
		if (F0A95D9B.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeDocThongBao", num);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.D9A09B34();
		if (B90E2BBD == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E3B4FBBF, text, F6A9300C, text2))
				{
					F592AD29 = true;
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
			if (InteractSQL.smethod_13(F0A97727, text, text2))
			{
				F592AD29 = true;
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

	private void F00C51A7_Paint(object sender, PaintEventArgs e)
	{
		if (F00C51A7.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F00C51A7.ClientSize.Width - num, F00C51A7.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool AB8160B9)
	{
		if (AB8160B9 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AB8160B9);
	}

	private void D52D0191()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDocThongBao));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		E2025DAF = new BunifuCustomLabel();
		A8BF0F0C = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		B3B4F33A = new Button();
		pictureBox1 = new PictureBox();
		F00C51A7 = new Panel();
		F0A95D9B = new RadioButton();
		rbLanLuot = new RadioButton();
		nudDelayTo = new NumericUpDown();
		F682F321 = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		D5150D0F = new Label();
		label3 = new Label();
		label6 = new Label();
		label4 = new Label();
		label5 = new Label();
		E791DA29 = new Label();
		label2 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		F00C51A7.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)F682F321).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = E2025DAF;
		bunifuDragControl_0.Vertical = true;
		E2025DAF.BackColor = Color.Transparent;
		E2025DAF.Cursor = Cursors.SizeAll;
		E2025DAF.Dock = DockStyle.Fill;
		E2025DAF.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E2025DAF.ForeColor = Color.Black;
		E2025DAF.Location = new Point(0, 0);
		E2025DAF.Name = "bunifuCustomLabel1";
		E2025DAF.Size = new Size(359, 31);
		E2025DAF.TabIndex = 12;
		E2025DAF.Text = "Cấu hình đọc thông báo";
		E2025DAF.TextAlign = ContentAlignment.MiddleCenter;
		A8BF0F0C.Fixed = true;
		A8BF0F0C.Horizontal = true;
		A8BF0F0C.TargetControl = pnlHeader;
		A8BF0F0C.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(B3B4F33A);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(E2025DAF);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		B3B4F33A.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B3B4F33A.Cursor = Cursors.Hand;
		B3B4F33A.FlatAppearance.BorderSize = 0;
		B3B4F33A.FlatStyle = FlatStyle.Flat;
		B3B4F33A.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B3B4F33A.ForeColor = Color.White;
		B3B4F33A.Image = (Image)componentResourceManager.GetObject("button1.Image");
		B3B4F33A.Location = new Point(328, 1);
		B3B4F33A.Name = "button1";
		B3B4F33A.Size = new Size(30, 30);
		B3B4F33A.TabIndex = 77;
		B3B4F33A.TextImageRelation = TextImageRelation.ImageBeforeText;
		B3B4F33A.UseVisualStyleBackColor = true;
		B3B4F33A.Click += B8288424;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		F00C51A7.BackColor = Color.White;
		F00C51A7.BorderStyle = BorderStyle.FixedSingle;
		F00C51A7.Controls.Add(F0A95D9B);
		F00C51A7.Controls.Add(rbLanLuot);
		F00C51A7.Controls.Add(nudDelayTo);
		F00C51A7.Controls.Add(F682F321);
		F00C51A7.Controls.Add(nudDelayFrom);
		F00C51A7.Controls.Add(nudSoLuongFrom);
		F00C51A7.Controls.Add(txtTenHanhDong);
		F00C51A7.Controls.Add(D5150D0F);
		F00C51A7.Controls.Add(label3);
		F00C51A7.Controls.Add(label6);
		F00C51A7.Controls.Add(label4);
		F00C51A7.Controls.Add(label5);
		F00C51A7.Controls.Add(E791DA29);
		F00C51A7.Controls.Add(label2);
		F00C51A7.Controls.Add(label1);
		F00C51A7.Controls.Add(btnCancel);
		F00C51A7.Controls.Add(btnAdd);
		F00C51A7.Controls.Add(bunifuCards1);
		F00C51A7.Cursor = Cursors.Arrow;
		F00C51A7.Dock = DockStyle.Fill;
		F00C51A7.Location = new Point(0, 0);
		F00C51A7.Name = "panel1";
		F00C51A7.Size = new Size(362, 216);
		F00C51A7.TabIndex = 0;
		F00C51A7.Paint += F00C51A7_Paint;
		F0A95D9B.AutoSize = true;
		F0A95D9B.Cursor = Cursors.Hand;
		F0A95D9B.Location = new Point(216, 107);
		F0A95D9B.Name = "rbNgauNhien";
		F0A95D9B.Size = new Size(89, 20);
		F0A95D9B.TabIndex = 4;
		F0A95D9B.TabStop = true;
		F0A95D9B.Text = "Ngâ\u0303u nhiên";
		F0A95D9B.UseVisualStyleBackColor = true;
		rbLanLuot.AutoSize = true;
		rbLanLuot.Cursor = Cursors.Hand;
		rbLanLuot.Location = new Point(122, 107);
		rbLanLuot.Name = "rbLanLuot";
		rbLanLuot.Size = new Size(71, 20);
		rbLanLuot.TabIndex = 3;
		rbLanLuot.TabStop = true;
		rbLanLuot.Text = "Lâ\u0300n lươ\u0323t";
		rbLanLuot.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(216, 133);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 6;
		F682F321.Location = new Point(216, 78);
		F682F321.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F682F321.Name = "nudSoLuongTo";
		F682F321.Size = new Size(56, 23);
		F682F321.TabIndex = 2;
		nudDelayFrom.Location = new Point(122, 133);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongFrom.Location = new Point(122, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(122, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(216, 23);
		txtTenHanhDong.TabIndex = 0;
		D5150D0F.Location = new Point(182, 135);
		D5150D0F.Name = "label7";
		D5150D0F.Size = new Size(29, 16);
		D5150D0F.TabIndex = 38;
		D5150D0F.Text = "đê\u0301n";
		D5150D0F.TextAlign = ContentAlignment.MiddleCenter;
		label3.Location = new Point(182, 80);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(277, 135);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new Point(274, 80);
		label4.Name = "label4";
		label4.Size = new Size(64, 16);
		label4.TabIndex = 35;
		label4.Text = "thông ba\u0301o";
		label5.AutoSize = true;
		label5.Location = new Point(17, 135);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		E791DA29.AutoSize = true;
		E791DA29.Location = new Point(17, 109);
		E791DA29.Name = "label8";
		E791DA29.Size = new Size(92, 16);
		E791DA29.TabIndex = 33;
		E791DA29.Text = "Tu\u0300y cho\u0323n xem:";
		label2.AutoSize = true;
		label2.Location = new Point(17, 80);
		label2.Name = "label2";
		label2.Size = new Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new Point(17, 52);
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
		btnCancel.Location = new Point(190, 172);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 8;
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
		btnAdd.Location = new Point(86, 172);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 7;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += F1911993;
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
		bunifuCards1.TabIndex = 9;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 216);
		base.Controls.Add(F00C51A7);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDocThongBao";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C42ED187;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		F00C51A7.ResumeLayout(performLayout: false);
		F00C51A7.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)F682F321).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
