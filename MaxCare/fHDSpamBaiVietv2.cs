using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDSpamBaiVietv2 : Form
{
	private JSON_Settings F92DEC31;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer BC929D10 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox A40EDE18;

	private Label CA2EF601;

	private Label D395C92A;

	private Label B1353923;

	private Label A090A71C;

	private Label label5;

	private Label E990BCB7;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel F016963D;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox D03572A9;

	private CheckBox ckbInteract;

	private CheckBox ckbShareWall;

	private Label A0B9A137;

	private NumericUpDown nudSoLuongUidFrom;

	private Label DC1C891A;

	private Label label19;

	private NumericUpDown BDB30DB3;

	private Label label66;

	private RichTextBox txtUid;

	private Panel plAnh;

	private CheckBox B13D38A3;

	private CheckBox BE9D8710;

	private RadioButton rbListUid;

	private Label E63CE426;

	private TextBox txtAnh;

	private Label AC12B705;

	private Button button4;

	private CheckBox ckbAutoDeleteComment;

	private Button btnChooseFileUid;

	private RadioButton rbFileUid;

	private TextBox txtPathFileUid;

	private Panel panel2;

	private NumericUpDown D335F135;

	private NumericUpDown nudBoQuaFrom;

	private Label label8;

	private Label F39BB29A;

	private CheckBox ckbBoQua;

	private CheckBox ckbTuDongThamGiaNhom;

	private CheckBox ckbKhongCommentTrungBaiCu;

	private Panel panel3;

	private NumericUpDown B7AF3E38;

	private NumericUpDown nudSoLuongNhomFrom;

	private Label label13;

	private Label ACADBD81;

	private Label E1B1E591;

	private Panel CCA1D1BC;

	private TextBox D49C131B;

	private Label label16;

	private RadioButton E3B63590;

	private Panel B1B03321;

	private Label label2;

	private RadioButton rbSpamIDNguoiDungNhap;

	public fHDSpamBaiVietv2(string string_3, int DCB56E12 = 0, string string_4 = "")
	{
		F2A1563F();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = DCB56E12;
		string text = "HDSpamBaiVietv2";
		string text2 = "Spam bài viết v2";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (DCB56E12)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A40EDE18.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A40EDE18.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F92DEC31 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(E990BCB7);
		Language.smethod_0(A0B9A137);
		Language.smethod_0(label66);
		Language.smethod_0(label19);
		Language.smethod_0(D395C92A);
		Language.smethod_0(A090A71C);
		Language.smethod_0(label5);
		Language.smethod_0(CA2EF601);
		Language.smethod_0(B1353923);
		Language.smethod_0(E63CE426);
		Language.smethod_0(button4);
		Language.smethod_0(rbFileUid);
		Language.smethod_0(btnChooseFileUid);
		Language.smethod_0(rbListUid);
		Language.smethod_0(BE9D8710);
		Language.smethod_0(ckbInteract);
		Language.smethod_0(ckbShareWall);
		Language.smethod_0(D03572A9);
		Language.smethod_0(B13D38A3);
		Language.smethod_0(AC12B705);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void BB334999_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = F92DEC31.GetValueInt("nudSoLuongUidFrom", 1);
			BDB30DB3.Value = F92DEC31.GetValueInt("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = F92DEC31.GetValueInt("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = F92DEC31.GetValueInt("nudSoLuongBaiVietTo", 3);
			nudDelayFrom.Value = F92DEC31.GetValueInt("nudDelayFrom", 2);
			nudDelayTo.Value = F92DEC31.GetValueInt("nudDelayTo", 5);
			if (F92DEC31.GetValueInt("typeSpam") == 0)
			{
				E3B63590.Checked = true;
			}
			else
			{
				rbSpamIDNguoiDungNhap.Checked = true;
			}
			int num = F92DEC31.GetValueInt("typeListUid");
			if (num == 1)
			{
				rbFileUid.Checked = true;
			}
			else
			{
				rbListUid.Checked = true;
			}
			txtPathFileUid.Text = F92DEC31.GetValue("txtPathFileUid");
			txtUid.Text = F92DEC31.GetValue("txtUid");
			ckbInteract.Checked = F92DEC31.GetValueBool("ckbInteract");
			ckbShareWall.Checked = F92DEC31.GetValueBool("ckbShareWall");
			D03572A9.Checked = F92DEC31.GetValueBool("ckbComment");
			ckbAutoDeleteComment.Checked = F92DEC31.GetValueBool("ckbAutoDeleteComment");
			D49C131B.Text = F92DEC31.GetValue("txtPathFolderComment");
			B13D38A3.Checked = F92DEC31.GetValueBool("ckbSendAnh");
			txtAnh.Text = F92DEC31.GetValue("txtAnh");
			BE9D8710.Checked = F92DEC31.GetValueBool("ckbTuDongXoaUid");
			ckbKhongCommentTrungBaiCu.Checked = F92DEC31.GetValueBool("ckbKhongCommentTrungBaiCu");
			ckbBoQua.Checked = F92DEC31.GetValueBool("ckbBoQua");
			nudBoQuaFrom.Value = F92DEC31.GetValueInt("nudBoQuaFrom", 1);
			D335F135.Value = F92DEC31.GetValueInt("nudBoQuaTo", 1);
			ckbTuDongThamGiaNhom.Checked = F92DEC31.GetValueBool("ckbTuDongThamGiaNhom");
			nudSoLuongNhomFrom.Value = F92DEC31.GetValueInt("nudSoLuongNhomFrom", 1);
			B7AF3E38.Value = F92DEC31.GetValueInt("nudSoLuongNhomTo", 1);
		}
		catch
		{
		}
		method_2();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AF830888(object sender, EventArgs e)
	{
		string text = A40EDE18.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (rbSpamIDNguoiDungNhap.Checked)
		{
			if (rbFileUid.Checked)
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
		}
		if (B13D38A3.Checked && txtAnh.Text.Trim().Length == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng chọn folder ảnh!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.GetJson("nudSoLuongUidTo", BDB30DB3.Value);
		gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.GetJson("nudDelayFrom", nudDelayFrom.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		if (E3B63590.Checked)
		{
			gClass.GetJson("typeSpam", 0);
		}
		else
		{
			gClass.GetJson("typeSpam", 1);
		}
		if (rbFileUid.Checked)
		{
			gClass.GetJson("typeListUid", 1);
		}
		else
		{
			gClass.GetJson("typeListUid", 0);
		}
		gClass.GetJson("txtPathFileUid", txtPathFileUid.Text.Trim());
		gClass.GetJson("txtUid", txtUid.Text.Trim());
		gClass.GetJson("ckbInteract", ckbInteract.Checked);
		gClass.GetJson("ckbShareWall", ckbShareWall.Checked);
		gClass.GetJson("ckbComment", D03572A9.Checked);
		gClass.GetJson("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		gClass.GetJson("txtPathFolderComment", D49C131B.Text.Trim());
		gClass.GetJson("ckbSendAnh", B13D38A3.Checked);
		gClass.GetJson("txtAnh", txtAnh.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", BE9D8710.Checked);
		gClass.GetJson("ckbKhongCommentTrungBaiCu", ckbKhongCommentTrungBaiCu.Checked);
		gClass.GetJson("ckbBoQua", ckbBoQua.Checked);
		gClass.GetJson("nudBoQuaFrom", nudBoQuaFrom.Value);
		gClass.GetJson("nudBoQuaTo", D335F135.Value);
		gClass.GetJson("ckbTuDongThamGiaNhom", ckbTuDongThamGiaNhom.Checked);
		gClass.GetJson("nudSoLuongNhomFrom", nudSoLuongNhomFrom.Value);
		gClass.GetJson("nudSoLuongNhomTo", B7AF3E38.Value);
		string string_ = gClass.D9A09B34();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
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
			if (InteractSQL.smethod_13(string_2, text, string_))
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

	private void AE10E628(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2()
	{
		method_3(null, null);
		AE9F809B(null, null);
		rbFileUid_CheckedChanged(null, null);
		AA90A424(null, null);
		ckbBoQua_CheckedChanged(null, null);
		D6855BB9(null, null);
		ckbTuDongThamGiaNhom_CheckedChanged(null, null);
		rbSpamIDNguoiDungNhap_CheckedChanged(null, null);
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void AE9F809B(object sender, EventArgs e)
	{
		CCA1D1BC.Enabled = D03572A9.Checked;
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

	private void B13D38A3_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = B13D38A3.Checked;
	}

	private void method_4(object sender, EventArgs e)
	{
		txtAnh.Text = Common.SelectFolder();
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void panel1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void B109BC20(object sender, EventArgs e)
	{
		txtPathFileUid.Text = Common.SelectFile();
	}

	private void rbFileUid_CheckedChanged(object sender, EventArgs e)
	{
		txtPathFileUid.Enabled = rbFileUid.Checked;
		btnChooseFileUid.Enabled = rbFileUid.Checked;
	}

	private void AA90A424(object sender, EventArgs e)
	{
		txtUid.Enabled = rbListUid.Checked;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.\r\nVí dụ: 15465478242/posts");
	}

	private void ckbBoQua_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = ckbBoQua.Checked;
	}

	private void D6855BB9(object sender, EventArgs e)
	{
	}

	private void ckbTuDongThamGiaNhom_CheckedChanged(object sender, EventArgs e)
	{
		panel3.Enabled = ckbTuDongThamGiaNhom.Checked;
	}

	private void rbSpamIDNguoiDungNhap_CheckedChanged(object sender, EventArgs e)
	{
		B1B03321.Enabled = rbSpamIDNguoiDungNhap.Checked;
	}

	protected override void Dispose(bool ECBD3C3E)
	{
		if (ECBD3C3E && BC929D10 != null)
		{
			BC929D10.Dispose();
		}
		base.Dispose(ECBD3C3E);
	}

	private void F2A1563F()
	{
		BC929D10 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDSpamBaiVietv2));
		bunifuDragControl_0 = new BunifuDragControl(BC929D10);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(BC929D10);
		F016963D = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		rbSpamIDNguoiDungNhap = new RadioButton();
		E3B63590 = new RadioButton();
		B1B03321 = new Panel();
		E63CE426 = new Label();
		txtPathFileUid = new TextBox();
		BE9D8710 = new CheckBox();
		txtUid = new RichTextBox();
		rbFileUid = new RadioButton();
		button4 = new Button();
		rbListUid = new RadioButton();
		btnChooseFileUid = new Button();
		panel3 = new Panel();
		B7AF3E38 = new NumericUpDown();
		nudSoLuongNhomFrom = new NumericUpDown();
		label13 = new Label();
		ACADBD81 = new Label();
		E1B1E591 = new Label();
		ckbTuDongThamGiaNhom = new CheckBox();
		panel2 = new Panel();
		D335F135 = new NumericUpDown();
		nudBoQuaFrom = new NumericUpDown();
		label8 = new Label();
		F39BB29A = new Label();
		ckbBoQua = new CheckBox();
		CCA1D1BC = new Panel();
		D49C131B = new TextBox();
		label16 = new Label();
		ckbAutoDeleteComment = new CheckBox();
		plAnh = new Panel();
		txtAnh = new TextBox();
		AC12B705 = new Label();
		B13D38A3 = new CheckBox();
		label2 = new Label();
		A0B9A137 = new Label();
		nudSoLuongUidFrom = new NumericUpDown();
		DC1C891A = new Label();
		label19 = new Label();
		BDB30DB3 = new NumericUpDown();
		label66 = new Label();
		D03572A9 = new CheckBox();
		ckbKhongCommentTrungBaiCu = new CheckBox();
		ckbShareWall = new CheckBox();
		ckbInteract = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudSoLuongBaiVietTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		nudSoLuongBaiVietFrom = new NumericUpDown();
		A40EDE18 = new TextBox();
		CA2EF601 = new Label();
		D395C92A = new Label();
		B1353923 = new Label();
		A090A71C = new Label();
		label5 = new Label();
		E990BCB7 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		F016963D.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		B1B03321.SuspendLayout();
		panel3.SuspendLayout();
		((ISupportInitialize)B7AF3E38).BeginInit();
		((ISupportInitialize)nudSoLuongNhomFrom).BeginInit();
		panel2.SuspendLayout();
		((ISupportInitialize)D335F135).BeginInit();
		((ISupportInitialize)nudBoQuaFrom).BeginInit();
		CCA1D1BC.SuspendLayout();
		plAnh.SuspendLayout();
		((ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((ISupportInitialize)BDB30DB3).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(704, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Spam bài viết v2";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = F016963D;
		bunifuDragControl_1.Vertical = true;
		F016963D.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F016963D.BackColor = Color.White;
		F016963D.Controls.Add(button1);
		F016963D.Controls.Add(pictureBox1);
		F016963D.Controls.Add(bunifuCustomLabel1);
		F016963D.Cursor = Cursors.SizeAll;
		F016963D.Location = new Point(0, 3);
		F016963D.Name = "pnlHeader";
		F016963D.Size = new Size(704, 31);
		F016963D.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(673, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(rbSpamIDNguoiDungNhap);
		panel1.Controls.Add(E3B63590);
		panel1.Controls.Add(B1B03321);
		panel1.Controls.Add(panel3);
		panel1.Controls.Add(ckbTuDongThamGiaNhom);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(ckbBoQua);
		panel1.Controls.Add(CCA1D1BC);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(B13D38A3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(A0B9A137);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(DC1C891A);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(BDB30DB3);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(D03572A9);
		panel1.Controls.Add(ckbKhongCommentTrungBaiCu);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(A40EDE18);
		panel1.Controls.Add(CA2EF601);
		panel1.Controls.Add(D395C92A);
		panel1.Controls.Add(B1353923);
		panel1.Controls.Add(A090A71C);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(E990BCB7);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(707, 534);
		panel1.TabIndex = 0;
		panel1.Click += panel1_Click;
		panel1.Paint += AE10E628;
		rbSpamIDNguoiDungNhap.AutoSize = true;
		rbSpamIDNguoiDungNhap.Cursor = Cursors.Hand;
		rbSpamIDNguoiDungNhap.Location = new Point(31, 204);
		rbSpamIDNguoiDungNhap.Name = "rbSpamIDNguoiDungNhap";
		rbSpamIDNguoiDungNhap.Size = new Size(174, 20);
		rbSpamIDNguoiDungNhap.TabIndex = 170;
		rbSpamIDNguoiDungNhap.TabStop = true;
		rbSpamIDNguoiDungNhap.Text = "Spam ID người dùng nhập";
		rbSpamIDNguoiDungNhap.UseVisualStyleBackColor = true;
		rbSpamIDNguoiDungNhap.CheckedChanged += rbSpamIDNguoiDungNhap_CheckedChanged;
		E3B63590.AutoSize = true;
		E3B63590.Cursor = Cursors.Hand;
		E3B63590.Location = new Point(31, 182);
		E3B63590.Name = "rbRandomNhomThamGia";
		E3B63590.Size = new Size(194, 20);
		E3B63590.TabIndex = 170;
		E3B63590.TabStop = true;
		E3B63590.Text = "Random nhóm đang tham gia";
		E3B63590.UseVisualStyleBackColor = true;
		B1B03321.BorderStyle = BorderStyle.FixedSingle;
		B1B03321.Controls.Add(E63CE426);
		B1B03321.Controls.Add(txtPathFileUid);
		B1B03321.Controls.Add(BE9D8710);
		B1B03321.Controls.Add(txtUid);
		B1B03321.Controls.Add(rbFileUid);
		B1B03321.Controls.Add(button4);
		B1B03321.Controls.Add(rbListUid);
		B1B03321.Controls.Add(btnChooseFileUid);
		B1B03321.Location = new Point(31, 226);
		B1B03321.Name = "plSpamIDNguoiDungNhap";
		B1B03321.Size = new Size(312, 210);
		B1B03321.TabIndex = 169;
		E63CE426.AutoSize = true;
		E63CE426.Location = new Point(3, 4);
		E63CE426.Name = "label10";
		E63CE426.Size = new Size(241, 16);
		E63CE426.TabIndex = 116;
		E63CE426.Text = "Nhập danh sách ID Cá nhân/Nhóm/Page:";
		txtPathFileUid.Location = new Point(104, 25);
		txtPathFileUid.Name = "txtPathFileUid";
		txtPathFileUid.Size = new Size(134, 23);
		txtPathFileUid.TabIndex = 0;
		BE9D8710.AutoSize = true;
		BE9D8710.Cursor = Cursors.Hand;
		BE9D8710.Location = new Point(7, 187);
		BE9D8710.Name = "ckbTuDongXoaUid";
		BE9D8710.Size = new Size(303, 20);
		BE9D8710.TabIndex = 8;
		BE9D8710.Text = "Tự động xóa Uid đã tương tác (Không trùng UID)";
		BE9D8710.UseVisualStyleBackColor = true;
		BE9D8710.CheckedChanged += D6855BB9;
		txtUid.BorderStyle = BorderStyle.FixedSingle;
		txtUid.Location = new Point(7, 71);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(299, 115);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += txtUid_TextChanged;
		rbFileUid.AutoSize = true;
		rbFileUid.Checked = true;
		rbFileUid.Cursor = Cursors.Hand;
		rbFileUid.Location = new Point(7, 25);
		rbFileUid.Name = "rbFileUid";
		rbFileUid.Size = new Size(94, 20);
		rbFileUid.TabIndex = 163;
		rbFileUid.TabStop = true;
		rbFileUid.Text = "Nhập từ File";
		rbFileUid.UseVisualStyleBackColor = true;
		rbFileUid.CheckedChanged += rbFileUid_CheckedChanged;
		button4.Cursor = Cursors.Help;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(244, 1);
		button4.Name = "button4";
		button4.Size = new Size(21, 23);
		button4.TabIndex = 5;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button4.Click += button4_Click;
		rbListUid.AutoSize = true;
		rbListUid.Cursor = Cursors.Hand;
		rbListUid.Location = new Point(7, 48);
		rbListUid.Name = "rbListUid";
		rbListUid.Size = new Size(174, 20);
		rbListUid.TabIndex = 163;
		rbListUid.Text = "Nhập (Mỗi Uid 1 dòng) (0)";
		rbListUid.UseVisualStyleBackColor = true;
		rbListUid.CheckedChanged += AA90A424;
		btnChooseFileUid.Cursor = Cursors.Hand;
		btnChooseFileUid.Location = new Point(244, 24);
		btnChooseFileUid.Name = "btnChooseFileUid";
		btnChooseFileUid.Size = new Size(63, 25);
		btnChooseFileUid.TabIndex = 156;
		btnChooseFileUid.Text = "Chọn";
		btnChooseFileUid.UseVisualStyleBackColor = true;
		btnChooseFileUid.Click += B109BC20;
		panel3.BorderStyle = BorderStyle.FixedSingle;
		panel3.Controls.Add(B7AF3E38);
		panel3.Controls.Add(nudSoLuongNhomFrom);
		panel3.Controls.Add(label13);
		panel3.Controls.Add(ACADBD81);
		panel3.Controls.Add(E1B1E591);
		panel3.Location = new Point(392, 442);
		panel3.Name = "panel3";
		panel3.Size = new Size(282, 30);
		panel3.TabIndex = 168;
		B7AF3E38.Location = new Point(175, 3);
		B7AF3E38.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		B7AF3E38.Name = "nudSoLuongNhomTo";
		B7AF3E38.Size = new Size(56, 23);
		B7AF3E38.TabIndex = 40;
		nudSoLuongNhomFrom.Location = new Point(78, 3);
		nudSoLuongNhomFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongNhomFrom.Name = "nudSoLuongNhomFrom";
		nudSoLuongNhomFrom.Size = new Size(56, 23);
		nudSoLuongNhomFrom.TabIndex = 39;
		label13.Location = new Point(140, 5);
		label13.Name = "label13";
		label13.Size = new Size(29, 16);
		label13.TabIndex = 43;
		label13.Text = "đê\u0301n";
		label13.TextAlign = ContentAlignment.MiddleCenter;
		ACADBD81.AutoSize = true;
		ACADBD81.Location = new Point(233, 5);
		ACADBD81.Name = "label14";
		ACADBD81.Size = new Size(39, 16);
		ACADBD81.TabIndex = 42;
		ACADBD81.Text = "nhóm";
		E1B1E591.AutoSize = true;
		E1B1E591.Location = new Point(3, 5);
		E1B1E591.Name = "label15";
		E1B1E591.Size = new Size(63, 16);
		E1B1E591.TabIndex = 41;
		E1B1E591.Text = "Số lượng:";
		ckbTuDongThamGiaNhom.AutoSize = true;
		ckbTuDongThamGiaNhom.Cursor = Cursors.Hand;
		ckbTuDongThamGiaNhom.Location = new Point(373, 419);
		ckbTuDongThamGiaNhom.Name = "ckbTuDongThamGiaNhom";
		ckbTuDongThamGiaNhom.Size = new Size(286, 20);
		ckbTuDongThamGiaNhom.TabIndex = 167;
		ckbTuDongThamGiaNhom.Text = "Tự động tham gia nhóm (Nếu chưa tham gia)";
		ckbTuDongThamGiaNhom.UseVisualStyleBackColor = true;
		ckbTuDongThamGiaNhom.CheckedChanged += ckbTuDongThamGiaNhom_CheckedChanged;
		panel2.BorderStyle = BorderStyle.FixedSingle;
		panel2.Controls.Add(D335F135);
		panel2.Controls.Add(nudBoQuaFrom);
		panel2.Controls.Add(label8);
		panel2.Controls.Add(F39BB29A);
		panel2.Location = new Point(96, 439);
		panel2.Name = "panel2";
		panel2.Size = new Size(247, 31);
		panel2.TabIndex = 166;
		D335F135.Location = new Point(91, 3);
		D335F135.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		D335F135.Name = "nudBoQuaTo";
		D335F135.Size = new Size(56, 23);
		D335F135.TabIndex = 40;
		nudBoQuaFrom.Location = new Point(3, 3);
		nudBoQuaFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudBoQuaFrom.Name = "nudBoQuaFrom";
		nudBoQuaFrom.Size = new Size(56, 23);
		nudBoQuaFrom.TabIndex = 39;
		label8.Location = new Point(60, 5);
		label8.Name = "label8";
		label8.Size = new Size(29, 16);
		label8.TabIndex = 42;
		label8.Text = "đê\u0301n";
		label8.TextAlign = ContentAlignment.MiddleCenter;
		F39BB29A.AutoSize = true;
		F39BB29A.Location = new Point(150, 5);
		F39BB29A.Name = "label11";
		F39BB29A.Size = new Size(73, 16);
		F39BB29A.TabIndex = 41;
		F39BB29A.Text = "bài viết đầu";
		ckbBoQua.AutoSize = true;
		ckbBoQua.Cursor = Cursors.Hand;
		ckbBoQua.Location = new Point(30, 444);
		ckbBoQua.Name = "ckbBoQua";
		ckbBoQua.Size = new Size(70, 20);
		ckbBoQua.TabIndex = 164;
		ckbBoQua.Text = "Bỏ qua:";
		ckbBoQua.UseVisualStyleBackColor = true;
		ckbBoQua.CheckedChanged += ckbBoQua_CheckedChanged;
		CCA1D1BC.BorderStyle = BorderStyle.FixedSingle;
		CCA1D1BC.Controls.Add(D49C131B);
		CCA1D1BC.Controls.Add(label16);
		CCA1D1BC.Controls.Add(ckbAutoDeleteComment);
		CCA1D1BC.Location = new Point(391, 271);
		CCA1D1BC.Name = "plComment";
		CCA1D1BC.Size = new Size(283, 53);
		CCA1D1BC.TabIndex = 162;
		D49C131B.Location = new Point(158, 3);
		D49C131B.Name = "txtPathFolderComment";
		D49C131B.Size = new Size(120, 23);
		D49C131B.TabIndex = 159;
		label16.AutoSize = true;
		label16.Location = new Point(3, 6);
		label16.Name = "label16";
		label16.Size = new Size(158, 16);
		label16.TabIndex = 158;
		label16.Text = "Đường dẫn folder content:";
		ckbAutoDeleteComment.AutoSize = true;
		ckbAutoDeleteComment.Cursor = Cursors.Hand;
		ckbAutoDeleteComment.Location = new Point(6, 29);
		ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		ckbAutoDeleteComment.Size = new Size(225, 20);
		ckbAutoDeleteComment.TabIndex = 8;
		ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		plAnh.BorderStyle = BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(AC12B705);
		plAnh.Enabled = false;
		plAnh.Location = new Point(391, 350);
		plAnh.Name = "plAnh";
		plAnh.Size = new Size(283, 31);
		plAnh.TabIndex = 162;
		txtAnh.Location = new Point(160, 3);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new Size(118, 23);
		txtAnh.TabIndex = 159;
		AC12B705.AutoSize = true;
		AC12B705.Location = new Point(3, 6);
		AC12B705.Name = "label12";
		AC12B705.Size = new Size(137, 16);
		AC12B705.TabIndex = 158;
		AC12B705.Text = "Đường dẫn folder ảnh:";
		B13D38A3.AutoSize = true;
		B13D38A3.Cursor = Cursors.Hand;
		B13D38A3.Location = new Point(373, 328);
		B13D38A3.Name = "ckbSendAnh";
		B13D38A3.Size = new Size(103, 20);
		B13D38A3.TabIndex = 161;
		B13D38A3.Text = "Bình luận ảnh";
		B13D38A3.UseVisualStyleBackColor = true;
		B13D38A3.CheckedChanged += B13D38A3_CheckedChanged;
		label2.AutoSize = true;
		label2.Location = new Point(27, 163);
		label2.Name = "label2";
		label2.Size = new Size(175, 16);
		label2.TabIndex = 116;
		label2.Text = "Tùy chọn đối tượng để spam:";
		A0B9A137.AutoSize = true;
		A0B9A137.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		A0B9A137.Location = new Point(27, 81);
		A0B9A137.Name = "label49";
		A0B9A137.Size = new Size(85, 16);
		A0B9A137.TabIndex = 92;
		A0B9A137.Text = "Sô\u0301 lươ\u0323ng Uid:";
		nudSoLuongUidFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new Point(135, 79);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 1;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		DC1C891A.AutoSize = true;
		DC1C891A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		DC1C891A.Location = new Point(290, 81);
		DC1C891A.Name = "label68";
		DC1C891A.Size = new Size(25, 16);
		DC1C891A.TabIndex = 99;
		DC1C891A.Text = "Uid";
		label19.AutoSize = true;
		label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label19.Location = new Point(27, 110);
		label19.Name = "label19";
		label19.Size = new Size(94, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết/uid:";
		BDB30DB3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BDB30DB3.Location = new Point(232, 79);
		BDB30DB3.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		BDB30DB3.Name = "nudSoLuongUidTo";
		BDB30DB3.Size = new Size(56, 23);
		BDB30DB3.TabIndex = 2;
		BDB30DB3.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label66.Location = new Point(197, 81);
		label66.Name = "label66";
		label66.Size = new Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = ContentAlignment.MiddleCenter;
		D03572A9.AutoSize = true;
		D03572A9.Cursor = Cursors.Hand;
		D03572A9.Location = new Point(373, 252);
		D03572A9.Name = "ckbComment";
		D03572A9.Size = new Size(127, 20);
		D03572A9.TabIndex = 9;
		D03572A9.Text = "Bi\u0300nh luâ\u0323n văn bản";
		D03572A9.UseVisualStyleBackColor = true;
		D03572A9.CheckedChanged += AE9F809B;
		ckbKhongCommentTrungBaiCu.AutoSize = true;
		ckbKhongCommentTrungBaiCu.Cursor = Cursors.Hand;
		ckbKhongCommentTrungBaiCu.Location = new Point(373, 393);
		ckbKhongCommentTrungBaiCu.Name = "ckbKhongCommentTrungBaiCu";
		ckbKhongCommentTrungBaiCu.Size = new Size(190, 20);
		ckbKhongCommentTrungBaiCu.TabIndex = 8;
		ckbKhongCommentTrungBaiCu.Text = "Không comment trùng bài cũ";
		ckbKhongCommentTrungBaiCu.UseVisualStyleBackColor = true;
		ckbKhongCommentTrungBaiCu.CheckedChanged += D6855BB9;
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = Cursors.Hand;
		ckbShareWall.Location = new Point(510, 226);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new Size(167, 20);
		ckbShareWall.TabIndex = 8;
		ckbShareWall.Text = "Chia sẻ ba\u0300i viê\u0301t về tường";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = Cursors.Hand;
		ckbInteract.Location = new Point(373, 226);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new Size(93, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		ckbInteract.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(232, 137);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new Point(232, 108);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(135, 137);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new Point(135, 108);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		A40EDE18.Location = new Point(135, 49);
		A40EDE18.Name = "txtTenHanhDong";
		A40EDE18.Size = new Size(195, 23);
		A40EDE18.TabIndex = 0;
		CA2EF601.Location = new Point(197, 139);
		CA2EF601.Name = "label7";
		CA2EF601.Size = new Size(29, 16);
		CA2EF601.TabIndex = 38;
		CA2EF601.Text = "đê\u0301n";
		CA2EF601.TextAlign = ContentAlignment.MiddleCenter;
		D395C92A.Location = new Point(197, 110);
		D395C92A.Name = "label3";
		D395C92A.Size = new Size(29, 16);
		D395C92A.TabIndex = 37;
		D395C92A.Text = "đê\u0301n";
		D395C92A.TextAlign = ContentAlignment.MiddleCenter;
		B1353923.AutoSize = true;
		B1353923.Location = new Point(290, 139);
		B1353923.Name = "label6";
		B1353923.Size = new Size(30, 16);
		B1353923.TabIndex = 36;
		B1353923.Text = "giây";
		A090A71C.AutoSize = true;
		A090A71C.Location = new Point(290, 110);
		A090A71C.Name = "label4";
		A090A71C.Size = new Size(24, 16);
		A090A71C.TabIndex = 35;
		A090A71C.Text = "ba\u0300i";
		label5.AutoSize = true;
		label5.Location = new Point(27, 139);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		E990BCB7.AutoSize = true;
		E990BCB7.Location = new Point(27, 52);
		E990BCB7.Name = "label1";
		E990BCB7.Size = new Size(98, 16);
		E990BCB7.TabIndex = 31;
		E990BCB7.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(361, 491);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(254, 491);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += AF830888;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(F016963D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(704, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(707, 534);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDSpamBaiVietv2";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += BB334999_Load;
		F016963D.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		B1B03321.ResumeLayout(performLayout: false);
		B1B03321.PerformLayout();
		panel3.ResumeLayout(performLayout: false);
		panel3.PerformLayout();
		((ISupportInitialize)B7AF3E38).EndInit();
		((ISupportInitialize)nudSoLuongNhomFrom).EndInit();
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		((ISupportInitialize)D335F135).EndInit();
		((ISupportInitialize)nudBoQuaFrom).EndInit();
		CCA1D1BC.ResumeLayout(performLayout: false);
		CCA1D1BC.PerformLayout();
		plAnh.ResumeLayout(performLayout: false);
		plAnh.PerformLayout();
		((ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((ISupportInitialize)BDB30DB3).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
