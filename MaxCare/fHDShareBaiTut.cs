using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDShareBaiTut : Form
{
	private JSON_Settings gclass8_0;

	private string F3B4700F;

	private string string_0;

	private string EF95B316;

	private int int_0;

	public static bool ADAE2F9A;

	private List<string> E9257012 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button F392B92B;

	private BunifuCards bunifuCards1;

	private Panel B58A490C;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbVanBan;

	private Panel plVanBan;

	private Label lblStatus;

	private RichTextBox txtNoiDung;

	private Button AF0C151F;

	private Button btnUp;

	private NumericUpDown E81F1929;

	private NumericUpDown nudDelayFrom;

	private Label label20;

	private Label BBAD6FAA;

	private Label label15;

	private GroupBox groupBox2;

	private Panel plDangBaiLenPage;

	private Label FBA3022C;

	private Label CCAEF53C;

	private NumericUpDown nudCountPageTo;

	private Label label23;

	private NumericUpDown nudCountPageFrom;

	private Panel plDangBaiLenNhom;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown CE21A791;

	private Label label24;

	private Label label25;

	private Label label26;

	private CheckBox ckbShareBaiLenPage;

	private CheckBox ckbShareBaiLenNhom;

	private CheckBox ckbShareBaiLenTuong;

	private Button E306A039;

	private Button button2;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label FA8F62B8;

	private Label label8;

	private Label D829D8BA;

	private CheckBox ckbOnlyShareNhomKhongKiemDuyet;

	private CheckBox ckbKhongPhaiLinkFacebook;

	private RadioButton rbShareVip;

	private RadioButton D781E433;

	private Label label3;

	private Panel E424F197;

	private Label B9923604;

	private Label label6;

	private Label label53;

	private NumericUpDown nudTuongTacTo;

	private NumericUpDown C31FD48E;

	private Label label7;

	private NumericUpDown D2A759AE;

	private Label label52;

	private CheckBox ckbTuongTacComment;

	private NumericUpDown nudTuongTacDelayFrom;

	private Label E7BB1D2B;

	private CheckBox ckbTuongTacLike;

	private Label F59948B0;

	private CheckBox ckbTuongTac;

	private Panel panel2;

	private Button button4;

	private Button button5;

	private RadioButton F236C51E;

	private RadioButton radioButton2;

	private Label B22A2D11;

	private Label C7808A3D;

	private RichTextBox txtComment;

	private Label lblComment;

	private LinkLabel linkLabel1;

	private Button D68BD4BD;

	private Button button7;

	private LinkLabel linkLabel2;

	private Panel panel4;

	private CheckBox C630BF1D;

	private CheckBox A9AB7E03;

	private CheckBox C2180781;

	private Panel DBB7ABA5;

	private Button button8;

	private RadioButton rbTuNhap;

	private RadioButton EA2873B7;

	private Label label11;

	private CheckBox ckbXemVideo;

	private Panel F3A90399;

	private Label label14;

	private NumericUpDown nudTimeWatchTo;

	private NumericUpDown D88C6D9B;

	private Label label12;

	private Label A0947591;

	private RadioButton BE245807;

	private RichTextBox txtLinkChiaSe;

	private NumericUpDown nudTimeWaitTo1;

	private NumericUpDown D021AB26;

	private Label E23795B9;

	private Label label17;

	private Label label16;

	private NumericUpDown nudTimeWaitTo2;

	private NumericUpDown C1B5CFAD;

	private Label A929779D;

	private Label F9B531B3;

	private Label label27;

	private RadioButton rbToken;

	private RadioButton rbCookieV2;

	private RadioButton rbCookieV1;

	private Label C9BA181A;

	private ToolTip toolTip_0;

	private CheckBox ckbXoaBai;

	public fHDShareBaiTut(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		ADAE2F9A = false;
		F3B4700F = string_1;
		EF95B316 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Share bài";
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
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			F392B92B.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void BF229787()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label15);
		Language.smethod_0(label20);
		Language.smethod_0(BBAD6FAA);
		Language.smethod_0(groupBox2);
		Language.smethod_0(ckbShareBaiLenTuong);
		Language.smethod_0(ckbShareBaiLenNhom);
		Language.smethod_0(label26);
		Language.smethod_0(label24);
		Language.smethod_0(label25);
		Language.smethod_0(ckbOnlyShareNhomKhongKiemDuyet);
		Language.smethod_0(ckbShareBaiLenPage);
		Language.smethod_0(FBA3022C);
		Language.smethod_0(label23);
		Language.smethod_0(CCAEF53C);
		Language.smethod_0(D829D8BA);
		Language.smethod_0(ckbVanBan);
		Language.smethod_0(lblStatus);
		Language.smethod_0(label8);
		Language.smethod_0(F392B92B);
		Language.smethod_0(btnCancel);
		Language.smethod_0(rbNganCachMoiDong);
		Language.smethod_0(rbNganCachKyTu);
	}

	private void A53360B8_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			E81F1929.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			ckbShareBaiLenTuong.Checked = gclass8_0.GetValueBool("ckbShareBaiLenTuong");
			ckbShareBaiLenNhom.Checked = gclass8_0.GetValueBool("ckbShareBaiLenNhom");
			CE21A791.Value = gclass8_0.GetValueInt("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = gclass8_0.GetValueInt("nudCountGroupTo", 1);
			D021AB26.Value = gclass8_0.GetValueInt("nudTimeWaitFrom1", 1);
			nudTimeWaitTo1.Value = gclass8_0.GetValueInt("nudTimeWaitTo1", 1);
			C1B5CFAD.Value = gclass8_0.GetValueInt("nudTimeWaitFrom2", 10);
			nudTimeWaitTo2.Value = gclass8_0.GetValueInt("nudTimeWaitTo2", 10);
			switch (gclass8_0.GetValueInt("typeLoad"))
			{
			case 0:
				rbCookieV1.Checked = true;
				break;
			case 1:
				rbCookieV2.Checked = true;
				break;
			case 2:
				rbToken.Checked = true;
				break;
			}
			if (gclass8_0.GetValueInt("typeShare") == 0)
			{
				EA2873B7.Checked = true;
			}
			else
			{
				rbTuNhap.Checked = true;
			}
			ckbXemVideo.Checked = gclass8_0.GetValueBool("ckbXemVideo");
			D88C6D9B.Value = gclass8_0.GetValueInt("nudTimeWatchFrom");
			nudTimeWatchTo.Value = gclass8_0.GetValueInt("nudTimeWatchTo");
			E9257012 = gclass8_0.GetValueList("lstNhomTuNhap");
			C2180781.Checked = gclass8_0.GetValueBool("ckbCauHinhNangCao");
			ckbOnlyShareNhomKhongKiemDuyet.Checked = gclass8_0.GetValueBool("ckbOnlyShareNhomKhongKiemDuyet");
			A9AB7E03.Checked = gclass8_0.GetValueBool("ckbUuTienNhomNhieuThanhVien");
			C630BF1D.Checked = gclass8_0.GetValueBool("ckbKhongShareTrung");
			ckbXoaBai.Checked = gclass8_0.GetValueBool("ckbXoaBai");
			ckbTuongTac.Checked = gclass8_0.GetValueBool("ckbTuongTac");
			D2A759AE.Value = gclass8_0.GetValueInt("nudTuongTacFrom", 3);
			nudTuongTacTo.Value = gclass8_0.GetValueInt("nudTuongTacTo", 5);
			nudTuongTacDelayFrom.Value = gclass8_0.GetValueInt("nudTuongTacDelayFrom", 5);
			C31FD48E.Value = gclass8_0.GetValueInt("nudTuongTacDelayTo", 7);
			ckbTuongTacLike.Checked = gclass8_0.GetValueBool("ckbTuongTacLike");
			ckbTuongTacComment.Checked = gclass8_0.GetValueBool("ckbTuongTacComment");
			txtComment.Text = gclass8_0.GetValue("txtComment");
			ckbShareBaiLenPage.Checked = gclass8_0.GetValueBool("ckbShareBaiLenPage");
			nudCountPageFrom.Value = gclass8_0.GetValueInt("nudCountPageFrom", 1);
			nudCountPageTo.Value = gclass8_0.GetValueInt("nudCountPageTo", 1);
			txtLinkChiaSe.Text = gclass8_0.GetValue("txtLinkChiaSe");
			switch (gclass8_0.GetValueInt("kieuShare"))
			{
			case 0:
				D781E433.Checked = true;
				break;
			case 1:
				rbShareVip.Checked = true;
				break;
			default:
				BE245807.Checked = true;
				break;
			}
			ckbKhongPhaiLinkFacebook.Checked = gclass8_0.GetValueBool("ckbKhongPhaiLinkFacebook");
			ckbVanBan.Checked = gclass8_0.GetValueBool("ckbVanBan");
			txtNoiDung.Text = gclass8_0.GetValue("txtNoiDung");
			if (gclass8_0.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch (Exception)
		{
		}
		method_0();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F392B92B_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", E81F1929.Value);
		gClass.GetJson("ckbShareBaiLenTuong", ckbShareBaiLenTuong.Checked);
		gClass.GetJson("ckbShareBaiLenNhom", ckbShareBaiLenNhom.Checked);
		gClass.GetJson("nudCountGroupFrom", CE21A791.Value);
		gClass.GetJson("nudCountGroupTo", nudCountGroupTo.Value);
		gClass.GetJson("nudTimeWaitFrom1", D021AB26.Value);
		gClass.GetJson("nudTimeWaitTo1", nudTimeWaitTo1.Value);
		gClass.GetJson("nudTimeWaitFrom2", C1B5CFAD.Value);
		gClass.GetJson("nudTimeWaitTo2", C1B5CFAD.Value);
		int num = 0;
		if (rbCookieV2.Checked)
		{
			num = 1;
		}
		else if (rbToken.Checked)
		{
			num = 2;
		}
		gClass.GetJson("typeLoad", num);
		int num2 = 0;
		if (rbTuNhap.Checked)
		{
			num2 = 1;
		}
		gClass.GetJson("typeShare", num2);
		gClass.GetJson("ckbXemVideo", ckbXemVideo.Checked);
		gClass.GetJson("nudTimeWatchFrom", D88C6D9B.Value);
		gClass.GetJson("nudTimeWatchTo", nudTimeWatchTo.Value);
		gClass.method_5("lstNhomTuNhap", E9257012);
		gClass.GetJson("ckbCauHinhNangCao", C2180781.Checked);
		gClass.GetJson("ckbOnlyShareNhomKhongKiemDuyet", ckbOnlyShareNhomKhongKiemDuyet.Checked);
		gClass.GetJson("ckbUuTienNhomNhieuThanhVien", A9AB7E03.Checked);
		gClass.GetJson("ckbKhongShareTrung", C630BF1D.Checked);
		gClass.GetJson("ckbXoaBai", ckbXoaBai.Checked);
		gClass.GetJson("ckbTuongTac", ckbTuongTac.Checked);
		gClass.GetJson("nudTuongTacFrom", D2A759AE.Value);
		gClass.GetJson("nudTuongTacTo", D2A759AE.Value);
		gClass.GetJson("nudTuongTacDelayFrom", nudTuongTacDelayFrom.Value);
		gClass.GetJson("nudTuongTacDelayTo", C31FD48E.Value);
		gClass.GetJson("ckbTuongTacLike", ckbTuongTacLike.Checked);
		gClass.GetJson("ckbTuongTacComment", ckbTuongTacComment.Checked);
		gClass.GetJson("txtComment", txtComment.Text);
		gClass.GetJson("ckbShareBaiLenPage", ckbShareBaiLenPage.Checked);
		gClass.GetJson("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.GetJson("nudCountPageTo", nudCountPageTo.Value);
		gClass.GetJson("txtLinkChiaSe", txtLinkChiaSe.Text.Trim());
		int num3 = 0;
		if (rbShareVip.Checked)
		{
			num3 = 1;
		}
		else if (BE245807.Checked)
		{
			num3 = 2;
		}
		gClass.GetJson("kieuShare", num3);
		gClass.GetJson("ckbKhongPhaiLinkFacebook", ckbKhongPhaiLinkFacebook.Checked);
		gClass.GetJson("ckbVanBan", ckbVanBan.Checked);
		gClass.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		int num4 = 0;
		if (rbNganCachKyTu.Checked)
		{
			num4 = 1;
		}
		gClass.GetJson("typeNganCach", num4);
		string text2 = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(F3B4700F, text, string_0, text2))
				{
					ADAE2F9A = true;
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
			if (InteractSQL.smethod_13(EF95B316, text, text2))
			{
				ADAE2F9A = true;
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

	private void method_0()
	{
		FD346C17(null, null);
		method_2(null, null);
		E395331D(null, null);
		ckbShareBaiLenNhom_CheckedChanged(null, null);
		ckbShareBaiLenPage_CheckedChanged(null, null);
		B69FE71E(null, null);
		D725790E(null, null);
		rbCookieV2_CheckedChanged(null, null);
		ckbTuongTac_CheckedChanged(null, null);
		AD0B5794(null, null);
		A6210724(null, null);
		C2180781_CheckedChanged(null, null);
		ckbXemVideo_CheckedChanged(null, null);
	}

	private void B69FE71E(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
	}

	private void EF9D66AF(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
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

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			AF0C151F.Visible = true;
		}
	}

	private void AF0C151F_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 216;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 169;
	}

	private void ckbShareBaiLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = ckbShareBaiLenNhom.Checked;
	}

	private void ckbShareBaiLenPage_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbShareBaiLenPage.Checked;
	}

	private void DA0C7929(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtNoiDung.Focus();
	}

	private void F937F0A0(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtNoiDung.Focus();
	}

	private void EABA11A7(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void E395331D(object sender, EventArgs e)
	{
	}

	private void FD346C17(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void A5BE7E91(object sender, EventArgs e)
	{
		Common.F9202C12(txtLinkChiaSe, D829D8BA);
	}

	private void rbCookieV2_CheckedChanged(object sender, EventArgs e)
	{
		ckbKhongPhaiLinkFacebook.Enabled = !rbShareVip.Checked;
		if (rbShareVip.Checked)
		{
			ckbKhongPhaiLinkFacebook.Checked = false;
		}
	}

	private void A8139B30(object sender, EventArgs e)
	{
	}

	private void D725790E(object sender, EventArgs e)
	{
	}

	private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		E424F197.Enabled = ckbTuongTac.Checked;
	}

	private void CFB4FB84(object sender, EventArgs e)
	{
	}

	private void AD0B5794(object sender, EventArgs e)
	{
		panel2.Enabled = ckbTuongTacComment.Checked;
	}

	private void DE04FB05(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		list = txtComment.Lines.ToList();
		list = Common.RemoveEmptyItems(list);
		lblComment.Text = string.Format(Language.GetValue("Danh sa\u0301ch comment ({0}):"), list.Count.ToString());
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void CFBD2AAE(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"));
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void F407930D(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"));
	}

	private void A6210724(object sender, EventArgs e)
	{
		button8.Enabled = rbTuNhap.Checked;
	}

	private void C2180781_CheckedChanged(object sender, EventArgs e)
	{
		panel4.Enabled = C2180781.Checked;
	}

	private void button8_Click(object sender, EventArgs e)
	{
		string text = Guid.NewGuid().ToString() + ".txt";
		Common.ShowForm(new fNhapDuLieu1(text, "Nhâ\u0323p danh sa\u0301ch ID nho\u0301m", "Danh sa\u0301ch ID nho\u0301m", "(Mô\u0303i nô\u0323i dung 1 do\u0300ng)", E9257012));
		E9257012 = File.ReadAllLines(text).ToList();
		try
		{
			File.Delete(text);
		}
		catch
		{
		}
	}

	private void ckbXemVideo_CheckedChanged(object sender, EventArgs e)
	{
		F3A90399.Enabled = ckbXemVideo.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDShareBaiTut));
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.B58A490C = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.txtLinkChiaSe = new System.Windows.Forms.RichTextBox();
		this.F3A90399 = new System.Windows.Forms.Panel();
		this.label14 = new System.Windows.Forms.Label();
		this.nudTimeWatchTo = new System.Windows.Forms.NumericUpDown();
		this.D88C6D9B = new System.Windows.Forms.NumericUpDown();
		this.label12 = new System.Windows.Forms.Label();
		this.A0947591 = new System.Windows.Forms.Label();
		this.ckbXemVideo = new System.Windows.Forms.CheckBox();
		this.BE245807 = new System.Windows.Forms.RadioButton();
		this.rbShareVip = new System.Windows.Forms.RadioButton();
		this.D781E433 = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.ckbKhongPhaiLinkFacebook = new System.Windows.Forms.CheckBox();
		this.D829D8BA = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.plDangBaiLenPage = new System.Windows.Forms.Panel();
		this.FBA3022C = new System.Windows.Forms.Label();
		this.CCAEF53C = new System.Windows.Forms.Label();
		this.nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		this.label23 = new System.Windows.Forms.Label();
		this.nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		this.plDangBaiLenNhom = new System.Windows.Forms.Panel();
		this.panel4 = new System.Windows.Forms.Panel();
		this.ckbXoaBai = new System.Windows.Forms.CheckBox();
		this.C630BF1D = new System.Windows.Forms.CheckBox();
		this.A9AB7E03 = new System.Windows.Forms.CheckBox();
		this.ckbOnlyShareNhomKhongKiemDuyet = new System.Windows.Forms.CheckBox();
		this.C2180781 = new System.Windows.Forms.CheckBox();
		this.DBB7ABA5 = new System.Windows.Forms.Panel();
		this.button8 = new System.Windows.Forms.Button();
		this.rbTuNhap = new System.Windows.Forms.RadioButton();
		this.EA2873B7 = new System.Windows.Forms.RadioButton();
		this.rbToken = new System.Windows.Forms.RadioButton();
		this.label11 = new System.Windows.Forms.Label();
		this.rbCookieV2 = new System.Windows.Forms.RadioButton();
		this.E424F197 = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.button7 = new System.Windows.Forms.Button();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.button4 = new System.Windows.Forms.Button();
		this.button5 = new System.Windows.Forms.Button();
		this.F236C51E = new System.Windows.Forms.RadioButton();
		this.radioButton2 = new System.Windows.Forms.RadioButton();
		this.B22A2D11 = new System.Windows.Forms.Label();
		this.C7808A3D = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblComment = new System.Windows.Forms.Label();
		this.B9923604 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label53 = new System.Windows.Forms.Label();
		this.nudTuongTacTo = new System.Windows.Forms.NumericUpDown();
		this.C31FD48E = new System.Windows.Forms.NumericUpDown();
		this.label7 = new System.Windows.Forms.Label();
		this.D2A759AE = new System.Windows.Forms.NumericUpDown();
		this.label52 = new System.Windows.Forms.Label();
		this.ckbTuongTacComment = new System.Windows.Forms.CheckBox();
		this.nudTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.E7BB1D2B = new System.Windows.Forms.Label();
		this.ckbTuongTacLike = new System.Windows.Forms.CheckBox();
		this.F59948B0 = new System.Windows.Forms.Label();
		this.rbCookieV1 = new System.Windows.Forms.RadioButton();
		this.C9BA181A = new System.Windows.Forms.Label();
		this.ckbTuongTac = new System.Windows.Forms.CheckBox();
		this.nudTimeWaitTo2 = new System.Windows.Forms.NumericUpDown();
		this.nudTimeWaitTo1 = new System.Windows.Forms.NumericUpDown();
		this.nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		this.C1B5CFAD = new System.Windows.Forms.NumericUpDown();
		this.D021AB26 = new System.Windows.Forms.NumericUpDown();
		this.CE21A791 = new System.Windows.Forms.NumericUpDown();
		this.A929779D = new System.Windows.Forms.Label();
		this.E23795B9 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.F9B531B3 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.ckbShareBaiLenPage = new System.Windows.Forms.CheckBox();
		this.ckbShareBaiLenNhom = new System.Windows.Forms.CheckBox();
		this.ckbShareBaiLenTuong = new System.Windows.Forms.CheckBox();
		this.E81F1929 = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.label20 = new System.Windows.Forms.Label();
		this.BBAD6FAA = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.plVanBan = new System.Windows.Forms.Panel();
		this.D68BD4BD = new System.Windows.Forms.Button();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.E306A039 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		this.FA8F62B8 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.AF0C151F = new System.Windows.Forms.Button();
		this.btnUp = new System.Windows.Forms.Button();
		this.txtNoiDung = new System.Windows.Forms.RichTextBox();
		this.lblStatus = new System.Windows.Forms.Label();
		this.F392B92B = new System.Windows.Forms.Button();
		this.ckbVanBan = new System.Windows.Forms.CheckBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.toolTip_0 = new System.Windows.Forms.ToolTip(this.icontainer_0);
		this.B58A490C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.F3A90399.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D88C6D9B).BeginInit();
		this.groupBox2.SuspendLayout();
		this.plDangBaiLenPage.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
		this.plDangBaiLenNhom.SuspendLayout();
		this.panel4.SuspendLayout();
		this.DBB7ABA5.SuspendLayout();
		this.E424F197.SuspendLayout();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C31FD48E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D2A759AE).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWaitTo2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWaitTo1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.C1B5CFAD).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D021AB26).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CE21A791).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E81F1929).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		this.plVanBan.SuspendLayout();
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
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(1097, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Share bài";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.B58A490C;
		this.bunifuDragControl_1.Vertical = true;
		this.B58A490C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.B58A490C.BackColor = System.Drawing.Color.White;
		this.B58A490C.Controls.Add(this.button1);
		this.B58A490C.Controls.Add(this.pictureBox1);
		this.B58A490C.Controls.Add(this.bunifuCustomLabel1);
		this.B58A490C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.B58A490C.Location = new System.Drawing.Point(0, 3);
		this.B58A490C.Name = "pnlHeader";
		this.B58A490C.Size = new System.Drawing.Size(1097, 31);
		this.B58A490C.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.button1.Location = new System.Drawing.Point(1066, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 0;
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
		this.panel1.Controls.Add(this.txtLinkChiaSe);
		this.panel1.Controls.Add(this.F3A90399);
		this.panel1.Controls.Add(this.ckbXemVideo);
		this.panel1.Controls.Add(this.BE245807);
		this.panel1.Controls.Add(this.rbShareVip);
		this.panel1.Controls.Add(this.D781E433);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Controls.Add(this.ckbKhongPhaiLinkFacebook);
		this.panel1.Controls.Add(this.D829D8BA);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.E81F1929);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.label20);
		this.panel1.Controls.Add(this.BBAD6FAA);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.plVanBan);
		this.panel1.Controls.Add(this.F392B92B);
		this.panel1.Controls.Add(this.ckbVanBan);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(1100, 612);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.txtLinkChiaSe.Location = new System.Drawing.Point(14, 136);
		this.txtLinkChiaSe.Name = "txtLinkChiaSe";
		this.txtLinkChiaSe.Size = new System.Drawing.Size(378, 98);
		this.txtLinkChiaSe.TabIndex = 71;
		this.txtLinkChiaSe.Text = "";
		this.txtLinkChiaSe.TextChanged += new System.EventHandler(A5BE7E91);
		this.F3A90399.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.F3A90399.Controls.Add(this.label14);
		this.F3A90399.Controls.Add(this.nudTimeWatchTo);
		this.F3A90399.Controls.Add(this.D88C6D9B);
		this.F3A90399.Controls.Add(this.label12);
		this.F3A90399.Controls.Add(this.A0947591);
		this.F3A90399.Location = new System.Drawing.Point(33, 284);
		this.F3A90399.Name = "panel5";
		this.F3A90399.Size = new System.Drawing.Size(298, 30);
		this.F3A90399.TabIndex = 70;
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(5, 6);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(93, 16);
		this.label14.TabIndex = 61;
		this.label14.Text = "Thời gian xem:";
		this.nudTimeWatchTo.Location = new System.Drawing.Point(204, 3);
		this.nudTimeWatchTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWatchTo.Name = "nudTimeWatchTo";
		this.nudTimeWatchTo.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWatchTo.TabIndex = 58;
		this.D88C6D9B.Location = new System.Drawing.Point(107, 3);
		this.D88C6D9B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D88C6D9B.Name = "nudTimeWatchFrom";
		this.D88C6D9B.Size = new System.Drawing.Size(56, 23);
		this.D88C6D9B.TabIndex = 57;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(169, 5);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(28, 16);
		this.label12.TabIndex = 60;
		this.label12.Text = "đê\u0301n";
		this.A0947591.AutoSize = true;
		this.A0947591.Location = new System.Drawing.Point(263, 5);
		this.A0947591.Name = "label13";
		this.A0947591.Size = new System.Drawing.Size(30, 16);
		this.A0947591.TabIndex = 59;
		this.A0947591.Text = "giây";
		this.ckbXemVideo.AutoSize = true;
		this.ckbXemVideo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXemVideo.Location = new System.Drawing.Point(14, 263);
		this.ckbXemVideo.Name = "ckbXemVideo";
		this.ckbXemVideo.Size = new System.Drawing.Size(176, 20);
		this.ckbXemVideo.TabIndex = 69;
		this.ckbXemVideo.Text = "Xem video trước khi share";
		this.ckbXemVideo.UseVisualStyleBackColor = true;
		this.ckbXemVideo.CheckedChanged += new System.EventHandler(ckbXemVideo_CheckedChanged);
		this.BE245807.AutoSize = true;
		this.BE245807.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BE245807.Location = new System.Drawing.Point(276, 237);
		this.BE245807.Name = "rbShareTut";
		this.BE245807.Size = new System.Drawing.Size(121, 20);
		this.BE245807.TabIndex = 68;
		this.BE245807.TabStop = true;
		this.BE245807.Text = "Post bài thay link";
		this.BE245807.UseVisualStyleBackColor = true;
		this.BE245807.CheckedChanged += new System.EventHandler(rbCookieV2_CheckedChanged);
		this.rbShareVip.AutoSize = true;
		this.rbShareVip.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbShareVip.Location = new System.Drawing.Point(194, 237);
		this.rbShareVip.Name = "rbShareVip";
		this.rbShareVip.Size = new System.Drawing.Size(81, 20);
		this.rbShareVip.TabIndex = 68;
		this.rbShareVip.TabStop = true;
		this.rbShareVip.Text = "Share Vip";
		this.rbShareVip.UseVisualStyleBackColor = true;
		this.rbShareVip.CheckedChanged += new System.EventHandler(rbCookieV2_CheckedChanged);
		this.D781E433.AutoSize = true;
		this.D781E433.Checked = true;
		this.D781E433.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D781E433.Location = new System.Drawing.Point(90, 237);
		this.D781E433.Name = "rbShareThuong";
		this.D781E433.Size = new System.Drawing.Size(103, 20);
		this.D781E433.TabIndex = 67;
		this.D781E433.TabStop = true;
		this.D781E433.Text = "Share thường";
		this.D781E433.UseVisualStyleBackColor = true;
		this.D781E433.CheckedChanged += new System.EventHandler(D725790E);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(11, 239);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(72, 16);
		this.label3.TabIndex = 66;
		this.label3.Text = "Kiểu share:";
		this.ckbKhongPhaiLinkFacebook.AutoSize = true;
		this.ckbKhongPhaiLinkFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbKhongPhaiLinkFacebook.Location = new System.Drawing.Point(14, 318);
		this.ckbKhongPhaiLinkFacebook.Name = "ckbKhongPhaiLinkFacebook";
		this.ckbKhongPhaiLinkFacebook.Size = new System.Drawing.Size(264, 20);
		this.ckbKhongPhaiLinkFacebook.TabIndex = 65;
		this.ckbKhongPhaiLinkFacebook.Text = "Link cần chia sẻ không phải của Facebook";
		this.ckbKhongPhaiLinkFacebook.UseVisualStyleBackColor = true;
		this.ckbKhongPhaiLinkFacebook.CheckedChanged += new System.EventHandler(A8139B30);
		this.D829D8BA.AutoSize = true;
		this.D829D8BA.Location = new System.Drawing.Point(11, 116);
		this.D829D8BA.Name = "label2";
		this.D829D8BA.Size = new System.Drawing.Size(136, 16);
		this.D829D8BA.TabIndex = 64;
		this.D829D8BA.Text = "Link bài cần share (0):";
		this.groupBox2.Controls.Add(this.plDangBaiLenPage);
		this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbShareBaiLenPage);
		this.groupBox2.Controls.Add(this.ckbShareBaiLenNhom);
		this.groupBox2.Controls.Add(this.ckbShareBaiLenTuong);
		this.groupBox2.Location = new System.Drawing.Point(407, 94);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(679, 462);
		this.groupBox2.TabIndex = 62;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Tùy chọn share";
		this.plDangBaiLenPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.plDangBaiLenPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenPage.Controls.Add(this.FBA3022C);
		this.plDangBaiLenPage.Controls.Add(this.CCAEF53C);
		this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
		this.plDangBaiLenPage.Controls.Add(this.label23);
		this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
		this.plDangBaiLenPage.Location = new System.Drawing.Point(33, 430);
		this.plDangBaiLenPage.Name = "plDangBaiLenPage";
		this.plDangBaiLenPage.Size = new System.Drawing.Size(312, 27);
		this.plDangBaiLenPage.TabIndex = 1;
		this.FBA3022C.AutoSize = true;
		this.FBA3022C.Location = new System.Drawing.Point(3, 3);
		this.FBA3022C.Name = "label21";
		this.FBA3022C.Size = new System.Drawing.Size(95, 16);
		this.FBA3022C.TabIndex = 49;
		this.FBA3022C.Text = "Số lượng page:";
		this.CCAEF53C.AutoSize = true;
		this.CCAEF53C.Location = new System.Drawing.Point(264, 3);
		this.CCAEF53C.Name = "label22";
		this.CCAEF53C.Size = new System.Drawing.Size(35, 16);
		this.CCAEF53C.TabIndex = 50;
		this.CCAEF53C.Text = "page";
		this.nudCountPageTo.Location = new System.Drawing.Point(205, 1);
		this.nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageTo.Name = "nudCountPageTo";
		this.nudCountPageTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageTo.TabIndex = 48;
		this.label23.AutoSize = true;
		this.label23.Location = new System.Drawing.Point(170, 3);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(28, 16);
		this.label23.TabIndex = 51;
		this.label23.Text = "đê\u0301n";
		this.nudCountPageFrom.Location = new System.Drawing.Point(108, 1);
		this.nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountPageFrom.Name = "nudCountPageFrom";
		this.nudCountPageFrom.Size = new System.Drawing.Size(56, 23);
		this.nudCountPageFrom.TabIndex = 47;
		this.plDangBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plDangBaiLenNhom.Controls.Add(this.panel4);
		this.plDangBaiLenNhom.Controls.Add(this.C2180781);
		this.plDangBaiLenNhom.Controls.Add(this.DBB7ABA5);
		this.plDangBaiLenNhom.Controls.Add(this.rbToken);
		this.plDangBaiLenNhom.Controls.Add(this.label11);
		this.plDangBaiLenNhom.Controls.Add(this.rbCookieV2);
		this.plDangBaiLenNhom.Controls.Add(this.E424F197);
		this.plDangBaiLenNhom.Controls.Add(this.rbCookieV1);
		this.plDangBaiLenNhom.Controls.Add(this.C9BA181A);
		this.plDangBaiLenNhom.Controls.Add(this.ckbTuongTac);
		this.plDangBaiLenNhom.Controls.Add(this.nudTimeWaitTo2);
		this.plDangBaiLenNhom.Controls.Add(this.nudTimeWaitTo1);
		this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
		this.plDangBaiLenNhom.Controls.Add(this.C1B5CFAD);
		this.plDangBaiLenNhom.Controls.Add(this.D021AB26);
		this.plDangBaiLenNhom.Controls.Add(this.CE21A791);
		this.plDangBaiLenNhom.Controls.Add(this.A929779D);
		this.plDangBaiLenNhom.Controls.Add(this.E23795B9);
		this.plDangBaiLenNhom.Controls.Add(this.label24);
		this.plDangBaiLenNhom.Controls.Add(this.F9B531B3);
		this.plDangBaiLenNhom.Controls.Add(this.label17);
		this.plDangBaiLenNhom.Controls.Add(this.label25);
		this.plDangBaiLenNhom.Controls.Add(this.label27);
		this.plDangBaiLenNhom.Controls.Add(this.label16);
		this.plDangBaiLenNhom.Controls.Add(this.label26);
		this.plDangBaiLenNhom.Location = new System.Drawing.Point(33, 72);
		this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		this.plDangBaiLenNhom.Size = new System.Drawing.Size(637, 329);
		this.plDangBaiLenNhom.TabIndex = 1;
		this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel4.Controls.Add(this.ckbXoaBai);
		this.panel4.Controls.Add(this.C630BF1D);
		this.panel4.Controls.Add(this.A9AB7E03);
		this.panel4.Controls.Add(this.ckbOnlyShareNhomKhongKiemDuyet);
		this.panel4.Location = new System.Drawing.Point(19, 210);
		this.panel4.Name = "panel4";
		this.panel4.Size = new System.Drawing.Size(287, 107);
		this.panel4.TabIndex = 69;
		this.ckbXoaBai.AutoSize = true;
		this.ckbXoaBai.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbXoaBai.Location = new System.Drawing.Point(3, 81);
		this.ckbXoaBai.Name = "ckbXoaBai";
		this.ckbXoaBai.Size = new System.Drawing.Size(247, 20);
		this.ckbXoaBai.TabIndex = 2;
		this.ckbXoaBai.Text = "Xóa bài khi đăng vào nhóm kiểm duyệt";
		this.ckbXoaBai.UseVisualStyleBackColor = true;
		this.C630BF1D.AutoSize = true;
		this.C630BF1D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.C630BF1D.Location = new System.Drawing.Point(3, 55);
		this.C630BF1D.Name = "ckbKhongShareTrung";
		this.C630BF1D.Size = new System.Drawing.Size(167, 20);
		this.C630BF1D.TabIndex = 2;
		this.C630BF1D.Text = "Không share trùng nhóm";
		this.C630BF1D.UseVisualStyleBackColor = true;
		this.A9AB7E03.AutoSize = true;
		this.A9AB7E03.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A9AB7E03.Location = new System.Drawing.Point(3, 29);
		this.A9AB7E03.Name = "ckbUuTienNhomNhieuThanhVien";
		this.A9AB7E03.Size = new System.Drawing.Size(254, 20);
		this.A9AB7E03.TabIndex = 1;
		this.A9AB7E03.Text = "Ưu tiên share nhóm có nhiều thành viên";
		this.A9AB7E03.UseVisualStyleBackColor = true;
		this.ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
		this.ckbOnlyShareNhomKhongKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbOnlyShareNhomKhongKiemDuyet.Location = new System.Drawing.Point(3, 3);
		this.ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
		this.ckbOnlyShareNhomKhongKiemDuyet.Size = new System.Drawing.Size(220, 20);
		this.ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
		this.ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
		this.ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		this.C2180781.AutoSize = true;
		this.C2180781.Location = new System.Drawing.Point(6, 187);
		this.C2180781.Name = "ckbCauHinhNangCao";
		this.C2180781.Size = new System.Drawing.Size(132, 20);
		this.C2180781.TabIndex = 68;
		this.C2180781.Text = "Cấu hình nâng cao";
		this.C2180781.UseVisualStyleBackColor = true;
		this.C2180781.CheckedChanged += new System.EventHandler(C2180781_CheckedChanged);
		this.DBB7ABA5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DBB7ABA5.Controls.Add(this.button8);
		this.DBB7ABA5.Controls.Add(this.rbTuNhap);
		this.DBB7ABA5.Controls.Add(this.EA2873B7);
		this.DBB7ABA5.Location = new System.Drawing.Point(19, 130);
		this.DBB7ABA5.Name = "panel3";
		this.DBB7ABA5.Size = new System.Drawing.Size(287, 54);
		this.DBB7ABA5.TabIndex = 67;
		this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button8.Location = new System.Drawing.Point(207, 27);
		this.button8.Name = "button8";
		this.button8.Size = new System.Drawing.Size(75, 23);
		this.button8.TabIndex = 2;
		this.button8.Text = "Nhập";
		this.button8.UseVisualStyleBackColor = true;
		this.button8.Click += new System.EventHandler(button8_Click);
		this.rbTuNhap.AutoSize = true;
		this.rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbTuNhap.Location = new System.Drawing.Point(3, 29);
		this.rbTuNhap.Name = "rbTuNhap";
		this.rbTuNhap.Size = new System.Drawing.Size(176, 20);
		this.rbTuNhap.TabIndex = 1;
		this.rbTuNhap.Text = "Nhóm do người dùng nhập";
		this.rbTuNhap.UseVisualStyleBackColor = true;
		this.rbTuNhap.CheckedChanged += new System.EventHandler(A6210724);
		this.EA2873B7.AutoSize = true;
		this.EA2873B7.Checked = true;
		this.EA2873B7.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EA2873B7.Location = new System.Drawing.Point(3, 3);
		this.EA2873B7.Name = "rbRandom";
		this.EA2873B7.Size = new System.Drawing.Size(197, 20);
		this.EA2873B7.TabIndex = 0;
		this.EA2873B7.TabStop = true;
		this.EA2873B7.Text = "Ngẫu nhiên nhóm đã tham gia";
		this.EA2873B7.UseVisualStyleBackColor = true;
		this.rbToken.AutoSize = true;
		this.rbToken.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbToken.Location = new System.Drawing.Point(271, 85);
		this.rbToken.Name = "rbToken";
		this.rbToken.Size = new System.Drawing.Size(60, 20);
		this.rbToken.TabIndex = 68;
		this.rbToken.TabStop = true;
		this.rbToken.Text = "Token";
		this.toolTip_0.SetToolTip(this.rbToken, "Cân bằng giữa 2 loại cookie");
		this.rbToken.UseVisualStyleBackColor = true;
		this.rbToken.CheckedChanged += new System.EventHandler(rbCookieV2_CheckedChanged);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(3, 111);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(154, 16);
		this.label11.TabIndex = 66;
		this.label11.Text = "Tùy chọn nhóm để share:";
		this.rbCookieV2.AutoSize = true;
		this.rbCookieV2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCookieV2.Location = new System.Drawing.Point(173, 85);
		this.rbCookieV2.Name = "rbCookieV2";
		this.rbCookieV2.Size = new System.Drawing.Size(82, 20);
		this.rbCookieV2.TabIndex = 68;
		this.rbCookieV2.TabStop = true;
		this.rbCookieV2.Text = "Cookie V2";
		this.toolTip_0.SetToolTip(this.rbCookieV2, "Load nhóm chuẩn, dễ die nick");
		this.rbCookieV2.UseVisualStyleBackColor = true;
		this.rbCookieV2.CheckedChanged += new System.EventHandler(rbCookieV2_CheckedChanged);
		this.E424F197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.E424F197.Controls.Add(this.panel2);
		this.E424F197.Controls.Add(this.B9923604);
		this.E424F197.Controls.Add(this.label6);
		this.E424F197.Controls.Add(this.label53);
		this.E424F197.Controls.Add(this.nudTuongTacTo);
		this.E424F197.Controls.Add(this.C31FD48E);
		this.E424F197.Controls.Add(this.label7);
		this.E424F197.Controls.Add(this.D2A759AE);
		this.E424F197.Controls.Add(this.label52);
		this.E424F197.Controls.Add(this.ckbTuongTacComment);
		this.E424F197.Controls.Add(this.nudTuongTacDelayFrom);
		this.E424F197.Controls.Add(this.E7BB1D2B);
		this.E424F197.Controls.Add(this.ckbTuongTacLike);
		this.E424F197.Controls.Add(this.F59948B0);
		this.E424F197.Location = new System.Drawing.Point(340, 30);
		this.E424F197.Name = "plInteractGroup";
		this.E424F197.Size = new System.Drawing.Size(290, 277);
		this.E424F197.TabIndex = 65;
		this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel2.Controls.Add(this.button7);
		this.panel2.Controls.Add(this.linkLabel2);
		this.panel2.Controls.Add(this.button4);
		this.panel2.Controls.Add(this.button5);
		this.panel2.Controls.Add(this.F236C51E);
		this.panel2.Controls.Add(this.radioButton2);
		this.panel2.Controls.Add(this.B22A2D11);
		this.panel2.Controls.Add(this.C7808A3D);
		this.panel2.Controls.Add(this.txtComment);
		this.panel2.Controls.Add(this.lblComment);
		this.panel2.Location = new System.Drawing.Point(8, 101);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(275, 168);
		this.panel2.TabIndex = 104;
		this.button7.Cursor = System.Windows.Forms.Cursors.Help;
		this.button7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button7.Location = new System.Drawing.Point(244, 144);
		this.button7.Name = "button7";
		this.button7.Size = new System.Drawing.Size(23, 23);
		this.button7.TabIndex = 192;
		this.button7.Text = "?";
		this.button7.UseVisualStyleBackColor = true;
		this.button7.Click += new System.EventHandler(F407930D);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel2.Location = new System.Drawing.Point(164, 147);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(81, 16);
		this.linkLabel2.TabIndex = 191;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Random icon";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(230, 189);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 44;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button5.Cursor = System.Windows.Forms.Cursors.Help;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.Location = new System.Drawing.Point(230, 166);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(21, 23);
		this.button5.TabIndex = 45;
		this.button5.Text = "?";
		this.button5.UseVisualStyleBackColor = true;
		this.F236C51E.AutoSize = true;
		this.F236C51E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F236C51E.Location = new System.Drawing.Point(71, 189);
		this.F236C51E.Name = "radioButton1";
		this.F236C51E.Size = new System.Drawing.Size(159, 20);
		this.F236C51E.TabIndex = 42;
		this.F236C51E.Text = "Nội dung có nhiều dòng";
		this.F236C51E.UseVisualStyleBackColor = true;
		this.radioButton2.AutoSize = true;
		this.radioButton2.Checked = true;
		this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.radioButton2.Location = new System.Drawing.Point(71, 168);
		this.radioButton2.Name = "radioButton2";
		this.radioButton2.Size = new System.Drawing.Size(155, 20);
		this.radioButton2.TabIndex = 43;
		this.radioButton2.TabStop = true;
		this.radioButton2.Text = "Nội dung chỉ có 1 dòng";
		this.radioButton2.UseVisualStyleBackColor = true;
		this.B22A2D11.AutoSize = true;
		this.B22A2D11.Location = new System.Drawing.Point(6, 168);
		this.B22A2D11.Name = "label4";
		this.B22A2D11.Size = new System.Drawing.Size(64, 16);
		this.B22A2D11.TabIndex = 41;
		this.B22A2D11.Text = "Tùy chọn:";
		this.C7808A3D.AutoSize = true;
		this.C7808A3D.Location = new System.Drawing.Point(5, 147);
		this.C7808A3D.Name = "label10";
		this.C7808A3D.Size = new System.Drawing.Size(143, 16);
		this.C7808A3D.TabIndex = 40;
		this.C7808A3D.Text = "(Spin nội dung {a|b|c})";
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 26);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(260, 119);
		this.txtComment.TabIndex = 34;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(DE04FB05);
		this.lblComment.AutoSize = true;
		this.lblComment.Location = new System.Drawing.Point(3, 5);
		this.lblComment.Name = "lblComment";
		this.lblComment.Size = new System.Drawing.Size(149, 16);
		this.lblComment.TabIndex = 0;
		this.lblComment.Text = "Danh sa\u0301ch comment (0):";
		this.B9923604.AutoSize = true;
		this.B9923604.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.B9923604.Location = new System.Drawing.Point(3, 6);
		this.B9923604.Name = "label5";
		this.B9923604.Size = new System.Drawing.Size(109, 16);
		this.B9923604.TabIndex = 99;
		this.B9923604.Text = "Sô\u0301 ba\u0300i viết/nhóm:";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label6.Location = new System.Drawing.Point(160, 7);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(28, 16);
		this.label6.TabIndex = 103;
		this.label6.Text = "đê\u0301n";
		this.label53.AutoSize = true;
		this.label53.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label53.Location = new System.Drawing.Point(160, 33);
		this.label53.Name = "label53";
		this.label53.Size = new System.Drawing.Size(28, 16);
		this.label53.TabIndex = 103;
		this.label53.Text = "đê\u0301n";
		this.nudTuongTacTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacTo.Location = new System.Drawing.Point(190, 4);
		this.nudTuongTacTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacTo.Name = "nudTuongTacTo";
		this.nudTuongTacTo.Size = new System.Drawing.Size(47, 23);
		this.nudTuongTacTo.TabIndex = 94;
		this.nudTuongTacTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.C31FD48E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.C31FD48E.Location = new System.Drawing.Point(190, 30);
		this.C31FD48E.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.C31FD48E.Name = "nudTuongTacDelayTo";
		this.C31FD48E.Size = new System.Drawing.Size(47, 23);
		this.C31FD48E.TabIndex = 94;
		this.C31FD48E.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label7.Location = new System.Drawing.Point(240, 7);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(24, 16);
		this.label7.TabIndex = 102;
		this.label7.Text = "bài";
		this.D2A759AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.D2A759AE.Location = new System.Drawing.Point(113, 3);
		this.D2A759AE.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.D2A759AE.Name = "nudTuongTacFrom";
		this.D2A759AE.Size = new System.Drawing.Size(42, 23);
		this.D2A759AE.TabIndex = 92;
		this.D2A759AE.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.label52.AutoSize = true;
		this.label52.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label52.Location = new System.Drawing.Point(240, 32);
		this.label52.Name = "label52";
		this.label52.Size = new System.Drawing.Size(30, 16);
		this.label52.TabIndex = 102;
		this.label52.Text = "giây";
		this.ckbTuongTacComment.AutoSize = true;
		this.ckbTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacComment.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacComment.Location = new System.Drawing.Point(113, 79);
		this.ckbTuongTacComment.Name = "ckbTuongTacComment";
		this.ckbTuongTacComment.Size = new System.Drawing.Size(81, 20);
		this.ckbTuongTacComment.TabIndex = 96;
		this.ckbTuongTacComment.Text = "Comment";
		this.ckbTuongTacComment.UseVisualStyleBackColor = true;
		this.ckbTuongTacComment.CheckedChanged += new System.EventHandler(AD0B5794);
		this.nudTuongTacDelayFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudTuongTacDelayFrom.Location = new System.Drawing.Point(113, 30);
		this.nudTuongTacDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
		this.nudTuongTacDelayFrom.Size = new System.Drawing.Size(42, 23);
		this.nudTuongTacDelayFrom.TabIndex = 93;
		this.nudTuongTacDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.E7BB1D2B.AutoSize = true;
		this.E7BB1D2B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E7BB1D2B.Location = new System.Drawing.Point(3, 33);
		this.E7BB1D2B.Name = "label51";
		this.E7BB1D2B.Size = new System.Drawing.Size(99, 16);
		this.E7BB1D2B.TabIndex = 101;
		this.E7BB1D2B.Text = "Thơ\u0300i gian delay:";
		this.ckbTuongTacLike.AutoSize = true;
		this.ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTacLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.ckbTuongTacLike.Location = new System.Drawing.Point(113, 58);
		this.ckbTuongTacLike.Name = "ckbTuongTacLike";
		this.ckbTuongTacLike.Size = new System.Drawing.Size(48, 20);
		this.ckbTuongTacLike.TabIndex = 95;
		this.ckbTuongTacLike.Text = "Like";
		this.ckbTuongTacLike.UseVisualStyleBackColor = true;
		this.F59948B0.AutoSize = true;
		this.F59948B0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.F59948B0.Location = new System.Drawing.Point(3, 59);
		this.F59948B0.Name = "label50";
		this.F59948B0.Size = new System.Drawing.Size(93, 16);
		this.F59948B0.TabIndex = 100;
		this.F59948B0.Text = "Loa\u0323i tương ta\u0301c:";
		this.rbCookieV1.AutoSize = true;
		this.rbCookieV1.Checked = true;
		this.rbCookieV1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbCookieV1.Location = new System.Drawing.Point(85, 85);
		this.rbCookieV1.Name = "rbCookieV1";
		this.rbCookieV1.Size = new System.Drawing.Size(82, 20);
		this.rbCookieV1.TabIndex = 67;
		this.rbCookieV1.TabStop = true;
		this.rbCookieV1.Text = "Cookie V1";
		this.toolTip_0.SetToolTip(this.rbCookieV1, "Ít die nick, k ổn định");
		this.rbCookieV1.UseVisualStyleBackColor = true;
		this.rbCookieV1.CheckedChanged += new System.EventHandler(D725790E);
		this.C9BA181A.AutoSize = true;
		this.C9BA181A.Location = new System.Drawing.Point(6, 87);
		this.C9BA181A.Name = "label30";
		this.C9BA181A.Size = new System.Drawing.Size(75, 16);
		this.C9BA181A.TabIndex = 66;
		this.C9BA181A.Text = "Load nhóm:";
		this.ckbTuongTac.AutoSize = true;
		this.ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuongTac.Location = new System.Drawing.Point(340, 7);
		this.ckbTuongTac.Name = "ckbTuongTac";
		this.ckbTuongTac.Size = new System.Drawing.Size(210, 20);
		this.ckbTuongTac.TabIndex = 57;
		this.ckbTuongTac.Text = "Tương tác nhóm trước khi share";
		this.ckbTuongTac.UseVisualStyleBackColor = true;
		this.ckbTuongTac.CheckedChanged += new System.EventHandler(ckbTuongTac_CheckedChanged);
		this.nudTimeWaitTo2.Location = new System.Drawing.Point(219, 58);
		this.nudTimeWaitTo2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWaitTo2.Name = "nudTimeWaitTo2";
		this.nudTimeWaitTo2.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWaitTo2.TabIndex = 53;
		this.nudTimeWaitTo1.Location = new System.Drawing.Point(219, 32);
		this.nudTimeWaitTo1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudTimeWaitTo1.Name = "nudTimeWaitTo1";
		this.nudTimeWaitTo1.Size = new System.Drawing.Size(56, 23);
		this.nudTimeWaitTo1.TabIndex = 53;
		this.nudCountGroupTo.Location = new System.Drawing.Point(219, 6);
		this.nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudCountGroupTo.Name = "nudCountGroupTo";
		this.nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
		this.nudCountGroupTo.TabIndex = 53;
		this.C1B5CFAD.Location = new System.Drawing.Point(122, 58);
		this.C1B5CFAD.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.C1B5CFAD.Name = "nudTimeWaitFrom2";
		this.C1B5CFAD.Size = new System.Drawing.Size(56, 23);
		this.C1B5CFAD.TabIndex = 52;
		this.D021AB26.Location = new System.Drawing.Point(122, 32);
		this.D021AB26.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D021AB26.Name = "nudTimeWaitFrom1";
		this.D021AB26.Size = new System.Drawing.Size(56, 23);
		this.D021AB26.TabIndex = 52;
		this.CE21A791.Location = new System.Drawing.Point(122, 6);
		this.CE21A791.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.CE21A791.Name = "nudCountGroupFrom";
		this.CE21A791.Size = new System.Drawing.Size(56, 23);
		this.CE21A791.TabIndex = 52;
		this.A929779D.AutoSize = true;
		this.A929779D.Location = new System.Drawing.Point(184, 60);
		this.A929779D.Name = "label29";
		this.A929779D.Size = new System.Drawing.Size(28, 16);
		this.A929779D.TabIndex = 56;
		this.A929779D.Text = "đê\u0301n";
		this.E23795B9.AutoSize = true;
		this.E23795B9.Location = new System.Drawing.Point(184, 34);
		this.E23795B9.Name = "label18";
		this.E23795B9.Size = new System.Drawing.Size(28, 16);
		this.E23795B9.TabIndex = 56;
		this.E23795B9.Text = "đê\u0301n";
		this.label24.AutoSize = true;
		this.label24.Location = new System.Drawing.Point(184, 8);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(28, 16);
		this.label24.TabIndex = 56;
		this.label24.Text = "đê\u0301n";
		this.F9B531B3.AutoSize = true;
		this.F9B531B3.Location = new System.Drawing.Point(278, 60);
		this.F9B531B3.Name = "label28";
		this.F9B531B3.Size = new System.Drawing.Size(30, 16);
		this.F9B531B3.TabIndex = 55;
		this.F9B531B3.Text = "giây";
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(278, 34);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(30, 16);
		this.label17.TabIndex = 55;
		this.label17.Text = "giây";
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(278, 8);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(39, 16);
		this.label25.TabIndex = 55;
		this.label25.Text = "nhóm";
		this.label27.AutoSize = true;
		this.label27.Location = new System.Drawing.Point(3, 60);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(109, 16);
		this.label27.TabIndex = 54;
		this.label27.Text = "Khoảng cách edit:";
		this.toolTip_0.SetToolTip(this.label27, "Thời gian chờ giữa 2 lần edit");
		this.label16.AutoSize = true;
		this.label16.Location = new System.Drawing.Point(3, 34);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(82, 16);
		this.label16.TabIndex = 54;
		this.label16.Text = "Chờ sửa link:";
		this.toolTip_0.SetToolTip(this.label16, "Thời gian chờ sau khi đăng m.fb");
		this.label26.AutoSize = true;
		this.label26.Location = new System.Drawing.Point(3, 8);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(99, 16);
		this.label26.TabIndex = 54;
		this.label26.Text = "Số lượng nhóm:";
		this.ckbShareBaiLenPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbShareBaiLenPage.AutoSize = true;
		this.ckbShareBaiLenPage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareBaiLenPage.Location = new System.Drawing.Point(10, 407);
		this.ckbShareBaiLenPage.Name = "ckbShareBaiLenPage";
		this.ckbShareBaiLenPage.Size = new System.Drawing.Size(134, 20);
		this.ckbShareBaiLenPage.TabIndex = 0;
		this.ckbShareBaiLenPage.Text = "Share bài lên page";
		this.ckbShareBaiLenPage.UseVisualStyleBackColor = true;
		this.ckbShareBaiLenPage.CheckedChanged += new System.EventHandler(ckbShareBaiLenPage_CheckedChanged);
		this.ckbShareBaiLenNhom.AutoSize = true;
		this.ckbShareBaiLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareBaiLenNhom.Location = new System.Drawing.Point(10, 48);
		this.ckbShareBaiLenNhom.Name = "ckbShareBaiLenNhom";
		this.ckbShareBaiLenNhom.Size = new System.Drawing.Size(138, 20);
		this.ckbShareBaiLenNhom.TabIndex = 0;
		this.ckbShareBaiLenNhom.Text = "Share bài lên nhóm";
		this.ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
		this.ckbShareBaiLenNhom.CheckedChanged += new System.EventHandler(ckbShareBaiLenNhom_CheckedChanged);
		this.ckbShareBaiLenTuong.AutoSize = true;
		this.ckbShareBaiLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbShareBaiLenTuong.Location = new System.Drawing.Point(10, 22);
		this.ckbShareBaiLenTuong.Name = "ckbShareBaiLenTuong";
		this.ckbShareBaiLenTuong.Size = new System.Drawing.Size(139, 20);
		this.ckbShareBaiLenTuong.TabIndex = 0;
		this.ckbShareBaiLenTuong.Text = "Share bài lên tường";
		this.ckbShareBaiLenTuong.UseVisualStyleBackColor = true;
		this.ckbShareBaiLenTuong.CheckedChanged += new System.EventHandler(E395331D);
		this.E81F1929.Location = new System.Drawing.Point(235, 79);
		this.E81F1929.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.E81F1929.Name = "nudDelayTo";
		this.E81F1929.Size = new System.Drawing.Size(56, 23);
		this.E81F1929.TabIndex = 58;
		this.nudDelayFrom.Location = new System.Drawing.Point(138, 79);
		this.nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudDelayFrom.Name = "nudDelayFrom";
		this.nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		this.nudDelayFrom.TabIndex = 57;
		this.label20.AutoSize = true;
		this.label20.Location = new System.Drawing.Point(200, 81);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(28, 16);
		this.label20.TabIndex = 61;
		this.label20.Text = "đê\u0301n";
		this.BBAD6FAA.AutoSize = true;
		this.BBAD6FAA.Location = new System.Drawing.Point(294, 81);
		this.BBAD6FAA.Name = "label19";
		this.BBAD6FAA.Size = new System.Drawing.Size(30, 16);
		this.BBAD6FAA.TabIndex = 60;
		this.BBAD6FAA.Text = "giây";
		this.label15.AutoSize = true;
		this.label15.Location = new System.Drawing.Point(11, 81);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(120, 16);
		this.label15.TabIndex = 59;
		this.label15.Text = "Khoảng cách share:";
		this.plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plVanBan.Controls.Add(this.D68BD4BD);
		this.plVanBan.Controls.Add(this.linkLabel1);
		this.plVanBan.Controls.Add(this.E306A039);
		this.plVanBan.Controls.Add(this.button2);
		this.plVanBan.Controls.Add(this.rbNganCachKyTu);
		this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
		this.plVanBan.Controls.Add(this.FA8F62B8);
		this.plVanBan.Controls.Add(this.label8);
		this.plVanBan.Controls.Add(this.AF0C151F);
		this.plVanBan.Controls.Add(this.btnUp);
		this.plVanBan.Controls.Add(this.txtNoiDung);
		this.plVanBan.Controls.Add(this.lblStatus);
		this.plVanBan.Location = new System.Drawing.Point(33, 371);
		this.plVanBan.Name = "plVanBan";
		this.plVanBan.Size = new System.Drawing.Size(359, 169);
		this.plVanBan.TabIndex = 33;
		this.D68BD4BD.Cursor = System.Windows.Forms.Cursors.Help;
		this.D68BD4BD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D68BD4BD.Location = new System.Drawing.Point(328, 145);
		this.D68BD4BD.Name = "button6";
		this.D68BD4BD.Size = new System.Drawing.Size(23, 23);
		this.D68BD4BD.TabIndex = 191;
		this.D68BD4BD.Text = "?";
		this.D68BD4BD.UseVisualStyleBackColor = true;
		this.D68BD4BD.Click += new System.EventHandler(CFBD2AAE);
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(245, 148);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 190;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.E306A039.Cursor = System.Windows.Forms.Cursors.Help;
		this.E306A039.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E306A039.Location = new System.Drawing.Point(230, 189);
		this.E306A039.Name = "button3";
		this.E306A039.Size = new System.Drawing.Size(21, 23);
		this.E306A039.TabIndex = 44;
		this.E306A039.Text = "?";
		this.E306A039.UseVisualStyleBackColor = true;
		this.E306A039.Click += new System.EventHandler(F937F0A0);
		this.button2.Cursor = System.Windows.Forms.Cursors.Help;
		this.button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.Location = new System.Drawing.Point(230, 166);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(21, 23);
		this.button2.TabIndex = 45;
		this.button2.Text = "?";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(DA0C7929);
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(71, 189);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 42;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.rbNganCachMoiDong.AutoSize = true;
		this.rbNganCachMoiDong.Checked = true;
		this.rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachMoiDong.Location = new System.Drawing.Point(71, 168);
		this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		this.rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		this.rbNganCachMoiDong.TabIndex = 43;
		this.rbNganCachMoiDong.TabStop = true;
		this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
		this.rbNganCachMoiDong.CheckedChanged += new System.EventHandler(EABA11A7);
		this.FA8F62B8.AutoSize = true;
		this.FA8F62B8.Location = new System.Drawing.Point(6, 168);
		this.FA8F62B8.Name = "label9";
		this.FA8F62B8.Size = new System.Drawing.Size(64, 16);
		this.FA8F62B8.TabIndex = 41;
		this.FA8F62B8.Text = "Tùy chọn:";
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(5, 147);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(143, 16);
		this.label8.TabIndex = 40;
		this.label8.Text = "(Spin nội dung {a|b|c})";
		this.AF0C151F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.AF0C151F.BackgroundImage = Resources.Bitmap_83;
		this.AF0C151F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AF0C151F.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.AF0C151F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.AF0C151F.Location = new System.Drawing.Point(302, -1);
		this.AF0C151F.Name = "btnDown";
		this.AF0C151F.Size = new System.Drawing.Size(25, 25);
		this.AF0C151F.TabIndex = 38;
		this.AF0C151F.Click += new System.EventHandler(AF0C151F_Click);
		this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnUp.BackgroundImage = Resources.E536C319;
		this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.Location = new System.Drawing.Point(333, -1);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new System.Drawing.Size(25, 25);
		this.btnUp.TabIndex = 39;
		this.btnUp.Click += new System.EventHandler(btnUp_Click);
		this.txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtNoiDung.Location = new System.Drawing.Point(7, 26);
		this.txtNoiDung.Name = "txtNoiDung";
		this.txtNoiDung.Size = new System.Drawing.Size(344, 119);
		this.txtNoiDung.TabIndex = 34;
		this.txtNoiDung.Text = "";
		this.txtNoiDung.WordWrap = false;
		this.txtNoiDung.TextChanged += new System.EventHandler(EF9D66AF);
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(145, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		this.F392B92B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F392B92B.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.F392B92B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F392B92B.FlatAppearance.BorderSize = 0;
		this.F392B92B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F392B92B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F392B92B.ForeColor = System.Drawing.Color.White;
		this.F392B92B.Location = new System.Drawing.Point(453, 570);
		this.F392B92B.Name = "btnAdd";
		this.F392B92B.Size = new System.Drawing.Size(92, 29);
		this.F392B92B.TabIndex = 3;
		this.F392B92B.Text = "Thêm";
		this.F392B92B.UseVisualStyleBackColor = false;
		this.F392B92B.Click += new System.EventHandler(F392B92B_Click);
		this.ckbVanBan.AutoSize = true;
		this.ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbVanBan.Location = new System.Drawing.Point(14, 344);
		this.ckbVanBan.Name = "ckbVanBan";
		this.ckbVanBan.Size = new System.Drawing.Size(112, 20);
		this.ckbVanBan.TabIndex = 32;
		this.ckbVanBan.Text = "Nội dung share";
		this.ckbVanBan.UseVisualStyleBackColor = true;
		this.ckbVanBan.CheckedChanged += new System.EventHandler(B69FE71E);
		this.txtTenHanhDong.Location = new System.Drawing.Point(138, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(193, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(11, 52);
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
		this.btnCancel.Location = new System.Drawing.Point(563, 570);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.B58A490C);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(1097, 37);
		this.bunifuCards1.TabIndex = 28;
		this.toolTip_0.AutomaticDelay = 100;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1100, 612);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDShareBaiTut";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A53360B8_Load);
		this.B58A490C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.F3A90399.ResumeLayout(false);
		this.F3A90399.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D88C6D9B).EndInit();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.plDangBaiLenPage.ResumeLayout(false);
		this.plDangBaiLenPage.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
		this.plDangBaiLenNhom.ResumeLayout(false);
		this.plDangBaiLenNhom.PerformLayout();
		this.panel4.ResumeLayout(false);
		this.panel4.PerformLayout();
		this.DBB7ABA5.ResumeLayout(false);
		this.DBB7ABA5.PerformLayout();
		this.E424F197.ResumeLayout(false);
		this.E424F197.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C31FD48E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D2A759AE).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWaitTo2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudTimeWaitTo1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.C1B5CFAD).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D021AB26).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CE21A791).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E81F1929).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		this.plVanBan.ResumeLayout(false);
		this.plVanBan.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
