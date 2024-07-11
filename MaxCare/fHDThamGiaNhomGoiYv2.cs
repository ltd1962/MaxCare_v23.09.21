using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDThamGiaNhomGoiYv2 : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string B1291906;

	private int E7255338;

	public static bool C20E959F;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel BA8AD2AA;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox F2B7308A;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label C8BBD80D;

	private Button D7346037;

	private Button btnAdd;

	private BunifuCards E5187F0E;

	private Panel D72E8808;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel EF9B3B3E;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private ToolTip FE8F752B;

	private Panel plTuongTac;

	private CheckBox F6AD8EAF;

	private TextBox txtCauTraLoi;

	private Label label9;

	private Label lblStatusComment;

	public fHDThamGiaNhomGoiYv2(string string_2, int A3311EAE = 0, string C8303807 = "")
	{
		InitializeComponent();
		C20E959F = false;
		string_0 = string_2;
		B1291906 = C8303807;
		E7255338 = A3311EAE;
		if (InteractSQL.B484648C("", "HDThamGiaNhomGoiYv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomGoiYv2', 'Tham gia nhóm gợi ý v2');");
		}
		string text = "";
		switch (A3311EAE)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDThamGiaNhomGoiYv2");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F2B7308A.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(C8303807);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F2B7308A.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(EF9B3B3E);
		Language.smethod_0(C8BBD80D);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(F6AD8EAF);
		Language.smethod_0(lblStatusComment);
		Language.smethod_0(label9);
		Language.smethod_0(btnAdd);
		Language.smethod_0(D7346037);
	}

	private void fHDThamGiaNhomGoiYv2_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 5);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			F6AD8EAF.Checked = gclass8_0.GetValueBool("ckbTuDongTraLoiCauHoi");
			txtCauTraLoi.Text = gclass8_0.GetValue("txtCauTraLoi");
		}
		catch
		{
		}
		method_1();
	}

	private void method_1()
	{
		AB196396(null, null);
	}

	private void BBA6F420(object sender, EventArgs e)
	{
		Close();
	}

	private void AA887037(object sender, EventArgs e)
	{
		string text = F2B7308A.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (F6AD8EAF.Checked)
		{
			List<string> a2AB53A = txtCauTraLoi.Lines.ToList();
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
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbTuDongTraLoiCauHoi", F6AD8EAF.Checked);
		gClass.GetJson("txtCauTraLoi", txtCauTraLoi.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (E7255338 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					C20E959F = true;
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
			if (InteractSQL.smethod_13(B1291906, text, string_))
			{
				C20E959F = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D7346037_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BA8AD2AA_Paint(object sender, PaintEventArgs e)
	{
		if (BA8AD2AA.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BA8AD2AA.ClientSize.Width - num, BA8AD2AA.ClientSize.Height - num));
		}
	}

	private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtCauTraLoi.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatusComment.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void AB196396(object sender, EventArgs e)
	{
		plTuongTac.Enabled = F6AD8EAF.Checked;
	}

	protected override void Dispose(bool F938F62E)
	{
		if (F938F62E && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F938F62E);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.EF9B3B3E = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D72E8808 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.BA8AD2AA = new System.Windows.Forms.Panel();
		this.plTuongTac = new System.Windows.Forms.Panel();
		this.txtCauTraLoi = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.lblStatusComment = new System.Windows.Forms.Label();
		this.F6AD8EAF = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.F2B7308A = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.C8BBD80D = new System.Windows.Forms.Label();
		this.D7346037 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.E5187F0E = new Bunifu.Framework.UI.BunifuCards();
		this.FE8F752B = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.D72E8808.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.BA8AD2AA.SuspendLayout();
		this.plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.E5187F0E.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.EF9B3B3E;
		this.bunifuDragControl_0.Vertical = true;
		this.EF9B3B3E.BackColor = System.Drawing.Color.Transparent;
		this.EF9B3B3E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.EF9B3B3E.Dock = System.Windows.Forms.DockStyle.Fill;
		this.EF9B3B3E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EF9B3B3E.ForeColor = System.Drawing.Color.Black;
		this.EF9B3B3E.Location = new System.Drawing.Point(0, 0);
		this.EF9B3B3E.Name = "bunifuCustomLabel1";
		this.EF9B3B3E.Size = new System.Drawing.Size(363, 31);
		this.EF9B3B3E.TabIndex = 12;
		this.EF9B3B3E.Text = "Cấu hình Tham gia nhóm gợi ý v2";
		this.EF9B3B3E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.D72E8808;
		this.bunifuDragControl_1.Vertical = true;
		this.D72E8808.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D72E8808.BackColor = System.Drawing.Color.White;
		this.D72E8808.Controls.Add(this.button1);
		this.D72E8808.Controls.Add(this.pictureBox1);
		this.D72E8808.Controls.Add(this.EF9B3B3E);
		this.D72E8808.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D72E8808.Location = new System.Drawing.Point(0, 3);
		this.D72E8808.Name = "pnlHeader";
		this.D72E8808.Size = new System.Drawing.Size(363, 31);
		this.D72E8808.TabIndex = 9;
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
		this.button1.Click += new System.EventHandler(BBA6F420);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.BA8AD2AA.BackColor = System.Drawing.Color.White;
		this.BA8AD2AA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BA8AD2AA.Controls.Add(this.plTuongTac);
		this.BA8AD2AA.Controls.Add(this.F6AD8EAF);
		this.BA8AD2AA.Controls.Add(this.nudDelayTo);
		this.BA8AD2AA.Controls.Add(this.nudDelayFrom);
		this.BA8AD2AA.Controls.Add(this.label7);
		this.BA8AD2AA.Controls.Add(this.label6);
		this.BA8AD2AA.Controls.Add(this.label5);
		this.BA8AD2AA.Controls.Add(this.nudSoLuongTo);
		this.BA8AD2AA.Controls.Add(this.nudSoLuongFrom);
		this.BA8AD2AA.Controls.Add(this.F2B7308A);
		this.BA8AD2AA.Controls.Add(this.label3);
		this.BA8AD2AA.Controls.Add(this.label4);
		this.BA8AD2AA.Controls.Add(this.label2);
		this.BA8AD2AA.Controls.Add(this.C8BBD80D);
		this.BA8AD2AA.Controls.Add(this.D7346037);
		this.BA8AD2AA.Controls.Add(this.btnAdd);
		this.BA8AD2AA.Controls.Add(this.E5187F0E);
		this.BA8AD2AA.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.BA8AD2AA.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BA8AD2AA.Location = new System.Drawing.Point(0, 0);
		this.BA8AD2AA.Name = "panel1";
		this.BA8AD2AA.Size = new System.Drawing.Size(366, 398);
		this.BA8AD2AA.TabIndex = 0;
		this.BA8AD2AA.Paint += new System.Windows.Forms.PaintEventHandler(BA8AD2AA_Paint);
		this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTac.Controls.Add(this.txtCauTraLoi);
		this.plTuongTac.Controls.Add(this.label9);
		this.plTuongTac.Controls.Add(this.lblStatusComment);
		this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTac.Location = new System.Drawing.Point(48, 162);
		this.plTuongTac.Name = "plTuongTac";
		this.plTuongTac.Size = new System.Drawing.Size(278, 179);
		this.plTuongTac.TabIndex = 116;
		this.txtCauTraLoi.Location = new System.Drawing.Point(6, 25);
		this.txtCauTraLoi.Multiline = true;
		this.txtCauTraLoi.Name = "txtCauTraLoi";
		this.txtCauTraLoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtCauTraLoi.Size = new System.Drawing.Size(265, 128);
		this.txtCauTraLoi.TabIndex = 1;
		this.txtCauTraLoi.WordWrap = false;
		this.txtCauTraLoi.TextChanged += new System.EventHandler(txtCauTraLoi_TextChanged);
		this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(3, 158);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(134, 16);
		this.label9.TabIndex = 0;
		this.label9.Text = "(Mỗi nội dung 1 dòng)";
		this.lblStatusComment.AutoSize = true;
		this.lblStatusComment.Location = new System.Drawing.Point(3, 4);
		this.lblStatusComment.Name = "lblStatusComment";
		this.lblStatusComment.Size = new System.Drawing.Size(154, 16);
		this.lblStatusComment.TabIndex = 0;
		this.lblStatusComment.Text = "Danh sách câu trả lời (0):";
		this.F6AD8EAF.AutoSize = true;
		this.F6AD8EAF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F6AD8EAF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.F6AD8EAF.Location = new System.Drawing.Point(30, 139);
		this.F6AD8EAF.Name = "ckbTuDongTraLoiCauHoi";
		this.F6AD8EAF.Size = new System.Drawing.Size(157, 20);
		this.F6AD8EAF.TabIndex = 115;
		this.F6AD8EAF.Text = "Tự động trả lời câu hỏi";
		this.F6AD8EAF.UseVisualStyleBackColor = true;
		this.F6AD8EAF.CheckedChanged += new System.EventHandler(AB196396);
		this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
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
		this.F2B7308A.Location = new System.Drawing.Point(132, 49);
		this.F2B7308A.Name = "txtTenHanhDong";
		this.F2B7308A.Size = new System.Drawing.Size(194, 23);
		this.F2B7308A.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(287, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(40, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "nhóm";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		this.C8BBD80D.AutoSize = true;
		this.C8BBD80D.Location = new System.Drawing.Point(27, 52);
		this.C8BBD80D.Name = "label1";
		this.C8BBD80D.Size = new System.Drawing.Size(99, 16);
		this.C8BBD80D.TabIndex = 31;
		this.C8BBD80D.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.D7346037.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D7346037.BackColor = System.Drawing.Color.Maroon;
		this.D7346037.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D7346037.FlatAppearance.BorderSize = 0;
		this.D7346037.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D7346037.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D7346037.ForeColor = System.Drawing.Color.White;
		this.D7346037.Location = new System.Drawing.Point(193, 355);
		this.D7346037.Name = "btnCancel";
		this.D7346037.Size = new System.Drawing.Size(92, 29);
		this.D7346037.TabIndex = 7;
		this.D7346037.Text = "Đóng";
		this.D7346037.UseVisualStyleBackColor = false;
		this.D7346037.Click += new System.EventHandler(D7346037_Click);
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
		this.btnAdd.Click += new System.EventHandler(AA887037);
		this.E5187F0E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E5187F0E.BackColor = System.Drawing.Color.White;
		this.E5187F0E.BorderRadius = 0;
		this.E5187F0E.BottomSahddow = true;
		this.E5187F0E.color = System.Drawing.Color.DarkViolet;
		this.E5187F0E.Controls.Add(this.D72E8808);
		this.E5187F0E.LeftSahddow = false;
		this.E5187F0E.Location = new System.Drawing.Point(1, 0);
		this.E5187F0E.Name = "bunifuCards1";
		this.E5187F0E.RightSahddow = true;
		this.E5187F0E.ShadowDepth = 20;
		this.E5187F0E.Size = new System.Drawing.Size(363, 37);
		this.E5187F0E.TabIndex = 28;
		this.FE8F752B.AutomaticDelay = 0;
		this.FE8F752B.AutoPopDelay = 0;
		this.FE8F752B.InitialDelay = 0;
		this.FE8F752B.ReshowDelay = 0;
		this.FE8F752B.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(366, 398);
		base.Controls.Add(this.BA8AD2AA);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomGoiYv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDThamGiaNhomGoiYv2_Load);
		this.D72E8808.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.BA8AD2AA.ResumeLayout(false);
		this.BA8AD2AA.PerformLayout();
		this.plTuongTac.ResumeLayout(false);
		this.plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.E5187F0E.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
