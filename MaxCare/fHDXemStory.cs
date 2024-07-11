using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDXemStory : Form
{
	private JObject EE09641C;

	private string string_0;

	private string D8245411;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer C022A889 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown C535540A;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown D417BB2F;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label B11302BD;

	private Label E1AED22A;

	private Label label6;

	private Label label4;

	private Label D3A0EE07;

	private Label label2;

	private Label A6018B08;

	private Button B90E2300;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel AF26B914;

	private Panel EB25403F;

	private Label A397AA92;

	private Panel plInteract;

	private Label label25;

	private Label D9B8AA3D;

	private Label EF0C9821;

	private Label C3A7CC84;

	private Label label29;

	private Label D4252BAE;

	private CheckBox ckbGian;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox F58ED09B;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox C23D0493;

	private Label D287280D;

	private CheckBox FAA0163B;

	private CheckBox D93FD71E;

	private TextBox txtComment;

	private Button BAB081A2;

	private Label label8;

	public fHDXemStory(string string_2, int A81ADC31 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		int_0 = A81ADC31;
		string json = "";
		switch (A81ADC31)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXemStory");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			D8245411 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		EE09641C = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(AF26B914);
		Language.smethod_0(A6018B08);
		Language.smethod_0(label2);
		Language.smethod_0(E1AED22A);
		Language.smethod_0(label4);
		Language.smethod_0(D3A0EE07);
		Language.smethod_0(B11302BD);
		Language.smethod_0(label6);
		Language.smethod_0(D93FD71E);
		Language.smethod_0(D9B8AA3D);
		Language.smethod_0(EF0C9821);
		Language.smethod_0(D4252BAE);
		Language.smethod_0(D287280D);
		Language.smethod_0(FAA0163B);
		Language.smethod_0(A397AA92);
		Language.smethod_0(BAB081A2);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(B90E2300);
	}

	private void A91DB42A(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(EE09641C["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(EE09641C["nudSoLuongTo"]);
			D417BB2F.Value = Convert.ToInt32(EE09641C["nudDelayFrom"]);
			C535540A.Value = Convert.ToInt32(EE09641C["nudDelayTo"]);
			D93FD71E.Checked = Convert.ToBoolean(EE09641C["ckbInteract"]);
			string text = EE09641C["typeReaction"].ToString();
			List<CheckBox> list = new List<CheckBox> { C23D0493, ckbTym, ckbThuong, F58ED09B, ckbWow, ckbBuon, ckbGian };
			for (int i = 0; i < list.Count; i++)
			{
				if (text.Contains(i.ToString()))
				{
					list[i].Checked = true;
				}
			}
			FAA0163B.Checked = Convert.ToBoolean(EE09641C["ckbComment"]);
			txtComment.Text = EE09641C["txtComment"].ToString();
		}
		catch
		{
		}
		method_1();
	}

	private void BA1E849E(object sender, EventArgs e)
	{
		Close();
	}

	private void F426D93F(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (FAA0163B.Checked)
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", D417BB2F.Value);
		gClass.GetJson("nudDelayTo", C535540A.Value);
		gClass.GetJson("ckbInteract", D93FD71E.Checked);
		string text2 = "";
		List<CheckBox> list = new List<CheckBox> { C23D0493, ckbTym, ckbThuong, F58ED09B, ckbWow, ckbBuon, ckbGian };
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Checked)
			{
				text2 += i;
			}
		}
		gClass.GetJson("typeReaction", text2);
		gClass.GetJson("ckbComment", FAA0163B.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, D8245411, string_))
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

	private void F21D0F35(object sender, EventArgs e)
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

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			A397AA92.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		D93FD71E_CheckedChanged(null, null);
		FAA0163B_CheckedChanged(null, null);
	}

	private void D93FD71E_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = D93FD71E.Checked;
	}

	private void FAA0163B_CheckedChanged(object sender, EventArgs e)
	{
		EB25403F.Enabled = FAA0163B.Checked;
	}

	private void label25_Click(object sender, EventArgs e)
	{
		C23D0493.Checked = !C23D0493.Checked;
	}

	private void D9B8AA3D_Click(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void EF0C9821_Click(object sender, EventArgs e)
	{
		ckbThuong.Checked = !ckbThuong.Checked;
	}

	private void A92F6C00(object sender, EventArgs e)
	{
		F58ED09B.Checked = !F58ED09B.Checked;
	}

	private void E70CC70D(object sender, EventArgs e)
	{
		ckbWow.Checked = !ckbWow.Checked;
	}

	private void D4252BAE_Click(object sender, EventArgs e)
	{
		ckbBuon.Checked = !ckbBuon.Checked;
	}

	private void BB3F4C00(object sender, EventArgs e)
	{
		ckbGian.Checked = !ckbGian.Checked;
	}

	private void E0152A93(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng story!");
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && C022A889 != null)
		{
			C022A889.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.C022A889 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemStory));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.C022A889);
		this.AF26B914 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.C022A889);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.EB25403F = new System.Windows.Forms.Panel();
		this.BAB081A2 = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.TextBox();
		this.A397AA92 = new System.Windows.Forms.Label();
		this.plInteract = new System.Windows.Forms.Panel();
		this.label25 = new System.Windows.Forms.Label();
		this.D9B8AA3D = new System.Windows.Forms.Label();
		this.EF0C9821 = new System.Windows.Forms.Label();
		this.C3A7CC84 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.D4252BAE = new System.Windows.Forms.Label();
		this.ckbGian = new System.Windows.Forms.CheckBox();
		this.ckbBuon = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.F58ED09B = new System.Windows.Forms.CheckBox();
		this.ckbThuong = new System.Windows.Forms.CheckBox();
		this.ckbTym = new System.Windows.Forms.CheckBox();
		this.C23D0493 = new System.Windows.Forms.CheckBox();
		this.D287280D = new System.Windows.Forms.Label();
		this.FAA0163B = new System.Windows.Forms.CheckBox();
		this.D93FD71E = new System.Windows.Forms.CheckBox();
		this.C535540A = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.D417BB2F = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.B11302BD = new System.Windows.Forms.Label();
		this.E1AED22A = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.D3A0EE07 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.A6018B08 = new System.Windows.Forms.Label();
		this.B90E2300 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.EB25403F.SuspendLayout();
		this.plInteract.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.C535540A).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D417BB2F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.AF26B914;
		this.bunifuDragControl_0.Vertical = true;
		this.AF26B914.BackColor = System.Drawing.Color.Transparent;
		this.AF26B914.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.AF26B914.Dock = System.Windows.Forms.DockStyle.Fill;
		this.AF26B914.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AF26B914.ForeColor = System.Drawing.Color.Black;
		this.AF26B914.Location = new System.Drawing.Point(0, 0);
		this.AF26B914.Name = "bunifuCustomLabel1";
		this.AF26B914.Size = new System.Drawing.Size(359, 31);
		this.AF26B914.TabIndex = 12;
		this.AF26B914.Text = "Cấu hình Xem Story";
		this.AF26B914.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.AF26B914);
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
		this.button1.Click += new System.EventHandler(BA1E849E);
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
		this.panel1.Controls.Add(this.EB25403F);
		this.panel1.Controls.Add(this.plInteract);
		this.panel1.Controls.Add(this.FAA0163B);
		this.panel1.Controls.Add(this.D93FD71E);
		this.panel1.Controls.Add(this.C535540A);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.D417BB2F);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.B11302BD);
		this.panel1.Controls.Add(this.E1AED22A);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.D3A0EE07);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.A6018B08);
		this.panel1.Controls.Add(this.B90E2300);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 447);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.EB25403F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.EB25403F.Controls.Add(this.BAB081A2);
		this.EB25403F.Controls.Add(this.label8);
		this.EB25403F.Controls.Add(this.txtComment);
		this.EB25403F.Controls.Add(this.A397AA92);
		this.EB25403F.Location = new System.Drawing.Point(48, 234);
		this.EB25403F.Name = "plComment";
		this.EB25403F.Size = new System.Drawing.Size(278, 164);
		this.EB25403F.TabIndex = 8;
		this.BAB081A2.Cursor = System.Windows.Forms.Cursors.Help;
		this.BAB081A2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BAB081A2.Location = new System.Drawing.Point(246, 2);
		this.BAB081A2.Name = "button2";
		this.BAB081A2.Size = new System.Drawing.Size(23, 23);
		this.BAB081A2.TabIndex = 3;
		this.BAB081A2.Text = "?";
		this.BAB081A2.UseVisualStyleBackColor = true;
		this.BAB081A2.Click += new System.EventHandler(E0152A93);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(3, 141);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(265, 16);
		this.label8.TabIndex = 2;
		this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Multiline = true;
		this.txtComment.Name = "txtComment";
		this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtComment.Size = new System.Drawing.Size(261, 111);
		this.txtComment.TabIndex = 1;
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.A397AA92.AutoSize = true;
		this.A397AA92.Location = new System.Drawing.Point(3, 5);
		this.A397AA92.Name = "lblStatus";
		this.A397AA92.Size = new System.Drawing.Size(139, 16);
		this.A397AA92.TabIndex = 0;
		this.A397AA92.Text = "Nội dung bình luận (0):";
		this.plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plInteract.Controls.Add(this.label25);
		this.plInteract.Controls.Add(this.D9B8AA3D);
		this.plInteract.Controls.Add(this.EF0C9821);
		this.plInteract.Controls.Add(this.C3A7CC84);
		this.plInteract.Controls.Add(this.label29);
		this.plInteract.Controls.Add(this.D4252BAE);
		this.plInteract.Controls.Add(this.ckbGian);
		this.plInteract.Controls.Add(this.ckbBuon);
		this.plInteract.Controls.Add(this.ckbWow);
		this.plInteract.Controls.Add(this.F58ED09B);
		this.plInteract.Controls.Add(this.ckbThuong);
		this.plInteract.Controls.Add(this.ckbTym);
		this.plInteract.Controls.Add(this.C23D0493);
		this.plInteract.Controls.Add(this.D287280D);
		this.plInteract.Location = new System.Drawing.Point(48, 165);
		this.plInteract.Name = "plInteract";
		this.plInteract.Size = new System.Drawing.Size(278, 40);
		this.plInteract.TabIndex = 6;
		this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label25.Location = new System.Drawing.Point(4, 1);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(30, 16);
		this.label25.TabIndex = 0;
		this.label25.Text = "Like";
		this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.Click += new System.EventHandler(label25_Click);
		this.D9B8AA3D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D9B8AA3D.Location = new System.Drawing.Point(40, 1);
		this.D9B8AA3D.Name = "label26";
		this.D9B8AA3D.Size = new System.Drawing.Size(33, 16);
		this.D9B8AA3D.TabIndex = 2;
		this.D9B8AA3D.Text = "Tym";
		this.D9B8AA3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D9B8AA3D.Click += new System.EventHandler(D9B8AA3D_Click);
		this.EF0C9821.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EF0C9821.Location = new System.Drawing.Point(75, 1);
		this.EF0C9821.Name = "label27";
		this.EF0C9821.Size = new System.Drawing.Size(52, 16);
		this.EF0C9821.TabIndex = 4;
		this.EF0C9821.Text = "Thương";
		this.EF0C9821.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.EF0C9821.Click += new System.EventHandler(EF0C9821_Click);
		this.C3A7CC84.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C3A7CC84.Location = new System.Drawing.Point(128, 1);
		this.C3A7CC84.Name = "label28";
		this.C3A7CC84.Size = new System.Drawing.Size(37, 16);
		this.C3A7CC84.TabIndex = 6;
		this.C3A7CC84.Text = "Haha";
		this.C3A7CC84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C3A7CC84.Click += new System.EventHandler(A92F6C00);
		this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label29.Location = new System.Drawing.Point(167, 1);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(37, 16);
		this.label29.TabIndex = 8;
		this.label29.Text = "Wow";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label29.Click += new System.EventHandler(E70CC70D);
		this.D4252BAE.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D4252BAE.Location = new System.Drawing.Point(206, 1);
		this.D4252BAE.Name = "label30";
		this.D4252BAE.Size = new System.Drawing.Size(36, 16);
		this.D4252BAE.TabIndex = 10;
		this.D4252BAE.Text = "Buồn";
		this.D4252BAE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D4252BAE.Click += new System.EventHandler(D4252BAE_Click);
		this.ckbGian.AutoSize = true;
		this.ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGian.Location = new System.Drawing.Point(252, 20);
		this.ckbGian.Name = "ckbGian";
		this.ckbGian.Size = new System.Drawing.Size(15, 14);
		this.ckbGian.TabIndex = 13;
		this.ckbGian.UseVisualStyleBackColor = true;
		this.ckbBuon.AutoSize = true;
		this.ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBuon.Location = new System.Drawing.Point(218, 20);
		this.ckbBuon.Name = "ckbBuon";
		this.ckbBuon.Size = new System.Drawing.Size(15, 14);
		this.ckbBuon.TabIndex = 11;
		this.ckbBuon.UseVisualStyleBackColor = true;
		this.ckbWow.AutoSize = true;
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Location = new System.Drawing.Point(179, 20);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(15, 14);
		this.ckbWow.TabIndex = 9;
		this.ckbWow.UseVisualStyleBackColor = true;
		this.F58ED09B.AutoSize = true;
		this.F58ED09B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F58ED09B.Location = new System.Drawing.Point(139, 20);
		this.F58ED09B.Name = "ckbHaha";
		this.F58ED09B.Size = new System.Drawing.Size(15, 14);
		this.F58ED09B.TabIndex = 7;
		this.F58ED09B.UseVisualStyleBackColor = true;
		this.ckbThuong.AutoSize = true;
		this.ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThuong.Location = new System.Drawing.Point(94, 20);
		this.ckbThuong.Name = "ckbThuong";
		this.ckbThuong.Size = new System.Drawing.Size(15, 14);
		this.ckbThuong.TabIndex = 5;
		this.ckbThuong.UseVisualStyleBackColor = true;
		this.ckbTym.AutoSize = true;
		this.ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTym.Location = new System.Drawing.Point(48, 20);
		this.ckbTym.Name = "ckbTym";
		this.ckbTym.Size = new System.Drawing.Size(15, 14);
		this.ckbTym.TabIndex = 3;
		this.ckbTym.UseVisualStyleBackColor = true;
		this.C23D0493.AutoSize = true;
		this.C23D0493.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C23D0493.Location = new System.Drawing.Point(11, 20);
		this.C23D0493.Name = "ckbLike";
		this.C23D0493.Size = new System.Drawing.Size(15, 14);
		this.C23D0493.TabIndex = 1;
		this.C23D0493.UseVisualStyleBackColor = true;
		this.D287280D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D287280D.Location = new System.Drawing.Point(242, 1);
		this.D287280D.Name = "label32";
		this.D287280D.Size = new System.Drawing.Size(33, 16);
		this.D287280D.TabIndex = 12;
		this.D287280D.Text = "Giận";
		this.D287280D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D287280D.Click += new System.EventHandler(BB3F4C00);
		this.FAA0163B.AutoSize = true;
		this.FAA0163B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FAA0163B.Location = new System.Drawing.Point(30, 209);
		this.FAA0163B.Name = "ckbComment";
		this.FAA0163B.Size = new System.Drawing.Size(130, 20);
		this.FAA0163B.TabIndex = 7;
		this.FAA0163B.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		this.FAA0163B.UseVisualStyleBackColor = true;
		this.FAA0163B.CheckedChanged += new System.EventHandler(FAA0163B_CheckedChanged);
		this.D93FD71E.AutoSize = true;
		this.D93FD71E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D93FD71E.Location = new System.Drawing.Point(30, 141);
		this.D93FD71E.Name = "ckbInteract";
		this.D93FD71E.Size = new System.Drawing.Size(112, 20);
		this.D93FD71E.TabIndex = 5;
		this.D93FD71E.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		this.D93FD71E.UseVisualStyleBackColor = true;
		this.D93FD71E.CheckedChanged += new System.EventHandler(D93FD71E_CheckedChanged);
		this.C535540A.Location = new System.Drawing.Point(229, 111);
		this.C535540A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C535540A.Name = "nudDelayTo";
		this.C535540A.Size = new System.Drawing.Size(56, 23);
		this.C535540A.TabIndex = 4;
		this.nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.D417BB2F.Location = new System.Drawing.Point(132, 111);
		this.D417BB2F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D417BB2F.Name = "nudDelayFrom";
		this.D417BB2F.Size = new System.Drawing.Size(56, 23);
		this.D417BB2F.TabIndex = 3;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.B11302BD.Location = new System.Drawing.Point(194, 113);
		this.B11302BD.Name = "label7";
		this.B11302BD.Size = new System.Drawing.Size(29, 16);
		this.B11302BD.TabIndex = 38;
		this.B11302BD.Text = "đê\u0301n";
		this.B11302BD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E1AED22A.Location = new System.Drawing.Point(194, 82);
		this.E1AED22A.Name = "label3";
		this.E1AED22A.Size = new System.Drawing.Size(29, 16);
		this.E1AED22A.TabIndex = 37;
		this.E1AED22A.Text = "đê\u0301n";
		this.E1AED22A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(35, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "story";
		this.D3A0EE07.AutoSize = true;
		this.D3A0EE07.Location = new System.Drawing.Point(27, 113);
		this.D3A0EE07.Name = "label5";
		this.D3A0EE07.Size = new System.Drawing.Size(89, 16);
		this.D3A0EE07.TabIndex = 34;
		this.D3A0EE07.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(95, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng story:";
		this.A6018B08.AutoSize = true;
		this.A6018B08.Location = new System.Drawing.Point(27, 52);
		this.A6018B08.Name = "label1";
		this.A6018B08.Size = new System.Drawing.Size(98, 16);
		this.A6018B08.TabIndex = 31;
		this.A6018B08.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.B90E2300.BackColor = System.Drawing.Color.Maroon;
		this.B90E2300.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B90E2300.FlatAppearance.BorderSize = 0;
		this.B90E2300.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B90E2300.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B90E2300.ForeColor = System.Drawing.Color.White;
		this.B90E2300.Location = new System.Drawing.Point(189, 406);
		this.B90E2300.Name = "btnCancel";
		this.B90E2300.Size = new System.Drawing.Size(92, 29);
		this.B90E2300.TabIndex = 10;
		this.B90E2300.Text = "Đóng";
		this.B90E2300.UseVisualStyleBackColor = false;
		this.B90E2300.Click += new System.EventHandler(F21D0F35);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 406);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(F426D93F);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(359, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 447);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemStory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A91DB42A);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.EB25403F.ResumeLayout(false);
		this.EB25403F.PerformLayout();
		this.plInteract.ResumeLayout(false);
		this.plInteract.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.C535540A).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D417BB2F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
