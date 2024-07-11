using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDTuongTacNhomv2 : Form
{
	private JSON_Settings C31B6C2B;

	private string F7B5CDAC;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool BA31D2B1;

	private List<CheckBox> DC24B788;

	private IContainer icontainer_0 = null;

	private BunifuDragControl D78067AA;

	private BunifuDragControl BC14F886;

	private Panel C63B988E;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F7895227;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label C6B0380D;

	private Label label1;

	private Button AC98ECAD;

	private Button btnAdd;

	private BunifuCards A6982D3B;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox A0911CB2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown FC953F97;

	private Label label9;

	private Label CE2AEF8A;

	private Panel plComment;

	private RichTextBox txtComment;

	private Label lblComment;

	private CheckBox ckbComment;

	private Panel C4294ABC;

	private CheckBox ckbAngry;

	private CheckBox ckbSad;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label CD0F350E;

	private NumericUpDown AB3140AD;

	private NumericUpDown FC16B383;

	private Label AA99549E;

	private Label label49;

	private CheckBox E28E5BB3;

	private Panel plDeleteComment;

	private Panel FC1D29A3;

	private RadioButton C90A7D15;

	private RadioButton E8085220;

	private Label label4;

	private Label label6;

	private Label label10;

	private NumericUpDown nudDelayDeleteFrom;

	private NumericUpDown C103E595;

	public fHDTuongTacNhomv2(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		BA31D2B1 = false;
		F7B5CDAC = string_2;
		string_1 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác nhóm v2";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C31B6C2B = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
		DC24B788 = new List<CheckBox> { ckbLike, ckbLove, ckbCare, ckbHaha, ckbWow, ckbSad, ckbAngry };
	}

	private void CA2D0D95(object sender, EventArgs e)
	{
		try
		{
			AB3140AD.Value = C31B6C2B.GetValueInt("nudSoLuongFrom", 1);
			FC16B383.Value = C31B6C2B.GetValueInt("nudSoLuongTo", 3);
			FC953F97.Value = C31B6C2B.GetValueInt("nudTimeFrom", 3);
			nudTimeTo.Value = C31B6C2B.GetValueInt("nudTimeTo", 5);
			F7895227.Value = C31B6C2B.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = C31B6C2B.GetValueInt("nudDelayTo", 5);
			A0911CB2.Checked = C31B6C2B.GetValueBool("ckbInteract");
			List<string> list = C31B6C2B.GetValue("typeReaction", "Like").Split('|').ToList();
			for (int i = 0; i < list.Count; i++)
			{
				foreach (CheckBox item in DC24B788)
				{
					if (item.Name.Substring(3) == list[i])
					{
						item.Checked = true;
					}
				}
			}
			ckbComment.Checked = C31B6C2B.GetValueBool("ckbComment");
			txtComment.Text = C31B6C2B.GetValue("txtComment");
			E28E5BB3.Checked = C31B6C2B.GetValueBool("ckbDeleteComment");
			nudDelayDeleteFrom.Value = C31B6C2B.GetValueInt("nudDelayDeleteFrom", 3);
			C103E595.Value = C31B6C2B.GetValueInt("nudDelayDeleteTo", 5);
		}
		catch
		{
		}
		DB8EC335();
	}

	private void F82A4589(object sender, EventArgs e)
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
		gClass.GetJson("nudSoLuongFrom", AB3140AD.Value);
		gClass.GetJson("nudSoLuongTo", FC16B383.Value);
		gClass.GetJson("nudTimeFrom", FC953F97.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", F7895227.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbInteract", A0911CB2.Checked);
		string text2 = "";
		for (int i = 0; i < DC24B788.Count; i++)
		{
			if (DC24B788[i].Checked)
			{
				text2 = text2 + DC24B788[i].Name.Substring(3) + "|";
			}
		}
		gClass.GetJson("typeReaction", text2.TrimEnd('|'));
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("ckbDeleteComment", E28E5BB3.Checked);
		gClass.GetJson("nudDelayDeleteFrom", nudDelayDeleteFrom.Value);
		gClass.GetJson("nudDelayDeleteTo", C103E595.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(F7B5CDAC, text, string_0, string_))
				{
					BA31D2B1 = true;
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
				BA31D2B1 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void AC98ECAD_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C63B988E_Paint(object sender, PaintEventArgs e)
	{
		if (C63B988E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C63B988E.ClientSize.Width - num, C63B988E.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, lblComment);
	}

	private void DB8EC335()
	{
		A0911CB2_CheckedChanged(null, null);
		C128793E(null, null);
		method_0(null, null);
		txtComment_TextChanged(null, null);
		E28E5BB3_CheckedChanged(null, null);
	}

	private void A0911CB2_CheckedChanged(object sender, EventArgs e)
	{
		C4294ABC.Enabled = A0911CB2.Checked;
	}

	private void C128793E(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void C63B988E_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void E28E5BB3_CheckedChanged(object sender, EventArgs e)
	{
		plDeleteComment.Enabled = E28E5BB3.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacNhomv2));
		this.D78067AA = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.BC14F886 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C63B988E = new System.Windows.Forms.Panel();
		this.AB3140AD = new System.Windows.Forms.NumericUpDown();
		this.FC16B383 = new System.Windows.Forms.NumericUpDown();
		this.AA99549E = new System.Windows.Forms.Label();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.F7895227 = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.plComment = new System.Windows.Forms.Panel();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblComment = new System.Windows.Forms.Label();
		this.E28E5BB3 = new System.Windows.Forms.CheckBox();
		this.plDeleteComment = new System.Windows.Forms.Panel();
		this.FC1D29A3 = new System.Windows.Forms.Panel();
		this.C90A7D15 = new System.Windows.Forms.RadioButton();
		this.E8085220 = new System.Windows.Forms.RadioButton();
		this.label4 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.nudDelayDeleteFrom = new System.Windows.Forms.NumericUpDown();
		this.C103E595 = new System.Windows.Forms.NumericUpDown();
		this.C4294ABC = new System.Windows.Forms.Panel();
		this.ckbAngry = new System.Windows.Forms.CheckBox();
		this.ckbSad = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbCare = new System.Windows.Forms.CheckBox();
		this.ckbLove = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.radioButton4 = new System.Windows.Forms.RadioButton();
		this.CD0F350E = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.A0911CB2 = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.FC953F97 = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.CE2AEF8A = new System.Windows.Forms.Label();
		this.C6B0380D = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.AC98ECAD = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.A6982D3B = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.C63B988E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.AB3140AD).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FC16B383).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F7895227).BeginInit();
		this.plComment.SuspendLayout();
		this.plDeleteComment.SuspendLayout();
		this.FC1D29A3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayDeleteFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C103E595).BeginInit();
		this.C4294ABC.SuspendLayout();
		this.panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FC953F97).BeginInit();
		this.A6982D3B.SuspendLayout();
		base.SuspendLayout();
		this.D78067AA.Fixed = true;
		this.D78067AA.Horizontal = true;
		this.D78067AA.TargetControl = this.bunifuCustomLabel1;
		this.D78067AA.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(394, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác nhóm v2";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.BC14F886.Fixed = true;
		this.BC14F886.Horizontal = true;
		this.BC14F886.TargetControl = this.pnlHeader;
		this.BC14F886.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(394, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(363, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(F82A4589);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.C63B988E.BackColor = System.Drawing.Color.White;
		this.C63B988E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C63B988E.Controls.Add(this.AB3140AD);
		this.C63B988E.Controls.Add(this.FC16B383);
		this.C63B988E.Controls.Add(this.AA99549E);
		this.C63B988E.Controls.Add(this.nudDelayTo);
		this.C63B988E.Controls.Add(this.F7895227);
		this.C63B988E.Controls.Add(this.label7);
		this.C63B988E.Controls.Add(this.plComment);
		this.C63B988E.Controls.Add(this.C4294ABC);
		this.C63B988E.Controls.Add(this.label49);
		this.C63B988E.Controls.Add(this.ckbComment);
		this.C63B988E.Controls.Add(this.A0911CB2);
		this.C63B988E.Controls.Add(this.nudTimeTo);
		this.C63B988E.Controls.Add(this.FC953F97);
		this.C63B988E.Controls.Add(this.txtTenHanhDong);
		this.C63B988E.Controls.Add(this.label9);
		this.C63B988E.Controls.Add(this.CE2AEF8A);
		this.C63B988E.Controls.Add(this.C6B0380D);
		this.C63B988E.Controls.Add(this.label1);
		this.C63B988E.Controls.Add(this.AC98ECAD);
		this.C63B988E.Controls.Add(this.btnAdd);
		this.C63B988E.Controls.Add(this.A6982D3B);
		this.C63B988E.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C63B988E.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C63B988E.Location = new System.Drawing.Point(0, 0);
		this.C63B988E.Name = "panel1";
		this.C63B988E.Size = new System.Drawing.Size(397, 453);
		this.C63B988E.TabIndex = 0;
		this.C63B988E.Click += new System.EventHandler(C63B988E_Click);
		this.C63B988E.Paint += new System.Windows.Forms.PaintEventHandler(C63B988E_Paint);
		this.AB3140AD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.AB3140AD.Location = new System.Drawing.Point(166, 78);
		this.AB3140AD.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.AB3140AD.Name = "nudSoLuongFrom";
		this.AB3140AD.Size = new System.Drawing.Size(66, 23);
		this.AB3140AD.TabIndex = 167;
		this.AB3140AD.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.FC16B383.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.FC16B383.Location = new System.Drawing.Point(295, 78);
		this.FC16B383.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.FC16B383.Name = "nudSoLuongTo";
		this.FC16B383.Size = new System.Drawing.Size(65, 23);
		this.FC16B383.TabIndex = 168;
		this.FC16B383.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.AA99549E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AA99549E.Location = new System.Drawing.Point(250, 80);
		this.AA99549E.Name = "label66";
		this.AA99549E.Size = new System.Drawing.Size(29, 16);
		this.AA99549E.TabIndex = 171;
		this.AA99549E.Text = ">";
		this.AA99549E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudDelayTo.Location = new System.Drawing.Point(295, 136);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(65, 23);
		this.nudDelayTo.TabIndex = 4;
		this.F7895227.Location = new System.Drawing.Point(166, 136);
		this.F7895227.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F7895227.Name = "nudDelayFrom";
		this.F7895227.Size = new System.Drawing.Size(66, 23);
		this.F7895227.TabIndex = 3;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new System.Drawing.Point(250, 138);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = ">";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.lblComment);
		this.plComment.Controls.Add(this.E28E5BB3);
		this.plComment.Controls.Add(this.plDeleteComment);
		this.plComment.Location = new System.Drawing.Point(48, 248);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(312, 146);
		this.plComment.TabIndex = 164;
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(299, 115);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(3, 5);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(139, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Nội dung bình luận (0):";
		this.E28E5BB3.AutoSize = true;
		this.E28E5BB3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E28E5BB3.Location = new System.Drawing.Point(7, 146);
		this.E28E5BB3.Name = "ckbDeleteComment";
		this.E28E5BB3.Size = new System.Drawing.Size(105, 20);
		this.E28E5BB3.TabIndex = 163;
		this.E28E5BB3.Text = "Xóa comment";
		this.E28E5BB3.UseVisualStyleBackColor = true;
		this.E28E5BB3.CheckedChanged += new System.EventHandler(E28E5BB3_CheckedChanged);
		this.plDeleteComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDeleteComment.Controls.Add(this.FC1D29A3);
		this.plDeleteComment.Controls.Add(this.label4);
		this.plDeleteComment.Controls.Add(this.label6);
		this.plDeleteComment.Controls.Add(this.label10);
		this.plDeleteComment.Controls.Add(this.nudDelayDeleteFrom);
		this.plDeleteComment.Controls.Add(this.C103E595);
		this.plDeleteComment.Location = new System.Drawing.Point(25, 169);
		this.plDeleteComment.Name = "plDeleteComment";
		this.plDeleteComment.Size = new System.Drawing.Size(281, 29);
		this.plDeleteComment.TabIndex = 180;
		this.FC1D29A3.Controls.Add(this.C90A7D15);
		this.FC1D29A3.Controls.Add(this.E8085220);
		this.FC1D29A3.Location = new System.Drawing.Point(67, 300);
		this.FC1D29A3.Name = "panel3";
		this.FC1D29A3.Size = new System.Drawing.Size(200, 43);
		this.FC1D29A3.TabIndex = 43;
		this.C90A7D15.AutoSize = true;
		this.C90A7D15.Checked = true;
		this.C90A7D15.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C90A7D15.Location = new System.Drawing.Point(3, 2);
		this.C90A7D15.Name = "radioButton1";
		this.C90A7D15.Size = new System.Drawing.Size(201, 20);
		this.C90A7D15.TabIndex = 3;
		this.C90A7D15.TabStop = true;
		this.C90A7D15.Text = "Comment theo thứ tự nội dung";
		this.C90A7D15.UseVisualStyleBackColor = true;
		this.E8085220.AutoSize = true;
		this.E8085220.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E8085220.Location = new System.Drawing.Point(3, 23);
		this.E8085220.Name = "radioButton2";
		this.E8085220.Size = new System.Drawing.Size(200, 20);
		this.E8085220.TabIndex = 3;
		this.E8085220.Text = "Comment ngẫu nhiên nội dung";
		this.E8085220.UseVisualStyleBackColor = true;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(4, 302);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(64, 16);
		this.label4.TabIndex = 2;
		this.label4.Text = "Tùy chọn:";
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 4);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(135, 16);
		this.label6.TabIndex = 34;
		this.label6.Text = "Chờ xóa comment (s):";
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(197, 4);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(19, 16);
		this.label10.TabIndex = 38;
		this.label10.Text = ">";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudDelayDeleteFrom.Location = new System.Drawing.Point(138, 2);
		this.nudDelayDeleteFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayDeleteFrom.Name = "nudDelayDeleteFrom";
		this.nudDelayDeleteFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayDeleteFrom.TabIndex = 3;
		this.C103E595.Location = new System.Drawing.Point(220, 2);
		this.C103E595.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C103E595.Name = "nudDelayDeleteTo";
		this.C103E595.Size = new System.Drawing.Size(56, 23);
		this.C103E595.TabIndex = 4;
		this.C4294ABC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C4294ABC.Controls.Add(this.ckbAngry);
		this.C4294ABC.Controls.Add(this.ckbSad);
		this.C4294ABC.Controls.Add(this.ckbWow);
		this.C4294ABC.Controls.Add(this.ckbHaha);
		this.C4294ABC.Controls.Add(this.ckbCare);
		this.C4294ABC.Controls.Add(this.ckbLove);
		this.C4294ABC.Controls.Add(this.ckbLike);
		this.C4294ABC.Controls.Add(this.panel7);
		this.C4294ABC.Controls.Add(this.CD0F350E);
		this.C4294ABC.Location = new System.Drawing.Point(48, 187);
		this.C4294ABC.Name = "plInteract";
		this.C4294ABC.Size = new System.Drawing.Size(312, 33);
		this.C4294ABC.TabIndex = 180;
		this.ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAngry.Image = Resources.Bitmap_7;
		this.ckbAngry.Location = new System.Drawing.Point(266, 1);
		this.ckbAngry.Name = "ckbAngry";
		this.ckbAngry.Size = new System.Drawing.Size(40, 30);
		this.ckbAngry.TabIndex = 179;
		this.ckbAngry.Tag = "Angry";
		this.ckbAngry.UseVisualStyleBackColor = true;
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
		this.ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCare.Image = Resources.Bitmap_14;
		this.ckbCare.Location = new System.Drawing.Point(90, 1);
		this.ckbCare.Name = "ckbCare";
		this.ckbCare.Size = new System.Drawing.Size(40, 30);
		this.ckbCare.TabIndex = 175;
		this.ckbCare.Tag = "Care";
		this.ckbCare.UseVisualStyleBackColor = true;
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
		this.panel7.Controls.Add(this.radioButton3);
		this.panel7.Controls.Add(this.radioButton4);
		this.panel7.Location = new System.Drawing.Point(67, 300);
		this.panel7.Name = "panel7";
		this.panel7.Size = new System.Drawing.Size(200, 43);
		this.panel7.TabIndex = 43;
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
		this.CD0F350E.AutoSize = true;
		this.CD0F350E.Location = new System.Drawing.Point(4, 302);
		this.CD0F350E.Name = "label26";
		this.CD0F350E.Size = new System.Drawing.Size(64, 16);
		this.CD0F350E.TabIndex = 2;
		this.CD0F350E.Text = "Tùy chọn:";
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(27, 80);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(106, 16);
		this.label49.TabIndex = 169;
		this.label49.Text = "Sô\u0301 bài tương tác:";
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(30, 224);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(78, 20);
		this.ckbComment.TabIndex = 163;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(C128793E);
		this.A0911CB2.AutoSize = true;
		this.A0911CB2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A0911CB2.Location = new System.Drawing.Point(30, 165);
		this.A0911CB2.Name = "ckbInteract";
		this.A0911CB2.Size = new System.Drawing.Size(99, 20);
		this.A0911CB2.TabIndex = 5;
		this.A0911CB2.Text = "Thả cảm xúc";
		this.A0911CB2.UseVisualStyleBackColor = true;
		this.A0911CB2.CheckedChanged += new System.EventHandler(A0911CB2_CheckedChanged);
		this.nudTimeTo.Location = new System.Drawing.Point(295, 107);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(65, 23);
		this.nudTimeTo.TabIndex = 4;
		this.FC953F97.Location = new System.Drawing.Point(166, 107);
		this.FC953F97.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FC953F97.Name = "nudTimeFrom";
		this.FC953F97.Size = new System.Drawing.Size(66, 23);
		this.FC953F97.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(166, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new System.Drawing.Point(250, 109);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 38;
		this.label9.Text = ">";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CE2AEF8A.AutoSize = true;
		this.CE2AEF8A.Location = new System.Drawing.Point(27, 109);
		this.CE2AEF8A.Name = "label3";
		this.CE2AEF8A.Size = new System.Drawing.Size(103, 16);
		this.CE2AEF8A.TabIndex = 34;
		this.CE2AEF8A.Text = "Xem bài viết (s):";
		this.C6B0380D.AutoSize = true;
		this.C6B0380D.Location = new System.Drawing.Point(27, 138);
		this.C6B0380D.Name = "label5";
		this.C6B0380D.Size = new System.Drawing.Size(133, 16);
		this.C6B0380D.TabIndex = 34;
		this.C6B0380D.Text = "Delay sau mỗi bài (s):";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.AC98ECAD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.AC98ECAD.BackColor = System.Drawing.Color.Maroon;
		this.AC98ECAD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AC98ECAD.FlatAppearance.BorderSize = 0;
		this.AC98ECAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AC98ECAD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AC98ECAD.ForeColor = System.Drawing.Color.White;
		this.AC98ECAD.Location = new System.Drawing.Point(204, 411);
		this.AC98ECAD.Name = "btnCancel";
		this.AC98ECAD.Size = new System.Drawing.Size(92, 29);
		this.AC98ECAD.TabIndex = 10;
		this.AC98ECAD.Text = "Đóng";
		this.AC98ECAD.UseVisualStyleBackColor = false;
		this.AC98ECAD.Click += new System.EventHandler(AC98ECAD_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(97, 411);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.A6982D3B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.A6982D3B.BackColor = System.Drawing.Color.White;
		this.A6982D3B.BorderRadius = 0;
		this.A6982D3B.BottomSahddow = true;
		this.A6982D3B.color = System.Drawing.Color.DarkViolet;
		this.A6982D3B.Controls.Add(this.pnlHeader);
		this.A6982D3B.LeftSahddow = false;
		this.A6982D3B.Location = new System.Drawing.Point(1, 0);
		this.A6982D3B.Name = "bunifuCards1";
		this.A6982D3B.RightSahddow = true;
		this.A6982D3B.ShadowDepth = 20;
		this.A6982D3B.Size = new System.Drawing.Size(394, 37);
		this.A6982D3B.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(397, 453);
		base.Controls.Add(this.C63B988E);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNhomv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CA2D0D95);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.C63B988E.ResumeLayout(false);
		this.C63B988E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.AB3140AD).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FC16B383).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F7895227).EndInit();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plDeleteComment.ResumeLayout(false);
		this.plDeleteComment.PerformLayout();
		this.FC1D29A3.ResumeLayout(false);
		this.FC1D29A3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayDeleteFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C103E595).EndInit();
		this.C4294ABC.ResumeLayout(false);
		this.C4294ABC.PerformLayout();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FC953F97).EndInit();
		this.A6982D3B.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
