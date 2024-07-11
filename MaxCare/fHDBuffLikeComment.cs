using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffLikeComment : Form
{
	private JSON_Settings gclass8_0;

	private string DA889AA0;

	private string string_0;

	private string string_1;

	private int E299861B;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl B9930C2B;

	private BunifuDragControl B099678F;

	private Panel panel1;

	private NumericUpDown C12BCA34;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label C0313DA4;

	private Label F1056310;

	private Label label1;

	private Button btnCancel;

	private Button CFB6A78E;

	private BunifuCards B5338B2F;

	private Panel pnlHeader;

	private Button F604EE04;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox CD0322A7;

	private Label label2;

	private NumericUpDown FC1BD430;

	private NumericUpDown nudTimeFrom;

	private Label label9;

	private Label label3;

	private Panel plCommentText;

	private RichTextBox D0B5C21E;

	private Label lblComment;

	private Panel plAnh;

	private TextBox txtAnh;

	private RichTextBox txtIdPost;

	private CheckBox C40BA539;

	private CheckBox ckbComment;

	private Label B5AA411B;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private NumericUpDown nudSoLuongUidTo;

	private Label label66;

	private RadioButton rbCommentNgauNhien;

	private RadioButton rbCommentTheoThuTu;

	private Label label13;

	private Button btnDown;

	private Button A51B2F81;

	private Panel panel3;

	private CheckBox ckbAutoDeleteComment;

	private Panel B9A5D6BA;

	private NumericUpDown nudSoLuongTagTo;

	private Label label16;

	private NumericUpDown nudSoLuongTagFrom;

	private Label label14;

	private CheckBox ckbTag;

	private CheckBox ckbChiTagTenViet;

	private ComboBox cbbTuyChonNoiDung;

	private Button btnHuongDanNhapNoiDung;

	private Label label8;

	private CheckBox ckbTuDongXoa;

	private Panel panel2;

	private TabPage tabPage1;

	private TabPage D185E018;

	private TabControl tabTuyChonBaiViet;

	private ComboBox cbbTuyChonBaiViet;

	private Label label4;

	private Label label6;

	private RichTextBox C803E329;

	private Panel DF1A3F15;

	private CheckBox ckbAngry;

	private CheckBox D4B7ED28;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox ckbLove;

	private CheckBox DEB6D203;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton BB3806AD;

	private Label label26;

	private CheckBox ckbInteract;

	private CheckBox A427DAAA;

	private Panel D405C7AB;

	private ComboBox cbbTuyChonNoiDungShare;

	private Button button2;

	private Label DB21928C;

	private CheckBox ckbAutoDeleteContentShare;

	private Panel panel6;

	private RadioButton C32AE8BD;

	private RadioButton B2927BA2;

	private Label D3044790;

	private RichTextBox C1BF669E;

	private Label lblContentShare;

	public fHDBuffLikeComment(string BC07DA33, int B7AFD81B = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		DA889AA0 = BC07DA33;
		string_1 = string_2;
		E299861B = B7AFD81B;
		string dCAD78A = base.Name.Substring(1);
		string a407F = "Tương ta\u0301c ba\u0300i viê\u0301t";
		InteractSQL.B58C1618(base.Name.Substring(1), a407F);
		string text = "";
		switch (B7AFD81B)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", dCAD78A);
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			CFB6A78E.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
		list_0 = new List<CheckBox> { DEB6D203, ckbLove, ckbCare, ckbHaha, ckbWow, D4B7ED28, ckbAngry };
	}

	private void CD00BEBD_Load(object sender, EventArgs e)
	{
		method_0();
		BE939692();
		method_1();
		try
		{
			nudSoLuongUidFrom.Value = gclass8_0.GetValueInt("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass8_0.GetValueInt("nudSoLuongUidTo", 1);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			C12BCA34.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			cbbTuyChonBaiViet.SelectedIndex = gclass8_0.GetValueInt("cbbTuyChonBaiViet");
			txtIdPost.Text = gclass8_0.GetValue("txtIdPost");
			ckbTuDongXoa.Checked = gclass8_0.GetValueBool("ckbTuDongXoa");
			C803E329.Text = gclass8_0.GetValue("txtTuKhoa");
			nudTimeFrom.Value = gclass8_0.GetValueInt("nudTimeFrom", 3);
			FC1BD430.Value = gclass8_0.GetValueInt("nudTimeTo", 5);
			ckbInteract.Checked = gclass8_0.GetValueBool("ckbInteract");
			string text = gclass8_0.GetValue("typeReaction", "Like");
			if (Common.IsNumber(text.Replace("|", "")))
			{
				List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
				for (int i = 0; i < list.Count; i++)
				{
					text = text.Replace(i.ToString(), list[i]);
				}
			}
			List<string> list2 = text.Split('|').ToList();
			for (int j = 0; j < list2.Count; j++)
			{
				foreach (CheckBox item in list_0)
				{
					if (item.Name.Substring(3) == list2[j])
					{
						item.Checked = true;
					}
				}
			}
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			D0B5C21E.Text = gclass8_0.GetValue("txtComment");
			cbbTuyChonNoiDung.SelectedIndex = gclass8_0.GetValueInt("typeNganCach");
			ckbAutoDeleteComment.Checked = gclass8_0.GetValueBool("ckbAutoDeleteComment");
			A427DAAA.Checked = gclass8_0.GetValueBool("ckbRunAPI");
			ckbTag.Checked = gclass8_0.GetValueBool("ckbTag");
			nudSoLuongTagFrom.Value = gclass8_0.GetValueInt("nudSoLuongTagFrom", 3);
			nudSoLuongTagTo.Value = gclass8_0.GetValueInt("nudSoLuongTagTo", 5);
			ckbChiTagTenViet.Checked = gclass8_0.GetValueBool("ckbChiTagTenViet");
			C40BA539.Checked = gclass8_0.GetValueBool("ckbSendAnh");
			txtAnh.Text = gclass8_0.GetValue("txtAnh");
			if (gclass8_0.GetValueInt("typeComment") == 1)
			{
				rbCommentNgauNhien.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
			}
			CD0322A7.Checked = gclass8_0.GetValueBool("ckbShareWall");
			C1BF669E.Text = gclass8_0.GetValue("txtContentShare");
			cbbTuyChonNoiDungShare.SelectedIndex = gclass8_0.GetValueInt("cbbTuyChonNoiDungShare");
			ckbAutoDeleteContentShare.Checked = gclass8_0.GetValueBool("ckbAutoDeleteContentShare");
		}
		catch
		{
		}
		method_2();
	}

	private void method_0()
	{
		List<string> e6A5AC = new List<string> { "Ba\u0300i viê\u0301t chi\u0309 đi\u0323nh", "Ba\u0300i viê\u0301t theo tư\u0300 kho\u0301a" };
		Common.F714B10E(cbbTuyChonBaiViet, e6A5AC);
	}

	private void BE939692()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(cbbTuyChonNoiDung, e6A5AC);
	}

	private void method_1()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(cbbTuyChonNoiDungShare, e6A5AC);
	}

	private void F604EE04_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FA82CFA2(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.GetJson("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", C12BCA34.Value);
		gClass.GetJson("cbbTuyChonBaiViet", cbbTuyChonBaiViet.SelectedIndex);
		gClass.GetJson("txtIdPost", txtIdPost.Text.Trim());
		gClass.GetJson("ckbTuDongXoa", ckbTuDongXoa.Checked);
		gClass.GetJson("txtTuKhoa", C803E329.Text.Trim());
		gClass.GetJson("nudTimeFrom", nudTimeFrom.Value);
		gClass.GetJson("nudTimeTo", FC1BD430.Value);
		gClass.GetJson("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + list_0[i].Name.Substring(3) + "|";
			}
		}
		gClass.GetJson("typeReaction", text2.TrimEnd('|'));
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("txtComment", D0B5C21E.Text.Trim());
		gClass.GetJson("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		gClass.GetJson("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		gClass.GetJson("ckbRunAPI", A427DAAA.Checked);
		gClass.GetJson("ckbTag", ckbTag.Checked);
		gClass.GetJson("nudSoLuongTagFrom", nudSoLuongTagFrom.Value);
		gClass.GetJson("nudSoLuongTagTo", nudSoLuongTagTo.Value);
		gClass.GetJson("ckbChiTagTenViet", ckbChiTagTenViet.Checked);
		gClass.GetJson("ckbSendAnh", C40BA539.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (rbCommentNgauNhien.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeComment", num);
		gClass.GetJson("ckbShareWall", CD0322A7.Checked);
		gClass.GetJson("txtContentShare", C1BF669E.Text.Trim());
		gClass.GetJson("cbbTuyChonNoiDungShare", cbbTuyChonNoiDungShare.SelectedIndex);
		gClass.GetJson("ckbAutoDeleteContentShare", ckbAutoDeleteContentShare.Checked);
		string string_ = gClass.D9A09B34();
		if (E299861B == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(DA889AA0, text, string_0, string_))
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

	private void E4A29CA8(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void DFA0A236(object sender, EventArgs e)
	{
		Common.F9202C12(D0B5C21E, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_2()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbTag_CheckedChanged(null, null);
		DFA0A236(null, null);
		cbbTuyChonBaiViet_SelectedIndexChanged(null, null);
		A427DAAA_CheckedChanged(null, null);
		DD234D22(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		DF1A3F15.Enabled = ckbInteract.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbComment.Checked;
	}

	private void D412100E(object sender, EventArgs e)
	{
		Common.F9202C12(txtIdPost, label2);
	}

	private void C40BA539_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = C40BA539.Checked;
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void A019162D(object sender, EventArgs e)
	{
	}

	private void D28475B5(object sender, EventArgs e)
	{
	}

	private void rbCommentTheoThuTu_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void label13_Click(object sender, EventArgs e)
	{
	}

	private void rbCommentNgauNhien_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void BC334892(object sender, EventArgs e)
	{
		plCommentText.Height = 275;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 358;
	}

	private void ckbTag_CheckedChanged(object sender, EventArgs e)
	{
		B9A5D6BA.Enabled = ckbTag.Checked;
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		Common.F9202C12(D0B5C21E, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		D0B5C21E.Focus();
	}

	private void cbbTuyChonBaiViet_SelectedIndexChanged(object sender, EventArgs e)
	{
		tabTuyChonBaiViet.SelectedIndex = cbbTuyChonBaiViet.SelectedIndex;
	}

	private void A427DAAA_CheckedChanged(object sender, EventArgs e)
	{
		ckbInteract.Enabled = !A427DAAA.Checked;
		CD0322A7.Enabled = !A427DAAA.Checked;
		C40BA539.Enabled = !A427DAAA.Checked;
		if (A427DAAA.Checked)
		{
			ckbInteract.Checked = false;
			CD0322A7.Checked = false;
			C40BA539.Checked = false;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDungShare.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		C1BF669E.Focus();
	}

	private void C1BF669E_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(C1BF669E, lblContentShare, cbbTuyChonNoiDungShare.SelectedIndex);
	}

	private void DD234D22(object sender, EventArgs e)
	{
		D405C7AB.Enabled = CD0322A7.Checked;
	}

	protected override void Dispose(bool F225F080)
	{
		if (F225F080 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F225F080);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffLikeComment));
		this.B9930C2B = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.B099678F = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.F604EE04 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.DF1A3F15 = new System.Windows.Forms.Panel();
		this.ckbAngry = new System.Windows.Forms.CheckBox();
		this.D4B7ED28 = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbCare = new System.Windows.Forms.CheckBox();
		this.ckbLove = new System.Windows.Forms.CheckBox();
		this.DEB6D203 = new System.Windows.Forms.CheckBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.BB3806AD = new System.Windows.Forms.RadioButton();
		this.label26 = new System.Windows.Forms.Label();
		this.D405C7AB = new System.Windows.Forms.Panel();
		this.cbbTuyChonNoiDungShare = new System.Windows.Forms.ComboBox();
		this.button2 = new System.Windows.Forms.Button();
		this.DB21928C = new System.Windows.Forms.Label();
		this.ckbAutoDeleteContentShare = new System.Windows.Forms.CheckBox();
		this.panel6 = new System.Windows.Forms.Panel();
		this.C32AE8BD = new System.Windows.Forms.RadioButton();
		this.B2927BA2 = new System.Windows.Forms.RadioButton();
		this.D3044790 = new System.Windows.Forms.Label();
		this.C1BF669E = new System.Windows.Forms.RichTextBox();
		this.lblContentShare = new System.Windows.Forms.Label();
		this.plCommentText = new System.Windows.Forms.Panel();
		this.cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		this.btnHuongDanNhapNoiDung = new System.Windows.Forms.Button();
		this.B9A5D6BA = new System.Windows.Forms.Panel();
		this.ckbChiTagTenViet = new System.Windows.Forms.CheckBox();
		this.nudSoLuongTagTo = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.nudSoLuongTagFrom = new System.Windows.Forms.NumericUpDown();
		this.label14 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.ckbTag = new System.Windows.Forms.CheckBox();
		this.A427DAAA = new System.Windows.Forms.CheckBox();
		this.ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		this.panel3 = new System.Windows.Forms.Panel();
		this.rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		this.rbCommentNgauNhien = new System.Windows.Forms.RadioButton();
		this.btnDown = new System.Windows.Forms.Button();
		this.A51B2F81 = new System.Windows.Forms.Button();
		this.label13 = new System.Windows.Forms.Label();
		this.D0B5C21E = new System.Windows.Forms.RichTextBox();
		this.lblComment = new System.Windows.Forms.Label();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.cbbTuyChonBaiViet = new System.Windows.Forms.ComboBox();
		this.C40BA539 = new System.Windows.Forms.CheckBox();
		this.panel2 = new System.Windows.Forms.Panel();
		this.tabTuyChonBaiViet = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.label2 = new System.Windows.Forms.Label();
		this.txtIdPost = new System.Windows.Forms.RichTextBox();
		this.ckbTuDongXoa = new System.Windows.Forms.CheckBox();
		this.D185E018 = new System.Windows.Forms.TabPage();
		this.label6 = new System.Windows.Forms.Label();
		this.C803E329 = new System.Windows.Forms.RichTextBox();
		this.plAnh = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.B5AA411B = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.CD0322A7 = new System.Windows.Forms.CheckBox();
		this.FC1BD430 = new System.Windows.Forms.NumericUpDown();
		this.C12BCA34 = new System.Windows.Forms.NumericUpDown();
		this.nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.C0313DA4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.F1056310 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.CFB6A78E = new System.Windows.Forms.Button();
		this.B5338B2F = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.DF1A3F15.SuspendLayout();
		this.panel7.SuspendLayout();
		this.D405C7AB.SuspendLayout();
		this.panel6.SuspendLayout();
		this.plCommentText.SuspendLayout();
		this.B9A5D6BA.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagFrom).BeginInit();
		this.panel3.SuspendLayout();
		this.panel2.SuspendLayout();
		this.tabTuyChonBaiViet.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.D185E018.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FC1BD430).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C12BCA34).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.B5338B2F.SuspendLayout();
		base.SuspendLayout();
		this.B9930C2B.Fixed = true;
		this.B9930C2B.Horizontal = true;
		this.B9930C2B.TargetControl = this.bunifuCustomLabel1;
		this.B9930C2B.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1000, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Tương ta\u0301c ba\u0300i viê\u0301t";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B099678F.Fixed = true;
		this.B099678F.Horizontal = true;
		this.B099678F.TargetControl = this.pnlHeader;
		this.B099678F.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.F604EE04);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(1000, 31);
		this.pnlHeader.TabIndex = 9;
		this.F604EE04.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.F604EE04.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F604EE04.FlatAppearance.BorderSize = 0;
		this.F604EE04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F604EE04.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F604EE04.ForeColor = System.Drawing.Color.White;
		this.F604EE04.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.F604EE04.Location = new System.Drawing.Point(969, 1);
		this.F604EE04.Name = "button1";
		this.F604EE04.Size = new System.Drawing.Size(30, 30);
		this.F604EE04.TabIndex = 77;
		this.F604EE04.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.F604EE04.UseVisualStyleBackColor = true;
		this.F604EE04.Click += new System.EventHandler(F604EE04_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(A019162D);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.DF1A3F15);
		this.panel1.Controls.Add(this.D405C7AB);
		this.panel1.Controls.Add(this.plCommentText);
		this.panel1.Controls.Add(this.ckbInteract);
		this.panel1.Controls.Add(this.cbbTuyChonBaiViet);
		this.panel1.Controls.Add(this.C40BA539);
		this.panel1.Controls.Add(this.panel2);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label49);
		this.panel1.Controls.Add(this.nudSoLuongUidFrom);
		this.panel1.Controls.Add(this.nudSoLuongUidTo);
		this.panel1.Controls.Add(this.label66);
		this.panel1.Controls.Add(this.ckbComment);
		this.panel1.Controls.Add(this.CD0322A7);
		this.panel1.Controls.Add(this.FC1BD430);
		this.panel1.Controls.Add(this.C12BCA34);
		this.panel1.Controls.Add(this.nudTimeFrom);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.C0313DA4);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.F1056310);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.CFB6A78E);
		this.panel1.Controls.Add(this.B5338B2F);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1003, 497);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(panel1_Click);
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(E4A29CA8);
		this.DF1A3F15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DF1A3F15.Controls.Add(this.ckbAngry);
		this.DF1A3F15.Controls.Add(this.D4B7ED28);
		this.DF1A3F15.Controls.Add(this.ckbWow);
		this.DF1A3F15.Controls.Add(this.ckbHaha);
		this.DF1A3F15.Controls.Add(this.ckbCare);
		this.DF1A3F15.Controls.Add(this.ckbLove);
		this.DF1A3F15.Controls.Add(this.DEB6D203);
		this.DF1A3F15.Controls.Add(this.panel7);
		this.DF1A3F15.Controls.Add(this.label26);
		this.DF1A3F15.Location = new System.Drawing.Point(317, 99);
		this.DF1A3F15.Name = "plInteract";
		this.DF1A3F15.Size = new System.Drawing.Size(312, 33);
		this.DF1A3F15.TabIndex = 182;
		this.ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAngry.Image = Resources.Bitmap_7;
		this.ckbAngry.Location = new System.Drawing.Point(266, 1);
		this.ckbAngry.Name = "ckbAngry";
		this.ckbAngry.Size = new System.Drawing.Size(40, 30);
		this.ckbAngry.TabIndex = 179;
		this.ckbAngry.Tag = "Angry";
		this.ckbAngry.UseVisualStyleBackColor = true;
		this.D4B7ED28.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D4B7ED28.Image = Resources.Bitmap_167;
		this.D4B7ED28.Location = new System.Drawing.Point(222, 1);
		this.D4B7ED28.Name = "ckbSad";
		this.D4B7ED28.Size = new System.Drawing.Size(40, 30);
		this.D4B7ED28.TabIndex = 178;
		this.D4B7ED28.Tag = "Sad";
		this.D4B7ED28.UseVisualStyleBackColor = true;
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
		this.DEB6D203.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DEB6D203.Image = Resources.B41E983E;
		this.DEB6D203.Location = new System.Drawing.Point(2, 1);
		this.DEB6D203.Name = "ckbLike";
		this.DEB6D203.Size = new System.Drawing.Size(40, 30);
		this.DEB6D203.TabIndex = 173;
		this.DEB6D203.Tag = "Like";
		this.DEB6D203.UseVisualStyleBackColor = true;
		this.panel7.Controls.Add(this.radioButton3);
		this.panel7.Controls.Add(this.BB3806AD);
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
		this.BB3806AD.AutoSize = true;
		this.BB3806AD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB3806AD.Location = new System.Drawing.Point(3, 23);
		this.BB3806AD.Name = "radioButton4";
		this.BB3806AD.Size = new System.Drawing.Size(200, 20);
		this.BB3806AD.TabIndex = 3;
		this.BB3806AD.Text = "Comment ngẫu nhiên nội dung";
		this.BB3806AD.UseVisualStyleBackColor = true;
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(4, 302);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(64, 16);
		this.label26.TabIndex = 2;
		this.label26.Text = "Tùy chọn:";
		this.D405C7AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.D405C7AB.Controls.Add(this.cbbTuyChonNoiDungShare);
		this.D405C7AB.Controls.Add(this.button2);
		this.D405C7AB.Controls.Add(this.DB21928C);
		this.D405C7AB.Controls.Add(this.ckbAutoDeleteContentShare);
		this.D405C7AB.Controls.Add(this.panel6);
		this.D405C7AB.Controls.Add(this.D3044790);
		this.D405C7AB.Controls.Add(this.C1BF669E);
		this.D405C7AB.Controls.Add(this.lblContentShare);
		this.D405C7AB.Location = new System.Drawing.Point(317, 159);
		this.D405C7AB.Name = "plContentShare";
		this.D405C7AB.Size = new System.Drawing.Size(312, 275);
		this.D405C7AB.TabIndex = 164;
		this.cbbTuyChonNoiDungShare.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.cbbTuyChonNoiDungShare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTuyChonNoiDungShare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTuyChonNoiDungShare.FormattingEnabled = true;
		this.cbbTuyChonNoiDungShare.Location = new System.Drawing.Point(69, 225);
		this.cbbTuyChonNoiDungShare.Name = "cbbTuyChonNoiDungShare";
		this.cbbTuyChonNoiDungShare.Size = new System.Drawing.Size(203, 24);
		this.cbbTuyChonNoiDungShare.TabIndex = 180;
		this.cbbTuyChonNoiDungShare.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(278, 224);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(26, 26);
		this.button2.TabIndex = 179;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.DB21928C.AutoSize = true;
		this.DB21928C.Location = new System.Drawing.Point(3, 228);
		this.DB21928C.Name = "label15";
		this.DB21928C.Size = new System.Drawing.Size(64, 16);
		this.DB21928C.TabIndex = 178;
		this.DB21928C.Text = "Tùy chọn:";
		this.ckbAutoDeleteContentShare.AutoSize = true;
		this.ckbAutoDeleteContentShare.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoDeleteContentShare.Location = new System.Drawing.Point(6, 252);
		this.ckbAutoDeleteContentShare.Name = "ckbAutoDeleteContentShare";
		this.ckbAutoDeleteContentShare.Size = new System.Drawing.Size(169, 20);
		this.ckbAutoDeleteContentShare.TabIndex = 176;
		this.ckbAutoDeleteContentShare.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		this.ckbAutoDeleteContentShare.UseVisualStyleBackColor = true;
		this.panel6.Controls.Add(this.C32AE8BD);
		this.panel6.Controls.Add(this.B2927BA2);
		this.panel6.Location = new System.Drawing.Point(67, 383);
		this.panel6.Name = "panel6";
		this.panel6.Size = new System.Drawing.Size(200, 43);
		this.panel6.TabIndex = 43;
		this.C32AE8BD.AutoSize = true;
		this.C32AE8BD.Checked = true;
		this.C32AE8BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C32AE8BD.Location = new System.Drawing.Point(3, 2);
		this.C32AE8BD.Name = "radioButton1";
		this.C32AE8BD.Size = new System.Drawing.Size(201, 20);
		this.C32AE8BD.TabIndex = 3;
		this.C32AE8BD.TabStop = true;
		this.C32AE8BD.Text = "Comment theo thứ tự nội dung";
		this.C32AE8BD.UseVisualStyleBackColor = true;
		this.C32AE8BD.CheckedChanged += new System.EventHandler(rbCommentTheoThuTu_CheckedChanged);
		this.B2927BA2.AutoSize = true;
		this.B2927BA2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B2927BA2.Location = new System.Drawing.Point(3, 23);
		this.B2927BA2.Name = "radioButton2";
		this.B2927BA2.Size = new System.Drawing.Size(200, 20);
		this.B2927BA2.TabIndex = 3;
		this.B2927BA2.Text = "Comment ngẫu nhiên nội dung";
		this.B2927BA2.UseVisualStyleBackColor = true;
		this.B2927BA2.CheckedChanged += new System.EventHandler(rbCommentNgauNhien_CheckedChanged);
		this.D3044790.AutoSize = true;
		this.D3044790.Location = new System.Drawing.Point(4, 385);
		this.D3044790.Name = "label17";
		this.D3044790.Size = new System.Drawing.Size(64, 16);
		this.D3044790.TabIndex = 2;
		this.D3044790.Text = "Tùy chọn:";
		this.D3044790.Click += new System.EventHandler(label13_Click);
		this.C1BF669E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C1BF669E.Location = new System.Drawing.Point(6, 25);
		this.C1BF669E.Name = "txtContentShare";
		this.C1BF669E.Size = new System.Drawing.Size(298, 194);
		this.C1BF669E.TabIndex = 1;
		this.C1BF669E.Text = "";
		this.C1BF669E.WordWrap = false;
		this.C1BF669E.TextChanged += new System.EventHandler(C1BF669E_TextChanged);
		this.lblContentShare.AutoSize = true;
		this.lblContentShare.Location = new System.Drawing.Point(2, 5);
		this.lblContentShare.Name = "lblContentShare";
		this.lblContentShare.Size = new System.Drawing.Size(119, 16);
		this.lblContentShare.TabIndex = 0;
		this.lblContentShare.Text = "Nội dung share (0):";
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.cbbTuyChonNoiDung);
		this.plCommentText.Controls.Add(this.btnHuongDanNhapNoiDung);
		this.plCommentText.Controls.Add(this.B9A5D6BA);
		this.plCommentText.Controls.Add(this.label8);
		this.plCommentText.Controls.Add(this.ckbTag);
		this.plCommentText.Controls.Add(this.A427DAAA);
		this.plCommentText.Controls.Add(this.ckbAutoDeleteComment);
		this.plCommentText.Controls.Add(this.panel3);
		this.plCommentText.Controls.Add(this.btnDown);
		this.plCommentText.Controls.Add(this.A51B2F81);
		this.plCommentText.Controls.Add(this.label13);
		this.plCommentText.Controls.Add(this.D0B5C21E);
		this.plCommentText.Controls.Add(this.lblComment);
		this.plCommentText.Location = new System.Drawing.Point(661, 99);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(311, 275);
		this.plCommentText.TabIndex = 164;
		this.cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTuyChonNoiDung.FormattingEnabled = true;
		this.cbbTuyChonNoiDung.Location = new System.Drawing.Point(69, 225);
		this.cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		this.cbbTuyChonNoiDung.Size = new System.Drawing.Size(202, 24);
		this.cbbTuyChonNoiDung.TabIndex = 180;
		this.cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		this.btnHuongDanNhapNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnHuongDanNhapNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnHuongDanNhapNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnHuongDanNhapNoiDung.Location = new System.Drawing.Point(277, 224);
		this.btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		this.btnHuongDanNhapNoiDung.Size = new System.Drawing.Size(26, 26);
		this.btnHuongDanNhapNoiDung.TabIndex = 179;
		this.btnHuongDanNhapNoiDung.Text = "?";
		this.btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		this.btnHuongDanNhapNoiDung.Click += new System.EventHandler(btnHuongDanNhapNoiDung_Click);
		this.B9A5D6BA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B9A5D6BA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.B9A5D6BA.Controls.Add(this.ckbChiTagTenViet);
		this.B9A5D6BA.Controls.Add(this.nudSoLuongTagTo);
		this.B9A5D6BA.Controls.Add(this.label16);
		this.B9A5D6BA.Controls.Add(this.nudSoLuongTagFrom);
		this.B9A5D6BA.Controls.Add(this.label14);
		this.B9A5D6BA.Location = new System.Drawing.Point(25, 298);
		this.B9A5D6BA.Name = "plTag";
		this.B9A5D6BA.Size = new System.Drawing.Size(275, 54);
		this.B9A5D6BA.TabIndex = 167;
		this.ckbChiTagTenViet.AutoSize = true;
		this.ckbChiTagTenViet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChiTagTenViet.Location = new System.Drawing.Point(6, 31);
		this.ckbChiTagTenViet.Name = "ckbChiTagTenViet";
		this.ckbChiTagTenViet.Size = new System.Drawing.Size(112, 20);
		this.ckbChiTagTenViet.TabIndex = 168;
		this.ckbChiTagTenViet.Text = "Chỉ tag tên việt";
		this.ckbChiTagTenViet.UseVisualStyleBackColor = true;
		this.nudSoLuongTagTo.Location = new System.Drawing.Point(156, 4);
		this.nudSoLuongTagTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTagTo.Name = "nudSoLuongTagTo";
		this.nudSoLuongTagTo.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTagTo.TabIndex = 174;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 6);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(63, 16);
		this.label16.TabIndex = 175;
		this.label16.Text = "Số lượng:";
		this.nudSoLuongTagFrom.Location = new System.Drawing.Point(70, 4);
		this.nudSoLuongTagFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTagFrom.Name = "nudSoLuongTagFrom";
		this.nudSoLuongTagFrom.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTagFrom.TabIndex = 173;
		this.label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label14.Location = new System.Drawing.Point(125, 6);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 177;
		this.label14.Text = ">";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(3, 228);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(64, 16);
		this.label8.TabIndex = 178;
		this.label8.Text = "Tùy chọn:";
		this.ckbTag.AutoSize = true;
		this.ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTag.Location = new System.Drawing.Point(6, 276);
		this.ckbTag.Name = "ckbTag";
		this.ckbTag.Size = new System.Drawing.Size(91, 20);
		this.ckbTag.TabIndex = 166;
		this.ckbTag.Text = "Tag bạn bè";
		this.ckbTag.UseVisualStyleBackColor = true;
		this.ckbTag.CheckedChanged += new System.EventHandler(ckbTag_CheckedChanged);
		this.A427DAAA.AutoSize = true;
		this.A427DAAA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A427DAAA.Location = new System.Drawing.Point(238, 252);
		this.A427DAAA.Name = "ckbRunAPI";
		this.A427DAAA.Size = new System.Drawing.Size(71, 20);
		this.A427DAAA.TabIndex = 176;
		this.A427DAAA.Text = "Run API";
		this.A427DAAA.UseVisualStyleBackColor = true;
		this.A427DAAA.Visible = false;
		this.A427DAAA.CheckedChanged += new System.EventHandler(A427DAAA_CheckedChanged);
		this.ckbAutoDeleteComment.AutoSize = true;
		this.ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoDeleteComment.Location = new System.Drawing.Point(6, 252);
		this.ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		this.ckbAutoDeleteComment.Size = new System.Drawing.Size(169, 20);
		this.ckbAutoDeleteComment.TabIndex = 176;
		this.ckbAutoDeleteComment.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		this.ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		this.panel3.Controls.Add(this.rbCommentTheoThuTu);
		this.panel3.Controls.Add(this.rbCommentNgauNhien);
		this.panel3.Location = new System.Drawing.Point(67, 383);
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
		this.rbCommentNgauNhien.AutoSize = true;
		this.rbCommentNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCommentNgauNhien.Location = new System.Drawing.Point(3, 23);
		this.rbCommentNgauNhien.Name = "rbCommentNgauNhien";
		this.rbCommentNgauNhien.Size = new System.Drawing.Size(200, 20);
		this.rbCommentNgauNhien.TabIndex = 3;
		this.rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
		this.rbCommentNgauNhien.UseVisualStyleBackColor = true;
		this.rbCommentNgauNhien.CheckedChanged += new System.EventHandler(rbCommentNgauNhien_CheckedChanged);
		this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnDown.BackgroundImage = Resources.Bitmap_83;
		this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.Location = new System.Drawing.Point(254, -1);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new System.Drawing.Size(25, 25);
		this.btnDown.TabIndex = 40;
		this.btnDown.Click += new System.EventHandler(btnDown_Click);
		this.A51B2F81.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.A51B2F81.BackgroundImage = Resources.E536C319;
		this.A51B2F81.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A51B2F81.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.A51B2F81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A51B2F81.Location = new System.Drawing.Point(285, -1);
		this.A51B2F81.Name = "btnUp";
		this.A51B2F81.Size = new System.Drawing.Size(25, 25);
		this.A51B2F81.TabIndex = 41;
		this.A51B2F81.Click += new System.EventHandler(BC334892);
		this.label13.AutoSize = true;
		this.label13.Location = new System.Drawing.Point(4, 385);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(64, 16);
		this.label13.TabIndex = 2;
		this.label13.Text = "Tùy chọn:";
		this.label13.Click += new System.EventHandler(label13_Click);
		this.D0B5C21E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D0B5C21E.Location = new System.Drawing.Point(6, 25);
		this.D0B5C21E.Name = "txtComment";
		this.D0B5C21E.Size = new System.Drawing.Size(297, 194);
		this.D0B5C21E.TabIndex = 1;
		this.D0B5C21E.Text = "";
		this.D0B5C21E.WordWrap = false;
		this.D0B5C21E.TextChanged += new System.EventHandler(DFA0A236);
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(2, 5);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(139, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Nội dung bình luận (0):";
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(317, 77);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(99, 20);
		this.ckbInteract.TabIndex = 181;
		this.ckbInteract.Text = "Thả cảm xúc";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		this.cbbTuyChonBaiViet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTuyChonBaiViet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTuyChonBaiViet.Enabled = false;
		this.cbbTuyChonBaiViet.FormattingEnabled = true;
		this.cbbTuyChonBaiViet.Location = new System.Drawing.Point(129, 135);
		this.cbbTuyChonBaiViet.Name = "cbbTuyChonBaiViet";
		this.cbbTuyChonBaiViet.Size = new System.Drawing.Size(153, 24);
		this.cbbTuyChonBaiViet.TabIndex = 180;
		this.cbbTuyChonBaiViet.SelectedIndexChanged += new System.EventHandler(cbbTuyChonBaiViet_SelectedIndexChanged);
		this.C40BA539.AutoSize = true;
		this.C40BA539.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C40BA539.Location = new System.Drawing.Point(661, 380);
		this.C40BA539.Name = "ckbSendAnh";
		this.C40BA539.Size = new System.Drawing.Size(103, 20);
		this.C40BA539.TabIndex = 165;
		this.C40BA539.Text = "Bi\u0300nh luâ\u0323n a\u0309nh";
		this.C40BA539.UseVisualStyleBackColor = true;
		this.C40BA539.CheckedChanged += new System.EventHandler(C40BA539_CheckedChanged);
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.tabTuyChonBaiViet);
		this.panel2.Location = new System.Drawing.Point(30, 164);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(252, 270);
		this.panel2.TabIndex = 181;
		this.tabTuyChonBaiViet.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		this.tabTuyChonBaiViet.Controls.Add(this.tabPage1);
		this.tabTuyChonBaiViet.Controls.Add(this.D185E018);
		this.tabTuyChonBaiViet.Location = new System.Drawing.Point(-4, -4);
		this.tabTuyChonBaiViet.Name = "tabTuyChonBaiViet";
		this.tabTuyChonBaiViet.SelectedIndex = 0;
		this.tabTuyChonBaiViet.Size = new System.Drawing.Size(258, 307);
		this.tabTuyChonBaiViet.TabIndex = 0;
		this.tabPage1.Controls.Add(this.label2);
		this.tabPage1.Controls.Add(this.txtIdPost);
		this.tabPage1.Controls.Add(this.ckbTuDongXoa);
		this.tabPage1.Location = new System.Drawing.Point(4, 4);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.tabPage1.Size = new System.Drawing.Size(250, 278);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "tabPage1";
		this.tabPage1.UseVisualStyleBackColor = true;
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(3, 3);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(176, 16);
		this.label2.TabIndex = 40;
		this.label2.Text = "Nhâ\u0323p Id hoă\u0323c link ba\u0300i viê\u0301t (0):";
		this.txtIdPost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtIdPost.Location = new System.Drawing.Point(6, 23);
		this.txtIdPost.Name = "txtIdPost";
		this.txtIdPost.Size = new System.Drawing.Size(238, 216);
		this.txtIdPost.TabIndex = 1;
		this.txtIdPost.Text = "";
		this.txtIdPost.WordWrap = false;
		this.txtIdPost.TextChanged += new System.EventHandler(D412100E);
		this.ckbTuDongXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.ckbTuDongXoa.AutoSize = true;
		this.ckbTuDongXoa.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoa.Location = new System.Drawing.Point(6, 242);
		this.ckbTuDongXoa.Name = "ckbTuDongXoa";
		this.ckbTuDongXoa.Size = new System.Drawing.Size(192, 20);
		this.ckbTuDongXoa.TabIndex = 176;
		this.ckbTuDongXoa.Text = "Xóa link ba\u0300i viê\u0301t đã tương tác";
		this.ckbTuDongXoa.UseVisualStyleBackColor = true;
		this.D185E018.Controls.Add(this.label6);
		this.D185E018.Controls.Add(this.C803E329);
		this.D185E018.Location = new System.Drawing.Point(4, 4);
		this.D185E018.Name = "tabPage2";
		this.D185E018.Padding = new System.Windows.Forms.Padding(3);
		this.D185E018.Size = new System.Drawing.Size(250, 281);
		this.D185E018.TabIndex = 1;
		this.D185E018.Text = "tabPage2";
		this.D185E018.UseVisualStyleBackColor = true;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(3, 3);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(171, 16);
		this.label6.TabIndex = 42;
		this.label6.Text = "Nhâ\u0323p danh sa\u0301ch tư\u0300 kho\u0301a (0):";
		this.C803E329.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.C803E329.Location = new System.Drawing.Point(6, 23);
		this.C803E329.Name = "txtTuKhoa";
		this.C803E329.Size = new System.Drawing.Size(238, 236);
		this.C803E329.TabIndex = 41;
		this.C803E329.Text = "";
		this.C803E329.WordWrap = false;
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.B5AA411B);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(661, 403);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(311, 31);
		this.plAnh.TabIndex = 166;
		this.txtAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtAnh.Location = new System.Drawing.Point(86, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(220, 23);
		this.txtAnh.TabIndex = 155;
		this.B5AA411B.AutoSize = true;
		this.B5AA411B.Location = new System.Drawing.Point(3, 6);
		this.B5AA411B.Name = "label12";
		this.B5AA411B.Size = new System.Drawing.Size(73, 16);
		this.B5AA411B.TabIndex = 39;
		this.B5AA411B.Text = "Folder ảnh:";
		this.B5AA411B.Click += new System.EventHandler(D28475B5);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(27, 137);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(64, 16);
		this.label4.TabIndex = 178;
		this.label4.Text = "Tùy chọn:";
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(27, 79);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(84, 16);
		this.label49.TabIndex = 169;
		this.label49.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(129, 77);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 167;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidTo.Location = new System.Drawing.Point(226, 77);
		this.nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidTo.TabIndex = 168;
		this.nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.label66.Location = new System.Drawing.Point(191, 79);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 171;
		this.label66.Text = ">";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(661, 77);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(127, 20);
		this.ckbComment.TabIndex = 163;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		this.CD0322A7.AutoSize = true;
		this.CD0322A7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CD0322A7.Location = new System.Drawing.Point(317, 135);
		this.CD0322A7.Name = "ckbShareWall";
		this.CD0322A7.Size = new System.Drawing.Size(87, 20);
		this.CD0322A7.TabIndex = 6;
		this.CD0322A7.Text = "Share wall";
		this.CD0322A7.UseVisualStyleBackColor = true;
		this.CD0322A7.CheckedChanged += new System.EventHandler(DD234D22);
		this.FC1BD430.Location = new System.Drawing.Point(498, 50);
		this.FC1BD430.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.FC1BD430.Name = "nudTimeTo";
		this.FC1BD430.Size = new System.Drawing.Size(51, 23);
		this.FC1BD430.TabIndex = 4;
		this.C12BCA34.Location = new System.Drawing.Point(226, 106);
		this.C12BCA34.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C12BCA34.Name = "nudDelayTo";
		this.C12BCA34.Size = new System.Drawing.Size(56, 23);
		this.C12BCA34.TabIndex = 4;
		this.nudTimeFrom.Location = new System.Drawing.Point(420, 50);
		this.nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeFrom.Name = "nudTimeFrom";
		this.nudTimeFrom.Size = new System.Drawing.Size(51, 23);
		this.nudTimeFrom.TabIndex = 3;
		this.nudDelayFrom.Location = new System.Drawing.Point(129, 106);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(129, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new System.Drawing.Point(471, 52);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 38;
		this.label9.Text = ">";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.C0313DA4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C0313DA4.Location = new System.Drawing.Point(191, 108);
		this.C0313DA4.Name = "label7";
		this.C0313DA4.Size = new System.Drawing.Size(29, 16);
		this.C0313DA4.TabIndex = 38;
		this.C0313DA4.Text = ">";
		this.C0313DA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(314, 52);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(103, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Xem bài viết (s):";
		this.F1056310.AutoSize = true;
		this.F1056310.Location = new System.Drawing.Point(27, 108);
		this.F1056310.Name = "label5";
		this.F1056310.Size = new System.Drawing.Size(87, 16);
		this.F1056310.TabIndex = 34;
		this.F1056310.Text = "Gia\u0303n ca\u0301ch (s):";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(508, 455);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 10;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.CFB6A78E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.CFB6A78E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.CFB6A78E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CFB6A78E.FlatAppearance.BorderSize = 0;
		this.CFB6A78E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CFB6A78E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.CFB6A78E.ForeColor = System.Drawing.Color.White;
		this.CFB6A78E.Location = new System.Drawing.Point(401, 455);
		this.CFB6A78E.Name = "btnAdd";
		this.CFB6A78E.Size = new System.Drawing.Size(92, 29);
		this.CFB6A78E.TabIndex = 9;
		this.CFB6A78E.Text = "Thêm";
		this.CFB6A78E.UseVisualStyleBackColor = false;
		this.CFB6A78E.Click += new System.EventHandler(FA82CFA2);
		this.B5338B2F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B5338B2F.BackColor = System.Drawing.Color.White;
		this.B5338B2F.BorderRadius = 0;
		this.B5338B2F.BottomSahddow = true;
		this.B5338B2F.color = System.Drawing.Color.DarkViolet;
		this.B5338B2F.Controls.Add(this.pnlHeader);
		this.B5338B2F.LeftSahddow = false;
		this.B5338B2F.Location = new System.Drawing.Point(1, 0);
		this.B5338B2F.Name = "bunifuCards1";
		this.B5338B2F.RightSahddow = true;
		this.B5338B2F.ShadowDepth = 20;
		this.B5338B2F.Size = new System.Drawing.Size(1000, 37);
		this.B5338B2F.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1003, 497);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffLikeComment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CD00BEBD_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.DF1A3F15.ResumeLayout(false);
		this.DF1A3F15.PerformLayout();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		this.D405C7AB.ResumeLayout(false);
		this.D405C7AB.PerformLayout();
		this.panel6.ResumeLayout(false);
		this.panel6.PerformLayout();
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.B9A5D6BA.ResumeLayout(false);
		this.B9A5D6BA.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagFrom).EndInit();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.tabTuyChonBaiViet.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.tabPage1.PerformLayout();
		this.D185E018.ResumeLayout(false);
		this.D185E018.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FC1BD430).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C12BCA34).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.B5338B2F.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
