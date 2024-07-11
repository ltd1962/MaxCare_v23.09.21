using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanTepUid : Form
{
	private JSON_Settings gclass8_0;

	private string E033D004;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl CE3DB9A2;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox DE37B9BD;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label CA2A90A8;

	private Button btnCancel;

	private Button FF86AF27;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox E634163B;

	private BunifuCustomLabel DF842F9D;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label D7AFE2AB;

	private Label label6;

	private Label label5;

	private RichTextBox txtUid;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip E41ABA96;

	private Panel plTuongTac;

	private Label label19;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private CheckBox ckbTuongTacLike;

	private Label E41D2D8D;

	private NumericUpDown nudTuongTacDelayFrom;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudTuongTacDelayTo;

	private Label label67;

	private Label label48;

	private CheckBox F711800F;

	private Panel A293E318;

	private TextBox txtComment;

	private Label C38628B5;

	private CheckBox ckbTuongTacComment;

	private LinkLabel AAA86136;

	private Label label17;

	private NumericUpDown nudTimesWarning;

	private Label A6086839;

	private Label label8;

	private ComboBox A3B831B8;

	private Label label10;

	private CheckBox F32EFE12;

	public fHDKetBanTepUid(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E033D004 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanTepUid");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DE37B9BD.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			FF86AF27.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DE37B9BD.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void E389E8AC_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			ckbTuDongXoaUid.Checked = gclass8_0.GetValueBool("ckbKetBanTrungNhau");
			txtUid.Text = gclass8_0.GetValue("txtUid");
			F711800F.Checked = gclass8_0.GetValueBool("ckbTuongTac");
			nudSoLuongBaiVietFrom.Value = gclass8_0.GetValueInt("nudSoLuongBaiVietFrom");
			nudSoLuongBaiVietTo.Value = gclass8_0.GetValueInt("nudSoLuongBaiVietTo");
			nudTuongTacDelayFrom.Value = gclass8_0.GetValueInt("nudTuongTacDelayFrom");
			nudTuongTacDelayTo.Value = gclass8_0.GetValueInt("nudTuongTacDelayTo");
			ckbTuongTacLike.Checked = gclass8_0.GetValueBool("ckbTuongTacLike");
			ckbTuongTacComment.Checked = gclass8_0.GetValueBool("ckbTuongTacComment");
			ckbTuDongXoaUid.Checked = gclass8_0.GetValueBool("ckbTuDongXoaUid");
			F32EFE12.Checked = gclass8_0.GetValueBool("ckbAddFriendApi");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			nudTimesWarning.Value = gclass8_0.GetValueInt("nudTimesWarning", 1);
			A3B831B8.SelectedIndex = gclass8_0.GetValueInt("cbbFacebookWeb");
		}
		catch
		{
		}
		E001CF3E();
	}

	private void E001CF3E()
	{
		F711800F_CheckedChanged(null, null);
		ckbTuongTacComment_CheckedChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FF86AF27_Click(object sender, EventArgs e)
	{
		string text = DE37B9BD.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid cần kết bạn!", 3);
			return;
		}
		if (F711800F.Checked && ckbTuongTacComment.Checked)
		{
			a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nội dung bình luận!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbKetBanTrungNhau", ckbTuDongXoaUid.Checked);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("ckbTuongTac", F711800F.Checked);
		gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.GetJson("nudTuongTacDelayFrom", nudTuongTacDelayFrom.Value);
		gClass.GetJson("nudTuongTacDelayTo", nudTuongTacDelayTo.Value);
		gClass.GetJson("ckbTuongTacLike", ckbTuongTacLike.Checked);
		gClass.GetJson("ckbTuongTacComment", ckbTuongTacComment.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.GetJson("ckbAddFriendApi", F32EFE12.Checked);
		gClass.GetJson("nudTimesWarning", nudTimesWarning.Value);
		gClass.GetJson("cbbFacebookWeb", A3B831B8.SelectedIndex);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E033D004, text, string_0, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FD1CFB90(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void B09A080F(object sender, EventArgs e)
	{
	}

	private void AC9C73AC(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid cần kết bạn ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void E5395298(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			C38628B5.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void F711800F_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = F711800F.Checked;
	}

	private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
	{
		A293E318.Enabled = ckbTuongTacComment.Checked;
	}

	private void AE8A34A2(object sender, LinkLabelLinkClickedEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTepUid));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.DF842F9D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.CE3DB9A2 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.E634163B = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.A3B831B8 = new System.Windows.Forms.ComboBox();
		this.label10 = new System.Windows.Forms.Label();
		this.nudTimesWarning = new System.Windows.Forms.NumericUpDown();
		this.A6086839 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.plTuongTac = new System.Windows.Forms.Panel();
		this.A293E318 = new System.Windows.Forms.Panel();
		this.AAA86136 = new System.Windows.Forms.LinkLabel();
		this.label17 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.TextBox();
		this.C38628B5 = new System.Windows.Forms.Label();
		this.ckbTuongTacComment = new System.Windows.Forms.CheckBox();
		this.label19 = new System.Windows.Forms.Label();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTacLike = new System.Windows.Forms.CheckBox();
		this.E41D2D8D = new System.Windows.Forms.Label();
		this.nudTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
		this.label67 = new System.Windows.Forms.Label();
		this.label48 = new System.Windows.Forms.Label();
		this.F711800F = new System.Windows.Forms.CheckBox();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.lblStatus = new System.Windows.Forms.Label();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.D7AFE2AB = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		this.DE37B9BD = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.CA2A90A8 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.FF86AF27 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.F32EFE12 = new System.Windows.Forms.CheckBox();
		this.E41ABA96 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E634163B).BeginInit();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimesWarning).BeginInit();
		this.plTuongTac.SuspendLayout();
		this.A293E318.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.DF842F9D;
		this.bunifuDragControl_0.Vertical = true;
		this.DF842F9D.BackColor = System.Drawing.Color.Transparent;
		this.DF842F9D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.DF842F9D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DF842F9D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DF842F9D.ForeColor = System.Drawing.Color.Black;
		this.DF842F9D.Location = new System.Drawing.Point(0, 0);
		this.DF842F9D.Name = "bunifuCustomLabel1";
		this.DF842F9D.Size = new System.Drawing.Size(695, 31);
		this.DF842F9D.TabIndex = 12;
		this.DF842F9D.Text = "Cấu hình Kết bạn theo tệp UID";
		this.DF842F9D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CE3DB9A2.Fixed = true;
		this.CE3DB9A2.Horizontal = true;
		this.CE3DB9A2.TargetControl = this.pnlHeader;
		this.CE3DB9A2.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.E634163B);
		this.pnlHeader.Controls.Add(this.DF842F9D);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(695, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(664, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.E634163B.Cursor = System.Windows.Forms.Cursors.Default;
		this.E634163B.Image = Resources.Bitmap_4;
		this.E634163B.Location = new System.Drawing.Point(3, 2);
		this.E634163B.Name = "pictureBox1";
		this.E634163B.Size = new System.Drawing.Size(34, 27);
		this.E634163B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E634163B.TabIndex = 76;
		this.E634163B.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.A3B831B8);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.nudTimesWarning);
		this.panel1.Controls.Add(this.A6086839);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.plTuongTac);
		this.panel1.Controls.Add(this.F711800F);
		this.panel1.Controls.Add(this.txtUid);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.lblStatus);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.D7AFE2AB);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.nudSoLuongTo);
		this.panel1.Controls.Add(this.nudSoLuongFrom);
		this.panel1.Controls.Add(this.DE37B9BD);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.CA2A90A8);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.FF86AF27);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Controls.Add(this.ckbTuDongXoaUid);
		this.panel1.Controls.Add(this.F32EFE12);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(698, 434);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(FD1CFB90);
		this.A3B831B8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A3B831B8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.A3B831B8.DropDownWidth = 200;
		this.A3B831B8.FormattingEnabled = true;
		this.A3B831B8.Items.AddRange(new object[2] { "https://m.facebook.com", "https://www.facebook.com" });
		this.A3B831B8.Location = new System.Drawing.Point(61, 349);
		this.A3B831B8.Name = "cbbFacebookWeb";
		this.A3B831B8.Size = new System.Drawing.Size(180, 24);
		this.A3B831B8.TabIndex = 193;
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(21, 352);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(38, 16);
		this.label10.TabIndex = 192;
		this.label10.Text = "Web:";
		this.nudTimesWarning.Location = new System.Drawing.Point(247, 320);
		this.nudTimesWarning.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimesWarning.Name = "nudTimesWarning";
		this.nudTimesWarning.Size = new System.Drawing.Size(43, 23);
		this.nudTimesWarning.TabIndex = 117;
		this.A6086839.AutoSize = true;
		this.A6086839.Location = new System.Drawing.Point(293, 322);
		this.A6086839.Name = "label9";
		this.A6086839.Size = new System.Drawing.Size(24, 16);
		this.A6086839.TabIndex = 119;
		this.A6086839.Text = "lần";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(21, 322);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(225, 16);
		this.label8.TabIndex = 118;
		this.label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		this.plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuongTac.Controls.Add(this.A293E318);
		this.plTuongTac.Controls.Add(this.ckbTuongTacComment);
		this.plTuongTac.Controls.Add(this.label19);
		this.plTuongTac.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.plTuongTac.Controls.Add(this.ckbTuongTacLike);
		this.plTuongTac.Controls.Add(this.E41D2D8D);
		this.plTuongTac.Controls.Add(this.nudTuongTacDelayFrom);
		this.plTuongTac.Controls.Add(this.nudSoLuongBaiVietTo);
		this.plTuongTac.Controls.Add(this.nudTuongTacDelayTo);
		this.plTuongTac.Controls.Add(this.label67);
		this.plTuongTac.Controls.Add(this.label48);
		this.plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.plTuongTac.Location = new System.Drawing.Point(360, 74);
		this.plTuongTac.Name = "plTuongTac";
		this.plTuongTac.Size = new System.Drawing.Size(310, 299);
		this.plTuongTac.TabIndex = 116;
		this.A293E318.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A293E318.Controls.Add(this.AAA86136);
		this.A293E318.Controls.Add(this.label17);
		this.A293E318.Controls.Add(this.txtComment);
		this.A293E318.Controls.Add(this.C38628B5);
		this.A293E318.Location = new System.Drawing.Point(25, 113);
		this.A293E318.Name = "plTuongTacComment";
		this.A293E318.Size = new System.Drawing.Size(278, 180);
		this.A293E318.TabIndex = 93;
		this.AAA86136.AutoSize = true;
		this.AAA86136.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AAA86136.Location = new System.Drawing.Point(190, 158);
		this.AAA86136.Name = "linkLabel1";
		this.AAA86136.Size = new System.Drawing.Size(81, 16);
		this.AAA86136.TabIndex = 189;
		this.AAA86136.TabStop = true;
		this.AAA86136.Text = "Random icon";
		this.AAA86136.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(AE8A34A2);
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(4, 158);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(131, 16);
		this.label17.TabIndex = 188;
		this.label17.Text = "Spin content: {a|b|c}";
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Multiline = true;
		this.txtComment.Name = "txtComment";
		this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtComment.Size = new System.Drawing.Size(261, 128);
		this.txtComment.TabIndex = 1;
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(E5395298);
		this.C38628B5.AutoSize = true;
		this.C38628B5.Location = new System.Drawing.Point(3, 5);
		this.C38628B5.Name = "lblStatusComment";
		this.C38628B5.Size = new System.Drawing.Size(139, 16);
		this.C38628B5.TabIndex = 0;
		this.C38628B5.Text = "Nội dung bình luận (0):";
		this.ckbTuongTacComment.AutoSize = true;
		this.ckbTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacComment.Location = new System.Drawing.Point(7, 88);
		this.ckbTuongTacComment.Name = "ckbTuongTacComment";
		this.ckbTuongTacComment.Size = new System.Drawing.Size(130, 20);
		this.ckbTuongTacComment.TabIndex = 92;
		this.ckbTuongTacComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		this.ckbTuongTacComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacComment.CheckedChanged += new System.EventHandler(ckbTuongTacComment_CheckedChanged);
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label19.Location = new System.Drawing.Point(4, 7);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(72, 16);
		this.label19.TabIndex = 89;
		this.label19.Text = "Sô\u0301 ba\u0300i viê\u0301t:";
		this.nudSoLuongBaiVietFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(129, 5);
		this.nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(42, 23);
		this.nudSoLuongBaiVietFrom.TabIndex = 2;
		this.nudSoLuongBaiVietFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.ckbTuongTacLike.AutoSize = true;
		this.ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacLike.Location = new System.Drawing.Point(7, 62);
		this.ckbTuongTacLike.Name = "ckbTuongTacLike";
		this.ckbTuongTacLike.Size = new System.Drawing.Size(48, 20);
		this.ckbTuongTacLike.TabIndex = 5;
		this.ckbTuongTacLike.Text = "Like";
		this.ckbTuongTacLike.UseVisualStyleBackColor = true;
		this.E41D2D8D.AutoSize = true;
		this.E41D2D8D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E41D2D8D.Location = new System.Drawing.Point(4, 36);
		this.E41D2D8D.Name = "label46";
		this.E41D2D8D.Size = new System.Drawing.Size(119, 16);
		this.E41D2D8D.TabIndex = 89;
		this.E41D2D8D.Text = "Thơ\u0300i gian delay (s):";
		this.nudTuongTacDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayFrom.Location = new System.Drawing.Point(129, 34);
		this.nudTuongTacDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
		this.nudTuongTacDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacDelayFrom.TabIndex = 3;
		this.nudTuongTacDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.nudSoLuongBaiVietTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(206, 6);
		this.nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(47, 23);
		this.nudSoLuongBaiVietTo.TabIndex = 4;
		this.nudSoLuongBaiVietTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudTuongTacDelayTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayTo.Location = new System.Drawing.Point(206, 35);
		this.nudTuongTacDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
		this.nudTuongTacDelayTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacDelayTo.TabIndex = 4;
		this.nudTuongTacDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label67.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label67.Location = new System.Drawing.Point(174, 8);
		this.label67.Name = "label67";
		this.label67.Size = new System.Drawing.Size(29, 16);
		this.label67.TabIndex = 91;
		this.label67.Text = ">";
		this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label48.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label48.Location = new System.Drawing.Point(174, 39);
		this.label48.Name = "label48";
		this.label48.Size = new System.Drawing.Size(29, 16);
		this.label48.TabIndex = 91;
		this.label48.Text = ">";
		this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F711800F.AutoSize = true;
		this.F711800F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F711800F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.F711800F.Location = new System.Drawing.Point(342, 51);
		this.F711800F.Name = "ckbTuongTac";
		this.F711800F.Size = new System.Drawing.Size(184, 20);
		this.F711800F.TabIndex = 115;
		this.F711800F.Text = "Tương tác trước khi kết bạn";
		this.F711800F.UseVisualStyleBackColor = true;
		this.F711800F.CheckedChanged += new System.EventHandler(F711800F_CheckedChanged);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(24, 159);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(295, 133);
		this.txtUid.TabIndex = 114;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(AC9C73AC);
		this.nudDelayTo.Location = new System.Drawing.Point(222, 107);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(20, 137);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(184, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch Uid cần kết bạn (0):";
		this.nudDelayFrom.Location = new System.Drawing.Point(125, 107);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.D7AFE2AB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D7AFE2AB.Location = new System.Drawing.Point(187, 109);
		this.D7AFE2AB.Name = "label7";
		this.D7AFE2AB.Size = new System.Drawing.Size(29, 16);
		this.D7AFE2AB.TabIndex = 46;
		this.D7AFE2AB.Text = ">";
		this.D7AFE2AB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(280, 109);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 45;
		this.label6.Text = "giây";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(20, 109);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 44;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.nudSoLuongTo.Location = new System.Drawing.Point(222, 78);
		this.nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTo.Name = "nudSoLuongTo";
		this.nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongTo.TabIndex = 2;
		this.nudSoLuongFrom.Location = new System.Drawing.Point(125, 78);
		this.nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongFrom.Name = "nudSoLuongFrom";
		this.nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongFrom.TabIndex = 1;
		this.DE37B9BD.Location = new System.Drawing.Point(125, 49);
		this.DE37B9BD.Name = "txtTenHanhDong";
		this.DE37B9BD.Size = new System.Drawing.Size(194, 23);
		this.DE37B9BD.TabIndex = 0;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(187, 80);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = ">";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(280, 80);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0323n";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(20, 80);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 16);
		this.label2.TabIndex = 32;
		this.label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		this.CA2A90A8.AutoSize = true;
		this.CA2A90A8.Location = new System.Drawing.Point(20, 52);
		this.CA2A90A8.Name = "label1";
		this.CA2A90A8.Size = new System.Drawing.Size(98, 16);
		this.CA2A90A8.TabIndex = 31;
		this.CA2A90A8.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(355, 390);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.FF86AF27.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.FF86AF27.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.FF86AF27.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FF86AF27.FlatAppearance.BorderSize = 0;
		this.FF86AF27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FF86AF27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FF86AF27.ForeColor = System.Drawing.Color.White;
		this.FF86AF27.Location = new System.Drawing.Point(248, 390);
		this.FF86AF27.Name = "btnAdd";
		this.FF86AF27.Size = new System.Drawing.Size(92, 29);
		this.FF86AF27.TabIndex = 6;
		this.FF86AF27.Text = "Thêm";
		this.FF86AF27.UseVisualStyleBackColor = false;
		this.FF86AF27.Click += new System.EventHandler(FF86AF27_Click);
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
		this.bunifuCards1.Size = new System.Drawing.Size(695, 37);
		this.bunifuCards1.TabIndex = 28;
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(24, 297);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(248, 20);
		this.ckbTuDongXoaUid.TabIndex = 113;
		this.ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 gư\u0309i lơ\u0300i mơ\u0300i kê\u0301t ba\u0323n";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.F32EFE12.AutoSize = true;
		this.F32EFE12.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F32EFE12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.F32EFE12.Location = new System.Drawing.Point(247, 351);
		this.F32EFE12.Name = "ckbAddFriendApi";
		this.F32EFE12.Size = new System.Drawing.Size(99, 20);
		this.F32EFE12.TabIndex = 113;
		this.F32EFE12.Text = "Run API (ẩn)";
		this.F32EFE12.UseVisualStyleBackColor = true;
		this.E41ABA96.AutomaticDelay = 0;
		this.E41ABA96.AutoPopDelay = 0;
		this.E41ABA96.InitialDelay = 0;
		this.E41ABA96.ReshowDelay = 0;
		this.E41ABA96.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(698, 434);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E389E8AC_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E634163B).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimesWarning).EndInit();
		this.plTuongTac.ResumeLayout(false);
		this.plTuongTac.PerformLayout();
		this.A293E318.ResumeLayout(false);
		this.A293E318.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
