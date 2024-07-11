using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using update;

namespace fUpdate;

public class fUpdate : Form
{
	
	public static string hostname = "http://ltdsoftwarex.click/" + Tool.softname + "/";

	private IContainer components = null;

	private Label lblproccess;

	private Label label1;

	private Timer timer1;

	public fUpdate()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		checkversion();
	}

	private void checkversion()
	{
        if (!Directory.Exists(Application.StartupPath + "\\update"))
        {
            Directory.CreateDirectory(Application.StartupPath + "\\update");
        }
        if (InternetConnection.IsConnectedToInternet())
		{
			WebClient webClient = new WebClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			webClient.DownloadFileCompleted += udcom;
			Uri address = new Uri(hostname + "update.ini");
			webClient.DownloadFileAsync(address, "./update/update.ini");
		}
		else
		{
			MessageBox.Show("No internet connect.Please check your network!", "LTDSoftware", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private void udcom(object sender, AsyncCompletedEventArgs e)
	{
		try
		{
			IniFile iniFile = new IniFile("./update/update.ini");
			string text = iniFile.Read("Version", Tool.softname);
			double num = Convert.ToDouble(text.Replace(".", "").Insert(1, "."));
			IniFile iniFile2 = new IniFile("update.ini");
			string text2 = iniFile2.Read("Version", Tool.softname);
			double num2 = Convert.ToDouble(text2.Replace(".", "").Insert(1, "."));
			if (num > num2)
			{
				fUpdateContent fUpdateContent2 = new fUpdateContent();
				Hide();
				fUpdateContent2.Show();
			}
			else
			{
				MessageBox.Show("Bạn đang được sử dụng phiên bản mới nhất!", "LTDSoftware", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                try
                {
                    Directory.Delete(Application.StartupPath + "\\update", true);
                }
                catch
                {
                }
                Close();
			}
		}
		catch
		{
			MessageBox.Show("Lô\u0303i update!", "LTDSoftware", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Close();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(global::fUpdate.fUpdate));
		this.lblproccess = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.lblproccess.AutoSize = true;
		this.lblproccess.Font = new System.Drawing.Font("Century Gothic", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblproccess.Location = new System.Drawing.Point(26, 17);
		this.lblproccess.Name = "lblproccess";
		this.lblproccess.Size = new System.Drawing.Size(184, 17);
		this.lblproccess.TabIndex = 2;
		this.lblproccess.Text = "Đang Kiểm Tra Phiên Bản ...";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75f);
		this.label1.Location = new System.Drawing.Point(26, 40);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(188, 17);
		this.label1.TabIndex = 3;
		this.label1.Text = "<<<   <<<   <<<   <<<   <<<   ";
		this.timer1.Enabled = true;
		this.timer1.Interval = 200;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(233, 64);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.lblproccess);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fUpdate";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cập nhật phần mềm";
		base.Load += new System.EventHandler(Form1_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
