using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDPhanHoiBinhLuan : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool C7898DA0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown E0197E20;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label DC3D4BAA;

	private Label label5;

	private Label E2A59B2D;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox AD2A3A34;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudTimeFrom;

	private Label label9;

	private Label ECA64EBC;

	private Label label3;

	private Panel E50205AB;

	private TextBox txtAnh;

	private RichTextBox txtIdPost;

	private CheckBox ckbSendAnh;

	private CheckBox ckbComment;

	private Label label12;

	private Label label49;

	private NumericUpDown CDA10DA6;

	private Label label68;

	private NumericUpDown nudSoLuongUidTo;

	private Label B8A101A8;

	private Panel AE1B8994;

	private CheckBox A9861206;

	private Panel EFA4EFAE;

	private RadioButton rbNganCachMoiDong;

	private Button FB11428C;

	private Button button2;

	private RadioButton BEA995A8;

	private LinkLabel linkLabel1;

	private Panel panel3;

	private RadioButton rbCommentTheoThuTu;

	private RadioButton A5A33395;

	private Label label13;

	private Label D908BF32;

	private RichTextBox C435ED24;

	private Label label11;

	private Label lblStatus;

	public fHDPhanHoiBinhLuan(string string_3, int int_1 = 0, string E2158D25 = "")
	{
		InitializeComponent();
		C7898DA0 = false;
		string_0 = string_3;
		string_2 = E2158D25;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Phản hồi bình luận";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(E2158D25);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void D2216D16(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = gclass8_0.GetValueInt("nudTimeFrom", 3);
			nudTimeTo.Value = gclass8_0.GetValueInt("nudTimeTo", 5);
			E0197E20.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			CDA10DA6.Value = gclass8_0.GetValueInt("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass8_0.GetValueInt("nudSoLuongUidTo", 3);
			AD2A3A34.Checked = gclass8_0.GetValueBool("ckbInteract");
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			C435ED24.Text = gclass8_0.GetValue("txtComment");
			txtIdPost.Text = gclass8_0.GetValue("txtIdPost");
			ckbSendAnh.Checked = gclass8_0.GetValueBool("ckbSendAnh");
			txtAnh.Text = gclass8_0.GetValue("txtAnh");
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				BEA995A8.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			if (gclass8_0.GetValueInt("typeComment") == 1)
			{
				A5A33395.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
			}
			A9861206.Checked = gclass8_0.GetValueBool("ckbAutoDeleteComment");
		}
		catch
		{
		}
		method_0();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E78A863A(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> a2AB53A = txtIdPost.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudTimeFrom", nudTimeFrom.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", E0197E20.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("nudSoLuongUidFrom", CDA10DA6.Value);
		gClass.GetJson("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.GetJson("ckbInteract", AD2A3A34.Checked);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", C435ED24.Text.Trim());
		gClass.GetJson("txtIdPost", txtIdPost.Text.Trim());
		gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (BEA995A8.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		int num2 = 0;
		if (A5A33395.Checked)
		{
			num2 = 1;
		}
		gClass.GetJson("typeComment", num2);
		gClass.GetJson("ckbAutoDeleteComment", A9861206.Checked);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					C7898DA0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (InteractSQL.smethod_13(string_2, text, string_))
			{
				C7898DA0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FAB0C131(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void DB1F648E(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = C435ED24.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_0()
	{
		E983D1BD(null, null);
		ckbComment_CheckedChanged(null, null);
		method_3(null, null);
		method_4(null, null);
	}

	private void E983D1BD(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		AE1B8994.Enabled = ckbComment.Checked;
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtIdPost, label2);
	}

	private void DD07882D(object sender, EventArgs e)
	{
		E50205AB.Enabled = ckbSendAnh.Checked;
	}

	private void D88EF6AA(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void B6A89F1B(object sender, EventArgs e)
	{
	}

	private void rbCommentTheoThuTu_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void CDBBCF1B(object sender, EventArgs e)
	{
	}

	private void A5A33395_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void E9B2FB84(object sender, EventArgs e)
	{
		AE1B8994.Height = 195;
	}

	private void method_1(object sender, EventArgs e)
	{
		AE1B8994.Height = 267;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		C435ED24.Focus();
	}

	private void FB11428C_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		C435ED24.Focus();
	}

	private void C435ED24_TextChanged(object sender, EventArgs e)
	{
		int num = 0;
		if (BEA995A8.Checked)
		{
			num = 1;
		}
		Common.F9202C12(C435ED24, lblStatus, num);
	}

	private void method_2(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void DF27CCB9(object sender, EventArgs e)
	{
		Common.F9202C12(C435ED24, lblStatus);
	}

	private void BEA995A8_CheckedChanged(object sender, EventArgs e)
	{
		Common.F9202C12(C435ED24, lblStatus, 1);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDPhanHoiBinhLuan));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.AE1B8994 = new System.Windows.Forms.Panel();
		this.A9861206 = new System.Windows.Forms.CheckBox();
		this.EFA4EFAE = new System.Windows.Forms.Panel();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.FB11428C = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.BEA995A8 = new System.Windows.Forms.RadioButton();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		this.A5A33395 = new System.Windows.Forms.RadioButton();
		this.label13 = new System.Windows.Forms.Label();
		this.D908BF32 = new System.Windows.Forms.Label();
		this.C435ED24 = new System.Windows.Forms.RichTextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.CDA10DA6 = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.B8A101A8 = new System.Windows.Forms.Label();
		this.E50205AB = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.txtIdPost = new System.Windows.Forms.RichTextBox();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.AD2A3A34 = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		this.E0197E20 = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.ECA64EBC = new System.Windows.Forms.Label();
		this.DC3D4BAA = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.E2A59B2D = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.AE1B8994.SuspendLayout();
		this.EFA4EFAE.SuspendLayout();
		this.panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.CDA10DA6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		this.E50205AB.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E0197E20).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(666, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Phản hồi bình luận";
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
		this.pnlHeader.Size = new System.Drawing.Size(666, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(635, 1);
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
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.AE1B8994);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.CDA10DA6);
		this.panel1.Controls.Add(this.label68);
		this.panel1.Controls.Add(this.nudSoLuongUidTo);
		this.panel1.Controls.Add(this.B8A101A8);
		this.panel1.Controls.Add(this.E50205AB);
		this.panel1.Controls.Add(this.txtIdPost);
		this.panel1.Controls.Add(this.ckbSendAnh);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.AD2A3A34);
		this.panel1.Controls.Add(this.nudTimeTo);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudTimeFrom);
		this.panel1.Controls.Add(this.E0197E20);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.ECA64EBC);
		this.panel1.Controls.Add(this.DC3D4BAA);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.E2A59B2D);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(669, 460);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(D88EF6AA);
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(FAB0C131);
		this.AE1B8994.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.AE1B8994.Controls.Add(this.A9861206);
		this.AE1B8994.Controls.Add(this.EFA4EFAE);
		this.AE1B8994.Controls.Add(this.linkLabel1);
		this.AE1B8994.Controls.Add(this.panel3);
		this.AE1B8994.Controls.Add(this.label13);
		this.AE1B8994.Controls.Add(this.D908BF32);
		this.AE1B8994.Controls.Add(this.C435ED24);
		this.AE1B8994.Controls.Add(this.label11);
		this.AE1B8994.Controls.Add(this.lblStatus);
		this.AE1B8994.Location = new System.Drawing.Point(371, 120);
		this.AE1B8994.Name = "plCommentText";
		this.AE1B8994.Size = new System.Drawing.Size(262, 219);
		this.AE1B8994.TabIndex = 164;
		this.A9861206.AutoSize = true;
		this.A9861206.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A9861206.Location = new System.Drawing.Point(8, 195);
		this.A9861206.Name = "ckbAutoDeleteComment";
		this.A9861206.Size = new System.Drawing.Size(225, 20);
		this.A9861206.TabIndex = 176;
		this.A9861206.Text = "Tự động xóa nội dung đã bình luận";
		this.A9861206.UseVisualStyleBackColor = true;
		this.EFA4EFAE.Controls.Add(this.rbNganCachMoiDong);
		this.EFA4EFAE.Controls.Add(this.FB11428C);
		this.EFA4EFAE.Controls.Add(this.button2);
		this.EFA4EFAE.Controls.Add(this.BEA995A8);
		this.EFA4EFAE.Location = new System.Drawing.Point(67, 147);
		this.EFA4EFAE.Name = "panel2";
		this.EFA4EFAE.Size = new System.Drawing.Size(200, 43);
		this.EFA4EFAE.TabIndex = 42;
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(3, 3);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		this.rbNganCachMoiDong.TabIndex = 3;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(DF27CCB9);
		this.FB11428C.Cursor = System.Windows.Forms.Cursors.Help;
		this.FB11428C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FB11428C.Location = new System.Drawing.Point(165, 22);
		this.FB11428C.Name = "button3";
		this.FB11428C.Size = new System.Drawing.Size(21, 21);
		this.FB11428C.TabIndex = 172;
		this.FB11428C.Text = "?";
		this.FB11428C.UseVisualStyleBackColor = true;
		this.FB11428C.Click += new System.EventHandler(FB11428C_Click);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(165, 1);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 21);
		this.button2.TabIndex = 173;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.BEA995A8.AutoSize = true;
		this.BEA995A8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BEA995A8.Location = new System.Drawing.Point(3, 24);
		this.BEA995A8.Name = "rbNganCachKyTu";
		this.BEA995A8.Size = new System.Drawing.Size(159, 20);
		this.BEA995A8.TabIndex = 3;
		this.BEA995A8.Text = "Nội dung có nhiều dòng";
		this.BEA995A8.UseVisualStyleBackColor = true;
		this.BEA995A8.CheckedChanged += new System.EventHandler(BEA995A8_CheckedChanged);
		this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(173, 127);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 175;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.panel3.Controls.Add(this.rbCommentTheoThuTu);
		this.panel3.Controls.Add(this.A5A33395);
		this.panel3.Location = new System.Drawing.Point(67, 300);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(200, 43);
		this.panel3.TabIndex = 43;
		this.rbCommentTheoThuTu.AutoSize = true;
		this.rbCommentTheoThuTu.Checked = true;
		this.rbCommentTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCommentTheoThuTu.Location = new System.Drawing.Point(3, 2);
		this.rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
		this.rbCommentTheoThuTu.Size = new System.Drawing.Size(201, 20);
		this.rbCommentTheoThuTu.TabIndex = 3;
		this.rbCommentTheoThuTu.TabStop = true;
		this.rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
		this.rbCommentTheoThuTu.UseVisualStyleBackColor = true;
		this.rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(rbCommentTheoThuTu_CheckedChanged);
		this.A5A33395.AutoSize = true;
		this.A5A33395.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A5A33395.Location = new System.Drawing.Point(3, 23);
		this.A5A33395.Name = "rbCommentNgauNhien";
		this.A5A33395.Size = new System.Drawing.Size(200, 20);
		this.A5A33395.TabIndex = 3;
		this.A5A33395.Text = "Comment ngẫu nhiên nội dung";
		this.A5A33395.UseVisualStyleBackColor = true;
		this.A5A33395.CheckedChanged += new System.EventHandler(A5A33395_CheckedChanged);
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(4, 302);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(64, 16);
		this.label13.TabIndex = 2;
		this.label13.Text = "Tùy chọn:";
		this.label13.Click += new System.EventHandler(CDBBCF1B);
		this.D908BF32.AutoSize = true;
		this.D908BF32.Location = new System.Drawing.Point(4, 150);
		this.D908BF32.Name = "label8";
		this.D908BF32.Size = new System.Drawing.Size(64, 16);
		this.D908BF32.TabIndex = 2;
		this.D908BF32.Text = "Tùy chọn:";
		this.C435ED24.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C435ED24.Location = new System.Drawing.Point(7, 25);
		this.C435ED24.Name = "txtComment";
		this.C435ED24.Size = new System.Drawing.Size(246, 102);
		this.C435ED24.TabIndex = 1;
		this.C435ED24.Text = "";
		this.C435ED24.WordWrap = false;
		this.C435ED24.TextChanged += new System.EventHandler(C435ED24_TextChanged);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(5, 128);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(133, 16);
		this.label11.TabIndex = 0;
		this.label11.Text = "Spin nội dung {a|b|c}";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(26, 108);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(107, 16);
		this.label49.TabIndex = 169;
		this.label49.Text = "Sô\u0301 lươ\u0323ng ID/Nick:";
		this.CDA10DA6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.CDA10DA6.Location = new System.Drawing.Point(134, 106);
		this.CDA10DA6.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.CDA10DA6.Name = "nudSoLuongUidFrom";
		this.CDA10DA6.Size = new System.Drawing.Size(56, 23);
		this.CDA10DA6.TabIndex = 167;
		this.CDA10DA6.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(289, 108);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(19, 16);
		this.label68.TabIndex = 170;
		this.label68.Text = "ID";
		this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidTo.Location = new System.Drawing.Point(231, 106);
		this.nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidTo.TabIndex = 168;
		this.nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.B8A101A8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.B8A101A8.Location = new System.Drawing.Point(196, 108);
		this.B8A101A8.Name = "label66";
		this.B8A101A8.Size = new System.Drawing.Size(29, 16);
		this.B8A101A8.TabIndex = 171;
		this.B8A101A8.Text = "đê\u0301n";
		this.B8A101A8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.E50205AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.E50205AB.Controls.Add(this.txtAnh);
		this.E50205AB.Controls.Add(this.label12);
		this.E50205AB.Enabled = false;
		this.E50205AB.Location = new System.Drawing.Point(371, 366);
		this.E50205AB.Name = "plAnh";
		this.E50205AB.Size = new System.Drawing.Size(262, 31);
		this.E50205AB.TabIndex = 166;
		this.txtAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtAnh.Location = new System.Drawing.Point(82, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(175, 23);
		this.txtAnh.TabIndex = 155;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(73, 16);
		this.label12.TabIndex = 39;
		this.label12.Text = "Folder ảnh:";
		this.label12.Click += new System.EventHandler(B6A89F1B);
		this.txtIdPost.Location = new System.Drawing.Point(30, 154);
		this.txtIdPost.Name = "txtIdPost";
		this.txtIdPost.Size = new System.Drawing.Size(297, 245);
		this.txtIdPost.TabIndex = 1;
		this.txtIdPost.Text = "";
		this.txtIdPost.WordWrap = false;
		this.txtIdPost.TextChanged += new System.EventHandler(txtIdPost_TextChanged);
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(353, 343);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		this.ckbSendAnh.TabIndex = 165;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(DD07882D);
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(353, 100);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(78, 20);
		this.ckbComment.TabIndex = 163;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 135);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(167, 16);
		this.label2.TabIndex = 40;
		this.label2.Text = "Danh sa\u0301ch ID Comment (0):";
		this.AD2A3A34.AutoSize = true;
		this.AD2A3A34.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AD2A3A34.Location = new System.Drawing.Point(353, 76);
		this.AD2A3A34.Name = "ckbInteract";
		this.AD2A3A34.Size = new System.Drawing.Size(48, 20);
		this.AD2A3A34.TabIndex = 5;
		this.AD2A3A34.Text = "Like";
		this.AD2A3A34.UseVisualStyleBackColor = true;
		this.nudTimeTo.Location = new System.Drawing.Point(568, 50);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(51, 23);
		this.nudTimeTo.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(231, 78);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.nudTimeFrom.Location = new System.Drawing.Point(490, 50);
		this.nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeFrom.Name = "nudTimeFrom";
		this.nudTimeFrom.Size = new System.Drawing.Size(51, 23);
		this.nudTimeFrom.TabIndex = 3;
		this.E0197E20.Location = new System.Drawing.Point(134, 78);
		this.E0197E20.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E0197E20.Name = "nudDelayFrom";
		this.E0197E20.Size = new System.Drawing.Size(56, 23);
		this.E0197E20.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label9.Location = new System.Drawing.Point(541, 52);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 38;
		this.label9.Text = "đê\u0301n";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label7.Location = new System.Drawing.Point(196, 80);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ECA64EBC.AutoSize = true;
		this.ECA64EBC.Location = new System.Drawing.Point(621, 52);
		this.ECA64EBC.Name = "label4";
		this.ECA64EBC.Size = new System.Drawing.Size(30, 16);
		this.ECA64EBC.TabIndex = 36;
		this.ECA64EBC.Text = "giây";
		this.DC3D4BAA.AutoSize = true;
		this.DC3D4BAA.Location = new System.Drawing.Point(289, 80);
		this.DC3D4BAA.Name = "label6";
		this.DC3D4BAA.Size = new System.Drawing.Size(30, 16);
		this.DC3D4BAA.TabIndex = 36;
		this.DC3D4BAA.Text = "giây";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(350, 52);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(138, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Thơ\u0300i gian xem bài viết:";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 80);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chờ:";
		this.E2A59B2D.AutoSize = true;
		this.E2A59B2D.Location = new System.Drawing.Point(27, 52);
		this.E2A59B2D.Name = "label1";
		this.E2A59B2D.Size = new System.Drawing.Size(98, 16);
		this.E2A59B2D.TabIndex = 31;
		this.E2A59B2D.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(340, 418);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(233, 418);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(E78A863A);
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
		this.bunifuCards1.Size = new System.Drawing.Size(666, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(669, 460);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDPhanHoiBinhLuan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D2216D16);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.AE1B8994.ResumeLayout(false);
		this.AE1B8994.PerformLayout();
		this.EFA4EFAE.ResumeLayout(false);
		this.EFA4EFAE.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.CDA10DA6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		this.E50205AB.ResumeLayout(false);
		this.E50205AB.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E0197E20).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
