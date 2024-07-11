using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDCapNhatThongTin : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A784CA8E
	{
		public static readonly A784CA8E _003C_003E9 = new A784CA8E();

		public static Func<string, string> _003C_003E9__24_0;

		public static Func<string, string> _003C_003E9__24_1;

		internal string A9A3B9AC(string string_0)
		{
			return string_0.Split('|')[0];
		}

		internal string method_0(string FCBE242F)
		{
			return FCBE242F.Split('|')[0];
		}
	}

	private JSON_Settings gclass8_0;

	private string string_0;

	private string CB34A120;

	private string string_1;

	private int int_0;

	public static bool A69247A9;

	private string string_2 = "";

	private int int_1 = 0;

	private List<string> E4232D84 = new List<string>();

	private List<string> D3022A85 = new List<string>();

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> A416C490 = new List<string>();

	private List<string> A2009D25 = new List<string>();

	private List<string> list_2 = new List<string>();

	private List<string> list_3 = new List<string>();

	private List<string> list_4 = new List<string>();

	private List<string> F78313BD = new List<string>
	{
		"1|Single", "2|In a relationship", "5|Engaged", "4|Married", "10|In a civil union", "11|In a domestic partnership", "3|In an open relationship", "6|It's complicated", "8|Separated", "9|Divorced",
		"7|Widowed"
	};

	private List<string> CEADB09B = new List<string> { "1|Female", "2|Male" };

	private IContainer FF1E3302 = null;

	private BunifuDragControl B33A0408;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button DCA67825;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button A086383B;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnNhapBio;

	private CheckBox ckbRelationship;

	private CheckBox ckbCurrentCity;

	private CheckBox D0A8E113;

	private CheckBox ckbHighSchool;

	private CheckBox E49812B9;

	private Button btnNhapCurrentCity;

	private Button AB1DA9BD;

	private Button btnNhapHighSchool;

	private Button btnNhapWork;

	private CheckBox C7B99F19;

	private ComboBox cbbRelationship;

	private CheckBox E9062609;

	private Button btnNhapHometown;

	private ComboBox AB07A2BC;

	private CheckBox ckbGender;

	private CheckBox C7948E0E;

	private Button B006F01A;

	private Button CDB89C09;

	private Button A411EEB0;

	private CheckBox ckbNickname;

	private Button C795469C;

	public fHDCapNhatThongTin(string string_3, int int_2 = 0, string string_4 = "")
	{
		InitializeComponent();
		A69247A9 = false;
		string_0 = string_3;
		string_1 = string_4;
		int_0 = int_2;
		string text = base.Name.Substring(1);
		string text2 = "Cập nhật thông tin";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_2)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			CB34A120 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			DCA67825.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void D91CB39B(object sender, EventArgs e)
	{
		method_0();
		D1A8D5AC();
		try
		{
			C7B99F19.Checked = gclass8_0.GetValueBool("ckbBio");
			E49812B9.Checked = gclass8_0.GetValueBool("ckbWork");
			ckbHighSchool.Checked = gclass8_0.GetValueBool("ckbHighSchool");
			D0A8E113.Checked = gclass8_0.GetValueBool("ckbCollege");
			ckbCurrentCity.Checked = gclass8_0.GetValueBool("ckbCurrentCity");
			E9062609.Checked = gclass8_0.GetValueBool("ckbHometown");
			ckbRelationship.Checked = gclass8_0.GetValueBool("ckbRelationship");
			ckbGender.Checked = gclass8_0.GetValueBool("ckbGender");
			C7948E0E.Checked = gclass8_0.GetValueBool("ckbBirthday");
			ckbNickname.Checked = gclass8_0.GetValueBool("ckbNickname");
			string_2 = gclass8_0.GetValue("txtBio");
			int_1 = gclass8_0.GetValueInt("typeSplitBio");
			E4232D84 = gclass8_0.GetValueList("lstWork");
			D3022A85 = gclass8_0.GetValueList("lstHighSchool");
			list_0 = gclass8_0.GetValueList("lstCollege");
			list_1 = gclass8_0.GetValueList("lstCurrentCity");
			A416C490 = gclass8_0.GetValueList("lstHometown");
			cbbRelationship.SelectedValue = ((gclass8_0.GetValue("cbbRelationship", "-1").Split('|').Length == 1) ? gclass8_0.GetValue("cbbRelationship", "-1") : "-1");
			AB07A2BC.SelectedValue = ((gclass8_0.GetValue("cbbGender", "-1").Split('|').Length == 1) ? gclass8_0.GetValue("cbbGender", "-1") : "-1");
			A2009D25 = gclass8_0.GetValueList("lstDay");
			list_2 = gclass8_0.GetValueList("lstMonth");
			list_3 = gclass8_0.GetValueList("lstYear");
			list_4 = gclass8_0.GetValueList("lstNickname");
			BCAC9A1F(null, null);
			E49812B9_CheckedChanged(null, null);
			C63F91A2(null, null);
			D0A8E113_CheckedChanged(null, null);
			ckbCurrentCity_CheckedChanged(null, null);
			E9062609_CheckedChanged(null, null);
			ckbRelationship_CheckedChanged(null, null);
			ckbGender_CheckedChanged(null, null);
			C7948E0E_CheckedChanged(null, null);
			ckbNickname_CheckedChanged(null, null);
			Common.BE3BB914(btnNhapCurrentCity, list_1.Count);
			Common.BE3BB914(btnNhapHometown, A416C490.Count);
			Common.BE3BB914(AB1DA9BD, list_0.Count);
			Common.BE3BB914(btnNhapHighSchool, D3022A85.Count);
			Common.BE3BB914(btnNhapWork, E4232D84.Count);
			Common.BE3BB914(btnNhapBio, string_2.Split(new string[1] { (int_1 == 0) ? "\n" : "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).Length);
			Common.BE3BB914(C795469C, list_4.Count);
		}
		catch
		{
		}
	}

	private void D1A8D5AC()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < CEADB09B.Count; i++)
		{
			dictionary.Add(CEADB09B[i].Split('|')[0], CEADB09B[i].Split('|')[1]);
		}
		dictionary.Add("-1", "Random");
		AB07A2BC.DataSource = new BindingSource(dictionary, null);
		AB07A2BC.DisplayMember = "Value";
		AB07A2BC.ValueMember = "Key";
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < F78313BD.Count; i++)
		{
			dictionary.Add(F78313BD[i].Split('|')[0], F78313BD[i].Split('|')[1]);
		}
		dictionary.Add("-1", "Random");
		cbbRelationship.DataSource = new BindingSource(dictionary, null);
		cbbRelationship.DisplayMember = "Value";
		cbbRelationship.ValueMember = "Key";
	}

	private void A086383B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DCA67825_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("ckbBio", C7B99F19.Checked);
		gClass.GetJson("ckbWork", E49812B9.Checked);
		gClass.GetJson("ckbHighSchool", ckbHighSchool.Checked);
		gClass.GetJson("ckbCollege", D0A8E113.Checked);
		gClass.GetJson("ckbCurrentCity", ckbCurrentCity.Checked);
		gClass.GetJson("ckbHometown", E9062609.Checked);
		gClass.GetJson("ckbRelationship", ckbRelationship.Checked);
		gClass.GetJson("ckbGender", ckbGender.Checked);
		gClass.GetJson("ckbBirthday", C7948E0E.Checked);
		gClass.GetJson("ckbNickname", ckbNickname.Checked);
		gClass.GetJson("txtBio", string_2);
		gClass.GetJson("typeSplitBio", int_1);
		gClass.method_5("lstWork", E4232D84);
		gClass.method_5("lstHighSchool", D3022A85);
		gClass.method_5("lstCollege", list_0);
		gClass.method_5("lstCurrentCity", list_1);
		gClass.method_5("lstHometown", A416C490);
		string text2 = cbbRelationship.SelectedValue.ToString();
		text2 = ((text2 == "-1") ? string.Join("|", F78313BD.Select((string string_0) => string_0.Split('|')[0])) : text2);
		gClass.GetJson("cbbRelationship", text2);
		string text3 = AB07A2BC.SelectedValue.ToString();
		text3 = ((text3 == "-1") ? string.Join("|", CEADB09B.Select((string FCBE242F) => FCBE242F.Split('|')[0])) : text3);
		gClass.GetJson("cbbGender", text3);
		gClass.method_5("lstDay", A2009D25);
		gClass.method_5("lstMonth", list_2);
		gClass.method_5("lstYear", list_3);
		gClass.method_5("lstNickname", list_4);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, CB34A120, string_))
				{
					A69247A9 = true;
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
			if (InteractSQL.smethod_13(string_1, text, string_))
			{
				A69247A9 = true;
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

	private void BCAC9A1F(object sender, EventArgs e)
	{
		btnNhapBio.Enabled = C7B99F19.Checked;
	}

	private void E49812B9_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapWork.Enabled = E49812B9.Checked;
	}

	private void C63F91A2(object sender, EventArgs e)
	{
		btnNhapHighSchool.Enabled = ckbHighSchool.Checked;
	}

	private void D0A8E113_CheckedChanged(object sender, EventArgs e)
	{
		AB1DA9BD.Enabled = D0A8E113.Checked;
	}

	private void ckbCurrentCity_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapCurrentCity.Enabled = ckbCurrentCity.Checked;
	}

	private void ckbRelationship_CheckedChanged(object sender, EventArgs e)
	{
		cbbRelationship.Enabled = ckbRelationship.Checked;
	}

	private void btnNhapBio_Click(object sender, EventArgs e)
	{
		fNhapDuLieu3 b = new fNhapDuLieu3(string_2, int_1, Language.GetValue("Nhâ\u0323p danh sa\u0301ch Bio"), Language.GetValue("Danh sa\u0301ch Bio"));
		Common.ShowForm(b);
		string_2 = b.FA0375B6;
		int_1 = b.FAA1F037;
		Common.BE3BB914(btnNhapBio, string_2.Split(new string[1] { (int_1 == 0) ? "\n" : "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).Length);
	}

	private void btnNhapWork_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(E4232D84, "Nhâ\u0323p danh sa\u0301ch Work", "Danh sa\u0301ch Work", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		E4232D84 = fNhapDuLieu3.C82C3629;
		Common.BE3BB914(btnNhapWork, E4232D84.Count);
	}

	private void btnNhapHighSchool_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(D3022A85, "Nhâ\u0323p danh sa\u0301ch High School", "Danh sa\u0301ch High School", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		D3022A85 = fNhapDuLieu3.C82C3629;
		Common.BE3BB914(btnNhapHighSchool, D3022A85.Count);
	}

	private void AB1DA9BD_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch College", "Danh sa\u0301ch College", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_0 = fNhapDuLieu3.C82C3629;
		Common.BE3BB914(AB1DA9BD, list_0.Count);
	}

	private void F5217D3E(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch Current City", "Danh sa\u0301ch Current City", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_1 = fNhapDuLieu3.C82C3629;
		Common.BE3BB914(btnNhapCurrentCity, list_1.Count);
	}

	private void E9062609_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapHometown.Enabled = E9062609.Checked;
	}

	private void btnNhapHometown_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(A416C490, "Nhâ\u0323p danh sa\u0301ch Hometown", "Danh sa\u0301ch Hometown", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		A416C490 = fNhapDuLieu3.C82C3629;
		Common.BE3BB914(btnNhapHometown, A416C490.Count);
	}

	private void A411EEB0_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(A2009D25, "Nhâ\u0323p danh sa\u0301ch ngày", "Danh sa\u0301ch ngày", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		A2009D25 = fNhapDuLieu3.C82C3629;
	}

	private void C3318F06(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_2, "Nhâ\u0323p danh sa\u0301ch tháng", "Danh sa\u0301ch tháng", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_2 = fNhapDuLieu3.C82C3629;
	}

	private void B006F01A_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_3, "Nhâ\u0323p danh sa\u0301ch năm", "Danh sa\u0301ch năm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_3 = fNhapDuLieu3.C82C3629;
	}

	private void ckbGender_CheckedChanged(object sender, EventArgs e)
	{
		AB07A2BC.Enabled = ckbGender.Checked;
	}

	private void C7948E0E_CheckedChanged(object sender, EventArgs e)
	{
		A411EEB0.Enabled = C7948E0E.Checked;
		CDB89C09.Enabled = C7948E0E.Checked;
		B006F01A.Enabled = C7948E0E.Checked;
	}

	private void C6AECA8A(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_4, "Nhâ\u0323p danh sa\u0301ch Nickname", "Danh sa\u0301ch Nickname", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.ShowForm(fNhapDuLieu3);
		list_4 = fNhapDuLieu3.C82C3629;
		Common.BE3BB914(C795469C, list_4.Count);
	}

	private void ckbNickname_CheckedChanged(object sender, EventArgs e)
	{
		C795469C.Enabled = ckbNickname.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && FF1E3302 != null)
		{
			FF1E3302.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.FF1E3302 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDCapNhatThongTin));
		this.B33A0408 = new Bunifu.Framework.UI.BunifuDragControl(this.FF1E3302);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.FF1E3302);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.A086383B = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.B006F01A = new System.Windows.Forms.Button();
		this.CDB89C09 = new System.Windows.Forms.Button();
		this.A411EEB0 = new System.Windows.Forms.Button();
		this.AB07A2BC = new System.Windows.Forms.ComboBox();
		this.ckbNickname = new System.Windows.Forms.CheckBox();
		this.C7948E0E = new System.Windows.Forms.CheckBox();
		this.cbbRelationship = new System.Windows.Forms.ComboBox();
		this.ckbGender = new System.Windows.Forms.CheckBox();
		this.ckbRelationship = new System.Windows.Forms.CheckBox();
		this.E9062609 = new System.Windows.Forms.CheckBox();
		this.ckbCurrentCity = new System.Windows.Forms.CheckBox();
		this.D0A8E113 = new System.Windows.Forms.CheckBox();
		this.ckbHighSchool = new System.Windows.Forms.CheckBox();
		this.E49812B9 = new System.Windows.Forms.CheckBox();
		this.btnNhapHometown = new System.Windows.Forms.Button();
		this.btnNhapCurrentCity = new System.Windows.Forms.Button();
		this.AB1DA9BD = new System.Windows.Forms.Button();
		this.btnNhapHighSchool = new System.Windows.Forms.Button();
		this.btnNhapWork = new System.Windows.Forms.Button();
		this.C7B99F19 = new System.Windows.Forms.CheckBox();
		this.C795469C = new System.Windows.Forms.Button();
		this.btnNhapBio = new System.Windows.Forms.Button();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.DCA67825 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.B33A0408.Fixed = true;
		this.B33A0408.Horizontal = true;
		this.B33A0408.TargetControl = this.bunifuCustomLabel1;
		this.B33A0408.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(476, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Cập nhật thông tin";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.A086383B);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(476, 31);
		this.pnlHeader.TabIndex = 9;
		this.A086383B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.A086383B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A086383B.FlatAppearance.BorderSize = 0;
		this.A086383B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.A086383B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A086383B.ForeColor = System.Drawing.Color.White;
		this.A086383B.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.A086383B.Location = new System.Drawing.Point(445, 1);
		this.A086383B.Name = "button1";
		this.A086383B.Size = new System.Drawing.Size(30, 30);
		this.A086383B.TabIndex = 77;
		this.A086383B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.A086383B.UseVisualStyleBackColor = true;
		this.A086383B.Click += new System.EventHandler(A086383B_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.B006F01A);
		this.panel1.Controls.Add(this.CDB89C09);
		this.panel1.Controls.Add(this.A411EEB0);
		this.panel1.Controls.Add(this.AB07A2BC);
		this.panel1.Controls.Add(this.ckbNickname);
		this.panel1.Controls.Add(this.C7948E0E);
		this.panel1.Controls.Add(this.cbbRelationship);
		this.panel1.Controls.Add(this.ckbGender);
		this.panel1.Controls.Add(this.ckbRelationship);
		this.panel1.Controls.Add(this.E9062609);
		this.panel1.Controls.Add(this.ckbCurrentCity);
		this.panel1.Controls.Add(this.D0A8E113);
		this.panel1.Controls.Add(this.ckbHighSchool);
		this.panel1.Controls.Add(this.E49812B9);
		this.panel1.Controls.Add(this.btnNhapHometown);
		this.panel1.Controls.Add(this.btnNhapCurrentCity);
		this.panel1.Controls.Add(this.AB1DA9BD);
		this.panel1.Controls.Add(this.btnNhapHighSchool);
		this.panel1.Controls.Add(this.btnNhapWork);
		this.panel1.Controls.Add(this.C7B99F19);
		this.panel1.Controls.Add(this.C795469C);
		this.panel1.Controls.Add(this.btnNhapBio);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.DCA67825);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(479, 459);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.B006F01A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B006F01A.Location = new System.Drawing.Point(384, 335);
		this.B006F01A.Name = "btnYear";
		this.B006F01A.Size = new System.Drawing.Size(61, 25);
		this.B006F01A.TabIndex = 128;
		this.B006F01A.Text = "Năm";
		this.B006F01A.UseVisualStyleBackColor = true;
		this.B006F01A.Click += new System.EventHandler(B006F01A_Click);
		this.CDB89C09.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CDB89C09.Location = new System.Drawing.Point(317, 335);
		this.CDB89C09.Name = "btnMonth";
		this.CDB89C09.Size = new System.Drawing.Size(61, 25);
		this.CDB89C09.TabIndex = 128;
		this.CDB89C09.Text = "Tháng";
		this.CDB89C09.UseVisualStyleBackColor = true;
		this.CDB89C09.Click += new System.EventHandler(C3318F06);
		this.A411EEB0.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A411EEB0.Location = new System.Drawing.Point(250, 335);
		this.A411EEB0.Name = "btnDay";
		this.A411EEB0.Size = new System.Drawing.Size(61, 25);
		this.A411EEB0.TabIndex = 128;
		this.A411EEB0.Text = "Ngày";
		this.A411EEB0.UseVisualStyleBackColor = true;
		this.A411EEB0.Click += new System.EventHandler(A411EEB0_Click);
		this.AB07A2BC.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AB07A2BC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.AB07A2BC.FormattingEnabled = true;
		this.AB07A2BC.Location = new System.Drawing.Point(250, 306);
		this.AB07A2BC.Name = "cbbGender";
		this.AB07A2BC.Size = new System.Drawing.Size(195, 24);
		this.AB07A2BC.TabIndex = 126;
		this.ckbNickname.AutoSize = true;
		this.ckbNickname.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbNickname.Location = new System.Drawing.Point(29, 370);
		this.ckbNickname.Name = "ckbNickname";
		this.ckbNickname.Size = new System.Drawing.Size(81, 20);
		this.ckbNickname.TabIndex = 125;
		this.ckbNickname.Text = "Nickname";
		this.ckbNickname.UseVisualStyleBackColor = true;
		this.ckbNickname.CheckedChanged += new System.EventHandler(ckbNickname_CheckedChanged);
		this.C7948E0E.AutoSize = true;
		this.C7948E0E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C7948E0E.Location = new System.Drawing.Point(29, 338);
		this.C7948E0E.Name = "ckbBirthday";
		this.C7948E0E.Size = new System.Drawing.Size(141, 20);
		this.C7948E0E.TabIndex = 125;
		this.C7948E0E.Text = "Ngày sinh (Birthday)";
		this.C7948E0E.UseVisualStyleBackColor = true;
		this.C7948E0E.CheckedChanged += new System.EventHandler(C7948E0E_CheckedChanged);
		this.cbbRelationship.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbRelationship.FormattingEnabled = true;
		this.cbbRelationship.Location = new System.Drawing.Point(250, 276);
		this.cbbRelationship.Name = "cbbRelationship";
		this.cbbRelationship.Size = new System.Drawing.Size(195, 24);
		this.cbbRelationship.TabIndex = 126;
		this.ckbGender.AutoSize = true;
		this.ckbGender.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGender.Location = new System.Drawing.Point(29, 308);
		this.ckbGender.Name = "ckbGender";
		this.ckbGender.Size = new System.Drawing.Size(127, 20);
		this.ckbGender.TabIndex = 125;
		this.ckbGender.Text = "Giới tính (Gender)";
		this.ckbGender.UseVisualStyleBackColor = true;
		this.ckbGender.CheckedChanged += new System.EventHandler(ckbGender_CheckedChanged);
		this.ckbRelationship.AutoSize = true;
		this.ckbRelationship.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRelationship.Location = new System.Drawing.Point(29, 278);
		this.ckbRelationship.Name = "ckbRelationship";
		this.ckbRelationship.Size = new System.Drawing.Size(218, 20);
		this.ckbRelationship.TabIndex = 125;
		this.ckbRelationship.Text = "Tình trạng quan hệ (Relationship)";
		this.ckbRelationship.UseVisualStyleBackColor = true;
		this.ckbRelationship.CheckedChanged += new System.EventHandler(ckbRelationship_CheckedChanged);
		this.E9062609.AutoSize = true;
		this.E9062609.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E9062609.Location = new System.Drawing.Point(29, 247);
		this.E9062609.Name = "ckbHometown";
		this.E9062609.Size = new System.Drawing.Size(156, 20);
		this.E9062609.TabIndex = 125;
		this.E9062609.Text = "Quê quán (Hometown)";
		this.E9062609.UseVisualStyleBackColor = true;
		this.E9062609.CheckedChanged += new System.EventHandler(E9062609_CheckedChanged);
		this.ckbCurrentCity.AutoSize = true;
		this.ckbCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCurrentCity.Location = new System.Drawing.Point(29, 214);
		this.ckbCurrentCity.Name = "ckbCurrentCity";
		this.ckbCurrentCity.Size = new System.Drawing.Size(215, 20);
		this.ckbCurrentCity.TabIndex = 125;
		this.ckbCurrentCity.Text = "Thành phố hiện tại (Current City)";
		this.ckbCurrentCity.UseVisualStyleBackColor = true;
		this.ckbCurrentCity.CheckedChanged += new System.EventHandler(ckbCurrentCity_CheckedChanged);
		this.D0A8E113.AutoSize = true;
		this.D0A8E113.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D0A8E113.Location = new System.Drawing.Point(29, 181);
		this.D0A8E113.Name = "ckbCollege";
		this.D0A8E113.Size = new System.Drawing.Size(169, 20);
		this.D0A8E113.TabIndex = 125;
		this.D0A8E113.Text = "Trường đại học (College)";
		this.D0A8E113.UseVisualStyleBackColor = true;
		this.D0A8E113.CheckedChanged += new System.EventHandler(D0A8E113_CheckedChanged);
		this.ckbHighSchool.AutoSize = true;
		this.ckbHighSchool.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHighSchool.Location = new System.Drawing.Point(29, 148);
		this.ckbHighSchool.Name = "ckbHighSchool";
		this.ckbHighSchool.Size = new System.Drawing.Size(207, 20);
		this.ckbHighSchool.TabIndex = 125;
		this.ckbHighSchool.Text = "Trường trung học (High School)";
		this.ckbHighSchool.UseVisualStyleBackColor = true;
		this.ckbHighSchool.CheckedChanged += new System.EventHandler(C63F91A2);
		this.E49812B9.AutoSize = true;
		this.E49812B9.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E49812B9.Location = new System.Drawing.Point(29, 115);
		this.E49812B9.Name = "ckbWork";
		this.E49812B9.Size = new System.Drawing.Size(125, 20);
		this.E49812B9.TabIndex = 125;
		this.E49812B9.Text = "Công việc (Work)";
		this.E49812B9.UseVisualStyleBackColor = true;
		this.E49812B9.CheckedChanged += new System.EventHandler(E49812B9_CheckedChanged);
		this.btnNhapHometown.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapHometown.Location = new System.Drawing.Point(250, 243);
		this.btnNhapHometown.Name = "btnNhapHometown";
		this.btnNhapHometown.Size = new System.Drawing.Size(195, 27);
		this.btnNhapHometown.TabIndex = 124;
		this.btnNhapHometown.Text = "Nhập (0)";
		this.btnNhapHometown.UseVisualStyleBackColor = true;
		this.btnNhapHometown.Click += new System.EventHandler(btnNhapHometown_Click);
		this.btnNhapCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapCurrentCity.Location = new System.Drawing.Point(250, 210);
		this.btnNhapCurrentCity.Name = "btnNhapCurrentCity";
		this.btnNhapCurrentCity.Size = new System.Drawing.Size(195, 27);
		this.btnNhapCurrentCity.TabIndex = 124;
		this.btnNhapCurrentCity.Text = "Nhập (0)";
		this.btnNhapCurrentCity.UseVisualStyleBackColor = true;
		this.btnNhapCurrentCity.Click += new System.EventHandler(F5217D3E);
		this.AB1DA9BD.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AB1DA9BD.Location = new System.Drawing.Point(250, 177);
		this.AB1DA9BD.Name = "btnNhapCollege";
		this.AB1DA9BD.Size = new System.Drawing.Size(195, 27);
		this.AB1DA9BD.TabIndex = 124;
		this.AB1DA9BD.Text = "Nhập (0)";
		this.AB1DA9BD.UseVisualStyleBackColor = true;
		this.AB1DA9BD.Click += new System.EventHandler(AB1DA9BD_Click);
		this.btnNhapHighSchool.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapHighSchool.Location = new System.Drawing.Point(250, 144);
		this.btnNhapHighSchool.Name = "btnNhapHighSchool";
		this.btnNhapHighSchool.Size = new System.Drawing.Size(195, 27);
		this.btnNhapHighSchool.TabIndex = 124;
		this.btnNhapHighSchool.Text = "Nhập (0)";
		this.btnNhapHighSchool.UseVisualStyleBackColor = true;
		this.btnNhapHighSchool.Click += new System.EventHandler(btnNhapHighSchool_Click);
		this.btnNhapWork.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapWork.Location = new System.Drawing.Point(250, 111);
		this.btnNhapWork.Name = "btnNhapWork";
		this.btnNhapWork.Size = new System.Drawing.Size(195, 27);
		this.btnNhapWork.TabIndex = 124;
		this.btnNhapWork.Text = "Nhập (0)";
		this.btnNhapWork.UseVisualStyleBackColor = true;
		this.btnNhapWork.Click += new System.EventHandler(btnNhapWork_Click);
		this.C7B99F19.AutoSize = true;
		this.C7B99F19.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C7B99F19.Location = new System.Drawing.Point(29, 82);
		this.C7B99F19.Name = "ckbBio";
		this.C7B99F19.Size = new System.Drawing.Size(191, 20);
		this.C7B99F19.TabIndex = 125;
		this.C7B99F19.Text = "Tiểu sử mô tả bản thân (Bio)";
		this.C7B99F19.UseVisualStyleBackColor = true;
		this.C7B99F19.CheckedChanged += new System.EventHandler(BCAC9A1F);
		this.C795469C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C795469C.Location = new System.Drawing.Point(250, 366);
		this.C795469C.Name = "btnNickname";
		this.C795469C.Size = new System.Drawing.Size(195, 27);
		this.C795469C.TabIndex = 124;
		this.C795469C.Text = "Nhập (0)";
		this.C795469C.UseVisualStyleBackColor = true;
		this.C795469C.Click += new System.EventHandler(C6AECA8A);
		this.btnNhapBio.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapBio.Location = new System.Drawing.Point(250, 78);
		this.btnNhapBio.Name = "btnNhapBio";
		this.btnNhapBio.Size = new System.Drawing.Size(195, 27);
		this.btnNhapBio.TabIndex = 124;
		this.btnNhapBio.Text = "Nhập (0)";
		this.btnNhapBio.UseVisualStyleBackColor = true;
		this.btnNhapBio.Click += new System.EventHandler(btnNhapBio_Click);
		this.txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(320, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(26, 52);
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
		this.btnCancel.Location = new System.Drawing.Point(246, 414);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.DCA67825.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.DCA67825.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.DCA67825.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DCA67825.FlatAppearance.BorderSize = 0;
		this.DCA67825.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DCA67825.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DCA67825.ForeColor = System.Drawing.Color.White;
		this.DCA67825.Location = new System.Drawing.Point(139, 414);
		this.DCA67825.Name = "btnAdd";
		this.DCA67825.Size = new System.Drawing.Size(92, 29);
		this.DCA67825.TabIndex = 6;
		this.DCA67825.Text = "Thêm";
		this.DCA67825.UseVisualStyleBackColor = false;
		this.DCA67825.Click += new System.EventHandler(DCA67825_Click);
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
		this.bunifuCards1.Size = new System.Drawing.Size(476, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(479, 459);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDCapNhatThongTin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D91CB39B);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
