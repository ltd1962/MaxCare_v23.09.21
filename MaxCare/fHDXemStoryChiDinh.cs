using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDXemStoryChiDinh : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool F4183619;

	private IContainer A70D1F12 = null;

	private BunifuDragControl ABAC49AA;

	private BunifuDragControl bunifuDragControl_0;

	private Panel DEA3F434;

	private TextBox txtTenHanhDong;

	private Label B23F3734;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox B582FCA5;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private Label lblStatus;

	private Panel plInteract;

	private Label AB0D4199;

	private Label label26;

	private Label label27;

	private Label label28;

	private Label label29;

	private Label label30;

	private CheckBox C690D417;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox BE8D54A4;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Label CC8A58AD;

	private CheckBox ckbComment;

	private CheckBox B72A40A6;

	private TextBox txtComment;

	private Button button2;

	private Label label8;

	private Label label2;

	private TextBox txtLinkStory;

	public fHDXemStoryChiDinh(string C92A0718, int int_1 = 0, string E0A3450B = "")
	{
		InitializeComponent();
		F4183619 = false;
		string_0 = C92A0718;
		string_2 = E0A3450B;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDXemStoryChiDinh").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXemStoryChiDinh','Xem story chỉ định');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDXemStoryChiDinh");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E0A3450B);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(B23F3734);
		Language.smethod_0(label2);
		Language.smethod_0(B72A40A6);
		Language.smethod_0(label26);
		Language.smethod_0(label27);
		Language.smethod_0(label30);
		Language.smethod_0(CC8A58AD);
		Language.smethod_0(ckbComment);
		Language.smethod_0(lblStatus);
		Language.smethod_0(button2);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void F00F19A0(object sender, EventArgs e)
	{
		try
		{
			txtLinkStory.Text = gclass8_0.GetValue("txtLinkStory");
			B72A40A6.Checked = gclass8_0.GetValueBool("ckbInteract");
			string text = gclass8_0.GetValue("typeReaction");
			List<CheckBox> list = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, BE8D54A4, ckbWow, ckbBuon, C690D417 };
			for (int i = 0; i < list.Count; i++)
			{
				if (text.Contains(i.ToString()))
				{
					list[i].Checked = true;
				}
			}
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			txtComment.Text = gclass8_0.GetValue("txtComment");
		}
		catch
		{
		}
		method_1();
	}

	private void AD0D468A(object sender, EventArgs e)
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
		if (ckbComment.Checked)
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
		gClass.GetJson("txtLinkStory", txtLinkStory.Text);
		gClass.GetJson("ckbInteract", B72A40A6.Checked);
		string text2 = "";
		List<CheckBox> list = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, BE8D54A4, ckbWow, ckbBuon, C690D417 };
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Checked)
			{
				text2 += i;
			}
		}
		gClass.GetJson("typeReaction", text2);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					F4183619 = true;
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
				F4183619 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void ADB5F5A9(object sender, EventArgs e)
	{
		Close();
	}

	private void E830C805(object sender, PaintEventArgs e)
	{
		if (DEA3F434.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, DEA3F434.ClientSize.Width - num, DEA3F434.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		AF931334(null, null);
		ckbComment_CheckedChanged(null, null);
	}

	private void AF931334(object sender, EventArgs e)
	{
		plInteract.Enabled = B72A40A6.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void AB0D4199_Click(object sender, EventArgs e)
	{
		ckbLike.Checked = !ckbLike.Checked;
	}

	private void C6ADD632(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void E3A4C117(object sender, EventArgs e)
	{
		ckbThuong.Checked = !ckbThuong.Checked;
	}

	private void label28_Click(object sender, EventArgs e)
	{
		BE8D54A4.Checked = !BE8D54A4.Checked;
	}

	private void A8809733(object sender, EventArgs e)
	{
		ckbWow.Checked = !ckbWow.Checked;
	}

	private void label30_Click(object sender, EventArgs e)
	{
		ckbBuon.Checked = !ckbBuon.Checked;
	}

	private void A528F598(object sender, EventArgs e)
	{
		C690D417.Checked = !C690D417.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng story!");
	}

	private void EFB48D0B(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtLinkStory.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label2.Text = string.Format(Language.GetValue("Danh sách link ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && A70D1F12 != null)
		{
			A70D1F12.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.A70D1F12 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemStoryChiDinh));
		this.ABAC49AA = new Bunifu.Framework.UI.BunifuDragControl(this.A70D1F12);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.A70D1F12);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.B582FCA5 = new System.Windows.Forms.PictureBox();
		this.DEA3F434 = new System.Windows.Forms.Panel();
		this.txtLinkStory = new System.Windows.Forms.TextBox();
		this.plComment = new System.Windows.Forms.Panel();
		this.button2 = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.TextBox();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plInteract = new System.Windows.Forms.Panel();
		this.AB0D4199 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.label28 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.label30 = new System.Windows.Forms.Label();
		this.C690D417 = new System.Windows.Forms.CheckBox();
		this.ckbBuon = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.BE8D54A4 = new System.Windows.Forms.CheckBox();
		this.ckbThuong = new System.Windows.Forms.CheckBox();
		this.ckbTym = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.CC8A58AD = new System.Windows.Forms.Label();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.B72A40A6 = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.B23F3734 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B582FCA5).BeginInit();
		this.DEA3F434.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plInteract.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.ABAC49AA.Fixed = true;
		this.ABAC49AA.Horizontal = true;
		this.ABAC49AA.TargetControl = this.bunifuCustomLabel1;
		this.ABAC49AA.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Xem Story";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.B582FCA5);
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
		this.button1.Click += new System.EventHandler(AD0D468A);
		this.B582FCA5.Cursor = System.Windows.Forms.Cursors.Default;
		this.B582FCA5.Image = Resources.Bitmap_4;
		this.B582FCA5.Location = new System.Drawing.Point(3, 2);
		this.B582FCA5.Name = "pictureBox1";
		this.B582FCA5.Size = new System.Drawing.Size(34, 27);
		this.B582FCA5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.B582FCA5.TabIndex = 76;
		this.B582FCA5.TabStop = false;
		this.DEA3F434.BackColor = System.Drawing.Color.White;
		this.DEA3F434.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DEA3F434.Controls.Add(this.txtLinkStory);
		this.DEA3F434.Controls.Add(this.plComment);
		this.DEA3F434.Controls.Add(this.plInteract);
		this.DEA3F434.Controls.Add(this.ckbComment);
		this.DEA3F434.Controls.Add(this.B72A40A6);
		this.DEA3F434.Controls.Add(this.txtTenHanhDong);
		this.DEA3F434.Controls.Add(this.label2);
		this.DEA3F434.Controls.Add(this.B23F3734);
		this.DEA3F434.Controls.Add(this.btnCancel);
		this.DEA3F434.Controls.Add(this.btnAdd);
		this.DEA3F434.Controls.Add(this.bunifuCards1);
		this.DEA3F434.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.DEA3F434.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DEA3F434.Location = new System.Drawing.Point(0, 0);
		this.DEA3F434.Name = "panel1";
		this.DEA3F434.Size = new System.Drawing.Size(362, 266);
		this.DEA3F434.TabIndex = 0;
		this.DEA3F434.Paint += new System.Windows.Forms.PaintEventHandler(E830C805);
		this.txtLinkStory.Location = new System.Drawing.Point(30, 98);
		this.txtLinkStory.Multiline = true;
		this.txtLinkStory.Name = "txtLinkStory";
		this.txtLinkStory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtLinkStory.Size = new System.Drawing.Size(296, 111);
		this.txtLinkStory.TabIndex = 32;
		this.txtLinkStory.WordWrap = false;
		this.txtLinkStory.TextChanged += new System.EventHandler(EFB48D0B);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.button2);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(48, 378);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(278, 164);
		this.plComment.TabIndex = 8;
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(246, 2);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(23, 23);
		this.button2.TabIndex = 3;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
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
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plInteract.Controls.Add(this.AB0D4199);
		this.plInteract.Controls.Add(this.label26);
		this.plInteract.Controls.Add(this.label27);
		this.plInteract.Controls.Add(this.label28);
		this.plInteract.Controls.Add(this.label29);
		this.plInteract.Controls.Add(this.label30);
		this.plInteract.Controls.Add(this.C690D417);
		this.plInteract.Controls.Add(this.ckbBuon);
		this.plInteract.Controls.Add(this.ckbWow);
		this.plInteract.Controls.Add(this.BE8D54A4);
		this.plInteract.Controls.Add(this.ckbThuong);
		this.plInteract.Controls.Add(this.ckbTym);
		this.plInteract.Controls.Add(this.ckbLike);
		this.plInteract.Controls.Add(this.CC8A58AD);
		this.plInteract.Location = new System.Drawing.Point(48, 309);
		this.plInteract.Name = "plInteract";
		this.plInteract.Size = new System.Drawing.Size(278, 40);
		this.plInteract.TabIndex = 6;
		this.AB0D4199.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AB0D4199.Location = new System.Drawing.Point(4, 1);
		this.AB0D4199.Name = "label25";
		this.AB0D4199.Size = new System.Drawing.Size(30, 16);
		this.AB0D4199.TabIndex = 0;
		this.AB0D4199.Text = "Like";
		this.AB0D4199.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.AB0D4199.Click += new System.EventHandler(AB0D4199_Click);
		this.label26.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label26.Location = new System.Drawing.Point(40, 1);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(33, 16);
		this.label26.TabIndex = 2;
		this.label26.Text = "Tym";
		this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label26.Click += new System.EventHandler(C6ADD632);
		this.label27.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label27.Location = new System.Drawing.Point(75, 1);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(52, 16);
		this.label27.TabIndex = 4;
		this.label27.Text = "Thương";
		this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label27.Click += new System.EventHandler(E3A4C117);
		this.label28.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label28.Location = new System.Drawing.Point(128, 1);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(37, 16);
		this.label28.TabIndex = 6;
		this.label28.Text = "Haha";
		this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label28.Click += new System.EventHandler(label28_Click);
		this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label29.Location = new System.Drawing.Point(167, 1);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(37, 16);
		this.label29.TabIndex = 8;
		this.label29.Text = "Wow";
		this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label29.Click += new System.EventHandler(A8809733);
		this.label30.Cursor = System.Windows.Forms.Cursors.Hand;
		this.label30.Location = new System.Drawing.Point(206, 1);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(36, 16);
		this.label30.TabIndex = 10;
		this.label30.Text = "Buồn";
		this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label30.Click += new System.EventHandler(label30_Click);
		this.C690D417.AutoSize = true;
		this.C690D417.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C690D417.Location = new System.Drawing.Point(252, 20);
		this.C690D417.Name = "ckbGian";
		this.C690D417.Size = new System.Drawing.Size(15, 14);
		this.C690D417.TabIndex = 13;
		this.C690D417.UseVisualStyleBackColor = true;
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
		this.BE8D54A4.AutoSize = true;
		this.BE8D54A4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BE8D54A4.Location = new System.Drawing.Point(139, 20);
		this.BE8D54A4.Name = "ckbHaha";
		this.BE8D54A4.Size = new System.Drawing.Size(15, 14);
		this.BE8D54A4.TabIndex = 7;
		this.BE8D54A4.UseVisualStyleBackColor = true;
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
		this.ckbLike.AutoSize = true;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Location = new System.Drawing.Point(11, 20);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(15, 14);
		this.ckbLike.TabIndex = 1;
		this.ckbLike.UseVisualStyleBackColor = true;
		this.CC8A58AD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CC8A58AD.Location = new System.Drawing.Point(242, 1);
		this.CC8A58AD.Name = "label32";
		this.CC8A58AD.Size = new System.Drawing.Size(33, 16);
		this.CC8A58AD.TabIndex = 12;
		this.CC8A58AD.Text = "Giận";
		this.CC8A58AD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CC8A58AD.Click += new System.EventHandler(A528F598);
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 353);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(130, 20);
		this.ckbComment.TabIndex = 7;
		this.ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.B72A40A6.AutoSize = true;
		this.B72A40A6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B72A40A6.Location = new System.Drawing.Point(30, 285);
		this.B72A40A6.Name = "ckbInteract";
		this.B72A40A6.Size = new System.Drawing.Size(112, 20);
		this.B72A40A6.TabIndex = 5;
		this.B72A40A6.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		this.B72A40A6.UseVisualStyleBackColor = true;
		this.B72A40A6.CheckedChanged += new System.EventHandler(AF931334);
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 78);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(115, 16);
		this.label2.TabIndex = 31;
		this.label2.Text = "Danh sách link (0):";
		this.B23F3734.AutoSize = true;
		this.B23F3734.Location = new System.Drawing.Point(27, 52);
		this.B23F3734.Name = "label1";
		this.B23F3734.Size = new System.Drawing.Size(98, 16);
		this.B23F3734.TabIndex = 31;
		this.B23F3734.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 224);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(ADB5F5A9);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 224);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		base.ClientSize = new System.Drawing.Size(362, 266);
		base.Controls.Add(this.DEA3F434);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemStoryChiDinh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F00F19A0);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.B582FCA5).EndInit();
		this.DEA3F434.ResumeLayout(false);
		this.DEA3F434.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plInteract.ResumeLayout(false);
		this.plInteract.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
