using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDSpamBaiViet : Form
{
	private JSON_Settings B59F4A06;

	private string E32BD006;

	private string string_0;

	private string EC286B30;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl EA017CAE;

	private Panel F1A8618C;

	private NumericUpDown nudDelayTo;

	private NumericUpDown F9132F2A;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox txtTenHanhDong;

	private Label D2166313;

	private Label label3;

	private Label FC8A718A;

	private Label FF916633;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button C72571BA;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private Label lblComment;

	private CheckBox B9367306;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label19;

	private NumericUpDown nudSoLuongUidTo;

	private Label label66;

	private RichTextBox CE232426;

	private Panel A232E33C;

	private CheckBox ckbSendAnh;

	private RichTextBox txtComment;

	private CheckBox ckbTuDongXoaUid;

	private TextBox txtAnh;

	private Label C9378F12;

	private CheckBox C7B81F02;

	private Button F3B3A78B;

	private Button DE89E084;

	private Panel A0B9ED3B;

	private NumericUpDown nudBoQuaTo;

	private NumericUpDown nudBoQuaFrom;

	private Label label8;

	private Label label11;

	private CheckBox B529EEAA;

	private CheckBox ckbTuDongThamGiaNhom;

	private CheckBox F8A8D793;

	private Panel DD872728;

	private CheckBox ckbGian;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label label26;

	private Label label10;

	private Label F898079B;

	private ComboBox B400D30F;

	private Button C41C5A15;

	private Label E209CA31;

	private ComboBox cbbLoaiDoiTuong;

	private CheckBox ckbRunAPI;

	public fHDSpamBaiViet(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E32BD006 = string_1;
		EC286B30 = string_2;
		int_0 = int_1;
		string text = "HDSpamBaiViet";
		string text2 = "Spam bài viết";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B59F4A06 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
		list_0 = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, ckbWow, ckbBuon, ckbGian };
	}

	private void fHDSpamBaiViet_Load(object sender, EventArgs e)
	{
		AA881D38();
		try
		{
			nudSoLuongUidFrom.Value = B59F4A06.GetValueInt("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = B59F4A06.GetValueInt("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = B59F4A06.GetValueInt("nudSoLuongBaiVietFrom", 1);
			F9132F2A.Value = B59F4A06.GetValueInt("nudSoLuongBaiVietTo", 1);
			nudDelayFrom.Value = B59F4A06.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = B59F4A06.GetValueInt("nudDelayTo", 5);
			cbbLoaiDoiTuong.SelectedIndex = B59F4A06.GetValueInt("typeID", 1);
			CE232426.Text = B59F4A06.GetValue("txtUid");
			ckbInteract.Checked = B59F4A06.GetValueBool("ckbInteract");
			string text = B59F4A06.GetValue("typeReaction", "0");
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Split('|').Contains(i.ToString());
			}
			ckbShareWall.Checked = B59F4A06.GetValueBool("ckbShareWall");
			ckbRunAPI.Checked = B59F4A06.GetValueBool("ckbRunAPI");
			B9367306.Checked = B59F4A06.GetValueBool("ckbComment");
			txtComment.Text = B59F4A06.GetValue("txtComment");
			ckbSendAnh.Checked = B59F4A06.GetValueBool("ckbSendAnh");
			txtAnh.Text = B59F4A06.GetValue("txtAnh");
			ckbTuDongXoaUid.Checked = B59F4A06.GetValueBool("ckbTuDongXoaUid");
			F8A8D793.Checked = B59F4A06.GetValueBool("ckbKhongCommentTrungBaiCu");
			B529EEAA.Checked = B59F4A06.GetValueBool("ckbBoQua");
			nudBoQuaFrom.Value = B59F4A06.GetValueInt("nudBoQuaFrom", 1);
			nudBoQuaTo.Value = B59F4A06.GetValueInt("nudBoQuaTo", 1);
			ckbTuDongThamGiaNhom.Checked = B59F4A06.GetValueBool("ckbTuDongThamGiaNhom");
			B400D30F.SelectedIndex = B59F4A06.GetValueInt("typeNganCach");
		}
		catch
		{
		}
		method_0();
	}

	private void AA881D38()
	{
		List<string> e6A5AC = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.F714B10E(B400D30F, e6A5AC);
	}

	private void C72571BA_Click(object sender, EventArgs e)
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
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.GetJson("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.GetJson("nudSoLuongBaiVietTo", F9132F2A.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("typeListUid", 0);
		gClass.GetJson("typeID", cbbLoaiDoiTuong.SelectedIndex);
		gClass.GetJson("txtUid", CE232426.Text.Trim());
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
		gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
		gClass.GetJson("ckbComment", B9367306.Checked);
		gClass.GetJson("ckbRunAPI", ckbRunAPI.Checked);
		gClass.GetJson("ckbAutoDeleteComment", C7B81F02.Checked);
		gClass.GetJson("txtComment", txtComment.Text.Trim());
		gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.GetJson("ckbKhongCommentTrungBaiCu", F8A8D793.Checked);
		gClass.GetJson("ckbBoQua", B529EEAA.Checked);
		gClass.GetJson("nudBoQuaFrom", nudBoQuaFrom.Value);
		gClass.GetJson("nudBoQuaTo", nudBoQuaTo.Value);
		gClass.GetJson("ckbTuDongThamGiaNhom", ckbTuDongThamGiaNhom.Checked);
		gClass.GetJson("typeNganCach", B400D30F.SelectedIndex);
		string text3 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(E32BD006, text, string_0, text3))
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
			if (InteractSQL.smethod_13(EC286B30, text, text3))
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

	private void BA339232(object sender, PaintEventArgs e)
	{
		if (F1A8618C.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F1A8618C.ClientSize.Width - num, F1A8618C.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, lblComment, B400D30F.SelectedIndex);
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		B9367306_CheckedChanged(null, null);
		B529EEAA_CheckedChanged(null, null);
		ckbRunAPI_CheckedChanged(null, null);
	}

	private void B9367306_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = B9367306.Checked;
	}

	private void D90DCD96(object sender, EventArgs e)
	{
		Common.F9202C12(CE232426, F898079B);
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		A232E33C.Enabled = ckbSendAnh.Checked;
	}

	private void A90D1E0A(object sender, EventArgs e)
	{
		plComment.Height = 211;
	}

	private void DE89E084_Click(object sender, EventArgs e)
	{
		plComment.Height = 188;
	}

	private void B529EEAA_CheckedChanged(object sender, EventArgs e)
	{
		A0B9ED3B.Enabled = B529EEAA.Checked;
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		DD872728.Enabled = ckbInteract.Checked;
	}

	private void B400D30F_SelectedIndexChanged(object sender, EventArgs e)
	{
		Common.F9202C12(txtComment, lblComment, B400D30F.SelectedIndex);
	}

	private void B52D4324(object sender, EventArgs e)
	{
		if (B400D30F.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.ShowForm(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void ckbRunAPI_CheckedChanged(object sender, EventArgs e)
	{
		ckbInteract.Enabled = !ckbRunAPI.Checked;
		ckbShareWall.Enabled = !ckbRunAPI.Checked;
		ckbSendAnh.Enabled = !ckbRunAPI.Checked;
		if (ckbRunAPI.Checked)
		{
			ckbInteract.Checked = false;
			ckbShareWall.Checked = false;
			ckbSendAnh.Checked = false;
		}
	}

	protected override void Dispose(bool FC287D11)
	{
		if (FC287D11 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FC287D11);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSpamBaiViet));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.EA017CAE = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.C72571BA = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.F1A8618C = new System.Windows.Forms.Panel();
		this.cbbLoaiDoiTuong = new System.Windows.Forms.ComboBox();
		this.plComment = new System.Windows.Forms.Panel();
		this.B400D30F = new System.Windows.Forms.ComboBox();
		this.C41C5A15 = new System.Windows.Forms.Button();
		this.E209CA31 = new System.Windows.Forms.Label();
		this.F3B3A78B = new System.Windows.Forms.Button();
		this.DE89E084 = new System.Windows.Forms.Button();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblComment = new System.Windows.Forms.Label();
		this.C7B81F02 = new System.Windows.Forms.CheckBox();
		this.label10 = new System.Windows.Forms.Label();
		this.F898079B = new System.Windows.Forms.Label();
		this.DD872728 = new System.Windows.Forms.Panel();
		this.ckbGian = new System.Windows.Forms.CheckBox();
		this.ckbBuon = new System.Windows.Forms.CheckBox();
		this.ckbWow = new System.Windows.Forms.CheckBox();
		this.ckbHaha = new System.Windows.Forms.CheckBox();
		this.ckbThuong = new System.Windows.Forms.CheckBox();
		this.ckbTym = new System.Windows.Forms.CheckBox();
		this.ckbLike = new System.Windows.Forms.CheckBox();
		this.panel7 = new System.Windows.Forms.Panel();
		this.radioButton3 = new System.Windows.Forms.RadioButton();
		this.radioButton4 = new System.Windows.Forms.RadioButton();
		this.label26 = new System.Windows.Forms.Label();
		this.ckbTuDongThamGiaNhom = new System.Windows.Forms.CheckBox();
		this.A0B9ED3B = new System.Windows.Forms.Panel();
		this.nudBoQuaTo = new System.Windows.Forms.NumericUpDown();
		this.nudBoQuaFrom = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.label11 = new System.Windows.Forms.Label();
		this.B529EEAA = new System.Windows.Forms.CheckBox();
		this.A232E33C = new System.Windows.Forms.Panel();
		this.txtAnh = new System.Windows.Forms.TextBox();
		this.C9378F12 = new System.Windows.Forms.Label();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.CE232426 = new System.Windows.Forms.RichTextBox();
		this.label49 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.label19 = new System.Windows.Forms.Label();
		this.nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		this.label66 = new System.Windows.Forms.Label();
		this.B9367306 = new System.Windows.Forms.CheckBox();
		this.F8A8D793 = new System.Windows.Forms.CheckBox();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.ckbShareWall = new System.Windows.Forms.CheckBox();
		this.ckbInteract = new System.Windows.Forms.CheckBox();
		this.nudDelayTo = new System.Windows.Forms.NumericUpDown();
		this.F9132F2A = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.D2166313 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.FC8A718A = new System.Windows.Forms.Label();
		this.FF916633 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.ckbRunAPI = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.F1A8618C.SuspendLayout();
		this.plComment.SuspendLayout();
		this.DD872728.SuspendLayout();
		this.panel7.SuspendLayout();
		this.A0B9ED3B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaFrom).BeginInit();
		this.A232E33C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F9132F2A).BeginInit();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(663, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Spam bài viết";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.EA017CAE.Fixed = true;
		this.EA017CAE.Horizontal = true;
		this.EA017CAE.TargetControl = this.pnlHeader;
		this.EA017CAE.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.C72571BA);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(663, 31);
		this.pnlHeader.TabIndex = 9;
		this.C72571BA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C72571BA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C72571BA.FlatAppearance.BorderSize = 0;
		this.C72571BA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C72571BA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C72571BA.ForeColor = System.Drawing.Color.White;
		this.C72571BA.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.C72571BA.Location = new System.Drawing.Point(632, 1);
		this.C72571BA.Name = "button1";
		this.C72571BA.Size = new System.Drawing.Size(30, 30);
		this.C72571BA.TabIndex = 77;
		this.C72571BA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.C72571BA.UseVisualStyleBackColor = true;
		this.C72571BA.Click += new System.EventHandler(C72571BA_Click);
		this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(3, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 76;
		this.pictureBox1.TabStop = false;
		this.F1A8618C.BackColor = System.Drawing.Color.White;
		this.F1A8618C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F1A8618C.Controls.Add(this.cbbLoaiDoiTuong);
		this.F1A8618C.Controls.Add(this.plComment);
		this.F1A8618C.Controls.Add(this.label10);
		this.F1A8618C.Controls.Add(this.F898079B);
		this.F1A8618C.Controls.Add(this.DD872728);
		this.F1A8618C.Controls.Add(this.ckbTuDongThamGiaNhom);
		this.F1A8618C.Controls.Add(this.A0B9ED3B);
		this.F1A8618C.Controls.Add(this.B529EEAA);
		this.F1A8618C.Controls.Add(this.A232E33C);
		this.F1A8618C.Controls.Add(this.ckbSendAnh);
		this.F1A8618C.Controls.Add(this.CE232426);
		this.F1A8618C.Controls.Add(this.label49);
		this.F1A8618C.Controls.Add(this.nudSoLuongUidFrom);
		this.F1A8618C.Controls.Add(this.label19);
		this.F1A8618C.Controls.Add(this.nudSoLuongUidTo);
		this.F1A8618C.Controls.Add(this.label66);
		this.F1A8618C.Controls.Add(this.B9367306);
		this.F1A8618C.Controls.Add(this.F8A8D793);
		this.F1A8618C.Controls.Add(this.ckbTuDongXoaUid);
		this.F1A8618C.Controls.Add(this.ckbShareWall);
		this.F1A8618C.Controls.Add(this.ckbInteract);
		this.F1A8618C.Controls.Add(this.nudDelayTo);
		this.F1A8618C.Controls.Add(this.F9132F2A);
		this.F1A8618C.Controls.Add(this.nudDelayFrom);
		this.F1A8618C.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.F1A8618C.Controls.Add(this.txtTenHanhDong);
		this.F1A8618C.Controls.Add(this.D2166313);
		this.F1A8618C.Controls.Add(this.label3);
		this.F1A8618C.Controls.Add(this.FC8A718A);
		this.F1A8618C.Controls.Add(this.FF916633);
		this.F1A8618C.Controls.Add(this.btnCancel);
		this.F1A8618C.Controls.Add(this.btnAdd);
		this.F1A8618C.Controls.Add(this.bunifuCards1);
		this.F1A8618C.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.F1A8618C.Dock = System.Windows.Forms.DockStyle.Fill;
		this.F1A8618C.Location = new System.Drawing.Point(0, 0);
		this.F1A8618C.Name = "panel1";
		this.F1A8618C.Size = new System.Drawing.Size(666, 499);
		this.F1A8618C.TabIndex = 0;
		this.F1A8618C.Paint += new System.Windows.Forms.PaintEventHandler(BA339232);
		this.cbbLoaiDoiTuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbLoaiDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbLoaiDoiTuong.FormattingEnabled = true;
		this.cbbLoaiDoiTuong.Items.AddRange(new object[3] { "Profile", "Group", "Page" });
		this.cbbLoaiDoiTuong.Location = new System.Drawing.Point(135, 164);
		this.cbbLoaiDoiTuong.Name = "cbbLoaiDoiTuong";
		this.cbbLoaiDoiTuong.Size = new System.Drawing.Size(153, 24);
		this.cbbLoaiDoiTuong.TabIndex = 195;
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.ckbRunAPI);
		this.plComment.Controls.Add(this.B400D30F);
		this.plComment.Controls.Add(this.C41C5A15);
		this.plComment.Controls.Add(this.E209CA31);
		this.plComment.Controls.Add(this.F3B3A78B);
		this.plComment.Controls.Add(this.DE89E084);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.lblComment);
		this.plComment.Controls.Add(this.C7B81F02);
		this.plComment.Location = new System.Drawing.Point(320, 164);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(313, 188);
		this.plComment.TabIndex = 10;
		this.B400D30F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B400D30F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B400D30F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.B400D30F.FormattingEnabled = true;
		this.B400D30F.Location = new System.Drawing.Point(69, 158);
		this.B400D30F.Name = "cbbTuyChonNoiDung";
		this.B400D30F.Size = new System.Drawing.Size(204, 24);
		this.B400D30F.TabIndex = 195;
		this.B400D30F.SelectedIndexChanged += new System.EventHandler(B400D30F_SelectedIndexChanged);
		this.C41C5A15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.C41C5A15.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C41C5A15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C41C5A15.Location = new System.Drawing.Point(279, 157);
		this.C41C5A15.Name = "btnHuongDanNhapNoiDung";
		this.C41C5A15.Size = new System.Drawing.Size(26, 26);
		this.C41C5A15.TabIndex = 194;
		this.C41C5A15.Text = "?";
		this.C41C5A15.UseVisualStyleBackColor = true;
		this.C41C5A15.Click += new System.EventHandler(B52D4324);
		this.E209CA31.AutoSize = true;
		this.E209CA31.Location = new System.Drawing.Point(3, 161);
		this.E209CA31.Name = "label2";
		this.E209CA31.Size = new System.Drawing.Size(64, 16);
		this.E209CA31.TabIndex = 193;
		this.E209CA31.Text = "Tùy chọn:";
		this.F3B3A78B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.F3B3A78B.BackgroundImage = Resources.Bitmap_83;
		this.F3B3A78B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F3B3A78B.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.F3B3A78B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F3B3A78B.Location = new System.Drawing.Point(256, -1);
		this.F3B3A78B.Name = "btnDown";
		this.F3B3A78B.Size = new System.Drawing.Size(25, 25);
		this.F3B3A78B.TabIndex = 191;
		this.F3B3A78B.Visible = false;
		this.F3B3A78B.Click += new System.EventHandler(A90D1E0A);
		this.DE89E084.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.DE89E084.BackgroundImage = Resources.E536C319;
		this.DE89E084.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE89E084.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.DE89E084.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.DE89E084.Location = new System.Drawing.Point(287, -1);
		this.DE89E084.Name = "btnUp";
		this.DE89E084.Size = new System.Drawing.Size(25, 25);
		this.DE89E084.TabIndex = 192;
		this.DE89E084.Visible = false;
		this.DE89E084.Click += new System.EventHandler(DE89E084_Click);
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(298, 128);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(3, 5);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(139, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Nội dung bình luận (0):";
		this.C7B81F02.AutoSize = true;
		this.C7B81F02.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C7B81F02.Location = new System.Drawing.Point(7, 186);
		this.C7B81F02.Name = "ckbAutoDeleteComment";
		this.C7B81F02.Size = new System.Drawing.Size(169, 20);
		this.C7B81F02.TabIndex = 8;
		this.C7B81F02.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		this.C7B81F02.UseVisualStyleBackColor = true;
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(27, 167);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(93, 16);
		this.label10.TabIndex = 186;
		this.label10.Text = "Loại đối tượng:";
		this.F898079B.AutoSize = true;
		this.F898079B.Location = new System.Drawing.Point(27, 191);
		this.F898079B.Name = "lblUid";
		this.F898079B.Size = new System.Drawing.Size(140, 16);
		this.F898079B.TabIndex = 182;
		this.F898079B.Text = "Nhập danh sách ID (0):";
		this.DD872728.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DD872728.Controls.Add(this.ckbGian);
		this.DD872728.Controls.Add(this.ckbBuon);
		this.DD872728.Controls.Add(this.ckbWow);
		this.DD872728.Controls.Add(this.ckbHaha);
		this.DD872728.Controls.Add(this.ckbThuong);
		this.DD872728.Controls.Add(this.ckbTym);
		this.DD872728.Controls.Add(this.ckbLike);
		this.DD872728.Controls.Add(this.panel7);
		this.DD872728.Controls.Add(this.label26);
		this.DD872728.Location = new System.Drawing.Point(320, 103);
		this.DD872728.Name = "plInteract";
		this.DD872728.Size = new System.Drawing.Size(312, 33);
		this.DD872728.TabIndex = 181;
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
		this.ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbWow.Image = Resources.BBAD6B14;
		this.ckbWow.Location = new System.Drawing.Point(178, 1);
		this.ckbWow.Name = "ckbWow";
		this.ckbWow.Size = new System.Drawing.Size(40, 30);
		this.ckbWow.TabIndex = 177;
		this.ckbWow.UseVisualStyleBackColor = true;
		this.ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbHaha.Image = Resources.Bitmap_34;
		this.ckbHaha.Location = new System.Drawing.Point(134, 1);
		this.ckbHaha.Name = "ckbHaha";
		this.ckbHaha.Size = new System.Drawing.Size(40, 30);
		this.ckbHaha.TabIndex = 176;
		this.ckbHaha.UseVisualStyleBackColor = true;
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
		this.ckbTuDongThamGiaNhom.AutoSize = true;
		this.ckbTuDongThamGiaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongThamGiaNhom.Location = new System.Drawing.Point(320, 418);
		this.ckbTuDongThamGiaNhom.Name = "ckbTuDongThamGiaNhom";
		this.ckbTuDongThamGiaNhom.Size = new System.Drawing.Size(286, 20);
		this.ckbTuDongThamGiaNhom.TabIndex = 167;
		this.ckbTuDongThamGiaNhom.Text = "Tự động tham gia nhóm (Nếu chưa tham gia)";
		this.ckbTuDongThamGiaNhom.UseVisualStyleBackColor = true;
		this.ckbTuDongThamGiaNhom.Visible = false;
		this.A0B9ED3B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A0B9ED3B.Controls.Add(this.nudBoQuaTo);
		this.A0B9ED3B.Controls.Add(this.nudBoQuaFrom);
		this.A0B9ED3B.Controls.Add(this.label8);
		this.A0B9ED3B.Controls.Add(this.label11);
		this.A0B9ED3B.Location = new System.Drawing.Point(97, 384);
		this.A0B9ED3B.Name = "panel2";
		this.A0B9ED3B.Size = new System.Drawing.Size(191, 29);
		this.A0B9ED3B.TabIndex = 166;
		this.nudBoQuaTo.Location = new System.Drawing.Point(72, 2);
		this.nudBoQuaTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudBoQuaTo.Name = "nudBoQuaTo";
		this.nudBoQuaTo.Size = new System.Drawing.Size(35, 23);
		this.nudBoQuaTo.TabIndex = 40;
		this.nudBoQuaFrom.Location = new System.Drawing.Point(2, 2);
		this.nudBoQuaFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudBoQuaFrom.Name = "nudBoQuaFrom";
		this.nudBoQuaFrom.Size = new System.Drawing.Size(35, 23);
		this.nudBoQuaFrom.TabIndex = 39;
		this.label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.Location = new System.Drawing.Point(39, 4);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(29, 16);
		this.label8.TabIndex = 42;
		this.label8.Text = ">";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(113, 4);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(73, 16);
		this.label11.TabIndex = 41;
		this.label11.Text = "bài viết đầu";
		this.B529EEAA.AutoSize = true;
		this.B529EEAA.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B529EEAA.Location = new System.Drawing.Point(31, 388);
		this.B529EEAA.Name = "ckbBoQua";
		this.B529EEAA.Size = new System.Drawing.Size(70, 20);
		this.B529EEAA.TabIndex = 164;
		this.B529EEAA.Text = "Bỏ qua:";
		this.B529EEAA.UseVisualStyleBackColor = true;
		this.B529EEAA.CheckedChanged += new System.EventHandler(B529EEAA_CheckedChanged);
		this.A232E33C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A232E33C.Controls.Add(this.txtAnh);
		this.A232E33C.Controls.Add(this.C9378F12);
		this.A232E33C.Enabled = false;
		this.A232E33C.Location = new System.Drawing.Point(320, 381);
		this.A232E33C.Name = "plAnh";
		this.A232E33C.Size = new System.Drawing.Size(313, 31);
		this.A232E33C.TabIndex = 162;
		this.txtAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtAnh.Location = new System.Drawing.Point(90, 3);
		this.txtAnh.Name = "txtAnh";
		this.txtAnh.Size = new System.Drawing.Size(218, 23);
		this.txtAnh.TabIndex = 159;
		this.C9378F12.AutoSize = true;
		this.C9378F12.Location = new System.Drawing.Point(3, 6);
		this.C9378F12.Name = "label12";
		this.C9378F12.Size = new System.Drawing.Size(73, 16);
		this.C9378F12.TabIndex = 158;
		this.C9378F12.Text = "Folder ảnh:";
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(320, 358);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		this.ckbSendAnh.TabIndex = 161;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		this.CE232426.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.CE232426.Location = new System.Drawing.Point(31, 210);
		this.CE232426.Name = "txtUid";
		this.CE232426.Size = new System.Drawing.Size(257, 144);
		this.CE232426.TabIndex = 117;
		this.CE232426.Text = "";
		this.CE232426.WordWrap = false;
		this.CE232426.TextChanged += new System.EventHandler(D90DCD96);
		this.label49.AutoSize = true;
		this.label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label49.Location = new System.Drawing.Point(27, 81);
		this.label49.Name = "label49";
		this.label49.Size = new System.Drawing.Size(79, 16);
		this.label49.TabIndex = 92;
		this.label49.Text = "Sô\u0301 lươ\u0323ng ID:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(135, 79);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 1;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label19.Location = new System.Drawing.Point(27, 110);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(89, 16);
		this.label19.TabIndex = 101;
		this.label19.Text = "Sô\u0301 ba\u0300i viết/ID:";
		this.nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidTo.Location = new System.Drawing.Point(232, 79);
		this.nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		this.nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidTo.TabIndex = 2;
		this.nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label66.Location = new System.Drawing.Point(197, 81);
		this.label66.Name = "label66";
		this.label66.Size = new System.Drawing.Size(29, 16);
		this.label66.TabIndex = 105;
		this.label66.Text = ">";
		this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.B9367306.AutoSize = true;
		this.B9367306.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B9367306.Location = new System.Drawing.Point(320, 141);
		this.B9367306.Name = "ckbComment";
		this.B9367306.Size = new System.Drawing.Size(127, 20);
		this.B9367306.TabIndex = 9;
		this.B9367306.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.B9367306.UseVisualStyleBackColor = true;
		this.B9367306.CheckedChanged += new System.EventHandler(B9367306_CheckedChanged);
		this.F8A8D793.AutoSize = true;
		this.F8A8D793.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F8A8D793.Location = new System.Drawing.Point(31, 418);
		this.F8A8D793.Name = "ckbKhongCommentTrungBaiCu";
		this.F8A8D793.Size = new System.Drawing.Size(190, 20);
		this.F8A8D793.TabIndex = 8;
		this.F8A8D793.Text = "Không comment trùng bài cũ";
		this.F8A8D793.UseVisualStyleBackColor = true;
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 360);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(190, 20);
		this.ckbTuDongXoaUid.TabIndex = 8;
		this.ckbTuDongXoaUid.Text = "Tự động xóa ID đã tương tác";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.ckbShareWall.AutoSize = true;
		this.ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareWall.Location = new System.Drawing.Point(553, 141);
		this.ckbShareWall.Name = "ckbShareWall";
		this.ckbShareWall.Size = new System.Drawing.Size(87, 20);
		this.ckbShareWall.TabIndex = 8;
		this.ckbShareWall.Text = "Share wall";
		this.ckbShareWall.UseVisualStyleBackColor = true;
		this.ckbInteract.AutoSize = true;
		this.ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbInteract.Location = new System.Drawing.Point(321, 80);
		this.ckbInteract.Name = "ckbInteract";
		this.ckbInteract.Size = new System.Drawing.Size(93, 20);
		this.ckbInteract.TabIndex = 7;
		this.ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		this.ckbInteract.UseVisualStyleBackColor = true;
		this.ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		this.nudDelayTo.Location = new System.Drawing.Point(232, 137);
		this.nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayTo.Name = "nudDelayTo";
		this.nudDelayTo.Size = new System.Drawing.Size(56, 23);
		this.nudDelayTo.TabIndex = 6;
		this.F9132F2A.Location = new System.Drawing.Point(232, 108);
		this.F9132F2A.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.F9132F2A.Name = "nudSoLuongBaiVietTo";
		this.F9132F2A.Size = new System.Drawing.Size(56, 23);
		this.F9132F2A.TabIndex = 4;
		this.nudDelayFrom.Location = new System.Drawing.Point(135, 137);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 5;
		this.nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 108);
		this.nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		this.nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongBaiVietFrom.TabIndex = 3;
		this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.D2166313.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D2166313.Location = new System.Drawing.Point(197, 139);
		this.D2166313.Name = "label7";
		this.D2166313.Size = new System.Drawing.Size(29, 16);
		this.D2166313.TabIndex = 38;
		this.D2166313.Text = ">";
		this.D2166313.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new System.Drawing.Point(197, 110);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(29, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = ">";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FC8A718A.AutoSize = true;
		this.FC8A718A.Location = new System.Drawing.Point(27, 139);
		this.FC8A718A.Name = "label5";
		this.FC8A718A.Size = new System.Drawing.Size(87, 16);
		this.FC8A718A.TabIndex = 34;
		this.FC8A718A.Text = "Gia\u0303n ca\u0301ch (s):";
		this.FF916633.AutoSize = true;
		this.FF916633.Location = new System.Drawing.Point(27, 52);
		this.FF916633.Name = "label1";
		this.FF916633.Size = new System.Drawing.Size(98, 16);
		this.FF916633.TabIndex = 31;
		this.FF916633.Text = "Tên ha\u0300nh đô\u0323ng:";
		this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(342, 454);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 12;
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
		this.btnAdd.Location = new System.Drawing.Point(235, 454);
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
		this.bunifuCards1.Size = new System.Drawing.Size(663, 37);
		this.bunifuCards1.TabIndex = 28;
		this.ckbRunAPI.AutoSize = true;
		this.ckbRunAPI.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRunAPI.Location = new System.Drawing.Point(178, 4);
		this.ckbRunAPI.Name = "ckbRunAPI";
		this.ckbRunAPI.Size = new System.Drawing.Size(71, 20);
		this.ckbRunAPI.TabIndex = 196;
		this.ckbRunAPI.Text = "Run API";
		this.ckbRunAPI.UseVisualStyleBackColor = true;
		this.ckbRunAPI.Visible = false;
		this.ckbRunAPI.CheckedChanged += new System.EventHandler(ckbRunAPI_CheckedChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(666, 499);
		base.Controls.Add(this.F1A8618C);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDSpamBaiViet_Load);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.F1A8618C.ResumeLayout(false);
		this.F1A8618C.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.DD872728.ResumeLayout(false);
		this.DD872728.PerformLayout();
		this.panel7.ResumeLayout(false);
		this.panel7.PerformLayout();
		this.A0B9ED3B.ResumeLayout(false);
		this.A0B9ED3B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudBoQuaFrom).EndInit();
		this.A232E33C.ResumeLayout(false);
		this.A232E33C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F9132F2A).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
