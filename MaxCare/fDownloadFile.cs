using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fDownloadFile : Form
{
	[CompilerGenerated]
	private sealed class Class72
	{
		public fDownloadFile DF388132;

		public Uri uri_0;

		public string A41E3825;

		internal void method_0()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += DF388132.method_2;
			webClient.DownloadFileCompleted += DF388132.method_3;
			webClient.DownloadFileAsync(uri_0, A41E3825);
		}
	}

	[CompilerGenerated]
	private sealed class Class73
	{
		public DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0;

		public fDownloadFile fDownloadFile_0;

		internal void method_0()
		{
			double num = double.Parse(downloadProgressChangedEventArgs_0.BytesReceived.ToString());
			double num2 = double.Parse(downloadProgressChangedEventArgs_0.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			fDownloadFile_0.lblproccess.Text = $"Downloading ({int.Parse(Math.Truncate(d).ToString())}%)...";
			fDownloadFile_0.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		}
	}

	private string D9838E17 = "";

	private string string_0 = "";

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private ProgressBar progressBar1;

	public fDownloadFile(string string_1)
	{
		InitializeComponent();
		method_0();
		D9838E17 = string_1;
		string_0 = Path.GetFileName(D9838E17);
	}

	private void method_0()
	{
		Language.smethod_0(lblproccess);
	}

	private void fDownloadFile_Load(object sender, EventArgs e)
	{
		try
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			if (InternetConnection.smethod_0())
			{
				Uri uri_ = new Uri(D9838E17);
				Common.DeleteFile("download");
				Common.CreateFolder("download");
				method_1(uri_, "download\\" + string_0);
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Không co\u0301 kê\u0301t nô\u0301i Internet, vui lo\u0300ng kiê\u0309m tra la\u0323i!"));
				Close();
			}
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error: " + ex.Message, 2);
			Close();
		}
	}

	public void C69D58BA(string string_1, string AA33B39E)
	{
		DirectoryInfo eB = new DirectoryInfo(string_1);
		DirectoryInfo directoryInfo_ = new DirectoryInfo(AA33B39E);
		B334E92B(eB, directoryInfo_);
	}

	public void B334E92B(DirectoryInfo EB286037, DirectoryInfo directoryInfo_0)
	{
		Directory.CreateDirectory(directoryInfo_0.FullName);
		int num = 1;
		FileInfo[] files = EB286037.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			Application.DoEvents();
			fileInfo.CopyTo(Path.Combine(directoryInfo_0.FullName, fileInfo.Name), overwrite: true);
			num++;
		}
		DirectoryInfo[] directories = EB286037.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			DirectoryInfo directoryInfo_ = directoryInfo_0.CreateSubdirectory(directoryInfo.Name);
			B334E92B(directoryInfo, directoryInfo_);
		}
	}

	private void method_1(Uri uri_0, string E108810F)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += method_2;
			webClient.DownloadFileCompleted += method_3;
			webClient.DownloadFileAsync(uri_0, E108810F);
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_2(object sender, DownloadProgressChangedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			double num = double.Parse(e.BytesReceived.ToString());
			double num2 = double.Parse(e.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			lblproccess.Text = $"Downloading ({int.Parse(Math.Truncate(d).ToString())}%)...";
			progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		});
	}

	private void method_3(object sender, AsyncCompletedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = Language.GetValue("Unzip file...");
		});
		try
		{
			ZipFile.ExtractToDirectory("./download/" + string_0, "./download/");
			Common.DeleteFilex("./download/" + string_0);
			if (File.Exists("download\\driver\\win32\\chromedriver.exe"))
			{
				C69D58BA("download\\driver\\win32", "./");
			}
			else
			{
				C69D58BA("download", "./");
			}
			Common.DeleteFile("download");
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error: " + ex.Message, 2);
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
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
		this.lblproccess = new System.Windows.Forms.Label();
		this.progressBar1 = new System.Windows.Forms.ProgressBar();
		base.SuspendLayout();
		this.lblproccess.AutoSize = true;
		this.lblproccess.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblproccess.Location = new System.Drawing.Point(34, 22);
		this.lblproccess.Name = "lblproccess";
		this.lblproccess.Size = new System.Drawing.Size(125, 16);
		this.lblproccess.TabIndex = 1;
		this.lblproccess.Text = "Downloading (0%)...";
		this.progressBar1.Location = new System.Drawing.Point(37, 52);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new System.Drawing.Size(219, 23);
		this.progressBar1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(294, 104);
		base.Controls.Add(this.progressBar1);
		base.Controls.Add(this.lblproccess);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDownloadFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "frm_progress";
		base.Load += new System.EventHandler(fDownloadFile_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void EA84F217()
	{
		lblproccess.Text = Language.GetValue("Unzip file...");
	}

	[CompilerGenerated]
	private void method_4()
	{
		Close();
	}

	[CompilerGenerated]
	private void C59588B8()
	{
		Close();
	}
}
