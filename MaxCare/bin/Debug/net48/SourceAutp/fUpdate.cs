using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

public class fUpdate : Form
{
	public static string string_0 = "https://minsoftware.xyz/file/" + Class3.string_1 + "/";

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private Label label1;

	private Timer timer_0;

	public fUpdate()
	{
		InitializeComponent();
	}

	private void fUpdate_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		if (Class1.smethod_0())
		{
			if (!Directory.Exists(Application.StartupPath + "\\update"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\update");
			}
			WebClient webClient = new WebClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			webClient.DownloadFileCompleted += method_2;
			Uri address = new Uri(string_0 + "update.ini");
			webClient.DownloadFileAsync(address, Application.StartupPath + "\\update\\update.ini");
		}
		else
		{
			MessageBox.Show("No internet connect.Please check your network!", "MIN Software");
		}
	}

	private double method_1(string string_1)
	{
		string text = "";
		int num = 0;
		for (int i = 0; i < string_1.Length; i++)
		{
			if (string_1[i] == '.')
			{
				if (num == 0)
				{
					num++;
					text += string_1[i];
				}
			}
			else
			{
				text += string_1[i];
			}
		}
		return Convert.ToDouble(text);
	}

	private void method_2(object sender, AsyncCompletedEventArgs e)
	{
		try
		{
			GClass0 gClass = new GClass0(Application.StartupPath + "\\update\\update.ini");
			string string_ = gClass.method_1("Version", Class3.string_1);
			double num = method_1(string_);
			GClass0 gClass2 = new GClass0(Application.StartupPath + "\\update.ini");
			string string_2 = gClass2.method_1("Version", Class3.string_1);
			double num2 = method_1(string_2);
			if (num > num2)
			{
				fUpdateContent fUpdateContent2 = new fUpdateContent();
				Hide();
				fUpdateContent2.Show();
				return;
			}
			MessageBox.Show("Bạn đang được sử dụng phiên bản mới nhất!", "MIN Software", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			try
			{
				Directory.Delete(Application.StartupPath + "\\update", recursive: true);
			}
			catch
			{
			}
			Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show("Update Error!\n" + ex.ToString(), "MIN Software", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Close();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdate));
		this.lblproccess = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.lblproccess.AutoSize = true;
		this.lblproccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblproccess.Location = new System.Drawing.Point(26, 17);
		this.lblproccess.Name = "lblproccess";
		this.lblproccess.Size = new System.Drawing.Size(172, 16);
		this.lblproccess.TabIndex = 2;
		this.lblproccess.Text = "Đang Kiểm Tra Phiên Bản ...";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.label1.Location = new System.Drawing.Point(26, 40);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(157, 16);
		this.label1.TabIndex = 3;
		this.label1.Text = "<<<   <<<   <<<   <<<   <<<   ";
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 200;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(233, 64);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.lblproccess);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fUpdate";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Auto Update";
		base.Load += new System.EventHandler(fUpdate_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
