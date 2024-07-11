using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDTuongTacBaiVietNhomv2 : Form
{
	private JSON_Settings B8A16E12 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl D017E619;

	private Panel F39EC83F;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown AC36E027;

	private TextBox txtTenHanhDong;

	private Label DA932A90;

	private Label A83E8C93;

	private Label label6;

	private Label CC3AFF8E;

	private Label D223190E;

	private Label CE2A9D8F;

	private Label CD961C22;

	private Button btnCancel;

	private Button E3AA0509;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox B8262094;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox F638433B;

	private Panel plCountComment;

	private NumericUpDown nudCountCommentFrom;

	private Label label13;

	private Label label14;

	private NumericUpDown D69FD8A9;

	private Panel B01A39A1;

	private RichTextBox txtComment;

	private Button FE0AB794;

	private Button btnUp;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label F3379A9C;

	private Label B3A82BBE;

	private Label lblStatus;

	private Panel panel3;

	private NumericUpDown nudCountLikeFrom;

	private Label label11;

	private Label label12;

	private NumericUpDown nudCountLikeTo;

	private CheckBox FDA9B206;

	private Panel plInteract;

	private CheckBox B83AAC09;

	private CheckBox ckbSad;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox E703BE0B;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	private Panel DAAD60BE;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label label26;

	public fHDTuongTacBaiVietNhomv2(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDTuongTacBaiVietNhomv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietNhomv2', 'Tương tác Bài viết nhóm v2');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTuongTacBaiVietNhomv2");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			E3AA0509.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B8A16E12 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
		list_0 = new List<CheckBox> { ckbLike, ckbLove, E703BE0B, ckbHaha, ckbWow, ckbSad, B83AAC09 };
	}

	private void fHDTuongTacBaiVietNhomv2_Load(object sender, EventArgs e)
	{
		try
		{
			AC36E027.Value = B8A16E12.GetValueInt("nudTimeFrom", 10);
			nudTimeTo.Value = B8A16E12.GetValueInt("nudTimeTo", 30);
			nudDelayFrom.Value = B8A16E12.GetValueInt("nudDelayFrom", 1);
			nudDelayTo.Value = B8A16E12.GetValueInt("nudDelayTo", 3);
			nudCountLikeFrom.Value = B8A16E12.GetValueInt("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = B8A16E12.GetValueInt("nudCountLikeTo", 3);
			nudCountCommentFrom.Value = B8A16E12.GetValueInt("nudCountCommentFrom", 1);
			D69FD8A9.Value = B8A16E12.GetValueInt("nudCountCommentTo", 3);
			FDA9B206.Checked = B8A16E12.GetValueBool("ckbInteract");
			F638433B.Checked = B8A16E12.GetValueBool("ckbComment");
			txtComment.Text = B8A16E12.GetValue("txtComment");
			List<string> list = B8A16E12.GetValue("typeReaction", "Like|Love").Split('|').ToList();
			for (int i = 0; i < list.Count; i++)
			{
				foreach (CheckBox item in list_0)
				{
					if (item.Name.Substring(3) == list[i])
					{
						item.Checked = true;
					}
				}
			}
			if (B8A16E12.GetValueInt("typeNganCach") == 1)
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
		C1B9D5AC();
	}

	private void C41BF230(object sender, EventArgs e)
	{
		Close();
	}

	private void BBA1B08C(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (F638433B.Checked)
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
		gClass.GetJson("nudTimeFrom", AC36E027.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbInteract", FDA9B206.Checked);
		gClass.GetJson("ckbComment", F638433B.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("nudCountLikeFrom", nudCountLikeFrom.Value);
		gClass.GetJson("nudCountLikeTo", nudCountLikeTo.Value);
		gClass.GetJson("nudCountCommentFrom", nudCountCommentFrom.Value);
		gClass.GetJson("nudCountCommentTo", D69FD8A9.Value);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + list_0[i].Name.Substring(3) + "|";
			}
		}
		gClass.GetJson("typeReaction", text2.TrimEnd('|'));
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
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
		}
		else if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_2, text, string_))
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

	private void F39EC83F_Paint(object sender, PaintEventArgs e)
	{
		if (F39EC83F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F39EC83F.ClientSize.Width - num, F39EC83F.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void C1B9D5AC()
	{
		FDA9B206_CheckedChanged(null, null);
		A3097583(null, null);
	}

	private void FDA9B206_CheckedChanged(object sender, EventArgs e)
	{
		panel3.Enabled = FDA9B206.Checked;
		plInteract.Enabled = FDA9B206.Checked;
	}

	private void A3097583(object sender, EventArgs e)
	{
		plCountComment.Enabled = F638433B.Checked;
		B01A39A1.Enabled = F638433B.Checked;
	}

	private void FE0AB794_Click(object sender, EventArgs e)
	{
		B01A39A1.Height = 207;
	}

	private void A8B3530C(object sender, EventArgs e)
	{
		B01A39A1.Height = 163;
	}

	private void B8262094_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			FE0AB794.Visible = true;
		}
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	protected override void Dispose(bool E3238B89)
	{
		if (E3238B89 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E3238B89);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.D017E619 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.B8262094 = new System.Windows.Forms.PictureBox();
		this.F39EC83F = new System.Windows.Forms.Panel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		this.FDA9B206 = new System.Windows.Forms.CheckBox();
		this.B01A39A1 = new System.Windows.Forms.Panel();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.FE0AB794 = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.F3379A9C = new System.Windows.Forms.Label();
		this.B3A82BBE = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plCountComment = new System.Windows.Forms.Panel();
		this.nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.D69FD8A9 = new System.Windows.Forms.NumericUpDown();
		this.F638433B = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.AC36E027 = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.DA932A90 = new System.Windows.Forms.Label();
		this.A83E8C93 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.CC3AFF8E = new System.Windows.Forms.Label();
		this.D223190E = new System.Windows.Forms.Label();
		this.CE2A9D8F = new System.Windows.Forms.Label();
		this.CD961C22 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.E3AA0509 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.plInteract = new System.Windows.Forms.Panel();
		this.B83AAC09 = new System.Windows.Forms.CheckBox();
		this.ckbSad = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.E703BE0B = new System.Windows.Forms.CheckBox();
		this.ckbLove = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.DAAD60BE = new System.Windows.Forms.Panel();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.radioButton4 = new System.Windows.Forms.RadioButton();
		this.label26 = new System.Windows.Forms.Label();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.B8262094).BeginInit();
		this.F39EC83F.SuspendLayout();
		this.panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
		this.B01A39A1.SuspendLayout();
		this.plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D69FD8A9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.AC36E027).BeginInit();
		this.bunifuCards1.SuspendLayout();
		this.plInteract.SuspendLayout();
		this.DAAD60BE.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(399, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Bài viết nhóm v2";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D017E619.Fixed = true;
		this.D017E619.Horizontal = true;
		this.D017E619.TargetControl = this.pnlHeader;
		this.D017E619.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.B8262094);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(399, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.A13F2207;
		this.button1.Location = new System.Drawing.Point(368, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(C41BF230);
		this.B8262094.Cursor = System.Windows.Forms.Cursors.Default;
		this.B8262094.Image = Resources.Bitmap_4;
		this.B8262094.Location = new System.Drawing.Point(3, 2);
		this.B8262094.Name = "pictureBox1";
		this.B8262094.Size = new System.Drawing.Size(34, 27);
		this.B8262094.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.B8262094.TabIndex = 76;
		this.B8262094.TabStop = false;
		this.B8262094.Click += new System.EventHandler(B8262094_Click);
		this.F39EC83F.BackColor = System.Drawing.Color.White;
		this.F39EC83F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F39EC83F.Controls.Add(this.plInteract);
		this.F39EC83F.Controls.Add(this.panel3);
		this.F39EC83F.Controls.Add(this.FDA9B206);
		this.F39EC83F.Controls.Add(this.B01A39A1);
		this.F39EC83F.Controls.Add(this.plCountComment);
		this.F39EC83F.Controls.Add(this.F638433B);
		this.F39EC83F.Controls.Add(this.nudDelayTo);
		this.F39EC83F.Controls.Add(this.nudTimeTo);
		this.F39EC83F.Controls.Add(this.nudDelayFrom);
		this.F39EC83F.Controls.Add(this.AC36E027);
		this.F39EC83F.Controls.Add(this.txtTenHanhDong);
		this.F39EC83F.Controls.Add(this.DA932A90);
		this.F39EC83F.Controls.Add(this.A83E8C93);
		this.F39EC83F.Controls.Add(this.label6);
		this.F39EC83F.Controls.Add(this.CC3AFF8E);
		this.F39EC83F.Controls.Add(this.D223190E);
		this.F39EC83F.Controls.Add(this.CE2A9D8F);
		this.F39EC83F.Controls.Add(this.CD961C22);
		this.F39EC83F.Controls.Add(this.btnCancel);
		this.F39EC83F.Controls.Add(this.E3AA0509);
		this.F39EC83F.Controls.Add(this.bunifuCards1);
		this.F39EC83F.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.F39EC83F.Dock = System.Windows.Forms.DockStyle.Fill;
		this.F39EC83F.Location = new System.Drawing.Point(0, 0);
		this.F39EC83F.Name = "panel1";
		this.F39EC83F.Size = new System.Drawing.Size(402, 452);
		this.F39EC83F.TabIndex = 0;
		this.F39EC83F.Paint += new System.Windows.Forms.PaintEventHandler(F39EC83F_Paint);
		this.panel3.Controls.Add(this.nudCountLikeFrom);
		this.panel3.Controls.Add(this.label11);
		this.panel3.Controls.Add(this.label12);
		this.panel3.Controls.Add(this.nudCountLikeTo);
		this.panel3.Location = new System.Drawing.Point(136, 132);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(195, 25);
		this.panel3.TabIndex = 45;
		this.nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		this.nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeFrom.Name = "nudCountLikeFrom";
		this.nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeFrom.TabIndex = 1;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(157, 3);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(24, 16);
		this.label11.TabIndex = 35;
		this.label11.Text = "lần";
		this.label12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label12.Location = new System.Drawing.Point(63, 3);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(29, 16);
		this.label12.TabIndex = 37;
		this.label12.Text = ">";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		this.nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountLikeTo.Name = "nudCountLikeTo";
		this.nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountLikeTo.TabIndex = 2;
		this.FDA9B206.AutoSize = true;
		this.FDA9B206.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FDA9B206.Location = new System.Drawing.Point(30, 134);
		this.FDA9B206.Name = "ckbInteract";
		this.FDA9B206.Size = new System.Drawing.Size(104, 20);
		this.FDA9B206.TabIndex = 44;
		this.FDA9B206.Text = "Thả cảm xúc:";
		this.FDA9B206.UseVisualStyleBackColor = true;
		this.FDA9B206.CheckedChanged += new System.EventHandler(FDA9B206_CheckedChanged);
		this.B01A39A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.B01A39A1.Controls.Add(this.txtComment);
		this.B01A39A1.Controls.Add(this.FE0AB794);
		this.B01A39A1.Controls.Add(this.btnUp);
		this.B01A39A1.Controls.Add(this.rbNganCachKyTu);
		this.B01A39A1.Controls.Add(this.rbNganCachMoiDong);
		this.B01A39A1.Controls.Add(this.F3379A9C);
		this.B01A39A1.Controls.Add(this.B3A82BBE);
		this.B01A39A1.Controls.Add(this.lblStatus);
		this.B01A39A1.Location = new System.Drawing.Point(50, 228);
		this.B01A39A1.Name = "plComment";
		this.B01A39A1.Size = new System.Drawing.Size(312, 163);
		this.B01A39A1.TabIndex = 42;
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(297, 111);
		this.txtComment.TabIndex = 106;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.FE0AB794.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.FE0AB794.BackgroundImage = Resources.Bitmap_83;
		this.FE0AB794.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FE0AB794.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.FE0AB794.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FE0AB794.Location = new System.Drawing.Point(255, -1);
		this.FE0AB794.Name = "btnDown";
		this.FE0AB794.Size = new System.Drawing.Size(25, 25);
		this.FE0AB794.TabIndex = 7;
		this.FE0AB794.Visible = false;
		this.FE0AB794.Click += new System.EventHandler(FE0AB794_Click);
		this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(286, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 7;
		this.btnUp.Visible = false;
		this.btnUp.Click += new System.EventHandler(A8B3530C);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(202, 20);
		this.rbNganCachKyTu.TabIndex = 6;
		this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(170, 20);
		this.rbNganCachMoiDong.TabIndex = 5;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		this.F3379A9C.AutoSize = true;
		this.F3379A9C.Location = new System.Drawing.Point(4, 161);
		this.F3379A9C.Name = "label8";
		this.F3379A9C.Size = new System.Drawing.Size(64, 16);
		this.F3379A9C.TabIndex = 4;
		this.F3379A9C.Text = "Tùy chọn:";
		this.B3A82BBE.AutoSize = true;
		this.B3A82BBE.Location = new System.Drawing.Point(4, 141);
		this.B3A82BBE.Name = "label15";
		this.B3A82BBE.Size = new System.Drawing.Size(265, 16);
		this.B3A82BBE.TabIndex = 0;
		this.B3A82BBE.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.plCountComment.Controls.Add(this.nudCountCommentFrom);
		this.plCountComment.Controls.Add(this.label13);
		this.plCountComment.Controls.Add(this.label14);
		this.plCountComment.Controls.Add(this.D69FD8A9);
		this.plCountComment.Location = new System.Drawing.Point(136, 199);
		this.plCountComment.Name = "plCountComment";
		this.plCountComment.Size = new System.Drawing.Size(195, 25);
		this.plCountComment.TabIndex = 41;
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
		this.label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(63, 3);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 37;
		this.label14.Text = ">";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D69FD8A9.Location = new System.Drawing.Point(98, 1);
		this.D69FD8A9.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D69FD8A9.Name = "nudCountCommentTo";
		this.D69FD8A9.Size = new System.Drawing.Size(56, 23);
		this.D69FD8A9.TabIndex = 2;
		this.F638433B.AutoSize = true;
		this.F638433B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F638433B.Location = new System.Drawing.Point(30, 201);
		this.F638433B.Name = "ckbComment";
		this.F638433B.Size = new System.Drawing.Size(81, 20);
		this.F638433B.TabIndex = 7;
		this.F638433B.Text = "Comment";
		this.F638433B.UseVisualStyleBackColor = true;
		this.F638433B.CheckedChanged += new System.EventHandler(A3097583);
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
		this.nudDelayFrom.Location = new System.Drawing.Point(137, 105);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.AC36E027.Location = new System.Drawing.Point(137, 77);
		this.AC36E027.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.AC36E027.Name = "nudTimeFrom";
		this.AC36E027.Size = new System.Drawing.Size(56, 23);
		this.AC36E027.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.DA932A90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DA932A90.Location = new System.Drawing.Point(199, 107);
		this.DA932A90.Name = "label7";
		this.DA932A90.Size = new System.Drawing.Size(29, 16);
		this.DA932A90.TabIndex = 38;
		this.DA932A90.Text = ">";
		this.DA932A90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A83E8C93.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A83E8C93.Location = new System.Drawing.Point(199, 79);
		this.A83E8C93.Name = "label3";
		this.A83E8C93.Size = new System.Drawing.Size(29, 16);
		this.A83E8C93.TabIndex = 37;
		this.A83E8C93.Text = ">";
		this.A83E8C93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(292, 107);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.CC3AFF8E.AutoSize = true;
		this.CC3AFF8E.Location = new System.Drawing.Point(292, 79);
		this.CC3AFF8E.Name = "label4";
		this.CC3AFF8E.Size = new System.Drawing.Size(30, 16);
		this.CC3AFF8E.TabIndex = 35;
		this.CC3AFF8E.Text = "giây";
		this.D223190E.AutoSize = true;
		this.D223190E.Location = new System.Drawing.Point(27, 107);
		this.D223190E.Name = "label5";
		this.D223190E.Size = new System.Drawing.Size(110, 16);
		this.D223190E.TabIndex = 34;
		this.D223190E.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		this.CE2A9D8F.AutoSize = true;
		this.CE2A9D8F.Location = new System.Drawing.Point(27, 79);
		this.CE2A9D8F.Name = "label2";
		this.CE2A9D8F.Size = new System.Drawing.Size(91, 16);
		this.CE2A9D8F.TabIndex = 32;
		this.CE2A9D8F.Text = "Thơ\u0300i gian lươ\u0301t:";
		this.CD961C22.AutoSize = true;
		this.CD961C22.Location = new System.Drawing.Point(27, 52);
		this.CD961C22.Name = "label1";
		this.CD961C22.Size = new System.Drawing.Size(98, 16);
		this.CD961C22.TabIndex = 31;
		this.CD961C22.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(210, 411);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.E3AA0509.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.E3AA0509.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.E3AA0509.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E3AA0509.FlatAppearance.BorderSize = 0;
		this.E3AA0509.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E3AA0509.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E3AA0509.ForeColor = System.Drawing.Color.White;
		this.E3AA0509.Location = new System.Drawing.Point(103, 411);
		this.E3AA0509.Name = "btnAdd";
		this.E3AA0509.Size = new System.Drawing.Size(92, 29);
		this.E3AA0509.TabIndex = 9;
		this.E3AA0509.Text = "Thêm";
		this.E3AA0509.UseVisualStyleBackColor = false;
		this.E3AA0509.Click += new System.EventHandler(BBA1B08C);
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
		this.bunifuCards1.Size = new System.Drawing.Size(399, 37);
		this.bunifuCards1.TabIndex = 28;
		this.plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plInteract.Controls.Add(this.B83AAC09);
		this.plInteract.Controls.Add(this.ckbSad);
		this.plInteract.Controls.Add(this.ckbWow);
		this.plInteract.Controls.Add(this.ckbHaha);
		this.plInteract.Controls.Add(this.E703BE0B);
		this.plInteract.Controls.Add(this.ckbLove);
		this.plInteract.Controls.Add(this.ckbLike);
		this.plInteract.Controls.Add(this.DAAD60BE);
		this.plInteract.Controls.Add(this.label26);
		this.plInteract.Location = new System.Drawing.Point(50, 160);
		this.plInteract.Name = "plInteract";
		this.plInteract.Size = new System.Drawing.Size(312, 33);
		this.plInteract.TabIndex = 181;
		this.B83AAC09.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B83AAC09.Image = Resources.Bitmap_7;
		this.B83AAC09.Location = new System.Drawing.Point(266, 1);
		this.B83AAC09.Name = "ckbAngry";
		this.B83AAC09.Size = new System.Drawing.Size(40, 30);
		this.B83AAC09.TabIndex = 179;
		this.B83AAC09.Tag = "Angry";
		this.B83AAC09.UseVisualStyleBackColor = true;
		this.ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSad.Image = Resources.Bitmap_167;
		this.ckbSad.Location = new System.Drawing.Point(222, 1);
		this.ckbSad.Name = "ckbSad";
		this.ckbSad.Size = new System.Drawing.Size(40, 30);
		this.ckbSad.TabIndex = 178;
		this.ckbSad.Tag = "Sad";
		this.ckbSad.UseVisualStyleBackColor = true;
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Image = Resources.BBAD6B14;
		this.ckbWow.Location = new System.Drawing.Point(178, 1);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(40, 30);
		this.ckbWow.TabIndex = 177;
		this.ckbWow.Tag = "Wow";
		this.ckbWow.UseVisualStyleBackColor = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Image = Resources.Bitmap_34;
		this.ckbHaha.Location = new System.Drawing.Point(134, 1);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(40, 30);
		this.ckbHaha.TabIndex = 176;
		this.ckbHaha.Tag = "Haha";
		this.ckbHaha.UseVisualStyleBackColor = true;
		this.E703BE0B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E703BE0B.Image = Resources.Bitmap_14;
		this.E703BE0B.Location = new System.Drawing.Point(90, 1);
		this.E703BE0B.Name = "ckbCare";
		this.E703BE0B.Size = new System.Drawing.Size(40, 30);
		this.E703BE0B.TabIndex = 175;
		this.E703BE0B.Tag = "Care";
		this.E703BE0B.UseVisualStyleBackColor = true;
		this.ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLove.Image = Resources.Bitmap_154;
		this.ckbLove.Location = new System.Drawing.Point(46, 1);
		this.ckbLove.Name = "ckbLove";
		this.ckbLove.Size = new System.Drawing.Size(40, 30);
		this.ckbLove.TabIndex = 174;
		this.ckbLove.Tag = "Love";
		this.ckbLove.UseVisualStyleBackColor = true;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Image = Resources.B41E983E;
		this.ckbLike.Location = new System.Drawing.Point(2, 1);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(40, 30);
		this.ckbLike.TabIndex = 173;
		this.ckbLike.Tag = "Like";
		this.ckbLike.UseVisualStyleBackColor = true;
		this.DAAD60BE.Controls.Add(this.radioButton3);
		this.DAAD60BE.Controls.Add(this.radioButton4);
		this.DAAD60BE.Location = new System.Drawing.Point(67, 300);
		this.DAAD60BE.Name = "panel7";
		this.DAAD60BE.Size = new System.Drawing.Size(200, 43);
		this.DAAD60BE.TabIndex = 43;
		this.radioButton3.AutoSize = true;
		this.radioButton3.Checked = true;
		this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton3.Location = new System.Drawing.Point(3, 2);
		this.radioButton3.Name = "radioButton3";
		this.radioButton3.Size = new System.Drawing.Size(201, 20);
		this.radioButton3.TabIndex = 3;
		this.radioButton3.TabStop = true;
		this.radioButton3.Text = "Comment theo thứ tự nội dung";
		this.radioButton3.UseVisualStyleBackColor = true;
		this.radioButton4.AutoSize = true;
		this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton4.Location = new System.Drawing.Point(3, 23);
		this.radioButton4.Name = "radioButton4";
		this.radioButton4.Size = new System.Drawing.Size(200, 20);
		this.radioButton4.TabIndex = 3;
		this.radioButton4.Text = "Comment ngẫu nhiên nội dung";
		this.radioButton4.UseVisualStyleBackColor = true;
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(4, 302);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(64, 16);
		this.label26.TabIndex = 2;
		this.label26.Text = "Tùy chọn:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(402, 452);
		base.Controls.Add(this.F39EC83F);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBaiVietNhomv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacBaiVietNhomv2_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.B8262094).EndInit();
		this.F39EC83F.ResumeLayout(false);
		this.F39EC83F.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
		this.B01A39A1.ResumeLayout(false);
		this.B01A39A1.PerformLayout();
		this.plCountComment.ResumeLayout(false);
		this.plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D69FD8A9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.AC36E027).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		this.plInteract.ResumeLayout(false);
		this.plInteract.PerformLayout();
		this.DAAD60BE.ResumeLayout(false);
		this.DAAD60BE.PerformLayout();
		base.ResumeLayout(false);
	}
}
