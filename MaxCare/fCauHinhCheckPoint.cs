using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhCheckPoint : Form
{
	public static bool isOK;

	private List<string> B9301F03 = new List<string>();

	private List<string> list_0 = new List<string>();

	private List<string> BC8512B5 = new List<string>();

	private IContainer B50D4A27 = null;

	private BunifuDragControl A13C109F;

	private BunifuDragControl CB109F91;

	private Panel panel1;

	private Button F0031439;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbCaptcha;

	private TextBox txtImage;

	private CheckBox ckbImage;

	private CheckBox AD32E01F;

	private Panel plPhone;

	private NumericUpDown D4130514;

	private Label label2;

	private BackgroundWorker DC954B3E;

	private Panel plImage;

	private RadioButton EA2F1E2A;

	private RadioButton rbFolder;

	private Panel C91FDCB8;

	private ComboBox BB91541D;

	private TextBox F2168191;

	private Panel plServiceId;

	private TextBox txtServiceId;

	private Label label1;

	private ComboBox CBBF502C;

	private TextBox txtApiPhone;

	private CheckBox ckbLanguage;

	private LinkLabel DCBBD60F;

	private Label label3;

	private GroupBox groupBox2;

	private RadioButton BFBF108F;

	private RadioButton E1A07B9E;

	private TextBox txtPass;

	private GroupBox grCheckpoint282;

	private Button A6BABC1F;

	private NumericUpDown nudLimitCountGetPhone;

	private Label label4;

	private Label B11BB1B4;

	private NumericUpDown F0AA171D;

	private CheckBox ckbAddMail;

	private Panel plMail;

	private Button btnNhapMail;

	private ComboBox cbbTypeMail;

	private Label label7;

	private CheckBox ckbBackupAnh;

	private CheckBox ckbChangeMD5;

	private ComboBox B79C8428;

	private CheckBox ckbDoiNgonNguSauKhiUnlock;

	private Button button3;

	private LinkLabel linkLabel2;

	private CheckBox BA883EA5;

	private TextBox D0923B15;

	private ComboBox EB87E312;

	private Button button4;

	private Panel AD2F798E;

	private RichTextBox txtSdt;

	private Label lblSdt;

	private CheckBox E49A5224;

	public fCauHinhCheckPoint(string B784988E = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		isOK = false;
		grCheckpoint282.Enabled = B784988E.Contains("282");
	}

	private void B7996922(object sender, EventArgs e)
	{
		method_0();
		method_1();
		try
		{
			if (SettingsTool.GetSettings("configCheckpoint").GetValueInt("typePass", 1) == 0)
			{
				BFBF108F.Checked = true;
			}
			else
			{
				E1A07B9E.Checked = true;
			}
			txtPass.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtPass");
			ckbCaptcha.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbCaptcha");
			int num = SettingsTool.GetSettings("configCheckpoint").GetValueInt("typeCaptcha");
			try
			{
				BB91541D.SelectedValue = num.ToString();
			}
			catch
			{
			}
			F2168191.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtCaptcha_" + num);
			if (F2168191.Text == "")
			{
				switch (num)
				{
				case 2:
					F2168191.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtAnyCaptcha");
					break;
				case 0:
					F2168191.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txt2Captcha");
					break;
				}
			}
			E49A5224.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbSwitch282To956");
			AD32E01F.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbPhone");
			int num2 = SettingsTool.GetSettings("configCheckpoint").GetValueInt("typeSim");
			try
			{
				CBBF502C.SelectedValue = num2.ToString();
			}
			catch
			{
			}
			txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtApiPhone_" + num2);
			if (txtApiPhone.Text == "")
			{
				switch (num2)
				{
				case 0:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtAhaSim");
					break;
				case 2:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtSimCode");
					break;
				case 4:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtPrimeOtp");
					break;
				case 6:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtOtpfb");
					break;
				case 8:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtViotp");
					break;
				case 9:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtOtpTextnow");
					break;
				case 10:
					txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtTempCode");
					break;
				}
			}
			txtServiceId.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtServiceId", "fb_tn");
			D4130514.Value = SettingsTool.GetSettings("configCheckpoint").GetValueInt("nudTime", 120);
			nudLimitCountGetPhone.Value = SettingsTool.GetSettings("configCheckpoint").GetValueInt("nudLimitCountGetPhone", 3);
			F0AA171D.Value = SettingsTool.GetSettings("configCheckpoint").GetValueInt("nudLimitTimeGetPhone", 100);
			ckbLanguage.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbLanguage");
			D0923B15.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtLanguage", "en_US,th_TH,my_MM");
			ckbDoiNgonNguSauKhiUnlock.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbDoiNgonNguSauKhiUnlock");
			B79C8428.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("cbbLanguageSauKhiUnlock", "en_US");
			txtSdt.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtSdt");
			ckbAddMail.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbAddMail");
			cbbTypeMail.SelectedIndex = SettingsTool.GetSettings("configCheckpoint").GetValueInt("cbbTypeMail");
			B9301F03 = SettingsTool.GetSettings("configCheckpoint").GetValueList("lstHotmail");
			list_0 = SettingsTool.GetSettings("configCheckpoint").GetValueList("lstMailDomain");
			BC8512B5 = SettingsTool.GetSettings("configCheckpoint").GetValueList("lstDomain");
			ckbImage.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbImage");
			ckbBackupAnh.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbBackupAnh");
			ckbChangeMD5.Checked = SettingsTool.GetSettings("configCheckpoint").GetValueBool("ckbChangeMD5");
			if (SettingsTool.GetSettings("configCheckpoint").GetValueInt("typeImage") == 0)
			{
				rbFolder.Checked = true;
			}
			else
			{
				EA2F1E2A.Checked = true;
			}
			txtImage.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtImage");
			EB87E312.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtImageUrl", "https://this-person-does-not-exist.com");
		}
		catch
		{
		}
		AE203C85();
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("4", "https://omocaptcha.com/");
		dictionary.Add("7", "https://1stcaptcha.com/");
		dictionary.Add("2", "https://anycaptcha.com/");
		dictionary.Add("0", "https://2captcha.com/");
		BB91541D.DataSource = new BindingSource(dictionary, null);
		BB91541D.DisplayMember = "Value";
		BB91541D.ValueMember = "Key";
	}

	private void method_1()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("39", "https://smartotp.net/");
		dictionary.Add("38", "https://app.server-otponline.xyz/");
		dictionary.Add("36", "https://xotp.pro/");
		dictionary.Add("32", "https://sellotpvn.com/");
		dictionary.Add("31", "https://sell282.xyz/");
		dictionary.Add("30", "https://ironsim.com/ VN");
		dictionary.Add("41", "https://ironsim.com/ US");
		dictionary.Add("23", "https://codeotp.site/");
		dictionary.Add("19", "http://hcotp.com/");
		dictionary.Add("16", "https://otp282.com/");
		dictionary.Add("17", "https://2ndline.io/");
		dictionary.Add("13", "https://sim24.cc/");
		dictionary.Add("14", "https://codetext247.com/");
		dictionary.Add("12", "https://winmail.shop/");
		dictionary.Add("2", "https://grizzlysms.com//");
		dictionary.Add("8", "https://viotp.com/");
		dictionary.Add("9", "https://otptextnow.com/");
		CBBF502C.DataSource = new BindingSource(dictionary, null);
		CBBF502C.DisplayMember = "Value";
		CBBF502C.ValueMember = "Key";
	}

	private void A8AEEA3D(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			int num = 0;
			if (E1A07B9E.Checked)
			{
				num = 1;
			}
			SettingsTool.GetSettings("configCheckpoint").GetJson("typePass", num);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtPass", txtPass.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbCaptcha", ckbCaptcha.Checked);
			int num2 = 0;
			try
			{
				num2 = Convert.ToInt32(BB91541D.SelectedValue);
			}
			catch (Exception)
			{
			}
			SettingsTool.GetSettings("configCheckpoint").GetJson("typeCaptcha", num2);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtCaptcha_" + num2, F2168191.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbSwitch282To956", E49A5224.Checked);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbPhone", AD32E01F.Checked);
			int num3 = 0;
			try
			{
				num3 = Convert.ToInt32(CBBF502C.SelectedValue);
			}
			catch
			{
			}
			SettingsTool.GetSettings("configCheckpoint").GetJson("typeSim", num3);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtApiPhone_" + num3, txtApiPhone.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtServiceId", txtServiceId.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("nudTime", D4130514.Value);
			SettingsTool.GetSettings("configCheckpoint").GetJson("nudLimitCountGetPhone", nudLimitCountGetPhone.Value);
			SettingsTool.GetSettings("configCheckpoint").GetJson("nudLimitTimeGetPhone", F0AA171D.Value);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbLanguage", ckbLanguage.Checked);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtLanguage", D0923B15.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbDoiNgonNguSauKhiUnlock", ckbDoiNgonNguSauKhiUnlock.Checked);
			SettingsTool.GetSettings("configCheckpoint").GetJson("cbbLanguageSauKhiUnlock", B79C8428.Text.Split('|')[0]);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtSdt", txtSdt.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbAddMail", ckbAddMail.Checked);
			SettingsTool.GetSettings("configCheckpoint").GetJson("cbbTypeMail", cbbTypeMail.SelectedIndex);
			SettingsTool.GetSettings("configCheckpoint").method_5("lstHotmail", B9301F03);
			SettingsTool.GetSettings("configCheckpoint").method_5("lstMailDomain", list_0);
			SettingsTool.GetSettings("configCheckpoint").method_5("lstDomain", BC8512B5);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbImage", ckbImage.Checked);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbBackupAnh", ckbBackupAnh.Checked);
			SettingsTool.GetSettings("configCheckpoint").GetJson("ckbChangeMD5", ckbChangeMD5.Checked);
			int num4 = 0;
			if (EA2F1E2A.Checked)
			{
				num4 = 1;
			}
			SettingsTool.GetSettings("configCheckpoint").GetJson("typeImage", num4);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtImage", txtImage.Text);
			SettingsTool.GetSettings("configCheckpoint").GetJson("txtImageUrl", EB87E312.Text);
			SettingsTool.Save("configCheckpoint");
			isOK = true;
			Close();
		}
		catch
		{
			MessageBoxHelper.Show("Vui lòng thử lại sau!", 2);
		}
	}

	private void AE203C85()
	{
		ckbCaptcha_CheckedChanged(null, null);
		AD32E01F_CheckedChanged(null, null);
		ckbImage_CheckedChanged(null, null);
		ADAC6D1E(null, null);
		EA2F1E2A_CheckedChanged(null, null);
		ckbBackupAnh_CheckedChanged(null, null);
		ckbAddMail_CheckedChanged(null, null);
		CEB3D900();
		ckbDoiNgonNguSauKhiUnlock_CheckedChanged(null, null);
		CBBF502C_SelectedIndexChanged(null, null);
		C7BB03AD(null, null);
	}

	private void CEB3D900()
	{
		switch (cbbTypeMail.SelectedIndex)
		{
		case 0:
			Common.BE3BB914(btnNhapMail, B9301F03.Count);
			break;
		case 1:
			Common.BE3BB914(btnNhapMail, list_0.Count);
			break;
		case 2:
			Common.BE3BB914(btnNhapMail, BC8512B5.Count);
			break;
		}
	}

	private void C59AA215(object sender, EventArgs e)
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

	private void ckbCaptcha_CheckedChanged(object sender, EventArgs e)
	{
		C91FDCB8.Enabled = ckbCaptcha.Checked;
	}

	private void AD32E01F_CheckedChanged(object sender, EventArgs e)
	{
		plPhone.Enabled = AD32E01F.Checked;
	}

	private void ckbImage_CheckedChanged(object sender, EventArgs e)
	{
		plImage.Enabled = ckbImage.Checked;
	}

	private void ADAC6D1E(object sender, EventArgs e)
	{
		txtImage.Enabled = rbFolder.Checked;
	}

	private void A90D12B1(object sender, EventArgs e)
	{
		try
		{
			F2168191.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtCaptcha_" + BB91541D.SelectedValue.ToString());
		}
		catch
		{
		}
	}

	private void F596F026(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://minsoftware.vn/tong-hop-ma-danh-sach-ngon-ngu-giai-checkpoint282-facebook/#4_Doi_ngon_ngu_khi_giai";
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	private void ckbBackupAnh_CheckedChanged(object sender, EventArgs e)
	{
		D0923B15.Enabled = ckbLanguage.Checked;
	}

	private void CBBF502C_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = "0";
		try
		{
			text = CBBF502C.SelectedValue.ToString();
		}
		catch (Exception)
		{
		}
		txtApiPhone.Text = SettingsTool.GetSettings("configCheckpoint").GetValue("txtApiPhone_" + text);
		plServiceId.Visible = text == "10";
		AD2F798E.Visible = text == "37";
	}

	private void BFBF108F_CheckedChanged(object sender, EventArgs e)
	{
		txtPass.Enabled = BFBF108F.Checked;
	}

	private void DD9A8A88(object sender, EventArgs e)
	{
		string object_ = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		MessageBoxHelper.Show(object_);
	}

	private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
	{
		plMail.Enabled = ckbAddMail.Checked;
	}

	private void btnNhapMail_Click(object sender, EventArgs e)
	{
		switch (cbbTypeMail.SelectedIndex)
		{
		case 0:
		{
			fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(B9301F03, "Nhâ\u0323p danh sa\u0301ch hotmail (mail|pass mail)", "Danh sa\u0301ch mail|pass mail", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.ShowForm(fNhapDuLieu3);
			B9301F03 = fNhapDuLieu3.C82C3629;
			Common.BE3BB914(btnNhapMail, B9301F03.Count);
			break;
		}
		case 1:
		{
			fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch link mail domain", "Danh sa\u0301ch link mail domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.ShowForm(fNhapDuLieu3);
			list_0 = fNhapDuLieu3.C82C3629;
			Common.BE3BB914(btnNhapMail, list_0.Count);
			break;
		}
		case 2:
		{
			fNhapDuLieu1 fNhapDuLieu3 = new fNhapDuLieu1(BC8512B5, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.ShowForm(fNhapDuLieu3);
			BC8512B5 = fNhapDuLieu3.C82C3629;
			Common.BE3BB914(btnNhapMail, BC8512B5.Count);
			break;
		}
		}
	}

	private void EA2F1E2A_CheckedChanged(object sender, EventArgs e)
	{
		EB87E312.Enabled = EA2F1E2A.Checked;
	}

	private void cbbTypeMail_SelectedIndexChanged(object sender, EventArgs e)
	{
		CEB3D900();
	}

	private void ckbDoiNgonNguSauKhiUnlock_CheckedChanged(object sender, EventArgs e)
	{
		B79C8428.Enabled = ckbDoiNgonNguSauKhiUnlock.Checked;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int num = SettingsTool.GetSettings("configCheckpoint").GetValueInt("typeSim");
		string object_ = CaptchaHelperxRentPhone.smethod_2(SettingsTool.GetSettings("configCheckpoint").GetValueInt("typeSim"), SettingsTool.GetSettings("configCheckpoint").GetValue("txtApiPhone_" + num), SettingsTool.GetSettings("configCheckpoint").GetValueInt("nudLimitTimeGetPhone"), SettingsTool.GetSettings("configCheckpoint").GetValue("txtServiceId"), SettingsTool.GetSettings("configCheckpoint").GetValue("txtCustom").Split('*')[0]);
		MessageBoxHelper.Show(object_);
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.CA2A5A03("https://bit.ly/postMaxDownloadImageFromWeb");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		string object_ = Common.CheckCaptcha(BB91541D.Text.ToString(), F2168191.Text.Trim());
		MessageBoxHelper.Show(object_);
	}

	private void C7BB03AD(object sender, EventArgs e)
	{
		Common.F9202C12(txtSdt, lblSdt);
	}

	protected override void Dispose(bool C615E7BC)
	{
		if (C615E7BC && B50D4A27 != null)
		{
			B50D4A27.Dispose();
		}
		base.Dispose(C615E7BC);
	}

	private void InitializeComponent()
	{
		this.B50D4A27 = new System.ComponentModel.Container();
		this.A13C109F = new Bunifu.Framework.UI.BunifuDragControl(this.B50D4A27);
		this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.CB109F91 = new Bunifu.Framework.UI.BunifuDragControl(this.B50D4A27);
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.button1 = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.AD2F798E = new System.Windows.Forms.Panel();
		this.txtSdt = new System.Windows.Forms.RichTextBox();
		this.lblSdt = new System.Windows.Forms.Label();
		this.button4 = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.A6BABC1F = new System.Windows.Forms.Button();
		this.BFBF108F = new System.Windows.Forms.RadioButton();
		this.E1A07B9E = new System.Windows.Forms.RadioButton();
		this.txtPass = new System.Windows.Forms.TextBox();
		this.grCheckpoint282 = new System.Windows.Forms.GroupBox();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.B79C8428 = new System.Windows.Forms.ComboBox();
		this.plPhone = new System.Windows.Forms.Panel();
		this.D0923B15 = new System.Windows.Forms.TextBox();
		this.txtApiPhone = new System.Windows.Forms.TextBox();
		this.button3 = new System.Windows.Forms.Button();
		this.DCBBD60F = new System.Windows.Forms.LinkLabel();
		this.plServiceId = new System.Windows.Forms.Panel();
		this.txtServiceId = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.F0AA171D = new System.Windows.Forms.NumericUpDown();
		this.nudLimitCountGetPhone = new System.Windows.Forms.NumericUpDown();
		this.D4130514 = new System.Windows.Forms.NumericUpDown();
		this.B11BB1B4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.ckbLanguage = new System.Windows.Forms.CheckBox();
		this.CBBF502C = new System.Windows.Forms.ComboBox();
		this.AD32E01F = new System.Windows.Forms.CheckBox();
		this.ckbAddMail = new System.Windows.Forms.CheckBox();
		this.ckbImage = new System.Windows.Forms.CheckBox();
		this.plMail = new System.Windows.Forms.Panel();
		this.btnNhapMail = new System.Windows.Forms.Button();
		this.cbbTypeMail = new System.Windows.Forms.ComboBox();
		this.label7 = new System.Windows.Forms.Label();
		this.plImage = new System.Windows.Forms.Panel();
		this.EB87E312 = new System.Windows.Forms.ComboBox();
		this.EA2F1E2A = new System.Windows.Forms.RadioButton();
		this.rbFolder = new System.Windows.Forms.RadioButton();
		this.txtImage = new System.Windows.Forms.TextBox();
		this.ckbChangeMD5 = new System.Windows.Forms.CheckBox();
		this.ckbBackupAnh = new System.Windows.Forms.CheckBox();
		this.ckbDoiNgonNguSauKhiUnlock = new System.Windows.Forms.CheckBox();
		this.C91FDCB8 = new System.Windows.Forms.Panel();
		this.BB91541D = new System.Windows.Forms.ComboBox();
		this.F2168191 = new System.Windows.Forms.TextBox();
		this.ckbCaptcha = new System.Windows.Forms.CheckBox();
		this.F0031439 = new System.Windows.Forms.Button();
		this.btnAdd = new System.Windows.Forms.Button();
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.BA883EA5 = new System.Windows.Forms.CheckBox();
		this.DC954B3E = new System.ComponentModel.BackgroundWorker();
		this.E49A5224 = new System.Windows.Forms.CheckBox();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		this.panel1.SuspendLayout();
		this.AD2F798E.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.grCheckpoint282.SuspendLayout();
		this.plPhone.SuspendLayout();
		this.plServiceId.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.F0AA171D).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudLimitCountGetPhone).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.D4130514).BeginInit();
		this.plMail.SuspendLayout();
		this.plImage.SuspendLayout();
		this.C91FDCB8.SuspendLayout();
		this.bunifuCards1.SuspendLayout();
		base.SuspendLayout();
		this.A13C109F.Fixed = true;
		this.A13C109F.Horizontal = true;
		this.A13C109F.TargetControl = this.bunifuCustomLabel1;
		this.A13C109F.Vertical = true;
		this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		this.bunifuCustomLabel1.Size = new System.Drawing.Size(873, 31);
		this.bunifuCustomLabel1.TabIndex = 12;
		this.bunifuCustomLabel1.Text = "Cấu hình Giải Checkpoint";
		this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.CB109F91.Fixed = true;
		this.CB109F91.Horizontal = true;
		this.CB109F91.TargetControl = this.pnlHeader;
		this.CB109F91.Vertical = true;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.button1);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 3);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(873, 31);
		this.pnlHeader.TabIndex = 9;
		this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatAppearance.BorderSize = 0;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Image = Resources.A13F2207;
		this.button1.Location = new System.Drawing.Point(842, 1);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(30, 30);
		this.button1.TabIndex = 77;
		this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(A8AEEA3D);
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
		this.panel1.Controls.Add(this.AD2F798E);
		this.panel1.Controls.Add(this.button4);
		this.panel1.Controls.Add(this.groupBox2);
		this.panel1.Controls.Add(this.grCheckpoint282);
		this.panel1.Controls.Add(this.C91FDCB8);
		this.panel1.Controls.Add(this.ckbCaptcha);
		this.panel1.Controls.Add(this.F0031439);
		this.panel1.Controls.Add(this.btnAdd);
		this.panel1.Controls.Add(this.bunifuCards1);
		this.panel1.Controls.Add(this.BA883EA5);
		this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(876, 515);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.AD2F798E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.AD2F798E.Controls.Add(this.txtSdt);
		this.AD2F798E.Controls.Add(this.lblSdt);
		this.AD2F798E.Location = new System.Drawing.Point(24, 279);
		this.AD2F798E.Name = "plNhapSdt";
		this.AD2F798E.Size = new System.Drawing.Size(388, 180);
		this.AD2F798E.TabIndex = 200;
		this.AD2F798E.Visible = false;
		this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.txtSdt.Location = new System.Drawing.Point(7, 24);
		this.txtSdt.Name = "txtSdt";
		this.txtSdt.Size = new System.Drawing.Size(374, 151);
		this.txtSdt.TabIndex = 3;
		this.txtSdt.Text = "";
		this.txtSdt.WordWrap = false;
		this.txtSdt.TextChanged += new System.EventHandler(C7BB03AD);
		this.lblSdt.AutoSize = true;
		this.lblSdt.Location = new System.Drawing.Point(3, 4);
		this.lblSdt.Name = "lblSdt";
		this.lblSdt.Size = new System.Drawing.Size(113, 16);
		this.lblSdt.TabIndex = 2;
		this.lblSdt.Text = "Danh sách sđt (0):";
		this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button4.Location = new System.Drawing.Point(358, 168);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(49, 25);
		this.button4.TabIndex = 122;
		this.button4.Text = "Check";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.groupBox2.Controls.Add(this.A6BABC1F);
		this.groupBox2.Controls.Add(this.BFBF108F);
		this.groupBox2.Controls.Add(this.E1A07B9E);
		this.groupBox2.Controls.Add(this.txtPass);
		this.groupBox2.Location = new System.Drawing.Point(24, 58);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(388, 73);
		this.groupBox2.TabIndex = 198;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Mật khẩu mới";
		this.A6BABC1F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.A6BABC1F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A6BABC1F.Location = new System.Drawing.Point(358, 21);
		this.A6BABC1F.Name = "button2";
		this.A6BABC1F.Size = new System.Drawing.Size(24, 24);
		this.A6BABC1F.TabIndex = 197;
		this.A6BABC1F.Text = "?";
		this.A6BABC1F.UseVisualStyleBackColor = true;
		this.A6BABC1F.Click += new System.EventHandler(DD9A8A88);
		this.BFBF108F.AutoSize = true;
		this.BFBF108F.Checked = true;
		this.BFBF108F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BFBF108F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BFBF108F.Location = new System.Drawing.Point(19, 22);
		this.BFBF108F.Name = "rbPassTuDat";
		this.BFBF108F.Size = new System.Drawing.Size(115, 20);
		this.BFBF108F.TabIndex = 195;
		this.BFBF108F.TabStop = true;
		this.BFBF108F.Text = "Mật khẩu tự đặt";
		this.BFBF108F.UseVisualStyleBackColor = true;
		this.BFBF108F.CheckedChanged += new System.EventHandler(BFBF108F_CheckedChanged);
		this.E1A07B9E.AutoSize = true;
		this.E1A07B9E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E1A07B9E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.E1A07B9E.Location = new System.Drawing.Point(19, 47);
		this.E1A07B9E.Name = "rbPassNgauNhien";
		this.E1A07B9E.Size = new System.Drawing.Size(125, 20);
		this.E1A07B9E.TabIndex = 194;
		this.E1A07B9E.Text = "Mật khẩu random";
		this.E1A07B9E.UseVisualStyleBackColor = true;
		this.txtPass.Location = new System.Drawing.Point(142, 21);
		this.txtPass.Name = "txtPass";
		this.txtPass.Size = new System.Drawing.Size(210, 23);
		this.txtPass.TabIndex = 196;
		this.grCheckpoint282.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.grCheckpoint282.Controls.Add(this.linkLabel2);
		this.grCheckpoint282.Controls.Add(this.B79C8428);
		this.grCheckpoint282.Controls.Add(this.plPhone);
		this.grCheckpoint282.Controls.Add(this.E49A5224);
		this.grCheckpoint282.Controls.Add(this.AD32E01F);
		this.grCheckpoint282.Controls.Add(this.ckbAddMail);
		this.grCheckpoint282.Controls.Add(this.ckbImage);
		this.grCheckpoint282.Controls.Add(this.plMail);
		this.grCheckpoint282.Controls.Add(this.plImage);
		this.grCheckpoint282.Controls.Add(this.ckbDoiNgonNguSauKhiUnlock);
		this.grCheckpoint282.Location = new System.Drawing.Point(435, 58);
		this.grCheckpoint282.Name = "grCheckpoint282";
		this.grCheckpoint282.Size = new System.Drawing.Size(415, 401);
		this.grCheckpoint282.TabIndex = 197;
		this.grCheckpoint282.TabStop = false;
		this.grCheckpoint282.Text = "Checkpoint 282";
		this.linkLabel2.Location = new System.Drawing.Point(238, 261);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(170, 18);
		this.linkLabel2.TabIndex = 197;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Phần mềm tải ảnh miễn phí!";
		this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		this.B79C8428.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.B79C8428.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		this.B79C8428.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		this.B79C8428.DropDownWidth = 150;
		this.B79C8428.FormattingEnabled = true;
		this.B79C8428.Items.AddRange(new object[112]
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
		this.B79C8428.Location = new System.Drawing.Point(197, 371);
		this.B79C8428.Name = "cbbLanguageSauKhiUnlock";
		this.B79C8428.Size = new System.Drawing.Size(205, 24);
		this.B79C8428.TabIndex = 196;
		this.plPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plPhone.Controls.Add(this.D0923B15);
		this.plPhone.Controls.Add(this.txtApiPhone);
		this.plPhone.Controls.Add(this.button3);
		this.plPhone.Controls.Add(this.DCBBD60F);
		this.plPhone.Controls.Add(this.plServiceId);
		this.plPhone.Controls.Add(this.F0AA171D);
		this.plPhone.Controls.Add(this.nudLimitCountGetPhone);
		this.plPhone.Controls.Add(this.D4130514);
		this.plPhone.Controls.Add(this.B11BB1B4);
		this.plPhone.Controls.Add(this.label3);
		this.plPhone.Controls.Add(this.label4);
		this.plPhone.Controls.Add(this.label2);
		this.plPhone.Controls.Add(this.ckbLanguage);
		this.plPhone.Controls.Add(this.CBBF502C);
		this.plPhone.Location = new System.Drawing.Point(35, 45);
		this.plPhone.Name = "plPhone";
		this.plPhone.Size = new System.Drawing.Size(367, 150);
		this.plPhone.TabIndex = 38;
		this.D0923B15.Location = new System.Drawing.Point(223, 62);
		this.D0923B15.Name = "txtLanguage";
		this.D0923B15.Size = new System.Drawing.Size(118, 23);
		this.D0923B15.TabIndex = 45;
		this.D0923B15.Text = "en_US,th_TH,my_MM";
		this.txtApiPhone.Location = new System.Drawing.Point(161, 5);
		this.txtApiPhone.Name = "txtApiPhone";
		this.txtApiPhone.Size = new System.Drawing.Size(199, 23);
		this.txtApiPhone.TabIndex = 34;
		this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button3.Location = new System.Drawing.Point(319, 4);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(42, 25);
		this.button3.TabIndex = 197;
		this.button3.Text = "Test";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.DCBBD60F.AutoSize = true;
		this.DCBBD60F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DCBBD60F.Location = new System.Drawing.Point(347, 65);
		this.DCBBD60F.Name = "linkLabel1";
		this.DCBBD60F.Size = new System.Drawing.Size(13, 16);
		this.DCBBD60F.TabIndex = 195;
		this.DCBBD60F.TabStop = true;
		this.DCBBD60F.Text = "?";
		this.DCBBD60F.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F596F026);
		this.plServiceId.Controls.Add(this.txtServiceId);
		this.plServiceId.Controls.Add(this.label1);
		this.plServiceId.Location = new System.Drawing.Point(148, 32);
		this.plServiceId.Name = "plServiceId";
		this.plServiceId.Size = new System.Drawing.Size(213, 25);
		this.plServiceId.TabIndex = 194;
		this.txtServiceId.Location = new System.Drawing.Point(75, 1);
		this.txtServiceId.Name = "txtServiceId";
		this.txtServiceId.Size = new System.Drawing.Size(137, 23);
		this.txtServiceId.TabIndex = 45;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(8, 4);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(69, 16);
		this.label1.TabIndex = 44;
		this.label1.Text = "service_id:";
		this.F0AA171D.Location = new System.Drawing.Point(223, 120);
		this.F0AA171D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.F0AA171D.Name = "nudLimitTimeGetPhone";
		this.F0AA171D.Size = new System.Drawing.Size(137, 23);
		this.F0AA171D.TabIndex = 38;
		this.nudLimitCountGetPhone.Location = new System.Drawing.Point(223, 91);
		this.nudLimitCountGetPhone.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.nudLimitCountGetPhone.Name = "nudLimitCountGetPhone";
		this.nudLimitCountGetPhone.Size = new System.Drawing.Size(137, 23);
		this.nudLimitCountGetPhone.TabIndex = 38;
		this.D4130514.Location = new System.Drawing.Point(58, 34);
		this.D4130514.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		this.D4130514.Name = "nudTime";
		this.D4130514.Size = new System.Drawing.Size(56, 23);
		this.D4130514.TabIndex = 38;
		this.B11BB1B4.AutoSize = true;
		this.B11BB1B4.Location = new System.Drawing.Point(0, 122);
		this.B11BB1B4.Name = "label5";
		this.B11BB1B4.Size = new System.Drawing.Size(172, 16);
		this.B11BB1B4.TabIndex = 37;
		this.B11BB1B4.Text = "Giới hạn thời gian lấy sđt (s):";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(114, 36);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(30, 16);
		this.label3.TabIndex = 37;
		this.label3.Text = "giây";
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(0, 93);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(137, 16);
		this.label4.TabIndex = 37;
		this.label4.Text = "Giới hạn số lần lấy sđt:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(0, 36);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(56, 16);
		this.label2.TabIndex = 37;
		this.label2.Text = "Chờ otp:";
		this.ckbLanguage.AutoSize = true;
		this.ckbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbLanguage.Location = new System.Drawing.Point(4, 64);
		this.ckbLanguage.Name = "ckbLanguage";
		this.ckbLanguage.Size = new System.Drawing.Size(205, 20);
		this.ckbLanguage.TabIndex = 34;
		this.ckbLanguage.Text = "Đổi ngôn ngữ trước khi lấy Sđt:";
		this.ckbLanguage.UseVisualStyleBackColor = true;
		this.ckbLanguage.CheckedChanged += new System.EventHandler(ckbBackupAnh_CheckedChanged);
		this.CBBF502C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CBBF502C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.CBBF502C.DropDownWidth = 200;
		this.CBBF502C.FormattingEnabled = true;
		this.CBBF502C.Location = new System.Drawing.Point(4, 4);
		this.CBBF502C.Name = "cbbTypePhone";
		this.CBBF502C.Size = new System.Drawing.Size(151, 24);
		this.CBBF502C.TabIndex = 193;
		this.CBBF502C.SelectedIndexChanged += new System.EventHandler(CBBF502C_SelectedIndexChanged);
		this.AD32E01F.AutoSize = true;
		this.AD32E01F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.AD32E01F.Location = new System.Drawing.Point(14, 22);
		this.AD32E01F.Name = "ckbPhone";
		this.AD32E01F.Size = new System.Drawing.Size(88, 20);
		this.AD32E01F.TabIndex = 34;
		this.AD32E01F.Text = "Thêm SĐT";
		this.AD32E01F.UseVisualStyleBackColor = true;
		this.AD32E01F.CheckedChanged += new System.EventHandler(AD32E01F_CheckedChanged);
		this.ckbAddMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbAddMail.AutoSize = true;
		this.ckbAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbAddMail.Location = new System.Drawing.Point(14, 199);
		this.ckbAddMail.Name = "ckbAddMail";
		this.ckbAddMail.Size = new System.Drawing.Size(76, 20);
		this.ckbAddMail.TabIndex = 36;
		this.ckbAddMail.Text = "Add mail";
		this.ckbAddMail.UseVisualStyleBackColor = true;
		this.ckbAddMail.CheckedChanged += new System.EventHandler(ckbAddMail_CheckedChanged);
		this.ckbImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbImage.AutoSize = true;
		this.ckbImage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbImage.Location = new System.Drawing.Point(14, 260);
		this.ckbImage.Name = "ckbImage";
		this.ckbImage.Size = new System.Drawing.Size(66, 20);
		this.ckbImage.TabIndex = 36;
		this.ckbImage.Text = "Up ảnh";
		this.ckbImage.UseVisualStyleBackColor = true;
		this.ckbImage.CheckedChanged += new System.EventHandler(ckbImage_CheckedChanged);
		this.plMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.plMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plMail.Controls.Add(this.btnNhapMail);
		this.plMail.Controls.Add(this.cbbTypeMail);
		this.plMail.Controls.Add(this.label7);
		this.plMail.Location = new System.Drawing.Point(35, 221);
		this.plMail.Name = "plMail";
		this.plMail.Size = new System.Drawing.Size(367, 34);
		this.plMail.TabIndex = 49;
		this.btnNhapMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnNhapMail.Location = new System.Drawing.Point(274, 3);
		this.btnNhapMail.Name = "btnNhapMail";
		this.btnNhapMail.Size = new System.Drawing.Size(86, 26);
		this.btnNhapMail.TabIndex = 122;
		this.btnNhapMail.Text = "Nhập (0)";
		this.btnNhapMail.UseVisualStyleBackColor = true;
		this.btnNhapMail.Click += new System.EventHandler(btnNhapMail_Click);
		this.cbbTypeMail.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbTypeMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbTypeMail.DropDownWidth = 200;
		this.cbbTypeMail.FormattingEnabled = true;
		this.cbbTypeMail.Items.AddRange(new object[3] { "Hotmail", "Mail domain", "https://generator.email/" });
		this.cbbTypeMail.Location = new System.Drawing.Point(74, 4);
		this.cbbTypeMail.Name = "cbbTypeMail";
		this.cbbTypeMail.Size = new System.Drawing.Size(194, 24);
		this.cbbTypeMail.TabIndex = 121;
		this.cbbTypeMail.SelectedIndexChanged += new System.EventHandler(cbbTypeMail_SelectedIndexChanged);
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(4, 7);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(63, 16);
		this.label7.TabIndex = 119;
		this.label7.Text = "Loại mail:";
		this.plImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.plImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.plImage.Controls.Add(this.EB87E312);
		this.plImage.Controls.Add(this.EA2F1E2A);
		this.plImage.Controls.Add(this.rbFolder);
		this.plImage.Controls.Add(this.txtImage);
		this.plImage.Controls.Add(this.ckbChangeMD5);
		this.plImage.Controls.Add(this.ckbBackupAnh);
		this.plImage.Location = new System.Drawing.Point(35, 282);
		this.plImage.Name = "plImage";
		this.plImage.Size = new System.Drawing.Size(367, 85);
		this.plImage.TabIndex = 49;
		this.EB87E312.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EB87E312.DropDownWidth = 250;
		this.EB87E312.FormattingEnabled = true;
		this.EB87E312.Items.AddRange(new object[4] { "https://thispersondoesnotexist.com", "https://this-person-does-not-exist.com", "https://www.unrealperson.com", "https://boredhumans.com" });
		this.EB87E312.Location = new System.Drawing.Point(161, 33);
		this.EB87E312.Name = "cbbImageUrl";
		this.EB87E312.Size = new System.Drawing.Size(200, 24);
		this.EB87E312.TabIndex = 200;
		this.EA2F1E2A.AutoSize = true;
		this.EA2F1E2A.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EA2F1E2A.Location = new System.Drawing.Point(7, 34);
		this.EA2F1E2A.Name = "rbWeb";
		this.EA2F1E2A.Size = new System.Drawing.Size(88, 20);
		this.EA2F1E2A.TabIndex = 38;
		this.EA2F1E2A.Text = "Lấy từ web";
		this.EA2F1E2A.UseVisualStyleBackColor = true;
		this.EA2F1E2A.CheckedChanged += new System.EventHandler(EA2F1E2A_CheckedChanged);
		this.rbFolder.AutoSize = true;
		this.rbFolder.Checked = true;
		this.rbFolder.Cursor = System.Windows.Forms.Cursors.Hand;
		this.rbFolder.Location = new System.Drawing.Point(7, 5);
		this.rbFolder.Name = "rbFolder";
		this.rbFolder.Size = new System.Drawing.Size(144, 20);
		this.rbFolder.TabIndex = 38;
		this.rbFolder.TabStop = true;
		this.rbFolder.Text = "Đường dẫn thư mục:";
		this.rbFolder.UseVisualStyleBackColor = true;
		this.rbFolder.CheckedChanged += new System.EventHandler(ADAC6D1E);
		this.txtImage.Location = new System.Drawing.Point(161, 4);
		this.txtImage.Name = "txtImage";
		this.txtImage.Size = new System.Drawing.Size(200, 23);
		this.txtImage.TabIndex = 37;
		this.ckbChangeMD5.AutoSize = true;
		this.ckbChangeMD5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbChangeMD5.Location = new System.Drawing.Point(7, 60);
		this.ckbChangeMD5.Name = "ckbChangeMD5";
		this.ckbChangeMD5.Size = new System.Drawing.Size(138, 20);
		this.ckbChangeMD5.TabIndex = 34;
		this.ckbChangeMD5.Text = "Change MD5 Image";
		this.ckbChangeMD5.UseVisualStyleBackColor = true;
		this.ckbChangeMD5.CheckedChanged += new System.EventHandler(ckbBackupAnh_CheckedChanged);
		this.ckbBackupAnh.AutoSize = true;
		this.ckbBackupAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbBackupAnh.Location = new System.Drawing.Point(161, 60);
		this.ckbBackupAnh.Name = "ckbBackupAnh";
		this.ckbBackupAnh.Size = new System.Drawing.Size(176, 20);
		this.ckbBackupAnh.TabIndex = 34;
		this.ckbBackupAnh.Text = "Ưu tiên gửi ảnh đã backup";
		this.ckbBackupAnh.UseVisualStyleBackColor = true;
		this.ckbBackupAnh.CheckedChanged += new System.EventHandler(ckbBackupAnh_CheckedChanged);
		this.ckbDoiNgonNguSauKhiUnlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.ckbDoiNgonNguSauKhiUnlock.AutoSize = true;
		this.ckbDoiNgonNguSauKhiUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbDoiNgonNguSauKhiUnlock.Location = new System.Drawing.Point(14, 373);
		this.ckbDoiNgonNguSauKhiUnlock.Name = "ckbDoiNgonNguSauKhiUnlock";
		this.ckbDoiNgonNguSauKhiUnlock.Size = new System.Drawing.Size(187, 20);
		this.ckbDoiNgonNguSauKhiUnlock.TabIndex = 34;
		this.ckbDoiNgonNguSauKhiUnlock.Text = "Đổi ngôn ngữ sau khi unlock";
		this.ckbDoiNgonNguSauKhiUnlock.UseVisualStyleBackColor = true;
		this.ckbDoiNgonNguSauKhiUnlock.CheckedChanged += new System.EventHandler(ckbDoiNgonNguSauKhiUnlock_CheckedChanged);
		this.C91FDCB8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.C91FDCB8.Controls.Add(this.BB91541D);
		this.C91FDCB8.Controls.Add(this.F2168191);
		this.C91FDCB8.Location = new System.Drawing.Point(45, 163);
		this.C91FDCB8.Name = "plCaptcha";
		this.C91FDCB8.Size = new System.Drawing.Size(367, 34);
		this.C91FDCB8.TabIndex = 48;
		this.BB91541D.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB91541D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.BB91541D.DropDownWidth = 200;
		this.BB91541D.FormattingEnabled = true;
		this.BB91541D.Location = new System.Drawing.Point(4, 4);
		this.BB91541D.Name = "cbbCaptcha";
		this.BB91541D.Size = new System.Drawing.Size(151, 24);
		this.BB91541D.TabIndex = 193;
		this.BB91541D.SelectedIndexChanged += new System.EventHandler(A90D12B1);
		this.F2168191.Location = new System.Drawing.Point(161, 5);
		this.F2168191.Name = "txtCaptcha";
		this.F2168191.Size = new System.Drawing.Size(147, 23);
		this.F2168191.TabIndex = 34;
		this.ckbCaptcha.AutoSize = true;
		this.ckbCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ckbCaptcha.Location = new System.Drawing.Point(24, 137);
		this.ckbCaptcha.Name = "ckbCaptcha";
		this.ckbCaptcha.Size = new System.Drawing.Size(95, 20);
		this.ckbCaptcha.TabIndex = 32;
		this.ckbCaptcha.Text = "Giải captcha";
		this.ckbCaptcha.UseVisualStyleBackColor = true;
		this.ckbCaptcha.CheckedChanged += new System.EventHandler(ckbCaptcha_CheckedChanged);
		this.F0031439.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F0031439.BackColor = System.Drawing.Color.Maroon;
		this.F0031439.Cursor = System.Windows.Forms.Cursors.Hand;
		this.F0031439.FlatAppearance.BorderSize = 0;
		this.F0031439.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.F0031439.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F0031439.ForeColor = System.Drawing.Color.White;
		this.F0031439.Location = new System.Drawing.Point(445, 471);
		this.F0031439.Name = "btnCancel";
		this.F0031439.Size = new System.Drawing.Size(92, 29);
		this.F0031439.TabIndex = 10;
		this.F0031439.Text = "Đóng";
		this.F0031439.UseVisualStyleBackColor = false;
		this.F0031439.Click += new System.EventHandler(C59AA215);
		this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnAdd.FlatAppearance.BorderSize = 0;
		this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdd.ForeColor = System.Drawing.Color.White;
		this.btnAdd.Location = new System.Drawing.Point(338, 471);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.Size = new System.Drawing.Size(92, 29);
		this.btnAdd.TabIndex = 9;
		this.btnAdd.Text = "Lưu";
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
		this.bunifuCards1.Size = new System.Drawing.Size(873, 37);
		this.bunifuCards1.TabIndex = 28;
		this.BA883EA5.AutoSize = true;
		this.BA883EA5.Font = new System.Drawing.Font("Tahoma", 8.75f);
		this.BA883EA5.Location = new System.Drawing.Point(441, 431);
		this.BA883EA5.Name = "ckbXoaMailCu";
		this.BA883EA5.Size = new System.Drawing.Size(167, 18);
		this.BA883EA5.TabIndex = 199;
		this.BA883EA5.Text = "Xóa email cũ (Nếu Fb hỏi)";
		this.BA883EA5.UseVisualStyleBackColor = true;
		this.BA883EA5.Visible = false;
		this.E49A5224.AutoSize = true;
		this.E49A5224.Cursor = System.Windows.Forms.Cursors.Hand;
		this.E49A5224.Location = new System.Drawing.Point(276, 22);
		this.E49A5224.Name = "ckbSwitch282To956";
		this.E49A5224.Size = new System.Drawing.Size(119, 20);
		this.E49A5224.TabIndex = 34;
		this.E49A5224.Text = "Đa\u0301 956 (nê\u0301u co\u0301)";
		this.E49A5224.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(876, 515);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fCauHinhCheckPoint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B7996922);
		this.pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.AD2F798E.ResumeLayout(false);
		this.AD2F798E.PerformLayout();
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.grCheckpoint282.ResumeLayout(false);
		this.grCheckpoint282.PerformLayout();
		this.plPhone.ResumeLayout(false);
		this.plPhone.PerformLayout();
		this.plServiceId.ResumeLayout(false);
		this.plServiceId.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.F0AA171D).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudLimitCountGetPhone).EndInit();
		((System.ComponentModel.ISupportInitialize)this.D4130514).EndInit();
		this.plMail.ResumeLayout(false);
		this.plMail.PerformLayout();
		this.plImage.ResumeLayout(false);
		this.plImage.PerformLayout();
		this.C91FDCB8.ResumeLayout(false);
		this.C91FDCB8.PerformLayout();
		this.bunifuCards1.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
