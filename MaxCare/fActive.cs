using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fActive : Form
{
	[CompilerGenerated]
	private sealed class Class114
	{
		public fActive CF13C535;

		public string string_0;

		public string AF17309A;

		public MethodInvoker methodInvoker_0;

		public MethodInvoker B6B196A5;

		public MethodInvoker FA27C7B7;

		public MethodInvoker methodInvoker_1;

		public MethodInvoker methodInvoker_2;

		public MethodInvoker methodInvoker_3;

		public MethodInvoker methodInvoker_4;

		internal void C3AA0A86()
		{
			CF13C535.btnLogin.Invoke((MethodInvoker)delegate
			{
				CF13C535.btnLogin.Enabled = false;
			});
			CF13C535.lblStatus.Invoke((MethodInvoker)delegate
			{
				CF13C535.lblStatus.Text = Language.GetValue("Đang kiểm tra đăng nhập...");
			});
			try
			{
				C8904CBA CS_0024_003C_003E8__locals0 = new C8904CBA
				{
					class114_0 = this,
					A9BEB6AA = Common.FF88D40C(string_0, AF17309A)
				};
				if (CS_0024_003C_003E8__locals0.A9BEB6AA.StartsWith("0|"))
				{
					CF13C535.lblStatus.Invoke((MethodInvoker)delegate
					{
						CS_0024_003C_003E8__locals0.class114_0.CF13C535.lblStatus.Text = CS_0024_003C_003E8__locals0.A9BEB6AA.Substring(2);
					});
					CF13C535.btnLogin.Invoke((MethodInvoker)delegate
					{
						CF13C535.btnLogin.Enabled = true;
					});
					return;
				}
				CS_0024_003C_003E8__locals0.A9BEB6AA = CS_0024_003C_003E8__locals0.A9BEB6AA.Substring(2);
				if (CS_0024_003C_003E8__locals0.A9BEB6AA.Split('|').Length < 3)
				{
					CF13C535.lblStatus.Invoke((MethodInvoker)delegate
					{
						CF13C535.lblStatus.Text = Language.GetValue("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
					});
					CF13C535.btnLogin.Invoke((MethodInvoker)delegate
					{
						CF13C535.btnLogin.Enabled = true;
					});
					return;
				}
				SettingsTool.GetSettings("settingLogin").GetJson("UserName", string_0);
				SettingsTool.GetSettings("settingLogin").GetJson("PassWord", AF17309A);
				SettingsTool.Save("settingLogin");
				CF13C535.lblStatus.Invoke((MethodInvoker)delegate
				{
					CF13C535.lblStatus.Text = Language.GetValue("Đăng nhập thành công!");
				});
				MessageBoxHelper.Show(Language.GetValue("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của MIN Software.") + "\r\n" + Language.GetValue("Vui lòng mở lại phần mềm để sử dụng!"));
				try
				{
					Environment.Exit(0);
				}
				catch (Exception)
				{
					Application.Exit();
				}
			}
			catch (Exception ex2)
			{
				MessageBoxHelper.Show("Active error:\n" + ex2.ToString(), 3);
				Common.ExportError(null, ex2, "Active error");
				MessageBoxHelper.Show("Lỗi không xác định!!!", 2);
			}
			CF13C535.btnLogin.Invoke((MethodInvoker)delegate
			{
				CF13C535.btnLogin.Enabled = true;
			});
		}

		internal void EA35B989()
		{
			CF13C535.btnLogin.Enabled = false;
		}

		internal void method_0()
		{
			CF13C535.lblStatus.Text = Language.GetValue("Đang kiểm tra đăng nhập...");
		}

		internal void method_1()
		{
			CF13C535.btnLogin.Enabled = true;
		}

		internal void F896A0A2()
		{
			CF13C535.lblStatus.Text = Language.GetValue("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
		}

		internal void E1BA7631()
		{
			CF13C535.btnLogin.Enabled = true;
		}

		internal void method_2()
		{
			CF13C535.lblStatus.Text = Language.GetValue("Đăng nhập thành công!");
		}

		internal void method_3()
		{
			CF13C535.btnLogin.Enabled = true;
		}
	}

	[CompilerGenerated]
	private sealed class C8904CBA
	{
		public string A9BEB6AA;

		public Class114 class114_0;

		internal void BE3C36AA()
		{
			class114_0.CF13C535.lblStatus.Text = A9BEB6AA.Substring(2);
		}
	}

	private int int_0 = 0;

	private Bitmap C9B3DC19 = Resources.AFB0A0B8;

	private Bitmap bitmap_0 = Resources.Bitmap_172;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A38153B4;

	private BunifuMetroTextbox txbUserName;

	private BunifuCustomLabel FEA24402;

	private BunifuCustomLabel bunifuCustomLabel3;

	private BunifuMetroTextbox txbPassword;

	private Button btnLogin;

	private Label lblStatus;

	private LinkLabel DE2F7C11;

	private Label label1;

	private Button btnMinimize;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox2;

	private BunifuCustomLabel bunifuCustomLabel8;

	private BunifuCustomLabel B707D8BD;

	private BunifuCustomLabel E53F0285;

	private BunifuCustomLabel F6168883;

	private BunifuCustomLabel FB8FFAB7;

	private BunifuDragControl bunifuDragControl_1;

	private BunifuCustomLabel BC9E7FA9;

	private BunifuCustomLabel E0255324;

	private ComboBox cbbServer;

	private LinkLabel linkLabel2;

	private Label label2;

	private PictureBox D813948C;

	public fActive(int DE213F2C)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		int_0 = DE213F2C;
		lblStatus.Text = method_0(DE213F2C);
		F6168883.Text = Common.GetDeviceId();
		Common.F5A0B829(cbbServer, Base.B33DDBA5());
		D813948C.Image = ((Base.GetLanguage() != "VN") ? C9B3DC19 : bitmap_0);
		A38153B4.Text = A38153B4.Text.Split('-')[0] + "- " + Language.GetValue(A38153B4.Text.Split('-')[1].Trim());
	}

	public fActive(string D60AB2B5)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		lblStatus.Text = D60AB2B5;
		F6168883.Text = Common.GetDeviceId();
		Common.F5A0B829(cbbServer, Base.B33DDBA5());
		D813948C.Image = ((Base.GetLanguage() != "VN") ? C9B3DC19 : bitmap_0);
	}

	private void EB17AAB2(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private string method_0(int B88A9483 = 0)
	{
		return B88A9483 switch
		{
			0 => "", 
			1 => Language.GetValue("Vui lòng đăng nhập để sử dụng phần mềm!!!"), 
			2 => Language.GetValue("Thiết bị của bạn chưa được kích hoạt!!!"), 
			3 => Language.GetValue("Thiết bị của bạn đã hết hạn sử dụng!!!"), 
			4 => Language.GetValue("Tài khoản hoặc mật khẩu bạn nhập không đúng!!!"), 
			5 => Language.GetValue("Server Error!!!"), 
			_ => Language.GetValue("Lỗi không xác định!!!"), 
		};
	}

	private void FFA2A734(object sender, EventArgs e)
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
		if (File.Exists(path))
		{
			try
			{
				List<string> list = new List<string> { "minsoftware" };
				using StreamReader streamReader = new StreamReader(path);
				string empty = string.Empty;
				while ((empty = streamReader.ReadLine()) != null)
				{
					foreach (string item in list)
					{
						if (empty.ToLower().Contains(item))
						{
							MessageBoxHelper.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
							Environment.Exit(0);
						}
					}
				}
			}
			catch
			{
			}
		}
		string username = txbUserName.Text.Trim();
		string password = txbPassword.Text.Trim();
		if (username == "" || password == "")
		{
			MessageBoxHelper.Show("Vui lòng điền đầy đủ thông tin!", 3);
			return;
		}
		if (!username.Contains("@"))
		{
			username += "@gmail.com";
		}
		SettingsTool.GetSettings("settingLogin").GetJson("Server", cbbServer.SelectedValue);
		SettingsTool.Save("settingLogin");
		new Thread((ThreadStart)delegate
		{
			btnLogin.Invoke((MethodInvoker)delegate
			{
				btnLogin.Enabled = false;
			});
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Text = Language.GetValue("Đang kiểm tra đăng nhập...");
			});
			try
			{
				string A9BEB6AA = Common.FF88D40C(username, password);
				if (A9BEB6AA.StartsWith("0|"))
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = A9BEB6AA.Substring(2);
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				A9BEB6AA = A9BEB6AA.Substring(2);
				if (A9BEB6AA.Split('|').Length < 3)
				{
					lblStatus.Invoke((MethodInvoker)delegate
					{
						lblStatus.Text = Language.GetValue("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
					});
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
					return;
				}
				SettingsTool.GetSettings("settingLogin").GetJson("UserName", username);
				SettingsTool.GetSettings("settingLogin").GetJson("PassWord", password);
				SettingsTool.Save("settingLogin");
				lblStatus.Invoke((MethodInvoker)delegate
				{
					lblStatus.Text = Language.GetValue("Đăng nhập thành công!");
				});
				MessageBoxHelper.Show(Language.GetValue("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của MIN Software.") + "\r\n" + Language.GetValue("Vui lòng mở lại phần mềm để sử dụng!"));
				try
				{
					Environment.Exit(0);
				}
				catch (Exception)
				{
					Application.Exit();
				}
			}
			catch (Exception ex2)
			{
				MessageBoxHelper.Show("Active error:\n" + ex2.ToString(), 3);
				Common.ExportError(null, ex2, "Active error");
				MessageBoxHelper.Show("Lỗi không xác định!!!", 2);
			}
			btnLogin.Invoke((MethodInvoker)delegate
			{
				btnLogin.Enabled = true;
			});
		}).Start();
	}

	private void AE927F24_FormClosing(object sender, FormClosingEventArgs e)
	{
		Environment.Exit(0);
	}

	private void DE2F7C11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.CA2A5A03("https://www.facebook.com/longk.hoanghai");
	}

	private void E106C086(object sender, EventArgs e)
	{
		Common.SetTextToClipboard(F6168883.Text);
		MessageBoxHelper.Show("Đã copy mã thiết bị!");
	}

	private void txbPassword_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			FFA2A734(null, null);
		}
	}

	private void B2A1C700(object sender, EventArgs e)
	{
		if (!E0255324.Visible)
		{
			E0255324.Visible = true;
			cbbServer.Visible = true;
			base.Height = 320;
		}
		else
		{
			E0255324.Visible = false;
			cbbServer.Visible = false;
			base.Height = 275;
		}
	}

	private void AE927F24_Load(object sender, EventArgs e)
	{
		cbbServer.SelectedValue = Base.smethod_1();
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://bit.ly/DieukhoanvaChinhsach";
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	private void D813948C_Click(object sender, EventArgs e)
	{
		if (D813948C.Image == C9B3DC19)
		{
			D813948C.Image = bitmap_0;
			Base.SetLanguage();
			MessageBoxHelper.Show("Vui lòng mở lại phần mềm để cập nhật ngôn ngữ!");
		}
		else
		{
			D813948C.Image = C9B3DC19;
			Base.SetLanguage("EN");
		}
		Base.GetLanguage();
		Language.SetLanguage(this);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fActive));
		this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		this.pnlHeader = new System.Windows.Forms.Panel();
		this.D813948C = new System.Windows.Forms.PictureBox();
		this.btnMinimize = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.A38153B4 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.txbUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
		this.FEA24402 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.txbPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
		this.btnLogin = new System.Windows.Forms.Button();
		this.lblStatus = new System.Windows.Forms.Label();
		this.DE2F7C11 = new System.Windows.Forms.LinkLabel();
		this.label1 = new System.Windows.Forms.Label();
		this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.B707D8BD = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E53F0285 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.F6168883 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.FB8FFAB7 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(this.icontainer_0);
		this.BC9E7FA9 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.E0255324 = new Bunifu.Framework.UI.BunifuCustomLabel();
		this.cbbServer = new System.Windows.Forms.ComboBox();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.label2 = new System.Windows.Forms.Label();
		this.bunifuCards1.SuspendLayout();
		this.pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.D813948C).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.bunifuCards1.BackColor = System.Drawing.Color.White;
		this.bunifuCards1.BorderRadius = 0;
		this.bunifuCards1.BottomSahddow = true;
		this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		this.bunifuCards1.Controls.Add(this.pnlHeader);
		this.bunifuCards1.LeftSahddow = false;
		this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
		this.bunifuCards1.Name = "bunifuCards1";
		this.bunifuCards1.RightSahddow = true;
		this.bunifuCards1.ShadowDepth = 20;
		this.bunifuCards1.Size = new System.Drawing.Size(395, 38);
		this.bunifuCards1.TabIndex = 11;
		this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.pnlHeader.BackColor = System.Drawing.Color.White;
		this.pnlHeader.Controls.Add(this.D813948C);
		this.pnlHeader.Controls.Add(this.btnMinimize);
		this.pnlHeader.Controls.Add(this.pictureBox1);
		this.pnlHeader.Controls.Add(this.A38153B4);
		this.pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.pnlHeader.Location = new System.Drawing.Point(0, 5);
		this.pnlHeader.Name = "pnlHeader";
		this.pnlHeader.Size = new System.Drawing.Size(393, 32);
		this.pnlHeader.TabIndex = 9;
		this.D813948C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.D813948C.Cursor = System.Windows.Forms.Cursors.Hand;
		this.D813948C.Image = Resources.Bitmap_172;
		this.D813948C.Location = new System.Drawing.Point(330, 3);
		this.D813948C.Name = "picLanguage";
		this.D813948C.Size = new System.Drawing.Size(25, 25);
		this.D813948C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.D813948C.TabIndex = 15;
		this.D813948C.TabStop = false;
		this.D813948C.Click += new System.EventHandler(D813948C_Click);
		this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		this.btnMinimize.FlatAppearance.BorderSize = 0;
		this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnMinimize.ForeColor = System.Drawing.Color.White;
		this.btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		this.btnMinimize.Location = new System.Drawing.Point(361, 0);
		this.btnMinimize.Name = "btnMinimize";
		this.btnMinimize.Size = new System.Drawing.Size(32, 32);
		this.btnMinimize.TabIndex = 13;
		this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnMinimize.UseVisualStyleBackColor = true;
		this.btnMinimize.Click += new System.EventHandler(EB17AAB2);
		this.pictureBox1.Image = Resources.Bitmap_4;
		this.pictureBox1.Location = new System.Drawing.Point(6, 2);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(34, 27);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pictureBox1.TabIndex = 12;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(B2A1C700);
		this.A38153B4.AutoSize = true;
		this.A38153B4.BackColor = System.Drawing.Color.Transparent;
		this.A38153B4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.A38153B4.ForeColor = System.Drawing.Color.Black;
		this.A38153B4.Location = new System.Drawing.Point(42, 7);
		this.A38153B4.Name = "bunifuCustomLabel1";
		this.A38153B4.Size = new System.Drawing.Size(221, 16);
		this.A38153B4.TabIndex = 7;
		this.A38153B4.Text = "MAX CARE - Kích hoạt bản quyền";
		this.txbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.txbUserName.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbUserName.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbUserName.BorderThickness = 3;
		this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txbUserName.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbUserName.isPassword = false;
		this.txbUserName.Location = new System.Drawing.Point(117, 46);
		this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
		this.txbUserName.Name = "txbUserName";
		this.txbUserName.Size = new System.Drawing.Size(228, 29);
		this.txbUserName.TabIndex = 0;
		this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.txbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(txbPassword_KeyDown);
		this.FEA24402.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.FEA24402.AutoSize = true;
		this.FEA24402.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FEA24402.Location = new System.Drawing.Point(37, 52);
		this.FEA24402.Name = "bunifuCustomLabel2";
		this.FEA24402.Size = new System.Drawing.Size(44, 16);
		this.FEA24402.TabIndex = 13;
		this.FEA24402.Text = "Email:";
		this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.bunifuCustomLabel3.AutoSize = true;
		this.bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 88);
		this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
		this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 16);
		this.bunifuCustomLabel3.TabIndex = 15;
		this.bunifuCustomLabel3.Text = "Mật khẩu:";
		this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.txbPassword.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		this.txbPassword.BorderThickness = 3;
		this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txbPassword.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.txbPassword.isPassword = true;
		this.txbPassword.Location = new System.Drawing.Point(117, 83);
		this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
		this.txbPassword.Name = "txbPassword";
		this.txbPassword.Size = new System.Drawing.Size(228, 29);
		this.txbPassword.TabIndex = 1;
		this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(txbPassword_KeyDown);
		this.btnLogin.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnLogin.FlatAppearance.BorderSize = 0;
		this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnLogin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnLogin.ForeColor = System.Drawing.Color.White;
		this.btnLogin.Location = new System.Drawing.Point(149, 178);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new System.Drawing.Size(115, 29);
		this.btnLogin.TabIndex = 2;
		this.btnLogin.Text = "Đăng nhập";
		this.btnLogin.UseVisualStyleBackColor = false;
		this.btnLogin.Click += new System.EventHandler(FFA2A734);
		this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.ForeColor = System.Drawing.Color.Red;
		this.lblStatus.Location = new System.Drawing.Point(10, 157);
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(371, 18);
		this.lblStatus.TabIndex = 28;
		this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DE2F7C11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.DE2F7C11.AutoSize = true;
		this.DE2F7C11.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DE2F7C11.LinkColor = System.Drawing.Color.FromArgb(53, 120, 229);
		this.DE2F7C11.Location = new System.Drawing.Point(285, 217);
		this.DE2F7C11.Name = "linkLabel1";
		this.DE2F7C11.Size = new System.Drawing.Size(27, 16);
		this.DE2F7C11.TabIndex = 3;
		this.DE2F7C11.TabStop = true;
		this.DE2F7C11.Text = "đây";
		this.DE2F7C11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DE2F7C11_LinkClicked);
		this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(100, 217);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(187, 16);
		this.label1.TabIndex = 30;
		this.label1.Text = "Đăng ký tài khoản mới bấm vào";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.bunifuDragControl_0.Fixed = true;
		this.bunifuDragControl_0.Horizontal = true;
		this.bunifuDragControl_0.TargetControl = this.pnlHeader;
		this.bunifuDragControl_0.Vertical = true;
		this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		this.pictureBox2.Location = new System.Drawing.Point(357, 281);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(20, 20);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 42;
		this.pictureBox2.TabStop = false;
		this.pictureBox2.Click += new System.EventHandler(E106C086);
		this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.bunifuCustomLabel8.AutoSize = true;
		this.bunifuCustomLabel8.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
		this.bunifuCustomLabel8.Location = new System.Drawing.Point(94, 240);
		this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
		this.bunifuCustomLabel8.Size = new System.Drawing.Size(140, 13);
		this.bunifuCustomLabel8.TabIndex = 40;
		this.bunifuCustomLabel8.Text = "https://www.facebook.com/longk.hoanghai";
		this.B707D8BD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.B707D8BD.AutoSize = true;
		this.B707D8BD.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.B707D8BD.Location = new System.Drawing.Point(22, 240);
		this.B707D8BD.Name = "bunifuCustomLabel6";
		this.B707D8BD.Size = new System.Drawing.Size(56, 13);
		this.B707D8BD.TabIndex = 38;
		this.B707D8BD.Text = "Website:";
		this.E53F0285.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.E53F0285.AutoSize = true;
		this.E53F0285.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E53F0285.Location = new System.Drawing.Point(22, 262);
		this.E53F0285.Name = "bunifuCustomLabel4";
		this.E53F0285.Size = new System.Drawing.Size(53, 13);
		this.E53F0285.TabIndex = 39;
		this.E53F0285.Text = "Hotline: ";
		this.F6168883.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.F6168883.AutoSize = true;
		this.F6168883.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.F6168883.ForeColor = System.Drawing.Color.Gray;
		this.F6168883.Location = new System.Drawing.Point(94, 284);
		this.F6168883.Name = "lblKey";
		this.F6168883.Size = new System.Drawing.Size(231, 13);
		this.F6168883.TabIndex = 37;
		this.F6168883.Text = "********************************";
		this.FB8FFAB7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.FB8FFAB7.AutoSize = true;
		this.FB8FFAB7.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.FB8FFAB7.Location = new System.Drawing.Point(22, 284);
		this.FB8FFAB7.Name = "bunifuCustomLabel7";
		this.FB8FFAB7.Size = new System.Drawing.Size(70, 13);
		this.FB8FFAB7.TabIndex = 36;
		this.FB8FFAB7.Text = "Mã thiết bị:";
		this.bunifuDragControl_1.Fixed = true;
		this.bunifuDragControl_1.Horizontal = true;
		this.bunifuDragControl_1.TargetControl = this.A38153B4;
		this.bunifuDragControl_1.Vertical = true;
		this.BC9E7FA9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		this.BC9E7FA9.AutoSize = true;
		this.BC9E7FA9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.BC9E7FA9.ForeColor = System.Drawing.Color.Gray;
		this.BC9E7FA9.Location = new System.Drawing.Point(94, 262);
		this.BC9E7FA9.Name = "bunifuCustomLabel5";
		this.BC9E7FA9.Size = new System.Drawing.Size(257, 13);
		this.BC9E7FA9.TabIndex = 41;
		this.BC9E7FA9.Text = "0969.078.803 - 0966.260.829 - 0973.363.129";
		this.E0255324.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.E0255324.AutoSize = true;
		this.E0255324.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E0255324.Location = new System.Drawing.Point(37, 127);
		this.E0255324.Name = "lblServer";
		this.E0255324.Size = new System.Drawing.Size(56, 16);
		this.E0255324.TabIndex = 43;
		this.E0255324.Text = "Server:";
		this.cbbServer.Cursor = System.Windows.Forms.Cursors.Hand;
		this.cbbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbServer.FormattingEnabled = true;
		this.cbbServer.ItemHeight = 16;
		this.cbbServer.Location = new System.Drawing.Point(119, 122);
		this.cbbServer.Name = "cbbServer";
		this.cbbServer.Size = new System.Drawing.Size(226, 24);
		this.cbbServer.TabIndex = 46;
		this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabel2.Location = new System.Drawing.Point(153, 419);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(109, 16);
		this.linkLabel2.TabIndex = 50;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "(Xem điều khoản)";
		this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(0, 400);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(393, 16);
		this.label2.TabIndex = 49;
		this.label2.Text = "Khi đăng nhập, bạn đã đồng ý với điều khoản của chúng tôi!";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(393, 311);
		base.Controls.Add(this.linkLabel2);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.E0255324);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.bunifuCustomLabel8);
		base.Controls.Add(this.BC9E7FA9);
		base.Controls.Add(this.B707D8BD);
		base.Controls.Add(this.E53F0285);
		base.Controls.Add(this.F6168883);
		base.Controls.Add(this.FB8FFAB7);
		base.Controls.Add(this.DE2F7C11);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.lblStatus);
		base.Controls.Add(this.btnLogin);
		base.Controls.Add(this.bunifuCustomLabel3);
		base.Controls.Add(this.txbPassword);
		base.Controls.Add(this.FEA24402);
		base.Controls.Add(this.txbUserName);
		base.Controls.Add(this.bunifuCards1);
		base.Controls.Add(this.cbbServer);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fActive";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MAX CARE";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(AE927F24_FormClosing);
		base.Load += new System.EventHandler(AE927F24_Load);
		this.bunifuCards1.ResumeLayout(false);
		this.pnlHeader.ResumeLayout(false);
		this.pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.D813948C).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
