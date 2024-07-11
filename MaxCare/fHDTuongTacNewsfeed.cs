using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDTuongTacNewsfeed : Form
{
	private JSON_Settings A429A8BC = null;

	private string C1209823;

	private string string_0;

	private string string_1;

	private int B12F1697;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl D4B9129A;

	private Panel BCA33B3C;

	private NumericUpDown A684EF87;

	private NumericUpDown DF012A34;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudTimeFrom;

	private TextBox A1330D30;

	private Label label7;

	private Label label3;

	private Label label6;

	private Label C33D138E;

	private Label FB07BA8D;

	private Label label2;

	private Label label1;

	private Button C01B3198;

	private Button C51DFD0A;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel DD06979F;

	private CheckBox ckbComment;

	private CheckBox CC298A13;

	private CheckBox ckbShareWall;

	private Panel plCountComment;

	private NumericUpDown DDA8A380;

	private Label B43EFBBB;

	private Label label14;

	private NumericUpDown nudCountCommentTo;

	private Panel plCountShareWall;

	private NumericUpDown A9057485;

	private Label label11;

	private Label label12;

	private NumericUpDown nudCountShareTo;

	private Panel plCountLike;

	private NumericUpDown AE143223;

	private Label label9;

	private Label label10;

	private NumericUpDown DC2B6F92;

	private Panel plCommentText;

	private RichTextBox B0A2A998;

	private Button btnDown;

	private Button btnUp;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label8;

	private Label label15;

	private Label lblStatus;

	private Button EF87C9A3;

	private Button button3;

	private Button FC9FE1BB;

	private LinkLabel FAB3A411;

	private Panel C78B6794;

	private TextBox txtAnh;

	private Label label16;

	private CheckBox ckbSendAnh;

	private Panel plComment;

	private Label label17;

	private CheckBox ckbCommentText;

	public fHDTuongTacNewsfeed(string A38D6720, int int_0 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		C1209823 = A38D6720;
		string_1 = string_2;
		B12F1697 = int_0;
		if (InteractSQL.B484648C("", "HDTuongTacNewsfeed").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNewsfeed', 'Tương tác Newsfeed');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTuongTacNewsfeed");
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A1330D30.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			C51DFD0A.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A1330D30.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A429A8BC = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(DD06979F);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(C33D138E);
		Language.smethod_0(FB07BA8D);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(label10);
		Language.smethod_0(label9);
		Language.smethod_0(label12);
		Language.smethod_0(label11);
		Language.smethod_0(label14);
		Language.smethod_0(B43EFBBB);
		Language.smethod_0(lblStatus);
		Language.smethod_0(EF87C9A3);
		Language.smethod_0(label15);
		Language.smethod_0(C51DFD0A);
		Language.smethod_0(C01B3198);
	}

	private void B99B3D07(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = A429A8BC.GetValueInt("nudTimeFrom", 10);
			DF012A34.Value = A429A8BC.GetValueInt("nudTimeTo", 30);
			nudDelayFrom.Value = A429A8BC.GetValueInt("nudDelayFrom", 1);
			A684EF87.Value = A429A8BC.GetValueInt("nudDelayTo", 3);
			AE143223.Value = A429A8BC.GetValueInt("nudCountLikeFrom", 1);
			DC2B6F92.Value = A429A8BC.GetValueInt("nudCountLikeTo", 3);
			A9057485.Value = A429A8BC.GetValueInt("nudCountShareFrom", 1);
			nudCountShareTo.Value = A429A8BC.GetValueInt("nudCountShareTo", 3);
			DDA8A380.Value = A429A8BC.GetValueInt("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = A429A8BC.GetValueInt("nudCountCommentTo", 3);
			CC298A13.Checked = A429A8BC.GetValueBool("ckbInteract");
			ckbShareWall.Checked = A429A8BC.GetValueBool("ckbShareWall");
			ckbComment.Checked = A429A8BC.GetValueBool("ckbComment");
			ckbCommentText.Checked = A429A8BC.GetValueBool("ckbCommentText");
			B0A2A998.Text = A429A8BC.GetValue("txtComment");
			ckbSendAnh.Checked = A429A8BC.GetValueBool("ckbSendAnh");
			txtAnh.Text = A429A8BC.GetValue("txtAnh");
			if (A429A8BC.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		method_2();
	}

	private void F6A93EAF(object sender, EventArgs e)
	{
		Close();
	}

	private void BE194F06(object sender, EventArgs e)
	{
		string text = A1330D30.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> a2AB53A = B0A2A998.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudTimeFrom", nudTimeFrom.Value);
		gClass.GetJson("nudTimeTo", DF012A34.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", A684EF87.Value);
		gClass.GetJson("ckbInteract", CC298A13.Checked);
		gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("ckbCommentText", ckbCommentText.Checked);
		gClass.GetJson("txtComment", B0A2A998.Text.Trim());
		gClass.GetJson("nudCountLikeFrom", AE143223.Value);
		gClass.GetJson("nudCountLikeTo", DC2B6F92.Value);
		gClass.GetJson("nudCountShareFrom", A9057485.Value);
		gClass.GetJson("nudCountShareTo", nudCountShareTo.Value);
		gClass.GetJson("nudCountCommentFrom", DDA8A380.Value);
		gClass.GetJson("nudCountCommentTo", nudCountCommentTo.Value);
		gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		string string_ = gClass.D9A09B34();
		if (B12F1697 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(C1209823, text, string_0, string_))
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

	private void C01B3198_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BCA33B3C_Paint(object sender, PaintEventArgs e)
	{
		if (BCA33B3C.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BCA33B3C.ClientSize.Width - num, BCA33B3C.ClientSize.Height - num));
		}
	}

	private void DA0B1309(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? B0A2A998.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : B0A2A998.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		CC298A13_CheckedChanged(null, null);
		DD31982E(null, null);
		ckbCommentText_CheckedChanged(null, null);
		ckbShareWall_CheckedChanged(null, null);
	}

	private void CC298A13_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = CC298A13.Checked;
	}

	private void DD31982E(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = ckbShareWall.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 207;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 163;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void EF87C9A3_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void C6173287(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		B0A2A998.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		B0A2A998.Focus();
	}

	private void F83012A3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void F08974A0(object sender, EventArgs e)
	{
		C78B6794.Enabled = ckbSendAnh.Checked;
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacNewsfeed));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.DD06979F = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.D4B9129A = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.BCA33B3C = new System.Windows.Forms.Panel();
		this.plComment = new System.Windows.Forms.Panel();
		this.plCommentText = new System.Windows.Forms.Panel();
		this.FAB3A411 = new System.Windows.Forms.LinkLabel();
		this.button3 = new System.Windows.Forms.Button();
		this.FC9FE1BB = new System.Windows.Forms.Button();
		this.EF87C9A3 = new System.Windows.Forms.Button();
		this.B0A2A998 = new System.Windows.Forms.RichTextBox();
		this.btnDown = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label8 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.C78B6794 = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.plCountComment = new System.Windows.Forms.Panel();
		this.DDA8A380 = new System.Windows.Forms.NumericUpDown();
		this.B43EFBBB = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		this.plCountShareWall = new System.Windows.Forms.Panel();
		this.A9057485 = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		this.plCountLike = new System.Windows.Forms.Panel();
		this.AE143223 = new System.Windows.Forms.NumericUpDown();
		this.label9 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.DC2B6F92 = new System.Windows.Forms.NumericUpDown();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.CC298A13 = new System.Windows.Forms.CheckBox();
		this.A684EF87 = new System.Windows.Forms.NumericUpDown();
		this.DF012A34 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		this.A1330D30 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.C33D138E = new System.Windows.Forms.Label();
		this.FB07BA8D = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.C01B3198 = new System.Windows.Forms.Button();
		this.C51DFD0A = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.BCA33B3C.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plCommentText.SuspendLayout();
		this.C78B6794.SuspendLayout();
		this.plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DDA8A380).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
		this.plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.A9057485).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).BeginInit();
		this.plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AE143223).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DC2B6F92).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.A684EF87).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DF012A34).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.DD06979F;
		this.bunifuDragControl_0.Vertical = true;
		this.DD06979F.BackColor = System.Drawing.Color.Transparent;
		this.DD06979F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.DD06979F.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DD06979F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DD06979F.ForeColor = System.Drawing.Color.Black;
		this.DD06979F.Location = new System.Drawing.Point(0, 0);
		this.DD06979F.Name = "bunifuCustomLabel1";
		this.DD06979F.Size = new System.Drawing.Size(373, 31);
		this.DD06979F.TabIndex = 12;
		this.DD06979F.Text = "Cấu hình Tương tác Newsfeed";
		this.DD06979F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D4B9129A.Fixed = true;
		this.D4B9129A.Horizontal = true;
		this.D4B9129A.TargetControl = this.pnlHeader;
		this.D4B9129A.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.DD06979F);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(373, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(342, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(F6A93EAF);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.BCA33B3C.BackColor = System.Drawing.Color.White;
		this.BCA33B3C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BCA33B3C.Controls.Add(this.plComment);
		this.BCA33B3C.Controls.Add(this.plCountShareWall);
		this.BCA33B3C.Controls.Add(this.plCountLike);
		this.BCA33B3C.Controls.Add(this.ckbComment);
		this.BCA33B3C.Controls.Add(this.ckbShareWall);
		this.BCA33B3C.Controls.Add(this.CC298A13);
		this.BCA33B3C.Controls.Add(this.A684EF87);
		this.BCA33B3C.Controls.Add(this.DF012A34);
		this.BCA33B3C.Controls.Add(this.nudDelayFrom);
		this.BCA33B3C.Controls.Add(this.nudTimeFrom);
		this.BCA33B3C.Controls.Add(this.A1330D30);
		this.BCA33B3C.Controls.Add(this.label7);
		this.BCA33B3C.Controls.Add(this.label3);
		this.BCA33B3C.Controls.Add(this.label6);
		this.BCA33B3C.Controls.Add(this.C33D138E);
		this.BCA33B3C.Controls.Add(this.FB07BA8D);
		this.BCA33B3C.Controls.Add(this.label2);
		this.BCA33B3C.Controls.Add(this.label1);
		this.BCA33B3C.Controls.Add(this.C01B3198);
		this.BCA33B3C.Controls.Add(this.C51DFD0A);
		this.BCA33B3C.Controls.Add(this.bunifuCards1);
		this.BCA33B3C.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.BCA33B3C.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BCA33B3C.Location = new System.Drawing.Point(0, 0);
		this.BCA33B3C.Name = "panel1";
		this.BCA33B3C.Size = new System.Drawing.Size(376, 550);
		this.BCA33B3C.TabIndex = 0;
		this.BCA33B3C.Paint += new System.Windows.Forms.PaintEventHandler(BCA33B3C_Paint);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.plCommentText);
		this.plComment.Controls.Add(this.label17);
		this.plComment.Controls.Add(this.C78B6794);
		this.plComment.Controls.Add(this.ckbCommentText);
		this.plComment.Controls.Add(this.ckbSendAnh);
		this.plComment.Controls.Add(this.plCountComment);
		this.plComment.Location = new System.Drawing.Point(30, 215);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(315, 282);
		this.plComment.TabIndex = 169;
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.FAB3A411);
		this.plCommentText.Controls.Add(this.button3);
		this.plCommentText.Controls.Add(this.FC9FE1BB);
		this.plCommentText.Controls.Add(this.EF87C9A3);
		this.plCommentText.Controls.Add(this.B0A2A998);
		this.plCommentText.Controls.Add(this.btnDown);
		this.plCommentText.Controls.Add(this.btnUp);
		this.plCommentText.Controls.Add(this.rbNganCachKyTu);
		this.plCommentText.Controls.Add(this.rbNganCachMoiDong);
		this.plCommentText.Controls.Add(this.label8);
		this.plCommentText.Controls.Add(this.label15);
		this.plCommentText.Controls.Add(this.lblStatus);
		this.plCommentText.Location = new System.Drawing.Point(26, 53);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(281, 161);
		this.plCommentText.TabIndex = 42;
		this.FAB3A411.AutoSize = true;
		this.FAB3A411.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FAB3A411.Location = new System.Drawing.Point(167, 141);
		this.FAB3A411.Name = "linkLabel1";
		this.FAB3A411.Size = new System.Drawing.Size(81, 16);
		this.FAB3A411.TabIndex = 109;
		this.FAB3A411.TabStop = true;
		this.FAB3A411.Text = "Random icon";
		this.FAB3A411.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F83012A3);
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(228, 183);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 107;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.FC9FE1BB.Cursor = System.Windows.Forms.Cursors.Help;
		this.FC9FE1BB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FC9FE1BB.Location = new System.Drawing.Point(228, 160);
		this.FC9FE1BB.Name = "button4";
		this.FC9FE1BB.Size = new System.Drawing.Size(21, 23);
		this.FC9FE1BB.TabIndex = 108;
		this.FC9FE1BB.Text = "?";
		this.FC9FE1BB.UseVisualStyleBackColor = true;
		this.FC9FE1BB.Click += new System.EventHandler(C6173287);
		this.EF87C9A3.Cursor = System.Windows.Forms.Cursors.Help;
		this.EF87C9A3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EF87C9A3.Location = new System.Drawing.Point(250, 138);
		this.EF87C9A3.Name = "button2";
		this.EF87C9A3.Size = new System.Drawing.Size(23, 23);
		this.EF87C9A3.TabIndex = 96;
		this.EF87C9A3.Text = "?";
		this.EF87C9A3.UseVisualStyleBackColor = true;
		this.EF87C9A3.Click += new System.EventHandler(EF87C9A3_Click);
		this.B0A2A998.Location = new System.Drawing.Point(7, 27);
		this.B0A2A998.Name = "txtComment";
		this.B0A2A998.Size = new System.Drawing.Size(266, 111);
		this.B0A2A998.TabIndex = 106;
		this.B0A2A998.Text = "";
		this.B0A2A998.WordWrap = false;
		this.B0A2A998.TextChanged += new System.EventHandler(DA0B1309);
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 7;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 7;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 6;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		this.rbNganCachMoiDong.TabIndex = 5;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 161);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(64, 16);
		this.label8.TabIndex = 4;
		this.label8.Text = "Tùy chọn:";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(4, 141);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(143, 16);
		this.label15.TabIndex = 0;
		this.label15.Text = "(Spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(5, 6);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(63, 16);
		this.label17.TabIndex = 32;
		this.label17.Text = "Số lượng:";
		this.C78B6794.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C78B6794.Controls.Add(this.txtAnh);
		this.C78B6794.Controls.Add(this.label16);
		this.C78B6794.Enabled = false;
		this.C78B6794.Location = new System.Drawing.Point(26, 244);
		this.C78B6794.Name = "plAnh";
		this.C78B6794.Size = new System.Drawing.Size(281, 31);
		this.C78B6794.TabIndex = 168;
		this.txtAnh.Location = new System.Drawing.Point(136, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(140, 23);
		this.txtAnh.TabIndex = 155;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 6);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(137, 16);
		this.label16.TabIndex = 39;
		this.label16.Text = "Đường dẫn folder ảnh:";
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(8, 31);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(127, 20);
		this.ckbCommentText.TabIndex = 7;
		this.ckbCommentText.Text = "Bình luận văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(ckbCommentText_CheckedChanged);
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(8, 220);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		this.ckbSendAnh.TabIndex = 167;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(F08974A0);
		this.plCountComment.Controls.Add(this.DDA8A380);
		this.plCountComment.Controls.Add(this.B43EFBBB);
		this.plCountComment.Controls.Add(this.label14);
		this.plCountComment.Controls.Add(this.nudCountCommentTo);
		this.plCountComment.Location = new System.Drawing.Point(105, 3);
		this.plCountComment.Name = "plCountComment";
		this.plCountComment.Size = new System.Drawing.Size(195, 25);
		this.plCountComment.TabIndex = 41;
		this.DDA8A380.Location = new System.Drawing.Point(1, 1);
		this.DDA8A380.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DDA8A380.Name = "nudCountCommentFrom";
		this.DDA8A380.Size = new System.Drawing.Size(56, 23);
		this.DDA8A380.TabIndex = 1;
		this.B43EFBBB.AutoSize = true;
		this.B43EFBBB.Location = new System.Drawing.Point(157, 3);
		this.B43EFBBB.Name = "label13";
		this.B43EFBBB.Size = new System.Drawing.Size(24, 16);
		this.B43EFBBB.TabIndex = 35;
		this.B43EFBBB.Text = "lần";
		this.label14.Location = new System.Drawing.Point(63, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 37;
		this.label14.Text = "đê\u0301n";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountCommentTo.Name = "nudCountCommentTo";
		this.nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountCommentTo.TabIndex = 2;
		this.plCountShareWall.Controls.Add(this.A9057485);
		this.plCountShareWall.Controls.Add(this.label11);
		this.plCountShareWall.Controls.Add(this.label12);
		this.plCountShareWall.Controls.Add(this.nudCountShareTo);
		this.plCountShareWall.Location = new System.Drawing.Point(136, 162);
		this.plCountShareWall.Name = "plCountShareWall";
		this.plCountShareWall.Size = new System.Drawing.Size(195, 25);
		this.plCountShareWall.TabIndex = 40;
		this.A9057485.Location = new System.Drawing.Point(1, 1);
		this.A9057485.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A9057485.Name = "nudCountShareFrom";
		this.A9057485.Size = new System.Drawing.Size(56, 23);
		this.A9057485.TabIndex = 1;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(157, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(24, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "lần";
		this.label12.Location = new System.Drawing.Point(63, 3);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(29, 16);
		this.label12.TabIndex = 37;
		this.label12.Text = "đê\u0301n";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountShareTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountShareTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountShareTo.Name = "nudCountShareTo";
		this.nudCountShareTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountShareTo.TabIndex = 2;
		this.plCountLike.Controls.Add(this.AE143223);
		this.plCountLike.Controls.Add(this.label9);
		this.plCountLike.Controls.Add(this.label10);
		this.plCountLike.Controls.Add(this.DC2B6F92);
		this.plCountLike.Location = new System.Drawing.Point(136, 133);
		this.plCountLike.Name = "plCountLike";
		this.plCountLike.Size = new System.Drawing.Size(195, 25);
		this.plCountLike.TabIndex = 39;
		this.AE143223.Location = new System.Drawing.Point(1, 1);
		this.AE143223.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.AE143223.Name = "nudCountLikeFrom";
		this.AE143223.Size = new System.Drawing.Size(56, 23);
		this.AE143223.TabIndex = 1;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(157, 3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(24, 16);
		this.label9.TabIndex = 35;
		this.label9.Text = "lần";
		this.label10.Location = new System.Drawing.Point(63, 3);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 37;
		this.label10.Text = "đê\u0301n";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DC2B6F92.Location = new System.Drawing.Point(98, 1);
		this.DC2B6F92.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DC2B6F92.Name = "nudCountLikeTo";
		this.DC2B6F92.Size = new System.Drawing.Size(56, 23);
		this.DC2B6F92.TabIndex = 2;
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 193);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(81, 20);
		this.ckbComment.TabIndex = 7;
		this.ckbComment.Text = "Comment";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(DD31982E);
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(30, 164);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(89, 20);
		this.ckbShareWall.TabIndex = 6;
		this.ckbShareWall.Text = "Share Wall";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		this.CC298A13.AutoSize = true;
		this.CC298A13.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CC298A13.Location = new System.Drawing.Point(30, 135);
		this.CC298A13.Name = "ckbInteract";
		this.CC298A13.Size = new System.Drawing.Size(48, 20);
		this.CC298A13.TabIndex = 5;
		this.CC298A13.Text = "Like";
		this.CC298A13.UseVisualStyleBackColor = true;
		this.CC298A13.CheckedChanged += new System.EventHandler(CC298A13_CheckedChanged);
		this.A684EF87.Location = new System.Drawing.Point(234, 105);
		this.A684EF87.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.A684EF87.Name = "nudDelayTo";
		this.A684EF87.Size = new System.Drawing.Size(56, 23);
		this.A684EF87.TabIndex = 4;
		this.DF012A34.Location = new System.Drawing.Point(234, 77);
		this.DF012A34.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DF012A34.Name = "nudTimeTo";
		this.DF012A34.Size = new System.Drawing.Size(56, 23);
		this.DF012A34.TabIndex = 2;
		this.nudDelayFrom.Location = new System.Drawing.Point(137, 105);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.nudTimeFrom.Location = new System.Drawing.Point(137, 77);
		this.nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeFrom.Name = "nudTimeFrom";
		this.nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudTimeFrom.TabIndex = 1;
		this.A1330D30.Location = new System.Drawing.Point(137, 49);
		this.A1330D30.Name = "txtTenHanhDong";
		this.A1330D30.Size = new System.Drawing.Size(194, 23);
		this.A1330D30.TabIndex = 0;
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
		this.C33D138E.AutoSize = true;
		this.C33D138E.Location = new System.Drawing.Point(292, 79);
		this.C33D138E.Name = "label4";
		this.C33D138E.Size = new System.Drawing.Size(30, 16);
		this.C33D138E.TabIndex = 35;
		this.C33D138E.Text = "giây";
		this.FB07BA8D.AutoSize = true;
		this.FB07BA8D.Location = new System.Drawing.Point(27, 107);
		this.FB07BA8D.Name = "label5";
		this.FB07BA8D.Size = new System.Drawing.Size(110, 16);
		this.FB07BA8D.TabIndex = 34;
		this.FB07BA8D.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 79);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(91, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Thơ\u0300i gian lươ\u0301t:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.C01B3198.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C01B3198.BackColor = System.Drawing.Color.Maroon;
		this.C01B3198.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C01B3198.FlatAppearance.BorderSize = 0;
		this.C01B3198.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C01B3198.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C01B3198.ForeColor = System.Drawing.Color.White;
		this.C01B3198.Location = new System.Drawing.Point(195, 509);
		this.C01B3198.Name = "btnCancel";
		this.C01B3198.Size = new System.Drawing.Size(92, 29);
		this.C01B3198.TabIndex = 10;
		this.C01B3198.Text = "Đóng";
		this.C01B3198.UseVisualStyleBackColor = false;
		this.C01B3198.Click += new System.EventHandler(C01B3198_Click);
		this.C51DFD0A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C51DFD0A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C51DFD0A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C51DFD0A.FlatAppearance.BorderSize = 0;
		this.C51DFD0A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C51DFD0A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C51DFD0A.ForeColor = System.Drawing.Color.White;
		this.C51DFD0A.Location = new System.Drawing.Point(88, 509);
		this.C51DFD0A.Name = "btnAdd";
		this.C51DFD0A.Size = new System.Drawing.Size(92, 29);
		this.C51DFD0A.TabIndex = 9;
		this.C51DFD0A.Text = "Thêm";
		this.C51DFD0A.UseVisualStyleBackColor = false;
		this.C51DFD0A.Click += new System.EventHandler(BE194F06);
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
		this.bunifuCards1.Size = new System.Drawing.Size(373, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(376, 550);
		base.Controls.Add(this.BCA33B3C);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNewsfeed";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B99B3D07);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.BCA33B3C.ResumeLayout(false);
		this.BCA33B3C.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.C78B6794.ResumeLayout(false);
		this.C78B6794.PerformLayout();
		this.plCountComment.ResumeLayout(false);
		this.plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.DDA8A380).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
		this.plCountShareWall.ResumeLayout(false);
		this.plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.A9057485).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountShareTo).EndInit();
		this.plCountLike.ResumeLayout(false);
		this.plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.AE143223).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DC2B6F92).EndInit();
		((System.ComponentModel.ISupportInitialize)this.A684EF87).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DF012A34).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
