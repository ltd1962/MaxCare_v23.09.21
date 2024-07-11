using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace fUpdate;

public class frm_progress : Form
{
	private IContainer components = null;

	private Label lblproccess;

	private Label label1;

	private Timer timer1;

	public frm_progress()
	{
		InitializeComponent();
	}

	private void frm_progress_Load(object sender, EventArgs e)
	{
		try
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			string hostname = fUpdate.hostname;
			if (InternetConnection.IsConnectedToInternet())
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFileCompleted += udcom_file;
				Uri address = new Uri(hostname + Tool.softname + ".zip");
				webClient.DownloadFileAsync(address, "./update/" + Tool.softname + ".zip");
			}
			else
			{
				MessageBox.Show("No internet connect.Please check your network!");
				Application.Exit();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}
	}

	private void udcom_file(object sender, AsyncCompletedEventArgs e)
	{
		try
		{
			if (Directory.Exists("./update/" + Tool.softname))
			{
				Directory.Delete("./update/" + Tool.softname, recursive: true);
			}
			ZipFile.ExtractToDirectory("./update/" + Tool.softname + ".zip", "./update/");
			try
			{
				string sourceDirectory = "./update/" + Tool.softname + "/";
				string startupPath = Application.StartupPath;
                
                Copy(sourceDirectory, startupPath);
            }
			catch (Exception ex)
			{
				MessageBox.Show("Update fail:" + ex.Message);
				return;
			}
			if (File.Exists("./update/" + Tool.softname + ".zip"))
			{
				File.Delete("./update/" + Tool.softname + ".zip");
			}
			if (Directory.Exists(("./update/" + Tool.softname) ?? ""))
			{
				Directory.Delete("./update/" + Tool.softname, recursive: true);
			}
			timer1.Stop();
			Copy("./update", "./");
			MessageBox.Show("Cập nhật thành công!", "LTDSoftware", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex2)
		{
			MessageBox.Show("Error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}
		finally
		{
			Application.Exit();
		}
	}

	public void Copy(string sourceDirectory, string targetDirectory)
	{
		DirectoryInfo source = new DirectoryInfo(sourceDirectory);
		DirectoryInfo target = new DirectoryInfo(targetDirectory);
		CopyAll(source, target);
	}

	public void CopyAll(DirectoryInfo source, DirectoryInfo target)
	{
		Directory.CreateDirectory(target.FullName);
		int num = 1;
		FileInfo[] files = source.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			Application.DoEvents();
			fileInfo.CopyTo(Path.Combine(target.FullName, fileInfo.Name), overwrite: true);
			num++;
		}
		DirectoryInfo[] directories = source.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			DirectoryInfo target2 = target.CreateSubdirectory(directoryInfo.Name);
			CopyAll(directoryInfo, target2);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_progress));
		this.lblproccess = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.lblproccess.AutoSize = true;
		this.lblproccess.Font = new System.Drawing.Font("Century Gothic", 9.75f);
		this.lblproccess.Location = new System.Drawing.Point(24, 20);
		this.lblproccess.Name = "lblproccess";
		this.lblproccess.Size = new System.Drawing.Size(167, 17);
		this.lblproccess.TabIndex = 1;
		this.lblproccess.Text = "Đang tải bản cập nhật...";
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(16, 46);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(188, 16);
		this.label1.TabIndex = 4;
		this.label1.Text = "<<<   <<<   <<<   <<<   ";
		this.timer1.Enabled = true;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(215, 71);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.lblproccess);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "frm_progress";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "frm_progress";
		base.Load += new System.EventHandler(frm_progress_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
