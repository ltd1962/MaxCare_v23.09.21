using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDChaySpam : Form
{
	private JSON_Settings gclass8_0;

	private string EB3E7F9A;

	private string E1A4901B;

	private string D306430E;

	private int F813E0A6;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl F7B1C13D;

	private BunifuDragControl bunifuDragControl_0;

	private Panel C3984A91;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox B10C2935;

	private Label D802B308;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button D3824E95;

	private Button btnAdd;

	private BunifuCards CF34093B;

	private Panel D1A20F14;

	private Button button1;

	private PictureBox EC9548B9;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbInteract;

	private CheckBox EEAF513B;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown D28CECBE;

	private Label label9;

	private Label label3;

	private Panel plCommentText;

	private RichTextBox txtComment;

	private Label label11;

	private Label lblComment;

	private Panel plAnh;

	private TextBox txtAnh;

	private RichTextBox A29D2B2C;

	private CheckBox AB13889A;

	private CheckBox ckbComment;

	private Label B506AAB6;

	private Label D58CCDA6;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label68;

	private NumericUpDown nudSoLuongUidTo;

	private Label E63A3C1B;

	private Button E514D901;

	private Button D2BDEBBF;

	private LinkLabel linkLabel1;

	private Panel plComment;

	private CheckBox ckbCommentText;

	private Panel C29F6396;

	private NumericUpDown nudSoLuongTagTo;

	private Label label16;

	private NumericUpDown BC27632B;

	private Label label15;

	private Label label14;

	private CheckBox DD24F505;

	private CheckBox ckbChiTagTenViet;

	private ComboBox cbbTuyChonNoiDung;

	private Button A5326322;

	private Label C993F227;

	private Panel plInteract;

	private CheckBox ckbGian;

	private CheckBox ckbBuon;

	private CheckBox F83504BF;

	private CheckBox D72DA0A1;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label label26;

	private CheckBox ckbAutoDeleteComment;

	private Panel panel3;

	private RadioButton DE893E86;

	private RadioButton rbCommentNgauNhien;

	private Label B52EBE23;

	public fHDChaySpam(string string_0, int int_0 = 0, string string_1 = "")
	{
		InitializeComponent();
		bool_0 = false;
		EB3E7F9A = string_0;
		D306430E = string_1;
		F813E0A6 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Chạy spam";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string string_2 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			string_2 = dataTable2.Rows[0]["CauHinh"].ToString();
			E1A4901B = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B10C2935.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_1);
			string_2 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B10C2935.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(string_2, BE9E4429: true);
		Language.SetLanguage(this);
		list_0 = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, D72DA0A1, F83504BF, ckbBuon, ckbGian };
	}

	private void AD29E0B6(object sender, EventArgs e)
	{
		F3027A0D();
		try
		{
			D28CECBE.Value = gclass8_0.GetValueInt("nudTimeFrom", 3);
			nudTimeTo.Value = gclass8_0.GetValueInt("nudTimeTo", 5);
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			nudSoLuongUidFrom.Value = gclass8_0.GetValueInt("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass8_0.GetValueInt("nudSoLuongUidTo", 3);
			ckbInteract.Checked = gclass8_0.GetValueBool("ckbInteract");
			string text = gclass8_0.GetValue("typeReaction", "0");
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Split('|').Contains(i.ToString());
			}
			EEAF513B.Checked = gclass8_0.GetValueBool("ckbShareWall");
			ckbComment.Checked = gclass8_0.GetValueBool("ckbComment");
			ckbCommentText.Checked = gclass8_0.GetValueBool("ckbCommentText");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			A29D2B2C.Text = gclass8_0.GetValue("txtIdPost");
			DD24F505.Checked = gclass8_0.GetValueBool("ckbTag");
			BC27632B.Value = gclass8_0.GetValueInt("nudSoLuongTagFrom", 3);
			nudSoLuongTagTo.Value = gclass8_0.GetValueInt("nudSoLuongTagTo", 5);
			ckbChiTagTenViet.Checked = gclass8_0.GetValueBool("ckbChiTagTenViet");
			AB13889A.Checked = gclass8_0.GetValueBool("ckbSendAnh");
			txtAnh.Text = gclass8_0.GetValue("txtAnh");
			cbbTuyChonNoiDung.SelectedIndex = gclass8_0.GetValueInt("typeNganCach");
			if (gclass8_0.GetValueInt("typeComment") == 1)
			{
				rbCommentNgauNhien.Checked = true;
			}
			else
			{
				DE893E86.Checked = true;
			}
			ckbAutoDeleteComment.Checked = gclass8_0.GetValueBool("ckbAutoDeleteComment");
		}
		catch
		{
		}
		method_0();
	}

	private void F3027A0D()
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
		string text = B10C2935.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = A29D2B2C.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id ba\u0300i viê\u0301t câ\u0300n buff like, comment!", 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> a2AB53A2 = txtComment.Lines.ToList();
			a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
			if (a2AB53A2.Count == 0 && !DD24F505.Checked)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudTimeFrom", D28CECBE.Value);
		gClass.GetJson("nudTimeTo", nudTimeTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.GetJson("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.GetJson("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + i + "|";
			}
		}
		gClass.GetJson("typeReaction", text2.TrimEnd('|'));
		gClass.GetJson("ckbShareWall", EEAF513B.Checked);
		gClass.GetJson("ckbComment", ckbComment.Checked);
		gClass.GetJson("ckbCommentText", ckbCommentText.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("txtIdPost", A29D2B2C.Text.Trim());
		gClass.GetJson("ckbTag", DD24F505.Checked);
		gClass.GetJson("nudSoLuongTagFrom", BC27632B.Value);
		gClass.GetJson("nudSoLuongTagTo", nudSoLuongTagTo.Value);
		gClass.GetJson("ckbChiTagTenViet", ckbChiTagTenViet.Checked);
		gClass.GetJson("ckbSendAnh", AB13889A.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		gClass.GetJson("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		int num = 0;
		if (rbCommentNgauNhien.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeComment", num);
		gClass.GetJson("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		string text3 = gClass.D9A09B34();
		if (F813E0A6 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(EB3E7F9A, text, E1A4901B, text3))
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
			if (InteractSQL.smethod_13(D306430E, text, text3))
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

	private void D3824E95_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C3984A91_Paint(object sender, PaintEventArgs e)
	{
		if (C3984A91.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C3984A91.ClientSize.Width - num, C3984A91.ClientSize.Height - num));
		}
	}

	private void E81DE583(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		D10A3803(null, null);
		ckbCommentText_CheckedChanged(null, null);
		DD24F505_CheckedChanged(null, null);
		E81DE583(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void D10A3803(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void A29D2B2C_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(A29D2B2C, label2);
	}

	private void AB13889A_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = AB13889A.Checked;
	}

	private void F38BFAA5(object sender, EventArgs e)
	{
	}

	private void EC9548B9_Click(object sender, EventArgs e)
	{
	}

	private void C6A49C19(object sender, EventArgs e)
	{
	}

	private void C73BAB25(object sender, EventArgs e)
	{
	}

	private void B52EBE23_Click(object sender, EventArgs e)
	{
	}

	private void rbCommentNgauNhien_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void D2BDEBBF_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 195;
	}

	private void CDA57738(object sender, EventArgs e)
	{
		plCommentText.Height = 260;
	}

	private void FB9F1A89(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbCommentText.Checked;
	}

	private void DD24F505_CheckedChanged(object sender, EventArgs e)
	{
		C29F6396.Enabled = DD24F505.Checked;
	}

	private void E032FFB6(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void A5326322_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtComment.Focus();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChaySpam));
		this.F7B1C13D = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.D1A20F14 = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.EC9548B9 = new System.Windows.Forms.PictureBox();
		this.C3984A91 = new System.Windows.Forms.Panel();
		this.plInteract = new System.Windows.Forms.Panel();
		this.ckbGian = new System.Windows.Forms.CheckBox();
		this.ckbBuon = new System.Windows.Forms.CheckBox();
		this.F83504BF = new System.Windows.Forms.CheckBox();
		this.D72DA0A1 = new System.Windows.Forms.CheckBox();
		this.ckbThuong = new System.Windows.Forms.CheckBox();
		this.ckbTym = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.radioButton4 = new System.Windows.Forms.RadioButton();
		this.label26 = new System.Windows.Forms.Label();
		this.plComment = new System.Windows.Forms.Panel();
		this.plCommentText = new System.Windows.Forms.Panel();
		this.cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		this.A5326322 = new System.Windows.Forms.Button();
		this.C993F227 = new System.Windows.Forms.Label();
		this.ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.DE893E86 = new System.Windows.Forms.RadioButton();
		this.rbCommentNgauNhien = new System.Windows.Forms.RadioButton();
		this.E514D901 = new System.Windows.Forms.Button();
		this.D2BDEBBF = new System.Windows.Forms.Button();
		this.B52EBE23 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.label11 = new System.Windows.Forms.Label();
		this.lblComment = new System.Windows.Forms.Label();
		this.ckbCommentText = new System.Windows.Forms.CheckBox();
		this.C29F6396 = new System.Windows.Forms.Panel();
		this.ckbChiTagTenViet = new System.Windows.Forms.CheckBox();
		this.nudSoLuongTagTo = new System.Windows.Forms.NumericUpDown();
		this.label16 = new System.Windows.Forms.Label();
		this.BC27632B = new System.Windows.Forms.NumericUpDown();
		this.label15 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.DD24F505 = new System.Windows.Forms.CheckBox();
		this.D58CCDA6 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label68 = new System.Windows.Forms.Label();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.E63A3C1B = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.B506AAB6 = new System.Windows.Forms.Label();
		this.A29D2B2C = new System.Windows.Forms.RichTextBox();
		this.AB13889A = new System.Windows.Forms.CheckBox();
		this.ckbComment = new System.Windows.Forms.CheckBox();
		this.label2 = new System.Windows.Forms.Label();
		this.EEAF513B = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudTimeTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.D28CECBE = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.B10C2935 = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.D802B308 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.D3824E95 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.CF34093B = new Bunifu.Framework.UI.BunifuCards();
		this.D1A20F14.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.EC9548B9).BeginInit();
		this.C3984A91.SuspendLayout();
		this.plInteract.SuspendLayout();
		this.panel7.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plCommentText.SuspendLayout();
		this.panel3.SuspendLayout();
		this.C29F6396.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.BC27632B).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D28CECBE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.CF34093B.SuspendLayout();
		base.SuspendLayout();
		this.F7B1C13D.Fixed = true;
		this.F7B1C13D.Horizontal = true;
		this.F7B1C13D.TargetControl = this.bunifuCustomLabel1;
		this.F7B1C13D.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(711, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Chạy spam";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.D1A20F14;
		this.bunifuDragControl_0.Vertical = true;
		this.D1A20F14.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.D1A20F14.BackColor = System.Drawing.Color.White;
		this.D1A20F14.Controls.Add(this.button1);
		this.D1A20F14.Controls.Add(this.EC9548B9);
		this.D1A20F14.Controls.Add(this.bunifuCustomLabel1);
		this.D1A20F14.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.D1A20F14.Location = new System.Drawing.Point(0, 3);
		this.D1A20F14.Name = "pnlHeader";
		this.D1A20F14.Size = new System.Drawing.Size(711, 31);
		this.D1A20F14.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(680, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.EC9548B9.Cursor = System.Windows.Forms.Cursors.Default;
		this.EC9548B9.Image = Resources.Bitmap_4;
		this.EC9548B9.Location = new System.Drawing.Point(3, 2);
		this.EC9548B9.Name = "pictureBox1";
		this.EC9548B9.Size = new System.Drawing.Size(34, 27);
		this.EC9548B9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.EC9548B9.TabIndex = 76;
		this.EC9548B9.TabStop = false;
		this.EC9548B9.Click += new System.EventHandler(EC9548B9_Click);
		this.C3984A91.BackColor = System.Drawing.Color.White;
		this.C3984A91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C3984A91.Controls.Add(this.plInteract);
		this.C3984A91.Controls.Add(this.plComment);
		this.C3984A91.Controls.Add(this.D58CCDA6);
		this.C3984A91.Controls.Add(this.nudSoLuongUidFrom);
		this.C3984A91.Controls.Add(this.label68);
		this.C3984A91.Controls.Add(this.nudSoLuongUidTo);
		this.C3984A91.Controls.Add(this.E63A3C1B);
		this.C3984A91.Controls.Add(this.plAnh);
		this.C3984A91.Controls.Add(this.A29D2B2C);
		this.C3984A91.Controls.Add(this.AB13889A);
		this.C3984A91.Controls.Add(this.ckbComment);
		this.C3984A91.Controls.Add(this.label2);
		this.C3984A91.Controls.Add(this.EEAF513B);
		this.C3984A91.Controls.Add(this.ckbInteract);
		this.C3984A91.Controls.Add(this.nudTimeTo);
		this.C3984A91.Controls.Add(this.nudDelayTo);
		this.C3984A91.Controls.Add(this.D28CECBE);
		this.C3984A91.Controls.Add(this.nudDelayFrom);
		this.C3984A91.Controls.Add(this.B10C2935);
		this.C3984A91.Controls.Add(this.label9);
		this.C3984A91.Controls.Add(this.D802B308);
		this.C3984A91.Controls.Add(this.label6);
		this.C3984A91.Controls.Add(this.label3);
		this.C3984A91.Controls.Add(this.label5);
		this.C3984A91.Controls.Add(this.label1);
		this.C3984A91.Controls.Add(this.D3824E95);
		this.C3984A91.Controls.Add(this.btnAdd);
		this.C3984A91.Controls.Add(this.CF34093B);
		this.C3984A91.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.C3984A91.Dock = System.Windows.Forms.DockStyle.Fill;
		this.C3984A91.Location = new System.Drawing.Point(0, 0);
		this.C3984A91.Name = "panel1";
		this.C3984A91.Size = new System.Drawing.Size(714, 594);
		this.C3984A91.TabIndex = 0;
		this.C3984A91.Click += new System.EventHandler(F38BFAA5);
		this.C3984A91.Paint += new System.Windows.Forms.PaintEventHandler(C3984A91_Paint);
		this.plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plInteract.Controls.Add(this.ckbGian);
		this.plInteract.Controls.Add(this.ckbBuon);
		this.plInteract.Controls.Add(this.F83504BF);
		this.plInteract.Controls.Add(this.D72DA0A1);
		this.plInteract.Controls.Add(this.ckbThuong);
		this.plInteract.Controls.Add(this.ckbTym);
		this.plInteract.Controls.Add(this.ckbLike);
		this.plInteract.Controls.Add(this.panel7);
		this.plInteract.Controls.Add(this.label26);
		this.plInteract.Location = new System.Drawing.Point(371, 98);
		this.plInteract.Name = "plInteract";
		this.plInteract.Size = new System.Drawing.Size(312, 33);
		this.plInteract.TabIndex = 180;
		this.ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbGian.Image = Resources.Bitmap_7;
		this.ckbGian.Location = new System.Drawing.Point(266, 1);
		this.ckbGian.Name = "ckbGian";
		this.ckbGian.Size = new System.Drawing.Size(40, 30);
		this.ckbGian.TabIndex = 179;
		this.ckbGian.UseVisualStyleBackColor = true;
		this.ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBuon.Image = Resources.Bitmap_167;
		this.ckbBuon.Location = new System.Drawing.Point(222, 1);
		this.ckbBuon.Name = "ckbBuon";
		this.ckbBuon.Size = new System.Drawing.Size(40, 30);
		this.ckbBuon.TabIndex = 178;
		this.ckbBuon.UseVisualStyleBackColor = true;
		this.F83504BF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F83504BF.Image = Resources.BBAD6B14;
		this.F83504BF.Location = new System.Drawing.Point(178, 1);
		this.F83504BF.Name = "ckbWow";
		this.F83504BF.Size = new System.Drawing.Size(40, 30);
		this.F83504BF.TabIndex = 177;
		this.F83504BF.UseVisualStyleBackColor = true;
		this.D72DA0A1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D72DA0A1.Image = Resources.Bitmap_34;
		this.D72DA0A1.Location = new System.Drawing.Point(134, 1);
		this.D72DA0A1.Name = "ckbHaha";
		this.D72DA0A1.Size = new System.Drawing.Size(40, 30);
		this.D72DA0A1.TabIndex = 176;
		this.D72DA0A1.UseVisualStyleBackColor = true;
		this.ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbThuong.Image = Resources.Bitmap_14;
		this.ckbThuong.Location = new System.Drawing.Point(90, 1);
		this.ckbThuong.Name = "ckbThuong";
		this.ckbThuong.Size = new System.Drawing.Size(40, 30);
		this.ckbThuong.TabIndex = 175;
		this.ckbThuong.UseVisualStyleBackColor = true;
		this.ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTym.Image = Resources.Bitmap_154;
		this.ckbTym.Location = new System.Drawing.Point(46, 1);
		this.ckbTym.Name = "ckbTym";
		this.ckbTym.Size = new System.Drawing.Size(40, 30);
		this.ckbTym.TabIndex = 174;
		this.ckbTym.UseVisualStyleBackColor = true;
		this.ckbLike.Checked = true;
		this.ckbLike.CheckState = System.Windows.Forms.CheckState.Checked;
		this.ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLike.Image = Resources.B41E983E;
		this.ckbLike.Location = new System.Drawing.Point(2, 1);
		this.ckbLike.Name = "ckbLike";
		this.ckbLike.Size = new System.Drawing.Size(40, 30);
		this.ckbLike.TabIndex = 173;
		this.ckbLike.UseVisualStyleBackColor = true;
		this.panel7.Controls.Add(this.radioButton3);
		this.panel7.Controls.Add(this.radioButton4);
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
		this.radioButton4.AutoSize = true;
		this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton4.Location = new System.Drawing.Point(3, 23);
		this.radioButton4.Name = "radioButton4";
		this.radioButton4.Size = new System.Drawing.Size(200, 20);
		this.radioButton4.TabIndex = 3;
		this.radioButton4.Text = "Comment ngẫu nhiên nội dung";
		this.radioButton4.UseVisualStyleBackColor = true;
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(4, 302);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(64, 16);
		this.label26.TabIndex = 2;
		this.label26.Text = "Tùy chọn:";
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.plCommentText);
		this.plComment.Controls.Add(this.ckbCommentText);
		this.plComment.Controls.Add(this.C29F6396);
		this.plComment.Controls.Add(this.DD24F505);
		this.plComment.Location = new System.Drawing.Point(371, 158);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(312, 313);
		this.plComment.TabIndex = 172;
		this.plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plCommentText.Controls.Add(this.cbbTuyChonNoiDung);
		this.plCommentText.Controls.Add(this.A5326322);
		this.plCommentText.Controls.Add(this.C993F227);
		this.plCommentText.Controls.Add(this.ckbAutoDeleteComment);
		this.plCommentText.Controls.Add(this.linkLabel1);
		this.plCommentText.Controls.Add(this.panel3);
		this.plCommentText.Controls.Add(this.E514D901);
		this.plCommentText.Controls.Add(this.D2BDEBBF);
		this.plCommentText.Controls.Add(this.B52EBE23);
		this.plCommentText.Controls.Add(this.txtComment);
		this.plCommentText.Controls.Add(this.label11);
		this.plCommentText.Controls.Add(this.lblComment);
		this.plCommentText.Location = new System.Drawing.Point(22, 26);
		this.plCommentText.Name = "plCommentText";
		this.plCommentText.Size = new System.Drawing.Size(281, 195);
		this.plCommentText.TabIndex = 164;
		this.cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTuyChonNoiDung.FormattingEnabled = true;
		this.cbbTuyChonNoiDung.Location = new System.Drawing.Point(70, 165);
		this.cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		this.cbbTuyChonNoiDung.Size = new System.Drawing.Size(168, 24);
		this.cbbTuyChonNoiDung.TabIndex = 180;
		this.cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(E032FFB6);
		this.A5326322.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A5326322.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A5326322.Location = new System.Drawing.Point(244, 164);
		this.A5326322.Name = "btnHuongDanNhapNoiDung";
		this.A5326322.Size = new System.Drawing.Size(26, 26);
		this.A5326322.TabIndex = 179;
		this.A5326322.Text = "?";
		this.A5326322.UseVisualStyleBackColor = true;
		this.A5326322.Click += new System.EventHandler(A5326322_Click);
		this.C993F227.AutoSize = true;
		this.C993F227.Location = new System.Drawing.Point(4, 168);
		this.C993F227.Name = "label8";
		this.C993F227.Size = new System.Drawing.Size(64, 16);
		this.C993F227.TabIndex = 178;
		this.C993F227.Text = "Tùy chọn:";
		this.ckbAutoDeleteComment.AutoSize = true;
		this.ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAutoDeleteComment.Location = new System.Drawing.Point(7, 236);
		this.ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		this.ckbAutoDeleteComment.Size = new System.Drawing.Size(225, 20);
		this.ckbAutoDeleteComment.TabIndex = 176;
		this.ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		this.ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(192, 144);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 175;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(FB9F1A89);
		this.panel3.Controls.Add(this.DE893E86);
		this.panel3.Controls.Add(this.rbCommentNgauNhien);
		this.panel3.Location = new System.Drawing.Point(67, 191);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(200, 43);
		this.panel3.TabIndex = 43;
		this.DE893E86.AutoSize = true;
		this.DE893E86.Checked = true;
		this.DE893E86.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE893E86.Location = new System.Drawing.Point(3, 2);
		this.DE893E86.Name = "rbCommentTheoThuTu";
		this.DE893E86.Size = new System.Drawing.Size(201, 20);
		this.DE893E86.TabIndex = 3;
		this.DE893E86.TabStop = true;
		this.DE893E86.Text = "Comment theo thứ tự nội dung";
		this.DE893E86.UseVisualStyleBackColor = true;
		this.DE893E86.CheckedChanged += new System.EventHandler(C73BAB25);
		this.rbCommentNgauNhien.AutoSize = true;
		this.rbCommentNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCommentNgauNhien.Location = new System.Drawing.Point(3, 23);
		this.rbCommentNgauNhien.Name = "rbCommentNgauNhien";
		this.rbCommentNgauNhien.Size = new System.Drawing.Size(200, 20);
		this.rbCommentNgauNhien.TabIndex = 3;
		this.rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
		this.rbCommentNgauNhien.UseVisualStyleBackColor = true;
		this.rbCommentNgauNhien.CheckedChanged += new System.EventHandler(rbCommentNgauNhien_CheckedChanged);
		this.E514D901.BackgroundImage = Resources.Bitmap_83;
		this.E514D901.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E514D901.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.E514D901.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E514D901.Location = new System.Drawing.Point(224, -1);
		this.E514D901.Name = "btnDown";
		this.E514D901.Size = new System.Drawing.Size(25, 25);
		this.E514D901.TabIndex = 40;
		this.E514D901.Visible = false;
		this.E514D901.Click += new System.EventHandler(CDA57738);
		this.D2BDEBBF.BackgroundImage = Resources.E536C319;
		this.D2BDEBBF.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D2BDEBBF.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.D2BDEBBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D2BDEBBF.Location = new System.Drawing.Point(255, -1);
		this.D2BDEBBF.Name = "btnUp";
		this.D2BDEBBF.Size = new System.Drawing.Size(25, 25);
		this.D2BDEBBF.TabIndex = 41;
		this.D2BDEBBF.Visible = false;
		this.D2BDEBBF.Click += new System.EventHandler(D2BDEBBF_Click);
		this.B52EBE23.AutoSize = true;
		this.B52EBE23.Location = new System.Drawing.Point(4, 193);
		this.B52EBE23.Name = "label13";
		this.B52EBE23.Size = new System.Drawing.Size(64, 16);
		this.B52EBE23.TabIndex = 2;
		this.B52EBE23.Text = "Tùy chọn:";
		this.B52EBE23.Click += new System.EventHandler(B52EBE23_Click);
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(263, 115);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(E81DE583);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(4, 144);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(133, 16);
		this.label11.TabIndex = 0;
		this.label11.Text = "Spin nội dung {a|b|c}";
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(3, 5);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(139, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Nội dung bình luận (0):";
		this.ckbCommentText.AutoSize = true;
		this.ckbCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCommentText.Location = new System.Drawing.Point(3, 3);
		this.ckbCommentText.Name = "ckbCommentText";
		this.ckbCommentText.Size = new System.Drawing.Size(127, 20);
		this.ckbCommentText.TabIndex = 165;
		this.ckbCommentText.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.ckbCommentText.UseVisualStyleBackColor = true;
		this.ckbCommentText.CheckedChanged += new System.EventHandler(ckbCommentText_CheckedChanged);
		this.C29F6396.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C29F6396.Controls.Add(this.ckbChiTagTenViet);
		this.C29F6396.Controls.Add(this.nudSoLuongTagTo);
		this.C29F6396.Controls.Add(this.label16);
		this.C29F6396.Controls.Add(this.BC27632B);
		this.C29F6396.Controls.Add(this.label15);
		this.C29F6396.Controls.Add(this.label14);
		this.C29F6396.Location = new System.Drawing.Point(22, 247);
		this.C29F6396.Name = "plTag";
		this.C29F6396.Size = new System.Drawing.Size(258, 60);
		this.C29F6396.TabIndex = 167;
		this.ckbChiTagTenViet.AutoSize = true;
		this.ckbChiTagTenViet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChiTagTenViet.Location = new System.Drawing.Point(6, 33);
		this.ckbChiTagTenViet.Name = "ckbChiTagTenViet";
		this.ckbChiTagTenViet.Size = new System.Drawing.Size(112, 20);
		this.ckbChiTagTenViet.TabIndex = 168;
		this.ckbChiTagTenViet.Text = "Chỉ tag tên việt";
		this.ckbChiTagTenViet.UseVisualStyleBackColor = true;
		this.nudSoLuongTagTo.Location = new System.Drawing.Point(156, 5);
		this.nudSoLuongTagTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudSoLuongTagTo.Name = "nudSoLuongTagTo";
		this.nudSoLuongTagTo.Size = new System.Drawing.Size(51, 23);
		this.nudSoLuongTagTo.TabIndex = 174;
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 7);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(63, 16);
		this.label16.TabIndex = 175;
		this.label16.Text = "Số lượng:";
		this.BC27632B.Location = new System.Drawing.Point(70, 5);
		this.BC27632B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.BC27632B.Name = "nudSoLuongTagFrom";
		this.BC27632B.Size = new System.Drawing.Size(51, 23);
		this.BC27632B.TabIndex = 173;
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(213, 7);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(39, 16);
		this.label15.TabIndex = 176;
		this.label15.Text = "người";
		this.label14.Location = new System.Drawing.Point(125, 7);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(29, 16);
		this.label14.TabIndex = 177;
		this.label14.Text = "đê\u0301n";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DD24F505.AutoSize = true;
		this.DD24F505.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DD24F505.Location = new System.Drawing.Point(3, 225);
		this.DD24F505.Name = "ckbTag";
		this.DD24F505.Size = new System.Drawing.Size(91, 20);
		this.DD24F505.TabIndex = 166;
		this.DD24F505.Text = "Tag bạn bè";
		this.DD24F505.UseVisualStyleBackColor = true;
		this.DD24F505.CheckedChanged += new System.EventHandler(DD24F505_CheckedChanged);
		this.D58CCDA6.AutoSize = true;
		this.D58CCDA6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.D58CCDA6.Location = new System.Drawing.Point(27, 108);
		this.D58CCDA6.Name = "label49";
		this.D58CCDA6.Size = new System.Drawing.Size(107, 16);
		this.D58CCDA6.TabIndex = 169;
		this.D58CCDA6.Text = "Sô\u0301 lươ\u0323ng ID/Nick:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(134, 106);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 167;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
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
		this.E63A3C1B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E63A3C1B.Location = new System.Drawing.Point(196, 108);
		this.E63A3C1B.Name = "label66";
		this.E63A3C1B.Size = new System.Drawing.Size(29, 16);
		this.E63A3C1B.TabIndex = 171;
		this.E63A3C1B.Text = "đê\u0301n";
		this.E63A3C1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.txtAnh);
		this.plAnh.Controls.Add(this.B506AAB6);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(371, 501);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(312, 31);
		this.plAnh.TabIndex = 166;
		this.txtAnh.Location = new System.Drawing.Point(74, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(233, 23);
		this.txtAnh.TabIndex = 155;
		this.B506AAB6.AutoSize = true;
		this.B506AAB6.Location = new System.Drawing.Point(3, 6);
		this.B506AAB6.Name = "label12";
		this.B506AAB6.Size = new System.Drawing.Size(73, 16);
		this.B506AAB6.TabIndex = 39;
		this.B506AAB6.Text = "Folder ảnh:";
		this.B506AAB6.Click += new System.EventHandler(C6A49C19);
		this.A29D2B2C.Location = new System.Drawing.Point(30, 152);
		this.A29D2B2C.Name = "txtIdPost";
		this.A29D2B2C.Size = new System.Drawing.Size(297, 380);
		this.A29D2B2C.TabIndex = 1;
		this.A29D2B2C.Text = "";
		this.A29D2B2C.WordWrap = false;
		this.A29D2B2C.TextChanged += new System.EventHandler(A29D2B2C_TextChanged);
		this.AB13889A.AutoSize = true;
		this.AB13889A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AB13889A.Location = new System.Drawing.Point(353, 477);
		this.AB13889A.Name = "ckbSendAnh";
		this.AB13889A.Size = new System.Drawing.Size(103, 20);
		this.AB13889A.TabIndex = 165;
		this.AB13889A.Text = "Bình luận ảnh";
		this.AB13889A.UseVisualStyleBackColor = true;
		this.AB13889A.CheckedChanged += new System.EventHandler(AB13889A_CheckedChanged);
		this.ckbComment.AutoSize = true;
		this.ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbComment.Location = new System.Drawing.Point(353, 136);
		this.ckbComment.Name = "ckbComment";
		this.ckbComment.Size = new System.Drawing.Size(78, 20);
		this.ckbComment.TabIndex = 163;
		this.ckbComment.Text = "Bi\u0300nh luâ\u0323n";
		this.ckbComment.UseVisualStyleBackColor = true;
		this.ckbComment.CheckedChanged += new System.EventHandler(D10A3803);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(27, 132);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(180, 16);
		this.label2.TabIndex = 40;
		this.label2.Text = "Danh sa\u0301ch ID/Link bài viết (0):";
		this.EEAF513B.AutoSize = true;
		this.EEAF513B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EEAF513B.Location = new System.Drawing.Point(547, 136);
		this.EEAF513B.Name = "ckbShareWall";
		this.EEAF513B.Size = new System.Drawing.Size(143, 20);
		this.EEAF513B.TabIndex = 6;
		this.EEAF513B.Text = "Chia sẻ bài về tường";
		this.EEAF513B.UseVisualStyleBackColor = true;
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(353, 79);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(93, 20);
		this.ckbInteract.TabIndex = 5;
		this.ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		this.nudTimeTo.Location = new System.Drawing.Point(586, 50);
		this.nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeTo.Name = "nudTimeTo";
		this.nudTimeTo.Size = new System.Drawing.Size(51, 23);
		this.nudTimeTo.TabIndex = 4;
		this.nudDelayTo.Location = new System.Drawing.Point(231, 78);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 4;
		this.D28CECBE.Location = new System.Drawing.Point(508, 50);
		this.D28CECBE.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D28CECBE.Name = "nudTimeFrom";
		this.D28CECBE.Size = new System.Drawing.Size(51, 23);
		this.D28CECBE.TabIndex = 3;
		this.nudDelayFrom.Location = new System.Drawing.Point(134, 78);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 3;
		this.B10C2935.Location = new System.Drawing.Point(134, 49);
		this.B10C2935.Name = "txtTenHanhDong";
		this.B10C2935.Size = new System.Drawing.Size(194, 23);
		this.B10C2935.TabIndex = 0;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new System.Drawing.Point(559, 52);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(29, 16);
		this.label9.TabIndex = 38;
		this.label9.Text = ">";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.D802B308.Location = new System.Drawing.Point(196, 80);
		this.D802B308.Name = "label7";
		this.D802B308.Size = new System.Drawing.Size(29, 16);
		this.D802B308.TabIndex = 38;
		this.D802B308.Text = "đê\u0301n";
		this.D802B308.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(289, 80);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(30, 16);
		this.label6.TabIndex = 36;
		this.label6.Text = "giây";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(350, 52);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(158, 16);
		this.label3.TabIndex = 34;
		this.label3.Text = "Thơ\u0300i gian xem bài viết (s):";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(27, 80);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(89, 16);
		this.label5.TabIndex = 34;
		this.label5.Text = "Thơ\u0300i gian chờ:";
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(27, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(98, 16);
		this.label1.TabIndex = 31;
		this.label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.D3824E95.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.D3824E95.BackColor = System.Drawing.Color.Maroon;
		this.D3824E95.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D3824E95.FlatAppearance.BorderSize = 0;
		this.D3824E95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D3824E95.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D3824E95.ForeColor = System.Drawing.Color.White;
		this.D3824E95.Location = new System.Drawing.Point(349, 552);
		this.D3824E95.Name = "btnCancel";
		this.D3824E95.Size = new System.Drawing.Size(92, 29);
		this.D3824E95.TabIndex = 10;
		this.D3824E95.Text = "Đóng";
		this.D3824E95.UseVisualStyleBackColor = false;
		this.D3824E95.Click += new System.EventHandler(D3824E95_Click);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(242, 552);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Thêm";
		this.btnAdd.UseVisualStyleBackColor = false;
		this.btnAdd.Click += new System.EventHandler(btnAdd_Click);
		this.CF34093B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.CF34093B.BackColor = System.Drawing.Color.White;
		this.CF34093B.BorderRadius = 0;
		this.CF34093B.BottomSahddow = true;
		this.CF34093B.color = System.Drawing.Color.DarkViolet;
		this.CF34093B.Controls.Add(this.D1A20F14);
		this.CF34093B.LeftSahddow = false;
		this.CF34093B.Location = new System.Drawing.Point(1, 0);
		this.CF34093B.Name = "bunifuCards1";
		this.CF34093B.RightSahddow = true;
		this.CF34093B.ShadowDepth = 20;
		this.CF34093B.Size = new System.Drawing.Size(711, 37);
		this.CF34093B.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(714, 594);
		base.Controls.Add(this.C3984A91);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChaySpam";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AD29E0B6);
		this.D1A20F14.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.EC9548B9).EndInit();
		this.C3984A91.ResumeLayout(false);
		this.C3984A91.PerformLayout();
		this.plInteract.ResumeLayout(false);
		this.plInteract.PerformLayout();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plCommentText.ResumeLayout(false);
		this.plCommentText.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		this.C29F6396.ResumeLayout(false);
		this.C29F6396.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongTagTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.BC27632B).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D28CECBE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.CF34093B.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
