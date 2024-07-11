using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;


public class fHDDoiNgonNgu : Form
{
	private JSON_Settings gclass8_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox F3157D8B;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ToolTip C3059923;

	private ComboBox cbbLanguage;

	private Label label3;

	public fHDDoiNgonNgu(string string_3, int FBB8388A = 0, string A0A23A08 = "")
	{
		BB205993();
		bool_0 = false;
		string_0 = string_3;
		string_2 = A0A23A08;
		int_0 = FBB8388A;
		string text = base.Name.Substring(1);
		string text2 = "Đổi ngôn ngữ";
		if (InteractSQL.B484648C("", text).Rows.Count == 0)
		{
			ConnectorKichBan.Instance.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (FBB8388A)
		{
		case 0:
		{
			DataTable dataTable2 = InteractSQL.B484648C("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = InteractSQL.FB881189(A0A23A08);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass8_0 = new JSON_Settings(text3, BE9E4429: true);
		Language.SetLanguage(this);
	}

	private void fHDDoiNgonNgu_Load(object sender, EventArgs e)
	{
		try
		{
			cbbLanguage.Text = gclass8_0.GetValue("cbbLanguage");
		}
		catch
		{
		}
	}

	private void C60B0F13(object sender, EventArgs e)
	{
		Close();
	}

	private void D390DF3A(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings gClass = new JSON_Settings();
		gClass.GetJson("cbbLanguage", cbbLanguage.Text);
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

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		string object_ = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		MessageBoxHelper.Show(object_);
	}

	protected override void Dispose(bool F7030407)
	{
		if (F7030407 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F7030407);
	}

	private void BB205993()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDoiNgonNgu));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		F3157D8B = new PictureBox();
		panel1 = new Panel();
		cbbLanguage = new ComboBox();
		label3 = new Label();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		C3059923 = new ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((ISupportInitialize)F3157D8B).BeginInit();
		panel1.SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(345, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đổi ngôn ngữ";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(F3157D8B);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(345, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(314, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += C60B0F13;
		F3157D8B.Cursor = Cursors.Default;
		F3157D8B.Image = Resources.Bitmap_4;
		F3157D8B.Location = new Point(3, 2);
		F3157D8B.Name = "pictureBox1";
		F3157D8B.Size = new Size(34, 27);
		F3157D8B.SizeMode = PictureBoxSizeMode.Zoom;
		F3157D8B.TabIndex = 76;
		F3157D8B.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(cbbLanguage);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(348, 162);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		cbbLanguage.AutoCompleteMode = AutoCompleteMode.Suggest;
		cbbLanguage.AutoCompleteSource = AutoCompleteSource.ListItems;
		cbbLanguage.Cursor = Cursors.Hand;
		cbbLanguage.FormattingEnabled = true;
		cbbLanguage.Items.AddRange(new object[112]
		{
			"so_SO|Tiếng Somali", "af_ZA|Tiếng Afrikaans", "az_AZ|Tiếng Azerbaijan", "id_ID|Tiếng Indo", "ms_MY|Tiếng Mã Lai", "jv_ID|Tiếng Java", "cx_PH|Tiếng Cebuano", "bs_BA|Tiếng Bosnia", "br_FR|Tiếng Breton", "ca_ES|Tiếng Ca-ta-lăng",
			"co_FR|Tiếng Corse", "cy_GB|Tiếng Wales", "da_DK|Tiếng Đan Mạch", "de_DE|Tiếng Đức", "et_EE|Tiếng Estonia", "en_GB|Tiếng Anh (Anh)", "en_US|Tiếng Anh (Mỹ)", "es_LA|Tiếng Tây Ban Nha", "es_ES|Tiếng Tây Ban Nha (Tây Ban Nha)", "eo_EO|Tiếng Esperanto",
			"eu_ES|Tiếng Basque", "tl_PH|Tiếng Philippines", "fr_CA|Tiếng Pháp (Canada)", "fr_FR|Tiếng Pháp (Pháp)", "fy_NL|Tiếng Frisia", "ff_NG|Tiếng Fula", "fo_FO|Tiếng Faroe", "ga_IE|Tiếng Ai-len", "gl_ES|Tiếng Galic", "gn_PY|Tiếng Guarani",
			"ha_NG|Tiếng Hausa", "hr_HR|Tiếng Croatia", "rw_RW|Tiếng Kinyarwanda", "iu_CA|Tiếng Inuktitut", "it_IT|Tiếng Ý", "ik_US|Tiếng Inupiaq", "sw_KE|Tiếng Swahili", "ht_HT|Tiếng Haitian Creole", "ku_TR|Tiếng Kurdish (Kurmanji)", "lv_LV|Tiếng Latvia",
			"lt_LT|Tiếng Lithuania", "hu_HU|Tiếng Hungary", "mg_MG|Tiếng Malagasy", "mt_MT|Tiếng Malta", "nl_NL|Tiếng Hà Lan", "nb_NO|Tiếng Na Uy (bokmal)", "nn_NO|Tiếng Na-uy (nynorsk)", "uz_UZ|Tiếng Uzbek", "pl_PL|Tiếng Ba Lan", "pt_BR|Tiếng Bồ Đào Nha (Brazil)",
			"pt_PT|Tiếng Bồ Đào Nha (Bồ Đào Nha)", "ro_RO|Tiếng Rumani", "sc_IT|Tiếng Sardinia", "sn_ZW|Tiếng Shona", "sq_AL|Tiếng Albani", "sk_SK|Tiếng Slovakia", "sl_SI|Tiếng Sloven", "fi_FI|Tiếng Phần Lan", "sv_SE|Tiếng Thụy Điển", "vi_VN|Tiếng Việt",
			"tr_TR|Tiếng Thổ Nhĩ Kỳ", "nl_BE|Tiếng Hà Lan-Bỉ", "zz_TR|Tiếng Zaza", "is_IS|Tiếng Iceland", "cs_CZ|Tiếng Séc", "sz_PL|Tiếng Silesia", "el_GR|Tiếng Hy Lạp", "be_BY|Tiếng Belarus", "bg_BG|Tiếng Bungari", "mk_MK|Tiếng Macedoni",
			"mn_MN|Tiếng Mông Cổ", "ru_RU|Tiếng Nga", "sr_RS|Tiếng Serbia", "tt_RU|Tiê\u0301ng Tatar", "tg_TJ|Tiếng Tajik", "uk_UA|Tiếng U-krai-na", "ky_KG|Tiếng Kyrgyz", "kk_KZ|Tiếng Kazakh", "hy_AM|Tiếng Armenia", "he_IL|Tiếng Do Thái",
			"ur_PK|Tiếng Urdu", "ar_AR|Tiếng Ả Rập", "fa_IR|Tiếng Ba Tư", "ps_AF|Tiếng Pashto", "cb_IQ|Tiếng Kurd Sorani", "sy_SY|Tiếng Syria", "ne_NP|Tiếng Nepan", "mr_IN|Tiếng Marathi", "hi_IN|Tiếng Hin-di (Ấn Độ)", "as_IN|Tiếng Assam",
			"bn_IN|Tiếng Bengali", "pa_IN|Tiếng Punjabi", "gu_IN|Tiếng Gujarati", "or_IN|Tiếng Oriya", "ta_IN|Tiếng Tamil", "te_IN|Tiếng Telugu", "kn_IN|Tiếng Kannada", "ml_IN|Tiếng Malayalam", "si_LK|Tiếng Sinhala", "th_TH|Tiếng Thái",
			"lo_LA|Tiếng Lào", "my_MM|Tiếng Miến Điện", "ka_GE|Tiếng Georgia", "am_ET|Tiếng Amhara", "km_KH|Tiếng Khơ-me", "tz_MA|Tiếng Tamazight", "zh_TW|Tiếng Trung phồn thể (Đài Loan)", "zh_CN|Tiếng Trung giản thể (Trung Quốc)", "zh_HK|Tiếng Trung phồn thể (Hồng Kông)", "ja_JP|Tiếng Nhật",
			"ja_KS|Tiếng Nhật (Kansai)", "ko_KR|Tiếng Hàn"
		});
		cbbLanguage.Location = new Point(125, 78);
		cbbLanguage.Name = "cbbLanguage";
		cbbLanguage.Size = new Size(194, 24);
		cbbLanguage.TabIndex = 153;
		label3.AutoSize = true;
		label3.Location = new Point(20, 81);
		label3.Name = "label3";
		label3.Size = new Size(64, 16);
		label3.TabIndex = 31;
		label3.Text = "Tùy chọn:";
		txtTenHanhDong.Location = new Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(20, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(184, 119);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
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
		btnAdd.Location = new Point(77, 119);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += D390DF3A;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(345, 37);
		bunifuCards1.TabIndex = 28;
		C3059923.AutomaticDelay = 0;
		C3059923.AutoPopDelay = 0;
		C3059923.InitialDelay = 0;
		C3059923.ReshowDelay = 0;
		C3059923.ShowAlways = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(348, 162);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDoiNgonNgu";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDoiNgonNgu_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)F3157D8B).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
