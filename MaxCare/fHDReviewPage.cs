using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDReviewPage : Form
{
	private JObject jobject_0;

	private string string_0;

	private string AF2F3325;

	private string D503B9BD;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl B0399F0F;

	private BunifuDragControl bunifuDragControl_0;

	private Panel C715848F;

	private NumericUpDown AD0EB99F;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label D4AEB0BD;

	private Label label2;

	private Label D016E313;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards FC0089BC;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label F039FE39;

	private Label AC38EE98;

	private NumericUpDown nudDelayTo;

	private NumericUpDown CA9E2C8E;

	private Label E7285A29;

	private Label E5292833;

	private Label label5;

	private RichTextBox txtUid;

	private CheckBox E12E5626;

	private ToolTip toolTip_0;

	private Panel plTuongTacComment;

	private TextBox txtComment;

	private Label AA27181E;

	private Label label17;

	private RadioButton rbNo;

	private RadioButton rbYes;

	private Label label9;

	public fHDReviewPage(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_1;
		D503B9BD = string_2;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanTepUid");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			AF2F3325 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void D291D6AA()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(D016E313);
		Language.smethod_0(label2);
		Language.smethod_0(label3);
		Language.smethod_0(D4AEB0BD);
		Language.smethod_0(label5);
		Language.smethod_0(E7285A29);
		Language.smethod_0(E5292833);
		Language.smethod_0(AC38EE98);
		Language.smethod_0(F039FE39);
		Language.smethod_0(E12E5626);
		Language.smethod_0(AA27181E);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void B9848304(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			AD0EB99F.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			CA9E2C8E.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			if (Convert.ToInt32(jobject_0["typeReview"]) == 0)
			{
				rbNo.Checked = true;
			}
			else
			{
				rbYes.Checked = true;
			}
			txtUid.Text = jobject_0["txtUid"].ToString();
			E12E5626.Checked = Convert.ToBoolean(jobject_0["ckbTuDongXoaUid"]);
			txtComment.Text = jobject_0["txtComment"].ToString();
		}
		catch
		{
		}
		method_0();
	}

	private void method_0()
	{
	}

	private void D4078F06(object sender, EventArgs e)
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
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách Id page cần đánh giá!", 3);
			return;
		}
		a2AB53A = txtComment.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nội dung đánh giá!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", AD0EB99F.Value);
		gClass.GetJson("nudDelayFrom", CA9E2C8E.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		int num = 0;
		if (rbYes.Checked)
		{
			num = 1;
		}
		gClass.GetJson("type", num);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", E12E5626.Checked);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, AF2F3325, text2))
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
			if (InteractSQL.smethod_13(D503B9BD, text, text2))
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

	private void A289BBBB(object sender, EventArgs e)
	{
		Close();
	}

	private void A5BD6699(object sender, PaintEventArgs e)
	{
		if (C715848F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C715848F.ClientSize.Width - num, C715848F.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			AC38EE98.Text = string.Format(Language.GetValue("Danh sa\u0301ch Id cần đánh giá ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			AA27181E.Text = string.Format(Language.GetValue("Nội dung đánh giá ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	protected override void Dispose(bool D70E9D3A)
	{
		if (D70E9D3A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D70E9D3A);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDReviewPage));
		this.B0399F0F = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.C715848F = new System.Windows.Forms.Panel();
		this.rbNo = new System.Windows.Forms.RadioButton();
		this.rbYes = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.plTuongTacComment = new System.Windows.Forms.Panel();
		this.label17 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.TextBox();
		this.AA27181E = new System.Windows.Forms.Label();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.E12E5626 = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.F039FE39 = new System.Windows.Forms.Label();
		this.AC38EE98 = new System.Windows.Forms.Label();
		this.CA9E2C8E = new System.Windows.Forms.NumericUpDown();
		this.E7285A29 = new System.Windows.Forms.Label();
		this.E5292833 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.AD0EB99F = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.D4AEB0BD = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.D016E313 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.FC0089BC = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.C715848F.SuspendLayout();
		this.plTuongTacComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CA9E2C8E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.AD0EB99F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.FC0089BC.SuspendLayout();
		base.SuspendLayout();
		this.B0399F0F.Fixed = true;
		this.B0399F0F.Horizontal = true;
		this.B0399F0F.TargetControl = this.bunifuCustomLabel1;
		this.B0399F0F.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Đánh giá page";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(687, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(656, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(D4078F06);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.C715848F.BackColor = System.Drawing.Color.White;
		this.C715848F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C715848F.Controls.Add(this.rbNo);
		this.C715848F.Controls.Add(this.rbYes);
		this.C715848F.Controls.Add(this.label9);
		this.C715848F.Controls.Add(this.plTuongTacComment);
		this.C715848F.Controls.Add(this.txtUid);
		this.C715848F.Controls.Add(this.E12E5626);
		this.C715848F.Controls.Add(this.nudDelayTo);
		this.C715848F.Controls.Add(this.F039FE39);
		this.C715848F.Controls.Add(this.AC38EE98);
		this.C715848F.Controls.Add(this.CA9E2C8E);
		this.C715848F.Controls.Add(this.E7285A29);
		this.C715848F.Controls.Add(this.E5292833);
		this.C715848F.Controls.Add(this.label5);
		this.C715848F.Controls.Add(this.AD0EB99F);
		this.C715848F.Controls.Add(this.nudSoLuongFrom);
		this.C715848F.Controls.Add(this.txtTenHanhDong);
		this.C715848F.Controls.Add(this.label3);
		this.C715848F.Controls.Add(this.D4AEB0BD);
		this.C715848F.Controls.Add(this.label2);
		this.C715848F.Controls.Add(this.D016E313);
		this.C715848F.Controls.Add(this.btnCancel);
		this.C715848F.Controls.Add(this.btnAdd);
		this.C715848F.Controls.Add(this.FC0089BC);
		this.C715848F.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C715848F.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C715848F.Location = new System.Drawing.Point(0, 0);
		this.C715848F.Name = "panel1";
		this.C715848F.Size = new System.Drawing.Size(690, 435);
		this.C715848F.TabIndex = 0;
		this.C715848F.Paint += new System.Windows.Forms.PaintEventHandler(A5BD6699);
		this.rbNo.AutoSize = true;
		this.rbNo.Location = new System.Drawing.Point(222, 140);
		this.rbNo.Name = "rbNo";
		this.rbNo.Size = new System.Drawing.Size(60, 20);
		this.rbNo.TabIndex = 116;
		this.rbNo.TabStop = true;
		this.rbNo.Text = "Không";
		this.rbNo.UseVisualStyleBackColor = true;
		this.rbYes.AutoSize = true;
		this.rbYes.Location = new System.Drawing.Point(125, 140);
		this.rbYes.Name = "rbYes";
		this.rbYes.Size = new System.Drawing.Size(40, 20);
		this.rbYes.TabIndex = 116;
		this.rbYes.TabStop = true;
		this.rbYes.Text = "Có";
		this.rbYes.UseVisualStyleBackColor = true;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(24, 142);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(56, 16);
		this.label9.TabIndex = 115;
		this.label9.Text = "Đề xuất:";
		this.plTuongTacComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTacComment.Controls.Add(this.label17);
		this.plTuongTacComment.Controls.Add(this.txtComment);
		this.plTuongTacComment.Controls.Add(this.AA27181E);
		this.plTuongTacComment.Location = new System.Drawing.Point(345, 49);
		this.plTuongTacComment.Name = "plTuongTacComment";
		this.plTuongTacComment.Size = new System.Drawing.Size(332, 297);
		this.plTuongTacComment.TabIndex = 93;
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(196, 277);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(131, 16);
		this.label17.TabIndex = 188;
		this.label17.Text = "Spin content: {a|b|c}";
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Multiline = true;
		this.txtComment.Name = "txtComment";
		this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtComment.Size = new System.Drawing.Size(320, 246);
		this.txtComment.TabIndex = 1;
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.AA27181E.AutoSize = true;
		this.AA27181E.Location = new System.Drawing.Point(3, 5);
		this.AA27181E.Name = "lblStatusComment";
		this.AA27181E.Size = new System.Drawing.Size(136, 16);
		this.AA27181E.TabIndex = 0;
		this.AA27181E.Text = "Nội dung đánh giá (0):";
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(24, 194);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(295, 141);
		this.txtUid.TabIndex = 114;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.E12E5626.AutoSize = true;
		this.E12E5626.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E12E5626.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E12E5626.Location = new System.Drawing.Point(24, 358);
		this.E12E5626.Name = "ckbTuDongXoaUid";
		this.E12E5626.Size = new System.Drawing.Size(184, 20);
		this.E12E5626.TabIndex = 113;
		this.E12E5626.Text = "Tư\u0323 đô\u0323ng xo\u0301a Id đa\u0303 đánh giá";
		this.E12E5626.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(222, 111);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.F039FE39.AutoSize = true;
		this.F039FE39.Location = new System.Drawing.Point(220, 338);
		this.F039FE39.Name = "label8";
		this.F039FE39.Size = new System.Drawing.Size(95, 16);
		this.F039FE39.TabIndex = 0;
		this.F039FE39.Text = "(Mỗi Id 1 dòng)";
		this.AC38EE98.AutoSize = true;
		this.AC38EE98.Location = new System.Drawing.Point(20, 172);
		this.AC38EE98.Name = "lblStatus";
		this.AC38EE98.Size = new System.Drawing.Size(184, 16);
		this.AC38EE98.TabIndex = 0;
		this.AC38EE98.Text = "Danh sa\u0301ch Id cần đánh giá (0):";
		this.CA9E2C8E.Location = new System.Drawing.Point(125, 111);
		this.CA9E2C8E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CA9E2C8E.Name = "nudDelayFrom";
		this.CA9E2C8E.Size = new System.Drawing.Size(56, 23);
		this.CA9E2C8E.TabIndex = 3;
		this.E7285A29.Location = new System.Drawing.Point(187, 113);
		this.E7285A29.Name = "label7";
		this.E7285A29.Size = new System.Drawing.Size(29, 16);
		this.E7285A29.TabIndex = 46;
		this.E7285A29.Text = "đê\u0301n";
		this.E7285A29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E5292833.AutoSize = true;
		this.E5292833.Location = new System.Drawing.Point(280, 113);
		this.E5292833.Name = "label6";
		this.E5292833.Size = new System.Drawing.Size(30, 16);
		this.E5292833.TabIndex = 45;
		this.E5292833.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(20, 113);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.AD0EB99F.Location = new System.Drawing.Point(222, 80);
		this.AD0EB99F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.AD0EB99F.Name = "nudSoLuongTo";
		this.AD0EB99F.Size = new System.Drawing.Size(56, 23);
		this.AD0EB99F.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(125, 80);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(187, 82);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "đê\u0301n";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D4AEB0BD.AutoSize = true;
		this.D4AEB0BD.Location = new System.Drawing.Point(280, 82);
		this.D4AEB0BD.Name = "label4";
		this.D4AEB0BD.Size = new System.Drawing.Size(35, 16);
		this.D4AEB0BD.TabIndex = 35;
		this.D4AEB0BD.Text = "page";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(20, 82);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(95, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng page:";
		this.D016E313.AutoSize = true;
		this.D016E313.Location = new System.Drawing.Point(20, 52);
		this.D016E313.Name = "label1";
		this.D016E313.Size = new System.Drawing.Size(98, 16);
		this.D016E313.TabIndex = 31;
		this.D016E313.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(349, 393);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(A289BBBB);
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(242, 393);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 6;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.FC0089BC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.FC0089BC.BackColor = System.Drawing.Color.White;
		this.FC0089BC.BorderRadius = 0;
		this.FC0089BC.BottomSahddow = true;
		this.FC0089BC.color = System.Drawing.Color.DarkViolet;
		this.FC0089BC.Controls.Add(this.pnlHeader);
		this.FC0089BC.LeftSahddow = false;
		this.FC0089BC.Location = new System.Drawing.Point(1, 0);
		this.FC0089BC.Name = "bunifuCards1";
		this.FC0089BC.RightSahddow = true;
		this.FC0089BC.ShadowDepth = 20;
		this.FC0089BC.Size = new System.Drawing.Size(687, 37);
		this.FC0089BC.TabIndex = 28;
		this.toolTip_0.AutomaticDelay = 0;
		this.toolTip_0.AutoPopDelay = 0;
		this.toolTip_0.InitialDelay = 0;
		this.toolTip_0.ReshowDelay = 0;
		this.toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(690, 435);
		base.Controls.Add(this.C715848F);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDReviewPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B9848304);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.C715848F.ResumeLayout(false);
		this.C715848F.PerformLayout();
		this.plTuongTacComment.ResumeLayout(false);
		this.plTuongTacComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CA9E2C8E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.AD0EB99F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.FC0089BC.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
