using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBaiVietProfile : Form
{
	private JSON_Settings F6070925;

	private string string_0;

	private string string_1;

	private string E5076395;

	private int int_0;

	public static bool EF1FC404;

	private IContainer EAAAEDB1 = null;

	private BunifuDragControl A025A3B5;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown E297A193;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label ABAD46A5;

	private Label A3241C0E;

	private Label BEA75C16;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button D391D327;

	private BunifuCards bunifuCards1;

	private Panel E718738C;

	private Button E986A226;

	private PictureBox DF058313;

	private BunifuCustomLabel AD10E78D;

	private Panel plComment;

	private Label lblStatus;

	private CheckBox F2ADD10F;

	private CheckBox EAB6F620;

	private CheckBox D390683A;

	private Label F9ADFC85;

	private NumericUpDown nudSoLuongUidFrom;

	private Label CABA3402;

	private Label label19;

	private NumericUpDown F92F358E;

	private Label E93DB418;

	private RichTextBox txtUid;

	private Panel plAnh;

	private CheckBox ckbSendAnh;

	private RichTextBox txtComment;

	private CheckBox ckbTuDongXoaUid;

	private RadioButton rbNganCachKyTu;

	private RadioButton BB1738AE;

	private Label label9;

	private CheckBox ckbRandomGoVanBan;

	private Button D23FA287;

	private RadioButton rbListUid;

	private RadioButton EB2DCE06;

	private Label label10;

	private TextBox txtPathFileUid;

	private TextBox D41A373B;

	private Label label12;

	private Button button3;

	private Button FD133505;

	private Button button4;

	private LinkLabel linkLabel1;

	private Label EA12BB16;

	private Button button5;

	public fHDBaiVietProfile(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		EF1FC404 = false;
		string_0 = string_2;
		E5076395 = string_3;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDBaiVietProfile").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBaiVietProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\",  \"nudSoLuongBaiVietFrom\": \"1\",  \"nudSoLuongBaiVietTo\": \"3\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",\"txtUid\": \"\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết Profile');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBaiVietProfile");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			D391D327.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F6070925 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void B03C2C9E()
	{
		Language.smethod_0(AD10E78D);
		Language.smethod_0(label1);
		Language.smethod_0(F9ADFC85);
		Language.smethod_0(E93DB418);
		Language.smethod_0(label19);
		Language.smethod_0(ABAD46A5);
		Language.smethod_0(BEA75C16);
		Language.smethod_0(label5);
		Language.smethod_0(label7);
		Language.smethod_0(A3241C0E);
		Language.smethod_0(label10);
		Language.smethod_0(button4);
		Language.smethod_0(EB2DCE06);
		Language.smethod_0(D23FA287);
		Language.smethod_0(rbListUid);
		Language.smethod_0(ckbTuDongXoaUid);
		Language.smethod_0(ckbRandomGoVanBan);
		Language.smethod_0(EAB6F620);
		Language.smethod_0(D390683A);
		Language.smethod_0(F2ADD10F);
		Language.smethod_0(lblStatus);
		Language.smethod_0(label9);
		Language.smethod_0(BB1738AE);
		Language.smethod_0(FD133505);
		Language.smethod_0(rbNganCachKyTu);
		Language.smethod_0(button3);
		Language.smethod_0(ckbSendAnh);
		Language.smethod_0(label12);
		Language.smethod_0(D391D327);
		Language.smethod_0(btnCancel);
	}

	private void F1A91B0B(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = F6070925.GetValueInt("nudSoLuongUidFrom");
			F92F358E.Value = F6070925.GetValueInt("nudSoLuongUidTo");
			nudSoLuongBaiVietFrom.Value = F6070925.GetValueInt("nudSoLuongBaiVietFrom");
			nudSoLuongBaiVietTo.Value = F6070925.GetValueInt("nudSoLuongBaiVietTo");
			nudDelayFrom.Value = F6070925.GetValueInt("nudDelayFrom");
			E297A193.Value = F6070925.GetValueInt("nudDelayTo");
			int num = F6070925.GetValueInt("typeListUid");
			if (num == 1)
			{
				EB2DCE06.Checked = true;
			}
			else
			{
				rbListUid.Checked = true;
			}
			txtPathFileUid.Text = F6070925.GetValue("txtPathFileUid");
			txtUid.Text = F6070925.GetValue("txtUid");
			EAB6F620.Checked = F6070925.GetValueBool("ckbInteract");
			D390683A.Checked = F6070925.GetValueBool("ckbShareWall");
			F2ADD10F.Checked = F6070925.GetValueBool("ckbComment");
			txtComment.Text = F6070925.GetValue("txtComment");
			ckbSendAnh.Checked = F6070925.GetValueBool("ckbSendAnh");
			D41A373B.Text = F6070925.GetValue("txtAnh");
			ckbTuDongXoaUid.Checked = F6070925.GetValueBool("ckbTuDongXoaUid");
			ckbRandomGoVanBan.Checked = F6070925.GetValueBool("ckbRandomGoVanBan");
			if (F6070925.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				BB1738AE.Checked = true;
			}
		}
		catch
		{
		}
		BEB7C3A5();
	}

	private void E986A226_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D391D327_Click(object sender, EventArgs e)
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
			if (EB2DCE06.Checked)
			{
				if (txtPathFileUid.Text.Trim() == "")
				{
					MessageBoxHelper.Show("Vui lo\u0300ng chọn File Uid!", 3);
					return;
				}
			}
			else
			{
				List<string> a2AB53A = txtUid.Lines.ToList();
				a2AB53A = Common.RemoveEmptyItems(a2AB53A);
				if (a2AB53A.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!", 3);
					return;
				}
			}
			if (F2ADD10F.Checked)
			{
				List<string> a2AB53A2 = txtComment.Lines.ToList();
				a2AB53A2 = Common.RemoveEmptyItems(a2AB53A2);
				if (a2AB53A2.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			if (ckbSendAnh.Checked && D41A373B.Text.Trim().Length == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng chọn folder ảnh!", 3);
				return;
			}
			JSON_Settings gClass = new JSON_Settings();
			gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
			gClass.GetJson("nudSoLuongUidTo", F92F358E.Value);
			gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass.GetJson("nudDelayTo", E297A193.Value);
			if (EB2DCE06.Checked)
			{
				gClass.GetJson("typeListUid", 1);
			}
			else
			{
				gClass.GetJson("typeListUid", 0);
			}
			gClass.GetJson("txtPathFileUid", txtPathFileUid.Text.Trim());
			gClass.GetJson("txtUid", txtUid.Text.Trim());
			gClass.GetJson("ckbInteract", EAB6F620.Checked);
			gClass.GetJson("ckbShareWall", D390683A.Checked);
			gClass.GetJson("ckbComment", F2ADD10F.Checked);
			gClass.GetJson("txtComment", txtComment.Text.Trim());
			gClass.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass.GetJson("txtAnh", D41A373B.Text.Trim());
			gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
			gClass.GetJson("ckbRandomGoVanBan", ckbRandomGoVanBan.Checked);
			int num = 0;
			if (rbNganCachKyTu.Checked)
			{
				num = 1;
			}
			gClass.GetJson("typeNganCach", num);
			string string_ = gClass.D9A09B34();
			if (InteractSQL.smethod_11(string_0, text, string_1, string_))
			{
				EF1FC404 = true;
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
			if (EB2DCE06.Checked)
			{
				if (txtPathFileUid.Text.Trim() == "")
				{
					MessageBoxHelper.Show("Vui lo\u0300ng chọn File Uid!", 3);
					return;
				}
			}
			else
			{
				List<string> a2AB53A3 = txtUid.Lines.ToList();
				a2AB53A3 = Common.RemoveEmptyItems(a2AB53A3);
				if (a2AB53A3.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!", 3);
					return;
				}
			}
			if (F2ADD10F.Checked)
			{
				List<string> a2AB53A4 = txtComment.Lines.ToList();
				a2AB53A4 = Common.RemoveEmptyItems(a2AB53A4);
				if (a2AB53A4.Count == 0)
				{
					MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
					return;
				}
			}
			if (ckbSendAnh.Checked && D41A373B.Text.Trim().Length == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng chọn folder ảnh!", 3);
				return;
			}
			JSON_Settings gClass2 = new JSON_Settings();
			gClass2.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
			gClass2.GetJson("nudSoLuongUidTo", F92F358E.Value);
			gClass2.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			gClass2.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			gClass2.GetJson("nudDelayFrom", nudDelayFrom.Value);
			gClass2.GetJson("nudDelayTo", E297A193.Value);
			if (EB2DCE06.Checked)
			{
				gClass2.GetJson("typeListUid", 1);
			}
			else
			{
				gClass2.GetJson("typeListUid", 0);
			}
			gClass2.GetJson("txtPathFileUid", txtPathFileUid.Text.Trim());
			gClass2.GetJson("txtUid", txtUid.Text.Trim());
			gClass2.GetJson("ckbInteract", EAB6F620.Checked);
			gClass2.GetJson("ckbShareWall", D390683A.Checked);
			gClass2.GetJson("ckbComment", F2ADD10F.Checked);
			gClass2.GetJson("txtComment", txtComment.Text.Trim());
			gClass2.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.GetJson("txtAnh", D41A373B.Text.Trim());
			gClass2.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
			gClass2.GetJson("ckbRandomGoVanBan", ckbRandomGoVanBan.Checked);
			int num2 = 0;
			if (rbNganCachKyTu.Checked)
			{
				num2 = 1;
			}
			gClass2.GetJson("typeNganCach", num2);
			gClass2.GetJson("ckbSendAnh", ckbSendAnh.Checked);
			gClass2.GetJson("txtAnh", D41A373B.Text.Trim());
			string text3 = gClass2.D9A09B34();
			if (InteractSQL.smethod_13(E5076395, text2, text3))
			{
				EF1FC404 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F838F5BE(object sender, EventArgs e)
	{
		Close();
	}

	private void BFB79738(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!BB1738AE.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void BEB7C3A5()
	{
		method_2(null, null);
		D6153632(null, null);
		EB2DCE06_CheckedChanged(null, null);
		C7A15C81(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void D6153632(object sender, EventArgs e)
	{
		plComment.Enabled = F2ADD10F.Checked;
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			rbListUid.Text = string.Format(Language.GetValue("Nhập (Mỗi Uid 1 dòng) ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void DD3B6618(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
		D41A373B.Text = Common.SelectFolder();
	}

	private void E83C8505(object sender, EventArgs e)
	{
	}

	private void txtComment_MouseEnter(object sender, EventArgs e)
	{
	}

	private void panel1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			ckbRandomGoVanBan.Visible = true;
		}
	}

	private void D23FA287_Click(object sender, EventArgs e)
	{
		txtPathFileUid.Text = Common.SelectFile();
	}

	private void EB2DCE06_CheckedChanged(object sender, EventArgs e)
	{
		txtPathFileUid.Enabled = EB2DCE06.Checked;
		D23FA287.Enabled = EB2DCE06.Checked;
	}

	private void C7A15C81(object sender, EventArgs e)
	{
		txtUid.Enabled = rbListUid.Checked;
	}

	private void FD133505_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtComment.Focus();
	}

	private void F0086B2D(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.\r\nVí dụ: 15465478242/posts");
	}

	private void BB1738AE_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void button5_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của UID!");
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && EAAAEDB1 != null)
		{
			EAAAEDB1.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.EAAAEDB1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietProfile));
		this.A025A3B5 = new Bunifu.Framework.UI.BunifuDragControl(this.EAAAEDB1);
		this.AD10E78D = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.EAAAEDB1);
		this.E718738C = new System.Windows.Forms.Panel();
		this.E986A226 = new System.Windows.Forms.Button();
		this.DF058313 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.button4 = new System.Windows.Forms.Button();
		this.D23FA287 = new System.Windows.Forms.Button();
		this.rbListUid = new System.Windows.Forms.RadioButton();
		this.EB2DCE06 = new System.Windows.Forms.RadioButton();
		this.plComment = new System.Windows.Forms.Panel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.EA12BB16 = new System.Windows.Forms.Label();
		this.button5 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.FD133505 = new System.Windows.Forms.Button();
		this.rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		this.BB1738AE = new System.Windows.Forms.RadioButton();
		this.label9 = new System.Windows.Forms.Label();
		this.txtComment = new System.Windows.Forms.RichTextBox();
		this.lblStatus = new System.Windows.Forms.Label();
		this.plAnh = new System.Windows.Forms.Panel();
		this.D41A373B = new System.Windows.Forms.TextBox();
		this.label12 = new System.Windows.Forms.Label();
		this.ckbSendAnh = new System.Windows.Forms.CheckBox();
		this.txtUid = new System.Windows.Forms.RichTextBox();
		this.label10 = new System.Windows.Forms.Label();
		this.F9ADFC85 = new System.Windows.Forms.Label();
		this.nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		this.CABA3402 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.F92F358E = new System.Windows.Forms.NumericUpDown();
		this.E93DB418 = new System.Windows.Forms.Label();
		this.F2ADD10F = new System.Windows.Forms.CheckBox();
		this.ckbRandomGoVanBan = new System.Windows.Forms.CheckBox();
		this.ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		this.D390683A = new System.Windows.Forms.CheckBox();
		this.EAB6F620 = new System.Windows.Forms.CheckBox();
		this.E297A193 = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		this.nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		this.nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		this.txtPathFileUid = new System.Windows.Forms.TextBox();
		this.txtTenHanhDong = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.ABAD46A5 = new System.Windows.Forms.Label();
		this.A3241C0E = new System.Windows.Forms.Label();
		this.BEA75C16 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.D391D327 = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.E718738C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DF058313).BeginInit();
		this.panel1.SuspendLayout();
		this.plComment.SuspendLayout();
		this.plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.F92F358E).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.E297A193).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).BeginInit();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.A025A3B5.Fixed = true;
		this.A025A3B5.Horizontal = true;
		this.A025A3B5.TargetControl = this.AD10E78D;
		this.A025A3B5.Vertical = true;
		this.AD10E78D.BackColor = System.Drawing.Color.Transparent;
		this.AD10E78D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.AD10E78D.Dock = System.Windows.Forms.DockStyle.Fill;
		this.AD10E78D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.AD10E78D.ForeColor = System.Drawing.Color.Black;
		this.AD10E78D.Location = new System.Drawing.Point(0, 0);
		this.AD10E78D.Name = "bunifuCustomLabel1";
		this.AD10E78D.Size = new System.Drawing.Size(680, 31);
		this.AD10E78D.TabIndex = 12;
		this.AD10E78D.Text = "Cấu hình Bài viết Profile";
		this.AD10E78D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.E718738C;
		this.bunifuDragControl_0.Vertical = true;
		this.E718738C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.E718738C.BackColor = System.Drawing.Color.White;
		this.E718738C.Controls.Add(this.E986A226);
		this.E718738C.Controls.Add(this.DF058313);
		this.E718738C.Controls.Add(this.AD10E78D);
		this.E718738C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.E718738C.Location = new System.Drawing.Point(0, 3);
		this.E718738C.Name = "pnlHeader";
		this.E718738C.Size = new System.Drawing.Size(680, 31);
		this.E718738C.TabIndex = 9;
		this.E986A226.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.E986A226.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E986A226.FlatAppearance.BorderSize = 0;
		this.E986A226.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.E986A226.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E986A226.ForeColor = System.Drawing.Color.White;
		this.E986A226.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		this.E986A226.Location = new System.Drawing.Point(649, 1);
		this.E986A226.Name = "button1";
		this.E986A226.Size = new System.Drawing.Size(30, 30);
		this.E986A226.TabIndex = 77;
		this.E986A226.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.E986A226.UseVisualStyleBackColor = true;
		this.E986A226.Click += new System.EventHandler(E986A226_Click);
		this.DF058313.Cursor = System.Windows.Forms.Cursors.Default;
		this.DF058313.Image = Resources.Bitmap_4;
		this.DF058313.Location = new System.Drawing.Point(3, 2);
		this.DF058313.Name = "pictureBox1";
		this.DF058313.Size = new System.Drawing.Size(34, 27);
		this.DF058313.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.DF058313.TabIndex = 76;
		this.DF058313.TabStop = false;
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.panel1.Controls.Add(this.button4);
		this.panel1.Controls.Add(this.D23FA287);
		this.panel1.Controls.Add(this.rbListUid);
		this.panel1.Controls.Add(this.EB2DCE06);
		this.panel1.Controls.Add(this.plComment);
		this.panel1.Controls.Add(this.plAnh);
		this.panel1.Controls.Add(this.ckbSendAnh);
		this.panel1.Controls.Add(this.txtUid);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.F9ADFC85);
		this.panel1.Controls.Add(this.nudSoLuongUidFrom);
		this.panel1.Controls.Add(this.CABA3402);
		this.panel1.Controls.Add(this.label19);
		this.panel1.Controls.Add(this.F92F358E);
		this.panel1.Controls.Add(this.E93DB418);
		this.panel1.Controls.Add(this.F2ADD10F);
		this.panel1.Controls.Add(this.ckbRandomGoVanBan);
		this.panel1.Controls.Add(this.ckbTuDongXoaUid);
		this.panel1.Controls.Add(this.D390683A);
		this.panel1.Controls.Add(this.EAB6F620);
		this.panel1.Controls.Add(this.E297A193);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietTo);
		this.panel1.Controls.Add(this.nudDelayFrom);
		this.panel1.Controls.Add(this.nudSoLuongBaiVietFrom);
		this.panel1.Controls.Add(this.txtPathFileUid);
		this.panel1.Controls.Add(this.txtTenHanhDong);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.ABAD46A5);
		this.panel1.Controls.Add(this.A3241C0E);
		this.panel1.Controls.Add(this.BEA75C16);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Controls.Add(this.D391D327);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(683, 432);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(panel1_Click);
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(BFB79738);
		this.button4.Cursor = System.Windows.Forms.Cursors.Help;
		this.button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button4.Location = new System.Drawing.Point(267, 167);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(21, 23);
		this.button4.TabIndex = 5;
		this.button4.Text = "?";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.D23FA287.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D23FA287.Location = new System.Drawing.Point(267, 189);
		this.D23FA287.Name = "btnChooseFileUid";
		this.D23FA287.Size = new System.Drawing.Size(63, 25);
		this.D23FA287.TabIndex = 156;
		this.D23FA287.Text = "Chọn";
		this.D23FA287.UseVisualStyleBackColor = true;
		this.D23FA287.Click += new System.EventHandler(D23FA287_Click);
		this.rbListUid.AutoSize = true;
		this.rbListUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbListUid.Location = new System.Drawing.Point(31, 213);
		this.rbListUid.Name = "rbListUid";
		this.rbListUid.Size = new System.Drawing.Size(174, 20);
		this.rbListUid.TabIndex = 163;
		this.rbListUid.Text = "Nhập (Mỗi Uid 1 dòng) (0)";
		this.rbListUid.UseVisualStyleBackColor = true;
		this.rbListUid.CheckedChanged += new System.EventHandler(C7A15C81);
		this.EB2DCE06.AutoSize = true;
		this.EB2DCE06.Checked = true;
		this.EB2DCE06.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EB2DCE06.Location = new System.Drawing.Point(31, 190);
		this.EB2DCE06.Name = "rbFileUid";
		this.EB2DCE06.Size = new System.Drawing.Size(94, 20);
		this.EB2DCE06.TabIndex = 163;
		this.EB2DCE06.TabStop = true;
		this.EB2DCE06.Text = "Nhập từ File";
		this.EB2DCE06.UseVisualStyleBackColor = true;
		this.EB2DCE06.CheckedChanged += new System.EventHandler(EB2DCE06_CheckedChanged);
		this.plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plComment.Controls.Add(this.linkLabel1);
		this.plComment.Controls.Add(this.EA12BB16);
		this.plComment.Controls.Add(this.button5);
		this.plComment.Controls.Add(this.button3);
		this.plComment.Controls.Add(this.FD133505);
		this.plComment.Controls.Add(this.rbNganCachKyTu);
		this.plComment.Controls.Add(this.BB1738AE);
		this.plComment.Controls.Add(this.label9);
		this.plComment.Controls.Add(this.txtComment);
		this.plComment.Controls.Add(this.lblStatus);
		this.plComment.Location = new System.Drawing.Point(369, 128);
		this.plComment.Name = "plComment";
		this.plComment.Size = new System.Drawing.Size(281, 193);
		this.plComment.TabIndex = 10;
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel1.Location = new System.Drawing.Point(163, 126);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(81, 16);
		this.linkLabel1.TabIndex = 187;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Random icon";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.EA12BB16.AutoSize = true;
		this.EA12BB16.Location = new System.Drawing.Point(5, 126);
		this.EA12BB16.Name = "label2";
		this.EA12BB16.Size = new System.Drawing.Size(131, 16);
		this.EA12BB16.TabIndex = 186;
		this.EA12BB16.Text = "Spin content: {a|b|c}";
		this.button5.Cursor = System.Windows.Forms.Cursors.Help;
		this.button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.Location = new System.Drawing.Point(247, 123);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(23, 23);
		this.button5.TabIndex = 185;
		this.button5.Text = "?";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.button3.Cursor = System.Windows.Forms.Cursors.Help;
		this.button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.Location = new System.Drawing.Point(229, 168);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(21, 23);
		this.button3.TabIndex = 4;
		this.button3.Text = "?";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(F0086B2D);
		this.FD133505.Cursor = System.Windows.Forms.Cursors.Help;
		this.FD133505.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FD133505.Location = new System.Drawing.Point(229, 145);
		this.FD133505.Name = "button2";
		this.FD133505.Size = new System.Drawing.Size(21, 23);
		this.FD133505.TabIndex = 4;
		this.FD133505.Text = "?";
		this.FD133505.UseVisualStyleBackColor = true;
		this.FD133505.Click += new System.EventHandler(FD133505_Click);
		this.rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.rbNganCachKyTu.AutoSize = true;
		this.rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
		this.rbNganCachKyTu.Name = "rbNganCachKyTu";
		this.rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		this.rbNganCachKyTu.TabIndex = 3;
		this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		this.rbNganCachKyTu.UseVisualStyleBackColor = true;
		this.rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		this.BB1738AE.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.BB1738AE.AutoSize = true;
		this.BB1738AE.Checked = true;
		this.BB1738AE.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB1738AE.Location = new System.Drawing.Point(70, 147);
		this.BB1738AE.Name = "rbNganCachMoiDong";
		this.BB1738AE.Size = new System.Drawing.Size(155, 20);
		this.BB1738AE.TabIndex = 3;
		this.BB1738AE.TabStop = true;
		this.BB1738AE.Text = "Nội dung chỉ có 1 dòng";
		this.BB1738AE.UseVisualStyleBackColor = true;
		this.BB1738AE.CheckedChanged += new System.EventHandler(BB1738AE_CheckedChanged);
		this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(5, 147);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(64, 16);
		this.label9.TabIndex = 2;
		this.label9.Text = "Tùy chọn:";
		this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtComment.Location = new System.Drawing.Point(7, 25);
		this.txtComment.Name = "txtComment";
		this.txtComment.Size = new System.Drawing.Size(263, 99);
		this.txtComment.TabIndex = 1;
		this.txtComment.Text = "";
		this.txtComment.WordWrap = false;
		this.txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		this.txtComment.MouseEnter += new System.EventHandler(txtComment_MouseEnter);
		this.txtComment.MouseLeave += new System.EventHandler(E83C8505);
		this.lblStatus.AutoSize = true;
		this.lblStatus.Location = new System.Drawing.Point(3, 5);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(139, 16);
		this.lblStatus.TabIndex = 0;
		this.lblStatus.Text = "Nội dung bình luận (0):";
		this.plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plAnh.Controls.Add(this.D41A373B);
		this.plAnh.Controls.Add(this.label12);
		this.plAnh.Enabled = false;
		this.plAnh.Location = new System.Drawing.Point(369, 349);
		this.plAnh.Name = "plAnh";
		this.plAnh.Size = new System.Drawing.Size(281, 31);
		this.plAnh.TabIndex = 162;
		this.D41A373B.Location = new System.Drawing.Point(136, 3);
		this.D41A373B.Name = "txtAnh";
		this.D41A373B.Size = new System.Drawing.Size(140, 23);
		this.D41A373B.TabIndex = 159;
		this.label12.AutoSize = true;
		this.label12.Location = new System.Drawing.Point(3, 6);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(137, 16);
		this.label12.TabIndex = 158;
		this.label12.Text = "Đường dẫn folder ảnh:";
		this.ckbSendAnh.AutoSize = true;
		this.ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbSendAnh.Location = new System.Drawing.Point(351, 327);
		this.ckbSendAnh.Name = "ckbSendAnh";
		this.ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		this.ckbSendAnh.TabIndex = 161;
		this.ckbSendAnh.Text = "Bình luận ảnh";
		this.ckbSendAnh.UseVisualStyleBackColor = true;
		this.ckbSendAnh.CheckedChanged += new System.EventHandler(DD3B6618);
		this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtUid.Location = new System.Drawing.Point(31, 236);
		this.txtUid.Name = "txtUid";
		this.txtUid.Size = new System.Drawing.Size(299, 115);
		this.txtUid.TabIndex = 117;
		this.txtUid.Text = "";
		this.txtUid.WordWrap = false;
		this.txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(27, 170);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(241, 16);
		this.label10.TabIndex = 116;
		this.label10.Text = "Nhập danh sách ID Cá nhân/Nhóm/Page:";
		this.F9ADFC85.AutoSize = true;
		this.F9ADFC85.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.F9ADFC85.Location = new System.Drawing.Point(27, 81);
		this.F9ADFC85.Name = "label49";
		this.F9ADFC85.Size = new System.Drawing.Size(85, 16);
		this.F9ADFC85.TabIndex = 92;
		this.F9ADFC85.Text = "Sô\u0301 lươ\u0323ng Uid:";
		this.nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.nudSoLuongUidFrom.Location = new System.Drawing.Point(135, 79);
		this.nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		this.nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		this.nudSoLuongUidFrom.TabIndex = 1;
		this.nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		this.CABA3402.AutoSize = true;
		this.CABA3402.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.CABA3402.Location = new System.Drawing.Point(290, 81);
		this.CABA3402.Name = "label68";
		this.CABA3402.Size = new System.Drawing.Size(25, 16);
		this.CABA3402.TabIndex = 99;
		this.CABA3402.Text = "Uid";
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.label19.Location = new System.Drawing.Point(27, 112);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(94, 16);
		this.label19.TabIndex = 101;
		this.label19.Text = "Sô\u0301 ba\u0300i viết/uid:";
		this.F92F358E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.F92F358E.Location = new System.Drawing.Point(232, 79);
		this.F92F358E.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.F92F358E.Name = "nudSoLuongUidTo";
		this.F92F358E.Size = new System.Drawing.Size(56, 23);
		this.F92F358E.TabIndex = 2;
		this.F92F358E.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.E93DB418.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.E93DB418.Location = new System.Drawing.Point(197, 81);
		this.E93DB418.Name = "label66";
		this.E93DB418.Size = new System.Drawing.Size(29, 16);
		this.E93DB418.TabIndex = 105;
		this.E93DB418.Text = "đê\u0301n";
		this.E93DB418.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.F2ADD10F.AutoSize = true;
		this.F2ADD10F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F2ADD10F.Location = new System.Drawing.Point(351, 103);
		this.F2ADD10F.Name = "ckbComment";
		this.F2ADD10F.Size = new System.Drawing.Size(127, 20);
		this.F2ADD10F.TabIndex = 9;
		this.F2ADD10F.Text = "Bi\u0300nh luâ\u0323n văn bản";
		this.F2ADD10F.UseVisualStyleBackColor = true;
		this.F2ADD10F.CheckedChanged += new System.EventHandler(D6153632);
		this.ckbRandomGoVanBan.AutoSize = true;
		this.ckbRandomGoVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbRandomGoVanBan.Location = new System.Drawing.Point(31, 383);
		this.ckbRandomGoVanBan.Name = "ckbRandomGoVanBan";
		this.ckbRandomGoVanBan.Size = new System.Drawing.Size(140, 20);
		this.ckbRandomGoVanBan.TabIndex = 8;
		this.ckbRandomGoVanBan.Text = "Random go\u0303 văn ba\u0309n";
		this.ckbRandomGoVanBan.UseVisualStyleBackColor = true;
		this.ckbRandomGoVanBan.Visible = false;
		this.ckbTuDongXoaUid.AutoSize = true;
		this.ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 357);
		this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		this.ckbTuDongXoaUid.Size = new System.Drawing.Size(303, 20);
		this.ckbTuDongXoaUid.TabIndex = 8;
		this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
		this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		this.D390683A.AutoSize = true;
		this.D390683A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D390683A.Location = new System.Drawing.Point(351, 77);
		this.D390683A.Name = "ckbShareWall";
		this.D390683A.Size = new System.Drawing.Size(167, 20);
		this.D390683A.TabIndex = 8;
		this.D390683A.Text = "Chia sẻ ba\u0300i viê\u0301t về tường";
		this.D390683A.UseVisualStyleBackColor = true;
		this.EAB6F620.AutoSize = true;
		this.EAB6F620.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EAB6F620.Location = new System.Drawing.Point(351, 51);
		this.EAB6F620.Name = "ckbInteract";
		this.EAB6F620.Size = new System.Drawing.Size(93, 20);
		this.EAB6F620.TabIndex = 7;
		this.EAB6F620.Text = "Like ba\u0300i viê\u0301t";
		this.EAB6F620.UseVisualStyleBackColor = true;
		this.E297A193.Location = new System.Drawing.Point(232, 140);
		this.E297A193.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.E297A193.Name = "nudDelayTo";
		this.E297A193.Size = new System.Drawing.Size(56, 23);
		this.E297A193.TabIndex = 6;
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
		this.txtPathFileUid.Location = new System.Drawing.Point(135, 190);
		this.txtPathFileUid.Name = "txtPathFileUid";
		this.txtPathFileUid.Size = new System.Drawing.Size(126, 23);
		this.txtPathFileUid.TabIndex = 0;
		this.txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		this.txtTenHanhDong.Name = "txtTenHanhDong";
		this.txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		this.txtTenHanhDong.TabIndex = 0;
		this.label7.Location = new System.Drawing.Point(197, 142);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(29, 16);
		this.label7.TabIndex = 38;
		this.label7.Text = "đê\u0301n";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ABAD46A5.Location = new System.Drawing.Point(197, 112);
		this.ABAD46A5.Name = "label3";
		this.ABAD46A5.Size = new System.Drawing.Size(29, 16);
		this.ABAD46A5.TabIndex = 37;
		this.ABAD46A5.Text = "đê\u0301n";
		this.ABAD46A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.A3241C0E.AutoSize = true;
		this.A3241C0E.Location = new System.Drawing.Point(290, 142);
		this.A3241C0E.Name = "label6";
		this.A3241C0E.Size = new System.Drawing.Size(30, 16);
		this.A3241C0E.TabIndex = 36;
		this.A3241C0E.Text = "giây";
		this.BEA75C16.AutoSize = true;
		this.BEA75C16.Location = new System.Drawing.Point(290, 112);
		this.BEA75C16.Name = "label4";
		this.BEA75C16.Size = new System.Drawing.Size(24, 16);
		this.BEA75C16.TabIndex = 35;
		this.BEA75C16.Text = "ba\u0300i";
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
		this.btnCancel.BackColor = System.Drawing.Color.Maroon;
		this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnCancel.FlatAppearance.BorderSize = 0;
		this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnCancel.ForeColor = System.Drawing.Color.White;
		this.btnCancel.Location = new System.Drawing.Point(349, 390);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 29);
		this.btnCancel.TabIndex = 12;
		this.btnCancel.Text = "Đóng";
		this.btnCancel.UseVisualStyleBackColor = false;
		this.btnCancel.Click += new System.EventHandler(F838F5BE);
		this.D391D327.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.D391D327.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D391D327.FlatAppearance.BorderSize = 0;
		this.D391D327.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.D391D327.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.D391D327.ForeColor = System.Drawing.Color.White;
		this.D391D327.Location = new System.Drawing.Point(242, 390);
		this.D391D327.Name = "btnAdd";
		this.D391D327.Size = new System.Drawing.Size(92, 29);
		this.D391D327.TabIndex = 11;
		this.D391D327.Text = "Thêm";
		this.D391D327.UseVisualStyleBackColor = false;
		this.D391D327.Click += new System.EventHandler(D391D327_Click);
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
		this.bunifuCards1.Controls.Add(this.E718738C);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(1, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(680, 37);
		this.bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(683, 432);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F1A91B0B);
		this.E718738C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DF058313).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.plComment.ResumeLayout(false);
		this.plComment.PerformLayout();
		this.plAnh.ResumeLayout(false);
		this.plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.F92F358E).EndInit();
		((System.ComponentModel.ISupportInitialize)this.E297A193).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudSoLuongBaiVietFrom).EndInit();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
