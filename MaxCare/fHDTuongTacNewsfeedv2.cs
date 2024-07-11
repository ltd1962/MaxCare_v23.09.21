using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDTuongTacNewsfeedv2 : Form
{
	private JSON_Settings gclass8_0 = null;

	private string A71BB685;

	private string A92A6790;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudTimeTo;

	private NumericUpDown A015370A;

	private NumericUpDown CB2DBF1B;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label6;

	private Label label4;

	private Label label5;

	private Label B5160927;

	private Label DA2E5D2E;

	private Button EBB99A37;

	private Button btnAdd;

	private BunifuCards D79D7E34;

	private Panel DE83B302;

	private Button button1;

	private PictureBox D6884D02;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbComment;

	private CheckBox DE22461F;

	private Panel E838629D;

	private NumericUpDown nudCountCommentFrom;

	private Label label13;

	private Label AEB7A286;

	private NumericUpDown nudCountCommentTo;

	private Panel C92FFD2D;

	private NumericUpDown nudCountLikeFrom;

	private Label label9;

	private Label D188F82B;

	private NumericUpDown nudCountLikeTo;

	private Panel plComment;

	private RichTextBox C585908C;

	private Button btnDown;

	private Button btnUp;

	private RadioButton A43767BD;

	private RadioButton F58EFF33;

	private Label label8;

	private Label F987722A;

	private Label lblStatus;

	private Panel C5967387;

	private CheckBox C0AB981A;

	private CheckBox ckbSad;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox A1136A0D;

	private CheckBox F9A3AB15;

	public fHDTuongTacNewsfeedv2(string string_1, int EE0FEA09 = 0, string F5ADF03B = "")
	{
		InitializeComponent();
		bool_0 = false;
		A71BB685 = string_1;
		string_0 = F5ADF03B;
		int_0 = EE0FEA09;
		if (InteractSQL.B484648C("", "HDTuongTacNewsfeedv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNewsfeedv2', 'Tương tác Newsfeed v2');");
		}
		string text = "";
		switch (EE0FEA09)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTuongTacNewsfeedv2");
			A92A6790 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(F5ADF03B);
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
		Language.smethod_0(DA2E5D2E);
		Language.smethod_0(B5160927);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(D188F82B);
		Language.smethod_0(label9);
		Language.smethod_0(AEB7A286);
		Language.smethod_0(label13);
		Language.smethod_0(lblStatus);
		Language.smethod_0(F987722A);
		Language.smethod_0(btnAdd);
		Language.smethod_0(EBB99A37);
	}

	private void fHDTuongTacNewsfeedv2_Load(object sender, EventArgs e)
	{
		try
		{
			CB2DBF1B.Value = gclass8_0.GetValueInt("nudTimeFrom", 10);
			nudTimeTo.Value = gclass8_0.GetValueInt("nudTimeTo", 30);
			A015370A.Value = gclass8_0.GetValueInt("nudDelayFrom", 1);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 3);
			nudCountLikeFrom.Value = gclass8_0.GetValueInt("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = gclass8_0.GetValueInt("nudCountLikeTo", 3);
			nudCountCommentFrom.Value = gclass8_0.GetValueInt("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = gclass8_0.GetValueInt("nudCountCommentTo", 3);
			DE22461F.Checked = gclass8_0.GetValueBool("ckbInteract");
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			C585908C.Text = gclass8_0.GetValue("txtComment");
			if (gclass8_0.GetValue("typeCamXuc").Contains("0"))
			{
				F9A3AB15.Checked = true;
			}
			if (gclass8_0.GetValue("typeCamXuc").Contains("1"))
			{
				A1136A0D.Checked = true;
			}
			if (gclass8_0.GetValue("typeCamXuc").Contains("2"))
			{
				ckbCare.Checked = true;
			}
			if (gclass8_0.GetValue("typeCamXuc").Contains("3"))
			{
				ckbHaha.Checked = true;
			}
			if (gclass8_0.GetValue("typeCamXuc").Contains("4"))
			{
				ckbWow.Checked = true;
			}
			if (gclass8_0.GetValue("typeCamXuc").Contains("5"))
			{
				ckbSad.Checked = true;
			}
			if (gclass8_0.GetValue("typeCamXuc").Contains("6"))
			{
				C0AB981A.Checked = true;
			}
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				A43767BD.Checked = true;
			}
			else
			{
				F58EFF33.Checked = true;
			}
		}
		catch
		{
		}
		CA90EB11();
	}

	private void button1_Click(object sender, EventArgs e)
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
			List<string> a2AB53A = C585908C.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudTimeFrom", CB2DBF1B.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", A015370A.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbInteract", DE22461F.Checked);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", C585908C.Text.Trim());
		gClass.GetJson("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.GetJson("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.GetJson("nudCountCommentFrom", nudCountCommentFrom.Value);
		gClass.GetJson("nudCountCommentTo", nudCountCommentTo.Value);
		string text2 = "";
		if (F9A3AB15.Checked)
		{
			text2 += "0";
		}
		if (A1136A0D.Checked)
		{
			text2 += "1";
		}
		if (ckbCare.Checked)
		{
			text2 += "2";
		}
		if (ckbHaha.Checked)
		{
			text2 += "3";
		}
		if (ckbWow.Checked)
		{
			text2 += "4";
		}
		if (ckbSad.Checked)
		{
			text2 += "5";
		}
		if (C0AB981A.Checked)
		{
			text2 += "6";
		}
		gClass.GetJson("typeCamXuc", text2);
		int num = 0;
		if (A43767BD.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		string text3 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(A71BB685, text, A92A6790, text3))
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
			if (InteractSQL.smethod_13(string_0, text, text3))
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

	private void BD2C380F(object sender, EventArgs e)
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

	private void A43D3C3A(object sender, EventArgs e)
	{
		E617669B();
	}

	private void E617669B()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!F58EFF33.Checked) ? C585908C.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : C585908C.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void CA90EB11()
	{
		DE22461F_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
	}

	private void DE22461F_CheckedChanged(object sender, EventArgs e)
	{
		C92FFD2D.Enabled = DE22461F.Checked;
		C5967387.Enabled = DE22461F.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		E838629D.Enabled = ckbComment.Checked;
		plComment.Enabled = ckbComment.Checked;
	}

	private void A1BA68BE(object sender, EventArgs e)
	{
		plComment.Height = 207;
	}

	private void AEACB6BC(object sender, EventArgs e)
	{
		plComment.Height = 163;
	}

	private void FABEB900(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void F58EFF33_CheckedChanged(object sender, EventArgs e)
	{
		E617669B();
	}

	private void A43767BD_CheckedChanged(object sender, EventArgs e)
	{
		E617669B();
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	protected override void Dispose(bool A0978697)
	{
		if (A0978697 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A0978697);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.DE83B302 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.D6884D02 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.C5967387 = new System.Windows.Forms.Panel();
		this.C0AB981A = new System.Windows.Forms.CheckBox();
		this.ckbSad = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbCare = new System.Windows.Forms.CheckBox();
		this.A1136A0D = new System.Windows.Forms.CheckBox();
		this.F9A3AB15 = new System.Windows.Forms.CheckBox();
		this.plComment = new System.Windows.Forms.Panel();
		this.C585908C = new System.Windows.Forms.RichTextBox();
		this.btnDown = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.A43767BD = new System.Windows.Forms.RadioButton();
		this.F58EFF33 = new System.Windows.Forms.RadioButton();
		this.label8 = new System.Windows.Forms.Label();
		this.F987722A = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.E838629D = new System.Windows.Forms.Panel();
		this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.AEB7A286 = new System.Windows.Forms.Label();
		this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		this.C92FFD2D = new System.Windows.Forms.Panel();
		this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.D188F82B = new System.Windows.Forms.Label();
		this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.DE22461F = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.A015370A = new System.Windows.Forms.NumericUpDown();
		this.CB2DBF1B = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.B5160927 = new System.Windows.Forms.Label();
		this.DA2E5D2E = new System.Windows.Forms.Label();
		this.EBB99A37 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.D79D7E34 = new Bunifu.Framework.UI.BunifuCards();
		this.DE83B302.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D6884D02).BeginInit();
		this.panel1.SuspendLayout();
		this.C5967387.SuspendLayout();
		this.plComment.SuspendLayout();
		this.E838629D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
		this.C92FFD2D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A015370A).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CB2DBF1B).BeginInit();
		this.D79D7E34.SuspendLayout();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Newsfeed v2";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.DE83B302;
		this.bunifuDragControl_1.Vertical = true;
		this.DE83B302.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.DE83B302.BackColor = System.Drawing.Color.White;
		this.DE83B302.Controls.Add(this.button1);
		this.DE83B302.Controls.Add(this.D6884D02);
		this.DE83B302.Controls.Add(this.bunifuCustomLabel1);
		this.DE83B302.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.DE83B302.Location = new System.Drawing.Point(0, 3);
		this.DE83B302.Name = "pnlHeader";
		this.DE83B302.Size = new System.Drawing.Size(359, 31);
		this.DE83B302.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.A13F2207;
		this.button1.Location = new System.Drawing.Point(328, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.D6884D02.Cursor = System.Windows.Forms.Cursors.Default;
		this.D6884D02.Image = Resources.Bitmap_4;
		this.D6884D02.Location = new System.Drawing.Point(3, 2);
		this.D6884D02.Name = "pictureBox1";
		this.D6884D02.Size = new System.Drawing.Size(34, 27);
		this.D6884D02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.D6884D02.TabIndex = 76;
		this.D6884D02.TabStop = false;
		this.D6884D02.Click += new System.EventHandler(FABEB900);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.C5967387);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.E838629D);
		this.panel1.Controls.Add(this.C92FFD2D);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.DE22461F);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudTimeTo);
		this.panel1.Controls.Add(this.A015370A);
		this.panel1.Controls.Add(this.CB2DBF1B);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.B5160927);
		this.panel1.Controls.Add(this.DA2E5D2E);
		this.panel1.Controls.Add(this.EBB99A37);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.D79D7E34);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 468);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.C5967387.Controls.Add(this.C0AB981A);
		this.C5967387.Controls.Add(this.ckbSad);
		this.C5967387.Controls.Add(this.ckbWow);
		this.C5967387.Controls.Add(this.ckbHaha);
		this.C5967387.Controls.Add(this.ckbCare);
		this.C5967387.Controls.Add(this.A1136A0D);
		this.C5967387.Controls.Add(this.F9A3AB15);
		this.C5967387.Location = new System.Drawing.Point(50, 161);
		this.C5967387.Name = "panel2";
		this.C5967387.Size = new System.Drawing.Size(281, 51);
		this.C5967387.TabIndex = 43;
		this.C0AB981A.AutoSize = true;
		this.C0AB981A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C0AB981A.Location = new System.Drawing.Point(142, 29);
		this.C0AB981A.Name = "ckbAngry";
		this.C0AB981A.Size = new System.Drawing.Size(72, 20);
		this.C0AB981A.TabIndex = 12;
		this.C0AB981A.Text = "Phẫn nộ";
		this.C0AB981A.UseVisualStyleBackColor = true;
		this.ckbSad.AutoSize = true;
		this.ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSad.Location = new System.Drawing.Point(73, 29);
		this.ckbSad.Name = "ckbSad";
		this.ckbSad.Size = new System.Drawing.Size(54, 20);
		this.ckbSad.TabIndex = 11;
		this.ckbSad.Text = "Buồn";
		this.ckbSad.UseVisualStyleBackColor = true;
		this.ckbWow.AutoSize = true;
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Location = new System.Drawing.Point(3, 29);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(55, 20);
		this.ckbWow.TabIndex = 10;
		this.ckbWow.Text = "Wow";
		this.ckbWow.UseVisualStyleBackColor = true;
		this.ckbHaha.AutoSize = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Location = new System.Drawing.Point(222, 3);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(55, 20);
		this.ckbHaha.TabIndex = 9;
		this.ckbHaha.Text = "Haha";
		this.ckbHaha.UseVisualStyleBackColor = true;
		this.ckbCare.AutoSize = true;
		this.ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCare.Location = new System.Drawing.Point(142, 3);
		this.ckbCare.Name = "ckbCare";
		this.ckbCare.Size = new System.Drawing.Size(70, 20);
		this.ckbCare.TabIndex = 8;
		this.ckbCare.Text = "Thương";
		this.ckbCare.UseVisualStyleBackColor = true;
		this.A1136A0D.AutoSize = true;
		this.A1136A0D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1136A0D.Location = new System.Drawing.Point(73, 3);
		this.A1136A0D.Name = "ckbLove";
		this.A1136A0D.Size = new System.Drawing.Size(51, 20);
		this.A1136A0D.TabIndex = 7;
		this.A1136A0D.Text = "Tym";
		this.A1136A0D.UseVisualStyleBackColor = true;
		this.F9A3AB15.AutoSize = true;
		this.F9A3AB15.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F9A3AB15.Location = new System.Drawing.Point(3, 3);
		this.F9A3AB15.Name = "ckbLike";
		this.F9A3AB15.Size = new System.Drawing.Size(48, 20);
		this.F9A3AB15.TabIndex = 6;
		this.F9A3AB15.Text = "Like";
		this.F9A3AB15.UseVisualStyleBackColor = true;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.C585908C);
		this.plComment.Controls.Add(this.btnDown);
		this.plComment.Controls.Add(this.btnUp);
		this.plComment.Controls.Add(this.A43767BD);
		this.plComment.Controls.Add(this.F58EFF33);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.F987722A);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(50, 255);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(281, 163);
		this.plComment.TabIndex = 42;
		this.C585908C.Location = new System.Drawing.Point(7, 27);
		this.C585908C.Name = "txtComment";
		this.C585908C.Size = new System.Drawing.Size(266, 111);
		this.C585908C.TabIndex = 106;
		this.C585908C.Text = "";
		this.C585908C.WordWrap = false;
		this.C585908C.TextChanged += new System.EventHandler(A43D3C3A);
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 7;
		this.btnDown.Visible = false;
		this.btnDown.Click += new System.EventHandler(A1BA68BE);
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 7;
		this.btnUp.Visible = false;
		this.btnUp.Click += new System.EventHandler(AEACB6BC);
		this.A43767BD.AutoSize = true;
		this.A43767BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A43767BD.Location = new System.Drawing.Point(69, 182);
		this.A43767BD.Name = "rbNganCachKyTu";
		this.A43767BD.Size = new System.Drawing.Size(202, 20);
		this.A43767BD.TabIndex = 6;
		this.A43767BD.Text = "Các nội dung ngăn cách bởi \"|\"";
		this.A43767BD.UseVisualStyleBackColor = true;
		this.A43767BD.CheckedChanged += new System.EventHandler(A43767BD_CheckedChanged);
		this.F58EFF33.AutoSize = true;
		this.F58EFF33.Checked = true;
		this.F58EFF33.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F58EFF33.Location = new System.Drawing.Point(69, 161);
		this.F58EFF33.Name = "rbNganCachMoiDong";
		this.F58EFF33.Size = new System.Drawing.Size(170, 20);
		this.F58EFF33.TabIndex = 5;
		this.F58EFF33.TabStop = true;
		this.F58EFF33.Text = "Mỗi dòng là một nội dung";
		this.F58EFF33.UseVisualStyleBackColor = true;
		this.F58EFF33.CheckedChanged += new System.EventHandler(F58EFF33_CheckedChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 161);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(64, 16);
		this.label8.TabIndex = 4;
		this.label8.Text = "Tùy chọn:";
		this.F987722A.AutoSize = true;
		this.F987722A.Location = new System.Drawing.Point(4, 141);
		this.F987722A.Name = "label15";
		this.F987722A.Size = new System.Drawing.Size(265, 16);
		this.F987722A.TabIndex = 0;
		this.F987722A.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.E838629D.Controls.Add(this.nudCountCommentFrom);
		this.E838629D.Controls.Add(this.label13);
		this.E838629D.Controls.Add(this.AEB7A286);
		this.E838629D.Controls.Add(this.nudCountCommentTo);
		this.E838629D.Location = new System.Drawing.Point(136, 226);
		this.E838629D.Name = "plCountComment";
		this.E838629D.Size = new System.Drawing.Size(195, 25);
		this.E838629D.TabIndex = 41;
		this.nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentFrom.Name = "nudCountCommentFrom";
		this.nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentFrom.TabIndex = 1;
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(157, 3);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(24, 16);
		this.label13.TabIndex = 35;
		this.label13.Text = "lần";
		this.AEB7A286.Location = new System.Drawing.Point(63, 3);
		this.AEB7A286.Name = "label14";
		this.AEB7A286.Size = new System.Drawing.Size(29, 16);
		this.AEB7A286.TabIndex = 37;
		this.AEB7A286.Text = "đê\u0301n";
		this.AEB7A286.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentTo.Name = "nudCountCommentTo";
		this.nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentTo.TabIndex = 2;
		this.C92FFD2D.Controls.Add(this.nudCountLikeFrom);
		this.C92FFD2D.Controls.Add(this.label9);
		this.C92FFD2D.Controls.Add(this.D188F82B);
		this.C92FFD2D.Controls.Add(this.nudCountLikeTo);
		this.C92FFD2D.Location = new System.Drawing.Point(136, 133);
		this.C92FFD2D.Name = "plCountLike";
		this.C92FFD2D.Size = new System.Drawing.Size(195, 25);
		this.C92FFD2D.TabIndex = 39;
		this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeFrom.Name = "nudCountLikeFrom";
		this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeFrom.TabIndex = 1;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(157, 3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(24, 16);
		this.label9.TabIndex = 35;
		this.label9.Text = "lần";
		this.D188F82B.Location = new System.Drawing.Point(63, 3);
		this.D188F82B.Name = "label10";
		this.D188F82B.Size = new System.Drawing.Size(29, 16);
		this.D188F82B.TabIndex = 37;
		this.D188F82B.Text = "đê\u0301n";
		this.D188F82B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeTo.Name = "nudCountLikeTo";
		this.nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeTo.TabIndex = 2;
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 228);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(81, 20);
		this.ckbComment.TabIndex = 7;
		this.ckbComment.Text = "Comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.DE22461F.AutoSize = true;
		this.DE22461F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE22461F.Location = new System.Drawing.Point(30, 135);
		this.DE22461F.Name = "ckbInteract";
		this.DE22461F.Size = new System.Drawing.Size(104, 20);
		this.DE22461F.TabIndex = 5;
		this.DE22461F.Text = "Thả cảm xúc:";
		this.DE22461F.UseVisualStyleBackColor = true;
		this.DE22461F.CheckedChanged += new System.EventHandler(DE22461F_CheckedChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(234, 105);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudTimeTo.Location = new System.Drawing.Point(234, 77);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeTo.TabIndex = 2;
		this.A015370A.Location = new System.Drawing.Point(137, 105);
		this.A015370A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A015370A.Name = "nudDelayFrom";
		this.A015370A.Size = new System.Drawing.Size(56, 23);
		this.A015370A.TabIndex = 3;
		this.CB2DBF1B.Location = new System.Drawing.Point(137, 77);
		this.CB2DBF1B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CB2DBF1B.Name = "nudTimeFrom";
		this.CB2DBF1B.Size = new System.Drawing.Size(56, 23);
		this.CB2DBF1B.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(199, 107);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(199, 79);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(292, 107);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(292, 79);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(30, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 107);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(110, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		this.B5160927.AutoSize = true;
		this.B5160927.Location = new System.Drawing.Point(27, 79);
		this.B5160927.Name = "label2";
		this.B5160927.Size = new System.Drawing.Size(91, 16);
		this.B5160927.TabIndex = 32;
		this.B5160927.Text = "Thơ\u0300i gian lươ\u0301t:";
		this.DA2E5D2E.AutoSize = true;
		this.DA2E5D2E.Location = new System.Drawing.Point(27, 52);
		this.DA2E5D2E.Name = "label1";
		this.DA2E5D2E.Size = new System.Drawing.Size(98, 16);
		this.DA2E5D2E.TabIndex = 31;
		this.DA2E5D2E.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.EBB99A37.BackColor = System.Drawing.Color.Maroon;
		this.EBB99A37.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EBB99A37.FlatAppearance.BorderSize = 0;
		this.EBB99A37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EBB99A37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EBB99A37.ForeColor = System.Drawing.Color.White;
		this.EBB99A37.Location = new System.Drawing.Point(189, 428);
		this.EBB99A37.Name = "btnCancel";
		this.EBB99A37.Size = new System.Drawing.Size(92, 29);
		this.EBB99A37.TabIndex = 10;
		this.EBB99A37.Text = "Đóng";
		this.EBB99A37.UseVisualStyleBackColor = false;
		this.EBB99A37.Click += new System.EventHandler(BD2C380F);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 428);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.D79D7E34.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D79D7E34.BackColor = System.Drawing.Color.White;
		this.D79D7E34.BorderRadius = 0;
		this.D79D7E34.BottomSahddow = true;
		this.D79D7E34.color = System.Drawing.Color.DarkViolet;
		this.D79D7E34.Controls.Add(this.DE83B302);
		this.D79D7E34.LeftSahddow = false;
		this.D79D7E34.Location = new System.Drawing.Point(1, 0);
		this.D79D7E34.Name = "bunifuCards1";
		this.D79D7E34.RightSahddow = true;
		this.D79D7E34.ShadowDepth = 20;
		this.D79D7E34.Size = new System.Drawing.Size(359, 37);
		this.D79D7E34.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 468);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNewsfeedv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacNewsfeedv2_Load);
		this.DE83B302.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.D6884D02).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.C5967387.ResumeLayout(false);
		this.C5967387.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.E838629D.ResumeLayout(false);
		this.E838629D.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
		this.C92FFD2D.ResumeLayout(false);
		this.C92FFD2D.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A015370A).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CB2DBF1B).EndInit();
		this.D79D7E34.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
