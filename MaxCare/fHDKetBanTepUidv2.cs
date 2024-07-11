using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDKetBanTepUidv2 : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int BD2F42B6;

	public static bool F389073F;

	private IContainer A5B9E517 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel E805968D;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label FFBA8583;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel D62FF893;

	private Button FF110A92;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label F7AEB1AC;

	private Label lblStatus;

	private NumericUpDown nudDelayTo;

	private NumericUpDown BF9DA68D;

	private Label DB99649A;

	private Label DEA09D2A;

	private Label label5;

	private RichTextBox E49B5C19;

	private CheckBox C83E6583;

	private ToolTip CB81480C;

	private Panel plTuongTac;

	private Label label54;

	private Label label19;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private CheckBox CB846294;

	private Label label46;

	private NumericUpDown D51C4884;

	private Label label47;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudTuongTacDelayTo;

	private Label label67;

	private Label label48;

	private CheckBox ckbTuongTac;

	private Panel BEB8611D;

	private TextBox D6971CAD;

	private Label E783832D;

	private Label BF2192AE;

	private CheckBox B52C8909;

	public fHDKetBanTepUidv2(string CD27DA8A, int int_0 = 0, string FD94D103 = "")
	{
		A13984A6();
		F389073F = false;
		string_0 = CD27DA8A;
		string_2 = FD94D103;
		BD2F42B6 = int_0;
		if (InteractSQL.B484648C("", "HDKetBanTepUidv2").Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTepUidv2', 'Kết bạn theo tệp Uid v2');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", "HDKetBanTepUidv2");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(FD94D103);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void FE3E7CAF()
	{
		Language.smethod_0(bunifuCustomLabel1);
		Language.smethod_0(label1);
		Language.smethod_0(label2);
		Language.smethod_0(FFBA8583);
		Language.smethod_0(label4);
		Language.smethod_0(label5);
		Language.smethod_0(DB99649A);
		Language.smethod_0(DEA09D2A);
		Language.smethod_0(lblStatus);
		Language.smethod_0(F7AEB1AC);
		Language.smethod_0(C83E6583);
		Language.smethod_0(ckbTuongTac);
		Language.smethod_0(label19);
		Language.smethod_0(label67);
		Language.smethod_0(label54);
		Language.smethod_0(label46);
		Language.smethod_0(label48);
		Language.smethod_0(label47);
		Language.smethod_0(B52C8909);
		Language.smethod_0(BF2192AE);
		Language.smethod_0(E783832D);
		Language.smethod_0(btnAdd);
		Language.smethod_0(btnCancel);
	}

	private void fHDKetBanTepUidv2_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass8_0.GetValueInt("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass8_0.GetValueInt("nudSoLuongTo", 2);
			BF9DA68D.Value = gclass8_0.GetValueInt("nudDelayFrom", 3);
			nudDelayTo.Value = gclass8_0.GetValueInt("nudDelayTo", 5);
			C83E6583.Checked = gclass8_0.GetValueBool("ckbKetBanTrungNhau");
			E49B5C19.Text = gclass8_0.GetValue("txtUid");
			ckbTuongTac.Checked = gclass8_0.GetValueBool("ckbTuongTac");
			nudSoLuongBaiVietFrom.Value = gclass8_0.GetValueInt("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = gclass8_0.GetValueInt("nudSoLuongBaiVietTo", 3);
			D51C4884.Value = gclass8_0.GetValueInt("nudTuongTacDelayFrom", 3);
			nudTuongTacDelayTo.Value = gclass8_0.GetValueInt("nudTuongTacDelayTo", 5);
			CB846294.Checked = gclass8_0.GetValueBool("ckbTuongTacLike");
			B52C8909.Checked = gclass8_0.GetValueBool("ckbTuongTacComment");
			C83E6583.Checked = gclass8_0.GetValueBool("ckbTuDongXoaUid");
			D6971CAD.Text = gclass8_0.GetValue("txtComment");
		}
		catch
		{
		}
		method_0();
	}

	private void method_0()
	{
		ckbTuongTac_CheckedChanged(null, null);
		BBA46934(null, null);
	}

	private void D912CC0D(object sender, EventArgs e)
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
		List<string> a2AB53A = E49B5C19.Lines.ToList();
		a2AB53A = Common.RemoveEmptyItems(a2AB53A);
		if (a2AB53A.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p danh sách uid cần kết bạn!", 3);
			return;
		}
		if (ckbTuongTac.Checked && B52C8909.Checked)
		{
			a2AB53A = D6971CAD.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			if (a2AB53A.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nội dung bình luận!", 3);
				return;
			}
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.GetJson("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.GetJson("nudDelayFrom", BF9DA68D.Value);
		gClass.GetJson("nudDelayTo", nudDelayTo.Value);
		gClass.GetJson("ckbKetBanTrungNhau", C83E6583.Checked);
		gClass.GetJson("txtUid", E49B5C19.Text.Trim());
		gClass.GetJson("ckbTuongTac", ckbTuongTac.Checked);
		gClass.GetJson("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.GetJson("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.GetJson("nudTuongTacDelayFrom", D51C4884.Value);
		gClass.GetJson("nudTuongTacDelayTo", nudTuongTacDelayTo.Value);
		gClass.GetJson("ckbTuongTacLike", CB846294.Checked);
		gClass.GetJson("ckbTuongTacComment", B52C8909.Checked);
		gClass.GetJson("txtComment", D6971CAD.Text.Trim());
		gClass.GetJson("ckbTuDongXoaUid", C83E6583.Checked);
		string string_ = gClass.D9A09B34();
		if (BD2F42B6 == 0)
		{
			if (MessageBoxHelper.ShowMessages("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (InteractSQL.smethod_11(string_0, text, string_1, string_))
				{
					F389073F = true;
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
				F389073F = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void CCAFA61F(object sender, EventArgs e)
	{
		Close();
	}

	private void E805968D_Paint(object sender, PaintEventArgs e)
	{
		if (E805968D.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E805968D.ClientSize.Width - num, E805968D.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void E49B5C19_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = E49B5C19.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid cần kết bạn ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void D6971CAD_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> a2AB53A = D6971CAD.Lines.ToList();
			a2AB53A = Common.RemoveEmptyItems(a2AB53A);
			BF2192AE.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), a2AB53A.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = ckbTuongTac.Checked;
	}

	private void BBA46934(object sender, EventArgs e)
	{
		BEB8611D.Enabled = B52C8909.Checked;
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && A5B9E517 != null)
		{
			A5B9E517.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void A13984A6()
	{
		A5B9E517 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(A5B9E517);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(A5B9E517);
		D62FF893 = new Panel();
		FF110A92 = new Button();
		pictureBox1 = new PictureBox();
		E805968D = new Panel();
		plTuongTac = new Panel();
		BEB8611D = new Panel();
		D6971CAD = new TextBox();
		E783832D = new Label();
		BF2192AE = new Label();
		B52C8909 = new CheckBox();
		label54 = new Label();
		label19 = new Label();
		nudSoLuongBaiVietFrom = new NumericUpDown();
		CB846294 = new CheckBox();
		label46 = new Label();
		D51C4884 = new NumericUpDown();
		label47 = new Label();
		nudSoLuongBaiVietTo = new NumericUpDown();
		nudTuongTacDelayTo = new NumericUpDown();
		label67 = new Label();
		label48 = new Label();
		ckbTuongTac = new CheckBox();
		E49B5C19 = new RichTextBox();
		C83E6583 = new CheckBox();
		nudDelayTo = new NumericUpDown();
		F7AEB1AC = new Label();
		lblStatus = new Label();
		BF9DA68D = new NumericUpDown();
		DB99649A = new Label();
		DEA09D2A = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		FFBA8583 = new Label();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		CB81480C = new ToolTip(A5B9E517);
		D62FF893.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		E805968D.SuspendLayout();
		plTuongTac.SuspendLayout();
		BEB8611D.SuspendLayout();
		((ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		((ISupportInitialize)D51C4884).BeginInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((ISupportInitialize)nudTuongTacDelayTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)BF9DA68D).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new Size(341, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp UID v2";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = D62FF893;
		bunifuDragControl_1.Vertical = true;
		D62FF893.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		D62FF893.BackColor = Color.White;
		D62FF893.Controls.Add(FF110A92);
		D62FF893.Controls.Add(pictureBox1);
		D62FF893.Controls.Add(bunifuCustomLabel1);
		D62FF893.Cursor = Cursors.SizeAll;
		D62FF893.Location = new Point(0, 3);
		D62FF893.Name = "pnlHeader";
		D62FF893.Size = new Size(341, 31);
		D62FF893.TabIndex = 9;
		FF110A92.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		FF110A92.Cursor = Cursors.Hand;
		FF110A92.FlatAppearance.BorderSize = 0;
		FF110A92.FlatStyle = FlatStyle.Flat;
		FF110A92.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		FF110A92.ForeColor = Color.White;
		FF110A92.Image = Resources.A13F2207;
		FF110A92.Location = new Point(310, 1);
		FF110A92.Name = "button1";
		FF110A92.Size = new Size(30, 30);
		FF110A92.TabIndex = 77;
		FF110A92.TextImageRelation = TextImageRelation.ImageBeforeText;
		FF110A92.UseVisualStyleBackColor = true;
		FF110A92.Click += D912CC0D;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = Resources.Bitmap_4;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		E805968D.BackColor = Color.White;
		E805968D.BorderStyle = BorderStyle.FixedSingle;
		E805968D.Controls.Add(plTuongTac);
		E805968D.Controls.Add(ckbTuongTac);
		E805968D.Controls.Add(E49B5C19);
		E805968D.Controls.Add(C83E6583);
		E805968D.Controls.Add(nudDelayTo);
		E805968D.Controls.Add(F7AEB1AC);
		E805968D.Controls.Add(lblStatus);
		E805968D.Controls.Add(BF9DA68D);
		E805968D.Controls.Add(DB99649A);
		E805968D.Controls.Add(DEA09D2A);
		E805968D.Controls.Add(label5);
		E805968D.Controls.Add(nudSoLuongTo);
		E805968D.Controls.Add(nudSoLuongFrom);
		E805968D.Controls.Add(txtTenHanhDong);
		E805968D.Controls.Add(FFBA8583);
		E805968D.Controls.Add(label4);
		E805968D.Controls.Add(label2);
		E805968D.Controls.Add(label1);
		E805968D.Controls.Add(btnCancel);
		E805968D.Controls.Add(btnAdd);
		E805968D.Controls.Add(bunifuCards1);
		E805968D.Cursor = Cursors.Arrow;
		E805968D.Dock = DockStyle.Fill;
		E805968D.Location = new Point(0, 0);
		E805968D.Name = "panel1";
		E805968D.Size = new Size(344, 406);
		E805968D.TabIndex = 0;
		E805968D.Paint += E805968D_Paint;
		plTuongTac.BorderStyle = BorderStyle.FixedSingle;
		plTuongTac.Controls.Add(BEB8611D);
		plTuongTac.Controls.Add(B52C8909);
		plTuongTac.Controls.Add(label54);
		plTuongTac.Controls.Add(label19);
		plTuongTac.Controls.Add(nudSoLuongBaiVietFrom);
		plTuongTac.Controls.Add(CB846294);
		plTuongTac.Controls.Add(label46);
		plTuongTac.Controls.Add(D51C4884);
		plTuongTac.Controls.Add(label47);
		plTuongTac.Controls.Add(nudSoLuongBaiVietTo);
		plTuongTac.Controls.Add(nudTuongTacDelayTo);
		plTuongTac.Controls.Add(label67);
		plTuongTac.Controls.Add(label48);
		plTuongTac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		plTuongTac.Location = new Point(360, 74);
		plTuongTac.Name = "plTuongTac";
		plTuongTac.Size = new Size(310, 272);
		plTuongTac.TabIndex = 116;
		BEB8611D.BorderStyle = BorderStyle.FixedSingle;
		BEB8611D.Controls.Add(D6971CAD);
		BEB8611D.Controls.Add(E783832D);
		BEB8611D.Controls.Add(BF2192AE);
		BEB8611D.Location = new Point(25, 113);
		BEB8611D.Name = "plTuongTacComment";
		BEB8611D.Size = new Size(278, 151);
		BEB8611D.TabIndex = 93;
		D6971CAD.Location = new Point(7, 27);
		D6971CAD.Multiline = true;
		D6971CAD.Name = "txtComment";
		D6971CAD.ScrollBars = ScrollBars.Both;
		D6971CAD.Size = new Size(261, 100);
		D6971CAD.TabIndex = 1;
		D6971CAD.WordWrap = false;
		D6971CAD.TextChanged += D6971CAD_TextChanged;
		E783832D.AutoSize = true;
		E783832D.Location = new Point(7, 130);
		E783832D.Name = "label9";
		E783832D.Size = new Size(266, 16);
		E783832D.TabIndex = 0;
		E783832D.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		BF2192AE.AutoSize = true;
		BF2192AE.Location = new Point(3, 5);
		BF2192AE.Name = "lblStatusComment";
		BF2192AE.Size = new Size(140, 16);
		BF2192AE.TabIndex = 0;
		BF2192AE.Text = "Nội dung bình luận (0):";
		B52C8909.AutoSize = true;
		B52C8909.Cursor = Cursors.Hand;
		B52C8909.Location = new Point(7, 88);
		B52C8909.Name = "ckbTuongTacComment";
		B52C8909.Size = new Size(131, 20);
		B52C8909.TabIndex = 92;
		B52C8909.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		B52C8909.UseVisualStyleBackColor = true;
		B52C8909.CheckedChanged += BBA46934;
		label54.AutoSize = true;
		label54.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label54.Location = new Point(240, 7);
		label54.Name = "label54";
		label54.Size = new Size(25, 16);
		label54.TabIndex = 89;
		label54.Text = "ba\u0300i";
		label19.AutoSize = true;
		label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label19.Location = new Point(4, 7);
		label19.Name = "label19";
		label19.Size = new Size(73, 16);
		label19.TabIndex = 89;
		label19.Text = "Sô\u0301 ba\u0300i viê\u0301t:";
		nudSoLuongBaiVietFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongBaiVietFrom.Location = new Point(114, 4);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new Size(42, 23);
		nudSoLuongBaiVietFrom.TabIndex = 2;
		nudSoLuongBaiVietFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		CB846294.AutoSize = true;
		CB846294.Cursor = Cursors.Hand;
		CB846294.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		CB846294.Location = new Point(7, 62);
		CB846294.Name = "ckbTuongTacLike";
		CB846294.Size = new Size(49, 20);
		CB846294.TabIndex = 5;
		CB846294.Text = "Like";
		CB846294.UseVisualStyleBackColor = true;
		label46.AutoSize = true;
		label46.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label46.Location = new Point(4, 34);
		label46.Name = "label46";
		label46.Size = new Size(100, 16);
		label46.TabIndex = 89;
		label46.Text = "Thơ\u0300i gian delay:";
		D51C4884.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D51C4884.Location = new Point(114, 31);
		D51C4884.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		D51C4884.Name = "nudTuongTacDelayFrom";
		D51C4884.Size = new Size(42, 23);
		D51C4884.TabIndex = 3;
		D51C4884.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label47.AutoSize = true;
		label47.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label47.Location = new Point(240, 36);
		label47.Name = "label47";
		label47.Size = new Size(31, 16);
		label47.TabIndex = 91;
		label47.Text = "giây";
		nudSoLuongBaiVietTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongBaiVietTo.Location = new Point(191, 5);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new Size(47, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudSoLuongBaiVietTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		nudTuongTacDelayTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudTuongTacDelayTo.Location = new Point(191, 32);
		nudTuongTacDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
		nudTuongTacDelayTo.Size = new Size(47, 23);
		nudTuongTacDelayTo.TabIndex = 4;
		nudTuongTacDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label67.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label67.Location = new Point(159, 7);
		label67.Name = "label67";
		label67.Size = new Size(29, 16);
		label67.TabIndex = 91;
		label67.Text = "đê\u0301n";
		label67.TextAlign = ContentAlignment.MiddleCenter;
		label48.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label48.Location = new Point(159, 36);
		label48.Name = "label48";
		label48.Size = new Size(29, 16);
		label48.TabIndex = 91;
		label48.Text = "đê\u0301n";
		label48.TextAlign = ContentAlignment.MiddleCenter;
		ckbTuongTac.AutoSize = true;
		ckbTuongTac.Cursor = Cursors.Hand;
		ckbTuongTac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuongTac.Location = new Point(342, 51);
		ckbTuongTac.Name = "ckbTuongTac";
		ckbTuongTac.Size = new Size(185, 20);
		ckbTuongTac.TabIndex = 115;
		ckbTuongTac.Text = "Tương tác trước khi kết bạn";
		ckbTuongTac.UseVisualStyleBackColor = true;
		ckbTuongTac.CheckedChanged += ckbTuongTac_CheckedChanged;
		E49B5C19.BorderStyle = BorderStyle.FixedSingle;
		E49B5C19.Location = new Point(24, 163);
		E49B5C19.Name = "txtUid";
		E49B5C19.Size = new Size(295, 141);
		E49B5C19.TabIndex = 114;
		E49B5C19.Text = "";
		E49B5C19.WordWrap = false;
		E49B5C19.TextChanged += E49B5C19_TextChanged;
		C83E6583.AutoSize = true;
		C83E6583.Cursor = Cursors.Hand;
		C83E6583.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C83E6583.Location = new Point(23, 326);
		C83E6583.Name = "ckbTuDongXoaUid";
		C83E6583.Size = new Size(249, 20);
		C83E6583.TabIndex = 113;
		C83E6583.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 gư\u0309i lơ\u0300i mơ\u0300i kê\u0301t ba\u0323n";
		C83E6583.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(222, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		F7AEB1AC.AutoSize = true;
		F7AEB1AC.Location = new Point(220, 307);
		F7AEB1AC.Name = "label8";
		F7AEB1AC.Size = new Size(103, 16);
		F7AEB1AC.TabIndex = 0;
		F7AEB1AC.Text = "(Mỗi Uid 1 dòng)";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(20, 141);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(185, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Uid cần kết bạn (0):";
		BF9DA68D.Location = new Point(125, 111);
		BF9DA68D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BF9DA68D.Name = "nudDelayFrom";
		BF9DA68D.Size = new Size(56, 23);
		BF9DA68D.TabIndex = 3;
		DB99649A.Location = new Point(187, 113);
		DB99649A.Name = "label7";
		DB99649A.Size = new Size(29, 16);
		DB99649A.TabIndex = 46;
		DB99649A.Text = "đê\u0301n";
		DB99649A.TextAlign = ContentAlignment.MiddleCenter;
		DEA09D2A.AutoSize = true;
		DEA09D2A.Location = new Point(280, 113);
		DEA09D2A.Name = "label6";
		DEA09D2A.Size = new Size(31, 16);
		DEA09D2A.TabIndex = 45;
		DEA09D2A.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(20, 113);
		label5.Name = "label5";
		label5.Size = new Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new Point(222, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(125, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		FFBA8583.Location = new Point(187, 82);
		FFBA8583.Name = "label3";
		FFBA8583.Size = new Size(29, 16);
		FFBA8583.TabIndex = 37;
		FFBA8583.Text = "đê\u0301n";
		FFBA8583.TextAlign = ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new Point(280, 82);
		label4.Name = "label4";
		label4.Size = new Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(20, 82);
		label2.Name = "label2";
		label2.Size = new Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new Point(20, 52);
		label1.Name = "label1";
		label1.Size = new Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(184, 364);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += CCAFA61F;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(77, 364);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(D62FF893);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(341, 37);
		bunifuCards1.TabIndex = 28;
		CB81480C.AutomaticDelay = 0;
		CB81480C.AutoPopDelay = 0;
		CB81480C.InitialDelay = 0;
		CB81480C.ReshowDelay = 0;
		CB81480C.ShowAlways = true;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(344, 406);
		base.Controls.Add(E805968D);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUidv2";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDKetBanTepUidv2_Load;
		D62FF893.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		E805968D.ResumeLayout(performLayout: false);
		E805968D.PerformLayout();
		plTuongTac.ResumeLayout(performLayout: false);
		plTuongTac.PerformLayout();
		BEB8611D.ResumeLayout(performLayout: false);
		BEB8611D.PerformLayout();
		((ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		((ISupportInitialize)D51C4884).EndInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((ISupportInitialize)nudTuongTacDelayTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)BF9DA68D).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
