using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDChucMungSinhNhat : Form
{
	private JObject jobject_0;

	private string F707061C;

	private string BABBDCAC;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel FE07A5A7;

	private NumericUpDown B3169281;

	private NumericUpDown B48A90A4;

	private TextBox D81DAB0B;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label C2AE8B2E;

	private Button CF2A5ABE;

	private Button btnAdd;

	private BunifuCards B9000F9F;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label D3B8BE2C;

	private Label D588AA8E;

	private TextBox txtContent;

	private NumericUpDown E83E582E;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label D5103BB6;

	private RadioButton rbDangBai;

	private RadioButton rbNhanTin;

	private Label label28;

	public fHDChucMungSinhNhat(string string_1, int int_1 = 0, string E89AEF9C = "")
	{
		InitializeComponent();
		bool_0 = false;
		F707061C = string_1;
		string_0 = E89AEF9C;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDChucMungSinhNhat");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			BABBDCAC = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D81DAB0B.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E89AEF9C);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			D81DAB0B.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(C2AE8B2E);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(D5103BB6);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(label28);
		Language.smethod_0(rbNhanTin);
		Language.smethod_0(rbDangBai);
		Language.smethod_0(D588AA8E);
		Language.smethod_0(D3B8BE2C);
		Language.smethod_0(btnAdd);
		Language.smethod_0(CF2A5ABE);
	}

	private void C7B7BCB5(object sender, EventArgs e)
	{
		try
		{
			B48A90A4.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			B3169281.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			E83E582E.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			if (Convert.ToInt32(jobject_0["typeAction"]) == 0)
			{
				rbNhanTin.Checked = true;
			}
			else
			{
				rbDangBai.Checked = true;
			}
			txtContent.Text = jobject_0["txtContent"].ToString();
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
		string text = D81DAB0B.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtContent.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n/ba\u0300i viê\u0301t!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", B48A90A4.Value);
		gClass.GetJson("nudSoLuongTo", B3169281.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", E83E582E.Value);
		if (rbNhanTin.Checked)
		{
			gClass.GetJson("typeAction", 0);
		}
		else
		{
			gClass.GetJson("typeAction", 1);
		}
		gClass.GetJson("txtContent", txtContent.Text.Trim());
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(F707061C, text, BABBDCAC, text2))
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
			if (InteractSQL.smethod_13(string_0, text, text2))
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

	private void CF2A5ABE_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FE07A5A7_Paint(object sender, PaintEventArgs e)
	{
		if (FE07A5A7.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FE07A5A7.ClientSize.Width - num, FE07A5A7.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void D9B8431A(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtContent.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			D588AA8E.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n/ba\u0300i viê\u0301t ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người nhận!");
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChucMungSinhNhat));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.FE07A5A7 = new System.Windows.Forms.Panel();
		this.rbDangBai = new System.Windows.Forms.RadioButton();
		this.rbNhanTin = new System.Windows.Forms.RadioButton();
		this.label28 = new System.Windows.Forms.Label();
		this.txtContent = new System.Windows.Forms.TextBox();
		this.E83E582E = new System.Windows.Forms.NumericUpDown();
		this.D3B8BE2C = new System.Windows.Forms.Label();
		this.D588AA8E = new System.Windows.Forms.Label();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.D5103BB6 = new System.Windows.Forms.Label();
		this.B3169281 = new System.Windows.Forms.NumericUpDown();
		this.B48A90A4 = new System.Windows.Forms.NumericUpDown();
		this.D81DAB0B = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.C2AE8B2E = new System.Windows.Forms.Label();
		this.CF2A5ABE = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.B9000F9F = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.FE07A5A7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E83E582E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B3169281).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B48A90A4).BeginInit();
		this.B9000F9F.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
		this.bunifuDragControl_0.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Chúc mừng sinh nhật";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.FE07A5A7.BackColor = System.Drawing.Color.White;
		this.FE07A5A7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FE07A5A7.Controls.Add(this.rbDangBai);
		this.FE07A5A7.Controls.Add(this.rbNhanTin);
		this.FE07A5A7.Controls.Add(this.label28);
		this.FE07A5A7.Controls.Add(this.txtContent);
		this.FE07A5A7.Controls.Add(this.E83E582E);
		this.FE07A5A7.Controls.Add(this.D3B8BE2C);
		this.FE07A5A7.Controls.Add(this.D588AA8E);
		this.FE07A5A7.Controls.Add(this.nudDelayFrom);
		this.FE07A5A7.Controls.Add(this.label7);
		this.FE07A5A7.Controls.Add(this.label6);
		this.FE07A5A7.Controls.Add(this.D5103BB6);
		this.FE07A5A7.Controls.Add(this.B3169281);
		this.FE07A5A7.Controls.Add(this.B48A90A4);
		this.FE07A5A7.Controls.Add(this.D81DAB0B);
		this.FE07A5A7.Controls.Add(this.label3);
		this.FE07A5A7.Controls.Add(this.label4);
		this.FE07A5A7.Controls.Add(this.label2);
		this.FE07A5A7.Controls.Add(this.C2AE8B2E);
		this.FE07A5A7.Controls.Add(this.CF2A5ABE);
		this.FE07A5A7.Controls.Add(this.btnAdd);
		this.FE07A5A7.Controls.Add(this.B9000F9F);
		this.FE07A5A7.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.FE07A5A7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FE07A5A7.Location = new System.Drawing.Point(0, 0);
		this.FE07A5A7.Name = "panel1";
		this.FE07A5A7.Size = new System.Drawing.Size(362, 408);
		this.FE07A5A7.TabIndex = 0;
		this.FE07A5A7.Paint += new System.Windows.Forms.PaintEventHandler(FE07A5A7_Paint);
		this.rbDangBai.AutoSize = true;
		this.rbDangBai.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbDangBai.Location = new System.Drawing.Point(229, 141);
		this.rbDangBai.Name = "rbDangBai";
		this.rbDangBai.Size = new System.Drawing.Size(76, 20);
		this.rbDangBai.TabIndex = 91;
		this.rbDangBai.Text = "Đăng ba\u0300i";
		this.rbDangBai.UseVisualStyleBackColor = true;
		this.rbNhanTin.AutoSize = true;
		this.rbNhanTin.Checked = true;
		this.rbNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNhanTin.Location = new System.Drawing.Point(132, 141);
		this.rbNhanTin.Name = "rbNhanTin";
		this.rbNhanTin.Size = new System.Drawing.Size(72, 20);
		this.rbNhanTin.TabIndex = 90;
		this.rbNhanTin.TabStop = true;
		this.rbNhanTin.Text = "Nhă\u0301n tin";
		this.rbNhanTin.UseVisualStyleBackColor = true;
		this.label28.AutoSize = true;
		this.label28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label28.Location = new System.Drawing.Point(28, 141);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(66, 16);
		this.label28.TabIndex = 92;
		this.label28.Text = "Hi\u0300nh thư\u0301c:";
		this.txtContent.Location = new System.Drawing.Point(31, 191);
		this.txtContent.Multiline = true;
		this.txtContent.Name = "txtContent";
		this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtContent.Size = new System.Drawing.Size(295, 138);
		this.txtContent.TabIndex = 5;
		this.txtContent.WordWrap = false;
		this.txtContent.TextChanged += new System.EventHandler(D9B8431A);
		this.E83E582E.Location = new System.Drawing.Point(229, 111);
		this.E83E582E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E83E582E.Name = "nudDelayTo";
		this.E83E582E.Size = new System.Drawing.Size(56, 23);
		this.E83E582E.TabIndex = 4;
		this.D3B8BE2C.AutoSize = true;
		this.D3B8BE2C.Location = new System.Drawing.Point(28, 332);
		this.D3B8BE2C.Name = "label8";
		this.D3B8BE2C.Size = new System.Drawing.Size(265, 16);
		this.D3B8BE2C.TabIndex = 0;
		this.D3B8BE2C.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.D588AA8E.AutoSize = true;
		this.D588AA8E.Location = new System.Drawing.Point(27, 169);
		this.D588AA8E.Name = "lblStatus";
		this.D588AA8E.Size = new System.Drawing.Size(188, 16);
		this.D588AA8E.TabIndex = 0;
		this.D588AA8E.Text = "Danh sa\u0301ch tin nhă\u0301n/ba\u0300i viê\u0301t (0):";
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(194, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(286, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.D5103BB6.AutoSize = true;
		this.D5103BB6.Location = new System.Drawing.Point(27, 113);
		this.D5103BB6.Name = "label5";
		this.D5103BB6.Size = new System.Drawing.Size(89, 16);
		this.D5103BB6.TabIndex = 44;
		this.D5103BB6.Text = "Thơ\u0300i gian chơ\u0300:";
		this.B3169281.Location = new System.Drawing.Point(229, 80);
		this.B3169281.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B3169281.Name = "nudSoLuongTo";
		this.B3169281.Size = new System.Drawing.Size(56, 23);
		this.B3169281.TabIndex = 2;
		this.B48A90A4.Location = new System.Drawing.Point(132, 80);
		this.B48A90A4.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B48A90A4.Name = "nudSoLuongFrom";
		this.B48A90A4.Size = new System.Drawing.Size(56, 23);
		this.B48A90A4.TabIndex = 1;
		this.D81DAB0B.Location = new System.Drawing.Point(132, 49);
		this.D81DAB0B.Name = "txtTenHanhDong";
		this.D81DAB0B.Size = new System.Drawing.Size(194, 23);
		this.D81DAB0B.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(286, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.C2AE8B2E.AutoSize = true;
		this.C2AE8B2E.Location = new System.Drawing.Point(27, 52);
		this.C2AE8B2E.Name = "label1";
		this.C2AE8B2E.Size = new System.Drawing.Size(98, 16);
		this.C2AE8B2E.TabIndex = 31;
		this.C2AE8B2E.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.CF2A5ABE.BackColor = System.Drawing.Color.Maroon;
		this.CF2A5ABE.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CF2A5ABE.FlatAppearance.BorderSize = 0;
		this.CF2A5ABE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CF2A5ABE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CF2A5ABE.ForeColor = System.Drawing.Color.White;
		this.CF2A5ABE.Location = new System.Drawing.Point(185, 363);
		this.CF2A5ABE.Name = "btnCancel";
		this.CF2A5ABE.Size = new System.Drawing.Size(92, 29);
		this.CF2A5ABE.TabIndex = 7;
		this.CF2A5ABE.Text = "Đóng";
		this.CF2A5ABE.UseVisualStyleBackColor = false;
		this.CF2A5ABE.Click += new System.EventHandler(CF2A5ABE_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(78, 363);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.B9000F9F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B9000F9F.BackColor = System.Drawing.Color.White;
		this.B9000F9F.BorderRadius = 0;
		this.B9000F9F.BottomSahddow = true;
		this.B9000F9F.color = System.Drawing.Color.DarkViolet;
		this.B9000F9F.Controls.Add(this.pnlHeader);
		this.B9000F9F.LeftSahddow = false;
		this.B9000F9F.Location = new System.Drawing.Point(1, 0);
		this.B9000F9F.Name = "bunifuCards1";
		this.B9000F9F.RightSahddow = true;
		this.B9000F9F.ShadowDepth = 20;
		this.B9000F9F.Size = new System.Drawing.Size(359, 37);
		this.B9000F9F.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 408);
		base.Controls.Add(this.FE07A5A7);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChucMungSinhNhat";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C7B7BCB5);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.FE07A5A7.ResumeLayout(false);
		this.FE07A5A7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.E83E582E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B3169281).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B48A90A4).EndInit();
		this.B9000F9F.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
