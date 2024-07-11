using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDTruyCapWebsite : Form
{
	private JSON_Settings gclass8_0 = null;

	private string string_0;

	private string B4B77604;

	private string string_1;

	private int int_0;

	public static bool AAB96118;

	private IContainer icontainer_0 = null;

	private BunifuDragControl F01A6635;

	private BunifuDragControl bunifuDragControl_0;

	private Panel FFAD1D10;

	private TextBox E09679BB;

	private Label label1;

	private Button E0B14713;

	private Button C731E906;

	private BunifuCards AF99E12F;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D9032628;

	private Label label8;

	private Label lblStatus;

	private RichTextBox txtLinkWeb;

	private NumericUpDown A588453E;

	private NumericUpDown FA277F34;

	private NumericUpDown nudCountLinkClickFrom;

	private NumericUpDown nudCountLinkFrom;

	private Label F6AC5E28;

	private Label label13;

	private Label label16;

	private Label label11;

	private Label label15;

	private Label E79A97AB;

	private CheckBox ckbLuot;

	private NumericUpDown nudCountTimeScrollTo;

	private Label label2;

	private Label label3;

	private Label label4;

	private NumericUpDown F100F535;

	public fHDTruyCapWebsite(string FE984411, int CB89D105 = 0, string string_2 = "")
	{
		InitializeComponent();
		AAB96118 = false;
		string_0 = FE984411;
		string_1 = string_2;
		int_0 = CB89D105;
		if (InteractSQL.B484648C("", "HDTruyCapWebsite").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTruyCapWebsite', 'Truy cập Website');");
		}
		string text = "";
		switch (CB89D105)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTruyCapWebsite");
			B4B77604 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			E09679BB.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			C731E906.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			E09679BB.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(D9032628);
		Language.smethod_0(label1);
		Language.smethod_0(lblStatus);
		Language.smethod_0(label8);
		Language.smethod_0(E79A97AB);
		Language.smethod_0(label13);
		Language.smethod_0(label11);
		Language.smethod_0(label15);
		Language.smethod_0(F6AC5E28);
		Language.smethod_0(label16);
		Language.smethod_0(label2);
		Language.smethod_0(label4);
		Language.smethod_0(label3);
		Language.smethod_0(ckbLuot);
		Language.smethod_0(C731E906);
		Language.smethod_0(E0B14713);
	}

	private void C23064AB(object sender, EventArgs e)
	{
		try
		{
			nudCountLinkFrom.Value = gclass8_0.GetValueInt("nudCountLinkFrom", 1);
			FA277F34.Value = gclass8_0.GetValueInt("nudCountLinkTo", 1);
			nudCountLinkClickFrom.Value = gclass8_0.GetValueInt("nudCountLinkClickFrom", 3);
			A588453E.Value = gclass8_0.GetValueInt("nudCountLinkClickTo", 5);
			F100F535.Value = gclass8_0.GetValueInt("nudCountTimeScrollFrom", 30);
			nudCountTimeScrollTo.Value = gclass8_0.GetValueInt("nudCountTimeScrollTo", 30);
			txtLinkWeb.Text = gclass8_0.GetValue("txtLinkWeb");
			ckbLuot.Checked = gclass8_0.GetValueBool("ckbLuot", bool_0: true);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F22346BF(object sender, EventArgs e)
	{
		string text = E09679BB.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudCountLinkFrom", nudCountLinkFrom.Value);
		gClass.GetJson("nudCountLinkTo", FA277F34.Value);
		gClass.GetJson("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		gClass.GetJson("nudCountLinkClickTo", A588453E.Value);
		gClass.GetJson("nudCountTimeScrollFrom", F100F535.Value);
		gClass.GetJson("nudCountTimeScrollTo", nudCountTimeScrollTo.Value);
		gClass.GetJson("txtLinkWeb", txtLinkWeb.Text.Trim());
		gClass.GetJson("ckbLuot", ckbLuot.Checked);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, B4B77604, string_))
				{
					AAB96118 = true;
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
				AAB96118 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void E0B14713_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AE86249F(object sender, PaintEventArgs e)
	{
		if (FFAD1D10.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FFAD1D10.ClientSize.Width - num, FFAD1D10.ClientSize.Height - num));
		}
	}

	private void txtLinkWeb_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtLinkWeb.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Link Web ({0}):"), a2AB53A.Count.ToString());
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

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTruyCapWebsite));
		this.F01A6635 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D9032628 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.FFAD1D10 = new System.Windows.Forms.Panel();
		this.nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbLuot = new System.Windows.Forms.CheckBox();
		this.label4 = new System.Windows.Forms.Label();
		this.txtLinkWeb = new System.Windows.Forms.RichTextBox();
		this.F100F535 = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.A588453E = new System.Windows.Forms.NumericUpDown();
		this.FA277F34 = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		this.nudCountLinkFrom = new System.Windows.Forms.NumericUpDown();
		this.E09679BB = new System.Windows.Forms.TextBox();
		this.F6AC5E28 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.E79A97AB = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.E0B14713 = new System.Windows.Forms.Button();
		this.C731E906 = new System.Windows.Forms.Button();
		this.AF99E12F = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.FFAD1D10.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F100F535).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A588453E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FA277F34).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkFrom).BeginInit();
		this.AF99E12F.SuspendLayout();
		base.SuspendLayout();
		this.F01A6635.Fixed = true;
		this.F01A6635.Horizontal = true;
		this.F01A6635.TargetControl = this.D9032628;
		this.F01A6635.Vertical = true;
		this.D9032628.BackColor = System.Drawing.Color.Transparent;
		this.D9032628.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D9032628.Dock = System.Windows.Forms.DockStyle.Fill;
		this.D9032628.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D9032628.ForeColor = System.Drawing.Color.Black;
		this.D9032628.Location = new System.Drawing.Point(0, 0);
		this.D9032628.Name = "bunifuCustomLabel1";
		this.D9032628.Size = new System.Drawing.Size(359, 31);
		this.D9032628.TabIndex = 12;
		this.D9032628.Text = "Cấu hình Truy cập Website";
		this.D9032628.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.D9032628);
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
		this.FFAD1D10.BackColor = System.Drawing.Color.White;
		this.FFAD1D10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FFAD1D10.Controls.Add(this.nudCountTimeScrollTo);
		this.FFAD1D10.Controls.Add(this.label2);
		this.FFAD1D10.Controls.Add(this.label3);
		this.FFAD1D10.Controls.Add(this.ckbLuot);
		this.FFAD1D10.Controls.Add(this.label4);
		this.FFAD1D10.Controls.Add(this.txtLinkWeb);
		this.FFAD1D10.Controls.Add(this.F100F535);
		this.FFAD1D10.Controls.Add(this.label8);
		this.FFAD1D10.Controls.Add(this.lblStatus);
		this.FFAD1D10.Controls.Add(this.A588453E);
		this.FFAD1D10.Controls.Add(this.FA277F34);
		this.FFAD1D10.Controls.Add(this.nudCountLinkClickFrom);
		this.FFAD1D10.Controls.Add(this.nudCountLinkFrom);
		this.FFAD1D10.Controls.Add(this.E09679BB);
		this.FFAD1D10.Controls.Add(this.F6AC5E28);
		this.FFAD1D10.Controls.Add(this.label13);
		this.FFAD1D10.Controls.Add(this.label16);
		this.FFAD1D10.Controls.Add(this.label11);
		this.FFAD1D10.Controls.Add(this.label15);
		this.FFAD1D10.Controls.Add(this.E79A97AB);
		this.FFAD1D10.Controls.Add(this.label1);
		this.FFAD1D10.Controls.Add(this.E0B14713);
		this.FFAD1D10.Controls.Add(this.C731E906);
		this.FFAD1D10.Controls.Add(this.AF99E12F);
		this.FFAD1D10.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.FFAD1D10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FFAD1D10.Location = new System.Drawing.Point(0, 0);
		this.FFAD1D10.Name = "panel1";
		this.FFAD1D10.Size = new System.Drawing.Size(362, 419);
		this.FFAD1D10.TabIndex = 0;
		this.FFAD1D10.Paint += new System.Windows.Forms.PaintEventHandler(AE86249F);
		this.nudCountTimeScrollTo.Location = new System.Drawing.Point(263, 316);
		this.nudCountTimeScrollTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
		this.nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 23);
		this.nudCountTimeScrollTo.TabIndex = 2;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(28, 318);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(120, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Thời gian trên web:";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(299, 318);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(30, 16);
		this.label3.TabIndex = 35;
		this.label3.Text = "giây";
		this.ckbLuot.AutoSize = true;
		this.ckbLuot.Checked = true;
		this.ckbLuot.CheckState = System.Windows.Forms.CheckState.Checked;
		this.ckbLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLuot.Location = new System.Drawing.Point(30, 343);
		this.ckbLuot.Name = "ckbLuot";
		this.ckbLuot.Size = new System.Drawing.Size(157, 20);
		this.ckbLuot.TabIndex = 43;
		this.ckbLuot.Text = "Tự động lướt trên Web";
		this.ckbLuot.UseVisualStyleBackColor = true;
		this.label4.Location = new System.Drawing.Point(231, 318);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(29, 16);
		this.label4.TabIndex = 37;
		this.label4.Text = "đê\u0301n";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtLinkWeb.Location = new System.Drawing.Point(30, 94);
		this.txtLinkWeb.Name = "txtLinkWeb";
		this.txtLinkWeb.Size = new System.Drawing.Size(298, 142);
		this.txtLinkWeb.TabIndex = 42;
		this.txtLinkWeb.Text = "";
		this.txtLinkWeb.WordWrap = false;
		this.txtLinkWeb.TextChanged += new System.EventHandler(txtLinkWeb_TextChanged);
		this.F100F535.Location = new System.Drawing.Point(192, 316);
		this.F100F535.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F100F535.Name = "nudCountTimeScrollFrom";
		this.F100F535.Size = new System.Drawing.Size(36, 23);
		this.F100F535.TabIndex = 1;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(28, 239);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(133, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Mỗi nội dung 1 do\u0300ng)";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(27, 75);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(148, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Link Web (0):";
		this.A588453E.Location = new System.Drawing.Point(263, 288);
		this.A588453E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A588453E.Name = "nudCountLinkClickTo";
		this.A588453E.Size = new System.Drawing.Size(36, 23);
		this.A588453E.TabIndex = 2;
		this.FA277F34.Location = new System.Drawing.Point(263, 260);
		this.FA277F34.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FA277F34.Name = "nudCountLinkTo";
		this.FA277F34.Size = new System.Drawing.Size(36, 23);
		this.FA277F34.TabIndex = 2;
		this.nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 288);
		this.nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		this.nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkClickFrom.TabIndex = 1;
		this.nudCountLinkFrom.Location = new System.Drawing.Point(192, 260);
		this.nudCountLinkFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLinkFrom.Name = "nudCountLinkFrom";
		this.nudCountLinkFrom.Size = new System.Drawing.Size(36, 23);
		this.nudCountLinkFrom.TabIndex = 1;
		this.E09679BB.Location = new System.Drawing.Point(134, 49);
		this.E09679BB.Name = "txtTenHanhDong";
		this.E09679BB.Size = new System.Drawing.Size(194, 23);
		this.E09679BB.TabIndex = 0;
		this.F6AC5E28.Location = new System.Drawing.Point(231, 290);
		this.F6AC5E28.Name = "label17";
		this.F6AC5E28.Size = new System.Drawing.Size(29, 16);
		this.F6AC5E28.TabIndex = 37;
		this.F6AC5E28.Text = "đê\u0301n";
		this.F6AC5E28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label13.Location = new System.Drawing.Point(231, 262);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(29, 16);
		this.label13.TabIndex = 37;
		this.label13.Text = "đê\u0301n";
		this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(299, 290);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(26, 16);
		this.label16.TabIndex = 35;
		this.label16.Text = "link";
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(299, 262);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(26, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "link";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(28, 290);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(164, 16);
		this.label15.TabIndex = 34;
		this.label15.Text = "Click random link trên web:";
		this.E79A97AB.AutoSize = true;
		this.E79A97AB.Location = new System.Drawing.Point(27, 262);
		this.E79A97AB.Name = "label9";
		this.E79A97AB.Size = new System.Drawing.Size(152, 16);
		this.E79A97AB.TabIndex = 32;
		this.E79A97AB.Text = "Sô\u0301 link web cần truy cập:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.E0B14713.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.E0B14713.BackColor = System.Drawing.Color.Maroon;
		this.E0B14713.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E0B14713.FlatAppearance.BorderSize = 0;
		this.E0B14713.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E0B14713.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E0B14713.ForeColor = System.Drawing.Color.White;
		this.E0B14713.Location = new System.Drawing.Point(189, 375);
		this.E0B14713.Name = "btnCancel";
		this.E0B14713.Size = new System.Drawing.Size(92, 29);
		this.E0B14713.TabIndex = 10;
		this.E0B14713.Text = "Đóng";
		this.E0B14713.UseVisualStyleBackColor = false;
		this.E0B14713.Click += new System.EventHandler(E0B14713_Click);
		this.C731E906.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.C731E906.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C731E906.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C731E906.FlatAppearance.BorderSize = 0;
		this.C731E906.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C731E906.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C731E906.ForeColor = System.Drawing.Color.White;
		this.C731E906.Location = new System.Drawing.Point(82, 375);
		this.C731E906.Name = "btnAdd";
		this.C731E906.Size = new System.Drawing.Size(92, 29);
		this.C731E906.TabIndex = 9;
		this.C731E906.Text = "Thêm";
		this.C731E906.UseVisualStyleBackColor = false;
		this.C731E906.Click += new System.EventHandler(F22346BF);
		this.AF99E12F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.AF99E12F.BackColor = System.Drawing.Color.White;
		this.AF99E12F.BorderRadius = 0;
		this.AF99E12F.BottomSahddow = true;
		this.AF99E12F.color = System.Drawing.Color.DarkViolet;
		this.AF99E12F.Controls.Add(this.pnlHeader);
		this.AF99E12F.LeftSahddow = false;
		this.AF99E12F.Location = new System.Drawing.Point(1, 0);
		this.AF99E12F.Name = "bunifuCards1";
		this.AF99E12F.RightSahddow = true;
		this.AF99E12F.ShadowDepth = 20;
		this.AF99E12F.Size = new System.Drawing.Size(359, 37);
		this.AF99E12F.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 419);
		base.Controls.Add(this.FFAD1D10);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTruyCapWebsite";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C23064AB);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.FFAD1D10.ResumeLayout(false);
		this.FFAD1D10.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountTimeScrollTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F100F535).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A588453E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FA277F34).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLinkFrom).EndInit();
		this.AF99E12F.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
