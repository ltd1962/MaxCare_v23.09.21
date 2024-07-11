using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBaiVietBanBe : Form
{
	private JSON_Settings gclass8_0;

	private string A80F7E1D;

	private string string_0;

	private string F78FB68B;

	private int int_0;

	public static bool BD347D32;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel BBA40EB5;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F5397403;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label C38699B8;

	private Label A318308A;

	private Label label4;

	private Label label5;

	private Label label1;

	private Button FDB9700C;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button A3912186;

	private PictureBox E43BB8B7;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox FC208626;

	private CheckBox C63F4A8E;

	private CheckBox EBA4B88C;

	private Label FC908B01;

	private NumericUpDown nudSoLuongBanBeFrom;

	private Label A121418C;

	private Label D18129B1;

	private NumericUpDown E6BE6A80;

	private Label label66;

	private Panel BA26EF37;

	private Panel C994BB1C;

	private LinkLabel linkLabel1;

	private Button button3;

	private Button button4;

	private Button DEA17E10;

	private RichTextBox txtComment;

	private Button btnDown;

	private Button ADB16B1E;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private Label label8;

	private Label lblStatus;

	private Panel E38E5281;

	private TextBox CDA4A193;

	private Label label16;

	private CheckBox ckbSendAnh;

	private CheckBox ckbCommentText;

	private CheckBox F5ACA018;

	public fHDBaiVietBanBe(string string_1, int EE3B5832 = 0, string string_2 = "")
	{
		InitializeComponent();
		BD347D32 = false;
		A80F7E1D = string_1;
		F78FB68B = string_2;
		int_0 = EE3B5832;
		string text = "";
		switch (EE3B5832)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietBanBe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
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
		Language.smethod_0(label1);
		Language.smethod_0(FC908B01);
		Language.smethod_0(label66);
		Language.smethod_0(A121418C);
		Language.smethod_0(D18129B1);
		Language.smethod_0(C38699B8);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(A318308A);
		Language.smethod_0(EBA4B88C);
		Language.smethod_0(FC208626);
		Language.smethod_0(lblStatus);
		Language.smethod_0(DEA17E10);
		Language.smethod_0(label8);
		Language.smethod_0(btnAdd);
		Language.smethod_0(FDB9700C);
	}

	private void DDA13ABD(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongBanBeFrom.Value = gclass8_0.GetValueInt("nudSoLuongBanBeFrom", 3);
			E6BE6A80.Value = gclass8_0.GetValueInt("nudSoLuongBanBeTo", 5);
			nudSoLuongBaiVietFrom.Value = gclass8_0.GetValueInt("nudSoLuongBaiVietFrom", 3);
			F5397403.Value = gclass8_0.GetValueInt("nudSoLuongBaiVietTo", 3);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			C63F4A8E.Checked = gclass8_0.GetValueBool("ckbInteract");
			EBA4B88C.Checked = gclass8_0.GetValueBool("ckbShareWall");
			FC208626.Checked = gclass8_0.GetValueBool("ckbComment");
			ckbCommentText.Checked = gclass8_0.GetValueBool("ckbCommentText");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			F5ACA018.Checked = gclass8_0.GetValueBool("ckbRandomNangCao");
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbSendAnh.Checked = gclass8_0.GetValueBool("ckbSendAnh");
			CDA4A193.Text = gclass8_0.GetValue("txtAnh");
		}
		catch
		{
		}
		EC85C92F();
	}

	private void D32CDF37(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
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
			if (FC208626.Checked)
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
			gClass.GetJson("nudSoLuongBanBeFrom", nudSoLuongBanBeFrom.Value);
			gClass.GetJson("nudSoLuongBanBeTo", E6BE6A80.Value);
			gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass.GetJson("nudSoLuongBaiVietTo", F5397403.Value);
			gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass.GetJson("ckbInteract", C63F4A8E.Checked);
			gClass.GetJson("ckbShareWall", EBA4B88C.Checked);
			gClass.GetJson("ckbComment", FC208626.Checked);
			gClass.GetJson("ckbCommentText", ckbCommentText.Checked);
			gClass.GetJson("txtComment", txtComment.Text.Trim());
			gClass.GetJson("ckbRandomNangCao", F5ACA018.Checked);
			int num = 0;
			if (rbNganCachKyTu.Checked)
			{
				num = 1;
			}
			gClass.GetJson("typeNganCach", num);
			gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass.GetJson("txtAnh", CDA4A193.Text.Trim());
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(A80F7E1D, text, string_0, string_))
			{
				BD347D32 = true;
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
			if (FC208626.Checked)
			{
				List<string> a2AB53A2 = txtComment.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudSoLuongBanBeFrom", nudSoLuongBanBeFrom.Value);
			gClass2.GetJson("nudSoLuongBanBeTo", E6BE6A80.Value);
			gClass2.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass2.GetJson("nudSoLuongBaiVietTo", F5397403.Value);
			gClass2.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass2.GetJson("nudDelayTo", nudDelayTo.Value);
			gClass2.GetJson("ckbInteract", C63F4A8E.Checked);
			gClass2.GetJson("ckbShareWall", EBA4B88C.Checked);
			gClass2.GetJson("ckbComment", FC208626.Checked);
			gClass2.GetJson("ckbCommentText", ckbCommentText.Checked);
			gClass2.GetJson("txtComment", txtComment.Text.Trim());
			gClass2.GetJson("ckbRandomNangCao", F5ACA018.Checked);
			int num2 = 0;
			if (rbNganCachKyTu.Checked)
			{
				num2 = 1;
			}
			gClass2.GetJson("typeNganCach", num2);
			gClass2.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.GetJson("txtAnh", CDA4A193.Text.Trim());
			string string_2 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(F78FB68B, text2, string_2))
			{
				BD347D32 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void FDB9700C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BBA40EB5_Paint(object sender, PaintEventArgs e)
	{
		if (BBA40EB5.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BBA40EB5.ClientSize.Width - num, BBA40EB5.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void FF9E5695(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_2()
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

	private void EC85C92F()
	{
		FCAA012E(null, null);
		FC208626_CheckedChanged(null, null);
		ckbCommentText_CheckedChanged(null, null);
		ckbSendAnh_CheckedChanged(null, null);
	}

	private void FCAA012E(object sender, EventArgs e)
	{
	}

	private void FC208626_CheckedChanged(object sender, EventArgs e)
	{
		BA26EF37.Enabled = FC208626.Checked;
	}

	private void F83693BB(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ADB16B1E.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		C994BB1C.Enabled = ckbCommentText.Checked;
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		E38E5281.Enabled = ckbSendAnh.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		C994BB1C.Height = 217;
	}

	private void ADB16B1E_Click(object sender, EventArgs e)
	{
		C994BB1C.Height = 164;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietBanBe));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.A3912186 = new System.Windows.Forms.Button();
		this.E43BB8B7 = new System.Windows.Forms.PictureBox();
		this.BBA40EB5 = new System.Windows.Forms.Panel();
		this.F5ACA018 = new System.Windows.Forms.CheckBox();
		this.BA26EF37 = new System.Windows.Forms.Panel();
		this.C994BB1C = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.button3 = new System.Windows.Forms.Button();
		this.button4 = new System.Windows.Forms.Button();
		this.DEA17E10 = new System.Windows.Forms.Button();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.btnDown = new System.Windows.Forms.Button();
		this.ADB16B1E = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.lblStatus = new System.Windows.Forms.Label();
		this.E38E5281 = new System.Windows.Forms.Panel();
		this.CDA4A193 = new System.Windows.Forms.TextBox();
		this.label16 = new System.Windows.Forms.Label();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.FC908B01 = new System.Windows.Forms.Label();
		this.nudSoLuongBanBeFrom = new System.Windows.Forms.NumericUpDown();
		this.A121418C = new System.Windows.Forms.Label();
		this.D18129B1 = new System.Windows.Forms.Label();
		this.E6BE6A80 = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.FC208626 = new System.Windows.Forms.CheckBox();
		this.EBA4B88C = new System.Windows.Forms.CheckBox();
		this.C63F4A8E = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.F5397403 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.C38699B8 = new System.Windows.Forms.Label();
		this.A318308A = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.FDB9700C = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.E43BB8B7).BeginInit();
		this.BBA40EB5.SuspendLayout();
		this.BA26EF37.SuspendLayout();
		this.C994BB1C.SuspendLayout();
		this.E38E5281.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E6BE6A80).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F5397403).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Bạn bè";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.pnlHeader;
		this.bunifuDragControl_1.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.A3912186);
		this.pnlHeader.Controls.Add(this.E43BB8B7);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(359, 31);
		this.pnlHeader.TabIndex = 9;
		this.A3912186.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.A3912186.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A3912186.FlatAppearance.BorderSize = 0;
		this.A3912186.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A3912186.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A3912186.ForeColor = System.Drawing.Color.White;
		this.A3912186.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.A3912186.Location = new System.Drawing.Point(328, 1);
		this.A3912186.Name = "button1";
		this.A3912186.Size = new System.Drawing.Size(30, 30);
		this.A3912186.TabIndex = 77;
		this.A3912186.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A3912186.UseVisualStyleBackColor = true;
		this.A3912186.Click += new System.EventHandler(D32CDF37);
		this.E43BB8B7.Cursor = System.Windows.Forms.Cursors.Default;
		this.E43BB8B7.Image = Resources.Bitmap_4;
		this.E43BB8B7.Location = new System.Drawing.Point(3, 2);
		this.E43BB8B7.Name = "pictureBox1";
		this.E43BB8B7.Size = new System.Drawing.Size(34, 27);
		this.E43BB8B7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.E43BB8B7.TabIndex = 76;
		this.E43BB8B7.TabStop = false;
		this.E43BB8B7.Click += new System.EventHandler(F83693BB);
		this.BBA40EB5.BackColor = System.Drawing.Color.White;
		this.BBA40EB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BBA40EB5.Controls.Add(this.F5ACA018);
		this.BBA40EB5.Controls.Add(this.BA26EF37);
		this.BBA40EB5.Controls.Add(this.FC908B01);
		this.BBA40EB5.Controls.Add(this.nudSoLuongBanBeFrom);
		this.BBA40EB5.Controls.Add(this.A121418C);
		this.BBA40EB5.Controls.Add(this.D18129B1);
		this.BBA40EB5.Controls.Add(this.E6BE6A80);
		this.BBA40EB5.Controls.Add(this.label66);
		this.BBA40EB5.Controls.Add(this.FC208626);
		this.BBA40EB5.Controls.Add(this.EBA4B88C);
		this.BBA40EB5.Controls.Add(this.C63F4A8E);
		this.BBA40EB5.Controls.Add(this.nudDelayTo);
		this.BBA40EB5.Controls.Add(this.F5397403);
		this.BBA40EB5.Controls.Add(this.nudDelayFrom);
		this.BBA40EB5.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.BBA40EB5.Controls.Add(this.txtTenHanhDong);
		this.BBA40EB5.Controls.Add(this.label7);
		this.BBA40EB5.Controls.Add(this.C38699B8);
		this.BBA40EB5.Controls.Add(this.A318308A);
		this.BBA40EB5.Controls.Add(this.label4);
		this.BBA40EB5.Controls.Add(this.label5);
		this.BBA40EB5.Controls.Add(this.label1);
		this.BBA40EB5.Controls.Add(this.FDB9700C);
		this.BBA40EB5.Controls.Add(this.btnAdd);
		this.BBA40EB5.Controls.Add(this.bunifuCards1);
		this.BBA40EB5.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.BBA40EB5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.BBA40EB5.Location = new System.Drawing.Point(0, 0);
		this.BBA40EB5.Name = "panel1";
		this.BBA40EB5.Size = new System.Drawing.Size(362, 559);
		this.BBA40EB5.TabIndex = 0;
		this.BBA40EB5.Paint += new System.Windows.Forms.PaintEventHandler(BBA40EB5_Paint);
		this.F5ACA018.AutoSize = true;
		this.F5ACA018.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F5ACA018.Location = new System.Drawing.Point(207, 171);
		this.F5ACA018.Name = "ckbRandomNangCao";
		this.F5ACA018.Size = new System.Drawing.Size(129, 20);
		this.F5ACA018.TabIndex = 107;
		this.F5ACA018.Text = "Random nâng cao";
		this.F5ACA018.UseVisualStyleBackColor = true;
		this.BA26EF37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BA26EF37.Controls.Add(this.C994BB1C);
		this.BA26EF37.Controls.Add(this.E38E5281);
		this.BA26EF37.Controls.Add(this.ckbSendAnh);
		this.BA26EF37.Controls.Add(this.ckbCommentText);
		this.BA26EF37.Location = new System.Drawing.Point(31, 246);
		this.BA26EF37.Name = "plComment";
		this.BA26EF37.Size = new System.Drawing.Size(306, 262);
		this.BA26EF37.TabIndex = 106;
		this.C994BB1C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C994BB1C.Controls.Add(this.linkLabel1);
		this.C994BB1C.Controls.Add(this.button3);
		this.C994BB1C.Controls.Add(this.button4);
		this.C994BB1C.Controls.Add(this.DEA17E10);
		this.C994BB1C.Controls.Add(this.txtComment);
		this.C994BB1C.Controls.Add(this.btnDown);
		this.C994BB1C.Controls.Add(this.ADB16B1E);
		this.C994BB1C.Controls.Add(this.rbNganCachKyTu);
		this.C994BB1C.Controls.Add(this.rbNganCachMoiDong);
		this.C994BB1C.Controls.Add(this.label9);
		this.C994BB1C.Controls.Add(this.label8);
		this.C994BB1C.Controls.Add(this.lblStatus);
		this.C994BB1C.Location = new System.Drawing.Point(24, 29);
		this.C994BB1C.Name = "plCommentText";
		this.C994BB1C.Size = new System.Drawing.Size(278, 164);
		this.C994BB1C.TabIndex = 8;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(163, 142);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 176;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(227, 185);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 127;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(227, 162);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 128;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.DEA17E10.Cursor = System.Windows.Forms.Cursors.Help;
		this.DEA17E10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DEA17E10.Location = new System.Drawing.Point(247, 139);
		this.DEA17E10.Name = "button2";
		this.DEA17E10.Size = new System.Drawing.Size(23, 23);
		this.DEA17E10.TabIndex = 126;
		this.DEA17E10.Text = "?";
		this.DEA17E10.UseVisualStyleBackColor = true;
		this.txtComment.Location = new System.Drawing.Point(7, 27);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(263, 111);
		this.txtComment.TabIndex = 114;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(FF9E5695);
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(221, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 112;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.ADB16B1E.BackgroundImage = Resources.E536C319;
		this.ADB16B1E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ADB16B1E.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.ADB16B1E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ADB16B1E.Location = new System.Drawing.Point(252, -1);
		this.ADB16B1E.Name = "btnUp";
		this.ADB16B1E.Size = new System.Drawing.Size(25, 25);
		this.ADB16B1E.TabIndex = 113;
		this.ADB16B1E.Click += new System.EventHandler(ADB16B1E_Click);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(68, 182);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 111;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
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
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(4, 4);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.E38E5281.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.E38E5281.Controls.Add(this.CDA4A193);
		this.E38E5281.Controls.Add(this.label16);
		this.E38E5281.Enabled = false;
		this.E38E5281.Location = new System.Drawing.Point(21, 223);
		this.E38E5281.Name = "plAnh";
		this.E38E5281.Size = new System.Drawing.Size(281, 31);
		this.E38E5281.TabIndex = 169;
		this.CDA4A193.Location = new System.Drawing.Point(136, 3);
		this.CDA4A193.Name = "txtAnh";
		this.CDA4A193.Size = new System.Drawing.Size(140, 23);
		this.CDA4A193.TabIndex = 155;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 6);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(137, 16);
		this.label16.TabIndex = 39;
		this.label16.Text = "Đường dẫn folder ảnh:";
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(4, 199);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		this.ckbSendAnh.TabIndex = 10;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(4, 4);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(127, 20);
		this.ckbCommentText.TabIndex = 9;
		this.ckbCommentText.Text = "Bình luận văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(ckbCommentText_CheckedChanged);
		this.FC908B01.AutoSize = true;
		this.FC908B01.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.FC908B01.Location = new System.Drawing.Point(27, 81);
		this.FC908B01.Name = "label49";
		this.FC908B01.Size = new System.Drawing.Size(106, 16);
		this.FC908B01.TabIndex = 92;
		this.FC908B01.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		this.nudSoLuongBanBeFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongBanBeFrom.Location = new System.Drawing.Point(135, 79);
		this.nudSoLuongBanBeFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBanBeFrom.Name = "nudSoLuongBanBeFrom";
		this.nudSoLuongBanBeFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBanBeFrom.TabIndex = 1;
		this.nudSoLuongBanBeFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.A121418C.AutoSize = true;
		this.A121418C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.A121418C.Location = new System.Drawing.Point(290, 81);
		this.A121418C.Name = "label68";
		this.A121418C.Size = new System.Drawing.Size(28, 16);
		this.A121418C.TabIndex = 99;
		this.A121418C.Text = "ba\u0323n";
		this.D18129B1.AutoSize = true;
		this.D18129B1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.D18129B1.Location = new System.Drawing.Point(27, 112);
		this.D18129B1.Name = "label19";
		this.D18129B1.Size = new System.Drawing.Size(98, 16);
		this.D18129B1.TabIndex = 101;
		this.D18129B1.Text = "Sô\u0301 ba\u0300i viê\u0301t/ba\u0323n:";
		this.E6BE6A80.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E6BE6A80.Location = new System.Drawing.Point(232, 79);
		this.E6BE6A80.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.E6BE6A80.Name = "nudSoLuongBanBeTo";
		this.E6BE6A80.Size = new System.Drawing.Size(56, 23);
		this.E6BE6A80.TabIndex = 2;
		this.E6BE6A80.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(197, 81);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 105;
		this.label66.Text = "đê\u0301n";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FC208626.AutoSize = true;
		this.FC208626.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FC208626.Location = new System.Drawing.Point(30, 223);
		this.FC208626.Name = "ckbComment";
		this.FC208626.Size = new System.Drawing.Size(130, 20);
		this.FC208626.TabIndex = 9;
		this.FC208626.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		this.FC208626.UseVisualStyleBackColor = true;
		this.FC208626.CheckedChanged += new System.EventHandler(FC208626_CheckedChanged);
		this.EBA4B88C.AutoSize = true;
		this.EBA4B88C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EBA4B88C.Location = new System.Drawing.Point(30, 197);
		this.EBA4B88C.Name = "ckbShareWall";
		this.EBA4B88C.Size = new System.Drawing.Size(122, 20);
		this.EBA4B88C.TabIndex = 8;
		this.EBA4B88C.Text = "Chia sẻ về tường";
		this.EBA4B88C.UseVisualStyleBackColor = true;
		this.C63F4A8E.AutoSize = true;
		this.C63F4A8E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C63F4A8E.Location = new System.Drawing.Point(30, 171);
		this.C63F4A8E.Name = "ckbInteract";
		this.C63F4A8E.Size = new System.Drawing.Size(48, 20);
		this.C63F4A8E.TabIndex = 7;
		this.C63F4A8E.Text = "Like";
		this.C63F4A8E.UseVisualStyleBackColor = true;
		this.nudDelayTo.Location = new System.Drawing.Point(232, 140);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 6;
		this.F5397403.Location = new System.Drawing.Point(232, 110);
		this.F5397403.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.F5397403.Name = "nudSoLuongBaiVietTo";
		this.F5397403.Size = new System.Drawing.Size(56, 23);
		this.F5397403.TabIndex = 4;
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
		this.C38699B8.Location = new System.Drawing.Point(197, 112);
		this.C38699B8.Name = "label3";
		this.C38699B8.Size = new System.Drawing.Size(29, 16);
		this.C38699B8.TabIndex = 37;
		this.C38699B8.Text = "đê\u0301n";
		this.C38699B8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A318308A.AutoSize = true;
		this.A318308A.Location = new System.Drawing.Point(290, 142);
		this.A318308A.Name = "label6";
		this.A318308A.Size = new System.Drawing.Size(30, 16);
		this.A318308A.TabIndex = 36;
		this.A318308A.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(290, 112);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(24, 16);
		this.label4.TabIndex = 35;
		this.label4.Text = "ba\u0300i";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 142);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chơ\u0300:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.FDB9700C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.FDB9700C.BackColor = System.Drawing.Color.Maroon;
		this.FDB9700C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FDB9700C.FlatAppearance.BorderSize = 0;
		this.FDB9700C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.FDB9700C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FDB9700C.ForeColor = System.Drawing.Color.White;
		this.FDB9700C.Location = new System.Drawing.Point(189, 514);
		this.FDB9700C.Name = "btnCancel";
		this.FDB9700C.Size = new System.Drawing.Size(92, 29);
		this.FDB9700C.TabIndex = 12;
		this.FDB9700C.Text = "Đóng";
		this.FDB9700C.UseVisualStyleBackColor = false;
		this.FDB9700C.Click += new System.EventHandler(FDB9700C_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(82, 514);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 11;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		base.ClientSize = new System.Drawing.Size(362, 559);
		base.Controls.Add(this.BBA40EB5);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DDA13ABD);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.E43BB8B7).EndInit();
		this.BBA40EB5.ResumeLayout(false);
		this.BBA40EB5.PerformLayout();
		this.BA26EF37.ResumeLayout(false);
		this.BA26EF37.PerformLayout();
		this.C994BB1C.ResumeLayout(false);
		this.C994BB1C.PerformLayout();
		this.E38E5281.ResumeLayout(false);
		this.E38E5281.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBanBeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E6BE6A80).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F5397403).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
