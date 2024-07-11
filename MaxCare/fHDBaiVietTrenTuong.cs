using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBaiVietTrenTuong : Form
{
	private JSON_Settings A334740A;

	private string string_0;

	private string string_1;

	private string string_2;

	private int C53290BC;

	public static bool bool_0;

	private IContainer E835FE19 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown F4AC8D38;

	private NumericUpDown EE83BA3C;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label6;

	private Label label4;

	private Label F83779BB;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button C83A1C07;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plCommentText;

	private Label FBB27191;

	private CheckBox ckbComment;

	private CheckBox A1A73111;

	private RichTextBox E7BAC803;

	private Button btnDown;

	private Button btnUp;

	private RadioButton A43CDDA1;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private Label label8;

	private Button CDABE32F;

	private Button button3;

	private Button button4;

	private LinkLabel linkLabel1;

	private Panel plComment;

	private CheckBox ckbCommentText;

	private CheckBox DD18D3A6;

	private Panel plAnh;

	private TextBox txtAnh;

	private Label label16;

	public fHDBaiVietTrenTuong(string ADAD9FAA, int int_0 = 0, string CB11438C = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = ADAD9FAA;
		string_2 = CB11438C;
		C53290BC = int_0;
		if (InteractSQL.B484648C("", "HDBaiVietTrenTuong").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBaiVietTrenTuong', '{  \"nudTimeFrom\": \"10\",  \"nudTimeTo\": \"30\",  \"nudDelayFrom\": \"2\",  \"nudDelayTo\": \"3\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết trên tường');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietTrenTuong");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(CB11438C);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			C83A1C07.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A334740A = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void E5B0C283()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(label4);
		Language.smethod_0(F83779BB);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(ckbComment);
		Language.smethod_0(FBB27191);
		Language.smethod_0(CDABE32F);
		Language.smethod_0(label8);
		Language.smethod_0(C83A1C07);
		Language.smethod_0(btnCancel);
	}

	private void D8ABF439(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = A334740A.GetValueInt("nudSoLuongFrom", 3);
			EE83BA3C.Value = A334740A.GetValueInt("nudSoLuongTo", 5);
			nudDelayFrom.Value = A334740A.GetValueInt("nudDelayFrom", 5);
			F4AC8D38.Value = A334740A.GetValueInt("nudDelayTo", 7);
			A1A73111.Checked = A334740A.GetValueBool("ckbInteract");
			ckbComment.Checked = A334740A.GetValueBool("ckbComment");
			ckbCommentText.Checked = A334740A.GetValueBool("ckbCommentText");
			E7BAC803.Text = A334740A.GetValue("txtComment");
			if (A334740A.GetValueInt("typeNganCach") == 1)
			{
				A43CDDA1.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			DD18D3A6.Checked = A334740A.GetValueBool("ckbSendAnh");
			txtAnh.Text = A334740A.GetValue("txtAnh");
		}
		catch
		{
		}
		ABB9BD84();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CD017931(object sender, EventArgs e)
	{
		if (C53290BC == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") != DialogResult.Yes)
			{
				return;
			}
			string text = txtTenHanhDong.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> a2AB53A = E7BAC803.Lines.ToList();
				a2AB53A = Common.RemoveEmptyItems(a2AB53A);
				if (a2AB53A.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass = new JSON_Settings();
			gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
			gClass.GetJson("nudSoLuongTo", EE83BA3C.Value);
			gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass.GetJson("nudDelayTo", F4AC8D38.Value);
			gClass.GetJson("ckbInteract", A1A73111.Checked);
			gClass.GetJson("ckbComment", ckbComment.Checked);
			gClass.GetJson("ckbCommentText", ckbCommentText.Checked);
			gClass.GetJson("txtComment", E7BAC803.Text.Trim());
			int num = 0;
			if (A43CDDA1.Checked)
			{
				num = 1;
			}
			gClass.GetJson("typeNganCach", num);
			gClass.GetJson("ckbSendAnh", DD18D3A6.Checked);
			gClass.GetJson("txtAnh", txtAnh.Text.Trim());
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(string_0, text, string_1, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		else
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") != DialogResult.Yes)
			{
				return;
			}
			string text2 = txtTenHanhDong.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> a2AB53A2 = E7BAC803.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
			gClass2.GetJson("nudSoLuongTo", EE83BA3C.Value);
			gClass2.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass2.GetJson("nudDelayTo", F4AC8D38.Value);
			gClass2.GetJson("ckbInteract", A1A73111.Checked);
			gClass2.GetJson("ckbComment", ckbComment.Checked);
			gClass2.GetJson("ckbCommentText", ckbCommentText.Checked);
			gClass2.GetJson("txtComment", E7BAC803.Text.Trim());
			int num2 = 0;
			if (A43CDDA1.Checked)
			{
				num2 = 1;
			}
			gClass2.GetJson("typeNganCach", num2);
			gClass2.GetJson("ckbSendAnh", DD18D3A6.Checked);
			gClass2.GetJson("txtAnh", txtAnh.Text.Trim());
			string text3 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(string_2, text2, text3))
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

	private void A1B0CA33(object sender, EventArgs e)
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

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = E7BAC803.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			FBB27191.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void ABB9BD84()
	{
		method_2(null, null);
		ckbComment_CheckedChanged(null, null);
		ED24EDBE(null, null);
		DC198402(null, null);
		DD18D3A6_CheckedChanged(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void DFB2C006(object sender, EventArgs e)
	{
		FD195F9A();
	}

	private void FD195F9A()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? E7BAC803.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : E7BAC803.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			FBB27191.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void AE99A2A6(object sender, EventArgs e)
	{
		plCommentText.Height = 207;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 165;
	}

	private void ED24EDBE(object sender, EventArgs e)
	{
		FD195F9A();
	}

	private void C922B392(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void BA3E243F(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		E7BAC803.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		E7BAC803.Focus();
	}

	private void BD29408E(object sender, PaintEventArgs e)
	{
	}

	private void EE2AB8AA(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void C9216D1D(object sender, PaintEventArgs e)
	{
	}

	private void DC198402(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
	}

	private void DD18D3A6_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = DD18D3A6.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && E835FE19 != null)
		{
			E835FE19.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.E835FE19 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietTrenTuong));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.E835FE19);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.E835FE19);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.plComment = new System.Windows.Forms.Panel();
		this.plCommentText = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.button3 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.CDABE32F = new System.Windows.Forms.Button();
		this.E7BAC803 = new System.Windows.Forms.RichTextBox();
		this.btnDown = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.A43CDDA1 = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.FBB27191 = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.DD18D3A6 = new System.Windows.Forms.CheckBox();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.A1A73111 = new System.Windows.Forms.CheckBox();
		this.F4AC8D38 = new System.Windows.Forms.NumericUpDown();
		this.EE83BA3C = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.F83779BB = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.C83A1C07 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plCommentText.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.F4AC8D38).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EE83BA3C).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
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
		this.bunifuCustomLabel1.Text = "Cấu hình Bài viết trên tường";
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
		this.pictureBox1.Click += new System.EventHandler(C922B392);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.A1A73111);
		this.panel1.Controls.Add(this.F4AC8D38);
		this.panel1.Controls.Add(this.EE83BA3C);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.F83779BB);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.C83A1C07);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(362, 504);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.plCommentText);
		this.plComment.Controls.Add(this.plAnh);
		this.plComment.Controls.Add(this.DD18D3A6);
		this.plComment.Controls.Add(this.ckbCommentText);
		this.plComment.Location = new System.Drawing.Point(30, 191);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(306, 262);
		this.plComment.TabIndex = 39;
		this.plComment.Paint += new System.Windows.Forms.PaintEventHandler(C9216D1D);
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.linkLabel1);
		this.plCommentText.Controls.Add(this.button3);
		this.plCommentText.Controls.Add(this.button4);
		this.plCommentText.Controls.Add(this.CDABE32F);
		this.plCommentText.Controls.Add(this.E7BAC803);
		this.plCommentText.Controls.Add(this.btnDown);
		this.plCommentText.Controls.Add(this.btnUp);
		this.plCommentText.Controls.Add(this.A43CDDA1);
		this.plCommentText.Controls.Add(this.rbNganCachMoiDong);
		this.plCommentText.Controls.Add(this.label9);
		this.plCommentText.Controls.Add(this.label8);
		this.plCommentText.Controls.Add(this.FBB27191);
		this.plCommentText.Location = new System.Drawing.Point(24, 29);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(278, 164);
		this.plCommentText.TabIndex = 8;
		this.plCommentText.Paint += new System.Windows.Forms.PaintEventHandler(BD29408E);
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(163, 142);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 176;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(EE2AB8AA);
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(227, 185);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 127;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(227, 162);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 128;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.CDABE32F.Cursor = System.Windows.Forms.Cursors.Help;
		this.CDABE32F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CDABE32F.Location = new System.Drawing.Point(247, 139);
		this.CDABE32F.Name = "button2";
		this.CDABE32F.Size = new System.Drawing.Size(23, 23);
		this.CDABE32F.TabIndex = 126;
		this.CDABE32F.Text = "?";
		this.CDABE32F.UseVisualStyleBackColor = true;
		this.CDABE32F.Click += new System.EventHandler(BA3E243F);
		this.E7BAC803.Location = new System.Drawing.Point(7, 27);
		this.E7BAC803.Name = "txtComment";
		this.E7BAC803.Size = new System.Drawing.Size(263, 111);
		this.E7BAC803.TabIndex = 114;
		this.E7BAC803.Text = "";
		this.E7BAC803.WordWrap = false;
		this.E7BAC803.TextChanged += new System.EventHandler(DFB2C006);
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(221, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 112;
		this.btnDown.Click += new System.EventHandler(AE99A2A6);
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(252, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 113;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.A43CDDA1.AutoSize = true;
		this.A43CDDA1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A43CDDA1.Location = new System.Drawing.Point(68, 182);
		this.A43CDDA1.Name = "rbNganCachKyTu";
		this.A43CDDA1.Size = new System.Drawing.Size(159, 20);
		this.A43CDDA1.TabIndex = 111;
		this.A43CDDA1.Text = "Nội dung có nhiều dòng";
		this.A43CDDA1.UseVisualStyleBackColor = true;
		this.A43CDDA1.CheckedChanged += new System.EventHandler(ED24EDBE);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(68, 161);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		this.rbNganCachMoiDong.TabIndex = 110;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(ED24EDBE);
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(3, 161);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 109;
		this.label9.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(3, 142);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(143, 16);
		this.label8.TabIndex = 107;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.FBB27191.AutoSize = true;
		this.FBB27191.Location = new System.Drawing.Point(4, 4);
		this.FBB27191.Name = "lblStatus";
		this.FBB27191.Size = new System.Drawing.Size(139, 16);
		this.FBB27191.TabIndex = 0;
		this.FBB27191.Text = "Nội dung bình luận (0):";
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.label16);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(21, 223);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(281, 31);
		this.plAnh.TabIndex = 169;
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
		this.DD18D3A6.AutoSize = true;
		this.DD18D3A6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD18D3A6.Location = new System.Drawing.Point(4, 199);
		this.DD18D3A6.Name = "ckbSendAnh";
		this.DD18D3A6.Size = new System.Drawing.Size(103, 20);
		this.DD18D3A6.TabIndex = 10;
		this.DD18D3A6.Text = "Bình luận ảnh";
		this.DD18D3A6.UseVisualStyleBackColor = true;
		this.DD18D3A6.CheckedChanged += new System.EventHandler(DD18D3A6_CheckedChanged);
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(4, 4);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(127, 20);
		this.ckbCommentText.TabIndex = 9;
		this.ckbCommentText.Text = "Bình luận văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(DC198402);
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 165);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(130, 20);
		this.ckbComment.TabIndex = 7;
		this.ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.A1A73111.AutoSize = true;
		this.A1A73111.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A1A73111.Location = new System.Drawing.Point(30, 141);
		this.A1A73111.Name = "ckbInteract";
		this.A1A73111.Size = new System.Drawing.Size(48, 20);
		this.A1A73111.TabIndex = 5;
		this.A1A73111.Text = "Like";
		this.A1A73111.UseVisualStyleBackColor = true;
		this.F4AC8D38.Location = new System.Drawing.Point(229, 111);
		this.F4AC8D38.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F4AC8D38.Name = "nudDelayTo";
		this.F4AC8D38.Size = new System.Drawing.Size(56, 23);
		this.F4AC8D38.TabIndex = 4;
		this.EE83BA3C.Location = new System.Drawing.Point(229, 80);
		this.EE83BA3C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.EE83BA3C.Name = "nudSoLuongTo";
		this.EE83BA3C.Size = new System.Drawing.Size(56, 23);
		this.EE83BA3C.TabIndex = 2;
		this.nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(194, 113);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Location = new System.Drawing.Point(194, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(290, 113);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 82);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0300i";
		this.F83779BB.AutoSize = true;
		this.F83779BB.Location = new System.Drawing.Point(27, 113);
		this.F83779BB.Name = "label5";
		this.F83779BB.Size = new System.Drawing.Size(89, 16);
		this.F83779BB.TabIndex = 34;
		this.F83779BB.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(108, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0300i viê\u0301t:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(189, 461);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(A1B0CA33);
		this.C83A1C07.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C83A1C07.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C83A1C07.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C83A1C07.FlatAppearance.BorderSize = 0;
		this.C83A1C07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C83A1C07.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C83A1C07.ForeColor = System.Drawing.Color.White;
		this.C83A1C07.Location = new System.Drawing.Point(82, 461);
		this.C83A1C07.Name = "btnAdd";
		this.C83A1C07.Size = new System.Drawing.Size(92, 29);
		this.C83A1C07.TabIndex = 9;
		this.C83A1C07.Text = "Thêm";
		this.C83A1C07.UseVisualStyleBackColor = false;
		this.C83A1C07.Click += new System.EventHandler(CD017931);
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
		base.ClientSize = new System.Drawing.Size(362, 504);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietTrenTuong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D8ABF439);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.F4AC8D38).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EE83BA3C).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
