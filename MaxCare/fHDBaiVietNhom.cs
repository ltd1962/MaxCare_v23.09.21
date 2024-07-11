using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietNhom : Form
{
	private JObject jobject_0;

	private string string_0;

	private string B8913CA0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label FAA6E20E;

	private Label label6;

	private Label BC1CC094;

	private Label label5;

	private Label CABE7200;

	private Button btnCancel;

	private Button C2AAE42B;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox D7A448AD;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox C73FBA16;

	private CheckBox FE9BD638;

	private CheckBox ckbShareWall;

	private Label label49;

	private NumericUpDown E285A330;

	private Label BC854323;

	private Label E4BB9827;

	private NumericUpDown nudSoLuongNhomTo;

	private Label label66;

	private Panel C5BFC21B;

	private RichTextBox txtComment;

	private Button btnDown;

	private Button btnUp;

	private RadioButton B2A98B09;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private Label label8;

	private Label lblStatus;

	private Panel FD0EB005;

	private TextBox EF8B8DBC;

	private CheckBox A6B5250F;

	private Button EC9E1482;

	private Button button4;

	private Button button5;

	private Label label2;

	private LinkLabel linkLabel1;

	private CheckBox ckbNangCao;

	private CheckBox AF0C9CB2;

	public fHDBaiVietNhom(string string_2, int int_1 = 0, string BBB39418 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = BBB39418;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietNhom");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			B8913CA0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(BBB39418);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			C2AAE42B.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(CABE7200);
		Language.smethod_0(label49);
		Language.smethod_0(label66);
		Language.smethod_0(BC854323);
		Language.smethod_0(E4BB9827);
		Language.smethod_0(FAA6E20E);
		Language.smethod_0(BC1CC094);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(label6);
		Language.smethod_0(ckbShareWall);
		Language.smethod_0(A6B5250F);
		Language.smethod_0(C73FBA16);
		Language.smethod_0(lblStatus);
		Language.smethod_0(EC9E1482);
		Language.smethod_0(label8);
		Language.smethod_0(C2AAE42B);
		Language.smethod_0(btnCancel);
	}

	private void C22512B6(object sender, EventArgs e)
	{
		try
		{
			E285A330.Value = Convert.ToInt32(jobject_0["nudSoLuongNhomFrom"]);
			nudSoLuongNhomTo.Value = Convert.ToInt32(jobject_0["nudSoLuongNhomTo"]);
			nudSoLuongBaiVietFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietFrom"]);
			nudSoLuongBaiVietTo.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			FE9BD638.Checked = Convert.ToBoolean(jobject_0["ckbInteract"]);
			ckbShareWall.Checked = Convert.ToBoolean(jobject_0["ckbShareWall"]);
			C73FBA16.Checked = Convert.ToBoolean(jobject_0["ckbComment"]);
			txtComment.Text = jobject_0["txtComment"].ToString();
			if (Convert.ToInt32(jobject_0["typeNganCach"]) == 1)
			{
				B2A98B09.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			AF0C9CB2.Checked = Convert.ToBoolean(jobject_0["ckbKhongCommentTrungBaiCu"]);
			A6B5250F.Checked = Convert.ToBoolean(jobject_0["ckbSendAnh"]);
			EF8B8DBC.Text = jobject_0["txtAnh"].ToString();
			ckbNangCao.Checked = Convert.ToBoolean(jobject_0["ckbNangCao"]);
		}
		catch
		{
		}
		method_1();
	}

	private void E1B21820(object sender, EventArgs e)
	{
		Close();
	}

	private void CA3C3A34(object sender, EventArgs e)
	{
		if (int_0 == 0)
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
			if (C73FBA16.Checked)
			{
				List<string> a2AB53A = txtComment.Lines.ToList();
				a2AB53A = Common.RemoveEmptyItems(a2AB53A);
				if (a2AB53A.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			if (A6B5250F.Checked && EF8B8DBC.Text.Trim().Length == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng chọn folder ảnh!", 3);
				return;
			}
			JSON_Settings gClass = new JSON_Settings();
			gClass.GetJson("nudSoLuongNhomFrom", E285A330.Value);
			gClass.GetJson("nudSoLuongNhomTo", nudSoLuongNhomTo.Value);
			gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass.GetJson("ckbInteract", FE9BD638.Checked);
			gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass.GetJson("ckbComment", C73FBA16.Checked);
			gClass.GetJson("txtComment", txtComment.Text.Trim());
			int num = 0;
			if (B2A98B09.Checked)
			{
				num = 1;
			}
			gClass.GetJson("typeNganCach", num);
			gClass.GetJson("ckbKhongCommentTrungBaiCu", AF0C9CB2.Checked);
			gClass.GetJson("ckbSendAnh", A6B5250F.Checked);
			gClass.GetJson("txtAnh", EF8B8DBC.Text.Trim());
			gClass.GetJson("ckbNangCao", ckbNangCao.Checked);
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(string_0, text, B8913CA0, string_))
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
			if (C73FBA16.Checked)
			{
				List<string> a2AB53A2 = txtComment.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			if (A6B5250F.Checked && EF8B8DBC.Text.Trim().Length == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng chọn folder ảnh!", 3);
				return;
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudSoLuongNhomFrom", E285A330.Value);
			gClass2.GetJson("nudSoLuongNhomTo", nudSoLuongNhomTo.Value);
			gClass2.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass2.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass2.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass2.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass2.GetJson("ckbInteract", FE9BD638.Checked);
			gClass2.GetJson("ckbShareWall", ckbShareWall.Checked);
			gClass2.GetJson("ckbComment", C73FBA16.Checked);
			gClass2.GetJson("txtComment", txtComment.Text.Trim());
			int num2 = 0;
			if (B2A98B09.Checked)
			{
				num2 = 1;
			}
			gClass2.GetJson("typeNganCach", num2);
			gClass2.GetJson("ckbKhongCommentTrungBaiCu", AF0C9CB2.Checked);
			gClass2.GetJson("ckbSendAnh", A6B5250F.Checked);
			gClass2.GetJson("txtAnh", EF8B8DBC.Text.Trim());
			gClass2.GetJson("ckbNangCao", ckbNangCao.Checked);
			string text3 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(string_1, text2, text3))
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

	private void E4B2811C(object sender, EventArgs e)
	{
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		AFBC9F16();
	}

	private void AFBC9F16()
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

	private void method_1()
	{
		method_2(null, null);
		C73FBA16_CheckedChanged(null, null);
		ABBD7E24(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void C73FBA16_CheckedChanged(object sender, EventArgs e)
	{
		C5BFC21B.Enabled = C73FBA16.Checked;
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		AFBC9F16();
	}

	private void B2A98B09_CheckedChanged(object sender, EventArgs e)
	{
		AFBC9F16();
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		C5BFC21B.Height = 207;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		C5BFC21B.Height = 163;
	}

	private void D7A448AD_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void ABBD7E24(object sender, EventArgs e)
	{
		FD0EB005.Enabled = A6B5250F.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
		EF8B8DBC.Text = Common.SelectFolder();
	}

	private void EC9E1482_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của người đăng bài!");
	}

	private void AD1E7097(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtComment.Focus();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void method_4(object sender, EventArgs e)
	{
		Process.Start("configs\\nhom.txt");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietNhom));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.D7A448AD = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.AF0C9CB2 = new System.Windows.Forms.CheckBox();
		this.ckbNangCao = new System.Windows.Forms.CheckBox();
		this.FD0EB005 = new System.Windows.Forms.Panel();
		this.EF8B8DBC = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.A6B5250F = new System.Windows.Forms.CheckBox();
		this.C5BFC21B = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.button4 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.EC9E1482 = new System.Windows.Forms.Button();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.btnDown = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.B2A98B09 = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.E285A330 = new System.Windows.Forms.NumericUpDown();
		this.BC854323 = new System.Windows.Forms.Label();
		this.E4BB9827 = new System.Windows.Forms.Label();
		this.nudSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.C73FBA16 = new System.Windows.Forms.CheckBox();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.FE9BD638 = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.FAA6E20E = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.BC1CC094 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.CABE7200 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.C2AAE42B = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D7A448AD).BeginInit();
		this.panel1.SuspendLayout();
		this.FD0EB005.SuspendLayout();
		this.C5BFC21B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E285A330).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongNhomTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(665, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Nhóm";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.D7A448AD);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(665, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(634, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(E1B21820);
		this.D7A448AD.Cursor = System.Windows.Forms.Cursors.Default;
		this.D7A448AD.Image = Resources.Bitmap_4;
		this.D7A448AD.Location = new System.Drawing.Point(3, 2);
		this.D7A448AD.Name = "pictureBox1";
		this.D7A448AD.Size = new System.Drawing.Size(34, 27);
		this.D7A448AD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.D7A448AD.TabIndex = 76;
		this.D7A448AD.TabStop = false;
		this.D7A448AD.Click += new System.EventHandler(D7A448AD_Click);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.AF0C9CB2);
		this.panel1.Controls.Add(this.ckbNangCao);
		this.panel1.Controls.Add(this.FD0EB005);
		this.panel1.Controls.Add(this.A6B5250F);
		this.panel1.Controls.Add(this.C5BFC21B);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.E285A330);
		this.panel1.Controls.Add(this.BC854323);
		this.panel1.Controls.Add(this.E4BB9827);
		this.panel1.Controls.Add(this.nudSoLuongNhomTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.C73FBA16);
		this.panel1.Controls.Add(this.ckbShareWall);
		this.panel1.Controls.Add(this.FE9BD638);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.FAA6E20E);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.BC1CC094);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.CABE7200);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.C2AAE42B);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(668, 325);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.AF0C9CB2.AutoSize = true;
		this.AF0C9CB2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AF0C9CB2.Location = new System.Drawing.Point(30, 193);
		this.AF0C9CB2.Name = "ckbKhongCommentTrungBaiCu";
		this.AF0C9CB2.Size = new System.Drawing.Size(152, 20);
		this.AF0C9CB2.TabIndex = 169;
		this.AF0C9CB2.Text = "Không comment trùng";
		this.AF0C9CB2.UseVisualStyleBackColor = true;
		this.ckbNangCao.AutoSize = true;
		this.ckbNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNangCao.Location = new System.Drawing.Point(206, 193);
		this.ckbNangCao.Name = "ckbNangCao";
		this.ckbNangCao.Size = new System.Drawing.Size(129, 20);
		this.ckbNangCao.TabIndex = 168;
		this.ckbNangCao.Text = "Random nâng cao";
		this.ckbNangCao.UseVisualStyleBackColor = true;
		this.FD0EB005.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FD0EB005.Controls.Add(this.EF8B8DBC);
		this.FD0EB005.Controls.Add(this.label2);
		this.FD0EB005.Enabled = false;
		this.FD0EB005.Location = new System.Drawing.Point(48, 237);
		this.FD0EB005.Name = "plAnh";
		this.FD0EB005.Size = new System.Drawing.Size(281, 31);
		this.FD0EB005.TabIndex = 164;
		this.EF8B8DBC.Location = new System.Drawing.Point(138, 3);
		this.EF8B8DBC.Name = "txtAnh";
		this.EF8B8DBC.Size = new System.Drawing.Size(137, 23);
		this.EF8B8DBC.TabIndex = 155;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label2.Location = new System.Drawing.Point(3, 6);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(137, 16);
		this.label2.TabIndex = 101;
		this.label2.Text = "Đường dẫn folder ảnh:";
		this.A6B5250F.AutoSize = true;
		this.A6B5250F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A6B5250F.Location = new System.Drawing.Point(30, 215);
		this.A6B5250F.Name = "ckbSendAnh";
		this.A6B5250F.Size = new System.Drawing.Size(103, 20);
		this.A6B5250F.TabIndex = 163;
		this.A6B5250F.Text = "Bình luận ảnh";
		this.A6B5250F.UseVisualStyleBackColor = true;
		this.A6B5250F.CheckedChanged += new System.EventHandler(ABBD7E24);
		this.C5BFC21B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C5BFC21B.Controls.Add(this.linkLabel1);
		this.C5BFC21B.Controls.Add(this.button4);
		this.C5BFC21B.Controls.Add(this.button5);
		this.C5BFC21B.Controls.Add(this.EC9E1482);
		this.C5BFC21B.Controls.Add(this.txtComment);
		this.C5BFC21B.Controls.Add(this.btnDown);
		this.C5BFC21B.Controls.Add(this.btnUp);
		this.C5BFC21B.Controls.Add(this.B2A98B09);
		this.C5BFC21B.Controls.Add(this.rbNganCachMoiDong);
		this.C5BFC21B.Controls.Add(this.label9);
		this.C5BFC21B.Controls.Add(this.label8);
		this.C5BFC21B.Controls.Add(this.lblStatus);
		this.C5BFC21B.Location = new System.Drawing.Point(369, 84);
		this.C5BFC21B.Name = "plComment";
		this.C5BFC21B.Size = new System.Drawing.Size(281, 164);
		this.C5BFC21B.TabIndex = 106;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(167, 141);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 182;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(226, 183);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 166;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.button5.Cursor = System.Windows.Forms.Cursors.Help;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.Location = new System.Drawing.Point(226, 160);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(21, 23);
		this.button5.TabIndex = 167;
		this.button5.Text = "?";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(AD1E7097);
		this.EC9E1482.Cursor = System.Windows.Forms.Cursors.Help;
		this.EC9E1482.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EC9E1482.Location = new System.Drawing.Point(250, 138);
		this.EC9E1482.Name = "button3";
		this.EC9E1482.Size = new System.Drawing.Size(23, 23);
		this.EC9E1482.TabIndex = 165;
		this.EC9E1482.Text = "?";
		this.EC9E1482.UseVisualStyleBackColor = true;
		this.EC9E1482.Click += new System.EventHandler(EC9E1482_Click);
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(266, 111);
		this.txtComment.TabIndex = 106;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(224, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 7;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(255, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 7;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.B2A98B09.AutoSize = true;
		this.B2A98B09.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B2A98B09.Location = new System.Drawing.Point(69, 182);
		this.B2A98B09.Name = "rbNganCachKyTu";
		this.B2A98B09.Size = new System.Drawing.Size(159, 20);
		this.B2A98B09.TabIndex = 6;
		this.B2A98B09.Text = "Nội dung có nhiều dòng";
		this.B2A98B09.UseVisualStyleBackColor = true;
		this.B2A98B09.CheckedChanged += new System.EventHandler(B2A98B09_CheckedChanged);
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
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(4, 161);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 4;
		this.label9.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(4, 141);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(143, 16);
		this.label8.TabIndex = 0;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(27, 81);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(99, 16);
		this.label49.TabIndex = 92;
		this.label49.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		this.E285A330.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E285A330.Location = new System.Drawing.Point(135, 79);
		this.E285A330.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.E285A330.Name = "nudSoLuongNhomFrom";
		this.E285A330.Size = new System.Drawing.Size(56, 23);
		this.E285A330.TabIndex = 1;
		this.E285A330.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.BC854323.AutoSize = true;
		this.BC854323.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.BC854323.Location = new System.Drawing.Point(293, 81);
		this.BC854323.Name = "label68";
		this.BC854323.Size = new System.Drawing.Size(39, 16);
		this.BC854323.TabIndex = 99;
		this.BC854323.Text = "nhóm";
		this.E4BB9827.AutoSize = true;
		this.E4BB9827.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E4BB9827.Location = new System.Drawing.Point(27, 112);
		this.E4BB9827.Name = "label19";
		this.E4BB9827.Size = new System.Drawing.Size(85, 16);
		this.E4BB9827.TabIndex = 101;
		this.E4BB9827.Text = "Sô\u0301 ba\u0300i/nhóm:";
		this.nudSoLuongNhomTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongNhomTo.Location = new System.Drawing.Point(232, 79);
		this.nudSoLuongNhomTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongNhomTo.Name = "nudSoLuongNhomTo";
		this.nudSoLuongNhomTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongNhomTo.TabIndex = 2;
		this.nudSoLuongNhomTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(197, 81);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 105;
		this.label66.Text = "đê\u0301n";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C73FBA16.AutoSize = true;
		this.C73FBA16.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C73FBA16.Location = new System.Drawing.Point(369, 62);
		this.C73FBA16.Name = "ckbComment";
		this.C73FBA16.Size = new System.Drawing.Size(127, 20);
		this.C73FBA16.TabIndex = 9;
		this.C73FBA16.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.C73FBA16.UseVisualStyleBackColor = true;
		this.C73FBA16.CheckedChanged += new System.EventHandler(C73FBA16_CheckedChanged);
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(206, 169);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(122, 20);
		this.ckbShareWall.TabIndex = 8;
		this.ckbShareWall.Text = "Chia sẻ về tường";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.FE9BD638.AutoSize = true;
		this.FE9BD638.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FE9BD638.Location = new System.Drawing.Point(30, 171);
		this.FE9BD638.Name = "ckbInteract";
		this.FE9BD638.Size = new System.Drawing.Size(48, 20);
		this.FE9BD638.TabIndex = 7;
		this.FE9BD638.Text = "Like";
		this.FE9BD638.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(232, 140);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 6;
		this.nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 110);
		this.nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		this.nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietTo.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(135, 140);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 5;
		this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 110);
		this.nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietFrom.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(197, 142);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FAA6E20E.Location = new System.Drawing.Point(197, 112);
		this.FAA6E20E.Name = "label3";
		this.FAA6E20E.Size = new System.Drawing.Size(29, 16);
		this.FAA6E20E.TabIndex = 37;
		this.FAA6E20E.Text = "đê\u0301n";
		this.FAA6E20E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(293, 142);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.BC1CC094.AutoSize = true;
		this.BC1CC094.Location = new System.Drawing.Point(293, 112);
		this.BC1CC094.Name = "label4";
		this.BC1CC094.Size = new System.Drawing.Size(24, 16);
		this.BC1CC094.TabIndex = 35;
		this.BC1CC094.Text = "ba\u0300i";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 142);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.CABE7200.AutoSize = true;
		this.CABE7200.Location = new System.Drawing.Point(27, 52);
		this.CABE7200.Name = "label1";
		this.CABE7200.Size = new System.Drawing.Size(98, 16);
		this.CABE7200.TabIndex = 31;
		this.CABE7200.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(341, 286);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 12;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.C2AAE42B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.C2AAE42B.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.C2AAE42B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C2AAE42B.FlatAppearance.BorderSize = 0;
		this.C2AAE42B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C2AAE42B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C2AAE42B.ForeColor = System.Drawing.Color.White;
		this.C2AAE42B.Location = new System.Drawing.Point(234, 286);
		this.C2AAE42B.Name = "btnAdd";
		this.C2AAE42B.Size = new System.Drawing.Size(92, 29);
		this.C2AAE42B.TabIndex = 11;
		this.C2AAE42B.Text = "Thêm";
		this.C2AAE42B.UseVisualStyleBackColor = false;
		this.C2AAE42B.Click += new System.EventHandler(CA3C3A34);
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
		this.bunifuCards1.Size = new System.Drawing.Size(665, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(668, 325);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C22512B6);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.D7A448AD).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.FD0EB005.ResumeLayout(false);
		this.FD0EB005.PerformLayout();
		this.C5BFC21B.ResumeLayout(false);
		this.C5BFC21B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.E285A330).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongNhomTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
