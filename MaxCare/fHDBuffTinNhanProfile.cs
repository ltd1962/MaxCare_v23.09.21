using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDBuffTinNhanProfile : Form
{
	private JSON_Settings C3A835A3;

	private string string_0;

	private string AD26D629;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl BBA04A10;

	private BunifuDragControl bunifuDragControl_0;

	private Panel BD155F8E;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label6;

	private Label CA218818;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards BDBC5F08;

	private Panel pnlHeader;

	private Button C18771A3;

	private PictureBox CCA55434;

	private BunifuCustomLabel B322AB19;

	private Panel B0924990;

	private Label E3B9521E;

	private Label lblStatus;

	private CheckBox D1A41F0B;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label68;

	private NumericUpDown nudSoLuongUidTo;

	private Label label66;

	private Label D4158516;

	private Label lblStatusUid;

	private RichTextBox txtUid;

	private Panel plAnh;

	private CheckBox A98B562F;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip toolTip_0;

	private Label A2B2A49D;

	private Label label9;

	private NumericUpDown nudSoLuongAnhFrom;

	private NumericUpDown DD1C3100;

	private Button btnDown;

	private Button btnUp;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label label11;

	private Panel plTuongTacTruocKhiNhanTin;

	private CheckBox ckbTuongTacKhiNhanTinComment;

	private CheckBox ckbTuongTacKhiNhanTinLike;

	private CheckBox F934AD24;

	private Panel C110E006;

	private RadioButton ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong;

	private RadioButton D90724BA;

	private Label label12;

	private RichTextBox txtTuongTacKhiNhanTinComment;

	private Label label14;

	private RadioButton rbTuongTacSauKhiNhanTin;

	private RadioButton rbTuongTacTruocKhiNhanTin;

	private Label label15;

	private Label label16;

	private Label label10;

	private TextBox B53A942C;

	private Button button3;

	private Button button2;

	private Button CC8D0085;

	private LinkLabel B2226DA1;

	private Label EC05C3AF;

	private Button button5;

	private Button button6;

	private CheckBox ckbAddFriend;

	private RichTextBox txtNoiDung;

	public fHDBuffTinNhanProfile(string C8A094A9, int int_1 = 0, string string_2 = "")
	{
		EA3765B7();
		bool_0 = false;
		string_0 = C8A094A9;
		string_1 = string_2;
		int_0 = int_1;
		if (InteractSQL.B484648C("", "HDBuffTinNhanProfile").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffTinNhanProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\", \"nudSoLuongAnhFrom\": \"1\", \"nudSoLuongAnhTo\": \"1\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",  \"txtUid\": \"\",  \"ckbNhanTinVanBan\": \"True\",  \"txtNoiDung\": \"hello\",  \"ckbSendAnh\": \"False\",  \"txtAnh\": \"\",  \"ckbTuDongXoaUid\": \"False\"}', 'Buff Tin nhắn Profile');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDBuffTinNhanProfile");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			AD26D629 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		C3A835A3 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void D6B12631(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = C3A835A3.GetValueInt("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = C3A835A3.GetValueInt("nudSoLuongUidTo", 3);
			nudSoLuongAnhFrom.Value = C3A835A3.GetValueInt("nudSoLuongAnhFrom", 1);
			DD1C3100.Value = C3A835A3.GetValueInt("nudSoLuongAnhTo", 1);
			nudDelayFrom.Value = C3A835A3.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = C3A835A3.GetValueInt("nudDelayTo", 5);
			txtUid.Text = C3A835A3.GetValue("txtUid");
			ckbAddFriend.Checked = C3A835A3.GetValueBool("ckbAddFriend");
			D1A41F0B.Checked = C3A835A3.GetValueBool("ckbNhanTinVanBan");
			txtNoiDung.Text = C3A835A3.GetValue("txtNoiDung");
			A98B562F.Checked = C3A835A3.GetValueBool("ckbSendAnh");
			B53A942C.Text = C3A835A3.GetValue("txtAnh");
			F934AD24.Checked = C3A835A3.GetValueBool("ckbTuongTacKhiNhanTin");
			if (C3A835A3.GetValueInt("typeTuongTacKhiNhanTin") == 0)
			{
				rbTuongTacTruocKhiNhanTin.Checked = true;
			}
			else
			{
				rbTuongTacSauKhiNhanTin.Checked = true;
			}
			ckbTuongTacKhiNhanTinLike.Checked = C3A835A3.GetValueBool("ckbTuongTacKhiNhanTinLike");
			ckbTuongTacKhiNhanTinComment.Checked = C3A835A3.GetValueBool("ckbTuongTacKhiNhanTinComment");
			txtTuongTacKhiNhanTinComment.Text = C3A835A3.GetValue("txtTuongTacKhiNhanTinComment");
			if (C3A835A3.GetValueInt("typeNganCachComment") == 1)
			{
				ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked = true;
			}
			else
			{
				D90724BA.Checked = true;
			}
			ckbTuDongXoaUid.Checked = C3A835A3.GetValueBool("ckbTuDongXoaUid");
			if (C3A835A3.GetValueInt("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		method_3();
	}

	private void C18771A3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BA286239(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> a2AB53A = txtUid.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!", 3);
			return;
		}
		if (D1A41F0B.Checked)
		{
			a2AB53A = txtNoiDung.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhắn!", 3);
				return;
			}
		}
		if (A98B562F.Checked && B53A942C.Text.Trim().Length == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng chọn folder ảnh!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.GetJson("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.GetJson("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.GetJson("nudSoLuongAnhTo", DD1C3100.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("ckbAddFriend", ckbAddFriend.Checked);
		gClass.GetJson("ckbNhanTinVanBan", D1A41F0B.Checked);
		gClass.GetJson("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.GetJson("ckbSendAnh", A98B562F.Checked);
		gClass.GetJson("txtAnh", B53A942C.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.GetJson("ckbTuongTacKhiNhanTin", F934AD24.Checked);
		if (rbTuongTacTruocKhiNhanTin.Checked)
		{
			gClass.GetJson("typeTuongTacKhiNhanTin", 0);
		}
		else
		{
			gClass.GetJson("typeTuongTacKhiNhanTin", 1);
		}
		gClass.GetJson("ckbTuongTacKhiNhanTinLike", ckbTuongTacKhiNhanTinLike.Checked);
		gClass.GetJson("ckbTuongTacKhiNhanTinComment", ckbTuongTacKhiNhanTinComment.Checked);
		gClass.GetJson("txtTuongTacKhiNhanTinComment", txtTuongTacKhiNhanTinComment.Text.Trim());
		int num = 0;
		if (ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked)
		{
			num = 1;
		}
		gClass.GetJson("typeNganCachComment", num);
		int num2 = 0;
		if (rbNganCachKyTu.Checked)
		{
			num2 = 1;
		}
		gClass.GetJson("typeNganCach", num2);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, AD26D629, string_))
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

	private void BD155F8E_Paint(object sender, PaintEventArgs e)
	{
		if (BD155F8E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BD155F8E.ClientSize.Width - num, BD155F8E.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_2()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung tin nhắn ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_3()
	{
		method_4(null, null);
		D1A41F0B_CheckedChanged(null, null);
		F934AD24_CheckedChanged(null, null);
		ckbTuongTacKhiNhanTinComment_CheckedChanged(null, null);
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void D1A41F0B_CheckedChanged(object sender, EventArgs e)
	{
		B0924990.Enabled = D1A41F0B.Checked;
	}

	private void D62FAAAD(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = txtUid.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatusUid.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid ca\u0301 nhân cần nhắn tin ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void A98B562F_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = A98B562F.Checked;
	}

	private void AC912432(object sender, EventArgs e)
	{
		B53A942C.Text = Common.SelectFolder();
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		B0924990.Height = 235;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		B0924990.Height = 185;
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void CCA55434_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void F934AD24_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacTruocKhiNhanTin.Enabled = F934AD24.Checked;
	}

	private void ckbTuongTacKhiNhanTinComment_CheckedChanged(object sender, EventArgs e)
	{
		C110E006.Enabled = ckbTuongTacKhiNhanTinComment.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		txtTuongTacKhiNhanTinComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
		txtTuongTacKhiNhanTinComment.Focus();
	}

	private void B6802515(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Có thể dùng [u] để thay thế tên của UID!");
	}

	private void B2226DA1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.ShowForm(new fHuongDanRandom());
	}

	private void B4AC553E(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		Common.ShowForm(new fHelpNhapComment());
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void EA3765B7()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBuffTinNhanProfile));
		BBA04A10 = new BunifuDragControl(icontainer_0);
		B322AB19 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		C18771A3 = new Button();
		CCA55434 = new PictureBox();
		BD155F8E = new Panel();
		ckbAddFriend = new CheckBox();
		plTuongTacTruocKhiNhanTin = new Panel();
		rbTuongTacSauKhiNhanTin = new RadioButton();
		ckbTuongTacKhiNhanTinComment = new CheckBox();
		rbTuongTacTruocKhiNhanTin = new RadioButton();
		label15 = new Label();
		ckbTuongTacKhiNhanTinLike = new CheckBox();
		label16 = new Label();
		C110E006 = new Panel();
		CC8D0085 = new Button();
		B2226DA1 = new LinkLabel();
		EC05C3AF = new Label();
		button3 = new Button();
		button2 = new Button();
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong = new RadioButton();
		D90724BA = new RadioButton();
		label12 = new Label();
		txtTuongTacKhiNhanTinComment = new RichTextBox();
		label14 = new Label();
		B0924990 = new Panel();
		txtNoiDung = new RichTextBox();
		button5 = new Button();
		button6 = new Button();
		btnDown = new Button();
		btnUp = new Button();
		rbNganCachKyTu = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		label11 = new Label();
		E3B9521E = new Label();
		lblStatus = new Label();
		plAnh = new Panel();
		label10 = new Label();
		B53A942C = new TextBox();
		A2B2A49D = new Label();
		label9 = new Label();
		nudSoLuongAnhFrom = new NumericUpDown();
		DD1C3100 = new NumericUpDown();
		A98B562F = new CheckBox();
		txtUid = new RichTextBox();
		D4158516 = new Label();
		lblStatusUid = new Label();
		label49 = new Label();
		nudSoLuongUidFrom = new NumericUpDown();
		label68 = new Label();
		nudSoLuongUidTo = new NumericUpDown();
		label66 = new Label();
		F934AD24 = new CheckBox();
		D1A41F0B = new CheckBox();
		ckbTuDongXoaUid = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		label6 = new Label();
		CA218818 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		BDBC5F08 = new BunifuCards();
		toolTip_0 = new ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)CCA55434).BeginInit();
		BD155F8E.SuspendLayout();
		plTuongTacTruocKhiNhanTin.SuspendLayout();
		C110E006.SuspendLayout();
		B0924990.SuspendLayout();
		plAnh.SuspendLayout();
		((ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		((ISupportInitialize)DD1C3100).BeginInit();
		((ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((ISupportInitialize)nudSoLuongUidTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		BDBC5F08.SuspendLayout();
		SuspendLayout();
		BBA04A10.Fixed = true;
		BBA04A10.Horizontal = true;
		BBA04A10.TargetControl = B322AB19;
		BBA04A10.Vertical = true;
		B322AB19.BackColor = Color.Transparent;
		B322AB19.Cursor = Cursors.SizeAll;
		B322AB19.Dock = DockStyle.Fill;
		B322AB19.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B322AB19.ForeColor = Color.Black;
		B322AB19.Location = new Point(0, 0);
		B322AB19.Name = "bunifuCustomLabel1";
		B322AB19.Size = new Size(1009, 31);
		B322AB19.TabIndex = 12;
		B322AB19.Text = "Cấu hình Buff Tin nhắn Profile";
		B322AB19.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(C18771A3);
		pnlHeader.Controls.Add(CCA55434);
		pnlHeader.Controls.Add(B322AB19);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(1009, 31);
		pnlHeader.TabIndex = 9;
		C18771A3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C18771A3.Cursor = Cursors.Hand;
		C18771A3.FlatAppearance.BorderSize = 0;
		C18771A3.FlatStyle = FlatStyle.Flat;
		C18771A3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C18771A3.ForeColor = Color.White;
		C18771A3.Image = (Image)componentResourceManager.GetObject("button1.Image");
		C18771A3.Location = new Point(978, 1);
		C18771A3.Name = "button1";
		C18771A3.Size = new Size(30, 30);
		C18771A3.TabIndex = 77;
		C18771A3.TextImageRelation = TextImageRelation.ImageBeforeText;
		C18771A3.UseVisualStyleBackColor = true;
		C18771A3.Click += C18771A3_Click;
		CCA55434.Cursor = Cursors.Default;
		CCA55434.Image = Resources.Bitmap_4;
		CCA55434.Location = new Point(3, 2);
		CCA55434.Name = "pictureBox1";
		CCA55434.Size = new Size(34, 27);
		CCA55434.SizeMode = PictureBoxSizeMode.Zoom;
		CCA55434.TabIndex = 76;
		CCA55434.TabStop = false;
		CCA55434.Click += CCA55434_Click;
		BD155F8E.BackColor = Color.White;
		BD155F8E.BorderStyle = BorderStyle.FixedSingle;
		BD155F8E.Controls.Add(ckbAddFriend);
		BD155F8E.Controls.Add(plTuongTacTruocKhiNhanTin);
		BD155F8E.Controls.Add(B0924990);
		BD155F8E.Controls.Add(plAnh);
		BD155F8E.Controls.Add(A98B562F);
		BD155F8E.Controls.Add(txtUid);
		BD155F8E.Controls.Add(D4158516);
		BD155F8E.Controls.Add(lblStatusUid);
		BD155F8E.Controls.Add(label49);
		BD155F8E.Controls.Add(nudSoLuongUidFrom);
		BD155F8E.Controls.Add(label68);
		BD155F8E.Controls.Add(nudSoLuongUidTo);
		BD155F8E.Controls.Add(label66);
		BD155F8E.Controls.Add(F934AD24);
		BD155F8E.Controls.Add(D1A41F0B);
		BD155F8E.Controls.Add(ckbTuDongXoaUid);
		BD155F8E.Controls.Add(nudDelayTo);
		BD155F8E.Controls.Add(nudDelayFrom);
		BD155F8E.Controls.Add(txtTenHanhDong);
		BD155F8E.Controls.Add(label7);
		BD155F8E.Controls.Add(label6);
		BD155F8E.Controls.Add(CA218818);
		BD155F8E.Controls.Add(label1);
		BD155F8E.Controls.Add(btnCancel);
		BD155F8E.Controls.Add(btnAdd);
		BD155F8E.Controls.Add(BDBC5F08);
		BD155F8E.Cursor = Cursors.Arrow;
		BD155F8E.Dock = DockStyle.Fill;
		BD155F8E.Location = new Point(0, 0);
		BD155F8E.Name = "panel1";
		BD155F8E.Size = new Size(1012, 447);
		BD155F8E.TabIndex = 0;
		BD155F8E.Paint += BD155F8E_Paint;
		ckbAddFriend.AutoSize = true;
		ckbAddFriend.Cursor = Cursors.Hand;
		ckbAddFriend.Location = new Point(677, 59);
		ckbAddFriend.Name = "ckbAddFriend";
		ckbAddFriend.Size = new Size(173, 20);
		ckbAddFriend.TabIndex = 164;
		ckbAddFriend.Text = "Kết bạn trước khi nhắn tin";
		ckbAddFriend.UseVisualStyleBackColor = true;
		plTuongTacTruocKhiNhanTin.BorderStyle = BorderStyle.FixedSingle;
		plTuongTacTruocKhiNhanTin.Controls.Add(rbTuongTacSauKhiNhanTin);
		plTuongTacTruocKhiNhanTin.Controls.Add(ckbTuongTacKhiNhanTinComment);
		plTuongTacTruocKhiNhanTin.Controls.Add(rbTuongTacTruocKhiNhanTin);
		plTuongTacTruocKhiNhanTin.Controls.Add(label15);
		plTuongTacTruocKhiNhanTin.Controls.Add(ckbTuongTacKhiNhanTinLike);
		plTuongTacTruocKhiNhanTin.Controls.Add(label16);
		plTuongTacTruocKhiNhanTin.Controls.Add(C110E006);
		plTuongTacTruocKhiNhanTin.Enabled = false;
		plTuongTacTruocKhiNhanTin.Location = new Point(695, 105);
		plTuongTacTruocKhiNhanTin.Name = "plTuongTacTruocKhiNhanTin";
		plTuongTacTruocKhiNhanTin.Size = new Size(297, 272);
		plTuongTacTruocKhiNhanTin.TabIndex = 163;
		rbTuongTacSauKhiNhanTin.AutoSize = true;
		rbTuongTacSauKhiNhanTin.Cursor = Cursors.Hand;
		rbTuongTacSauKhiNhanTin.Location = new Point(77, 28);
		rbTuongTacSauKhiNhanTin.Name = "rbTuongTacSauKhiNhanTin";
		rbTuongTacSauKhiNhanTin.Size = new Size(177, 20);
		rbTuongTacSauKhiNhanTin.TabIndex = 105;
		rbTuongTacSauKhiNhanTin.Text = "Tương tác sau khi nhắn tin";
		rbTuongTacSauKhiNhanTin.UseVisualStyleBackColor = true;
		ckbTuongTacKhiNhanTinComment.AutoSize = true;
		ckbTuongTacKhiNhanTinComment.Cursor = Cursors.Hand;
		ckbTuongTacKhiNhanTinComment.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuongTacKhiNhanTinComment.Location = new Point(161, 52);
		ckbTuongTacKhiNhanTinComment.Name = "ckbTuongTacKhiNhanTinComment";
		ckbTuongTacKhiNhanTinComment.Size = new Size(81, 20);
		ckbTuongTacKhiNhanTinComment.TabIndex = 96;
		ckbTuongTacKhiNhanTinComment.Text = "Comment";
		ckbTuongTacKhiNhanTinComment.UseVisualStyleBackColor = true;
		ckbTuongTacKhiNhanTinComment.CheckedChanged += ckbTuongTacKhiNhanTinComment_CheckedChanged;
		rbTuongTacTruocKhiNhanTin.AutoSize = true;
		rbTuongTacTruocKhiNhanTin.Checked = true;
		rbTuongTacTruocKhiNhanTin.Cursor = Cursors.Hand;
		rbTuongTacTruocKhiNhanTin.Location = new Point(77, 6);
		rbTuongTacTruocKhiNhanTin.Name = "rbTuongTacTruocKhiNhanTin";
		rbTuongTacTruocKhiNhanTin.Size = new Size(187, 20);
		rbTuongTacTruocKhiNhanTin.TabIndex = 106;
		rbTuongTacTruocKhiNhanTin.TabStop = true;
		rbTuongTacTruocKhiNhanTin.Text = "Tương tác trước khi nhắn tin";
		rbTuongTacTruocKhiNhanTin.UseVisualStyleBackColor = true;
		label15.AutoSize = true;
		label15.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label15.Location = new Point(6, 8);
		label15.Name = "label15";
		label15.Size = new Size(64, 16);
		label15.TabIndex = 103;
		label15.Text = "Tùy chọn:";
		ckbTuongTacKhiNhanTinLike.AutoSize = true;
		ckbTuongTacKhiNhanTinLike.Cursor = Cursors.Hand;
		ckbTuongTacKhiNhanTinLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuongTacKhiNhanTinLike.Location = new Point(106, 52);
		ckbTuongTacKhiNhanTinLike.Name = "ckbTuongTacKhiNhanTinLike";
		ckbTuongTacKhiNhanTinLike.Size = new Size(48, 20);
		ckbTuongTacKhiNhanTinLike.TabIndex = 95;
		ckbTuongTacKhiNhanTinLike.Text = "Like";
		ckbTuongTacKhiNhanTinLike.UseVisualStyleBackColor = true;
		label16.AutoSize = true;
		label16.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label16.Location = new Point(6, 53);
		label16.Name = "label16";
		label16.Size = new Size(93, 16);
		label16.TabIndex = 104;
		label16.Text = "Loa\u0323i tương ta\u0301c:";
		C110E006.BorderStyle = BorderStyle.FixedSingle;
		C110E006.Controls.Add(CC8D0085);
		C110E006.Controls.Add(B2226DA1);
		C110E006.Controls.Add(EC05C3AF);
		C110E006.Controls.Add(button3);
		C110E006.Controls.Add(button2);
		C110E006.Controls.Add(ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
		C110E006.Controls.Add(D90724BA);
		C110E006.Controls.Add(label12);
		C110E006.Controls.Add(txtTuongTacKhiNhanTinComment);
		C110E006.Controls.Add(label14);
		C110E006.Location = new Point(9, 75);
		C110E006.Name = "plTuongTacTruocKhiNhanTinComment";
		C110E006.Size = new Size(281, 191);
		C110E006.TabIndex = 101;
		CC8D0085.Cursor = Cursors.Help;
		CC8D0085.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CC8D0085.Location = new Point(247, 120);
		CC8D0085.Name = "button4";
		CC8D0085.Size = new Size(23, 23);
		CC8D0085.TabIndex = 189;
		CC8D0085.Text = "?";
		CC8D0085.UseVisualStyleBackColor = true;
		CC8D0085.Click += B6802515;
		B2226DA1.AutoSize = true;
		B2226DA1.Cursor = Cursors.Hand;
		B2226DA1.Location = new Point(167, 123);
		B2226DA1.Name = "linkLabel1";
		B2226DA1.Size = new Size(81, 16);
		B2226DA1.TabIndex = 188;
		B2226DA1.TabStop = true;
		B2226DA1.Text = "Random icon";
		B2226DA1.LinkClicked += B2226DA1_LinkClicked;
		EC05C3AF.AutoSize = true;
		EC05C3AF.Location = new Point(5, 123);
		EC05C3AF.Name = "label17";
		EC05C3AF.Size = new Size(131, 16);
		EC05C3AF.TabIndex = 187;
		EC05C3AF.Text = "Spin content: {a|b|c}";
		button3.Cursor = Cursors.Help;
		button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.Location = new Point(226, 165);
		button3.Name = "button3";
		button3.Size = new Size(21, 23);
		button3.TabIndex = 5;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += button3_Click;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(226, 142);
		button2.Name = "button2";
		button2.Size = new Size(21, 23);
		button2.TabIndex = 6;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.AutoSize = true;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Cursor = Cursors.Hand;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Location = new Point(70, 164);
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Name = "ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong";
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Size = new Size(159, 20);
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.TabIndex = 3;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Text = "Nội dung có nhiều dòng";
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.UseVisualStyleBackColor = true;
		D90724BA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		D90724BA.AutoSize = true;
		D90724BA.Checked = true;
		D90724BA.Cursor = Cursors.Hand;
		D90724BA.Location = new Point(70, 143);
		D90724BA.Name = "ckbTuongTacKhiNhanTinCommentNoiDung1Dong";
		D90724BA.Size = new Size(155, 20);
		D90724BA.TabIndex = 3;
		D90724BA.TabStop = true;
		D90724BA.Text = "Nội dung chỉ có 1 dòng";
		D90724BA.UseVisualStyleBackColor = true;
		label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		label12.AutoSize = true;
		label12.Location = new Point(5, 143);
		label12.Name = "label12";
		label12.Size = new Size(64, 16);
		label12.TabIndex = 2;
		label12.Text = "Tùy chọn:";
		txtTuongTacKhiNhanTinComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtTuongTacKhiNhanTinComment.Location = new Point(7, 23);
		txtTuongTacKhiNhanTinComment.Name = "txtTuongTacKhiNhanTinComment";
		txtTuongTacKhiNhanTinComment.Size = new Size(263, 97);
		txtTuongTacKhiNhanTinComment.TabIndex = 1;
		txtTuongTacKhiNhanTinComment.Text = "";
		txtTuongTacKhiNhanTinComment.WordWrap = false;
		label14.AutoSize = true;
		label14.Location = new Point(3, 3);
		label14.Name = "label14";
		label14.Size = new Size(118, 16);
		label14.TabIndex = 0;
		label14.Text = "Nội dung bình luận:";
		B0924990.BorderStyle = BorderStyle.FixedSingle;
		B0924990.Controls.Add(txtNoiDung);
		B0924990.Controls.Add(button5);
		B0924990.Controls.Add(button6);
		B0924990.Controls.Add(btnDown);
		B0924990.Controls.Add(btnUp);
		B0924990.Controls.Add(rbNganCachKyTu);
		B0924990.Controls.Add(rbNganCachMoiDong);
		B0924990.Controls.Add(label11);
		B0924990.Controls.Add(E3B9521E);
		B0924990.Controls.Add(lblStatus);
		B0924990.Location = new Point(376, 105);
		B0924990.Name = "plComment";
		B0924990.Size = new Size(281, 185);
		B0924990.TabIndex = 10;
		txtNoiDung.Location = new Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new Size(263, 137);
		txtNoiDung.TabIndex = 165;
		txtNoiDung.Text = "";
		button5.Cursor = Cursors.Help;
		button5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button5.Location = new Point(224, 210);
		button5.Name = "button5";
		button5.Size = new Size(21, 23);
		button5.TabIndex = 13;
		button5.Text = "?";
		button5.UseVisualStyleBackColor = true;
		button5.Click += button5_Click;
		button6.Cursor = Cursors.Help;
		button6.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button6.Location = new Point(224, 187);
		button6.Name = "button6";
		button6.Size = new Size(21, 23);
		button6.TabIndex = 14;
		button6.Text = "?";
		button6.UseVisualStyleBackColor = true;
		button6.Click += B4AC553E;
		btnDown.BackgroundImage = Resources.Bitmap_83;
		btnDown.Cursor = Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = Color.Silver;
		btnDown.FlatStyle = FlatStyle.Flat;
		btnDown.Location = new Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new Size(25, 25);
		btnDown.TabIndex = 11;
		btnDown.Click += btnDown_Click;
		btnUp.BackgroundImage = Resources.E536C319;
		btnUp.Cursor = Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = Color.Silver;
		btnUp.FlatStyle = FlatStyle.Flat;
		btnUp.Location = new Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new Size(25, 25);
		btnUp.TabIndex = 12;
		btnUp.Click += btnUp_Click;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = Cursors.Hand;
		rbNganCachKyTu.Location = new Point(68, 209);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new Size(159, 20);
		rbNganCachKyTu.TabIndex = 10;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += rbNganCachKyTu_CheckedChanged;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(68, 188);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(155, 20);
		rbNganCachMoiDong.TabIndex = 9;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += rbNganCachMoiDong_CheckedChanged;
		label11.AutoSize = true;
		label11.Location = new Point(3, 188);
		label11.Name = "label11";
		label11.Size = new Size(64, 16);
		label11.TabIndex = 8;
		label11.Text = "Tùy chọn:";
		E3B9521E.AutoSize = true;
		E3B9521E.Location = new Point(4, 163);
		E3B9521E.Name = "label8";
		E3B9521E.Size = new Size(143, 16);
		E3B9521E.TabIndex = 0;
		E3B9521E.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(3, 3);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(133, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung tin nhắn (0):";
		plAnh.BorderStyle = BorderStyle.FixedSingle;
		plAnh.Controls.Add(label10);
		plAnh.Controls.Add(B53A942C);
		plAnh.Controls.Add(A2B2A49D);
		plAnh.Controls.Add(label9);
		plAnh.Controls.Add(nudSoLuongAnhFrom);
		plAnh.Controls.Add(DD1C3100);
		plAnh.Enabled = false;
		plAnh.Location = new Point(376, 319);
		plAnh.Name = "plAnh";
		plAnh.Size = new Size(281, 58);
		plAnh.TabIndex = 162;
		label10.AutoSize = true;
		label10.Location = new Point(3, 6);
		label10.Name = "label10";
		label10.Size = new Size(137, 16);
		label10.TabIndex = 159;
		label10.Text = "Đường dẫn folder ảnh:";
		B53A942C.Location = new Point(143, 3);
		B53A942C.Name = "txtAnh";
		B53A942C.Size = new Size(133, 23);
		B53A942C.TabIndex = 158;
		A2B2A49D.AutoSize = true;
		A2B2A49D.Location = new Point(3, 31);
		A2B2A49D.Name = "label3";
		A2B2A49D.Size = new Size(103, 16);
		A2B2A49D.TabIndex = 34;
		A2B2A49D.Text = "Số ảnh/tin nhắn:";
		label9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label9.Location = new Point(189, 31);
		label9.Name = "label9";
		label9.Size = new Size(29, 16);
		label9.TabIndex = 38;
		label9.Text = ">";
		label9.TextAlign = ContentAlignment.MiddleCenter;
		nudSoLuongAnhFrom.Location = new Point(143, 29);
		nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		nudSoLuongAnhFrom.Size = new Size(43, 23);
		nudSoLuongAnhFrom.TabIndex = 5;
		DD1C3100.Location = new Point(220, 29);
		DD1C3100.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DD1C3100.Name = "nudSoLuongAnhTo";
		DD1C3100.Size = new Size(43, 23);
		DD1C3100.TabIndex = 6;
		A98B562F.AutoSize = true;
		A98B562F.Cursor = Cursors.Hand;
		A98B562F.Location = new Point(358, 296);
		A98B562F.Name = "ckbSendAnh";
		A98B562F.Size = new Size(70, 20);
		A98B562F.TabIndex = 161;
		A98B562F.Text = "Gửi ảnh";
		A98B562F.UseVisualStyleBackColor = true;
		A98B562F.CheckedChanged += A98B562F_CheckedChanged;
		txtUid.BorderStyle = BorderStyle.FixedSingle;
		txtUid.Location = new Point(31, 154);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(299, 181);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += D62FAAAD;
		D4158516.AutoSize = true;
		D4158516.Location = new Point(229, 338);
		D4158516.Name = "label2";
		D4158516.Size = new Size(102, 16);
		D4158516.TabIndex = 115;
		D4158516.Text = "(Mỗi Uid 1 dòng)";
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new Point(28, 135);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new Size(237, 16);
		lblStatusUid.TabIndex = 116;
		lblStatusUid.Text = "Danh sa\u0301ch Uid ca\u0301 nhân cần nhắn tin (0):";
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(27, 81);
		label49.Name = "label49";
		label49.Size = new Size(101, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng Uid(?):";
		toolTip_0.SetToolTip(label49, "Mỗi tài khoản chỉ nhắn tin được tối đa 50 người tại 1 thời điểm!");
		nudSoLuongUidFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new Point(135, 79);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 1;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label68.Location = new Point(290, 81);
		label68.Name = "label68";
		label68.Size = new Size(25, 16);
		label68.TabIndex = 99;
		label68.Text = "Uid";
		nudSoLuongUidTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongUidTo.Location = new Point(232, 79);
		nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		nudSoLuongUidTo.Size = new Size(56, 23);
		nudSoLuongUidTo.TabIndex = 2;
		nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label66.Location = new Point(197, 81);
		label66.Name = "label66";
		label66.Size = new Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = ContentAlignment.MiddleCenter;
		F934AD24.AutoSize = true;
		F934AD24.Cursor = Cursors.Hand;
		F934AD24.Location = new Point(677, 81);
		F934AD24.Name = "ckbTuongTacKhiNhanTin";
		F934AD24.Size = new Size(154, 20);
		F934AD24.TabIndex = 9;
		F934AD24.Text = "Tương tác khi nhắn tin";
		F934AD24.UseVisualStyleBackColor = true;
		F934AD24.CheckedChanged += F934AD24_CheckedChanged;
		D1A41F0B.AutoSize = true;
		D1A41F0B.Cursor = Cursors.Hand;
		D1A41F0B.Location = new Point(358, 81);
		D1A41F0B.Name = "ckbNhanTinVanBan";
		D1A41F0B.Size = new Size(122, 20);
		D1A41F0B.TabIndex = 9;
		D1A41F0B.Text = "Nhắn tin văn bản";
		D1A41F0B.UseVisualStyleBackColor = true;
		D1A41F0B.CheckedChanged += D1A41F0B_CheckedChanged;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = Cursors.Hand;
		ckbTuDongXoaUid.Location = new Point(30, 357);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new Size(295, 20);
		ckbTuDongXoaUid.TabIndex = 8;
		ckbTuDongXoaUid.Text = "Tự động xóa Uid đã nhắn tin (Không trùng UID)";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(232, 108);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudDelayFrom.Location = new Point(135, 108);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		txtTenHanhDong.Location = new Point(135, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(195, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new Point(197, 110);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(290, 110);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		CA218818.AutoSize = true;
		CA218818.Location = new Point(27, 110);
		CA218818.Name = "label5";
		CA218818.Size = new Size(89, 16);
		CA218818.TabIndex = 34;
		CA218818.Text = "Thơ\u0300i gian chơ\u0300:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
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
		btnCancel.Location = new Point(513, 398);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(406, 398);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += BA286239;
		BDBC5F08.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		BDBC5F08.BackColor = Color.White;
		BDBC5F08.BorderRadius = 0;
		BDBC5F08.BottomSahddow = true;
		BDBC5F08.color = Color.DarkViolet;
		BDBC5F08.Controls.Add(pnlHeader);
		BDBC5F08.LeftSahddow = false;
		BDBC5F08.Location = new Point(1, 0);
		BDBC5F08.Name = "bunifuCards1";
		BDBC5F08.RightSahddow = true;
		BDBC5F08.ShadowDepth = 20;
		BDBC5F08.Size = new Size(1009, 37);
		BDBC5F08.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 20000;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ToolTipTitle = "Chú ý";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(1012, 447);
		base.Controls.Add(BD155F8E);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBuffTinNhanProfile";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += D6B12631;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)CCA55434).EndInit();
		BD155F8E.ResumeLayout(performLayout: false);
		BD155F8E.PerformLayout();
		plTuongTacTruocKhiNhanTin.ResumeLayout(performLayout: false);
		plTuongTacTruocKhiNhanTin.PerformLayout();
		C110E006.ResumeLayout(performLayout: false);
		C110E006.PerformLayout();
		B0924990.ResumeLayout(performLayout: false);
		B0924990.PerformLayout();
		plAnh.ResumeLayout(performLayout: false);
		plAnh.PerformLayout();
		((ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		((ISupportInitialize)DD1C3100).EndInit();
		((ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((ISupportInitialize)nudSoLuongUidTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		BDBC5F08.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
