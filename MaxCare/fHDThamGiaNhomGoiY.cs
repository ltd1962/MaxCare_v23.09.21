using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDThamGiaNhomGoiY : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string E0BBFE02;

	private string string_1;

	private int DBAFEF0C;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl F48844AB;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox FE1E2234;

	private Label label3;

	private Label CB81BB1D;

	private Label label2;

	private Label F22496A0;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel F882901B;

	private Button button1;

	private PictureBox EA9298A6;

	private BunifuCustomLabel CE9B810A;

	private NumericUpDown DC108BB3;

	private NumericUpDown F03DEC2E;

	private Label label7;

	private Label label6;

	private Label label5;

	private ToolTip toolTip_0;

	private Panel plTuongTac;

	private CheckBox AD011DAA;

	private TextBox D0955534;

	private Label B4179CAC;

	private Label BB915302;

	public fHDThamGiaNhomGoiY(string string_2, int int_0 = 0, string CCA5F0BF = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = CCA5F0BF;
		DBAFEF0C = int_0;
		if (InteractSQL.B484648C("", "HDThamGiaNhomGoiY").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomGoiY', 'Tham gia nhóm gợi ý');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDThamGiaNhomGoiY");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			E0BBFE02 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FE1E2234.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(CCA5F0BF);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			FE1E2234.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(CE9B810A);
		Language.smethod_0(F22496A0);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(CB81BB1D);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(AD011DAA);
		Language.smethod_0(BB915302);
		Language.smethod_0(B4179CAC);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void fHDThamGiaNhomGoiY_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 5);
			F03DEC2E.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			DC108BB3.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			AD011DAA.Checked = gclass8_0.GetValueBool("ckbTuDongTraLoiCauHoi");
			D0955534.Text = gclass8_0.GetValue("txtCauTraLoi");
		}
		catch
		{
		}
		ABA0DD25();
	}

	private void ABA0DD25()
	{
		BA956D0D(null, null);
	}

	private void F39D349B(object sender, EventArgs e)
	{
		Close();
	}

	private void FEA9FE91(object sender, EventArgs e)
	{
		string text = FE1E2234.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (AD011DAA.Checked)
		{
			List<string> a2AB53A = D0955534.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", F03DEC2E.Value);
		gClass.GetJson("nudDelayTo", DC108BB3.Value);
		gClass.GetJson("ckbTuDongTraLoiCauHoi", AD011DAA.Checked);
		gClass.GetJson("txtCauTraLoi", D0955534.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (DBAFEF0C == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, E0BBFE02, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A217F521(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void D506D202(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = D0955534.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			BB915302.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void BA956D0D(object sender, EventArgs e)
	{
		plTuongTac.Enabled = AD011DAA.Checked;
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
		this.F48844AB = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.CE9B810A = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.F882901B = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.EA9298A6 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plTuongTac = new System.Windows.Forms.Panel();
		this.D0955534 = new System.Windows.Forms.TextBox();
		this.B4179CAC = new System.Windows.Forms.Label();
		this.BB915302 = new System.Windows.Forms.Label();
		this.AD011DAA = new System.Windows.Forms.CheckBox();
		this.DC108BB3 = new System.Windows.Forms.NumericUpDown();
		this.F03DEC2E = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.FE1E2234 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.CB81BB1D = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.F22496A0 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.F882901B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.EA9298A6).BeginInit();
		this.panel1.SuspendLayout();
		this.plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DC108BB3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F03DEC2E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.F48844AB.Fixed = true;
		this.F48844AB.Horizontal = true;
		this.F48844AB.TargetControl = this.CE9B810A;
		this.F48844AB.Vertical = true;
		this.CE9B810A.BackColor = System.Drawing.Color.Transparent;
		this.CE9B810A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.CE9B810A.Dock = System.Windows.Forms.DockStyle.Fill;
		this.CE9B810A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CE9B810A.ForeColor = System.Drawing.Color.Black;
		this.CE9B810A.Location = new System.Drawing.Point(0, 0);
		this.CE9B810A.Name = "bunifuCustomLabel1";
		this.CE9B810A.Size = new System.Drawing.Size(363, 31);
		this.CE9B810A.TabIndex = 12;
		this.CE9B810A.Text = "Cấu hình Tham gia nhóm gợi ý";
		this.CE9B810A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.F882901B;
		this.bunifuDragControl_0.Vertical = true;
		this.F882901B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.F882901B.BackColor = System.Drawing.Color.White;
		this.F882901B.Controls.Add(this.button1);
		this.F882901B.Controls.Add(this.EA9298A6);
		this.F882901B.Controls.Add(this.CE9B810A);
		this.F882901B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.F882901B.Location = new System.Drawing.Point(0, 3);
		this.F882901B.Name = "pnlHeader";
		this.F882901B.Size = new System.Drawing.Size(363, 31);
		this.F882901B.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.C400940B;
		this.button1.Location = new System.Drawing.Point(332, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(F39D349B);
		this.EA9298A6.Cursor = System.Windows.Forms.Cursors.Default;
		this.EA9298A6.Image = Resources.Bitmap_4;
		this.EA9298A6.Location = new System.Drawing.Point(3, 2);
		this.EA9298A6.Name = "pictureBox1";
		this.EA9298A6.Size = new System.Drawing.Size(34, 27);
		this.EA9298A6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.EA9298A6.TabIndex = 76;
		this.EA9298A6.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plTuongTac);
		this.panel1.Controls.Add(this.AD011DAA);
		this.panel1.Controls.Add(this.DC108BB3);
		this.panel1.Controls.Add(this.F03DEC2E);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.FE1E2234);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.CB81BB1D);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.F22496A0);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(366, 398);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(A217F521);
		this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTac.Controls.Add(this.D0955534);
		this.plTuongTac.Controls.Add(this.B4179CAC);
		this.plTuongTac.Controls.Add(this.BB915302);
		this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTac.Location = new System.Drawing.Point(48, 162);
		this.plTuongTac.Name = "plTuongTac";
		this.plTuongTac.Size = new System.Drawing.Size(278, 179);
		this.plTuongTac.TabIndex = 116;
		this.D0955534.Location = new System.Drawing.Point(6, 25);
		this.D0955534.Multiline = true;
		this.D0955534.Name = "txtCauTraLoi";
		this.D0955534.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.D0955534.Size = new System.Drawing.Size(265, 128);
		this.D0955534.TabIndex = 1;
		this.D0955534.WordWrap = false;
		this.D0955534.TextChanged += new System.EventHandler(D506D202);
		this.B4179CAC.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.B4179CAC.AutoSize = true;
		this.B4179CAC.Location = new System.Drawing.Point(3, 158);
		this.B4179CAC.Name = "label9";
		this.B4179CAC.Size = new System.Drawing.Size(134, 16);
		this.B4179CAC.TabIndex = 0;
		this.B4179CAC.Text = "(Mỗi nội dung 1 dòng)";
		this.BB915302.AutoSize = true;
		this.BB915302.Location = new System.Drawing.Point(3, 4);
		this.BB915302.Name = "lblStatusComment";
		this.BB915302.Size = new System.Drawing.Size(154, 16);
		this.BB915302.TabIndex = 0;
		this.BB915302.Text = "Danh sách câu trả lời (0):";
		this.AD011DAA.AutoSize = true;
		this.AD011DAA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AD011DAA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.AD011DAA.Location = new System.Drawing.Point(30, 139);
		this.AD011DAA.Name = "ckbTuDongTraLoiCauHoi";
		this.AD011DAA.Size = new System.Drawing.Size(157, 20);
		this.AD011DAA.TabIndex = 115;
		this.AD011DAA.Text = "Tự động trả lời câu hỏi";
		this.AD011DAA.UseVisualStyleBackColor = true;
		this.AD011DAA.CheckedChanged += new System.EventHandler(BA956D0D);
		this.DC108BB3.Location = new System.Drawing.Point(229, 111);
		this.DC108BB3.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DC108BB3.Name = "nudDelayTo";
		this.DC108BB3.Size = new System.Drawing.Size(56, 23);
		this.DC108BB3.TabIndex = 4;
		this.F03DEC2E.Location = new System.Drawing.Point(132, 111);
		this.F03DEC2E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F03DEC2E.Name = "nudDelayFrom";
		this.F03DEC2E.Size = new System.Drawing.Size(56, 23);
		this.F03DEC2E.TabIndex = 3;
		this.label7.Location = new System.Drawing.Point(194, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 46;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(287, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(31, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(90, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.FE1E2234.Location = new System.Drawing.Point(132, 49);
		this.FE1E2234.Name = "txtTenHanhDong";
		this.FE1E2234.Size = new System.Drawing.Size(194, 23);
		this.FE1E2234.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CB81BB1D.AutoSize = true;
		this.CB81BB1D.Location = new System.Drawing.Point(287, 82);
		this.CB81BB1D.Name = "label4";
		this.CB81BB1D.Size = new System.Drawing.Size(40, 16);
		this.CB81BB1D.TabIndex = 35;
		this.CB81BB1D.Text = "nhóm";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		this.F22496A0.AutoSize = true;
		this.F22496A0.Location = new System.Drawing.Point(27, 52);
		this.F22496A0.Name = "label1";
		this.F22496A0.Size = new System.Drawing.Size(99, 16);
		this.F22496A0.TabIndex = 31;
		this.F22496A0.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(193, 355);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(86, 355);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(FEA9FE91);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.F882901B);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(363, 37);
		this.bunifuCards1.TabIndex = 28;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 0;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 0;
		this.toolTip_0.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(366, 398);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomGoiY";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = " ";
		base.Load += new System.EventHandler(fHDThamGiaNhomGoiY_Load);
		this.F882901B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.EA9298A6).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plTuongTac.ResumeLayout(false);
		this.plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DC108BB3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F03DEC2E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
