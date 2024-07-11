using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDDangStatus : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool C32C8039;

	private IContainer B8890AB8 = null;

	private BunifuDragControl C828FB32;

	private BunifuDragControl bunifuDragControl_0;

	private Panel BBB9EEA3;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button A928E1B1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button D534E303;

	private PictureBox pictureBox1;

	private BunifuCustomLabel FCA22C8E;

	private CheckBox ckbAnh;

	private CheckBox ckbVanBan;

	private Panel plVanBan;

	private Label A32B698D;

	private Label lblStatus;

	private Panel FD272E88;

	private TextBox FA0BBB94;

	private Label D286E921;

	private RichTextBox txtNoiDung;

	private RadioButton CBA059AB;

	private RadioButton rbNganCachMoiDong;

	private Label label9;

	private CheckBox ckbUseBackground;

	private Panel plTag;

	private RichTextBox txtUidTag;

	private Label label11;

	private Label label10;

	private Label lbUid;

	private CheckBox B7184C9C;

	private NumericUpDown A9B71F0B;

	private NumericUpDown nudUidFrom;

	private Label AD9D17A8;

	private Label BA256826;

	private RadioButton rbUidTuNhap;

	private RadioButton A18422B0;

	private Label label12;

	private Panel plUidTuNhap;

	private Label label19;

	private Label label20;

	private NumericUpDown A7AE3A2E;

	private NumericUpDown DDB5D622;

	private Label F9A02296;

	private Label F3135C94;

	private NumericUpDown FA3F8796;

	private NumericUpDown B9BB6B1C;

	private Label label16;

	private Label label15;

	private NumericUpDown nudSoLuongAnhTo;

	private NumericUpDown DF9DA824;

	private Label DF103A3C;

	private Label label21;

	private Button D71B82A8;

	private Button button3;

	private Button button4;

	private LinkLabel CDAB8901;

	public fHDDangStatus(string CBAE2C88, int A79FB329 = 0, string A6B6E1A8 = "")
	{
		C384C6AE();
		C32C8039 = false;
		string_0 = CBAE2C88;
		string_2 = A6B6E1A8;
		int_0 = A79FB329;
		if (InteractSQL.B484648C("", "HDDangStatus").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDDangStatus', '{  \"ckbVanBan\": \"False\",\"txtNoiDung\": \"\",   \"ckbAnh\": \"False\",\"txtPathAnh\":\"\",\"nudSoLuongAnh\": \"1\",  \"ckbVideo\": \"False\",\"txtPathVideo\":\"\",\"nudSoLuongVideo\": \"1\"}', 'Đăng status');");
		}
		string text = "";
		switch (A79FB329)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDDangStatus");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(A6B6E1A8);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			A928E1B1.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDDangStatus_Load(object sender, EventArgs e)
	{
		try
		{
			B9BB6B1C.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			FA3F8796.Value = gclass8_0.GetValueInt("nudSoLuongTo", 1);
			DDB5D622.Value = gclass8_0.GetValueInt("nudKhoangCachFrom", 5);
			A7AE3A2E.Value = gclass8_0.GetValueInt("nudKhoangCachTo", 10);
			ckbVanBan.Checked = gclass8_0.GetValueBool("ckbVanBan");
			ckbUseBackground.Checked = gclass8_0.GetValueBool("ckbUseBackground");
			txtNoiDung.Text = gclass8_0.GetValue("txtNoiDung");
			ckbAnh.Checked = gclass8_0.GetValueBool("ckbAnh");
			DF9DA824.Value = gclass8_0.GetValueInt("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass8_0.GetValueInt("nudSoLuongAnhTo", 1);
			FA0BBB94.Text = gclass8_0.GetValue("txtPathAnh");
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				CBA059AB.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			if (gclass8_0.GetValueInt("typeUidTag") == 0)
			{
				A18422B0.Checked = true;
			}
			else
			{
				rbUidTuNhap.Checked = true;
			}
			B7184C9C.Checked = gclass8_0.GetValueBool("ckbTag");
			txtUidTag.Text = gclass8_0.GetValue("txtUidTag");
			nudUidFrom.Value = gclass8_0.GetValueInt("nudUidFrom", 1);
			A9B71F0B.Value = gclass8_0.GetValueInt("nudUidTo", 1);
		}
		catch (Exception)
		{
		}
		method_0();
	}

	private void D534E303_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C092EB26(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbAnh.Checked && !Directory.Exists(FA0BBB94.Text.Trim()))
		{
			MessageBoxHelper.Show("Đường dẫn ảnh không tồn tại!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", B9BB6B1C.Value);
		gClass.GetJson("nudSoLuongTo", FA3F8796.Value);
		gClass.GetJson("nudKhoangCachFrom", DDB5D622.Value);
		gClass.GetJson("nudKhoangCachTo", A7AE3A2E.Value);
		gClass.GetJson("ckbVanBan", ckbVanBan.Checked);
		gClass.GetJson("ckbUseBackground", ckbUseBackground.Checked);
		gClass.GetJson("ckbAnh", ckbAnh.Checked);
		gClass.GetJson("nudSoLuongAnhFrom", DF9DA824.Value);
		gClass.GetJson("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gClass.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.GetJson("txtPathAnh", FA0BBB94.Text.Trim());
		int num = 0;
		if (CBA059AB.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCach", num);
		if (A18422B0.Checked)
		{
			gClass.GetJson("typeUidTag", 0);
		}
		else if (rbUidTuNhap.Checked)
		{
			gClass.GetJson("typeUidTag", 1);
		}
		gClass.GetJson("ckbTag", B7184C9C.Checked);
		gClass.GetJson("txtUidTag", txtUidTag.Text.Trim());
		gClass.GetJson("nudUidFrom", nudUidFrom.Value);
		gClass.GetJson("nudUidTo", A9B71F0B.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					C32C8039 = true;
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
				C32C8039 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F6087431(object sender, EventArgs e)
	{
		Close();
	}

	private void BBB9EEA3_Paint(object sender, PaintEventArgs e)
	{
		if (BBB9EEA3.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BBB9EEA3.ClientSize.Width - num, BBB9EEA3.ClientSize.Height - num));
		}
	}

	private void method_0()
	{
		ckbVanBan_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
		method_1(null, null);
		AB9AF58F(null, null);
		rbUidTuNhap_CheckedChanged(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
		if (!ckbVanBan.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		FD272E88.Enabled = ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void E7873536(object sender, EventArgs e)
	{
		AB3C6426();
	}

	private void AB3C6426()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void A5AE3780()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtUidTag.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtUidTag.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lbUid.Text = string.Format(Language.GetValue("Danh sách Uid ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		AB3C6426();
	}

	private void FBB1BD97(object sender, EventArgs e)
	{
		AB3C6426();
	}

	private void CA1F6DB1(object sender, EventArgs e)
	{
	}

	private void AB9AF58F(object sender, EventArgs e)
	{
		plTag.Enabled = B7184C9C.Checked;
	}

	private void txtUidTag_TextChanged(object sender, EventArgs e)
	{
		A5AE3780();
	}

	private void lbUid_Click(object sender, EventArgs e)
	{
	}

	private void label11_Click(object sender, EventArgs e)
	{
	}

	private void rbUidTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		plUidTuNhap.Enabled = rbUidTuNhap.Checked;
	}

	private void FA0BBB94_TextChanged(object sender, EventArgs e)
	{
	}

	private void D71B82A8_Click(object sender, EventArgs e)
	{
		string object_ = Language.GetValue("Có thể dùng:") + Environment.NewLine + Language.GetValue("- [full_name] để thay thế họ tên của tài khoản!") + Environment.NewLine + Language.GetValue("- [name] để thay thế tên của tài khoản!");
		MessageBoxHelper.Show(object_);
	}

	private void A536469E(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtNoiDung.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtNoiDung.Focus();
	}

	private void CDAB8901_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && B8890AB8 != null)
		{
			B8890AB8.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void C384C6AE()
	{
		B8890AB8 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDangStatus));
		C828FB32 = new BunifuDragControl(B8890AB8);
		FCA22C8E = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(B8890AB8);
		pnlHeader = new Panel();
		D534E303 = new Button();
		pictureBox1 = new PictureBox();
		BBB9EEA3 = new Panel();
		label19 = new Label();
		label20 = new Label();
		A7AE3A2E = new NumericUpDown();
		DDB5D622 = new NumericUpDown();
		F9A02296 = new Label();
		F3135C94 = new Label();
		FA3F8796 = new NumericUpDown();
		B9BB6B1C = new NumericUpDown();
		label16 = new Label();
		label15 = new Label();
		plTag = new Panel();
		plUidTuNhap = new Panel();
		lbUid = new Label();
		label11 = new Label();
		txtUidTag = new RichTextBox();
		rbUidTuNhap = new RadioButton();
		A18422B0 = new RadioButton();
		A9B71F0B = new NumericUpDown();
		nudUidFrom = new NumericUpDown();
		label12 = new Label();
		label10 = new Label();
		AD9D17A8 = new Label();
		BA256826 = new Label();
		plVanBan = new Panel();
		CDAB8901 = new LinkLabel();
		button3 = new Button();
		D71B82A8 = new Button();
		button4 = new Button();
		CBA059AB = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		label9 = new Label();
		txtNoiDung = new RichTextBox();
		A32B698D = new Label();
		lblStatus = new Label();
		A928E1B1 = new Button();
		FD272E88 = new Panel();
		nudSoLuongAnhTo = new NumericUpDown();
		DF9DA824 = new NumericUpDown();
		DF103A3C = new Label();
		label21 = new Label();
		FA0BBB94 = new TextBox();
		D286E921 = new Label();
		B7184C9C = new CheckBox();
		ckbUseBackground = new CheckBox();
		ckbAnh = new CheckBox();
		ckbVanBan = new CheckBox();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		BBB9EEA3.SuspendLayout();
		((ISupportInitialize)A7AE3A2E).BeginInit();
		((ISupportInitialize)DDB5D622).BeginInit();
		((ISupportInitialize)FA3F8796).BeginInit();
		((ISupportInitialize)B9BB6B1C).BeginInit();
		plTag.SuspendLayout();
		plUidTuNhap.SuspendLayout();
		((ISupportInitialize)A9B71F0B).BeginInit();
		((ISupportInitialize)nudUidFrom).BeginInit();
		plVanBan.SuspendLayout();
		FD272E88.SuspendLayout();
		((ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((ISupportInitialize)DF9DA824).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		C828FB32.Fixed = true;
		C828FB32.Horizontal = true;
		C828FB32.TargetControl = FCA22C8E;
		C828FB32.Vertical = true;
		FCA22C8E.BackColor = Color.Transparent;
		FCA22C8E.Cursor = Cursors.SizeAll;
		FCA22C8E.Dock = DockStyle.Fill;
		FCA22C8E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		FCA22C8E.ForeColor = Color.Black;
		FCA22C8E.Location = new Point(0, 0);
		FCA22C8E.Name = "bunifuCustomLabel1";
		FCA22C8E.Size = new Size(680, 31);
		FCA22C8E.TabIndex = 12;
		FCA22C8E.Text = "Cấu hình Đăng status";
		FCA22C8E.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D534E303);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(FCA22C8E);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(680, 31);
		pnlHeader.TabIndex = 9;
		D534E303.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D534E303.Cursor = Cursors.Hand;
		D534E303.FlatAppearance.BorderSize = 0;
		D534E303.FlatStyle = FlatStyle.Flat;
		D534E303.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D534E303.ForeColor = Color.White;
		D534E303.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D534E303.Location = new Point(649, 1);
		D534E303.Name = "button1";
		D534E303.Size = new Size(30, 30);
		D534E303.TabIndex = 0;
		D534E303.TextImageRelation = TextImageRelation.ImageBeforeText;
		D534E303.UseVisualStyleBackColor = true;
		D534E303.Click += D534E303_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		BBB9EEA3.BackColor = Color.White;
		BBB9EEA3.BorderStyle = BorderStyle.FixedSingle;
		BBB9EEA3.Controls.Add(label19);
		BBB9EEA3.Controls.Add(label20);
		BBB9EEA3.Controls.Add(A7AE3A2E);
		BBB9EEA3.Controls.Add(DDB5D622);
		BBB9EEA3.Controls.Add(F9A02296);
		BBB9EEA3.Controls.Add(F3135C94);
		BBB9EEA3.Controls.Add(FA3F8796);
		BBB9EEA3.Controls.Add(B9BB6B1C);
		BBB9EEA3.Controls.Add(label16);
		BBB9EEA3.Controls.Add(label15);
		BBB9EEA3.Controls.Add(plTag);
		BBB9EEA3.Controls.Add(plVanBan);
		BBB9EEA3.Controls.Add(A928E1B1);
		BBB9EEA3.Controls.Add(FD272E88);
		BBB9EEA3.Controls.Add(B7184C9C);
		BBB9EEA3.Controls.Add(ckbUseBackground);
		BBB9EEA3.Controls.Add(ckbAnh);
		BBB9EEA3.Controls.Add(ckbVanBan);
		BBB9EEA3.Controls.Add(txtTenHanhDong);
		BBB9EEA3.Controls.Add(label1);
		BBB9EEA3.Controls.Add(btnCancel);
		BBB9EEA3.Controls.Add(bunifuCards1);
		BBB9EEA3.Cursor = Cursors.Arrow;
		BBB9EEA3.Dock = DockStyle.Fill;
		BBB9EEA3.Location = new Point(0, 0);
		BBB9EEA3.Name = "panel1";
		BBB9EEA3.Size = new Size(683, 591);
		BBB9EEA3.TabIndex = 0;
		BBB9EEA3.Paint += BBB9EEA3_Paint;
		label19.AutoSize = true;
		label19.Location = new Point(291, 109);
		label19.Name = "label19";
		label19.Size = new Size(30, 16);
		label19.TabIndex = 43;
		label19.Text = "giây";
		label20.Location = new Point(205, 109);
		label20.Name = "label20";
		label20.Size = new Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = "đến";
		label20.TextAlign = ContentAlignment.MiddleCenter;
		A7AE3A2E.Location = new Point(236, 107);
		A7AE3A2E.Name = "nudKhoangCachTo";
		A7AE3A2E.Size = new Size(51, 23);
		A7AE3A2E.TabIndex = 41;
		DDB5D622.Location = new Point(151, 107);
		DDB5D622.Name = "nudKhoangCachFrom";
		DDB5D622.Size = new Size(51, 23);
		DDB5D622.TabIndex = 40;
		F9A02296.AutoSize = true;
		F9A02296.Location = new Point(291, 83);
		F9A02296.Name = "label18";
		F9A02296.Size = new Size(24, 16);
		F9A02296.TabIndex = 39;
		F9A02296.Text = "bài";
		F3135C94.Location = new Point(205, 83);
		F3135C94.Name = "label17";
		F3135C94.Size = new Size(29, 16);
		F3135C94.TabIndex = 38;
		F3135C94.Text = "đến";
		F3135C94.TextAlign = ContentAlignment.MiddleCenter;
		FA3F8796.Location = new Point(236, 78);
		FA3F8796.Name = "nudSoLuongTo";
		FA3F8796.Size = new Size(51, 23);
		FA3F8796.TabIndex = 37;
		B9BB6B1C.Location = new Point(151, 78);
		B9BB6B1C.Name = "nudSoLuongFrom";
		B9BB6B1C.Size = new Size(51, 23);
		B9BB6B1C.TabIndex = 36;
		label16.AutoSize = true;
		label16.Location = new Point(30, 109);
		label16.Name = "label16";
		label16.Size = new Size(116, 16);
		label16.TabIndex = 35;
		label16.Text = "Khoảng cách đăng:";
		label15.AutoSize = true;
		label15.Location = new Point(30, 83);
		label15.Name = "label15";
		label15.Size = new Size(108, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng bài viết:";
		plTag.BorderStyle = BorderStyle.FixedSingle;
		plTag.Controls.Add(plUidTuNhap);
		plTag.Controls.Add(rbUidTuNhap);
		plTag.Controls.Add(A18422B0);
		plTag.Controls.Add(A9B71F0B);
		plTag.Controls.Add(nudUidFrom);
		plTag.Controls.Add(label12);
		plTag.Controls.Add(label10);
		plTag.Controls.Add(AD9D17A8);
		plTag.Controls.Add(BA256826);
		plTag.Enabled = false;
		plTag.Location = new Point(370, 269);
		plTag.Name = "plTag";
		plTag.Size = new Size(278, 255);
		plTag.TabIndex = 33;
		plUidTuNhap.BorderStyle = BorderStyle.FixedSingle;
		plUidTuNhap.Controls.Add(lbUid);
		plUidTuNhap.Controls.Add(label11);
		plUidTuNhap.Controls.Add(txtUidTag);
		plUidTuNhap.Location = new Point(17, 97);
		plUidTuNhap.Name = "plUidTuNhap";
		plUidTuNhap.Size = new Size(248, 151);
		plUidTuNhap.TabIndex = 34;
		lbUid.AutoSize = true;
		lbUid.Location = new Point(3, 3);
		lbUid.Name = "lbUid";
		lbUid.Size = new Size(114, 16);
		lbUid.TabIndex = 0;
		lbUid.Text = "Danh sa\u0301ch Uid (0):";
		lbUid.Click += lbUid_Click;
		label11.AutoSize = true;
		label11.Location = new Point(4, 127);
		label11.Name = "label11";
		label11.Size = new Size(133, 16);
		label11.TabIndex = 0;
		label11.Text = "(Mỗi nội dung 1 dòng)";
		label11.Click += label11_Click;
		txtUidTag.Location = new Point(7, 22);
		txtUidTag.Name = "txtUidTag";
		txtUidTag.Size = new Size(236, 102);
		txtUidTag.TabIndex = 34;
		txtUidTag.Text = "";
		txtUidTag.WordWrap = false;
		txtUidTag.TextChanged += txtUidTag_TextChanged;
		rbUidTuNhap.AutoSize = true;
		rbUidTuNhap.Cursor = Cursors.Hand;
		rbUidTuNhap.Location = new Point(17, 73);
		rbUidTuNhap.Name = "rbUidTuNhap";
		rbUidTuNhap.Size = new Size(186, 20);
		rbUidTuNhap.TabIndex = 42;
		rbUidTuNhap.Text = "Theo danh sách Uid tự nhập";
		rbUidTuNhap.UseVisualStyleBackColor = true;
		rbUidTuNhap.CheckedChanged += rbUidTuNhap_CheckedChanged;
		A18422B0.AutoSize = true;
		A18422B0.Checked = true;
		A18422B0.Cursor = Cursors.Hand;
		A18422B0.Location = new Point(17, 50);
		A18422B0.Name = "rbUidBanBe";
		A18422B0.Size = new Size(194, 20);
		A18422B0.TabIndex = 42;
		A18422B0.TabStop = true;
		A18422B0.Text = "Ngẫu nhiên danh sách bạn bè";
		A18422B0.UseVisualStyleBackColor = true;
		A9B71F0B.Location = new Point(208, 4);
		A9B71F0B.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		A9B71F0B.Name = "nudUidTo";
		A9B71F0B.Size = new Size(36, 23);
		A9B71F0B.TabIndex = 39;
		A9B71F0B.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		nudUidFrom.Location = new Point(137, 4);
		nudUidFrom.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		nudUidFrom.Name = "nudUidFrom";
		nudUidFrom.Size = new Size(36, 23);
		nudUidFrom.TabIndex = 38;
		nudUidFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label12.AutoSize = true;
		label12.Location = new Point(3, 31);
		label12.Name = "label12";
		label12.Size = new Size(126, 16);
		label12.TabIndex = 0;
		label12.Text = "Tùy chọn Uid để tag:";
		label10.AutoSize = true;
		label10.Location = new Point(3, 6);
		label10.Name = "label10";
		label10.Size = new Size(117, 16);
		label10.TabIndex = 0;
		label10.Text = "Số Uid cần tag/bài:";
		AD9D17A8.Location = new Point(176, 6);
		AD9D17A8.Name = "label13";
		AD9D17A8.Size = new Size(29, 16);
		AD9D17A8.TabIndex = 41;
		AD9D17A8.Text = "đê\u0301n";
		AD9D17A8.TextAlign = ContentAlignment.MiddleCenter;
		BA256826.AutoSize = true;
		BA256826.Location = new Point(244, 6);
		BA256826.Name = "label14";
		BA256826.Size = new Size(25, 16);
		BA256826.TabIndex = 40;
		BA256826.Text = "Uid";
		plVanBan.BorderStyle = BorderStyle.FixedSingle;
		plVanBan.Controls.Add(CDAB8901);
		plVanBan.Controls.Add(button3);
		plVanBan.Controls.Add(D71B82A8);
		plVanBan.Controls.Add(button4);
		plVanBan.Controls.Add(CBA059AB);
		plVanBan.Controls.Add(rbNganCachMoiDong);
		plVanBan.Controls.Add(label9);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(A32B698D);
		plVanBan.Controls.Add(lblStatus);
		plVanBan.Location = new Point(47, 159);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new Size(278, 365);
		plVanBan.TabIndex = 33;
		CDAB8901.Anchor = AnchorStyles.Bottom;
		CDAB8901.AutoSize = true;
		CDAB8901.Cursor = Cursors.Hand;
		CDAB8901.Location = new Point(166, 296);
		CDAB8901.Name = "linkLabel1";
		CDAB8901.Size = new Size(81, 16);
		CDAB8901.TabIndex = 111;
		CDAB8901.TabStop = true;
		CDAB8901.Text = "Random icon";
		CDAB8901.LinkClicked += CDAB8901_LinkClicked;
		button3.Cursor = Cursors.Help;
		button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(226, 339);
		button3.Name = "button3";
		button3.Size = new Size(21, 23);
		button3.TabIndex = 96;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += button3_Click;
		D71B82A8.Anchor = AnchorStyles.Bottom;
		D71B82A8.Cursor = Cursors.Help;
		D71B82A8.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D71B82A8.Location = new Point(248, 293);
		D71B82A8.Name = "button2";
		D71B82A8.Size = new Size(23, 23);
		D71B82A8.TabIndex = 95;
		D71B82A8.Text = "?";
		D71B82A8.UseVisualStyleBackColor = true;
		D71B82A8.Click += D71B82A8_Click;
		button4.Cursor = Cursors.Help;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(226, 316);
		button4.Name = "button4";
		button4.Size = new Size(21, 23);
		button4.TabIndex = 97;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button4.Click += A536469E;
		CBA059AB.AutoSize = true;
		CBA059AB.Cursor = Cursors.Hand;
		CBA059AB.Location = new Point(70, 339);
		CBA059AB.Name = "rbNganCachKyTu";
		CBA059AB.Size = new Size(159, 20);
		CBA059AB.TabIndex = 37;
		CBA059AB.Text = "Nội dung có nhiều dòng";
		CBA059AB.UseVisualStyleBackColor = true;
		CBA059AB.CheckedChanged += FBB1BD97;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(70, 318);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(155, 20);
		rbNganCachMoiDong.TabIndex = 36;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += rbNganCachMoiDong_CheckedChanged;
		label9.AutoSize = true;
		label9.Location = new Point(5, 318);
		label9.Name = "label9";
		label9.Size = new Size(64, 16);
		label9.TabIndex = 35;
		label9.Text = "Tùy chọn:";
		txtNoiDung.Location = new Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new Size(263, 263);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += E7873536;
		A32B698D.Anchor = AnchorStyles.Bottom;
		A32B698D.AutoSize = true;
		A32B698D.Location = new Point(5, 296);
		A32B698D.Name = "label8";
		A32B698D.Size = new Size(143, 16);
		A32B698D.TabIndex = 0;
		A32B698D.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(3, 4);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(145, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		A928E1B1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		A928E1B1.BackColor = Color.FromArgb(53, 120, 229);
		A928E1B1.Cursor = Cursors.Hand;
		A928E1B1.FlatAppearance.BorderSize = 0;
		A928E1B1.FlatStyle = FlatStyle.Flat;
		A928E1B1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A928E1B1.ForeColor = Color.White;
		A928E1B1.Location = new Point(245, 544);
		A928E1B1.Name = "btnAdd";
		A928E1B1.Size = new Size(92, 29);
		A928E1B1.TabIndex = 3;
		A928E1B1.Text = "Thêm";
		A928E1B1.UseVisualStyleBackColor = false;
		A928E1B1.Click += C092EB26;
		FD272E88.BorderStyle = BorderStyle.FixedSingle;
		FD272E88.Controls.Add(nudSoLuongAnhTo);
		FD272E88.Controls.Add(DF9DA824);
		FD272E88.Controls.Add(DF103A3C);
		FD272E88.Controls.Add(label21);
		FD272E88.Controls.Add(FA0BBB94);
		FD272E88.Controls.Add(D286E921);
		FD272E88.Location = new Point(370, 181);
		FD272E88.Name = "plAnh";
		FD272E88.Size = new Size(278, 58);
		FD272E88.TabIndex = 33;
		nudSoLuongAnhTo.Location = new Point(229, 29);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new Size(45, 23);
		nudSoLuongAnhTo.TabIndex = 7;
		DF9DA824.Location = new Point(136, 29);
		DF9DA824.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DF9DA824.Name = "nudSoLuongAnhFrom";
		DF9DA824.Size = new Size(45, 23);
		DF9DA824.TabIndex = 8;
		DF103A3C.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DF103A3C.Location = new Point(192, 31);
		DF103A3C.Name = "label2";
		DF103A3C.Size = new Size(29, 16);
		DF103A3C.TabIndex = 4;
		DF103A3C.Text = ">";
		DF103A3C.TextAlign = ContentAlignment.MiddleCenter;
		label21.AutoSize = true;
		label21.Location = new Point(3, 31);
		label21.Name = "label21";
		label21.Size = new Size(110, 16);
		label21.TabIndex = 6;
		label21.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		FA0BBB94.Location = new Point(136, 2);
		FA0BBB94.Name = "txtPathAnh";
		FA0BBB94.Size = new Size(138, 23);
		FA0BBB94.TabIndex = 1;
		FA0BBB94.TextChanged += FA0BBB94_TextChanged;
		D286E921.AutoSize = true;
		D286E921.Location = new Point(3, 5);
		D286E921.Name = "label3";
		D286E921.Size = new Size(137, 16);
		D286E921.TabIndex = 0;
		D286E921.Text = "Đường dẫn folder ảnh:";
		B7184C9C.AutoSize = true;
		B7184C9C.Cursor = Cursors.Hand;
		B7184C9C.Location = new Point(356, 245);
		B7184C9C.Name = "ckbTag";
		B7184C9C.Size = new Size(139, 20);
		B7184C9C.TabIndex = 32;
		B7184C9C.Text = "Tag Uid vào bài viết";
		B7184C9C.UseVisualStyleBackColor = true;
		B7184C9C.CheckedChanged += AB9AF58F;
		ckbUseBackground.AutoSize = true;
		ckbUseBackground.Cursor = Cursors.Hand;
		ckbUseBackground.Location = new Point(356, 135);
		ckbUseBackground.Name = "ckbUseBackground";
		ckbUseBackground.Size = new Size(144, 20);
		ckbUseBackground.TabIndex = 32;
		ckbUseBackground.Text = "Sử dụng Background";
		ckbUseBackground.UseVisualStyleBackColor = true;
		ckbUseBackground.CheckedChanged += CA1F6DB1;
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = Cursors.Hand;
		ckbAnh.Location = new Point(356, 159);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new Size(48, 20);
		ckbAnh.TabIndex = 32;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += ckbAnh_CheckedChanged;
		ckbVanBan.AutoSize = true;
		ckbVanBan.Cursor = Cursors.Hand;
		ckbVanBan.Location = new Point(33, 135);
		ckbVanBan.Name = "ckbVanBan";
		ckbVanBan.Size = new Size(73, 20);
		ckbVanBan.TabIndex = 32;
		ckbVanBan.Text = "Văn ba\u0309n";
		ckbVanBan.UseVisualStyleBackColor = true;
		ckbVanBan.CheckedChanged += ckbVanBan_CheckedChanged;
		txtTenHanhDong.Location = new Point(151, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(174, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(30, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(344, 544);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += F6087431;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(680, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(683, 591);
		base.Controls.Add(BBB9EEA3);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDangStatus";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDangStatus_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		BBB9EEA3.ResumeLayout(performLayout: false);
		BBB9EEA3.PerformLayout();
		((ISupportInitialize)A7AE3A2E).EndInit();
		((ISupportInitialize)DDB5D622).EndInit();
		((ISupportInitialize)FA3F8796).EndInit();
		((ISupportInitialize)B9BB6B1C).EndInit();
		plTag.ResumeLayout(performLayout: false);
		plTag.PerformLayout();
		plUidTuNhap.ResumeLayout(performLayout: false);
		plUidTuNhap.PerformLayout();
		((ISupportInitialize)A9B71F0B).EndInit();
		((ISupportInitialize)nudUidFrom).EndInit();
		plVanBan.ResumeLayout(performLayout: false);
		plVanBan.PerformLayout();
		FD272E88.ResumeLayout(performLayout: false);
		FD272E88.PerformLayout();
		((ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((ISupportInitialize)DF9DA824).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
