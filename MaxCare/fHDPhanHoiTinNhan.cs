using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDPhanHoiTinNhan : Form
{
	private JObject A0B4190A;

	private string E29AF702;

	private string A3A22C39;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label B43F8B95;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards E439E8B0;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel BD23E99D;

	private Label F9AF663B;

	private Label FF34ADA5;

	private TextBox txtTinNhan;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label DEAE8E0C;

	private Button button2;

	private LinkLabel BC27DE31;

	public fHDPhanHoiTinNhan(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E29AF702 = string_1;
		string_0 = string_2;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDPhanHoiTinNhan");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			A3A22C39 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A0B4190A = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void F6389FB8()
	{
		Language.smethod_0(BD23E99D);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(B43F8B95);
		Language.smethod_0(label4);
		Language.smethod_0(DEAE8E0C);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(FF34ADA5);
		Language.smethod_0(F9AF663B);
		Language.smethod_0(button2);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void C5A8BC29(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(A0B4190A["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(A0B4190A["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(A0B4190A["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(A0B4190A["nudDelayTo"]);
			txtTinNhan.Text = A0B4190A["txtTinNhan"].ToString();
		}
		catch
		{
		}
	}

	private void A22D6D86(object sender, EventArgs e)
	{
		Close();
	}

	private void BB0516A7(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtTinNhan.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtTinNhan", txtTinNhan.Text.Trim());
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E29AF702, text, A3A22C39, text2))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void D81CA5AA(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtTinNhan.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			FF34ADA5.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void F2BC1C2B(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người nhận!");
	}

	private void C00BDFAE(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDPhanHoiTinNhan));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.BD23E99D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.BC27DE31 = new System.Windows.Forms.LinkLabel();
		this.button2 = new System.Windows.Forms.Button();
		this.txtTinNhan = new System.Windows.Forms.TextBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.F9AF663B = new System.Windows.Forms.Label();
		this.FF34ADA5 = new System.Windows.Forms.Label();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.DEAE8E0C = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.B43F8B95 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.E439E8B0 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.E439E8B0.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.BD23E99D;
		this.bunifuDragControl_0.Vertical = true;
		this.BD23E99D.BackColor = System.Drawing.Color.Transparent;
		this.BD23E99D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.BD23E99D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BD23E99D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BD23E99D.ForeColor = System.Drawing.Color.Black;
		this.BD23E99D.Location = new System.Drawing.Point(0, 0);
		this.BD23E99D.Name = "bunifuCustomLabel1";
		this.BD23E99D.Size = new System.Drawing.Size(359, 31);
		this.BD23E99D.TabIndex = 12;
		this.BD23E99D.Text = "Cấu hình Pha\u0309n hô\u0300i tin nhă\u0301n";
		this.BD23E99D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.BD23E99D);
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
		this.button1.Click += new System.EventHandler(A22D6D86);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.BC27DE31);
		this.panel1.Controls.Add(this.button2);
		this.panel1.Controls.Add(this.txtTinNhan);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.F9AF663B);
		this.panel1.Controls.Add(this.FF34ADA5);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.DEAE8E0C);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.B43F8B95);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.E439E8B0);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 385);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.BC27DE31.AutoSize = true;
		this.BC27DE31.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BC27DE31.Location = new System.Drawing.Point(220, 305);
		this.BC27DE31.Name = "linkLabel1";
		this.BC27DE31.Size = new System.Drawing.Size(81, 16);
		this.BC27DE31.TabIndex = 189;
		this.BC27DE31.TabStop = true;
		this.BC27DE31.Text = "Random icon";
		this.BC27DE31.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C00BDFAE);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(304, 302);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(23, 23);
		this.button2.TabIndex = 94;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(F2BC1C2B);
		this.txtTinNhan.Location = new System.Drawing.Point(31, 164);
		this.txtTinNhan.Multiline = true;
		this.txtTinNhan.Name = "txtTinNhan";
		this.txtTinNhan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtTinNhan.Size = new System.Drawing.Size(295, 138);
		this.txtTinNhan.TabIndex = 5;
		this.txtTinNhan.WordWrap = false;
		this.txtTinNhan.TextChanged += new System.EventHandler(D81CA5AA);
		this.nudDelayTo.Location = new System.Drawing.Point(229, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.F9AF663B.AutoSize = true;
		this.F9AF663B.Location = new System.Drawing.Point(28, 305);
		this.F9AF663B.Name = "label8";
		this.F9AF663B.Size = new System.Drawing.Size(143, 16);
		this.F9AF663B.TabIndex = 0;
		this.F9AF663B.Text = "(Spin nội dung {a|b|c})";
		this.FF34ADA5.AutoSize = true;
		this.FF34ADA5.Location = new System.Drawing.Point(27, 142);
		this.FF34ADA5.Name = "lblStatus";
		this.FF34ADA5.Size = new System.Drawing.Size(142, 16);
		this.FF34ADA5.TabIndex = 0;
		this.FF34ADA5.Text = "Danh sa\u0301ch tin nhă\u0301n (0):";
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
		this.DEAE8E0C.AutoSize = true;
		this.DEAE8E0C.Location = new System.Drawing.Point(27, 113);
		this.DEAE8E0C.Name = "label5";
		this.DEAE8E0C.Size = new System.Drawing.Size(89, 16);
		this.DEAE8E0C.TabIndex = 44;
		this.DEAE8E0C.Text = "Thơ\u0300i gian chơ\u0300:";
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
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.B43F8B95.Location = new System.Drawing.Point(194, 82);
		this.B43F8B95.Name = "label3";
		this.B43F8B95.Size = new System.Drawing.Size(29, 16);
		this.B43F8B95.TabIndex = 37;
		this.B43F8B95.Text = "đê\u0301n";
		this.B43F8B95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(185, 336);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(78, 336);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(BB0516A7);
		this.E439E8B0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E439E8B0.BackColor = System.Drawing.Color.White;
		this.E439E8B0.BorderRadius = 0;
		this.E439E8B0.BottomSahddow = true;
		this.E439E8B0.color = System.Drawing.Color.DarkViolet;
		this.E439E8B0.Controls.Add(this.pnlHeader);
		this.E439E8B0.LeftSahddow = false;
		this.E439E8B0.Location = new System.Drawing.Point(1, 0);
		this.E439E8B0.Name = "bunifuCards1";
		this.E439E8B0.RightSahddow = true;
		this.E439E8B0.ShadowDepth = 20;
		this.E439E8B0.Size = new System.Drawing.Size(359, 37);
		this.E439E8B0.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 385);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDPhanHoiTinNhan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C5A8BC29);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.E439E8B0.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
