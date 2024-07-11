using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangBai : Form
{
	private ucTuongTacProfile ucTuongTacProfile_0;

	private JSON_Settings BAA91B28;

	private string string_0;

	private string FF93BD90;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer AF823811 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B0274E3F;

	private Panel panel1;

	private TextBox DB090F20;

	private Label E6B181A9;

	private Button BF0A4412;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox F9A61B27;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown B9136EBB;

	private Label label20;

	private Label label15;

	private Panel plAnh;

	private Label label3;

	private NumericUpDown nudSoLuongAnhTo;

	private Label EA968733;

	private NumericUpDown D3B2EE2E;

	private Label label10;

	private TextBox D20A5935;

	private CheckBox ckbUseAvatar;

	private CheckBox ckbUseBackground;

	private CheckBox ckbAnh;

	private CheckBox ckbVanBan;

	private CheckBox ckbXoaNhomDaDang;

	private GroupBox groupBox2;

	private Panel DA8E27A1;

	private Label D437CB0C;

	private NumericUpDown nudCountPageTo;

	private Label label23;

	private NumericUpDown D9129787;

	private Panel plDangBaiLenNhom;

	private CheckBox ckbKhongDangTrung;

	private CheckBox E7A3AD0B;

	private LinkLabel F324BA83;

	private CheckBox EE2E8CA5;

	private Panel panel3;

	private Panel plTuNhap;

	private RichTextBox txtNhomTuNhap;

	private CheckBox ckbChiDangNhomDaThamGia;

	private RadioButton rbTuNhap;

	private RadioButton rbRandom;

	private Label BC0C553C;

	private NumericUpDown nudCountGroupTo;

	private CheckBox ckbTuongTac;

	private NumericUpDown nudCountGroupFrom;

	private Label label24;

	private Label F39A49B8;

	private CheckBox DA0E518A;

	private CheckBox C60D3334;

	private CheckBox BE8ECA98;

	private Panel BD343911;

	private ComboBox cbbTuyChonNoiDung;

	private Button BE95461B;

	private LinkLabel B1258D95;

	private RichTextBox txtNoiDung;

	private Label label8;

	private Label label9;

	private Label lblNoiDung;

	private Panel AB0B1100;

	private Label label4;

	private NumericUpDown nudCountWallTo;

	private Label label5;

	private NumericUpDown nudCountWallFrom;

	private GroupBox C2A04BB7;

	private CheckBox ckbCopyPost;

	private Panel AF8A2DB0;

	private Label lblIdPost;

	private RichTextBox txtIdPost;

	private CheckBox ckbThemVaoCuoiNoiDung;

	private LinkLabel linkLabel2;

	private RichTextBox txtNoiDungThemVaoCuoi;

	private Label label6;

	private CheckBox C3BE6B9D;

	private CheckBox D00D6121;

	private CheckBox D33605B2;

	private Panel plNotUseAvatar;

	public fHDDangBai(string C09DFC32, int int_1 = 0, string EDA27A0C = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = C09DFC32;
		string_1 = EDA27A0C;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng bài";
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
			FF93BD90 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DB090F20.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(EDA27A0C);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DB090F20.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		BAA91B28 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
		ucTuongTacProfile_0 = new ucTuongTacProfile(BAA91B28)
		{
			Visible = false
		};
		base.Controls.Add(ucTuongTacProfile_0);
		ucTuongTacProfile_0.AF142CA5(bool_0: true);
	}

	private void BDB67D95(object sender, EventArgs e)
	{
		method_0();
		try
		{
			B9136EBB.Value = BAA91B28.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = BAA91B28.GetValueInt("nudDelayTo", 5);
			ckbVanBan.Checked = BAA91B28.GetValueBool("ckbVanBan");
			txtNoiDung.Text = BAA91B28.GetValue("txtNoiDung");
			cbbTuyChonNoiDung.SelectedIndex = BAA91B28.GetValueInt("typeNganCach");
			ckbUseBackground.Checked = BAA91B28.GetValueBool("ckbUseBackground");
			D00D6121.Checked = BAA91B28.GetValueBool("ckbXoaNoiDung");
			ckbAnh.Checked = BAA91B28.GetValueBool("ckbAnh");
			D3B2EE2E.Value = BAA91B28.GetValueInt("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = BAA91B28.GetValueInt("nudSoLuongAnhTo", 1);
			ckbUseAvatar.Checked = BAA91B28.GetValueBool("ckbUseAvatar");
			D20A5935.Text = BAA91B28.GetValue("txtPathAnh");
			D33605B2.Checked = BAA91B28.GetValueBool("ckbXoaAnh");
			BE8ECA98.Checked = BAA91B28.GetValueBool("ckbDangBaiLenTuong");
			nudCountWallFrom.Value = BAA91B28.GetValueInt("nudCountWallFrom", 1);
			nudCountWallTo.Value = BAA91B28.GetValueInt("nudCountWallTo", 1);
			C60D3334.Checked = BAA91B28.GetValueBool("ckbDangBaiLenNhom");
			nudCountGroupFrom.Value = BAA91B28.GetValueInt("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = BAA91B28.GetValueInt("nudCountGroupTo", 1);
			if (BAA91B28.GetValueInt("typePost") == 0)
			{
				rbRandom.Checked = true;
			}
			else
			{
				rbTuNhap.Checked = true;
			}
			txtNhomTuNhap.Text = BAA91B28.GetValue("lstNhomTuNhap");
			ckbChiDangNhomDaThamGia.Checked = BAA91B28.GetValueBool("ckbChiDangNhomDaThamGia");
			ckbXoaNhomDaDang.Checked = BAA91B28.GetValueBool("ckbXoaNhomDaDang");
			EE2E8CA5.Checked = BAA91B28.GetValueBool("ckbOnlyDangNhomKhongKiemDuyet");
			E7A3AD0B.Checked = BAA91B28.GetValueBool("ckbUuTienNhomNhieuThanhVien");
			ckbKhongDangTrung.Checked = BAA91B28.GetValueBool("ckbKhongDangTrung");
			ckbTuongTac.Checked = BAA91B28.GetValueBool("ckbTuongTac");
			DA0E518A.Checked = BAA91B28.GetValueBool("ckbDangBaiLenPage");
			D9129787.Value = BAA91B28.GetValueInt("nudCountPageFrom", 1);
			nudCountPageTo.Value = BAA91B28.GetValueInt("nudCountPageTo", 1);
			ckbCopyPost.Checked = BAA91B28.GetValueBool("ckbCopyPost");
			txtIdPost.Text = BAA91B28.GetValue("txtIdPost");
			C3BE6B9D.Checked = BAA91B28.GetValueBool("ckbXoaIdPostDaDung");
			ckbThemVaoCuoiNoiDung.Checked = BAA91B28.GetValueBool("ckbThemVaoCuoiNoiDung");
			txtNoiDungThemVaoCuoi.Text = BAA91B28.GetValue("txtNoiDungThemVaoCuoi");
		}
		catch (Exception)
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(cbbTuyChonNoiDung, e6A5AC);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = DB090F20.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		BAA91B28.GetJson("nudDelayFrom", B9136EBB.Value);
		BAA91B28.GetJson("nudDelayTo", nudDelayTo.Value);
		BAA91B28.GetJson("ckbVanBan", ckbVanBan.Checked);
		BAA91B28.GetJson("ckbXoaNoiDung", D00D6121.Checked);
		BAA91B28.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		BAA91B28.GetJson("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		BAA91B28.GetJson("ckbUseBackground", ckbUseBackground.Checked);
		BAA91B28.GetJson("ckbAnh", ckbAnh.Checked);
		BAA91B28.GetJson("nudSoLuongAnhFrom", D3B2EE2E.Value);
		BAA91B28.GetJson("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		BAA91B28.GetJson("ckbUseAvatar", ckbUseAvatar.Checked);
		BAA91B28.GetJson("txtPathAnh", D20A5935.Text.Trim());
		BAA91B28.GetJson("ckbXoaAnh", D33605B2.Checked);
		BAA91B28.GetJson("ckbDangBaiLenTuong", BE8ECA98.Checked);
		BAA91B28.GetJson("nudCountWallFrom", nudCountWallFrom.Value);
		BAA91B28.GetJson("nudCountWallTo", nudCountWallTo.Value);
		BAA91B28.GetJson("ckbDangBaiLenNhom", C60D3334.Checked);
		BAA91B28.GetJson("nudCountGroupFrom", nudCountGroupFrom.Value);
		BAA91B28.GetJson("nudCountGroupTo", nudCountGroupTo.Value);
		int num = 0;
		if (rbTuNhap.Checked)
		{
			num = 1;
		}
		BAA91B28.GetJson("typePost", num);
		BAA91B28.GetJson("lstNhomTuNhap", txtNhomTuNhap.Text);
		BAA91B28.GetJson("ckbChiDangNhomDaThamGia", ckbChiDangNhomDaThamGia.Checked);
		BAA91B28.GetJson("ckbXoaNhomDaDang", ckbXoaNhomDaDang.Checked);
		BAA91B28.GetJson("ckbOnlyDangNhomKhongKiemDuyet", EE2E8CA5.Checked);
		BAA91B28.GetJson("ckbUuTienNhomNhieuThanhVien", E7A3AD0B.Checked);
		BAA91B28.GetJson("ckbKhongDangTrung", ckbKhongDangTrung.Checked);
		BAA91B28.GetJson("ckbTuongTac", ckbTuongTac.Checked);
		BAA91B28.GetJson("ckbDangBaiLenPage", DA0E518A.Checked);
		BAA91B28.GetJson("nudCountPageFrom", D9129787.Value);
		BAA91B28.GetJson("nudCountPageTo", nudCountPageTo.Value);
		BAA91B28.GetJson("ckbCopyPost", ckbCopyPost.Checked);
		BAA91B28.GetJson("txtIdPost", txtIdPost.Text.Trim());
		BAA91B28.GetJson("ckbXoaIdPostDaDung", C3BE6B9D.Checked);
		BAA91B28.GetJson("ckbThemVaoCuoiNoiDung", ckbThemVaoCuoiNoiDung.Checked);
		BAA91B28.GetJson("txtNoiDungThemVaoCuoi", txtNoiDungThemVaoCuoi.Text.Trim());
		string string_ = BAA91B28.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, FF93BD90, string_))
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

	private void F82CB183(object sender, EventArgs e)
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

	private void method_1()
	{
		C60D3334_CheckedChanged(null, null);
		DA0E518A_CheckedChanged(null, null);
		ckbVanBan_CheckedChanged(null, null);
		B235413D(null, null);
		C19C9E1D(null, null);
		rbTuNhap_CheckedChanged(null, null);
		ckbTuongTac_CheckedChanged(null, null);
		BE8ECA98_CheckedChanged(null, null);
		ckbCopyPost_CheckedChanged(null, null);
		FCAEC6A9(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		BD343911.Enabled = ckbVanBan.Checked;
		ckbUseBackground_CheckedChanged(null, null);
	}

	private void B235413D(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtNoiDung, lblNoiDung, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void B1258D95_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void BE95461B_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtNoiDung.Focus();
	}

	private void B8AE5285(object sender, EventArgs e)
	{
		Common.F9202C12(txtNoiDung, lblNoiDung, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void C60D3334_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = C60D3334.Checked;
	}

	private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		plTuNhap.Enabled = rbTuNhap.Checked;
		if (rbTuNhap.Checked)
		{
			if (!ckbChiDangNhomDaThamGia.Checked)
			{
				EE2E8CA5.Checked = false;
				EE2E8CA5.Enabled = false;
				E7A3AD0B.Checked = false;
				E7A3AD0B.Enabled = false;
			}
		}
		else
		{
			EE2E8CA5.Enabled = true;
			E7A3AD0B.Enabled = true;
		}
	}

	private void txtNhomTuNhap_TextChanged(object sender, EventArgs e)
	{
		Common.smethod_49(sender as RichTextBox, rbTuNhap);
	}

	private void ckbChiDangNhomDaThamGia_CheckedChanged(object sender, EventArgs e)
	{
		if (!ckbChiDangNhomDaThamGia.Checked)
		{
			EE2E8CA5.Checked = false;
			EE2E8CA5.Enabled = false;
			E7A3AD0B.Checked = false;
			E7A3AD0B.Enabled = false;
		}
		else
		{
			EE2E8CA5.Enabled = true;
			E7A3AD0B.Enabled = true;
		}
	}

	private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		F324BA83.Enabled = ckbTuongTac.Checked;
	}

	private void F324BA83_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_18(ucTuongTacProfile_0, this);
	}

	private void DA0E518A_CheckedChanged(object sender, EventArgs e)
	{
		DA8E27A1.Enabled = DA0E518A.Checked;
	}

	private void C19C9E1D(object sender, EventArgs e)
	{
		plNotUseAvatar.Enabled = !ckbUseAvatar.Checked;
	}

	private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
	{
		if (ckbVanBan.Checked && ckbUseBackground.Checked)
		{
			ckbAnh.Checked = false;
			ckbAnh.Enabled = false;
		}
		else
		{
			ckbAnh.Enabled = true;
		}
	}

	private void BE8ECA98_CheckedChanged(object sender, EventArgs e)
	{
		AB0B1100.Enabled = BE8ECA98.Checked;
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtIdPost, lblIdPost);
	}

	private void ckbCopyPost_CheckedChanged(object sender, EventArgs e)
	{
		AF8A2DB0.Enabled = ckbCopyPost.Checked;
		if (ckbCopyPost.Checked)
		{
			ckbVanBan.Checked = false;
			ckbAnh.Checked = false;
		}
		ckbVanBan.Enabled = !ckbCopyPost.Checked;
		ckbAnh.Enabled = !ckbCopyPost.Checked;
	}

	private void FCAEC6A9(object sender, EventArgs e)
	{
		txtNoiDungThemVaoCuoi.Enabled = ckbThemVaoCuoiNoiDung.Checked;
	}

	private void plAnh_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool FA21D724)
	{
		if (FA21D724 && AF823811 != null)
		{
			AF823811.Dispose();
		}
		base.Dispose(FA21D724);
	}

	private void InitializeComponent()
	{
		this.AF823811 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangBai));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.AF823811);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.B0274E3F = new Bunifu.Framework.UI.BunifuDragControl(this.AF823811);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.F9A61B27 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.C2A04BB7 = new System.Windows.Forms.GroupBox();
		this.ckbCopyPost = new System.Windows.Forms.CheckBox();
		this.ckbVanBan = new System.Windows.Forms.CheckBox();
		this.AF8A2DB0 = new System.Windows.Forms.Panel();
		this.C3BE6B9D = new System.Windows.Forms.CheckBox();
		this.ckbThemVaoCuoiNoiDung = new System.Windows.Forms.CheckBox();
		this.lblIdPost = new System.Windows.Forms.Label();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.txtNoiDungThemVaoCuoi = new System.Windows.Forms.RichTextBox();
		this.txtIdPost = new System.Windows.Forms.RichTextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.BD343911 = new System.Windows.Forms.Panel();
		this.D00D6121 = new System.Windows.Forms.CheckBox();
		this.cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		this.BE95461B = new System.Windows.Forms.Button();
		this.B1258D95 = new System.Windows.Forms.LinkLabel();
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.ckbUseBackground = new System.Windows.Forms.CheckBox();
		this.label9 = new System.Windows.Forms.Label();
		this.lblNoiDung = new System.Windows.Forms.Label();
		this.ckbAnh = new System.Windows.Forms.CheckBox();
		this.plAnh = new System.Windows.Forms.Panel();
		this.plNotUseAvatar = new System.Windows.Forms.Panel();
		this.label3 = new System.Windows.Forms.Label();
		this.D20A5935 = new System.Windows.Forms.TextBox();
		this.D3B2EE2E = new System.Windows.Forms.NumericUpDown();
		this.D33605B2 = new System.Windows.Forms.CheckBox();
		this.label10 = new System.Windows.Forms.Label();
		this.nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		this.EA968733 = new System.Windows.Forms.Label();
		this.ckbUseAvatar = new System.Windows.Forms.CheckBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.AB0B1100 = new System.Windows.Forms.Panel();
		this.label4 = new System.Windows.Forms.Label();
		this.nudCountWallTo = new System.Windows.Forms.NumericUpDown();
		this.label5 = new System.Windows.Forms.Label();
		this.nudCountWallFrom = new System.Windows.Forms.NumericUpDown();
		this.DA8E27A1 = new System.Windows.Forms.Panel();
		this.D437CB0C = new System.Windows.Forms.Label();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.D9129787 = new System.Windows.Forms.NumericUpDown();
		this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
		this.ckbKhongDangTrung = new System.Windows.Forms.CheckBox();
		this.E7A3AD0B = new System.Windows.Forms.CheckBox();
		this.F324BA83 = new System.Windows.Forms.LinkLabel();
		this.EE2E8CA5 = new System.Windows.Forms.CheckBox();
		this.panel3 = new System.Windows.Forms.Panel();
		this.plTuNhap = new System.Windows.Forms.Panel();
		this.txtNhomTuNhap = new System.Windows.Forms.RichTextBox();
		this.ckbChiDangNhomDaThamGia = new System.Windows.Forms.CheckBox();
		this.ckbXoaNhomDaDang = new System.Windows.Forms.CheckBox();
		this.rbTuNhap = new System.Windows.Forms.RadioButton();
		this.rbRandom = new System.Windows.Forms.RadioButton();
		this.BC0C553C = new System.Windows.Forms.Label();
		this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		this.ckbTuongTac = new System.Windows.Forms.CheckBox();
		this.nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
		this.label24 = new System.Windows.Forms.Label();
		this.F39A49B8 = new System.Windows.Forms.Label();
		this.DA0E518A = new System.Windows.Forms.CheckBox();
		this.C60D3334 = new System.Windows.Forms.CheckBox();
		this.BE8ECA98 = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.B9136EBB = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.btnAdd = new System.Windows.Forms.Button();
		this.DB090F20 = new System.Windows.Forms.TextBox();
		this.E6B181A9 = new System.Windows.Forms.Label();
		this.BF0A4412 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.F9A61B27).BeginInit();
		this.panel1.SuspendLayout();
		this.C2A04BB7.SuspendLayout();
		this.AF8A2DB0.SuspendLayout();
		this.BD343911.SuspendLayout();
		this.plAnh.SuspendLayout();
		this.plNotUseAvatar.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D3B2EE2E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).BeginInit();
		this.groupBox2.SuspendLayout();
		this.AB0B1100.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountWallTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountWallFrom).BeginInit();
		this.DA8E27A1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D9129787).BeginInit();
		this.plDangBaiLenNhom.SuspendLayout();
		this.panel3.SuspendLayout();
		this.plTuNhap.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B9136EBB).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1034, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Đăng bài";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B0274E3F.Fixed = true;
		this.B0274E3F.Horizontal = true;
		this.B0274E3F.TargetControl = this.pnlHeader;
		this.B0274E3F.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.F9A61B27);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1034, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(1003, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 0;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.F9A61B27.Cursor = System.Windows.Forms.Cursors.Default;
		this.F9A61B27.Image = Resources.Bitmap_4;
		this.F9A61B27.Location = new System.Drawing.Point(3, 2);
		this.F9A61B27.Name = "pictureBox1";
		this.F9A61B27.Size = new System.Drawing.Size(34, 27);
		this.F9A61B27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.F9A61B27.TabIndex = 76;
		this.F9A61B27.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.C2A04BB7);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.nudDelayTo);
		this.panel1.Controls.Add(this.B9136EBB);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.DB090F20);
		this.panel1.Controls.Add(this.E6B181A9);
		this.panel1.Controls.Add(this.BF0A4412);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1037, 693);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.C2A04BB7.Controls.Add(this.ckbCopyPost);
		this.C2A04BB7.Controls.Add(this.ckbVanBan);
		this.C2A04BB7.Controls.Add(this.AF8A2DB0);
		this.C2A04BB7.Controls.Add(this.BD343911);
		this.C2A04BB7.Controls.Add(this.ckbAnh);
		this.C2A04BB7.Controls.Add(this.plAnh);
		this.C2A04BB7.Location = new System.Drawing.Point(404, 107);
		this.C2A04BB7.Name = "groupBox1";
		this.C2A04BB7.Size = new System.Drawing.Size(600, 524);
		this.C2A04BB7.TabIndex = 72;
		this.C2A04BB7.TabStop = false;
		this.C2A04BB7.Text = "Nội dung đăng";
		this.ckbCopyPost.AutoSize = true;
		this.ckbCopyPost.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCopyPost.Location = new System.Drawing.Point(356, 22);
		this.ckbCopyPost.Name = "ckbCopyPost";
		this.ckbCopyPost.Size = new System.Drawing.Size(206, 20);
		this.ckbCopyPost.TabIndex = 66;
		this.ckbCopyPost.Text = "Sao chép bài viết trên facebook";
		this.ckbCopyPost.UseVisualStyleBackColor = true;
		this.ckbCopyPost.CheckedChanged += new System.EventHandler(ckbCopyPost_CheckedChanged);
		this.ckbVanBan.AutoSize = true;
		this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVanBan.Location = new System.Drawing.Point(9, 22);
		this.ckbVanBan.Name = "ckbVanBan";
		this.ckbVanBan.Size = new System.Drawing.Size(76, 20);
		this.ckbVanBan.TabIndex = 66;
		this.ckbVanBan.Text = "Nội dung";
		this.ckbVanBan.UseVisualStyleBackColor = true;
		this.ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		this.AF8A2DB0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.AF8A2DB0.Controls.Add(this.C3BE6B9D);
		this.AF8A2DB0.Controls.Add(this.ckbThemVaoCuoiNoiDung);
		this.AF8A2DB0.Controls.Add(this.lblIdPost);
		this.AF8A2DB0.Controls.Add(this.linkLabel2);
		this.AF8A2DB0.Controls.Add(this.txtNoiDungThemVaoCuoi);
		this.AF8A2DB0.Controls.Add(this.txtIdPost);
		this.AF8A2DB0.Controls.Add(this.label6);
		this.AF8A2DB0.Location = new System.Drawing.Point(356, 45);
		this.AF8A2DB0.Name = "plCopyPost";
		this.AF8A2DB0.Size = new System.Drawing.Size(236, 471);
		this.AF8A2DB0.TabIndex = 71;
		this.C3BE6B9D.AutoSize = true;
		this.C3BE6B9D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C3BE6B9D.Location = new System.Drawing.Point(6, 295);
		this.C3BE6B9D.Name = "ckbXoaIdPostDaDung";
		this.C3BE6B9D.Size = new System.Drawing.Size(158, 20);
		this.C3BE6B9D.TabIndex = 66;
		this.C3BE6B9D.Text = "Xóa Id bài viết đã dùng";
		this.C3BE6B9D.UseVisualStyleBackColor = true;
		this.C3BE6B9D.CheckedChanged += new System.EventHandler(FCAEC6A9);
		this.ckbThemVaoCuoiNoiDung.AutoSize = true;
		this.ckbThemVaoCuoiNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThemVaoCuoiNoiDung.Location = new System.Drawing.Point(6, 321);
		this.ckbThemVaoCuoiNoiDung.Name = "ckbThemVaoCuoiNoiDung";
		this.ckbThemVaoCuoiNoiDung.Size = new System.Drawing.Size(163, 20);
		this.ckbThemVaoCuoiNoiDung.TabIndex = 66;
		this.ckbThemVaoCuoiNoiDung.Text = "Thêm vào cuối nội dung";
		this.ckbThemVaoCuoiNoiDung.UseVisualStyleBackColor = true;
		this.ckbThemVaoCuoiNoiDung.CheckedChanged += new System.EventHandler(FCAEC6A9);
		this.lblIdPost.AutoSize = true;
		this.lblIdPost.Location = new System.Drawing.Point(1, 4);
		this.lblIdPost.Name = "lblIdPost";
		this.lblIdPost.Size = new System.Drawing.Size(152, 16);
		this.lblIdPost.TabIndex = 179;
		this.lblIdPost.Text = "Danh sách Id bài viết (0):";
		this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel2.Location = new System.Drawing.Point(150, 450);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(81, 16);
		this.linkLabel2.TabIndex = 183;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Random icon";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B1258D95_LinkClicked);
		this.txtNoiDungThemVaoCuoi.Location = new System.Drawing.Point(6, 343);
		this.txtNoiDungThemVaoCuoi.Name = "txtNoiDungThemVaoCuoi";
		this.txtNoiDungThemVaoCuoi.Size = new System.Drawing.Size(224, 105);
		this.txtNoiDungThemVaoCuoi.TabIndex = 180;
		this.txtNoiDungThemVaoCuoi.Text = "";
		this.txtNoiDungThemVaoCuoi.WordWrap = false;
		this.txtNoiDungThemVaoCuoi.TextChanged += new System.EventHandler(txtIdPost_TextChanged);
		this.txtIdPost.Location = new System.Drawing.Point(5, 24);
		this.txtIdPost.Name = "txtIdPost";
		this.txtIdPost.Size = new System.Drawing.Size(224, 267);
		this.txtIdPost.TabIndex = 180;
		this.txtIdPost.Text = "";
		this.txtIdPost.WordWrap = false;
		this.txtIdPost.TextChanged += new System.EventHandler(txtIdPost_TextChanged);
		this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 450);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(143, 16);
		this.label6.TabIndex = 178;
		this.label6.Text = "(Spin nội dung {a|b|c})";
		this.BD343911.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BD343911.Controls.Add(this.D00D6121);
		this.BD343911.Controls.Add(this.cbbTuyChonNoiDung);
		this.BD343911.Controls.Add(this.BE95461B);
		this.BD343911.Controls.Add(this.B1258D95);
		this.BD343911.Controls.Add(this.txtNoiDung);
		this.BD343911.Controls.Add(this.label8);
		this.BD343911.Controls.Add(this.ckbUseBackground);
		this.BD343911.Controls.Add(this.label9);
		this.BD343911.Controls.Add(this.lblNoiDung);
		this.BD343911.Location = new System.Drawing.Point(26, 45);
		this.BD343911.Name = "plVanBan";
		this.BD343911.Size = new System.Drawing.Size(307, 336);
		this.BD343911.TabIndex = 71;
		this.D00D6121.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.D00D6121.AutoSize = true;
		this.D00D6121.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D00D6121.Location = new System.Drawing.Point(6, 311);
		this.D00D6121.Name = "ckbXoaNoiDung";
		this.D00D6121.Size = new System.Drawing.Size(169, 20);
		this.D00D6121.TabIndex = 185;
		this.D00D6121.Text = "Xóa nội dung đã sử dụng";
		this.D00D6121.UseVisualStyleBackColor = true;
		this.cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTuyChonNoiDung.FormattingEnabled = true;
		this.cbbTuyChonNoiDung.Location = new System.Drawing.Point(80, 283);
		this.cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		this.cbbTuyChonNoiDung.Size = new System.Drawing.Size(190, 24);
		this.cbbTuyChonNoiDung.TabIndex = 184;
		this.cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(B8AE5285);
		this.BE95461B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.BE95461B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BE95461B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BE95461B.Location = new System.Drawing.Point(275, 282);
		this.BE95461B.Name = "btnHuongDanNhapNoiDung";
		this.BE95461B.Size = new System.Drawing.Size(26, 26);
		this.BE95461B.TabIndex = 182;
		this.BE95461B.Text = "?";
		this.BE95461B.UseVisualStyleBackColor = true;
		this.BE95461B.Click += new System.EventHandler(BE95461B_Click);
		this.B1258D95.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.B1258D95.AutoSize = true;
		this.B1258D95.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B1258D95.Location = new System.Drawing.Point(222, 260);
		this.B1258D95.Name = "linkLabel1";
		this.B1258D95.Size = new System.Drawing.Size(81, 16);
		this.B1258D95.TabIndex = 183;
		this.B1258D95.TabStop = true;
		this.B1258D95.Text = "Random icon";
		this.B1258D95.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B1258D95_LinkClicked);
		this.txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtNoiDung.Location = new System.Drawing.Point(5, 24);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(295, 233);
		this.txtNoiDung.TabIndex = 180;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(3, 260);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(143, 16);
		this.label8.TabIndex = 178;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.ckbUseBackground.AutoSize = true;
		this.ckbUseBackground.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseBackground.Location = new System.Drawing.Point(162, 3);
		this.ckbUseBackground.Name = "ckbUseBackground";
		this.ckbUseBackground.Size = new System.Drawing.Size(144, 20);
		this.ckbUseBackground.TabIndex = 64;
		this.ckbUseBackground.Text = "Sử dụng Background";
		this.ckbUseBackground.UseVisualStyleBackColor = true;
		this.ckbUseBackground.CheckedChanged += new System.EventHandler(ckbUseBackground_CheckedChanged);
		this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(3, 286);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 181;
		this.label9.Text = "Tùy chọn:";
		this.lblNoiDung.AutoSize = true;
		this.lblNoiDung.Location = new System.Drawing.Point(1, 4);
		this.lblNoiDung.Name = "lblNoiDung";
		this.lblNoiDung.Size = new System.Drawing.Size(83, 16);
		this.lblNoiDung.TabIndex = 179;
		this.lblNoiDung.Text = "Nội dung (0):";
		this.ckbAnh.AutoSize = true;
		this.ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAnh.Location = new System.Drawing.Point(9, 386);
		this.ckbAnh.Name = "ckbAnh";
		this.ckbAnh.Size = new System.Drawing.Size(48, 20);
		this.ckbAnh.TabIndex = 65;
		this.ckbAnh.Text = "A\u0309nh";
		this.ckbAnh.UseVisualStyleBackColor = true;
		this.ckbAnh.CheckedChanged += new System.EventHandler(B235413D);
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.plNotUseAvatar);
		this.plAnh.Controls.Add(this.ckbUseAvatar);
		this.plAnh.Location = new System.Drawing.Point(26, 409);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(307, 107);
		this.plAnh.TabIndex = 69;
		this.plAnh.Paint += new System.Windows.Forms.PaintEventHandler(plAnh_Paint);
		this.plNotUseAvatar.Controls.Add(this.label3);
		this.plNotUseAvatar.Controls.Add(this.D20A5935);
		this.plNotUseAvatar.Controls.Add(this.D3B2EE2E);
		this.plNotUseAvatar.Controls.Add(this.D33605B2);
		this.plNotUseAvatar.Controls.Add(this.label10);
		this.plNotUseAvatar.Controls.Add(this.nudSoLuongAnhTo);
		this.plNotUseAvatar.Controls.Add(this.EA968733);
		this.plNotUseAvatar.Location = new System.Drawing.Point(-1, -1);
		this.plNotUseAvatar.Name = "plNotUseAvatar";
		this.plNotUseAvatar.Size = new System.Drawing.Size(307, 81);
		this.plNotUseAvatar.TabIndex = 34;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(4, 8);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(73, 16);
		this.label3.TabIndex = 0;
		this.label3.Text = "Folder ảnh:";
		this.D20A5935.Location = new System.Drawing.Point(83, 5);
		this.D20A5935.Name = "txtPathAnh";
		this.D20A5935.Size = new System.Drawing.Size(218, 23);
		this.D20A5935.TabIndex = 1;
		this.D3B2EE2E.Location = new System.Drawing.Point(83, 33);
		this.D3B2EE2E.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.D3B2EE2E.Name = "nudSoLuongAnhFrom";
		this.D3B2EE2E.Size = new System.Drawing.Size(45, 23);
		this.D3B2EE2E.TabIndex = 3;
		this.D33605B2.AutoSize = true;
		this.D33605B2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D33605B2.Location = new System.Drawing.Point(7, 60);
		this.D33605B2.Name = "ckbXoaAnh";
		this.D33605B2.Size = new System.Drawing.Size(141, 20);
		this.D33605B2.TabIndex = 33;
		this.D33605B2.Text = "Xóa ảnh đã sử dụng";
		this.D33605B2.UseVisualStyleBackColor = true;
		this.D33605B2.CheckedChanged += new System.EventHandler(C19C9E1D);
		this.label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new System.Drawing.Point(130, 35);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(29, 16);
		this.label10.TabIndex = 0;
		this.label10.Text = ">";
		this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.nudSoLuongAnhTo.Location = new System.Drawing.Point(161, 33);
		this.nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		this.nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 23);
		this.nudSoLuongAnhTo.TabIndex = 3;
		this.EA968733.AutoSize = true;
		this.EA968733.Location = new System.Drawing.Point(4, 35);
		this.EA968733.Name = "label2";
		this.EA968733.Size = new System.Drawing.Size(74, 16);
		this.EA968733.TabIndex = 0;
		this.EA968733.Text = "Sô\u0301 a\u0309nh/bài:";
		this.ckbUseAvatar.AutoSize = true;
		this.ckbUseAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbUseAvatar.Location = new System.Drawing.Point(6, 82);
		this.ckbUseAvatar.Name = "ckbUseAvatar";
		this.ckbUseAvatar.Size = new System.Drawing.Size(196, 20);
		this.ckbUseAvatar.TabIndex = 33;
		this.ckbUseAvatar.Text = "Sử dụng avatar làm ảnh đăng";
		this.ckbUseAvatar.UseVisualStyleBackColor = true;
		this.ckbUseAvatar.CheckedChanged += new System.EventHandler(C19C9E1D);
		this.groupBox2.Controls.Add(this.AB0B1100);
		this.groupBox2.Controls.Add(this.DA8E27A1);
		this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.DA0E518A);
		this.groupBox2.Controls.Add(this.C60D3334);
		this.groupBox2.Controls.Add(this.BE8ECA98);
		this.groupBox2.Location = new System.Drawing.Point(30, 107);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(353, 524);
		this.groupBox2.TabIndex = 70;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn";
		this.AB0B1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.AB0B1100.Controls.Add(this.label4);
		this.AB0B1100.Controls.Add(this.nudCountWallTo);
		this.AB0B1100.Controls.Add(this.label5);
		this.AB0B1100.Controls.Add(this.nudCountWallFrom);
		this.AB0B1100.Location = new System.Drawing.Point(32, 44);
		this.AB0B1100.Name = "plDangBaiLenTuong";
		this.AB0B1100.Size = new System.Drawing.Size(313, 27);
		this.AB0B1100.TabIndex = 1;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(3, 3);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(84, 16);
		this.label4.TabIndex = 49;
		this.label4.Text = "Số lượng bài:";
		this.nudCountWallTo.Location = new System.Drawing.Point(187, 1);
		this.nudCountWallTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountWallTo.Name = "nudCountWallTo";
		this.nudCountWallTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountWallTo.TabIndex = 48;
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.Location = new System.Drawing.Point(166, 3);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(18, 16);
		this.label5.TabIndex = 51;
		this.label5.Text = ">";
		this.nudCountWallFrom.Location = new System.Drawing.Point(108, 1);
		this.nudCountWallFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountWallFrom.Name = "nudCountWallFrom";
		this.nudCountWallFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountWallFrom.TabIndex = 47;
		this.DA8E27A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DA8E27A1.Controls.Add(this.D437CB0C);
		this.DA8E27A1.Controls.Add(this.nudCountPageTo);
		this.DA8E27A1.Controls.Add(this.label23);
		this.DA8E27A1.Controls.Add(this.D9129787);
		this.DA8E27A1.Location = new System.Drawing.Point(32, 489);
		this.DA8E27A1.Name = "plDangBaiLenPage";
		this.DA8E27A1.Size = new System.Drawing.Size(313, 27);
		this.DA8E27A1.TabIndex = 1;
		this.D437CB0C.AutoSize = true;
		this.D437CB0C.Location = new System.Drawing.Point(3, 3);
		this.D437CB0C.Name = "label21";
		this.D437CB0C.Size = new System.Drawing.Size(95, 16);
		this.D437CB0C.TabIndex = 49;
		this.D437CB0C.Text = "Số lượng page:";
		this.nudCountPageTo.Location = new System.Drawing.Point(187, 1);
		this.nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageTo.Name = "nudCountPageTo";
		this.nudCountPageTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageTo.TabIndex = 48;
		this.label23.AutoSize = true;
		this.label23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label23.Location = new System.Drawing.Point(166, 3);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(18, 16);
		this.label23.TabIndex = 51;
		this.label23.Text = ">";
		this.D9129787.Location = new System.Drawing.Point(108, 1);
		this.D9129787.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D9129787.Name = "nudCountPageFrom";
		this.D9129787.Size = new System.Drawing.Size(56, 23);
		this.D9129787.TabIndex = 47;
		this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenNhom.Controls.Add(this.ckbKhongDangTrung);
		this.plDangBaiLenNhom.Controls.Add(this.E7A3AD0B);
		this.plDangBaiLenNhom.Controls.Add(this.F324BA83);
		this.plDangBaiLenNhom.Controls.Add(this.EE2E8CA5);
		this.plDangBaiLenNhom.Controls.Add(this.panel3);
		this.plDangBaiLenNhom.Controls.Add(this.BC0C553C);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
		this.plDangBaiLenNhom.Controls.Add(this.ckbTuongTac);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
		this.plDangBaiLenNhom.Controls.Add(this.label24);
		this.plDangBaiLenNhom.Controls.Add(this.F39A49B8);
		this.plDangBaiLenNhom.Location = new System.Drawing.Point(32, 99);
		this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		this.plDangBaiLenNhom.Size = new System.Drawing.Size(313, 364);
		this.plDangBaiLenNhom.TabIndex = 1;
		this.ckbKhongDangTrung.AutoSize = true;
		this.ckbKhongDangTrung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongDangTrung.Location = new System.Drawing.Point(6, 313);
		this.ckbKhongDangTrung.Name = "ckbKhongDangTrung";
		this.ckbKhongDangTrung.Size = new System.Drawing.Size(163, 20);
		this.ckbKhongDangTrung.TabIndex = 2;
		this.ckbKhongDangTrung.Text = "Không đăng trùng nhóm";
		this.ckbKhongDangTrung.UseVisualStyleBackColor = true;
		this.E7A3AD0B.AutoSize = true;
		this.E7A3AD0B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E7A3AD0B.Location = new System.Drawing.Point(6, 287);
		this.E7A3AD0B.Name = "ckbUuTienNhomNhieuThanhVien";
		this.E7A3AD0B.Size = new System.Drawing.Size(250, 20);
		this.E7A3AD0B.TabIndex = 1;
		this.E7A3AD0B.Text = "Ưu tiên đăng nhóm có nhiều thành viên";
		this.E7A3AD0B.UseVisualStyleBackColor = true;
		this.F324BA83.AutoSize = true;
		this.F324BA83.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F324BA83.Location = new System.Drawing.Point(209, 340);
		this.F324BA83.Name = "lblTuongTacNhom";
		this.F324BA83.Size = new System.Drawing.Size(47, 16);
		this.F324BA83.TabIndex = 183;
		this.F324BA83.TabStop = true;
		this.F324BA83.Text = "Cài đặt";
		this.F324BA83.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F324BA83_LinkClicked);
		this.EE2E8CA5.AutoSize = true;
		this.EE2E8CA5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EE2E8CA5.Location = new System.Drawing.Point(6, 261);
		this.EE2E8CA5.Name = "ckbOnlyDangNhomKhongKiemDuyet";
		this.EE2E8CA5.Size = new System.Drawing.Size(216, 20);
		this.EE2E8CA5.TabIndex = 0;
		this.EE2E8CA5.Text = "Chỉ đăng nhóm không kiểm duyệt";
		this.EE2E8CA5.UseVisualStyleBackColor = true;
		this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel3.Controls.Add(this.plTuNhap);
		this.panel3.Controls.Add(this.rbTuNhap);
		this.panel3.Controls.Add(this.rbRandom);
		this.panel3.Location = new System.Drawing.Point(6, 52);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(300, 203);
		this.panel3.TabIndex = 67;
		this.plTuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plTuNhap.Controls.Add(this.txtNhomTuNhap);
		this.plTuNhap.Controls.Add(this.ckbChiDangNhomDaThamGia);
		this.plTuNhap.Controls.Add(this.ckbXoaNhomDaDang);
		this.plTuNhap.Location = new System.Drawing.Point(22, 49);
		this.plTuNhap.Name = "plTuNhap";
		this.plTuNhap.Size = new System.Drawing.Size(273, 149);
		this.plTuNhap.TabIndex = 193;
		this.txtNhomTuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtNhomTuNhap.Location = new System.Drawing.Point(3, 3);
		this.txtNhomTuNhap.Name = "txtNhomTuNhap";
		this.txtNhomTuNhap.Size = new System.Drawing.Size(265, 97);
		this.txtNhomTuNhap.TabIndex = 34;
		this.txtNhomTuNhap.Text = "";
		this.txtNhomTuNhap.WordWrap = false;
		this.txtNhomTuNhap.TextChanged += new System.EventHandler(txtNhomTuNhap_TextChanged);
		this.ckbChiDangNhomDaThamGia.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbChiDangNhomDaThamGia.AutoSize = true;
		this.ckbChiDangNhomDaThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChiDangNhomDaThamGia.Location = new System.Drawing.Point(3, 103);
		this.ckbChiDangNhomDaThamGia.Name = "ckbChiDangNhomDaThamGia";
		this.ckbChiDangNhomDaThamGia.Size = new System.Drawing.Size(184, 20);
		this.ckbChiDangNhomDaThamGia.TabIndex = 33;
		this.ckbChiDangNhomDaThamGia.Text = "Chỉ đăng nhóm đã tham gia";
		this.ckbChiDangNhomDaThamGia.UseVisualStyleBackColor = true;
		this.ckbChiDangNhomDaThamGia.CheckedChanged += new System.EventHandler(ckbChiDangNhomDaThamGia_CheckedChanged);
		this.ckbXoaNhomDaDang.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbXoaNhomDaDang.AutoSize = true;
		this.ckbXoaNhomDaDang.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaNhomDaDang.Location = new System.Drawing.Point(3, 125);
		this.ckbXoaNhomDaDang.Name = "ckbXoaNhomDaDang";
		this.ckbXoaNhomDaDang.Size = new System.Drawing.Size(150, 20);
		this.ckbXoaNhomDaDang.TabIndex = 33;
		this.ckbXoaNhomDaDang.Text = "Xóa ID nhóm đã đăng";
		this.ckbXoaNhomDaDang.UseVisualStyleBackColor = true;
		this.rbTuNhap.AutoSize = true;
		this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuNhap.Location = new System.Drawing.Point(3, 27);
		this.rbTuNhap.Name = "rbTuNhap";
		this.rbTuNhap.Size = new System.Drawing.Size(197, 20);
		this.rbTuNhap.TabIndex = 1;
		this.rbTuNhap.Text = "Nhóm do người dùng nhập (0)";
		this.rbTuNhap.UseVisualStyleBackColor = true;
		this.rbTuNhap.CheckedChanged += new System.EventHandler(rbTuNhap_CheckedChanged);
		this.rbRandom.AutoSize = true;
		this.rbRandom.Checked = true;
		this.rbRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbRandom.Location = new System.Drawing.Point(3, 3);
		this.rbRandom.Name = "rbRandom";
		this.rbRandom.Size = new System.Drawing.Size(197, 20);
		this.rbRandom.TabIndex = 0;
		this.rbRandom.TabStop = true;
		this.rbRandom.Text = "Ngẫu nhiên nhóm đã tham gia";
		this.rbRandom.UseVisualStyleBackColor = true;
		this.BC0C553C.AutoSize = true;
		this.BC0C553C.Location = new System.Drawing.Point(3, 31);
		this.BC0C553C.Name = "label12";
		this.BC0C553C.Size = new System.Drawing.Size(100, 16);
		this.BC0C553C.TabIndex = 66;
		this.BC0C553C.Text = "Tùy chọn nhóm:";
		this.nudCountGroupTo.Location = new System.Drawing.Point(187, 4);
		this.nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupTo.Name = "nudCountGroupTo";
		this.nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupTo.TabIndex = 53;
		this.ckbTuongTac.AutoSize = true;
		this.ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTac.Location = new System.Drawing.Point(6, 339);
		this.ckbTuongTac.Name = "ckbTuongTac";
		this.ckbTuongTac.Size = new System.Drawing.Size(206, 20);
		this.ckbTuongTac.TabIndex = 57;
		this.ckbTuongTac.Text = "Tương tác nhóm trước khi đăng";
		this.ckbTuongTac.UseVisualStyleBackColor = true;
		this.ckbTuongTac.CheckedChanged += new System.EventHandler(ckbTuongTac_CheckedChanged);
		this.nudCountGroupFrom.Location = new System.Drawing.Point(108, 4);
		this.nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupFrom.Name = "nudCountGroupFrom";
		this.nudCountGroupFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupFrom.TabIndex = 52;
		this.label24.AutoSize = true;
		this.label24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label24.Location = new System.Drawing.Point(166, 6);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(18, 16);
		this.label24.TabIndex = 56;
		this.label24.Text = ">";
		this.F39A49B8.AutoSize = true;
		this.F39A49B8.Location = new System.Drawing.Point(3, 6);
		this.F39A49B8.Name = "label26";
		this.F39A49B8.Size = new System.Drawing.Size(99, 16);
		this.F39A49B8.TabIndex = 54;
		this.F39A49B8.Text = "Số lượng nhóm:";
		this.DA0E518A.AutoSize = true;
		this.DA0E518A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DA0E518A.Location = new System.Drawing.Point(9, 467);
		this.DA0E518A.Name = "ckbDangBaiLenPage";
		this.DA0E518A.Size = new System.Drawing.Size(130, 20);
		this.DA0E518A.TabIndex = 0;
		this.DA0E518A.Text = "Đăng bài lên page";
		this.DA0E518A.UseVisualStyleBackColor = true;
		this.DA0E518A.CheckedChanged += new System.EventHandler(DA0E518A_CheckedChanged);
		this.C60D3334.AutoSize = true;
		this.C60D3334.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C60D3334.Location = new System.Drawing.Point(9, 75);
		this.C60D3334.Name = "ckbDangBaiLenNhom";
		this.C60D3334.Size = new System.Drawing.Size(134, 20);
		this.C60D3334.TabIndex = 0;
		this.C60D3334.Text = "Đăng bài lên nhóm";
		this.C60D3334.UseVisualStyleBackColor = true;
		this.C60D3334.CheckedChanged += new System.EventHandler(C60D3334_CheckedChanged);
		this.BE8ECA98.AutoSize = true;
		this.BE8ECA98.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BE8ECA98.Location = new System.Drawing.Point(9, 22);
		this.BE8ECA98.Name = "ckbDangBaiLenTuong";
		this.BE8ECA98.Size = new System.Drawing.Size(135, 20);
		this.BE8ECA98.TabIndex = 0;
		this.BE8ECA98.Text = "Đăng bài lên tường";
		this.BE8ECA98.UseVisualStyleBackColor = true;
		this.BE8ECA98.CheckedChanged += new System.EventHandler(BE8ECA98_CheckedChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(260, 78);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 58;
		this.B9136EBB.Location = new System.Drawing.Point(163, 78);
		this.B9136EBB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.B9136EBB.Name = "nudDelayFrom";
		this.B9136EBB.Size = new System.Drawing.Size(56, 23);
		this.B9136EBB.TabIndex = 57;
		this.label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label20.Location = new System.Drawing.Point(225, 80);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(29, 16);
		this.label20.TabIndex = 61;
		this.label20.Text = ">";
		this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(27, 80);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(136, 16);
		this.label15.TabIndex = 59;
		this.label15.Text = "Khoảng cách đăng (s):";
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(421, 647);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 3;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.DB090F20.Location = new System.Drawing.Point(163, 49);
		this.DB090F20.Name = "txtTenHanhDong";
		this.DB090F20.Size = new System.Drawing.Size(193, 23);
		this.DB090F20.TabIndex = 0;
		this.E6B181A9.AutoSize = true;
		this.E6B181A9.Location = new System.Drawing.Point(27, 52);
		this.E6B181A9.Name = "label1";
		this.E6B181A9.Size = new System.Drawing.Size(98, 16);
		this.E6B181A9.TabIndex = 31;
		this.E6B181A9.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.BF0A4412.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BF0A4412.BackColor = System.Drawing.Color.Maroon;
		this.BF0A4412.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BF0A4412.FlatAppearance.BorderSize = 0;
		this.BF0A4412.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.BF0A4412.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BF0A4412.ForeColor = System.Drawing.Color.White;
		this.BF0A4412.Location = new System.Drawing.Point(520, 647);
		this.BF0A4412.Name = "btnCancel";
		this.BF0A4412.Size = new System.Drawing.Size(92, 29);
		this.BF0A4412.TabIndex = 4;
		this.BF0A4412.Text = "Đóng";
		this.BF0A4412.UseVisualStyleBackColor = false;
		this.BF0A4412.Click += new System.EventHandler(F82CB183);
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
		this.bunifuCards1.Size = new System.Drawing.Size(1034, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1037, 693);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangBai";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BDB67D95);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.F9A61B27).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.C2A04BB7.ResumeLayout(false);
		this.C2A04BB7.PerformLayout();
		this.AF8A2DB0.ResumeLayout(false);
		this.AF8A2DB0.PerformLayout();
		this.BD343911.ResumeLayout(false);
		this.BD343911.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		this.plNotUseAvatar.ResumeLayout(false);
		this.plNotUseAvatar.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.D3B2EE2E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.AB0B1100.ResumeLayout(false);
		this.AB0B1100.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountWallTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountWallFrom).EndInit();
		this.DA8E27A1.ResumeLayout(false);
		this.DA8E27A1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D9129787).EndInit();
		this.plDangBaiLenNhom.ResumeLayout(false);
		this.plDangBaiLenNhom.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.plTuNhap.ResumeLayout(false);
		this.plTuNhap.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B9136EBB).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
