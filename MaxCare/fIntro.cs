using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using maxcare.Properties;

public class fIntro : Form
{
	private IContainer EF883CAF;

	private ProgressBar B79CDDA2;

	private Timer timer_0;

	private Timer C6B27001;

	private Label label7;

	private ucContact D4939700;

	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint B2B1A736, StringBuilder FEB54D31, uint F20D4036);

	public fIntro()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void fIntro_Load(object sender, EventArgs e)
	{
		timer_0.Tick += timer_0_Tick;
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			timer_0.Stop();
			try
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
				string text = SettingsTool.GetSettings("settingLogin").GetValue("UserName");
				string text2 = SettingsTool.GetSettings("settingLogin").GetValue("PassWord");
				if (text == "" || text2 == "")
				{
					text = Settings.Default.UserName;
					text2 = Settings.Default.PassWord;
					if (text != "" || text2 != "")
					{
						SettingsTool.GetSettings("settingLogin").GetJson("UserName", text);
						SettingsTool.GetSettings("settingLogin").GetJson("PassWord", text2);
						SettingsTool.Save("settingLogin");
					}
				}
				if (text == "" || text2 == "" || !Common.IsValidMail(text))
				{
					Hide();
					new fActive(1).ShowDialog();
					return;
				}
				string text3 = Common.FF88D40C(text, text2);
				if (text3.StartsWith("0|"))
				{
					Hide();
					new fActive(text3.Substring(2)).ShowDialog();
					return;
				}
				text3 = text3.Substring(2);
				Hide();
				try
				{
					new fMain(text3).ShowDialog();
				}
				catch (Exception)
				{
					new fActive("").ShowDialog();
				}
				try
				{
					Environment.Exit(0);
					return;
				}
				catch (Exception)
				{
					Application.Exit();
					return;
				}
			}
			catch (Exception exception_)
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!", 2);
				Common.ExportError(null, exception_, "Run Program");
				Close();
				return;
			}
		}
		base.Opacity += 0.05;
	}

	private void CA0CCE94(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			timer_0.Stop();
			Close();
		}
		else
		{
			base.Opacity -= 0.05;
		}
	}

	private void C6B27001_Tick(object sender, EventArgs e)
	{
		if (B79CDDA2.Value < 90)
		{
			B79CDDA2.Value += 10;
		}
		else
		{
			C6B27001.Stop();
		}
	}

	protected override void Dispose(bool ABBA3BA8)
	{
		if (ABBA3BA8 && EF883CAF != null)
		{
			EF883CAF.Dispose();
		}
		base.Dispose(ABBA3BA8);
	}

	private void InitializeComponent()
	{
		EF883CAF = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fIntro));
		B79CDDA2 = new ProgressBar();
		timer_0 = new Timer(EF883CAF);
		C6B27001 = new Timer(EF883CAF);
		label7 = new Label();
		D4939700 = new ucContact();
		SuspendLayout();
		B79CDDA2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		B79CDDA2.Location = new Point(38, 508);
		B79CDDA2.Name = "progressBar";
		B79CDDA2.Size = new Size(668, 23);
		B79CDDA2.Step = 50;
		B79CDDA2.TabIndex = 7;
		timer_0.Interval = 30;
		C6B27001.Enabled = true;
		C6B27001.Tick += C6B27001_Tick;
		label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label7.ForeColor = Color.DarkViolet;
		label7.Location = new Point(556, 488);
		label7.Name = "label7";
		label7.Size = new Size(154, 16);
		label7.TabIndex = 9;
		label7.Text = "Đang kiểm tra thông tin...";
		D4939700.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D4939700.Location = new Point(13, 13);
		D4939700.Margin = new Padding(4);
		D4939700.Name = "ucContact1";
		D4939700.Size = new Size(714, 470);
		D4939700.TabIndex = 10;
		base.AutoScaleMode = AutoScaleMode.None;
		BackColor = Color.WhiteSmoke;
		base.ClientSize = new Size(746, 543);
		base.Controls.Add(D4939700);
		base.Controls.Add(label7);
		base.Controls.Add(B79CDDA2);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "fIntro";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Kiểm tra thông tin";
		base.Load += fIntro_Load;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
