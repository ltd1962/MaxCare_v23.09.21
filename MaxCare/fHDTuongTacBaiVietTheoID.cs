using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBaiVietTheoID : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string F20A9A31;

	private string string_1;

	private int ED00D407;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl CC007A88;

	private Panel F703A2B7;

	private NumericUpDown DA2BC9BF;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label B2AB4BAB;

	private Label label5;

	private Label C08DAD8A;

	private Button F2BB9FA6;

	private Button btnAdd;

	private BunifuCards B60738AC;

	private Panel pnlHeader;

	private Button B437E02C;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox B18C643D;

	private CheckBox ckbShareWall;

	private Label label10;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown D496F4B0;

	private Label label9;

	private Label label4;

	private Label label3;

	private Panel plComment;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label8;

	private RichTextBox txtComment;

	private Label F3B8D59C;

	private Label F59FE227;

	private Panel BC20F616;

	private TextBox txtAnh;

	private RichTextBox txtIdPost;

	private CheckBox ckbSendAnh;

	private CheckBox AB8A3DBF;

	private Label label12;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label68;

	private NumericUpDown CDBDDE11;

	private Label label66;

	private RadioButton rbCommentNgauNhien;

	private RadioButton rbCommentTheoThuTu;

	private Label label13;

	private Button btnDown;

	private Button BEA2D724;

	private Panel panel2;

	private Panel panel3;

	private Button button3;

	private Button C9160602;

	private Button button4;

	private LinkLabel linkLabel1;

	private CheckBox C834F18B;

	public fHDTuongTacBaiVietTheoID(string string_2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		ED00D407 = int_0;
		if (InteractSQL.B484648C("", "HDTuongTacBaiVietTheoID").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietTheoID', 'Tương tác bài viết theo ID');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDTuongTacBaiVietTheoID");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			F20A9A31 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
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
		Language.smethod_0(C08DAD8A);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(B2AB4BAB);
		Language.smethod_0(label49);
		Language.smethod_0(label66);
		Language.smethod_0(label2);
		Language.smethod_0(label10);
		Language.smethod_0(label3);
		Language.smethod_0(label9);
		Language.smethod_0(label4);
		Language.smethod_0(B18C643D);
		Language.smethod_0(ckbShareWall);
		Language.smethod_0(AB8A3DBF);
		Language.smethod_0(F59FE227);
		Language.smethod_0(F3B8D59C);
		Language.smethod_0(label8);
		Language.smethod_0(rbNganCachMoiDong);
		Language.smethod_0(C9160602);
		Language.smethod_0(rbNganCachKyTu);
		Language.smethod_0(button3);
		Language.smethod_0(ckbSendAnh);
		Language.smethod_0(label12);
		Language.smethod_0(btnAdd);
		Language.smethod_0(F2BB9FA6);
		Language.smethod_0(label13);
		Language.smethod_0(rbCommentTheoThuTu);
		Language.smethod_0(rbCommentNgauNhien);
	}

	private void fHDTuongTacBaiVietTheoID_Load(object sender, EventArgs e)
	{
		try
		{
			D496F4B0.Value = gclass8_0.GetValueInt("nudTimeFrom", 3);
			nudTimeTo.Value = gclass8_0.GetValueInt("nudTimeTo", 5);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			DA2BC9BF.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			nudSoLuongUidFrom.Value = gclass8_0.GetValueInt("nudSoLuongUidFrom", 1);
			CDBDDE11.Value = gclass8_0.GetValueInt("nudSoLuongUidTo", 3);
			B18C643D.Checked = gclass8_0.GetValueBool("ckbInteract");
			ckbShareWall.Checked = gclass8_0.GetValueBool("ckbShareWall");
			AB8A3DBF.Checked = gclass8_0.GetValueBool("ckbComment");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			txtIdPost.Text = gclass8_0.GetValue("txtIdPost");
			C834F18B.Checked = gclass8_0.GetValueBool("ckbTuDongXoa");
			ckbSendAnh.Checked = gclass8_0.GetValueBool("ckbSendAnh");
			txtAnh.Text = gclass8_0.GetValue("txtAnh");
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			if (gclass8_0.GetValueInt("typeComment") == 1)
			{
				rbCommentNgauNhien.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
			}
		}
		catch
		{
		}
		method_1();
	}

	private void B437E02C_Click(object sender, EventArgs e)
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
		List<string> a2AB53A = txtIdPost.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id ba\u0300i viê\u0301t câ\u0300n tương tác!", 3);
			return;
		}
		if (AB8A3DBF.Checked)
		{
			List<string> a2AB53A2 = txtComment.Lines.ToList();
			a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
			if (a2AB53A2.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudTimeFrom", D496F4B0.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", DA2BC9BF.Value);
		gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.GetJson("nudSoLuongUidTo", CDBDDE11.Value);
		gClass.GetJson("ckbInteract", B18C643D.Checked);
		gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
		gClass.GetJson("ckbComment", AB8A3DBF.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("txtIdPost", txtIdPost.Text.Trim());
		gClass.GetJson("ckbTuDongXoa", C834F18B.Checked);
		gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		int num2 = 0;
		if (rbCommentNgauNhien.Checked)
		{
			num2 = 1;
		}
		gClass.GetJson("typeComment", num2);
		string string_ = gClass.D9A09B34();
		if (ED00D407 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, F20A9A31, string_))
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

	private void F2BB9FA6_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A0945631(object sender, PaintEventArgs e)
	{
		if (F703A2B7.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F703A2B7.ClientSize.Width - num, F703A2B7.ClientSize.Height - num));
		}
	}

	private void F98E2132(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtComment.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			F59FE227.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		F81B701E(null, null);
		AB8A3DBF_CheckedChanged(null, null);
	}

	private void F81B701E(object sender, EventArgs e)
	{
	}

	private void AB8A3DBF_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = AB8A3DBF.Checked;
	}

	private void B215DB25(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtIdPost.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			label2.Text = string.Format(Language.GetValue("Danh sa\u0301ch ID bài viết ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		BC20F616.Enabled = ckbSendAnh.Checked;
	}

	private void ACA343A2(object sender, EventArgs e)
	{
	}

	private void EA976E9F(object sender, EventArgs e)
	{
	}

	private void label12_Click(object sender, EventArgs e)
	{
	}

	private void C736790F(object sender, EventArgs e)
	{
	}

	private void label13_Click(object sender, EventArgs e)
	{
	}

	private void FA3C2B3E(object sender, EventArgs e)
	{
	}

	private void BEA2D724_Click(object sender, EventArgs e)
	{
		plComment.Height = 195;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plComment.Height = 237;
	}

	private void C9160602_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacBaiVietTheoID));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.CC007A88 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.B437E02C = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.F703A2B7 = new System.Windows.Forms.Panel();
		this.C834F18B = new System.Windows.Forms.CheckBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.button3 = new System.Windows.Forms.Button();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.C9160602 = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.CDBDDE11 = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.plComment = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		this.rbCommentNgauNhien = new System.Windows.Forms.RadioButton();
		this.btnDown = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.BEA2D724 = new System.Windows.Forms.Button();
		this.label13 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.F3B8D59C = new System.Windows.Forms.Label();
		this.F59FE227 = new System.Windows.Forms.Label();
		this.BC20F616 = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.txtIdPost = new System.Windows.Forms.RichTextBox();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.AB8A3DBF = new System.Windows.Forms.CheckBox();
		this.label10 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.B18C643D = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.DA2BC9BF = new System.Windows.Forms.NumericUpDown();
		this.D496F4B0 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.B2AB4BAB = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.C08DAD8A = new System.Windows.Forms.Label();
		this.F2BB9FA6 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.B60738AC = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.F703A2B7.SuspendLayout();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CDBDDE11).BeginInit();
		this.plComment.SuspendLayout();
		this.panel3.SuspendLayout();
		this.BC20F616.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DA2BC9BF).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D496F4B0).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.B60738AC.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(684, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Tương tác ba\u0300i viê\u0301t theo ID";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CC007A88.Fixed = true;
		this.CC007A88.Horizontal = true;
		this.CC007A88.TargetControl = this.pnlHeader;
		this.CC007A88.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.B437E02C);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(684, 31);
		this.pnlHeader.TabIndex = 9;
		this.B437E02C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.B437E02C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B437E02C.FlatAppearance.BorderSize = 0;
		this.B437E02C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.B437E02C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B437E02C.ForeColor = System.Drawing.Color.White;
		this.B437E02C.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.B437E02C.Location = new System.Drawing.Point(653, 1);
		this.B437E02C.Name = "button1";
		this.B437E02C.Size = new System.Drawing.Size(30, 30);
		this.B437E02C.TabIndex = 77;
		this.B437E02C.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.B437E02C.UseVisualStyleBackColor = true;
		this.B437E02C.Click += new System.EventHandler(B437E02C_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(EA976E9F);
		this.F703A2B7.BackColor = System.Drawing.Color.White;
		this.F703A2B7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F703A2B7.Controls.Add(this.C834F18B);
		this.F703A2B7.Controls.Add(this.panel2);
		this.F703A2B7.Controls.Add(this.label49);
		this.F703A2B7.Controls.Add(this.nudSoLuongUidFrom);
		this.F703A2B7.Controls.Add(this.label68);
		this.F703A2B7.Controls.Add(this.CDBDDE11);
		this.F703A2B7.Controls.Add(this.label66);
		this.F703A2B7.Controls.Add(this.plComment);
		this.F703A2B7.Controls.Add(this.BC20F616);
		this.F703A2B7.Controls.Add(this.txtIdPost);
		this.F703A2B7.Controls.Add(this.ckbSendAnh);
		this.F703A2B7.Controls.Add(this.AB8A3DBF);
		this.F703A2B7.Controls.Add(this.label10);
		this.F703A2B7.Controls.Add(this.label2);
		this.F703A2B7.Controls.Add(this.ckbShareWall);
		this.F703A2B7.Controls.Add(this.B18C643D);
		this.F703A2B7.Controls.Add(this.nudTimeTo);
		this.F703A2B7.Controls.Add(this.DA2BC9BF);
		this.F703A2B7.Controls.Add(this.D496F4B0);
		this.F703A2B7.Controls.Add(this.nudDelayFrom);
		this.F703A2B7.Controls.Add(this.txtTenHanhDong);
		this.F703A2B7.Controls.Add(this.label9);
		this.F703A2B7.Controls.Add(this.label7);
		this.F703A2B7.Controls.Add(this.label4);
		this.F703A2B7.Controls.Add(this.B2AB4BAB);
		this.F703A2B7.Controls.Add(this.label3);
		this.F703A2B7.Controls.Add(this.label5);
		this.F703A2B7.Controls.Add(this.C08DAD8A);
		this.F703A2B7.Controls.Add(this.F2BB9FA6);
		this.F703A2B7.Controls.Add(this.btnAdd);
		this.F703A2B7.Controls.Add(this.B60738AC);
		this.F703A2B7.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.F703A2B7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.F703A2B7.Location = new System.Drawing.Point(0, 0);
		this.F703A2B7.Name = "panel1";
		this.F703A2B7.Size = new System.Drawing.Size(687, 467);
		this.F703A2B7.TabIndex = 0;
		this.F703A2B7.Click += new System.EventHandler(ACA343A2);
		this.F703A2B7.Paint += new System.Windows.Forms.PaintEventHandler(A0945631);
		this.C834F18B.AutoSize = true;
		this.C834F18B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C834F18B.Location = new System.Drawing.Point(353, 79);
		this.C834F18B.Name = "ckbTuDongXoa";
		this.C834F18B.Size = new System.Drawing.Size(211, 20);
		this.C834F18B.TabIndex = 172;
		this.C834F18B.Text = "Xóa ID bài viết sau khi tương tác";
		this.C834F18B.UseVisualStyleBackColor = true;
		this.panel2.Controls.Add(this.button3);
		this.panel2.Controls.Add(this.rbNganCachMoiDong);
		this.panel2.Controls.Add(this.C9160602);
		this.panel2.Controls.Add(this.rbNganCachKyTu);
		this.panel2.Location = new System.Drawing.Point(439, 299);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(200, 43);
		this.panel2.TabIndex = 42;
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(165, 22);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 21);
		this.button3.TabIndex = 172;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
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
		this.C9160602.Cursor = System.Windows.Forms.Cursors.Help;
		this.C9160602.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C9160602.Location = new System.Drawing.Point(165, 1);
		this.C9160602.Name = "button2";
		this.C9160602.Size = new System.Drawing.Size(21, 21);
		this.C9160602.TabIndex = 173;
		this.C9160602.Text = "?";
		this.C9160602.UseVisualStyleBackColor = true;
		this.C9160602.Click += new System.EventHandler(C9160602_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(3, 24);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 3;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(26, 108);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(99, 16);
		this.label49.TabIndex = 169;
		this.label49.Text = "Sô\u0301 bài viết/nick:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(134, 106);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 167;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label68.AutoSize = true;
		this.label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label68.Location = new System.Drawing.Point(284, 108);
		this.label68.Name = "label68";
		this.label68.Size = new System.Drawing.Size(48, 16);
		this.label68.TabIndex = 170;
		this.label68.Text = "bài viết";
		this.CDBDDE11.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.CDBDDE11.Location = new System.Drawing.Point(227, 106);
		this.CDBDDE11.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.CDBDDE11.Name = "nudSoLuongUidTo";
		this.CDBDDE11.Size = new System.Drawing.Size(56, 23);
		this.CDBDDE11.TabIndex = 168;
		this.CDBDDE11.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(194, 108);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 171;
		this.label66.Text = "đê\u0301n";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.linkLabel1);
		this.plComment.Controls.Add(this.panel3);
		this.plComment.Controls.Add(this.btnDown);
		this.plComment.Controls.Add(this.button4);
		this.plComment.Controls.Add(this.BEA2D724);
		this.plComment.Controls.Add(this.label13);
		this.plComment.Controls.Add(this.label8);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.F3B8D59C);
		this.plComment.Controls.Add(this.F59FE227);
		this.plComment.Location = new System.Drawing.Point(371, 151);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(281, 195);
		this.plComment.TabIndex = 164;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(165, 128);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 180;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.panel3.Controls.Add(this.rbCommentTheoThuTu);
		this.panel3.Controls.Add(this.rbCommentNgauNhien);
		this.panel3.Location = new System.Drawing.Point(67, 191);
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
		this.rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(C736790F);
		this.rbCommentNgauNhien.AutoSize = true;
		this.rbCommentNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCommentNgauNhien.Location = new System.Drawing.Point(3, 23);
		this.rbCommentNgauNhien.Name = "rbCommentNgauNhien";
		this.rbCommentNgauNhien.Size = new System.Drawing.Size(200, 20);
		this.rbCommentNgauNhien.TabIndex = 3;
		this.rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
		this.rbCommentNgauNhien.UseVisualStyleBackColor = true;
		this.rbCommentNgauNhien.CheckedChanged += new System.EventHandler(FA3C2B3E);
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 40;
		this.btnDown.Visible = false;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(249, 126);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 21);
		this.button4.TabIndex = 173;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.BEA2D724.BackgroundImage = Resources.E536C319;
		this.BEA2D724.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BEA2D724.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.BEA2D724.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BEA2D724.Location = new System.Drawing.Point(255, -1);
		this.BEA2D724.Name = "btnUp";
		this.BEA2D724.Size = new System.Drawing.Size(25, 25);
		this.BEA2D724.TabIndex = 41;
		this.BEA2D724.Visible = false;
		this.BEA2D724.Click += new System.EventHandler(BEA2D724_Click);
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(4, 193);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(64, 16);
		this.label13.TabIndex = 2;
		this.label13.Text = "Tùy chọn:";
		this.label13.Click += new System.EventHandler(label13_Click);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 150);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(64, 16);
		this.label8.TabIndex = 2;
		this.label8.Text = "Tùy chọn:";
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(263, 102);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.F3B8D59C.AutoSize = true;
		this.F3B8D59C.Location = new System.Drawing.Point(5, 128);
		this.F3B8D59C.Name = "label11";
		this.F3B8D59C.Size = new System.Drawing.Size(133, 16);
		this.F3B8D59C.TabIndex = 0;
		this.F3B8D59C.Text = "Spin nội dung {a|b|c}";
		this.F59FE227.AutoSize = true;
		this.F59FE227.Location = new System.Drawing.Point(3, 5);
		this.F59FE227.Name = "lblStatus";
		this.F59FE227.Size = new System.Drawing.Size(118, 16);
		this.F59FE227.TabIndex = 0;
		this.F59FE227.Text = "Nội dung bình luận:";
		this.BC20F616.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BC20F616.Controls.Add(this.txtAnh);
		this.BC20F616.Controls.Add(this.label12);
		this.BC20F616.Enabled = false;
		this.BC20F616.Location = new System.Drawing.Point(371, 373);
		this.BC20F616.Name = "plAnh";
		this.BC20F616.Size = new System.Drawing.Size(281, 31);
		this.BC20F616.TabIndex = 166;
		this.txtAnh.Location = new System.Drawing.Point(136, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(140, 23);
		this.txtAnh.TabIndex = 155;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(137, 16);
		this.label12.TabIndex = 39;
		this.label12.Text = "Đường dẫn folder ảnh:";
		this.label12.Click += new System.EventHandler(label12_Click);
		this.txtIdPost.Location = new System.Drawing.Point(30, 152);
		this.txtIdPost.Name = "txtIdPost";
		this.txtIdPost.Size = new System.Drawing.Size(297, 233);
		this.txtIdPost.TabIndex = 1;
		this.txtIdPost.Text = "";
		this.txtIdPost.WordWrap = false;
		this.txtIdPost.TextChanged += new System.EventHandler(B215DB25);
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(353, 349);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		this.ckbSendAnh.TabIndex = 165;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.AB8A3DBF.AutoSize = true;
		this.AB8A3DBF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AB8A3DBF.Location = new System.Drawing.Point(353, 128);
		this.AB8A3DBF.Name = "ckbComment";
		this.AB8A3DBF.Size = new System.Drawing.Size(127, 20);
		this.AB8A3DBF.TabIndex = 163;
		this.AB8A3DBF.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.AB8A3DBF.UseVisualStyleBackColor = true;
		this.AB8A3DBF.CheckedChanged += new System.EventHandler(AB8A3DBF_CheckedChanged);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(27, 388);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(141, 16);
		this.label10.TabIndex = 39;
		this.label10.Text = "(Mỗi ID bài viết 1 dòng)";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 132);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(153, 16);
		this.label2.TabIndex = 40;
		this.label2.Text = "Danh sa\u0301ch ID bài viết (0):";
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(510, 104);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(143, 20);
		this.ckbShareWall.TabIndex = 6;
		this.ckbShareWall.Text = "Chia sẻ bài về tường";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.B18C643D.AutoSize = true;
		this.B18C643D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B18C643D.Location = new System.Drawing.Point(353, 104);
		this.B18C643D.Name = "ckbInteract";
		this.B18C643D.Size = new System.Drawing.Size(93, 20);
		this.B18C643D.TabIndex = 5;
		this.B18C643D.Text = "Like ba\u0300i viê\u0301t";
		this.B18C643D.UseVisualStyleBackColor = true;
		this.nudTimeTo.Location = new System.Drawing.Point(568, 50);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(51, 23);
		this.nudTimeTo.TabIndex = 4;
		this.DA2BC9BF.Location = new System.Drawing.Point(227, 78);
		this.DA2BC9BF.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.DA2BC9BF.Name = "nudDelayTo";
		this.DA2BC9BF.Size = new System.Drawing.Size(56, 23);
		this.DA2BC9BF.TabIndex = 4;
		this.D496F4B0.Location = new System.Drawing.Point(490, 50);
		this.D496F4B0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D496F4B0.Name = "nudTimeFrom";
		this.D496F4B0.Size = new System.Drawing.Size(51, 23);
		this.D496F4B0.TabIndex = 3;
		this.nudDelayFrom.Location = new System.Drawing.Point(134, 78);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
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
		this.label7.Location = new System.Drawing.Point(194, 80);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(621, 52);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(30, 16);
		this.label4.TabIndex = 36;
		this.label4.Text = "giây";
		this.B2AB4BAB.AutoSize = true;
		this.B2AB4BAB.Location = new System.Drawing.Point(285, 80);
		this.B2AB4BAB.Name = "label6";
		this.B2AB4BAB.Size = new System.Drawing.Size(30, 16);
		this.B2AB4BAB.TabIndex = 36;
		this.B2AB4BAB.Text = "giây";
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
		this.C08DAD8A.AutoSize = true;
		this.C08DAD8A.Location = new System.Drawing.Point(27, 52);
		this.C08DAD8A.Name = "label1";
		this.C08DAD8A.Size = new System.Drawing.Size(98, 16);
		this.C08DAD8A.TabIndex = 31;
		this.C08DAD8A.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.F2BB9FA6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.F2BB9FA6.BackColor = System.Drawing.Color.Maroon;
		this.F2BB9FA6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F2BB9FA6.FlatAppearance.BorderSize = 0;
		this.F2BB9FA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F2BB9FA6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F2BB9FA6.ForeColor = System.Drawing.Color.White;
		this.F2BB9FA6.Location = new System.Drawing.Point(349, 425);
		this.F2BB9FA6.Name = "btnCancel";
		this.F2BB9FA6.Size = new System.Drawing.Size(92, 29);
		this.F2BB9FA6.TabIndex = 10;
		this.F2BB9FA6.Text = "Đóng";
		this.F2BB9FA6.UseVisualStyleBackColor = false;
		this.F2BB9FA6.Click += new System.EventHandler(F2BB9FA6_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(242, 425);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.B60738AC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B60738AC.BackColor = System.Drawing.Color.White;
		this.B60738AC.BorderRadius = 0;
		this.B60738AC.BottomSahddow = true;
		this.B60738AC.color = System.Drawing.Color.DarkViolet;
		this.B60738AC.Controls.Add(this.pnlHeader);
		this.B60738AC.LeftSahddow = false;
		this.B60738AC.Location = new System.Drawing.Point(1, 0);
		this.B60738AC.Name = "bunifuCards1";
		this.B60738AC.RightSahddow = true;
		this.B60738AC.ShadowDepth = 20;
		this.B60738AC.Size = new System.Drawing.Size(684, 37);
		this.B60738AC.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(687, 467);
		base.Controls.Add(this.F703A2B7);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBaiVietTheoID";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacBaiVietTheoID_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.F703A2B7.ResumeLayout(false);
		this.F703A2B7.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CDBDDE11).EndInit();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.BC20F616.ResumeLayout(false);
		this.BC20F616.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DA2BC9BF).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D496F4B0).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.B60738AC.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
